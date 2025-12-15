using System;
using System.Drawing;
using System.Windows.Forms;
using PublishingApp.Models;

namespace PublishingApp
{
    public partial class FormReceipt : Form
    {
        private Order order;

        public FormReceipt(Order orderDetails)
        {
            InitializeComponent();
            order = orderDetails;
            DisplayReceipt();
        }

        private void DisplayReceipt()
        {
            if (order == null) return;

            lblReceiptTitle.Text = $"Чек №{order.Id}";
            lblOrderId.Text = order.Id.ToString();
            lblOrderName.Text = order.OrderName;
            lblBookTitle.Text = order.BookTitle;
            lblCustomerName.Text = order.CustomerName;
            lblOfficeName.Text = order.OfficeName;
            lblOrderDate.Text = order.OrderDate.ToString("dd.MM.yyyy HH:mm");
            lblPrice.Text = order.Price.ToString("C");

            rtxtReceipt.Text = $"ЧЕК №{order.Id}\n" +
                $"=============================\n" +
                $"Клиент: {order.CustomerName}\n" +
                $"Книга: {order.BookTitle}\n" +
                $"Офис получения: {order.OfficeName}\n" +
                $"Дата заказа: {order.OrderDate:dd.MM.yyyy HH:mm}\n" +
                $"Сумма: {order.Price:C}\n" +
                $"=============================\n" +
                $"Спасибо за предзаказ!\n" +
                $"Книга будет доступна в офисе через 3-5 дней.\n" +
                $"Контактный телефон: +7 (495) 123-45-67";
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                printDocument.Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при печати: {ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font printFont = new Font("Courier New", 10);
            float yPos = 0;
            float leftMargin = e.MarginBounds.Left;
            float topMargin = e.MarginBounds.Top;

            string[] lines = rtxtReceipt.Text.Split('\n');

            foreach (string line in lines)
            {
                yPos = topMargin + (printFont.GetHeight(e.Graphics) * lines.Length);
                e.Graphics.DrawString(line, printFont, Brushes.Black, leftMargin, yPos, new StringFormat());
                topMargin += printFont.GetHeight(e.Graphics);
            }
        }
    }
}