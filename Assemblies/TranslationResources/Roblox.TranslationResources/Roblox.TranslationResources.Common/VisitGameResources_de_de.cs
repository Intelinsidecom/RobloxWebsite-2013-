namespace Roblox.TranslationResources.Common;

/// <summary>
/// This class overrides VisitGameResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class VisitGameResources_de_de : VisitGameResources_en_us, IVisitGameResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Retry"
	/// button label
	/// English String: "Retry"
	/// </summary>
	public override string ActionRetry => "Erneut versuchen";

	/// <summary>
	/// Key: "Heading.ErrorStartingGame"
	/// Error starting game
	/// English String: "Error starting game"
	/// </summary>
	public override string HeadingErrorStartingGame => "Fehler beim Starten des Spiels";

	/// <summary>
	/// Key: "Heading.SwitchToDesktopToPlay"
	/// Switch to Desktop Mode to Play Games
	/// English String: "Switch to Desktop Mode to Play Games"
	/// </summary>
	public override string HeadingSwitchToDesktopToPlay => "Wechsle zum Desktop-Modus, um Spiele zu spielen";

	/// <summary>
	/// Key: "Label.Cancel"
	/// Cancel
	/// English String: "Cancel"
	/// </summary>
	public override string LabelCancel => "Abbrechen";

	/// <summary>
	/// Key: "Label.CheckingForStudio"
	/// We are checking if user has Roblox Studio installed
	/// English String: "Checking for Roblox Studio..."
	/// </summary>
	public override string LabelCheckingForStudio => "Suche nach Roblox Studio\u00a0...";

	/// <summary>
	/// Key: "Label.ClickHereForHelp"
	/// Click here for help
	/// English String: "Click here for help"
	/// </summary>
	public override string LabelClickHereForHelp => "Klicke hier, um Hilfe zu erhalten.";

	/// <summary>
	/// Key: "Label.ConnectingToPlayers"
	/// Joining a game network with other players
	/// English String: "Connecting to Players..."
	/// </summary>
	public override string LabelConnectingToPlayers => "Verbindungsaufbau zu Spielern\u00a0...";

	/// <summary>
	/// Key: "Label.DevelopPageTitle"
	/// English String: "Develop"
	/// </summary>
	public override string LabelDevelopPageTitle => "Entwickeln";

	/// <summary>
	/// Key: "Label.DownloadInstallRoblox"
	/// Download and Install Roblox
	/// English String: "Download and Install Roblox"
	/// </summary>
	public override string LabelDownloadInstallRoblox => "Roblox herunterladen und installieren";

	/// <summary>
	/// Key: "Label.DownloadStudio"
	/// Download Roblox Studio to start creating games
	/// English String: "Download Studio"
	/// </summary>
	public override string LabelDownloadStudio => "Studio herunterladen";

	/// <summary>
	/// Key: "Label.GameConfigurePageTitle"
	/// English String: "Game Configure"
	/// </summary>
	public override string LabelGameConfigurePageTitle => "Spiel konfigurieren";

	/// <summary>
	/// Key: "Label.GameFreeSoothsayer"
	/// English String: "Free because you are a soothsayer"
	/// </summary>
	public override string LabelGameFreeSoothsayer => "Gratis, weil du ein Wahrsager bist";

	/// <summary>
	/// Key: "Label.GameUnavailableAccountResrictions"
	/// English String: "The game is unavailable due to account restrictions settings."
	/// </summary>
	public override string LabelGameUnavailableAccountResrictions => "Dieses Spiel ist aufgrund von Kontoeinschränkungseinstellungen nicht verfügbar.";

	/// <summary>
	/// Key: "Label.GameUnavailableCannotPlayGamesStudio"
	/// English String: "You cannot play games from Studio. Please use a web browser to play this game."
	/// </summary>
	public override string LabelGameUnavailableCannotPlayGamesStudio => "Du kannst Spiele nicht von Studio aus spielen. Bitte verwende einen Web-Browser, um dieses Spiel zu spielen.";

	/// <summary>
	/// Key: "Label.GameUnavailableClosedToVisitors"
	/// English String: "Sorry, this place is currently closed to visitors."
	/// </summary>
	public override string LabelGameUnavailableClosedToVisitors => "Dieser Ort ist für Besucher derzeit leider nicht zugänglich.";

	/// <summary>
	/// Key: "Label.GameUnavailableCurrentlyIsPrivateVisitor"
	/// When a game is private, this message is shown to visitors.
	/// English String: "Sorry, this game is private."
	/// </summary>
	public override string LabelGameUnavailableCurrentlyIsPrivateVisitor => "Dieses Spiel ist leider privat.";

	/// <summary>
	/// Key: "Label.GameUnavailableGameInsecure"
	/// U13 users cannot play insecure games unless they are the creator or friends with the creator.
	/// English String: "Sorry, your account is restricted from playing Experimental Games unless you are friends with the creator."
	/// </summary>
	public override string LabelGameUnavailableGameInsecure => "Tut uns leid, dein Konto hat keinen Zugriff auf Spiele im Experimentalmodus, es sei denn, du bist mit dem Ersteller befreundet.";

	/// <summary>
	/// Key: "Label.GameUnavailablePermissionLevels"
	/// English String: "The permission levels on this place prevent you from entering."
	/// </summary>
	public override string LabelGameUnavailablePermissionLevels => "Aufgrund der Berechtigungsstufen dieses Orts kannst du ihn nicht betreten.";

	/// <summary>
	/// Key: "Label.GameUnavailablePlaceUnderReview"
	/// English String: "Sorry, this place is currently under review. Try again later."
	/// </summary>
	public override string LabelGameUnavailablePlaceUnderReview => "Dieser Ort wird derzeit leider evaluiert. Versuche es später erneut.";

	/// <summary>
	/// Key: "Label.GameUnavailablePlatform"
	/// English String: "This game is not available on your platform.  Check the games page to see all playable games."
	/// </summary>
	public override string LabelGameUnavailablePlatform => "Dieses Spiel ist auf deiner Plattform nicht verfügbar. Sieh dir die Spieleseite an, um alle spielbaren Spiele zu finden.";

	/// <summary>
	/// Key: "Label.GameWarning"
	/// English String: "Warning"
	/// </summary>
	public override string LabelGameWarning => "Warnung";

	/// <summary>
	/// Key: "Label.InstallationInstructions"
	/// Installation Instructions
	/// English String: "Installation Instructions"
	/// </summary>
	public override string LabelInstallationInstructions => "Installationsanweisungen";

	/// <summary>
	/// Key: "Label.LaunchApplication"
	/// Launch Application
	/// English String: "Launch Application"
	/// </summary>
	public override string LabelLaunchApplication => "Anwendung starten";

	/// <summary>
	/// Key: "Label.PersuadeToDevelopRoblox"
	/// Persuade user to begin developing their own games using Roblox Studio
	/// English String: "Get started creating your own games!"
	/// </summary>
	public override string LabelPersuadeToDevelopRoblox => "Erstelle noch heute deine eigenen Spiele!";

	/// <summary>
	/// Key: "Label.PersuadeToInstallRoblox"
	/// We are exciting the user about Roblox so that they will be persuaded to download and install it.
	/// English String: "You're moments away from getting into the game!"
	/// </summary>
	public override string LabelPersuadeToInstallRoblox => "Du bist fast im Spiel!";

	/// <summary>
	/// Key: "Label.Play"
	/// English String: "Play"
	/// </summary>
	public override string LabelPlay => "Spielen";

	/// <summary>
	/// Key: "Label.PlayInApp"
	/// English String: "Play in App"
	/// </summary>
	public override string LabelPlayInApp => "In der App spielen";

	/// <summary>
	/// Key: "Label.RobloxLoadingToPlay"
	/// Roblox is loading, so the user is getting excited to start playing a game
	/// English String: "Roblox is now loading. Get ready to play!"
	/// </summary>
	public override string LabelRobloxLoadingToPlay => "Roblox lädt gerade. Mach dich spielbereit!";

	/// <summary>
	/// Key: "Label.StartingRoblox"
	/// Game launch process has started
	/// English String: "Starting Roblox..."
	/// </summary>
	public override string LabelStartingRoblox => "Roblox wird gestartet\u00a0...";

	/// <summary>
	/// Key: "Label.SwitchToDesktopMode"
	/// Switch to Desktop Mode
	/// English String: "Switch to Desktop Mode"
	/// </summary>
	public override string LabelSwitchToDesktopMode => "Wechsle zum Desktop-Modus";

	/// <summary>
	/// Key: "Label.UniverseConfigurePageTitle"
	/// The name of the universe configuration page
	/// English String: "Universe Configuration"
	/// </summary>
	public override string LabelUniverseConfigurePageTitle => "Universum konfigurieren";

	/// <summary>
	/// Key: "Response.Dialog.ClickHere"
	/// Click here!
	/// English String: "Click here!"
	/// </summary>
	public override string ResponseDialogClickHere => "Klicke hier!";

	/// <summary>
	/// Key: "Response.Dialog.ErrorLaunching"
	/// An error occurred trying to launch the game.  Please try again later.
	/// English String: "An error occurred trying to launch the game.  Please try again later."
	/// </summary>
	public override string ResponseDialogErrorLaunching => "Beim Starten des Spiels ist ein Fehler aufgetreten. Bitte versuche es später erneut.";

	/// <summary>
	/// Key: "Response.Dialog.HavingTroubleInstallQuestion"
	/// (Are you) having trouble installing Roblox?
	/// English String: "Having trouble installing Roblox?"
	/// </summary>
	public override string ResponseDialogHavingTroubleInstallQuestion => "Hast du Probleme bei der Installation von Roblox?";

	/// <summary>
	/// Key: "Response.Dialog.MacChromeSecondInstruction"
	/// Double-click the Roblox app icon to begin the installation process.
	/// English String: "Double-click the Roblox app icon to begin the installation process."
	/// </summary>
	public override string ResponseDialogMacChromeSecondInstruction => "Doppelklicke auf das Roblox-Appsymbol, um die Installation zu starten.";

	/// <summary>
	/// Key: "Response.Dialog.ThanksForPlayingRoblox"
	/// Thanks for playing Roblox
	/// English String: "Thanks for playing Roblox"
	/// </summary>
	public override string ResponseDialogThanksForPlayingRoblox => "Danke, dass du Roblox spielst.";

	/// <summary>
	/// Key: "Response.GameTemporarilyUnavailable"
	/// error message (will be followed by link with Action.Retry label)
	/// English String: "Unable to verify that you have access to this game.  Please try again later."
	/// </summary>
	public override string ResponseGameTemporarilyUnavailable => "Dein Zugriffsrecht auf dieses Spiel konnte nicht bestätigt werden. Bitte versuche es später erneut.";

	public VisitGameResources_de_de(TranslationResourceState state)
		: base(state)
	{
	}

	/// <summary>
	/// Key: "Action.GamePerformPoorly"
	/// English String: "{warning} This game may perform poorly on your device."
	/// </summary>
	public override string ActionGamePerformPoorly(string warning)
	{
		return $"{warning} Dieses Spiel läuft auf deinem Gerät eventuell nicht optimal.";
	}

	protected override string _GetTemplateForActionGamePerformPoorly()
	{
		return "{warning} Dieses Spiel läuft auf deinem Gerät eventuell nicht optimal.";
	}

	protected override string _GetTemplateForActionRetry()
	{
		return "Erneut versuchen";
	}

	protected override string _GetTemplateForHeadingErrorStartingGame()
	{
		return "Fehler beim Starten des Spiels";
	}

	protected override string _GetTemplateForHeadingSwitchToDesktopToPlay()
	{
		return "Wechsle zum Desktop-Modus, um Spiele zu spielen";
	}

	/// <summary>
	/// Key: "Label.BuyAccess"
	/// English String: "Buy Access for {robux} Robux"
	/// </summary>
	public override string LabelBuyAccess(string robux)
	{
		return $"Zugang für {robux} Robux";
	}

	protected override string _GetTemplateForLabelBuyAccess()
	{
		return "Zugang für {robux} Robux";
	}

	protected override string _GetTemplateForLabelCancel()
	{
		return "Abbrechen";
	}

	protected override string _GetTemplateForLabelCheckingForStudio()
	{
		return "Suche nach Roblox Studio\u00a0...";
	}

	protected override string _GetTemplateForLabelClickHereForHelp()
	{
		return "Klicke hier, um Hilfe zu erhalten.";
	}

	protected override string _GetTemplateForLabelConnectingToPlayers()
	{
		return "Verbindungsaufbau zu Spielern\u00a0...";
	}

	protected override string _GetTemplateForLabelDevelopPageTitle()
	{
		return "Entwickeln";
	}

	protected override string _GetTemplateForLabelDownloadInstallRoblox()
	{
		return "Roblox herunterladen und installieren";
	}

	protected override string _GetTemplateForLabelDownloadStudio()
	{
		return "Studio herunterladen";
	}

	protected override string _GetTemplateForLabelGameConfigurePageTitle()
	{
		return "Spiel konfigurieren";
	}

	protected override string _GetTemplateForLabelGameFreeSoothsayer()
	{
		return "Gratis, weil du ein Wahrsager bist";
	}

	/// <summary>
	/// Key: "Label.GameIsPrivatePlayableByGroupOnly"
	/// When a game is private, this message is shown to group developers with a link from where it can be made public.
	/// English String: "Only developers can play because this game is private. Make it public on the {linkStart}Configure Game{linkEnd} page."
	/// </summary>
	public override string LabelGameIsPrivatePlayableByGroupOnly(string linkStart, string linkEnd)
	{
		return $"Da dieses Spiel privat ist, kann es nur von Entwicklern gespielt werden. Mache es auf der Seite „{linkStart}Spiel konfigurieren{linkEnd}“ öffentlich.";
	}

	protected override string _GetTemplateForLabelGameIsPrivatePlayableByGroupOnly()
	{
		return "Da dieses Spiel privat ist, kann es nur von Entwicklern gespielt werden. Mache es auf der Seite „{linkStart}Spiel konfigurieren{linkEnd}“ öffentlich.";
	}

	/// <summary>
	/// Key: "Label.GameIsPrivatePlayableByOwnerOnly"
	/// When a game is private, this message is shown to owner with a link from where it can be made public.
	/// English String: "Only you can play because this game is private. Make it public on the {linkStart}Configure Game{linkEnd} page."
	/// </summary>
	public override string LabelGameIsPrivatePlayableByOwnerOnly(string linkStart, string linkEnd)
	{
		return $"Da dieses Spiel privat ist, kannst nur du es spielen. Mache es auf der Seite „{linkStart}Spiel konfigurieren{linkEnd}“ öffentlich.";
	}

	protected override string _GetTemplateForLabelGameIsPrivatePlayableByOwnerOnly()
	{
		return "Da dieses Spiel privat ist, kannst nur du es spielen. Mache es auf der Seite „{linkStart}Spiel konfigurieren{linkEnd}“ öffentlich.";
	}

	protected override string _GetTemplateForLabelGameUnavailableAccountResrictions()
	{
		return "Dieses Spiel ist aufgrund von Kontoeinschränkungseinstellungen nicht verfügbar.";
	}

	protected override string _GetTemplateForLabelGameUnavailableCannotPlayGamesStudio()
	{
		return "Du kannst Spiele nicht von Studio aus spielen. Bitte verwende einen Web-Browser, um dieses Spiel zu spielen.";
	}

	protected override string _GetTemplateForLabelGameUnavailableClosedToVisitors()
	{
		return "Dieser Ort ist für Besucher derzeit leider nicht zugänglich.";
	}

	/// <summary>
	/// Key: "Label.GameUnavailableCurrentlyIsPrivateGroup"
	/// When a game is private, this message is shown to group developers with a link from where it can be made public. Similar to an existing translation. Change is making the message directly address the group developers.
	/// English String: "Only developers can play because this game is private. Make it public on the {linkStart}Develop{linkEnd} page."
	/// </summary>
	public override string LabelGameUnavailableCurrentlyIsPrivateGroup(string linkStart, string linkEnd)
	{
		return $"Da dieses Spiel privat ist, kann es nur von Entwicklern gespielt werden. Mache es auf der Seite „{linkStart}Entwickeln{linkEnd}“ öffentlich.";
	}

	protected override string _GetTemplateForLabelGameUnavailableCurrentlyIsPrivateGroup()
	{
		return "Da dieses Spiel privat ist, kann es nur von Entwicklern gespielt werden. Mache es auf der Seite „{linkStart}Entwickeln{linkEnd}“ öffentlich.";
	}

	/// <summary>
	/// Key: "Label.GameUnavailableCurrentlyIsPrivateOwner"
	/// When a game is private, this message is shown to owner with a link from where it can be made public. Similar to an existing translation. Change is making the message directly address the owner.
	/// English String: "Only you can play because this game is private. Make it public on the {linkStart}Develop{linkEnd} page."
	/// </summary>
	public override string LabelGameUnavailableCurrentlyIsPrivateOwner(string linkStart, string linkEnd)
	{
		return $"Da dieses Spiel privat ist, kannst nur du es spielen. Mache es auf der Seite „{linkStart}Entwickeln{linkEnd}“ öffentlich.";
	}

	protected override string _GetTemplateForLabelGameUnavailableCurrentlyIsPrivateOwner()
	{
		return "Da dieses Spiel privat ist, kannst nur du es spielen. Mache es auf der Seite „{linkStart}Entwickeln{linkEnd}“ öffentlich.";
	}

	protected override string _GetTemplateForLabelGameUnavailableCurrentlyIsPrivateVisitor()
	{
		return "Dieses Spiel ist leider privat.";
	}

	/// <summary>
	/// Key: "Label.GameUnavailableCurrentlyPrivate"
	/// When a game is private, this message is shown to user with link from where it can be made public
	/// English String: "This {gameTypeName} is currently private. Make it public on the {developPageLink} page to make it playable."
	/// </summary>
	public override string LabelGameUnavailableCurrentlyPrivate(string gameTypeName, string developPageLink)
	{
		return $"Dieses „{gameTypeName}“-Spiel ist derzeit privat. Mache es auf der Seite „{developPageLink}“ öffentlich, damit es gespielt werden kann.";
	}

	protected override string _GetTemplateForLabelGameUnavailableCurrentlyPrivate()
	{
		return "Dieses „{gameTypeName}“-Spiel ist derzeit privat. Mache es auf der Seite „{developPageLink}“ öffentlich, damit es gespielt werden kann.";
	}

	protected override string _GetTemplateForLabelGameUnavailableGameInsecure()
	{
		return "Tut uns leid, dein Konto hat keinen Zugriff auf Spiele im Experimentalmodus, es sei denn, du bist mit dem Ersteller befreundet.";
	}

	/// <summary>
	/// Key: "Label.GameUnavailableNoRootPlace"
	/// English String: "This place is part of a game that has no root place. Add a root place on the {gameConfigureLink} page to make it playable."
	/// </summary>
	public override string LabelGameUnavailableNoRootPlace(string gameConfigureLink)
	{
		return $"Dieser Ort ist Teil eines Spiels ohne Quellort. Füge auf der Seite „{gameConfigureLink}“ einen Quellort hinzu, damit es gespielt werden kann.";
	}

	protected override string _GetTemplateForLabelGameUnavailableNoRootPlace()
	{
		return "Dieser Ort ist Teil eines Spiels ohne Quellort. Füge auf der Seite „{gameConfigureLink}“ einen Quellort hinzu, damit es gespielt werden kann.";
	}

	protected override string _GetTemplateForLabelGameUnavailablePermissionLevels()
	{
		return "Aufgrund der Berechtigungsstufen dieses Orts kannst du ihn nicht betreten.";
	}

	/// <summary>
	/// Key: "Label.GameUnavailablePlaceNotPartOfGame"
	/// English String: "This place is not currently part of a Game. Add it to a game on the {developPageLink} page to make it playable."
	/// </summary>
	public override string LabelGameUnavailablePlaceNotPartOfGame(string developPageLink)
	{
		return $"Dieser Ort ist derzeit nicht Teil eines Spiels. Füge ihn auf der Seite „{developPageLink}“ zu einem Spiel hinzu, damit er gespielt werden kann.";
	}

	protected override string _GetTemplateForLabelGameUnavailablePlaceNotPartOfGame()
	{
		return "Dieser Ort ist derzeit nicht Teil eines Spiels. Füge ihn auf der Seite „{developPageLink}“ zu einem Spiel hinzu, damit er gespielt werden kann.";
	}

	protected override string _GetTemplateForLabelGameUnavailablePlaceUnderReview()
	{
		return "Dieser Ort wird derzeit leider evaluiert. Versuche es später erneut.";
	}

	protected override string _GetTemplateForLabelGameUnavailablePlatform()
	{
		return "Dieses Spiel ist auf deiner Plattform nicht verfügbar. Sieh dir die Spieleseite an, um alle spielbaren Spiele zu finden.";
	}

	protected override string _GetTemplateForLabelGameWarning()
	{
		return "Warnung";
	}

	protected override string _GetTemplateForLabelInstallationInstructions()
	{
		return "Installationsanweisungen";
	}

	protected override string _GetTemplateForLabelLaunchApplication()
	{
		return "Anwendung starten";
	}

	/// <summary>
	/// Key: "Label.OperaInstallSteps"
	/// 1) A window will open. Click Open2) Doubleclick the Roblox icon.
	/// English String: "1) A window will open. Click {startBold}Open{endBold}.{breakLine}2) Doubleclick the Roblox icon."
	/// </summary>
	public override string LabelOperaInstallSteps(string startBold, string endBold, string breakLine)
	{
		return $"1) Ein Fenster wird sich öffnen. Klicke auf {startBold}Öffnen{endBold}.{breakLine}2) Doppelklicke auf das Roblox-Symbol.";
	}

	protected override string _GetTemplateForLabelOperaInstallSteps()
	{
		return "1) Ein Fenster wird sich öffnen. Klicke auf {startBold}Öffnen{endBold}.{breakLine}2) Doppelklicke auf das Roblox-Symbol.";
	}

	protected override string _GetTemplateForLabelPersuadeToDevelopRoblox()
	{
		return "Erstelle noch heute deine eigenen Spiele!";
	}

	protected override string _GetTemplateForLabelPersuadeToInstallRoblox()
	{
		return "Du bist fast im Spiel!";
	}

	protected override string _GetTemplateForLabelPlay()
	{
		return "Spielen";
	}

	protected override string _GetTemplateForLabelPlayInApp()
	{
		return "In der App spielen";
	}

	protected override string _GetTemplateForLabelRobloxLoadingToPlay()
	{
		return "Roblox lädt gerade. Mach dich spielbereit!";
	}

	protected override string _GetTemplateForLabelStartingRoblox()
	{
		return "Roblox wird gestartet\u00a0...";
	}

	protected override string _GetTemplateForLabelSwitchToDesktopMode()
	{
		return "Wechsle zum Desktop-Modus";
	}

	protected override string _GetTemplateForLabelUniverseConfigurePageTitle()
	{
		return "Universum konfigurieren";
	}

	/// <summary>
	/// Key: "Response.CheckAlwaysOpenRoblox"
	/// Check {startBold}Always open links for Roblox{endBold} and click {startBold2}Open Roblox{endBold2} in the dialog box above to join games faster in the future!
	/// English String: "Check {startBold}Always open links for Roblox{endBold} and click {startBold2}Open Roblox{endBold2} in the dialog box above to join games faster in the future!"
	/// </summary>
	public override string ResponseCheckAlwaysOpenRoblox(string startBold, string endBold, string startBold2, string endBold2)
	{
		return $"Wähle {startBold}Links für Roblox immer öffnen{endBold} und klicke im Dialogfenster oben auf {startBold2}Roblox öffnen{endBold2}, um Spielen in Zukunft schneller beitreten zu können!";
	}

	protected override string _GetTemplateForResponseCheckAlwaysOpenRoblox()
	{
		return "Wähle {startBold}Links für Roblox immer öffnen{endBold} und klicke im Dialogfenster oben auf {startBold2}Roblox öffnen{endBold2}, um Spielen in Zukunft schneller beitreten zu können!";
	}

	/// <summary>
	/// Key: "Response.CheckAlwaysOpenRobloxURL"
	/// Check {startBold}Always open links for URL: Roblox Protocol{endBold} and click {startBold}Open URL: Roblox Protocol{endBold} in the dialog box above to join games faster in the future!
	/// English String: "Check {startBold}Always open links for URL: Roblox Protocol{endBold} and click {startBold2}Open URL: Roblox Protocol{endBold2} in the dialog box above to join games faster in the future!"
	/// </summary>
	public override string ResponseCheckAlwaysOpenRobloxURL(string startBold, string endBold, string startBold2, string endBold2)
	{
		return $"Wähle {startBold}Links für URL immer öffnen: Roblox-Protokoll{endBold} und klicke im Dialogfenster oben auf {startBold2}URL öffnen: Roblox-Protokoll{endBold2}, um Spielen in Zukunft schneller beitreten zu können!";
	}

	protected override string _GetTemplateForResponseCheckAlwaysOpenRobloxURL()
	{
		return "Wähle {startBold}Links für URL immer öffnen: Roblox-Protokoll{endBold} und klicke im Dialogfenster oben auf {startBold2}URL öffnen: Roblox-Protokoll{endBold2}, um Spielen in Zukunft schneller beitreten zu können!";
	}

	/// <summary>
	/// Key: "Response.CheckRememberMyChoiceOK"
	/// Check Remember my choice and click OK in the dialog box above to join games faster in the future!
	/// English String: "Check {startBold}Remember my choice{endBold} and click {startBold2}OK{endBold2} in the dialog box above to join games faster in the future!"
	/// </summary>
	public override string ResponseCheckRememberMyChoiceOK(string startBold, string endBold, string startBold2, string endBold2)
	{
		return $"Wähle {startBold}Meine Auswahl speichern{endBold} und klicke im Dialogfenster oben auf {startBold2}Okay{endBold2}, um Spielen in Zukunft schneller beitreten zu können!";
	}

	protected override string _GetTemplateForResponseCheckRememberMyChoiceOK()
	{
		return "Wähle {startBold}Meine Auswahl speichern{endBold} und klicke im Dialogfenster oben auf {startBold2}Okay{endBold2}, um Spielen in Zukunft schneller beitreten zu können!";
	}

	protected override string _GetTemplateForResponseDialogClickHere()
	{
		return "Klicke hier!";
	}

	protected override string _GetTemplateForResponseDialogErrorLaunching()
	{
		return "Beim Starten des Spiels ist ein Fehler aufgetreten. Bitte versuche es später erneut.";
	}

	protected override string _GetTemplateForResponseDialogHavingTroubleInstallQuestion()
	{
		return "Hast du Probleme bei der Installation von Roblox?";
	}

	/// <summary>
	/// Key: "Response.Dialog.InstallingMessageWithLink"
	/// Note: For this translation, please move the linkStart and linkEnd variables with the translation for download now.
	/// English String: "The Roblox installer should download shortly. If it doesn’t, start the {linkStart}download now.{linkEnd}"
	/// </summary>
	public override string ResponseDialogInstallingMessageWithLink(string linkStart, string linkEnd)
	{
		return $"Der Roblox-Installer sollte in Kürze heruntergeladen werden. Falls dies nicht automatisch passiert, starte den {linkStart}Download jetzt{linkEnd}.";
	}

	protected override string _GetTemplateForResponseDialogInstallingMessageWithLink()
	{
		return "Der Roblox-Installer sollte in Kürze heruntergeladen werden. Falls dies nicht automatisch passiert, starte den {linkStart}Download jetzt{linkEnd}.";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacChromeFifthInstruction"
	/// After installation, click {startBold}Play{endBold} below to join the action!
	/// English String: "After installation, click {startBold}Play{endBold} below to join the action!"
	/// </summary>
	public override string ResponseDialogMacChromeFifthInstruction(string startBold, string endBold)
	{
		return $"Klicke nach der Installation unten auf {startBold}Spielen{endBold} und stürze dich ins Abenteuer!";
	}

	protected override string _GetTemplateForResponseDialogMacChromeFifthInstruction()
	{
		return "Klicke nach der Installation unten auf {startBold}Spielen{endBold} und stürze dich ins Abenteuer!";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacChromeFirstInstruction"
	/// Click {startBold}Roblox.dmg{endBold} to run the Roblox installer, which just downloaded via your web browser.
	/// English String: "Click {startBold}Roblox.dmg{endBold} to run the Roblox installer, which just downloaded via your web browser."
	/// </summary>
	public override string ResponseDialogMacChromeFirstInstruction(string startBold, string endBold)
	{
		return $"Klicke auf {startBold}Roblox.dmg{endBold}, um den Roblox-Installer zu starten, der gerade über deinen Web-Browser heruntergeladen wurde.";
	}

	protected override string _GetTemplateForResponseDialogMacChromeFirstInstruction()
	{
		return "Klicke auf {startBold}Roblox.dmg{endBold}, um den Roblox-Installer zu starten, der gerade über deinen Web-Browser heruntergeladen wurde.";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacChromeFourthInstruction"
	/// Click {startBold}Ok{endBold} once you've successfully installed Roblox.
	/// English String: "Click {startBold}Ok{endBold} once you've successfully installed Roblox."
	/// </summary>
	public override string ResponseDialogMacChromeFourthInstruction(string startBold, string endBold)
	{
		return $"Klicke auf {startBold}Okay{endBold}, nachdem du Roblox erfolgreich installiert hast.";
	}

	protected override string _GetTemplateForResponseDialogMacChromeFourthInstruction()
	{
		return "Klicke auf {startBold}Okay{endBold}, nachdem du Roblox erfolgreich installiert hast.";
	}

	protected override string _GetTemplateForResponseDialogMacChromeSecondInstruction()
	{
		return "Doppelklicke auf das Roblox-Appsymbol, um die Installation zu starten.";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacChromeThirdInstruction"
	/// Click {startBold}Open{endBold} when prompted by your computer.
	/// English String: "Click {startBold}Open{endBold} when prompted by your computer."
	/// </summary>
	public override string ResponseDialogMacChromeThirdInstruction(string startBold, string endBold)
	{
		return $"Klicke auf {startBold}Öffnen{endBold}, wenn dich dein Computer dazu auffordert.";
	}

	protected override string _GetTemplateForResponseDialogMacChromeThirdInstruction()
	{
		return "Klicke auf {startBold}Öffnen{endBold}, wenn dich dein Computer dazu auffordert.";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacFirefoxFifthInstruction"
	/// Then select the Remember my choice... checkbox and click OK
	/// English String: "Then select the {startBold}Remember my choice...{endBold} checkbox and click {startBold2}OK{endBold2}"
	/// </summary>
	public override string ResponseDialogMacFirefoxFifthInstruction(string startBold, string endBold, string startBold2, string endBold2)
	{
		return $"Aktiviere dann das Kontrollkästchen für {startBold}Meine Auswahl speichern\u00a0...{endBold} und klicke auf {startBold2}Okay{endBold2}.";
	}

	protected override string _GetTemplateForResponseDialogMacFirefoxFifthInstruction()
	{
		return "Aktiviere dann das Kontrollkästchen für {startBold}Meine Auswahl speichern\u00a0...{endBold} und klicke auf {startBold2}Okay{endBold2}.";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacFirefoxFirstInstruction"
	/// Select Open with and click OK
	/// English String: "Select {startBold}Open with{endBold} and click {startBold2}OK{endBold2}"
	/// </summary>
	public override string ResponseDialogMacFirefoxFirstInstruction(string startBold, string endBold, string startBold2, string endBold2)
	{
		return $"Wähle {startBold}Öffnen mit{endBold} und klicke auf {startBold2}Okay{endBold2}.";
	}

	protected override string _GetTemplateForResponseDialogMacFirefoxFirstInstruction()
	{
		return "Wähle {startBold}Öffnen mit{endBold} und klicke auf {startBold2}Okay{endBold2}.";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacFirefoxFourthInstruction"
	/// Once installed, click Play to join the action!
	/// English String: "Once installed, click {startBold}Play{endBold} to join the action!"
	/// </summary>
	public override string ResponseDialogMacFirefoxFourthInstruction(string startBold, string endBold)
	{
		return $"Klicke nach der Installation auf {startBold}Spielen{endBold} und stürze dich ins Abenteuer!";
	}

	protected override string _GetTemplateForResponseDialogMacFirefoxFourthInstruction()
	{
		return "Klicke nach der Installation auf {startBold}Spielen{endBold} und stürze dich ins Abenteuer!";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacFirefoxSecondInstruction"
	/// Double-click the Roblox Icon to begin the installation process
	/// English String: "Double-click the {startBold}Roblox Icon{endBold} to begin the installation process"
	/// </summary>
	public override string ResponseDialogMacFirefoxSecondInstruction(string startBold, string endBold)
	{
		return $"Doppelklicke auf das {startBold}Roblox-Symbol{endBold}, um die Installation zu starten.";
	}

	protected override string _GetTemplateForResponseDialogMacFirefoxSecondInstruction()
	{
		return "Doppelklicke auf das {startBold}Roblox-Symbol{endBold}, um die Installation zu starten.";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacFirefoxThirdInstruction"
	/// You will receive a warning, click Open
	/// English String: "You will receive a warning, click {startBold}Open{endBold}"
	/// </summary>
	public override string ResponseDialogMacFirefoxThirdInstruction(string startBold, string endBold)
	{
		return $"Du wirst eine Warnmeldung erhalten, klicke auf {startBold}Öffnen{endBold}.";
	}

	protected override string _GetTemplateForResponseDialogMacFirefoxThirdInstruction()
	{
		return "Du wirst eine Warnmeldung erhalten, klicke auf {startBold}Öffnen{endBold}.";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacSafariFirstInstruction"
	/// Go to Downloads and double-click Roblox.dmg
	/// English String: "Go to Downloads and double-click {startBold}Roblox.dmg{endBold}"
	/// </summary>
	public override string ResponseDialogMacSafariFirstInstruction(string startBold, string endBold)
	{
		return $"Gehe zu deinen Downloads und doppelklicke auf {startBold}Roblox.dmg{endBold}.";
	}

	protected override string _GetTemplateForResponseDialogMacSafariFirstInstruction()
	{
		return "Gehe zu deinen Downloads und doppelklicke auf {startBold}Roblox.dmg{endBold}.";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacSafariFourthInstruction"
	/// Once installed, click {startBold}Play{endBold} to join the action!
	/// English String: "Once installed, click {startBold}Play{endBold} to join the action!"
	/// </summary>
	public override string ResponseDialogMacSafariFourthInstruction(string startBold, string endBold)
	{
		return $"Klicke nach der Installation auf {startBold}Spielen{endBold} und stürze dich ins Abenteuer!";
	}

	protected override string _GetTemplateForResponseDialogMacSafariFourthInstruction()
	{
		return "Klicke nach der Installation auf {startBold}Spielen{endBold} und stürze dich ins Abenteuer!";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacSafariSecondInstruction"
	/// Double-click the {startBold}Roblox Icon{endBold} to begin the installation process
	/// English String: "Double-click the {startBold}Roblox Icon{endBold} to begin the installation process"
	/// </summary>
	public override string ResponseDialogMacSafariSecondInstruction(string startBold, string endBold)
	{
		return $"Doppelklicke auf das {startBold}Roblox-Symbol{endBold}, um die Installation zu starten.";
	}

	protected override string _GetTemplateForResponseDialogMacSafariSecondInstruction()
	{
		return "Doppelklicke auf das {startBold}Roblox-Symbol{endBold}, um die Installation zu starten.";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacSafariThirdInstruction"
	/// You will receive a warning, click {startBold}Open{endBold}
	/// English String: "You will receive a warning, click {startBold}Open{endBold}"
	/// </summary>
	public override string ResponseDialogMacSafariThirdInstruction(string startBold, string endBold)
	{
		return $"Du wirst eine Warnmeldung erhalten, klicke auf {startBold}Öffnen{endBold}.";
	}

	protected override string _GetTemplateForResponseDialogMacSafariThirdInstruction()
	{
		return "Du wirst eine Warnmeldung erhalten, klicke auf {startBold}Öffnen{endBold}.";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcChromeFirstInstruction"
	/// Click {startBold}RobloxPlayer.exe{endBold} to run the Roblox installer, which just downloaded via your web browser.
	/// English String: "Click {startBold}RobloxPlayer.exe{endBold} to run the Roblox installer, which just downloaded via your web browser."
	/// </summary>
	public override string ResponseDialogPcChromeFirstInstruction(string startBold, string endBold)
	{
		return $"Klicke auf {startBold}RobloxPlayer.exe{endBold}, um den Roblox-Installer zu starten, der gerade über deinen Web-Browser heruntergeladen wurde.";
	}

	protected override string _GetTemplateForResponseDialogPcChromeFirstInstruction()
	{
		return "Klicke auf {startBold}RobloxPlayer.exe{endBold}, um den Roblox-Installer zu starten, der gerade über deinen Web-Browser heruntergeladen wurde.";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcChromeFourthInstruction"
	/// After installation, click {startBold}Play{endBold} below to join the action!
	/// English String: "After installation, click {startBold}Play{endBold} below to join the action!"
	/// </summary>
	public override string ResponseDialogPcChromeFourthInstruction(string startBold, string endBold)
	{
		return $"Klicke nach der Installation unten auf {startBold}Spielen{endBold} und stürze dich ins Abenteuer!";
	}

	protected override string _GetTemplateForResponseDialogPcChromeFourthInstruction()
	{
		return "Klicke nach der Installation unten auf {startBold}Spielen{endBold} und stürze dich ins Abenteuer!";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcChromeSecondInstruction"
	/// Click {startBold}Run{endBold} when prompted by your computer to begin the installation process.
	/// English String: "Click {startBold}Run{endBold} when prompted by your computer to begin the installation process."
	/// </summary>
	public override string ResponseDialogPcChromeSecondInstruction(string startBold, string endBold)
	{
		return $"Klicke auf {startBold}Ausführen{endBold}, wenn dich dein Computer dazu auffordert, um die Installation zu starten.";
	}

	protected override string _GetTemplateForResponseDialogPcChromeSecondInstruction()
	{
		return "Klicke auf {startBold}Ausführen{endBold}, wenn dich dein Computer dazu auffordert, um die Installation zu starten.";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcChromeThirdInstruction"
	/// Click {startBold}Ok{endBold} once you've successfully installed Roblox.
	/// English String: "Click {startBold}Ok{endBold} once you've successfully installed Roblox."
	/// </summary>
	public override string ResponseDialogPcChromeThirdInstruction(string startBold, string endBold)
	{
		return $"Klicke auf {startBold}Okay{endBold}, nachdem du Roblox erfolgreich installiert hast.";
	}

	protected override string _GetTemplateForResponseDialogPcChromeThirdInstruction()
	{
		return "Klicke auf {startBold}Okay{endBold}, nachdem du Roblox erfolgreich installiert hast.";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcEdgeFirstInstruction"
	/// Click {startBold}Run{endBold} to install Roblox after the download finishes
	/// English String: "Click {startBold}Run{endBold} to install Roblox after the download finishes"
	/// </summary>
	public override string ResponseDialogPcEdgeFirstInstruction(string startBold, string endBold)
	{
		return $"Klicke auf {startBold}Ausführen{endBold}, um Roblox nach dem Herunterladen zu installieren.";
	}

	protected override string _GetTemplateForResponseDialogPcEdgeFirstInstruction()
	{
		return "Klicke auf {startBold}Ausführen{endBold}, um Roblox nach dem Herunterladen zu installieren.";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcEdgeSecondInstruction"
	/// Click {startBold}Ok{endBold} to finish installing Roblox
	/// English String: "Click {startBold}Ok{endBold} to finish installing Roblox"
	/// </summary>
	public override string ResponseDialogPcEdgeSecondInstruction(string startBold, string endBold)
	{
		return $"Klicke auf {startBold}Okay{endBold}, um die Installation von Roblox abzuschließen.";
	}

	protected override string _GetTemplateForResponseDialogPcEdgeSecondInstruction()
	{
		return "Klicke auf {startBold}Okay{endBold}, um die Installation von Roblox abzuschließen.";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcEdgeThirdInstruction"
	/// Click the {startBold}Play{endBold} button to join the action!
	/// English String: "Click the {startBold}Play{endBold} button to join the action!"
	/// </summary>
	public override string ResponseDialogPcEdgeThirdInstruction(string startBold, string endBold)
	{
		return $"Klicke auf {startBold}Spielen{endBold} und stürze dich ins Abenteuer!";
	}

	protected override string _GetTemplateForResponseDialogPcEdgeThirdInstruction()
	{
		return "Klicke auf {startBold}Spielen{endBold} und stürze dich ins Abenteuer!";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcFirefoxFifthInstruction"
	/// Click {startBold}Ok{endBold} when the alert pops up
	/// English String: "Click {startBold}Ok{endBold} when the alert pops up"
	/// </summary>
	public override string ResponseDialogPcFirefoxFifthInstruction(string startBold, string endBold)
	{
		return $"Klicke auf {startBold}Okay{endBold}, wenn die Warnmeldung angezeigt wird.";
	}

	protected override string _GetTemplateForResponseDialogPcFirefoxFifthInstruction()
	{
		return "Klicke auf {startBold}Okay{endBold}, wenn die Warnmeldung angezeigt wird.";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcFirefoxFirstInstruction"
	/// Click {startBold}Save File{endBold} when the download window pops up
	/// English String: "Click {startBold}Save File{endBold} when the download window pops up"
	/// </summary>
	public override string ResponseDialogPcFirefoxFirstInstruction(string startBold, string endBold)
	{
		return $"Klicke auf {startBold}Datei speichern{endBold}, wenn das Download-Fenster angezeigt wird.";
	}

	protected override string _GetTemplateForResponseDialogPcFirefoxFirstInstruction()
	{
		return "Klicke auf {startBold}Datei speichern{endBold}, wenn das Download-Fenster angezeigt wird.";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcFirefoxFourthInstruction"
	/// Once installed, click {startBold}Play{endBold} to join the action!
	/// English String: "Once installed, click {startBold}Play{endBold} to join the action!"
	/// </summary>
	public override string ResponseDialogPcFirefoxFourthInstruction(string startBold, string endBold)
	{
		return $"Klicke nach der Installation auf {startBold}Spielen{endBold} und stürze dich ins Abenteuer!";
	}

	protected override string _GetTemplateForResponseDialogPcFirefoxFourthInstruction()
	{
		return "Klicke nach der Installation auf {startBold}Spielen{endBold} und stürze dich ins Abenteuer!";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcFirefoxSecondInstruction"
	/// Go to Downloads and double click {startBold}RobloxPlayer.exe{endBold}
	/// English String: "Go to Downloads and double click {startBold}RobloxPlayer.exe{endBold}"
	/// </summary>
	public override string ResponseDialogPcFirefoxSecondInstruction(string startBold, string endBold)
	{
		return $"Gehe zu deinen Downloads und doppelklicke auf {startBold}RobloxPlayer.exe{endBold}.";
	}

	protected override string _GetTemplateForResponseDialogPcFirefoxSecondInstruction()
	{
		return "Gehe zu deinen Downloads und doppelklicke auf {startBold}RobloxPlayer.exe{endBold}.";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcFirefoxThirdInstruction"
	/// Click {startBold}Run{endBold}
	/// English String: "Click {startBold}Run{endBold}"
	/// </summary>
	public override string ResponseDialogPcFirefoxThirdInstruction(string startBold, string endBold)
	{
		return $"Klicke auf {startBold}Ausführen{endBold}.";
	}

	protected override string _GetTemplateForResponseDialogPcFirefoxThirdInstruction()
	{
		return "Klicke auf {startBold}Ausführen{endBold}.";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcIEFirstInstruction"
	/// You will receive a warning, click {startBold}Run{endBold}
	/// English String: "You will receive a warning, click {startBold}Run{endBold}"
	/// </summary>
	public override string ResponseDialogPcIEFirstInstruction(string startBold, string endBold)
	{
		return $"Du wirst eine Warnmeldung erhalten, klicke auf {startBold}Ausführen{endBold}.";
	}

	protected override string _GetTemplateForResponseDialogPcIEFirstInstruction()
	{
		return "Du wirst eine Warnmeldung erhalten, klicke auf {startBold}Ausführen{endBold}.";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcIeInstructionOne"
	/// You will receive a warning, click {startBold}Run{endBold}
	/// English String: "You will receive a warning, click {startBold}Run{endBold}"
	/// </summary>
	public override string ResponseDialogPcIeInstructionOne(string startBold, string endBold)
	{
		return $"Du wirst eine Warnmeldung erhalten, klicke auf {startBold}Ausführen{endBold}.";
	}

	protected override string _GetTemplateForResponseDialogPcIeInstructionOne()
	{
		return "Du wirst eine Warnmeldung erhalten, klicke auf {startBold}Ausführen{endBold}.";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcIeInstructionThree"
	/// Click {startBold}Run{endBold}
	/// English String: "Click {startBold}Run{endBold}"
	/// </summary>
	public override string ResponseDialogPcIeInstructionThree(string startBold, string endBold)
	{
		return $"Klicke auf {startBold}Ausführen{endBold}.";
	}

	protected override string _GetTemplateForResponseDialogPcIeInstructionThree()
	{
		return "Klicke auf {startBold}Ausführen{endBold}.";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcIeInstructionTwo"
	/// Go to Downloads and double click {startBold}RobloxPlayer.exe{endBold}
	/// English String: "Go to Downloads and double click {startBold}RobloxPlayer.exe{endBold}"
	/// </summary>
	public override string ResponseDialogPcIeInstructionTwo(string startBold, string endBold)
	{
		return $"Gehe zu deinen Downloads und doppelklicke auf {startBold}RobloxPlayer.exe{endBold}.";
	}

	protected override string _GetTemplateForResponseDialogPcIeInstructionTwo()
	{
		return "Gehe zu deinen Downloads und doppelklicke auf {startBold}RobloxPlayer.exe{endBold}.";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcIESecondInstruction"
	/// Click {startBold}Ok{endBold} once you've installed Roblox
	/// English String: "Click {startBold}Ok{endBold} once you've installed Roblox"
	/// </summary>
	public override string ResponseDialogPcIESecondInstruction(string startBold, string endBold)
	{
		return $"Klicke auf {startBold}Okay{endBold}, nachdem du Roblox installiert hast.";
	}

	protected override string _GetTemplateForResponseDialogPcIESecondInstruction()
	{
		return "Klicke auf {startBold}Okay{endBold}, nachdem du Roblox installiert hast.";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcIEThirdInstruction"
	/// Once installed, click {startBold}Play{endBold} to join the action!
	/// English String: "Once installed, click {startBold}Play{endBold} to join the action!"
	/// </summary>
	public override string ResponseDialogPcIEThirdInstruction(string startBold, string endBold)
	{
		return $"Klicke nach der Installation auf {startBold}Spielen{endBold} und stürze dich ins Abenteuer!";
	}

	protected override string _GetTemplateForResponseDialogPcIEThirdInstruction()
	{
		return "Klicke nach der Installation auf {startBold}Spielen{endBold} und stürze dich ins Abenteuer!";
	}

	protected override string _GetTemplateForResponseDialogThanksForPlayingRoblox()
	{
		return "Danke, dass du Roblox spielst.";
	}

	protected override string _GetTemplateForResponseGameTemporarilyUnavailable()
	{
		return "Dein Zugriffsrecht auf dieses Spiel konnte nicht bestätigt werden. Bitte versuche es später erneut.";
	}

	/// <summary>
	/// Key: "Response.RememberMyChoiceAppLaunch"
	/// Check {startBold}Remember my choice{endBold} and click {appLaunchLink} in the dialog box above to join games faster in the future!
	/// English String: "Check {startBold}Remember my choice{endBold} and click {appLaunchLink} in the dialog box above to join games faster in the future!"
	/// </summary>
	public override string ResponseRememberMyChoiceAppLaunch(string startBold, string endBold, string appLaunchLink)
	{
		return $"Wähle {startBold}Meine Auswahl speichern{endBold} und klicke im Dialogfenster oben auf {appLaunchLink}, um Spielen in Zukunft schneller beitreten zu können!";
	}

	protected override string _GetTemplateForResponseRememberMyChoiceAppLaunch()
	{
		return "Wähle {startBold}Meine Auswahl speichern{endBold} und klicke im Dialogfenster oben auf {appLaunchLink}, um Spielen in Zukunft schneller beitreten zu können!";
	}
}
