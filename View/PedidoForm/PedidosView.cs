using RotiseriaDes.Interface;
using RotiseriaDes.Modelos;
using RotiseriaDes.Service;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RotiseriaDes.View.PedidoForm
{
    public partial class PedidosView : Form
    {
        private readonly IGenericService<Pedido> _pedidoService = new GenericService<Pedido>();
        private readonly IGenericService<Cliente> _clienteService = new GenericService<Cliente>();
        private readonly IGenericService<Producto> _productoService = new GenericService<Producto>();

        public PedidosView()
        {
            InitializeComponent();
            CargarGrilla();
        }

        private async Task CargarGrilla()
        {
            try
            {
                var pedidos = await _pedidoService.GetAllAsync();
                var pedidosConDetalles = new List<dynamic>();

                foreach (var pedido in pedidos)
                {
                    var cliente = await ObtenerClientePorIdAsync(pedido.ClienteId);
                    var producto = await ObtenerProductoPorIdAsync(pedido.ProductoId);

                    pedidosConDetalles.Add(new
                    {
                        pedido.Id,
                        NombreCliente = cliente?.Nombre ?? "Cliente desconocido",
                        NombreProducto = producto?.Nombre ?? "Producto desconocido",
                        pedido.Fecha,
                        pedido.Estado,
                        PrecioProducto = producto?.Precio.ToString("F2") ?? "0.00"
                    });
                }

                dataGridPedidos.DataSource = pedidosConDetalles;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los pedidos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task<Cliente> ObtenerClientePorIdAsync(int clienteId)
        {
            try
            {
                return await _clienteService.GetByIdAsync(clienteId);
            }
            catch
            {
                MessageBox.Show($"No se pudo obtener el cliente con ID {clienteId}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        private async Task<Producto> ObtenerProductoPorIdAsync(int productoId)
        {
            try
            {
                return await _productoService.GetByIdAsync(productoId);
            }
            catch
            {
                MessageBox.Show($"No se pudo obtener el producto con ID {productoId}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            using (var agregarEditarPedido = new AgregarEditarPedido())
            {
                agregarEditarPedido.ShowDialog();
            }
            await CargarGrilla();
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridPedidos.CurrentRow != null)
            {
                var idEliminar = (int)dataGridPedidos.CurrentRow.Cells[0].Value;
                var nombreEliminar = dataGridPedidos.CurrentRow.Cells[1].Value.ToString();

                var respuesta = MessageBox.Show($"¿Está seguro que quiere borrar el pedido del cliente {nombreEliminar}?",
                                                "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    try
                    {
                        await _pedidoService.DeleteAsync(idEliminar);
                        await CargarGrilla();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al eliminar el pedido: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un pedido para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridPedidos.CurrentRow != null)
            {
                var idEditar = (int)dataGridPedidos.CurrentRow.Cells[0].Value;

                using (var agregarEditarPedido = new AgregarEditarPedido(idEditar))
                {
                    agregarEditarPedido.ShowDialog();
                }

                await CargarGrilla();
            }
            else
            {
                MessageBox.Show("Seleccione un pedido para editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
