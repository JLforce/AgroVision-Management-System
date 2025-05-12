namespace AgroVision_Management_System.AgroVision_Forms.cs
{
    partial class DeleteItemForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteItemForm));
            dgvDeleteInventory = new DataGridView();
            btnDelete = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDeleteInventory).BeginInit();
            SuspendLayout();
            // 
            // dgvDeleteInventory
            // 
            dgvDeleteInventory.BackgroundColor = SystemColors.Info;
            dgvDeleteInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDeleteInventory.Dock = DockStyle.Bottom;
            dgvDeleteInventory.Location = new Point(0, 421);
            dgvDeleteInventory.Name = "dgvDeleteInventory";
            dgvDeleteInventory.RowHeadersWidth = 51;
            dgvDeleteInventory.Size = new Size(800, 435);
            dgvDeleteInventory.TabIndex = 0;
            dgvDeleteInventory.CellContentClick += dgvDeleteInventory_CellContentClick;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.DarkKhaki;
            btnDelete.Font = new Font("SimSun-ExtG", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(282, 332);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(119, 46);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.DarkKhaki;
            btnCancel.Font = new Font("SimSun-ExtG", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(407, 332);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(119, 46);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // DeleteItemForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(800, 856);
            Controls.Add(btnCancel);
            Controls.Add(btnDelete);
            Controls.Add(dgvDeleteInventory);
            DoubleBuffered = true;
            Name = "DeleteItemForm";
            Text = "DeleteItemForm";
            Load += DeleteItemForm_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvDeleteInventory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvDeleteInventory;
        private Button btnDelete;
        private Button btnCancel;
    }
}