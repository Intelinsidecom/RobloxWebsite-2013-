namespace Roblox.TranslationResources.Purchasing;

/// <summary>
/// This class overrides RedeemGameCardResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class RedeemGameCardResources_ko_kr : RedeemGameCardResources_en_us, IRedeemGameCardResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Dialog.Close"
	/// button text
	/// English String: "Close"
	/// </summary>
	public override string ActionDialogClose => "닫기";

	/// <summary>
	/// Key: "Action.Dialog.Login"
	/// button text
	/// English String: "Login"
	/// </summary>
	public override string ActionDialogLogin => "로그인";

	/// <summary>
	/// Key: "Action.Dialog.SignUp"
	/// button text
	/// English String: "Sign Up"
	/// </summary>
	public override string ActionDialogSignUp => "회원가입";

	/// <summary>
	/// Key: "Action.PurchaseCard"
	/// link text
	/// English String: "Purchase Card"
	/// </summary>
	public override string ActionPurchaseCard => "카드 구매";

	/// <summary>
	/// Key: "Action.Redeem"
	/// button text
	/// English String: "Redeem"
	/// </summary>
	public override string ActionRedeem => "사용";

	/// <summary>
	/// Key: "Description.CombineCards"
	/// bullet point in a list
	/// English String: "Combine cards for more Roblox credit."
	/// </summary>
	public override string DescriptionCombineCards => "카드를 결합하면 더 많은 Roblox 크레딧을 받으실 수 있습니다.";

	/// <summary>
	/// Key: "Description.Dialog.RobloxRedeemCard"
	/// diglog main text
	/// English String: "You must be logged in to your Roblox account to redeem your Game Card!"
	/// </summary>
	public override string DescriptionDialogRobloxRedeemCard => "게임카드를 사용하려면 Roblox 계정에 로그인해야 합니다!";

	/// <summary>
	/// Key: "Description.LegalDisclaimer"
	/// descrption text
	/// English String: "Purchases can be made with only one form of payment. Game card credits cannot be combined with other forms of payment."
	/// </summary>
	public override string DescriptionLegalDisclaimer => "구매 시 하나의 결제 수단만 사용하실 수 있습니다. 게임카드 크레딧은 다른 결제 수단과 함께 사용할 수 없어요.";

	/// <summary>
	/// Key: "Description.RetailersInfo"
	/// bullet point of a list
	/// English String: "Buy a Roblox game card at one of the participating retailers or receive a Roblox gift card from someone."
	/// </summary>
	public override string DescriptionRetailersInfo => "제휴 매장에서 Roblox 게임카드를 구매하거나 선물받은 Roblox 상품권을 이용하세요.";

	/// <summary>
	/// Key: "Description.SpendRobloxCredit"
	/// bullet point of a list
	/// English String: "Spend your Roblox credit on Robux and Builders Club!"
	/// </summary>
	public override string DescriptionSpendRobloxCredit => "Roblox 크레딧으로 Robux를 구입하거나 Builders Club에 가입하세요!";

	/// <summary>
	/// Key: "Description.TypeCardPin"
	/// bullet point in a list
	/// English String: "Type in your card PIN in the redeem section."
	/// </summary>
	public override string DescriptionTypeCardPin => "카드 사용란에 카드 PIN을 입력하세요.";

	/// <summary>
	/// Key: "Heading.EnterPin"
	/// section heading  - please keep PIN capitalized if the languiage supports it
	/// English String: "Enter PIN"
	/// </summary>
	public override string HeadingEnterPin => "PIN 입력";

	/// <summary>
	/// Key: "Heading.GetRobloxCreditFor"
	/// section heading
	/// English String: "Get Roblox credit for"
	/// </summary>
	public override string HeadingGetRobloxCreditFor => "Roblox 크레딧으로 구입해보세요";

	/// <summary>
	/// Key: "Heading.HowToRedeem"
	/// modal(dialog box) heading
	/// English String: "How to Redeem"
	/// </summary>
	public override string HeadingHowToRedeem => "사용 방법";

	/// <summary>
	/// Key: "Heading.HowToUse"
	/// section heading
	/// English String: "How to Use"
	/// </summary>
	public override string HeadingHowToUse => "사용 방법";

	/// <summary>
	/// Key: "Heading.RedeemRobloxCards"
	/// page heading
	/// English String: "Redeem Roblox cards"
	/// </summary>
	public override string HeadingRedeemRobloxCards => "Roblox 카드 사용";

	/// <summary>
	/// Key: "Label.Dialog.RedeemGameCard"
	/// dialog title
	/// English String: "Redeem Roblox Game Card"
	/// </summary>
	public override string LabelDialogRedeemGameCard => "Roblox 게임카드 사용";

	/// <summary>
	/// Key: "Label.NeedGameCard"
	/// label
	/// English String: "Need a Roblox game card?"
	/// </summary>
	public override string LabelNeedGameCard => "Roblox 게임카드가 필요하세요?";

	/// <summary>
	/// Key: "Label.PinCode"
	/// please keep PIN capitalized if language supports capitalization
	/// English String: "PIN Code"
	/// </summary>
	public override string LabelPinCode => "PIN 코드";

	/// <summary>
	/// Key: "Label.RobuxRedeemed"
	/// English String: "Robux Redeemed:"
	/// </summary>
	public override string LabelRobuxRedeemed => "교환받은 Robux:";

	/// <summary>
	/// Key: "Label.YourBalance"
	/// label
	/// English String: "Your Credit Balance:"
	/// </summary>
	public override string LabelYourBalance => "나의 크레딧 잔액:";

	/// <summary>
	/// Key: "Response.AlreadyRedeemedError"
	/// error message
	/// English String: "This gift card has already been redeemed."
	/// </summary>
	public override string ResponseAlreadyRedeemedError => "이미 사용한 상품권입니다.";

	/// <summary>
	/// Key: "Response.BonusPreview"
	/// success message upsell text
	/// English String: "Redeem one more Roblox card from GameStop to receive your bonus Robux."
	/// </summary>
	public override string ResponseBonusPreview => "GameStop에서 구입한 Roblox 카드를 한 장 더 사용하시고 보너스 Robux도 받아보세요.";

	/// <summary>
	/// Key: "Response.BuildersClubExtended"
	/// success message
	/// English String: "Your Builders Club Membership has successfully been extended!"
	/// </summary>
	public override string ResponseBuildersClubExtended => "Builders Club 멤버십 연장을 완료했어요!";

	/// <summary>
	/// Key: "Response.BuildersClubExtendedSubText"
	/// sub text on success message
	/// English String: "Please allow up to 5 minutes for the changes to take effect."
	/// </summary>
	public override string ResponseBuildersClubExtendedSubText => "변경 사항을 적용하려면 최대 5 분이 소요됩니다.";

	/// <summary>
	/// Key: "Response.BuildersClubRedeemed"
	/// success message
	/// English String: "Your Builders Club Membership has successfully been redeemed!"
	/// </summary>
	public override string ResponseBuildersClubRedeemed => "Builders Club 멤버십 구매를 완료했어요!";

	/// <summary>
	/// Key: "Response.CodeNotFoundError"
	/// error message
	/// English String: "No matching code found."
	/// </summary>
	public override string ResponseCodeNotFoundError => "일치하는 코드가 없습니다.";

	/// <summary>
	/// Key: "Response.CouldNotFindObject"
	/// error message
	/// English String: "Could not find requested object."
	/// </summary>
	public override string ResponseCouldNotFindObject => "요청한 대상을 찾을 수 없습니다.";

	/// <summary>
	/// Key: "Response.FeatureDisabledError"
	/// error message
	/// English String: "This feature is currently disabled."
	/// </summary>
	public override string ResponseFeatureDisabledError => "본 기능은 현재 비활성화 상태입니다.";

	/// <summary>
	/// Key: "Response.GenericError"
	/// error message
	/// English String: "Something went wrong, please try again later."
	/// </summary>
	public override string ResponseGenericError => "오류가 발생했어요. 나중에 다시 시도하세요.";

	/// <summary>
	/// Key: "Response.InvalidPIN"
	/// error message
	/// English String: "Invalid PIN"
	/// </summary>
	public override string ResponseInvalidPIN => "유효하지 않은 PIN";

	/// <summary>
	/// Key: "Response.LoginRequiredError"
	/// error message
	/// English String: "You must be logged in to perform this action."
	/// </summary>
	public override string ResponseLoginRequiredError => "본 작업을 수행하려면 Roblox 계정에 로그인하세요!";

	/// <summary>
	/// Key: "Response.ObjectNotFoundError"
	/// error message
	/// English String: "Could not find the requested object. Please try your request again and contact customer service if this problem persists."
	/// </summary>
	public override string ResponseObjectNotFoundError => "요청한 대상을 찾을 수 없습니다. 나중에 다시 시도하세요. 문제가 계속되면 고객지원으로 문의하세요.";

	/// <summary>
	/// Key: "Response.RedeemSuccess"
	/// success message
	/// English String: "You have successfully redeemed your card!"
	/// </summary>
	public override string ResponseRedeemSuccess => "카드 사용을 완료했어요!";

	/// <summary>
	/// Key: "Response.TooManyCodesRedeemedError"
	/// error message
	/// English String: "Too many codes redeemed. Try your request again later."
	/// </summary>
	public override string ResponseTooManyCodesRedeemedError => "코드 사용 가능 횟수를 초과했어요. 나중에 다시 시도하세요.";

	/// <summary>
	/// Key: "Response.TooManyRequestsError"
	/// error messages
	/// English String: "Too many failed request attempts. Try your request again later."
	/// </summary>
	public override string ResponseTooManyRequestsError => "시도 가능 횟수를 초과했습니다. 나중에 다시 시도하세요.";

	public RedeemGameCardResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionDialogClose()
	{
		return "닫기";
	}

	protected override string _GetTemplateForActionDialogLogin()
	{
		return "로그인";
	}

	protected override string _GetTemplateForActionDialogSignUp()
	{
		return "회원가입";
	}

	protected override string _GetTemplateForActionPurchaseCard()
	{
		return "카드 구매";
	}

	protected override string _GetTemplateForActionRedeem()
	{
		return "사용";
	}

	protected override string _GetTemplateForDescriptionCombineCards()
	{
		return "카드를 결합하면 더 많은 Roblox 크레딧을 받으실 수 있습니다.";
	}

	protected override string _GetTemplateForDescriptionDialogRobloxRedeemCard()
	{
		return "게임카드를 사용하려면 Roblox 계정에 로그인해야 합니다!";
	}

	protected override string _GetTemplateForDescriptionLegalDisclaimer()
	{
		return "구매 시 하나의 결제 수단만 사용하실 수 있습니다. 게임카드 크레딧은 다른 결제 수단과 함께 사용할 수 없어요.";
	}

	/// <summary>
	/// Key: "Description.RetailerLink"
	/// bullet point in a list
	/// English String: "Buy a Roblox game card at one of the {retailerLinkStart}participating retailers{retailerLinkEnd} or receive a Roblox gift card from someone. "
	/// </summary>
	public override string DescriptionRetailerLink(string retailerLinkStart, string retailerLinkEnd)
	{
		return $"{retailerLinkStart}제휴 매장{retailerLinkEnd}에서 Roblox 게임카드를 구매하거나 선물받은\nRoblox 상품권을 이용하세요.";
	}

	protected override string _GetTemplateForDescriptionRetailerLink()
	{
		return "{retailerLinkStart}제휴 매장{retailerLinkEnd}에서 Roblox 게임카드를 구매하거나 선물받은\nRoblox 상품권을 이용하세요.";
	}

	protected override string _GetTemplateForDescriptionRetailersInfo()
	{
		return "제휴 매장에서 Roblox 게임카드를 구매하거나 선물받은 Roblox 상품권을 이용하세요.";
	}

	protected override string _GetTemplateForDescriptionSpendRobloxCredit()
	{
		return "Roblox 크레딧으로 Robux를 구입하거나 Builders Club에 가입하세요!";
	}

	protected override string _GetTemplateForDescriptionTypeCardPin()
	{
		return "카드 사용란에 카드 PIN을 입력하세요.";
	}

	protected override string _GetTemplateForHeadingEnterPin()
	{
		return "PIN 입력";
	}

	protected override string _GetTemplateForHeadingGetRobloxCreditFor()
	{
		return "Roblox 크레딧으로 구입해보세요";
	}

	protected override string _GetTemplateForHeadingHowToRedeem()
	{
		return "사용 방법";
	}

	protected override string _GetTemplateForHeadingHowToUse()
	{
		return "사용 방법";
	}

	protected override string _GetTemplateForHeadingRedeemRobloxCards()
	{
		return "Roblox 카드 사용";
	}

	protected override string _GetTemplateForLabelDialogRedeemGameCard()
	{
		return "Roblox 게임카드 사용";
	}

	protected override string _GetTemplateForLabelNeedGameCard()
	{
		return "Roblox 게임카드가 필요하세요?";
	}

	protected override string _GetTemplateForLabelPinCode()
	{
		return "PIN 코드";
	}

	protected override string _GetTemplateForLabelRobuxRedeemed()
	{
		return "교환받은 Robux:";
	}

	protected override string _GetTemplateForLabelYourBalance()
	{
		return "나의 크레딧 잔액:";
	}

	protected override string _GetTemplateForResponseAlreadyRedeemedError()
	{
		return "이미 사용한 상품권입니다.";
	}

	protected override string _GetTemplateForResponseBonusPreview()
	{
		return "GameStop에서 구입한 Roblox 카드를 한 장 더 사용하시고 보너스 Robux도 받아보세요.";
	}

	protected override string _GetTemplateForResponseBuildersClubExtended()
	{
		return "Builders Club 멤버십 연장을 완료했어요!";
	}

	protected override string _GetTemplateForResponseBuildersClubExtendedSubText()
	{
		return "변경 사항을 적용하려면 최대 5 분이 소요됩니다.";
	}

	protected override string _GetTemplateForResponseBuildersClubRedeemed()
	{
		return "Builders Club 멤버십 구매를 완료했어요!";
	}

	protected override string _GetTemplateForResponseCodeNotFoundError()
	{
		return "일치하는 코드가 없습니다.";
	}

	protected override string _GetTemplateForResponseCouldNotFindObject()
	{
		return "요청한 대상을 찾을 수 없습니다.";
	}

	protected override string _GetTemplateForResponseFeatureDisabledError()
	{
		return "본 기능은 현재 비활성화 상태입니다.";
	}

	protected override string _GetTemplateForResponseGenericError()
	{
		return "오류가 발생했어요. 나중에 다시 시도하세요.";
	}

	protected override string _GetTemplateForResponseInvalidPIN()
	{
		return "유효하지 않은 PIN";
	}

	protected override string _GetTemplateForResponseLoginRequiredError()
	{
		return "본 작업을 수행하려면 Roblox 계정에 로그인하세요!";
	}

	/// <summary>
	/// Key: "Response.MerchantNotFoundError"
	/// error message
	/// English String: "User tried to redeem Pin but the merchant does not exist. UserId: {authenticatedUserId} Pin Number: {cardPin}"
	/// </summary>
	public override string ResponseMerchantNotFoundError(string authenticatedUserId, string cardPin)
	{
		return $"사용자가 PIN 사용을 시도했지만 판매자가 존재하지 않습니다. 사용자 ID: {authenticatedUserId} PIN 번호: {cardPin}";
	}

	protected override string _GetTemplateForResponseMerchantNotFoundError()
	{
		return "사용자가 PIN 사용을 시도했지만 판매자가 존재하지 않습니다. 사용자 ID: {authenticatedUserId} PIN 번호: {cardPin}";
	}

	protected override string _GetTemplateForResponseObjectNotFoundError()
	{
		return "요청한 대상을 찾을 수 없습니다. 나중에 다시 시도하세요. 문제가 계속되면 고객지원으로 문의하세요.";
	}

	protected override string _GetTemplateForResponseRedeemSuccess()
	{
		return "카드 사용을 완료했어요!";
	}

	/// <summary>
	/// Key: "Response.RedeemSuccessForProduct"
	/// success message
	/// English String: "You have successfully redeemed your card for {productName}"
	/// </summary>
	public override string ResponseRedeemSuccessForProduct(string productName)
	{
		return $"카드로 {productName}을(를) 구매했어요!";
	}

	protected override string _GetTemplateForResponseRedeemSuccessForProduct()
	{
		return "카드로 {productName}을(를) 구매했어요!";
	}

	protected override string _GetTemplateForResponseTooManyCodesRedeemedError()
	{
		return "코드 사용 가능 횟수를 초과했어요. 나중에 다시 시도하세요.";
	}

	protected override string _GetTemplateForResponseTooManyRequestsError()
	{
		return "시도 가능 횟수를 초과했습니다. 나중에 다시 시도하세요.";
	}

	/// <summary>
	/// Key: "Response.TwoCardsBonus"
	/// success message
	/// English String: "Thanks for redeeming two Roblox cards from GameStop. {robuxCount} Robux have been added to your account."
	/// </summary>
	public override string ResponseTwoCardsBonus(string robuxCount)
	{
		return $"GameStop에서 구입한 두 장의 Roblox 카드를 사용해 주셔서 감사합니다. 계정에 {robuxCount} Robux가 적립되었어요.";
	}

	protected override string _GetTemplateForResponseTwoCardsBonus()
	{
		return "GameStop에서 구입한 두 장의 Roblox 카드를 사용해 주셔서 감사합니다. 계정에 {robuxCount} Robux가 적립되었어요.";
	}

	/// <summary>
	/// Key: "Response.WalmartRewardUpsell"
	/// upsell message
	/// English String: "Redeem one more Roblox card from Walmart to receive {rewardName}."
	/// </summary>
	public override string ResponseWalmartRewardUpsell(string rewardName)
	{
		return $"Walmart에서 구입한 Roblox 카드를 한 장 더 사용하시고 보너스 {rewardName}도 받아보세요.";
	}

	protected override string _GetTemplateForResponseWalmartRewardUpsell()
	{
		return "Walmart에서 구입한 Roblox 카드를 한 장 더 사용하시고 보너스 {rewardName}도 받아보세요.";
	}
}
