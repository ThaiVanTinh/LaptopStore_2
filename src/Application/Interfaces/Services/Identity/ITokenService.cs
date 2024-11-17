using LaptopStore_2.Application.Interfaces.Common;
using LaptopStore_2.Application.Requests.Identity;
using LaptopStore_2.Application.Responses.Identity;
using LaptopStore_2.Shared.Wrapper;
using System.Threading.Tasks;

namespace LaptopStore_2.Application.Interfaces.Services.Identity
{
    public interface ITokenService : IService
    {
        Task<Result<TokenResponse>> LoginAsync(TokenRequest model);

        Task<Result<TokenResponse>> GetRefreshTokenAsync(RefreshTokenRequest model);
    }
}