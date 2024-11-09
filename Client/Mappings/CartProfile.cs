using AutoMapper;
using LaptopStore.Application.Features.Carts.Commands.AddEdit;
using LaptopStore.Application.Features.Carts.Queries.GetAll;
using LaptopStore.Application.Features.Carts.Queries.GetById;
using LaptopStore.Domain.Entities.Catalog;

namespace LaptopStore.Application.Mappings
{
    public class CartProfile : Profile
    {
        public CartProfile()
        {
            CreateMap<AddEditCartCommand, Cart>().ReverseMap();
            CreateMap<GetCartByIdResponse, Cart>().ReverseMap();
            CreateMap<GetAllCartsResponse, Cart>().ReverseMap();
        }
    }
}