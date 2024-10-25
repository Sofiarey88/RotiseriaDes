
using RotiseriaDes.View.ClienteForm;
using RotiseriaDes.View.PedidoForm;
using RotiseriaDes.View.ProductoForm;
using RotiseriaDes.View.ProveedorForm;

namespace RotiseriaDes
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void salirDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientesView clientesView = new ClientesView();
            clientesView.ShowDialog();
        }

        private void pedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PedidosView pedidosView = new PedidosView();
            pedidosView.ShowDialog();
        }

        private void proveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProveedoresView proveedoresView = new ProveedoresView();
            proveedoresView.ShowDialog();
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductosView productosView = new ProductosView();
            productosView.ShowDialog();
        }
    }
}
