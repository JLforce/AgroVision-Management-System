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

namespace AgroVision_Management_System.AgroVision_Forms.cs
{
    public partial class AddCropForm : Form
    {
        private string connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Jafit Love R. Ybanez\Documents\AgriVisionDB.accdb;";
        public AddCropForm()
        {
            InitializeComponent();
        }
        private void lblCropType_Click(object sender, EventArgs e) { }
        private void lblPlantingDate_Click(object sender, EventArgs e) { }

        private void lblCropName_Click(object sender, EventArgs e) { }

        private void btnAddFertilizerDate_Click(object sender, EventArgs e)
        {
            string selectedDate = dtpFertilizerDate.Value.ToString("dd/MM/yyyy");

            if (!lbxFertilizerDates.Items.Contains(selectedDate))
            {
                lbxFertilizerDates.Items.Add(selectedDate);
            }
            else
            {
                MessageBox.Show("This date is already added.");
            }
        }

        private void btnSaveCrops_Click(object sender, EventArgs e)
        {
            string cropType = cmbCropType.Text;
            string cropName = tbxCropName.Text;
            DateTime plantingDate = dtpPlantingDate.Value;
            double expectedYield;

            if (string.IsNullOrWhiteSpace(cropType) || string.IsNullOrWhiteSpace(cropName) || !double.TryParse(tbxExpectedYield.Text, out expectedYield))
            {
                MessageBox.Show("Please fill all fields with valid data.");
                return;
            }

            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                try
                {
                    conn.Open();

                    // Insert crop with explicit types
                    string cropQuery = "INSERT INTO Crops (CropType, CropName, PlantingDate, ExpectedYield) VALUES (?, ?, ?, ?)";
                    OleDbCommand cropCmd = new OleDbCommand(cropQuery, conn);
                    cropCmd.Parameters.Add("?", OleDbType.VarChar).Value = cropType;
                    cropCmd.Parameters.Add("?", OleDbType.VarChar).Value = cropName;
                    cropCmd.Parameters.Add("?", OleDbType.Date).Value = plantingDate;
                    cropCmd.Parameters.Add("?", OleDbType.Double).Value = expectedYield;
                    cropCmd.ExecuteNonQuery();

                    // Get inserted Crop ID
                    OleDbCommand getIdCmd = new OleDbCommand("SELECT @@IDENTITY", conn);
                    int cropID = Convert.ToInt32(getIdCmd.ExecuteScalar());

                    // Insert fertilizer dates
                    foreach (string dateStr in lbxFertilizerDates.Items)
                    {
                        DateTime fertDate = DateTime.ParseExact(dateStr, "dd/MM/yyyy", null);
                        string fertQuery = "INSERT INTO FertilizerSchedules (CropID, FertilizerDate) VALUES (?, ?)";
                        OleDbCommand fertCmd = new OleDbCommand(fertQuery, conn);
                        fertCmd.Parameters.Add("?", OleDbType.Integer).Value = cropID;
                        fertCmd.Parameters.Add("?", OleDbType.Date).Value = fertDate;
                        fertCmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Crop saved successfully!");
                    this.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving data: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        private void btnAddCropB2D_Click(object sender, EventArgs e)
        {
            DashboardForm dashboard = new DashboardForm();
            dashboard.Show();
            this.Close();
        }
        private void AddCropForm_Load(object sender, EventArgs e) { }

    }
}