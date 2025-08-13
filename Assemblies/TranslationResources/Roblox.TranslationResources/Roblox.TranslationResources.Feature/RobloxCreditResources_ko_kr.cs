namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides RobloxCreditResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class RobloxCreditResources_ko_kr : RobloxCreditResources_en_us, IRobloxCreditResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.ConvertToRobux"
	/// English String: "Convert To Robux"
	/// </summary>
	public override string ActionConvertToRobux => "Robux로 전환";

	/// <summary>
	/// Key: "Action.Redeem"
	/// English String: "Redeem"
	/// </summary>
	public override string ActionRedeem => "사용";

	/// <summary>
	/// Key: "Heading.GetRobux"
	/// English String: "Get Robux"
	/// </summary>
	public override string HeadingGetRobux => "Robux 얻기";

	/// <summary>
	/// Key: "Heading.RobloxCredit"
	/// English String: "Roblox credit"
	/// </summary>
	public override string HeadingRobloxCredit => "Roblox 크레딧";

	/// <summary>
	/// Key: "Message.FailedDebitRobloxCredit"
	/// English String: "There has been an issue processing your Roblox credit. Please try again later!"
	/// </summary>
	public override string MessageFailedDebitRobloxCredit => "Roblox 크레딧 처리에 문제가 발생했습니다. 나중에 다시 시도해 주세요!";

	/// <summary>
	/// Key: "Message.FailedGrantingRobux"
	/// English String: "We’ve credited your Roblox credits, but there was an issue processing your Robux grant. Please contact customer support to get your Robux."
	/// </summary>
	public override string MessageFailedGrantingRobux => "Roblox 크레딧 사용은 완료되었지만, 오류로 인해 Robux를 지급받지 못하셨어요. 지원 센터에 연락해 Robux를 받으세요.";

	public RobloxCreditResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionConvertToRobux()
	{
		return "Robux로 전환";
	}

	protected override string _GetTemplateForActionRedeem()
	{
		return "사용";
	}

	/// <summary>
	/// Key: "Description.ConfirmRobloxCreditToRobuxRedemption"
	/// English String: "Redeem your {balance} Roblox credit to {iconRobux} {robuxAmount}"
	/// </summary>
	public override string DescriptionConfirmRobloxCreditToRobuxRedemption(string balance, string iconRobux, string robuxAmount)
	{
		return $"{balance} Roblox 크레딧을 {iconRobux}{robuxAmount}로 교환하세요";
	}

	protected override string _GetTemplateForDescriptionConfirmRobloxCreditToRobuxRedemption()
	{
		return "{balance} Roblox 크레딧을 {iconRobux}{robuxAmount}로 교환하세요";
	}

	protected override string _GetTemplateForHeadingGetRobux()
	{
		return "Robux 얻기";
	}

	protected override string _GetTemplateForHeadingRobloxCredit()
	{
		return "Roblox 크레딧";
	}

	/// <summary>
	/// Key: "Label.CurrentBalance"
	/// Roblox Credit Balance
	/// English String: "Current Balance: ${balance}"
	/// </summary>
	public override string LabelCurrentBalance(string balance)
	{
		return $"현재 잔액: ${balance}";
	}

	protected override string _GetTemplateForLabelCurrentBalance()
	{
		return "현재 잔액: ${balance}";
	}

	protected override string _GetTemplateForMessageFailedDebitRobloxCredit()
	{
		return "Roblox 크레딧 처리에 문제가 발생했습니다. 나중에 다시 시도해 주세요!";
	}

	protected override string _GetTemplateForMessageFailedGrantingRobux()
	{
		return "Roblox 크레딧 사용은 완료되었지만, 오류로 인해 Robux를 지급받지 못하셨어요. 지원 센터에 연락해 Robux를 받으세요.";
	}

	/// <summary>
	/// Key: "Message.RobloxCreditToRobuxRedemptionConfirmation"
	/// English String: "You've successfully redeemed {robuxAmount} Robux!"
	/// </summary>
	public override string MessageRobloxCreditToRobuxRedemptionConfirmation(string robuxAmount)
	{
		return $"{robuxAmount} Robux를 교환받았어요!";
	}

	protected override string _GetTemplateForMessageRobloxCreditToRobuxRedemptionConfirmation()
	{
		return "{robuxAmount} Robux를 교환받았어요!";
	}
}
