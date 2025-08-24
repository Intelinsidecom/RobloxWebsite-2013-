namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides VotingPanelResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class VotingPanelResources_ja_jp : VotingPanelResources_en_us, IVotingPanelResources, ITranslationResources
{
	/// <summary>
	/// Key: "Label.Accept"
	/// English String: "Verify"
	/// </summary>
	public override string LabelAccept => "認証";

	/// <summary>
	/// Key: "Label.AccountPageTitle"
	/// English String: "Account"
	/// </summary>
	public override string LabelAccountPageTitle => "アカウント";

	/// <summary>
	/// Key: "Label.AccountUnderDayOneMessage"
	/// English String: "You will be able to vote on Games and Studio Models later, after you've had a chance to experience Roblox a bit more. Come back to this page in a couple days."
	/// </summary>
	public override string LabelAccountUnderDayOneMessage => "Robloxをもう少し体験すれば、ゲームやStudioのモデルに投票できるようになります。数日後にもう一度このページにアクセスしてください。";

	/// <summary>
	/// Key: "Label.AccountUnderDayOneTitle"
	/// English String: "Voter Feedback"
	/// </summary>
	public override string LabelAccountUnderDayOneTitle => "投票者フィードバック";

	/// <summary>
	/// Key: "Label.AssetNotVoteableMessage"
	/// English String: "This asset may not be voted on at this time."
	/// </summary>
	public override string LabelAssetNotVoteableMessage => "このアセットには現在投票できません。";

	/// <summary>
	/// Key: "Label.AssetNotVoteableTitle"
	/// English String: "Unable to Vote"
	/// </summary>
	public override string LabelAssetNotVoteableTitle => "投票できません";

	/// <summary>
	/// Key: "Label.BuyGamePassMessage"
	/// English String: "You must own this game pass before you can vote on it."
	/// </summary>
	public override string LabelBuyGamePassMessage => "投票する前にこのゲームパスを持っている必要があります。";

	/// <summary>
	/// Key: "Label.BuyGamePassTitle"
	/// English String: "Buy Game Pass"
	/// </summary>
	public override string LabelBuyGamePassTitle => "ゲームパスを買う";

	/// <summary>
	/// Key: "Label.Decline"
	/// English String: "Cancel"
	/// </summary>
	public override string LabelDecline => "キャンセル";

	/// <summary>
	/// Key: "Label.EmailVerifiedTitle"
	/// English String: "Verify Your Email"
	/// </summary>
	public override string LabelEmailVerifiedTitle => "メールアドレスを認証";

	/// <summary>
	/// Key: "Label.FloodCheckMessage"
	/// English String: "You're voting too quickly. Come back later and try again."
	/// </summary>
	public override string LabelFloodCheckMessage => "頻繁に投票し過ぎです。しばらくしてから戻ってきてやり直してください。";

	/// <summary>
	/// Key: "Label.FloodCheckTitle"
	/// English String: "Slow Down"
	/// </summary>
	public override string LabelFloodCheckTitle => "ペースを落とす";

	/// <summary>
	/// Key: "Label.GuestUserTitle"
	/// English String: "Login to Vote"
	/// </summary>
	public override string LabelGuestUserTitle => "ログインして投票する";

	/// <summary>
	/// Key: "Label.InstallPluginMessage"
	/// English String: "You must install this plugin before you can vote on it."
	/// </summary>
	public override string LabelInstallPluginMessage => "投票する前にこのプラグインをインストールする必要があります。";

	/// <summary>
	/// Key: "Label.InstallPluginTitle"
	/// English String: "Install Plugin"
	/// </summary>
	public override string LabelInstallPluginTitle => "プラグインのインストール";

	/// <summary>
	/// Key: "Label.Login"
	/// English String: "Login"
	/// </summary>
	public override string LabelLogin => "ログイン";

	/// <summary>
	/// Key: "Label.LoginOrRegisterPageTitle"
	/// English String: "login or register"
	/// </summary>
	public override string LabelLoginOrRegisterPageTitle => "ログインまたは新規登録";

	/// <summary>
	/// Key: "Label.Ok"
	/// English String: "OK"
	/// </summary>
	public override string LabelOk => "OK";

	/// <summary>
	/// Key: "Label.PlayGameMessage"
	/// English String: "You must play the game before you can vote on it."
	/// </summary>
	public override string LabelPlayGameMessage => "投票する前にゲームをプレイする必要があります。";

	/// <summary>
	/// Key: "Label.PlayGameTitle"
	/// English String: "Play Game"
	/// </summary>
	public override string LabelPlayGameTitle => "ゲームをプレイ";

	/// <summary>
	/// Key: "Label.UnknownProblemMessage"
	/// English String: "There was an unknown problem voting. Please try again."
	/// </summary>
	public override string LabelUnknownProblemMessage => "投票中に不明なエラーが発生しました。もう一度お試しください。";

	/// <summary>
	/// Key: "Label.UnknownProblemTitle"
	/// English String: "Something Broke"
	/// </summary>
	public override string LabelUnknownProblemTitle => "問題が発生";

	/// <summary>
	/// Key: "Label.UseModelMessage"
	/// English String: "You must use this model before you can vote on it."
	/// </summary>
	public override string LabelUseModelMessage => "投票する前にこのモデルを使う必要があります。";

	/// <summary>
	/// Key: "Label.UseModelTitle"
	/// English String: "Use Model"
	/// </summary>
	public override string LabelUseModelTitle => "モデルを使う";

	/// <summary>
	/// Key: "Label.YouMustLoginToVote"
	/// English String: "You must login to vote."
	/// </summary>
	public override string LabelYouMustLoginToVote => "投票を行うにはログインする必要があります。";

	public VotingPanelResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForLabelAccept()
	{
		return "認証";
	}

	protected override string _GetTemplateForLabelAccountPageTitle()
	{
		return "アカウント";
	}

	protected override string _GetTemplateForLabelAccountUnderDayOneMessage()
	{
		return "Robloxをもう少し体験すれば、ゲームやStudioのモデルに投票できるようになります。数日後にもう一度このページにアクセスしてください。";
	}

	protected override string _GetTemplateForLabelAccountUnderDayOneTitle()
	{
		return "投票者フィードバック";
	}

	protected override string _GetTemplateForLabelAssetNotVoteableMessage()
	{
		return "このアセットには現在投票できません。";
	}

	protected override string _GetTemplateForLabelAssetNotVoteableTitle()
	{
		return "投票できません";
	}

	protected override string _GetTemplateForLabelBuyGamePassMessage()
	{
		return "投票する前にこのゲームパスを持っている必要があります。";
	}

	protected override string _GetTemplateForLabelBuyGamePassTitle()
	{
		return "ゲームパスを買う";
	}

	protected override string _GetTemplateForLabelDecline()
	{
		return "キャンセル";
	}

	/// <summary>
	/// Key: "Label.EmailVerifiedMessage"
	/// English String: "You must verify your email before you can vote. You can verify your email on the {accountPageLink} page."
	/// </summary>
	public override string LabelEmailVerifiedMessage(string accountPageLink)
	{
		return $"投票する前にメールアドレスの認証を行う必要があります。メールアドレスの認証は、{accountPageLink}ページで行えます。";
	}

	protected override string _GetTemplateForLabelEmailVerifiedMessage()
	{
		return "投票する前にメールアドレスの認証を行う必要があります。メールアドレスの認証は、{accountPageLink}ページで行えます。";
	}

	protected override string _GetTemplateForLabelEmailVerifiedTitle()
	{
		return "メールアドレスを認証";
	}

	protected override string _GetTemplateForLabelFloodCheckMessage()
	{
		return "頻繁に投票し過ぎです。しばらくしてから戻ってきてやり直してください。";
	}

	protected override string _GetTemplateForLabelFloodCheckTitle()
	{
		return "ペースを落とす";
	}

	/// <summary>
	/// Key: "Label.GuestUserMessage"
	/// English String: "Please {loginOrRegisterPageLink} to continue."
	/// </summary>
	public override string LabelGuestUserMessage(string loginOrRegisterPageLink)
	{
		return $"続けるには {loginOrRegisterPageLink} してください。";
	}

	protected override string _GetTemplateForLabelGuestUserMessage()
	{
		return "続けるには {loginOrRegisterPageLink} してください。";
	}

	protected override string _GetTemplateForLabelGuestUserTitle()
	{
		return "ログインして投票する";
	}

	protected override string _GetTemplateForLabelInstallPluginMessage()
	{
		return "投票する前にこのプラグインをインストールする必要があります。";
	}

	protected override string _GetTemplateForLabelInstallPluginTitle()
	{
		return "プラグインのインストール";
	}

	protected override string _GetTemplateForLabelLogin()
	{
		return "ログイン";
	}

	protected override string _GetTemplateForLabelLoginOrRegisterPageTitle()
	{
		return "ログインまたは新規登録";
	}

	protected override string _GetTemplateForLabelOk()
	{
		return "OK";
	}

	protected override string _GetTemplateForLabelPlayGameMessage()
	{
		return "投票する前にゲームをプレイする必要があります。";
	}

	protected override string _GetTemplateForLabelPlayGameTitle()
	{
		return "ゲームをプレイ";
	}

	protected override string _GetTemplateForLabelUnknownProblemMessage()
	{
		return "投票中に不明なエラーが発生しました。もう一度お試しください。";
	}

	protected override string _GetTemplateForLabelUnknownProblemTitle()
	{
		return "問題が発生";
	}

	protected override string _GetTemplateForLabelUseModelMessage()
	{
		return "投票する前にこのモデルを使う必要があります。";
	}

	protected override string _GetTemplateForLabelUseModelTitle()
	{
		return "モデルを使う";
	}

	protected override string _GetTemplateForLabelYouMustLoginToVote()
	{
		return "投票を行うにはログインする必要があります。";
	}
}
