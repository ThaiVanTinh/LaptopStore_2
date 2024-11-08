﻿using LaptopStore.Application.Features.Carts.Commands.AddEdit;
using FluentValidation;
using Microsoft.Extensions.Localization;

namespace LaptopStore.Application.Validators.Features.Carts.Commands.AddEdit
{
    public class AddEditCartCommandValidator : AbstractValidator<AddEditCartCommand>
    {
        public AddEditCartCommandValidator(IStringLocalizer<AddEditCartCommandValidator> localizer)
        {
            RuleFor(request => request.TotalPrice)
                .GreaterThan(0).WithMessage(x => localizer["Price is required!"]);
            RuleFor(request => request.PaymentStatus)
                .Must(x => !string.IsNullOrWhiteSpace(x)).WithMessage(x => localizer["Name is required!"]);
            
        }
    }
}