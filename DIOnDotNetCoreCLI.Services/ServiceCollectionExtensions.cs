using System;
using Microsoft.Extensions.DependencyInjection;

namespace DIOnDotNetCoreCLI.Services
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddMyServices(this IServiceCollection services)
        {
            return services
                .AddSingleton<IFormatterService, FormatterService>()
                .AddSingleton<IQuotesService, QuotesService>();
        }
    }
}
