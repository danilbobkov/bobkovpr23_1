namespace PublishingApp
{
    partial class FormReceipt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReceipt));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblReceiptTitle = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.groupBoxReceipt = new System.Windows.Forms.GroupBox();
            this.rtxtReceipt = new System.Windows.Forms.RichTextBox();
            this.groupBoxDetails = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lblOrderIdLabel = new System.Windows.Forms.Label();
            this.lblOrderId = new System.Windows.Forms.Label();
            this.lblOrderNameLabel = new System.Windows.Forms.Label();
            this.lblOrderName = new System.Windows.Forms.Label();
            this.lblBookTitleLabel = new System.Windows.Forms.Label();
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.lblCustomerNameLabel = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblOfficeNameLabel = new System.Windows.Forms.Label();
            this.lblOfficeName = new System.Windows.Forms.Label();
            this.lblOrderDateLabel = new System.Windows.Forms.Label();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.lblPriceLabel = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.panelHeader.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.groupBoxReceipt.SuspendLayout();
            this.groupBoxDetails.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.panelFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.SteelBlue;
            this.panelHeader.Controls.Add(this.lblReceiptTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(800, 60);
            this.panelHeader.TabIndex = 0;
            // 
            // lblReceiptTitle
            // 
            this.lblReceiptTitle.AutoSize = true;
            this.lblReceiptTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblReceiptTitle.ForeColor = System.Drawing.Color.White;
            this.lblReceiptTitle.Location = new System.Drawing.Point(20, 15);
            this.lblReceiptTitle.Name = "lblReceiptTitle";
            this.lblReceiptTitle.Size = new System.Drawing.Size(151, 30);
            this.lblReceiptTitle.TabIndex = 0;
            this.lblReceiptTitle.Text = "Чек заказа №";
            // 
            // panelContent
            // 
            this.panelContent.AutoScroll = true;
            this.panelContent.Controls.Add(this.groupBoxReceipt);
            this.panelContent.Controls.Add(this.groupBoxDetails);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 60);
            this.panelContent.Name = "panelContent";
            this.panelContent.Padding = new System.Windows.Forms.Padding(20);
            this.panelContent.Size = new System.Drawing.Size(800, 441);
            this.panelContent.TabIndex = 1;
            // 
            // groupBoxReceipt
            // 
            this.groupBoxReceipt.Controls.Add(this.rtxtReceipt);
            this.groupBoxReceipt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxReceipt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxReceipt.Location = new System.Drawing.Point(20, 240);
            this.groupBoxReceipt.Name = "groupBoxReceipt";
            this.groupBoxReceipt.Size = new System.Drawing.Size(760, 181);
            this.groupBoxReceipt.TabIndex = 1;
            this.groupBoxReceipt.TabStop = false;
            this.groupBoxReceipt.Text = "Текст чека для печати";
            // 
            // rtxtReceipt
            // 
            this.rtxtReceipt.BackColor = System.Drawing.Color.White;
            this.rtxtReceipt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtReceipt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtReceipt.Font = new System.Drawing.Font("Courier New", 10F);
            this.rtxtReceipt.Location = new System.Drawing.Point(3, 21);
            this.rtxtReceipt.Name = "rtxtReceipt";
            this.rtxtReceipt.ReadOnly = true;
            this.rtxtReceipt.Size = new System.Drawing.Size(754, 157);
            this.rtxtReceipt.TabIndex = 0;
            this.rtxtReceipt.Text = "";
            // 
            // groupBoxDetails
            // 
            this.groupBoxDetails.Controls.Add(this.tableLayoutPanel);
            this.groupBoxDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxDetails.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxDetails.Location = new System.Drawing.Point(20, 20);
            this.groupBoxDetails.Name = "groupBoxDetails";
            this.groupBoxDetails.Size = new System.Drawing.Size(760, 220);
            this.groupBoxDetails.TabIndex = 0;
            this.groupBoxDetails.TabStop = false;
            this.groupBoxDetails.Text = "Детали заказа";
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel.Controls.Add(this.lblOrderIdLabel, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.lblOrderId, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.lblOrderNameLabel, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.lblOrderName, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.lblBookTitleLabel, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.lblBookTitle, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.lblCustomerNameLabel, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.lblCustomerName, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.lblOfficeNameLabel, 0, 4);
            this.tableLayoutPanel.Controls.Add(this.lblOfficeName, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.lblOrderDateLabel, 0, 5);
            this.tableLayoutPanel.Controls.Add(this.lblOrderDate, 1, 5);
            this.tableLayoutPanel.Controls.Add(this.lblPriceLabel, 0, 6);
            this.tableLayoutPanel.Controls.Add(this.lblPrice, 1, 6);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(3, 21);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 7;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(754, 196);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // lblOrderIdLabel
            // 
            this.lblOrderIdLabel.AutoSize = true;
            this.lblOrderIdLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOrderIdLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOrderIdLabel.Location = new System.Drawing.Point(3, 0);
            this.lblOrderIdLabel.Name = "lblOrderIdLabel";
            this.lblOrderIdLabel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblOrderIdLabel.Size = new System.Drawing.Size(220, 28);
            this.lblOrderIdLabel.TabIndex = 0;
            this.lblOrderIdLabel.Text = "Номер заказа:";
            this.lblOrderIdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOrderId
            // 
            this.lblOrderId.AutoSize = true;
            this.lblOrderId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOrderId.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOrderId.Location = new System.Drawing.Point(229, 0);
            this.lblOrderId.Name = "lblOrderId";
            this.lblOrderId.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.lblOrderId.Size = new System.Drawing.Size(522, 28);
            this.lblOrderId.TabIndex = 1;
            this.lblOrderId.Text = "0";
            this.lblOrderId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOrderNameLabel
            // 
            this.lblOrderNameLabel.AutoSize = true;
            this.lblOrderNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOrderNameLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOrderNameLabel.Location = new System.Drawing.Point(3, 28);
            this.lblOrderNameLabel.Name = "lblOrderNameLabel";
            this.lblOrderNameLabel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblOrderNameLabel.Size = new System.Drawing.Size(220, 28);
            this.lblOrderNameLabel.TabIndex = 2;
            this.lblOrderNameLabel.Text = "Название заказа:";
            this.lblOrderNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOrderName
            // 
            this.lblOrderName.AutoSize = true;
            this.lblOrderName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOrderName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOrderName.Location = new System.Drawing.Point(229, 28);
            this.lblOrderName.Name = "lblOrderName";
            this.lblOrderName.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.lblOrderName.Size = new System.Drawing.Size(522, 28);
            this.lblOrderName.TabIndex = 3;
            this.lblOrderName.Text = "Заказ №0";
            this.lblOrderName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBookTitleLabel
            // 
            this.lblBookTitleLabel.AutoSize = true;
            this.lblBookTitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBookTitleLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBookTitleLabel.Location = new System.Drawing.Point(3, 56);
            this.lblBookTitleLabel.Name = "lblBookTitleLabel";
            this.lblBookTitleLabel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblBookTitleLabel.Size = new System.Drawing.Size(220, 28);
            this.lblBookTitleLabel.TabIndex = 4;
            this.lblBookTitleLabel.Text = "Книга:";
            this.lblBookTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.AutoSize = true;
            this.lblBookTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBookTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBookTitle.Location = new System.Drawing.Point(229, 56);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.lblBookTitle.Size = new System.Drawing.Size(522, 28);
            this.lblBookTitle.TabIndex = 5;
            this.lblBookTitle.Text = "Название книги";
            this.lblBookTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCustomerNameLabel
            // 
            this.lblCustomerNameLabel.AutoSize = true;
            this.lblCustomerNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCustomerNameLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCustomerNameLabel.Location = new System.Drawing.Point(3, 84);
            this.lblCustomerNameLabel.Name = "lblCustomerNameLabel";
            this.lblCustomerNameLabel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblCustomerNameLabel.Size = new System.Drawing.Size(220, 28);
            this.lblCustomerNameLabel.TabIndex = 6;
            this.lblCustomerNameLabel.Text = "Клиент:";
            this.lblCustomerNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCustomerName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCustomerName.Location = new System.Drawing.Point(229, 84);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.lblCustomerName.Size = new System.Drawing.Size(522, 28);
            this.lblCustomerName.TabIndex = 7;
            this.lblCustomerName.Text = "ФИО клиента";
            this.lblCustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOfficeNameLabel
            // 
            this.lblOfficeNameLabel.AutoSize = true;
            this.lblOfficeNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOfficeNameLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOfficeNameLabel.Location = new System.Drawing.Point(3, 112);
            this.lblOfficeNameLabel.Name = "lblOfficeNameLabel";
            this.lblOfficeNameLabel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblOfficeNameLabel.Size = new System.Drawing.Size(220, 28);
            this.lblOfficeNameLabel.TabIndex = 8;
            this.lblOfficeNameLabel.Text = "Офис получения:";
            this.lblOfficeNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOfficeName
            // 
            this.lblOfficeName.AutoSize = true;
            this.lblOfficeName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOfficeName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOfficeName.Location = new System.Drawing.Point(229, 112);
            this.lblOfficeName.Name = "lblOfficeName";
            this.lblOfficeName.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.lblOfficeName.Size = new System.Drawing.Size(522, 28);
            this.lblOfficeName.TabIndex = 9;
            this.lblOfficeName.Text = "Название офиса";
            this.lblOfficeName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOrderDateLabel
            // 
            this.lblOrderDateLabel.AutoSize = true;
            this.lblOrderDateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOrderDateLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOrderDateLabel.Location = new System.Drawing.Point(3, 140);
            this.lblOrderDateLabel.Name = "lblOrderDateLabel";
            this.lblOrderDateLabel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblOrderDateLabel.Size = new System.Drawing.Size(220, 28);
            this.lblOrderDateLabel.TabIndex = 10;
            this.lblOrderDateLabel.Text = "Дата заказа:";
            this.lblOrderDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOrderDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOrderDate.Location = new System.Drawing.Point(229, 140);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.lblOrderDate.Size = new System.Drawing.Size(522, 28);
            this.lblOrderDate.TabIndex = 11;
            this.lblOrderDate.Text = "01.01.2023 00:00";
            this.lblOrderDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPriceLabel
            // 
            this.lblPriceLabel.AutoSize = true;
            this.lblPriceLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPriceLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPriceLabel.Location = new System.Drawing.Point(3, 168);
            this.lblPriceLabel.Name = "lblPriceLabel";
            this.lblPriceLabel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblPriceLabel.Size = new System.Drawing.Size(220, 28);
            this.lblPriceLabel.TabIndex = 12;
            this.lblPriceLabel.Text = "Сумма:";
            this.lblPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPrice.ForeColor = System.Drawing.Color.Green;
            this.lblPrice.Location = new System.Drawing.Point(229, 168);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.lblPrice.Size = new System.Drawing.Size(522, 28);
            this.lblPrice.TabIndex = 13;
            this.lblPrice.Text = "0,00 руб";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.Gainsboro;
            this.panelFooter.Controls.Add(this.btnClose);
            this.panelFooter.Controls.Add(this.btnPrint);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 501);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(800, 60);
            this.panelFooter.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DimGray;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(580, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(200, 40);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.SteelBlue;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(20, 10);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(200, 40);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "Печать";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // FormReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 561);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            //this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(816, 600);
            this.Name = "FormReceipt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Чек заказа";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelContent.ResumeLayout(false);
            this.groupBoxReceipt.ResumeLayout(false);
            this.groupBoxDetails.ResumeLayout(false);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.panelFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblReceiptTitle;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.GroupBox groupBoxReceipt;
        private System.Windows.Forms.RichTextBox rtxtReceipt;
        private System.Windows.Forms.GroupBox groupBoxDetails;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label lblOrderIdLabel;
        private System.Windows.Forms.Label lblOrderId;
        private System.Windows.Forms.Label lblOrderNameLabel;
        private System.Windows.Forms.Label lblOrderName;
        private System.Windows.Forms.Label lblBookTitleLabel;
        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.Label lblCustomerNameLabel;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblOfficeNameLabel;
        private System.Windows.Forms.Label lblOfficeName;
        private System.Windows.Forms.Label lblOrderDateLabel;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.Label lblPriceLabel;
        private System.Windows.Forms.Label lblPrice;
        private System.Drawing.Printing.PrintDocument printDocument;
    }
}