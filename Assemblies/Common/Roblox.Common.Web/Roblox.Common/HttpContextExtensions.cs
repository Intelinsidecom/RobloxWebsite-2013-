using System.Web;

namespace Roblox.Common;

/// <summary>
/// Http context extensions
/// </summary>
public static class HttpContextExtensions
{
	private static readonly HttpHeaderIpResolver _HeaderResolver = new HttpHeaderIpResolver();

	private static readonly HttpSecureIpResolver _SecureResolver = new HttpSecureIpResolver();

	private static readonly HttpContextIpResolver _IPResolver = new HttpContextIpResolver(_HeaderResolver, _SecureResolver);

	/// <summary>
	/// Determines the true origin IP address based on whether the request came from an internal server,
	/// externally through a load balancer, through DosArrest, or through DosArrest through a load balancer.
	/// </summary>
	/// <param name="context">context base</param>
	/// <returns></returns>
	public static string GetOriginIP(this HttpContextBase context)
	{
		return _IPResolver.Resolve(context)?.ToString();
	}

	/// <summary>
	/// Determines the true origin IP address based on whether the request came from an internal server,
	/// externally through a load balancer, through DosArrest, or through DosArrest through a load balancer.
	/// </summary>
	/// <param name="context"></param>
	/// <returns></returns>
	public static string GetOriginIP(this HttpContext context)
	{
		return _IPResolver.Resolve(context)?.ToString();
	}
}
