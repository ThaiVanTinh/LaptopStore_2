using AutoMapper;
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

namespace LaptopStore.Application.Features.Carts.Queries.GetAll
{
    public class GetAllCartsQuery : IRequest<Result<List<GetAllCartsResponse>>>
    {
        public GetAllCartsQuery()
        {
        }
    }

<<<<<<< HEAD
    internal class GetAllCartsQueryHandler : IRequestHandler<GetAllCartsQuery, Result<List<GetAllCartsResponse>>>
=======
    internal class GetAllCartsCachedQueryHandler : IRequestHandler<GetAllCartsQuery, Result<List<GetAllCartsResponse>>>
>>>>>>> 9d7f1a9 (cart)
    {
        private readonly IUnitOfWork<int> _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IAppCache _cache;

<<<<<<< HEAD
        public GetAllCartsQueryHandler(IUnitOfWork<int> unitOfWork, IMapper mapper, IAppCache cache)
=======
        public GetAllCartsCachedQueryHandler(IUnitOfWork<int> unitOfWork, IMapper mapper, IAppCache cache)
>>>>>>> 9d7f1a9 (cart)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _cache = cache;
        }

        public async Task<Result<List<GetAllCartsResponse>>> Handle(GetAllCartsQuery request, CancellationToken cancellationToken)
        {
            Func<Task<List<Cart>>> getAllCarts = () => _unitOfWork.Repository<Cart>().GetAllAsync();
            var cartList = await _cache.GetOrAddAsync(ApplicationConstants.Cache.GetAllCartsCacheKey, getAllCarts);
            var mappedCarts = _mapper.Map<List<GetAllCartsResponse>>(cartList);
            return await Result<List<GetAllCartsResponse>>.SuccessAsync(mappedCarts);
        }
    }
}