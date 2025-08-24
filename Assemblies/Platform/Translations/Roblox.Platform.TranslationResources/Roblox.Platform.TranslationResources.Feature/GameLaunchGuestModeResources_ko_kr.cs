namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides GameLaunchGuestModeResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class GameLaunchGuestModeResources_ko_kr : GameLaunchGuestModeResources_en_us, IGameLaunchGuestModeResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Dialog.Close"
	/// button text
	/// English String: "Close"
	/// </summary>
	public override string ActionDialogClose => "닫기";

	/// <summary>
	/// Key: "Action.Dialog.Login"
	/// button text
	/// English String: "Log In"
	/// </summary>
	public override string ActionDialogLogin => "로그인";

	/// <summary>
	/// Key: "Action.Dialog.Ok"
	/// button text
	/// English String: "OK"
	/// </summary>
	public override string ActionDialogOk => "확인";

	/// <summary>
	/// Key: "Action.Dialog.SignUp"
	/// button text
	/// English String: "Sign Up"
	/// </summary>
	public override string ActionDialogSignUp => "회원가입";

	/// <summary>
	/// Key: "Action.Dialog.SignUpNow"
	/// button text
	/// English String: "Sign up now!"
	/// </summary>
	public override string ActionDialogSignUpNow => "지금 회원가입하세요!";

	/// <summary>
	/// Key: "Description.Dialog.SignUpOrLogin"
	/// modal body text
	/// English String: "To play games, chat with friends, or customize your avatar, you'll need an account. Sign up for a free account or log in to play now."
	/// </summary>
	public override string DescriptionDialogSignUpOrLogin => "계정이 있어야 게임, 채팅, 아바타 꾸미기를 즐길 수 있어요. 회원가입(무료)하거나 계정이 있으신 분은 로그인하여 지금 게임을 즐겨보세요!";

	/// <summary>
	/// Key: "Description.Dialog.SignUpTodayOneDayRemaining"
	/// description text
	/// English String: "You are playing in guest mode. To use all features available on Roblox, you will need to create an account. You have less than a day left before we require free sign up."
	/// </summary>
	public override string DescriptionDialogSignUpTodayOneDayRemaining => "게스트 모드로 플레이 중입니다. Roblox의 모든 기능을 사용하려면 계정을 만들어야 해요. 게스트 모드 이용이 24시간 내에 만료되니 회원가입(무료)하세요.";

	/// <summary>
	/// Key: "Description.Dialog.TrialOver"
	/// description
	/// English String: "Your trial period has ended. Please sign up to play games - it's free!"
	/// </summary>
	public override string DescriptionDialogTrialOver => "체험 기간이 종료되었습니다. 회원가입(무료)하시고 게임을 계속 즐겨보세요!";

	/// <summary>
	/// Key: "Description.Dialog.YouArePlayingOneDayRemaining"
	/// description
	/// English String: "You are playing in guest mode. To use all features available on Roblox, you will need to create an account. You have 1 gameplay left before we require free sign up."
	/// </summary>
	public override string DescriptionDialogYouArePlayingOneDayRemaining => "게스트 모드로 플레이 중입니다. Roblox의 모든 기능을 사용하려면 계정을 만들어야 해요. 1번 플레이한 후에는 회원가입(무료)을 해야 합니다.";

	/// <summary>
	/// Key: "Heading.ChooseAvatar"
	/// modal heading
	/// English String: "Choose Your Avatar"
	/// </summary>
	public override string HeadingChooseAvatar => "아바타를 선택하세요";

	/// <summary>
	/// Key: "Heading.Dialog.SignUpOrLogin"
	/// modal heading
	/// English String: "Sign up for a free account or log in!"
	/// </summary>
	public override string HeadingDialogSignUpOrLogin => "회원가입(무료)을 통해 계정을 만들거나 로그인하세요!";

	/// <summary>
	/// Key: "Heading.Dialog.SignUpToday"
	/// modal heading
	/// English String: "Sign Up Today!"
	/// </summary>
	public override string HeadingDialogSignUpToday => "지금 회원가입하세요!";

	/// <summary>
	/// Key: "Label.HaveAccount"
	/// label
	/// English String: "I have an account"
	/// </summary>
	public override string LabelHaveAccount => "계정이 있습니다";

	public GameLaunchGuestModeResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionDialogClose()
	{
		return "닫기";
	}

	protected override string _GetTemplateForActionDialogLogin()
	{
		return "로그인";
	}

	protected override string _GetTemplateForActionDialogOk()
	{
		return "확인";
	}

	protected override string _GetTemplateForActionDialogSignUp()
	{
		return "회원가입";
	}

	protected override string _GetTemplateForActionDialogSignUpNow()
	{
		return "지금 회원가입하세요!";
	}

	protected override string _GetTemplateForDescriptionDialogSignUpOrLogin()
	{
		return "계정이 있어야 게임, 채팅, 아바타 꾸미기를 즐길 수 있어요. 회원가입(무료)하거나 계정이 있으신 분은 로그인하여 지금 게임을 즐겨보세요!";
	}

	protected override string _GetTemplateForDescriptionDialogSignUpTodayOneDayRemaining()
	{
		return "게스트 모드로 플레이 중입니다. Roblox의 모든 기능을 사용하려면 계정을 만들어야 해요. 게스트 모드 이용이 24시간 내에 만료되니 회원가입(무료)하세요.";
	}

	/// <summary>
	/// Key: "Description.Dialog.SignUpTodaySomeDaysRemaining"
	/// description
	/// English String: "You are playing in guest mode. To use all features available on Roblox, you will need to create an account. You have less than {numDays} days left before we require free sign up."
	/// </summary>
	public override string DescriptionDialogSignUpTodaySomeDaysRemaining(string numDays)
	{
		return $"게스트 모드로 플레이 중입니다. Roblox의 모든 기능을 사용하려면 계정을 만들어야 해요. 게스트 모드 이용이 {numDays}내에 만료되니 회원가입(무료)하세요.";
	}

	protected override string _GetTemplateForDescriptionDialogSignUpTodaySomeDaysRemaining()
	{
		return "게스트 모드로 플레이 중입니다. Roblox의 모든 기능을 사용하려면 계정을 만들어야 해요. 게스트 모드 이용이 {numDays}내에 만료되니 회원가입(무료)하세요.";
	}

	protected override string _GetTemplateForDescriptionDialogTrialOver()
	{
		return "체험 기간이 종료되었습니다. 회원가입(무료)하시고 게임을 계속 즐겨보세요!";
	}

	protected override string _GetTemplateForDescriptionDialogYouArePlayingOneDayRemaining()
	{
		return "게스트 모드로 플레이 중입니다. Roblox의 모든 기능을 사용하려면 계정을 만들어야 해요. 1번 플레이한 후에는 회원가입(무료)을 해야 합니다.";
	}

	/// <summary>
	/// Key: "Description.Dialog.YouArePlayingSomeDaysRemaining"
	/// description
	/// English String: "You are playing in guest mode. To use all features available on Roblox, you will need to create an account. You have {numDays} gameplays left before we require free sign up."
	/// </summary>
	public override string DescriptionDialogYouArePlayingSomeDaysRemaining(string numDays)
	{
		return $"게스트 모드로 플레이 중입니다. Roblox의 모든 기능을 사용하려면 계정을 만들어야 해요. {numDays}일 플레이한 후에는 회원가입(무료)을 해야 합니다.";
	}

	protected override string _GetTemplateForDescriptionDialogYouArePlayingSomeDaysRemaining()
	{
		return "게스트 모드로 플레이 중입니다. Roblox의 모든 기능을 사용하려면 계정을 만들어야 해요. {numDays}일 플레이한 후에는 회원가입(무료)을 해야 합니다.";
	}

	protected override string _GetTemplateForHeadingChooseAvatar()
	{
		return "아바타를 선택하세요";
	}

	protected override string _GetTemplateForHeadingDialogSignUpOrLogin()
	{
		return "회원가입(무료)을 통해 계정을 만들거나 로그인하세요!";
	}

	protected override string _GetTemplateForHeadingDialogSignUpToday()
	{
		return "지금 회원가입하세요!";
	}

	protected override string _GetTemplateForLabelHaveAccount()
	{
		return "계정이 있습니다";
	}
}
