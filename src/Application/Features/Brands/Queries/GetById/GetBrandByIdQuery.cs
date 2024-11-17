using AutoMapper;
using LaptopStore_2.Application.Interfaces.Repositories;
using LaptopStore_2.Domain.Entities.Catalog;
using LaptopStore_2.Shared.Wrapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace LaptopStore_2.Application.Features.Brands.Queries.GetById
{
    public class GetBrandByIdQuery : IRequest<Result<GetBrandByIdResponse>>
    {
        public int Id { get; set; }
    }

    internal class GetProductByIdQueryHandler : IRequestHandler<GetBrandByIdQuery, Result<GetBrandByIdResponse>>
    {
        private readonly IUnitOfWork<int> _unitOfWork;
        private readonly IMapper _mapper;

        public GetProductByIdQueryHandler(IUnitOfWork<int> unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Result<GetBrandByIdResponse>> Handle(GetBrandByIdQuery query, CancellationToken cancellationToken)
        {
            var brand = await _unitOfWork.Repository<Brand>().GetByIdAsync(query.Id);
            var mappedBrand = _mapper.Map<GetBrandByIdResponse>(brand);
            return await Result<GetBrandByIdResponse>.SuccessAsync(mappedBrand);
        }
    }
}