namespace Roblox.Platform.Social;

/// <summary>
/// Represents a set of filters for querying messages.
/// </summary>
public class MessageQueryFilterSet
{
	/// <summary>
	/// Represents a filter on querying messages based off whether the message is archived or not.
	/// </summary>
	public enum ArchiveQueryFilter
	{
		/// <summary>
		/// The query should only get archived messages.
		/// </summary>
		ArchivedOnly,
		/// <summary>
		/// The query should only get unarchived messages.
		/// </summary>
		UnarchivedOnly,
		/// <summary>
		/// The query should get both archived and unarchived messages.
		/// </summary>
		Both
	}

	/// <summary>
	/// Represents a filter on querying messages based off whether the message is read or not.
	/// </summary>
	public enum ReadQueryFilter
	{
		/// <summary>
		/// The query should only get read messages.
		/// </summary>
		ReadOnly,
		/// <summary>
		/// The query should only get unread messages.
		/// </summary>
		UnreadOnly,
		/// <summary>
		/// The query should get both read and unread messages.
		/// </summary>
		Both
	}

	/// <summary>
	/// Represents a filter on querying messages based off whether the message is a system message or not.
	/// </summary>
	public enum SystemMessageQueryFilter
	{
		/// <summary>
		/// The query should only get system messages.
		/// </summary>
		SystemOnly,
		/// <summary>
		/// The query should only get user messages.
		/// </summary>
		UserOnly,
		/// <summary>
		/// The query should get both system and user messages.
		/// </summary>
		Both
	}

	/// <summary>
	/// Represents a filter on querying messages based off whether the message is an invitation or not.
	/// </summary>
	public enum InvitationQueryFilter
	{
		/// <summary>
		/// The query should only get invitation messages.
		/// </summary>
		InvitationsOnly,
		/// <summary>
		/// The query should only get non-invitation messages.
		/// </summary>
		NoInvitations,
		/// <summary>
		/// The query should get both invitation and non-invitation messages.
		/// </summary>
		Both
	}

	/// <summary>
	/// The ArchiveQueryFilter to filter the query by.
	/// </summary>
	public ArchiveQueryFilter ArchiveFilter { get; set; }

	/// <summary>
	/// The ReadQueryFilter to filter the query by.
	/// </summary>
	public ReadQueryFilter ReadFilter { get; set; }

	/// <summary>
	/// The SystemMessageQueryFilter to filter the query by.
	/// </summary>
	public SystemMessageQueryFilter SystemMessageFilter { get; set; }

	/// <summary>
	/// The InvitationQueryFilter to filter the query by.
	/// </summary>
	public InvitationQueryFilter InvitationFilter { get; set; }
}
