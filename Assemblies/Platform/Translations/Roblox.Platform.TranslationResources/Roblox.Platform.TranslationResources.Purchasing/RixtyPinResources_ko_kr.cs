namespace Roblox.TranslationResources.Purchasing;

/// <summary>
/// This class overrides RixtyPinResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class RixtyPinResources_ko_kr : RixtyPinResources_en_us, IRixtyPinResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.BuyNow"
	/// English String: "Buy Now"
	/// </summary>
	public override string ActionBuyNow => "지금 구매";

	/// <summary>
	/// Key: "Action.BuyRobux"
	/// English String: "Buy Robux"
	/// </summary>
	public override string ActionBuyRobux => "Robux 구매";

	/// <summary>
	/// Key: "Action.MoreBCOptions"
	/// English String: "More Builders Club Options"
	/// </summary>
	public override string ActionMoreBCOptions => "Builders Club 옵션 더 보기";

	/// <summary>
	/// Key: "Action.Redeem"
	/// English String: "Redeem"
	/// </summary>
	public override string ActionRedeem => "사용";

	/// <summary>
	/// Key: "Heading.AlreadyHaveCredit"
	/// English String: "You have Roblox Credit!"
	/// </summary>
	public override string HeadingAlreadyHaveCredit => "Roblox 크레딧이 있어요!";

	/// <summary>
	/// Key: "Heading.BuyRobuxUsingRixty"
	/// English String: "Buy Robux using Rixty"
	/// </summary>
	public override string HeadingBuyRobuxUsingRixty => "Rixty로 Robux 구매";

	/// <summary>
	/// Key: "Heading.GetRobuxOrBcWithRixty"
	/// English String: "Get Robux or Builders Club with Rixty"
	/// </summary>
	public override string HeadingGetRobuxOrBcWithRixty => "Rixty로 Robux 또는 Builders Club 구매하기";

	/// <summary>
	/// Key: "Heading.GetRobuxWithRixty"
	/// English String: "Get Robux with Rixty"
	/// </summary>
	public override string HeadingGetRobuxWithRixty => "Rixty로 Robux 구매";

	/// <summary>
	/// Key: "Heading.HowToUse"
	/// English String: "How to Use"
	/// </summary>
	public override string HeadingHowToUse => "사용 방법";

	/// <summary>
	/// Key: "Heading.PayWithRixty"
	/// English String: "Pay with Rixty"
	/// </summary>
	public override string HeadingPayWithRixty => "Rixty로 결제";

	/// <summary>
	/// Key: "Heading.RedeemRixtyCards"
	/// English String: "Redeem Rixty Cards"
	/// </summary>
	public override string HeadingRedeemRixtyCards => "Rixty 카드 사용";

	/// <summary>
	/// Key: "Label.AlreadyHaveAccount"
	/// English String: "I already have a Rixty account"
	/// </summary>
	public override string LabelAlreadyHaveAccount => "이미 Rixty 계정이 있어요";

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
	public override string LabelEnterPin => "PIN 입력:";

	/// <summary>
	/// Key: "Label.EnterPinImage"
	/// English String: "Enter Your PIN"
	/// </summary>
	public override string LabelEnterPinImage => "PIN 입력";

	/// <summary>
	/// Key: "Label.FortyFiveDaysBC"
	/// English String: "45 Day Builders Club Extension - $10.00 (Existing BC members only)"
	/// </summary>
	public override string LabelFortyFiveDaysBC => "45일 Builders Club 연장 - $10.00 (기존 BC 멤버만 해당)";

	/// <summary>
	/// Key: "Label.InstructionForCombineCards"
	/// English String: "Combine cards for more Roblox credit."
	/// </summary>
	public override string LabelInstructionForCombineCards => "카드를 결합하면 더 많은 Roblox 크레딧을 받으실 수 있습니다.";

	/// <summary>
	/// Key: "Label.InstructionForEnterPin"
	/// English String: "Enter your Rixty PIN."
	/// </summary>
	public override string LabelInstructionForEnterPin => "Rixty PIN을 입력하세요.";

	/// <summary>
	/// Key: "Label.OrUppercase"
	/// English String: "OR"
	/// </summary>
	public override string LabelOrUppercase => "또는";

	/// <summary>
	/// Key: "Label.PinImageText"
	/// English String: "Your PIN is on your receipt"
	/// </summary>
	public override string LabelPinImageText => "영수증에서 PIN을 확인하세요";

	/// <summary>
	/// Key: "Label.RixtyLogo"
	/// English String: "Rixty Logo"
	/// </summary>
	public override string LabelRixtyLogo => "Rixty 로고";

	/// <summary>
	/// Key: "Label.Robux"
	/// English String: "Robux"
	/// </summary>
	public override string LabelRobux => "Robux";

	/// <summary>
	/// Key: "Label.ThirtyDaysBC"
	/// English String: "30 Days of Builders Club - $10.00"
	/// </summary>
	public override string LabelThirtyDaysBC => "Builders Club 30일 - $10.00";

	/// <summary>
	/// Key: "Label.WhySpendCredit"
	/// English String: "Spend your Roblox credit on Robux and Builders Club!"
	/// </summary>
	public override string LabelWhySpendCredit => "Roblox 크레딧으로 Robux를 구입하거나 Builders Club에 가입하세요!";

	/// <summary>
	/// Key: "Label.YourBalance"
	/// English String: "Your Balance:"
	/// </summary>
	public override string LabelYourBalance => "잔액:";

	/// <summary>
	/// Key: "Message.AnErrorOccurred"
	/// English String: "An error occurred"
	/// </summary>
	public override string MessageAnErrorOccurred => "오류가 발생했어요";

	/// <summary>
	/// Key: "Message.Failure"
	/// English String: "Failure"
	/// </summary>
	public override string MessageFailure => "실패";

	/// <summary>
	/// Key: "Message.Loading"
	/// English String: "Loading"
	/// </summary>
	public override string MessageLoading => "로딩 중";

	/// <summary>
	/// Key: "Message.PinAlreadyRedeemed"
	/// English String: "PIN already redeemed"
	/// </summary>
	public override string MessagePinAlreadyRedeemed => "이미 사용한 PIN이에요";

	/// <summary>
	/// Key: "Message.RixtyUnavailable"
	/// English String: "Currently unavailable. Please try again later."
	/// </summary>
	public override string MessageRixtyUnavailable => "현재 이용 불가. 나중에 다시 시도하세요.";

	/// <summary>
	/// Key: "Message.Success"
	/// English String: "Success"
	/// </summary>
	public override string MessageSuccess => "성공";

	/// <summary>
	/// Key: "Message.SuccessfulRedemption"
	/// English String: "You have successfully redeemed your PIN!"
	/// </summary>
	public override string MessageSuccessfulRedemption => "PIN 사용을 완료했어요!";

	public RixtyPinResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionBuyNow()
	{
		return "지금 구매";
	}

	protected override string _GetTemplateForActionBuyRobux()
	{
		return "Robux 구매";
	}

	protected override string _GetTemplateForActionMoreBCOptions()
	{
		return "Builders Club 옵션 더 보기";
	}

	protected override string _GetTemplateForActionRedeem()
	{
		return "사용";
	}

	/// <summary>
	/// Key: "Description.UseCashForRobux"
	/// English String: "With Rixty, you can use cash and coins to buy Robux and Builders Club.{lineBreak}No credit card? No problem!"
	/// </summary>
	public override string DescriptionUseCashForRobux(string lineBreak)
	{
		return $"Rixty로 현금 및 코인을 사용해 Robux와 Builders Club을 구매할 수 있어요.{lineBreak}신용카드가 없다고요? 괜찮습니다!";
	}

	protected override string _GetTemplateForDescriptionUseCashForRobux()
	{
		return "Rixty로 현금 및 코인을 사용해 Robux와 Builders Club을 구매할 수 있어요.{lineBreak}신용카드가 없다고요? 괜찮습니다!";
	}

	/// <summary>
	/// Key: "Description.UseCashForRobuxAndPremium"
	/// English String: "With Rixty, you can use cash and coins to buy Robux and Builders Club.{lineBreak}No credit card? No problem!"
	/// </summary>
	public override string DescriptionUseCashForRobuxAndPremium(string lineBreak)
	{
		return $"Rixty를 통해 현금과 코인으로 Robux와 빌더스 클럽을 구매할 수 있어요.{lineBreak}신용카드가 없다고요? 괜찮습니다!";
	}

	protected override string _GetTemplateForDescriptionUseCashForRobuxAndPremium()
	{
		return "Rixty를 통해 현금과 코인으로 Robux와 빌더스 클럽을 구매할 수 있어요.{lineBreak}신용카드가 없다고요? 괜찮습니다!";
	}

	protected override string _GetTemplateForHeadingAlreadyHaveCredit()
	{
		return "Roblox 크레딧이 있어요!";
	}

	protected override string _GetTemplateForHeadingBuyRobuxUsingRixty()
	{
		return "Rixty로 Robux 구매";
	}

	protected override string _GetTemplateForHeadingGetRobuxOrBcWithRixty()
	{
		return "Rixty로 Robux 또는 Builders Club 구매하기";
	}

	protected override string _GetTemplateForHeadingGetRobuxWithRixty()
	{
		return "Rixty로 Robux 구매";
	}

	protected override string _GetTemplateForHeadingHowToUse()
	{
		return "사용 방법";
	}

	protected override string _GetTemplateForHeadingPayWithRixty()
	{
		return "Rixty로 결제";
	}

	protected override string _GetTemplateForHeadingRedeemRixtyCards()
	{
		return "Rixty 카드 사용";
	}

	protected override string _GetTemplateForLabelAlreadyHaveAccount()
	{
		return "이미 Rixty 계정이 있어요";
	}

	/// <summary>
	/// Key: "Label.BuildersClubExtensionExisting"
	/// For example, 45 Day Builders Club Extension - $10.00 (Existing BC members only)
	/// English String: "{numberOfDays} Day Builders Club Extension - {cost} (Existing BC members only)"
	/// </summary>
	public override string LabelBuildersClubExtensionExisting(string numberOfDays, string cost)
	{
		return $"{numberOfDays}일 Builders Club 연장 - {cost} (기존 BC 멤버만 해당)";
	}

	protected override string _GetTemplateForLabelBuildersClubExtensionExisting()
	{
		return "{numberOfDays}일 Builders Club 연장 - {cost} (기존 BC 멤버만 해당)";
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
		return $"Builders Club {numberOfDays}일 - {cost}";
	}

	protected override string _GetTemplateForLabelBuildersClubOffer()
	{
		return "Builders Club {numberOfDays}일 - {cost}";
	}

	/// <summary>
	/// Key: "Label.BuyRobuxWithRixty"
	/// For example, "400 Robux for $4.95"
	/// English String: "{robuxAmount} Robux for {currencyAmount}"
	/// </summary>
	public override string LabelBuyRobuxWithRixty(string robuxAmount, string currencyAmount)
	{
		return $"{currencyAmount}당 {robuxAmount} Robux ";
	}

	protected override string _GetTemplateForLabelBuyRobuxWithRixty()
	{
		return "{currencyAmount}당 {robuxAmount} Robux ";
	}

	protected override string _GetTemplateForLabelEnterPin()
	{
		return "PIN 입력:";
	}

	protected override string _GetTemplateForLabelEnterPinImage()
	{
		return "PIN 입력";
	}

	protected override string _GetTemplateForLabelFortyFiveDaysBC()
	{
		return "45일 Builders Club 연장 - $10.00 (기존 BC 멤버만 해당)";
	}

	/// <summary>
	/// Key: "Label.GetPhysicalRixtyCard"
	/// English String: "{startLink}Go to your local store{endLink} and get a Rixty Card."
	/// </summary>
	public override string LabelGetPhysicalRixtyCard(string startLink, string endLink)
	{
		return $"{startLink}인근 매장을 방문해{endLink} Rixty 카드를 구매하세요.";
	}

	protected override string _GetTemplateForLabelGetPhysicalRixtyCard()
	{
		return "{startLink}인근 매장을 방문해{endLink} Rixty 카드를 구매하세요.";
	}

	protected override string _GetTemplateForLabelInstructionForCombineCards()
	{
		return "카드를 결합하면 더 많은 Roblox 크레딧을 받으실 수 있습니다.";
	}

	protected override string _GetTemplateForLabelInstructionForEnterPin()
	{
		return "Rixty PIN을 입력하세요.";
	}

	protected override string _GetTemplateForLabelOrUppercase()
	{
		return "또는";
	}

	protected override string _GetTemplateForLabelPinImageText()
	{
		return "영수증에서 PIN을 확인하세요";
	}

	protected override string _GetTemplateForLabelRixtyLogo()
	{
		return "Rixty 로고";
	}

	protected override string _GetTemplateForLabelRobux()
	{
		return "Robux";
	}

	protected override string _GetTemplateForLabelThirtyDaysBC()
	{
		return "Builders Club 30일 - $10.00";
	}

	protected override string _GetTemplateForLabelWhySpendCredit()
	{
		return "Roblox 크레딧으로 Robux를 구입하거나 Builders Club에 가입하세요!";
	}

	protected override string _GetTemplateForLabelYourBalance()
	{
		return "잔액:";
	}

	protected override string _GetTemplateForMessageAnErrorOccurred()
	{
		return "오류가 발생했어요";
	}

	protected override string _GetTemplateForMessageFailure()
	{
		return "실패";
	}

	protected override string _GetTemplateForMessageLoading()
	{
		return "로딩 중";
	}

	protected override string _GetTemplateForMessagePinAlreadyRedeemed()
	{
		return "이미 사용한 PIN이에요";
	}

	protected override string _GetTemplateForMessageRixtyUnavailable()
	{
		return "현재 이용 불가. 나중에 다시 시도하세요.";
	}

	protected override string _GetTemplateForMessageSuccess()
	{
		return "성공";
	}

	protected override string _GetTemplateForMessageSuccessfulRedemption()
	{
		return "PIN 사용을 완료했어요!";
	}
}
