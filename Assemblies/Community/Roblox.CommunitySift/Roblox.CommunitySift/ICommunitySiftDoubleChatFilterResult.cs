using System.Collections.Generic;

namespace Roblox.CommunitySift;

/// <summary>
/// Result of a double chat request.
/// </summary>
public interface ICommunitySiftDoubleChatFilterResult
{
	/// <summary>
	/// Indicates if the text was filtered for 13+ users.
	/// </summary>
	bool PrimaryTextWasFiltered { get; }

	/// <summary>
	/// The new value of the text with hashes for 13+ users.
	/// Null otherwise.
	/// </summary>
	string PrimaryFilteredText { get; }

	/// <summary>
	/// The list of Community Sift Moderation Topics that caused the text to be filtered for 13+ users.
	/// </summary>
	HashSet<CommunitySiftModerationTopic> PrimaryFilteredCategories { get; }

	/// <summary>
	/// Indicates if the was filtered for U13 users.
	/// </summary>
	bool SecondaryTextWasFiltered { get; }

	/// <summary>
	/// The new value of the text with hashes for U13 users.
	/// Null otherwise.
	/// </summary>
	string SecondaryFilteredText { get; }

	/// <summary>
	/// The list of Community Sift Moderation Topics that caused the text to be filtered for U13 users.
	/// </summary>
	HashSet<CommunitySiftModerationTopic> SecondaryFilteredCategories { get; }

	/// <summary>Trust level assigned to the user </summary>
	/// <remarks>0=full trust to 7=no trust</remarks>
	int? Trust { get; }
}
