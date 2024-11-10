using LaptopStore.Domain.Entities.Catalog;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LaptopStore.Application.Interfaces.Repositories
{
    public interface IBrandRepository
    {
        Task<Brand> GetByIdAsync(int id);
        Task<List<Brand>> GetAllAsync();
        Task<int> InsertAsync(Brand brand);
        Task<int> UpdateAsync(Brand brand);
        Task<int> DeleteAsync(int id);
    }
}
