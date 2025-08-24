namespace Roblox.TranslationResources.Feature;

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
	public override string ActionCancel => "취소";

	/// <summary>
	/// Key: "Action.Continue"
	/// English String: "Continue"
	/// </summary>
	public override string ActionContinue => "계속";

	/// <summary>
	/// Key: "Action.ContinueToShop"
	/// button text
	/// English String: "Continue to Shop"
	/// </summary>
	public override string ActionContinueToShop => "상점으로 이동";

	/// <summary>
	/// Key: "Description.AgeWarning"
	/// age warning message
	/// English String: "Please note that you need to be over 18 to purchase products online. The Amazon store is not part of Roblox.com and is governed by a separate privacy policy."
	/// </summary>
	public override string DescriptionAgeWarning => "만 18세 이상 사용자만 온라인에서 상품을 구입할 수 있으며, Amazon 스토어는 Roblox.com에 속하지 않는 별개의 기업으로 별도의 개인정보 처리방침이 적용됩니다.";

	/// <summary>
	/// Key: "Description.PurchaseAgeWarning"
	/// English String: "Please note that you need to be over 18 to purchase products online. We hope to see you again soon!"
	/// </summary>
	public override string DescriptionPurchaseAgeWarning => "온라인에서 상품을 구매하려면 만 18세 이상이어야 해요. 곧 다시 뵙길 바래요!";

	/// <summary>
	/// Key: "Description.RetailWebsiteRedirect"
	/// English String: "Heads up, Robloxian – by clicking “continue,” you will be redirected to a retail website that is not owned or operated by Roblox. They may have different terms and privacy policies."
	/// </summary>
	public override string DescriptionRetailWebsiteRedirect => "Roblox 플레이어 여러분, 주의하세요. \"계속\"을 클릭하면 Roblox가 소유도 운영도 하지 않는 리테일 웹사이트로 이동하게 됩니다. 개인정보 취급방침이 다를 수 있어요.";

	/// <summary>
	/// Key: "Heading.LeavingRoblox"
	/// dialog heading
	/// English String: "You are leaving Roblox"
	/// </summary>
	public override string HeadingLeavingRoblox => "안녕히 가세요";

	public ShopDialogResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "취소";
	}

	protected override string _GetTemplateForActionContinue()
	{
		return "계속";
	}

	protected override string _GetTemplateForActionContinueToShop()
	{
		return "상점으로 이동";
	}

	protected override string _GetTemplateForDescriptionAgeWarning()
	{
		return "만 18세 이상 사용자만 온라인에서 상품을 구입할 수 있으며, Amazon 스토어는 Roblox.com에 속하지 않는 별개의 기업으로 별도의 개인정보 처리방침이 적용됩니다.";
	}

	/// <summary>
	/// Key: "Description.AmazonRedirect"
	/// message in the modal
	/// English String: "Your are about to visit our amazon store. You will be redirected to Roblox merchandise store on {shopLink}."
	/// </summary>
	public override string DescriptionAmazonRedirect(string shopLink)
	{
		return $"곧 {shopLink}에 있는 Roblox 상품 스토어로 이동합니다.";
	}

	protected override string _GetTemplateForDescriptionAmazonRedirect()
	{
		return "곧 {shopLink}에 있는 Roblox 상품 스토어로 이동합니다.";
	}

	protected override string _GetTemplateForDescriptionPurchaseAgeWarning()
	{
		return "온라인에서 상품을 구매하려면 만 18세 이상이어야 해요. 곧 다시 뵙길 바래요!";
	}

	protected override string _GetTemplateForDescriptionRetailWebsiteRedirect()
	{
		return "Roblox 플레이어 여러분, 주의하세요. \"계속\"을 클릭하면 Roblox가 소유도 운영도 하지 않는 리테일 웹사이트로 이동하게 됩니다. 개인정보 취급방침이 다를 수 있어요.";
	}

	protected override string _GetTemplateForHeadingLeavingRoblox()
	{
		return "안녕히 가세요";
	}
}
