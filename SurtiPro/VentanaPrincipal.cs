using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SurtiPro
{
    public partial class VentanaPrincipal : Form
    {
        private MySqlConnection connection;

        public VentanaPrincipal()
        {
            InitializeComponent();

            string connectionString = "Server=localhost;Database=surtipro;Uid=root;Pwd=;";
            connection = new MySqlConnection(connectionString);
        }

        private void listaDeEnviosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaEnvios listaEnvios = new ListaEnvios();
            listaEnvios.FormClosed += FormularioMenu_FormClosed;
            listaEnvios.Show();
        }

        private void registrarEnvíoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroEnvio registroEnvio = new RegistroEnvio();
            registroEnvio.FormClosed += FormularioMenu_FormClosed;
            registroEnvio.Show();
        }

        private void listaDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            productForm.FormClosed += FormularioMenu_FormClosed;
            productForm.Show();
        }

        private void registrarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroPrducto form1 = new RegistroPrducto(null);
            form1.FormClosed += FormularioMenu_FormClosed;
            form1.Show();
        }

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {
            CargarEstadisticas();
            CargarUltimosEnvios();
            CargarProductosBajoStock();
        }

        private void CargarEstadisticas()
        {
            string queryEnvios = "SELECT COUNT(*) FROM envios";
            string queryProductos = "SELECT COUNT(*) FROM productos";

            try
            {
                connection.Open();

                MySqlCommand commandEnvios = new MySqlCommand(queryEnvios, connection);
                MySqlCommand commandProductos = new MySqlCommand(queryProductos, connection);

                int totalEnvios = Convert.ToInt32(commandEnvios.ExecuteScalar());
                int totalProductos = Convert.ToInt32(commandProductos.ExecuteScalar());

                textBoxTotalEnvios.Text = totalEnvios.ToString();
                textBoxTotalProductos.Text = totalProductos.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar estadísticas: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void CargarUltimosEnvios()
        {
            listBoxUltimosEnvios.Items.Clear(); // Añade esta línea para limpiar el ListBox
            string query = "SELECT id_envio, fecha_envio, direccion_envio " +
                           "FROM envios " +
                           "ORDER BY fecha_envio DESC LIMIT 5";

            try
            {
                connection.Open();

                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int idEnvio = reader.GetInt32("id_envio");
                    DateTime fechaEnvio = reader.GetDateTime("fecha_envio");
                    string direccionEnvio = reader.GetString("direccion_envio");

                    listBoxUltimosEnvios.Items.Add($"ID Envío: {idEnvio} - Fecha: {fechaEnvio.ToShortDateString()} - Dirección: {direccionEnvio}");
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los últimos envíos: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void CargarProductosBajoStock()
        {
            listBoxProductosBajoStock.Items.Clear();
            string query = "SELECT nombre_producto, cantidad_stock " +
                           "FROM productos " +
                           "WHERE cantidad_stock <= 15 " +
                           "ORDER BY cantidad_stock ASC";

            try
            {
                connection.Open();

                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string nombreProducto = reader.GetString("nombre_producto");
                    int stock = reader.GetInt32("cantidad_stock");

                    listBoxProductosBajoStock.Items.Add($"Producto: {nombreProducto} - Stock: {stock}");
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos con bajo stock: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        private void FormularioMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            CargarEstadisticas();
            CargarUltimosEnvios();
            CargarProductosBajoStock();
        }

    }
}
