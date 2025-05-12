namespace AgroVision_Management_System.AgroVision_Forms.cs
{
    partial class WeatherTrackerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeatherTrackerForm));
            pnlWeatherEntry = new Panel();
            tbxHumidity = new TextBox();
            tbxTemperature = new TextBox();
            lblWeatherCondition = new Label();
            lblInputHumidity = new Label();
            lblInputTemperature = new Label();
            lblDateSelection = new Label();
            btnSaveWeatherRecord = new Button();
            cbmWeatherCondition = new ComboBox();
            dtpWeatherEntry = new DateTimePicker();
            dgvWeatherHistory = new DataGridView();
            lblWeatherHistory = new Label();
            btnWeatherTrackerB2D = new Button();
            pnlWeatherEntry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvWeatherHistory).BeginInit();
            SuspendLayout();
            // 
            // pnlWeatherEntry
            // 
            pnlWeatherEntry.BackColor = Color.Cornsilk;
            pnlWeatherEntry.Controls.Add(tbxHumidity);
            pnlWeatherEntry.Controls.Add(tbxTemperature);
            pnlWeatherEntry.Controls.Add(lblWeatherCondition);
            pnlWeatherEntry.Controls.Add(lblInputHumidity);
            pnlWeatherEntry.Controls.Add(lblInputTemperature);
            pnlWeatherEntry.Controls.Add(lblDateSelection);
            pnlWeatherEntry.Controls.Add(btnSaveWeatherRecord);
            pnlWeatherEntry.Controls.Add(cbmWeatherCondition);
            pnlWeatherEntry.Controls.Add(dtpWeatherEntry);
            pnlWeatherEntry.Location = new Point(143, 141);
            pnlWeatherEntry.Name = "pnlWeatherEntry";
            pnlWeatherEntry.Size = new Size(449, 576);
            pnlWeatherEntry.TabIndex = 0;
            // 
            // tbxHumidity
            // 
            tbxHumidity.Location = new Point(232, 223);
            tbxHumidity.Name = "tbxHumidity";
            tbxHumidity.Size = new Size(190, 27);
            tbxHumidity.TabIndex = 23;
            // 
            // tbxTemperature
            // 
            tbxTemperature.Location = new Point(232, 154);
            tbxTemperature.Name = "tbxTemperature";
            tbxTemperature.Size = new Size(190, 27);
            tbxTemperature.TabIndex = 22;
            // 
            // lblWeatherCondition
            // 
            lblWeatherCondition.AutoSize = true;
            lblWeatherCondition.BackColor = Color.RosyBrown;
            lblWeatherCondition.Font = new Font("Rockwell Condensed", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWeatherCondition.Location = new Point(84, 305);
            lblWeatherCondition.Name = "lblWeatherCondition";
            lblWeatherCondition.Size = new Size(252, 27);
            lblWeatherCondition.TabIndex = 21;
            lblWeatherCondition.Text = "Select Weather Condition:";
            // 
            // lblInputHumidity
            // 
            lblInputHumidity.AutoSize = true;
            lblInputHumidity.BackColor = Color.MediumTurquoise;
            lblInputHumidity.Font = new Font("Rockwell Condensed", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInputHumidity.Location = new Point(35, 223);
            lblInputHumidity.Name = "lblInputHumidity";
            lblInputHumidity.Size = new Size(139, 27);
            lblInputHumidity.TabIndex = 20;
            lblInputHumidity.Text = "Humidity (%):";
            // 
            // lblInputTemperature
            // 
            lblInputTemperature.AutoSize = true;
            lblInputTemperature.BackColor = Color.MediumTurquoise;
            lblInputTemperature.Font = new Font("Rockwell Condensed", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInputTemperature.Location = new Point(35, 154);
            lblInputTemperature.Name = "lblInputTemperature";
            lblInputTemperature.Size = new Size(167, 27);
            lblInputTemperature.TabIndex = 19;
            lblInputTemperature.Text = "Temperature (C):";
            // 
            // lblDateSelection
            // 
            lblDateSelection.AutoSize = true;
            lblDateSelection.BackColor = Color.MediumTurquoise;
            lblDateSelection.Font = new Font("Rockwell Condensed", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDateSelection.Location = new Point(35, 87);
            lblDateSelection.Name = "lblDateSelection";
            lblDateSelection.Size = new Size(121, 27);
            lblDateSelection.TabIndex = 14;
            lblDateSelection.Text = "Select Date:";
            // 
            // btnSaveWeatherRecord
            // 
            btnSaveWeatherRecord.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSaveWeatherRecord.BackColor = Color.Yellow;
            btnSaveWeatherRecord.Font = new Font("ROG Fonts", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSaveWeatherRecord.Location = new Point(324, 493);
            btnSaveWeatherRecord.Name = "btnSaveWeatherRecord";
            btnSaveWeatherRecord.Size = new Size(98, 43);
            btnSaveWeatherRecord.TabIndex = 17;
            btnSaveWeatherRecord.Text = "SAVE";
            btnSaveWeatherRecord.UseVisualStyleBackColor = false;
            btnSaveWeatherRecord.Click += btnSaveWeatherRecord_Click;
            // 
            // cbmWeatherCondition
            // 
            cbmWeatherCondition.FormattingEnabled = true;
            cbmWeatherCondition.Items.AddRange(new object[] { "Sunny", "Rainy", "Cloudy", "Stormy", "Windy", "Foggy" });
            cbmWeatherCondition.Location = new Point(84, 335);
            cbmWeatherCondition.Name = "cbmWeatherCondition";
            cbmWeatherCondition.Size = new Size(252, 28);
            cbmWeatherCondition.TabIndex = 16;
            cbmWeatherCondition.SelectedIndexChanged += cbmWeatherCondition_SelectedIndexChanged;
            // 
            // dtpWeatherEntry
            // 
            dtpWeatherEntry.Font = new Font("Segoe UI Variable Display Semib", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpWeatherEntry.Format = DateTimePickerFormat.Custom;
            dtpWeatherEntry.Location = new Point(232, 87);
            dtpWeatherEntry.Name = "dtpWeatherEntry";
            dtpWeatherEntry.Size = new Size(190, 30);
            dtpWeatherEntry.TabIndex = 6;
            dtpWeatherEntry.ValueChanged += dtpWeatherEntry_ValueChanged;
            // 
            // dgvWeatherHistory
            // 
            dgvWeatherHistory.BackgroundColor = Color.GhostWhite;
            dgvWeatherHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvWeatherHistory.Location = new Point(658, 141);
            dgvWeatherHistory.Name = "dgvWeatherHistory";
            dgvWeatherHistory.RowHeadersWidth = 51;
            dgvWeatherHistory.Size = new Size(556, 576);
            dgvWeatherHistory.TabIndex = 1;
            dgvWeatherHistory.CellContentClick += dgvWeatherHistory_CellContentClick;
            // 
            // lblWeatherHistory
            // 
            lblWeatherHistory.AutoSize = true;
            lblWeatherHistory.BackColor = Color.Transparent;
            lblWeatherHistory.Font = new Font("STCaiyun", 31.1999989F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lblWeatherHistory.ForeColor = Color.Crimson;
            lblWeatherHistory.Location = new Point(711, 84);
            lblWeatherHistory.Name = "lblWeatherHistory";
            lblWeatherHistory.Size = new Size(458, 54);
            lblWeatherHistory.TabIndex = 22;
            lblWeatherHistory.Text = "WEATHER HISTORY";
            lblWeatherHistory.Click += lblWeatherHistory_Click;
            // 
            // btnWeatherTrackerB2D
            // 
            btnWeatherTrackerB2D.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnWeatherTrackerB2D.BackColor = Color.Transparent;
            btnWeatherTrackerB2D.BackgroundImage = (Image)resources.GetObject("btnWeatherTrackerB2D.BackgroundImage");
            btnWeatherTrackerB2D.BackgroundImageLayout = ImageLayout.Zoom;
            btnWeatherTrackerB2D.Font = new Font("ROG Fonts", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnWeatherTrackerB2D.Location = new Point(50, 40);
            btnWeatherTrackerB2D.Name = "btnWeatherTrackerB2D";
            btnWeatherTrackerB2D.Size = new Size(136, 41);
            btnWeatherTrackerB2D.TabIndex = 23;
            btnWeatherTrackerB2D.UseVisualStyleBackColor = false;
            btnWeatherTrackerB2D.Click += btnWeatherTrackerB2D_Click;
            // 
            // WeatherTrackerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1382, 853);
            Controls.Add(btnWeatherTrackerB2D);
            Controls.Add(lblWeatherHistory);
            Controls.Add(dgvWeatherHistory);
            Controls.Add(pnlWeatherEntry);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "WeatherTrackerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WeatherTracker";
            Load += WeatherTrackerForm_Load;
            pnlWeatherEntry.ResumeLayout(false);
            pnlWeatherEntry.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvWeatherHistory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlWeatherEntry;
        private DateTimePicker dtpWeatherEntry;
        private ComboBox cbmWeatherCondition;
        private Button btnSaveWeatherRecord;
        private DataGridView dgvWeatherHistory;
        private Label lblInputHumidity;
        private Label lblInputTemperature;
        private Label lblDateSelection;
        private Label lblWeatherCondition;
        private Label lblWeatherHistory;
        private Button btnWeatherTrackerB2D;
        private TextBox tbxHumidity;
        private TextBox tbxTemperature;
    }
}