using AutoMapper;
using LaptopStore_2.Application.Features.Brands.Commands.AddEdit;
using LaptopStore_2.Application.Features.Brands.Queries.GetAll;
using LaptopStore_2.Application.Features.Brands.Queries.GetById;
using LaptopStore_2.Domain.Entities.Catalog;

namespace LaptopStore_2.Application.Mappings
{
    public class BrandProfile : Profile
    {
        public BrandProfile()
        {
            CreateMap<AddEditBrandCommand, Brand>().ReverseMap();
            CreateMap<GetBrandByIdResponse, Brand>().ReverseMap();
            CreateMap<GetAllBrandsResponse, Brand>().ReverseMap();
        }
    }
}