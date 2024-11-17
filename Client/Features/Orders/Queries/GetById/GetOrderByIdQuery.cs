using AutoMapper;
using LaptopStore.Application.Interfaces.Repositories;
using LaptopStore.Domain.Entities.Catalog;
using LaptopStore.Shared.Wrapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace LaptopStore.Application.Features.Orders.Queries.GetById
{
    public class GetOrderByIdQuery : IRequest<Result<GetOrderByIdResponse>>
    {
        public int Id { get; set; }
    }

    internal class GetProductByIdQueryHandler : IRequestHandler<GetOrderByIdQuery, Result<GetOrderByIdResponse>>
    {
        private readonly IUnitOfWork<int> _unitOfWork;
        private readonly IMapper _mapper;

        public async Task<Result<GetOrderByIdResponse>> Handle(GetOrderByIdQuery query, CancellationToken cancellationToken)
        {
            var order = await _unitOfWork.Repository<Order>().GetByIdAsync(query.Id);
            var mappedOrder = _mapper.Map<GetOrderByIdResponse>(order);
            return await Result<GetOrderByIdResponse>.SuccessAsync(mappedOrder);
        }
    }
}