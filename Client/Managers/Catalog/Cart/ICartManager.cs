using LaptopStore.Application.Features.Carts.Queries.GetAll;
using LaptopStore.Shared.Wrapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using LaptopStore.Application.Features.Carts.Commands.AddEdit;

namespace LaptopStore.Client.Infrastructure.Managers.Catalog.Cart
{
    public interface ICartManager : IManager
    {
        Task<IResult<List<GetAllCartsResponse>>> GetAllAsync();

        Task<IResult<int>> SaveAsync(AddEditCartCommand request);

        Task<IResult<int>> DeleteAsync(int id);

        Task<IResult<string>> ExportToExcelAsync(string searchString = "");
    }
}