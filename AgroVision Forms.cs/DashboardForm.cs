using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using AgroVision_Management_System;
    using System.Windows.Forms.DataVisualization.Charting;

namespace AgroVision_Management_System.AgroVision_Forms.cs
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
            InitializeCustomComponents();
            AttachEventHandlers();
        }
        private void InitializeCustomComponents()
        {
            // File MenuStrip 
            refreshToolStripMenuItem.Click += refreshToolStripMenuItem_Click;
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;

            // Manage MenuStrip
            addCropToolStripMenuItem.Click += addCropToolStripMenuItem_Click;
            recordExpenseToolStripMenuItem.Click += recordExpenseToolStripMenuItem_Click;
            weatherEntryToolStripMenuItem.Click += weatherEntryToolStripMenuItem_Click;

            // Reports MenuStrip
            expenseRecordToolStripMenuItem.Click += expenseRecordToolStripMenuItem_Click;
            weatherHistoryToolStripMenuItem.Click += weatherHistoryToolStripMenuItem_Click;

            // Help MenuStrip
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            userGuideToolStripMenuItem.Click += userGuideToolStripMenuItem_Click;

            // ContextMenuStrip
            this.ContextMenuStrip = contextMenuDashboard;
            refreshDashboardToolStripMenuItem.Click += refreshToolStripMenuItem_Click;
            exitToolStripMenuItem1.Click += exitToolStripMenuItem1_Click;
            logoutToolStripMenuItem1.Click += logoutToolStripMenuItem1_Click;
        }
        private void DashboardForm_Load(object sender, EventArgs e)
        {
        }
        private void AttachEventHandlers()
        {
            // Crop Management Buttons
            btnAddCrop.Click += btnAddCrop_Click;
            btnDeleteCrop.Click += btnDeleteCrop_Click;
            btnUpdateCrop.Click += btnUpdateCrop_Click;

            // Expense Tracking Buttons
            btnRecordExpense.Click += btnRecordExpense_Click;
            btnDeleteExpense.Click += btnDeleteExpense_Click;
            btnGenerateExpenseRecord.Click += btnGenerateExpenseRecord_Click;

            // Weather Monitoring Button
            btnWeatherEntryHistory.Click += btnWeatherEntryHistory_Click;
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Refresh(); // Refreshes the form
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Closes the application
        }
        private void addCropToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCropForm addCropForm = new AddCropForm();
            addCropForm.Show(); // Opens as a separate window
        }
        private void recordExpenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RecordExpenseForm recordExpenseForm = new RecordExpenseForm();
            recordExpenseForm.Show();
        }
        private void weatherEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WeatherTrackerForm weatherEntryForm = new WeatherTrackerForm();
            weatherEntryForm.Show();
        }
        
        private void expenseRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenerateExpenseRecordForm expenseRecordForm = new GenerateExpenseRecordForm();
            expenseRecordForm.Show();
        }
        private void weatherHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WeatherTrackerForm weatherHistoryForm = new WeatherTrackerForm();
            weatherHistoryForm.Show();
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("AgroVision Management System\nVersion 1.0\n© 2025 AgroVision Inc.",
                "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void userGuideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Path\To\UserGuide.pdf");
        }
        private void refreshDashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();  // Clears all controls
            this.InitializeComponent(); // Reinitializes the components
            this.DashboardForm_Load(sender, e); // Reload the form
        }
        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Show confirmation message
            DialogResult result = MessageBox.Show("You have been logged out successfully.", "Logout Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (result == DialogResult.OK)
            {
                // Close DashboardForm first
                this.Hide();
                this.Dispose();

                // Open LoginForm AFTER DashboardForm is fully closed
                LoginForm loginForm = new LoginForm();
                loginForm.ShowDialog(); // Ensures it's the next active window
            }
        }
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Close the application
        }

        // Left Panel Menu
        private void ShowForm(Form form)
        {
            // Clear existing controls before loading a new form
            pnlDashboard.Controls.Clear(); // Use the correct panel name

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            pnlDashboard.Controls.Add(form);
            form.Show();
        }
        private void btnAddCrop_Click(object sender, EventArgs e)
        {
            AddCropForm addCropForm = new AddCropForm();
            addCropForm.Show();
        }
        private void btnDeleteCrop_Click(object sender, EventArgs e)
        {
            DeleteCropForm deleteCropForm = new DeleteCropForm();
            deleteCropForm.Show();
        }
        private void btnUpdateCrop_Click(object sender, EventArgs e)
        {
            UpdateCropForm updateCropForm = new UpdateCropForm();
            updateCropForm.Show();
        }
        
        private void btnRecordExpense_Click(object sender, EventArgs e)
        {
            RecordExpenseForm recordExpenseForm = new RecordExpenseForm();
            recordExpenseForm.Show();
        }
        private void btnDeleteExpense_Click(object sender, EventArgs e)
        {
            DeleteExpenseForm deleteExpenseForm = new DeleteExpenseForm();
            deleteExpenseForm.Show();
        }
        private void btnGenerateExpenseRecord_Click(object sender, EventArgs e)
        {
            GenerateExpenseRecordForm generateExpenseForm = new GenerateExpenseRecordForm();
            generateExpenseForm.Show();
        }
        private void btnWeatherEntryHistory_Click(object sender, EventArgs e)
        {
            WeatherTrackerForm weatherForm = new WeatherTrackerForm();
            weatherForm.Show();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            AddItemForm addItemForm = new AddItemForm();
            addItemForm.FormClosed += AddItemForm_FormClosed;
            addItemForm.Show();
        }
        private void AddItemForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            // Hide the DashboardForm
            this.Hide();

            // Create and show the AddItemForm
            DeleteItemForm deleteItemForm = new DeleteItemForm();
            deleteItemForm.FormClosed += DeleteItemForm_FormClosed;
            deleteItemForm.Show();
        }
        private void DeleteItemForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void btnUpdateItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            UpdateItemForm updateItemForm = new UpdateItemForm();
            updateItemForm.FormClosed += UpdateItemForm_FormClosed;
            updateItemForm.Show();
        }
        private void UpdateItemForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            this.Hide();

            RecordSaleForm recordsaleForm = new RecordSaleForm();
            recordsaleForm.FormClosed += RecordSaleForm_FormClosed;
            recordsaleForm.Show();
        }
        private void RecordSaleForm_FormClosed(object sender, EventArgs e)
        {
            this.Show();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void btnLoadChart_Click(object sender, EventArgs e)
        {
            // Get the selected date from DateTimePicker
            DateTime selectedDate = dtpStartDate.Value.Date;

            // Call function to load chart with sales data
            LoadSalesData(selectedDate);
        }
        private void LoadSalesData(DateTime selectedDate)
        {
            // Clear previous chart data
            crtfarmSales.Series["SalesSeries"].Points.Clear();

            // Call the method from Sales.cs to get the total sales for the selected date
            decimal totalSales = Sales.GetTotalSalesByDate(selectedDate);

            // Add the total sales for the selected date to the chart
            crtfarmSales.Series["SalesSeries"].Points.AddXY(selectedDate.ToShortDateString(), totalSales);
        }
    }
}




