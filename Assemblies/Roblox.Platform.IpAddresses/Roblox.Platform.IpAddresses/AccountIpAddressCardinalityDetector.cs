using System.Linq;
using Roblox.Platform.Core;

namespace Roblox.Platform.IpAddresses;

/// <summary>
/// Checks how many accounts have been accessed from an IP address
/// </summary>
internal class AccountIpAddressCardinalityDetector : IAccountIpAddressCardinalityDetector
{
	private IpAddressDomainFactories _Factories;

	public AccountIpAddressCardinalityDetector(IpAddressDomainFactories factories)
	{
		_Factories = factories.AssignOrThrowIfNull("factories");
	}

	/// <summary>
	/// Checks if more than a given number of accounts have been accessed from an IP address.
	/// This implementation is less heavy on the database than aggregating for exact cardinality.
	/// </summary>
	/// <param name="ipAddress">The IP address</param>
	/// <param name="threshold">Threshold number</param>
	public bool IsCardinalityGreaterThanThreshold(string ipAddress, int threshold)
	{
		IIpAddressEntity ipAddressEntity = _Factories.IpAddressEntityFactory.GetByValue(ipAddress);
		if (ipAddressEntity == null)
		{
			return false;
		}
		return _Factories.AccountIpAddressEntityFactory.GetByIpAddressIdPaged(ipAddressEntity.Id, 0, threshold + 1).Count() > threshold;
	}
}
