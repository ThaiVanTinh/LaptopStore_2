﻿using AutoMapper;
using LaptopStore_2.Application.Requests.Identity;
using LaptopStore_2.Application.Responses.Identity;

namespace LaptopStore_2.Client.Infrastructure.Mappings
{
    public class RoleProfile : Profile
    {
        public RoleProfile()
        {
            CreateMap<PermissionResponse, PermissionRequest>().ReverseMap();
            CreateMap<RoleClaimResponse, RoleClaimRequest>().ReverseMap();
        }
    }
}