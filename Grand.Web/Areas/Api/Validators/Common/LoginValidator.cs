﻿using FluentValidation;
using Grand.Core.Configuration;
using Grand.Framework.Validators;
using Grand.Services.Customers;
using Grand.Services.Security;
using Grand.Services.Stores;
using Grand.Web.Areas.Api.Models.Common;

namespace Grand.Web.Areas.Api.Validators.Common
{
    public class LoginValidator : BaseGrandValidator<LoginModel>
    {
        public LoginValidator(ApiConfig apiConfig, ICustomerService customerService, IStoreService storeService, IUserApiService userApiService, IEncryptionService encryptionService)
        {
            if (!apiConfig.Enabled)
                RuleFor(x => x).Must((x) => false).WithMessage("API is disabled");

            RuleFor(x => x.Email).NotEmpty().WithMessage("Email is required");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Password is required");
            RuleFor(x => x).Must((x, context) =>
            {
                if (!string.IsNullOrEmpty(x.Email))
                {
                    var userapi = userApiService.GetUserByEmail(x.Email.ToLowerInvariant());
                    if (userapi != null && userapi.IsActive)
                    {
                        var base64EncodedBytes = System.Convert.FromBase64String(x.Password);
                        var password = System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
                        if (userapi.Password == encryptionService.EncryptText(password, userapi.PrivateKey))
                            return true;
                    }
                }
                return false;
            }).WithMessage(("User not exists or password is wrong"));
            RuleFor(x => x).Must((x, context) =>
            {
                if (!string.IsNullOrEmpty(x.Email))
                {
                    var customer = customerService.GetCustomerByEmail(x.Email.ToLowerInvariant());
                    if (customer != null && customer.Active && !customer.IsSystemAccount)
                        return true;
                }
                return false;
            }).WithMessage("Customer not exist");
        }
    }
}
