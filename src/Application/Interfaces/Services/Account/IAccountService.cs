using LaptopStore_2.Application.Interfaces.Common;
using LaptopStore_2.Application.Requests.Identity;
using LaptopStore_2.Shared.Wrapper;
using System.Threading.Tasks;

namespace LaptopStore_2.Application.Interfaces.Services.Account
{
    public interface IAccountService : IService
    {
        Task<IResult> UpdateProfileAsync(UpdateProfileRequest model, string userId);

        Task<IResult> ChangePasswordAsync(ChangePasswordRequest model, string userId);

        Task<IResult<string>> GetProfilePictureAsync(string userId);

        Task<IResult<string>> UpdateProfilePictureAsync(UpdateProfilePictureRequest request, string userId);
    }
}