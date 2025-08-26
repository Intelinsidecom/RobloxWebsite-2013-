namespace Roblox.Platform.TranslationResources.Common {
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
	public override string ActionRetry => "å†è©¦è¡Œ";

	/// <summary>
	/// Key: "Heading.ErrorStartingGame"
	/// Error starting game
	/// English String: "Error starting game"
	/// </summary>
	public override string HeadingErrorStartingGame => "ã‚²ãƒ¼ãƒ ã®èµ·å‹•ä¸­ã«ã‚¨ãƒ©ãƒ¼ãŒç™ºç”Ÿã—ã¾ã—ãŸ";

	/// <summary>
	/// Key: "Heading.SwitchToDesktopToPlay"
	/// Switch to Desktop Mode to Play Games
	/// English String: "Switch to Desktop Mode to Play Games"
	/// </summary>
	public override string HeadingSwitchToDesktopToPlay => "ãƒ‡ã‚¹ã‚¯ãƒˆãƒƒãƒ—ãƒ¢ãƒ¼ãƒ‰ã«åˆ‡ã‚Šæ›¿ãˆã¦ã‚²ãƒ¼ãƒ ã‚’ãƒ—ãƒ¬ã‚¤ã™ã‚‹";

	/// <summary>
	/// Key: "Label.Cancel"
	/// Cancel
	/// English String: "Cancel"
	/// </summary>
	public override string LabelCancel => "ã‚­ãƒ£ãƒ³ã‚»ãƒ«";

	/// <summary>
	/// Key: "Label.CheckingForStudio"
	/// We are checking if user has Roblox Studio installed
	/// English String: "Checking for Roblox Studio..."
	/// </summary>
	public override string LabelCheckingForStudio => "Roblox Studioã‚’ç¢ºèªä¸­...";

	/// <summary>
	/// Key: "Label.ClickHereForHelp"
	/// Click here for help
	/// English String: "Click here for help"
	/// </summary>
	public override string LabelClickHereForHelp => "ãƒ˜ãƒ«ãƒ—ã¯ã“ã¡ã‚‰ã‚’ã‚¯ãƒªãƒƒã‚¯";

	/// <summary>
	/// Key: "Label.ConnectingToPlayers"
	/// Joining a game network with other players
	/// English String: "Connecting to Players..."
	/// </summary>
	public override string LabelConnectingToPlayers => "ãƒ—ãƒ¬ã‚¤ãƒ¤ãƒ¼ã«æŽ¥ç¶šä¸­...";

	/// <summary>
	/// Key: "Label.DevelopPageTitle"
	/// English String: "Develop"
	/// </summary>
	public override string LabelDevelopPageTitle => "é–‹ç™º";

	/// <summary>
	/// Key: "Label.DownloadInstallRoblox"
	/// Download and Install Roblox
	/// English String: "Download and Install Roblox"
	/// </summary>
	public override string LabelDownloadInstallRoblox => "Robloxã®ãƒ€ã‚¦ãƒ³ãƒ­ãƒ¼ãƒ‰ã¨ã‚¤ãƒ³ã‚¹ãƒˆãƒ¼ãƒ«";

	/// <summary>
	/// Key: "Label.DownloadStudio"
	/// Download Roblox Studio to start creating games
	/// English String: "Download Studio"
	/// </summary>
	public override string LabelDownloadStudio => "Studioã‚’ãƒ€ã‚¦ãƒ³ãƒ­ãƒ¼ãƒ‰";

	/// <summary>
	/// Key: "Label.GameConfigurePageTitle"
	/// English String: "Game Configure"
	/// </summary>
	public override string LabelGameConfigurePageTitle => "ã‚²ãƒ¼ãƒ ç’°å¢ƒè¨­å®š";

	/// <summary>
	/// Key: "Label.GameFreeSoothsayer"
	/// English String: "Free because you are a soothsayer"
	/// </summary>
	public override string LabelGameFreeSoothsayer => "ã‚ãªãŸã¯é­”æ³•ä½¿ã„ãªã®ã§ç„¡æ–™ã§ã™";

	/// <summary>
	/// Key: "Label.GameUnavailableAccountResrictions"
	/// English String: "The game is unavailable due to account restrictions settings."
	/// </summary>
	public override string LabelGameUnavailableAccountResrictions => "ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã®åˆ¶é™è¨­å®šã«ã‚ˆã‚Šã€ã“ã®ã‚²ãƒ¼ãƒ ã¯åˆ©ç”¨ã§ãã¾ã›ã‚“ã€‚";

	/// <summary>
	/// Key: "Label.GameUnavailableCannotPlayGamesStudio"
	/// English String: "You cannot play games from Studio. Please use a web browser to play this game."
	/// </summary>
	public override string LabelGameUnavailableCannotPlayGamesStudio => "Studioã§ã‚²ãƒ¼ãƒ ã‚’ãƒ—ãƒ¬ã‚¤ã§ãã¾ã›ã‚“ã€‚ã“ã®ã‚²ãƒ¼ãƒ ã‚’ãƒ—ãƒ¬ã‚¤ã™ã‚‹ã«ã¯ã€ã‚¦ã‚§ãƒ–ãƒ–ãƒ©ã‚¦ã‚¶ã‚’ä½¿ã£ã¦ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Label.GameUnavailableClosedToVisitors"
	/// English String: "Sorry, this place is currently closed to visitors."
	/// </summary>
	public override string LabelGameUnavailableClosedToVisitors => "ç”³ã—è¨³ã‚ã‚Šã¾ã›ã‚“ãŒã€ã“ã®ãƒ—ãƒ¬ãƒ¼ã‚¹ã¯ç¾åœ¨è¨ªå•è€…ã‚’å—ã‘ä»˜ã‘ã¦ã„ã¾ã›ã‚“ã€‚";

	/// <summary>
	/// Key: "Label.GameUnavailableCurrentlyIsPrivateVisitor"
	/// When a game is private, this message is shown to visitors.
	/// English String: "Sorry, this game is private."
	/// </summary>
	public override string LabelGameUnavailableCurrentlyIsPrivateVisitor => "ç”³ã—è¨³ã‚ã‚Šã¾ã›ã‚“ãŒã€ã“ã®ã‚²ãƒ¼ãƒ ã¯ãƒ—ãƒ©ã‚¤ãƒ™ãƒ¼ãƒˆè¨­å®šã«ãªã£ã¦ã„ã¾ã™ã€‚";

	/// <summary>
	/// Key: "Label.GameUnavailableGameInsecure"
	/// U13 users cannot play insecure games unless they are the creator or friends with the creator.
	/// English String: "Sorry, your account is restricted from playing Experimental Games unless you are friends with the creator."
	/// </summary>
	public override string LabelGameUnavailableGameInsecure => "ç”³ã—è¨³ã‚ã‚Šã¾ã›ã‚“ãŒã€ã‚ãªãŸã®ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã¯ã€ã‚¯ãƒªã‚¨ãƒ¼ã‚¿ãƒ¼ã¨å‹é”ã§ãªã„å ´åˆã€è©¦é¨“ã‚²ãƒ¼ãƒ ã®ãƒ—ãƒ¬ã‚¤ãŒåˆ¶é™ã•ã‚Œã¦ã„ã¾ã™ã€‚";

	/// <summary>
	/// Key: "Label.GameUnavailablePermissionLevels"
	/// English String: "The permission levels on this place prevent you from entering."
	/// </summary>
	public override string LabelGameUnavailablePermissionLevels => "ã“ã®ãƒ—ãƒ¬ãƒ¼ã‚¹ã®è¨±å¯ãƒ¬ãƒ™ãƒ«ã«ã‚ˆã‚Šã€ã“ã®ãƒ—ãƒ¬ãƒ¼ã‚¹ã«ã¯å…¥ã‚Œã¾ã›ã‚“ã€‚";

	/// <summary>
	/// Key: "Label.GameUnavailablePlaceUnderReview"
	/// English String: "Sorry, this place is currently under review. Try again later."
	/// </summary>
	public override string LabelGameUnavailablePlaceUnderReview => "ç”³ã—è¨³ã‚ã‚Šã¾ã›ã‚“ãŒã€ã“ã®ãƒ—ãƒ¬ãƒ¼ã‚¹ã¯ç¾åœ¨ãƒ¬ãƒ“ãƒ¥ãƒ¼ä¸­ã§ã™ã€‚å¾Œã§ã‚‚ã†ä¸€åº¦ãŠè©¦ã—ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Label.GameUnavailablePlatform"
	/// English String: "This game is not available on your platform.  Check the games page to see all playable games."
	/// </summary>
	public override string LabelGameUnavailablePlatform => "ã“ã®ã‚²ãƒ¼ãƒ ã¯ã‚ãªãŸã®ãƒ—ãƒ©ãƒƒãƒˆãƒ•ã‚©ãƒ¼ãƒ ã§ã¯åˆ©ç”¨ã§ãã¾ã›ã‚“ã€‚ãƒ—ãƒ¬ã‚¤ã§ãã‚‹ã‚²ãƒ¼ãƒ ã«ã¤ã„ã¦ã¯ã€ã‚²ãƒ¼ãƒ ãƒšãƒ¼ã‚¸ã§ãƒã‚§ãƒƒã‚¯ã—ã¦ãã ã•ã„ã€‚";

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
	public override string LabelInstallationInstructions => "ã‚¤ãƒ³ã‚¹ãƒˆãƒ¼ãƒ«æ–¹æ³•";

	/// <summary>
	/// Key: "Label.LaunchApplication"
	/// Launch Application
	/// English String: "Launch Application"
	/// </summary>
	public override string LabelLaunchApplication => "ã‚¢ãƒ—ãƒªã‚’èµ·å‹•";

	/// <summary>
	/// Key: "Label.PersuadeToDevelopRoblox"
	/// Persuade user to begin developing their own games using Roblox Studio
	/// English String: "Get started creating your own games!"
	/// </summary>
	public override string LabelPersuadeToDevelopRoblox => "è‡ªåˆ†ã®ã‚²ãƒ¼ãƒ ã‚’åˆ¶ä½œã—ã¦ã¿ã‚ˆã†ï¼";

	/// <summary>
	/// Key: "Label.PersuadeToInstallRoblox"
	/// We are exciting the user about Roblox so that they will be persuaded to download and install it.
	/// English String: "You're moments away from getting into the game!"
	/// </summary>
	public override string LabelPersuadeToInstallRoblox => "ã‚²ãƒ¼ãƒ ã«å‚åŠ ã§ãã‚‹ã‚ˆã†ã«ãªã‚‹ã¾ã§ã€ã‚ã¨å°‘ã—ã§ã™ï¼";

	/// <summary>
	/// Key: "Label.Play"
	/// English String: "Play"
	/// </summary>
	public override string LabelPlay => "ãƒ—ãƒ¬ã‚¤";

	/// <summary>
	/// Key: "Label.PlayInApp"
	/// English String: "Play in App"
	/// </summary>
	public override string LabelPlayInApp => "ã‚¢ãƒ—ãƒªã§ãƒ—ãƒ¬ã‚¤ã™ã‚‹";

	/// <summary>
	/// Key: "Label.RobloxLoadingToPlay"
	/// Roblox is loading, so the user is getting excited to start playing a game
	/// English String: "Roblox is now loading. Get ready to play!"
	/// </summary>
	public override string LabelRobloxLoadingToPlay => "Robloxã‚’èª­ã¿è¾¼ã‚“ã§ã„ã¾ã™ã€‚ãƒ—ãƒ¬ã‚¤ã®æº–å‚™ã‚’ã—ã‚ˆã†ï¼";

	/// <summary>
	/// Key: "Label.StartingRoblox"
	/// Game launch process has started
	/// English String: "Starting Roblox..."
	/// </summary>
	public override string LabelStartingRoblox => "Robloxã‚’é–‹å§‹ä¸­...";

	/// <summary>
	/// Key: "Label.SwitchToDesktopMode"
	/// Switch to Desktop Mode
	/// English String: "Switch to Desktop Mode"
	/// </summary>
	public override string LabelSwitchToDesktopMode => "ãƒ‡ã‚¹ã‚¯ãƒˆãƒƒãƒ—ãƒ¢ãƒ¼ãƒ‰ã«åˆ‡ã‚Šæ›¿ãˆã‚‹";

	/// <summary>
	/// Key: "Label.UniverseConfigurePageTitle"
	/// The name of the universe configuration page
	/// English String: "Universe Configuration"
	/// </summary>
	public override string LabelUniverseConfigurePageTitle => "ãƒ¦ãƒ‹ãƒãƒ¼ã‚¹ç’°å¢ƒè¨­å®š";

	/// <summary>
	/// Key: "Response.Dialog.ClickHere"
	/// Click here!
	/// English String: "Click here!"
	/// </summary>
	public override string ResponseDialogClickHere => "ã“ã¡ã‚‰ã‚’ã‚¯ãƒªãƒƒã‚¯ã—ã¦ãã ã•ã„ï¼";

	/// <summary>
	/// Key: "Response.Dialog.ErrorLaunching"
	/// An error occurred trying to launch the game.  Please try again later.
	/// English String: "An error occurred trying to launch the game.  Please try again later."
	/// </summary>
	public override string ResponseDialogErrorLaunching => "ã‚²ãƒ¼ãƒ ã®èµ·å‹•ä¸­ã«ã‚¨ãƒ©ãƒ¼ãŒç™ºç”Ÿã—ã¾ã—ãŸã€‚å¾Œã§ã‚‚ã†ä¸€åº¦ãŠè©¦ã—ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Response.Dialog.HavingTroubleInstallQuestion"
	/// (Are you) having trouble installing Roblox?
	/// English String: "Having trouble installing Roblox?"
	/// </summary>
	public override string ResponseDialogHavingTroubleInstallQuestion => "Robloxã®ã‚¤ãƒ³ã‚¹ãƒˆãƒ¼ãƒ«ãŒã§ããªã„å ´åˆã€‚";

	/// <summary>
	/// Key: "Response.Dialog.MacChromeSecondInstruction"
	/// Double-click the Roblox app icon to begin the installation process.
	/// English String: "Double-click the Roblox app icon to begin the installation process."
	/// </summary>
	public override string ResponseDialogMacChromeSecondInstruction => "Robloxã‚¢ãƒ—ãƒªã‚¢ã‚¤ã‚³ãƒ³ã‚’ãƒ€ãƒ–ãƒ«ã‚¯ãƒªãƒƒã‚¯ã—ã¦ã€ã‚¤ãƒ³ã‚¹ãƒˆãƒ¼ãƒ«ãƒ—ãƒ­ã‚»ã‚¹ã‚’é–‹å§‹ã€‚";

	/// <summary>
	/// Key: "Response.Dialog.ThanksForPlayingRoblox"
	/// Thanks for playing Roblox
	/// English String: "Thanks for playing Roblox"
	/// </summary>
	public override string ResponseDialogThanksForPlayingRoblox => "Robloxã‚’ãƒ—ãƒ¬ã‚¤ã—ã¦ã„ãŸã ãã‚ã‚ŠãŒã¨ã†ã”ã–ã„ã¾ã™";

	/// <summary>
	/// Key: "Response.GameTemporarilyUnavailable"
	/// error message (will be followed by link with Action.Retry label)
	/// English String: "Unable to verify that you have access to this game.  Please try again later."
	/// </summary>
	public override string ResponseGameTemporarilyUnavailable => "ã“ã®ã‚²ãƒ¼ãƒ ã¸ã®ã‚¢ã‚¯ã‚»ã‚¹æ¨©ã‚’èªè¨¼ã§ãã¾ã›ã‚“ã€‚å¾Œã§å†è©¦è¡Œã—ã¦ãã ã•ã„ã€‚";

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
		return $"{warning} ã“ã®ã‚²ãƒ¼ãƒ ã¯ã€ãŠä½¿ã„ã®ãƒ‡ãƒã‚¤ã‚¹ã§ã¯ã€ã†ã¾ãä½œå‹•ã—ãªã„å¯èƒ½æ€§ãŒã‚ã‚Šã¾ã™ã€‚";
	}

	protected override string _GetTemplateForActionGamePerformPoorly()
	{
		return "{warning} ã“ã®ã‚²ãƒ¼ãƒ ã¯ã€ãŠä½¿ã„ã®ãƒ‡ãƒã‚¤ã‚¹ã§ã¯ã€ã†ã¾ãä½œå‹•ã—ãªã„å¯èƒ½æ€§ãŒã‚ã‚Šã¾ã™ã€‚";
	}

	protected override string _GetTemplateForActionRetry()
	{
		return "å†è©¦è¡Œ";
	}

	protected override string _GetTemplateForHeadingErrorStartingGame()
	{
		return "ã‚²ãƒ¼ãƒ ã®èµ·å‹•ä¸­ã«ã‚¨ãƒ©ãƒ¼ãŒç™ºç”Ÿã—ã¾ã—ãŸ";
	}

	protected override string _GetTemplateForHeadingSwitchToDesktopToPlay()
	{
		return "ãƒ‡ã‚¹ã‚¯ãƒˆãƒƒãƒ—ãƒ¢ãƒ¼ãƒ‰ã«åˆ‡ã‚Šæ›¿ãˆã¦ã‚²ãƒ¼ãƒ ã‚’ãƒ—ãƒ¬ã‚¤ã™ã‚‹";
	}

	/// <summary>
	/// Key: "Label.BuyAccess"
	/// English String: "Buy Access for {robux} Robux"
	/// </summary>
	public override string LabelBuyAccess(string robux)
	{
		return $"{robux} Robux ã§ã‚¢ã‚¯ã‚»ã‚¹ã‚’è²·ã†";
	}

	protected override string _GetTemplateForLabelBuyAccess()
	{
		return "{robux} Robux ã§ã‚¢ã‚¯ã‚»ã‚¹ã‚’è²·ã†";
	}

	protected override string _GetTemplateForLabelCancel()
	{
		return "ã‚­ãƒ£ãƒ³ã‚»ãƒ«";
	}

	protected override string _GetTemplateForLabelCheckingForStudio()
	{
		return "Roblox Studioã‚’ç¢ºèªä¸­...";
	}

	protected override string _GetTemplateForLabelClickHereForHelp()
	{
		return "ãƒ˜ãƒ«ãƒ—ã¯ã“ã¡ã‚‰ã‚’ã‚¯ãƒªãƒƒã‚¯";
	}

	protected override string _GetTemplateForLabelConnectingToPlayers()
	{
		return "ãƒ—ãƒ¬ã‚¤ãƒ¤ãƒ¼ã«æŽ¥ç¶šä¸­...";
	}

	protected override string _GetTemplateForLabelDevelopPageTitle()
	{
		return "é–‹ç™º";
	}

	protected override string _GetTemplateForLabelDownloadInstallRoblox()
	{
		return "Robloxã®ãƒ€ã‚¦ãƒ³ãƒ­ãƒ¼ãƒ‰ã¨ã‚¤ãƒ³ã‚¹ãƒˆãƒ¼ãƒ«";
	}

	protected override string _GetTemplateForLabelDownloadStudio()
	{
		return "Studioã‚’ãƒ€ã‚¦ãƒ³ãƒ­ãƒ¼ãƒ‰";
	}

	protected override string _GetTemplateForLabelGameConfigurePageTitle()
	{
		return "ã‚²ãƒ¼ãƒ ç’°å¢ƒè¨­å®š";
	}

	protected override string _GetTemplateForLabelGameFreeSoothsayer()
	{
		return "ã‚ãªãŸã¯é­”æ³•ä½¿ã„ãªã®ã§ç„¡æ–™ã§ã™";
	}

	/// <summary>
	/// Key: "Label.GameIsPrivatePlayableByGroupOnly"
	/// When a game is private, this message is shown to group developers with a link from where it can be made public.
	/// English String: "Only developers can play because this game is private. Make it public on the {linkStart}Configure Game{linkEnd} page."
	/// </summary>
	public override string LabelGameIsPrivatePlayableByGroupOnly(string linkStart, string linkEnd)
	{
		return $"ã“ã®ã‚²ãƒ¼ãƒ ã¯ç¾åœ¨ã€ãƒ—ãƒ©ã‚¤ãƒ™ãƒ¼ãƒˆè¨­å®šã«ãªã£ã¦ã„ã‚‹ãŸã‚ã€é–‹ç™ºè€…ã—ã‹ãƒ—ãƒ¬ã‚¤ã§ãã¾ã›ã‚“ã€‚{linkStart}ã‚²ãƒ¼ãƒ ç’°å¢ƒè¨­å®š{linkEnd}ãƒšãƒ¼ã‚¸ã§å…¬é–‹ã—ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForLabelGameIsPrivatePlayableByGroupOnly()
	{
		return "ã“ã®ã‚²ãƒ¼ãƒ ã¯ç¾åœ¨ã€ãƒ—ãƒ©ã‚¤ãƒ™ãƒ¼ãƒˆè¨­å®šã«ãªã£ã¦ã„ã‚‹ãŸã‚ã€é–‹ç™ºè€…ã—ã‹ãƒ—ãƒ¬ã‚¤ã§ãã¾ã›ã‚“ã€‚{linkStart}ã‚²ãƒ¼ãƒ ç’°å¢ƒè¨­å®š{linkEnd}ãƒšãƒ¼ã‚¸ã§å…¬é–‹ã—ã¦ãã ã•ã„ã€‚";
	}

	/// <summary>
	/// Key: "Label.GameIsPrivatePlayableByOwnerOnly"
	/// When a game is private, this message is shown to owner with a link from where it can be made public.
	/// English String: "Only you can play because this game is private. Make it public on the {linkStart}Configure Game{linkEnd} page."
	/// </summary>
	public override string LabelGameIsPrivatePlayableByOwnerOnly(string linkStart, string linkEnd)
	{
		return $"ã“ã®ã‚²ãƒ¼ãƒ ã¯ç¾åœ¨ã€ãƒ—ãƒ©ã‚¤ãƒ™ãƒ¼ãƒˆè¨­å®šã«ãªã£ã¦ã„ã‚‹ãŸã‚ã€ã‚ãªãŸã—ã‹ãƒ—ãƒ¬ã‚¤ã§ãã¾ã›ã‚“ã€‚{linkStart}ã‚²ãƒ¼ãƒ ç’°å¢ƒè¨­å®š{linkEnd}ãƒšãƒ¼ã‚¸ã§å…¬é–‹ã—ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForLabelGameIsPrivatePlayableByOwnerOnly()
	{
		return "ã“ã®ã‚²ãƒ¼ãƒ ã¯ç¾åœ¨ã€ãƒ—ãƒ©ã‚¤ãƒ™ãƒ¼ãƒˆè¨­å®šã«ãªã£ã¦ã„ã‚‹ãŸã‚ã€ã‚ãªãŸã—ã‹ãƒ—ãƒ¬ã‚¤ã§ãã¾ã›ã‚“ã€‚{linkStart}ã‚²ãƒ¼ãƒ ç’°å¢ƒè¨­å®š{linkEnd}ãƒšãƒ¼ã‚¸ã§å…¬é–‹ã—ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForLabelGameUnavailableAccountResrictions()
	{
		return "ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã®åˆ¶é™è¨­å®šã«ã‚ˆã‚Šã€ã“ã®ã‚²ãƒ¼ãƒ ã¯åˆ©ç”¨ã§ãã¾ã›ã‚“ã€‚";
	}

	protected override string _GetTemplateForLabelGameUnavailableCannotPlayGamesStudio()
	{
		return "Studioã§ã‚²ãƒ¼ãƒ ã‚’ãƒ—ãƒ¬ã‚¤ã§ãã¾ã›ã‚“ã€‚ã“ã®ã‚²ãƒ¼ãƒ ã‚’ãƒ—ãƒ¬ã‚¤ã™ã‚‹ã«ã¯ã€ã‚¦ã‚§ãƒ–ãƒ–ãƒ©ã‚¦ã‚¶ã‚’ä½¿ã£ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForLabelGameUnavailableClosedToVisitors()
	{
		return "ç”³ã—è¨³ã‚ã‚Šã¾ã›ã‚“ãŒã€ã“ã®ãƒ—ãƒ¬ãƒ¼ã‚¹ã¯ç¾åœ¨è¨ªå•è€…ã‚’å—ã‘ä»˜ã‘ã¦ã„ã¾ã›ã‚“ã€‚";
	}

	/// <summary>
	/// Key: "Label.GameUnavailableCurrentlyIsPrivateGroup"
	/// When a game is private, this message is shown to group developers with a link from where it can be made public. Similar to an existing translation. Change is making the message directly address the group developers.
	/// English String: "Only developers can play because this game is private. Make it public on the {linkStart}Develop{linkEnd} page."
	/// </summary>
	public override string LabelGameUnavailableCurrentlyIsPrivateGroup(string linkStart, string linkEnd)
	{
		return $"ã“ã®ã‚²ãƒ¼ãƒ ã¯ç¾åœ¨ã€ãƒ—ãƒ©ã‚¤ãƒ™ãƒ¼ãƒˆè¨­å®šã«ãªã£ã¦ã„ã‚‹ãŸã‚ã€é–‹ç™ºè€…ã—ã‹ãƒ—ãƒ¬ã‚¤ã§ãã¾ã›ã‚“ã€‚{linkStart}é–‹ç™º{linkEnd}ãƒšãƒ¼ã‚¸ã§å…¬é–‹ã—ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForLabelGameUnavailableCurrentlyIsPrivateGroup()
	{
		return "ã“ã®ã‚²ãƒ¼ãƒ ã¯ç¾åœ¨ã€ãƒ—ãƒ©ã‚¤ãƒ™ãƒ¼ãƒˆè¨­å®šã«ãªã£ã¦ã„ã‚‹ãŸã‚ã€é–‹ç™ºè€…ã—ã‹ãƒ—ãƒ¬ã‚¤ã§ãã¾ã›ã‚“ã€‚{linkStart}é–‹ç™º{linkEnd}ãƒšãƒ¼ã‚¸ã§å…¬é–‹ã—ã¦ãã ã•ã„ã€‚";
	}

	/// <summary>
	/// Key: "Label.GameUnavailableCurrentlyIsPrivateOwner"
	/// When a game is private, this message is shown to owner with a link from where it can be made public. Similar to an existing translation. Change is making the message directly address the owner.
	/// English String: "Only you can play because this game is private. Make it public on the {linkStart}Develop{linkEnd} page."
	/// </summary>
	public override string LabelGameUnavailableCurrentlyIsPrivateOwner(string linkStart, string linkEnd)
	{
		return $"ã“ã®ã‚²ãƒ¼ãƒ ã¯ç¾åœ¨ã€ãƒ—ãƒ©ã‚¤ãƒ™ãƒ¼ãƒˆè¨­å®šã«ãªã£ã¦ã„ã‚‹ãŸã‚ã€ã‚ãªãŸã—ã‹ãƒ—ãƒ¬ã‚¤ã§ãã¾ã›ã‚“ã€‚{linkStart}é–‹ç™º{linkEnd}ãƒšãƒ¼ã‚¸ã§å…¬é–‹ã—ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForLabelGameUnavailableCurrentlyIsPrivateOwner()
	{
		return "ã“ã®ã‚²ãƒ¼ãƒ ã¯ç¾åœ¨ã€ãƒ—ãƒ©ã‚¤ãƒ™ãƒ¼ãƒˆè¨­å®šã«ãªã£ã¦ã„ã‚‹ãŸã‚ã€ã‚ãªãŸã—ã‹ãƒ—ãƒ¬ã‚¤ã§ãã¾ã›ã‚“ã€‚{linkStart}é–‹ç™º{linkEnd}ãƒšãƒ¼ã‚¸ã§å…¬é–‹ã—ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForLabelGameUnavailableCurrentlyIsPrivateVisitor()
	{
		return "ç”³ã—è¨³ã‚ã‚Šã¾ã›ã‚“ãŒã€ã“ã®ã‚²ãƒ¼ãƒ ã¯ãƒ—ãƒ©ã‚¤ãƒ™ãƒ¼ãƒˆè¨­å®šã«ãªã£ã¦ã„ã¾ã™ã€‚";
	}

	/// <summary>
	/// Key: "Label.GameUnavailableCurrentlyPrivate"
	/// When a game is private, this message is shown to user with link from where it can be made public
	/// English String: "This {gameTypeName} is currently private. Make it public on the {developPageLink} page to make it playable."
	/// </summary>
	public override string LabelGameUnavailableCurrentlyPrivate(string gameTypeName, string developPageLink)
	{
		return $"{gameTypeName} ã¯ç¾åœ¨ã€ãƒ—ãƒ©ã‚¤ãƒ™ãƒ¼ãƒˆã«è¨­å®šã«ãªã£ã¦ã„ã¾ã™ã€‚ãƒ—ãƒ¬ã‚¤ã§ãã‚‹ã‚ˆã†ã«ã™ã‚‹ã«ã¯ã€{developPageLink} ãƒšãƒ¼ã‚¸ã§å…¬é–‹ã—ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForLabelGameUnavailableCurrentlyPrivate()
	{
		return "{gameTypeName} ã¯ç¾åœ¨ã€ãƒ—ãƒ©ã‚¤ãƒ™ãƒ¼ãƒˆã«è¨­å®šã«ãªã£ã¦ã„ã¾ã™ã€‚ãƒ—ãƒ¬ã‚¤ã§ãã‚‹ã‚ˆã†ã«ã™ã‚‹ã«ã¯ã€{developPageLink} ãƒšãƒ¼ã‚¸ã§å…¬é–‹ã—ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForLabelGameUnavailableGameInsecure()
	{
		return "ç”³ã—è¨³ã‚ã‚Šã¾ã›ã‚“ãŒã€ã‚ãªãŸã®ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã¯ã€ã‚¯ãƒªã‚¨ãƒ¼ã‚¿ãƒ¼ã¨å‹é”ã§ãªã„å ´åˆã€è©¦é¨“ã‚²ãƒ¼ãƒ ã®ãƒ—ãƒ¬ã‚¤ãŒåˆ¶é™ã•ã‚Œã¦ã„ã¾ã™ã€‚";
	}

	/// <summary>
	/// Key: "Label.GameUnavailableNoRootPlace"
	/// English String: "This place is part of a game that has no root place. Add a root place on the {gameConfigureLink} page to make it playable."
	/// </summary>
	public override string LabelGameUnavailableNoRootPlace(string gameConfigureLink)
	{
		return $"ã“ã®ãƒ—ãƒ¬ãƒ¼ã‚¹ã¯ã€ãƒ«ãƒ¼ãƒˆãƒ—ãƒ¬ã‚¤ã‚¹ã®è¨­å®šã•ã‚Œã¦ã„ãªã„ã‚²ãƒ¼ãƒ ã®ä¸€éƒ¨ã§ã™ã€‚ãƒ—ãƒ¬ã‚¤ã§ãã‚‹ã‚ˆã†ã«ã™ã‚‹ã«ã¯ã€{gameConfigureLink}ãƒšãƒ¼ã‚¸ã§ãƒ«ãƒ¼ãƒˆãƒ—ãƒ¬ãƒ¼ã‚¹ã‚’è¿½åŠ ã—ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForLabelGameUnavailableNoRootPlace()
	{
		return "ã“ã®ãƒ—ãƒ¬ãƒ¼ã‚¹ã¯ã€ãƒ«ãƒ¼ãƒˆãƒ—ãƒ¬ã‚¤ã‚¹ã®è¨­å®šã•ã‚Œã¦ã„ãªã„ã‚²ãƒ¼ãƒ ã®ä¸€éƒ¨ã§ã™ã€‚ãƒ—ãƒ¬ã‚¤ã§ãã‚‹ã‚ˆã†ã«ã™ã‚‹ã«ã¯ã€{gameConfigureLink}ãƒšãƒ¼ã‚¸ã§ãƒ«ãƒ¼ãƒˆãƒ—ãƒ¬ãƒ¼ã‚¹ã‚’è¿½åŠ ã—ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForLabelGameUnavailablePermissionLevels()
	{
		return "ã“ã®ãƒ—ãƒ¬ãƒ¼ã‚¹ã®è¨±å¯ãƒ¬ãƒ™ãƒ«ã«ã‚ˆã‚Šã€ã“ã®ãƒ—ãƒ¬ãƒ¼ã‚¹ã«ã¯å…¥ã‚Œã¾ã›ã‚“ã€‚";
	}

	/// <summary>
	/// Key: "Label.GameUnavailablePlaceNotPartOfGame"
	/// English String: "This place is not currently part of a Game. Add it to a game on the {developPageLink} page to make it playable."
	/// </summary>
	public override string LabelGameUnavailablePlaceNotPartOfGame(string developPageLink)
	{
		return $"ã“ã®ãƒ—ãƒ¬ãƒ¼ã‚¹ã¯ç¾åœ¨ã€ã‚²ãƒ¼ãƒ ã®ä¸€éƒ¨ã§ã¯ã‚ã‚Šã¾ã›ã‚“ã€‚ãƒ—ãƒ¬ã‚¤ã§ãã‚‹ã‚ˆã†ã«ã™ã‚‹ã«ã¯ã€{developPageLink}ãƒšãƒ¼ã‚¸ã§ã‚²ãƒ¼ãƒ ã«è¿½åŠ ã—ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForLabelGameUnavailablePlaceNotPartOfGame()
	{
		return "ã“ã®ãƒ—ãƒ¬ãƒ¼ã‚¹ã¯ç¾åœ¨ã€ã‚²ãƒ¼ãƒ ã®ä¸€éƒ¨ã§ã¯ã‚ã‚Šã¾ã›ã‚“ã€‚ãƒ—ãƒ¬ã‚¤ã§ãã‚‹ã‚ˆã†ã«ã™ã‚‹ã«ã¯ã€{developPageLink}ãƒšãƒ¼ã‚¸ã§ã‚²ãƒ¼ãƒ ã«è¿½åŠ ã—ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForLabelGameUnavailablePlaceUnderReview()
	{
		return "ç”³ã—è¨³ã‚ã‚Šã¾ã›ã‚“ãŒã€ã“ã®ãƒ—ãƒ¬ãƒ¼ã‚¹ã¯ç¾åœ¨ãƒ¬ãƒ“ãƒ¥ãƒ¼ä¸­ã§ã™ã€‚å¾Œã§ã‚‚ã†ä¸€åº¦ãŠè©¦ã—ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForLabelGameUnavailablePlatform()
	{
		return "ã“ã®ã‚²ãƒ¼ãƒ ã¯ã‚ãªãŸã®ãƒ—ãƒ©ãƒƒãƒˆãƒ•ã‚©ãƒ¼ãƒ ã§ã¯åˆ©ç”¨ã§ãã¾ã›ã‚“ã€‚ãƒ—ãƒ¬ã‚¤ã§ãã‚‹ã‚²ãƒ¼ãƒ ã«ã¤ã„ã¦ã¯ã€ã‚²ãƒ¼ãƒ ãƒšãƒ¼ã‚¸ã§ãƒã‚§ãƒƒã‚¯ã—ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForLabelGameWarning()
	{
		return "è­¦å‘Š";
	}

	protected override string _GetTemplateForLabelInstallationInstructions()
	{
		return "ã‚¤ãƒ³ã‚¹ãƒˆãƒ¼ãƒ«æ–¹æ³•";
	}

	protected override string _GetTemplateForLabelLaunchApplication()
	{
		return "ã‚¢ãƒ—ãƒªã‚’èµ·å‹•";
	}

	/// <summary>
	/// Key: "Label.OperaInstallSteps"
	/// 1) A window will open. Click Open2) Doubleclick the Roblox icon.
	/// English String: "1) A window will open. Click {startBold}Open{endBold}.{breakLine}2) Doubleclick the Roblox icon."
	/// </summary>
	public override string LabelOperaInstallSteps(string startBold, string endBold, string breakLine)
	{
		return $"1) ã‚¦ã‚£ãƒ³ãƒ‰ã‚¦ãŒé–‹ãã¾ã™ã€‚ã€Œ{startBold}é–‹ã{endBold}ã€ã‚’ã‚¯ãƒªãƒƒã‚¯ã—ã¾ã™ã€‚{breakLine}2) Robloxã‚¢ã‚¤ã‚³ãƒ³ã‚’ãƒ€ãƒ–ãƒ«ã‚¯ãƒªãƒƒã‚¯ã—ã¾ã™ã€‚";
	}

	protected override string _GetTemplateForLabelOperaInstallSteps()
	{
		return "1) ã‚¦ã‚£ãƒ³ãƒ‰ã‚¦ãŒé–‹ãã¾ã™ã€‚ã€Œ{startBold}é–‹ã{endBold}ã€ã‚’ã‚¯ãƒªãƒƒã‚¯ã—ã¾ã™ã€‚{breakLine}2) Robloxã‚¢ã‚¤ã‚³ãƒ³ã‚’ãƒ€ãƒ–ãƒ«ã‚¯ãƒªãƒƒã‚¯ã—ã¾ã™ã€‚";
	}

	protected override string _GetTemplateForLabelPersuadeToDevelopRoblox()
	{
		return "è‡ªåˆ†ã®ã‚²ãƒ¼ãƒ ã‚’åˆ¶ä½œã—ã¦ã¿ã‚ˆã†ï¼";
	}

	protected override string _GetTemplateForLabelPersuadeToInstallRoblox()
	{
		return "ã‚²ãƒ¼ãƒ ã«å‚åŠ ã§ãã‚‹ã‚ˆã†ã«ãªã‚‹ã¾ã§ã€ã‚ã¨å°‘ã—ã§ã™ï¼";
	}

	protected override string _GetTemplateForLabelPlay()
	{
		return "ãƒ—ãƒ¬ã‚¤";
	}

	protected override string _GetTemplateForLabelPlayInApp()
	{
		return "ã‚¢ãƒ—ãƒªã§ãƒ—ãƒ¬ã‚¤ã™ã‚‹";
	}

	protected override string _GetTemplateForLabelRobloxLoadingToPlay()
	{
		return "Robloxã‚’èª­ã¿è¾¼ã‚“ã§ã„ã¾ã™ã€‚ãƒ—ãƒ¬ã‚¤ã®æº–å‚™ã‚’ã—ã‚ˆã†ï¼";
	}

	protected override string _GetTemplateForLabelStartingRoblox()
	{
		return "Robloxã‚’é–‹å§‹ä¸­...";
	}

	protected override string _GetTemplateForLabelSwitchToDesktopMode()
	{
		return "ãƒ‡ã‚¹ã‚¯ãƒˆãƒƒãƒ—ãƒ¢ãƒ¼ãƒ‰ã«åˆ‡ã‚Šæ›¿ãˆã‚‹";
	}

	protected override string _GetTemplateForLabelUniverseConfigurePageTitle()
	{
		return "ãƒ¦ãƒ‹ãƒãƒ¼ã‚¹ç’°å¢ƒè¨­å®š";
	}

	/// <summary>
	/// Key: "Response.CheckAlwaysOpenRoblox"
	/// Check {startBold}Always open links for Roblox{endBold} and click {startBold2}Open Roblox{endBold2} in the dialog box above to join games faster in the future!
	/// English String: "Check {startBold}Always open links for Roblox{endBold} and click {startBold2}Open Roblox{endBold2} in the dialog box above to join games faster in the future!"
	/// </summary>
	public override string ResponseCheckAlwaysOpenRoblox(string startBold, string endBold, string startBold2, string endBold2)
	{
		return $"ã€Œ{startBold}Robloxã®ãƒªãƒ³ã‚¯ã¯å¸¸ã«é–‹ã{endBold}ã€ã«ãƒã‚§ãƒƒã‚¯ã‚’ä»˜ã‘ã¦ã€ä¸Šã®ãƒ€ã‚¤ã‚¢ãƒ­ã‚°ã®ã€Œ{startBold2}Robloxã‚’é–‹ã{endBold2}ã€ã‚’ã‚¯ãƒªãƒƒã‚¯ã™ã‚Œã°ã€ä»Šå¾Œã¯ã™ãã«ã‚²ãƒ¼ãƒ ã«å‚åŠ ã§ãã¾ã™ï¼";
	}

	protected override string _GetTemplateForResponseCheckAlwaysOpenRoblox()
	{
		return "ã€Œ{startBold}Robloxã®ãƒªãƒ³ã‚¯ã¯å¸¸ã«é–‹ã{endBold}ã€ã«ãƒã‚§ãƒƒã‚¯ã‚’ä»˜ã‘ã¦ã€ä¸Šã®ãƒ€ã‚¤ã‚¢ãƒ­ã‚°ã®ã€Œ{startBold2}Robloxã‚’é–‹ã{endBold2}ã€ã‚’ã‚¯ãƒªãƒƒã‚¯ã™ã‚Œã°ã€ä»Šå¾Œã¯ã™ãã«ã‚²ãƒ¼ãƒ ã«å‚åŠ ã§ãã¾ã™ï¼";
	}

	/// <summary>
	/// Key: "Response.CheckAlwaysOpenRobloxURL"
	/// Check {startBold}Always open links for URL: Roblox Protocol{endBold} and click {startBold}Open URL: Roblox Protocol{endBold} in the dialog box above to join games faster in the future!
	/// English String: "Check {startBold}Always open links for URL: Roblox Protocol{endBold} and click {startBold2}Open URL: Roblox Protocol{endBold2} in the dialog box above to join games faster in the future!"
	/// </summary>
	public override string ResponseCheckAlwaysOpenRobloxURL(string startBold, string endBold, string startBold2, string endBold2)
	{
		return $"ã€Œ{startBold}URL: Roblox Protocolã®ãƒªãƒ³ã‚¯ã¯å¸¸ã«é–‹ã{endBold}ã€ã«ãƒã‚§ãƒƒã‚¯ã‚’ä»˜ã‘ã¦ã€ä¸Šã®ãƒ€ã‚¤ã‚¢ãƒ­ã‚°ã®ã€Œ{startBold2}URL: Roblox Protocolã‚’é–‹ã{endBold2}ã€ã‚’ã‚¯ãƒªãƒƒã‚¯ã™ã‚Œã°ã€ä»Šå¾Œã¯ã™ãã«ã‚²ãƒ¼ãƒ ã«å‚åŠ ã§ãã¾ã™ï¼";
	}

	protected override string _GetTemplateForResponseCheckAlwaysOpenRobloxURL()
	{
		return "ã€Œ{startBold}URL: Roblox Protocolã®ãƒªãƒ³ã‚¯ã¯å¸¸ã«é–‹ã{endBold}ã€ã«ãƒã‚§ãƒƒã‚¯ã‚’ä»˜ã‘ã¦ã€ä¸Šã®ãƒ€ã‚¤ã‚¢ãƒ­ã‚°ã®ã€Œ{startBold2}URL: Roblox Protocolã‚’é–‹ã{endBold2}ã€ã‚’ã‚¯ãƒªãƒƒã‚¯ã™ã‚Œã°ã€ä»Šå¾Œã¯ã™ãã«ã‚²ãƒ¼ãƒ ã«å‚åŠ ã§ãã¾ã™ï¼";
	}

	/// <summary>
	/// Key: "Response.CheckRememberMyChoiceOK"
	/// Check Remember my choice and click OK in the dialog box above to join games faster in the future!
	/// English String: "Check {startBold}Remember my choice{endBold} and click {startBold2}OK{endBold2} in the dialog box above to join games faster in the future!"
	/// </summary>
	public override string ResponseCheckRememberMyChoiceOK(string startBold, string endBold, string startBold2, string endBold2)
	{
		return $"ã€Œ{startBold}é¸æŠžã‚’è¨˜æ†¶ã™ã‚‹{endBold}ã€ã«ãƒã‚§ãƒƒã‚¯ã‚’ä»˜ã‘ã¦ã€ä¸Šã®ãƒ€ã‚¤ã‚¢ãƒ­ã‚°ã®ã€Œ{startBold2}OK{endBold2}ã€ã‚’ã‚¯ãƒªãƒƒã‚¯ã™ã‚Œã°ã€ä»Šå¾Œã¯ã™ãã«ã‚²ãƒ¼ãƒ ã«å‚åŠ ã§ãã¾ã™ï¼";
	}

	protected override string _GetTemplateForResponseCheckRememberMyChoiceOK()
	{
		return "ã€Œ{startBold}é¸æŠžã‚’è¨˜æ†¶ã™ã‚‹{endBold}ã€ã«ãƒã‚§ãƒƒã‚¯ã‚’ä»˜ã‘ã¦ã€ä¸Šã®ãƒ€ã‚¤ã‚¢ãƒ­ã‚°ã®ã€Œ{startBold2}OK{endBold2}ã€ã‚’ã‚¯ãƒªãƒƒã‚¯ã™ã‚Œã°ã€ä»Šå¾Œã¯ã™ãã«ã‚²ãƒ¼ãƒ ã«å‚åŠ ã§ãã¾ã™ï¼";
	}

	protected override string _GetTemplateForResponseDialogClickHere()
	{
		return "ã“ã¡ã‚‰ã‚’ã‚¯ãƒªãƒƒã‚¯ã—ã¦ãã ã•ã„ï¼";
	}

	protected override string _GetTemplateForResponseDialogErrorLaunching()
	{
		return "ã‚²ãƒ¼ãƒ ã®èµ·å‹•ä¸­ã«ã‚¨ãƒ©ãƒ¼ãŒç™ºç”Ÿã—ã¾ã—ãŸã€‚å¾Œã§ã‚‚ã†ä¸€åº¦ãŠè©¦ã—ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForResponseDialogHavingTroubleInstallQuestion()
	{
		return "Robloxã®ã‚¤ãƒ³ã‚¹ãƒˆãƒ¼ãƒ«ãŒã§ããªã„å ´åˆã€‚";
	}

	/// <summary>
	/// Key: "Response.Dialog.InstallingMessageWithLink"
	/// Note: For this translation, please move the linkStart and linkEnd variables with the translation for download now.
	/// English String: "The Roblox installer should download shortly. If it doesnâ€™t, start the {linkStart}download now.{linkEnd}"
	/// </summary>
	public override string ResponseDialogInstallingMessageWithLink(string linkStart, string linkEnd)
	{
		return $"Robloxã‚¤ãƒ³ã‚¹ãƒˆãƒ¼ãƒ©ã®ãƒ€ã‚¦ãƒ³ãƒ­ãƒ¼ãƒ‰ãŒã¾ã‚‚ãªãå§‹ã¾ã‚Šã¾ã™ã€‚å§‹ã¾ã‚‰ãªã„å ´åˆã¯ã€{linkStart}ä»Šã™ããƒ€ã‚¦ãƒ³ãƒ­ãƒ¼ãƒ‰{linkEnd}ã§é–‹å§‹ã—ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForResponseDialogInstallingMessageWithLink()
	{
		return "Robloxã‚¤ãƒ³ã‚¹ãƒˆãƒ¼ãƒ©ã®ãƒ€ã‚¦ãƒ³ãƒ­ãƒ¼ãƒ‰ãŒã¾ã‚‚ãªãå§‹ã¾ã‚Šã¾ã™ã€‚å§‹ã¾ã‚‰ãªã„å ´åˆã¯ã€{linkStart}ä»Šã™ããƒ€ã‚¦ãƒ³ãƒ­ãƒ¼ãƒ‰{linkEnd}ã§é–‹å§‹ã—ã¦ãã ã•ã„ã€‚";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacChromeFifthInstruction"
	/// After installation, click {startBold}Play{endBold} below to join the action!
	/// English String: "After installation, click {startBold}Play{endBold} below to join the action!"
	/// </summary>
	public override string ResponseDialogMacChromeFifthInstruction(string startBold, string endBold)
	{
		return $"ã‚¤ãƒ³ã‚¹ãƒˆãƒ¼ãƒ«å¾Œã€ä»¥ä¸‹ã®ã€Œ{startBold}ãƒ—ãƒ¬ã‚¤{endBold}ã€ã‚’ã‚¯ãƒªãƒƒã‚¯ã—ã¦å‚åŠ ã—ã¾ã—ã‚‡ã†ï¼";
	}

	protected override string _GetTemplateForResponseDialogMacChromeFifthInstruction()
	{
		return "ã‚¤ãƒ³ã‚¹ãƒˆãƒ¼ãƒ«å¾Œã€ä»¥ä¸‹ã®ã€Œ{startBold}ãƒ—ãƒ¬ã‚¤{endBold}ã€ã‚’ã‚¯ãƒªãƒƒã‚¯ã—ã¦å‚åŠ ã—ã¾ã—ã‚‡ã†ï¼";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacChromeFirstInstruction"
	/// Click {startBold}Roblox.dmg{endBold} to run the Roblox installer, which just downloaded via your web browser.
	/// English String: "Click {startBold}Roblox.dmg{endBold} to run the Roblox installer, which just downloaded via your web browser."
	/// </summary>
	public override string ResponseDialogMacChromeFirstInstruction(string startBold, string endBold)
	{
		return $"ã€Œ{startBold}Roblox.dmg{endBold}ã€ã‚’ã‚¯ãƒªãƒƒã‚¯ã™ã‚‹ã¨ã€ã‚¦ã‚§ãƒ–ãƒ–ãƒ©ã‚¦ã‚¶ã§ãƒ€ã‚¦ãƒ³ãƒ­ãƒ¼ãƒ‰ã—ãŸã°ã‹ã‚Šã®Robloxã‚¤ãƒ³ã‚¹ãƒˆãƒ¼ãƒ©ãŒå®Ÿè¡Œã•ã‚Œã¾ã™ã€‚";
	}

	protected override string _GetTemplateForResponseDialogMacChromeFirstInstruction()
	{
		return "ã€Œ{startBold}Roblox.dmg{endBold}ã€ã‚’ã‚¯ãƒªãƒƒã‚¯ã™ã‚‹ã¨ã€ã‚¦ã‚§ãƒ–ãƒ–ãƒ©ã‚¦ã‚¶ã§ãƒ€ã‚¦ãƒ³ãƒ­ãƒ¼ãƒ‰ã—ãŸã°ã‹ã‚Šã®Robloxã‚¤ãƒ³ã‚¹ãƒˆãƒ¼ãƒ©ãŒå®Ÿè¡Œã•ã‚Œã¾ã™ã€‚";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacChromeFourthInstruction"
	/// Click {startBold}Ok{endBold} once you've successfully installed Roblox.
	/// English String: "Click {startBold}Ok{endBold} once you've successfully installed Roblox."
	/// </summary>
	public override string ResponseDialogMacChromeFourthInstruction(string startBold, string endBold)
	{
		return $"Robloxã‚’æ­£å¸¸ã«ã‚¤ãƒ³ã‚¹ãƒˆãƒ¼ãƒ«ã—ãŸã‚‰ã€Œ{startBold}OK{endBold}ã€ã‚’ä¸€å›žã‚¯ãƒªãƒƒã‚¯ã—ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForResponseDialogMacChromeFourthInstruction()
	{
		return "Robloxã‚’æ­£å¸¸ã«ã‚¤ãƒ³ã‚¹ãƒˆãƒ¼ãƒ«ã—ãŸã‚‰ã€Œ{startBold}OK{endBold}ã€ã‚’ä¸€å›žã‚¯ãƒªãƒƒã‚¯ã—ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForResponseDialogMacChromeSecondInstruction()
	{
		return "Robloxã‚¢ãƒ—ãƒªã‚¢ã‚¤ã‚³ãƒ³ã‚’ãƒ€ãƒ–ãƒ«ã‚¯ãƒªãƒƒã‚¯ã—ã¦ã€ã‚¤ãƒ³ã‚¹ãƒˆãƒ¼ãƒ«ãƒ—ãƒ­ã‚»ã‚¹ã‚’é–‹å§‹ã€‚";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacChromeThirdInstruction"
	/// Click {startBold}Open{endBold} when prompted by your computer.
	/// English String: "Click {startBold}Open{endBold} when prompted by your computer."
	/// </summary>
	public override string ResponseDialogMacChromeThirdInstruction(string startBold, string endBold)
	{
		return $"ç”»é¢ã®æŒ‡ç¤ºã«å¾“ã£ã¦ã€Œ{startBold}é–‹ã{endBold}ã€ã‚’ã‚¯ãƒªãƒƒã‚¯ã—ã¾ã™ã€‚";
	}

	protected override string _GetTemplateForResponseDialogMacChromeThirdInstruction()
	{
		return "ç”»é¢ã®æŒ‡ç¤ºã«å¾“ã£ã¦ã€Œ{startBold}é–‹ã{endBold}ã€ã‚’ã‚¯ãƒªãƒƒã‚¯ã—ã¾ã™ã€‚";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacFirefoxFifthInstruction"
	/// Then select the Remember my choice... checkbox and click OK
	/// English String: "Then select the {startBold}Remember my choice...{endBold} checkbox and click {startBold2}OK{endBold2}"
	/// </summary>
	public override string ResponseDialogMacFirefoxFifthInstruction(string startBold, string endBold, string startBold2, string endBold2)
	{
		return $"æ¬¡ã«ã€Œ{startBold}é¸æŠžã‚’è¨˜æ†¶ã™ã‚‹...{endBold}ã€ã®ãƒã‚§ãƒƒã‚¯ãƒœãƒƒã‚¯ã‚¹ã‚’é¸æŠžã—ã¦ã€ã€Œ{startBold2}OK{endBold2}ã€ã‚’ã‚¯ãƒªãƒƒã‚¯ã—ã¾ã™";
	}

	protected override string _GetTemplateForResponseDialogMacFirefoxFifthInstruction()
	{
		return "æ¬¡ã«ã€Œ{startBold}é¸æŠžã‚’è¨˜æ†¶ã™ã‚‹...{endBold}ã€ã®ãƒã‚§ãƒƒã‚¯ãƒœãƒƒã‚¯ã‚¹ã‚’é¸æŠžã—ã¦ã€ã€Œ{startBold2}OK{endBold2}ã€ã‚’ã‚¯ãƒªãƒƒã‚¯ã—ã¾ã™";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacFirefoxFirstInstruction"
	/// Select Open with and click OK
	/// English String: "Select {startBold}Open with{endBold} and click {startBold2}OK{endBold2}"
	/// </summary>
	public override string ResponseDialogMacFirefoxFirstInstruction(string startBold, string endBold, string startBold2, string endBold2)
	{
		return $"ã€Œ{startBold}ã§é–‹ã{endBold}ã€ã‚’é¸æŠžã—ã¦ã€ã€Œ{startBold2}OK{endBold2}ã€ã‚’ã‚¯ãƒªãƒƒã‚¯ã—ã¾ã™";
	}

	protected override string _GetTemplateForResponseDialogMacFirefoxFirstInstruction()
	{
		return "ã€Œ{startBold}ã§é–‹ã{endBold}ã€ã‚’é¸æŠžã—ã¦ã€ã€Œ{startBold2}OK{endBold2}ã€ã‚’ã‚¯ãƒªãƒƒã‚¯ã—ã¾ã™";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacFirefoxFourthInstruction"
	/// Once installed, click Play to join the action!
	/// English String: "Once installed, click {startBold}Play{endBold} to join the action!"
	/// </summary>
	public override string ResponseDialogMacFirefoxFourthInstruction(string startBold, string endBold)
	{
		return $"ã‚¤ãƒ³ã‚¹ãƒˆãƒ¼ãƒ«å¾Œã€ã€Œ{startBold}ãƒ—ãƒ¬ã‚¤{endBold}ã€ã‚’ã‚¯ãƒªãƒƒã‚¯ã—ã¦å‚åŠ ã—ã¾ã—ã‚‡ã†ï¼";
	}

	protected override string _GetTemplateForResponseDialogMacFirefoxFourthInstruction()
	{
		return "ã‚¤ãƒ³ã‚¹ãƒˆãƒ¼ãƒ«å¾Œã€ã€Œ{startBold}ãƒ—ãƒ¬ã‚¤{endBold}ã€ã‚’ã‚¯ãƒªãƒƒã‚¯ã—ã¦å‚åŠ ã—ã¾ã—ã‚‡ã†ï¼";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacFirefoxSecondInstruction"
	/// Double-click the Roblox Icon to begin the installation process
	/// English String: "Double-click the {startBold}Roblox Icon{endBold} to begin the installation process"
	/// </summary>
	public override string ResponseDialogMacFirefoxSecondInstruction(string startBold, string endBold)
	{
		return $"{startBold}Robloxã‚¢ã‚¤ã‚³ãƒ³{endBold}ã‚’ãƒ€ãƒ–ãƒ«ã‚¯ãƒªãƒƒã‚¯ã—ã¦ã€ã‚¤ãƒ³ã‚¹ãƒˆãƒ¼ãƒ«ãƒ—ãƒ­ã‚»ã‚¹ã‚’é–‹å§‹";
	}

	protected override string _GetTemplateForResponseDialogMacFirefoxSecondInstruction()
	{
		return "{startBold}Robloxã‚¢ã‚¤ã‚³ãƒ³{endBold}ã‚’ãƒ€ãƒ–ãƒ«ã‚¯ãƒªãƒƒã‚¯ã—ã¦ã€ã‚¤ãƒ³ã‚¹ãƒˆãƒ¼ãƒ«ãƒ—ãƒ­ã‚»ã‚¹ã‚’é–‹å§‹";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacFirefoxThirdInstruction"
	/// You will receive a warning, click Open
	/// English String: "You will receive a warning, click {startBold}Open{endBold}"
	/// </summary>
	public override string ResponseDialogMacFirefoxThirdInstruction(string startBold, string endBold)
	{
		return $"è­¦å‘ŠãŒè¡¨ç¤ºã•ã‚ŒãŸã‚‰ã€ã€Œ{startBold}é–‹ã{endBold}ã€ã‚’ã‚¯ãƒªãƒƒã‚¯ã—ã¾ã™";
	}

	protected override string _GetTemplateForResponseDialogMacFirefoxThirdInstruction()
	{
		return "è­¦å‘ŠãŒè¡¨ç¤ºã•ã‚ŒãŸã‚‰ã€ã€Œ{startBold}é–‹ã{endBold}ã€ã‚’ã‚¯ãƒªãƒƒã‚¯ã—ã¾ã™";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacSafariFirstInstruction"
	/// Go to Downloads and double-click Roblox.dmg
	/// English String: "Go to Downloads and double-click {startBold}Roblox.dmg{endBold}"
	/// </summary>
	public override string ResponseDialogMacSafariFirstInstruction(string startBold, string endBold)
	{
		return $"ã€Œãƒ€ã‚¦ãƒ³ãƒ­ãƒ¼ãƒ‰ã€ã«ã‚¢ã‚¯ã‚»ã‚¹ã—ã¦ã€{startBold}Roblox.dmg{endBold}ã‚’ãƒ€ãƒ–ãƒ«ã‚¯ãƒªãƒƒã‚¯ã—ã¾ã™";
	}

	protected override string _GetTemplateForResponseDialogMacSafariFirstInstruction()
	{
		return "ã€Œãƒ€ã‚¦ãƒ³ãƒ­ãƒ¼ãƒ‰ã€ã«ã‚¢ã‚¯ã‚»ã‚¹ã—ã¦ã€{startBold}Roblox.dmg{endBold}ã‚’ãƒ€ãƒ–ãƒ«ã‚¯ãƒªãƒƒã‚¯ã—ã¾ã™";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacSafariFourthInstruction"
	/// Once installed, click {startBold}Play{endBold} to join the action!
	/// English String: "Once installed, click {startBold}Play{endBold} to join the action!"
	/// </summary>
	public override string ResponseDialogMacSafariFourthInstruction(string startBold, string endBold)
	{
		return $"ã‚¤ãƒ³ã‚¹ãƒˆãƒ¼ãƒ«å¾Œã€ã€Œ{startBold}ãƒ—ãƒ¬ã‚¤{endBold}ã€ã‚’ã‚¯ãƒªãƒƒã‚¯ã—ã¦å‚åŠ ã—ã¾ã—ã‚‡ã†ï¼";
	}

	protected override string _GetTemplateForResponseDialogMacSafariFourthInstruction()
	{
		return "ã‚¤ãƒ³ã‚¹ãƒˆãƒ¼ãƒ«å¾Œã€ã€Œ{startBold}ãƒ—ãƒ¬ã‚¤{endBold}ã€ã‚’ã‚¯ãƒªãƒƒã‚¯ã—ã¦å‚åŠ ã—ã¾ã—ã‚‡ã†ï¼";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacSafariSecondInstruction"
	/// Double-click the {startBold}Roblox Icon{endBold} to begin the installation process
	/// English String: "Double-click the {startBold}Roblox Icon{endBold} to begin the installation process"
	/// </summary>
	public override string ResponseDialogMacSafariSecondInstruction(string startBold, string endBold)
	{
		return $"{startBold}Robloxã‚¢ã‚¤ã‚³ãƒ³{endBold}ã‚’ãƒ€ãƒ–ãƒ«ã‚¯ãƒªãƒƒã‚¯ã—ã¦ã€ã‚¤ãƒ³ã‚¹ãƒˆãƒ¼ãƒ«ãƒ—ãƒ­ã‚»ã‚¹ã‚’é–‹å§‹";
	}

	protected override string _GetTemplateForResponseDialogMacSafariSecondInstruction()
	{
		return "{startBold}Robloxã‚¢ã‚¤ã‚³ãƒ³{endBold}ã‚’ãƒ€ãƒ–ãƒ«ã‚¯ãƒªãƒƒã‚¯ã—ã¦ã€ã‚¤ãƒ³ã‚¹ãƒˆãƒ¼ãƒ«ãƒ—ãƒ­ã‚»ã‚¹ã‚’é–‹å§‹";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacSafariThirdInstruction"
	/// You will receive a warning, click {startBold}Open{endBold}
	/// English String: "You will receive a warning, click {startBold}Open{endBold}"
	/// </summary>
	public override string ResponseDialogMacSafariThirdInstruction(string startBold, string endBold)
	{
		return $"è­¦å‘ŠãŒè¡¨ç¤ºã•ã‚ŒãŸã‚‰ã€ã€Œ{startBold}é–‹ã{endBold}ã€ã‚’ã‚¯ãƒªãƒƒã‚¯ã—ã¾ã™";
	}

	protected override string _GetTemplateForResponseDialogMacSafariThirdInstruction()
	{
		return "è­¦å‘ŠãŒè¡¨ç¤ºã•ã‚ŒãŸã‚‰ã€ã€Œ{startBold}é–‹ã{endBold}ã€ã‚’ã‚¯ãƒªãƒƒã‚¯ã—ã¾ã™";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcChromeFirstInstruction"
	/// Click {startBold}RobloxPlayer.exe{endBold} to run the Roblox installer, which just downloaded via your web browser.
	/// English String: "Click {startBold}RobloxPlayer.exe{endBold} to run the Roblox installer, which just downloaded via your web browser."
	/// </summary>
	public override string ResponseDialogPcChromeFirstInstruction(string startBold, string endBold)
	{
		return $"ã€Œ{startBold}RobloxPlayer.exe{endBold}ã€ã‚’ã‚¯ãƒªãƒƒã‚¯ã™ã‚‹ã¨ã€ã‚¦ã‚§ãƒ–ãƒ–ãƒ©ã‚¦ã‚¶ã§ãƒ€ã‚¦ãƒ³ãƒ­ãƒ¼ãƒ‰ã—ãŸã°ã‹ã‚Šã®Robloxã‚¤ãƒ³ã‚¹ãƒˆãƒ¼ãƒ©ãŒå®Ÿè¡Œã•ã‚Œã¾ã™ã€‚";
	}

	protected override string _GetTemplateForResponseDialogPcChromeFirstInstruction()
	{
		return "ã€Œ{startBold}RobloxPlayer.exe{endBold}ã€ã‚’ã‚¯ãƒªãƒƒã‚¯ã™ã‚‹ã¨ã€ã‚¦ã‚§ãƒ–ãƒ–ãƒ©ã‚¦ã‚¶ã§ãƒ€ã‚¦ãƒ³ãƒ­ãƒ¼ãƒ‰ã—ãŸã°ã‹ã‚Šã®Robloxã‚¤ãƒ³ã‚¹ãƒˆãƒ¼ãƒ©ãŒå®Ÿè¡Œã•ã‚Œã¾ã™ã€‚";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcChromeFourthInstruction"
	/// After installation, click {startBold}Play{endBold} below to join the action!
	/// English String: "After installation, click {startBold}Play{endBold} below to join the action!"
	/// </summary>
	public override string ResponseDialogPcChromeFourthInstruction(string startBold, string endBold)
	{
		return $"ã‚¤ãƒ³ã‚¹ãƒˆãƒ¼ãƒ«å¾Œã€ä»¥ä¸‹ã®ã€Œ{startBold}ãƒ—ãƒ¬ã‚¤{endBold}ã€ã‚’ã‚¯ãƒªãƒƒã‚¯ã—ã¦å‚åŠ ã—ã¾ã—ã‚‡ã†ï¼";
	}

	protected override string _GetTemplateForResponseDialogPcChromeFourthInstruction()
	{
		return "ã‚¤ãƒ³ã‚¹ãƒˆãƒ¼ãƒ«å¾Œã€ä»¥ä¸‹ã®ã€Œ{startBold}ãƒ—ãƒ¬ã‚¤{endBold}ã€ã‚’ã‚¯ãƒªãƒƒã‚¯ã—ã¦å‚åŠ ã—ã¾ã—ã‚‡ã†ï¼";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcChromeSecondInstruction"
	/// Click {startBold}Run{endBold} when prompted by your computer to begin the installation process.
	/// English String: "Click {startBold}Run{endBold} when prompted by your computer to begin the installation process."
	/// </summary>
	public override string ResponseDialogPcChromeSecondInstruction(string startBold, string endBold)
	{
		return $"ã‚¤ãƒ³ã‚¹ãƒˆãƒ¼ãƒ«ãƒ—ãƒ­ã‚»ã‚¹ã‚’é–‹å§‹ã™ã‚‹ã‚ˆã†ã«ãƒ‘ã‚½ã‚³ãƒ³ã«æŒ‡ç¤ºã•ã‚ŒãŸã‚‰ã€ã€Œ{startBold}å®Ÿè¡Œ{endBold}ã€ã‚’ã‚¯ãƒªãƒƒã‚¯ã—ã¾ã™ã€‚";
	}

	protected override string _GetTemplateForResponseDialogPcChromeSecondInstruction()
	{
		return "ã‚¤ãƒ³ã‚¹ãƒˆãƒ¼ãƒ«ãƒ—ãƒ­ã‚»ã‚¹ã‚’é–‹å§‹ã™ã‚‹ã‚ˆã†ã«ãƒ‘ã‚½ã‚³ãƒ³ã«æŒ‡ç¤ºã•ã‚ŒãŸã‚‰ã€ã€Œ{startBold}å®Ÿè¡Œ{endBold}ã€ã‚’ã‚¯ãƒªãƒƒã‚¯ã—ã¾ã™ã€‚";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcChromeThirdInstruction"
	/// Click {startBold}Ok{endBold} once you've successfully installed Roblox.
	/// English String: "Click {startBold}Ok{endBold} once you've successfully installed Roblox."
	/// </summary>
	public override string ResponseDialogPcChromeThirdInstruction(string startBold, string endBold)
	{
		return $"Robloxã‚’æ­£å¸¸ã«ã‚¤ãƒ³ã‚¹ãƒˆãƒ¼ãƒ«ã—ãŸã‚‰ã€Œ{startBold}OK{endBold}ã€ã‚’ä¸€å›žã‚¯ãƒªãƒƒã‚¯ã—ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForResponseDialogPcChromeThirdInstruction()
	{
		return "Robloxã‚’æ­£å¸¸ã«ã‚¤ãƒ³ã‚¹ãƒˆãƒ¼ãƒ«ã—ãŸã‚‰ã€Œ{startBold}OK{endBold}ã€ã‚’ä¸€å›žã‚¯ãƒªãƒƒã‚¯ã—ã¦ãã ã•ã„ã€‚";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcEdgeFirstInstruction"
	/// Click {startBold}Run{endBold} to install Roblox after the download finishes
	/// English String: "Click {startBold}Run{endBold} to install Roblox after the download finishes"
	/// </summary>
	public override string ResponseDialogPcEdgeFirstInstruction(string startBold, string endBold)
	{
		return $"ãƒ€ã‚¦ãƒ³ãƒ­ãƒ¼ãƒ‰ãŒçµ‚ã‚ã£ãŸã‚‰ã€ã€Œ{startBold}å®Ÿè¡Œ{endBold}ã€ã‚’ã‚¯ãƒªãƒƒã‚¯ã—ã¦Robloxã‚’ã‚¤ãƒ³ã‚¹ãƒˆãƒ¼ãƒ«ã—ã¾ã™";
	}

	protected override string _GetTemplateForResponseDialogPcEdgeFirstInstruction()
	{
		return "ãƒ€ã‚¦ãƒ³ãƒ­ãƒ¼ãƒ‰ãŒçµ‚ã‚ã£ãŸã‚‰ã€ã€Œ{startBold}å®Ÿè¡Œ{endBold}ã€ã‚’ã‚¯ãƒªãƒƒã‚¯ã—ã¦Robloxã‚’ã‚¤ãƒ³ã‚¹ãƒˆãƒ¼ãƒ«ã—ã¾ã™";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcEdgeSecondInstruction"
	/// Click {startBold}Ok{endBold} to finish installing Roblox
	/// English String: "Click {startBold}Ok{endBold} to finish installing Roblox"
	/// </summary>
	public override string ResponseDialogPcEdgeSecondInstruction(string startBold, string endBold)
	{
		return $"ã€Œ{startBold}OK{endBold}ã€ã‚’ã‚¯ãƒªãƒƒã‚¯ã—ã¦Robloxã®ã‚¤ãƒ³ã‚¹ãƒˆãƒ¼ãƒ«ã‚’å®Œäº†ã—ã¾ã™ã€‚";
	}

	protected override string _GetTemplateForResponseDialogPcEdgeSecondInstruction()
	{
		return "ã€Œ{startBold}OK{endBold}ã€ã‚’ã‚¯ãƒªãƒƒã‚¯ã—ã¦Robloxã®ã‚¤ãƒ³ã‚¹ãƒˆãƒ¼ãƒ«ã‚’å®Œäº†ã—ã¾ã™ã€‚";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcEdgeThirdInstruction"
	/// Click the {startBold}Play{endBold} button to join the action!
	/// English String: "Click the {startBold}Play{endBold} button to join the action!"
	/// </summary>
	public override string ResponseDialogPcEdgeThirdInstruction(string startBold, string endBold)
	{
		return $"ã€Œ{startBold}ãƒ—ãƒ¬ã‚¤{endBold}ã€ãƒœã‚¿ãƒ³ã‚’ã‚¯ãƒªãƒƒã‚¯ã—ã¦ã€ã‚²ãƒ¼ãƒ ã«å‚åŠ ã—ã¾ã™ï¼";
	}

	protected override string _GetTemplateForResponseDialogPcEdgeThirdInstruction()
	{
		return "ã€Œ{startBold}ãƒ—ãƒ¬ã‚¤{endBold}ã€ãƒœã‚¿ãƒ³ã‚’ã‚¯ãƒªãƒƒã‚¯ã—ã¦ã€ã‚²ãƒ¼ãƒ ã«å‚åŠ ã—ã¾ã™ï¼";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcFirefoxFifthInstruction"
	/// Click {startBold}Ok{endBold} when the alert pops up
	/// English String: "Click {startBold}Ok{endBold} when the alert pops up"
	/// </summary>
	public override string ResponseDialogPcFirefoxFifthInstruction(string startBold, string endBold)
	{
		return $"è­¦å‘ŠãŒè¡¨ç¤ºã•ã‚ŒãŸã‚‰ã€Œ{startBold}OK{endBold}ã€ã‚’ã‚¯ãƒªãƒƒã‚¯ã—ã¾ã™";
	}

	protected override string _GetTemplateForResponseDialogPcFirefoxFifthInstruction()
	{
		return "è­¦å‘ŠãŒè¡¨ç¤ºã•ã‚ŒãŸã‚‰ã€Œ{startBold}OK{endBold}ã€ã‚’ã‚¯ãƒªãƒƒã‚¯ã—ã¾ã™";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcFirefoxFirstInstruction"
	/// Click {startBold}Save File{endBold} when the download window pops up
	/// English String: "Click {startBold}Save File{endBold} when the download window pops up"
	/// </summary>
	public override string ResponseDialogPcFirefoxFirstInstruction(string startBold, string endBold)
	{
		return $"ãƒ€ã‚¦ãƒ³ãƒ­ãƒ¼ãƒ‰ã‚¦ã‚£ãƒ³ãƒ‰ã‚¦ãŒé–‹ã„ãŸã‚‰ã€Œ{startBold}ãƒ•ã‚¡ã‚¤ãƒ«ã‚’ä¿å­˜ã™ã‚‹{endBold}ã€ã‚’ã‚¯ãƒªãƒƒã‚¯ã—ã¾ã™";
	}

	protected override string _GetTemplateForResponseDialogPcFirefoxFirstInstruction()
	{
		return "ãƒ€ã‚¦ãƒ³ãƒ­ãƒ¼ãƒ‰ã‚¦ã‚£ãƒ³ãƒ‰ã‚¦ãŒé–‹ã„ãŸã‚‰ã€Œ{startBold}ãƒ•ã‚¡ã‚¤ãƒ«ã‚’ä¿å­˜ã™ã‚‹{endBold}ã€ã‚’ã‚¯ãƒªãƒƒã‚¯ã—ã¾ã™";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcFirefoxFourthInstruction"
	/// Once installed, click {startBold}Play{endBold} to join the action!
	/// English String: "Once installed, click {startBold}Play{endBold} to join the action!"
	/// </summary>
	public override string ResponseDialogPcFirefoxFourthInstruction(string startBold, string endBold)
	{
		return $"ã‚¤ãƒ³ã‚¹ãƒˆãƒ¼ãƒ«å¾Œã€ã€Œ{startBold}ãƒ—ãƒ¬ã‚¤{endBold}ã€ã‚’ã‚¯ãƒªãƒƒã‚¯ã—ã¦å‚åŠ ã—ã¾ã—ã‚‡ã†ï¼";
	}

	protected override string _GetTemplateForResponseDialogPcFirefoxFourthInstruction()
	{
		return "ã‚¤ãƒ³ã‚¹ãƒˆãƒ¼ãƒ«å¾Œã€ã€Œ{startBold}ãƒ—ãƒ¬ã‚¤{endBold}ã€ã‚’ã‚¯ãƒªãƒƒã‚¯ã—ã¦å‚åŠ ã—ã¾ã—ã‚‡ã†ï¼";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcFirefoxSecondInstruction"
	/// Go to Downloads and double click {startBold}RobloxPlayer.exe{endBold}
	/// English String: "Go to Downloads and double click {startBold}RobloxPlayer.exe{endBold}"
	/// </summary>
	public override string ResponseDialogPcFirefoxSecondInstruction(string startBold, string endBold)
	{
		return $"ã€Œãƒ€ã‚¦ãƒ³ãƒ­ãƒ¼ãƒ‰ã€ã«ã‚¢ã‚¯ã‚»ã‚¹ã—ã¦ã€{startBold}RobloxPlayer.exe{endBold}ã‚’ãƒ€ãƒ–ãƒ«ã‚¯ãƒªãƒƒã‚¯ã—ã¾ã™";
	}

	protected override string _GetTemplateForResponseDialogPcFirefoxSecondInstruction()
	{
		return "ã€Œãƒ€ã‚¦ãƒ³ãƒ­ãƒ¼ãƒ‰ã€ã«ã‚¢ã‚¯ã‚»ã‚¹ã—ã¦ã€{startBold}RobloxPlayer.exe{endBold}ã‚’ãƒ€ãƒ–ãƒ«ã‚¯ãƒªãƒƒã‚¯ã—ã¾ã™";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcFirefoxThirdInstruction"
	/// Click {startBold}Run{endBold}
	/// English String: "Click {startBold}Run{endBold}"
	/// </summary>
	public override string ResponseDialogPcFirefoxThirdInstruction(string startBold, string endBold)
	{
		return $"ã€Œ{startBold}å®Ÿè¡Œ{endBold}ã€ã‚’ã‚¯ãƒªãƒƒã‚¯ã—ã¾ã™";
	}

	protected override string _GetTemplateForResponseDialogPcFirefoxThirdInstruction()
	{
		return "ã€Œ{startBold}å®Ÿè¡Œ{endBold}ã€ã‚’ã‚¯ãƒªãƒƒã‚¯ã—ã¾ã™";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcIEFirstInstruction"
	/// You will receive a warning, click {startBold}Run{endBold}
	/// English String: "You will receive a warning, click {startBold}Run{endBold}"
	/// </summary>
	public override string ResponseDialogPcIEFirstInstruction(string startBold, string endBold)
	{
		return $"è­¦å‘ŠãŒè¡¨ç¤ºã•ã‚ŒãŸã‚‰ã€ã€Œ{startBold}å®Ÿè¡Œ{endBold}ã€ã‚’ã‚¯ãƒªãƒƒã‚¯ã—ã¾ã™";
	}

	protected override string _GetTemplateForResponseDialogPcIEFirstInstruction()
	{
		return "è­¦å‘ŠãŒè¡¨ç¤ºã•ã‚ŒãŸã‚‰ã€ã€Œ{startBold}å®Ÿè¡Œ{endBold}ã€ã‚’ã‚¯ãƒªãƒƒã‚¯ã—ã¾ã™";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcIeInstructionOne"
	/// You will receive a warning, click {startBold}Run{endBold}
	/// English String: "You will receive a warning, click {startBold}Run{endBold}"
	/// </summary>
	public override string ResponseDialogPcIeInstructionOne(string startBold, string endBold)
	{
		return $"è­¦å‘ŠãŒè¡¨ç¤ºã•ã‚ŒãŸã‚‰ã€ã€Œ{startBold}å®Ÿè¡Œ{endBold}ã€ã‚’ã‚¯ãƒªãƒƒã‚¯ã—ã¾ã™";
	}

	protected override string _GetTemplateForResponseDialogPcIeInstructionOne()
	{
		return "è­¦å‘ŠãŒè¡¨ç¤ºã•ã‚ŒãŸã‚‰ã€ã€Œ{startBold}å®Ÿè¡Œ{endBold}ã€ã‚’ã‚¯ãƒªãƒƒã‚¯ã—ã¾ã™";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcIeInstructionThree"
	/// Click {startBold}Run{endBold}
	/// English String: "Click {startBold}Run{endBold}"
	/// </summary>
	public override string ResponseDialogPcIeInstructionThree(string startBold, string endBold)
	{
		return $"ã€Œ{startBold}å®Ÿè¡Œ{endBold}ã€ã‚’ã‚¯ãƒªãƒƒã‚¯ã—ã¾ã™";
	}

	protected override string _GetTemplateForResponseDialogPcIeInstructionThree()
	{
		return "ã€Œ{startBold}å®Ÿè¡Œ{endBold}ã€ã‚’ã‚¯ãƒªãƒƒã‚¯ã—ã¾ã™";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcIeInstructionTwo"
	/// Go to Downloads and double click {startBold}RobloxPlayer.exe{endBold}
	/// English String: "Go to Downloads and double click {startBold}RobloxPlayer.exe{endBold}"
	/// </summary>
	public override string ResponseDialogPcIeInstructionTwo(string startBold, string endBold)
	{
		return $"ã€Œãƒ€ã‚¦ãƒ³ãƒ­ãƒ¼ãƒ‰ã€ã«ã‚¢ã‚¯ã‚»ã‚¹ã—ã¦ã€{startBold}RobloxPlayer.exe{endBold}ã‚’ãƒ€ãƒ–ãƒ«ã‚¯ãƒªãƒƒã‚¯ã—ã¾ã™";
	}

	protected override string _GetTemplateForResponseDialogPcIeInstructionTwo()
	{
		return "ã€Œãƒ€ã‚¦ãƒ³ãƒ­ãƒ¼ãƒ‰ã€ã«ã‚¢ã‚¯ã‚»ã‚¹ã—ã¦ã€{startBold}RobloxPlayer.exe{endBold}ã‚’ãƒ€ãƒ–ãƒ«ã‚¯ãƒªãƒƒã‚¯ã—ã¾ã™";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcIESecondInstruction"
	/// Click {startBold}Ok{endBold} once you've installed Roblox
	/// English String: "Click {startBold}Ok{endBold} once you've installed Roblox"
	/// </summary>
	public override string ResponseDialogPcIESecondInstruction(string startBold, string endBold)
	{
		return $"Robloxã‚’æ­£å¸¸ã«ã‚¤ãƒ³ã‚¹ãƒˆãƒ¼ãƒ«ã—ãŸã‚‰ã€Œ{startBold}OK{endBold}ã€ã‚’ã‚¯ãƒªãƒƒã‚¯ã—ã¦ãã ã•ã„";
	}

	protected override string _GetTemplateForResponseDialogPcIESecondInstruction()
	{
		return "Robloxã‚’æ­£å¸¸ã«ã‚¤ãƒ³ã‚¹ãƒˆãƒ¼ãƒ«ã—ãŸã‚‰ã€Œ{startBold}OK{endBold}ã€ã‚’ã‚¯ãƒªãƒƒã‚¯ã—ã¦ãã ã•ã„";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcIEThirdInstruction"
	/// Once installed, click {startBold}Play{endBold} to join the action!
	/// English String: "Once installed, click {startBold}Play{endBold} to join the action!"
	/// </summary>
	public override string ResponseDialogPcIEThirdInstruction(string startBold, string endBold)
	{
		return $"ã‚¤ãƒ³ã‚¹ãƒˆãƒ¼ãƒ«å¾Œã€ã€Œ{startBold}ãƒ—ãƒ¬ã‚¤{endBold}ã€ã‚’ã‚¯ãƒªãƒƒã‚¯ã—ã¦å‚åŠ ã—ã¾ã—ã‚‡ã†ï¼";
	}

	protected override string _GetTemplateForResponseDialogPcIEThirdInstruction()
	{
		return "ã‚¤ãƒ³ã‚¹ãƒˆãƒ¼ãƒ«å¾Œã€ã€Œ{startBold}ãƒ—ãƒ¬ã‚¤{endBold}ã€ã‚’ã‚¯ãƒªãƒƒã‚¯ã—ã¦å‚åŠ ã—ã¾ã—ã‚‡ã†ï¼";
	}

	protected override string _GetTemplateForResponseDialogThanksForPlayingRoblox()
	{
		return "Robloxã‚’ãƒ—ãƒ¬ã‚¤ã—ã¦ã„ãŸã ãã‚ã‚ŠãŒã¨ã†ã”ã–ã„ã¾ã™";
	}

	protected override string _GetTemplateForResponseGameTemporarilyUnavailable()
	{
		return "ã“ã®ã‚²ãƒ¼ãƒ ã¸ã®ã‚¢ã‚¯ã‚»ã‚¹æ¨©ã‚’èªè¨¼ã§ãã¾ã›ã‚“ã€‚å¾Œã§å†è©¦è¡Œã—ã¦ãã ã•ã„ã€‚";
	}

	/// <summary>
	/// Key: "Response.RememberMyChoiceAppLaunch"
	/// Check {startBold}Remember my choice{endBold} and click {appLaunchLink} in the dialog box above to join games faster in the future!
	/// English String: "Check {startBold}Remember my choice{endBold} and click {appLaunchLink} in the dialog box above to join games faster in the future!"
	/// </summary>
	public override string ResponseRememberMyChoiceAppLaunch(string startBold, string endBold, string appLaunchLink)
	{
		return $"ã€Œ{startBold}é¸æŠžçŠ¶æ³ã‚’è¨˜æ†¶ã™ã‚‹{endBold}ã€ã«ãƒã‚§ãƒƒã‚¯ã‚’ä»˜ã‘ã¦ã€ä¸Šã®ãƒ€ã‚¤ã‚¢ãƒ­ã‚°ã®{appLaunchLink}ã‚’ã‚¯ãƒªãƒƒã‚¯ã™ã‚Œã°ã€ä»Šå¾Œã¯ã™ãã«ã‚²ãƒ¼ãƒ ã«å‚åŠ ã§ãã¾ã™ï¼";
	}

	protected override string _GetTemplateForResponseRememberMyChoiceAppLaunch()
	{
		return "ã€Œ{startBold}é¸æŠžçŠ¶æ³ã‚’è¨˜æ†¶ã™ã‚‹{endBold}ã€ã«ãƒã‚§ãƒƒã‚¯ã‚’ä»˜ã‘ã¦ã€ä¸Šã®ãƒ€ã‚¤ã‚¢ãƒ­ã‚°ã®{appLaunchLink}ã‚’ã‚¯ãƒªãƒƒã‚¯ã™ã‚Œã°ã€ä»Šå¾Œã¯ã™ãã«ã‚²ãƒ¼ãƒ ã«å‚åŠ ã§ãã¾ã™ï¼";
	}
}


}
