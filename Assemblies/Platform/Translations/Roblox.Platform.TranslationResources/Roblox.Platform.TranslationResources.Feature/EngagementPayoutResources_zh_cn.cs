namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides EngagementPayoutResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class EngagementPayoutResources_zh_cn : EngagementPayoutResources_en_us, IEngagementPayoutResources, ITranslationResources
{
	/// <summary>
	/// Key: "Heading.EngagementPayout"
	/// English String: "Engagement and Payout"
	/// </summary>
	public override string HeadingEngagementPayout => "çº¦å®šåŠæ”¯ä»˜";

	public EngagementPayoutResources_zh_cn(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForHeadingEngagementPayout()
	{
		return "çº¦å®šåŠæ”¯ä»˜";
	}
}


}
