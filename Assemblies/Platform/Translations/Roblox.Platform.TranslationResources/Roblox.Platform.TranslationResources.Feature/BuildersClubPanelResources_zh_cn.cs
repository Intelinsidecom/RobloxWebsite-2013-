namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides BuildersClubPanelResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class BuildersClubPanelResources_zh_cn : BuildersClubPanelResources_en_us, IBuildersClubPanelResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.BuyRobux"
	/// button text
	/// English String: "Buy Robux"
	/// </summary>
	public override string ActionBuyRobux => "购买 Robux";

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
	public override string ActionRedeemCard => "兑换礼品卡";

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
	public override string ActionWhereToBuy => "购买渠道";

	/// <summary>
	/// Key: "Description.BuyRobux"
	/// description text
	/// English String: "Robux is the virtual currency used in many of our online games. You can also use Robux for finding a great look for your avatar. Get cool gear to take into multiplayer battles. Buy Limited items to sell and trade. You’ll need Robux to make it all happen. What are you waiting for?"
	/// </summary>
	public override string DescriptionBuyRobux => "Robux 是我们许多在线游戏中使用的虚拟货币。你可以使用 Robux 打造个性十足的虚拟形象、获取可用于多人游戏战斗中的酷炫装备，并购买限量物品以出售和交易。要实现这一切，你都将需要 Robux。你还在等什么？";

	/// <summary>
	/// Key: "Heading.BuyRobux"
	/// section heading
	/// English String: "Buy Robux"
	/// </summary>
	public override string HeadingBuyRobux => "购买 Robux";

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
	public override string HeadingGameCards => "礼品卡";

	/// <summary>
	/// Key: "Heading.Parents"
	/// section heading
	/// English String: "Parents"
	/// </summary>
	public override string HeadingParents => "家长";

	/// <summary>
	/// Key: "Label.BuyRobuxWith"
	/// label - there are 2 images after the message about showing buying options
	/// English String: "Buy Robux with"
	/// </summary>
	public override string LabelBuyRobuxWith => "可通过下列渠道购买 Robux：";

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
	public override string LabelRobloxGameCards => "Roblox 礼品卡";

	public BuildersClubPanelResources_zh_cn(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionBuyRobux()
	{
		return "购买 Robux";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "取消";
	}

	protected override string _GetTemplateForActionRedeemCard()
	{
		return "兑换礼品卡";
	}

	protected override string _GetTemplateForActionUpdateCreditCard()
	{
		return "更新信用卡";
	}

	protected override string _GetTemplateForActionWhereToBuy()
	{
		return "购买渠道";
	}

	/// <summary>
	/// Key: "Description.BillingPaymentHelp"
	/// description - help text
	/// English String: "For billing and payment questions: {emailLink}"
	/// </summary>
	public override string DescriptionBillingPaymentHelp(string emailLink)
	{
		return $"关于账单与付款问题，请联系：{emailLink}";
	}

	protected override string _GetTemplateForDescriptionBillingPaymentHelp()
	{
		return "关于账单与付款问题，请联系：{emailLink}";
	}

	protected override string _GetTemplateForDescriptionBuyRobux()
	{
		return "Robux 是我们许多在线游戏中使用的虚拟货币。你可以使用 Robux 打造个性十足的虚拟形象、获取可用于多人游戏战斗中的酷炫装备，并购买限量物品以出售和交易。要实现这一切，你都将需要 Robux。你还在等什么？";
	}

	/// <summary>
	/// Key: "Description.Cancellations"
	/// description text
	/// English String: "You can turn off membership auto renewal at any time before the renewal date and you will continue to receive Builders Club privileges for the remainder of the currently paid period. To turn off membership auto renewal, please click the 'Cancel Membership Renewal button' on the {linkStartTag}Billing{linkEndTag} tab of the Settings page and confirm the cancellation."
	/// </summary>
	public override string DescriptionCancellations(string linkStartTag, string linkEndTag)
	{
		return $"你可以在 Builders Club 会员资格续订日期之前随时关闭自动续订，并在当前剩余的已付费期限内继续享有 Builders Club 的权益。若要关闭会员自动续订，请在设置页面的{linkStartTag}账单{linkEndTag}标签中点按“取消会员资格续订”按钮，然后确认取消。";
	}

	protected override string _GetTemplateForDescriptionCancellations()
	{
		return "你可以在 Builders Club 会员资格续订日期之前随时关闭自动续订，并在当前剩余的已付费期限内继续享有 Builders Club 的权益。若要关闭会员自动续订，请在设置页面的{linkStartTag}账单{linkEndTag}标签中点按“取消会员资格续订”按钮，然后确认取消。";
	}

	/// <summary>
	/// Key: "Description.CancellationsPremium"
	/// English String: "You can turn off membership auto renewal at any time before the renewal date and you will continue to receive Premium privileges for the remainder of the currently paid period. To turn off membership auto renewal, please click the 'Cancel Membership Renewal button' on the {linkStartTag}Billing{linkEndTag} tab of the Settings page and confirm the cancellation."
	/// </summary>
	public override string DescriptionCancellationsPremium(string linkStartTag, string linkEndTag)
	{
		return $"你可以在 Premium 会员资格续订日期之前随时关闭自动续订，并在当前剩余的已付费期限内继续享有 Premium 的福利。若要关闭会员自动续订，请在设置页面的{linkStartTag}账单{linkEndTag}标签中点按“取消会员资格续订”按钮，然后确认取消。";
	}

	protected override string _GetTemplateForDescriptionCancellationsPremium()
	{
		return "你可以在 Premium 会员资格续订日期之前随时关闭自动续订，并在当前剩余的已付费期限内继续享有 Premium 的福利。若要关闭会员自动续订，请在设置页面的{linkStartTag}账单{linkEndTag}标签中点按“取消会员资格续订”按钮，然后确认取消。";
	}

	/// <summary>
	/// Key: "Description.LeanMoreKidsSafety"
	/// description
	/// English String: "Learn more about Builders Club and how we help {startLinkTag}keep kids safe{endLinkTag}."
	/// </summary>
	public override string DescriptionLeanMoreKidsSafety(string startLinkTag, string endLinkTag)
	{
		return $"了解更多关于 Builders Club 及我们如何{startLinkTag}保护儿童安全{endLinkTag}的方式。";
	}

	protected override string _GetTemplateForDescriptionLeanMoreKidsSafety()
	{
		return "了解更多关于 Builders Club 及我们如何{startLinkTag}保护儿童安全{endLinkTag}的方式。";
	}

	/// <summary>
	/// Key: "Description.LearnMoreKidsSafetyPremium"
	/// English String: "Learn more about Premium and how we help {startLinkTag}keep kids safe{endLinkTag}."
	/// </summary>
	public override string DescriptionLearnMoreKidsSafetyPremium(string startLinkTag, string endLinkTag)
	{
		return $"进一步了解 Premium 及我们如何{startLinkTag}维护儿童安全{endLinkTag}。";
	}

	protected override string _GetTemplateForDescriptionLearnMoreKidsSafetyPremium()
	{
		return "进一步了解 Premium 及我们如何{startLinkTag}维护儿童安全{endLinkTag}。";
	}

	protected override string _GetTemplateForHeadingBuyRobux()
	{
		return "购买 Robux";
	}

	protected override string _GetTemplateForHeadingCancellations()
	{
		return "取消";
	}

	protected override string _GetTemplateForHeadingGameCards()
	{
		return "礼品卡";
	}

	protected override string _GetTemplateForHeadingParents()
	{
		return "家长";
	}

	protected override string _GetTemplateForLabelBuyRobuxWith()
	{
		return "可通过下列渠道购买 Robux：";
	}

	/// <summary>
	/// Key: "Label.CreditBalance"
	/// label
	/// English String: "Credit Balance: {amount}"
	/// </summary>
	public override string LabelCreditBalance(string amount)
	{
		return $"点数余额：{amount}";
	}

	protected override string _GetTemplateForLabelCreditBalance()
	{
		return "点数余额：{amount}";
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
		return "Roblox 礼品卡";
	}
}
