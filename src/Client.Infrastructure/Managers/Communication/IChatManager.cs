using LaptopStore_2.Application.Models.Chat;
using LaptopStore_2.Application.Responses.Identity;
using LaptopStore_2.Shared.Wrapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using LaptopStore_2.Application.Interfaces.Chat;

namespace LaptopStore_2.Client.Infrastructure.Managers.Communication
{
    public interface IChatManager : IManager
    {
        Task<IResult<IEnumerable<ChatUserResponse>>> GetChatUsersAsync();

        Task<IResult> SaveMessageAsync(ChatHistory<IChatUser> chatHistory);

        Task<IResult<IEnumerable<ChatHistoryResponse>>> GetChatHistoryAsync(string cId);
    }
}