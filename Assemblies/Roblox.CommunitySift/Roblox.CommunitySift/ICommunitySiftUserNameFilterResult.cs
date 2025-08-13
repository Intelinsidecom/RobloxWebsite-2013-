using System.Collections.Generic;

namespace Roblox.CommunitySift;

/// <summary>
/// Result of a UserName request.
/// </summary>
public interface ICommunitySiftUserNameFilterResult
{
	/// <summary>
	/// Indicates if the text was filtered for 13+ users.
	/// </summary>
	bool IsPrimaryTextFiltered { get; }

	/// <summary>
	/// The new value of the text with hashes for 13+ users.
	/// Null otherwise.
	/// </summary>
	string PrimaryFilteredText { get; }

	/// <summary>
	/// Indicates if the was filtered for U13 users.
	/// </summary>
	bool IsSecondaryTextFiltered { get; }

	/// <summary>
	/// The new value of the text with hashes for U13 users.
	/// Null otherwise.
	/// </summary>
	string SecondaryFilteredText { get; }

	/// <summary>
	/// The Community Sift Moderation Topics that caused the text to be filtered.
	/// </summary>
	HashSet<CommunitySiftModerationTopic> FilteredCategories { get; set; }
}
