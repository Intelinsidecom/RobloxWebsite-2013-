using Roblox.Platform.Core;
using Roblox.Platform.IpAddresses.Entities;

namespace Roblox.Platform.IpAddresses;

internal class IpAddressEntityFactory : IIpAddressEntityFactory, IDomainFactory<IpAddressDomainFactories>, IDomainObject<IpAddressDomainFactories>
{
	public IpAddressDomainFactories DomainFactories { get; }

	public IpAddressEntityFactory(IpAddressDomainFactories domainFactories)
	{
		if (domainFactories == null)
		{
			throw new PlatformArgumentNullException("domainFactories");
		}
		DomainFactories = domainFactories;
	}

	public IIpAddressEntity Get(int id)
	{
		return CalToCachedMssql(IPAddress.Get(id));
	}

	public IIpAddressEntity GetOrCreate(string value)
	{
		return CalToCachedMssql(IPAddress.GetOrCreate(value));
	}

	public IIpAddressEntity GetByValue(string value)
	{
		return CalToCachedMssql(IPAddress.GetByAddress(value));
	}

	private static IIpAddressEntity CalToCachedMssql(IPAddress cal)
	{
		if (cal != null)
		{
			return new IpAddressCachedMssqlEntity
			{
				Id = cal.ID,
				State = cal.State,
				Expiration = cal.Expiration,
				Created = cal.Created,
				Updated = cal.Updated,
				Value = cal.Value
			};
		}
		return null;
	}
}
