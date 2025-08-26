namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides GameLaunchGuestModeResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class GameLaunchGuestModeResources_zh_cjv : GameLaunchGuestModeResources_en_us, IGameLaunchGuestModeResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Dialog.Close"
	/// button text
	/// English String: "Close"
	/// </summary>
	public override string ActionDialogClose => "å…³é—­";

	/// <summary>
	/// Key: "Action.Dialog.Login"
	/// button text
	/// English String: "Log In"
	/// </summary>
	public override string ActionDialogLogin => "ç™»å½•";

	/// <summary>
	/// Key: "Action.Dialog.Ok"
	/// button text
	/// English String: "OK"
	/// </summary>
	public override string ActionDialogOk => "å¥½";

	/// <summary>
	/// Key: "Action.Dialog.SignUp"
	/// button text
	/// English String: "Sign Up"
	/// </summary>
	public override string ActionDialogSignUp => "æ³¨å†Œ";

	/// <summary>
	/// Key: "Action.Dialog.SignUpNow"
	/// button text
	/// English String: "Sign up now!"
	/// </summary>
	public override string ActionDialogSignUpNow => "ç«‹å³æ³¨å†Œï¼";

	/// <summary>
	/// Key: "Description.Dialog.SignUpOrLogin"
	/// modal body text
	/// English String: "To play games, chat with friends, or customize your avatar, you'll need an account. Sign up for a free account or log in to play now."
	/// </summary>
	public override string DescriptionDialogSignUpOrLogin => "è¦å¼€å§‹æ¸¸æˆï¼Œå’Œå¥½å‹èŠå¤©ï¼Œæˆ–æ˜¯è‡ªå®šä¹‰ä½ çš„è™šæ‹Ÿå½¢è±¡ï¼Œä½ éœ€è¦ä¸€ä¸ªå¸æˆ·ã€‚æ³¨å†Œä¸€ä¸ªå…è´¹å¸æˆ·ï¼Œæˆ–ç™»å½•ä»¥ç«‹å³å¼€å§‹æ¸¸æˆã€‚";

	/// <summary>
	/// Key: "Description.Dialog.SignUpTodayOneDayRemaining"
	/// description text
	/// English String: "You are playing in guest mode. To use all features available on Roblox, you will need to create an account. You have less than a day left before we require free sign up."
	/// </summary>
	public override string DescriptionDialogSignUpTodayOneDayRemaining => "ä½ æ­£åœ¨ä»¥æ¸¸å®¢æ¨¡å¼åŠ å…¥æ¸¸æˆã€‚è‹¥è¦ä½¿ç”¨ Roblox ä¸Šå¯ç”¨çš„æ‰€æœ‰åŠŸèƒ½ï¼Œä½ éœ€è¦åˆ›å»ºå¸æˆ·ã€‚åœ¨æˆ‘ä»¬è¦æ±‚å…è´¹æ³¨å†Œä¹‹å‰ï¼Œä½ è¿˜å‰©ä¸åˆ° 1 å¤©æ—¶é—´ã€‚";

	/// <summary>
	/// Key: "Description.Dialog.TrialOver"
	/// description
	/// English String: "Your trial period has ended. Please sign up to play games - it's free!"
	/// </summary>
	public override string DescriptionDialogTrialOver => "ä½ çš„è¯•çŽ©æœŸå·²ç»“æŸã€‚è¯·å…ˆæ³¨å†Œä»¥å¼€å§‹æ¸¸æˆï¼Œæ˜¯å…è´¹çš„å“¦ï¼";

	/// <summary>
	/// Key: "Description.Dialog.YouArePlayingOneDayRemaining"
	/// description
	/// English String: "You are playing in guest mode. To use all features available on Roblox, you will need to create an account. You have 1 gameplay left before we require free sign up."
	/// </summary>
	public override string DescriptionDialogYouArePlayingOneDayRemaining => "ä½ æ­£åœ¨ä»¥æ¸¸å®¢æ¨¡å¼åŠ å…¥æ¸¸æˆã€‚è‹¥è¦ä½¿ç”¨ Roblox ä¸Šå¯ç”¨çš„æ‰€æœ‰åŠŸèƒ½ï¼Œä½ éœ€è¦åˆ›å»ºå¸æˆ·ã€‚åœ¨æˆ‘ä»¬è¦æ±‚å…è´¹æ³¨å†Œä¹‹å‰ï¼Œä½ è¿˜å‰© 1 æ¬¡æ¸¸æˆæœºä¼šã€‚";

	/// <summary>
	/// Key: "Heading.ChooseAvatar"
	/// modal heading
	/// English String: "Choose Your Avatar"
	/// </summary>
	public override string HeadingChooseAvatar => "é€‰æ‹©ä½ çš„è™šæ‹Ÿå½¢è±¡";

	/// <summary>
	/// Key: "Heading.Dialog.SignUpOrLogin"
	/// modal heading
	/// English String: "Sign up for a free account or log in!"
	/// </summary>
	public override string HeadingDialogSignUpOrLogin => "æ³¨å†Œå…è´¹å¸æˆ·æˆ–ç™»å½•ï¼";

	/// <summary>
	/// Key: "Heading.Dialog.SignUpToday"
	/// modal heading
	/// English String: "Sign Up Today!"
	/// </summary>
	public override string HeadingDialogSignUpToday => "çŽ°åœ¨æ³¨å†Œï¼";

	/// <summary>
	/// Key: "Label.HaveAccount"
	/// label
	/// English String: "I have an account"
	/// </summary>
	public override string LabelHaveAccount => "æˆ‘å·²æœ‰å¸æˆ·";

	public GameLaunchGuestModeResources_zh_cjv(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionDialogClose()
	{
		return "å…³é—­";
	}

	protected override string _GetTemplateForActionDialogLogin()
	{
		return "ç™»å½•";
	}

	protected override string _GetTemplateForActionDialogOk()
	{
		return "å¥½";
	}

	protected override string _GetTemplateForActionDialogSignUp()
	{
		return "æ³¨å†Œ";
	}

	protected override string _GetTemplateForActionDialogSignUpNow()
	{
		return "ç«‹å³æ³¨å†Œï¼";
	}

	protected override string _GetTemplateForDescriptionDialogSignUpOrLogin()
	{
		return "è¦å¼€å§‹æ¸¸æˆï¼Œå’Œå¥½å‹èŠå¤©ï¼Œæˆ–æ˜¯è‡ªå®šä¹‰ä½ çš„è™šæ‹Ÿå½¢è±¡ï¼Œä½ éœ€è¦ä¸€ä¸ªå¸æˆ·ã€‚æ³¨å†Œä¸€ä¸ªå…è´¹å¸æˆ·ï¼Œæˆ–ç™»å½•ä»¥ç«‹å³å¼€å§‹æ¸¸æˆã€‚";
	}

	protected override string _GetTemplateForDescriptionDialogSignUpTodayOneDayRemaining()
	{
		return "ä½ æ­£åœ¨ä»¥æ¸¸å®¢æ¨¡å¼åŠ å…¥æ¸¸æˆã€‚è‹¥è¦ä½¿ç”¨ Roblox ä¸Šå¯ç”¨çš„æ‰€æœ‰åŠŸèƒ½ï¼Œä½ éœ€è¦åˆ›å»ºå¸æˆ·ã€‚åœ¨æˆ‘ä»¬è¦æ±‚å…è´¹æ³¨å†Œä¹‹å‰ï¼Œä½ è¿˜å‰©ä¸åˆ° 1 å¤©æ—¶é—´ã€‚";
	}

	/// <summary>
	/// Key: "Description.Dialog.SignUpTodaySomeDaysRemaining"
	/// description
	/// English String: "You are playing in guest mode. To use all features available on Roblox, you will need to create an account. You have less than {numDays} days left before we require free sign up."
	/// </summary>
	public override string DescriptionDialogSignUpTodaySomeDaysRemaining(string numDays)
	{
		return $"ä½ æ­£åœ¨ä»¥æ¸¸å®¢æ¨¡å¼åŠ å…¥æ¸¸æˆã€‚è‹¥è¦ä½¿ç”¨ Roblox ä¸Šå¯ç”¨çš„æ‰€æœ‰åŠŸèƒ½ï¼Œä½ éœ€è¦åˆ›å»ºå¸æˆ·ã€‚åœ¨æˆ‘ä»¬è¦æ±‚å…è´¹æ³¨å†Œä¹‹å‰ï¼Œä½ è¿˜å‰©ä¸åˆ° {numDays} å¤©æ—¶é—´ã€‚";
	}

	protected override string _GetTemplateForDescriptionDialogSignUpTodaySomeDaysRemaining()
	{
		return "ä½ æ­£åœ¨ä»¥æ¸¸å®¢æ¨¡å¼åŠ å…¥æ¸¸æˆã€‚è‹¥è¦ä½¿ç”¨ Roblox ä¸Šå¯ç”¨çš„æ‰€æœ‰åŠŸèƒ½ï¼Œä½ éœ€è¦åˆ›å»ºå¸æˆ·ã€‚åœ¨æˆ‘ä»¬è¦æ±‚å…è´¹æ³¨å†Œä¹‹å‰ï¼Œä½ è¿˜å‰©ä¸åˆ° {numDays} å¤©æ—¶é—´ã€‚";
	}

	protected override string _GetTemplateForDescriptionDialogTrialOver()
	{
		return "ä½ çš„è¯•çŽ©æœŸå·²ç»“æŸã€‚è¯·å…ˆæ³¨å†Œä»¥å¼€å§‹æ¸¸æˆï¼Œæ˜¯å…è´¹çš„å“¦ï¼";
	}

	protected override string _GetTemplateForDescriptionDialogYouArePlayingOneDayRemaining()
	{
		return "ä½ æ­£åœ¨ä»¥æ¸¸å®¢æ¨¡å¼åŠ å…¥æ¸¸æˆã€‚è‹¥è¦ä½¿ç”¨ Roblox ä¸Šå¯ç”¨çš„æ‰€æœ‰åŠŸèƒ½ï¼Œä½ éœ€è¦åˆ›å»ºå¸æˆ·ã€‚åœ¨æˆ‘ä»¬è¦æ±‚å…è´¹æ³¨å†Œä¹‹å‰ï¼Œä½ è¿˜å‰© 1 æ¬¡æ¸¸æˆæœºä¼šã€‚";
	}

	/// <summary>
	/// Key: "Description.Dialog.YouArePlayingSomeDaysRemaining"
	/// description
	/// English String: "You are playing in guest mode. To use all features available on Roblox, you will need to create an account. You have {numDays} gameplays left before we require free sign up."
	/// </summary>
	public override string DescriptionDialogYouArePlayingSomeDaysRemaining(string numDays)
	{
		return $"ä½ æ­£åœ¨ä»¥æ¸¸å®¢æ¨¡å¼åŠ å…¥æ¸¸æˆã€‚è‹¥è¦ä½¿ç”¨ Roblox ä¸Šå¯ç”¨çš„æ‰€æœ‰åŠŸèƒ½ï¼Œä½ éœ€è¦åˆ›å»ºå¸æˆ·ã€‚åœ¨æˆ‘ä»¬è¦æ±‚å…è´¹æ³¨å†Œä¹‹å‰ï¼Œä½ è¿˜å‰© {numDays} æ¬¡æ¸¸æˆæœºä¼šã€‚";
	}

	protected override string _GetTemplateForDescriptionDialogYouArePlayingSomeDaysRemaining()
	{
		return "ä½ æ­£åœ¨ä»¥æ¸¸å®¢æ¨¡å¼åŠ å…¥æ¸¸æˆã€‚è‹¥è¦ä½¿ç”¨ Roblox ä¸Šå¯ç”¨çš„æ‰€æœ‰åŠŸèƒ½ï¼Œä½ éœ€è¦åˆ›å»ºå¸æˆ·ã€‚åœ¨æˆ‘ä»¬è¦æ±‚å…è´¹æ³¨å†Œä¹‹å‰ï¼Œä½ è¿˜å‰© {numDays} æ¬¡æ¸¸æˆæœºä¼šã€‚";
	}

	protected override string _GetTemplateForHeadingChooseAvatar()
	{
		return "é€‰æ‹©ä½ çš„è™šæ‹Ÿå½¢è±¡";
	}

	protected override string _GetTemplateForHeadingDialogSignUpOrLogin()
	{
		return "æ³¨å†Œå…è´¹å¸æˆ·æˆ–ç™»å½•ï¼";
	}

	protected override string _GetTemplateForHeadingDialogSignUpToday()
	{
		return "çŽ°åœ¨æ³¨å†Œï¼";
	}

	protected override string _GetTemplateForLabelHaveAccount()
	{
		return "æˆ‘å·²æœ‰å¸æˆ·";
	}
}


}
