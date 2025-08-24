using System;
using Roblox.Platform.Core;

namespace Roblox.Platform.Authentication.AccountSecurityTickets;

/// <summary>
/// Represents the account security tickets.
/// </summary>
public class AccountSecurityTickets : IAccountSecurityTickets
{
	/// <summary>
	/// The entry indicates the Id
	/// </summary>
	public long Id { get; }

	/// <summary>
	/// The entry indicates the Value of the ticket
	/// </summary>
	public Guid Value { get; set; }

	/// <summary>
	/// The entry indicates the AccountId of the ticket owner
	/// </summary>
	public long AccountId { get; set; }

	/// <summary>
	/// The entry represents weather the ticket is valid
	/// </summary>
	public bool IsValid { get; set; }

	public AccountSecurityTickets(long id, Guid value, long accountId, bool isValid)
	{
		if (accountId == 0L)
		{
			throw new PlatformArgumentNullException("id");
		}
		Id = id;
		Value = value;
		AccountId = accountId;
		IsValid = isValid;
	}
}
