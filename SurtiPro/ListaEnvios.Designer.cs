namespace SurtiPro
{
    partial class ListaEnvios
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewEnvios = new DataGridView();
            dataGridViewDetallesEnvio = new DataGridView();
            buttonCerrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEnvios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDetallesEnvio).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewEnvios
            // 
            dataGridViewEnvios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEnvios.Location = new Point(14, 14);
            dataGridViewEnvios.Margin = new Padding(4, 3, 4, 3);
            dataGridViewEnvios.Name = "dataGridViewEnvios";
            dataGridViewEnvios.Size = new Size(597, 173);
            dataGridViewEnvios.TabIndex = 0;
            dataGridViewEnvios.CellContentClick += dataGridViewEnvios_CellContentClick_1;
            // 
            // dataGridViewDetallesEnvio
            // 
            dataGridViewDetallesEnvio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDetallesEnvio.Location = new Point(14, 194);
            dataGridViewDetallesEnvio.Margin = new Padding(4, 3, 4, 3);
            dataGridViewDetallesEnvio.Name = "dataGridViewDetallesEnvio";
            dataGridViewDetallesEnvio.Size = new Size(597, 173);
            dataGridViewDetallesEnvio.TabIndex = 1;
            // 
            // buttonCerrar
            // 
            buttonCerrar.Location = new Point(451, 374);
            buttonCerrar.Margin = new Padding(4, 3, 4, 3);
            buttonCerrar.Name = "buttonCerrar";
            buttonCerrar.Size = new Size(88, 27);
            buttonCerrar.TabIndex = 2;
            buttonCerrar.Text = "Cerrar";
            buttonCerrar.UseVisualStyleBackColor = true;
            buttonCerrar.Click += buttonCerrar_Click;
            // 
            // ListaEnvios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 414);
            Controls.Add(buttonCerrar);
            Controls.Add(dataGridViewDetallesEnvio);
            Controls.Add(dataGridViewEnvios);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ListaEnvios";
            Text = "Lista de Envíos";
            Load += ListaEnvios_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewEnvios).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDetallesEnvio).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEnvios;
        private System.Windows.Forms.DataGridView dataGridViewDetallesEnvio;
        private System.Windows.Forms.Button buttonCerrar;
    }
}