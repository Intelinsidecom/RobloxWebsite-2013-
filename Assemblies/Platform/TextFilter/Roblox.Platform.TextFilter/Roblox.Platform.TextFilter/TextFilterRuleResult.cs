using System.Collections.Generic;

namespace Roblox.TextFilter;

/// <summary>
/// The result of filtering text for a single moderation rule (eg. under 13)
/// </summary>
internal class TextFilterRuleResult : ITextFilterRuleResult, ITextFilterResultModerationDetails
{
	/// <summary>
	/// The safely filtered text
	/// </summary>
	public string FilteredText { get; set; }

	/// <summary>
	/// The level to which the text had to be moderated to be rendered safe
	/// </summary>
	public ModerationLevel ModerationLevel { get; set; }

	/// <summary>
	/// The categories which were triggered causing the text to be moderated
	/// </summary>
	public HashSet<ModerationCategory> TriggeredModerationCategories { get; set; }
}
