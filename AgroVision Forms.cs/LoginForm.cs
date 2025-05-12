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
using System.Security.Cryptography;
using Microsoft.VisualBasic.ApplicationServices;

namespace AgroVision_Management_System.AgroVision_Forms.cs
{
    public partial class LoginForm : Form
    {
        private bool isLoginSuccessful = false;
        private LoginHandler loginHandler = new LoginHandler();
        public static class PasswordHelper
        {
            public static string HashPassword(string password, string salt)
            {
                using (var sha256 = SHA256.Create())
                {
                    // Combine password and salt and hash them together
                    byte[] passwordBytes = Encoding.UTF8.GetBytes(password + salt);
                    byte[] hashBytes = sha256.ComputeHash(passwordBytes);

                    // Convert hash to base64 string
                    return Convert.ToBase64String(hashBytes);
                }
            }
        }
        private bool ValidateLogin(string enteredPassword, string storedHash, string storedSalt)
        {
            // Hash the entered password with the stored salt
            string enteredHash = PasswordHelper.HashPassword(enteredPassword, storedSalt);

            // Debugging: Show entered hash and stored hash for verification
            MessageBox.Show($"Entered Password: {enteredPassword}\nStored Salt: {storedSalt}\nEntered Hash: {enteredHash}\nStored Hash: {storedHash}");

            // Compare entered hash with stored hash
            return enteredHash == storedHash;
        }
        public LoginForm()
        {
            InitializeComponent();

            // Ensure the password is hidden by default
            tbxPassword.PasswordChar = '●';

            // Attach event handlers
            btnLogin.Click += btnLogin_Click; // Attach event to Login button
            btnExit.Click += btnExit_Click;   // Attach event to Exit button
            cbxShowPassword.CheckedChanged += ChkShowPassword_CheckedChanged;

        }
        private void LoginForm_Load(object sender, EventArgs e) { }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            try
            {
                // Hide the current LoginForm
                this.Hide();

                // Create an instance of the SignUpForm
                SignUpForm signUpForm = new SignUpForm();

                // Show the SignUpForm as a modeless form (non-blocking)
                signUpForm.Show();

                // Optionally, you can show a message when returning back to the LoginForm
                signUpForm.FormClosed += (s, args) =>
                {
                    this.Show();
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbxUsername.Text;
            string enteredPassword = tbxPassword.Text;

            try
            {
                bool isValidLogin = loginHandler.ValidateLogin(username, enteredPassword); // Use LoginHandler to validate login
                if (isValidLogin)
                {
                    if (!isLoginSuccessful)
                    {
                        MessageBox.Show("Login successful!");
                        isLoginSuccessful = true;
                        DashboardForm dashboardForm = new DashboardForm();
                        dashboardForm.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Close the application
        }
        private void ChkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxShowPassword.Checked)
            {
                tbxPassword.PasswordChar = '\0';  // Show actual text
            }
            else
            {
                tbxPassword.PasswordChar = '●';  // Hide password with dots
            }
        }
    }
}