using System;
using System.Text;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class MainForm : Form
    {
        private double firstNumber = 0;
        private double secondNumber = 0;
        private string operation = "";
        private bool isNewOperation = true;
        private bool isScientificMode = false;
        private bool isRadiansMode = true;
        private double memoryValue = 0; // Вместо использования настроек

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            resultTextBox.Text = "0";
            scientificPanel.Visible = false;
            UpdateAngleModeDisplay();
            UpdateModeLabel();
            AdjustFormSize();
            memoryLabel.Text = "M: 0";
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (isNewOperation || resultTextBox.Text == "0")
            {
                resultTextBox.Text = button.Text;
                isNewOperation = false;
            }
            else
            {
                resultTextBox.Text += button.Text;
            }
        }

        private void OperationButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            try
            {
                firstNumber = double.Parse(resultTextBox.Text);
                operation = button.Text;
                isNewOperation = true;
                historyLabel.Text = $"{firstNumber} {operation}";
            }
            catch
            {
                MessageBox.Show("Некорректное число", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EqualsButton_Click(object sender, EventArgs e)
        {
            if (operation == "" || isNewOperation)
                return;

            try
            {
                secondNumber = double.Parse(resultTextBox.Text);
                double result = 0;

                switch (operation)
                {
                    case "+":
                        result = firstNumber + secondNumber;
                        break;
                    case "-":
                        result = firstNumber - secondNumber;
                        break;
                    case "×":
                        result = firstNumber * secondNumber;
                        break;
                    case "÷":
                        if (secondNumber == 0)
                        {
                            MessageBox.Show("Деление на ноль невозможно!", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        result = firstNumber / secondNumber;
                        break;
                    case "^":
                        result = Math.Pow(firstNumber, secondNumber);
                        break;
                }

                // Обновляем историю
                historyLabel.Text = $"{firstNumber} {operation} {secondNumber} = {result:F8}";

                // Отображаем результат
                resultTextBox.Text = result.ToString("F8");

                // Сбрасываем операцию
                operation = "";
                isNewOperation = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка вычисления: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = "0";
            firstNumber = 0;
            secondNumber = 0;
            operation = "";
            isNewOperation = true;
            historyLabel.Text = "";
        }

        private void BackspaceButton_Click(object sender, EventArgs e)
        {
            if (resultTextBox.Text.Length > 1)
            {
                resultTextBox.Text = resultTextBox.Text.Substring(0, resultTextBox.Text.Length - 1);
            }
            else
            {
                resultTextBox.Text = "0";
                isNewOperation = true;
            }
        }

        private void DecimalButton_Click(object sender, EventArgs e)
        {
            if (!resultTextBox.Text.Contains("."))
            {
                resultTextBox.Text += ".";
                isNewOperation = false;
            }
        }

        private void PlusMinusButton_Click(object sender, EventArgs e)
        {
            try
            {
                double currentValue = double.Parse(resultTextBox.Text);
                currentValue = -currentValue;
                resultTextBox.Text = currentValue.ToString();
            }
            catch
            {
                MessageBox.Show("Некорректное число", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PercentButton_Click(object sender, EventArgs e)
        {
            try
            {
                double currentValue = double.Parse(resultTextBox.Text);
                currentValue = currentValue / 100;
                resultTextBox.Text = currentValue.ToString("F8");
            }
            catch
            {
                MessageBox.Show("Некорректное число", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SquareRootButton_Click(object sender, EventArgs e)
        {
            try
            {
                double number = double.Parse(resultTextBox.Text);

                if (number < 0)
                {
                    MessageBox.Show("Корень из отрицательного числа!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                double result = Math.Sqrt(number);
                historyLabel.Text = $"√{number} = {result:F8}";
                resultTextBox.Text = result.ToString("F8");
                isNewOperation = true;
            }
            catch
            {
                MessageBox.Show("Некорректное число", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PowerButton_Click(object sender, EventArgs e)
        {
            try
            {
                firstNumber = double.Parse(resultTextBox.Text);
                operation = "^";
                isNewOperation = true;
                historyLabel.Text = $"{firstNumber} ^";
            }
            catch
            {
                MessageBox.Show("Некорректное число", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Тригонометрические функции
        private void SinButton_Click(object sender, EventArgs e)
        {
            CalculateTrigonometricFunction("sin");
        }

        private void CosButton_Click(object sender, EventArgs e)
        {
            CalculateTrigonometricFunction("cos");
        }

        private void TanButton_Click(object sender, EventArgs e)
        {
            CalculateTrigonometricFunction("tan");
        }

        private void ArcSinButton_Click(object sender, EventArgs e)
        {
            CalculateInverseTrigonometricFunction("arcsin");
        }

        private void ArcCosButton_Click(object sender, EventArgs e)
        {
            CalculateInverseTrigonometricFunction("arccos");
        }

        private void ArcTanButton_Click(object sender, EventArgs e)
        {
            CalculateInverseTrigonometricFunction("arctan");
        }

        private void PiButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = Math.PI.ToString("F8");
            isNewOperation = true;
        }

        private void EulerButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = Math.E.ToString("F8");
            isNewOperation = true;
        }

        private void FactorialButton_Click(object sender, EventArgs e)
        {
            try
            {
                int number = (int)double.Parse(resultTextBox.Text);

                if (number < 0)
                {
                    MessageBox.Show("Факториал определен только для неотрицательных чисел!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (number > 20) // Ограничение для предотвращения переполнения
                {
                    MessageBox.Show("Слишком большое число для вычисления факториала!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                long result = CalculateFactorial(number);
                historyLabel.Text = $"{number}! = {result}";
                resultTextBox.Text = result.ToString();
                isNewOperation = true;
            }
            catch
            {
                MessageBox.Show("Некорректное число для факториала!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private long CalculateFactorial(int n)
        {
            long result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }

        private void CalculateTrigonometricFunction(string function)
        {
            try
            {
                double angle = double.Parse(resultTextBox.Text);
                double angleInRadians = angle;

                // Если режим градусов, преобразуем в радианы
                if (!isRadiansMode)
                {
                    angleInRadians = angle * Math.PI / 180.0;
                }

                double result = 0;
                string funcName = "";

                switch (function)
                {
                    case "sin":
                        result = Math.Sin(angleInRadians);
                        funcName = "sin";
                        break;
                    case "cos":
                        result = Math.Cos(angleInRadians);
                        funcName = "cos";
                        break;
                    case "tan":
                        // Проверка на особые углы для тангенса
                        if (!isRadiansMode)
                        {
                            if (Math.Abs(angle % 90) < 1e-10 && Math.Abs(angle % 180) > 1e-10)
                            {
                                MessageBox.Show("Тангенс не определен для данного угла!", "Ошибка",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        else
                        {
                            if (Math.Abs(angle % (Math.PI / 2)) < 1e-10 && Math.Abs(angle % Math.PI) > 1e-10)
                            {
                                MessageBox.Show("Тангенс не определен для данного угла!", "Ошибка",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        result = Math.Tan(angleInRadians);
                        funcName = "tan";
                        break;
                }

                string angleUnit = isRadiansMode ? "rad" : "°";
                historyLabel.Text = $"{funcName}({angle}{angleUnit}) = {result:F8}";
                resultTextBox.Text = result.ToString("F8");
                isNewOperation = true;
            }
            catch
            {
                MessageBox.Show("Некорректное число для тригонометрической функции!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CalculateInverseTrigonometricFunction(string function)
        {
            try
            {
                double value = double.Parse(resultTextBox.Text);

                // Проверка области определения для арксинуса и арккосинуса
                if ((function == "arcsin" || function == "arccos") && (value < -1 || value > 1))
                {
                    MessageBox.Show("Значение должно быть в диапазоне [-1, 1]!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                double resultInRadians = 0;
                string funcName = "";

                switch (function)
                {
                    case "arcsin":
                        resultInRadians = Math.Asin(value);
                        funcName = "arcsin";
                        break;
                    case "arccos":
                        resultInRadians = Math.Acos(value);
                        funcName = "arccos";
                        break;
                    case "arctan":
                        resultInRadians = Math.Atan(value);
                        funcName = "arctan";
                        break;
                }

                double finalResult = resultInRadians;
                string resultUnit = "rad";

                // Если режим градусов, конвертируем результат в градусы
                if (!isRadiansMode)
                {
                    finalResult = resultInRadians * 180.0 / Math.PI;
                    resultUnit = "°";
                }

                historyLabel.Text = $"{funcName}({value:F4}) = {finalResult:F8} {resultUnit}";
                resultTextBox.Text = finalResult.ToString("F8");
                isNewOperation = true;
            }
            catch
            {
                MessageBox.Show("Некорректное число для обратной тригонометрической функции!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ToggleAngleModeButton_Click(object sender, EventArgs e)
        {
            isRadiansMode = !isRadiansMode;
            UpdateAngleModeDisplay();
        }

        private void UpdateAngleModeDisplay()
        {
            toggleAngleModeButton.Text = isRadiansMode ? "RAD" : "DEG";
            angleModeLabel.Text = isRadiansMode ? "Режим: Радианы" : "Режим: Градусы";
        }

        private void LogButton_Click(object sender, EventArgs e)
        {
            CalculateLogarithm("log");
        }

        private void LnButton_Click(object sender, EventArgs e)
        {
            CalculateLogarithm("ln");
        }

        private void CalculateLogarithm(string logType)
        {
            try
            {
                double number = double.Parse(resultTextBox.Text);

                if (number <= 0)
                {
                    MessageBox.Show("Логарифм определен только для положительных чисел!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                double result = 0;
                string funcName = "";

                switch (logType)
                {
                    case "log":
                        result = Math.Log10(number);
                        funcName = "log₁₀";
                        break;
                    case "ln":
                        result = Math.Log(number);
                        funcName = "ln";
                        break;
                }

                historyLabel.Text = $"{funcName}({number}) = {result:F8}";
                resultTextBox.Text = result.ToString("F8");
                isNewOperation = true;
            }
            catch
            {
                MessageBox.Show("Некорректное число для логарифма!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ToggleScientificModeButton_Click(object sender, EventArgs e)
        {
            isScientificMode = !isScientificMode;
            scientificPanel.Visible = isScientificMode;
            UpdateModeLabel();
            AdjustFormSize();
        }

        private void UpdateModeLabel()
        {
            modeLabel.Text = isScientificMode ? "Научный режим" : "Обычный режим";
            toggleScientificModeButton.Text = isScientificMode ? "Обычный" : "Научный";
        }

        private void AdjustFormSize()
        {
            if (isScientificMode)
            {
                this.Width = 560;
                this.Height = 490;
            }
            else
            {
                this.Width = 340;
                this.Height = 490;
            }
        }

        private void MemoryStoreButton_Click(object sender, EventArgs e)
        {
            try
            {
                double value = double.Parse(resultTextBox.Text);
                memoryValue = value;
                memoryLabel.Text = $"M: {value:F4}";
            }
            catch
            {
                MessageBox.Show("Некорректное число для сохранения в память!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MemoryRecallButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = memoryValue.ToString();
            isNewOperation = true;
        }

        private void MemoryClearButton_Click(object sender, EventArgs e)
        {
            memoryValue = 0;
            memoryLabel.Text = "M: 0";
        }

        private void MemoryAddButton_Click(object sender, EventArgs e)
        {
            try
            {
                double newValue = double.Parse(resultTextBox.Text);
                memoryValue = memoryValue + newValue;
                memoryLabel.Text = $"M: {memoryValue:F4}";
            }
            catch
            {
                MessageBox.Show("Некорректное число!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MemorySubtractButton_Click(object sender, EventArgs e)
        {
            try
            {
                double newValue = double.Parse(resultTextBox.Text);
                memoryValue = memoryValue - newValue;
                memoryLabel.Text = $"M: {memoryValue:F4}";
            }
            catch
            {
                MessageBox.Show("Некорректное число!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}