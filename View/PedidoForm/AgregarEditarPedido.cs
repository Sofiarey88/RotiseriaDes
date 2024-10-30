using RotiseriaDes.Interface;
using RotiseriaDes.Modelos;
using RotiseriaDes.Service;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RotiseriaDes.View.PedidoForm
{
    public partial class AgregarEditarPedido : Form
    {
        private readonly IGenericService<Pedido> pedidoService = new GenericService<Pedido>();
        private readonly IGenericService<Cliente> clienteService = new GenericService<Cliente>();
        private readonly IGenericService<Producto> productoService = new GenericService<Producto>();

        private Pedido pedido;
        private List<Cliente> clientes;
        private List<Producto> productos;

        public AgregarEditarPedido()
        {
            InitializeComponent();
            pedido = new Pedido();
            CargarClientes();
            CargarProducto();
            txtEstado.Text = "Pendiente";  // Asigna "Pendiente" como estado predeterminado para nuevos pedidos
        }

        private async  void CargarProducto()
        {
            try
            {
                productos = await productoService.GetAllAsync();
                cmbProducto.DataSource = productos;
                cmbProducto.DisplayMember = "Nombre";
                cmbProducto.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public AgregarEditarPedido(int idEditar) : this()
        {
            CargarDatosPedidoAEditar(idEditar);
        }

        private async void CargarClientes()
        {
            try
            {
                clientes = await clienteService.GetAllAsync();
                comboBoxClientes.DataSource = clientes;
                comboBoxClientes.DisplayMember = "Nombre";
                comboBoxClientes.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar clientes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void CargarDatosPedidoAEditar(int idEditar)
        {
            try
            {
                pedido = await pedidoService.GetByIdAsync(idEditar);
                if (pedido != null)
                {
                    cmbProducto.SelectedValue = pedido.ProductoId;
                    comboBoxClientes.SelectedValue = pedido.ClienteId;
                    dateTimePicker1.Value = pedido.Fecha;
                    txtEstado.Text = pedido.Estado;
                }
                else
                {
                    MessageBox.Show("No se encontró el pedido con el ID especificado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos del pedido: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                pedido.ProductoId = (int)cmbProducto.SelectedValue;
                pedido.ClienteId = (int)comboBoxClientes.SelectedValue;
                pedido.Fecha = dateTimePicker1.Value;
                pedido.Estado = txtEstado.Text;

                // Verifica si es un pedido nuevo o una actualización
                if (pedido.Id == 0)
                {
                    await pedidoService.AddAsync(pedido);
                }
                else
                {
                    await pedidoService.UpdateAsync(pedido);
                }

                MessageBox.Show("Pedido guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el pedido: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
