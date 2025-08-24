namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides VotingPanelResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class VotingPanelResources_ko_kr : VotingPanelResources_en_us, IVotingPanelResources, ITranslationResources
{
	/// <summary>
	/// Key: "Label.Accept"
	/// English String: "Verify"
	/// </summary>
	public override string LabelAccept => "확인";

	/// <summary>
	/// Key: "Label.AccountPageTitle"
	/// English String: "Account"
	/// </summary>
	public override string LabelAccountPageTitle => "계정";

	/// <summary>
	/// Key: "Label.AccountUnderDayOneMessage"
	/// English String: "You will be able to vote on Games and Studio Models later, after you've had a chance to experience Roblox a bit more. Come back to this page in a couple days."
	/// </summary>
	public override string LabelAccountUnderDayOneMessage => "Roblox를 조금만 더 사용하시면 Roblox 게임 및 Studio 모델에 투표할 수 있습니다. 며칠 후 다시 방문해 주세요.";

	/// <summary>
	/// Key: "Label.AccountUnderDayOneTitle"
	/// English String: "Voter Feedback"
	/// </summary>
	public override string LabelAccountUnderDayOneTitle => "투표자 피드백";

	/// <summary>
	/// Key: "Label.AssetNotVoteableMessage"
	/// English String: "This asset may not be voted on at this time."
	/// </summary>
	public override string LabelAssetNotVoteableMessage => "지금은 본 애셋에 투표할 수 없어요.";

	/// <summary>
	/// Key: "Label.AssetNotVoteableTitle"
	/// English String: "Unable to Vote"
	/// </summary>
	public override string LabelAssetNotVoteableTitle => "투표 불가";

	/// <summary>
	/// Key: "Label.BuyGamePassMessage"
	/// English String: "You must own this game pass before you can vote on it."
	/// </summary>
	public override string LabelBuyGamePassMessage => "투표하려면 먼저 본 게임패스를 보유해야 합니다.";

	/// <summary>
	/// Key: "Label.BuyGamePassTitle"
	/// English String: "Buy Game Pass"
	/// </summary>
	public override string LabelBuyGamePassTitle => "게임패스 구매";

	/// <summary>
	/// Key: "Label.Decline"
	/// English String: "Cancel"
	/// </summary>
	public override string LabelDecline => "취소";

	/// <summary>
	/// Key: "Label.EmailVerifiedTitle"
	/// English String: "Verify Your Email"
	/// </summary>
	public override string LabelEmailVerifiedTitle => "이메일 인증";

	/// <summary>
	/// Key: "Label.FloodCheckMessage"
	/// English String: "You're voting too quickly. Come back later and try again."
	/// </summary>
	public override string LabelFloodCheckMessage => "너무 자주 투표를 하시는군요. 나중에 다시 시도하세요.";

	/// <summary>
	/// Key: "Label.FloodCheckTitle"
	/// English String: "Slow Down"
	/// </summary>
	public override string LabelFloodCheckTitle => "조금만 천천히!";

	/// <summary>
	/// Key: "Label.GuestUserTitle"
	/// English String: "Login to Vote"
	/// </summary>
	public override string LabelGuestUserTitle => "로그인 및 투표";

	/// <summary>
	/// Key: "Label.InstallPluginMessage"
	/// English String: "You must install this plugin before you can vote on it."
	/// </summary>
	public override string LabelInstallPluginMessage => "투표하려면 먼저 본 플러그인을 사용해야 합니다.";

	/// <summary>
	/// Key: "Label.InstallPluginTitle"
	/// English String: "Install Plugin"
	/// </summary>
	public override string LabelInstallPluginTitle => "플러그인 설치";

	/// <summary>
	/// Key: "Label.Login"
	/// English String: "Login"
	/// </summary>
	public override string LabelLogin => "로그인";

	/// <summary>
	/// Key: "Label.LoginOrRegisterPageTitle"
	/// English String: "login or register"
	/// </summary>
	public override string LabelLoginOrRegisterPageTitle => "로그인 또는 가입";

	/// <summary>
	/// Key: "Label.Ok"
	/// English String: "OK"
	/// </summary>
	public override string LabelOk => "확인";

	/// <summary>
	/// Key: "Label.PlayGameMessage"
	/// English String: "You must play the game before you can vote on it."
	/// </summary>
	public override string LabelPlayGameMessage => "투표하려면 먼저 게임을 플레이해야 합니다.";

	/// <summary>
	/// Key: "Label.PlayGameTitle"
	/// English String: "Play Game"
	/// </summary>
	public override string LabelPlayGameTitle => "게임 플레이";

	/// <summary>
	/// Key: "Label.UnknownProblemMessage"
	/// English String: "There was an unknown problem voting. Please try again."
	/// </summary>
	public override string LabelUnknownProblemMessage => "투표 중 알 수 없는 오류가 발생했어요. 다시 시도하세요.";

	/// <summary>
	/// Key: "Label.UnknownProblemTitle"
	/// English String: "Something Broke"
	/// </summary>
	public override string LabelUnknownProblemTitle => "오류가 발생했어요";

	/// <summary>
	/// Key: "Label.UseModelMessage"
	/// English String: "You must use this model before you can vote on it."
	/// </summary>
	public override string LabelUseModelMessage => "투표하려면 먼저 본 모델을 사용해야 합니다.";

	/// <summary>
	/// Key: "Label.UseModelTitle"
	/// English String: "Use Model"
	/// </summary>
	public override string LabelUseModelTitle => "모델 사용";

	/// <summary>
	/// Key: "Label.YouMustLoginToVote"
	/// English String: "You must login to vote."
	/// </summary>
	public override string LabelYouMustLoginToVote => "투표하려면 로그인하세요.";

	public VotingPanelResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForLabelAccept()
	{
		return "확인";
	}

	protected override string _GetTemplateForLabelAccountPageTitle()
	{
		return "계정";
	}

	protected override string _GetTemplateForLabelAccountUnderDayOneMessage()
	{
		return "Roblox를 조금만 더 사용하시면 Roblox 게임 및 Studio 모델에 투표할 수 있습니다. 며칠 후 다시 방문해 주세요.";
	}

	protected override string _GetTemplateForLabelAccountUnderDayOneTitle()
	{
		return "투표자 피드백";
	}

	protected override string _GetTemplateForLabelAssetNotVoteableMessage()
	{
		return "지금은 본 애셋에 투표할 수 없어요.";
	}

	protected override string _GetTemplateForLabelAssetNotVoteableTitle()
	{
		return "투표 불가";
	}

	protected override string _GetTemplateForLabelBuyGamePassMessage()
	{
		return "투표하려면 먼저 본 게임패스를 보유해야 합니다.";
	}

	protected override string _GetTemplateForLabelBuyGamePassTitle()
	{
		return "게임패스 구매";
	}

	protected override string _GetTemplateForLabelDecline()
	{
		return "취소";
	}

	/// <summary>
	/// Key: "Label.EmailVerifiedMessage"
	/// English String: "You must verify your email before you can vote. You can verify your email on the {accountPageLink} page."
	/// </summary>
	public override string LabelEmailVerifiedMessage(string accountPageLink)
	{
		return $"투표하려면 먼저 이메일을 인증해야 합니다. {accountPageLink} 페이지에서 이메일 인증을 하실 수 있어요.";
	}

	protected override string _GetTemplateForLabelEmailVerifiedMessage()
	{
		return "투표하려면 먼저 이메일을 인증해야 합니다. {accountPageLink} 페이지에서 이메일 인증을 하실 수 있어요.";
	}

	protected override string _GetTemplateForLabelEmailVerifiedTitle()
	{
		return "이메일 인증";
	}

	protected override string _GetTemplateForLabelFloodCheckMessage()
	{
		return "너무 자주 투표를 하시는군요. 나중에 다시 시도하세요.";
	}

	protected override string _GetTemplateForLabelFloodCheckTitle()
	{
		return "조금만 천천히!";
	}

	/// <summary>
	/// Key: "Label.GuestUserMessage"
	/// English String: "Please {loginOrRegisterPageLink} to continue."
	/// </summary>
	public override string LabelGuestUserMessage(string loginOrRegisterPageLink)
	{
		return $"계속하려면 {loginOrRegisterPageLink}하세요.";
	}

	protected override string _GetTemplateForLabelGuestUserMessage()
	{
		return "계속하려면 {loginOrRegisterPageLink}하세요.";
	}

	protected override string _GetTemplateForLabelGuestUserTitle()
	{
		return "로그인 및 투표";
	}

	protected override string _GetTemplateForLabelInstallPluginMessage()
	{
		return "투표하려면 먼저 본 플러그인을 사용해야 합니다.";
	}

	protected override string _GetTemplateForLabelInstallPluginTitle()
	{
		return "플러그인 설치";
	}

	protected override string _GetTemplateForLabelLogin()
	{
		return "로그인";
	}

	protected override string _GetTemplateForLabelLoginOrRegisterPageTitle()
	{
		return "로그인 또는 가입";
	}

	protected override string _GetTemplateForLabelOk()
	{
		return "확인";
	}

	protected override string _GetTemplateForLabelPlayGameMessage()
	{
		return "투표하려면 먼저 게임을 플레이해야 합니다.";
	}

	protected override string _GetTemplateForLabelPlayGameTitle()
	{
		return "게임 플레이";
	}

	protected override string _GetTemplateForLabelUnknownProblemMessage()
	{
		return "투표 중 알 수 없는 오류가 발생했어요. 다시 시도하세요.";
	}

	protected override string _GetTemplateForLabelUnknownProblemTitle()
	{
		return "오류가 발생했어요";
	}

	protected override string _GetTemplateForLabelUseModelMessage()
	{
		return "투표하려면 먼저 본 모델을 사용해야 합니다.";
	}

	protected override string _GetTemplateForLabelUseModelTitle()
	{
		return "모델 사용";
	}

	protected override string _GetTemplateForLabelYouMustLoginToVote()
	{
		return "투표하려면 로그인하세요.";
	}
}
