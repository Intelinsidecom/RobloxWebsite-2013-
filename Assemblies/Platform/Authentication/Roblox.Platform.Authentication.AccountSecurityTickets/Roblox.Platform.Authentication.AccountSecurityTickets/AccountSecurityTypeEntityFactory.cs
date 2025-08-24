using Roblox.Platform.Authentication.AccountSecurityTickets.Entities;
using Roblox.Platform.Core;

namespace Roblox.Platform.Authentication.AccountSecurityTickets;

internal class AccountSecurityTypeEntityFactory : IAccountSecurityTypeEntityFactory, IDomainFactory<AccountSecurityTicketsDomainFactories>, IDomainObject<AccountSecurityTicketsDomainFactories>
{
	public AccountSecurityTicketsDomainFactories DomainFactories { get; }

	public AccountSecurityTypeEntityFactory(AccountSecurityTicketsDomainFactories domainFactories)
	{
		if (domainFactories == null)
		{
			throw new PlatformArgumentNullException("domainFactories");
		}
		DomainFactories = domainFactories;
	}

	public IAccountSecurityTypeEntity Get(short id)
	{
		return CalToCachedMssql(Roblox.Platform.Authentication.AccountSecurityTickets.Entities.AccountSecurityType.Get(id));
	}

	public IAccountSecurityTypeEntity GetByValue(string value)
	{
		if (value == null)
		{
			throw new PlatformArgumentNullException("value");
		}
		return CalToCachedMssql(Roblox.Platform.Authentication.AccountSecurityTickets.Entities.AccountSecurityType.GetByValue(value));
	}

	private static IAccountSecurityTypeEntity CalToCachedMssql(Roblox.Platform.Authentication.AccountSecurityTickets.Entities.AccountSecurityType cal)
	{
		if (cal != null)
		{
			return new AccountSecurityTypeCachedMssqlEntity
			{
				Id = cal.ID,
				Value = cal.Value,
				Created = cal.Created,
				Updated = cal.Updated
			};
		}
		return null;
	}
}
