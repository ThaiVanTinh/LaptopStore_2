using LaptopStore_2.Shared.Wrapper;
using System.Threading.Tasks;
using LaptopStore_2.Application.Features.Dashboards.Queries.GetData;

namespace LaptopStore_2.Client.Infrastructure.Managers.Dashboard
{
    public interface IDashboardManager : IManager
    {
        Task<IResult<DashboardDataResponse>> GetDataAsync();
    }
}