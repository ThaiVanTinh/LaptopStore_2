﻿using LaptopStore_2.Application.Features.Brands.Queries.GetAll;
using LaptopStore_2.Shared.Wrapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using LaptopStore_2.Application.Features.Brands.Commands.AddEdit;

namespace LaptopStore_2.Client.Infrastructure.Managers.Catalog.Brand
{
    public interface IBrandManager : IManager
    {
        Task<IResult<List<GetAllBrandsResponse>>> GetAllAsync();

        Task<IResult<int>> SaveAsync(AddEditBrandCommand request);

        Task<IResult<int>> DeleteAsync(int id);

        Task<IResult<string>> ExportToExcelAsync(string searchString = "");
    }
}