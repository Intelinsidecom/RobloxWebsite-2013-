namespace Roblox.TranslationResources.Purchasing;

/// <summary>
/// This class overrides RixtyPinResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class RixtyPinResources_zh_tw : RixtyPinResources_en_us, IRixtyPinResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.BuyNow"
	/// English String: "Buy Now"
	/// </summary>
	public override string ActionBuyNow => "現在購買";

	/// <summary>
	/// Key: "Action.BuyRobux"
	/// English String: "Buy Robux"
	/// </summary>
	public override string ActionBuyRobux => "購買 Robux";

	/// <summary>
	/// Key: "Action.MoreBCOptions"
	/// English String: "More Builders Club Options"
	/// </summary>
	public override string ActionMoreBCOptions => "更多 Builders Club 選項";

	/// <summary>
	/// Key: "Action.Redeem"
	/// English String: "Redeem"
	/// </summary>
	public override string ActionRedeem => "兌換";

	/// <summary>
	/// Key: "Heading.AlreadyHaveCredit"
	/// English String: "You have Roblox Credit!"
	/// </summary>
	public override string HeadingAlreadyHaveCredit => "您有 Roblox 點數！";

	/// <summary>
	/// Key: "Heading.BuyRobuxUsingRixty"
	/// English String: "Buy Robux using Rixty"
	/// </summary>
	public override string HeadingBuyRobuxUsingRixty => "以 Rixty 購買 Robux";

	/// <summary>
	/// Key: "Heading.GetRobuxOrBcWithRixty"
	/// English String: "Get Robux or Builders Club with Rixty"
	/// </summary>
	public override string HeadingGetRobuxOrBcWithRixty => "以 Rixty 取得 Robux 或 Builders Club";

	/// <summary>
	/// Key: "Heading.GetRobuxWithRixty"
	/// English String: "Get Robux with Rixty"
	/// </summary>
	public override string HeadingGetRobuxWithRixty => "以 Rixty 取得 Robux";

	/// <summary>
	/// Key: "Heading.HowToUse"
	/// English String: "How to Use"
	/// </summary>
	public override string HeadingHowToUse => "使用說明";

	/// <summary>
	/// Key: "Heading.PayWithRixty"
	/// English String: "Pay with Rixty"
	/// </summary>
	public override string HeadingPayWithRixty => "以 Rixty 付款";

	/// <summary>
	/// Key: "Heading.RedeemRixtyCards"
	/// English String: "Redeem Rixty Cards"
	/// </summary>
	public override string HeadingRedeemRixtyCards => "兌換 Rixty 點數卡";

	/// <summary>
	/// Key: "Label.AlreadyHaveAccount"
	/// English String: "I already have a Rixty account"
	/// </summary>
	public override string LabelAlreadyHaveAccount => "我有 Rixty 帳號";

	/// <summary>
	/// Key: "Label.BuildersClubImage"
	/// Alternate text for Builders Club image
	/// English String: "Builders Club"
	/// </summary>
	public override string LabelBuildersClubImage => "Builders Club";

	/// <summary>
	/// Key: "Label.EnterPin"
	/// English String: "Enter PIN:"
	/// </summary>
	public override string LabelEnterPin => "輸入 PIN：";

	/// <summary>
	/// Key: "Label.EnterPinImage"
	/// English String: "Enter Your PIN"
	/// </summary>
	public override string LabelEnterPinImage => "輸入您的 PIN";

	/// <summary>
	/// Key: "Label.FortyFiveDaysBC"
	/// English String: "45 Day Builders Club Extension - $10.00 (Existing BC members only)"
	/// </summary>
	public override string LabelFortyFiveDaysBC => "45 天 Builders Club 續約：$10.00（限 Builders Club 會員）";

	/// <summary>
	/// Key: "Label.InstructionForCombineCards"
	/// English String: "Combine cards for more Roblox credit."
	/// </summary>
	public override string LabelInstructionForCombineCards => "合併點數卡，取得更多 Roblox 點數。";

	/// <summary>
	/// Key: "Label.InstructionForEnterPin"
	/// English String: "Enter your Rixty PIN."
	/// </summary>
	public override string LabelInstructionForEnterPin => "輸入您的 Rixty PIN。";

	/// <summary>
	/// Key: "Label.OrUppercase"
	/// English String: "OR"
	/// </summary>
	public override string LabelOrUppercase => "或";

	/// <summary>
	/// Key: "Label.PinImageText"
	/// English String: "Your PIN is on your receipt"
	/// </summary>
	public override string LabelPinImageText => "您的 PIN 在您的收據上";

	/// <summary>
	/// Key: "Label.RixtyLogo"
	/// English String: "Rixty Logo"
	/// </summary>
	public override string LabelRixtyLogo => "Rixty 標誌";

	/// <summary>
	/// Key: "Label.Robux"
	/// English String: "Robux"
	/// </summary>
	public override string LabelRobux => "Robux";

	/// <summary>
	/// Key: "Label.ThirtyDaysBC"
	/// English String: "30 Days of Builders Club - $10.00"
	/// </summary>
	public override string LabelThirtyDaysBC => "30 天 Builders Club：$10.00";

	/// <summary>
	/// Key: "Label.WhySpendCredit"
	/// English String: "Spend your Roblox credit on Robux and Builders Club!"
	/// </summary>
	public override string LabelWhySpendCredit => "您可以將 Roblox 點數用在 Robux 和 Builders Club！";

	/// <summary>
	/// Key: "Label.YourBalance"
	/// English String: "Your Balance:"
	/// </summary>
	public override string LabelYourBalance => "您的餘額：";

	/// <summary>
	/// Key: "Message.AnErrorOccurred"
	/// English String: "An error occurred"
	/// </summary>
	public override string MessageAnErrorOccurred => "發生錯誤";

	/// <summary>
	/// Key: "Message.Failure"
	/// English String: "Failure"
	/// </summary>
	public override string MessageFailure => "失敗";

	/// <summary>
	/// Key: "Message.Loading"
	/// English String: "Loading"
	/// </summary>
	public override string MessageLoading => "正在載入";

	/// <summary>
	/// Key: "Message.PinAlreadyRedeemed"
	/// English String: "PIN already redeemed"
	/// </summary>
	public override string MessagePinAlreadyRedeemed => "PIN 已兌換";

	/// <summary>
	/// Key: "Message.RixtyUnavailable"
	/// English String: "Currently unavailable. Please try again later."
	/// </summary>
	public override string MessageRixtyUnavailable => "目前無法使用，請稍後再試。";

	/// <summary>
	/// Key: "Message.Success"
	/// English String: "Success"
	/// </summary>
	public override string MessageSuccess => "成功";

	/// <summary>
	/// Key: "Message.SuccessfulRedemption"
	/// English String: "You have successfully redeemed your PIN!"
	/// </summary>
	public override string MessageSuccessfulRedemption => "成功兌換 PIN ！";

	public RixtyPinResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionBuyNow()
	{
		return "現在購買";
	}

	protected override string _GetTemplateForActionBuyRobux()
	{
		return "購買 Robux";
	}

	protected override string _GetTemplateForActionMoreBCOptions()
	{
		return "更多 Builders Club 選項";
	}

	protected override string _GetTemplateForActionRedeem()
	{
		return "兌換";
	}

	/// <summary>
	/// Key: "Description.UseCashForRobux"
	/// English String: "With Rixty, you can use cash and coins to buy Robux and Builders Club.{lineBreak}No credit card? No problem!"
	/// </summary>
	public override string DescriptionUseCashForRobux(string lineBreak)
	{
		return $"有了 Rixty，您就可以使用現金與硬幣購買 Robux 與 Builders Club。{lineBreak}沒有信用卡嗎？沒問題";
	}

	protected override string _GetTemplateForDescriptionUseCashForRobux()
	{
		return "有了 Rixty，您就可以使用現金與硬幣購買 Robux 與 Builders Club。{lineBreak}沒有信用卡嗎？沒問題";
	}

	/// <summary>
	/// Key: "Description.UseCashForRobuxAndPremium"
	/// English String: "With Rixty, you can use cash and coins to buy Robux and Builders Club.{lineBreak}No credit card? No problem!"
	/// </summary>
	public override string DescriptionUseCashForRobuxAndPremium(string lineBreak)
	{
		return $"有了 Rixty，您就可以使用現金與硬幣購買 Robux 與 Builders Club。{lineBreak}沒有信用卡嗎？沒問題";
	}

	protected override string _GetTemplateForDescriptionUseCashForRobuxAndPremium()
	{
		return "有了 Rixty，您就可以使用現金與硬幣購買 Robux 與 Builders Club。{lineBreak}沒有信用卡嗎？沒問題";
	}

	protected override string _GetTemplateForHeadingAlreadyHaveCredit()
	{
		return "您有 Roblox 點數！";
	}

	protected override string _GetTemplateForHeadingBuyRobuxUsingRixty()
	{
		return "以 Rixty 購買 Robux";
	}

	protected override string _GetTemplateForHeadingGetRobuxOrBcWithRixty()
	{
		return "以 Rixty 取得 Robux 或 Builders Club";
	}

	protected override string _GetTemplateForHeadingGetRobuxWithRixty()
	{
		return "以 Rixty 取得 Robux";
	}

	protected override string _GetTemplateForHeadingHowToUse()
	{
		return "使用說明";
	}

	protected override string _GetTemplateForHeadingPayWithRixty()
	{
		return "以 Rixty 付款";
	}

	protected override string _GetTemplateForHeadingRedeemRixtyCards()
	{
		return "兌換 Rixty 點數卡";
	}

	protected override string _GetTemplateForLabelAlreadyHaveAccount()
	{
		return "我有 Rixty 帳號";
	}

	/// <summary>
	/// Key: "Label.BuildersClubExtensionExisting"
	/// For example, 45 Day Builders Club Extension - $10.00 (Existing BC members only)
	/// English String: "{numberOfDays} Day Builders Club Extension - {cost} (Existing BC members only)"
	/// </summary>
	public override string LabelBuildersClubExtensionExisting(string numberOfDays, string cost)
	{
		return $"{numberOfDays} 天 Builders Club 續約：{cost}（限 BC 會員）";
	}

	protected override string _GetTemplateForLabelBuildersClubExtensionExisting()
	{
		return "{numberOfDays} 天 Builders Club 續約：{cost}（限 BC 會員）";
	}

	protected override string _GetTemplateForLabelBuildersClubImage()
	{
		return "Builders Club";
	}

	/// <summary>
	/// Key: "Label.BuildersClubOffer"
	/// New purchase offer of builders club
	/// English String: "{numberOfDays} Days of Builders Club - {cost}"
	/// </summary>
	public override string LabelBuildersClubOffer(string numberOfDays, string cost)
	{
		return $"{numberOfDays} 天 Builders Club 續約：{cost}";
	}

	protected override string _GetTemplateForLabelBuildersClubOffer()
	{
		return "{numberOfDays} 天 Builders Club 續約：{cost}";
	}

	/// <summary>
	/// Key: "Label.BuyRobuxWithRixty"
	/// For example, "400 Robux for $4.95"
	/// English String: "{robuxAmount} Robux for {currencyAmount}"
	/// </summary>
	public override string LabelBuyRobuxWithRixty(string robuxAmount, string currencyAmount)
	{
		return $"以 {currencyAmount} 購買 {robuxAmount} Robux";
	}

	protected override string _GetTemplateForLabelBuyRobuxWithRixty()
	{
		return "以 {currencyAmount} 購買 {robuxAmount} Robux";
	}

	protected override string _GetTemplateForLabelEnterPin()
	{
		return "輸入 PIN：";
	}

	protected override string _GetTemplateForLabelEnterPinImage()
	{
		return "輸入您的 PIN";
	}

	protected override string _GetTemplateForLabelFortyFiveDaysBC()
	{
		return "45 天 Builders Club 續約：$10.00（限 Builders Club 會員）";
	}

	/// <summary>
	/// Key: "Label.GetPhysicalRixtyCard"
	/// English String: "{startLink}Go to your local store{endLink} and get a Rixty Card."
	/// </summary>
	public override string LabelGetPhysicalRixtyCard(string startLink, string endLink)
	{
		return $"{startLink}前往商家{endLink}購買 Rixty 點數卡。";
	}

	protected override string _GetTemplateForLabelGetPhysicalRixtyCard()
	{
		return "{startLink}前往商家{endLink}購買 Rixty 點數卡。";
	}

	protected override string _GetTemplateForLabelInstructionForCombineCards()
	{
		return "合併點數卡，取得更多 Roblox 點數。";
	}

	protected override string _GetTemplateForLabelInstructionForEnterPin()
	{
		return "輸入您的 Rixty PIN。";
	}

	protected override string _GetTemplateForLabelOrUppercase()
	{
		return "或";
	}

	protected override string _GetTemplateForLabelPinImageText()
	{
		return "您的 PIN 在您的收據上";
	}

	protected override string _GetTemplateForLabelRixtyLogo()
	{
		return "Rixty 標誌";
	}

	protected override string _GetTemplateForLabelRobux()
	{
		return "Robux";
	}

	protected override string _GetTemplateForLabelThirtyDaysBC()
	{
		return "30 天 Builders Club：$10.00";
	}

	protected override string _GetTemplateForLabelWhySpendCredit()
	{
		return "您可以將 Roblox 點數用在 Robux 和 Builders Club！";
	}

	protected override string _GetTemplateForLabelYourBalance()
	{
		return "您的餘額：";
	}

	protected override string _GetTemplateForMessageAnErrorOccurred()
	{
		return "發生錯誤";
	}

	protected override string _GetTemplateForMessageFailure()
	{
		return "失敗";
	}

	protected override string _GetTemplateForMessageLoading()
	{
		return "正在載入";
	}

	protected override string _GetTemplateForMessagePinAlreadyRedeemed()
	{
		return "PIN 已兌換";
	}

	protected override string _GetTemplateForMessageRixtyUnavailable()
	{
		return "目前無法使用，請稍後再試。";
	}

	protected override string _GetTemplateForMessageSuccess()
	{
		return "成功";
	}

	protected override string _GetTemplateForMessageSuccessfulRedemption()
	{
		return "成功兌換 PIN ！";
	}
}
