using System.Collections.Generic;

namespace Roblox.CommunitySift;

public class CommunitySiftChatFilterNoContextResult : ICommunitySiftChatFilterNoContextResult
{
	public bool TextWasFiltered { get; set; }

	public string FilteredText { get; set; }

	public HashSet<CommunitySiftModerationTopic> FilteredCategories { get; set; }
}
