namespace AgroVision_Management_System.AgroVision_Forms.cs
{
    partial class DeleteCropForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteCropForm));
            btnDeleteCrop = new Button();
            btnCancelCropDelete = new Button();
            dgvDeleteCrop = new DataGridView();
            btnDeleteCropB2D = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDeleteCrop).BeginInit();
            SuspendLayout();
            // 
            // btnDeleteCrop
            // 
            btnDeleteCrop.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDeleteCrop.BackColor = Color.Crimson;
            btnDeleteCrop.Font = new Font("ROG Fonts", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDeleteCrop.Location = new Point(779, 654);
            btnDeleteCrop.Name = "btnDeleteCrop";
            btnDeleteCrop.Size = new Size(124, 54);
            btnDeleteCrop.TabIndex = 5;
            btnDeleteCrop.Text = "DELETE";
            btnDeleteCrop.UseVisualStyleBackColor = false;
            btnDeleteCrop.Click += btnDeleteCrop_Click;
            // 
            // btnCancelCropDelete
            // 
            btnCancelCropDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelCropDelete.BackColor = SystemColors.ControlDark;
            btnCancelCropDelete.Font = new Font("ROG Fonts", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelCropDelete.Location = new Point(922, 654);
            btnCancelCropDelete.Name = "btnCancelCropDelete";
            btnCancelCropDelete.Size = new Size(119, 54);
            btnCancelCropDelete.TabIndex = 6;
            btnCancelCropDelete.Text = "CANCEL";
            btnCancelCropDelete.UseVisualStyleBackColor = false;
            // 
            // dgvDeleteCrop
            // 
            dgvDeleteCrop.BackgroundColor = Color.FloralWhite;
            dgvDeleteCrop.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDeleteCrop.Location = new Point(367, 118);
            dgvDeleteCrop.Name = "dgvDeleteCrop";
            dgvDeleteCrop.RowHeadersWidth = 51;
            dgvDeleteCrop.Size = new Size(674, 506);
            dgvDeleteCrop.TabIndex = 7;
            dgvDeleteCrop.CellContentClick += dgvDeleteCrop_CellContentClick;
            // 
            // btnDeleteCropB2D
            // 
            btnDeleteCropB2D.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDeleteCropB2D.BackColor = Color.Transparent;
            btnDeleteCropB2D.BackgroundImage = (Image)resources.GetObject("btnDeleteCropB2D.BackgroundImage");
            btnDeleteCropB2D.BackgroundImageLayout = ImageLayout.Zoom;
            btnDeleteCropB2D.Font = new Font("ROG Fonts", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDeleteCropB2D.Location = new Point(59, 47);
            btnDeleteCropB2D.Name = "btnDeleteCropB2D";
            btnDeleteCropB2D.Size = new Size(136, 41);
            btnDeleteCropB2D.TabIndex = 8;
            btnDeleteCropB2D.UseVisualStyleBackColor = false;
            btnDeleteCropB2D.Click += btnDeleteCropB2D_Click;
            // 
            // DeleteCropForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OliveDrab;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1382, 853);
            Controls.Add(btnDeleteCropB2D);
            Controls.Add(dgvDeleteCrop);
            Controls.Add(btnCancelCropDelete);
            Controls.Add(btnDeleteCrop);
            Name = "DeleteCropForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DeleteCrop";
            Load += DeleteCropForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDeleteCrop).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnDeleteCrop;
        private Button btnCancelCropDelete;
        private DataGridView dgvDeleteCrop;
        private Button btnDeleteCropB2D;
    }
}