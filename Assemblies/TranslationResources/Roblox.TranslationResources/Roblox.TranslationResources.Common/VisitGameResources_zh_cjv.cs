namespace Roblox.TranslationResources.Common;

/// <summary>
/// This class overrides VisitGameResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class VisitGameResources_zh_cjv : VisitGameResources_en_us, IVisitGameResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Retry"
	/// button label
	/// English String: "Retry"
	/// </summary>
	public override string ActionRetry => "重试";

	/// <summary>
	/// Key: "Heading.ErrorStartingGame"
	/// Error starting game
	/// English String: "Error starting game"
	/// </summary>
	public override string HeadingErrorStartingGame => "启动游戏时出错。";

	/// <summary>
	/// Key: "Heading.SwitchToDesktopToPlay"
	/// Switch to Desktop Mode to Play Games
	/// English String: "Switch to Desktop Mode to Play Games"
	/// </summary>
	public override string HeadingSwitchToDesktopToPlay => "切换至桌面模式以开始游戏";

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
	public override string LabelCheckingForStudio => "正在检查 Roblox Studio...";

	/// <summary>
	/// Key: "Label.ClickHereForHelp"
	/// Click here for help
	/// English String: "Click here for help"
	/// </summary>
	public override string LabelClickHereForHelp => "点击此处获取帮助";

	/// <summary>
	/// Key: "Label.ConnectingToPlayers"
	/// Joining a game network with other players
	/// English String: "Connecting to Players..."
	/// </summary>
	public override string LabelConnectingToPlayers => "正在连接玩家...";

	/// <summary>
	/// Key: "Label.DevelopPageTitle"
	/// English String: "Develop"
	/// </summary>
	public override string LabelDevelopPageTitle => "开发";

	/// <summary>
	/// Key: "Label.DownloadInstallRoblox"
	/// Download and Install Roblox
	/// English String: "Download and Install Roblox"
	/// </summary>
	public override string LabelDownloadInstallRoblox => "下载并安装 Roblox";

	/// <summary>
	/// Key: "Label.DownloadStudio"
	/// Download Roblox Studio to start creating games
	/// English String: "Download Studio"
	/// </summary>
	public override string LabelDownloadStudio => "下载 Studio";

	/// <summary>
	/// Key: "Label.GameConfigurePageTitle"
	/// English String: "Game Configure"
	/// </summary>
	public override string LabelGameConfigurePageTitle => "游戏配置";

	/// <summary>
	/// Key: "Label.GameFreeSoothsayer"
	/// English String: "Free because you are a soothsayer"
	/// </summary>
	public override string LabelGameFreeSoothsayer => "免费，由于你是 Soothsayer 用户";

	/// <summary>
	/// Key: "Label.GameUnavailableAccountResrictions"
	/// English String: "The game is unavailable due to account restrictions settings."
	/// </summary>
	public override string LabelGameUnavailableAccountResrictions => "由于帐户限制设置，此游戏不可用。";

	/// <summary>
	/// Key: "Label.GameUnavailableCannotPlayGamesStudio"
	/// English String: "You cannot play games from Studio. Please use a web browser to play this game."
	/// </summary>
	public override string LabelGameUnavailableCannotPlayGamesStudio => "你无法玩 Studio 上的游戏。请使用网络浏览器开始此游戏。";

	/// <summary>
	/// Key: "Label.GameUnavailableClosedToVisitors"
	/// English String: "Sorry, this place is currently closed to visitors."
	/// </summary>
	public override string LabelGameUnavailableClosedToVisitors => "抱歉，此场景当前不对访客开放。";

	/// <summary>
	/// Key: "Label.GameUnavailableCurrentlyIsPrivateVisitor"
	/// When a game is private, this message is shown to visitors.
	/// English String: "Sorry, this game is private."
	/// </summary>
	public override string LabelGameUnavailableCurrentlyIsPrivateVisitor => "抱歉，这是私人游戏。";

	/// <summary>
	/// Key: "Label.GameUnavailableGameInsecure"
	/// U13 users cannot play insecure games unless they are the creator or friends with the creator.
	/// English String: "Sorry, your account is restricted from playing Experimental Games unless you are friends with the creator."
	/// </summary>
	public override string LabelGameUnavailableGameInsecure => "抱歉，你与创作者还不是好友，因此你无法加入实验性游戏。";

	/// <summary>
	/// Key: "Label.GameUnavailablePermissionLevels"
	/// English String: "The permission levels on this place prevent you from entering."
	/// </summary>
	public override string LabelGameUnavailablePermissionLevels => "你的权限不足，无法进入此场景。";

	/// <summary>
	/// Key: "Label.GameUnavailablePlaceUnderReview"
	/// English String: "Sorry, this place is currently under review. Try again later."
	/// </summary>
	public override string LabelGameUnavailablePlaceUnderReview => "抱歉，此场景当前正接受审核。请稍后重试。";

	/// <summary>
	/// Key: "Label.GameUnavailablePlatform"
	/// English String: "This game is not available on your platform.  Check the games page to see all playable games."
	/// </summary>
	public override string LabelGameUnavailablePlatform => "此游戏无法再你的平台上运行。请在游戏页面查看全部可玩的游戏。";

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
	public override string LabelInstallationInstructions => "安装说明";

	/// <summary>
	/// Key: "Label.LaunchApplication"
	/// Launch Application
	/// English String: "Launch Application"
	/// </summary>
	public override string LabelLaunchApplication => "启动应用程序";

	/// <summary>
	/// Key: "Label.PersuadeToDevelopRoblox"
	/// Persuade user to begin developing their own games using Roblox Studio
	/// English String: "Get started creating your own games!"
	/// </summary>
	public override string LabelPersuadeToDevelopRoblox => "开始创作你自己的游戏！";

	/// <summary>
	/// Key: "Label.PersuadeToInstallRoblox"
	/// We are exciting the user about Roblox so that they will be persuaded to download and install it.
	/// English String: "You're moments away from getting into the game!"
	/// </summary>
	public override string LabelPersuadeToInstallRoblox => "你很快就要进入游戏啦！";

	/// <summary>
	/// Key: "Label.Play"
	/// English String: "Play"
	/// </summary>
	public override string LabelPlay => "开始游戏";

	/// <summary>
	/// Key: "Label.PlayInApp"
	/// English String: "Play in App"
	/// </summary>
	public override string LabelPlayInApp => "在 App 中玩";

	/// <summary>
	/// Key: "Label.RobloxLoadingToPlay"
	/// Roblox is loading, so the user is getting excited to start playing a game
	/// English String: "Roblox is now loading. Get ready to play!"
	/// </summary>
	public override string LabelRobloxLoadingToPlay => "正在加载 Roblox。准备好，游戏马上开始！";

	/// <summary>
	/// Key: "Label.StartingRoblox"
	/// Game launch process has started
	/// English String: "Starting Roblox..."
	/// </summary>
	public override string LabelStartingRoblox => "正在启动 Roblox...";

	/// <summary>
	/// Key: "Label.SwitchToDesktopMode"
	/// Switch to Desktop Mode
	/// English String: "Switch to Desktop Mode"
	/// </summary>
	public override string LabelSwitchToDesktopMode => "切换至桌面模式";

	/// <summary>
	/// Key: "Label.UniverseConfigurePageTitle"
	/// The name of the universe configuration page
	/// English String: "Universe Configuration"
	/// </summary>
	public override string LabelUniverseConfigurePageTitle => "通用配置";

	/// <summary>
	/// Key: "Response.Dialog.ClickHere"
	/// Click here!
	/// English String: "Click here!"
	/// </summary>
	public override string ResponseDialogClickHere => "点按此处！";

	/// <summary>
	/// Key: "Response.Dialog.ErrorLaunching"
	/// An error occurred trying to launch the game.  Please try again later.
	/// English String: "An error occurred trying to launch the game.  Please try again later."
	/// </summary>
	public override string ResponseDialogErrorLaunching => "尝试启动游戏时发生错误。请稍后重试。";

	/// <summary>
	/// Key: "Response.Dialog.HavingTroubleInstallQuestion"
	/// (Are you) having trouble installing Roblox?
	/// English String: "Having trouble installing Roblox?"
	/// </summary>
	public override string ResponseDialogHavingTroubleInstallQuestion => "安装 Roblox 时遇到问题？";

	/// <summary>
	/// Key: "Response.Dialog.MacChromeSecondInstruction"
	/// Double-click the Roblox app icon to begin the installation process.
	/// English String: "Double-click the Roblox app icon to begin the installation process."
	/// </summary>
	public override string ResponseDialogMacChromeSecondInstruction => "连按 Roblox App 图标以开始安装程序。";

	/// <summary>
	/// Key: "Response.Dialog.ThanksForPlayingRoblox"
	/// Thanks for playing Roblox
	/// English String: "Thanks for playing Roblox"
	/// </summary>
	public override string ResponseDialogThanksForPlayingRoblox => "谢谢你玩 Roblox";

	/// <summary>
	/// Key: "Response.GameTemporarilyUnavailable"
	/// error message (will be followed by link with Action.Retry label)
	/// English String: "Unable to verify that you have access to this game.  Please try again later."
	/// </summary>
	public override string ResponseGameTemporarilyUnavailable => "无法验证你是否有权访问此游戏。请稍后重试。";

	public VisitGameResources_zh_cjv(TranslationResourceState state)
		: base(state)
	{
	}

	/// <summary>
	/// Key: "Action.GamePerformPoorly"
	/// English String: "{warning} This game may perform poorly on your device."
	/// </summary>
	public override string ActionGamePerformPoorly(string warning)
	{
		return $"{warning} 此游戏可能在你的设备上运行不佳。";
	}

	protected override string _GetTemplateForActionGamePerformPoorly()
	{
		return "{warning} 此游戏可能在你的设备上运行不佳。";
	}

	protected override string _GetTemplateForActionRetry()
	{
		return "重试";
	}

	protected override string _GetTemplateForHeadingErrorStartingGame()
	{
		return "启动游戏时出错。";
	}

	protected override string _GetTemplateForHeadingSwitchToDesktopToPlay()
	{
		return "切换至桌面模式以开始游戏";
	}

	/// <summary>
	/// Key: "Label.BuyAccess"
	/// English String: "Buy Access for {robux} Robux"
	/// </summary>
	public override string LabelBuyAccess(string robux)
	{
		return $"以 {robux} Robux 购买通行证";
	}

	protected override string _GetTemplateForLabelBuyAccess()
	{
		return "以 {robux} Robux 购买通行证";
	}

	protected override string _GetTemplateForLabelCancel()
	{
		return "取消";
	}

	protected override string _GetTemplateForLabelCheckingForStudio()
	{
		return "正在检查 Roblox Studio...";
	}

	protected override string _GetTemplateForLabelClickHereForHelp()
	{
		return "点击此处获取帮助";
	}

	protected override string _GetTemplateForLabelConnectingToPlayers()
	{
		return "正在连接玩家...";
	}

	protected override string _GetTemplateForLabelDevelopPageTitle()
	{
		return "开发";
	}

	protected override string _GetTemplateForLabelDownloadInstallRoblox()
	{
		return "下载并安装 Roblox";
	}

	protected override string _GetTemplateForLabelDownloadStudio()
	{
		return "下载 Studio";
	}

	protected override string _GetTemplateForLabelGameConfigurePageTitle()
	{
		return "游戏配置";
	}

	protected override string _GetTemplateForLabelGameFreeSoothsayer()
	{
		return "免费，由于你是 Soothsayer 用户";
	}

	/// <summary>
	/// Key: "Label.GameIsPrivatePlayableByGroupOnly"
	/// When a game is private, this message is shown to group developers with a link from where it can be made public.
	/// English String: "Only developers can play because this game is private. Make it public on the {linkStart}Configure Game{linkEnd} page."
	/// </summary>
	public override string LabelGameIsPrivatePlayableByGroupOnly(string linkStart, string linkEnd)
	{
		return $"这是私人游戏，只有开发者能玩。请在{linkStart}配置游戏{linkEnd}页面将其设为公开。";
	}

	protected override string _GetTemplateForLabelGameIsPrivatePlayableByGroupOnly()
	{
		return "这是私人游戏，只有开发者能玩。请在{linkStart}配置游戏{linkEnd}页面将其设为公开。";
	}

	/// <summary>
	/// Key: "Label.GameIsPrivatePlayableByOwnerOnly"
	/// When a game is private, this message is shown to owner with a link from where it can be made public.
	/// English String: "Only you can play because this game is private. Make it public on the {linkStart}Configure Game{linkEnd} page."
	/// </summary>
	public override string LabelGameIsPrivatePlayableByOwnerOnly(string linkStart, string linkEnd)
	{
		return $"这是私人游戏，只有你能玩。请在{linkStart}配置游戏{linkEnd}页面将其设为公开。";
	}

	protected override string _GetTemplateForLabelGameIsPrivatePlayableByOwnerOnly()
	{
		return "这是私人游戏，只有你能玩。请在{linkStart}配置游戏{linkEnd}页面将其设为公开。";
	}

	protected override string _GetTemplateForLabelGameUnavailableAccountResrictions()
	{
		return "由于帐户限制设置，此游戏不可用。";
	}

	protected override string _GetTemplateForLabelGameUnavailableCannotPlayGamesStudio()
	{
		return "你无法玩 Studio 上的游戏。请使用网络浏览器开始此游戏。";
	}

	protected override string _GetTemplateForLabelGameUnavailableClosedToVisitors()
	{
		return "抱歉，此场景当前不对访客开放。";
	}

	/// <summary>
	/// Key: "Label.GameUnavailableCurrentlyIsPrivateGroup"
	/// When a game is private, this message is shown to group developers with a link from where it can be made public. Similar to an existing translation. Change is making the message directly address the group developers.
	/// English String: "Only developers can play because this game is private. Make it public on the {linkStart}Develop{linkEnd} page."
	/// </summary>
	public override string LabelGameUnavailableCurrentlyIsPrivateGroup(string linkStart, string linkEnd)
	{
		return $"这是四人游戏，只有开发者可以玩。请在{linkStart}创建{linkEnd}页面将其设为公开。";
	}

	protected override string _GetTemplateForLabelGameUnavailableCurrentlyIsPrivateGroup()
	{
		return "这是四人游戏，只有开发者可以玩。请在{linkStart}创建{linkEnd}页面将其设为公开。";
	}

	/// <summary>
	/// Key: "Label.GameUnavailableCurrentlyIsPrivateOwner"
	/// When a game is private, this message is shown to owner with a link from where it can be made public. Similar to an existing translation. Change is making the message directly address the owner.
	/// English String: "Only you can play because this game is private. Make it public on the {linkStart}Develop{linkEnd} page."
	/// </summary>
	public override string LabelGameUnavailableCurrentlyIsPrivateOwner(string linkStart, string linkEnd)
	{
		return $"这是私人游戏，只有你能玩。请在{linkStart}创建{linkEnd}页面将其设为公开。";
	}

	protected override string _GetTemplateForLabelGameUnavailableCurrentlyIsPrivateOwner()
	{
		return "这是私人游戏，只有你能玩。请在{linkStart}创建{linkEnd}页面将其设为公开。";
	}

	protected override string _GetTemplateForLabelGameUnavailableCurrentlyIsPrivateVisitor()
	{
		return "抱歉，这是私人游戏。";
	}

	/// <summary>
	/// Key: "Label.GameUnavailableCurrentlyPrivate"
	/// When a game is private, this message is shown to user with link from where it can be made public
	/// English String: "This {gameTypeName} is currently private. Make it public on the {developPageLink} page to make it playable."
	/// </summary>
	public override string LabelGameUnavailableCurrentlyPrivate(string gameTypeName, string developPageLink)
	{
		return $"此“{gameTypeName}”当前为私人模式。请在 {developPageLink} 页面将其设为公开，使它成为可玩状态。";
	}

	protected override string _GetTemplateForLabelGameUnavailableCurrentlyPrivate()
	{
		return "此“{gameTypeName}”当前为私人模式。请在 {developPageLink} 页面将其设为公开，使它成为可玩状态。";
	}

	protected override string _GetTemplateForLabelGameUnavailableGameInsecure()
	{
		return "抱歉，你与创作者还不是好友，因此你无法加入实验性游戏。";
	}

	/// <summary>
	/// Key: "Label.GameUnavailableNoRootPlace"
	/// English String: "This place is part of a game that has no root place. Add a root place on the {gameConfigureLink} page to make it playable."
	/// </summary>
	public override string LabelGameUnavailableNoRootPlace(string gameConfigureLink)
	{
		return $"此场景所在的游戏没有根场景。在 {gameConfigureLink} 页面添加根场景，使它成为可玩状态。";
	}

	protected override string _GetTemplateForLabelGameUnavailableNoRootPlace()
	{
		return "此场景所在的游戏没有根场景。在 {gameConfigureLink} 页面添加根场景，使它成为可玩状态。";
	}

	protected override string _GetTemplateForLabelGameUnavailablePermissionLevels()
	{
		return "你的权限不足，无法进入此场景。";
	}

	/// <summary>
	/// Key: "Label.GameUnavailablePlaceNotPartOfGame"
	/// English String: "This place is not currently part of a Game. Add it to a game on the {developPageLink} page to make it playable."
	/// </summary>
	public override string LabelGameUnavailablePlaceNotPartOfGame(string developPageLink)
	{
		return $"此场景当前不属于任何游戏。请在 {developPageLink} 页面将其添加至一款游戏中，使它成为可玩状态。";
	}

	protected override string _GetTemplateForLabelGameUnavailablePlaceNotPartOfGame()
	{
		return "此场景当前不属于任何游戏。请在 {developPageLink} 页面将其添加至一款游戏中，使它成为可玩状态。";
	}

	protected override string _GetTemplateForLabelGameUnavailablePlaceUnderReview()
	{
		return "抱歉，此场景当前正接受审核。请稍后重试。";
	}

	protected override string _GetTemplateForLabelGameUnavailablePlatform()
	{
		return "此游戏无法再你的平台上运行。请在游戏页面查看全部可玩的游戏。";
	}

	protected override string _GetTemplateForLabelGameWarning()
	{
		return "警告";
	}

	protected override string _GetTemplateForLabelInstallationInstructions()
	{
		return "安装说明";
	}

	protected override string _GetTemplateForLabelLaunchApplication()
	{
		return "启动应用程序";
	}

	/// <summary>
	/// Key: "Label.OperaInstallSteps"
	/// 1) A window will open. Click Open2) Doubleclick the Roblox icon.
	/// English String: "1) A window will open. Click {startBold}Open{endBold}.{breakLine}2) Doubleclick the Roblox icon."
	/// </summary>
	public override string LabelOperaInstallSteps(string startBold, string endBold, string breakLine)
	{
		return $"1) 窗口将会打开。点按{startBold}打开{endBold}。{breakLine}2) 连按 Roblox 图标。";
	}

	protected override string _GetTemplateForLabelOperaInstallSteps()
	{
		return "1) 窗口将会打开。点按{startBold}打开{endBold}。{breakLine}2) 连按 Roblox 图标。";
	}

	protected override string _GetTemplateForLabelPersuadeToDevelopRoblox()
	{
		return "开始创作你自己的游戏！";
	}

	protected override string _GetTemplateForLabelPersuadeToInstallRoblox()
	{
		return "你很快就要进入游戏啦！";
	}

	protected override string _GetTemplateForLabelPlay()
	{
		return "开始游戏";
	}

	protected override string _GetTemplateForLabelPlayInApp()
	{
		return "在 App 中玩";
	}

	protected override string _GetTemplateForLabelRobloxLoadingToPlay()
	{
		return "正在加载 Roblox。准备好，游戏马上开始！";
	}

	protected override string _GetTemplateForLabelStartingRoblox()
	{
		return "正在启动 Roblox...";
	}

	protected override string _GetTemplateForLabelSwitchToDesktopMode()
	{
		return "切换至桌面模式";
	}

	protected override string _GetTemplateForLabelUniverseConfigurePageTitle()
	{
		return "通用配置";
	}

	/// <summary>
	/// Key: "Response.CheckAlwaysOpenRoblox"
	/// Check {startBold}Always open links for Roblox{endBold} and click {startBold2}Open Roblox{endBold2} in the dialog box above to join games faster in the future!
	/// English String: "Check {startBold}Always open links for Roblox{endBold} and click {startBold2}Open Roblox{endBold2} in the dialog box above to join games faster in the future!"
	/// </summary>
	public override string ResponseCheckAlwaysOpenRoblox(string startBold, string endBold, string startBold2, string endBold2)
	{
		return $"选中{startBold}始终打开 Roblox 链接{endBold}，并在上方对话框中点按{startBold2}打开 Roblox{endBold2}，之后就可以更快加入游戏！";
	}

	protected override string _GetTemplateForResponseCheckAlwaysOpenRoblox()
	{
		return "选中{startBold}始终打开 Roblox 链接{endBold}，并在上方对话框中点按{startBold2}打开 Roblox{endBold2}，之后就可以更快加入游戏！";
	}

	/// <summary>
	/// Key: "Response.CheckAlwaysOpenRobloxURL"
	/// Check {startBold}Always open links for URL: Roblox Protocol{endBold} and click {startBold}Open URL: Roblox Protocol{endBold} in the dialog box above to join games faster in the future!
	/// English String: "Check {startBold}Always open links for URL: Roblox Protocol{endBold} and click {startBold2}Open URL: Roblox Protocol{endBold2} in the dialog box above to join games faster in the future!"
	/// </summary>
	public override string ResponseCheckAlwaysOpenRobloxURL(string startBold, string endBold, string startBold2, string endBold2)
	{
		return $"选中{startBold}始终打开 URL：Roblox 协议链接{endBold}，并在上方对话框中点按{startBold2}打开 URL：Roblox 协议{endBold2}，之后就可以更快加入游戏！";
	}

	protected override string _GetTemplateForResponseCheckAlwaysOpenRobloxURL()
	{
		return "选中{startBold}始终打开 URL：Roblox 协议链接{endBold}，并在上方对话框中点按{startBold2}打开 URL：Roblox 协议{endBold2}，之后就可以更快加入游戏！";
	}

	/// <summary>
	/// Key: "Response.CheckRememberMyChoiceOK"
	/// Check Remember my choice and click OK in the dialog box above to join games faster in the future!
	/// English String: "Check {startBold}Remember my choice{endBold} and click {startBold2}OK{endBold2} in the dialog box above to join games faster in the future!"
	/// </summary>
	public override string ResponseCheckRememberMyChoiceOK(string startBold, string endBold, string startBold2, string endBold2)
	{
		return $"选中{startBold}记住我的选择{endBold}，并在上方对话框中点按{startBold2}确定{endBold2}，之后就可以更快加入游戏！";
	}

	protected override string _GetTemplateForResponseCheckRememberMyChoiceOK()
	{
		return "选中{startBold}记住我的选择{endBold}，并在上方对话框中点按{startBold2}确定{endBold2}，之后就可以更快加入游戏！";
	}

	protected override string _GetTemplateForResponseDialogClickHere()
	{
		return "点按此处！";
	}

	protected override string _GetTemplateForResponseDialogErrorLaunching()
	{
		return "尝试启动游戏时发生错误。请稍后重试。";
	}

	protected override string _GetTemplateForResponseDialogHavingTroubleInstallQuestion()
	{
		return "安装 Roblox 时遇到问题？";
	}

	/// <summary>
	/// Key: "Response.Dialog.InstallingMessageWithLink"
	/// Note: For this translation, please move the linkStart and linkEnd variables with the translation for download now.
	/// English String: "The Roblox installer should download shortly. If it doesn’t, start the {linkStart}download now.{linkEnd}"
	/// </summary>
	public override string ResponseDialogInstallingMessageWithLink(string linkStart, string linkEnd)
	{
		return $"Roblox 安装程序很快就会开始下载。如果下载没有开始，请手动{linkStart}开始下载{linkEnd}。";
	}

	protected override string _GetTemplateForResponseDialogInstallingMessageWithLink()
	{
		return "Roblox 安装程序很快就会开始下载。如果下载没有开始，请手动{linkStart}开始下载{linkEnd}。";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacChromeFifthInstruction"
	/// After installation, click {startBold}Play{endBold} below to join the action!
	/// English String: "After installation, click {startBold}Play{endBold} below to join the action!"
	/// </summary>
	public override string ResponseDialogMacChromeFifthInstruction(string startBold, string endBold)
	{
		return $"安装完毕后，点按下面的{startBold}开始游戏{endBold}即可加入游戏！";
	}

	protected override string _GetTemplateForResponseDialogMacChromeFifthInstruction()
	{
		return "安装完毕后，点按下面的{startBold}开始游戏{endBold}即可加入游戏！";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacChromeFirstInstruction"
	/// Click {startBold}Roblox.dmg{endBold} to run the Roblox installer, which just downloaded via your web browser.
	/// English String: "Click {startBold}Roblox.dmg{endBold} to run the Roblox installer, which just downloaded via your web browser."
	/// </summary>
	public override string ResponseDialogMacChromeFirstInstruction(string startBold, string endBold)
	{
		return $"点按 {startBold}Roblox.dmg{endBold}，运行刚刚通过网络浏览器下载的 Roblox 安装程序。";
	}

	protected override string _GetTemplateForResponseDialogMacChromeFirstInstruction()
	{
		return "点按 {startBold}Roblox.dmg{endBold}，运行刚刚通过网络浏览器下载的 Roblox 安装程序。";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacChromeFourthInstruction"
	/// Click {startBold}Ok{endBold} once you've successfully installed Roblox.
	/// English String: "Click {startBold}Ok{endBold} once you've successfully installed Roblox."
	/// </summary>
	public override string ResponseDialogMacChromeFourthInstruction(string startBold, string endBold)
	{
		return $"成功安装 Roblox 后，点按{startBold}好{endBold}。";
	}

	protected override string _GetTemplateForResponseDialogMacChromeFourthInstruction()
	{
		return "成功安装 Roblox 后，点按{startBold}好{endBold}。";
	}

	protected override string _GetTemplateForResponseDialogMacChromeSecondInstruction()
	{
		return "连按 Roblox App 图标以开始安装程序。";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacChromeThirdInstruction"
	/// Click {startBold}Open{endBold} when prompted by your computer.
	/// English String: "Click {startBold}Open{endBold} when prompted by your computer."
	/// </summary>
	public override string ResponseDialogMacChromeThirdInstruction(string startBold, string endBold)
	{
		return $"按你的电脑提示，点按{startBold}打开{endBold}。";
	}

	protected override string _GetTemplateForResponseDialogMacChromeThirdInstruction()
	{
		return "按你的电脑提示，点按{startBold}打开{endBold}。";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacFirefoxFifthInstruction"
	/// Then select the Remember my choice... checkbox and click OK
	/// English String: "Then select the {startBold}Remember my choice...{endBold} checkbox and click {startBold2}OK{endBold2}"
	/// </summary>
	public override string ResponseDialogMacFirefoxFifthInstruction(string startBold, string endBold, string startBold2, string endBold2)
	{
		return $"然后选中{startBold}记住我的选择...{endBold}复选框，并点按{startBold2}确定{endBold2}";
	}

	protected override string _GetTemplateForResponseDialogMacFirefoxFifthInstruction()
	{
		return "然后选中{startBold}记住我的选择...{endBold}复选框，并点按{startBold2}确定{endBold2}";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacFirefoxFirstInstruction"
	/// Select Open with and click OK
	/// English String: "Select {startBold}Open with{endBold} and click {startBold2}OK{endBold2}"
	/// </summary>
	public override string ResponseDialogMacFirefoxFirstInstruction(string startBold, string endBold, string startBold2, string endBold2)
	{
		return $"选择{startBold}打开方式{endBold}，并点按{startBold2}好{endBold2}";
	}

	protected override string _GetTemplateForResponseDialogMacFirefoxFirstInstruction()
	{
		return "选择{startBold}打开方式{endBold}，并点按{startBold2}好{endBold2}";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacFirefoxFourthInstruction"
	/// Once installed, click Play to join the action!
	/// English String: "Once installed, click {startBold}Play{endBold} to join the action!"
	/// </summary>
	public override string ResponseDialogMacFirefoxFourthInstruction(string startBold, string endBold)
	{
		return $"安装完毕后，点按{startBold}开始游戏{endBold}即可进入 Roblox 的世界！";
	}

	protected override string _GetTemplateForResponseDialogMacFirefoxFourthInstruction()
	{
		return "安装完毕后，点按{startBold}开始游戏{endBold}即可进入 Roblox 的世界！";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacFirefoxSecondInstruction"
	/// Double-click the Roblox Icon to begin the installation process
	/// English String: "Double-click the {startBold}Roblox Icon{endBold} to begin the installation process"
	/// </summary>
	public override string ResponseDialogMacFirefoxSecondInstruction(string startBold, string endBold)
	{
		return $"连按 {startBold}Roblox 图标{endBold}以开始安装程序";
	}

	protected override string _GetTemplateForResponseDialogMacFirefoxSecondInstruction()
	{
		return "连按 {startBold}Roblox 图标{endBold}以开始安装程序";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacFirefoxThirdInstruction"
	/// You will receive a warning, click Open
	/// English String: "You will receive a warning, click {startBold}Open{endBold}"
	/// </summary>
	public override string ResponseDialogMacFirefoxThirdInstruction(string startBold, string endBold)
	{
		return $"你会收到警告，点按{startBold}打开{endBold}";
	}

	protected override string _GetTemplateForResponseDialogMacFirefoxThirdInstruction()
	{
		return "你会收到警告，点按{startBold}打开{endBold}";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacSafariFirstInstruction"
	/// Go to Downloads and double-click Roblox.dmg
	/// English String: "Go to Downloads and double-click {startBold}Roblox.dmg{endBold}"
	/// </summary>
	public override string ResponseDialogMacSafariFirstInstruction(string startBold, string endBold)
	{
		return $"前往“下载”并连按 {startBold}Roblox.dmg{endBold}";
	}

	protected override string _GetTemplateForResponseDialogMacSafariFirstInstruction()
	{
		return "前往“下载”并连按 {startBold}Roblox.dmg{endBold}";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacSafariFourthInstruction"
	/// Once installed, click {startBold}Play{endBold} to join the action!
	/// English String: "Once installed, click {startBold}Play{endBold} to join the action!"
	/// </summary>
	public override string ResponseDialogMacSafariFourthInstruction(string startBold, string endBold)
	{
		return $"安装完毕后，点按{startBold}开始游戏{endBold}即可进入 Roblox 的世界！";
	}

	protected override string _GetTemplateForResponseDialogMacSafariFourthInstruction()
	{
		return "安装完毕后，点按{startBold}开始游戏{endBold}即可进入 Roblox 的世界！";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacSafariSecondInstruction"
	/// Double-click the {startBold}Roblox Icon{endBold} to begin the installation process
	/// English String: "Double-click the {startBold}Roblox Icon{endBold} to begin the installation process"
	/// </summary>
	public override string ResponseDialogMacSafariSecondInstruction(string startBold, string endBold)
	{
		return $"连按 {startBold}Roblox 图标{endBold}以开始安装程序";
	}

	protected override string _GetTemplateForResponseDialogMacSafariSecondInstruction()
	{
		return "连按 {startBold}Roblox 图标{endBold}以开始安装程序";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacSafariThirdInstruction"
	/// You will receive a warning, click {startBold}Open{endBold}
	/// English String: "You will receive a warning, click {startBold}Open{endBold}"
	/// </summary>
	public override string ResponseDialogMacSafariThirdInstruction(string startBold, string endBold)
	{
		return $"你会收到警告，点按{startBold}打开{endBold}";
	}

	protected override string _GetTemplateForResponseDialogMacSafariThirdInstruction()
	{
		return "你会收到警告，点按{startBold}打开{endBold}";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcChromeFirstInstruction"
	/// Click {startBold}RobloxPlayer.exe{endBold} to run the Roblox installer, which just downloaded via your web browser.
	/// English String: "Click {startBold}RobloxPlayer.exe{endBold} to run the Roblox installer, which just downloaded via your web browser."
	/// </summary>
	public override string ResponseDialogPcChromeFirstInstruction(string startBold, string endBold)
	{
		return $"点按 {startBold}RobloxPlayer.exe{endBold}，运行刚刚通过网络浏览器下载的 Roblox 安装程序。";
	}

	protected override string _GetTemplateForResponseDialogPcChromeFirstInstruction()
	{
		return "点按 {startBold}RobloxPlayer.exe{endBold}，运行刚刚通过网络浏览器下载的 Roblox 安装程序。";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcChromeFourthInstruction"
	/// After installation, click {startBold}Play{endBold} below to join the action!
	/// English String: "After installation, click {startBold}Play{endBold} below to join the action!"
	/// </summary>
	public override string ResponseDialogPcChromeFourthInstruction(string startBold, string endBold)
	{
		return $"安装完毕后，点按下面的{startBold}开始游戏{endBold}即可加入游戏！";
	}

	protected override string _GetTemplateForResponseDialogPcChromeFourthInstruction()
	{
		return "安装完毕后，点按下面的{startBold}开始游戏{endBold}即可加入游戏！";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcChromeSecondInstruction"
	/// Click {startBold}Run{endBold} when prompted by your computer to begin the installation process.
	/// English String: "Click {startBold}Run{endBold} when prompted by your computer to begin the installation process."
	/// </summary>
	public override string ResponseDialogPcChromeSecondInstruction(string startBold, string endBold)
	{
		return $"按电脑提示，点按{startBold}运行{endBold}。";
	}

	protected override string _GetTemplateForResponseDialogPcChromeSecondInstruction()
	{
		return "按电脑提示，点按{startBold}运行{endBold}。";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcChromeThirdInstruction"
	/// Click {startBold}Ok{endBold} once you've successfully installed Roblox.
	/// English String: "Click {startBold}Ok{endBold} once you've successfully installed Roblox."
	/// </summary>
	public override string ResponseDialogPcChromeThirdInstruction(string startBold, string endBold)
	{
		return $"成功安装 Roblox 后，点按{startBold}确定{endBold}。";
	}

	protected override string _GetTemplateForResponseDialogPcChromeThirdInstruction()
	{
		return "成功安装 Roblox 后，点按{startBold}确定{endBold}。";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcEdgeFirstInstruction"
	/// Click {startBold}Run{endBold} to install Roblox after the download finishes
	/// English String: "Click {startBold}Run{endBold} to install Roblox after the download finishes"
	/// </summary>
	public override string ResponseDialogPcEdgeFirstInstruction(string startBold, string endBold)
	{
		return $"下载结束后，点按{startBold}运行{endBold}安装 Roblox";
	}

	protected override string _GetTemplateForResponseDialogPcEdgeFirstInstruction()
	{
		return "下载结束后，点按{startBold}运行{endBold}安装 Roblox";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcEdgeSecondInstruction"
	/// Click {startBold}Ok{endBold} to finish installing Roblox
	/// English String: "Click {startBold}Ok{endBold} to finish installing Roblox"
	/// </summary>
	public override string ResponseDialogPcEdgeSecondInstruction(string startBold, string endBold)
	{
		return $"点按{startBold}确定{endBold}以结束安装 Roblox";
	}

	protected override string _GetTemplateForResponseDialogPcEdgeSecondInstruction()
	{
		return "点按{startBold}确定{endBold}以结束安装 Roblox";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcEdgeThirdInstruction"
	/// Click the {startBold}Play{endBold} button to join the action!
	/// English String: "Click the {startBold}Play{endBold} button to join the action!"
	/// </summary>
	public override string ResponseDialogPcEdgeThirdInstruction(string startBold, string endBold)
	{
		return $"点按{startBold}开始游戏{endBold}按钮即可加入游戏！";
	}

	protected override string _GetTemplateForResponseDialogPcEdgeThirdInstruction()
	{
		return "点按{startBold}开始游戏{endBold}按钮即可加入游戏！";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcFirefoxFifthInstruction"
	/// Click {startBold}Ok{endBold} when the alert pops up
	/// English String: "Click {startBold}Ok{endBold} when the alert pops up"
	/// </summary>
	public override string ResponseDialogPcFirefoxFifthInstruction(string startBold, string endBold)
	{
		return $"提醒弹出时，点按{startBold}确定{endBold}";
	}

	protected override string _GetTemplateForResponseDialogPcFirefoxFifthInstruction()
	{
		return "提醒弹出时，点按{startBold}确定{endBold}";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcFirefoxFirstInstruction"
	/// Click {startBold}Save File{endBold} when the download window pops up
	/// English String: "Click {startBold}Save File{endBold} when the download window pops up"
	/// </summary>
	public override string ResponseDialogPcFirefoxFirstInstruction(string startBold, string endBold)
	{
		return $"下载窗口弹出时，点按{startBold}保存文件{endBold}";
	}

	protected override string _GetTemplateForResponseDialogPcFirefoxFirstInstruction()
	{
		return "下载窗口弹出时，点按{startBold}保存文件{endBold}";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcFirefoxFourthInstruction"
	/// Once installed, click {startBold}Play{endBold} to join the action!
	/// English String: "Once installed, click {startBold}Play{endBold} to join the action!"
	/// </summary>
	public override string ResponseDialogPcFirefoxFourthInstruction(string startBold, string endBold)
	{
		return $"安装完毕后，点按{startBold}开始游戏{endBold}即可进入 Roblox 的世界！";
	}

	protected override string _GetTemplateForResponseDialogPcFirefoxFourthInstruction()
	{
		return "安装完毕后，点按{startBold}开始游戏{endBold}即可进入 Roblox 的世界！";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcFirefoxSecondInstruction"
	/// Go to Downloads and double click {startBold}RobloxPlayer.exe{endBold}
	/// English String: "Go to Downloads and double click {startBold}RobloxPlayer.exe{endBold}"
	/// </summary>
	public override string ResponseDialogPcFirefoxSecondInstruction(string startBold, string endBold)
	{
		return $"前往“下载”并连按 {startBold}RobloxPlayer.exe{endBold}";
	}

	protected override string _GetTemplateForResponseDialogPcFirefoxSecondInstruction()
	{
		return "前往“下载”并连按 {startBold}RobloxPlayer.exe{endBold}";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcFirefoxThirdInstruction"
	/// Click {startBold}Run{endBold}
	/// English String: "Click {startBold}Run{endBold}"
	/// </summary>
	public override string ResponseDialogPcFirefoxThirdInstruction(string startBold, string endBold)
	{
		return $"点按{startBold}运行{endBold}";
	}

	protected override string _GetTemplateForResponseDialogPcFirefoxThirdInstruction()
	{
		return "点按{startBold}运行{endBold}";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcIEFirstInstruction"
	/// You will receive a warning, click {startBold}Run{endBold}
	/// English String: "You will receive a warning, click {startBold}Run{endBold}"
	/// </summary>
	public override string ResponseDialogPcIEFirstInstruction(string startBold, string endBold)
	{
		return $"你会收到警告，点按{startBold}运行{endBold}";
	}

	protected override string _GetTemplateForResponseDialogPcIEFirstInstruction()
	{
		return "你会收到警告，点按{startBold}运行{endBold}";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcIeInstructionOne"
	/// You will receive a warning, click {startBold}Run{endBold}
	/// English String: "You will receive a warning, click {startBold}Run{endBold}"
	/// </summary>
	public override string ResponseDialogPcIeInstructionOne(string startBold, string endBold)
	{
		return $"你会收到警告，点按{startBold}运行{endBold}";
	}

	protected override string _GetTemplateForResponseDialogPcIeInstructionOne()
	{
		return "你会收到警告，点按{startBold}运行{endBold}";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcIeInstructionThree"
	/// Click {startBold}Run{endBold}
	/// English String: "Click {startBold}Run{endBold}"
	/// </summary>
	public override string ResponseDialogPcIeInstructionThree(string startBold, string endBold)
	{
		return $"点按{startBold}运行{endBold}";
	}

	protected override string _GetTemplateForResponseDialogPcIeInstructionThree()
	{
		return "点按{startBold}运行{endBold}";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcIeInstructionTwo"
	/// Go to Downloads and double click {startBold}RobloxPlayer.exe{endBold}
	/// English String: "Go to Downloads and double click {startBold}RobloxPlayer.exe{endBold}"
	/// </summary>
	public override string ResponseDialogPcIeInstructionTwo(string startBold, string endBold)
	{
		return $"前往“下载”并连按 {startBold}RobloxPlayer.exe{endBold}";
	}

	protected override string _GetTemplateForResponseDialogPcIeInstructionTwo()
	{
		return "前往“下载”并连按 {startBold}RobloxPlayer.exe{endBold}";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcIESecondInstruction"
	/// Click {startBold}Ok{endBold} once you've installed Roblox
	/// English String: "Click {startBold}Ok{endBold} once you've installed Roblox"
	/// </summary>
	public override string ResponseDialogPcIESecondInstruction(string startBold, string endBold)
	{
		return $"安装 Roblox 后，点按{startBold}确定{endBold}";
	}

	protected override string _GetTemplateForResponseDialogPcIESecondInstruction()
	{
		return "安装 Roblox 后，点按{startBold}确定{endBold}";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcIEThirdInstruction"
	/// Once installed, click {startBold}Play{endBold} to join the action!
	/// English String: "Once installed, click {startBold}Play{endBold} to join the action!"
	/// </summary>
	public override string ResponseDialogPcIEThirdInstruction(string startBold, string endBold)
	{
		return $"安装完毕后，点按{startBold}开始游戏{endBold}即可进入 Roblox 的世界！";
	}

	protected override string _GetTemplateForResponseDialogPcIEThirdInstruction()
	{
		return "安装完毕后，点按{startBold}开始游戏{endBold}即可进入 Roblox 的世界！";
	}

	protected override string _GetTemplateForResponseDialogThanksForPlayingRoblox()
	{
		return "谢谢你玩 Roblox";
	}

	protected override string _GetTemplateForResponseGameTemporarilyUnavailable()
	{
		return "无法验证你是否有权访问此游戏。请稍后重试。";
	}

	/// <summary>
	/// Key: "Response.RememberMyChoiceAppLaunch"
	/// Check {startBold}Remember my choice{endBold} and click {appLaunchLink} in the dialog box above to join games faster in the future!
	/// English String: "Check {startBold}Remember my choice{endBold} and click {appLaunchLink} in the dialog box above to join games faster in the future!"
	/// </summary>
	public override string ResponseRememberMyChoiceAppLaunch(string startBold, string endBold, string appLaunchLink)
	{
		return $"选中{startBold}记住我的选择{endBold}，并点按上方对话框中的{appLaunchLink}，之后就可以更快加入游戏！";
	}

	protected override string _GetTemplateForResponseRememberMyChoiceAppLaunch()
	{
		return "选中{startBold}记住我的选择{endBold}，并点按上方对话框中的{appLaunchLink}，之后就可以更快加入游戏！";
	}
}
