namespace Roblox.Platform.TranslationResources.Feature {
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
	public override string ActionDialogClose => "é—œé–‰";

	/// <summary>
	/// Key: "Action.Dialog.Login"
	/// button text
	/// English String: "Log In"
	/// </summary>
	public override string ActionDialogLogin => "ç™»å…¥";

	/// <summary>
	/// Key: "Action.Dialog.Ok"
	/// button text
	/// English String: "OK"
	/// </summary>
	public override string ActionDialogOk => "ç¢ºå®š";

	/// <summary>
	/// Key: "Action.Dialog.SignUp"
	/// button text
	/// English String: "Sign Up"
	/// </summary>
	public override string ActionDialogSignUp => "è¨»å†Š";

	/// <summary>
	/// Key: "Action.Dialog.SignUpNow"
	/// button text
	/// English String: "Sign up now!"
	/// </summary>
	public override string ActionDialogSignUpNow => "ç¾åœ¨è¨»å†Šï¼";

	/// <summary>
	/// Key: "Description.Dialog.SignUpOrLogin"
	/// modal body text
	/// English String: "To play games, chat with friends, or customize your avatar, you'll need an account. Sign up for a free account or log in to play now."
	/// </summary>
	public override string DescriptionDialogSignUpOrLogin => "æ‚¨éœ€è¦ç”³è«‹å¸³è™Ÿæ‰å¯ä»¥çŽ©éŠæˆ²ã€èˆ‡å¥½å‹èŠå¤©åŠè‡ªè¨‚æ‚¨çš„è™›æ“¬äººå¶ã€‚ç™»å…¥æˆ–è¨»å†Šå…è²»å¸³è™Ÿï¼Œé¦¬ä¸Šé–‹å§‹çŽ©ã€‚";

	/// <summary>
	/// Key: "Description.Dialog.SignUpTodayOneDayRemaining"
	/// description text
	/// English String: "You are playing in guest mode. To use all features available on Roblox, you will need to create an account. You have less than a day left before we require free sign up."
	/// </summary>
	public override string DescriptionDialogSignUpTodayOneDayRemaining => "æ‚¨æ­£åœ¨ä»¥è¨ªå®¢æ¨¡å¼éŠçŽ©ã€‚è‹¥è¦ä½¿ç”¨æ‰€æœ‰ Roblox åŠŸèƒ½ï¼Œæ‚¨å°‡éœ€è¦å»ºç«‹å¸³è™Ÿã€‚åœ¨éœ€è¦å…è²»è¨»å†Šä¹‹å‰ï¼Œæ‚¨é‚„å¯ä»¥çŽ©ä¸€å¤©ã€‚";

	/// <summary>
	/// Key: "Description.Dialog.TrialOver"
	/// description
	/// English String: "Your trial period has ended. Please sign up to play games - it's free!"
	/// </summary>
	public override string DescriptionDialogTrialOver => "æ‚¨çš„è©¦ç”¨æœŸå·²çµæŸï¼Œè«‹è¨»å†Šå…è²»å¸³è™Ÿç¹¼çºŒçŽ©ã€‚";

	/// <summary>
	/// Key: "Description.Dialog.YouArePlayingOneDayRemaining"
	/// description
	/// English String: "You are playing in guest mode. To use all features available on Roblox, you will need to create an account. You have 1 gameplay left before we require free sign up."
	/// </summary>
	public override string DescriptionDialogYouArePlayingOneDayRemaining => "æ‚¨æ­£åœ¨ä»¥è¨ªå®¢æ¨¡å¼éŠçŽ©ã€‚è‹¥è¦ä½¿ç”¨æ‰€æœ‰ Roblox åŠŸèƒ½ï¼Œæ‚¨å°‡éœ€è¦å»ºç«‹å¸³è™Ÿã€‚åœ¨éœ€è¦å…è²»è¨»å†Šä¹‹å‰ï¼Œæ‚¨é‚„å¯ä»¥éŠçŽ©ä¸€æ¬¡ã€‚";

