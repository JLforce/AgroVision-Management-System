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
using static AgroVisionManagementSystem.Inventory;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace AgroVision_Management_System.AgroVision_Forms.cs
{
    public partial class RecordSaleForm : Form
    {
        public RecordSaleForm()
        {
            InitializeComponent();
            LoadInventoryItems();
        }
        private void RecordSaleForm_Load(object sender, EventArgs e)
        {
            dtpSaleDate.Value = DateTime.Today;
            LoadInventoryItems();
        }
        private void LoadInventoryItems()
        {
            var items = Inventory.GetAllInventory();
            cmbInventoryItem.DataSource = items;
            cmbInventoryItem.DisplayMember = "ItemName";
            cmbInventoryItem.ValueMember = "InventoryID";
        }
        private void btnSaveSale_Click(object sender, EventArgs e)
        {
            if (cmbInventoryItem.SelectedValue == null || !int.TryParse(txtQuantitySold.Text.Trim(), out int quantity))
            {
                MessageBox.Show("Please select an item and enter a valid quantity.");
                return;
            }

            if (!decimal.TryParse(txtTotalAmount.Text.Trim(), out decimal total))
            {
                MessageBox.Show("Please enter a valid total amount.");
                return;
            }

            int inventoryId = Convert.ToInt32(cmbInventoryItem.SelectedValue);
            DateTime saleDate = dtpSaleDate.Value;

            // Create a new Sale object
            Sales sale = new Sales(inventoryId, quantity, saleDate, total);

            try
            {
                if (Sales.RecordSale(sale))
                {
                    MessageBox.Show("Sale recorded successfully!");
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Failed to record the sale. Please try again.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving sale: " + ex.Message);
            }
        }
        private void ClearFields()
        {
            cmbInventoryItem.SelectedIndex = -1; // Clears selected item
            txtQuantitySold.Clear(); // Clears quantity field
            txtTotalAmount.Clear(); // Clears total amount
            dtpSaleDate.Value = DateTime.Today; // Resets to today's date
        }
        private void btnClear_Click_1(object sender, EventArgs e)
        {
            ClearFields();
        }
        private void cmbInventoryItem_SelectedIndexChanged(object sender, EventArgs e) { }
        
    }
}
