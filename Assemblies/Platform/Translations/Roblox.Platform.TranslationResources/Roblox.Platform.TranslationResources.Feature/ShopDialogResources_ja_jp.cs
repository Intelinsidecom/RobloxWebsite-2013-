namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides ShopDialogResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ShopDialogResources_ja_jp : ShopDialogResources_en_us, IShopDialogResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Cancel"
	/// button text
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "ã‚­ãƒ£ãƒ³ã‚»ãƒ«";

	/// <summary>
	/// Key: "Action.Continue"
	/// English String: "Continue"
	/// </summary>
	public override string ActionContinue => "ç¶šã‘ã‚‹";

	/// <summary>
	/// Key: "Action.ContinueToShop"
	/// button text
	/// English String: "Continue to Shop"
	/// </summary>
	public override string ActionContinueToShop => "ã‚·ãƒ§ãƒƒãƒ—ã«ç§»å‹•";

	/// <summary>
	/// Key: "Description.AgeWarning"
	/// age warning message
	/// English String: "Please note that you need to be over 18 to purchase products online. The Amazon store is not part of Roblox.com and is governed by a separate privacy policy."
	/// </summary>
	public override string DescriptionAgeWarning => "ã‚ªãƒ³ãƒ©ã‚¤ãƒ³ã§å•†å“ã‚’è²·ã†ã«ã¯ã€18æ­³ä»¥ä¸Šã§ã‚ã‚‹å¿…è¦ãŒã‚ã‚Šã¾ã™ã€‚Amazonã‚¹ãƒˆã‚¢ã¯Roblox.comã®ã‚µã‚¤ãƒˆã®ä¸€éƒ¨ã§ãªã„ãŸã‚ã€åˆ¥ã®ãƒ—ãƒ©ã‚¤ãƒã‚·ãƒ¼ãƒãƒªã‚·ãƒ¼ã§ç®¡ç†ã•ã‚Œã¦ã„ã¾ã™ã€‚";

	/// <summary>
	/// Key: "Description.PurchaseAgeWarning"
	/// English String: "Please note that you need to be over 18 to purchase products online. We hope to see you again soon!"
	/// </summary>
	public override string DescriptionPurchaseAgeWarning => "ã‚ªãƒ³ãƒ©ã‚¤ãƒ³ã§å•†å“ã‚’è²·ã†ã«ã¯ã€18æ­³ä»¥ä¸Šã§ã‚ã‚‹å¿…è¦ãŒã‚ã‚Šã¾ã™ã€‚ã¾ãŸã®ã”åˆ©ç”¨ã‚’ãŠå¾…ã¡ã—ã¦ã„ã¾ã™ï¼";

	/// <summary>
	/// Key: "Description.RetailWebsiteRedirect"
	/// English String: "Heads up, Robloxian â€“ by clicking â€œcontinue,â€ you will be redirected to a retail website that is not owned or operated by Roblox. They may have different terms and privacy policies."
	/// </summary>
	public override string DescriptionRetailWebsiteRedirect => "Robloxã”åˆ©ç”¨è€…ã¸ã®ãŠçŸ¥ã‚‰ã› â€“ ã€Œç¶šã‘ã‚‹ã€ã‚’ã‚¯ãƒªãƒƒã‚¯ã™ã‚‹ã¨ã€RobloxãŒæ‰€æœ‰ã€ç®¡ç†ã—ã¦ã„ãªã„è²©å£²ç”¨ã‚µã‚¤ãƒˆã«ç§»å‹•ã—ã¾ã™ã€‚Robloxã¨ã¯ç•°ãªã‚‹åˆ©ç”¨è¦ç´„ã‚„ãƒ—ãƒ©ã‚¤ãƒã‚·ãƒ¼ãƒãƒªã‚·ãƒ¼ãŒé©ç”¨ã•ã‚Œã‚‹å ´åˆãŒã‚ã‚Šã¾ã™ã€‚";

	/// <summary>
	/// Key: "Heading.LeavingRoblox"
	/// dialog heading
	/// English String: "You are leaving Roblox"
	/// </summary>
	public override string HeadingLeavingRoblox => "Robloxã§ã¯ãªã„ã‚µã‚¤ãƒˆã«ç§»å‹•ã—ã¦ã„ã¾ã™";

	public ShopDialogResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "ã‚­ãƒ£ãƒ³ã‚»ãƒ«";
	}

	protected override string _GetTemplateForActionContinue()
	{
		return "ç¶šã‘ã‚‹";
	}

	protected override string _GetTemplateForActionContinueToShop()
	{
		return "ã‚·ãƒ§ãƒƒãƒ—ã«ç§»å‹•";
	}

	protected override string _GetTemplateForDescriptionAgeWarning()
	{
		return "ã‚ªãƒ³ãƒ©ã‚¤ãƒ³ã§å•†å“ã‚’è²·ã†ã«ã¯ã€18æ­³ä»¥ä¸Šã§ã‚ã‚‹å¿…è¦ãŒã‚ã‚Šã¾ã™ã€‚Amazonã‚¹ãƒˆã‚¢ã¯Roblox.comã®ã‚µã‚¤ãƒˆã®ä¸€éƒ¨ã§ãªã„ãŸã‚ã€åˆ¥ã®ãƒ—ãƒ©ã‚¤ãƒã‚·ãƒ¼ãƒãƒªã‚·ãƒ¼ã§ç®¡ç†ã•ã‚Œã¦ã„ã¾ã™ã€‚";
	}

	/// <summary>
	/// Key: "Description.AmazonRedirect"
	/// message in the modal
	/// English String: "Your are about to visit our amazon store. You will be redirected to Roblox merchandise store on {shopLink}."
	/// </summary>
	public override string DescriptionAmazonRedirect(string shopLink)
	{
		return $"å½“ç¤¾ã®Amazonã‚¹ãƒˆã‚¢ã«ã‚¢ã‚¯ã‚»ã‚¹ã—ã‚ˆã†ã¨ã—ã¦ã„ã¾ã™ã€‚{shopLink}ã§Robloxã®å•†å“ã‚¹ãƒˆã‚¢ã«ç§»å‹•ã—ã¾ã™ã€‚";
	}

	protected override string _GetTemplateForDescriptionAmazonRedirect()
	{
		return "å½“ç¤¾ã®Amazonã‚¹ãƒˆã‚¢ã«ã‚¢ã‚¯ã‚»ã‚¹ã—ã‚ˆã†ã¨ã—ã¦ã„ã¾ã™ã€‚{shopLink}ã§Robloxã®å•†å“ã‚¹ãƒˆã‚¢ã«ç§»å‹•ã—ã¾ã™ã€‚";
	}

	protected override string _GetTemplateForDescriptionPurchaseAgeWarning()
	{
		return "ã‚ªãƒ³ãƒ©ã‚¤ãƒ³ã§å•†å“ã‚’è²·ã†ã«ã¯ã€18æ­³ä»¥ä¸Šã§ã‚ã‚‹å¿…è¦ãŒã‚ã‚Šã¾ã™ã€‚ã¾ãŸã®ã”åˆ©ç”¨ã‚’ãŠå¾…ã¡ã—ã¦ã„ã¾ã™ï¼";
	}

	protected override string _GetTemplateForDescriptionRetailWebsiteRedirect()
	{
		return "Robloxã”åˆ©ç”¨è€…ã¸ã®ãŠçŸ¥ã‚‰ã› â€“ ã€Œç¶šã‘ã‚‹ã€ã‚’ã‚¯ãƒªãƒƒã‚¯ã™ã‚‹ã¨ã€RobloxãŒæ‰€æœ‰ã€ç®¡ç†ã—ã¦ã„ãªã„è²©å£²ç”¨ã‚µã‚¤ãƒˆã«ç§»å‹•ã—ã¾ã™ã€‚Robloxã¨ã¯ç•°ãªã‚‹åˆ©ç”¨è¦ç´„ã‚„ãƒ—ãƒ©ã‚¤ãƒã‚·ãƒ¼ãƒãƒªã‚·ãƒ¼ãŒé©ç”¨ã•ã‚Œã‚‹å ´åˆãŒã‚ã‚Šã¾ã™ã€‚";
	}

	protected override string _GetTemplateForHeadingLeavingRoblox()
	{
		return "Robloxã§ã¯ãªã„ã‚µã‚¤ãƒˆã«ç§»å‹•ã—ã¦ã„ã¾ã™";
	}
}


}
