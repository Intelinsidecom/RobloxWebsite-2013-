namespace Roblox.TranslationResources.Common;

/// <summary>
/// This class overrides VisitGameResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class VisitGameResources_es_es : VisitGameResources_en_us, IVisitGameResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Retry"
	/// button label
	/// English String: "Retry"
	/// </summary>
	public override string ActionRetry => "Reintentar";

	/// <summary>
	/// Key: "Heading.ErrorStartingGame"
	/// Error starting game
	/// English String: "Error starting game"
	/// </summary>
	public override string HeadingErrorStartingGame => "Error al iniciar el juego";

	/// <summary>
	/// Key: "Heading.SwitchToDesktopToPlay"
	/// Switch to Desktop Mode to Play Games
	/// English String: "Switch to Desktop Mode to Play Games"
	/// </summary>
	public override string HeadingSwitchToDesktopToPlay => "Cambiar a modo de escritorio para jugar";

	/// <summary>
	/// Key: "Label.Cancel"
	/// Cancel
	/// English String: "Cancel"
	/// </summary>
	public override string LabelCancel => "Cancelar";

	/// <summary>
	/// Key: "Label.CheckingForStudio"
	/// We are checking if user has Roblox Studio installed
	/// English String: "Checking for Roblox Studio..."
	/// </summary>
	public override string LabelCheckingForStudio => "Comprobando Roblox Studio...";

	/// <summary>
	/// Key: "Label.ClickHereForHelp"
	/// Click here for help
	/// English String: "Click here for help"
	/// </summary>
	public override string LabelClickHereForHelp => "Haz clic aquí para obtener ayuda.";

	/// <summary>
	/// Key: "Label.ConnectingToPlayers"
	/// Joining a game network with other players
	/// English String: "Connecting to Players..."
	/// </summary>
	public override string LabelConnectingToPlayers => "Conectando con los jugadores...";

	/// <summary>
	/// Key: "Label.DevelopPageTitle"
	/// English String: "Develop"
	/// </summary>
	public override string LabelDevelopPageTitle => "Desarrolla";

	/// <summary>
	/// Key: "Label.DownloadInstallRoblox"
	/// Download and Install Roblox
	/// English String: "Download and Install Roblox"
	/// </summary>
	public override string LabelDownloadInstallRoblox => "Descargar e instalar Roblox";

	/// <summary>
	/// Key: "Label.DownloadStudio"
	/// Download Roblox Studio to start creating games
	/// English String: "Download Studio"
	/// </summary>
	public override string LabelDownloadStudio => "Descargar Studio";

	/// <summary>
	/// Key: "Label.GameConfigurePageTitle"
	/// English String: "Game Configure"
	/// </summary>
	public override string LabelGameConfigurePageTitle => "Configura el juego";

	/// <summary>
	/// Key: "Label.GameFreeSoothsayer"
	/// English String: "Free because you are a soothsayer"
	/// </summary>
	public override string LabelGameFreeSoothsayer => "Gratis porque eres un augur";

	/// <summary>
	/// Key: "Label.GameUnavailableAccountResrictions"
	/// English String: "The game is unavailable due to account restrictions settings."
	/// </summary>
	public override string LabelGameUnavailableAccountResrictions => "El juego no está disponible a causa de la configuración de las restricciones de la cuenta.";

	/// <summary>
	/// Key: "Label.GameUnavailableCannotPlayGamesStudio"
	/// English String: "You cannot play games from Studio. Please use a web browser to play this game."
	/// </summary>
	public override string LabelGameUnavailableCannotPlayGamesStudio => "No se puede jugar desde Studio. Usa un navegador para jugar a este juego.";

	/// <summary>
	/// Key: "Label.GameUnavailableClosedToVisitors"
	/// English String: "Sorry, this place is currently closed to visitors."
	/// </summary>
	public override string LabelGameUnavailableClosedToVisitors => "Lo sentimos, este lugar está cerrado para visitantes en este momento.";

	/// <summary>
	/// Key: "Label.GameUnavailableCurrentlyIsPrivateVisitor"
	/// When a game is private, this message is shown to visitors.
	/// English String: "Sorry, this game is private."
	/// </summary>
	public override string LabelGameUnavailableCurrentlyIsPrivateVisitor => "Lo sentimos, este juego es privado.";

	/// <summary>
	/// Key: "Label.GameUnavailableGameInsecure"
	/// U13 users cannot play insecure games unless they are the creator or friends with the creator.
	/// English String: "Sorry, your account is restricted from playing Experimental Games unless you are friends with the creator."
	/// </summary>
	public override string LabelGameUnavailableGameInsecure => "Lo sentimos, tu cuenta está restringida a juegos experimentales a menos que seas amigo del creador.";

	/// <summary>
	/// Key: "Label.GameUnavailablePermissionLevels"
	/// English String: "The permission levels on this place prevent you from entering."
	/// </summary>
	public override string LabelGameUnavailablePermissionLevels => "Los niveles de permisos de este lugar te impiden la entrada.";

	/// <summary>
	/// Key: "Label.GameUnavailablePlaceUnderReview"
	/// English String: "Sorry, this place is currently under review. Try again later."
	/// </summary>
	public override string LabelGameUnavailablePlaceUnderReview => "Lo sentimos, este lugar está siendo analizado. Inténtalo de nuevo más tarde.";

	/// <summary>
	/// Key: "Label.GameUnavailablePlatform"
	/// English String: "This game is not available on your platform.  Check the games page to see all playable games."
	/// </summary>
	public override string LabelGameUnavailablePlatform => "Este juego no está disponible en tu plataforma. Echa un vistazo a la página de juegos para ver todos los juegos jugables.";

	/// <summary>
	/// Key: "Label.GameWarning"
	/// English String: "Warning"
	/// </summary>
	public override string LabelGameWarning => "Advertencia";

	/// <summary>
	/// Key: "Label.InstallationInstructions"
	/// Installation Instructions
	/// English String: "Installation Instructions"
	/// </summary>
	public override string LabelInstallationInstructions => "Instrucciones de instalación";

	/// <summary>
	/// Key: "Label.LaunchApplication"
	/// Launch Application
	/// English String: "Launch Application"
	/// </summary>
	public override string LabelLaunchApplication => "Iniciar aplicación";

	/// <summary>
	/// Key: "Label.PersuadeToDevelopRoblox"
	/// Persuade user to begin developing their own games using Roblox Studio
	/// English String: "Get started creating your own games!"
	/// </summary>
	public override string LabelPersuadeToDevelopRoblox => "¡Empieza a crear tus propios juegos!";

	/// <summary>
	/// Key: "Label.PersuadeToInstallRoblox"
	/// We are exciting the user about Roblox so that they will be persuaded to download and install it.
	/// English String: "You're moments away from getting into the game!"
	/// </summary>
	public override string LabelPersuadeToInstallRoblox => "¡Estás a punto de entrar al juego!";

	/// <summary>
	/// Key: "Label.Play"
	/// English String: "Play"
	/// </summary>
	public override string LabelPlay => "Jugar";

	/// <summary>
	/// Key: "Label.PlayInApp"
	/// English String: "Play in App"
	/// </summary>
	public override string LabelPlayInApp => "Jugar en la aplicación";

	/// <summary>
	/// Key: "Label.RobloxLoadingToPlay"
	/// Roblox is loading, so the user is getting excited to start playing a game
	/// English String: "Roblox is now loading. Get ready to play!"
	/// </summary>
	public override string LabelRobloxLoadingToPlay => "Roblox se está cargando. ¡Prepárate para jugar!";

	/// <summary>
	/// Key: "Label.StartingRoblox"
	/// Game launch process has started
	/// English String: "Starting Roblox..."
	/// </summary>
	public override string LabelStartingRoblox => "Inicializando Roblox...";

	/// <summary>
	/// Key: "Label.SwitchToDesktopMode"
	/// Switch to Desktop Mode
	/// English String: "Switch to Desktop Mode"
	/// </summary>
	public override string LabelSwitchToDesktopMode => "Cambiar a modo de escritorio";

	/// <summary>
	/// Key: "Label.UniverseConfigurePageTitle"
	/// The name of the universe configuration page
	/// English String: "Universe Configuration"
	/// </summary>
	public override string LabelUniverseConfigurePageTitle => "Configuración del universo";

	/// <summary>
	/// Key: "Response.Dialog.ClickHere"
	/// Click here!
	/// English String: "Click here!"
	/// </summary>
	public override string ResponseDialogClickHere => "¡Haz clic aquí!";

	/// <summary>
	/// Key: "Response.Dialog.ErrorLaunching"
	/// An error occurred trying to launch the game.  Please try again later.
	/// English String: "An error occurred trying to launch the game.  Please try again later."
	/// </summary>
	public override string ResponseDialogErrorLaunching => "Se ha producido un error al iniciar el juego. Inténtalo de nuevo más tarde.";

	/// <summary>
	/// Key: "Response.Dialog.HavingTroubleInstallQuestion"
	/// (Are you) having trouble installing Roblox?
	/// English String: "Having trouble installing Roblox?"
	/// </summary>
	public override string ResponseDialogHavingTroubleInstallQuestion => "¿Tienes problemas para instalar Roblox?";

	/// <summary>
	/// Key: "Response.Dialog.MacChromeSecondInstruction"
	/// Double-click the Roblox app icon to begin the installation process.
	/// English String: "Double-click the Roblox app icon to begin the installation process."
	/// </summary>
	public override string ResponseDialogMacChromeSecondInstruction => "Haz doble clic en el icono de la aplicación de Roblox para iniciar el proceso de instalación.";

	/// <summary>
	/// Key: "Response.Dialog.ThanksForPlayingRoblox"
	/// Thanks for playing Roblox
	/// English String: "Thanks for playing Roblox"
	/// </summary>
	public override string ResponseDialogThanksForPlayingRoblox => "Gracias por jugar a Roblox";

	/// <summary>
	/// Key: "Response.GameTemporarilyUnavailable"
	/// error message (will be followed by link with Action.Retry label)
	/// English String: "Unable to verify that you have access to this game.  Please try again later."
	/// </summary>
	public override string ResponseGameTemporarilyUnavailable => "No se ha podido comprobar que tienes acceso a este juego. Inténtalo de nuevo más tarde.";

	public VisitGameResources_es_es(TranslationResourceState state)
		: base(state)
	{
	}

	/// <summary>
	/// Key: "Action.GamePerformPoorly"
	/// English String: "{warning} This game may perform poorly on your device."
	/// </summary>
	public override string ActionGamePerformPoorly(string warning)
	{
		return $"{warning} Este juego puede tener un rendimiento pobre en tu dispositivo.";
	}

	protected override string _GetTemplateForActionGamePerformPoorly()
	{
		return "{warning} Este juego puede tener un rendimiento pobre en tu dispositivo.";
	}

	protected override string _GetTemplateForActionRetry()
	{
		return "Reintentar";
	}

	protected override string _GetTemplateForHeadingErrorStartingGame()
	{
		return "Error al iniciar el juego";
	}

	protected override string _GetTemplateForHeadingSwitchToDesktopToPlay()
	{
		return "Cambiar a modo de escritorio para jugar";
	}

	/// <summary>
	/// Key: "Label.BuyAccess"
	/// English String: "Buy Access for {robux} Robux"
	/// </summary>
	public override string LabelBuyAccess(string robux)
	{
		return $"Acceder por {robux} Robux";
	}

	protected override string _GetTemplateForLabelBuyAccess()
	{
		return "Acceder por {robux} Robux";
	}

	protected override string _GetTemplateForLabelCancel()
	{
		return "Cancelar";
	}

	protected override string _GetTemplateForLabelCheckingForStudio()
	{
		return "Comprobando Roblox Studio...";
	}

	protected override string _GetTemplateForLabelClickHereForHelp()
	{
		return "Haz clic aquí para obtener ayuda.";
	}

	protected override string _GetTemplateForLabelConnectingToPlayers()
	{
		return "Conectando con los jugadores...";
	}

	protected override string _GetTemplateForLabelDevelopPageTitle()
	{
		return "Desarrolla";
	}

	protected override string _GetTemplateForLabelDownloadInstallRoblox()
	{
		return "Descargar e instalar Roblox";
	}

	protected override string _GetTemplateForLabelDownloadStudio()
	{
		return "Descargar Studio";
	}

	protected override string _GetTemplateForLabelGameConfigurePageTitle()
	{
		return "Configura el juego";
	}

	protected override string _GetTemplateForLabelGameFreeSoothsayer()
	{
		return "Gratis porque eres un augur";
	}

	/// <summary>
	/// Key: "Label.GameIsPrivatePlayableByGroupOnly"
	/// When a game is private, this message is shown to group developers with a link from where it can be made public.
	/// English String: "Only developers can play because this game is private. Make it public on the {linkStart}Configure Game{linkEnd} page."
	/// </summary>
	public override string LabelGameIsPrivatePlayableByGroupOnly(string linkStart, string linkEnd)
	{
		return $"Solo los desarrolladores pueden jugar a este juego porque es privado. Hazlo público en la página {linkStart}Configuración del juego{linkEnd}.";
	}

	protected override string _GetTemplateForLabelGameIsPrivatePlayableByGroupOnly()
	{
		return "Solo los desarrolladores pueden jugar a este juego porque es privado. Hazlo público en la página {linkStart}Configuración del juego{linkEnd}.";
	}

	/// <summary>
	/// Key: "Label.GameIsPrivatePlayableByOwnerOnly"
	/// When a game is private, this message is shown to owner with a link from where it can be made public.
	/// English String: "Only you can play because this game is private. Make it public on the {linkStart}Configure Game{linkEnd} page."
	/// </summary>
	public override string LabelGameIsPrivatePlayableByOwnerOnly(string linkStart, string linkEnd)
	{
		return $"Solo tú puedes jugar a este juego porque es privado. Hazlo público en la página {linkStart}Configuración del juego{linkEnd}.";
	}

	protected override string _GetTemplateForLabelGameIsPrivatePlayableByOwnerOnly()
	{
		return "Solo tú puedes jugar a este juego porque es privado. Hazlo público en la página {linkStart}Configuración del juego{linkEnd}.";
	}

	protected override string _GetTemplateForLabelGameUnavailableAccountResrictions()
	{
		return "El juego no está disponible a causa de la configuración de las restricciones de la cuenta.";
	}

	protected override string _GetTemplateForLabelGameUnavailableCannotPlayGamesStudio()
	{
		return "No se puede jugar desde Studio. Usa un navegador para jugar a este juego.";
	}

	protected override string _GetTemplateForLabelGameUnavailableClosedToVisitors()
	{
		return "Lo sentimos, este lugar está cerrado para visitantes en este momento.";
	}

	/// <summary>
	/// Key: "Label.GameUnavailableCurrentlyIsPrivateGroup"
	/// When a game is private, this message is shown to group developers with a link from where it can be made public. Similar to an existing translation. Change is making the message directly address the group developers.
	/// English String: "Only developers can play because this game is private. Make it public on the {linkStart}Develop{linkEnd} page."
	/// </summary>
	public override string LabelGameUnavailableCurrentlyIsPrivateGroup(string linkStart, string linkEnd)
	{
		return $"Solo los desarrolladores pueden jugar a este juego porque es privado. Hazlo público en la página {linkStart}Crear{linkEnd}.";
	}

	protected override string _GetTemplateForLabelGameUnavailableCurrentlyIsPrivateGroup()
	{
		return "Solo los desarrolladores pueden jugar a este juego porque es privado. Hazlo público en la página {linkStart}Crear{linkEnd}.";
	}

	/// <summary>
	/// Key: "Label.GameUnavailableCurrentlyIsPrivateOwner"
	/// When a game is private, this message is shown to owner with a link from where it can be made public. Similar to an existing translation. Change is making the message directly address the owner.
	/// English String: "Only you can play because this game is private. Make it public on the {linkStart}Develop{linkEnd} page."
	/// </summary>
	public override string LabelGameUnavailableCurrentlyIsPrivateOwner(string linkStart, string linkEnd)
	{
		return $"Solo tú puedes jugar a este juego porque es privado. Hazlo público en la página {linkStart}Crear{linkEnd}.";
	}

	protected override string _GetTemplateForLabelGameUnavailableCurrentlyIsPrivateOwner()
	{
		return "Solo tú puedes jugar a este juego porque es privado. Hazlo público en la página {linkStart}Crear{linkEnd}.";
	}

	protected override string _GetTemplateForLabelGameUnavailableCurrentlyIsPrivateVisitor()
	{
		return "Lo sentimos, este juego es privado.";
	}

	/// <summary>
	/// Key: "Label.GameUnavailableCurrentlyPrivate"
	/// When a game is private, this message is shown to user with link from where it can be made public
	/// English String: "This {gameTypeName} is currently private. Make it public on the {developPageLink} page to make it playable."
	/// </summary>
	public override string LabelGameUnavailableCurrentlyPrivate(string gameTypeName, string developPageLink)
	{
		return $"El juego {gameTypeName} es privado en este momento. Hazlo público en la página {developPageLink} para que sea jugable.";
	}

	protected override string _GetTemplateForLabelGameUnavailableCurrentlyPrivate()
	{
		return "El juego {gameTypeName} es privado en este momento. Hazlo público en la página {developPageLink} para que sea jugable.";
	}

	protected override string _GetTemplateForLabelGameUnavailableGameInsecure()
	{
		return "Lo sentimos, tu cuenta está restringida a juegos experimentales a menos que seas amigo del creador.";
	}

	/// <summary>
	/// Key: "Label.GameUnavailableNoRootPlace"
	/// English String: "This place is part of a game that has no root place. Add a root place on the {gameConfigureLink} page to make it playable."
	/// </summary>
	public override string LabelGameUnavailableNoRootPlace(string gameConfigureLink)
	{
		return $"Este lugar es parte de un juego que no tiene lugar raíz. Añade un lugar raíz en la página {gameConfigureLink} para hacerlo jugable.";
	}

	protected override string _GetTemplateForLabelGameUnavailableNoRootPlace()
	{
		return "Este lugar es parte de un juego que no tiene lugar raíz. Añade un lugar raíz en la página {gameConfigureLink} para hacerlo jugable.";
	}

	protected override string _GetTemplateForLabelGameUnavailablePermissionLevels()
	{
		return "Los niveles de permisos de este lugar te impiden la entrada.";
	}

	/// <summary>
	/// Key: "Label.GameUnavailablePlaceNotPartOfGame"
	/// English String: "This place is not currently part of a Game. Add it to a game on the {developPageLink} page to make it playable."
	/// </summary>
	public override string LabelGameUnavailablePlaceNotPartOfGame(string developPageLink)
	{
		return $"Este lugar no es parte de un juego en este momento. Añádelo a un juego en la página {developPageLink} para hacerlo jugable.";
	}

	protected override string _GetTemplateForLabelGameUnavailablePlaceNotPartOfGame()
	{
		return "Este lugar no es parte de un juego en este momento. Añádelo a un juego en la página {developPageLink} para hacerlo jugable.";
	}

	protected override string _GetTemplateForLabelGameUnavailablePlaceUnderReview()
	{
		return "Lo sentimos, este lugar está siendo analizado. Inténtalo de nuevo más tarde.";
	}

	protected override string _GetTemplateForLabelGameUnavailablePlatform()
	{
		return "Este juego no está disponible en tu plataforma. Echa un vistazo a la página de juegos para ver todos los juegos jugables.";
	}

	protected override string _GetTemplateForLabelGameWarning()
	{
		return "Advertencia";
	}

	protected override string _GetTemplateForLabelInstallationInstructions()
	{
		return "Instrucciones de instalación";
	}

	protected override string _GetTemplateForLabelLaunchApplication()
	{
		return "Iniciar aplicación";
	}

	/// <summary>
	/// Key: "Label.OperaInstallSteps"
	/// 1) A window will open. Click Open2) Doubleclick the Roblox icon.
	/// English String: "1) A window will open. Click {startBold}Open{endBold}.{breakLine}2) Doubleclick the Roblox icon."
	/// </summary>
	public override string LabelOperaInstallSteps(string startBold, string endBold, string breakLine)
	{
		return $"1) Se abrirá una ventana. Haz clic en {startBold}Abrir{endBold}.{breakLine}2) Haz doble clic en el icono de Roblox.";
	}

	protected override string _GetTemplateForLabelOperaInstallSteps()
	{
		return "1) Se abrirá una ventana. Haz clic en {startBold}Abrir{endBold}.{breakLine}2) Haz doble clic en el icono de Roblox.";
	}

	protected override string _GetTemplateForLabelPersuadeToDevelopRoblox()
	{
		return "¡Empieza a crear tus propios juegos!";
	}

	protected override string _GetTemplateForLabelPersuadeToInstallRoblox()
	{
		return "¡Estás a punto de entrar al juego!";
	}

	protected override string _GetTemplateForLabelPlay()
	{
		return "Jugar";
	}

	protected override string _GetTemplateForLabelPlayInApp()
	{
		return "Jugar en la aplicación";
	}

	protected override string _GetTemplateForLabelRobloxLoadingToPlay()
	{
		return "Roblox se está cargando. ¡Prepárate para jugar!";
	}

	protected override string _GetTemplateForLabelStartingRoblox()
	{
		return "Inicializando Roblox...";
	}

	protected override string _GetTemplateForLabelSwitchToDesktopMode()
	{
		return "Cambiar a modo de escritorio";
	}

	protected override string _GetTemplateForLabelUniverseConfigurePageTitle()
	{
		return "Configuración del universo";
	}

	/// <summary>
	/// Key: "Response.CheckAlwaysOpenRoblox"
	/// Check {startBold}Always open links for Roblox{endBold} and click {startBold2}Open Roblox{endBold2} in the dialog box above to join games faster in the future!
	/// English String: "Check {startBold}Always open links for Roblox{endBold} and click {startBold2}Open Roblox{endBold2} in the dialog box above to join games faster in the future!"
	/// </summary>
	public override string ResponseCheckAlwaysOpenRoblox(string startBold, string endBold, string startBold2, string endBold2)
	{
		return $"Activa {startBold}Abrir siempre los enlaces para Roblox{endBold} y haz clic en {startBold2}Abrir Roblox{endBold2} en el cuadro de diálogo de arriba para acceder más rápidamente a los juegos.";
	}

	protected override string _GetTemplateForResponseCheckAlwaysOpenRoblox()
	{
		return "Activa {startBold}Abrir siempre los enlaces para Roblox{endBold} y haz clic en {startBold2}Abrir Roblox{endBold2} en el cuadro de diálogo de arriba para acceder más rápidamente a los juegos.";
	}

	/// <summary>
	/// Key: "Response.CheckAlwaysOpenRobloxURL"
	/// Check {startBold}Always open links for URL: Roblox Protocol{endBold} and click {startBold}Open URL: Roblox Protocol{endBold} in the dialog box above to join games faster in the future!
	/// English String: "Check {startBold}Always open links for URL: Roblox Protocol{endBold} and click {startBold2}Open URL: Roblox Protocol{endBold2} in the dialog box above to join games faster in the future!"
	/// </summary>
	public override string ResponseCheckAlwaysOpenRobloxURL(string startBold, string endBold, string startBold2, string endBold2)
	{
		return $"Activa {startBold}Abrir siempre los enlaces para la URL: Protocolo de Roblox{endBold} y haz clic en {startBold2}Abrir URL: Protocolo de Roblox{endBold2} en el cuadro de diálogo de arriba para acceder más rápidamente a los juegos.";
	}

	protected override string _GetTemplateForResponseCheckAlwaysOpenRobloxURL()
	{
		return "Activa {startBold}Abrir siempre los enlaces para la URL: Protocolo de Roblox{endBold} y haz clic en {startBold2}Abrir URL: Protocolo de Roblox{endBold2} en el cuadro de diálogo de arriba para acceder más rápidamente a los juegos.";
	}

	/// <summary>
	/// Key: "Response.CheckRememberMyChoiceOK"
	/// Check Remember my choice and click OK in the dialog box above to join games faster in the future!
	/// English String: "Check {startBold}Remember my choice{endBold} and click {startBold2}OK{endBold2} in the dialog box above to join games faster in the future!"
	/// </summary>
	public override string ResponseCheckRememberMyChoiceOK(string startBold, string endBold, string startBold2, string endBold2)
	{
		return $"Activa {startBold}Recordar mi opción{endBold} y haz clic en {startBold2}Aceptar{endBold2} en el cuadro de diálogo de arriba para acceder más rápidamente a los juegos.";
	}

	protected override string _GetTemplateForResponseCheckRememberMyChoiceOK()
	{
		return "Activa {startBold}Recordar mi opción{endBold} y haz clic en {startBold2}Aceptar{endBold2} en el cuadro de diálogo de arriba para acceder más rápidamente a los juegos.";
	}

	protected override string _GetTemplateForResponseDialogClickHere()
	{
		return "¡Haz clic aquí!";
	}

	protected override string _GetTemplateForResponseDialogErrorLaunching()
	{
		return "Se ha producido un error al iniciar el juego. Inténtalo de nuevo más tarde.";
	}

	protected override string _GetTemplateForResponseDialogHavingTroubleInstallQuestion()
	{
		return "¿Tienes problemas para instalar Roblox?";
	}

	/// <summary>
	/// Key: "Response.Dialog.InstallingMessageWithLink"
	/// Note: For this translation, please move the linkStart and linkEnd variables with the translation for download now.
	/// English String: "The Roblox installer should download shortly. If it doesn’t, start the {linkStart}download now.{linkEnd}"
	/// </summary>
	public override string ResponseDialogInstallingMessageWithLink(string linkStart, string linkEnd)
	{
		return $"El instalador de Roblox se descargará enseguida. En caso contrario, inicia la {linkStart}descarga ahora.{linkEnd}";
	}

	protected override string _GetTemplateForResponseDialogInstallingMessageWithLink()
	{
		return "El instalador de Roblox se descargará enseguida. En caso contrario, inicia la {linkStart}descarga ahora.{linkEnd}";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacChromeFifthInstruction"
	/// After installation, click {startBold}Play{endBold} below to join the action!
	/// English String: "After installation, click {startBold}Play{endBold} below to join the action!"
	/// </summary>
	public override string ResponseDialogMacChromeFifthInstruction(string startBold, string endBold)
	{
		return $"Una vez finalizada la instalación, haz clic en {startBold}Jugar{endBold} a continuación para unirte a la acción.";
	}

	protected override string _GetTemplateForResponseDialogMacChromeFifthInstruction()
	{
		return "Una vez finalizada la instalación, haz clic en {startBold}Jugar{endBold} a continuación para unirte a la acción.";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacChromeFirstInstruction"
	/// Click {startBold}Roblox.dmg{endBold} to run the Roblox installer, which just downloaded via your web browser.
	/// English String: "Click {startBold}Roblox.dmg{endBold} to run the Roblox installer, which just downloaded via your web browser."
	/// </summary>
	public override string ResponseDialogMacChromeFirstInstruction(string startBold, string endBold)
	{
		return $"Haz clic en {startBold}Roblox.dmg{endBold} para ejecutar el instalador de Roblox recién descargado con tu navegador.";
	}

	protected override string _GetTemplateForResponseDialogMacChromeFirstInstruction()
	{
		return "Haz clic en {startBold}Roblox.dmg{endBold} para ejecutar el instalador de Roblox recién descargado con tu navegador.";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacChromeFourthInstruction"
	/// Click {startBold}Ok{endBold} once you've successfully installed Roblox.
	/// English String: "Click {startBold}Ok{endBold} once you've successfully installed Roblox."
	/// </summary>
	public override string ResponseDialogMacChromeFourthInstruction(string startBold, string endBold)
	{
		return $"Haz clic en {startBold}Aceptar{endBold} una vez que Roblox se haya instalado correctamente.";
	}

	protected override string _GetTemplateForResponseDialogMacChromeFourthInstruction()
	{
		return "Haz clic en {startBold}Aceptar{endBold} una vez que Roblox se haya instalado correctamente.";
	}

	protected override string _GetTemplateForResponseDialogMacChromeSecondInstruction()
	{
		return "Haz doble clic en el icono de la aplicación de Roblox para iniciar el proceso de instalación.";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacChromeThirdInstruction"
	/// Click {startBold}Open{endBold} when prompted by your computer.
	/// English String: "Click {startBold}Open{endBold} when prompted by your computer."
	/// </summary>
	public override string ResponseDialogMacChromeThirdInstruction(string startBold, string endBold)
	{
		return $"Haz clic en {startBold}Abrir{endBold} cuando tu ordenador lo solicite.";
	}

	protected override string _GetTemplateForResponseDialogMacChromeThirdInstruction()
	{
		return "Haz clic en {startBold}Abrir{endBold} cuando tu ordenador lo solicite.";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacFirefoxFifthInstruction"
	/// Then select the Remember my choice... checkbox and click OK
	/// English String: "Then select the {startBold}Remember my choice...{endBold} checkbox and click {startBold2}OK{endBold2}"
	/// </summary>
	public override string ResponseDialogMacFirefoxFifthInstruction(string startBold, string endBold, string startBold2, string endBold2)
	{
		return $"A continuación, selecciona la casilla {startBold}Recordar mi elección...{endBold} y haz clic en {startBold2}Aceptar{endBold2}.";
	}

	protected override string _GetTemplateForResponseDialogMacFirefoxFifthInstruction()
	{
		return "A continuación, selecciona la casilla {startBold}Recordar mi elección...{endBold} y haz clic en {startBold2}Aceptar{endBold2}.";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacFirefoxFirstInstruction"
	/// Select Open with and click OK
	/// English String: "Select {startBold}Open with{endBold} and click {startBold2}OK{endBold2}"
	/// </summary>
	public override string ResponseDialogMacFirefoxFirstInstruction(string startBold, string endBold, string startBold2, string endBold2)
	{
		return $"Selecciona {startBold}Abrir con{endBold} y haz clic en {startBold2}Aceptar{endBold2}.";
	}

	protected override string _GetTemplateForResponseDialogMacFirefoxFirstInstruction()
	{
		return "Selecciona {startBold}Abrir con{endBold} y haz clic en {startBold2}Aceptar{endBold2}.";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacFirefoxFourthInstruction"
	/// Once installed, click Play to join the action!
	/// English String: "Once installed, click {startBold}Play{endBold} to join the action!"
	/// </summary>
	public override string ResponseDialogMacFirefoxFourthInstruction(string startBold, string endBold)
	{
		return $"Una vez instalado, haz clic en {startBold}Jugar{endBold} para unirte a la acción.";
	}

	protected override string _GetTemplateForResponseDialogMacFirefoxFourthInstruction()
	{
		return "Una vez instalado, haz clic en {startBold}Jugar{endBold} para unirte a la acción.";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacFirefoxSecondInstruction"
	/// Double-click the Roblox Icon to begin the installation process
	/// English String: "Double-click the {startBold}Roblox Icon{endBold} to begin the installation process"
	/// </summary>
	public override string ResponseDialogMacFirefoxSecondInstruction(string startBold, string endBold)
	{
		return $"Haz doble clic en el {startBold}icono de Roblox{endBold} para iniciar el proceso de instalación.";
	}

	protected override string _GetTemplateForResponseDialogMacFirefoxSecondInstruction()
	{
		return "Haz doble clic en el {startBold}icono de Roblox{endBold} para iniciar el proceso de instalación.";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacFirefoxThirdInstruction"
	/// You will receive a warning, click Open
	/// English String: "You will receive a warning, click {startBold}Open{endBold}"
	/// </summary>
	public override string ResponseDialogMacFirefoxThirdInstruction(string startBold, string endBold)
	{
		return $"Al recibir una advertencia, haz clic en {startBold}Abrir{endBold}.";
	}

	protected override string _GetTemplateForResponseDialogMacFirefoxThirdInstruction()
	{
		return "Al recibir una advertencia, haz clic en {startBold}Abrir{endBold}.";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacSafariFirstInstruction"
	/// Go to Downloads and double-click Roblox.dmg
	/// English String: "Go to Downloads and double-click {startBold}Roblox.dmg{endBold}"
	/// </summary>
	public override string ResponseDialogMacSafariFirstInstruction(string startBold, string endBold)
	{
		return $"Ve a Descargas y haz doble clic en {startBold}Roblox.dmg{endBold}.";
	}

	protected override string _GetTemplateForResponseDialogMacSafariFirstInstruction()
	{
		return "Ve a Descargas y haz doble clic en {startBold}Roblox.dmg{endBold}.";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacSafariFourthInstruction"
	/// Once installed, click {startBold}Play{endBold} to join the action!
	/// English String: "Once installed, click {startBold}Play{endBold} to join the action!"
	/// </summary>
	public override string ResponseDialogMacSafariFourthInstruction(string startBold, string endBold)
	{
		return $"Una vez instalado, haz clic en {startBold}Jugar{endBold} para unirte a la acción.";
	}

	protected override string _GetTemplateForResponseDialogMacSafariFourthInstruction()
	{
		return "Una vez instalado, haz clic en {startBold}Jugar{endBold} para unirte a la acción.";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacSafariSecondInstruction"
	/// Double-click the {startBold}Roblox Icon{endBold} to begin the installation process
	/// English String: "Double-click the {startBold}Roblox Icon{endBold} to begin the installation process"
	/// </summary>
	public override string ResponseDialogMacSafariSecondInstruction(string startBold, string endBold)
	{
		return $"Haz doble clic en el {startBold}icono de Roblox{endBold} para iniciar el proceso de instalación.";
	}

	protected override string _GetTemplateForResponseDialogMacSafariSecondInstruction()
	{
		return "Haz doble clic en el {startBold}icono de Roblox{endBold} para iniciar el proceso de instalación.";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacSafariThirdInstruction"
	/// You will receive a warning, click {startBold}Open{endBold}
	/// English String: "You will receive a warning, click {startBold}Open{endBold}"
	/// </summary>
	public override string ResponseDialogMacSafariThirdInstruction(string startBold, string endBold)
	{
		return $"Al recibir una advertencia, haz clic en {startBold}Abrir{endBold}.";
	}

	protected override string _GetTemplateForResponseDialogMacSafariThirdInstruction()
	{
		return "Al recibir una advertencia, haz clic en {startBold}Abrir{endBold}.";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcChromeFirstInstruction"
	/// Click {startBold}RobloxPlayer.exe{endBold} to run the Roblox installer, which just downloaded via your web browser.
	/// English String: "Click {startBold}RobloxPlayer.exe{endBold} to run the Roblox installer, which just downloaded via your web browser."
	/// </summary>
	public override string ResponseDialogPcChromeFirstInstruction(string startBold, string endBold)
	{
		return $"Haz clic en {startBold}RobloxPlayer.exe{endBold} para ejecutar el instalador de Roblox recién descargado con tu navegador.";
	}

	protected override string _GetTemplateForResponseDialogPcChromeFirstInstruction()
	{
		return "Haz clic en {startBold}RobloxPlayer.exe{endBold} para ejecutar el instalador de Roblox recién descargado con tu navegador.";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcChromeFourthInstruction"
	/// After installation, click {startBold}Play{endBold} below to join the action!
	/// English String: "After installation, click {startBold}Play{endBold} below to join the action!"
	/// </summary>
	public override string ResponseDialogPcChromeFourthInstruction(string startBold, string endBold)
	{
		return $"Una vez finalizada la instalación, haz clic en {startBold}Jugar{endBold} a continuación para unirte a la acción.";
	}

	protected override string _GetTemplateForResponseDialogPcChromeFourthInstruction()
	{
		return "Una vez finalizada la instalación, haz clic en {startBold}Jugar{endBold} a continuación para unirte a la acción.";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcChromeSecondInstruction"
	/// Click {startBold}Run{endBold} when prompted by your computer to begin the installation process.
	/// English String: "Click {startBold}Run{endBold} when prompted by your computer to begin the installation process."
	/// </summary>
	public override string ResponseDialogPcChromeSecondInstruction(string startBold, string endBold)
	{
		return $"Haz clic en {startBold}Ejecutar{endBold} cuando tu ordenador lo solicite para iniciar el proceso de instalación.";
	}

	protected override string _GetTemplateForResponseDialogPcChromeSecondInstruction()
	{
		return "Haz clic en {startBold}Ejecutar{endBold} cuando tu ordenador lo solicite para iniciar el proceso de instalación.";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcChromeThirdInstruction"
	/// Click {startBold}Ok{endBold} once you've successfully installed Roblox.
	/// English String: "Click {startBold}Ok{endBold} once you've successfully installed Roblox."
	/// </summary>
	public override string ResponseDialogPcChromeThirdInstruction(string startBold, string endBold)
	{
		return $"Haz clic en {startBold}Aceptar{endBold} una vez que Roblox se haya instalado correctamente.";
	}

	protected override string _GetTemplateForResponseDialogPcChromeThirdInstruction()
	{
		return "Haz clic en {startBold}Aceptar{endBold} una vez que Roblox se haya instalado correctamente.";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcEdgeFirstInstruction"
	/// Click {startBold}Run{endBold} to install Roblox after the download finishes
	/// English String: "Click {startBold}Run{endBold} to install Roblox after the download finishes"
	/// </summary>
	public override string ResponseDialogPcEdgeFirstInstruction(string startBold, string endBold)
	{
		return $"Haz clic en {startBold}Ejecutar{endBold} para instalar Roblox una vez finalizada la descarga.";
	}

	protected override string _GetTemplateForResponseDialogPcEdgeFirstInstruction()
	{
		return "Haz clic en {startBold}Ejecutar{endBold} para instalar Roblox una vez finalizada la descarga.";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcEdgeSecondInstruction"
	/// Click {startBold}Ok{endBold} to finish installing Roblox
	/// English String: "Click {startBold}Ok{endBold} to finish installing Roblox"
	/// </summary>
	public override string ResponseDialogPcEdgeSecondInstruction(string startBold, string endBold)
	{
		return $"Haz clic en {startBold}Aceptar{endBold} para finalizar la instalación de Roblox.";
	}

	protected override string _GetTemplateForResponseDialogPcEdgeSecondInstruction()
	{
		return "Haz clic en {startBold}Aceptar{endBold} para finalizar la instalación de Roblox.";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcEdgeThirdInstruction"
	/// Click the {startBold}Play{endBold} button to join the action!
	/// English String: "Click the {startBold}Play{endBold} button to join the action!"
	/// </summary>
	public override string ResponseDialogPcEdgeThirdInstruction(string startBold, string endBold)
	{
		return $"Haz clic en el botón {startBold}Jugar{endBold} para unirte a la acción.";
	}

	protected override string _GetTemplateForResponseDialogPcEdgeThirdInstruction()
	{
		return "Haz clic en el botón {startBold}Jugar{endBold} para unirte a la acción.";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcFirefoxFifthInstruction"
	/// Click {startBold}Ok{endBold} when the alert pops up
	/// English String: "Click {startBold}Ok{endBold} when the alert pops up"
	/// </summary>
	public override string ResponseDialogPcFirefoxFifthInstruction(string startBold, string endBold)
	{
		return $"Haz clic en {startBold}Aceptar{endBold} cuando aparezca la alerta.";
	}

	protected override string _GetTemplateForResponseDialogPcFirefoxFifthInstruction()
	{
		return "Haz clic en {startBold}Aceptar{endBold} cuando aparezca la alerta.";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcFirefoxFirstInstruction"
	/// Click {startBold}Save File{endBold} when the download window pops up
	/// English String: "Click {startBold}Save File{endBold} when the download window pops up"
	/// </summary>
	public override string ResponseDialogPcFirefoxFirstInstruction(string startBold, string endBold)
	{
		return $"Haz clic en {startBold}Guardar archivo{endBold} cuando aparezca la ventana de descarga.";
	}

	protected override string _GetTemplateForResponseDialogPcFirefoxFirstInstruction()
	{
		return "Haz clic en {startBold}Guardar archivo{endBold} cuando aparezca la ventana de descarga.";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcFirefoxFourthInstruction"
	/// Once installed, click {startBold}Play{endBold} to join the action!
	/// English String: "Once installed, click {startBold}Play{endBold} to join the action!"
	/// </summary>
	public override string ResponseDialogPcFirefoxFourthInstruction(string startBold, string endBold)
	{
		return $"Una vez instalado, haz clic en {startBold}Jugar{endBold} para unirte a la acción.";
	}

	protected override string _GetTemplateForResponseDialogPcFirefoxFourthInstruction()
	{
		return "Una vez instalado, haz clic en {startBold}Jugar{endBold} para unirte a la acción.";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcFirefoxSecondInstruction"
	/// Go to Downloads and double click {startBold}RobloxPlayer.exe{endBold}
	/// English String: "Go to Downloads and double click {startBold}RobloxPlayer.exe{endBold}"
	/// </summary>
	public override string ResponseDialogPcFirefoxSecondInstruction(string startBold, string endBold)
	{
		return $"Ve a Descargas y haz doble clic en {startBold}RobloxPlayer.exe{endBold}.";
	}

	protected override string _GetTemplateForResponseDialogPcFirefoxSecondInstruction()
	{
		return "Ve a Descargas y haz doble clic en {startBold}RobloxPlayer.exe{endBold}.";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcFirefoxThirdInstruction"
	/// Click {startBold}Run{endBold}
	/// English String: "Click {startBold}Run{endBold}"
	/// </summary>
	public override string ResponseDialogPcFirefoxThirdInstruction(string startBold, string endBold)
	{
		return $"Haz clic en {startBold}Ejecutar{endBold}.";
	}

	protected override string _GetTemplateForResponseDialogPcFirefoxThirdInstruction()
	{
		return "Haz clic en {startBold}Ejecutar{endBold}.";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcIEFirstInstruction"
	/// You will receive a warning, click {startBold}Run{endBold}
	/// English String: "You will receive a warning, click {startBold}Run{endBold}"
	/// </summary>
	public override string ResponseDialogPcIEFirstInstruction(string startBold, string endBold)
	{
		return $"Al recibir una advertencia, haz clic en {startBold}Ejecutar{endBold}.";
	}

	protected override string _GetTemplateForResponseDialogPcIEFirstInstruction()
	{
		return "Al recibir una advertencia, haz clic en {startBold}Ejecutar{endBold}.";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcIeInstructionOne"
	/// You will receive a warning, click {startBold}Run{endBold}
	/// English String: "You will receive a warning, click {startBold}Run{endBold}"
	/// </summary>
	public override string ResponseDialogPcIeInstructionOne(string startBold, string endBold)
	{
		return $"Al recibir una advertencia, haz clic en {startBold}Ejecutar{endBold}.";
	}

	protected override string _GetTemplateForResponseDialogPcIeInstructionOne()
	{
		return "Al recibir una advertencia, haz clic en {startBold}Ejecutar{endBold}.";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcIeInstructionThree"
	/// Click {startBold}Run{endBold}
	/// English String: "Click {startBold}Run{endBold}"
	/// </summary>
	public override string ResponseDialogPcIeInstructionThree(string startBold, string endBold)
	{
		return $"Haz clic en {startBold}Ejecutar{endBold}.";
	}

	protected override string _GetTemplateForResponseDialogPcIeInstructionThree()
	{
		return "Haz clic en {startBold}Ejecutar{endBold}.";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcIeInstructionTwo"
	/// Go to Downloads and double click {startBold}RobloxPlayer.exe{endBold}
	/// English String: "Go to Downloads and double click {startBold}RobloxPlayer.exe{endBold}"
	/// </summary>
	public override string ResponseDialogPcIeInstructionTwo(string startBold, string endBold)
	{
		return $"Ve a Descargas y haz doble clic en {startBold}RobloxPlayer.exe{endBold}.";
	}

	protected override string _GetTemplateForResponseDialogPcIeInstructionTwo()
	{
		return "Ve a Descargas y haz doble clic en {startBold}RobloxPlayer.exe{endBold}.";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcIESecondInstruction"
	/// Click {startBold}Ok{endBold} once you've installed Roblox
	/// English String: "Click {startBold}Ok{endBold} once you've installed Roblox"
	/// </summary>
	public override string ResponseDialogPcIESecondInstruction(string startBold, string endBold)
	{
		return $"Haz clic en {startBold}Aceptar{endBold} una vez que hayas instalado Roblox.";
	}

	protected override string _GetTemplateForResponseDialogPcIESecondInstruction()
	{
		return "Haz clic en {startBold}Aceptar{endBold} una vez que hayas instalado Roblox.";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcIEThirdInstruction"
	/// Once installed, click {startBold}Play{endBold} to join the action!
	/// English String: "Once installed, click {startBold}Play{endBold} to join the action!"
	/// </summary>
	public override string ResponseDialogPcIEThirdInstruction(string startBold, string endBold)
	{
		return $"Una vez instalado, haz clic en {startBold}Jugar{endBold} para unirte a la acción.";
	}

	protected override string _GetTemplateForResponseDialogPcIEThirdInstruction()
	{
		return "Una vez instalado, haz clic en {startBold}Jugar{endBold} para unirte a la acción.";
	}

	protected override string _GetTemplateForResponseDialogThanksForPlayingRoblox()
	{
		return "Gracias por jugar a Roblox";
	}

	protected override string _GetTemplateForResponseGameTemporarilyUnavailable()
	{
		return "No se ha podido comprobar que tienes acceso a este juego. Inténtalo de nuevo más tarde.";
	}

	/// <summary>
	/// Key: "Response.RememberMyChoiceAppLaunch"
	/// Check {startBold}Remember my choice{endBold} and click {appLaunchLink} in the dialog box above to join games faster in the future!
	/// English String: "Check {startBold}Remember my choice{endBold} and click {appLaunchLink} in the dialog box above to join games faster in the future!"
	/// </summary>
	public override string ResponseRememberMyChoiceAppLaunch(string startBold, string endBold, string appLaunchLink)
	{
		return $"Activa {startBold}Recordar mi opción{endBold} y haz clic en {appLaunchLink} en el cuadro de diálogo de arriba para acceder más rápidamente a los juegos.";
	}

	protected override string _GetTemplateForResponseRememberMyChoiceAppLaunch()
	{
		return "Activa {startBold}Recordar mi opción{endBold} y haz clic en {appLaunchLink} en el cuadro de diálogo de arriba para acceder más rápidamente a los juegos.";
	}
}
