using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace Roblox.LightUtils
{
    public static class HealthCheckMiddleware
    {
        public static IApplicationBuilder UseHealthChecks(this IApplicationBuilder app, string endpoint = "/health", Func<bool> isAppHealthyFunc = null)
        {
            if (app == null) throw new ArgumentNullException(nameof(app));
            isAppHealthyFunc = isAppHealthyFunc ?? (() => true);
            app.Map(endpoint, appBuilder => HandleHealth(appBuilder, isAppHealthyFunc));
            return app;
        }

        private static void HandleHealth(IApplicationBuilder app, Func<bool> isAppHealthyFunc) 
            => app.Run(async context =>
            {
                if (!isAppHealthyFunc())
                {
                    context.Response.StatusCode = 500;
                    await context.Response.WriteAsync("App instance is not healthy", default);
                }
                else
                {
                    context.Response.StatusCode = 200;
                    await context.Response.WriteAsync(Environment.GetEnvironmentVariable("AppName") != null? $"{Environment.GetEnvironmentVariable("AppName")} is OK!" : null, default);
                }
            }
        );
    }
}
