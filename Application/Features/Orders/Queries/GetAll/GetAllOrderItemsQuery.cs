﻿using AutoMapper;
using LaptopStore.Application.Features.Orders.Queries.GetAll;
using LaptopStore.Application.Interfaces.Repositories;
using LaptopStore.Domain.Entities.Catalog;
using LaptopStore.Shared.Constants.Application;
using LaptopStore.Shared.Wrapper;
using LazyCache;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace LaptopStore.Application.Features.Orders.Queries.GetAll
{
    public class GetAllOrderItemsQuery : IRequest<Result<List<GetAllOrderItemsResponse>>>
    {
        public GetAllOrderItemsQuery()
        {
        }
    }

    internal class GetAllOrderItemsCachedQueryHandler : IRequestHandler<GetAllOrderItemsQuery, Result<List<GetAllOrderItemsResponse>>>
    {
        private readonly IUnitOfWork<int> _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IAppCache _cache;

        public GetAllOrderItemsCachedQueryHandler(IUnitOfWork<int> unitOfWork, IMapper mapper, IAppCache cache)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _cache = cache;
        }

        public async Task<Result<List<GetAllOrderItemsResponse>>> Handle(GetAllOrderItemsQuery request, CancellationToken cancellationToken)
        {
            Func<Task<List<Domain.Entities.Catalog.OrderItem>>> getAllOrderItems = () => _unitOfWork.Repository<Domain.Entities.Catalog.OrderItem>().GetAllAsync();
            var orderList = await _cache.GetOrAddAsync(ApplicationConstants.Cache.GetAllOrderItemsCacheKey, getAllOrderItems);
            var mappedOrders = _mapper.Map<List<GetAllOrderItemsResponse>>(orderList);
            return await Result<List<GetAllOrderItemsResponse>>.SuccessAsync(mappedOrders);
        }
    }
}