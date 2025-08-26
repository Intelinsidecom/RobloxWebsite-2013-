namespace Roblox.Platform.TranslationResources.Feature {
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
	public override string DescriptionEngagementPayoutSubtitle => "äº’å‹•åˆ†æ•¸èˆ‡æ”¯ä»˜ä¾æ“šèª²é‡‘ä½¿ç”¨è€…çš„äº’å‹•ã€‚";

	/// <summary>
	/// Key: "Description.EngagementRobuxEarned"
	/// English String: "Engagement Robux Earned"
	/// </summary>
	public override string DescriptionEngagementRobuxEarned => "å·²è³ºå¾—çš„äº’å‹• Robux";

	/// <summary>
	/// Key: "Description.EngagementScore"
	/// English String: "Engagement Score"
	/// </summary>
	public override string DescriptionEngagementScore => "äº’å‹•åˆ†æ•¸";

	/// <summary>
	/// Key: "Heading.EngagementPayout"
	/// English String: "Engagement and Payout"
	/// </summary>
	public override string HeadingEngagementPayout => "äº’å‹•èˆ‡æ”¯ä»˜";

	/// <summary>
	/// Key: "Label.Custom"
	/// English String: "Custom"
	/// </summary>
	public override string LabelCustom => "è‡ªè¨‚";

	/// <summary>
	/// Key: "Label.EngagementBasedPayout"
	/// English String: "Engagement based payout"
	/// </summary>
	public override string LabelEngagementBasedPayout => "äº’å‹•ä¾æ“šæ”¯ä»˜";

	/// <summary>
	/// Key: "Label.EngagementScore"
	/// English String: "Engagement score"
	/// </summary>
	public override string LabelEngagementScore => "äº’å‹•åˆ†æ•¸";

	/// <summary>
	/// Key: "Label.Monthly"
	/// English String: "Monthly"
	/// </summary>
	public override string LabelMonthly => "æ¯æœˆ";

	/// <summary>
	/// Key: "Label.Weekly"
	/// English String: "Weekly"
	/// </summary>
	public override string LabelWeekly => "æ¯é€±";

	public EngagementPayoutResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForDescriptionEngagementPayoutSubtitle()
	{
		return "äº’å‹•åˆ†æ•¸èˆ‡æ”¯ä»˜ä¾æ“šèª²é‡‘ä½¿ç”¨è€…çš„äº’å‹•ã€‚";
	}

	protected override string _GetTemplateForDescriptionEngagementRobuxEarned()
	{
		return "å·²è³ºå¾—çš„äº’å‹• Robux";
	}

	protected override string _GetTemplateForDescriptionEngagementScore()
	{
		return "äº’å‹•åˆ†æ•¸";
	}

	protected override string _GetTemplateForHeadingEngagementPayout()
	{
		return "äº’å‹•èˆ‡æ”¯ä»˜";
	}

	protected override string _GetTemplateForLabelCustom()
	{
		return "è‡ªè¨‚";
	}

	protected override string _GetTemplateForLabelEngagementBasedPayout()
	{
		return "äº’å‹•ä¾æ“šæ”¯ä»˜";
	}

	protected override string _GetTemplateForLabelEngagementScore()
	{
		return "äº’å‹•åˆ†æ•¸";
	}

	protected override string _GetTemplateForLabelMonthly()
	{
		return "æ¯æœˆ";
	}

	protected override string _GetTemplateForLabelWeekly()
	{
		return "æ¯é€±";
	}
}


}
