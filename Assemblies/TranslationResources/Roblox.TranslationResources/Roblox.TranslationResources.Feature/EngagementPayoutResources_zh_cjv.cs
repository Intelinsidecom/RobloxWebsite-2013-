namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides EngagementPayoutResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class EngagementPayoutResources_zh_cjv : EngagementPayoutResources_en_us, IEngagementPayoutResources, ITranslationResources
{
	/// <summary>
	/// Key: "Description.EngagementPayoutSubtitle"
	/// English String: "Engagement score and payout based on engagement of monetized users."
	/// </summary>
	public override string DescriptionEngagementPayoutSubtitle => "";

	/// <summary>
	/// Key: "Description.EngagementRobuxEarned"
	/// English String: "Engagement Robux Earned"
	/// </summary>
	public override string DescriptionEngagementRobuxEarned => "";

	/// <summary>
	/// Key: "Description.EngagementScore"
	/// English String: "Engagement Score"
	/// </summary>
	public override string DescriptionEngagementScore => "";

	/// <summary>
	/// Key: "Heading.EngagementPayout"
	/// English String: "Engagement and Payout"
	/// </summary>
	public override string HeadingEngagementPayout => "约定及支付";

	/// <summary>
	/// Key: "Label.Custom"
	/// English String: "Custom"
	/// </summary>
	public override string LabelCustom => "";

	/// <summary>
	/// Key: "Label.EngagementBasedPayout"
	/// English String: "Engagement based payout"
	/// </summary>
	public override string LabelEngagementBasedPayout => "";

	/// <summary>
	/// Key: "Label.EngagementScore"
	/// English String: "Engagement score"
	/// </summary>
	public override string LabelEngagementScore => "";

	/// <summary>
	/// Key: "Label.Monthly"
	/// English String: "Monthly"
	/// </summary>
	public override string LabelMonthly => "";

	/// <summary>
	/// Key: "Label.Weekly"
	/// English String: "Weekly"
	/// </summary>
	public override string LabelWeekly => "";

	public EngagementPayoutResources_zh_cjv(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForDescriptionEngagementPayoutSubtitle()
	{
		return "";
	}

	protected override string _GetTemplateForDescriptionEngagementRobuxEarned()
	{
		return "";
	}

	protected override string _GetTemplateForDescriptionEngagementScore()
	{
		return "";
	}

	protected override string _GetTemplateForHeadingEngagementPayout()
	{
		return "约定及支付";
	}

	protected override string _GetTemplateForLabelCustom()
	{
		return "";
	}

	protected override string _GetTemplateForLabelEngagementBasedPayout()
	{
		return "";
	}

	protected override string _GetTemplateForLabelEngagementScore()
	{
		return "";
	}

	protected override string _GetTemplateForLabelMonthly()
	{
		return "";
	}

	protected override string _GetTemplateForLabelWeekly()
	{
		return "";
	}
}
