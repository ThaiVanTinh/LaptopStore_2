using AutoMapper;
using LaptopStore.Application.Interfaces.Repositories;
using LaptopStore.Domain.Entities.Catalog;
using LaptopStore.Shared.Wrapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace LaptopStore.Application.Features.Carts.Queries.GetById
{
    public class GetCartByIdQuery : IRequest<Result<GetCartByIdResponse>>
    {
        public int Id { get; set; }
    }

    internal class GetProductByIdQueryHandler : IRequestHandler<GetCartByIdQuery, Result<GetCartByIdResponse>>
    {
        private readonly IUnitOfWork<int> _unitOfWork;
        private readonly IMapper _mapper;

        public GetProductByIdQueryHandler(IUnitOfWork<int> unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Result<GetCartByIdResponse>> Handle(GetCartByIdQuery query, CancellationToken cancellationToken)
        {
            var brand = await _unitOfWork.Repository<Brand>().GetByIdAsync(query.Id);
            var mappedBrand = _mapper.Map<GetCartByIdResponse>(brand);
            return await Result<GetCartByIdResponse>.SuccessAsync(mappedBrand);
        }
    }
}