namespace Roblox.Platform.TranslationResources.Authentication {
    /// <summary>

/// This class overrides ResetPasswordResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ResetPasswordResources_th_th : ResetPasswordResources_en_us, IResetPasswordResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "à¸¢à¸à¹€à¸¥\u0e34à¸";

	/// <summary>
	/// Key: "Action.EmailToResetPassword"
	/// English String: "Use email to reset password"
	/// </summary>
	public override string ActionEmailToResetPassword => "à¹ƒà¸Š\u0e49à¸­\u0e35à¹€à¸¡à¸¥à¹€à¸ž\u0e37\u0e48à¸­à¸£\u0e35à¹€à¸‹\u0e47à¸•à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™";

	/// <summary>
	/// Key: "Action.EmailToRetriveUsername"
	/// English String: "Use email to retrieve username"
	/// </summary>
	public override string ActionEmailToRetriveUsername => "à¹ƒà¸Š\u0e49à¸­\u0e35à¹€à¸¡à¸¥à¹€à¸ž\u0e37\u0e48à¸­à¸£\u0e31à¸šà¸Š\u0e37\u0e48à¸­à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49";

	/// <summary>
	/// Key: "Action.Ok"
	/// OK
	/// English String: "OK"
	/// </summary>
	public override string ActionOk => "à¸•à¸à¸¥à¸‡";

	/// <summary>
	/// Key: "Action.PhoneToResetPassword"
	/// English String: "Use phone number to reset password"
	/// </summary>
	public override string ActionPhoneToResetPassword => "à¹ƒà¸Š\u0e49à¸«à¸¡à¸²à¸¢à¹€à¸¥à¸‚à¹‚à¸—à¸£à¸¨\u0e31à¸žà¸—\u0e4cà¹€à¸ž\u0e37\u0e48à¸­à¸£\u0e35à¹€à¸‹\u0e47à¸•à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™";

	/// <summary>
	/// Key: "Action.PhoneToRetriveUsername"
	/// English String: "Use phone number to retrieve username"
	/// </summary>
	public override string ActionPhoneToRetriveUsername => "à¹ƒà¸Š\u0e49à¸«à¸¡à¸²à¸¢à¹€à¸¥à¸‚à¹‚à¸—à¸£à¸¨\u0e31à¸žà¸—\u0e4cà¹€à¸ž\u0e37\u0e48à¸­à¸£\u0e31à¸šà¸Š\u0e37\u0e48à¸­à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49";

	/// <summary>
	/// Key: "Action.Verify"
	/// English String: "Verify"
	/// </summary>
	public override string ActionVerify => "à¸•à¸£à¸§à¸ˆà¸ªà¸­à¸š";

	/// <summary>
	/// Key: "Description.EmailToResetPassword"
	/// English String: "Enter your email to reset your password."
	/// </summary>
	public override string DescriptionEmailToResetPassword => "à¸›\u0e49à¸­à¸™à¸­\u0e35à¹€à¸¡à¸¥à¸‚à¸­à¸‡à¸„\u0e38à¸“à¹€à¸ž\u0e37\u0e48à¸­à¸£\u0e35à¹€à¸‹\u0e47à¸•à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™à¸‚à¸­à¸‡à¸„\u0e38à¸“";

	/// <summary>
	/// Key: "Description.EmailToRetriveUsername"
	/// English String: "Enter your email to retrieve your username."
	/// </summary>
	public override string DescriptionEmailToRetriveUsername => "à¸›\u0e49à¸­à¸™à¸­\u0e35à¹€à¸¡à¸¥à¸‚à¸­à¸‡à¸„\u0e38à¸“à¹€à¸ž\u0e37\u0e48à¸­à¸£\u0e31à¸šà¸Š\u0e37\u0e48à¸­à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49à¸‚à¸­à¸‡à¸„\u0e38à¸“";

	/// <summary>
	/// Key: "Description.PasswordChangeEmail.Subject"
	/// email subject to change password
	/// English String: "Roblox Password Reset"
	/// </summary>
	public override string DescriptionPasswordChangeEmailSubject => "à¸à¸²à¸£à¸£\u0e35à¹€à¸‹\u0e47à¸•à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™à¸š\u0e31à¸à¸Š\u0e35 Roblox";

	/// <summary>
	/// Key: "Description.PasswordResetEmail.Subject"
	/// Subject for password reset email
	/// English String: "Roblox Account Password Reset"
	/// </summary>
	public override string DescriptionPasswordResetEmailSubject => "à¸à¸²à¸£à¸£\u0e35à¹€à¸‹\u0e47à¸•à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™à¸š\u0e31à¸à¸Š\u0e35 Roblox";

	/// <summary>
	/// Key: "Description.PhoneToResetPassword"
	/// English String: "Enter your phone number to reset your password."
	/// </summary>
	public override string DescriptionPhoneToResetPassword => "à¸›\u0e49à¸­à¸™à¸«à¸¡à¸²à¸¢à¹€à¸¥à¸‚à¹‚à¸—à¸£à¸¨\u0e31à¸žà¸—\u0e4cà¸‚à¸­à¸‡à¸„\u0e38à¸“à¹€à¸ž\u0e37\u0e48à¸­à¸£\u0e35à¹€à¸‹\u0e47à¸•à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™à¸‚à¸­à¸‡à¸„\u0e38à¸“";

	/// <summary>
	/// Key: "Description.PhoneToRetriveUsername"
	/// English String: "Enter your phone number to retrieve your username."
	/// </summary>
	public override string DescriptionPhoneToRetriveUsername => "à¸›\u0e49à¸­à¸™à¸«à¸¡à¸²à¸¢à¹€à¸¥à¸‚à¹‚à¸—à¸£à¸¨\u0e31à¸žà¸—\u0e4cà¸‚à¸­à¸‡à¸„\u0e38à¸“à¹€à¸ž\u0e37\u0e48à¸­à¸£\u0e31à¸šà¸Š\u0e37\u0e48à¸­à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49à¸‚à¸­à¸‡à¸„\u0e38à¸“";

	/// <summary>
	/// Key: "Heading.VerifyCode"
	/// verify code heading
	/// English String: "Verify Code"
	/// </summary>
	public override string HeadingVerifyCode => "à¸•à¸£à¸§à¸ˆà¸ªà¸­à¸šà¸£à¸«\u0e31à¸ª";

	/// <summary>
	/// Key: "Heading.VerifyPhone"
	/// English String: "Verify Phone"
	/// </summary>
	public override string HeadingVerifyPhone => "à¸•à¸£à¸§à¸ˆà¸ªà¸­à¸šà¹‚à¸—à¸£à¸¨\u0e31à¸žà¸—\u0e4c";

	/// <summary>
	/// Key: "HeadingForgetPasswordOrUsername"
	/// English String: "Forgot Password or Username"
	/// </summary>
	public override string HeadingForgetPasswordOrUsername => "à¸¥\u0e37à¸¡à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™à¸«à¸£\u0e37à¸­à¸Š\u0e37\u0e48à¸­à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49";

	/// <summary>
	/// Key: "Label.ActionButtonYes"
	/// button label
	/// English String: "Yes"
	/// </summary>
	public override string LabelActionButtonYes => "à¹ƒà¸Š\u0e48";

	/// <summary>
	/// Key: "Label.ForgetMyPassword"
	/// English String: "Forgot My Password"
	/// </summary>
	public override string LabelForgetMyPassword => "à¸¥\u0e37à¸¡à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™à¸‚à¸­à¸‡à¸‰\u0e31à¸™";

	/// <summary>
	/// Key: "Label.ForgetMyUsername"
	/// English String: "Forgot My Username"
	/// </summary>
	public override string LabelForgetMyUsername => "à¸¥\u0e37à¸¡à¸Š\u0e37\u0e48à¸­à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49à¸‚à¸­à¸‡à¸‰\u0e31à¸™";

	/// <summary>
	/// Key: "Label.InvalidEmail"
	/// English String: "Invalid email"
	/// </summary>
	public override string LabelInvalidEmail => "à¸­\u0e35à¹€à¸¡à¸¥à¹„à¸¡\u0e48à¸–\u0e39à¸à¸•\u0e49à¸­à¸‡";

	/// <summary>
	/// Key: "Label.InvalidPhoneNumber"
	/// English String: "Invalid phone number"
	/// </summary>
	public override string LabelInvalidPhoneNumber => "à¸«à¸¡à¸²à¸¢à¹€à¸¥à¸‚à¹‚à¸—à¸£à¸¨\u0e31à¸žà¸—\u0e4cà¹„à¸¡\u0e48à¸–\u0e39à¸à¸•\u0e49à¸­à¸‡";

	/// <summary>
	/// Key: "Label.NeutralButtonOk"
	/// ok button label
	/// English String: "OK"
	/// </summary>
	public override string LabelNeutralButtonOk => "à¸•à¸à¸¥à¸‡";

	/// <summary>
	/// Key: "Label.Password"
	/// label
	/// English String: "Password"
	/// </summary>
	public override string LabelPassword => "à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™";

	/// <summary>
	/// Key: "Label.ResendCode"
	/// English String: "Resend Code"
	/// </summary>
	public override string LabelResendCode => "à¸ª\u0e48à¸‡à¸£à¸«\u0e31à¸ªà¹ƒà¸«à¸¡\u0e48";

	/// <summary>
	/// Key: "Label.Submit"
	/// English String: "Submit"
	/// </summary>
	public override string LabelSubmit => "à¸ª\u0e48à¸‡";

	/// <summary>
	/// Key: "Label.ToolTip.WhoCanFindMeByPhone"
	/// English String: "This setting controls who can find you using the phone number you provided."
	/// </summary>
	public override string LabelToolTipWhoCanFindMeByPhone => "à¸à¸²à¸£à¸•\u0e31\u0e49à¸‡à¸„\u0e48à¸²à¸™\u0e35\u0e49à¸„à¸§à¸šà¸„\u0e38à¸¡à¸§\u0e48à¸² à¹ƒà¸„à¸£à¸š\u0e49à¸²à¸‡à¸—\u0e35\u0e48à¸ˆà¸°à¸ªà¸²à¸¡à¸²à¸£à¸–à¸žà¸šà¸§\u0e48à¸²à¸„\u0e38à¸“à¹ƒà¸Š\u0e49à¸«à¸¡à¸²à¸¢à¹€à¸¥à¸‚à¹‚à¸—à¸£à¸¨\u0e31à¸žà¸—\u0e4cà¸—\u0e35\u0e48à¸„\u0e38à¸“à¹„à¸”\u0e49à¹à¸ˆ\u0e49à¸‡à¹„à¸§\u0e49";

	/// <summary>
	/// Key: "Label.Username"
	/// English String: "Username"
	/// </summary>
	public override string LabelUsername => "à¸Š\u0e37\u0e48à¸­à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49";

	/// <summary>
	/// Key: "Label.WhoCanFindMeByPhone"
	/// English String: "Who can find me by my phone number?"
	/// </summary>
	public override string LabelWhoCanFindMeByPhone => "à¹ƒà¸„à¸£à¸š\u0e49à¸²à¸‡à¸—\u0e35\u0e48à¸ªà¸²à¸¡à¸²à¸£à¸–à¸”\u0e39à¸«à¸¡à¸²à¸¢à¹€à¸¥à¸‚à¹‚à¸—à¸£à¸¨\u0e31à¸žà¸—\u0e4cà¸‚à¸­à¸‡à¸‰\u0e31à¸™à¹„à¸”\u0e49?";

	/// <summary>
	/// Key: "Message.DefaultError"
	/// English String: "An error occurred, try again later."
	/// </summary>
	public override string MessageDefaultError => "à¹€à¸\u0e34à¸”à¸‚\u0e49à¸­à¸œ\u0e34à¸”à¸žà¸¥à¸²à¸” à¸à¸£\u0e38à¸“à¸²à¸¥à¸­à¸‡à¹ƒà¸«à¸¡\u0e48à¸­\u0e35à¸à¸„à¸£\u0e31\u0e49à¸‡à¹ƒà¸™à¸ à¸²à¸¢à¸«à¸¥\u0e31à¸‡";

	/// <summary>
	/// Key: "Message.EmailForUsernameSuccessBody"
	/// success message
	/// English String: "An email with your username(s) has been sent to you if the email was previously saved on your account."
	/// </summary>
	public override string MessageEmailForUsernameSuccessBody => "à¸¡\u0e35à¸à¸²à¸£à¸ª\u0e48à¸‡à¸­\u0e35à¹€à¸¡à¸¥à¸žà¸£\u0e49à¸­à¸¡à¸Š\u0e37\u0e48à¸­à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49à¸‚à¸­à¸‡à¸„\u0e38à¸“à¹„à¸›à¹ƒà¸«\u0e49 à¸«à¸²à¸à¹„à¸”\u0e49à¸—à¸³à¸à¸²à¸£à¸š\u0e31à¸™à¸—\u0e36à¸à¸­\u0e35à¹€à¸¡à¸¥à¸‚à¸­à¸‡à¸„\u0e38à¸“à¹„à¸§\u0e49à¸ªà¸³à¸«à¸£\u0e31à¸šà¸š\u0e31à¸à¸Š\u0e35à¸™\u0e35\u0e49";

