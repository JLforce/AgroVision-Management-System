namespace AgroVision_Management_System.AgroVision_Forms.cs
{
    partial class AddItemForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddItemForm));
            lblItemName = new Label();
            txtItemName = new TextBox();
            txtQuantity = new TextBox();
            cmbCategory = new ComboBox();
            txtUnit = new TextBox();
            dtpDateAdded = new DateTimePicker();
            btnAdd = new Button();
            dataGridView1 = new DataGridView();
            lblCategory = new Label();
            lblQuantity = new Label();
            lblUnit = new Label();
            lblDateAdded = new Label();
            lblPrice = new Label();
            txtPrice = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblItemName
            // 
            lblItemName.AutoSize = true;
            lblItemName.BackColor = Color.Thistle;
            lblItemName.Font = new Font("Bahnschrift SemiBold SemiConden", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblItemName.ForeColor = SystemColors.ActiveCaptionText;
            lblItemName.Location = new Point(189, 118);
            lblItemName.Name = "lblItemName";
            lblItemName.Size = new Size(94, 24);
            lblItemName.TabIndex = 1;
            lblItemName.Text = "Item Name";
            // 
            // txtItemName
            // 
            txtItemName.BackColor = SystemColors.Info;
            txtItemName.Location = new Point(337, 116);
            txtItemName.Multiline = true;
            txtItemName.Name = "txtItemName";
            txtItemName.Size = new Size(231, 26);
            txtItemName.TabIndex = 6;
            // 
            // txtQuantity
            // 
            txtQuantity.BackColor = SystemColors.Info;
            txtQuantity.Location = new Point(337, 204);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(231, 27);
            txtQuantity.TabIndex = 7;
            // 
            // cmbCategory
            // 
            cmbCategory.BackColor = SystemColors.Info;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "Grain", "Vegetable" });
            cmbCategory.Location = new Point(337, 157);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(231, 28);
            cmbCategory.TabIndex = 8;
            // 
            // txtUnit
            // 
            txtUnit.BackColor = SystemColors.Info;
            txtUnit.Location = new Point(337, 245);
            txtUnit.Name = "txtUnit";
            txtUnit.Size = new Size(231, 27);
            txtUnit.TabIndex = 9;
            // 
            // dtpDateAdded
            // 
            dtpDateAdded.CalendarMonthBackground = SystemColors.Info;
            dtpDateAdded.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpDateAdded.Location = new Point(337, 339);
            dtpDateAdded.Name = "dtpDateAdded";
            dtpDateAdded.Size = new Size(283, 25);
            dtpDateAdded.TabIndex = 10;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.DarkKhaki;
            btnAdd.Font = new Font("SimSun-ExtG", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(580, 475);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(105, 46);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAddItem_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Info;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 560);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(800, 296);
            dataGridView1.TabIndex = 12;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.BackColor = Color.Thistle;
            lblCategory.Font = new Font("Bahnschrift SemiBold SemiConden", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategory.ForeColor = SystemColors.ActiveCaptionText;
            lblCategory.Location = new Point(189, 157);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(78, 24);
            lblCategory.TabIndex = 13;
            lblCategory.Text = "Category";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.BackColor = Color.Thistle;
            lblQuantity.Font = new Font("Bahnschrift SemiBold SemiConden", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuantity.ForeColor = SystemColors.ActiveCaptionText;
            lblQuantity.Location = new Point(189, 207);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(75, 24);
            lblQuantity.TabIndex = 14;
            lblQuantity.Text = "Quantity";
            // 
            // lblUnit
            // 
            lblUnit.AutoSize = true;
            lblUnit.BackColor = Color.Thistle;
            lblUnit.Font = new Font("Bahnschrift SemiBold SemiConden", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUnit.ForeColor = SystemColors.ActiveCaptionText;
            lblUnit.Location = new Point(189, 244);
            lblUnit.Name = "lblUnit";
            lblUnit.Size = new Size(41, 24);
            lblUnit.TabIndex = 15;
            lblUnit.Text = "Unit";
            // 
            // lblDateAdded
            // 
            lblDateAdded.AutoSize = true;
            lblDateAdded.BackColor = Color.Thistle;
            lblDateAdded.Font = new Font("Bahnschrift SemiBold SemiConden", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDateAdded.ForeColor = SystemColors.ActiveCaptionText;
            lblDateAdded.Location = new Point(189, 339);
            lblDateAdded.Name = "lblDateAdded";
            lblDateAdded.Size = new Size(97, 24);
            lblDateAdded.TabIndex = 16;
            lblDateAdded.Text = "Date Added";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.BackColor = Color.Thistle;
            lblPrice.Font = new Font("Bahnschrift SemiBold SemiConden", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrice.ForeColor = SystemColors.ActiveCaptionText;
            lblPrice.Location = new Point(189, 296);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(50, 24);
            lblPrice.TabIndex = 17;
            lblPrice.Text = "Price";
            // 
            // txtPrice
            // 
            txtPrice.BackColor = SystemColors.Info;
            txtPrice.Location = new Point(337, 293);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(231, 27);
            txtPrice.TabIndex = 18;
            txtPrice.TextChanged += txtPrice_TextChanged;
            // 
            // AddItemForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(800, 856);
            Controls.Add(txtPrice);
            Controls.Add(lblPrice);
            Controls.Add(lblDateAdded);
            Controls.Add(lblUnit);
            Controls.Add(lblQuantity);
            Controls.Add(lblCategory);
            Controls.Add(dataGridView1);
            Controls.Add(btnAdd);
            Controls.Add(dtpDateAdded);
            Controls.Add(txtUnit);
            Controls.Add(cmbCategory);
            Controls.Add(txtQuantity);
            Controls.Add(txtItemName);
            Controls.Add(lblItemName);
            DoubleBuffered = true;
            Name = "AddItemForm";
            Text = "AddItemForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblItemName;
        private TextBox txtItemName;
        private TextBox txtQuantity;
        private ComboBox cmbCategory;
        private TextBox txtUnit;
        private DateTimePicker dtpDateAdded;
        private Button btnAdd;
        private DataGridView dataGridView1;
        private Label lblCategory;
        private Label lblQuantity;
        private Label lblUnit;
        private Label lblDateAdded;
        private Label lblPrice;
        private TextBox txtPrice;
    }
}