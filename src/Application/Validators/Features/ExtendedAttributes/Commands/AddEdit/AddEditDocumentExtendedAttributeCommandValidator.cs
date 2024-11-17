﻿using LaptopStore_2.Domain.Entities.ExtendedAttributes;
using LaptopStore_2.Domain.Entities.Misc;
using Microsoft.Extensions.Localization;

namespace LaptopStore_2.Application.Validators.Features.ExtendedAttributes.Commands.AddEdit
{
    public class AddEditDocumentExtendedAttributeCommandValidator : AddEditExtendedAttributeCommandValidator<int, int, Document, DocumentExtendedAttribute>
    {
        public AddEditDocumentExtendedAttributeCommandValidator(IStringLocalizer<AddEditExtendedAttributeCommandValidatorLocalization> localizer) : base(localizer)
        {
            // you can override the validation rules here
        }
    }
}