	/// <summary>
	/// Key: "Message.EmailSuccessBody"
	/// English String: "An email with instructions has been sent to you if the email was previously saved on your account."
	/// </summary>
	public override string MessageEmailSuccessBody => "à¸¡\u0e35à¸à¸²à¸£à¸ª\u0e48à¸‡à¸­\u0e35à¹€à¸¡à¸¥à¸žà¸£\u0e49à¸­à¸¡à¸‚\u0e31\u0e49à¸™à¸•à¸­à¸™à¹„à¸›à¹ƒà¸«\u0e49à¸„\u0e38à¸“ à¸«à¸²à¸à¹„à¸”\u0e49à¸—à¸³à¸à¸²à¸£à¸š\u0e31à¸™à¸—\u0e36à¸à¸­\u0e35à¹€à¸¡à¸¥à¸‚à¸­à¸‡à¸„\u0e38à¸“à¹„à¸§\u0e49à¸ªà¸³à¸«à¸£\u0e31à¸šà¸š\u0e31à¸à¸Š\u0e35à¸™\u0e35\u0e49";

	/// <summary>
	/// Key: "Message.EmailSuccessTitle"
	/// English String: "Email Sent"
	/// </summary>
	public override string MessageEmailSuccessTitle => "à¸ª\u0e48à¸‡à¸­\u0e35à¹€à¸¡à¸¥à¹à¸¥\u0e49à¸§";

	/// <summary>
	/// Key: "Message.EnterCode"
	/// English String: "A code was sent to your phone if it was previously verified on your account. Please enter it below"
	/// </summary>
	public override string MessageEnterCode => "à¹„à¸”\u0e49à¸¡\u0e35à¸à¸²à¸£à¸ª\u0e48à¸‡à¸£à¸«\u0e31à¸ªà¹„à¸›à¸¢\u0e31à¸‡à¹‚à¸—à¸£à¸¨\u0e31à¸žà¸—\u0e4cà¸‚à¸­à¸‡à¸„\u0e38à¸“à¸«à¸²à¸à¸„\u0e38à¸“à¹„à¸”\u0e49à¸¢\u0e37à¸™à¸¢\u0e31à¸™à¹‚à¸—à¸£à¸¨\u0e31à¸žà¸—\u0e4cà¸‚à¸­à¸‡à¸„\u0e38à¸“à¹„à¸§\u0e49à¸ªà¸³à¸«à¸£\u0e31à¸šà¸š\u0e31à¸à¸Š\u0e35à¸™\u0e35\u0e49 à¸à¸£\u0e38à¸“à¸²à¸›\u0e49à¸­à¸™à¸£à¸«\u0e31à¸ªà¸”\u0e49à¸²à¸™à¸¥\u0e48à¸²à¸‡à¸™\u0e35\u0e49";

	/// <summary>
	/// Key: "Message.EnterCodeSentToEmail"
	/// Enter the code we just sent to your email.
	/// English String: "Enter the code we just sent to your email."
	/// </summary>
	public override string MessageEnterCodeSentToEmail => "à¸›\u0e49à¸­à¸™à¸£à¸«\u0e31à¸ªà¸—\u0e35\u0e48à¹€à¸£à¸²à¹€à¸ž\u0e34\u0e48à¸‡à¸ª\u0e48à¸‡à¹ƒà¸«\u0e49à¸„\u0e38à¸“à¸—à¸²à¸‡à¸­\u0e35à¹€à¸¡à¸¥";

	/// <summary>
	/// Key: "Message.PhoneForUsernameSuccessBody"
	/// English String: "An SMS with your username(s) has been sent to you if the phone number was previously verified on your account."
	/// </summary>
	public override string MessagePhoneForUsernameSuccessBody => "à¸¡\u0e35à¸à¸²à¸£à¸ª\u0e48à¸‡ SMS à¸žà¸£\u0e49à¸­à¸¡à¸Š\u0e37\u0e48à¸­à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49à¸‚à¸­à¸‡à¸„\u0e38à¸“à¹„à¸›à¹ƒà¸«\u0e49 à¸«à¸²à¸à¹„à¸”\u0e49à¸—à¸³à¸à¸²à¸£à¸¢\u0e37à¸™à¸¢\u0e31à¸™à¸«à¸¡à¸²à¸¢à¹€à¸¥à¸‚à¹‚à¸—à¸£à¸¨\u0e31à¸žà¸—\u0e4cà¹„à¸§\u0e49à¸ªà¸³à¸«à¸£\u0e31à¸šà¸š\u0e31à¸à¸Š\u0e35à¸‚à¸­à¸‡à¸„\u0e38à¸“à¸\u0e48à¸­à¸™à¸«à¸™\u0e49à¸²à¸™\u0e35\u0e49";

	/// <summary>
	/// Key: "Message.PhoneForUsernameSuccessTitle"
	/// English String: "SMS Sent"
	/// </summary>
	public override string MessagePhoneForUsernameSuccessTitle => "à¸ª\u0e48à¸‡ SMS à¹à¸¥\u0e49à¸§";

	/// <summary>
	/// Key: "MessageAccountDoesNotHaveAnEmail"
	/// English String: "There is no email linked to this account"
	/// </summary>
	public override string MessageAccountDoesNotHaveAnEmail => "à¹„à¸¡\u0e48à¸¡\u0e35à¸­\u0e35à¹€à¸¡à¸¥à¸—\u0e35\u0e48à¹€à¸Š\u0e37\u0e48à¸­à¸¡à¹‚à¸¢à¸‡à¸­à¸¢\u0e39\u0e48à¸\u0e31à¸šà¸š\u0e31à¸à¸Š\u0e35à¸™\u0e35\u0e49";

	/// <summary>
	/// Key: "MessageAccountNotFoundByEmail"
	/// No account found. Please use a different email.
	/// English String: "No account found. Please use a different email."
	/// </summary>
	public override string MessageAccountNotFoundByEmail => "à¹„à¸¡\u0e48à¸žà¸šà¸š\u0e31à¸à¸Š\u0e35 à¸à¸£\u0e38à¸“à¸²à¸£à¸°à¸š\u0e38à¸­\u0e35à¹€à¸¡à¸¥à¸­\u0e37\u0e48à¸™";

	/// <summary>
	/// Key: "MessageAccountNotFoundByPhone"
	/// No account found. Please use a different phone number.
	/// English String: "No account found. Please use a different phone number."
	/// </summary>
	public override string MessageAccountNotFoundByPhone => "à¹„à¸¡\u0e48à¸žà¸šà¸š\u0e31à¸à¸Š\u0e35 à¸à¸£\u0e38à¸“à¸²à¸£à¸°à¸š\u0e38à¸«à¸¡à¸²à¸¢à¹€à¸¥à¸‚à¹‚à¸—à¸£à¸¨\u0e31à¸žà¸—\u0e4cà¸­\u0e37\u0e48à¸™";

	/// <summary>
	/// Key: "MessageAccountRecoveryUnknownError"
	/// English String: "System error. Account could not be restored to this state."
	/// </summary>
	public override string MessageAccountRecoveryUnknownError => "à¹€à¸\u0e34à¸”à¸‚\u0e49à¸­à¸œ\u0e34à¸”à¸žà¸¥à¸²à¸”à¸\u0e31à¸šà¸£à¸°à¸šà¸š à¹„à¸¡\u0e48à¸ªà¸²à¸¡à¸²à¸£à¸–à¸\u0e39\u0e49à¸„\u0e37à¸™à¸š\u0e31à¸à¸Š\u0e35à¸à¸¥\u0e31à¸šà¸¡à¸²à¸ª\u0e39\u0e48à¸ªà¸–à¸²à¸™à¸°à¸™\u0e35\u0e49à¹„à¸”\u0e49";

	/// <summary>
	/// Key: "MessageCaptchaError"
	/// English String: "We need to make sure you're not a robot!"
	/// </summary>
	public override string MessageCaptchaError => "à¹€à¸£à¸²à¸ˆà¸³à¹€à¸›\u0e47à¸™à¸•\u0e49à¸­à¸‡à¸•à¸£à¸§à¸ˆà¸ªà¸­à¸šà¹ƒà¸«\u0e49à¹à¸™\u0e48à¹ƒà¸ˆà¸§\u0e48à¸²à¸„\u0e38à¸“à¹„à¸¡\u0e48à¹ƒà¸Š\u0e48à¸«\u0e38\u0e48à¸™à¸¢à¸™à¸•\u0e4c!";

	/// <summary>
	/// Key: "MessageCaptchaFailError"
	/// English String: "The words you typed didn't match the picture. Please try again."
	/// </summary>
	public override string MessageCaptchaFailError => "à¸„à¸³à¸—\u0e35\u0e48à¸„\u0e38à¸“à¸ž\u0e34à¸¡à¸ž\u0e4cà¹„à¸¡\u0e48à¸•à¸£à¸‡à¸\u0e31à¸šà¸ à¸²à¸ž à¸à¸£\u0e38à¸“à¸²à¸¥à¸­à¸‡à¹ƒà¸«à¸¡\u0e48à¸­\u0e35à¸à¸„à¸£\u0e31\u0e49à¸‡";

	/// <summary>
	/// Key: "MessageCredentialsError"
	/// English String: "Your username or password is incorrect. Please check them and try again."
	/// </summary>
	public override string MessageCredentialsError => "à¸Š\u0e37\u0e48à¸­à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49à¸«à¸£\u0e37à¸­à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™à¸‚à¸­à¸‡à¸„\u0e38à¸“à¹„à¸¡\u0e48à¸–\u0e39à¸à¸•\u0e49à¸­à¸‡ à¸à¸£\u0e38à¸“à¸²à¸•à¸£à¸§à¸ˆà¸ªà¸­à¸šà¹à¸¥\u0e49à¸§à¸¥à¸­à¸‡à¹ƒà¸«à¸¡\u0e48à¸­\u0e35à¸à¸„à¸£\u0e31\u0e49à¸‡";

	/// <summary>
	/// Key: "MessageFloodCheckedError"
	/// English String: "Too many attempts. Please try again later."
	/// </summary>
	public override string MessageFloodCheckedError => "à¸¡\u0e35à¸à¸²à¸£à¸”à¸³à¹€à¸™\u0e34à¸™à¸à¸²à¸£à¸‹\u0e49à¸³à¸¡à¸²à¸à¹€à¸\u0e34à¸™à¹„à¸› à¸à¸£\u0e38à¸“à¸²à¸¥à¸­à¸‡à¹ƒà¸«à¸¡\u0e48à¸­\u0e35à¸à¸„à¸£\u0e31\u0e49à¸‡à¹ƒà¸™à¸ à¸²à¸¢à¸«à¸¥\u0e31à¸‡";

	/// <summary>
	/// Key: "MessageForgotPasswordFeatureDisabled"
	/// English String: "Feature temporarily disabled. Please try again later."
	/// </summary>
	public override string MessageForgotPasswordFeatureDisabled => "à¸„\u0e38à¸“à¸¥\u0e31à¸à¸©à¸“à¸°à¸–\u0e39à¸à¸›\u0e34à¸”à¸à¸²à¸£à¹ƒà¸Š\u0e49à¸‡à¸²à¸™à¸Š\u0e31\u0e48à¸§à¸„à¸£à¸²à¸§ à¸à¸£\u0e38à¸“à¸²à¸¥à¸­à¸‡à¹ƒà¸«à¸¡\u0e48à¸­\u0e35à¸à¸„à¸£\u0e31\u0e49à¸‡";

	/// <summary>
	/// Key: "MessageForgotPasswordSuccess"
	/// English String: "Check your email for login instructions"
	/// </summary>
	public override string MessageForgotPasswordSuccess => "à¸•à¸£à¸§à¸ˆà¸ªà¸­à¸šà¸­\u0e35à¹€à¸¡à¸¥à¹€à¸ž\u0e37\u0e48à¸­à¸”\u0e39à¸„à¸³à¹à¸™à¸°à¸™à¸³à¸à¸²à¸£à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸£à¸°à¸šà¸š";

