using System;
using System.Net;
using System.Threading.Tasks;

namespace Roblox.LightUtils
{
	public class HealthCheckClient : IHealthCheckClient
	{
		public async Task<WebResponse> CheckHealth(string url, string method = "GET")
		{
            if (!(WebRequest.Create(url) is HttpWebRequest request))
            {
                throw new ArgumentException("Unable to create web request for url " + url);
            }
            request.Method = method;
			return await request.GetResponseAsync();
		}
	}
}
