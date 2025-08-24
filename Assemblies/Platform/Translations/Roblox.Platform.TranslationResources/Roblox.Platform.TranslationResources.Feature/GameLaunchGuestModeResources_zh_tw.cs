namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides GameLaunchGuestModeResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class GameLaunchGuestModeResources_zh_tw : GameLaunchGuestModeResources_en_us, IGameLaunchGuestModeResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Dialog.Close"
	/// button text
	/// English String: "Close"
	/// </summary>
	public override string ActionDialogClose => "關閉";

	/// <summary>
	/// Key: "Action.Dialog.Login"
	/// button text
	/// English String: "Log In"
	/// </summary>
	public override string ActionDialogLogin => "登入";

	/// <summary>
	/// Key: "Action.Dialog.Ok"
	/// button text
	/// English String: "OK"
	/// </summary>
	public override string ActionDialogOk => "確定";

	/// <summary>
	/// Key: "Action.Dialog.SignUp"
	/// button text
	/// English String: "Sign Up"
	/// </summary>
	public override string ActionDialogSignUp => "註冊";

	/// <summary>
	/// Key: "Action.Dialog.SignUpNow"
	/// button text
	/// English String: "Sign up now!"
	/// </summary>
	public override string ActionDialogSignUpNow => "現在註冊！";

	/// <summary>
	/// Key: "Description.Dialog.SignUpOrLogin"
	/// modal body text
	/// English String: "To play games, chat with friends, or customize your avatar, you'll need an account. Sign up for a free account or log in to play now."
	/// </summary>
	public override string DescriptionDialogSignUpOrLogin => "您需要申請帳號才可以玩遊戲、與好友聊天及自訂您的虛擬人偶。登入或註冊免費帳號，馬上開始玩。";

	/// <summary>
	/// Key: "Description.Dialog.SignUpTodayOneDayRemaining"
	/// description text
	/// English String: "You are playing in guest mode. To use all features available on Roblox, you will need to create an account. You have less than a day left before we require free sign up."
	/// </summary>
	public override string DescriptionDialogSignUpTodayOneDayRemaining => "您正在以訪客模式遊玩。若要使用所有 Roblox 功能，您將需要建立帳號。在需要免費註冊之前，您還可以玩一天。";

	/// <summary>
	/// Key: "Description.Dialog.TrialOver"
	/// description
	/// English String: "Your trial period has ended. Please sign up to play games - it's free!"
	/// </summary>
	public override string DescriptionDialogTrialOver => "您的試用期已結束，請註冊免費帳號繼續玩。";

	/// <summary>
	/// Key: "Description.Dialog.YouArePlayingOneDayRemaining"
	/// description
	/// English String: "You are playing in guest mode. To use all features available on Roblox, you will need to create an account. You have 1 gameplay left before we require free sign up."
	/// </summary>
	public override string DescriptionDialogYouArePlayingOneDayRemaining => "您正在以訪客模式遊玩。若要使用所有 Roblox 功能，您將需要建立帳號。在需要免費註冊之前，您還可以遊玩一次。";

	/// <summary>
	/// Key: "Heading.ChooseAvatar"
	/// modal heading
	/// English String: "Choose Your Avatar"
	/// </summary>
	public override string HeadingChooseAvatar => "選擇您的虛擬人偶";

	/// <summary>
	/// Key: "Heading.Dialog.SignUpOrLogin"
	/// modal heading
	/// English String: "Sign up for a free account or log in!"
	/// </summary>
	public override string HeadingDialogSignUpOrLogin => "登入或註冊免費帳號！";

	/// <summary>
	/// Key: "Heading.Dialog.SignUpToday"
	/// modal heading
	/// English String: "Sign Up Today!"
	/// </summary>
	public override string HeadingDialogSignUpToday => "現在註冊！";

	/// <summary>
	/// Key: "Label.HaveAccount"
	/// label
	/// English String: "I have an account"
	/// </summary>
	public override string LabelHaveAccount => "我有帳號";

	public GameLaunchGuestModeResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionDialogClose()
	{
		return "關閉";
	}

	protected override string _GetTemplateForActionDialogLogin()
	{
		return "登入";
	}

	protected override string _GetTemplateForActionDialogOk()
	{
		return "確定";
	}

	protected override string _GetTemplateForActionDialogSignUp()
	{
		return "註冊";
	}

	protected override string _GetTemplateForActionDialogSignUpNow()
	{
		return "現在註冊！";
	}

	protected override string _GetTemplateForDescriptionDialogSignUpOrLogin()
	{
		return "您需要申請帳號才可以玩遊戲、與好友聊天及自訂您的虛擬人偶。登入或註冊免費帳號，馬上開始玩。";
	}

	protected override string _GetTemplateForDescriptionDialogSignUpTodayOneDayRemaining()
	{
		return "您正在以訪客模式遊玩。若要使用所有 Roblox 功能，您將需要建立帳號。在需要免費註冊之前，您還可以玩一天。";
	}

	/// <summary>
	/// Key: "Description.Dialog.SignUpTodaySomeDaysRemaining"
	/// description
	/// English String: "You are playing in guest mode. To use all features available on Roblox, you will need to create an account. You have less than {numDays} days left before we require free sign up."
	/// </summary>
	public override string DescriptionDialogSignUpTodaySomeDaysRemaining(string numDays)
	{
		return $"您正在以訪客模式遊玩。若要使用所有 Roblox 功能，您將需要建立帳號。在需要免費註冊之前，您還可以玩 {numDays} 天。";
	}

	protected override string _GetTemplateForDescriptionDialogSignUpTodaySomeDaysRemaining()
	{
		return "您正在以訪客模式遊玩。若要使用所有 Roblox 功能，您將需要建立帳號。在需要免費註冊之前，您還可以玩 {numDays} 天。";
	}

	protected override string _GetTemplateForDescriptionDialogTrialOver()
	{
		return "您的試用期已結束，請註冊免費帳號繼續玩。";
	}

	protected override string _GetTemplateForDescriptionDialogYouArePlayingOneDayRemaining()
	{
		return "您正在以訪客模式遊玩。若要使用所有 Roblox 功能，您將需要建立帳號。在需要免費註冊之前，您還可以遊玩一次。";
	}

	/// <summary>
	/// Key: "Description.Dialog.YouArePlayingSomeDaysRemaining"
	/// description
	/// English String: "You are playing in guest mode. To use all features available on Roblox, you will need to create an account. You have {numDays} gameplays left before we require free sign up."
	/// </summary>
	public override string DescriptionDialogYouArePlayingSomeDaysRemaining(string numDays)
	{
		return $"您正在以訪客模式遊玩。若要使用所有 Roblox 功能，您將需要建立帳號。在需要免費註冊之前，您還可以遊玩 {numDays} 次。";
	}

	protected override string _GetTemplateForDescriptionDialogYouArePlayingSomeDaysRemaining()
	{
		return "您正在以訪客模式遊玩。若要使用所有 Roblox 功能，您將需要建立帳號。在需要免費註冊之前，您還可以遊玩 {numDays} 次。";
	}

	protected override string _GetTemplateForHeadingChooseAvatar()
	{
		return "選擇您的虛擬人偶";
	}

	protected override string _GetTemplateForHeadingDialogSignUpOrLogin()
	{
		return "登入或註冊免費帳號！";
	}

	protected override string _GetTemplateForHeadingDialogSignUpToday()
	{
		return "現在註冊！";
	}

	protected override string _GetTemplateForLabelHaveAccount()
	{
		return "我有帳號";
	}
}
