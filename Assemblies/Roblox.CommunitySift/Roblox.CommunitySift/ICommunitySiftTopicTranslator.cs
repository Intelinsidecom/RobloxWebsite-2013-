using System.Collections.Generic;

namespace Roblox.CommunitySift;

/// <summary>
/// Converts the Community Sift Topic IDs that are returned in filter calls to an enum value
/// </summary>
internal interface ICommunitySiftTopicTranslator
{
	HashSet<CommunitySiftModerationTopic> ExtractFilteredTopics(Dictionary<int, int> topicIdsAndScores, bool isUnder13);

	CommunitySiftModerationTopic? TranslateTopicIdToEnum(int topicId);
}
