using AutoMapper;
using LaptopStore.Application.Interfaces.Repositories;
using LaptopStore.Domain.Entities.Catalog;
using LaptopStore.Shared.Wrapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace LaptopStore.Application.Features.Orders.Queries.GetById
{
    public class GetOrderByIdQuery : IRequest<Result<GetOrderByIdResponse>>
    {
        public int Id { get; set; } // Order ID to get
    }

    internal class GetOrderByIdQueryHandler : IRequestHandler<GetOrderByIdQuery, Result<GetOrderByIdResponse>>
    {
        private readonly IUnitOfWork<int> _unitOfWork;
        private readonly IMapper _mapper;

        public GetOrderByIdQueryHandler(IUnitOfWork<int> unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Result<GetOrderByIdResponse>> Handle(GetOrderByIdQuery request, CancellationToken cancellationToken)
        {
            // Fetch the order by its ID
            var order = await _unitOfWork.Repository<Order>().GetByIdAsync(request.Id);

            if (order == null)
            {
                // Return failure result if order not found
                return await Result<GetOrderByIdResponse>.FailAsync("Order not found.");
            }

            // Map the order to response model
            var mappedOrder = _mapper.Map<GetOrderByIdResponse>(order);

            // Fetch associated CartItems for the given OrderId
            var cartItems = await _unitOfWork.Repository<CartItem>().Entities
                .Where(c => c.OrderId == order.Id) // Filter by OrderId
                .ToListAsync(); // Execute the query

            if (cartItems.Any())  // Check if there are CartItems
            {
                mappedOrder.OrderItem = _mapper.Map<List<CartItemByIdResponse>>(cartItems);

                foreach (var item in mappedOrder.OrderItem)
                {
                    var product = await _unitOfWork.Repository<Product>().GetByIdAsync(item.ProductId);
                    if (product != null)
                    {
                        item.ProductName = product.Name;
                        item.ProductPrice = product.Price;
                        item.Quantity = product.Quantity;
                        item.QuantityOrdered = cartItems.FirstOrDefault(c => c.ProductId == item.ProductId)?.Quantity ?? 0; 
                        item.ProductImage=product.ImageDataURL;
                    }
                    else
                    {
                        item.ProductName = "Unknown Product";
                        item.ProductPrice = 0;
                        item.Quantity = 0;
                        item.QuantityOrdered = 0;
                    }
                }
            }

            return await Result<GetOrderByIdResponse>.SuccessAsync(mappedOrder);
        }
    }
}
