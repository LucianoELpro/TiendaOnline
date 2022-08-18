using Microsoft.AspNetCore.Builder;
using WebApi.Middlewares;

namespace TiendaOnlineApi.Extensions
{
    public static class AppExtensions
    {
        public static void UseErrorHandlingddleware(this IApplicationBuilder app)
        {
            app.UseMiddleware<ErrorHandlerMiddleware>();
        }
    }
}
