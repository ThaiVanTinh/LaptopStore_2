using LaptopStore_2.Application.Features.Documents.Commands.AddEdit;
using LaptopStore_2.Application.Features.Documents.Queries.GetAll;
using LaptopStore_2.Application.Requests.Documents;
using LaptopStore_2.Shared.Wrapper;
using System.Threading.Tasks;
using LaptopStore_2.Application.Features.Documents.Queries.GetById;

namespace LaptopStore_2.Client.Infrastructure.Managers.Misc.Document
{
    public interface IDocumentManager : IManager
    {
        Task<PaginatedResult<GetAllDocumentsResponse>> GetAllAsync(GetAllPagedDocumentsRequest request);

        Task<IResult<GetDocumentByIdResponse>> GetByIdAsync(GetDocumentByIdQuery request);

        Task<IResult<int>> SaveAsync(AddEditDocumentCommand request);

        Task<IResult<int>> DeleteAsync(int id);
    }
}