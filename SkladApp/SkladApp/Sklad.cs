using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace SkladApp
{
    public partial class Sklad : Form
    {
        private string connectionString = @"Data Source=DESKTOP-3CVUA48\SQLEXPRESS;Initial Catalog=sklad;Integrated Security=True";

        private DataGridView dataGridViewProducts;
        private TextBox txtName, txtStillage, txtCell, txtQuantity;
        private TextBox txtSearchName, txtSearchStillage, txtSearchCell;
        private Button btnUpdate, btnDelete, btnSaveToFile;
        private Button btnSearchByName, btnSearchByLocation, btnRefresh;
        private Label lblName, lblStillage, lblCell, lblQuantity;
        private Label lblSearchName, lblSearchLocation;

        public Sklad()
        {
            InitializeForm();
            LoadProducts();
        }

        private void InitializeForm()
        {
            this.Text = "Sklad";
            this.Size = new Size(750, 450);
            this.StartPosition = FormStartPosition.CenterScreen;

            // DataGridView
            dataGridViewProducts = new DataGridView();
            dataGridViewProducts.Location = new Point(20, 20);
            dataGridViewProducts.Size = new Size(500, 200);
            dataGridViewProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProducts.ReadOnly = true;
            this.Controls.Add(dataGridViewProducts);

            // Поля редактирования
            txtName = new TextBox { Location = new Point(550, 40), Width = 150 };
            txtStillage = new TextBox { Location = new Point(550, 80), Width = 150 };
            txtCell = new TextBox { Location = new Point(550, 120), Width = 150 };
            txtQuantity = new TextBox { Location = new Point(550, 160), Width = 150 };

            this.Controls.Add(txtName);
            this.Controls.Add(txtStillage);
            this.Controls.Add(txtCell);
            this.Controls.Add(txtQuantity);

            // Поля поиска
            txtSearchName = new TextBox { Location = new Point(20, 250), Width = 150 };
            txtSearchStillage = new TextBox { Location = new Point(200, 250), Width = 80 };
            txtSearchCell = new TextBox { Location = new Point(300, 250), Width = 80 };

            this.Controls.Add(txtSearchName);
            this.Controls.Add(txtSearchStillage);
            this.Controls.Add(txtSearchCell);

            // Кнопки
            btnUpdate = new Button { Text = "Обновить", Location = new Point(550, 200), Size = new Size(70, 25) };
            btnDelete = new Button { Text = "Удалить", Location = new Point(630, 200), Size = new Size(70, 25) };
            btnSaveToFile = new Button { Text = "Сохранить в файл", Location = new Point(550, 235), Size = new Size(150, 25) };
            btnSearchByName = new Button { Text = "Поиск по названию", Location = new Point(20, 280), Size = new Size(150, 25) };
            btnSearchByLocation = new Button { Text = "Поиск по координатам", Location = new Point(200, 280), Size = new Size(150, 25) };
            btnRefresh = new Button { Text = "Обновить", Location = new Point(550, 270), Size = new Size(150, 25) };

            this.Controls.Add(btnUpdate);
            this.Controls.Add(btnDelete);
            this.Controls.Add(btnSaveToFile);
            this.Controls.Add(btnSearchByName);
            this.Controls.Add(btnSearchByLocation);
            this.Controls.Add(btnRefresh);

            // Метки
            lblName = new Label { Text = "Название:", Location = new Point(550, 20) };
            lblStillage = new Label { Text = "Стеллаж:", Location = new Point(550, 60) };
            lblCell = new Label { Text = "Ячейка:", Location = new Point(550, 100) };
            lblQuantity = new Label { Text = "Количество:", Location = new Point(550, 140) };
            lblSearchName = new Label { Text = "Поиск по названию:", Location = new Point(20, 230) };
            lblSearchLocation = new Label { Text = "Поиск по координатам:", Location = new Point(200, 230) };

            this.Controls.Add(lblName);
            this.Controls.Add(lblStillage);
            this.Controls.Add(lblCell);
            this.Controls.Add(lblQuantity);
            this.Controls.Add(lblSearchName);
            this.Controls.Add(lblSearchLocation);

            // События
            btnUpdate.Click += btnUpdate_Click;
            btnDelete.Click += btnDelete_Click;
            btnSaveToFile.Click += btnSaveToFile_Click;
            btnSearchByName.Click += btnSearchByName_Click;
            btnSearchByLocation.Click += btnSearchByLocation_Click;
            btnRefresh.Click += btnRefresh_Click;
            dataGridViewProducts.SelectionChanged += dataGridViewProducts_SelectionChanged;
        }

        private void LoadProducts()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM products";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridViewProducts.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных: {ex.Message}");
            }
        }

        // Модуль 1: Управление продуктами
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducts.CurrentRow != null)
            {
                try
                {
                    int id = Convert.ToInt32(dataGridViewProducts.CurrentRow.Cells["id"].Value);
                    string name = txtName.Text;
                    int stillage = Convert.ToInt32(txtStillage.Text);
                    int cell = Convert.ToInt32(txtCell.Text);
                    int quantity = Convert.ToInt32(txtQuantity.Text);

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        string query = "UPDATE products SET name=@name, stillage=@stillage, cell=@cell, quantity=@quantity WHERE id=@id";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@stillage", stillage);
                        command.Parameters.AddWithValue("@cell", cell);
                        command.Parameters.AddWithValue("@quantity", quantity);
                        command.Parameters.AddWithValue("@id", id);

                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                    LoadProducts();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка обновления: {ex.Message}");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducts.CurrentRow != null)
            {
                try
                {
                    int id = Convert.ToInt32(dataGridViewProducts.CurrentRow.Cells["id"].Value);

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        string query = "DELETE FROM products WHERE id=@id";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@id", id);

                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                    LoadProducts();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка удаления: {ex.Message}");
                }
            }
        }

        private void btnSaveToFile_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text files (*.txt)|*.txt";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                    {
                        foreach (DataGridViewRow row in dataGridViewProducts.Rows)
                        {
                            if (!row.IsNewRow)
                            {
                                writer.WriteLine($"{row.Cells["id"].Value}\t{row.Cells["name"].Value}\t{row.Cells["stillage"].Value}\t{row.Cells["cell"].Value}\t{row.Cells["quantity"].Value}");
                            }
                        }
                    }
                    MessageBox.Show("Данные сохранены в файл");
                }
            }
        }

        // Модуль 2: Поиск по названию
        private void btnSearchByName_Click(object sender, EventArgs e)
        {
            string searchName = txtSearchName.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM products WHERE name LIKE @name";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@name", "%" + searchName + "%");
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridViewProducts.DataSource = table;
            }
        }

        // Модуль 3: Поиск по координатам
        private void btnSearchByLocation_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtSearchStillage.Text, out int stillage) &&
                int.TryParse(txtSearchCell.Text, out int cell))
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM products WHERE stillage=@stillage AND cell=@cell";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@stillage", stillage);
                    adapter.SelectCommand.Parameters.AddWithValue("@cell", cell);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridViewProducts.DataSource = table;
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void dataGridViewProducts_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewProducts.CurrentRow != null)
            {
                txtName.Text = dataGridViewProducts.CurrentRow.Cells["name"].Value?.ToString();
                txtStillage.Text = dataGridViewProducts.CurrentRow.Cells["stillage"].Value?.ToString();
                txtCell.Text = dataGridViewProducts.CurrentRow.Cells["cell"].Value?.ToString();
                txtQuantity.Text = dataGridViewProducts.CurrentRow.Cells["quantity"].Value?.ToString();
            }
        }
    }
}