using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Platform.Authentication.AccountSecurityTickets.Entities;
using Roblox.Platform.Core;

namespace Roblox.Platform.Authentication.AccountSecurityTickets;

internal class AccountSecurityTicketsV2EntityFactory : IAccountSecurityTicketsV2EntityFactory, IDomainFactory<AccountSecurityTicketsDomainFactories>, IDomainObject<AccountSecurityTicketsDomainFactories>
{
	public AccountSecurityTicketsDomainFactories DomainFactories { get; }

	public AccountSecurityTicketsV2EntityFactory(AccountSecurityTicketsDomainFactories domainFactories)
	{
		if (domainFactories == null)
		{
			throw new PlatformArgumentNullException("domainFactories");
		}
		DomainFactories = domainFactories;
	}

	public IAccountSecurityTicketsV2Entity Create(long accountId)
	{
		AccountSecurityTicketsV2 accountSecurityTicketsV = new AccountSecurityTicketsV2();
		accountSecurityTicketsV.AccountID = accountId;
		accountSecurityTicketsV.Save();
		return CalToCachedMssql(accountSecurityTicketsV);
	}

	public IAccountSecurityTicketsV2Entity Create(long accountId, Guid value)
	{
		AccountSecurityTicketsV2 accountSecurityTicketsV = new AccountSecurityTicketsV2();
		accountSecurityTicketsV.AccountID = accountId;
		accountSecurityTicketsV.Value = value;
		accountSecurityTicketsV.Save();
		return CalToCachedMssql(accountSecurityTicketsV);
	}

	public IAccountSecurityTicketsV2Entity Get(long id)
	{
		return CalToCachedMssql(AccountSecurityTicketsV2.Get(id));
	}

	public IAccountSecurityTicketsV2Entity GetByValue(Guid value)
	{
		return CalToCachedMssql(AccountSecurityTicketsV2.GetByValue(value));
	}

	public IEnumerable<IAccountSecurityTicketsV2Entity> GetByAccountIdAndIsValidEnumerative(long accountId, bool isValid, long count, long exclusiveStartAccountSecurityTicketsV2Id)
	{
		if (count < 1)
		{
			throw new PlatformArgumentException("'count' must be positive");
		}
		return AccountSecurityTicketsV2.GetAccountSecurityTicketsV2ByAccountIDAndIsValid(accountId, isValid, count, exclusiveStartAccountSecurityTicketsV2Id).Select(CalToCachedMssql);
	}

	public long GetTotalByAccountIdAndIsValid(long accountId, bool isValid)
	{
		return AccountSecurityTicketsV2.GetTotalNumberOfAccountSecurityTicketsV2ByAccountIdAndIsValid(accountId, isValid);
	}

	private static IAccountSecurityTicketsV2Entity CalToCachedMssql(AccountSecurityTicketsV2 cal)
	{
		if (cal != null)
		{
			return new AccountSecurityTicketsV2CachedMssqlEntity
			{
				Id = cal.ID,
				Value = cal.Value,
				AccountId = cal.AccountID,
				IsValid = cal.IsValid,
				Created = cal.Created,
				Updated = cal.Updated
			};
		}
		return null;
	}
}
