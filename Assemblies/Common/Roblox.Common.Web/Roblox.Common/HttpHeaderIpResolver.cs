using System;
using System.Net;
using Roblox.Common.Properties;
using Roblox.Platform.Infrastructure;

namespace Roblox.Common;

public class HttpHeaderIpResolver : IIpResolver<HttpHeaderIpResolverModel>, IHttpHeaderIpResolver
{
	private readonly ISettings _Settings;

	private readonly IServerValidator _ServerValidator;

	public HttpHeaderIpResolver()
		: this(Settings.Default, ServerValidator.RobloxServerValidator)
	{
	}

	internal HttpHeaderIpResolver(ISettings settings, IServerValidator serverValidator)
	{
		_Settings = settings ?? throw new ArgumentNullException("settings");
		_ServerValidator = serverValidator ?? throw new ArgumentNullException("serverValidator");
	}

	internal bool IsValidIP(string potentialIPString)
	{
		IPAddress potentialIP;
		return IPAddress.TryParse(potentialIPString, out potentialIP);
	}

	/// <summary>
	/// First IP address from X-Forwarded-For header.  This represents the original client IP address, but BEWARE THIS CAN BE SPOOFED.  
	/// </summary>
	/// <param name="xForwardedForHeaderValue">The value of the xForwardedForHeader</param>
	/// <returns></returns>
	internal string TrimAndValidateXForwardedFor(string xForwardedForHeaderValue)
	{
		if (!string.IsNullOrEmpty(xForwardedForHeaderValue))
		{
			string potentialIPString = xForwardedForHeaderValue.Split(',')[0];
			if (IsValidIP(potentialIPString))
			{
				return potentialIPString;
			}
		}
		return null;
	}

	/// <summary>
	/// Determines which of the three provided values should be used as the OriginIP Address
	/// based on whether the OriginIP is from one of the three scenarios:
	///  1) an internal server (standard load-balancer situation)
	///  2) through DosArrest (deprecated).
	///  3) through another header. This is for IP addresses behind a NAT proxy.
	/// </summary>
	/// <param name="userHostAddress"></param>
	/// <param name="xForwardedForHeaderValue"></param>
	/// <param name="xRealIpHeaderValue"></param>
	/// <param name="robloxProxiedForHeaderValue"></param>
	/// <returns></returns>
	public IPAddress ResolveOriginIpFromRequestHeaders(string userHostAddress, string xForwardedForHeaderValue, string xRealIpHeaderValue, string robloxProxiedForHeaderValue)
	{
		string originIp = userHostAddress;
		if (_Settings.EnableXForwardedForOriginIp && _ServerValidator.IsAllowedProxyIp(originIp))
		{
			xForwardedForHeaderValue = TrimAndValidateXForwardedFor(xForwardedForHeaderValue);
			if (xForwardedForHeaderValue != null)
			{
				originIp = xForwardedForHeaderValue;
			}
		}
		if (_Settings.EnableDosArrestRealIpHeaderForOriginIP && _ServerValidator.IsDosArrestIp(originIp) && !string.IsNullOrEmpty(xRealIpHeaderValue) && IsValidIP(xRealIpHeaderValue))
		{
			originIp = xRealIpHeaderValue;
		}
		if (_Settings.EnableWhitelistProxiedIpHeadersForOriginIp && _ServerValidator.IsWhitelistedIp(originIp) && !string.IsNullOrEmpty(robloxProxiedForHeaderValue) && IsValidIP(robloxProxiedForHeaderValue))
		{
			originIp = robloxProxiedForHeaderValue;
		}
		IPAddress.TryParse(originIp, out var ip);
		return ip;
	}

	/// <summary>
	/// Resolve Ip from headers
	/// </summary>
	/// <param name="data">header data</param>
	/// <returns>Ip address</returns>
	public IPAddress Resolve(HttpHeaderIpResolverModel data)
	{
		return ResolveOriginIpFromRequestHeaders(data?.UserHostAddress, data?.ForwardedFor, data?.DosArrestRealIpHeaderName, data?.RobloxProxiedFor);
	}
}
