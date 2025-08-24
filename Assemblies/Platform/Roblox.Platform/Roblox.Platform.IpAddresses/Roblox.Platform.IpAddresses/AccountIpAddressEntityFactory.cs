using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Platform.Core;
using Roblox.Platform.IpAddresses.Entities;

namespace Roblox.Platform.IpAddresses;

internal class AccountIpAddressEntityFactory : IAccountIpAddressEntityFactory, IDomainFactory<IpAddressDomainFactories>, IDomainObject<IpAddressDomainFactories>
{
	public IpAddressDomainFactories DomainFactories { get; }

	public AccountIpAddressEntityFactory(IpAddressDomainFactories domainFactories)
	{
		if (domainFactories == null)
		{
			throw new PlatformArgumentNullException("domainFactories");
		}
		DomainFactories = domainFactories;
	}

	public IAccountIpAddressEntity Get(long id)
	{
		return CalToCachedMssql(AccountIPAddressV2.Get(id));
	}

	public IAccountIpAddressEntity GetOrCreate(long accountId, long ipAddressId)
	{
		if (accountId <= 0)
		{
			throw new PlatformArgumentException("'accountId' must be positive");
		}
		if (ipAddressId <= 0)
		{
			throw new PlatformArgumentException("'ipAddressId' must be positive");
		}
		return CalToCachedMssql(AccountIPAddressV2.GetOrCreate(accountId, ipAddressId));
	}

	public IEnumerable<IAccountIpAddressEntity> GetByAccountIdPaged(long accountId, int startRowIndex, int maxRows)
	{
		if (accountId <= 0)
		{
			throw new PlatformArgumentException("'accountId' must be positive");
		}
		if (startRowIndex < 0)
		{
			throw new PlatformArgumentException("'startRowIndex' cannot be negative");
		}
		if (maxRows <= 0)
		{
			throw new PlatformArgumentException("'maxRows' must be positive");
		}
		return AccountIPAddressV2.GetAccountIPAddressesV2ByAccountPaged(accountId, startRowIndex, maxRows).Select(CalToCachedMssql);
	}

	public long GetTotalByAccountId(long accountId)
	{
		if (accountId <= 0)
		{
			throw new PlatformArgumentException("'accountId' must be positive");
		}
		return AccountIPAddressV2.GetTotalNumberOfAccountIPAddressesV2ByAccount(accountId);
	}

	public IEnumerable<IAccountIpAddressEntity> GetByIpAddressIdPaged(long ipAddressId, int startRowIndex, int maxRows)
	{
		if (ipAddressId <= 0)
		{
			throw new PlatformArgumentException("'ipAddressId' must be positive");
		}
		if (startRowIndex < 0)
		{
			throw new PlatformArgumentException("'startRowIndex' cannot be negative");
		}
		if (maxRows <= 0)
		{
			throw new PlatformArgumentException("'maxRows' must be positive");
		}
		return AccountIPAddressV2.GetAccountIPAddressesV2ByAddressPaged(ipAddressId, startRowIndex, maxRows).Select(CalToCachedMssql);
	}

	public long GetTotalByIpAddressId(long ipAddressId)
	{
		if (ipAddressId <= 0)
		{
			throw new PlatformArgumentException("'ipAddressId' must be positive");
		}
		return AccountIPAddressV2.GetTotalNumberOfAccountIPAddressesV2ByAddress(ipAddressId);
	}

	public ICollection<IAccountIpAddressEntity> GetByAccountIdEnumerative(long accountId, int count, DateTime? exclusiveStartLastSeen = null, long? exclusiveStartID = null)
	{
		if (count < 1)
		{
			throw new PlatformArgumentException("'count' must be positive");
		}
		if (exclusiveStartID.HasValue && exclusiveStartID.Value < 1)
		{
			throw new PlatformArgumentException("'exclusiveStartID' must be positive");
		}
		return AccountIPAddressV2.GetAccountIPAddressesV2ByAccountID(accountId, count, exclusiveStartLastSeen, exclusiveStartID).Select(CalToCachedMssql).ToArray();
	}

	private static IAccountIpAddressEntity CalToCachedMssql(AccountIPAddressV2 cal)
	{
		if (cal != null)
		{
			return new AccountIpAddressCachedMssqlEntity
			{
				Id = cal.ID,
				AccountId = cal.AccountID,
				IpAddressId = cal.IPAddressID,
				Created = cal.Created,
				LastSeen = cal.LastSeen
			};
		}
		return null;
	}
}