	/// <summary>
	/// Key: "Heading.ChooseAvatar"
	/// modal heading
	/// English String: "Choose Your Avatar"
	/// </summary>
	public override string HeadingChooseAvatar => "é¸æ“‡æ‚¨çš„è™›æ“¬äººå¶";

	/// <summary>
	/// Key: "Heading.Dialog.SignUpOrLogin"
	/// modal heading
	/// English String: "Sign up for a free account or log in!"
	/// </summary>
	public override string HeadingDialogSignUpOrLogin => "ç™»å…¥æˆ–è¨»å†Šå…è²»å¸³è™Ÿï¼";

	/// <summary>
	/// Key: "Heading.Dialog.SignUpToday"
	/// modal heading
	/// English String: "Sign Up Today!"
	/// </summary>
	public override string HeadingDialogSignUpToday => "ç¾åœ¨è¨»å†Šï¼";

	/// <summary>
	/// Key: "Label.HaveAccount"
	/// label
	/// English String: "I have an account"
	/// </summary>
	public override string LabelHaveAccount => "æˆ‘æœ‰å¸³è™Ÿ";

	public GameLaunchGuestModeResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionDialogClose()
	{
		return "é—œé–‰";
	}

	protected override string _GetTemplateForActionDialogLogin()
	{
		return "ç™»å…¥";
	}

	protected override string _GetTemplateForActionDialogOk()
	{
		return "ç¢ºå®š";
	}

	protected override string _GetTemplateForActionDialogSignUp()
	{
		return "è¨»å†Š";
	}

	protected override string _GetTemplateForActionDialogSignUpNow()
	{
		return "ç¾åœ¨è¨»å†Šï¼";
	}

	protected override string _GetTemplateForDescriptionDialogSignUpOrLogin()
	{
		return "æ‚¨éœ€è¦ç”³è«‹å¸³è™Ÿæ‰å¯ä»¥çŽ©éŠæˆ²ã€èˆ‡å¥½å‹èŠå¤©åŠè‡ªè¨‚æ‚¨çš„è™›æ“¬äººå¶ã€‚ç™»å…¥æˆ–è¨»å†Šå…è²»å¸³è™Ÿï¼Œé¦¬ä¸Šé–‹å§‹çŽ©ã€‚";
	}

	protected override string _GetTemplateForDescriptionDialogSignUpTodayOneDayRemaining()
	{
		return "æ‚¨æ­£åœ¨ä»¥è¨ªå®¢æ¨¡å¼éŠçŽ©ã€‚è‹¥è¦ä½¿ç”¨æ‰€æœ‰ Roblox åŠŸèƒ½ï¼Œæ‚¨å°‡éœ€è¦å»ºç«‹å¸³è™Ÿã€‚åœ¨éœ€è¦å…è²»è¨»å†Šä¹‹å‰ï¼Œæ‚¨é‚„å¯ä»¥çŽ©ä¸€å¤©ã€‚";
	}

	/// <summary>
	/// Key: "Description.Dialog.SignUpTodaySomeDaysRemaining"
	/// description
	/// English String: "You are playing in guest mode. To use all features available on Roblox, you will need to create an account. You have less than {numDays} days left before we require free sign up."
	/// </summary>
	public override string DescriptionDialogSignUpTodaySomeDaysRemaining(string numDays)
	{
		return $"æ‚¨æ­£åœ¨ä»¥è¨ªå®¢æ¨¡å¼éŠçŽ©ã€‚è‹¥è¦ä½¿ç”¨æ‰€æœ‰ Roblox åŠŸèƒ½ï¼Œæ‚¨å°‡éœ€è¦å»ºç«‹å¸³è™Ÿã€‚åœ¨éœ€è¦å…è²»è¨»å†Šä¹‹å‰ï¼Œæ‚¨é‚„å¯ä»¥çŽ© {numDays} å¤©ã€‚";
	}

