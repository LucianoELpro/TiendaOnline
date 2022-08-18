using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace TiendaOnlineApi.Extensions
{
    public static class ServiceExtension
    {

        public static void AddApiVersioningExtension(this IServiceCollection service)
        {
            service
              .AddApiVersioning(config =>
                {
                    config.DefaultApiVersion = new ApiVersion(1, 0);
                    config.AssumeDefaultVersionWhenUnspecified = true;
                    config.ReportApiVersions = true;
                });

        }
    }
}
