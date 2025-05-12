using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroVision_Management_System.AgroVision_Forms.cs
{
    public class Crop
    {
        public int CropID { get; set; }
        public string CropType { get; set; }
        public string CropName { get; set; }
        public DateTime PlantingDate { get; set; }
        public int ExpectedYield { get; set; }

        public Crop(int cropID, string cropType, string cropName, DateTime plantingDate, int expectedYield)
        {
            CropID = cropID;
            CropType = cropType;
            CropName = cropName;
            PlantingDate = plantingDate;
            ExpectedYield = expectedYield;
        }

        public string ToFormattedString(int cropIDWidth, int cropTypeWidth, int cropNameWidth, int plantingDateWidth, int expectedYieldWidth)
        {
            return string.Format("{0,-" + cropIDWidth + "} {1,-" + cropTypeWidth + "} {2,-" + cropNameWidth + "} {3,-" + plantingDateWidth + "} {4,-" + expectedYieldWidth + "}",
                CropID, CropType, CropName, PlantingDate.ToString("yyyy-MM-dd"), ExpectedYield);
        }
    }
}
