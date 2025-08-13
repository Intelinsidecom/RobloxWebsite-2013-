namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides VotingPanelResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class VotingPanelResources_zh_tw : VotingPanelResources_en_us, IVotingPanelResources, ITranslationResources
{
	/// <summary>
	/// Key: "Label.Accept"
	/// English String: "Verify"
	/// </summary>
	public override string LabelAccept => "驗證";

	/// <summary>
	/// Key: "Label.AccountPageTitle"
	/// English String: "Account"
	/// </summary>
	public override string LabelAccountPageTitle => "帳號";

	/// <summary>
	/// Key: "Label.AccountUnderDayOneMessage"
	/// English String: "You will be able to vote on Games and Studio Models later, after you've had a chance to experience Roblox a bit more. Come back to this page in a couple days."
	/// </summary>
	public override string LabelAccountUnderDayOneMessage => "您多玩幾天 Roblox 之後就可以為遊戲及 Studio 模型投票，請過幾天再回到此頁面。";

	/// <summary>
	/// Key: "Label.AccountUnderDayOneTitle"
	/// English String: "Voter Feedback"
	/// </summary>
	public override string LabelAccountUnderDayOneTitle => "投票者意見反映";

	/// <summary>
	/// Key: "Label.AssetNotVoteableMessage"
	/// English String: "This asset may not be voted on at this time."
	/// </summary>
	public override string LabelAssetNotVoteableMessage => "目前無法為此素材投票。";

	/// <summary>
	/// Key: "Label.AssetNotVoteableTitle"
	/// English String: "Unable to Vote"
	/// </summary>
	public override string LabelAssetNotVoteableTitle => "無法投票";

	/// <summary>
	/// Key: "Label.BuyGamePassMessage"
	/// English String: "You must own this game pass before you can vote on it."
	/// </summary>
	public override string LabelBuyGamePassMessage => "若要投票，請先取得此遊戲的通行證。";

	/// <summary>
	/// Key: "Label.BuyGamePassTitle"
	/// English String: "Buy Game Pass"
	/// </summary>
	public override string LabelBuyGamePassTitle => "購買遊戲證";

	/// <summary>
	/// Key: "Label.Decline"
	/// English String: "Cancel"
	/// </summary>
	public override string LabelDecline => "取消";

	/// <summary>
	/// Key: "Label.EmailVerifiedTitle"
	/// English String: "Verify Your Email"
	/// </summary>
	public override string LabelEmailVerifiedTitle => "驗證您的電子郵件地址";

	/// <summary>
	/// Key: "Label.FloodCheckMessage"
	/// English String: "You're voting too quickly. Come back later and try again."
	/// </summary>
	public override string LabelFloodCheckMessage => "您的投票頻率過高，請稍後再試。";

	/// <summary>
	/// Key: "Label.FloodCheckTitle"
	/// English String: "Slow Down"
	/// </summary>
	public override string LabelFloodCheckTitle => "慢下來";

	/// <summary>
	/// Key: "Label.GuestUserTitle"
	/// English String: "Login to Vote"
	/// </summary>
	public override string LabelGuestUserTitle => "若要投票，請先登入。";

	/// <summary>
	/// Key: "Label.InstallPluginMessage"
	/// English String: "You must install this plugin before you can vote on it."
	/// </summary>
	public override string LabelInstallPluginMessage => "若要投票，請先安裝此外掛程式。";

	/// <summary>
	/// Key: "Label.InstallPluginTitle"
	/// English String: "Install Plugin"
	/// </summary>
	public override string LabelInstallPluginTitle => "安裝外掛程式";

	/// <summary>
	/// Key: "Label.Login"
	/// English String: "Login"
	/// </summary>
	public override string LabelLogin => "登入";

	/// <summary>
	/// Key: "Label.LoginOrRegisterPageTitle"
	/// English String: "login or register"
	/// </summary>
	public override string LabelLoginOrRegisterPageTitle => "登入或註冊";

	/// <summary>
	/// Key: "Label.Ok"
	/// English String: "OK"
	/// </summary>
	public override string LabelOk => "確定";

	/// <summary>
	/// Key: "Label.PlayGameMessage"
	/// English String: "You must play the game before you can vote on it."
	/// </summary>
	public override string LabelPlayGameMessage => "若要投票，請先玩此遊戲。";

	/// <summary>
	/// Key: "Label.PlayGameTitle"
	/// English String: "Play Game"
	/// </summary>
	public override string LabelPlayGameTitle => "玩遊戲";

	/// <summary>
	/// Key: "Label.UnknownProblemMessage"
	/// English String: "There was an unknown problem voting. Please try again."
	/// </summary>
	public override string LabelUnknownProblemMessage => "投票時發生錯誤，請重新嘗試。";

	/// <summary>
	/// Key: "Label.UnknownProblemTitle"
	/// English String: "Something Broke"
	/// </summary>
	public override string LabelUnknownProblemTitle => "發生錯誤";

	/// <summary>
	/// Key: "Label.UseModelMessage"
	/// English String: "You must use this model before you can vote on it."
	/// </summary>
	public override string LabelUseModelMessage => "若要投票，請先使用此模型。";

	/// <summary>
	/// Key: "Label.UseModelTitle"
	/// English String: "Use Model"
	/// </summary>
	public override string LabelUseModelTitle => "使用模型";

	/// <summary>
	/// Key: "Label.YouMustLoginToVote"
	/// English String: "You must login to vote."
	/// </summary>
	public override string LabelYouMustLoginToVote => "若要投票，請先登入。";

	public VotingPanelResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForLabelAccept()
	{
		return "驗證";
	}

	protected override string _GetTemplateForLabelAccountPageTitle()
	{
		return "帳號";
	}

	protected override string _GetTemplateForLabelAccountUnderDayOneMessage()
	{
		return "您多玩幾天 Roblox 之後就可以為遊戲及 Studio 模型投票，請過幾天再回到此頁面。";
	}

	protected override string _GetTemplateForLabelAccountUnderDayOneTitle()
	{
		return "投票者意見反映";
	}

	protected override string _GetTemplateForLabelAssetNotVoteableMessage()
	{
		return "目前無法為此素材投票。";
	}

	protected override string _GetTemplateForLabelAssetNotVoteableTitle()
	{
		return "無法投票";
	}

	protected override string _GetTemplateForLabelBuyGamePassMessage()
	{
		return "若要投票，請先取得此遊戲的通行證。";
	}

	protected override string _GetTemplateForLabelBuyGamePassTitle()
	{
		return "購買遊戲證";
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
		return $"若要投票，請先驗證電子郵件地址。您可以在 {accountPageLink} 驗證您的電子郵件地址。";
	}

	protected override string _GetTemplateForLabelEmailVerifiedMessage()
	{
		return "若要投票，請先驗證電子郵件地址。您可以在 {accountPageLink} 驗證您的電子郵件地址。";
	}

	protected override string _GetTemplateForLabelEmailVerifiedTitle()
	{
		return "驗證您的電子郵件地址";
	}

	protected override string _GetTemplateForLabelFloodCheckMessage()
	{
		return "您的投票頻率過高，請稍後再試。";
	}

	protected override string _GetTemplateForLabelFloodCheckTitle()
	{
		return "慢下來";
	}

	/// <summary>
	/// Key: "Label.GuestUserMessage"
	/// English String: "Please {loginOrRegisterPageLink} to continue."
	/// </summary>
	public override string LabelGuestUserMessage(string loginOrRegisterPageLink)
	{
		return $"若要繼續，請先{loginOrRegisterPageLink}。";
	}

	protected override string _GetTemplateForLabelGuestUserMessage()
	{
		return "若要繼續，請先{loginOrRegisterPageLink}。";
	}

	protected override string _GetTemplateForLabelGuestUserTitle()
	{
		return "若要投票，請先登入。";
	}

	protected override string _GetTemplateForLabelInstallPluginMessage()
	{
		return "若要投票，請先安裝此外掛程式。";
	}

	protected override string _GetTemplateForLabelInstallPluginTitle()
	{
		return "安裝外掛程式";
	}

	protected override string _GetTemplateForLabelLogin()
	{
		return "登入";
	}

	protected override string _GetTemplateForLabelLoginOrRegisterPageTitle()
	{
		return "登入或註冊";
	}

	protected override string _GetTemplateForLabelOk()
	{
		return "確定";
	}

	protected override string _GetTemplateForLabelPlayGameMessage()
	{
		return "若要投票，請先玩此遊戲。";
	}

	protected override string _GetTemplateForLabelPlayGameTitle()
	{
		return "玩遊戲";
	}

	protected override string _GetTemplateForLabelUnknownProblemMessage()
	{
		return "投票時發生錯誤，請重新嘗試。";
	}

	protected override string _GetTemplateForLabelUnknownProblemTitle()
	{
		return "發生錯誤";
	}

	protected override string _GetTemplateForLabelUseModelMessage()
	{
		return "若要投票，請先使用此模型。";
	}

	protected override string _GetTemplateForLabelUseModelTitle()
	{
		return "使用模型";
	}

	protected override string _GetTemplateForLabelYouMustLoginToVote()
	{
		return "若要投票，請先登入。";
	}
}
