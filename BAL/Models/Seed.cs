using System;

namespace BAL.Models
{
    public class Seed
    {
        public Seed()
        {
            MinSun = 0;
            MaxSun = 0;
            FrostHardy = false;
            PlantSpacing = string.Empty;
            SeedDepth = string.Empty;
            MaxTemperature = 0;
            MinTemperature = 0;
            MinSproutInDays = 0;
            MaxSproutInDays = 0;
            Variety = string.Empty;
            SeedType = string.Empty;
            Manufacturer = string.Empty;
            UserId = 0;
            Id = 0;
            PurchaseDate = DateTime.Now;
        }

        public int MinSun { get; set; }
        public bool FrostHardy { get; set; }
        public string PlantSpacing { get; set; }
        public string SeedDepth { get; set; }
        public int MaxTemperature { get; set; }
        public int MinTemperature { get; set; }
        public int MaxSun { get; set; }
        public int MaxSproutInDays { get; set; }
        public string Variety { get; set; }
        public string SeedType { get; set; }
        public DateTime PurchaseDate { get; set; }
        public string Manufacturer { get; set; }
        public int UserId { get; set; }
        public int Id { get; set; }
        public int MinSproutInDays { get; set; }
        public byte[] ByteImage { get; set; }
    }
}
