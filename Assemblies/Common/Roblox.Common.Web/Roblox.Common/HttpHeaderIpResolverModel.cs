namespace Roblox.Common;

/// <summary>
/// Model for resolving Ip via Http Headers
/// </summary>
public class HttpHeaderIpResolverModel
{
	/// <summary>
	/// Host address
	/// </summary>
	public string UserHostAddress { get; set; }

	/// <summary>
	/// XForwardedForHeaderName value from proxy headers
	/// </summary>
	public string ForwardedFor { get; set; }

	/// <summary>
	/// Real Ip header Name from proxy headers
	/// </summary>
	public string DosArrestRealIpHeaderName { get; set; }

	/// <summary>
	/// Roblox-Proxied-IP header for IPs that are behind a NAT or Load Balancer
	/// </summary>
	public string RobloxProxiedFor { get; set; }
}
