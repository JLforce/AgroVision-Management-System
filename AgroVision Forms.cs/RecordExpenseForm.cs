using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgroVision_Management_System.AgroVision_Forms.cs
{
    public partial class RecordExpenseForm : Form
    {
        private string connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Jafit Love R. Ybanez\Documents\AgriVisionDB.accdb;";
        public RecordExpenseForm()
        {
            InitializeComponent();
        }
        private void panel1_Paint(object sender, PaintEventArgs e) { }

        private void btnRecordExpenseB2D_Click(object sender, EventArgs e)
        {
            DashboardForm dashboard = new DashboardForm();
            dashboard.Show();
            this.Close();
        }
        private void RecordExpenseForm_Load(object sender, EventArgs e) { }
        private void btnSaveExpense_Click(object sender, EventArgs e)
        {
            string item = tbxExpenseItem.Text.Trim();
            string amountText = tbxExpenseAmount.Text.Trim();
            double amount;

            if (string.IsNullOrWhiteSpace(item) || !double.TryParse(amountText, out amount))
            {
                MessageBox.Show("Please enter a valid item and numeric amount.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Create a new Expense object
            Expense expense = new Expense(0, item, amount); // 0 for ExpenseID, as it will be auto-generated in the DB
            bool result = expense.Save();

            if (result)
            {
                MessageBox.Show("Expense saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbxExpenseItem.Clear();
                tbxExpenseAmount.Clear();
            }
            else
            {
                MessageBox.Show("Failed to save expense.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCancelExpenseSave_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