	/// <summary>
	/// Key: "MessageInvalidAccountStatus"
	/// English String: "Account status prevents resetting password"
	/// </summary>
	public override string MessageInvalidAccountStatus => "à¸ªà¸–à¸²à¸™à¸°à¸š\u0e31à¸à¸Š\u0e35à¸‚\u0e31à¸”à¸‚à¸§à¸²à¸‡à¹„à¸¡\u0e48à¹ƒà¸«\u0e49à¸—à¸³à¸à¸²à¸£à¸£\u0e35à¹€à¸‹\u0e47à¸•à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™";

	/// <summary>
	/// Key: "MessageInvalidPassword"
	/// English String: "Invalid password"
	/// </summary>
	public override string MessageInvalidPassword => "à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™à¹„à¸¡\u0e48à¸–\u0e39à¸à¸•\u0e49à¸­à¸‡";

	/// <summary>
	/// Key: "MessageInvalidTicket"
	/// English String: "We couldn't load this security ticket."
	/// </summary>
	public override string MessageInvalidTicket => "à¹€à¸£à¸²à¹„à¸¡\u0e48à¸ªà¸²à¸¡à¸²à¸£à¸–à¹‚à¸«à¸¥à¸”à¸•\u0e31\u0e4bà¸§à¸£\u0e31à¸à¸©à¸²à¸„à¸§à¸²à¸¡à¸›à¸¥à¸­à¸”à¸ \u0e31à¸¢à¸™\u0e35\u0e49à¹„à¸”\u0e49";

	/// <summary>
	/// Key: "MessageInvalidUserNameOrEmail"
	/// English String: "Invalid username, or no email exists"
	/// </summary>
	public override string MessageInvalidUserNameOrEmail => "à¸Š\u0e37\u0e48à¸­à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49à¹„à¸¡\u0e48à¸–\u0e39à¸à¸•\u0e49à¸­à¸‡à¸«à¸£\u0e37à¸­à¹„à¸¡\u0e48à¸¡\u0e35à¸­\u0e35à¹€à¸¡à¸¥à¸™\u0e31\u0e49à¸™à¸­à¸¢\u0e39\u0e48";

	/// <summary>
	/// Key: "MessageMobileResetPasswordSuccess"
	/// English String: "MobileResetPasswordSuccess"
	/// </summary>
	public override string MessageMobileResetPasswordSuccess => "MobileResetPasswordSuccess";

	/// <summary>
	/// Key: "MessageNoAccountsLinkedToEmail"
	/// English String: "There are no accounts linked to this email address"
	/// </summary>
	public override string MessageNoAccountsLinkedToEmail => "à¹„à¸¡\u0e48à¸¡\u0e35à¸š\u0e31à¸à¸Š\u0e35à¸—\u0e35\u0e48à¹€à¸Š\u0e37\u0e48à¸­à¸¡à¹‚à¸¢à¸‡à¸­à¸¢\u0e39\u0e48à¸\u0e31à¸šà¸—\u0e35\u0e48à¸­à¸¢\u0e39\u0e48à¸­\u0e35à¹€à¸¡à¸¥à¸™\u0e35\u0e49";

	/// <summary>
	/// Key: "MessageOldUsernameError"
	/// English String: "It looks like you are trying to log in with a username that has changed. Please log in with your new username."
	/// </summary>
	public override string MessageOldUsernameError => "à¸”\u0e39à¹€à¸«à¸¡\u0e37à¸­à¸™à¸§\u0e48à¸²à¸„\u0e38à¸“à¸žà¸¢à¸²à¸¢à¸²à¸¡à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸£à¸°à¸šà¸šà¸”\u0e49à¸§à¸¢à¸Š\u0e37\u0e48à¸­à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49à¸—\u0e35\u0e48à¸¡\u0e35à¸à¸²à¸£à¹€à¸›à¸¥\u0e35\u0e48à¸¢à¸™à¹à¸›à¸¥à¸‡à¹„à¸›à¹à¸¥\u0e49à¸§ à¸à¸£\u0e38à¸“à¸²à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸£à¸°à¸šà¸šà¸”\u0e49à¸§à¸¢à¸Š\u0e37\u0e48à¸­à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49à¹ƒà¸«à¸¡\u0e48à¸‚à¸­à¸‡à¸„\u0e38à¸“";

	/// <summary>
	/// Key: "MessagePasswordCannotBeUsed"
	/// English String: "Sorry, that password cannot be used."
	/// </summary>
	public override string MessagePasswordCannotBeUsed => "à¸‚à¸­à¸­à¸ \u0e31à¸¢ à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™à¸™\u0e31\u0e49à¸™à¹„à¸¡\u0e48à¸ªà¸²à¸¡à¸²à¸£à¸–à¹ƒà¸Š\u0e49à¸‡à¸²à¸™à¹„à¸”\u0e49";

	/// <summary>
	/// Key: "MessagePasswordsDoNotMatch"
	/// English String: "Passwords do not match"
	/// </summary>
	public override string MessagePasswordsDoNotMatch => "à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™à¹„à¸¡\u0e48à¸•à¸£à¸‡à¸\u0e31à¸™";

	/// <summary>
	/// Key: "MessageSamlUnauthenticated"
	/// English String: "You must log in to Roblox to finish authenticating."
	/// </summary>
	public override string MessageSamlUnauthenticated => "à¸„\u0e38à¸“à¸ˆà¸°à¸•\u0e49à¸­à¸‡à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸£à¸°à¸šà¸š Roblox à¹€à¸ž\u0e37\u0e48à¸­à¸ˆà¸šà¸‚\u0e31\u0e49à¸™à¸•à¸­à¸™à¸à¸²à¸£à¸•à¸£à¸§à¸ˆà¸ªà¸­à¸šà¸„à¸§à¸²à¸¡à¸–\u0e39à¸à¸•\u0e49à¸­à¸‡";

	/// <summary>
	/// Key: "MessageUnknownError"
	/// English String: "Unknown Error"
	/// </summary>
	public override string MessageUnknownError => "à¸‚\u0e49à¸­à¸œ\u0e34à¸”à¸žà¸¥à¸²à¸”à¸—\u0e35\u0e48à¹„à¸¡\u0e48à¸—à¸£à¸²à¸šà¸ªà¸²à¹€à¸«à¸•\u0e38";

	/// <summary>
	/// Key: "MessageUnknownSystemError"
	/// English String: "System error. Please return to login screen."
	/// </summary>
	public override string MessageUnknownSystemError => "à¹€à¸\u0e34à¸”à¸‚\u0e49à¸­à¸œ\u0e34à¸”à¸žà¸¥à¸²à¸”à¸\u0e31à¸šà¸£à¸°à¸šà¸š à¸à¸£\u0e38à¸“à¸²à¸à¸¥\u0e31à¸šà¸ª\u0e39\u0e48à¸«à¸™\u0e49à¸²à¸à¸²à¸£à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸£à¸°à¸šà¸š";

	/// <summary>
	/// Key: "Placeholder.Email"
	/// English String: "Email"
	/// </summary>
	public override string PlaceholderEmail => "à¸­\u0e35à¹€à¸¡à¸¥";

	/// <summary>
	/// Key: "Placeholder.PhoneNumber"
	/// English String: "Phone Number"
	/// </summary>
	public override string PlaceholderPhoneNumber => "à¸«à¸¡à¸²à¸¢à¹€à¸¥à¸‚à¹‚à¸—à¸£à¸¨\u0e31à¸žà¸—\u0e4c";

	/// <summary>
	/// Key: "Response.PasswordResetSuccess"
	/// Password reset success! Please login again.
	/// English String: "Password reset success! Please login again."
	/// </summary>
	public override string ResponsePasswordResetSuccess => "à¸£\u0e35à¹€à¸‹\u0e47à¸•à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™à¸ªà¸³à¹€à¸£\u0e47à¸ˆ! à¸à¸£\u0e38à¸“à¸²à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸£à¸°à¸šà¸šà¹ƒà¸«à¸¡\u0e48à¸­\u0e35à¸à¸„à¸£\u0e31\u0e49à¸‡";

	/// <summary>
	/// Key: "Response.Success"
	/// English String: "Success"
	/// </summary>
	public override string ResponseSuccess => "à¸ªà¸³à¹€à¸£\u0e47à¸ˆ";

	/// <summary>
	/// Key: "Response.UpdatePasswordFlooded"
	/// English String: "Too many attempts. Please try again later."
	/// </summary>
	public override string ResponseUpdatePasswordFlooded => "à¸¡\u0e35à¸à¸²à¸£à¸”à¸³à¹€à¸™\u0e34à¸™à¸à¸²à¸£à¸‹\u0e49à¸³à¸¡à¸²à¸à¹€à¸\u0e34à¸™à¹„à¸› à¸à¸£\u0e38à¸“à¸²à¸¥à¸­à¸‡à¹ƒà¸«à¸¡\u0e48à¸­\u0e35à¸à¸„à¸£\u0e31\u0e49à¸‡à¹ƒà¸™à¸ à¸²à¸¢à¸«à¸¥\u0e31à¸‡";

	/// <summary>
	/// Key: "Response.UpdatePasswordIncorrect"
	/// English String: "Your current password is incorrect, the password was not changed."
	/// </summary>
	public override string ResponseUpdatePasswordIncorrect => "à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™à¹ƒà¸™à¸›\u0e31à¸ˆà¸ˆ\u0e38à¸š\u0e31à¸™à¸‚à¸­à¸‡à¸„\u0e38à¸“à¹„à¸¡\u0e48à¸–\u0e39à¸à¸•\u0e49à¸­à¸‡ à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™à¹„à¸¡\u0e48à¸–\u0e39à¸à¹€à¸›à¸¥\u0e35\u0e48à¸¢à¸™";

	/// <summary>
	/// Key: "Response.UpdatePasswordInputMissing"
	/// English String: "Must include new password and confirm password"
	/// </summary>
	public override string ResponseUpdatePasswordInputMissing => "à¸ˆà¸°à¸•\u0e49à¸­à¸‡à¸›\u0e49à¸­à¸™à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™à¹ƒà¸«à¸¡\u0e48à¹à¸¥à¸°à¸¢\u0e37à¸™à¸¢\u0e31à¸™à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™";

	/// <summary>
	/// Key: "Response.UpdatePasswordMismatch"
	/// English String: "Your new password and confirm password must match"
	/// </summary>
	public override string ResponseUpdatePasswordMismatch => "à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™à¹ƒà¸«à¸¡\u0e48à¹à¸¥à¸°à¸¢\u0e37à¸™à¸¢\u0e31à¸™à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™à¸ˆà¸°à¸•\u0e49à¸­à¸‡à¸•à¸£à¸‡à¸\u0e31à¸™";

	public ResetPasswordResources_th_th(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "à¸¢à¸à¹€à¸¥\u0e34à¸";
	}

	protected override string _GetTemplateForActionEmailToResetPassword()
	{
		return "à¹ƒà¸Š\u0e49à¸­\u0e35à¹€à¸¡à¸¥à¹€à¸ž\u0e37\u0e48à¸­à¸£\u0e35à¹€à¸‹\u0e47à¸•à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™";
	}

	protected override string _GetTemplateForActionEmailToRetriveUsername()
	{
		return "à¹ƒà¸Š\u0e49à¸­\u0e35à¹€à¸¡à¸¥à¹€à¸ž\u0e37\u0e48à¸­à¸£\u0e31à¸šà¸Š\u0e37\u0e48à¸­à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49";
	}

	protected override string _GetTemplateForActionOk()
	{
		return "à¸•à¸à¸¥à¸‡";
	}

	protected override string _GetTemplateForActionPhoneToResetPassword()
	{
		return "à¹ƒà¸Š\u0e49à¸«à¸¡à¸²à¸¢à¹€à¸¥à¸‚à¹‚à¸—à¸£à¸¨\u0e31à¸žà¸—\u0e4cà¹€à¸ž\u0e37\u0e48à¸­à¸£\u0e35à¹€à¸‹\u0e47à¸•à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™";
	}

	protected override string _GetTemplateForActionPhoneToRetriveUsername()
	{
		return "à¹ƒà¸Š\u0e49à¸«à¸¡à¸²à¸¢à¹€à¸¥à¸‚à¹‚à¸—à¸£à¸¨\u0e31à¸žà¸—\u0e4cà¹€à¸ž\u0e37\u0e48à¸­à¸£\u0e31à¸šà¸Š\u0e37\u0e48à¸­à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49";
	}

	protected override string _GetTemplateForActionVerify()
	{
		return "à¸•à¸£à¸§à¸ˆà¸ªà¸­à¸š";
	}

