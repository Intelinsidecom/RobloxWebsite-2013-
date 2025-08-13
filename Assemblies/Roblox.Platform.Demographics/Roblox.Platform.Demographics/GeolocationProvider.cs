using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Platform.IpAddresses;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Demographics;

/// <summary>
/// Implements the interface IGeolocationFactory. Provides geolocation information for a given userid.
/// </summary>
public class GeolocationProvider : IGeolocationProvider
{
	private readonly IGeolocationFactory _GeolocationFactory;

	private readonly IpAddressDomainFactories _IpAddressDomainFactories;

	public GeolocationProvider(IGeolocationFactory geolocationFactory, IpAddressDomainFactories ipAddressDomainFactories)
	{
		_GeolocationFactory = geolocationFactory ?? throw new ArgumentNullException("geolocationFactory");
		_IpAddressDomainFactories = ipAddressDomainFactories ?? throw new ArgumentNullException("ipAddressDomainFactories");
	}

	public IGeolocation GetGeolocationByUser(IUser user)
	{
		if (user == null)
		{
			throw new ArgumentNullException("user");
		}
		ICollection<IAccountIpAddressEntity> queryResults = _IpAddressDomainFactories.AccountIpAddressEntityFactory.GetByAccountIdEnumerative(user.AccountId, 1);
		if (queryResults.Count == 0)
		{
			return new Geolocation();
		}
		long ipAddressId = queryResults.ToList().Single().IpAddressId;
		IIpAddressEntity ipAddress = _IpAddressDomainFactories.IpAddressEntityFactory.Get(Convert.ToInt32(ipAddressId));
		return _GeolocationFactory.GetOrCreateGeolocation(ipAddress.Value);
	}
}
