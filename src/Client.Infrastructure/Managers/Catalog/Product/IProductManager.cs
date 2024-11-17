using LaptopStore_2.Application.Features.Products.Commands.AddEdit;
using LaptopStore_2.Application.Features.Products.Queries.GetAllPaged;
using LaptopStore_2.Application.Requests.Catalog;
using LaptopStore_2.Shared.Wrapper;
using System.Threading.Tasks;

namespace LaptopStore_2.Client.Infrastructure.Managers.Catalog.Product
{
    public interface IProductManager : IManager
    {
        Task<PaginatedResult<GetAllPagedProductsResponse>> GetProductsAsync(GetAllPagedProductsRequest request);

        Task<IResult<string>> GetProductImageAsync(int id);

        Task<IResult<int>> SaveAsync(AddEditProductCommand request);

        Task<IResult<int>> DeleteAsync(int id);

        Task<IResult<string>> ExportToExcelAsync(string searchString = "");
    }
}