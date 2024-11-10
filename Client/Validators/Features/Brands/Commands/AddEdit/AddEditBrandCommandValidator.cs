using LaptopStore.Application.Features.Brands.Commands.AddEdit;
using FluentValidation;
using Microsoft.Extensions.Localization;
using System.Linq; // Add this line

namespace LaptopStore.Application.Validators.Features.Brands.Commands.AddEdit
{
    public class AddEditBrandCommandValidator : AbstractValidator<AddEditBrandCommand>
    {
        public AddEditBrandCommandValidator(IStringLocalizer<AddEditBrandCommandValidator> localizer)
        {
            RuleFor(request => request.Name)
                .Must(x => !string.IsNullOrWhiteSpace(x)).WithMessage(x => localizer["Name is required!"]);

            RuleFor(request => request.ProductLines)
                .Must(x => x != null && x.Any()).WithMessage(x => localizer["At least one ProductLine is required!"]);

        }
    }
}
