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
    public partial class WeatherTrackerForm : Form
    {
        private string connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Jafit Love R. Ybanez\Documents\AgriVisionDB.accdb;";

        public WeatherTrackerForm()
        {
            InitializeComponent();
        }

        private void WeatherTrackerForm_Load(object sender, EventArgs e)
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connString))
                {
                    conn.Open();
                    string query = "SELECT * FROM WeatherHistory";
                    OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dgvWeatherHistory.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading weather history: " + ex.Message);
            }
        }

        private void btnWeatherTrackerB2D_Click(object sender, EventArgs e)
        {
            DashboardForm dashboard = new DashboardForm();
            dashboard.Show();
            this.Close();
        }

        private void dtpWeatherEntry_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tbxTemperature_TextChanged(object sender, EventArgs e)
        {
        }

        private void tbxHumidity_TextChanged(object sender, EventArgs e)
        {
        }
        private void cbmWeatherCondition_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void btnSaveWeatherRecord_Click(object sender, EventArgs e)
        {
            if (dtpWeatherEntry.Value == null ||
        string.IsNullOrWhiteSpace(tbxTemperature.Text) ||
        string.IsNullOrWhiteSpace(tbxHumidity.Text) ||
        cbmWeatherCondition.SelectedItem == null)
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            // Parse Temperature
            if (!double.TryParse(tbxTemperature.Text, out double temperature))
            {
                MessageBox.Show("Invalid Temperature value. Please enter a numeric value.");
                return;
            }

            // Parse Humidity
            if (!double.TryParse(tbxHumidity.Text, out double humidity))
            {
                MessageBox.Show("Invalid Humidity value. Please enter a numeric value.");
                return;
            }

            // Retrieve WeatherCondition
            string weatherCondition = cbmWeatherCondition.SelectedItem.ToString();

            // Retrieve WeatherDate
            DateTime weatherDate = dtpWeatherEntry.Value;

            try
            {
                using (OleDbConnection conn = new OleDbConnection(connString))
                {
                    conn.Open();

                    // SQL query with placeholders
                    string query = "INSERT INTO WeatherHistory (WeatherDate, Temperature, Humidity, WeatherCondition) VALUES (?, ?, ?, ?)";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        // Add parameters with explicit data types
                        cmd.Parameters.Add("?", OleDbType.Date).Value = weatherDate;
                        cmd.Parameters.Add("?", OleDbType.Double).Value = temperature;
                        cmd.Parameters.Add("?", OleDbType.Double).Value = humidity;
                        cmd.Parameters.Add("?", OleDbType.VarWChar).Value = weatherCondition;

                        // Execute the command
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Weather record saved successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving weather record: " + ex.Message);
            }
        }

        private void dgvWeatherHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle any actions when a cell in the DataGridView is clicked
        }

        private void lblWeatherHistory_Click(object sender, EventArgs e)
        {

        }
    }
}
