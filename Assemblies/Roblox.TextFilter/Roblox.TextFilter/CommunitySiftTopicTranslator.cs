using System.Collections.Generic;
using Roblox.CommunitySift;

namespace Roblox.TextFilter;

/// <summary>
/// Translates Community Sift specific moderation topics into standardised Roblox topics
/// </summary>
internal static class CommunitySiftTopicTranslator
{
	public static HashSet<ModerationCategory> TranslateInfringingCategories(HashSet<CommunitySiftModerationTopic> returnedTopics)
	{
		HashSet<ModerationCategory> infringingCategories = new HashSet<ModerationCategory>();
		foreach (CommunitySiftModerationTopic returnedTopic in returnedTopics)
		{
			ModerationCategory? category = TranslateCommunitySiftTopicToModerationCategory(returnedTopic);
			if (category.HasValue)
			{
				infringingCategories.Add(category.Value);
			}
		}
		return infringingCategories;
	}

	public static ModerationCategory? TranslateCommunitySiftTopicToModerationCategory(CommunitySiftModerationTopic entryKey)
	{
		return entryKey switch
		{
			CommunitySiftModerationTopic.GeneralRisk => ModerationCategory.GeneralRisk, 
			CommunitySiftModerationTopic.Bullying => ModerationCategory.Bullying, 
			CommunitySiftModerationTopic.Fighting => ModerationCategory.Fighting, 
			CommunitySiftModerationTopic.PII => ModerationCategory.PII, 
			CommunitySiftModerationTopic.DatingAndSexting => ModerationCategory.DatingAndSexting, 
			CommunitySiftModerationTopic.Vulgar => ModerationCategory.Vulgar, 
			CommunitySiftModerationTopic.DrugsAndAlcohol => ModerationCategory.DrugsAndAlcohol, 
			CommunitySiftModerationTopic.InGame => ModerationCategory.InGame, 
			CommunitySiftModerationTopic.Alarm => ModerationCategory.Alarm, 
			CommunitySiftModerationTopic.Fraud => ModerationCategory.Fraud, 
			CommunitySiftModerationTopic.Racist => ModerationCategory.Racist, 
			CommunitySiftModerationTopic.Religion => ModerationCategory.Religion, 
			CommunitySiftModerationTopic.Junk => ModerationCategory.Junk, 
			CommunitySiftModerationTopic.Website => ModerationCategory.Website, 
			CommunitySiftModerationTopic.Grooming => ModerationCategory.Grooming, 
			CommunitySiftModerationTopic.PublicThreats => ModerationCategory.PublicThreats, 
			CommunitySiftModerationTopic.RealName => ModerationCategory.RealName, 
			CommunitySiftModerationTopic.Radicalization => ModerationCategory.Radicalization, 
			CommunitySiftModerationTopic.Subversive => ModerationCategory.Subversive, 
			CommunitySiftModerationTopic.Sentiment => ModerationCategory.Sentiment, 
			CommunitySiftModerationTopic.Custom1 => ModerationCategory.Unknown, 
			CommunitySiftModerationTopic.Custom2 => ModerationCategory.Unknown, 
			CommunitySiftModerationTopic.Custom3 => ModerationCategory.Unknown, 
			CommunitySiftModerationTopic.Custom4 => ModerationCategory.Unknown, 
			CommunitySiftModerationTopic.Custom5 => ModerationCategory.Unknown, 
			_ => null, 
		};
	}
}
