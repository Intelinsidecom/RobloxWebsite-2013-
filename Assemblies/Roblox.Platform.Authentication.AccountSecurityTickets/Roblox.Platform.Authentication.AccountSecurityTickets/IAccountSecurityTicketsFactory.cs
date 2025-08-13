using System;
using Roblox.Platform.Core;

namespace Roblox.Platform.Authentication.AccountSecurityTickets;

public interface IAccountSecurityTicketsFactory : IDomainObject<AccountSecurityTicketsDomainFactories>
{
	/// <summary>
	/// Creates a <see cref="T:Roblox.Platform.Authentication.AccountSecurityTickets.IAccountSecurityTicketsV2Entity" />.
	/// </summary>
	/// <param name="accountId">The account ID.</param>
	/// <param name="value">The value.</param>
	/// <returns>The created <see cref="T:Roblox.Platform.Authentication.AccountSecurityTickets.IAccountSecurityTicketsV2Entity" />.</returns>
	IAccountSecurityTicketsV2Entity CreateEntry(long accountId, Guid value);

	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.Authentication.AccountSecurityTickets.IAccountSecurityTicketsV2Entity" /> by its value.
	/// </summary>
	/// <param name="value">The value.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Authentication.AccountSecurityTickets.IAccountSecurityTicketsV2Entity" /> with the given value, or null if none existed.</returns>
	IAccountSecurityTicketsV2Entity GetByValue(Guid value);

	/// <summary>
	/// Creates AccountSecurityTicketItems linked to the supplied Guid 
	/// </summary>
	/// <param name="accountId">The accountId of the user.</param>
	/// <param name="value">The Guid of the ticket to attach to the item.</param>
	/// <param name="accountEmailAddress">The account email address to create a ticket for.</param>
	/// <param name="accountPassword">The account password to create a ticket for.</param>
	/// <param name="accountPhoneNumber">The account phone number to create a ticket for.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="value" /> is null.</exception>
	void CreateAccountSecurityTickets(long accountId, Guid value, long accountEmailAddress, long? accountPassword = null, long? accountPhoneNumber = null);

	/// <summary>
	/// Gets a <see cref="T:Roblox.Platform.Authentication.AccountSecurityTickets.AccountSecurityTickets" /> by it's GUID, null otherwise
	/// </summary>
	/// <param name="value">The Guid of the ticket.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="value" /> is null.</exception>
	/// <returns>A <see cref="T:Roblox.Platform.Authentication.AccountSecurityTickets.AccountSecurityTickets" />.</returns>
	AccountSecurityTickets Get(Guid value);

	/// <summary>
	/// Invalidates all new valid security tickets from the inputted exclusiveStartAccountSecurityTicketsV2Id
	/// </summary>
	/// <param name="accountId">The account id to get this from.</param>
	/// <param name="exclusiveStartAccountSecurityTicketsV2Id">The exclusive key at which to begin getting entities.</param>
	void InvalidateCurrentAndNewerAccountSecurityTickets(long accountId, long exclusiveStartAccountSecurityTicketsV2Id);
}
