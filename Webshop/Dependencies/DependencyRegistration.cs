using Microsoft.Extensions.Logging;
using ASPWebshop.Services.Interfaces;
using ASPWebshop.Services.Implementations;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class DependencyInjectionRegistration
    {
        public static IServiceCollection AddMyServices(this IServiceCollection services)
        {
            //services.AddSingleton<Interface, Implementation>();

            services.AddSingleton<IUserDataAccess, UserDataAccess>();
            services.AddSingleton<ILoginService, LoginService>();

            services.AddLogging(cfg => cfg.AddConsole()).Configure<LoggerFilterOptions>(cfg => cfg.MinLevel = LogLevel.Debug);
            return services;
        }
    }
}