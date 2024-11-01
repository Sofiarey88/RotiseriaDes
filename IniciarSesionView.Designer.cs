namespace RotiseriaDes.View.Login
{
    partial class IniciarSesionView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IniciarSesionView));
            label1 = new Label();
            label2 = new Label();
            btnIngresar = new FontAwesome.Sharp.IconButton();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            txtEmail = new TextBox();
            txtContraseña = new TextBox();
            checkContra = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(106, 121);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(106, 223);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 1;
            label2.Text = "Contraseña:";
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.FromArgb(128, 255, 128);
            btnIngresar.IconChar = FontAwesome.Sharp.IconChar.File;
            btnIngresar.IconColor = Color.Black;
            btnIngresar.IconFont = FontAwesome.Sharp.IconFont.Regular;
            btnIngresar.IconSize = 24;
            btnIngresar.ImageAlign = ContentAlignment.MiddleLeft;
            btnIngresar.Location = new Point(154, 343);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(150, 40);
            btnIngresar.TabIndex = 7;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(255, 128, 128);
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.File;
            btnCancelar.IconColor = Color.Black;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Regular;
            btnCancelar.IconSize = 24;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(415, 343);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(150, 40);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(246, 118);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(339, 27);
            txtEmail.TabIndex = 9;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(246, 216);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(335, 27);
            txtContraseña.TabIndex = 10;
            // 
            // checkContra
            // 
            checkContra.AutoSize = true;
            checkContra.Location = new Point(304, 269);
            checkContra.Name = "checkContra";
            checkContra.Size = new Size(128, 24);
            checkContra.TabIndex = 11;
            checkContra.Text = "Ver contraseña";
            checkContra.UseVisualStyleBackColor = true;
            checkContra.CheckedChanged += checkContra_CheckedChanged;
            // 
            // IniciarSesionView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(702, 453);
            Controls.Add(checkContra);
            Controls.Add(txtContraseña);
            Controls.Add(txtEmail);
            Controls.Add(btnCancelar);
            Controls.Add(btnIngresar);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "IniciarSesionView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "IniciarSesionView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private FontAwesome.Sharp.IconButton btnIngresar;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private TextBox txtEmail;
        private TextBox txtContraseña;
        private CheckBox checkContra;
    }
}