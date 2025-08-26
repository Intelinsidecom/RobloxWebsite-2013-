namespace Roblox.Platform.TranslationResources.Common {
    /// <summary>

/// This class overrides VisitGameResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class VisitGameResources_ko_kr : VisitGameResources_en_us, IVisitGameResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Retry"
	/// button label
	/// English String: "Retry"
	/// </summary>
	public override string ActionRetry => "ë‹¤ì‹œ ì‹œë„";

	/// <summary>
	/// Key: "Heading.ErrorStartingGame"
	/// Error starting game
	/// English String: "Error starting game"
	/// </summary>
	public override string HeadingErrorStartingGame => "ê²Œìž„ ì‹œìž‘ ì¤‘ ì˜¤ë¥˜ ë°œìƒ";

	/// <summary>
	/// Key: "Heading.SwitchToDesktopToPlay"
	/// Switch to Desktop Mode to Play Games
	/// English String: "Switch to Desktop Mode to Play Games"
	/// </summary>
	public override string HeadingSwitchToDesktopToPlay => "ë°ìŠ¤í¬í†± ëª¨ë“œë¡œ ì „í™˜í•˜ì—¬ ê²Œìž„ í”Œë ˆì´";

	/// <summary>
	/// Key: "Label.Cancel"
	/// Cancel
	/// English String: "Cancel"
	/// </summary>
	public override string LabelCancel => "ì·¨ì†Œ";

	/// <summary>
	/// Key: "Label.CheckingForStudio"
	/// We are checking if user has Roblox Studio installed
	/// English String: "Checking for Roblox Studio..."
	/// </summary>
	public override string LabelCheckingForStudio => "Roblox Studio í™•ì¸ ì¤‘...";

	/// <summary>
	/// Key: "Label.ClickHereForHelp"
	/// Click here for help
	/// English String: "Click here for help"
	/// </summary>
	public override string LabelClickHereForHelp => "ì—¬ê¸°ë¥¼ í´ë¦­í•˜ì—¬ ë„ì›€ì„ ë°›ì•„ë³´ì„¸ìš”";

	/// <summary>
	/// Key: "Label.ConnectingToPlayers"
	/// Joining a game network with other players
	/// English String: "Connecting to Players..."
	/// </summary>
	public override string LabelConnectingToPlayers => "í”Œë ˆì´ì–´ì™€ ì—°ê²° ì¤‘...";

	/// <summary>
	/// Key: "Label.DevelopPageTitle"
	/// English String: "Develop"
	/// </summary>
	public override string LabelDevelopPageTitle => "ê²Œìž„ ë§Œë“¤ê¸°";

	/// <summary>
	/// Key: "Label.DownloadInstallRoblox"
	/// Download and Install Roblox
	/// English String: "Download and Install Roblox"
	/// </summary>
	public override string LabelDownloadInstallRoblox => "Roblox ë‹¤ìš´ë¡œë“œ ë° ì„¤ì¹˜";

	/// <summary>
	/// Key: "Label.DownloadStudio"
	/// Download Roblox Studio to start creating games
	/// English String: "Download Studio"
	/// </summary>
	public override string LabelDownloadStudio => "Studio ë‹¤ìš´ë¡œë“œ";

	/// <summary>
	/// Key: "Label.GameConfigurePageTitle"
	/// English String: "Game Configure"
	/// </summary>
	public override string LabelGameConfigurePageTitle => "ê²Œìž„ êµ¬ì„±";

	/// <summary>
	/// Key: "Label.GameFreeSoothsayer"
	/// English String: "Free because you are a soothsayer"
	/// </summary>
	public override string LabelGameFreeSoothsayer => "íšŒì›ë‹˜ì€ ì˜ˆì–¸ìžì´ê¸° ë•Œë¬¸ì— ë¬´ë£Œìž…ë‹ˆë‹¤";

	/// <summary>
	/// Key: "Label.GameUnavailableAccountResrictions"
	/// English String: "The game is unavailable due to account restrictions settings."
	/// </summary>
	public override string LabelGameUnavailableAccountResrictions => "ê³„ì • ì œí•œ ì„¤ì • ë•Œë¬¸ì— ê²Œìž„ì„ ì´ìš©í•  ìˆ˜ ì—†ìŠµë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Label.GameUnavailableCannotPlayGamesStudio"
	/// English String: "You cannot play games from Studio. Please use a web browser to play this game."
	/// </summary>
	public override string LabelGameUnavailableCannotPlayGamesStudio => "Studioì—ì„œëŠ” ê²Œìž„ì„ í”Œë ˆì´í•  ìˆ˜ ì—†ì–´ìš”. ì›¹ ë¸Œë¼ìš°ì €ë¥¼ ì‚¬ìš©í•˜ì—¬ ê²Œìž„ì„ ì¦ê²¨ë³´ì„¸ìš”.";

	/// <summary>
	/// Key: "Label.GameUnavailableClosedToVisitors"
	/// English String: "Sorry, this place is currently closed to visitors."
	/// </summary>
	public override string LabelGameUnavailableClosedToVisitors => "ì£„ì†¡í•©ë‹ˆë‹¤. ë°©ë¬¸ê°ì€ í˜„ìž¬ ë³¸ ìž¥ì†Œë¥¼ ì´ìš©í•˜ì‹¤ ìˆ˜ ì—†ìŠµë‹ˆë‹¤";

	/// <summary>
	/// Key: "Label.GameUnavailableCurrentlyIsPrivateVisitor"
	/// When a game is private, this message is shown to visitors.
	/// English String: "Sorry, this game is private."
	/// </summary>
	public override string LabelGameUnavailableCurrentlyIsPrivateVisitor => "ì£„ì†¡í•©ë‹ˆë‹¤. ë¹„ê³µê°œ ê²Œìž„ìž…ë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Label.GameUnavailableGameInsecure"
	/// U13 users cannot play insecure games unless they are the creator or friends with the creator.
	/// English String: "Sorry, your account is restricted from playing Experimental Games unless you are friends with the creator."
	/// </summary>
	public override string LabelGameUnavailableGameInsecure => "ì£„ì†¡í•©ë‹ˆë‹¤. ê°œë°œìžì™€ ì¹œêµ¬ê°€ ì•„ë‹ˆë©´ íšŒì›ë‹˜ì˜ ê³„ì •ìœ¼ë¡œëŠ” ì‹¤í—˜ ê²Œìž„ì„ í•  ìˆ˜ ì—†ìŠµë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Label.GameUnavailablePermissionLevels"
	/// English String: "The permission levels on this place prevent you from entering."
	/// </summary>
	public override string LabelGameUnavailablePermissionLevels => "ë³¸ ìž¥ì†Œì— ëŒ€í•œ ê¶Œí•œ ì„¤ì • ë•Œë¬¸ì— ìž…ìž¥í•  ìˆ˜ ì—†ìŠµë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Label.GameUnavailablePlaceUnderReview"
	/// English String: "Sorry, this place is currently under review. Try again later."
	/// </summary>
	public override string LabelGameUnavailablePlaceUnderReview => "ì£„ì†¡í•©ë‹ˆë‹¤. ë³¸ ìž¥ì†ŒëŠ” í˜„ìž¬ ê²€í†  ì¤‘ìž…ë‹ˆë‹¤. ë‚˜ì¤‘ì— ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "Label.GameUnavailablePlatform"
	/// English String: "This game is not available on your platform.  Check the games page to see all playable games."
	/// </summary>
	public override string LabelGameUnavailablePlatform => "ì‚¬ìš© ì¤‘ì¸ í”Œëž«í¼ì´ ì§€ì›í•˜ì§€ ì•ŠëŠ” ê²Œìž„ìž…ë‹ˆë‹¤. ê²Œìž„ íŽ˜ì´ì§€ì—ì„œ í”Œë ˆì´ ê°€ëŠ¥í•œ ê²Œìž„ë“¤ì„ ì•Œì•„ë³´ì„¸ìš”.";

	/// <summary>
	/// Key: "Label.GameWarning"
	/// English String: "Warning"
	/// </summary>
	public override string LabelGameWarning => "ì£¼ì˜";

	/// <summary>
	/// Key: "Label.InstallationInstructions"
	/// Installation Instructions
	/// English String: "Installation Instructions"
	/// </summary>
	public override string LabelInstallationInstructions => "ì„¤ì¹˜ ì•ˆë‚´";

	/// <summary>
	/// Key: "Label.LaunchApplication"
	/// Launch Application
	/// English String: "Launch Application"
	/// </summary>
	public override string LabelLaunchApplication => "ì‘ìš© í”„ë¡œê·¸ëž¨ ì‹œìž‘";

	/// <summary>
	/// Key: "Label.PersuadeToDevelopRoblox"
	/// Persuade user to begin developing their own games using Roblox Studio
	/// English String: "Get started creating your own games!"
	/// </summary>
	public override string LabelPersuadeToDevelopRoblox => "ì—¬ëŸ¬ë¶„ë§Œì˜ ê²Œìž„ì„ ë§Œë“¤ì–´ë³´ì„¸ìš”!";

	/// <summary>
	/// Key: "Label.PersuadeToInstallRoblox"
	/// We are exciting the user about Roblox so that they will be persuaded to download and install it.
	/// English String: "You're moments away from getting into the game!"
	/// </summary>
	public override string LabelPersuadeToInstallRoblox => "ê³§ ê²Œìž„ì´ ì‹œìž‘ë©ë‹ˆë‹¤!";

	/// <summary>
	/// Key: "Label.Play"
	/// English String: "Play"
	/// </summary>
	public override string LabelPlay => "í”Œë ˆì´";

	/// <summary>
	/// Key: "Label.PlayInApp"
	/// English String: "Play in App"
	/// </summary>
	public override string LabelPlayInApp => "ì•±ì—ì„œ í”Œë ˆì´";

	/// <summary>
	/// Key: "Label.RobloxLoadingToPlay"
	/// Roblox is loading, so the user is getting excited to start playing a game
	/// English String: "Roblox is now loading. Get ready to play!"
	/// </summary>
	public override string LabelRobloxLoadingToPlay => "Robloxë¥¼ ë¶ˆëŸ¬ì˜¤ëŠ” ì¤‘ìž…ë‹ˆë‹¤. ê²Œìž„ì„ ì¦ê¸¸ ì¤€ë¹„ ë˜ì…¨ë‚˜ìš”?";

	/// <summary>
	/// Key: "Label.StartingRoblox"
	/// Game launch process has started
	/// English String: "Starting Roblox..."
	/// </summary>
	public override string LabelStartingRoblox => "Roblox ì‹œìž‘ ì¤‘...";

	/// <summary>
	/// Key: "Label.SwitchToDesktopMode"
	/// Switch to Desktop Mode
	/// English String: "Switch to Desktop Mode"
	/// </summary>
	public override string LabelSwitchToDesktopMode => "ë°ìŠ¤í¬í†± ëª¨ë“œë¡œ ì „í™˜";

	/// <summary>
	/// Key: "Label.UniverseConfigurePageTitle"
	/// The name of the universe configuration page
	/// English String: "Universe Configuration"
	/// </summary>
	public override string LabelUniverseConfigurePageTitle => "ì„¸ê³„ êµ¬ì„±";

	/// <summary>
	/// Key: "Response.Dialog.ClickHere"
	/// Click here!
	/// English String: "Click here!"
	/// </summary>
	public override string ResponseDialogClickHere => "ì—¬ê¸°ë¥¼ í´ë¦­í•˜ì„¸ìš”!";

	/// <summary>
	/// Key: "Response.Dialog.ErrorLaunching"
	/// An error occurred trying to launch the game.  Please try again later.
	/// English String: "An error occurred trying to launch the game.  Please try again later."
	/// </summary>
	public override string ResponseDialogErrorLaunching => "ê²Œìž„ ì‹œìž‘ ì¤‘ ì˜¤ë¥˜ê°€ ë°œìƒí–ˆì–´ìš”. ë‚˜ì¤‘ì— ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "Response.Dialog.HavingTroubleInstallQuestion"
	/// (Are you) having trouble installing Roblox?
	/// English String: "Having trouble installing Roblox?"
	/// </summary>
	public override string ResponseDialogHavingTroubleInstallQuestion => "Roblox ì„¤ì¹˜ì— ì–´ë ¤ì›€ì„ ê²ªê³  ìžˆë‚˜ìš”?";

	/// <summary>
	/// Key: "Response.Dialog.MacChromeSecondInstruction"
	/// Double-click the Roblox app icon to begin the installation process.
	/// English String: "Double-click the Roblox app icon to begin the installation process."
	/// </summary>
	public override string ResponseDialogMacChromeSecondInstruction => "Roblox ì•± ì•„ì´ì½˜ì„ ë‘ ë²ˆ í´ë¦­í•˜ì—¬ ì„¤ì¹˜ ê³¼ì •ì„ ì‹œìž‘í•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "Response.Dialog.ThanksForPlayingRoblox"
	/// Thanks for playing Roblox
	/// English String: "Thanks for playing Roblox"
	/// </summary>
	public override string ResponseDialogThanksForPlayingRoblox => "Robloxë¥¼ ì´ìš©í•´ ì£¼ì…”ì„œ ê°ì‚¬í•©ë‹ˆë‹¤";

	/// <summary>
	/// Key: "Response.GameTemporarilyUnavailable"
	/// error message (will be followed by link with Action.Retry label)
	/// English String: "Unable to verify that you have access to this game.  Please try again later."
	/// </summary>
	public override string ResponseGameTemporarilyUnavailable => "ë³¸ ê²Œìž„ ì´ìš©ê¶Œ ë³´ìœ  ì—¬ë¶€ í™•ì¸ ë¶ˆê°€. ë‚˜ì¤‘ì— ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";

	public VisitGameResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	/// <summary>
	/// Key: "Action.GamePerformPoorly"
	/// English String: "{warning} This game may perform poorly on your device."
	/// </summary>
	public override string ActionGamePerformPoorly(string warning)
	{
		return $"{warning} ë³¸ ê²Œìž„ì€ ì‚¬ìš© ì¤‘ì¸ ê¸°ê¸°ì—ì„œ ìž˜ ì‹¤í–‰ë˜ì§€ ì•Šì„ ìˆ˜ë„ ìžˆìŠµë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForActionGamePerformPoorly()
	{
		return "{warning} ë³¸ ê²Œìž„ì€ ì‚¬ìš© ì¤‘ì¸ ê¸°ê¸°ì—ì„œ ìž˜ ì‹¤í–‰ë˜ì§€ ì•Šì„ ìˆ˜ë„ ìžˆìŠµë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForActionRetry()
	{
		return "ë‹¤ì‹œ ì‹œë„";
	}

	protected override string _GetTemplateForHeadingErrorStartingGame()
	{
		return "ê²Œìž„ ì‹œìž‘ ì¤‘ ì˜¤ë¥˜ ë°œìƒ";
	}

	protected override string _GetTemplateForHeadingSwitchToDesktopToPlay()
	{
		return "ë°ìŠ¤í¬í†± ëª¨ë“œë¡œ ì „í™˜í•˜ì—¬ ê²Œìž„ í”Œë ˆì´";
	}

	/// <summary>
	/// Key: "Label.BuyAccess"
	/// English String: "Buy Access for {robux} Robux"
	/// </summary>
	public override string LabelBuyAccess(string robux)
	{
		return $"{robux} Robux ì´ìš©ê¶Œ êµ¬ë§¤";
	}

	protected override string _GetTemplateForLabelBuyAccess()
	{
		return "{robux} Robux ì´ìš©ê¶Œ êµ¬ë§¤";
	}

	protected override string _GetTemplateForLabelCancel()
	{
		return "ì·¨ì†Œ";
	}

	protected override string _GetTemplateForLabelCheckingForStudio()
	{
		return "Roblox Studio í™•ì¸ ì¤‘...";
	}

	protected override string _GetTemplateForLabelClickHereForHelp()
	{
		return "ì—¬ê¸°ë¥¼ í´ë¦­í•˜ì—¬ ë„ì›€ì„ ë°›ì•„ë³´ì„¸ìš”";
	}

	protected override string _GetTemplateForLabelConnectingToPlayers()
	{
		return "í”Œë ˆì´ì–´ì™€ ì—°ê²° ì¤‘...";
	}

	protected override string _GetTemplateForLabelDevelopPageTitle()
	{
		return "ê²Œìž„ ë§Œë“¤ê¸°";
	}

	protected override string _GetTemplateForLabelDownloadInstallRoblox()
	{
		return "Roblox ë‹¤ìš´ë¡œë“œ ë° ì„¤ì¹˜";
	}

	protected override string _GetTemplateForLabelDownloadStudio()
	{
		return "Studio ë‹¤ìš´ë¡œë“œ";
	}

	protected override string _GetTemplateForLabelGameConfigurePageTitle()
	{
		return "ê²Œìž„ êµ¬ì„±";
	}

	protected override string _GetTemplateForLabelGameFreeSoothsayer()
	{
		return "íšŒì›ë‹˜ì€ ì˜ˆì–¸ìžì´ê¸° ë•Œë¬¸ì— ë¬´ë£Œìž…ë‹ˆë‹¤";
	}

	/// <summary>
	/// Key: "Label.GameIsPrivatePlayableByGroupOnly"
	/// When a game is private, this message is shown to group developers with a link from where it can be made public.
	/// English String: "Only developers can play because this game is private. Make it public on the {linkStart}Configure Game{linkEnd} page."
	/// </summary>
	public override string LabelGameIsPrivatePlayableByGroupOnly(string linkStart, string linkEnd)
	{
		return $"ë¹„ê³µê°œ ê²Œìž„ì€ ê°œë°œìžë§Œ í”Œë ˆì´í•  ìˆ˜ ìžˆìŠµë‹ˆë‹¤. {linkStart}ê²Œìž„ êµ¬ì„±{linkEnd} íŽ˜ì´ì§€ì—ì„œ ê³µê°œë¡œ ë³€ê²½í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForLabelGameIsPrivatePlayableByGroupOnly()
	{
		return "ë¹„ê³µê°œ ê²Œìž„ì€ ê°œë°œìžë§Œ í”Œë ˆì´í•  ìˆ˜ ìžˆìŠµë‹ˆë‹¤. {linkStart}ê²Œìž„ êµ¬ì„±{linkEnd} íŽ˜ì´ì§€ì—ì„œ ê³µê°œë¡œ ë³€ê²½í•˜ì„¸ìš”.";
	}

	/// <summary>
	/// Key: "Label.GameIsPrivatePlayableByOwnerOnly"
	/// When a game is private, this message is shown to owner with a link from where it can be made public.
	/// English String: "Only you can play because this game is private. Make it public on the {linkStart}Configure Game{linkEnd} page."
	/// </summary>
	public override string LabelGameIsPrivatePlayableByOwnerOnly(string linkStart, string linkEnd)
	{
		return $"ë¹„ê³µê°œ ê²Œìž„ì€ ë³¸ì¸ë§Œ í”Œë ˆì´í•  ìˆ˜ ìžˆìŠµë‹ˆë‹¤. {linkStart}ê²Œìž„ êµ¬ì„±{linkEnd} íŽ˜ì´ì§€ì—ì„œ ê³µê°œë¡œ ë³€ê²½í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForLabelGameIsPrivatePlayableByOwnerOnly()
	{
		return "ë¹„ê³µê°œ ê²Œìž„ì€ ë³¸ì¸ë§Œ í”Œë ˆì´í•  ìˆ˜ ìžˆìŠµë‹ˆë‹¤. {linkStart}ê²Œìž„ êµ¬ì„±{linkEnd} íŽ˜ì´ì§€ì—ì„œ ê³µê°œë¡œ ë³€ê²½í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForLabelGameUnavailableAccountResrictions()
	{
		return "ê³„ì • ì œí•œ ì„¤ì • ë•Œë¬¸ì— ê²Œìž„ì„ ì´ìš©í•  ìˆ˜ ì—†ìŠµë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForLabelGameUnavailableCannotPlayGamesStudio()
	{
		return "Studioì—ì„œëŠ” ê²Œìž„ì„ í”Œë ˆì´í•  ìˆ˜ ì—†ì–´ìš”. ì›¹ ë¸Œë¼ìš°ì €ë¥¼ ì‚¬ìš©í•˜ì—¬ ê²Œìž„ì„ ì¦ê²¨ë³´ì„¸ìš”.";
	}

	protected override string _GetTemplateForLabelGameUnavailableClosedToVisitors()
	{
		return "ì£„ì†¡í•©ë‹ˆë‹¤. ë°©ë¬¸ê°ì€ í˜„ìž¬ ë³¸ ìž¥ì†Œë¥¼ ì´ìš©í•˜ì‹¤ ìˆ˜ ì—†ìŠµë‹ˆë‹¤";
	}

	/// <summary>
	/// Key: "Label.GameUnavailableCurrentlyIsPrivateGroup"
	/// When a game is private, this message is shown to group developers with a link from where it can be made public. Similar to an existing translation. Change is making the message directly address the group developers.
	/// English String: "Only developers can play because this game is private. Make it public on the {linkStart}Develop{linkEnd} page."
	/// </summary>
	public override string LabelGameUnavailableCurrentlyIsPrivateGroup(string linkStart, string linkEnd)
	{
		return $"ë¹„ê³µê°œ ê²Œìž„ì€ ê°œë°œìžë§Œ í”Œë ˆì´í•  ìˆ˜ ìžˆìŠµë‹ˆë‹¤. {linkStart}ê°œë°œ{linkEnd} íŽ˜ì´ì§€ì—ì„œ ê³µê°œë¡œ ë³€ê²½í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForLabelGameUnavailableCurrentlyIsPrivateGroup()
	{
		return "ë¹„ê³µê°œ ê²Œìž„ì€ ê°œë°œìžë§Œ í”Œë ˆì´í•  ìˆ˜ ìžˆìŠµë‹ˆë‹¤. {linkStart}ê°œë°œ{linkEnd} íŽ˜ì´ì§€ì—ì„œ ê³µê°œë¡œ ë³€ê²½í•˜ì„¸ìš”.";
	}

	/// <summary>
	/// Key: "Label.GameUnavailableCurrentlyIsPrivateOwner"
	/// When a game is private, this message is shown to owner with a link from where it can be made public. Similar to an existing translation. Change is making the message directly address the owner.
	/// English String: "Only you can play because this game is private. Make it public on the {linkStart}Develop{linkEnd} page."
	/// </summary>
	public override string LabelGameUnavailableCurrentlyIsPrivateOwner(string linkStart, string linkEnd)
	{
		return $"ë¹„ê³µê°œ ê²Œìž„ì€ ë³¸ì¸ë§Œ í”Œë ˆì´í•  ìˆ˜ ìžˆìŠµë‹ˆë‹¤. {linkStart}ê°œë°œ{linkEnd} íŽ˜ì´ì§€ì—ì„œ ê³µê°œë¡œ ë³€ê²½í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForLabelGameUnavailableCurrentlyIsPrivateOwner()
	{
		return "ë¹„ê³µê°œ ê²Œìž„ì€ ë³¸ì¸ë§Œ í”Œë ˆì´í•  ìˆ˜ ìžˆìŠµë‹ˆë‹¤. {linkStart}ê°œë°œ{linkEnd} íŽ˜ì´ì§€ì—ì„œ ê³µê°œë¡œ ë³€ê²½í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForLabelGameUnavailableCurrentlyIsPrivateVisitor()
	{
		return "ì£„ì†¡í•©ë‹ˆë‹¤. ë¹„ê³µê°œ ê²Œìž„ìž…ë‹ˆë‹¤.";
	}

	/// <summary>
	/// Key: "Label.GameUnavailableCurrentlyPrivate"
	/// When a game is private, this message is shown to user with link from where it can be made public
	/// English String: "This {gameTypeName} is currently private. Make it public on the {developPageLink} page to make it playable."
	/// </summary>
	public override string LabelGameUnavailableCurrentlyPrivate(string gameTypeName, string developPageLink)
	{
		return $"ë³¸ {gameTypeName}ì€(ëŠ”) í˜„ìž¬ ë¹„ê³µê°œ ìƒíƒœìž…ë‹ˆë‹¤. {developPageLink} íŽ˜ì´ì§€ì—ì„œ ê³µê°œë¡œ ë³€ê²½ í›„ í”Œë ˆì´í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForLabelGameUnavailableCurrentlyPrivate()
	{
		return "ë³¸ {gameTypeName}ì€(ëŠ”) í˜„ìž¬ ë¹„ê³µê°œ ìƒíƒœìž…ë‹ˆë‹¤. {developPageLink} íŽ˜ì´ì§€ì—ì„œ ê³µê°œë¡œ ë³€ê²½ í›„ í”Œë ˆì´í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForLabelGameUnavailableGameInsecure()
	{
		return "ì£„ì†¡í•©ë‹ˆë‹¤. ê°œë°œìžì™€ ì¹œêµ¬ê°€ ì•„ë‹ˆë©´ íšŒì›ë‹˜ì˜ ê³„ì •ìœ¼ë¡œëŠ” ì‹¤í—˜ ê²Œìž„ì„ í•  ìˆ˜ ì—†ìŠµë‹ˆë‹¤.";
	}

	/// <summary>
	/// Key: "Label.GameUnavailableNoRootPlace"
	/// English String: "This place is part of a game that has no root place. Add a root place on the {gameConfigureLink} page to make it playable."
	/// </summary>
	public override string LabelGameUnavailableNoRootPlace(string gameConfigureLink)
	{
		return $"ë³¸ ìž¥ì†ŒëŠ” ë£¨íŠ¸ í”Œë ˆì´ìŠ¤ê°€ ì—†ëŠ” ê²Œìž„ì— ì†í•´ ìžˆìŠµë‹ˆë‹¤. í”Œë ˆì´í•˜ë ¤ë©´ {gameConfigureLink} íŽ˜ì´ì§€ì—ì„œ ë£¨íŠ¸ í”Œë ˆì´ìŠ¤ë¥¼ ì¶”ê°€í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForLabelGameUnavailableNoRootPlace()
	{
		return "ë³¸ ìž¥ì†ŒëŠ” ë£¨íŠ¸ í”Œë ˆì´ìŠ¤ê°€ ì—†ëŠ” ê²Œìž„ì— ì†í•´ ìžˆìŠµë‹ˆë‹¤. í”Œë ˆì´í•˜ë ¤ë©´ {gameConfigureLink} íŽ˜ì´ì§€ì—ì„œ ë£¨íŠ¸ í”Œë ˆì´ìŠ¤ë¥¼ ì¶”ê°€í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForLabelGameUnavailablePermissionLevels()
	{
		return "ë³¸ ìž¥ì†Œì— ëŒ€í•œ ê¶Œí•œ ì„¤ì • ë•Œë¬¸ì— ìž…ìž¥í•  ìˆ˜ ì—†ìŠµë‹ˆë‹¤.";
	}

	/// <summary>
	/// Key: "Label.GameUnavailablePlaceNotPartOfGame"
	/// English String: "This place is not currently part of a Game. Add it to a game on the {developPageLink} page to make it playable."
	/// </summary>
	public override string LabelGameUnavailablePlaceNotPartOfGame(string developPageLink)
	{
		return $"í˜„ìž¬ ê²Œìž„ì— í¬í•¨ë˜ì§€ ì•Šì€ ìž¥ì†Œìž…ë‹ˆë‹¤. {developPageLink}ì—ì„œ ê²Œìž„ì— ì¶”ê°€í•œ í›„ í”Œë ˆì´í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForLabelGameUnavailablePlaceNotPartOfGame()
	{
		return "í˜„ìž¬ ê²Œìž„ì— í¬í•¨ë˜ì§€ ì•Šì€ ìž¥ì†Œìž…ë‹ˆë‹¤. {developPageLink}ì—ì„œ ê²Œìž„ì— ì¶”ê°€í•œ í›„ í”Œë ˆì´í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForLabelGameUnavailablePlaceUnderReview()
	{
		return "ì£„ì†¡í•©ë‹ˆë‹¤. ë³¸ ìž¥ì†ŒëŠ” í˜„ìž¬ ê²€í†  ì¤‘ìž…ë‹ˆë‹¤. ë‚˜ì¤‘ì— ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForLabelGameUnavailablePlatform()
	{
		return "ì‚¬ìš© ì¤‘ì¸ í”Œëž«í¼ì´ ì§€ì›í•˜ì§€ ì•ŠëŠ” ê²Œìž„ìž…ë‹ˆë‹¤. ê²Œìž„ íŽ˜ì´ì§€ì—ì„œ í”Œë ˆì´ ê°€ëŠ¥í•œ ê²Œìž„ë“¤ì„ ì•Œì•„ë³´ì„¸ìš”.";
	}

	protected override string _GetTemplateForLabelGameWarning()
	{
		return "ì£¼ì˜";
	}

	protected override string _GetTemplateForLabelInstallationInstructions()
	{
		return "ì„¤ì¹˜ ì•ˆë‚´";
	}

	protected override string _GetTemplateForLabelLaunchApplication()
	{
		return "ì‘ìš© í”„ë¡œê·¸ëž¨ ì‹œìž‘";
	}

	/// <summary>
	/// Key: "Label.OperaInstallSteps"
	/// 1) A window will open. Click Open2) Doubleclick the Roblox icon.
	/// English String: "1) A window will open. Click {startBold}Open{endBold}.{breakLine}2) Doubleclick the Roblox icon."
	/// </summary>
	public override string LabelOperaInstallSteps(string startBold, string endBold, string breakLine)
	{
		return $"1) ì°½ì´ ì—´ë¦¬ë©´ {startBold}ì—´ê¸°{endBold}ë¥¼ í´ë¦­í•˜ì„¸ìš”.{breakLine}2) Roblox ì•„ì´ì½˜ì„ ë”ë¸” í´ë¦­í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForLabelOperaInstallSteps()
	{
		return "1) ì°½ì´ ì—´ë¦¬ë©´ {startBold}ì—´ê¸°{endBold}ë¥¼ í´ë¦­í•˜ì„¸ìš”.{breakLine}2) Roblox ì•„ì´ì½˜ì„ ë”ë¸” í´ë¦­í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForLabelPersuadeToDevelopRoblox()
	{
		return "ì—¬ëŸ¬ë¶„ë§Œì˜ ê²Œìž„ì„ ë§Œë“¤ì–´ë³´ì„¸ìš”!";
	}

	protected override string _GetTemplateForLabelPersuadeToInstallRoblox()
	{
		return "ê³§ ê²Œìž„ì´ ì‹œìž‘ë©ë‹ˆë‹¤!";
	}

	protected override string _GetTemplateForLabelPlay()
	{
		return "í”Œë ˆì´";
	}

	protected override string _GetTemplateForLabelPlayInApp()
	{
		return "ì•±ì—ì„œ í”Œë ˆì´";
	}

	protected override string _GetTemplateForLabelRobloxLoadingToPlay()
	{
		return "Robloxë¥¼ ë¶ˆëŸ¬ì˜¤ëŠ” ì¤‘ìž…ë‹ˆë‹¤. ê²Œìž„ì„ ì¦ê¸¸ ì¤€ë¹„ ë˜ì…¨ë‚˜ìš”?";
	}

	protected override string _GetTemplateForLabelStartingRoblox()
	{
		return "Roblox ì‹œìž‘ ì¤‘...";
	}

	protected override string _GetTemplateForLabelSwitchToDesktopMode()
	{
		return "ë°ìŠ¤í¬í†± ëª¨ë“œë¡œ ì „í™˜";
	}

	protected override string _GetTemplateForLabelUniverseConfigurePageTitle()
	{
		return "ì„¸ê³„ êµ¬ì„±";
	}

	/// <summary>
	/// Key: "Response.CheckAlwaysOpenRoblox"
	/// Check {startBold}Always open links for Roblox{endBold} and click {startBold2}Open Roblox{endBold2} in the dialog box above to join games faster in the future!
	/// English String: "Check {startBold}Always open links for Roblox{endBold} and click {startBold2}Open Roblox{endBold2} in the dialog box above to join games faster in the future!"
	/// </summary>
	public override string ResponseCheckAlwaysOpenRoblox(string startBold, string endBold, string startBold2, string endBold2)
	{
		return $"ìƒë‹¨ ëŒ€í™” ìƒìžì—ì„œ {startBold}í•­ìƒ Roblox ë§í¬ ì—´ê¸°{endBold}ë¥¼ ì„ íƒ í›„ {startBold2}Roblox ì—´ê¸°{endBold2}ë¥¼ í´ë¦­í•˜ë©´ ë‹¤ìŒë²ˆì— ê²Œìž„ì„ ë” ë¹¨ë¦¬ ì‹œìž‘í•  ìˆ˜ ìžˆì–´ìš”!";
	}

	protected override string _GetTemplateForResponseCheckAlwaysOpenRoblox()
	{
		return "ìƒë‹¨ ëŒ€í™” ìƒìžì—ì„œ {startBold}í•­ìƒ Roblox ë§í¬ ì—´ê¸°{endBold}ë¥¼ ì„ íƒ í›„ {startBold2}Roblox ì—´ê¸°{endBold2}ë¥¼ í´ë¦­í•˜ë©´ ë‹¤ìŒë²ˆì— ê²Œìž„ì„ ë” ë¹¨ë¦¬ ì‹œìž‘í•  ìˆ˜ ìžˆì–´ìš”!";
	}

	/// <summary>
	/// Key: "Response.CheckAlwaysOpenRobloxURL"
	/// Check {startBold}Always open links for URL: Roblox Protocol{endBold} and click {startBold}Open URL: Roblox Protocol{endBold} in the dialog box above to join games faster in the future!
	/// English String: "Check {startBold}Always open links for URL: Roblox Protocol{endBold} and click {startBold2}Open URL: Roblox Protocol{endBold2} in the dialog box above to join games faster in the future!"
	/// </summary>
	public override string ResponseCheckAlwaysOpenRobloxURL(string startBold, string endBold, string startBold2, string endBold2)
	{
		return $"ìƒë‹¨ ëŒ€í™” ìƒìžì—ì„œ {startBold}í•­ìƒ URL: Roblox Protocol ë§í¬ ì—´ê¸°{endBold}ë¥¼ ì„ íƒ í›„ {startBold2}URL: Roblox Protocol ì—´ê¸°{endBold2}ë¥¼ í´ë¦­í•˜ë©´ ë‹¤ìŒë²ˆì— ê²Œìž„ì„ ë” ë¹¨ë¦¬ ì‹œìž‘í•  ìˆ˜ ìžˆì–´ìš”!";
	}

	protected override string _GetTemplateForResponseCheckAlwaysOpenRobloxURL()
	{
		return "ìƒë‹¨ ëŒ€í™” ìƒìžì—ì„œ {startBold}í•­ìƒ URL: Roblox Protocol ë§í¬ ì—´ê¸°{endBold}ë¥¼ ì„ íƒ í›„ {startBold2}URL: Roblox Protocol ì—´ê¸°{endBold2}ë¥¼ í´ë¦­í•˜ë©´ ë‹¤ìŒë²ˆì— ê²Œìž„ì„ ë” ë¹¨ë¦¬ ì‹œìž‘í•  ìˆ˜ ìžˆì–´ìš”!";
	}

	/// <summary>
	/// Key: "Response.CheckRememberMyChoiceOK"
	/// Check Remember my choice and click OK in the dialog box above to join games faster in the future!
	/// English String: "Check {startBold}Remember my choice{endBold} and click {startBold2}OK{endBold2} in the dialog box above to join games faster in the future!"
	/// </summary>
	public override string ResponseCheckRememberMyChoiceOK(string startBold, string endBold, string startBold2, string endBold2)
	{
		return $"ìƒë‹¨ ëŒ€í™” ìƒìžì—ì„œ {startBold}ë‚´ ì„ íƒ ê¸°ì–µí•˜ê¸°{endBold}ë¥¼ ì²´í¬ í›„ {startBold2}í™•ì¸{endBold2}ì„ í´ë¦­í•˜ë©´ ë‹¤ìŒë²ˆì— ê²Œìž„ì„ ë” ë¹¨ë¦¬ ì‹œìž‘í•  ìˆ˜ ìžˆì–´ìš”!";
	}

	protected override string _GetTemplateForResponseCheckRememberMyChoiceOK()
	{
		return "ìƒë‹¨ ëŒ€í™” ìƒìžì—ì„œ {startBold}ë‚´ ì„ íƒ ê¸°ì–µí•˜ê¸°{endBold}ë¥¼ ì²´í¬ í›„ {startBold2}í™•ì¸{endBold2}ì„ í´ë¦­í•˜ë©´ ë‹¤ìŒë²ˆì— ê²Œìž„ì„ ë” ë¹¨ë¦¬ ì‹œìž‘í•  ìˆ˜ ìžˆì–´ìš”!";
	}

	protected override string _GetTemplateForResponseDialogClickHere()
	{
		return "ì—¬ê¸°ë¥¼ í´ë¦­í•˜ì„¸ìš”!";
	}

	protected override string _GetTemplateForResponseDialogErrorLaunching()
	{
		return "ê²Œìž„ ì‹œìž‘ ì¤‘ ì˜¤ë¥˜ê°€ ë°œìƒí–ˆì–´ìš”. ë‚˜ì¤‘ì— ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForResponseDialogHavingTroubleInstallQuestion()
	{
		return "Roblox ì„¤ì¹˜ì— ì–´ë ¤ì›€ì„ ê²ªê³  ìžˆë‚˜ìš”?";
	}

	/// <summary>
	/// Key: "Response.Dialog.InstallingMessageWithLink"
	/// Note: For this translation, please move the linkStart and linkEnd variables with the translation for download now.
	/// English String: "The Roblox installer should download shortly. If it doesnâ€™t, start the {linkStart}download now.{linkEnd}"
	/// </summary>
	public override string ResponseDialogInstallingMessageWithLink(string linkStart, string linkEnd)
	{
		return $"Roblox ì„¤ì¹˜ í”„ë¡œê·¸ëž¨ì˜ ë‹¤ìš´ë¡œë“œê°€ ê³§ ì‹œìž‘ë©ë‹ˆë‹¤. ì‹œìž‘ë˜ì§€ ì•Šìœ¼ë©´ {linkStart}ì§€ê¸ˆ ë‹¤ìš´ë¡œë“œ{linkEnd}ë¥¼ í´ë¦­í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForResponseDialogInstallingMessageWithLink()
	{
		return "Roblox ì„¤ì¹˜ í”„ë¡œê·¸ëž¨ì˜ ë‹¤ìš´ë¡œë“œê°€ ê³§ ì‹œìž‘ë©ë‹ˆë‹¤. ì‹œìž‘ë˜ì§€ ì•Šìœ¼ë©´ {linkStart}ì§€ê¸ˆ ë‹¤ìš´ë¡œë“œ{linkEnd}ë¥¼ í´ë¦­í•˜ì„¸ìš”.";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacChromeFifthInstruction"
	/// After installation, click {startBold}Play{endBold} below to join the action!
	/// English String: "After installation, click {startBold}Play{endBold} below to join the action!"
	/// </summary>
	public override string ResponseDialogMacChromeFifthInstruction(string startBold, string endBold)
	{
		return $"ì„¤ì¹˜ê°€ ì™„ë£Œë˜ë©´ í•˜ë‹¨ì˜ {startBold}í”Œë ˆì´{endBold} ë²„íŠ¼ì„ í´ë¦­í•˜ì—¬ ê²Œìž„ì„ ì‹œìž‘í•˜ì„¸ìš”!";
	}

	protected override string _GetTemplateForResponseDialogMacChromeFifthInstruction()
	{
		return "ì„¤ì¹˜ê°€ ì™„ë£Œë˜ë©´ í•˜ë‹¨ì˜ {startBold}í”Œë ˆì´{endBold} ë²„íŠ¼ì„ í´ë¦­í•˜ì—¬ ê²Œìž„ì„ ì‹œìž‘í•˜ì„¸ìš”!";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacChromeFirstInstruction"
	/// Click {startBold}Roblox.dmg{endBold} to run the Roblox installer, which just downloaded via your web browser.
	/// English String: "Click {startBold}Roblox.dmg{endBold} to run the Roblox installer, which just downloaded via your web browser."
	/// </summary>
	public override string ResponseDialogMacChromeFirstInstruction(string startBold, string endBold)
	{
		return $"ë°©ê¸ˆ ì›¹ ë¸Œë¼ìš°ì €ë¥¼ í†µí•´ ë‹¤ìš´ë¡œë“œí•œ {startBold}Roblox.dmg{endBold}ë¥¼ í´ë¦­í•˜ì—¬ Roblox ì„¤ì¹˜ í”„ë¡œê·¸ëž¨ì„ ì‹¤í–‰í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForResponseDialogMacChromeFirstInstruction()
	{
		return "ë°©ê¸ˆ ì›¹ ë¸Œë¼ìš°ì €ë¥¼ í†µí•´ ë‹¤ìš´ë¡œë“œí•œ {startBold}Roblox.dmg{endBold}ë¥¼ í´ë¦­í•˜ì—¬ Roblox ì„¤ì¹˜ í”„ë¡œê·¸ëž¨ì„ ì‹¤í–‰í•˜ì„¸ìš”.";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacChromeFourthInstruction"
	/// Click {startBold}Ok{endBold} once you've successfully installed Roblox.
	/// English String: "Click {startBold}Ok{endBold} once you've successfully installed Roblox."
	/// </summary>
	public override string ResponseDialogMacChromeFourthInstruction(string startBold, string endBold)
	{
		return $"Roblox ì„¤ì¹˜ê°€ ì™„ë£Œë˜ë©´ {startBold}í™•ì¸{endBold}ì„ í´ë¦­í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForResponseDialogMacChromeFourthInstruction()
	{
		return "Roblox ì„¤ì¹˜ê°€ ì™„ë£Œë˜ë©´ {startBold}í™•ì¸{endBold}ì„ í´ë¦­í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForResponseDialogMacChromeSecondInstruction()
	{
		return "Roblox ì•± ì•„ì´ì½˜ì„ ë‘ ë²ˆ í´ë¦­í•˜ì—¬ ì„¤ì¹˜ ê³¼ì •ì„ ì‹œìž‘í•˜ì„¸ìš”.";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacChromeThirdInstruction"
	/// Click {startBold}Open{endBold} when prompted by your computer.
	/// English String: "Click {startBold}Open{endBold} when prompted by your computer."
	/// </summary>
	public override string ResponseDialogMacChromeThirdInstruction(string startBold, string endBold)
	{
		return $"ì»´í“¨í„°ì— ë©”ì‹œì§€ê°€ í‘œì‹œë˜ë©´ {startBold}ì—´ê¸°{endBold}ë¥¼ í´ë¦­í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForResponseDialogMacChromeThirdInstruction()
	{
		return "ì»´í“¨í„°ì— ë©”ì‹œì§€ê°€ í‘œì‹œë˜ë©´ {startBold}ì—´ê¸°{endBold}ë¥¼ í´ë¦­í•˜ì„¸ìš”.";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacFirefoxFifthInstruction"
	/// Then select the Remember my choice... checkbox and click OK
	/// English String: "Then select the {startBold}Remember my choice...{endBold} checkbox and click {startBold2}OK{endBold2}"
	/// </summary>
	public override string ResponseDialogMacFirefoxFifthInstruction(string startBold, string endBold, string startBold2, string endBold2)
	{
		return $"ê·¸ ë‹¤ìŒ {startBold}ë‚´ ì„ íƒ ê¸°ì–µí•˜ê¸°...{endBold}ë¥¼ ì„ íƒ í›„ {startBold2}í™•ì¸{endBold2}ì„ í´ë¦­í•˜ì„¸ìš”";
	}

	protected override string _GetTemplateForResponseDialogMacFirefoxFifthInstruction()
	{
		return "ê·¸ ë‹¤ìŒ {startBold}ë‚´ ì„ íƒ ê¸°ì–µí•˜ê¸°...{endBold}ë¥¼ ì„ íƒ í›„ {startBold2}í™•ì¸{endBold2}ì„ í´ë¦­í•˜ì„¸ìš”";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacFirefoxFirstInstruction"
	/// Select Open with and click OK
	/// English String: "Select {startBold}Open with{endBold} and click {startBold2}OK{endBold2}"
	/// </summary>
	public override string ResponseDialogMacFirefoxFirstInstruction(string startBold, string endBold, string startBold2, string endBold2)
	{
		return $"{startBold}ë‹¤ë¥¸ í”„ë¡œê·¸ëž¨ìœ¼ë¡œ ì—´ê¸°{endBold}ë¥¼ ì„ íƒ í›„ {startBold2}í™•ì¸{endBold2}ì„ í´ë¦­í•˜ì„¸ìš”";
	}

	protected override string _GetTemplateForResponseDialogMacFirefoxFirstInstruction()
	{
		return "{startBold}ë‹¤ë¥¸ í”„ë¡œê·¸ëž¨ìœ¼ë¡œ ì—´ê¸°{endBold}ë¥¼ ì„ íƒ í›„ {startBold2}í™•ì¸{endBold2}ì„ í´ë¦­í•˜ì„¸ìš”";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacFirefoxFourthInstruction"
	/// Once installed, click Play to join the action!
	/// English String: "Once installed, click {startBold}Play{endBold} to join the action!"
	/// </summary>
	public override string ResponseDialogMacFirefoxFourthInstruction(string startBold, string endBold)
	{
		return $"ì„¤ì¹˜ê°€ ì™„ë£Œë˜ë©´ {startBold}í”Œë ˆì´{endBold} ë²„íŠ¼ì„ í´ë¦­í•˜ì—¬ ì‹œìž‘í•˜ì„¸ìš”!";
	}

	protected override string _GetTemplateForResponseDialogMacFirefoxFourthInstruction()
	{
		return "ì„¤ì¹˜ê°€ ì™„ë£Œë˜ë©´ {startBold}í”Œë ˆì´{endBold} ë²„íŠ¼ì„ í´ë¦­í•˜ì—¬ ì‹œìž‘í•˜ì„¸ìš”!";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacFirefoxSecondInstruction"
	/// Double-click the Roblox Icon to begin the installation process
	/// English String: "Double-click the {startBold}Roblox Icon{endBold} to begin the installation process"
	/// </summary>
	public override string ResponseDialogMacFirefoxSecondInstruction(string startBold, string endBold)
	{
		return $"{startBold}Roblox ì•„ì´ì½˜{endBold}ì„ ë”ë¸” í´ë¦­í•˜ì—¬ ì„¤ì¹˜ ê³¼ì •ì„ ì‹œìž‘í•˜ì„¸ìš”";
	}

	protected override string _GetTemplateForResponseDialogMacFirefoxSecondInstruction()
	{
		return "{startBold}Roblox ì•„ì´ì½˜{endBold}ì„ ë”ë¸” í´ë¦­í•˜ì—¬ ì„¤ì¹˜ ê³¼ì •ì„ ì‹œìž‘í•˜ì„¸ìš”";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacFirefoxThirdInstruction"
	/// You will receive a warning, click Open
	/// English String: "You will receive a warning, click {startBold}Open{endBold}"
	/// </summary>
	public override string ResponseDialogMacFirefoxThirdInstruction(string startBold, string endBold)
	{
		return $"ê²½ê³ ê°€ ë‚˜íƒ€ë‚˜ë©´ {startBold}ì—´ê¸°{endBold}ë¥¼ í´ë¦­í•˜ì„¸ìš”";
	}

	protected override string _GetTemplateForResponseDialogMacFirefoxThirdInstruction()
	{
		return "ê²½ê³ ê°€ ë‚˜íƒ€ë‚˜ë©´ {startBold}ì—´ê¸°{endBold}ë¥¼ í´ë¦­í•˜ì„¸ìš”";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacSafariFirstInstruction"
	/// Go to Downloads and double-click Roblox.dmg
	/// English String: "Go to Downloads and double-click {startBold}Roblox.dmg{endBold}"
	/// </summary>
	public override string ResponseDialogMacSafariFirstInstruction(string startBold, string endBold)
	{
		return $"ë‹¤ìš´ë¡œë“œë¡œ ê°€ì„œ {startBold}Roblox.dmg{endBold}ë¥¼ ë”ë¸” í´ë¦­í•˜ì„¸ìš”";
	}

	protected override string _GetTemplateForResponseDialogMacSafariFirstInstruction()
	{
		return "ë‹¤ìš´ë¡œë“œë¡œ ê°€ì„œ {startBold}Roblox.dmg{endBold}ë¥¼ ë”ë¸” í´ë¦­í•˜ì„¸ìš”";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacSafariFourthInstruction"
	/// Once installed, click {startBold}Play{endBold} to join the action!
	/// English String: "Once installed, click {startBold}Play{endBold} to join the action!"
	/// </summary>
	public override string ResponseDialogMacSafariFourthInstruction(string startBold, string endBold)
	{
		return $"ì„¤ì¹˜ê°€ ì™„ë£Œë˜ë©´ {startBold}í”Œë ˆì´{endBold}ë¥¼ í´ë¦­í•˜ì—¬ ì‹œìž‘í•˜ì„¸ìš”!";
	}

	protected override string _GetTemplateForResponseDialogMacSafariFourthInstruction()
	{
		return "ì„¤ì¹˜ê°€ ì™„ë£Œë˜ë©´ {startBold}í”Œë ˆì´{endBold}ë¥¼ í´ë¦­í•˜ì—¬ ì‹œìž‘í•˜ì„¸ìš”!";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacSafariSecondInstruction"
	/// Double-click the {startBold}Roblox Icon{endBold} to begin the installation process
	/// English String: "Double-click the {startBold}Roblox Icon{endBold} to begin the installation process"
	/// </summary>
	public override string ResponseDialogMacSafariSecondInstruction(string startBold, string endBold)
	{
		return $"{startBold}Roblox ì•„ì´ì½˜{endBold}ì„ ë”ë¸” í´ë¦­í•˜ì—¬ ì„¤ì¹˜ ê³¼ì •ì„ ì‹œìž‘í•˜ì„¸ìš”";
	}

	protected override string _GetTemplateForResponseDialogMacSafariSecondInstruction()
	{
		return "{startBold}Roblox ì•„ì´ì½˜{endBold}ì„ ë”ë¸” í´ë¦­í•˜ì—¬ ì„¤ì¹˜ ê³¼ì •ì„ ì‹œìž‘í•˜ì„¸ìš”";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacSafariThirdInstruction"
	/// You will receive a warning, click {startBold}Open{endBold}
	/// English String: "You will receive a warning, click {startBold}Open{endBold}"
	/// </summary>
	public override string ResponseDialogMacSafariThirdInstruction(string startBold, string endBold)
	{
		return $"ê²½ê³ ê°€ ë‚˜íƒ€ë‚˜ë©´ {startBold}ì—´ê¸°{endBold}ë¥¼ í´ë¦­í•˜ì„¸ìš”";
	}

	protected override string _GetTemplateForResponseDialogMacSafariThirdInstruction()
	{
		return "ê²½ê³ ê°€ ë‚˜íƒ€ë‚˜ë©´ {startBold}ì—´ê¸°{endBold}ë¥¼ í´ë¦­í•˜ì„¸ìš”";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcChromeFirstInstruction"
	/// Click {startBold}RobloxPlayer.exe{endBold} to run the Roblox installer, which just downloaded via your web browser.
	/// English String: "Click {startBold}RobloxPlayer.exe{endBold} to run the Roblox installer, which just downloaded via your web browser."
	/// </summary>
	public override string ResponseDialogPcChromeFirstInstruction(string startBold, string endBold)
	{
		return $"ë°©ê¸ˆ ì›¹ ë¸Œë¼ìš°ì €ë¥¼ í†µí•´ ë‹¤ìš´ë¡œë“œí•œ {startBold}RobloxPlayer.exe{endBold}ë¥¼ í´ë¦­í•˜ì—¬ Roblox ì„¤ì¹˜ í”„ë¡œê·¸ëž¨ì„ ì‹¤í–‰í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForResponseDialogPcChromeFirstInstruction()
	{
		return "ë°©ê¸ˆ ì›¹ ë¸Œë¼ìš°ì €ë¥¼ í†µí•´ ë‹¤ìš´ë¡œë“œí•œ {startBold}RobloxPlayer.exe{endBold}ë¥¼ í´ë¦­í•˜ì—¬ Roblox ì„¤ì¹˜ í”„ë¡œê·¸ëž¨ì„ ì‹¤í–‰í•˜ì„¸ìš”.";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcChromeFourthInstruction"
	/// After installation, click {startBold}Play{endBold} below to join the action!
	/// English String: "After installation, click {startBold}Play{endBold} below to join the action!"
	/// </summary>
	public override string ResponseDialogPcChromeFourthInstruction(string startBold, string endBold)
	{
		return $"ì„¤ì¹˜ê°€ ì™„ë£Œë˜ë©´ í•˜ë‹¨ì˜ {startBold}í”Œë ˆì´{endBold} ë²„íŠ¼ì„ í´ë¦­í•˜ì—¬ ê²Œìž„ì„ ì‹œìž‘í•˜ì„¸ìš”!";
	}

	protected override string _GetTemplateForResponseDialogPcChromeFourthInstruction()
	{
		return "ì„¤ì¹˜ê°€ ì™„ë£Œë˜ë©´ í•˜ë‹¨ì˜ {startBold}í”Œë ˆì´{endBold} ë²„íŠ¼ì„ í´ë¦­í•˜ì—¬ ê²Œìž„ì„ ì‹œìž‘í•˜ì„¸ìš”!";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcChromeSecondInstruction"
	/// Click {startBold}Run{endBold} when prompted by your computer to begin the installation process.
	/// English String: "Click {startBold}Run{endBold} when prompted by your computer to begin the installation process."
	/// </summary>
	public override string ResponseDialogPcChromeSecondInstruction(string startBold, string endBold)
	{
		return $"ì»´í“¨í„°ì— ë©”ì‹œì§€ê°€ í‘œì‹œë˜ë©´ {startBold}ì‹¤í–‰{endBold}ì„ í´ë¦­í•˜ì—¬ ì„¤ì¹˜ ê³¼ì •ì„ ì‹œìž‘í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForResponseDialogPcChromeSecondInstruction()
	{
		return "ì»´í“¨í„°ì— ë©”ì‹œì§€ê°€ í‘œì‹œë˜ë©´ {startBold}ì‹¤í–‰{endBold}ì„ í´ë¦­í•˜ì—¬ ì„¤ì¹˜ ê³¼ì •ì„ ì‹œìž‘í•˜ì„¸ìš”.";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcChromeThirdInstruction"
	/// Click {startBold}Ok{endBold} once you've successfully installed Roblox.
	/// English String: "Click {startBold}Ok{endBold} once you've successfully installed Roblox."
	/// </summary>
	public override string ResponseDialogPcChromeThirdInstruction(string startBold, string endBold)
	{
		return $"Roblox ì„¤ì¹˜ê°€ ì™„ë£Œë˜ë©´ {startBold}í™•ì¸{endBold}ì„ í´ë¦­í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForResponseDialogPcChromeThirdInstruction()
	{
		return "Roblox ì„¤ì¹˜ê°€ ì™„ë£Œë˜ë©´ {startBold}í™•ì¸{endBold}ì„ í´ë¦­í•˜ì„¸ìš”.";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcEdgeFirstInstruction"
	/// Click {startBold}Run{endBold} to install Roblox after the download finishes
	/// English String: "Click {startBold}Run{endBold} to install Roblox after the download finishes"
	/// </summary>
	public override string ResponseDialogPcEdgeFirstInstruction(string startBold, string endBold)
	{
		return $"ë‹¤ìš´ë¡œë“œê°€ ëë‚˜ë©´ {startBold}ì‹¤í–‰{endBold}ì„ í´ë¦­í•˜ì—¬ Robloxë¥¼ ì„¤ì¹˜í•˜ì„¸ìš”";
	}

	protected override string _GetTemplateForResponseDialogPcEdgeFirstInstruction()
	{
		return "ë‹¤ìš´ë¡œë“œê°€ ëë‚˜ë©´ {startBold}ì‹¤í–‰{endBold}ì„ í´ë¦­í•˜ì—¬ Robloxë¥¼ ì„¤ì¹˜í•˜ì„¸ìš”";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcEdgeSecondInstruction"
	/// Click {startBold}Ok{endBold} to finish installing Roblox
	/// English String: "Click {startBold}Ok{endBold} to finish installing Roblox"
	/// </summary>
	public override string ResponseDialogPcEdgeSecondInstruction(string startBold, string endBold)
	{
		return $"{startBold}í™•ì¸{endBold}ì„ í´ë¦­í•˜ì—¬ Roblox ì„¤ì¹˜ë¥¼ ì¢…ë£Œí•˜ì„¸ìš”";
	}

	protected override string _GetTemplateForResponseDialogPcEdgeSecondInstruction()
	{
		return "{startBold}í™•ì¸{endBold}ì„ í´ë¦­í•˜ì—¬ Roblox ì„¤ì¹˜ë¥¼ ì¢…ë£Œí•˜ì„¸ìš”";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcEdgeThirdInstruction"
	/// Click the {startBold}Play{endBold} button to join the action!
	/// English String: "Click the {startBold}Play{endBold} button to join the action!"
	/// </summary>
	public override string ResponseDialogPcEdgeThirdInstruction(string startBold, string endBold)
	{
		return $"{startBold}í”Œë ˆì´{endBold} ë²„íŠ¼ì„ í´ë¦­í•˜ì—¬ ê²Œìž„ì„ ì‹œìž‘í•˜ì„¸ìš”!";
	}

	protected override string _GetTemplateForResponseDialogPcEdgeThirdInstruction()
	{
		return "{startBold}í”Œë ˆì´{endBold} ë²„íŠ¼ì„ í´ë¦­í•˜ì—¬ ê²Œìž„ì„ ì‹œìž‘í•˜ì„¸ìš”!";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcFirefoxFifthInstruction"
	/// Click {startBold}Ok{endBold} when the alert pops up
	/// English String: "Click {startBold}Ok{endBold} when the alert pops up"
	/// </summary>
	public override string ResponseDialogPcFirefoxFifthInstruction(string startBold, string endBold)
	{
		return $"ê²½ê³ ê°€ ë‚˜íƒ€ë‚˜ë©´ {startBold}í™•ì¸{endBold}ì„ í´ë¦­í•˜ì„¸ìš”";
	}

	protected override string _GetTemplateForResponseDialogPcFirefoxFifthInstruction()
	{
		return "ê²½ê³ ê°€ ë‚˜íƒ€ë‚˜ë©´ {startBold}í™•ì¸{endBold}ì„ í´ë¦­í•˜ì„¸ìš”";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcFirefoxFirstInstruction"
	/// Click {startBold}Save File{endBold} when the download window pops up
	/// English String: "Click {startBold}Save File{endBold} when the download window pops up"
	/// </summary>
	public override string ResponseDialogPcFirefoxFirstInstruction(string startBold, string endBold)
	{
		return $"ë‹¤ìš´ë¡œë“œ ì°½ì´ ë‚˜íƒ€ë‚˜ë©´ {startBold}íŒŒì¼ ì €ìž¥{endBold}ì„ í´ë¦­í•˜ì„¸ìš”";
	}

	protected override string _GetTemplateForResponseDialogPcFirefoxFirstInstruction()
	{
		return "ë‹¤ìš´ë¡œë“œ ì°½ì´ ë‚˜íƒ€ë‚˜ë©´ {startBold}íŒŒì¼ ì €ìž¥{endBold}ì„ í´ë¦­í•˜ì„¸ìš”";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcFirefoxFourthInstruction"
	/// Once installed, click {startBold}Play{endBold} to join the action!
	/// English String: "Once installed, click {startBold}Play{endBold} to join the action!"
	/// </summary>
	public override string ResponseDialogPcFirefoxFourthInstruction(string startBold, string endBold)
	{
		return $"ì„¤ì¹˜ê°€ ì™„ë£Œë˜ë©´ {startBold}í”Œë ˆì´{endBold} ë²„íŠ¼ì„ í´ë¦­í•˜ì—¬ ê²Œìž„ì„ ì‹œìž‘í•˜ì„¸ìš”!";
	}

	protected override string _GetTemplateForResponseDialogPcFirefoxFourthInstruction()
	{
		return "ì„¤ì¹˜ê°€ ì™„ë£Œë˜ë©´ {startBold}í”Œë ˆì´{endBold} ë²„íŠ¼ì„ í´ë¦­í•˜ì—¬ ê²Œìž„ì„ ì‹œìž‘í•˜ì„¸ìš”!";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcFirefoxSecondInstruction"
	/// Go to Downloads and double click {startBold}RobloxPlayer.exe{endBold}
	/// English String: "Go to Downloads and double click {startBold}RobloxPlayer.exe{endBold}"
	/// </summary>
	public override string ResponseDialogPcFirefoxSecondInstruction(string startBold, string endBold)
	{
		return $"ë‹¤ìš´ë¡œë“œë¡œ ê°€ì„œ {startBold}RobloxPlayer.exe{endBold}ë¥¼ ë”ë¸” í´ë¦­í•˜ì„¸ìš”";
	}

	protected override string _GetTemplateForResponseDialogPcFirefoxSecondInstruction()
	{
		return "ë‹¤ìš´ë¡œë“œë¡œ ê°€ì„œ {startBold}RobloxPlayer.exe{endBold}ë¥¼ ë”ë¸” í´ë¦­í•˜ì„¸ìš”";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcFirefoxThirdInstruction"
	/// Click {startBold}Run{endBold}
	/// English String: "Click {startBold}Run{endBold}"
	/// </summary>
	public override string ResponseDialogPcFirefoxThirdInstruction(string startBold, string endBold)
	{
		return $"{startBold}ì‹¤í–‰{endBold}ì„ í´ë¦­í•˜ì„¸ìš”";
	}

	protected override string _GetTemplateForResponseDialogPcFirefoxThirdInstruction()
	{
		return "{startBold}ì‹¤í–‰{endBold}ì„ í´ë¦­í•˜ì„¸ìš”";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcIEFirstInstruction"
	/// You will receive a warning, click {startBold}Run{endBold}
	/// English String: "You will receive a warning, click {startBold}Run{endBold}"
	/// </summary>
	public override string ResponseDialogPcIEFirstInstruction(string startBold, string endBold)
	{
		return $"ê²½ê³ ê°€ ë‚˜íƒ€ë‚˜ë©´ {startBold}ì‹¤í–‰{endBold}ì„ í´ë¦­í•˜ì„¸ìš”";
	}

	protected override string _GetTemplateForResponseDialogPcIEFirstInstruction()
	{
		return "ê²½ê³ ê°€ ë‚˜íƒ€ë‚˜ë©´ {startBold}ì‹¤í–‰{endBold}ì„ í´ë¦­í•˜ì„¸ìš”";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcIeInstructionOne"
	/// You will receive a warning, click {startBold}Run{endBold}
	/// English String: "You will receive a warning, click {startBold}Run{endBold}"
	/// </summary>
	public override string ResponseDialogPcIeInstructionOne(string startBold, string endBold)
	{
		return $"ê²½ê³ ê°€ ë‚˜íƒ€ë‚˜ë©´ {startBold}ì‹¤í–‰{endBold}ì„ í´ë¦­í•˜ì„¸ìš”";
	}

	protected override string _GetTemplateForResponseDialogPcIeInstructionOne()
	{
		return "ê²½ê³ ê°€ ë‚˜íƒ€ë‚˜ë©´ {startBold}ì‹¤í–‰{endBold}ì„ í´ë¦­í•˜ì„¸ìš”";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcIeInstructionThree"
	/// Click {startBold}Run{endBold}
	/// English String: "Click {startBold}Run{endBold}"
	/// </summary>
	public override string ResponseDialogPcIeInstructionThree(string startBold, string endBold)
	{
		return $"{startBold}ì‹¤í–‰{endBold}ì„ í´ë¦­í•˜ì„¸ìš”";
	}

	protected override string _GetTemplateForResponseDialogPcIeInstructionThree()
	{
		return "{startBold}ì‹¤í–‰{endBold}ì„ í´ë¦­í•˜ì„¸ìš”";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcIeInstructionTwo"
	/// Go to Downloads and double click {startBold}RobloxPlayer.exe{endBold}
	/// English String: "Go to Downloads and double click {startBold}RobloxPlayer.exe{endBold}"
	/// </summary>
	public override string ResponseDialogPcIeInstructionTwo(string startBold, string endBold)
	{
		return $"ë‹¤ìš´ë¡œë“œë¡œ ê°€ì„œ {startBold}RobloxPlayer.exe{endBold}ë¥¼ ë”ë¸” í´ë¦­í•˜ì„¸ìš”";
	}

	protected override string _GetTemplateForResponseDialogPcIeInstructionTwo()
	{
		return "ë‹¤ìš´ë¡œë“œë¡œ ê°€ì„œ {startBold}RobloxPlayer.exe{endBold}ë¥¼ ë”ë¸” í´ë¦­í•˜ì„¸ìš”";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcIESecondInstruction"
	/// Click {startBold}Ok{endBold} once you've installed Roblox
	/// English String: "Click {startBold}Ok{endBold} once you've installed Roblox"
	/// </summary>
	public override string ResponseDialogPcIESecondInstruction(string startBold, string endBold)
	{
		return $"Roblox ì„¤ì¹˜ê°€ ì™„ë£Œë˜ë©´ {startBold}í™•ì¸{endBold}ì„ í´ë¦­í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForResponseDialogPcIESecondInstruction()
	{
		return "Roblox ì„¤ì¹˜ê°€ ì™„ë£Œë˜ë©´ {startBold}í™•ì¸{endBold}ì„ í´ë¦­í•˜ì„¸ìš”.";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcIEThirdInstruction"
	/// Once installed, click {startBold}Play{endBold} to join the action!
	/// English String: "Once installed, click {startBold}Play{endBold} to join the action!"
	/// </summary>
	public override string ResponseDialogPcIEThirdInstruction(string startBold, string endBold)
	{
		return $"ì„¤ì¹˜ê°€ ì™„ë£Œë˜ë©´ {startBold}í”Œë ˆì´{endBold} ë²„íŠ¼ì„ í´ë¦­í•˜ì—¬ ê²Œìž„ì„ ì‹œìž‘í•˜ì„¸ìš”!";
	}

	protected override string _GetTemplateForResponseDialogPcIEThirdInstruction()
	{
		return "ì„¤ì¹˜ê°€ ì™„ë£Œë˜ë©´ {startBold}í”Œë ˆì´{endBold} ë²„íŠ¼ì„ í´ë¦­í•˜ì—¬ ê²Œìž„ì„ ì‹œìž‘í•˜ì„¸ìš”!";
	}

	protected override string _GetTemplateForResponseDialogThanksForPlayingRoblox()
	{
		return "Robloxë¥¼ ì´ìš©í•´ ì£¼ì…”ì„œ ê°ì‚¬í•©ë‹ˆë‹¤";
	}

	protected override string _GetTemplateForResponseGameTemporarilyUnavailable()
	{
		return "ë³¸ ê²Œìž„ ì´ìš©ê¶Œ ë³´ìœ  ì—¬ë¶€ í™•ì¸ ë¶ˆê°€. ë‚˜ì¤‘ì— ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";
	}

	/// <summary>
	/// Key: "Response.RememberMyChoiceAppLaunch"
	/// Check {startBold}Remember my choice{endBold} and click {appLaunchLink} in the dialog box above to join games faster in the future!
	/// English String: "Check {startBold}Remember my choice{endBold} and click {appLaunchLink} in the dialog box above to join games faster in the future!"
	/// </summary>
	public override string ResponseRememberMyChoiceAppLaunch(string startBold, string endBold, string appLaunchLink)
	{
		return $"ìƒë‹¨ ëŒ€í™” ìƒìžì—ì„œ {startBold}ë‚´ ì„ íƒ ê¸°ì–µí•˜ê¸°{endBold}ë¥¼ ì²´í¬ í›„ {appLaunchLink}ì„ í´ë¦­í•˜ë©´ ë‹¤ìŒë²ˆì— ê²Œìž„ì„ ë” ë¹¨ë¦¬ ì‹œìž‘í•  ìˆ˜ ìžˆì–´ìš”!";
	}

	protected override string _GetTemplateForResponseRememberMyChoiceAppLaunch()
	{
		return "ìƒë‹¨ ëŒ€í™” ìƒìžì—ì„œ {startBold}ë‚´ ì„ íƒ ê¸°ì–µí•˜ê¸°{endBold}ë¥¼ ì²´í¬ í›„ {appLaunchLink}ì„ í´ë¦­í•˜ë©´ ë‹¤ìŒë²ˆì— ê²Œìž„ì„ ë” ë¹¨ë¦¬ ì‹œìž‘í•  ìˆ˜ ìžˆì–´ìš”!";
	}
}


}
