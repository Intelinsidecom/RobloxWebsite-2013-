using System.Net;

namespace Roblox.Common;

/// <summary>
/// Interface used to determine which field extracted from an Http request is the true origin IP address
/// </summary>
public interface IHttpHeaderIpResolver
{
	/// <summary>
	/// Takes the user host address according to the request and the values of the X-Forwarded-For and X-Real-Ip headers
	/// and returns which of these values is the true origin host IP
	/// </summary>
	/// <param name="userHostAddress"></param>
	/// <param name="xForwardedForHeaderValue"></param>
	/// <param name="xRealIpHeaderValue"></param>
	/// <param name="robloxProxiedForHeaderValue"></param>
	/// <returns></returns>
	IPAddress ResolveOriginIpFromRequestHeaders(string userHostAddress, string xForwardedForHeaderValue, string xRealIpHeaderValue, string robloxProxiedForHeaderValue);
}
