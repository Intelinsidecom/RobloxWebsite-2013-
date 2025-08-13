namespace Roblox.TranslationResources.Common;

/// <summary>
/// This class overrides VisitGameResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class VisitGameResources_zh_tw : VisitGameResources_en_us, IVisitGameResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Retry"
	/// button label
	/// English String: "Retry"
	/// </summary>
	public override string ActionRetry => "重試";

	/// <summary>
	/// Key: "Heading.ErrorStartingGame"
	/// Error starting game
	/// English String: "Error starting game"
	/// </summary>
	public override string HeadingErrorStartingGame => "啟動遊戲時發生錯誤。";

	/// <summary>
	/// Key: "Heading.SwitchToDesktopToPlay"
	/// Switch to Desktop Mode to Play Games
	/// English String: "Switch to Desktop Mode to Play Games"
	/// </summary>
	public override string HeadingSwitchToDesktopToPlay => "若要玩遊戲，請切換到桌面模式";

	/// <summary>
	/// Key: "Label.Cancel"
	/// Cancel
	/// English String: "Cancel"
	/// </summary>
	public override string LabelCancel => "取消";

	/// <summary>
	/// Key: "Label.CheckingForStudio"
	/// We are checking if user has Roblox Studio installed
	/// English String: "Checking for Roblox Studio..."
	/// </summary>
	public override string LabelCheckingForStudio => "正在檢查 Roblox Studio…";

	/// <summary>
	/// Key: "Label.ClickHereForHelp"
	/// Click here for help
	/// English String: "Click here for help"
	/// </summary>
	public override string LabelClickHereForHelp => "按下此處取得協助";

	/// <summary>
	/// Key: "Label.ConnectingToPlayers"
	/// Joining a game network with other players
	/// English String: "Connecting to Players..."
	/// </summary>
	public override string LabelConnectingToPlayers => "正在和玩家建立連線…";

	/// <summary>
	/// Key: "Label.DevelopPageTitle"
	/// English String: "Develop"
	/// </summary>
	public override string LabelDevelopPageTitle => "開發";

	/// <summary>
	/// Key: "Label.DownloadInstallRoblox"
	/// Download and Install Roblox
	/// English String: "Download and Install Roblox"
	/// </summary>
	public override string LabelDownloadInstallRoblox => "下載並安裝 Roblox";

	/// <summary>
	/// Key: "Label.DownloadStudio"
	/// Download Roblox Studio to start creating games
	/// English String: "Download Studio"
	/// </summary>
	public override string LabelDownloadStudio => "下載 Studio";

	/// <summary>
	/// Key: "Label.GameConfigurePageTitle"
	/// English String: "Game Configure"
	/// </summary>
	public override string LabelGameConfigurePageTitle => "遊戲設定";

	/// <summary>
	/// Key: "Label.GameFreeSoothsayer"
	/// English String: "Free because you are a soothsayer"
	/// </summary>
	public override string LabelGameFreeSoothsayer => "因為您是占卜師，您可以免費遊玩";

	/// <summary>
	/// Key: "Label.GameUnavailableAccountResrictions"
	/// English String: "The game is unavailable due to account restrictions settings."
	/// </summary>
	public override string LabelGameUnavailableAccountResrictions => "因帳號限制設定，無法遊玩此遊戲。";

	/// <summary>
	/// Key: "Label.GameUnavailableCannotPlayGamesStudio"
	/// English String: "You cannot play games from Studio. Please use a web browser to play this game."
	/// </summary>
	public override string LabelGameUnavailableCannotPlayGamesStudio => "您無法從 Studio 開啟遊戲，請使用網頁瀏覽器開啟此遊戲。";

	/// <summary>
	/// Key: "Label.GameUnavailableClosedToVisitors"
	/// English String: "Sorry, this place is currently closed to visitors."
	/// </summary>
	public override string LabelGameUnavailableClosedToVisitors => "對不起，此空間目前不對訪客開放。";

	/// <summary>
	/// Key: "Label.GameUnavailableCurrentlyIsPrivateVisitor"
	/// When a game is private, this message is shown to visitors.
	/// English String: "Sorry, this game is private."
	/// </summary>
	public override string LabelGameUnavailableCurrentlyIsPrivateVisitor => "對不起，此遊戲設為私人。";

	/// <summary>
	/// Key: "Label.GameUnavailableGameInsecure"
	/// U13 users cannot play insecure games unless they are the creator or friends with the creator.
	/// English String: "Sorry, your account is restricted from playing Experimental Games unless you are friends with the creator."
	/// </summary>
	public override string LabelGameUnavailableGameInsecure => "對不起，您與創作者不是好友，不能玩實驗遊戲。";

	/// <summary>
	/// Key: "Label.GameUnavailablePermissionLevels"
	/// English String: "The permission levels on this place prevent you from entering."
	/// </summary>
	public override string LabelGameUnavailablePermissionLevels => "您的權限不足，無法進入此空間。";

	/// <summary>
	/// Key: "Label.GameUnavailablePlaceUnderReview"
	/// English String: "Sorry, this place is currently under review. Try again later."
	/// </summary>
	public override string LabelGameUnavailablePlaceUnderReview => "對不起，此空間正在經過審核，請稍後再試。";

	/// <summary>
	/// Key: "Label.GameUnavailablePlatform"
	/// English String: "This game is not available on your platform.  Check the games page to see all playable games."
	/// </summary>
	public override string LabelGameUnavailablePlatform => "此遊戲無法在您的平台上運作，請查看遊戲頁面檢視所有可以玩的遊戲。";

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
	public override string LabelInstallationInstructions => "安裝說明";

	/// <summary>
	/// Key: "Label.LaunchApplication"
	/// Launch Application
	/// English String: "Launch Application"
	/// </summary>
	public override string LabelLaunchApplication => "啟動應用程式";

	/// <summary>
	/// Key: "Label.PersuadeToDevelopRoblox"
	/// Persuade user to begin developing their own games using Roblox Studio
	/// English String: "Get started creating your own games!"
	/// </summary>
	public override string LabelPersuadeToDevelopRoblox => "開始創作屬於您自己的遊戲！";

	/// <summary>
	/// Key: "Label.PersuadeToInstallRoblox"
	/// We are exciting the user about Roblox so that they will be persuaded to download and install it.
	/// English String: "You're moments away from getting into the game!"
	/// </summary>
	public override string LabelPersuadeToInstallRoblox => "您即將進入遊戲！";

	/// <summary>
	/// Key: "Label.Play"
	/// English String: "Play"
	/// </summary>
	public override string LabelPlay => "開始遊戲";

	/// <summary>
	/// Key: "Label.PlayInApp"
	/// English String: "Play in App"
	/// </summary>
	public override string LabelPlayInApp => "在 App 遊玩";

	/// <summary>
	/// Key: "Label.RobloxLoadingToPlay"
	/// Roblox is loading, so the user is getting excited to start playing a game
	/// English String: "Roblox is now loading. Get ready to play!"
	/// </summary>
	public override string LabelRobloxLoadingToPlay => "正在載入 Roblox，準備好了嗎？";

	/// <summary>
	/// Key: "Label.StartingRoblox"
	/// Game launch process has started
	/// English String: "Starting Roblox..."
	/// </summary>
	public override string LabelStartingRoblox => "正在啟動 Roblox…";

	/// <summary>
	/// Key: "Label.SwitchToDesktopMode"
	/// Switch to Desktop Mode
	/// English String: "Switch to Desktop Mode"
	/// </summary>
	public override string LabelSwitchToDesktopMode => "切換到桌面模式";

	/// <summary>
	/// Key: "Label.UniverseConfigurePageTitle"
	/// The name of the universe configuration page
	/// English String: "Universe Configuration"
	/// </summary>
	public override string LabelUniverseConfigurePageTitle => "世界設定";

	/// <summary>
	/// Key: "Response.Dialog.ClickHere"
	/// Click here!
	/// English String: "Click here!"
	/// </summary>
	public override string ResponseDialogClickHere => "按下此處！";

	/// <summary>
	/// Key: "Response.Dialog.ErrorLaunching"
	/// An error occurred trying to launch the game.  Please try again later.
	/// English String: "An error occurred trying to launch the game.  Please try again later."
	/// </summary>
	public override string ResponseDialogErrorLaunching => "啟動遊戲時發生錯誤，請稍後再試。";

	/// <summary>
	/// Key: "Response.Dialog.HavingTroubleInstallQuestion"
	/// (Are you) having trouble installing Roblox?
	/// English String: "Having trouble installing Roblox?"
	/// </summary>
	public override string ResponseDialogHavingTroubleInstallQuestion => "安裝 Roblox 遇到問題？";

	/// <summary>
	/// Key: "Response.Dialog.MacChromeSecondInstruction"
	/// Double-click the Roblox app icon to begin the installation process.
	/// English String: "Double-click the Roblox app icon to begin the installation process."
	/// </summary>
	public override string ResponseDialogMacChromeSecondInstruction => "按兩下 Roblox App 圖示開始安裝程序。";

	/// <summary>
	/// Key: "Response.Dialog.ThanksForPlayingRoblox"
	/// Thanks for playing Roblox
	/// English String: "Thanks for playing Roblox"
	/// </summary>
	public override string ResponseDialogThanksForPlayingRoblox => "謝謝您玩 Roblox";

	/// <summary>
	/// Key: "Response.GameTemporarilyUnavailable"
	/// error message (will be followed by link with Action.Retry label)
	/// English String: "Unable to verify that you have access to this game.  Please try again later."
	/// </summary>
	public override string ResponseGameTemporarilyUnavailable => "無法驗證您的遊戲通行權，請稍後再試。";

	public VisitGameResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	/// <summary>
	/// Key: "Action.GamePerformPoorly"
	/// English String: "{warning} This game may perform poorly on your device."
	/// </summary>
	public override string ActionGamePerformPoorly(string warning)
	{
		return $"{warning} 此遊戲可能無法在您的裝置上順暢運作。";
	}

	protected override string _GetTemplateForActionGamePerformPoorly()
	{
		return "{warning} 此遊戲可能無法在您的裝置上順暢運作。";
	}

	protected override string _GetTemplateForActionRetry()
	{
		return "重試";
	}

	protected override string _GetTemplateForHeadingErrorStartingGame()
	{
		return "啟動遊戲時發生錯誤。";
	}

	protected override string _GetTemplateForHeadingSwitchToDesktopToPlay()
	{
		return "若要玩遊戲，請切換到桌面模式";
	}

	/// <summary>
	/// Key: "Label.BuyAccess"
	/// English String: "Buy Access for {robux} Robux"
	/// </summary>
	public override string LabelBuyAccess(string robux)
	{
		return $"以 {robux} Robux 購買通行權";
	}

	protected override string _GetTemplateForLabelBuyAccess()
	{
		return "以 {robux} Robux 購買通行權";
	}

	protected override string _GetTemplateForLabelCancel()
	{
		return "取消";
	}

	protected override string _GetTemplateForLabelCheckingForStudio()
	{
		return "正在檢查 Roblox Studio…";
	}

	protected override string _GetTemplateForLabelClickHereForHelp()
	{
		return "按下此處取得協助";
	}

	protected override string _GetTemplateForLabelConnectingToPlayers()
	{
		return "正在和玩家建立連線…";
	}

	protected override string _GetTemplateForLabelDevelopPageTitle()
	{
		return "開發";
	}

	protected override string _GetTemplateForLabelDownloadInstallRoblox()
	{
		return "下載並安裝 Roblox";
	}

	protected override string _GetTemplateForLabelDownloadStudio()
	{
		return "下載 Studio";
	}

	protected override string _GetTemplateForLabelGameConfigurePageTitle()
	{
		return "遊戲設定";
	}

	protected override string _GetTemplateForLabelGameFreeSoothsayer()
	{
		return "因為您是占卜師，您可以免費遊玩";
	}

	/// <summary>
	/// Key: "Label.GameIsPrivatePlayableByGroupOnly"
	/// When a game is private, this message is shown to group developers with a link from where it can be made public.
	/// English String: "Only developers can play because this game is private. Make it public on the {linkStart}Configure Game{linkEnd} page."
	/// </summary>
	public override string LabelGameIsPrivatePlayableByGroupOnly(string linkStart, string linkEnd)
	{
		return $"此遊戲設為私人，只有開發人員可以玩。請在{linkStart}遊戲設定{linkEnd}頁面設為公開。";
	}

	protected override string _GetTemplateForLabelGameIsPrivatePlayableByGroupOnly()
	{
		return "此遊戲設為私人，只有開發人員可以玩。請在{linkStart}遊戲設定{linkEnd}頁面設為公開。";
	}

	/// <summary>
	/// Key: "Label.GameIsPrivatePlayableByOwnerOnly"
	/// When a game is private, this message is shown to owner with a link from where it can be made public.
	/// English String: "Only you can play because this game is private. Make it public on the {linkStart}Configure Game{linkEnd} page."
	/// </summary>
	public override string LabelGameIsPrivatePlayableByOwnerOnly(string linkStart, string linkEnd)
	{
		return $"此遊戲設為私人，只有您可以玩。請在{linkStart}遊戲設定{linkEnd}頁面設為公開。";
	}

	protected override string _GetTemplateForLabelGameIsPrivatePlayableByOwnerOnly()
	{
		return "此遊戲設為私人，只有您可以玩。請在{linkStart}遊戲設定{linkEnd}頁面設為公開。";
	}

	protected override string _GetTemplateForLabelGameUnavailableAccountResrictions()
	{
		return "因帳號限制設定，無法遊玩此遊戲。";
	}

	protected override string _GetTemplateForLabelGameUnavailableCannotPlayGamesStudio()
	{
		return "您無法從 Studio 開啟遊戲，請使用網頁瀏覽器開啟此遊戲。";
	}

	protected override string _GetTemplateForLabelGameUnavailableClosedToVisitors()
	{
		return "對不起，此空間目前不對訪客開放。";
	}

	/// <summary>
	/// Key: "Label.GameUnavailableCurrentlyIsPrivateGroup"
	/// When a game is private, this message is shown to group developers with a link from where it can be made public. Similar to an existing translation. Change is making the message directly address the group developers.
	/// English String: "Only developers can play because this game is private. Make it public on the {linkStart}Develop{linkEnd} page."
	/// </summary>
	public override string LabelGameUnavailableCurrentlyIsPrivateGroup(string linkStart, string linkEnd)
	{
		return $"此遊戲設為私人，只有開發人員可以玩。請在{linkEnd}開發{linkStart}頁面將此遊戲設為公開。";
	}

	protected override string _GetTemplateForLabelGameUnavailableCurrentlyIsPrivateGroup()
	{
		return "此遊戲設為私人，只有開發人員可以玩。請在{linkEnd}開發{linkStart}頁面將此遊戲設為公開。";
	}

	/// <summary>
	/// Key: "Label.GameUnavailableCurrentlyIsPrivateOwner"
	/// When a game is private, this message is shown to owner with a link from where it can be made public. Similar to an existing translation. Change is making the message directly address the owner.
	/// English String: "Only you can play because this game is private. Make it public on the {linkStart}Develop{linkEnd} page."
	/// </summary>
	public override string LabelGameUnavailableCurrentlyIsPrivateOwner(string linkStart, string linkEnd)
	{
		return $"此遊戲設為私人，只有您可以玩。請在{linkEnd}開發{linkStart}頁面設為公開。";
	}

	protected override string _GetTemplateForLabelGameUnavailableCurrentlyIsPrivateOwner()
	{
		return "此遊戲設為私人，只有您可以玩。請在{linkEnd}開發{linkStart}頁面設為公開。";
	}

	protected override string _GetTemplateForLabelGameUnavailableCurrentlyIsPrivateVisitor()
	{
		return "對不起，此遊戲設為私人。";
	}

	/// <summary>
	/// Key: "Label.GameUnavailableCurrentlyPrivate"
	/// When a game is private, this message is shown to user with link from where it can be made public
	/// English String: "This {gameTypeName} is currently private. Make it public on the {developPageLink} page to make it playable."
	/// </summary>
	public override string LabelGameUnavailableCurrentlyPrivate(string gameTypeName, string developPageLink)
	{
		return $"此{gameTypeName}目前設為私人。請在{developPageLink}頁面設為公開，讓其他人可以玩。";
	}

	protected override string _GetTemplateForLabelGameUnavailableCurrentlyPrivate()
	{
		return "此{gameTypeName}目前設為私人。請在{developPageLink}頁面設為公開，讓其他人可以玩。";
	}

	protected override string _GetTemplateForLabelGameUnavailableGameInsecure()
	{
		return "對不起，您與創作者不是好友，不能玩實驗遊戲。";
	}

	/// <summary>
	/// Key: "Label.GameUnavailableNoRootPlace"
	/// English String: "This place is part of a game that has no root place. Add a root place on the {gameConfigureLink} page to make it playable."
	/// </summary>
	public override string LabelGameUnavailableNoRootPlace(string gameConfigureLink)
	{
		return $"此空間所屬的遊戲沒有母空間。請在{gameConfigureLink}頁面新增母空間，讓它成為可遊玩狀態。";
	}

	protected override string _GetTemplateForLabelGameUnavailableNoRootPlace()
	{
		return "此空間所屬的遊戲沒有母空間。請在{gameConfigureLink}頁面新增母空間，讓它成為可遊玩狀態。";
	}

	protected override string _GetTemplateForLabelGameUnavailablePermissionLevels()
	{
		return "您的權限不足，無法進入此空間。";
	}

	/// <summary>
	/// Key: "Label.GameUnavailablePlaceNotPartOfGame"
	/// English String: "This place is not currently part of a Game. Add it to a game on the {developPageLink} page to make it playable."
	/// </summary>
	public override string LabelGameUnavailablePlaceNotPartOfGame(string developPageLink)
	{
		return $"此空間目前不屬於任何遊戲。請在{developPageLink}頁面將它加到遊戲中，讓它成為可遊玩狀態。";
	}

	protected override string _GetTemplateForLabelGameUnavailablePlaceNotPartOfGame()
	{
		return "此空間目前不屬於任何遊戲。請在{developPageLink}頁面將它加到遊戲中，讓它成為可遊玩狀態。";
	}

	protected override string _GetTemplateForLabelGameUnavailablePlaceUnderReview()
	{
		return "對不起，此空間正在經過審核，請稍後再試。";
	}

	protected override string _GetTemplateForLabelGameUnavailablePlatform()
	{
		return "此遊戲無法在您的平台上運作，請查看遊戲頁面檢視所有可以玩的遊戲。";
	}

	protected override string _GetTemplateForLabelGameWarning()
	{
		return "警告";
	}

	protected override string _GetTemplateForLabelInstallationInstructions()
	{
		return "安裝說明";
	}

	protected override string _GetTemplateForLabelLaunchApplication()
	{
		return "啟動應用程式";
	}

	/// <summary>
	/// Key: "Label.OperaInstallSteps"
	/// 1) A window will open. Click Open2) Doubleclick the Roblox icon.
	/// English String: "1) A window will open. Click {startBold}Open{endBold}.{breakLine}2) Doubleclick the Roblox icon."
	/// </summary>
	public override string LabelOperaInstallSteps(string startBold, string endBold, string breakLine)
	{
		return $"1) 視窗將會開啟，按下{startBold}開啟{endBold}。{breakLine}2) 按兩下 Roblox 圖示。";
	}

	protected override string _GetTemplateForLabelOperaInstallSteps()
	{
		return "1) 視窗將會開啟，按下{startBold}開啟{endBold}。{breakLine}2) 按兩下 Roblox 圖示。";
	}

	protected override string _GetTemplateForLabelPersuadeToDevelopRoblox()
	{
		return "開始創作屬於您自己的遊戲！";
	}

	protected override string _GetTemplateForLabelPersuadeToInstallRoblox()
	{
		return "您即將進入遊戲！";
	}

	protected override string _GetTemplateForLabelPlay()
	{
		return "開始遊戲";
	}

	protected override string _GetTemplateForLabelPlayInApp()
	{
		return "在 App 遊玩";
	}

	protected override string _GetTemplateForLabelRobloxLoadingToPlay()
	{
		return "正在載入 Roblox，準備好了嗎？";
	}

	protected override string _GetTemplateForLabelStartingRoblox()
	{
		return "正在啟動 Roblox…";
	}

	protected override string _GetTemplateForLabelSwitchToDesktopMode()
	{
		return "切換到桌面模式";
	}

	protected override string _GetTemplateForLabelUniverseConfigurePageTitle()
	{
		return "世界設定";
	}

	/// <summary>
	/// Key: "Response.CheckAlwaysOpenRoblox"
	/// Check {startBold}Always open links for Roblox{endBold} and click {startBold2}Open Roblox{endBold2} in the dialog box above to join games faster in the future!
	/// English String: "Check {startBold}Always open links for Roblox{endBold} and click {startBold2}Open Roblox{endBold2} in the dialog box above to join games faster in the future!"
	/// </summary>
	public override string ResponseCheckAlwaysOpenRoblox(string startBold, string endBold, string startBold2, string endBold2)
	{
		return $"勾選{startBold}永遠開啟 Roblox 的連結{endBold}，並在上方的對話框按下{startBold2}開啟 Roblox{endBold2}，就可以更快加入遊戲！";
	}

	protected override string _GetTemplateForResponseCheckAlwaysOpenRoblox()
	{
		return "勾選{startBold}永遠開啟 Roblox 的連結{endBold}，並在上方的對話框按下{startBold2}開啟 Roblox{endBold2}，就可以更快加入遊戲！";
	}

	/// <summary>
	/// Key: "Response.CheckAlwaysOpenRobloxURL"
	/// Check {startBold}Always open links for URL: Roblox Protocol{endBold} and click {startBold}Open URL: Roblox Protocol{endBold} in the dialog box above to join games faster in the future!
	/// English String: "Check {startBold}Always open links for URL: Roblox Protocol{endBold} and click {startBold2}Open URL: Roblox Protocol{endBold2} in the dialog box above to join games faster in the future!"
	/// </summary>
	public override string ResponseCheckAlwaysOpenRobloxURL(string startBold, string endBold, string startBold2, string endBold2)
	{
		return $"勾選{startBold}永遠開啟以下網址連結：Roblox 協定{endBold}，並在上方的對話框按下{startBold2}開啟以下網址：Roblox 協定{endBold2}，就可以更快加入遊戲！";
	}

	protected override string _GetTemplateForResponseCheckAlwaysOpenRobloxURL()
	{
		return "勾選{startBold}永遠開啟以下網址連結：Roblox 協定{endBold}，並在上方的對話框按下{startBold2}開啟以下網址：Roblox 協定{endBold2}，就可以更快加入遊戲！";
	}

	/// <summary>
	/// Key: "Response.CheckRememberMyChoiceOK"
	/// Check Remember my choice and click OK in the dialog box above to join games faster in the future!
	/// English String: "Check {startBold}Remember my choice{endBold} and click {startBold2}OK{endBold2} in the dialog box above to join games faster in the future!"
	/// </summary>
	public override string ResponseCheckRememberMyChoiceOK(string startBold, string endBold, string startBold2, string endBold2)
	{
		return $"勾選{startBold}記住我的選擇{endBold}，並在上方的對話框按下{startBold2}確定{endBold2}，就可以更快加入遊戲！";
	}

	protected override string _GetTemplateForResponseCheckRememberMyChoiceOK()
	{
		return "勾選{startBold}記住我的選擇{endBold}，並在上方的對話框按下{startBold2}確定{endBold2}，就可以更快加入遊戲！";
	}

	protected override string _GetTemplateForResponseDialogClickHere()
	{
		return "按下此處！";
	}

	protected override string _GetTemplateForResponseDialogErrorLaunching()
	{
		return "啟動遊戲時發生錯誤，請稍後再試。";
	}

	protected override string _GetTemplateForResponseDialogHavingTroubleInstallQuestion()
	{
		return "安裝 Roblox 遇到問題？";
	}

	/// <summary>
	/// Key: "Response.Dialog.InstallingMessageWithLink"
	/// Note: For this translation, please move the linkStart and linkEnd variables with the translation for download now.
	/// English String: "The Roblox installer should download shortly. If it doesn’t, start the {linkStart}download now.{linkEnd}"
	/// </summary>
	public override string ResponseDialogInstallingMessageWithLink(string linkStart, string linkEnd)
	{
		return $"Roblox 安裝程式將會開始下載。若下載沒有開始，請手動{linkStart}開始下載。{linkEnd}";
	}

	protected override string _GetTemplateForResponseDialogInstallingMessageWithLink()
	{
		return "Roblox 安裝程式將會開始下載。若下載沒有開始，請手動{linkStart}開始下載。{linkEnd}";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacChromeFifthInstruction"
	/// After installation, click {startBold}Play{endBold} below to join the action!
	/// English String: "After installation, click {startBold}Play{endBold} below to join the action!"
	/// </summary>
	public override string ResponseDialogMacChromeFifthInstruction(string startBold, string endBold)
	{
		return $"安裝後，按下下方的{startBold}開始遊戲{endBold}就可以開始玩！";
	}

	protected override string _GetTemplateForResponseDialogMacChromeFifthInstruction()
	{
		return "安裝後，按下下方的{startBold}開始遊戲{endBold}就可以開始玩！";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacChromeFirstInstruction"
	/// Click {startBold}Roblox.dmg{endBold} to run the Roblox installer, which just downloaded via your web browser.
	/// English String: "Click {startBold}Roblox.dmg{endBold} to run the Roblox installer, which just downloaded via your web browser."
	/// </summary>
	public override string ResponseDialogMacChromeFirstInstruction(string startBold, string endBold)
	{
		return $"按下 {startBold}Roblox.dmg{endBold} 執行剛才下載的 Roblox 安裝程式。";
	}

	protected override string _GetTemplateForResponseDialogMacChromeFirstInstruction()
	{
		return "按下 {startBold}Roblox.dmg{endBold} 執行剛才下載的 Roblox 安裝程式。";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacChromeFourthInstruction"
	/// Click {startBold}Ok{endBold} once you've successfully installed Roblox.
	/// English String: "Click {startBold}Ok{endBold} once you've successfully installed Roblox."
	/// </summary>
	public override string ResponseDialogMacChromeFourthInstruction(string startBold, string endBold)
	{
		return $"您成功安裝 Roblox 後，按下{startBold}確定{endBold}。";
	}

	protected override string _GetTemplateForResponseDialogMacChromeFourthInstruction()
	{
		return "您成功安裝 Roblox 後，按下{startBold}確定{endBold}。";
	}

	protected override string _GetTemplateForResponseDialogMacChromeSecondInstruction()
	{
		return "按兩下 Roblox App 圖示開始安裝程序。";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacChromeThirdInstruction"
	/// Click {startBold}Open{endBold} when prompted by your computer.
	/// English String: "Click {startBold}Open{endBold} when prompted by your computer."
	/// </summary>
	public override string ResponseDialogMacChromeThirdInstruction(string startBold, string endBold)
	{
		return $"依您的電腦提示，按下{startBold}開啟{endBold}。";
	}

	protected override string _GetTemplateForResponseDialogMacChromeThirdInstruction()
	{
		return "依您的電腦提示，按下{startBold}開啟{endBold}。";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacFirefoxFifthInstruction"
	/// Then select the Remember my choice... checkbox and click OK
	/// English String: "Then select the {startBold}Remember my choice...{endBold} checkbox and click {startBold2}OK{endBold2}"
	/// </summary>
	public override string ResponseDialogMacFirefoxFifthInstruction(string startBold, string endBold, string startBold2, string endBold2)
	{
		return $"接著選擇{startBold}記住我的選擇…{endBold} 選項，並按下{startBold2}確定{endBold2}";
	}

	protected override string _GetTemplateForResponseDialogMacFirefoxFifthInstruction()
	{
		return "接著選擇{startBold}記住我的選擇…{endBold} 選項，並按下{startBold2}確定{endBold2}";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacFirefoxFirstInstruction"
	/// Select Open with and click OK
	/// English String: "Select {startBold}Open with{endBold} and click {startBold2}OK{endBold2}"
	/// </summary>
	public override string ResponseDialogMacFirefoxFirstInstruction(string startBold, string endBold, string startBold2, string endBold2)
	{
		return $"選擇{startBold}開啟時使用{endBold}並按下{startBold2}確定{endBold2}";
	}

	protected override string _GetTemplateForResponseDialogMacFirefoxFirstInstruction()
	{
		return "選擇{startBold}開啟時使用{endBold}並按下{startBold2}確定{endBold2}";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacFirefoxFourthInstruction"
	/// Once installed, click Play to join the action!
	/// English String: "Once installed, click {startBold}Play{endBold} to join the action!"
	/// </summary>
	public override string ResponseDialogMacFirefoxFourthInstruction(string startBold, string endBold)
	{
		return $"安裝完畢後，按下{startBold}開始遊戲{endBold}進入 Roblox 的世界！";
	}

	protected override string _GetTemplateForResponseDialogMacFirefoxFourthInstruction()
	{
		return "安裝完畢後，按下{startBold}開始遊戲{endBold}進入 Roblox 的世界！";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacFirefoxSecondInstruction"
	/// Double-click the Roblox Icon to begin the installation process
	/// English String: "Double-click the {startBold}Roblox Icon{endBold} to begin the installation process"
	/// </summary>
	public override string ResponseDialogMacFirefoxSecondInstruction(string startBold, string endBold)
	{
		return $"按兩下 {startBold}Roblox 圖示{endBold}開始安裝程序";
	}

	protected override string _GetTemplateForResponseDialogMacFirefoxSecondInstruction()
	{
		return "按兩下 {startBold}Roblox 圖示{endBold}開始安裝程序";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacFirefoxThirdInstruction"
	/// You will receive a warning, click Open
	/// English String: "You will receive a warning, click {startBold}Open{endBold}"
	/// </summary>
	public override string ResponseDialogMacFirefoxThirdInstruction(string startBold, string endBold)
	{
		return $"您會收到警告，按下{startBold}開啟{endBold}";
	}

	protected override string _GetTemplateForResponseDialogMacFirefoxThirdInstruction()
	{
		return "您會收到警告，按下{startBold}開啟{endBold}";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacSafariFirstInstruction"
	/// Go to Downloads and double-click Roblox.dmg
	/// English String: "Go to Downloads and double-click {startBold}Roblox.dmg{endBold}"
	/// </summary>
	public override string ResponseDialogMacSafariFirstInstruction(string startBold, string endBold)
	{
		return $"前往「下載」並按兩下 {startBold}Roblox.dmg{endBold}";
	}

	protected override string _GetTemplateForResponseDialogMacSafariFirstInstruction()
	{
		return "前往「下載」並按兩下 {startBold}Roblox.dmg{endBold}";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacSafariFourthInstruction"
	/// Once installed, click {startBold}Play{endBold} to join the action!
	/// English String: "Once installed, click {startBold}Play{endBold} to join the action!"
	/// </summary>
	public override string ResponseDialogMacSafariFourthInstruction(string startBold, string endBold)
	{
		return $"安裝完畢後，按下{startBold}開始遊戲{endBold}進入 Roblox 的世界！";
	}

	protected override string _GetTemplateForResponseDialogMacSafariFourthInstruction()
	{
		return "安裝完畢後，按下{startBold}開始遊戲{endBold}進入 Roblox 的世界！";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacSafariSecondInstruction"
	/// Double-click the {startBold}Roblox Icon{endBold} to begin the installation process
	/// English String: "Double-click the {startBold}Roblox Icon{endBold} to begin the installation process"
	/// </summary>
	public override string ResponseDialogMacSafariSecondInstruction(string startBold, string endBold)
	{
		return $"按兩下 {startBold}Roblox 圖示{endBold}開始安裝程序";
	}

	protected override string _GetTemplateForResponseDialogMacSafariSecondInstruction()
	{
		return "按兩下 {startBold}Roblox 圖示{endBold}開始安裝程序";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacSafariThirdInstruction"
	/// You will receive a warning, click {startBold}Open{endBold}
	/// English String: "You will receive a warning, click {startBold}Open{endBold}"
	/// </summary>
	public override string ResponseDialogMacSafariThirdInstruction(string startBold, string endBold)
	{
		return $"您會收到警告訊息，按下{startBold}開啟{endBold}";
	}

	protected override string _GetTemplateForResponseDialogMacSafariThirdInstruction()
	{
		return "您會收到警告訊息，按下{startBold}開啟{endBold}";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcChromeFirstInstruction"
	/// Click {startBold}RobloxPlayer.exe{endBold} to run the Roblox installer, which just downloaded via your web browser.
	/// English String: "Click {startBold}RobloxPlayer.exe{endBold} to run the Roblox installer, which just downloaded via your web browser."
	/// </summary>
	public override string ResponseDialogPcChromeFirstInstruction(string startBold, string endBold)
	{
		return $"按下 {startBold}RobloxPlayer.exe{endBold} 執行您下載的 Roblox 安裝程式。";
	}

	protected override string _GetTemplateForResponseDialogPcChromeFirstInstruction()
	{
		return "按下 {startBold}RobloxPlayer.exe{endBold} 執行您下載的 Roblox 安裝程式。";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcChromeFourthInstruction"
	/// After installation, click {startBold}Play{endBold} below to join the action!
	/// English String: "After installation, click {startBold}Play{endBold} below to join the action!"
	/// </summary>
	public override string ResponseDialogPcChromeFourthInstruction(string startBold, string endBold)
	{
		return $"安裝後，按下下方的{startBold}開始遊戲{endBold}進入 Roblox 的世界！";
	}

	protected override string _GetTemplateForResponseDialogPcChromeFourthInstruction()
	{
		return "安裝後，按下下方的{startBold}開始遊戲{endBold}進入 Roblox 的世界！";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcChromeSecondInstruction"
	/// Click {startBold}Run{endBold} when prompted by your computer to begin the installation process.
	/// English String: "Click {startBold}Run{endBold} when prompted by your computer to begin the installation process."
	/// </summary>
	public override string ResponseDialogPcChromeSecondInstruction(string startBold, string endBold)
	{
		return $"依照電腦指示，按下{startBold}執行{endBold}開始安裝程序。";
	}

	protected override string _GetTemplateForResponseDialogPcChromeSecondInstruction()
	{
		return "依照電腦指示，按下{startBold}執行{endBold}開始安裝程序。";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcChromeThirdInstruction"
	/// Click {startBold}Ok{endBold} once you've successfully installed Roblox.
	/// English String: "Click {startBold}Ok{endBold} once you've successfully installed Roblox."
	/// </summary>
	public override string ResponseDialogPcChromeThirdInstruction(string startBold, string endBold)
	{
		return $"Roblox 安裝完畢後，按下{startBold}確定{endBold}。";
	}

	protected override string _GetTemplateForResponseDialogPcChromeThirdInstruction()
	{
		return "Roblox 安裝完畢後，按下{startBold}確定{endBold}。";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcEdgeFirstInstruction"
	/// Click {startBold}Run{endBold} to install Roblox after the download finishes
	/// English String: "Click {startBold}Run{endBold} to install Roblox after the download finishes"
	/// </summary>
	public override string ResponseDialogPcEdgeFirstInstruction(string startBold, string endBold)
	{
		return $"下載完成後，按下{startBold}執行{endBold}開始安裝 Roblox";
	}

	protected override string _GetTemplateForResponseDialogPcEdgeFirstInstruction()
	{
		return "下載完成後，按下{startBold}執行{endBold}開始安裝 Roblox";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcEdgeSecondInstruction"
	/// Click {startBold}Ok{endBold} to finish installing Roblox
	/// English String: "Click {startBold}Ok{endBold} to finish installing Roblox"
	/// </summary>
	public override string ResponseDialogPcEdgeSecondInstruction(string startBold, string endBold)
	{
		return $"按下{startBold}確定{endBold}完成安裝 Roblox";
	}

	protected override string _GetTemplateForResponseDialogPcEdgeSecondInstruction()
	{
		return "按下{startBold}確定{endBold}完成安裝 Roblox";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcEdgeThirdInstruction"
	/// Click the {startBold}Play{endBold} button to join the action!
	/// English String: "Click the {startBold}Play{endBold} button to join the action!"
	/// </summary>
	public override string ResponseDialogPcEdgeThirdInstruction(string startBold, string endBold)
	{
		return $"按下{startBold}開始遊戲{endBold}按鈕，進入 Roblox 的世界！";
	}

	protected override string _GetTemplateForResponseDialogPcEdgeThirdInstruction()
	{
		return "按下{startBold}開始遊戲{endBold}按鈕，進入 Roblox 的世界！";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcFirefoxFifthInstruction"
	/// Click {startBold}Ok{endBold} when the alert pops up
	/// English String: "Click {startBold}Ok{endBold} when the alert pops up"
	/// </summary>
	public override string ResponseDialogPcFirefoxFifthInstruction(string startBold, string endBold)
	{
		return $"警告視窗彈出後，按下{startBold}確定{endBold}";
	}

	protected override string _GetTemplateForResponseDialogPcFirefoxFifthInstruction()
	{
		return "警告視窗彈出後，按下{startBold}確定{endBold}";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcFirefoxFirstInstruction"
	/// Click {startBold}Save File{endBold} when the download window pops up
	/// English String: "Click {startBold}Save File{endBold} when the download window pops up"
	/// </summary>
	public override string ResponseDialogPcFirefoxFirstInstruction(string startBold, string endBold)
	{
		return $"下載視窗彈出時，按下{startBold}儲存檔案{endBold}";
	}

	protected override string _GetTemplateForResponseDialogPcFirefoxFirstInstruction()
	{
		return "下載視窗彈出時，按下{startBold}儲存檔案{endBold}";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcFirefoxFourthInstruction"
	/// Once installed, click {startBold}Play{endBold} to join the action!
	/// English String: "Once installed, click {startBold}Play{endBold} to join the action!"
	/// </summary>
	public override string ResponseDialogPcFirefoxFourthInstruction(string startBold, string endBold)
	{
		return $"安裝完畢後，按下{startBold}開始遊戲{endBold}進入 Roblox 的世界！";
	}

	protected override string _GetTemplateForResponseDialogPcFirefoxFourthInstruction()
	{
		return "安裝完畢後，按下{startBold}開始遊戲{endBold}進入 Roblox 的世界！";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcFirefoxSecondInstruction"
	/// Go to Downloads and double click {startBold}RobloxPlayer.exe{endBold}
	/// English String: "Go to Downloads and double click {startBold}RobloxPlayer.exe{endBold}"
	/// </summary>
	public override string ResponseDialogPcFirefoxSecondInstruction(string startBold, string endBold)
	{
		return $"前往「下載」並按兩下 {startBold}RobloxPlayer.exe{endBold}";
	}

	protected override string _GetTemplateForResponseDialogPcFirefoxSecondInstruction()
	{
		return "前往「下載」並按兩下 {startBold}RobloxPlayer.exe{endBold}";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcFirefoxThirdInstruction"
	/// Click {startBold}Run{endBold}
	/// English String: "Click {startBold}Run{endBold}"
	/// </summary>
	public override string ResponseDialogPcFirefoxThirdInstruction(string startBold, string endBold)
	{
		return $"按下{startBold}執行{endBold}";
	}

	protected override string _GetTemplateForResponseDialogPcFirefoxThirdInstruction()
	{
		return "按下{startBold}執行{endBold}";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcIEFirstInstruction"
	/// You will receive a warning, click {startBold}Run{endBold}
	/// English String: "You will receive a warning, click {startBold}Run{endBold}"
	/// </summary>
	public override string ResponseDialogPcIEFirstInstruction(string startBold, string endBold)
	{
		return $"您會收到警告，請按下{startBold}執行{endBold}";
	}

	protected override string _GetTemplateForResponseDialogPcIEFirstInstruction()
	{
		return "您會收到警告，請按下{startBold}執行{endBold}";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcIeInstructionOne"
	/// You will receive a warning, click {startBold}Run{endBold}
	/// English String: "You will receive a warning, click {startBold}Run{endBold}"
	/// </summary>
	public override string ResponseDialogPcIeInstructionOne(string startBold, string endBold)
	{
		return $"您會收到警告，請按下{startBold}執行{endBold}";
	}

	protected override string _GetTemplateForResponseDialogPcIeInstructionOne()
	{
		return "您會收到警告，請按下{startBold}執行{endBold}";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcIeInstructionThree"
	/// Click {startBold}Run{endBold}
	/// English String: "Click {startBold}Run{endBold}"
	/// </summary>
	public override string ResponseDialogPcIeInstructionThree(string startBold, string endBold)
	{
		return $"按下{startBold}執行{endBold}";
	}

	protected override string _GetTemplateForResponseDialogPcIeInstructionThree()
	{
		return "按下{startBold}執行{endBold}";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcIeInstructionTwo"
	/// Go to Downloads and double click {startBold}RobloxPlayer.exe{endBold}
	/// English String: "Go to Downloads and double click {startBold}RobloxPlayer.exe{endBold}"
	/// </summary>
	public override string ResponseDialogPcIeInstructionTwo(string startBold, string endBold)
	{
		return $"前往「下載」並按兩下 {startBold}RobloxPlayer.exe{endBold}";
	}

	protected override string _GetTemplateForResponseDialogPcIeInstructionTwo()
	{
		return "前往「下載」並按兩下 {startBold}RobloxPlayer.exe{endBold}";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcIESecondInstruction"
	/// Click {startBold}Ok{endBold} once you've installed Roblox
	/// English String: "Click {startBold}Ok{endBold} once you've installed Roblox"
	/// </summary>
	public override string ResponseDialogPcIESecondInstruction(string startBold, string endBold)
	{
		return $"您安裝 Roblox 後，按下{startBold}確定{endBold}";
	}

	protected override string _GetTemplateForResponseDialogPcIESecondInstruction()
	{
		return "您安裝 Roblox 後，按下{startBold}確定{endBold}";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcIEThirdInstruction"
	/// Once installed, click {startBold}Play{endBold} to join the action!
	/// English String: "Once installed, click {startBold}Play{endBold} to join the action!"
	/// </summary>
	public override string ResponseDialogPcIEThirdInstruction(string startBold, string endBold)
	{
		return $"安裝完畢後，按下{startBold}開始遊戲{endBold}進入 Roblox 的世界！";
	}

	protected override string _GetTemplateForResponseDialogPcIEThirdInstruction()
	{
		return "安裝完畢後，按下{startBold}開始遊戲{endBold}進入 Roblox 的世界！";
	}

	protected override string _GetTemplateForResponseDialogThanksForPlayingRoblox()
	{
		return "謝謝您玩 Roblox";
	}

	protected override string _GetTemplateForResponseGameTemporarilyUnavailable()
	{
		return "無法驗證您的遊戲通行權，請稍後再試。";
	}

	/// <summary>
	/// Key: "Response.RememberMyChoiceAppLaunch"
	/// Check {startBold}Remember my choice{endBold} and click {appLaunchLink} in the dialog box above to join games faster in the future!
	/// English String: "Check {startBold}Remember my choice{endBold} and click {appLaunchLink} in the dialog box above to join games faster in the future!"
	/// </summary>
	public override string ResponseRememberMyChoiceAppLaunch(string startBold, string endBold, string appLaunchLink)
	{
		return $"勾選{startBold}記住我的選擇{endBold}，並在上方的對話框按下{appLaunchLink}，就可以更快加入遊戲！";
	}

	protected override string _GetTemplateForResponseRememberMyChoiceAppLaunch()
	{
		return "勾選{startBold}記住我的選擇{endBold}，並在上方的對話框按下{appLaunchLink}，就可以更快加入遊戲！";
	}
}
