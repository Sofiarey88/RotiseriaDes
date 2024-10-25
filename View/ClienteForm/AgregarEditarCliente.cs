using RotiseriaDes.Interface;
using RotiseriaDes.Modelos;
using RotiseriaDes.Service;

namespace RotiseriaDes.View.ClienteForm
{
    public partial class AgregarEditarCliente : Form
    {
        IGenericService<Cliente> clienteService = new GenericService<Cliente>();
        Cliente cliente;

        public AgregarEditarCliente()
        {
            InitializeComponent();
            cliente = new Cliente(); 
        }

        public AgregarEditarCliente(int idEditar)
        {
            InitializeComponent();
            CargarDatosClientesAEditar(idEditar); 
        }

        private async void CargarDatosClientesAEditar(int idEditar)
        {
            // Obtiene los datos del cliente desde el servicio usando el ID proporcionado
            cliente = await clienteService.GetByIdAsync(idEditar);

            // Verifica si el cliente existe y luego llena los campos del formulario
            if (cliente != null)
            {
                txtNombre.Text = cliente.Nombre;
                txtDireccion.Text = cliente.Direccion;
                txtTelefono.Text = cliente.Telefono;
                txtEmail.Text = cliente.Email;
            }
            else
            {
                MessageBox.Show("No se encontró el cliente con el ID especificado.");
            }
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            // Asigna los valores del formulario al objeto cliente
            cliente.Nombre = txtNombre.Text;
            cliente.Direccion = txtDireccion.Text;
            cliente.Telefono = txtTelefono.Text;
            cliente.Email = txtEmail.Text;

            // Verifica si es un cliente nuevo o una actualización
            if (cliente.Id == 0)
            {
                await clienteService.AddAsync(cliente);
            }
            else
            {
                await clienteService.UpdateAsync(cliente);
            }

            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
