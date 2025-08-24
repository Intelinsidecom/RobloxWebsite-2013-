namespace Roblox.Platform.Social;

/// <summary>
/// Represents a grouping of messages by what kind of message they are according to pre-defined MessageQueryFilter
/// </summary>
public enum MessageTabType
{
	/// <summary>
	/// Messages received in the users inbox.
	/// </summary>
	Inbox,
	/// <summary>
	/// Messages sent by the user.
	/// </summary>
	Sent,
	/// <summary>
	/// Messages the user has archived from their inbox.
	/// </summary>
	Archive
}
