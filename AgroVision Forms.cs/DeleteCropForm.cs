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
    public partial class DeleteCropForm : Form
    {
        private string connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Jafit Love R. Ybanez\Documents\AgriVisionDB.accdb;";

        public DeleteCropForm()
        {
            InitializeComponent();
        }
        private void DeleteCropForm_Load(object sender, EventArgs e)
        {
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT CropID, CropType, CropName, PlantingDate, ExpectedYield FROM Crops";
                    OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dgvDeleteCrop.DataSource = table;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading crops: " + ex.Message);
                }
            }
        }
        private void btnDeleteCrop_Click(object sender, EventArgs e)
        {
            if (dgvDeleteCrop.SelectedRows.Count > 0)
            {
                int selectedCropId = Convert.ToInt32(dgvDeleteCrop.SelectedRows[0].Cells["CropID"].Value);

                DialogResult confirm = MessageBox.Show("Are you sure you want to delete this crop?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    using (OleDbConnection conn = new OleDbConnection(connString))
                    {
                        try
                        {
                            conn.Open();

                            // Delete fertilizer schedules first
                            string deleteFertQuery = "DELETE FROM FertilizerSchedules WHERE CropID = ?";
                            OleDbCommand fertCmd = new OleDbCommand(deleteFertQuery, conn);
                            fertCmd.Parameters.AddWithValue("?", selectedCropId);
                            fertCmd.ExecuteNonQuery();

                            // Then delete the crop
                            string deleteCropQuery = "DELETE FROM Crops WHERE CropID = ?";
                            OleDbCommand cropCmd = new OleDbCommand(deleteCropQuery, conn);
                            cropCmd.Parameters.AddWithValue("?", selectedCropId);
                            cropCmd.ExecuteNonQuery();

                            MessageBox.Show("Crop deleted successfully.");
                            DeleteCropForm_Load(null, null); // Refresh list
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error deleting crop: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a crop to delete.");
            }
        }
        private void lblDeleteCrop_Click(object sender, EventArgs e) { }

        private void tbxCropNametoDelete_TextChanged(object sender, EventArgs e) { }

        private void btnDeleteCropB2D_Click(object sender, EventArgs e)
        {
            DashboardForm dashboard = new DashboardForm();
            dashboard.Show();
            this.Close();
        }
        private void dgvDeleteCrop_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}