namespace Roblox.TranslationResources.Purchasing;

/// <summary>
/// This class overrides RedeemGameCardResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class RedeemGameCardResources_zh_tw : RedeemGameCardResources_en_us, IRedeemGameCardResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Dialog.Close"
	/// button text
	/// English String: "Close"
	/// </summary>
	public override string ActionDialogClose => "關閉";

	/// <summary>
	/// Key: "Action.Dialog.Login"
	/// button text
	/// English String: "Login"
	/// </summary>
	public override string ActionDialogLogin => "登入";

	/// <summary>
	/// Key: "Action.Dialog.SignUp"
	/// button text
	/// English String: "Sign Up"
	/// </summary>
	public override string ActionDialogSignUp => "註冊";

	/// <summary>
	/// Key: "Action.PurchaseCard"
	/// link text
	/// English String: "Purchase Card"
	/// </summary>
	public override string ActionPurchaseCard => "購買點數卡";

	/// <summary>
	/// Key: "Action.Redeem"
	/// button text
	/// English String: "Redeem"
	/// </summary>
	public override string ActionRedeem => "兌換";

	/// <summary>
	/// Key: "Description.CombineCards"
	/// bullet point in a list
	/// English String: "Combine cards for more Roblox credit."
	/// </summary>
	public override string DescriptionCombineCards => "合併點數卡，取得更多 Roblox 點數。";

	/// <summary>
	/// Key: "Description.Dialog.RobloxRedeemCard"
	/// diglog main text
	/// English String: "You must be logged in to your Roblox account to redeem your Game Card!"
	/// </summary>
	public override string DescriptionDialogRobloxRedeemCard => "若要兌換點數卡，請先登入 Roblox 帳號。";

	/// <summary>
	/// Key: "Description.LegalDisclaimer"
	/// descrption text
	/// English String: "Purchases can be made with only one form of payment. Game card credits cannot be combined with other forms of payment."
	/// </summary>
	public override string DescriptionLegalDisclaimer => "限以一種付款形式進行購買。點數卡點數無法與其他付款形式合併。";

	/// <summary>
	/// Key: "Description.RetailersInfo"
	/// bullet point of a list
	/// English String: "Buy a Roblox game card at one of the participating retailers or receive a Roblox gift card from someone."
	/// </summary>
	public override string DescriptionRetailersInfo => "請從合作商家購買 Roblox 點數卡，或者向他人取得 Roblox 點數卡。";

	/// <summary>
	/// Key: "Description.SpendRobloxCredit"
	/// bullet point of a list
	/// English String: "Spend your Roblox credit on Robux and Builders Club!"
	/// </summary>
	public override string DescriptionSpendRobloxCredit => "您可以將 Roblox 點數用在 Robux 和 Builders Club！";

	/// <summary>
	/// Key: "Description.TypeCardPin"
	/// bullet point in a list
	/// English String: "Type in your card PIN in the redeem section."
	/// </summary>
	public override string DescriptionTypeCardPin => "請在兌換區輸入點數卡上的 PIN。";

	/// <summary>
	/// Key: "Heading.EnterPin"
	/// section heading  - please keep PIN capitalized if the languiage supports it
	/// English String: "Enter PIN"
	/// </summary>
	public override string HeadingEnterPin => "輸入 PIN";

	/// <summary>
	/// Key: "Heading.GetRobloxCreditFor"
	/// section heading
	/// English String: "Get Roblox credit for"
	/// </summary>
	public override string HeadingGetRobloxCreditFor => "取得 Roblox 點數，用在";

	/// <summary>
	/// Key: "Heading.HowToRedeem"
	/// modal(dialog box) heading
	/// English String: "How to Redeem"
	/// </summary>
	public override string HeadingHowToRedeem => "兌換方式";

	/// <summary>
	/// Key: "Heading.HowToUse"
	/// section heading
	/// English String: "How to Use"
	/// </summary>
	public override string HeadingHowToUse => "使用說明";

	/// <summary>
	/// Key: "Heading.RedeemRobloxCards"
	/// page heading
	/// English String: "Redeem Roblox cards"
	/// </summary>
	public override string HeadingRedeemRobloxCards => "兌換 Roblox 點數卡";

	/// <summary>
	/// Key: "Label.Dialog.RedeemGameCard"
	/// dialog title
	/// English String: "Redeem Roblox Game Card"
	/// </summary>
	public override string LabelDialogRedeemGameCard => "兌換 Roblox 點數卡";

	/// <summary>
	/// Key: "Label.NeedGameCard"
	/// label
	/// English String: "Need a Roblox game card?"
	/// </summary>
	public override string LabelNeedGameCard => "需要 Roblox 點數卡？";

	/// <summary>
	/// Key: "Label.PinCode"
	/// please keep PIN capitalized if language supports capitalization
	/// English String: "PIN Code"
	/// </summary>
	public override string LabelPinCode => "PIN";

	/// <summary>
	/// Key: "Label.RobuxRedeemed"
	/// English String: "Robux Redeemed:"
	/// </summary>
	public override string LabelRobuxRedeemed => "已兌換 Robux：";

	/// <summary>
	/// Key: "Label.YourBalance"
	/// label
	/// English String: "Your Credit Balance:"
	/// </summary>
	public override string LabelYourBalance => "您的點數餘額：";

	/// <summary>
	/// Key: "Response.AlreadyRedeemedError"
	/// error message
	/// English String: "This gift card has already been redeemed."
	/// </summary>
	public override string ResponseAlreadyRedeemedError => "此點數卡已被兌換。";

	/// <summary>
	/// Key: "Response.BonusPreview"
	/// success message upsell text
	/// English String: "Redeem one more Roblox card from GameStop to receive your bonus Robux."
	/// </summary>
	public override string ResponseBonusPreview => "您只要再兌換一張 GameStop 的 Roblox 點數卡，就可以獲得獎勵 Robux。";

	/// <summary>
	/// Key: "Response.BuildersClubExtended"
	/// success message
	/// English String: "Your Builders Club Membership has successfully been extended!"
	/// </summary>
	public override string ResponseBuildersClubExtended => "成功延長 Builders Club 會員資格！";

	/// <summary>
	/// Key: "Response.BuildersClubExtendedSubText"
	/// sub text on success message
	/// English String: "Please allow up to 5 minutes for the changes to take effect."
	/// </summary>
	public override string ResponseBuildersClubExtendedSubText => "更新將在 5 分鐘內生效。";

	/// <summary>
	/// Key: "Response.BuildersClubRedeemed"
	/// success message
	/// English String: "Your Builders Club Membership has successfully been redeemed!"
	/// </summary>
	public override string ResponseBuildersClubRedeemed => "成功兌換 Builders Club 會員資格！";

	/// <summary>
	/// Key: "Response.CodeNotFoundError"
	/// error message
	/// English String: "No matching code found."
	/// </summary>
	public override string ResponseCodeNotFoundError => "沒有找到相符代碼。";

	/// <summary>
	/// Key: "Response.CouldNotFindObject"
	/// error message
	/// English String: "Could not find requested object."
	/// </summary>
	public override string ResponseCouldNotFindObject => "找不到請求的物件。";

	/// <summary>
	/// Key: "Response.FeatureDisabledError"
	/// error message
	/// English String: "This feature is currently disabled."
	/// </summary>
	public override string ResponseFeatureDisabledError => "此功能目前停用。";

	/// <summary>
	/// Key: "Response.GenericError"
	/// error message
	/// English String: "Something went wrong, please try again later."
	/// </summary>
	public override string ResponseGenericError => "發生錯誤，請稍後再試。";

	/// <summary>
	/// Key: "Response.InvalidPIN"
	/// error message
	/// English String: "Invalid PIN"
	/// </summary>
	public override string ResponseInvalidPIN => "PIN 無效";

	/// <summary>
	/// Key: "Response.LoginRequiredError"
	/// error message
	/// English String: "You must be logged in to perform this action."
	/// </summary>
	public override string ResponseLoginRequiredError => "若要執行此動作，請先登入。";

	/// <summary>
	/// Key: "Response.ObjectNotFoundError"
	/// error message
	/// English String: "Could not find the requested object. Please try your request again and contact customer service if this problem persists."
	/// </summary>
	public override string ResponseObjectNotFoundError => "找不到請求的物件，請重新嘗試。若此問題持續，請聯絡客服人員。";

	/// <summary>
	/// Key: "Response.RedeemSuccess"
	/// success message
	/// English String: "You have successfully redeemed your card!"
	/// </summary>
	public override string ResponseRedeemSuccess => "成功兌換點數卡！";

	/// <summary>
	/// Key: "Response.TooManyCodesRedeemedError"
	/// error message
	/// English String: "Too many codes redeemed. Try your request again later."
	/// </summary>
	public override string ResponseTooManyCodesRedeemedError => "已兌換過多代碼，請稍後再試。";

	/// <summary>
	/// Key: "Response.TooManyRequestsError"
	/// error messages
	/// English String: "Too many failed request attempts. Try your request again later."
	/// </summary>
	public override string ResponseTooManyRequestsError => "請求失敗次數過多，請稍後再試。";

	public RedeemGameCardResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionDialogClose()
	{
		return "關閉";
	}

	protected override string _GetTemplateForActionDialogLogin()
	{
		return "登入";
	}

	protected override string _GetTemplateForActionDialogSignUp()
	{
		return "註冊";
	}

	protected override string _GetTemplateForActionPurchaseCard()
	{
		return "購買點數卡";
	}

	protected override string _GetTemplateForActionRedeem()
	{
		return "兌換";
	}

	protected override string _GetTemplateForDescriptionCombineCards()
	{
		return "合併點數卡，取得更多 Roblox 點數。";
	}

	protected override string _GetTemplateForDescriptionDialogRobloxRedeemCard()
	{
		return "若要兌換點數卡，請先登入 Roblox 帳號。";
	}

	protected override string _GetTemplateForDescriptionLegalDisclaimer()
	{
		return "限以一種付款形式進行購買。點數卡點數無法與其他付款形式合併。";
	}

	/// <summary>
	/// Key: "Description.RetailerLink"
	/// bullet point in a list
	/// English String: "Buy a Roblox game card at one of the {retailerLinkStart}participating retailers{retailerLinkEnd} or receive a Roblox gift card from someone. "
	/// </summary>
	public override string DescriptionRetailerLink(string retailerLinkStart, string retailerLinkEnd)
	{
		return $"請從{retailerLinkStart}合作商家{retailerLinkEnd}購買 Roblox 點數卡，或者向他人取得 Roblox 點數卡。 ";
	}

	protected override string _GetTemplateForDescriptionRetailerLink()
	{
		return "請從{retailerLinkStart}合作商家{retailerLinkEnd}購買 Roblox 點數卡，或者向他人取得 Roblox 點數卡。 ";
	}

	protected override string _GetTemplateForDescriptionRetailersInfo()
	{
		return "請從合作商家購買 Roblox 點數卡，或者向他人取得 Roblox 點數卡。";
	}

	protected override string _GetTemplateForDescriptionSpendRobloxCredit()
	{
		return "您可以將 Roblox 點數用在 Robux 和 Builders Club！";
	}

	protected override string _GetTemplateForDescriptionTypeCardPin()
	{
		return "請在兌換區輸入點數卡上的 PIN。";
	}

	protected override string _GetTemplateForHeadingEnterPin()
	{
		return "輸入 PIN";
	}

	protected override string _GetTemplateForHeadingGetRobloxCreditFor()
	{
		return "取得 Roblox 點數，用在";
	}

	protected override string _GetTemplateForHeadingHowToRedeem()
	{
		return "兌換方式";
	}

	protected override string _GetTemplateForHeadingHowToUse()
	{
		return "使用說明";
	}

	protected override string _GetTemplateForHeadingRedeemRobloxCards()
	{
		return "兌換 Roblox 點數卡";
	}

	protected override string _GetTemplateForLabelDialogRedeemGameCard()
	{
		return "兌換 Roblox 點數卡";
	}

	protected override string _GetTemplateForLabelNeedGameCard()
	{
		return "需要 Roblox 點數卡？";
	}

	protected override string _GetTemplateForLabelPinCode()
	{
		return "PIN";
	}

	protected override string _GetTemplateForLabelRobuxRedeemed()
	{
		return "已兌換 Robux：";
	}

	protected override string _GetTemplateForLabelYourBalance()
	{
		return "您的點數餘額：";
	}

	protected override string _GetTemplateForResponseAlreadyRedeemedError()
	{
		return "此點數卡已被兌換。";
	}

	protected override string _GetTemplateForResponseBonusPreview()
	{
		return "您只要再兌換一張 GameStop 的 Roblox 點數卡，就可以獲得獎勵 Robux。";
	}

	protected override string _GetTemplateForResponseBuildersClubExtended()
	{
		return "成功延長 Builders Club 會員資格！";
	}

	protected override string _GetTemplateForResponseBuildersClubExtendedSubText()
	{
		return "更新將在 5 分鐘內生效。";
	}

	protected override string _GetTemplateForResponseBuildersClubRedeemed()
	{
		return "成功兌換 Builders Club 會員資格！";
	}

	protected override string _GetTemplateForResponseCodeNotFoundError()
	{
		return "沒有找到相符代碼。";
	}

	protected override string _GetTemplateForResponseCouldNotFindObject()
	{
		return "找不到請求的物件。";
	}

	protected override string _GetTemplateForResponseFeatureDisabledError()
	{
		return "此功能目前停用。";
	}

	protected override string _GetTemplateForResponseGenericError()
	{
		return "發生錯誤，請稍後再試。";
	}

	protected override string _GetTemplateForResponseInvalidPIN()
	{
		return "PIN 無效";
	}

	protected override string _GetTemplateForResponseLoginRequiredError()
	{
		return "若要執行此動作，請先登入。";
	}

	/// <summary>
	/// Key: "Response.MerchantNotFoundError"
	/// error message
	/// English String: "User tried to redeem Pin but the merchant does not exist. UserId: {authenticatedUserId} Pin Number: {cardPin}"
	/// </summary>
	public override string ResponseMerchantNotFoundError(string authenticatedUserId, string cardPin)
	{
		return $"使用者嘗試兌換 PIN，但商家不存在。使用者 ID：{authenticatedUserId} PIN：{cardPin}";
	}

	protected override string _GetTemplateForResponseMerchantNotFoundError()
	{
		return "使用者嘗試兌換 PIN，但商家不存在。使用者 ID：{authenticatedUserId} PIN：{cardPin}";
	}

	protected override string _GetTemplateForResponseObjectNotFoundError()
	{
		return "找不到請求的物件，請重新嘗試。若此問題持續，請聯絡客服人員。";
	}

	protected override string _GetTemplateForResponseRedeemSuccess()
	{
		return "成功兌換點數卡！";
	}

	/// <summary>
	/// Key: "Response.RedeemSuccessForProduct"
	/// success message
	/// English String: "You have successfully redeemed your card for {productName}"
	/// </summary>
	public override string ResponseRedeemSuccessForProduct(string productName)
	{
		return $"您已成功兌換{productName}！";
	}

	protected override string _GetTemplateForResponseRedeemSuccessForProduct()
	{
		return "您已成功兌換{productName}！";
	}

	protected override string _GetTemplateForResponseTooManyCodesRedeemedError()
	{
		return "已兌換過多代碼，請稍後再試。";
	}

	protected override string _GetTemplateForResponseTooManyRequestsError()
	{
		return "請求失敗次數過多，請稍後再試。";
	}

	/// <summary>
	/// Key: "Response.TwoCardsBonus"
	/// success message
	/// English String: "Thanks for redeeming two Roblox cards from GameStop. {robuxCount} Robux have been added to your account."
	/// </summary>
	public override string ResponseTwoCardsBonus(string robuxCount)
	{
		return $"謝謝您兌換兩張 GameStop 的 Roblox 點數卡，已新增 {robuxCount} Robux 到您的帳號。";
	}

	protected override string _GetTemplateForResponseTwoCardsBonus()
	{
		return "謝謝您兌換兩張 GameStop 的 Roblox 點數卡，已新增 {robuxCount} Robux 到您的帳號。";
	}

	/// <summary>
	/// Key: "Response.WalmartRewardUpsell"
	/// upsell message
	/// English String: "Redeem one more Roblox card from Walmart to receive {rewardName}."
	/// </summary>
	public override string ResponseWalmartRewardUpsell(string rewardName)
	{
		return $"您只要再兌換一張 Walmart 的 Roblox 點數卡，就可以獲得{rewardName}。";
	}

	protected override string _GetTemplateForResponseWalmartRewardUpsell()
	{
		return "您只要再兌換一張 Walmart 的 Roblox 點數卡，就可以獲得{rewardName}。";
	}
}
