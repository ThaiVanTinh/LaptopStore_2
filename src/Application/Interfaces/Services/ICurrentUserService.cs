using LaptopStore_2.Application.Interfaces.Common;

namespace LaptopStore_2.Application.Interfaces.Services
{
    public interface ICurrentUserService : IService
    {
        string UserId { get; }
    }
}