namespace AgroVision_Management_System.AgroVision_Forms.cs
{
    partial class UpdateCropForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateCropForm));
            pnlCropDetailstoUpdate = new Panel();
            btnUpdateSelectedFertilizerDate = new Button();
            tbxExpectedYieldtoUpdate = new TextBox();
            lblExpectedYieldtoUpdate = new Label();
            dtpPlantingDatetoUpdate = new DateTimePicker();
            lblPlantingDatetoUpdate = new Label();
            tbxCropNametoUpdate = new TextBox();
            lblCropNametoUpdate = new Label();
            pnlFertilizerScheduletoUpdate = new Panel();
            btnDeleteDate = new Button();
            btnEditDate = new Button();
            lblNewFertilizerDate = new Label();
            dtpFertilizerDatetoUpdate = new DateTimePicker();
            ListofFertilizerSchedule = new ListBox();
            btnUpdateCropB2D = new Button();
            pnlCropDetailstoUpdate.SuspendLayout();
            pnlFertilizerScheduletoUpdate.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCropDetailstoUpdate
            // 
            pnlCropDetailstoUpdate.BackColor = Color.AntiqueWhite;
            pnlCropDetailstoUpdate.Controls.Add(btnUpdateSelectedFertilizerDate);
            pnlCropDetailstoUpdate.Controls.Add(tbxExpectedYieldtoUpdate);
            pnlCropDetailstoUpdate.Controls.Add(lblExpectedYieldtoUpdate);
            pnlCropDetailstoUpdate.Controls.Add(dtpPlantingDatetoUpdate);
            pnlCropDetailstoUpdate.Controls.Add(lblPlantingDatetoUpdate);
            pnlCropDetailstoUpdate.Controls.Add(tbxCropNametoUpdate);
            pnlCropDetailstoUpdate.Controls.Add(lblCropNametoUpdate);
            pnlCropDetailstoUpdate.Location = new Point(69, 162);
            pnlCropDetailstoUpdate.Name = "pnlCropDetailstoUpdate";
            pnlCropDetailstoUpdate.Size = new Size(590, 420);
            pnlCropDetailstoUpdate.TabIndex = 1;
            // 
            // btnUpdateSelectedFertilizerDate
            // 
            btnUpdateSelectedFertilizerDate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnUpdateSelectedFertilizerDate.BackColor = Color.Yellow;
            btnUpdateSelectedFertilizerDate.Font = new Font("ROG Fonts", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdateSelectedFertilizerDate.Location = new Point(402, 290);
            btnUpdateSelectedFertilizerDate.Name = "btnUpdateSelectedFertilizerDate";
            btnUpdateSelectedFertilizerDate.Size = new Size(154, 63);
            btnUpdateSelectedFertilizerDate.TabIndex = 8;
            btnUpdateSelectedFertilizerDate.Text = "UPDATE";
            btnUpdateSelectedFertilizerDate.UseVisualStyleBackColor = false;
            btnUpdateSelectedFertilizerDate.Click += btnUpdateSelectedFertilizerDate_Click;
            // 
            // tbxExpectedYieldtoUpdate
            // 
            tbxExpectedYieldtoUpdate.Location = new Point(330, 207);
            tbxExpectedYieldtoUpdate.Name = "tbxExpectedYieldtoUpdate";
            tbxExpectedYieldtoUpdate.Size = new Size(226, 27);
            tbxExpectedYieldtoUpdate.TabIndex = 7;
            // 
            // lblExpectedYieldtoUpdate
            // 
            lblExpectedYieldtoUpdate.AutoSize = true;
            lblExpectedYieldtoUpdate.BackColor = Color.PowderBlue;
            lblExpectedYieldtoUpdate.Font = new Font("Rockwell Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExpectedYieldtoUpdate.Location = new Point(39, 207);
            lblExpectedYieldtoUpdate.Name = "lblExpectedYieldtoUpdate";
            lblExpectedYieldtoUpdate.Size = new Size(227, 24);
            lblExpectedYieldtoUpdate.TabIndex = 6;
            lblExpectedYieldtoUpdate.Text = "Enter New Expected Yield:";
            // 
            // dtpPlantingDatetoUpdate
            // 
            dtpPlantingDatetoUpdate.Font = new Font("Segoe UI Variable Display Semib", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpPlantingDatetoUpdate.Format = DateTimePickerFormat.Custom;
            dtpPlantingDatetoUpdate.Location = new Point(330, 130);
            dtpPlantingDatetoUpdate.Name = "dtpPlantingDatetoUpdate";
            dtpPlantingDatetoUpdate.Size = new Size(224, 30);
            dtpPlantingDatetoUpdate.TabIndex = 5;
            // 
            // lblPlantingDatetoUpdate
            // 
            lblPlantingDatetoUpdate.AutoSize = true;
            lblPlantingDatetoUpdate.BackColor = Color.PowderBlue;
            lblPlantingDatetoUpdate.Font = new Font("Rockwell Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPlantingDatetoUpdate.Location = new Point(39, 130);
            lblPlantingDatetoUpdate.Name = "lblPlantingDatetoUpdate";
            lblPlantingDatetoUpdate.Size = new Size(220, 24);
            lblPlantingDatetoUpdate.TabIndex = 4;
            lblPlantingDatetoUpdate.Text = "Enter New Planting Date:";
            // 
            // tbxCropNametoUpdate
            // 
            tbxCropNametoUpdate.Location = new Point(330, 60);
            tbxCropNametoUpdate.Name = "tbxCropNametoUpdate";
            tbxCropNametoUpdate.Size = new Size(224, 27);
            tbxCropNametoUpdate.TabIndex = 3;
            // 
            // lblCropNametoUpdate
            // 
            lblCropNametoUpdate.AutoSize = true;
            lblCropNametoUpdate.BackColor = Color.PowderBlue;
            lblCropNametoUpdate.Font = new Font("Rockwell Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCropNametoUpdate.Location = new Point(39, 60);
            lblCropNametoUpdate.Name = "lblCropNametoUpdate";
            lblCropNametoUpdate.Size = new Size(241, 24);
            lblCropNametoUpdate.TabIndex = 2;
            lblCropNametoUpdate.Text = "Enter Crop Name to Update:";
            // 
            // pnlFertilizerScheduletoUpdate
            // 
            pnlFertilizerScheduletoUpdate.BackColor = Color.AntiqueWhite;
            pnlFertilizerScheduletoUpdate.Controls.Add(btnDeleteDate);
            pnlFertilizerScheduletoUpdate.Controls.Add(btnEditDate);
            pnlFertilizerScheduletoUpdate.Controls.Add(lblNewFertilizerDate);
            pnlFertilizerScheduletoUpdate.Controls.Add(dtpFertilizerDatetoUpdate);
            pnlFertilizerScheduletoUpdate.Controls.Add(ListofFertilizerSchedule);
            pnlFertilizerScheduletoUpdate.Location = new Point(698, 162);
            pnlFertilizerScheduletoUpdate.Name = "pnlFertilizerScheduletoUpdate";
            pnlFertilizerScheduletoUpdate.Size = new Size(619, 420);
            pnlFertilizerScheduletoUpdate.TabIndex = 2;
            // 
            // btnDeleteDate
            // 
            btnDeleteDate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDeleteDate.BackColor = SystemColors.ControlDark;
            btnDeleteDate.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteDate.Location = new Point(461, 338);
            btnDeleteDate.Name = "btnDeleteDate";
            btnDeleteDate.Size = new Size(135, 51);
            btnDeleteDate.TabIndex = 10;
            btnDeleteDate.Text = "Delete Date";
            btnDeleteDate.UseVisualStyleBackColor = false;
            btnDeleteDate.Click += btnDeleteDate_Click_1;
            // 
            // btnEditDate
            // 
            btnEditDate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEditDate.BackColor = SystemColors.ControlDark;
            btnEditDate.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditDate.ForeColor = Color.Black;
            btnEditDate.Location = new Point(461, 280);
            btnEditDate.Name = "btnEditDate";
            btnEditDate.Size = new Size(135, 52);
            btnEditDate.TabIndex = 9;
            btnEditDate.Text = "Edit Date";
            btnEditDate.UseVisualStyleBackColor = false;
            btnEditDate.Click += btnEditDate_Click;
            // 
            // lblNewFertilizerDate
            // 
            lblNewFertilizerDate.AutoSize = true;
            lblNewFertilizerDate.BackColor = Color.PowderBlue;
            lblNewFertilizerDate.Font = new Font("Rockwell Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNewFertilizerDate.Location = new Point(372, 76);
            lblNewFertilizerDate.Name = "lblNewFertilizerDate";
            lblNewFertilizerDate.Size = new Size(224, 24);
            lblNewFertilizerDate.TabIndex = 7;
            lblNewFertilizerDate.Text = "Enter New Fertilizer Date:";
            // 
            // dtpFertilizerDatetoUpdate
            // 
            dtpFertilizerDatetoUpdate.Font = new Font("Segoe UI Variable Display Semib", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpFertilizerDatetoUpdate.Format = DateTimePickerFormat.Custom;
            dtpFertilizerDatetoUpdate.Location = new Point(372, 112);
            dtpFertilizerDatetoUpdate.Name = "dtpFertilizerDatetoUpdate";
            dtpFertilizerDatetoUpdate.Size = new Size(224, 27);
            dtpFertilizerDatetoUpdate.TabIndex = 6;
            dtpFertilizerDatetoUpdate.ValueChanged += dtpFertilizerDatetoUpdate_ValueChanged;
            // 
            // ListofFertilizerSchedule
            // 
            ListofFertilizerSchedule.FormattingEnabled = true;
            ListofFertilizerSchedule.Location = new Point(15, 25);
            ListofFertilizerSchedule.Name = "ListofFertilizerSchedule";
            ListofFertilizerSchedule.Size = new Size(339, 344);
            ListofFertilizerSchedule.TabIndex = 3;
            ListofFertilizerSchedule.SelectedIndexChanged += ListofFertilizerSchedule_SelectedIndexChanged;
            // 
            // btnUpdateCropB2D
            // 
            btnUpdateCropB2D.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnUpdateCropB2D.BackColor = Color.Transparent;
            btnUpdateCropB2D.BackgroundImage = (Image)resources.GetObject("btnUpdateCropB2D.BackgroundImage");
            btnUpdateCropB2D.BackgroundImageLayout = ImageLayout.Zoom;
            btnUpdateCropB2D.Font = new Font("ROG Fonts", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdateCropB2D.Location = new Point(57, 34);
            btnUpdateCropB2D.Name = "btnUpdateCropB2D";
            btnUpdateCropB2D.Size = new Size(136, 41);
            btnUpdateCropB2D.TabIndex = 7;
            btnUpdateCropB2D.UseVisualStyleBackColor = false;
            btnUpdateCropB2D.Click += btnUpdateCropB2D_Click;
            // 
            // UpdateCropForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OliveDrab;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1382, 853);
            Controls.Add(btnUpdateCropB2D);
            Controls.Add(pnlFertilizerScheduletoUpdate);
            Controls.Add(pnlCropDetailstoUpdate);
            Name = "UpdateCropForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UpdateCrop";
            Load += UpdateCropForm_Load;
            pnlCropDetailstoUpdate.ResumeLayout(false);
            pnlCropDetailstoUpdate.PerformLayout();
            pnlFertilizerScheduletoUpdate.ResumeLayout(false);
            pnlFertilizerScheduletoUpdate.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlCropDetailstoUpdate;
        private TextBox tbxExpectedYieldtoUpdate;
        private DateTimePicker dtpPlantingDatetoUpdate;
        private TextBox tbxCropNametoUpdate;
        private Label lblExpectedYieldtoUpdate;
        private Label lblPlantingDatetoUpdate;
        private Label lblCropNametoUpdate;
        private Panel pnlFertilizerScheduletoUpdate;
        private TextBox textBox1;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private TextBox textBox2;
        private ListBox ListofFertilizerSchedule;
        private Label lblNewFertilizerDate;
        private DateTimePicker dtpFertilizerDatetoUpdate;
        private Button btnUpdateSelectedFertilizerDate;
        private Button btnUpdateCropB2D;
        private Button btnDeleteDate;
        private Button btnEditDate;
    }
}