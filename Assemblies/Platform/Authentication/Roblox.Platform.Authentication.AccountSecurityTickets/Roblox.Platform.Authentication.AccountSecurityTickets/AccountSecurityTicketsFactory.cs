using System;
using Roblox.Platform.Core;

namespace Roblox.Platform.Authentication.AccountSecurityTickets;

public class AccountSecurityTicketsFactory : IAccountSecurityTicketsFactory, IDomainObject<AccountSecurityTicketsDomainFactories>
{
	public AccountSecurityTicketsDomainFactories DomainFactories { get; }

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.Authentication.AccountSecurityTickets.AccountSecurityTickets" /> class.
	/// </summary>
	/// <param name="domainFactories">The domain factories.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">
	///     <paramref name="domainFactories" />
	/// </exception>
	public AccountSecurityTicketsFactory(AccountSecurityTicketsDomainFactories domainFactories)
	{
		if (domainFactories == null)
		{
			throw new PlatformArgumentNullException("domainFactories");
		}
		DomainFactories = domainFactories;
	}

	/// <inheritdoc cref="M:Roblox.Platform.Authentication.AccountSecurityTickets.IAccountSecurityTicketsFactory.CreateEntry(System.Int64,System.Guid)" />
	private void CreateEntry(long accountId)
	{
		DomainFactories.AccountSecurityTicketsV2EntityFactory.Create(accountId, Guid.NewGuid());
	}

	/// <inheritdoc cref="M:Roblox.Platform.Authentication.AccountSecurityTickets.IAccountSecurityTicketsFactory.CreateEntry(System.Int64,System.Guid)" />
	public IAccountSecurityTicketsV2Entity CreateEntry(long accountId, Guid value)
	{
		return DomainFactories.AccountSecurityTicketsV2EntityFactory.Create(accountId, value);
	}

	/// <inheritdoc cref="M:Roblox.Platform.Authentication.AccountSecurityTickets.IAccountSecurityTicketsFactory.GetByValue(System.Guid)" />
	public IAccountSecurityTicketsV2Entity GetByValue(Guid value)
	{
		return DomainFactories.AccountSecurityTicketsV2EntityFactory.GetByValue(value);
	}

	/// <summary>
	/// Invalidates all new valid security tickets from the inputted exclusiveStartAccountSecurityTicketsV2Id
	/// </summary>
	/// <param name="accountId">The account id to get this from.</param>
	/// <param name="exclusiveStartAccountSecurityTicketsV2Id">The exclusive key at which to begin getting entities.</param>
	public void InvalidateCurrentAndNewerAccountSecurityTickets(long accountId, long exclusiveStartAccountSecurityTicketsV2Id)
	{
		long totalNumberOfValidAccountSecurityTickets = DomainFactories.AccountSecurityTicketsV2EntityFactory.GetTotalByAccountIdAndIsValid(accountId, isValid: true);
		foreach (IAccountSecurityTicketsV2Entity item in DomainFactories.AccountSecurityTicketsV2EntityFactory.GetByAccountIdAndIsValidEnumerative(accountId, isValid: true, totalNumberOfValidAccountSecurityTickets, exclusiveStartAccountSecurityTicketsV2Id))
		{
			item.IsValid = false;
			item.Update();
		}
		IAccountSecurityTicketsV2Entity accountSecurityTicketsV2Entity = DomainFactories.AccountSecurityTicketsV2EntityFactory.Get(exclusiveStartAccountSecurityTicketsV2Id);
		accountSecurityTicketsV2Entity.IsValid = false;
		accountSecurityTicketsV2Entity.Update();
	}

	/// <summary>
	/// Creates AccountSecurityTicketItems linked to the supplied Guid 
	/// </summary>
	/// <param name="accountId">The accountId of the user.</param>
	/// <param name="value">The Guid of the ticket to attach to the item.</param>
	/// <param name="accountEmailAddressId">The account email address to create a ticket for.</param>
	/// <param name="accountPasswordId">The account password to create a ticket for.</param>
	/// <param name="phoneNumberId">The phone number to create a ticket for.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="value" /> is null.</exception>
	public void CreateAccountSecurityTickets(long accountId, Guid value, long accountEmailAddressId, long? accountPasswordId = null, long? phoneNumberId = null)
	{
		IAccountSecurityTicketsV2Entity accountSecurityTicketsV2 = DomainFactories.AccountSecurityTicketsV2EntityFactory.Create(accountId, value);
		DomainFactories.AccountSecurityTicketItemEntityFactory.Create(accountSecurityTicketsV2.Id, accountEmailAddressId, 1);
		if (accountPasswordId.HasValue)
		{
			DomainFactories.AccountSecurityTicketItemEntityFactory.Create(accountSecurityTicketsV2.Id, accountPasswordId.Value, 2);
		}
		if (phoneNumberId.HasValue)
		{
			DomainFactories.AccountSecurityTicketItemEntityFactory.Create(accountSecurityTicketsV2.Id, phoneNumberId.Value, 3);
		}
	}

	/// <summary>
	/// Gets a <see cref="T:Roblox.Platform.Authentication.AccountSecurityTickets.AccountSecurityTickets" /> by it's GUID, null otherwise
	/// </summary>
	/// <param name="value">The Guid of the ticket.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="value" /> is null.</exception>
	/// <returns>A <see cref="T:Roblox.Platform.Authentication.AccountSecurityTickets.AccountSecurityTickets" />.</returns>
	public AccountSecurityTickets Get(Guid value)
	{
		IAccountSecurityTicketsV2Entity accountSecurityTicketsV2 = DomainFactories.AccountSecurityTicketsV2EntityFactory.GetByValue(value);
		return BllToPlatform(accountSecurityTicketsV2);
	}

	private AccountSecurityTickets BllToPlatform(IAccountSecurityTicketsV2Entity accountSecurityTickets)
	{
		if (accountSecurityTickets != null)
		{
			return new AccountSecurityTickets(accountSecurityTickets.Id, accountSecurityTickets.Value, accountSecurityTickets.AccountId, accountSecurityTickets.IsValid);
		}
		return null;
	}
}
