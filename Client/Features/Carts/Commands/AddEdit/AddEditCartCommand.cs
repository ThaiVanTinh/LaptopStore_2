﻿using System.ComponentModel.DataAnnotations;
using AutoMapper;
using LaptopStore.Application.Interfaces.Repositories;
using LaptopStore.Domain.Entities.Catalog;
using LaptopStore.Shared.Wrapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Localization;
using LaptopStore.Shared.Constants.Application;
using LaptopStore.Application.Features.Products.Queries.GetAllPaged;

namespace LaptopStore.Application.Features.Carts.Commands.AddEdit
{
    public partial class AddEditCartCommand : IRequest<Result<int>>
    {
        public int Id { get; set; }
        public int UserID { get; set; }
        public int ProductID { get; set; }
        public GetAllPagedProductsResponse AllProduct { get; set; }
        public int TotalPrice { get; set; }
        public string PaymentStatus { get; set; }
    }

    internal class AddEditCartCommandHandler : IRequestHandler<AddEditCartCommand, Result<int>>
    {
        private readonly IMapper _mapper;
        private readonly IStringLocalizer<AddEditCartCommandHandler> _localizer;
        private readonly IUnitOfWork<int> _unitOfWork;

        public AddEditCartCommandHandler(IUnitOfWork<int> unitOfWork, IMapper mapper, IStringLocalizer<AddEditCartCommandHandler> localizer)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _localizer = localizer;
        }

        public async Task<Result<int>> Handle(AddEditCartCommand command, CancellationToken cancellationToken)
        {
            if (command.Id == 0)
            {
                var cart = _mapper.Map<Cart>(command);
                await _unitOfWork.Repository<Cart>().AddAsync(cart);
                await _unitOfWork.CommitAndRemoveCache(cancellationToken, ApplicationConstants.Cache.GetAllCartsCacheKey);
                return await Result<int>.SuccessAsync(cart.Id, _localizer["Cart Saved"]);
            }
            else
            {
                var cart = await _unitOfWork.Repository<Cart>().GetByIdAsync(command.Id);
                if (cart != null)
                {
                    cart.TotalPrice = (command.TotalPrice == 0) ? cart.TotalPrice : command.TotalPrice;
                    cart.PaymentStatus = command.PaymentStatus ?? cart.PaymentStatus;
                    await _unitOfWork.Repository<Cart>().UpdateAsync(cart);
                    await _unitOfWork.CommitAndRemoveCache(cancellationToken, ApplicationConstants.Cache.GetAllCartsCacheKey);
                    return await Result<int>.SuccessAsync(cart.Id, _localizer["Cart Updated"]);
                }
                else
                {
                    return await Result<int>.FailAsync(_localizer["Cart Not Found!"]);
                }
            }
        }
    }
}