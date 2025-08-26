namespace Roblox.Platform.TranslationResources.Common {
    /// <summary>

/// This class overrides VisitGameResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class VisitGameResources_zh_cn : VisitGameResources_en_us, IVisitGameResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Retry"
	/// button label
	/// English String: "Retry"
	/// </summary>
	public override string ActionRetry => "é‡è¯•";

	/// <summary>
	/// Key: "Heading.ErrorStartingGame"
	/// Error starting game
	/// English String: "Error starting game"
	/// </summary>
	public override string HeadingErrorStartingGame => "å¯åŠ¨æ¸¸æˆæ—¶å‡ºé”™ã€‚";

	/// <summary>
	/// Key: "Heading.SwitchToDesktopToPlay"
	/// Switch to Desktop Mode to Play Games
	/// English String: "Switch to Desktop Mode to Play Games"
	/// </summary>
	public override string HeadingSwitchToDesktopToPlay => "åˆ‡æ¢è‡³æ¡Œé¢æ¨¡å¼ä»¥å¼€å§‹æ¸¸æˆ";

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
	public override string LabelCheckingForStudio => "æ­£åœ¨æ£€æŸ¥ Roblox Studio...";

	/// <summary>
	/// Key: "Label.ClickHereForHelp"
	/// Click here for help
	/// English String: "Click here for help"
	/// </summary>
	public override string LabelClickHereForHelp => "ç‚¹å‡»æ­¤å¤„èŽ·å–å¸®åŠ©";

	/// <summary>
	/// Key: "Label.ConnectingToPlayers"
	/// Joining a game network with other players
	/// English String: "Connecting to Players..."
	/// </summary>
	public override string LabelConnectingToPlayers => "æ­£åœ¨è¿žæŽ¥çŽ©å®¶...";

	/// <summary>
	/// Key: "Label.DevelopPageTitle"
	/// English String: "Develop"
	/// </summary>
	public override string LabelDevelopPageTitle => "å¼€å‘";

	/// <summary>
	/// Key: "Label.DownloadInstallRoblox"
	/// Download and Install Roblox
	/// English String: "Download and Install Roblox"
	/// </summary>
	public override string LabelDownloadInstallRoblox => "ä¸‹è½½å¹¶å®‰è£… Roblox";

	/// <summary>
	/// Key: "Label.DownloadStudio"
	/// Download Roblox Studio to start creating games
	/// English String: "Download Studio"
	/// </summary>
	public override string LabelDownloadStudio => "ä¸‹è½½ Studio";

	/// <summary>
	/// Key: "Label.GameConfigurePageTitle"
	/// English String: "Game Configure"
	/// </summary>
	public override string LabelGameConfigurePageTitle => "æ¸¸æˆé…ç½®";

	/// <summary>
	/// Key: "Label.GameFreeSoothsayer"
	/// English String: "Free because you are a soothsayer"
	/// </summary>
	public override string LabelGameFreeSoothsayer => "å…è´¹ï¼Œç”±äºŽä½ æ˜¯ Soothsayer ç”¨æˆ·";

	/// <summary>
	/// Key: "Label.GameUnavailableAccountResrictions"
	/// English String: "The game is unavailable due to account restrictions settings."
	/// </summary>
	public override string LabelGameUnavailableAccountResrictions => "ç”±äºŽå¸æˆ·é™åˆ¶è®¾ç½®ï¼Œæ­¤æ¸¸æˆä¸å¯ç”¨ã€‚";

	/// <summary>
	/// Key: "Label.GameUnavailableCannotPlayGamesStudio"
	/// English String: "You cannot play games from Studio. Please use a web browser to play this game."
	/// </summary>
	public override string LabelGameUnavailableCannotPlayGamesStudio => "ä½ æ— æ³•çŽ© Studio ä¸Šçš„æ¸¸æˆã€‚è¯·ä½¿ç”¨ç½‘ç»œæµè§ˆå™¨å¼€å§‹æ­¤æ¸¸æˆã€‚";

	/// <summary>
	/// Key: "Label.GameUnavailableClosedToVisitors"
	/// English String: "Sorry, this place is currently closed to visitors."
	/// </summary>
	public override string LabelGameUnavailableClosedToVisitors => "æŠ±æ­‰ï¼Œæ­¤åœºæ™¯å½“å‰ä¸å¯¹è®¿å®¢å¼€æ”¾ã€‚";

	/// <summary>
	/// Key: "Label.GameUnavailableCurrentlyIsPrivateVisitor"
	/// When a game is private, this message is shown to visitors.
	/// English String: "Sorry, this game is private."
	/// </summary>
	public override string LabelGameUnavailableCurrentlyIsPrivateVisitor => "æŠ±æ­‰ï¼Œè¿™æ˜¯ç§äººæ¸¸æˆã€‚";

	/// <summary>
	/// Key: "Label.GameUnavailableGameInsecure"
	/// U13 users cannot play insecure games unless they are the creator or friends with the creator.
	/// English String: "Sorry, your account is restricted from playing Experimental Games unless you are friends with the creator."
	/// </summary>
	public override string LabelGameUnavailableGameInsecure => "æŠ±æ­‰ï¼Œä½ ä¸Žåˆ›ä½œè€…è¿˜ä¸æ˜¯å¥½å‹ï¼Œå› æ­¤ä½ æ— æ³•åŠ å…¥å®žéªŒæ€§æ¸¸æˆã€‚";

	/// <summary>
	/// Key: "Label.GameUnavailablePermissionLevels"
	/// English String: "The permission levels on this place prevent you from entering."
	/// </summary>
	public override string LabelGameUnavailablePermissionLevels => "ä½ çš„æƒé™ä¸è¶³ï¼Œæ— æ³•è¿›å…¥æ­¤åœºæ™¯ã€‚";

	/// <summary>
	/// Key: "Label.GameUnavailablePlaceUnderReview"
	/// English String: "Sorry, this place is currently under review. Try again later."
	/// </summary>
	public override string LabelGameUnavailablePlaceUnderReview => "æŠ±æ­‰ï¼Œæ­¤åœºæ™¯å½“å‰æ­£æŽ¥å—å®¡æ ¸ã€‚è¯·ç¨åŽé‡è¯•ã€‚";

	/// <summary>
	/// Key: "Label.GameUnavailablePlatform"
	/// English String: "This game is not available on your platform.  Check the games page to see all playable games."
	/// </summary>
	public override string LabelGameUnavailablePlatform => "æ­¤æ¸¸æˆæ— æ³•å†ä½ çš„å¹³å°ä¸Šè¿è¡Œã€‚è¯·åœ¨æ¸¸æˆé¡µé¢æŸ¥çœ‹å…¨éƒ¨å¯çŽ©çš„æ¸¸æˆã€‚";

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
	public override string LabelInstallationInstructions => "å®‰è£…è¯´æ˜Ž";

	/// <summary>
	/// Key: "Label.LaunchApplication"
	/// Launch Application
	/// English String: "Launch Application"
	/// </summary>
	public override string LabelLaunchApplication => "å¯åŠ¨åº”ç”¨ç¨‹åº";

	/// <summary>
	/// Key: "Label.PersuadeToDevelopRoblox"
	/// Persuade user to begin developing their own games using Roblox Studio
	/// English String: "Get started creating your own games!"
	/// </summary>
	public override string LabelPersuadeToDevelopRoblox => "å¼€å§‹åˆ›ä½œä½ è‡ªå·±çš„æ¸¸æˆï¼";

	/// <summary>
	/// Key: "Label.PersuadeToInstallRoblox"
	/// We are exciting the user about Roblox so that they will be persuaded to download and install it.
	/// English String: "You're moments away from getting into the game!"
	/// </summary>
	public override string LabelPersuadeToInstallRoblox => "ä½ å¾ˆå¿«å°±è¦è¿›å…¥æ¸¸æˆå•¦ï¼";

	/// <summary>
	/// Key: "Label.Play"
	/// English String: "Play"
	/// </summary>
	public override string LabelPlay => "å¼€å§‹æ¸¸æˆ";

	/// <summary>
	/// Key: "Label.PlayInApp"
	/// English String: "Play in App"
	/// </summary>
	public override string LabelPlayInApp => "åœ¨ App ä¸­çŽ©";

	/// <summary>
	/// Key: "Label.RobloxLoadingToPlay"
	/// Roblox is loading, so the user is getting excited to start playing a game
	/// English String: "Roblox is now loading. Get ready to play!"
	/// </summary>
	public override string LabelRobloxLoadingToPlay => "æ­£åœ¨åŠ è½½ Robloxã€‚å‡†å¤‡å¥½ï¼Œæ¸¸æˆé©¬ä¸Šå¼€å§‹ï¼";

	/// <summary>
	/// Key: "Label.StartingRoblox"
	/// Game launch process has started
	/// English String: "Starting Roblox..."
	/// </summary>
	public override string LabelStartingRoblox => "æ­£åœ¨å¯åŠ¨ Roblox...";

	/// <summary>
	/// Key: "Label.SwitchToDesktopMode"
	/// Switch to Desktop Mode
	/// English String: "Switch to Desktop Mode"
	/// </summary>
	public override string LabelSwitchToDesktopMode => "åˆ‡æ¢è‡³æ¡Œé¢æ¨¡å¼";

	/// <summary>
	/// Key: "Label.UniverseConfigurePageTitle"
	/// The name of the universe configuration page
	/// English String: "Universe Configuration"
	/// </summary>
	public override string LabelUniverseConfigurePageTitle => "é€šç”¨é…ç½®";

	/// <summary>
	/// Key: "Response.Dialog.ClickHere"
	/// Click here!
	/// English String: "Click here!"
	/// </summary>
	public override string ResponseDialogClickHere => "ç‚¹æŒ‰æ­¤å¤„ï¼";

	/// <summary>
	/// Key: "Response.Dialog.ErrorLaunching"
	/// An error occurred trying to launch the game.  Please try again later.
	/// English String: "An error occurred trying to launch the game.  Please try again later."
	/// </summary>
	public override string ResponseDialogErrorLaunching => "å°è¯•å¯åŠ¨æ¸¸æˆæ—¶å‘ç”Ÿé”™è¯¯ã€‚è¯·ç¨åŽé‡è¯•ã€‚";

	/// <summary>
	/// Key: "Response.Dialog.HavingTroubleInstallQuestion"
	/// (Are you) having trouble installing Roblox?
	/// English String: "Having trouble installing Roblox?"
	/// </summary>
	public override string ResponseDialogHavingTroubleInstallQuestion => "å®‰è£… Roblox æ—¶é‡åˆ°é—®é¢˜ï¼Ÿ";

	/// <summary>
	/// Key: "Response.Dialog.MacChromeSecondInstruction"
	/// Double-click the Roblox app icon to begin the installation process.
	/// English String: "Double-click the Roblox app icon to begin the installation process."
	/// </summary>
	public override string ResponseDialogMacChromeSecondInstruction => "è¿žæŒ‰ Roblox App å›¾æ ‡ä»¥å¼€å§‹å®‰è£…ç¨‹åºã€‚";

	/// <summary>
	/// Key: "Response.Dialog.ThanksForPlayingRoblox"
	/// Thanks for playing Roblox
	/// English String: "Thanks for playing Roblox"
	/// </summary>
	public override string ResponseDialogThanksForPlayingRoblox => "è°¢è°¢ä½ çŽ© Roblox";

	/// <summary>
	/// Key: "Response.GameTemporarilyUnavailable"
	/// error message (will be followed by link with Action.Retry label)
	/// English String: "Unable to verify that you have access to this game.  Please try again later."
	/// </summary>
	public override string ResponseGameTemporarilyUnavailable => "æ— æ³•éªŒè¯ä½ æ˜¯å¦æœ‰æƒè®¿é—®æ­¤æ¸¸æˆã€‚è¯·ç¨åŽé‡è¯•ã€‚";

	public VisitGameResources_zh_cn(TranslationResourceState state)
		: base(state)
	{
	}

	/// <summary>
	/// Key: "Action.GamePerformPoorly"
	/// English String: "{warning} This game may perform poorly on your device."
	/// </summary>
	public override string ActionGamePerformPoorly(string warning)
	{
		return $"{warning} æ­¤æ¸¸æˆå¯èƒ½åœ¨ä½ çš„è®¾å¤‡ä¸Šè¿è¡Œä¸ä½³ã€‚";
	}

	protected override string _GetTemplateForActionGamePerformPoorly()
	{
		return "{warning} æ­¤æ¸¸æˆå¯èƒ½åœ¨ä½ çš„è®¾å¤‡ä¸Šè¿è¡Œä¸ä½³ã€‚";
	}

	protected override string _GetTemplateForActionRetry()
	{
		return "é‡è¯•";
	}

	protected override string _GetTemplateForHeadingErrorStartingGame()
	{
		return "å¯åŠ¨æ¸¸æˆæ—¶å‡ºé”™ã€‚";
	}

	protected override string _GetTemplateForHeadingSwitchToDesktopToPlay()
	{
		return "åˆ‡æ¢è‡³æ¡Œé¢æ¨¡å¼ä»¥å¼€å§‹æ¸¸æˆ";
	}

	/// <summary>
	/// Key: "Label.BuyAccess"
	/// English String: "Buy Access for {robux} Robux"
	/// </summary>
	public override string LabelBuyAccess(string robux)
	{
		return $"ä»¥ {robux} Robux è´­ä¹°é€šè¡Œè¯";
	}

	protected override string _GetTemplateForLabelBuyAccess()
	{
		return "ä»¥ {robux} Robux è´­ä¹°é€šè¡Œè¯";
	}

	protected override string _GetTemplateForLabelCancel()
	{
		return "å–æ¶ˆ";
	}

	protected override string _GetTemplateForLabelCheckingForStudio()
	{
		return "æ­£åœ¨æ£€æŸ¥ Roblox Studio...";
	}

	protected override string _GetTemplateForLabelClickHereForHelp()
	{
		return "ç‚¹å‡»æ­¤å¤„èŽ·å–å¸®åŠ©";
	}

	protected override string _GetTemplateForLabelConnectingToPlayers()
	{
		return "æ­£åœ¨è¿žæŽ¥çŽ©å®¶...";
	}

	protected override string _GetTemplateForLabelDevelopPageTitle()
	{
		return "å¼€å‘";
	}

	protected override string _GetTemplateForLabelDownloadInstallRoblox()
	{
		return "ä¸‹è½½å¹¶å®‰è£… Roblox";
	}

	protected override string _GetTemplateForLabelDownloadStudio()
	{
		return "ä¸‹è½½ Studio";
	}

	protected override string _GetTemplateForLabelGameConfigurePageTitle()
	{
		return "æ¸¸æˆé…ç½®";
	}

	protected override string _GetTemplateForLabelGameFreeSoothsayer()
	{
		return "å…è´¹ï¼Œç”±äºŽä½ æ˜¯ Soothsayer ç”¨æˆ·";
	}

	/// <summary>
	/// Key: "Label.GameIsPrivatePlayableByGroupOnly"
	/// When a game is private, this message is shown to group developers with a link from where it can be made public.
	/// English String: "Only developers can play because this game is private. Make it public on the {linkStart}Configure Game{linkEnd} page."
	/// </summary>
	public override string LabelGameIsPrivatePlayableByGroupOnly(string linkStart, string linkEnd)
	{
		return $"è¿™æ˜¯ç§äººæ¸¸æˆï¼Œåªæœ‰å¼€å‘è€…èƒ½çŽ©ã€‚è¯·åœ¨{linkStart}é…ç½®æ¸¸æˆ{linkEnd}é¡µé¢å°†å…¶è®¾ä¸ºå…¬å¼€ã€‚";
	}

	protected override string _GetTemplateForLabelGameIsPrivatePlayableByGroupOnly()
	{
		return "è¿™æ˜¯ç§äººæ¸¸æˆï¼Œåªæœ‰å¼€å‘è€…èƒ½çŽ©ã€‚è¯·åœ¨{linkStart}é…ç½®æ¸¸æˆ{linkEnd}é¡µé¢å°†å…¶è®¾ä¸ºå…¬å¼€ã€‚";
	}

	/// <summary>
	/// Key: "Label.GameIsPrivatePlayableByOwnerOnly"
	/// When a game is private, this message is shown to owner with a link from where it can be made public.
	/// English String: "Only you can play because this game is private. Make it public on the {linkStart}Configure Game{linkEnd} page."
	/// </summary>
	public override string LabelGameIsPrivatePlayableByOwnerOnly(string linkStart, string linkEnd)
	{
		return $"è¿™æ˜¯ç§äººæ¸¸æˆï¼Œåªæœ‰ä½ èƒ½çŽ©ã€‚è¯·åœ¨{linkStart}é…ç½®æ¸¸æˆ{linkEnd}é¡µé¢å°†å…¶è®¾ä¸ºå…¬å¼€ã€‚";
	}

	protected override string _GetTemplateForLabelGameIsPrivatePlayableByOwnerOnly()
	{
		return "è¿™æ˜¯ç§äººæ¸¸æˆï¼Œåªæœ‰ä½ èƒ½çŽ©ã€‚è¯·åœ¨{linkStart}é…ç½®æ¸¸æˆ{linkEnd}é¡µé¢å°†å…¶è®¾ä¸ºå…¬å¼€ã€‚";
	}

	protected override string _GetTemplateForLabelGameUnavailableAccountResrictions()
	{
		return "ç”±äºŽå¸æˆ·é™åˆ¶è®¾ç½®ï¼Œæ­¤æ¸¸æˆä¸å¯ç”¨ã€‚";
	}

	protected override string _GetTemplateForLabelGameUnavailableCannotPlayGamesStudio()
	{
		return "ä½ æ— æ³•çŽ© Studio ä¸Šçš„æ¸¸æˆã€‚è¯·ä½¿ç”¨ç½‘ç»œæµè§ˆå™¨å¼€å§‹æ­¤æ¸¸æˆã€‚";
	}

	protected override string _GetTemplateForLabelGameUnavailableClosedToVisitors()
	{
		return "æŠ±æ­‰ï¼Œæ­¤åœºæ™¯å½“å‰ä¸å¯¹è®¿å®¢å¼€æ”¾ã€‚";
	}

	/// <summary>
	/// Key: "Label.GameUnavailableCurrentlyIsPrivateGroup"
	/// When a game is private, this message is shown to group developers with a link from where it can be made public. Similar to an existing translation. Change is making the message directly address the group developers.
	/// English String: "Only developers can play because this game is private. Make it public on the {linkStart}Develop{linkEnd} page."
	/// </summary>
	public override string LabelGameUnavailableCurrentlyIsPrivateGroup(string linkStart, string linkEnd)
	{
		return $"è¿™æ˜¯å››äººæ¸¸æˆï¼Œåªæœ‰å¼€å‘è€…å¯ä»¥çŽ©ã€‚è¯·åœ¨{linkStart}åˆ›å»º{linkEnd}é¡µé¢å°†å…¶è®¾ä¸ºå…¬å¼€ã€‚";
	}

	protected override string _GetTemplateForLabelGameUnavailableCurrentlyIsPrivateGroup()
	{
		return "è¿™æ˜¯å››äººæ¸¸æˆï¼Œåªæœ‰å¼€å‘è€…å¯ä»¥çŽ©ã€‚è¯·åœ¨{linkStart}åˆ›å»º{linkEnd}é¡µé¢å°†å…¶è®¾ä¸ºå…¬å¼€ã€‚";
	}

	/// <summary>
	/// Key: "Label.GameUnavailableCurrentlyIsPrivateOwner"
	/// When a game is private, this message is shown to owner with a link from where it can be made public. Similar to an existing translation. Change is making the message directly address the owner.
	/// English String: "Only you can play because this game is private. Make it public on the {linkStart}Develop{linkEnd} page."
	/// </summary>
	public override string LabelGameUnavailableCurrentlyIsPrivateOwner(string linkStart, string linkEnd)
	{
		return $"è¿™æ˜¯ç§äººæ¸¸æˆï¼Œåªæœ‰ä½ èƒ½çŽ©ã€‚è¯·åœ¨{linkStart}åˆ›å»º{linkEnd}é¡µé¢å°†å…¶è®¾ä¸ºå…¬å¼€ã€‚";
	}

	protected override string _GetTemplateForLabelGameUnavailableCurrentlyIsPrivateOwner()
	{
		return "è¿™æ˜¯ç§äººæ¸¸æˆï¼Œåªæœ‰ä½ èƒ½çŽ©ã€‚è¯·åœ¨{linkStart}åˆ›å»º{linkEnd}é¡µé¢å°†å…¶è®¾ä¸ºå…¬å¼€ã€‚";
	}

	protected override string _GetTemplateForLabelGameUnavailableCurrentlyIsPrivateVisitor()
	{
		return "æŠ±æ­‰ï¼Œè¿™æ˜¯ç§äººæ¸¸æˆã€‚";
	}

	/// <summary>
	/// Key: "Label.GameUnavailableCurrentlyPrivate"
	/// When a game is private, this message is shown to user with link from where it can be made public
	/// English String: "This {gameTypeName} is currently private. Make it public on the {developPageLink} page to make it playable."
	/// </summary>
	public override string LabelGameUnavailableCurrentlyPrivate(string gameTypeName, string developPageLink)
	{
		return $"æ­¤â€œ{gameTypeName}â€å½“å‰ä¸ºç§äººæ¨¡å¼ã€‚è¯·åœ¨ {developPageLink} é¡µé¢å°†å…¶è®¾ä¸ºå…¬å¼€ï¼Œä½¿å®ƒæˆä¸ºå¯çŽ©çŠ¶æ€ã€‚";
	}

	protected override string _GetTemplateForLabelGameUnavailableCurrentlyPrivate()
	{
		return "æ­¤â€œ{gameTypeName}â€å½“å‰ä¸ºç§äººæ¨¡å¼ã€‚è¯·åœ¨ {developPageLink} é¡µé¢å°†å…¶è®¾ä¸ºå…¬å¼€ï¼Œä½¿å®ƒæˆä¸ºå¯çŽ©çŠ¶æ€ã€‚";
	}

	protected override string _GetTemplateForLabelGameUnavailableGameInsecure()
	{
		return "æŠ±æ­‰ï¼Œä½ ä¸Žåˆ›ä½œè€…è¿˜ä¸æ˜¯å¥½å‹ï¼Œå› æ­¤ä½ æ— æ³•åŠ å…¥å®žéªŒæ€§æ¸¸æˆã€‚";
	}

	/// <summary>
	/// Key: "Label.GameUnavailableNoRootPlace"
	/// English String: "This place is part of a game that has no root place. Add a root place on the {gameConfigureLink} page to make it playable."
	/// </summary>
	public override string LabelGameUnavailableNoRootPlace(string gameConfigureLink)
	{
		return $"æ­¤åœºæ™¯æ‰€åœ¨çš„æ¸¸æˆæ²¡æœ‰æ ¹åœºæ™¯ã€‚åœ¨ {gameConfigureLink} é¡µé¢æ·»åŠ æ ¹åœºæ™¯ï¼Œä½¿å®ƒæˆä¸ºå¯çŽ©çŠ¶æ€ã€‚";
	}

	protected override string _GetTemplateForLabelGameUnavailableNoRootPlace()
	{
		return "æ­¤åœºæ™¯æ‰€åœ¨çš„æ¸¸æˆæ²¡æœ‰æ ¹åœºæ™¯ã€‚åœ¨ {gameConfigureLink} é¡µé¢æ·»åŠ æ ¹åœºæ™¯ï¼Œä½¿å®ƒæˆä¸ºå¯çŽ©çŠ¶æ€ã€‚";
	}

	protected override string _GetTemplateForLabelGameUnavailablePermissionLevels()
	{
		return "ä½ çš„æƒé™ä¸è¶³ï¼Œæ— æ³•è¿›å…¥æ­¤åœºæ™¯ã€‚";
	}

	/// <summary>
	/// Key: "Label.GameUnavailablePlaceNotPartOfGame"
	/// English String: "This place is not currently part of a Game. Add it to a game on the {developPageLink} page to make it playable."
	/// </summary>
	public override string LabelGameUnavailablePlaceNotPartOfGame(string developPageLink)
	{
		return $"æ­¤åœºæ™¯å½“å‰ä¸å±žäºŽä»»ä½•æ¸¸æˆã€‚è¯·åœ¨ {developPageLink} é¡µé¢å°†å…¶æ·»åŠ è‡³ä¸€æ¬¾æ¸¸æˆä¸­ï¼Œä½¿å®ƒæˆä¸ºå¯çŽ©çŠ¶æ€ã€‚";
	}

	protected override string _GetTemplateForLabelGameUnavailablePlaceNotPartOfGame()
	{
		return "æ­¤åœºæ™¯å½“å‰ä¸å±žäºŽä»»ä½•æ¸¸æˆã€‚è¯·åœ¨ {developPageLink} é¡µé¢å°†å…¶æ·»åŠ è‡³ä¸€æ¬¾æ¸¸æˆä¸­ï¼Œä½¿å®ƒæˆä¸ºå¯çŽ©çŠ¶æ€ã€‚";
	}

	protected override string _GetTemplateForLabelGameUnavailablePlaceUnderReview()
	{
		return "æŠ±æ­‰ï¼Œæ­¤åœºæ™¯å½“å‰æ­£æŽ¥å—å®¡æ ¸ã€‚è¯·ç¨åŽé‡è¯•ã€‚";
	}

	protected override string _GetTemplateForLabelGameUnavailablePlatform()
	{
		return "æ­¤æ¸¸æˆæ— æ³•å†ä½ çš„å¹³å°ä¸Šè¿è¡Œã€‚è¯·åœ¨æ¸¸æˆé¡µé¢æŸ¥çœ‹å…¨éƒ¨å¯çŽ©çš„æ¸¸æˆã€‚";
	}

	protected override string _GetTemplateForLabelGameWarning()
	{
		return "è­¦å‘Š";
	}

	protected override string _GetTemplateForLabelInstallationInstructions()
	{
		return "å®‰è£…è¯´æ˜Ž";
	}

	protected override string _GetTemplateForLabelLaunchApplication()
	{
		return "å¯åŠ¨åº”ç”¨ç¨‹åº";
	}

	/// <summary>
	/// Key: "Label.OperaInstallSteps"
	/// 1) A window will open. Click Open2) Doubleclick the Roblox icon.
	/// English String: "1) A window will open. Click {startBold}Open{endBold}.{breakLine}2) Doubleclick the Roblox icon."
	/// </summary>
	public override string LabelOperaInstallSteps(string startBold, string endBold, string breakLine)
	{
		return $"1) çª—å£å°†ä¼šæ‰“å¼€ã€‚ç‚¹æŒ‰{startBold}æ‰“å¼€{endBold}ã€‚{breakLine}2) è¿žæŒ‰ Roblox å›¾æ ‡ã€‚";
	}

	protected override string _GetTemplateForLabelOperaInstallSteps()
	{
		return "1) çª—å£å°†ä¼šæ‰“å¼€ã€‚ç‚¹æŒ‰{startBold}æ‰“å¼€{endBold}ã€‚{breakLine}2) è¿žæŒ‰ Roblox å›¾æ ‡ã€‚";
	}

	protected override string _GetTemplateForLabelPersuadeToDevelopRoblox()
	{
		return "å¼€å§‹åˆ›ä½œä½ è‡ªå·±çš„æ¸¸æˆï¼";
	}

	protected override string _GetTemplateForLabelPersuadeToInstallRoblox()
	{
		return "ä½ å¾ˆå¿«å°±è¦è¿›å…¥æ¸¸æˆå•¦ï¼";
	}

	protected override string _GetTemplateForLabelPlay()
	{
		return "å¼€å§‹æ¸¸æˆ";
	}

	protected override string _GetTemplateForLabelPlayInApp()
	{
		return "åœ¨ App ä¸­çŽ©";
	}

	protected override string _GetTemplateForLabelRobloxLoadingToPlay()
	{
		return "æ­£åœ¨åŠ è½½ Robloxã€‚å‡†å¤‡å¥½ï¼Œæ¸¸æˆé©¬ä¸Šå¼€å§‹ï¼";
	}

	protected override string _GetTemplateForLabelStartingRoblox()
	{
		return "æ­£åœ¨å¯åŠ¨ Roblox...";
	}

	protected override string _GetTemplateForLabelSwitchToDesktopMode()
	{
		return "åˆ‡æ¢è‡³æ¡Œé¢æ¨¡å¼";
	}

	protected override string _GetTemplateForLabelUniverseConfigurePageTitle()
	{
		return "é€šç”¨é…ç½®";
	}

	/// <summary>
	/// Key: "Response.CheckAlwaysOpenRoblox"
	/// Check {startBold}Always open links for Roblox{endBold} and click {startBold2}Open Roblox{endBold2} in the dialog box above to join games faster in the future!
	/// English String: "Check {startBold}Always open links for Roblox{endBold} and click {startBold2}Open Roblox{endBold2} in the dialog box above to join games faster in the future!"
	/// </summary>
	public override string ResponseCheckAlwaysOpenRoblox(string startBold, string endBold, string startBold2, string endBold2)
	{
		return $"é€‰ä¸­{startBold}å§‹ç»ˆæ‰“å¼€ Roblox é“¾æŽ¥{endBold}ï¼Œå¹¶åœ¨ä¸Šæ–¹å¯¹è¯æ¡†ä¸­ç‚¹æŒ‰{startBold2}æ‰“å¼€ Roblox{endBold2}ï¼Œä¹‹åŽå°±å¯ä»¥æ›´å¿«åŠ å…¥æ¸¸æˆï¼";
	}

	protected override string _GetTemplateForResponseCheckAlwaysOpenRoblox()
	{
		return "é€‰ä¸­{startBold}å§‹ç»ˆæ‰“å¼€ Roblox é“¾æŽ¥{endBold}ï¼Œå¹¶åœ¨ä¸Šæ–¹å¯¹è¯æ¡†ä¸­ç‚¹æŒ‰{startBold2}æ‰“å¼€ Roblox{endBold2}ï¼Œä¹‹åŽå°±å¯ä»¥æ›´å¿«åŠ å…¥æ¸¸æˆï¼";
	}

	/// <summary>
	/// Key: "Response.CheckAlwaysOpenRobloxURL"
	/// Check {startBold}Always open links for URL: Roblox Protocol{endBold} and click {startBold}Open URL: Roblox Protocol{endBold} in the dialog box above to join games faster in the future!
	/// English String: "Check {startBold}Always open links for URL: Roblox Protocol{endBold} and click {startBold2}Open URL: Roblox Protocol{endBold2} in the dialog box above to join games faster in the future!"
	/// </summary>
	public override string ResponseCheckAlwaysOpenRobloxURL(string startBold, string endBold, string startBold2, string endBold2)
	{
		return $"é€‰ä¸­{startBold}å§‹ç»ˆæ‰“å¼€ URLï¼šRoblox åè®®é“¾æŽ¥{endBold}ï¼Œå¹¶åœ¨ä¸Šæ–¹å¯¹è¯æ¡†ä¸­ç‚¹æŒ‰{startBold2}æ‰“å¼€ URLï¼šRoblox åè®®{endBold2}ï¼Œä¹‹åŽå°±å¯ä»¥æ›´å¿«åŠ å…¥æ¸¸æˆï¼";
	}

	protected override string _GetTemplateForResponseCheckAlwaysOpenRobloxURL()
	{
		return "é€‰ä¸­{startBold}å§‹ç»ˆæ‰“å¼€ URLï¼šRoblox åè®®é“¾æŽ¥{endBold}ï¼Œå¹¶åœ¨ä¸Šæ–¹å¯¹è¯æ¡†ä¸­ç‚¹æŒ‰{startBold2}æ‰“å¼€ URLï¼šRoblox åè®®{endBold2}ï¼Œä¹‹åŽå°±å¯ä»¥æ›´å¿«åŠ å…¥æ¸¸æˆï¼";
	}

	/// <summary>
	/// Key: "Response.CheckRememberMyChoiceOK"
	/// Check Remember my choice and click OK in the dialog box above to join games faster in the future!
	/// English String: "Check {startBold}Remember my choice{endBold} and click {startBold2}OK{endBold2} in the dialog box above to join games faster in the future!"
	/// </summary>
	public override string ResponseCheckRememberMyChoiceOK(string startBold, string endBold, string startBold2, string endBold2)
	{
		return $"é€‰ä¸­{startBold}è®°ä½æˆ‘çš„é€‰æ‹©{endBold}ï¼Œå¹¶åœ¨ä¸Šæ–¹å¯¹è¯æ¡†ä¸­ç‚¹æŒ‰{startBold2}ç¡®å®š{endBold2}ï¼Œä¹‹åŽå°±å¯ä»¥æ›´å¿«åŠ å…¥æ¸¸æˆï¼";
	}

	protected override string _GetTemplateForResponseCheckRememberMyChoiceOK()
	{
		return "é€‰ä¸­{startBold}è®°ä½æˆ‘çš„é€‰æ‹©{endBold}ï¼Œå¹¶åœ¨ä¸Šæ–¹å¯¹è¯æ¡†ä¸­ç‚¹æŒ‰{startBold2}ç¡®å®š{endBold2}ï¼Œä¹‹åŽå°±å¯ä»¥æ›´å¿«åŠ å…¥æ¸¸æˆï¼";
	}

	protected override string _GetTemplateForResponseDialogClickHere()
	{
		return "ç‚¹æŒ‰æ­¤å¤„ï¼";
	}

	protected override string _GetTemplateForResponseDialogErrorLaunching()
	{
		return "å°è¯•å¯åŠ¨æ¸¸æˆæ—¶å‘ç”Ÿé”™è¯¯ã€‚è¯·ç¨åŽé‡è¯•ã€‚";
	}

	protected override string _GetTemplateForResponseDialogHavingTroubleInstallQuestion()
	{
		return "å®‰è£… Roblox æ—¶é‡åˆ°é—®é¢˜ï¼Ÿ";
	}

	/// <summary>
	/// Key: "Response.Dialog.InstallingMessageWithLink"
	/// Note: For this translation, please move the linkStart and linkEnd variables with the translation for download now.
	/// English String: "The Roblox installer should download shortly. If it doesnâ€™t, start the {linkStart}download now.{linkEnd}"
	/// </summary>
	public override string ResponseDialogInstallingMessageWithLink(string linkStart, string linkEnd)
	{
		return $"Roblox å®‰è£…ç¨‹åºå¾ˆå¿«å°±ä¼šå¼€å§‹ä¸‹è½½ã€‚å¦‚æžœä¸‹è½½æ²¡æœ‰å¼€å§‹ï¼Œè¯·æ‰‹åŠ¨{linkStart}å¼€å§‹ä¸‹è½½{linkEnd}ã€‚";
	}

	protected override string _GetTemplateForResponseDialogInstallingMessageWithLink()
	{
		return "Roblox å®‰è£…ç¨‹åºå¾ˆå¿«å°±ä¼šå¼€å§‹ä¸‹è½½ã€‚å¦‚æžœä¸‹è½½æ²¡æœ‰å¼€å§‹ï¼Œè¯·æ‰‹åŠ¨{linkStart}å¼€å§‹ä¸‹è½½{linkEnd}ã€‚";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacChromeFifthInstruction"
	/// After installation, click {startBold}Play{endBold} below to join the action!
	/// English String: "After installation, click {startBold}Play{endBold} below to join the action!"
	/// </summary>
	public override string ResponseDialogMacChromeFifthInstruction(string startBold, string endBold)
	{
		return $"å®‰è£…å®Œæ¯•åŽï¼Œç‚¹æŒ‰ä¸‹é¢çš„{startBold}å¼€å§‹æ¸¸æˆ{endBold}å³å¯åŠ å…¥æ¸¸æˆï¼";
	}

	protected override string _GetTemplateForResponseDialogMacChromeFifthInstruction()
	{
		return "å®‰è£…å®Œæ¯•åŽï¼Œç‚¹æŒ‰ä¸‹é¢çš„{startBold}å¼€å§‹æ¸¸æˆ{endBold}å³å¯åŠ å…¥æ¸¸æˆï¼";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacChromeFirstInstruction"
	/// Click {startBold}Roblox.dmg{endBold} to run the Roblox installer, which just downloaded via your web browser.
	/// English String: "Click {startBold}Roblox.dmg{endBold} to run the Roblox installer, which just downloaded via your web browser."
	/// </summary>
	public override string ResponseDialogMacChromeFirstInstruction(string startBold, string endBold)
	{
		return $"ç‚¹æŒ‰ {startBold}Roblox.dmg{endBold}ï¼Œè¿è¡Œåˆšåˆšé€šè¿‡ç½‘ç»œæµè§ˆå™¨ä¸‹è½½çš„ Roblox å®‰è£…ç¨‹åºã€‚";
	}

	protected override string _GetTemplateForResponseDialogMacChromeFirstInstruction()
	{
		return "ç‚¹æŒ‰ {startBold}Roblox.dmg{endBold}ï¼Œè¿è¡Œåˆšåˆšé€šè¿‡ç½‘ç»œæµè§ˆå™¨ä¸‹è½½çš„ Roblox å®‰è£…ç¨‹åºã€‚";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacChromeFourthInstruction"
	/// Click {startBold}Ok{endBold} once you've successfully installed Roblox.
	/// English String: "Click {startBold}Ok{endBold} once you've successfully installed Roblox."
	/// </summary>
	public override string ResponseDialogMacChromeFourthInstruction(string startBold, string endBold)
	{
		return $"æˆåŠŸå®‰è£… Roblox åŽï¼Œç‚¹æŒ‰{startBold}å¥½{endBold}ã€‚";
	}

	protected override string _GetTemplateForResponseDialogMacChromeFourthInstruction()
	{
		return "æˆåŠŸå®‰è£… Roblox åŽï¼Œç‚¹æŒ‰{startBold}å¥½{endBold}ã€‚";
	}

	protected override string _GetTemplateForResponseDialogMacChromeSecondInstruction()
	{
		return "è¿žæŒ‰ Roblox App å›¾æ ‡ä»¥å¼€å§‹å®‰è£…ç¨‹åºã€‚";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacChromeThirdInstruction"
	/// Click {startBold}Open{endBold} when prompted by your computer.
	/// English String: "Click {startBold}Open{endBold} when prompted by your computer."
	/// </summary>
	public override string ResponseDialogMacChromeThirdInstruction(string startBold, string endBold)
	{
		return $"æŒ‰ä½ çš„ç”µè„‘æç¤ºï¼Œç‚¹æŒ‰{startBold}æ‰“å¼€{endBold}ã€‚";
	}

	protected override string _GetTemplateForResponseDialogMacChromeThirdInstruction()
	{
		return "æŒ‰ä½ çš„ç”µè„‘æç¤ºï¼Œç‚¹æŒ‰{startBold}æ‰“å¼€{endBold}ã€‚";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacFirefoxFifthInstruction"
	/// Then select the Remember my choice... checkbox and click OK
	/// English String: "Then select the {startBold}Remember my choice...{endBold} checkbox and click {startBold2}OK{endBold2}"
	/// </summary>
	public override string ResponseDialogMacFirefoxFifthInstruction(string startBold, string endBold, string startBold2, string endBold2)
	{
		return $"ç„¶åŽé€‰ä¸­{startBold}è®°ä½æˆ‘çš„é€‰æ‹©...{endBold}å¤é€‰æ¡†ï¼Œå¹¶ç‚¹æŒ‰{startBold2}ç¡®å®š{endBold2}";
	}

	protected override string _GetTemplateForResponseDialogMacFirefoxFifthInstruction()
	{
		return "ç„¶åŽé€‰ä¸­{startBold}è®°ä½æˆ‘çš„é€‰æ‹©...{endBold}å¤é€‰æ¡†ï¼Œå¹¶ç‚¹æŒ‰{startBold2}ç¡®å®š{endBold2}";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacFirefoxFirstInstruction"
	/// Select Open with and click OK
	/// English String: "Select {startBold}Open with{endBold} and click {startBold2}OK{endBold2}"
	/// </summary>
	public override string ResponseDialogMacFirefoxFirstInstruction(string startBold, string endBold, string startBold2, string endBold2)
	{
		return $"é€‰æ‹©{startBold}æ‰“å¼€æ–¹å¼{endBold}ï¼Œå¹¶ç‚¹æŒ‰{startBold2}å¥½{endBold2}";
	}

	protected override string _GetTemplateForResponseDialogMacFirefoxFirstInstruction()
	{
		return "é€‰æ‹©{startBold}æ‰“å¼€æ–¹å¼{endBold}ï¼Œå¹¶ç‚¹æŒ‰{startBold2}å¥½{endBold2}";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacFirefoxFourthInstruction"
	/// Once installed, click Play to join the action!
	/// English String: "Once installed, click {startBold}Play{endBold} to join the action!"
	/// </summary>
	public override string ResponseDialogMacFirefoxFourthInstruction(string startBold, string endBold)
	{
		return $"å®‰è£…å®Œæ¯•åŽï¼Œç‚¹æŒ‰{startBold}å¼€å§‹æ¸¸æˆ{endBold}å³å¯è¿›å…¥ Roblox çš„ä¸–ç•Œï¼";
	}

	protected override string _GetTemplateForResponseDialogMacFirefoxFourthInstruction()
	{
		return "å®‰è£…å®Œæ¯•åŽï¼Œç‚¹æŒ‰{startBold}å¼€å§‹æ¸¸æˆ{endBold}å³å¯è¿›å…¥ Roblox çš„ä¸–ç•Œï¼";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacFirefoxSecondInstruction"
	/// Double-click the Roblox Icon to begin the installation process
	/// English String: "Double-click the {startBold}Roblox Icon{endBold} to begin the installation process"
	/// </summary>
	public override string ResponseDialogMacFirefoxSecondInstruction(string startBold, string endBold)
	{
		return $"è¿žæŒ‰ {startBold}Roblox å›¾æ ‡{endBold}ä»¥å¼€å§‹å®‰è£…ç¨‹åº";
	}

	protected override string _GetTemplateForResponseDialogMacFirefoxSecondInstruction()
	{
		return "è¿žæŒ‰ {startBold}Roblox å›¾æ ‡{endBold}ä»¥å¼€å§‹å®‰è£…ç¨‹åº";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacFirefoxThirdInstruction"
	/// You will receive a warning, click Open
	/// English String: "You will receive a warning, click {startBold}Open{endBold}"
	/// </summary>
	public override string ResponseDialogMacFirefoxThirdInstruction(string startBold, string endBold)
	{
		return $"ä½ ä¼šæ”¶åˆ°è­¦å‘Šï¼Œç‚¹æŒ‰{startBold}æ‰“å¼€{endBold}";
	}

	protected override string _GetTemplateForResponseDialogMacFirefoxThirdInstruction()
	{
		return "ä½ ä¼šæ”¶åˆ°è­¦å‘Šï¼Œç‚¹æŒ‰{startBold}æ‰“å¼€{endBold}";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacSafariFirstInstruction"
	/// Go to Downloads and double-click Roblox.dmg
	/// English String: "Go to Downloads and double-click {startBold}Roblox.dmg{endBold}"
	/// </summary>
	public override string ResponseDialogMacSafariFirstInstruction(string startBold, string endBold)
	{
		return $"å‰å¾€â€œä¸‹è½½â€å¹¶è¿žæŒ‰ {startBold}Roblox.dmg{endBold}";
	}

	protected override string _GetTemplateForResponseDialogMacSafariFirstInstruction()
	{
		return "å‰å¾€â€œä¸‹è½½â€å¹¶è¿žæŒ‰ {startBold}Roblox.dmg{endBold}";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacSafariFourthInstruction"
	/// Once installed, click {startBold}Play{endBold} to join the action!
	/// English String: "Once installed, click {startBold}Play{endBold} to join the action!"
	/// </summary>
	public override string ResponseDialogMacSafariFourthInstruction(string startBold, string endBold)
	{
		return $"å®‰è£…å®Œæ¯•åŽï¼Œç‚¹æŒ‰{startBold}å¼€å§‹æ¸¸æˆ{endBold}å³å¯è¿›å…¥ Roblox çš„ä¸–ç•Œï¼";
	}

	protected override string _GetTemplateForResponseDialogMacSafariFourthInstruction()
	{
		return "å®‰è£…å®Œæ¯•åŽï¼Œç‚¹æŒ‰{startBold}å¼€å§‹æ¸¸æˆ{endBold}å³å¯è¿›å…¥ Roblox çš„ä¸–ç•Œï¼";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacSafariSecondInstruction"
	/// Double-click the {startBold}Roblox Icon{endBold} to begin the installation process
	/// English String: "Double-click the {startBold}Roblox Icon{endBold} to begin the installation process"
	/// </summary>
	public override string ResponseDialogMacSafariSecondInstruction(string startBold, string endBold)
	{
		return $"è¿žæŒ‰ {startBold}Roblox å›¾æ ‡{endBold}ä»¥å¼€å§‹å®‰è£…ç¨‹åº";
	}

	protected override string _GetTemplateForResponseDialogMacSafariSecondInstruction()
	{
		return "è¿žæŒ‰ {startBold}Roblox å›¾æ ‡{endBold}ä»¥å¼€å§‹å®‰è£…ç¨‹åº";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacSafariThirdInstruction"
	/// You will receive a warning, click {startBold}Open{endBold}
	/// English String: "You will receive a warning, click {startBold}Open{endBold}"
	/// </summary>
	public override string ResponseDialogMacSafariThirdInstruction(string startBold, string endBold)
	{
		return $"ä½ ä¼šæ”¶åˆ°è­¦å‘Šï¼Œç‚¹æŒ‰{startBold}æ‰“å¼€{endBold}";
	}

	protected override string _GetTemplateForResponseDialogMacSafariThirdInstruction()
	{
		return "ä½ ä¼šæ”¶åˆ°è­¦å‘Šï¼Œç‚¹æŒ‰{startBold}æ‰“å¼€{endBold}";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcChromeFirstInstruction"
	/// Click {startBold}RobloxPlayer.exe{endBold} to run the Roblox installer, which just downloaded via your web browser.
	/// English String: "Click {startBold}RobloxPlayer.exe{endBold} to run the Roblox installer, which just downloaded via your web browser."
	/// </summary>
	public override string ResponseDialogPcChromeFirstInstruction(string startBold, string endBold)
	{
		return $"ç‚¹æŒ‰ {startBold}RobloxPlayer.exe{endBold}ï¼Œè¿è¡Œåˆšåˆšé€šè¿‡ç½‘ç»œæµè§ˆå™¨ä¸‹è½½çš„ Roblox å®‰è£…ç¨‹åºã€‚";
	}

	protected override string _GetTemplateForResponseDialogPcChromeFirstInstruction()
	{
		return "ç‚¹æŒ‰ {startBold}RobloxPlayer.exe{endBold}ï¼Œè¿è¡Œåˆšåˆšé€šè¿‡ç½‘ç»œæµè§ˆå™¨ä¸‹è½½çš„ Roblox å®‰è£…ç¨‹åºã€‚";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcChromeFourthInstruction"
	/// After installation, click {startBold}Play{endBold} below to join the action!
	/// English String: "After installation, click {startBold}Play{endBold} below to join the action!"
	/// </summary>
	public override string ResponseDialogPcChromeFourthInstruction(string startBold, string endBold)
	{
		return $"å®‰è£…å®Œæ¯•åŽï¼Œç‚¹æŒ‰ä¸‹é¢çš„{startBold}å¼€å§‹æ¸¸æˆ{endBold}å³å¯åŠ å…¥æ¸¸æˆï¼";
	}

	protected override string _GetTemplateForResponseDialogPcChromeFourthInstruction()
	{
		return "å®‰è£…å®Œæ¯•åŽï¼Œç‚¹æŒ‰ä¸‹é¢çš„{startBold}å¼€å§‹æ¸¸æˆ{endBold}å³å¯åŠ å…¥æ¸¸æˆï¼";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcChromeSecondInstruction"
	/// Click {startBold}Run{endBold} when prompted by your computer to begin the installation process.
	/// English String: "Click {startBold}Run{endBold} when prompted by your computer to begin the installation process."
	/// </summary>
	public override string ResponseDialogPcChromeSecondInstruction(string startBold, string endBold)
	{
		return $"æŒ‰ç”µè„‘æç¤ºï¼Œç‚¹æŒ‰{startBold}è¿è¡Œ{endBold}ã€‚";
	}

	protected override string _GetTemplateForResponseDialogPcChromeSecondInstruction()
	{
		return "æŒ‰ç”µè„‘æç¤ºï¼Œç‚¹æŒ‰{startBold}è¿è¡Œ{endBold}ã€‚";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcChromeThirdInstruction"
	/// Click {startBold}Ok{endBold} once you've successfully installed Roblox.
	/// English String: "Click {startBold}Ok{endBold} once you've successfully installed Roblox."
	/// </summary>
	public override string ResponseDialogPcChromeThirdInstruction(string startBold, string endBold)
	{
		return $"æˆåŠŸå®‰è£… Roblox åŽï¼Œç‚¹æŒ‰{startBold}ç¡®å®š{endBold}ã€‚";
	}

	protected override string _GetTemplateForResponseDialogPcChromeThirdInstruction()
	{
		return "æˆåŠŸå®‰è£… Roblox åŽï¼Œç‚¹æŒ‰{startBold}ç¡®å®š{endBold}ã€‚";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcEdgeFirstInstruction"
	/// Click {startBold}Run{endBold} to install Roblox after the download finishes
	/// English String: "Click {startBold}Run{endBold} to install Roblox after the download finishes"
	/// </summary>
	public override string ResponseDialogPcEdgeFirstInstruction(string startBold, string endBold)
	{
		return $"ä¸‹è½½ç»“æŸåŽï¼Œç‚¹æŒ‰{startBold}è¿è¡Œ{endBold}å®‰è£… Roblox";
	}

	protected override string _GetTemplateForResponseDialogPcEdgeFirstInstruction()
	{
		return "ä¸‹è½½ç»“æŸåŽï¼Œç‚¹æŒ‰{startBold}è¿è¡Œ{endBold}å®‰è£… Roblox";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcEdgeSecondInstruction"
	/// Click {startBold}Ok{endBold} to finish installing Roblox
	/// English String: "Click {startBold}Ok{endBold} to finish installing Roblox"
	/// </summary>
	public override string ResponseDialogPcEdgeSecondInstruction(string startBold, string endBold)
	{
		return $"ç‚¹æŒ‰{startBold}ç¡®å®š{endBold}ä»¥ç»“æŸå®‰è£… Roblox";
	}

	protected override string _GetTemplateForResponseDialogPcEdgeSecondInstruction()
	{
		return "ç‚¹æŒ‰{startBold}ç¡®å®š{endBold}ä»¥ç»“æŸå®‰è£… Roblox";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcEdgeThirdInstruction"
	/// Click the {startBold}Play{endBold} button to join the action!
	/// English String: "Click the {startBold}Play{endBold} button to join the action!"
	/// </summary>
	public override string ResponseDialogPcEdgeThirdInstruction(string startBold, string endBold)
	{
		return $"ç‚¹æŒ‰{startBold}å¼€å§‹æ¸¸æˆ{endBold}æŒ‰é’®å³å¯åŠ å…¥æ¸¸æˆï¼";
	}

	protected override string _GetTemplateForResponseDialogPcEdgeThirdInstruction()
	{
		return "ç‚¹æŒ‰{startBold}å¼€å§‹æ¸¸æˆ{endBold}æŒ‰é’®å³å¯åŠ å…¥æ¸¸æˆï¼";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcFirefoxFifthInstruction"
	/// Click {startBold}Ok{endBold} when the alert pops up
	/// English String: "Click {startBold}Ok{endBold} when the alert pops up"
	/// </summary>
	public override string ResponseDialogPcFirefoxFifthInstruction(string startBold, string endBold)
	{
		return $"æé†’å¼¹å‡ºæ—¶ï¼Œç‚¹æŒ‰{startBold}ç¡®å®š{endBold}";
	}

	protected override string _GetTemplateForResponseDialogPcFirefoxFifthInstruction()
	{
		return "æé†’å¼¹å‡ºæ—¶ï¼Œç‚¹æŒ‰{startBold}ç¡®å®š{endBold}";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcFirefoxFirstInstruction"
	/// Click {startBold}Save File{endBold} when the download window pops up
	/// English String: "Click {startBold}Save File{endBold} when the download window pops up"
	/// </summary>
	public override string ResponseDialogPcFirefoxFirstInstruction(string startBold, string endBold)
	{
		return $"ä¸‹è½½çª—å£å¼¹å‡ºæ—¶ï¼Œç‚¹æŒ‰{startBold}ä¿å­˜æ–‡ä»¶{endBold}";
	}

	protected override string _GetTemplateForResponseDialogPcFirefoxFirstInstruction()
	{
		return "ä¸‹è½½çª—å£å¼¹å‡ºæ—¶ï¼Œç‚¹æŒ‰{startBold}ä¿å­˜æ–‡ä»¶{endBold}";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcFirefoxFourthInstruction"
	/// Once installed, click {startBold}Play{endBold} to join the action!
	/// English String: "Once installed, click {startBold}Play{endBold} to join the action!"
	/// </summary>
	public override string ResponseDialogPcFirefoxFourthInstruction(string startBold, string endBold)
	{
		return $"å®‰è£…å®Œæ¯•åŽï¼Œç‚¹æŒ‰{startBold}å¼€å§‹æ¸¸æˆ{endBold}å³å¯è¿›å…¥ Roblox çš„ä¸–ç•Œï¼";
	}

	protected override string _GetTemplateForResponseDialogPcFirefoxFourthInstruction()
	{
		return "å®‰è£…å®Œæ¯•åŽï¼Œç‚¹æŒ‰{startBold}å¼€å§‹æ¸¸æˆ{endBold}å³å¯è¿›å…¥ Roblox çš„ä¸–ç•Œï¼";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcFirefoxSecondInstruction"
	/// Go to Downloads and double click {startBold}RobloxPlayer.exe{endBold}
	/// English String: "Go to Downloads and double click {startBold}RobloxPlayer.exe{endBold}"
	/// </summary>
	public override string ResponseDialogPcFirefoxSecondInstruction(string startBold, string endBold)
	{
		return $"å‰å¾€â€œä¸‹è½½â€å¹¶è¿žæŒ‰ {startBold}RobloxPlayer.exe{endBold}";
	}

	protected override string _GetTemplateForResponseDialogPcFirefoxSecondInstruction()
	{
		return "å‰å¾€â€œä¸‹è½½â€å¹¶è¿žæŒ‰ {startBold}RobloxPlayer.exe{endBold}";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcFirefoxThirdInstruction"
	/// Click {startBold}Run{endBold}
	/// English String: "Click {startBold}Run{endBold}"
	/// </summary>
	public override string ResponseDialogPcFirefoxThirdInstruction(string startBold, string endBold)
	{
		return $"ç‚¹æŒ‰{startBold}è¿è¡Œ{endBold}";
	}

	protected override string _GetTemplateForResponseDialogPcFirefoxThirdInstruction()
	{
		return "ç‚¹æŒ‰{startBold}è¿è¡Œ{endBold}";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcIEFirstInstruction"
	/// You will receive a warning, click {startBold}Run{endBold}
	/// English String: "You will receive a warning, click {startBold}Run{endBold}"
	/// </summary>
	public override string ResponseDialogPcIEFirstInstruction(string startBold, string endBold)
	{
		return $"ä½ ä¼šæ”¶åˆ°è­¦å‘Šï¼Œç‚¹æŒ‰{startBold}è¿è¡Œ{endBold}";
	}

	protected override string _GetTemplateForResponseDialogPcIEFirstInstruction()
	{
		return "ä½ ä¼šæ”¶åˆ°è­¦å‘Šï¼Œç‚¹æŒ‰{startBold}è¿è¡Œ{endBold}";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcIeInstructionOne"
	/// You will receive a warning, click {startBold}Run{endBold}
	/// English String: "You will receive a warning, click {startBold}Run{endBold}"
	/// </summary>
	public override string ResponseDialogPcIeInstructionOne(string startBold, string endBold)
	{
		return $"ä½ ä¼šæ”¶åˆ°è­¦å‘Šï¼Œç‚¹æŒ‰{startBold}è¿è¡Œ{endBold}";
	}

	protected override string _GetTemplateForResponseDialogPcIeInstructionOne()
	{
		return "ä½ ä¼šæ”¶åˆ°è­¦å‘Šï¼Œç‚¹æŒ‰{startBold}è¿è¡Œ{endBold}";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcIeInstructionThree"
	/// Click {startBold}Run{endBold}
	/// English String: "Click {startBold}Run{endBold}"
	/// </summary>
	public override string ResponseDialogPcIeInstructionThree(string startBold, string endBold)
	{
		return $"ç‚¹æŒ‰{startBold}è¿è¡Œ{endBold}";
	}

	protected override string _GetTemplateForResponseDialogPcIeInstructionThree()
	{
		return "ç‚¹æŒ‰{startBold}è¿è¡Œ{endBold}";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcIeInstructionTwo"
	/// Go to Downloads and double click {startBold}RobloxPlayer.exe{endBold}
	/// English String: "Go to Downloads and double click {startBold}RobloxPlayer.exe{endBold}"
	/// </summary>
	public override string ResponseDialogPcIeInstructionTwo(string startBold, string endBold)
	{
		return $"å‰å¾€â€œä¸‹è½½â€å¹¶è¿žæŒ‰ {startBold}RobloxPlayer.exe{endBold}";
	}

	protected override string _GetTemplateForResponseDialogPcIeInstructionTwo()
	{
		return "å‰å¾€â€œä¸‹è½½â€å¹¶è¿žæŒ‰ {startBold}RobloxPlayer.exe{endBold}";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcIESecondInstruction"
	/// Click {startBold}Ok{endBold} once you've installed Roblox
	/// English String: "Click {startBold}Ok{endBold} once you've installed Roblox"
	/// </summary>
	public override string ResponseDialogPcIESecondInstruction(string startBold, string endBold)
	{
		return $"å®‰è£… Roblox åŽï¼Œç‚¹æŒ‰{startBold}ç¡®å®š{endBold}";
	}

	protected override string _GetTemplateForResponseDialogPcIESecondInstruction()
	{
		return "å®‰è£… Roblox åŽï¼Œç‚¹æŒ‰{startBold}ç¡®å®š{endBold}";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcIEThirdInstruction"
	/// Once installed, click {startBold}Play{endBold} to join the action!
	/// English String: "Once installed, click {startBold}Play{endBold} to join the action!"
	/// </summary>
	public override string ResponseDialogPcIEThirdInstruction(string startBold, string endBold)
	{
		return $"å®‰è£…å®Œæ¯•åŽï¼Œç‚¹æŒ‰{startBold}å¼€å§‹æ¸¸æˆ{endBold}å³å¯è¿›å…¥ Roblox çš„ä¸–ç•Œï¼";
	}

	protected override string _GetTemplateForResponseDialogPcIEThirdInstruction()
	{
		return "å®‰è£…å®Œæ¯•åŽï¼Œç‚¹æŒ‰{startBold}å¼€å§‹æ¸¸æˆ{endBold}å³å¯è¿›å…¥ Roblox çš„ä¸–ç•Œï¼";
	}

	protected override string _GetTemplateForResponseDialogThanksForPlayingRoblox()
	{
		return "è°¢è°¢ä½ çŽ© Roblox";
	}

	protected override string _GetTemplateForResponseGameTemporarilyUnavailable()
	{
		return "æ— æ³•éªŒè¯ä½ æ˜¯å¦æœ‰æƒè®¿é—®æ­¤æ¸¸æˆã€‚è¯·ç¨åŽé‡è¯•ã€‚";
	}

	/// <summary>
	/// Key: "Response.RememberMyChoiceAppLaunch"
	/// Check {startBold}Remember my choice{endBold} and click {appLaunchLink} in the dialog box above to join games faster in the future!
	/// English String: "Check {startBold}Remember my choice{endBold} and click {appLaunchLink} in the dialog box above to join games faster in the future!"
	/// </summary>
	public override string ResponseRememberMyChoiceAppLaunch(string startBold, string endBold, string appLaunchLink)
	{
		return $"é€‰ä¸­{startBold}è®°ä½æˆ‘çš„é€‰æ‹©{endBold}ï¼Œå¹¶ç‚¹æŒ‰ä¸Šæ–¹å¯¹è¯æ¡†ä¸­çš„{appLaunchLink}ï¼Œä¹‹åŽå°±å¯ä»¥æ›´å¿«åŠ å…¥æ¸¸æˆï¼";
	}

	protected override string _GetTemplateForResponseRememberMyChoiceAppLaunch()
	{
		return "é€‰ä¸­{startBold}è®°ä½æˆ‘çš„é€‰æ‹©{endBold}ï¼Œå¹¶ç‚¹æŒ‰ä¸Šæ–¹å¯¹è¯æ¡†ä¸­çš„{appLaunchLink}ï¼Œä¹‹åŽå°±å¯ä»¥æ›´å¿«åŠ å…¥æ¸¸æˆï¼";
	}
}


}
