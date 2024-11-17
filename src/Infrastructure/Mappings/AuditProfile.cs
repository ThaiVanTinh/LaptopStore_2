using AutoMapper;
using LaptopStore_2.Infrastructure.Models.Audit;
using LaptopStore_2.Application.Responses.Audit;

namespace LaptopStore_2.Infrastructure.Mappings
{
    public class AuditProfile : Profile
    {
        public AuditProfile()
        {
            CreateMap<AuditResponse, Audit>().ReverseMap();
        }
    }
}