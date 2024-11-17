using LaptopStore_2.Application.Requests.Mail;
using System.Threading.Tasks;

namespace LaptopStore_2.Application.Interfaces.Services
{
    public interface IMailService
    {
        Task SendAsync(MailRequest request);
    }
}