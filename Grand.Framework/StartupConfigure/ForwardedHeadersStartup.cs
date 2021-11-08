using Grand.Core;
using Grand.Core.Configuration;
using Grand.Core.Data;
using Grand.Framework.Infrastructure.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Grand.Framework.StartupConfigure
{
    public class ForwardedHeadersStartup : IGrandStartup
    {
        /// <summary>
        /// Add and configure any of the middleware
        /// </summary>
        /// <param name="services">Collection of service descriptors</param>
        /// <param name="configuration">Configuration root of the application</param>
        public void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            //There are several reasons for a method not to have a method body:

            //It is an unintentional omission, and should be fixed.
            //It is not yet, or never will be, supported. In this case a NotSupportedException should be thrown.
            //The method is an intentionally - blank override. In this case a nested comment should explain the reason for the blank override.
        }

        public void ConfigureServicesElse()
        {
            throw new NotSupportedException();
        }


        /// <summary>
        /// Configure the using of added middleware
        /// </summary>
        /// <param name="application">Builder for configuring an application's request pipeline</param>
        /// <param name="webHostEnvironment">WebHostEnvironment</param>
        public void Configure(IApplicationBuilder application, IWebHostEnvironment webHostEnvironment)
        {
            //check whether database is installed
            if (!DataSettingsHelper.DatabaseIsInstalled())
                return;

            var serviceProvider = application.ApplicationServices;
            var hostingConfig = serviceProvider.GetRequiredService<HostingConfig>();

            if (hostingConfig.UseForwardedHeaders)
                application.UseGrandForwardedHeaders();

        }

        /// <summary>
        /// Gets order of this startup configuration implementation
        /// </summary>
        public int Order {
            //ForwardedHeadersStartup should be loaded before authentication 
            get { return -20; }
        }
    }
}
