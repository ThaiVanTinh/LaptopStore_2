using AutoMapper;
using LaptopStore_2.Application.Interfaces.Chat;
using LaptopStore_2.Application.Models.Chat;
using LaptopStore_2.Infrastructure.Models.Identity;

namespace LaptopStore_2.Infrastructure.Mappings
{
    public class ChatHistoryProfile : Profile
    {
        public ChatHistoryProfile()
        {
            CreateMap<ChatHistory<IChatUser>, ChatHistory<BlazorHeroUser>>().ReverseMap();
        }
    }
}