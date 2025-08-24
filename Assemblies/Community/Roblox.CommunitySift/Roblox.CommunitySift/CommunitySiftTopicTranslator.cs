using System.Collections.Generic;
using Roblox.CommunitySift.Properties;

namespace Roblox.CommunitySift;

/// <summary>
/// Default implementation of <see cref="T:Roblox.CommunitySift.ICommunitySiftTopicTranslator" />.
/// Used to extract information about which CommSift categories may have failed for the given request.
/// Note that we are mapping their IDs in enums.
/// </summary>
internal class CommunitySiftTopicTranslator : ICommunitySiftTopicTranslator
{
	private readonly ICommunitySiftTopicTranslatorSettings _Settings;

	public CommunitySiftTopicTranslator(ICommunitySiftTopicTranslatorSettings settings)
	{
		_Settings = settings;
	}

	/// <summary>
	/// Takes a list of topic IDs and sccores from a community sift response, and returns corresponding enums for the topics
	/// that are over the filtering threshold, which indicates that they were a reason the text was filtered.
	///
	/// Currently only considers the score of the PII topic
	/// </summary>
	/// <param name="topicIdsAndScores">A map of topic IDs to the score the text rated for that topic</param>
	/// <param name="isUnder13"></param>
	/// <returns></returns>
	public virtual HashSet<CommunitySiftModerationTopic> ExtractFilteredTopics(Dictionary<int, int> topicIdsAndScores, bool isUnder13)
	{
		HashSet<CommunitySiftModerationTopic> topics = new HashSet<CommunitySiftModerationTopic>();
		Dictionary<CommunitySiftModerationTopic, int> moderationThresholds = (isUnder13 ? GetUnder13ModerationThresholds() : Get13AndOverModerationThresholds());
		foreach (KeyValuePair<int, int> tuple in topicIdsAndScores ?? new Dictionary<int, int>())
		{
			CommunitySiftModerationTopic? topic = TranslateTopicIdToEnum(tuple.Key);
			if (topic.HasValue && moderationThresholds.ContainsKey(topic.Value) && tuple.Value > moderationThresholds[topic.Value])
			{
				topics.Add(topic.Value);
			}
		}
		return topics;
	}

	private Dictionary<CommunitySiftModerationTopic, int> GetUnder13ModerationThresholds()
	{
		Dictionary<CommunitySiftModerationTopic, int> rules = new Dictionary<CommunitySiftModerationTopic, int>();
		AddNonZeroSetting(rules, CommunitySiftModerationTopic.GeneralRisk, _Settings.CommunitySiftGeneralRiskThresholdUnder13);
		AddNonZeroSetting(rules, CommunitySiftModerationTopic.Bullying, _Settings.CommunitySiftBullyingThresholdUnder13);
		AddNonZeroSetting(rules, CommunitySiftModerationTopic.Fighting, _Settings.CommunitySiftFightingThresholdUnder13);
		AddNonZeroSetting(rules, CommunitySiftModerationTopic.PII, _Settings.CommunitySiftPIIThresholdUnder13);
		AddNonZeroSetting(rules, CommunitySiftModerationTopic.DatingAndSexting, _Settings.CommunitySiftDatingAndSextingThresholdUnder13);
		AddNonZeroSetting(rules, CommunitySiftModerationTopic.Vulgar, _Settings.CommunitySiftVulgarThresholdUnder13);
		AddNonZeroSetting(rules, CommunitySiftModerationTopic.DrugsAndAlcohol, _Settings.CommunitySiftDrugsAndAlcoholThresholdUnder13);
		AddNonZeroSetting(rules, CommunitySiftModerationTopic.InGame, _Settings.CommunitySiftInGameThresholdUnder13);
		AddNonZeroSetting(rules, CommunitySiftModerationTopic.Alarm, _Settings.CommunitySiftAlarmThresholdUnder13);
		AddNonZeroSetting(rules, CommunitySiftModerationTopic.Fraud, _Settings.CommunitySiftFraudThresholdUnder13);
		AddNonZeroSetting(rules, CommunitySiftModerationTopic.Racist, _Settings.CommunitySiftRacistThresholdUnder13);
		AddNonZeroSetting(rules, CommunitySiftModerationTopic.Religion, _Settings.CommunitySiftReligionThresholdUnder13);
		AddNonZeroSetting(rules, CommunitySiftModerationTopic.Junk, _Settings.CommunitySiftJunkThresholdUnder13);
		AddNonZeroSetting(rules, CommunitySiftModerationTopic.Website, _Settings.CommunitySiftWebsiteThresholdUnder13);
		AddNonZeroSetting(rules, CommunitySiftModerationTopic.Grooming, _Settings.CommunitySiftGroomingThresholdUnder13);
		AddNonZeroSetting(rules, CommunitySiftModerationTopic.PublicThreats, _Settings.CommunitySiftPublicThreatsThresholdUnder13);
		AddNonZeroSetting(rules, CommunitySiftModerationTopic.RealName, _Settings.CommunitySiftRealNameThresholdUnder13);
		AddNonZeroSetting(rules, CommunitySiftModerationTopic.Radicalization, _Settings.CommunitySiftRadicalizationThresholdUnder13);
		AddNonZeroSetting(rules, CommunitySiftModerationTopic.Subversive, _Settings.CommunitySiftSubversiveThresholdUnder13);
		AddNonZeroSetting(rules, CommunitySiftModerationTopic.Sentiment, _Settings.CommunitySiftSentimentThresholdUnder13);
		AddNonZeroSetting(rules, CommunitySiftModerationTopic.Custom1, _Settings.CommunitySiftCustom1ThresholdUnder13);
		AddNonZeroSetting(rules, CommunitySiftModerationTopic.Custom2, _Settings.CommunitySiftCustom2ThresholdUnder13);
		AddNonZeroSetting(rules, CommunitySiftModerationTopic.Custom3, _Settings.CommunitySiftCustom3ThresholdUnder13);
		AddNonZeroSetting(rules, CommunitySiftModerationTopic.Custom4, _Settings.CommunitySiftCustom4ThresholdUnder13);
		AddNonZeroSetting(rules, CommunitySiftModerationTopic.Custom5, _Settings.CommunitySiftCustom5ThresholdUnder13);
		return rules;
	}

