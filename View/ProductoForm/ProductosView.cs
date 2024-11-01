using RotiseriaDes.Interface;
using RotiseriaDes.Modelos;
using RotiseriaDes.Service;
using RotiseriaDes.View.PedidoForm;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RotiseriaDes.View.ProductoForm
{
    public partial class ProductosView : Form
    {
        private readonly IGenericService<Producto> _productoService = new GenericService<Producto>();

        public ProductosView()
        {
            InitializeComponent();
            CargarGrilla();
        }

        private async Task CargarGrilla()
        {
            var productos = await _productoService.GetAllAsync();
            var productosConPrecioFormateado = new List<dynamic>();

            // Crear una lista de productos con el precio formateado
            foreach (var producto in productos)
            {
                productosConPrecioFormateado.Add(new
                {
                    producto.Id,
                    producto.Nombre,
                    Precio = producto.Precio.ToString("F2") // Formatear el precio con dos decimales
                });
            }

            dataGridProductos.DataSource = productosConPrecioFormateado;
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

                // Crear instancia del formulario en modo edición con el ID del producto a editar
                var agregarEditarProducto = new AgregarEditarProducto(idEditar);

                // Mostrar el formulario de edición
                agregarEditarProducto.ShowDialog();

                // Actualizar la grilla después de cerrar el formulario de edición
                await CargarGrilla();
            }
            else
            {
                MessageBox.Show("Seleccione un producto para editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            var agregarEditarProducto = new AgregarEditarProducto();
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
                    await _productoService.DeleteAsync(idEliminar); // Espera a que se complete la eliminación
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
