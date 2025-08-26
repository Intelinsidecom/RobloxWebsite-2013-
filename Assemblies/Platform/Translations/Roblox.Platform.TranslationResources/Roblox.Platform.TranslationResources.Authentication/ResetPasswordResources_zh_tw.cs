namespace Roblox.Platform.TranslationResources.Authentication {
    /// <summary>

/// This class overrides ResetPasswordResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ResetPasswordResources_zh_tw : ResetPasswordResources_en_us, IResetPasswordResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "å–æ¶ˆ";

	/// <summary>
	/// Key: "Action.EmailToResetPassword"
	/// English String: "Use email to reset password"
	/// </summary>
	public override string ActionEmailToResetPassword => "ä½¿ç”¨é›»å­éƒµä»¶é‡ç½®å¯†ç¢¼";

	/// <summary>
	/// Key: "Action.EmailToRetriveUsername"
	/// English String: "Use email to retrieve username"
	/// </summary>
	public override string ActionEmailToRetriveUsername => "ä½¿ç”¨é›»å­éƒµä»¶å–å¾—ä½¿ç”¨è€…åç¨±";

	/// <summary>
	/// Key: "Action.Ok"
	/// OK
	/// English String: "OK"
	/// </summary>
	public override string ActionOk => "ç¢ºå®š";

	/// <summary>
	/// Key: "Action.PhoneToResetPassword"
	/// English String: "Use phone number to reset password"
	/// </summary>
	public override string ActionPhoneToResetPassword => "ä½¿ç”¨æ‰‹æ©Ÿè™Ÿç¢¼é‡ç½®å¯†ç¢¼";

	/// <summary>
	/// Key: "Action.PhoneToRetriveUsername"
	/// English String: "Use phone number to retrieve username"
	/// </summary>
	public override string ActionPhoneToRetriveUsername => "ä½¿ç”¨æ‰‹æ©Ÿè™Ÿç¢¼å–å¾—ä½¿ç”¨è€…åç¨±";

	/// <summary>
	/// Key: "Action.Verify"
	/// English String: "Verify"
	/// </summary>
	public override string ActionVerify => "é©—è­‰";

	/// <summary>
	/// Key: "Description.EmailToResetPassword"
	/// English String: "Enter your email to reset your password."
	/// </summary>
	public override string DescriptionEmailToResetPassword => "è‹¥è¦é‡ç½®æ‚¨çš„å¯†ç¢¼ï¼Œè«‹è¼¸å…¥æ‚¨çš„é›»å­éƒµä»¶åœ°å€ã€‚";

	/// <summary>
	/// Key: "Description.EmailToRetriveUsername"
	/// English String: "Enter your email to retrieve your username."
	/// </summary>
	public override string DescriptionEmailToRetriveUsername => "è‹¥è¦å–å¾—æ‚¨çš„ä½¿ç”¨è€…åç¨±ï¼Œè«‹è¼¸å…¥æ‚¨çš„é›»å­éƒµä»¶åœ°å€ã€‚";

	/// <summary>
	/// Key: "Description.PasswordChangeEmail.Subject"
	/// email subject to change password
	/// English String: "Roblox Password Reset"
	/// </summary>
	public override string DescriptionPasswordChangeEmailSubject => "Roblox å¯†ç¢¼é‡ç½®";

	/// <summary>
	/// Key: "Description.PasswordResetEmail.Subject"
	/// Subject for password reset email
	/// English String: "Roblox Account Password Reset"
	/// </summary>
	public override string DescriptionPasswordResetEmailSubject => "Roblox å¸³è™Ÿå¯†ç¢¼é‡ç½®";

	/// <summary>
	/// Key: "Description.PhoneToResetPassword"
	/// English String: "Enter your phone number to reset your password."
	/// </summary>
	public override string DescriptionPhoneToResetPassword => "è‹¥è¦é‡ç½®æ‚¨çš„å¯†ç¢¼ï¼Œè«‹è¼¸å…¥æ‚¨çš„æ‰‹æ©Ÿè™Ÿç¢¼ã€‚";

	/// <summary>
	/// Key: "Description.PhoneToRetriveUsername"
	/// English String: "Enter your phone number to retrieve your username."
	/// </summary>
	public override string DescriptionPhoneToRetriveUsername => "è‹¥è¦å–å¾—æ‚¨çš„ä½¿ç”¨è€…åç¨±ï¼Œè«‹è¼¸å…¥æ‚¨çš„æ‰‹æ©Ÿè™Ÿç¢¼ã€‚";

	/// <summary>
	/// Key: "Heading.VerifyCode"
	/// verify code heading
	/// English String: "Verify Code"
	/// </summary>
	public override string HeadingVerifyCode => "é©—è­‰ç¢¼";

	/// <summary>
	/// Key: "Heading.VerifyPhone"
	/// English String: "Verify Phone"
	/// </summary>
	public override string HeadingVerifyPhone => "é©—è­‰æ‰‹æ©Ÿè™Ÿç¢¼";

	/// <summary>
	/// Key: "HeadingForgetPasswordOrUsername"
	/// English String: "Forgot Password or Username"
	/// </summary>
	public override string HeadingForgetPasswordOrUsername => "å¿˜è¨˜å¯†ç¢¼æˆ–ä½¿ç”¨è€…åç¨±";

	/// <summary>
	/// Key: "Label.ActionButtonYes"
	/// button label
	/// English String: "Yes"
	/// </summary>
	public override string LabelActionButtonYes => "æ˜¯";

	/// <summary>
	/// Key: "Label.ForgetMyPassword"
	/// English String: "Forgot My Password"
	/// </summary>
	public override string LabelForgetMyPassword => "å¿˜è¨˜å¯†ç¢¼äº†";

	/// <summary>
	/// Key: "Label.ForgetMyUsername"
	/// English String: "Forgot My Username"
	/// </summary>
	public override string LabelForgetMyUsername => "å¿˜è¨˜ä½¿ç”¨è€…åç¨±äº†";

	/// <summary>
	/// Key: "Label.InvalidEmail"
	/// English String: "Invalid email"
	/// </summary>
	public override string LabelInvalidEmail => "é›»å­éƒµä»¶åœ°å€ç„¡æ•ˆ";

	/// <summary>
	/// Key: "Label.InvalidPhoneNumber"
	/// English String: "Invalid phone number"
	/// </summary>
	public override string LabelInvalidPhoneNumber => "æ‰‹æ©Ÿè™Ÿç¢¼ç„¡æ•ˆ";

	/// <summary>
	/// Key: "Label.NeutralButtonOk"
	/// ok button label
	/// English String: "OK"
	/// </summary>
	public override string LabelNeutralButtonOk => "ç¢ºå®š";

	/// <summary>
	/// Key: "Label.Password"
	/// label
	/// English String: "Password"
	/// </summary>
	public override string LabelPassword => "å¯†ç¢¼";

	/// <summary>
	/// Key: "Label.ResendCode"
	/// English String: "Resend Code"
	/// </summary>
	public override string LabelResendCode => "é‡æ–°å‚³é€é©—è­‰ç¢¼";

	/// <summary>
	/// Key: "Label.Submit"
	/// English String: "Submit"
	/// </summary>
	public override string LabelSubmit => "æäº¤";

	/// <summary>
	/// Key: "Label.ToolTip.WhoCanFindMeByPhone"
	/// English String: "This setting controls who can find you using the phone number you provided."
	/// </summary>
	public override string LabelToolTipWhoCanFindMeByPhone => "æ­¤è¨­å®šæŽ§åˆ¶èª°å¯ä»¥ä½¿ç”¨æ‚¨æä¾›çš„æ‰‹æ©Ÿè™Ÿç¢¼æ‰¾åˆ°æ‚¨ã€‚";

	/// <summary>
	/// Key: "Label.Username"
	/// English String: "Username"
	/// </summary>
	public override string LabelUsername => "ä½¿ç”¨è€…åç¨±";

	/// <summary>
	/// Key: "Label.WhoCanFindMeByPhone"
	/// English String: "Who can find me by my phone number?"
	/// </summary>
	public override string LabelWhoCanFindMeByPhone => "èª°å¯ä»¥é€éŽæˆ‘çš„æ‰‹æ©Ÿè™Ÿç¢¼æ‰¾åˆ°æˆ‘ï¼Ÿ";

	/// <summary>
	/// Key: "Message.DefaultError"
	/// English String: "An error occurred, try again later."
	/// </summary>
	public override string MessageDefaultError => "ç™¼ç”ŸéŒ¯èª¤ï¼Œè«‹ç¨å¾Œå†è©¦ã€‚";

	/// <summary>
	/// Key: "Message.EmailForUsernameSuccessBody"
	/// success message
	/// English String: "An email with your username(s) has been sent to you if the email was previously saved on your account."
	/// </summary>
	public override string MessageEmailForUsernameSuccessBody => "å¦‚æžœæ‚¨çš„é›»å­éƒµä»¶åœ°å€å·²ç¶“éŽé©—è­‰ï¼Œæˆ‘å€‘å·²å°‡å«æœ‰æ‚¨çš„ä½¿ç”¨è€…åç¨±çš„é›»å­éƒµä»¶å‚³é€åˆ°æ‚¨çš„é›»å­éƒµä»¶åœ°å€ã€‚";

	/// <summary>
	/// Key: "Message.EmailSuccessBody"
	/// English String: "An email with instructions has been sent to you if the email was previously saved on your account."
	/// </summary>
	public override string MessageEmailSuccessBody => "å¦‚æžœæ‚¨çš„é›»å­éƒµä»¶åœ°å€å·²ç¶“éŽé©—è­‰ï¼Œæˆ‘å€‘å·²å°‡èªªæ˜Žå‚³é€åˆ°æ‚¨çš„é›»å­éƒµä»¶åœ°å€ã€‚";

	/// <summary>
	/// Key: "Message.EmailSuccessTitle"
	/// English String: "Email Sent"
	/// </summary>
	public override string MessageEmailSuccessTitle => "é›»å­éƒµä»¶å·²å‚³é€";

	/// <summary>
	/// Key: "Message.EnterCode"
	/// English String: "A code was sent to your phone if it was previously verified on your account. Please enter it below"
	/// </summary>
	public override string MessageEnterCode => "å¦‚æžœæ‚¨çš„æ‰‹æ©Ÿè™Ÿç¢¼ç¶“éŽé©—è­‰ï¼Œæˆ‘å€‘å·²å°‡ä»£ç¢¼å‚³é€åˆ°æ‚¨çš„æ‰‹æ©Ÿã€‚";

	/// <summary>
	/// Key: "Message.EnterCodeSentToEmail"
	/// Enter the code we just sent to your email.
	/// English String: "Enter the code we just sent to your email."
	/// </summary>
	public override string MessageEnterCodeSentToEmail => "è«‹è¼¸å…¥å‚³é€åˆ°æ‚¨çš„é›»å­éƒµä»¶ä¿¡ç®±çš„é©—è­‰ç¢¼ã€‚";

	/// <summary>
	/// Key: "Message.PhoneForUsernameSuccessBody"
	/// English String: "An SMS with your username(s) has been sent to you if the phone number was previously verified on your account."
	/// </summary>
	public override string MessagePhoneForUsernameSuccessBody => "è‹¥æ‚¨çš„å¸³è™Ÿå·²é©—è­‰æ­¤æ‰‹æ©Ÿè™Ÿç¢¼ï¼Œæˆ‘å€‘å·²å°‡æ‚¨çš„ä½¿ç”¨è€…åç¨±ä»¥ç°¡è¨Šå‚³é€çµ¦æ‚¨ã€‚";

	/// <summary>
	/// Key: "Message.PhoneForUsernameSuccessTitle"
	/// English String: "SMS Sent"
	/// </summary>
	public override string MessagePhoneForUsernameSuccessTitle => "ç°¡è¨Šå·²å‚³é€";

	/// <summary>
	/// Key: "MessageAccountDoesNotHaveAnEmail"
	/// English String: "There is no email linked to this account"
	/// </summary>
	public override string MessageAccountDoesNotHaveAnEmail => "æ­¤å¸³è™Ÿæ²’æœ‰åŠ å…¥é›»å­éƒµä»¶åœ°å€";

	/// <summary>
	/// Key: "MessageAccountNotFoundByEmail"
	/// No account found. Please use a different email.
	/// English String: "No account found. Please use a different email."
	/// </summary>
	public override string MessageAccountNotFoundByEmail => "æ‰¾ä¸åˆ°å¸³è™Ÿï¼Œè«‹ä½¿ç”¨å…¶å®ƒé›»å­éƒµä»¶åœ°å€ã€‚";

	/// <summary>
	/// Key: "MessageAccountNotFoundByPhone"
	/// No account found. Please use a different phone number.
	/// English String: "No account found. Please use a different phone number."
	/// </summary>
	public override string MessageAccountNotFoundByPhone => "æ‰¾ä¸åˆ°å¸³è™Ÿï¼Œè«‹ä½¿ç”¨å…¶å®ƒæ‰‹æ©Ÿè™Ÿç¢¼ã€‚";

	/// <summary>
	/// Key: "MessageAccountRecoveryUnknownError"
	/// English String: "System error. Account could not be restored to this state."
	/// </summary>
	public override string MessageAccountRecoveryUnknownError => "ç³»çµ±éŒ¯èª¤ï¼Œå¸³è™Ÿç„¡æ³•æ¢å¾©æˆæ­¤ç‹€æ…‹ã€‚";

	/// <summary>
	/// Key: "MessageCaptchaError"
	/// English String: "We need to make sure you're not a robot!"
	/// </summary>
	public override string MessageCaptchaError => "æˆ‘å€‘éœ€è¦é€²è¡ŒçœŸäººé©—è­‰ã€‚";

	/// <summary>
	/// Key: "MessageCaptchaFailError"
	/// English String: "The words you typed didn't match the picture. Please try again."
	/// </summary>
	public override string MessageCaptchaFailError => "æ‚¨è¼¸å…¥çš„æ–‡å­—èˆ‡åœ–ç‰‡ä¸ç¬¦ï¼Œè«‹é‡æ–°å˜—è©¦ã€‚";

	/// <summary>
	/// Key: "MessageCredentialsError"
	/// English String: "Your username or password is incorrect. Please check them and try again."
	/// </summary>
	public override string MessageCredentialsError => "æ‚¨çš„ä½¿ç”¨è€…åç¨±æˆ–å¯†ç¢¼ä¸æ­£ç¢ºï¼Œè«‹é‡æ–°å˜—è©¦ã€‚";

	/// <summary>
	/// Key: "MessageFloodCheckedError"
	/// English String: "Too many attempts. Please try again later."
	/// </summary>
	public override string MessageFloodCheckedError => "å˜—è©¦æ¬¡æ•¸éŽå¤šï¼Œè«‹ç¨å¾Œå†è©¦ã€‚";

	/// <summary>
	/// Key: "MessageForgotPasswordFeatureDisabled"
	/// English String: "Feature temporarily disabled. Please try again later."
	/// </summary>
	public override string MessageForgotPasswordFeatureDisabled => "æ­¤åŠŸèƒ½æš«æ™‚åœç”¨ï¼Œè«‹ç¨å¾Œå†è©¦ã€‚";

	/// <summary>
	/// Key: "MessageForgotPasswordSuccess"
	/// English String: "Check your email for login instructions"
	/// </summary>
	public override string MessageForgotPasswordSuccess => "è«‹æŸ¥çœ‹æ‚¨çš„é›»å­éƒµä»¶ä¿¡ç®±å–å¾—ç™»å…¥èªªæ˜Ž";

	/// <summary>
	/// Key: "MessageInvalidAccountStatus"
	/// English String: "Account status prevents resetting password"
	/// </summary>
	public override string MessageInvalidAccountStatus => "æ‚¨çš„å¸³è™Ÿç‹€æ…‹ä¸å…è¨±æ‚¨é‡ç½®å¯†ç¢¼";

	/// <summary>
	/// Key: "MessageInvalidPassword"
	/// English String: "Invalid password"
	/// </summary>
	public override string MessageInvalidPassword => "å¯†ç¢¼ç„¡æ•ˆ";

	/// <summary>
	/// Key: "MessageInvalidTicket"
	/// English String: "We couldn't load this security ticket."
	/// </summary>
	public override string MessageInvalidTicket => "ç„¡æ³•è¼‰å…¥é©—è­‰ç¥¨ã€‚";

	/// <summary>
	/// Key: "MessageInvalidUserNameOrEmail"
	/// English String: "Invalid username, or no email exists"
	/// </summary>
	public override string MessageInvalidUserNameOrEmail => "ä½¿ç”¨è€…åç¨±æˆ–é›»å­éƒµä»¶åœ°å€ç„¡æ•ˆ";

	/// <summary>
	/// Key: "MessageMobileResetPasswordSuccess"
	/// English String: "MobileResetPasswordSuccess"
	/// </summary>
	public override string MessageMobileResetPasswordSuccess => "MobileResetPasswordSuccess";

	/// <summary>
	/// Key: "MessageNoAccountsLinkedToEmail"
	/// English String: "There are no accounts linked to this email address"
	/// </summary>
	public override string MessageNoAccountsLinkedToEmail => "æ²’æœ‰åŠ å…¥æ­¤é›»å­éƒµä»¶çš„å¸³è™Ÿ";

	/// <summary>
	/// Key: "MessageOldUsernameError"
	/// English String: "It looks like you are trying to log in with a username that has changed. Please log in with your new username."
	/// </summary>
	public override string MessageOldUsernameError => "æ‚¨ä¼¼ä¹Žåœ¨ä»¥éŽåŽ»çš„ä½¿ç”¨è€…åç¨±ç™»å…¥ï¼Œè«‹ä»¥æ–°çš„ä½¿ç”¨è€…åç¨±ç™»å…¥ã€‚";

	/// <summary>
	/// Key: "MessagePasswordCannotBeUsed"
	/// English String: "Sorry, that password cannot be used."
	/// </summary>
	public override string MessagePasswordCannotBeUsed => "å°ä¸èµ·ï¼Œç„¡æ³•ä½¿ç”¨è©²å¯†ç¢¼ã€‚";

	/// <summary>
	/// Key: "MessagePasswordsDoNotMatch"
	/// English String: "Passwords do not match"
	/// </summary>
	public override string MessagePasswordsDoNotMatch => "å¯†ç¢¼ä¸ç›¸ç¬¦";

	/// <summary>
	/// Key: "MessageSamlUnauthenticated"
	/// English String: "You must log in to Roblox to finish authenticating."
	/// </summary>
	public override string MessageSamlUnauthenticated => "è‹¥è¦å®Œæˆé©—è­‰ï¼Œè«‹ç™»å…¥ Robloxã€‚";

	/// <summary>
	/// Key: "MessageUnknownError"
	/// English String: "Unknown Error"
	/// </summary>
	public override string MessageUnknownError => "æœªçŸ¥éŒ¯èª¤";

	/// <summary>
	/// Key: "MessageUnknownSystemError"
	/// English String: "System error. Please return to login screen."
	/// </summary>
	public override string MessageUnknownSystemError => "ç³»çµ±éŒ¯èª¤ï¼Œè«‹è¿”å›žç™»å…¥ç•«é¢ã€‚";

	/// <summary>
	/// Key: "Placeholder.Email"
	/// English String: "Email"
	/// </summary>
	public override string PlaceholderEmail => "é›»å­éƒµä»¶åœ°å€";

	/// <summary>
	/// Key: "Placeholder.PhoneNumber"
	/// English String: "Phone Number"
	/// </summary>
	public override string PlaceholderPhoneNumber => "æ‰‹æ©Ÿè™Ÿç¢¼";

	/// <summary>
	/// Key: "Response.PasswordResetSuccess"
	/// Password reset success! Please login again.
	/// English String: "Password reset success! Please login again."
	/// </summary>
	public override string ResponsePasswordResetSuccess => "å¯†ç¢¼é‡ç½®æˆåŠŸï¼Œè«‹é‡æ–°ç™»å…¥ã€‚";

	/// <summary>
	/// Key: "Response.Success"
	/// English String: "Success"
	/// </summary>
	public override string ResponseSuccess => "æˆåŠŸ";

	/// <summary>
	/// Key: "Response.UpdatePasswordFlooded"
	/// English String: "Too many attempts. Please try again later."
	/// </summary>
	public override string ResponseUpdatePasswordFlooded => "å˜—è©¦æ¬¡æ•¸éŽå¤šï¼Œè«‹ç¨å¾Œå†è©¦ã€‚";

	/// <summary>
	/// Key: "Response.UpdatePasswordIncorrect"
	/// English String: "Your current password is incorrect, the password was not changed."
	/// </summary>
	public override string ResponseUpdatePasswordIncorrect => "æ‚¨ç›®å‰çš„å¯†ç¢¼ä¸æ­£ç¢ºï¼Œå¯†ç¢¼ä¸¦æœªè®Šæ›´ã€‚";

	/// <summary>
	/// Key: "Response.UpdatePasswordInputMissing"
	/// English String: "Must include new password and confirm password"
	/// </summary>
	public override string ResponseUpdatePasswordInputMissing => "å¿…é ˆè¼¸å…¥ä¸¦ç¢ºèªæ–°å¯†ç¢¼";

	/// <summary>
	/// Key: "Response.UpdatePasswordMismatch"
	/// English String: "Your new password and confirm password must match"
	/// </summary>
	public override string ResponseUpdatePasswordMismatch => "æ–°å¯†ç¢¼èˆ‡ç¢ºèªå¯†ç¢¼æ¬„ä½å¿…é ˆç›¸ç¬¦";

	public ResetPasswordResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "å–æ¶ˆ";
	}

	protected override string _GetTemplateForActionEmailToResetPassword()
	{
		return "ä½¿ç”¨é›»å­éƒµä»¶é‡ç½®å¯†ç¢¼";
	}

	protected override string _GetTemplateForActionEmailToRetriveUsername()
	{
		return "ä½¿ç”¨é›»å­éƒµä»¶å–å¾—ä½¿ç”¨è€…åç¨±";
	}

	protected override string _GetTemplateForActionOk()
	{
		return "ç¢ºå®š";
	}

	protected override string _GetTemplateForActionPhoneToResetPassword()
	{
		return "ä½¿ç”¨æ‰‹æ©Ÿè™Ÿç¢¼é‡ç½®å¯†ç¢¼";
	}

	protected override string _GetTemplateForActionPhoneToRetriveUsername()
	{
		return "ä½¿ç”¨æ‰‹æ©Ÿè™Ÿç¢¼å–å¾—ä½¿ç”¨è€…åç¨±";
	}

	protected override string _GetTemplateForActionVerify()
	{
		return "é©—è­‰";
	}

	/// <summary>
	/// Key: "Description.ChangePasswordEmail.HtmlBody1"
	/// email body for change password email
	/// English String: "We noticed that the password changed for your Roblox account: {userName}. If you didn't intend to change it, or you think someone else changed it by mistake, please click this link to undo the action:{lineBreak} {actionLink} {lineBreak}{lineBreak}If you are happy with your new Roblox password, you don't have to do anything! It's already set up. Please do not reply to this message. If you have any questions, please see the Roblox help page (https://www.roblox.com/help)."
	/// </summary>
	public override string DescriptionChangePasswordEmailHtmlBody1(string userName, string lineBreak, string actionLink)
	{
		return $"æˆ‘å€‘ç™¼ç¾æ‚¨è®Šæ›´äº†æ‚¨çš„å¸³è™Ÿ {userName} çš„å¯†ç¢¼ã€‚è‹¥æ‚¨æ²’æœ‰è¦è®Šæ›´æ‚¨çš„å¯†ç¢¼ï¼Œè«‹æŒ‰ä¸‹æ­¤é€£çµå¾©åŽŸæ‚¨çš„å¯†ç¢¼ï¼š{lineBreak} {actionLink} {lineBreak}{lineBreak}è‹¥æ‚¨æœ‰è®Šæ›´å¯†ç¢¼ï¼Œæ‚¨çš„è®Šæ›´å·²ç¶“ç”Ÿæ•ˆï¼Œæ‚¨ä¸éœ€è¦æŽ¡å–ä»»ä½•å‹•ä½œã€‚è«‹å‹¿å›žè¦†æ­¤é›»å­éƒµä»¶ã€‚è‹¥æ‚¨æœ‰ä»»ä½•å•é¡Œï¼Œè«‹å‰å¾€ Roblox å”åŠ©é é¢ï¼ˆhttps://www.roblox.com/helpï¼‰ã€‚";
	}

	protected override string _GetTemplateForDescriptionChangePasswordEmailHtmlBody1()
	{
		return "æˆ‘å€‘ç™¼ç¾æ‚¨è®Šæ›´äº†æ‚¨çš„å¸³è™Ÿ {userName} çš„å¯†ç¢¼ã€‚è‹¥æ‚¨æ²’æœ‰è¦è®Šæ›´æ‚¨çš„å¯†ç¢¼ï¼Œè«‹æŒ‰ä¸‹æ­¤é€£çµå¾©åŽŸæ‚¨çš„å¯†ç¢¼ï¼š{lineBreak} {actionLink} {lineBreak}{lineBreak}è‹¥æ‚¨æœ‰è®Šæ›´å¯†ç¢¼ï¼Œæ‚¨çš„è®Šæ›´å·²ç¶“ç”Ÿæ•ˆï¼Œæ‚¨ä¸éœ€è¦æŽ¡å–ä»»ä½•å‹•ä½œã€‚è«‹å‹¿å›žè¦†æ­¤é›»å­éƒµä»¶ã€‚è‹¥æ‚¨æœ‰ä»»ä½•å•é¡Œï¼Œè«‹å‰å¾€ Roblox å”åŠ©é é¢ï¼ˆhttps://www.roblox.com/helpï¼‰ã€‚";
	}

	protected override string _GetTemplateForDescriptionEmailToResetPassword()
	{
		return "è‹¥è¦é‡ç½®æ‚¨çš„å¯†ç¢¼ï¼Œè«‹è¼¸å…¥æ‚¨çš„é›»å­éƒµä»¶åœ°å€ã€‚";
	}

	protected override string _GetTemplateForDescriptionEmailToRetriveUsername()
	{
		return "è‹¥è¦å–å¾—æ‚¨çš„ä½¿ç”¨è€…åç¨±ï¼Œè«‹è¼¸å…¥æ‚¨çš„é›»å­éƒµä»¶åœ°å€ã€‚";
	}

	/// <summary>
	/// Key: "Description.PasswordChangeEmail.BodyPlainText"
	/// password reset plaintext email message
	/// English String: "We noticed that the password changed for your Roblox account: {userName}. If you didn't intend to change it, or you think someone else changed it by mistake, please click this link to undo the action:\n{urlWithTicket}\n\nIf you are happy with your new Roblox password, you don't have to do anything! It's already set up. Please do not reply to this message. If you have any questions, please see the Roblox help page (https://www.roblox.com/help)."
	/// </summary>
	public override string DescriptionPasswordChangeEmailBodyPlainText(string userName, string urlWithTicket)
	{
		return $"æˆ‘å€‘ç™¼ç¾æ‚¨è®Šæ›´äº†æ‚¨çš„å¸³è™Ÿ {userName} çš„å¯†ç¢¼ã€‚è‹¥æ‚¨æ²’æœ‰è¦è®Šæ›´æ‚¨çš„å¯†ç¢¼ï¼Œè«‹æŒ‰ä¸‹æ­¤é€£çµå¾©åŽŸæ‚¨çš„å¯†ç¢¼ï¼š\n{urlWithTicket}\n\nè‹¥æ‚¨æœ‰è®Šæ›´å¯†ç¢¼ï¼Œæ‚¨çš„è®Šæ›´å·²ç¶“ç”Ÿæ•ˆï¼Œæ‚¨ä¸éœ€è¦æŽ¡å–ä»»ä½•å‹•ä½œã€‚è«‹å‹¿å›žè¦†æ­¤é›»å­éƒµä»¶ã€‚è‹¥æ‚¨æœ‰ä»»ä½•å•é¡Œï¼Œè«‹å‰å¾€ Roblox å”åŠ©é é¢ï¼ˆhttps://www.roblox.com/helpï¼‰ã€‚";
	}

	protected override string _GetTemplateForDescriptionPasswordChangeEmailBodyPlainText()
	{
		return "æˆ‘å€‘ç™¼ç¾æ‚¨è®Šæ›´äº†æ‚¨çš„å¸³è™Ÿ {userName} çš„å¯†ç¢¼ã€‚è‹¥æ‚¨æ²’æœ‰è¦è®Šæ›´æ‚¨çš„å¯†ç¢¼ï¼Œè«‹æŒ‰ä¸‹æ­¤é€£çµå¾©åŽŸæ‚¨çš„å¯†ç¢¼ï¼š\n{urlWithTicket}\n\nè‹¥æ‚¨æœ‰è®Šæ›´å¯†ç¢¼ï¼Œæ‚¨çš„è®Šæ›´å·²ç¶“ç”Ÿæ•ˆï¼Œæ‚¨ä¸éœ€è¦æŽ¡å–ä»»ä½•å‹•ä½œã€‚è«‹å‹¿å›žè¦†æ­¤é›»å­éƒµä»¶ã€‚è‹¥æ‚¨æœ‰ä»»ä½•å•é¡Œï¼Œè«‹å‰å¾€ Roblox å”åŠ©é é¢ï¼ˆhttps://www.roblox.com/helpï¼‰ã€‚";
	}

	/// <summary>
	/// Key: "Description.PasswordChangeEmail.From"
	/// name of the sender as shown in from field of the email
	/// English String: "\"Roblox Password Reset\" {fromEmailAddress}"
	/// </summary>
	public override string DescriptionPasswordChangeEmailFrom(string fromEmailAddress)
	{
		return $"ã€ŒRoblox å¯†ç¢¼é‡ç½®ã€{fromEmailAddress}";
	}

	protected override string _GetTemplateForDescriptionPasswordChangeEmailFrom()
	{
		return "ã€ŒRoblox å¯†ç¢¼é‡ç½®ã€{fromEmailAddress}";
	}

	protected override string _GetTemplateForDescriptionPasswordChangeEmailSubject()
	{
		return "Roblox å¯†ç¢¼é‡ç½®";
	}

	/// <summary>
	/// Key: "Description.PasswordResetEmail.From"
	/// The "From" field for the password reset email
	/// English String: "{escapeLiteralStart}Roblox Password Reset{escapeLiteralEnd} {fromEmailAddress}"
	/// </summary>
	public override string DescriptionPasswordResetEmailFrom(string escapeLiteralStart, string escapeLiteralEnd, string fromEmailAddress)
	{
		return $"{escapeLiteralStart}Roblox å¯†ç¢¼é‡ç½®{escapeLiteralEnd} {fromEmailAddress}";
	}

	protected override string _GetTemplateForDescriptionPasswordResetEmailFrom()
	{
		return "{escapeLiteralStart}Roblox å¯†ç¢¼é‡ç½®{escapeLiteralEnd} {fromEmailAddress}";
	}

	/// <summary>
	/// Key: "Description.PasswordResetEmail.HtmlBody"
	/// This email is sent when a user requests a password reset.
	/// English String: "We have received a request to reset the password for your Roblox account: {emailOrUsername}{lineBreak}{lineBreak}If you submitted this request, please click the button below to proceed.{lineBreak}This button will be active for {passwordResetTicketHours} hours, {passwordResetTicketMinutes} minutes. If you do not wish to reset your password, please disregard this notice.{lineBreak}{lineBreak}{aTagWithStartHref}{resetPasswordUrl}{hrefEnd}{buttonStart}Reset Password{buttonEnd}{aTagEnd}"
	/// </summary>
	public override string DescriptionPasswordResetEmailHtmlBody(string emailOrUsername, string lineBreak, string passwordResetTicketHours, string passwordResetTicketMinutes, string aTagWithStartHref, string resetPasswordUrl, string hrefEnd, string buttonStart, string buttonEnd, string aTagEnd)
	{
		return $"æˆ‘å€‘æ”¶åˆ°æ‚¨çš„ Roblox å¸³è™Ÿ {emailOrUsername} çš„å¯†ç¢¼é‡ç½®è«‹æ±‚ã€‚{lineBreak}{lineBreak}è‹¥æ‚¨æœ‰æäº¤æ­¤è«‹æ±‚ï¼Œè«‹æŒ‰ä¸‹ä¸‹æ–¹é€£çµï¼Œæˆ–å°‡é€£çµè²¼åœ¨ç€è¦½å™¨ã€‚{lineBreak}æ­¤æŒ‰éˆ•å°‡åœ¨ {passwordResetTicketHours} å°æ™‚ {passwordResetTicketMinutes} åˆ†é˜å…§æœ‰æ•ˆã€‚è‹¥æ‚¨ä¸æƒ³é‡ç½®æ‚¨çš„å¯†ç¢¼ï¼Œè«‹å¿½ç•¥æ­¤é›»å­éƒµä»¶ã€‚{lineBreak}{lineBreak}{aTagWithStartHref}{resetPasswordUrl}{hrefEnd}{buttonStart}é‡ç½®å¯†ç¢¼{buttonEnd}{aTagEnd}";
	}

	protected override string _GetTemplateForDescriptionPasswordResetEmailHtmlBody()
	{
		return "æˆ‘å€‘æ”¶åˆ°æ‚¨çš„ Roblox å¸³è™Ÿ {emailOrUsername} çš„å¯†ç¢¼é‡ç½®è«‹æ±‚ã€‚{lineBreak}{lineBreak}è‹¥æ‚¨æœ‰æäº¤æ­¤è«‹æ±‚ï¼Œè«‹æŒ‰ä¸‹ä¸‹æ–¹é€£çµï¼Œæˆ–å°‡é€£çµè²¼åœ¨ç€è¦½å™¨ã€‚{lineBreak}æ­¤æŒ‰éˆ•å°‡åœ¨ {passwordResetTicketHours} å°æ™‚ {passwordResetTicketMinutes} åˆ†é˜å…§æœ‰æ•ˆã€‚è‹¥æ‚¨ä¸æƒ³é‡ç½®æ‚¨çš„å¯†ç¢¼ï¼Œè«‹å¿½ç•¥æ­¤é›»å­éƒµä»¶ã€‚{lineBreak}{lineBreak}{aTagWithStartHref}{resetPasswordUrl}{hrefEnd}{buttonStart}é‡ç½®å¯†ç¢¼{buttonEnd}{aTagEnd}";
	}

	/// <summary>
	/// Key: "Description.PasswordResetEmail.PlainBody"
	/// This email is sent when a user requests a password reset.
	/// English String: "We have received a request to reset the password for your Roblox account: {emailOrUsername}{lineBreak}{lineBreak}If you submitted this request, please click the link below or paste it into a web browser to proceed.{lineBreak}This link will be active for {passwordResetTicketHours} hours, {passwordResetTicketMinutes} minutes. If you do not wish to reset your password, please disregard this notice.{lineBreak}{lineBreak}{resetPasswordUrl}"
	/// </summary>
	public override string DescriptionPasswordResetEmailPlainBody(string emailOrUsername, string lineBreak, string passwordResetTicketHours, string passwordResetTicketMinutes, string resetPasswordUrl)
	{
		return $"æˆ‘å€‘æ”¶åˆ°æ‚¨çš„ Roblox å¸³è™Ÿ {emailOrUsername} çš„å¯†ç¢¼é‡ç½®è«‹æ±‚ã€‚{lineBreak}{lineBreak}è‹¥æ‚¨æœ‰æäº¤æ­¤è«‹æ±‚ï¼Œè«‹æŒ‰ä¸‹ä¸‹æ–¹é€£çµï¼Œæˆ–å°‡é€£çµè²¼åœ¨ç€è¦½å™¨ã€‚{lineBreak}æ­¤æŒ‰éˆ•å°‡åœ¨ {passwordResetTicketHours} å°æ™‚ {passwordResetTicketMinutes} åˆ†é˜å…§æœ‰æ•ˆã€‚è‹¥æ‚¨ä¸æƒ³é‡ç½®æ‚¨çš„å¯†ç¢¼ï¼Œè«‹å¿½ç•¥æ­¤é›»å­éƒµä»¶ã€‚{lineBreak}{lineBreak}{resetPasswordUrl}";
	}

	protected override string _GetTemplateForDescriptionPasswordResetEmailPlainBody()
	{
		return "æˆ‘å€‘æ”¶åˆ°æ‚¨çš„ Roblox å¸³è™Ÿ {emailOrUsername} çš„å¯†ç¢¼é‡ç½®è«‹æ±‚ã€‚{lineBreak}{lineBreak}è‹¥æ‚¨æœ‰æäº¤æ­¤è«‹æ±‚ï¼Œè«‹æŒ‰ä¸‹ä¸‹æ–¹é€£çµï¼Œæˆ–å°‡é€£çµè²¼åœ¨ç€è¦½å™¨ã€‚{lineBreak}æ­¤æŒ‰éˆ•å°‡åœ¨ {passwordResetTicketHours} å°æ™‚ {passwordResetTicketMinutes} åˆ†é˜å…§æœ‰æ•ˆã€‚è‹¥æ‚¨ä¸æƒ³é‡ç½®æ‚¨çš„å¯†ç¢¼ï¼Œè«‹å¿½ç•¥æ­¤é›»å­éƒµä»¶ã€‚{lineBreak}{lineBreak}{resetPasswordUrl}";
	}

	protected override string _GetTemplateForDescriptionPasswordResetEmailSubject()
	{
		return "Roblox å¸³è™Ÿå¯†ç¢¼é‡ç½®";
	}

	protected override string _GetTemplateForDescriptionPhoneToResetPassword()
	{
		return "è‹¥è¦é‡ç½®æ‚¨çš„å¯†ç¢¼ï¼Œè«‹è¼¸å…¥æ‚¨çš„æ‰‹æ©Ÿè™Ÿç¢¼ã€‚";
	}

	protected override string _GetTemplateForDescriptionPhoneToRetriveUsername()
	{
		return "è‹¥è¦å–å¾—æ‚¨çš„ä½¿ç”¨è€…åç¨±ï¼Œè«‹è¼¸å…¥æ‚¨çš„æ‰‹æ©Ÿè™Ÿç¢¼ã€‚";
	}

	protected override string _GetTemplateForHeadingVerifyCode()
	{
		return "é©—è­‰ç¢¼";
	}

	protected override string _GetTemplateForHeadingVerifyPhone()
	{
		return "é©—è­‰æ‰‹æ©Ÿè™Ÿç¢¼";
	}

	protected override string _GetTemplateForHeadingForgetPasswordOrUsername()
	{
		return "å¿˜è¨˜å¯†ç¢¼æˆ–ä½¿ç”¨è€…åç¨±";
	}

	protected override string _GetTemplateForLabelActionButtonYes()
	{
		return "æ˜¯";
	}

	protected override string _GetTemplateForLabelForgetMyPassword()
	{
		return "å¿˜è¨˜å¯†ç¢¼äº†";
	}

	protected override string _GetTemplateForLabelForgetMyUsername()
	{
		return "å¿˜è¨˜ä½¿ç”¨è€…åç¨±äº†";
	}

	protected override string _GetTemplateForLabelInvalidEmail()
	{
		return "é›»å­éƒµä»¶åœ°å€ç„¡æ•ˆ";
	}

	protected override string _GetTemplateForLabelInvalidPhoneNumber()
	{
		return "æ‰‹æ©Ÿè™Ÿç¢¼ç„¡æ•ˆ";
	}

	protected override string _GetTemplateForLabelNeutralButtonOk()
	{
		return "ç¢ºå®š";
	}

	protected override string _GetTemplateForLabelPassword()
	{
		return "å¯†ç¢¼";
	}

	protected override string _GetTemplateForLabelResendCode()
	{
		return "é‡æ–°å‚³é€é©—è­‰ç¢¼";
	}

	protected override string _GetTemplateForLabelSubmit()
	{
		return "æäº¤";
	}

	protected override string _GetTemplateForLabelToolTipWhoCanFindMeByPhone()
	{
		return "æ­¤è¨­å®šæŽ§åˆ¶èª°å¯ä»¥ä½¿ç”¨æ‚¨æä¾›çš„æ‰‹æ©Ÿè™Ÿç¢¼æ‰¾åˆ°æ‚¨ã€‚";
	}

	protected override string _GetTemplateForLabelUsername()
	{
		return "ä½¿ç”¨è€…åç¨±";
	}

	protected override string _GetTemplateForLabelWhoCanFindMeByPhone()
	{
		return "èª°å¯ä»¥é€éŽæˆ‘çš„æ‰‹æ©Ÿè™Ÿç¢¼æ‰¾åˆ°æˆ‘ï¼Ÿ";
	}

	/// <summary>
	/// Key: "Message.CantSendEmailWarning"
	/// English String: "If you did not give us a {styleStart}real email address{styleEnd} when you created your account, we cannot send you an email."
	/// </summary>
	public override string MessageCantSendEmailWarning(string styleStart, string styleEnd)
	{
		return $"è‹¥æ‚¨åœ¨å»ºç«‹å¸³è™Ÿæ™‚æ²’æœ‰æä¾›{styleStart}çœŸå¯¦çš„é›»å­éƒµä»¶åœ°å€{styleEnd}ï¼Œæˆ‘å€‘å°‡ç„¡æ³•å‚³é€é›»å­éƒµä»¶çµ¦æ‚¨ã€‚";
	}

	protected override string _GetTemplateForMessageCantSendEmailWarning()
	{
		return "è‹¥æ‚¨åœ¨å»ºç«‹å¸³è™Ÿæ™‚æ²’æœ‰æä¾›{styleStart}çœŸå¯¦çš„é›»å­éƒµä»¶åœ°å€{styleEnd}ï¼Œæˆ‘å€‘å°‡ç„¡æ³•å‚³é€é›»å­éƒµä»¶çµ¦æ‚¨ã€‚";
	}

	protected override string _GetTemplateForMessageDefaultError()
	{
		return "ç™¼ç”ŸéŒ¯èª¤ï¼Œè«‹ç¨å¾Œå†è©¦ã€‚";
	}

	protected override string _GetTemplateForMessageEmailForUsernameSuccessBody()
	{
		return "å¦‚æžœæ‚¨çš„é›»å­éƒµä»¶åœ°å€å·²ç¶“éŽé©—è­‰ï¼Œæˆ‘å€‘å·²å°‡å«æœ‰æ‚¨çš„ä½¿ç”¨è€…åç¨±çš„é›»å­éƒµä»¶å‚³é€åˆ°æ‚¨çš„é›»å­éƒµä»¶åœ°å€ã€‚";
	}

	protected override string _GetTemplateForMessageEmailSuccessBody()
	{
		return "å¦‚æžœæ‚¨çš„é›»å­éƒµä»¶åœ°å€å·²ç¶“éŽé©—è­‰ï¼Œæˆ‘å€‘å·²å°‡èªªæ˜Žå‚³é€åˆ°æ‚¨çš„é›»å­éƒµä»¶åœ°å€ã€‚";
	}

	protected override string _GetTemplateForMessageEmailSuccessTitle()
	{
		return "é›»å­éƒµä»¶å·²å‚³é€";
	}

	protected override string _GetTemplateForMessageEnterCode()
	{
		return "å¦‚æžœæ‚¨çš„æ‰‹æ©Ÿè™Ÿç¢¼ç¶“éŽé©—è­‰ï¼Œæˆ‘å€‘å·²å°‡ä»£ç¢¼å‚³é€åˆ°æ‚¨çš„æ‰‹æ©Ÿã€‚";
	}

	protected override string _GetTemplateForMessageEnterCodeSentToEmail()
	{
		return "è«‹è¼¸å…¥å‚³é€åˆ°æ‚¨çš„é›»å­éƒµä»¶ä¿¡ç®±çš„é©—è­‰ç¢¼ã€‚";
	}

	protected override string _GetTemplateForMessagePhoneForUsernameSuccessBody()
	{
		return "è‹¥æ‚¨çš„å¸³è™Ÿå·²é©—è­‰æ­¤æ‰‹æ©Ÿè™Ÿç¢¼ï¼Œæˆ‘å€‘å·²å°‡æ‚¨çš„ä½¿ç”¨è€…åç¨±ä»¥ç°¡è¨Šå‚³é€çµ¦æ‚¨ã€‚";
	}

	protected override string _GetTemplateForMessagePhoneForUsernameSuccessTitle()
	{
		return "ç°¡è¨Šå·²å‚³é€";
	}

	protected override string _GetTemplateForMessageAccountDoesNotHaveAnEmail()
	{
		return "æ­¤å¸³è™Ÿæ²’æœ‰åŠ å…¥é›»å­éƒµä»¶åœ°å€";
	}

	protected override string _GetTemplateForMessageAccountNotFoundByEmail()
	{
		return "æ‰¾ä¸åˆ°å¸³è™Ÿï¼Œè«‹ä½¿ç”¨å…¶å®ƒé›»å­éƒµä»¶åœ°å€ã€‚";
	}

	protected override string _GetTemplateForMessageAccountNotFoundByPhone()
	{
		return "æ‰¾ä¸åˆ°å¸³è™Ÿï¼Œè«‹ä½¿ç”¨å…¶å®ƒæ‰‹æ©Ÿè™Ÿç¢¼ã€‚";
	}

	protected override string _GetTemplateForMessageAccountRecoveryUnknownError()
	{
		return "ç³»çµ±éŒ¯èª¤ï¼Œå¸³è™Ÿç„¡æ³•æ¢å¾©æˆæ­¤ç‹€æ…‹ã€‚";
	}

	protected override string _GetTemplateForMessageCaptchaError()
	{
		return "æˆ‘å€‘éœ€è¦é€²è¡ŒçœŸäººé©—è­‰ã€‚";
	}

	protected override string _GetTemplateForMessageCaptchaFailError()
	{
		return "æ‚¨è¼¸å…¥çš„æ–‡å­—èˆ‡åœ–ç‰‡ä¸ç¬¦ï¼Œè«‹é‡æ–°å˜—è©¦ã€‚";
	}

	protected override string _GetTemplateForMessageCredentialsError()
	{
		return "æ‚¨çš„ä½¿ç”¨è€…åç¨±æˆ–å¯†ç¢¼ä¸æ­£ç¢ºï¼Œè«‹é‡æ–°å˜—è©¦ã€‚";
	}

	protected override string _GetTemplateForMessageFloodCheckedError()
	{
		return "å˜—è©¦æ¬¡æ•¸éŽå¤šï¼Œè«‹ç¨å¾Œå†è©¦ã€‚";
	}

	protected override string _GetTemplateForMessageForgotPasswordFeatureDisabled()
	{
		return "æ­¤åŠŸèƒ½æš«æ™‚åœç”¨ï¼Œè«‹ç¨å¾Œå†è©¦ã€‚";
	}

	protected override string _GetTemplateForMessageForgotPasswordSuccess()
	{
		return "è«‹æŸ¥çœ‹æ‚¨çš„é›»å­éƒµä»¶ä¿¡ç®±å–å¾—ç™»å…¥èªªæ˜Ž";
	}

	protected override string _GetTemplateForMessageInvalidAccountStatus()
	{
		return "æ‚¨çš„å¸³è™Ÿç‹€æ…‹ä¸å…è¨±æ‚¨é‡ç½®å¯†ç¢¼";
	}

	protected override string _GetTemplateForMessageInvalidPassword()
	{
		return "å¯†ç¢¼ç„¡æ•ˆ";
	}

	protected override string _GetTemplateForMessageInvalidTicket()
	{
		return "ç„¡æ³•è¼‰å…¥é©—è­‰ç¥¨ã€‚";
	}

	protected override string _GetTemplateForMessageInvalidUserNameOrEmail()
	{
		return "ä½¿ç”¨è€…åç¨±æˆ–é›»å­éƒµä»¶åœ°å€ç„¡æ•ˆ";
	}

	protected override string _GetTemplateForMessageMobileResetPasswordSuccess()
	{
		return "MobileResetPasswordSuccess";
	}

	protected override string _GetTemplateForMessageNoAccountsLinkedToEmail()
	{
		return "æ²’æœ‰åŠ å…¥æ­¤é›»å­éƒµä»¶çš„å¸³è™Ÿ";
	}

	protected override string _GetTemplateForMessageOldUsernameError()
	{
		return "æ‚¨ä¼¼ä¹Žåœ¨ä»¥éŽåŽ»çš„ä½¿ç”¨è€…åç¨±ç™»å…¥ï¼Œè«‹ä»¥æ–°çš„ä½¿ç”¨è€…åç¨±ç™»å…¥ã€‚";
	}

	protected override string _GetTemplateForMessagePasswordCannotBeUsed()
	{
		return "å°ä¸èµ·ï¼Œç„¡æ³•ä½¿ç”¨è©²å¯†ç¢¼ã€‚";
	}

	/// <summary>
	/// Key: "MessagePasswordResetTicketExpired"
	/// English String: "Sorry, password reset requests expire {expirationHour} hours, {expirationMinute} minutes after issuance. Try requesting another password reset ticket again."
	/// </summary>
	public override string MessagePasswordResetTicketExpired(string expirationHour, string expirationMinute)
	{
		return $"å°ä¸èµ·ï¼Œå¯†ç¢¼é‡ç½®è«‹æ±‚åœ¨ {expirationHour} å°æ™‚ {expirationMinute} åˆ†é˜å¾Œå¤±æ•ˆã€‚è«‹é‡æ–°å˜—è©¦è«‹æ±‚ã€‚";
	}

	protected override string _GetTemplateForMessagePasswordResetTicketExpired()
	{
		return "å°ä¸èµ·ï¼Œå¯†ç¢¼é‡ç½®è«‹æ±‚åœ¨ {expirationHour} å°æ™‚ {expirationMinute} åˆ†é˜å¾Œå¤±æ•ˆã€‚è«‹é‡æ–°å˜—è©¦è«‹æ±‚ã€‚";
	}

	protected override string _GetTemplateForMessagePasswordsDoNotMatch()
	{
		return "å¯†ç¢¼ä¸ç›¸ç¬¦";
	}

	protected override string _GetTemplateForMessageSamlUnauthenticated()
	{
		return "è‹¥è¦å®Œæˆé©—è­‰ï¼Œè«‹ç™»å…¥ Robloxã€‚";
	}

	protected override string _GetTemplateForMessageUnknownError()
	{
		return "æœªçŸ¥éŒ¯èª¤";
	}

	protected override string _GetTemplateForMessageUnknownSystemError()
	{
		return "ç³»çµ±éŒ¯èª¤ï¼Œè«‹è¿”å›žç™»å…¥ç•«é¢ã€‚";
	}

	protected override string _GetTemplateForPlaceholderEmail()
	{
		return "é›»å­éƒµä»¶åœ°å€";
	}

	/// <summary>
	/// Key: "Placeholder.EnterCode"
	/// English String: "Enter Code ({codeLength}-digit)"
	/// </summary>
	public override string PlaceholderEnterCode(string codeLength)
	{
		return $"è¼¸å…¥é©—è­‰ç¢¼ï¼ˆ{codeLength} ä½æ•¸ï¼‰";
	}

	protected override string _GetTemplateForPlaceholderEnterCode()
	{
		return "è¼¸å…¥é©—è­‰ç¢¼ï¼ˆ{codeLength} ä½æ•¸ï¼‰";
	}

	protected override string _GetTemplateForPlaceholderPhoneNumber()
	{
		return "æ‰‹æ©Ÿè™Ÿç¢¼";
	}

	protected override string _GetTemplateForResponsePasswordResetSuccess()
	{
		return "å¯†ç¢¼é‡ç½®æˆåŠŸï¼Œè«‹é‡æ–°ç™»å…¥ã€‚";
	}

	protected override string _GetTemplateForResponseSuccess()
	{
		return "æˆåŠŸ";
	}

	protected override string _GetTemplateForResponseUpdatePasswordFlooded()
	{
		return "å˜—è©¦æ¬¡æ•¸éŽå¤šï¼Œè«‹ç¨å¾Œå†è©¦ã€‚";
	}

	protected override string _GetTemplateForResponseUpdatePasswordIncorrect()
	{
		return "æ‚¨ç›®å‰çš„å¯†ç¢¼ä¸æ­£ç¢ºï¼Œå¯†ç¢¼ä¸¦æœªè®Šæ›´ã€‚";
	}

	protected override string _GetTemplateForResponseUpdatePasswordInputMissing()
	{
		return "å¿…é ˆè¼¸å…¥ä¸¦ç¢ºèªæ–°å¯†ç¢¼";
	}

	protected override string _GetTemplateForResponseUpdatePasswordMismatch()
	{
		return "æ–°å¯†ç¢¼èˆ‡ç¢ºèªå¯†ç¢¼æ¬„ä½å¿…é ˆç›¸ç¬¦";
	}
}


}
