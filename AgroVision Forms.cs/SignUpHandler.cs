using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroVision_Management_System.AgroVision_Forms.cs
{
    public class SignUpHandler
    {
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Jafit Love R. Ybanez\Documents\AgriVisionDB.accdb;";

        public bool RegisterUser(string username, string password, string email)
        {
            string salt = PasswordHelper.GenerateSalt(); // Generate salt for password
            string hashedPassword = PasswordHelper.HashPassword(password, salt); // Hash password with salt

            // Check if the username already exists in the database
            string checkQuery = "SELECT COUNT(*) FROM Users WHERE Username = ?";
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand checkCommand = new OleDbCommand(checkQuery, connection);
                checkCommand.Parameters.AddWithValue("?", username);

                try
                {
                    connection.Open();
                    int userCount = (int)checkCommand.ExecuteScalar();
                    if (userCount > 0)
                    {
                        return false; // Username already exists
                    }

                    // Insert new user into database
                    string insertQuery = "INSERT INTO Users (Username, PasswordHash, Salt, Email) VALUES (?, ?, ?, ?)";
                    OleDbCommand insertCommand = new OleDbCommand(insertQuery, connection);
                    insertCommand.Parameters.AddWithValue("?", username);
                    insertCommand.Parameters.AddWithValue("?", hashedPassword);
                    insertCommand.Parameters.AddWithValue("?", salt);
                    insertCommand.Parameters.AddWithValue("?", email);

                    insertCommand.ExecuteNonQuery();
                    return true; // User registered successfully
                }
                catch (Exception ex)
                {
                    throw new Exception("Error during user registration: " + ex.Message);
                }
            }
        }
    }
}
