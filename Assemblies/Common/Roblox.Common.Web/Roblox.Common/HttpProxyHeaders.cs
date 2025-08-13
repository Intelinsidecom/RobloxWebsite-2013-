namespace Roblox.Common;

/// <summary>
/// Contains the header names for the X-Forwarded-For header (used by load balancers to store the IP of incoming requests)
/// and the X-Real-Ip header (used by DosArrest to store the IP of incoming requests)
/// </summary>
public static class HttpProxyHeaders
{
	/// <summary>
	/// The name of the header in which load balancers define the host address of the incoming request
	/// </summary>
	public const string XForwardedForHeaderName = "X-Forwarded-For";

	/// <summary>
	/// The name of the header in which DosArrest defines the original host address
	/// </summary>
	public const string DosArrestRealIpHeaderName = "X-Real-IP";

	/// <summary>
	/// The name of a header added by our load balancers to indicate whether the client connection was
	/// over http or https
	/// </summary>
	public const string XForwardedProtoHeaderName = "X-Forwarded-Proto";

	/// <summary>
	/// The date of the secure request; functions as a nonce
	/// </summary>
	public const string RobloxEdgeProxyDate = "Roblox-EP-Date";

	/// <summary>
	/// This is the url that is securely proxied
	/// </summary>
	public const string RobloxEdgeProxyUrl = "Roblox-EP-Url";

	/// <summary>
	/// This is the IP address from the secure server
	/// </summary>
	public const string RobloxEdgeProxyTrueIp = "Roblox-EP-True-IP";

	/// <summary>
	/// The HMAC hash
	/// </summary>
	public const string RobloxEdgeProxySecure = "Roblox-EP-Secure";

	/// <summary>
	/// The date of the secure request; functions as a nonce
	/// </summary>
	public const string RobloxCnProxyDate = "Roblox-CNP-Date";

	/// <summary>
	/// This is the url that is securely proxied
	/// </summary>
	public const string RobloxCnProxyUrl = "Roblox-CNP-Url";

	/// <summary>
	/// This is the IP address from the secure server
	/// </summary>
	public const string RobloxCnProxyTrueIp = "Roblox-CNP-True-IP";

	/// <summary>
	/// The HMAC hash
	/// </summary>
	public const string RobloxCnProxySecure = "Roblox-CNP-Secure";

	/// <summary>
	/// The HMAC hash
	/// </summary>
	public const string RobloxCnProxySecure2 = "Roblox-CNP-Secure2";

	/// <summary>
	/// IP Address from a whitelisted proxy server
	/// </summary>
	public const string RobloxWhiteListProxiedIp = "Roblox-Proxied-IP";
}
