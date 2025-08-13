using System.Collections.Generic;
using System.Linq;
using Roblox.Platform.Core;

namespace Roblox.Platform.Authentication.AccountSecurityTickets;

public class AccountSecurityTicketItemFactory : IDomainObject<AccountSecurityTicketsDomainFactories>
{
	public AccountSecurityTicketsDomainFactories DomainFactories { get; }

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.Authentication.AccountSecurityTickets.AccountSecurityTicketItem" /> class.
	/// </summary>
	/// <param name="domainFactories">The domain factories.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">
	///     <paramref name="domainFactories" />
	/// </exception>
	public AccountSecurityTicketItemFactory(AccountSecurityTicketsDomainFactories domainFactories)
	{
		if (domainFactories == null)
		{
			throw new PlatformArgumentNullException("domainFactories");
		}
		DomainFactories = domainFactories;
	}

	/// <summary>
	/// Creates a <see cref="T:Roblox.Platform.Authentication.AccountSecurityTickets.IAccountSecurityTicketItem" />.
	/// </summary>
	/// <param name="accountSecurityTicketId">The account security ticket ID.</param>
	/// <param name="accountSecurityTargetId">The account security target ID.</param>
	/// <param name="accountSecurityTypeId">The account security type ID.</param>
	public void CreateEntry(long accountSecurityTicketId, long accountSecurityTargetId, short accountSecurityTypeId)
	{
		DomainFactories.AccountSecurityTicketItemEntityFactory.Create(accountSecurityTicketId, accountSecurityTargetId, accountSecurityTypeId);
	}

	/// <summary>
	/// Gets a page of <see cref="T:Roblox.Platform.Authentication.AccountSecurityTickets.IAccountSecurityTicketItem" />s by their account security tickets ID
	/// </summary>
	/// <param name="accountSecurityTicketId">The account security ID.</param>
	/// <returns>The page of <see cref="T:Roblox.Platform.Authentication.AccountSecurityTickets.IAccountSecurityTicketItemEntity" />s.</returns>
	public IEnumerable<IAccountSecurityTicketItem> GetByAccountSecurityTicketsIdEnumerative(long accountSecurityTicketId)
	{
		return DomainFactories.AccountSecurityTicketItemEntityFactory.GetByAccountSecurityTicketsIdEnumerative(accountSecurityTicketId, DomainFactories.AccountSecurityTicketItemEntityFactory.GetTotalByAccountSecurityTicketId(accountSecurityTicketId), 0L).Select(BllToPlatform);
	}

	private AccountSecurityTicketItem BllToPlatform(IAccountSecurityTicketItemEntity accountSecurityTickets)
	{
		if (accountSecurityTickets != null)
		{
			return new AccountSecurityTicketItem(accountSecurityTickets.AccountSecurityTicketsId, accountSecurityTickets.AccountSecurityTypeId, accountSecurityTickets.AccountSecurityTargetId);
		}
		return null;
	}
}
