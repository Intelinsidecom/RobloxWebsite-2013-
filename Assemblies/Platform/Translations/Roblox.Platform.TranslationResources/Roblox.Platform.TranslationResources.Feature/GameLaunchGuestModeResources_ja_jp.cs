namespace Roblox.Platform.TranslationResources.Feature {
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
	public override string ActionDialogClose => "é–‰ã˜ã‚‹";

	/// <summary>
	/// Key: "Action.Dialog.Login"
	/// button text
	/// English String: "Log In"
	/// </summary>
	public override string ActionDialogLogin => "ãƒ­ã‚°ã‚¤ãƒ³";

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
	public override string ActionDialogSignUp => "æ–°è¦ç™»éŒ²";

	/// <summary>
	/// Key: "Action.Dialog.SignUpNow"
	/// button text
	/// English String: "Sign up now!"
	/// </summary>
	public override string ActionDialogSignUpNow => "ä»Šã™ãæ–°è¦ç™»éŒ²ã—ã‚ˆã†ï¼";

	/// <summary>
	/// Key: "Description.Dialog.SignUpOrLogin"
	/// modal body text
	/// English String: "To play games, chat with friends, or customize your avatar, you'll need an account. Sign up for a free account or log in to play now."
	/// </summary>
	public override string DescriptionDialogSignUpOrLogin => "ã‚²ãƒ¼ãƒ ã‚’ãƒ—ãƒ¬ã‚¤ã—ãŸã‚Šã€å‹é”ã¨ãƒãƒ£ãƒƒãƒˆã—ãŸã‚Šã€ã‚¢ãƒã‚¿ãƒ¼ã®ã‚«ã‚¹ã‚¿ãƒžã‚¤ã‚ºã‚’ã—ãŸã‚Šã™ã‚‹ã«ã¯ã‚¢ã‚«ã‚¦ãƒ³ãƒˆãŒå¿…è¦ã§ã™ã€‚ç„¡æ–™ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã‚’æ–°è¦ç™»éŒ²ã™ã‚‹ã‹ã€ãƒ­ã‚°ã‚¤ãƒ³ã—ã¦ãã ã•ã„ï¼";

	/// <summary>
	/// Key: "Description.Dialog.SignUpTodayOneDayRemaining"
	/// description text
	/// English String: "You are playing in guest mode. To use all features available on Roblox, you will need to create an account. You have less than a day left before we require free sign up."
	/// </summary>
	public override string DescriptionDialogSignUpTodayOneDayRemaining => "ã‚²ã‚¹ãƒˆãƒ¢ãƒ¼ãƒ‰ã§ãƒ—ãƒ¬ã‚¤ã—ã¦ã„ã¾ã™ã€‚Robloxã§åˆ©ç”¨ã§ãã‚‹ã™ã¹ã¦ã®æ©Ÿèƒ½ã‚’ä½¿ã†ã«ã¯ã€ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã‚’ä½œã‚‹å¿…è¦ãŒã‚ã‚Šã¾ã™ã€‚ç„¡æ–™ã®æ–°è¦ç™»éŒ²ãŒå¿…è¦ã«ãªã‚‹ã¾ã§ã€24æ™‚é–“ã‚’åˆ‡ã£ã¦ã„ã¾ã™ã€‚";

	/// <summary>
	/// Key: "Description.Dialog.TrialOver"
	/// description
	/// English String: "Your trial period has ended. Please sign up to play games - it's free!"
	/// </summary>
	public override string DescriptionDialogTrialOver => "ãƒˆãƒ©ã‚¤ã‚¢ãƒ«æœŸé–“ãŒçµ‚äº†ã—ã¾ã—ãŸã€‚ã‚²ãƒ¼ãƒ ã‚’ãƒ—ãƒ¬ã‚¤ã™ã‚‹ã«ã¯ã€ç„¡æ–™ã®æ–°è¦ç™»éŒ²ã‚’è¡Œã£ã¦ãã ã•ã„ï¼";

	/// <summary>
	/// Key: "Description.Dialog.YouArePlayingOneDayRemaining"
	/// description
	/// English String: "You are playing in guest mode. To use all features available on Roblox, you will need to create an account. You have 1 gameplay left before we require free sign up."
	/// </summary>
	public override string DescriptionDialogYouArePlayingOneDayRemaining => "ã‚²ã‚¹ãƒˆãƒ¢ãƒ¼ãƒ‰ã§ãƒ—ãƒ¬ã‚¤ã—ã¦ã„ã¾ã™ã€‚Robloxã§åˆ©ç”¨ã§ãã‚‹ã™ã¹ã¦ã®æ©Ÿèƒ½ã‚’ä½¿ã†ã«ã¯ã€ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã‚’ä½œã‚‹å¿…è¦ãŒã‚ã‚Šã¾ã™ã€‚ç„¡æ–™ã®æ–°è¦ç™»éŒ²ãŒå¿…è¦ã«ãªã‚‹ã¾ã§ã€ã‚ã¨1å›žã®ã‚²ãƒ¼ãƒ ãƒ—ãƒ¬ã‚¤ãŒæ®‹ã£ã¦ã„ã¾ã™ã€‚";

	/// <summary>
	/// Key: "Heading.ChooseAvatar"
	/// modal heading
	/// English String: "Choose Your Avatar"
	/// </summary>
	public override string HeadingChooseAvatar => "ã‚¢ãƒã‚¿ãƒ¼ã‚’é¸ã¶";

	/// <summary>
	/// Key: "Heading.Dialog.SignUpOrLogin"
	/// modal heading
	/// English String: "Sign up for a free account or log in!"
	/// </summary>
	public override string HeadingDialogSignUpOrLogin => "ç„¡æ–™ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã‚’æ–°è¦ç™»éŒ²ã™ã‚‹ã‹ã€ãƒ­ã‚°ã‚¤ãƒ³ã—ã¦ãã ã•ã„ï¼";

	/// <summary>
	/// Key: "Heading.Dialog.SignUpToday"
	/// modal heading
	/// English String: "Sign Up Today!"
	/// </summary>
	public override string HeadingDialogSignUpToday => "ä»Šã™ãæ–°è¦ç™»éŒ²ã—ã‚ˆã†ï¼";

	/// <summary>
	/// Key: "Label.HaveAccount"
	/// label
	/// English String: "I have an account"
	/// </summary>
	public override string LabelHaveAccount => "ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã‚’æŒã£ã¦ã„ã‚‹";

	public GameLaunchGuestModeResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionDialogClose()
	{
		return "é–‰ã˜ã‚‹";
	}

	protected override string _GetTemplateForActionDialogLogin()
	{
		return "ãƒ­ã‚°ã‚¤ãƒ³";
	}

	protected override string _GetTemplateForActionDialogOk()
	{
		return "OK";
	}

	protected override string _GetTemplateForActionDialogSignUp()
	{
		return "æ–°è¦ç™»éŒ²";
	}

	protected override string _GetTemplateForActionDialogSignUpNow()
	{
		return "ä»Šã™ãæ–°è¦ç™»éŒ²ã—ã‚ˆã†ï¼";
	}

	protected override string _GetTemplateForDescriptionDialogSignUpOrLogin()
	{
		return "ã‚²ãƒ¼ãƒ ã‚’ãƒ—ãƒ¬ã‚¤ã—ãŸã‚Šã€å‹é”ã¨ãƒãƒ£ãƒƒãƒˆã—ãŸã‚Šã€ã‚¢ãƒã‚¿ãƒ¼ã®ã‚«ã‚¹ã‚¿ãƒžã‚¤ã‚ºã‚’ã—ãŸã‚Šã™ã‚‹ã«ã¯ã‚¢ã‚«ã‚¦ãƒ³ãƒˆãŒå¿…è¦ã§ã™ã€‚ç„¡æ–™ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã‚’æ–°è¦ç™»éŒ²ã™ã‚‹ã‹ã€ãƒ­ã‚°ã‚¤ãƒ³ã—ã¦ãã ã•ã„ï¼";
	}

	protected override string _GetTemplateForDescriptionDialogSignUpTodayOneDayRemaining()
	{
		return "ã‚²ã‚¹ãƒˆãƒ¢ãƒ¼ãƒ‰ã§ãƒ—ãƒ¬ã‚¤ã—ã¦ã„ã¾ã™ã€‚Robloxã§åˆ©ç”¨ã§ãã‚‹ã™ã¹ã¦ã®æ©Ÿèƒ½ã‚’ä½¿ã†ã«ã¯ã€ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã‚’ä½œã‚‹å¿…è¦ãŒã‚ã‚Šã¾ã™ã€‚ç„¡æ–™ã®æ–°è¦ç™»éŒ²ãŒå¿…è¦ã«ãªã‚‹ã¾ã§ã€24æ™‚é–“ã‚’åˆ‡ã£ã¦ã„ã¾ã™ã€‚";
	}

	/// <summary>
	/// Key: "Description.Dialog.SignUpTodaySomeDaysRemaining"
	/// description
	/// English String: "You are playing in guest mode. To use all features available on Roblox, you will need to create an account. You have less than {numDays} days left before we require free sign up."
	/// </summary>
	public override string DescriptionDialogSignUpTodaySomeDaysRemaining(string numDays)
	{
		return $"ã‚²ã‚¹ãƒˆãƒ¢ãƒ¼ãƒ‰ã§ãƒ—ãƒ¬ã‚¤ã—ã¦ã„ã¾ã™ã€‚Robloxã§åˆ©ç”¨ã§ãã‚‹ã™ã¹ã¦ã®æ©Ÿèƒ½ã‚’ä½¿ã†ã«ã¯ã€ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã‚’ä½œã‚‹å¿…è¦ãŒã‚ã‚Šã¾ã™ã€‚ç„¡æ–™ã®æ–°è¦ç™»éŒ²ãŒå¿…è¦ã«ãªã‚‹ã¾ã§ã€{numDays} æ—¥ã‚’åˆ‡ã£ã¦ã„ã¾ã™ã€‚";
	}

	protected override string _GetTemplateForDescriptionDialogSignUpTodaySomeDaysRemaining()
	{
		return "ã‚²ã‚¹ãƒˆãƒ¢ãƒ¼ãƒ‰ã§ãƒ—ãƒ¬ã‚¤ã—ã¦ã„ã¾ã™ã€‚Robloxã§åˆ©ç”¨ã§ãã‚‹ã™ã¹ã¦ã®æ©Ÿèƒ½ã‚’ä½¿ã†ã«ã¯ã€ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã‚’ä½œã‚‹å¿…è¦ãŒã‚ã‚Šã¾ã™ã€‚ç„¡æ–™ã®æ–°è¦ç™»éŒ²ãŒå¿…è¦ã«ãªã‚‹ã¾ã§ã€{numDays} æ—¥ã‚’åˆ‡ã£ã¦ã„ã¾ã™ã€‚";
	}

	protected override string _GetTemplateForDescriptionDialogTrialOver()
	{
		return "ãƒˆãƒ©ã‚¤ã‚¢ãƒ«æœŸé–“ãŒçµ‚äº†ã—ã¾ã—ãŸã€‚ã‚²ãƒ¼ãƒ ã‚’ãƒ—ãƒ¬ã‚¤ã™ã‚‹ã«ã¯ã€ç„¡æ–™ã®æ–°è¦ç™»éŒ²ã‚’è¡Œã£ã¦ãã ã•ã„ï¼";
	}

	protected override string _GetTemplateForDescriptionDialogYouArePlayingOneDayRemaining()
	{
		return "ã‚²ã‚¹ãƒˆãƒ¢ãƒ¼ãƒ‰ã§ãƒ—ãƒ¬ã‚¤ã—ã¦ã„ã¾ã™ã€‚Robloxã§åˆ©ç”¨ã§ãã‚‹ã™ã¹ã¦ã®æ©Ÿèƒ½ã‚’ä½¿ã†ã«ã¯ã€ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã‚’ä½œã‚‹å¿…è¦ãŒã‚ã‚Šã¾ã™ã€‚ç„¡æ–™ã®æ–°è¦ç™»éŒ²ãŒå¿…è¦ã«ãªã‚‹ã¾ã§ã€ã‚ã¨1å›žã®ã‚²ãƒ¼ãƒ ãƒ—ãƒ¬ã‚¤ãŒæ®‹ã£ã¦ã„ã¾ã™ã€‚";
	}

	/// <summary>
	/// Key: "Description.Dialog.YouArePlayingSomeDaysRemaining"
	/// description
	/// English String: "You are playing in guest mode. To use all features available on Roblox, you will need to create an account. You have {numDays} gameplays left before we require free sign up."
	/// </summary>
	public override string DescriptionDialogYouArePlayingSomeDaysRemaining(string numDays)
	{
		return $"ã‚²ã‚¹ãƒˆãƒ¢ãƒ¼ãƒ‰ã§ãƒ—ãƒ¬ã‚¤ã—ã¦ã„ã¾ã™ã€‚Robloxã§åˆ©ç”¨ã§ãã‚‹ã™ã¹ã¦ã®æ©Ÿèƒ½ã‚’ä½¿ç”¨ã™ã‚‹ã«ã¯ã€ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã‚’ä½œã‚‹å¿…è¦ãŒã‚ã‚Šã¾ã™ã€‚ç„¡æ–™ã®æ–°è¦ç™»éŒ²ãŒå¿…è¦ã«ãªã‚‹ã¾ã§ã€ã‚ã¨ {numDays} å›žã®ã‚²ãƒ¼ãƒ ãƒ—ãƒ¬ã‚¤ãŒæ®‹ã£ã¦ã„ã¾ã™ã€‚";
	}

	protected override string _GetTemplateForDescriptionDialogYouArePlayingSomeDaysRemaining()
	{
		return "ã‚²ã‚¹ãƒˆãƒ¢ãƒ¼ãƒ‰ã§ãƒ—ãƒ¬ã‚¤ã—ã¦ã„ã¾ã™ã€‚Robloxã§åˆ©ç”¨ã§ãã‚‹ã™ã¹ã¦ã®æ©Ÿèƒ½ã‚’ä½¿ç”¨ã™ã‚‹ã«ã¯ã€ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã‚’ä½œã‚‹å¿…è¦ãŒã‚ã‚Šã¾ã™ã€‚ç„¡æ–™ã®æ–°è¦ç™»éŒ²ãŒå¿…è¦ã«ãªã‚‹ã¾ã§ã€ã‚ã¨ {numDays} å›žã®ã‚²ãƒ¼ãƒ ãƒ—ãƒ¬ã‚¤ãŒæ®‹ã£ã¦ã„ã¾ã™ã€‚";
	}

	protected override string _GetTemplateForHeadingChooseAvatar()
	{
		return "ã‚¢ãƒã‚¿ãƒ¼ã‚’é¸ã¶";
	}

	protected override string _GetTemplateForHeadingDialogSignUpOrLogin()
	{
		return "ç„¡æ–™ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã‚’æ–°è¦ç™»éŒ²ã™ã‚‹ã‹ã€ãƒ­ã‚°ã‚¤ãƒ³ã—ã¦ãã ã•ã„ï¼";
	}

	protected override string _GetTemplateForHeadingDialogSignUpToday()
	{
		return "ä»Šã™ãæ–°è¦ç™»éŒ²ã—ã‚ˆã†ï¼";
	}

	protected override string _GetTemplateForLabelHaveAccount()
	{
		return "ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã‚’æŒã£ã¦ã„ã‚‹";
	}
}


}
