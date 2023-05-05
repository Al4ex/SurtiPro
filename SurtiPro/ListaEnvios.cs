using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SurtiPro
{
    public partial class ListaEnvios : Form
    {
        private MySqlConnection connection;
        private DataGridViewButtonColumn eliminarButtonColumn;

        public ListaEnvios()
        {
            InitializeComponent();
            dataGridViewEnvios.AllowUserToAddRows = false;
            dataGridViewDetallesEnvio.AllowUserToAddRows = false;
            string connectionString = "Server=localhost;Database=surtipro;Uid=root;Pwd=;";
            connection = new MySqlConnection(connectionString);

            dataGridViewEnvios.AutoGenerateColumns = false;
            dataGridViewEnvios.Columns.Add("id_envio", "ID Envío");
            dataGridViewEnvios.Columns.Add("fecha_envio", "Fecha Envío");
            dataGridViewEnvios.Columns.Add("direccion_envio", "Dirección Envío");

            eliminarButtonColumn = new DataGridViewButtonColumn();
            eliminarButtonColumn.HeaderText = "Eliminar";
            eliminarButtonColumn.Text = "Eliminar";
            eliminarButtonColumn.UseColumnTextForButtonValue = true;
            dataGridViewEnvios.Columns.Add(eliminarButtonColumn);

            dataGridViewDetallesEnvio.AutoGenerateColumns = false;
            dataGridViewDetallesEnvio.Columns.Add("nombre_producto", "Producto");
            dataGridViewDetallesEnvio.Columns.Add("cantidad", "Cantidad");
            dataGridViewDetallesEnvio.Columns.Add("precio_producto", "Precio Producto");
            MostrarEnvios();

            dataGridViewDetallesEnvio.Columns.Add("subtotal", "Subtotal");
            dataGridViewDetallesEnvio.Columns["subtotal"].DefaultCellStyle.Format = "C";
            dataGridViewDetallesEnvio.Columns.Add("suma_total", "Total");
            dataGridViewDetallesEnvio.Columns["suma_total"].DefaultCellStyle.Format = "C";

            dataGridViewEnvios.SelectionChanged += DataGridViewEnvios_SelectionChanged;
            dataGridViewEnvios.CellContentClick += DataGridViewEnvios_CellContentClick;
        }

        private void MostrarEnvios()
        {
            string query = "SELECT id_envio, fecha_envio, direccion_envio " +
                           "FROM envios " +
                           "ORDER BY id_envio";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                try
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        int idEnvio = reader.GetInt32("id_envio");
                        DateTime fechaEnvio = reader.GetDateTime("fecha_envio");
                        string direccionEnvio = reader.GetString("direccion_envio");

                        dataGridViewEnvios.Rows.Add(idEnvio, fechaEnvio, direccionEnvio);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al mostrar los envíos: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void DataGridViewEnvios_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewEnvios.SelectedRows.Count > 0)
            {
                int idEnvio = Convert.ToInt32(dataGridViewEnvios.SelectedRows[0].Cells["id_envio"].Value);
                MostrarDetallesEnvio(idEnvio);
            }
        }

        private void MostrarDetallesEnvio(int idEnvio)
        {
            dataGridViewDetallesEnvio.Rows.Clear();
            string query = "SELECT p.nombre_producto, de.cantidad, p.precio_producto " +
                           "FROM detalles_envio de " +
                           "JOIN productos p ON de.id_producto = p.id_producto " +
                           "WHERE de.id_envio = @idEnvio";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@idEnvio", idEnvio);
                try
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string nombreProducto = reader.GetString("nombre_producto");
                        int cantidad = reader.GetInt32("cantidad");
                        decimal precioProducto = reader.GetDecimal("precio_producto");
                        decimal total = reader.GetDecimal("precio_producto") * reader.GetInt32("cantidad");

                        dataGridViewDetallesEnvio.Rows.Add(nombreProducto, cantidad, precioProducto);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al mostrar los detalles del envío: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            for (int i = 0; i < dataGridViewDetallesEnvio.Rows.Count; i++)
            {
                int cantidad = Convert.ToInt32(dataGridViewDetallesEnvio.Rows[i].Cells["cantidad"].Value);
                decimal precioVenta = Convert.ToDecimal(dataGridViewDetallesEnvio.Rows[i].Cells["precio_producto"].Value);
                dataGridViewDetallesEnvio.Rows[i].Cells["subtotal"].Value = cantidad * precioVenta;
            }

            // Calcular y agregar la suma total al final del DataGridView
            decimal sumaTotal = 0;
            for (int i = 0; i < dataGridViewDetallesEnvio.Rows.Count; i++)
            {
                sumaTotal += Convert.ToDecimal(dataGridViewDetallesEnvio.Rows[i].Cells["subtotal"].Value);
            }

            int lastIndex = dataGridViewDetallesEnvio.Rows.Add();
            dataGridViewDetallesEnvio.Rows[lastIndex].Cells["suma_total"].Value = sumaTotal;

            // Establecer el estilo de la fila de la suma total
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.Font = new Font(dataGridViewDetallesEnvio.Font, FontStyle.Bold);
            dataGridViewDetallesEnvio.Rows[lastIndex].DefaultCellStyle = style;
        }

        private void DataGridViewEnvios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == eliminarButtonColumn.Index)
            {
                int idEnvio = Convert.ToInt32(dataGridViewEnvios.Rows[e.RowIndex].Cells["id_envio"].Value);
                DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar el envío seleccionado?", "Confirmar eliminación", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    EliminarEnvio(idEnvio);
                }
            }
        }

        private void EliminarEnvio(int idEnvio)
        {
            string query = "DELETE FROM detalles_envio WHERE id_envio = @idEnvio;" +
                           "DELETE FROM envios WHERE id_envio = @idEnvio;";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@idEnvio", idEnvio);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Envío eliminado con éxito.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el envío: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }

            // Actualizar la lista de envíos y limpiar la lista de detalles de envío
            dataGridViewEnvios.Rows.Clear();
            dataGridViewDetallesEnvio.Rows.Clear();
            MostrarEnvios();
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridViewEnvios_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ListaEnvios_Load(object sender, EventArgs e)
        {

        }
    }
}