	private Dictionary<CommunitySiftModerationTopic, int> Get13AndOverModerationThresholds()
	{
		Dictionary<CommunitySiftModerationTopic, int> rules = new Dictionary<CommunitySiftModerationTopic, int>();
		AddNonZeroSetting(rules, CommunitySiftModerationTopic.GeneralRisk, _Settings.CommunitySiftGeneralRiskThreshold13AndOver);
		AddNonZeroSetting(rules, CommunitySiftModerationTopic.Bullying, _Settings.CommunitySiftBullyingThreshold13AndOver);
		AddNonZeroSetting(rules, CommunitySiftModerationTopic.Fighting, _Settings.CommunitySiftFightingThreshold13AndOver);
		AddNonZeroSetting(rules, CommunitySiftModerationTopic.PII, _Settings.CommunitySiftPIIThreshold13AndOver);
		AddNonZeroSetting(rules, CommunitySiftModerationTopic.DatingAndSexting, _Settings.CommunitySiftDatingAndSextingThreshold13AndOver);
		AddNonZeroSetting(rules, CommunitySiftModerationTopic.Vulgar, _Settings.CommunitySiftVulgarThreshold13AndOver);
		AddNonZeroSetting(rules, CommunitySiftModerationTopic.DrugsAndAlcohol, _Settings.CommunitySiftDrugsAndAlcoholThreshold13AndOver);
		AddNonZeroSetting(rules, CommunitySiftModerationTopic.InGame, _Settings.CommunitySiftInGameThreshold13AndOver);
		AddNonZeroSetting(rules, CommunitySiftModerationTopic.Alarm, _Settings.CommunitySiftAlarmThreshold13AndOver);
		AddNonZeroSetting(rules, CommunitySiftModerationTopic.Fraud, _Settings.CommunitySiftFraudThreshold13AndOver);
		AddNonZeroSetting(rules, CommunitySiftModerationTopic.Racist, _Settings.CommunitySiftRacistThreshold13AndOver);
		AddNonZeroSetting(rules, CommunitySiftModerationTopic.Religion, _Settings.CommunitySiftReligionThreshold13AndOver);
		AddNonZeroSetting(rules, CommunitySiftModerationTopic.Junk, _Settings.CommunitySiftJunkThreshold13AndOver);
		AddNonZeroSetting(rules, CommunitySiftModerationTopic.Website, _Settings.CommunitySiftWebsiteThreshold13AndOver);
		AddNonZeroSetting(rules, CommunitySiftModerationTopic.Grooming, _Settings.CommunitySiftGroomingThreshold13AndOver);
		AddNonZeroSetting(rules, CommunitySiftModerationTopic.PublicThreats, _Settings.CommunitySiftPublicThreatsThreshold13AndOver);
		AddNonZeroSetting(rules, CommunitySiftModerationTopic.RealName, _Settings.CommunitySiftRealNameThreshold13AndOver);
		AddNonZeroSetting(rules, CommunitySiftModerationTopic.Radicalization, _Settings.CommunitySiftRadicalizationThreshold13AndOver);
		AddNonZeroSetting(rules, CommunitySiftModerationTopic.Subversive, _Settings.CommunitySiftSubversiveThreshold13AndOver);
		AddNonZeroSetting(rules, CommunitySiftModerationTopic.Sentiment, _Settings.CommunitySiftSentimentThreshold13AndOver);
		AddNonZeroSetting(rules, CommunitySiftModerationTopic.Custom1, _Settings.CommunitySiftCustom1Threshold13AndOver);
		AddNonZeroSetting(rules, CommunitySiftModerationTopic.Custom2, _Settings.CommunitySiftCustom2Threshold13AndOver);
		AddNonZeroSetting(rules, CommunitySiftModerationTopic.Custom3, _Settings.CommunitySiftCustom3Threshold13AndOver);
		AddNonZeroSetting(rules, CommunitySiftModerationTopic.Custom4, _Settings.CommunitySiftCustom4Threshold13AndOver);
		AddNonZeroSetting(rules, CommunitySiftModerationTopic.Custom5, _Settings.CommunitySiftCustom5Threshold13AndOver);
		return rules;
	}

