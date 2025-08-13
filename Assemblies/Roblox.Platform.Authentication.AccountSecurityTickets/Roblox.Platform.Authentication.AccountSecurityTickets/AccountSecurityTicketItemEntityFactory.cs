using System.Collections.Generic;
using System.Linq;
using Roblox.Platform.Authentication.AccountSecurityTickets.Entities;
using Roblox.Platform.Core;

namespace Roblox.Platform.Authentication.AccountSecurityTickets;

internal class AccountSecurityTicketItemEntityFactory : IAccountSecurityTicketItemEntityFactory, IDomainFactory<AccountSecurityTicketsDomainFactories>, IDomainObject<AccountSecurityTicketsDomainFactories>
{
	public AccountSecurityTicketsDomainFactories DomainFactories { get; }

	public AccountSecurityTicketItemEntityFactory(AccountSecurityTicketsDomainFactories domainFactories)
	{
		if (domainFactories == null)
		{
			throw new PlatformArgumentNullException("domainFactories");
		}
		DomainFactories = domainFactories;
	}

	public IAccountSecurityTicketItemEntity Create(long accountSecurityTicketId, long accountSecurityTargetId, short accountSecurityTypeId)
	{
		Roblox.Platform.Authentication.AccountSecurityTickets.Entities.AccountSecurityTicketItem accountSecurityTicketItem = new Roblox.Platform.Authentication.AccountSecurityTickets.Entities.AccountSecurityTicketItem();
		accountSecurityTicketItem.AccountSecurityTicketID = accountSecurityTicketId;
		accountSecurityTicketItem.AccountSecurityTargetID = accountSecurityTargetId;
		accountSecurityTicketItem.AccountSecurityTypeID = accountSecurityTypeId;
		accountSecurityTicketItem.Save();
		return CalToCachedMssql(accountSecurityTicketItem);
	}

	public IAccountSecurityTicketItemEntity Get(long id)
	{
		return CalToCachedMssql(Roblox.Platform.Authentication.AccountSecurityTickets.Entities.AccountSecurityTicketItem.Get(id));
	}

	public IEnumerable<IAccountSecurityTicketItemEntity> GetByAccountSecurityTicketsIdEnumerative(long accountSecurityTicketId, int count, long exclusiveStartAccountSecurityTicketItemId)
	{
		if (count < 1)
		{
			throw new PlatformArgumentException("'count' must be positive");
		}
		return Roblox.Platform.Authentication.AccountSecurityTickets.Entities.AccountSecurityTicketItem.GetAccountSecurityTicketItemsByAccountSecurityTicketID(accountSecurityTicketId, count, exclusiveStartAccountSecurityTicketItemId).Select(CalToCachedMssql);
	}

	public int GetTotalByAccountSecurityTicketId(long accountSecurityTicketId)
	{
		return Roblox.Platform.Authentication.AccountSecurityTickets.Entities.AccountSecurityTicketItem.GetTotalNumberOfAccountSecurityTicketItemsByAccountSecurityTicketId(accountSecurityTicketId);
	}

	private static IAccountSecurityTicketItemEntity CalToCachedMssql(Roblox.Platform.Authentication.AccountSecurityTickets.Entities.AccountSecurityTicketItem cal)
	{
		if (cal != null)
		{
			return new AccountSecurityTicketItemCachedMssqlEntity
			{
				Id = cal.ID,
				AccountSecurityTicketsId = cal.AccountSecurityTicketID,
				AccountSecurityTypeId = cal.AccountSecurityTypeID,
				AccountSecurityTargetId = cal.AccountSecurityTargetID,
				Created = cal.Created,
				Updated = cal.Updated
			};
		}
		return null;
	}
}
