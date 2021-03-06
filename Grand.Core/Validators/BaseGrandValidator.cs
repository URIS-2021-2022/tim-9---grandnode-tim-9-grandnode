using FluentValidation;
using System.Collections.Generic;

namespace Grand.Core.Validators
{
    public abstract class BaseGrandValidator<T> : AbstractValidator<T> where T : class
    {

        protected BaseGrandValidator(IEnumerable<IValidatorConsumer<T>> validators)
        {
        
        }

        protected virtual void PostInitialize(IEnumerable<IValidatorConsumer<T>> validators)
        {
            foreach (var item in validators)
            {
                item.AddRules(this);
            }

        }

    }


}