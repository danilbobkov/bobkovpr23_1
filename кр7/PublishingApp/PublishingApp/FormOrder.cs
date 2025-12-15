using System;
using System.Windows.Forms;
using PublishingApp.Models;

namespace PublishingApp
{
    public partial class FormOrder : Form
    {
        private Book selectedBook;
        private DatabaseHelper dbHelper;

        public FormOrder(Book book)
        {
            InitializeComponent();
            selectedBook = book;
            dbHelper = new DatabaseHelper();

            InitializeForm();
        }

        private void InitializeForm()
        {
            lblBookTitleValue.Text = selectedBook.Title;
            lblAuthorValue.Text = selectedBook.AuthorName;
            lblYearValue.Text = selectedBook.ReleaseYear.ToString();
            lblPriceValue.Text = selectedBook.Price.ToString("C");

            try
            {
                var offices = dbHelper.GetOffices();
                cmbOffice.DataSource = offices;
                cmbOffice.DisplayMember = "Name";
                cmbOffice.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке офисов: {ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtCustomerName.Text))
                {
                    MessageBox.Show("Введите ФИО клиента!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (cmbOffice.SelectedItem == null)
                {
                    MessageBox.Show("Выберите офис для получения!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var customer = new Customer
                {
                    Name = txtCustomerName.Text,
                    Address = txtAddress.Text,
                    Phone = txtPhone.Text,
                    Email = txtEmail.Text
                };

                int customerId = dbHelper.CreateCustomer(customer);

                var order = new Order
                {
                    BookId = selectedBook.Id,
                    BookTitle = selectedBook.Title,
                    CustomerId = customerId,
                    CustomerName = customer.Name,
                    OfficeId = ((Office)cmbOffice.SelectedItem).Id,
                    OfficeName = ((Office)cmbOffice.SelectedItem).Name,
                    OrderDate = DateTime.Now,
                    Price = selectedBook.Price,
                    Quantity = 1
                };

                int orderId = dbHelper.CreateOrder(order);

                var orderDetails = dbHelper.GetOrderDetails(orderId);

                FormReceipt receiptForm = new FormReceipt(orderDetails);
                receiptForm.ShowDialog();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при оформлении заказа: {ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}