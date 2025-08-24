using Roblox.MaxMind.GeoIP2;
using Roblox.Platform.Core;

namespace Roblox.Platform.IpAddresses;

/// <summary>
/// Implementation of <see cref="T:Roblox.Platform.IpAddresses.IIpLocation" />
/// </summary>
internal class IpLocation : IIpLocation
{
	/// <inheritdoc cref="P:Roblox.Platform.IpAddresses.IIpLocation.Country" />
	public string Country { get; }

	/// <inheritdoc cref="P:Roblox.Platform.IpAddresses.IIpLocation.Region" />
	public string Region { get; }

	/// <inheritdoc cref="P:Roblox.Platform.IpAddresses.IIpLocation.City" />
	public string City { get; }

	/// <inheritdoc cref="P:Roblox.Platform.IpAddresses.IIpLocation.Postal" />
	public string Postal { get; }

	/// <inheritdoc cref="P:Roblox.Platform.IpAddresses.IIpLocation.IpType" />
	public IpType IpType { get; }

	/// <inheritdoc cref="P:Roblox.Platform.IpAddresses.IIpLocation.Value" />
	public string Value { get; }

	/// <summary>
	/// Constructs a new <see cref="T:Roblox.Platform.IpAddresses.IpLocation" />
	/// </summary>
	/// <param name="ipLookUpResult">An <see cref="T:Roblox.MaxMind.GeoIP2.IPLookupResult" /></param>
	/// <param name="ipAddress">A string value of ipAddress</param>
	public IpLocation(IIPLookupResult ipLookUpResult, string ipAddress)
	{
		if (ipLookUpResult == null)
		{
			throw new PlatformArgumentNullException("ipLookUpResult");
		}
		if (ipAddress == null)
		{
			throw new PlatformArgumentNullException("ipAddress");
		}
		Country = ipLookUpResult.Country;
		Region = ipLookUpResult.Subdivision;
		City = ipLookUpResult.City;
		Postal = ipLookUpResult.ZipCode;
		Value = ipAddress;
		switch (ipLookUpResult.IPLookupErrorType)
		{
		case IPLookupErrorType.BadRequest:
			IpType = IpType.Private;
			break;
		case IPLookupErrorType.NotFound:
		case IPLookupErrorType.Other:
			IpType = IpType.NotFound;
			break;
		default:
			IpType = IpType.Public;
			break;
		}
	}
}