	/// <summary>
	/// Key: "Description.ChangePasswordEmail.HtmlBody1"
	/// email body for change password email
	/// English String: "We noticed that the password changed for your Roblox account: {userName}. If you didn't intend to change it, or you think someone else changed it by mistake, please click this link to undo the action:{lineBreak} {actionLink} {lineBreak}{lineBreak}If you are happy with your new Roblox password, you don't have to do anything! It's already set up. Please do not reply to this message. If you have any questions, please see the Roblox help page (https://www.roblox.com/help)."
	/// </summary>
	public override string DescriptionChangePasswordEmailHtmlBody1(string userName, string lineBreak, string actionLink)
	{
		return $"à¹€à¸£à¸²à¸ª\u0e31à¸‡à¹€à¸à¸•à¹€à¸«\u0e47à¸™à¸§\u0e48à¸²à¸¡\u0e35à¸à¸²à¸£à¹€à¸›à¸¥\u0e35\u0e48à¸¢à¸™à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™à¸š\u0e31à¸à¸Š\u0e35 Roblox à¸‚à¸­à¸‡à¸„\u0e38à¸“: {userName} à¸«à¸²à¸à¸„\u0e38à¸“à¹„à¸¡\u0e48à¹„à¸”\u0e49à¸•\u0e31\u0e49à¸‡à¹ƒà¸ˆà¹€à¸›à¸¥\u0e35\u0e48à¸¢à¸™ à¸«à¸£\u0e37à¸­à¸„\u0e38à¸“à¸„\u0e34à¸”à¸§\u0e48à¸²à¹€à¸›\u0e47à¸™à¹€à¸«à¸•\u0e38à¸œ\u0e34à¸”à¸žà¸¥à¸²à¸”à¸ˆà¸²à¸à¸à¸²à¸£à¸—\u0e35\u0e48à¸¡\u0e35à¸„à¸™à¸­\u0e37\u0e48à¸™à¸¡à¸²à¹€à¸›à¸¥\u0e35\u0e48à¸¢à¸™ à¸à¸£\u0e38à¸“à¸²à¸„à¸¥\u0e34à¸à¸—\u0e35\u0e48à¸¥\u0e34à¸‡à¸\u0e4cà¸™\u0e35\u0e49à¹€à¸ž\u0e37\u0e48à¸­à¸¢à¸à¹€à¸¥\u0e34à¸à¸à¸²à¸£à¹€à¸›à¸¥\u0e35\u0e48à¸¢à¸™à¸™\u0e31\u0e49à¸™:{lineBreak} {actionLink} {lineBreak}{lineBreak}à¸«à¸²à¸à¸„\u0e38à¸“à¸žà¸­à¹ƒà¸ˆà¸\u0e31à¸šà¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™à¸š\u0e31à¸à¸Š\u0e35 Roblox à¹ƒà¸«à¸¡\u0e48à¸‚à¸­à¸‡à¸„\u0e38à¸“ à¸„\u0e38à¸“à¸\u0e47à¹„à¸¡\u0e48à¸ˆà¸³à¹€à¸›\u0e47à¸™à¸•\u0e49à¸­à¸‡à¸”à¸³à¹€à¸™\u0e34à¸™à¸à¸²à¸£à¹ƒà¸”à¹† à¹€à¸¥à¸¢! à¸¡\u0e31à¸™à¸žà¸£\u0e49à¸­à¸¡à¹ƒà¸Š\u0e49à¸‡à¸²à¸™à¹à¸¥\u0e49à¸§ à¹‚à¸›à¸£à¸”à¸­à¸¢\u0e48à¸²à¸•à¸­à¸šà¸à¸¥\u0e31à¸šà¸‚\u0e49à¸­à¸„à¸§à¸²à¸¡à¸™\u0e35\u0e49 à¸«à¸²à¸à¸„\u0e38à¸“à¸¡\u0e35à¸„à¸³à¸–à¸²à¸¡à¹ƒà¸”à¹† à¸à¸£\u0e38à¸“à¸²à¸”\u0e39à¸—\u0e35\u0e48à¸«à¸™\u0e49à¸²à¹€à¸žà¸ˆà¸Š\u0e48à¸§à¸¢à¹€à¸«à¸¥\u0e37à¸­à¸‚à¸­à¸‡ Roblox (https://www.roblox.com/help)";
	}

	protected override string _GetTemplateForDescriptionChangePasswordEmailHtmlBody1()
	{
		return "à¹€à¸£à¸²à¸ª\u0e31à¸‡à¹€à¸à¸•à¹€à¸«\u0e47à¸™à¸§\u0e48à¸²à¸¡\u0e35à¸à¸²à¸£à¹€à¸›à¸¥\u0e35\u0e48à¸¢à¸™à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™à¸š\u0e31à¸à¸Š\u0e35 Roblox à¸‚à¸­à¸‡à¸„\u0e38à¸“: {userName} à¸«à¸²à¸à¸„\u0e38à¸“à¹„à¸¡\u0e48à¹„à¸”\u0e49à¸•\u0e31\u0e49à¸‡à¹ƒà¸ˆà¹€à¸›à¸¥\u0e35\u0e48à¸¢à¸™ à¸«à¸£\u0e37à¸­à¸„\u0e38à¸“à¸„\u0e34à¸”à¸§\u0e48à¸²à¹€à¸›\u0e47à¸™à¹€à¸«à¸•\u0e38à¸œ\u0e34à¸”à¸žà¸¥à¸²à¸”à¸ˆà¸²à¸à¸à¸²à¸£à¸—\u0e35\u0e48à¸¡\u0e35à¸„à¸™à¸­\u0e37\u0e48à¸™à¸¡à¸²à¹€à¸›à¸¥\u0e35\u0e48à¸¢à¸™ à¸à¸£\u0e38à¸“à¸²à¸„à¸¥\u0e34à¸à¸—\u0e35\u0e48à¸¥\u0e34à¸‡à¸\u0e4cà¸™\u0e35\u0e49à¹€à¸ž\u0e37\u0e48à¸­à¸¢à¸à¹€à¸¥\u0e34à¸à¸à¸²à¸£à¹€à¸›à¸¥\u0e35\u0e48à¸¢à¸™à¸™\u0e31\u0e49à¸™:{lineBreak} {actionLink} {lineBreak}{lineBreak}à¸«à¸²à¸à¸„\u0e38à¸“à¸žà¸­à¹ƒà¸ˆà¸\u0e31à¸šà¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™à¸š\u0e31à¸à¸Š\u0e35 Roblox à¹ƒà¸«à¸¡\u0e48à¸‚à¸­à¸‡à¸„\u0e38à¸“ à¸„\u0e38à¸“à¸\u0e47à¹„à¸¡\u0e48à¸ˆà¸³à¹€à¸›\u0e47à¸™à¸•\u0e49à¸­à¸‡à¸”à¸³à¹€à¸™\u0e34à¸™à¸à¸²à¸£à¹ƒà¸”à¹† à¹€à¸¥à¸¢! à¸¡\u0e31à¸™à¸žà¸£\u0e49à¸­à¸¡à¹ƒà¸Š\u0e49à¸‡à¸²à¸™à¹à¸¥\u0e49à¸§ à¹‚à¸›à¸£à¸”à¸­à¸¢\u0e48à¸²à¸•à¸­à¸šà¸à¸¥\u0e31à¸šà¸‚\u0e49à¸­à¸„à¸§à¸²à¸¡à¸™\u0e35\u0e49 à¸«à¸²à¸à¸„\u0e38à¸“à¸¡\u0e35à¸„à¸³à¸–à¸²à¸¡à¹ƒà¸”à¹† à¸à¸£\u0e38à¸“à¸²à¸”\u0e39à¸—\u0e35\u0e48à¸«à¸™\u0e49à¸²à¹€à¸žà¸ˆà¸Š\u0e48à¸§à¸¢à¹€à¸«à¸¥\u0e37à¸­à¸‚à¸­à¸‡ Roblox (https://www.roblox.com/help)";
	}

	protected override string _GetTemplateForDescriptionEmailToResetPassword()
	{
		return "à¸›\u0e49à¸­à¸™à¸­\u0e35à¹€à¸¡à¸¥à¸‚à¸­à¸‡à¸„\u0e38à¸“à¹€à¸ž\u0e37\u0e48à¸­à¸£\u0e35à¹€à¸‹\u0e47à¸•à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™à¸‚à¸­à¸‡à¸„\u0e38à¸“";
	}

	protected override string _GetTemplateForDescriptionEmailToRetriveUsername()
	{
		return "à¸›\u0e49à¸­à¸™à¸­\u0e35à¹€à¸¡à¸¥à¸‚à¸­à¸‡à¸„\u0e38à¸“à¹€à¸ž\u0e37\u0e48à¸­à¸£\u0e31à¸šà¸Š\u0e37\u0e48à¸­à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49à¸‚à¸­à¸‡à¸„\u0e38à¸“";
	}

	/// <summary>
	/// Key: "Description.PasswordChangeEmail.BodyPlainText"
	/// password reset plaintext email message
	/// English String: "We noticed that the password changed for your Roblox account: {userName}. If you didn't intend to change it, or you think someone else changed it by mistake, please click this link to undo the action:\n{urlWithTicket}\n\nIf you are happy with your new Roblox password, you don't have to do anything! It's already set up. Please do not reply to this message. If you have any questions, please see the Roblox help page (https://www.roblox.com/help)."
	/// </summary>
	public override string DescriptionPasswordChangeEmailBodyPlainText(string userName, string urlWithTicket)
	{
		return $"à¹€à¸£à¸²à¸ª\u0e31à¸‡à¹€à¸à¸•à¹€à¸«\u0e47à¸™à¸§\u0e48à¸²à¸¡\u0e35à¸à¸²à¸£à¹€à¸›à¸¥\u0e35\u0e48à¸¢à¸™à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™à¸š\u0e31à¸à¸Š\u0e35 Roblox à¸‚à¸­à¸‡à¸„\u0e38à¸“: {userName} à¸«à¸²à¸à¸„\u0e38à¸“à¹„à¸¡\u0e48à¹„à¸”\u0e49à¸•\u0e31\u0e49à¸‡à¹ƒà¸ˆà¹€à¸›à¸¥\u0e35\u0e48à¸¢à¸™ à¸«à¸£\u0e37à¸­à¸„\u0e38à¸“à¸„\u0e34à¸”à¸§\u0e48à¸²à¹€à¸›\u0e47à¸™à¹€à¸«à¸•\u0e38à¸œ\u0e34à¸”à¸žà¸¥à¸²à¸”à¸ˆà¸²à¸à¸à¸²à¸£à¸—\u0e35\u0e48à¸¡\u0e35à¸„à¸™à¸­\u0e37\u0e48à¸™à¸¡à¸²à¹€à¸›à¸¥\u0e35\u0e48à¸¢à¸™ à¸à¸£\u0e38à¸“à¸²à¸„à¸¥\u0e34à¸à¸—\u0e35\u0e48à¸¥\u0e34à¸‡à¸\u0e4cà¸™\u0e35\u0e49à¹€à¸ž\u0e37\u0e48à¸­à¸¢à¸à¹€à¸¥\u0e34à¸à¸à¸²à¸£à¹€à¸›à¸¥\u0e35\u0e48à¸¢à¸™à¸™\u0e31\u0e49à¸™:\n{urlWithTicket}\n\nà¸«à¸²à¸à¸„\u0e38à¸“à¸žà¸­à¹ƒà¸ˆà¸\u0e31à¸šà¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™à¸š\u0e31à¸à¸Š\u0e35 Roblox à¹ƒà¸«à¸¡\u0e48à¸‚à¸­à¸‡à¸„\u0e38à¸“ à¸„\u0e38à¸“à¸\u0e47à¹„à¸¡\u0e48à¸ˆà¸³à¹€à¸›\u0e47à¸™à¸•\u0e49à¸­à¸‡à¸”à¸³à¹€à¸™\u0e34à¸™à¸à¸²à¸£à¹ƒà¸”à¹† à¹€à¸¥à¸¢! à¸¡\u0e31à¸™à¸žà¸£\u0e49à¸­à¸¡à¹ƒà¸Š\u0e49à¸‡à¸²à¸™à¹à¸¥\u0e49à¸§ à¹‚à¸›à¸£à¸”à¸­à¸¢\u0e48à¸²à¸•à¸­à¸šà¸à¸¥\u0e31à¸šà¸‚\u0e49à¸­à¸„à¸§à¸²à¸¡à¸™\u0e35\u0e49 à¸«à¸²à¸à¸„\u0e38à¸“à¸¡\u0e35à¸„à¸³à¸–à¸²à¸¡à¹ƒà¸”à¹† à¸à¸£\u0e38à¸“à¸²à¸”\u0e39à¸—\u0e35\u0e48à¸«à¸™\u0e49à¸²à¹€à¸žà¸ˆà¸Š\u0e48à¸§à¸¢à¹€à¸«à¸¥\u0e37à¸­à¸‚à¸­à¸‡ Roblox (https://www.roblox.com/help)";
	}

