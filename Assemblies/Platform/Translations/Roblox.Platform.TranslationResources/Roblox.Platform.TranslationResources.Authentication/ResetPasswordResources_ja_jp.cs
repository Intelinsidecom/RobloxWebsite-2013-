namespace Roblox.Platform.TranslationResources.Authentication {
    /// <summary>

/// This class overrides ResetPasswordResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ResetPasswordResources_ja_jp : ResetPasswordResources_en_us, IResetPasswordResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "ã‚­ãƒ£ãƒ³ã‚»ãƒ«";

	/// <summary>
	/// Key: "Action.EmailToResetPassword"
	/// English String: "Use email to reset password"
	/// </summary>
	public override string ActionEmailToResetPassword => "ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã‚’ä½¿ç”¨ã—ã¦ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ã‚’ãƒªã‚»ãƒƒãƒˆã™ã‚‹";

	/// <summary>
	/// Key: "Action.EmailToRetriveUsername"
	/// English String: "Use email to retrieve username"
	/// </summary>
	public override string ActionEmailToRetriveUsername => "ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã‚’ä½¿ç”¨ã—ã¦ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ ã‚’å†ç¢ºèªã™ã‚‹";

	/// <summary>
	/// Key: "Action.Ok"
	/// OK
	/// English String: "OK"
	/// </summary>
	public override string ActionOk => "OK";

	/// <summary>
	/// Key: "Action.PhoneToResetPassword"
	/// English String: "Use phone number to reset password"
	/// </summary>
	public override string ActionPhoneToResetPassword => "é›»è©±ç•ªå·ã‚’ä½¿ç”¨ã—ã¦ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ã‚’ãƒªã‚»ãƒƒãƒˆã™ã‚‹";

	/// <summary>
	/// Key: "Action.PhoneToRetriveUsername"
	/// English String: "Use phone number to retrieve username"
	/// </summary>
	public override string ActionPhoneToRetriveUsername => "é›»è©±ç•ªå·ã‚’ä½¿ç”¨ã—ã¦ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ ã‚’å†ç¢ºèªã™ã‚‹";

	/// <summary>
	/// Key: "Action.Verify"
	/// English String: "Verify"
	/// </summary>
	public override string ActionVerify => "ç¢ºèª";

	/// <summary>
	/// Key: "Description.EmailToResetPassword"
	/// English String: "Enter your email to reset your password."
	/// </summary>
	public override string DescriptionEmailToResetPassword => "ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ã‚’ãƒªã‚»ãƒƒãƒˆã™ã‚‹ã«ã¯ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã‚’å…¥åŠ›ã—ã¦ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Description.EmailToRetriveUsername"
	/// English String: "Enter your email to retrieve your username."
	/// </summary>
	public override string DescriptionEmailToRetriveUsername => "ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ ã‚’å†ç¢ºèªã™ã‚‹ã«ã¯ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã‚’å…¥åŠ›ã—ã¦ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Description.PasswordChangeEmail.Subject"
	/// email subject to change password
	/// English String: "Roblox Password Reset"
	/// </summary>
	public override string DescriptionPasswordChangeEmailSubject => "Robloxãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ãƒªã‚»ãƒƒãƒˆ";

	/// <summary>
	/// Key: "Description.PasswordResetEmail.Subject"
	/// Subject for password reset email
	/// English String: "Roblox Account Password Reset"
	/// </summary>
	public override string DescriptionPasswordResetEmailSubject => "Robloxã‚¢ã‚«ã‚¦ãƒ³ãƒˆã®ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ãƒªã‚»ãƒƒãƒˆ";

	/// <summary>
	/// Key: "Description.PhoneToResetPassword"
	/// English String: "Enter your phone number to reset your password."
	/// </summary>
	public override string DescriptionPhoneToResetPassword => "ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ã‚’ãƒªã‚»ãƒƒãƒˆã™ã‚‹ã«ã¯é›»è©±ç•ªå·ã‚’å…¥åŠ›ã—ã¦ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Description.PhoneToRetriveUsername"
	/// English String: "Enter your phone number to retrieve your username."
	/// </summary>
	public override string DescriptionPhoneToRetriveUsername => "ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ ã‚’å†ç¢ºèªã™ã‚‹ã«ã¯é›»è©±ç•ªå·ã‚’å…¥åŠ›ã—ã¦ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Heading.VerifyCode"
	/// verify code heading
	/// English String: "Verify Code"
	/// </summary>
	public override string HeadingVerifyCode => "èªè¨¼ã‚³ãƒ¼ãƒ‰";

	/// <summary>
	/// Key: "Heading.VerifyPhone"
	/// English String: "Verify Phone"
	/// </summary>
	public override string HeadingVerifyPhone => "é›»è©±ã‚’ç¢ºèª";

	/// <summary>
	/// Key: "HeadingForgetPasswordOrUsername"
	/// English String: "Forgot Password or Username"
	/// </summary>
	public override string HeadingForgetPasswordOrUsername => "ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ã€ã¾ãŸã¯ãƒ¦ãƒ¼ã‚¶ãƒãƒ¼ãƒ ã‚’å¿˜ã‚ŒãŸå ´åˆ";

	/// <summary>
	/// Key: "Label.ActionButtonYes"
	/// button label
	/// English String: "Yes"
	/// </summary>
	public override string LabelActionButtonYes => "ã¯ã„";

	/// <summary>
	/// Key: "Label.ForgetMyPassword"
	/// English String: "Forgot My Password"
	/// </summary>
	public override string LabelForgetMyPassword => "ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ã‚’å¿˜ã‚ŒãŸ";

	/// <summary>
	/// Key: "Label.ForgetMyUsername"
	/// English String: "Forgot My Username"
	/// </summary>
	public override string LabelForgetMyUsername => "ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ ã‚’å¿˜ã‚ŒãŸå ´åˆ";

	/// <summary>
	/// Key: "Label.InvalidEmail"
	/// English String: "Invalid email"
	/// </summary>
	public override string LabelInvalidEmail => "ç„¡åŠ¹ãªãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹";

	/// <summary>
	/// Key: "Label.InvalidPhoneNumber"
	/// English String: "Invalid phone number"
	/// </summary>
	public override string LabelInvalidPhoneNumber => "ç„¡åŠ¹ãªé›»è©±ç•ªå·";

	/// <summary>
	/// Key: "Label.NeutralButtonOk"
	/// ok button label
	/// English String: "OK"
	/// </summary>
	public override string LabelNeutralButtonOk => "OK";

	/// <summary>
	/// Key: "Label.Password"
	/// label
	/// English String: "Password"
	/// </summary>
	public override string LabelPassword => "ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰";

	/// <summary>
	/// Key: "Label.ResendCode"
	/// English String: "Resend Code"
	/// </summary>
	public override string LabelResendCode => "ã‚³ãƒ¼ãƒ‰ã‚’å†é€ä¿¡";

	/// <summary>
	/// Key: "Label.Submit"
	/// English String: "Submit"
	/// </summary>
	public override string LabelSubmit => "é€ä¿¡";

	/// <summary>
	/// Key: "Label.ToolTip.WhoCanFindMeByPhone"
	/// English String: "This setting controls who can find you using the phone number you provided."
	/// </summary>
	public override string LabelToolTipWhoCanFindMeByPhone => "ã“ã®è¨­å®šã§ãŠä½¿ã„ã®é›»è©±ç•ªå·ã‹ã‚‰ã‚ãªãŸã‚’è¦‹ã¤ã‘ã‚‰ã‚Œã‚‹äººã‚’æŒ‡å®šã§ãã¾ã™ã€‚";

	/// <summary>
	/// Key: "Label.Username"
	/// English String: "Username"
	/// </summary>
	public override string LabelUsername => "ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ ";

	/// <summary>
	/// Key: "Label.WhoCanFindMeByPhone"
	/// English String: "Who can find me by my phone number?"
	/// </summary>
	public override string LabelWhoCanFindMeByPhone => "é›»è©±ç•ªå·ã‹ã‚‰ã®æ¤œç´¢ã‚’è¨±å¯ã™ã‚‹å¯¾è±¡ã€‚";

	/// <summary>
	/// Key: "Message.DefaultError"
	/// English String: "An error occurred, try again later."
	/// </summary>
	public override string MessageDefaultError => "ã‚¨ãƒ©ãƒ¼ãŒç™ºç”Ÿã—ã¾ã—ãŸã€‚ã—ã°ã‚‰ãã—ã¦ã‹ã‚‰ã‚„ã‚Šç›´ã—ã¦ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Message.EmailForUsernameSuccessBody"
	/// success message
	/// English String: "An email with your username(s) has been sent to you if the email was previously saved on your account."
	/// </summary>
	public override string MessageEmailForUsernameSuccessBody => "ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ãŒã™ã§ã«ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã«ä¿å­˜ã•ã‚Œã¦ã„ã‚‹å ´åˆã¯ã€ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ ãŒè¨˜è¼‰ã•ã‚ŒãŸãƒ¡ãƒ¼ãƒ«ã‚’é€ä¿¡ã—ã¦ã„ã¾ã™ã€‚";

	/// <summary>
	/// Key: "Message.EmailSuccessBody"
	/// English String: "An email with instructions has been sent to you if the email was previously saved on your account."
	/// </summary>
	public override string MessageEmailSuccessBody => "ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ãŒã™ã§ã«ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã«ä¿å­˜ã•ã‚Œã¦ã„ã‚‹å ´åˆã¯ã€å¿…è¦ãªæ‰‹é †ãŒè¨˜è¼‰ã•ã‚ŒãŸãƒ¡ãƒ¼ãƒ«ã‚’é€ä¿¡ã—ã¦ã„ã¾ã™ã€‚";

	/// <summary>
	/// Key: "Message.EmailSuccessTitle"
	/// English String: "Email Sent"
	/// </summary>
	public override string MessageEmailSuccessTitle => "ãƒ¡ãƒ¼ãƒ«ãŒé€ä¿¡ã•ã‚Œã¾ã—ãŸ";

	/// <summary>
	/// Key: "Message.EnterCode"
	/// English String: "A code was sent to your phone if it was previously verified on your account. Please enter it below"
	/// </summary>
	public override string MessageEnterCode => "éŽåŽ»ã«ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã§èªè¨¼ã‚’è¡Œã£ãŸã“ã¨ãŒã‚ã‚‹å ´åˆã¯ã€ã‚³ãƒ¼ãƒ‰ã‚’æºå¸¯é›»è©±ã«é€ä¿¡ã—ã¦ã„ã¾ã™ã€‚é€ä¿¡ã•ã‚ŒãŸã‚³ãƒ¼ãƒ‰ã‚’å…¥åŠ›ã—ã¦ãã ã•ã„";

	/// <summary>
	/// Key: "Message.EnterCodeSentToEmail"
	/// Enter the code we just sent to your email.
	/// English String: "Enter the code we just sent to your email."
	/// </summary>
	public override string MessageEnterCodeSentToEmail => "ãƒ¡ãƒ¼ãƒ«ã«è¨˜è¼‰ã•ã‚ŒãŸã‚³ãƒ¼ãƒ‰ã‚’å…¥åŠ›ã—ã¦ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Message.PhoneForUsernameSuccessBody"
	/// English String: "An SMS with your username(s) has been sent to you if the phone number was previously verified on your account."
	/// </summary>
	public override string MessagePhoneForUsernameSuccessBody => "éŽåŽ»ã«ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã§é›»è©±ç•ªå·ã®èªè¨¼ã‚’è¡Œã£ãŸã“ã¨ãŒã‚ã‚‹å ´åˆã¯ã€ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ ãŒè¨˜è¼‰ã•ã‚ŒãŸSMSãƒ¡ãƒƒã‚»ãƒ¼ã‚¸ã‚’é€ä¿¡ã—ã¦ã„ã¾ã™ã€‚";

	/// <summary>
	/// Key: "Message.PhoneForUsernameSuccessTitle"
	/// English String: "SMS Sent"
	/// </summary>
	public override string MessagePhoneForUsernameSuccessTitle => "SMSãŒé€ä¿¡ã•ã‚Œã¾ã—ãŸ";

	/// <summary>
	/// Key: "MessageAccountDoesNotHaveAnEmail"
	/// English String: "There is no email linked to this account"
	/// </summary>
	public override string MessageAccountDoesNotHaveAnEmail => "ã“ã®ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã«ãƒªãƒ³ã‚¯æ¸ˆã¿ã®ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã¯ã‚ã‚Šã¾ã›ã‚“";

	/// <summary>
	/// Key: "MessageAccountNotFoundByEmail"
	/// No account found. Please use a different email.
	/// English String: "No account found. Please use a different email."
	/// </summary>
	public override string MessageAccountNotFoundByEmail => "ã‚¢ã‚«ã‚¦ãƒ³ãƒˆãŒè¦‹ã¤ã‹ã‚Šã¾ã›ã‚“ã§ã—ãŸã€‚åˆ¥ã®ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã‚’ã”åˆ©ç”¨ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "MessageAccountNotFoundByPhone"
	/// No account found. Please use a different phone number.
	/// English String: "No account found. Please use a different phone number."
	/// </summary>
	public override string MessageAccountNotFoundByPhone => "ã‚¢ã‚«ã‚¦ãƒ³ãƒˆãŒè¦‹ã¤ã‹ã‚Šã¾ã›ã‚“ã§ã—ãŸã€‚åˆ¥ã®é›»è©±ç•ªå·ã‚’ã”åˆ©ç”¨ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "MessageAccountRecoveryUnknownError"
	/// English String: "System error. Account could not be restored to this state."
	/// </summary>
	public override string MessageAccountRecoveryUnknownError => "ã‚·ã‚¹ãƒ†ãƒ ã‚¨ãƒ©ãƒ¼ãŒç™ºç”Ÿã—ã¾ã—ãŸã€‚ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã‚’ã“ã®çŠ¶æ…‹ã«å¾©æ—§ã§ãã¾ã›ã‚“ã§ã—ãŸã€‚";

	/// <summary>
	/// Key: "MessageCaptchaError"
	/// English String: "We need to make sure you're not a robot!"
	/// </summary>
	public override string MessageCaptchaError => "ãƒ­ãƒœãƒƒãƒˆå…¥åŠ›ã§ã¯ãªã„ã“ã¨ã‚’ç¢ºèªã™ã‚‹å¿…è¦ãŒã‚ã‚Šã¾ã™ï¼";

	/// <summary>
	/// Key: "MessageCaptchaFailError"
	/// English String: "The words you typed didn't match the picture. Please try again."
	/// </summary>
	public override string MessageCaptchaFailError => "ç”»åƒã®æ–‡å­—ã¨å…¥åŠ›ã—ãŸæ–‡å­—ãŒä¸€è‡´ã—ã¦ã„ã¾ã›ã‚“ã€‚ã‚‚ã†ä¸€åº¦ãŠè©¦ã—ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "MessageCredentialsError"
	/// English String: "Your username or password is incorrect. Please check them and try again."
	/// </summary>
	public override string MessageCredentialsError => "ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ ã€ã¾ãŸã¯ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ãŒé–“é•ã£ã¦ã„ã¾ã™ã€‚ã‚‚ã†ä¸€åº¦ãƒã‚§ãƒƒã‚¯ã—ã¦ã‹ã‚‰ã‚„ã‚Šç›´ã—ã¦ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "MessageFloodCheckedError"
	/// English String: "Too many attempts. Please try again later."
	/// </summary>
	public override string MessageFloodCheckedError => "è©¦è¡Œå›žæ•°ãŒå¤šã™ãŽã¾ã™ã€‚ã—ã°ã‚‰ãã—ã¦ã‹ã‚‰ã‚„ã‚Šç›´ã—ã¦ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "MessageForgotPasswordFeatureDisabled"
	/// English String: "Feature temporarily disabled. Please try again later."
	/// </summary>
	public override string MessageForgotPasswordFeatureDisabled => "æ©Ÿèƒ½ãŒä¸€æ™‚çš„ã«ç„¡åŠ¹ã«ãªã£ã¦ã„ã¾ã™ã€‚ã—ã°ã‚‰ãã—ã¦ã‹ã‚‰ã‚„ã‚Šç›´ã—ã¦ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "MessageForgotPasswordSuccess"
	/// English String: "Check your email for login instructions"
	/// </summary>
	public override string MessageForgotPasswordSuccess => "ãƒ­ã‚°ã‚¤ãƒ³æ–¹æ³•ã«ã¤ã„ã¦ã¯ãƒ¡ãƒ¼ãƒ«ã‚’ã”ã‚‰ã‚“ãã ã•ã„";

	/// <summary>
	/// Key: "MessageInvalidAccountStatus"
	/// English String: "Account status prevents resetting password"
	/// </summary>
	public override string MessageInvalidAccountStatus => "ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã‚¹ãƒ†ãƒ¼ã‚¿ã‚¹ã«ã‚ˆã‚Šãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ã®ãƒªã‚»ãƒƒãƒˆã¯ã§ãã¾ã›ã‚“";

	/// <summary>
	/// Key: "MessageInvalidPassword"
	/// English String: "Invalid password"
	/// </summary>
	public override string MessageInvalidPassword => "ç„¡åŠ¹ãªãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰";

	/// <summary>
	/// Key: "MessageInvalidTicket"
	/// English String: "We couldn't load this security ticket."
	/// </summary>
	public override string MessageInvalidTicket => "ã“ã®ã‚»ã‚­ãƒ¥ãƒªãƒ†ã‚£ãƒã‚±ãƒƒãƒˆã‚’èª­ã¿è¾¼ã‚ã¾ã›ã‚“ã§ã—ãŸã€‚";

	/// <summary>
	/// Key: "MessageInvalidUserNameOrEmail"
	/// English String: "Invalid username, or no email exists"
	/// </summary>
	public override string MessageInvalidUserNameOrEmail => "ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ ãŒç„¡åŠ¹ã§ã‚ã‚‹ã‹ã€ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ãŒå­˜åœ¨ã—ã¾ã›ã‚“";

	/// <summary>
	/// Key: "MessageMobileResetPasswordSuccess"
	/// English String: "MobileResetPasswordSuccess"
	/// </summary>
	public override string MessageMobileResetPasswordSuccess => "MobileResetPasswordSuccess";

	/// <summary>
	/// Key: "MessageNoAccountsLinkedToEmail"
	/// English String: "There are no accounts linked to this email address"
	/// </summary>
	public override string MessageNoAccountsLinkedToEmail => "ã“ã®ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã«ãƒªãƒ³ã‚¯æ¸ˆã¿ã®ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã¯ã‚ã‚Šã¾ã›ã‚“";

	/// <summary>
	/// Key: "MessageOldUsernameError"
	/// English String: "It looks like you are trying to log in with a username that has changed. Please log in with your new username."
	/// </summary>
	public override string MessageOldUsernameError => "å¤ã„ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ ãŒå…¥åŠ›ã•ã‚ŒãŸã‚ˆã†ã§ã™ã€‚æ–°ã—ã„ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ ã§ãƒ­ã‚°ã‚¤ãƒ³ã—ã¦ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "MessagePasswordCannotBeUsed"
	/// English String: "Sorry, that password cannot be used."
	/// </summary>
	public override string MessagePasswordCannotBeUsed => "ç”³ã—è¨³ã‚ã‚Šã¾ã›ã‚“ãŒã€ãã®ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ã¯ä½¿ç”¨ã§ãã¾ã›ã‚“ã€‚";

	/// <summary>
	/// Key: "MessagePasswordsDoNotMatch"
	/// English String: "Passwords do not match"
	/// </summary>
	public override string MessagePasswordsDoNotMatch => "ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ãŒä¸€è‡´ã—ã¾ã›ã‚“";

	/// <summary>
	/// Key: "MessageSamlUnauthenticated"
	/// English String: "You must log in to Roblox to finish authenticating."
	/// </summary>
	public override string MessageSamlUnauthenticated => "èªè¨¼ã‚’å®Œäº†ã™ã‚‹ã«ã¯Robloxã«ãƒ­ã‚°ã‚¤ãƒ³ã™ã‚‹å¿…è¦ãŒã‚ã‚Šã¾ã™ã€‚";

	/// <summary>
	/// Key: "MessageUnknownError"
	/// English String: "Unknown Error"
	/// </summary>
	public override string MessageUnknownError => "ä¸æ˜Žãªã‚¨ãƒ©ãƒ¼ãŒç™ºç”Ÿã—ã¾ã—ãŸ";

	/// <summary>
	/// Key: "MessageUnknownSystemError"
	/// English String: "System error. Please return to login screen."
	/// </summary>
	public override string MessageUnknownSystemError => "ã‚·ã‚¹ãƒ†ãƒ ã‚¨ãƒ©ãƒ¼ãŒç™ºç”Ÿã—ã¾ã—ãŸã€‚ãƒ­ã‚°ã‚¤ãƒ³ç”»é¢ã«ãŠæˆ»ã‚Šãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Placeholder.Email"
	/// English String: "Email"
	/// </summary>
	public override string PlaceholderEmail => "ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹";

	/// <summary>
	/// Key: "Placeholder.PhoneNumber"
	/// English String: "Phone Number"
	/// </summary>
	public override string PlaceholderPhoneNumber => "é›»è©±ç•ªå·";

	/// <summary>
	/// Key: "Response.PasswordResetSuccess"
	/// Password reset success! Please login again.
	/// English String: "Password reset success! Please login again."
	/// </summary>
	public override string ResponsePasswordResetSuccess => "ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ã®ãƒªã‚»ãƒƒãƒˆã«æˆåŠŸã—ã¾ã—ãŸï¼ã‚‚ã†ä¸€åº¦ãƒ­ã‚°ã‚¤ãƒ³ã—ã¦ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Response.Success"
	/// English String: "Success"
	/// </summary>
	public override string ResponseSuccess => "æˆåŠŸ";

	/// <summary>
	/// Key: "Response.UpdatePasswordFlooded"
	/// English String: "Too many attempts. Please try again later."
	/// </summary>
	public override string ResponseUpdatePasswordFlooded => "è©¦è¡Œå›žæ•°ãŒå¤šã™ãŽã¾ã™ã€‚ã—ã°ã‚‰ãã—ã¦ã‹ã‚‰ã‚„ã‚Šç›´ã—ã¦ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Response.UpdatePasswordIncorrect"
	/// English String: "Your current password is incorrect, the password was not changed."
	/// </summary>
	public override string ResponseUpdatePasswordIncorrect => "ç¾åœ¨ã®ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ãŒé–“é•ã£ã¦ã„ã¾ã™ã€‚ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ã¯å¤‰æ›´ã•ã‚Œã¾ã›ã‚“ã§ã—ãŸã€‚";

	/// <summary>
	/// Key: "Response.UpdatePasswordInputMissing"
	/// English String: "Must include new password and confirm password"
	/// </summary>
	public override string ResponseUpdatePasswordInputMissing => "æ–°ã—ã„ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ã¨ç¢ºèªãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ã‚’å«ã‚€å¿…è¦ãŒã‚ã‚Šã¾ã™";

	/// <summary>
	/// Key: "Response.UpdatePasswordMismatch"
	/// English String: "Your new password and confirm password must match"
	/// </summary>
	public override string ResponseUpdatePasswordMismatch => "æ–°ã—ã„ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ã¨ç¢ºèªãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ãŒä¸€è‡´ã—ã¦ã„ã‚‹å¿…è¦ãŒã‚ã‚Šã¾ã™";

	public ResetPasswordResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "ã‚­ãƒ£ãƒ³ã‚»ãƒ«";
	}

	protected override string _GetTemplateForActionEmailToResetPassword()
	{
		return "ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã‚’ä½¿ç”¨ã—ã¦ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ã‚’ãƒªã‚»ãƒƒãƒˆã™ã‚‹";
	}

	protected override string _GetTemplateForActionEmailToRetriveUsername()
	{
		return "ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã‚’ä½¿ç”¨ã—ã¦ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ ã‚’å†ç¢ºèªã™ã‚‹";
	}

	protected override string _GetTemplateForActionOk()
	{
		return "OK";
	}

	protected override string _GetTemplateForActionPhoneToResetPassword()
	{
		return "é›»è©±ç•ªå·ã‚’ä½¿ç”¨ã—ã¦ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ã‚’ãƒªã‚»ãƒƒãƒˆã™ã‚‹";
	}

	protected override string _GetTemplateForActionPhoneToRetriveUsername()
	{
		return "é›»è©±ç•ªå·ã‚’ä½¿ç”¨ã—ã¦ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ ã‚’å†ç¢ºèªã™ã‚‹";
	}

	protected override string _GetTemplateForActionVerify()
	{
		return "ç¢ºèª";
	}

	/// <summary>
	/// Key: "Description.ChangePasswordEmail.HtmlBody1"
	/// email body for change password email
	/// English String: "We noticed that the password changed for your Roblox account: {userName}. If you didn't intend to change it, or you think someone else changed it by mistake, please click this link to undo the action:{lineBreak} {actionLink} {lineBreak}{lineBreak}If you are happy with your new Roblox password, you don't have to do anything! It's already set up. Please do not reply to this message. If you have any questions, please see the Roblox help page (https://www.roblox.com/help)."
	/// </summary>
	public override string DescriptionChangePasswordEmailHtmlBody1(string userName, string lineBreak, string actionLink)
	{
		return $"ãŠä½¿ã„ã®Robloxã‚¢ã‚«ã‚¦ãƒ³ãƒˆï¼ˆ{userName}ï¼‰ã§ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰å¤‰æ›´ãŒè¡Œã‚ã‚Œã¦ã„ã¾ã™ã€‚å¤‰æ›´ã™ã‚‹ã¤ã‚‚ã‚ŠãŒãªã‹ã£ãŸã‚Šã€ä»–ã®èª°ã‹ãŒé–“é•ã£ã¦å¤‰æ›´ã—ãŸã¨æ€ã‚ã‚Œã‚‹å ´åˆã€ä»¥ä¸‹ã®ãƒªãƒ³ã‚¯ã‚’ã‚¯ãƒªãƒƒã‚¯ã—ã¦æ“ä½œã‚’å–ã‚Šæ¶ˆã—ã¦ãã ã•ã„:{lineBreak} {actionLink} {lineBreak}{lineBreak}æ–°ã—ã„Robloxã®ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ã«å•é¡ŒãŒãªã‘ã‚Œã°ã€ä½•ã‚‚ã™ã‚‹å¿…è¦ã¯ã‚ã‚Šã¾ã›ã‚“ã€‚æ–°ã—ã„ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ã¯ã™ã§ã«è¨­å®šã•ã‚Œã¦ã„ã¾ã™ã€‚ä½•ã‹è³ªå•ãŒã‚ã‚Œã°ã€Robloxã®ãƒ˜ãƒ«ãƒ—ãƒšãƒ¼ã‚¸(https://www.roblox.com/help)ã‚’è¦‹ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForDescriptionChangePasswordEmailHtmlBody1()
	{
		return "ãŠä½¿ã„ã®Robloxã‚¢ã‚«ã‚¦ãƒ³ãƒˆï¼ˆ{userName}ï¼‰ã§ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰å¤‰æ›´ãŒè¡Œã‚ã‚Œã¦ã„ã¾ã™ã€‚å¤‰æ›´ã™ã‚‹ã¤ã‚‚ã‚ŠãŒãªã‹ã£ãŸã‚Šã€ä»–ã®èª°ã‹ãŒé–“é•ã£ã¦å¤‰æ›´ã—ãŸã¨æ€ã‚ã‚Œã‚‹å ´åˆã€ä»¥ä¸‹ã®ãƒªãƒ³ã‚¯ã‚’ã‚¯ãƒªãƒƒã‚¯ã—ã¦æ“ä½œã‚’å–ã‚Šæ¶ˆã—ã¦ãã ã•ã„:{lineBreak} {actionLink} {lineBreak}{lineBreak}æ–°ã—ã„Robloxã®ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ã«å•é¡ŒãŒãªã‘ã‚Œã°ã€ä½•ã‚‚ã™ã‚‹å¿…è¦ã¯ã‚ã‚Šã¾ã›ã‚“ã€‚æ–°ã—ã„ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ã¯ã™ã§ã«è¨­å®šã•ã‚Œã¦ã„ã¾ã™ã€‚ä½•ã‹è³ªå•ãŒã‚ã‚Œã°ã€Robloxã®ãƒ˜ãƒ«ãƒ—ãƒšãƒ¼ã‚¸(https://www.roblox.com/help)ã‚’è¦‹ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForDescriptionEmailToResetPassword()
	{
		return "ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ã‚’ãƒªã‚»ãƒƒãƒˆã™ã‚‹ã«ã¯ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã‚’å…¥åŠ›ã—ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForDescriptionEmailToRetriveUsername()
	{
		return "ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ ã‚’å†ç¢ºèªã™ã‚‹ã«ã¯ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã‚’å…¥åŠ›ã—ã¦ãã ã•ã„ã€‚";
	}

	/// <summary>
	/// Key: "Description.PasswordChangeEmail.BodyPlainText"
	/// password reset plaintext email message
	/// English String: "We noticed that the password changed for your Roblox account: {userName}. If you didn't intend to change it, or you think someone else changed it by mistake, please click this link to undo the action:\n{urlWithTicket}\n\nIf you are happy with your new Roblox password, you don't have to do anything! It's already set up. Please do not reply to this message. If you have any questions, please see the Roblox help page (https://www.roblox.com/help)."
	/// </summary>
	public override string DescriptionPasswordChangeEmailBodyPlainText(string userName, string urlWithTicket)
	{
		return $"ãŠä½¿ã„ã®Robloxã‚¢ã‚«ã‚¦ãƒ³ãƒˆï¼ˆ{userName}ï¼‰ã§ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰å¤‰æ›´ãŒè¡Œã‚ã‚Œã¦ã„ã¾ã™ã€‚å¤‰æ›´ã™ã‚‹ã¤ã‚‚ã‚ŠãŒãªã‹ã£ãŸã‚Šã€ä»–ã®èª°ã‹ãŒé–“é•ã£ã¦å¤‰æ›´ã—ãŸã¨æ€ã‚ã‚Œã‚‹å ´åˆã€ä»¥ä¸‹ã®ãƒªãƒ³ã‚¯ã‚’ã‚¯ãƒªãƒƒã‚¯ã—ã¦æ“ä½œã‚’å–ã‚Šæ¶ˆã—ã¦ãã ã•ã„:\n{urlWithTicket}\n\næ–°ã—ã„Robloxã®ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ã«å•é¡ŒãŒãªã‘ã‚Œã°ã€ä½•ã‚‚ã™ã‚‹å¿…è¦ã¯ã‚ã‚Šã¾ã›ã‚“ã€‚æ–°ã—ã„ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ã¯ã™ã§ã«è¨­å®šã•ã‚Œã¦ã„ã¾ã™ã€‚ä½•ã‹è³ªå•ãŒã‚ã‚Œã°ã€Robloxã®ãƒ˜ãƒ«ãƒ—ãƒšãƒ¼ã‚¸(https://www.roblox.com/help)ã‚’è¦‹ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForDescriptionPasswordChangeEmailBodyPlainText()
	{
		return "ãŠä½¿ã„ã®Robloxã‚¢ã‚«ã‚¦ãƒ³ãƒˆï¼ˆ{userName}ï¼‰ã§ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰å¤‰æ›´ãŒè¡Œã‚ã‚Œã¦ã„ã¾ã™ã€‚å¤‰æ›´ã™ã‚‹ã¤ã‚‚ã‚ŠãŒãªã‹ã£ãŸã‚Šã€ä»–ã®èª°ã‹ãŒé–“é•ã£ã¦å¤‰æ›´ã—ãŸã¨æ€ã‚ã‚Œã‚‹å ´åˆã€ä»¥ä¸‹ã®ãƒªãƒ³ã‚¯ã‚’ã‚¯ãƒªãƒƒã‚¯ã—ã¦æ“ä½œã‚’å–ã‚Šæ¶ˆã—ã¦ãã ã•ã„:\n{urlWithTicket}\n\næ–°ã—ã„Robloxã®ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ã«å•é¡ŒãŒãªã‘ã‚Œã°ã€ä½•ã‚‚ã™ã‚‹å¿…è¦ã¯ã‚ã‚Šã¾ã›ã‚“ã€‚æ–°ã—ã„ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ã¯ã™ã§ã«è¨­å®šã•ã‚Œã¦ã„ã¾ã™ã€‚ä½•ã‹è³ªå•ãŒã‚ã‚Œã°ã€Robloxã®ãƒ˜ãƒ«ãƒ—ãƒšãƒ¼ã‚¸(https://www.roblox.com/help)ã‚’è¦‹ã¦ãã ã•ã„ã€‚";
	}

	/// <summary>
	/// Key: "Description.PasswordChangeEmail.From"
	/// name of the sender as shown in from field of the email
	/// English String: "\"Roblox Password Reset\" {fromEmailAddress}"
	/// </summary>
	public override string DescriptionPasswordChangeEmailFrom(string fromEmailAddress)
	{
		return $"\"Robloxãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ãƒªã‚»ãƒƒãƒˆ\"{fromEmailAddress}";
	}

	protected override string _GetTemplateForDescriptionPasswordChangeEmailFrom()
	{
		return "\"Robloxãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ãƒªã‚»ãƒƒãƒˆ\"{fromEmailAddress}";
	}

	protected override string _GetTemplateForDescriptionPasswordChangeEmailSubject()
	{
		return "Robloxãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ãƒªã‚»ãƒƒãƒˆ";
	}

	/// <summary>
	/// Key: "Description.PasswordResetEmail.From"
	/// The "From" field for the password reset email
	/// English String: "{escapeLiteralStart}Roblox Password Reset{escapeLiteralEnd} {fromEmailAddress}"
	/// </summary>
	public override string DescriptionPasswordResetEmailFrom(string escapeLiteralStart, string escapeLiteralEnd, string fromEmailAddress)
	{
		return $"{escapeLiteralStart}Robloxãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ãƒªã‚»ãƒƒãƒˆ{escapeLiteralEnd}{fromEmailAddress}";
	}

	protected override string _GetTemplateForDescriptionPasswordResetEmailFrom()
	{
		return "{escapeLiteralStart}Robloxãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ãƒªã‚»ãƒƒãƒˆ{escapeLiteralEnd}{fromEmailAddress}";
	}

	/// <summary>
	/// Key: "Description.PasswordResetEmail.HtmlBody"
	/// This email is sent when a user requests a password reset.
	/// English String: "We have received a request to reset the password for your Roblox account: {emailOrUsername}{lineBreak}{lineBreak}If you submitted this request, please click the button below to proceed.{lineBreak}This button will be active for {passwordResetTicketHours} hours, {passwordResetTicketMinutes} minutes. If you do not wish to reset your password, please disregard this notice.{lineBreak}{lineBreak}{aTagWithStartHref}{resetPasswordUrl}{hrefEnd}{buttonStart}Reset Password{buttonEnd}{aTagEnd}"
	/// </summary>
	public override string DescriptionPasswordResetEmailHtmlBody(string emailOrUsername, string lineBreak, string passwordResetTicketHours, string passwordResetTicketMinutes, string aTagWithStartHref, string resetPasswordUrl, string hrefEnd, string buttonStart, string buttonEnd, string aTagEnd)
	{
		return $"Roblox ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã«å¯¾ã—ã¦ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ãƒªã‚»ãƒƒãƒˆã®ãƒªã‚¯ã‚¨ã‚¹ãƒˆãŒå±Šãã¾ã—ãŸï¼š{emailOrUsername}{lineBreak}{lineBreak}ã“ã®ãƒªã‚¯ã‚¨ã‚¹ãƒˆã‚’é€ä¿¡ã—ãŸå ´åˆã¯ã€ä¸‹ã®ãƒœã‚¿ãƒ³ã‚’ã‚¯ãƒªãƒƒã‚¯ã™ã‚‹ã‹ã€ã‚¦ã‚§ãƒ–ãƒ–ãƒ©ã‚¦ã‚¶ã«è²¼ã‚Šä»˜ã‘ã¦ç¶šè¡Œã—ã¦ãã ã•ã„ã€‚{lineBreak}ã“ã®ãƒªãƒ³ã‚¯ã®æœŸé™ã¯{passwordResetTicketHours}æ™‚é–“{passwordResetTicketMinutes}åˆ†ã§ã™ã€‚ ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ã‚’ãƒªã‚»ãƒƒãƒˆã—ãŸããªã„å ´åˆã¯ã€ã“ã®é€šçŸ¥ã‚’ç„¡è¦–ã—ã¦ãã ã•ã„ã€‚{lineBreak}{lineBreak}{aTagWithStartHref}{resetPasswordUrl}{hrefEnd}{buttonStart}ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ãƒªã‚»ãƒƒãƒˆ{buttonEnd}{aTagEnd}";
	}

	protected override string _GetTemplateForDescriptionPasswordResetEmailHtmlBody()
	{
		return "Roblox ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã«å¯¾ã—ã¦ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ãƒªã‚»ãƒƒãƒˆã®ãƒªã‚¯ã‚¨ã‚¹ãƒˆãŒå±Šãã¾ã—ãŸï¼š{emailOrUsername}{lineBreak}{lineBreak}ã“ã®ãƒªã‚¯ã‚¨ã‚¹ãƒˆã‚’é€ä¿¡ã—ãŸå ´åˆã¯ã€ä¸‹ã®ãƒœã‚¿ãƒ³ã‚’ã‚¯ãƒªãƒƒã‚¯ã™ã‚‹ã‹ã€ã‚¦ã‚§ãƒ–ãƒ–ãƒ©ã‚¦ã‚¶ã«è²¼ã‚Šä»˜ã‘ã¦ç¶šè¡Œã—ã¦ãã ã•ã„ã€‚{lineBreak}ã“ã®ãƒªãƒ³ã‚¯ã®æœŸé™ã¯{passwordResetTicketHours}æ™‚é–“{passwordResetTicketMinutes}åˆ†ã§ã™ã€‚ ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ã‚’ãƒªã‚»ãƒƒãƒˆã—ãŸããªã„å ´åˆã¯ã€ã“ã®é€šçŸ¥ã‚’ç„¡è¦–ã—ã¦ãã ã•ã„ã€‚{lineBreak}{lineBreak}{aTagWithStartHref}{resetPasswordUrl}{hrefEnd}{buttonStart}ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ãƒªã‚»ãƒƒãƒˆ{buttonEnd}{aTagEnd}";
	}

	/// <summary>
	/// Key: "Description.PasswordResetEmail.PlainBody"
	/// This email is sent when a user requests a password reset.
	/// English String: "We have received a request to reset the password for your Roblox account: {emailOrUsername}{lineBreak}{lineBreak}If you submitted this request, please click the link below or paste it into a web browser to proceed.{lineBreak}This link will be active for {passwordResetTicketHours} hours, {passwordResetTicketMinutes} minutes. If you do not wish to reset your password, please disregard this notice.{lineBreak}{lineBreak}{resetPasswordUrl}"
	/// </summary>
	public override string DescriptionPasswordResetEmailPlainBody(string emailOrUsername, string lineBreak, string passwordResetTicketHours, string passwordResetTicketMinutes, string resetPasswordUrl)
	{
		return $"Roblox ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã«å¯¾ã—ã¦ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ãƒªã‚»ãƒƒãƒˆã®ãƒªã‚¯ã‚¨ã‚¹ãƒˆãŒå±Šãã¾ã—ãŸï¼š{emailOrUsername}{lineBreak}{lineBreak}ã“ã®ãƒªã‚¯ã‚¨ã‚¹ãƒˆã‚’é€ä¿¡ã—ãŸå ´åˆã¯ã€ä¸‹ã®ãƒªãƒ³ã‚¯ã‚’ã‚¯ãƒªãƒƒã‚¯ã™ã‚‹ã‹ã€ã‚¦ã‚§ãƒ–ãƒ–ãƒ©ã‚¦ã‚¶ã«è²¼ã‚Šä»˜ã‘ã¦ç¶šè¡Œã—ã¦ãã ã•ã„ã€‚{lineBreak}ã“ã®ãƒªãƒ³ã‚¯ã®æœŸé™ã¯{passwordResetTicketHours}æ™‚é–“{passwordResetTicketMinutes}åˆ†ã§ã™ã€‚ ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ã‚’ãƒªã‚»ãƒƒãƒˆã—ãŸããªã„å ´åˆã¯ã€ã“ã®é€šçŸ¥ã‚’ç„¡è¦–ã—ã¦ãã ã•ã„ã€‚{lineBreak}{lineBreak}{resetPasswordUrl}";
	}

	protected override string _GetTemplateForDescriptionPasswordResetEmailPlainBody()
	{
		return "Roblox ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã«å¯¾ã—ã¦ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ãƒªã‚»ãƒƒãƒˆã®ãƒªã‚¯ã‚¨ã‚¹ãƒˆãŒå±Šãã¾ã—ãŸï¼š{emailOrUsername}{lineBreak}{lineBreak}ã“ã®ãƒªã‚¯ã‚¨ã‚¹ãƒˆã‚’é€ä¿¡ã—ãŸå ´åˆã¯ã€ä¸‹ã®ãƒªãƒ³ã‚¯ã‚’ã‚¯ãƒªãƒƒã‚¯ã™ã‚‹ã‹ã€ã‚¦ã‚§ãƒ–ãƒ–ãƒ©ã‚¦ã‚¶ã«è²¼ã‚Šä»˜ã‘ã¦ç¶šè¡Œã—ã¦ãã ã•ã„ã€‚{lineBreak}ã“ã®ãƒªãƒ³ã‚¯ã®æœŸé™ã¯{passwordResetTicketHours}æ™‚é–“{passwordResetTicketMinutes}åˆ†ã§ã™ã€‚ ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ã‚’ãƒªã‚»ãƒƒãƒˆã—ãŸããªã„å ´åˆã¯ã€ã“ã®é€šçŸ¥ã‚’ç„¡è¦–ã—ã¦ãã ã•ã„ã€‚{lineBreak}{lineBreak}{resetPasswordUrl}";
	}

	protected override string _GetTemplateForDescriptionPasswordResetEmailSubject()
	{
		return "Robloxã‚¢ã‚«ã‚¦ãƒ³ãƒˆã®ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ãƒªã‚»ãƒƒãƒˆ";
	}

	protected override string _GetTemplateForDescriptionPhoneToResetPassword()
	{
		return "ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ã‚’ãƒªã‚»ãƒƒãƒˆã™ã‚‹ã«ã¯é›»è©±ç•ªå·ã‚’å…¥åŠ›ã—ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForDescriptionPhoneToRetriveUsername()
	{
		return "ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ ã‚’å†ç¢ºèªã™ã‚‹ã«ã¯é›»è©±ç•ªå·ã‚’å…¥åŠ›ã—ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForHeadingVerifyCode()
	{
		return "èªè¨¼ã‚³ãƒ¼ãƒ‰";
	}

	protected override string _GetTemplateForHeadingVerifyPhone()
	{
		return "é›»è©±ã‚’ç¢ºèª";
	}

	protected override string _GetTemplateForHeadingForgetPasswordOrUsername()
	{
		return "ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ã€ã¾ãŸã¯ãƒ¦ãƒ¼ã‚¶ãƒãƒ¼ãƒ ã‚’å¿˜ã‚ŒãŸå ´åˆ";
	}

	protected override string _GetTemplateForLabelActionButtonYes()
	{
		return "ã¯ã„";
	}

	protected override string _GetTemplateForLabelForgetMyPassword()
	{
		return "ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ã‚’å¿˜ã‚ŒãŸ";
	}

	protected override string _GetTemplateForLabelForgetMyUsername()
	{
		return "ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ ã‚’å¿˜ã‚ŒãŸå ´åˆ";
	}

	protected override string _GetTemplateForLabelInvalidEmail()
	{
		return "ç„¡åŠ¹ãªãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹";
	}

	protected override string _GetTemplateForLabelInvalidPhoneNumber()
	{
		return "ç„¡åŠ¹ãªé›»è©±ç•ªå·";
	}

	protected override string _GetTemplateForLabelNeutralButtonOk()
	{
		return "OK";
	}

	protected override string _GetTemplateForLabelPassword()
	{
		return "ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰";
	}

	protected override string _GetTemplateForLabelResendCode()
	{
		return "ã‚³ãƒ¼ãƒ‰ã‚’å†é€ä¿¡";
	}

	protected override string _GetTemplateForLabelSubmit()
	{
		return "é€ä¿¡";
	}

	protected override string _GetTemplateForLabelToolTipWhoCanFindMeByPhone()
	{
		return "ã“ã®è¨­å®šã§ãŠä½¿ã„ã®é›»è©±ç•ªå·ã‹ã‚‰ã‚ãªãŸã‚’è¦‹ã¤ã‘ã‚‰ã‚Œã‚‹äººã‚’æŒ‡å®šã§ãã¾ã™ã€‚";
	}

	protected override string _GetTemplateForLabelUsername()
	{
		return "ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ ";
	}

	protected override string _GetTemplateForLabelWhoCanFindMeByPhone()
	{
		return "é›»è©±ç•ªå·ã‹ã‚‰ã®æ¤œç´¢ã‚’è¨±å¯ã™ã‚‹å¯¾è±¡ã€‚";
	}

	/// <summary>
	/// Key: "Message.CantSendEmailWarning"
	/// English String: "If you did not give us a {styleStart}real email address{styleEnd} when you created your account, we cannot send you an email."
	/// </summary>
	public override string MessageCantSendEmailWarning(string styleStart, string styleEnd)
	{
		return $"ã‚¢ã‚«ã‚¦ãƒ³ãƒˆä½œæˆæ™‚ã«{styleStart}æœ¬ç‰©ã®ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹{styleEnd}ã‚’å…¥åŠ›ã—ã¦ã„ãªã„ã¨ã€ã“ã¡ã‚‰ã‹ã‚‰ãƒ¡ãƒ¼ãƒ«ã‚’é€ã‚‹ã“ã¨ãŒã§ãã¾ã›ã‚“ã€‚";
	}

	protected override string _GetTemplateForMessageCantSendEmailWarning()
	{
		return "ã‚¢ã‚«ã‚¦ãƒ³ãƒˆä½œæˆæ™‚ã«{styleStart}æœ¬ç‰©ã®ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹{styleEnd}ã‚’å…¥åŠ›ã—ã¦ã„ãªã„ã¨ã€ã“ã¡ã‚‰ã‹ã‚‰ãƒ¡ãƒ¼ãƒ«ã‚’é€ã‚‹ã“ã¨ãŒã§ãã¾ã›ã‚“ã€‚";
	}

	protected override string _GetTemplateForMessageDefaultError()
	{
		return "ã‚¨ãƒ©ãƒ¼ãŒç™ºç”Ÿã—ã¾ã—ãŸã€‚ã—ã°ã‚‰ãã—ã¦ã‹ã‚‰ã‚„ã‚Šç›´ã—ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForMessageEmailForUsernameSuccessBody()
	{
		return "ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ãŒã™ã§ã«ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã«ä¿å­˜ã•ã‚Œã¦ã„ã‚‹å ´åˆã¯ã€ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ ãŒè¨˜è¼‰ã•ã‚ŒãŸãƒ¡ãƒ¼ãƒ«ã‚’é€ä¿¡ã—ã¦ã„ã¾ã™ã€‚";
	}

	protected override string _GetTemplateForMessageEmailSuccessBody()
	{
		return "ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ãŒã™ã§ã«ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã«ä¿å­˜ã•ã‚Œã¦ã„ã‚‹å ´åˆã¯ã€å¿…è¦ãªæ‰‹é †ãŒè¨˜è¼‰ã•ã‚ŒãŸãƒ¡ãƒ¼ãƒ«ã‚’é€ä¿¡ã—ã¦ã„ã¾ã™ã€‚";
	}

	protected override string _GetTemplateForMessageEmailSuccessTitle()
	{
		return "ãƒ¡ãƒ¼ãƒ«ãŒé€ä¿¡ã•ã‚Œã¾ã—ãŸ";
	}

	protected override string _GetTemplateForMessageEnterCode()
	{
		return "éŽåŽ»ã«ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã§èªè¨¼ã‚’è¡Œã£ãŸã“ã¨ãŒã‚ã‚‹å ´åˆã¯ã€ã‚³ãƒ¼ãƒ‰ã‚’æºå¸¯é›»è©±ã«é€ä¿¡ã—ã¦ã„ã¾ã™ã€‚é€ä¿¡ã•ã‚ŒãŸã‚³ãƒ¼ãƒ‰ã‚’å…¥åŠ›ã—ã¦ãã ã•ã„";
	}

	protected override string _GetTemplateForMessageEnterCodeSentToEmail()
	{
		return "ãƒ¡ãƒ¼ãƒ«ã«è¨˜è¼‰ã•ã‚ŒãŸã‚³ãƒ¼ãƒ‰ã‚’å…¥åŠ›ã—ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForMessagePhoneForUsernameSuccessBody()
	{
		return "éŽåŽ»ã«ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã§é›»è©±ç•ªå·ã®èªè¨¼ã‚’è¡Œã£ãŸã“ã¨ãŒã‚ã‚‹å ´åˆã¯ã€ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ ãŒè¨˜è¼‰ã•ã‚ŒãŸSMSãƒ¡ãƒƒã‚»ãƒ¼ã‚¸ã‚’é€ä¿¡ã—ã¦ã„ã¾ã™ã€‚";
	}

	protected override string _GetTemplateForMessagePhoneForUsernameSuccessTitle()
	{
		return "SMSãŒé€ä¿¡ã•ã‚Œã¾ã—ãŸ";
	}

	protected override string _GetTemplateForMessageAccountDoesNotHaveAnEmail()
	{
		return "ã“ã®ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã«ãƒªãƒ³ã‚¯æ¸ˆã¿ã®ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã¯ã‚ã‚Šã¾ã›ã‚“";
	}

	protected override string _GetTemplateForMessageAccountNotFoundByEmail()
	{
		return "ã‚¢ã‚«ã‚¦ãƒ³ãƒˆãŒè¦‹ã¤ã‹ã‚Šã¾ã›ã‚“ã§ã—ãŸã€‚åˆ¥ã®ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã‚’ã”åˆ©ç”¨ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForMessageAccountNotFoundByPhone()
	{
		return "ã‚¢ã‚«ã‚¦ãƒ³ãƒˆãŒè¦‹ã¤ã‹ã‚Šã¾ã›ã‚“ã§ã—ãŸã€‚åˆ¥ã®é›»è©±ç•ªå·ã‚’ã”åˆ©ç”¨ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForMessageAccountRecoveryUnknownError()
	{
		return "ã‚·ã‚¹ãƒ†ãƒ ã‚¨ãƒ©ãƒ¼ãŒç™ºç”Ÿã—ã¾ã—ãŸã€‚ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã‚’ã“ã®çŠ¶æ…‹ã«å¾©æ—§ã§ãã¾ã›ã‚“ã§ã—ãŸã€‚";
	}

	protected override string _GetTemplateForMessageCaptchaError()
	{
		return "ãƒ­ãƒœãƒƒãƒˆå…¥åŠ›ã§ã¯ãªã„ã“ã¨ã‚’ç¢ºèªã™ã‚‹å¿…è¦ãŒã‚ã‚Šã¾ã™ï¼";
	}

	protected override string _GetTemplateForMessageCaptchaFailError()
	{
		return "ç”»åƒã®æ–‡å­—ã¨å…¥åŠ›ã—ãŸæ–‡å­—ãŒä¸€è‡´ã—ã¦ã„ã¾ã›ã‚“ã€‚ã‚‚ã†ä¸€åº¦ãŠè©¦ã—ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForMessageCredentialsError()
	{
		return "ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ ã€ã¾ãŸã¯ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ãŒé–“é•ã£ã¦ã„ã¾ã™ã€‚ã‚‚ã†ä¸€åº¦ãƒã‚§ãƒƒã‚¯ã—ã¦ã‹ã‚‰ã‚„ã‚Šç›´ã—ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForMessageFloodCheckedError()
	{
		return "è©¦è¡Œå›žæ•°ãŒå¤šã™ãŽã¾ã™ã€‚ã—ã°ã‚‰ãã—ã¦ã‹ã‚‰ã‚„ã‚Šç›´ã—ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForMessageForgotPasswordFeatureDisabled()
	{
		return "æ©Ÿèƒ½ãŒä¸€æ™‚çš„ã«ç„¡åŠ¹ã«ãªã£ã¦ã„ã¾ã™ã€‚ã—ã°ã‚‰ãã—ã¦ã‹ã‚‰ã‚„ã‚Šç›´ã—ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForMessageForgotPasswordSuccess()
	{
		return "ãƒ­ã‚°ã‚¤ãƒ³æ–¹æ³•ã«ã¤ã„ã¦ã¯ãƒ¡ãƒ¼ãƒ«ã‚’ã”ã‚‰ã‚“ãã ã•ã„";
	}

	protected override string _GetTemplateForMessageInvalidAccountStatus()
	{
		return "ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã‚¹ãƒ†ãƒ¼ã‚¿ã‚¹ã«ã‚ˆã‚Šãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ã®ãƒªã‚»ãƒƒãƒˆã¯ã§ãã¾ã›ã‚“";
	}

	protected override string _GetTemplateForMessageInvalidPassword()
	{
		return "ç„¡åŠ¹ãªãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰";
	}

	protected override string _GetTemplateForMessageInvalidTicket()
	{
		return "ã“ã®ã‚»ã‚­ãƒ¥ãƒªãƒ†ã‚£ãƒã‚±ãƒƒãƒˆã‚’èª­ã¿è¾¼ã‚ã¾ã›ã‚“ã§ã—ãŸã€‚";
	}

	protected override string _GetTemplateForMessageInvalidUserNameOrEmail()
	{
		return "ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ ãŒç„¡åŠ¹ã§ã‚ã‚‹ã‹ã€ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ãŒå­˜åœ¨ã—ã¾ã›ã‚“";
	}

	protected override string _GetTemplateForMessageMobileResetPasswordSuccess()
	{
		return "MobileResetPasswordSuccess";
	}

	protected override string _GetTemplateForMessageNoAccountsLinkedToEmail()
	{
		return "ã“ã®ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã«ãƒªãƒ³ã‚¯æ¸ˆã¿ã®ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã¯ã‚ã‚Šã¾ã›ã‚“";
	}

	protected override string _GetTemplateForMessageOldUsernameError()
	{
		return "å¤ã„ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ ãŒå…¥åŠ›ã•ã‚ŒãŸã‚ˆã†ã§ã™ã€‚æ–°ã—ã„ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ ã§ãƒ­ã‚°ã‚¤ãƒ³ã—ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForMessagePasswordCannotBeUsed()
	{
		return "ç”³ã—è¨³ã‚ã‚Šã¾ã›ã‚“ãŒã€ãã®ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ã¯ä½¿ç”¨ã§ãã¾ã›ã‚“ã€‚";
	}

	/// <summary>
	/// Key: "MessagePasswordResetTicketExpired"
	/// English String: "Sorry, password reset requests expire {expirationHour} hours, {expirationMinute} minutes after issuance. Try requesting another password reset ticket again."
	/// </summary>
	public override string MessagePasswordResetTicketExpired(string expirationHour, string expirationMinute)
	{
		return $"ç”³ã—è¨³ã”ã–ã„ã¾ã›ã‚“ã€‚ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ãƒªã‚»ãƒƒãƒˆã®ãƒªã‚¯ã‚¨ã‚¹ãƒˆã¯ã€ã”ä¾é ¼ã‹ã‚‰{expirationHour}æ™‚é–“{expirationMinute}åˆ†ã§æœŸé™åˆ‡ã‚Œã¨ãªã‚Šã¾ã™ã€‚å†åº¦ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ãƒªã‚»ãƒƒãƒˆã‚’ãƒªã‚¯ã‚¨ã‚¹ãƒˆã—ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForMessagePasswordResetTicketExpired()
	{
		return "ç”³ã—è¨³ã”ã–ã„ã¾ã›ã‚“ã€‚ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ãƒªã‚»ãƒƒãƒˆã®ãƒªã‚¯ã‚¨ã‚¹ãƒˆã¯ã€ã”ä¾é ¼ã‹ã‚‰{expirationHour}æ™‚é–“{expirationMinute}åˆ†ã§æœŸé™åˆ‡ã‚Œã¨ãªã‚Šã¾ã™ã€‚å†åº¦ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ãƒªã‚»ãƒƒãƒˆã‚’ãƒªã‚¯ã‚¨ã‚¹ãƒˆã—ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForMessagePasswordsDoNotMatch()
	{
		return "ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ãŒä¸€è‡´ã—ã¾ã›ã‚“";
	}

	protected override string _GetTemplateForMessageSamlUnauthenticated()
	{
		return "èªè¨¼ã‚’å®Œäº†ã™ã‚‹ã«ã¯Robloxã«ãƒ­ã‚°ã‚¤ãƒ³ã™ã‚‹å¿…è¦ãŒã‚ã‚Šã¾ã™ã€‚";
	}

	protected override string _GetTemplateForMessageUnknownError()
	{
		return "ä¸æ˜Žãªã‚¨ãƒ©ãƒ¼ãŒç™ºç”Ÿã—ã¾ã—ãŸ";
	}

	protected override string _GetTemplateForMessageUnknownSystemError()
	{
		return "ã‚·ã‚¹ãƒ†ãƒ ã‚¨ãƒ©ãƒ¼ãŒç™ºç”Ÿã—ã¾ã—ãŸã€‚ãƒ­ã‚°ã‚¤ãƒ³ç”»é¢ã«ãŠæˆ»ã‚Šãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForPlaceholderEmail()
	{
		return "ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹";
	}

	/// <summary>
	/// Key: "Placeholder.EnterCode"
	/// English String: "Enter Code ({codeLength}-digit)"
	/// </summary>
	public override string PlaceholderEnterCode(string codeLength)
	{
		return $"ã‚³ãƒ¼ãƒ‰ã‚’å…¥åŠ› ({codeLength}-æ¡)";
	}

	protected override string _GetTemplateForPlaceholderEnterCode()
	{
		return "ã‚³ãƒ¼ãƒ‰ã‚’å…¥åŠ› ({codeLength}-æ¡)";
	}

	protected override string _GetTemplateForPlaceholderPhoneNumber()
	{
		return "é›»è©±ç•ªå·";
	}

	protected override string _GetTemplateForResponsePasswordResetSuccess()
	{
		return "ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ã®ãƒªã‚»ãƒƒãƒˆã«æˆåŠŸã—ã¾ã—ãŸï¼ã‚‚ã†ä¸€åº¦ãƒ­ã‚°ã‚¤ãƒ³ã—ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForResponseSuccess()
	{
		return "æˆåŠŸ";
	}

	protected override string _GetTemplateForResponseUpdatePasswordFlooded()
	{
		return "è©¦è¡Œå›žæ•°ãŒå¤šã™ãŽã¾ã™ã€‚ã—ã°ã‚‰ãã—ã¦ã‹ã‚‰ã‚„ã‚Šç›´ã—ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForResponseUpdatePasswordIncorrect()
	{
		return "ç¾åœ¨ã®ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ãŒé–“é•ã£ã¦ã„ã¾ã™ã€‚ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ã¯å¤‰æ›´ã•ã‚Œã¾ã›ã‚“ã§ã—ãŸã€‚";
	}

	protected override string _GetTemplateForResponseUpdatePasswordInputMissing()
	{
		return "æ–°ã—ã„ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ã¨ç¢ºèªãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ã‚’å«ã‚€å¿…è¦ãŒã‚ã‚Šã¾ã™";
	}

	protected override string _GetTemplateForResponseUpdatePasswordMismatch()
	{
		return "æ–°ã—ã„ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ã¨ç¢ºèªãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ãŒä¸€è‡´ã—ã¦ã„ã‚‹å¿…è¦ãŒã‚ã‚Šã¾ã™";
	}
}


}
