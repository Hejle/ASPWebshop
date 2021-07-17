using Microsoft.Extensions.Logging;
using ASPWebshop.Services.Interfaces;
using ASPWebshop.Services.Implementations;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class DependencyInjectionRegistration
    {
        /// <summary>
        /// Addes Services to the Dependency Framework
        /// A service is added with the following code.
        /// services.AddSingleton<Interface, Implementation>();
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddServices(this IServiceCollection services)
        {

            services.AddSingleton<IUserDataAccess, UserDataAccess>();
            services.AddSingleton<ILoginService, LoginService>();

            services.AddLogging(cfg => cfg.AddConsole()).Configure<LoggerFilterOptions>(cfg => cfg.MinLevel = LogLevel.Debug);
            return services;
        }
    }
}