	protected override string _GetTemplateForDescriptionPasswordChangeEmailBodyPlainText()
	{
		return "à¹€à¸£à¸²à¸ª\u0e31à¸‡à¹€à¸à¸•à¹€à¸«\u0e47à¸™à¸§\u0e48à¸²à¸¡\u0e35à¸à¸²à¸£à¹€à¸›à¸¥\u0e35\u0e48à¸¢à¸™à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™à¸š\u0e31à¸à¸Š\u0e35 Roblox à¸‚à¸­à¸‡à¸„\u0e38à¸“: {userName} à¸«à¸²à¸à¸„\u0e38à¸“à¹„à¸¡\u0e48à¹„à¸”\u0e49à¸•\u0e31\u0e49à¸‡à¹ƒà¸ˆà¹€à¸›à¸¥\u0e35\u0e48à¸¢à¸™ à¸«à¸£\u0e37à¸­à¸„\u0e38à¸“à¸„\u0e34à¸”à¸§\u0e48à¸²à¹€à¸›\u0e47à¸™à¹€à¸«à¸•\u0e38à¸œ\u0e34à¸”à¸žà¸¥à¸²à¸”à¸ˆà¸²à¸à¸à¸²à¸£à¸—\u0e35\u0e48à¸¡\u0e35à¸„à¸™à¸­\u0e37\u0e48à¸™à¸¡à¸²à¹€à¸›à¸¥\u0e35\u0e48à¸¢à¸™ à¸à¸£\u0e38à¸“à¸²à¸„à¸¥\u0e34à¸à¸—\u0e35\u0e48à¸¥\u0e34à¸‡à¸\u0e4cà¸™\u0e35\u0e49à¹€à¸ž\u0e37\u0e48à¸­à¸¢à¸à¹€à¸¥\u0e34à¸à¸à¸²à¸£à¹€à¸›à¸¥\u0e35\u0e48à¸¢à¸™à¸™\u0e31\u0e49à¸™:\n{urlWithTicket}\n\nà¸«à¸²à¸à¸„\u0e38à¸“à¸žà¸­à¹ƒà¸ˆà¸\u0e31à¸šà¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™à¸š\u0e31à¸à¸Š\u0e35 Roblox à¹ƒà¸«à¸¡\u0e48à¸‚à¸­à¸‡à¸„\u0e38à¸“ à¸„\u0e38à¸“à¸\u0e47à¹„à¸¡\u0e48à¸ˆà¸³à¹€à¸›\u0e47à¸™à¸•\u0e49à¸­à¸‡à¸”à¸³à¹€à¸™\u0e34à¸™à¸à¸²à¸£à¹ƒà¸”à¹† à¹€à¸¥à¸¢! à¸¡\u0e31à¸™à¸žà¸£\u0e49à¸­à¸¡à¹ƒà¸Š\u0e49à¸‡à¸²à¸™à¹à¸¥\u0e49à¸§ à¹‚à¸›à¸£à¸”à¸­à¸¢\u0e48à¸²à¸•à¸­à¸šà¸à¸¥\u0e31à¸šà¸‚\u0e49à¸­à¸„à¸§à¸²à¸¡à¸™\u0e35\u0e49 à¸«à¸²à¸à¸„\u0e38à¸“à¸¡\u0e35à¸„à¸³à¸–à¸²à¸¡à¹ƒà¸”à¹† à¸à¸£\u0e38à¸“à¸²à¸”\u0e39à¸—\u0e35\u0e48à¸«à¸™\u0e49à¸²à¹€à¸žà¸ˆà¸Š\u0e48à¸§à¸¢à¹€à¸«à¸¥\u0e37à¸­à¸‚à¸­à¸‡ Roblox (https://www.roblox.com/help)";
	}

	/// <summary>
	/// Key: "Description.PasswordChangeEmail.From"
	/// name of the sender as shown in from field of the email
	/// English String: "\"Roblox Password Reset\" {fromEmailAddress}"
	/// </summary>
	public override string DescriptionPasswordChangeEmailFrom(string fromEmailAddress)
	{
		return $"\"à¸à¸²à¸£à¸£\u0e35à¹€à¸‹\u0e47à¸•à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™à¸š\u0e31à¸à¸Š\u0e35 Roblox\" {fromEmailAddress}";
	}

	protected override string _GetTemplateForDescriptionPasswordChangeEmailFrom()
	{
		return "\"à¸à¸²à¸£à¸£\u0e35à¹€à¸‹\u0e47à¸•à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™à¸š\u0e31à¸à¸Š\u0e35 Roblox\" {fromEmailAddress}";
	}

	protected override string _GetTemplateForDescriptionPasswordChangeEmailSubject()
	{
		return "à¸à¸²à¸£à¸£\u0e35à¹€à¸‹\u0e47à¸•à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™à¸š\u0e31à¸à¸Š\u0e35 Roblox";
	}

	/// <summary>
	/// Key: "Description.PasswordResetEmail.From"
	/// The "From" field for the password reset email
	/// English String: "{escapeLiteralStart}Roblox Password Reset{escapeLiteralEnd} {fromEmailAddress}"
	/// </summary>
	public override string DescriptionPasswordResetEmailFrom(string escapeLiteralStart, string escapeLiteralEnd, string fromEmailAddress)
	{
		return $"{escapeLiteralStart}à¸à¸²à¸£à¸£\u0e35à¹€à¸‹\u0e47à¸•à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™à¸š\u0e31à¸à¸Š\u0e35 Roblox{escapeLiteralEnd} {fromEmailAddress}";
	}

	protected override string _GetTemplateForDescriptionPasswordResetEmailFrom()
	{
		return "{escapeLiteralStart}à¸à¸²à¸£à¸£\u0e35à¹€à¸‹\u0e47à¸•à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™à¸š\u0e31à¸à¸Š\u0e35 Roblox{escapeLiteralEnd} {fromEmailAddress}";
	}

	/// <summary>
	/// Key: "Description.PasswordResetEmail.HtmlBody"
	/// This email is sent when a user requests a password reset.
	/// English String: "We have received a request to reset the password for your Roblox account: {emailOrUsername}{lineBreak}{lineBreak}If you submitted this request, please click the button below to proceed.{lineBreak}This button will be active for {passwordResetTicketHours} hours, {passwordResetTicketMinutes} minutes. If you do not wish to reset your password, please disregard this notice.{lineBreak}{lineBreak}{aTagWithStartHref}{resetPasswordUrl}{hrefEnd}{buttonStart}Reset Password{buttonEnd}{aTagEnd}"
	/// </summary>
	public override string DescriptionPasswordResetEmailHtmlBody(string emailOrUsername, string lineBreak, string passwordResetTicketHours, string passwordResetTicketMinutes, string aTagWithStartHref, string resetPasswordUrl, string hrefEnd, string buttonStart, string buttonEnd, string aTagEnd)
	{
		return $"à¹€à¸£à¸²à¹„à¸”\u0e49à¸£\u0e31à¸šà¸à¸²à¸£à¸£\u0e49à¸­à¸‡à¸‚à¸­à¸£\u0e35à¹€à¸‹\u0e47à¸•à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™à¸ªà¸³à¸«à¸£\u0e31à¸šà¸š\u0e31à¸à¸Š\u0e35 Roblox à¸‚à¸­à¸‡à¸„\u0e38à¸“: {emailOrUsername}{lineBreak}{lineBreak}à¸«à¸²à¸à¸„\u0e38à¸“à¹€à¸›\u0e47à¸™à¸œ\u0e39\u0e49à¸ª\u0e48à¸‡à¸„à¸³à¸£\u0e49à¸­à¸‡à¸‚à¸­à¸™\u0e35\u0e49 à¸à¸£\u0e38à¸“à¸²à¸„à¸¥\u0e34à¸à¸—\u0e35\u0e48à¸›\u0e38\u0e48à¸¡à¸”\u0e49à¸²à¸™à¸¥\u0e48à¸²à¸‡à¹€à¸ž\u0e37\u0e48à¸­à¸”à¸³à¹€à¸™\u0e34à¸™à¸à¸²à¸£à¸•\u0e48à¸­{lineBreak}à¸›\u0e38\u0e48à¸¡à¸™\u0e35\u0e49à¸ˆà¸°à¹ƒà¸Š\u0e49à¸‡à¸²à¸™à¹„à¸”\u0e49à¹€à¸›\u0e47à¸™à¹€à¸§à¸¥à¸² {passwordResetTicketHours} à¸Š\u0e31\u0e48à¸§à¹‚à¸¡à¸‡ {passwordResetTicketMinutes} à¸™à¸²à¸—\u0e35 à¸«à¸²à¸à¸„\u0e38à¸“à¹„à¸¡\u0e48à¸•\u0e49à¸­à¸‡à¸à¸²à¸£à¸£\u0e35à¹€à¸‹\u0e47à¸•à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™à¸‚à¸­à¸‡à¸„\u0e38à¸“ à¸à¸£\u0e38à¸“à¸²à¸­à¸¢\u0e48à¸²à¸ªà¸™à¹ƒà¸ˆà¸à¸²à¸£à¹à¸ˆ\u0e49à¸‡à¸™\u0e35\u0e49{lineBreak}{lineBreak}{aTagWithStartHref}{resetPasswordUrl}{hrefEnd}{buttonStart}à¸£\u0e35à¹€à¸‹\u0e47à¸•à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™{buttonEnd}{aTagEnd}";
	}

	protected override string _GetTemplateForDescriptionPasswordResetEmailHtmlBody()
	{
		return "à¹€à¸£à¸²à¹„à¸”\u0e49à¸£\u0e31à¸šà¸à¸²à¸£à¸£\u0e49à¸­à¸‡à¸‚à¸­à¸£\u0e35à¹€à¸‹\u0e47à¸•à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™à¸ªà¸³à¸«à¸£\u0e31à¸šà¸š\u0e31à¸à¸Š\u0e35 Roblox à¸‚à¸­à¸‡à¸„\u0e38à¸“: {emailOrUsername}{lineBreak}{lineBreak}à¸«à¸²à¸à¸„\u0e38à¸“à¹€à¸›\u0e47à¸™à¸œ\u0e39\u0e49à¸ª\u0e48à¸‡à¸„à¸³à¸£\u0e49à¸­à¸‡à¸‚à¸­à¸™\u0e35\u0e49 à¸à¸£\u0e38à¸“à¸²à¸„à¸¥\u0e34à¸à¸—\u0e35\u0e48à¸›\u0e38\u0e48à¸¡à¸”\u0e49à¸²à¸™à¸¥\u0e48à¸²à¸‡à¹€à¸ž\u0e37\u0e48à¸­à¸”à¸³à¹€à¸™\u0e34à¸™à¸à¸²à¸£à¸•\u0e48à¸­{lineBreak}à¸›\u0e38\u0e48à¸¡à¸™\u0e35\u0e49à¸ˆà¸°à¹ƒà¸Š\u0e49à¸‡à¸²à¸™à¹„à¸”\u0e49à¹€à¸›\u0e47à¸™à¹€à¸§à¸¥à¸² {passwordResetTicketHours} à¸Š\u0e31\u0e48à¸§à¹‚à¸¡à¸‡ {passwordResetTicketMinutes} à¸™à¸²à¸—\u0e35 à¸«à¸²à¸à¸„\u0e38à¸“à¹„à¸¡\u0e48à¸•\u0e49à¸­à¸‡à¸à¸²à¸£à¸£\u0e35à¹€à¸‹\u0e47à¸•à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™à¸‚à¸­à¸‡à¸„\u0e38à¸“ à¸à¸£\u0e38à¸“à¸²à¸­à¸¢\u0e48à¸²à¸ªà¸™à¹ƒà¸ˆà¸à¸²à¸£à¹à¸ˆ\u0e49à¸‡à¸™\u0e35\u0e49{lineBreak}{lineBreak}{aTagWithStartHref}{resetPasswordUrl}{hrefEnd}{buttonStart}à¸£\u0e35à¹€à¸‹\u0e47à¸•à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™{buttonEnd}{aTagEnd}";
	}

