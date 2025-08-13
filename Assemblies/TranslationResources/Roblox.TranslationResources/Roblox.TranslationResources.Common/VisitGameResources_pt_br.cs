namespace Roblox.TranslationResources.Common;

/// <summary>
/// This class overrides VisitGameResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class VisitGameResources_pt_br : VisitGameResources_en_us, IVisitGameResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Retry"
	/// button label
	/// English String: "Retry"
	/// </summary>
	public override string ActionRetry => "Tentar de novo";

	/// <summary>
	/// Key: "Heading.ErrorStartingGame"
	/// Error starting game
	/// English String: "Error starting game"
	/// </summary>
	public override string HeadingErrorStartingGame => "Erro ao iniciar jogo";

	/// <summary>
	/// Key: "Heading.SwitchToDesktopToPlay"
	/// Switch to Desktop Mode to Play Games
	/// English String: "Switch to Desktop Mode to Play Games"
	/// </summary>
	public override string HeadingSwitchToDesktopToPlay => "Mude para Modo Desktop para jogar";

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
	public override string LabelCheckingForStudio => "Conferindo Roblox Studio...";

	/// <summary>
	/// Key: "Label.ClickHereForHelp"
	/// Click here for help
	/// English String: "Click here for help"
	/// </summary>
	public override string LabelClickHereForHelp => "Clique aqui para obter ajuda";

	/// <summary>
	/// Key: "Label.ConnectingToPlayers"
	/// Joining a game network with other players
	/// English String: "Connecting to Players..."
	/// </summary>
	public override string LabelConnectingToPlayers => "Conectando-se aos jogadores...";

	/// <summary>
	/// Key: "Label.DevelopPageTitle"
	/// English String: "Develop"
	/// </summary>
	public override string LabelDevelopPageTitle => "Desenvolvimento";

	/// <summary>
	/// Key: "Label.DownloadInstallRoblox"
	/// Download and Install Roblox
	/// English String: "Download and Install Roblox"
	/// </summary>
	public override string LabelDownloadInstallRoblox => "Baixe e instale Roblox";

	/// <summary>
	/// Key: "Label.DownloadStudio"
	/// Download Roblox Studio to start creating games
	/// English String: "Download Studio"
	/// </summary>
	public override string LabelDownloadStudio => "Baixar Studio";

	/// <summary>
	/// Key: "Label.GameConfigurePageTitle"
	/// English String: "Game Configure"
	/// </summary>
	public override string LabelGameConfigurePageTitle => "Configuração do jogo";

	/// <summary>
	/// Key: "Label.GameFreeSoothsayer"
	/// English String: "Free because you are a soothsayer"
	/// </summary>
	public override string LabelGameFreeSoothsayer => "Grátis, pois você é um profeta";

	/// <summary>
	/// Key: "Label.GameUnavailableAccountResrictions"
	/// English String: "The game is unavailable due to account restrictions settings."
	/// </summary>
	public override string LabelGameUnavailableAccountResrictions => "O jogo não está disponível devido a configurações de restrições da conta.";

	/// <summary>
	/// Key: "Label.GameUnavailableCannotPlayGamesStudio"
	/// English String: "You cannot play games from Studio. Please use a web browser to play this game."
	/// </summary>
	public override string LabelGameUnavailableCannotPlayGamesStudio => "Você não pode jogar do Studio. Use um navegador para jogar este jogo.";

	/// <summary>
	/// Key: "Label.GameUnavailableClosedToVisitors"
	/// English String: "Sorry, this place is currently closed to visitors."
	/// </summary>
	public override string LabelGameUnavailableClosedToVisitors => "Infelizmente, este local está fechado para visitantes no momento.";

	/// <summary>
	/// Key: "Label.GameUnavailableCurrentlyIsPrivateVisitor"
	/// When a game is private, this message is shown to visitors.
	/// English String: "Sorry, this game is private."
	/// </summary>
	public override string LabelGameUnavailableCurrentlyIsPrivateVisitor => "Ops! Este jogo é privado.";

	/// <summary>
	/// Key: "Label.GameUnavailableGameInsecure"
	/// U13 users cannot play insecure games unless they are the creator or friends with the creator.
	/// English String: "Sorry, your account is restricted from playing Experimental Games unless you are friends with the creator."
	/// </summary>
	public override string LabelGameUnavailableGameInsecure => "Você não pode jogar jogos experimentais a menos que seja amigo do criador do jogo pois sua conta é restrita.";

	/// <summary>
	/// Key: "Label.GameUnavailablePermissionLevels"
	/// English String: "The permission levels on this place prevent you from entering."
	/// </summary>
	public override string LabelGameUnavailablePermissionLevels => "Os níveis de permissão neste local impedem que você entre.";

	/// <summary>
	/// Key: "Label.GameUnavailablePlaceUnderReview"
	/// English String: "Sorry, this place is currently under review. Try again later."
	/// </summary>
	public override string LabelGameUnavailablePlaceUnderReview => "Infelizmente, este local está sob revisão no momento. Tente de novo mais tarde.";

	/// <summary>
	/// Key: "Label.GameUnavailablePlatform"
	/// English String: "This game is not available on your platform.  Check the games page to see all playable games."
	/// </summary>
	public override string LabelGameUnavailablePlatform => "Este jogo não está disponível na sua plataforma. Confira a página de jogos para ver todos os jogos disponíveis.";

	/// <summary>
	/// Key: "Label.GameWarning"
	/// English String: "Warning"
	/// </summary>
	public override string LabelGameWarning => "Aviso";

	/// <summary>
	/// Key: "Label.InstallationInstructions"
	/// Installation Instructions
	/// English String: "Installation Instructions"
	/// </summary>
	public override string LabelInstallationInstructions => "Instruções de instalação";

	/// <summary>
	/// Key: "Label.LaunchApplication"
	/// Launch Application
	/// English String: "Launch Application"
	/// </summary>
	public override string LabelLaunchApplication => "Iniciar aplicativo";

	/// <summary>
	/// Key: "Label.PersuadeToDevelopRoblox"
	/// Persuade user to begin developing their own games using Roblox Studio
	/// English String: "Get started creating your own games!"
	/// </summary>
	public override string LabelPersuadeToDevelopRoblox => "Comece a criar seus próprios jogos!";

	/// <summary>
	/// Key: "Label.PersuadeToInstallRoblox"
	/// We are exciting the user about Roblox so that they will be persuaded to download and install it.
	/// English String: "You're moments away from getting into the game!"
	/// </summary>
	public override string LabelPersuadeToInstallRoblox => "Falta pouco para você entrar no jogo!";

	/// <summary>
	/// Key: "Label.Play"
	/// English String: "Play"
	/// </summary>
	public override string LabelPlay => "Jogar";

	/// <summary>
	/// Key: "Label.PlayInApp"
	/// English String: "Play in App"
	/// </summary>
	public override string LabelPlayInApp => "Jogar no app";

	/// <summary>
	/// Key: "Label.RobloxLoadingToPlay"
	/// Roblox is loading, so the user is getting excited to start playing a game
	/// English String: "Roblox is now loading. Get ready to play!"
	/// </summary>
	public override string LabelRobloxLoadingToPlay => "Roblox está carregando. Prepare-se para jogar!";

	/// <summary>
	/// Key: "Label.StartingRoblox"
	/// Game launch process has started
	/// English String: "Starting Roblox..."
	/// </summary>
	public override string LabelStartingRoblox => "Iniciando Roblox...";

	/// <summary>
	/// Key: "Label.SwitchToDesktopMode"
	/// Switch to Desktop Mode
	/// English String: "Switch to Desktop Mode"
	/// </summary>
	public override string LabelSwitchToDesktopMode => "Mudar para Modo Desktop";

	/// <summary>
	/// Key: "Label.UniverseConfigurePageTitle"
	/// The name of the universe configuration page
	/// English String: "Universe Configuration"
	/// </summary>
	public override string LabelUniverseConfigurePageTitle => "Configuração de universo";

	/// <summary>
	/// Key: "Response.Dialog.ClickHere"
	/// Click here!
	/// English String: "Click here!"
	/// </summary>
	public override string ResponseDialogClickHere => "Clique aqui!";

	/// <summary>
	/// Key: "Response.Dialog.ErrorLaunching"
	/// An error occurred trying to launch the game.  Please try again later.
	/// English String: "An error occurred trying to launch the game.  Please try again later."
	/// </summary>
	public override string ResponseDialogErrorLaunching => "Ocorreu um erro ao tentar iniciar o jogo. Tente novamente mais tarde.";

	/// <summary>
	/// Key: "Response.Dialog.HavingTroubleInstallQuestion"
	/// (Are you) having trouble installing Roblox?
	/// English String: "Having trouble installing Roblox?"
	/// </summary>
	public override string ResponseDialogHavingTroubleInstallQuestion => "Você está tendo problemas para instalar o Roblox?";

	/// <summary>
	/// Key: "Response.Dialog.MacChromeSecondInstruction"
	/// Double-click the Roblox app icon to begin the installation process.
	/// English String: "Double-click the Roblox app icon to begin the installation process."
	/// </summary>
	public override string ResponseDialogMacChromeSecondInstruction => "Dê um clique duplo no ícone do app Roblox para iniciar o processo de instalação.";

	/// <summary>
	/// Key: "Response.Dialog.ThanksForPlayingRoblox"
	/// Thanks for playing Roblox
	/// English String: "Thanks for playing Roblox"
	/// </summary>
	public override string ResponseDialogThanksForPlayingRoblox => "Obrigado por jogar Roblox";

	/// <summary>
	/// Key: "Response.GameTemporarilyUnavailable"
	/// error message (will be followed by link with Action.Retry label)
	/// English String: "Unable to verify that you have access to this game.  Please try again later."
	/// </summary>
	public override string ResponseGameTemporarilyUnavailable => "Impossível verificar seu acesso a este jogo. Tente de novo mais tarde.";

	public VisitGameResources_pt_br(TranslationResourceState state)
		: base(state)
	{
	}

	/// <summary>
	/// Key: "Action.GamePerformPoorly"
	/// English String: "{warning} This game may perform poorly on your device."
	/// </summary>
	public override string ActionGamePerformPoorly(string warning)
	{
		return $"{warning} Este jogo pode ter um desempenho ruim no seu dispositivo.";
	}

	protected override string _GetTemplateForActionGamePerformPoorly()
	{
		return "{warning} Este jogo pode ter um desempenho ruim no seu dispositivo.";
	}

	protected override string _GetTemplateForActionRetry()
	{
		return "Tentar de novo";
	}

	protected override string _GetTemplateForHeadingErrorStartingGame()
	{
		return "Erro ao iniciar jogo";
	}

	protected override string _GetTemplateForHeadingSwitchToDesktopToPlay()
	{
		return "Mude para Modo Desktop para jogar";
	}

	/// <summary>
	/// Key: "Label.BuyAccess"
	/// English String: "Buy Access for {robux} Robux"
	/// </summary>
	public override string LabelBuyAccess(string robux)
	{
		return $"Acessar por {robux} Robux";
	}

	protected override string _GetTemplateForLabelBuyAccess()
	{
		return "Acessar por {robux} Robux";
	}

	protected override string _GetTemplateForLabelCancel()
	{
		return "Cancelar";
	}

	protected override string _GetTemplateForLabelCheckingForStudio()
	{
		return "Conferindo Roblox Studio...";
	}

	protected override string _GetTemplateForLabelClickHereForHelp()
	{
		return "Clique aqui para obter ajuda";
	}

	protected override string _GetTemplateForLabelConnectingToPlayers()
	{
		return "Conectando-se aos jogadores...";
	}

	protected override string _GetTemplateForLabelDevelopPageTitle()
	{
		return "Desenvolvimento";
	}

	protected override string _GetTemplateForLabelDownloadInstallRoblox()
	{
		return "Baixe e instale Roblox";
	}

	protected override string _GetTemplateForLabelDownloadStudio()
	{
		return "Baixar Studio";
	}

	protected override string _GetTemplateForLabelGameConfigurePageTitle()
	{
		return "Configuração do jogo";
	}

	protected override string _GetTemplateForLabelGameFreeSoothsayer()
	{
		return "Grátis, pois você é um profeta";
	}

	/// <summary>
	/// Key: "Label.GameIsPrivatePlayableByGroupOnly"
	/// When a game is private, this message is shown to group developers with a link from where it can be made public.
	/// English String: "Only developers can play because this game is private. Make it public on the {linkStart}Configure Game{linkEnd} page."
	/// </summary>
	public override string LabelGameIsPrivatePlayableByGroupOnly(string linkStart, string linkEnd)
	{
		return $"Só os desenvolvedores podem jogar porque este jogo é privado. Torne-o público na página de {linkStart}Configurar jogo{linkEnd}.";
	}

	protected override string _GetTemplateForLabelGameIsPrivatePlayableByGroupOnly()
	{
		return "Só os desenvolvedores podem jogar porque este jogo é privado. Torne-o público na página de {linkStart}Configurar jogo{linkEnd}.";
	}

	/// <summary>
	/// Key: "Label.GameIsPrivatePlayableByOwnerOnly"
	/// When a game is private, this message is shown to owner with a link from where it can be made public.
	/// English String: "Only you can play because this game is private. Make it public on the {linkStart}Configure Game{linkEnd} page."
	/// </summary>
	public override string LabelGameIsPrivatePlayableByOwnerOnly(string linkStart, string linkEnd)
	{
		return $"Só você pode jogar porque este jogo é privado. Torne-o público na página de {linkStart}Configurar jogo{linkEnd}.";
	}

	protected override string _GetTemplateForLabelGameIsPrivatePlayableByOwnerOnly()
	{
		return "Só você pode jogar porque este jogo é privado. Torne-o público na página de {linkStart}Configurar jogo{linkEnd}.";
	}

	protected override string _GetTemplateForLabelGameUnavailableAccountResrictions()
	{
		return "O jogo não está disponível devido a configurações de restrições da conta.";
	}

	protected override string _GetTemplateForLabelGameUnavailableCannotPlayGamesStudio()
	{
		return "Você não pode jogar do Studio. Use um navegador para jogar este jogo.";
	}

	protected override string _GetTemplateForLabelGameUnavailableClosedToVisitors()
	{
		return "Infelizmente, este local está fechado para visitantes no momento.";
	}

	/// <summary>
	/// Key: "Label.GameUnavailableCurrentlyIsPrivateGroup"
	/// When a game is private, this message is shown to group developers with a link from where it can be made public. Similar to an existing translation. Change is making the message directly address the group developers.
	/// English String: "Only developers can play because this game is private. Make it public on the {linkStart}Develop{linkEnd} page."
	/// </summary>
	public override string LabelGameUnavailableCurrentlyIsPrivateGroup(string linkStart, string linkEnd)
	{
		return $"Só os desenvolvedores podem jogar porque este jogo é privado. Torne-o público na página de {linkStart}Desenvolvimento{linkEnd}.";
	}

	protected override string _GetTemplateForLabelGameUnavailableCurrentlyIsPrivateGroup()
	{
		return "Só os desenvolvedores podem jogar porque este jogo é privado. Torne-o público na página de {linkStart}Desenvolvimento{linkEnd}.";
	}

	/// <summary>
	/// Key: "Label.GameUnavailableCurrentlyIsPrivateOwner"
	/// When a game is private, this message is shown to owner with a link from where it can be made public. Similar to an existing translation. Change is making the message directly address the owner.
	/// English String: "Only you can play because this game is private. Make it public on the {linkStart}Develop{linkEnd} page."
	/// </summary>
	public override string LabelGameUnavailableCurrentlyIsPrivateOwner(string linkStart, string linkEnd)
	{
		return $"Só você pode jogar porque este jogo é privado. Torne-o público na página de {linkStart}Desenvolvimento{linkEnd}.";
	}

	protected override string _GetTemplateForLabelGameUnavailableCurrentlyIsPrivateOwner()
	{
		return "Só você pode jogar porque este jogo é privado. Torne-o público na página de {linkStart}Desenvolvimento{linkEnd}.";
	}

	protected override string _GetTemplateForLabelGameUnavailableCurrentlyIsPrivateVisitor()
	{
		return "Ops! Este jogo é privado.";
	}

	/// <summary>
	/// Key: "Label.GameUnavailableCurrentlyPrivate"
	/// When a game is private, this message is shown to user with link from where it can be made public
	/// English String: "This {gameTypeName} is currently private. Make it public on the {developPageLink} page to make it playable."
	/// </summary>
	public override string LabelGameUnavailableCurrentlyPrivate(string gameTypeName, string developPageLink)
	{
		return $"Este jogo {gameTypeName} está em modo privado. Torne-o público na página {developPageLink} para torná-lo disponível.";
	}

	protected override string _GetTemplateForLabelGameUnavailableCurrentlyPrivate()
	{
		return "Este jogo {gameTypeName} está em modo privado. Torne-o público na página {developPageLink} para torná-lo disponível.";
	}

	protected override string _GetTemplateForLabelGameUnavailableGameInsecure()
	{
		return "Você não pode jogar jogos experimentais a menos que seja amigo do criador do jogo pois sua conta é restrita.";
	}

	/// <summary>
	/// Key: "Label.GameUnavailableNoRootPlace"
	/// English String: "This place is part of a game that has no root place. Add a root place on the {gameConfigureLink} page to make it playable."
	/// </summary>
	public override string LabelGameUnavailableNoRootPlace(string gameConfigureLink)
	{
		return $"Este local faz parte de um jogo que não possui um local-raiz. Adicione um local-raiz na página {gameConfigureLink} para torná-lo jogável.";
	}

	protected override string _GetTemplateForLabelGameUnavailableNoRootPlace()
	{
		return "Este local faz parte de um jogo que não possui um local-raiz. Adicione um local-raiz na página {gameConfigureLink} para torná-lo jogável.";
	}

	protected override string _GetTemplateForLabelGameUnavailablePermissionLevels()
	{
		return "Os níveis de permissão neste local impedem que você entre.";
	}

	/// <summary>
	/// Key: "Label.GameUnavailablePlaceNotPartOfGame"
	/// English String: "This place is not currently part of a Game. Add it to a game on the {developPageLink} page to make it playable."
	/// </summary>
	public override string LabelGameUnavailablePlaceNotPartOfGame(string developPageLink)
	{
		return $"Este local não faz parte de um jogo no momento. Adicione-o a um jogo na página {developPageLink} para torná-lo jogável.";
	}

	protected override string _GetTemplateForLabelGameUnavailablePlaceNotPartOfGame()
	{
		return "Este local não faz parte de um jogo no momento. Adicione-o a um jogo na página {developPageLink} para torná-lo jogável.";
	}

	protected override string _GetTemplateForLabelGameUnavailablePlaceUnderReview()
	{
		return "Infelizmente, este local está sob revisão no momento. Tente de novo mais tarde.";
	}

	protected override string _GetTemplateForLabelGameUnavailablePlatform()
	{
		return "Este jogo não está disponível na sua plataforma. Confira a página de jogos para ver todos os jogos disponíveis.";
	}

	protected override string _GetTemplateForLabelGameWarning()
	{
		return "Aviso";
	}

	protected override string _GetTemplateForLabelInstallationInstructions()
	{
		return "Instruções de instalação";
	}

	protected override string _GetTemplateForLabelLaunchApplication()
	{
		return "Iniciar aplicativo";
	}

	/// <summary>
	/// Key: "Label.OperaInstallSteps"
	/// 1) A window will open. Click Open2) Doubleclick the Roblox icon.
	/// English String: "1) A window will open. Click {startBold}Open{endBold}.{breakLine}2) Doubleclick the Roblox icon."
	/// </summary>
	public override string LabelOperaInstallSteps(string startBold, string endBold, string breakLine)
	{
		return $"1) Uma janela abrirá. Clique em {startBold}Abrir{endBold}.{breakLine}2) Dê um clique duplo no ícone do Roblox.";
	}

	protected override string _GetTemplateForLabelOperaInstallSteps()
	{
		return "1) Uma janela abrirá. Clique em {startBold}Abrir{endBold}.{breakLine}2) Dê um clique duplo no ícone do Roblox.";
	}

	protected override string _GetTemplateForLabelPersuadeToDevelopRoblox()
	{
		return "Comece a criar seus próprios jogos!";
	}

	protected override string _GetTemplateForLabelPersuadeToInstallRoblox()
	{
		return "Falta pouco para você entrar no jogo!";
	}

	protected override string _GetTemplateForLabelPlay()
	{
		return "Jogar";
	}

	protected override string _GetTemplateForLabelPlayInApp()
	{
		return "Jogar no app";
	}

	protected override string _GetTemplateForLabelRobloxLoadingToPlay()
	{
		return "Roblox está carregando. Prepare-se para jogar!";
	}

	protected override string _GetTemplateForLabelStartingRoblox()
	{
		return "Iniciando Roblox...";
	}

	protected override string _GetTemplateForLabelSwitchToDesktopMode()
	{
		return "Mudar para Modo Desktop";
	}

	protected override string _GetTemplateForLabelUniverseConfigurePageTitle()
	{
		return "Configuração de universo";
	}

	/// <summary>
	/// Key: "Response.CheckAlwaysOpenRoblox"
	/// Check {startBold}Always open links for Roblox{endBold} and click {startBold2}Open Roblox{endBold2} in the dialog box above to join games faster in the future!
	/// English String: "Check {startBold}Always open links for Roblox{endBold} and click {startBold2}Open Roblox{endBold2} in the dialog box above to join games faster in the future!"
	/// </summary>
	public override string ResponseCheckAlwaysOpenRoblox(string startBold, string endBold, string startBold2, string endBold2)
	{
		return $"Selecione {startBold}Sempre abrir links para Roblox{endBold} e clique em {startBold2}Abrir Roblox{endBold2} na caixa de diálogo acima para entrar em jogos mais rápido no futuro!";
	}

	protected override string _GetTemplateForResponseCheckAlwaysOpenRoblox()
	{
		return "Selecione {startBold}Sempre abrir links para Roblox{endBold} e clique em {startBold2}Abrir Roblox{endBold2} na caixa de diálogo acima para entrar em jogos mais rápido no futuro!";
	}

	/// <summary>
	/// Key: "Response.CheckAlwaysOpenRobloxURL"
	/// Check {startBold}Always open links for URL: Roblox Protocol{endBold} and click {startBold}Open URL: Roblox Protocol{endBold} in the dialog box above to join games faster in the future!
	/// English String: "Check {startBold}Always open links for URL: Roblox Protocol{endBold} and click {startBold2}Open URL: Roblox Protocol{endBold2} in the dialog box above to join games faster in the future!"
	/// </summary>
	public override string ResponseCheckAlwaysOpenRobloxURL(string startBold, string endBold, string startBold2, string endBold2)
	{
		return $"Selecione {startBold}Sempre abrir links para URL: Roblox Protocol{endBold} e clique em {startBold2}Abrir URL: Roblox Protocol{endBold2} na caixa de diálogo acima para entrar em jogos mais rápido no futuro!";
	}

	protected override string _GetTemplateForResponseCheckAlwaysOpenRobloxURL()
	{
		return "Selecione {startBold}Sempre abrir links para URL: Roblox Protocol{endBold} e clique em {startBold2}Abrir URL: Roblox Protocol{endBold2} na caixa de diálogo acima para entrar em jogos mais rápido no futuro!";
	}

	/// <summary>
	/// Key: "Response.CheckRememberMyChoiceOK"
	/// Check Remember my choice and click OK in the dialog box above to join games faster in the future!
	/// English String: "Check {startBold}Remember my choice{endBold} and click {startBold2}OK{endBold2} in the dialog box above to join games faster in the future!"
	/// </summary>
	public override string ResponseCheckRememberMyChoiceOK(string startBold, string endBold, string startBold2, string endBold2)
	{
		return $"Selecione {startBold}Lembrar minha escolha{endBold} e clique em {startBold2}OK{endBold2} na caixa de diálogo acima para entrar em jogos mais rápido no futuro!";
	}

	protected override string _GetTemplateForResponseCheckRememberMyChoiceOK()
	{
		return "Selecione {startBold}Lembrar minha escolha{endBold} e clique em {startBold2}OK{endBold2} na caixa de diálogo acima para entrar em jogos mais rápido no futuro!";
	}

	protected override string _GetTemplateForResponseDialogClickHere()
	{
		return "Clique aqui!";
	}

	protected override string _GetTemplateForResponseDialogErrorLaunching()
	{
		return "Ocorreu um erro ao tentar iniciar o jogo. Tente novamente mais tarde.";
	}

	protected override string _GetTemplateForResponseDialogHavingTroubleInstallQuestion()
	{
		return "Você está tendo problemas para instalar o Roblox?";
	}

	/// <summary>
	/// Key: "Response.Dialog.InstallingMessageWithLink"
	/// Note: For this translation, please move the linkStart and linkEnd variables with the translation for download now.
	/// English String: "The Roblox installer should download shortly. If it doesn’t, start the {linkStart}download now.{linkEnd}"
	/// </summary>
	public override string ResponseDialogInstallingMessageWithLink(string linkStart, string linkEnd)
	{
		return $"O instalador do Roblox deve ser baixado em breve. Caso contrário, inicie o {linkStart}download agora.{linkEnd}";
	}

	protected override string _GetTemplateForResponseDialogInstallingMessageWithLink()
	{
		return "O instalador do Roblox deve ser baixado em breve. Caso contrário, inicie o {linkStart}download agora.{linkEnd}";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacChromeFifthInstruction"
	/// After installation, click {startBold}Play{endBold} below to join the action!
	/// English String: "After installation, click {startBold}Play{endBold} below to join the action!"
	/// </summary>
	public override string ResponseDialogMacChromeFifthInstruction(string startBold, string endBold)
	{
		return $"Depois da instalação, clique em {startBold}Jogar{endBold}, abaixo, para entrar na ação!";
	}

	protected override string _GetTemplateForResponseDialogMacChromeFifthInstruction()
	{
		return "Depois da instalação, clique em {startBold}Jogar{endBold}, abaixo, para entrar na ação!";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacChromeFirstInstruction"
	/// Click {startBold}Roblox.dmg{endBold} to run the Roblox installer, which just downloaded via your web browser.
	/// English String: "Click {startBold}Roblox.dmg{endBold} to run the Roblox installer, which just downloaded via your web browser."
	/// </summary>
	public override string ResponseDialogMacChromeFirstInstruction(string startBold, string endBold)
	{
		return $"Clique em {startBold}Roblox.dmg{endBold} para executar o instalador do Roblox que acabou de ser baixado no seu navegador.";
	}

	protected override string _GetTemplateForResponseDialogMacChromeFirstInstruction()
	{
		return "Clique em {startBold}Roblox.dmg{endBold} para executar o instalador do Roblox que acabou de ser baixado no seu navegador.";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacChromeFourthInstruction"
	/// Click {startBold}Ok{endBold} once you've successfully installed Roblox.
	/// English String: "Click {startBold}Ok{endBold} once you've successfully installed Roblox."
	/// </summary>
	public override string ResponseDialogMacChromeFourthInstruction(string startBold, string endBold)
	{
		return $"Clique em {startBold}Ok{endBold} depois de instalar o Roblox com sucesso.";
	}

	protected override string _GetTemplateForResponseDialogMacChromeFourthInstruction()
	{
		return "Clique em {startBold}Ok{endBold} depois de instalar o Roblox com sucesso.";
	}

	protected override string _GetTemplateForResponseDialogMacChromeSecondInstruction()
	{
		return "Dê um clique duplo no ícone do app Roblox para iniciar o processo de instalação.";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacChromeThirdInstruction"
	/// Click {startBold}Open{endBold} when prompted by your computer.
	/// English String: "Click {startBold}Open{endBold} when prompted by your computer."
	/// </summary>
	public override string ResponseDialogMacChromeThirdInstruction(string startBold, string endBold)
	{
		return $"Clique em {startBold}Abrir{endBold} quando solicitado por seu computador.";
	}

	protected override string _GetTemplateForResponseDialogMacChromeThirdInstruction()
	{
		return "Clique em {startBold}Abrir{endBold} quando solicitado por seu computador.";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacFirefoxFifthInstruction"
	/// Then select the Remember my choice... checkbox and click OK
	/// English String: "Then select the {startBold}Remember my choice...{endBold} checkbox and click {startBold2}OK{endBold2}"
	/// </summary>
	public override string ResponseDialogMacFirefoxFifthInstruction(string startBold, string endBold, string startBold2, string endBold2)
	{
		return $"Depois selecione a opção {startBold}Lembrar minha escolha...{endBold} e clique em {startBold2}OK{endBold2}.";
	}

	protected override string _GetTemplateForResponseDialogMacFirefoxFifthInstruction()
	{
		return "Depois selecione a opção {startBold}Lembrar minha escolha...{endBold} e clique em {startBold2}OK{endBold2}.";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacFirefoxFirstInstruction"
	/// Select Open with and click OK
	/// English String: "Select {startBold}Open with{endBold} and click {startBold2}OK{endBold2}"
	/// </summary>
	public override string ResponseDialogMacFirefoxFirstInstruction(string startBold, string endBold, string startBold2, string endBold2)
	{
		return $"Selecione {startBold}Abrir com{endBold} e clique em {startBold2}OK{endBold2}.";
	}

	protected override string _GetTemplateForResponseDialogMacFirefoxFirstInstruction()
	{
		return "Selecione {startBold}Abrir com{endBold} e clique em {startBold2}OK{endBold2}.";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacFirefoxFourthInstruction"
	/// Once installed, click Play to join the action!
	/// English String: "Once installed, click {startBold}Play{endBold} to join the action!"
	/// </summary>
	public override string ResponseDialogMacFirefoxFourthInstruction(string startBold, string endBold)
	{
		return $"Depois de instalado, clique em {startBold}Jogar{endBold} para entrar de cabeça na ação!";
	}

	protected override string _GetTemplateForResponseDialogMacFirefoxFourthInstruction()
	{
		return "Depois de instalado, clique em {startBold}Jogar{endBold} para entrar de cabeça na ação!";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacFirefoxSecondInstruction"
	/// Double-click the Roblox Icon to begin the installation process
	/// English String: "Double-click the {startBold}Roblox Icon{endBold} to begin the installation process"
	/// </summary>
	public override string ResponseDialogMacFirefoxSecondInstruction(string startBold, string endBold)
	{
		return $"Dê um clique duplo no {startBold}Ícone do Roblox{endBold} para iniciar o processo de instalação.";
	}

	protected override string _GetTemplateForResponseDialogMacFirefoxSecondInstruction()
	{
		return "Dê um clique duplo no {startBold}Ícone do Roblox{endBold} para iniciar o processo de instalação.";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacFirefoxThirdInstruction"
	/// You will receive a warning, click Open
	/// English String: "You will receive a warning, click {startBold}Open{endBold}"
	/// </summary>
	public override string ResponseDialogMacFirefoxThirdInstruction(string startBold, string endBold)
	{
		return $"Você receberá um aviso. Clique em {startBold}Abrir{endBold}.";
	}

	protected override string _GetTemplateForResponseDialogMacFirefoxThirdInstruction()
	{
		return "Você receberá um aviso. Clique em {startBold}Abrir{endBold}.";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacSafariFirstInstruction"
	/// Go to Downloads and double-click Roblox.dmg
	/// English String: "Go to Downloads and double-click {startBold}Roblox.dmg{endBold}"
	/// </summary>
	public override string ResponseDialogMacSafariFirstInstruction(string startBold, string endBold)
	{
		return $"Vá para Downloads e dê um clique duplo em {startBold}Roblox.dmg{endBold}";
	}

	protected override string _GetTemplateForResponseDialogMacSafariFirstInstruction()
	{
		return "Vá para Downloads e dê um clique duplo em {startBold}Roblox.dmg{endBold}";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacSafariFourthInstruction"
	/// Once installed, click {startBold}Play{endBold} to join the action!
	/// English String: "Once installed, click {startBold}Play{endBold} to join the action!"
	/// </summary>
	public override string ResponseDialogMacSafariFourthInstruction(string startBold, string endBold)
	{
		return $"Depois de instalado, clique em {startBold}Jogar{endBold} para entrar na ação!";
	}

	protected override string _GetTemplateForResponseDialogMacSafariFourthInstruction()
	{
		return "Depois de instalado, clique em {startBold}Jogar{endBold} para entrar na ação!";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacSafariSecondInstruction"
	/// Double-click the {startBold}Roblox Icon{endBold} to begin the installation process
	/// English String: "Double-click the {startBold}Roblox Icon{endBold} to begin the installation process"
	/// </summary>
	public override string ResponseDialogMacSafariSecondInstruction(string startBold, string endBold)
	{
		return $"Dê um clique duplo no {startBold}Ícone do Roblox{endBold} para iniciar o processo de instalação.";
	}

	protected override string _GetTemplateForResponseDialogMacSafariSecondInstruction()
	{
		return "Dê um clique duplo no {startBold}Ícone do Roblox{endBold} para iniciar o processo de instalação.";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacSafariThirdInstruction"
	/// You will receive a warning, click {startBold}Open{endBold}
	/// English String: "You will receive a warning, click {startBold}Open{endBold}"
	/// </summary>
	public override string ResponseDialogMacSafariThirdInstruction(string startBold, string endBold)
	{
		return $"Você receberá um aviso. Clique em {startBold}Abrir{endBold}.";
	}

	protected override string _GetTemplateForResponseDialogMacSafariThirdInstruction()
	{
		return "Você receberá um aviso. Clique em {startBold}Abrir{endBold}.";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcChromeFirstInstruction"
	/// Click {startBold}RobloxPlayer.exe{endBold} to run the Roblox installer, which just downloaded via your web browser.
	/// English String: "Click {startBold}RobloxPlayer.exe{endBold} to run the Roblox installer, which just downloaded via your web browser."
	/// </summary>
	public override string ResponseDialogPcChromeFirstInstruction(string startBold, string endBold)
	{
		return $"Clique em {startBold}RobloxPlayer.exe{endBold} para executar o instalador do Roblox que acabou de ser baixado no seu navegador.";
	}

	protected override string _GetTemplateForResponseDialogPcChromeFirstInstruction()
	{
		return "Clique em {startBold}RobloxPlayer.exe{endBold} para executar o instalador do Roblox que acabou de ser baixado no seu navegador.";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcChromeFourthInstruction"
	/// After installation, click {startBold}Play{endBold} below to join the action!
	/// English String: "After installation, click {startBold}Play{endBold} below to join the action!"
	/// </summary>
	public override string ResponseDialogPcChromeFourthInstruction(string startBold, string endBold)
	{
		return $"Depois da instalação, clique em {startBold}Jogar{endBold}, abaixo, para entrar na ação!";
	}

	protected override string _GetTemplateForResponseDialogPcChromeFourthInstruction()
	{
		return "Depois da instalação, clique em {startBold}Jogar{endBold}, abaixo, para entrar na ação!";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcChromeSecondInstruction"
	/// Click {startBold}Run{endBold} when prompted by your computer to begin the installation process.
	/// English String: "Click {startBold}Run{endBold} when prompted by your computer to begin the installation process."
	/// </summary>
	public override string ResponseDialogPcChromeSecondInstruction(string startBold, string endBold)
	{
		return $"Clique em {startBold}Executar{endBold}, quando solicitado pelo seu computador, para iniciar o processo de instalação.";
	}

	protected override string _GetTemplateForResponseDialogPcChromeSecondInstruction()
	{
		return "Clique em {startBold}Executar{endBold}, quando solicitado pelo seu computador, para iniciar o processo de instalação.";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcChromeThirdInstruction"
	/// Click {startBold}Ok{endBold} once you've successfully installed Roblox.
	/// English String: "Click {startBold}Ok{endBold} once you've successfully installed Roblox."
	/// </summary>
	public override string ResponseDialogPcChromeThirdInstruction(string startBold, string endBold)
	{
		return $"Clique em {startBold}Ok{endBold} depois de instalar o Roblox com sucesso.";
	}

	protected override string _GetTemplateForResponseDialogPcChromeThirdInstruction()
	{
		return "Clique em {startBold}Ok{endBold} depois de instalar o Roblox com sucesso.";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcEdgeFirstInstruction"
	/// Click {startBold}Run{endBold} to install Roblox after the download finishes
	/// English String: "Click {startBold}Run{endBold} to install Roblox after the download finishes"
	/// </summary>
	public override string ResponseDialogPcEdgeFirstInstruction(string startBold, string endBold)
	{
		return $"Clique em {startBold}Executar{endBold} para instalar o Roblox depois que o download terminar.";
	}

	protected override string _GetTemplateForResponseDialogPcEdgeFirstInstruction()
	{
		return "Clique em {startBold}Executar{endBold} para instalar o Roblox depois que o download terminar.";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcEdgeSecondInstruction"
	/// Click {startBold}Ok{endBold} to finish installing Roblox
	/// English String: "Click {startBold}Ok{endBold} to finish installing Roblox"
	/// </summary>
	public override string ResponseDialogPcEdgeSecondInstruction(string startBold, string endBold)
	{
		return $"Clique em {startBold}Ok{endBold} para terminar de instalar o Roblox.";
	}

	protected override string _GetTemplateForResponseDialogPcEdgeSecondInstruction()
	{
		return "Clique em {startBold}Ok{endBold} para terminar de instalar o Roblox.";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcEdgeThirdInstruction"
	/// Click the {startBold}Play{endBold} button to join the action!
	/// English String: "Click the {startBold}Play{endBold} button to join the action!"
	/// </summary>
	public override string ResponseDialogPcEdgeThirdInstruction(string startBold, string endBold)
	{
		return $"Clique no botão {startBold}Jogar{endBold} para entrar na ação!";
	}

	protected override string _GetTemplateForResponseDialogPcEdgeThirdInstruction()
	{
		return "Clique no botão {startBold}Jogar{endBold} para entrar na ação!";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcFirefoxFifthInstruction"
	/// Click {startBold}Ok{endBold} when the alert pops up
	/// English String: "Click {startBold}Ok{endBold} when the alert pops up"
	/// </summary>
	public override string ResponseDialogPcFirefoxFifthInstruction(string startBold, string endBold)
	{
		return $"Clique em {startBold}Ok{endBold} quando o alerta aparecer.";
	}

	protected override string _GetTemplateForResponseDialogPcFirefoxFifthInstruction()
	{
		return "Clique em {startBold}Ok{endBold} quando o alerta aparecer.";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcFirefoxFirstInstruction"
	/// Click {startBold}Save File{endBold} when the download window pops up
	/// English String: "Click {startBold}Save File{endBold} when the download window pops up"
	/// </summary>
	public override string ResponseDialogPcFirefoxFirstInstruction(string startBold, string endBold)
	{
		return $"Clique em {startBold}Salvar arquivo{endBold} quando a janela de download aparecer.";
	}

	protected override string _GetTemplateForResponseDialogPcFirefoxFirstInstruction()
	{
		return "Clique em {startBold}Salvar arquivo{endBold} quando a janela de download aparecer.";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcFirefoxFourthInstruction"
	/// Once installed, click {startBold}Play{endBold} to join the action!
	/// English String: "Once installed, click {startBold}Play{endBold} to join the action!"
	/// </summary>
	public override string ResponseDialogPcFirefoxFourthInstruction(string startBold, string endBold)
	{
		return $"Depois de instalado, clique em {startBold}Jogar{endBold} para entrar na ação!";
	}

	protected override string _GetTemplateForResponseDialogPcFirefoxFourthInstruction()
	{
		return "Depois de instalado, clique em {startBold}Jogar{endBold} para entrar na ação!";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcFirefoxSecondInstruction"
	/// Go to Downloads and double click {startBold}RobloxPlayer.exe{endBold}
	/// English String: "Go to Downloads and double click {startBold}RobloxPlayer.exe{endBold}"
	/// </summary>
	public override string ResponseDialogPcFirefoxSecondInstruction(string startBold, string endBold)
	{
		return $"Vá para Downloads e dê um clique duplo em {startBold}RobloxPlayer.exe{endBold}";
	}

	protected override string _GetTemplateForResponseDialogPcFirefoxSecondInstruction()
	{
		return "Vá para Downloads e dê um clique duplo em {startBold}RobloxPlayer.exe{endBold}";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcFirefoxThirdInstruction"
	/// Click {startBold}Run{endBold}
	/// English String: "Click {startBold}Run{endBold}"
	/// </summary>
	public override string ResponseDialogPcFirefoxThirdInstruction(string startBold, string endBold)
	{
		return $"Clique em {startBold}Executar{endBold}.";
	}

	protected override string _GetTemplateForResponseDialogPcFirefoxThirdInstruction()
	{
		return "Clique em {startBold}Executar{endBold}.";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcIEFirstInstruction"
	/// You will receive a warning, click {startBold}Run{endBold}
	/// English String: "You will receive a warning, click {startBold}Run{endBold}"
	/// </summary>
	public override string ResponseDialogPcIEFirstInstruction(string startBold, string endBold)
	{
		return $"Você receberá um aviso. Clique em {startBold}Executar{endBold}.";
	}

	protected override string _GetTemplateForResponseDialogPcIEFirstInstruction()
	{
		return "Você receberá um aviso. Clique em {startBold}Executar{endBold}.";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcIeInstructionOne"
	/// You will receive a warning, click {startBold}Run{endBold}
	/// English String: "You will receive a warning, click {startBold}Run{endBold}"
	/// </summary>
	public override string ResponseDialogPcIeInstructionOne(string startBold, string endBold)
	{
		return $"Você receberá um aviso. Clique em {startBold}Executar{endBold}.";
	}

	protected override string _GetTemplateForResponseDialogPcIeInstructionOne()
	{
		return "Você receberá um aviso. Clique em {startBold}Executar{endBold}.";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcIeInstructionThree"
	/// Click {startBold}Run{endBold}
	/// English String: "Click {startBold}Run{endBold}"
	/// </summary>
	public override string ResponseDialogPcIeInstructionThree(string startBold, string endBold)
	{
		return $"Clique em {startBold}Executar{endBold}.";
	}

	protected override string _GetTemplateForResponseDialogPcIeInstructionThree()
	{
		return "Clique em {startBold}Executar{endBold}.";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcIeInstructionTwo"
	/// Go to Downloads and double click {startBold}RobloxPlayer.exe{endBold}
	/// English String: "Go to Downloads and double click {startBold}RobloxPlayer.exe{endBold}"
	/// </summary>
	public override string ResponseDialogPcIeInstructionTwo(string startBold, string endBold)
	{
		return $"Vá para Downloads e dê um clique duplo em {startBold}RobloxPlayer.exe{endBold}";
	}

	protected override string _GetTemplateForResponseDialogPcIeInstructionTwo()
	{
		return "Vá para Downloads e dê um clique duplo em {startBold}RobloxPlayer.exe{endBold}";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcIESecondInstruction"
	/// Click {startBold}Ok{endBold} once you've installed Roblox
	/// English String: "Click {startBold}Ok{endBold} once you've installed Roblox"
	/// </summary>
	public override string ResponseDialogPcIESecondInstruction(string startBold, string endBold)
	{
		return $"Clique em {startBold}Ok{endBold} depois de instalar o Roblox.";
	}

	protected override string _GetTemplateForResponseDialogPcIESecondInstruction()
	{
		return "Clique em {startBold}Ok{endBold} depois de instalar o Roblox.";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcIEThirdInstruction"
	/// Once installed, click {startBold}Play{endBold} to join the action!
	/// English String: "Once installed, click {startBold}Play{endBold} to join the action!"
	/// </summary>
	public override string ResponseDialogPcIEThirdInstruction(string startBold, string endBold)
	{
		return $"Depois de instalado, clique em {startBold}Jogar{endBold} para entrar na ação!";
	}

	protected override string _GetTemplateForResponseDialogPcIEThirdInstruction()
	{
		return "Depois de instalado, clique em {startBold}Jogar{endBold} para entrar na ação!";
	}

	protected override string _GetTemplateForResponseDialogThanksForPlayingRoblox()
	{
		return "Obrigado por jogar Roblox";
	}

	protected override string _GetTemplateForResponseGameTemporarilyUnavailable()
	{
		return "Impossível verificar seu acesso a este jogo. Tente de novo mais tarde.";
	}

	/// <summary>
	/// Key: "Response.RememberMyChoiceAppLaunch"
	/// Check {startBold}Remember my choice{endBold} and click {appLaunchLink} in the dialog box above to join games faster in the future!
	/// English String: "Check {startBold}Remember my choice{endBold} and click {appLaunchLink} in the dialog box above to join games faster in the future!"
	/// </summary>
	public override string ResponseRememberMyChoiceAppLaunch(string startBold, string endBold, string appLaunchLink)
	{
		return $"Selecione {startBold}Lembrar minha escolha{endBold} e clique em {appLaunchLink} na caixa de diálogo acima para entrar em jogos mais rápido no futuro!";
	}

	protected override string _GetTemplateForResponseRememberMyChoiceAppLaunch()
	{
		return "Selecione {startBold}Lembrar minha escolha{endBold} e clique em {appLaunchLink} na caixa de diálogo acima para entrar em jogos mais rápido no futuro!";
	}
}
