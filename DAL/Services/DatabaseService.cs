using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.Services
{
    public class DatabaseService : FatHead.Services.Interfaces.IDatabaseService
    {
        /// <summary>
        /// Delete
        /// </summary>
        /// <typeparam name="T">Generic Type</typeparam>
        /// <param name="Model">Generic Model</param>
        /// <returns>int number of records affected</returns>
        public Task<int> Delete<T>(T Model) where T : class, new()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get
        /// </summary>
        /// <typeparam name="T">Generic Type</typeparam>
        /// <param name="model">Generic Model</param>
        /// <returns>Generic Model</returns>
        public Task<T> Get<T>(T model) where T : class, new()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// GetList
        /// </summary>
        /// <typeparam name="T">Generic Type</typeparam>
        /// <returns>IList of Generic Models</returns>
        public Task<IList<T>> GetList<T>()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Post
        /// </summary>
        /// <typeparam name="T">Generic Type</typeparam>
        /// <param name="Model">Generic Model</param>
        /// <returns>int number of records affected</returns>
        public Task<int> Post<T>(T Model) where T : class, new()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Put
        /// </summary>
        /// <typeparam name="T">Generic Type</typeparam>
        /// <param name="Model">Generic Model</param>
        /// <returns>int number of records affected</returns>
        public Task<int> Put<T>(T Model) where T : class, new()
        {
            throw new NotImplementedException();
        }
    }
}
