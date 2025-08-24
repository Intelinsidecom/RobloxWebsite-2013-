namespace Roblox.TranslationResources.Feature;

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
	public override string ActionCancel => "キャンセル";

	/// <summary>
	/// Key: "Action.Continue"
	/// English String: "Continue"
	/// </summary>
	public override string ActionContinue => "続ける";

	/// <summary>
	/// Key: "Action.ContinueToShop"
	/// button text
	/// English String: "Continue to Shop"
	/// </summary>
	public override string ActionContinueToShop => "ショップに移動";

	/// <summary>
	/// Key: "Description.AgeWarning"
	/// age warning message
	/// English String: "Please note that you need to be over 18 to purchase products online. The Amazon store is not part of Roblox.com and is governed by a separate privacy policy."
	/// </summary>
	public override string DescriptionAgeWarning => "オンラインで商品を買うには、18歳以上である必要があります。AmazonストアはRoblox.comのサイトの一部でないため、別のプライバシーポリシーで管理されています。";

	/// <summary>
	/// Key: "Description.PurchaseAgeWarning"
	/// English String: "Please note that you need to be over 18 to purchase products online. We hope to see you again soon!"
	/// </summary>
	public override string DescriptionPurchaseAgeWarning => "オンラインで商品を買うには、18歳以上である必要があります。またのご利用をお待ちしています！";

	/// <summary>
	/// Key: "Description.RetailWebsiteRedirect"
	/// English String: "Heads up, Robloxian – by clicking “continue,” you will be redirected to a retail website that is not owned or operated by Roblox. They may have different terms and privacy policies."
	/// </summary>
	public override string DescriptionRetailWebsiteRedirect => "Robloxご利用者へのお知らせ – 「続ける」をクリックすると、Robloxが所有、管理していない販売用サイトに移動します。Robloxとは異なる利用規約やプライバシーポリシーが適用される場合があります。";

	/// <summary>
	/// Key: "Heading.LeavingRoblox"
	/// dialog heading
	/// English String: "You are leaving Roblox"
	/// </summary>
	public override string HeadingLeavingRoblox => "Robloxではないサイトに移動しています";

	public ShopDialogResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "キャンセル";
	}

	protected override string _GetTemplateForActionContinue()
	{
		return "続ける";
	}

	protected override string _GetTemplateForActionContinueToShop()
	{
		return "ショップに移動";
	}

	protected override string _GetTemplateForDescriptionAgeWarning()
	{
		return "オンラインで商品を買うには、18歳以上である必要があります。AmazonストアはRoblox.comのサイトの一部でないため、別のプライバシーポリシーで管理されています。";
	}

	/// <summary>
	/// Key: "Description.AmazonRedirect"
	/// message in the modal
	/// English String: "Your are about to visit our amazon store. You will be redirected to Roblox merchandise store on {shopLink}."
	/// </summary>
	public override string DescriptionAmazonRedirect(string shopLink)
	{
		return $"当社のAmazonストアにアクセスしようとしています。{shopLink}でRobloxの商品ストアに移動します。";
	}

	protected override string _GetTemplateForDescriptionAmazonRedirect()
	{
		return "当社のAmazonストアにアクセスしようとしています。{shopLink}でRobloxの商品ストアに移動します。";
	}

	protected override string _GetTemplateForDescriptionPurchaseAgeWarning()
	{
		return "オンラインで商品を買うには、18歳以上である必要があります。またのご利用をお待ちしています！";
	}

	protected override string _GetTemplateForDescriptionRetailWebsiteRedirect()
	{
		return "Robloxご利用者へのお知らせ – 「続ける」をクリックすると、Robloxが所有、管理していない販売用サイトに移動します。Robloxとは異なる利用規約やプライバシーポリシーが適用される場合があります。";
	}

	protected override string _GetTemplateForHeadingLeavingRoblox()
	{
		return "Robloxではないサイトに移動しています";
	}
}
