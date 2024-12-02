namespace RotiseriaDes.View.PedidoForm
{
    partial class AgregarEditarPedido
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
            label1 = new Label();
            comboBoxClientes = new ComboBox();
            label2 = new Label();
            Estado = new Label();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            dateTimePicker1 = new DateTimePicker();
            txtEstado = new TextBox();
            label3 = new Label();
            cmbProducto = new ComboBox();
            NuevoClienteAgre = new Button();
            NuevoProductoAgre = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(90, 58);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 0;
            label1.Text = "ClienteId:";
            // 
            // comboBoxClientes
            // 
            comboBoxClientes.FormattingEnabled = true;
            comboBoxClientes.Location = new Point(185, 58);
            comboBoxClientes.Name = "comboBoxClientes";
            comboBoxClientes.Size = new Size(356, 28);
            comboBoxClientes.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(90, 156);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 2;
            label2.Text = "Fecha:";
            // 
            // Estado
            // 
            Estado.AutoSize = true;
            Estado.Location = new Point(90, 244);
            Estado.Name = "Estado";
            Estado.Size = new Size(54, 20);
            Estado.TabIndex = 4;
            Estado.Text = "Estado";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(255, 128, 128);
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Cake;
            btnCancelar.IconColor = Color.Black;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Regular;
            btnCancelar.IconSize = 24;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(495, 402);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(124, 40);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(128, 255, 128);
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnGuardar.IconColor = Color.Black;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Regular;
            btnGuardar.IconSize = 24;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(159, 402);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(124, 40);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(185, 156);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(356, 27);
            dateTimePicker1.TabIndex = 12;
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(185, 244);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(356, 27);
            txtEstado.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(90, 318);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 14;
            label3.Text = "Producto:";
            // 
            // cmbProducto
            // 
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(185, 319);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(356, 28);
            cmbProducto.TabIndex = 15;
            // 
            // NuevoClienteAgre
            // 
            NuevoClienteAgre.BackColor = Color.SandyBrown;
            NuevoClienteAgre.Location = new Point(603, 58);
            NuevoClienteAgre.Name = "NuevoClienteAgre";
            NuevoClienteAgre.Size = new Size(137, 29);
            NuevoClienteAgre.TabIndex = 16;
            NuevoClienteAgre.Text = "Nuevo Cliente";
            NuevoClienteAgre.UseVisualStyleBackColor = false;
            NuevoClienteAgre.Click += NuevoClienteAgre_Click;
            // 
            // NuevoProductoAgre
            // 
            NuevoProductoAgre.BackColor = Color.SandyBrown;
            NuevoProductoAgre.Location = new Point(603, 319);
            NuevoProductoAgre.Name = "NuevoProductoAgre";
            NuevoProductoAgre.Size = new Size(137, 29);
            NuevoProductoAgre.TabIndex = 17;
            NuevoProductoAgre.Text = "Nuevo Producto";
            NuevoProductoAgre.UseVisualStyleBackColor = false;
            NuevoProductoAgre.Click += NuevoProductoAgre_Click;
            // 
            // AgregarEditarPedido
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(845, 482);
            Controls.Add(NuevoProductoAgre);
            Controls.Add(NuevoClienteAgre);
            Controls.Add(cmbProducto);
            Controls.Add(label3);
            Controls.Add(txtEstado);
            Controls.Add(dateTimePicker1);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(Estado);
            Controls.Add(label2);
            Controls.Add(comboBoxClientes);
            Controls.Add(label1);
            Name = "AgregarEditarPedido";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AgregarEditarPedido";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBoxClientes;
        private Label label2;
        private Label Estado;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private DateTimePicker dateTimePicker1;
        private TextBox txtEstado;
        private Label label3;
        private ComboBox cmbProducto;
        private Button NuevoClienteAgre;
        private Button NuevoProductoAgre;
    }
}