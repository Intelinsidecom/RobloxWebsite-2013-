namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides GameLaunchGuestModeResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class GameLaunchGuestModeResources_zh_cn : GameLaunchGuestModeResources_en_us, IGameLaunchGuestModeResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Dialog.Close"
	/// button text
	/// English String: "Close"
	/// </summary>
	public override string ActionDialogClose => "关闭";

	/// <summary>
	/// Key: "Action.Dialog.Login"
	/// button text
	/// English String: "Log In"
	/// </summary>
	public override string ActionDialogLogin => "登录";

	/// <summary>
	/// Key: "Action.Dialog.Ok"
	/// button text
	/// English String: "OK"
	/// </summary>
	public override string ActionDialogOk => "好";

	/// <summary>
	/// Key: "Action.Dialog.SignUp"
	/// button text
	/// English String: "Sign Up"
	/// </summary>
	public override string ActionDialogSignUp => "注册";

	/// <summary>
	/// Key: "Action.Dialog.SignUpNow"
	/// button text
	/// English String: "Sign up now!"
	/// </summary>
	public override string ActionDialogSignUpNow => "立即注册！";

	/// <summary>
	/// Key: "Description.Dialog.SignUpOrLogin"
	/// modal body text
	/// English String: "To play games, chat with friends, or customize your avatar, you'll need an account. Sign up for a free account or log in to play now."
	/// </summary>
	public override string DescriptionDialogSignUpOrLogin => "要开始游戏，和好友聊天，或是自定义你的虚拟形象，你需要一个帐户。注册一个免费帐户，或登录以立即开始游戏。";

	/// <summary>
	/// Key: "Description.Dialog.SignUpTodayOneDayRemaining"
	/// description text
	/// English String: "You are playing in guest mode. To use all features available on Roblox, you will need to create an account. You have less than a day left before we require free sign up."
	/// </summary>
	public override string DescriptionDialogSignUpTodayOneDayRemaining => "你正在以游客模式加入游戏。若要使用 Roblox 上可用的所有功能，你需要创建帐户。在我们要求免费注册之前，你还剩不到 1 天时间。";

	/// <summary>
	/// Key: "Description.Dialog.TrialOver"
	/// description
	/// English String: "Your trial period has ended. Please sign up to play games - it's free!"
	/// </summary>
	public override string DescriptionDialogTrialOver => "你的试玩期已结束。请先注册以开始游戏，是免费的哦！";

	/// <summary>
	/// Key: "Description.Dialog.YouArePlayingOneDayRemaining"
	/// description
	/// English String: "You are playing in guest mode. To use all features available on Roblox, you will need to create an account. You have 1 gameplay left before we require free sign up."
	/// </summary>
	public override string DescriptionDialogYouArePlayingOneDayRemaining => "你正在以游客模式加入游戏。若要使用 Roblox 上可用的所有功能，你需要创建帐户。在我们要求免费注册之前，你还剩 1 次游戏机会。";

	/// <summary>
	/// Key: "Heading.ChooseAvatar"
	/// modal heading
	/// English String: "Choose Your Avatar"
	/// </summary>
	public override string HeadingChooseAvatar => "选择你的虚拟形象";

	/// <summary>
	/// Key: "Heading.Dialog.SignUpOrLogin"
	/// modal heading
	/// English String: "Sign up for a free account or log in!"
	/// </summary>
	public override string HeadingDialogSignUpOrLogin => "注册免费帐户或登录！";

	/// <summary>
	/// Key: "Heading.Dialog.SignUpToday"
	/// modal heading
	/// English String: "Sign Up Today!"
	/// </summary>
	public override string HeadingDialogSignUpToday => "现在注册！";

	/// <summary>
	/// Key: "Label.HaveAccount"
	/// label
	/// English String: "I have an account"
	/// </summary>
	public override string LabelHaveAccount => "我已有帐户";

	public GameLaunchGuestModeResources_zh_cn(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionDialogClose()
	{
		return "关闭";
	}

	protected override string _GetTemplateForActionDialogLogin()
	{
		return "登录";
	}

	protected override string _GetTemplateForActionDialogOk()
	{
		return "好";
	}

	protected override string _GetTemplateForActionDialogSignUp()
	{
		return "注册";
	}

	protected override string _GetTemplateForActionDialogSignUpNow()
	{
		return "立即注册！";
	}

	protected override string _GetTemplateForDescriptionDialogSignUpOrLogin()
	{
		return "要开始游戏，和好友聊天，或是自定义你的虚拟形象，你需要一个帐户。注册一个免费帐户，或登录以立即开始游戏。";
	}

	protected override string _GetTemplateForDescriptionDialogSignUpTodayOneDayRemaining()
	{
		return "你正在以游客模式加入游戏。若要使用 Roblox 上可用的所有功能，你需要创建帐户。在我们要求免费注册之前，你还剩不到 1 天时间。";
	}

	/// <summary>
	/// Key: "Description.Dialog.SignUpTodaySomeDaysRemaining"
	/// description
	/// English String: "You are playing in guest mode. To use all features available on Roblox, you will need to create an account. You have less than {numDays} days left before we require free sign up."
	/// </summary>
	public override string DescriptionDialogSignUpTodaySomeDaysRemaining(string numDays)
	{
		return $"你正在以游客模式加入游戏。若要使用 Roblox 上可用的所有功能，你需要创建帐户。在我们要求免费注册之前，你还剩不到 {numDays} 天时间。";
	}

	protected override string _GetTemplateForDescriptionDialogSignUpTodaySomeDaysRemaining()
	{
		return "你正在以游客模式加入游戏。若要使用 Roblox 上可用的所有功能，你需要创建帐户。在我们要求免费注册之前，你还剩不到 {numDays} 天时间。";
	}

	protected override string _GetTemplateForDescriptionDialogTrialOver()
	{
		return "你的试玩期已结束。请先注册以开始游戏，是免费的哦！";
	}

	protected override string _GetTemplateForDescriptionDialogYouArePlayingOneDayRemaining()
	{
		return "你正在以游客模式加入游戏。若要使用 Roblox 上可用的所有功能，你需要创建帐户。在我们要求免费注册之前，你还剩 1 次游戏机会。";
	}

	/// <summary>
	/// Key: "Description.Dialog.YouArePlayingSomeDaysRemaining"
	/// description
	/// English String: "You are playing in guest mode. To use all features available on Roblox, you will need to create an account. You have {numDays} gameplays left before we require free sign up."
	/// </summary>
	public override string DescriptionDialogYouArePlayingSomeDaysRemaining(string numDays)
	{
		return $"你正在以游客模式加入游戏。若要使用 Roblox 上可用的所有功能，你需要创建帐户。在我们要求免费注册之前，你还剩 {numDays} 次游戏机会。";
	}

	protected override string _GetTemplateForDescriptionDialogYouArePlayingSomeDaysRemaining()
	{
		return "你正在以游客模式加入游戏。若要使用 Roblox 上可用的所有功能，你需要创建帐户。在我们要求免费注册之前，你还剩 {numDays} 次游戏机会。";
	}

	protected override string _GetTemplateForHeadingChooseAvatar()
	{
		return "选择你的虚拟形象";
	}

	protected override string _GetTemplateForHeadingDialogSignUpOrLogin()
	{
		return "注册免费帐户或登录！";
	}

	protected override string _GetTemplateForHeadingDialogSignUpToday()
	{
		return "现在注册！";
	}

	protected override string _GetTemplateForLabelHaveAccount()
	{
		return "我已有帐户";
	}
}
