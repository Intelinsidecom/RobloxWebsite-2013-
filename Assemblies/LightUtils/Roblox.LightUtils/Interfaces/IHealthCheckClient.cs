using System.Net;
using System.Threading.Tasks;

namespace Roblox.LightUtils
{
	public interface IHealthCheckClient
	{
		Task<WebResponse> CheckHealth(string url, string method = "GET");
	}
}
