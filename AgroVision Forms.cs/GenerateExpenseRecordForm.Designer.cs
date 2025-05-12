namespace AgroVision_Management_System.AgroVision_Forms.cs
{
    partial class GenerateExpenseRecordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenerateExpenseRecordForm));
            pnlGenerateCropReport = new Panel();
            btnClose = new Button();
            dgvListofExpenses = new DataGridView();
            btnGenerateExpenseReport = new Button();
            btnCancelExpenseSave = new Button();
            btnSaveExpense = new Button();
            btnExpenseReportB2D = new Button();
            pnlGenerateCropReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListofExpenses).BeginInit();
            SuspendLayout();
            // 
            // pnlGenerateCropReport
            // 
            pnlGenerateCropReport.BackColor = Color.SaddleBrown;
            pnlGenerateCropReport.Controls.Add(btnClose);
            pnlGenerateCropReport.Controls.Add(dgvListofExpenses);
            pnlGenerateCropReport.Controls.Add(btnGenerateExpenseReport);
            pnlGenerateCropReport.Controls.Add(btnCancelExpenseSave);
            pnlGenerateCropReport.Controls.Add(btnSaveExpense);
            pnlGenerateCropReport.Location = new Point(300, 180);
            pnlGenerateCropReport.Name = "pnlGenerateCropReport";
            pnlGenerateCropReport.Size = new Size(762, 494);
            pnlGenerateCropReport.TabIndex = 3;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnClose.BackColor = SystemColors.ControlLight;
            btnClose.Font = new Font("Rockwell Condensed", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = SystemColors.ActiveCaptionText;
            btnClose.Location = new Point(609, 419);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(116, 49);
            btnClose.TabIndex = 16;
            btnClose.TabStop = false;
            btnClose.Text = "CLOSE";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // dgvListofExpenses
            // 
            dgvListofExpenses.BackgroundColor = Color.FloralWhite;
            dgvListofExpenses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListofExpenses.Location = new Point(0, 0);
            dgvListofExpenses.Name = "dgvListofExpenses";
            dgvListofExpenses.RowHeadersWidth = 51;
            dgvListofExpenses.Size = new Size(573, 494);
            dgvListofExpenses.TabIndex = 12;
            dgvListofExpenses.CellContentClick += dgvListofExpenses_CellContentClick;
            // 
            // btnGenerateExpenseReport
            // 
            btnGenerateExpenseReport.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGenerateExpenseReport.BackColor = Color.Yellow;
            btnGenerateExpenseReport.Font = new Font("Rockwell Condensed", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerateExpenseReport.ForeColor = SystemColors.ActiveCaptionText;
            btnGenerateExpenseReport.Location = new Point(609, 364);
            btnGenerateExpenseReport.Name = "btnGenerateExpenseReport";
            btnGenerateExpenseReport.Size = new Size(116, 49);
            btnGenerateExpenseReport.TabIndex = 15;
            btnGenerateExpenseReport.Text = "Generate Report";
            btnGenerateExpenseReport.UseVisualStyleBackColor = false;
            btnGenerateExpenseReport.Click += btnGenerateExpenseReport_Click;
            // 
            // btnCancelExpenseSave
            // 
            btnCancelExpenseSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelExpenseSave.BackColor = SystemColors.ControlDark;
            btnCancelExpenseSave.Font = new Font("ROG Fonts", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelExpenseSave.Location = new Point(966, 849);
            btnCancelExpenseSave.Name = "btnCancelExpenseSave";
            btnCancelExpenseSave.Size = new Size(130, 54);
            btnCancelExpenseSave.TabIndex = 11;
            btnCancelExpenseSave.Text = "CANCEL";
            btnCancelExpenseSave.UseVisualStyleBackColor = false;
            // 
            // btnSaveExpense
            // 
            btnSaveExpense.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSaveExpense.BackColor = Color.Yellow;
            btnSaveExpense.Font = new Font("ROG Fonts", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSaveExpense.Location = new Point(830, 849);
            btnSaveExpense.Name = "btnSaveExpense";
            btnSaveExpense.Size = new Size(130, 54);
            btnSaveExpense.TabIndex = 10;
            btnSaveExpense.Text = "SAVE";
            btnSaveExpense.UseVisualStyleBackColor = false;
            // 
            // btnExpenseReportB2D
            // 
            btnExpenseReportB2D.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnExpenseReportB2D.BackColor = Color.Transparent;
            btnExpenseReportB2D.BackgroundImage = (Image)resources.GetObject("btnExpenseReportB2D.BackgroundImage");
            btnExpenseReportB2D.BackgroundImageLayout = ImageLayout.Zoom;
            btnExpenseReportB2D.Font = new Font("ROG Fonts", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExpenseReportB2D.Location = new Point(90, 58);
            btnExpenseReportB2D.Name = "btnExpenseReportB2D";
            btnExpenseReportB2D.Size = new Size(136, 41);
            btnExpenseReportB2D.TabIndex = 7;
            btnExpenseReportB2D.UseVisualStyleBackColor = false;
            btnExpenseReportB2D.Click += btnExpenseReportB2D_Click;
            // 
            // GenerateExpenseRecordForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1382, 853);
            Controls.Add(btnExpenseReportB2D);
            Controls.Add(pnlGenerateCropReport);
            Name = "GenerateExpenseRecordForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GenerateExpenseRecord";
            Load += GenerateExpenseRecordForm_Load;
            pnlGenerateCropReport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListofExpenses).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlGenerateCropReport;
        private DataGridView dgvListofExpenses;
        private Button btnCancelExpenseSave;
        private Button btnSaveExpense;
        private Button btnClose;
        private Button btnGenerateExpenseReport;
        private Button btnExpenseReportB2D;
    }
}