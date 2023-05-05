using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SurtiPro
{
    public partial class ProductForm : Form
    {
        private DataTable dataTable = new DataTable();
        private string connectionString = "Server=localhost;Database=surtipro;Uid=root;Pwd=;";

        public ProductForm()
        {
            InitializeComponent();
            dataGridViewProducts.CellDoubleClick += dataGridViewProducts_CellDoubleClick;
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            LoadProductData();
            dataGridViewProducts.CellClick += dataGridViewProducts_CellClick;
            // Agrega un botón de eliminar en la columna del DataGridView
            DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn();
            btnEliminar.HeaderText = "Eliminar";
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseColumnTextForButtonValue = true;
            btnEliminar.Name = "Eliminar";
            dataGridViewProducts.Columns.Add(btnEliminar);
            //dataGridViewProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // Ajusta automáticamente el tamaño del DataGridView y lo ancla al contenedor
            dataGridViewProducts.AutoSize = true;
            dataGridViewProducts.Dock = DockStyle.Fill;

        }
        private void dataGridViewProducts_MouseWheel(object sender, MouseEventArgs e)
        {
            int currentIndex = dataGridViewProducts.FirstDisplayedScrollingRowIndex;
            int scrollLines = SystemInformation.MouseWheelScrollLines;

            if (currentIndex >= 0)
            {
                if (e.Delta < 0)
                {
                    currentIndex += scrollLines;
                }
                else
                {
                    currentIndex -= scrollLines;
                }

                if (currentIndex < 0)
                {
                    currentIndex = 0;
                }
                else if (currentIndex >= dataGridViewProducts.RowCount)
                {
                    currentIndex = dataGridViewProducts.RowCount - 1;
                }

                dataGridViewProducts.FirstDisplayedScrollingRowIndex = currentIndex;
            }
        }

        private void LoadProductData()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM productos";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                {
                    dataTable.Clear();
                    adapter.Fill(dataTable);

                    dataGridViewProducts.DataSource = dataTable;
                }
            }
        }

        private void irARegistrarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
<<<<<<< HEAD
            RegistroPrducto form1 = new RegistroPrducto(this); // no se pasa ningún argumento
=======
            Form1 form1 = new Form1(this); // no se pasa ningún argumento
>>>>>>> e057946a2bcaf233bceae64521f7ee31984b4d06
=======
            Form1 form1 = new Form1(this); // no se pasa ningún argumento
>>>>>>> e057946a2bcaf233bceae64521f7ee31984b4d06
            form1.Show();
            this.Hide();
        }

        

        // Agregar botón Editar
        private void dataGridViewProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(dataGridViewProducts.Rows[e.RowIndex].Cells["id_producto"].Value);

<<<<<<< HEAD
<<<<<<< HEAD
                RegistroPrducto form1 = new RegistroPrducto(this, id);
=======
                Form1 form1 = new Form1(this, id);
>>>>>>> e057946a2bcaf233bceae64521f7ee31984b4d06
=======
                Form1 form1 = new Form1(this, id);
>>>>>>> e057946a2bcaf233bceae64521f7ee31984b4d06
                form1.ShowDialog();
                LoadProductData();
            }

        }
        private void dataGridViewProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridViewProducts.Columns["Eliminar"].Index)
            {
                int id = Convert.ToInt32(dataGridViewProducts.Rows[e.RowIndex].Cells["id_producto"].Value);

                DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar el producto?", "Eliminar producto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();

                        string query = "DELETE FROM productos WHERE id_producto = @id_producto";

                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@id_producto", id);
                            command.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Producto eliminado correctamente");
                    LoadProductData();
                }
            }
        }

        private void dataGridViewProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void enviosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void irARegistrarProfuctoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
