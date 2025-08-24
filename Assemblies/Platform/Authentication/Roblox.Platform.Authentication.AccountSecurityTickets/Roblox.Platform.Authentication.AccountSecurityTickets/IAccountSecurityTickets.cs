using System;

namespace Roblox.Platform.Authentication.AccountSecurityTickets;

/// <summary>
/// Represents the account security tickets.
/// </summary>
public interface IAccountSecurityTickets
{
	/// <summary>
	/// The entry indicates the Id
	/// </summary>
	long Id { get; }

	/// <summary>
	/// The entry indicates the Value of the ticket
	/// </summary>
	Guid Value { get; }

	/// <summary>
	/// The entry indicates the AccountId of the ticket owner
	/// </summary>
	long AccountId { get; }

	/// <summary>
	/// The entry represents weather the ticket is valid
	/// </summary>
	bool IsValid { get; }
}
