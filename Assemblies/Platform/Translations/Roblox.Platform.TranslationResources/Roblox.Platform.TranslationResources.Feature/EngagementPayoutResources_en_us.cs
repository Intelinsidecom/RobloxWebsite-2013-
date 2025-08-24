using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Feature;

internal class EngagementPayoutResources_en_us : TranslationResourcesBase, IEngagementPayoutResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "Description.EngagementPayoutSubtitle"
	/// English String: "Engagement score and payout based on engagement of monetized users."
	/// </summary>
	public virtual string DescriptionEngagementPayoutSubtitle => "Engagement score and payout based on engagement of monetized users.";

	/// <summary>
	/// Key: "Description.EngagementRobuxEarned"
	/// English String: "Engagement Robux Earned"
	/// </summary>
	public virtual string DescriptionEngagementRobuxEarned => "Engagement Robux Earned";

	/// <summary>
	/// Key: "Description.EngagementScore"
	/// English String: "Engagement Score"
	/// </summary>
	public virtual string DescriptionEngagementScore => "Engagement Score";

	/// <summary>
	/// Key: "Heading.EngagementPayout"
	/// English String: "Engagement and Payout"
	/// </summary>
	public virtual string HeadingEngagementPayout => "Engagement and Payout";

	/// <summary>
	/// Key: "Label.Custom"
	/// English String: "Custom"
	/// </summary>
	public virtual string LabelCustom => "Custom";

	/// <summary>
	/// Key: "Label.EngagementBasedPayout"
	/// English String: "Engagement based payout"
	/// </summary>
	public virtual string LabelEngagementBasedPayout => "Engagement based payout";

	/// <summary>
	/// Key: "Label.EngagementScore"
	/// English String: "Engagement score"
	/// </summary>
	public virtual string LabelEngagementScore => "Engagement score";

	/// <summary>
	/// Key: "Label.Monthly"
	/// English String: "Monthly"
	/// </summary>
	public virtual string LabelMonthly => "Monthly";

	/// <summary>
	/// Key: "Label.Weekly"
	/// English String: "Weekly"
	/// </summary>
	public virtual string LabelWeekly => "Weekly";

	public EngagementPayoutResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"Description.EngagementPayoutSubtitle",
				_GetTemplateForDescriptionEngagementPayoutSubtitle()
			},
			{
				"Description.EngagementRobuxEarned",
				_GetTemplateForDescriptionEngagementRobuxEarned()
			},
			{
				"Description.EngagementScore",
				_GetTemplateForDescriptionEngagementScore()
			},
			{
				"Heading.EngagementPayout",
				_GetTemplateForHeadingEngagementPayout()
			},
			{
				"Label.Custom",
				_GetTemplateForLabelCustom()
			},
			{
				"Label.EngagementBasedPayout",
				_GetTemplateForLabelEngagementBasedPayout()
			},
			{
				"Label.EngagementScore",
				_GetTemplateForLabelEngagementScore()
			},
			{
				"Label.Monthly",
				_GetTemplateForLabelMonthly()
			},
			{
				"Label.Weekly",
				_GetTemplateForLabelWeekly()
			}
		});
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "Feature.EngagementPayout";
	}

	protected virtual string _GetTemplateForDescriptionEngagementPayoutSubtitle()
	{
		return "Engagement score and payout based on engagement of monetized users.";
	}

	protected virtual string _GetTemplateForDescriptionEngagementRobuxEarned()
	{
		return "Engagement Robux Earned";
	}

	protected virtual string _GetTemplateForDescriptionEngagementScore()
	{
		return "Engagement Score";
	}

	protected virtual string _GetTemplateForHeadingEngagementPayout()
	{
		return "Engagement and Payout";
	}

	protected virtual string _GetTemplateForLabelCustom()
	{
		return "Custom";
	}

	protected virtual string _GetTemplateForLabelEngagementBasedPayout()
	{
		return "Engagement based payout";
	}

	protected virtual string _GetTemplateForLabelEngagementScore()
	{
		return "Engagement score";
	}

	protected virtual string _GetTemplateForLabelMonthly()
	{
		return "Monthly";
	}

	protected virtual string _GetTemplateForLabelWeekly()
	{
		return "Weekly";
	}
}
