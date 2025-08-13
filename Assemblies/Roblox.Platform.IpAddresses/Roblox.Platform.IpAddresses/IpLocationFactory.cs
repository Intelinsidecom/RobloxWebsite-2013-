using System.Net;
using Roblox.MaxMind.GeoIP2;
using Roblox.Platform.Core;

namespace Roblox.Platform.IpAddresses;

/// <summary>
/// Implementation of <see cref="T:Roblox.Platform.IpAddresses.IIpLocationFactory" />
/// </summary>
public class IpLocationFactory : IIpLocationFactory
{
	private readonly IMaxmindClient _Client;

	/// <summary>
	/// Construct a new <see cref="T:Roblox.Platform.IpAddresses.IpLocationFactory" />
	/// </summary>
	/// <param name="client">An <see cref="T:Roblox.MaxMind.GeoIP2.IMaxmindClient" /></param>
	public IpLocationFactory(IMaxmindClient maxMindClient)
	{
		_Client = maxMindClient ?? throw new PlatformArgumentNullException("maxMindClient");
	}

	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.IpAddresses.IIpLocation" /> by its string value of ipAddress
	/// </summary>
	/// <param name="ipAddress">The string value of ipAddress.</param>
	/// <returns>The <see cref="T:Roblox.Platform.IpAddresses.IIpLocation" /> with the given ipAddress, or null if the ipAddress is invalid.</returns>
	public IIpLocation GetByIpAddress(string ipAddress)
	{
		if (string.IsNullOrWhiteSpace(ipAddress))
		{
			throw new PlatformArgumentNullException("ipAddress");
		}
		if (!System.Net.IPAddress.TryParse(ipAddress, out var _))
		{
			throw new PlatformArgumentException("ipAddress");
		}
		return new IpLocation(_Client.Lookup(ipAddress, IPLookupType.City), ipAddress);
	}
}
