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
    public partial class DeleteExpenseForm : Form
    {
        private string connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Jafit Love R. Ybanez\Documents\AgriVisionDB.accdb;";
        public DeleteExpenseForm()
        {
            InitializeComponent();
        }
        private void btnDeleteExpenseB2D_Click(object sender, EventArgs e)
        {
            DashboardForm dashboard = new DashboardForm();
            dashboard.Show();
            this.Close();
        }
        private void dgvExpenseRecord_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void DeleteExpenseForm_Load(object sender, EventArgs e)
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

                    if (table.Rows.Count == 0)
                    {
                        MessageBox.Show("No records found in the Expenses table.");
                    }
                    else
                    {
                        dgvExpenseRecord.DataSource = table;
                        dgvExpenseRecord.Refresh(); // Force refresh
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading expenses: " + ex.Message);
                }
            }
        }
        private void btnDeleteExpense_Click(object sender, EventArgs e)
        {
            if (dgvExpenseRecord.SelectedRows.Count > 0)
            {
                int selectedExpenseId = Convert.ToInt32(dgvExpenseRecord.SelectedRows[0].Cells["ExpenseID"].Value);

                DialogResult confirm = MessageBox.Show("Are you sure you want to delete this expense?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    bool result = Expense.Delete(selectedExpenseId);
                    if (result)
                    {
                        MessageBox.Show("Expense deleted successfully.");
                        DeleteExpenseForm_Load(null, null); // Refresh list
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete expense.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an expense to delete.");
            }
        }

        private void btnCancelExpenseDelete_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
