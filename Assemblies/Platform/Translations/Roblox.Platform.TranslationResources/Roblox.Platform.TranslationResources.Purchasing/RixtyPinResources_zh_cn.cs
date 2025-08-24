namespace Roblox.TranslationResources.Purchasing;

/// <summary>
/// This class overrides RixtyPinResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class RixtyPinResources_zh_cn : RixtyPinResources_en_us, IRixtyPinResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.BuyNow"
	/// English String: "Buy Now"
	/// </summary>
	public override string ActionBuyNow => "立即购买";

	/// <summary>
	/// Key: "Action.BuyRobux"
	/// English String: "Buy Robux"
	/// </summary>
	public override string ActionBuyRobux => "购买 Robux";

	/// <summary>
	/// Key: "Action.MoreBCOptions"
	/// English String: "More Builders Club Options"
	/// </summary>
	public override string ActionMoreBCOptions => "更多 Builders Club 选项";

	/// <summary>
	/// Key: "Action.Redeem"
	/// English String: "Redeem"
	/// </summary>
	public override string ActionRedeem => "兑换";

	/// <summary>
	/// Key: "Heading.AlreadyHaveCredit"
	/// English String: "You have Roblox Credit!"
	/// </summary>
	public override string HeadingAlreadyHaveCredit => "你有 Roblox 点数！";

	/// <summary>
	/// Key: "Heading.BuyRobuxUsingRixty"
	/// English String: "Buy Robux using Rixty"
	/// </summary>
	public override string HeadingBuyRobuxUsingRixty => "使用 Rixty 购买 Robux";

	/// <summary>
	/// Key: "Heading.GetRobuxOrBcWithRixty"
	/// English String: "Get Robux or Builders Club with Rixty"
	/// </summary>
	public override string HeadingGetRobuxOrBcWithRixty => "使用 Rixty 获取 Robux 或加入 Builders Club";

	/// <summary>
	/// Key: "Heading.GetRobuxWithRixty"
	/// English String: "Get Robux with Rixty"
	/// </summary>
	public override string HeadingGetRobuxWithRixty => "使用 Rixty 获取 Robux";

	/// <summary>
	/// Key: "Heading.HowToUse"
	/// English String: "How to Use"
	/// </summary>
	public override string HeadingHowToUse => "使用说明";

	/// <summary>
	/// Key: "Heading.PayWithRixty"
	/// English String: "Pay with Rixty"
	/// </summary>
	public override string HeadingPayWithRixty => "使用 Rixty 支付";

	/// <summary>
	/// Key: "Heading.RedeemRixtyCards"
	/// English String: "Redeem Rixty Cards"
	/// </summary>
	public override string HeadingRedeemRixtyCards => "兑换 Rixty 卡";

	/// <summary>
	/// Key: "Label.AlreadyHaveAccount"
	/// English String: "I already have a Rixty account"
	/// </summary>
	public override string LabelAlreadyHaveAccount => "我已有 Rixty 帐户";

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
	public override string LabelEnterPin => "请输入 PIN：";

	/// <summary>
	/// Key: "Label.EnterPinImage"
	/// English String: "Enter Your PIN"
	/// </summary>
	public override string LabelEnterPinImage => "请输入你的 PIN";

	/// <summary>
	/// Key: "Label.FortyFiveDaysBC"
	/// English String: "45 Day Builders Club Extension - $10.00 (Existing BC members only)"
	/// </summary>
	public override string LabelFortyFiveDaysBC => "45 天 Builders Club 会员资格续订：$10.00（仅限现有 Builders Club 会员）";

	/// <summary>
	/// Key: "Label.InstructionForCombineCards"
	/// English String: "Combine cards for more Roblox credit."
	/// </summary>
	public override string LabelInstructionForCombineCards => "将卡合并来获得更多 Roblox 点数。";

	/// <summary>
	/// Key: "Label.InstructionForEnterPin"
	/// English String: "Enter your Rixty PIN."
	/// </summary>
	public override string LabelInstructionForEnterPin => "请输入你的 Rixty PIN。";

	/// <summary>
	/// Key: "Label.OrUppercase"
	/// English String: "OR"
	/// </summary>
	public override string LabelOrUppercase => "或";

	/// <summary>
	/// Key: "Label.PinImageText"
	/// English String: "Your PIN is on your receipt"
	/// </summary>
	public override string LabelPinImageText => "你的 PIN 在收据上";

	/// <summary>
	/// Key: "Label.RixtyLogo"
	/// English String: "Rixty Logo"
	/// </summary>
	public override string LabelRixtyLogo => "Rixty 标志";

	/// <summary>
	/// Key: "Label.Robux"
	/// English String: "Robux"
	/// </summary>
	public override string LabelRobux => "Robux";

	/// <summary>
	/// Key: "Label.ThirtyDaysBC"
	/// English String: "30 Days of Builders Club - $10.00"
	/// </summary>
	public override string LabelThirtyDaysBC => "30 天 Builders Club 会员资格：$10.00";

	/// <summary>
	/// Key: "Label.WhySpendCredit"
	/// English String: "Spend your Roblox credit on Robux and Builders Club!"
	/// </summary>
	public override string LabelWhySpendCredit => "你可将 Roblox 点数用在 Robux 和 Builders Club！";

	/// <summary>
	/// Key: "Label.YourBalance"
	/// English String: "Your Balance:"
	/// </summary>
	public override string LabelYourBalance => "你的余额：";

	/// <summary>
	/// Key: "Message.AnErrorOccurred"
	/// English String: "An error occurred"
	/// </summary>
	public override string MessageAnErrorOccurred => "发生错误";

	/// <summary>
	/// Key: "Message.Failure"
	/// English String: "Failure"
	/// </summary>
	public override string MessageFailure => "失败";

	/// <summary>
	/// Key: "Message.Loading"
	/// English String: "Loading"
	/// </summary>
	public override string MessageLoading => "正在加载";

	/// <summary>
	/// Key: "Message.PinAlreadyRedeemed"
	/// English String: "PIN already redeemed"
	/// </summary>
	public override string MessagePinAlreadyRedeemed => "PIN 已兑换";

	/// <summary>
	/// Key: "Message.RixtyUnavailable"
	/// English String: "Currently unavailable. Please try again later."
	/// </summary>
	public override string MessageRixtyUnavailable => "当前不可用。请稍后重试。";

	/// <summary>
	/// Key: "Message.Success"
	/// English String: "Success"
	/// </summary>
	public override string MessageSuccess => "成功";

	/// <summary>
	/// Key: "Message.SuccessfulRedemption"
	/// English String: "You have successfully redeemed your PIN!"
	/// </summary>
	public override string MessageSuccessfulRedemption => "你已成功兑换你的 PIN！";

	public RixtyPinResources_zh_cn(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionBuyNow()
	{
		return "立即购买";
	}

	protected override string _GetTemplateForActionBuyRobux()
	{
		return "购买 Robux";
	}

	protected override string _GetTemplateForActionMoreBCOptions()
	{
		return "更多 Builders Club 选项";
	}

	protected override string _GetTemplateForActionRedeem()
	{
		return "兑换";
	}

	/// <summary>
	/// Key: "Description.UseCashForRobux"
	/// English String: "With Rixty, you can use cash and coins to buy Robux and Builders Club.{lineBreak}No credit card? No problem!"
	/// </summary>
	public override string DescriptionUseCashForRobux(string lineBreak)
	{
		return $"有了 Rixty，你可以使用现金和金币购买 Robux 并加入 Builders Club。{lineBreak}没有信用卡？没问题！";
	}

	protected override string _GetTemplateForDescriptionUseCashForRobux()
	{
		return "有了 Rixty，你可以使用现金和金币购买 Robux 并加入 Builders Club。{lineBreak}没有信用卡？没问题！";
	}

	/// <summary>
	/// Key: "Description.UseCashForRobuxAndPremium"
	/// English String: "With Rixty, you can use cash and coins to buy Robux and Builders Club.{lineBreak}No credit card? No problem!"
	/// </summary>
	public override string DescriptionUseCashForRobuxAndPremium(string lineBreak)
	{
		return $"有了 Rixty，你可以使用现金和金币购买 Robux 并加入 Builders Club。{lineBreak}没有信用卡？没问题！";
	}

	protected override string _GetTemplateForDescriptionUseCashForRobuxAndPremium()
	{
		return "有了 Rixty，你可以使用现金和金币购买 Robux 并加入 Builders Club。{lineBreak}没有信用卡？没问题！";
	}

	protected override string _GetTemplateForHeadingAlreadyHaveCredit()
	{
		return "你有 Roblox 点数！";
	}

	protected override string _GetTemplateForHeadingBuyRobuxUsingRixty()
	{
		return "使用 Rixty 购买 Robux";
	}

	protected override string _GetTemplateForHeadingGetRobuxOrBcWithRixty()
	{
		return "使用 Rixty 获取 Robux 或加入 Builders Club";
	}

	protected override string _GetTemplateForHeadingGetRobuxWithRixty()
	{
		return "使用 Rixty 获取 Robux";
	}

	protected override string _GetTemplateForHeadingHowToUse()
	{
		return "使用说明";
	}

	protected override string _GetTemplateForHeadingPayWithRixty()
	{
		return "使用 Rixty 支付";
	}

	protected override string _GetTemplateForHeadingRedeemRixtyCards()
	{
		return "兑换 Rixty 卡";
	}

	protected override string _GetTemplateForLabelAlreadyHaveAccount()
	{
		return "我已有 Rixty 帐户";
	}

	/// <summary>
	/// Key: "Label.BuildersClubExtensionExisting"
	/// For example, 45 Day Builders Club Extension - $10.00 (Existing BC members only)
	/// English String: "{numberOfDays} Day Builders Club Extension - {cost} (Existing BC members only)"
	/// </summary>
	public override string LabelBuildersClubExtensionExisting(string numberOfDays, string cost)
	{
		return $"{numberOfDays} 天 Builders Club 会员资格续订 - {cost}（仅限现有 Builders Club 成员）";
	}

	protected override string _GetTemplateForLabelBuildersClubExtensionExisting()
	{
		return "{numberOfDays} 天 Builders Club 会员资格续订 - {cost}（仅限现有 Builders Club 成员）";
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
		return $"{numberOfDays} 天 Builders Club 会员资格续订：{cost}";
	}

	protected override string _GetTemplateForLabelBuildersClubOffer()
	{
		return "{numberOfDays} 天 Builders Club 会员资格续订：{cost}";
	}

	/// <summary>
	/// Key: "Label.BuyRobuxWithRixty"
	/// For example, "400 Robux for $4.95"
	/// English String: "{robuxAmount} Robux for {currencyAmount}"
	/// </summary>
	public override string LabelBuyRobuxWithRixty(string robuxAmount, string currencyAmount)
	{
		return $"以 {currencyAmount} 的价格购买 {robuxAmount} Robux";
	}

	protected override string _GetTemplateForLabelBuyRobuxWithRixty()
	{
		return "以 {currencyAmount} 的价格购买 {robuxAmount} Robux";
	}

	protected override string _GetTemplateForLabelEnterPin()
	{
		return "请输入 PIN：";
	}

	protected override string _GetTemplateForLabelEnterPinImage()
	{
		return "请输入你的 PIN";
	}

	protected override string _GetTemplateForLabelFortyFiveDaysBC()
	{
		return "45 天 Builders Club 会员资格续订：$10.00（仅限现有 Builders Club 会员）";
	}

	/// <summary>
	/// Key: "Label.GetPhysicalRixtyCard"
	/// English String: "{startLink}Go to your local store{endLink} and get a Rixty Card."
	/// </summary>
	public override string LabelGetPhysicalRixtyCard(string startLink, string endLink)
	{
		return $"{startLink}前往当地商店{endLink}，购买 Rixty 卡。";
	}

	protected override string _GetTemplateForLabelGetPhysicalRixtyCard()
	{
		return "{startLink}前往当地商店{endLink}，购买 Rixty 卡。";
	}

	protected override string _GetTemplateForLabelInstructionForCombineCards()
	{
		return "将卡合并来获得更多 Roblox 点数。";
	}

	protected override string _GetTemplateForLabelInstructionForEnterPin()
	{
		return "请输入你的 Rixty PIN。";
	}

	protected override string _GetTemplateForLabelOrUppercase()
	{
		return "或";
	}

	protected override string _GetTemplateForLabelPinImageText()
	{
		return "你的 PIN 在收据上";
	}

	protected override string _GetTemplateForLabelRixtyLogo()
	{
		return "Rixty 标志";
	}

	protected override string _GetTemplateForLabelRobux()
	{
		return "Robux";
	}

	protected override string _GetTemplateForLabelThirtyDaysBC()
	{
		return "30 天 Builders Club 会员资格：$10.00";
	}

	protected override string _GetTemplateForLabelWhySpendCredit()
	{
		return "你可将 Roblox 点数用在 Robux 和 Builders Club！";
	}

	protected override string _GetTemplateForLabelYourBalance()
	{
		return "你的余额：";
	}

	protected override string _GetTemplateForMessageAnErrorOccurred()
	{
		return "发生错误";
	}

	protected override string _GetTemplateForMessageFailure()
	{
		return "失败";
	}

	protected override string _GetTemplateForMessageLoading()
	{
		return "正在加载";
	}

	protected override string _GetTemplateForMessagePinAlreadyRedeemed()
	{
		return "PIN 已兑换";
	}

	protected override string _GetTemplateForMessageRixtyUnavailable()
	{
		return "当前不可用。请稍后重试。";
	}

	protected override string _GetTemplateForMessageSuccess()
	{
		return "成功";
	}

	protected override string _GetTemplateForMessageSuccessfulRedemption()
	{
		return "你已成功兑换你的 PIN！";
	}
}
