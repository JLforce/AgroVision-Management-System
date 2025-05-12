using AgroVisionManagementSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Quic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgroVision_Management_System.AgroVision_Forms.cs
{
    public partial class UpdateItemForm : Form
    {
        private int selectedInventoryId = -1;
        public UpdateItemForm()
        {
            InitializeComponent();
            dgvInventory.CellContentClick += dgvInventory_CellContentClick;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedInventoryId != -1)
            {
                Inventory item = new Inventory
                {
                    InventoryID = selectedInventoryId,
                    ItemName = txtItemName.Text,
                    Category = cmbCategory.Text,
                    Price = decimal.TryParse(txtPrice.Text, out decimal price) ? price : 0m,
                    Quantity = int.TryParse(txtQuantity.Text, out int qty) ? qty : 0,
                    Unit = txtUnit.Text,

                };

                bool result = Inventory.UpdateInventory(item);

                if (result)
                {
                    MessageBox.Show("Item updated successfully.");
                    LoadInventoryData();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Failed to update item.");
                }
            }
            else
            {
                MessageBox.Show("Please select an item to update.");
            }
        }

        private void UpdateItemForm_Load(object sender, EventArgs e)
        {
            LoadInventoryData();
        }
        private void LoadInventoryData()
        {
            dgvInventory.DataSource = null;
            dgvInventory.DataSource = Inventory.GetAllInventory();
        }

        private void dgvInventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvInventory.Rows[e.RowIndex];

                selectedInventoryId = Convert.ToInt32(row.Cells["InventoryID"].Value);
                txtItemName.Text = row.Cells["ItemName"].Value.ToString();
                cmbCategory.Text = row.Cells["Category"].Value.ToString();
                txtQuantity.Text = row.Cells["Quantity"].Value.ToString();
                txtUnit.Text = row.Cells["Unit"].Value.ToString();
                txtPrice.Text = row.Cells["Price"].Value.ToString();
            }
        }
        private void ClearFields()
        {
            txtItemName.Clear();
            cmbCategory.SelectedIndex = -1;
            txtQuantity.Clear();
            txtUnit.Clear();
            txtPrice.Clear();
            selectedInventoryId = -1;
        }
        private void txtPrice_TextChanged(object sender, EventArgs e) { }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
