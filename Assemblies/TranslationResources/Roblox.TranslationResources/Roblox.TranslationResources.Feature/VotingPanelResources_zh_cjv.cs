namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides VotingPanelResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class VotingPanelResources_zh_cjv : VotingPanelResources_en_us, IVotingPanelResources, ITranslationResources
{
	/// <summary>
	/// Key: "Label.Accept"
	/// English String: "Verify"
	/// </summary>
	public override string LabelAccept => "验证";

	/// <summary>
	/// Key: "Label.AccountPageTitle"
	/// English String: "Account"
	/// </summary>
	public override string LabelAccountPageTitle => "帐户";

	/// <summary>
	/// Key: "Label.AccountUnderDayOneMessage"
	/// English String: "You will be able to vote on Games and Studio Models later, after you've had a chance to experience Roblox a bit more. Come back to this page in a couple days."
	/// </summary>
	public override string LabelAccountUnderDayOneMessage => "待你有机会多体验 Roblox 后，你便能对游戏和 Studio 模型进行投票。请几天后再回到此页面。";

	/// <summary>
	/// Key: "Label.AccountUnderDayOneTitle"
	/// English String: "Voter Feedback"
	/// </summary>
	public override string LabelAccountUnderDayOneTitle => "投票者反馈";

	/// <summary>
	/// Key: "Label.AssetNotVoteableMessage"
	/// English String: "This asset may not be voted on at this time."
	/// </summary>
	public override string LabelAssetNotVoteableMessage => "目前无法对此素材投票。";

	/// <summary>
	/// Key: "Label.AssetNotVoteableTitle"
	/// English String: "Unable to Vote"
	/// </summary>
	public override string LabelAssetNotVoteableTitle => "无法投票";

	/// <summary>
	/// Key: "Label.BuyGamePassMessage"
	/// English String: "You must own this game pass before you can vote on it."
	/// </summary>
	public override string LabelBuyGamePassMessage => "你必须先拥有此游戏通行证才能投票。";

	/// <summary>
	/// Key: "Label.BuyGamePassTitle"
	/// English String: "Buy Game Pass"
	/// </summary>
	public override string LabelBuyGamePassTitle => "购买游戏通行证";

	/// <summary>
	/// Key: "Label.Decline"
	/// English String: "Cancel"
	/// </summary>
	public override string LabelDecline => "取消";

	/// <summary>
	/// Key: "Label.EmailVerifiedTitle"
	/// English String: "Verify Your Email"
	/// </summary>
	public override string LabelEmailVerifiedTitle => "验证你的电子邮件";

	/// <summary>
	/// Key: "Label.FloodCheckMessage"
	/// English String: "You're voting too quickly. Come back later and try again."
	/// </summary>
	public override string LabelFloodCheckMessage => "你投票的次数过于频繁。请稍后回来重试。";

	/// <summary>
	/// Key: "Label.FloodCheckTitle"
	/// English String: "Slow Down"
	/// </summary>
	public override string LabelFloodCheckTitle => "慢下来";

	/// <summary>
	/// Key: "Label.GuestUserTitle"
	/// English String: "Login to Vote"
	/// </summary>
	public override string LabelGuestUserTitle => "登录以投票";

	/// <summary>
	/// Key: "Label.InstallPluginMessage"
	/// English String: "You must install this plugin before you can vote on it."
	/// </summary>
	public override string LabelInstallPluginMessage => "你必须先安装此插件才能投票。";

	/// <summary>
	/// Key: "Label.InstallPluginTitle"
	/// English String: "Install Plugin"
	/// </summary>
	public override string LabelInstallPluginTitle => "安装插件";

	/// <summary>
	/// Key: "Label.Login"
	/// English String: "Login"
	/// </summary>
	public override string LabelLogin => "登录";

	/// <summary>
	/// Key: "Label.LoginOrRegisterPageTitle"
	/// English String: "login or register"
	/// </summary>
	public override string LabelLoginOrRegisterPageTitle => "登录或注册";

	/// <summary>
	/// Key: "Label.Ok"
	/// English String: "OK"
	/// </summary>
	public override string LabelOk => "好";

	/// <summary>
	/// Key: "Label.PlayGameMessage"
	/// English String: "You must play the game before you can vote on it."
	/// </summary>
	public override string LabelPlayGameMessage => "你必须先玩游戏才能投票。";

	/// <summary>
	/// Key: "Label.PlayGameTitle"
	/// English String: "Play Game"
	/// </summary>
	public override string LabelPlayGameTitle => "玩游戏";

	/// <summary>
	/// Key: "Label.UnknownProblemMessage"
	/// English String: "There was an unknown problem voting. Please try again."
	/// </summary>
	public override string LabelUnknownProblemMessage => "投票时发生未知问题。请重试。";

	/// <summary>
	/// Key: "Label.UnknownProblemTitle"
	/// English String: "Something Broke"
	/// </summary>
	public override string LabelUnknownProblemTitle => "出错了";

	/// <summary>
	/// Key: "Label.UseModelMessage"
	/// English String: "You must use this model before you can vote on it."
	/// </summary>
	public override string LabelUseModelMessage => "你必须先使用此模型才能投票。";

	/// <summary>
	/// Key: "Label.UseModelTitle"
	/// English String: "Use Model"
	/// </summary>
	public override string LabelUseModelTitle => "使用模型";

	/// <summary>
	/// Key: "Label.YouMustLoginToVote"
	/// English String: "You must login to vote."
	/// </summary>
	public override string LabelYouMustLoginToVote => "你必须登录才能投票。";

	public VotingPanelResources_zh_cjv(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForLabelAccept()
	{
		return "验证";
	}

	protected override string _GetTemplateForLabelAccountPageTitle()
	{
		return "帐户";
	}

	protected override string _GetTemplateForLabelAccountUnderDayOneMessage()
	{
		return "待你有机会多体验 Roblox 后，你便能对游戏和 Studio 模型进行投票。请几天后再回到此页面。";
	}

	protected override string _GetTemplateForLabelAccountUnderDayOneTitle()
	{
		return "投票者反馈";
	}

	protected override string _GetTemplateForLabelAssetNotVoteableMessage()
	{
		return "目前无法对此素材投票。";
	}

	protected override string _GetTemplateForLabelAssetNotVoteableTitle()
	{
		return "无法投票";
	}

	protected override string _GetTemplateForLabelBuyGamePassMessage()
	{
		return "你必须先拥有此游戏通行证才能投票。";
	}

	protected override string _GetTemplateForLabelBuyGamePassTitle()
	{
		return "购买游戏通行证";
	}

	protected override string _GetTemplateForLabelDecline()
	{
		return "取消";
	}

	/// <summary>
	/// Key: "Label.EmailVerifiedMessage"
	/// English String: "You must verify your email before you can vote. You can verify your email on the {accountPageLink} page."
	/// </summary>
	public override string LabelEmailVerifiedMessage(string accountPageLink)
	{
		return $"你先必须验证电子邮件才能投票。你可以在 {accountPageLink} 页面验证你的电子邮件。";
	}

	protected override string _GetTemplateForLabelEmailVerifiedMessage()
	{
		return "你先必须验证电子邮件才能投票。你可以在 {accountPageLink} 页面验证你的电子邮件。";
	}

	protected override string _GetTemplateForLabelEmailVerifiedTitle()
	{
		return "验证你的电子邮件";
	}

	protected override string _GetTemplateForLabelFloodCheckMessage()
	{
		return "你投票的次数过于频繁。请稍后回来重试。";
	}

	protected override string _GetTemplateForLabelFloodCheckTitle()
	{
		return "慢下来";
	}

	/// <summary>
	/// Key: "Label.GuestUserMessage"
	/// English String: "Please {loginOrRegisterPageLink} to continue."
	/// </summary>
	public override string LabelGuestUserMessage(string loginOrRegisterPageLink)
	{
		return $"请 {loginOrRegisterPageLink} 以继续。";
	}

	protected override string _GetTemplateForLabelGuestUserMessage()
	{
		return "请 {loginOrRegisterPageLink} 以继续。";
	}

	protected override string _GetTemplateForLabelGuestUserTitle()
	{
		return "登录以投票";
	}

	protected override string _GetTemplateForLabelInstallPluginMessage()
	{
		return "你必须先安装此插件才能投票。";
	}

	protected override string _GetTemplateForLabelInstallPluginTitle()
	{
		return "安装插件";
	}

	protected override string _GetTemplateForLabelLogin()
	{
		return "登录";
	}

	protected override string _GetTemplateForLabelLoginOrRegisterPageTitle()
	{
		return "登录或注册";
	}

	protected override string _GetTemplateForLabelOk()
	{
		return "好";
	}

	protected override string _GetTemplateForLabelPlayGameMessage()
	{
		return "你必须先玩游戏才能投票。";
	}

	protected override string _GetTemplateForLabelPlayGameTitle()
	{
		return "玩游戏";
	}

	protected override string _GetTemplateForLabelUnknownProblemMessage()
	{
		return "投票时发生未知问题。请重试。";
	}

	protected override string _GetTemplateForLabelUnknownProblemTitle()
	{
		return "出错了";
	}

	protected override string _GetTemplateForLabelUseModelMessage()
	{
		return "你必须先使用此模型才能投票。";
	}

	protected override string _GetTemplateForLabelUseModelTitle()
	{
		return "使用模型";
	}

	protected override string _GetTemplateForLabelYouMustLoginToVote()
	{
		return "你必须登录才能投票。";
	}
}
