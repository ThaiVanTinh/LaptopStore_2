using AutoMapper;
using LaptopStore.Application.Interfaces.Repositories;
using LaptopStore.Domain.Entities.Catalog;
using LaptopStore.Shared.Wrapper;
using MediatR;
using Microsoft.Extensions.Localization;
using System.Threading;
using System.Threading.Tasks;

namespace LaptopStore.Application.Features.Products.Queries.GetProductById
{
    public class GetProductByIdQuery : IRequest<Result<GetProductByIdResponse>>
    {
        public int Id { get; set; }

        public GetProductByIdQuery(int id)
        {
            Id = id;
        }

        public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, Result<GetProductByIdResponse>>
        {
            private readonly IUnitOfWork<int> _unitOfWork;
            private readonly IMapper _mapper;
            private readonly IStringLocalizer<GetProductByIdQueryHandler> _localizer;

            public GetProductByIdQueryHandler(
                IUnitOfWork<int> unitOfWork,
                IMapper mapper,
                IStringLocalizer<GetProductByIdQueryHandler> localizer)
            {
                _unitOfWork = unitOfWork;
                _mapper = mapper;
                _localizer = localizer;
            }

            public async Task<Result<GetProductByIdResponse>> Handle(GetProductByIdQuery query, CancellationToken cancellationToken)
            {
                var product = await _unitOfWork.Repository<Product>().GetByIdAsync(query.Id);

                if (product != null)
                {
                    var productResponse = _mapper.Map<GetProductByIdResponse>(product);
                    return await Result<GetProductByIdResponse>.SuccessAsync(productResponse);
                }
                else
                {
                    return await Result<GetProductByIdResponse>.FailAsync(_localizer["Product Not Found!"]);
                }
            }
        }
    }
}
