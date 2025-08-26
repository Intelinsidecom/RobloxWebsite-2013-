namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides ShopDialogResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ShopDialogResources_zh_cjv : ShopDialogResources_en_us, IShopDialogResources, ITranslationResources
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
	public override string ActionContinue => "ç»§ç»­";

	/// <summary>
	/// Key: "Action.ContinueToShop"
	/// button text
	/// English String: "Continue to Shop"
	/// </summary>
	public override string ActionContinueToShop => "ç»§ç»­è´­ç‰©";

	/// <summary>
	/// Key: "Description.AgeWarning"
	/// age warning message
	/// English String: "Please note that you need to be over 18 to purchase products online. The Amazon store is not part of Roblox.com and is governed by a separate privacy policy."
	/// </summary>
	public override string DescriptionAgeWarning => "è¯·æ³¨æ„ï¼Œä½ å¿…é¡»å¹´æ»¡ 18 å²æ‰èƒ½åœ¨çº¿è´­ä¹°äº§å“ã€‚Amazon å•†åº—ä¸å±žäºŽ Roblox.comï¼Œå—å•ç‹¬éšç§æ”¿ç­–çš„ç›‘ç®¡ã€‚";

	/// <summary>
	/// Key: "Description.PurchaseAgeWarning"
	/// English String: "Please note that you need to be over 18 to purchase products online. We hope to see you again soon!"
	/// </summary>
	public override string DescriptionPurchaseAgeWarning => "ä½ å¿…é¡»å¹´æ»¡ 18 å²æ‰èƒ½åœ¨ç½‘ç»œä¸Šè´­ä¹°å•†å“ã€‚";

	/// <summary>
	/// Key: "Description.RetailWebsiteRedirect"
	/// English String: "Heads up, Robloxian â€“ by clicking â€œcontinue,â€ you will be redirected to a retail website that is not owned or operated by Roblox. They may have different terms and privacy policies."
	/// </summary>
	public override string DescriptionRetailWebsiteRedirect => "è¯·æ³¨æ„ï¼Œå¦‚æžœç‚¹æŒ‰â€œç»§ç»­â€ï¼Œä½ å°†ä¼šé‡æ–°å¯¼å‘è‡³å¹¶éžç”± Roblox è¿è¥å¹¶æ“ä½œçš„é›¶å”®ç½‘ç«™ï¼Œè¯¥ç½‘ç«™å¯èƒ½å—ä¸åŒçš„æ¡æ¬¾åŠéšç§æ”¿ç­–çº¦æŸã€‚";

	/// <summary>
	/// Key: "Heading.LeavingRoblox"
	/// dialog heading
	/// English String: "You are leaving Roblox"
	/// </summary>
	public override string HeadingLeavingRoblox => "ä½ å³å°†ç¦»å¼€ Roblox";

	public ShopDialogResources_zh_cjv(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "å–æ¶ˆ";
	}

	protected override string _GetTemplateForActionContinue()
	{
		return "ç»§ç»­";
	}

	protected override string _GetTemplateForActionContinueToShop()
	{
		return "ç»§ç»­è´­ç‰©";
	}

	protected override string _GetTemplateForDescriptionAgeWarning()
	{
		return "è¯·æ³¨æ„ï¼Œä½ å¿…é¡»å¹´æ»¡ 18 å²æ‰èƒ½åœ¨çº¿è´­ä¹°äº§å“ã€‚Amazon å•†åº—ä¸å±žäºŽ Roblox.comï¼Œå—å•ç‹¬éšç§æ”¿ç­–çš„ç›‘ç®¡ã€‚";
	}

	/// <summary>
	/// Key: "Description.AmazonRedirect"
	/// message in the modal
	/// English String: "Your are about to visit our amazon store. You will be redirected to Roblox merchandise store on {shopLink}."
	/// </summary>
	public override string DescriptionAmazonRedirect(string shopLink)
	{
		return $"ä½ å³å°†è®¿é—®æˆ‘ä»¬çš„ Amazon å•†åº—ã€‚ä½ å°†ä¼šé‡æ–°å¯¼å‘è‡³ä½äºŽ {shopLink} çš„ Roblox å‘¨è¾¹å•†åº—ã€‚";
	}

	protected override string _GetTemplateForDescriptionAmazonRedirect()
	{
		return "ä½ å³å°†è®¿é—®æˆ‘ä»¬çš„ Amazon å•†åº—ã€‚ä½ å°†ä¼šé‡æ–°å¯¼å‘è‡³ä½äºŽ {shopLink} çš„ Roblox å‘¨è¾¹å•†åº—ã€‚";
	}

	protected override string _GetTemplateForDescriptionPurchaseAgeWarning()
	{
		return "ä½ å¿…é¡»å¹´æ»¡ 18 å²æ‰èƒ½åœ¨ç½‘ç»œä¸Šè´­ä¹°å•†å“ã€‚";
	}

	protected override string _GetTemplateForDescriptionRetailWebsiteRedirect()
	{
		return "è¯·æ³¨æ„ï¼Œå¦‚æžœç‚¹æŒ‰â€œç»§ç»­â€ï¼Œä½ å°†ä¼šé‡æ–°å¯¼å‘è‡³å¹¶éžç”± Roblox è¿è¥å¹¶æ“ä½œçš„é›¶å”®ç½‘ç«™ï¼Œè¯¥ç½‘ç«™å¯èƒ½å—ä¸åŒçš„æ¡æ¬¾åŠéšç§æ”¿ç­–çº¦æŸã€‚";
	}

	protected override string _GetTemplateForHeadingLeavingRoblox()
	{
		return "ä½ å³å°†ç¦»å¼€ Roblox";
	}
}


}
