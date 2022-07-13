using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Middleware.Options;
using System;

namespace Middleware
{
    public static class MiddlewareBuilder
    {
        /// <summary>
        /// Registers the custom middleware with the provided options
        /// </summary>
        public static IApplicationBuilder UseCustomMiddleware(this IApplicationBuilder app, CustomOptions options)
        {
            return app.UseMiddleware<CustomMiddleware>(options);
        }
        public static IApplicationBuilder UseCustomMiddleware(this IApplicationBuilder app,
            Action<CustomOptions> setupAction = null)
        {
            CustomOptions options;
            using (var scope = app.ApplicationServices.CreateScope())
            {
                options = scope.ServiceProvider.GetRequiredService<IOptionsSnapshot<CustomOptions>>().Value;
                setupAction?.Invoke(options);
            }

            return app.UseCustomMiddleware(options);
        }
    }
}
