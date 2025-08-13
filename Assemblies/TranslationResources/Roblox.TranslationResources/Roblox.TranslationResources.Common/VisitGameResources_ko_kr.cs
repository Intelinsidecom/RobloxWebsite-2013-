namespace Roblox.TranslationResources.Common;

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
	public override string ActionRetry => "다시 시도";

	/// <summary>
	/// Key: "Heading.ErrorStartingGame"
	/// Error starting game
	/// English String: "Error starting game"
	/// </summary>
	public override string HeadingErrorStartingGame => "게임 시작 중 오류 발생";

	/// <summary>
	/// Key: "Heading.SwitchToDesktopToPlay"
	/// Switch to Desktop Mode to Play Games
	/// English String: "Switch to Desktop Mode to Play Games"
	/// </summary>
	public override string HeadingSwitchToDesktopToPlay => "데스크톱 모드로 전환하여 게임 플레이";

	/// <summary>
	/// Key: "Label.Cancel"
	/// Cancel
	/// English String: "Cancel"
	/// </summary>
	public override string LabelCancel => "취소";

	/// <summary>
	/// Key: "Label.CheckingForStudio"
	/// We are checking if user has Roblox Studio installed
	/// English String: "Checking for Roblox Studio..."
	/// </summary>
	public override string LabelCheckingForStudio => "Roblox Studio 확인 중...";

	/// <summary>
	/// Key: "Label.ClickHereForHelp"
	/// Click here for help
	/// English String: "Click here for help"
	/// </summary>
	public override string LabelClickHereForHelp => "여기를 클릭하여 도움을 받아보세요";

	/// <summary>
	/// Key: "Label.ConnectingToPlayers"
	/// Joining a game network with other players
	/// English String: "Connecting to Players..."
	/// </summary>
	public override string LabelConnectingToPlayers => "플레이어와 연결 중...";

	/// <summary>
	/// Key: "Label.DevelopPageTitle"
	/// English String: "Develop"
	/// </summary>
	public override string LabelDevelopPageTitle => "게임 만들기";

	/// <summary>
	/// Key: "Label.DownloadInstallRoblox"
	/// Download and Install Roblox
	/// English String: "Download and Install Roblox"
	/// </summary>
	public override string LabelDownloadInstallRoblox => "Roblox 다운로드 및 설치";

	/// <summary>
	/// Key: "Label.DownloadStudio"
	/// Download Roblox Studio to start creating games
	/// English String: "Download Studio"
	/// </summary>
	public override string LabelDownloadStudio => "Studio 다운로드";

	/// <summary>
	/// Key: "Label.GameConfigurePageTitle"
	/// English String: "Game Configure"
	/// </summary>
	public override string LabelGameConfigurePageTitle => "게임 구성";

	/// <summary>
	/// Key: "Label.GameFreeSoothsayer"
	/// English String: "Free because you are a soothsayer"
	/// </summary>
	public override string LabelGameFreeSoothsayer => "회원님은 예언자이기 때문에 무료입니다";

	/// <summary>
	/// Key: "Label.GameUnavailableAccountResrictions"
	/// English String: "The game is unavailable due to account restrictions settings."
	/// </summary>
	public override string LabelGameUnavailableAccountResrictions => "계정 제한 설정 때문에 게임을 이용할 수 없습니다.";

	/// <summary>
	/// Key: "Label.GameUnavailableCannotPlayGamesStudio"
	/// English String: "You cannot play games from Studio. Please use a web browser to play this game."
	/// </summary>
	public override string LabelGameUnavailableCannotPlayGamesStudio => "Studio에서는 게임을 플레이할 수 없어요. 웹 브라우저를 사용하여 게임을 즐겨보세요.";

	/// <summary>
	/// Key: "Label.GameUnavailableClosedToVisitors"
	/// English String: "Sorry, this place is currently closed to visitors."
	/// </summary>
	public override string LabelGameUnavailableClosedToVisitors => "죄송합니다. 방문객은 현재 본 장소를 이용하실 수 없습니다";

	/// <summary>
	/// Key: "Label.GameUnavailableCurrentlyIsPrivateVisitor"
	/// When a game is private, this message is shown to visitors.
	/// English String: "Sorry, this game is private."
	/// </summary>
	public override string LabelGameUnavailableCurrentlyIsPrivateVisitor => "죄송합니다. 비공개 게임입니다.";

	/// <summary>
	/// Key: "Label.GameUnavailableGameInsecure"
	/// U13 users cannot play insecure games unless they are the creator or friends with the creator.
	/// English String: "Sorry, your account is restricted from playing Experimental Games unless you are friends with the creator."
	/// </summary>
	public override string LabelGameUnavailableGameInsecure => "죄송합니다. 개발자와 친구가 아니면 회원님의 계정으로는 실험 게임을 할 수 없습니다.";

	/// <summary>
	/// Key: "Label.GameUnavailablePermissionLevels"
	/// English String: "The permission levels on this place prevent you from entering."
	/// </summary>
	public override string LabelGameUnavailablePermissionLevels => "본 장소에 대한 권한 설정 때문에 입장할 수 없습니다.";

	/// <summary>
	/// Key: "Label.GameUnavailablePlaceUnderReview"
	/// English String: "Sorry, this place is currently under review. Try again later."
	/// </summary>
	public override string LabelGameUnavailablePlaceUnderReview => "죄송합니다. 본 장소는 현재 검토 중입니다. 나중에 다시 시도하세요.";

	/// <summary>
	/// Key: "Label.GameUnavailablePlatform"
	/// English String: "This game is not available on your platform.  Check the games page to see all playable games."
	/// </summary>
	public override string LabelGameUnavailablePlatform => "사용 중인 플랫폼이 지원하지 않는 게임입니다. 게임 페이지에서 플레이 가능한 게임들을 알아보세요.";

	/// <summary>
	/// Key: "Label.GameWarning"
	/// English String: "Warning"
	/// </summary>
	public override string LabelGameWarning => "주의";

	/// <summary>
	/// Key: "Label.InstallationInstructions"
	/// Installation Instructions
	/// English String: "Installation Instructions"
	/// </summary>
	public override string LabelInstallationInstructions => "설치 안내";

	/// <summary>
	/// Key: "Label.LaunchApplication"
	/// Launch Application
	/// English String: "Launch Application"
	/// </summary>
	public override string LabelLaunchApplication => "응용 프로그램 시작";

	/// <summary>
	/// Key: "Label.PersuadeToDevelopRoblox"
	/// Persuade user to begin developing their own games using Roblox Studio
	/// English String: "Get started creating your own games!"
	/// </summary>
	public override string LabelPersuadeToDevelopRoblox => "여러분만의 게임을 만들어보세요!";

	/// <summary>
	/// Key: "Label.PersuadeToInstallRoblox"
	/// We are exciting the user about Roblox so that they will be persuaded to download and install it.
	/// English String: "You're moments away from getting into the game!"
	/// </summary>
	public override string LabelPersuadeToInstallRoblox => "곧 게임이 시작됩니다!";

	/// <summary>
	/// Key: "Label.Play"
	/// English String: "Play"
	/// </summary>
	public override string LabelPlay => "플레이";

	/// <summary>
	/// Key: "Label.PlayInApp"
	/// English String: "Play in App"
	/// </summary>
	public override string LabelPlayInApp => "앱에서 플레이";

	/// <summary>
	/// Key: "Label.RobloxLoadingToPlay"
	/// Roblox is loading, so the user is getting excited to start playing a game
	/// English String: "Roblox is now loading. Get ready to play!"
	/// </summary>
	public override string LabelRobloxLoadingToPlay => "Roblox를 불러오는 중입니다. 게임을 즐길 준비 되셨나요?";

	/// <summary>
	/// Key: "Label.StartingRoblox"
	/// Game launch process has started
	/// English String: "Starting Roblox..."
	/// </summary>
	public override string LabelStartingRoblox => "Roblox 시작 중...";

	/// <summary>
	/// Key: "Label.SwitchToDesktopMode"
	/// Switch to Desktop Mode
	/// English String: "Switch to Desktop Mode"
	/// </summary>
	public override string LabelSwitchToDesktopMode => "데스크톱 모드로 전환";

	/// <summary>
	/// Key: "Label.UniverseConfigurePageTitle"
	/// The name of the universe configuration page
	/// English String: "Universe Configuration"
	/// </summary>
	public override string LabelUniverseConfigurePageTitle => "세계 구성";

	/// <summary>
	/// Key: "Response.Dialog.ClickHere"
	/// Click here!
	/// English String: "Click here!"
	/// </summary>
	public override string ResponseDialogClickHere => "여기를 클릭하세요!";

	/// <summary>
	/// Key: "Response.Dialog.ErrorLaunching"
	/// An error occurred trying to launch the game.  Please try again later.
	/// English String: "An error occurred trying to launch the game.  Please try again later."
	/// </summary>
	public override string ResponseDialogErrorLaunching => "게임 시작 중 오류가 발생했어요. 나중에 다시 시도하세요.";

	/// <summary>
	/// Key: "Response.Dialog.HavingTroubleInstallQuestion"
	/// (Are you) having trouble installing Roblox?
	/// English String: "Having trouble installing Roblox?"
	/// </summary>
	public override string ResponseDialogHavingTroubleInstallQuestion => "Roblox 설치에 어려움을 겪고 있나요?";

	/// <summary>
	/// Key: "Response.Dialog.MacChromeSecondInstruction"
	/// Double-click the Roblox app icon to begin the installation process.
	/// English String: "Double-click the Roblox app icon to begin the installation process."
	/// </summary>
	public override string ResponseDialogMacChromeSecondInstruction => "Roblox 앱 아이콘을 두 번 클릭하여 설치 과정을 시작하세요.";

	/// <summary>
	/// Key: "Response.Dialog.ThanksForPlayingRoblox"
	/// Thanks for playing Roblox
	/// English String: "Thanks for playing Roblox"
	/// </summary>
	public override string ResponseDialogThanksForPlayingRoblox => "Roblox를 이용해 주셔서 감사합니다";

	/// <summary>
	/// Key: "Response.GameTemporarilyUnavailable"
	/// error message (will be followed by link with Action.Retry label)
	/// English String: "Unable to verify that you have access to this game.  Please try again later."
	/// </summary>
	public override string ResponseGameTemporarilyUnavailable => "본 게임 이용권 보유 여부 확인 불가. 나중에 다시 시도하세요.";

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
		return $"{warning} 본 게임은 사용 중인 기기에서 잘 실행되지 않을 수도 있습니다.";
	}

	protected override string _GetTemplateForActionGamePerformPoorly()
	{
		return "{warning} 본 게임은 사용 중인 기기에서 잘 실행되지 않을 수도 있습니다.";
	}

	protected override string _GetTemplateForActionRetry()
	{
		return "다시 시도";
	}

	protected override string _GetTemplateForHeadingErrorStartingGame()
	{
		return "게임 시작 중 오류 발생";
	}

	protected override string _GetTemplateForHeadingSwitchToDesktopToPlay()
	{
		return "데스크톱 모드로 전환하여 게임 플레이";
	}

	/// <summary>
	/// Key: "Label.BuyAccess"
	/// English String: "Buy Access for {robux} Robux"
	/// </summary>
	public override string LabelBuyAccess(string robux)
	{
		return $"{robux} Robux 이용권 구매";
	}

	protected override string _GetTemplateForLabelBuyAccess()
	{
		return "{robux} Robux 이용권 구매";
	}

	protected override string _GetTemplateForLabelCancel()
	{
		return "취소";
	}

	protected override string _GetTemplateForLabelCheckingForStudio()
	{
		return "Roblox Studio 확인 중...";
	}

	protected override string _GetTemplateForLabelClickHereForHelp()
	{
		return "여기를 클릭하여 도움을 받아보세요";
	}

	protected override string _GetTemplateForLabelConnectingToPlayers()
	{
		return "플레이어와 연결 중...";
	}

	protected override string _GetTemplateForLabelDevelopPageTitle()
	{
		return "게임 만들기";
	}

	protected override string _GetTemplateForLabelDownloadInstallRoblox()
	{
		return "Roblox 다운로드 및 설치";
	}

	protected override string _GetTemplateForLabelDownloadStudio()
	{
		return "Studio 다운로드";
	}

	protected override string _GetTemplateForLabelGameConfigurePageTitle()
	{
		return "게임 구성";
	}

	protected override string _GetTemplateForLabelGameFreeSoothsayer()
	{
		return "회원님은 예언자이기 때문에 무료입니다";
	}

	/// <summary>
	/// Key: "Label.GameIsPrivatePlayableByGroupOnly"
	/// When a game is private, this message is shown to group developers with a link from where it can be made public.
	/// English String: "Only developers can play because this game is private. Make it public on the {linkStart}Configure Game{linkEnd} page."
	/// </summary>
	public override string LabelGameIsPrivatePlayableByGroupOnly(string linkStart, string linkEnd)
	{
		return $"비공개 게임은 개발자만 플레이할 수 있습니다. {linkStart}게임 구성{linkEnd} 페이지에서 공개로 변경하세요.";
	}

	protected override string _GetTemplateForLabelGameIsPrivatePlayableByGroupOnly()
	{
		return "비공개 게임은 개발자만 플레이할 수 있습니다. {linkStart}게임 구성{linkEnd} 페이지에서 공개로 변경하세요.";
	}

	/// <summary>
	/// Key: "Label.GameIsPrivatePlayableByOwnerOnly"
	/// When a game is private, this message is shown to owner with a link from where it can be made public.
	/// English String: "Only you can play because this game is private. Make it public on the {linkStart}Configure Game{linkEnd} page."
	/// </summary>
	public override string LabelGameIsPrivatePlayableByOwnerOnly(string linkStart, string linkEnd)
	{
		return $"비공개 게임은 본인만 플레이할 수 있습니다. {linkStart}게임 구성{linkEnd} 페이지에서 공개로 변경하세요.";
	}

	protected override string _GetTemplateForLabelGameIsPrivatePlayableByOwnerOnly()
	{
		return "비공개 게임은 본인만 플레이할 수 있습니다. {linkStart}게임 구성{linkEnd} 페이지에서 공개로 변경하세요.";
	}

	protected override string _GetTemplateForLabelGameUnavailableAccountResrictions()
	{
		return "계정 제한 설정 때문에 게임을 이용할 수 없습니다.";
	}

	protected override string _GetTemplateForLabelGameUnavailableCannotPlayGamesStudio()
	{
		return "Studio에서는 게임을 플레이할 수 없어요. 웹 브라우저를 사용하여 게임을 즐겨보세요.";
	}

	protected override string _GetTemplateForLabelGameUnavailableClosedToVisitors()
	{
		return "죄송합니다. 방문객은 현재 본 장소를 이용하실 수 없습니다";
	}

	/// <summary>
	/// Key: "Label.GameUnavailableCurrentlyIsPrivateGroup"
	/// When a game is private, this message is shown to group developers with a link from where it can be made public. Similar to an existing translation. Change is making the message directly address the group developers.
	/// English String: "Only developers can play because this game is private. Make it public on the {linkStart}Develop{linkEnd} page."
	/// </summary>
	public override string LabelGameUnavailableCurrentlyIsPrivateGroup(string linkStart, string linkEnd)
	{
		return $"비공개 게임은 개발자만 플레이할 수 있습니다. {linkStart}개발{linkEnd} 페이지에서 공개로 변경하세요.";
	}

	protected override string _GetTemplateForLabelGameUnavailableCurrentlyIsPrivateGroup()
	{
		return "비공개 게임은 개발자만 플레이할 수 있습니다. {linkStart}개발{linkEnd} 페이지에서 공개로 변경하세요.";
	}

	/// <summary>
	/// Key: "Label.GameUnavailableCurrentlyIsPrivateOwner"
	/// When a game is private, this message is shown to owner with a link from where it can be made public. Similar to an existing translation. Change is making the message directly address the owner.
	/// English String: "Only you can play because this game is private. Make it public on the {linkStart}Develop{linkEnd} page."
	/// </summary>
	public override string LabelGameUnavailableCurrentlyIsPrivateOwner(string linkStart, string linkEnd)
	{
		return $"비공개 게임은 본인만 플레이할 수 있습니다. {linkStart}개발{linkEnd} 페이지에서 공개로 변경하세요.";
	}

	protected override string _GetTemplateForLabelGameUnavailableCurrentlyIsPrivateOwner()
	{
		return "비공개 게임은 본인만 플레이할 수 있습니다. {linkStart}개발{linkEnd} 페이지에서 공개로 변경하세요.";
	}

	protected override string _GetTemplateForLabelGameUnavailableCurrentlyIsPrivateVisitor()
	{
		return "죄송합니다. 비공개 게임입니다.";
	}

	/// <summary>
	/// Key: "Label.GameUnavailableCurrentlyPrivate"
	/// When a game is private, this message is shown to user with link from where it can be made public
	/// English String: "This {gameTypeName} is currently private. Make it public on the {developPageLink} page to make it playable."
	/// </summary>
	public override string LabelGameUnavailableCurrentlyPrivate(string gameTypeName, string developPageLink)
	{
		return $"본 {gameTypeName}은(는) 현재 비공개 상태입니다. {developPageLink} 페이지에서 공개로 변경 후 플레이하세요.";
	}

	protected override string _GetTemplateForLabelGameUnavailableCurrentlyPrivate()
	{
		return "본 {gameTypeName}은(는) 현재 비공개 상태입니다. {developPageLink} 페이지에서 공개로 변경 후 플레이하세요.";
	}

	protected override string _GetTemplateForLabelGameUnavailableGameInsecure()
	{
		return "죄송합니다. 개발자와 친구가 아니면 회원님의 계정으로는 실험 게임을 할 수 없습니다.";
	}

	/// <summary>
	/// Key: "Label.GameUnavailableNoRootPlace"
	/// English String: "This place is part of a game that has no root place. Add a root place on the {gameConfigureLink} page to make it playable."
	/// </summary>
	public override string LabelGameUnavailableNoRootPlace(string gameConfigureLink)
	{
		return $"본 장소는 루트 플레이스가 없는 게임에 속해 있습니다. 플레이하려면 {gameConfigureLink} 페이지에서 루트 플레이스를 추가하세요.";
	}

	protected override string _GetTemplateForLabelGameUnavailableNoRootPlace()
	{
		return "본 장소는 루트 플레이스가 없는 게임에 속해 있습니다. 플레이하려면 {gameConfigureLink} 페이지에서 루트 플레이스를 추가하세요.";
	}

	protected override string _GetTemplateForLabelGameUnavailablePermissionLevels()
	{
		return "본 장소에 대한 권한 설정 때문에 입장할 수 없습니다.";
	}

	/// <summary>
	/// Key: "Label.GameUnavailablePlaceNotPartOfGame"
	/// English String: "This place is not currently part of a Game. Add it to a game on the {developPageLink} page to make it playable."
	/// </summary>
	public override string LabelGameUnavailablePlaceNotPartOfGame(string developPageLink)
	{
		return $"현재 게임에 포함되지 않은 장소입니다. {developPageLink}에서 게임에 추가한 후 플레이하세요.";
	}

	protected override string _GetTemplateForLabelGameUnavailablePlaceNotPartOfGame()
	{
		return "현재 게임에 포함되지 않은 장소입니다. {developPageLink}에서 게임에 추가한 후 플레이하세요.";
	}

	protected override string _GetTemplateForLabelGameUnavailablePlaceUnderReview()
	{
		return "죄송합니다. 본 장소는 현재 검토 중입니다. 나중에 다시 시도하세요.";
	}

	protected override string _GetTemplateForLabelGameUnavailablePlatform()
	{
		return "사용 중인 플랫폼이 지원하지 않는 게임입니다. 게임 페이지에서 플레이 가능한 게임들을 알아보세요.";
	}

	protected override string _GetTemplateForLabelGameWarning()
	{
		return "주의";
	}

	protected override string _GetTemplateForLabelInstallationInstructions()
	{
		return "설치 안내";
	}

	protected override string _GetTemplateForLabelLaunchApplication()
	{
		return "응용 프로그램 시작";
	}

	/// <summary>
	/// Key: "Label.OperaInstallSteps"
	/// 1) A window will open. Click Open2) Doubleclick the Roblox icon.
	/// English String: "1) A window will open. Click {startBold}Open{endBold}.{breakLine}2) Doubleclick the Roblox icon."
	/// </summary>
	public override string LabelOperaInstallSteps(string startBold, string endBold, string breakLine)
	{
		return $"1) 창이 열리면 {startBold}열기{endBold}를 클릭하세요.{breakLine}2) Roblox 아이콘을 더블 클릭하세요.";
	}

	protected override string _GetTemplateForLabelOperaInstallSteps()
	{
		return "1) 창이 열리면 {startBold}열기{endBold}를 클릭하세요.{breakLine}2) Roblox 아이콘을 더블 클릭하세요.";
	}

	protected override string _GetTemplateForLabelPersuadeToDevelopRoblox()
	{
		return "여러분만의 게임을 만들어보세요!";
	}

	protected override string _GetTemplateForLabelPersuadeToInstallRoblox()
	{
		return "곧 게임이 시작됩니다!";
	}

	protected override string _GetTemplateForLabelPlay()
	{
		return "플레이";
	}

	protected override string _GetTemplateForLabelPlayInApp()
	{
		return "앱에서 플레이";
	}

	protected override string _GetTemplateForLabelRobloxLoadingToPlay()
	{
		return "Roblox를 불러오는 중입니다. 게임을 즐길 준비 되셨나요?";
	}

	protected override string _GetTemplateForLabelStartingRoblox()
	{
		return "Roblox 시작 중...";
	}

	protected override string _GetTemplateForLabelSwitchToDesktopMode()
	{
		return "데스크톱 모드로 전환";
	}

	protected override string _GetTemplateForLabelUniverseConfigurePageTitle()
	{
		return "세계 구성";
	}

	/// <summary>
	/// Key: "Response.CheckAlwaysOpenRoblox"
	/// Check {startBold}Always open links for Roblox{endBold} and click {startBold2}Open Roblox{endBold2} in the dialog box above to join games faster in the future!
	/// English String: "Check {startBold}Always open links for Roblox{endBold} and click {startBold2}Open Roblox{endBold2} in the dialog box above to join games faster in the future!"
	/// </summary>
	public override string ResponseCheckAlwaysOpenRoblox(string startBold, string endBold, string startBold2, string endBold2)
	{
		return $"상단 대화 상자에서 {startBold}항상 Roblox 링크 열기{endBold}를 선택 후 {startBold2}Roblox 열기{endBold2}를 클릭하면 다음번에 게임을 더 빨리 시작할 수 있어요!";
	}

	protected override string _GetTemplateForResponseCheckAlwaysOpenRoblox()
	{
		return "상단 대화 상자에서 {startBold}항상 Roblox 링크 열기{endBold}를 선택 후 {startBold2}Roblox 열기{endBold2}를 클릭하면 다음번에 게임을 더 빨리 시작할 수 있어요!";
	}

	/// <summary>
	/// Key: "Response.CheckAlwaysOpenRobloxURL"
	/// Check {startBold}Always open links for URL: Roblox Protocol{endBold} and click {startBold}Open URL: Roblox Protocol{endBold} in the dialog box above to join games faster in the future!
	/// English String: "Check {startBold}Always open links for URL: Roblox Protocol{endBold} and click {startBold2}Open URL: Roblox Protocol{endBold2} in the dialog box above to join games faster in the future!"
	/// </summary>
	public override string ResponseCheckAlwaysOpenRobloxURL(string startBold, string endBold, string startBold2, string endBold2)
	{
		return $"상단 대화 상자에서 {startBold}항상 URL: Roblox Protocol 링크 열기{endBold}를 선택 후 {startBold2}URL: Roblox Protocol 열기{endBold2}를 클릭하면 다음번에 게임을 더 빨리 시작할 수 있어요!";
	}

	protected override string _GetTemplateForResponseCheckAlwaysOpenRobloxURL()
	{
		return "상단 대화 상자에서 {startBold}항상 URL: Roblox Protocol 링크 열기{endBold}를 선택 후 {startBold2}URL: Roblox Protocol 열기{endBold2}를 클릭하면 다음번에 게임을 더 빨리 시작할 수 있어요!";
	}

	/// <summary>
	/// Key: "Response.CheckRememberMyChoiceOK"
	/// Check Remember my choice and click OK in the dialog box above to join games faster in the future!
	/// English String: "Check {startBold}Remember my choice{endBold} and click {startBold2}OK{endBold2} in the dialog box above to join games faster in the future!"
	/// </summary>
	public override string ResponseCheckRememberMyChoiceOK(string startBold, string endBold, string startBold2, string endBold2)
	{
		return $"상단 대화 상자에서 {startBold}내 선택 기억하기{endBold}를 체크 후 {startBold2}확인{endBold2}을 클릭하면 다음번에 게임을 더 빨리 시작할 수 있어요!";
	}

	protected override string _GetTemplateForResponseCheckRememberMyChoiceOK()
	{
		return "상단 대화 상자에서 {startBold}내 선택 기억하기{endBold}를 체크 후 {startBold2}확인{endBold2}을 클릭하면 다음번에 게임을 더 빨리 시작할 수 있어요!";
	}

	protected override string _GetTemplateForResponseDialogClickHere()
	{
		return "여기를 클릭하세요!";
	}

	protected override string _GetTemplateForResponseDialogErrorLaunching()
	{
		return "게임 시작 중 오류가 발생했어요. 나중에 다시 시도하세요.";
	}

	protected override string _GetTemplateForResponseDialogHavingTroubleInstallQuestion()
	{
		return "Roblox 설치에 어려움을 겪고 있나요?";
	}

	/// <summary>
	/// Key: "Response.Dialog.InstallingMessageWithLink"
	/// Note: For this translation, please move the linkStart and linkEnd variables with the translation for download now.
	/// English String: "The Roblox installer should download shortly. If it doesn’t, start the {linkStart}download now.{linkEnd}"
	/// </summary>
	public override string ResponseDialogInstallingMessageWithLink(string linkStart, string linkEnd)
	{
		return $"Roblox 설치 프로그램의 다운로드가 곧 시작됩니다. 시작되지 않으면 {linkStart}지금 다운로드{linkEnd}를 클릭하세요.";
	}

	protected override string _GetTemplateForResponseDialogInstallingMessageWithLink()
	{
		return "Roblox 설치 프로그램의 다운로드가 곧 시작됩니다. 시작되지 않으면 {linkStart}지금 다운로드{linkEnd}를 클릭하세요.";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacChromeFifthInstruction"
	/// After installation, click {startBold}Play{endBold} below to join the action!
	/// English String: "After installation, click {startBold}Play{endBold} below to join the action!"
	/// </summary>
	public override string ResponseDialogMacChromeFifthInstruction(string startBold, string endBold)
	{
		return $"설치가 완료되면 하단의 {startBold}플레이{endBold} 버튼을 클릭하여 게임을 시작하세요!";
	}

	protected override string _GetTemplateForResponseDialogMacChromeFifthInstruction()
	{
		return "설치가 완료되면 하단의 {startBold}플레이{endBold} 버튼을 클릭하여 게임을 시작하세요!";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacChromeFirstInstruction"
	/// Click {startBold}Roblox.dmg{endBold} to run the Roblox installer, which just downloaded via your web browser.
	/// English String: "Click {startBold}Roblox.dmg{endBold} to run the Roblox installer, which just downloaded via your web browser."
	/// </summary>
	public override string ResponseDialogMacChromeFirstInstruction(string startBold, string endBold)
	{
		return $"방금 웹 브라우저를 통해 다운로드한 {startBold}Roblox.dmg{endBold}를 클릭하여 Roblox 설치 프로그램을 실행하세요.";
	}

	protected override string _GetTemplateForResponseDialogMacChromeFirstInstruction()
	{
		return "방금 웹 브라우저를 통해 다운로드한 {startBold}Roblox.dmg{endBold}를 클릭하여 Roblox 설치 프로그램을 실행하세요.";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacChromeFourthInstruction"
	/// Click {startBold}Ok{endBold} once you've successfully installed Roblox.
	/// English String: "Click {startBold}Ok{endBold} once you've successfully installed Roblox."
	/// </summary>
	public override string ResponseDialogMacChromeFourthInstruction(string startBold, string endBold)
	{
		return $"Roblox 설치가 완료되면 {startBold}확인{endBold}을 클릭하세요.";
	}

	protected override string _GetTemplateForResponseDialogMacChromeFourthInstruction()
	{
		return "Roblox 설치가 완료되면 {startBold}확인{endBold}을 클릭하세요.";
	}

	protected override string _GetTemplateForResponseDialogMacChromeSecondInstruction()
	{
		return "Roblox 앱 아이콘을 두 번 클릭하여 설치 과정을 시작하세요.";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacChromeThirdInstruction"
	/// Click {startBold}Open{endBold} when prompted by your computer.
	/// English String: "Click {startBold}Open{endBold} when prompted by your computer."
	/// </summary>
	public override string ResponseDialogMacChromeThirdInstruction(string startBold, string endBold)
	{
		return $"컴퓨터에 메시지가 표시되면 {startBold}열기{endBold}를 클릭하세요.";
	}

	protected override string _GetTemplateForResponseDialogMacChromeThirdInstruction()
	{
		return "컴퓨터에 메시지가 표시되면 {startBold}열기{endBold}를 클릭하세요.";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacFirefoxFifthInstruction"
	/// Then select the Remember my choice... checkbox and click OK
	/// English String: "Then select the {startBold}Remember my choice...{endBold} checkbox and click {startBold2}OK{endBold2}"
	/// </summary>
	public override string ResponseDialogMacFirefoxFifthInstruction(string startBold, string endBold, string startBold2, string endBold2)
	{
		return $"그 다음 {startBold}내 선택 기억하기...{endBold}를 선택 후 {startBold2}확인{endBold2}을 클릭하세요";
	}

	protected override string _GetTemplateForResponseDialogMacFirefoxFifthInstruction()
	{
		return "그 다음 {startBold}내 선택 기억하기...{endBold}를 선택 후 {startBold2}확인{endBold2}을 클릭하세요";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacFirefoxFirstInstruction"
	/// Select Open with and click OK
	/// English String: "Select {startBold}Open with{endBold} and click {startBold2}OK{endBold2}"
	/// </summary>
	public override string ResponseDialogMacFirefoxFirstInstruction(string startBold, string endBold, string startBold2, string endBold2)
	{
		return $"{startBold}다른 프로그램으로 열기{endBold}를 선택 후 {startBold2}확인{endBold2}을 클릭하세요";
	}

	protected override string _GetTemplateForResponseDialogMacFirefoxFirstInstruction()
	{
		return "{startBold}다른 프로그램으로 열기{endBold}를 선택 후 {startBold2}확인{endBold2}을 클릭하세요";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacFirefoxFourthInstruction"
	/// Once installed, click Play to join the action!
	/// English String: "Once installed, click {startBold}Play{endBold} to join the action!"
	/// </summary>
	public override string ResponseDialogMacFirefoxFourthInstruction(string startBold, string endBold)
	{
		return $"설치가 완료되면 {startBold}플레이{endBold} 버튼을 클릭하여 시작하세요!";
	}

	protected override string _GetTemplateForResponseDialogMacFirefoxFourthInstruction()
	{
		return "설치가 완료되면 {startBold}플레이{endBold} 버튼을 클릭하여 시작하세요!";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacFirefoxSecondInstruction"
	/// Double-click the Roblox Icon to begin the installation process
	/// English String: "Double-click the {startBold}Roblox Icon{endBold} to begin the installation process"
	/// </summary>
	public override string ResponseDialogMacFirefoxSecondInstruction(string startBold, string endBold)
	{
		return $"{startBold}Roblox 아이콘{endBold}을 더블 클릭하여 설치 과정을 시작하세요";
	}

	protected override string _GetTemplateForResponseDialogMacFirefoxSecondInstruction()
	{
		return "{startBold}Roblox 아이콘{endBold}을 더블 클릭하여 설치 과정을 시작하세요";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacFirefoxThirdInstruction"
	/// You will receive a warning, click Open
	/// English String: "You will receive a warning, click {startBold}Open{endBold}"
	/// </summary>
	public override string ResponseDialogMacFirefoxThirdInstruction(string startBold, string endBold)
	{
		return $"경고가 나타나면 {startBold}열기{endBold}를 클릭하세요";
	}

	protected override string _GetTemplateForResponseDialogMacFirefoxThirdInstruction()
	{
		return "경고가 나타나면 {startBold}열기{endBold}를 클릭하세요";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacSafariFirstInstruction"
	/// Go to Downloads and double-click Roblox.dmg
	/// English String: "Go to Downloads and double-click {startBold}Roblox.dmg{endBold}"
	/// </summary>
	public override string ResponseDialogMacSafariFirstInstruction(string startBold, string endBold)
	{
		return $"다운로드로 가서 {startBold}Roblox.dmg{endBold}를 더블 클릭하세요";
	}

	protected override string _GetTemplateForResponseDialogMacSafariFirstInstruction()
	{
		return "다운로드로 가서 {startBold}Roblox.dmg{endBold}를 더블 클릭하세요";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacSafariFourthInstruction"
	/// Once installed, click {startBold}Play{endBold} to join the action!
	/// English String: "Once installed, click {startBold}Play{endBold} to join the action!"
	/// </summary>
	public override string ResponseDialogMacSafariFourthInstruction(string startBold, string endBold)
	{
		return $"설치가 완료되면 {startBold}플레이{endBold}를 클릭하여 시작하세요!";
	}

	protected override string _GetTemplateForResponseDialogMacSafariFourthInstruction()
	{
		return "설치가 완료되면 {startBold}플레이{endBold}를 클릭하여 시작하세요!";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacSafariSecondInstruction"
	/// Double-click the {startBold}Roblox Icon{endBold} to begin the installation process
	/// English String: "Double-click the {startBold}Roblox Icon{endBold} to begin the installation process"
	/// </summary>
	public override string ResponseDialogMacSafariSecondInstruction(string startBold, string endBold)
	{
		return $"{startBold}Roblox 아이콘{endBold}을 더블 클릭하여 설치 과정을 시작하세요";
	}

	protected override string _GetTemplateForResponseDialogMacSafariSecondInstruction()
	{
		return "{startBold}Roblox 아이콘{endBold}을 더블 클릭하여 설치 과정을 시작하세요";
	}

	/// <summary>
	/// Key: "Response.Dialog.MacSafariThirdInstruction"
	/// You will receive a warning, click {startBold}Open{endBold}
	/// English String: "You will receive a warning, click {startBold}Open{endBold}"
	/// </summary>
	public override string ResponseDialogMacSafariThirdInstruction(string startBold, string endBold)
	{
		return $"경고가 나타나면 {startBold}열기{endBold}를 클릭하세요";
	}

	protected override string _GetTemplateForResponseDialogMacSafariThirdInstruction()
	{
		return "경고가 나타나면 {startBold}열기{endBold}를 클릭하세요";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcChromeFirstInstruction"
	/// Click {startBold}RobloxPlayer.exe{endBold} to run the Roblox installer, which just downloaded via your web browser.
	/// English String: "Click {startBold}RobloxPlayer.exe{endBold} to run the Roblox installer, which just downloaded via your web browser."
	/// </summary>
	public override string ResponseDialogPcChromeFirstInstruction(string startBold, string endBold)
	{
		return $"방금 웹 브라우저를 통해 다운로드한 {startBold}RobloxPlayer.exe{endBold}를 클릭하여 Roblox 설치 프로그램을 실행하세요.";
	}

	protected override string _GetTemplateForResponseDialogPcChromeFirstInstruction()
	{
		return "방금 웹 브라우저를 통해 다운로드한 {startBold}RobloxPlayer.exe{endBold}를 클릭하여 Roblox 설치 프로그램을 실행하세요.";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcChromeFourthInstruction"
	/// After installation, click {startBold}Play{endBold} below to join the action!
	/// English String: "After installation, click {startBold}Play{endBold} below to join the action!"
	/// </summary>
	public override string ResponseDialogPcChromeFourthInstruction(string startBold, string endBold)
	{
		return $"설치가 완료되면 하단의 {startBold}플레이{endBold} 버튼을 클릭하여 게임을 시작하세요!";
	}

	protected override string _GetTemplateForResponseDialogPcChromeFourthInstruction()
	{
		return "설치가 완료되면 하단의 {startBold}플레이{endBold} 버튼을 클릭하여 게임을 시작하세요!";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcChromeSecondInstruction"
	/// Click {startBold}Run{endBold} when prompted by your computer to begin the installation process.
	/// English String: "Click {startBold}Run{endBold} when prompted by your computer to begin the installation process."
	/// </summary>
	public override string ResponseDialogPcChromeSecondInstruction(string startBold, string endBold)
	{
		return $"컴퓨터에 메시지가 표시되면 {startBold}실행{endBold}을 클릭하여 설치 과정을 시작하세요.";
	}

	protected override string _GetTemplateForResponseDialogPcChromeSecondInstruction()
	{
		return "컴퓨터에 메시지가 표시되면 {startBold}실행{endBold}을 클릭하여 설치 과정을 시작하세요.";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcChromeThirdInstruction"
	/// Click {startBold}Ok{endBold} once you've successfully installed Roblox.
	/// English String: "Click {startBold}Ok{endBold} once you've successfully installed Roblox."
	/// </summary>
	public override string ResponseDialogPcChromeThirdInstruction(string startBold, string endBold)
	{
		return $"Roblox 설치가 완료되면 {startBold}확인{endBold}을 클릭하세요.";
	}

	protected override string _GetTemplateForResponseDialogPcChromeThirdInstruction()
	{
		return "Roblox 설치가 완료되면 {startBold}확인{endBold}을 클릭하세요.";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcEdgeFirstInstruction"
	/// Click {startBold}Run{endBold} to install Roblox after the download finishes
	/// English String: "Click {startBold}Run{endBold} to install Roblox after the download finishes"
	/// </summary>
	public override string ResponseDialogPcEdgeFirstInstruction(string startBold, string endBold)
	{
		return $"다운로드가 끝나면 {startBold}실행{endBold}을 클릭하여 Roblox를 설치하세요";
	}

	protected override string _GetTemplateForResponseDialogPcEdgeFirstInstruction()
	{
		return "다운로드가 끝나면 {startBold}실행{endBold}을 클릭하여 Roblox를 설치하세요";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcEdgeSecondInstruction"
	/// Click {startBold}Ok{endBold} to finish installing Roblox
	/// English String: "Click {startBold}Ok{endBold} to finish installing Roblox"
	/// </summary>
	public override string ResponseDialogPcEdgeSecondInstruction(string startBold, string endBold)
	{
		return $"{startBold}확인{endBold}을 클릭하여 Roblox 설치를 종료하세요";
	}

	protected override string _GetTemplateForResponseDialogPcEdgeSecondInstruction()
	{
		return "{startBold}확인{endBold}을 클릭하여 Roblox 설치를 종료하세요";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcEdgeThirdInstruction"
	/// Click the {startBold}Play{endBold} button to join the action!
	/// English String: "Click the {startBold}Play{endBold} button to join the action!"
	/// </summary>
	public override string ResponseDialogPcEdgeThirdInstruction(string startBold, string endBold)
	{
		return $"{startBold}플레이{endBold} 버튼을 클릭하여 게임을 시작하세요!";
	}

	protected override string _GetTemplateForResponseDialogPcEdgeThirdInstruction()
	{
		return "{startBold}플레이{endBold} 버튼을 클릭하여 게임을 시작하세요!";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcFirefoxFifthInstruction"
	/// Click {startBold}Ok{endBold} when the alert pops up
	/// English String: "Click {startBold}Ok{endBold} when the alert pops up"
	/// </summary>
	public override string ResponseDialogPcFirefoxFifthInstruction(string startBold, string endBold)
	{
		return $"경고가 나타나면 {startBold}확인{endBold}을 클릭하세요";
	}

	protected override string _GetTemplateForResponseDialogPcFirefoxFifthInstruction()
	{
		return "경고가 나타나면 {startBold}확인{endBold}을 클릭하세요";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcFirefoxFirstInstruction"
	/// Click {startBold}Save File{endBold} when the download window pops up
	/// English String: "Click {startBold}Save File{endBold} when the download window pops up"
	/// </summary>
	public override string ResponseDialogPcFirefoxFirstInstruction(string startBold, string endBold)
	{
		return $"다운로드 창이 나타나면 {startBold}파일 저장{endBold}을 클릭하세요";
	}

	protected override string _GetTemplateForResponseDialogPcFirefoxFirstInstruction()
	{
		return "다운로드 창이 나타나면 {startBold}파일 저장{endBold}을 클릭하세요";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcFirefoxFourthInstruction"
	/// Once installed, click {startBold}Play{endBold} to join the action!
	/// English String: "Once installed, click {startBold}Play{endBold} to join the action!"
	/// </summary>
	public override string ResponseDialogPcFirefoxFourthInstruction(string startBold, string endBold)
	{
		return $"설치가 완료되면 {startBold}플레이{endBold} 버튼을 클릭하여 게임을 시작하세요!";
	}

	protected override string _GetTemplateForResponseDialogPcFirefoxFourthInstruction()
	{
		return "설치가 완료되면 {startBold}플레이{endBold} 버튼을 클릭하여 게임을 시작하세요!";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcFirefoxSecondInstruction"
	/// Go to Downloads and double click {startBold}RobloxPlayer.exe{endBold}
	/// English String: "Go to Downloads and double click {startBold}RobloxPlayer.exe{endBold}"
	/// </summary>
	public override string ResponseDialogPcFirefoxSecondInstruction(string startBold, string endBold)
	{
		return $"다운로드로 가서 {startBold}RobloxPlayer.exe{endBold}를 더블 클릭하세요";
	}

	protected override string _GetTemplateForResponseDialogPcFirefoxSecondInstruction()
	{
		return "다운로드로 가서 {startBold}RobloxPlayer.exe{endBold}를 더블 클릭하세요";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcFirefoxThirdInstruction"
	/// Click {startBold}Run{endBold}
	/// English String: "Click {startBold}Run{endBold}"
	/// </summary>
	public override string ResponseDialogPcFirefoxThirdInstruction(string startBold, string endBold)
	{
		return $"{startBold}실행{endBold}을 클릭하세요";
	}

	protected override string _GetTemplateForResponseDialogPcFirefoxThirdInstruction()
	{
		return "{startBold}실행{endBold}을 클릭하세요";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcIEFirstInstruction"
	/// You will receive a warning, click {startBold}Run{endBold}
	/// English String: "You will receive a warning, click {startBold}Run{endBold}"
	/// </summary>
	public override string ResponseDialogPcIEFirstInstruction(string startBold, string endBold)
	{
		return $"경고가 나타나면 {startBold}실행{endBold}을 클릭하세요";
	}

	protected override string _GetTemplateForResponseDialogPcIEFirstInstruction()
	{
		return "경고가 나타나면 {startBold}실행{endBold}을 클릭하세요";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcIeInstructionOne"
	/// You will receive a warning, click {startBold}Run{endBold}
	/// English String: "You will receive a warning, click {startBold}Run{endBold}"
	/// </summary>
	public override string ResponseDialogPcIeInstructionOne(string startBold, string endBold)
	{
		return $"경고가 나타나면 {startBold}실행{endBold}을 클릭하세요";
	}

	protected override string _GetTemplateForResponseDialogPcIeInstructionOne()
	{
		return "경고가 나타나면 {startBold}실행{endBold}을 클릭하세요";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcIeInstructionThree"
	/// Click {startBold}Run{endBold}
	/// English String: "Click {startBold}Run{endBold}"
	/// </summary>
	public override string ResponseDialogPcIeInstructionThree(string startBold, string endBold)
	{
		return $"{startBold}실행{endBold}을 클릭하세요";
	}

	protected override string _GetTemplateForResponseDialogPcIeInstructionThree()
	{
		return "{startBold}실행{endBold}을 클릭하세요";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcIeInstructionTwo"
	/// Go to Downloads and double click {startBold}RobloxPlayer.exe{endBold}
	/// English String: "Go to Downloads and double click {startBold}RobloxPlayer.exe{endBold}"
	/// </summary>
	public override string ResponseDialogPcIeInstructionTwo(string startBold, string endBold)
	{
		return $"다운로드로 가서 {startBold}RobloxPlayer.exe{endBold}를 더블 클릭하세요";
	}

	protected override string _GetTemplateForResponseDialogPcIeInstructionTwo()
	{
		return "다운로드로 가서 {startBold}RobloxPlayer.exe{endBold}를 더블 클릭하세요";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcIESecondInstruction"
	/// Click {startBold}Ok{endBold} once you've installed Roblox
	/// English String: "Click {startBold}Ok{endBold} once you've installed Roblox"
	/// </summary>
	public override string ResponseDialogPcIESecondInstruction(string startBold, string endBold)
	{
		return $"Roblox 설치가 완료되면 {startBold}확인{endBold}을 클릭하세요.";
	}

	protected override string _GetTemplateForResponseDialogPcIESecondInstruction()
	{
		return "Roblox 설치가 완료되면 {startBold}확인{endBold}을 클릭하세요.";
	}

	/// <summary>
	/// Key: "Response.Dialog.PcIEThirdInstruction"
	/// Once installed, click {startBold}Play{endBold} to join the action!
	/// English String: "Once installed, click {startBold}Play{endBold} to join the action!"
	/// </summary>
	public override string ResponseDialogPcIEThirdInstruction(string startBold, string endBold)
	{
		return $"설치가 완료되면 {startBold}플레이{endBold} 버튼을 클릭하여 게임을 시작하세요!";
	}

	protected override string _GetTemplateForResponseDialogPcIEThirdInstruction()
	{
		return "설치가 완료되면 {startBold}플레이{endBold} 버튼을 클릭하여 게임을 시작하세요!";
	}

	protected override string _GetTemplateForResponseDialogThanksForPlayingRoblox()
	{
		return "Roblox를 이용해 주셔서 감사합니다";
	}

	protected override string _GetTemplateForResponseGameTemporarilyUnavailable()
	{
		return "본 게임 이용권 보유 여부 확인 불가. 나중에 다시 시도하세요.";
	}

	/// <summary>
	/// Key: "Response.RememberMyChoiceAppLaunch"
	/// Check {startBold}Remember my choice{endBold} and click {appLaunchLink} in the dialog box above to join games faster in the future!
	/// English String: "Check {startBold}Remember my choice{endBold} and click {appLaunchLink} in the dialog box above to join games faster in the future!"
	/// </summary>
	public override string ResponseRememberMyChoiceAppLaunch(string startBold, string endBold, string appLaunchLink)
	{
		return $"상단 대화 상자에서 {startBold}내 선택 기억하기{endBold}를 체크 후 {appLaunchLink}을 클릭하면 다음번에 게임을 더 빨리 시작할 수 있어요!";
	}

	protected override string _GetTemplateForResponseRememberMyChoiceAppLaunch()
	{
		return "상단 대화 상자에서 {startBold}내 선택 기억하기{endBold}를 체크 후 {appLaunchLink}을 클릭하면 다음번에 게임을 더 빨리 시작할 수 있어요!";
	}
}
