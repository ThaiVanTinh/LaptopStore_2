using System.Threading.Tasks;

namespace LaptopStore_2.Application.Interfaces.Repositories
{
    public interface IProductRepository
    {
        Task<bool> IsBrandUsed(int brandId);
    }
}