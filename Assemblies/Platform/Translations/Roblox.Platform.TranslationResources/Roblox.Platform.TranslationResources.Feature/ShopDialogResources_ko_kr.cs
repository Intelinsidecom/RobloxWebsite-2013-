namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides ShopDialogResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ShopDialogResources_ko_kr : ShopDialogResources_en_us, IShopDialogResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Cancel"
	/// button text
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "ì·¨ì†Œ";

	/// <summary>
	/// Key: "Action.Continue"
	/// English String: "Continue"
	/// </summary>
	public override string ActionContinue => "ê³„ì†";

	/// <summary>
	/// Key: "Action.ContinueToShop"
	/// button text
	/// English String: "Continue to Shop"
	/// </summary>
	public override string ActionContinueToShop => "ìƒì ìœ¼ë¡œ ì´ë™";

	/// <summary>
	/// Key: "Description.AgeWarning"
	/// age warning message
	/// English String: "Please note that you need to be over 18 to purchase products online. The Amazon store is not part of Roblox.com and is governed by a separate privacy policy."
	/// </summary>
	public override string DescriptionAgeWarning => "ë§Œ 18ì„¸ ì´ìƒ ì‚¬ìš©ìžë§Œ ì˜¨ë¼ì¸ì—ì„œ ìƒí’ˆì„ êµ¬ìž…í•  ìˆ˜ ìžˆìœ¼ë©°, Amazon ìŠ¤í† ì–´ëŠ” Roblox.comì— ì†í•˜ì§€ ì•ŠëŠ” ë³„ê°œì˜ ê¸°ì—…ìœ¼ë¡œ ë³„ë„ì˜ ê°œì¸ì •ë³´ ì²˜ë¦¬ë°©ì¹¨ì´ ì ìš©ë©ë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Description.PurchaseAgeWarning"
	/// English String: "Please note that you need to be over 18 to purchase products online. We hope to see you again soon!"
	/// </summary>
	public override string DescriptionPurchaseAgeWarning => "ì˜¨ë¼ì¸ì—ì„œ ìƒí’ˆì„ êµ¬ë§¤í•˜ë ¤ë©´ ë§Œ 18ì„¸ ì´ìƒì´ì–´ì•¼ í•´ìš”. ê³§ ë‹¤ì‹œ ëµ™ê¸¸ ë°”ëž˜ìš”!";

	/// <summary>
	/// Key: "Description.RetailWebsiteRedirect"
	/// English String: "Heads up, Robloxian â€“ by clicking â€œcontinue,â€ you will be redirected to a retail website that is not owned or operated by Roblox. They may have different terms and privacy policies."
	/// </summary>
	public override string DescriptionRetailWebsiteRedirect => "Roblox í”Œë ˆì´ì–´ ì—¬ëŸ¬ë¶„, ì£¼ì˜í•˜ì„¸ìš”. \"ê³„ì†\"ì„ í´ë¦­í•˜ë©´ Robloxê°€ ì†Œìœ ë„ ìš´ì˜ë„ í•˜ì§€ ì•ŠëŠ” ë¦¬í…Œì¼ ì›¹ì‚¬ì´íŠ¸ë¡œ ì´ë™í•˜ê²Œ ë©ë‹ˆë‹¤. ê°œì¸ì •ë³´ ì·¨ê¸‰ë°©ì¹¨ì´ ë‹¤ë¥¼ ìˆ˜ ìžˆì–´ìš”.";

	/// <summary>
	/// Key: "Heading.LeavingRoblox"
	/// dialog heading
	/// English String: "You are leaving Roblox"
	/// </summary>
	public override string HeadingLeavingRoblox => "ì•ˆë…•ížˆ ê°€ì„¸ìš”";

	public ShopDialogResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "ì·¨ì†Œ";
	}

	protected override string _GetTemplateForActionContinue()
	{
		return "ê³„ì†";
	}

	protected override string _GetTemplateForActionContinueToShop()
	{
		return "ìƒì ìœ¼ë¡œ ì´ë™";
	}

	protected override string _GetTemplateForDescriptionAgeWarning()
	{
		return "ë§Œ 18ì„¸ ì´ìƒ ì‚¬ìš©ìžë§Œ ì˜¨ë¼ì¸ì—ì„œ ìƒí’ˆì„ êµ¬ìž…í•  ìˆ˜ ìžˆìœ¼ë©°, Amazon ìŠ¤í† ì–´ëŠ” Roblox.comì— ì†í•˜ì§€ ì•ŠëŠ” ë³„ê°œì˜ ê¸°ì—…ìœ¼ë¡œ ë³„ë„ì˜ ê°œì¸ì •ë³´ ì²˜ë¦¬ë°©ì¹¨ì´ ì ìš©ë©ë‹ˆë‹¤.";
	}

	/// <summary>
	/// Key: "Description.AmazonRedirect"
	/// message in the modal
	/// English String: "Your are about to visit our amazon store. You will be redirected to Roblox merchandise store on {shopLink}."
	/// </summary>
	public override string DescriptionAmazonRedirect(string shopLink)
	{
		return $"ê³§ {shopLink}ì— ìžˆëŠ” Roblox ìƒí’ˆ ìŠ¤í† ì–´ë¡œ ì´ë™í•©ë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForDescriptionAmazonRedirect()
	{
		return "ê³§ {shopLink}ì— ìžˆëŠ” Roblox ìƒí’ˆ ìŠ¤í† ì–´ë¡œ ì´ë™í•©ë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForDescriptionPurchaseAgeWarning()
	{
		return "ì˜¨ë¼ì¸ì—ì„œ ìƒí’ˆì„ êµ¬ë§¤í•˜ë ¤ë©´ ë§Œ 18ì„¸ ì´ìƒì´ì–´ì•¼ í•´ìš”. ê³§ ë‹¤ì‹œ ëµ™ê¸¸ ë°”ëž˜ìš”!";
	}

	protected override string _GetTemplateForDescriptionRetailWebsiteRedirect()
	{
		return "Roblox í”Œë ˆì´ì–´ ì—¬ëŸ¬ë¶„, ì£¼ì˜í•˜ì„¸ìš”. \"ê³„ì†\"ì„ í´ë¦­í•˜ë©´ Robloxê°€ ì†Œìœ ë„ ìš´ì˜ë„ í•˜ì§€ ì•ŠëŠ” ë¦¬í…Œì¼ ì›¹ì‚¬ì´íŠ¸ë¡œ ì´ë™í•˜ê²Œ ë©ë‹ˆë‹¤. ê°œì¸ì •ë³´ ì·¨ê¸‰ë°©ì¹¨ì´ ë‹¤ë¥¼ ìˆ˜ ìžˆì–´ìš”.";
	}

	protected override string _GetTemplateForHeadingLeavingRoblox()
	{
		return "ì•ˆë…•ížˆ ê°€ì„¸ìš”";
	}
}


}
