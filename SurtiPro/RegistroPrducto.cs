using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SurtiPro
{
    public partial class RegistroPrducto : Form
    {
        private int? productId;
        private ProductForm _productForm; // Agrega esta línea al comienzo de la clase Form1

        public RegistroPrducto(ProductForm productForm, int? productId = null) // Modifica el constructor
        {
            InitializeComponent();
            _productForm = productForm; // Agrega esta línea
            this.productId = productId;
            if (productId.HasValue)
            {
                LoadProductData(productId.Value);
                button1.Text = "Actualizar"; // Agrega esta línea para cambiar el texto del botón a "Actualizar"
                Text = "Actualizar Producto";
            }
            else
            {
                button1.Text = "Insertar"; // Agrega esta línea para cambiar el texto del botón a "Insertar"
            
            }
            
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (productId != null)
            {
                UpdateProduct(productId.Value);
            }
            else
            {
                InsertProduct();
            }
        }

        private void InsertProduct()
        {
            string connectionString = "Server=localhost;Database=SurtiPro;Uid=root;Pwd=;";

            string nombreProducto = txtNombreProducto.Text;
            string descripcionProducto = txtDescripcionProducto.Text;
            string categoriaProducto = txtCategoriaProducto.Text;

            if (string.IsNullOrWhiteSpace(nombreProducto) ||
                string.IsNullOrWhiteSpace(descripcionProducto) ||
                string.IsNullOrWhiteSpace(categoriaProducto))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            if (!decimal.TryParse(txtPrecioProducto.Text, out decimal precioProducto))
            {
                MessageBox.Show("Por favor, ingrese un precio válido.");
                return;
            }

            if (!int.TryParse(txtCantidadStock.Text, out int cantidadStock))
            {
                MessageBox.Show("Por favor, ingrese una cantidad de stock válida.");
                return;
            }

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand cmd = new MySqlCommand("INSERT INTO productos (nombre_producto, descripcion_producto, categoria_producto, precio_producto, cantidad_stock) VALUES (@nombre_producto, @descripcion_producto, @categoria_producto, @precio_producto, @cantidad_stock)", connection))
                {
                    cmd.Parameters.AddWithValue("@nombre_producto", nombreProducto);
                    cmd.Parameters.AddWithValue("@descripcion_producto", descripcionProducto);
                    cmd.Parameters.AddWithValue("@categoria_producto", categoriaProducto);
                    cmd.Parameters.AddWithValue("@precio_producto", precioProducto);
                    cmd.Parameters.AddWithValue("@cantidad_stock", cantidadStock);

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Producto insertado correctamente");

            // Limpiar los TextBox
            txtNombreProducto.Text = "";
            txtDescripcionProducto.Text = "";
            txtCategoriaProducto.Text = "";
            txtPrecioProducto.Text = "";
            txtCantidadStock.Text = "";
        }

        private void UpdateProduct(int productId)
        {
            string connectionString = "Server=localhost;Database=SurtiPro;Uid=root;Pwd=;";

            string nombreProducto = txtNombreProducto.Text;
            string descripcionProducto = txtDescripcionProducto.Text;
            string categoriaProducto = txtCategoriaProducto.Text;

            if (string.IsNullOrWhiteSpace(nombreProducto) ||
                string.IsNullOrWhiteSpace(descripcionProducto) ||
                string.IsNullOrWhiteSpace(categoriaProducto))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            if (!decimal.TryParse(txtPrecioProducto.Text, out decimal precioProducto))
            {
                MessageBox.Show("Por favor, ingrese un precio válido.");
                return;
            }

            if (!int.TryParse(txtCantidadStock.Text, out int cantidadStock))
            {
                MessageBox.Show("Por favor, ingrese una cantidad de stock válida.");
                return;
            }

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand cmd = new MySqlCommand("UPDATE productos SET nombre_producto=@nombre_producto, descripcion_producto=@descripcion_producto, categoria_producto=@categoria_producto, precio_producto=@precio_producto, cantidad_stock=@cantidad_stock WHERE id_producto=@id_producto", connection))
                {
                    cmd.Parameters.AddWithValue("@nombre_producto", nombreProducto);
                    cmd.Parameters.AddWithValue("@descripcion_producto", descripcionProducto);
                    cmd.Parameters.AddWithValue("@categoria_producto", categoriaProducto);
                    cmd.Parameters.AddWithValue("@precio_producto", precioProducto);
                    cmd.Parameters.AddWithValue("@cantidad_stock", cantidadStock);
                    cmd.Parameters.AddWithValue("@id_producto", productId);

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Producto actualizado correctamente");

            Close();

        }

        


        private void LoadProductData(int productId)
        {
            string connectionString = "Server=localhost;Database=SurtiPro;Uid=root;Pwd=;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM productos WHERE id_producto = @productId";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@productId", productId);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtNombreProducto.Text = reader["nombre_producto"].ToString();
                            txtDescripcionProducto.Text = reader["descripcion_producto"].ToString();
                            txtCategoriaProducto.Text = reader["categoria_producto"].ToString();
                            txtPrecioProducto.Text = reader["precio_producto"].ToString();
                            txtCantidadStock.Text = reader["cantidad_stock"].ToString();
                        }
                    }
                }
            }
        }



    }
}
