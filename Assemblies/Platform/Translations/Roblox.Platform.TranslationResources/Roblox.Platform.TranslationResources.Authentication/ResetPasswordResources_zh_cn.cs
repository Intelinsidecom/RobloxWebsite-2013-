namespace Roblox.Platform.TranslationResources.Authentication {
    /// <summary>

/// This class overrides ResetPasswordResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ResetPasswordResources_zh_cn : ResetPasswordResources_en_us, IResetPasswordResources, ITranslationResources
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
	public override string ActionEmailToResetPassword => "ä½¿ç”¨ç”µå­é‚®ä»¶ä»¥é‡ç½®å¯†ç ";

	/// <summary>
	/// Key: "Action.EmailToRetriveUsername"
	/// English String: "Use email to retrieve username"
	/// </summary>
	public override string ActionEmailToRetriveUsername => "ä½¿ç”¨ç”µå­é‚®ä»¶ä»¥å–å›žç”¨æˆ·å";

	/// <summary>
	/// Key: "Action.Ok"
	/// OK
	/// English String: "OK"
	/// </summary>
	public override string ActionOk => "å¥½";

	/// <summary>
	/// Key: "Action.PhoneToResetPassword"
	/// English String: "Use phone number to reset password"
	/// </summary>
	public override string ActionPhoneToResetPassword => "ä½¿ç”¨æ‰‹æœºå·ç ä»¥é‡ç½®å¯†ç ";

	/// <summary>
	/// Key: "Action.PhoneToRetriveUsername"
	/// English String: "Use phone number to retrieve username"
	/// </summary>
	public override string ActionPhoneToRetriveUsername => "ä½¿ç”¨æ‰‹æœºå·ç ä»¥å–å›žç”¨æˆ·å";

	/// <summary>
	/// Key: "Action.Verify"
	/// English String: "Verify"
	/// </summary>
	public override string ActionVerify => "éªŒè¯";

	/// <summary>
	/// Key: "Description.EmailToResetPassword"
	/// English String: "Enter your email to reset your password."
	/// </summary>
	public override string DescriptionEmailToResetPassword => "è¾“å…¥ä½ çš„ç”µå­é‚®ä»¶ä»¥é‡ç½®ä½ çš„å¯†ç ã€‚";

	/// <summary>
	/// Key: "Description.EmailToRetriveUsername"
	/// English String: "Enter your email to retrieve your username."
	/// </summary>
	public override string DescriptionEmailToRetriveUsername => "è¾“å…¥ä½ çš„ç”µå­é‚®ä»¶ä»¥å–å›žä½ çš„ç”¨æˆ·åã€‚";

	/// <summary>
	/// Key: "Description.PasswordChangeEmail.Subject"
	/// email subject to change password
	/// English String: "Roblox Password Reset"
	/// </summary>
	public override string DescriptionPasswordChangeEmailSubject => "Roblox å¯†ç é‡ç½®";

	/// <summary>
	/// Key: "Description.PasswordResetEmail.Subject"
	/// Subject for password reset email
	/// English String: "Roblox Account Password Reset"
	/// </summary>
	public override string DescriptionPasswordResetEmailSubject => "Roblox å¸æˆ·å¯†ç é‡ç½®";

	/// <summary>
	/// Key: "Description.PhoneToResetPassword"
	/// English String: "Enter your phone number to reset your password."
	/// </summary>
	public override string DescriptionPhoneToResetPassword => "è¾“å…¥ä½ çš„æ‰‹æœºå·ç ä»¥é‡ç½®ä½ çš„å¯†ç ã€‚";

	/// <summary>
	/// Key: "Description.PhoneToRetriveUsername"
	/// English String: "Enter your phone number to retrieve your username."
	/// </summary>
	public override string DescriptionPhoneToRetriveUsername => "è¾“å…¥ä½ çš„æ‰‹æœºå·ç ä»¥å–å›žä½ çš„ç”¨æˆ·åã€‚";

	/// <summary>
	/// Key: "Heading.VerifyCode"
	/// verify code heading
	/// English String: "Verify Code"
	/// </summary>
	public override string HeadingVerifyCode => "éªŒè¯ç ";

	/// <summary>
	/// Key: "Heading.VerifyPhone"
	/// English String: "Verify Phone"
	/// </summary>
	public override string HeadingVerifyPhone => "éªŒè¯æ‰‹æœº";

	/// <summary>
	/// Key: "HeadingForgetPasswordOrUsername"
	/// English String: "Forgot Password or Username"
	/// </summary>
	public override string HeadingForgetPasswordOrUsername => "å¿˜è®°å¯†ç æˆ–ç”¨æˆ·å";

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
	public override string LabelForgetMyPassword => "å¿˜è®°æˆ‘çš„å¯†ç ";

	/// <summary>
	/// Key: "Label.ForgetMyUsername"
	/// English String: "Forgot My Username"
	/// </summary>
	public override string LabelForgetMyUsername => "å¿˜è®°æˆ‘çš„ç”¨æˆ·å";

	/// <summary>
	/// Key: "Label.InvalidEmail"
	/// English String: "Invalid email"
	/// </summary>
	public override string LabelInvalidEmail => "ç”µå­é‚®ä»¶æ— æ•ˆ";

	/// <summary>
	/// Key: "Label.InvalidPhoneNumber"
	/// English String: "Invalid phone number"
	/// </summary>
	public override string LabelInvalidPhoneNumber => "æ‰‹æœºå·ç æ— æ•ˆ";

	/// <summary>
	/// Key: "Label.NeutralButtonOk"
	/// ok button label
	/// English String: "OK"
	/// </summary>
	public override string LabelNeutralButtonOk => "å¥½";

	/// <summary>
	/// Key: "Label.Password"
	/// label
	/// English String: "Password"
	/// </summary>
	public override string LabelPassword => "å¯†ç ";

	/// <summary>
	/// Key: "Label.ResendCode"
	/// English String: "Resend Code"
	/// </summary>
	public override string LabelResendCode => "é‡æ–°å‘é€éªŒè¯ç ";

	/// <summary>
	/// Key: "Label.Submit"
	/// English String: "Submit"
	/// </summary>
	public override string LabelSubmit => "æäº¤";

	/// <summary>
	/// Key: "Label.ToolTip.WhoCanFindMeByPhone"
	/// English String: "This setting controls who can find you using the phone number you provided."
	/// </summary>
	public override string LabelToolTipWhoCanFindMeByPhone => "æ­¤è®¾ç½®å¯æŽ§åˆ¶è°å¯ä»¥é€šè¿‡ä½ æä¾›çš„æ‰‹æœºå·ç æ‰¾åˆ°ä½ ã€‚";

	/// <summary>
	/// Key: "Label.Username"
	/// English String: "Username"
	/// </summary>
	public override string LabelUsername => "ç”¨æˆ·å";

	/// <summary>
	/// Key: "Label.WhoCanFindMeByPhone"
	/// English String: "Who can find me by my phone number?"
	/// </summary>
	public override string LabelWhoCanFindMeByPhone => "è°å¯ä»¥é€šè¿‡æˆ‘çš„æ‰‹æœºå·ç æ‰¾åˆ°æˆ‘ï¼Ÿ";

	/// <summary>
	/// Key: "Message.DefaultError"
	/// English String: "An error occurred, try again later."
	/// </summary>
	public override string MessageDefaultError => "å‘ç”Ÿé”™è¯¯ï¼Œè¯·ç¨åŽé‡è¯•ã€‚";

	/// <summary>
	/// Key: "Message.EmailForUsernameSuccessBody"
	/// success message
	/// English String: "An email with your username(s) has been sent to you if the email was previously saved on your account."
	/// </summary>
	public override string MessageEmailForUsernameSuccessBody => "å¦‚æžœä½ çš„å¸æˆ·å·²ä¿å­˜ç”µå­é‚®ä»¶åœ°å€ï¼Œé‚£æˆ‘ä»¬å·²å‘ä½ å‘é€äº†ä¸€å°åŒ…å«ä½ ç”¨æˆ·åçš„ç”µå­é‚®ä»¶ã€‚";

	/// <summary>
	/// Key: "Message.EmailSuccessBody"
	/// English String: "An email with instructions has been sent to you if the email was previously saved on your account."
	/// </summary>
	public override string MessageEmailSuccessBody => "å¦‚æžœä½ çš„å¸æˆ·å·²ä¿å­˜ç”µå­é‚®ä»¶åœ°å€ï¼Œé‚£æˆ‘ä»¬å·²å‘ä½ å‘é€äº†ä¸€å°é™„æœ‰è¯´æ˜Žçš„ç”µå­é‚®ä»¶ã€‚";

	/// <summary>
	/// Key: "Message.EmailSuccessTitle"
	/// English String: "Email Sent"
	/// </summary>
	public override string MessageEmailSuccessTitle => "ç”µå­é‚®ä»¶å·²å‘é€";

	/// <summary>
	/// Key: "Message.EnterCode"
	/// English String: "A code was sent to your phone if it was previously verified on your account. Please enter it below"
	/// </summary>
	public override string MessageEnterCode => "å¦‚æžœä½ çš„æ‰‹æœºå·ç å·²ç»è¿‡éªŒè¯ï¼Œä½ å°†æ”¶åˆ°æˆ‘ä»¬å‘é€è‡³ä½ æ‰‹æœºçš„ä»£ç ã€‚è¯·åœ¨ä¸‹æ–¹è¾“å…¥";

	/// <summary>
	/// Key: "Message.EnterCodeSentToEmail"
	/// Enter the code we just sent to your email.
	/// English String: "Enter the code we just sent to your email."
	/// </summary>
	public override string MessageEnterCodeSentToEmail => "è¯·è¾“å…¥æˆ‘ä»¬åˆšå‘é€è‡³ä½ ç”µå­é‚®ä»¶çš„ä»£ç ã€‚";

	/// <summary>
	/// Key: "Message.PhoneForUsernameSuccessBody"
	/// English String: "An SMS with your username(s) has been sent to you if the phone number was previously verified on your account."
	/// </summary>
	public override string MessagePhoneForUsernameSuccessBody => "å¦‚æžœä½ çš„å¸æˆ·å·²éªŒè¯è¿‡ç”µè¯å·ç ï¼Œé‚£ä¹ˆæˆ‘ä»¬å·²å‘ä½ å‘é€äº†ä¸€æ¡åŒ…å«ä½ ç”¨æˆ·åçš„ä¿¡æ¯ã€‚";

	/// <summary>
	/// Key: "Message.PhoneForUsernameSuccessTitle"
	/// English String: "SMS Sent"
	/// </summary>
	public override string MessagePhoneForUsernameSuccessTitle => "çŸ­ä¿¡å·²å‘é€";

	/// <summary>
	/// Key: "MessageAccountDoesNotHaveAnEmail"
	/// English String: "There is no email linked to this account"
	/// </summary>
	public override string MessageAccountDoesNotHaveAnEmail => "æ²¡æœ‰ä¸Žæ­¤å¸æˆ·ç›¸å…³è”çš„ç”µå­é‚®ä»¶";

	/// <summary>
	/// Key: "MessageAccountNotFoundByEmail"
	/// No account found. Please use a different email.
	/// English String: "No account found. Please use a different email."
	/// </summary>
	public override string MessageAccountNotFoundByEmail => "æœªæ‰¾åˆ°å¸æˆ·ã€‚è¯·ä½¿ç”¨å…¶ä»–ç”µå­é‚®ä»¶ã€‚";

	/// <summary>
	/// Key: "MessageAccountNotFoundByPhone"
	/// No account found. Please use a different phone number.
	/// English String: "No account found. Please use a different phone number."
	/// </summary>
	public override string MessageAccountNotFoundByPhone => "æœªæ‰¾åˆ°å¸æˆ·ã€‚è¯·ä½¿ç”¨å…¶ä»–æ‰‹æœºå·ç ã€‚";

	/// <summary>
	/// Key: "MessageAccountRecoveryUnknownError"
	/// English String: "System error. Account could not be restored to this state."
	/// </summary>
	public override string MessageAccountRecoveryUnknownError => "ç³»ç»Ÿé”™è¯¯ã€‚å¸æˆ·æ— æ³•æ¢å¤è‡³æ­¤çŠ¶æ€ã€‚";

	/// <summary>
	/// Key: "MessageCaptchaError"
	/// English String: "We need to make sure you're not a robot!"
	/// </summary>
	public override string MessageCaptchaError => "æˆ‘ä»¬éœ€è¦ç¡®å®šä½ ä¸æ˜¯æœºå™¨äºº :)";

	/// <summary>
	/// Key: "MessageCaptchaFailError"
	/// English String: "The words you typed didn't match the picture. Please try again."
	/// </summary>
	public override string MessageCaptchaFailError => "ä½ é”®å…¥çš„æ–‡å­—ä¸Žå›¾ç‰‡ä¸ç¬¦ã€‚è¯·é‡è¯•ã€‚";

	/// <summary>
	/// Key: "MessageCredentialsError"
	/// English String: "Your username or password is incorrect. Please check them and try again."
	/// </summary>
	public override string MessageCredentialsError => "ä½ çš„ç”¨æˆ·åæˆ–å¯†ç ä¸æ­£ç¡®ã€‚è¯·æ£€æŸ¥å¹¶é‡è¯•ã€‚";

	/// <summary>
	/// Key: "MessageFloodCheckedError"
	/// English String: "Too many attempts. Please try again later."
	/// </summary>
	public override string MessageFloodCheckedError => "å°è¯•æ¬¡æ•°è¿‡å¤šã€‚è¯·ç¨åŽé‡è¯•ã€‚";

	/// <summary>
	/// Key: "MessageForgotPasswordFeatureDisabled"
	/// English String: "Feature temporarily disabled. Please try again later."
	/// </summary>
	public override string MessageForgotPasswordFeatureDisabled => "åŠŸèƒ½æš‚æ—¶åœç”¨ã€‚è¯·ç¨åŽé‡è¯•ã€‚";

	/// <summary>
	/// Key: "MessageForgotPasswordSuccess"
	/// English String: "Check your email for login instructions"
	/// </summary>
	public override string MessageForgotPasswordSuccess => "è¯·æŸ¥çœ‹ä½ çš„é‚®ä»¶ä»¥èŽ·å–ç™»å½•è¯´æ˜Ž";

	/// <summary>
	/// Key: "MessageInvalidAccountStatus"
	/// English String: "Account status prevents resetting password"
	/// </summary>
	public override string MessageInvalidAccountStatus => "å¸æˆ·çŠ¶æ€å¯¼è‡´æ— æ³•é‡ç½®å¯†ç ";

	/// <summary>
	/// Key: "MessageInvalidPassword"
	/// English String: "Invalid password"
	/// </summary>
	public override string MessageInvalidPassword => "å¯†ç æ— æ•ˆ";

	/// <summary>
	/// Key: "MessageInvalidTicket"
	/// English String: "We couldn't load this security ticket."
	/// </summary>
	public override string MessageInvalidTicket => "æˆ‘ä»¬æ— æ³•åŠ è½½æ­¤å®‰å…¨ç¥¨å•ã€‚";

	/// <summary>
	/// Key: "MessageInvalidUserNameOrEmail"
	/// English String: "Invalid username, or no email exists"
	/// </summary>
	public override string MessageInvalidUserNameOrEmail => "ç”¨æˆ·åæ— æ•ˆï¼Œæˆ–ç”µå­é‚®ä»¶ä¸å­˜åœ¨";

	/// <summary>
	/// Key: "MessageMobileResetPasswordSuccess"
	/// English String: "MobileResetPasswordSuccess"
	/// </summary>
	public override string MessageMobileResetPasswordSuccess => "MobileResetPasswordSuccess";

	/// <summary>
	/// Key: "MessageNoAccountsLinkedToEmail"
	/// English String: "There are no accounts linked to this email address"
	/// </summary>
	public override string MessageNoAccountsLinkedToEmail => "æ²¡æœ‰ä¸Žæ­¤ç”µå­é‚®ä»¶åœ°å€ç›¸å…³è”çš„å¸æˆ·";

	/// <summary>
	/// Key: "MessageOldUsernameError"
	/// English String: "It looks like you are trying to log in with a username that has changed. Please log in with your new username."
	/// </summary>
	public override string MessageOldUsernameError => "ä½ ä¼¼ä¹Žåœ¨å°è¯•ä½¿ç”¨å·²æ›´æ”¹çš„ç”¨æˆ·åè¿›è¡Œç™»å½•ã€‚è¯·ä½¿ç”¨ä½ çš„æ–°ç”¨æˆ·åç™»å½•ã€‚";

	/// <summary>
	/// Key: "MessagePasswordCannotBeUsed"
	/// English String: "Sorry, that password cannot be used."
	/// </summary>
	public override string MessagePasswordCannotBeUsed => "æŠ±æ­‰ï¼Œæ— æ³•ä½¿ç”¨è¯¥å¯†ç ã€‚";

	/// <summary>
	/// Key: "MessagePasswordsDoNotMatch"
	/// English String: "Passwords do not match"
	/// </summary>
	public override string MessagePasswordsDoNotMatch => "å¯†ç ä¸åŒ¹é…";

	/// <summary>
	/// Key: "MessageSamlUnauthenticated"
	/// English String: "You must log in to Roblox to finish authenticating."
	/// </summary>
	public override string MessageSamlUnauthenticated => "ä½ å¿…é¡»ç™»å½• Roblox ä»¥å®Œæˆèº«ä»½éªŒè¯ã€‚";

	/// <summary>
	/// Key: "MessageUnknownError"
	/// English String: "Unknown Error"
	/// </summary>
	public override string MessageUnknownError => "æœªçŸ¥é”™è¯¯";

	/// <summary>
	/// Key: "MessageUnknownSystemError"
	/// English String: "System error. Please return to login screen."
	/// </summary>
	public override string MessageUnknownSystemError => "ç³»ç»Ÿé”™è¯¯ã€‚è¯·è¿”å›žç™»å½•å±å¹•ã€‚";

	/// <summary>
	/// Key: "Placeholder.Email"
	/// English String: "Email"
	/// </summary>
	public override string PlaceholderEmail => "ç”µå­é‚®ä»¶";

	/// <summary>
	/// Key: "Placeholder.PhoneNumber"
	/// English String: "Phone Number"
	/// </summary>
	public override string PlaceholderPhoneNumber => "æ‰‹æœºå·ç ";

	/// <summary>
	/// Key: "Response.PasswordResetSuccess"
	/// Password reset success! Please login again.
	/// English String: "Password reset success! Please login again."
	/// </summary>
	public override string ResponsePasswordResetSuccess => "å¯†ç é‡ç½®æˆåŠŸï¼è¯·å†æ¬¡ç™»å½•ã€‚";

	/// <summary>
	/// Key: "Response.Success"
	/// English String: "Success"
	/// </summary>
	public override string ResponseSuccess => "æˆåŠŸ";

	/// <summary>
	/// Key: "Response.UpdatePasswordFlooded"
	/// English String: "Too many attempts. Please try again later."
	/// </summary>
	public override string ResponseUpdatePasswordFlooded => "å°è¯•æ¬¡æ•°è¿‡å¤šã€‚è¯·ç¨åŽé‡è¯•ã€‚";

	/// <summary>
	/// Key: "Response.UpdatePasswordIncorrect"
	/// English String: "Your current password is incorrect, the password was not changed."
	/// </summary>
	public override string ResponseUpdatePasswordIncorrect => "ä½ å½“å‰çš„å¯†ç ä¸æ­£ç¡®ï¼Œå¯†ç æœªæ›´æ”¹ã€‚";

	/// <summary>
	/// Key: "Response.UpdatePasswordInputMissing"
	/// English String: "Must include new password and confirm password"
	/// </summary>
	public override string ResponseUpdatePasswordInputMissing => "å¿…é¡»åŒ…å«æ–°å¯†ç å¹¶ç¡®è®¤å¯†ç ";

	/// <summary>
	/// Key: "Response.UpdatePasswordMismatch"
	/// English String: "Your new password and confirm password must match"
	/// </summary>
	public override string ResponseUpdatePasswordMismatch => "ä½ çš„æ–°å¯†ç é¡»ä¸Žç¡®è®¤å¯†ç ç›¸ç¬¦";

	public ResetPasswordResources_zh_cn(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "å–æ¶ˆ";
	}

	protected override string _GetTemplateForActionEmailToResetPassword()
	{
		return "ä½¿ç”¨ç”µå­é‚®ä»¶ä»¥é‡ç½®å¯†ç ";
	}

	protected override string _GetTemplateForActionEmailToRetriveUsername()
	{
		return "ä½¿ç”¨ç”µå­é‚®ä»¶ä»¥å–å›žç”¨æˆ·å";
	}

	protected override string _GetTemplateForActionOk()
	{
		return "å¥½";
	}

	protected override string _GetTemplateForActionPhoneToResetPassword()
	{
		return "ä½¿ç”¨æ‰‹æœºå·ç ä»¥é‡ç½®å¯†ç ";
	}

	protected override string _GetTemplateForActionPhoneToRetriveUsername()
	{
		return "ä½¿ç”¨æ‰‹æœºå·ç ä»¥å–å›žç”¨æˆ·å";
	}

	protected override string _GetTemplateForActionVerify()
	{
		return "éªŒè¯";
	}

	/// <summary>
	/// Key: "Description.ChangePasswordEmail.HtmlBody1"
	/// email body for change password email
	/// English String: "We noticed that the password changed for your Roblox account: {userName}. If you didn't intend to change it, or you think someone else changed it by mistake, please click this link to undo the action:{lineBreak} {actionLink} {lineBreak}{lineBreak}If you are happy with your new Roblox password, you don't have to do anything! It's already set up. Please do not reply to this message. If you have any questions, please see the Roblox help page (https://www.roblox.com/help)."
	/// </summary>
	public override string DescriptionChangePasswordEmailHtmlBody1(string userName, string lineBreak, string actionLink)
	{
		return $"æˆ‘ä»¬æ³¨æ„åˆ°ä½  Roblox å¸æˆ·çš„å¯†ç å·²æ›´æ”¹ï¼š{userName} ã€‚å¦‚æžœä½ ä¸æƒ³çœŸçš„æ›´æ”¹ï¼Œæˆ–è€…ä½ è®¤ä¸ºåˆ«äººå¯èƒ½ä¸å°å¿ƒä½œå‡ºäº†æ­¤æ›´æ”¹ï¼Œé‚£ä¹ˆè¯·ç‚¹æŒ‰æ­¤é“¾æŽ¥ä»¥æ’¤é”€ï¼š{lineBreak}{actionLink}{lineBreak}{lineBreak}å¦‚æžœä½ æ›´å€¾å‘äºŽä½¿ç”¨æ–°çš„ Roblox å¯†ç ï¼Œæ— éœ€ä»»ä½•æ­¥éª¤ï¼Œå¸æˆ·å·²è®¾ç½®å¥½ã€‚è¯·ä¸è¦å›žå¤æ­¤æ¶ˆæ¯ã€‚å¦‚æžœä½ æœ‰ä»»ä½•é—®é¢˜ï¼Œè¯·æŸ¥çœ‹ Roblox å¸®åŠ©é¡µé¢ï¼ˆhttps://www.roblox.com/helpï¼‰ã€‚";
	}

	protected override string _GetTemplateForDescriptionChangePasswordEmailHtmlBody1()
	{
		return "æˆ‘ä»¬æ³¨æ„åˆ°ä½  Roblox å¸æˆ·çš„å¯†ç å·²æ›´æ”¹ï¼š{userName} ã€‚å¦‚æžœä½ ä¸æƒ³çœŸçš„æ›´æ”¹ï¼Œæˆ–è€…ä½ è®¤ä¸ºåˆ«äººå¯èƒ½ä¸å°å¿ƒä½œå‡ºäº†æ­¤æ›´æ”¹ï¼Œé‚£ä¹ˆè¯·ç‚¹æŒ‰æ­¤é“¾æŽ¥ä»¥æ’¤é”€ï¼š{lineBreak}{actionLink}{lineBreak}{lineBreak}å¦‚æžœä½ æ›´å€¾å‘äºŽä½¿ç”¨æ–°çš„ Roblox å¯†ç ï¼Œæ— éœ€ä»»ä½•æ­¥éª¤ï¼Œå¸æˆ·å·²è®¾ç½®å¥½ã€‚è¯·ä¸è¦å›žå¤æ­¤æ¶ˆæ¯ã€‚å¦‚æžœä½ æœ‰ä»»ä½•é—®é¢˜ï¼Œè¯·æŸ¥çœ‹ Roblox å¸®åŠ©é¡µé¢ï¼ˆhttps://www.roblox.com/helpï¼‰ã€‚";
	}

	protected override string _GetTemplateForDescriptionEmailToResetPassword()
	{
		return "è¾“å…¥ä½ çš„ç”µå­é‚®ä»¶ä»¥é‡ç½®ä½ çš„å¯†ç ã€‚";
	}

	protected override string _GetTemplateForDescriptionEmailToRetriveUsername()
	{
		return "è¾“å…¥ä½ çš„ç”µå­é‚®ä»¶ä»¥å–å›žä½ çš„ç”¨æˆ·åã€‚";
	}

	/// <summary>
	/// Key: "Description.PasswordChangeEmail.BodyPlainText"
	/// password reset plaintext email message
	/// English String: "We noticed that the password changed for your Roblox account: {userName}. If you didn't intend to change it, or you think someone else changed it by mistake, please click this link to undo the action:\n{urlWithTicket}\n\nIf you are happy with your new Roblox password, you don't have to do anything! It's already set up. Please do not reply to this message. If you have any questions, please see the Roblox help page (https://www.roblox.com/help)."
	/// </summary>
	public override string DescriptionPasswordChangeEmailBodyPlainText(string userName, string urlWithTicket)
	{
		return $"æˆ‘ä»¬æ³¨æ„åˆ°ä½  Roblox å¸æˆ·çš„å¯†ç å·²æ›´æ”¹ï¼š{userName} ã€‚å¦‚æžœä½ ä¸æƒ³çœŸçš„æ›´æ”¹ï¼Œæˆ–è€…ä½ è®¤ä¸ºåˆ«äººå¯èƒ½ä¸å°å¿ƒä½œå‡ºäº†æ­¤æ›´æ”¹ï¼Œé‚£ä¹ˆè¯·ç‚¹æŒ‰æ­¤é“¾æŽ¥ä»¥æ’¤é”€ï¼š\n{urlWithTicket}\n\nå¦‚æžœä½ æ›´å€¾å‘äºŽä½¿ç”¨æ–°çš„ Roblox å¯†ç ï¼Œæ— éœ€ä»»ä½•æ­¥éª¤ï¼Œå¸æˆ·å·²è®¾ç½®å¥½ã€‚è¯·ä¸è¦å›žå¤æ­¤æ¶ˆæ¯ã€‚å¦‚æžœä½ æœ‰ä»»ä½•é—®é¢˜ï¼Œè¯·æŸ¥çœ‹ Roblox å¸®åŠ©é¡µé¢ï¼ˆhttps://www.roblox.com/helpï¼‰ã€‚";
	}

	protected override string _GetTemplateForDescriptionPasswordChangeEmailBodyPlainText()
	{
		return "æˆ‘ä»¬æ³¨æ„åˆ°ä½  Roblox å¸æˆ·çš„å¯†ç å·²æ›´æ”¹ï¼š{userName} ã€‚å¦‚æžœä½ ä¸æƒ³çœŸçš„æ›´æ”¹ï¼Œæˆ–è€…ä½ è®¤ä¸ºåˆ«äººå¯èƒ½ä¸å°å¿ƒä½œå‡ºäº†æ­¤æ›´æ”¹ï¼Œé‚£ä¹ˆè¯·ç‚¹æŒ‰æ­¤é“¾æŽ¥ä»¥æ’¤é”€ï¼š\n{urlWithTicket}\n\nå¦‚æžœä½ æ›´å€¾å‘äºŽä½¿ç”¨æ–°çš„ Roblox å¯†ç ï¼Œæ— éœ€ä»»ä½•æ­¥éª¤ï¼Œå¸æˆ·å·²è®¾ç½®å¥½ã€‚è¯·ä¸è¦å›žå¤æ­¤æ¶ˆæ¯ã€‚å¦‚æžœä½ æœ‰ä»»ä½•é—®é¢˜ï¼Œè¯·æŸ¥çœ‹ Roblox å¸®åŠ©é¡µé¢ï¼ˆhttps://www.roblox.com/helpï¼‰ã€‚";
	}

	/// <summary>
	/// Key: "Description.PasswordChangeEmail.From"
	/// name of the sender as shown in from field of the email
	/// English String: "\"Roblox Password Reset\" {fromEmailAddress}"
	/// </summary>
	public override string DescriptionPasswordChangeEmailFrom(string fromEmailAddress)
	{
		return $"â€œRoblox å¸æˆ·å¯†ç é‡ç½®â€{fromEmailAddress}";
	}

	protected override string _GetTemplateForDescriptionPasswordChangeEmailFrom()
	{
		return "â€œRoblox å¸æˆ·å¯†ç é‡ç½®â€{fromEmailAddress}";
	}

	protected override string _GetTemplateForDescriptionPasswordChangeEmailSubject()
	{
		return "Roblox å¯†ç é‡ç½®";
	}

	/// <summary>
	/// Key: "Description.PasswordResetEmail.From"
	/// The "From" field for the password reset email
	/// English String: "{escapeLiteralStart}Roblox Password Reset{escapeLiteralEnd} {fromEmailAddress}"
	/// </summary>
	public override string DescriptionPasswordResetEmailFrom(string escapeLiteralStart, string escapeLiteralEnd, string fromEmailAddress)
	{
		return $"{escapeLiteralStart}Roblox å¯†ç é‡ç½®{escapeLiteralEnd}{fromEmailAddress}";
	}

	protected override string _GetTemplateForDescriptionPasswordResetEmailFrom()
	{
		return "{escapeLiteralStart}Roblox å¯†ç é‡ç½®{escapeLiteralEnd}{fromEmailAddress}";
	}

	/// <summary>
	/// Key: "Description.PasswordResetEmail.HtmlBody"
	/// This email is sent when a user requests a password reset.
	/// English String: "We have received a request to reset the password for your Roblox account: {emailOrUsername}{lineBreak}{lineBreak}If you submitted this request, please click the button below to proceed.{lineBreak}This button will be active for {passwordResetTicketHours} hours, {passwordResetTicketMinutes} minutes. If you do not wish to reset your password, please disregard this notice.{lineBreak}{lineBreak}{aTagWithStartHref}{resetPasswordUrl}{hrefEnd}{buttonStart}Reset Password{buttonEnd}{aTagEnd}"
	/// </summary>
	public override string DescriptionPasswordResetEmailHtmlBody(string emailOrUsername, string lineBreak, string passwordResetTicketHours, string passwordResetTicketMinutes, string aTagWithStartHref, string resetPasswordUrl, string hrefEnd, string buttonStart, string buttonEnd, string aTagEnd)
	{
		return $"æˆ‘ä»¬å·²æ”¶åˆ°é‡ç½®ä½ çš„ Roblox å¸æˆ·å¯†ç çš„è¯·æ±‚ï¼š{emailOrUsername}{lineBreak}{lineBreak}å¦‚æžœä½ æäº¤äº†è¯¥è¯·æ±‚ï¼Œè¯·ç‚¹æŒ‰ä¸‹æ–¹æŒ‰é’®ä»¥ç»§ç»­ã€‚{lineBreak}æŒ‰é’®é“¾æŽ¥å°†ä¼šåœ¨{passwordResetTicketHours} å°æ—¶ {passwordResetTicketMinutes} å†…æœ‰æ•ˆã€‚å¦‚æžœä½ ä¸æƒ³é‡ç½®å¯†ç ï¼Œè¯·å¿½ç•¥æ­¤é€šçŸ¥ã€‚{lineBreak}{lineBreak}{aTagWithStartHref}{resetPasswordUrl}{hrefEnd}{buttonStart}é‡ç½®å¯†ç {buttonEnd}{aTagEnd}";
	}

	protected override string _GetTemplateForDescriptionPasswordResetEmailHtmlBody()
	{
		return "æˆ‘ä»¬å·²æ”¶åˆ°é‡ç½®ä½ çš„ Roblox å¸æˆ·å¯†ç çš„è¯·æ±‚ï¼š{emailOrUsername}{lineBreak}{lineBreak}å¦‚æžœä½ æäº¤äº†è¯¥è¯·æ±‚ï¼Œè¯·ç‚¹æŒ‰ä¸‹æ–¹æŒ‰é’®ä»¥ç»§ç»­ã€‚{lineBreak}æŒ‰é’®é“¾æŽ¥å°†ä¼šåœ¨{passwordResetTicketHours} å°æ—¶ {passwordResetTicketMinutes} å†…æœ‰æ•ˆã€‚å¦‚æžœä½ ä¸æƒ³é‡ç½®å¯†ç ï¼Œè¯·å¿½ç•¥æ­¤é€šçŸ¥ã€‚{lineBreak}{lineBreak}{aTagWithStartHref}{resetPasswordUrl}{hrefEnd}{buttonStart}é‡ç½®å¯†ç {buttonEnd}{aTagEnd}";
	}

	/// <summary>
	/// Key: "Description.PasswordResetEmail.PlainBody"
	/// This email is sent when a user requests a password reset.
	/// English String: "We have received a request to reset the password for your Roblox account: {emailOrUsername}{lineBreak}{lineBreak}If you submitted this request, please click the link below or paste it into a web browser to proceed.{lineBreak}This link will be active for {passwordResetTicketHours} hours, {passwordResetTicketMinutes} minutes. If you do not wish to reset your password, please disregard this notice.{lineBreak}{lineBreak}{resetPasswordUrl}"
	/// </summary>
	public override string DescriptionPasswordResetEmailPlainBody(string emailOrUsername, string lineBreak, string passwordResetTicketHours, string passwordResetTicketMinutes, string resetPasswordUrl)
	{
		return $"æˆ‘ä»¬å·²æ”¶åˆ°é‡ç½®ä½ çš„ Roblox å¸æˆ·å¯†ç çš„è¯·æ±‚ï¼š{emailOrUsername}{lineBreak}{lineBreak}å¦‚æžœä½ æäº¤äº†è¯¥è¯·æ±‚ï¼Œè¯·ç‚¹æŒ‰ä¸‹æ–¹é“¾æŽ¥ï¼Œæˆ–å°†å…¶ç²˜è´´è‡³ç½‘é¡µæµè§ˆå™¨ä»¥ç»§ç»­ã€‚{lineBreak}æ­¤é“¾æŽ¥å°†ä¼šåœ¨{passwordResetTicketHours} å°æ—¶ {passwordResetTicketMinutes} å†…æœ‰æ•ˆã€‚å¦‚æžœä½ ä¸æƒ³é‡ç½®å¯†ç ï¼Œè¯·å¿½ç•¥æ­¤é€šçŸ¥ã€‚{lineBreak}{lineBreak}{resetPasswordUrl}";
	}

	protected override string _GetTemplateForDescriptionPasswordResetEmailPlainBody()
	{
		return "æˆ‘ä»¬å·²æ”¶åˆ°é‡ç½®ä½ çš„ Roblox å¸æˆ·å¯†ç çš„è¯·æ±‚ï¼š{emailOrUsername}{lineBreak}{lineBreak}å¦‚æžœä½ æäº¤äº†è¯¥è¯·æ±‚ï¼Œè¯·ç‚¹æŒ‰ä¸‹æ–¹é“¾æŽ¥ï¼Œæˆ–å°†å…¶ç²˜è´´è‡³ç½‘é¡µæµè§ˆå™¨ä»¥ç»§ç»­ã€‚{lineBreak}æ­¤é“¾æŽ¥å°†ä¼šåœ¨{passwordResetTicketHours} å°æ—¶ {passwordResetTicketMinutes} å†…æœ‰æ•ˆã€‚å¦‚æžœä½ ä¸æƒ³é‡ç½®å¯†ç ï¼Œè¯·å¿½ç•¥æ­¤é€šçŸ¥ã€‚{lineBreak}{lineBreak}{resetPasswordUrl}";
	}

	protected override string _GetTemplateForDescriptionPasswordResetEmailSubject()
	{
		return "Roblox å¸æˆ·å¯†ç é‡ç½®";
	}

	protected override string _GetTemplateForDescriptionPhoneToResetPassword()
	{
		return "è¾“å…¥ä½ çš„æ‰‹æœºå·ç ä»¥é‡ç½®ä½ çš„å¯†ç ã€‚";
	}

	protected override string _GetTemplateForDescriptionPhoneToRetriveUsername()
	{
		return "è¾“å…¥ä½ çš„æ‰‹æœºå·ç ä»¥å–å›žä½ çš„ç”¨æˆ·åã€‚";
	}

	protected override string _GetTemplateForHeadingVerifyCode()
	{
		return "éªŒè¯ç ";
	}

	protected override string _GetTemplateForHeadingVerifyPhone()
	{
		return "éªŒè¯æ‰‹æœº";
	}

	protected override string _GetTemplateForHeadingForgetPasswordOrUsername()
	{
		return "å¿˜è®°å¯†ç æˆ–ç”¨æˆ·å";
	}

	protected override string _GetTemplateForLabelActionButtonYes()
	{
		return "æ˜¯";
	}

	protected override string _GetTemplateForLabelForgetMyPassword()
	{
		return "å¿˜è®°æˆ‘çš„å¯†ç ";
	}

	protected override string _GetTemplateForLabelForgetMyUsername()
	{
		return "å¿˜è®°æˆ‘çš„ç”¨æˆ·å";
	}

	protected override string _GetTemplateForLabelInvalidEmail()
	{
		return "ç”µå­é‚®ä»¶æ— æ•ˆ";
	}

	protected override string _GetTemplateForLabelInvalidPhoneNumber()
	{
		return "æ‰‹æœºå·ç æ— æ•ˆ";
	}

	protected override string _GetTemplateForLabelNeutralButtonOk()
	{
		return "å¥½";
	}

	protected override string _GetTemplateForLabelPassword()
	{
		return "å¯†ç ";
	}

	protected override string _GetTemplateForLabelResendCode()
	{
		return "é‡æ–°å‘é€éªŒè¯ç ";
	}

	protected override string _GetTemplateForLabelSubmit()
	{
		return "æäº¤";
	}

	protected override string _GetTemplateForLabelToolTipWhoCanFindMeByPhone()
	{
		return "æ­¤è®¾ç½®å¯æŽ§åˆ¶è°å¯ä»¥é€šè¿‡ä½ æä¾›çš„æ‰‹æœºå·ç æ‰¾åˆ°ä½ ã€‚";
	}

	protected override string _GetTemplateForLabelUsername()
	{
		return "ç”¨æˆ·å";
	}

	protected override string _GetTemplateForLabelWhoCanFindMeByPhone()
	{
		return "è°å¯ä»¥é€šè¿‡æˆ‘çš„æ‰‹æœºå·ç æ‰¾åˆ°æˆ‘ï¼Ÿ";
	}

	/// <summary>
	/// Key: "Message.CantSendEmailWarning"
	/// English String: "If you did not give us a {styleStart}real email address{styleEnd} when you created your account, we cannot send you an email."
	/// </summary>
	public override string MessageCantSendEmailWarning(string styleStart, string styleEnd)
	{
		return $"å¦‚æžœä½ åœ¨åˆ›å»ºå¸æˆ·æ—¶æœªæä¾›{styleStart}çœŸå®žçš„ç”µå­é‚®ä»¶åœ°å€{styleEnd}ï¼Œæˆ‘ä»¬åˆ™æ— æ³•å‘ä½ å‘é€ç”µå­é‚®ä»¶ã€‚";
	}

	protected override string _GetTemplateForMessageCantSendEmailWarning()
	{
		return "å¦‚æžœä½ åœ¨åˆ›å»ºå¸æˆ·æ—¶æœªæä¾›{styleStart}çœŸå®žçš„ç”µå­é‚®ä»¶åœ°å€{styleEnd}ï¼Œæˆ‘ä»¬åˆ™æ— æ³•å‘ä½ å‘é€ç”µå­é‚®ä»¶ã€‚";
	}

	protected override string _GetTemplateForMessageDefaultError()
	{
		return "å‘ç”Ÿé”™è¯¯ï¼Œè¯·ç¨åŽé‡è¯•ã€‚";
	}

	protected override string _GetTemplateForMessageEmailForUsernameSuccessBody()
	{
		return "å¦‚æžœä½ çš„å¸æˆ·å·²ä¿å­˜ç”µå­é‚®ä»¶åœ°å€ï¼Œé‚£æˆ‘ä»¬å·²å‘ä½ å‘é€äº†ä¸€å°åŒ…å«ä½ ç”¨æˆ·åçš„ç”µå­é‚®ä»¶ã€‚";
	}

	protected override string _GetTemplateForMessageEmailSuccessBody()
	{
		return "å¦‚æžœä½ çš„å¸æˆ·å·²ä¿å­˜ç”µå­é‚®ä»¶åœ°å€ï¼Œé‚£æˆ‘ä»¬å·²å‘ä½ å‘é€äº†ä¸€å°é™„æœ‰è¯´æ˜Žçš„ç”µå­é‚®ä»¶ã€‚";
	}

	protected override string _GetTemplateForMessageEmailSuccessTitle()
	{
		return "ç”µå­é‚®ä»¶å·²å‘é€";
	}

	protected override string _GetTemplateForMessageEnterCode()
	{
		return "å¦‚æžœä½ çš„æ‰‹æœºå·ç å·²ç»è¿‡éªŒè¯ï¼Œä½ å°†æ”¶åˆ°æˆ‘ä»¬å‘é€è‡³ä½ æ‰‹æœºçš„ä»£ç ã€‚è¯·åœ¨ä¸‹æ–¹è¾“å…¥";
	}

	protected override string _GetTemplateForMessageEnterCodeSentToEmail()
	{
		return "è¯·è¾“å…¥æˆ‘ä»¬åˆšå‘é€è‡³ä½ ç”µå­é‚®ä»¶çš„ä»£ç ã€‚";
	}

	protected override string _GetTemplateForMessagePhoneForUsernameSuccessBody()
	{
		return "å¦‚æžœä½ çš„å¸æˆ·å·²éªŒè¯è¿‡ç”µè¯å·ç ï¼Œé‚£ä¹ˆæˆ‘ä»¬å·²å‘ä½ å‘é€äº†ä¸€æ¡åŒ…å«ä½ ç”¨æˆ·åçš„ä¿¡æ¯ã€‚";
	}

	protected override string _GetTemplateForMessagePhoneForUsernameSuccessTitle()
	{
		return "çŸ­ä¿¡å·²å‘é€";
	}

	protected override string _GetTemplateForMessageAccountDoesNotHaveAnEmail()
	{
		return "æ²¡æœ‰ä¸Žæ­¤å¸æˆ·ç›¸å…³è”çš„ç”µå­é‚®ä»¶";
	}

	protected override string _GetTemplateForMessageAccountNotFoundByEmail()
	{
		return "æœªæ‰¾åˆ°å¸æˆ·ã€‚è¯·ä½¿ç”¨å…¶ä»–ç”µå­é‚®ä»¶ã€‚";
	}

	protected override string _GetTemplateForMessageAccountNotFoundByPhone()
	{
		return "æœªæ‰¾åˆ°å¸æˆ·ã€‚è¯·ä½¿ç”¨å…¶ä»–æ‰‹æœºå·ç ã€‚";
	}

	protected override string _GetTemplateForMessageAccountRecoveryUnknownError()
	{
		return "ç³»ç»Ÿé”™è¯¯ã€‚å¸æˆ·æ— æ³•æ¢å¤è‡³æ­¤çŠ¶æ€ã€‚";
	}

	protected override string _GetTemplateForMessageCaptchaError()
	{
		return "æˆ‘ä»¬éœ€è¦ç¡®å®šä½ ä¸æ˜¯æœºå™¨äºº :)";
	}

	protected override string _GetTemplateForMessageCaptchaFailError()
	{
		return "ä½ é”®å…¥çš„æ–‡å­—ä¸Žå›¾ç‰‡ä¸ç¬¦ã€‚è¯·é‡è¯•ã€‚";
	}

	protected override string _GetTemplateForMessageCredentialsError()
	{
		return "ä½ çš„ç”¨æˆ·åæˆ–å¯†ç ä¸æ­£ç¡®ã€‚è¯·æ£€æŸ¥å¹¶é‡è¯•ã€‚";
	}

	protected override string _GetTemplateForMessageFloodCheckedError()
	{
		return "å°è¯•æ¬¡æ•°è¿‡å¤šã€‚è¯·ç¨åŽé‡è¯•ã€‚";
	}

	protected override string _GetTemplateForMessageForgotPasswordFeatureDisabled()
	{
		return "åŠŸèƒ½æš‚æ—¶åœç”¨ã€‚è¯·ç¨åŽé‡è¯•ã€‚";
	}

	protected override string _GetTemplateForMessageForgotPasswordSuccess()
	{
		return "è¯·æŸ¥çœ‹ä½ çš„é‚®ä»¶ä»¥èŽ·å–ç™»å½•è¯´æ˜Ž";
	}

	protected override string _GetTemplateForMessageInvalidAccountStatus()
	{
		return "å¸æˆ·çŠ¶æ€å¯¼è‡´æ— æ³•é‡ç½®å¯†ç ";
	}

	protected override string _GetTemplateForMessageInvalidPassword()
	{
		return "å¯†ç æ— æ•ˆ";
	}

	protected override string _GetTemplateForMessageInvalidTicket()
	{
		return "æˆ‘ä»¬æ— æ³•åŠ è½½æ­¤å®‰å…¨ç¥¨å•ã€‚";
	}

	protected override string _GetTemplateForMessageInvalidUserNameOrEmail()
	{
		return "ç”¨æˆ·åæ— æ•ˆï¼Œæˆ–ç”µå­é‚®ä»¶ä¸å­˜åœ¨";
	}

	protected override string _GetTemplateForMessageMobileResetPasswordSuccess()
	{
		return "MobileResetPasswordSuccess";
	}

	protected override string _GetTemplateForMessageNoAccountsLinkedToEmail()
	{
		return "æ²¡æœ‰ä¸Žæ­¤ç”µå­é‚®ä»¶åœ°å€ç›¸å…³è”çš„å¸æˆ·";
	}

	protected override string _GetTemplateForMessageOldUsernameError()
	{
		return "ä½ ä¼¼ä¹Žåœ¨å°è¯•ä½¿ç”¨å·²æ›´æ”¹çš„ç”¨æˆ·åè¿›è¡Œç™»å½•ã€‚è¯·ä½¿ç”¨ä½ çš„æ–°ç”¨æˆ·åç™»å½•ã€‚";
	}

	protected override string _GetTemplateForMessagePasswordCannotBeUsed()
	{
		return "æŠ±æ­‰ï¼Œæ— æ³•ä½¿ç”¨è¯¥å¯†ç ã€‚";
	}

	/// <summary>
	/// Key: "MessagePasswordResetTicketExpired"
	/// English String: "Sorry, password reset requests expire {expirationHour} hours, {expirationMinute} minutes after issuance. Try requesting another password reset ticket again."
	/// </summary>
	public override string MessagePasswordResetTicketExpired(string expirationHour, string expirationMinute)
	{
		return $"æŠ±æ­‰ï¼Œå¯†ç é‡ç½®è¯·æ±‚ä¼šåœ¨å‘é€åŽçš„ {expirationHour} å°æ—¶ {expirationMinute} åˆ†åŽè¿‡æœŸã€‚è¯·é‡æ–°æäº¤ä¸€å¼ å¯†ç é‡ç½®ç¥¨å•ã€‚";
	}

	protected override string _GetTemplateForMessagePasswordResetTicketExpired()
	{
		return "æŠ±æ­‰ï¼Œå¯†ç é‡ç½®è¯·æ±‚ä¼šåœ¨å‘é€åŽçš„ {expirationHour} å°æ—¶ {expirationMinute} åˆ†åŽè¿‡æœŸã€‚è¯·é‡æ–°æäº¤ä¸€å¼ å¯†ç é‡ç½®ç¥¨å•ã€‚";
	}

	protected override string _GetTemplateForMessagePasswordsDoNotMatch()
	{
		return "å¯†ç ä¸åŒ¹é…";
	}

	protected override string _GetTemplateForMessageSamlUnauthenticated()
	{
		return "ä½ å¿…é¡»ç™»å½• Roblox ä»¥å®Œæˆèº«ä»½éªŒè¯ã€‚";
	}

	protected override string _GetTemplateForMessageUnknownError()
	{
		return "æœªçŸ¥é”™è¯¯";
	}

	protected override string _GetTemplateForMessageUnknownSystemError()
	{
		return "ç³»ç»Ÿé”™è¯¯ã€‚è¯·è¿”å›žç™»å½•å±å¹•ã€‚";
	}

	protected override string _GetTemplateForPlaceholderEmail()
	{
		return "ç”µå­é‚®ä»¶";
	}

	/// <summary>
	/// Key: "Placeholder.EnterCode"
	/// English String: "Enter Code ({codeLength}-digit)"
	/// </summary>
	public override string PlaceholderEnterCode(string codeLength)
	{
		return $"è¾“å…¥éªŒè¯ç ï¼ˆ{codeLength} ä½ï¼‰";
	}

	protected override string _GetTemplateForPlaceholderEnterCode()
	{
		return "è¾“å…¥éªŒè¯ç ï¼ˆ{codeLength} ä½ï¼‰";
	}

	protected override string _GetTemplateForPlaceholderPhoneNumber()
	{
		return "æ‰‹æœºå·ç ";
	}

	protected override string _GetTemplateForResponsePasswordResetSuccess()
	{
		return "å¯†ç é‡ç½®æˆåŠŸï¼è¯·å†æ¬¡ç™»å½•ã€‚";
	}

	protected override string _GetTemplateForResponseSuccess()
	{
		return "æˆåŠŸ";
	}

	protected override string _GetTemplateForResponseUpdatePasswordFlooded()
	{
		return "å°è¯•æ¬¡æ•°è¿‡å¤šã€‚è¯·ç¨åŽé‡è¯•ã€‚";
	}

	protected override string _GetTemplateForResponseUpdatePasswordIncorrect()
	{
		return "ä½ å½“å‰çš„å¯†ç ä¸æ­£ç¡®ï¼Œå¯†ç æœªæ›´æ”¹ã€‚";
	}

	protected override string _GetTemplateForResponseUpdatePasswordInputMissing()
	{
		return "å¿…é¡»åŒ…å«æ–°å¯†ç å¹¶ç¡®è®¤å¯†ç ";
	}

	protected override string _GetTemplateForResponseUpdatePasswordMismatch()
	{
		return "ä½ çš„æ–°å¯†ç é¡»ä¸Žç¡®è®¤å¯†ç ç›¸ç¬¦";
	}
}


}
