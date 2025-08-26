namespace Roblox.Platform.TranslationResources.Purchasing {
    /// <summary>

/// This class overrides RobloxProductsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class RobloxProductsResources_zh_cn : RobloxProductsResources_en_us, IRobloxProductsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Heading.Sorry"
	/// English String: "Sorry"
	/// </summary>
	public override string HeadingSorry => "æŠ±æ­‰";

	/// <summary>
	/// Key: "Message.BuyRobuxToCustomizeAvatar"
	/// English String: "Buy Robux to customize your avatar and get items in game!"
	/// </summary>
	public override string MessageBuyRobuxToCustomizeAvatar => "è´­ä¹° Robux æ¥è‡ªå®šä¹‰ä½ çš„è™šæ‹Ÿå½¢è±¡ï¼Œå¹¶åœ¨æ¸¸æˆä¸­èŽ·å¾—é“å…·ï¼";

	/// <summary>
	/// Key: "Message.TryAgainLater"
	/// English String: "Robux purchases are temporarily disabled. Please try again later."
	/// </summary>
	public override string MessageTryAgainLater => "Robux è´­ä¹°æš‚æ—¶åœç”¨ã€‚è¯·ç¨åŽé‡è¯•ã€‚";

	public RobloxProductsResources_zh_cn(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForHeadingSorry()
	{
		return "æŠ±æ­‰";
	}

	protected override string _GetTemplateForMessageBuyRobuxToCustomizeAvatar()
	{
		return "è´­ä¹° Robux æ¥è‡ªå®šä¹‰ä½ çš„è™šæ‹Ÿå½¢è±¡ï¼Œå¹¶åœ¨æ¸¸æˆä¸­èŽ·å¾—é“å…·ï¼";
	}

	protected override string _GetTemplateForMessageTryAgainLater()
	{
		return "Robux è´­ä¹°æš‚æ—¶åœç”¨ã€‚è¯·ç¨åŽé‡è¯•ã€‚";
	}
}


}
