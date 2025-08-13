using System.Collections.Generic;
using Roblox.Platform.Core;

namespace Roblox.Platform.Authentication.AccountSecurityTickets;

internal interface IAccountSecurityTicketItemEntityFactory : IDomainFactory<AccountSecurityTicketsDomainFactories>, IDomainObject<AccountSecurityTicketsDomainFactories>
{
	/// <summary>
	/// Creates and persists a new <see cref="T:Roblox.Platform.Authentication.AccountSecurityTickets.IAccountSecurityTicketItemEntity" /> with the given account ID.
	/// </summary>
	/// <param name="accountSecurityTicketId">The account security ticket ID.</param>
	/// <param name="accountSecurityTargetId">The account security target ID.</param>
	/// <param name="accountSecurityTypeId">he account security type ID.</param>
	/// <returns>The created <see cref="T:Roblox.Platform.Authentication.AccountSecurityTickets.IAccountSecurityTicketItemEntity" />.</returns>
	IAccountSecurityTicketItemEntity Create(long accountSecurityTicketId, long accountSecurityTargetId, short accountSecurityTypeId);

	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.Authentication.AccountSecurityTickets.IAccountSecurityTicketItemEntity" /> by its ID.
	/// </summary>
	/// <param name="id">The ID.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Authentication.AccountSecurityTickets.IAccountSecurityTicketItemEntity" /> with the given ID, or null if none existed.</returns>
	IAccountSecurityTicketItemEntity Get(long id);

	/// <summary>
	/// Gets a page of <see cref="T:Roblox.Platform.Authentication.AccountSecurityTickets.IAccountSecurityTicketItemEntity" />s by their account security tickets ID
	/// </summary>
	/// <param name="accountSecurityTicketId">The account security ID.</param>
	/// <param name="count">The number of entities to get.</param>
	/// <param name="exclusiveStartAccountSecurityTicketItemId">The exclusive key at which to begin getting entities.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="count" /> is non-positive.</exception>
	/// <returns>The page of <see cref="T:Roblox.Platform.Authentication.AccountSecurityTickets.IAccountSecurityTicketItemEntity" />s.</returns>
	IEnumerable<IAccountSecurityTicketItemEntity> GetByAccountSecurityTicketsIdEnumerative(long accountSecurityTicketId, int count, long exclusiveStartAccountSecurityTicketItemId);

	/// <summary>
	/// Gets the total number of <see cref="T:Roblox.Platform.Authentication.AccountSecurityTickets.IAccountSecurityTicketItemEntity" />s with the given accountSecurityTicketId
	/// </summary>
	/// <param name="accountSecurityTicketId">The account security ID.</param>
	/// <returns>The total number of <see cref="T:Roblox.Platform.Authentication.AccountSecurityTickets.IAccountSecurityTicketItemEntity" />s with the given accountSecurityTicketId.</returns>
	int GetTotalByAccountSecurityTicketId(long accountSecurityTicketId);
}
