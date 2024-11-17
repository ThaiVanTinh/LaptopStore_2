using AutoMapper;
using LaptopStore_2.Infrastructure.Models.Identity;
using LaptopStore_2.Application.Responses.Identity;

namespace LaptopStore_2.Infrastructure.Mappings
{
    public class RoleProfile : Profile
    {
        public RoleProfile()
        {
            CreateMap<RoleResponse, BlazorHeroRole>().ReverseMap();
        }
    }
}