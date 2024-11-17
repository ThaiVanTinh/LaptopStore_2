using LaptopStore_2.Application.Requests.Identity;
using LaptopStore_2.Shared.Wrapper;
using System.Security.Claims;
using System.Threading.Tasks;

namespace LaptopStore_2.Client.Infrastructure.Managers.Identity.Authentication
{
    public interface IAuthenticationManager : IManager
    {
        Task<IResult> Login(TokenRequest model);

        Task<IResult> Logout();

        Task<string> RefreshToken();

        Task<string> TryRefreshToken();

        Task<string> TryForceRefreshToken();

        Task<ClaimsPrincipal> CurrentUser();
    }
}