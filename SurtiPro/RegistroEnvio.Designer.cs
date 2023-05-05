namespace SurtiPro
{
    partial class RegistroEnvio
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox comboBoxProductos;
        private System.Windows.Forms.Label labelProducto;
        private System.Windows.Forms.Label labelCantidad;
        private System.Windows.Forms.NumericUpDown numericUpDownCantidad;
        private System.Windows.Forms.Label labelFechaEnvio;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaEnvio;
        private System.Windows.Forms.Label labelDireccionEnvio;
        private System.Windows.Forms.TextBox textBoxDireccionEnvio;
        private System.Windows.Forms.Button buttonEnviar;
        private System.Windows.Forms.ListBox listBoxProductos;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            comboBoxProductos = new ComboBox();
            labelProducto = new Label();
            numericUpDownCantidad = new NumericUpDown();
            labelCantidad = new Label();
            listBoxProductos = new ListBox();
            dateTimePickerFechaEnvio = new DateTimePicker();
            labelFechaEnvio = new Label();
            textBoxDireccionEnvio = new TextBox();
            labelDireccionEnvio = new Label();
            buttonEnviar = new Button();
            buttonAgregarProducto = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCantidad).BeginInit();
            SuspendLayout();
            // 
            // comboBoxProductos
            // 
            comboBoxProductos.Location = new Point(20, 50);
            comboBoxProductos.Name = "comboBoxProductos";
            comboBoxProductos.Size = new Size(121, 23);
            comboBoxProductos.TabIndex = 0;
            // 
            // labelProducto
            // 
            labelProducto.Location = new Point(20, 30);
            labelProducto.Name = "labelProducto";
            labelProducto.Size = new Size(100, 23);
            labelProducto.TabIndex = 1;
            labelProducto.Text = "Producto:";
            // 
            // numericUpDownCantidad
            // 
            numericUpDownCantidad.Location = new Point(280, 50);
            numericUpDownCantidad.Name = "numericUpDownCantidad";
            numericUpDownCantidad.Size = new Size(120, 23);
            numericUpDownCantidad.TabIndex = 2;
            // 
            // labelCantidad
            // 
            labelCantidad.Location = new Point(280, 30);
            labelCantidad.Name = "labelCantidad";
            labelCantidad.Size = new Size(100, 23);
            labelCantidad.TabIndex = 3;
            labelCantidad.Text = "Cantidad:";
            // 
            // listBoxProductos
            // 
            listBoxProductos.ItemHeight = 15;
            listBoxProductos.Location = new Point(20, 90);
            listBoxProductos.Name = "listBoxProductos";
            listBoxProductos.Size = new Size(760, 199);
            listBoxProductos.TabIndex = 5;
            // 
            // dateTimePickerFechaEnvio
            // 
            dateTimePickerFechaEnvio.Location = new Point(20, 336);
            dateTimePickerFechaEnvio.Name = "dateTimePickerFechaEnvio";
            dateTimePickerFechaEnvio.Size = new Size(200, 23);
            dateTimePickerFechaEnvio.TabIndex = 6;
            // 
            // labelFechaEnvio
            // 
            labelFechaEnvio.Location = new Point(20, 310);
            labelFechaEnvio.Name = "labelFechaEnvio";
            labelFechaEnvio.Size = new Size(100, 23);
            labelFechaEnvio.TabIndex = 7;
            labelFechaEnvio.Text = "Fecha de envío:";
            // 
            // textBoxDireccionEnvio
            // 
            textBoxDireccionEnvio.Location = new Point(280, 336);
            textBoxDireccionEnvio.Name = "textBoxDireccionEnvio";
            textBoxDireccionEnvio.Size = new Size(300, 23);
            textBoxDireccionEnvio.TabIndex = 8;
            // 
            // labelDireccionEnvio
            // 
            labelDireccionEnvio.Location = new Point(280, 310);
            labelDireccionEnvio.Name = "labelDireccionEnvio";
            labelDireccionEnvio.Size = new Size(127, 23);
            labelDireccionEnvio.TabIndex = 9;
            labelDireccionEnvio.Text = "Dirección de envío:";
            // 
            // buttonEnviar
            // 
            buttonEnviar.Location = new Point(667, 336);
            buttonEnviar.Name = "buttonEnviar";
            buttonEnviar.Size = new Size(75, 23);
            buttonEnviar.TabIndex = 10;
            buttonEnviar.Text = "Enviar";
            buttonEnviar.Click += buttonEnviar_Click;
            // 
            // buttonAgregarProducto
            // 
            buttonAgregarProducto.Location = new Point(558, 50);
            buttonAgregarProducto.Name = "buttonAgregarProducto";
            buttonAgregarProducto.Size = new Size(75, 23);
            buttonAgregarProducto.TabIndex = 11;
            buttonAgregarProducto.Text = "Agregar";
            buttonAgregarProducto.UseVisualStyleBackColor = true;
            buttonAgregarProducto.Click += buttonAgregarProducto_Click;
            // 
            // RegistroEnvio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonAgregarProducto);
            Controls.Add(comboBoxProductos);
            Controls.Add(labelProducto);
            Controls.Add(numericUpDownCantidad);
            Controls.Add(labelCantidad);
            Controls.Add(listBoxProductos);
            Controls.Add(dateTimePickerFechaEnvio);
            Controls.Add(labelFechaEnvio);
            Controls.Add(textBoxDireccionEnvio);
            Controls.Add(labelDireccionEnvio);
            Controls.Add(buttonEnviar);
            Name = "RegistroEnvio";
            Text = "Registro de Envios";
            Load += RegistroEnvio_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownCantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAgregarProducto;
    }
}
