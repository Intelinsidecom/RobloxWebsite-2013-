namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides ShopDialogResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ShopDialogResources_zh_tw : ShopDialogResources_en_us, IShopDialogResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Cancel"
	/// button text
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "å–æ¶ˆ";

	/// <summary>
	/// Key: "Action.Continue"
	/// English String: "Continue"
	/// </summary>
	public override string ActionContinue => "ç¹¼çºŒ";

	/// <summary>
	/// Key: "Action.ContinueToShop"
	/// button text
	/// English String: "Continue to Shop"
	/// </summary>
	public override string ActionContinueToShop => "å‰å¾€å•†åº—";

	/// <summary>
	/// Key: "Description.AgeWarning"
	/// age warning message
	/// English String: "Please note that you need to be over 18 to purchase products online. The Amazon store is not part of Roblox.com and is governed by a separate privacy policy."
	/// </summary>
	public override string DescriptionAgeWarning => "è«‹æ³¨æ„ï¼Œæ‚¨éœ€è¦ 18 æ­²ä»¥ä¸Šæ‰èƒ½åœ¨ç¶²è·¯ä¸Šè³¼è²·ç”¢å“ã€‚Amazon å•†åº—ä¸å±¬æ–¼ Roblox.comï¼Œå—å–®ç¨çš„éš±ç§æ¬Šæ”¿ç­–ç®¡ç†ã€‚";

	/// <summary>
	/// Key: "Description.PurchaseAgeWarning"
	/// English String: "Please note that you need to be over 18 to purchase products online. We hope to see you again soon!"
	/// </summary>
	public override string DescriptionPurchaseAgeWarning => "æ‚¨å¿…é ˆ 18 æ­²ä»¥ä¸Šæ‰èƒ½åœ¨ç¶²è·¯ä¸Šè³¼è²·å•†å“ã€‚ç¥æ‚¨è³¼ç‰©æ„‰å¿«ï¼";

	/// <summary>
	/// Key: "Description.RetailWebsiteRedirect"
	/// English String: "Heads up, Robloxian â€“ by clicking â€œcontinue,â€ you will be redirected to a retail website that is not owned or operated by Roblox. They may have different terms and privacy policies."
	/// </summary>
	public override string DescriptionRetailWebsiteRedirect => "è«‹æ³¨æ„ï¼Œæ‚¨æŒ‰ä¸‹ã€Œç¹¼çºŒã€å¾Œå°‡æœƒå‰å¾€ Roblox ä»¥å¤–çš„è³¼ç‰©ç¶²ç«™ï¼Œè©²ç¶²ç«™æœ‰å…¶å€‹åˆ¥çš„æ¢æ¬¾æ¬Šæ”¿ç­–ã€‚";

	/// <summary>
	/// Key: "Heading.LeavingRoblox"
	/// dialog heading
	/// English String: "You are leaving Roblox"
	/// </summary>
	public override string HeadingLeavingRoblox => "æ‚¨å³å°‡é›¢é–‹ Roblox";

	public ShopDialogResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "å–æ¶ˆ";
	}

	protected override string _GetTemplateForActionContinue()
	{
		return "ç¹¼çºŒ";
	}

	protected override string _GetTemplateForActionContinueToShop()
	{
		return "å‰å¾€å•†åº—";
	}

	protected override string _GetTemplateForDescriptionAgeWarning()
	{
		return "è«‹æ³¨æ„ï¼Œæ‚¨éœ€è¦ 18 æ­²ä»¥ä¸Šæ‰èƒ½åœ¨ç¶²è·¯ä¸Šè³¼è²·ç”¢å“ã€‚Amazon å•†åº—ä¸å±¬æ–¼ Roblox.comï¼Œå—å–®ç¨çš„éš±ç§æ¬Šæ”¿ç­–ç®¡ç†ã€‚";
	}

	/// <summary>
	/// Key: "Description.AmazonRedirect"
	/// message in the modal
	/// English String: "Your are about to visit our amazon store. You will be redirected to Roblox merchandise store on {shopLink}."
	/// </summary>
	public override string DescriptionAmazonRedirect(string shopLink)
	{
		return $"æ‚¨å³å°‡å‰å¾€æˆ‘å€‘çš„ Amazon å•†åº—ã€‚æ‚¨å°‡æœƒé‡æ–°å°Žå‘è‡³ä½æ–¼ {shopLink} çš„ Roblox å•†åŸŽã€‚";
	}

	protected override string _GetTemplateForDescriptionAmazonRedirect()
	{
		return "æ‚¨å³å°‡å‰å¾€æˆ‘å€‘çš„ Amazon å•†åº—ã€‚æ‚¨å°‡æœƒé‡æ–°å°Žå‘è‡³ä½æ–¼ {shopLink} çš„ Roblox å•†åŸŽã€‚";
	}

	protected override string _GetTemplateForDescriptionPurchaseAgeWarning()
	{
		return "æ‚¨å¿…é ˆ 18 æ­²ä»¥ä¸Šæ‰èƒ½åœ¨ç¶²è·¯ä¸Šè³¼è²·å•†å“ã€‚ç¥æ‚¨è³¼ç‰©æ„‰å¿«ï¼";
	}

	protected override string _GetTemplateForDescriptionRetailWebsiteRedirect()
	{
		return "è«‹æ³¨æ„ï¼Œæ‚¨æŒ‰ä¸‹ã€Œç¹¼çºŒã€å¾Œå°‡æœƒå‰å¾€ Roblox ä»¥å¤–çš„è³¼ç‰©ç¶²ç«™ï¼Œè©²ç¶²ç«™æœ‰å…¶å€‹åˆ¥çš„æ¢æ¬¾æ¬Šæ”¿ç­–ã€‚";
	}

	protected override string _GetTemplateForHeadingLeavingRoblox()
	{
		return "æ‚¨å³å°‡é›¢é–‹ Roblox";
	}
}


}
