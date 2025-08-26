namespace Roblox.Platform.TranslationResources.Common {
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
	public override string ActionRetry => "é‡è©¦";

	/// <summary>
	/// Key: "Heading.ErrorStartingGame"
	/// Error starting game
	/// English String: "Error starting game"
	/// </summary>
	public override string HeadingErrorStartingGame => "å•Ÿå‹•éŠæˆ²æ™‚ç™¼ç”ŸéŒ¯èª¤ã€‚";

	/// <summary>
	/// Key: "Heading.SwitchToDesktopToPlay"
	/// Switch to Desktop Mode to Play Games
	/// English String: "Switch to Desktop Mode to Play Games"
	/// </summary>
	public override string HeadingSwitchToDesktopToPlay => "è‹¥è¦çŽ©éŠæˆ²ï¼Œè«‹åˆ‡æ›åˆ°æ¡Œé¢æ¨¡å¼";

	/// <summary>
	/// Key: "Label.Cancel"
	/// Cancel
	/// English String: "Cancel"
	/// </summary>
	public override string LabelCancel => "å–æ¶ˆ";

	/// <summary>
	/// Key: "Label.CheckingForStudio"
	/// We are checking if user has Roblox Studio installed
	/// English String: "Checking for Roblox Studio..."
	/// </summary>
	public override string LabelCheckingForStudio => "æ­£åœ¨æª¢æŸ¥ Roblox Studioâ€¦";

	/// <summary>
	/// Key: "Label.ClickHereForHelp"
	/// Click here for help
	/// English String: "Click here for help"
	/// </summary>
	public override string LabelClickHereForHelp => "æŒ‰ä¸‹æ­¤è™•å–å¾—å”åŠ©";

	/// <summary>
	/// Key: "Label.ConnectingToPlayers"
	/// Joining a game network with other players
	/// English String: "Connecting to Players..."
	/// </summary>
	public override string LabelConnectingToPlayers => "æ­£åœ¨å’ŒçŽ©å®¶å»ºç«‹é€£ç·šâ€¦";

	/// <summary>
	/// Key: "Label.DevelopPageTitle"
	/// English String: "Develop"
	/// </summary>
	public override string LabelDevelopPageTitle => "é–‹ç™¼";

	/// <summary>
	/// Key: "Label.DownloadInstallRoblox"
	/// Download and Install Roblox
	/// English String: "Download and Install Roblox"
	/// </summary>
	public override string LabelDownloadInstallRoblox => "ä¸‹è¼‰ä¸¦å®‰è£ Roblox";

	/// <summary>
	/// Key: "Label.DownloadStudio"
	/// Download Roblox Studio to start creating games
	/// English String: "Download Studio"
	/// </summary>
	public override string LabelDownloadStudio => "ä¸‹è¼‰ Studio";

	/// <summary>
	/// Key: "Label.GameConfigurePageTitle"
	/// English String: "Game Configure"
	/// </summary>
	public override string LabelGameConfigurePageTitle => "éŠæˆ²è¨­å®š";

	/// <summary>
	/// Key: "Label.GameFreeSoothsayer"
	/// English String: "Free because you are a soothsayer"
	/// </summary>
	public override string LabelGameFreeSoothsayer => "å› ç‚ºæ‚¨æ˜¯å åœå¸«ï¼Œæ‚¨å¯ä»¥å…è²»éŠçŽ©";

	/// <summary>
	/// Key: "Label.GameUnavailableAccountResrictions"
	/// English String: "The game is unavailable due to account restrictions settings."
	/// </summary>
	public override string LabelGameUnavailableAccountResrictions => "å› å¸³è™Ÿé™åˆ¶è¨­å®šï¼Œç„¡æ³•éŠçŽ©æ­¤éŠæˆ²ã€‚";

	/// <summary>
	/// Key: "Label.GameUnavailableCannotPlayGamesStudio"
	/// English String: "You cannot play games from Studio. Please use a web browser to play this game."
	/// </summary>
	public override string LabelGameUnavailableCannotPlayGamesStudio => "æ‚¨ç„¡æ³•å¾ž Studio é–‹å•ŸéŠæˆ²ï¼Œè«‹ä½¿ç”¨ç¶²é ç€è¦½å™¨é–‹å•Ÿæ­¤éŠæˆ²ã€‚";

	/// <summary>
	/// Key: "Label.GameUnavailableClosedToVisitors"
	/// English String: "Sorry, this place is currently closed to visitors."
	/// </summary>
	public override string LabelGameUnavailableClosedToVisitors => "å°ä¸èµ·ï¼Œæ­¤ç©ºé–“ç›®å‰ä¸å°è¨ªå®¢é–‹æ”¾ã€‚";

	/// <summary>
	/// Key: "Label.GameUnavailableCurrentlyIsPrivateVisitor"
	/// When a game is private, this message is shown to visitors.
	/// English String: "Sorry, this game is private."
	/// </summary>
	public override string LabelGameUnavailableCurrentlyIsPrivateVisitor => "å°ä¸èµ·ï¼Œæ­¤éŠæˆ²è¨­ç‚ºç§äººã€‚";

	/// <summary>
	/// Key: "Label.GameUnavailableGameInsecure"
	/// U13 users cannot play insecure games unless they are the creator or friends with the creator.
	/// English String: "Sorry, your account is restricted from playing Experimental Games unless you are friends with the creator."
	/// </summary>
	public override string LabelGameUnavailableGameInsecure => "å°ä¸èµ·ï¼Œæ‚¨èˆ‡å‰µä½œè€…ä¸æ˜¯å¥½å‹ï¼Œä¸èƒ½çŽ©å¯¦é©—éŠæˆ²ã€‚";

	/// <summary>
	/// Key: "Label.GameUnavailablePermissionLevels"
	/// English String: "The permission levels on this place prevent you from entering."
	/// </summary>
	public override string LabelGameUnavailablePermissionLevels => "æ‚¨çš„æ¬Šé™ä¸è¶³ï¼Œç„¡æ³•é€²å…¥æ­¤ç©ºé–“ã€‚";

	/// <summary>
	/// Key: "Label.GameUnavailablePlaceUnderReview"
	/// English String: "Sorry, this place is currently under review. Try again later."
	/// </summary>
	public override string LabelGameUnavailablePlaceUnderReview => "å°ä¸èµ·ï¼Œæ­¤ç©ºé–“æ­£åœ¨ç¶“éŽå¯©æ ¸ï¼Œè«‹ç¨å¾Œå†è©¦ã€‚";

	/// <summary>
	/// Key: "Label.GameUnavailablePlatform"
	/// English String: "This game is not available on your platform.  Check the games page to see all playable games."
	/// </summary>
	public override string LabelGameUnavailablePlatform => "æ­¤éŠæˆ²ç„¡æ³•åœ¨æ‚¨çš„å¹³å°ä¸Šé‹ä½œï¼Œè«‹æŸ¥çœ‹éŠæˆ²é é¢æª¢è¦–æ‰€æœ‰å¯ä»¥çŽ©çš„éŠæˆ²ã€‚";

	/// <summary>
	/// Key: "Label.GameWarning"
	/// English String: "Warning"
	/// </summary>
	public override string LabelGameWarning => "è­¦å‘Š";

	/// <summary>
	/// Key: "Label.InstallationInstructions"
	/// Installation Instructions
	/// English String: "Installation Instructions"
	/// </summary>
	public override string LabelInstallationInstructions => "å®‰è£èªªæ˜Ž";

	/// <summary>
	/// Key: "Label.LaunchApplication"
	/// Launch Application
	/// English String: "Launch Application"
	/// </summary>
	public override string LabelLaunchApplication => "å•Ÿå‹•æ‡‰ç”¨ç¨‹å¼";

	/// <summary>
	/// Key: "Label.PersuadeToDevelopRoblox"
	/// Persuade user to begin developing their own games using Roblox Studio
	/// English String: "Get started creating your own games!"
	/// </summary>
	public override string LabelPersuadeToDevelopRoblox => "é–‹å§‹å‰µä½œå±¬æ–¼æ‚¨è‡ªå·±çš„éŠæˆ²ï¼";

	/// <summary>
	/// Key: "Label.PersuadeToInstallRoblox"
	/// We are exciting the user about Roblox so that they will be persuaded to download and install it.
	/// English String: "You're moments away from getting into the game!"
	/// </summary>
	public override string LabelPersuadeToInstallRoblox => "æ‚¨å³å°‡é€²å…¥éŠæˆ²ï¼";

	/// <summary>
	/// Key: "Label.Play"
	/// English String: "Play"
	/// </summary>
	public override string LabelPlay => "é–‹å§‹éŠæˆ²";

	/// <summary>
	/// Key: "Label.PlayInApp"
	/// English String: "Play in App"
	/// </summary>
	public override string LabelPlayInApp => "åœ¨ App éŠçŽ©";

	/// <summary>
	/// Key: "Label.RobloxLoadingToPlay"
	/// Roblox is loading, so the user is getting excited to start playing a game
	/// English String: "Roblox is now loading. Get ready to play!"
	/// </summary>
	public override string LabelRobloxLoadingToPlay => "æ­£åœ¨è¼‰å…¥ Robloxï¼Œæº–å‚™å¥½äº†å—Žï¼Ÿ";

	/// <summary>
	/// Key: "Label.StartingRoblox"
	/// Game launch process has started
	/// English String: "Starting Roblox..."
	/// </summary>
	public override string LabelStartingRoblox => "æ­£åœ¨å•Ÿå‹• Robloxâ€¦";

	/// <summary>
	/// Key: "Label.SwitchToDesktopMode"
	/// Switch to Desktop Mode
	/// English String: "Switch to Desktop Mode"
	/// </summary>
	public override string LabelSwitchToDesktopMode => "åˆ‡æ›åˆ°æ¡Œé¢æ¨¡å¼";

	/// <summary>
	/// Key: "Label.UniverseConfigurePageTitle"
	/// The name of the universe configuration page
	/// English String: "Universe Configuration"
	/// </summary>
	public override string LabelUniverseConfigurePageTitle => "ä¸–ç•Œè¨­å®š";

	/// <summary>
	/// Key: "Response.Dialog.ClickHere"
	/// Click here!
	/// English String: "Click here!"
	/// </summary>
	public override string ResponseDialogClickHere => "æŒ‰ä¸‹æ­¤è™•ï¼";

	/// <summary>
	/// Key: "Response.Dialog.ErrorLaunching"
	/// An error occurred trying to launch the game.  Please try again later.
	/// English String: "An error occurred trying to launch the game.  Please try again later."
	/// </summary>
	public override string ResponseDialogErrorLaunching => "å•Ÿå‹•éŠæˆ²æ™‚ç™¼ç”ŸéŒ¯èª¤ï¼Œè«‹ç¨å¾Œå†è©¦ã€‚";

	/// <summary>
	/// Key: "Response.Dialog.HavingTroubleInstallQuestion"
	/// (Are you) having trouble installing Roblox?
	/// English String: "Having trouble installing Roblox?"
	/// </summary>
	public override string ResponseDialogHavingTroubleInstallQuestion => "å®‰è£ Roblox é‡åˆ°å•é¡Œï¼Ÿ";

	/// <summary>
	/// Key: "Response.Dialog.MacChromeSecondInstruction"
	/// Double-click the Roblox app icon to begin the installation process.
	/// English String: "Double-click the Roblox app icon to begin the installation process."
	/// </summary>
	public override string ResponseDialogMacChromeSecondInstruction => "æŒ‰å…©ä¸‹ Roblox App åœ–ç¤ºé–‹å§‹å®‰è£ç¨‹åºã€‚";

	/// <summary>
	/// Key: "Response.Dialog.ThanksForPlayingRoblox"
	/// Thanks for playing Roblox
	/// English String: "Thanks for playing Roblox"
	/// </summary>
	public override string ResponseDialogThanksForPlayingRoblox => "è¬è¬æ‚¨çŽ© Roblox";

	/// <summary>
	/// Key: "Response.GameTemporarilyUnavailable"
	/// error message (will be followed by link with Action.Retry label)
	/// English String: "Unable to verify that you have access to this game.  Please try again later."
	/// </summary>
	public override string ResponseGameTemporarilyUnavailable => "ç„¡æ³•é©—è­‰æ‚¨çš„éŠæˆ²é€šè¡Œæ¬Šï¼Œè«‹ç¨å¾Œå†è©¦ã€‚";

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
		return $"{warning} æ­¤éŠæˆ²å¯èƒ½ç„¡æ³•åœ¨æ‚¨çš„è£ç½®ä¸Šé †æš¢é‹ä½œã€‚";
	}

	protected override string _GetTemplateForActionGamePerformPoorly()
	{
		return "{warning} æ­¤éŠæˆ²å¯èƒ½ç„¡æ³•åœ¨æ‚¨çš„è£ç½®ä¸Šé †æš¢é‹ä½œã€‚";
	}

	protected override string _GetTemplateForActionRetry()
	{
		return "é‡è©¦";
	}

	protected override string _GetTemplateForHeadingErrorStartingGame()
	{
		return "å•Ÿå‹•éŠæˆ²æ™‚ç™¼ç”ŸéŒ¯èª¤ã€‚";
	}

	protected override string _GetTemplateForHeadingSwitchToDesktopToPlay()
	{
		return "è‹¥è¦çŽ©éŠæˆ²ï¼Œè«‹åˆ‡æ›åˆ°æ¡Œé¢æ¨¡å¼";
	}

	/// <summary>
	/// Key: "Label.BuyAccess"
	/// English String: "Buy Access for {robux} Robux"
	/// </summary>
	public override string LabelBuyAccess(string robux)
	{
		return $"ä»¥ {robux} Robux è³¼è²·é€šè¡Œæ¬Š";
	}

	protected override string _GetTemplateForLabelBuyAccess()
	{
		return "ä»¥ {robux} Robux è³¼è²·é€šè¡Œæ¬Š";
	}

	protected override string _GetTemplateForLabelCancel()
	{
		return "å–æ¶ˆ";
	}

	protected override string _GetTemplateForLabelCheckingForStudio()
	{
		return "æ­£åœ¨æª¢æŸ¥ Roblox Studioâ€¦";
	}

	protected override string _GetTemplateForLabelClickHereForHelp()
	{
		return "æŒ‰ä¸‹æ­¤è™•å–å¾—å”åŠ©";
	}

	protected override string _GetTemplateForLabelConnectingToPlayers()
	{
		return "æ­£åœ¨å’ŒçŽ©å®¶å»ºç«‹é€£ç·šâ€¦";
	}

	protected override string _GetTemplateForLabelDevelopPageTitle()
	{
		return "é–‹ç™¼";
	}

	protected override string _GetTemplateForLabelDownloadInstallRoblox()
	{
		return "ä¸‹è¼‰ä¸¦å®‰è£ Roblox";
	}

	protected override string _GetTemplateForLabelDownloadStudio()
	{
		return "ä¸‹è¼‰ Studio";
	}

	protected override string _GetTemplateForLabelGameConfigurePageTitle()
	{
		return "éŠæˆ²è¨­å®š";
	}

	protected override string _GetTemplateForLabelGameFreeSoothsayer()
	{
		return "å› ç‚ºæ‚¨æ˜¯å åœå¸«ï¼Œæ‚¨å¯ä»¥å…è²»éŠçŽ©";
	}

	/// <summary>
	/// Key: "Label.GameIsPrivatePlayableByGroupOnly"
	/// When a game is private, this message is shown to group developers with a link from where it can be made public.
	/// English String: "Only developers can play because this game is private. Make it public on the {linkStart}Configure Game{linkEnd} page."
	/// </summary>
	public override string LabelGameIsPrivatePlayableByGroupOnly(string linkStart, string linkEnd)
	{
		return $"æ­¤éŠæˆ²è¨­ç‚ºç§äººï¼Œåªæœ‰é–‹ç™¼äººå“¡å¯ä»¥çŽ©ã€‚è«‹åœ¨{linkStart}éŠæˆ²è¨­å®š{linkEnd}é é¢è¨­ç‚ºå…¬é–‹ã€‚";
	}

	protected override string _GetTemplateForLabelGameIsPrivatePlayableByGroupOnly()
	{
		return "æ­¤éŠæˆ²è¨­ç‚ºç§äººï¼Œåªæœ‰é–‹ç™¼äººå“¡å¯ä»¥çŽ©ã€‚è«‹åœ¨{linkStart}éŠæˆ²è¨­å®š{linkEnd}é é¢è¨­ç‚ºå…¬é–‹ã€‚";
	}

	/// <summary>
	/// Key: "Label.GameIsPrivatePlayableByOwnerOnly"
	/// When a game is private, this message is shown to owner with a link from where it can be made public.
	/// English String: "Only you can play because this game is private. Make it public on the {linkStart}Configure Game{linkEnd} page."
	/// </summary>
	public override string LabelGameIsPrivatePlayableByOwnerOnly(string linkStart, string linkEnd)
	{
		return $"æ­¤éŠæˆ²è¨­ç‚ºç§äººï¼Œåªæœ‰æ‚¨å¯ä»¥çŽ©ã€‚è«‹åœ¨{linkStart}éŠæˆ²è¨­å®š{linkEnd}é é¢è¨­ç‚ºå…¬é–‹ã€‚";
	}

	protected override string _GetTemplateForLabelGameIsPrivatePlayableByOwnerOnly()
	{
		return "æ­¤éŠæˆ²è¨­ç‚ºç§äººï¼Œåªæœ‰æ‚¨å¯ä»¥çŽ©ã€‚è«‹åœ¨{linkStart}éŠæˆ²è¨­å®š{linkEnd}é é¢è¨­ç‚ºå…¬é–‹ã€‚";
	}

	protected override string _GetTemplateForLabelGameUnavailableAccountResrictions()
	{
		return "å› å¸³è™Ÿé™åˆ¶è¨­å®šï¼Œç„¡æ³•éŠçŽ©æ­¤éŠæˆ²ã€‚";
	}

	protected override string _GetTemplateForLabelGameUnavailableCannotPlayGamesStudio()
	{
		return "æ‚¨ç„¡æ³•å¾ž Studio é–‹å•ŸéŠæˆ²ï¼Œè«‹ä½¿ç”¨ç¶²é ç€è¦½å™¨é–‹å•Ÿæ­¤éŠæˆ²ã€‚";
	}

	protected override string _GetTemplateForLabelGameUnavailableClosedToVisitors()
	{
		return "å°ä¸èµ·ï¼Œæ­¤ç©ºé–“ç›®å‰ä¸å°è¨ªå®¢é–‹æ”¾ã€‚";
	}

	/// <summary>
	/// Key: "Label.GameUnavailableCurrentlyIsPrivateGroup"
	/// When a game is private, this message is shown to group developers with a link from where it can be made public. Similar to an existing translation. Change is making the message directly address the group developers.
	/// English String: "Only developers can play because this game is private. Make it public on the {linkStart}Develop{linkEnd} page."
	/// </summary>
	public override string LabelGameUnavailableCurrentlyIsPrivateGroup(string linkStart, string linkEnd)
	{
		return $"æ­¤éŠæˆ²è¨­ç‚ºç§äººï¼Œåªæœ‰é–‹ç™¼äººå“¡å¯ä»¥çŽ©ã€‚è«‹åœ¨{linkEnd}é–‹ç™¼{linkStart}é é¢å°‡æ­¤éŠæˆ²è¨­ç‚ºå…¬é–‹ã€‚";
	}

	protected override string _GetTemplateForLabelGameUnavailableCurrentlyIsPrivateGroup()
	{
		return "æ­¤éŠæˆ²è¨­ç‚ºç§äººï¼Œåªæœ‰é–‹ç™¼äººå“¡å¯ä»¥çŽ©ã€‚è«‹åœ¨{linkEnd}é–‹ç™¼{linkStart}é é¢å°‡æ­¤éŠæˆ²è¨­ç‚ºå…¬é–‹ã€‚";
	}

	/// <summary>
	/// Key: "Label.GameUnavailableCurrentlyIsPrivateOwner"
	/// When a game is private, this message is shown to owner with a link from where it can be made public. Similar to an existing translation. Change is making the message directly address the owner.
	/// English String: "Only you can play because this game is private. Make it public on the {linkStart}Develop{linkEnd} page."
	/// </summary>
	public override string LabelGameUnavailableCurrentlyIsPrivateOwner(string linkStart, string linkEnd)
	{
		return $"æ­¤éŠæˆ²è¨­ç‚ºç§äººï¼Œåªæœ‰æ‚¨å¯ä»¥çŽ©ã€‚è«‹åœ¨{linkEnd}é–‹ç™¼{linkStart}é é¢è¨­ç‚ºå…¬é–‹ã€‚";
	}

	protected override string _GetTemplateForLabelGameUnavailableCurrentlyIsPrivateOwner()
	{
		return "æ­¤éŠæˆ²è¨­ç‚ºç§äººï¼Œåªæœ‰æ‚¨å¯ä»¥çŽ©ã€‚è«‹åœ¨{linkEnd}é–‹ç™¼{linkStart}é é¢è¨­ç‚ºå…¬é–‹ã€‚";
	}

	protected override string _GetTemplateForLabelGameUnavailableCurrentlyIsPrivateVisitor()
	{
		return "å°ä¸èµ·ï¼Œæ­¤éŠæˆ²è¨­ç‚ºç§äººã€‚";
	}

	/// <summary>
	/// Key: "Label.GameUnavailableCurrentlyPrivate"
	/// When a game is private, this message is shown to user with link from where it can be made public
	/// English String: "This {gameTypeName} is currently private. Make it public on the {developPageLink} page to make it playable."
	/// </summary>
	public override string LabelGameUnavailableCurrentlyPrivate(string gameTypeName, string developPageLink)
	{
		return $"æ­¤{gameTypeName}ç›®å‰è¨­ç‚ºç§äººã€‚è«‹åœ¨{developPageLink}é é¢è¨­ç‚ºå…¬é–‹ï¼Œè®“å…¶ä»–äººå¯ä»¥çŽ©ã€‚";
	}

	protected override string _GetTemplateForLabelGameUnavailableCurrentlyPrivate()
	{
		return "æ­¤{gameTypeName}ç›®å‰è¨­ç‚ºç§äººã€‚è«‹åœ¨{developPageLink}é é¢è¨­ç‚ºå…¬é–‹ï¼Œè®“å…¶ä»–äººå¯ä»¥çŽ©ã€‚";
	}

	protected override string _GetTemplateForLabelGameUnavailableGameInsecure()
	{
		return "å°ä¸èµ·ï¼Œæ‚¨èˆ‡å‰µä½œè€…ä¸æ˜¯å¥½å‹ï¼Œä¸èƒ½çŽ©å¯¦é©—éŠæˆ²ã€‚";
	}

	/// <summary>
	/// Key: "Label.GameUnavailableNoRootPlace"
	/// English String: "This place is part of a game that has no root place. Add a root place on the {gameConfigureLink} page to make it playable."
	/// </summary>
	public override string LabelGameUnavailableNoRootPlace(string gameConfigureLink)
	{
		return $"æ­¤ç©ºé–“æ‰€å±¬çš„éŠæˆ²æ²’æœ‰æ¯ç©ºé–“ã€‚è«‹åœ¨{gameConfigureLink}é é¢æ–°å¢žæ¯ç©ºé–“ï¼Œè®“å®ƒæˆç‚ºå¯éŠçŽ©ç‹€æ…‹ã€‚";
	}

	protected override string _GetTemplateForLabelGameUnavailableNoRootPlace()
	{
		return "æ­¤ç©ºé–“æ‰€å±¬çš„éŠæˆ²æ²’æœ‰æ¯ç©ºé–“ã€‚è«‹åœ¨{gameConfigureLink}é é¢æ–°å¢žæ¯ç©ºé–“ï¼Œè®“å®ƒæˆç‚ºå¯éŠçŽ©ç‹€æ…‹ã€‚";
	}

	protected override string _GetTemplateForLabelGameUnavailablePermissionLevels()
	{
		return "æ‚¨çš„æ¬Šé™ä¸è¶³ï¼Œç„¡æ³•é€²å…¥æ­¤ç©ºé–“ã€‚";
	}

	/// <summary>
	/// Key: "Label.GameUnavailablePlaceNotPartOfGame"
	/// English String: "This place is not currently part of a Game. Add it to a game on the {developPageLink} page to make it playable."
	/// </summary>
	public override string LabelGameUnavailablePlaceNotPartOfGame(string developPageLink)
	{
		return $"æ­¤ç©ºé–“ç›®å‰ä¸å±¬æ–¼ä»»ä½•éŠæˆ²ã€‚è«‹åœ¨{developPageLink}é é¢å°‡å®ƒåŠ åˆ°éŠæˆ²ä¸­ï¼Œè®“å®ƒæˆç‚ºå¯éŠçŽ©ç‹€æ…‹ã€‚";
	}

	protected override string _GetTemplateForLabelGameUnavailablePlaceNotPartOfGame()
	{
		return "æ­¤ç©ºé–“ç›®å‰ä¸å±¬æ–¼ä»»ä½•éŠæˆ²ã€‚è«‹åœ¨{developPageLink}é é¢å°‡å®ƒåŠ åˆ°éŠæˆ²ä¸­ï¼Œè®“å®ƒæˆç‚ºå¯éŠçŽ©ç‹€æ…‹ã€‚";
	}

	protected override string _GetTemplateForLabelGameUnavailablePlaceUnderReview()
	{
		return "å°ä¸èµ·ï¼Œæ­¤ç©ºé–“æ­£åœ¨ç¶“éŽå¯©æ ¸ï¼Œè«‹ç¨å¾Œå†è©¦ã€‚";
	}

	protected override string _GetTemplateForLabelGameUnavailablePlatform()
	{
		return "æ­¤éŠæˆ²ç„¡æ³•åœ¨æ‚¨çš„å¹³å°ä¸Šé‹ä½œï¼Œè«‹æŸ¥çœ‹éŠæˆ²é é¢æª¢è¦–æ‰€æœ‰å¯ä»¥çŽ©çš„éŠæˆ²ã€‚";
	}

	protected override string _GetTemplateForLabelGameWarning()
	{
		return "è­¦å‘Š";
	}

	protected override string _GetTemplateForLabelInstallationInstructions()
	{
		return "å®‰è£èªªæ˜Ž";
	}

	protected override string _GetTemplateForLabelLaunchApplication()
	{
		return "å•Ÿå‹•æ‡‰ç”¨ç¨‹å¼";
	}

	/// <summary>
	/// Key: "Label.OperaInstallSteps"
	/// 1) A window will open. Click Open2) Doubleclick the Roblox icon.
	/// English String: "1) A window will open. Click {startBold}Open{endBold}.{breakLine}2) Doubleclick the Roblox icon."
	/// </summary>
	public override string LabelOperaInstallSteps(string startBold, string endBold, string breakLine)
	{
		return $"1) è¦–çª—å°‡æœƒé–‹å•Ÿï¼ŒæŒ‰ä¸‹{startBold}é–‹å•Ÿ{endBold}ã€‚{breakLine}2) æŒ‰å…©ä¸‹ Roblox åœ–ç¤ºã€‚";
	}

	protected override string _GetTemplateForLabelOperaInstallSteps()
	{
		return "1) è¦–çª—å°‡æœƒé–‹å•Ÿï¼ŒæŒ‰ä¸‹{startBold}é–‹å•Ÿ{endBold}ã€‚{breakLine}2) æŒ‰å…©ä¸‹ Roblox åœ–ç¤ºã€‚";
	}

	protected override string _GetTemplateForLabelPersuadeToDevelopRoblox()
	{
		return "é–‹å§‹å‰µä½œå±¬æ–¼æ‚¨è‡ªå·±çš„éŠæˆ²ï¼";
	}

	protected override string _GetTemplateForLabelPersuadeToInstallRoblox()
	{
		return "æ‚¨å³å°‡é€²å…¥éŠæˆ²ï¼";
	}

	protected override string _GetTemplateForLabelPlay()
	{
		return "é–‹å§‹éŠæˆ²";
	}

	protected override string _GetTemplateForLabelPlayInApp()
	{
		return "åœ¨ App éŠçŽ©";
	}

	protected override string _GetTemplateForLabelRobloxLoadingToPlay()
	{
		return "æ­£åœ¨è¼‰å…¥ Robloxï¼Œæº–å‚™å¥½äº†å—Žï¼Ÿ";
	}

	protected override string _GetTemplateForLabelStartingRoblox()
	{
		return "æ­£åœ¨å•Ÿå‹• Robloxâ€¦";
	}

	protected override string _GetTemplateForLabelSwitchToDesktopMode()
	{
		return "åˆ‡æ›åˆ°æ¡Œé¢æ¨¡å¼";
	}

	protected override string _GetTemplateForLabelUniverseConfigurePageTitle()
	{
		return "ä¸–ç•Œè¨­å®š";
	}

	/// <summary>
	/// Key: "Response.CheckAlwaysOpenRoblox"
	/// Check {startBold}Always open links for Roblox{endBold} and click {startBold2}Open Roblox{endBold2} in the dialog box above to join games faster in the future!
	/// English String: "Check {startBold}Always open links for Roblox{endBold} and click {startBold2}Open Roblox{endBold2} in the dialog box above to join games faster in the future!"
	/// </summary>
	public override string ResponseCheckAlwaysOpenRoblox(string startBold, string endBold, string startBold2, string endBold2)
	{
		return $"å‹¾é¸{startBold}æ°¸é é–‹å•Ÿ Roblox çš„é€£çµ{endBold}ï¼Œä¸¦åœ¨ä¸Šæ–¹çš„å°è©±æ¡†æŒ‰ä¸‹{startBold2}é–‹å•Ÿ Roblox{endBold2}ï¼Œå°±å¯ä»¥æ›´å¿«åŠ å…¥éŠæˆ²ï¼";
	}

	protected override string _GetTemplateForResponseCheckAlwaysOpenRoblox()
	{
		return "å‹¾é¸{startBold}æ°¸é é–‹å•Ÿ Roblox çš„é€£çµ{endBold}ï¼Œä¸¦åœ¨ä¸Šæ–¹çš„å°è©±æ¡†æŒ‰ä¸‹{startBold2}é–‹å•Ÿ Roblox{endBold2}ï¼Œå°±å¯ä»¥æ›´å¿«åŠ å…¥éŠæˆ²ï¼";
	}

	/// <summary>
	/// Key: "Response.CheckAlwaysOpenRobloxURL"
	/// Check {startBold}Always open links for URL: Roblox Protocol{endBold} and click {startBold}Open URL: Roblox Protocol{endBold} in the dialog box above to join games faster in the future!
	/// English String: "Check {startBold}Always open links for URL: Roblox Protocol{endBold} and click {startBold2}Open URL: Roblox Protocol{endBold2} in the dialog box above to join games faster in the future!"
	/// </summary>
	public override string ResponseCheckAlwaysOpenRobloxURL(string startBold, string endBold, string startBold2, string endBold2)
	{
		return $"å‹¾é¸{startBold}æ°¸é é–‹å•Ÿä»¥ä¸‹ç¶²å€é€£çµï¼šRoblox å”å®š{endBold}ï¼Œä¸¦åœ¨ä¸Šæ–¹çš„å°è©±æ¡†æŒ‰ä¸‹{startBold2}é–‹å•Ÿä»¥ä¸‹ç¶²å€ï¼šRoblox å”å®š{endBold2}ï¼Œå°±å¯ä»¥æ›´å¿«åŠ å…¥éŠæˆ²ï¼";
	}

	protected override string _GetTemplateForResponseCheckAlwaysOpenRobloxURL()
	{
		return "å‹¾é¸{startBold}æ°¸é é–‹å•Ÿä»¥ä¸‹ç¶²å€é€£çµï¼šRoblox å”å®š{endBold}ï¼Œä¸¦åœ¨ä¸Šæ–¹çš„å°è©±æ¡†æŒ‰ä¸‹{startBold2}é–‹å•Ÿä»¥ä¸‹ç¶²å€ï¼šRoblox å”å®š{endBold2}ï¼Œå°±å¯ä»¥æ›´å¿«åŠ å…¥éŠæˆ²ï¼";
	}

	/// <summary>
	/// Key: "Response.CheckRememberMyChoiceOK"
	/// Check Remember my choice and click OK in the dialog box above to join games faster in the future!
	/// English String: "Check {startBold}Remember my choice{endBold} and click {startBold2}OK{endBold2} in the dialog box above to join games faster in the future!"
	/// </summary>
	public override string ResponseCheckRememberMyChoiceOK(string startBold, string endBold, string startBold2, string endBold2)
	{
		return $"å‹¾é¸{startBold}è¨˜ä½æˆ‘çš„é¸æ“‡{endBold}ï¼Œä¸¦åœ¨ä¸Šæ–¹çš„å°è©±æ¡†æŒ‰ä¸‹{startBold2}ç¢ºå®š{endBold2}ï¼Œå°±å¯ä»¥æ›´å¿«åŠ å…¥éŠæˆ²ï¼";
	}

	protected override string _GetTemplateForResponseCheckRememberMyChoiceOK()
	{
		return "å‹¾é¸{startBold}è¨˜ä½æˆ‘çš„é¸æ“‡{endBold}ï¼Œä¸¦åœ¨ä¸Šæ–¹çš„å°è©±æ¡†æŒ‰ä¸‹{startBold2}ç¢ºå®š{endBold2}ï¼Œå°±å¯ä»¥æ›´å¿«åŠ å…¥éŠæˆ²ï¼";
	}

	protected override string _GetTemplateForResponseDialogClickHere()
	{
		return "æŒ‰ä¸‹æ­¤è™•ï¼";
	}

	protected override string _GetTemplateForResponseDialogErrorLaunching()
	{
		return "å•Ÿå‹•éŠæˆ²æ™‚ç™¼ç”ŸéŒ¯èª¤ï¼Œè«‹ç¨å¾Œå†è©¦ã€‚";
	}

	protected override string _GetTemplateForResponseDialogHavingTroubleInstallQuestion()
	{
		return "å®‰è£ Roblox é‡åˆ°å•é¡Œï¼Ÿ";
	}

	/// <summary>
	/// Key: "Response.Dialog.InstallingMessageWithLink"
	/// Note: For this translation, please move the linkStart and linkEnd variables with the translation for download now.
	/// English String: "The Roblox installer should download shortly. If it doesnâ€™t, start the {linkStart}download now.{linkEnd}"
	/// </summary>
	public override string ResponseDialogInstallingMessageWithLink(string linkStart, string linkEnd)
	{
		return $"Roblox å®‰è£ç¨‹å¼å°‡æœƒé–‹å§‹ä¸‹è¼‰ã€‚è‹¥ä¸‹è¼‰æ²’æœ‰é–‹å§‹ï¼Œè«‹æ‰‹å‹•{linkStart}é–‹å§‹ä¸‹è¼‰ã€‚{linkEnd}";
	}

	protected override string _GetTemplateForResponseDialogInstallingMessageWithLink()
	{
		return "Roblox å®‰è£ç¨‹å¼å°‡æœƒé–‹å§‹ä¸‹è¼‰ã€‚è‹¥ä¸‹è¼‰æ²’æœ‰é–‹å§‹ï¼Œè«‹æ‰‹å‹•{linkStart}é–‹å§‹ä¸‹è¼‰ã€‚{linkEnd}";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacChromeFifthInstruction"
	/// After installation, click {startBold}Play{endBold} below to join the action!
	/// English String: "After installation, click {startBold}Play{endBold} below to join the action!"
	/// </summary>
	public override string ResponseDialogMacChromeFifthInstruction(string startBold, string endBold)
	{
		return $"å®‰è£å¾Œï¼ŒæŒ‰ä¸‹ä¸‹æ–¹çš„{startBold}é–‹å§‹éŠæˆ²{endBold}å°±å¯ä»¥é–‹å§‹çŽ©ï¼";
	}

	protected override string _GetTemplateForResponseDialogMacChromeFifthInstruction()
	{
		return "å®‰è£å¾Œï¼ŒæŒ‰ä¸‹ä¸‹æ–¹çš„{startBold}é–‹å§‹éŠæˆ²{endBold}å°±å¯ä»¥é–‹å§‹çŽ©ï¼";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacChromeFirstInstruction"
	/// Click {startBold}Roblox.dmg{endBold} to run the Roblox installer, which just downloaded via your web browser.
	/// English String: "Click {startBold}Roblox.dmg{endBold} to run the Roblox installer, which just downloaded via your web browser."
	/// </summary>
	public override string ResponseDialogMacChromeFirstInstruction(string startBold, string endBold)
	{
		return $"æŒ‰ä¸‹ {startBold}Roblox.dmg{endBold} åŸ·è¡Œå‰›æ‰ä¸‹è¼‰çš„ Roblox å®‰è£ç¨‹å¼ã€‚";
	}

	protected override string _GetTemplateForResponseDialogMacChromeFirstInstruction()
	{
		return "æŒ‰ä¸‹ {startBold}Roblox.dmg{endBold} åŸ·è¡Œå‰›æ‰ä¸‹è¼‰çš„ Roblox å®‰è£ç¨‹å¼ã€‚";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacChromeFourthInstruction"
	/// Click {startBold}Ok{endBold} once you've successfully installed Roblox.
	/// English String: "Click {startBold}Ok{endBold} once you've successfully installed Roblox."
	/// </summary>
	public override string ResponseDialogMacChromeFourthInstruction(string startBold, string endBold)
	{
		return $"æ‚¨æˆåŠŸå®‰è£ Roblox å¾Œï¼ŒæŒ‰ä¸‹{startBold}ç¢ºå®š{endBold}ã€‚";
	}

	protected override string _GetTemplateForResponseDialogMacChromeFourthInstruction()
	{
		return "æ‚¨æˆåŠŸå®‰è£ Roblox å¾Œï¼ŒæŒ‰ä¸‹{startBold}ç¢ºå®š{endBold}ã€‚";
	}

	protected override string _GetTemplateForResponseDialogMacChromeSecondInstruction()
	{
		return "æŒ‰å…©ä¸‹ Roblox App åœ–ç¤ºé–‹å§‹å®‰è£ç¨‹åºã€‚";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacChromeThirdInstruction"
	/// Click {startBold}Open{endBold} when prompted by your computer.
	/// English String: "Click {startBold}Open{endBold} when prompted by your computer."
	/// </summary>
	public override string ResponseDialogMacChromeThirdInstruction(string startBold, string endBold)
	{
		return $"ä¾æ‚¨çš„é›»è…¦æç¤ºï¼ŒæŒ‰ä¸‹{startBold}é–‹å•Ÿ{endBold}ã€‚";
	}

	protected override string _GetTemplateForResponseDialogMacChromeThirdInstruction()
	{
		return "ä¾æ‚¨çš„é›»è…¦æç¤ºï¼ŒæŒ‰ä¸‹{startBold}é–‹å•Ÿ{endBold}ã€‚";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacFirefoxFifthInstruction"
	/// Then select the Remember my choice... checkbox and click OK
	/// English String: "Then select the {startBold}Remember my choice...{endBold} checkbox and click {startBold2}OK{endBold2}"
	/// </summary>
	public override string ResponseDialogMacFirefoxFifthInstruction(string startBold, string endBold, string startBold2, string endBold2)
	{
		return $"æŽ¥è‘—é¸æ“‡{startBold}è¨˜ä½æˆ‘çš„é¸æ“‡â€¦{endBold} é¸é …ï¼Œä¸¦æŒ‰ä¸‹{startBold2}ç¢ºå®š{endBold2}";
	}

	protected override string _GetTemplateForResponseDialogMacFirefoxFifthInstruction()
	{
		return "æŽ¥è‘—é¸æ“‡{startBold}è¨˜ä½æˆ‘çš„é¸æ“‡â€¦{endBold} é¸é …ï¼Œä¸¦æŒ‰ä¸‹{startBold2}ç¢ºå®š{endBold2}";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacFirefoxFirstInstruction"
	/// Select Open with and click OK
	/// English String: "Select {startBold}Open with{endBold} and click {startBold2}OK{endBold2}"
	/// </summary>
	public override string ResponseDialogMacFirefoxFirstInstruction(string startBold, string endBold, string startBold2, string endBold2)
	{
		return $"é¸æ“‡{startBold}é–‹å•Ÿæ™‚ä½¿ç”¨{endBold}ä¸¦æŒ‰ä¸‹{startBold2}ç¢ºå®š{endBold2}";
	}

	protected override string _GetTemplateForResponseDialogMacFirefoxFirstInstruction()
	{
		return "é¸æ“‡{startBold}é–‹å•Ÿæ™‚ä½¿ç”¨{endBold}ä¸¦æŒ‰ä¸‹{startBold2}ç¢ºå®š{endBold2}";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacFirefoxFourthInstruction"
	/// Once installed, click Play to join the action!
	/// English String: "Once installed, click {startBold}Play{endBold} to join the action!"
	/// </summary>
	public override string ResponseDialogMacFirefoxFourthInstruction(string startBold, string endBold)
	{
		return $"å®‰è£å®Œç•¢å¾Œï¼ŒæŒ‰ä¸‹{startBold}é–‹å§‹éŠæˆ²{endBold}é€²å…¥ Roblox çš„ä¸–ç•Œï¼";
	}

	protected override string _GetTemplateForResponseDialogMacFirefoxFourthInstruction()
	{
		return "å®‰è£å®Œç•¢å¾Œï¼ŒæŒ‰ä¸‹{startBold}é–‹å§‹éŠæˆ²{endBold}é€²å…¥ Roblox çš„ä¸–ç•Œï¼";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacFirefoxSecondInstruction"
	/// Double-click the Roblox Icon to begin the installation process
	/// English String: "Double-click the {startBold}Roblox Icon{endBold} to begin the installation process"
	/// </summary>
	public override string ResponseDialogMacFirefoxSecondInstruction(string startBold, string endBold)
	{
		return $"æŒ‰å…©ä¸‹ {startBold}Roblox åœ–ç¤º{endBold}é–‹å§‹å®‰è£ç¨‹åº";
	}

	protected override string _GetTemplateForResponseDialogMacFirefoxSecondInstruction()
	{
		return "æŒ‰å…©ä¸‹ {startBold}Roblox åœ–ç¤º{endBold}é–‹å§‹å®‰è£ç¨‹åº";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacFirefoxThirdInstruction"
	/// You will receive a warning, click Open
	/// English String: "You will receive a warning, click {startBold}Open{endBold}"
	/// </summary>
	public override string ResponseDialogMacFirefoxThirdInstruction(string startBold, string endBold)
	{
		return $"æ‚¨æœƒæ”¶åˆ°è­¦å‘Šï¼ŒæŒ‰ä¸‹{startBold}é–‹å•Ÿ{endBold}";
	}

	protected override string _GetTemplateForResponseDialogMacFirefoxThirdInstruction()
	{
		return "æ‚¨æœƒæ”¶åˆ°è­¦å‘Šï¼ŒæŒ‰ä¸‹{startBold}é–‹å•Ÿ{endBold}";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacSafariFirstInstruction"
	/// Go to Downloads and double-click Roblox.dmg
	/// English String: "Go to Downloads and double-click {startBold}Roblox.dmg{endBold}"
	/// </summary>
	public override string ResponseDialogMacSafariFirstInstruction(string startBold, string endBold)
	{
		return $"å‰å¾€ã€Œä¸‹è¼‰ã€ä¸¦æŒ‰å…©ä¸‹ {startBold}Roblox.dmg{endBold}";
	}

	protected override string _GetTemplateForResponseDialogMacSafariFirstInstruction()
	{
		return "å‰å¾€ã€Œä¸‹è¼‰ã€ä¸¦æŒ‰å…©ä¸‹ {startBold}Roblox.dmg{endBold}";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacSafariFourthInstruction"
	/// Once installed, click {startBold}Play{endBold} to join the action!
	/// English String: "Once installed, click {startBold}Play{endBold} to join the action!"
	/// </summary>
	public override string ResponseDialogMacSafariFourthInstruction(string startBold, string endBold)
	{
		return $"å®‰è£å®Œç•¢å¾Œï¼ŒæŒ‰ä¸‹{startBold}é–‹å§‹éŠæˆ²{endBold}é€²å…¥ Roblox çš„ä¸–ç•Œï¼";
	}

	protected override string _GetTemplateForResponseDialogMacSafariFourthInstruction()
	{
		return "å®‰è£å®Œç•¢å¾Œï¼ŒæŒ‰ä¸‹{startBold}é–‹å§‹éŠæˆ²{endBold}é€²å…¥ Roblox çš„ä¸–ç•Œï¼";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacSafariSecondInstruction"
	/// Double-click the {startBold}Roblox Icon{endBold} to begin the installation process
	/// English String: "Double-click the {startBold}Roblox Icon{endBold} to begin the installation process"
	/// </summary>
	public override string ResponseDialogMacSafariSecondInstruction(string startBold, string endBold)
	{
		return $"æŒ‰å…©ä¸‹ {startBold}Roblox åœ–ç¤º{endBold}é–‹å§‹å®‰è£ç¨‹åº";
	}

	protected override string _GetTemplateForResponseDialogMacSafariSecondInstruction()
	{
		return "æŒ‰å…©ä¸‹ {startBold}Roblox åœ–ç¤º{endBold}é–‹å§‹å®‰è£ç¨‹åº";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacSafariThirdInstruction"
	/// You will receive a warning, click {startBold}Open{endBold}
	/// English String: "You will receive a warning, click {startBold}Open{endBold}"
	/// </summary>
	public override string ResponseDialogMacSafariThirdInstruction(string startBold, string endBold)
	{
		return $"æ‚¨æœƒæ”¶åˆ°è­¦å‘Šè¨Šæ¯ï¼ŒæŒ‰ä¸‹{startBold}é–‹å•Ÿ{endBold}";
	}

	protected override string _GetTemplateForResponseDialogMacSafariThirdInstruction()
	{
		return "æ‚¨æœƒæ”¶åˆ°è­¦å‘Šè¨Šæ¯ï¼ŒæŒ‰ä¸‹{startBold}é–‹å•Ÿ{endBold}";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcChromeFirstInstruction"
	/// Click {startBold}RobloxPlayer.exe{endBold} to run the Roblox installer, which just downloaded via your web browser.
	/// English String: "Click {startBold}RobloxPlayer.exe{endBold} to run the Roblox installer, which just downloaded via your web browser."
	/// </summary>
	public override string ResponseDialogPcChromeFirstInstruction(string startBold, string endBold)
	{
		return $"æŒ‰ä¸‹ {startBold}RobloxPlayer.exe{endBold} åŸ·è¡Œæ‚¨ä¸‹è¼‰çš„ Roblox å®‰è£ç¨‹å¼ã€‚";
	}

	protected override string _GetTemplateForResponseDialogPcChromeFirstInstruction()
	{
		return "æŒ‰ä¸‹ {startBold}RobloxPlayer.exe{endBold} åŸ·è¡Œæ‚¨ä¸‹è¼‰çš„ Roblox å®‰è£ç¨‹å¼ã€‚";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcChromeFourthInstruction"
	/// After installation, click {startBold}Play{endBold} below to join the action!
	/// English String: "After installation, click {startBold}Play{endBold} below to join the action!"
	/// </summary>
	public override string ResponseDialogPcChromeFourthInstruction(string startBold, string endBold)
	{
		return $"å®‰è£å¾Œï¼ŒæŒ‰ä¸‹ä¸‹æ–¹çš„{startBold}é–‹å§‹éŠæˆ²{endBold}é€²å…¥ Roblox çš„ä¸–ç•Œï¼";
	}

	protected override string _GetTemplateForResponseDialogPcChromeFourthInstruction()
	{
		return "å®‰è£å¾Œï¼ŒæŒ‰ä¸‹ä¸‹æ–¹çš„{startBold}é–‹å§‹éŠæˆ²{endBold}é€²å…¥ Roblox çš„ä¸–ç•Œï¼";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcChromeSecondInstruction"
	/// Click {startBold}Run{endBold} when prompted by your computer to begin the installation process.
	/// English String: "Click {startBold}Run{endBold} when prompted by your computer to begin the installation process."
	/// </summary>
	public override string ResponseDialogPcChromeSecondInstruction(string startBold, string endBold)
	{
		return $"ä¾ç…§é›»è…¦æŒ‡ç¤ºï¼ŒæŒ‰ä¸‹{startBold}åŸ·è¡Œ{endBold}é–‹å§‹å®‰è£ç¨‹åºã€‚";
	}

	protected override string _GetTemplateForResponseDialogPcChromeSecondInstruction()
	{
		return "ä¾ç…§é›»è…¦æŒ‡ç¤ºï¼ŒæŒ‰ä¸‹{startBold}åŸ·è¡Œ{endBold}é–‹å§‹å®‰è£ç¨‹åºã€‚";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcChromeThirdInstruction"
	/// Click {startBold}Ok{endBold} once you've successfully installed Roblox.
	/// English String: "Click {startBold}Ok{endBold} once you've successfully installed Roblox."
	/// </summary>
	public override string ResponseDialogPcChromeThirdInstruction(string startBold, string endBold)
	{
		return $"Roblox å®‰è£å®Œç•¢å¾Œï¼ŒæŒ‰ä¸‹{startBold}ç¢ºå®š{endBold}ã€‚";
	}

	protected override string _GetTemplateForResponseDialogPcChromeThirdInstruction()
	{
		return "Roblox å®‰è£å®Œç•¢å¾Œï¼ŒæŒ‰ä¸‹{startBold}ç¢ºå®š{endBold}ã€‚";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcEdgeFirstInstruction"
	/// Click {startBold}Run{endBold} to install Roblox after the download finishes
	/// English String: "Click {startBold}Run{endBold} to install Roblox after the download finishes"
	/// </summary>
	public override string ResponseDialogPcEdgeFirstInstruction(string startBold, string endBold)
	{
		return $"ä¸‹è¼‰å®Œæˆå¾Œï¼ŒæŒ‰ä¸‹{startBold}åŸ·è¡Œ{endBold}é–‹å§‹å®‰è£ Roblox";
	}

	protected override string _GetTemplateForResponseDialogPcEdgeFirstInstruction()
	{
		return "ä¸‹è¼‰å®Œæˆå¾Œï¼ŒæŒ‰ä¸‹{startBold}åŸ·è¡Œ{endBold}é–‹å§‹å®‰è£ Roblox";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcEdgeSecondInstruction"
	/// Click {startBold}Ok{endBold} to finish installing Roblox
	/// English String: "Click {startBold}Ok{endBold} to finish installing Roblox"
	/// </summary>
	public override string ResponseDialogPcEdgeSecondInstruction(string startBold, string endBold)
	{
		return $"æŒ‰ä¸‹{startBold}ç¢ºå®š{endBold}å®Œæˆå®‰è£ Roblox";
	}

	protected override string _GetTemplateForResponseDialogPcEdgeSecondInstruction()
	{
		return "æŒ‰ä¸‹{startBold}ç¢ºå®š{endBold}å®Œæˆå®‰è£ Roblox";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcEdgeThirdInstruction"
	/// Click the {startBold}Play{endBold} button to join the action!
	/// English String: "Click the {startBold}Play{endBold} button to join the action!"
	/// </summary>
	public override string ResponseDialogPcEdgeThirdInstruction(string startBold, string endBold)
	{
		return $"æŒ‰ä¸‹{startBold}é–‹å§‹éŠæˆ²{endBold}æŒ‰éˆ•ï¼Œé€²å…¥ Roblox çš„ä¸–ç•Œï¼";
	}

	protected override string _GetTemplateForResponseDialogPcEdgeThirdInstruction()
	{
		return "æŒ‰ä¸‹{startBold}é–‹å§‹éŠæˆ²{endBold}æŒ‰éˆ•ï¼Œé€²å…¥ Roblox çš„ä¸–ç•Œï¼";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcFirefoxFifthInstruction"
	/// Click {startBold}Ok{endBold} when the alert pops up
	/// English String: "Click {startBold}Ok{endBold} when the alert pops up"
	/// </summary>
	public override string ResponseDialogPcFirefoxFifthInstruction(string startBold, string endBold)
	{
		return $"è­¦å‘Šè¦–çª—å½ˆå‡ºå¾Œï¼ŒæŒ‰ä¸‹{startBold}ç¢ºå®š{endBold}";
	}

	protected override string _GetTemplateForResponseDialogPcFirefoxFifthInstruction()
	{
		return "è­¦å‘Šè¦–çª—å½ˆå‡ºå¾Œï¼ŒæŒ‰ä¸‹{startBold}ç¢ºå®š{endBold}";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcFirefoxFirstInstruction"
	/// Click {startBold}Save File{endBold} when the download window pops up
	/// English String: "Click {startBold}Save File{endBold} when the download window pops up"
	/// </summary>
	public override string ResponseDialogPcFirefoxFirstInstruction(string startBold, string endBold)
	{
		return $"ä¸‹è¼‰è¦–çª—å½ˆå‡ºæ™‚ï¼ŒæŒ‰ä¸‹{startBold}å„²å­˜æª”æ¡ˆ{endBold}";
	}

	protected override string _GetTemplateForResponseDialogPcFirefoxFirstInstruction()
	{
		return "ä¸‹è¼‰è¦–çª—å½ˆå‡ºæ™‚ï¼ŒæŒ‰ä¸‹{startBold}å„²å­˜æª”æ¡ˆ{endBold}";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcFirefoxFourthInstruction"
	/// Once installed, click {startBold}Play{endBold} to join the action!
	/// English String: "Once installed, click {startBold}Play{endBold} to join the action!"
	/// </summary>
	public override string ResponseDialogPcFirefoxFourthInstruction(string startBold, string endBold)
	{
		return $"å®‰è£å®Œç•¢å¾Œï¼ŒæŒ‰ä¸‹{startBold}é–‹å§‹éŠæˆ²{endBold}é€²å…¥ Roblox çš„ä¸–ç•Œï¼";
	}

	protected override string _GetTemplateForResponseDialogPcFirefoxFourthInstruction()
	{
		return "å®‰è£å®Œç•¢å¾Œï¼ŒæŒ‰ä¸‹{startBold}é–‹å§‹éŠæˆ²{endBold}é€²å…¥ Roblox çš„ä¸–ç•Œï¼";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcFirefoxSecondInstruction"
	/// Go to Downloads and double click {startBold}RobloxPlayer.exe{endBold}
	/// English String: "Go to Downloads and double click {startBold}RobloxPlayer.exe{endBold}"
	/// </summary>
	public override string ResponseDialogPcFirefoxSecondInstruction(string startBold, string endBold)
	{
		return $"å‰å¾€ã€Œä¸‹è¼‰ã€ä¸¦æŒ‰å…©ä¸‹ {startBold}RobloxPlayer.exe{endBold}";
	}

	protected override string _GetTemplateForResponseDialogPcFirefoxSecondInstruction()
	{
		return "å‰å¾€ã€Œä¸‹è¼‰ã€ä¸¦æŒ‰å…©ä¸‹ {startBold}RobloxPlayer.exe{endBold}";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcFirefoxThirdInstruction"
	/// Click {startBold}Run{endBold}
	/// English String: "Click {startBold}Run{endBold}"
	/// </summary>
	public override string ResponseDialogPcFirefoxThirdInstruction(string startBold, string endBold)
	{
		return $"æŒ‰ä¸‹{startBold}åŸ·è¡Œ{endBold}";
	}

	protected override string _GetTemplateForResponseDialogPcFirefoxThirdInstruction()
	{
		return "æŒ‰ä¸‹{startBold}åŸ·è¡Œ{endBold}";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcIEFirstInstruction"
	/// You will receive a warning, click {startBold}Run{endBold}
	/// English String: "You will receive a warning, click {startBold}Run{endBold}"
	/// </summary>
	public override string ResponseDialogPcIEFirstInstruction(string startBold, string endBold)
	{
		return $"æ‚¨æœƒæ”¶åˆ°è­¦å‘Šï¼Œè«‹æŒ‰ä¸‹{startBold}åŸ·è¡Œ{endBold}";
	}

	protected override string _GetTemplateForResponseDialogPcIEFirstInstruction()
	{
		return "æ‚¨æœƒæ”¶åˆ°è­¦å‘Šï¼Œè«‹æŒ‰ä¸‹{startBold}åŸ·è¡Œ{endBold}";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcIeInstructionOne"
	/// You will receive a warning, click {startBold}Run{endBold}
	/// English String: "You will receive a warning, click {startBold}Run{endBold}"
	/// </summary>
	public override string ResponseDialogPcIeInstructionOne(string startBold, string endBold)
	{
		return $"æ‚¨æœƒæ”¶åˆ°è­¦å‘Šï¼Œè«‹æŒ‰ä¸‹{startBold}åŸ·è¡Œ{endBold}";
	}

	protected override string _GetTemplateForResponseDialogPcIeInstructionOne()
	{
		return "æ‚¨æœƒæ”¶åˆ°è­¦å‘Šï¼Œè«‹æŒ‰ä¸‹{startBold}åŸ·è¡Œ{endBold}";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcIeInstructionThree"
	/// Click {startBold}Run{endBold}
	/// English String: "Click {startBold}Run{endBold}"
	/// </summary>
	public override string ResponseDialogPcIeInstructionThree(string startBold, string endBold)
	{
		return $"æŒ‰ä¸‹{startBold}åŸ·è¡Œ{endBold}";
	}

	protected override string _GetTemplateForResponseDialogPcIeInstructionThree()
	{
		return "æŒ‰ä¸‹{startBold}åŸ·è¡Œ{endBold}";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcIeInstructionTwo"
	/// Go to Downloads and double click {startBold}RobloxPlayer.exe{endBold}
	/// English String: "Go to Downloads and double click {startBold}RobloxPlayer.exe{endBold}"
	/// </summary>
	public override string ResponseDialogPcIeInstructionTwo(string startBold, string endBold)
	{
		return $"å‰å¾€ã€Œä¸‹è¼‰ã€ä¸¦æŒ‰å…©ä¸‹ {startBold}RobloxPlayer.exe{endBold}";
	}

	protected override string _GetTemplateForResponseDialogPcIeInstructionTwo()
	{
		return "å‰å¾€ã€Œä¸‹è¼‰ã€ä¸¦æŒ‰å…©ä¸‹ {startBold}RobloxPlayer.exe{endBold}";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcIESecondInstruction"
	/// Click {startBold}Ok{endBold} once you've installed Roblox
	/// English String: "Click {startBold}Ok{endBold} once you've installed Roblox"
	/// </summary>
	public override string ResponseDialogPcIESecondInstruction(string startBold, string endBold)
	{
		return $"æ‚¨å®‰è£ Roblox å¾Œï¼ŒæŒ‰ä¸‹{startBold}ç¢ºå®š{endBold}";
	}

	protected override string _GetTemplateForResponseDialogPcIESecondInstruction()
	{
		return "æ‚¨å®‰è£ Roblox å¾Œï¼ŒæŒ‰ä¸‹{startBold}ç¢ºå®š{endBold}";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcIEThirdInstruction"
	/// Once installed, click {startBold}Play{endBold} to join the action!
	/// English String: "Once installed, click {startBold}Play{endBold} to join the action!"
	/// </summary>
	public override string ResponseDialogPcIEThirdInstruction(string startBold, string endBold)
	{
		return $"å®‰è£å®Œç•¢å¾Œï¼ŒæŒ‰ä¸‹{startBold}é–‹å§‹éŠæˆ²{endBold}é€²å…¥ Roblox çš„ä¸–ç•Œï¼";
	}

	protected override string _GetTemplateForResponseDialogPcIEThirdInstruction()
	{
		return "å®‰è£å®Œç•¢å¾Œï¼ŒæŒ‰ä¸‹{startBold}é–‹å§‹éŠæˆ²{endBold}é€²å…¥ Roblox çš„ä¸–ç•Œï¼";
	}

	protected override string _GetTemplateForResponseDialogThanksForPlayingRoblox()
	{
		return "è¬è¬æ‚¨çŽ© Roblox";
	}

	protected override string _GetTemplateForResponseGameTemporarilyUnavailable()
	{
		return "ç„¡æ³•é©—è­‰æ‚¨çš„éŠæˆ²é€šè¡Œæ¬Šï¼Œè«‹ç¨å¾Œå†è©¦ã€‚";
	}

	/// <summary>
	/// Key: "Response.RememberMyChoiceAppLaunch"
	/// Check {startBold}Remember my choice{endBold} and click {appLaunchLink} in the dialog box above to join games faster in the future!
	/// English String: "Check {startBold}Remember my choice{endBold} and click {appLaunchLink} in the dialog box above to join games faster in the future!"
	/// </summary>
	public override string ResponseRememberMyChoiceAppLaunch(string startBold, string endBold, string appLaunchLink)
	{
		return $"å‹¾é¸{startBold}è¨˜ä½æˆ‘çš„é¸æ“‡{endBold}ï¼Œä¸¦åœ¨ä¸Šæ–¹çš„å°è©±æ¡†æŒ‰ä¸‹{appLaunchLink}ï¼Œå°±å¯ä»¥æ›´å¿«åŠ å…¥éŠæˆ²ï¼";
	}

	protected override string _GetTemplateForResponseRememberMyChoiceAppLaunch()
	{
		return "å‹¾é¸{startBold}è¨˜ä½æˆ‘çš„é¸æ“‡{endBold}ï¼Œä¸¦åœ¨ä¸Šæ–¹çš„å°è©±æ¡†æŒ‰ä¸‹{appLaunchLink}ï¼Œå°±å¯ä»¥æ›´å¿«åŠ å…¥éŠæˆ²ï¼";
	}
}


}
