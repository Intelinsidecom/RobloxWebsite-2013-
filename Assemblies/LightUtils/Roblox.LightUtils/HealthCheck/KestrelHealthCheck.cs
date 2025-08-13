using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Roblox.LightUtils.HealthCheck;

namespace Roblox.LightUtils
{
    public sealed class KestrelHealthCheck : IHealthCheckServer, IDisposable
    {
        public KestrelHealthCheck(int port = 8095, string endpoint = "/health")
        {
            _Port = port;
            _Endpoint = endpoint;
        }

        public IHealthCheckServer Start()
        {
            if (_Task != null)
                throw new InvalidOperationException("The health check server has already been started.");
            _Task = StartServer(_Cts.Token);
            return this;
        }
        public async Task StopAsync()
        {
            _Cts?.Cancel();
            try
            {
                if (_Task != null)
                {
                    await _Task;
                }
            }
            catch (OperationCanceledException)
            {
            }
            finally
            {
                _Cts?.Dispose();
                _Cts = null;
            }
        }
        public void Stop()
        {
            StopAsync().GetAwaiter().GetResult();
        }
        void IDisposable.Dispose()
        {
            Stop();
        }
        private Task StartServer(CancellationToken cancel)
        {
            var webHost = new WebHostBuilder()
                .UseKestrel()
                .Configure((app) => app.UseHealthChecks(_Endpoint))
                .UseUrls(string.Format("http://*:{0}", _Port))
                .Build();
            webHost.Start();
            return webHost.WaitForShutdownAsync(cancel);
        }

        private CancellationTokenSource _Cts = new CancellationTokenSource();
        private readonly int _Port;
        private readonly string _Endpoint;
        private Task _Task;
    }
}
