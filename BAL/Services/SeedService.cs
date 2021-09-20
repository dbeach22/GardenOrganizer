using BAL.Models;
using BAL.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BAL.Services
{
    public class SeedService : ISeedService
    {
        private IList<Seed> _seeds;
        FatHead.Services.Interfaces.IDatabaseService _databaseService;
        FatHead.Converters.Interfaces.IDataConverter _dataConverter;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="databaseService">FatHead.Services.Interfaces.IDatabaseService</param>
        /// <param name="dataConverter">FatHead.Converters.Interfaces.IDataConverter</param>
        public SeedService(FatHead.Services.Interfaces.IDatabaseService databaseService, FatHead.Converters.Interfaces.IDataConverter dataConverter)
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
        public Task<int> Delete(Seed seed)
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
        public Task<IList<Seed>> GetList(string seedType)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Post
        /// </summary>
        /// <param name="seedType">BAL.Models.Seed</param>
        /// <returns>int number of records affected</returns>
        public Task<int> Post(Seed seed)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Put
        /// </summary>
        /// <param name="seedType">BAL.Models.Seed</param>
        /// <returns>int number of records affected</returns>
        public Task<int> Put(Seed seed)
        {
            throw new NotImplementedException();
        }
    }
}
