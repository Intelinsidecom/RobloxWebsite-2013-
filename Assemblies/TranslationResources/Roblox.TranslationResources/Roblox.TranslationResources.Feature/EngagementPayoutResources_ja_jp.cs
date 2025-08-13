namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides EngagementPayoutResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class EngagementPayoutResources_ja_jp : EngagementPayoutResources_en_us, IEngagementPayoutResources, ITranslationResources
{
	/// <summary>
	/// Key: "Description.EngagementRobuxEarned"
	/// English String: "Engagement Robux Earned"
	/// </summary>
	public override string DescriptionEngagementRobuxEarned => "獲得したエンゲージメントRobux";

	/// <summary>
	/// Key: "Description.EngagementScore"
	/// English String: "Engagement Score"
	/// </summary>
	public override string DescriptionEngagementScore => "エンゲージメントスコア";

	/// <summary>
	/// Key: "Heading.EngagementPayout"
	/// English String: "Engagement and Payout"
	/// </summary>
	public override string HeadingEngagementPayout => "エンゲージメントとペイアウト";

	/// <summary>
	/// Key: "Label.Custom"
	/// English String: "Custom"
	/// </summary>
	public override string LabelCustom => "カスタム";

	/// <summary>
	/// Key: "Label.EngagementBasedPayout"
	/// English String: "Engagement based payout"
	/// </summary>
	public override string LabelEngagementBasedPayout => "エンゲージメントによるペイアウト";

	/// <summary>
	/// Key: "Label.EngagementScore"
	/// English String: "Engagement score"
	/// </summary>
	public override string LabelEngagementScore => "エンゲージメントスコア";

	/// <summary>
	/// Key: "Label.Monthly"
	/// English String: "Monthly"
	/// </summary>
	public override string LabelMonthly => "月間";

	/// <summary>
	/// Key: "Label.Weekly"
	/// English String: "Weekly"
	/// </summary>
	public override string LabelWeekly => "週間";

	public EngagementPayoutResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForDescriptionEngagementRobuxEarned()
	{
		return "獲得したエンゲージメントRobux";
	}

	protected override string _GetTemplateForDescriptionEngagementScore()
	{
		return "エンゲージメントスコア";
	}

	protected override string _GetTemplateForHeadingEngagementPayout()
	{
		return "エンゲージメントとペイアウト";
	}

	protected override string _GetTemplateForLabelCustom()
	{
		return "カスタム";
	}

	protected override string _GetTemplateForLabelEngagementBasedPayout()
	{
		return "エンゲージメントによるペイアウト";
	}

	protected override string _GetTemplateForLabelEngagementScore()
	{
		return "エンゲージメントスコア";
	}

	protected override string _GetTemplateForLabelMonthly()
	{
		return "月間";
	}

	protected override string _GetTemplateForLabelWeekly()
	{
		return "週間";
	}
}
