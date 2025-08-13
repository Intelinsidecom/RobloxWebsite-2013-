namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides BuildersClubPanelResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class BuildersClubPanelResources_ja_jp : BuildersClubPanelResources_en_us, IBuildersClubPanelResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.BuyRobux"
	/// button text
	/// English String: "Buy Robux"
	/// </summary>
	public override string ActionBuyRobux => "Robuxを買う";

	/// <summary>
	/// Key: "Action.Cancel"
	/// button text
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "キャンセル";

	/// <summary>
	/// Key: "Action.RedeemCard"
	/// button text
	/// English String: "Redeem Card"
	/// </summary>
	public override string ActionRedeemCard => "カードを引き換える";

	/// <summary>
	/// Key: "Action.UpdateCreditCard"
	/// button text
	/// English String: "Update Credit Card"
	/// </summary>
	public override string ActionUpdateCreditCard => "クレジットカードを更新";

	/// <summary>
	/// Key: "Action.WhereToBuy"
	/// button text
	/// English String: "Where to Buy"
	/// </summary>
	public override string ActionWhereToBuy => "購入場所";

	/// <summary>
	/// Key: "Description.BuyRobux"
	/// description text
	/// English String: "Robux is the virtual currency used in many of our online games. You can also use Robux for finding a great look for your avatar. Get cool gear to take into multiplayer battles. Buy Limited items to sell and trade. You’ll need Robux to make it all happen. What are you waiting for?"
	/// </summary>
	public override string DescriptionBuyRobux => "Robuxは当社のオンラインゲームで使用されている仮想通貨です。Robuxを使って、アバターの外見を変えることもできます。クールなギアを手に入れて、マルチプレイヤーバトルに持ち込むこともできます。限定アイテムを買って、転売したり取引したりすることもできます。何をするにもRobuxが必要になります。早速、手に入れましょう。";

	/// <summary>
	/// Key: "Heading.BuyRobux"
	/// section heading
	/// English String: "Buy Robux"
	/// </summary>
	public override string HeadingBuyRobux => "Robuxを買う";

	/// <summary>
	/// Key: "Heading.Cancellations"
	/// section heading
	/// English String: "Cancellation"
	/// </summary>
	public override string HeadingCancellations => "キャンセル";

	/// <summary>
	/// Key: "Heading.GameCards"
	/// section heading
	/// English String: "Game Cards"
	/// </summary>
	public override string HeadingGameCards => "ゲームカード";

	/// <summary>
	/// Key: "Heading.Parents"
	/// section heading
	/// English String: "Parents"
	/// </summary>
	public override string HeadingParents => "保護者の方へ";

	/// <summary>
	/// Key: "Label.BuyRobuxWith"
	/// label - there are 2 images after the message about showing buying options
	/// English String: "Buy Robux with"
	/// </summary>
	public override string LabelBuyRobuxWith => "こちらでRobuxを買う:";

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
	public override string LabelRobloxGameCards => "Robloxゲームカード";

	public BuildersClubPanelResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionBuyRobux()
	{
		return "Robuxを買う";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "キャンセル";
	}

	protected override string _GetTemplateForActionRedeemCard()
	{
		return "カードを引き換える";
	}

	protected override string _GetTemplateForActionUpdateCreditCard()
	{
		return "クレジットカードを更新";
	}

	protected override string _GetTemplateForActionWhereToBuy()
	{
		return "購入場所";
	}

	/// <summary>
	/// Key: "Description.BillingPaymentHelp"
	/// description - help text
	/// English String: "For billing and payment questions: {emailLink}"
	/// </summary>
	public override string DescriptionBillingPaymentHelp(string emailLink)
	{
		return $"ご請求とお支払いについてのお問い合わせ先: {emailLink}";
	}

	protected override string _GetTemplateForDescriptionBillingPaymentHelp()
	{
		return "ご請求とお支払いについてのお問い合わせ先: {emailLink}";
	}

	protected override string _GetTemplateForDescriptionBuyRobux()
	{
		return "Robuxは当社のオンラインゲームで使用されている仮想通貨です。Robuxを使って、アバターの外見を変えることもできます。クールなギアを手に入れて、マルチプレイヤーバトルに持ち込むこともできます。限定アイテムを買って、転売したり取引したりすることもできます。何をするにもRobuxが必要になります。早速、手に入れましょう。";
	}

	/// <summary>
	/// Key: "Description.Cancellations"
	/// description text
	/// English String: "You can turn off membership auto renewal at any time before the renewal date and you will continue to receive Builders Club privileges for the remainder of the currently paid period. To turn off membership auto renewal, please click the 'Cancel Membership Renewal button' on the {linkStartTag}Billing{linkEndTag} tab of the Settings page and confirm the cancellation."
	/// </summary>
	public override string DescriptionCancellations(string linkStartTag, string linkEndTag)
	{
		return $"更新日までなら、メンバーシップの自動更新はいつでもオフにできます。オフにしても、現在のメンバーシップの期限が切れるまでは、Builders Clubの特典を受けられます。メンバーシップの自動更新をオフにするには、設定ページの{linkStartTag}請求{linkEndTag}タブにある「メンバーシップ更新のキャンセル」ボタンをクリックして、キャンセルを承認します。";
	}

	protected override string _GetTemplateForDescriptionCancellations()
	{
		return "更新日までなら、メンバーシップの自動更新はいつでもオフにできます。オフにしても、現在のメンバーシップの期限が切れるまでは、Builders Clubの特典を受けられます。メンバーシップの自動更新をオフにするには、設定ページの{linkStartTag}請求{linkEndTag}タブにある「メンバーシップ更新のキャンセル」ボタンをクリックして、キャンセルを承認します。";
	}

	/// <summary>
	/// Key: "Description.CancellationsPremium"
	/// English String: "You can turn off membership auto renewal at any time before the renewal date and you will continue to receive Premium privileges for the remainder of the currently paid period. To turn off membership auto renewal, please click the 'Cancel Membership Renewal button' on the {linkStartTag}Billing{linkEndTag} tab of the Settings page and confirm the cancellation."
	/// </summary>
	public override string DescriptionCancellationsPremium(string linkStartTag, string linkEndTag)
	{
		return $"更新日までなら、メンバーシップの自動更新はいつでもオフにできます。オフにしても、現在のメンバーシップの期限が切れるまでは、Premiumの特典を受けられます。メンバーシップの自動更新をオフにするには、設定ページの {linkStartTag}請求{linkEndTag} タブにある「メンバーシップ更新のキャンセル」ボタンをクリックして、キャンセルを承認します。";
	}

	protected override string _GetTemplateForDescriptionCancellationsPremium()
	{
		return "更新日までなら、メンバーシップの自動更新はいつでもオフにできます。オフにしても、現在のメンバーシップの期限が切れるまでは、Premiumの特典を受けられます。メンバーシップの自動更新をオフにするには、設定ページの {linkStartTag}請求{linkEndTag} タブにある「メンバーシップ更新のキャンセル」ボタンをクリックして、キャンセルを承認します。";
	}

	/// <summary>
	/// Key: "Description.LeanMoreKidsSafety"
	/// description
	/// English String: "Learn more about Builders Club and how we help {startLinkTag}keep kids safe{endLinkTag}."
	/// </summary>
	public override string DescriptionLeanMoreKidsSafety(string startLinkTag, string endLinkTag)
	{
		return $"Builders Clubに関する情報や当社が取り組んでいる {startLinkTag}子供たちの安全を守るための対策{endLinkTag} について確認してください。";
	}

	protected override string _GetTemplateForDescriptionLeanMoreKidsSafety()
	{
		return "Builders Clubに関する情報や当社が取り組んでいる {startLinkTag}子供たちの安全を守るための対策{endLinkTag} について確認してください。";
	}

	/// <summary>
	/// Key: "Description.LearnMoreKidsSafetyPremium"
	/// English String: "Learn more about Premium and how we help {startLinkTag}keep kids safe{endLinkTag}."
	/// </summary>
	public override string DescriptionLearnMoreKidsSafetyPremium(string startLinkTag, string endLinkTag)
	{
		return $"Premiumに関する情報や当社が取り組んでいる {startLinkTag}子供たちの安全を守るための対策{endLinkTag} についてご確認ください。";
	}

	protected override string _GetTemplateForDescriptionLearnMoreKidsSafetyPremium()
	{
		return "Premiumに関する情報や当社が取り組んでいる {startLinkTag}子供たちの安全を守るための対策{endLinkTag} についてご確認ください。";
	}

	protected override string _GetTemplateForHeadingBuyRobux()
	{
		return "Robuxを買う";
	}

	protected override string _GetTemplateForHeadingCancellations()
	{
		return "キャンセル";
	}

	protected override string _GetTemplateForHeadingGameCards()
	{
		return "ゲームカード";
	}

	protected override string _GetTemplateForHeadingParents()
	{
		return "保護者の方へ";
	}

	protected override string _GetTemplateForLabelBuyRobuxWith()
	{
		return "こちらでRobuxを買う:";
	}

	/// <summary>
	/// Key: "Label.CreditBalance"
	/// label
	/// English String: "Credit Balance: {amount}"
	/// </summary>
	public override string LabelCreditBalance(string amount)
	{
		return $"クレジット残高: {amount}";
	}

	protected override string _GetTemplateForLabelCreditBalance()
	{
		return "クレジット残高: {amount}";
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
		return "Robloxゲームカード";
	}
}
