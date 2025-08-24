namespace Roblox.TranslationResources.Authentication;

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
	public override string ActionCancel => "取消";

	/// <summary>
	/// Key: "Action.EmailToResetPassword"
	/// English String: "Use email to reset password"
	/// </summary>
	public override string ActionEmailToResetPassword => "使用電子郵件重置密碼";

	/// <summary>
	/// Key: "Action.EmailToRetriveUsername"
	/// English String: "Use email to retrieve username"
	/// </summary>
	public override string ActionEmailToRetriveUsername => "使用電子郵件取得使用者名稱";

	/// <summary>
	/// Key: "Action.Ok"
	/// OK
	/// English String: "OK"
	/// </summary>
	public override string ActionOk => "確定";

	/// <summary>
	/// Key: "Action.PhoneToResetPassword"
	/// English String: "Use phone number to reset password"
	/// </summary>
	public override string ActionPhoneToResetPassword => "使用手機號碼重置密碼";

	/// <summary>
	/// Key: "Action.PhoneToRetriveUsername"
	/// English String: "Use phone number to retrieve username"
	/// </summary>
	public override string ActionPhoneToRetriveUsername => "使用手機號碼取得使用者名稱";

	/// <summary>
	/// Key: "Action.Verify"
	/// English String: "Verify"
	/// </summary>
	public override string ActionVerify => "驗證";

	/// <summary>
	/// Key: "Description.EmailToResetPassword"
	/// English String: "Enter your email to reset your password."
	/// </summary>
	public override string DescriptionEmailToResetPassword => "若要重置您的密碼，請輸入您的電子郵件地址。";

	/// <summary>
	/// Key: "Description.EmailToRetriveUsername"
	/// English String: "Enter your email to retrieve your username."
	/// </summary>
	public override string DescriptionEmailToRetriveUsername => "若要取得您的使用者名稱，請輸入您的電子郵件地址。";

	/// <summary>
	/// Key: "Description.PasswordChangeEmail.Subject"
	/// email subject to change password
	/// English String: "Roblox Password Reset"
	/// </summary>
	public override string DescriptionPasswordChangeEmailSubject => "Roblox 密碼重置";

	/// <summary>
	/// Key: "Description.PasswordResetEmail.Subject"
	/// Subject for password reset email
	/// English String: "Roblox Account Password Reset"
	/// </summary>
	public override string DescriptionPasswordResetEmailSubject => "Roblox 帳號密碼重置";

	/// <summary>
	/// Key: "Description.PhoneToResetPassword"
	/// English String: "Enter your phone number to reset your password."
	/// </summary>
	public override string DescriptionPhoneToResetPassword => "若要重置您的密碼，請輸入您的手機號碼。";

	/// <summary>
	/// Key: "Description.PhoneToRetriveUsername"
	/// English String: "Enter your phone number to retrieve your username."
	/// </summary>
	public override string DescriptionPhoneToRetriveUsername => "若要取得您的使用者名稱，請輸入您的手機號碼。";

	/// <summary>
	/// Key: "Heading.VerifyCode"
	/// verify code heading
	/// English String: "Verify Code"
	/// </summary>
	public override string HeadingVerifyCode => "驗證碼";

	/// <summary>
	/// Key: "Heading.VerifyPhone"
	/// English String: "Verify Phone"
	/// </summary>
	public override string HeadingVerifyPhone => "驗證手機號碼";

	/// <summary>
	/// Key: "HeadingForgetPasswordOrUsername"
	/// English String: "Forgot Password or Username"
	/// </summary>
	public override string HeadingForgetPasswordOrUsername => "忘記密碼或使用者名稱";

	/// <summary>
	/// Key: "Label.ActionButtonYes"
	/// button label
	/// English String: "Yes"
	/// </summary>
	public override string LabelActionButtonYes => "是";

	/// <summary>
	/// Key: "Label.ForgetMyPassword"
	/// English String: "Forgot My Password"
	/// </summary>
	public override string LabelForgetMyPassword => "忘記密碼了";

	/// <summary>
	/// Key: "Label.ForgetMyUsername"
	/// English String: "Forgot My Username"
	/// </summary>
	public override string LabelForgetMyUsername => "忘記使用者名稱了";

	/// <summary>
	/// Key: "Label.InvalidEmail"
	/// English String: "Invalid email"
	/// </summary>
	public override string LabelInvalidEmail => "電子郵件地址無效";

	/// <summary>
	/// Key: "Label.InvalidPhoneNumber"
	/// English String: "Invalid phone number"
	/// </summary>
	public override string LabelInvalidPhoneNumber => "手機號碼無效";

	/// <summary>
	/// Key: "Label.NeutralButtonOk"
	/// ok button label
	/// English String: "OK"
	/// </summary>
	public override string LabelNeutralButtonOk => "確定";

	/// <summary>
	/// Key: "Label.Password"
	/// label
	/// English String: "Password"
	/// </summary>
	public override string LabelPassword => "密碼";

	/// <summary>
	/// Key: "Label.ResendCode"
	/// English String: "Resend Code"
	/// </summary>
	public override string LabelResendCode => "重新傳送驗證碼";

	/// <summary>
	/// Key: "Label.Submit"
	/// English String: "Submit"
	/// </summary>
	public override string LabelSubmit => "提交";

	/// <summary>
	/// Key: "Label.ToolTip.WhoCanFindMeByPhone"
	/// English String: "This setting controls who can find you using the phone number you provided."
	/// </summary>
	public override string LabelToolTipWhoCanFindMeByPhone => "此設定控制誰可以使用您提供的手機號碼找到您。";

	/// <summary>
	/// Key: "Label.Username"
	/// English String: "Username"
	/// </summary>
	public override string LabelUsername => "使用者名稱";

	/// <summary>
	/// Key: "Label.WhoCanFindMeByPhone"
	/// English String: "Who can find me by my phone number?"
	/// </summary>
	public override string LabelWhoCanFindMeByPhone => "誰可以透過我的手機號碼找到我？";

	/// <summary>
	/// Key: "Message.DefaultError"
	/// English String: "An error occurred, try again later."
	/// </summary>
	public override string MessageDefaultError => "發生錯誤，請稍後再試。";

	/// <summary>
	/// Key: "Message.EmailForUsernameSuccessBody"
	/// success message
	/// English String: "An email with your username(s) has been sent to you if the email was previously saved on your account."
	/// </summary>
	public override string MessageEmailForUsernameSuccessBody => "如果您的電子郵件地址已經過驗證，我們已將含有您的使用者名稱的電子郵件傳送到您的電子郵件地址。";

	/// <summary>
	/// Key: "Message.EmailSuccessBody"
	/// English String: "An email with instructions has been sent to you if the email was previously saved on your account."
	/// </summary>
	public override string MessageEmailSuccessBody => "如果您的電子郵件地址已經過驗證，我們已將說明傳送到您的電子郵件地址。";

	/// <summary>
	/// Key: "Message.EmailSuccessTitle"
	/// English String: "Email Sent"
	/// </summary>
	public override string MessageEmailSuccessTitle => "電子郵件已傳送";

	/// <summary>
	/// Key: "Message.EnterCode"
	/// English String: "A code was sent to your phone if it was previously verified on your account. Please enter it below"
	/// </summary>
	public override string MessageEnterCode => "如果您的手機號碼經過驗證，我們已將代碼傳送到您的手機。";

	/// <summary>
	/// Key: "Message.EnterCodeSentToEmail"
	/// Enter the code we just sent to your email.
	/// English String: "Enter the code we just sent to your email."
	/// </summary>
	public override string MessageEnterCodeSentToEmail => "請輸入傳送到您的電子郵件信箱的驗證碼。";

	/// <summary>
	/// Key: "Message.PhoneForUsernameSuccessBody"
	/// English String: "An SMS with your username(s) has been sent to you if the phone number was previously verified on your account."
	/// </summary>
	public override string MessagePhoneForUsernameSuccessBody => "若您的帳號已驗證此手機號碼，我們已將您的使用者名稱以簡訊傳送給您。";

	/// <summary>
	/// Key: "Message.PhoneForUsernameSuccessTitle"
	/// English String: "SMS Sent"
	/// </summary>
	public override string MessagePhoneForUsernameSuccessTitle => "簡訊已傳送";

	/// <summary>
	/// Key: "MessageAccountDoesNotHaveAnEmail"
	/// English String: "There is no email linked to this account"
	/// </summary>
	public override string MessageAccountDoesNotHaveAnEmail => "此帳號沒有加入電子郵件地址";

	/// <summary>
	/// Key: "MessageAccountNotFoundByEmail"
	/// No account found. Please use a different email.
	/// English String: "No account found. Please use a different email."
	/// </summary>
	public override string MessageAccountNotFoundByEmail => "找不到帳號，請使用其它電子郵件地址。";

	/// <summary>
	/// Key: "MessageAccountNotFoundByPhone"
	/// No account found. Please use a different phone number.
	/// English String: "No account found. Please use a different phone number."
	/// </summary>
	public override string MessageAccountNotFoundByPhone => "找不到帳號，請使用其它手機號碼。";

	/// <summary>
	/// Key: "MessageAccountRecoveryUnknownError"
	/// English String: "System error. Account could not be restored to this state."
	/// </summary>
	public override string MessageAccountRecoveryUnknownError => "系統錯誤，帳號無法恢復成此狀態。";

	/// <summary>
	/// Key: "MessageCaptchaError"
	/// English String: "We need to make sure you're not a robot!"
	/// </summary>
	public override string MessageCaptchaError => "我們需要進行真人驗證。";

	/// <summary>
	/// Key: "MessageCaptchaFailError"
	/// English String: "The words you typed didn't match the picture. Please try again."
	/// </summary>
	public override string MessageCaptchaFailError => "您輸入的文字與圖片不符，請重新嘗試。";

	/// <summary>
	/// Key: "MessageCredentialsError"
	/// English String: "Your username or password is incorrect. Please check them and try again."
	/// </summary>
	public override string MessageCredentialsError => "您的使用者名稱或密碼不正確，請重新嘗試。";

	/// <summary>
	/// Key: "MessageFloodCheckedError"
	/// English String: "Too many attempts. Please try again later."
	/// </summary>
	public override string MessageFloodCheckedError => "嘗試次數過多，請稍後再試。";

	/// <summary>
	/// Key: "MessageForgotPasswordFeatureDisabled"
	/// English String: "Feature temporarily disabled. Please try again later."
	/// </summary>
	public override string MessageForgotPasswordFeatureDisabled => "此功能暫時停用，請稍後再試。";

	/// <summary>
	/// Key: "MessageForgotPasswordSuccess"
	/// English String: "Check your email for login instructions"
	/// </summary>
	public override string MessageForgotPasswordSuccess => "請查看您的電子郵件信箱取得登入說明";

	/// <summary>
	/// Key: "MessageInvalidAccountStatus"
	/// English String: "Account status prevents resetting password"
	/// </summary>
	public override string MessageInvalidAccountStatus => "您的帳號狀態不允許您重置密碼";

	/// <summary>
	/// Key: "MessageInvalidPassword"
	/// English String: "Invalid password"
	/// </summary>
	public override string MessageInvalidPassword => "密碼無效";

	/// <summary>
	/// Key: "MessageInvalidTicket"
	/// English String: "We couldn't load this security ticket."
	/// </summary>
	public override string MessageInvalidTicket => "無法載入驗證票。";

	/// <summary>
	/// Key: "MessageInvalidUserNameOrEmail"
	/// English String: "Invalid username, or no email exists"
	/// </summary>
	public override string MessageInvalidUserNameOrEmail => "使用者名稱或電子郵件地址無效";

	/// <summary>
	/// Key: "MessageMobileResetPasswordSuccess"
	/// English String: "MobileResetPasswordSuccess"
	/// </summary>
	public override string MessageMobileResetPasswordSuccess => "MobileResetPasswordSuccess";

	/// <summary>
	/// Key: "MessageNoAccountsLinkedToEmail"
	/// English String: "There are no accounts linked to this email address"
	/// </summary>
	public override string MessageNoAccountsLinkedToEmail => "沒有加入此電子郵件的帳號";

	/// <summary>
	/// Key: "MessageOldUsernameError"
	/// English String: "It looks like you are trying to log in with a username that has changed. Please log in with your new username."
	/// </summary>
	public override string MessageOldUsernameError => "您似乎在以過去的使用者名稱登入，請以新的使用者名稱登入。";

	/// <summary>
	/// Key: "MessagePasswordCannotBeUsed"
	/// English String: "Sorry, that password cannot be used."
	/// </summary>
	public override string MessagePasswordCannotBeUsed => "對不起，無法使用該密碼。";

	/// <summary>
	/// Key: "MessagePasswordsDoNotMatch"
	/// English String: "Passwords do not match"
	/// </summary>
	public override string MessagePasswordsDoNotMatch => "密碼不相符";

	/// <summary>
	/// Key: "MessageSamlUnauthenticated"
	/// English String: "You must log in to Roblox to finish authenticating."
	/// </summary>
	public override string MessageSamlUnauthenticated => "若要完成驗證，請登入 Roblox。";

	/// <summary>
	/// Key: "MessageUnknownError"
	/// English String: "Unknown Error"
	/// </summary>
	public override string MessageUnknownError => "未知錯誤";

	/// <summary>
	/// Key: "MessageUnknownSystemError"
	/// English String: "System error. Please return to login screen."
	/// </summary>
	public override string MessageUnknownSystemError => "系統錯誤，請返回登入畫面。";

	/// <summary>
	/// Key: "Placeholder.Email"
	/// English String: "Email"
	/// </summary>
	public override string PlaceholderEmail => "電子郵件地址";

	/// <summary>
	/// Key: "Placeholder.PhoneNumber"
	/// English String: "Phone Number"
	/// </summary>
	public override string PlaceholderPhoneNumber => "手機號碼";

	/// <summary>
	/// Key: "Response.PasswordResetSuccess"
	/// Password reset success! Please login again.
	/// English String: "Password reset success! Please login again."
	/// </summary>
	public override string ResponsePasswordResetSuccess => "密碼重置成功，請重新登入。";

	/// <summary>
	/// Key: "Response.Success"
	/// English String: "Success"
	/// </summary>
	public override string ResponseSuccess => "成功";

	/// <summary>
	/// Key: "Response.UpdatePasswordFlooded"
	/// English String: "Too many attempts. Please try again later."
	/// </summary>
	public override string ResponseUpdatePasswordFlooded => "嘗試次數過多，請稍後再試。";

	/// <summary>
	/// Key: "Response.UpdatePasswordIncorrect"
	/// English String: "Your current password is incorrect, the password was not changed."
	/// </summary>
	public override string ResponseUpdatePasswordIncorrect => "您目前的密碼不正確，密碼並未變更。";

	/// <summary>
	/// Key: "Response.UpdatePasswordInputMissing"
	/// English String: "Must include new password and confirm password"
	/// </summary>
	public override string ResponseUpdatePasswordInputMissing => "必須輸入並確認新密碼";

	/// <summary>
	/// Key: "Response.UpdatePasswordMismatch"
	/// English String: "Your new password and confirm password must match"
	/// </summary>
	public override string ResponseUpdatePasswordMismatch => "新密碼與確認密碼欄位必須相符";

	public ResetPasswordResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "取消";
	}

	protected override string _GetTemplateForActionEmailToResetPassword()
	{
		return "使用電子郵件重置密碼";
	}

	protected override string _GetTemplateForActionEmailToRetriveUsername()
	{
		return "使用電子郵件取得使用者名稱";
	}

	protected override string _GetTemplateForActionOk()
	{
		return "確定";
	}

	protected override string _GetTemplateForActionPhoneToResetPassword()
	{
		return "使用手機號碼重置密碼";
	}

	protected override string _GetTemplateForActionPhoneToRetriveUsername()
	{
		return "使用手機號碼取得使用者名稱";
	}

	protected override string _GetTemplateForActionVerify()
	{
		return "驗證";
	}

	/// <summary>
	/// Key: "Description.ChangePasswordEmail.HtmlBody1"
	/// email body for change password email
	/// English String: "We noticed that the password changed for your Roblox account: {userName}. If you didn't intend to change it, or you think someone else changed it by mistake, please click this link to undo the action:{lineBreak} {actionLink} {lineBreak}{lineBreak}If you are happy with your new Roblox password, you don't have to do anything! It's already set up. Please do not reply to this message. If you have any questions, please see the Roblox help page (https://www.roblox.com/help)."
	/// </summary>
	public override string DescriptionChangePasswordEmailHtmlBody1(string userName, string lineBreak, string actionLink)
	{
		return $"我們發現您變更了您的帳號 {userName} 的密碼。若您沒有要變更您的密碼，請按下此連結復原您的密碼：{lineBreak} {actionLink} {lineBreak}{lineBreak}若您有變更密碼，您的變更已經生效，您不需要採取任何動作。請勿回覆此電子郵件。若您有任何問題，請前往 Roblox 協助頁面（https://www.roblox.com/help）。";
	}

	protected override string _GetTemplateForDescriptionChangePasswordEmailHtmlBody1()
	{
		return "我們發現您變更了您的帳號 {userName} 的密碼。若您沒有要變更您的密碼，請按下此連結復原您的密碼：{lineBreak} {actionLink} {lineBreak}{lineBreak}若您有變更密碼，您的變更已經生效，您不需要採取任何動作。請勿回覆此電子郵件。若您有任何問題，請前往 Roblox 協助頁面（https://www.roblox.com/help）。";
	}

	protected override string _GetTemplateForDescriptionEmailToResetPassword()
	{
		return "若要重置您的密碼，請輸入您的電子郵件地址。";
	}

	protected override string _GetTemplateForDescriptionEmailToRetriveUsername()
	{
		return "若要取得您的使用者名稱，請輸入您的電子郵件地址。";
	}

	/// <summary>
	/// Key: "Description.PasswordChangeEmail.BodyPlainText"
	/// password reset plaintext email message
	/// English String: "We noticed that the password changed for your Roblox account: {userName}. If you didn't intend to change it, or you think someone else changed it by mistake, please click this link to undo the action:\n{urlWithTicket}\n\nIf you are happy with your new Roblox password, you don't have to do anything! It's already set up. Please do not reply to this message. If you have any questions, please see the Roblox help page (https://www.roblox.com/help)."
	/// </summary>
	public override string DescriptionPasswordChangeEmailBodyPlainText(string userName, string urlWithTicket)
	{
		return $"我們發現您變更了您的帳號 {userName} 的密碼。若您沒有要變更您的密碼，請按下此連結復原您的密碼：\n{urlWithTicket}\n\n若您有變更密碼，您的變更已經生效，您不需要採取任何動作。請勿回覆此電子郵件。若您有任何問題，請前往 Roblox 協助頁面（https://www.roblox.com/help）。";
	}

	protected override string _GetTemplateForDescriptionPasswordChangeEmailBodyPlainText()
	{
		return "我們發現您變更了您的帳號 {userName} 的密碼。若您沒有要變更您的密碼，請按下此連結復原您的密碼：\n{urlWithTicket}\n\n若您有變更密碼，您的變更已經生效，您不需要採取任何動作。請勿回覆此電子郵件。若您有任何問題，請前往 Roblox 協助頁面（https://www.roblox.com/help）。";
	}

	/// <summary>
	/// Key: "Description.PasswordChangeEmail.From"
	/// name of the sender as shown in from field of the email
	/// English String: "\"Roblox Password Reset\" {fromEmailAddress}"
	/// </summary>
	public override string DescriptionPasswordChangeEmailFrom(string fromEmailAddress)
	{
		return $"「Roblox 密碼重置」{fromEmailAddress}";
	}

	protected override string _GetTemplateForDescriptionPasswordChangeEmailFrom()
	{
		return "「Roblox 密碼重置」{fromEmailAddress}";
	}

	protected override string _GetTemplateForDescriptionPasswordChangeEmailSubject()
	{
		return "Roblox 密碼重置";
	}

	/// <summary>
	/// Key: "Description.PasswordResetEmail.From"
	/// The "From" field for the password reset email
	/// English String: "{escapeLiteralStart}Roblox Password Reset{escapeLiteralEnd} {fromEmailAddress}"
	/// </summary>
	public override string DescriptionPasswordResetEmailFrom(string escapeLiteralStart, string escapeLiteralEnd, string fromEmailAddress)
	{
		return $"{escapeLiteralStart}Roblox 密碼重置{escapeLiteralEnd} {fromEmailAddress}";
	}

	protected override string _GetTemplateForDescriptionPasswordResetEmailFrom()
	{
		return "{escapeLiteralStart}Roblox 密碼重置{escapeLiteralEnd} {fromEmailAddress}";
	}

	/// <summary>
	/// Key: "Description.PasswordResetEmail.HtmlBody"
	/// This email is sent when a user requests a password reset.
	/// English String: "We have received a request to reset the password for your Roblox account: {emailOrUsername}{lineBreak}{lineBreak}If you submitted this request, please click the button below to proceed.{lineBreak}This button will be active for {passwordResetTicketHours} hours, {passwordResetTicketMinutes} minutes. If you do not wish to reset your password, please disregard this notice.{lineBreak}{lineBreak}{aTagWithStartHref}{resetPasswordUrl}{hrefEnd}{buttonStart}Reset Password{buttonEnd}{aTagEnd}"
	/// </summary>
	public override string DescriptionPasswordResetEmailHtmlBody(string emailOrUsername, string lineBreak, string passwordResetTicketHours, string passwordResetTicketMinutes, string aTagWithStartHref, string resetPasswordUrl, string hrefEnd, string buttonStart, string buttonEnd, string aTagEnd)
	{
		return $"我們收到您的 Roblox 帳號 {emailOrUsername} 的密碼重置請求。{lineBreak}{lineBreak}若您有提交此請求，請按下下方連結，或將連結貼在瀏覽器。{lineBreak}此按鈕將在 {passwordResetTicketHours} 小時 {passwordResetTicketMinutes} 分鐘內有效。若您不想重置您的密碼，請忽略此電子郵件。{lineBreak}{lineBreak}{aTagWithStartHref}{resetPasswordUrl}{hrefEnd}{buttonStart}重置密碼{buttonEnd}{aTagEnd}";
	}

	protected override string _GetTemplateForDescriptionPasswordResetEmailHtmlBody()
	{
		return "我們收到您的 Roblox 帳號 {emailOrUsername} 的密碼重置請求。{lineBreak}{lineBreak}若您有提交此請求，請按下下方連結，或將連結貼在瀏覽器。{lineBreak}此按鈕將在 {passwordResetTicketHours} 小時 {passwordResetTicketMinutes} 分鐘內有效。若您不想重置您的密碼，請忽略此電子郵件。{lineBreak}{lineBreak}{aTagWithStartHref}{resetPasswordUrl}{hrefEnd}{buttonStart}重置密碼{buttonEnd}{aTagEnd}";
	}

	/// <summary>
	/// Key: "Description.PasswordResetEmail.PlainBody"
	/// This email is sent when a user requests a password reset.
	/// English String: "We have received a request to reset the password for your Roblox account: {emailOrUsername}{lineBreak}{lineBreak}If you submitted this request, please click the link below or paste it into a web browser to proceed.{lineBreak}This link will be active for {passwordResetTicketHours} hours, {passwordResetTicketMinutes} minutes. If you do not wish to reset your password, please disregard this notice.{lineBreak}{lineBreak}{resetPasswordUrl}"
	/// </summary>
	public override string DescriptionPasswordResetEmailPlainBody(string emailOrUsername, string lineBreak, string passwordResetTicketHours, string passwordResetTicketMinutes, string resetPasswordUrl)
	{
		return $"我們收到您的 Roblox 帳號 {emailOrUsername} 的密碼重置請求。{lineBreak}{lineBreak}若您有提交此請求，請按下下方連結，或將連結貼在瀏覽器。{lineBreak}此按鈕將在 {passwordResetTicketHours} 小時 {passwordResetTicketMinutes} 分鐘內有效。若您不想重置您的密碼，請忽略此電子郵件。{lineBreak}{lineBreak}{resetPasswordUrl}";
	}

	protected override string _GetTemplateForDescriptionPasswordResetEmailPlainBody()
	{
		return "我們收到您的 Roblox 帳號 {emailOrUsername} 的密碼重置請求。{lineBreak}{lineBreak}若您有提交此請求，請按下下方連結，或將連結貼在瀏覽器。{lineBreak}此按鈕將在 {passwordResetTicketHours} 小時 {passwordResetTicketMinutes} 分鐘內有效。若您不想重置您的密碼，請忽略此電子郵件。{lineBreak}{lineBreak}{resetPasswordUrl}";
	}

	protected override string _GetTemplateForDescriptionPasswordResetEmailSubject()
	{
		return "Roblox 帳號密碼重置";
	}

	protected override string _GetTemplateForDescriptionPhoneToResetPassword()
	{
		return "若要重置您的密碼，請輸入您的手機號碼。";
	}

	protected override string _GetTemplateForDescriptionPhoneToRetriveUsername()
	{
		return "若要取得您的使用者名稱，請輸入您的手機號碼。";
	}

	protected override string _GetTemplateForHeadingVerifyCode()
	{
		return "驗證碼";
	}

	protected override string _GetTemplateForHeadingVerifyPhone()
	{
		return "驗證手機號碼";
	}

	protected override string _GetTemplateForHeadingForgetPasswordOrUsername()
	{
		return "忘記密碼或使用者名稱";
	}

	protected override string _GetTemplateForLabelActionButtonYes()
	{
		return "是";
	}

	protected override string _GetTemplateForLabelForgetMyPassword()
	{
		return "忘記密碼了";
	}

	protected override string _GetTemplateForLabelForgetMyUsername()
	{
		return "忘記使用者名稱了";
	}

	protected override string _GetTemplateForLabelInvalidEmail()
	{
		return "電子郵件地址無效";
	}

	protected override string _GetTemplateForLabelInvalidPhoneNumber()
	{
		return "手機號碼無效";
	}

	protected override string _GetTemplateForLabelNeutralButtonOk()
	{
		return "確定";
	}

	protected override string _GetTemplateForLabelPassword()
	{
		return "密碼";
	}

	protected override string _GetTemplateForLabelResendCode()
	{
		return "重新傳送驗證碼";
	}

	protected override string _GetTemplateForLabelSubmit()
	{
		return "提交";
	}

	protected override string _GetTemplateForLabelToolTipWhoCanFindMeByPhone()
	{
		return "此設定控制誰可以使用您提供的手機號碼找到您。";
	}

	protected override string _GetTemplateForLabelUsername()
	{
		return "使用者名稱";
	}

	protected override string _GetTemplateForLabelWhoCanFindMeByPhone()
	{
		return "誰可以透過我的手機號碼找到我？";
	}

	/// <summary>
	/// Key: "Message.CantSendEmailWarning"
	/// English String: "If you did not give us a {styleStart}real email address{styleEnd} when you created your account, we cannot send you an email."
	/// </summary>
	public override string MessageCantSendEmailWarning(string styleStart, string styleEnd)
	{
		return $"若您在建立帳號時沒有提供{styleStart}真實的電子郵件地址{styleEnd}，我們將無法傳送電子郵件給您。";
	}

	protected override string _GetTemplateForMessageCantSendEmailWarning()
	{
		return "若您在建立帳號時沒有提供{styleStart}真實的電子郵件地址{styleEnd}，我們將無法傳送電子郵件給您。";
	}

	protected override string _GetTemplateForMessageDefaultError()
	{
		return "發生錯誤，請稍後再試。";
	}

	protected override string _GetTemplateForMessageEmailForUsernameSuccessBody()
	{
		return "如果您的電子郵件地址已經過驗證，我們已將含有您的使用者名稱的電子郵件傳送到您的電子郵件地址。";
	}

	protected override string _GetTemplateForMessageEmailSuccessBody()
	{
		return "如果您的電子郵件地址已經過驗證，我們已將說明傳送到您的電子郵件地址。";
	}

	protected override string _GetTemplateForMessageEmailSuccessTitle()
	{
		return "電子郵件已傳送";
	}

	protected override string _GetTemplateForMessageEnterCode()
	{
		return "如果您的手機號碼經過驗證，我們已將代碼傳送到您的手機。";
	}

	protected override string _GetTemplateForMessageEnterCodeSentToEmail()
	{
		return "請輸入傳送到您的電子郵件信箱的驗證碼。";
	}

	protected override string _GetTemplateForMessagePhoneForUsernameSuccessBody()
	{
		return "若您的帳號已驗證此手機號碼，我們已將您的使用者名稱以簡訊傳送給您。";
	}

	protected override string _GetTemplateForMessagePhoneForUsernameSuccessTitle()
	{
		return "簡訊已傳送";
	}

	protected override string _GetTemplateForMessageAccountDoesNotHaveAnEmail()
	{
		return "此帳號沒有加入電子郵件地址";
	}

	protected override string _GetTemplateForMessageAccountNotFoundByEmail()
	{
		return "找不到帳號，請使用其它電子郵件地址。";
	}

	protected override string _GetTemplateForMessageAccountNotFoundByPhone()
	{
		return "找不到帳號，請使用其它手機號碼。";
	}

	protected override string _GetTemplateForMessageAccountRecoveryUnknownError()
	{
		return "系統錯誤，帳號無法恢復成此狀態。";
	}

	protected override string _GetTemplateForMessageCaptchaError()
	{
		return "我們需要進行真人驗證。";
	}

	protected override string _GetTemplateForMessageCaptchaFailError()
	{
		return "您輸入的文字與圖片不符，請重新嘗試。";
	}

	protected override string _GetTemplateForMessageCredentialsError()
	{
		return "您的使用者名稱或密碼不正確，請重新嘗試。";
	}

	protected override string _GetTemplateForMessageFloodCheckedError()
	{
		return "嘗試次數過多，請稍後再試。";
	}

	protected override string _GetTemplateForMessageForgotPasswordFeatureDisabled()
	{
		return "此功能暫時停用，請稍後再試。";
	}

	protected override string _GetTemplateForMessageForgotPasswordSuccess()
	{
		return "請查看您的電子郵件信箱取得登入說明";
	}

	protected override string _GetTemplateForMessageInvalidAccountStatus()
	{
		return "您的帳號狀態不允許您重置密碼";
	}

	protected override string _GetTemplateForMessageInvalidPassword()
	{
		return "密碼無效";
	}

	protected override string _GetTemplateForMessageInvalidTicket()
	{
		return "無法載入驗證票。";
	}

	protected override string _GetTemplateForMessageInvalidUserNameOrEmail()
	{
		return "使用者名稱或電子郵件地址無效";
	}

	protected override string _GetTemplateForMessageMobileResetPasswordSuccess()
	{
		return "MobileResetPasswordSuccess";
	}

	protected override string _GetTemplateForMessageNoAccountsLinkedToEmail()
	{
		return "沒有加入此電子郵件的帳號";
	}

	protected override string _GetTemplateForMessageOldUsernameError()
	{
		return "您似乎在以過去的使用者名稱登入，請以新的使用者名稱登入。";
	}

	protected override string _GetTemplateForMessagePasswordCannotBeUsed()
	{
		return "對不起，無法使用該密碼。";
	}

	/// <summary>
	/// Key: "MessagePasswordResetTicketExpired"
	/// English String: "Sorry, password reset requests expire {expirationHour} hours, {expirationMinute} minutes after issuance. Try requesting another password reset ticket again."
	/// </summary>
	public override string MessagePasswordResetTicketExpired(string expirationHour, string expirationMinute)
	{
		return $"對不起，密碼重置請求在 {expirationHour} 小時 {expirationMinute} 分鐘後失效。請重新嘗試請求。";
	}

	protected override string _GetTemplateForMessagePasswordResetTicketExpired()
	{
		return "對不起，密碼重置請求在 {expirationHour} 小時 {expirationMinute} 分鐘後失效。請重新嘗試請求。";
	}

	protected override string _GetTemplateForMessagePasswordsDoNotMatch()
	{
		return "密碼不相符";
	}

	protected override string _GetTemplateForMessageSamlUnauthenticated()
	{
		return "若要完成驗證，請登入 Roblox。";
	}

	protected override string _GetTemplateForMessageUnknownError()
	{
		return "未知錯誤";
	}

	protected override string _GetTemplateForMessageUnknownSystemError()
	{
		return "系統錯誤，請返回登入畫面。";
	}

	protected override string _GetTemplateForPlaceholderEmail()
	{
		return "電子郵件地址";
	}

	/// <summary>
	/// Key: "Placeholder.EnterCode"
	/// English String: "Enter Code ({codeLength}-digit)"
	/// </summary>
	public override string PlaceholderEnterCode(string codeLength)
	{
		return $"輸入驗證碼（{codeLength} 位數）";
	}

	protected override string _GetTemplateForPlaceholderEnterCode()
	{
		return "輸入驗證碼（{codeLength} 位數）";
	}

	protected override string _GetTemplateForPlaceholderPhoneNumber()
	{
		return "手機號碼";
	}

	protected override string _GetTemplateForResponsePasswordResetSuccess()
	{
		return "密碼重置成功，請重新登入。";
	}

	protected override string _GetTemplateForResponseSuccess()
	{
		return "成功";
	}

	protected override string _GetTemplateForResponseUpdatePasswordFlooded()
	{
		return "嘗試次數過多，請稍後再試。";
	}

	protected override string _GetTemplateForResponseUpdatePasswordIncorrect()
	{
		return "您目前的密碼不正確，密碼並未變更。";
	}

	protected override string _GetTemplateForResponseUpdatePasswordInputMissing()
	{
		return "必須輸入並確認新密碼";
	}

	protected override string _GetTemplateForResponseUpdatePasswordMismatch()
	{
		return "新密碼與確認密碼欄位必須相符";
	}
}
