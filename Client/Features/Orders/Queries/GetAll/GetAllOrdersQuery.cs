using AutoMapper;
using LaptopStore.Application.Interfaces.Repositories;
using LaptopStore.Domain.Entities.Catalog;
using LaptopStore.Shared.Constants.Application;
using LaptopStore.Shared.Wrapper;
using LazyCache;
using MediatR;
using Microsoft.EntityFrameworkCore;
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


    internal class GetAllOrdersQueryHandler : IRequestHandler<GetAllOrdersQuery, Result<List<GetAllOrdersResponse>>>
    {
        private readonly IUnitOfWork<int> _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IAppCache _cache;

        public GetAllOrdersQueryHandler(IUnitOfWork<int> unitOfWork, IMapper mapper, IAppCache cache)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _cache = cache;
        }

        public async Task<Result<List<GetAllOrdersResponse>>> Handle(GetAllOrdersQuery request, CancellationToken cancellationToken)
        {
            // Cache function to get all orders
            Func<Task<List<Order>>> getAllOrders = () => _unitOfWork.Repository<Order>().GetAllAsync();
            var orderList = await _cache.GetOrAddAsync(ApplicationConstants.Cache.GetAllOrdersCacheKey, getAllOrders);

            // Map the orders to response model
            var mappedOrders = _mapper.Map<List<GetAllOrdersResponse>>(orderList);

            // Loop through each order and map the order items from CartItem table
            foreach (var order in mappedOrders)
            {
                // Fetch CartItems associated with this OrderId using LINQ on Entities
                var cartItems = await _unitOfWork.Repository<CartItem>().Entities
                    .Where(c => c.OrderId == order.Id) // Filter by OrderId
                    .ToListAsync(); // Execute query asynchronously

                if (cartItems.Any())  // Now we await the task before using Any()
                {
                    // Map CartItem entities to CartItemResponse models
                    order.OrderItem = _mapper.Map<List<CartItemResponse>>(cartItems);

                    // Load product details for each cart item
                    foreach (var item in order.OrderItem)
                    {
                        var product = await _unitOfWork.Repository<Product>().GetByIdAsync(item.ProductId);
                        if (product != null)
                        {
                            item.ProductName = product.Name;
                            item.ProductPrice = product.Price;
                            item.Quantity = product.Quantity;
                            item.ProductImage=product.ImageDataURL;
                        }
                        else
                        {
                            item.ProductName = "Unknown Product";
                            item.ProductPrice = 0;
                            item.Quantity = 0;
                        }
                    }
                }
            }

            // Return mapped order data with products
            return await Result<List<GetAllOrdersResponse>>.SuccessAsync(mappedOrders);
        }
    }


}