namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides BuildersClubPanelResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class BuildersClubPanelResources_zh_tw : BuildersClubPanelResources_en_us, IBuildersClubPanelResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.BuyRobux"
	/// button text
	/// English String: "Buy Robux"
	/// </summary>
	public override string ActionBuyRobux => "購買 Robux";

	/// <summary>
	/// Key: "Action.Cancel"
	/// button text
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "取消";

	/// <summary>
	/// Key: "Action.RedeemCard"
	/// button text
	/// English String: "Redeem Card"
	/// </summary>
	public override string ActionRedeemCard => "兌換點數卡";

	/// <summary>
	/// Key: "Action.UpdateCreditCard"
	/// button text
	/// English String: "Update Credit Card"
	/// </summary>
	public override string ActionUpdateCreditCard => "更新信用卡";

	/// <summary>
	/// Key: "Action.WhereToBuy"
	/// button text
	/// English String: "Where to Buy"
	/// </summary>
	public override string ActionWhereToBuy => "哪裡購買";

	/// <summary>
	/// Key: "Description.BuyRobux"
	/// description text
	/// English String: "Robux is the virtual currency used in many of our online games. You can also use Robux for finding a great look for your avatar. Get cool gear to take into multiplayer battles. Buy Limited items to sell and trade. You’ll need Robux to make it all happen. What are you waiting for?"
	/// </summary>
	public override string DescriptionBuyRobux => "Robux 是 Roblox 專用的虛擬貨幣。您可以使用 Robux 打扮您的虛擬人偶、取得戰鬥用的酷炫裝備及購買限量道具轉售和交易。不要猶豫，現在就購買 Robux！";

	/// <summary>
	/// Key: "Heading.BuyRobux"
	/// section heading
	/// English String: "Buy Robux"
	/// </summary>
	public override string HeadingBuyRobux => "購買 Robux";

	/// <summary>
	/// Key: "Heading.Cancellations"
	/// section heading
	/// English String: "Cancellation"
	/// </summary>
	public override string HeadingCancellations => "取消";

	/// <summary>
	/// Key: "Heading.GameCards"
	/// section heading
	/// English String: "Game Cards"
	/// </summary>
	public override string HeadingGameCards => "點數卡";

	/// <summary>
	/// Key: "Heading.Parents"
	/// section heading
	/// English String: "Parents"
	/// </summary>
	public override string HeadingParents => "家長";

	/// <summary>
	/// Key: "Label.BuyRobuxWith"
	/// label - there are 2 images after the message about showing buying options
	/// English String: "Buy Robux with"
	/// </summary>
	public override string LabelBuyRobuxWith => "可由以下選項購買 Robux：";

	/// <summary>
	/// Key: "Label.Itunes"
	/// image alt tag text
	/// English String: "iTunes"
	/// </summary>
	public override string LabelItunes => "iTunes";

	/// <summary>
	/// Key: "Label.Rixty"
	/// image alt tag text
	/// English String: "Rixty"
	/// </summary>
	public override string LabelRixty => "Rixty";

	/// <summary>
	/// Key: "Label.RobloxGameCards"
	/// label
	/// English String: "Roblox Gamecards"
	/// </summary>
	public override string LabelRobloxGameCards => "Roblox 點數卡";

	public BuildersClubPanelResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionBuyRobux()
	{
		return "購買 Robux";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "取消";
	}

	protected override string _GetTemplateForActionRedeemCard()
	{
		return "兌換點數卡";
	}

	protected override string _GetTemplateForActionUpdateCreditCard()
	{
		return "更新信用卡";
	}

	protected override string _GetTemplateForActionWhereToBuy()
	{
		return "哪裡購買";
	}

	/// <summary>
	/// Key: "Description.BillingPaymentHelp"
	/// description - help text
	/// English String: "For billing and payment questions: {emailLink}"
	/// </summary>
	public override string DescriptionBillingPaymentHelp(string emailLink)
	{
		return $"帳務和付款問題：{emailLink}";
	}

	protected override string _GetTemplateForDescriptionBillingPaymentHelp()
	{
		return "帳務和付款問題：{emailLink}";
	}

	protected override string _GetTemplateForDescriptionBuyRobux()
	{
		return "Robux 是 Roblox 專用的虛擬貨幣。您可以使用 Robux 打扮您的虛擬人偶、取得戰鬥用的酷炫裝備及購買限量道具轉售和交易。不要猶豫，現在就購買 Robux！";
	}

	/// <summary>
	/// Key: "Description.Cancellations"
	/// description text
	/// English String: "You can turn off membership auto renewal at any time before the renewal date and you will continue to receive Builders Club privileges for the remainder of the currently paid period. To turn off membership auto renewal, please click the 'Cancel Membership Renewal button' on the {linkStartTag}Billing{linkEndTag} tab of the Settings page and confirm the cancellation."
	/// </summary>
	public override string DescriptionCancellations(string linkStartTag, string linkEndTag)
	{
		return $"您在 Builders Club 會員資格續約日期之前可以隨時關閉自動續約，並在會員資格停止之前繼續享用 Builders Club。若要關閉會員資格自動續約，請在設定頁面的{linkStartTag}帳務{linkEndTag}標籤按下「取消續約」按鈕，確認取消會員資格續約。";
	}

	protected override string _GetTemplateForDescriptionCancellations()
	{
		return "您在 Builders Club 會員資格續約日期之前可以隨時關閉自動續約，並在會員資格停止之前繼續享用 Builders Club。若要關閉會員資格自動續約，請在設定頁面的{linkStartTag}帳務{linkEndTag}標籤按下「取消續約」按鈕，確認取消會員資格續約。";
	}

	/// <summary>
	/// Key: "Description.CancellationsPremium"
	/// English String: "You can turn off membership auto renewal at any time before the renewal date and you will continue to receive Premium privileges for the remainder of the currently paid period. To turn off membership auto renewal, please click the 'Cancel Membership Renewal button' on the {linkStartTag}Billing{linkEndTag} tab of the Settings page and confirm the cancellation."
	/// </summary>
	public override string DescriptionCancellationsPremium(string linkStartTag, string linkEndTag)
	{
		return $"您在 Premium 會員資格續約日期之前可以隨時關閉自動續約，並在會員資格停止之前繼續享用 Premium。若要關閉會員資格自動續約，請在設定頁面的{linkStartTag}帳務{linkEndTag}標籤按下「取消續約」按鈕，確認取消會員資格續約。";
	}

	protected override string _GetTemplateForDescriptionCancellationsPremium()
	{
		return "您在 Premium 會員資格續約日期之前可以隨時關閉自動續約，並在會員資格停止之前繼續享用 Premium。若要關閉會員資格自動續約，請在設定頁面的{linkStartTag}帳務{linkEndTag}標籤按下「取消續約」按鈕，確認取消會員資格續約。";
	}

	/// <summary>
	/// Key: "Description.LeanMoreKidsSafety"
	/// description
	/// English String: "Learn more about Builders Club and how we help {startLinkTag}keep kids safe{endLinkTag}."
	/// </summary>
	public override string DescriptionLeanMoreKidsSafety(string startLinkTag, string endLinkTag)
	{
		return $"進一步了解 Builders Club，及我們如何{startLinkTag}維護兒童安全{endLinkTag}。";
	}

	protected override string _GetTemplateForDescriptionLeanMoreKidsSafety()
	{
		return "進一步了解 Builders Club，及我們如何{startLinkTag}維護兒童安全{endLinkTag}。";
	}

	/// <summary>
	/// Key: "Description.LearnMoreKidsSafetyPremium"
	/// English String: "Learn more about Premium and how we help {startLinkTag}keep kids safe{endLinkTag}."
	/// </summary>
	public override string DescriptionLearnMoreKidsSafetyPremium(string startLinkTag, string endLinkTag)
	{
		return $"進一步了解 Premium，及我們如何{startLinkTag}維護兒童安全{endLinkTag}。";
	}

	protected override string _GetTemplateForDescriptionLearnMoreKidsSafetyPremium()
	{
		return "進一步了解 Premium，及我們如何{startLinkTag}維護兒童安全{endLinkTag}。";
	}

	protected override string _GetTemplateForHeadingBuyRobux()
	{
		return "購買 Robux";
	}

	protected override string _GetTemplateForHeadingCancellations()
	{
		return "取消";
	}

	protected override string _GetTemplateForHeadingGameCards()
	{
		return "點數卡";
	}

	protected override string _GetTemplateForHeadingParents()
	{
		return "家長";
	}

	protected override string _GetTemplateForLabelBuyRobuxWith()
	{
		return "可由以下選項購買 Robux：";
	}

	/// <summary>
	/// Key: "Label.CreditBalance"
	/// label
	/// English String: "Credit Balance: {amount}"
	/// </summary>
	public override string LabelCreditBalance(string amount)
	{
		return $"點數餘額：{amount}";
	}

	protected override string _GetTemplateForLabelCreditBalance()
	{
		return "點數餘額：{amount}";
	}

	protected override string _GetTemplateForLabelItunes()
	{
		return "iTunes";
	}

	protected override string _GetTemplateForLabelRixty()
	{
		return "Rixty";
	}

	protected override string _GetTemplateForLabelRobloxGameCards()
	{
		return "Roblox 點數卡";
	}
}
