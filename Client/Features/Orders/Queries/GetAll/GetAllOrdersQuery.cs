using AutoMapper;
using LaptopStore.Application.Interfaces.Repositories;
using LaptopStore.Domain.Entities.Catalog;
using LaptopStore.Shared.Constants.Application;
using LaptopStore.Shared.Wrapper;
using LazyCache;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace LaptopStore.Application.Features.Orders.Queries.GetAll
{
    public class GetAllOrdersQuery : IRequest<Result<List<GetAllOrdersResponse>>>
    {
        public GetAllOrdersQuery()
        {
        }
    }

    internal class GetAllBrandsCachedQueryHandler : IRequestHandler<GetAllOrdersQuery, Result<List<GetAllOrdersResponse>>>
    {
        private readonly IUnitOfWork<int> _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IAppCache _cache;

        public GetAllBrandsCachedQueryHandler(IUnitOfWork<int> unitOfWork, IMapper mapper, IAppCache cache)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _cache = cache;
        }

        public async Task<Result<List<GetAllOrdersResponse>>> Handle(GetAllOrdersQuery request, CancellationToken cancellationToken)
        {
            Func<Task<List<Order>>> getAllOrders = () => _unitOfWork.Repository<Order>().GetAllAsync();
            var orderList = await _cache.GetOrAddAsync(ApplicationConstants.Cache.GetAllOrdersCacheKey, getAllOrders);

            // Mapped Orders including OrderItems
            var mappedOrders = _mapper.Map<List<GetAllOrdersResponse>>(orderList);

            foreach (var order in mappedOrders)
            {
                var orderItemList = orderList.FirstOrDefault(o => o.Id == order.Id)?.OrderItem;
                if (orderItemList != null)
                {
                    order.OrderItem = (ICollection<CartItem>)orderItemList.Select(item => new CartItemResponse
                    {
                        ProductId = item.ProductId,
                        ProductName = item.ProductName,
                        ProductPrice = item.ProductPrice,
                        ProductImage = item.ProductImage,
                        Quantity = item.Quantity
                    }).ToList();
                }
            }

            return await Result<List<GetAllOrdersResponse>>.SuccessAsync(mappedOrders);
        }

    }
}