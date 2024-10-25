namespace RotiseriaDes.View.ProductoForm
{
    partial class AgregarEditarProducto
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
            btnCancelar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            txtPrecio = new TextBox();
            txtDescripcion = new TextBox();
            txtNombre = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(255, 128, 128);
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Cake;
            btnCancelar.IconColor = Color.Black;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Regular;
            btnCancelar.IconSize = 24;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(534, 382);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(124, 40);
            btnCancelar.TabIndex = 19;
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
            btnGuardar.Location = new Point(191, 382);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(124, 40);
            btnGuardar.TabIndex = 18;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(352, 278);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(306, 27);
            txtPrecio.TabIndex = 16;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(352, 194);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(306, 27);
            txtDescripcion.TabIndex = 15;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(352, 129);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(306, 27);
            txtNombre.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(142, 278);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 12;
            label3.Text = "Precio:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(142, 201);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 11;
            label2.Text = "Descripción:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(142, 129);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 10;
            label1.Text = "Nombre:";
            // 
            // AgregarEditarProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(809, 488);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(txtPrecio);
            Controls.Add(txtDescripcion);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AgregarEditarProducto";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AgregarEditarProducto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private TextBox txtPrecio;
        private TextBox txtDescripcion;
        private TextBox txtNombre;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}