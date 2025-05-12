using AgroVisionManagementSystem;
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
    public partial class AddItemForm : Form
    {
        private string connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Jafit Love R. Ybanez\Documents\AgriVisionDB.accdb";

        public AddItemForm()
        {
            InitializeComponent();
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            // Validate the inputs
            if (string.IsNullOrEmpty(txtItemName.Text) ||
                string.IsNullOrEmpty(txtQuantity.Text) ||
                string.IsNullOrEmpty(txtUnit.Text) ||
                string.IsNullOrEmpty(txtPrice.Text) ||
                cmbCategory.SelectedItem == null)
            {
                MessageBox.Show("Please fill in all fields, including Price.");
                return;
            }
            if (!int.TryParse(txtQuantity.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Please enter a valid positive quantity.");
                return;
            }
            if (!decimal.TryParse(txtPrice.Text, out decimal price) || price < 0)
            {
                MessageBox.Show("Please enter a valid price.");
                return;
            }

            try
            {
                Inventory newItem = new Inventory(
                    txtItemName.Text.Trim(),
                    cmbCategory.SelectedItem.ToString(),
                    quantity,
                    txtUnit.Text.Trim(),
                    dtpDateAdded.Value,
                    price
                );

                AddItemToDatabase(newItem);
                LoadItems();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private void AddItemToDatabase(Inventory item)
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connString))
                {
                    string query = "INSERT INTO Inventory (ItemName, Category, Quantity, Unit, [Date Added], Price) " +
                                   "VALUES (?, ?, ?, ?, ?, ?)";

                    OleDbCommand cmd = new OleDbCommand(query, conn);
                    cmd.Parameters.AddWithValue("?", item.ItemName);
                    cmd.Parameters.AddWithValue("?", item.Category);
                    cmd.Parameters.AddWithValue("?", item.Quantity);
                    cmd.Parameters.AddWithValue("?", item.Unit);
                    cmd.Parameters.AddWithValue("?", item.DateAdded);
                    cmd.Parameters.AddWithValue("?", item.Price);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Item added successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding item: {ex.Message}");
            }
        }

        // Load the items from the database into the DataGridView
        private void LoadItems()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connString))
                {
                    string query = "SELECT * FROM Inventory";
                    OleDbDataAdapter da = new OleDbDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading items: {ex.Message}");
            }
        }

        // Method to clear input fields
        private void ClearFields()
        {
            txtItemName.Clear();
            txtQuantity.Clear();
            txtUnit.Clear();
            txtPrice.Clear();
            cmbCategory.SelectedIndex = -1;
            dtpDateAdded.Value = DateTime.Now;
        }
        private void AddItemForm_Load(object sender, EventArgs e)
        {
            LoadItems();
        }
        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && ((sender as TextBox).Text.Contains(".")))
            {
                e.Handled = true;
            }
        }
        private void txtPrice_TextChanged(object sender, EventArgs e) { }

    }
}
