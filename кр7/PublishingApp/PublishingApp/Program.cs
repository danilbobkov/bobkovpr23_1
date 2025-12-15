using System;
using System.Windows.Forms;

namespace PublishingApp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                Application.Run(new MainForm());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Критическая ошибка: {ex.Message}\n{ex.StackTrace}",
                    "Ошибка приложения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}