	/// <summary>
	/// Key: "Description.PasswordResetEmail.PlainBody"
	/// This email is sent when a user requests a password reset.
	/// English String: "We have received a request to reset the password for your Roblox account: {emailOrUsername}{lineBreak}{lineBreak}If you submitted this request, please click the link below or paste it into a web browser to proceed.{lineBreak}This link will be active for {passwordResetTicketHours} hours, {passwordResetTicketMinutes} minutes. If you do not wish to reset your password, please disregard this notice.{lineBreak}{lineBreak}{resetPasswordUrl}"
	/// </summary>
	public override string DescriptionPasswordResetEmailPlainBody(string emailOrUsername, string lineBreak, string passwordResetTicketHours, string passwordResetTicketMinutes, string resetPasswordUrl)
	{
		return $"à¹€à¸£à¸²à¹„à¸”\u0e49à¸£\u0e31à¸šà¸à¸²à¸£à¸£\u0e49à¸­à¸‡à¸‚à¸­à¸£\u0e35à¹€à¸‹\u0e47à¸•à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™à¸ªà¸³à¸«à¸£\u0e31à¸šà¸š\u0e31à¸à¸Š\u0e35 Roblox à¸‚à¸­à¸‡à¸„\u0e38à¸“: {emailOrUsername}{lineBreak}{lineBreak}à¸«à¸²à¸à¸„\u0e38à¸“à¹€à¸›\u0e47à¸™à¸œ\u0e39\u0e49à¸ª\u0e48à¸‡à¸„à¸³à¸£\u0e49à¸­à¸‡à¸‚à¸­à¸™\u0e35\u0e49 à¸à¸£\u0e38à¸“à¸²à¸„à¸¥\u0e34à¸à¸—\u0e35\u0e48à¸¥\u0e34à¸‡à¸\u0e4cà¸”\u0e49à¸²à¸™à¸¥\u0e48à¸²à¸‡à¸«à¸£\u0e37à¸­à¸„\u0e31à¸”à¸¥à¸­à¸à¹à¸¥\u0e49à¸§à¸™à¸³à¹„à¸›à¸§à¸²à¸‡à¸—\u0e35\u0e48à¹€à¸šà¸£à¸²à¸§\u0e4cà¹€à¸‹à¸­à¸£\u0e4cà¸‚à¸­à¸‡à¸„\u0e38à¸“à¹€à¸ž\u0e37\u0e48à¸­à¸”à¸³à¹€à¸™\u0e34à¸™à¸à¸²à¸£à¸•\u0e48à¸­{lineBreak}à¸¥\u0e34à¸‡à¸\u0e4cà¸™\u0e35\u0e49à¸ˆà¸°à¹ƒà¸Š\u0e49à¸‡à¸²à¸™à¹„à¸”\u0e49à¹€à¸›\u0e47à¸™à¹€à¸§à¸¥à¸² {passwordResetTicketHours} à¸Š\u0e31\u0e48à¸§à¹‚à¸¡à¸‡ {passwordResetTicketMinutes} à¸™à¸²à¸—\u0e35 à¸«à¸²à¸à¸„\u0e38à¸“à¹„à¸¡\u0e48à¸•\u0e49à¸­à¸‡à¸à¸²à¸£à¸£\u0e35à¹€à¸‹\u0e47à¸•à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™à¸‚à¸­à¸‡à¸„\u0e38à¸“ à¸à¸£\u0e38à¸“à¸²à¸­à¸¢\u0e48à¸²à¸ªà¸™à¹ƒà¸ˆà¸à¸²à¸£à¹à¸ˆ\u0e49à¸‡à¸™\u0e35\u0e49{lineBreak}{lineBreak}{resetPasswordUrl}";
	}

	protected override string _GetTemplateForDescriptionPasswordResetEmailPlainBody()
	{
		return "à¹€à¸£à¸²à¹„à¸”\u0e49à¸£\u0e31à¸šà¸à¸²à¸£à¸£\u0e49à¸­à¸‡à¸‚à¸­à¸£\u0e35à¹€à¸‹\u0e47à¸•à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™à¸ªà¸³à¸«à¸£\u0e31à¸šà¸š\u0e31à¸à¸Š\u0e35 Roblox à¸‚à¸­à¸‡à¸„\u0e38à¸“: {emailOrUsername}{lineBreak}{lineBreak}à¸«à¸²à¸à¸„\u0e38à¸“à¹€à¸›\u0e47à¸™à¸œ\u0e39\u0e49à¸ª\u0e48à¸‡à¸„à¸³à¸£\u0e49à¸­à¸‡à¸‚à¸­à¸™\u0e35\u0e49 à¸à¸£\u0e38à¸“à¸²à¸„à¸¥\u0e34à¸à¸—\u0e35\u0e48à¸¥\u0e34à¸‡à¸\u0e4cà¸”\u0e49à¸²à¸™à¸¥\u0e48à¸²à¸‡à¸«à¸£\u0e37à¸­à¸„\u0e31à¸”à¸¥à¸­à¸à¹à¸¥\u0e49à¸§à¸™à¸³à¹„à¸›à¸§à¸²à¸‡à¸—\u0e35\u0e48à¹€à¸šà¸£à¸²à¸§\u0e4cà¹€à¸‹à¸­à¸£\u0e4cà¸‚à¸­à¸‡à¸„\u0e38à¸“à¹€à¸ž\u0e37\u0e48à¸­à¸”à¸³à¹€à¸™\u0e34à¸™à¸à¸²à¸£à¸•\u0e48à¸­{lineBreak}à¸¥\u0e34à¸‡à¸\u0e4cà¸™\u0e35\u0e49à¸ˆà¸°à¹ƒà¸Š\u0e49à¸‡à¸²à¸™à¹„à¸”\u0e49à¹€à¸›\u0e47à¸™à¹€à¸§à¸¥à¸² {passwordResetTicketHours} à¸Š\u0e31\u0e48à¸§à¹‚à¸¡à¸‡ {passwordResetTicketMinutes} à¸™à¸²à¸—\u0e35 à¸«à¸²à¸à¸„\u0e38à¸“à¹„à¸¡\u0e48à¸•\u0e49à¸­à¸‡à¸à¸²à¸£à¸£\u0e35à¹€à¸‹\u0e47à¸•à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™à¸‚à¸­à¸‡à¸„\u0e38à¸“ à¸à¸£\u0e38à¸“à¸²à¸­à¸¢\u0e48à¸²à¸ªà¸™à¹ƒà¸ˆà¸à¸²à¸£à¹à¸ˆ\u0e49à¸‡à¸™\u0e35\u0e49{lineBreak}{lineBreak}{resetPasswordUrl}";
	}

	protected override string _GetTemplateForDescriptionPasswordResetEmailSubject()
	{
		return "à¸à¸²à¸£à¸£\u0e35à¹€à¸‹\u0e47à¸•à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™à¸š\u0e31à¸à¸Š\u0e35 Roblox";
	}

	protected override string _GetTemplateForDescriptionPhoneToResetPassword()
	{
		return "à¸›\u0e49à¸­à¸™à¸«à¸¡à¸²à¸¢à¹€à¸¥à¸‚à¹‚à¸—à¸£à¸¨\u0e31à¸žà¸—\u0e4cà¸‚à¸­à¸‡à¸„\u0e38à¸“à¹€à¸ž\u0e37\u0e48à¸­à¸£\u0e35à¹€à¸‹\u0e47à¸•à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™à¸‚à¸­à¸‡à¸„\u0e38à¸“";
	}

	protected override string _GetTemplateForDescriptionPhoneToRetriveUsername()
	{
		return "à¸›\u0e49à¸­à¸™à¸«à¸¡à¸²à¸¢à¹€à¸¥à¸‚à¹‚à¸—à¸£à¸¨\u0e31à¸žà¸—\u0e4cà¸‚à¸­à¸‡à¸„\u0e38à¸“à¹€à¸ž\u0e37\u0e48à¸­à¸£\u0e31à¸šà¸Š\u0e37\u0e48à¸­à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49à¸‚à¸­à¸‡à¸„\u0e38à¸“";
	}

	protected override string _GetTemplateForHeadingVerifyCode()
	{
		return "à¸•à¸£à¸§à¸ˆà¸ªà¸­à¸šà¸£à¸«\u0e31à¸ª";
	}

	protected override string _GetTemplateForHeadingVerifyPhone()
	{
		return "à¸•à¸£à¸§à¸ˆà¸ªà¸­à¸šà¹‚à¸—à¸£à¸¨\u0e31à¸žà¸—\u0e4c";
	}

	protected override string _GetTemplateForHeadingForgetPasswordOrUsername()
	{
		return "à¸¥\u0e37à¸¡à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™à¸«à¸£\u0e37à¸­à¸Š\u0e37\u0e48à¸­à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49";
	}

	protected override string _GetTemplateForLabelActionButtonYes()
	{
		return "à¹ƒà¸Š\u0e48";
	}

	protected override string _GetTemplateForLabelForgetMyPassword()
	{
		return "à¸¥\u0e37à¸¡à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™à¸‚à¸­à¸‡à¸‰\u0e31à¸™";
	}

	protected override string _GetTemplateForLabelForgetMyUsername()
	{
		return "à¸¥\u0e37à¸¡à¸Š\u0e37\u0e48à¸­à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49à¸‚à¸­à¸‡à¸‰\u0e31à¸™";
	}

	protected override string _GetTemplateForLabelInvalidEmail()
	{
		return "à¸­\u0e35à¹€à¸¡à¸¥à¹„à¸¡\u0e48à¸–\u0e39à¸à¸•\u0e49à¸­à¸‡";
	}

	protected override string _GetTemplateForLabelInvalidPhoneNumber()
	{
		return "à¸«à¸¡à¸²à¸¢à¹€à¸¥à¸‚à¹‚à¸—à¸£à¸¨\u0e31à¸žà¸—\u0e4cà¹„à¸¡\u0e48à¸–\u0e39à¸à¸•\u0e49à¸­à¸‡";
	}

	protected override string _GetTemplateForLabelNeutralButtonOk()
	{
		return "à¸•à¸à¸¥à¸‡";
	}

	protected override string _GetTemplateForLabelPassword()
	{
		return "à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™";
	}

	protected override string _GetTemplateForLabelResendCode()
	{
		return "à¸ª\u0e48à¸‡à¸£à¸«\u0e31à¸ªà¹ƒà¸«à¸¡\u0e48";
	}

	protected override string _GetTemplateForLabelSubmit()
	{
		return "à¸ª\u0e48à¸‡";
	}

	protected override string _GetTemplateForLabelToolTipWhoCanFindMeByPhone()
	{
		return "à¸à¸²à¸£à¸•\u0e31\u0e49à¸‡à¸„\u0e48à¸²à¸™\u0e35\u0e49à¸„à¸§à¸šà¸„\u0e38à¸¡à¸§\u0e48à¸² à¹ƒà¸„à¸£à¸š\u0e49à¸²à¸‡à¸—\u0e35\u0e48à¸ˆà¸°à¸ªà¸²à¸¡à¸²à¸£à¸–à¸žà¸šà¸§\u0e48à¸²à¸„\u0e38à¸“à¹ƒà¸Š\u0e49à¸«à¸¡à¸²à¸¢à¹€à¸¥à¸‚à¹‚à¸—à¸£à¸¨\u0e31à¸žà¸—\u0e4cà¸—\u0e35\u0e48à¸„\u0e38à¸“à¹„à¸”\u0e49à¹à¸ˆ\u0e49à¸‡à¹„à¸§\u0e49";
	}

	protected override string _GetTemplateForLabelUsername()
	{
		return "à¸Š\u0e37\u0e48à¸­à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49";
	}

	protected override string _GetTemplateForLabelWhoCanFindMeByPhone()
	{
		return "à¹ƒà¸„à¸£à¸š\u0e49à¸²à¸‡à¸—\u0e35\u0e48à¸ªà¸²à¸¡à¸²à¸£à¸–à¸”\u0e39à¸«à¸¡à¸²à¸¢à¹€à¸¥à¸‚à¹‚à¸—à¸£à¸¨\u0e31à¸žà¸—\u0e4cà¸‚à¸­à¸‡à¸‰\u0e31à¸™à¹„à¸”\u0e49?";
	}

	/// <summary>
	/// Key: "Message.CantSendEmailWarning"
	/// English String: "If you did not give us a {styleStart}real email address{styleEnd} when you created your account, we cannot send you an email."
	/// </summary>
	public override string MessageCantSendEmailWarning(string styleStart, string styleEnd)
	{
		return $"à¸«à¸²à¸à¸„\u0e38à¸“à¹„à¸¡\u0e48à¹„à¸”\u0e49à¹ƒà¸«\u0e49{styleStart}à¸—\u0e35\u0e48à¸­à¸¢\u0e39\u0e48à¸­\u0e35à¹€à¸¡à¸¥à¸ˆà¸£\u0e34à¸‡{styleEnd}à¹à¸\u0e48à¹€à¸£à¸²à¹€à¸¡\u0e37\u0e48à¸­à¸„\u0e38à¸“à¸ªà¸£\u0e49à¸²à¸‡à¸š\u0e31à¸à¸Š\u0e35à¸‚à¸­à¸‡à¸„\u0e38à¸“ à¹€à¸£à¸²à¸ˆà¸°à¹„à¸¡\u0e48à¸ªà¸²à¸¡à¸²à¸£à¸–à¸ª\u0e48à¸‡à¸­\u0e35à¹€à¸¡à¸¥à¹ƒà¸«\u0e49à¸„\u0e38à¸“à¹„à¸”\u0e49";
	}

