﻿using LaptopStore.Application.Features.Carts.Commands.AddEdit;
using FluentValidation;
using Microsoft.Extensions.Localization;

namespace LaptopStore.Application.Validators.Features.Carts.Commands.AddEdit
{
    public class AddEditCartCommandValidator : AbstractValidator<AddEditCartCommand>
    {
        public AddEditCartCommandValidator(IStringLocalizer<AddEditCartCommandValidator> localizer)
        {
<<<<<<< HEAD
            RuleFor(request => request.TotalPrice)
                .GreaterThan(0).WithMessage(x => localizer["Price is required!"]);
            RuleFor(request => request.PaymentStatus)
                .Must(x => !string.IsNullOrWhiteSpace(x)).WithMessage(x => localizer["Name is required!"]);
            
=======
            RuleFor(request => request.ProductId)
                .GreaterThan(0).WithMessage(x => localizer["ProductId is required!"]);
            RuleFor(request => request.Quantity)
                .GreaterThan(0).WithMessage(x => localizer["Quantity is required!"]);
            //RuleFor(request => request.Name)
            //    .Must(x => !string.IsNullOrWhiteSpace(x)).WithMessage(x => localizer["Name is required!"]);
            //RuleFor(request => request.ProductLine)
            //    .Must(x => !string.IsNullOrWhiteSpace(x)).WithMessage(x => localizer["ProductLine is required!"]);
>>>>>>> 9d7f1a9 (cart)
        }
    }
}