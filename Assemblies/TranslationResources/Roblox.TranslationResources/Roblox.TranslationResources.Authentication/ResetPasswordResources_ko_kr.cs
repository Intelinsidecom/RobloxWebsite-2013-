namespace Roblox.TranslationResources.Authentication;

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
	public override string ActionCancel => "취소";

	/// <summary>
	/// Key: "Action.EmailToResetPassword"
	/// English String: "Use email to reset password"
	/// </summary>
	public override string ActionEmailToResetPassword => "비밀번호 재설정하려면 이메일을 사용하세요";

	/// <summary>
	/// Key: "Action.EmailToRetriveUsername"
	/// English String: "Use email to retrieve username"
	/// </summary>
	public override string ActionEmailToRetriveUsername => "사용자 이름을 찾으려면 이메일을 사용하세요";

	/// <summary>
	/// Key: "Action.Ok"
	/// OK
	/// English String: "OK"
	/// </summary>
	public override string ActionOk => "확인";

	/// <summary>
	/// Key: "Action.PhoneToResetPassword"
	/// English String: "Use phone number to reset password"
	/// </summary>
	public override string ActionPhoneToResetPassword => "비밀번호를 재설정하려면 전화번호를 사용하세요";

	/// <summary>
	/// Key: "Action.PhoneToRetriveUsername"
	/// English String: "Use phone number to retrieve username"
	/// </summary>
	public override string ActionPhoneToRetriveUsername => "사용자 이름을 찾으려면 전화번호를 사용하세요";

	/// <summary>
	/// Key: "Action.Verify"
	/// English String: "Verify"
	/// </summary>
	public override string ActionVerify => "인증";

	/// <summary>
	/// Key: "Description.EmailToResetPassword"
	/// English String: "Enter your email to reset your password."
	/// </summary>
	public override string DescriptionEmailToResetPassword => "비밀번호를 재설정하려면 이메일을 입력하세요.";

	/// <summary>
	/// Key: "Description.EmailToRetriveUsername"
	/// English String: "Enter your email to retrieve your username."
	/// </summary>
	public override string DescriptionEmailToRetriveUsername => "사용자 이름을 찾으려면 이메일을 입력하세요.";

	/// <summary>
	/// Key: "Description.PasswordChangeEmail.Subject"
	/// email subject to change password
	/// English String: "Roblox Password Reset"
	/// </summary>
	public override string DescriptionPasswordChangeEmailSubject => "Roblox 비밀번호 재설정";

	/// <summary>
	/// Key: "Description.PasswordResetEmail.Subject"
	/// Subject for password reset email
	/// English String: "Roblox Account Password Reset"
	/// </summary>
	public override string DescriptionPasswordResetEmailSubject => "Roblox 계정 비밀번호 재설정";

	/// <summary>
	/// Key: "Description.PhoneToResetPassword"
	/// English String: "Enter your phone number to reset your password."
	/// </summary>
	public override string DescriptionPhoneToResetPassword => "비밀번호를 재설정하려면 전화번호를 입력하세요.";

	/// <summary>
	/// Key: "Description.PhoneToRetriveUsername"
	/// English String: "Enter your phone number to retrieve your username."
	/// </summary>
	public override string DescriptionPhoneToRetriveUsername => "사용자 이름을 찾으려면 전화번호를 입력하세요.";

	/// <summary>
	/// Key: "Heading.VerifyCode"
	/// verify code heading
	/// English String: "Verify Code"
	/// </summary>
	public override string HeadingVerifyCode => "코드 인증";

	/// <summary>
	/// Key: "Heading.VerifyPhone"
	/// English String: "Verify Phone"
	/// </summary>
	public override string HeadingVerifyPhone => "전화번호 인증";

	/// <summary>
	/// Key: "HeadingForgetPasswordOrUsername"
	/// English String: "Forgot Password or Username"
	/// </summary>
	public override string HeadingForgetPasswordOrUsername => "비밀번호 또는 사용자 이름 분실";

	/// <summary>
	/// Key: "Label.ActionButtonYes"
	/// button label
	/// English String: "Yes"
	/// </summary>
	public override string LabelActionButtonYes => "예";

	/// <summary>
	/// Key: "Label.ForgetMyPassword"
	/// English String: "Forgot My Password"
	/// </summary>
	public override string LabelForgetMyPassword => "내 비밀번호를 잊었습니다";

	/// <summary>
	/// Key: "Label.ForgetMyUsername"
	/// English String: "Forgot My Username"
	/// </summary>
	public override string LabelForgetMyUsername => "내 사용자 이름을 잊었습니다";

	/// <summary>
	/// Key: "Label.InvalidEmail"
	/// English String: "Invalid email"
	/// </summary>
	public override string LabelInvalidEmail => "유효하지 않은 이메일";

	/// <summary>
	/// Key: "Label.InvalidPhoneNumber"
	/// English String: "Invalid phone number"
	/// </summary>
	public override string LabelInvalidPhoneNumber => "유효하지 않은 전화번호";

	/// <summary>
	/// Key: "Label.NeutralButtonOk"
	/// ok button label
	/// English String: "OK"
	/// </summary>
	public override string LabelNeutralButtonOk => "확인";

	/// <summary>
	/// Key: "Label.Password"
	/// label
	/// English String: "Password"
	/// </summary>
	public override string LabelPassword => "비밀번호";

	/// <summary>
	/// Key: "Label.ResendCode"
	/// English String: "Resend Code"
	/// </summary>
	public override string LabelResendCode => "코드 재전송";

	/// <summary>
	/// Key: "Label.Submit"
	/// English String: "Submit"
	/// </summary>
	public override string LabelSubmit => "제출";

	/// <summary>
	/// Key: "Label.ToolTip.WhoCanFindMeByPhone"
	/// English String: "This setting controls who can find you using the phone number you provided."
	/// </summary>
	public override string LabelToolTipWhoCanFindMeByPhone => "입력하신 전화번호를 사용하여 회원님을 찾을 수 있는 사용자를 설정합니다.";

	/// <summary>
	/// Key: "Label.Username"
	/// English String: "Username"
	/// </summary>
	public override string LabelUsername => "사용자 이름";

	/// <summary>
	/// Key: "Label.WhoCanFindMeByPhone"
	/// English String: "Who can find me by my phone number?"
	/// </summary>
	public override string LabelWhoCanFindMeByPhone => "누가 내 전화번호로 나를 찾을 수 있나요?";

	/// <summary>
	/// Key: "Message.DefaultError"
	/// English String: "An error occurred, try again later."
	/// </summary>
	public override string MessageDefaultError => "오류가 발생했어요. 나중에 다시 시도하세요.";

	/// <summary>
	/// Key: "Message.EmailForUsernameSuccessBody"
	/// success message
	/// English String: "An email with your username(s) has been sent to you if the email was previously saved on your account."
	/// </summary>
	public override string MessageEmailForUsernameSuccessBody => "계정에서 사전에 저장된 이메일 주소로 사용자 이름이 포함된 메일이 발송되었어요.";

	/// <summary>
	/// Key: "Message.EmailSuccessBody"
	/// English String: "An email with instructions has been sent to you if the email was previously saved on your account."
	/// </summary>
	public override string MessageEmailSuccessBody => "계정에서 사전에 저장된 이메일 주소로 지침이 포함된 메일이 발송되었어요.";

	/// <summary>
	/// Key: "Message.EmailSuccessTitle"
	/// English String: "Email Sent"
	/// </summary>
	public override string MessageEmailSuccessTitle => "이메일 전송 완료";

	/// <summary>
	/// Key: "Message.EnterCode"
	/// English String: "A code was sent to your phone if it was previously verified on your account. Please enter it below"
	/// </summary>
	public override string MessageEnterCode => "계정에서 사전에 인증된 휴대폰으로 코드가 전송되었어요. 아래에 코드를 입력하세요.";

	/// <summary>
	/// Key: "Message.EnterCodeSentToEmail"
	/// Enter the code we just sent to your email.
	/// English String: "Enter the code we just sent to your email."
	/// </summary>
	public override string MessageEnterCodeSentToEmail => "이메일로 방금 발송된 코드를 입력하세요.";

	/// <summary>
	/// Key: "Message.PhoneForUsernameSuccessBody"
	/// English String: "An SMS with your username(s) has been sent to you if the phone number was previously verified on your account."
	/// </summary>
	public override string MessagePhoneForUsernameSuccessBody => "계정에서 사전에 인증된 전화번호로 사용자 이름이 포함된 SMS가 발송되었어요.";

	/// <summary>
	/// Key: "Message.PhoneForUsernameSuccessTitle"
	/// English String: "SMS Sent"
	/// </summary>
	public override string MessagePhoneForUsernameSuccessTitle => "SMS 전송 완료";

	/// <summary>
	/// Key: "MessageAccountDoesNotHaveAnEmail"
	/// English String: "There is no email linked to this account"
	/// </summary>
	public override string MessageAccountDoesNotHaveAnEmail => "본 계정에 연결된 이메일이 존재하지 않습니다.";

	/// <summary>
	/// Key: "MessageAccountNotFoundByEmail"
	/// No account found. Please use a different email.
	/// English String: "No account found. Please use a different email."
	/// </summary>
	public override string MessageAccountNotFoundByEmail => "계정을 찾을 수 없습니다. 다른 이메일을 사용하세요.";

	/// <summary>
	/// Key: "MessageAccountNotFoundByPhone"
	/// No account found. Please use a different phone number.
	/// English String: "No account found. Please use a different phone number."
	/// </summary>
	public override string MessageAccountNotFoundByPhone => "계정을 찾을 수 없습니다. 다른 전화번호를 사용하세요.";

	/// <summary>
	/// Key: "MessageAccountRecoveryUnknownError"
	/// English String: "System error. Account could not be restored to this state."
	/// </summary>
	public override string MessageAccountRecoveryUnknownError => "시스템 오류. 계정을 본 상태로 복구하지 못했습니다.";

	/// <summary>
	/// Key: "MessageCaptchaError"
	/// English String: "We need to make sure you're not a robot!"
	/// </summary>
	public override string MessageCaptchaError => "로봇이 아님을 확인해야 합니다!";

	/// <summary>
	/// Key: "MessageCaptchaFailError"
	/// English String: "The words you typed didn't match the picture. Please try again."
	/// </summary>
	public override string MessageCaptchaFailError => "입력한 단어가 사진과 일치하지 않습니다. 다시 시도하세요.";

	/// <summary>
	/// Key: "MessageCredentialsError"
	/// English String: "Your username or password is incorrect. Please check them and try again."
	/// </summary>
	public override string MessageCredentialsError => "사용자 이름 또는 비밀번호가 일치하지 않습니다. 확인 후 다시 시도하세요.";

	/// <summary>
	/// Key: "MessageFloodCheckedError"
	/// English String: "Too many attempts. Please try again later."
	/// </summary>
	public override string MessageFloodCheckedError => "시도 가능 횟수를 초과하였습니다. 나중에 다시 시도하세요.";

	/// <summary>
	/// Key: "MessageForgotPasswordFeatureDisabled"
	/// English String: "Feature temporarily disabled. Please try again later."
	/// </summary>
	public override string MessageForgotPasswordFeatureDisabled => "일시적 기능 비활성화. 나중에 다시 시도하세요.";

	/// <summary>
	/// Key: "MessageForgotPasswordSuccess"
	/// English String: "Check your email for login instructions"
	/// </summary>
	public override string MessageForgotPasswordSuccess => "로그인 안내를 위해 이메일을 확인하세요.";

	/// <summary>
	/// Key: "MessageInvalidAccountStatus"
	/// English String: "Account status prevents resetting password"
	/// </summary>
	public override string MessageInvalidAccountStatus => "비밀번호 재설정이 불가능한 계정 상태";

	/// <summary>
	/// Key: "MessageInvalidPassword"
	/// English String: "Invalid password"
	/// </summary>
	public override string MessageInvalidPassword => "유효하지 않은 비밀번호";

	/// <summary>
	/// Key: "MessageInvalidTicket"
	/// English String: "We couldn't load this security ticket."
	/// </summary>
	public override string MessageInvalidTicket => "보안 티켓을 불러오지 못했습니다.";

	/// <summary>
	/// Key: "MessageInvalidUserNameOrEmail"
	/// English String: "Invalid username, or no email exists"
	/// </summary>
	public override string MessageInvalidUserNameOrEmail => "유효하지 않은 사용자 이름 또는 존재하지 않는 이메일";

	/// <summary>
	/// Key: "MessageMobileResetPasswordSuccess"
	/// English String: "MobileResetPasswordSuccess"
	/// </summary>
	public override string MessageMobileResetPasswordSuccess => "MobileResetPasswordSuccess";

	/// <summary>
	/// Key: "MessageNoAccountsLinkedToEmail"
	/// English String: "There are no accounts linked to this email address"
	/// </summary>
	public override string MessageNoAccountsLinkedToEmail => "본 이메일 주소에 연결된 계정이 존재하지 않습니다.";

	/// <summary>
	/// Key: "MessageOldUsernameError"
	/// English String: "It looks like you are trying to log in with a username that has changed. Please log in with your new username."
	/// </summary>
	public override string MessageOldUsernameError => "변경 전 사용자 이름으로 로그인을 시도하셨군요. 변경된 사용자 이름으로 로그인하세요.";

	/// <summary>
	/// Key: "MessagePasswordCannotBeUsed"
	/// English String: "Sorry, that password cannot be used."
	/// </summary>
	public override string MessagePasswordCannotBeUsed => "죄송합니다. 이 비밀번호는 사용할 수 없습니다.";

	/// <summary>
	/// Key: "MessagePasswordsDoNotMatch"
	/// English String: "Passwords do not match"
	/// </summary>
	public override string MessagePasswordsDoNotMatch => "비밀번호가 일치하지 않습니다";

	/// <summary>
	/// Key: "MessageSamlUnauthenticated"
	/// English String: "You must log in to Roblox to finish authenticating."
	/// </summary>
	public override string MessageSamlUnauthenticated => "인증을 완료하려면 Roblox에 로그인해야 합니다.";

	/// <summary>
	/// Key: "MessageUnknownError"
	/// English String: "Unknown Error"
	/// </summary>
	public override string MessageUnknownError => "알 수 없는 오류";

	/// <summary>
	/// Key: "MessageUnknownSystemError"
	/// English String: "System error. Please return to login screen."
	/// </summary>
	public override string MessageUnknownSystemError => "시스템 오류. 로그인 화면으로 돌아가세요.";

	/// <summary>
	/// Key: "Placeholder.Email"
	/// English String: "Email"
	/// </summary>
	public override string PlaceholderEmail => "이메일";

	/// <summary>
	/// Key: "Placeholder.PhoneNumber"
	/// English String: "Phone Number"
	/// </summary>
	public override string PlaceholderPhoneNumber => "전화번호";

	/// <summary>
	/// Key: "Response.PasswordResetSuccess"
	/// Password reset success! Please login again.
	/// English String: "Password reset success! Please login again."
	/// </summary>
	public override string ResponsePasswordResetSuccess => "비밀번호 재설정 완료! 다시 로그인하세요.";

	/// <summary>
	/// Key: "Response.Success"
	/// English String: "Success"
	/// </summary>
	public override string ResponseSuccess => "성공";

	/// <summary>
	/// Key: "Response.UpdatePasswordFlooded"
	/// English String: "Too many attempts. Please try again later."
	/// </summary>
	public override string ResponseUpdatePasswordFlooded => "시도 가능 횟수를 초과했습니다. 나중에 다시 시도하세요.";

	/// <summary>
	/// Key: "Response.UpdatePasswordIncorrect"
	/// English String: "Your current password is incorrect, the password was not changed."
	/// </summary>
	public override string ResponseUpdatePasswordIncorrect => "입력하신 비밀번호가 일치하지 않아 비밀번호를 변경하지 못했습니다.";

	/// <summary>
	/// Key: "Response.UpdatePasswordInputMissing"
	/// English String: "Must include new password and confirm password"
	/// </summary>
	public override string ResponseUpdatePasswordInputMissing => "새 비밀번호 및 재확인 비밀번호를 입력해야 합니다";

	/// <summary>
	/// Key: "Response.UpdatePasswordMismatch"
	/// English String: "Your new password and confirm password must match"
	/// </summary>
	public override string ResponseUpdatePasswordMismatch => "새 비밀번호와 재확인 비밀번호가 일치해야 합니다";

	public ResetPasswordResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "취소";
	}

	protected override string _GetTemplateForActionEmailToResetPassword()
	{
		return "비밀번호 재설정하려면 이메일을 사용하세요";
	}

	protected override string _GetTemplateForActionEmailToRetriveUsername()
	{
		return "사용자 이름을 찾으려면 이메일을 사용하세요";
	}

	protected override string _GetTemplateForActionOk()
	{
		return "확인";
	}

	protected override string _GetTemplateForActionPhoneToResetPassword()
	{
		return "비밀번호를 재설정하려면 전화번호를 사용하세요";
	}

	protected override string _GetTemplateForActionPhoneToRetriveUsername()
	{
		return "사용자 이름을 찾으려면 전화번호를 사용하세요";
	}

	protected override string _GetTemplateForActionVerify()
	{
		return "인증";
	}

	/// <summary>
	/// Key: "Description.ChangePasswordEmail.HtmlBody1"
	/// email body for change password email
	/// English String: "We noticed that the password changed for your Roblox account: {userName}. If you didn't intend to change it, or you think someone else changed it by mistake, please click this link to undo the action:{lineBreak} {actionLink} {lineBreak}{lineBreak}If you are happy with your new Roblox password, you don't have to do anything! It's already set up. Please do not reply to this message. If you have any questions, please see the Roblox help page (https://www.roblox.com/help)."
	/// </summary>
	public override string DescriptionChangePasswordEmailHtmlBody1(string userName, string lineBreak, string actionLink)
	{
		return $"{userName} 님의 Roblox 계정 비밀번호가 변경되었습니다. 변경 의도가 없으셨거나 다른 누군가가 실수로 변경한 것이라면 아래 링크를 클릭해 변경을 취소할 수 있습니다:{lineBreak} {actionLink} {lineBreak}{lineBreak}변경된 비밀번호에 만족하신다면 그냥 변경된 상태로 두시면 됩니다! 본 메시지에 회신하지 마세요. 문의 사항이 있으신 경우 Roblox 도움말 페이지(https://www.roblox.com/help)를 참고하세요.";
	}

	protected override string _GetTemplateForDescriptionChangePasswordEmailHtmlBody1()
	{
		return "{userName} 님의 Roblox 계정 비밀번호가 변경되었습니다. 변경 의도가 없으셨거나 다른 누군가가 실수로 변경한 것이라면 아래 링크를 클릭해 변경을 취소할 수 있습니다:{lineBreak} {actionLink} {lineBreak}{lineBreak}변경된 비밀번호에 만족하신다면 그냥 변경된 상태로 두시면 됩니다! 본 메시지에 회신하지 마세요. 문의 사항이 있으신 경우 Roblox 도움말 페이지(https://www.roblox.com/help)를 참고하세요.";
	}

	protected override string _GetTemplateForDescriptionEmailToResetPassword()
	{
		return "비밀번호를 재설정하려면 이메일을 입력하세요.";
	}

	protected override string _GetTemplateForDescriptionEmailToRetriveUsername()
	{
		return "사용자 이름을 찾으려면 이메일을 입력하세요.";
	}

	/// <summary>
	/// Key: "Description.PasswordChangeEmail.BodyPlainText"
	/// password reset plaintext email message
	/// English String: "We noticed that the password changed for your Roblox account: {userName}. If you didn't intend to change it, or you think someone else changed it by mistake, please click this link to undo the action:\n{urlWithTicket}\n\nIf you are happy with your new Roblox password, you don't have to do anything! It's already set up. Please do not reply to this message. If you have any questions, please see the Roblox help page (https://www.roblox.com/help)."
	/// </summary>
	public override string DescriptionPasswordChangeEmailBodyPlainText(string userName, string urlWithTicket)
	{
		return $"{userName} 님의 Roblox 계정 비밀번호가 변경되었습니다. 변경 의도가 없으셨거나 다른 누군가가 실수로 변경한 것이라면 아래 링크를 클릭해 변경을 취소하실 수 있습니다.\n{urlWithTicket}\n\n변경된 비밀번호에 만족하신다면 그냥 변경된 상태로 두시면 됩니다! 본 메시지에 회신하지 마세요. 문의 사항이 있으신 경우 Roblox 도움말 페이지(https://www.roblox.com/help)를 참고하세요.";
	}

	protected override string _GetTemplateForDescriptionPasswordChangeEmailBodyPlainText()
	{
		return "{userName} 님의 Roblox 계정 비밀번호가 변경되었습니다. 변경 의도가 없으셨거나 다른 누군가가 실수로 변경한 것이라면 아래 링크를 클릭해 변경을 취소하실 수 있습니다.\n{urlWithTicket}\n\n변경된 비밀번호에 만족하신다면 그냥 변경된 상태로 두시면 됩니다! 본 메시지에 회신하지 마세요. 문의 사항이 있으신 경우 Roblox 도움말 페이지(https://www.roblox.com/help)를 참고하세요.";
	}

	/// <summary>
	/// Key: "Description.PasswordChangeEmail.From"
	/// name of the sender as shown in from field of the email
	/// English String: "\"Roblox Password Reset\" {fromEmailAddress}"
	/// </summary>
	public override string DescriptionPasswordChangeEmailFrom(string fromEmailAddress)
	{
		return $"\"Roblox 비밀번호 재설정\" {fromEmailAddress}";
	}

	protected override string _GetTemplateForDescriptionPasswordChangeEmailFrom()
	{
		return "\"Roblox 비밀번호 재설정\" {fromEmailAddress}";
	}

	protected override string _GetTemplateForDescriptionPasswordChangeEmailSubject()
	{
		return "Roblox 비밀번호 재설정";
	}

	/// <summary>
	/// Key: "Description.PasswordResetEmail.From"
	/// The "From" field for the password reset email
	/// English String: "{escapeLiteralStart}Roblox Password Reset{escapeLiteralEnd} {fromEmailAddress}"
	/// </summary>
	public override string DescriptionPasswordResetEmailFrom(string escapeLiteralStart, string escapeLiteralEnd, string fromEmailAddress)
	{
		return $"{escapeLiteralStart}Roblox 비밀번호 재설정{escapeLiteralEnd} {fromEmailAddress}";
	}

	protected override string _GetTemplateForDescriptionPasswordResetEmailFrom()
	{
		return "{escapeLiteralStart}Roblox 비밀번호 재설정{escapeLiteralEnd} {fromEmailAddress}";
	}

	/// <summary>
	/// Key: "Description.PasswordResetEmail.HtmlBody"
	/// This email is sent when a user requests a password reset.
	/// English String: "We have received a request to reset the password for your Roblox account: {emailOrUsername}{lineBreak}{lineBreak}If you submitted this request, please click the button below to proceed.{lineBreak}This button will be active for {passwordResetTicketHours} hours, {passwordResetTicketMinutes} minutes. If you do not wish to reset your password, please disregard this notice.{lineBreak}{lineBreak}{aTagWithStartHref}{resetPasswordUrl}{hrefEnd}{buttonStart}Reset Password{buttonEnd}{aTagEnd}"
	/// </summary>
	public override string DescriptionPasswordResetEmailHtmlBody(string emailOrUsername, string lineBreak, string passwordResetTicketHours, string passwordResetTicketMinutes, string aTagWithStartHref, string resetPasswordUrl, string hrefEnd, string buttonStart, string buttonEnd, string aTagEnd)
	{
		return $"Roblox 계정: {emailOrUsername}의 비밀번호 재설정 요청을 받았습니다.{lineBreak}{lineBreak}이 요청을 제출하셨다면, 아래 버튼을 클릭해 진행하세요.{lineBreak}본 링크는 {passwordResetTicketHours}시간, {passwordResetTicketMinutes}분 동안 활성화됩니다. 비밀번호를 재설정하고 싶지 않다면, 본 알림을 무시하세요.{lineBreak}{lineBreak}{aTagWithStartHref}{resetPasswordUrl}{hrefEnd}{buttonStart}비밀번호 재설정{buttonEnd}{aTagEnd}";
	}

	protected override string _GetTemplateForDescriptionPasswordResetEmailHtmlBody()
	{
		return "Roblox 계정: {emailOrUsername}의 비밀번호 재설정 요청을 받았습니다.{lineBreak}{lineBreak}이 요청을 제출하셨다면, 아래 버튼을 클릭해 진행하세요.{lineBreak}본 링크는 {passwordResetTicketHours}시간, {passwordResetTicketMinutes}분 동안 활성화됩니다. 비밀번호를 재설정하고 싶지 않다면, 본 알림을 무시하세요.{lineBreak}{lineBreak}{aTagWithStartHref}{resetPasswordUrl}{hrefEnd}{buttonStart}비밀번호 재설정{buttonEnd}{aTagEnd}";
	}

	/// <summary>
	/// Key: "Description.PasswordResetEmail.PlainBody"
	/// This email is sent when a user requests a password reset.
	/// English String: "We have received a request to reset the password for your Roblox account: {emailOrUsername}{lineBreak}{lineBreak}If you submitted this request, please click the link below or paste it into a web browser to proceed.{lineBreak}This link will be active for {passwordResetTicketHours} hours, {passwordResetTicketMinutes} minutes. If you do not wish to reset your password, please disregard this notice.{lineBreak}{lineBreak}{resetPasswordUrl}"
	/// </summary>
	public override string DescriptionPasswordResetEmailPlainBody(string emailOrUsername, string lineBreak, string passwordResetTicketHours, string passwordResetTicketMinutes, string resetPasswordUrl)
	{
		return $"Roblox 계정: {emailOrUsername}의 비밀번호 재설정 요청을 받았습니다.{lineBreak}{lineBreak}본 요청을 제출하셨다면, 재설정 진행을 위해 아래 링크를 클릭하거나 아래 주소를 웹브라우저에 붙여넣으세요.{lineBreak}본 링크는 {passwordResetTicketHours}시간, {passwordResetTicketMinutes}분 동안 활성화됩니다. 비밀번호를 재설정하고 싶지 않다면, 본 알림을 무시하세요.{lineBreak}{lineBreak}{resetPasswordUrl}";
	}

	protected override string _GetTemplateForDescriptionPasswordResetEmailPlainBody()
	{
		return "Roblox 계정: {emailOrUsername}의 비밀번호 재설정 요청을 받았습니다.{lineBreak}{lineBreak}본 요청을 제출하셨다면, 재설정 진행을 위해 아래 링크를 클릭하거나 아래 주소를 웹브라우저에 붙여넣으세요.{lineBreak}본 링크는 {passwordResetTicketHours}시간, {passwordResetTicketMinutes}분 동안 활성화됩니다. 비밀번호를 재설정하고 싶지 않다면, 본 알림을 무시하세요.{lineBreak}{lineBreak}{resetPasswordUrl}";
	}

	protected override string _GetTemplateForDescriptionPasswordResetEmailSubject()
	{
		return "Roblox 계정 비밀번호 재설정";
	}

	protected override string _GetTemplateForDescriptionPhoneToResetPassword()
	{
		return "비밀번호를 재설정하려면 전화번호를 입력하세요.";
	}

	protected override string _GetTemplateForDescriptionPhoneToRetriveUsername()
	{
		return "사용자 이름을 찾으려면 전화번호를 입력하세요.";
	}

	protected override string _GetTemplateForHeadingVerifyCode()
	{
		return "코드 인증";
	}

	protected override string _GetTemplateForHeadingVerifyPhone()
	{
		return "전화번호 인증";
	}

	protected override string _GetTemplateForHeadingForgetPasswordOrUsername()
	{
		return "비밀번호 또는 사용자 이름 분실";
	}

	protected override string _GetTemplateForLabelActionButtonYes()
	{
		return "예";
	}

	protected override string _GetTemplateForLabelForgetMyPassword()
	{
		return "내 비밀번호를 잊었습니다";
	}

	protected override string _GetTemplateForLabelForgetMyUsername()
	{
		return "내 사용자 이름을 잊었습니다";
	}

	protected override string _GetTemplateForLabelInvalidEmail()
	{
		return "유효하지 않은 이메일";
	}

	protected override string _GetTemplateForLabelInvalidPhoneNumber()
	{
		return "유효하지 않은 전화번호";
	}

	protected override string _GetTemplateForLabelNeutralButtonOk()
	{
		return "확인";
	}

	protected override string _GetTemplateForLabelPassword()
	{
		return "비밀번호";
	}

	protected override string _GetTemplateForLabelResendCode()
	{
		return "코드 재전송";
	}

	protected override string _GetTemplateForLabelSubmit()
	{
		return "제출";
	}

	protected override string _GetTemplateForLabelToolTipWhoCanFindMeByPhone()
	{
		return "입력하신 전화번호를 사용하여 회원님을 찾을 수 있는 사용자를 설정합니다.";
	}

	protected override string _GetTemplateForLabelUsername()
	{
		return "사용자 이름";
	}

	protected override string _GetTemplateForLabelWhoCanFindMeByPhone()
	{
		return "누가 내 전화번호로 나를 찾을 수 있나요?";
	}

	/// <summary>
	/// Key: "Message.CantSendEmailWarning"
	/// English String: "If you did not give us a {styleStart}real email address{styleEnd} when you created your account, we cannot send you an email."
	/// </summary>
	public override string MessageCantSendEmailWarning(string styleStart, string styleEnd)
	{
		return $"계정을 만들었을 때 {styleStart}실제 이메일 주소{styleEnd}를 제공하지 않았다면 이메일을 보낼 수 없습니다.";
	}

	protected override string _GetTemplateForMessageCantSendEmailWarning()
	{
		return "계정을 만들었을 때 {styleStart}실제 이메일 주소{styleEnd}를 제공하지 않았다면 이메일을 보낼 수 없습니다.";
	}

	protected override string _GetTemplateForMessageDefaultError()
	{
		return "오류가 발생했어요. 나중에 다시 시도하세요.";
	}

	protected override string _GetTemplateForMessageEmailForUsernameSuccessBody()
	{
		return "계정에서 사전에 저장된 이메일 주소로 사용자 이름이 포함된 메일이 발송되었어요.";
	}

	protected override string _GetTemplateForMessageEmailSuccessBody()
	{
		return "계정에서 사전에 저장된 이메일 주소로 지침이 포함된 메일이 발송되었어요.";
	}

	protected override string _GetTemplateForMessageEmailSuccessTitle()
	{
		return "이메일 전송 완료";
	}

	protected override string _GetTemplateForMessageEnterCode()
	{
		return "계정에서 사전에 인증된 휴대폰으로 코드가 전송되었어요. 아래에 코드를 입력하세요.";
	}

	protected override string _GetTemplateForMessageEnterCodeSentToEmail()
	{
		return "이메일로 방금 발송된 코드를 입력하세요.";
	}

	protected override string _GetTemplateForMessagePhoneForUsernameSuccessBody()
	{
		return "계정에서 사전에 인증된 전화번호로 사용자 이름이 포함된 SMS가 발송되었어요.";
	}

	protected override string _GetTemplateForMessagePhoneForUsernameSuccessTitle()
	{
		return "SMS 전송 완료";
	}

	protected override string _GetTemplateForMessageAccountDoesNotHaveAnEmail()
	{
		return "본 계정에 연결된 이메일이 존재하지 않습니다.";
	}

	protected override string _GetTemplateForMessageAccountNotFoundByEmail()
	{
		return "계정을 찾을 수 없습니다. 다른 이메일을 사용하세요.";
	}

	protected override string _GetTemplateForMessageAccountNotFoundByPhone()
	{
		return "계정을 찾을 수 없습니다. 다른 전화번호를 사용하세요.";
	}

	protected override string _GetTemplateForMessageAccountRecoveryUnknownError()
	{
		return "시스템 오류. 계정을 본 상태로 복구하지 못했습니다.";
	}

	protected override string _GetTemplateForMessageCaptchaError()
	{
		return "로봇이 아님을 확인해야 합니다!";
	}

	protected override string _GetTemplateForMessageCaptchaFailError()
	{
		return "입력한 단어가 사진과 일치하지 않습니다. 다시 시도하세요.";
	}

	protected override string _GetTemplateForMessageCredentialsError()
	{
		return "사용자 이름 또는 비밀번호가 일치하지 않습니다. 확인 후 다시 시도하세요.";
	}

	protected override string _GetTemplateForMessageFloodCheckedError()
	{
		return "시도 가능 횟수를 초과하였습니다. 나중에 다시 시도하세요.";
	}

	protected override string _GetTemplateForMessageForgotPasswordFeatureDisabled()
	{
		return "일시적 기능 비활성화. 나중에 다시 시도하세요.";
	}

	protected override string _GetTemplateForMessageForgotPasswordSuccess()
	{
		return "로그인 안내를 위해 이메일을 확인하세요.";
	}

	protected override string _GetTemplateForMessageInvalidAccountStatus()
	{
		return "비밀번호 재설정이 불가능한 계정 상태";
	}

	protected override string _GetTemplateForMessageInvalidPassword()
	{
		return "유효하지 않은 비밀번호";
	}

	protected override string _GetTemplateForMessageInvalidTicket()
	{
		return "보안 티켓을 불러오지 못했습니다.";
	}

	protected override string _GetTemplateForMessageInvalidUserNameOrEmail()
	{
		return "유효하지 않은 사용자 이름 또는 존재하지 않는 이메일";
	}

	protected override string _GetTemplateForMessageMobileResetPasswordSuccess()
	{
		return "MobileResetPasswordSuccess";
	}

	protected override string _GetTemplateForMessageNoAccountsLinkedToEmail()
	{
		return "본 이메일 주소에 연결된 계정이 존재하지 않습니다.";
	}

	protected override string _GetTemplateForMessageOldUsernameError()
	{
		return "변경 전 사용자 이름으로 로그인을 시도하셨군요. 변경된 사용자 이름으로 로그인하세요.";
	}

	protected override string _GetTemplateForMessagePasswordCannotBeUsed()
	{
		return "죄송합니다. 이 비밀번호는 사용할 수 없습니다.";
	}

	/// <summary>
	/// Key: "MessagePasswordResetTicketExpired"
	/// English String: "Sorry, password reset requests expire {expirationHour} hours, {expirationMinute} minutes after issuance. Try requesting another password reset ticket again."
	/// </summary>
	public override string MessagePasswordResetTicketExpired(string expirationHour, string expirationMinute)
	{
		return $"죄송합니다. 비밀번호 재설정 요청은 발급으로부터 {expirationHour}시간, {expirationMinute}분 후에 만료됩니다. 비밀번호 재설정 티켓을 다시 요청하세요.";
	}

	protected override string _GetTemplateForMessagePasswordResetTicketExpired()
	{
		return "죄송합니다. 비밀번호 재설정 요청은 발급으로부터 {expirationHour}시간, {expirationMinute}분 후에 만료됩니다. 비밀번호 재설정 티켓을 다시 요청하세요.";
	}

	protected override string _GetTemplateForMessagePasswordsDoNotMatch()
	{
		return "비밀번호가 일치하지 않습니다";
	}

	protected override string _GetTemplateForMessageSamlUnauthenticated()
	{
		return "인증을 완료하려면 Roblox에 로그인해야 합니다.";
	}

	protected override string _GetTemplateForMessageUnknownError()
	{
		return "알 수 없는 오류";
	}

	protected override string _GetTemplateForMessageUnknownSystemError()
	{
		return "시스템 오류. 로그인 화면으로 돌아가세요.";
	}

	protected override string _GetTemplateForPlaceholderEmail()
	{
		return "이메일";
	}

	/// <summary>
	/// Key: "Placeholder.EnterCode"
	/// English String: "Enter Code ({codeLength}-digit)"
	/// </summary>
	public override string PlaceholderEnterCode(string codeLength)
	{
		return $"코드 입력 ({codeLength}자리)";
	}

	protected override string _GetTemplateForPlaceholderEnterCode()
	{
		return "코드 입력 ({codeLength}자리)";
	}

	protected override string _GetTemplateForPlaceholderPhoneNumber()
	{
		return "전화번호";
	}

	protected override string _GetTemplateForResponsePasswordResetSuccess()
	{
		return "비밀번호 재설정 완료! 다시 로그인하세요.";
	}

	protected override string _GetTemplateForResponseSuccess()
	{
		return "성공";
	}

	protected override string _GetTemplateForResponseUpdatePasswordFlooded()
	{
		return "시도 가능 횟수를 초과했습니다. 나중에 다시 시도하세요.";
	}

	protected override string _GetTemplateForResponseUpdatePasswordIncorrect()
	{
		return "입력하신 비밀번호가 일치하지 않아 비밀번호를 변경하지 못했습니다.";
	}

	protected override string _GetTemplateForResponseUpdatePasswordInputMissing()
	{
		return "새 비밀번호 및 재확인 비밀번호를 입력해야 합니다";
	}

	protected override string _GetTemplateForResponseUpdatePasswordMismatch()
	{
		return "새 비밀번호와 재확인 비밀번호가 일치해야 합니다";
	}
}
