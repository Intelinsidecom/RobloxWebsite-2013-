namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides EngagementPayoutResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class EngagementPayoutResources_zh_tw : EngagementPayoutResources_en_us, IEngagementPayoutResources, ITranslationResources
{
	/// <summary>
	/// Key: "Description.EngagementPayoutSubtitle"
	/// English String: "Engagement score and payout based on engagement of monetized users."
	/// </summary>
	public override string DescriptionEngagementPayoutSubtitle => "互動分數與支付依據課金使用者的互動。";

	/// <summary>
	/// Key: "Description.EngagementRobuxEarned"
	/// English String: "Engagement Robux Earned"
	/// </summary>
	public override string DescriptionEngagementRobuxEarned => "已賺得的互動 Robux";

	/// <summary>
	/// Key: "Description.EngagementScore"
	/// English String: "Engagement Score"
	/// </summary>
	public override string DescriptionEngagementScore => "互動分數";

	/// <summary>
	/// Key: "Heading.EngagementPayout"
	/// English String: "Engagement and Payout"
	/// </summary>
	public override string HeadingEngagementPayout => "互動與支付";

	/// <summary>
	/// Key: "Label.Custom"
	/// English String: "Custom"
	/// </summary>
	public override string LabelCustom => "自訂";

	/// <summary>
	/// Key: "Label.EngagementBasedPayout"
	/// English String: "Engagement based payout"
	/// </summary>
	public override string LabelEngagementBasedPayout => "互動依據支付";

	/// <summary>
	/// Key: "Label.EngagementScore"
	/// English String: "Engagement score"
	/// </summary>
	public override string LabelEngagementScore => "互動分數";

	/// <summary>
	/// Key: "Label.Monthly"
	/// English String: "Monthly"
	/// </summary>
	public override string LabelMonthly => "每月";

	/// <summary>
	/// Key: "Label.Weekly"
	/// English String: "Weekly"
	/// </summary>
	public override string LabelWeekly => "每週";

	public EngagementPayoutResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForDescriptionEngagementPayoutSubtitle()
	{
		return "互動分數與支付依據課金使用者的互動。";
	}

	protected override string _GetTemplateForDescriptionEngagementRobuxEarned()
	{
		return "已賺得的互動 Robux";
	}

	protected override string _GetTemplateForDescriptionEngagementScore()
	{
		return "互動分數";
	}

	protected override string _GetTemplateForHeadingEngagementPayout()
	{
		return "互動與支付";
	}

	protected override string _GetTemplateForLabelCustom()
	{
		return "自訂";
	}

	protected override string _GetTemplateForLabelEngagementBasedPayout()
	{
		return "互動依據支付";
	}

	protected override string _GetTemplateForLabelEngagementScore()
	{
		return "互動分數";
	}

	protected override string _GetTemplateForLabelMonthly()
	{
		return "每月";
	}

	protected override string _GetTemplateForLabelWeekly()
	{
		return "每週";
	}
}
