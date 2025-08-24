namespace Roblox.TranslationResources.Authentication;

/// <summary>
/// This class overrides ResetPasswordResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ResetPasswordResources_zh_cjv : ResetPasswordResources_en_us, IResetPasswordResources, ITranslationResources
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
	public override string ActionEmailToResetPassword => "使用电子邮件以重置密码";

	/// <summary>
	/// Key: "Action.EmailToRetriveUsername"
	/// English String: "Use email to retrieve username"
	/// </summary>
	public override string ActionEmailToRetriveUsername => "使用电子邮件以取回用户名";

	/// <summary>
	/// Key: "Action.Ok"
	/// OK
	/// English String: "OK"
	/// </summary>
	public override string ActionOk => "好";

	/// <summary>
	/// Key: "Action.PhoneToResetPassword"
	/// English String: "Use phone number to reset password"
	/// </summary>
	public override string ActionPhoneToResetPassword => "使用手机号码以重置密码";

	/// <summary>
	/// Key: "Action.PhoneToRetriveUsername"
	/// English String: "Use phone number to retrieve username"
	/// </summary>
	public override string ActionPhoneToRetriveUsername => "使用手机号码以取回用户名";

	/// <summary>
	/// Key: "Action.Verify"
	/// English String: "Verify"
	/// </summary>
	public override string ActionVerify => "验证";

	/// <summary>
	/// Key: "Description.EmailToResetPassword"
	/// English String: "Enter your email to reset your password."
	/// </summary>
	public override string DescriptionEmailToResetPassword => "输入你的电子邮件以重置你的密码。";

	/// <summary>
	/// Key: "Description.EmailToRetriveUsername"
	/// English String: "Enter your email to retrieve your username."
	/// </summary>
	public override string DescriptionEmailToRetriveUsername => "输入你的电子邮件以取回你的用户名。";

	/// <summary>
	/// Key: "Description.PasswordChangeEmail.Subject"
	/// email subject to change password
	/// English String: "Roblox Password Reset"
	/// </summary>
	public override string DescriptionPasswordChangeEmailSubject => "Roblox 密码重置";

	/// <summary>
	/// Key: "Description.PasswordResetEmail.Subject"
	/// Subject for password reset email
	/// English String: "Roblox Account Password Reset"
	/// </summary>
	public override string DescriptionPasswordResetEmailSubject => "Roblox 帐户密码重置";

	/// <summary>
	/// Key: "Description.PhoneToResetPassword"
	/// English String: "Enter your phone number to reset your password."
	/// </summary>
	public override string DescriptionPhoneToResetPassword => "输入你的手机号码以重置你的密码。";

	/// <summary>
	/// Key: "Description.PhoneToRetriveUsername"
	/// English String: "Enter your phone number to retrieve your username."
	/// </summary>
	public override string DescriptionPhoneToRetriveUsername => "输入你的手机号码以取回你的用户名。";

	/// <summary>
	/// Key: "Heading.VerifyCode"
	/// verify code heading
	/// English String: "Verify Code"
	/// </summary>
	public override string HeadingVerifyCode => "验证码";

	/// <summary>
	/// Key: "Heading.VerifyPhone"
	/// English String: "Verify Phone"
	/// </summary>
	public override string HeadingVerifyPhone => "验证手机";

	/// <summary>
	/// Key: "HeadingForgetPasswordOrUsername"
	/// English String: "Forgot Password or Username"
	/// </summary>
	public override string HeadingForgetPasswordOrUsername => "忘记密码或用户名";

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
	public override string LabelForgetMyPassword => "忘记我的密码";

	/// <summary>
	/// Key: "Label.ForgetMyUsername"
	/// English String: "Forgot My Username"
	/// </summary>
	public override string LabelForgetMyUsername => "忘记我的用户名";

	/// <summary>
	/// Key: "Label.InvalidEmail"
	/// English String: "Invalid email"
	/// </summary>
	public override string LabelInvalidEmail => "电子邮件无效";

	/// <summary>
	/// Key: "Label.InvalidPhoneNumber"
	/// English String: "Invalid phone number"
	/// </summary>
	public override string LabelInvalidPhoneNumber => "手机号码无效";

	/// <summary>
	/// Key: "Label.NeutralButtonOk"
	/// ok button label
	/// English String: "OK"
	/// </summary>
	public override string LabelNeutralButtonOk => "好";

	/// <summary>
	/// Key: "Label.Password"
	/// label
	/// English String: "Password"
	/// </summary>
	public override string LabelPassword => "密码";

	/// <summary>
	/// Key: "Label.ResendCode"
	/// English String: "Resend Code"
	/// </summary>
	public override string LabelResendCode => "重新发送验证码";

	/// <summary>
	/// Key: "Label.Submit"
	/// English String: "Submit"
	/// </summary>
	public override string LabelSubmit => "提交";

	/// <summary>
	/// Key: "Label.ToolTip.WhoCanFindMeByPhone"
	/// English String: "This setting controls who can find you using the phone number you provided."
	/// </summary>
	public override string LabelToolTipWhoCanFindMeByPhone => "此设置可控制谁可以通过你提供的手机号码找到你。";

	/// <summary>
	/// Key: "Label.Username"
	/// English String: "Username"
	/// </summary>
	public override string LabelUsername => "用户名";

	/// <summary>
	/// Key: "Label.WhoCanFindMeByPhone"
	/// English String: "Who can find me by my phone number?"
	/// </summary>
	public override string LabelWhoCanFindMeByPhone => "谁可以通过我的手机号码找到我？";

	/// <summary>
	/// Key: "Message.DefaultError"
	/// English String: "An error occurred, try again later."
	/// </summary>
	public override string MessageDefaultError => "发生错误，请稍后重试。";

	/// <summary>
	/// Key: "Message.EmailForUsernameSuccessBody"
	/// success message
	/// English String: "An email with your username(s) has been sent to you if the email was previously saved on your account."
	/// </summary>
	public override string MessageEmailForUsernameSuccessBody => "如果你的帐户已保存电子邮件地址，那我们已向你发送了一封包含你用户名的电子邮件。";

	/// <summary>
	/// Key: "Message.EmailSuccessBody"
	/// English String: "An email with instructions has been sent to you if the email was previously saved on your account."
	/// </summary>
	public override string MessageEmailSuccessBody => "如果你的帐户已保存电子邮件地址，那我们已向你发送了一封附有说明的电子邮件。";

	/// <summary>
	/// Key: "Message.EmailSuccessTitle"
	/// English String: "Email Sent"
	/// </summary>
	public override string MessageEmailSuccessTitle => "电子邮件已发送";

	/// <summary>
	/// Key: "Message.EnterCode"
	/// English String: "A code was sent to your phone if it was previously verified on your account. Please enter it below"
	/// </summary>
	public override string MessageEnterCode => "如果你的手机号码已经过验证，你将收到我们发送至你手机的代码。请在下方输入";

	/// <summary>
	/// Key: "Message.EnterCodeSentToEmail"
	/// Enter the code we just sent to your email.
	/// English String: "Enter the code we just sent to your email."
	/// </summary>
	public override string MessageEnterCodeSentToEmail => "请输入我们刚发送至你电子邮件的代码。";

	/// <summary>
	/// Key: "Message.PhoneForUsernameSuccessBody"
	/// English String: "An SMS with your username(s) has been sent to you if the phone number was previously verified on your account."
	/// </summary>
	public override string MessagePhoneForUsernameSuccessBody => "如果你的帐户已验证过电话号码，那么我们已向你发送了一条包含你用户名的信息。";

	/// <summary>
	/// Key: "Message.PhoneForUsernameSuccessTitle"
	/// English String: "SMS Sent"
	/// </summary>
	public override string MessagePhoneForUsernameSuccessTitle => "短信已发送";

	/// <summary>
	/// Key: "MessageAccountDoesNotHaveAnEmail"
	/// English String: "There is no email linked to this account"
	/// </summary>
	public override string MessageAccountDoesNotHaveAnEmail => "没有与此帐户相关联的电子邮件";

	/// <summary>
	/// Key: "MessageAccountNotFoundByEmail"
	/// No account found. Please use a different email.
	/// English String: "No account found. Please use a different email."
	/// </summary>
	public override string MessageAccountNotFoundByEmail => "未找到帐户。请使用其他电子邮件。";

	/// <summary>
	/// Key: "MessageAccountNotFoundByPhone"
	/// No account found. Please use a different phone number.
	/// English String: "No account found. Please use a different phone number."
	/// </summary>
	public override string MessageAccountNotFoundByPhone => "未找到帐户。请使用其他手机号码。";

	/// <summary>
	/// Key: "MessageAccountRecoveryUnknownError"
	/// English String: "System error. Account could not be restored to this state."
	/// </summary>
	public override string MessageAccountRecoveryUnknownError => "系统错误。帐户无法恢复至此状态。";

	/// <summary>
	/// Key: "MessageCaptchaError"
	/// English String: "We need to make sure you're not a robot!"
	/// </summary>
	public override string MessageCaptchaError => "我们需要确定你不是机器人 :)";

	/// <summary>
	/// Key: "MessageCaptchaFailError"
	/// English String: "The words you typed didn't match the picture. Please try again."
	/// </summary>
	public override string MessageCaptchaFailError => "你键入的文字与图片不符。请重试。";

	/// <summary>
	/// Key: "MessageCredentialsError"
	/// English String: "Your username or password is incorrect. Please check them and try again."
	/// </summary>
	public override string MessageCredentialsError => "你的用户名或密码不正确。请检查并重试。";

	/// <summary>
	/// Key: "MessageFloodCheckedError"
	/// English String: "Too many attempts. Please try again later."
	/// </summary>
	public override string MessageFloodCheckedError => "尝试次数过多。请稍后重试。";

	/// <summary>
	/// Key: "MessageForgotPasswordFeatureDisabled"
	/// English String: "Feature temporarily disabled. Please try again later."
	/// </summary>
	public override string MessageForgotPasswordFeatureDisabled => "功能暂时停用。请稍后重试。";

	/// <summary>
	/// Key: "MessageForgotPasswordSuccess"
	/// English String: "Check your email for login instructions"
	/// </summary>
	public override string MessageForgotPasswordSuccess => "请查看你的邮件以获取登录说明";

	/// <summary>
	/// Key: "MessageInvalidAccountStatus"
	/// English String: "Account status prevents resetting password"
	/// </summary>
	public override string MessageInvalidAccountStatus => "帐户状态导致无法重置密码";

	/// <summary>
	/// Key: "MessageInvalidPassword"
	/// English String: "Invalid password"
	/// </summary>
	public override string MessageInvalidPassword => "密码无效";

	/// <summary>
	/// Key: "MessageInvalidTicket"
	/// English String: "We couldn't load this security ticket."
	/// </summary>
	public override string MessageInvalidTicket => "我们无法加载此安全票单。";

	/// <summary>
	/// Key: "MessageInvalidUserNameOrEmail"
	/// English String: "Invalid username, or no email exists"
	/// </summary>
	public override string MessageInvalidUserNameOrEmail => "用户名无效，或电子邮件不存在";

	/// <summary>
	/// Key: "MessageMobileResetPasswordSuccess"
	/// English String: "MobileResetPasswordSuccess"
	/// </summary>
	public override string MessageMobileResetPasswordSuccess => "MobileResetPasswordSuccess";

	/// <summary>
	/// Key: "MessageNoAccountsLinkedToEmail"
	/// English String: "There are no accounts linked to this email address"
	/// </summary>
	public override string MessageNoAccountsLinkedToEmail => "没有与此电子邮件地址相关联的帐户";

	/// <summary>
	/// Key: "MessageOldUsernameError"
	/// English String: "It looks like you are trying to log in with a username that has changed. Please log in with your new username."
	/// </summary>
	public override string MessageOldUsernameError => "你似乎在尝试使用已更改的用户名进行登录。请使用你的新用户名登录。";

	/// <summary>
	/// Key: "MessagePasswordCannotBeUsed"
	/// English String: "Sorry, that password cannot be used."
	/// </summary>
	public override string MessagePasswordCannotBeUsed => "抱歉，无法使用该密码。";

	/// <summary>
	/// Key: "MessagePasswordsDoNotMatch"
	/// English String: "Passwords do not match"
	/// </summary>
	public override string MessagePasswordsDoNotMatch => "密码不匹配";

	/// <summary>
	/// Key: "MessageSamlUnauthenticated"
	/// English String: "You must log in to Roblox to finish authenticating."
	/// </summary>
	public override string MessageSamlUnauthenticated => "你必须登录 Roblox 以完成身份验证。";

	/// <summary>
	/// Key: "MessageUnknownError"
	/// English String: "Unknown Error"
	/// </summary>
	public override string MessageUnknownError => "未知错误";

	/// <summary>
	/// Key: "MessageUnknownSystemError"
	/// English String: "System error. Please return to login screen."
	/// </summary>
	public override string MessageUnknownSystemError => "系统错误。请返回登录屏幕。";

	/// <summary>
	/// Key: "Placeholder.Email"
	/// English String: "Email"
	/// </summary>
	public override string PlaceholderEmail => "电子邮件";

	/// <summary>
	/// Key: "Placeholder.PhoneNumber"
	/// English String: "Phone Number"
	/// </summary>
	public override string PlaceholderPhoneNumber => "手机号码";

	/// <summary>
	/// Key: "Response.PasswordResetSuccess"
	/// Password reset success! Please login again.
	/// English String: "Password reset success! Please login again."
	/// </summary>
	public override string ResponsePasswordResetSuccess => "密码重置成功！请再次登录。";

	/// <summary>
	/// Key: "Response.Success"
	/// English String: "Success"
	/// </summary>
	public override string ResponseSuccess => "成功";

	/// <summary>
	/// Key: "Response.UpdatePasswordFlooded"
	/// English String: "Too many attempts. Please try again later."
	/// </summary>
	public override string ResponseUpdatePasswordFlooded => "尝试次数过多。请稍后重试。";

	/// <summary>
	/// Key: "Response.UpdatePasswordIncorrect"
	/// English String: "Your current password is incorrect, the password was not changed."
	/// </summary>
	public override string ResponseUpdatePasswordIncorrect => "你当前的密码不正确，密码未更改。";

	/// <summary>
	/// Key: "Response.UpdatePasswordInputMissing"
	/// English String: "Must include new password and confirm password"
	/// </summary>
	public override string ResponseUpdatePasswordInputMissing => "必须包含新密码并确认密码";

	/// <summary>
	/// Key: "Response.UpdatePasswordMismatch"
	/// English String: "Your new password and confirm password must match"
	/// </summary>
	public override string ResponseUpdatePasswordMismatch => "你的新密码须与确认密码相符";

	public ResetPasswordResources_zh_cjv(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "取消";
	}

	protected override string _GetTemplateForActionEmailToResetPassword()
	{
		return "使用电子邮件以重置密码";
	}

	protected override string _GetTemplateForActionEmailToRetriveUsername()
	{
		return "使用电子邮件以取回用户名";
	}

	protected override string _GetTemplateForActionOk()
	{
		return "好";
	}

	protected override string _GetTemplateForActionPhoneToResetPassword()
	{
		return "使用手机号码以重置密码";
	}

	protected override string _GetTemplateForActionPhoneToRetriveUsername()
	{
		return "使用手机号码以取回用户名";
	}

	protected override string _GetTemplateForActionVerify()
	{
		return "验证";
	}

	/// <summary>
	/// Key: "Description.ChangePasswordEmail.HtmlBody1"
	/// email body for change password email
	/// English String: "We noticed that the password changed for your Roblox account: {userName}. If you didn't intend to change it, or you think someone else changed it by mistake, please click this link to undo the action:{lineBreak} {actionLink} {lineBreak}{lineBreak}If you are happy with your new Roblox password, you don't have to do anything! It's already set up. Please do not reply to this message. If you have any questions, please see the Roblox help page (https://www.roblox.com/help)."
	/// </summary>
	public override string DescriptionChangePasswordEmailHtmlBody1(string userName, string lineBreak, string actionLink)
	{
		return $"我们注意到你 Roblox 帐户的密码已更改：{userName} 。如果你不想真的更改，或者你认为别人可能不小心作出了此更改，那么请点按此链接以撤销：{lineBreak}{actionLink}{lineBreak}{lineBreak}如果你更倾向于使用新的 Roblox 密码，无需任何步骤，帐户已设置好。请不要回复此消息。如果你有任何问题，请查看 Roblox 帮助页面（https://www.roblox.com/help）。";
	}

	protected override string _GetTemplateForDescriptionChangePasswordEmailHtmlBody1()
	{
		return "我们注意到你 Roblox 帐户的密码已更改：{userName} 。如果你不想真的更改，或者你认为别人可能不小心作出了此更改，那么请点按此链接以撤销：{lineBreak}{actionLink}{lineBreak}{lineBreak}如果你更倾向于使用新的 Roblox 密码，无需任何步骤，帐户已设置好。请不要回复此消息。如果你有任何问题，请查看 Roblox 帮助页面（https://www.roblox.com/help）。";
	}

	protected override string _GetTemplateForDescriptionEmailToResetPassword()
	{
		return "输入你的电子邮件以重置你的密码。";
	}

	protected override string _GetTemplateForDescriptionEmailToRetriveUsername()
	{
		return "输入你的电子邮件以取回你的用户名。";
	}

	/// <summary>
	/// Key: "Description.PasswordChangeEmail.BodyPlainText"
	/// password reset plaintext email message
	/// English String: "We noticed that the password changed for your Roblox account: {userName}. If you didn't intend to change it, or you think someone else changed it by mistake, please click this link to undo the action:\n{urlWithTicket}\n\nIf you are happy with your new Roblox password, you don't have to do anything! It's already set up. Please do not reply to this message. If you have any questions, please see the Roblox help page (https://www.roblox.com/help)."
	/// </summary>
	public override string DescriptionPasswordChangeEmailBodyPlainText(string userName, string urlWithTicket)
	{
		return $"我们注意到你 Roblox 帐户的密码已更改：{userName} 。如果你不想真的更改，或者你认为别人可能不小心作出了此更改，那么请点按此链接以撤销：\n{urlWithTicket}\n\n如果你更倾向于使用新的 Roblox 密码，无需任何步骤，帐户已设置好。请不要回复此消息。如果你有任何问题，请查看 Roblox 帮助页面（https://www.roblox.com/help）。";
	}

	protected override string _GetTemplateForDescriptionPasswordChangeEmailBodyPlainText()
	{
		return "我们注意到你 Roblox 帐户的密码已更改：{userName} 。如果你不想真的更改，或者你认为别人可能不小心作出了此更改，那么请点按此链接以撤销：\n{urlWithTicket}\n\n如果你更倾向于使用新的 Roblox 密码，无需任何步骤，帐户已设置好。请不要回复此消息。如果你有任何问题，请查看 Roblox 帮助页面（https://www.roblox.com/help）。";
	}

	/// <summary>
	/// Key: "Description.PasswordChangeEmail.From"
	/// name of the sender as shown in from field of the email
	/// English String: "\"Roblox Password Reset\" {fromEmailAddress}"
	/// </summary>
	public override string DescriptionPasswordChangeEmailFrom(string fromEmailAddress)
	{
		return $"“Roblox 帐户密码重置”{fromEmailAddress}";
	}

	protected override string _GetTemplateForDescriptionPasswordChangeEmailFrom()
	{
		return "“Roblox 帐户密码重置”{fromEmailAddress}";
	}

	protected override string _GetTemplateForDescriptionPasswordChangeEmailSubject()
	{
		return "Roblox 密码重置";
	}

	/// <summary>
	/// Key: "Description.PasswordResetEmail.From"
	/// The "From" field for the password reset email
	/// English String: "{escapeLiteralStart}Roblox Password Reset{escapeLiteralEnd} {fromEmailAddress}"
	/// </summary>
	public override string DescriptionPasswordResetEmailFrom(string escapeLiteralStart, string escapeLiteralEnd, string fromEmailAddress)
	{
		return $"{escapeLiteralStart}Roblox 密码重置{escapeLiteralEnd}{fromEmailAddress}";
	}

	protected override string _GetTemplateForDescriptionPasswordResetEmailFrom()
	{
		return "{escapeLiteralStart}Roblox 密码重置{escapeLiteralEnd}{fromEmailAddress}";
	}

	/// <summary>
	/// Key: "Description.PasswordResetEmail.HtmlBody"
	/// This email is sent when a user requests a password reset.
	/// English String: "We have received a request to reset the password for your Roblox account: {emailOrUsername}{lineBreak}{lineBreak}If you submitted this request, please click the button below to proceed.{lineBreak}This button will be active for {passwordResetTicketHours} hours, {passwordResetTicketMinutes} minutes. If you do not wish to reset your password, please disregard this notice.{lineBreak}{lineBreak}{aTagWithStartHref}{resetPasswordUrl}{hrefEnd}{buttonStart}Reset Password{buttonEnd}{aTagEnd}"
	/// </summary>
	public override string DescriptionPasswordResetEmailHtmlBody(string emailOrUsername, string lineBreak, string passwordResetTicketHours, string passwordResetTicketMinutes, string aTagWithStartHref, string resetPasswordUrl, string hrefEnd, string buttonStart, string buttonEnd, string aTagEnd)
	{
		return $"我们已收到重置你的 Roblox 帐户密码的请求：{emailOrUsername}{lineBreak}{lineBreak}如果你提交了该请求，请点按下方按钮以继续。{lineBreak}按钮链接将会在{passwordResetTicketHours} 小时 {passwordResetTicketMinutes} 内有效。如果你不想重置密码，请忽略此通知。{lineBreak}{lineBreak}{aTagWithStartHref}{resetPasswordUrl}{hrefEnd}{buttonStart}重置密码{buttonEnd}{aTagEnd}";
	}

	protected override string _GetTemplateForDescriptionPasswordResetEmailHtmlBody()
	{
		return "我们已收到重置你的 Roblox 帐户密码的请求：{emailOrUsername}{lineBreak}{lineBreak}如果你提交了该请求，请点按下方按钮以继续。{lineBreak}按钮链接将会在{passwordResetTicketHours} 小时 {passwordResetTicketMinutes} 内有效。如果你不想重置密码，请忽略此通知。{lineBreak}{lineBreak}{aTagWithStartHref}{resetPasswordUrl}{hrefEnd}{buttonStart}重置密码{buttonEnd}{aTagEnd}";
	}

	/// <summary>
	/// Key: "Description.PasswordResetEmail.PlainBody"
	/// This email is sent when a user requests a password reset.
	/// English String: "We have received a request to reset the password for your Roblox account: {emailOrUsername}{lineBreak}{lineBreak}If you submitted this request, please click the link below or paste it into a web browser to proceed.{lineBreak}This link will be active for {passwordResetTicketHours} hours, {passwordResetTicketMinutes} minutes. If you do not wish to reset your password, please disregard this notice.{lineBreak}{lineBreak}{resetPasswordUrl}"
	/// </summary>
	public override string DescriptionPasswordResetEmailPlainBody(string emailOrUsername, string lineBreak, string passwordResetTicketHours, string passwordResetTicketMinutes, string resetPasswordUrl)
	{
		return $"我们已收到重置你的 Roblox 帐户密码的请求：{emailOrUsername}{lineBreak}{lineBreak}如果你提交了该请求，请点按下方链接，或将其粘贴至网页浏览器以继续。{lineBreak}此链接将会在{passwordResetTicketHours} 小时 {passwordResetTicketMinutes} 内有效。如果你不想重置密码，请忽略此通知。{lineBreak}{lineBreak}{resetPasswordUrl}";
	}

	protected override string _GetTemplateForDescriptionPasswordResetEmailPlainBody()
	{
		return "我们已收到重置你的 Roblox 帐户密码的请求：{emailOrUsername}{lineBreak}{lineBreak}如果你提交了该请求，请点按下方链接，或将其粘贴至网页浏览器以继续。{lineBreak}此链接将会在{passwordResetTicketHours} 小时 {passwordResetTicketMinutes} 内有效。如果你不想重置密码，请忽略此通知。{lineBreak}{lineBreak}{resetPasswordUrl}";
	}

	protected override string _GetTemplateForDescriptionPasswordResetEmailSubject()
	{
		return "Roblox 帐户密码重置";
	}

	protected override string _GetTemplateForDescriptionPhoneToResetPassword()
	{
		return "输入你的手机号码以重置你的密码。";
	}

	protected override string _GetTemplateForDescriptionPhoneToRetriveUsername()
	{
		return "输入你的手机号码以取回你的用户名。";
	}

	protected override string _GetTemplateForHeadingVerifyCode()
	{
		return "验证码";
	}

	protected override string _GetTemplateForHeadingVerifyPhone()
	{
		return "验证手机";
	}

	protected override string _GetTemplateForHeadingForgetPasswordOrUsername()
	{
		return "忘记密码或用户名";
	}

	protected override string _GetTemplateForLabelActionButtonYes()
	{
		return "是";
	}

	protected override string _GetTemplateForLabelForgetMyPassword()
	{
		return "忘记我的密码";
	}

	protected override string _GetTemplateForLabelForgetMyUsername()
	{
		return "忘记我的用户名";
	}

	protected override string _GetTemplateForLabelInvalidEmail()
	{
		return "电子邮件无效";
	}

	protected override string _GetTemplateForLabelInvalidPhoneNumber()
	{
		return "手机号码无效";
	}

	protected override string _GetTemplateForLabelNeutralButtonOk()
	{
		return "好";
	}

	protected override string _GetTemplateForLabelPassword()
	{
		return "密码";
	}

	protected override string _GetTemplateForLabelResendCode()
	{
		return "重新发送验证码";
	}

	protected override string _GetTemplateForLabelSubmit()
	{
		return "提交";
	}

	protected override string _GetTemplateForLabelToolTipWhoCanFindMeByPhone()
	{
		return "此设置可控制谁可以通过你提供的手机号码找到你。";
	}

	protected override string _GetTemplateForLabelUsername()
	{
		return "用户名";
	}

	protected override string _GetTemplateForLabelWhoCanFindMeByPhone()
	{
		return "谁可以通过我的手机号码找到我？";
	}

	/// <summary>
	/// Key: "Message.CantSendEmailWarning"
	/// English String: "If you did not give us a {styleStart}real email address{styleEnd} when you created your account, we cannot send you an email."
	/// </summary>
	public override string MessageCantSendEmailWarning(string styleStart, string styleEnd)
	{
		return $"如果你在创建帐户时未提供{styleStart}真实的电子邮件地址{styleEnd}，我们则无法向你发送电子邮件。";
	}

	protected override string _GetTemplateForMessageCantSendEmailWarning()
	{
		return "如果你在创建帐户时未提供{styleStart}真实的电子邮件地址{styleEnd}，我们则无法向你发送电子邮件。";
	}

	protected override string _GetTemplateForMessageDefaultError()
	{
		return "发生错误，请稍后重试。";
	}

	protected override string _GetTemplateForMessageEmailForUsernameSuccessBody()
	{
		return "如果你的帐户已保存电子邮件地址，那我们已向你发送了一封包含你用户名的电子邮件。";
	}

	protected override string _GetTemplateForMessageEmailSuccessBody()
	{
		return "如果你的帐户已保存电子邮件地址，那我们已向你发送了一封附有说明的电子邮件。";
	}

	protected override string _GetTemplateForMessageEmailSuccessTitle()
	{
		return "电子邮件已发送";
	}

	protected override string _GetTemplateForMessageEnterCode()
	{
		return "如果你的手机号码已经过验证，你将收到我们发送至你手机的代码。请在下方输入";
	}

	protected override string _GetTemplateForMessageEnterCodeSentToEmail()
	{
		return "请输入我们刚发送至你电子邮件的代码。";
	}

	protected override string _GetTemplateForMessagePhoneForUsernameSuccessBody()
	{
		return "如果你的帐户已验证过电话号码，那么我们已向你发送了一条包含你用户名的信息。";
	}

	protected override string _GetTemplateForMessagePhoneForUsernameSuccessTitle()
	{
		return "短信已发送";
	}

	protected override string _GetTemplateForMessageAccountDoesNotHaveAnEmail()
	{
		return "没有与此帐户相关联的电子邮件";
	}

	protected override string _GetTemplateForMessageAccountNotFoundByEmail()
	{
		return "未找到帐户。请使用其他电子邮件。";
	}

	protected override string _GetTemplateForMessageAccountNotFoundByPhone()
	{
		return "未找到帐户。请使用其他手机号码。";
	}

	protected override string _GetTemplateForMessageAccountRecoveryUnknownError()
	{
		return "系统错误。帐户无法恢复至此状态。";
	}

	protected override string _GetTemplateForMessageCaptchaError()
	{
		return "我们需要确定你不是机器人 :)";
	}

	protected override string _GetTemplateForMessageCaptchaFailError()
	{
		return "你键入的文字与图片不符。请重试。";
	}

	protected override string _GetTemplateForMessageCredentialsError()
	{
		return "你的用户名或密码不正确。请检查并重试。";
	}

	protected override string _GetTemplateForMessageFloodCheckedError()
	{
		return "尝试次数过多。请稍后重试。";
	}

	protected override string _GetTemplateForMessageForgotPasswordFeatureDisabled()
	{
		return "功能暂时停用。请稍后重试。";
	}

	protected override string _GetTemplateForMessageForgotPasswordSuccess()
	{
		return "请查看你的邮件以获取登录说明";
	}

	protected override string _GetTemplateForMessageInvalidAccountStatus()
	{
		return "帐户状态导致无法重置密码";
	}

	protected override string _GetTemplateForMessageInvalidPassword()
	{
		return "密码无效";
	}

	protected override string _GetTemplateForMessageInvalidTicket()
	{
		return "我们无法加载此安全票单。";
	}

	protected override string _GetTemplateForMessageInvalidUserNameOrEmail()
	{
		return "用户名无效，或电子邮件不存在";
	}

	protected override string _GetTemplateForMessageMobileResetPasswordSuccess()
	{
		return "MobileResetPasswordSuccess";
	}

	protected override string _GetTemplateForMessageNoAccountsLinkedToEmail()
	{
		return "没有与此电子邮件地址相关联的帐户";
	}

	protected override string _GetTemplateForMessageOldUsernameError()
	{
		return "你似乎在尝试使用已更改的用户名进行登录。请使用你的新用户名登录。";
	}

	protected override string _GetTemplateForMessagePasswordCannotBeUsed()
	{
		return "抱歉，无法使用该密码。";
	}

	/// <summary>
	/// Key: "MessagePasswordResetTicketExpired"
	/// English String: "Sorry, password reset requests expire {expirationHour} hours, {expirationMinute} minutes after issuance. Try requesting another password reset ticket again."
	/// </summary>
	public override string MessagePasswordResetTicketExpired(string expirationHour, string expirationMinute)
	{
		return $"抱歉，密码重置请求会在发送后的 {expirationHour} 小时 {expirationMinute} 分后过期。请重新提交一张密码重置票单。";
	}

	protected override string _GetTemplateForMessagePasswordResetTicketExpired()
	{
		return "抱歉，密码重置请求会在发送后的 {expirationHour} 小时 {expirationMinute} 分后过期。请重新提交一张密码重置票单。";
	}

	protected override string _GetTemplateForMessagePasswordsDoNotMatch()
	{
		return "密码不匹配";
	}

	protected override string _GetTemplateForMessageSamlUnauthenticated()
	{
		return "你必须登录 Roblox 以完成身份验证。";
	}

	protected override string _GetTemplateForMessageUnknownError()
	{
		return "未知错误";
	}

	protected override string _GetTemplateForMessageUnknownSystemError()
	{
		return "系统错误。请返回登录屏幕。";
	}

	protected override string _GetTemplateForPlaceholderEmail()
	{
		return "电子邮件";
	}

	/// <summary>
	/// Key: "Placeholder.EnterCode"
	/// English String: "Enter Code ({codeLength}-digit)"
	/// </summary>
	public override string PlaceholderEnterCode(string codeLength)
	{
		return $"输入验证码（{codeLength} 位）";
	}

	protected override string _GetTemplateForPlaceholderEnterCode()
	{
		return "输入验证码（{codeLength} 位）";
	}

	protected override string _GetTemplateForPlaceholderPhoneNumber()
	{
		return "手机号码";
	}

	protected override string _GetTemplateForResponsePasswordResetSuccess()
	{
		return "密码重置成功！请再次登录。";
	}

	protected override string _GetTemplateForResponseSuccess()
	{
		return "成功";
	}

	protected override string _GetTemplateForResponseUpdatePasswordFlooded()
	{
		return "尝试次数过多。请稍后重试。";
	}

	protected override string _GetTemplateForResponseUpdatePasswordIncorrect()
	{
		return "你当前的密码不正确，密码未更改。";
	}

	protected override string _GetTemplateForResponseUpdatePasswordInputMissing()
	{
		return "必须包含新密码并确认密码";
	}

	protected override string _GetTemplateForResponseUpdatePasswordMismatch()
	{
		return "你的新密码须与确认密码相符";
	}
}
