using System.Threading.Tasks;

namespace Roblox.LightUtils.HealthCheck
{
	public interface IHealthCheckServer
	{
		IHealthCheckServer Start();
		Task StopAsync();
		void Stop();
	}
}
