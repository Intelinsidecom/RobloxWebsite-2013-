using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Prometheus;

namespace Roblox.LightUtils
{
    public static class TelemetryMiddlewareExtensions
    {
        public static IApplicationBuilder UseTelemetry(this IApplicationBuilder app)
        {
            Initialize();
            app.Use(async (context, next) =>
            {
                var endpointLogEntry = GetEndPointLogEntry(context);
                _ConcurentRequestsGauge.WithLabels(context.Request.Method, context.Request.Path).Inc(1.0);
                _HttpRequestCounter.WithLabels(context.Request.Method, context.Request.Path).Inc(1.0);
                if (string.Compare(context.Request.Method, "GET", StringComparison.CurrentCultureIgnoreCase) == 0)
                    SimpleLogger.Trace($"{endpointLogEntry} request called", new { context.Request.QueryString });
                else
                    SimpleLogger.Trace($"{endpointLogEntry} request called");
                var latency = Stopwatch.StartNew();
                try
                {
                    await next();
                    context.Response.OnCompleted(() =>
                    {
                        if (context.Response.StatusCode >= 200 && context.Response.StatusCode < 300)
                            _RequestDurationHistogram.WithLabels(context.Request.Method, context.Request.Path).Observe(latency.Elapsed.TotalSeconds);
                        _ConcurentRequestsGauge.WithLabels(context.Request.Method, context.Request.Path).Dec(1.0);
                        _HttpResponseCounter.WithLabels(context.Request.Method, context.Request.Path, context.Response.StatusCode.ToString()).Inc(1.0);
                        return Task.CompletedTask;
                    });
                    SimpleLogger.Trace($"{endpointLogEntry} responded in {latency.ElapsedMilliseconds} ms");
                }
                catch (Exception ex)
                {
                    _ConcurentRequestsGauge.WithLabels(context.Request.Method, context.Request.Path).Dec(1.0);
                    _HttpResponseCounter.WithLabels(context.Request.Method, context.Request.Path, "500").Inc(1.0);
                    SimpleLogger.Error($"{endpointLogEntry} failed in {latency.ElapsedMilliseconds} ms", ex, null);
                    throw;
                }
            });
            return app;
        }

        private static void Initialize()
        {
            _HttpResponseCounter = Metrics.CreateCounter("http_server_response_total", "Total number of http responses", "Method", "Endpoint", "StatusCode");
            _HttpRequestCounter = Metrics.CreateCounter("http_server_requests_total", "Total number of http requests", "Method", "Endpoint");
            _ConcurentRequestsGauge = Metrics.CreateGauge("http_server_concurent_requests_total", "Number of concurent requests", "Method", "Endpoint");
            _RequestDurationHistogram = Metrics.CreateHistogram("http_server_request_duration_seconds", "Duration in seconds each request takes", "Method", "Endpoint");
            SimpleLogger.Trace("MetricsMiddleware initialized", null);
        }

        private static string GetEndPointLogEntry(HttpContext context)
        {
            return string.Format("\"{0} {1}\"", context.Request.Method, context.Request.Path);
        }

        private static Gauge _ConcurentRequestsGauge;
        private static Counter _HttpResponseCounter;
        private static Counter _HttpRequestCounter;
        private static Histogram _RequestDurationHistogram;
    }
}
