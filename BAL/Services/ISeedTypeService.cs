using BAL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BAL.Services.Interfaces
{
    public interface ISeedTypeService
    {
        Task<IList<SeedType>> GetList();
        
        Task<int> Delete(SeedType seedType);

        Task<SeedType> Get(SeedType seedType);

        Task<int> Put(SeedType seedType);

        Task<int> Post(SeedType seedType);
    }
}
