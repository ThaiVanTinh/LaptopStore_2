using AutoMapper;
using LaptopStore.Application.Features.Orders.Commands.AddEdit;
using LaptopStore.Application.Features.Orders.Queries.GetAll;
using LaptopStore.Application.Features.Orders.Queries.GetById;
using LaptopStore.Domain.Entities.Catalog;

namespace LaptopStore.Application.Mappings
{
    public class OrderProfile : Profile
    {
        public OrderProfile()
        {
            CreateMap<AddEditOrderCommand, Order>().ReverseMap();
            CreateMap<GetOrderByIdResponse, Order>().ReverseMap();
            CreateMap<GetAllOrdersResponse, Order>().ReverseMap();
            CreateMap<Order, Order>().ReverseMap();
        }
    }
}