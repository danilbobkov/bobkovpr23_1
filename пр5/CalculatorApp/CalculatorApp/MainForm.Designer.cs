namespace CalculatorApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.historyLabel = new System.Windows.Forms.Label();
            this.button0 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.subtractButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.divideButton = new System.Windows.Forms.Button();
            this.equalsButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.decimalButton = new System.Windows.Forms.Button();
            this.backspaceButton = new System.Windows.Forms.Button();
            this.plusMinusButton = new System.Windows.Forms.Button();
            this.percentButton = new System.Windows.Forms.Button();
            this.squareRootButton = new System.Windows.Forms.Button();
            this.powerButton = new System.Windows.Forms.Button();
            this.scientificPanel = new System.Windows.Forms.Panel();
            this.lnButton = new System.Windows.Forms.Button();
            this.logButton = new System.Windows.Forms.Button();
            this.angleModeLabel = new System.Windows.Forms.Label();
            this.toggleAngleModeButton = new System.Windows.Forms.Button();
            this.factorialButton = new System.Windows.Forms.Button();
            this.eulerButton = new System.Windows.Forms.Button();
            this.piButton = new System.Windows.Forms.Button();
            this.arcTanButton = new System.Windows.Forms.Button();
            this.arcCosButton = new System.Windows.Forms.Button();
            this.arcSinButton = new System.Windows.Forms.Button();
            this.tanButton = new System.Windows.Forms.Button();
            this.cosButton = new System.Windows.Forms.Button();
            this.sinButton = new System.Windows.Forms.Button();
            this.toggleScientificModeButton = new System.Windows.Forms.Button();
            this.modeLabel = new System.Windows.Forms.Label();
            this.memoryLabel = new System.Windows.Forms.Label();
            this.memoryStoreButton = new System.Windows.Forms.Button();
            this.memoryRecallButton = new System.Windows.Forms.Button();
            this.memoryClearButton = new System.Windows.Forms.Button();
            this.memoryAddButton = new System.Windows.Forms.Button();
            this.memorySubtractButton = new System.Windows.Forms.Button();
            this.scientificPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // resultTextBox
            // 
            this.resultTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultTextBox.Location = new System.Drawing.Point(12, 40);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.Size = new System.Drawing.Size(300, 35);
            this.resultTextBox.TabIndex = 0;
            this.resultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // historyLabel
            // 
            this.historyLabel.AutoSize = true;
            this.historyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.historyLabel.Location = new System.Drawing.Point(12, 20);
            this.historyLabel.Name = "historyLabel";
            this.historyLabel.Size = new System.Drawing.Size(0, 15);
            this.historyLabel.TabIndex = 1;
            // 
            // button0
            // 
            this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button0.Location = new System.Drawing.Point(12, 220);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(60, 40);
            this.button0.TabIndex = 2;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(78, 174);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 40);
            this.button2.TabIndex = 4;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(144, 174);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 40);
            this.button3.TabIndex = 5;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(12, 128);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(60, 40);
            this.button4.TabIndex = 6;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(78, 128);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(60, 40);
            this.button5.TabIndex = 7;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(144, 128);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(60, 40);
            this.button6.TabIndex = 8;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(12, 82);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(60, 40);
            this.button7.TabIndex = 9;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.Location = new System.Drawing.Point(78, 82);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(60, 40);
            this.button8.TabIndex = 10;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button9.Location = new System.Drawing.Point(144, 82);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(60, 40);
            this.button9.TabIndex = 11;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.Location = new System.Drawing.Point(210, 220);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(60, 40);
            this.addButton.TabIndex = 12;
            this.addButton.Text = "+";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // subtractButton
            // 
            this.subtractButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subtractButton.Location = new System.Drawing.Point(210, 174);
            this.subtractButton.Name = "subtractButton";
            this.subtractButton.Size = new System.Drawing.Size(60, 40);
            this.subtractButton.TabIndex = 13;
            this.subtractButton.Text = "-";
            this.subtractButton.UseVisualStyleBackColor = true;
            this.subtractButton.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // multiplyButton
            // 
            this.multiplyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.multiplyButton.Location = new System.Drawing.Point(210, 128);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(60, 40);
            this.multiplyButton.TabIndex = 14;
            this.multiplyButton.Text = "×";
            this.multiplyButton.UseVisualStyleBackColor = true;
            this.multiplyButton.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // divideButton
            // 
            this.divideButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.divideButton.Location = new System.Drawing.Point(210, 82);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(60, 40);
            this.divideButton.TabIndex = 15;
            this.divideButton.Text = "÷";
            this.divideButton.UseVisualStyleBackColor = true;
            this.divideButton.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // equalsButton
            // 
            this.equalsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.equalsButton.Location = new System.Drawing.Point(144, 220);
            this.equalsButton.Name = "equalsButton";
            this.equalsButton.Size = new System.Drawing.Size(60, 40);
            this.equalsButton.TabIndex = 16;
            this.equalsButton.Text = "=";
            this.equalsButton.UseVisualStyleBackColor = true;
            this.equalsButton.Click += new System.EventHandler(this.EqualsButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearButton.Location = new System.Drawing.Point(12, 266);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(126, 40);
            this.clearButton.TabIndex = 17;
            this.clearButton.Text = "C (Очистить)";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // decimalButton
            // 
            this.decimalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.decimalButton.Location = new System.Drawing.Point(78, 220);
            this.decimalButton.Name = "decimalButton";
            this.decimalButton.Size = new System.Drawing.Size(60, 40);
            this.decimalButton.TabIndex = 18;
            this.decimalButton.Text = ".";
            this.decimalButton.UseVisualStyleBackColor = true;
            this.decimalButton.Click += new System.EventHandler(this.DecimalButton_Click);
            // 
            // backspaceButton
            // 
            this.backspaceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backspaceButton.Location = new System.Drawing.Point(144, 266);
            this.backspaceButton.Name = "backspaceButton";
            this.backspaceButton.Size = new System.Drawing.Size(126, 40);
            this.backspaceButton.TabIndex = 19;
            this.backspaceButton.Text = "⌫ (Назад)";
            this.backspaceButton.UseVisualStyleBackColor = true;
            this.backspaceButton.Click += new System.EventHandler(this.BackspaceButton_Click);
            // 
            // plusMinusButton
            // 
            this.plusMinusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plusMinusButton.Location = new System.Drawing.Point(12, 312);
            this.plusMinusButton.Name = "plusMinusButton";
            this.plusMinusButton.Size = new System.Drawing.Size(60, 40);
            this.plusMinusButton.TabIndex = 20;
            this.plusMinusButton.Text = "±";
            this.plusMinusButton.UseVisualStyleBackColor = true;
            this.plusMinusButton.Click += new System.EventHandler(this.PlusMinusButton_Click);
            // 
            // percentButton
            // 
            this.percentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.percentButton.Location = new System.Drawing.Point(78, 312);
            this.percentButton.Name = "percentButton";
            this.percentButton.Size = new System.Drawing.Size(60, 40);
            this.percentButton.TabIndex = 21;
            this.percentButton.Text = "%";
            this.percentButton.UseVisualStyleBackColor = true;
            this.percentButton.Click += new System.EventHandler(this.PercentButton_Click);
            // 
            // squareRootButton
            // 
            this.squareRootButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.squareRootButton.Location = new System.Drawing.Point(144, 312);
            this.squareRootButton.Name = "squareRootButton";
            this.squareRootButton.Size = new System.Drawing.Size(60, 40);
            this.squareRootButton.TabIndex = 22;
            this.squareRootButton.Text = "√";
            this.squareRootButton.UseVisualStyleBackColor = true;
            this.squareRootButton.Click += new System.EventHandler(this.SquareRootButton_Click);
            // 
            // powerButton
            // 
            this.powerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.powerButton.Location = new System.Drawing.Point(210, 312);
            this.powerButton.Name = "powerButton";
            this.powerButton.Size = new System.Drawing.Size(60, 40);
            this.powerButton.TabIndex = 23;
            this.powerButton.Text = "^";
            this.powerButton.UseVisualStyleBackColor = true;
            this.powerButton.Click += new System.EventHandler(this.PowerButton_Click);
            // 
            // scientificPanel
            // 
            this.scientificPanel.Controls.Add(this.lnButton);
            this.scientificPanel.Controls.Add(this.logButton);
            this.scientificPanel.Controls.Add(this.angleModeLabel);
            this.scientificPanel.Controls.Add(this.toggleAngleModeButton);
            this.scientificPanel.Controls.Add(this.factorialButton);
            this.scientificPanel.Controls.Add(this.eulerButton);
            this.scientificPanel.Controls.Add(this.piButton);
            this.scientificPanel.Controls.Add(this.arcTanButton);
            this.scientificPanel.Controls.Add(this.arcCosButton);
            this.scientificPanel.Controls.Add(this.arcSinButton);
            this.scientificPanel.Controls.Add(this.tanButton);
            this.scientificPanel.Controls.Add(this.cosButton);
            this.scientificPanel.Controls.Add(this.sinButton);
            this.scientificPanel.Location = new System.Drawing.Point(276, 40);
            this.scientificPanel.Name = "scientificPanel";
            this.scientificPanel.Size = new System.Drawing.Size(200, 320);
            this.scientificPanel.TabIndex = 24;
            // 
            // lnButton
            // 
            this.lnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lnButton.Location = new System.Drawing.Point(70, 220);
            this.lnButton.Name = "lnButton";
            this.lnButton.Size = new System.Drawing.Size(60, 40);
            this.lnButton.TabIndex = 36;
            this.lnButton.Text = "ln";
            this.lnButton.UseVisualStyleBackColor = true;
            this.lnButton.Click += new System.EventHandler(this.LnButton_Click);
            // 
            // logButton
            // 
            this.logButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logButton.Location = new System.Drawing.Point(4, 220);
            this.logButton.Name = "logButton";
            this.logButton.Size = new System.Drawing.Size(60, 40);
            this.logButton.TabIndex = 35;
            this.logButton.Text = "log₁₀";
            this.logButton.UseVisualStyleBackColor = true;
            this.logButton.Click += new System.EventHandler(this.LogButton_Click);
            // 
            // angleModeLabel
            // 
            this.angleModeLabel.AutoSize = true;
            this.angleModeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.angleModeLabel.Location = new System.Drawing.Point(90, 285);
            this.angleModeLabel.Name = "angleModeLabel";
            this.angleModeLabel.Size = new System.Drawing.Size(103, 13);
            this.angleModeLabel.TabIndex = 34;
            this.angleModeLabel.Text = "Режим: Радианы";
            // 
            // toggleAngleModeButton
            // 
            this.toggleAngleModeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toggleAngleModeButton.Location = new System.Drawing.Point(4, 275);
            this.toggleAngleModeButton.Name = "toggleAngleModeButton";
            this.toggleAngleModeButton.Size = new System.Drawing.Size(80, 40);
            this.toggleAngleModeButton.TabIndex = 33;
            this.toggleAngleModeButton.Text = "RAD";
            this.toggleAngleModeButton.UseVisualStyleBackColor = true;
            this.toggleAngleModeButton.Click += new System.EventHandler(this.ToggleAngleModeButton_Click);
            // 
            // factorialButton
            // 
            this.factorialButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.factorialButton.Location = new System.Drawing.Point(4, 175);
            this.factorialButton.Name = "factorialButton";
            this.factorialButton.Size = new System.Drawing.Size(126, 40);
            this.factorialButton.TabIndex = 32;
            this.factorialButton.Text = "n! (Факториал)";
            this.factorialButton.UseVisualStyleBackColor = true;
            this.factorialButton.Click += new System.EventHandler(this.FactorialButton_Click);
            // 
            // eulerButton
            // 
            this.eulerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eulerButton.Location = new System.Drawing.Point(136, 130);
            this.eulerButton.Name = "eulerButton";
            this.eulerButton.Size = new System.Drawing.Size(60, 40);
            this.eulerButton.TabIndex = 31;
            this.eulerButton.Text = "e";
            this.eulerButton.UseVisualStyleBackColor = true;
            this.eulerButton.Click += new System.EventHandler(this.EulerButton_Click);
            // 
            // piButton
            // 
            this.piButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.piButton.Location = new System.Drawing.Point(70, 130);
            this.piButton.Name = "piButton";
            this.piButton.Size = new System.Drawing.Size(60, 40);
            this.piButton.TabIndex = 30;
            this.piButton.Text = "π";
            this.piButton.UseVisualStyleBackColor = true;
            this.piButton.Click += new System.EventHandler(this.PiButton_Click);
            // 
            // arcTanButton
            // 
            this.arcTanButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.arcTanButton.Location = new System.Drawing.Point(136, 85);
            this.arcTanButton.Name = "arcTanButton";
            this.arcTanButton.Size = new System.Drawing.Size(60, 40);
            this.arcTanButton.TabIndex = 29;
            this.arcTanButton.Text = "arctan";
            this.arcTanButton.UseVisualStyleBackColor = true;
            this.arcTanButton.Click += new System.EventHandler(this.ArcTanButton_Click);
            // 
            // arcCosButton
            // 
            this.arcCosButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.arcCosButton.Location = new System.Drawing.Point(70, 85);
            this.arcCosButton.Name = "arcCosButton";
            this.arcCosButton.Size = new System.Drawing.Size(60, 40);
            this.arcCosButton.TabIndex = 28;
            this.arcCosButton.Text = "arccos";
            this.arcCosButton.UseVisualStyleBackColor = true;
            this.arcCosButton.Click += new System.EventHandler(this.ArcCosButton_Click);
            // 
            // arcSinButton
            // 
            this.arcSinButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.arcSinButton.Location = new System.Drawing.Point(4, 85);
            this.arcSinButton.Name = "arcSinButton";
            this.arcSinButton.Size = new System.Drawing.Size(60, 40);
            this.arcSinButton.TabIndex = 27;
            this.arcSinButton.Text = "arcsin";
            this.arcSinButton.UseVisualStyleBackColor = true;
            this.arcSinButton.Click += new System.EventHandler(this.ArcSinButton_Click);
            // 
            // tanButton
            // 
            this.tanButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tanButton.Location = new System.Drawing.Point(136, 40);
            this.tanButton.Name = "tanButton";
            this.tanButton.Size = new System.Drawing.Size(60, 40);
            this.tanButton.TabIndex = 26;
            this.tanButton.Text = "tan";
            this.tanButton.UseVisualStyleBackColor = true;
            this.tanButton.Click += new System.EventHandler(this.TanButton_Click);
            // 
            // cosButton
            // 
            this.cosButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cosButton.Location = new System.Drawing.Point(70, 40);
            this.cosButton.Name = "cosButton";
            this.cosButton.Size = new System.Drawing.Size(60, 40);
            this.cosButton.TabIndex = 25;
            this.cosButton.Text = "cos";
            this.cosButton.UseVisualStyleBackColor = true;
            this.cosButton.Click += new System.EventHandler(this.CosButton_Click);
            // 
            // sinButton
            // 
            this.sinButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sinButton.Location = new System.Drawing.Point(4, 40);
            this.sinButton.Name = "sinButton";
            this.sinButton.Size = new System.Drawing.Size(60, 40);
            this.sinButton.TabIndex = 24;
            this.sinButton.Text = "sin";
            this.sinButton.UseVisualStyleBackColor = true;
            this.sinButton.Click += new System.EventHandler(this.SinButton_Click);
            // 
            // toggleScientificModeButton
            // 
            this.toggleScientificModeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toggleScientificModeButton.Location = new System.Drawing.Point(12, 358);
            this.toggleScientificModeButton.Name = "toggleScientificModeButton";
            this.toggleScientificModeButton.Size = new System.Drawing.Size(100, 40);
            this.toggleScientificModeButton.TabIndex = 25;
            this.toggleScientificModeButton.Text = "Научный";
            this.toggleScientificModeButton.UseVisualStyleBackColor = true;
            this.toggleScientificModeButton.Click += new System.EventHandler(this.ToggleScientificModeButton_Click);
            // 
            // modeLabel
            // 
            this.modeLabel.AutoSize = true;
            this.modeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.modeLabel.Location = new System.Drawing.Point(118, 370);
            this.modeLabel.Name = "modeLabel";
            this.modeLabel.Size = new System.Drawing.Size(119, 17);
            this.modeLabel.TabIndex = 26;
            this.modeLabel.Text = "Обычный режим";
            // 
            // memoryLabel
            // 
            this.memoryLabel.AutoSize = true;
            this.memoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.memoryLabel.Location = new System.Drawing.Point(12, 400);
            this.memoryLabel.Name = "memoryLabel";
            this.memoryLabel.Size = new System.Drawing.Size(33, 15);
            this.memoryLabel.TabIndex = 27;
            this.memoryLabel.Text = "M: 0";
            // 
            // memoryStoreButton
            // 
            this.memoryStoreButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.memoryStoreButton.Location = new System.Drawing.Point(60, 400);
            this.memoryStoreButton.Name = "memoryStoreButton";
            this.memoryStoreButton.Size = new System.Drawing.Size(40, 25);
            this.memoryStoreButton.TabIndex = 28;
            this.memoryStoreButton.Text = "MS";
            this.memoryStoreButton.UseVisualStyleBackColor = true;
            this.memoryStoreButton.Click += new System.EventHandler(this.MemoryStoreButton_Click);
            // 
            // memoryRecallButton
            // 
            this.memoryRecallButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.memoryRecallButton.Location = new System.Drawing.Point(106, 400);
            this.memoryRecallButton.Name = "memoryRecallButton";
            this.memoryRecallButton.Size = new System.Drawing.Size(40, 25);
            this.memoryRecallButton.TabIndex = 29;
            this.memoryRecallButton.Text = "MR";
            this.memoryRecallButton.UseVisualStyleBackColor = true;
            this.memoryRecallButton.Click += new System.EventHandler(this.MemoryRecallButton_Click);
            // 
            // memoryClearButton
            // 
            this.memoryClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.memoryClearButton.Location = new System.Drawing.Point(152, 400);
            this.memoryClearButton.Name = "memoryClearButton";
            this.memoryClearButton.Size = new System.Drawing.Size(40, 25);
            this.memoryClearButton.TabIndex = 30;
            this.memoryClearButton.Text = "MC";
            this.memoryClearButton.UseVisualStyleBackColor = true;
            this.memoryClearButton.Click += new System.EventHandler(this.MemoryClearButton_Click);
            // 
            // memoryAddButton
            // 
            this.memoryAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.memoryAddButton.Location = new System.Drawing.Point(198, 400);
            this.memoryAddButton.Name = "memoryAddButton";
            this.memoryAddButton.Size = new System.Drawing.Size(40, 25);
            this.memoryAddButton.TabIndex = 31;
            this.memoryAddButton.Text = "M+";
            this.memoryAddButton.UseVisualStyleBackColor = true;
            this.memoryAddButton.Click += new System.EventHandler(this.MemoryAddButton_Click);
            // 
            // memorySubtractButton
            // 
            this.memorySubtractButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.memorySubtractButton.Location = new System.Drawing.Point(244, 400);
            this.memorySubtractButton.Name = "memorySubtractButton";
            this.memorySubtractButton.Size = new System.Drawing.Size(40, 25);
            this.memorySubtractButton.TabIndex = 32;
            this.memorySubtractButton.Text = "M-";
            this.memorySubtractButton.UseVisualStyleBackColor = true;
            this.memorySubtractButton.Click += new System.EventHandler(this.MemorySubtractButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 430);
            this.Controls.Add(this.memorySubtractButton);
            this.Controls.Add(this.memoryAddButton);
            this.Controls.Add(this.memoryClearButton);
            this.Controls.Add(this.memoryRecallButton);
            this.Controls.Add(this.memoryStoreButton);
            this.Controls.Add(this.memoryLabel);
            this.Controls.Add(this.modeLabel);
            this.Controls.Add(this.toggleScientificModeButton);
            this.Controls.Add(this.scientificPanel);
            this.Controls.Add(this.powerButton);
            this.Controls.Add(this.squareRootButton);
            this.Controls.Add(this.percentButton);
            this.Controls.Add(this.plusMinusButton);
            this.Controls.Add(this.backspaceButton);
            this.Controls.Add(this.decimalButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.equalsButton);
            this.Controls.Add(this.divideButton);
            this.Controls.Add(this.multiplyButton);
            this.Controls.Add(this.subtractButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.historyLabel);
            this.Controls.Add(this.resultTextBox);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(356, 469);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Универсальный калькулятор";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.scientificPanel.ResumeLayout(false);
            this.scientificPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Label historyLabel;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button subtractButton;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Button divideButton;
        private System.Windows.Forms.Button equalsButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button decimalButton;
        private System.Windows.Forms.Button backspaceButton;
        private System.Windows.Forms.Button plusMinusButton;
        private System.Windows.Forms.Button percentButton;
        private System.Windows.Forms.Button squareRootButton;
        private System.Windows.Forms.Button powerButton;
        private System.Windows.Forms.Panel scientificPanel;
        private System.Windows.Forms.Button sinButton;
        private System.Windows.Forms.Button cosButton;
        private System.Windows.Forms.Button tanButton;
        private System.Windows.Forms.Button arcSinButton;
        private System.Windows.Forms.Button arcCosButton;
        private System.Windows.Forms.Button arcTanButton;
        private System.Windows.Forms.Button piButton;
        private System.Windows.Forms.Button eulerButton;
        private System.Windows.Forms.Button factorialButton;
        private System.Windows.Forms.Button toggleAngleModeButton;
        private System.Windows.Forms.Label angleModeLabel;
        private System.Windows.Forms.Button logButton;
        private System.Windows.Forms.Button lnButton;
        private System.Windows.Forms.Button toggleScientificModeButton;
        private System.Windows.Forms.Label modeLabel;
        private System.Windows.Forms.Label memoryLabel;
        private System.Windows.Forms.Button memoryStoreButton;
        private System.Windows.Forms.Button memoryRecallButton;
        private System.Windows.Forms.Button memoryClearButton;
        private System.Windows.Forms.Button memoryAddButton;
        private System.Windows.Forms.Button memorySubtractButton;
    }
}