using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace Roblox.Networking;

/// <summary>
/// Utility methods for dealing with IPAddresses
/// </summary>
public static class IPAddressUtils
{
	/// <summary>
	/// Resoves client ip address from request header value
	/// </summary>
	/// <param name="headerValue">Request header value</param>
	/// <returns>Client ip address</returns>
	/// <throws>ArgumentException if unable to parse header value</throws>
	public static IPAddress ResolveClientIpAddressFromRequestHeader(string headerValue)
	{
		if (!string.IsNullOrEmpty(headerValue))
		{
			IPAddress xForwardedForIPAddress = ParseIPAddress(headerValue.Split(new char[1] { ',' })[0]);
			if (xForwardedForIPAddress != null)
			{
				return xForwardedForIPAddress;
			}
			throw new ArgumentException($"Unable to parse ip address '{headerValue}'", "headerValue");
		}
		return null;
	}

	/// <summary>
	/// Returns true if ip address is allowed
	/// </summary>
	/// <param name="ipAddress">IP Address to check</param>
	/// <param name="ipAddressRanges">IP Address ranges to check against</param>
	/// <returns>True if ip address is allowed</returns>
	public static bool IsIpAddressAllowed(IPAddress ipAddress, IReadOnlyCollection<IpAddressRange> ipAddressRanges)
	{
		return ipAddressRanges.Aggregate(seed: false, (bool result, IpAddressRange ipRange) => result || ipRange.IsInRange(ipAddress));
	}

	/// <summary>
	/// Parse ip address from string
	/// </summary>
	/// <param name="ipAddressString">IP Address string</param>
	/// <returns>ip address</returns>
	public static IPAddress ParseIPAddress(string ipAddressString)
	{
		if (!IPAddress.TryParse(ipAddressString, out var ipAddress))
		{
			return null;
		}
		return ipAddress;
	}
}
