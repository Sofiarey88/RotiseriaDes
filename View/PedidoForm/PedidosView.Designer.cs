namespace RotiseriaDes.View.PedidoForm
{
    partial class PedidosView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSalir = new FontAwesome.Sharp.IconButton();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnEditar = new FontAwesome.Sharp.IconButton();
            btnAgregar = new FontAwesome.Sharp.IconButton();
            dataGridPedidos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridPedidos).BeginInit();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(128, 128, 255);
            btnSalir.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            btnSalir.IconColor = Color.Black;
            btnSalir.IconFont = FontAwesome.Sharp.IconFont.Regular;
            btnSalir.IconSize = 24;
            btnSalir.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalir.Location = new Point(848, 510);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(150, 40);
            btnSalir.TabIndex = 9;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(255, 128, 128);
            btnEliminar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            btnEliminar.IconColor = Color.Black;
            btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Regular;
            btnEliminar.IconSize = 24;
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(570, 451);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(150, 40);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(255, 255, 128);
            btnEditar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            btnEditar.IconColor = Color.Black;
            btnEditar.IconFont = FontAwesome.Sharp.IconFont.Regular;
            btnEditar.IconSize = 24;
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.Location = new Point(326, 451);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(150, 40);
            btnEditar.TabIndex = 7;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(128, 255, 128);
            btnAgregar.IconChar = FontAwesome.Sharp.IconChar.File;
            btnAgregar.IconColor = Color.Black;
            btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Regular;
            btnAgregar.IconSize = 24;
            btnAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregar.Location = new Point(79, 451);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(150, 40);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dataGridPedidos
            // 
            dataGridPedidos.AllowUserToAddRows = false;
            dataGridPedidos.AllowUserToDeleteRows = false;
            dataGridPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridPedidos.Location = new Point(48, 71);
            dataGridPedidos.Name = "dataGridPedidos";
            dataGridPedidos.ReadOnly = true;
            dataGridPedidos.RowHeadersWidth = 51;
            dataGridPedidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridPedidos.Size = new Size(935, 329);
            dataGridPedidos.TabIndex = 5;
            // 
            // PedidosView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(1056, 586);
            Controls.Add(btnSalir);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Controls.Add(dataGridPedidos);
            Name = "PedidosView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "PedidosView";
            ((System.ComponentModel.ISupportInitialize)dataGridPedidos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnSalir;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private DataGridView dataGridPedidos;
    }
}