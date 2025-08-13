using System.Collections.Generic;

namespace Roblox.Platform.Chat.Events;

public class ConversationsMissingInCache
{
	public IReadOnlyCollection<long> MissingConversationIds { get; set; }

	public double MinConversationScoreInRange { get; set; }

	public double MaxConversationScoreInRange { get; set; }

	public ConversationsMissingInCache(IReadOnlyCollection<long> missingConversationIds, double minConversationScoreInRange, double maxConversationScoreInRange)
	{
		MissingConversationIds = missingConversationIds;
		MinConversationScoreInRange = minConversationScoreInRange;
		MaxConversationScoreInRange = maxConversationScoreInRange;
	}
}
