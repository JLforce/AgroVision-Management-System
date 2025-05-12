using AgroVisionManagementSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgroVision_Management_System.AgroVision_Forms.cs
{
    public partial class DeleteItemForm : Form
    {
        public DeleteItemForm()
        {
            InitializeComponent();
        }
        private void LoadInventoryData()
        {
            dgvDeleteInventory.DataSource = null;
            dgvDeleteInventory.DataSource = Inventory.GetAllInventory();
        }

        // Delete selected inventory item
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvDeleteInventory.SelectedRows.Count > 0)
            {
                int inventoryId = Convert.ToInt32(dgvDeleteInventory.SelectedRows[0].Cells["InventoryID"].Value);

                bool result = Inventory.DeleteInventory(inventoryId);

                if (result)
                {
                    MessageBox.Show("Inventory item deleted successfully.");
                    dgvDeleteInventory.DataSource = Inventory.GetAllInventory(); // Refresh table
                }
                else
                {
                    MessageBox.Show("Failed to delete inventory item.");
                }
            }
            else
            {
                MessageBox.Show("Please select an item to delete.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvDeleteInventory_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void DeleteItemForm_Load_1(object sender, EventArgs e)
        {
            LoadInventoryData();
        }
    }
}
