namespace Roblox.Platform.Authentication.AccountSecurityTickets;

/// <summary>
/// Represents the account security ticket item.
/// </summary>
public interface IAccountSecurityTicketItem
{
	/// <summary>
	/// The entry indicates the ticket this item is associated with 
	/// </summary>
	long AccountSecurityTicketsId { get; }

	/// <summary>
	/// The entry indicates the type of item this
	/// </summary>
	short AccountSecurityTypeId { get; }

	/// <summary>
	/// The entry indicates the ticket the target to revert to
	/// </summary>
	long AccountSecurityTargetId { get; }
}
