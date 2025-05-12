namespace AgroVision_Management_System.AgroVision_Forms.cs
{
    partial class DeleteExpenseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteExpenseForm));
            dgvExpenseRecord = new DataGridView();
            btnDeleteExpense = new Button();
            btnCancelExpenseDelete = new Button();
            btnDeleteExpenseB2D = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvExpenseRecord).BeginInit();
            SuspendLayout();
            // 
            // dgvExpenseRecord
            // 
            dgvExpenseRecord.BackgroundColor = Color.FloralWhite;
            dgvExpenseRecord.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExpenseRecord.Location = new Point(405, 109);
            dgvExpenseRecord.Name = "dgvExpenseRecord";
            dgvExpenseRecord.RowHeadersWidth = 51;
            dgvExpenseRecord.Size = new Size(584, 481);
            dgvExpenseRecord.TabIndex = 0;
            dgvExpenseRecord.CellContentClick += dgvExpenseRecord_CellContentClick;
            // 
            // btnDeleteExpense
            // 
            btnDeleteExpense.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDeleteExpense.BackColor = Color.Crimson;
            btnDeleteExpense.Font = new Font("ROG Fonts", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDeleteExpense.ForeColor = SystemColors.ActiveCaptionText;
            btnDeleteExpense.Location = new Point(726, 625);
            btnDeleteExpense.Name = "btnDeleteExpense";
            btnDeleteExpense.Size = new Size(130, 54);
            btnDeleteExpense.TabIndex = 11;
            btnDeleteExpense.Text = "DELETE";
            btnDeleteExpense.UseVisualStyleBackColor = false;
            btnDeleteExpense.Click += btnDeleteExpense_Click;
            // 
            // btnCancelExpenseDelete
            // 
            btnCancelExpenseDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelExpenseDelete.BackColor = SystemColors.ControlDark;
            btnCancelExpenseDelete.Font = new Font("ROG Fonts", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelExpenseDelete.ForeColor = SystemColors.ActiveCaptionText;
            btnCancelExpenseDelete.Location = new Point(862, 625);
            btnCancelExpenseDelete.Name = "btnCancelExpenseDelete";
            btnCancelExpenseDelete.Size = new Size(130, 54);
            btnCancelExpenseDelete.TabIndex = 12;
            btnCancelExpenseDelete.Text = "CANCEL";
            btnCancelExpenseDelete.UseVisualStyleBackColor = false;
            btnCancelExpenseDelete.Click += btnCancelExpenseDelete_Click;
            // 
            // btnDeleteExpenseB2D
            // 
            btnDeleteExpenseB2D.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDeleteExpenseB2D.BackColor = Color.Transparent;
            btnDeleteExpenseB2D.BackgroundImage = (Image)resources.GetObject("btnDeleteExpenseB2D.BackgroundImage");
            btnDeleteExpenseB2D.BackgroundImageLayout = ImageLayout.Zoom;
            btnDeleteExpenseB2D.Font = new Font("ROG Fonts", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDeleteExpenseB2D.Location = new Point(83, 57);
            btnDeleteExpenseB2D.Name = "btnDeleteExpenseB2D";
            btnDeleteExpenseB2D.Size = new Size(136, 41);
            btnDeleteExpenseB2D.TabIndex = 13;
            btnDeleteExpenseB2D.UseVisualStyleBackColor = false;
            btnDeleteExpenseB2D.Click += btnDeleteExpenseB2D_Click;
            // 
            // DeleteExpenseForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1382, 853);
            Controls.Add(btnDeleteExpenseB2D);
            Controls.Add(btnCancelExpenseDelete);
            Controls.Add(btnDeleteExpense);
            Controls.Add(dgvExpenseRecord);
            ForeColor = SystemColors.ControlLightLight;
            Name = "DeleteExpenseForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DeleteExpense";
            Load += DeleteExpenseForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvExpenseRecord).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvExpenseRecord;
        private Button btnDeleteExpense;
        private Button btnCancelExpenseDelete;
        private Button btnDeleteExpenseB2D;
    }
}