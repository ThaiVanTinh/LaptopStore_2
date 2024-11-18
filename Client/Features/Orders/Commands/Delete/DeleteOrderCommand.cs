﻿using LaptopStore.Application.Interfaces.Repositories;
using LaptopStore.Domain.Entities.Catalog;
using LaptopStore.Shared.Wrapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Localization;
using LaptopStore.Shared.Constants.Application;

namespace LaptopStore.Application.Features.Orders.Commands.Delete
{
    public class DeleteOrderCommand : IRequest<Result<int>>
    {
        public int Id { get; set; }
    }

    internal class DeleteOrderCommandHandler : IRequestHandler<DeleteOrderCommand, Result<int>>
    {
        private readonly IProductRepository _productRepository;
        private readonly IStringLocalizer<DeleteOrderCommandHandler> _localizer;
        private readonly IUnitOfWork<int> _unitOfWork;

        public DeleteOrderCommandHandler(IUnitOfWork<int> unitOfWork, IProductRepository productRepository, IStringLocalizer<DeleteOrderCommandHandler> localizer)
        {
            _unitOfWork = unitOfWork;
            _productRepository = productRepository;
            _localizer = localizer;
        }

        public async Task<Result<int>> Handle(DeleteOrderCommand command, CancellationToken cancellationToken)
        {  
            var order = await _unitOfWork.Repository<Order>().GetByIdAsync(command.Id);
            if (order != null)
            {
                await _unitOfWork.Repository<Order>().DeleteAsync(order);
                await _unitOfWork.CommitAndRemoveCache(cancellationToken, ApplicationConstants.Cache.GetAllOrdersCacheKey);
                return await Result<int>.SuccessAsync(order.Id, _localizer["Order Deleted"]);
            }
            else
            {
                return await Result<int>.FailAsync(_localizer["Order Not Found!"]);
            }
        }
    }
}