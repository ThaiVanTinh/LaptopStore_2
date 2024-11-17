using AutoMapper;
using LaptopStore_2.Application.Features.Documents.Commands.AddEdit;
using LaptopStore_2.Application.Features.Documents.Queries.GetById;
using LaptopStore_2.Domain.Entities.Misc;

namespace LaptopStore_2.Application.Mappings
{
    public class DocumentProfile : Profile
    {
        public DocumentProfile()
        {
            CreateMap<AddEditDocumentCommand, Document>().ReverseMap();
            CreateMap<GetDocumentByIdResponse, Document>().ReverseMap();
        }
    }
}