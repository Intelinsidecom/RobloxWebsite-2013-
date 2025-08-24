using System.Collections.Generic;
using Roblox.Platform.Core;

namespace Roblox.Platform.Authentication.AccountSecurityTickets.Interfaces.Factories;

/// <summary>
/// Provides common functions for account security ticket items
/// </summary>
internal interface IAccountSecurityTicketItemFactory : IDomainObject<AccountSecurityTicketsDomainFactories>
{
	/// <summary>
	/// Creates a <see cref="T:Roblox.Platform.Authentication.AccountSecurityTickets.IAccountSecurityTicketItem" />.
	/// </summary>
	/// <param name="accountSecurityTicketId">The account security ticket ID.</param>
	/// <param name="accountSecurityTargetId">The account security target ID.</param>
	/// <param name="accountSecurityTypeId">The account security type ID.</param>
	void CreateEntry(long accountSecurityTicketId, long accountSecurityTargetId, short accountSecurityTypeId);

	/// <summary>
	/// Gets the total number of <see cref="T:Roblox.Platform.Authentication.AccountSecurityTickets.IAccountSecurityTicketItemEntity" />s with the given accountSecurityTicketId
	/// </summary>
	/// <param name="accountSecurityTicketId">The account security ID.</param>
	/// <param name="count">The maximum number to be returned.</param>
	/// <param name="exclusiveStartAccountSecurityTicketItemId">The exclusiveStartAccountSecurityTicketItemId to start pulling from.</param>
	/// <returns>The total number of <see cref="T:Roblox.Platform.Authentication.AccountSecurityTickets.IAccountSecurityTicketItemEntity" />s with the given accountSecurityTicketId.</returns>
	IEnumerable<IAccountSecurityTicketItemEntity> GetByAccountSecurityTicketsIdEnumerative(long accountSecurityTicketId, int count, long exclusiveStartAccountSecurityTicketItemId);
}
