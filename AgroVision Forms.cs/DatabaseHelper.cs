using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroVision_Management_System.AgroVision_Forms.cs
{
    public static class DatabaseHelper
    {
        private static string connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Jafit Love R. Ybanez\Documents\AgriVisionDB.accdb;";

        public static List<Crop> GetCrops()
        {
            List<Crop> crops = new List<Crop>();

            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand("SELECT CropID, CropType, CropName, PlantingDate, ExpectedYield FROM Crops", conn);
                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int cropID = Convert.ToInt32(reader["CropID"]);
                    string cropType = reader["CropType"].ToString();
                    string cropName = reader["CropName"].ToString();
                    DateTime plantingDate = Convert.ToDateTime(reader["PlantingDate"]);
                    int expectedYield = Convert.ToInt32(reader["ExpectedYield"]);

                    crops.Add(new Crop(cropID, cropType, cropName, plantingDate, expectedYield));
                }
            }

            return crops;
        }
        public static void AddCrop(Crop crop)
        {
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand("INSERT INTO Crops (CropType, CropName, PlantingDate, ExpectedYield) VALUES (?, ?, ?, ?)", conn);
                cmd.Parameters.AddWithValue("@CropType", crop.CropType);
                cmd.Parameters.AddWithValue("@CropName", crop.CropName);
                cmd.Parameters.AddWithValue("@PlantingDate", crop.PlantingDate);
                cmd.Parameters.AddWithValue("@ExpectedYield", crop.ExpectedYield);
                cmd.ExecuteNonQuery();
            }
        }
        public static void UpdateCrop(Crop crop)
        {
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand("UPDATE Crops SET CropType = ?, CropName = ?, PlantingDate = ?, ExpectedYield = ? WHERE CropID = ?", conn);
                cmd.Parameters.AddWithValue("@CropType", crop.CropType);
                cmd.Parameters.AddWithValue("@CropName", crop.CropName);
                cmd.Parameters.AddWithValue("@PlantingDate", crop.PlantingDate);
                cmd.Parameters.AddWithValue("@ExpectedYield", crop.ExpectedYield);
                cmd.Parameters.AddWithValue("@CropID", crop.CropID);
                cmd.ExecuteNonQuery();
            }
        }
        public static void DeleteCrop(int cropID)
        {
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand("DELETE FROM Crops WHERE CropID = ?", conn);
                cmd.Parameters.AddWithValue("@CropID", cropID);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
