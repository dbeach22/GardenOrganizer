using BAL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BAL.Services.Interfaces
{
    public interface ISeedService
    {
        Task<IList<Seed>> GetList(string seedType);

        Task<int> Delete(Seed seed);

        Task<SeedType> Get(Seed seed);

        Task<int> Put(Seed seed);

        Task<int> Post(Seed seed);
    }
}
