﻿using FluentValidation;
using Grand.Core.Validators;
using Grand.Services.Localization;
using Grand.Admin.Models.Messages;
using System.Collections.Generic;

namespace Grand.Admin.Validators.Messages
{
    public class NewsletterCategoryValidator : BaseGrandValidator<NewsletterCategoryModel>
    {
        public NewsletterCategoryValidator(
            IEnumerable<IValidatorConsumer<NewsletterCategoryModel>> validators,
            ILocalizationService localizationService)
            : base(validators)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Admin.Promotions.NewsletterCategory.Fields.Name.Required"));
        }
    }
}