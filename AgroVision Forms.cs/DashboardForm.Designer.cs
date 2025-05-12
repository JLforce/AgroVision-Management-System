namespace AgroVision_Management_System.AgroVision_Forms.cs
{
    partial class DashboardForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            pnlDashboard = new Panel();
            btnUpdateItem = new Button();
            btnDeleteItem = new Button();
            btnAddItem = new Button();
            btnSales = new Button();
            lblRecordSales = new Label();
            lblManageInventory = new Label();
            lblWeatherMonitoring = new Label();
            lblExpenseTracking = new Label();
            lblCropManagement = new Label();
            btnWeatherEntryHistory = new Button();
            btnGenerateExpenseRecord = new Button();
            btnDeleteExpense = new Button();
            btnRecordExpense = new Button();
            btnUpdateCrop = new Button();
            btnDeleteCrop = new Button();
            btnAddCrop = new Button();
            pnlDashboardUpperLeft = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            lblProjectTitle = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnLoadChart = new Button();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            refreshToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            manageToolStripMenuItem = new ToolStripMenuItem();
            addCropToolStripMenuItem = new ToolStripMenuItem();
            recordExpenseToolStripMenuItem = new ToolStripMenuItem();
            weatherEntryToolStripMenuItem = new ToolStripMenuItem();
            reportsToolStripMenuItem = new ToolStripMenuItem();
            generateCropReportToolStripMenuItem = new ToolStripMenuItem();
            expenseRecordToolStripMenuItem = new ToolStripMenuItem();
            weatherHistoryToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            userGuideToolStripMenuItem = new ToolStripMenuItem();
            contextMenuDashboard = new ContextMenuStrip(components);
            refreshDashboardToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem1 = new ToolStripMenuItem();
            exitToolStripMenuItem1 = new ToolStripMenuItem();
            pnlDashboardUpperRight = new Panel();
            pictureBox8 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            crtfarmSales = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dtpStartDate = new DateTimePicker();
            pnlDashboard.SuspendLayout();
            pnlDashboardUpperLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            contextMenuDashboard.SuspendLayout();
            pnlDashboardUpperRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)crtfarmSales).BeginInit();
            SuspendLayout();
            // 
            // pnlDashboard
            // 
            pnlDashboard.BackColor = Color.SeaShell;
            pnlDashboard.BackgroundImage = (Image)resources.GetObject("pnlDashboard.BackgroundImage");
            pnlDashboard.BackgroundImageLayout = ImageLayout.Stretch;
            pnlDashboard.Controls.Add(btnUpdateItem);
            pnlDashboard.Controls.Add(btnDeleteItem);
            pnlDashboard.Controls.Add(btnAddItem);
            pnlDashboard.Controls.Add(btnSales);
            pnlDashboard.Controls.Add(lblRecordSales);
            pnlDashboard.Controls.Add(lblManageInventory);
            pnlDashboard.Controls.Add(lblWeatherMonitoring);
            pnlDashboard.Controls.Add(lblExpenseTracking);
            pnlDashboard.Controls.Add(lblCropManagement);
            pnlDashboard.Controls.Add(btnWeatherEntryHistory);
            pnlDashboard.Controls.Add(btnGenerateExpenseRecord);
            pnlDashboard.Controls.Add(btnDeleteExpense);
            pnlDashboard.Controls.Add(btnRecordExpense);
            pnlDashboard.Controls.Add(btnUpdateCrop);
            pnlDashboard.Controls.Add(btnDeleteCrop);
            pnlDashboard.Controls.Add(btnAddCrop);
            pnlDashboard.Controls.Add(pnlDashboardUpperLeft);
            pnlDashboard.Dock = DockStyle.Left;
            pnlDashboard.Location = new Point(0, 0);
            pnlDashboard.Name = "pnlDashboard";
            pnlDashboard.Size = new Size(441, 853);
            pnlDashboard.TabIndex = 0;
            // 
            // btnUpdateItem
            // 
            btnUpdateItem.BackColor = Color.LightSteelBlue;
            btnUpdateItem.Font = new Font("Bahnschrift SemiCondensed", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateItem.Location = new Point(55, 643);
            btnUpdateItem.Name = "btnUpdateItem";
            btnUpdateItem.Size = new Size(130, 36);
            btnUpdateItem.TabIndex = 24;
            btnUpdateItem.Text = "Update Item";
            btnUpdateItem.UseVisualStyleBackColor = false;
            btnUpdateItem.Click += btnUpdateItem_Click;
            // 
            // btnDeleteItem
            // 
            btnDeleteItem.BackColor = Color.LightSteelBlue;
            btnDeleteItem.Font = new Font("Bahnschrift SemiCondensed", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteItem.Location = new Point(218, 601);
            btnDeleteItem.Name = "btnDeleteItem";
            btnDeleteItem.Size = new Size(130, 36);
            btnDeleteItem.TabIndex = 23;
            btnDeleteItem.Text = "Delete Item";
            btnDeleteItem.UseVisualStyleBackColor = false;
            btnDeleteItem.Click += btnDeleteItem_Click;
            // 
            // btnAddItem
            // 
            btnAddItem.BackColor = Color.LightSteelBlue;
            btnAddItem.Font = new Font("Bahnschrift SemiCondensed", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddItem.Location = new Point(55, 601);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(130, 36);
            btnAddItem.TabIndex = 22;
            btnAddItem.Text = "Add Item";
            btnAddItem.UseVisualStyleBackColor = false;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // btnSales
            // 
            btnSales.BackColor = Color.LightSteelBlue;
            btnSales.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSales.Location = new Point(59, 754);
            btnSales.Name = "btnSales";
            btnSales.Size = new Size(130, 36);
            btnSales.TabIndex = 21;
            btnSales.Text = "Sales";
            btnSales.UseVisualStyleBackColor = false;
            btnSales.Click += btnSales_Click;
            // 
            // lblRecordSales
            // 
            lblRecordSales.AutoSize = true;
            lblRecordSales.BackColor = Color.MediumAquamarine;
            lblRecordSales.Font = new Font("Berlin Sans FB Demi", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecordSales.Location = new Point(55, 724);
            lblRecordSales.Name = "lblRecordSales";
            lblRecordSales.Size = new Size(168, 27);
            lblRecordSales.TabIndex = 20;
            lblRecordSales.Text = "RECORD SALES";
            // 
            // lblManageInventory
            // 
            lblManageInventory.AutoSize = true;
            lblManageInventory.BackColor = Color.MediumAquamarine;
            lblManageInventory.Font = new Font("Berlin Sans FB Demi", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblManageInventory.Location = new Point(55, 571);
            lblManageInventory.Name = "lblManageInventory";
            lblManageInventory.Size = new Size(241, 27);
            lblManageInventory.TabIndex = 18;
            lblManageInventory.Text = "MANAGE INVENTORY";
            // 
            // lblWeatherMonitoring
            // 
            lblWeatherMonitoring.AutoSize = true;
            lblWeatherMonitoring.BackColor = Color.MediumAquamarine;
            lblWeatherMonitoring.Font = new Font("Berlin Sans FB Demi", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWeatherMonitoring.Location = new Point(55, 469);
            lblWeatherMonitoring.Name = "lblWeatherMonitoring";
            lblWeatherMonitoring.Size = new Size(268, 27);
            lblWeatherMonitoring.TabIndex = 17;
            lblWeatherMonitoring.Text = "WEATHER MONITORING";
            // 
            // lblExpenseTracking
            // 
            lblExpenseTracking.AutoSize = true;
            lblExpenseTracking.BackColor = Color.MediumAquamarine;
            lblExpenseTracking.Font = new Font("Berlin Sans FB Demi", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExpenseTracking.Location = new Point(55, 327);
            lblExpenseTracking.Name = "lblExpenseTracking";
            lblExpenseTracking.Size = new Size(223, 27);
            lblExpenseTracking.TabIndex = 16;
            lblExpenseTracking.Text = "EXPENSE TRACKING";
            // 
            // lblCropManagement
            // 
            lblCropManagement.AutoSize = true;
            lblCropManagement.BackColor = Color.MediumAquamarine;
            lblCropManagement.Font = new Font("Berlin Sans FB Demi", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCropManagement.Location = new Point(55, 183);
            lblCropManagement.Name = "lblCropManagement";
            lblCropManagement.Size = new Size(237, 27);
            lblCropManagement.TabIndex = 15;
            lblCropManagement.Text = "CROP MANAGEMENT";
            // 
            // btnWeatherEntryHistory
            // 
            btnWeatherEntryHistory.BackColor = Color.LightSteelBlue;
            btnWeatherEntryHistory.Font = new Font("Bahnschrift SemiCondensed", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnWeatherEntryHistory.Location = new Point(55, 499);
            btnWeatherEntryHistory.Name = "btnWeatherEntryHistory";
            btnWeatherEntryHistory.Size = new Size(205, 36);
            btnWeatherEntryHistory.TabIndex = 12;
            btnWeatherEntryHistory.Text = "Weather Entry / History";
            btnWeatherEntryHistory.UseVisualStyleBackColor = false;
            btnWeatherEntryHistory.Click += btnWeatherEntryHistory_Click;
            // 
            // btnGenerateExpenseRecord
            // 
            btnGenerateExpenseRecord.BackColor = Color.LightSteelBlue;
            btnGenerateExpenseRecord.Font = new Font("Bahnschrift SemiCondensed", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerateExpenseRecord.Location = new Point(55, 399);
            btnGenerateExpenseRecord.Name = "btnGenerateExpenseRecord";
            btnGenerateExpenseRecord.Size = new Size(141, 36);
            btnGenerateExpenseRecord.TabIndex = 10;
            btnGenerateExpenseRecord.Text = "Generate Record";
            btnGenerateExpenseRecord.UseVisualStyleBackColor = false;
            btnGenerateExpenseRecord.Click += btnGenerateExpenseRecord_Click;
            // 
            // btnDeleteExpense
            // 
            btnDeleteExpense.BackColor = Color.LightSteelBlue;
            btnDeleteExpense.Font = new Font("Bahnschrift SemiCondensed", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteExpense.Location = new Point(218, 357);
            btnDeleteExpense.Name = "btnDeleteExpense";
            btnDeleteExpense.Size = new Size(141, 36);
            btnDeleteExpense.TabIndex = 9;
            btnDeleteExpense.Text = "Delete Expense";
            btnDeleteExpense.UseVisualStyleBackColor = false;
            btnDeleteExpense.Click += btnDeleteExpense_Click;
            // 
            // btnRecordExpense
            // 
            btnRecordExpense.BackColor = Color.LightSteelBlue;
            btnRecordExpense.Font = new Font("Bahnschrift SemiCondensed", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRecordExpense.Location = new Point(55, 357);
            btnRecordExpense.Name = "btnRecordExpense";
            btnRecordExpense.Size = new Size(141, 36);
            btnRecordExpense.TabIndex = 8;
            btnRecordExpense.Text = "Record Expense";
            btnRecordExpense.UseVisualStyleBackColor = false;
            btnRecordExpense.Click += btnRecordExpense_Click;
            // 
            // btnUpdateCrop
            // 
            btnUpdateCrop.BackColor = Color.LightSteelBlue;
            btnUpdateCrop.Font = new Font("Bahnschrift SemiCondensed", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateCrop.Location = new Point(55, 255);
            btnUpdateCrop.Name = "btnUpdateCrop";
            btnUpdateCrop.Size = new Size(130, 36);
            btnUpdateCrop.TabIndex = 6;
            btnUpdateCrop.Text = "Update Crop";
            btnUpdateCrop.UseVisualStyleBackColor = false;
            btnUpdateCrop.Click += btnUpdateCrop_Click;
            // 
            // btnDeleteCrop
            // 
            btnDeleteCrop.BackColor = Color.LightSteelBlue;
            btnDeleteCrop.Font = new Font("Bahnschrift SemiCondensed", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteCrop.Location = new Point(218, 213);
            btnDeleteCrop.Name = "btnDeleteCrop";
            btnDeleteCrop.Size = new Size(130, 36);
            btnDeleteCrop.TabIndex = 5;
            btnDeleteCrop.Text = "Delete Crop";
            btnDeleteCrop.UseVisualStyleBackColor = false;
            btnDeleteCrop.Click += btnDeleteCrop_Click;
            // 
            // btnAddCrop
            // 
            btnAddCrop.BackColor = Color.LightSteelBlue;
            btnAddCrop.Font = new Font("Bahnschrift SemiCondensed", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddCrop.Location = new Point(55, 213);
            btnAddCrop.Name = "btnAddCrop";
            btnAddCrop.Size = new Size(130, 36);
            btnAddCrop.TabIndex = 4;
            btnAddCrop.Text = "Add Crop";
            btnAddCrop.UseVisualStyleBackColor = false;
            btnAddCrop.Click += btnAddCrop_Click;
            // 
            // pnlDashboardUpperLeft
            // 
            pnlDashboardUpperLeft.BackColor = Color.Transparent;
            pnlDashboardUpperLeft.BackgroundImage = (Image)resources.GetObject("pnlDashboardUpperLeft.BackgroundImage");
            pnlDashboardUpperLeft.Controls.Add(panel3);
            pnlDashboardUpperLeft.Controls.Add(panel2);
            pnlDashboardUpperLeft.Controls.Add(lblProjectTitle);
            pnlDashboardUpperLeft.Controls.Add(pictureBox1);
            pnlDashboardUpperLeft.Controls.Add(panel1);
            pnlDashboardUpperLeft.Location = new Point(0, 0);
            pnlDashboardUpperLeft.Name = "pnlDashboardUpperLeft";
            pnlDashboardUpperLeft.Size = new Size(454, 132);
            pnlDashboardUpperLeft.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.Location = new Point(441, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(942, 125);
            panel3.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Location = new Point(441, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(942, 132);
            panel2.TabIndex = 1;
            // 
            // lblProjectTitle
            // 
            lblProjectTitle.AutoSize = true;
            lblProjectTitle.BackColor = Color.FloralWhite;
            lblProjectTitle.Font = new Font("Courier New", 31.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblProjectTitle.ForeColor = Color.SaddleBrown;
            lblProjectTitle.Location = new Point(82, 35);
            lblProjectTitle.Name = "lblProjectTitle";
            lblProjectTitle.Size = new Size(347, 61);
            lblProjectTitle.TabIndex = 3;
            lblProjectTitle.Text = "AgroVISION";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 107);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Location = new Point(438, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(256, 125);
            panel1.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(3, 32);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(250, 125);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // btnLoadChart
            // 
            btnLoadChart.BackColor = Color.ForestGreen;
            btnLoadChart.Font = new Font("Bahnschrift SemiCondensed", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoadChart.ForeColor = SystemColors.ActiveCaptionText;
            btnLoadChart.Location = new Point(1213, 305);
            btnLoadChart.Name = "btnLoadChart";
            btnLoadChart.Size = new Size(129, 49);
            btnLoadChart.TabIndex = 25;
            btnLoadChart.Text = "LOAD";
            btnLoadChart.UseVisualStyleBackColor = false;
            btnLoadChart.Click += btnLoadChart_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Snow;
            menuStrip1.Dock = DockStyle.Bottom;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, manageToolStripMenuItem, reportsToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 96);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(939, 36);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.BackColor = Color.MintCream;
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { refreshToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Font = new Font("Bahnschrift SemiCondensed", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fileToolStripMenuItem.ForeColor = Color.Black;
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(59, 32);
            fileToolStripMenuItem.Text = "File";
            // 
            // refreshToolStripMenuItem
            // 
            refreshToolStripMenuItem.BackColor = Color.Honeydew;
            refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            refreshToolStripMenuItem.Size = new Size(170, 32);
            refreshToolStripMenuItem.Text = "Refresh";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.BackColor = Color.Honeydew;
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(170, 32);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // manageToolStripMenuItem
            // 
            manageToolStripMenuItem.BackColor = Color.MintCream;
            manageToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addCropToolStripMenuItem, recordExpenseToolStripMenuItem, weatherEntryToolStripMenuItem });
            manageToolStripMenuItem.Font = new Font("Bahnschrift SemiCondensed", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            manageToolStripMenuItem.ForeColor = Color.Black;
            manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            manageToolStripMenuItem.Size = new Size(96, 32);
            manageToolStripMenuItem.Text = "Manage";
            // 
            // addCropToolStripMenuItem
            // 
            addCropToolStripMenuItem.BackColor = Color.Honeydew;
            addCropToolStripMenuItem.Name = "addCropToolStripMenuItem";
            addCropToolStripMenuItem.Size = new Size(243, 32);
            addCropToolStripMenuItem.Text = "Add Crop";
            // 
            // recordExpenseToolStripMenuItem
            // 
            recordExpenseToolStripMenuItem.BackColor = Color.Honeydew;
            recordExpenseToolStripMenuItem.Name = "recordExpenseToolStripMenuItem";
            recordExpenseToolStripMenuItem.Size = new Size(243, 32);
            recordExpenseToolStripMenuItem.Text = "Record Expense";
            // 
            // weatherEntryToolStripMenuItem
            // 
            weatherEntryToolStripMenuItem.BackColor = Color.Honeydew;
            weatherEntryToolStripMenuItem.Name = "weatherEntryToolStripMenuItem";
            weatherEntryToolStripMenuItem.Size = new Size(243, 32);
            weatherEntryToolStripMenuItem.Text = "Weather Entry";
            // 
            // reportsToolStripMenuItem
            // 
            reportsToolStripMenuItem.BackColor = Color.MintCream;
            reportsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { generateCropReportToolStripMenuItem, expenseRecordToolStripMenuItem, weatherHistoryToolStripMenuItem });
            reportsToolStripMenuItem.Font = new Font("Bahnschrift SemiCondensed", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            reportsToolStripMenuItem.ForeColor = Color.Black;
            reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            reportsToolStripMenuItem.Size = new Size(98, 32);
            reportsToolStripMenuItem.Text = "Reports";
            // 
            // expenseRecordToolStripMenuItem
            // 
            expenseRecordToolStripMenuItem.BackColor = Color.Honeydew;
            expenseRecordToolStripMenuItem.Name = "expenseRecordToolStripMenuItem";
            expenseRecordToolStripMenuItem.Size = new Size(243, 32);
            expenseRecordToolStripMenuItem.Text = "Expense Record";
            // 
            // weatherHistoryToolStripMenuItem
            // 
            weatherHistoryToolStripMenuItem.BackColor = Color.Honeydew;
            weatherHistoryToolStripMenuItem.Name = "weatherHistoryToolStripMenuItem";
            weatherHistoryToolStripMenuItem.Size = new Size(243, 32);
            weatherHistoryToolStripMenuItem.Text = "Weather History";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.BackColor = Color.MintCream;
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem, userGuideToolStripMenuItem });
            helpToolStripMenuItem.Font = new Font("Bahnschrift SemiCondensed", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            helpToolStripMenuItem.ForeColor = Color.Black;
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(67, 32);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.BackColor = Color.Honeydew;
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(196, 32);
            aboutToolStripMenuItem.Text = "About";
            // 
            // userGuideToolStripMenuItem
            // 
            userGuideToolStripMenuItem.BackColor = Color.Honeydew;
            userGuideToolStripMenuItem.Name = "userGuideToolStripMenuItem";
            userGuideToolStripMenuItem.Size = new Size(196, 32);
            userGuideToolStripMenuItem.Text = "User Guide";
            // 
            // contextMenuDashboard
            // 
            contextMenuDashboard.ImageScalingSize = new Size(20, 20);
            contextMenuDashboard.Items.AddRange(new ToolStripItem[] { refreshDashboardToolStripMenuItem, logoutToolStripMenuItem1, exitToolStripMenuItem1 });
            contextMenuDashboard.Name = "contextMenuStrip1";
            contextMenuDashboard.RenderMode = ToolStripRenderMode.Professional;
            contextMenuDashboard.Size = new Size(140, 88);
            contextMenuDashboard.Text = "DashboardMenu";
            // 
            // refreshDashboardToolStripMenuItem
            // 
            refreshDashboardToolStripMenuItem.BackColor = Color.MintCream;
            refreshDashboardToolStripMenuItem.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            refreshDashboardToolStripMenuItem.Name = "refreshDashboardToolStripMenuItem";
            refreshDashboardToolStripMenuItem.Size = new Size(139, 28);
            refreshDashboardToolStripMenuItem.Text = "Refresh";
            refreshDashboardToolStripMenuItem.Click += refreshDashboardToolStripMenuItem_Click;
            // 
            // logoutToolStripMenuItem1
            // 
            logoutToolStripMenuItem1.BackColor = Color.MintCream;
            logoutToolStripMenuItem1.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logoutToolStripMenuItem1.Name = "logoutToolStripMenuItem1";
            logoutToolStripMenuItem1.Size = new Size(139, 28);
            logoutToolStripMenuItem1.Text = "Logout";
            logoutToolStripMenuItem1.Click += logoutToolStripMenuItem1_Click;
            // 
            // exitToolStripMenuItem1
            // 
            exitToolStripMenuItem1.BackColor = Color.MintCream;
            exitToolStripMenuItem1.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            exitToolStripMenuItem1.Size = new Size(139, 28);
            exitToolStripMenuItem1.Text = "Exit";
            // 
            // pnlDashboardUpperRight
            // 
            pnlDashboardUpperRight.BackColor = Color.Transparent;
            pnlDashboardUpperRight.BackgroundImage = (Image)resources.GetObject("pnlDashboardUpperRight.BackgroundImage");
            pnlDashboardUpperRight.Controls.Add(pictureBox8);
            pnlDashboardUpperRight.Controls.Add(pictureBox7);
            pnlDashboardUpperRight.Controls.Add(pictureBox6);
            pnlDashboardUpperRight.Controls.Add(pictureBox5);
            pnlDashboardUpperRight.Controls.Add(pictureBox4);
            pnlDashboardUpperRight.Controls.Add(pictureBox3);
            pnlDashboardUpperRight.Controls.Add(pictureBox2);
            pnlDashboardUpperRight.Controls.Add(menuStrip1);
            pnlDashboardUpperRight.Location = new Point(444, 0);
            pnlDashboardUpperRight.Name = "pnlDashboardUpperRight";
            pnlDashboardUpperRight.Size = new Size(939, 132);
            pnlDashboardUpperRight.TabIndex = 1;
            // 
            // pictureBox8
            // 
            pictureBox8.BackgroundImage = (Image)resources.GetObject("pictureBox8.BackgroundImage");
            pictureBox8.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox8.Location = new Point(524, 0);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(93, 96);
            pictureBox8.TabIndex = 4;
            pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.BackgroundImage = (Image)resources.GetObject("pictureBox7.BackgroundImage");
            pictureBox7.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox7.Location = new Point(320, 0);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(94, 96);
            pictureBox7.TabIndex = 4;
            pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackgroundImage = (Image)resources.GetObject("pictureBox6.BackgroundImage");
            pictureBox6.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox6.Location = new Point(410, 0);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(118, 96);
            pictureBox6.TabIndex = 3;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImage = (Image)resources.GetObject("pictureBox5.BackgroundImage");
            pictureBox5.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox5.Location = new Point(0, 0);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(59, 96);
            pictureBox5.TabIndex = 3;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Location = new Point(59, 25);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(146, 71);
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(709, 35);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(107, 61);
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(813, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(123, 96);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // crtfarmSales
            // 
            chartArea1.Name = "ChartArea1";
            crtfarmSales.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            crtfarmSales.Legends.Add(legend1);
            crtfarmSales.Location = new Point(598, 187);
            crtfarmSales.Name = "crtfarmSales";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "SalesSeries";
            crtfarmSales.Series.Add(series1);
            crtfarmSales.Size = new Size(578, 348);
            crtfarmSales.TabIndex = 2;
            crtfarmSales.Text = "chart1";
            crtfarmSales.Click += chart1_Click;
            // 
            // dtpStartDate
            // 
            dtpStartDate.CalendarForeColor = SystemColors.ActiveCaptionText;
            dtpStartDate.CalendarMonthBackground = SystemColors.GradientInactiveCaption;
            dtpStartDate.CalendarTitleForeColor = SystemColors.ControlDarkDark;
            dtpStartDate.Font = new Font("Poor Richard", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpStartDate.Location = new Point(598, 601);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(494, 45);
            dtpStartDate.TabIndex = 27;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1382, 853);
            Controls.Add(dtpStartDate);
            Controls.Add(btnLoadChart);
            Controls.Add(crtfarmSales);
            Controls.Add(pnlDashboardUpperRight);
            Controls.Add(pnlDashboard);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MainMenuStrip = menuStrip1;
            Name = "DashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += DashboardForm_Load;
            pnlDashboard.ResumeLayout(false);
            pnlDashboard.PerformLayout();
            pnlDashboardUpperLeft.ResumeLayout(false);
            pnlDashboardUpperLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            contextMenuDashboard.ResumeLayout(false);
            pnlDashboardUpperRight.ResumeLayout(false);
            pnlDashboardUpperRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)crtfarmSales).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlDashboard;
        private Panel pnlDashboardUpperLeft;
        private Panel panel1;
        private Label lblProjectTitle;
        private PictureBox pictureBox1;
        private Button btnUpdateCrop;
        private Button btnDeleteCrop;
        private Button btnAddCrop;
        private Button btnGenerateExpenseRecord;
        private Button btnDeleteExpense;
        private Button btnRecordExpense;
        private Button btnWeatherEntryHistory;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem refreshToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem manageToolStripMenuItem;
        private ToolStripMenuItem reportsToolStripMenuItem;
        private ToolStripMenuItem generateCropReportToolStripMenuItem;
        private ToolStripMenuItem expenseRecordToolStripMenuItem;
        private ToolStripMenuItem weatherHistoryToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem userGuideToolStripMenuItem;
        private ContextMenuStrip contextMenuDashboard;
        private Label lblCropManagement;
        private Label lblWeatherMonitoring;
        private Label lblExpenseTracking;
        private ToolStripMenuItem refreshDashboardToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem1;
        private ToolStripMenuItem exitToolStripMenuItem1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel2;
        private Panel panel3;
        private ToolStripMenuItem addCropToolStripMenuItem;
        private ToolStripMenuItem recordExpenseToolStripMenuItem;
        private ToolStripMenuItem weatherEntryToolStripMenuItem;
        private Panel pnlDashboardUpperRight;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox6;
        private PictureBox pictureBox8;
        private PictureBox pictureBox7;
        private Button button1;
        private Label lblManageInventory;
        private Button btnInventory;
        private Button btnSales;
        private Label lblRecordSales;
        private Button button3;
        private Button button2;
        private Button btnUpdateItem;
        private Button btnDeleteItem;
        private Button btnAddItem;
        private Button btnLoadChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart crtfarmSales;
        private DateTimePicker dtpStartDate;

    }
}