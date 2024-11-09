using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using LaptopStore.Application.Extensions;
using LaptopStore.Application.Interfaces.Repositories;
using LaptopStore.Application.Interfaces.Services;
using LaptopStore.Application.Specifications.Catalog;
using LaptopStore.Domain.Entities.Catalog;
using LaptopStore.Shared.Wrapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Localization;

namespace LaptopStore.Application.Features.Carts.Queries.Export
{
    public class ExportCartsQuery : IRequest<Result<string>>
    {
        public string SearchString { get; set; }

        public ExportCartsQuery(string searchString = "")
        {
            SearchString = searchString;
        }
    }

    internal class ExportCartsQueryHandler : IRequestHandler<ExportCartsQuery, Result<string>>
    {
        private readonly IExcelService _excelService;
        private readonly IUnitOfWork<int> _unitOfWork;
        private readonly IStringLocalizer<ExportCartsQueryHandler> _localizer;

        public ExportCartsQueryHandler(IExcelService excelService
            , IUnitOfWork<int> unitOfWork
            , IStringLocalizer<ExportCartsQueryHandler> localizer)
        {
            _excelService = excelService;
            _unitOfWork = unitOfWork;
            _localizer = localizer;
        }

        public async Task<Result<string>> Handle(ExportCartsQuery request, CancellationToken cancellationToken)
        {
            var cartFilterSpec = new CartFilterSpecification(request.SearchString);
            var carts = await _unitOfWork.Repository<Cart>().Entities
                .Specify(cartFilterSpec)
                .ToListAsync(cancellationToken);
            var data = await _excelService.ExportAsync(carts, mappers: new Dictionary<string, Func<Cart, object>>
            {
                { _localizer["Id"], item => item.Id },
                { _localizer["ProductId"], item => item.ProductId },
                { _localizer["Product"], item => item.Product }
            }, sheetName: _localizer["Carts"]);

            return await Result<string>.SuccessAsync(data: data);
        }
    }
}
