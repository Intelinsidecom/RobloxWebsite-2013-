namespace Roblox.TranslationResources.Feature;

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
	public override string ActionCancel => "取消";

	/// <summary>
	/// Key: "Action.Continue"
	/// English String: "Continue"
	/// </summary>
	public override string ActionContinue => "繼續";

	/// <summary>
	/// Key: "Action.ContinueToShop"
	/// button text
	/// English String: "Continue to Shop"
	/// </summary>
	public override string ActionContinueToShop => "前往商店";

	/// <summary>
	/// Key: "Description.AgeWarning"
	/// age warning message
	/// English String: "Please note that you need to be over 18 to purchase products online. The Amazon store is not part of Roblox.com and is governed by a separate privacy policy."
	/// </summary>
	public override string DescriptionAgeWarning => "請注意，您需要 18 歲以上才能在網路上購買產品。Amazon 商店不屬於 Roblox.com，受單獨的隱私權政策管理。";

	/// <summary>
	/// Key: "Description.PurchaseAgeWarning"
	/// English String: "Please note that you need to be over 18 to purchase products online. We hope to see you again soon!"
	/// </summary>
	public override string DescriptionPurchaseAgeWarning => "您必須 18 歲以上才能在網路上購買商品。祝您購物愉快！";

	/// <summary>
	/// Key: "Description.RetailWebsiteRedirect"
	/// English String: "Heads up, Robloxian – by clicking “continue,” you will be redirected to a retail website that is not owned or operated by Roblox. They may have different terms and privacy policies."
	/// </summary>
	public override string DescriptionRetailWebsiteRedirect => "請注意，您按下「繼續」後將會前往 Roblox 以外的購物網站，該網站有其個別的條款權政策。";

	/// <summary>
	/// Key: "Heading.LeavingRoblox"
	/// dialog heading
	/// English String: "You are leaving Roblox"
	/// </summary>
	public override string HeadingLeavingRoblox => "您即將離開 Roblox";

	public ShopDialogResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "取消";
	}

	protected override string _GetTemplateForActionContinue()
	{
		return "繼續";
	}

	protected override string _GetTemplateForActionContinueToShop()
	{
		return "前往商店";
	}

	protected override string _GetTemplateForDescriptionAgeWarning()
	{
		return "請注意，您需要 18 歲以上才能在網路上購買產品。Amazon 商店不屬於 Roblox.com，受單獨的隱私權政策管理。";
	}

	/// <summary>
	/// Key: "Description.AmazonRedirect"
	/// message in the modal
	/// English String: "Your are about to visit our amazon store. You will be redirected to Roblox merchandise store on {shopLink}."
	/// </summary>
	public override string DescriptionAmazonRedirect(string shopLink)
	{
		return $"您即將前往我們的 Amazon 商店。您將會重新導向至位於 {shopLink} 的 Roblox 商城。";
	}

	protected override string _GetTemplateForDescriptionAmazonRedirect()
	{
		return "您即將前往我們的 Amazon 商店。您將會重新導向至位於 {shopLink} 的 Roblox 商城。";
	}

	protected override string _GetTemplateForDescriptionPurchaseAgeWarning()
	{
		return "您必須 18 歲以上才能在網路上購買商品。祝您購物愉快！";
	}

	protected override string _GetTemplateForDescriptionRetailWebsiteRedirect()
	{
		return "請注意，您按下「繼續」後將會前往 Roblox 以外的購物網站，該網站有其個別的條款權政策。";
	}

	protected override string _GetTemplateForHeadingLeavingRoblox()
	{
		return "您即將離開 Roblox";
	}
}
