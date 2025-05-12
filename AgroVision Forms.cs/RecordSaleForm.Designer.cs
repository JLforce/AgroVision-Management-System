namespace AgroVision_Management_System.AgroVision_Forms.cs
{
    partial class RecordSaleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecordSaleForm));
            lblInventoryItem = new Label();
            lblQuantitySold = new Label();
            lblSaleDate = new Label();
            cmbInventoryItem = new ComboBox();
            txtQuantitySold = new TextBox();
            dtpSaleDate = new DateTimePicker();
            btnSaveSale = new Button();
            txtTotalAmount = new TextBox();
            btnClear = new Button();
            lblTotalAmount = new Label();
            SuspendLayout();
            // 
            // lblInventoryItem
            // 
            lblInventoryItem.AutoSize = true;
            lblInventoryItem.BackColor = Color.Thistle;
            lblInventoryItem.Font = new Font("Bahnschrift SemiBold SemiConden", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInventoryItem.ForeColor = SystemColors.ActiveCaptionText;
            lblInventoryItem.Location = new Point(108, 76);
            lblInventoryItem.Name = "lblInventoryItem";
            lblInventoryItem.Size = new Size(98, 24);
            lblInventoryItem.TabIndex = 3;
            lblInventoryItem.Text = "Select Item";
            // 
            // lblQuantitySold
            // 
            lblQuantitySold.AutoSize = true;
            lblQuantitySold.BackColor = Color.Thistle;
            lblQuantitySold.Font = new Font("Bahnschrift SemiBold SemiConden", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuantitySold.ForeColor = SystemColors.ActiveCaptionText;
            lblQuantitySold.Location = new Point(108, 127);
            lblQuantitySold.Name = "lblQuantitySold";
            lblQuantitySold.Size = new Size(113, 24);
            lblQuantitySold.TabIndex = 4;
            lblQuantitySold.Text = "Quantity Sold";
            // 
            // lblSaleDate
            // 
            lblSaleDate.AutoSize = true;
            lblSaleDate.BackColor = Color.Thistle;
            lblSaleDate.Font = new Font("Bahnschrift SemiBold SemiConden", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSaleDate.ForeColor = SystemColors.ActiveCaptionText;
            lblSaleDate.Location = new Point(108, 187);
            lblSaleDate.Name = "lblSaleDate";
            lblSaleDate.Size = new Size(83, 24);
            lblSaleDate.TabIndex = 5;
            lblSaleDate.Text = "Sale Date";
            // 
            // cmbInventoryItem
            // 
            cmbInventoryItem.BackColor = SystemColors.Info;
            cmbInventoryItem.FormattingEnabled = true;
            cmbInventoryItem.Items.AddRange(new object[] { "Grain", "Vegetable" });
            cmbInventoryItem.Location = new Point(251, 72);
            cmbInventoryItem.Name = "cmbInventoryItem";
            cmbInventoryItem.Size = new Size(231, 28);
            cmbInventoryItem.TabIndex = 20;
            cmbInventoryItem.SelectedIndexChanged += cmbInventoryItem_SelectedIndexChanged;
            // 
            // txtQuantitySold
            // 
            txtQuantitySold.BackColor = SystemColors.Info;
            txtQuantitySold.Location = new Point(251, 128);
            txtQuantitySold.Multiline = true;
            txtQuantitySold.Name = "txtQuantitySold";
            txtQuantitySold.Size = new Size(231, 26);
            txtQuantitySold.TabIndex = 21;
            // 
            // dtpSaleDate
            // 
            dtpSaleDate.CalendarMonthBackground = SystemColors.Info;
            dtpSaleDate.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpSaleDate.Location = new Point(251, 187);
            dtpSaleDate.Name = "dtpSaleDate";
            dtpSaleDate.Size = new Size(283, 25);
            dtpSaleDate.TabIndex = 23;
            // 
            // btnSaveSale
            // 
            btnSaveSale.BackColor = Color.DarkKhaki;
            btnSaveSale.Font = new Font("SimSun-ExtG", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveSale.Location = new Point(446, 547);
            btnSaveSale.Name = "btnSaveSale";
            btnSaveSale.Size = new Size(113, 46);
            btnSaveSale.TabIndex = 25;
            btnSaveSale.Text = "SAVE";
            btnSaveSale.UseVisualStyleBackColor = false;
            btnSaveSale.Click += btnSaveSale_Click;
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.BackColor = SystemColors.Info;
            txtTotalAmount.Location = new Point(315, 365);
            txtTotalAmount.Multiline = true;
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.Size = new Size(231, 33);
            txtTotalAmount.TabIndex = 27;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.DarkKhaki;
            btnClear.Font = new Font("SimSun-ExtG", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(565, 547);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(113, 46);
            btnClear.TabIndex = 29;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click_1;
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.BackColor = Color.Thistle;
            lblTotalAmount.Font = new Font("Britannic Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalAmount.ForeColor = SystemColors.ActiveCaptionText;
            lblTotalAmount.Location = new Point(131, 365);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(178, 31);
            lblTotalAmount.TabIndex = 31;
            lblTotalAmount.Text = "Total Amount";
            // 
            // RecordSaleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(732, 653);
            Controls.Add(lblTotalAmount);
            Controls.Add(btnClear);
            Controls.Add(txtTotalAmount);
            Controls.Add(btnSaveSale);
            Controls.Add(dtpSaleDate);
            Controls.Add(txtQuantitySold);
            Controls.Add(cmbInventoryItem);
            Controls.Add(lblSaleDate);
            Controls.Add(lblQuantitySold);
            Controls.Add(lblInventoryItem);
            DoubleBuffered = true;
            Name = "RecordSaleForm";
            Text = "RecordSaleForm";
            Load += RecordSaleForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInventoryItem;
        private Label lblQuantitySold;
        private Label lblSaleDate;
        private ComboBox cmbInventoryItem;
        private TextBox txtQuantitySold;
        private DateTimePicker dtpSaleDate;
        private Button btnSaveSale;
        private TextBox txtTotalAmount;
        private Button btnClear;
        private Label lblTotalAmount;
    }
}