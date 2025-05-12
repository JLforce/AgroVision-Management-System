namespace AgroVision_Management_System.AgroVision_Forms.cs
{
    partial class AddCropForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCropForm));
            pnlCropDetails = new Panel();
            tbxExpectedYield = new TextBox();
            lblExpectedYield = new Label();
            dtpPlantingDate = new DateTimePicker();
            lblPlantingDate = new Label();
            tbxCropName = new TextBox();
            lblCropName = new Label();
            lblCropType = new Label();
            cmbCropType = new ComboBox();
            pnlFertilizerSchedule = new Panel();
            btnRemoveFertilizerDate = new Button();
            btnAddFertilizerDate = new Button();
            lblFertilizerDate = new Label();
            dtpFertilizerDate = new DateTimePicker();
            lbxFertilizerDates = new ListBox();
            btnSaveCrops = new Button();
            btnCancelCropSave = new Button();
            btnAddCropB2D = new Button();
            pnlCropDetails.SuspendLayout();
            pnlFertilizerSchedule.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCropDetails
            // 
            pnlCropDetails.BackColor = Color.AntiqueWhite;
            pnlCropDetails.Controls.Add(tbxExpectedYield);
            pnlCropDetails.Controls.Add(lblExpectedYield);
            pnlCropDetails.Controls.Add(dtpPlantingDate);
            pnlCropDetails.Controls.Add(lblPlantingDate);
            pnlCropDetails.Controls.Add(tbxCropName);
            pnlCropDetails.Controls.Add(lblCropName);
            pnlCropDetails.Controls.Add(lblCropType);
            pnlCropDetails.Controls.Add(cmbCropType);
            pnlCropDetails.Location = new Point(204, 103);
            pnlCropDetails.Name = "pnlCropDetails";
            pnlCropDetails.Size = new Size(447, 434);
            pnlCropDetails.TabIndex = 0;
            // 
            // tbxExpectedYield
            // 
            tbxExpectedYield.Location = new Point(176, 303);
            tbxExpectedYield.Name = "tbxExpectedYield";
            tbxExpectedYield.Size = new Size(226, 27);
            tbxExpectedYield.TabIndex = 7;
            // 
            // lblExpectedYield
            // 
            lblExpectedYield.AutoSize = true;
            lblExpectedYield.BackColor = Color.PowderBlue;
            lblExpectedYield.Font = new Font("Rockwell Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExpectedYield.Location = new Point(39, 303);
            lblExpectedYield.Name = "lblExpectedYield";
            lblExpectedYield.Size = new Size(131, 24);
            lblExpectedYield.TabIndex = 6;
            lblExpectedYield.Text = "Expected Yield";
            // 
            // dtpPlantingDate
            // 
            dtpPlantingDate.Font = new Font("Segoe UI Variable Display Semib", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpPlantingDate.Format = DateTimePickerFormat.Custom;
            dtpPlantingDate.Location = new Point(176, 233);
            dtpPlantingDate.Name = "dtpPlantingDate";
            dtpPlantingDate.Size = new Size(224, 27);
            dtpPlantingDate.TabIndex = 5;
            // 
            // lblPlantingDate
            // 
            lblPlantingDate.AutoSize = true;
            lblPlantingDate.BackColor = Color.PowderBlue;
            lblPlantingDate.Font = new Font("Rockwell Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPlantingDate.Location = new Point(39, 236);
            lblPlantingDate.Name = "lblPlantingDate";
            lblPlantingDate.Size = new Size(124, 24);
            lblPlantingDate.TabIndex = 4;
            lblPlantingDate.Text = "Planting Date";
            lblPlantingDate.Click += lblPlantingDate_Click;
            // 
            // tbxCropName
            // 
            tbxCropName.Location = new Point(178, 167);
            tbxCropName.Name = "tbxCropName";
            tbxCropName.Size = new Size(224, 27);
            tbxCropName.TabIndex = 3;
            // 
            // lblCropName
            // 
            lblCropName.AutoSize = true;
            lblCropName.BackColor = Color.PowderBlue;
            lblCropName.Font = new Font("Rockwell Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCropName.Location = new Point(45, 170);
            lblCropName.Name = "lblCropName";
            lblCropName.Size = new Size(99, 24);
            lblCropName.TabIndex = 2;
            lblCropName.Text = "Crop Name";
            lblCropName.Click += lblCropName_Click;
            // 
            // lblCropType
            // 
            lblCropType.AutoSize = true;
            lblCropType.BackColor = Color.PowderBlue;
            lblCropType.Font = new Font("Rockwell Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCropType.Location = new Point(45, 102);
            lblCropType.Name = "lblCropType";
            lblCropType.Size = new Size(93, 24);
            lblCropType.TabIndex = 1;
            lblCropType.Text = "Crop Type";
            lblCropType.Click += lblCropType_Click;
            // 
            // cmbCropType
            // 
            cmbCropType.FormattingEnabled = true;
            cmbCropType.Items.AddRange(new object[] { "Grain", "Vegetable" });
            cmbCropType.Location = new Point(178, 102);
            cmbCropType.Name = "cmbCropType";
            cmbCropType.Size = new Size(224, 28);
            cmbCropType.TabIndex = 0;
            // 
            // pnlFertilizerSchedule
            // 
            pnlFertilizerSchedule.BackColor = Color.AntiqueWhite;
            pnlFertilizerSchedule.Controls.Add(btnRemoveFertilizerDate);
            pnlFertilizerSchedule.Controls.Add(btnAddFertilizerDate);
            pnlFertilizerSchedule.Controls.Add(lblFertilizerDate);
            pnlFertilizerSchedule.Controls.Add(dtpFertilizerDate);
            pnlFertilizerSchedule.Controls.Add(lbxFertilizerDates);
            pnlFertilizerSchedule.Location = new Point(708, 103);
            pnlFertilizerSchedule.Name = "pnlFertilizerSchedule";
            pnlFertilizerSchedule.Size = new Size(442, 520);
            pnlFertilizerSchedule.TabIndex = 2;
            // 
            // btnRemoveFertilizerDate
            // 
            btnRemoveFertilizerDate.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRemoveFertilizerDate.BackColor = Color.LightCoral;
            btnRemoveFertilizerDate.Font = new Font("ROG Fonts", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRemoveFertilizerDate.Location = new Point(269, 447);
            btnRemoveFertilizerDate.Name = "btnRemoveFertilizerDate";
            btnRemoveFertilizerDate.Size = new Size(135, 33);
            btnRemoveFertilizerDate.TabIndex = 4;
            btnRemoveFertilizerDate.Text = "Remove";
            btnRemoveFertilizerDate.UseVisualStyleBackColor = false;
            // 
            // btnAddFertilizerDate
            // 
            btnAddFertilizerDate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAddFertilizerDate.BackColor = Color.LightSkyBlue;
            btnAddFertilizerDate.Font = new Font("ROG Fonts", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddFertilizerDate.Location = new Point(128, 447);
            btnAddFertilizerDate.Name = "btnAddFertilizerDate";
            btnAddFertilizerDate.Size = new Size(135, 33);
            btnAddFertilizerDate.TabIndex = 3;
            btnAddFertilizerDate.Text = "Add";
            btnAddFertilizerDate.UseVisualStyleBackColor = false;
            btnAddFertilizerDate.Click += btnAddFertilizerDate_Click;
            // 
            // lblFertilizerDate
            // 
            lblFertilizerDate.AutoSize = true;
            lblFertilizerDate.BackColor = Color.PowderBlue;
            lblFertilizerDate.Font = new Font("Rockwell Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFertilizerDate.Location = new Point(38, 54);
            lblFertilizerDate.Name = "lblFertilizerDate";
            lblFertilizerDate.Size = new Size(128, 24);
            lblFertilizerDate.TabIndex = 2;
            lblFertilizerDate.Text = "Fertilizer Date";
            // 
            // dtpFertilizerDate
            // 
            dtpFertilizerDate.Font = new Font("Segoe UI Variable Display Semib", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpFertilizerDate.Format = DateTimePickerFormat.Custom;
            dtpFertilizerDate.Location = new Point(190, 51);
            dtpFertilizerDate.Name = "dtpFertilizerDate";
            dtpFertilizerDate.Size = new Size(214, 27);
            dtpFertilizerDate.TabIndex = 1;
            // 
            // lbxFertilizerDates
            // 
            lbxFertilizerDates.FormattingEnabled = true;
            lbxFertilizerDates.Location = new Point(38, 102);
            lbxFertilizerDates.Name = "lbxFertilizerDates";
            lbxFertilizerDates.Size = new Size(366, 304);
            lbxFertilizerDates.TabIndex = 0;
            // 
            // btnSaveCrops
            // 
            btnSaveCrops.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSaveCrops.BackColor = Color.Yellow;
            btnSaveCrops.Font = new Font("ROG Fonts", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSaveCrops.Location = new Point(955, 704);
            btnSaveCrops.Name = "btnSaveCrops";
            btnSaveCrops.Size = new Size(115, 54);
            btnSaveCrops.TabIndex = 4;
            btnSaveCrops.Text = "SAVE";
            btnSaveCrops.UseVisualStyleBackColor = false;
            btnSaveCrops.Click += btnSaveCrops_Click;
            // 
            // btnCancelCropSave
            // 
            btnCancelCropSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelCropSave.BackColor = SystemColors.ControlDark;
            btnCancelCropSave.Font = new Font("ROG Fonts", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelCropSave.Location = new Point(1086, 704);
            btnCancelCropSave.Name = "btnCancelCropSave";
            btnCancelCropSave.Size = new Size(118, 54);
            btnCancelCropSave.TabIndex = 5;
            btnCancelCropSave.Text = "CANCEL";
            btnCancelCropSave.UseVisualStyleBackColor = false;
            // 
            // btnAddCropB2D
            // 
            btnAddCropB2D.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAddCropB2D.BackColor = Color.Transparent;
            btnAddCropB2D.BackgroundImage = (Image)resources.GetObject("btnAddCropB2D.BackgroundImage");
            btnAddCropB2D.BackgroundImageLayout = ImageLayout.Zoom;
            btnAddCropB2D.Font = new Font("ROG Fonts", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddCropB2D.Location = new Point(39, 33);
            btnAddCropB2D.Name = "btnAddCropB2D";
            btnAddCropB2D.Size = new Size(136, 41);
            btnAddCropB2D.TabIndex = 6;
            btnAddCropB2D.UseVisualStyleBackColor = false;
            btnAddCropB2D.Click += btnAddCropB2D_Click;
            // 
            // AddCropForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OliveDrab;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1382, 853);
            Controls.Add(btnAddCropB2D);
            Controls.Add(btnCancelCropSave);
            Controls.Add(btnSaveCrops);
            Controls.Add(pnlFertilizerSchedule);
            Controls.Add(pnlCropDetails);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "AddCropForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddCrop";
            Load += AddCropForm_Load;
            pnlCropDetails.ResumeLayout(false);
            pnlCropDetails.PerformLayout();
            pnlFertilizerSchedule.ResumeLayout(false);
            pnlFertilizerSchedule.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlCropDetails;
        private Panel pnlFertilizerSchedule;
        private ComboBox cmbCropType;
        private Label lblCropType;
        private TextBox tbxCropName;
        private Label lblCropName;
        private DateTimePicker dtpPlantingDate;
        private Label lblPlantingDate;
        private TextBox tbxExpectedYield;
        private Label lblExpectedYield;
        private ListBox lbxFertilizerDates;
        private Label lblFertilizerDate;
        private DateTimePicker dtpFertilizerDate;
        private Button btnAddFertilizerDate;
        private Button btnRemoveFertilizerDate;
        private Button btnSaveCrops;
        private Button btnCancelCropSave;
        private Button btnAddCropB2D;
    }
}