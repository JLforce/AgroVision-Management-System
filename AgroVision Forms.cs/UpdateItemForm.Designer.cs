namespace AgroVision_Management_System.AgroVision_Forms.cs
{
    partial class UpdateItemForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateItemForm));
            lblItemName = new Label();
            lblCategory = new Label();
            lblQuantity = new Label();
            lblUnit = new Label();
            lblDateAdded = new Label();
            txtItemName = new TextBox();
            cmbCategory = new ComboBox();
            txtQuantity = new TextBox();
            txtUnit = new TextBox();
            dtpDateAdded = new DateTimePicker();
            dgvInventory = new DataGridView();
            btnUpdate = new Button();
            btnClear = new Button();
            lblPrice = new Label();
            txtPrice = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).BeginInit();
            SuspendLayout();
            // 
            // lblItemName
            // 
            lblItemName.AutoSize = true;
            lblItemName.BackColor = Color.Thistle;
            lblItemName.Font = new Font("Bahnschrift SemiBold SemiConden", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblItemName.ForeColor = SystemColors.ActiveCaptionText;
            lblItemName.Location = new Point(150, 109);
            lblItemName.Name = "lblItemName";
            lblItemName.Size = new Size(94, 24);
            lblItemName.TabIndex = 2;
            lblItemName.Text = "Item Name";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.BackColor = Color.Thistle;
            lblCategory.Font = new Font("Bahnschrift SemiBold SemiConden", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategory.ForeColor = SystemColors.ActiveCaptionText;
            lblCategory.Location = new Point(150, 165);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(78, 24);
            lblCategory.TabIndex = 14;
            lblCategory.Text = "Category";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.BackColor = Color.Thistle;
            lblQuantity.Font = new Font("Bahnschrift SemiBold SemiConden", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuantity.ForeColor = SystemColors.ActiveCaptionText;
            lblQuantity.Location = new Point(150, 220);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(75, 24);
            lblQuantity.TabIndex = 15;
            lblQuantity.Text = "Quantity";
            // 
            // lblUnit
            // 
            lblUnit.AutoSize = true;
            lblUnit.BackColor = Color.Thistle;
            lblUnit.Font = new Font("Bahnschrift SemiBold SemiConden", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUnit.ForeColor = SystemColors.ActiveCaptionText;
            lblUnit.Location = new Point(150, 273);
            lblUnit.Name = "lblUnit";
            lblUnit.Size = new Size(41, 24);
            lblUnit.TabIndex = 16;
            lblUnit.Text = "Unit";
            // 
            // lblDateAdded
            // 
            lblDateAdded.AutoSize = true;
            lblDateAdded.BackColor = Color.Thistle;
            lblDateAdded.Font = new Font("Bahnschrift SemiBold SemiConden", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDateAdded.ForeColor = SystemColors.ActiveCaptionText;
            lblDateAdded.Location = new Point(150, 368);
            lblDateAdded.Name = "lblDateAdded";
            lblDateAdded.Size = new Size(97, 24);
            lblDateAdded.TabIndex = 17;
            lblDateAdded.Text = "Date Added";
            // 
            // txtItemName
            // 
            txtItemName.BackColor = SystemColors.Info;
            txtItemName.Location = new Point(273, 107);
            txtItemName.Multiline = true;
            txtItemName.Name = "txtItemName";
            txtItemName.Size = new Size(231, 26);
            txtItemName.TabIndex = 18;
            // 
            // cmbCategory
            // 
            cmbCategory.BackColor = SystemColors.Info;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "Grain", "Vegetable" });
            cmbCategory.Location = new Point(273, 165);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(231, 28);
            cmbCategory.TabIndex = 19;
            // 
            // txtQuantity
            // 
            txtQuantity.BackColor = SystemColors.Info;
            txtQuantity.Location = new Point(273, 220);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(231, 27);
            txtQuantity.TabIndex = 20;
            // 
            // txtUnit
            // 
            txtUnit.BackColor = SystemColors.Info;
            txtUnit.Location = new Point(273, 273);
            txtUnit.Name = "txtUnit";
            txtUnit.Size = new Size(231, 27);
            txtUnit.TabIndex = 21;
            // 
            // dtpDateAdded
            // 
            dtpDateAdded.CalendarMonthBackground = SystemColors.Info;
            dtpDateAdded.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpDateAdded.Location = new Point(273, 367);
            dtpDateAdded.Name = "dtpDateAdded";
            dtpDateAdded.Size = new Size(283, 25);
            dtpDateAdded.TabIndex = 22;
            // 
            // dgvInventory
            // 
            dgvInventory.BackgroundColor = SystemColors.Info;
            dgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventory.Dock = DockStyle.Bottom;
            dgvInventory.Location = new Point(0, 560);
            dgvInventory.Name = "dgvInventory";
            dgvInventory.RowHeadersWidth = 51;
            dgvInventory.Size = new Size(800, 296);
            dgvInventory.TabIndex = 23;
            dgvInventory.CellContentClick += dgvInventory_CellContentClick;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.DarkKhaki;
            btnUpdate.Font = new Font("SimSun-ExtG", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(537, 508);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 46);
            btnUpdate.TabIndex = 24;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.DarkKhaki;
            btnClear.Font = new Font("SimSun-ExtG", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(655, 508);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 46);
            btnClear.TabIndex = 25;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click_1;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.BackColor = Color.Thistle;
            lblPrice.Font = new Font("Bahnschrift SemiBold SemiConden", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrice.ForeColor = SystemColors.ActiveCaptionText;
            lblPrice.Location = new Point(150, 323);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(50, 24);
            lblPrice.TabIndex = 26;
            lblPrice.Text = "Price";
            // 
            // txtPrice
            // 
            txtPrice.BackColor = SystemColors.Info;
            txtPrice.Location = new Point(273, 320);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(231, 27);
            txtPrice.TabIndex = 27;
            txtPrice.TextChanged += txtPrice_TextChanged;
            // 
            // UpdateItemForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(800, 856);
            Controls.Add(txtPrice);
            Controls.Add(lblPrice);
            Controls.Add(btnClear);
            Controls.Add(btnUpdate);
            Controls.Add(dgvInventory);
            Controls.Add(dtpDateAdded);
            Controls.Add(txtUnit);
            Controls.Add(txtQuantity);
            Controls.Add(cmbCategory);
            Controls.Add(txtItemName);
            Controls.Add(lblDateAdded);
            Controls.Add(lblUnit);
            Controls.Add(lblQuantity);
            Controls.Add(lblCategory);
            Controls.Add(lblItemName);
            DoubleBuffered = true;
            Name = "UpdateItemForm";
            Text = "UpdateItemForm";
            Load += UpdateItemForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInventory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblItemName;
        private Label lblCategory;
        private Label lblQuantity;
        private Label lblUnit;
        private Label lblDateAdded;
        private TextBox txtItemName;
        private ComboBox cmbCategory;
        private TextBox txtQuantity;
        private TextBox txtUnit;
        private DateTimePicker dtpDateAdded;
        private DataGridView dgvInventory;
        private Button btnUpdate;
        private Button btnClear;
        private Label lblPrice;
        private TextBox txtPrice;
    }
}