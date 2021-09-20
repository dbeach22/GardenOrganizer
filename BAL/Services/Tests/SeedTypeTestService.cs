using BAL.Models;
using BAL.Services.Interfaces;
using DAL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BAL.Services
{
    public class SeedTypeTestService : ISeedTypeService
    {
        private IList<SeedType> _seedTypes;
        FatHead.Services.Interfaces.IDatabaseService _databaseService;
        FatHead.Converters.Interfaces.IDataConverter _dataConverter;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="databaseService">FatHead.Services.Interfaces.IDatabaseService</param>
        /// <param name="dataConverter">FatHead.Converters.Interfaces.IDataConverter</param>
        public SeedTypeTestService(FatHead.Services.Interfaces.IDatabaseService databaseService, FatHead.Converters.Interfaces.IDataConverter dataConverter)
        {
            _seedTypes = new List<SeedType>();

            _databaseService = databaseService;
            _dataConverter = dataConverter;
        }

        /// <summary>
        /// Get List of Seed Type
        /// </summary>
        /// <returns>IList of Seed Type</returns>
        public async Task<IList<SeedType>> GetList()
        {
            //IList<SeedTypeDatabase> seedTypeDatabases = await LoadDefaultSeedTypes();

            //foreach (SeedTypeDatabase std in seedTypeDatabases)
            //{
            //    SeedType seedType = new SeedType();

            //    _dataConverter.ConvertModelFromModel(std, seedType);

            //    _seedTypes.Add(seedType);
            //}

            _seedTypes = new List<SeedType>()
            {
                new SeedType(){ Id = 1, Type = "Asparagus"},
                new SeedType(){ Id = 2, Type = "Bean"},
                new SeedType(){ Id = 3, Type = "Beet"},
                new SeedType(){ Id = 4, Type = "Chard"},
                new SeedType(){ Id = 5, Type = "Broccoli"},
                new SeedType(){ Id = 6, Type = "Brussels Sprouts"},
                new SeedType(){ Id = 7, Type = "Cabbage"},
                new SeedType(){ Id = 8, Type = "Capsicum"},
                new SeedType(){ Id = 9, Type = "Carrot"},
                new SeedType(){ Id = 10, Type = "Cauliflower"},
                new SeedType(){ Id = 11, Type = "Celeriac"},
                new SeedType(){ Id = 12, Type = "Celery"},
                new SeedType(){ Id = 13, Type = "Chickpea"},
                new SeedType(){ Id = 14, Type = "Corn"},
                new SeedType(){ Id = 15, Type = "Cucumber"},
                new SeedType(){ Id = 16, Type = "Eggplant"},
                new SeedType(){ Id = 17, Type = "Lettuce"},
                new SeedType(){ Id = 18, Type = "Onion"},
                new SeedType(){ Id = 19, Type = "Parsnip"},
                new SeedType(){ Id = 20, Type = "Peas"},
                new SeedType(){ Id = 21, Type = "Potato"},
                new SeedType(){ Id = 22, Type = "Pumpkin"},
                new SeedType(){ Id = 23, Type = "Radish"},
                new SeedType(){ Id = 24, Type = "Spinach"},
                new SeedType(){ Id = 25, Type = "Squash"},
                new SeedType(){ Id = 26, Type = "Tomato"},
                new SeedType(){ Id = 27, Type = "Turnip"},
                new SeedType(){ Id = 28, Type = "Zucchini"},
                new SeedType(){ Id = 29, Type = "Pepper"},
                new SeedType(){ Id = 30, Type = "View All"}
            };

            return _seedTypes;
        }

        /// <summary>
        /// Delete
        /// </summary>
        /// <param name="seedType">BAL.Models.SeedType</param>
        /// <returns>int number of records affected</returns>
        public async Task<int> Delete(SeedType seedType)
        {
            int result = 0;

            return result;
        }

        /// <summary>
        /// Get
        /// </summary>
        /// <param name="seedType">BAL.Models.SeedType</param>
        /// <returns>BAL.Models.SeedType</returns>
        public async Task<SeedType> Get(SeedType seedType)
        {
            return seedType;
        }

        /// <summary>
        /// Put
        /// </summary>
        /// <param name="seedType">BAL.Models.SeedType</param>
        /// <returns>int number of records affected</returns>
        public async Task<int> Put(SeedType seedType)
        {
            int result = 0;

            return result;
        }

        /// <summary>
        /// Post
        /// </summary>
        /// <param name="seedType">BAL.Models.SeedType</param>
        /// <returns>int number of records affected</returns>
        public async Task<int> Post(SeedType seedType)
        {
            int result = 0;


            return result;
        }

        /// <summary>
        /// LoadDefaultSeedTypes
        /// </summary>
        /// <returns>IList of SeedTypeDatabase</returns>
        private async Task<IList<SeedTypeDatabase>> LoadDefaultSeedTypes()
        {
            IList<SeedTypeDatabase> temp = new List<SeedTypeDatabase>();

            await Task.Run(() =>
            {
                temp = new List<SeedTypeDatabase>()
                {
                    new SeedTypeDatabase(){ Id = 1, Type = "Asparagus"},
                    new SeedTypeDatabase(){ Id = 2, Type = "Bean"},
                    new SeedTypeDatabase(){ Id = 3, Type = "Beet"},
                    new SeedTypeDatabase(){ Id = 4, Type = "Chard"},
                    new SeedTypeDatabase(){ Id = 5, Type = "Broccoli"},
                    new SeedTypeDatabase(){ Id = 6, Type = "Brussels Sprouts"},
                    new SeedTypeDatabase(){ Id = 7, Type = "Cabbage"},
                    new SeedTypeDatabase(){ Id = 8, Type = "Capsicum"},
                    new SeedTypeDatabase(){ Id = 9, Type = "Carrot"},
                    new SeedTypeDatabase(){ Id = 10, Type = "Cauliflower"},
                    new SeedTypeDatabase(){ Id = 11, Type = "Celeriac"},
                    new SeedTypeDatabase(){ Id = 12, Type = "Celery"},
                    new SeedTypeDatabase(){ Id = 13, Type = "Chickpea"},
                    new SeedTypeDatabase(){ Id = 14, Type = "Corn"},
                    new SeedTypeDatabase(){ Id = 15, Type = "Cucumber"},
                    new SeedTypeDatabase(){ Id = 16, Type = "Eggplant"},
                    new SeedTypeDatabase(){ Id = 17, Type = "Lettuce"},
                    new SeedTypeDatabase(){ Id = 18, Type = "Onion"},
                    new SeedTypeDatabase(){ Id = 19, Type = "Parsnip"},
                    new SeedTypeDatabase(){ Id = 20, Type = "Peas"},
                    new SeedTypeDatabase(){ Id = 21, Type = "Potato"},
                    new SeedTypeDatabase(){ Id = 22, Type = "Pumpkin"},
                    new SeedTypeDatabase(){ Id = 23, Type = "Radish"},
                    new SeedTypeDatabase(){ Id = 24, Type = "Spinach"},
                    new SeedTypeDatabase(){ Id = 25, Type = "Squash"},
                    new SeedTypeDatabase(){ Id = 26, Type = "Tomato"},
                    new SeedTypeDatabase(){ Id = 27, Type = "Turnip"},
                    new SeedTypeDatabase(){ Id = 28, Type = "Zucchini"},
                    new SeedTypeDatabase(){ Id = 29, Type = "Pepper"},
                    new SeedTypeDatabase(){ Id = 30, Type = "View All"}
                };
            });

            return temp;
        }
    }
}
