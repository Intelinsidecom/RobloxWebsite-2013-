namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides GameLaunchGuestModeResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class GameLaunchGuestModeResources_ja_jp : GameLaunchGuestModeResources_en_us, IGameLaunchGuestModeResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Dialog.Close"
	/// button text
	/// English String: "Close"
	/// </summary>
	public override string ActionDialogClose => "閉じる";

	/// <summary>
	/// Key: "Action.Dialog.Login"
	/// button text
	/// English String: "Log In"
	/// </summary>
	public override string ActionDialogLogin => "ログイン";

	/// <summary>
	/// Key: "Action.Dialog.Ok"
	/// button text
	/// English String: "OK"
	/// </summary>
	public override string ActionDialogOk => "OK";

	/// <summary>
	/// Key: "Action.Dialog.SignUp"
	/// button text
	/// English String: "Sign Up"
	/// </summary>
	public override string ActionDialogSignUp => "新規登録";

	/// <summary>
	/// Key: "Action.Dialog.SignUpNow"
	/// button text
	/// English String: "Sign up now!"
	/// </summary>
	public override string ActionDialogSignUpNow => "今すぐ新規登録しよう！";

	/// <summary>
	/// Key: "Description.Dialog.SignUpOrLogin"
	/// modal body text
	/// English String: "To play games, chat with friends, or customize your avatar, you'll need an account. Sign up for a free account or log in to play now."
	/// </summary>
	public override string DescriptionDialogSignUpOrLogin => "ゲームをプレイしたり、友達とチャットしたり、アバターのカスタマイズをしたりするにはアカウントが必要です。無料アカウントを新規登録するか、ログインしてください！";

	/// <summary>
	/// Key: "Description.Dialog.SignUpTodayOneDayRemaining"
	/// description text
	/// English String: "You are playing in guest mode. To use all features available on Roblox, you will need to create an account. You have less than a day left before we require free sign up."
	/// </summary>
	public override string DescriptionDialogSignUpTodayOneDayRemaining => "ゲストモードでプレイしています。Robloxで利用できるすべての機能を使うには、アカウントを作る必要があります。無料の新規登録が必要になるまで、24時間を切っています。";

	/// <summary>
	/// Key: "Description.Dialog.TrialOver"
	/// description
	/// English String: "Your trial period has ended. Please sign up to play games - it's free!"
	/// </summary>
	public override string DescriptionDialogTrialOver => "トライアル期間が終了しました。ゲームをプレイするには、無料の新規登録を行ってください！";

	/// <summary>
	/// Key: "Description.Dialog.YouArePlayingOneDayRemaining"
	/// description
	/// English String: "You are playing in guest mode. To use all features available on Roblox, you will need to create an account. You have 1 gameplay left before we require free sign up."
	/// </summary>
	public override string DescriptionDialogYouArePlayingOneDayRemaining => "ゲストモードでプレイしています。Robloxで利用できるすべての機能を使うには、アカウントを作る必要があります。無料の新規登録が必要になるまで、あと1回のゲームプレイが残っています。";

	/// <summary>
	/// Key: "Heading.ChooseAvatar"
	/// modal heading
	/// English String: "Choose Your Avatar"
	/// </summary>
	public override string HeadingChooseAvatar => "アバターを選ぶ";

	/// <summary>
	/// Key: "Heading.Dialog.SignUpOrLogin"
	/// modal heading
	/// English String: "Sign up for a free account or log in!"
	/// </summary>
	public override string HeadingDialogSignUpOrLogin => "無料アカウントを新規登録するか、ログインしてください！";

	/// <summary>
	/// Key: "Heading.Dialog.SignUpToday"
	/// modal heading
	/// English String: "Sign Up Today!"
	/// </summary>
	public override string HeadingDialogSignUpToday => "今すぐ新規登録しよう！";

	/// <summary>
	/// Key: "Label.HaveAccount"
	/// label
	/// English String: "I have an account"
	/// </summary>
	public override string LabelHaveAccount => "アカウントを持っている";

	public GameLaunchGuestModeResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionDialogClose()
	{
		return "閉じる";
	}

	protected override string _GetTemplateForActionDialogLogin()
	{
		return "ログイン";
	}

	protected override string _GetTemplateForActionDialogOk()
	{
		return "OK";
	}

	protected override string _GetTemplateForActionDialogSignUp()
	{
		return "新規登録";
	}

	protected override string _GetTemplateForActionDialogSignUpNow()
	{
		return "今すぐ新規登録しよう！";
	}

	protected override string _GetTemplateForDescriptionDialogSignUpOrLogin()
	{
		return "ゲームをプレイしたり、友達とチャットしたり、アバターのカスタマイズをしたりするにはアカウントが必要です。無料アカウントを新規登録するか、ログインしてください！";
	}

	protected override string _GetTemplateForDescriptionDialogSignUpTodayOneDayRemaining()
	{
		return "ゲストモードでプレイしています。Robloxで利用できるすべての機能を使うには、アカウントを作る必要があります。無料の新規登録が必要になるまで、24時間を切っています。";
	}

	/// <summary>
	/// Key: "Description.Dialog.SignUpTodaySomeDaysRemaining"
	/// description
	/// English String: "You are playing in guest mode. To use all features available on Roblox, you will need to create an account. You have less than {numDays} days left before we require free sign up."
	/// </summary>
	public override string DescriptionDialogSignUpTodaySomeDaysRemaining(string numDays)
	{
		return $"ゲストモードでプレイしています。Robloxで利用できるすべての機能を使うには、アカウントを作る必要があります。無料の新規登録が必要になるまで、{numDays} 日を切っています。";
	}

	protected override string _GetTemplateForDescriptionDialogSignUpTodaySomeDaysRemaining()
	{
		return "ゲストモードでプレイしています。Robloxで利用できるすべての機能を使うには、アカウントを作る必要があります。無料の新規登録が必要になるまで、{numDays} 日を切っています。";
	}

	protected override string _GetTemplateForDescriptionDialogTrialOver()
	{
		return "トライアル期間が終了しました。ゲームをプレイするには、無料の新規登録を行ってください！";
	}

	protected override string _GetTemplateForDescriptionDialogYouArePlayingOneDayRemaining()
	{
		return "ゲストモードでプレイしています。Robloxで利用できるすべての機能を使うには、アカウントを作る必要があります。無料の新規登録が必要になるまで、あと1回のゲームプレイが残っています。";
	}

	/// <summary>
	/// Key: "Description.Dialog.YouArePlayingSomeDaysRemaining"
	/// description
	/// English String: "You are playing in guest mode. To use all features available on Roblox, you will need to create an account. You have {numDays} gameplays left before we require free sign up."
	/// </summary>
	public override string DescriptionDialogYouArePlayingSomeDaysRemaining(string numDays)
	{
		return $"ゲストモードでプレイしています。Robloxで利用できるすべての機能を使用するには、アカウントを作る必要があります。無料の新規登録が必要になるまで、あと {numDays} 回のゲームプレイが残っています。";
	}

	protected override string _GetTemplateForDescriptionDialogYouArePlayingSomeDaysRemaining()
	{
		return "ゲストモードでプレイしています。Robloxで利用できるすべての機能を使用するには、アカウントを作る必要があります。無料の新規登録が必要になるまで、あと {numDays} 回のゲームプレイが残っています。";
	}

	protected override string _GetTemplateForHeadingChooseAvatar()
	{
		return "アバターを選ぶ";
	}

	protected override string _GetTemplateForHeadingDialogSignUpOrLogin()
	{
		return "無料アカウントを新規登録するか、ログインしてください！";
	}

	protected override string _GetTemplateForHeadingDialogSignUpToday()
	{
		return "今すぐ新規登録しよう！";
	}

	protected override string _GetTemplateForLabelHaveAccount()
	{
		return "アカウントを持っている";
	}
}
