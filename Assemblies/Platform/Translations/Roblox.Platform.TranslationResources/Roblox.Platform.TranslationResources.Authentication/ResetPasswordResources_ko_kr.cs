namespace Roblox.Platform.TranslationResources.Authentication {
    /// <summary>

/// This class overrides ResetPasswordResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ResetPasswordResources_ko_kr : ResetPasswordResources_en_us, IResetPasswordResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "ì·¨ì†Œ";

	/// <summary>
	/// Key: "Action.EmailToResetPassword"
	/// English String: "Use email to reset password"
	/// </summary>
	public override string ActionEmailToResetPassword => "ë¹„ë°€ë²ˆí˜¸ ìž¬ì„¤ì •í•˜ë ¤ë©´ ì´ë©”ì¼ì„ ì‚¬ìš©í•˜ì„¸ìš”";

	/// <summary>
	/// Key: "Action.EmailToRetriveUsername"
	/// English String: "Use email to retrieve username"
	/// </summary>
	public override string ActionEmailToRetriveUsername => "ì‚¬ìš©ìž ì´ë¦„ì„ ì°¾ìœ¼ë ¤ë©´ ì´ë©”ì¼ì„ ì‚¬ìš©í•˜ì„¸ìš”";

	/// <summary>
	/// Key: "Action.Ok"
	/// OK
	/// English String: "OK"
	/// </summary>
	public override string ActionOk => "í™•ì¸";

	/// <summary>
	/// Key: "Action.PhoneToResetPassword"
	/// English String: "Use phone number to reset password"
	/// </summary>
	public override string ActionPhoneToResetPassword => "ë¹„ë°€ë²ˆí˜¸ë¥¼ ìž¬ì„¤ì •í•˜ë ¤ë©´ ì „í™”ë²ˆí˜¸ë¥¼ ì‚¬ìš©í•˜ì„¸ìš”";

	/// <summary>
	/// Key: "Action.PhoneToRetriveUsername"
	/// English String: "Use phone number to retrieve username"
	/// </summary>
	public override string ActionPhoneToRetriveUsername => "ì‚¬ìš©ìž ì´ë¦„ì„ ì°¾ìœ¼ë ¤ë©´ ì „í™”ë²ˆí˜¸ë¥¼ ì‚¬ìš©í•˜ì„¸ìš”";

	/// <summary>
	/// Key: "Action.Verify"
	/// English String: "Verify"
	/// </summary>
	public override string ActionVerify => "ì¸ì¦";

	/// <summary>
	/// Key: "Description.EmailToResetPassword"
	/// English String: "Enter your email to reset your password."
	/// </summary>
	public override string DescriptionEmailToResetPassword => "ë¹„ë°€ë²ˆí˜¸ë¥¼ ìž¬ì„¤ì •í•˜ë ¤ë©´ ì´ë©”ì¼ì„ ìž…ë ¥í•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "Description.EmailToRetriveUsername"
	/// English String: "Enter your email to retrieve your username."
	/// </summary>
	public override string DescriptionEmailToRetriveUsername => "ì‚¬ìš©ìž ì´ë¦„ì„ ì°¾ìœ¼ë ¤ë©´ ì´ë©”ì¼ì„ ìž…ë ¥í•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "Description.PasswordChangeEmail.Subject"
	/// email subject to change password
	/// English String: "Roblox Password Reset"
	/// </summary>
	public override string DescriptionPasswordChangeEmailSubject => "Roblox ë¹„ë°€ë²ˆí˜¸ ìž¬ì„¤ì •";

	/// <summary>
	/// Key: "Description.PasswordResetEmail.Subject"
	/// Subject for password reset email
	/// English String: "Roblox Account Password Reset"
	/// </summary>
	public override string DescriptionPasswordResetEmailSubject => "Roblox ê³„ì • ë¹„ë°€ë²ˆí˜¸ ìž¬ì„¤ì •";

	/// <summary>
	/// Key: "Description.PhoneToResetPassword"
	/// English String: "Enter your phone number to reset your password."
	/// </summary>
	public override string DescriptionPhoneToResetPassword => "ë¹„ë°€ë²ˆí˜¸ë¥¼ ìž¬ì„¤ì •í•˜ë ¤ë©´ ì „í™”ë²ˆí˜¸ë¥¼ ìž…ë ¥í•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "Description.PhoneToRetriveUsername"
	/// English String: "Enter your phone number to retrieve your username."
	/// </summary>
	public override string DescriptionPhoneToRetriveUsername => "ì‚¬ìš©ìž ì´ë¦„ì„ ì°¾ìœ¼ë ¤ë©´ ì „í™”ë²ˆí˜¸ë¥¼ ìž…ë ¥í•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "Heading.VerifyCode"
	/// verify code heading
	/// English String: "Verify Code"
	/// </summary>
	public override string HeadingVerifyCode => "ì½”ë“œ ì¸ì¦";

	/// <summary>
	/// Key: "Heading.VerifyPhone"
	/// English String: "Verify Phone"
	/// </summary>
	public override string HeadingVerifyPhone => "ì „í™”ë²ˆí˜¸ ì¸ì¦";

	/// <summary>
	/// Key: "HeadingForgetPasswordOrUsername"
	/// English String: "Forgot Password or Username"
	/// </summary>
	public override string HeadingForgetPasswordOrUsername => "ë¹„ë°€ë²ˆí˜¸ ë˜ëŠ” ì‚¬ìš©ìž ì´ë¦„ ë¶„ì‹¤";

	/// <summary>
	/// Key: "Label.ActionButtonYes"
	/// button label
	/// English String: "Yes"
	/// </summary>
	public override string LabelActionButtonYes => "ì˜ˆ";

	/// <summary>
	/// Key: "Label.ForgetMyPassword"
	/// English String: "Forgot My Password"
	/// </summary>
	public override string LabelForgetMyPassword => "ë‚´ ë¹„ë°€ë²ˆí˜¸ë¥¼ ìžŠì—ˆìŠµë‹ˆë‹¤";

	/// <summary>
	/// Key: "Label.ForgetMyUsername"
	/// English String: "Forgot My Username"
	/// </summary>
	public override string LabelForgetMyUsername => "ë‚´ ì‚¬ìš©ìž ì´ë¦„ì„ ìžŠì—ˆìŠµë‹ˆë‹¤";

	/// <summary>
	/// Key: "Label.InvalidEmail"
	/// English String: "Invalid email"
	/// </summary>
	public override string LabelInvalidEmail => "ìœ íš¨í•˜ì§€ ì•Šì€ ì´ë©”ì¼";

	/// <summary>
	/// Key: "Label.InvalidPhoneNumber"
	/// English String: "Invalid phone number"
	/// </summary>
	public override string LabelInvalidPhoneNumber => "ìœ íš¨í•˜ì§€ ì•Šì€ ì „í™”ë²ˆí˜¸";

	/// <summary>
	/// Key: "Label.NeutralButtonOk"
	/// ok button label
	/// English String: "OK"
	/// </summary>
	public override string LabelNeutralButtonOk => "í™•ì¸";

	/// <summary>
	/// Key: "Label.Password"
	/// label
	/// English String: "Password"
	/// </summary>
	public override string LabelPassword => "ë¹„ë°€ë²ˆí˜¸";

	/// <summary>
	/// Key: "Label.ResendCode"
	/// English String: "Resend Code"
	/// </summary>
	public override string LabelResendCode => "ì½”ë“œ ìž¬ì „ì†¡";

	/// <summary>
	/// Key: "Label.Submit"
	/// English String: "Submit"
	/// </summary>
	public override string LabelSubmit => "ì œì¶œ";

	/// <summary>
	/// Key: "Label.ToolTip.WhoCanFindMeByPhone"
	/// English String: "This setting controls who can find you using the phone number you provided."
	/// </summary>
	public override string LabelToolTipWhoCanFindMeByPhone => "ìž…ë ¥í•˜ì‹  ì „í™”ë²ˆí˜¸ë¥¼ ì‚¬ìš©í•˜ì—¬ íšŒì›ë‹˜ì„ ì°¾ì„ ìˆ˜ ìžˆëŠ” ì‚¬ìš©ìžë¥¼ ì„¤ì •í•©ë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Label.Username"
	/// English String: "Username"
	/// </summary>
	public override string LabelUsername => "ì‚¬ìš©ìž ì´ë¦„";

	/// <summary>
	/// Key: "Label.WhoCanFindMeByPhone"
	/// English String: "Who can find me by my phone number?"
	/// </summary>
	public override string LabelWhoCanFindMeByPhone => "ëˆ„ê°€ ë‚´ ì „í™”ë²ˆí˜¸ë¡œ ë‚˜ë¥¼ ì°¾ì„ ìˆ˜ ìžˆë‚˜ìš”?";

	/// <summary>
	/// Key: "Message.DefaultError"
	/// English String: "An error occurred, try again later."
	/// </summary>
	public override string MessageDefaultError => "ì˜¤ë¥˜ê°€ ë°œìƒí–ˆì–´ìš”. ë‚˜ì¤‘ì— ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "Message.EmailForUsernameSuccessBody"
	/// success message
	/// English String: "An email with your username(s) has been sent to you if the email was previously saved on your account."
	/// </summary>
	public override string MessageEmailForUsernameSuccessBody => "ê³„ì •ì—ì„œ ì‚¬ì „ì— ì €ìž¥ëœ ì´ë©”ì¼ ì£¼ì†Œë¡œ ì‚¬ìš©ìž ì´ë¦„ì´ í¬í•¨ëœ ë©”ì¼ì´ ë°œì†¡ë˜ì—ˆì–´ìš”.";

	/// <summary>
	/// Key: "Message.EmailSuccessBody"
	/// English String: "An email with instructions has been sent to you if the email was previously saved on your account."
	/// </summary>
	public override string MessageEmailSuccessBody => "ê³„ì •ì—ì„œ ì‚¬ì „ì— ì €ìž¥ëœ ì´ë©”ì¼ ì£¼ì†Œë¡œ ì§€ì¹¨ì´ í¬í•¨ëœ ë©”ì¼ì´ ë°œì†¡ë˜ì—ˆì–´ìš”.";

	/// <summary>
	/// Key: "Message.EmailSuccessTitle"
	/// English String: "Email Sent"
	/// </summary>
	public override string MessageEmailSuccessTitle => "ì´ë©”ì¼ ì „ì†¡ ì™„ë£Œ";

	/// <summary>
	/// Key: "Message.EnterCode"
	/// English String: "A code was sent to your phone if it was previously verified on your account. Please enter it below"
	/// </summary>
	public override string MessageEnterCode => "ê³„ì •ì—ì„œ ì‚¬ì „ì— ì¸ì¦ëœ íœ´ëŒ€í°ìœ¼ë¡œ ì½”ë“œê°€ ì „ì†¡ë˜ì—ˆì–´ìš”. ì•„ëž˜ì— ì½”ë“œë¥¼ ìž…ë ¥í•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "Message.EnterCodeSentToEmail"
	/// Enter the code we just sent to your email.
	/// English String: "Enter the code we just sent to your email."
	/// </summary>
	public override string MessageEnterCodeSentToEmail => "ì´ë©”ì¼ë¡œ ë°©ê¸ˆ ë°œì†¡ëœ ì½”ë“œë¥¼ ìž…ë ¥í•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "Message.PhoneForUsernameSuccessBody"
	/// English String: "An SMS with your username(s) has been sent to you if the phone number was previously verified on your account."
	/// </summary>
	public override string MessagePhoneForUsernameSuccessBody => "ê³„ì •ì—ì„œ ì‚¬ì „ì— ì¸ì¦ëœ ì „í™”ë²ˆí˜¸ë¡œ ì‚¬ìš©ìž ì´ë¦„ì´ í¬í•¨ëœ SMSê°€ ë°œì†¡ë˜ì—ˆì–´ìš”.";

	/// <summary>
	/// Key: "Message.PhoneForUsernameSuccessTitle"
	/// English String: "SMS Sent"
	/// </summary>
	public override string MessagePhoneForUsernameSuccessTitle => "SMS ì „ì†¡ ì™„ë£Œ";

	/// <summary>
	/// Key: "MessageAccountDoesNotHaveAnEmail"
	/// English String: "There is no email linked to this account"
	/// </summary>
	public override string MessageAccountDoesNotHaveAnEmail => "ë³¸ ê³„ì •ì— ì—°ê²°ëœ ì´ë©”ì¼ì´ ì¡´ìž¬í•˜ì§€ ì•ŠìŠµë‹ˆë‹¤.";

	/// <summary>
	/// Key: "MessageAccountNotFoundByEmail"
	/// No account found. Please use a different email.
	/// English String: "No account found. Please use a different email."
	/// </summary>
	public override string MessageAccountNotFoundByEmail => "ê³„ì •ì„ ì°¾ì„ ìˆ˜ ì—†ìŠµë‹ˆë‹¤. ë‹¤ë¥¸ ì´ë©”ì¼ì„ ì‚¬ìš©í•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "MessageAccountNotFoundByPhone"
	/// No account found. Please use a different phone number.
	/// English String: "No account found. Please use a different phone number."
	/// </summary>
	public override string MessageAccountNotFoundByPhone => "ê³„ì •ì„ ì°¾ì„ ìˆ˜ ì—†ìŠµë‹ˆë‹¤. ë‹¤ë¥¸ ì „í™”ë²ˆí˜¸ë¥¼ ì‚¬ìš©í•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "MessageAccountRecoveryUnknownError"
	/// English String: "System error. Account could not be restored to this state."
	/// </summary>
	public override string MessageAccountRecoveryUnknownError => "ì‹œìŠ¤í…œ ì˜¤ë¥˜. ê³„ì •ì„ ë³¸ ìƒíƒœë¡œ ë³µêµ¬í•˜ì§€ ëª»í–ˆìŠµë‹ˆë‹¤.";

	/// <summary>
	/// Key: "MessageCaptchaError"
	/// English String: "We need to make sure you're not a robot!"
	/// </summary>
	public override string MessageCaptchaError => "ë¡œë´‡ì´ ì•„ë‹˜ì„ í™•ì¸í•´ì•¼ í•©ë‹ˆë‹¤!";

	/// <summary>
	/// Key: "MessageCaptchaFailError"
	/// English String: "The words you typed didn't match the picture. Please try again."
	/// </summary>
	public override string MessageCaptchaFailError => "ìž…ë ¥í•œ ë‹¨ì–´ê°€ ì‚¬ì§„ê³¼ ì¼ì¹˜í•˜ì§€ ì•ŠìŠµë‹ˆë‹¤. ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "MessageCredentialsError"
	/// English String: "Your username or password is incorrect. Please check them and try again."
	/// </summary>
	public override string MessageCredentialsError => "ì‚¬ìš©ìž ì´ë¦„ ë˜ëŠ” ë¹„ë°€ë²ˆí˜¸ê°€ ì¼ì¹˜í•˜ì§€ ì•ŠìŠµë‹ˆë‹¤. í™•ì¸ í›„ ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "MessageFloodCheckedError"
	/// English String: "Too many attempts. Please try again later."
	/// </summary>
	public override string MessageFloodCheckedError => "ì‹œë„ ê°€ëŠ¥ íšŸìˆ˜ë¥¼ ì´ˆê³¼í•˜ì˜€ìŠµë‹ˆë‹¤. ë‚˜ì¤‘ì— ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "MessageForgotPasswordFeatureDisabled"
	/// English String: "Feature temporarily disabled. Please try again later."
	/// </summary>
	public override string MessageForgotPasswordFeatureDisabled => "ì¼ì‹œì  ê¸°ëŠ¥ ë¹„í™œì„±í™”. ë‚˜ì¤‘ì— ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "MessageForgotPasswordSuccess"
	/// English String: "Check your email for login instructions"
	/// </summary>
	public override string MessageForgotPasswordSuccess => "ë¡œê·¸ì¸ ì•ˆë‚´ë¥¼ ìœ„í•´ ì´ë©”ì¼ì„ í™•ì¸í•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "MessageInvalidAccountStatus"
	/// English String: "Account status prevents resetting password"
	/// </summary>
	public override string MessageInvalidAccountStatus => "ë¹„ë°€ë²ˆí˜¸ ìž¬ì„¤ì •ì´ ë¶ˆê°€ëŠ¥í•œ ê³„ì • ìƒíƒœ";

	/// <summary>
	/// Key: "MessageInvalidPassword"
	/// English String: "Invalid password"
	/// </summary>
	public override string MessageInvalidPassword => "ìœ íš¨í•˜ì§€ ì•Šì€ ë¹„ë°€ë²ˆí˜¸";

	/// <summary>
	/// Key: "MessageInvalidTicket"
	/// English String: "We couldn't load this security ticket."
	/// </summary>
	public override string MessageInvalidTicket => "ë³´ì•ˆ í‹°ì¼“ì„ ë¶ˆëŸ¬ì˜¤ì§€ ëª»í–ˆìŠµë‹ˆë‹¤.";

	/// <summary>
	/// Key: "MessageInvalidUserNameOrEmail"
	/// English String: "Invalid username, or no email exists"
	/// </summary>
	public override string MessageInvalidUserNameOrEmail => "ìœ íš¨í•˜ì§€ ì•Šì€ ì‚¬ìš©ìž ì´ë¦„ ë˜ëŠ” ì¡´ìž¬í•˜ì§€ ì•ŠëŠ” ì´ë©”ì¼";

	/// <summary>
	/// Key: "MessageMobileResetPasswordSuccess"
	/// English String: "MobileResetPasswordSuccess"
	/// </summary>
	public override string MessageMobileResetPasswordSuccess => "MobileResetPasswordSuccess";

	/// <summary>
	/// Key: "MessageNoAccountsLinkedToEmail"
	/// English String: "There are no accounts linked to this email address"
	/// </summary>
	public override string MessageNoAccountsLinkedToEmail => "ë³¸ ì´ë©”ì¼ ì£¼ì†Œì— ì—°ê²°ëœ ê³„ì •ì´ ì¡´ìž¬í•˜ì§€ ì•ŠìŠµë‹ˆë‹¤.";

	/// <summary>
	/// Key: "MessageOldUsernameError"
	/// English String: "It looks like you are trying to log in with a username that has changed. Please log in with your new username."
	/// </summary>
	public override string MessageOldUsernameError => "ë³€ê²½ ì „ ì‚¬ìš©ìž ì´ë¦„ìœ¼ë¡œ ë¡œê·¸ì¸ì„ ì‹œë„í•˜ì…¨êµ°ìš”. ë³€ê²½ëœ ì‚¬ìš©ìž ì´ë¦„ìœ¼ë¡œ ë¡œê·¸ì¸í•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "MessagePasswordCannotBeUsed"
	/// English String: "Sorry, that password cannot be used."
	/// </summary>
	public override string MessagePasswordCannotBeUsed => "ì£„ì†¡í•©ë‹ˆë‹¤. ì´ ë¹„ë°€ë²ˆí˜¸ëŠ” ì‚¬ìš©í•  ìˆ˜ ì—†ìŠµë‹ˆë‹¤.";

	/// <summary>
	/// Key: "MessagePasswordsDoNotMatch"
	/// English String: "Passwords do not match"
	/// </summary>
	public override string MessagePasswordsDoNotMatch => "ë¹„ë°€ë²ˆí˜¸ê°€ ì¼ì¹˜í•˜ì§€ ì•ŠìŠµë‹ˆë‹¤";

	/// <summary>
	/// Key: "MessageSamlUnauthenticated"
	/// English String: "You must log in to Roblox to finish authenticating."
	/// </summary>
	public override string MessageSamlUnauthenticated => "ì¸ì¦ì„ ì™„ë£Œí•˜ë ¤ë©´ Robloxì— ë¡œê·¸ì¸í•´ì•¼ í•©ë‹ˆë‹¤.";

	/// <summary>
	/// Key: "MessageUnknownError"
	/// English String: "Unknown Error"
	/// </summary>
	public override string MessageUnknownError => "ì•Œ ìˆ˜ ì—†ëŠ” ì˜¤ë¥˜";

	/// <summary>
	/// Key: "MessageUnknownSystemError"
	/// English String: "System error. Please return to login screen."
	/// </summary>
	public override string MessageUnknownSystemError => "ì‹œìŠ¤í…œ ì˜¤ë¥˜. ë¡œê·¸ì¸ í™”ë©´ìœ¼ë¡œ ëŒì•„ê°€ì„¸ìš”.";

	/// <summary>
	/// Key: "Placeholder.Email"
	/// English String: "Email"
	/// </summary>
	public override string PlaceholderEmail => "ì´ë©”ì¼";

	/// <summary>
	/// Key: "Placeholder.PhoneNumber"
	/// English String: "Phone Number"
	/// </summary>
	public override string PlaceholderPhoneNumber => "ì „í™”ë²ˆí˜¸";

	/// <summary>
	/// Key: "Response.PasswordResetSuccess"
	/// Password reset success! Please login again.
	/// English String: "Password reset success! Please login again."
	/// </summary>
	public override string ResponsePasswordResetSuccess => "ë¹„ë°€ë²ˆí˜¸ ìž¬ì„¤ì • ì™„ë£Œ! ë‹¤ì‹œ ë¡œê·¸ì¸í•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "Response.Success"
	/// English String: "Success"
	/// </summary>
	public override string ResponseSuccess => "ì„±ê³µ";

	/// <summary>
	/// Key: "Response.UpdatePasswordFlooded"
	/// English String: "Too many attempts. Please try again later."
	/// </summary>
	public override string ResponseUpdatePasswordFlooded => "ì‹œë„ ê°€ëŠ¥ íšŸìˆ˜ë¥¼ ì´ˆê³¼í–ˆìŠµë‹ˆë‹¤. ë‚˜ì¤‘ì— ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "Response.UpdatePasswordIncorrect"
	/// English String: "Your current password is incorrect, the password was not changed."
	/// </summary>
	public override string ResponseUpdatePasswordIncorrect => "ìž…ë ¥í•˜ì‹  ë¹„ë°€ë²ˆí˜¸ê°€ ì¼ì¹˜í•˜ì§€ ì•Šì•„ ë¹„ë°€ë²ˆí˜¸ë¥¼ ë³€ê²½í•˜ì§€ ëª»í–ˆìŠµë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Response.UpdatePasswordInputMissing"
	/// English String: "Must include new password and confirm password"
	/// </summary>
	public override string ResponseUpdatePasswordInputMissing => "ìƒˆ ë¹„ë°€ë²ˆí˜¸ ë° ìž¬í™•ì¸ ë¹„ë°€ë²ˆí˜¸ë¥¼ ìž…ë ¥í•´ì•¼ í•©ë‹ˆë‹¤";

	/// <summary>
	/// Key: "Response.UpdatePasswordMismatch"
	/// English String: "Your new password and confirm password must match"
	/// </summary>
	public override string ResponseUpdatePasswordMismatch => "ìƒˆ ë¹„ë°€ë²ˆí˜¸ì™€ ìž¬í™•ì¸ ë¹„ë°€ë²ˆí˜¸ê°€ ì¼ì¹˜í•´ì•¼ í•©ë‹ˆë‹¤";

	public ResetPasswordResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "ì·¨ì†Œ";
	}

	protected override string _GetTemplateForActionEmailToResetPassword()
	{
		return "ë¹„ë°€ë²ˆí˜¸ ìž¬ì„¤ì •í•˜ë ¤ë©´ ì´ë©”ì¼ì„ ì‚¬ìš©í•˜ì„¸ìš”";
	}

	protected override string _GetTemplateForActionEmailToRetriveUsername()
	{
		return "ì‚¬ìš©ìž ì´ë¦„ì„ ì°¾ìœ¼ë ¤ë©´ ì´ë©”ì¼ì„ ì‚¬ìš©í•˜ì„¸ìš”";
	}

	protected override string _GetTemplateForActionOk()
	{
		return "í™•ì¸";
	}

	protected override string _GetTemplateForActionPhoneToResetPassword()
	{
		return "ë¹„ë°€ë²ˆí˜¸ë¥¼ ìž¬ì„¤ì •í•˜ë ¤ë©´ ì „í™”ë²ˆí˜¸ë¥¼ ì‚¬ìš©í•˜ì„¸ìš”";
	}

	protected override string _GetTemplateForActionPhoneToRetriveUsername()
	{
		return "ì‚¬ìš©ìž ì´ë¦„ì„ ì°¾ìœ¼ë ¤ë©´ ì „í™”ë²ˆí˜¸ë¥¼ ì‚¬ìš©í•˜ì„¸ìš”";
	}

	protected override string _GetTemplateForActionVerify()
	{
		return "ì¸ì¦";
	}

	/// <summary>
	/// Key: "Description.ChangePasswordEmail.HtmlBody1"
	/// email body for change password email
	/// English String: "We noticed that the password changed for your Roblox account: {userName}. If you didn't intend to change it, or you think someone else changed it by mistake, please click this link to undo the action:{lineBreak} {actionLink} {lineBreak}{lineBreak}If you are happy with your new Roblox password, you don't have to do anything! It's already set up. Please do not reply to this message. If you have any questions, please see the Roblox help page (https://www.roblox.com/help)."
	/// </summary>
	public override string DescriptionChangePasswordEmailHtmlBody1(string userName, string lineBreak, string actionLink)
	{
		return $"{userName} ë‹˜ì˜ Roblox ê³„ì • ë¹„ë°€ë²ˆí˜¸ê°€ ë³€ê²½ë˜ì—ˆìŠµë‹ˆë‹¤. ë³€ê²½ ì˜ë„ê°€ ì—†ìœ¼ì…¨ê±°ë‚˜ ë‹¤ë¥¸ ëˆ„êµ°ê°€ê°€ ì‹¤ìˆ˜ë¡œ ë³€ê²½í•œ ê²ƒì´ë¼ë©´ ì•„ëž˜ ë§í¬ë¥¼ í´ë¦­í•´ ë³€ê²½ì„ ì·¨ì†Œí•  ìˆ˜ ìžˆìŠµë‹ˆë‹¤:{lineBreak} {actionLink} {lineBreak}{lineBreak}ë³€ê²½ëœ ë¹„ë°€ë²ˆí˜¸ì— ë§Œì¡±í•˜ì‹ ë‹¤ë©´ ê·¸ëƒ¥ ë³€ê²½ëœ ìƒíƒœë¡œ ë‘ì‹œë©´ ë©ë‹ˆë‹¤! ë³¸ ë©”ì‹œì§€ì— íšŒì‹ í•˜ì§€ ë§ˆì„¸ìš”. ë¬¸ì˜ ì‚¬í•­ì´ ìžˆìœ¼ì‹  ê²½ìš° Roblox ë„ì›€ë§ íŽ˜ì´ì§€(https://www.roblox.com/help)ë¥¼ ì°¸ê³ í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForDescriptionChangePasswordEmailHtmlBody1()
	{
		return "{userName} ë‹˜ì˜ Roblox ê³„ì • ë¹„ë°€ë²ˆí˜¸ê°€ ë³€ê²½ë˜ì—ˆìŠµë‹ˆë‹¤. ë³€ê²½ ì˜ë„ê°€ ì—†ìœ¼ì…¨ê±°ë‚˜ ë‹¤ë¥¸ ëˆ„êµ°ê°€ê°€ ì‹¤ìˆ˜ë¡œ ë³€ê²½í•œ ê²ƒì´ë¼ë©´ ì•„ëž˜ ë§í¬ë¥¼ í´ë¦­í•´ ë³€ê²½ì„ ì·¨ì†Œí•  ìˆ˜ ìžˆìŠµë‹ˆë‹¤:{lineBreak} {actionLink} {lineBreak}{lineBreak}ë³€ê²½ëœ ë¹„ë°€ë²ˆí˜¸ì— ë§Œì¡±í•˜ì‹ ë‹¤ë©´ ê·¸ëƒ¥ ë³€ê²½ëœ ìƒíƒœë¡œ ë‘ì‹œë©´ ë©ë‹ˆë‹¤! ë³¸ ë©”ì‹œì§€ì— íšŒì‹ í•˜ì§€ ë§ˆì„¸ìš”. ë¬¸ì˜ ì‚¬í•­ì´ ìžˆìœ¼ì‹  ê²½ìš° Roblox ë„ì›€ë§ íŽ˜ì´ì§€(https://www.roblox.com/help)ë¥¼ ì°¸ê³ í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForDescriptionEmailToResetPassword()
	{
		return "ë¹„ë°€ë²ˆí˜¸ë¥¼ ìž¬ì„¤ì •í•˜ë ¤ë©´ ì´ë©”ì¼ì„ ìž…ë ¥í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForDescriptionEmailToRetriveUsername()
	{
		return "ì‚¬ìš©ìž ì´ë¦„ì„ ì°¾ìœ¼ë ¤ë©´ ì´ë©”ì¼ì„ ìž…ë ¥í•˜ì„¸ìš”.";
	}

	/// <summary>
	/// Key: "Description.PasswordChangeEmail.BodyPlainText"
	/// password reset plaintext email message
	/// English String: "We noticed that the password changed for your Roblox account: {userName}. If you didn't intend to change it, or you think someone else changed it by mistake, please click this link to undo the action:\n{urlWithTicket}\n\nIf you are happy with your new Roblox password, you don't have to do anything! It's already set up. Please do not reply to this message. If you have any questions, please see the Roblox help page (https://www.roblox.com/help)."
	/// </summary>
	public override string DescriptionPasswordChangeEmailBodyPlainText(string userName, string urlWithTicket)
	{
		return $"{userName} ë‹˜ì˜ Roblox ê³„ì • ë¹„ë°€ë²ˆí˜¸ê°€ ë³€ê²½ë˜ì—ˆìŠµë‹ˆë‹¤. ë³€ê²½ ì˜ë„ê°€ ì—†ìœ¼ì…¨ê±°ë‚˜ ë‹¤ë¥¸ ëˆ„êµ°ê°€ê°€ ì‹¤ìˆ˜ë¡œ ë³€ê²½í•œ ê²ƒì´ë¼ë©´ ì•„ëž˜ ë§í¬ë¥¼ í´ë¦­í•´ ë³€ê²½ì„ ì·¨ì†Œí•˜ì‹¤ ìˆ˜ ìžˆìŠµë‹ˆë‹¤.\n{urlWithTicket}\n\në³€ê²½ëœ ë¹„ë°€ë²ˆí˜¸ì— ë§Œì¡±í•˜ì‹ ë‹¤ë©´ ê·¸ëƒ¥ ë³€ê²½ëœ ìƒíƒœë¡œ ë‘ì‹œë©´ ë©ë‹ˆë‹¤! ë³¸ ë©”ì‹œì§€ì— íšŒì‹ í•˜ì§€ ë§ˆì„¸ìš”. ë¬¸ì˜ ì‚¬í•­ì´ ìžˆìœ¼ì‹  ê²½ìš° Roblox ë„ì›€ë§ íŽ˜ì´ì§€(https://www.roblox.com/help)ë¥¼ ì°¸ê³ í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForDescriptionPasswordChangeEmailBodyPlainText()
	{
		return "{userName} ë‹˜ì˜ Roblox ê³„ì • ë¹„ë°€ë²ˆí˜¸ê°€ ë³€ê²½ë˜ì—ˆìŠµë‹ˆë‹¤. ë³€ê²½ ì˜ë„ê°€ ì—†ìœ¼ì…¨ê±°ë‚˜ ë‹¤ë¥¸ ëˆ„êµ°ê°€ê°€ ì‹¤ìˆ˜ë¡œ ë³€ê²½í•œ ê²ƒì´ë¼ë©´ ì•„ëž˜ ë§í¬ë¥¼ í´ë¦­í•´ ë³€ê²½ì„ ì·¨ì†Œí•˜ì‹¤ ìˆ˜ ìžˆìŠµë‹ˆë‹¤.\n{urlWithTicket}\n\në³€ê²½ëœ ë¹„ë°€ë²ˆí˜¸ì— ë§Œì¡±í•˜ì‹ ë‹¤ë©´ ê·¸ëƒ¥ ë³€ê²½ëœ ìƒíƒœë¡œ ë‘ì‹œë©´ ë©ë‹ˆë‹¤! ë³¸ ë©”ì‹œì§€ì— íšŒì‹ í•˜ì§€ ë§ˆì„¸ìš”. ë¬¸ì˜ ì‚¬í•­ì´ ìžˆìœ¼ì‹  ê²½ìš° Roblox ë„ì›€ë§ íŽ˜ì´ì§€(https://www.roblox.com/help)ë¥¼ ì°¸ê³ í•˜ì„¸ìš”.";
	}

	/// <summary>
	/// Key: "Description.PasswordChangeEmail.From"
	/// name of the sender as shown in from field of the email
	/// English String: "\"Roblox Password Reset\" {fromEmailAddress}"
	/// </summary>
	public override string DescriptionPasswordChangeEmailFrom(string fromEmailAddress)
	{
		return $"\"Roblox ë¹„ë°€ë²ˆí˜¸ ìž¬ì„¤ì •\" {fromEmailAddress}";
	}

	protected override string _GetTemplateForDescriptionPasswordChangeEmailFrom()
	{
		return "\"Roblox ë¹„ë°€ë²ˆí˜¸ ìž¬ì„¤ì •\" {fromEmailAddress}";
	}

	protected override string _GetTemplateForDescriptionPasswordChangeEmailSubject()
	{
		return "Roblox ë¹„ë°€ë²ˆí˜¸ ìž¬ì„¤ì •";
	}

	/// <summary>
	/// Key: "Description.PasswordResetEmail.From"
	/// The "From" field for the password reset email
	/// English String: "{escapeLiteralStart}Roblox Password Reset{escapeLiteralEnd} {fromEmailAddress}"
	/// </summary>
	public override string DescriptionPasswordResetEmailFrom(string escapeLiteralStart, string escapeLiteralEnd, string fromEmailAddress)
	{
		return $"{escapeLiteralStart}Roblox ë¹„ë°€ë²ˆí˜¸ ìž¬ì„¤ì •{escapeLiteralEnd} {fromEmailAddress}";
	}

	protected override string _GetTemplateForDescriptionPasswordResetEmailFrom()
	{
		return "{escapeLiteralStart}Roblox ë¹„ë°€ë²ˆí˜¸ ìž¬ì„¤ì •{escapeLiteralEnd} {fromEmailAddress}";
	}

	/// <summary>
	/// Key: "Description.PasswordResetEmail.HtmlBody"
	/// This email is sent when a user requests a password reset.
	/// English String: "We have received a request to reset the password for your Roblox account: {emailOrUsername}{lineBreak}{lineBreak}If you submitted this request, please click the button below to proceed.{lineBreak}This button will be active for {passwordResetTicketHours} hours, {passwordResetTicketMinutes} minutes. If you do not wish to reset your password, please disregard this notice.{lineBreak}{lineBreak}{aTagWithStartHref}{resetPasswordUrl}{hrefEnd}{buttonStart}Reset Password{buttonEnd}{aTagEnd}"
	/// </summary>
	public override string DescriptionPasswordResetEmailHtmlBody(string emailOrUsername, string lineBreak, string passwordResetTicketHours, string passwordResetTicketMinutes, string aTagWithStartHref, string resetPasswordUrl, string hrefEnd, string buttonStart, string buttonEnd, string aTagEnd)
	{
		return $"Roblox ê³„ì •: {emailOrUsername}ì˜ ë¹„ë°€ë²ˆí˜¸ ìž¬ì„¤ì • ìš”ì²­ì„ ë°›ì•˜ìŠµë‹ˆë‹¤.{lineBreak}{lineBreak}ì´ ìš”ì²­ì„ ì œì¶œí•˜ì…¨ë‹¤ë©´, ì•„ëž˜ ë²„íŠ¼ì„ í´ë¦­í•´ ì§„í–‰í•˜ì„¸ìš”.{lineBreak}ë³¸ ë§í¬ëŠ” {passwordResetTicketHours}ì‹œê°„, {passwordResetTicketMinutes}ë¶„ ë™ì•ˆ í™œì„±í™”ë©ë‹ˆë‹¤. ë¹„ë°€ë²ˆí˜¸ë¥¼ ìž¬ì„¤ì •í•˜ê³  ì‹¶ì§€ ì•Šë‹¤ë©´, ë³¸ ì•Œë¦¼ì„ ë¬´ì‹œí•˜ì„¸ìš”.{lineBreak}{lineBreak}{aTagWithStartHref}{resetPasswordUrl}{hrefEnd}{buttonStart}ë¹„ë°€ë²ˆí˜¸ ìž¬ì„¤ì •{buttonEnd}{aTagEnd}";
	}

	protected override string _GetTemplateForDescriptionPasswordResetEmailHtmlBody()
	{
		return "Roblox ê³„ì •: {emailOrUsername}ì˜ ë¹„ë°€ë²ˆí˜¸ ìž¬ì„¤ì • ìš”ì²­ì„ ë°›ì•˜ìŠµë‹ˆë‹¤.{lineBreak}{lineBreak}ì´ ìš”ì²­ì„ ì œì¶œí•˜ì…¨ë‹¤ë©´, ì•„ëž˜ ë²„íŠ¼ì„ í´ë¦­í•´ ì§„í–‰í•˜ì„¸ìš”.{lineBreak}ë³¸ ë§í¬ëŠ” {passwordResetTicketHours}ì‹œê°„, {passwordResetTicketMinutes}ë¶„ ë™ì•ˆ í™œì„±í™”ë©ë‹ˆë‹¤. ë¹„ë°€ë²ˆí˜¸ë¥¼ ìž¬ì„¤ì •í•˜ê³  ì‹¶ì§€ ì•Šë‹¤ë©´, ë³¸ ì•Œë¦¼ì„ ë¬´ì‹œí•˜ì„¸ìš”.{lineBreak}{lineBreak}{aTagWithStartHref}{resetPasswordUrl}{hrefEnd}{buttonStart}ë¹„ë°€ë²ˆí˜¸ ìž¬ì„¤ì •{buttonEnd}{aTagEnd}";
	}

	/// <summary>
	/// Key: "Description.PasswordResetEmail.PlainBody"
	/// This email is sent when a user requests a password reset.
	/// English String: "We have received a request to reset the password for your Roblox account: {emailOrUsername}{lineBreak}{lineBreak}If you submitted this request, please click the link below or paste it into a web browser to proceed.{lineBreak}This link will be active for {passwordResetTicketHours} hours, {passwordResetTicketMinutes} minutes. If you do not wish to reset your password, please disregard this notice.{lineBreak}{lineBreak}{resetPasswordUrl}"
	/// </summary>
	public override string DescriptionPasswordResetEmailPlainBody(string emailOrUsername, string lineBreak, string passwordResetTicketHours, string passwordResetTicketMinutes, string resetPasswordUrl)
	{
		return $"Roblox ê³„ì •: {emailOrUsername}ì˜ ë¹„ë°€ë²ˆí˜¸ ìž¬ì„¤ì • ìš”ì²­ì„ ë°›ì•˜ìŠµë‹ˆë‹¤.{lineBreak}{lineBreak}ë³¸ ìš”ì²­ì„ ì œì¶œí•˜ì…¨ë‹¤ë©´, ìž¬ì„¤ì • ì§„í–‰ì„ ìœ„í•´ ì•„ëž˜ ë§í¬ë¥¼ í´ë¦­í•˜ê±°ë‚˜ ì•„ëž˜ ì£¼ì†Œë¥¼ ì›¹ë¸Œë¼ìš°ì €ì— ë¶™ì—¬ë„£ìœ¼ì„¸ìš”.{lineBreak}ë³¸ ë§í¬ëŠ” {passwordResetTicketHours}ì‹œê°„, {passwordResetTicketMinutes}ë¶„ ë™ì•ˆ í™œì„±í™”ë©ë‹ˆë‹¤. ë¹„ë°€ë²ˆí˜¸ë¥¼ ìž¬ì„¤ì •í•˜ê³  ì‹¶ì§€ ì•Šë‹¤ë©´, ë³¸ ì•Œë¦¼ì„ ë¬´ì‹œí•˜ì„¸ìš”.{lineBreak}{lineBreak}{resetPasswordUrl}";
	}

	protected override string _GetTemplateForDescriptionPasswordResetEmailPlainBody()
	{
		return "Roblox ê³„ì •: {emailOrUsername}ì˜ ë¹„ë°€ë²ˆí˜¸ ìž¬ì„¤ì • ìš”ì²­ì„ ë°›ì•˜ìŠµë‹ˆë‹¤.{lineBreak}{lineBreak}ë³¸ ìš”ì²­ì„ ì œì¶œí•˜ì…¨ë‹¤ë©´, ìž¬ì„¤ì • ì§„í–‰ì„ ìœ„í•´ ì•„ëž˜ ë§í¬ë¥¼ í´ë¦­í•˜ê±°ë‚˜ ì•„ëž˜ ì£¼ì†Œë¥¼ ì›¹ë¸Œë¼ìš°ì €ì— ë¶™ì—¬ë„£ìœ¼ì„¸ìš”.{lineBreak}ë³¸ ë§í¬ëŠ” {passwordResetTicketHours}ì‹œê°„, {passwordResetTicketMinutes}ë¶„ ë™ì•ˆ í™œì„±í™”ë©ë‹ˆë‹¤. ë¹„ë°€ë²ˆí˜¸ë¥¼ ìž¬ì„¤ì •í•˜ê³  ì‹¶ì§€ ì•Šë‹¤ë©´, ë³¸ ì•Œë¦¼ì„ ë¬´ì‹œí•˜ì„¸ìš”.{lineBreak}{lineBreak}{resetPasswordUrl}";
	}

	protected override string _GetTemplateForDescriptionPasswordResetEmailSubject()
	{
		return "Roblox ê³„ì • ë¹„ë°€ë²ˆí˜¸ ìž¬ì„¤ì •";
	}

	protected override string _GetTemplateForDescriptionPhoneToResetPassword()
	{
		return "ë¹„ë°€ë²ˆí˜¸ë¥¼ ìž¬ì„¤ì •í•˜ë ¤ë©´ ì „í™”ë²ˆí˜¸ë¥¼ ìž…ë ¥í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForDescriptionPhoneToRetriveUsername()
	{
		return "ì‚¬ìš©ìž ì´ë¦„ì„ ì°¾ìœ¼ë ¤ë©´ ì „í™”ë²ˆí˜¸ë¥¼ ìž…ë ¥í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForHeadingVerifyCode()
	{
		return "ì½”ë“œ ì¸ì¦";
	}

	protected override string _GetTemplateForHeadingVerifyPhone()
	{
		return "ì „í™”ë²ˆí˜¸ ì¸ì¦";
	}

	protected override string _GetTemplateForHeadingForgetPasswordOrUsername()
	{
		return "ë¹„ë°€ë²ˆí˜¸ ë˜ëŠ” ì‚¬ìš©ìž ì´ë¦„ ë¶„ì‹¤";
	}

	protected override string _GetTemplateForLabelActionButtonYes()
	{
		return "ì˜ˆ";
	}

	protected override string _GetTemplateForLabelForgetMyPassword()
	{
		return "ë‚´ ë¹„ë°€ë²ˆí˜¸ë¥¼ ìžŠì—ˆìŠµë‹ˆë‹¤";
	}

	protected override string _GetTemplateForLabelForgetMyUsername()
	{
		return "ë‚´ ì‚¬ìš©ìž ì´ë¦„ì„ ìžŠì—ˆìŠµë‹ˆë‹¤";
	}

	protected override string _GetTemplateForLabelInvalidEmail()
	{
		return "ìœ íš¨í•˜ì§€ ì•Šì€ ì´ë©”ì¼";
	}

	protected override string _GetTemplateForLabelInvalidPhoneNumber()
	{
		return "ìœ íš¨í•˜ì§€ ì•Šì€ ì „í™”ë²ˆí˜¸";
	}

	protected override string _GetTemplateForLabelNeutralButtonOk()
	{
		return "í™•ì¸";
	}

	protected override string _GetTemplateForLabelPassword()
	{
		return "ë¹„ë°€ë²ˆí˜¸";
	}

	protected override string _GetTemplateForLabelResendCode()
	{
		return "ì½”ë“œ ìž¬ì „ì†¡";
	}

	protected override string _GetTemplateForLabelSubmit()
	{
		return "ì œì¶œ";
	}

	protected override string _GetTemplateForLabelToolTipWhoCanFindMeByPhone()
	{
		return "ìž…ë ¥í•˜ì‹  ì „í™”ë²ˆí˜¸ë¥¼ ì‚¬ìš©í•˜ì—¬ íšŒì›ë‹˜ì„ ì°¾ì„ ìˆ˜ ìžˆëŠ” ì‚¬ìš©ìžë¥¼ ì„¤ì •í•©ë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForLabelUsername()
	{
		return "ì‚¬ìš©ìž ì´ë¦„";
	}

	protected override string _GetTemplateForLabelWhoCanFindMeByPhone()
	{
		return "ëˆ„ê°€ ë‚´ ì „í™”ë²ˆí˜¸ë¡œ ë‚˜ë¥¼ ì°¾ì„ ìˆ˜ ìžˆë‚˜ìš”?";
	}

	/// <summary>
	/// Key: "Message.CantSendEmailWarning"
	/// English String: "If you did not give us a {styleStart}real email address{styleEnd} when you created your account, we cannot send you an email."
	/// </summary>
	public override string MessageCantSendEmailWarning(string styleStart, string styleEnd)
	{
		return $"ê³„ì •ì„ ë§Œë“¤ì—ˆì„ ë•Œ {styleStart}ì‹¤ì œ ì´ë©”ì¼ ì£¼ì†Œ{styleEnd}ë¥¼ ì œê³µí•˜ì§€ ì•Šì•˜ë‹¤ë©´ ì´ë©”ì¼ì„ ë³´ë‚¼ ìˆ˜ ì—†ìŠµë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForMessageCantSendEmailWarning()
	{
		return "ê³„ì •ì„ ë§Œë“¤ì—ˆì„ ë•Œ {styleStart}ì‹¤ì œ ì´ë©”ì¼ ì£¼ì†Œ{styleEnd}ë¥¼ ì œê³µí•˜ì§€ ì•Šì•˜ë‹¤ë©´ ì´ë©”ì¼ì„ ë³´ë‚¼ ìˆ˜ ì—†ìŠµë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForMessageDefaultError()
	{
		return "ì˜¤ë¥˜ê°€ ë°œìƒí–ˆì–´ìš”. ë‚˜ì¤‘ì— ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForMessageEmailForUsernameSuccessBody()
	{
		return "ê³„ì •ì—ì„œ ì‚¬ì „ì— ì €ìž¥ëœ ì´ë©”ì¼ ì£¼ì†Œë¡œ ì‚¬ìš©ìž ì´ë¦„ì´ í¬í•¨ëœ ë©”ì¼ì´ ë°œì†¡ë˜ì—ˆì–´ìš”.";
	}

	protected override string _GetTemplateForMessageEmailSuccessBody()
	{
		return "ê³„ì •ì—ì„œ ì‚¬ì „ì— ì €ìž¥ëœ ì´ë©”ì¼ ì£¼ì†Œë¡œ ì§€ì¹¨ì´ í¬í•¨ëœ ë©”ì¼ì´ ë°œì†¡ë˜ì—ˆì–´ìš”.";
	}

	protected override string _GetTemplateForMessageEmailSuccessTitle()
	{
		return "ì´ë©”ì¼ ì „ì†¡ ì™„ë£Œ";
	}

	protected override string _GetTemplateForMessageEnterCode()
	{
		return "ê³„ì •ì—ì„œ ì‚¬ì „ì— ì¸ì¦ëœ íœ´ëŒ€í°ìœ¼ë¡œ ì½”ë“œê°€ ì „ì†¡ë˜ì—ˆì–´ìš”. ì•„ëž˜ì— ì½”ë“œë¥¼ ìž…ë ¥í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForMessageEnterCodeSentToEmail()
	{
		return "ì´ë©”ì¼ë¡œ ë°©ê¸ˆ ë°œì†¡ëœ ì½”ë“œë¥¼ ìž…ë ¥í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForMessagePhoneForUsernameSuccessBody()
	{
		return "ê³„ì •ì—ì„œ ì‚¬ì „ì— ì¸ì¦ëœ ì „í™”ë²ˆí˜¸ë¡œ ì‚¬ìš©ìž ì´ë¦„ì´ í¬í•¨ëœ SMSê°€ ë°œì†¡ë˜ì—ˆì–´ìš”.";
	}

	protected override string _GetTemplateForMessagePhoneForUsernameSuccessTitle()
	{
		return "SMS ì „ì†¡ ì™„ë£Œ";
	}

	protected override string _GetTemplateForMessageAccountDoesNotHaveAnEmail()
	{
		return "ë³¸ ê³„ì •ì— ì—°ê²°ëœ ì´ë©”ì¼ì´ ì¡´ìž¬í•˜ì§€ ì•ŠìŠµë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForMessageAccountNotFoundByEmail()
	{
		return "ê³„ì •ì„ ì°¾ì„ ìˆ˜ ì—†ìŠµë‹ˆë‹¤. ë‹¤ë¥¸ ì´ë©”ì¼ì„ ì‚¬ìš©í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForMessageAccountNotFoundByPhone()
	{
		return "ê³„ì •ì„ ì°¾ì„ ìˆ˜ ì—†ìŠµë‹ˆë‹¤. ë‹¤ë¥¸ ì „í™”ë²ˆí˜¸ë¥¼ ì‚¬ìš©í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForMessageAccountRecoveryUnknownError()
	{
		return "ì‹œìŠ¤í…œ ì˜¤ë¥˜. ê³„ì •ì„ ë³¸ ìƒíƒœë¡œ ë³µêµ¬í•˜ì§€ ëª»í–ˆìŠµë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForMessageCaptchaError()
	{
		return "ë¡œë´‡ì´ ì•„ë‹˜ì„ í™•ì¸í•´ì•¼ í•©ë‹ˆë‹¤!";
	}

	protected override string _GetTemplateForMessageCaptchaFailError()
	{
		return "ìž…ë ¥í•œ ë‹¨ì–´ê°€ ì‚¬ì§„ê³¼ ì¼ì¹˜í•˜ì§€ ì•ŠìŠµë‹ˆë‹¤. ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForMessageCredentialsError()
	{
		return "ì‚¬ìš©ìž ì´ë¦„ ë˜ëŠ” ë¹„ë°€ë²ˆí˜¸ê°€ ì¼ì¹˜í•˜ì§€ ì•ŠìŠµë‹ˆë‹¤. í™•ì¸ í›„ ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForMessageFloodCheckedError()
	{
		return "ì‹œë„ ê°€ëŠ¥ íšŸìˆ˜ë¥¼ ì´ˆê³¼í•˜ì˜€ìŠµë‹ˆë‹¤. ë‚˜ì¤‘ì— ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForMessageForgotPasswordFeatureDisabled()
	{
		return "ì¼ì‹œì  ê¸°ëŠ¥ ë¹„í™œì„±í™”. ë‚˜ì¤‘ì— ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForMessageForgotPasswordSuccess()
	{
		return "ë¡œê·¸ì¸ ì•ˆë‚´ë¥¼ ìœ„í•´ ì´ë©”ì¼ì„ í™•ì¸í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForMessageInvalidAccountStatus()
	{
		return "ë¹„ë°€ë²ˆí˜¸ ìž¬ì„¤ì •ì´ ë¶ˆê°€ëŠ¥í•œ ê³„ì • ìƒíƒœ";
	}

	protected override string _GetTemplateForMessageInvalidPassword()
	{
		return "ìœ íš¨í•˜ì§€ ì•Šì€ ë¹„ë°€ë²ˆí˜¸";
	}

	protected override string _GetTemplateForMessageInvalidTicket()
	{
		return "ë³´ì•ˆ í‹°ì¼“ì„ ë¶ˆëŸ¬ì˜¤ì§€ ëª»í–ˆìŠµë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForMessageInvalidUserNameOrEmail()
	{
		return "ìœ íš¨í•˜ì§€ ì•Šì€ ì‚¬ìš©ìž ì´ë¦„ ë˜ëŠ” ì¡´ìž¬í•˜ì§€ ì•ŠëŠ” ì´ë©”ì¼";
	}

	protected override string _GetTemplateForMessageMobileResetPasswordSuccess()
	{
		return "MobileResetPasswordSuccess";
	}

	protected override string _GetTemplateForMessageNoAccountsLinkedToEmail()
	{
		return "ë³¸ ì´ë©”ì¼ ì£¼ì†Œì— ì—°ê²°ëœ ê³„ì •ì´ ì¡´ìž¬í•˜ì§€ ì•ŠìŠµë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForMessageOldUsernameError()
	{
		return "ë³€ê²½ ì „ ì‚¬ìš©ìž ì´ë¦„ìœ¼ë¡œ ë¡œê·¸ì¸ì„ ì‹œë„í•˜ì…¨êµ°ìš”. ë³€ê²½ëœ ì‚¬ìš©ìž ì´ë¦„ìœ¼ë¡œ ë¡œê·¸ì¸í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForMessagePasswordCannotBeUsed()
	{
		return "ì£„ì†¡í•©ë‹ˆë‹¤. ì´ ë¹„ë°€ë²ˆí˜¸ëŠ” ì‚¬ìš©í•  ìˆ˜ ì—†ìŠµë‹ˆë‹¤.";
	}

	/// <summary>
	/// Key: "MessagePasswordResetTicketExpired"
	/// English String: "Sorry, password reset requests expire {expirationHour} hours, {expirationMinute} minutes after issuance. Try requesting another password reset ticket again."
	/// </summary>
	public override string MessagePasswordResetTicketExpired(string expirationHour, string expirationMinute)
	{
		return $"ì£„ì†¡í•©ë‹ˆë‹¤. ë¹„ë°€ë²ˆí˜¸ ìž¬ì„¤ì • ìš”ì²­ì€ ë°œê¸‰ìœ¼ë¡œë¶€í„° {expirationHour}ì‹œê°„, {expirationMinute}ë¶„ í›„ì— ë§Œë£Œë©ë‹ˆë‹¤. ë¹„ë°€ë²ˆí˜¸ ìž¬ì„¤ì • í‹°ì¼“ì„ ë‹¤ì‹œ ìš”ì²­í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForMessagePasswordResetTicketExpired()
	{
		return "ì£„ì†¡í•©ë‹ˆë‹¤. ë¹„ë°€ë²ˆí˜¸ ìž¬ì„¤ì • ìš”ì²­ì€ ë°œê¸‰ìœ¼ë¡œë¶€í„° {expirationHour}ì‹œê°„, {expirationMinute}ë¶„ í›„ì— ë§Œë£Œë©ë‹ˆë‹¤. ë¹„ë°€ë²ˆí˜¸ ìž¬ì„¤ì • í‹°ì¼“ì„ ë‹¤ì‹œ ìš”ì²­í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForMessagePasswordsDoNotMatch()
	{
		return "ë¹„ë°€ë²ˆí˜¸ê°€ ì¼ì¹˜í•˜ì§€ ì•ŠìŠµë‹ˆë‹¤";
	}

	protected override string _GetTemplateForMessageSamlUnauthenticated()
	{
		return "ì¸ì¦ì„ ì™„ë£Œí•˜ë ¤ë©´ Robloxì— ë¡œê·¸ì¸í•´ì•¼ í•©ë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForMessageUnknownError()
	{
		return "ì•Œ ìˆ˜ ì—†ëŠ” ì˜¤ë¥˜";
	}

	protected override string _GetTemplateForMessageUnknownSystemError()
	{
		return "ì‹œìŠ¤í…œ ì˜¤ë¥˜. ë¡œê·¸ì¸ í™”ë©´ìœ¼ë¡œ ëŒì•„ê°€ì„¸ìš”.";
	}

	protected override string _GetTemplateForPlaceholderEmail()
	{
		return "ì´ë©”ì¼";
	}

	/// <summary>
	/// Key: "Placeholder.EnterCode"
	/// English String: "Enter Code ({codeLength}-digit)"
	/// </summary>
	public override string PlaceholderEnterCode(string codeLength)
	{
		return $"ì½”ë“œ ìž…ë ¥ ({codeLength}ìžë¦¬)";
	}

	protected override string _GetTemplateForPlaceholderEnterCode()
	{
		return "ì½”ë“œ ìž…ë ¥ ({codeLength}ìžë¦¬)";
	}

	protected override string _GetTemplateForPlaceholderPhoneNumber()
	{
		return "ì „í™”ë²ˆí˜¸";
	}

	protected override string _GetTemplateForResponsePasswordResetSuccess()
	{
		return "ë¹„ë°€ë²ˆí˜¸ ìž¬ì„¤ì • ì™„ë£Œ! ë‹¤ì‹œ ë¡œê·¸ì¸í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForResponseSuccess()
	{
		return "ì„±ê³µ";
	}

	protected override string _GetTemplateForResponseUpdatePasswordFlooded()
	{
		return "ì‹œë„ ê°€ëŠ¥ íšŸìˆ˜ë¥¼ ì´ˆê³¼í–ˆìŠµë‹ˆë‹¤. ë‚˜ì¤‘ì— ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForResponseUpdatePasswordIncorrect()
	{
		return "ìž…ë ¥í•˜ì‹  ë¹„ë°€ë²ˆí˜¸ê°€ ì¼ì¹˜í•˜ì§€ ì•Šì•„ ë¹„ë°€ë²ˆí˜¸ë¥¼ ë³€ê²½í•˜ì§€ ëª»í–ˆìŠµë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForResponseUpdatePasswordInputMissing()
	{
		return "ìƒˆ ë¹„ë°€ë²ˆí˜¸ ë° ìž¬í™•ì¸ ë¹„ë°€ë²ˆí˜¸ë¥¼ ìž…ë ¥í•´ì•¼ í•©ë‹ˆë‹¤";
	}

	protected override string _GetTemplateForResponseUpdatePasswordMismatch()
	{
		return "ìƒˆ ë¹„ë°€ë²ˆí˜¸ì™€ ìž¬í™•ì¸ ë¹„ë°€ë²ˆí˜¸ê°€ ì¼ì¹˜í•´ì•¼ í•©ë‹ˆë‹¤";
	}
}


}
