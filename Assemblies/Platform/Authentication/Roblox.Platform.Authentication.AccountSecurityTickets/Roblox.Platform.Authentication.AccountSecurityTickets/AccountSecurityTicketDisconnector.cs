using System;
using System.Collections.Generic;
using System.Linq;

namespace Roblox.Platform.Authentication.AccountSecurityTickets;

/// <summary>
///     Provides functionality that disconnects account security tickets
///     from various information.
/// </summary>
public class AccountSecurityTicketDisconnector : IAccountSecurityTicketDisconnector
{
	private AccountSecurityTicketsDomainFactories _DomainFactories { get; }

	/// <summary>
	///     Initializes a new instance of the <see cref="T:Roblox.Platform.Authentication.AccountSecurityTickets.AccountSecurityTickets" /> class.
	/// </summary>
	/// <param name="domainFactories">The domain factories <see cref="T:Roblox.Platform.Authentication.AccountSecurityTickets.AccountSecurityTicketsDomainFactories" />. </param>
	/// <exception cref="T:System.ArgumentNullException">
	///     <paramref name="domainFactories" />
	/// </exception>
	public AccountSecurityTicketDisconnector(AccountSecurityTicketsDomainFactories domainFactories)
	{
		_DomainFactories = domainFactories ?? throw new ArgumentNullException("domainFactories");
	}

	/// <inheritdoc />
	public void DisconnectSecurityTicketsWithPhoneNumber(long accountId)
	{
		DisconnectSecurityTickets(accountId, AccountSecurityType.PhoneNumber);
	}

	/// <inheritdoc />
	public void DisconnectSecurityTicketsWithEmail(long accountId)
	{
		DisconnectSecurityTickets(accountId, AccountSecurityType.Email);
	}

	/// <summary>
	///     Deletes security tickets and security ticket items that are targeting
	///     specified accountSecurityType.
	/// </summary>
	/// <param name="accountId">Account whose tickets should be deleted.</param>
	/// <param name="accountSecurityType">
	///     Type of security ticket items that should be removed.
	///     <see cref="T:Roblox.Platform.Authentication.AccountSecurityTickets.AccountSecurityType" />
	/// </param>
	private void DisconnectSecurityTickets(long accountId, AccountSecurityType accountSecurityType)
	{
		DisconnectSecurityTickets(accountId, isValid: true, accountSecurityType);
		DisconnectSecurityTickets(accountId, isValid: false, accountSecurityType);
	}

	/// <summary>
	///     Deletes security tickets and their items.
	/// </summary>
	/// <param name="accountId">Account whose security tickets should be deleted.</param>
	/// <param name="isValid">Flag indicating whether to target only valid or invalid tickets.</param>
	/// <param name="accountSecurityType">Type of security ticket items to delete. <see cref="T:Roblox.Platform.Authentication.AccountSecurityTickets.AccountSecurityType" /></param>
	private void DisconnectSecurityTickets(long accountId, bool isValid, AccountSecurityType accountSecurityType)
	{
		int batchSize = _DomainFactories.Settings.AccountSecurityTicketsPageSize;
		long startId = 0L;
		List<IAccountSecurityTicketsV2Entity> tickets = _DomainFactories.AccountSecurityTicketsV2EntityFactory.GetByAccountIdAndIsValidEnumerative(accountId, isValid, batchSize, startId)?.ToList();
		while (tickets != null && tickets.Any())
		{
			foreach (IAccountSecurityTicketsV2Entity securityTicket in tickets)
			{
				DeleteSecurityTicketItems(securityTicket.Id, accountSecurityType);
			}
			startId = tickets.Last().Id;
			tickets = _DomainFactories.AccountSecurityTicketsV2EntityFactory.GetByAccountIdAndIsValidEnumerative(accountId, isValid, batchSize, startId)?.ToList();
		}
	}

	/// <summary>
	///     Deletes all security ticket items of specific type id and related to specified ticket id.
	/// </summary>
	/// <param name="securityTicketId">Security ticket that should be deleted.</param>
	/// <param name="accountSecurityType">Type of security ticket items to delete. <see cref="T:Roblox.Platform.Authentication.AccountSecurityTickets.AccountSecurityType" /></param>
	private void DeleteSecurityTicketItems(long securityTicketId, AccountSecurityType accountSecurityType)
	{
		long startId = 0L;
		int batchSize = _DomainFactories.Settings.AccountSecurityTicketItemsPageSize;
		List<IAccountSecurityTicketItemEntity> ticketItems = _DomainFactories.AccountSecurityTicketItemEntityFactory.GetByAccountSecurityTicketsIdEnumerative(securityTicketId, batchSize, startId)?.ToList();
		while (ticketItems != null && ticketItems.Any())
		{
			foreach (IAccountSecurityTicketItemEntity item in ticketItems.Where((IAccountSecurityTicketItemEntity tItem) => tItem.AccountSecurityTypeId == (short)accountSecurityType))
			{
				item.Delete();
			}
			startId = ticketItems.Last().Id;
			ticketItems = _DomainFactories.AccountSecurityTicketItemEntityFactory.GetByAccountSecurityTicketsIdEnumerative(securityTicketId, batchSize, startId)?.ToList();
		}
	}
}
