namespace AgroVision_Management_System.AgroVision_Forms.cs
{
    partial class RecordExpenseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecordExpenseForm));
            pnlCropDetailstoUpdate = new Panel();
            btnCancelExpenseSave = new Button();
            btnSaveExpense = new Button();
            lblAddExpenseAmount = new Label();
            tbxExpenseAmount = new TextBox();
            tbxExpenseItem = new TextBox();
            lblAddExpenseItem = new Label();
            btnRecordExpenseB2D = new Button();
            pnlCropDetailstoUpdate.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCropDetailstoUpdate
            // 
            pnlCropDetailstoUpdate.BackColor = Color.SaddleBrown;
            pnlCropDetailstoUpdate.Controls.Add(btnCancelExpenseSave);
            pnlCropDetailstoUpdate.Controls.Add(btnSaveExpense);
            pnlCropDetailstoUpdate.Controls.Add(lblAddExpenseAmount);
            pnlCropDetailstoUpdate.Controls.Add(tbxExpenseAmount);
            pnlCropDetailstoUpdate.Controls.Add(tbxExpenseItem);
            pnlCropDetailstoUpdate.Controls.Add(lblAddExpenseItem);
            pnlCropDetailstoUpdate.Location = new Point(446, 131);
            pnlCropDetailstoUpdate.Name = "pnlCropDetailstoUpdate";
            pnlCropDetailstoUpdate.Size = new Size(565, 591);
            pnlCropDetailstoUpdate.TabIndex = 2;
            // 
            // btnCancelExpenseSave
            // 
            btnCancelExpenseSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelExpenseSave.BackColor = SystemColors.ControlDark;
            btnCancelExpenseSave.Font = new Font("ROG Fonts", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelExpenseSave.Location = new Point(404, 455);
            btnCancelExpenseSave.Name = "btnCancelExpenseSave";
            btnCancelExpenseSave.Size = new Size(130, 54);
            btnCancelExpenseSave.TabIndex = 11;
            btnCancelExpenseSave.Text = "CANCEL";
            btnCancelExpenseSave.UseVisualStyleBackColor = false;
            btnCancelExpenseSave.Click += btnCancelExpenseSave_Click;
            // 
            // btnSaveExpense
            // 
            btnSaveExpense.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSaveExpense.BackColor = Color.Yellow;
            btnSaveExpense.Font = new Font("ROG Fonts", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSaveExpense.Location = new Point(268, 455);
            btnSaveExpense.Name = "btnSaveExpense";
            btnSaveExpense.Size = new Size(130, 54);
            btnSaveExpense.TabIndex = 10;
            btnSaveExpense.Text = "SAVE";
            btnSaveExpense.UseVisualStyleBackColor = false;
            btnSaveExpense.Click += btnSaveExpense_Click;
            // 
            // lblAddExpenseAmount
            // 
            lblAddExpenseAmount.AutoSize = true;
            lblAddExpenseAmount.BackColor = Color.PowderBlue;
            lblAddExpenseAmount.Font = new Font("Rockwell Condensed", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddExpenseAmount.Location = new Point(20, 174);
            lblAddExpenseAmount.Name = "lblAddExpenseAmount";
            lblAddExpenseAmount.Size = new Size(229, 27);
            lblAddExpenseAmount.TabIndex = 9;
            lblAddExpenseAmount.Text = "Enter Expense Amount:";
            // 
            // tbxExpenseAmount
            // 
            tbxExpenseAmount.Location = new Point(280, 174);
            tbxExpenseAmount.Multiline = true;
            tbxExpenseAmount.Name = "tbxExpenseAmount";
            tbxExpenseAmount.Size = new Size(254, 27);
            tbxExpenseAmount.TabIndex = 8;
            // 
            // tbxExpenseItem
            // 
            tbxExpenseItem.Location = new Point(280, 111);
            tbxExpenseItem.Multiline = true;
            tbxExpenseItem.Name = "tbxExpenseItem";
            tbxExpenseItem.Size = new Size(254, 27);
            tbxExpenseItem.TabIndex = 3;
            // 
            // lblAddExpenseItem
            // 
            lblAddExpenseItem.AutoSize = true;
            lblAddExpenseItem.BackColor = Color.PowderBlue;
            lblAddExpenseItem.Font = new Font("Rockwell Condensed", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddExpenseItem.Location = new Point(22, 111);
            lblAddExpenseItem.Name = "lblAddExpenseItem";
            lblAddExpenseItem.Size = new Size(199, 27);
            lblAddExpenseItem.TabIndex = 2;
            lblAddExpenseItem.Text = "Enter Expense Item:";
            // 
            // btnRecordExpenseB2D
            // 
            btnRecordExpenseB2D.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRecordExpenseB2D.BackColor = Color.Transparent;
            btnRecordExpenseB2D.BackgroundImage = (Image)resources.GetObject("btnRecordExpenseB2D.BackgroundImage");
            btnRecordExpenseB2D.BackgroundImageLayout = ImageLayout.Zoom;
            btnRecordExpenseB2D.Font = new Font("ROG Fonts", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRecordExpenseB2D.Location = new Point(62, 73);
            btnRecordExpenseB2D.Name = "btnRecordExpenseB2D";
            btnRecordExpenseB2D.Size = new Size(136, 41);
            btnRecordExpenseB2D.TabIndex = 7;
            btnRecordExpenseB2D.UseVisualStyleBackColor = false;
            btnRecordExpenseB2D.Click += btnRecordExpenseB2D_Click;
            // 
            // RecordExpenseForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1382, 853);
            Controls.Add(btnRecordExpenseB2D);
            Controls.Add(pnlCropDetailstoUpdate);
            DoubleBuffered = true;
            Name = "RecordExpenseForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RecordExpense";
            Load += RecordExpenseForm_Load;
            pnlCropDetailstoUpdate.ResumeLayout(false);
            pnlCropDetailstoUpdate.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlCropDetailstoUpdate;
        private TextBox tbxExpenseItem;
        private Label lblAddExpenseItem;
        private TextBox tbxExpenseAmount;
        private Label lblAddExpenseAmount;
        private Button btnSaveExpense;
        private Button btnCancelExpenseSave;
        private Button btnRecordExpenseB2D;
    }
}