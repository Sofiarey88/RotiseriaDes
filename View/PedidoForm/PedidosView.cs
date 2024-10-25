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
        IGenericService<Pedido> pedidoService = new GenericService<Pedido>();
        IGenericService<Cliente> clienteService = new GenericService<Cliente>(); // Servicio para obtener clientes

        public PedidosView()
        {
            InitializeComponent();
            CargarGrilla();
        }

        private async Task CargarGrilla()
        {
            var pedidos = await pedidoService.GetAllAsync();
            var pedidosConNombreCliente = new List<dynamic>();

            // Cargar el nombre del cliente para cada pedido
            foreach (var pedido in pedidos)
            {
                var cliente = await clienteService.GetByIdAsync(pedido.ClienteId); // Obtener el cliente por ID
                pedidosConNombreCliente.Add(new
                {
                    pedido.Id,
                    NombreCliente = cliente?.Nombre, // Asignar nombre del cliente
                    pedido.Fecha,
                    pedido.Estado
                });
            }

            dataGridPedidos.DataSource = pedidosConNombreCliente;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarEditarPedido agregarEditarPedido = new AgregarEditarPedido();
            agregarEditarPedido.ShowDialog();
            await CargarGrilla();
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridPedidos.CurrentRow != null)
            {
                var idEliminar = (int)dataGridPedidos.CurrentRow.Cells[0].Value;
                var nombreEliminar = dataGridPedidos.CurrentRow.Cells[1].Value.ToString(); // Obtener nombre del cliente
                var respuesta = MessageBox.Show($"¿Está seguro que quiere borrar el pedido del cliente {nombreEliminar}?",
                                                "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    await pedidoService.DeleteAsync(idEliminar);
                    await CargarGrilla();
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

                // Crear instancia del formulario en modo edición con el ID del pedido a editar
                var agregarEditarPedido = new AgregarEditarPedido(idEditar);

                // Mostrar el formulario de edición
                agregarEditarPedido.ShowDialog();

                // Actualizar la grilla después de cerrar el formulario de edición
                await CargarGrilla();
            }
            else
            {
                MessageBox.Show("Seleccione un pedido para editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
