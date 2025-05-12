using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AgroVision_Management_System.AgroVision_Forms.cs.LoginForm;

namespace AgroVision_Management_System.AgroVision_Forms.cs
{
    public partial class SignUpForm : Form
    {
        private SignUpHandler signUpHandler = new SignUpHandler();
        
        public SignUpForm()
        {
            InitializeComponent();
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string username = tbxUsernameSignup.Text;
            string password = tbxPasswordSignup.Text;
            string email = tbxEmail.Text;

            try
            {
                bool isRegistered = signUpHandler.RegisterUser(username, password, email); // Use SignUpHandler to register user
                if (isRegistered)
                {
                    MessageBox.Show("User registered successfully!");
                    this.Close(); // Close the SignUp form after successful registration
                }
                else
                {
                    MessageBox.Show("Username already exists. Please choose a different username.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private void SignUpForm_Load(object sender, EventArgs e) { }
    }
}
