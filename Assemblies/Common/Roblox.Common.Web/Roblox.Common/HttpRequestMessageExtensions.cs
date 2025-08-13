using System.Linq;
using System.Net.Http;
using System.ServiceModel.Channels;
using System.Web;

namespace Roblox.Common;

public static class HttpRequestMessageExtensions
{
	private static readonly IIpResolver<HttpHeaderIpResolverModel> _IpResolver = new HttpHeaderIpResolver();

	public static string GetClientIpAddress(this HttpRequestMessage request)
	{
		if (request.Properties.ContainsKey("MS_HttpContext"))
		{
			return ((HttpContextWrapper)request.Properties["MS_HttpContext"]).GetOriginIP();
		}
		if (request.Properties.ContainsKey(RemoteEndpointMessageProperty.Name))
		{
			RemoteEndpointMessageProperty prop = (RemoteEndpointMessageProperty)request.Properties[RemoteEndpointMessageProperty.Name];
			request.Headers.TryGetValues("X-Forwarded-For", out var xForwardedForHeaderValues);
			string xForwardedForHeader = xForwardedForHeaderValues.FirstOrDefault();
			request.Headers.TryGetValues("X-Real-IP", out var xRealIpHeaderValues);
			string xRealIpHeader = xRealIpHeaderValues.FirstOrDefault();
			request.Headers.TryGetValues("Roblox-Proxied-IP", out var xRobloxProxiedForHeaderValues);
			string xRobloxProxiedForHeader = xRobloxProxiedForHeaderValues.FirstOrDefault();
			return _IpResolver.Resolve(new HttpHeaderIpResolverModel
			{
				UserHostAddress = prop.Address,
				ForwardedFor = xForwardedForHeader,
				DosArrestRealIpHeaderName = xRealIpHeader,
				RobloxProxiedFor = xRobloxProxiedForHeader
			}).ToString();
		}
		return null;
	}
}
