using System;
using System.Net;

namespace Roblox.Common;

/// <summary>
/// Interface used to determine if the IP from a supplied secure request header is the true origin IP address
/// </summary>
public interface IHttpSecureIpResolver
{
	/// <summary>
	/// Uses the secure headers from Nginx to resolve the client IP.
	/// </summary>
	/// <param name="trueIp"></param>
	/// <param name="proxyUrl"></param>
	/// <param name="nonce"></param>
	/// <param name="bool enableHashenableHash"></param>
	/// <param name="hashAndKeyPair1"></param>
	/// <param name="hashAndKeyPair2"></param>
	/// <returns></returns>
	IPAddress ResolveOriginIpFromSecureIpHeaders(string trueIp, string proxyUrl, string nonce, bool enableHash, Tuple<string, string> hashAndKeyPair1, Tuple<string, string> hashAndKeyPair2);
}
