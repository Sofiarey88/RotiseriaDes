namespace RotiseriaDes
{
    partial class MenuPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            menuStrip1 = new MenuStrip();
            principalToolStripMenuItem = new FontAwesome.Sharp.IconMenuItem();
            baseToolStripMenuItem = new FontAwesome.Sharp.IconMenuItem();
            clienteToolStripMenuItem = new FontAwesome.Sharp.IconMenuItem();
            productoToolStripMenuItem = new FontAwesome.Sharp.IconMenuItem();
            proveedorToolStripMenuItem = new FontAwesome.Sharp.IconMenuItem();
            pedidoToolStripMenuItem = new FontAwesome.Sharp.IconMenuItem();
            salirToolStripMenuItem = new FontAwesome.Sharp.IconMenuItem();
            salirDelSistemaToolStripMenuItem = new FontAwesome.Sharp.IconMenuItem();
            bindingSource1 = new BindingSource(components);
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { principalToolStripMenuItem, baseToolStripMenuItem, salirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1041, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // principalToolStripMenuItem
            // 
            principalToolStripMenuItem.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            principalToolStripMenuItem.IconColor = Color.Black;
            principalToolStripMenuItem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            principalToolStripMenuItem.Name = "principalToolStripMenuItem";
            principalToolStripMenuItem.Size = new Size(100, 24);
            principalToolStripMenuItem.Text = "Principal";
            // 
            // baseToolStripMenuItem
            // 
            baseToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clienteToolStripMenuItem, productoToolStripMenuItem, proveedorToolStripMenuItem, pedidoToolStripMenuItem });
            baseToolStripMenuItem.IconChar = FontAwesome.Sharp.IconChar.Database;
            baseToolStripMenuItem.IconColor = Color.Black;
            baseToolStripMenuItem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            baseToolStripMenuItem.Name = "baseToolStripMenuItem";
            baseToolStripMenuItem.Size = new Size(74, 24);
            baseToolStripMenuItem.Text = "Base";
            // 
            // clienteToolStripMenuItem
            // 
            clienteToolStripMenuItem.IconChar = FontAwesome.Sharp.IconChar.User;
            clienteToolStripMenuItem.IconColor = Color.Black;
            clienteToolStripMenuItem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            clienteToolStripMenuItem.Size = new Size(224, 26);
            clienteToolStripMenuItem.Text = "Cliente";
            clienteToolStripMenuItem.Click += clienteToolStripMenuItem_Click;
            // 
            // productoToolStripMenuItem
            // 
            productoToolStripMenuItem.IconChar = FontAwesome.Sharp.IconChar.DollyBox;
            productoToolStripMenuItem.IconColor = Color.Black;
            productoToolStripMenuItem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            productoToolStripMenuItem.Name = "productoToolStripMenuItem";
            productoToolStripMenuItem.Size = new Size(224, 26);
            productoToolStripMenuItem.Text = "Producto";
            productoToolStripMenuItem.Click += productoToolStripMenuItem_Click;
            // 
            // proveedorToolStripMenuItem
            // 
            proveedorToolStripMenuItem.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            proveedorToolStripMenuItem.IconColor = Color.Black;
            proveedorToolStripMenuItem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            proveedorToolStripMenuItem.Name = "proveedorToolStripMenuItem";
            proveedorToolStripMenuItem.Size = new Size(224, 26);
            proveedorToolStripMenuItem.Text = "Proveedor";
            proveedorToolStripMenuItem.Click += proveedorToolStripMenuItem_Click;
            // 
            // pedidoToolStripMenuItem
            // 
            pedidoToolStripMenuItem.IconChar = FontAwesome.Sharp.IconChar.Box;
            pedidoToolStripMenuItem.IconColor = Color.Black;
            pedidoToolStripMenuItem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            pedidoToolStripMenuItem.Name = "pedidoToolStripMenuItem";
            pedidoToolStripMenuItem.Size = new Size(224, 26);
            pedidoToolStripMenuItem.Text = "Pedido";
            pedidoToolStripMenuItem.Click += pedidoToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirDelSistemaToolStripMenuItem });
            salirToolStripMenuItem.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            salirToolStripMenuItem.IconColor = Color.Black;
            salirToolStripMenuItem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(72, 24);
            salirToolStripMenuItem.Text = "Salir";
            // 
            // salirDelSistemaToolStripMenuItem
            // 
            salirDelSistemaToolStripMenuItem.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            salirDelSistemaToolStripMenuItem.IconColor = Color.Black;
            salirDelSistemaToolStripMenuItem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            salirDelSistemaToolStripMenuItem.Name = "salirDelSistemaToolStripMenuItem";
            salirDelSistemaToolStripMenuItem.Size = new Size(200, 26);
            salirDelSistemaToolStripMenuItem.Text = "Salir del sistema";
            salirDelSistemaToolStripMenuItem.Click += salirDelSistemaToolStripMenuItem_Click;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1041, 613);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MenuPrincipal";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Rotiseria";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private BindingSource bindingSource1;
        private FontAwesome.Sharp.IconMenuItem principalToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem baseToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem clienteToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem productoToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem proveedorToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem pedidoToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem salirToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem salirDelSistemaToolStripMenuItem;
    }
}
