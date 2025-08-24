using System;
using System.Collections.Generic;
using Roblox.Platform.Core;

namespace Roblox.Platform.Authentication.AccountSecurityTickets;

internal interface IAccountSecurityTicketsV2EntityFactory : IDomainFactory<AccountSecurityTicketsDomainFactories>, IDomainObject<AccountSecurityTicketsDomainFactories>
{
	/// <summary>
	/// Creates and persists a new <see cref="T:Roblox.Platform.Authentication.AccountSecurityTickets.IAccountSecurityTicketsV2Entity" /> with the given account ID.
	/// </summary>
	/// <param name="accountId">The account ID.</param>
	/// <returns>The created <see cref="T:Roblox.Platform.Authentication.AccountSecurityTickets.IAccountSecurityTicketsV2Entity" /></returns>
	IAccountSecurityTicketsV2Entity Create(long accountId);

	/// <summary>
	/// Creates and persists a new <see cref="T:Roblox.Platform.Authentication.AccountSecurityTickets.IAccountSecurityTicketsV2Entity" /> with the given account ID.
	/// </summary>
	/// <param name="accountId">The account ID.</param>
	/// <param name="value">The value.</param>
	/// <returns>The created <see cref="T:Roblox.Platform.Authentication.AccountSecurityTickets.IAccountSecurityTicketsV2Entity" /></returns>
	IAccountSecurityTicketsV2Entity Create(long accountId, Guid value);

	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.Authentication.AccountSecurityTickets.IAccountSecurityTicketsV2Entity" /> by its ID.
	/// </summary>
	/// <param name="id">The ID.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Authentication.AccountSecurityTickets.IAccountSecurityTicketsV2Entity" /> with the given ID, or null if none existed.</returns>
	IAccountSecurityTicketsV2Entity Get(long id);

	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.Authentication.AccountSecurityTickets.IAccountSecurityTicketsV2Entity" /> by its value.
	/// </summary>
	/// <param name="value">The value.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Authentication.AccountSecurityTickets.IAccountSecurityTicketsV2Entity" /> with the given value, or null if none existed.</returns>
	IAccountSecurityTicketsV2Entity GetByValue(Guid value);

	/// <summary>
	/// Gets a page of <see cref="T:Roblox.Platform.Authentication.AccountSecurityTickets.IAccountSecurityTicketsV2Entity" />s by their accountId and isValid
	/// </summary>
	/// <param name="accountId">The account id to get this from.</param>
	/// <param name="isValid">if the entiries will be valid.</param>
	/// <param name="count">The number of entities to get.</param>
	/// <param name="exclusiveStartAccountSecurityTicketsV2Id">The exclusive key at which to begin getting entities.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="count" /> is non-positive.</exception>
	/// <returns>The page of <see cref="T:Roblox.Platform.Authentication.AccountSecurityTickets.IAccountSecurityTicketsV2Entity" />s.</returns>
	IEnumerable<IAccountSecurityTicketsV2Entity> GetByAccountIdAndIsValidEnumerative(long accountId, bool isValid, long count, long exclusiveStartAccountSecurityTicketsV2Id);

	/// <summary>
	/// Gets the total number of <see cref="T:Roblox.Platform.Authentication.AccountSecurityTickets.IAccountSecurityTicketsV2Entity" />s with the given accountId and whether it isValid
	/// </summary>
	/// <param name="accountId">The account id to get this from.</param>
	/// <param name="isValid">if the entiries will be valid.</param>
	/// <returns>The total number of <see cref="T:Roblox.Platform.Authentication.AccountSecurityTickets.IAccountSecurityTicketsV2Entity" />s with the given accountId and whether it isValid.</returns>
	long GetTotalByAccountIdAndIsValid(long accountId, bool isValid);
}
