using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroVision_Management_System.AgroVision_Forms.cs
{
    public class Expense
    {
        public int ExpenseID { get; set; }
        public string ExpenseItem { get; set; }
        public double ExpenseAmount { get; set; }

        public Expense(int expenseID, string expenseItem, double expenseAmount)
        {
            ExpenseID = expenseID;
            ExpenseItem = expenseItem;
            ExpenseAmount = expenseAmount;
        }
        public bool Save()
        {
            using (OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Jafit Love R. Ybanez\Documents\AgriVisionDB.accdb;"))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Expenses (ExpenseItem, ExpenseAmount) VALUES (?, ?)";
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("?", ExpenseItem);
                        cmd.Parameters.AddWithValue("?", ExpenseAmount);
                        cmd.ExecuteNonQuery();
                    }
                    return true; // Return true if save is successful
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false; // Return false if an error occurs
                }
            }
        }

        public static bool Delete(int expenseID)
        {
            using (OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Jafit Love R. Ybanez\Documents\AgriVisionDB.accdb;"))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM Expenses WHERE ExpenseID = ?";
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("?", expenseID);
                        cmd.ExecuteNonQuery();
                    }
                    return true; // Return true if delete is successful
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting expense: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false; // Return false if an error occurs
                }
            }
        }
        public static List<Expense> GetAllExpenses()
        {
            List<Expense> expenses = new List<Expense>();

            using (OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Jafit Love R. Ybanez\Documents\AgriVisionDB.accdb;"))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT ExpenseID, ExpenseItem, ExpenseAmount FROM Expenses";
                    OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    foreach (DataRow row in table.Rows)
                    {
                        expenses.Add(new Expense(
                            Convert.ToInt32(row["ExpenseID"]),
                            row["ExpenseItem"].ToString(),
                            Convert.ToDouble(row["ExpenseAmount"])
                        ));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading expenses: " + ex.Message);
                }
            }
            return expenses;
        }

    }
}
