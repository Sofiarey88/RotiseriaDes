using RotiseriaDes.Interface;
using RotiseriaDes.Modelos;
using RotiseriaDes.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RotiseriaDes.View.ClienteForm
{
    public partial class ClientesView : Form
    {
        IGenericService<Cliente> clienteService = new GenericService<Cliente>();
        public ClientesView()
        {
            InitializeComponent();
            CargarGrilla();
        }

        private async Task CargarGrilla()
        {
            dataGridClientes.DataSource = await clienteService.GetAllAsync();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarEditarCliente agregarEditarCliente = new AgregarEditarCliente();
            agregarEditarCliente.ShowDialog();
            CargarGrilla();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var idEliminar = (int)dataGridClientes.CurrentRow.Cells[0].Value;
            var nombreEliminar = (string)dataGridClientes.CurrentRow.Cells[1].Value;
            var respuesta = MessageBox.Show($"¿Está seguro que quiere borrar al cliente {nombreEliminar}", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                clienteService.DeleteAsync(idEliminar);
                CargarGrilla();
            }
        }

        private async void btnEditar_Click(object sender, EventArgs e)
        {
            var idEditar = (int)dataGridClientes.CurrentRow.Cells[0].Value;
            AgregarEditarCliente agregarEditarCliente = new AgregarEditarCliente(idEditar);
            agregarEditarCliente.ShowDialog();
            CargarGrilla();

        }
    }
}
