using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroVision_Management_System.AgroVision_Forms.cs
{
    public class LoginHandler
    {
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Jafit Love R. Ybanez\Documents\AgriVisionDB.accdb;";

        public bool ValidateLogin(string username, string enteredPassword)
        {
            string query = "SELECT PasswordHash, Salt FROM Users WHERE Username = ?";
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("?", username);

                try
                {
                    connection.Open();
                    OleDbDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        string storedHash = reader["PasswordHash"].ToString();
                        string storedSalt = reader["Salt"].ToString();

                        string enteredHash = PasswordHelper.HashPassword(enteredPassword, storedSalt);
                        return enteredHash == storedHash; // Check if the password matches
                    }
                    return false;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error during login validation: " + ex.Message);
                }
            }
        }
    }
}