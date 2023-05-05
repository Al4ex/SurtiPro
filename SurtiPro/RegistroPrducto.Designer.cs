namespace SurtiPro
{
    partial class RegistroPrducto
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
            bindingSource1 = new BindingSource(components);
            txtNombreProducto = new TextBox();
            txtDescripcionProducto = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtCategoriaProducto = new TextBox();
            label4 = new Label();
            txtPrecioProducto = new TextBox();
            label5 = new Label();
            txtCantidadStock = new TextBox();
            button1 = new Button();
            txtIdProducto = new TextBox();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(122, 69);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(344, 23);
            txtNombreProducto.TabIndex = 0;
            // 
            // txtDescripcionProducto
            // 
            txtDescripcionProducto.Location = new Point(122, 132);
            txtDescripcionProducto.Name = "txtDescripcionProducto";
            txtDescripcionProducto.Size = new Size(344, 23);
            txtDescripcionProducto.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(122, 39);
            label1.Name = "label1";
            label1.Size = new Size(122, 15);
            label1.TabIndex = 2;
            label1.Text = "Nombre del Producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(122, 105);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 3;
            label2.Text = "Descripcion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(122, 177);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 5;
            label3.Text = "Categoria";
            // 
            // txtCategoriaProducto
            // 
            txtCategoriaProducto.Location = new Point(120, 206);
            txtCategoriaProducto.Name = "txtCategoriaProducto";
            txtCategoriaProducto.Size = new Size(130, 23);
            txtCategoriaProducto.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(336, 177);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 7;
            label4.Text = "Precio";
            // 
            // txtPrecioProducto
            // 
            txtPrecioProducto.Location = new Point(336, 206);
            txtPrecioProducto.Name = "txtPrecioProducto";
            txtPrecioProducto.Size = new Size(130, 23);
            txtPrecioProducto.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(122, 257);
            label5.Name = "label5";
            label5.Size = new Size(102, 15);
            label5.TabIndex = 9;
            label5.Text = "Cantidad en stock";
            // 
            // txtCantidadStock
            // 
            txtCantidadStock.Location = new Point(120, 289);
            txtCantidadStock.Name = "txtCantidadStock";
            txtCantidadStock.Size = new Size(130, 23);
            txtCantidadStock.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(122, 343);
            button1.Name = "button1";
            button1.Size = new Size(344, 46);
            button1.TabIndex = 10;
            button1.Text = "Insertar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtIdProducto
            // 
            txtIdProducto.Location = new Point(16, 9);
            txtIdProducto.Name = "txtIdProducto";
            txtIdProducto.Size = new Size(100, 23);
            txtIdProducto.TabIndex = 11;
            txtIdProducto.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(945, 428);
            Controls.Add(txtIdProducto);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(txtCantidadStock);
            Controls.Add(label4);
            Controls.Add(txtPrecioProducto);
            Controls.Add(label3);
            Controls.Add(txtCategoriaProducto);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDescripcionProducto);
            Controls.Add(txtNombreProducto);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Insertar Productos";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BindingSource bindingSource1;
        private TextBox txtNombreProducto;
        private TextBox txtDescripcionProducto;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtCategoriaProducto;
        private Label label4;
        private TextBox txtPrecioProducto;
        private Label label5;
        private TextBox txtCantidadStock;
        private Button button1;
        private TextBox txtIdProducto;
    }
}