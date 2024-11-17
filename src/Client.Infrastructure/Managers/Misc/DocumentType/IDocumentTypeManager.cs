using System.Collections.Generic;
using System.Threading.Tasks;
using LaptopStore_2.Application.Features.DocumentTypes.Commands.AddEdit;
using LaptopStore_2.Application.Features.DocumentTypes.Queries.GetAll;
using LaptopStore_2.Shared.Wrapper;

namespace LaptopStore_2.Client.Infrastructure.Managers.Misc.DocumentType
{
    public interface IDocumentTypeManager : IManager
    {
        Task<IResult<List<GetAllDocumentTypesResponse>>> GetAllAsync();

        Task<IResult<int>> SaveAsync(AddEditDocumentTypeCommand request);

        Task<IResult<int>> DeleteAsync(int id);

        Task<IResult<string>> ExportToExcelAsync(string searchString = "");
    }
}