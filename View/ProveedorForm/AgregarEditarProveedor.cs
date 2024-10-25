using RotiseriaDes.Interface;
using RotiseriaDes.Modelos;
using RotiseriaDes.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RotiseriaDes.View.ProveedorForm
{
    public partial class AgregarEditarProveedor : Form
    {
        IGenericService<Proveedor> proveedorService = new GenericService<Proveedor>();
        Proveedor proveedor;
        public AgregarEditarProveedor()
        {
            InitializeComponent();
            proveedor = new Proveedor();
        }

        public AgregarEditarProveedor(int idEditar)
        {
            InitializeComponent();
            CargarDatosProveedorAEditar(idEditar);
        }

        private async void CargarDatosProveedorAEditar(int idEditar)
        {
            // Obtiene los datos del cliente desde el servicio usando el ID proporcionado
            proveedor = await proveedorService.GetByIdAsync(idEditar);

            // Verifica si el cliente existe y luego llena los campos del formulario
            if (proveedor != null)
            {
                txtNombre.Text = proveedor.Nombre;
                txtTelefono.Text = proveedor.Telefono;
                txtEmail.Text = proveedor.Email;
                txtContacto.Text = proveedor.Contacto;
            }
            else
            {
                MessageBox.Show("No se encontró el cliente con el ID especificado.");
            }
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            // Asigna los valores del formulario al objeto cliente
            proveedor.Nombre = txtNombre.Text;
            proveedor.Contacto = txtContacto.Text;
            proveedor.Telefono = txtTelefono.Text;
            proveedor.Email = txtEmail.Text;

            // Verifica si es un cliente nuevo o una actualización
            if (proveedor.Id == 0)
            {
                await proveedorService.AddAsync(proveedor);
            }
            else
            {
                await proveedorService.UpdateAsync(proveedor);
            }

            this.Close();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
