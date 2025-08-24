using System.Collections.Generic;

namespace Roblox.CommunitySift;

internal class CommunitySiftUserNameFilterResult : ICommunitySiftUserNameFilterResult
{
	public bool IsPrimaryTextFiltered { get; set; }

	public string PrimaryFilteredText { get; set; }

	public bool IsSecondaryTextFiltered { get; set; }

	public string SecondaryFilteredText { get; set; }

	public HashSet<CommunitySiftModerationTopic> FilteredCategories { get; set; }
}
