using System.Threading.Tasks;

namespace LaptopStore.Application.Interfaces.Repositories
{
    public interface IProductRepository
    {
        Task<bool> IsBrandUsed(int brandId);
        
    }
}