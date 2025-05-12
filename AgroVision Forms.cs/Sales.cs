using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using static AgroVisionManagementSystem.Inventory;

namespace AgroVision_Management_System
{
    public class Sales
    {
        public int InventoryID { get; set; }
        public int QuantitySold { get; set; }
        public DateTime SaleDate { get; set; }
        public decimal TotalAmount { get; set; }

        public Sales(int inventoryID, int quantitySold, DateTime saleDate, decimal totalAmount)
        {
            InventoryID = inventoryID;
            QuantitySold = quantitySold;
            SaleDate = saleDate;
            TotalAmount = totalAmount;
        }

        public static bool RecordSale(Sales sale)
        {
            try
            {
                string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Jafit Love R. Ybanez\\Documents\\AgriVisionDB.accdb";

                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO Sales (InventoryID, QuantitySold, SaleDate, TotalAmount) VALUES (?, ?, ?, ?)";
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("?", sale.InventoryID);
                        cmd.Parameters.AddWithValue("?", sale.QuantitySold);
                        cmd.Parameters.AddWithValue("?", sale.SaleDate);
                        cmd.Parameters.AddWithValue("?", sale.TotalAmount);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any errors that occur during the database operation
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }
        public static decimal GetTotalSalesByDate(DateTime saleDate)
        {
            decimal totalSales = 0;

            try
            {
                string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Jafit Love R. Ybanez\\Documents\\AgriVisionDB.accdb";

                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT SUM(TotalAmount) AS TotalSales FROM Sales WHERE SaleDate = ?";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        // Add the saleDate parameter
                        cmd.Parameters.AddWithValue("?", saleDate.Date);

                        // Execute the query and get the result
                        object result = cmd.ExecuteScalar();

                        // If result is not null, parse the result to a decimal
                        if (result != DBNull.Value)
                        {
                            totalSales = Convert.ToDecimal(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any errors that occur during the database operation
                MessageBox.Show("Error: " + ex.Message);
            }

            return totalSales;
        }
    }
}

