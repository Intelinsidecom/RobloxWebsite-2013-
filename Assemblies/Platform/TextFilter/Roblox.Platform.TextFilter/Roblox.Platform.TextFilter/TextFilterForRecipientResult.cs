using System.Collections.Generic;

namespace Roblox.TextFilter;

internal class TextFilterForRecipientResult : ITextFilterRuleResult, ITextFilterResultModerationDetails
{
	public string FilteredText { get; }

	public ModerationLevel ModerationLevel { get; }

	public HashSet<ModerationCategory> TriggeredModerationCategories { get; } = new HashSet<ModerationCategory>();


	public TextFilterForRecipientResult(string text, ModerationLevel moderationLevel)
	{
		FilteredText = text;
		ModerationLevel = moderationLevel;
	}
}
