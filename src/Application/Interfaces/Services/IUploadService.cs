using LaptopStore_2.Application.Requests;

namespace LaptopStore_2.Application.Interfaces.Services
{
    public interface IUploadService
    {
        string UploadAsync(UploadRequest request);
    }
}