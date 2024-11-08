﻿using LaptopStore.Application.Interfaces.Repositories;
using LaptopStore.Domain.Entities.Catalog;
using LaptopStore.Shared.Wrapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Localization;

namespace LaptopStore.Application.Features.Carts.Commands.Delete
{
    public class DeleteCartCommand : IRequest<Result<int>>
    {
        public int Id { get; set; }
    }

    internal class DeleteCartCommandHandler : IRequestHandler<DeleteCartCommand, Result<int>>
    {
        private readonly IUnitOfWork<int> _unitOfWork;
        private readonly IStringLocalizer<DeleteCartCommandHandler> _localizer;

        public DeleteCartCommandHandler(IUnitOfWork<int> unitOfWork, IStringLocalizer<DeleteCartCommandHandler> localizer)
        {
            _unitOfWork = unitOfWork;
            _localizer = localizer;
        }

        public async Task<Result<int>> Handle(DeleteCartCommand command, CancellationToken cancellationToken)
        {
            var cart = await _unitOfWork.Repository<Product>().GetByIdAsync(command.Id);
            if (cart != null)
            {
                await _unitOfWork.Repository<Product>().DeleteAsync(cart);
                await _unitOfWork.Commit(cancellationToken);
                return await Result<int>.SuccessAsync(cart.Id, _localizer["Cart Deleted"]);
            }
            else
            {
                return await Result<int>.FailAsync(_localizer["Cart Not Found!"]);
            }
        }
    }
}