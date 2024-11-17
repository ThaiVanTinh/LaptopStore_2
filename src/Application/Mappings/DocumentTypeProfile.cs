using AutoMapper;
using LaptopStore_2.Application.Features.DocumentTypes.Commands.AddEdit;
using LaptopStore_2.Application.Features.DocumentTypes.Queries.GetAll;
using LaptopStore_2.Application.Features.DocumentTypes.Queries.GetById;
using LaptopStore_2.Domain.Entities.Misc;

namespace LaptopStore_2.Application.Mappings
{
    public class DocumentTypeProfile : Profile
    {
        public DocumentTypeProfile()
        {
            CreateMap<AddEditDocumentTypeCommand, DocumentType>().ReverseMap();
            CreateMap<GetDocumentTypeByIdResponse, DocumentType>().ReverseMap();
            CreateMap<GetAllDocumentTypesResponse, DocumentType>().ReverseMap();
        }
    }
}