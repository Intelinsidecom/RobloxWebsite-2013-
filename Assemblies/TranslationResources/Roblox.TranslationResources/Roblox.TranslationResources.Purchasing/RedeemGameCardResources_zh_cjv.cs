namespace Roblox.TranslationResources.Purchasing;

/// <summary>
/// This class overrides RedeemGameCardResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class RedeemGameCardResources_zh_cjv : RedeemGameCardResources_en_us, IRedeemGameCardResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Dialog.Close"
	/// button text
	/// English String: "Close"
	/// </summary>
	public override string ActionDialogClose => "关闭";

	/// <summary>
	/// Key: "Action.Dialog.Login"
	/// button text
	/// English String: "Login"
	/// </summary>
	public override string ActionDialogLogin => "登录";

	/// <summary>
	/// Key: "Action.Dialog.SignUp"
	/// button text
	/// English String: "Sign Up"
	/// </summary>
	public override string ActionDialogSignUp => "注册";

	/// <summary>
	/// Key: "Action.PurchaseCard"
	/// link text
	/// English String: "Purchase Card"
	/// </summary>
	public override string ActionPurchaseCard => "购买礼品卡";

	/// <summary>
	/// Key: "Action.Redeem"
	/// button text
	/// English String: "Redeem"
	/// </summary>
	public override string ActionRedeem => "兑换";

	/// <summary>
	/// Key: "Description.CombineCards"
	/// bullet point in a list
	/// English String: "Combine cards for more Roblox credit."
	/// </summary>
	public override string DescriptionCombineCards => "将卡片合并来获得更多 Roblox 点数。";

	/// <summary>
	/// Key: "Description.Dialog.RobloxRedeemCard"
	/// diglog main text
	/// English String: "You must be logged in to your Roblox account to redeem your Game Card!"
	/// </summary>
	public override string DescriptionDialogRobloxRedeemCard => "若要兑换礼品卡，你必须先登录 Roblox 帐户。";

	/// <summary>
	/// Key: "Description.LegalDisclaimer"
	/// descrption text
	/// English String: "Purchases can be made with only one form of payment. Game card credits cannot be combined with other forms of payment."
	/// </summary>
	public override string DescriptionLegalDisclaimer => "购买时仅限使用一种付款方式。礼品卡点数无法与其他付款方式合并。";

	/// <summary>
	/// Key: "Description.RetailersInfo"
	/// bullet point of a list
	/// English String: "Buy a Roblox game card at one of the participating retailers or receive a Roblox gift card from someone."
	/// </summary>
	public override string DescriptionRetailersInfo => "请从任一合作零售商处购买 Roblox 礼品卡，或接受他人赠送的 Roblox 礼品卡。";

	/// <summary>
	/// Key: "Description.SpendRobloxCredit"
	/// bullet point of a list
	/// English String: "Spend your Roblox credit on Robux and Builders Club!"
	/// </summary>
	public override string DescriptionSpendRobloxCredit => "你可将 Roblox 点数用在 Robux 和 Builders Club！";

	/// <summary>
	/// Key: "Description.TypeCardPin"
	/// bullet point in a list
	/// English String: "Type in your card PIN in the redeem section."
	/// </summary>
	public override string DescriptionTypeCardPin => "请在兑换区中输入卡片上的 PIN。";

	/// <summary>
	/// Key: "Heading.EnterPin"
	/// section heading  - please keep PIN capitalized if the languiage supports it
	/// English String: "Enter PIN"
	/// </summary>
	public override string HeadingEnterPin => "请输入 PIN";

	/// <summary>
	/// Key: "Heading.GetRobloxCreditFor"
	/// section heading
	/// English String: "Get Roblox credit for"
	/// </summary>
	public override string HeadingGetRobloxCreditFor => "获得 Roblox 点数可用于";

	/// <summary>
	/// Key: "Heading.HowToRedeem"
	/// modal(dialog box) heading
	/// English String: "How to Redeem"
	/// </summary>
	public override string HeadingHowToRedeem => "兑换方法";

	/// <summary>
	/// Key: "Heading.HowToUse"
	/// section heading
	/// English String: "How to Use"
	/// </summary>
	public override string HeadingHowToUse => "使用说明";

	/// <summary>
	/// Key: "Heading.RedeemRobloxCards"
	/// page heading
	/// English String: "Redeem Roblox cards"
	/// </summary>
	public override string HeadingRedeemRobloxCards => "兑换 Roblox 礼品卡";

	/// <summary>
	/// Key: "Label.Dialog.RedeemGameCard"
	/// dialog title
	/// English String: "Redeem Roblox Game Card"
	/// </summary>
	public override string LabelDialogRedeemGameCard => "兑换 Roblox 礼品卡";

	/// <summary>
	/// Key: "Label.NeedGameCard"
	/// label
	/// English String: "Need a Roblox game card?"
	/// </summary>
	public override string LabelNeedGameCard => "需要 Roblox 礼品卡？";

	/// <summary>
	/// Key: "Label.PinCode"
	/// please keep PIN capitalized if language supports capitalization
	/// English String: "PIN Code"
	/// </summary>
	public override string LabelPinCode => "PIN 码";

	/// <summary>
	/// Key: "Label.RobuxRedeemed"
	/// English String: "Robux Redeemed:"
	/// </summary>
	public override string LabelRobuxRedeemed => "已兑换 Robux：";

	/// <summary>
	/// Key: "Label.YourBalance"
	/// label
	/// English String: "Your Credit Balance:"
	/// </summary>
	public override string LabelYourBalance => "你的点数余额：";

	/// <summary>
	/// Key: "Response.AlreadyRedeemedError"
	/// error message
	/// English String: "This gift card has already been redeemed."
	/// </summary>
	public override string ResponseAlreadyRedeemedError => "此礼品卡已被兑换。";

	/// <summary>
	/// Key: "Response.BonusPreview"
	/// success message upsell text
	/// English String: "Redeem one more Roblox card from GameStop to receive your bonus Robux."
	/// </summary>
	public override string ResponseBonusPreview => "从 GameStop 再兑换一张 Roblox 卡即可获得额外 Robux 奖励。";

	/// <summary>
	/// Key: "Response.BuildersClubExtended"
	/// success message
	/// English String: "Your Builders Club Membership has successfully been extended!"
	/// </summary>
	public override string ResponseBuildersClubExtended => "你的 Builders Club 会员资格已延期成功！";

	/// <summary>
	/// Key: "Response.BuildersClubExtendedSubText"
	/// sub text on success message
	/// English String: "Please allow up to 5 minutes for the changes to take effect."
	/// </summary>
	public override string ResponseBuildersClubExtendedSubText => "请稍候最多 5 分钟以等待更改生效。";

	/// <summary>
	/// Key: "Response.BuildersClubRedeemed"
	/// success message
	/// English String: "Your Builders Club Membership has successfully been redeemed!"
	/// </summary>
	public override string ResponseBuildersClubRedeemed => "你的 Builders Club 会员资格已成功兑换！";

	/// <summary>
	/// Key: "Response.CodeNotFoundError"
	/// error message
	/// English String: "No matching code found."
	/// </summary>
	public override string ResponseCodeNotFoundError => "未找到相符的代码。";

	/// <summary>
	/// Key: "Response.CouldNotFindObject"
	/// error message
	/// English String: "Could not find requested object."
	/// </summary>
	public override string ResponseCouldNotFindObject => "找不到所请求的对象。";

	/// <summary>
	/// Key: "Response.FeatureDisabledError"
	/// error message
	/// English String: "This feature is currently disabled."
	/// </summary>
	public override string ResponseFeatureDisabledError => "此功能当前已停用。";

	/// <summary>
	/// Key: "Response.GenericError"
	/// error message
	/// English String: "Something went wrong, please try again later."
	/// </summary>
	public override string ResponseGenericError => "发生错误，请稍后重试。";

	/// <summary>
	/// Key: "Response.InvalidPIN"
	/// error message
	/// English String: "Invalid PIN"
	/// </summary>
	public override string ResponseInvalidPIN => "PIN 无效";

	/// <summary>
	/// Key: "Response.LoginRequiredError"
	/// error message
	/// English String: "You must be logged in to perform this action."
	/// </summary>
	public override string ResponseLoginRequiredError => "你必须登录才能执行此操作。";

	/// <summary>
	/// Key: "Response.ObjectNotFoundError"
	/// error message
	/// English String: "Could not find the requested object. Please try your request again and contact customer service if this problem persists."
	/// </summary>
	public override string ResponseObjectNotFoundError => "找不到所请求的对象。请重试请求，如果问题仍然存在，请联系客户服务。";

	/// <summary>
	/// Key: "Response.RedeemSuccess"
	/// success message
	/// English String: "You have successfully redeemed your card!"
	/// </summary>
	public override string ResponseRedeemSuccess => "你已成功兑换卡片！";

	/// <summary>
	/// Key: "Response.TooManyCodesRedeemedError"
	/// error message
	/// English String: "Too many codes redeemed. Try your request again later."
	/// </summary>
	public override string ResponseTooManyCodesRedeemedError => "兑换代码过多。请稍后重新提交请求。";

	/// <summary>
	/// Key: "Response.TooManyRequestsError"
	/// error messages
	/// English String: "Too many failed request attempts. Try your request again later."
	/// </summary>
	public override string ResponseTooManyRequestsError => "失败请求尝试次数过多。请稍后重试。";

	public RedeemGameCardResources_zh_cjv(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionDialogClose()
	{
		return "关闭";
	}

	protected override string _GetTemplateForActionDialogLogin()
	{
		return "登录";
	}

	protected override string _GetTemplateForActionDialogSignUp()
	{
		return "注册";
	}

	protected override string _GetTemplateForActionPurchaseCard()
	{
		return "购买礼品卡";
	}

	protected override string _GetTemplateForActionRedeem()
	{
		return "兑换";
	}

	protected override string _GetTemplateForDescriptionCombineCards()
	{
		return "将卡片合并来获得更多 Roblox 点数。";
	}

	protected override string _GetTemplateForDescriptionDialogRobloxRedeemCard()
	{
		return "若要兑换礼品卡，你必须先登录 Roblox 帐户。";
	}

	protected override string _GetTemplateForDescriptionLegalDisclaimer()
	{
		return "购买时仅限使用一种付款方式。礼品卡点数无法与其他付款方式合并。";
	}

	/// <summary>
	/// Key: "Description.RetailerLink"
	/// bullet point in a list
	/// English String: "Buy a Roblox game card at one of the {retailerLinkStart}participating retailers{retailerLinkEnd} or receive a Roblox gift card from someone. "
	/// </summary>
	public override string DescriptionRetailerLink(string retailerLinkStart, string retailerLinkEnd)
	{
		return $"请从任一{retailerLinkStart}合作零售商{retailerLinkEnd}处购买 Roblox 礼品卡，或接受他人赠予的 Roblox 礼品卡。 ";
	}

	protected override string _GetTemplateForDescriptionRetailerLink()
	{
		return "请从任一{retailerLinkStart}合作零售商{retailerLinkEnd}处购买 Roblox 礼品卡，或接受他人赠予的 Roblox 礼品卡。 ";
	}

	protected override string _GetTemplateForDescriptionRetailersInfo()
	{
		return "请从任一合作零售商处购买 Roblox 礼品卡，或接受他人赠送的 Roblox 礼品卡。";
	}

	protected override string _GetTemplateForDescriptionSpendRobloxCredit()
	{
		return "你可将 Roblox 点数用在 Robux 和 Builders Club！";
	}

	protected override string _GetTemplateForDescriptionTypeCardPin()
	{
		return "请在兑换区中输入卡片上的 PIN。";
	}

	protected override string _GetTemplateForHeadingEnterPin()
	{
		return "请输入 PIN";
	}

	protected override string _GetTemplateForHeadingGetRobloxCreditFor()
	{
		return "获得 Roblox 点数可用于";
	}

	protected override string _GetTemplateForHeadingHowToRedeem()
	{
		return "兑换方法";
	}

	protected override string _GetTemplateForHeadingHowToUse()
	{
		return "使用说明";
	}

	protected override string _GetTemplateForHeadingRedeemRobloxCards()
	{
		return "兑换 Roblox 礼品卡";
	}

	protected override string _GetTemplateForLabelDialogRedeemGameCard()
	{
		return "兑换 Roblox 礼品卡";
	}

	protected override string _GetTemplateForLabelNeedGameCard()
	{
		return "需要 Roblox 礼品卡？";
	}

	protected override string _GetTemplateForLabelPinCode()
	{
		return "PIN 码";
	}

	protected override string _GetTemplateForLabelRobuxRedeemed()
	{
		return "已兑换 Robux：";
	}

	protected override string _GetTemplateForLabelYourBalance()
	{
		return "你的点数余额：";
	}

	protected override string _GetTemplateForResponseAlreadyRedeemedError()
	{
		return "此礼品卡已被兑换。";
	}

	protected override string _GetTemplateForResponseBonusPreview()
	{
		return "从 GameStop 再兑换一张 Roblox 卡即可获得额外 Robux 奖励。";
	}

	protected override string _GetTemplateForResponseBuildersClubExtended()
	{
		return "你的 Builders Club 会员资格已延期成功！";
	}

	protected override string _GetTemplateForResponseBuildersClubExtendedSubText()
	{
		return "请稍候最多 5 分钟以等待更改生效。";
	}

	protected override string _GetTemplateForResponseBuildersClubRedeemed()
	{
		return "你的 Builders Club 会员资格已成功兑换！";
	}

	protected override string _GetTemplateForResponseCodeNotFoundError()
	{
		return "未找到相符的代码。";
	}

	protected override string _GetTemplateForResponseCouldNotFindObject()
	{
		return "找不到所请求的对象。";
	}

	protected override string _GetTemplateForResponseFeatureDisabledError()
	{
		return "此功能当前已停用。";
	}

	protected override string _GetTemplateForResponseGenericError()
	{
		return "发生错误，请稍后重试。";
	}

	protected override string _GetTemplateForResponseInvalidPIN()
	{
		return "PIN 无效";
	}

	protected override string _GetTemplateForResponseLoginRequiredError()
	{
		return "你必须登录才能执行此操作。";
	}

	/// <summary>
	/// Key: "Response.MerchantNotFoundError"
	/// error message
	/// English String: "User tried to redeem Pin but the merchant does not exist. UserId: {authenticatedUserId} Pin Number: {cardPin}"
	/// </summary>
	public override string ResponseMerchantNotFoundError(string authenticatedUserId, string cardPin)
	{
		return $"用户尝试兑换 PIN，但商家不存在。用户 ID：{authenticatedUserId} PIN：{cardPin}";
	}

	protected override string _GetTemplateForResponseMerchantNotFoundError()
	{
		return "用户尝试兑换 PIN，但商家不存在。用户 ID：{authenticatedUserId} PIN：{cardPin}";
	}

	protected override string _GetTemplateForResponseObjectNotFoundError()
	{
		return "找不到所请求的对象。请重试请求，如果问题仍然存在，请联系客户服务。";
	}

	protected override string _GetTemplateForResponseRedeemSuccess()
	{
		return "你已成功兑换卡片！";
	}

	/// <summary>
	/// Key: "Response.RedeemSuccessForProduct"
	/// success message
	/// English String: "You have successfully redeemed your card for {productName}"
	/// </summary>
	public override string ResponseRedeemSuccessForProduct(string productName)
	{
		return $"你已成功将卡兑换为 {productName}";
	}

	protected override string _GetTemplateForResponseRedeemSuccessForProduct()
	{
		return "你已成功将卡兑换为 {productName}";
	}

	protected override string _GetTemplateForResponseTooManyCodesRedeemedError()
	{
		return "兑换代码过多。请稍后重新提交请求。";
	}

	protected override string _GetTemplateForResponseTooManyRequestsError()
	{
		return "失败请求尝试次数过多。请稍后重试。";
	}

	/// <summary>
	/// Key: "Response.TwoCardsBonus"
	/// success message
	/// English String: "Thanks for redeeming two Roblox cards from GameStop. {robuxCount} Robux have been added to your account."
	/// </summary>
	public override string ResponseTwoCardsBonus(string robuxCount)
	{
		return $"感谢你从 GameStop 兑换了两张 Roblox 卡。{robuxCount} Robux 已添加至你的帐户。";
	}

	protected override string _GetTemplateForResponseTwoCardsBonus()
	{
		return "感谢你从 GameStop 兑换了两张 Roblox 卡。{robuxCount} Robux 已添加至你的帐户。";
	}

	/// <summary>
	/// Key: "Response.WalmartRewardUpsell"
	/// upsell message
	/// English String: "Redeem one more Roblox card from Walmart to receive {rewardName}."
	/// </summary>
	public override string ResponseWalmartRewardUpsell(string rewardName)
	{
		return $"从 Walmart 再兑换一张 Roblox 卡即可获得 {rewardName}。";
	}

	protected override string _GetTemplateForResponseWalmartRewardUpsell()
	{
		return "从 Walmart 再兑换一张 Roblox 卡即可获得 {rewardName}。";
	}
}
