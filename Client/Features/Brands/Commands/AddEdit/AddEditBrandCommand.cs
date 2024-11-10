using System.ComponentModel.DataAnnotations;
using AutoMapper;
using LaptopStore.Application.Interfaces.Repositories;
using LaptopStore.Domain.Entities.Catalog;
using LaptopStore.Shared.Wrapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Localization;
using LaptopStore.Shared.Constants.Application;
using System.Collections.Generic;
using System.Linq;

namespace LaptopStore.Application.Features.Brands.Commands.AddEdit
{
    public class AddEditBrandCommand : IRequest<Result<int>>
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public List<string> ProductLines { get; set; } = new List<string>();  // Ensure this exists
    }


    internal class AddEditBrandCommandHandler : IRequestHandler<AddEditBrandCommand, Result<int>>
    {
        private readonly IMapper _mapper;
        private readonly IStringLocalizer<AddEditBrandCommandHandler> _localizer;
        private readonly IUnitOfWork<int> _unitOfWork;

        public AddEditBrandCommandHandler(IUnitOfWork<int> unitOfWork, IMapper mapper, IStringLocalizer<AddEditBrandCommandHandler> localizer)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _localizer = localizer;
        }

        public async Task<Result<int>> Handle(AddEditBrandCommand command, CancellationToken cancellationToken)
        {
            if (command.Id == 0)
            {
                var brand = new Brand
                {
                    Name = command.Name,
                    ProductLines = command.ProductLines.Select(line => new ProductLine { LineName = line }).ToList()
                };

                await _unitOfWork.Repository<Brand>().AddAsync(brand);
                await _unitOfWork.CommitAndRemoveCache(cancellationToken, ApplicationConstants.Cache.GetAllBrandsCacheKey);
                return await Result<int>.SuccessAsync(brand.Id, _localizer["Brand Saved"]);
            }
            else
            {
                var brand = await _unitOfWork.Repository<Brand>().GetByIdAsync(command.Id);
                if (brand != null)
                {
                    brand.Name = command.Name;
                    brand.ProductLines = command.ProductLines.Select(line => new ProductLine { LineName = line }).ToList();

                    await _unitOfWork.Repository<Brand>().UpdateAsync(brand);
                    await _unitOfWork.CommitAndRemoveCache(cancellationToken, ApplicationConstants.Cache.GetAllBrandsCacheKey);
                    return await Result<int>.SuccessAsync(brand.Id, _localizer["Brand Updated"]);
                }
                else
                {
                    return await Result<int>.FailAsync(_localizer["Brand Not Found!"]);
                }
            }
        }


    }

}