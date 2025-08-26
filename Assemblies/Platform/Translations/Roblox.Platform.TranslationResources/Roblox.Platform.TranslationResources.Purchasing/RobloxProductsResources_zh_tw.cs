namespace Roblox.Platform.TranslationResources.Purchasing {
    /// <summary>

/// This class overrides RobloxProductsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class RobloxProductsResources_zh_tw : RobloxProductsResources_en_us, IRobloxProductsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Heading.Sorry"
	/// English String: "Sorry"
	/// </summary>
	public override string HeadingSorry => "å°ä¸èµ·";

	/// <summary>
	/// Key: "Message.BuyRobuxToCustomizeAvatar"
	/// English String: "Buy Robux to customize your avatar and get items in game!"
	/// </summary>
	public override string MessageBuyRobuxToCustomizeAvatar => "è³¼è²· Robux è‡ªè¨‚æ‚¨çš„è™›æ“¬äººå¶ï¼Œå–å¾—éŠæˆ²é“å…·ï¼";

	/// <summary>
	/// Key: "Message.TryAgainLater"
	/// English String: "Robux purchases are temporarily disabled. Please try again later."
	/// </summary>
	public override string MessageTryAgainLater => "Robux è³¼è²·æš«æ™‚åœç”¨ï¼Œè«‹ç¨å¾Œå†è©¦ã€‚";

	public RobloxProductsResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForHeadingSorry()
	{
		return "å°ä¸èµ·";
	}

	protected override string _GetTemplateForMessageBuyRobuxToCustomizeAvatar()
	{
		return "è³¼è²· Robux è‡ªè¨‚æ‚¨çš„è™›æ“¬äººå¶ï¼Œå–å¾—éŠæˆ²é“å…·ï¼";
	}

	protected override string _GetTemplateForMessageTryAgainLater()
	{
		return "Robux è³¼è²·æš«æ™‚åœç”¨ï¼Œè«‹ç¨å¾Œå†è©¦ã€‚";
	}
}


}
