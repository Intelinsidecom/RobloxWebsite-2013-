using Microsoft.Owin;

namespace Roblox.Common;

public static class OwinContextExtensions
{
	private static readonly IIpResolver<HttpHeaderIpResolverModel> _HttpContextIpResolver = new HttpHeaderIpResolver();

	/// <summary>
	/// Proxy aware IP address lookup
	/// </summary>
	/// <param name="context"></param>
	/// <returns></returns>
	public static string GetOwinContextOriginIP(this IOwinContext context)
	{
		return _HttpContextIpResolver.Resolve(new HttpHeaderIpResolverModel
		{
			UserHostAddress = context.Request.RemoteIpAddress,
			ForwardedFor = context.Request.Headers["X-Forwarded-For"],
			DosArrestRealIpHeaderName = context.Request.Headers["X-Real-IP"]
		}).ToString();
	}
}
