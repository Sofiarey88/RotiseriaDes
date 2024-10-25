using RotiseriaDes.Interface;
using RotiseriaDes.Modelos;
using RotiseriaDes.Service;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RotiseriaDes.View.ProductoForm
{
    public partial class AgregarEditarProducto : Form
    {
        private readonly IGenericService<Producto> productosService = new GenericService<Producto>();
        private Producto producto;

        public AgregarEditarProducto()
        {
            InitializeComponent();
            producto = new Producto();
            txtPrecio.Text = "0.00";  // Asigna un precio predeterminado para nuevos productos
        }

        public AgregarEditarProducto(int idEditar) : this()
        {
            CargarDatosProductoAEditar(idEditar);
        }

        private async void CargarDatosProductoAEditar(int idEditar)
        {
            try
            {
                producto = await productosService.GetByIdAsync(idEditar);
                if (producto != null)
                {
                    txtNombre.Text = producto.Nombre;
                    txtDescripcion.Text = producto.Descripcion;
                    txtPrecio.Text = producto.Precio.ToString("0.00");
                }
                else
                {
                    MessageBox.Show("No se encontró el producto con el ID especificado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos del producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Asigna los valores de los campos al objeto producto
                producto.Nombre = txtNombre.Text;
                producto.Descripcion = txtDescripcion.Text;

                if (decimal.TryParse(txtPrecio.Text, out decimal precio))
                {
                    producto.Precio = precio;

                    // Verifica si es un producto nuevo o una actualización
                    if (producto.Id == 0)
                    {
                        await productosService.AddAsync(producto);
                    }
                    else
                    {
                        await productosService.UpdateAsync(producto);
                    }

                    MessageBox.Show("Producto guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Por favor, ingresa un precio válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