	protected override string _GetTemplateForMessageCantSendEmailWarning()
	{
		return "à¸«à¸²à¸à¸„\u0e38à¸“à¹„à¸¡\u0e48à¹„à¸”\u0e49à¹ƒà¸«\u0e49{styleStart}à¸—\u0e35\u0e48à¸­à¸¢\u0e39\u0e48à¸­\u0e35à¹€à¸¡à¸¥à¸ˆà¸£\u0e34à¸‡{styleEnd}à¹à¸\u0e48à¹€à¸£à¸²à¹€à¸¡\u0e37\u0e48à¸­à¸„\u0e38à¸“à¸ªà¸£\u0e49à¸²à¸‡à¸š\u0e31à¸à¸Š\u0e35à¸‚à¸­à¸‡à¸„\u0e38à¸“ à¹€à¸£à¸²à¸ˆà¸°à¹„à¸¡\u0e48à¸ªà¸²à¸¡à¸²à¸£à¸–à¸ª\u0e48à¸‡à¸­\u0e35à¹€à¸¡à¸¥à¹ƒà¸«\u0e49à¸„\u0e38à¸“à¹„à¸”\u0e49";
	}

	protected override string _GetTemplateForMessageDefaultError()
	{
		return "à¹€à¸\u0e34à¸”à¸‚\u0e49à¸­à¸œ\u0e34à¸”à¸žà¸¥à¸²à¸” à¸à¸£\u0e38à¸“à¸²à¸¥à¸­à¸‡à¹ƒà¸«à¸¡\u0e48à¸­\u0e35à¸à¸„à¸£\u0e31\u0e49à¸‡à¹ƒà¸™à¸ à¸²à¸¢à¸«à¸¥\u0e31à¸‡";
	}

	protected override string _GetTemplateForMessageEmailForUsernameSuccessBody()
	{
		return "à¸¡\u0e35à¸à¸²à¸£à¸ª\u0e48à¸‡à¸­\u0e35à¹€à¸¡à¸¥à¸žà¸£\u0e49à¸­à¸¡à¸Š\u0e37\u0e48à¸­à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49à¸‚à¸­à¸‡à¸„\u0e38à¸“à¹„à¸›à¹ƒà¸«\u0e49 à¸«à¸²à¸à¹„à¸”\u0e49à¸—à¸³à¸à¸²à¸£à¸š\u0e31à¸™à¸—\u0e36à¸à¸­\u0e35à¹€à¸¡à¸¥à¸‚à¸­à¸‡à¸„\u0e38à¸“à¹„à¸§\u0e49à¸ªà¸³à¸«à¸£\u0e31à¸šà¸š\u0e31à¸à¸Š\u0e35à¸™\u0e35\u0e49";
	}

	protected override string _GetTemplateForMessageEmailSuccessBody()
	{
		return "à¸¡\u0e35à¸à¸²à¸£à¸ª\u0e48à¸‡à¸­\u0e35à¹€à¸¡à¸¥à¸žà¸£\u0e49à¸­à¸¡à¸‚\u0e31\u0e49à¸™à¸•à¸­à¸™à¹„à¸›à¹ƒà¸«\u0e49à¸„\u0e38à¸“ à¸«à¸²à¸à¹„à¸”\u0e49à¸—à¸³à¸à¸²à¸£à¸š\u0e31à¸™à¸—\u0e36à¸à¸­\u0e35à¹€à¸¡à¸¥à¸‚à¸­à¸‡à¸„\u0e38à¸“à¹„à¸§\u0e49à¸ªà¸³à¸«à¸£\u0e31à¸šà¸š\u0e31à¸à¸Š\u0e35à¸™\u0e35\u0e49";
	}

	protected override string _GetTemplateForMessageEmailSuccessTitle()
	{
		return "à¸ª\u0e48à¸‡à¸­\u0e35à¹€à¸¡à¸¥à¹à¸¥\u0e49à¸§";
	}

	protected override string _GetTemplateForMessageEnterCode()
	{
		return "à¹„à¸”\u0e49à¸¡\u0e35à¸à¸²à¸£à¸ª\u0e48à¸‡à¸£à¸«\u0e31à¸ªà¹„à¸›à¸¢\u0e31à¸‡à¹‚à¸—à¸£à¸¨\u0e31à¸žà¸—\u0e4cà¸‚à¸­à¸‡à¸„\u0e38à¸“à¸«à¸²à¸à¸„\u0e38à¸“à¹„à¸”\u0e49à¸¢\u0e37à¸™à¸¢\u0e31à¸™à¹‚à¸—à¸£à¸¨\u0e31à¸žà¸—\u0e4cà¸‚à¸­à¸‡à¸„\u0e38à¸“à¹„à¸§\u0e49à¸ªà¸³à¸«à¸£\u0e31à¸šà¸š\u0e31à¸à¸Š\u0e35à¸™\u0e35\u0e49 à¸à¸£\u0e38à¸“à¸²à¸›\u0e49à¸­à¸™à¸£à¸«\u0e31à¸ªà¸”\u0e49à¸²à¸™à¸¥\u0e48à¸²à¸‡à¸™\u0e35\u0e49";
	}

	protected override string _GetTemplateForMessageEnterCodeSentToEmail()
	{
		return "à¸›\u0e49à¸­à¸™à¸£à¸«\u0e31à¸ªà¸—\u0e35\u0e48à¹€à¸£à¸²à¹€à¸ž\u0e34\u0e48à¸‡à¸ª\u0e48à¸‡à¹ƒà¸«\u0e49à¸„\u0e38à¸“à¸—à¸²à¸‡à¸­\u0e35à¹€à¸¡à¸¥";
	}

	protected override string _GetTemplateForMessagePhoneForUsernameSuccessBody()
	{
		return "à¸¡\u0e35à¸à¸²à¸£à¸ª\u0e48à¸‡ SMS à¸žà¸£\u0e49à¸­à¸¡à¸Š\u0e37\u0e48à¸­à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49à¸‚à¸­à¸‡à¸„\u0e38à¸“à¹„à¸›à¹ƒà¸«\u0e49 à¸«à¸²à¸à¹„à¸”\u0e49à¸—à¸³à¸à¸²à¸£à¸¢\u0e37à¸™à¸¢\u0e31à¸™à¸«à¸¡à¸²à¸¢à¹€à¸¥à¸‚à¹‚à¸—à¸£à¸¨\u0e31à¸žà¸—\u0e4cà¹„à¸§\u0e49à¸ªà¸³à¸«à¸£\u0e31à¸šà¸š\u0e31à¸à¸Š\u0e35à¸‚à¸­à¸‡à¸„\u0e38à¸“à¸\u0e48à¸­à¸™à¸«à¸™\u0e49à¸²à¸™\u0e35\u0e49";
	}

	protected override string _GetTemplateForMessagePhoneForUsernameSuccessTitle()
	{
		return "à¸ª\u0e48à¸‡ SMS à¹à¸¥\u0e49à¸§";
	}

	protected override string _GetTemplateForMessageAccountDoesNotHaveAnEmail()
	{
		return "à¹„à¸¡\u0e48à¸¡\u0e35à¸­\u0e35à¹€à¸¡à¸¥à¸—\u0e35\u0e48à¹€à¸Š\u0e37\u0e48à¸­à¸¡à¹‚à¸¢à¸‡à¸­à¸¢\u0e39\u0e48à¸\u0e31à¸šà¸š\u0e31à¸à¸Š\u0e35à¸™\u0e35\u0e49";
	}

	protected override string _GetTemplateForMessageAccountNotFoundByEmail()
	{
		return "à¹„à¸¡\u0e48à¸žà¸šà¸š\u0e31à¸à¸Š\u0e35 à¸à¸£\u0e38à¸“à¸²à¸£à¸°à¸š\u0e38à¸­\u0e35à¹€à¸¡à¸¥à¸­\u0e37\u0e48à¸™";
	}

	protected override string _GetTemplateForMessageAccountNotFoundByPhone()
	{
		return "à¹„à¸¡\u0e48à¸žà¸šà¸š\u0e31à¸à¸Š\u0e35 à¸à¸£\u0e38à¸“à¸²à¸£à¸°à¸š\u0e38à¸«à¸¡à¸²à¸¢à¹€à¸¥à¸‚à¹‚à¸—à¸£à¸¨\u0e31à¸žà¸—\u0e4cà¸­\u0e37\u0e48à¸™";
	}

	protected override string _GetTemplateForMessageAccountRecoveryUnknownError()
	{
		return "à¹€à¸\u0e34à¸”à¸‚\u0e49à¸­à¸œ\u0e34à¸”à¸žà¸¥à¸²à¸”à¸\u0e31à¸šà¸£à¸°à¸šà¸š à¹„à¸¡\u0e48à¸ªà¸²à¸¡à¸²à¸£à¸–à¸\u0e39\u0e49à¸„\u0e37à¸™à¸š\u0e31à¸à¸Š\u0e35à¸à¸¥\u0e31à¸šà¸¡à¸²à¸ª\u0e39\u0e48à¸ªà¸–à¸²à¸™à¸°à¸™\u0e35\u0e49à¹„à¸”\u0e49";
	}

	protected override string _GetTemplateForMessageCaptchaError()
	{
		return "à¹€à¸£à¸²à¸ˆà¸³à¹€à¸›\u0e47à¸™à¸•\u0e49à¸­à¸‡à¸•à¸£à¸§à¸ˆà¸ªà¸­à¸šà¹ƒà¸«\u0e49à¹à¸™\u0e48à¹ƒà¸ˆà¸§\u0e48à¸²à¸„\u0e38à¸“à¹„à¸¡\u0e48à¹ƒà¸Š\u0e48à¸«\u0e38\u0e48à¸™à¸¢à¸™à¸•\u0e4c!";
	}

	protected override string _GetTemplateForMessageCaptchaFailError()
	{
		return "à¸„à¸³à¸—\u0e35\u0e48à¸„\u0e38à¸“à¸ž\u0e34à¸¡à¸ž\u0e4cà¹„à¸¡\u0e48à¸•à¸£à¸‡à¸\u0e31à¸šà¸ à¸²à¸ž à¸à¸£\u0e38à¸“à¸²à¸¥à¸­à¸‡à¹ƒà¸«à¸¡\u0e48à¸­\u0e35à¸à¸„à¸£\u0e31\u0e49à¸‡";
	}

	protected override string _GetTemplateForMessageCredentialsError()
	{
		return "à¸Š\u0e37\u0e48à¸­à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49à¸«à¸£\u0e37à¸­à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™à¸‚à¸­à¸‡à¸„\u0e38à¸“à¹„à¸¡\u0e48à¸–\u0e39à¸à¸•\u0e49à¸­à¸‡ à¸à¸£\u0e38à¸“à¸²à¸•à¸£à¸§à¸ˆà¸ªà¸­à¸šà¹à¸¥\u0e49à¸§à¸¥à¸­à¸‡à¹ƒà¸«à¸¡\u0e48à¸­\u0e35à¸à¸„à¸£\u0e31\u0e49à¸‡";
	}

	protected override string _GetTemplateForMessageFloodCheckedError()
	{
		return "à¸¡\u0e35à¸à¸²à¸£à¸”à¸³à¹€à¸™\u0e34à¸™à¸à¸²à¸£à¸‹\u0e49à¸³à¸¡à¸²à¸à¹€à¸\u0e34à¸™à¹„à¸› à¸à¸£\u0e38à¸“à¸²à¸¥à¸­à¸‡à¹ƒà¸«à¸¡\u0e48à¸­\u0e35à¸à¸„à¸£\u0e31\u0e49à¸‡à¹ƒà¸™à¸ à¸²à¸¢à¸«à¸¥\u0e31à¸‡";
	}

	protected override string _GetTemplateForMessageForgotPasswordFeatureDisabled()
	{
		return "à¸„\u0e38à¸“à¸¥\u0e31à¸à¸©à¸“à¸°à¸–\u0e39à¸à¸›\u0e34à¸”à¸à¸²à¸£à¹ƒà¸Š\u0e49à¸‡à¸²à¸™à¸Š\u0e31\u0e48à¸§à¸„à¸£à¸²à¸§ à¸à¸£\u0e38à¸“à¸²à¸¥à¸­à¸‡à¹ƒà¸«à¸¡\u0e48à¸­\u0e35à¸à¸„à¸£\u0e31\u0e49à¸‡";
	}

