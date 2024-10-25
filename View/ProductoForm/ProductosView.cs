using RotiseriaDes.Interface;
using RotiseriaDes.Modelos;
using RotiseriaDes.Service;
using RotiseriaDes.View.PedidoForm;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RotiseriaDes.View.ProductoForm
{
    public partial class ProductosView : Form
    {
        IGenericService<Producto> productoService = new GenericService<Producto>();

        public ProductosView()
        {
            InitializeComponent();
            CargarGrilla();
        }

        private async Task CargarGrilla()
        {
            dataGridProductos.DataSource = await productoService.GetAllAsync();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridProductos.CurrentRow != null)
            {
                var idEditar = (int)dataGridProductos.CurrentRow.Cells[0].Value;

                // Crear instancia del formulario en modo edición con el ID del pedido a editar
                var agregarEditarProducto = new AgregarEditarProducto(idEditar);

                // Mostrar el formulario de edición
                agregarEditarProducto.ShowDialog();

                // Actualizar la grilla después de cerrar el formulario de edición
                await CargarGrilla();
            }
            else
            {
                MessageBox.Show("Seleccione un pedido para editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarEditarProducto agregarEditarProducto = new AgregarEditarProducto();
            agregarEditarProducto.ShowDialog();
            await CargarGrilla(); // Vuelve a cargar la grilla después de agregar
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridProductos.CurrentRow != null) // Verifica que haya una fila seleccionada
            {
                var idEliminar = (int)dataGridProductos.CurrentRow.Cells[0].Value;
                var nombreEliminar = (string)dataGridProductos.CurrentRow.Cells[1].Value;
                var respuesta = MessageBox.Show($"¿Está seguro que quiere borrar el producto {nombreEliminar}?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    await productoService.DeleteAsync(idEliminar); // Espera a que se complete la eliminación
                    await CargarGrilla(); // Vuelve a cargar la grilla después de eliminar
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un producto para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
