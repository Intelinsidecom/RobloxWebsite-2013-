namespace Roblox.Platform.TranslationResources.Purchasing {
    /// <summary>

/// This class overrides RobloxProductsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class RobloxProductsResources_ko_kr : RobloxProductsResources_en_us, IRobloxProductsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Heading.Sorry"
	/// English String: "Sorry"
	/// </summary>
	public override string HeadingSorry => "ì£„ì†¡í•©ë‹ˆë‹¤";

	/// <summary>
	/// Key: "Message.BuyRobuxToCustomizeAvatar"
	/// English String: "Buy Robux to customize your avatar and get items in game!"
	/// </summary>
	public override string MessageBuyRobuxToCustomizeAvatar => "Robuxë¥¼ êµ¬ë§¤í•˜ì—¬ ì•„ë°”íƒ€ë„ ê¾¸ë¯¸ê³  ê²Œìž„ ì•„ì´í…œë„ êµ¬ìž…í•´ë³´ì„¸ìš”!";

	/// <summary>
	/// Key: "Message.TryAgainLater"
	/// English String: "Robux purchases are temporarily disabled. Please try again later."
	/// </summary>
	public override string MessageTryAgainLater => "ì¼ì‹œì ìœ¼ë¡œ Robuxë¥¼ êµ¬ìž…í•  ìˆ˜ ì—†ìŠµë‹ˆë‹¤. ë‚˜ì¤‘ì— ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";

	public RobloxProductsResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForHeadingSorry()
	{
		return "ì£„ì†¡í•©ë‹ˆë‹¤";
	}

	protected override string _GetTemplateForMessageBuyRobuxToCustomizeAvatar()
	{
		return "Robuxë¥¼ êµ¬ë§¤í•˜ì—¬ ì•„ë°”íƒ€ë„ ê¾¸ë¯¸ê³  ê²Œìž„ ì•„ì´í…œë„ êµ¬ìž…í•´ë³´ì„¸ìš”!";
	}

	protected override string _GetTemplateForMessageTryAgainLater()
	{
		return "ì¼ì‹œì ìœ¼ë¡œ Robuxë¥¼ êµ¬ìž…í•  ìˆ˜ ì—†ìŠµë‹ˆë‹¤. ë‚˜ì¤‘ì— ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";
	}
}


}