	protected override string _GetTemplateForMessageForgotPasswordSuccess()
	{
		return "à¸•à¸£à¸§à¸ˆà¸ªà¸­à¸šà¸­\u0e35à¹€à¸¡à¸¥à¹€à¸ž\u0e37\u0e48à¸­à¸”\u0e39à¸„à¸³à¹à¸™à¸°à¸™à¸³à¸à¸²à¸£à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸£à¸°à¸šà¸š";
	}

	protected override string _GetTemplateForMessageInvalidAccountStatus()
	{
		return "à¸ªà¸–à¸²à¸™à¸°à¸š\u0e31à¸à¸Š\u0e35à¸‚\u0e31à¸”à¸‚à¸§à¸²à¸‡à¹„à¸¡\u0e48à¹ƒà¸«\u0e49à¸—à¸³à¸à¸²à¸£à¸£\u0e35à¹€à¸‹\u0e47à¸•à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™";
	}

	protected override string _GetTemplateForMessageInvalidPassword()
	{
		return "à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™à¹„à¸¡\u0e48à¸–\u0e39à¸à¸•\u0e49à¸­à¸‡";
	}

	protected override string _GetTemplateForMessageInvalidTicket()
	{
		return "à¹€à¸£à¸²à¹„à¸¡\u0e48à¸ªà¸²à¸¡à¸²à¸£à¸–à¹‚à¸«à¸¥à¸”à¸•\u0e31\u0e4bà¸§à¸£\u0e31à¸à¸©à¸²à¸„à¸§à¸²à¸¡à¸›à¸¥à¸­à¸”à¸ \u0e31à¸¢à¸™\u0e35\u0e49à¹„à¸”\u0e49";
	}

	protected override string _GetTemplateForMessageInvalidUserNameOrEmail()
	{
		return "à¸Š\u0e37\u0e48à¸­à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49à¹„à¸¡\u0e48à¸–\u0e39à¸à¸•\u0e49à¸­à¸‡à¸«à¸£\u0e37à¸­à¹„à¸¡\u0e48à¸¡\u0e35à¸­\u0e35à¹€à¸¡à¸¥à¸™\u0e31\u0e49à¸™à¸­à¸¢\u0e39\u0e48";
	}

	protected override string _GetTemplateForMessageMobileResetPasswordSuccess()
	{
		return "MobileResetPasswordSuccess";
	}

	protected override string _GetTemplateForMessageNoAccountsLinkedToEmail()
	{
		return "à¹„à¸¡\u0e48à¸¡\u0e35à¸š\u0e31à¸à¸Š\u0e35à¸—\u0e35\u0e48à¹€à¸Š\u0e37\u0e48à¸­à¸¡à¹‚à¸¢à¸‡à¸­à¸¢\u0e39\u0e48à¸\u0e31à¸šà¸—\u0e35\u0e48à¸­à¸¢\u0e39\u0e48à¸­\u0e35à¹€à¸¡à¸¥à¸™\u0e35\u0e49";
	}

	protected override string _GetTemplateForMessageOldUsernameError()
	{
		return "à¸”\u0e39à¹€à¸«à¸¡\u0e37à¸­à¸™à¸§\u0e48à¸²à¸„\u0e38à¸“à¸žà¸¢à¸²à¸¢à¸²à¸¡à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸£à¸°à¸šà¸šà¸”\u0e49à¸§à¸¢à¸Š\u0e37\u0e48à¸­à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49à¸—\u0e35\u0e48à¸¡\u0e35à¸à¸²à¸£à¹€à¸›à¸¥\u0e35\u0e48à¸¢à¸™à¹à¸›à¸¥à¸‡à¹„à¸›à¹à¸¥\u0e49à¸§ à¸à¸£\u0e38à¸“à¸²à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸£à¸°à¸šà¸šà¸”\u0e49à¸§à¸¢à¸Š\u0e37\u0e48à¸­à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49à¹ƒà¸«à¸¡\u0e48à¸‚à¸­à¸‡à¸„\u0e38à¸“";
	}

	protected override string _GetTemplateForMessagePasswordCannotBeUsed()
	{
		return "à¸‚à¸­à¸­à¸ \u0e31à¸¢ à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™à¸™\u0e31\u0e49à¸™à¹„à¸¡\u0e48à¸ªà¸²à¸¡à¸²à¸£à¸–à¹ƒà¸Š\u0e49à¸‡à¸²à¸™à¹„à¸”\u0e49";
	}

	/// <summary>
	/// Key: "MessagePasswordResetTicketExpired"
	/// English String: "Sorry, password reset requests expire {expirationHour} hours, {expirationMinute} minutes after issuance. Try requesting another password reset ticket again."
	/// </summary>
	public override string MessagePasswordResetTicketExpired(string expirationHour, string expirationMinute)
	{
		return $"à¸‚à¸­à¸­à¸ \u0e31à¸¢ à¸à¸²à¸£à¸£\u0e35à¹€à¸‹\u0e47à¸•à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™à¸ˆà¸°à¸«à¸¡à¸”à¹€à¸§à¸¥à¸²à¸¥à¸‡à¹ƒà¸™ {expirationHour} à¸Š\u0e31\u0e48à¸§à¹‚à¸¡à¸‡ {expirationMinute} à¸™à¸²à¸—\u0e35 à¸«à¸¥\u0e31à¸‡à¸ˆà¸²à¸à¸à¸²à¸£à¸¢\u0e37\u0e48à¸™à¹€à¸£\u0e37\u0e48à¸­à¸‡ à¸¥à¸­à¸‡à¸¢\u0e37\u0e48à¸™à¸‚à¸­à¸•\u0e31\u0e4bà¸§à¸£\u0e35à¹€à¸‹\u0e47à¸•à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™à¹ƒà¸«à¸¡\u0e48à¸­\u0e35à¸à¸„à¸£\u0e31\u0e49à¸‡";
	}

	protected override string _GetTemplateForMessagePasswordResetTicketExpired()
	{
		return "à¸‚à¸­à¸­à¸ \u0e31à¸¢ à¸à¸²à¸£à¸£\u0e35à¹€à¸‹\u0e47à¸•à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™à¸ˆà¸°à¸«à¸¡à¸”à¹€à¸§à¸¥à¸²à¸¥à¸‡à¹ƒà¸™ {expirationHour} à¸Š\u0e31\u0e48à¸§à¹‚à¸¡à¸‡ {expirationMinute} à¸™à¸²à¸—\u0e35 à¸«à¸¥\u0e31à¸‡à¸ˆà¸²à¸à¸à¸²à¸£à¸¢\u0e37\u0e48à¸™à¹€à¸£\u0e37\u0e48à¸­à¸‡ à¸¥à¸­à¸‡à¸¢\u0e37\u0e48à¸™à¸‚à¸­à¸•\u0e31\u0e4bà¸§à¸£\u0e35à¹€à¸‹\u0e47à¸•à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™à¹ƒà¸«à¸¡\u0e48à¸­\u0e35à¸à¸„à¸£\u0e31\u0e49à¸‡";
	}

	protected override string _GetTemplateForMessagePasswordsDoNotMatch()
	{
		return "à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™à¹„à¸¡\u0e48à¸•à¸£à¸‡à¸\u0e31à¸™";
	}

	protected override string _GetTemplateForMessageSamlUnauthenticated()
	{
		return "à¸„\u0e38à¸“à¸ˆà¸°à¸•\u0e49à¸­à¸‡à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸£à¸°à¸šà¸š Roblox à¹€à¸ž\u0e37\u0e48à¸­à¸ˆà¸šà¸‚\u0e31\u0e49à¸™à¸•à¸­à¸™à¸à¸²à¸£à¸•à¸£à¸§à¸ˆà¸ªà¸­à¸šà¸„à¸§à¸²à¸¡à¸–\u0e39à¸à¸•\u0e49à¸­à¸‡";
	}

	protected override string _GetTemplateForMessageUnknownError()
	{
		return "à¸‚\u0e49à¸­à¸œ\u0e34à¸”à¸žà¸¥à¸²à¸”à¸—\u0e35\u0e48à¹„à¸¡\u0e48à¸—à¸£à¸²à¸šà¸ªà¸²à¹€à¸«à¸•\u0e38";
	}

	protected override string _GetTemplateForMessageUnknownSystemError()
	{
		return "à¹€à¸\u0e34à¸”à¸‚\u0e49à¸­à¸œ\u0e34à¸”à¸žà¸¥à¸²à¸”à¸\u0e31à¸šà¸£à¸°à¸šà¸š à¸à¸£\u0e38à¸“à¸²à¸à¸¥\u0e31à¸šà¸ª\u0e39\u0e48à¸«à¸™\u0e49à¸²à¸à¸²à¸£à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸£à¸°à¸šà¸š";
	}

	protected override string _GetTemplateForPlaceholderEmail()
	{
		return "à¸­\u0e35à¹€à¸¡à¸¥";
	}

	/// <summary>
	/// Key: "Placeholder.EnterCode"
	/// English String: "Enter Code ({codeLength}-digit)"
	/// </summary>
	public override string PlaceholderEnterCode(string codeLength)
	{
		return $"à¸›\u0e49à¸­à¸™à¸£à¸«\u0e31à¸ª ({codeLength} à¸«à¸¥\u0e31à¸)";
	}

	protected override string _GetTemplateForPlaceholderEnterCode()
	{
		return "à¸›\u0e49à¸­à¸™à¸£à¸«\u0e31à¸ª ({codeLength} à¸«à¸¥\u0e31à¸)";
	}

	protected override string _GetTemplateForPlaceholderPhoneNumber()
	{
		return "à¸«à¸¡à¸²à¸¢à¹€à¸¥à¸‚à¹‚à¸—à¸£à¸¨\u0e31à¸žà¸—\u0e4c";
	}

	protected override string _GetTemplateForResponsePasswordResetSuccess()
	{
		return "à¸£\u0e35à¹€à¸‹\u0e47à¸•à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™à¸ªà¸³à¹€à¸£\u0e47à¸ˆ! à¸à¸£\u0e38à¸“à¸²à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸£à¸°à¸šà¸šà¹ƒà¸«à¸¡\u0e48à¸­\u0e35à¸à¸„à¸£\u0e31\u0e49à¸‡";
	}

	protected override string _GetTemplateForResponseSuccess()
	{
		return "à¸ªà¸³à¹€à¸£\u0e47à¸ˆ";
	}

	protected override string _GetTemplateForResponseUpdatePasswordFlooded()
	{
		return "à¸¡\u0e35à¸à¸²à¸£à¸”à¸³à¹€à¸™\u0e34à¸™à¸à¸²à¸£à¸‹\u0e49à¸³à¸¡à¸²à¸à¹€à¸\u0e34à¸™à¹„à¸› à¸à¸£\u0e38à¸“à¸²à¸¥à¸­à¸‡à¹ƒà¸«à¸¡\u0e48à¸­\u0e35à¸à¸„à¸£\u0e31\u0e49à¸‡à¹ƒà¸™à¸ à¸²à¸¢à¸«à¸¥\u0e31à¸‡";
	}

	protected override string _GetTemplateForResponseUpdatePasswordIncorrect()
	{
		return "à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™à¹ƒà¸™à¸›\u0e31à¸ˆà¸ˆ\u0e38à¸š\u0e31à¸™à¸‚à¸­à¸‡à¸„\u0e38à¸“à¹„à¸¡\u0e48à¸–\u0e39à¸à¸•\u0e49à¸­à¸‡ à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™à¹„à¸¡\u0e48à¸–\u0e39à¸à¹€à¸›à¸¥\u0e35\u0e48à¸¢à¸™";
	}

	protected override string _GetTemplateForResponseUpdatePasswordInputMissing()
	{
		return "à¸ˆà¸°à¸•\u0e49à¸­à¸‡à¸›\u0e49à¸­à¸™à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™à¹ƒà¸«à¸¡\u0e48à¹à¸¥à¸°à¸¢\u0e37à¸™à¸¢\u0e31à¸™à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™";
	}

	protected override string _GetTemplateForResponseUpdatePasswordMismatch()
	{
		return "à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™à¹ƒà¸«à¸¡\u0e48à¹à¸¥à¸°à¸¢\u0e37à¸™à¸¢\u0e31à¸™à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™à¸ˆà¸°à¸•\u0e49à¸­à¸‡à¸•à¸£à¸‡à¸\u0e31à¸™";
	}
}


}
