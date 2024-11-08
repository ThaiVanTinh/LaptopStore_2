using LaptopStore.Application.Features.Products.Commands.AddEdit;
using FluentValidation;
using Microsoft.Extensions.Localization;

namespace LaptopStore.Application.Validators.Features.Products.Commands.AddEdit
{
    public class AddEditProductCommandValidator : AbstractValidator<AddEditProductCommand>
    {
        public AddEditProductCommandValidator(IStringLocalizer<AddEditProductCommandValidator> localizer)
        {
            RuleFor(request => request.Name)
                .Must(x => !string.IsNullOrWhiteSpace(x)).WithMessage(x => localizer["Name is required!"]);
            RuleFor(request => request.Price)
                .GreaterThan(0).WithMessage(x => localizer["Price is required!"]);
            RuleFor(request => request.Barcode)
                .Must(x => !string.IsNullOrWhiteSpace(x)).WithMessage(x => localizer["Barcode is required!"]);
            RuleFor(request => request.CPU)
                .Must(x => !string.IsNullOrWhiteSpace(x)).WithMessage(x => localizer["CPU is required!"]);
            RuleFor(request => request.Screen)
                .Must(x => !string.IsNullOrWhiteSpace(x)).WithMessage(x => localizer["Screen is required!"]);
            RuleFor(request => request.Card)
                .Must(x => !string.IsNullOrWhiteSpace(x)).WithMessage(x => localizer["Card is required!"]);
            RuleFor(request => request.Ram)
                .Must(x => !string.IsNullOrWhiteSpace(x)).WithMessage(x => localizer["Ram is required!"]);
            RuleFor(request => request.Rom)
                .Must(x => !string.IsNullOrWhiteSpace(x)).WithMessage(x => localizer["Rom is required!"]);
            RuleFor(request => request.Battery)
                .Must(x => !string.IsNullOrWhiteSpace(x)).WithMessage(x => localizer["Battery is required!"]);
            RuleFor(request => request.Weight)
               .Must(x => !string.IsNullOrWhiteSpace(x)).WithMessage(x => localizer["Weight is required!"]);
            RuleFor(request => request.Description)
                .Must(x => !string.IsNullOrWhiteSpace(x)).WithMessage(x => localizer["Description is required!"]);
            RuleFor(request => request.BrandId)
                .GreaterThan(0).WithMessage(x => localizer["Brand is required!"]);
            RuleFor(request => request.Rate)
                .InclusiveBetween(1, 5).WithMessage(x => localizer["Rate must be between 1 and 5"]);

        }
    }
}