namespace RotiseriaDes.View.ProveedorForm
{
    partial class AgregarEditarProveedor
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
            txtEmail = new TextBox();
            txtTelefono = new TextBox();
            txtNombre = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtContacto = new TextBox();
            label5 = new Label();
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
            btnCancelar.Location = new Point(553, 425);
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
            btnGuardar.Location = new Point(195, 425);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(124, 40);
            btnGuardar.TabIndex = 18;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(334, 317);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(306, 27);
            txtEmail.TabIndex = 17;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(334, 132);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(306, 27);
            txtTelefono.TabIndex = 15;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(334, 73);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(306, 27);
            txtNombre.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(161, 317);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 13;
            label4.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(161, 132);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 11;
            label2.Text = "Telefono:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(161, 73);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 10;
            label1.Text = "Nombre:";
            // 
            // txtContacto
            // 
            txtContacto.Location = new Point(334, 221);
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(301, 27);
            txtContacto.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(159, 224);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 21;
            label5.Text = "Contacto:";
            // 
            // AgregarEditarProveedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(839, 536);
            Controls.Add(label5);
            Controls.Add(txtContacto);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefono);
            Controls.Add(txtNombre);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AgregarEditarProveedor";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AgregarEditarProveedor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private TextBox txtEmail;
        private TextBox txtTelefono;
        private TextBox txtNombre;
        private Label label4;
        private Label label2;
        private Label label1;
        private TextBox txtContacto;
        private Label label5;
    }
}