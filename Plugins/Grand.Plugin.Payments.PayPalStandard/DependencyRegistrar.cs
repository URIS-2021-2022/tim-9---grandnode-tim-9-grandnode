using Grand.Core.Configuration;
using Grand.Core.Infrastructure;
using Grand.Core.Infrastructure.DependencyManagement;
using Microsoft.Extensions.DependencyInjection;

namespace Grand.Plugin.Payments.PayPalStandard
{
    public class DependencyRegistrar : IDependencyRegistrar
    {
        public virtual void Register(IServiceCollection serviceCollection, ITypeFinder typeFinder, GrandConfig config)
        {
            serviceCollection.AddScoped<PayPalStandardPaymentProcessor>();
        }

        public int Order
        {
            get { return 10; }
        }
    }
}
