namespace Roblox.TranslationResources.Common;

/// <summary>
/// This class overrides VisitGameResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class VisitGameResources_ja_jp : VisitGameResources_en_us, IVisitGameResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Retry"
	/// button label
	/// English String: "Retry"
	/// </summary>
	public override string ActionRetry => "再試行";

	/// <summary>
	/// Key: "Heading.ErrorStartingGame"
	/// Error starting game
	/// English String: "Error starting game"
	/// </summary>
	public override string HeadingErrorStartingGame => "ゲームの起動中にエラーが発生しました";

	/// <summary>
	/// Key: "Heading.SwitchToDesktopToPlay"
	/// Switch to Desktop Mode to Play Games
	/// English String: "Switch to Desktop Mode to Play Games"
	/// </summary>
	public override string HeadingSwitchToDesktopToPlay => "デスクトップモードに切り替えてゲームをプレイする";

	/// <summary>
	/// Key: "Label.Cancel"
	/// Cancel
	/// English String: "Cancel"
	/// </summary>
	public override string LabelCancel => "キャンセル";

	/// <summary>
	/// Key: "Label.CheckingForStudio"
	/// We are checking if user has Roblox Studio installed
	/// English String: "Checking for Roblox Studio..."
	/// </summary>
	public override string LabelCheckingForStudio => "Roblox Studioを確認中...";

	/// <summary>
	/// Key: "Label.ClickHereForHelp"
	/// Click here for help
	/// English String: "Click here for help"
	/// </summary>
	public override string LabelClickHereForHelp => "ヘルプはこちらをクリック";

	/// <summary>
	/// Key: "Label.ConnectingToPlayers"
	/// Joining a game network with other players
	/// English String: "Connecting to Players..."
	/// </summary>
	public override string LabelConnectingToPlayers => "プレイヤーに接続中...";

	/// <summary>
	/// Key: "Label.DevelopPageTitle"
	/// English String: "Develop"
	/// </summary>
	public override string LabelDevelopPageTitle => "開発";

	/// <summary>
	/// Key: "Label.DownloadInstallRoblox"
	/// Download and Install Roblox
	/// English String: "Download and Install Roblox"
	/// </summary>
	public override string LabelDownloadInstallRoblox => "Robloxのダウンロードとインストール";

	/// <summary>
	/// Key: "Label.DownloadStudio"
	/// Download Roblox Studio to start creating games
	/// English String: "Download Studio"
	/// </summary>
	public override string LabelDownloadStudio => "Studioをダウンロード";

	/// <summary>
	/// Key: "Label.GameConfigurePageTitle"
	/// English String: "Game Configure"
	/// </summary>
	public override string LabelGameConfigurePageTitle => "ゲーム環境設定";

	/// <summary>
	/// Key: "Label.GameFreeSoothsayer"
	/// English String: "Free because you are a soothsayer"
	/// </summary>
	public override string LabelGameFreeSoothsayer => "あなたは魔法使いなので無料です";

	/// <summary>
	/// Key: "Label.GameUnavailableAccountResrictions"
	/// English String: "The game is unavailable due to account restrictions settings."
	/// </summary>
	public override string LabelGameUnavailableAccountResrictions => "アカウントの制限設定により、このゲームは利用できません。";

	/// <summary>
	/// Key: "Label.GameUnavailableCannotPlayGamesStudio"
	/// English String: "You cannot play games from Studio. Please use a web browser to play this game."
	/// </summary>
	public override string LabelGameUnavailableCannotPlayGamesStudio => "Studioでゲームをプレイできません。このゲームをプレイするには、ウェブブラウザを使ってください。";

	/// <summary>
	/// Key: "Label.GameUnavailableClosedToVisitors"
	/// English String: "Sorry, this place is currently closed to visitors."
	/// </summary>
	public override string LabelGameUnavailableClosedToVisitors => "申し訳ありませんが、このプレースは現在訪問者を受け付けていません。";

	/// <summary>
	/// Key: "Label.GameUnavailableCurrentlyIsPrivateVisitor"
	/// When a game is private, this message is shown to visitors.
	/// English String: "Sorry, this game is private."
	/// </summary>
	public override string LabelGameUnavailableCurrentlyIsPrivateVisitor => "申し訳ありませんが、このゲームはプライベート設定になっています。";

	/// <summary>
	/// Key: "Label.GameUnavailableGameInsecure"
	/// U13 users cannot play insecure games unless they are the creator or friends with the creator.
	/// English String: "Sorry, your account is restricted from playing Experimental Games unless you are friends with the creator."
	/// </summary>
	public override string LabelGameUnavailableGameInsecure => "申し訳ありませんが、あなたのアカウントは、クリエーターと友達でない場合、試験ゲームのプレイが制限されています。";

	/// <summary>
	/// Key: "Label.GameUnavailablePermissionLevels"
	/// English String: "The permission levels on this place prevent you from entering."
	/// </summary>
	public override string LabelGameUnavailablePermissionLevels => "このプレースの許可レベルにより、このプレースには入れません。";

	/// <summary>
	/// Key: "Label.GameUnavailablePlaceUnderReview"
	/// English String: "Sorry, this place is currently under review. Try again later."
	/// </summary>
	public override string LabelGameUnavailablePlaceUnderReview => "申し訳ありませんが、このプレースは現在レビュー中です。後でもう一度お試しください。";

	/// <summary>
	/// Key: "Label.GameUnavailablePlatform"
	/// English String: "This game is not available on your platform.  Check the games page to see all playable games."
	/// </summary>
	public override string LabelGameUnavailablePlatform => "このゲームはあなたのプラットフォームでは利用できません。プレイできるゲームについては、ゲームページでチェックしてください。";

	/// <summary>
	/// Key: "Label.GameWarning"
	/// English String: "Warning"
	/// </summary>
	public override string LabelGameWarning => "警告";

	/// <summary>
	/// Key: "Label.InstallationInstructions"
	/// Installation Instructions
	/// English String: "Installation Instructions"
	/// </summary>
	public override string LabelInstallationInstructions => "インストール方法";

	/// <summary>
	/// Key: "Label.LaunchApplication"
	/// Launch Application
	/// English String: "Launch Application"
	/// </summary>
	public override string LabelLaunchApplication => "アプリを起動";

	/// <summary>
	/// Key: "Label.PersuadeToDevelopRoblox"
	/// Persuade user to begin developing their own games using Roblox Studio
	/// English String: "Get started creating your own games!"
	/// </summary>
	public override string LabelPersuadeToDevelopRoblox => "自分のゲームを制作してみよう！";

	/// <summary>
	/// Key: "Label.PersuadeToInstallRoblox"
	/// We are exciting the user about Roblox so that they will be persuaded to download and install it.
	/// English String: "You're moments away from getting into the game!"
	/// </summary>
	public override string LabelPersuadeToInstallRoblox => "ゲームに参加できるようになるまで、あと少しです！";

	/// <summary>
	/// Key: "Label.Play"
	/// English String: "Play"
	/// </summary>
	public override string LabelPlay => "プレイ";

	/// <summary>
	/// Key: "Label.PlayInApp"
	/// English String: "Play in App"
	/// </summary>
	public override string LabelPlayInApp => "アプリでプレイする";

	/// <summary>
	/// Key: "Label.RobloxLoadingToPlay"
	/// Roblox is loading, so the user is getting excited to start playing a game
	/// English String: "Roblox is now loading. Get ready to play!"
	/// </summary>
	public override string LabelRobloxLoadingToPlay => "Robloxを読み込んでいます。プレイの準備をしよう！";

	/// <summary>
	/// Key: "Label.StartingRoblox"
	/// Game launch process has started
	/// English String: "Starting Roblox..."
	/// </summary>
	public override string LabelStartingRoblox => "Robloxを開始中...";

	/// <summary>
	/// Key: "Label.SwitchToDesktopMode"
	/// Switch to Desktop Mode
	/// English String: "Switch to Desktop Mode"
	/// </summary>
	public override string LabelSwitchToDesktopMode => "デスクトップモードに切り替える";

	/// <summary>
	/// Key: "Label.UniverseConfigurePageTitle"
	/// The name of the universe configuration page
	/// English String: "Universe Configuration"
	/// </summary>
	public override string LabelUniverseConfigurePageTitle => "ユニバース環境設定";

	/// <summary>
	/// Key: "Response.Dialog.ClickHere"
	/// Click here!
	/// English String: "Click here!"
	/// </summary>
	public override string ResponseDialogClickHere => "こちらをクリックしてください！";

	/// <summary>
	/// Key: "Response.Dialog.ErrorLaunching"
	/// An error occurred trying to launch the game.  Please try again later.
	/// English String: "An error occurred trying to launch the game.  Please try again later."
	/// </summary>
	public override string ResponseDialogErrorLaunching => "ゲームの起動中にエラーが発生しました。後でもう一度お試しください。";

	/// <summary>
	/// Key: "Response.Dialog.HavingTroubleInstallQuestion"
	/// (Are you) having trouble installing Roblox?
	/// English String: "Having trouble installing Roblox?"
	/// </summary>
	public override string ResponseDialogHavingTroubleInstallQuestion => "Robloxのインストールができない場合。";

	/// <summary>
	/// Key: "Response.Dialog.MacChromeSecondInstruction"
	/// Double-click the Roblox app icon to begin the installation process.
	/// English String: "Double-click the Roblox app icon to begin the installation process."
	/// </summary>
	public override string ResponseDialogMacChromeSecondInstruction => "Robloxアプリアイコンをダブルクリックして、インストールプロセスを開始。";

	/// <summary>
	/// Key: "Response.Dialog.ThanksForPlayingRoblox"
	/// Thanks for playing Roblox
	/// English String: "Thanks for playing Roblox"
	/// </summary>
	public override string ResponseDialogThanksForPlayingRoblox => "Robloxをプレイしていただきありがとうございます";

	/// <summary>
	/// Key: "Response.GameTemporarilyUnavailable"
	/// error message (will be followed by link with Action.Retry label)
	/// English String: "Unable to verify that you have access to this game.  Please try again later."
	/// </summary>
	public override string ResponseGameTemporarilyUnavailable => "このゲームへのアクセス権を認証できません。後で再試行してください。";

	public VisitGameResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	/// <summary>
	/// Key: "Action.GamePerformPoorly"
	/// English String: "{warning} This game may perform poorly on your device."
	/// </summary>
	public override string ActionGamePerformPoorly(string warning)
	{
		return $"{warning} このゲームは、お使いのデバイスでは、うまく作動しない可能性があります。";
	}

	protected override string _GetTemplateForActionGamePerformPoorly()
	{
		return "{warning} このゲームは、お使いのデバイスでは、うまく作動しない可能性があります。";
	}

	protected override string _GetTemplateForActionRetry()
	{
		return "再試行";
	}

	protected override string _GetTemplateForHeadingErrorStartingGame()
	{
		return "ゲームの起動中にエラーが発生しました";
	}

	protected override string _GetTemplateForHeadingSwitchToDesktopToPlay()
	{
		return "デスクトップモードに切り替えてゲームをプレイする";
	}

	/// <summary>
	/// Key: "Label.BuyAccess"
	/// English String: "Buy Access for {robux} Robux"
	/// </summary>
	public override string LabelBuyAccess(string robux)
	{
		return $"{robux} Robux でアクセスを買う";
	}

	protected override string _GetTemplateForLabelBuyAccess()
	{
		return "{robux} Robux でアクセスを買う";
	}

	protected override string _GetTemplateForLabelCancel()
	{
		return "キャンセル";
	}

	protected override string _GetTemplateForLabelCheckingForStudio()
	{
		return "Roblox Studioを確認中...";
	}

	protected override string _GetTemplateForLabelClickHereForHelp()
	{
		return "ヘルプはこちらをクリック";
	}

	protected override string _GetTemplateForLabelConnectingToPlayers()
	{
		return "プレイヤーに接続中...";
	}

	protected override string _GetTemplateForLabelDevelopPageTitle()
	{
		return "開発";
	}

	protected override string _GetTemplateForLabelDownloadInstallRoblox()
	{
		return "Robloxのダウンロードとインストール";
	}

	protected override string _GetTemplateForLabelDownloadStudio()
	{
		return "Studioをダウンロード";
	}

	protected override string _GetTemplateForLabelGameConfigurePageTitle()
	{
		return "ゲーム環境設定";
	}

	protected override string _GetTemplateForLabelGameFreeSoothsayer()
	{
		return "あなたは魔法使いなので無料です";
	}

	/// <summary>
	/// Key: "Label.GameIsPrivatePlayableByGroupOnly"
	/// When a game is private, this message is shown to group developers with a link from where it can be made public.
	/// English String: "Only developers can play because this game is private. Make it public on the {linkStart}Configure Game{linkEnd} page."
	/// </summary>
	public override string LabelGameIsPrivatePlayableByGroupOnly(string linkStart, string linkEnd)
	{
		return $"このゲームは現在、プライベート設定になっているため、開発者しかプレイできません。{linkStart}ゲーム環境設定{linkEnd}ページで公開してください。";
	}

	protected override string _GetTemplateForLabelGameIsPrivatePlayableByGroupOnly()
	{
		return "このゲームは現在、プライベート設定になっているため、開発者しかプレイできません。{linkStart}ゲーム環境設定{linkEnd}ページで公開してください。";
	}

	/// <summary>
	/// Key: "Label.GameIsPrivatePlayableByOwnerOnly"
	/// When a game is private, this message is shown to owner with a link from where it can be made public.
	/// English String: "Only you can play because this game is private. Make it public on the {linkStart}Configure Game{linkEnd} page."
	/// </summary>
	public override string LabelGameIsPrivatePlayableByOwnerOnly(string linkStart, string linkEnd)
	{
		return $"このゲームは現在、プライベート設定になっているため、あなたしかプレイできません。{linkStart}ゲーム環境設定{linkEnd}ページで公開してください。";
	}

	protected override string _GetTemplateForLabelGameIsPrivatePlayableByOwnerOnly()
	{
		return "このゲームは現在、プライベート設定になっているため、あなたしかプレイできません。{linkStart}ゲーム環境設定{linkEnd}ページで公開してください。";
	}

	protected override string _GetTemplateForLabelGameUnavailableAccountResrictions()
	{
		return "アカウントの制限設定により、このゲームは利用できません。";
	}

	protected override string _GetTemplateForLabelGameUnavailableCannotPlayGamesStudio()
	{
		return "Studioでゲームをプレイできません。このゲームをプレイするには、ウェブブラウザを使ってください。";
	}

	protected override string _GetTemplateForLabelGameUnavailableClosedToVisitors()
	{
		return "申し訳ありませんが、このプレースは現在訪問者を受け付けていません。";
	}

	/// <summary>
	/// Key: "Label.GameUnavailableCurrentlyIsPrivateGroup"
	/// When a game is private, this message is shown to group developers with a link from where it can be made public. Similar to an existing translation. Change is making the message directly address the group developers.
	/// English String: "Only developers can play because this game is private. Make it public on the {linkStart}Develop{linkEnd} page."
	/// </summary>
	public override string LabelGameUnavailableCurrentlyIsPrivateGroup(string linkStart, string linkEnd)
	{
		return $"このゲームは現在、プライベート設定になっているため、開発者しかプレイできません。{linkStart}開発{linkEnd}ページで公開してください。";
	}

	protected override string _GetTemplateForLabelGameUnavailableCurrentlyIsPrivateGroup()
	{
		return "このゲームは現在、プライベート設定になっているため、開発者しかプレイできません。{linkStart}開発{linkEnd}ページで公開してください。";
	}

	/// <summary>
	/// Key: "Label.GameUnavailableCurrentlyIsPrivateOwner"
	/// When a game is private, this message is shown to owner with a link from where it can be made public. Similar to an existing translation. Change is making the message directly address the owner.
	/// English String: "Only you can play because this game is private. Make it public on the {linkStart}Develop{linkEnd} page."
	/// </summary>
	public override string LabelGameUnavailableCurrentlyIsPrivateOwner(string linkStart, string linkEnd)
	{
		return $"このゲームは現在、プライベート設定になっているため、あなたしかプレイできません。{linkStart}開発{linkEnd}ページで公開してください。";
	}

	protected override string _GetTemplateForLabelGameUnavailableCurrentlyIsPrivateOwner()
	{
		return "このゲームは現在、プライベート設定になっているため、あなたしかプレイできません。{linkStart}開発{linkEnd}ページで公開してください。";
	}

	protected override string _GetTemplateForLabelGameUnavailableCurrentlyIsPrivateVisitor()
	{
		return "申し訳ありませんが、このゲームはプライベート設定になっています。";
	}

	/// <summary>
	/// Key: "Label.GameUnavailableCurrentlyPrivate"
	/// When a game is private, this message is shown to user with link from where it can be made public
	/// English String: "This {gameTypeName} is currently private. Make it public on the {developPageLink} page to make it playable."
	/// </summary>
	public override string LabelGameUnavailableCurrentlyPrivate(string gameTypeName, string developPageLink)
	{
		return $"{gameTypeName} は現在、プライベートに設定になっています。プレイできるようにするには、{developPageLink} ページで公開してください。";
	}

	protected override string _GetTemplateForLabelGameUnavailableCurrentlyPrivate()
	{
		return "{gameTypeName} は現在、プライベートに設定になっています。プレイできるようにするには、{developPageLink} ページで公開してください。";
	}

	protected override string _GetTemplateForLabelGameUnavailableGameInsecure()
	{
		return "申し訳ありませんが、あなたのアカウントは、クリエーターと友達でない場合、試験ゲームのプレイが制限されています。";
	}

	/// <summary>
	/// Key: "Label.GameUnavailableNoRootPlace"
	/// English String: "This place is part of a game that has no root place. Add a root place on the {gameConfigureLink} page to make it playable."
	/// </summary>
	public override string LabelGameUnavailableNoRootPlace(string gameConfigureLink)
	{
		return $"このプレースは、ルートプレイスの設定されていないゲームの一部です。プレイできるようにするには、{gameConfigureLink}ページでルートプレースを追加してください。";
	}

	protected override string _GetTemplateForLabelGameUnavailableNoRootPlace()
	{
		return "このプレースは、ルートプレイスの設定されていないゲームの一部です。プレイできるようにするには、{gameConfigureLink}ページでルートプレースを追加してください。";
	}

	protected override string _GetTemplateForLabelGameUnavailablePermissionLevels()
	{
		return "このプレースの許可レベルにより、このプレースには入れません。";
	}

	/// <summary>
	/// Key: "Label.GameUnavailablePlaceNotPartOfGame"
	/// English String: "This place is not currently part of a Game. Add it to a game on the {developPageLink} page to make it playable."
	/// </summary>
	public override string LabelGameUnavailablePlaceNotPartOfGame(string developPageLink)
	{
		return $"このプレースは現在、ゲームの一部ではありません。プレイできるようにするには、{developPageLink}ページでゲームに追加してください。";
	}

	protected override string _GetTemplateForLabelGameUnavailablePlaceNotPartOfGame()
	{
		return "このプレースは現在、ゲームの一部ではありません。プレイできるようにするには、{developPageLink}ページでゲームに追加してください。";
	}

	protected override string _GetTemplateForLabelGameUnavailablePlaceUnderReview()
	{
		return "申し訳ありませんが、このプレースは現在レビュー中です。後でもう一度お試しください。";
	}

	protected override string _GetTemplateForLabelGameUnavailablePlatform()
	{
		return "このゲームはあなたのプラットフォームでは利用できません。プレイできるゲームについては、ゲームページでチェックしてください。";
	}

	protected override string _GetTemplateForLabelGameWarning()
	{
		return "警告";
	}

	protected override string _GetTemplateForLabelInstallationInstructions()
	{
		return "インストール方法";
	}

	protected override string _GetTemplateForLabelLaunchApplication()
	{
		return "アプリを起動";
	}

	/// <summary>
	/// Key: "Label.OperaInstallSteps"
	/// 1) A window will open. Click Open2) Doubleclick the Roblox icon.
	/// English String: "1) A window will open. Click {startBold}Open{endBold}.{breakLine}2) Doubleclick the Roblox icon."
	/// </summary>
	public override string LabelOperaInstallSteps(string startBold, string endBold, string breakLine)
	{
		return $"1) ウィンドウが開きます。「{startBold}開く{endBold}」をクリックします。{breakLine}2) Robloxアイコンをダブルクリックします。";
	}

	protected override string _GetTemplateForLabelOperaInstallSteps()
	{
		return "1) ウィンドウが開きます。「{startBold}開く{endBold}」をクリックします。{breakLine}2) Robloxアイコンをダブルクリックします。";
	}

	protected override string _GetTemplateForLabelPersuadeToDevelopRoblox()
	{
		return "自分のゲームを制作してみよう！";
	}

	protected override string _GetTemplateForLabelPersuadeToInstallRoblox()
	{
		return "ゲームに参加できるようになるまで、あと少しです！";
	}

	protected override string _GetTemplateForLabelPlay()
	{
		return "プレイ";
	}

	protected override string _GetTemplateForLabelPlayInApp()
	{
		return "アプリでプレイする";
	}

	protected override string _GetTemplateForLabelRobloxLoadingToPlay()
	{
		return "Robloxを読み込んでいます。プレイの準備をしよう！";
	}

	protected override string _GetTemplateForLabelStartingRoblox()
	{
		return "Robloxを開始中...";
	}

	protected override string _GetTemplateForLabelSwitchToDesktopMode()
	{
		return "デスクトップモードに切り替える";
	}

	protected override string _GetTemplateForLabelUniverseConfigurePageTitle()
	{
		return "ユニバース環境設定";
	}

	/// <summary>
	/// Key: "Response.CheckAlwaysOpenRoblox"
	/// Check {startBold}Always open links for Roblox{endBold} and click {startBold2}Open Roblox{endBold2} in the dialog box above to join games faster in the future!
	/// English String: "Check {startBold}Always open links for Roblox{endBold} and click {startBold2}Open Roblox{endBold2} in the dialog box above to join games faster in the future!"
	/// </summary>
	public override string ResponseCheckAlwaysOpenRoblox(string startBold, string endBold, string startBold2, string endBold2)
	{
		return $"「{startBold}Robloxのリンクは常に開く{endBold}」にチェックを付けて、上のダイアログの「{startBold2}Robloxを開く{endBold2}」をクリックすれば、今後はすぐにゲームに参加できます！";
	}

	protected override string _GetTemplateForResponseCheckAlwaysOpenRoblox()
	{
		return "「{startBold}Robloxのリンクは常に開く{endBold}」にチェックを付けて、上のダイアログの「{startBold2}Robloxを開く{endBold2}」をクリックすれば、今後はすぐにゲームに参加できます！";
	}

	/// <summary>
	/// Key: "Response.CheckAlwaysOpenRobloxURL"
	/// Check {startBold}Always open links for URL: Roblox Protocol{endBold} and click {startBold}Open URL: Roblox Protocol{endBold} in the dialog box above to join games faster in the future!
	/// English String: "Check {startBold}Always open links for URL: Roblox Protocol{endBold} and click {startBold2}Open URL: Roblox Protocol{endBold2} in the dialog box above to join games faster in the future!"
	/// </summary>
	public override string ResponseCheckAlwaysOpenRobloxURL(string startBold, string endBold, string startBold2, string endBold2)
	{
		return $"「{startBold}URL: Roblox Protocolのリンクは常に開く{endBold}」にチェックを付けて、上のダイアログの「{startBold2}URL: Roblox Protocolを開く{endBold2}」をクリックすれば、今後はすぐにゲームに参加できます！";
	}

	protected override string _GetTemplateForResponseCheckAlwaysOpenRobloxURL()
	{
		return "「{startBold}URL: Roblox Protocolのリンクは常に開く{endBold}」にチェックを付けて、上のダイアログの「{startBold2}URL: Roblox Protocolを開く{endBold2}」をクリックすれば、今後はすぐにゲームに参加できます！";
	}

	/// <summary>
	/// Key: "Response.CheckRememberMyChoiceOK"
	/// Check Remember my choice and click OK in the dialog box above to join games faster in the future!
	/// English String: "Check {startBold}Remember my choice{endBold} and click {startBold2}OK{endBold2} in the dialog box above to join games faster in the future!"
	/// </summary>
	public override string ResponseCheckRememberMyChoiceOK(string startBold, string endBold, string startBold2, string endBold2)
	{
		return $"「{startBold}選択を記憶する{endBold}」にチェックを付けて、上のダイアログの「{startBold2}OK{endBold2}」をクリックすれば、今後はすぐにゲームに参加できます！";
	}

	protected override string _GetTemplateForResponseCheckRememberMyChoiceOK()
	{
		return "「{startBold}選択を記憶する{endBold}」にチェックを付けて、上のダイアログの「{startBold2}OK{endBold2}」をクリックすれば、今後はすぐにゲームに参加できます！";
	}

	protected override string _GetTemplateForResponseDialogClickHere()
	{
		return "こちらをクリックしてください！";
	}

	protected override string _GetTemplateForResponseDialogErrorLaunching()
	{
		return "ゲームの起動中にエラーが発生しました。後でもう一度お試しください。";
	}

	protected override string _GetTemplateForResponseDialogHavingTroubleInstallQuestion()
	{
		return "Robloxのインストールができない場合。";
	}

	/// <summary>
	/// Key: "Response.Dialog.InstallingMessageWithLink"
	/// Note: For this translation, please move the linkStart and linkEnd variables with the translation for download now.
	/// English String: "The Roblox installer should download shortly. If it doesn’t, start the {linkStart}download now.{linkEnd}"
	/// </summary>
	public override string ResponseDialogInstallingMessageWithLink(string linkStart, string linkEnd)
	{
		return $"Robloxインストーラのダウンロードがまもなく始まります。始まらない場合は、{linkStart}今すぐダウンロード{linkEnd}で開始してください。";
	}

	protected override string _GetTemplateForResponseDialogInstallingMessageWithLink()
	{
		return "Robloxインストーラのダウンロードがまもなく始まります。始まらない場合は、{linkStart}今すぐダウンロード{linkEnd}で開始してください。";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacChromeFifthInstruction"
	/// After installation, click {startBold}Play{endBold} below to join the action!
	/// English String: "After installation, click {startBold}Play{endBold} below to join the action!"
	/// </summary>
	public override string ResponseDialogMacChromeFifthInstruction(string startBold, string endBold)
	{
		return $"インストール後、以下の「{startBold}プレイ{endBold}」をクリックして参加しましょう！";
	}

	protected override string _GetTemplateForResponseDialogMacChromeFifthInstruction()
	{
		return "インストール後、以下の「{startBold}プレイ{endBold}」をクリックして参加しましょう！";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacChromeFirstInstruction"
	/// Click {startBold}Roblox.dmg{endBold} to run the Roblox installer, which just downloaded via your web browser.
	/// English String: "Click {startBold}Roblox.dmg{endBold} to run the Roblox installer, which just downloaded via your web browser."
	/// </summary>
	public override string ResponseDialogMacChromeFirstInstruction(string startBold, string endBold)
	{
		return $"「{startBold}Roblox.dmg{endBold}」をクリックすると、ウェブブラウザでダウンロードしたばかりのRobloxインストーラが実行されます。";
	}

	protected override string _GetTemplateForResponseDialogMacChromeFirstInstruction()
	{
		return "「{startBold}Roblox.dmg{endBold}」をクリックすると、ウェブブラウザでダウンロードしたばかりのRobloxインストーラが実行されます。";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacChromeFourthInstruction"
	/// Click {startBold}Ok{endBold} once you've successfully installed Roblox.
	/// English String: "Click {startBold}Ok{endBold} once you've successfully installed Roblox."
	/// </summary>
	public override string ResponseDialogMacChromeFourthInstruction(string startBold, string endBold)
	{
		return $"Robloxを正常にインストールしたら「{startBold}OK{endBold}」を一回クリックしてください。";
	}

	protected override string _GetTemplateForResponseDialogMacChromeFourthInstruction()
	{
		return "Robloxを正常にインストールしたら「{startBold}OK{endBold}」を一回クリックしてください。";
	}

	protected override string _GetTemplateForResponseDialogMacChromeSecondInstruction()
	{
		return "Robloxアプリアイコンをダブルクリックして、インストールプロセスを開始。";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacChromeThirdInstruction"
	/// Click {startBold}Open{endBold} when prompted by your computer.
	/// English String: "Click {startBold}Open{endBold} when prompted by your computer."
	/// </summary>
	public override string ResponseDialogMacChromeThirdInstruction(string startBold, string endBold)
	{
		return $"画面の指示に従って「{startBold}開く{endBold}」をクリックします。";
	}

	protected override string _GetTemplateForResponseDialogMacChromeThirdInstruction()
	{
		return "画面の指示に従って「{startBold}開く{endBold}」をクリックします。";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacFirefoxFifthInstruction"
	/// Then select the Remember my choice... checkbox and click OK
	/// English String: "Then select the {startBold}Remember my choice...{endBold} checkbox and click {startBold2}OK{endBold2}"
	/// </summary>
	public override string ResponseDialogMacFirefoxFifthInstruction(string startBold, string endBold, string startBold2, string endBold2)
	{
		return $"次に「{startBold}選択を記憶する...{endBold}」のチェックボックスを選択して、「{startBold2}OK{endBold2}」をクリックします";
	}

	protected override string _GetTemplateForResponseDialogMacFirefoxFifthInstruction()
	{
		return "次に「{startBold}選択を記憶する...{endBold}」のチェックボックスを選択して、「{startBold2}OK{endBold2}」をクリックします";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacFirefoxFirstInstruction"
	/// Select Open with and click OK
	/// English String: "Select {startBold}Open with{endBold} and click {startBold2}OK{endBold2}"
	/// </summary>
	public override string ResponseDialogMacFirefoxFirstInstruction(string startBold, string endBold, string startBold2, string endBold2)
	{
		return $"「{startBold}で開く{endBold}」を選択して、「{startBold2}OK{endBold2}」をクリックします";
	}

	protected override string _GetTemplateForResponseDialogMacFirefoxFirstInstruction()
	{
		return "「{startBold}で開く{endBold}」を選択して、「{startBold2}OK{endBold2}」をクリックします";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacFirefoxFourthInstruction"
	/// Once installed, click Play to join the action!
	/// English String: "Once installed, click {startBold}Play{endBold} to join the action!"
	/// </summary>
	public override string ResponseDialogMacFirefoxFourthInstruction(string startBold, string endBold)
	{
		return $"インストール後、「{startBold}プレイ{endBold}」をクリックして参加しましょう！";
	}

	protected override string _GetTemplateForResponseDialogMacFirefoxFourthInstruction()
	{
		return "インストール後、「{startBold}プレイ{endBold}」をクリックして参加しましょう！";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacFirefoxSecondInstruction"
	/// Double-click the Roblox Icon to begin the installation process
	/// English String: "Double-click the {startBold}Roblox Icon{endBold} to begin the installation process"
	/// </summary>
	public override string ResponseDialogMacFirefoxSecondInstruction(string startBold, string endBold)
	{
		return $"{startBold}Robloxアイコン{endBold}をダブルクリックして、インストールプロセスを開始";
	}

	protected override string _GetTemplateForResponseDialogMacFirefoxSecondInstruction()
	{
		return "{startBold}Robloxアイコン{endBold}をダブルクリックして、インストールプロセスを開始";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacFirefoxThirdInstruction"
	/// You will receive a warning, click Open
	/// English String: "You will receive a warning, click {startBold}Open{endBold}"
	/// </summary>
	public override string ResponseDialogMacFirefoxThirdInstruction(string startBold, string endBold)
	{
		return $"警告が表示されたら、「{startBold}開く{endBold}」をクリックします";
	}

	protected override string _GetTemplateForResponseDialogMacFirefoxThirdInstruction()
	{
		return "警告が表示されたら、「{startBold}開く{endBold}」をクリックします";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacSafariFirstInstruction"
	/// Go to Downloads and double-click Roblox.dmg
	/// English String: "Go to Downloads and double-click {startBold}Roblox.dmg{endBold}"
	/// </summary>
	public override string ResponseDialogMacSafariFirstInstruction(string startBold, string endBold)
	{
		return $"「ダウンロード」にアクセスして、{startBold}Roblox.dmg{endBold}をダブルクリックします";
	}

	protected override string _GetTemplateForResponseDialogMacSafariFirstInstruction()
	{
		return "「ダウンロード」にアクセスして、{startBold}Roblox.dmg{endBold}をダブルクリックします";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacSafariFourthInstruction"
	/// Once installed, click {startBold}Play{endBold} to join the action!
	/// English String: "Once installed, click {startBold}Play{endBold} to join the action!"
	/// </summary>
	public override string ResponseDialogMacSafariFourthInstruction(string startBold, string endBold)
	{
		return $"インストール後、「{startBold}プレイ{endBold}」をクリックして参加しましょう！";
	}

	protected override string _GetTemplateForResponseDialogMacSafariFourthInstruction()
	{
		return "インストール後、「{startBold}プレイ{endBold}」をクリックして参加しましょう！";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacSafariSecondInstruction"
	/// Double-click the {startBold}Roblox Icon{endBold} to begin the installation process
	/// English String: "Double-click the {startBold}Roblox Icon{endBold} to begin the installation process"
	/// </summary>
	public override string ResponseDialogMacSafariSecondInstruction(string startBold, string endBold)
	{
		return $"{startBold}Robloxアイコン{endBold}をダブルクリックして、インストールプロセスを開始";
	}

	protected override string _GetTemplateForResponseDialogMacSafariSecondInstruction()
	{
		return "{startBold}Robloxアイコン{endBold}をダブルクリックして、インストールプロセスを開始";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacSafariThirdInstruction"
	/// You will receive a warning, click {startBold}Open{endBold}
	/// English String: "You will receive a warning, click {startBold}Open{endBold}"
	/// </summary>
	public override string ResponseDialogMacSafariThirdInstruction(string startBold, string endBold)
	{
		return $"警告が表示されたら、「{startBold}開く{endBold}」をクリックします";
	}

	protected override string _GetTemplateForResponseDialogMacSafariThirdInstruction()
	{
		return "警告が表示されたら、「{startBold}開く{endBold}」をクリックします";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcChromeFirstInstruction"
	/// Click {startBold}RobloxPlayer.exe{endBold} to run the Roblox installer, which just downloaded via your web browser.
	/// English String: "Click {startBold}RobloxPlayer.exe{endBold} to run the Roblox installer, which just downloaded via your web browser."
	/// </summary>
	public override string ResponseDialogPcChromeFirstInstruction(string startBold, string endBold)
	{
		return $"「{startBold}RobloxPlayer.exe{endBold}」をクリックすると、ウェブブラウザでダウンロードしたばかりのRobloxインストーラが実行されます。";
	}

	protected override string _GetTemplateForResponseDialogPcChromeFirstInstruction()
	{
		return "「{startBold}RobloxPlayer.exe{endBold}」をクリックすると、ウェブブラウザでダウンロードしたばかりのRobloxインストーラが実行されます。";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcChromeFourthInstruction"
	/// After installation, click {startBold}Play{endBold} below to join the action!
	/// English String: "After installation, click {startBold}Play{endBold} below to join the action!"
	/// </summary>
	public override string ResponseDialogPcChromeFourthInstruction(string startBold, string endBold)
	{
		return $"インストール後、以下の「{startBold}プレイ{endBold}」をクリックして参加しましょう！";
	}

	protected override string _GetTemplateForResponseDialogPcChromeFourthInstruction()
	{
		return "インストール後、以下の「{startBold}プレイ{endBold}」をクリックして参加しましょう！";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcChromeSecondInstruction"
	/// Click {startBold}Run{endBold} when prompted by your computer to begin the installation process.
	/// English String: "Click {startBold}Run{endBold} when prompted by your computer to begin the installation process."
	/// </summary>
	public override string ResponseDialogPcChromeSecondInstruction(string startBold, string endBold)
	{
		return $"インストールプロセスを開始するようにパソコンに指示されたら、「{startBold}実行{endBold}」をクリックします。";
	}

	protected override string _GetTemplateForResponseDialogPcChromeSecondInstruction()
	{
		return "インストールプロセスを開始するようにパソコンに指示されたら、「{startBold}実行{endBold}」をクリックします。";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcChromeThirdInstruction"
	/// Click {startBold}Ok{endBold} once you've successfully installed Roblox.
	/// English String: "Click {startBold}Ok{endBold} once you've successfully installed Roblox."
	/// </summary>
	public override string ResponseDialogPcChromeThirdInstruction(string startBold, string endBold)
	{
		return $"Robloxを正常にインストールしたら「{startBold}OK{endBold}」を一回クリックしてください。";
	}

	protected override string _GetTemplateForResponseDialogPcChromeThirdInstruction()
	{
		return "Robloxを正常にインストールしたら「{startBold}OK{endBold}」を一回クリックしてください。";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcEdgeFirstInstruction"
	/// Click {startBold}Run{endBold} to install Roblox after the download finishes
	/// English String: "Click {startBold}Run{endBold} to install Roblox after the download finishes"
	/// </summary>
	public override string ResponseDialogPcEdgeFirstInstruction(string startBold, string endBold)
	{
		return $"ダウンロードが終わったら、「{startBold}実行{endBold}」をクリックしてRobloxをインストールします";
	}

	protected override string _GetTemplateForResponseDialogPcEdgeFirstInstruction()
	{
		return "ダウンロードが終わったら、「{startBold}実行{endBold}」をクリックしてRobloxをインストールします";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcEdgeSecondInstruction"
	/// Click {startBold}Ok{endBold} to finish installing Roblox
	/// English String: "Click {startBold}Ok{endBold} to finish installing Roblox"
	/// </summary>
	public override string ResponseDialogPcEdgeSecondInstruction(string startBold, string endBold)
	{
		return $"「{startBold}OK{endBold}」をクリックしてRobloxのインストールを完了します。";
	}

	protected override string _GetTemplateForResponseDialogPcEdgeSecondInstruction()
	{
		return "「{startBold}OK{endBold}」をクリックしてRobloxのインストールを完了します。";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcEdgeThirdInstruction"
	/// Click the {startBold}Play{endBold} button to join the action!
	/// English String: "Click the {startBold}Play{endBold} button to join the action!"
	/// </summary>
	public override string ResponseDialogPcEdgeThirdInstruction(string startBold, string endBold)
	{
		return $"「{startBold}プレイ{endBold}」ボタンをクリックして、ゲームに参加します！";
	}

	protected override string _GetTemplateForResponseDialogPcEdgeThirdInstruction()
	{
		return "「{startBold}プレイ{endBold}」ボタンをクリックして、ゲームに参加します！";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcFirefoxFifthInstruction"
	/// Click {startBold}Ok{endBold} when the alert pops up
	/// English String: "Click {startBold}Ok{endBold} when the alert pops up"
	/// </summary>
	public override string ResponseDialogPcFirefoxFifthInstruction(string startBold, string endBold)
	{
		return $"警告が表示されたら「{startBold}OK{endBold}」をクリックします";
	}

	protected override string _GetTemplateForResponseDialogPcFirefoxFifthInstruction()
	{
		return "警告が表示されたら「{startBold}OK{endBold}」をクリックします";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcFirefoxFirstInstruction"
	/// Click {startBold}Save File{endBold} when the download window pops up
	/// English String: "Click {startBold}Save File{endBold} when the download window pops up"
	/// </summary>
	public override string ResponseDialogPcFirefoxFirstInstruction(string startBold, string endBold)
	{
		return $"ダウンロードウィンドウが開いたら「{startBold}ファイルを保存する{endBold}」をクリックします";
	}

	protected override string _GetTemplateForResponseDialogPcFirefoxFirstInstruction()
	{
		return "ダウンロードウィンドウが開いたら「{startBold}ファイルを保存する{endBold}」をクリックします";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcFirefoxFourthInstruction"
	/// Once installed, click {startBold}Play{endBold} to join the action!
	/// English String: "Once installed, click {startBold}Play{endBold} to join the action!"
	/// </summary>
	public override string ResponseDialogPcFirefoxFourthInstruction(string startBold, string endBold)
	{
		return $"インストール後、「{startBold}プレイ{endBold}」をクリックして参加しましょう！";
	}

	protected override string _GetTemplateForResponseDialogPcFirefoxFourthInstruction()
	{
		return "インストール後、「{startBold}プレイ{endBold}」をクリックして参加しましょう！";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcFirefoxSecondInstruction"
	/// Go to Downloads and double click {startBold}RobloxPlayer.exe{endBold}
	/// English String: "Go to Downloads and double click {startBold}RobloxPlayer.exe{endBold}"
	/// </summary>
	public override string ResponseDialogPcFirefoxSecondInstruction(string startBold, string endBold)
	{
		return $"「ダウンロード」にアクセスして、{startBold}RobloxPlayer.exe{endBold}をダブルクリックします";
	}

	protected override string _GetTemplateForResponseDialogPcFirefoxSecondInstruction()
	{
		return "「ダウンロード」にアクセスして、{startBold}RobloxPlayer.exe{endBold}をダブルクリックします";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcFirefoxThirdInstruction"
	/// Click {startBold}Run{endBold}
	/// English String: "Click {startBold}Run{endBold}"
	/// </summary>
	public override string ResponseDialogPcFirefoxThirdInstruction(string startBold, string endBold)
	{
		return $"「{startBold}実行{endBold}」をクリックします";
	}

	protected override string _GetTemplateForResponseDialogPcFirefoxThirdInstruction()
	{
		return "「{startBold}実行{endBold}」をクリックします";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcIEFirstInstruction"
	/// You will receive a warning, click {startBold}Run{endBold}
	/// English String: "You will receive a warning, click {startBold}Run{endBold}"
	/// </summary>
	public override string ResponseDialogPcIEFirstInstruction(string startBold, string endBold)
	{
		return $"警告が表示されたら、「{startBold}実行{endBold}」をクリックします";
	}

	protected override string _GetTemplateForResponseDialogPcIEFirstInstruction()
	{
		return "警告が表示されたら、「{startBold}実行{endBold}」をクリックします";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcIeInstructionOne"
	/// You will receive a warning, click {startBold}Run{endBold}
	/// English String: "You will receive a warning, click {startBold}Run{endBold}"
	/// </summary>
	public override string ResponseDialogPcIeInstructionOne(string startBold, string endBold)
	{
		return $"警告が表示されたら、「{startBold}実行{endBold}」をクリックします";
	}

	protected override string _GetTemplateForResponseDialogPcIeInstructionOne()
	{
		return "警告が表示されたら、「{startBold}実行{endBold}」をクリックします";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcIeInstructionThree"
	/// Click {startBold}Run{endBold}
	/// English String: "Click {startBold}Run{endBold}"
	/// </summary>
	public override string ResponseDialogPcIeInstructionThree(string startBold, string endBold)
	{
		return $"「{startBold}実行{endBold}」をクリックします";
	}

	protected override string _GetTemplateForResponseDialogPcIeInstructionThree()
	{
		return "「{startBold}実行{endBold}」をクリックします";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcIeInstructionTwo"
	/// Go to Downloads and double click {startBold}RobloxPlayer.exe{endBold}
	/// English String: "Go to Downloads and double click {startBold}RobloxPlayer.exe{endBold}"
	/// </summary>
	public override string ResponseDialogPcIeInstructionTwo(string startBold, string endBold)
	{
		return $"「ダウンロード」にアクセスして、{startBold}RobloxPlayer.exe{endBold}をダブルクリックします";
	}

	protected override string _GetTemplateForResponseDialogPcIeInstructionTwo()
	{
		return "「ダウンロード」にアクセスして、{startBold}RobloxPlayer.exe{endBold}をダブルクリックします";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcIESecondInstruction"
	/// Click {startBold}Ok{endBold} once you've installed Roblox
	/// English String: "Click {startBold}Ok{endBold} once you've installed Roblox"
	/// </summary>
	public override string ResponseDialogPcIESecondInstruction(string startBold, string endBold)
	{
		return $"Robloxを正常にインストールしたら「{startBold}OK{endBold}」をクリックしてください";
	}

	protected override string _GetTemplateForResponseDialogPcIESecondInstruction()
	{
		return "Robloxを正常にインストールしたら「{startBold}OK{endBold}」をクリックしてください";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcIEThirdInstruction"
	/// Once installed, click {startBold}Play{endBold} to join the action!
	/// English String: "Once installed, click {startBold}Play{endBold} to join the action!"
	/// </summary>
	public override string ResponseDialogPcIEThirdInstruction(string startBold, string endBold)
	{
		return $"インストール後、「{startBold}プレイ{endBold}」をクリックして参加しましょう！";
	}

	protected override string _GetTemplateForResponseDialogPcIEThirdInstruction()
	{
		return "インストール後、「{startBold}プレイ{endBold}」をクリックして参加しましょう！";
	}

	protected override string _GetTemplateForResponseDialogThanksForPlayingRoblox()
	{
		return "Robloxをプレイしていただきありがとうございます";
	}

	protected override string _GetTemplateForResponseGameTemporarilyUnavailable()
	{
		return "このゲームへのアクセス権を認証できません。後で再試行してください。";
	}

	/// <summary>
	/// Key: "Response.RememberMyChoiceAppLaunch"
	/// Check {startBold}Remember my choice{endBold} and click {appLaunchLink} in the dialog box above to join games faster in the future!
	/// English String: "Check {startBold}Remember my choice{endBold} and click {appLaunchLink} in the dialog box above to join games faster in the future!"
	/// </summary>
	public override string ResponseRememberMyChoiceAppLaunch(string startBold, string endBold, string appLaunchLink)
	{
		return $"「{startBold}選択状況を記憶する{endBold}」にチェックを付けて、上のダイアログの{appLaunchLink}をクリックすれば、今後はすぐにゲームに参加できます！";
	}

	protected override string _GetTemplateForResponseRememberMyChoiceAppLaunch()
	{
		return "「{startBold}選択状況を記憶する{endBold}」にチェックを付けて、上のダイアログの{appLaunchLink}をクリックすれば、今後はすぐにゲームに参加できます！";
	}
}
