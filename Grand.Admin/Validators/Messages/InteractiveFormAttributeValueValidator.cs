﻿using FluentValidation;
using Grand.Core.Validators;
using Grand.Services.Localization;
using Grand.Admin.Models.Messages;
using System.Collections.Generic;

namespace Grand.Admin.Validators.Messages
{
    public class InteractiveFormAttributeValueValidator : BaseGrandValidator<InteractiveFormAttributeValueModel>
    {
        public InteractiveFormAttributeValueValidator(
            IEnumerable<IValidatorConsumer<InteractiveFormAttributeValueModel>> validators,
            ILocalizationService localizationService)
            : base(validators)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Admin.Promotions.InteractiveForms.Attribute.Values.Fields.Name.Required"));
        }
    }
}