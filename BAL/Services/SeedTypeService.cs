using BAL.Models;
using BAL.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BAL.Services
{
    public class SeedTypeService : ISeedTypeService
    {
        private IList<SeedType> _seedTypes;
        FatHead.Services.Interfaces.IDatabaseService _databaseService;
        FatHead.Converters.Interfaces.IDataConverter _dataConverter;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="databaseService">FatHead.Services.Interfaces.IDatabaseService</param>
        /// <param name="dataConverter">FatHead.Converters.Interfaces.IDataConverter</param>
        public SeedTypeService(FatHead.Services.Interfaces.IDatabaseService databaseService, FatHead.Converters.Interfaces.IDataConverter dataConverter)
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
            IList<DAL.Models.SeedTypeDatabase> seedTypeDatabases = await _databaseService.GetList<DAL.Models.SeedTypeDatabase>();

            foreach (DAL.Models.SeedTypeDatabase std in seedTypeDatabases)
            {
                SeedType seedType = new SeedType();

                _dataConverter.ConvertModelFromModel(std, seedType);

                _seedTypes.Add(seedType);
            }

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

            DAL.Models.SeedTypeDatabase seedTypeDatabase = new DAL.Models.SeedTypeDatabase();

            _dataConverter.ConvertModelFromModel(seedType, seedTypeDatabase);

            result = await _databaseService.Delete(seedTypeDatabase);

            return result;
        }

        /// <summary>
        /// Get
        /// </summary>
        /// <param name="seedType">BAL.Models.SeedType</param>
        /// <returns>int number of records affected</returns>
        public async Task<SeedType> Get(SeedType seedType)
        {
            DAL.Models.SeedTypeDatabase seedTypeDatabase = new DAL.Models.SeedTypeDatabase();

            _dataConverter.ConvertModelFromModel(seedType, seedTypeDatabase);

            seedTypeDatabase = await _databaseService.Get(seedTypeDatabase);

            _dataConverter.ConvertModelFromModel(seedTypeDatabase, seedType);

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

            DAL.Models.SeedTypeDatabase seedTypeDatabase = new DAL.Models.SeedTypeDatabase();

            _dataConverter.ConvertModelFromModel(seedType, seedTypeDatabase);

            result = await _databaseService.Put(seedTypeDatabase);

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

            DAL.Models.SeedTypeDatabase seedTypeDatabase = new DAL.Models.SeedTypeDatabase();

            _dataConverter.ConvertModelFromModel(seedType, seedTypeDatabase);

            result = await _databaseService.Post(seedTypeDatabase);

            return result;
        }
    }
}
