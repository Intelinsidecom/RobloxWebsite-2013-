namespace Roblox.TranslationResources.Common;

/// <summary>
/// This class overrides VisitGameResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class VisitGameResources_fr_fr : VisitGameResources_en_us, IVisitGameResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Retry"
	/// button label
	/// English String: "Retry"
	/// </summary>
	public override string ActionRetry => "Réessayer";

	/// <summary>
	/// Key: "Heading.ErrorStartingGame"
	/// Error starting game
	/// English String: "Error starting game"
	/// </summary>
	public override string HeadingErrorStartingGame => "Erreur lors du lancement du jeu";

	/// <summary>
	/// Key: "Heading.SwitchToDesktopToPlay"
	/// Switch to Desktop Mode to Play Games
	/// English String: "Switch to Desktop Mode to Play Games"
	/// </summary>
	public override string HeadingSwitchToDesktopToPlay => "Passez en mode bureau pour jouer";

	/// <summary>
	/// Key: "Label.Cancel"
	/// Cancel
	/// English String: "Cancel"
	/// </summary>
	public override string LabelCancel => "Annuler";

	/// <summary>
	/// Key: "Label.CheckingForStudio"
	/// We are checking if user has Roblox Studio installed
	/// English String: "Checking for Roblox Studio..."
	/// </summary>
	public override string LabelCheckingForStudio => "Vérification de Roblox Studio...";

	/// <summary>
	/// Key: "Label.ClickHereForHelp"
	/// Click here for help
	/// English String: "Click here for help"
	/// </summary>
	public override string LabelClickHereForHelp => "Cliquez ici pour obtenir de l'aide";

	/// <summary>
	/// Key: "Label.ConnectingToPlayers"
	/// Joining a game network with other players
	/// English String: "Connecting to Players..."
	/// </summary>
	public override string LabelConnectingToPlayers => "Connexion aux joueurs...";

	/// <summary>
	/// Key: "Label.DevelopPageTitle"
	/// English String: "Develop"
	/// </summary>
	public override string LabelDevelopPageTitle => "Développer";

	/// <summary>
	/// Key: "Label.DownloadInstallRoblox"
	/// Download and Install Roblox
	/// English String: "Download and Install Roblox"
	/// </summary>
	public override string LabelDownloadInstallRoblox => "Télécharger et installer Roblox";

	/// <summary>
	/// Key: "Label.DownloadStudio"
	/// Download Roblox Studio to start creating games
	/// English String: "Download Studio"
	/// </summary>
	public override string LabelDownloadStudio => "Télécharger Studio";

	/// <summary>
	/// Key: "Label.GameConfigurePageTitle"
	/// English String: "Game Configure"
	/// </summary>
	public override string LabelGameConfigurePageTitle => "Configuration du jeu";

	/// <summary>
	/// Key: "Label.GameFreeSoothsayer"
	/// English String: "Free because you are a soothsayer"
	/// </summary>
	public override string LabelGameFreeSoothsayer => "Gratuit car vous êtes devin";

	/// <summary>
	/// Key: "Label.GameUnavailableAccountResrictions"
	/// English String: "The game is unavailable due to account restrictions settings."
	/// </summary>
	public override string LabelGameUnavailableAccountResrictions => "Le jeu est indisponible en raison des paramètres de limitation du compte.";

	/// <summary>
	/// Key: "Label.GameUnavailableCannotPlayGamesStudio"
	/// English String: "You cannot play games from Studio. Please use a web browser to play this game."
	/// </summary>
	public override string LabelGameUnavailableCannotPlayGamesStudio => "Vous ne pouvez pas jouer depuis Studio. Veuillez utiliser un navigateur Internet pour jouer à ce jeu.";

	/// <summary>
	/// Key: "Label.GameUnavailableClosedToVisitors"
	/// English String: "Sorry, this place is currently closed to visitors."
	/// </summary>
	public override string LabelGameUnavailableClosedToVisitors => "Désolé, cet emplacement est actuellement fermé aux visiteurs.";

	/// <summary>
	/// Key: "Label.GameUnavailableCurrentlyIsPrivateVisitor"
	/// When a game is private, this message is shown to visitors.
	/// English String: "Sorry, this game is private."
	/// </summary>
	public override string LabelGameUnavailableCurrentlyIsPrivateVisitor => "Désolé, ce jeu est privé.";

	/// <summary>
	/// Key: "Label.GameUnavailableGameInsecure"
	/// U13 users cannot play insecure games unless they are the creator or friends with the creator.
	/// English String: "Sorry, your account is restricted from playing Experimental Games unless you are friends with the creator."
	/// </summary>
	public override string LabelGameUnavailableGameInsecure => "Désolé, ton compte est restreint et tu ne peux pas jouer aux jeux expérimentaux si tu n'es pas ami-e avec le créateur.";

	/// <summary>
	/// Key: "Label.GameUnavailablePermissionLevels"
	/// English String: "The permission levels on this place prevent you from entering."
	/// </summary>
	public override string LabelGameUnavailablePermissionLevels => "Les niveaux de permission de cet emplacement vous empêchent d'y entrer.";

	/// <summary>
	/// Key: "Label.GameUnavailablePlaceUnderReview"
	/// English String: "Sorry, this place is currently under review. Try again later."
	/// </summary>
	public override string LabelGameUnavailablePlaceUnderReview => "Désolé, cet emplacement est actuellement en cours d'évaluation. Veuillez réessayer plus tard.";

	/// <summary>
	/// Key: "Label.GameUnavailablePlatform"
	/// English String: "This game is not available on your platform.  Check the games page to see all playable games."
	/// </summary>
	public override string LabelGameUnavailablePlatform => "Ce jeu n'est pas disponible sur ta plateforme. Consulte la page des jeux pour voir tous les jeux auxquels tu peux jouer.";

	/// <summary>
	/// Key: "Label.GameWarning"
	/// English String: "Warning"
	/// </summary>
	public override string LabelGameWarning => "Avertissement";

	/// <summary>
	/// Key: "Label.InstallationInstructions"
	/// Installation Instructions
	/// English String: "Installation Instructions"
	/// </summary>
	public override string LabelInstallationInstructions => "Instructions d'installation";

	/// <summary>
	/// Key: "Label.LaunchApplication"
	/// Launch Application
	/// English String: "Launch Application"
	/// </summary>
	public override string LabelLaunchApplication => "Lancer l'application";

	/// <summary>
	/// Key: "Label.PersuadeToDevelopRoblox"
	/// Persuade user to begin developing their own games using Roblox Studio
	/// English String: "Get started creating your own games!"
	/// </summary>
	public override string LabelPersuadeToDevelopRoblox => "Commencez à créer vos propres jeux\u00a0!";

	/// <summary>
	/// Key: "Label.PersuadeToInstallRoblox"
	/// We are exciting the user about Roblox so that they will be persuaded to download and install it.
	/// English String: "You're moments away from getting into the game!"
	/// </summary>
	public override string LabelPersuadeToInstallRoblox => "Vous n'êtes qu'à quelques pas d'entrer dans le jeu\u00a0!";

	/// <summary>
	/// Key: "Label.Play"
	/// English String: "Play"
	/// </summary>
	public override string LabelPlay => "Jouer";

	/// <summary>
	/// Key: "Label.PlayInApp"
	/// English String: "Play in App"
	/// </summary>
	public override string LabelPlayInApp => "Jouer dans l'application";

	/// <summary>
	/// Key: "Label.RobloxLoadingToPlay"
	/// Roblox is loading, so the user is getting excited to start playing a game
	/// English String: "Roblox is now loading. Get ready to play!"
	/// </summary>
	public override string LabelRobloxLoadingToPlay => "Roblox est en cours de chargement. Préparez-vous à jouer\u00a0!";

	/// <summary>
	/// Key: "Label.StartingRoblox"
	/// Game launch process has started
	/// English String: "Starting Roblox..."
	/// </summary>
	public override string LabelStartingRoblox => "Lancement de Roblox...";

	/// <summary>
	/// Key: "Label.SwitchToDesktopMode"
	/// Switch to Desktop Mode
	/// English String: "Switch to Desktop Mode"
	/// </summary>
	public override string LabelSwitchToDesktopMode => "Passer en mode bureau";

	/// <summary>
	/// Key: "Label.UniverseConfigurePageTitle"
	/// The name of the universe configuration page
	/// English String: "Universe Configuration"
	/// </summary>
	public override string LabelUniverseConfigurePageTitle => "Configuration de l'univers";

	/// <summary>
	/// Key: "Response.Dialog.ClickHere"
	/// Click here!
	/// English String: "Click here!"
	/// </summary>
	public override string ResponseDialogClickHere => "Cliquez ici\u00a0!";

	/// <summary>
	/// Key: "Response.Dialog.ErrorLaunching"
	/// An error occurred trying to launch the game.  Please try again later.
	/// English String: "An error occurred trying to launch the game.  Please try again later."
	/// </summary>
	public override string ResponseDialogErrorLaunching => "Une erreur est survenue lors du lancement du jeu. Veuillez réessayer plus tard.";

	/// <summary>
	/// Key: "Response.Dialog.HavingTroubleInstallQuestion"
	/// (Are you) having trouble installing Roblox?
	/// English String: "Having trouble installing Roblox?"
	/// </summary>
	public override string ResponseDialogHavingTroubleInstallQuestion => "Vous rencontrez des difficultés pour installer Roblox\u00a0?";

	/// <summary>
	/// Key: "Response.Dialog.MacChromeSecondInstruction"
	/// Double-click the Roblox app icon to begin the installation process.
	/// English String: "Double-click the Roblox app icon to begin the installation process."
	/// </summary>
	public override string ResponseDialogMacChromeSecondInstruction => "Double-cliquez sur l'icône de l'application Roblox pour démarrer l'installation.";

	/// <summary>
	/// Key: "Response.Dialog.ThanksForPlayingRoblox"
	/// Thanks for playing Roblox
	/// English String: "Thanks for playing Roblox"
	/// </summary>
	public override string ResponseDialogThanksForPlayingRoblox => "Merci de jouer à Roblox";

	/// <summary>
	/// Key: "Response.GameTemporarilyUnavailable"
	/// error message (will be followed by link with Action.Retry label)
	/// English String: "Unable to verify that you have access to this game.  Please try again later."
	/// </summary>
	public override string ResponseGameTemporarilyUnavailable => "Impossible de vérifier que vous avez l'autorisation d'accéder à ce jeu. Veuillez réessayer plus tard.";

	public VisitGameResources_fr_fr(TranslationResourceState state)
		: base(state)
	{
	}

	/// <summary>
	/// Key: "Action.GamePerformPoorly"
	/// English String: "{warning} This game may perform poorly on your device."
	/// </summary>
	public override string ActionGamePerformPoorly(string warning)
	{
		return $"{warning} Ce jeu est susceptible de mal fonctionner sur ton appareil.";
	}

	protected override string _GetTemplateForActionGamePerformPoorly()
	{
		return "{warning} Ce jeu est susceptible de mal fonctionner sur ton appareil.";
	}

	protected override string _GetTemplateForActionRetry()
	{
		return "Réessayer";
	}

	protected override string _GetTemplateForHeadingErrorStartingGame()
	{
		return "Erreur lors du lancement du jeu";
	}

	protected override string _GetTemplateForHeadingSwitchToDesktopToPlay()
	{
		return "Passez en mode bureau pour jouer";
	}

	/// <summary>
	/// Key: "Label.BuyAccess"
	/// English String: "Buy Access for {robux} Robux"
	/// </summary>
	public override string LabelBuyAccess(string robux)
	{
		return $"Accéder pour {robux}\u00a0Robux";
	}

	protected override string _GetTemplateForLabelBuyAccess()
	{
		return "Accéder pour {robux}\u00a0Robux";
	}

	protected override string _GetTemplateForLabelCancel()
	{
		return "Annuler";
	}

	protected override string _GetTemplateForLabelCheckingForStudio()
	{
		return "Vérification de Roblox Studio...";
	}

	protected override string _GetTemplateForLabelClickHereForHelp()
	{
		return "Cliquez ici pour obtenir de l'aide";
	}

	protected override string _GetTemplateForLabelConnectingToPlayers()
	{
		return "Connexion aux joueurs...";
	}

	protected override string _GetTemplateForLabelDevelopPageTitle()
	{
		return "Développer";
	}

	protected override string _GetTemplateForLabelDownloadInstallRoblox()
	{
		return "Télécharger et installer Roblox";
	}

	protected override string _GetTemplateForLabelDownloadStudio()
	{
		return "Télécharger Studio";
	}

	protected override string _GetTemplateForLabelGameConfigurePageTitle()
	{
		return "Configuration du jeu";
	}

	protected override string _GetTemplateForLabelGameFreeSoothsayer()
	{
		return "Gratuit car vous êtes devin";
	}

	/// <summary>
	/// Key: "Label.GameIsPrivatePlayableByGroupOnly"
	/// When a game is private, this message is shown to group developers with a link from where it can be made public.
	/// English String: "Only developers can play because this game is private. Make it public on the {linkStart}Configure Game{linkEnd} page."
	/// </summary>
	public override string LabelGameIsPrivatePlayableByGroupOnly(string linkStart, string linkEnd)
	{
		return $"Seuls les développeurs peuvent jouer à ce jeu, car il est privé. Rendez-le public depuis la page {linkStart}Configurer le jeu{linkEnd}.";
	}

	protected override string _GetTemplateForLabelGameIsPrivatePlayableByGroupOnly()
	{
		return "Seuls les développeurs peuvent jouer à ce jeu, car il est privé. Rendez-le public depuis la page {linkStart}Configurer le jeu{linkEnd}.";
	}

	/// <summary>
	/// Key: "Label.GameIsPrivatePlayableByOwnerOnly"
	/// When a game is private, this message is shown to owner with a link from where it can be made public.
	/// English String: "Only you can play because this game is private. Make it public on the {linkStart}Configure Game{linkEnd} page."
	/// </summary>
	public override string LabelGameIsPrivatePlayableByOwnerOnly(string linkStart, string linkEnd)
	{
		return $"Vous seul pouvez jouer à ce jeu car il est privé. Rendez-le public depuis la page {linkStart}Configurer le jeu{linkEnd}.";
	}

	protected override string _GetTemplateForLabelGameIsPrivatePlayableByOwnerOnly()
	{
		return "Vous seul pouvez jouer à ce jeu car il est privé. Rendez-le public depuis la page {linkStart}Configurer le jeu{linkEnd}.";
	}

	protected override string _GetTemplateForLabelGameUnavailableAccountResrictions()
	{
		return "Le jeu est indisponible en raison des paramètres de limitation du compte.";
	}

	protected override string _GetTemplateForLabelGameUnavailableCannotPlayGamesStudio()
	{
		return "Vous ne pouvez pas jouer depuis Studio. Veuillez utiliser un navigateur Internet pour jouer à ce jeu.";
	}

	protected override string _GetTemplateForLabelGameUnavailableClosedToVisitors()
	{
		return "Désolé, cet emplacement est actuellement fermé aux visiteurs.";
	}

	/// <summary>
	/// Key: "Label.GameUnavailableCurrentlyIsPrivateGroup"
	/// When a game is private, this message is shown to group developers with a link from where it can be made public. Similar to an existing translation. Change is making the message directly address the group developers.
	/// English String: "Only developers can play because this game is private. Make it public on the {linkStart}Develop{linkEnd} page."
	/// </summary>
	public override string LabelGameUnavailableCurrentlyIsPrivateGroup(string linkStart, string linkEnd)
	{
		return $"Seuls les développeurs peuvent jouer à ce jeu, car il est privé. Rendez-le public depuis la page {linkStart}Développer{linkEnd}.";
	}

	protected override string _GetTemplateForLabelGameUnavailableCurrentlyIsPrivateGroup()
	{
		return "Seuls les développeurs peuvent jouer à ce jeu, car il est privé. Rendez-le public depuis la page {linkStart}Développer{linkEnd}.";
	}

	/// <summary>
	/// Key: "Label.GameUnavailableCurrentlyIsPrivateOwner"
	/// When a game is private, this message is shown to owner with a link from where it can be made public. Similar to an existing translation. Change is making the message directly address the owner.
	/// English String: "Only you can play because this game is private. Make it public on the {linkStart}Develop{linkEnd} page."
	/// </summary>
	public override string LabelGameUnavailableCurrentlyIsPrivateOwner(string linkStart, string linkEnd)
	{
		return $"Vous seul pouvez jouer à ce jeu car il est privé. Rendez-le public depuis la page {linkStart}Développer{linkEnd}.";
	}

	protected override string _GetTemplateForLabelGameUnavailableCurrentlyIsPrivateOwner()
	{
		return "Vous seul pouvez jouer à ce jeu car il est privé. Rendez-le public depuis la page {linkStart}Développer{linkEnd}.";
	}

	protected override string _GetTemplateForLabelGameUnavailableCurrentlyIsPrivateVisitor()
	{
		return "Désolé, ce jeu est privé.";
	}

	/// <summary>
	/// Key: "Label.GameUnavailableCurrentlyPrivate"
	/// When a game is private, this message is shown to user with link from where it can be made public
	/// English String: "This {gameTypeName} is currently private. Make it public on the {developPageLink} page to make it playable."
	/// </summary>
	public override string LabelGameUnavailableCurrentlyPrivate(string gameTypeName, string developPageLink)
	{
		return $"Ce jeu de type {gameTypeName} est actuellement privé. Rendez-le public depuis la page {developPageLink} afin de permettre aux utilisateurs d'y jouer.";
	}

	protected override string _GetTemplateForLabelGameUnavailableCurrentlyPrivate()
	{
		return "Ce jeu de type {gameTypeName} est actuellement privé. Rendez-le public depuis la page {developPageLink} afin de permettre aux utilisateurs d'y jouer.";
	}

	protected override string _GetTemplateForLabelGameUnavailableGameInsecure()
	{
		return "Désolé, ton compte est restreint et tu ne peux pas jouer aux jeux expérimentaux si tu n'es pas ami-e avec le créateur.";
	}

	/// <summary>
	/// Key: "Label.GameUnavailableNoRootPlace"
	/// English String: "This place is part of a game that has no root place. Add a root place on the {gameConfigureLink} page to make it playable."
	/// </summary>
	public override string LabelGameUnavailableNoRootPlace(string gameConfigureLink)
	{
		return $"Cet emplacement fait partie d'un jeu qui n'a aucun emplacement racine. Ajoutez-en un à un jeu depuis la page {gameConfigureLink} afin de permettre aux utilisateurs d'y jouer.";
	}

	protected override string _GetTemplateForLabelGameUnavailableNoRootPlace()
	{
		return "Cet emplacement fait partie d'un jeu qui n'a aucun emplacement racine. Ajoutez-en un à un jeu depuis la page {gameConfigureLink} afin de permettre aux utilisateurs d'y jouer.";
	}

	protected override string _GetTemplateForLabelGameUnavailablePermissionLevels()
	{
		return "Les niveaux de permission de cet emplacement vous empêchent d'y entrer.";
	}

	/// <summary>
	/// Key: "Label.GameUnavailablePlaceNotPartOfGame"
	/// English String: "This place is not currently part of a Game. Add it to a game on the {developPageLink} page to make it playable."
	/// </summary>
	public override string LabelGameUnavailablePlaceNotPartOfGame(string developPageLink)
	{
		return $"Cet emplacement ne fait actuellement partie d'aucun jeu. Ajoutez-le à un jeu depuis la page {developPageLink} afin de permettre aux utilisateurs d'y jouer.";
	}

	protected override string _GetTemplateForLabelGameUnavailablePlaceNotPartOfGame()
	{
		return "Cet emplacement ne fait actuellement partie d'aucun jeu. Ajoutez-le à un jeu depuis la page {developPageLink} afin de permettre aux utilisateurs d'y jouer.";
	}

	protected override string _GetTemplateForLabelGameUnavailablePlaceUnderReview()
	{
		return "Désolé, cet emplacement est actuellement en cours d'évaluation. Veuillez réessayer plus tard.";
	}

	protected override string _GetTemplateForLabelGameUnavailablePlatform()
	{
		return "Ce jeu n'est pas disponible sur ta plateforme. Consulte la page des jeux pour voir tous les jeux auxquels tu peux jouer.";
	}

	protected override string _GetTemplateForLabelGameWarning()
	{
		return "Avertissement";
	}

	protected override string _GetTemplateForLabelInstallationInstructions()
	{
		return "Instructions d'installation";
	}

	protected override string _GetTemplateForLabelLaunchApplication()
	{
		return "Lancer l'application";
	}

	/// <summary>
	/// Key: "Label.OperaInstallSteps"
	/// 1) A window will open. Click Open2) Doubleclick the Roblox icon.
	/// English String: "1) A window will open. Click {startBold}Open{endBold}.{breakLine}2) Doubleclick the Roblox icon."
	/// </summary>
	public override string LabelOperaInstallSteps(string startBold, string endBold, string breakLine)
	{
		return $"1) Une fenêtre va s'ouvrir. Cliquez sur {startBold}Ouvrir{endBold}.{breakLine}2) Double-cliquez sur l'icône de Roblox.";
	}

	protected override string _GetTemplateForLabelOperaInstallSteps()
	{
		return "1) Une fenêtre va s'ouvrir. Cliquez sur {startBold}Ouvrir{endBold}.{breakLine}2) Double-cliquez sur l'icône de Roblox.";
	}

	protected override string _GetTemplateForLabelPersuadeToDevelopRoblox()
	{
		return "Commencez à créer vos propres jeux\u00a0!";
	}

	protected override string _GetTemplateForLabelPersuadeToInstallRoblox()
	{
		return "Vous n'êtes qu'à quelques pas d'entrer dans le jeu\u00a0!";
	}

	protected override string _GetTemplateForLabelPlay()
	{
		return "Jouer";
	}

	protected override string _GetTemplateForLabelPlayInApp()
	{
		return "Jouer dans l'application";
	}

	protected override string _GetTemplateForLabelRobloxLoadingToPlay()
	{
		return "Roblox est en cours de chargement. Préparez-vous à jouer\u00a0!";
	}

	protected override string _GetTemplateForLabelStartingRoblox()
	{
		return "Lancement de Roblox...";
	}

	protected override string _GetTemplateForLabelSwitchToDesktopMode()
	{
		return "Passer en mode bureau";
	}

	protected override string _GetTemplateForLabelUniverseConfigurePageTitle()
	{
		return "Configuration de l'univers";
	}

	/// <summary>
	/// Key: "Response.CheckAlwaysOpenRoblox"
	/// Check {startBold}Always open links for Roblox{endBold} and click {startBold2}Open Roblox{endBold2} in the dialog box above to join games faster in the future!
	/// English String: "Check {startBold}Always open links for Roblox{endBold} and click {startBold2}Open Roblox{endBold2} in the dialog box above to join games faster in the future!"
	/// </summary>
	public override string ResponseCheckAlwaysOpenRoblox(string startBold, string endBold, string startBold2, string endBold2)
	{
		return $"Cochez {startBold}Toujours ouvrir les liens pour Roblox{endBold} et cliquez sur {startBold2}Ouvrir Roblox{endBold2} dans la boîte de dialogue ci-dessus afin de rejoindre des jeux plus rapidement à l'avenir\u00a0!";
	}

	protected override string _GetTemplateForResponseCheckAlwaysOpenRoblox()
	{
		return "Cochez {startBold}Toujours ouvrir les liens pour Roblox{endBold} et cliquez sur {startBold2}Ouvrir Roblox{endBold2} dans la boîte de dialogue ci-dessus afin de rejoindre des jeux plus rapidement à l'avenir\u00a0!";
	}

	/// <summary>
	/// Key: "Response.CheckAlwaysOpenRobloxURL"
	/// Check {startBold}Always open links for URL: Roblox Protocol{endBold} and click {startBold}Open URL: Roblox Protocol{endBold} in the dialog box above to join games faster in the future!
	/// English String: "Check {startBold}Always open links for URL: Roblox Protocol{endBold} and click {startBold2}Open URL: Roblox Protocol{endBold2} in the dialog box above to join games faster in the future!"
	/// </summary>
	public override string ResponseCheckAlwaysOpenRobloxURL(string startBold, string endBold, string startBold2, string endBold2)
	{
		return $"Cochez {startBold}Toujours ouvrir les liens pour l'URL\u00a0: Protocole Roblox{endBold} et cliquez sur {startBold2}Ouvrir l'URL\u00a0: Protocole Roblox{endBold2} dans la boîte de dialogue ci-dessus afin de rejoindre des jeux plus rapidement à l'avenir\u00a0!";
	}

	protected override string _GetTemplateForResponseCheckAlwaysOpenRobloxURL()
	{
		return "Cochez {startBold}Toujours ouvrir les liens pour l'URL\u00a0: Protocole Roblox{endBold} et cliquez sur {startBold2}Ouvrir l'URL\u00a0: Protocole Roblox{endBold2} dans la boîte de dialogue ci-dessus afin de rejoindre des jeux plus rapidement à l'avenir\u00a0!";
	}

	/// <summary>
	/// Key: "Response.CheckRememberMyChoiceOK"
	/// Check Remember my choice and click OK in the dialog box above to join games faster in the future!
	/// English String: "Check {startBold}Remember my choice{endBold} and click {startBold2}OK{endBold2} in the dialog box above to join games faster in the future!"
	/// </summary>
	public override string ResponseCheckRememberMyChoiceOK(string startBold, string endBold, string startBold2, string endBold2)
	{
		return $"Cochez {startBold}Se souvenir de mon choix{endBold} et cliquez sur {startBold2}OK{endBold2} dans la boîte de dialogue ci-dessus afin de rejoindre des jeux plus rapidement à l'avenir\u00a0!";
	}

	protected override string _GetTemplateForResponseCheckRememberMyChoiceOK()
	{
		return "Cochez {startBold}Se souvenir de mon choix{endBold} et cliquez sur {startBold2}OK{endBold2} dans la boîte de dialogue ci-dessus afin de rejoindre des jeux plus rapidement à l'avenir\u00a0!";
	}

	protected override string _GetTemplateForResponseDialogClickHere()
	{
		return "Cliquez ici\u00a0!";
	}

	protected override string _GetTemplateForResponseDialogErrorLaunching()
	{
		return "Une erreur est survenue lors du lancement du jeu. Veuillez réessayer plus tard.";
	}

	protected override string _GetTemplateForResponseDialogHavingTroubleInstallQuestion()
	{
		return "Vous rencontrez des difficultés pour installer Roblox\u00a0?";
	}

	/// <summary>
	/// Key: "Response.Dialog.InstallingMessageWithLink"
	/// Note: For this translation, please move the linkStart and linkEnd variables with the translation for download now.
	/// English String: "The Roblox installer should download shortly. If it doesn’t, start the {linkStart}download now.{linkEnd}"
	/// </summary>
	public override string ResponseDialogInstallingMessageWithLink(string linkStart, string linkEnd)
	{
		return $"Le téléchargement de l'utilitaire d'installation de Roblox devrait bientôt démarrer. Si ce n'est pas le cas, lancez le téléchargement {linkStart}en cliquant ici{linkEnd}.";
	}

	protected override string _GetTemplateForResponseDialogInstallingMessageWithLink()
	{
		return "Le téléchargement de l'utilitaire d'installation de Roblox devrait bientôt démarrer. Si ce n'est pas le cas, lancez le téléchargement {linkStart}en cliquant ici{linkEnd}.";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacChromeFifthInstruction"
	/// After installation, click {startBold}Play{endBold} below to join the action!
	/// English String: "After installation, click {startBold}Play{endBold} below to join the action!"
	/// </summary>
	public override string ResponseDialogMacChromeFifthInstruction(string startBold, string endBold)
	{
		return $"Une fois l'installation terminée, cliquez sur {startBold}Jouer{endBold} ci-dessous pour plonger dans l'action\u00a0!";
	}

	protected override string _GetTemplateForResponseDialogMacChromeFifthInstruction()
	{
		return "Une fois l'installation terminée, cliquez sur {startBold}Jouer{endBold} ci-dessous pour plonger dans l'action\u00a0!";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacChromeFirstInstruction"
	/// Click {startBold}Roblox.dmg{endBold} to run the Roblox installer, which just downloaded via your web browser.
	/// English String: "Click {startBold}Roblox.dmg{endBold} to run the Roblox installer, which just downloaded via your web browser."
	/// </summary>
	public override string ResponseDialogMacChromeFirstInstruction(string startBold, string endBold)
	{
		return $"Cliquez sur {startBold}Roblox.dmg{endBold} pour exécuter l'utilitaire d'installation de Roblox que vous venez de télécharger.";
	}

	protected override string _GetTemplateForResponseDialogMacChromeFirstInstruction()
	{
		return "Cliquez sur {startBold}Roblox.dmg{endBold} pour exécuter l'utilitaire d'installation de Roblox que vous venez de télécharger.";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacChromeFourthInstruction"
	/// Click {startBold}Ok{endBold} once you've successfully installed Roblox.
	/// English String: "Click {startBold}Ok{endBold} once you've successfully installed Roblox."
	/// </summary>
	public override string ResponseDialogMacChromeFourthInstruction(string startBold, string endBold)
	{
		return $"Cliquez sur {startBold}OK{endBold} une fois l'installation de Roblox terminée.";
	}

	protected override string _GetTemplateForResponseDialogMacChromeFourthInstruction()
	{
		return "Cliquez sur {startBold}OK{endBold} une fois l'installation de Roblox terminée.";
	}

	protected override string _GetTemplateForResponseDialogMacChromeSecondInstruction()
	{
		return "Double-cliquez sur l'icône de l'application Roblox pour démarrer l'installation.";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacChromeThirdInstruction"
	/// Click {startBold}Open{endBold} when prompted by your computer.
	/// English String: "Click {startBold}Open{endBold} when prompted by your computer."
	/// </summary>
	public override string ResponseDialogMacChromeThirdInstruction(string startBold, string endBold)
	{
		return $"Cliquez sur {startBold}Ouvrir{endBold} lorsque l'invite s'affiche à l'écran.";
	}

	protected override string _GetTemplateForResponseDialogMacChromeThirdInstruction()
	{
		return "Cliquez sur {startBold}Ouvrir{endBold} lorsque l'invite s'affiche à l'écran.";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacFirefoxFifthInstruction"
	/// Then select the Remember my choice... checkbox and click OK
	/// English String: "Then select the {startBold}Remember my choice...{endBold} checkbox and click {startBold2}OK{endBold2}"
	/// </summary>
	public override string ResponseDialogMacFirefoxFifthInstruction(string startBold, string endBold, string startBold2, string endBold2)
	{
		return $"Cochez ensuite la case {startBold}Se souvenir de mon choix...{endBold} et cliquez sur {startBold2}OK{endBold2}.";
	}

	protected override string _GetTemplateForResponseDialogMacFirefoxFifthInstruction()
	{
		return "Cochez ensuite la case {startBold}Se souvenir de mon choix...{endBold} et cliquez sur {startBold2}OK{endBold2}.";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacFirefoxFirstInstruction"
	/// Select Open with and click OK
	/// English String: "Select {startBold}Open with{endBold} and click {startBold2}OK{endBold2}"
	/// </summary>
	public override string ResponseDialogMacFirefoxFirstInstruction(string startBold, string endBold, string startBold2, string endBold2)
	{
		return $"Sélectionnez {startBold}Ouvrir avec{endBold} et cliquez sur {startBold2}OK{endBold2}.";
	}

	protected override string _GetTemplateForResponseDialogMacFirefoxFirstInstruction()
	{
		return "Sélectionnez {startBold}Ouvrir avec{endBold} et cliquez sur {startBold2}OK{endBold2}.";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacFirefoxFourthInstruction"
	/// Once installed, click Play to join the action!
	/// English String: "Once installed, click {startBold}Play{endBold} to join the action!"
	/// </summary>
	public override string ResponseDialogMacFirefoxFourthInstruction(string startBold, string endBold)
	{
		return $"Une fois l'installation terminée, cliquez sur {startBold}Jouer{endBold} pour plonger dans l'action\u00a0!";
	}

	protected override string _GetTemplateForResponseDialogMacFirefoxFourthInstruction()
	{
		return "Une fois l'installation terminée, cliquez sur {startBold}Jouer{endBold} pour plonger dans l'action\u00a0!";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacFirefoxSecondInstruction"
	/// Double-click the Roblox Icon to begin the installation process
	/// English String: "Double-click the {startBold}Roblox Icon{endBold} to begin the installation process"
	/// </summary>
	public override string ResponseDialogMacFirefoxSecondInstruction(string startBold, string endBold)
	{
		return $"Double-cliquez sur {startBold}l'icône Roblox{endBold} pour démarrer l'installation.";
	}

	protected override string _GetTemplateForResponseDialogMacFirefoxSecondInstruction()
	{
		return "Double-cliquez sur {startBold}l'icône Roblox{endBold} pour démarrer l'installation.";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacFirefoxThirdInstruction"
	/// You will receive a warning, click Open
	/// English String: "You will receive a warning, click {startBold}Open{endBold}"
	/// </summary>
	public override string ResponseDialogMacFirefoxThirdInstruction(string startBold, string endBold)
	{
		return $"Un avertissement s'affiche\u00a0; cliquez sur {startBold}Ouvrir{endBold}.";
	}

	protected override string _GetTemplateForResponseDialogMacFirefoxThirdInstruction()
	{
		return "Un avertissement s'affiche\u00a0; cliquez sur {startBold}Ouvrir{endBold}.";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacSafariFirstInstruction"
	/// Go to Downloads and double-click Roblox.dmg
	/// English String: "Go to Downloads and double-click {startBold}Roblox.dmg{endBold}"
	/// </summary>
	public override string ResponseDialogMacSafariFirstInstruction(string startBold, string endBold)
	{
		return $"Ouvrez le dossier Téléchargements et double-cliquez sur {startBold}Roblox.dmg{endBold}.";
	}

	protected override string _GetTemplateForResponseDialogMacSafariFirstInstruction()
	{
		return "Ouvrez le dossier Téléchargements et double-cliquez sur {startBold}Roblox.dmg{endBold}.";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacSafariFourthInstruction"
	/// Once installed, click {startBold}Play{endBold} to join the action!
	/// English String: "Once installed, click {startBold}Play{endBold} to join the action!"
	/// </summary>
	public override string ResponseDialogMacSafariFourthInstruction(string startBold, string endBold)
	{
		return $"Une fois l'installation terminée, cliquez sur {startBold}Jouer{endBold} pour plonger dans l'action\u00a0!";
	}

	protected override string _GetTemplateForResponseDialogMacSafariFourthInstruction()
	{
		return "Une fois l'installation terminée, cliquez sur {startBold}Jouer{endBold} pour plonger dans l'action\u00a0!";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacSafariSecondInstruction"
	/// Double-click the {startBold}Roblox Icon{endBold} to begin the installation process
	/// English String: "Double-click the {startBold}Roblox Icon{endBold} to begin the installation process"
	/// </summary>
	public override string ResponseDialogMacSafariSecondInstruction(string startBold, string endBold)
	{
		return $"Double-cliquez sur {startBold}l'icône Roblox{endBold} pour démarrer l'installation.";
	}

	protected override string _GetTemplateForResponseDialogMacSafariSecondInstruction()
	{
		return "Double-cliquez sur {startBold}l'icône Roblox{endBold} pour démarrer l'installation.";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacSafariThirdInstruction"
	/// You will receive a warning, click {startBold}Open{endBold}
	/// English String: "You will receive a warning, click {startBold}Open{endBold}"
	/// </summary>
	public override string ResponseDialogMacSafariThirdInstruction(string startBold, string endBold)
	{
		return $"Un avertissement s'affiche\u00a0; cliquez sur {startBold}Ouvrir{endBold}.";
	}

	protected override string _GetTemplateForResponseDialogMacSafariThirdInstruction()
	{
		return "Un avertissement s'affiche\u00a0; cliquez sur {startBold}Ouvrir{endBold}.";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcChromeFirstInstruction"
	/// Click {startBold}RobloxPlayer.exe{endBold} to run the Roblox installer, which just downloaded via your web browser.
	/// English String: "Click {startBold}RobloxPlayer.exe{endBold} to run the Roblox installer, which just downloaded via your web browser."
	/// </summary>
	public override string ResponseDialogPcChromeFirstInstruction(string startBold, string endBold)
	{
		return $"Cliquez sur {startBold}RobloxPlayer.exe{endBold} pour exécuter l'utilitaire d'installation de Roblox que vous venez de télécharger.";
	}

	protected override string _GetTemplateForResponseDialogPcChromeFirstInstruction()
	{
		return "Cliquez sur {startBold}RobloxPlayer.exe{endBold} pour exécuter l'utilitaire d'installation de Roblox que vous venez de télécharger.";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcChromeFourthInstruction"
	/// After installation, click {startBold}Play{endBold} below to join the action!
	/// English String: "After installation, click {startBold}Play{endBold} below to join the action!"
	/// </summary>
	public override string ResponseDialogPcChromeFourthInstruction(string startBold, string endBold)
	{
		return $"Une fois l'installation terminée, cliquez sur {startBold}Jouer{endBold} ci-dessous pour plonger dans l'action\u00a0!";
	}

	protected override string _GetTemplateForResponseDialogPcChromeFourthInstruction()
	{
		return "Une fois l'installation terminée, cliquez sur {startBold}Jouer{endBold} ci-dessous pour plonger dans l'action\u00a0!";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcChromeSecondInstruction"
	/// Click {startBold}Run{endBold} when prompted by your computer to begin the installation process.
	/// English String: "Click {startBold}Run{endBold} when prompted by your computer to begin the installation process."
	/// </summary>
	public override string ResponseDialogPcChromeSecondInstruction(string startBold, string endBold)
	{
		return $"Cliquez sur {startBold}Ouvrir{endBold} lorsque l'invite s'affiche à l'écran afin de lancer l'installation.";
	}

	protected override string _GetTemplateForResponseDialogPcChromeSecondInstruction()
	{
		return "Cliquez sur {startBold}Ouvrir{endBold} lorsque l'invite s'affiche à l'écran afin de lancer l'installation.";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcChromeThirdInstruction"
	/// Click {startBold}Ok{endBold} once you've successfully installed Roblox.
	/// English String: "Click {startBold}Ok{endBold} once you've successfully installed Roblox."
	/// </summary>
	public override string ResponseDialogPcChromeThirdInstruction(string startBold, string endBold)
	{
		return $"Cliquez sur {startBold}OK{endBold} une fois l'installation de Roblox terminée.";
	}

	protected override string _GetTemplateForResponseDialogPcChromeThirdInstruction()
	{
		return "Cliquez sur {startBold}OK{endBold} une fois l'installation de Roblox terminée.";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcEdgeFirstInstruction"
	/// Click {startBold}Run{endBold} to install Roblox after the download finishes
	/// English String: "Click {startBold}Run{endBold} to install Roblox after the download finishes"
	/// </summary>
	public override string ResponseDialogPcEdgeFirstInstruction(string startBold, string endBold)
	{
		return $"Cliquez sur {startBold}Ouvrir{endBold} pour installer Roblox une fois le téléchargement terminé.";
	}

	protected override string _GetTemplateForResponseDialogPcEdgeFirstInstruction()
	{
		return "Cliquez sur {startBold}Ouvrir{endBold} pour installer Roblox une fois le téléchargement terminé.";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcEdgeSecondInstruction"
	/// Click {startBold}Ok{endBold} to finish installing Roblox
	/// English String: "Click {startBold}Ok{endBold} to finish installing Roblox"
	/// </summary>
	public override string ResponseDialogPcEdgeSecondInstruction(string startBold, string endBold)
	{
		return $"Cliquez sur {startBold}OK{endBold} pour terminer l'installation de Roblox.";
	}

	protected override string _GetTemplateForResponseDialogPcEdgeSecondInstruction()
	{
		return "Cliquez sur {startBold}OK{endBold} pour terminer l'installation de Roblox.";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcEdgeThirdInstruction"
	/// Click the {startBold}Play{endBold} button to join the action!
	/// English String: "Click the {startBold}Play{endBold} button to join the action!"
	/// </summary>
	public override string ResponseDialogPcEdgeThirdInstruction(string startBold, string endBold)
	{
		return $"Cliquez sur {startBold}Jouer{endBold} pour plonger dans l'action\u00a0!";
	}

	protected override string _GetTemplateForResponseDialogPcEdgeThirdInstruction()
	{
		return "Cliquez sur {startBold}Jouer{endBold} pour plonger dans l'action\u00a0!";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcFirefoxFifthInstruction"
	/// Click {startBold}Ok{endBold} when the alert pops up
	/// English String: "Click {startBold}Ok{endBold} when the alert pops up"
	/// </summary>
	public override string ResponseDialogPcFirefoxFifthInstruction(string startBold, string endBold)
	{
		return $"Cliquez sur {startBold}OK{endBold} lorsque l'avertissement apparaît.";
	}

	protected override string _GetTemplateForResponseDialogPcFirefoxFifthInstruction()
	{
		return "Cliquez sur {startBold}OK{endBold} lorsque l'avertissement apparaît.";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcFirefoxFirstInstruction"
	/// Click {startBold}Save File{endBold} when the download window pops up
	/// English String: "Click {startBold}Save File{endBold} when the download window pops up"
	/// </summary>
	public override string ResponseDialogPcFirefoxFirstInstruction(string startBold, string endBold)
	{
		return $"Cliquez sur {startBold}Enregistrer le fichier{endBold} lorsque la fenêtre de téléchargement apparaît.";
	}

	protected override string _GetTemplateForResponseDialogPcFirefoxFirstInstruction()
	{
		return "Cliquez sur {startBold}Enregistrer le fichier{endBold} lorsque la fenêtre de téléchargement apparaît.";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcFirefoxFourthInstruction"
	/// Once installed, click {startBold}Play{endBold} to join the action!
	/// English String: "Once installed, click {startBold}Play{endBold} to join the action!"
	/// </summary>
	public override string ResponseDialogPcFirefoxFourthInstruction(string startBold, string endBold)
	{
		return $"Une fois l'installation terminée, cliquez sur {startBold}Jouer{endBold} pour plonger dans l'action\u00a0!";
	}

	protected override string _GetTemplateForResponseDialogPcFirefoxFourthInstruction()
	{
		return "Une fois l'installation terminée, cliquez sur {startBold}Jouer{endBold} pour plonger dans l'action\u00a0!";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcFirefoxSecondInstruction"
	/// Go to Downloads and double click {startBold}RobloxPlayer.exe{endBold}
	/// English String: "Go to Downloads and double click {startBold}RobloxPlayer.exe{endBold}"
	/// </summary>
	public override string ResponseDialogPcFirefoxSecondInstruction(string startBold, string endBold)
	{
		return $"Ouvrez le dossier Téléchargements et double-cliquez sur {startBold}RobloxPlayer.exe{endBold}.";
	}

	protected override string _GetTemplateForResponseDialogPcFirefoxSecondInstruction()
	{
		return "Ouvrez le dossier Téléchargements et double-cliquez sur {startBold}RobloxPlayer.exe{endBold}.";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcFirefoxThirdInstruction"
	/// Click {startBold}Run{endBold}
	/// English String: "Click {startBold}Run{endBold}"
	/// </summary>
	public override string ResponseDialogPcFirefoxThirdInstruction(string startBold, string endBold)
	{
		return $"Cliquez sur {startBold}Ouvrir{endBold}.";
	}

	protected override string _GetTemplateForResponseDialogPcFirefoxThirdInstruction()
	{
		return "Cliquez sur {startBold}Ouvrir{endBold}.";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcIEFirstInstruction"
	/// You will receive a warning, click {startBold}Run{endBold}
	/// English String: "You will receive a warning, click {startBold}Run{endBold}"
	/// </summary>
	public override string ResponseDialogPcIEFirstInstruction(string startBold, string endBold)
	{
		return $"Un avertissement s'affiche\u00a0; cliquez sur {startBold}Ouvrir{endBold}.";
	}

	protected override string _GetTemplateForResponseDialogPcIEFirstInstruction()
	{
		return "Un avertissement s'affiche\u00a0; cliquez sur {startBold}Ouvrir{endBold}.";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcIeInstructionOne"
	/// You will receive a warning, click {startBold}Run{endBold}
	/// English String: "You will receive a warning, click {startBold}Run{endBold}"
	/// </summary>
	public override string ResponseDialogPcIeInstructionOne(string startBold, string endBold)
	{
		return $"Un avertissement s'affiche\u00a0; cliquez sur {startBold}Ouvrir{endBold}.";
	}

	protected override string _GetTemplateForResponseDialogPcIeInstructionOne()
	{
		return "Un avertissement s'affiche\u00a0; cliquez sur {startBold}Ouvrir{endBold}.";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcIeInstructionThree"
	/// Click {startBold}Run{endBold}
	/// English String: "Click {startBold}Run{endBold}"
	/// </summary>
	public override string ResponseDialogPcIeInstructionThree(string startBold, string endBold)
	{
		return $"Cliquez sur {startBold}Ouvrir{endBold}.";
	}

	protected override string _GetTemplateForResponseDialogPcIeInstructionThree()
	{
		return "Cliquez sur {startBold}Ouvrir{endBold}.";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcIeInstructionTwo"
	/// Go to Downloads and double click {startBold}RobloxPlayer.exe{endBold}
	/// English String: "Go to Downloads and double click {startBold}RobloxPlayer.exe{endBold}"
	/// </summary>
	public override string ResponseDialogPcIeInstructionTwo(string startBold, string endBold)
	{
		return $"Ouvrez le dossier Téléchargements et double-cliquez sur {startBold}RobloxPlayer.exe{endBold}.";
	}

	protected override string _GetTemplateForResponseDialogPcIeInstructionTwo()
	{
		return "Ouvrez le dossier Téléchargements et double-cliquez sur {startBold}RobloxPlayer.exe{endBold}.";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcIESecondInstruction"
	/// Click {startBold}Ok{endBold} once you've installed Roblox
	/// English String: "Click {startBold}Ok{endBold} once you've installed Roblox"
	/// </summary>
	public override string ResponseDialogPcIESecondInstruction(string startBold, string endBold)
	{
		return $"Cliquez sur {startBold}OK{endBold} une fois l'installation de Roblox terminée.";
	}

	protected override string _GetTemplateForResponseDialogPcIESecondInstruction()
	{
		return "Cliquez sur {startBold}OK{endBold} une fois l'installation de Roblox terminée.";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcIEThirdInstruction"
	/// Once installed, click {startBold}Play{endBold} to join the action!
	/// English String: "Once installed, click {startBold}Play{endBold} to join the action!"
	/// </summary>
	public override string ResponseDialogPcIEThirdInstruction(string startBold, string endBold)
	{
		return $"Une fois l'installation terminée, cliquez sur {startBold}Jouer{endBold} pour plonger dans l'action\u00a0!";
	}

	protected override string _GetTemplateForResponseDialogPcIEThirdInstruction()
	{
		return "Une fois l'installation terminée, cliquez sur {startBold}Jouer{endBold} pour plonger dans l'action\u00a0!";
	}

	protected override string _GetTemplateForResponseDialogThanksForPlayingRoblox()
	{
		return "Merci de jouer à Roblox";
	}

	protected override string _GetTemplateForResponseGameTemporarilyUnavailable()
	{
		return "Impossible de vérifier que vous avez l'autorisation d'accéder à ce jeu. Veuillez réessayer plus tard.";
	}

	/// <summary>
	/// Key: "Response.RememberMyChoiceAppLaunch"
	/// Check {startBold}Remember my choice{endBold} and click {appLaunchLink} in the dialog box above to join games faster in the future!
	/// English String: "Check {startBold}Remember my choice{endBold} and click {appLaunchLink} in the dialog box above to join games faster in the future!"
	/// </summary>
	public override string ResponseRememberMyChoiceAppLaunch(string startBold, string endBold, string appLaunchLink)
	{
		return $"Cochez {startBold}Se rappeler de mon choix{endBold} et cliquez sur {appLaunchLink} dans la boîte de dialogue ci-dessus afin de rejoindre des jeux plus rapidement à l'avenir\u00a0!";
	}

	protected override string _GetTemplateForResponseRememberMyChoiceAppLaunch()
	{
		return "Cochez {startBold}Se rappeler de mon choix{endBold} et cliquez sur {appLaunchLink} dans la boîte de dialogue ci-dessus afin de rejoindre des jeux plus rapidement à l'avenir\u00a0!";
	}
}
