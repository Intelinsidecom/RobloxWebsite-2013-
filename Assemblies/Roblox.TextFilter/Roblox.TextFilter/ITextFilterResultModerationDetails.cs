using System.Collections.Generic;

namespace Roblox.TextFilter;

/// <summary>
/// An interface to represent the details about moderation levels of the filtered text.
/// </summary>
public interface ITextFilterResultModerationDetails
{
	/// <summary>
	/// Gets the moderation level.
	/// </summary>
	/// <value>
	/// The moderation level.
	/// </value>
	ModerationLevel ModerationLevel { get; }

	/// <summary>
	/// Gets the triggered moderation categories.
	/// </summary>
	/// <value>
	/// The triggered moderation categories.
	/// </value>
	HashSet<ModerationCategory> TriggeredModerationCategories { get; }
}
