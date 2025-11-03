using System;
using System.Text;
using System.Windows.Forms;

namespace CaesarCipher
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            SetupComboBoxes();
        }

        private void SetupComboBoxes()
        {
            // Настройка комбобокса для выбора языка
            languageComboBox.Items.Clear();
            languageComboBox.Items.AddRange(new[] { "Русский", "English" });
            languageComboBox.SelectedIndex = 0;

            // Настройка комбобокса для выбора сдвига
            shiftComboBox.Items.Clear();
            for (int i = 1; i <= 10; i++)
            {
                shiftComboBox.Items.Add(i);
            }
            shiftComboBox.SelectedIndex = 2; // Выбор сдвига 3 по умолчанию
        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            ProcessText(true);
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            ProcessText(false);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            inputTextBox.Clear();
            outputTextBox.Clear();
        }

        private void ProcessText(bool encrypt)
        {
            // Проверка ввода
            if (string.IsNullOrWhiteSpace(inputTextBox.Text))
            {
                MessageBox.Show("Введите текст для обработки");
                return;
            }

            if (shiftComboBox.SelectedItem == null)
            {
                MessageBox.Show("Выберите величину сдвига");
                return;
            }

            // Получение параметров
            int shift = (int)shiftComboBox.SelectedItem;
            bool isRussian = languageComboBox.SelectedIndex == 0;
            string alphabet = isRussian ? "абвгдежзийклмнопрстуфхцчшщъыьэюя" : "abcdefghijklmnopqrstuvwxyz";

            // Обработка текста
            StringBuilder result = new StringBuilder();
            foreach (char c in inputTextBox.Text)
            {
                if (char.IsLetter(c))
                {
                    bool isUpper = char.IsUpper(c);
                    char lowerChar = char.ToLower(c);

                    int index = alphabet.IndexOf(lowerChar);
                    if (index >= 0)
                    {
                        int newIndex = encrypt ?
                            (index + shift) % alphabet.Length :
                            (index - shift + alphabet.Length) % alphabet.Length;

                        char newChar = alphabet[newIndex];
                        result.Append(isUpper ? char.ToUpper(newChar) : newChar);
                    }
                    else
                    {
                        result.Append(c);
                    }
                }
                else
                {
                    result.Append(c);
                }
            }

            outputTextBox.Text = result.ToString();
        }
    }
}