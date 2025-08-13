namespace Roblox.TranslationResources.Authentication;

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
	public override string ActionCancel => "ยกเล\u0e34ก";

	/// <summary>
	/// Key: "Action.EmailToResetPassword"
	/// English String: "Use email to reset password"
	/// </summary>
	public override string ActionEmailToResetPassword => "ใช\u0e49อ\u0e35เมลเพ\u0e37\u0e48อร\u0e35เซ\u0e47ตรห\u0e31สผ\u0e48าน";

	/// <summary>
	/// Key: "Action.EmailToRetriveUsername"
	/// English String: "Use email to retrieve username"
	/// </summary>
	public override string ActionEmailToRetriveUsername => "ใช\u0e49อ\u0e35เมลเพ\u0e37\u0e48อร\u0e31บช\u0e37\u0e48อผ\u0e39\u0e49ใช\u0e49";

	/// <summary>
	/// Key: "Action.Ok"
	/// OK
	/// English String: "OK"
	/// </summary>
	public override string ActionOk => "ตกลง";

	/// <summary>
	/// Key: "Action.PhoneToResetPassword"
	/// English String: "Use phone number to reset password"
	/// </summary>
	public override string ActionPhoneToResetPassword => "ใช\u0e49หมายเลขโทรศ\u0e31พท\u0e4cเพ\u0e37\u0e48อร\u0e35เซ\u0e47ตรห\u0e31สผ\u0e48าน";

	/// <summary>
	/// Key: "Action.PhoneToRetriveUsername"
	/// English String: "Use phone number to retrieve username"
	/// </summary>
	public override string ActionPhoneToRetriveUsername => "ใช\u0e49หมายเลขโทรศ\u0e31พท\u0e4cเพ\u0e37\u0e48อร\u0e31บช\u0e37\u0e48อผ\u0e39\u0e49ใช\u0e49";

	/// <summary>
	/// Key: "Action.Verify"
	/// English String: "Verify"
	/// </summary>
	public override string ActionVerify => "ตรวจสอบ";

	/// <summary>
	/// Key: "Description.EmailToResetPassword"
	/// English String: "Enter your email to reset your password."
	/// </summary>
	public override string DescriptionEmailToResetPassword => "ป\u0e49อนอ\u0e35เมลของค\u0e38ณเพ\u0e37\u0e48อร\u0e35เซ\u0e47ตรห\u0e31สผ\u0e48านของค\u0e38ณ";

	/// <summary>
	/// Key: "Description.EmailToRetriveUsername"
	/// English String: "Enter your email to retrieve your username."
	/// </summary>
	public override string DescriptionEmailToRetriveUsername => "ป\u0e49อนอ\u0e35เมลของค\u0e38ณเพ\u0e37\u0e48อร\u0e31บช\u0e37\u0e48อผ\u0e39\u0e49ใช\u0e49ของค\u0e38ณ";

	/// <summary>
	/// Key: "Description.PasswordChangeEmail.Subject"
	/// email subject to change password
	/// English String: "Roblox Password Reset"
	/// </summary>
	public override string DescriptionPasswordChangeEmailSubject => "การร\u0e35เซ\u0e47ตรห\u0e31สผ\u0e48านบ\u0e31ญช\u0e35 Roblox";

	/// <summary>
	/// Key: "Description.PasswordResetEmail.Subject"
	/// Subject for password reset email
	/// English String: "Roblox Account Password Reset"
	/// </summary>
	public override string DescriptionPasswordResetEmailSubject => "การร\u0e35เซ\u0e47ตรห\u0e31สผ\u0e48านบ\u0e31ญช\u0e35 Roblox";

	/// <summary>
	/// Key: "Description.PhoneToResetPassword"
	/// English String: "Enter your phone number to reset your password."
	/// </summary>
	public override string DescriptionPhoneToResetPassword => "ป\u0e49อนหมายเลขโทรศ\u0e31พท\u0e4cของค\u0e38ณเพ\u0e37\u0e48อร\u0e35เซ\u0e47ตรห\u0e31สผ\u0e48านของค\u0e38ณ";

	/// <summary>
	/// Key: "Description.PhoneToRetriveUsername"
	/// English String: "Enter your phone number to retrieve your username."
	/// </summary>
	public override string DescriptionPhoneToRetriveUsername => "ป\u0e49อนหมายเลขโทรศ\u0e31พท\u0e4cของค\u0e38ณเพ\u0e37\u0e48อร\u0e31บช\u0e37\u0e48อผ\u0e39\u0e49ใช\u0e49ของค\u0e38ณ";

	/// <summary>
	/// Key: "Heading.VerifyCode"
	/// verify code heading
	/// English String: "Verify Code"
	/// </summary>
	public override string HeadingVerifyCode => "ตรวจสอบรห\u0e31ส";

	/// <summary>
	/// Key: "Heading.VerifyPhone"
	/// English String: "Verify Phone"
	/// </summary>
	public override string HeadingVerifyPhone => "ตรวจสอบโทรศ\u0e31พท\u0e4c";

	/// <summary>
	/// Key: "HeadingForgetPasswordOrUsername"
	/// English String: "Forgot Password or Username"
	/// </summary>
	public override string HeadingForgetPasswordOrUsername => "ล\u0e37มรห\u0e31สผ\u0e48านหร\u0e37อช\u0e37\u0e48อผ\u0e39\u0e49ใช\u0e49";

	/// <summary>
	/// Key: "Label.ActionButtonYes"
	/// button label
	/// English String: "Yes"
	/// </summary>
	public override string LabelActionButtonYes => "ใช\u0e48";

	/// <summary>
	/// Key: "Label.ForgetMyPassword"
	/// English String: "Forgot My Password"
	/// </summary>
	public override string LabelForgetMyPassword => "ล\u0e37มรห\u0e31สผ\u0e48านของฉ\u0e31น";

	/// <summary>
	/// Key: "Label.ForgetMyUsername"
	/// English String: "Forgot My Username"
	/// </summary>
	public override string LabelForgetMyUsername => "ล\u0e37มช\u0e37\u0e48อผ\u0e39\u0e49ใช\u0e49ของฉ\u0e31น";

	/// <summary>
	/// Key: "Label.InvalidEmail"
	/// English String: "Invalid email"
	/// </summary>
	public override string LabelInvalidEmail => "อ\u0e35เมลไม\u0e48ถ\u0e39กต\u0e49อง";

	/// <summary>
	/// Key: "Label.InvalidPhoneNumber"
	/// English String: "Invalid phone number"
	/// </summary>
	public override string LabelInvalidPhoneNumber => "หมายเลขโทรศ\u0e31พท\u0e4cไม\u0e48ถ\u0e39กต\u0e49อง";

	/// <summary>
	/// Key: "Label.NeutralButtonOk"
	/// ok button label
	/// English String: "OK"
	/// </summary>
	public override string LabelNeutralButtonOk => "ตกลง";

	/// <summary>
	/// Key: "Label.Password"
	/// label
	/// English String: "Password"
	/// </summary>
	public override string LabelPassword => "รห\u0e31สผ\u0e48าน";

	/// <summary>
	/// Key: "Label.ResendCode"
	/// English String: "Resend Code"
	/// </summary>
	public override string LabelResendCode => "ส\u0e48งรห\u0e31สใหม\u0e48";

	/// <summary>
	/// Key: "Label.Submit"
	/// English String: "Submit"
	/// </summary>
	public override string LabelSubmit => "ส\u0e48ง";

	/// <summary>
	/// Key: "Label.ToolTip.WhoCanFindMeByPhone"
	/// English String: "This setting controls who can find you using the phone number you provided."
	/// </summary>
	public override string LabelToolTipWhoCanFindMeByPhone => "การต\u0e31\u0e49งค\u0e48าน\u0e35\u0e49ควบค\u0e38มว\u0e48า ใครบ\u0e49างท\u0e35\u0e48จะสามารถพบว\u0e48าค\u0e38ณใช\u0e49หมายเลขโทรศ\u0e31พท\u0e4cท\u0e35\u0e48ค\u0e38ณได\u0e49แจ\u0e49งไว\u0e49";

	/// <summary>
	/// Key: "Label.Username"
	/// English String: "Username"
	/// </summary>
	public override string LabelUsername => "ช\u0e37\u0e48อผ\u0e39\u0e49ใช\u0e49";

	/// <summary>
	/// Key: "Label.WhoCanFindMeByPhone"
	/// English String: "Who can find me by my phone number?"
	/// </summary>
	public override string LabelWhoCanFindMeByPhone => "ใครบ\u0e49างท\u0e35\u0e48สามารถด\u0e39หมายเลขโทรศ\u0e31พท\u0e4cของฉ\u0e31นได\u0e49?";

	/// <summary>
	/// Key: "Message.DefaultError"
	/// English String: "An error occurred, try again later."
	/// </summary>
	public override string MessageDefaultError => "เก\u0e34ดข\u0e49อผ\u0e34ดพลาด กร\u0e38ณาลองใหม\u0e48อ\u0e35กคร\u0e31\u0e49งในภายหล\u0e31ง";

	/// <summary>
	/// Key: "Message.EmailForUsernameSuccessBody"
	/// success message
	/// English String: "An email with your username(s) has been sent to you if the email was previously saved on your account."
	/// </summary>
	public override string MessageEmailForUsernameSuccessBody => "ม\u0e35การส\u0e48งอ\u0e35เมลพร\u0e49อมช\u0e37\u0e48อผ\u0e39\u0e49ใช\u0e49ของค\u0e38ณไปให\u0e49 หากได\u0e49ทำการบ\u0e31นท\u0e36กอ\u0e35เมลของค\u0e38ณไว\u0e49สำหร\u0e31บบ\u0e31ญช\u0e35น\u0e35\u0e49";

	/// <summary>
	/// Key: "Message.EmailSuccessBody"
	/// English String: "An email with instructions has been sent to you if the email was previously saved on your account."
	/// </summary>
	public override string MessageEmailSuccessBody => "ม\u0e35การส\u0e48งอ\u0e35เมลพร\u0e49อมข\u0e31\u0e49นตอนไปให\u0e49ค\u0e38ณ หากได\u0e49ทำการบ\u0e31นท\u0e36กอ\u0e35เมลของค\u0e38ณไว\u0e49สำหร\u0e31บบ\u0e31ญช\u0e35น\u0e35\u0e49";

	/// <summary>
	/// Key: "Message.EmailSuccessTitle"
	/// English String: "Email Sent"
	/// </summary>
	public override string MessageEmailSuccessTitle => "ส\u0e48งอ\u0e35เมลแล\u0e49ว";

	/// <summary>
	/// Key: "Message.EnterCode"
	/// English String: "A code was sent to your phone if it was previously verified on your account. Please enter it below"
	/// </summary>
	public override string MessageEnterCode => "ได\u0e49ม\u0e35การส\u0e48งรห\u0e31สไปย\u0e31งโทรศ\u0e31พท\u0e4cของค\u0e38ณหากค\u0e38ณได\u0e49ย\u0e37นย\u0e31นโทรศ\u0e31พท\u0e4cของค\u0e38ณไว\u0e49สำหร\u0e31บบ\u0e31ญช\u0e35น\u0e35\u0e49 กร\u0e38ณาป\u0e49อนรห\u0e31สด\u0e49านล\u0e48างน\u0e35\u0e49";

	/// <summary>
	/// Key: "Message.EnterCodeSentToEmail"
	/// Enter the code we just sent to your email.
	/// English String: "Enter the code we just sent to your email."
	/// </summary>
	public override string MessageEnterCodeSentToEmail => "ป\u0e49อนรห\u0e31สท\u0e35\u0e48เราเพ\u0e34\u0e48งส\u0e48งให\u0e49ค\u0e38ณทางอ\u0e35เมล";

	/// <summary>
	/// Key: "Message.PhoneForUsernameSuccessBody"
	/// English String: "An SMS with your username(s) has been sent to you if the phone number was previously verified on your account."
	/// </summary>
	public override string MessagePhoneForUsernameSuccessBody => "ม\u0e35การส\u0e48ง SMS พร\u0e49อมช\u0e37\u0e48อผ\u0e39\u0e49ใช\u0e49ของค\u0e38ณไปให\u0e49 หากได\u0e49ทำการย\u0e37นย\u0e31นหมายเลขโทรศ\u0e31พท\u0e4cไว\u0e49สำหร\u0e31บบ\u0e31ญช\u0e35ของค\u0e38ณก\u0e48อนหน\u0e49าน\u0e35\u0e49";

	/// <summary>
	/// Key: "Message.PhoneForUsernameSuccessTitle"
	/// English String: "SMS Sent"
	/// </summary>
	public override string MessagePhoneForUsernameSuccessTitle => "ส\u0e48ง SMS แล\u0e49ว";

	/// <summary>
	/// Key: "MessageAccountDoesNotHaveAnEmail"
	/// English String: "There is no email linked to this account"
	/// </summary>
	public override string MessageAccountDoesNotHaveAnEmail => "ไม\u0e48ม\u0e35อ\u0e35เมลท\u0e35\u0e48เช\u0e37\u0e48อมโยงอย\u0e39\u0e48ก\u0e31บบ\u0e31ญช\u0e35น\u0e35\u0e49";

	/// <summary>
	/// Key: "MessageAccountNotFoundByEmail"
	/// No account found. Please use a different email.
	/// English String: "No account found. Please use a different email."
	/// </summary>
	public override string MessageAccountNotFoundByEmail => "ไม\u0e48พบบ\u0e31ญช\u0e35 กร\u0e38ณาระบ\u0e38อ\u0e35เมลอ\u0e37\u0e48น";

	/// <summary>
	/// Key: "MessageAccountNotFoundByPhone"
	/// No account found. Please use a different phone number.
	/// English String: "No account found. Please use a different phone number."
	/// </summary>
	public override string MessageAccountNotFoundByPhone => "ไม\u0e48พบบ\u0e31ญช\u0e35 กร\u0e38ณาระบ\u0e38หมายเลขโทรศ\u0e31พท\u0e4cอ\u0e37\u0e48น";

	/// <summary>
	/// Key: "MessageAccountRecoveryUnknownError"
	/// English String: "System error. Account could not be restored to this state."
	/// </summary>
	public override string MessageAccountRecoveryUnknownError => "เก\u0e34ดข\u0e49อผ\u0e34ดพลาดก\u0e31บระบบ ไม\u0e48สามารถก\u0e39\u0e49ค\u0e37นบ\u0e31ญช\u0e35กล\u0e31บมาส\u0e39\u0e48สถานะน\u0e35\u0e49ได\u0e49";

	/// <summary>
	/// Key: "MessageCaptchaError"
	/// English String: "We need to make sure you're not a robot!"
	/// </summary>
	public override string MessageCaptchaError => "เราจำเป\u0e47นต\u0e49องตรวจสอบให\u0e49แน\u0e48ใจว\u0e48าค\u0e38ณไม\u0e48ใช\u0e48ห\u0e38\u0e48นยนต\u0e4c!";

	/// <summary>
	/// Key: "MessageCaptchaFailError"
	/// English String: "The words you typed didn't match the picture. Please try again."
	/// </summary>
	public override string MessageCaptchaFailError => "คำท\u0e35\u0e48ค\u0e38ณพ\u0e34มพ\u0e4cไม\u0e48ตรงก\u0e31บภาพ กร\u0e38ณาลองใหม\u0e48อ\u0e35กคร\u0e31\u0e49ง";

	/// <summary>
	/// Key: "MessageCredentialsError"
	/// English String: "Your username or password is incorrect. Please check them and try again."
	/// </summary>
	public override string MessageCredentialsError => "ช\u0e37\u0e48อผ\u0e39\u0e49ใช\u0e49หร\u0e37อรห\u0e31สผ\u0e48านของค\u0e38ณไม\u0e48ถ\u0e39กต\u0e49อง กร\u0e38ณาตรวจสอบแล\u0e49วลองใหม\u0e48อ\u0e35กคร\u0e31\u0e49ง";

	/// <summary>
	/// Key: "MessageFloodCheckedError"
	/// English String: "Too many attempts. Please try again later."
	/// </summary>
	public override string MessageFloodCheckedError => "ม\u0e35การดำเน\u0e34นการซ\u0e49ำมากเก\u0e34นไป กร\u0e38ณาลองใหม\u0e48อ\u0e35กคร\u0e31\u0e49งในภายหล\u0e31ง";

	/// <summary>
	/// Key: "MessageForgotPasswordFeatureDisabled"
	/// English String: "Feature temporarily disabled. Please try again later."
	/// </summary>
	public override string MessageForgotPasswordFeatureDisabled => "ค\u0e38ณล\u0e31กษณะถ\u0e39กป\u0e34ดการใช\u0e49งานช\u0e31\u0e48วคราว กร\u0e38ณาลองใหม\u0e48อ\u0e35กคร\u0e31\u0e49ง";

	/// <summary>
	/// Key: "MessageForgotPasswordSuccess"
	/// English String: "Check your email for login instructions"
	/// </summary>
	public override string MessageForgotPasswordSuccess => "ตรวจสอบอ\u0e35เมลเพ\u0e37\u0e48อด\u0e39คำแนะนำการเข\u0e49าส\u0e39\u0e48ระบบ";

	/// <summary>
	/// Key: "MessageInvalidAccountStatus"
	/// English String: "Account status prevents resetting password"
	/// </summary>
	public override string MessageInvalidAccountStatus => "สถานะบ\u0e31ญช\u0e35ข\u0e31ดขวางไม\u0e48ให\u0e49ทำการร\u0e35เซ\u0e47ตรห\u0e31สผ\u0e48าน";

	/// <summary>
	/// Key: "MessageInvalidPassword"
	/// English String: "Invalid password"
	/// </summary>
	public override string MessageInvalidPassword => "รห\u0e31สผ\u0e48านไม\u0e48ถ\u0e39กต\u0e49อง";

	/// <summary>
	/// Key: "MessageInvalidTicket"
	/// English String: "We couldn't load this security ticket."
	/// </summary>
	public override string MessageInvalidTicket => "เราไม\u0e48สามารถโหลดต\u0e31\u0e4bวร\u0e31กษาความปลอดภ\u0e31ยน\u0e35\u0e49ได\u0e49";

	/// <summary>
	/// Key: "MessageInvalidUserNameOrEmail"
	/// English String: "Invalid username, or no email exists"
	/// </summary>
	public override string MessageInvalidUserNameOrEmail => "ช\u0e37\u0e48อผ\u0e39\u0e49ใช\u0e49ไม\u0e48ถ\u0e39กต\u0e49องหร\u0e37อไม\u0e48ม\u0e35อ\u0e35เมลน\u0e31\u0e49นอย\u0e39\u0e48";

	/// <summary>
	/// Key: "MessageMobileResetPasswordSuccess"
	/// English String: "MobileResetPasswordSuccess"
	/// </summary>
	public override string MessageMobileResetPasswordSuccess => "MobileResetPasswordSuccess";

	/// <summary>
	/// Key: "MessageNoAccountsLinkedToEmail"
	/// English String: "There are no accounts linked to this email address"
	/// </summary>
	public override string MessageNoAccountsLinkedToEmail => "ไม\u0e48ม\u0e35บ\u0e31ญช\u0e35ท\u0e35\u0e48เช\u0e37\u0e48อมโยงอย\u0e39\u0e48ก\u0e31บท\u0e35\u0e48อย\u0e39\u0e48อ\u0e35เมลน\u0e35\u0e49";

	/// <summary>
	/// Key: "MessageOldUsernameError"
	/// English String: "It looks like you are trying to log in with a username that has changed. Please log in with your new username."
	/// </summary>
	public override string MessageOldUsernameError => "ด\u0e39เหม\u0e37อนว\u0e48าค\u0e38ณพยายามเข\u0e49าส\u0e39\u0e48ระบบด\u0e49วยช\u0e37\u0e48อผ\u0e39\u0e49ใช\u0e49ท\u0e35\u0e48ม\u0e35การเปล\u0e35\u0e48ยนแปลงไปแล\u0e49ว กร\u0e38ณาเข\u0e49าส\u0e39\u0e48ระบบด\u0e49วยช\u0e37\u0e48อผ\u0e39\u0e49ใช\u0e49ใหม\u0e48ของค\u0e38ณ";

	/// <summary>
	/// Key: "MessagePasswordCannotBeUsed"
	/// English String: "Sorry, that password cannot be used."
	/// </summary>
	public override string MessagePasswordCannotBeUsed => "ขออภ\u0e31ย รห\u0e31สผ\u0e48านน\u0e31\u0e49นไม\u0e48สามารถใช\u0e49งานได\u0e49";

	/// <summary>
	/// Key: "MessagePasswordsDoNotMatch"
	/// English String: "Passwords do not match"
	/// </summary>
	public override string MessagePasswordsDoNotMatch => "รห\u0e31สผ\u0e48านไม\u0e48ตรงก\u0e31น";

	/// <summary>
	/// Key: "MessageSamlUnauthenticated"
	/// English String: "You must log in to Roblox to finish authenticating."
	/// </summary>
	public override string MessageSamlUnauthenticated => "ค\u0e38ณจะต\u0e49องเข\u0e49าส\u0e39\u0e48ระบบ Roblox เพ\u0e37\u0e48อจบข\u0e31\u0e49นตอนการตรวจสอบความถ\u0e39กต\u0e49อง";

	/// <summary>
	/// Key: "MessageUnknownError"
	/// English String: "Unknown Error"
	/// </summary>
	public override string MessageUnknownError => "ข\u0e49อผ\u0e34ดพลาดท\u0e35\u0e48ไม\u0e48ทราบสาเหต\u0e38";

	/// <summary>
	/// Key: "MessageUnknownSystemError"
	/// English String: "System error. Please return to login screen."
	/// </summary>
	public override string MessageUnknownSystemError => "เก\u0e34ดข\u0e49อผ\u0e34ดพลาดก\u0e31บระบบ กร\u0e38ณากล\u0e31บส\u0e39\u0e48หน\u0e49าการเข\u0e49าส\u0e39\u0e48ระบบ";

	/// <summary>
	/// Key: "Placeholder.Email"
	/// English String: "Email"
	/// </summary>
	public override string PlaceholderEmail => "อ\u0e35เมล";

	/// <summary>
	/// Key: "Placeholder.PhoneNumber"
	/// English String: "Phone Number"
	/// </summary>
	public override string PlaceholderPhoneNumber => "หมายเลขโทรศ\u0e31พท\u0e4c";

	/// <summary>
	/// Key: "Response.PasswordResetSuccess"
	/// Password reset success! Please login again.
	/// English String: "Password reset success! Please login again."
	/// </summary>
	public override string ResponsePasswordResetSuccess => "ร\u0e35เซ\u0e47ตรห\u0e31สผ\u0e48านสำเร\u0e47จ! กร\u0e38ณาเข\u0e49าส\u0e39\u0e48ระบบใหม\u0e48อ\u0e35กคร\u0e31\u0e49ง";

	/// <summary>
	/// Key: "Response.Success"
	/// English String: "Success"
	/// </summary>
	public override string ResponseSuccess => "สำเร\u0e47จ";

	/// <summary>
	/// Key: "Response.UpdatePasswordFlooded"
	/// English String: "Too many attempts. Please try again later."
	/// </summary>
	public override string ResponseUpdatePasswordFlooded => "ม\u0e35การดำเน\u0e34นการซ\u0e49ำมากเก\u0e34นไป กร\u0e38ณาลองใหม\u0e48อ\u0e35กคร\u0e31\u0e49งในภายหล\u0e31ง";

	/// <summary>
	/// Key: "Response.UpdatePasswordIncorrect"
	/// English String: "Your current password is incorrect, the password was not changed."
	/// </summary>
	public override string ResponseUpdatePasswordIncorrect => "รห\u0e31สผ\u0e48านในป\u0e31จจ\u0e38บ\u0e31นของค\u0e38ณไม\u0e48ถ\u0e39กต\u0e49อง รห\u0e31สผ\u0e48านไม\u0e48ถ\u0e39กเปล\u0e35\u0e48ยน";

	/// <summary>
	/// Key: "Response.UpdatePasswordInputMissing"
	/// English String: "Must include new password and confirm password"
	/// </summary>
	public override string ResponseUpdatePasswordInputMissing => "จะต\u0e49องป\u0e49อนรห\u0e31สผ\u0e48านใหม\u0e48และย\u0e37นย\u0e31นรห\u0e31สผ\u0e48าน";

	/// <summary>
	/// Key: "Response.UpdatePasswordMismatch"
	/// English String: "Your new password and confirm password must match"
	/// </summary>
	public override string ResponseUpdatePasswordMismatch => "รห\u0e31สผ\u0e48านใหม\u0e48และย\u0e37นย\u0e31นรห\u0e31สผ\u0e48านจะต\u0e49องตรงก\u0e31น";

	public ResetPasswordResources_th_th(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "ยกเล\u0e34ก";
	}

	protected override string _GetTemplateForActionEmailToResetPassword()
	{
		return "ใช\u0e49อ\u0e35เมลเพ\u0e37\u0e48อร\u0e35เซ\u0e47ตรห\u0e31สผ\u0e48าน";
	}

	protected override string _GetTemplateForActionEmailToRetriveUsername()
	{
		return "ใช\u0e49อ\u0e35เมลเพ\u0e37\u0e48อร\u0e31บช\u0e37\u0e48อผ\u0e39\u0e49ใช\u0e49";
	}

	protected override string _GetTemplateForActionOk()
	{
		return "ตกลง";
	}

	protected override string _GetTemplateForActionPhoneToResetPassword()
	{
		return "ใช\u0e49หมายเลขโทรศ\u0e31พท\u0e4cเพ\u0e37\u0e48อร\u0e35เซ\u0e47ตรห\u0e31สผ\u0e48าน";
	}

	protected override string _GetTemplateForActionPhoneToRetriveUsername()
	{
		return "ใช\u0e49หมายเลขโทรศ\u0e31พท\u0e4cเพ\u0e37\u0e48อร\u0e31บช\u0e37\u0e48อผ\u0e39\u0e49ใช\u0e49";
	}

	protected override string _GetTemplateForActionVerify()
	{
		return "ตรวจสอบ";
	}

	/// <summary>
	/// Key: "Description.ChangePasswordEmail.HtmlBody1"
	/// email body for change password email
	/// English String: "We noticed that the password changed for your Roblox account: {userName}. If you didn't intend to change it, or you think someone else changed it by mistake, please click this link to undo the action:{lineBreak} {actionLink} {lineBreak}{lineBreak}If you are happy with your new Roblox password, you don't have to do anything! It's already set up. Please do not reply to this message. If you have any questions, please see the Roblox help page (https://www.roblox.com/help)."
	/// </summary>
	public override string DescriptionChangePasswordEmailHtmlBody1(string userName, string lineBreak, string actionLink)
	{
		return $"เราส\u0e31งเกตเห\u0e47นว\u0e48าม\u0e35การเปล\u0e35\u0e48ยนรห\u0e31สผ\u0e48านบ\u0e31ญช\u0e35 Roblox ของค\u0e38ณ: {userName} หากค\u0e38ณไม\u0e48ได\u0e49ต\u0e31\u0e49งใจเปล\u0e35\u0e48ยน หร\u0e37อค\u0e38ณค\u0e34ดว\u0e48าเป\u0e47นเหต\u0e38ผ\u0e34ดพลาดจากการท\u0e35\u0e48ม\u0e35คนอ\u0e37\u0e48นมาเปล\u0e35\u0e48ยน กร\u0e38ณาคล\u0e34กท\u0e35\u0e48ล\u0e34งก\u0e4cน\u0e35\u0e49เพ\u0e37\u0e48อยกเล\u0e34กการเปล\u0e35\u0e48ยนน\u0e31\u0e49น:{lineBreak} {actionLink} {lineBreak}{lineBreak}หากค\u0e38ณพอใจก\u0e31บรห\u0e31สผ\u0e48านบ\u0e31ญช\u0e35 Roblox ใหม\u0e48ของค\u0e38ณ ค\u0e38ณก\u0e47ไม\u0e48จำเป\u0e47นต\u0e49องดำเน\u0e34นการใดๆ เลย! ม\u0e31นพร\u0e49อมใช\u0e49งานแล\u0e49ว โปรดอย\u0e48าตอบกล\u0e31บข\u0e49อความน\u0e35\u0e49 หากค\u0e38ณม\u0e35คำถามใดๆ กร\u0e38ณาด\u0e39ท\u0e35\u0e48หน\u0e49าเพจช\u0e48วยเหล\u0e37อของ Roblox (https://www.roblox.com/help)";
	}

	protected override string _GetTemplateForDescriptionChangePasswordEmailHtmlBody1()
	{
		return "เราส\u0e31งเกตเห\u0e47นว\u0e48าม\u0e35การเปล\u0e35\u0e48ยนรห\u0e31สผ\u0e48านบ\u0e31ญช\u0e35 Roblox ของค\u0e38ณ: {userName} หากค\u0e38ณไม\u0e48ได\u0e49ต\u0e31\u0e49งใจเปล\u0e35\u0e48ยน หร\u0e37อค\u0e38ณค\u0e34ดว\u0e48าเป\u0e47นเหต\u0e38ผ\u0e34ดพลาดจากการท\u0e35\u0e48ม\u0e35คนอ\u0e37\u0e48นมาเปล\u0e35\u0e48ยน กร\u0e38ณาคล\u0e34กท\u0e35\u0e48ล\u0e34งก\u0e4cน\u0e35\u0e49เพ\u0e37\u0e48อยกเล\u0e34กการเปล\u0e35\u0e48ยนน\u0e31\u0e49น:{lineBreak} {actionLink} {lineBreak}{lineBreak}หากค\u0e38ณพอใจก\u0e31บรห\u0e31สผ\u0e48านบ\u0e31ญช\u0e35 Roblox ใหม\u0e48ของค\u0e38ณ ค\u0e38ณก\u0e47ไม\u0e48จำเป\u0e47นต\u0e49องดำเน\u0e34นการใดๆ เลย! ม\u0e31นพร\u0e49อมใช\u0e49งานแล\u0e49ว โปรดอย\u0e48าตอบกล\u0e31บข\u0e49อความน\u0e35\u0e49 หากค\u0e38ณม\u0e35คำถามใดๆ กร\u0e38ณาด\u0e39ท\u0e35\u0e48หน\u0e49าเพจช\u0e48วยเหล\u0e37อของ Roblox (https://www.roblox.com/help)";
	}

	protected override string _GetTemplateForDescriptionEmailToResetPassword()
	{
		return "ป\u0e49อนอ\u0e35เมลของค\u0e38ณเพ\u0e37\u0e48อร\u0e35เซ\u0e47ตรห\u0e31สผ\u0e48านของค\u0e38ณ";
	}

	protected override string _GetTemplateForDescriptionEmailToRetriveUsername()
	{
		return "ป\u0e49อนอ\u0e35เมลของค\u0e38ณเพ\u0e37\u0e48อร\u0e31บช\u0e37\u0e48อผ\u0e39\u0e49ใช\u0e49ของค\u0e38ณ";
	}

	/// <summary>
	/// Key: "Description.PasswordChangeEmail.BodyPlainText"
	/// password reset plaintext email message
	/// English String: "We noticed that the password changed for your Roblox account: {userName}. If you didn't intend to change it, or you think someone else changed it by mistake, please click this link to undo the action:\n{urlWithTicket}\n\nIf you are happy with your new Roblox password, you don't have to do anything! It's already set up. Please do not reply to this message. If you have any questions, please see the Roblox help page (https://www.roblox.com/help)."
	/// </summary>
	public override string DescriptionPasswordChangeEmailBodyPlainText(string userName, string urlWithTicket)
	{
		return $"เราส\u0e31งเกตเห\u0e47นว\u0e48าม\u0e35การเปล\u0e35\u0e48ยนรห\u0e31สผ\u0e48านบ\u0e31ญช\u0e35 Roblox ของค\u0e38ณ: {userName} หากค\u0e38ณไม\u0e48ได\u0e49ต\u0e31\u0e49งใจเปล\u0e35\u0e48ยน หร\u0e37อค\u0e38ณค\u0e34ดว\u0e48าเป\u0e47นเหต\u0e38ผ\u0e34ดพลาดจากการท\u0e35\u0e48ม\u0e35คนอ\u0e37\u0e48นมาเปล\u0e35\u0e48ยน กร\u0e38ณาคล\u0e34กท\u0e35\u0e48ล\u0e34งก\u0e4cน\u0e35\u0e49เพ\u0e37\u0e48อยกเล\u0e34กการเปล\u0e35\u0e48ยนน\u0e31\u0e49น:\n{urlWithTicket}\n\nหากค\u0e38ณพอใจก\u0e31บรห\u0e31สผ\u0e48านบ\u0e31ญช\u0e35 Roblox ใหม\u0e48ของค\u0e38ณ ค\u0e38ณก\u0e47ไม\u0e48จำเป\u0e47นต\u0e49องดำเน\u0e34นการใดๆ เลย! ม\u0e31นพร\u0e49อมใช\u0e49งานแล\u0e49ว โปรดอย\u0e48าตอบกล\u0e31บข\u0e49อความน\u0e35\u0e49 หากค\u0e38ณม\u0e35คำถามใดๆ กร\u0e38ณาด\u0e39ท\u0e35\u0e48หน\u0e49าเพจช\u0e48วยเหล\u0e37อของ Roblox (https://www.roblox.com/help)";
	}

	protected override string _GetTemplateForDescriptionPasswordChangeEmailBodyPlainText()
	{
		return "เราส\u0e31งเกตเห\u0e47นว\u0e48าม\u0e35การเปล\u0e35\u0e48ยนรห\u0e31สผ\u0e48านบ\u0e31ญช\u0e35 Roblox ของค\u0e38ณ: {userName} หากค\u0e38ณไม\u0e48ได\u0e49ต\u0e31\u0e49งใจเปล\u0e35\u0e48ยน หร\u0e37อค\u0e38ณค\u0e34ดว\u0e48าเป\u0e47นเหต\u0e38ผ\u0e34ดพลาดจากการท\u0e35\u0e48ม\u0e35คนอ\u0e37\u0e48นมาเปล\u0e35\u0e48ยน กร\u0e38ณาคล\u0e34กท\u0e35\u0e48ล\u0e34งก\u0e4cน\u0e35\u0e49เพ\u0e37\u0e48อยกเล\u0e34กการเปล\u0e35\u0e48ยนน\u0e31\u0e49น:\n{urlWithTicket}\n\nหากค\u0e38ณพอใจก\u0e31บรห\u0e31สผ\u0e48านบ\u0e31ญช\u0e35 Roblox ใหม\u0e48ของค\u0e38ณ ค\u0e38ณก\u0e47ไม\u0e48จำเป\u0e47นต\u0e49องดำเน\u0e34นการใดๆ เลย! ม\u0e31นพร\u0e49อมใช\u0e49งานแล\u0e49ว โปรดอย\u0e48าตอบกล\u0e31บข\u0e49อความน\u0e35\u0e49 หากค\u0e38ณม\u0e35คำถามใดๆ กร\u0e38ณาด\u0e39ท\u0e35\u0e48หน\u0e49าเพจช\u0e48วยเหล\u0e37อของ Roblox (https://www.roblox.com/help)";
	}

	/// <summary>
	/// Key: "Description.PasswordChangeEmail.From"
	/// name of the sender as shown in from field of the email
	/// English String: "\"Roblox Password Reset\" {fromEmailAddress}"
	/// </summary>
	public override string DescriptionPasswordChangeEmailFrom(string fromEmailAddress)
	{
		return $"\"การร\u0e35เซ\u0e47ตรห\u0e31สผ\u0e48านบ\u0e31ญช\u0e35 Roblox\" {fromEmailAddress}";
	}

	protected override string _GetTemplateForDescriptionPasswordChangeEmailFrom()
	{
		return "\"การร\u0e35เซ\u0e47ตรห\u0e31สผ\u0e48านบ\u0e31ญช\u0e35 Roblox\" {fromEmailAddress}";
	}

	protected override string _GetTemplateForDescriptionPasswordChangeEmailSubject()
	{
		return "การร\u0e35เซ\u0e47ตรห\u0e31สผ\u0e48านบ\u0e31ญช\u0e35 Roblox";
	}

	/// <summary>
	/// Key: "Description.PasswordResetEmail.From"
	/// The "From" field for the password reset email
	/// English String: "{escapeLiteralStart}Roblox Password Reset{escapeLiteralEnd} {fromEmailAddress}"
	/// </summary>
	public override string DescriptionPasswordResetEmailFrom(string escapeLiteralStart, string escapeLiteralEnd, string fromEmailAddress)
	{
		return $"{escapeLiteralStart}การร\u0e35เซ\u0e47ตรห\u0e31สผ\u0e48านบ\u0e31ญช\u0e35 Roblox{escapeLiteralEnd} {fromEmailAddress}";
	}

	protected override string _GetTemplateForDescriptionPasswordResetEmailFrom()
	{
		return "{escapeLiteralStart}การร\u0e35เซ\u0e47ตรห\u0e31สผ\u0e48านบ\u0e31ญช\u0e35 Roblox{escapeLiteralEnd} {fromEmailAddress}";
	}

	/// <summary>
	/// Key: "Description.PasswordResetEmail.HtmlBody"
	/// This email is sent when a user requests a password reset.
	/// English String: "We have received a request to reset the password for your Roblox account: {emailOrUsername}{lineBreak}{lineBreak}If you submitted this request, please click the button below to proceed.{lineBreak}This button will be active for {passwordResetTicketHours} hours, {passwordResetTicketMinutes} minutes. If you do not wish to reset your password, please disregard this notice.{lineBreak}{lineBreak}{aTagWithStartHref}{resetPasswordUrl}{hrefEnd}{buttonStart}Reset Password{buttonEnd}{aTagEnd}"
	/// </summary>
	public override string DescriptionPasswordResetEmailHtmlBody(string emailOrUsername, string lineBreak, string passwordResetTicketHours, string passwordResetTicketMinutes, string aTagWithStartHref, string resetPasswordUrl, string hrefEnd, string buttonStart, string buttonEnd, string aTagEnd)
	{
		return $"เราได\u0e49ร\u0e31บการร\u0e49องขอร\u0e35เซ\u0e47ตรห\u0e31สผ\u0e48านสำหร\u0e31บบ\u0e31ญช\u0e35 Roblox ของค\u0e38ณ: {emailOrUsername}{lineBreak}{lineBreak}หากค\u0e38ณเป\u0e47นผ\u0e39\u0e49ส\u0e48งคำร\u0e49องขอน\u0e35\u0e49 กร\u0e38ณาคล\u0e34กท\u0e35\u0e48ป\u0e38\u0e48มด\u0e49านล\u0e48างเพ\u0e37\u0e48อดำเน\u0e34นการต\u0e48อ{lineBreak}ป\u0e38\u0e48มน\u0e35\u0e49จะใช\u0e49งานได\u0e49เป\u0e47นเวลา {passwordResetTicketHours} ช\u0e31\u0e48วโมง {passwordResetTicketMinutes} นาท\u0e35 หากค\u0e38ณไม\u0e48ต\u0e49องการร\u0e35เซ\u0e47ตรห\u0e31สผ\u0e48านของค\u0e38ณ กร\u0e38ณาอย\u0e48าสนใจการแจ\u0e49งน\u0e35\u0e49{lineBreak}{lineBreak}{aTagWithStartHref}{resetPasswordUrl}{hrefEnd}{buttonStart}ร\u0e35เซ\u0e47ตรห\u0e31สผ\u0e48าน{buttonEnd}{aTagEnd}";
	}

	protected override string _GetTemplateForDescriptionPasswordResetEmailHtmlBody()
	{
		return "เราได\u0e49ร\u0e31บการร\u0e49องขอร\u0e35เซ\u0e47ตรห\u0e31สผ\u0e48านสำหร\u0e31บบ\u0e31ญช\u0e35 Roblox ของค\u0e38ณ: {emailOrUsername}{lineBreak}{lineBreak}หากค\u0e38ณเป\u0e47นผ\u0e39\u0e49ส\u0e48งคำร\u0e49องขอน\u0e35\u0e49 กร\u0e38ณาคล\u0e34กท\u0e35\u0e48ป\u0e38\u0e48มด\u0e49านล\u0e48างเพ\u0e37\u0e48อดำเน\u0e34นการต\u0e48อ{lineBreak}ป\u0e38\u0e48มน\u0e35\u0e49จะใช\u0e49งานได\u0e49เป\u0e47นเวลา {passwordResetTicketHours} ช\u0e31\u0e48วโมง {passwordResetTicketMinutes} นาท\u0e35 หากค\u0e38ณไม\u0e48ต\u0e49องการร\u0e35เซ\u0e47ตรห\u0e31สผ\u0e48านของค\u0e38ณ กร\u0e38ณาอย\u0e48าสนใจการแจ\u0e49งน\u0e35\u0e49{lineBreak}{lineBreak}{aTagWithStartHref}{resetPasswordUrl}{hrefEnd}{buttonStart}ร\u0e35เซ\u0e47ตรห\u0e31สผ\u0e48าน{buttonEnd}{aTagEnd}";
	}

	/// <summary>
	/// Key: "Description.PasswordResetEmail.PlainBody"
	/// This email is sent when a user requests a password reset.
	/// English String: "We have received a request to reset the password for your Roblox account: {emailOrUsername}{lineBreak}{lineBreak}If you submitted this request, please click the link below or paste it into a web browser to proceed.{lineBreak}This link will be active for {passwordResetTicketHours} hours, {passwordResetTicketMinutes} minutes. If you do not wish to reset your password, please disregard this notice.{lineBreak}{lineBreak}{resetPasswordUrl}"
	/// </summary>
	public override string DescriptionPasswordResetEmailPlainBody(string emailOrUsername, string lineBreak, string passwordResetTicketHours, string passwordResetTicketMinutes, string resetPasswordUrl)
	{
		return $"เราได\u0e49ร\u0e31บการร\u0e49องขอร\u0e35เซ\u0e47ตรห\u0e31สผ\u0e48านสำหร\u0e31บบ\u0e31ญช\u0e35 Roblox ของค\u0e38ณ: {emailOrUsername}{lineBreak}{lineBreak}หากค\u0e38ณเป\u0e47นผ\u0e39\u0e49ส\u0e48งคำร\u0e49องขอน\u0e35\u0e49 กร\u0e38ณาคล\u0e34กท\u0e35\u0e48ล\u0e34งก\u0e4cด\u0e49านล\u0e48างหร\u0e37อค\u0e31ดลอกแล\u0e49วนำไปวางท\u0e35\u0e48เบราว\u0e4cเซอร\u0e4cของค\u0e38ณเพ\u0e37\u0e48อดำเน\u0e34นการต\u0e48อ{lineBreak}ล\u0e34งก\u0e4cน\u0e35\u0e49จะใช\u0e49งานได\u0e49เป\u0e47นเวลา {passwordResetTicketHours} ช\u0e31\u0e48วโมง {passwordResetTicketMinutes} นาท\u0e35 หากค\u0e38ณไม\u0e48ต\u0e49องการร\u0e35เซ\u0e47ตรห\u0e31สผ\u0e48านของค\u0e38ณ กร\u0e38ณาอย\u0e48าสนใจการแจ\u0e49งน\u0e35\u0e49{lineBreak}{lineBreak}{resetPasswordUrl}";
	}

	protected override string _GetTemplateForDescriptionPasswordResetEmailPlainBody()
	{
		return "เราได\u0e49ร\u0e31บการร\u0e49องขอร\u0e35เซ\u0e47ตรห\u0e31สผ\u0e48านสำหร\u0e31บบ\u0e31ญช\u0e35 Roblox ของค\u0e38ณ: {emailOrUsername}{lineBreak}{lineBreak}หากค\u0e38ณเป\u0e47นผ\u0e39\u0e49ส\u0e48งคำร\u0e49องขอน\u0e35\u0e49 กร\u0e38ณาคล\u0e34กท\u0e35\u0e48ล\u0e34งก\u0e4cด\u0e49านล\u0e48างหร\u0e37อค\u0e31ดลอกแล\u0e49วนำไปวางท\u0e35\u0e48เบราว\u0e4cเซอร\u0e4cของค\u0e38ณเพ\u0e37\u0e48อดำเน\u0e34นการต\u0e48อ{lineBreak}ล\u0e34งก\u0e4cน\u0e35\u0e49จะใช\u0e49งานได\u0e49เป\u0e47นเวลา {passwordResetTicketHours} ช\u0e31\u0e48วโมง {passwordResetTicketMinutes} นาท\u0e35 หากค\u0e38ณไม\u0e48ต\u0e49องการร\u0e35เซ\u0e47ตรห\u0e31สผ\u0e48านของค\u0e38ณ กร\u0e38ณาอย\u0e48าสนใจการแจ\u0e49งน\u0e35\u0e49{lineBreak}{lineBreak}{resetPasswordUrl}";
	}

	protected override string _GetTemplateForDescriptionPasswordResetEmailSubject()
	{
		return "การร\u0e35เซ\u0e47ตรห\u0e31สผ\u0e48านบ\u0e31ญช\u0e35 Roblox";
	}

	protected override string _GetTemplateForDescriptionPhoneToResetPassword()
	{
		return "ป\u0e49อนหมายเลขโทรศ\u0e31พท\u0e4cของค\u0e38ณเพ\u0e37\u0e48อร\u0e35เซ\u0e47ตรห\u0e31สผ\u0e48านของค\u0e38ณ";
	}

	protected override string _GetTemplateForDescriptionPhoneToRetriveUsername()
	{
		return "ป\u0e49อนหมายเลขโทรศ\u0e31พท\u0e4cของค\u0e38ณเพ\u0e37\u0e48อร\u0e31บช\u0e37\u0e48อผ\u0e39\u0e49ใช\u0e49ของค\u0e38ณ";
	}

	protected override string _GetTemplateForHeadingVerifyCode()
	{
		return "ตรวจสอบรห\u0e31ส";
	}

	protected override string _GetTemplateForHeadingVerifyPhone()
	{
		return "ตรวจสอบโทรศ\u0e31พท\u0e4c";
	}

	protected override string _GetTemplateForHeadingForgetPasswordOrUsername()
	{
		return "ล\u0e37มรห\u0e31สผ\u0e48านหร\u0e37อช\u0e37\u0e48อผ\u0e39\u0e49ใช\u0e49";
	}

	protected override string _GetTemplateForLabelActionButtonYes()
	{
		return "ใช\u0e48";
	}

	protected override string _GetTemplateForLabelForgetMyPassword()
	{
		return "ล\u0e37มรห\u0e31สผ\u0e48านของฉ\u0e31น";
	}

	protected override string _GetTemplateForLabelForgetMyUsername()
	{
		return "ล\u0e37มช\u0e37\u0e48อผ\u0e39\u0e49ใช\u0e49ของฉ\u0e31น";
	}

	protected override string _GetTemplateForLabelInvalidEmail()
	{
		return "อ\u0e35เมลไม\u0e48ถ\u0e39กต\u0e49อง";
	}

	protected override string _GetTemplateForLabelInvalidPhoneNumber()
	{
		return "หมายเลขโทรศ\u0e31พท\u0e4cไม\u0e48ถ\u0e39กต\u0e49อง";
	}

	protected override string _GetTemplateForLabelNeutralButtonOk()
	{
		return "ตกลง";
	}

	protected override string _GetTemplateForLabelPassword()
	{
		return "รห\u0e31สผ\u0e48าน";
	}

	protected override string _GetTemplateForLabelResendCode()
	{
		return "ส\u0e48งรห\u0e31สใหม\u0e48";
	}

	protected override string _GetTemplateForLabelSubmit()
	{
		return "ส\u0e48ง";
	}

	protected override string _GetTemplateForLabelToolTipWhoCanFindMeByPhone()
	{
		return "การต\u0e31\u0e49งค\u0e48าน\u0e35\u0e49ควบค\u0e38มว\u0e48า ใครบ\u0e49างท\u0e35\u0e48จะสามารถพบว\u0e48าค\u0e38ณใช\u0e49หมายเลขโทรศ\u0e31พท\u0e4cท\u0e35\u0e48ค\u0e38ณได\u0e49แจ\u0e49งไว\u0e49";
	}

	protected override string _GetTemplateForLabelUsername()
	{
		return "ช\u0e37\u0e48อผ\u0e39\u0e49ใช\u0e49";
	}

	protected override string _GetTemplateForLabelWhoCanFindMeByPhone()
	{
		return "ใครบ\u0e49างท\u0e35\u0e48สามารถด\u0e39หมายเลขโทรศ\u0e31พท\u0e4cของฉ\u0e31นได\u0e49?";
	}

	/// <summary>
	/// Key: "Message.CantSendEmailWarning"
	/// English String: "If you did not give us a {styleStart}real email address{styleEnd} when you created your account, we cannot send you an email."
	/// </summary>
	public override string MessageCantSendEmailWarning(string styleStart, string styleEnd)
	{
		return $"หากค\u0e38ณไม\u0e48ได\u0e49ให\u0e49{styleStart}ท\u0e35\u0e48อย\u0e39\u0e48อ\u0e35เมลจร\u0e34ง{styleEnd}แก\u0e48เราเม\u0e37\u0e48อค\u0e38ณสร\u0e49างบ\u0e31ญช\u0e35ของค\u0e38ณ เราจะไม\u0e48สามารถส\u0e48งอ\u0e35เมลให\u0e49ค\u0e38ณได\u0e49";
	}

	protected override string _GetTemplateForMessageCantSendEmailWarning()
	{
		return "หากค\u0e38ณไม\u0e48ได\u0e49ให\u0e49{styleStart}ท\u0e35\u0e48อย\u0e39\u0e48อ\u0e35เมลจร\u0e34ง{styleEnd}แก\u0e48เราเม\u0e37\u0e48อค\u0e38ณสร\u0e49างบ\u0e31ญช\u0e35ของค\u0e38ณ เราจะไม\u0e48สามารถส\u0e48งอ\u0e35เมลให\u0e49ค\u0e38ณได\u0e49";
	}

	protected override string _GetTemplateForMessageDefaultError()
	{
		return "เก\u0e34ดข\u0e49อผ\u0e34ดพลาด กร\u0e38ณาลองใหม\u0e48อ\u0e35กคร\u0e31\u0e49งในภายหล\u0e31ง";
	}

	protected override string _GetTemplateForMessageEmailForUsernameSuccessBody()
	{
		return "ม\u0e35การส\u0e48งอ\u0e35เมลพร\u0e49อมช\u0e37\u0e48อผ\u0e39\u0e49ใช\u0e49ของค\u0e38ณไปให\u0e49 หากได\u0e49ทำการบ\u0e31นท\u0e36กอ\u0e35เมลของค\u0e38ณไว\u0e49สำหร\u0e31บบ\u0e31ญช\u0e35น\u0e35\u0e49";
	}

	protected override string _GetTemplateForMessageEmailSuccessBody()
	{
		return "ม\u0e35การส\u0e48งอ\u0e35เมลพร\u0e49อมข\u0e31\u0e49นตอนไปให\u0e49ค\u0e38ณ หากได\u0e49ทำการบ\u0e31นท\u0e36กอ\u0e35เมลของค\u0e38ณไว\u0e49สำหร\u0e31บบ\u0e31ญช\u0e35น\u0e35\u0e49";
	}

	protected override string _GetTemplateForMessageEmailSuccessTitle()
	{
		return "ส\u0e48งอ\u0e35เมลแล\u0e49ว";
	}

	protected override string _GetTemplateForMessageEnterCode()
	{
		return "ได\u0e49ม\u0e35การส\u0e48งรห\u0e31สไปย\u0e31งโทรศ\u0e31พท\u0e4cของค\u0e38ณหากค\u0e38ณได\u0e49ย\u0e37นย\u0e31นโทรศ\u0e31พท\u0e4cของค\u0e38ณไว\u0e49สำหร\u0e31บบ\u0e31ญช\u0e35น\u0e35\u0e49 กร\u0e38ณาป\u0e49อนรห\u0e31สด\u0e49านล\u0e48างน\u0e35\u0e49";
	}

	protected override string _GetTemplateForMessageEnterCodeSentToEmail()
	{
		return "ป\u0e49อนรห\u0e31สท\u0e35\u0e48เราเพ\u0e34\u0e48งส\u0e48งให\u0e49ค\u0e38ณทางอ\u0e35เมล";
	}

	protected override string _GetTemplateForMessagePhoneForUsernameSuccessBody()
	{
		return "ม\u0e35การส\u0e48ง SMS พร\u0e49อมช\u0e37\u0e48อผ\u0e39\u0e49ใช\u0e49ของค\u0e38ณไปให\u0e49 หากได\u0e49ทำการย\u0e37นย\u0e31นหมายเลขโทรศ\u0e31พท\u0e4cไว\u0e49สำหร\u0e31บบ\u0e31ญช\u0e35ของค\u0e38ณก\u0e48อนหน\u0e49าน\u0e35\u0e49";
	}

	protected override string _GetTemplateForMessagePhoneForUsernameSuccessTitle()
	{
		return "ส\u0e48ง SMS แล\u0e49ว";
	}

	protected override string _GetTemplateForMessageAccountDoesNotHaveAnEmail()
	{
		return "ไม\u0e48ม\u0e35อ\u0e35เมลท\u0e35\u0e48เช\u0e37\u0e48อมโยงอย\u0e39\u0e48ก\u0e31บบ\u0e31ญช\u0e35น\u0e35\u0e49";
	}

	protected override string _GetTemplateForMessageAccountNotFoundByEmail()
	{
		return "ไม\u0e48พบบ\u0e31ญช\u0e35 กร\u0e38ณาระบ\u0e38อ\u0e35เมลอ\u0e37\u0e48น";
	}

	protected override string _GetTemplateForMessageAccountNotFoundByPhone()
	{
		return "ไม\u0e48พบบ\u0e31ญช\u0e35 กร\u0e38ณาระบ\u0e38หมายเลขโทรศ\u0e31พท\u0e4cอ\u0e37\u0e48น";
	}

	protected override string _GetTemplateForMessageAccountRecoveryUnknownError()
	{
		return "เก\u0e34ดข\u0e49อผ\u0e34ดพลาดก\u0e31บระบบ ไม\u0e48สามารถก\u0e39\u0e49ค\u0e37นบ\u0e31ญช\u0e35กล\u0e31บมาส\u0e39\u0e48สถานะน\u0e35\u0e49ได\u0e49";
	}

	protected override string _GetTemplateForMessageCaptchaError()
	{
		return "เราจำเป\u0e47นต\u0e49องตรวจสอบให\u0e49แน\u0e48ใจว\u0e48าค\u0e38ณไม\u0e48ใช\u0e48ห\u0e38\u0e48นยนต\u0e4c!";
	}

	protected override string _GetTemplateForMessageCaptchaFailError()
	{
		return "คำท\u0e35\u0e48ค\u0e38ณพ\u0e34มพ\u0e4cไม\u0e48ตรงก\u0e31บภาพ กร\u0e38ณาลองใหม\u0e48อ\u0e35กคร\u0e31\u0e49ง";
	}

	protected override string _GetTemplateForMessageCredentialsError()
	{
		return "ช\u0e37\u0e48อผ\u0e39\u0e49ใช\u0e49หร\u0e37อรห\u0e31สผ\u0e48านของค\u0e38ณไม\u0e48ถ\u0e39กต\u0e49อง กร\u0e38ณาตรวจสอบแล\u0e49วลองใหม\u0e48อ\u0e35กคร\u0e31\u0e49ง";
	}

	protected override string _GetTemplateForMessageFloodCheckedError()
	{
		return "ม\u0e35การดำเน\u0e34นการซ\u0e49ำมากเก\u0e34นไป กร\u0e38ณาลองใหม\u0e48อ\u0e35กคร\u0e31\u0e49งในภายหล\u0e31ง";
	}

	protected override string _GetTemplateForMessageForgotPasswordFeatureDisabled()
	{
		return "ค\u0e38ณล\u0e31กษณะถ\u0e39กป\u0e34ดการใช\u0e49งานช\u0e31\u0e48วคราว กร\u0e38ณาลองใหม\u0e48อ\u0e35กคร\u0e31\u0e49ง";
	}

	protected override string _GetTemplateForMessageForgotPasswordSuccess()
	{
		return "ตรวจสอบอ\u0e35เมลเพ\u0e37\u0e48อด\u0e39คำแนะนำการเข\u0e49าส\u0e39\u0e48ระบบ";
	}

	protected override string _GetTemplateForMessageInvalidAccountStatus()
	{
		return "สถานะบ\u0e31ญช\u0e35ข\u0e31ดขวางไม\u0e48ให\u0e49ทำการร\u0e35เซ\u0e47ตรห\u0e31สผ\u0e48าน";
	}

	protected override string _GetTemplateForMessageInvalidPassword()
	{
		return "รห\u0e31สผ\u0e48านไม\u0e48ถ\u0e39กต\u0e49อง";
	}

	protected override string _GetTemplateForMessageInvalidTicket()
	{
		return "เราไม\u0e48สามารถโหลดต\u0e31\u0e4bวร\u0e31กษาความปลอดภ\u0e31ยน\u0e35\u0e49ได\u0e49";
	}

	protected override string _GetTemplateForMessageInvalidUserNameOrEmail()
	{
		return "ช\u0e37\u0e48อผ\u0e39\u0e49ใช\u0e49ไม\u0e48ถ\u0e39กต\u0e49องหร\u0e37อไม\u0e48ม\u0e35อ\u0e35เมลน\u0e31\u0e49นอย\u0e39\u0e48";
	}

	protected override string _GetTemplateForMessageMobileResetPasswordSuccess()
	{
		return "MobileResetPasswordSuccess";
	}

	protected override string _GetTemplateForMessageNoAccountsLinkedToEmail()
	{
		return "ไม\u0e48ม\u0e35บ\u0e31ญช\u0e35ท\u0e35\u0e48เช\u0e37\u0e48อมโยงอย\u0e39\u0e48ก\u0e31บท\u0e35\u0e48อย\u0e39\u0e48อ\u0e35เมลน\u0e35\u0e49";
	}

	protected override string _GetTemplateForMessageOldUsernameError()
	{
		return "ด\u0e39เหม\u0e37อนว\u0e48าค\u0e38ณพยายามเข\u0e49าส\u0e39\u0e48ระบบด\u0e49วยช\u0e37\u0e48อผ\u0e39\u0e49ใช\u0e49ท\u0e35\u0e48ม\u0e35การเปล\u0e35\u0e48ยนแปลงไปแล\u0e49ว กร\u0e38ณาเข\u0e49าส\u0e39\u0e48ระบบด\u0e49วยช\u0e37\u0e48อผ\u0e39\u0e49ใช\u0e49ใหม\u0e48ของค\u0e38ณ";
	}

	protected override string _GetTemplateForMessagePasswordCannotBeUsed()
	{
		return "ขออภ\u0e31ย รห\u0e31สผ\u0e48านน\u0e31\u0e49นไม\u0e48สามารถใช\u0e49งานได\u0e49";
	}

	/// <summary>
	/// Key: "MessagePasswordResetTicketExpired"
	/// English String: "Sorry, password reset requests expire {expirationHour} hours, {expirationMinute} minutes after issuance. Try requesting another password reset ticket again."
	/// </summary>
	public override string MessagePasswordResetTicketExpired(string expirationHour, string expirationMinute)
	{
		return $"ขออภ\u0e31ย การร\u0e35เซ\u0e47ตรห\u0e31สผ\u0e48านจะหมดเวลาลงใน {expirationHour} ช\u0e31\u0e48วโมง {expirationMinute} นาท\u0e35 หล\u0e31งจากการย\u0e37\u0e48นเร\u0e37\u0e48อง ลองย\u0e37\u0e48นขอต\u0e31\u0e4bวร\u0e35เซ\u0e47ตรห\u0e31สผ\u0e48านใหม\u0e48อ\u0e35กคร\u0e31\u0e49ง";
	}

	protected override string _GetTemplateForMessagePasswordResetTicketExpired()
	{
		return "ขออภ\u0e31ย การร\u0e35เซ\u0e47ตรห\u0e31สผ\u0e48านจะหมดเวลาลงใน {expirationHour} ช\u0e31\u0e48วโมง {expirationMinute} นาท\u0e35 หล\u0e31งจากการย\u0e37\u0e48นเร\u0e37\u0e48อง ลองย\u0e37\u0e48นขอต\u0e31\u0e4bวร\u0e35เซ\u0e47ตรห\u0e31สผ\u0e48านใหม\u0e48อ\u0e35กคร\u0e31\u0e49ง";
	}

	protected override string _GetTemplateForMessagePasswordsDoNotMatch()
	{
		return "รห\u0e31สผ\u0e48านไม\u0e48ตรงก\u0e31น";
	}

	protected override string _GetTemplateForMessageSamlUnauthenticated()
	{
		return "ค\u0e38ณจะต\u0e49องเข\u0e49าส\u0e39\u0e48ระบบ Roblox เพ\u0e37\u0e48อจบข\u0e31\u0e49นตอนการตรวจสอบความถ\u0e39กต\u0e49อง";
	}

	protected override string _GetTemplateForMessageUnknownError()
	{
		return "ข\u0e49อผ\u0e34ดพลาดท\u0e35\u0e48ไม\u0e48ทราบสาเหต\u0e38";
	}

	protected override string _GetTemplateForMessageUnknownSystemError()
	{
		return "เก\u0e34ดข\u0e49อผ\u0e34ดพลาดก\u0e31บระบบ กร\u0e38ณากล\u0e31บส\u0e39\u0e48หน\u0e49าการเข\u0e49าส\u0e39\u0e48ระบบ";
	}

	protected override string _GetTemplateForPlaceholderEmail()
	{
		return "อ\u0e35เมล";
	}

	/// <summary>
	/// Key: "Placeholder.EnterCode"
	/// English String: "Enter Code ({codeLength}-digit)"
	/// </summary>
	public override string PlaceholderEnterCode(string codeLength)
	{
		return $"ป\u0e49อนรห\u0e31ส ({codeLength} หล\u0e31ก)";
	}

	protected override string _GetTemplateForPlaceholderEnterCode()
	{
		return "ป\u0e49อนรห\u0e31ส ({codeLength} หล\u0e31ก)";
	}

	protected override string _GetTemplateForPlaceholderPhoneNumber()
	{
		return "หมายเลขโทรศ\u0e31พท\u0e4c";
	}

	protected override string _GetTemplateForResponsePasswordResetSuccess()
	{
		return "ร\u0e35เซ\u0e47ตรห\u0e31สผ\u0e48านสำเร\u0e47จ! กร\u0e38ณาเข\u0e49าส\u0e39\u0e48ระบบใหม\u0e48อ\u0e35กคร\u0e31\u0e49ง";
	}

	protected override string _GetTemplateForResponseSuccess()
	{
		return "สำเร\u0e47จ";
	}

	protected override string _GetTemplateForResponseUpdatePasswordFlooded()
	{
		return "ม\u0e35การดำเน\u0e34นการซ\u0e49ำมากเก\u0e34นไป กร\u0e38ณาลองใหม\u0e48อ\u0e35กคร\u0e31\u0e49งในภายหล\u0e31ง";
	}

	protected override string _GetTemplateForResponseUpdatePasswordIncorrect()
	{
		return "รห\u0e31สผ\u0e48านในป\u0e31จจ\u0e38บ\u0e31นของค\u0e38ณไม\u0e48ถ\u0e39กต\u0e49อง รห\u0e31สผ\u0e48านไม\u0e48ถ\u0e39กเปล\u0e35\u0e48ยน";
	}

	protected override string _GetTemplateForResponseUpdatePasswordInputMissing()
	{
		return "จะต\u0e49องป\u0e49อนรห\u0e31สผ\u0e48านใหม\u0e48และย\u0e37นย\u0e31นรห\u0e31สผ\u0e48าน";
	}

	protected override string _GetTemplateForResponseUpdatePasswordMismatch()
	{
		return "รห\u0e31สผ\u0e48านใหม\u0e48และย\u0e37นย\u0e31นรห\u0e31สผ\u0e48านจะต\u0e49องตรงก\u0e31น";
	}
}
