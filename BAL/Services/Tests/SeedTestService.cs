using BAL.Models;
using BAL.Services.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BAL.Services
{
    public class SeedTestService : ISeedService
    {
        private IList<Seed> _seeds;
        FatHead.Services.Interfaces.IDatabaseService _databaseService;
        FatHead.Converters.Interfaces.IDataConverter _dataConverter;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="databaseService">FatHead.Services.Interfaces.IDatabaseService</param>
        /// <param name="dataConverter">FatHead.Converters.Interfaces.IDataConverter</param>
        public SeedTestService(FatHead.Services.Interfaces.IDatabaseService databaseService, FatHead.Converters.Interfaces.IDataConverter dataConverter)
        {
            _seeds = new List<Seed>();

            _databaseService = databaseService;
            _dataConverter = dataConverter;
        }

        /// <summary>
        /// Delete
        /// </summary>
        /// <param name="seedType">BAL.Models.Seed</param>
        /// <returns>int number of records affected</returns>
        public Task<int> Delete(Seed seedType)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get
        /// </summary>
        /// <param name="seed">BAL.Models.Seed</param>
        /// <returns>BAL.Models.SeedType</returns>
        public Task<SeedType> Get(Seed seed)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get List of Seeds by type
        /// </summary>
        /// <returns>IList of Seeds</returns>
        public async Task<IList<Seed>> GetList(string seedType)
        {
            if (_seeds.Count == 0)
            {
                IList<SeedDatabase> seedDatabases = await LoadDefaultSeeds();

                seedDatabases = seedDatabases.Where(x => x.SeedType == seedType).ToList();

                foreach (SeedDatabase sd in seedDatabases)
                {
                    Seed seed = new Seed();

                    _dataConverter.ConvertModelFromModel(sd, seed);

                    _seeds.Add(seed);
                }
            }

            return _seeds;
        }

        /// <summary>
        /// Post
        /// </summary>
        /// <param name="seedType">BAL.Models.Seed</param>
        /// <returns>int number of records affected</returns>
        public Task<int> Post(Seed seedType)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Put
        /// </summary>
        /// <param name="seedType">BAL.Models.Seed</param>
        /// <returns>int number of records affected</returns>
        public Task<int> Put(Seed seedType)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// LoadDefaultSeedTypes
        /// </summary>
        /// <returns>IList of SeedDatabase</returns>
        private async Task<IList<SeedDatabase>> LoadDefaultSeeds()
        {
            IList<SeedDatabase> temp = new List<SeedDatabase>();
            SeedDatabase SeedDatabase = new SeedDatabase();

            await Task.Run(() =>
            {
                temp.Add(
                    new SeedDatabase()
                    {
                        SeedType = "Tomato",
                        Variety = "Roma",
                        Manufacturer = "Baker Creek",
                        MinSproutInDays = 7,
                        MaxSproutInDays = 14,
                        MinTemperature = 50,
                        MaxTemperature = 90,
                        MinSun = 4,
                        MaxSun = 8,
                        FrostHardy = false,
                        PurchaseDate = DateTime.Now,
                        SeedDepth = "1 inch",
                        PlantSpacing = "12 inches"
                    });

                temp.Add(
                    new SeedDatabase()
                    {
                        SeedType = "Tomato",
                        Variety = "Cherry",
                        Manufacturer = "Baker Creek",
                        MinSproutInDays = 7,
                        MaxSproutInDays = 14,
                        MinTemperature = 50,
                        MaxTemperature = 90,
                        MinSun = 4,
                        MaxSun = 8,
                        FrostHardy = false,
                        PurchaseDate = DateTime.Now,
                        SeedDepth = "1 inch",
                        PlantSpacing = "12 inches"
                    });

                temp.Add(
                    new SeedDatabase()
                    {
                        SeedType = "Tomato",
                        Variety = "Big Boy",
                        Manufacturer = "Baker Creek",
                        MinSproutInDays = 7,
                        MaxSproutInDays = 14,
                        MinTemperature = 50,
                        MaxTemperature = 90,
                        MinSun = 4,
                        MaxSun = 8,
                        FrostHardy = false,
                        PurchaseDate = DateTime.Now,
                        SeedDepth = "1 inch",
                        PlantSpacing = "12 inches"
                    });

                temp.Add(
                    new SeedDatabase()
                    {
                        SeedType = "Pumpkin",
                        Variety = "Sugar",
                        Manufacturer = "Baker Creek",
                        MinSproutInDays = 7,
                        MaxSproutInDays = 14,
                        MinTemperature = 50,
                        MaxTemperature = 90,
                        MinSun = 4,
                        MaxSun = 8,
                        FrostHardy = false,
                        PurchaseDate = DateTime.Now,
                        SeedDepth = "1 inch",
                        PlantSpacing = "12 inches"
                    });

                temp.Add(
                    new SeedDatabase()
                    {
                        SeedType = "Pepper",
                        Variety = "Jalapeno",
                        Manufacturer = "Baker Creek",
                        MinSproutInDays = 7,
                        MaxSproutInDays = 14,
                        MinTemperature = 50,
                        MaxTemperature = 90,
                        MinSun = 4,
                        MaxSun = 8,
                        FrostHardy = false,
                        PurchaseDate = DateTime.Now,
                        SeedDepth = "1 inch",
                        PlantSpacing = "12 inches"
                    });

                temp.Add(
                    new SeedDatabase()
                    {
                        SeedType = "Pepper",
                        Variety = "Bell",
                        Manufacturer = "Baker Creek",
                        MinSproutInDays = 7,
                        MaxSproutInDays = 14,
                        MinTemperature = 50,
                        MaxTemperature = 90,
                        MinSun = 4,
                        MaxSun = 8,
                        FrostHardy = false,
                        PurchaseDate = DateTime.Now,
                        SeedDepth = "1 inch",
                        PlantSpacing = "12 inches"
                    });
            });

            return temp;
        }
    }
}
