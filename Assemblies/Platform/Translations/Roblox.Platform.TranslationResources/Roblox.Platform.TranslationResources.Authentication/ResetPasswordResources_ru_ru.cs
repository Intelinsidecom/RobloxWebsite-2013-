namespace Roblox.Platform.TranslationResources.Authentication {
    /// <summary>

/// This class overrides ResetPasswordResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ResetPasswordResources_ru_ru : ResetPasswordResources_en_us, IResetPasswordResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "ÐžÑ‚Ð¼ÐµÐ½Ð°";

	/// <summary>
	/// Key: "Action.EmailToResetPassword"
	/// English String: "Use email to reset password"
	/// </summary>
	public override string ActionEmailToResetPassword => "Ð¡Ð±Ñ€Ð¾ÑÐ¸Ñ‚ÑŒ Ð¿Ð°Ñ€Ð¾Ð»ÑŒ Ñ Ð¿Ð¾Ð¼Ð¾Ñ‰ÑŒÑŽ ÑÐ». Ð¿Ð¾Ñ‡Ñ‚Ñ‹";

	/// <summary>
	/// Key: "Action.EmailToRetriveUsername"
	/// English String: "Use email to retrieve username"
	/// </summary>
	public override string ActionEmailToRetriveUsername => "Ð’Ð¾ÑÑÑ‚Ð°Ð½Ð¾Ð²Ð¸Ñ‚ÑŒ Ð¸Ð¼Ñ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ Ñ Ð¿Ð¾Ð¼Ð¾Ñ‰ÑŒÑŽ ÑÐ». Ð¿Ð¾Ñ‡Ñ‚Ñ‹";

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
	public override string ActionPhoneToResetPassword => "Ð¡Ð±Ñ€Ð¾ÑÐ¸Ñ‚ÑŒ Ð¿Ð°Ñ€Ð¾Ð»ÑŒ Ñ Ð¿Ð¾Ð¼Ð¾Ñ‰ÑŒÑŽ Ñ‚ÐµÐ»ÐµÑ„Ð¾Ð½Ð°";

	/// <summary>
	/// Key: "Action.PhoneToRetriveUsername"
	/// English String: "Use phone number to retrieve username"
	/// </summary>
	public override string ActionPhoneToRetriveUsername => "Ð’Ð¾ÑÑÑ‚Ð°Ð½Ð¾Ð²Ð¸Ñ‚ÑŒ Ð¸Ð¼Ñ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ Ñ Ð¿Ð¾Ð¼Ð¾Ñ‰ÑŒÑŽ Ñ‚ÐµÐ»ÐµÑ„Ð¾Ð½Ð°";

	/// <summary>
	/// Key: "Action.Verify"
	/// English String: "Verify"
	/// </summary>
	public override string ActionVerify => "ÐŸÐ¾Ð´Ñ‚Ð²ÐµÑ€Ð´Ð¸Ñ‚ÑŒ";

	/// <summary>
	/// Key: "Description.EmailToResetPassword"
	/// English String: "Enter your email to reset your password."
	/// </summary>
	public override string DescriptionEmailToResetPassword => "Ð’Ð²ÐµÐ´Ð¸Ñ‚Ðµ Ð°Ð´Ñ€ÐµÑ ÑÐ». Ð¿Ð¾Ñ‡Ñ‚Ñ‹, Ñ‡Ñ‚Ð¾Ð±Ñ‹ ÑÐ±Ñ€Ð¾ÑÐ¸Ñ‚ÑŒ Ð¿Ð°Ñ€Ð¾Ð»ÑŒ.";

	/// <summary>
	/// Key: "Description.EmailToRetriveUsername"
	/// English String: "Enter your email to retrieve your username."
	/// </summary>
	public override string DescriptionEmailToRetriveUsername => "Ð’Ð²ÐµÐ´Ð¸Ñ‚Ðµ Ð°Ð´Ñ€ÐµÑ ÑÐ». Ð¿Ð¾Ñ‡Ñ‚Ñ‹, Ñ‡Ñ‚Ð¾Ð±Ñ‹ Ð²Ð¾ÑÑÑ‚Ð°Ð½Ð¾Ð²Ð¸Ñ‚ÑŒ ÑÐ²Ð¾Ðµ Ð¸Ð¼Ñ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ.";

	/// <summary>
	/// Key: "Description.PasswordChangeEmail.Subject"
	/// email subject to change password
	/// English String: "Roblox Password Reset"
	/// </summary>
	public override string DescriptionPasswordChangeEmailSubject => "Ð¡Ð±Ñ€Ð¾Ñ Ð¿Ð°Ñ€Ð¾Ð»Ñ Roblox";

	/// <summary>
	/// Key: "Description.PasswordResetEmail.Subject"
	/// Subject for password reset email
	/// English String: "Roblox Account Password Reset"
	/// </summary>
	public override string DescriptionPasswordResetEmailSubject => "Ð˜Ð·Ð¼ÐµÐ½ÐµÐ½Ð¸Ðµ Ð¿Ð°Ñ€Ð¾Ð»Ñ ÑƒÑ‡ÐµÑ‚Ð½Ð¾Ð¹ Ð·Ð°Ð¿Ð¸ÑÐ¸ Roblox";

	/// <summary>
	/// Key: "Description.PhoneToResetPassword"
	/// English String: "Enter your phone number to reset your password."
	/// </summary>
	public override string DescriptionPhoneToResetPassword => "Ð’Ð²ÐµÐ´Ð¸Ñ‚Ðµ Ð½Ð¾Ð¼ÐµÑ€ Ñ‚ÐµÐ»ÐµÑ„Ð¾Ð½Ð°, Ñ‡Ñ‚Ð¾Ð±Ñ‹ ÑÐ±Ñ€Ð¾ÑÐ¸Ñ‚ÑŒ Ð¿Ð°Ñ€Ð¾Ð»ÑŒ.";

	/// <summary>
	/// Key: "Description.PhoneToRetriveUsername"
	/// English String: "Enter your phone number to retrieve your username."
	/// </summary>
	public override string DescriptionPhoneToRetriveUsername => "Ð’Ð²ÐµÐ´Ð¸Ñ‚Ðµ Ð½Ð¾Ð¼ÐµÑ€ Ñ‚ÐµÐ»ÐµÑ„Ð¾Ð½Ð°, Ñ‡Ñ‚Ð¾Ð±Ñ‹ Ð²Ð¾ÑÑÑ‚Ð°Ð½Ð¾Ð²Ð¸Ñ‚ÑŒ ÑÐ²Ð¾Ðµ Ð¸Ð¼Ñ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ.";

	/// <summary>
	/// Key: "Heading.VerifyCode"
	/// verify code heading
	/// English String: "Verify Code"
	/// </summary>
	public override string HeadingVerifyCode => "ÐŸÐ¾Ð´Ñ‚Ð²ÐµÑ€Ð´Ð¸Ñ‚ÑŒ ÐºÐ¾Ð´";

	/// <summary>
	/// Key: "Heading.VerifyPhone"
	/// English String: "Verify Phone"
	/// </summary>
	public override string HeadingVerifyPhone => "ÐŸÑ€Ð¾Ð²ÐµÑ€ÐºÐ° Ñ‚ÐµÐ»ÐµÑ„Ð¾Ð½Ð°";

	/// <summary>
	/// Key: "HeadingForgetPasswordOrUsername"
	/// English String: "Forgot Password or Username"
	/// </summary>
	public override string HeadingForgetPasswordOrUsername => "Ð—Ð°Ð±Ñ‹Ñ‚ Ð¿Ð°Ñ€Ð¾Ð»ÑŒ Ð¸Ð»Ð¸ Ð¸Ð¼Ñ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ";

	/// <summary>
	/// Key: "Label.ActionButtonYes"
	/// button label
	/// English String: "Yes"
	/// </summary>
	public override string LabelActionButtonYes => "Ð”Ð°";

	/// <summary>
	/// Key: "Label.ForgetMyPassword"
	/// English String: "Forgot My Password"
	/// </summary>
	public override string LabelForgetMyPassword => "ÐŸÐ°Ñ€Ð¾Ð»ÑŒ Ð·Ð°Ð±Ñ‹Ñ‚";

	/// <summary>
	/// Key: "Label.ForgetMyUsername"
	/// English String: "Forgot My Username"
	/// </summary>
	public override string LabelForgetMyUsername => "Ð˜Ð¼Ñ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ Ð·Ð°Ð±Ñ‹Ñ‚Ð¾";

	/// <summary>
	/// Key: "Label.InvalidEmail"
	/// English String: "Invalid email"
	/// </summary>
	public override string LabelInvalidEmail => "ÐÐµÐ´Ð¾Ð¿ÑƒÑÑ‚Ð¸Ð¼Ñ‹Ð¹ Ð°Ð´Ñ€ÐµÑ ÑÐ». Ð¿Ð¾Ñ‡Ñ‚Ñ‹";

	/// <summary>
	/// Key: "Label.InvalidPhoneNumber"
	/// English String: "Invalid phone number"
	/// </summary>
	public override string LabelInvalidPhoneNumber => "ÐÐµÐ´Ð¾Ð¿ÑƒÑÑ‚Ð¸Ð¼Ñ‹Ð¹ Ð½Ð¾Ð¼ÐµÑ€ Ñ‚ÐµÐ»ÐµÑ„Ð¾Ð½Ð°";

	/// <summary>
	/// Key: "Label.NeutralButtonOk"
	/// ok button label
	/// English String: "OK"
	/// </summary>
	public override string LabelNeutralButtonOk => "ÐžÐš";

	/// <summary>
	/// Key: "Label.Password"
	/// label
	/// English String: "Password"
	/// </summary>
	public override string LabelPassword => "ÐŸÐ°Ñ€Ð¾Ð»ÑŒ";

	/// <summary>
	/// Key: "Label.ResendCode"
	/// English String: "Resend Code"
	/// </summary>
	public override string LabelResendCode => "ÐžÑ‚Ð¿Ñ€Ð°Ð²Ð¸Ñ‚ÑŒ ÐºÐ¾Ð´ Ð·Ð°Ð½Ð¾Ð²Ð¾";

	/// <summary>
	/// Key: "Label.Submit"
	/// English String: "Submit"
	/// </summary>
	public override string LabelSubmit => "ÐžÑ‚Ð¿Ñ€Ð°Ð²Ð¸Ñ‚ÑŒ";

	/// <summary>
	/// Key: "Label.ToolTip.WhoCanFindMeByPhone"
	/// English String: "This setting controls who can find you using the phone number you provided."
	/// </summary>
	public override string LabelToolTipWhoCanFindMeByPhone => "Ð­Ñ‚Ð° Ð½Ð°ÑÑ‚Ñ€Ð¾Ð¹ÐºÐ° Ð¿Ð¾Ð·Ð²Ð¾Ð»ÑÐµÑ‚ ÑƒÐºÐ°Ð·Ð°Ñ‚ÑŒ, ÐºÑ‚Ð¾ Ð¼Ð¾Ð¶ÐµÑ‚ Ð½Ð°Ð¹Ñ‚Ð¸ Ð²Ð°Ñ Ð¿Ð¾ Ð½Ð¾Ð¼ÐµÑ€Ñƒ Ð²Ð°ÑˆÐµÐ³Ð¾ Ñ‚ÐµÐ»ÐµÑ„Ð¾Ð½Ð°.";

	/// <summary>
	/// Key: "Label.Username"
	/// English String: "Username"
	/// </summary>
	public override string LabelUsername => "Ð˜Ð¼Ñ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ";

	/// <summary>
	/// Key: "Label.WhoCanFindMeByPhone"
	/// English String: "Who can find me by my phone number?"
	/// </summary>
	public override string LabelWhoCanFindMeByPhone => "ÐšÑ‚Ð¾ Ð¼Ð¾Ð¶ÐµÑ‚ Ð½Ð°Ð¹Ñ‚Ð¸ Ð¼ÐµÐ½Ñ Ð¿Ð¾ Ð½Ð¾Ð¼ÐµÑ€Ñƒ Ñ‚ÐµÐ»ÐµÑ„Ð¾Ð½Ð°?";

	/// <summary>
	/// Key: "Message.DefaultError"
	/// English String: "An error occurred, try again later."
	/// </summary>
	public override string MessageDefaultError => "ÐŸÑ€Ð¾Ð¸Ð·Ð¾ÑˆÐ»Ð° Ð¾ÑˆÐ¸Ð±ÐºÐ°. ÐŸÐ¾Ð²Ñ‚Ð¾Ñ€Ð¸Ñ‚Ðµ Ð¿Ð¾Ð¿Ñ‹Ñ‚ÐºÑƒ Ð¿Ð¾Ð·Ð¶Ðµ.";

	/// <summary>
	/// Key: "Message.EmailForUsernameSuccessBody"
	/// success message
	/// English String: "An email with your username(s) has been sent to you if the email was previously saved on your account."
	/// </summary>
	public override string MessageEmailForUsernameSuccessBody => "Ð•ÑÐ»Ð¸ Ð²Ð°ÑˆÐ° ÑÐ». Ð¿Ð¾Ñ‡Ñ‚Ð° Ð±Ñ‹Ð»Ð° Ñ€Ð°Ð½ÐµÐµ Ð¿Ð¾Ð´Ñ‚Ð²ÐµÑ€Ð¶Ð´ÐµÐ½Ð° Ð² Ð²Ð°ÑˆÐµÐ¹ ÑƒÑ‡ÐµÑ‚Ð½Ð¾Ð¹ Ð·Ð°Ð¿Ð¸ÑÐ¸, Ñ‚Ð¾ Ð½Ð° ÐµÐµ Ð°Ð´Ñ€ÐµÑ Ð±Ñ‹Ð»Ð¾ Ð²Ñ‹ÑÐ»Ð°Ð½Ð¾ Ð²Ð°ÑˆÐµ Ð¸Ð¼Ñ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ.";

	/// <summary>
	/// Key: "Message.EmailSuccessBody"
	/// English String: "An email with instructions has been sent to you if the email was previously saved on your account."
	/// </summary>
	public override string MessageEmailSuccessBody => "Ð•ÑÐ»Ð¸ Ð² Ð²Ð°ÑˆÐµÐ¹ ÑƒÑ‡ÐµÑ‚Ð½Ð¾Ð¹ Ð·Ð°Ð¿Ð¸ÑÐ¸ Ð±Ñ‹Ð»Ð° ÑÐ¾Ñ…Ñ€Ð°Ð½ÐµÐ½Ð° ÑÐ». Ð¿Ð¾Ñ‡Ñ‚Ð°, Ð½Ð° Ð½ÐµÐµ Ð±Ñ‹Ð»Ð¸ Ð¾Ñ‚Ð¿Ñ€Ð°Ð²Ð»ÐµÐ½Ñ‹ Ð¸Ð½ÑÑ‚Ñ€ÑƒÐºÑ†Ð¸Ð¸.";

	/// <summary>
	/// Key: "Message.EmailSuccessTitle"
	/// English String: "Email Sent"
	/// </summary>
	public override string MessageEmailSuccessTitle => "Ð¡Ð¾Ð¾Ð±Ñ‰ÐµÐ½Ð¸Ðµ Ð¾Ñ‚Ð¿Ñ€Ð°Ð²Ð»ÐµÐ½Ð¾";

	/// <summary>
	/// Key: "Message.EnterCode"
	/// English String: "A code was sent to your phone if it was previously verified on your account. Please enter it below"
	/// </summary>
	public override string MessageEnterCode => "Ð•ÑÐ»Ð¸ Ð²Ð°Ñˆ Ñ‚ÐµÐ»ÐµÑ„Ð¾Ð½ Ð±Ñ‹Ð» Ñ€Ð°Ð½ÐµÐµ Ð¿Ð¾Ð´Ñ‚Ð²ÐµÑ€Ð¶Ð´ÐµÐ½ Ð² Ð²Ð°ÑˆÐµÐ¹ ÑƒÑ‡ÐµÑ‚Ð½Ð¾Ð¹ Ð·Ð°Ð¿Ð¸ÑÐ¸, Ñ‚Ð¾ Ð½Ð° ÐµÐ³Ð¾ Ð½Ð¾Ð¼ÐµÑ€ Ð±Ñ‹Ð» Ð²Ñ‹ÑÐ»Ð°Ð½ ÐºÐ¾Ð´. ÐŸÐ¾Ð¶Ð°Ð»ÑƒÐ¹ÑÑ‚Ð°, Ð²Ð²ÐµÐ´Ð¸Ñ‚Ðµ ÐµÐ³Ð¾ Ð½Ð¸Ð¶Ðµ.";

	/// <summary>
	/// Key: "Message.EnterCodeSentToEmail"
	/// Enter the code we just sent to your email.
	/// English String: "Enter the code we just sent to your email."
	/// </summary>
	public override string MessageEnterCodeSentToEmail => "Ð’Ð²ÐµÐ´Ð¸Ñ‚Ðµ ÐºÐ¾Ð´, Ð¾Ñ‚Ð¿Ñ€Ð°Ð²Ð»ÐµÐ½Ð½Ñ‹Ð¹ Ð²Ð°Ð¼ Ð¿Ð¾ ÑÐ»ÐµÐºÑ‚Ñ€Ð¾Ð½Ð½Ð¾Ð¹ Ð¿Ð¾Ñ‡Ñ‚Ðµ.";

	/// <summary>
	/// Key: "Message.PhoneForUsernameSuccessBody"
	/// English String: "An SMS with your username(s) has been sent to you if the phone number was previously verified on your account."
	/// </summary>
	public override string MessagePhoneForUsernameSuccessBody => "Ð¡ÐœÐ¡ Ñ Ð²Ð°ÑˆÐ¸Ð¼ Ð¸Ð¼ÐµÐ½ÐµÐ¼ (Ð¸Ð¼ÐµÐ½Ð°Ð¼Ð¸) Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ(-ÐµÐ¹) Ð±Ñ‹Ð»Ð¾ Ð¾Ñ‚Ð¿Ñ€Ð°Ð²Ð»ÐµÐ½Ð¾ Ð½Ð° Ñ‚ÐµÐ»ÐµÑ„Ð¾Ð½Ð½Ñ‹Ð¹ Ð½Ð¾Ð¼ÐµÑ€, ÐµÑÐ»Ð¸ Ð¾Ð½ Ð±Ñ‹Ð» Ð¿Ð¾Ð´Ñ‚Ð²ÐµÑ€Ð¶Ð´ÐµÐ½ Ð² Ð²Ð°ÑˆÐµÐ¹ ÑƒÑ‡ÐµÑ‚Ð½Ð¾Ð¹ Ð·Ð°Ð¿Ð¸ÑÐ¸.";

	/// <summary>
	/// Key: "Message.PhoneForUsernameSuccessTitle"
	/// English String: "SMS Sent"
	/// </summary>
	public override string MessagePhoneForUsernameSuccessTitle => "Ð¡ÐœÐ¡ Ð¾Ñ‚Ð¿Ñ€Ð°Ð²Ð»ÐµÐ½Ð¾";

	/// <summary>
	/// Key: "MessageAccountDoesNotHaveAnEmail"
	/// English String: "There is no email linked to this account"
	/// </summary>
	public override string MessageAccountDoesNotHaveAnEmail => "Ðš ÑÑ‚Ð¾Ð¹ ÑƒÑ‡ÐµÑ‚Ð½Ð¾Ð¹ Ð·Ð°Ð¿Ð¸ÑÐ¸ Ð½Ðµ Ð¿Ñ€Ð¸ÐºÑ€ÐµÐ¿Ð»ÐµÐ½ Ð°Ð´Ñ€ÐµÑ ÑÐ». Ð¿Ð¾Ñ‡Ñ‚Ñ‹";

	/// <summary>
	/// Key: "MessageAccountNotFoundByEmail"
	/// No account found. Please use a different email.
	/// English String: "No account found. Please use a different email."
	/// </summary>
	public override string MessageAccountNotFoundByEmail => "Ð£Ñ‡ÐµÑ‚Ð½Ð°Ñ Ð·Ð°Ð¿Ð¸ÑÑŒ Ð½Ðµ Ð½Ð°Ð¹Ð´ÐµÐ½Ð°. Ð£ÐºÐ°Ð¶Ð¸Ñ‚Ðµ Ð´Ñ€ÑƒÐ³Ð¾Ð¹ Ð°Ð´Ñ€ÐµÑ ÑÐ». Ð¿Ð¾Ñ‡Ñ‚Ñ‹.";

	/// <summary>
	/// Key: "MessageAccountNotFoundByPhone"
	/// No account found. Please use a different phone number.
	/// English String: "No account found. Please use a different phone number."
	/// </summary>
	public override string MessageAccountNotFoundByPhone => "Ð£Ñ‡ÐµÑ‚Ð½Ð°Ñ Ð·Ð°Ð¿Ð¸ÑÑŒ Ð½Ðµ Ð½Ð°Ð¹Ð´ÐµÐ½Ð°. Ð£ÐºÐ°Ð¶Ð¸Ñ‚Ðµ Ð´Ñ€ÑƒÐ³Ð¾Ð¹ Ð½Ð¾Ð¼ÐµÑ€ Ñ‚ÐµÐ»ÐµÑ„Ð¾Ð½Ð°.";

	/// <summary>
	/// Key: "MessageAccountRecoveryUnknownError"
	/// English String: "System error. Account could not be restored to this state."
	/// </summary>
	public override string MessageAccountRecoveryUnknownError => "ÐžÑˆÐ¸Ð±ÐºÐ° ÑÐ¸ÑÑ‚ÐµÐ¼Ñ‹. Ð£Ñ‡ÐµÑ‚Ð½ÑƒÑŽ Ð·Ð°Ð¿Ð¸ÑÑŒ Ð½ÐµÐ²Ð¾Ð·Ð¼Ð¾Ð¶Ð½Ð¾ Ð²Ð¾ÑÑÑ‚Ð°Ð½Ð¾Ð²Ð¸Ñ‚ÑŒ Ð´Ð¾ ÑÑ‚Ð¾Ð³Ð¾ ÑÐ¾ÑÑ‚Ð¾ÑÐ½Ð¸Ñ.";

	/// <summary>
	/// Key: "MessageCaptchaError"
	/// English String: "We need to make sure you're not a robot!"
	/// </summary>
	public override string MessageCaptchaError => "ÐÐ°Ð¼ Ð½ÐµÐ¾Ð±Ñ…Ð¾Ð´Ð¸Ð¼Ð¾ ÑƒÐ±ÐµÐ´Ð¸Ñ‚ÑŒÑÑ, Ñ‡Ñ‚Ð¾ Ð²Ñ‹ â€“ Ð½Ðµ Ñ€Ð¾Ð±Ð¾Ñ‚!";

	/// <summary>
	/// Key: "MessageCaptchaFailError"
	/// English String: "The words you typed didn't match the picture. Please try again."
	/// </summary>
	public override string MessageCaptchaFailError => "Ð’Ð²ÐµÐ´ÐµÐ½Ð½Ñ‹Ðµ Ð²Ð°Ð¼Ð¸ ÑÐ»Ð¾Ð²Ð° Ð½Ðµ ÑÐ¾Ð¾Ñ‚Ð²ÐµÑ‚ÑÑ‚Ð²ÑƒÑŽÑ‚ Ð¸Ð·Ð¾Ð±Ñ€Ð°Ð¶ÐµÐ½Ð¸ÑŽ. ÐŸÐ¾Ð²Ñ‚Ð¾Ñ€Ð¸Ñ‚Ðµ Ð¿Ð¾Ð¿Ñ‹Ñ‚ÐºÑƒ.";

	/// <summary>
	/// Key: "MessageCredentialsError"
	/// English String: "Your username or password is incorrect. Please check them and try again."
	/// </summary>
	public override string MessageCredentialsError => "ÐÐµÐ¿Ñ€Ð°Ð²Ð¸Ð»ÑŒÐ½Ñ‹Ð¹ Ð¿Ð°Ñ€Ð¾Ð»ÑŒ Ð¸Ð»Ð¸ Ð¸Ð¼Ñ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ. ÐŸÑ€Ð¾Ð²ÐµÑ€ÑŒÑ‚Ðµ ÐµÑ‰Ðµ Ñ€Ð°Ð· Ð¸ Ð¿Ð¾Ð²Ñ‚Ð¾Ñ€Ð¸Ñ‚Ðµ Ð¿Ð¾Ð¿Ñ‹Ñ‚ÐºÑƒ.";

	/// <summary>
	/// Key: "MessageFloodCheckedError"
	/// English String: "Too many attempts. Please try again later."
	/// </summary>
	public override string MessageFloodCheckedError => "Ð¡Ð»Ð¸ÑˆÐºÐ¾Ð¼ Ð¼Ð½Ð¾Ð³Ð¾ Ð¿Ð¾Ð¿Ñ‹Ñ‚Ð¾Ðº. ÐŸÐ¾Ð²Ñ‚Ð¾Ñ€Ð¸Ñ‚Ðµ Ð¿Ð¾Ð¿Ñ‹Ñ‚ÐºÑƒ Ð¿Ð¾Ð·Ð¶Ðµ.";

	/// <summary>
	/// Key: "MessageForgotPasswordFeatureDisabled"
	/// English String: "Feature temporarily disabled. Please try again later."
	/// </summary>
	public override string MessageForgotPasswordFeatureDisabled => "Ð¤ÑƒÐ½ÐºÑ†Ð¸Ñ Ð²Ñ€ÐµÐ¼ÐµÐ½Ð½Ð¾ Ð½ÐµÐ´Ð¾ÑÑ‚ÑƒÐ¿Ð½Ð°. ÐŸÐ¾Ð²Ñ‚Ð¾Ñ€Ð¸Ñ‚Ðµ Ð¿Ð¾Ð¿Ñ‹Ñ‚ÐºÑƒ Ð¿Ð¾Ð·Ð¶Ðµ.";

	/// <summary>
	/// Key: "MessageForgotPasswordSuccess"
	/// English String: "Check your email for login instructions"
	/// </summary>
	public override string MessageForgotPasswordSuccess => "Ð˜Ð½ÑÑ‚Ñ€ÑƒÐºÑ†Ð¸Ð¸ Ð¿Ð¾ Ð²Ñ…Ð¾Ð´Ñƒ Ð¾Ñ‚Ð¿Ñ€Ð°Ð²Ð»ÐµÐ½Ñ‹ Ð²Ð°Ð¼ Ð¿Ð¾ ÑÐ»ÐµÐºÑ‚Ñ€Ð¾Ð½Ð½Ð¾Ð¹ Ð¿Ð¾Ñ‡Ñ‚Ðµ";

	/// <summary>
	/// Key: "MessageInvalidAccountStatus"
	/// English String: "Account status prevents resetting password"
	/// </summary>
	public override string MessageInvalidAccountStatus => "Ð¡Ð¾ÑÑ‚Ð¾ÑÐ½Ð¸Ðµ ÑƒÑ‡ÐµÑ‚Ð½Ð¾Ð¹ Ð·Ð°Ð¿Ð¸ÑÐ¸ Ð·Ð°Ð¿Ñ€ÐµÑ‰Ð°ÐµÑ‚ ÑÐ±Ñ€Ð¾Ñ Ð¿Ð°Ñ€Ð¾Ð»Ñ";

	/// <summary>
	/// Key: "MessageInvalidPassword"
	/// English String: "Invalid password"
	/// </summary>
	public override string MessageInvalidPassword => "ÐÐµÐ´Ð¾Ð¿ÑƒÑÑ‚Ð¸Ð¼Ñ‹Ð¹ Ð¿Ð°Ñ€Ð¾Ð»ÑŒ";

	/// <summary>
	/// Key: "MessageInvalidTicket"
	/// English String: "We couldn't load this security ticket."
	/// </summary>
	public override string MessageInvalidTicket => "ÐÐµ ÑƒÐ´Ð°Ð»Ð¾ÑÑŒ Ð·Ð°Ð³Ñ€ÑƒÐ·Ð¸Ñ‚ÑŒ ÑÑ‚Ð¾Ñ‚ Ð±Ð¸Ð»ÐµÑ‚ Ð±ÐµÐ·Ð¾Ð¿Ð°ÑÐ½Ð¾ÑÑ‚Ð¸.";

	/// <summary>
	/// Key: "MessageInvalidUserNameOrEmail"
	/// English String: "Invalid username, or no email exists"
	/// </summary>
	public override string MessageInvalidUserNameOrEmail => "ÐÐµÐ´Ð¾Ð¿ÑƒÑÑ‚Ð¸Ð¼Ð¾Ðµ Ð¸Ð¼Ñ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ Ð¸Ð»Ð¸ Ð½ÐµÑÑƒÑ‰ÐµÑÑ‚Ð²ÑƒÑŽÑ‰Ð¸Ð¹ Ð°Ð´Ñ€ÐµÑ ÑÐ». Ð¿Ð¾Ñ‡Ñ‚Ñ‹";

	/// <summary>
	/// Key: "MessageMobileResetPasswordSuccess"
	/// English String: "MobileResetPasswordSuccess"
	/// </summary>
	public override string MessageMobileResetPasswordSuccess => "MobileResetPasswordSuccess";

	/// <summary>
	/// Key: "MessageNoAccountsLinkedToEmail"
	/// English String: "There are no accounts linked to this email address"
	/// </summary>
	public override string MessageNoAccountsLinkedToEmail => "Ðš ÑÑ‚Ð¾Ð¼Ñƒ Ð°Ð´Ñ€ÐµÑÑƒ ÑÐ». Ð¿Ð¾Ñ‡Ñ‚Ñ‹ Ð½Ðµ Ð¿Ñ€Ð¸ÐºÑ€ÐµÐ¿Ð»ÐµÐ½Ð° ÑƒÑ‡ÐµÑ‚Ð½Ð°Ñ Ð·Ð°Ð¿Ð¸ÑÑŒ";

	/// <summary>
	/// Key: "MessageOldUsernameError"
	/// English String: "It looks like you are trying to log in with a username that has changed. Please log in with your new username."
	/// </summary>
	public override string MessageOldUsernameError => "ÐŸÐ¾Ñ…Ð¾Ð¶Ðµ, Ð²Ñ‹ ÑƒÐºÐ°Ð·Ñ‹Ð²Ð°ÐµÑ‚Ðµ Ð¸Ð¼Ñ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ, ÐºÐ¾Ñ‚Ð¾Ñ€Ð¾Ðµ Ð±Ñ‹Ð»Ð¾ Ð¸Ð·Ð¼ÐµÐ½ÐµÐ½Ð¾. Ð’Ð¾Ð¹Ð´Ð¸Ñ‚Ðµ Ñ Ð½Ð¾Ð²Ñ‹Ð¼ Ð¸Ð¼ÐµÐ½ÐµÐ¼ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ.";

	/// <summary>
	/// Key: "MessagePasswordCannotBeUsed"
	/// English String: "Sorry, that password cannot be used."
	/// </summary>
	public override string MessagePasswordCannotBeUsed => "Ðš ÑÐ¾Ð¶Ð°Ð»ÐµÐ½Ð¸ÑŽ, ÑÑ‚Ð¾Ñ‚ Ð¿Ð°Ñ€Ð¾Ð»ÑŒ Ð½ÐµÐ»ÑŒÐ·Ñ Ð¸ÑÐ¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÑŒ.";

	/// <summary>
	/// Key: "MessagePasswordsDoNotMatch"
	/// English String: "Passwords do not match"
	/// </summary>
	public override string MessagePasswordsDoNotMatch => "ÐŸÐ°Ñ€Ð¾Ð»Ð¸ Ð½Ðµ ÑÐ¾Ð²Ð¿Ð°Ð´Ð°ÑŽÑ‚";

	/// <summary>
	/// Key: "MessageSamlUnauthenticated"
	/// English String: "You must log in to Roblox to finish authenticating."
	/// </summary>
	public override string MessageSamlUnauthenticated => "ÐÐµÐ¾Ð±Ñ…Ð¾Ð´Ð¸Ð¼Ð¾ Ð²Ð¾Ð¹Ñ‚Ð¸ Ð² Roblox, Ñ‡Ñ‚Ð¾Ð±Ñ‹ Ð·Ð°Ð²ÐµÑ€ÑˆÐ¸Ñ‚ÑŒ Ð°ÑƒÑ‚ÐµÐ½Ñ‚Ð¸Ñ„Ð¸ÐºÐ°Ñ†Ð¸ÑŽ.";

	/// <summary>
	/// Key: "MessageUnknownError"
	/// English String: "Unknown Error"
	/// </summary>
	public override string MessageUnknownError => "ÐÐµÐ¸Ð·Ð²ÐµÑÑ‚Ð½Ð°Ñ Ð¾ÑˆÐ¸Ð±ÐºÐ°";

	/// <summary>
	/// Key: "MessageUnknownSystemError"
	/// English String: "System error. Please return to login screen."
	/// </summary>
	public override string MessageUnknownSystemError => "ÐžÑˆÐ¸Ð±ÐºÐ° ÑÐ¸ÑÑ‚ÐµÐ¼Ñ‹. Ð’ÐµÑ€Ð½Ð¸Ñ‚ÐµÑÑŒ Ð½Ð° ÑÐºÑ€Ð°Ð½ Ð²Ñ…Ð¾Ð´Ð°.";

	/// <summary>
	/// Key: "Placeholder.Email"
	/// English String: "Email"
	/// </summary>
	public override string PlaceholderEmail => "Ð­Ð». Ð¿Ð¾Ñ‡Ñ‚Ð°";

	/// <summary>
	/// Key: "Placeholder.PhoneNumber"
	/// English String: "Phone Number"
	/// </summary>
	public override string PlaceholderPhoneNumber => "ÐÐ¾Ð¼ÐµÑ€ Ñ‚ÐµÐ»ÐµÑ„Ð¾Ð½Ð°";

	/// <summary>
	/// Key: "Response.PasswordResetSuccess"
	/// Password reset success! Please login again.
	/// English String: "Password reset success! Please login again."
	/// </summary>
	public override string ResponsePasswordResetSuccess => "ÐŸÐ°Ñ€Ð¾Ð»ÑŒ ÑÐ±Ñ€Ð¾ÑˆÐµÐ½! Ð’Ð¾Ð¹Ð´Ð¸Ñ‚Ðµ Ð² ÑƒÑ‡ÐµÑ‚Ð½ÑƒÑŽ Ð·Ð°Ð¿Ð¸ÑÑŒ Ð¿Ð¾Ð²Ñ‚Ð¾Ñ€Ð½Ð¾.";

	/// <summary>
	/// Key: "Response.Success"
	/// English String: "Success"
	/// </summary>
	public override string ResponseSuccess => "Ð£ÑÐ¿ÐµÑ…";

	/// <summary>
	/// Key: "Response.UpdatePasswordFlooded"
	/// English String: "Too many attempts. Please try again later."
	/// </summary>
	public override string ResponseUpdatePasswordFlooded => "Ð¡Ð»Ð¸ÑˆÐºÐ¾Ð¼ Ð¼Ð½Ð¾Ð³Ð¾ Ð¿Ð¾Ð¿Ñ‹Ñ‚Ð¾Ðº. ÐŸÐ¾Ð²Ñ‚Ð¾Ñ€Ð¸Ñ‚Ðµ Ð¿Ð¾Ð¿Ñ‹Ñ‚ÐºÑƒ Ð¿Ð¾Ð·Ð¶Ðµ.";

	/// <summary>
	/// Key: "Response.UpdatePasswordIncorrect"
	/// English String: "Your current password is incorrect, the password was not changed."
	/// </summary>
	public override string ResponseUpdatePasswordIncorrect => "ÐÐµÐ¿Ñ€Ð°Ð²Ð¸Ð»ÑŒÐ½Ñ‹Ð¹ Ñ‚ÐµÐºÑƒÑ‰Ð¸Ð¹ Ð¿Ð°Ñ€Ð¾Ð»ÑŒ. ÐŸÐ°Ñ€Ð¾Ð»ÑŒ Ð½Ðµ Ð¸Ð·Ð¼ÐµÐ½ÐµÐ½.";

	/// <summary>
	/// Key: "Response.UpdatePasswordInputMissing"
	/// English String: "Must include new password and confirm password"
	/// </summary>
	public override string ResponseUpdatePasswordInputMissing => "Ð¢Ñ€ÐµÐ±ÑƒÐµÑ‚ÑÑ ÑƒÐºÐ°Ð·Ð°Ñ‚ÑŒ Ð¸ Ð¿Ð¾Ð´Ñ‚Ð²ÐµÑ€Ð´Ð¸Ñ‚ÑŒ Ð½Ð¾Ð²Ñ‹Ð¹ Ð¿Ð°Ñ€Ð¾Ð»ÑŒ";

	/// <summary>
	/// Key: "Response.UpdatePasswordMismatch"
	/// English String: "Your new password and confirm password must match"
	/// </summary>
	public override string ResponseUpdatePasswordMismatch => "Ð”Ð°Ð½Ð½Ñ‹Ðµ Ð² Ð¿Ð¾Ð»ÑÑ… Â«ÐÐ¾Ð²Ñ‹Ð¹ Ð¿Ð°Ñ€Ð¾Ð»ÑŒÂ» Ð¸ Â«ÐŸÐ¾Ð´Ñ‚Ð²ÐµÑ€Ð¶Ð´ÐµÐ½Ð¸Ðµ Ð¿Ð°Ñ€Ð¾Ð»ÑÂ» Ð´Ð¾Ð»Ð¶Ð½Ñ‹ ÑÐ¾Ð²Ð¿Ð°Ð´Ð°Ñ‚ÑŒ";

	public ResetPasswordResources_ru_ru(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "ÐžÑ‚Ð¼ÐµÐ½Ð°";
	}

	protected override string _GetTemplateForActionEmailToResetPassword()
	{
		return "Ð¡Ð±Ñ€Ð¾ÑÐ¸Ñ‚ÑŒ Ð¿Ð°Ñ€Ð¾Ð»ÑŒ Ñ Ð¿Ð¾Ð¼Ð¾Ñ‰ÑŒÑŽ ÑÐ». Ð¿Ð¾Ñ‡Ñ‚Ñ‹";
	}

	protected override string _GetTemplateForActionEmailToRetriveUsername()
	{
		return "Ð’Ð¾ÑÑÑ‚Ð°Ð½Ð¾Ð²Ð¸Ñ‚ÑŒ Ð¸Ð¼Ñ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ Ñ Ð¿Ð¾Ð¼Ð¾Ñ‰ÑŒÑŽ ÑÐ». Ð¿Ð¾Ñ‡Ñ‚Ñ‹";
	}

	protected override string _GetTemplateForActionOk()
	{
		return "OK";
	}

	protected override string _GetTemplateForActionPhoneToResetPassword()
	{
		return "Ð¡Ð±Ñ€Ð¾ÑÐ¸Ñ‚ÑŒ Ð¿Ð°Ñ€Ð¾Ð»ÑŒ Ñ Ð¿Ð¾Ð¼Ð¾Ñ‰ÑŒÑŽ Ñ‚ÐµÐ»ÐµÑ„Ð¾Ð½Ð°";
	}

	protected override string _GetTemplateForActionPhoneToRetriveUsername()
	{
		return "Ð’Ð¾ÑÑÑ‚Ð°Ð½Ð¾Ð²Ð¸Ñ‚ÑŒ Ð¸Ð¼Ñ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ Ñ Ð¿Ð¾Ð¼Ð¾Ñ‰ÑŒÑŽ Ñ‚ÐµÐ»ÐµÑ„Ð¾Ð½Ð°";
	}

	protected override string _GetTemplateForActionVerify()
	{
		return "ÐŸÐ¾Ð´Ñ‚Ð²ÐµÑ€Ð´Ð¸Ñ‚ÑŒ";
	}

	/// <summary>
	/// Key: "Description.ChangePasswordEmail.HtmlBody1"
	/// email body for change password email
	/// English String: "We noticed that the password changed for your Roblox account: {userName}. If you didn't intend to change it, or you think someone else changed it by mistake, please click this link to undo the action:{lineBreak} {actionLink} {lineBreak}{lineBreak}If you are happy with your new Roblox password, you don't have to do anything! It's already set up. Please do not reply to this message. If you have any questions, please see the Roblox help page (https://www.roblox.com/help)."
	/// </summary>
	public override string DescriptionChangePasswordEmailHtmlBody1(string userName, string lineBreak, string actionLink)
	{
		return $".ÐœÑ‹ Ð·Ð°Ð¼ÐµÑ‚Ð¸Ð»Ð¸, Ñ‡Ñ‚Ð¾ Ð²Ñ‹ Ð¸Ð·Ð¼ÐµÐ½Ð¸Ð»Ð¸ Ð¿Ð°Ñ€Ð¾Ð»ÑŒ Ð´Ð»Ñ ÑƒÑ‡ÐµÑ‚Ð½Ð¾Ð¹ Ð·Ð°Ð¿Ð¸ÑÐ¸  Roblox: {userName}Ð•ÑÐ»Ð¸ Ð²Ñ‹ ÑÑ‚Ð¾Ð³Ð¾ Ð½Ðµ ÑÐ¾Ð²ÐµÑ€ÑˆÐ°Ð»Ð¸ Ð¸Ð»Ð¸ ÐºÑ‚Ð¾-Ñ‚Ð¾ Ð½Ðµ ÑÐ´ÐµÐ»Ð°Ð» ÑÑ‚Ð¾Ð³Ð¾ Ð¿Ð¾ Ð¾ÑˆÐ¸Ð±ÐºÐµ, Ð¿Ð¾Ð¶Ð°Ð»ÑƒÐ¹ÑÑ‚Ð°, Ð¿Ñ€Ð¾Ð¹Ð´Ð¸Ñ‚Ðµ Ð¿Ð¾ ÑÑÑ‹Ð»ÐºÐµ Ð½Ð¸Ð¶Ðµ:{lineBreak}{actionLink}{lineBreak}{lineBreak}Ð•ÑÐ»Ð¸ Ð²Ð°Ñ ÑƒÑÑ‚Ñ€Ð°Ð¸Ð²Ð°ÐµÑ‚ Ð²Ð°Ñˆ Ð½Ð¾Ð²Ñ‹Ð¹ Ð¿Ð°Ñ€Ð¾Ð»ÑŒ  Roblox, Ñ‚Ð¾Ð²Ð°Ð¼ Ð½Ð¸Ñ‡ÐµÐ³Ð¾ Ð½Ðµ Ð½ÑƒÐ¶Ð½Ð¾ Ð´ÐµÐ»Ð°Ñ‚ÑŒ. Ð’ÑÐµ ÑƒÐ¶Ðµ Ð½Ð°ÑÑ‚Ñ€Ð¾ÐµÐ½Ð¾. ÐŸÐ¾Ð¶Ð°Ð»ÑƒÐ¹ÑÑ‚Ð°, Ð½Ðµ Ð¾Ñ‚Ð²ÐµÑ‡Ð°Ð¹Ñ‚Ðµ Ð½Ð° ÑÑ‚Ð¾ ÑÐ¾Ð¾Ð±Ñ‰ÐµÐ½Ð¸Ðµ. Ð•ÑÐ»Ð¸ Ñƒ Ð²Ð°Ñ ÐµÑÑ‚ÑŒ Ð²Ð¾Ð¿Ñ€Ð¾ÑÑ‹, Ð¾Ð±Ñ€Ð°Ñ‚Ð¸Ñ‚ÐµÑÑ‚ÑŒ Ð½Ð° ÑÑ€Ð°Ð½Ð¸Ñ†Ñƒ Ð¿Ð¾Ð¼Ð¾Ñ‰Ð¸  Roblox (https://www.roblox.com/help).";
	}

	protected override string _GetTemplateForDescriptionChangePasswordEmailHtmlBody1()
	{
		return ".ÐœÑ‹ Ð·Ð°Ð¼ÐµÑ‚Ð¸Ð»Ð¸, Ñ‡Ñ‚Ð¾ Ð²Ñ‹ Ð¸Ð·Ð¼ÐµÐ½Ð¸Ð»Ð¸ Ð¿Ð°Ñ€Ð¾Ð»ÑŒ Ð´Ð»Ñ ÑƒÑ‡ÐµÑ‚Ð½Ð¾Ð¹ Ð·Ð°Ð¿Ð¸ÑÐ¸  Roblox: {userName}Ð•ÑÐ»Ð¸ Ð²Ñ‹ ÑÑ‚Ð¾Ð³Ð¾ Ð½Ðµ ÑÐ¾Ð²ÐµÑ€ÑˆÐ°Ð»Ð¸ Ð¸Ð»Ð¸ ÐºÑ‚Ð¾-Ñ‚Ð¾ Ð½Ðµ ÑÐ´ÐµÐ»Ð°Ð» ÑÑ‚Ð¾Ð³Ð¾ Ð¿Ð¾ Ð¾ÑˆÐ¸Ð±ÐºÐµ, Ð¿Ð¾Ð¶Ð°Ð»ÑƒÐ¹ÑÑ‚Ð°, Ð¿Ñ€Ð¾Ð¹Ð´Ð¸Ñ‚Ðµ Ð¿Ð¾ ÑÑÑ‹Ð»ÐºÐµ Ð½Ð¸Ð¶Ðµ:{lineBreak}{actionLink}{lineBreak}{lineBreak}Ð•ÑÐ»Ð¸ Ð²Ð°Ñ ÑƒÑÑ‚Ñ€Ð°Ð¸Ð²Ð°ÐµÑ‚ Ð²Ð°Ñˆ Ð½Ð¾Ð²Ñ‹Ð¹ Ð¿Ð°Ñ€Ð¾Ð»ÑŒ  Roblox, Ñ‚Ð¾Ð²Ð°Ð¼ Ð½Ð¸Ñ‡ÐµÐ³Ð¾ Ð½Ðµ Ð½ÑƒÐ¶Ð½Ð¾ Ð´ÐµÐ»Ð°Ñ‚ÑŒ. Ð’ÑÐµ ÑƒÐ¶Ðµ Ð½Ð°ÑÑ‚Ñ€Ð¾ÐµÐ½Ð¾. ÐŸÐ¾Ð¶Ð°Ð»ÑƒÐ¹ÑÑ‚Ð°, Ð½Ðµ Ð¾Ñ‚Ð²ÐµÑ‡Ð°Ð¹Ñ‚Ðµ Ð½Ð° ÑÑ‚Ð¾ ÑÐ¾Ð¾Ð±Ñ‰ÐµÐ½Ð¸Ðµ. Ð•ÑÐ»Ð¸ Ñƒ Ð²Ð°Ñ ÐµÑÑ‚ÑŒ Ð²Ð¾Ð¿Ñ€Ð¾ÑÑ‹, Ð¾Ð±Ñ€Ð°Ñ‚Ð¸Ñ‚ÐµÑÑ‚ÑŒ Ð½Ð° ÑÑ€Ð°Ð½Ð¸Ñ†Ñƒ Ð¿Ð¾Ð¼Ð¾Ñ‰Ð¸  Roblox (https://www.roblox.com/help).";
	}

	protected override string _GetTemplateForDescriptionEmailToResetPassword()
	{
		return "Ð’Ð²ÐµÐ´Ð¸Ñ‚Ðµ Ð°Ð´Ñ€ÐµÑ ÑÐ». Ð¿Ð¾Ñ‡Ñ‚Ñ‹, Ñ‡Ñ‚Ð¾Ð±Ñ‹ ÑÐ±Ñ€Ð¾ÑÐ¸Ñ‚ÑŒ Ð¿Ð°Ñ€Ð¾Ð»ÑŒ.";
	}

	protected override string _GetTemplateForDescriptionEmailToRetriveUsername()
	{
		return "Ð’Ð²ÐµÐ´Ð¸Ñ‚Ðµ Ð°Ð´Ñ€ÐµÑ ÑÐ». Ð¿Ð¾Ñ‡Ñ‚Ñ‹, Ñ‡Ñ‚Ð¾Ð±Ñ‹ Ð²Ð¾ÑÑÑ‚Ð°Ð½Ð¾Ð²Ð¸Ñ‚ÑŒ ÑÐ²Ð¾Ðµ Ð¸Ð¼Ñ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ.";
	}

	/// <summary>
	/// Key: "Description.PasswordChangeEmail.BodyPlainText"
	/// password reset plaintext email message
	/// English String: "We noticed that the password changed for your Roblox account: {userName}. If you didn't intend to change it, or you think someone else changed it by mistake, please click this link to undo the action:\n{urlWithTicket}\n\nIf you are happy with your new Roblox password, you don't have to do anything! It's already set up. Please do not reply to this message. If you have any questions, please see the Roblox help page (https://www.roblox.com/help)."
	/// </summary>
	public override string DescriptionPasswordChangeEmailBodyPlainText(string userName, string urlWithTicket)
	{
		return $"ÐœÑ‹ Ð·Ð°Ð¼ÐµÑ‚Ð¸Ð»Ð¸, Ñ‡Ñ‚Ð¾ Ð²Ñ‹ Ð¸Ð·Ð¼ÐµÐ½Ð¸Ð»Ð¸ Ð¿Ð°Ñ€Ð¾Ð»ÑŒ Ð´Ð»Ñ ÑƒÑ‡ÐµÑ‚Ð½Ð¾Ð¹ Ð·Ð°Ð¿Ð¸ÑÐ¸  Roblox: {userName}Ð•ÑÐ»Ð¸ Ð²Ñ‹ ÑÑ‚Ð¾Ð³Ð¾ Ð½Ðµ ÑÐ¾Ð²ÐµÑ€ÑˆÐ°Ð»Ð¸ Ð¸Ð»Ð¸ ÐºÑ‚Ð¾-Ñ‚Ð¾ Ð½Ðµ ÑÐ´ÐµÐ»Ð°Ð» ÑÑ‚Ð¾Ð³Ð¾ Ð¿Ð¾ Ð¾ÑˆÐ¸Ð±ÐºÐµ, Ð¿Ð¾Ð¶Ð°Ð»ÑƒÐ¹ÑÑ‚Ð°, Ð¿Ñ€Ð¾Ð¹Ð´Ð¸Ñ‚Ðµ Ð¿Ð¾ ÑÑÑ‹Ð»ÐºÐµ Ð½Ð¸Ð¶Ðµ:\n{urlWithTicket}\n\nÐ•ÑÐ»Ð¸ Ð²Ð°Ñ ÑƒÑÑ‚Ñ€Ð°Ð¸Ð²Ð°ÐµÑ‚ Ð²Ð°Ñˆ Ð½Ð¾Ð²Ñ‹Ð¹ Ð¿Ð°Ñ€Ð¾Ð»ÑŒ  Roblox, Ñ‚Ð¾Ð²Ð°Ð¼ Ð½Ð¸Ñ‡ÐµÐ³Ð¾ Ð½Ðµ Ð½ÑƒÐ¶Ð½Ð¾ Ð´ÐµÐ»Ð°Ñ‚ÑŒ. Ð’ÑÐµ ÑƒÐ¶Ðµ Ð½Ð°ÑÑ‚Ñ€Ð¾ÐµÐ½Ð¾. ÐŸÐ¾Ð¶Ð°Ð»ÑƒÐ¹ÑÑ‚Ð°, Ð½Ðµ Ð¾Ñ‚Ð²ÐµÑ‡Ð°Ð¹Ñ‚Ðµ Ð½Ð° ÑÑ‚Ð¾ ÑÐ¾Ð¾Ð±Ñ‰ÐµÐ½Ð¸Ðµ. Ð•ÑÐ»Ð¸ Ñƒ Ð²Ð°Ñ ÐµÑÑ‚ÑŒ Ð²Ð¾Ð¿Ñ€Ð¾ÑÑ‹, Ð¾Ð±Ñ€Ð°Ñ‚Ð¸Ñ‚ÐµÑÑ‚ÑŒ Ð½Ð° ÑÑ€Ð°Ð½Ð¸Ñ†Ñƒ Ð¿Ð¾Ð¼Ð¾Ñ‰Ð¸  Roblox (https://www.roblox.com/help).";
	}

	protected override string _GetTemplateForDescriptionPasswordChangeEmailBodyPlainText()
	{
		return "ÐœÑ‹ Ð·Ð°Ð¼ÐµÑ‚Ð¸Ð»Ð¸, Ñ‡Ñ‚Ð¾ Ð²Ñ‹ Ð¸Ð·Ð¼ÐµÐ½Ð¸Ð»Ð¸ Ð¿Ð°Ñ€Ð¾Ð»ÑŒ Ð´Ð»Ñ ÑƒÑ‡ÐµÑ‚Ð½Ð¾Ð¹ Ð·Ð°Ð¿Ð¸ÑÐ¸  Roblox: {userName}Ð•ÑÐ»Ð¸ Ð²Ñ‹ ÑÑ‚Ð¾Ð³Ð¾ Ð½Ðµ ÑÐ¾Ð²ÐµÑ€ÑˆÐ°Ð»Ð¸ Ð¸Ð»Ð¸ ÐºÑ‚Ð¾-Ñ‚Ð¾ Ð½Ðµ ÑÐ´ÐµÐ»Ð°Ð» ÑÑ‚Ð¾Ð³Ð¾ Ð¿Ð¾ Ð¾ÑˆÐ¸Ð±ÐºÐµ, Ð¿Ð¾Ð¶Ð°Ð»ÑƒÐ¹ÑÑ‚Ð°, Ð¿Ñ€Ð¾Ð¹Ð´Ð¸Ñ‚Ðµ Ð¿Ð¾ ÑÑÑ‹Ð»ÐºÐµ Ð½Ð¸Ð¶Ðµ:\n{urlWithTicket}\n\nÐ•ÑÐ»Ð¸ Ð²Ð°Ñ ÑƒÑÑ‚Ñ€Ð°Ð¸Ð²Ð°ÐµÑ‚ Ð²Ð°Ñˆ Ð½Ð¾Ð²Ñ‹Ð¹ Ð¿Ð°Ñ€Ð¾Ð»ÑŒ  Roblox, Ñ‚Ð¾Ð²Ð°Ð¼ Ð½Ð¸Ñ‡ÐµÐ³Ð¾ Ð½Ðµ Ð½ÑƒÐ¶Ð½Ð¾ Ð´ÐµÐ»Ð°Ñ‚ÑŒ. Ð’ÑÐµ ÑƒÐ¶Ðµ Ð½Ð°ÑÑ‚Ñ€Ð¾ÐµÐ½Ð¾. ÐŸÐ¾Ð¶Ð°Ð»ÑƒÐ¹ÑÑ‚Ð°, Ð½Ðµ Ð¾Ñ‚Ð²ÐµÑ‡Ð°Ð¹Ñ‚Ðµ Ð½Ð° ÑÑ‚Ð¾ ÑÐ¾Ð¾Ð±Ñ‰ÐµÐ½Ð¸Ðµ. Ð•ÑÐ»Ð¸ Ñƒ Ð²Ð°Ñ ÐµÑÑ‚ÑŒ Ð²Ð¾Ð¿Ñ€Ð¾ÑÑ‹, Ð¾Ð±Ñ€Ð°Ñ‚Ð¸Ñ‚ÐµÑÑ‚ÑŒ Ð½Ð° ÑÑ€Ð°Ð½Ð¸Ñ†Ñƒ Ð¿Ð¾Ð¼Ð¾Ñ‰Ð¸  Roblox (https://www.roblox.com/help).";
	}

	/// <summary>
	/// Key: "Description.PasswordChangeEmail.From"
	/// name of the sender as shown in from field of the email
	/// English String: "\"Roblox Password Reset\" {fromEmailAddress}"
	/// </summary>
	public override string DescriptionPasswordChangeEmailFrom(string fromEmailAddress)
	{
		return $"Â«Ð˜Ð·Ð¼ÐµÐ½ÐµÐ½Ð¸Ðµ Ð¿Ð°Ñ€Ð¾Ð»Ñ RobloxÂ» {fromEmailAddress}";
	}

	protected override string _GetTemplateForDescriptionPasswordChangeEmailFrom()
	{
		return "Â«Ð˜Ð·Ð¼ÐµÐ½ÐµÐ½Ð¸Ðµ Ð¿Ð°Ñ€Ð¾Ð»Ñ RobloxÂ» {fromEmailAddress}";
	}

	protected override string _GetTemplateForDescriptionPasswordChangeEmailSubject()
	{
		return "Ð¡Ð±Ñ€Ð¾Ñ Ð¿Ð°Ñ€Ð¾Ð»Ñ Roblox";
	}

	/// <summary>
	/// Key: "Description.PasswordResetEmail.From"
	/// The "From" field for the password reset email
	/// English String: "{escapeLiteralStart}Roblox Password Reset{escapeLiteralEnd} {fromEmailAddress}"
	/// </summary>
	public override string DescriptionPasswordResetEmailFrom(string escapeLiteralStart, string escapeLiteralEnd, string fromEmailAddress)
	{
		return $"{escapeLiteralStart}Ð˜Ð·Ð¼ÐµÐ½ÐµÐ½Ð¸Ðµ Ð¿Ð°Ñ€Ð¾Ð»Ñ Roblox{escapeLiteralEnd} {fromEmailAddress}";
	}

	protected override string _GetTemplateForDescriptionPasswordResetEmailFrom()
	{
		return "{escapeLiteralStart}Ð˜Ð·Ð¼ÐµÐ½ÐµÐ½Ð¸Ðµ Ð¿Ð°Ñ€Ð¾Ð»Ñ Roblox{escapeLiteralEnd} {fromEmailAddress}";
	}

	/// <summary>
	/// Key: "Description.PasswordResetEmail.HtmlBody"
	/// This email is sent when a user requests a password reset.
	/// English String: "We have received a request to reset the password for your Roblox account: {emailOrUsername}{lineBreak}{lineBreak}If you submitted this request, please click the button below to proceed.{lineBreak}This button will be active for {passwordResetTicketHours} hours, {passwordResetTicketMinutes} minutes. If you do not wish to reset your password, please disregard this notice.{lineBreak}{lineBreak}{aTagWithStartHref}{resetPasswordUrl}{hrefEnd}{buttonStart}Reset Password{buttonEnd}{aTagEnd}"
	/// </summary>
	public override string DescriptionPasswordResetEmailHtmlBody(string emailOrUsername, string lineBreak, string passwordResetTicketHours, string passwordResetTicketMinutes, string aTagWithStartHref, string resetPasswordUrl, string hrefEnd, string buttonStart, string buttonEnd, string aTagEnd)
	{
		return $"ÐœÑ‹ Ð¿Ð¾Ð»ÑƒÑ‡Ð¸Ð»Ð¸ Ð·Ð°Ð¿Ñ€Ð¾Ñ Ð½Ð° Ð¸Ð·Ð¼ÐµÐ½ÐµÐ½Ð¸Ðµ Ð²Ð°ÑˆÐµÐ³Ð¾ Ð¿Ð°Ñ€Ð¾Ð»Ñ Ð´Ð»Ñ ÑƒÑ‡ÐµÑ‚Ð½Ð¾Ð¹ Ð·Ð°Ð¿Ð¸ÑÐ¸ Roblox: {emailOrUsername}{lineBreak}{lineBreak}Ð•ÑÐ»Ð¸ Ð²Ñ‹ Ð´ÐµÐ¹ÑÑ‚Ð²Ð¸Ñ‚ÐµÐ»ÑŒÐ½Ð¾ ÑÐ´ÐµÐ»Ð°Ð»Ð¸ ÑÑ‚Ð¾Ñ‚ Ð·Ð°Ð¿Ñ€Ð¾Ñ, Ð¿Ð¾Ð¶Ð°Ð»ÑƒÐ¹ÑÑ‚Ð°, Ð½Ð°Ð¶Ð¼Ð¸Ñ‚Ðµ Ð½Ð° ÐºÐ½Ð¾Ð¿ÐºÑƒ Ð½Ð¸Ð¶Ðµ.{lineBreak}Ð­Ñ‚Ð° ÐºÐ½Ð¾Ð¿ÐºÐ° Ð±ÑƒÐ´ÐµÑ‚ Ð°ÐºÑ‚Ð¸Ð²Ð½Ð° Ð² Ñ‚ÐµÑ‡ÐµÐ½Ð¸Ðµ {passwordResetTicketHours} Ñ‡Ð°ÑÐ¾Ð², {passwordResetTicketMinutes} Ð¼Ð¸Ð½ÑƒÑ‚. ÐµÑÐ»Ð¸ Ð²Ñ‹ Ð½Ðµ Ð¶ÐµÐ»Ð°ÐµÑ‚Ðµ Ð¸Ð·Ð¼ÐµÐ½Ð¸Ñ‚ÑŒ ÑÐ²Ð¾Ð¹ Ð¿Ð°Ñ€Ð¾Ð»ÑŒ, Ð¿Ð¾Ð¶Ð°Ð»ÑƒÐ¹ÑÑ‚Ð°, Ð¸Ð³Ð½Ð¾Ñ€Ð¸Ñ€ÑƒÐ¹Ñ‚Ðµ ÑÑ‚Ð¾ ÑÐ¾Ð¾Ð±Ñ‰ÐµÐ½Ð¸Ðµ.{lineBreak}{lineBreak}{aTagWithStartHref}{resetPasswordUrl}{hrefEnd}{buttonStart}Ð˜Ð·Ð¼ÐµÐ½Ð¸Ñ‚ÑŒ Ð¿Ð°Ñ€Ð¾Ð»ÑŒ{buttonEnd}{aTagEnd}";
	}

	protected override string _GetTemplateForDescriptionPasswordResetEmailHtmlBody()
	{
		return "ÐœÑ‹ Ð¿Ð¾Ð»ÑƒÑ‡Ð¸Ð»Ð¸ Ð·Ð°Ð¿Ñ€Ð¾Ñ Ð½Ð° Ð¸Ð·Ð¼ÐµÐ½ÐµÐ½Ð¸Ðµ Ð²Ð°ÑˆÐµÐ³Ð¾ Ð¿Ð°Ñ€Ð¾Ð»Ñ Ð´Ð»Ñ ÑƒÑ‡ÐµÑ‚Ð½Ð¾Ð¹ Ð·Ð°Ð¿Ð¸ÑÐ¸ Roblox: {emailOrUsername}{lineBreak}{lineBreak}Ð•ÑÐ»Ð¸ Ð²Ñ‹ Ð´ÐµÐ¹ÑÑ‚Ð²Ð¸Ñ‚ÐµÐ»ÑŒÐ½Ð¾ ÑÐ´ÐµÐ»Ð°Ð»Ð¸ ÑÑ‚Ð¾Ñ‚ Ð·Ð°Ð¿Ñ€Ð¾Ñ, Ð¿Ð¾Ð¶Ð°Ð»ÑƒÐ¹ÑÑ‚Ð°, Ð½Ð°Ð¶Ð¼Ð¸Ñ‚Ðµ Ð½Ð° ÐºÐ½Ð¾Ð¿ÐºÑƒ Ð½Ð¸Ð¶Ðµ.{lineBreak}Ð­Ñ‚Ð° ÐºÐ½Ð¾Ð¿ÐºÐ° Ð±ÑƒÐ´ÐµÑ‚ Ð°ÐºÑ‚Ð¸Ð²Ð½Ð° Ð² Ñ‚ÐµÑ‡ÐµÐ½Ð¸Ðµ {passwordResetTicketHours} Ñ‡Ð°ÑÐ¾Ð², {passwordResetTicketMinutes} Ð¼Ð¸Ð½ÑƒÑ‚. ÐµÑÐ»Ð¸ Ð²Ñ‹ Ð½Ðµ Ð¶ÐµÐ»Ð°ÐµÑ‚Ðµ Ð¸Ð·Ð¼ÐµÐ½Ð¸Ñ‚ÑŒ ÑÐ²Ð¾Ð¹ Ð¿Ð°Ñ€Ð¾Ð»ÑŒ, Ð¿Ð¾Ð¶Ð°Ð»ÑƒÐ¹ÑÑ‚Ð°, Ð¸Ð³Ð½Ð¾Ñ€Ð¸Ñ€ÑƒÐ¹Ñ‚Ðµ ÑÑ‚Ð¾ ÑÐ¾Ð¾Ð±Ñ‰ÐµÐ½Ð¸Ðµ.{lineBreak}{lineBreak}{aTagWithStartHref}{resetPasswordUrl}{hrefEnd}{buttonStart}Ð˜Ð·Ð¼ÐµÐ½Ð¸Ñ‚ÑŒ Ð¿Ð°Ñ€Ð¾Ð»ÑŒ{buttonEnd}{aTagEnd}";
	}

	/// <summary>
	/// Key: "Description.PasswordResetEmail.PlainBody"
	/// This email is sent when a user requests a password reset.
	/// English String: "We have received a request to reset the password for your Roblox account: {emailOrUsername}{lineBreak}{lineBreak}If you submitted this request, please click the link below or paste it into a web browser to proceed.{lineBreak}This link will be active for {passwordResetTicketHours} hours, {passwordResetTicketMinutes} minutes. If you do not wish to reset your password, please disregard this notice.{lineBreak}{lineBreak}{resetPasswordUrl}"
	/// </summary>
	public override string DescriptionPasswordResetEmailPlainBody(string emailOrUsername, string lineBreak, string passwordResetTicketHours, string passwordResetTicketMinutes, string resetPasswordUrl)
	{
		return $"ÐœÑ‹ Ð¿Ð¾Ð»ÑƒÑ‡Ð¸Ð»Ð¸ Ð·Ð°Ð¿Ñ€Ð¾Ñ Ð½Ð° Ð¸Ð·Ð¼ÐµÐ½ÐµÐ½Ð¸Ðµ Ð²Ð°ÑˆÐµÐ³Ð¾ Ð¿Ð°Ñ€Ð¾Ð»Ñ Ð´Ð»Ñ ÑƒÑ‡ÐµÑ‚Ð½Ð¾Ð¹ Ð·Ð°Ð¿Ð¸ÑÐ¸ Roblox: {emailOrUsername}{lineBreak}{lineBreak}Ð•ÑÐ»Ð¸ Ð²Ñ‹ Ð´ÐµÐ¹ÑÑ‚Ð²Ð¸Ñ‚ÐµÐ»ÑŒÐ½Ð¾ ÑÐ´ÐµÐ»Ð°Ð»Ð¸ ÑÑ‚Ð¾Ñ‚ Ð·Ð°Ð¿Ñ€Ð¾Ñ, Ð¿Ð¾Ð¶Ð°Ð»ÑƒÐ¹ÑÑ‚Ð°, Ð¿Ñ€Ð¾Ð¹Ð´Ð¸Ñ‚Ðµ Ð¿Ð¾ ÑÑÑ‹Ð»ÐºÐµ Ð½Ð¸Ð¶Ðµ Ð¸Ð»Ð¸ ÑÐºÐ¾Ð¿Ð¸Ñ€ÑƒÐ¹Ñ‚Ðµ ÐµÐµ Ð² Ð±Ñ€Ð°ÑƒÐ·ÐµÑ€.{lineBreak}Ð­Ñ‚Ð° ÑÑÑ‹Ð»ÐºÐ° Ð±ÑƒÐ´ÐµÑ‚ Ð°ÐºÑ‚Ð¸Ð²Ð½Ð° Ð² Ñ‚ÐµÑ‡ÐµÐ½Ð¸Ðµ {passwordResetTicketHours} Ñ‡Ð°ÑÐ¾Ð², {passwordResetTicketMinutes} Ð¼Ð¸Ð½ÑƒÑ‚. ÐµÑÐ»Ð¸ Ð²Ñ‹ Ð½Ðµ Ð¶ÐµÐ»Ð°ÐµÑ‚Ðµ Ð¸Ð·Ð¼ÐµÐ½Ð¸Ñ‚ÑŒ ÑÐ²Ð¾Ð¹ Ð¿Ð°Ñ€Ð¾Ð»ÑŒ, Ð¿Ð¾Ð¶Ð°Ð»ÑƒÐ¹ÑÑ‚Ð°, Ð¸Ð³Ð½Ð¾Ñ€Ð¸Ñ€ÑƒÐ¹Ñ‚Ðµ ÑÑ‚Ð¾ ÑÐ¾Ð¾Ð±Ñ‰ÐµÐ½Ð¸Ðµ.{lineBreak}{lineBreak}{resetPasswordUrl}";
	}

	protected override string _GetTemplateForDescriptionPasswordResetEmailPlainBody()
	{
		return "ÐœÑ‹ Ð¿Ð¾Ð»ÑƒÑ‡Ð¸Ð»Ð¸ Ð·Ð°Ð¿Ñ€Ð¾Ñ Ð½Ð° Ð¸Ð·Ð¼ÐµÐ½ÐµÐ½Ð¸Ðµ Ð²Ð°ÑˆÐµÐ³Ð¾ Ð¿Ð°Ñ€Ð¾Ð»Ñ Ð´Ð»Ñ ÑƒÑ‡ÐµÑ‚Ð½Ð¾Ð¹ Ð·Ð°Ð¿Ð¸ÑÐ¸ Roblox: {emailOrUsername}{lineBreak}{lineBreak}Ð•ÑÐ»Ð¸ Ð²Ñ‹ Ð´ÐµÐ¹ÑÑ‚Ð²Ð¸Ñ‚ÐµÐ»ÑŒÐ½Ð¾ ÑÐ´ÐµÐ»Ð°Ð»Ð¸ ÑÑ‚Ð¾Ñ‚ Ð·Ð°Ð¿Ñ€Ð¾Ñ, Ð¿Ð¾Ð¶Ð°Ð»ÑƒÐ¹ÑÑ‚Ð°, Ð¿Ñ€Ð¾Ð¹Ð´Ð¸Ñ‚Ðµ Ð¿Ð¾ ÑÑÑ‹Ð»ÐºÐµ Ð½Ð¸Ð¶Ðµ Ð¸Ð»Ð¸ ÑÐºÐ¾Ð¿Ð¸Ñ€ÑƒÐ¹Ñ‚Ðµ ÐµÐµ Ð² Ð±Ñ€Ð°ÑƒÐ·ÐµÑ€.{lineBreak}Ð­Ñ‚Ð° ÑÑÑ‹Ð»ÐºÐ° Ð±ÑƒÐ´ÐµÑ‚ Ð°ÐºÑ‚Ð¸Ð²Ð½Ð° Ð² Ñ‚ÐµÑ‡ÐµÐ½Ð¸Ðµ {passwordResetTicketHours} Ñ‡Ð°ÑÐ¾Ð², {passwordResetTicketMinutes} Ð¼Ð¸Ð½ÑƒÑ‚. ÐµÑÐ»Ð¸ Ð²Ñ‹ Ð½Ðµ Ð¶ÐµÐ»Ð°ÐµÑ‚Ðµ Ð¸Ð·Ð¼ÐµÐ½Ð¸Ñ‚ÑŒ ÑÐ²Ð¾Ð¹ Ð¿Ð°Ñ€Ð¾Ð»ÑŒ, Ð¿Ð¾Ð¶Ð°Ð»ÑƒÐ¹ÑÑ‚Ð°, Ð¸Ð³Ð½Ð¾Ñ€Ð¸Ñ€ÑƒÐ¹Ñ‚Ðµ ÑÑ‚Ð¾ ÑÐ¾Ð¾Ð±Ñ‰ÐµÐ½Ð¸Ðµ.{lineBreak}{lineBreak}{resetPasswordUrl}";
	}

	protected override string _GetTemplateForDescriptionPasswordResetEmailSubject()
	{
		return "Ð˜Ð·Ð¼ÐµÐ½ÐµÐ½Ð¸Ðµ Ð¿Ð°Ñ€Ð¾Ð»Ñ ÑƒÑ‡ÐµÑ‚Ð½Ð¾Ð¹ Ð·Ð°Ð¿Ð¸ÑÐ¸ Roblox";
	}

	protected override string _GetTemplateForDescriptionPhoneToResetPassword()
	{
		return "Ð’Ð²ÐµÐ´Ð¸Ñ‚Ðµ Ð½Ð¾Ð¼ÐµÑ€ Ñ‚ÐµÐ»ÐµÑ„Ð¾Ð½Ð°, Ñ‡Ñ‚Ð¾Ð±Ñ‹ ÑÐ±Ñ€Ð¾ÑÐ¸Ñ‚ÑŒ Ð¿Ð°Ñ€Ð¾Ð»ÑŒ.";
	}

	protected override string _GetTemplateForDescriptionPhoneToRetriveUsername()
	{
		return "Ð’Ð²ÐµÐ´Ð¸Ñ‚Ðµ Ð½Ð¾Ð¼ÐµÑ€ Ñ‚ÐµÐ»ÐµÑ„Ð¾Ð½Ð°, Ñ‡Ñ‚Ð¾Ð±Ñ‹ Ð²Ð¾ÑÑÑ‚Ð°Ð½Ð¾Ð²Ð¸Ñ‚ÑŒ ÑÐ²Ð¾Ðµ Ð¸Ð¼Ñ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ.";
	}

	protected override string _GetTemplateForHeadingVerifyCode()
	{
		return "ÐŸÐ¾Ð´Ñ‚Ð²ÐµÑ€Ð´Ð¸Ñ‚ÑŒ ÐºÐ¾Ð´";
	}

	protected override string _GetTemplateForHeadingVerifyPhone()
	{
		return "ÐŸÑ€Ð¾Ð²ÐµÑ€ÐºÐ° Ñ‚ÐµÐ»ÐµÑ„Ð¾Ð½Ð°";
	}

	protected override string _GetTemplateForHeadingForgetPasswordOrUsername()
	{
		return "Ð—Ð°Ð±Ñ‹Ñ‚ Ð¿Ð°Ñ€Ð¾Ð»ÑŒ Ð¸Ð»Ð¸ Ð¸Ð¼Ñ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ";
	}

	protected override string _GetTemplateForLabelActionButtonYes()
	{
		return "Ð”Ð°";
	}

	protected override string _GetTemplateForLabelForgetMyPassword()
	{
		return "ÐŸÐ°Ñ€Ð¾Ð»ÑŒ Ð·Ð°Ð±Ñ‹Ñ‚";
	}

	protected override string _GetTemplateForLabelForgetMyUsername()
	{
		return "Ð˜Ð¼Ñ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ Ð·Ð°Ð±Ñ‹Ñ‚Ð¾";
	}

	protected override string _GetTemplateForLabelInvalidEmail()
	{
		return "ÐÐµÐ´Ð¾Ð¿ÑƒÑÑ‚Ð¸Ð¼Ñ‹Ð¹ Ð°Ð´Ñ€ÐµÑ ÑÐ». Ð¿Ð¾Ñ‡Ñ‚Ñ‹";
	}

	protected override string _GetTemplateForLabelInvalidPhoneNumber()
	{
		return "ÐÐµÐ´Ð¾Ð¿ÑƒÑÑ‚Ð¸Ð¼Ñ‹Ð¹ Ð½Ð¾Ð¼ÐµÑ€ Ñ‚ÐµÐ»ÐµÑ„Ð¾Ð½Ð°";
	}

	protected override string _GetTemplateForLabelNeutralButtonOk()
	{
		return "ÐžÐš";
	}

	protected override string _GetTemplateForLabelPassword()
	{
		return "ÐŸÐ°Ñ€Ð¾Ð»ÑŒ";
	}

	protected override string _GetTemplateForLabelResendCode()
	{
		return "ÐžÑ‚Ð¿Ñ€Ð°Ð²Ð¸Ñ‚ÑŒ ÐºÐ¾Ð´ Ð·Ð°Ð½Ð¾Ð²Ð¾";
	}

	protected override string _GetTemplateForLabelSubmit()
	{
		return "ÐžÑ‚Ð¿Ñ€Ð°Ð²Ð¸Ñ‚ÑŒ";
	}

	protected override string _GetTemplateForLabelToolTipWhoCanFindMeByPhone()
	{
		return "Ð­Ñ‚Ð° Ð½Ð°ÑÑ‚Ñ€Ð¾Ð¹ÐºÐ° Ð¿Ð¾Ð·Ð²Ð¾Ð»ÑÐµÑ‚ ÑƒÐºÐ°Ð·Ð°Ñ‚ÑŒ, ÐºÑ‚Ð¾ Ð¼Ð¾Ð¶ÐµÑ‚ Ð½Ð°Ð¹Ñ‚Ð¸ Ð²Ð°Ñ Ð¿Ð¾ Ð½Ð¾Ð¼ÐµÑ€Ñƒ Ð²Ð°ÑˆÐµÐ³Ð¾ Ñ‚ÐµÐ»ÐµÑ„Ð¾Ð½Ð°.";
	}

	protected override string _GetTemplateForLabelUsername()
	{
		return "Ð˜Ð¼Ñ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ";
	}

	protected override string _GetTemplateForLabelWhoCanFindMeByPhone()
	{
		return "ÐšÑ‚Ð¾ Ð¼Ð¾Ð¶ÐµÑ‚ Ð½Ð°Ð¹Ñ‚Ð¸ Ð¼ÐµÐ½Ñ Ð¿Ð¾ Ð½Ð¾Ð¼ÐµÑ€Ñƒ Ñ‚ÐµÐ»ÐµÑ„Ð¾Ð½Ð°?";
	}

	/// <summary>
	/// Key: "Message.CantSendEmailWarning"
	/// English String: "If you did not give us a {styleStart}real email address{styleEnd} when you created your account, we cannot send you an email."
	/// </summary>
	public override string MessageCantSendEmailWarning(string styleStart, string styleEnd)
	{
		return $"Ð•ÑÐ»Ð¸ Ð²Ñ‹ Ð½Ðµ ÑƒÐºÐ°Ð·Ð°Ð»Ð¸ {styleStart}Ð½Ð°ÑÑ‚Ð¾ÑÑ‰Ð¸Ð¹ Ð°Ð´Ñ€ÐµÑ ÑÐ». Ð¿Ð¾Ñ‡Ñ‚Ñ‹{styleEnd} Ð¿Ñ€Ð¸ ÑÐ¾Ð·Ð´Ð°Ð½Ð¸Ð¸ ÑƒÑ‡ÐµÑ‚Ð½Ð¾Ð¹ Ð·Ð°Ð¿Ð¸ÑÐ¸, Ð¼Ñ‹ Ð½Ðµ ÑÐ¼Ð¾Ð¶ÐµÐ¼ Ð¾Ñ‚Ð¿Ñ€Ð°Ð²Ð¸Ñ‚ÑŒ Ð²Ð°Ð¼ ÑÐ¾Ð¾Ð±Ñ‰ÐµÐ½Ð¸Ðµ.";
	}

	protected override string _GetTemplateForMessageCantSendEmailWarning()
	{
		return "Ð•ÑÐ»Ð¸ Ð²Ñ‹ Ð½Ðµ ÑƒÐºÐ°Ð·Ð°Ð»Ð¸ {styleStart}Ð½Ð°ÑÑ‚Ð¾ÑÑ‰Ð¸Ð¹ Ð°Ð´Ñ€ÐµÑ ÑÐ». Ð¿Ð¾Ñ‡Ñ‚Ñ‹{styleEnd} Ð¿Ñ€Ð¸ ÑÐ¾Ð·Ð´Ð°Ð½Ð¸Ð¸ ÑƒÑ‡ÐµÑ‚Ð½Ð¾Ð¹ Ð·Ð°Ð¿Ð¸ÑÐ¸, Ð¼Ñ‹ Ð½Ðµ ÑÐ¼Ð¾Ð¶ÐµÐ¼ Ð¾Ñ‚Ð¿Ñ€Ð°Ð²Ð¸Ñ‚ÑŒ Ð²Ð°Ð¼ ÑÐ¾Ð¾Ð±Ñ‰ÐµÐ½Ð¸Ðµ.";
	}

	protected override string _GetTemplateForMessageDefaultError()
	{
		return "ÐŸÑ€Ð¾Ð¸Ð·Ð¾ÑˆÐ»Ð° Ð¾ÑˆÐ¸Ð±ÐºÐ°. ÐŸÐ¾Ð²Ñ‚Ð¾Ñ€Ð¸Ñ‚Ðµ Ð¿Ð¾Ð¿Ñ‹Ñ‚ÐºÑƒ Ð¿Ð¾Ð·Ð¶Ðµ.";
	}

	protected override string _GetTemplateForMessageEmailForUsernameSuccessBody()
	{
		return "Ð•ÑÐ»Ð¸ Ð²Ð°ÑˆÐ° ÑÐ». Ð¿Ð¾Ñ‡Ñ‚Ð° Ð±Ñ‹Ð»Ð° Ñ€Ð°Ð½ÐµÐµ Ð¿Ð¾Ð´Ñ‚Ð²ÐµÑ€Ð¶Ð´ÐµÐ½Ð° Ð² Ð²Ð°ÑˆÐµÐ¹ ÑƒÑ‡ÐµÑ‚Ð½Ð¾Ð¹ Ð·Ð°Ð¿Ð¸ÑÐ¸, Ñ‚Ð¾ Ð½Ð° ÐµÐµ Ð°Ð´Ñ€ÐµÑ Ð±Ñ‹Ð»Ð¾ Ð²Ñ‹ÑÐ»Ð°Ð½Ð¾ Ð²Ð°ÑˆÐµ Ð¸Ð¼Ñ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ.";
	}

	protected override string _GetTemplateForMessageEmailSuccessBody()
	{
		return "Ð•ÑÐ»Ð¸ Ð² Ð²Ð°ÑˆÐµÐ¹ ÑƒÑ‡ÐµÑ‚Ð½Ð¾Ð¹ Ð·Ð°Ð¿Ð¸ÑÐ¸ Ð±Ñ‹Ð»Ð° ÑÐ¾Ñ…Ñ€Ð°Ð½ÐµÐ½Ð° ÑÐ». Ð¿Ð¾Ñ‡Ñ‚Ð°, Ð½Ð° Ð½ÐµÐµ Ð±Ñ‹Ð»Ð¸ Ð¾Ñ‚Ð¿Ñ€Ð°Ð²Ð»ÐµÐ½Ñ‹ Ð¸Ð½ÑÑ‚Ñ€ÑƒÐºÑ†Ð¸Ð¸.";
	}

	protected override string _GetTemplateForMessageEmailSuccessTitle()
	{
		return "Ð¡Ð¾Ð¾Ð±Ñ‰ÐµÐ½Ð¸Ðµ Ð¾Ñ‚Ð¿Ñ€Ð°Ð²Ð»ÐµÐ½Ð¾";
	}

	protected override string _GetTemplateForMessageEnterCode()
	{
		return "Ð•ÑÐ»Ð¸ Ð²Ð°Ñˆ Ñ‚ÐµÐ»ÐµÑ„Ð¾Ð½ Ð±Ñ‹Ð» Ñ€Ð°Ð½ÐµÐµ Ð¿Ð¾Ð´Ñ‚Ð²ÐµÑ€Ð¶Ð´ÐµÐ½ Ð² Ð²Ð°ÑˆÐµÐ¹ ÑƒÑ‡ÐµÑ‚Ð½Ð¾Ð¹ Ð·Ð°Ð¿Ð¸ÑÐ¸, Ñ‚Ð¾ Ð½Ð° ÐµÐ³Ð¾ Ð½Ð¾Ð¼ÐµÑ€ Ð±Ñ‹Ð» Ð²Ñ‹ÑÐ»Ð°Ð½ ÐºÐ¾Ð´. ÐŸÐ¾Ð¶Ð°Ð»ÑƒÐ¹ÑÑ‚Ð°, Ð²Ð²ÐµÐ´Ð¸Ñ‚Ðµ ÐµÐ³Ð¾ Ð½Ð¸Ð¶Ðµ.";
	}

	protected override string _GetTemplateForMessageEnterCodeSentToEmail()
	{
		return "Ð’Ð²ÐµÐ´Ð¸Ñ‚Ðµ ÐºÐ¾Ð´, Ð¾Ñ‚Ð¿Ñ€Ð°Ð²Ð»ÐµÐ½Ð½Ñ‹Ð¹ Ð²Ð°Ð¼ Ð¿Ð¾ ÑÐ»ÐµÐºÑ‚Ñ€Ð¾Ð½Ð½Ð¾Ð¹ Ð¿Ð¾Ñ‡Ñ‚Ðµ.";
	}

	protected override string _GetTemplateForMessagePhoneForUsernameSuccessBody()
	{
		return "Ð¡ÐœÐ¡ Ñ Ð²Ð°ÑˆÐ¸Ð¼ Ð¸Ð¼ÐµÐ½ÐµÐ¼ (Ð¸Ð¼ÐµÐ½Ð°Ð¼Ð¸) Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ(-ÐµÐ¹) Ð±Ñ‹Ð»Ð¾ Ð¾Ñ‚Ð¿Ñ€Ð°Ð²Ð»ÐµÐ½Ð¾ Ð½Ð° Ñ‚ÐµÐ»ÐµÑ„Ð¾Ð½Ð½Ñ‹Ð¹ Ð½Ð¾Ð¼ÐµÑ€, ÐµÑÐ»Ð¸ Ð¾Ð½ Ð±Ñ‹Ð» Ð¿Ð¾Ð´Ñ‚Ð²ÐµÑ€Ð¶Ð´ÐµÐ½ Ð² Ð²Ð°ÑˆÐµÐ¹ ÑƒÑ‡ÐµÑ‚Ð½Ð¾Ð¹ Ð·Ð°Ð¿Ð¸ÑÐ¸.";
	}

	protected override string _GetTemplateForMessagePhoneForUsernameSuccessTitle()
	{
		return "Ð¡ÐœÐ¡ Ð¾Ñ‚Ð¿Ñ€Ð°Ð²Ð»ÐµÐ½Ð¾";
	}

	protected override string _GetTemplateForMessageAccountDoesNotHaveAnEmail()
	{
		return "Ðš ÑÑ‚Ð¾Ð¹ ÑƒÑ‡ÐµÑ‚Ð½Ð¾Ð¹ Ð·Ð°Ð¿Ð¸ÑÐ¸ Ð½Ðµ Ð¿Ñ€Ð¸ÐºÑ€ÐµÐ¿Ð»ÐµÐ½ Ð°Ð´Ñ€ÐµÑ ÑÐ». Ð¿Ð¾Ñ‡Ñ‚Ñ‹";
	}

	protected override string _GetTemplateForMessageAccountNotFoundByEmail()
	{
		return "Ð£Ñ‡ÐµÑ‚Ð½Ð°Ñ Ð·Ð°Ð¿Ð¸ÑÑŒ Ð½Ðµ Ð½Ð°Ð¹Ð´ÐµÐ½Ð°. Ð£ÐºÐ°Ð¶Ð¸Ñ‚Ðµ Ð´Ñ€ÑƒÐ³Ð¾Ð¹ Ð°Ð´Ñ€ÐµÑ ÑÐ». Ð¿Ð¾Ñ‡Ñ‚Ñ‹.";
	}

	protected override string _GetTemplateForMessageAccountNotFoundByPhone()
	{
		return "Ð£Ñ‡ÐµÑ‚Ð½Ð°Ñ Ð·Ð°Ð¿Ð¸ÑÑŒ Ð½Ðµ Ð½Ð°Ð¹Ð´ÐµÐ½Ð°. Ð£ÐºÐ°Ð¶Ð¸Ñ‚Ðµ Ð´Ñ€ÑƒÐ³Ð¾Ð¹ Ð½Ð¾Ð¼ÐµÑ€ Ñ‚ÐµÐ»ÐµÑ„Ð¾Ð½Ð°.";
	}

	protected override string _GetTemplateForMessageAccountRecoveryUnknownError()
	{
		return "ÐžÑˆÐ¸Ð±ÐºÐ° ÑÐ¸ÑÑ‚ÐµÐ¼Ñ‹. Ð£Ñ‡ÐµÑ‚Ð½ÑƒÑŽ Ð·Ð°Ð¿Ð¸ÑÑŒ Ð½ÐµÐ²Ð¾Ð·Ð¼Ð¾Ð¶Ð½Ð¾ Ð²Ð¾ÑÑÑ‚Ð°Ð½Ð¾Ð²Ð¸Ñ‚ÑŒ Ð´Ð¾ ÑÑ‚Ð¾Ð³Ð¾ ÑÐ¾ÑÑ‚Ð¾ÑÐ½Ð¸Ñ.";
	}

	protected override string _GetTemplateForMessageCaptchaError()
	{
		return "ÐÐ°Ð¼ Ð½ÐµÐ¾Ð±Ñ…Ð¾Ð´Ð¸Ð¼Ð¾ ÑƒÐ±ÐµÐ´Ð¸Ñ‚ÑŒÑÑ, Ñ‡Ñ‚Ð¾ Ð²Ñ‹ â€“ Ð½Ðµ Ñ€Ð¾Ð±Ð¾Ñ‚!";
	}

	protected override string _GetTemplateForMessageCaptchaFailError()
	{
		return "Ð’Ð²ÐµÐ´ÐµÐ½Ð½Ñ‹Ðµ Ð²Ð°Ð¼Ð¸ ÑÐ»Ð¾Ð²Ð° Ð½Ðµ ÑÐ¾Ð¾Ñ‚Ð²ÐµÑ‚ÑÑ‚Ð²ÑƒÑŽÑ‚ Ð¸Ð·Ð¾Ð±Ñ€Ð°Ð¶ÐµÐ½Ð¸ÑŽ. ÐŸÐ¾Ð²Ñ‚Ð¾Ñ€Ð¸Ñ‚Ðµ Ð¿Ð¾Ð¿Ñ‹Ñ‚ÐºÑƒ.";
	}

	protected override string _GetTemplateForMessageCredentialsError()
	{
		return "ÐÐµÐ¿Ñ€Ð°Ð²Ð¸Ð»ÑŒÐ½Ñ‹Ð¹ Ð¿Ð°Ñ€Ð¾Ð»ÑŒ Ð¸Ð»Ð¸ Ð¸Ð¼Ñ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ. ÐŸÑ€Ð¾Ð²ÐµÑ€ÑŒÑ‚Ðµ ÐµÑ‰Ðµ Ñ€Ð°Ð· Ð¸ Ð¿Ð¾Ð²Ñ‚Ð¾Ñ€Ð¸Ñ‚Ðµ Ð¿Ð¾Ð¿Ñ‹Ñ‚ÐºÑƒ.";
	}

	protected override string _GetTemplateForMessageFloodCheckedError()
	{
		return "Ð¡Ð»Ð¸ÑˆÐºÐ¾Ð¼ Ð¼Ð½Ð¾Ð³Ð¾ Ð¿Ð¾Ð¿Ñ‹Ñ‚Ð¾Ðº. ÐŸÐ¾Ð²Ñ‚Ð¾Ñ€Ð¸Ñ‚Ðµ Ð¿Ð¾Ð¿Ñ‹Ñ‚ÐºÑƒ Ð¿Ð¾Ð·Ð¶Ðµ.";
	}

	protected override string _GetTemplateForMessageForgotPasswordFeatureDisabled()
	{
		return "Ð¤ÑƒÐ½ÐºÑ†Ð¸Ñ Ð²Ñ€ÐµÐ¼ÐµÐ½Ð½Ð¾ Ð½ÐµÐ´Ð¾ÑÑ‚ÑƒÐ¿Ð½Ð°. ÐŸÐ¾Ð²Ñ‚Ð¾Ñ€Ð¸Ñ‚Ðµ Ð¿Ð¾Ð¿Ñ‹Ñ‚ÐºÑƒ Ð¿Ð¾Ð·Ð¶Ðµ.";
	}

	protected override string _GetTemplateForMessageForgotPasswordSuccess()
	{
		return "Ð˜Ð½ÑÑ‚Ñ€ÑƒÐºÑ†Ð¸Ð¸ Ð¿Ð¾ Ð²Ñ…Ð¾Ð´Ñƒ Ð¾Ñ‚Ð¿Ñ€Ð°Ð²Ð»ÐµÐ½Ñ‹ Ð²Ð°Ð¼ Ð¿Ð¾ ÑÐ»ÐµÐºÑ‚Ñ€Ð¾Ð½Ð½Ð¾Ð¹ Ð¿Ð¾Ñ‡Ñ‚Ðµ";
	}

	protected override string _GetTemplateForMessageInvalidAccountStatus()
	{
		return "Ð¡Ð¾ÑÑ‚Ð¾ÑÐ½Ð¸Ðµ ÑƒÑ‡ÐµÑ‚Ð½Ð¾Ð¹ Ð·Ð°Ð¿Ð¸ÑÐ¸ Ð·Ð°Ð¿Ñ€ÐµÑ‰Ð°ÐµÑ‚ ÑÐ±Ñ€Ð¾Ñ Ð¿Ð°Ñ€Ð¾Ð»Ñ";
	}

	protected override string _GetTemplateForMessageInvalidPassword()
	{
		return "ÐÐµÐ´Ð¾Ð¿ÑƒÑÑ‚Ð¸Ð¼Ñ‹Ð¹ Ð¿Ð°Ñ€Ð¾Ð»ÑŒ";
	}

	protected override string _GetTemplateForMessageInvalidTicket()
	{
		return "ÐÐµ ÑƒÐ´Ð°Ð»Ð¾ÑÑŒ Ð·Ð°Ð³Ñ€ÑƒÐ·Ð¸Ñ‚ÑŒ ÑÑ‚Ð¾Ñ‚ Ð±Ð¸Ð»ÐµÑ‚ Ð±ÐµÐ·Ð¾Ð¿Ð°ÑÐ½Ð¾ÑÑ‚Ð¸.";
	}

	protected override string _GetTemplateForMessageInvalidUserNameOrEmail()
	{
		return "ÐÐµÐ´Ð¾Ð¿ÑƒÑÑ‚Ð¸Ð¼Ð¾Ðµ Ð¸Ð¼Ñ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ Ð¸Ð»Ð¸ Ð½ÐµÑÑƒÑ‰ÐµÑÑ‚Ð²ÑƒÑŽÑ‰Ð¸Ð¹ Ð°Ð´Ñ€ÐµÑ ÑÐ». Ð¿Ð¾Ñ‡Ñ‚Ñ‹";
	}

	protected override string _GetTemplateForMessageMobileResetPasswordSuccess()
	{
		return "MobileResetPasswordSuccess";
	}

	protected override string _GetTemplateForMessageNoAccountsLinkedToEmail()
	{
		return "Ðš ÑÑ‚Ð¾Ð¼Ñƒ Ð°Ð´Ñ€ÐµÑÑƒ ÑÐ». Ð¿Ð¾Ñ‡Ñ‚Ñ‹ Ð½Ðµ Ð¿Ñ€Ð¸ÐºÑ€ÐµÐ¿Ð»ÐµÐ½Ð° ÑƒÑ‡ÐµÑ‚Ð½Ð°Ñ Ð·Ð°Ð¿Ð¸ÑÑŒ";
	}

	protected override string _GetTemplateForMessageOldUsernameError()
	{
		return "ÐŸÐ¾Ñ…Ð¾Ð¶Ðµ, Ð²Ñ‹ ÑƒÐºÐ°Ð·Ñ‹Ð²Ð°ÐµÑ‚Ðµ Ð¸Ð¼Ñ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ, ÐºÐ¾Ñ‚Ð¾Ñ€Ð¾Ðµ Ð±Ñ‹Ð»Ð¾ Ð¸Ð·Ð¼ÐµÐ½ÐµÐ½Ð¾. Ð’Ð¾Ð¹Ð´Ð¸Ñ‚Ðµ Ñ Ð½Ð¾Ð²Ñ‹Ð¼ Ð¸Ð¼ÐµÐ½ÐµÐ¼ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ.";
	}

	protected override string _GetTemplateForMessagePasswordCannotBeUsed()
	{
		return "Ðš ÑÐ¾Ð¶Ð°Ð»ÐµÐ½Ð¸ÑŽ, ÑÑ‚Ð¾Ñ‚ Ð¿Ð°Ñ€Ð¾Ð»ÑŒ Ð½ÐµÐ»ÑŒÐ·Ñ Ð¸ÑÐ¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÑŒ.";
	}

	/// <summary>
	/// Key: "MessagePasswordResetTicketExpired"
	/// English String: "Sorry, password reset requests expire {expirationHour} hours, {expirationMinute} minutes after issuance. Try requesting another password reset ticket again."
	/// </summary>
	public override string MessagePasswordResetTicketExpired(string expirationHour, string expirationMinute)
	{
		return $"Ðš ÑÐ¾Ð¶Ð°Ð»ÐµÐ½Ð¸ÑŽ, Ð·Ð°Ð¿Ñ€Ð¾ÑÑ‹ Ð½Ð° ÑÐ±Ñ€Ð¾Ñ Ð¿Ð°Ñ€Ð¾Ð»Ñ Ð¸ÑÑ‚ÐµÐºÐ°ÑŽÑ‚ Ñ‡ÐµÑ€ÐµÐ· {expirationHour} Ñ‡. {expirationMinute} Ð¼Ð¸Ð½. Ð¿Ð¾ÑÐ»Ðµ Ð¾Ñ‚Ð¿Ñ€Ð°Ð²ÐºÐ¸. Ð—Ð°Ð¿Ñ€Ð¾ÑÐ¸Ñ‚Ðµ Ð½Ð¾Ð²Ñ‹Ð¹ Ð±Ð¸Ð»ÐµÑ‚ Ð½Ð° ÑÐ±Ñ€Ð¾Ñ Ð¿Ð°Ñ€Ð¾Ð»Ñ.";
	}

	protected override string _GetTemplateForMessagePasswordResetTicketExpired()
	{
		return "Ðš ÑÐ¾Ð¶Ð°Ð»ÐµÐ½Ð¸ÑŽ, Ð·Ð°Ð¿Ñ€Ð¾ÑÑ‹ Ð½Ð° ÑÐ±Ñ€Ð¾Ñ Ð¿Ð°Ñ€Ð¾Ð»Ñ Ð¸ÑÑ‚ÐµÐºÐ°ÑŽÑ‚ Ñ‡ÐµÑ€ÐµÐ· {expirationHour} Ñ‡. {expirationMinute} Ð¼Ð¸Ð½. Ð¿Ð¾ÑÐ»Ðµ Ð¾Ñ‚Ð¿Ñ€Ð°Ð²ÐºÐ¸. Ð—Ð°Ð¿Ñ€Ð¾ÑÐ¸Ñ‚Ðµ Ð½Ð¾Ð²Ñ‹Ð¹ Ð±Ð¸Ð»ÐµÑ‚ Ð½Ð° ÑÐ±Ñ€Ð¾Ñ Ð¿Ð°Ñ€Ð¾Ð»Ñ.";
	}

	protected override string _GetTemplateForMessagePasswordsDoNotMatch()
	{
		return "ÐŸÐ°Ñ€Ð¾Ð»Ð¸ Ð½Ðµ ÑÐ¾Ð²Ð¿Ð°Ð´Ð°ÑŽÑ‚";
	}

	protected override string _GetTemplateForMessageSamlUnauthenticated()
	{
		return "ÐÐµÐ¾Ð±Ñ…Ð¾Ð´Ð¸Ð¼Ð¾ Ð²Ð¾Ð¹Ñ‚Ð¸ Ð² Roblox, Ñ‡Ñ‚Ð¾Ð±Ñ‹ Ð·Ð°Ð²ÐµÑ€ÑˆÐ¸Ñ‚ÑŒ Ð°ÑƒÑ‚ÐµÐ½Ñ‚Ð¸Ñ„Ð¸ÐºÐ°Ñ†Ð¸ÑŽ.";
	}

	protected override string _GetTemplateForMessageUnknownError()
	{
		return "ÐÐµÐ¸Ð·Ð²ÐµÑÑ‚Ð½Ð°Ñ Ð¾ÑˆÐ¸Ð±ÐºÐ°";
	}

	protected override string _GetTemplateForMessageUnknownSystemError()
	{
		return "ÐžÑˆÐ¸Ð±ÐºÐ° ÑÐ¸ÑÑ‚ÐµÐ¼Ñ‹. Ð’ÐµÑ€Ð½Ð¸Ñ‚ÐµÑÑŒ Ð½Ð° ÑÐºÑ€Ð°Ð½ Ð²Ñ…Ð¾Ð´Ð°.";
	}

	protected override string _GetTemplateForPlaceholderEmail()
	{
		return "Ð­Ð». Ð¿Ð¾Ñ‡Ñ‚Ð°";
	}

	/// <summary>
	/// Key: "Placeholder.EnterCode"
	/// English String: "Enter Code ({codeLength}-digit)"
	/// </summary>
	public override string PlaceholderEnterCode(string codeLength)
	{
		return $"Ð’Ð²ÐµÐ´Ð¸Ñ‚Ðµ ÐºÐ¾Ð´ (Ð¸Ð· {codeLength} Ñ†Ð¸Ñ„Ñ€)";
	}

	protected override string _GetTemplateForPlaceholderEnterCode()
	{
		return "Ð’Ð²ÐµÐ´Ð¸Ñ‚Ðµ ÐºÐ¾Ð´ (Ð¸Ð· {codeLength} Ñ†Ð¸Ñ„Ñ€)";
	}

	protected override string _GetTemplateForPlaceholderPhoneNumber()
	{
		return "ÐÐ¾Ð¼ÐµÑ€ Ñ‚ÐµÐ»ÐµÑ„Ð¾Ð½Ð°";
	}

	protected override string _GetTemplateForResponsePasswordResetSuccess()
	{
		return "ÐŸÐ°Ñ€Ð¾Ð»ÑŒ ÑÐ±Ñ€Ð¾ÑˆÐµÐ½! Ð’Ð¾Ð¹Ð´Ð¸Ñ‚Ðµ Ð² ÑƒÑ‡ÐµÑ‚Ð½ÑƒÑŽ Ð·Ð°Ð¿Ð¸ÑÑŒ Ð¿Ð¾Ð²Ñ‚Ð¾Ñ€Ð½Ð¾.";
	}

	protected override string _GetTemplateForResponseSuccess()
	{
		return "Ð£ÑÐ¿ÐµÑ…";
	}

	protected override string _GetTemplateForResponseUpdatePasswordFlooded()
	{
		return "Ð¡Ð»Ð¸ÑˆÐºÐ¾Ð¼ Ð¼Ð½Ð¾Ð³Ð¾ Ð¿Ð¾Ð¿Ñ‹Ñ‚Ð¾Ðº. ÐŸÐ¾Ð²Ñ‚Ð¾Ñ€Ð¸Ñ‚Ðµ Ð¿Ð¾Ð¿Ñ‹Ñ‚ÐºÑƒ Ð¿Ð¾Ð·Ð¶Ðµ.";
	}

	protected override string _GetTemplateForResponseUpdatePasswordIncorrect()
	{
		return "ÐÐµÐ¿Ñ€Ð°Ð²Ð¸Ð»ÑŒÐ½Ñ‹Ð¹ Ñ‚ÐµÐºÑƒÑ‰Ð¸Ð¹ Ð¿Ð°Ñ€Ð¾Ð»ÑŒ. ÐŸÐ°Ñ€Ð¾Ð»ÑŒ Ð½Ðµ Ð¸Ð·Ð¼ÐµÐ½ÐµÐ½.";
	}

	protected override string _GetTemplateForResponseUpdatePasswordInputMissing()
	{
		return "Ð¢Ñ€ÐµÐ±ÑƒÐµÑ‚ÑÑ ÑƒÐºÐ°Ð·Ð°Ñ‚ÑŒ Ð¸ Ð¿Ð¾Ð´Ñ‚Ð²ÐµÑ€Ð´Ð¸Ñ‚ÑŒ Ð½Ð¾Ð²Ñ‹Ð¹ Ð¿Ð°Ñ€Ð¾Ð»ÑŒ";
	}

	protected override string _GetTemplateForResponseUpdatePasswordMismatch()
	{
		return "Ð”Ð°Ð½Ð½Ñ‹Ðµ Ð² Ð¿Ð¾Ð»ÑÑ… Â«ÐÐ¾Ð²Ñ‹Ð¹ Ð¿Ð°Ñ€Ð¾Ð»ÑŒÂ» Ð¸ Â«ÐŸÐ¾Ð´Ñ‚Ð²ÐµÑ€Ð¶Ð´ÐµÐ½Ð¸Ðµ Ð¿Ð°Ñ€Ð¾Ð»ÑÂ» Ð´Ð¾Ð»Ð¶Ð½Ñ‹ ÑÐ¾Ð²Ð¿Ð°Ð´Ð°Ñ‚ÑŒ";
	}
}


}
