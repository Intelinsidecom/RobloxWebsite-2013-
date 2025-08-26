namespace Roblox.Platform.TranslationResources.Purchasing {
    /// <summary>

/// This class overrides RobloxProductsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class RobloxProductsResources_ja_jp : RobloxProductsResources_en_us, IRobloxProductsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Heading.Sorry"
	/// English String: "Sorry"
	/// </summary>
	public override string HeadingSorry => "ç”³ã—è¨³ã‚ã‚Šã¾ã›ã‚“";

	/// <summary>
	/// Key: "Message.BuyRobuxToCustomizeAvatar"
	/// English String: "Buy Robux to customize your avatar and get items in game!"
	/// </summary>
	public override string MessageBuyRobuxToCustomizeAvatar => "Robuxã‚’è²·ã£ã¦ã‚¢ãƒã‚¿ãƒ¼ã‚’ã‚«ã‚¹ã‚¿ãƒžã‚¤ã‚ºã—ãŸã‚Šã€ã‚²ãƒ¼ãƒ å†…ã‚¢ã‚¤ãƒ†ãƒ ã‚’ã‚²ãƒƒãƒˆã—ã‚ˆã†ï¼";

	/// <summary>
	/// Key: "Message.TryAgainLater"
	/// English String: "Robux purchases are temporarily disabled. Please try again later."
	/// </summary>
	public override string MessageTryAgainLater => "Robuxè³¼å…¥ã¯ä¸€æ™‚çš„ã«ç„¡åŠ¹ã«ãªã£ã¦ã„ã¾ã™ã€‚å¾Œã§ã‚‚ã†ä¸€åº¦ãŠè©¦ã—ãã ã•ã„ã€‚";

	public RobloxProductsResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForHeadingSorry()
	{
		return "ç”³ã—è¨³ã‚ã‚Šã¾ã›ã‚“";
	}

	protected override string _GetTemplateForMessageBuyRobuxToCustomizeAvatar()
	{
		return "Robuxã‚’è²·ã£ã¦ã‚¢ãƒã‚¿ãƒ¼ã‚’ã‚«ã‚¹ã‚¿ãƒžã‚¤ã‚ºã—ãŸã‚Šã€ã‚²ãƒ¼ãƒ å†…ã‚¢ã‚¤ãƒ†ãƒ ã‚’ã‚²ãƒƒãƒˆã—ã‚ˆã†ï¼";
	}

	protected override string _GetTemplateForMessageTryAgainLater()
	{
		return "Robuxè³¼å…¥ã¯ä¸€æ™‚çš„ã«ç„¡åŠ¹ã«ãªã£ã¦ã„ã¾ã™ã€‚å¾Œã§ã‚‚ã†ä¸€åº¦ãŠè©¦ã—ãã ã•ã„ã€‚";
	}
}


}
