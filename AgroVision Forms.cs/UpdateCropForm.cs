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
    public partial class UpdateCropForm : Form
    {
        string connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Jafit Love R. Ybanez\Documents\AgriVisionDB.accdb;";
        int selectedCropID = -1;

        public UpdateCropForm()
        {
            InitializeComponent();
        }
        private void btnUpdateCropB2D_Click(object sender, EventArgs e)
        {
            DashboardForm dashboard = new DashboardForm();
            dashboard.Show();
            this.Close();
        }

        private void UpdateCropForm_Load(object sender, EventArgs e)
        {
        }

        private void LoadCropDetails(string cropName)
        {

        }
        private void LoadFertilizerDates()
        {
            ListofFertilizerSchedule.Items.Clear();

            if (selectedCropID == -1) return;

            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand("SELECT FertilizerDate FROM FertilizerSchedules WHERE CropID = @id", conn);
                cmd.Parameters.AddWithValue("@id", selectedCropID);

                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ListofFertilizerSchedule.Items.Add(Convert.ToDateTime(reader["FertilizerDate"]).ToShortDateString());
                }
            }
        }

        private void btnUpdateSelectedFertilizerDate_Click(object sender, EventArgs e)
        {
            string cropName = tbxCropNametoUpdate.Text.Trim();
            DateTime newPlantingDate = dtpPlantingDatetoUpdate.Value;
            int newExpectedYield;

            if (string.IsNullOrEmpty(cropName) || !int.TryParse(tbxExpectedYieldtoUpdate.Text, out newExpectedYield))
            {
                MessageBox.Show("Please provide valid crop name and expected yield.");
                return;
            }

            try
            {
                using (OleDbConnection conn = new OleDbConnection(connString))
                {
                    conn.Open();

                    // Get CropID by CropName
                    OleDbCommand getIDCmd = new OleDbCommand("SELECT CropID FROM Crops WHERE CropName = @name", conn);
                    getIDCmd.Parameters.Add("@name", OleDbType.VarWChar).Value = cropName;
                    object result = getIDCmd.ExecuteScalar();

                    if (result == null)
                    {
                        MessageBox.Show("Crop not found.");
                        return;
                    }

                    selectedCropID = Convert.ToInt32(result);

                    // Update Crop info
                    OleDbCommand updateCmd = new OleDbCommand("UPDATE Crops SET PlantingDate = @plantingDate, ExpectedYield = @yield WHERE CropID = @id", conn);
                    updateCmd.Parameters.Add("@plantingDate", OleDbType.Date).Value = newPlantingDate;
                    updateCmd.Parameters.Add("@yield", OleDbType.Integer).Value = newExpectedYield;
                    updateCmd.Parameters.Add("@id", OleDbType.Integer).Value = selectedCropID;

                    int rowsAffected = updateCmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Crop updated successfully!");
                    }
                    else
                    {
                        MessageBox.Show("No rows were updated. Please check if the CropID exists.");
                    }

                    LoadFertilizerDates();
                }
            }
            catch (OleDbException oleDbEx)
            {
                MessageBox.Show("Database error: " + oleDbEx.Message);
                // Log the error for debugging purposes
                Console.WriteLine("Database error: " + oleDbEx.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
                // Log the error for debugging purposes
                Console.WriteLine("General error: " + ex.ToString());
            }
        }

        private void dtpFertilizerDatetoUpdate_ValueChanged(object sender, EventArgs e) { }

        private void btnEditDate_Click(object sender, EventArgs e)
        {
            if (ListofFertilizerSchedule.SelectedItem == null)
            {
                MessageBox.Show("Select a fertilizer date to edit.");
                return;
            }

            DateTime oldDate = Convert.ToDateTime(ListofFertilizerSchedule.SelectedItem);
            DateTime newDate = dtpFertilizerDatetoUpdate.Value;

            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                try
                {
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand("UPDATE FertilizerSchedules SET FertilizerDate = ? WHERE CropID = ? AND FertilizerDate = ?", conn);

                    // Adding parameters using the correct order
                    cmd.Parameters.Add("?", OleDbType.Date).Value = newDate; // Position 1: newDate
                    cmd.Parameters.Add("?", OleDbType.Integer).Value = selectedCropID; // Position 2: CropID
                    cmd.Parameters.Add("?", OleDbType.Date).Value = oldDate; // Position 3: oldDate

                    int rows = cmd.ExecuteNonQuery();

                    MessageBox.Show(rows > 0 ? "Fertilizer date updated!" : "No matching date found.");
                    LoadFertilizerDates();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating fertilizer date: " + ex.Message);
                }
            }
        }
        private void ListofFertilizerSchedule_SelectedIndexChanged(object sender, EventArgs r) { }


        private void btnDeleteDate_Click_1(object sender, EventArgs e)
        {
            if (ListofFertilizerSchedule.SelectedItem == null)
            {
                MessageBox.Show("Please select a fertilizer date to delete.");
                return;
            }

            if (selectedCropID == -1)
            {
                MessageBox.Show("No crop selected. Cannot delete fertilizer date.");
                return;
            }

            DateTime selectedDate;
            if (!DateTime.TryParse(ListofFertilizerSchedule.SelectedItem.ToString(), out selectedDate))
            {
                MessageBox.Show("Invalid date format.");
                return;
            }

            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                try
                {
                    conn.Open();

                    string query = "DELETE FROM FertilizerSchedules WHERE CropID = ? AND Format(FertilizerDate, 'Short Date') = Format(?, 'Short Date')";
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.Add("?", OleDbType.Integer).Value = selectedCropID;
                        cmd.Parameters.Add("?", OleDbType.Date).Value = selectedDate;

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Fertilizer date deleted successfully.");
                            LoadFertilizerDates();
                        }
                        else
                        {
                            MessageBox.Show("No matching fertilizer date found to delete.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting fertilizer date:\n" + ex.Message);
                }
            }
        }
    }
}