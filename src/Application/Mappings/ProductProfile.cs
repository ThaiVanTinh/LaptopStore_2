using AutoMapper;
using LaptopStore_2.Application.Features.Products.Commands.AddEdit;
using LaptopStore_2.Domain.Entities.Catalog;

namespace LaptopStore_2.Application.Mappings
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<AddEditProductCommand, Product>().ReverseMap();
        }
    }
}