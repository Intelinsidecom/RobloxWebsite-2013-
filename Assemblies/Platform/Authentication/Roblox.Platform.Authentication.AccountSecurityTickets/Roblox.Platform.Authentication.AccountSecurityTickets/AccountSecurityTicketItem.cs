namespace Roblox.Platform.Authentication.AccountSecurityTickets;

/// <summary>
/// Represents the account security ticket item.
/// </summary>
public class AccountSecurityTicketItem : IAccountSecurityTicketItem
{
	/// <summary>
	/// The entry indicates the ticket this item is associated with 
	/// </summary>
	public long AccountSecurityTicketsId { get; }

	/// <summary>
	/// The entry indicates the type of item this
	/// </summary>
	public short AccountSecurityTypeId { get; }

	/// <summary>
	/// The entry indicates the ticket the target to revert to
	/// </summary>
	public long AccountSecurityTargetId { get; }

	public AccountSecurityTicketItem(long accountSecurityTicketsId, short accountSecurityTypeId, long accountSecurityTargetId)
	{
		AccountSecurityTicketsId = accountSecurityTicketsId;
		AccountSecurityTypeId = accountSecurityTypeId;
		AccountSecurityTargetId = accountSecurityTargetId;
	}
}
