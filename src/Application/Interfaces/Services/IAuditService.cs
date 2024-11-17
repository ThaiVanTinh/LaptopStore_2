using LaptopStore_2.Application.Responses.Audit;
using LaptopStore_2.Shared.Wrapper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LaptopStore_2.Application.Interfaces.Services
{
    public interface IAuditService
    {
        Task<IResult<IEnumerable<AuditResponse>>> GetCurrentUserTrailsAsync(string userId);

        Task<IResult<string>> ExportToExcelAsync(string userId, string searchString = "", bool searchInOldValues = false, bool searchInNewValues = false);
    }
}