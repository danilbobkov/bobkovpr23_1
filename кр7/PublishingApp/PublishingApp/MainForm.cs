using System;
using System.Windows.Forms;
using PublishingApp.Models;

namespace PublishingApp
{
    public partial class MainForm : Form
    {
        private DatabaseHelper dbHelper;
        private Book selectedBook;

        public MainForm()
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper();

            try
            {
                if (!dbHelper.TestConnection())
                {
                    MessageBox.Show("Ошибка подключения к базе данных!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Environment.Exit(1);
                }

                LoadBooks();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadBooks()
        {
            try
            {
                var books = dbHelper.GetBooks();
                dataGridViewBooks.DataSource = books;

                dataGridViewBooks.Columns["Id"].Visible = false;
                dataGridViewBooks.Columns["AuthorId"].Visible = false;
                dataGridViewBooks.Columns["Title"].HeaderText = "Название";
                dataGridViewBooks.Columns["AuthorName"].HeaderText = "Автор";
                dataGridViewBooks.Columns["ReleaseYear"].HeaderText = "Год выпуска";
                dataGridViewBooks.Columns["Pages"].HeaderText = "Страниц";
                dataGridViewBooks.Columns["Circulation"].HeaderText = "Тираж";
                dataGridViewBooks.Columns["Price"].HeaderText = "Цена";
                dataGridViewBooks.Columns["Price"].DefaultCellStyle.Format = "C2";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке книг: {ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewBooks_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewBooks.SelectedRows.Count > 0)
            {
                selectedBook = dataGridViewBooks.SelectedRows[0].DataBoundItem as Book;
                btnOrder.Enabled = selectedBook != null;
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (selectedBook == null)
            {
                MessageBox.Show("Выберите книгу для оформления предзаказа!",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                FormOrder orderForm = new FormOrder(selectedBook);
                if (orderForm.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Предзаказ успешно оформлен!", "Успех",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при оформлении заказа: {ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            dbHelper.Dispose();
        }
    }
}