using System.Collections.Generic;

namespace Roblox.CommunitySift;

/// <summary>
/// Result of a long text request
/// </summary>
public interface ICommunitySiftLongTextFilterResult
{
	/// <summary>
	/// Indicates that the text was filtered.
	/// </summary>
	bool TextWasFiltered { get; }

	/// <summary>
	/// Value of the filtered text.
	/// Will be null if the text was not filtered.
	/// </summary>
	string FilteredText { get; }

	/// <summary>
	/// The Community Sift Moderation Topics that caused the text to be filtered.
	/// </summary>
	HashSet<CommunitySiftModerationTopic> FilteredCategories { get; }
}
