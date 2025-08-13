using System.Collections.Generic;

namespace Roblox.CommunitySift;

internal class CommunitySiftDoubleChatFilterResult : ICommunitySiftDoubleChatFilterResult
{
	public bool PrimaryTextWasFiltered { get; set; }

	public string PrimaryFilteredText { get; set; }

	public HashSet<CommunitySiftModerationTopic> PrimaryFilteredCategories { get; set; }

	public bool SecondaryTextWasFiltered { get; set; }

	public string SecondaryFilteredText { get; set; }

	public HashSet<CommunitySiftModerationTopic> SecondaryFilteredCategories { get; set; }

	public int? Trust { get; set; }
}
