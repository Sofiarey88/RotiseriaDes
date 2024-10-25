using RotiseriaDes.Interface;
using RotiseriaDes.Modelos;
using RotiseriaDes.Service;
using RotiseriaDes.View.ClienteForm;
using RotiseriaDes.View.PedidoForm;
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
    public partial class ProveedoresView : Form
    {
        IGenericService<Proveedor> proveedoresService = new GenericService<Proveedor>();

        public ProveedoresView()
        {
            InitializeComponent();
            CargarGrilla(); // Cargar los datos al inicializar el formulario
        }

        // Método para cargar la grilla de proveedores de manera asíncrona
        private async Task CargarGrilla()
        {
            var proveedores = await proveedoresService.GetAllAsync(); // Espera la respuesta asíncrona
            dataGridProveedores.DataSource = proveedores; // Asignar los datos obtenidos a la grilla
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close(); // Cerrar la ventana actual
        }

        // Manejo del botón de agregar un nuevo proveedor
        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            var agregarEditarProveedor = new AgregarEditarProveedor();
            agregarEditarProveedor.ShowDialog(); // Mostrar el formulario para agregar o editar
            await CargarGrilla(); // Recargar la grilla después de agregar un proveedor
        }

        // Manejo del botón de editar un proveedor existente
        private async void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridProveedores.CurrentRow != null)
            {
                var idEditar = (int)dataGridProveedores.CurrentRow.Cells[0].Value; // Obtener el ID del proveedor seleccionado
                var agregarEditarProveedor = new AgregarEditarProveedor(idEditar); // Pasar el ID para editar
                agregarEditarProveedor.ShowDialog(); // Mostrar el formulario de edición
                await CargarGrilla(); // Recargar la grilla después de editar
            }
            else
            {
                MessageBox.Show("Seleccione un proveedor para editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); // Mostrar mensaje si no se selecciona un proveedor
            }
        }

        // Manejo del botón para eliminar un proveedor
        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridProveedores.CurrentRow != null)
            {
                var idEliminar = (int)dataGridProveedores.CurrentRow.Cells[0].Value; // Obtener el ID del proveedor a eliminar
                var nombreEliminar = (string)dataGridProveedores.CurrentRow.Cells[1].Value; // Obtener el nombre del proveedor a eliminar
                var respuesta = MessageBox.Show($"¿Está seguro que quiere borrar al proveedor {nombreEliminar}?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    await proveedoresService.DeleteAsync(idEliminar); // Eliminar de manera asíncrona
                    await CargarGrilla(); // Recargar la grilla después de eliminar
                }
            }
            else
            {
                MessageBox.Show("Seleccione un proveedor para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); // Mostrar mensaje si no se selecciona un proveedor
            }
        }
    }
}