	protected override string _GetTemplateForDescriptionDialogSignUpTodaySomeDaysRemaining()
	{
		return "æ‚¨æ­£åœ¨ä»¥è¨ªå®¢æ¨¡å¼éŠçŽ©ã€‚è‹¥è¦ä½¿ç”¨æ‰€æœ‰ Roblox åŠŸèƒ½ï¼Œæ‚¨å°‡éœ€è¦å»ºç«‹å¸³è™Ÿã€‚åœ¨éœ€è¦å…è²»è¨»å†Šä¹‹å‰ï¼Œæ‚¨é‚„å¯ä»¥çŽ© {numDays} å¤©ã€‚";
	}

	protected override string _GetTemplateForDescriptionDialogTrialOver()
	{
		return "æ‚¨çš„è©¦ç”¨æœŸå·²çµæŸï¼Œè«‹è¨»å†Šå…è²»å¸³è™Ÿç¹¼çºŒçŽ©ã€‚";
	}

	protected override string _GetTemplateForDescriptionDialogYouArePlayingOneDayRemaining()
	{
		return "æ‚¨æ­£åœ¨ä»¥è¨ªå®¢æ¨¡å¼éŠçŽ©ã€‚è‹¥è¦ä½¿ç”¨æ‰€æœ‰ Roblox åŠŸèƒ½ï¼Œæ‚¨å°‡éœ€è¦å»ºç«‹å¸³è™Ÿã€‚åœ¨éœ€è¦å…è²»è¨»å†Šä¹‹å‰ï¼Œæ‚¨é‚„å¯ä»¥éŠçŽ©ä¸€æ¬¡ã€‚";
	}

	/// <summary>
	/// Key: "Description.Dialog.YouArePlayingSomeDaysRemaining"
	/// description
	/// English String: "You are playing in guest mode. To use all features available on Roblox, you will need to create an account. You have {numDays} gameplays left before we require free sign up."
	/// </summary>
	public override string DescriptionDialogYouArePlayingSomeDaysRemaining(string numDays)
	{
		return $"æ‚¨æ­£åœ¨ä»¥è¨ªå®¢æ¨¡å¼éŠçŽ©ã€‚è‹¥è¦ä½¿ç”¨æ‰€æœ‰ Roblox åŠŸèƒ½ï¼Œæ‚¨å°‡éœ€è¦å»ºç«‹å¸³è™Ÿã€‚åœ¨éœ€è¦å…è²»è¨»å†Šä¹‹å‰ï¼Œæ‚¨é‚„å¯ä»¥éŠçŽ© {numDays} æ¬¡ã€‚";
	}

	protected override string _GetTemplateForDescriptionDialogYouArePlayingSomeDaysRemaining()
	{
		return "æ‚¨æ­£åœ¨ä»¥è¨ªå®¢æ¨¡å¼éŠçŽ©ã€‚è‹¥è¦ä½¿ç”¨æ‰€æœ‰ Roblox åŠŸèƒ½ï¼Œæ‚¨å°‡éœ€è¦å»ºç«‹å¸³è™Ÿã€‚åœ¨éœ€è¦å…è²»è¨»å†Šä¹‹å‰ï¼Œæ‚¨é‚„å¯ä»¥éŠçŽ© {numDays} æ¬¡ã€‚";
	}

	protected override string _GetTemplateForHeadingChooseAvatar()
	{
		return "é¸æ“‡æ‚¨çš„è™›æ“¬äººå¶";
	}

	protected override string _GetTemplateForHeadingDialogSignUpOrLogin()
	{
		return "ç™»å…¥æˆ–è¨»å†Šå…è²»å¸³è™Ÿï¼";
	}

	protected override string _GetTemplateForHeadingDialogSignUpToday()
	{
		return "ç¾åœ¨è¨»å†Šï¼";
	}

	protected override string _GetTemplateForLabelHaveAccount()
	{
		return "æˆ‘æœ‰å¸³è™Ÿ";
	}
}


}
