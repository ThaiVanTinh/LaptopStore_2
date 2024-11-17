using System.Collections.Generic;
using System.Threading.Tasks;
using LaptopStore_2.Application.Interfaces.Common;
using LaptopStore_2.Application.Requests.Identity;
using LaptopStore_2.Application.Responses.Identity;
using LaptopStore_2.Shared.Wrapper;

namespace LaptopStore_2.Application.Interfaces.Services.Identity
{
    public interface IRoleClaimService : IService
    {
        Task<Result<List<RoleClaimResponse>>> GetAllAsync();

        Task<int> GetCountAsync();

        Task<Result<RoleClaimResponse>> GetByIdAsync(int id);

        Task<Result<List<RoleClaimResponse>>> GetAllByRoleIdAsync(string roleId);

        Task<Result<string>> SaveAsync(RoleClaimRequest request);

        Task<Result<string>> DeleteAsync(int id);
    }
}