	private void AddNonZeroSetting(IDictionary<CommunitySiftModerationTopic, int> rules, CommunitySiftModerationTopic topic, int value)
	{
		if (value > 0)
		{
			rules.Add(topic, value);
		}
	}

	/// <summary>
	/// Converts a Community Sift topic ID to an enum. These mappings are taken directly from
	/// the Community Sift documentation pages.
	/// Accurate as of 13 MAR 2017
	/// </summary>
	/// <param name="topicId"></param>
	/// <returns>The enum if a mapping exists, otherwise null</returns>
	public virtual CommunitySiftModerationTopic? TranslateTopicIdToEnum(int topicId)
	{
		return topicId switch
		{
			0 => CommunitySiftModerationTopic.GeneralRisk, 
			1 => CommunitySiftModerationTopic.Bullying, 
			2 => CommunitySiftModerationTopic.Fighting, 
			3 => CommunitySiftModerationTopic.PII, 
			4 => CommunitySiftModerationTopic.DatingAndSexting, 
			5 => CommunitySiftModerationTopic.Vulgar, 
			6 => CommunitySiftModerationTopic.DrugsAndAlcohol, 
			7 => CommunitySiftModerationTopic.InGame, 
			8 => CommunitySiftModerationTopic.Alarm, 
			9 => CommunitySiftModerationTopic.Fraud, 
			10 => CommunitySiftModerationTopic.Racist, 
			11 => CommunitySiftModerationTopic.Religion, 
			12 => CommunitySiftModerationTopic.Junk, 
			13 => CommunitySiftModerationTopic.Website, 
			14 => CommunitySiftModerationTopic.Grooming, 
			15 => CommunitySiftModerationTopic.PublicThreats, 
			16 => CommunitySiftModerationTopic.RealName, 
			17 => CommunitySiftModerationTopic.Radicalization, 
			18 => CommunitySiftModerationTopic.Subversive, 
			19 => CommunitySiftModerationTopic.Sentiment, 
			27 => CommunitySiftModerationTopic.Custom1, 
			28 => CommunitySiftModerationTopic.Custom2, 
			29 => CommunitySiftModerationTopic.Custom3, 
			30 => CommunitySiftModerationTopic.Custom4, 
			31 => CommunitySiftModerationTopic.Custom5, 
			_ => null, 
		};
	}
}
