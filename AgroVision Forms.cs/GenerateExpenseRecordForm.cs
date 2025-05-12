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
    public partial class GenerateExpenseRecordForm : Form
    {
        private string connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Jafit Love R. Ybanez\Documents\AgriVisionDB.accdb;";

        public GenerateExpenseRecordForm()
        {
            InitializeComponent();
        }

        private void btnExpenseReportB2D_Click(object sender, EventArgs e)
        {
            DashboardForm dashboard = new DashboardForm();
            dashboard.Show();
            this.Close();
        }

        private void dgvListofExpenses_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void GenerateExpenseRecordForm_Load(object sender, EventArgs e)
        {
            List<Expense> expenses = Expense.GetAllExpenses();
            dgvListofExpenses.DataSource = expenses;
        }

        private void btnGenerateExpenseReport_Click(object sender, EventArgs e)
        {
            StringBuilder reportContent = new StringBuilder();

            // Add report headers
            reportContent.AppendLine("Expense Report");
            reportContent.AppendLine(new string('-', 80));
            reportContent.AppendLine("ExpenseID   ExpenseItem  ExpenseAmount");
            reportContent.AppendLine(new string('-', 80));

            // Loop through the DataGridView rows and append data to the report
            foreach (DataGridViewRow row in dgvListofExpenses.Rows)
            {
                if (!row.IsNewRow) // Skip the new row at the bottom
                {
                    string expenseID = row.Cells["ExpenseID"].Value.ToString();
                    string expenseItem = row.Cells["ExpenseItem"].Value.ToString();
                    string expenseAmount = row.Cells["ExpenseAmount"].Value.ToString();

                    // Format the row for the report
                    reportContent.AppendLine(FormatLine(expenseID, expenseItem, expenseAmount, 20, 20, 20));
                }
            }

            // Display the report content (You can modify this part to save the report to a file)
            MessageBox.Show(reportContent.ToString());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private string FormatLine(string expenseID, string expenseItem, string expenseAmount,
            int expenseIDWidth, int expenseItemWidth, int expenseAmountWidth)
        {
            return string.Format("{0,-" + expenseIDWidth + "} {1,-" + expenseItemWidth + "} {2,-" + expenseAmountWidth + "}",
                expenseID.PadRight(expenseIDWidth), expenseItem.PadRight(expenseItemWidth), expenseAmount.PadRight(expenseAmountWidth));
        }
        private void LoadExpenseData()
        {
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT ExpenseID, ExpenseItem, ExpenseAmount FROM Expenses";
                    OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    // Bind the DataTable to the DataGridView
                    dgvListofExpenses.DataSource = table;

                    // Optionally adjust the columns width for better readability
                    dgvListofExpenses.Columns["ExpenseID"].Width = 100;
                    dgvListofExpenses.Columns["ExpenseItem"].Width = 200;
                    dgvListofExpenses.Columns["ExpenseAmount"].Width = 150;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading expenses: " + ex.Message);
                }
            }
        }
    }
}
