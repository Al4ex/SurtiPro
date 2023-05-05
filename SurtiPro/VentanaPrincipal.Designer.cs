namespace SurtiPro
{
    partial class VentanaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPrincipal));
            menuStrip1 = new MenuStrip();
            enviosToolStripMenuItem = new ToolStripMenuItem();
            listaDeEnviosToolStripMenuItem = new ToolStripMenuItem();
            registrarEnvíoToolStripMenuItem = new ToolStripMenuItem();
            productosToolStripMenuItem = new ToolStripMenuItem();
            listaDeProductosToolStripMenuItem = new ToolStripMenuItem();
            registrarProductoToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            labelProductosBajoStock = new Label();
            labelUltimosEnvios = new Label();
            listBoxProductosBajoStock = new ListBox();
            listBoxUltimosEnvios = new ListBox();
            labelProductos = new Label();
            labelEnvios = new Label();
            textBoxTotalProductos = new TextBox();
            textBoxTotalEnvios = new TextBox();
            labelEstadisticas = new Label();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { enviosToolStripMenuItem, productosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(933, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // enviosToolStripMenuItem
            // 
            enviosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listaDeEnviosToolStripMenuItem, registrarEnvíoToolStripMenuItem });
            enviosToolStripMenuItem.Name = "enviosToolStripMenuItem";
            enviosToolStripMenuItem.Size = new Size(53, 20);
            enviosToolStripMenuItem.Text = "Envíos";
            // 
            // listaDeEnviosToolStripMenuItem
            // 
            listaDeEnviosToolStripMenuItem.Name = "listaDeEnviosToolStripMenuItem";
            listaDeEnviosToolStripMenuItem.Size = new Size(152, 22);
            listaDeEnviosToolStripMenuItem.Text = "Lista de envíos";
            listaDeEnviosToolStripMenuItem.Click += listaDeEnviosToolStripMenuItem_Click;
            // 
            // registrarEnvíoToolStripMenuItem
            // 
            registrarEnvíoToolStripMenuItem.Name = "registrarEnvíoToolStripMenuItem";
            registrarEnvíoToolStripMenuItem.Size = new Size(152, 22);
            registrarEnvíoToolStripMenuItem.Text = "Registrar envío";
            registrarEnvíoToolStripMenuItem.Click += registrarEnvíoToolStripMenuItem_Click;
            // 
            // productosToolStripMenuItem
            // 
            productosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listaDeProductosToolStripMenuItem, registrarProductoToolStripMenuItem });
            productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            productosToolStripMenuItem.Size = new Size(73, 20);
            productosToolStripMenuItem.Text = "Productos";
            // 
            // listaDeProductosToolStripMenuItem
            // 
            listaDeProductosToolStripMenuItem.Name = "listaDeProductosToolStripMenuItem";
            listaDeProductosToolStripMenuItem.Size = new Size(172, 22);
            listaDeProductosToolStripMenuItem.Text = "Lista de productos";
            listaDeProductosToolStripMenuItem.Click += listaDeProductosToolStripMenuItem_Click;
            // 
            // registrarProductoToolStripMenuItem
            // 
            registrarProductoToolStripMenuItem.Name = "registrarProductoToolStripMenuItem";
            registrarProductoToolStripMenuItem.Size = new Size(172, 22);
            registrarProductoToolStripMenuItem.Text = "Registrar producto";
            registrarProductoToolStripMenuItem.Click += registrarProductoToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(labelProductosBajoStock);
            panel1.Controls.Add(labelUltimosEnvios);
            panel1.Controls.Add(listBoxProductosBajoStock);
            panel1.Controls.Add(listBoxUltimosEnvios);
            panel1.Controls.Add(labelProductos);
            panel1.Controls.Add(labelEnvios);
            panel1.Controls.Add(textBoxTotalProductos);
            panel1.Controls.Add(textBoxTotalEnvios);
            panel1.Controls.Add(labelEstadisticas);
            panel1.Location = new Point(14, 31);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(905, 474);
            panel1.TabIndex = 1;
            // 
            // labelProductosBajoStock
            // 
            labelProductosBajoStock.AutoSize = true;
            labelProductosBajoStock.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelProductosBajoStock.Location = new Point(467, 137);
            labelProductosBajoStock.Margin = new Padding(4, 0, 4, 0);
            labelProductosBajoStock.Name = "labelProductosBajoStock";
            labelProductosBajoStock.Size = new Size(216, 20);
            labelProductosBajoStock.TabIndex = 8;
            labelProductosBajoStock.Text = "Productos con bajo stock:";
            // 
            // labelUltimosEnvios
            // 
            labelUltimosEnvios.AutoSize = true;
            labelUltimosEnvios.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelUltimosEnvios.Location = new Point(19, 137);
            labelUltimosEnvios.Margin = new Padding(4, 0, 4, 0);
            labelUltimosEnvios.Name = "labelUltimosEnvios";
            labelUltimosEnvios.Size = new Size(130, 20);
            labelUltimosEnvios.TabIndex = 7;
            labelUltimosEnvios.Text = "Últimos envíos:";
            // 
            // listBoxProductosBajoStock
            // 
            listBoxProductosBajoStock.FormattingEnabled = true;
            listBoxProductosBajoStock.ItemHeight = 15;
            listBoxProductosBajoStock.Location = new Point(471, 164);
            listBoxProductosBajoStock.Margin = new Padding(4, 3, 4, 3);
            listBoxProductosBajoStock.Name = "listBoxProductosBajoStock";
            listBoxProductosBajoStock.Size = new Size(410, 289);
            listBoxProductosBajoStock.TabIndex = 6;
            // 
            // listBoxUltimosEnvios
            // 
            listBoxUltimosEnvios.FormattingEnabled = true;
            listBoxUltimosEnvios.ItemHeight = 15;
            listBoxUltimosEnvios.Location = new Point(23, 164);
            listBoxUltimosEnvios.Margin = new Padding(4, 3, 4, 3);
            listBoxUltimosEnvios.Name = "listBoxUltimosEnvios";
            listBoxUltimosEnvios.Size = new Size(410, 289);
            listBoxUltimosEnvios.TabIndex = 5;
            // 
            // labelProductos
            // 
            labelProductos.AutoSize = true;
            labelProductos.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelProductos.Location = new Point(19, 80);
            labelProductos.Margin = new Padding(4, 0, 4, 0);
            labelProductos.Name = "labelProductos";
            labelProductos.Size = new Size(171, 20);
            labelProductos.TabIndex = 4;
            labelProductos.Text = "Cantidad productos:";
            // 
            // labelEnvios
            // 
            labelEnvios.AutoSize = true;
            labelEnvios.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelEnvios.Location = new Point(19, 37);
            labelEnvios.Margin = new Padding(4, 0, 4, 0);
            labelEnvios.Name = "labelEnvios";
            labelEnvios.Size = new Size(142, 20);
            labelEnvios.TabIndex = 3;
            labelEnvios.Text = "Cantidad envíos:";
            // 
            // textBoxTotalProductos
            // 
            textBoxTotalProductos.Enabled = false;
            textBoxTotalProductos.Location = new Point(223, 80);
            textBoxTotalProductos.Margin = new Padding(4, 3, 4, 3);
            textBoxTotalProductos.Name = "textBoxTotalProductos";
            textBoxTotalProductos.ReadOnly = true;
            textBoxTotalProductos.Size = new Size(116, 23);
            textBoxTotalProductos.TabIndex = 2;
            // 
            // textBoxTotalEnvios
            // 
            textBoxTotalEnvios.Enabled = false;
            textBoxTotalEnvios.Location = new Point(223, 37);
            textBoxTotalEnvios.Margin = new Padding(4, 3, 4, 3);
            textBoxTotalEnvios.Name = "textBoxTotalEnvios";
            textBoxTotalEnvios.ReadOnly = true;
            textBoxTotalEnvios.Size = new Size(116, 23);
            textBoxTotalEnvios.TabIndex = 1;
            // 
            // labelEstadisticas
            // 
            labelEstadisticas.AutoSize = true;
            labelEstadisticas.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point);
            labelEstadisticas.Location = new Point(4, 0);
            labelEstadisticas.Margin = new Padding(4, 0, 4, 0);
            labelEstadisticas.Name = "labelEstadisticas";
            labelEstadisticas.Size = new Size(119, 24);
            labelEstadisticas.TabIndex = 0;
            labelEstadisticas.Text = "Estadísticas";
            // 
            // VentanaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            Name = "VentanaPrincipal";
            Text = "SurtiPro - Ventana Principal";
            Load += VentanaPrincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem enviosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeEnviosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarEnvíoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarProductoToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelProductosBajoStock;
        private System.Windows.Forms.Label labelUltimosEnvios;
        private System.Windows.Forms.ListBox listBoxProductosBajoStock;
        private System.Windows.Forms.ListBox listBoxUltimosEnvios;
        private System.Windows.Forms.Label labelProductos;
        private System.Windows.Forms.Label labelEnvios;
        private System.Windows.Forms.TextBox textBoxTotalProductos;
        private System.Windows.Forms.TextBox textBoxTotalEnvios;
        private System.Windows.Forms.Label labelEstadisticas;
    }
}


