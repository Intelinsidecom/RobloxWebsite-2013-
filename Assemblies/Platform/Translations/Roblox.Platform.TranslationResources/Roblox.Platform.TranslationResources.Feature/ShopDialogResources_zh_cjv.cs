namespace Roblox.TranslationResources.Feature;

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
	public override string ActionCancel => "取消";

	/// <summary>
	/// Key: "Action.Continue"
	/// English String: "Continue"
	/// </summary>
	public override string ActionContinue => "继续";

	/// <summary>
	/// Key: "Action.ContinueToShop"
	/// button text
	/// English String: "Continue to Shop"
	/// </summary>
	public override string ActionContinueToShop => "继续购物";

	/// <summary>
	/// Key: "Description.AgeWarning"
	/// age warning message
	/// English String: "Please note that you need to be over 18 to purchase products online. The Amazon store is not part of Roblox.com and is governed by a separate privacy policy."
	/// </summary>
	public override string DescriptionAgeWarning => "请注意，你必须年满 18 岁才能在线购买产品。Amazon 商店不属于 Roblox.com，受单独隐私政策的监管。";

	/// <summary>
	/// Key: "Description.PurchaseAgeWarning"
	/// English String: "Please note that you need to be over 18 to purchase products online. We hope to see you again soon!"
	/// </summary>
	public override string DescriptionPurchaseAgeWarning => "你必须年满 18 岁才能在网络上购买商品。";

	/// <summary>
	/// Key: "Description.RetailWebsiteRedirect"
	/// English String: "Heads up, Robloxian – by clicking “continue,” you will be redirected to a retail website that is not owned or operated by Roblox. They may have different terms and privacy policies."
	/// </summary>
	public override string DescriptionRetailWebsiteRedirect => "请注意，如果点按“继续”，你将会重新导向至并非由 Roblox 运营并操作的零售网站，该网站可能受不同的条款及隐私政策约束。";

	/// <summary>
	/// Key: "Heading.LeavingRoblox"
	/// dialog heading
	/// English String: "You are leaving Roblox"
	/// </summary>
	public override string HeadingLeavingRoblox => "你即将离开 Roblox";

	public ShopDialogResources_zh_cjv(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "取消";
	}

	protected override string _GetTemplateForActionContinue()
	{
		return "继续";
	}

	protected override string _GetTemplateForActionContinueToShop()
	{
		return "继续购物";
	}

	protected override string _GetTemplateForDescriptionAgeWarning()
	{
		return "请注意，你必须年满 18 岁才能在线购买产品。Amazon 商店不属于 Roblox.com，受单独隐私政策的监管。";
	}

	/// <summary>
	/// Key: "Description.AmazonRedirect"
	/// message in the modal
	/// English String: "Your are about to visit our amazon store. You will be redirected to Roblox merchandise store on {shopLink}."
	/// </summary>
	public override string DescriptionAmazonRedirect(string shopLink)
	{
		return $"你即将访问我们的 Amazon 商店。你将会重新导向至位于 {shopLink} 的 Roblox 周边商店。";
	}

	protected override string _GetTemplateForDescriptionAmazonRedirect()
	{
		return "你即将访问我们的 Amazon 商店。你将会重新导向至位于 {shopLink} 的 Roblox 周边商店。";
	}

	protected override string _GetTemplateForDescriptionPurchaseAgeWarning()
	{
		return "你必须年满 18 岁才能在网络上购买商品。";
	}

	protected override string _GetTemplateForDescriptionRetailWebsiteRedirect()
	{
		return "请注意，如果点按“继续”，你将会重新导向至并非由 Roblox 运营并操作的零售网站，该网站可能受不同的条款及隐私政策约束。";
	}

	protected override string _GetTemplateForHeadingLeavingRoblox()
	{
		return "你即将离开 Roblox";
	}
}
