using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Diagnostics;

namespace AgroVisionManagementSystem
{
    public class Inventory
    {
        public int InventoryID { get; set; }
        public string ItemName { get; set; }
        public string Category { get; set; }
        public int Quantity { get; set; }
        public string Unit { get; set; }
        public DateTime DateAdded { get; set; }
        public decimal Price { get; set; }

        public static class Database
        {
            private static string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Jafit Love R. Ybanez\Documents\AgriVisionDB.accdb";

            public static OleDbConnection GetConnection()
            {
                return new OleDbConnection(connectionString);
            }
        }
        public Inventory(string itemName, string category, int quantity, string unit, DateTime dateAdded, decimal price)
        {
            ItemName = itemName;
            Category = category;
            Quantity = quantity;
            Unit = unit;
            DateAdded = dateAdded;
            Price = price;
        }
        public Inventory() { }
        public static DataTable GetAllInventory()
        {
            DataTable dt = new DataTable();

            using (OleDbConnection conn = Database.GetConnection())
            {
                string query = "SELECT * FROM Inventory"; 
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    conn.Open();
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }
            }

            return dt;
        }
        public static bool DeleteInventory(int inventoryId)
        {
            try
            {
                using (OleDbConnection conn = Database.GetConnection())
                {
                    string query = "DELETE FROM Inventory WHERE InventoryID = ?";
                    OleDbCommand cmd = new OleDbCommand(query, conn);
                    cmd.Parameters.AddWithValue("?", inventoryId);
                    conn.Open();

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error deleting inventory: " + ex.Message);
                return false;
            }
        }
        public static bool UpdateInventory(Inventory inv)
        {
            using (OleDbConnection conn = Database.GetConnection())
            {
                string query = @"UPDATE Inventory 
                         SET ItemName = ?, Category = ?, Quantity = ?, Unit = ?, Price=? 
                         WHERE InventoryID = ?";

                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("?", inv.ItemName);
                    cmd.Parameters.AddWithValue("?", inv.Category);
                    cmd.Parameters.AddWithValue("?", inv.Quantity);
                    cmd.Parameters.AddWithValue("?", inv.Unit);
                    cmd.Parameters.AddWithValue("?", inv.Price);
                    cmd.Parameters.AddWithValue("?", inv.InventoryID);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                } 
            }
        }
        public static decimal GetItemPrice(int inventoryId)
        {
            using (OleDbConnection conn = Database.GetConnection())
            {
                string query = "SELECT Price FROM Inventory WHERE InventoryID = ?";
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("?", inventoryId);
                    conn.Open();
                    object result = cmd.ExecuteScalar();

                    if (result != null && decimal.TryParse(result.ToString(), out decimal price))
                    {
                        return price;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}