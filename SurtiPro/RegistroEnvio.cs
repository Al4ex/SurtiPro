using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SurtiPro
{
    public partial class RegistroEnvio : Form
    {
        private string connectionString = "Server=localhost;Database=surtipro;Uid=root;Pwd=;";
        public RegistroEnvio()
        {
            InitializeComponent();
            comboBoxProductos.SelectedIndexChanged += new System.EventHandler(comboBoxProductos_SelectedIndexChanged);
            


        }

        private void LoadProductData()
        {
            comboBoxProductos.Items.Clear();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT id_producto, nombre_producto, cantidad_stock FROM productos WHERE cantidad_stock > 0";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                using (MySqlDataReader reader = command.ExecuteReader())
                {


                    while (reader.Read())
                    {
                        Producto producto = new Producto
                        {
                            Id = reader.GetInt32("id_producto"),
                            Nombre = reader.GetString("nombre_producto"),
                            Stock = reader.GetInt32("cantidad_stock")
                        };

                        comboBoxProductos.Items.Add(producto);
                    }
                }
            }
        }
        private void comboBoxProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Producto productoSeleccionado = comboBoxProductos.SelectedItem as Producto;

            if (productoSeleccionado != null)
            {
                numericUpDownCantidad.Maximum = productoSeleccionado.Stock;
            }
        }

        private void RegistroEnvio_Load(object sender, EventArgs e)
        {
            LoadProductData();
        }

        private void buttonAgregarProducto_Click(object sender, EventArgs e)
        {
            Producto productoSeleccionado = comboBoxProductos.SelectedItem as Producto;
            int cantidad = (int)numericUpDownCantidad.Value;

            if (productoSeleccionado != null && cantidad > 0)
            {
                ProductoEnvio productoEnvio = new ProductoEnvio
                {
                    Id = productoSeleccionado.Id,
                    Nombre = productoSeleccionado.Nombre,
                    Stock = productoSeleccionado.Stock,
                    Cantidad = cantidad
                };

                bool alreadyInList = false;
                foreach (ProductoEnvio item in listBoxProductos.Items)
                {
                    if (item.Id == productoEnvio.Id)
                    {
                        alreadyInList = true;
                        MessageBox.Show("El producto ya está en la lista.");
                        break;
                    }
                }

                if (!alreadyInList)
                {
                    listBoxProductos.Items.Add(productoEnvio);
                }
            }
        }

        private void buttonEnviar_Click(object sender, EventArgs e)
        {
            string direccionEnvio = textBoxDireccionEnvio.Text;

            if (string.IsNullOrWhiteSpace(direccionEnvio))
            {
                MessageBox.Show("Por favor, ingrese una dirección de envío.");
                return;
            }

            if (listBoxProductos.Items.Count < 1)
            {
                MessageBox.Show("Por favor, agregue al menos un producto al envío.");
                return;
            }

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlTransaction transaction = connection.BeginTransaction();
                long lastInsertId;
                try
                {
                    string queryEnvio = "INSERT INTO envios (fecha_envio, direccion_envio) VALUES (@fecha_envio, @direccion_envio)";
                    using (MySqlCommand commandEnvio = new MySqlCommand(queryEnvio, connection, transaction))
                    {
                        commandEnvio.Parameters.AddWithValue("@fecha_envio", dateTimePickerFechaEnvio.Value);
                        commandEnvio.Parameters.AddWithValue("@direccion_envio", direccionEnvio);

                        commandEnvio.ExecuteNonQuery();
                        lastInsertId = commandEnvio.LastInsertedId;
                    }

                    foreach (ProductoEnvio productoEnvio in listBoxProductos.Items)
                    {
                        string queryDetalleEnvio = "INSERT INTO detalles_envio (id_envio, id_producto, cantidad) VALUES (@id_envio, @id_producto, @cantidad)";
                        using (MySqlCommand commandDetalleEnvio = new MySqlCommand(queryDetalleEnvio, connection, transaction))
                        {
                            commandDetalleEnvio.Parameters.AddWithValue("@id_envio", lastInsertId);
                            commandDetalleEnvio.Parameters.AddWithValue("@id_producto", productoEnvio.Id);
                            commandDetalleEnvio.Parameters.AddWithValue("@cantidad", productoEnvio.Cantidad);

                            commandDetalleEnvio.ExecuteNonQuery();
                        }

                        string queryUpdateStock = "UPDATE productos SET cantidad_stock = cantidad_stock - @cantidad WHERE id_producto = @id_producto";
                        using (MySqlCommand commandUpdateStock = new MySqlCommand(queryUpdateStock, connection, transaction))
                        {
                            commandUpdateStock.Parameters.AddWithValue("@id_producto", productoEnvio.Id);
                            commandUpdateStock.Parameters.AddWithValue("@cantidad", productoEnvio.Cantidad);

                            commandUpdateStock.ExecuteNonQuery();
                        }
                    }

                    
                    transaction.Commit();
                    MessageBox.Show("Envío insertado correctamente");
                    LimpiarFormulario();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar el envío: " + ex.Message);
                    transaction.Rollback();
                }
            }
        }

        private void LimpiarFormulario()
        {
            textBoxDireccionEnvio.Text = "";
            comboBoxProductos.Text = "";
            listBoxProductos.Items.Clear();
            numericUpDownCantidad.Value = 0;
            LoadProductData(); // Llama a la función que carga los productos, que deberías haber creado previamente
        }
    }
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Stock { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }
    public class ProductoEnvio : Producto
    {
        public int Cantidad { get; set; }

        public override string ToString()
        {
            return $"{Nombre} - Cantidad: {Cantidad}";
        }
    }



}