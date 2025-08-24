using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Common;

internal class VisitGameResources_en_us : TranslationResourcesBase, IVisitGameResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "Action.Retry"
	/// button label
	/// English String: "Retry"
	/// </summary>
	public virtual string ActionRetry => "Retry";

	/// <summary>
	/// Key: "Heading.ErrorStartingGame"
	/// Error starting game
	/// English String: "Error starting game"
	/// </summary>
	public virtual string HeadingErrorStartingGame => "Error starting game";

	/// <summary>
	/// Key: "Heading.SwitchToDesktopToPlay"
	/// Switch to Desktop Mode to Play Games
	/// English String: "Switch to Desktop Mode to Play Games"
	/// </summary>
	public virtual string HeadingSwitchToDesktopToPlay => "Switch to Desktop Mode to Play Games";

	/// <summary>
	/// Key: "Label.Cancel"
	/// Cancel
	/// English String: "Cancel"
	/// </summary>
	public virtual string LabelCancel => "Cancel";

	/// <summary>
	/// Key: "Label.CheckingForStudio"
	/// We are checking if user has Roblox Studio installed
	/// English String: "Checking for Roblox Studio..."
	/// </summary>
	public virtual string LabelCheckingForStudio => "Checking for Roblox Studio...";

	/// <summary>
	/// Key: "Label.ClickHereForHelp"
	/// Click here for help
	/// English String: "Click here for help"
	/// </summary>
	public virtual string LabelClickHereForHelp => "Click here for help";

	/// <summary>
	/// Key: "Label.ConnectingToPlayers"
	/// Joining a game network with other players
	/// English String: "Connecting to Players..."
	/// </summary>
	public virtual string LabelConnectingToPlayers => "Connecting to Players...";

	/// <summary>
	/// Key: "Label.DevelopPageTitle"
	/// English String: "Develop"
	/// </summary>
	public virtual string LabelDevelopPageTitle => "Develop";

	/// <summary>
	/// Key: "Label.DownloadInstallRoblox"
	/// Download and Install Roblox
	/// English String: "Download and Install Roblox"
	/// </summary>
	public virtual string LabelDownloadInstallRoblox => "Download and Install Roblox";

	/// <summary>
	/// Key: "Label.DownloadStudio"
	/// Download Roblox Studio to start creating games
	/// English String: "Download Studio"
	/// </summary>
	public virtual string LabelDownloadStudio => "Download Studio";

	/// <summary>
	/// Key: "Label.GameConfigurePageTitle"
	/// English String: "Game Configure"
	/// </summary>
	public virtual string LabelGameConfigurePageTitle => "Game Configure";

	/// <summary>
	/// Key: "Label.GameFreeSoothsayer"
	/// English String: "Free because you are a soothsayer"
	/// </summary>
	public virtual string LabelGameFreeSoothsayer => "Free because you are a soothsayer";

	/// <summary>
	/// Key: "Label.GameUnavailableAccountResrictions"
	/// English String: "The game is unavailable due to account restrictions settings."
	/// </summary>
	public virtual string LabelGameUnavailableAccountResrictions => "The game is unavailable due to account restrictions settings.";

	/// <summary>
	/// Key: "Label.GameUnavailableCannotPlayGamesStudio"
	/// English String: "You cannot play games from Studio. Please use a web browser to play this game."
	/// </summary>
	public virtual string LabelGameUnavailableCannotPlayGamesStudio => "You cannot play games from Studio. Please use a web browser to play this game.";

	/// <summary>
	/// Key: "Label.GameUnavailableClosedToVisitors"
	/// English String: "Sorry, this place is currently closed to visitors."
	/// </summary>
	public virtual string LabelGameUnavailableClosedToVisitors => "Sorry, this place is currently closed to visitors.";

	/// <summary>
	/// Key: "Label.GameUnavailableCurrentlyIsPrivateVisitor"
	/// When a game is private, this message is shown to visitors.
	/// English String: "Sorry, this game is private."
	/// </summary>
	public virtual string LabelGameUnavailableCurrentlyIsPrivateVisitor => "Sorry, this game is private.";

	/// <summary>
	/// Key: "Label.GameUnavailableGameInsecure"
	/// U13 users cannot play insecure games unless they are the creator or friends with the creator.
	/// English String: "Sorry, your account is restricted from playing Experimental Games unless you are friends with the creator."
	/// </summary>
	public virtual string LabelGameUnavailableGameInsecure => "Sorry, your account is restricted from playing Experimental Games unless you are friends with the creator.";

	/// <summary>
	/// Key: "Label.GameUnavailablePermissionLevels"
	/// English String: "The permission levels on this place prevent you from entering."
	/// </summary>
	public virtual string LabelGameUnavailablePermissionLevels => "The permission levels on this place prevent you from entering.";

	/// <summary>
	/// Key: "Label.GameUnavailablePlaceUnderReview"
	/// English String: "Sorry, this place is currently under review. Try again later."
	/// </summary>
	public virtual string LabelGameUnavailablePlaceUnderReview => "Sorry, this place is currently under review. Try again later.";

	/// <summary>
	/// Key: "Label.GameUnavailablePlatform"
	/// English String: "This game is not available on your platform.  Check the games page to see all playable games."
	/// </summary>
	public virtual string LabelGameUnavailablePlatform => "This game is not available on your platform.  Check the games page to see all playable games.";

	/// <summary>
	/// Key: "Label.GameWarning"
	/// English String: "Warning"
	/// </summary>
	public virtual string LabelGameWarning => "Warning";

	/// <summary>
	/// Key: "Label.InstallationInstructions"
	/// Installation Instructions
	/// English String: "Installation Instructions"
	/// </summary>
	public virtual string LabelInstallationInstructions => "Installation Instructions";

	/// <summary>
	/// Key: "Label.LaunchApplication"
	/// Launch Application
	/// English String: "Launch Application"
	/// </summary>
	public virtual string LabelLaunchApplication => "Launch Application";

	/// <summary>
	/// Key: "Label.PersuadeToDevelopRoblox"
	/// Persuade user to begin developing their own games using Roblox Studio
	/// English String: "Get started creating your own games!"
	/// </summary>
	public virtual string LabelPersuadeToDevelopRoblox => "Get started creating your own games!";

	/// <summary>
	/// Key: "Label.PersuadeToInstallRoblox"
	/// We are exciting the user about Roblox so that they will be persuaded to download and install it.
	/// English String: "You're moments away from getting into the game!"
	/// </summary>
	public virtual string LabelPersuadeToInstallRoblox => "You're moments away from getting into the game!";

	/// <summary>
	/// Key: "Label.Play"
	/// English String: "Play"
	/// </summary>
	public virtual string LabelPlay => "Play";

	/// <summary>
	/// Key: "Label.PlayInApp"
	/// English String: "Play in App"
	/// </summary>
	public virtual string LabelPlayInApp => "Play in App";

	/// <summary>
	/// Key: "Label.RobloxLoadingToPlay"
	/// Roblox is loading, so the user is getting excited to start playing a game
	/// English String: "Roblox is now loading. Get ready to play!"
	/// </summary>
	public virtual string LabelRobloxLoadingToPlay => "Roblox is now loading. Get ready to play!";

	/// <summary>
	/// Key: "Label.StartingRoblox"
	/// Game launch process has started
	/// English String: "Starting Roblox..."
	/// </summary>
	public virtual string LabelStartingRoblox => "Starting Roblox...";

	/// <summary>
	/// Key: "Label.SwitchToDesktopMode"
	/// Switch to Desktop Mode
	/// English String: "Switch to Desktop Mode"
	/// </summary>
	public virtual string LabelSwitchToDesktopMode => "Switch to Desktop Mode";

	/// <summary>
	/// Key: "Label.UniverseConfigurePageTitle"
	/// The name of the universe configuration page
	/// English String: "Universe Configuration"
	/// </summary>
	public virtual string LabelUniverseConfigurePageTitle => "Universe Configuration";

	/// <summary>
	/// Key: "Response.Dialog.ClickHere"
	/// Click here!
	/// English String: "Click here!"
	/// </summary>
	public virtual string ResponseDialogClickHere => "Click here!";

	/// <summary>
	/// Key: "Response.Dialog.ErrorLaunching"
	/// An error occurred trying to launch the game.  Please try again later.
	/// English String: "An error occurred trying to launch the game.  Please try again later."
	/// </summary>
	public virtual string ResponseDialogErrorLaunching => "An error occurred trying to launch the game.  Please try again later.";

	/// <summary>
	/// Key: "Response.Dialog.HavingTroubleInstallQuestion"
	/// (Are you) having trouble installing Roblox?
	/// English String: "Having trouble installing Roblox?"
	/// </summary>
	public virtual string ResponseDialogHavingTroubleInstallQuestion => "Having trouble installing Roblox?";

	/// <summary>
	/// Key: "Response.Dialog.MacChromeSecondInstruction"
	/// Double-click the Roblox app icon to begin the installation process.
	/// English String: "Double-click the Roblox app icon to begin the installation process."
	/// </summary>
	public virtual string ResponseDialogMacChromeSecondInstruction => "Double-click the Roblox app icon to begin the installation process.";

	/// <summary>
	/// Key: "Response.Dialog.ThanksForPlayingRoblox"
	/// Thanks for playing Roblox
	/// English String: "Thanks for playing Roblox"
	/// </summary>
	public virtual string ResponseDialogThanksForPlayingRoblox => "Thanks for playing Roblox";

	/// <summary>
	/// Key: "Response.GameTemporarilyUnavailable"
	/// error message (will be followed by link with Action.Retry label)
	/// English String: "Unable to verify that you have access to this game.  Please try again later."
	/// </summary>
	public virtual string ResponseGameTemporarilyUnavailable => "Unable to verify that you have access to this game.  Please try again later.";

	public VisitGameResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"Action.GamePerformPoorly",
				_GetTemplateForActionGamePerformPoorly()
			},
			{
				"Action.Retry",
				_GetTemplateForActionRetry()
			},
			{
				"Heading.ErrorStartingGame",
				_GetTemplateForHeadingErrorStartingGame()
			},
			{
				"Heading.SwitchToDesktopToPlay",
				_GetTemplateForHeadingSwitchToDesktopToPlay()
			},
			{
				"Label.BuyAccess",
				_GetTemplateForLabelBuyAccess()
			},
			{
				"Label.Cancel",
				_GetTemplateForLabelCancel()
			},
			{
				"Label.CheckingForStudio",
				_GetTemplateForLabelCheckingForStudio()
			},
			{
				"Label.ClickHereForHelp",
				_GetTemplateForLabelClickHereForHelp()
			},
			{
				"Label.ConnectingToPlayers",
				_GetTemplateForLabelConnectingToPlayers()
			},
			{
				"Label.DevelopPageTitle",
				_GetTemplateForLabelDevelopPageTitle()
			},
			{
				"Label.DownloadInstallRoblox",
				_GetTemplateForLabelDownloadInstallRoblox()
			},
			{
				"Label.DownloadStudio",
				_GetTemplateForLabelDownloadStudio()
			},
			{
				"Label.GameConfigurePageTitle",
				_GetTemplateForLabelGameConfigurePageTitle()
			},
			{
				"Label.GameFreeSoothsayer",
				_GetTemplateForLabelGameFreeSoothsayer()
			},
			{
				"Label.GameIsPrivatePlayableByGroupOnly",
				_GetTemplateForLabelGameIsPrivatePlayableByGroupOnly()
			},
			{
				"Label.GameIsPrivatePlayableByOwnerOnly",
				_GetTemplateForLabelGameIsPrivatePlayableByOwnerOnly()
			},
			{
				"Label.GameUnavailableAccountResrictions",
				_GetTemplateForLabelGameUnavailableAccountResrictions()
			},
			{
				"Label.GameUnavailableCannotPlayGamesStudio",
				_GetTemplateForLabelGameUnavailableCannotPlayGamesStudio()
			},
			{
				"Label.GameUnavailableClosedToVisitors",
				_GetTemplateForLabelGameUnavailableClosedToVisitors()
			},
			{
				"Label.GameUnavailableCurrentlyIsPrivateGroup",
				_GetTemplateForLabelGameUnavailableCurrentlyIsPrivateGroup()
			},
			{
				"Label.GameUnavailableCurrentlyIsPrivateOwner",
				_GetTemplateForLabelGameUnavailableCurrentlyIsPrivateOwner()
			},
			{
				"Label.GameUnavailableCurrentlyIsPrivateVisitor",
				_GetTemplateForLabelGameUnavailableCurrentlyIsPrivateVisitor()
			},
			{
				"Label.GameUnavailableCurrentlyPrivate",
				_GetTemplateForLabelGameUnavailableCurrentlyPrivate()
			},
			{
				"Label.GameUnavailableGameInsecure",
				_GetTemplateForLabelGameUnavailableGameInsecure()
			},
			{
				"Label.GameUnavailableNoRootPlace",
				_GetTemplateForLabelGameUnavailableNoRootPlace()
			},
			{
				"Label.GameUnavailablePermissionLevels",
				_GetTemplateForLabelGameUnavailablePermissionLevels()
			},
			{
				"Label.GameUnavailablePlaceNotPartOfGame",
				_GetTemplateForLabelGameUnavailablePlaceNotPartOfGame()
			},
			{
				"Label.GameUnavailablePlaceUnderReview",
				_GetTemplateForLabelGameUnavailablePlaceUnderReview()
			},
			{
				"Label.GameUnavailablePlatform",
				_GetTemplateForLabelGameUnavailablePlatform()
			},
			{
				"Label.GameWarning",
				_GetTemplateForLabelGameWarning()
			},
			{
				"Label.InstallationInstructions",
				_GetTemplateForLabelInstallationInstructions()
			},
			{
				"Label.LaunchApplication",
				_GetTemplateForLabelLaunchApplication()
			},
			{
				"Label.OperaInstallSteps",
				_GetTemplateForLabelOperaInstallSteps()
			},
			{
				"Label.PersuadeToDevelopRoblox",
				_GetTemplateForLabelPersuadeToDevelopRoblox()
			},
			{
				"Label.PersuadeToInstallRoblox",
				_GetTemplateForLabelPersuadeToInstallRoblox()
			},
			{
				"Label.Play",
				_GetTemplateForLabelPlay()
			},
			{
				"Label.PlayInApp",
				_GetTemplateForLabelPlayInApp()
			},
			{
				"Label.RobloxLoadingToPlay",
				_GetTemplateForLabelRobloxLoadingToPlay()
			},
			{
				"Label.StartingRoblox",
				_GetTemplateForLabelStartingRoblox()
			},
			{
				"Label.SwitchToDesktopMode",
				_GetTemplateForLabelSwitchToDesktopMode()
			},
			{
				"Label.UniverseConfigurePageTitle",
				_GetTemplateForLabelUniverseConfigurePageTitle()
			},
			{
				"Response.CheckAlwaysOpenRoblox",
				_GetTemplateForResponseCheckAlwaysOpenRoblox()
			},
			{
				"Response.CheckAlwaysOpenRobloxURL",
				_GetTemplateForResponseCheckAlwaysOpenRobloxURL()
			},
			{
				"Response.CheckRememberMyChoiceOK",
				_GetTemplateForResponseCheckRememberMyChoiceOK()
			},
			{
				"Response.Dialog.ClickHere",
				_GetTemplateForResponseDialogClickHere()
			},
			{
				"Response.Dialog.ErrorLaunching",
				_GetTemplateForResponseDialogErrorLaunching()
			},
			{
				"Response.Dialog.HavingTroubleInstallQuestion",
				_GetTemplateForResponseDialogHavingTroubleInstallQuestion()
			},
			{
				"Response.Dialog.InstallingMessageWithLink",
				_GetTemplateForResponseDialogInstallingMessageWithLink()
			},
			{
				"Response.Dialog.MacChromeFifthInstruction",
				_GetTemplateForResponseDialogMacChromeFifthInstruction()
			},
			{
				"Response.Dialog.MacChromeFirstInstruction",
				_GetTemplateForResponseDialogMacChromeFirstInstruction()
			},
			{
				"Response.Dialog.MacChromeFourthInstruction",
				_GetTemplateForResponseDialogMacChromeFourthInstruction()
			},
			{
				"Response.Dialog.MacChromeSecondInstruction",
				_GetTemplateForResponseDialogMacChromeSecondInstruction()
			},
			{
				"Response.Dialog.MacChromeThirdInstruction",
				_GetTemplateForResponseDialogMacChromeThirdInstruction()
			},
			{
				"Response.Dialog.MacFirefoxFifthInstruction",
				_GetTemplateForResponseDialogMacFirefoxFifthInstruction()
			},
			{
				"Response.Dialog.MacFirefoxFirstInstruction",
				_GetTemplateForResponseDialogMacFirefoxFirstInstruction()
			},
			{
				"Response.Dialog.MacFirefoxFourthInstruction",
				_GetTemplateForResponseDialogMacFirefoxFourthInstruction()
			},
			{
				"Response.Dialog.MacFirefoxSecondInstruction",
				_GetTemplateForResponseDialogMacFirefoxSecondInstruction()
			},
			{
				"Response.Dialog.MacFirefoxThirdInstruction",
				_GetTemplateForResponseDialogMacFirefoxThirdInstruction()
			},
			{
				"Response.Dialog.MacSafariFirstInstruction",
				_GetTemplateForResponseDialogMacSafariFirstInstruction()
			},
			{
				"Response.Dialog.MacSafariFourthInstruction",
				_GetTemplateForResponseDialogMacSafariFourthInstruction()
			},
			{
				"Response.Dialog.MacSafariSecondInstruction",
				_GetTemplateForResponseDialogMacSafariSecondInstruction()
			},
			{
				"Response.Dialog.MacSafariThirdInstruction",
				_GetTemplateForResponseDialogMacSafariThirdInstruction()
			},
			{
				"Response.Dialog.PcChromeFirstInstruction",
				_GetTemplateForResponseDialogPcChromeFirstInstruction()
			},
			{
				"Response.Dialog.PcChromeFourthInstruction",
				_GetTemplateForResponseDialogPcChromeFourthInstruction()
			},
			{
				"Response.Dialog.PcChromeSecondInstruction",
				_GetTemplateForResponseDialogPcChromeSecondInstruction()
			},
			{
				"Response.Dialog.PcChromeThirdInstruction",
				_GetTemplateForResponseDialogPcChromeThirdInstruction()
			},
			{
				"Response.Dialog.PcEdgeFirstInstruction",
				_GetTemplateForResponseDialogPcEdgeFirstInstruction()
			},
			{
				"Response.Dialog.PcEdgeSecondInstruction",
				_GetTemplateForResponseDialogPcEdgeSecondInstruction()
			},
			{
				"Response.Dialog.PcEdgeThirdInstruction",
				_GetTemplateForResponseDialogPcEdgeThirdInstruction()
			},
			{
				"Response.Dialog.PcFirefoxFifthInstruction",
				_GetTemplateForResponseDialogPcFirefoxFifthInstruction()
			},
			{
				"Response.Dialog.PcFirefoxFirstInstruction",
				_GetTemplateForResponseDialogPcFirefoxFirstInstruction()
			},
			{
				"Response.Dialog.PcFirefoxFourthInstruction",
				_GetTemplateForResponseDialogPcFirefoxFourthInstruction()
			},
			{
				"Response.Dialog.PcFirefoxSecondInstruction",
				_GetTemplateForResponseDialogPcFirefoxSecondInstruction()
			},
			{
				"Response.Dialog.PcFirefoxThirdInstruction",
				_GetTemplateForResponseDialogPcFirefoxThirdInstruction()
			},
			{
				"Response.Dialog.PcIEFirstInstruction",
				_GetTemplateForResponseDialogPcIEFirstInstruction()
			},
			{
				"Response.Dialog.PcIeInstructionOne",
				_GetTemplateForResponseDialogPcIeInstructionOne()
			},
			{
				"Response.Dialog.PcIeInstructionThree",
				_GetTemplateForResponseDialogPcIeInstructionThree()
			},
			{
				"Response.Dialog.PcIeInstructionTwo",
				_GetTemplateForResponseDialogPcIeInstructionTwo()
			},
			{
				"Response.Dialog.PcIESecondInstruction",
				_GetTemplateForResponseDialogPcIESecondInstruction()
			},
			{
				"Response.Dialog.PcIEThirdInstruction",
				_GetTemplateForResponseDialogPcIEThirdInstruction()
			},
			{
				"Response.Dialog.ThanksForPlayingRoblox",
				_GetTemplateForResponseDialogThanksForPlayingRoblox()
			},
			{
				"Response.GameTemporarilyUnavailable",
				_GetTemplateForResponseGameTemporarilyUnavailable()
			},
			{
				"Response.RememberMyChoiceAppLaunch",
				_GetTemplateForResponseRememberMyChoiceAppLaunch()
			}
		});
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "Common.VisitGame";
	}

	/// <summary>
	/// Key: "Action.GamePerformPoorly"
	/// English String: "{warning} This game may perform poorly on your device."
	/// </summary>
	public virtual string ActionGamePerformPoorly(string warning)
	{
		return $"{warning} This game may perform poorly on your device.";
	}

	protected virtual string _GetTemplateForActionGamePerformPoorly()
	{
		return "{warning} This game may perform poorly on your device.";
	}

	protected virtual string _GetTemplateForActionRetry()
	{
		return "Retry";
	}

	protected virtual string _GetTemplateForHeadingErrorStartingGame()
	{
		return "Error starting game";
	}

	protected virtual string _GetTemplateForHeadingSwitchToDesktopToPlay()
	{
		return "Switch to Desktop Mode to Play Games";
	}

	/// <summary>
	/// Key: "Label.BuyAccess"
	/// English String: "Buy Access for {robux} Robux"
	/// </summary>
	public virtual string LabelBuyAccess(string robux)
	{
		return $"Buy Access for {robux} Robux";
	}

	protected virtual string _GetTemplateForLabelBuyAccess()
	{
		return "Buy Access for {robux} Robux";
	}

	protected virtual string _GetTemplateForLabelCancel()
	{
		return "Cancel";
	}

	protected virtual string _GetTemplateForLabelCheckingForStudio()
	{
		return "Checking for Roblox Studio...";
	}

	protected virtual string _GetTemplateForLabelClickHereForHelp()
	{
		return "Click here for help";
	}

	protected virtual string _GetTemplateForLabelConnectingToPlayers()
	{
		return "Connecting to Players...";
	}

	protected virtual string _GetTemplateForLabelDevelopPageTitle()
	{
		return "Develop";
	}

	protected virtual string _GetTemplateForLabelDownloadInstallRoblox()
	{
		return "Download and Install Roblox";
	}

	protected virtual string _GetTemplateForLabelDownloadStudio()
	{
		return "Download Studio";
	}

	protected virtual string _GetTemplateForLabelGameConfigurePageTitle()
	{
		return "Game Configure";
	}

	protected virtual string _GetTemplateForLabelGameFreeSoothsayer()
	{
		return "Free because you are a soothsayer";
	}

	/// <summary>
	/// Key: "Label.GameIsPrivatePlayableByGroupOnly"
	/// When a game is private, this message is shown to group developers with a link from where it can be made public.
	/// English String: "Only developers can play because this game is private. Make it public on the {linkStart}Configure Game{linkEnd} page."
	/// </summary>
	public virtual string LabelGameIsPrivatePlayableByGroupOnly(string linkStart, string linkEnd)
	{
		return $"Only developers can play because this game is private. Make it public on the {linkStart}Configure Game{linkEnd} page.";
	}

	protected virtual string _GetTemplateForLabelGameIsPrivatePlayableByGroupOnly()
	{
		return "Only developers can play because this game is private. Make it public on the {linkStart}Configure Game{linkEnd} page.";
	}

	/// <summary>
	/// Key: "Label.GameIsPrivatePlayableByOwnerOnly"
	/// When a game is private, this message is shown to owner with a link from where it can be made public.
	/// English String: "Only you can play because this game is private. Make it public on the {linkStart}Configure Game{linkEnd} page."
	/// </summary>
	public virtual string LabelGameIsPrivatePlayableByOwnerOnly(string linkStart, string linkEnd)
	{
		return $"Only you can play because this game is private. Make it public on the {linkStart}Configure Game{linkEnd} page.";
	}

	protected virtual string _GetTemplateForLabelGameIsPrivatePlayableByOwnerOnly()
	{
		return "Only you can play because this game is private. Make it public on the {linkStart}Configure Game{linkEnd} page.";
	}

	protected virtual string _GetTemplateForLabelGameUnavailableAccountResrictions()
	{
		return "The game is unavailable due to account restrictions settings.";
	}

	protected virtual string _GetTemplateForLabelGameUnavailableCannotPlayGamesStudio()
	{
		return "You cannot play games from Studio. Please use a web browser to play this game.";
	}

	protected virtual string _GetTemplateForLabelGameUnavailableClosedToVisitors()
	{
		return "Sorry, this place is currently closed to visitors.";
	}

	/// <summary>
	/// Key: "Label.GameUnavailableCurrentlyIsPrivateGroup"
	/// When a game is private, this message is shown to group developers with a link from where it can be made public. Similar to an existing translation. Change is making the message directly address the group developers.
	/// English String: "Only developers can play because this game is private. Make it public on the {linkStart}Develop{linkEnd} page."
	/// </summary>
	public virtual string LabelGameUnavailableCurrentlyIsPrivateGroup(string linkStart, string linkEnd)
	{
		return $"Only developers can play because this game is private. Make it public on the {linkStart}Develop{linkEnd} page.";
	}

	protected virtual string _GetTemplateForLabelGameUnavailableCurrentlyIsPrivateGroup()
	{
		return "Only developers can play because this game is private. Make it public on the {linkStart}Develop{linkEnd} page.";
	}

	/// <summary>
	/// Key: "Label.GameUnavailableCurrentlyIsPrivateOwner"
	/// When a game is private, this message is shown to owner with a link from where it can be made public. Similar to an existing translation. Change is making the message directly address the owner.
	/// English String: "Only you can play because this game is private. Make it public on the {linkStart}Develop{linkEnd} page."
	/// </summary>
	public virtual string LabelGameUnavailableCurrentlyIsPrivateOwner(string linkStart, string linkEnd)
	{
		return $"Only you can play because this game is private. Make it public on the {linkStart}Develop{linkEnd} page.";
	}

	protected virtual string _GetTemplateForLabelGameUnavailableCurrentlyIsPrivateOwner()
	{
		return "Only you can play because this game is private. Make it public on the {linkStart}Develop{linkEnd} page.";
	}

	protected virtual string _GetTemplateForLabelGameUnavailableCurrentlyIsPrivateVisitor()
	{
		return "Sorry, this game is private.";
	}

	/// <summary>
	/// Key: "Label.GameUnavailableCurrentlyPrivate"
	/// When a game is private, this message is shown to user with link from where it can be made public
	/// English String: "This {gameTypeName} is currently private. Make it public on the {developPageLink} page to make it playable."
	/// </summary>
	public virtual string LabelGameUnavailableCurrentlyPrivate(string gameTypeName, string developPageLink)
	{
		return $"This {gameTypeName} is currently private. Make it public on the {developPageLink} page to make it playable.";
	}

	protected virtual string _GetTemplateForLabelGameUnavailableCurrentlyPrivate()
	{
		return "This {gameTypeName} is currently private. Make it public on the {developPageLink} page to make it playable.";
	}

	protected virtual string _GetTemplateForLabelGameUnavailableGameInsecure()
	{
		return "Sorry, your account is restricted from playing Experimental Games unless you are friends with the creator.";
	}

	/// <summary>
	/// Key: "Label.GameUnavailableNoRootPlace"
	/// English String: "This place is part of a game that has no root place. Add a root place on the {gameConfigureLink} page to make it playable."
	/// </summary>
	public virtual string LabelGameUnavailableNoRootPlace(string gameConfigureLink)
	{
		return $"This place is part of a game that has no root place. Add a root place on the {gameConfigureLink} page to make it playable.";
	}

	protected virtual string _GetTemplateForLabelGameUnavailableNoRootPlace()
	{
		return "This place is part of a game that has no root place. Add a root place on the {gameConfigureLink} page to make it playable.";
	}

	protected virtual string _GetTemplateForLabelGameUnavailablePermissionLevels()
	{
		return "The permission levels on this place prevent you from entering.";
	}

	/// <summary>
	/// Key: "Label.GameUnavailablePlaceNotPartOfGame"
	/// English String: "This place is not currently part of a Game. Add it to a game on the {developPageLink} page to make it playable."
	/// </summary>
	public virtual string LabelGameUnavailablePlaceNotPartOfGame(string developPageLink)
	{
		return $"This place is not currently part of a Game. Add it to a game on the {developPageLink} page to make it playable.";
	}

	protected virtual string _GetTemplateForLabelGameUnavailablePlaceNotPartOfGame()
	{
		return "This place is not currently part of a Game. Add it to a game on the {developPageLink} page to make it playable.";
	}

	protected virtual string _GetTemplateForLabelGameUnavailablePlaceUnderReview()
	{
		return "Sorry, this place is currently under review. Try again later.";
	}

	protected virtual string _GetTemplateForLabelGameUnavailablePlatform()
	{
		return "This game is not available on your platform.  Check the games page to see all playable games.";
	}

	protected virtual string _GetTemplateForLabelGameWarning()
	{
		return "Warning";
	}

	protected virtual string _GetTemplateForLabelInstallationInstructions()
	{
		return "Installation Instructions";
	}

	protected virtual string _GetTemplateForLabelLaunchApplication()
	{
		return "Launch Application";
	}

	/// <summary>
	/// Key: "Label.OperaInstallSteps"
	/// 1) A window will open. Click Open2) Doubleclick the Roblox icon.
	/// English String: "1) A window will open. Click {startBold}Open{endBold}.{breakLine}2) Doubleclick the Roblox icon."
	/// </summary>
	public virtual string LabelOperaInstallSteps(string startBold, string endBold, string breakLine)
	{
		return $"1) A window will open. Click {startBold}Open{endBold}.{breakLine}2) Doubleclick the Roblox icon.";
	}

	protected virtual string _GetTemplateForLabelOperaInstallSteps()
	{
		return "1) A window will open. Click {startBold}Open{endBold}.{breakLine}2) Doubleclick the Roblox icon.";
	}

	protected virtual string _GetTemplateForLabelPersuadeToDevelopRoblox()
	{
		return "Get started creating your own games!";
	}

	protected virtual string _GetTemplateForLabelPersuadeToInstallRoblox()
	{
		return "You're moments away from getting into the game!";
	}

	protected virtual string _GetTemplateForLabelPlay()
	{
		return "Play";
	}

	protected virtual string _GetTemplateForLabelPlayInApp()
	{
		return "Play in App";
	}

	protected virtual string _GetTemplateForLabelRobloxLoadingToPlay()
	{
		return "Roblox is now loading. Get ready to play!";
	}

	protected virtual string _GetTemplateForLabelStartingRoblox()
	{
		return "Starting Roblox...";
	}

	protected virtual string _GetTemplateForLabelSwitchToDesktopMode()
	{
		return "Switch to Desktop Mode";
	}

	protected virtual string _GetTemplateForLabelUniverseConfigurePageTitle()
	{
		return "Universe Configuration";
	}

	/// <summary>
	/// Key: "Response.CheckAlwaysOpenRoblox"
	/// Check {startBold}Always open links for Roblox{endBold} and click {startBold2}Open Roblox{endBold2} in the dialog box above to join games faster in the future!
	/// English String: "Check {startBold}Always open links for Roblox{endBold} and click {startBold2}Open Roblox{endBold2} in the dialog box above to join games faster in the future!"
	/// </summary>
	public virtual string ResponseCheckAlwaysOpenRoblox(string startBold, string endBold, string startBold2, string endBold2)
	{
		return $"Check {startBold}Always open links for Roblox{endBold} and click {startBold2}Open Roblox{endBold2} in the dialog box above to join games faster in the future!";
	}

	protected virtual string _GetTemplateForResponseCheckAlwaysOpenRoblox()
	{
		return "Check {startBold}Always open links for Roblox{endBold} and click {startBold2}Open Roblox{endBold2} in the dialog box above to join games faster in the future!";
	}

	/// <summary>
	/// Key: "Response.CheckAlwaysOpenRobloxURL"
	/// Check {startBold}Always open links for URL: Roblox Protocol{endBold} and click {startBold}Open URL: Roblox Protocol{endBold} in the dialog box above to join games faster in the future!
	/// English String: "Check {startBold}Always open links for URL: Roblox Protocol{endBold} and click {startBold2}Open URL: Roblox Protocol{endBold2} in the dialog box above to join games faster in the future!"
	/// </summary>
	public virtual string ResponseCheckAlwaysOpenRobloxURL(string startBold, string endBold, string startBold2, string endBold2)
	{
		return $"Check {startBold}Always open links for URL: Roblox Protocol{endBold} and click {startBold2}Open URL: Roblox Protocol{endBold2} in the dialog box above to join games faster in the future!";
	}

	protected virtual string _GetTemplateForResponseCheckAlwaysOpenRobloxURL()
	{
		return "Check {startBold}Always open links for URL: Roblox Protocol{endBold} and click {startBold2}Open URL: Roblox Protocol{endBold2} in the dialog box above to join games faster in the future!";
	}

	/// <summary>
	/// Key: "Response.CheckRememberMyChoiceOK"
	/// Check Remember my choice and click OK in the dialog box above to join games faster in the future!
	/// English String: "Check {startBold}Remember my choice{endBold} and click {startBold2}OK{endBold2} in the dialog box above to join games faster in the future!"
	/// </summary>
	public virtual string ResponseCheckRememberMyChoiceOK(string startBold, string endBold, string startBold2, string endBold2)
	{
		return $"Check {startBold}Remember my choice{endBold} and click {startBold2}OK{endBold2} in the dialog box above to join games faster in the future!";
	}

	protected virtual string _GetTemplateForResponseCheckRememberMyChoiceOK()
	{
		return "Check {startBold}Remember my choice{endBold} and click {startBold2}OK{endBold2} in the dialog box above to join games faster in the future!";
	}

	protected virtual string _GetTemplateForResponseDialogClickHere()
	{
		return "Click here!";
	}

	protected virtual string _GetTemplateForResponseDialogErrorLaunching()
	{
		return "An error occurred trying to launch the game.  Please try again later.";
	}

	protected virtual string _GetTemplateForResponseDialogHavingTroubleInstallQuestion()
	{
		return "Having trouble installing Roblox?";
	}

	/// <summary>
	/// Key: "Response.Dialog.InstallingMessageWithLink"
	/// Note: For this translation, please move the linkStart and linkEnd variables with the translation for download now.
	/// English String: "The Roblox installer should download shortly. If it doesn’t, start the {linkStart}download now.{linkEnd}"
	/// </summary>
	public virtual string ResponseDialogInstallingMessageWithLink(string linkStart, string linkEnd)
	{
		return $"The Roblox installer should download shortly. If it doesn’t, start the {linkStart}download now.{linkEnd}";
	}

	protected virtual string _GetTemplateForResponseDialogInstallingMessageWithLink()
	{
		return "The Roblox installer should download shortly. If it doesn’t, start the {linkStart}download now.{linkEnd}";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacChromeFifthInstruction"
	/// After installation, click {startBold}Play{endBold} below to join the action!
	/// English String: "After installation, click {startBold}Play{endBold} below to join the action!"
	/// </summary>
	public virtual string ResponseDialogMacChromeFifthInstruction(string startBold, string endBold)
	{
		return $"After installation, click {startBold}Play{endBold} below to join the action!";
	}

	protected virtual string _GetTemplateForResponseDialogMacChromeFifthInstruction()
	{
		return "After installation, click {startBold}Play{endBold} below to join the action!";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacChromeFirstInstruction"
	/// Click {startBold}Roblox.dmg{endBold} to run the Roblox installer, which just downloaded via your web browser.
	/// English String: "Click {startBold}Roblox.dmg{endBold} to run the Roblox installer, which just downloaded via your web browser."
	/// </summary>
	public virtual string ResponseDialogMacChromeFirstInstruction(string startBold, string endBold)
	{
		return $"Click {startBold}Roblox.dmg{endBold} to run the Roblox installer, which just downloaded via your web browser.";
	}

	protected virtual string _GetTemplateForResponseDialogMacChromeFirstInstruction()
	{
		return "Click {startBold}Roblox.dmg{endBold} to run the Roblox installer, which just downloaded via your web browser.";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacChromeFourthInstruction"
	/// Click {startBold}Ok{endBold} once you've successfully installed Roblox.
	/// English String: "Click {startBold}Ok{endBold} once you've successfully installed Roblox."
	/// </summary>
	public virtual string ResponseDialogMacChromeFourthInstruction(string startBold, string endBold)
	{
		return $"Click {startBold}Ok{endBold} once you've successfully installed Roblox.";
	}

	protected virtual string _GetTemplateForResponseDialogMacChromeFourthInstruction()
	{
		return "Click {startBold}Ok{endBold} once you've successfully installed Roblox.";
	}

	protected virtual string _GetTemplateForResponseDialogMacChromeSecondInstruction()
	{
		return "Double-click the Roblox app icon to begin the installation process.";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacChromeThirdInstruction"
	/// Click {startBold}Open{endBold} when prompted by your computer.
	/// English String: "Click {startBold}Open{endBold} when prompted by your computer."
	/// </summary>
	public virtual string ResponseDialogMacChromeThirdInstruction(string startBold, string endBold)
	{
		return $"Click {startBold}Open{endBold} when prompted by your computer.";
	}

	protected virtual string _GetTemplateForResponseDialogMacChromeThirdInstruction()
	{
		return "Click {startBold}Open{endBold} when prompted by your computer.";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacFirefoxFifthInstruction"
	/// Then select the Remember my choice... checkbox and click OK
	/// English String: "Then select the {startBold}Remember my choice...{endBold} checkbox and click {startBold2}OK{endBold2}"
	/// </summary>
	public virtual string ResponseDialogMacFirefoxFifthInstruction(string startBold, string endBold, string startBold2, string endBold2)
	{
		return $"Then select the {startBold}Remember my choice...{endBold} checkbox and click {startBold2}OK{endBold2}";
	}

	protected virtual string _GetTemplateForResponseDialogMacFirefoxFifthInstruction()
	{
		return "Then select the {startBold}Remember my choice...{endBold} checkbox and click {startBold2}OK{endBold2}";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacFirefoxFirstInstruction"
	/// Select Open with and click OK
	/// English String: "Select {startBold}Open with{endBold} and click {startBold2}OK{endBold2}"
	/// </summary>
	public virtual string ResponseDialogMacFirefoxFirstInstruction(string startBold, string endBold, string startBold2, string endBold2)
	{
		return $"Select {startBold}Open with{endBold} and click {startBold2}OK{endBold2}";
	}

	protected virtual string _GetTemplateForResponseDialogMacFirefoxFirstInstruction()
	{
		return "Select {startBold}Open with{endBold} and click {startBold2}OK{endBold2}";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacFirefoxFourthInstruction"
	/// Once installed, click Play to join the action!
	/// English String: "Once installed, click {startBold}Play{endBold} to join the action!"
	/// </summary>
	public virtual string ResponseDialogMacFirefoxFourthInstruction(string startBold, string endBold)
	{
		return $"Once installed, click {startBold}Play{endBold} to join the action!";
	}

	protected virtual string _GetTemplateForResponseDialogMacFirefoxFourthInstruction()
	{
		return "Once installed, click {startBold}Play{endBold} to join the action!";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacFirefoxSecondInstruction"
	/// Double-click the Roblox Icon to begin the installation process
	/// English String: "Double-click the {startBold}Roblox Icon{endBold} to begin the installation process"
	/// </summary>
	public virtual string ResponseDialogMacFirefoxSecondInstruction(string startBold, string endBold)
	{
		return $"Double-click the {startBold}Roblox Icon{endBold} to begin the installation process";
	}

	protected virtual string _GetTemplateForResponseDialogMacFirefoxSecondInstruction()
	{
		return "Double-click the {startBold}Roblox Icon{endBold} to begin the installation process";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacFirefoxThirdInstruction"
	/// You will receive a warning, click Open
	/// English String: "You will receive a warning, click {startBold}Open{endBold}"
	/// </summary>
	public virtual string ResponseDialogMacFirefoxThirdInstruction(string startBold, string endBold)
	{
		return $"You will receive a warning, click {startBold}Open{endBold}";
	}

	protected virtual string _GetTemplateForResponseDialogMacFirefoxThirdInstruction()
	{
		return "You will receive a warning, click {startBold}Open{endBold}";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacSafariFirstInstruction"
	/// Go to Downloads and double-click Roblox.dmg
	/// English String: "Go to Downloads and double-click {startBold}Roblox.dmg{endBold}"
	/// </summary>
	public virtual string ResponseDialogMacSafariFirstInstruction(string startBold, string endBold)
	{
		return $"Go to Downloads and double-click {startBold}Roblox.dmg{endBold}";
	}

	protected virtual string _GetTemplateForResponseDialogMacSafariFirstInstruction()
	{
		return "Go to Downloads and double-click {startBold}Roblox.dmg{endBold}";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacSafariFourthInstruction"
	/// Once installed, click {startBold}Play{endBold} to join the action!
	/// English String: "Once installed, click {startBold}Play{endBold} to join the action!"
	/// </summary>
	public virtual string ResponseDialogMacSafariFourthInstruction(string startBold, string endBold)
	{
		return $"Once installed, click {startBold}Play{endBold} to join the action!";
	}

	protected virtual string _GetTemplateForResponseDialogMacSafariFourthInstruction()
	{
		return "Once installed, click {startBold}Play{endBold} to join the action!";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacSafariSecondInstruction"
	/// Double-click the {startBold}Roblox Icon{endBold} to begin the installation process
	/// English String: "Double-click the {startBold}Roblox Icon{endBold} to begin the installation process"
	/// </summary>
	public virtual string ResponseDialogMacSafariSecondInstruction(string startBold, string endBold)
	{
		return $"Double-click the {startBold}Roblox Icon{endBold} to begin the installation process";
	}

	protected virtual string _GetTemplateForResponseDialogMacSafariSecondInstruction()
	{
		return "Double-click the {startBold}Roblox Icon{endBold} to begin the installation process";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacSafariThirdInstruction"
	/// You will receive a warning, click {startBold}Open{endBold}
	/// English String: "You will receive a warning, click {startBold}Open{endBold}"
	/// </summary>
	public virtual string ResponseDialogMacSafariThirdInstruction(string startBold, string endBold)
	{
		return $"You will receive a warning, click {startBold}Open{endBold}";
	}

	protected virtual string _GetTemplateForResponseDialogMacSafariThirdInstruction()
	{
		return "You will receive a warning, click {startBold}Open{endBold}";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcChromeFirstInstruction"
	/// Click {startBold}RobloxPlayer.exe{endBold} to run the Roblox installer, which just downloaded via your web browser.
	/// English String: "Click {startBold}RobloxPlayer.exe{endBold} to run the Roblox installer, which just downloaded via your web browser."
	/// </summary>
	public virtual string ResponseDialogPcChromeFirstInstruction(string startBold, string endBold)
	{
		return $"Click {startBold}RobloxPlayer.exe{endBold} to run the Roblox installer, which just downloaded via your web browser.";
	}

	protected virtual string _GetTemplateForResponseDialogPcChromeFirstInstruction()
	{
		return "Click {startBold}RobloxPlayer.exe{endBold} to run the Roblox installer, which just downloaded via your web browser.";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcChromeFourthInstruction"
	/// After installation, click {startBold}Play{endBold} below to join the action!
	/// English String: "After installation, click {startBold}Play{endBold} below to join the action!"
	/// </summary>
	public virtual string ResponseDialogPcChromeFourthInstruction(string startBold, string endBold)
	{
		return $"After installation, click {startBold}Play{endBold} below to join the action!";
	}

	protected virtual string _GetTemplateForResponseDialogPcChromeFourthInstruction()
	{
		return "After installation, click {startBold}Play{endBold} below to join the action!";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcChromeSecondInstruction"
	/// Click {startBold}Run{endBold} when prompted by your computer to begin the installation process.
	/// English String: "Click {startBold}Run{endBold} when prompted by your computer to begin the installation process."
	/// </summary>
	public virtual string ResponseDialogPcChromeSecondInstruction(string startBold, string endBold)
	{
		return $"Click {startBold}Run{endBold} when prompted by your computer to begin the installation process.";
	}

	protected virtual string _GetTemplateForResponseDialogPcChromeSecondInstruction()
	{
		return "Click {startBold}Run{endBold} when prompted by your computer to begin the installation process.";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcChromeThirdInstruction"
	/// Click {startBold}Ok{endBold} once you've successfully installed Roblox.
	/// English String: "Click {startBold}Ok{endBold} once you've successfully installed Roblox."
	/// </summary>
	public virtual string ResponseDialogPcChromeThirdInstruction(string startBold, string endBold)
	{
		return $"Click {startBold}Ok{endBold} once you've successfully installed Roblox.";
	}

	protected virtual string _GetTemplateForResponseDialogPcChromeThirdInstruction()
	{
		return "Click {startBold}Ok{endBold} once you've successfully installed Roblox.";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcEdgeFirstInstruction"
	/// Click {startBold}Run{endBold} to install Roblox after the download finishes
	/// English String: "Click {startBold}Run{endBold} to install Roblox after the download finishes"
	/// </summary>
	public virtual string ResponseDialogPcEdgeFirstInstruction(string startBold, string endBold)
	{
		return $"Click {startBold}Run{endBold} to install Roblox after the download finishes";
	}

	protected virtual string _GetTemplateForResponseDialogPcEdgeFirstInstruction()
	{
		return "Click {startBold}Run{endBold} to install Roblox after the download finishes";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcEdgeSecondInstruction"
	/// Click {startBold}Ok{endBold} to finish installing Roblox
	/// English String: "Click {startBold}Ok{endBold} to finish installing Roblox"
	/// </summary>
	public virtual string ResponseDialogPcEdgeSecondInstruction(string startBold, string endBold)
	{
		return $"Click {startBold}Ok{endBold} to finish installing Roblox";
	}

	protected virtual string _GetTemplateForResponseDialogPcEdgeSecondInstruction()
	{
		return "Click {startBold}Ok{endBold} to finish installing Roblox";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcEdgeThirdInstruction"
	/// Click the {startBold}Play{endBold} button to join the action!
	/// English String: "Click the {startBold}Play{endBold} button to join the action!"
	/// </summary>
	public virtual string ResponseDialogPcEdgeThirdInstruction(string startBold, string endBold)
	{
		return $"Click the {startBold}Play{endBold} button to join the action!";
	}

	protected virtual string _GetTemplateForResponseDialogPcEdgeThirdInstruction()
	{
		return "Click the {startBold}Play{endBold} button to join the action!";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcFirefoxFifthInstruction"
	/// Click {startBold}Ok{endBold} when the alert pops up
	/// English String: "Click {startBold}Ok{endBold} when the alert pops up"
	/// </summary>
	public virtual string ResponseDialogPcFirefoxFifthInstruction(string startBold, string endBold)
	{
		return $"Click {startBold}Ok{endBold} when the alert pops up";
	}

	protected virtual string _GetTemplateForResponseDialogPcFirefoxFifthInstruction()
	{
		return "Click {startBold}Ok{endBold} when the alert pops up";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcFirefoxFirstInstruction"
	/// Click {startBold}Save File{endBold} when the download window pops up
	/// English String: "Click {startBold}Save File{endBold} when the download window pops up"
	/// </summary>
	public virtual string ResponseDialogPcFirefoxFirstInstruction(string startBold, string endBold)
	{
		return $"Click {startBold}Save File{endBold} when the download window pops up";
	}

	protected virtual string _GetTemplateForResponseDialogPcFirefoxFirstInstruction()
	{
		return "Click {startBold}Save File{endBold} when the download window pops up";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcFirefoxFourthInstruction"
	/// Once installed, click {startBold}Play{endBold} to join the action!
	/// English String: "Once installed, click {startBold}Play{endBold} to join the action!"
	/// </summary>
	public virtual string ResponseDialogPcFirefoxFourthInstruction(string startBold, string endBold)
	{
		return $"Once installed, click {startBold}Play{endBold} to join the action!";
	}

	protected virtual string _GetTemplateForResponseDialogPcFirefoxFourthInstruction()
	{
		return "Once installed, click {startBold}Play{endBold} to join the action!";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcFirefoxSecondInstruction"
	/// Go to Downloads and double click {startBold}RobloxPlayer.exe{endBold}
	/// English String: "Go to Downloads and double click {startBold}RobloxPlayer.exe{endBold}"
	/// </summary>
	public virtual string ResponseDialogPcFirefoxSecondInstruction(string startBold, string endBold)
	{
		return $"Go to Downloads and double click {startBold}RobloxPlayer.exe{endBold}";
	}

	protected virtual string _GetTemplateForResponseDialogPcFirefoxSecondInstruction()
	{
		return "Go to Downloads and double click {startBold}RobloxPlayer.exe{endBold}";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcFirefoxThirdInstruction"
	/// Click {startBold}Run{endBold}
	/// English String: "Click {startBold}Run{endBold}"
	/// </summary>
	public virtual string ResponseDialogPcFirefoxThirdInstruction(string startBold, string endBold)
	{
		return $"Click {startBold}Run{endBold}";
	}

	protected virtual string _GetTemplateForResponseDialogPcFirefoxThirdInstruction()
	{
		return "Click {startBold}Run{endBold}";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcIEFirstInstruction"
	/// You will receive a warning, click {startBold}Run{endBold}
	/// English String: "You will receive a warning, click {startBold}Run{endBold}"
	/// </summary>
	public virtual string ResponseDialogPcIEFirstInstruction(string startBold, string endBold)
	{
		return $"You will receive a warning, click {startBold}Run{endBold}";
	}

	protected virtual string _GetTemplateForResponseDialogPcIEFirstInstruction()
	{
		return "You will receive a warning, click {startBold}Run{endBold}";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcIeInstructionOne"
	/// You will receive a warning, click {startBold}Run{endBold}
	/// English String: "You will receive a warning, click {startBold}Run{endBold}"
	/// </summary>
	public virtual string ResponseDialogPcIeInstructionOne(string startBold, string endBold)
	{
		return $"You will receive a warning, click {startBold}Run{endBold}";
	}

	protected virtual string _GetTemplateForResponseDialogPcIeInstructionOne()
	{
		return "You will receive a warning, click {startBold}Run{endBold}";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcIeInstructionThree"
	/// Click {startBold}Run{endBold}
	/// English String: "Click {startBold}Run{endBold}"
	/// </summary>
	public virtual string ResponseDialogPcIeInstructionThree(string startBold, string endBold)
	{
		return $"Click {startBold}Run{endBold}";
	}

	protected virtual string _GetTemplateForResponseDialogPcIeInstructionThree()
	{
		return "Click {startBold}Run{endBold}";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcIeInstructionTwo"
	/// Go to Downloads and double click {startBold}RobloxPlayer.exe{endBold}
	/// English String: "Go to Downloads and double click {startBold}RobloxPlayer.exe{endBold}"
	/// </summary>
	public virtual string ResponseDialogPcIeInstructionTwo(string startBold, string endBold)
	{
		return $"Go to Downloads and double click {startBold}RobloxPlayer.exe{endBold}";
	}

	protected virtual string _GetTemplateForResponseDialogPcIeInstructionTwo()
	{
		return "Go to Downloads and double click {startBold}RobloxPlayer.exe{endBold}";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcIESecondInstruction"
	/// Click {startBold}Ok{endBold} once you've installed Roblox
	/// English String: "Click {startBold}Ok{endBold} once you've installed Roblox"
	/// </summary>
	public virtual string ResponseDialogPcIESecondInstruction(string startBold, string endBold)
	{
		return $"Click {startBold}Ok{endBold} once you've installed Roblox";
	}

	protected virtual string _GetTemplateForResponseDialogPcIESecondInstruction()
	{
		return "Click {startBold}Ok{endBold} once you've installed Roblox";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcIEThirdInstruction"
	/// Once installed, click {startBold}Play{endBold} to join the action!
	/// English String: "Once installed, click {startBold}Play{endBold} to join the action!"
	/// </summary>
	public virtual string ResponseDialogPcIEThirdInstruction(string startBold, string endBold)
	{
		return $"Once installed, click {startBold}Play{endBold} to join the action!";
	}

	protected virtual string _GetTemplateForResponseDialogPcIEThirdInstruction()
	{
		return "Once installed, click {startBold}Play{endBold} to join the action!";
	}

	protected virtual string _GetTemplateForResponseDialogThanksForPlayingRoblox()
	{
		return "Thanks for playing Roblox";
	}

	protected virtual string _GetTemplateForResponseGameTemporarilyUnavailable()
	{
		return "Unable to verify that you have access to this game.  Please try again later.";
	}

	/// <summary>
	/// Key: "Response.RememberMyChoiceAppLaunch"
	/// Check {startBold}Remember my choice{endBold} and click {appLaunchLink} in the dialog box above to join games faster in the future!
	/// English String: "Check {startBold}Remember my choice{endBold} and click {appLaunchLink} in the dialog box above to join games faster in the future!"
	/// </summary>
	public virtual string ResponseRememberMyChoiceAppLaunch(string startBold, string endBold, string appLaunchLink)
	{
		return $"Check {startBold}Remember my choice{endBold} and click {appLaunchLink} in the dialog box above to join games faster in the future!";
	}

	protected virtual string _GetTemplateForResponseRememberMyChoiceAppLaunch()
	{
		return "Check {startBold}Remember my choice{endBold} and click {appLaunchLink} in the dialog box above to join games faster in the future!";
	}
}
