namespace Roblox.Platform.TranslationResources.Feature {
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
	public override string DescriptionEngagementRobuxEarned => "ç²å¾—ã—ãŸã‚¨ãƒ³ã‚²ãƒ¼ã‚¸ãƒ¡ãƒ³ãƒˆRobux";

	/// <summary>
	/// Key: "Description.EngagementScore"
	/// English String: "Engagement Score"
	/// </summary>
	public override string DescriptionEngagementScore => "ã‚¨ãƒ³ã‚²ãƒ¼ã‚¸ãƒ¡ãƒ³ãƒˆã‚¹ã‚³ã‚¢";

	/// <summary>
	/// Key: "Heading.EngagementPayout"
	/// English String: "Engagement and Payout"
	/// </summary>
	public override string HeadingEngagementPayout => "ã‚¨ãƒ³ã‚²ãƒ¼ã‚¸ãƒ¡ãƒ³ãƒˆã¨ãƒšã‚¤ã‚¢ã‚¦ãƒˆ";

	/// <summary>
	/// Key: "Label.Custom"
	/// English String: "Custom"
	/// </summary>
	public override string LabelCustom => "ã‚«ã‚¹ã‚¿ãƒ ";

	/// <summary>
	/// Key: "Label.EngagementBasedPayout"
	/// English String: "Engagement based payout"
	/// </summary>
	public override string LabelEngagementBasedPayout => "ã‚¨ãƒ³ã‚²ãƒ¼ã‚¸ãƒ¡ãƒ³ãƒˆã«ã‚ˆã‚‹ãƒšã‚¤ã‚¢ã‚¦ãƒˆ";

	/// <summary>
	/// Key: "Label.EngagementScore"
	/// English String: "Engagement score"
	/// </summary>
	public override string LabelEngagementScore => "ã‚¨ãƒ³ã‚²ãƒ¼ã‚¸ãƒ¡ãƒ³ãƒˆã‚¹ã‚³ã‚¢";

	/// <summary>
	/// Key: "Label.Monthly"
	/// English String: "Monthly"
	/// </summary>
	public override string LabelMonthly => "æœˆé–“";

	/// <summary>
	/// Key: "Label.Weekly"
	/// English String: "Weekly"
	/// </summary>
	public override string LabelWeekly => "é€±é–“";

	public EngagementPayoutResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForDescriptionEngagementRobuxEarned()
	{
		return "ç²å¾—ã—ãŸã‚¨ãƒ³ã‚²ãƒ¼ã‚¸ãƒ¡ãƒ³ãƒˆRobux";
	}

	protected override string _GetTemplateForDescriptionEngagementScore()
	{
		return "ã‚¨ãƒ³ã‚²ãƒ¼ã‚¸ãƒ¡ãƒ³ãƒˆã‚¹ã‚³ã‚¢";
	}

	protected override string _GetTemplateForHeadingEngagementPayout()
	{
		return "ã‚¨ãƒ³ã‚²ãƒ¼ã‚¸ãƒ¡ãƒ³ãƒˆã¨ãƒšã‚¤ã‚¢ã‚¦ãƒˆ";
	}

	protected override string _GetTemplateForLabelCustom()
	{
		return "ã‚«ã‚¹ã‚¿ãƒ ";
	}

	protected override string _GetTemplateForLabelEngagementBasedPayout()
	{
		return "ã‚¨ãƒ³ã‚²ãƒ¼ã‚¸ãƒ¡ãƒ³ãƒˆã«ã‚ˆã‚‹ãƒšã‚¤ã‚¢ã‚¦ãƒˆ";
	}

	protected override string _GetTemplateForLabelEngagementScore()
	{
		return "ã‚¨ãƒ³ã‚²ãƒ¼ã‚¸ãƒ¡ãƒ³ãƒˆã‚¹ã‚³ã‚¢";
	}

	protected override string _GetTemplateForLabelMonthly()
	{
		return "æœˆé–“";
	}

	protected override string _GetTemplateForLabelWeekly()
	{
		return "é€±é–“";
	}
}


}
