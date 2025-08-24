namespace Roblox.TranslationResources.Authentication;

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
	public override string ActionCancel => "Отмена";

	/// <summary>
	/// Key: "Action.EmailToResetPassword"
	/// English String: "Use email to reset password"
	/// </summary>
	public override string ActionEmailToResetPassword => "Сбросить пароль с помощью эл. почты";

	/// <summary>
	/// Key: "Action.EmailToRetriveUsername"
	/// English String: "Use email to retrieve username"
	/// </summary>
	public override string ActionEmailToRetriveUsername => "Восстановить имя пользователя с помощью эл. почты";

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
	public override string ActionPhoneToResetPassword => "Сбросить пароль с помощью телефона";

	/// <summary>
	/// Key: "Action.PhoneToRetriveUsername"
	/// English String: "Use phone number to retrieve username"
	/// </summary>
	public override string ActionPhoneToRetriveUsername => "Восстановить имя пользователя с помощью телефона";

	/// <summary>
	/// Key: "Action.Verify"
	/// English String: "Verify"
	/// </summary>
	public override string ActionVerify => "Подтвердить";

	/// <summary>
	/// Key: "Description.EmailToResetPassword"
	/// English String: "Enter your email to reset your password."
	/// </summary>
	public override string DescriptionEmailToResetPassword => "Введите адрес эл. почты, чтобы сбросить пароль.";

	/// <summary>
	/// Key: "Description.EmailToRetriveUsername"
	/// English String: "Enter your email to retrieve your username."
	/// </summary>
	public override string DescriptionEmailToRetriveUsername => "Введите адрес эл. почты, чтобы восстановить свое имя пользователя.";

	/// <summary>
	/// Key: "Description.PasswordChangeEmail.Subject"
	/// email subject to change password
	/// English String: "Roblox Password Reset"
	/// </summary>
	public override string DescriptionPasswordChangeEmailSubject => "Сброс пароля Roblox";

	/// <summary>
	/// Key: "Description.PasswordResetEmail.Subject"
	/// Subject for password reset email
	/// English String: "Roblox Account Password Reset"
	/// </summary>
	public override string DescriptionPasswordResetEmailSubject => "Изменение пароля учетной записи Roblox";

	/// <summary>
	/// Key: "Description.PhoneToResetPassword"
	/// English String: "Enter your phone number to reset your password."
	/// </summary>
	public override string DescriptionPhoneToResetPassword => "Введите номер телефона, чтобы сбросить пароль.";

	/// <summary>
	/// Key: "Description.PhoneToRetriveUsername"
	/// English String: "Enter your phone number to retrieve your username."
	/// </summary>
	public override string DescriptionPhoneToRetriveUsername => "Введите номер телефона, чтобы восстановить свое имя пользователя.";

	/// <summary>
	/// Key: "Heading.VerifyCode"
	/// verify code heading
	/// English String: "Verify Code"
	/// </summary>
	public override string HeadingVerifyCode => "Подтвердить код";

	/// <summary>
	/// Key: "Heading.VerifyPhone"
	/// English String: "Verify Phone"
	/// </summary>
	public override string HeadingVerifyPhone => "Проверка телефона";

	/// <summary>
	/// Key: "HeadingForgetPasswordOrUsername"
	/// English String: "Forgot Password or Username"
	/// </summary>
	public override string HeadingForgetPasswordOrUsername => "Забыт пароль или имя пользователя";

	/// <summary>
	/// Key: "Label.ActionButtonYes"
	/// button label
	/// English String: "Yes"
	/// </summary>
	public override string LabelActionButtonYes => "Да";

	/// <summary>
	/// Key: "Label.ForgetMyPassword"
	/// English String: "Forgot My Password"
	/// </summary>
	public override string LabelForgetMyPassword => "Пароль забыт";

	/// <summary>
	/// Key: "Label.ForgetMyUsername"
	/// English String: "Forgot My Username"
	/// </summary>
	public override string LabelForgetMyUsername => "Имя пользователя забыто";

	/// <summary>
	/// Key: "Label.InvalidEmail"
	/// English String: "Invalid email"
	/// </summary>
	public override string LabelInvalidEmail => "Недопустимый адрес эл. почты";

	/// <summary>
	/// Key: "Label.InvalidPhoneNumber"
	/// English String: "Invalid phone number"
	/// </summary>
	public override string LabelInvalidPhoneNumber => "Недопустимый номер телефона";

	/// <summary>
	/// Key: "Label.NeutralButtonOk"
	/// ok button label
	/// English String: "OK"
	/// </summary>
	public override string LabelNeutralButtonOk => "ОК";

	/// <summary>
	/// Key: "Label.Password"
	/// label
	/// English String: "Password"
	/// </summary>
	public override string LabelPassword => "Пароль";

	/// <summary>
	/// Key: "Label.ResendCode"
	/// English String: "Resend Code"
	/// </summary>
	public override string LabelResendCode => "Отправить код заново";

	/// <summary>
	/// Key: "Label.Submit"
	/// English String: "Submit"
	/// </summary>
	public override string LabelSubmit => "Отправить";

	/// <summary>
	/// Key: "Label.ToolTip.WhoCanFindMeByPhone"
	/// English String: "This setting controls who can find you using the phone number you provided."
	/// </summary>
	public override string LabelToolTipWhoCanFindMeByPhone => "Эта настройка позволяет указать, кто может найти вас по номеру вашего телефона.";

	/// <summary>
	/// Key: "Label.Username"
	/// English String: "Username"
	/// </summary>
	public override string LabelUsername => "Имя пользователя";

	/// <summary>
	/// Key: "Label.WhoCanFindMeByPhone"
	/// English String: "Who can find me by my phone number?"
	/// </summary>
	public override string LabelWhoCanFindMeByPhone => "Кто может найти меня по номеру телефона?";

	/// <summary>
	/// Key: "Message.DefaultError"
	/// English String: "An error occurred, try again later."
	/// </summary>
	public override string MessageDefaultError => "Произошла ошибка. Повторите попытку позже.";

	/// <summary>
	/// Key: "Message.EmailForUsernameSuccessBody"
	/// success message
	/// English String: "An email with your username(s) has been sent to you if the email was previously saved on your account."
	/// </summary>
	public override string MessageEmailForUsernameSuccessBody => "Если ваша эл. почта была ранее подтверждена в вашей учетной записи, то на ее адрес было выслано ваше имя пользователя.";

	/// <summary>
	/// Key: "Message.EmailSuccessBody"
	/// English String: "An email with instructions has been sent to you if the email was previously saved on your account."
	/// </summary>
	public override string MessageEmailSuccessBody => "Если в вашей учетной записи была сохранена эл. почта, на нее были отправлены инструкции.";

	/// <summary>
	/// Key: "Message.EmailSuccessTitle"
	/// English String: "Email Sent"
	/// </summary>
	public override string MessageEmailSuccessTitle => "Сообщение отправлено";

	/// <summary>
	/// Key: "Message.EnterCode"
	/// English String: "A code was sent to your phone if it was previously verified on your account. Please enter it below"
	/// </summary>
	public override string MessageEnterCode => "Если ваш телефон был ранее подтвержден в вашей учетной записи, то на его номер был выслан код. Пожалуйста, введите его ниже.";

	/// <summary>
	/// Key: "Message.EnterCodeSentToEmail"
	/// Enter the code we just sent to your email.
	/// English String: "Enter the code we just sent to your email."
	/// </summary>
	public override string MessageEnterCodeSentToEmail => "Введите код, отправленный вам по электронной почте.";

	/// <summary>
	/// Key: "Message.PhoneForUsernameSuccessBody"
	/// English String: "An SMS with your username(s) has been sent to you if the phone number was previously verified on your account."
	/// </summary>
	public override string MessagePhoneForUsernameSuccessBody => "СМС с вашим именем (именами) пользователя(-ей) было отправлено на телефонный номер, если он был подтвержден в вашей учетной записи.";

	/// <summary>
	/// Key: "Message.PhoneForUsernameSuccessTitle"
	/// English String: "SMS Sent"
	/// </summary>
	public override string MessagePhoneForUsernameSuccessTitle => "СМС отправлено";

	/// <summary>
	/// Key: "MessageAccountDoesNotHaveAnEmail"
	/// English String: "There is no email linked to this account"
	/// </summary>
	public override string MessageAccountDoesNotHaveAnEmail => "К этой учетной записи не прикреплен адрес эл. почты";

	/// <summary>
	/// Key: "MessageAccountNotFoundByEmail"
	/// No account found. Please use a different email.
	/// English String: "No account found. Please use a different email."
	/// </summary>
	public override string MessageAccountNotFoundByEmail => "Учетная запись не найдена. Укажите другой адрес эл. почты.";

	/// <summary>
	/// Key: "MessageAccountNotFoundByPhone"
	/// No account found. Please use a different phone number.
	/// English String: "No account found. Please use a different phone number."
	/// </summary>
	public override string MessageAccountNotFoundByPhone => "Учетная запись не найдена. Укажите другой номер телефона.";

	/// <summary>
	/// Key: "MessageAccountRecoveryUnknownError"
	/// English String: "System error. Account could not be restored to this state."
	/// </summary>
	public override string MessageAccountRecoveryUnknownError => "Ошибка системы. Учетную запись невозможно восстановить до этого состояния.";

	/// <summary>
	/// Key: "MessageCaptchaError"
	/// English String: "We need to make sure you're not a robot!"
	/// </summary>
	public override string MessageCaptchaError => "Нам необходимо убедиться, что вы – не робот!";

	/// <summary>
	/// Key: "MessageCaptchaFailError"
	/// English String: "The words you typed didn't match the picture. Please try again."
	/// </summary>
	public override string MessageCaptchaFailError => "Введенные вами слова не соответствуют изображению. Повторите попытку.";

	/// <summary>
	/// Key: "MessageCredentialsError"
	/// English String: "Your username or password is incorrect. Please check them and try again."
	/// </summary>
	public override string MessageCredentialsError => "Неправильный пароль или имя пользователя. Проверьте еще раз и повторите попытку.";

	/// <summary>
	/// Key: "MessageFloodCheckedError"
	/// English String: "Too many attempts. Please try again later."
	/// </summary>
	public override string MessageFloodCheckedError => "Слишком много попыток. Повторите попытку позже.";

	/// <summary>
	/// Key: "MessageForgotPasswordFeatureDisabled"
	/// English String: "Feature temporarily disabled. Please try again later."
	/// </summary>
	public override string MessageForgotPasswordFeatureDisabled => "Функция временно недоступна. Повторите попытку позже.";

	/// <summary>
	/// Key: "MessageForgotPasswordSuccess"
	/// English String: "Check your email for login instructions"
	/// </summary>
	public override string MessageForgotPasswordSuccess => "Инструкции по входу отправлены вам по электронной почте";

	/// <summary>
	/// Key: "MessageInvalidAccountStatus"
	/// English String: "Account status prevents resetting password"
	/// </summary>
	public override string MessageInvalidAccountStatus => "Состояние учетной записи запрещает сброс пароля";

	/// <summary>
	/// Key: "MessageInvalidPassword"
	/// English String: "Invalid password"
	/// </summary>
	public override string MessageInvalidPassword => "Недопустимый пароль";

	/// <summary>
	/// Key: "MessageInvalidTicket"
	/// English String: "We couldn't load this security ticket."
	/// </summary>
	public override string MessageInvalidTicket => "Не удалось загрузить этот билет безопасности.";

	/// <summary>
	/// Key: "MessageInvalidUserNameOrEmail"
	/// English String: "Invalid username, or no email exists"
	/// </summary>
	public override string MessageInvalidUserNameOrEmail => "Недопустимое имя пользователя или несуществующий адрес эл. почты";

	/// <summary>
	/// Key: "MessageMobileResetPasswordSuccess"
	/// English String: "MobileResetPasswordSuccess"
	/// </summary>
	public override string MessageMobileResetPasswordSuccess => "MobileResetPasswordSuccess";

	/// <summary>
	/// Key: "MessageNoAccountsLinkedToEmail"
	/// English String: "There are no accounts linked to this email address"
	/// </summary>
	public override string MessageNoAccountsLinkedToEmail => "К этому адресу эл. почты не прикреплена учетная запись";

	/// <summary>
	/// Key: "MessageOldUsernameError"
	/// English String: "It looks like you are trying to log in with a username that has changed. Please log in with your new username."
	/// </summary>
	public override string MessageOldUsernameError => "Похоже, вы указываете имя пользователя, которое было изменено. Войдите с новым именем пользователя.";

	/// <summary>
	/// Key: "MessagePasswordCannotBeUsed"
	/// English String: "Sorry, that password cannot be used."
	/// </summary>
	public override string MessagePasswordCannotBeUsed => "К сожалению, этот пароль нельзя использовать.";

	/// <summary>
	/// Key: "MessagePasswordsDoNotMatch"
	/// English String: "Passwords do not match"
	/// </summary>
	public override string MessagePasswordsDoNotMatch => "Пароли не совпадают";

	/// <summary>
	/// Key: "MessageSamlUnauthenticated"
	/// English String: "You must log in to Roblox to finish authenticating."
	/// </summary>
	public override string MessageSamlUnauthenticated => "Необходимо войти в Roblox, чтобы завершить аутентификацию.";

	/// <summary>
	/// Key: "MessageUnknownError"
	/// English String: "Unknown Error"
	/// </summary>
	public override string MessageUnknownError => "Неизвестная ошибка";

	/// <summary>
	/// Key: "MessageUnknownSystemError"
	/// English String: "System error. Please return to login screen."
	/// </summary>
	public override string MessageUnknownSystemError => "Ошибка системы. Вернитесь на экран входа.";

	/// <summary>
	/// Key: "Placeholder.Email"
	/// English String: "Email"
	/// </summary>
	public override string PlaceholderEmail => "Эл. почта";

	/// <summary>
	/// Key: "Placeholder.PhoneNumber"
	/// English String: "Phone Number"
	/// </summary>
	public override string PlaceholderPhoneNumber => "Номер телефона";

	/// <summary>
	/// Key: "Response.PasswordResetSuccess"
	/// Password reset success! Please login again.
	/// English String: "Password reset success! Please login again."
	/// </summary>
	public override string ResponsePasswordResetSuccess => "Пароль сброшен! Войдите в учетную запись повторно.";

	/// <summary>
	/// Key: "Response.Success"
	/// English String: "Success"
	/// </summary>
	public override string ResponseSuccess => "Успех";

	/// <summary>
	/// Key: "Response.UpdatePasswordFlooded"
	/// English String: "Too many attempts. Please try again later."
	/// </summary>
	public override string ResponseUpdatePasswordFlooded => "Слишком много попыток. Повторите попытку позже.";

	/// <summary>
	/// Key: "Response.UpdatePasswordIncorrect"
	/// English String: "Your current password is incorrect, the password was not changed."
	/// </summary>
	public override string ResponseUpdatePasswordIncorrect => "Неправильный текущий пароль. Пароль не изменен.";

	/// <summary>
	/// Key: "Response.UpdatePasswordInputMissing"
	/// English String: "Must include new password and confirm password"
	/// </summary>
	public override string ResponseUpdatePasswordInputMissing => "Требуется указать и подтвердить новый пароль";

	/// <summary>
	/// Key: "Response.UpdatePasswordMismatch"
	/// English String: "Your new password and confirm password must match"
	/// </summary>
	public override string ResponseUpdatePasswordMismatch => "Данные в полях «Новый пароль» и «Подтверждение пароля» должны совпадать";

	public ResetPasswordResources_ru_ru(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "Отмена";
	}

	protected override string _GetTemplateForActionEmailToResetPassword()
	{
		return "Сбросить пароль с помощью эл. почты";
	}

	protected override string _GetTemplateForActionEmailToRetriveUsername()
	{
		return "Восстановить имя пользователя с помощью эл. почты";
	}

	protected override string _GetTemplateForActionOk()
	{
		return "OK";
	}

	protected override string _GetTemplateForActionPhoneToResetPassword()
	{
		return "Сбросить пароль с помощью телефона";
	}

	protected override string _GetTemplateForActionPhoneToRetriveUsername()
	{
		return "Восстановить имя пользователя с помощью телефона";
	}

	protected override string _GetTemplateForActionVerify()
	{
		return "Подтвердить";
	}

	/// <summary>
	/// Key: "Description.ChangePasswordEmail.HtmlBody1"
	/// email body for change password email
	/// English String: "We noticed that the password changed for your Roblox account: {userName}. If you didn't intend to change it, or you think someone else changed it by mistake, please click this link to undo the action:{lineBreak} {actionLink} {lineBreak}{lineBreak}If you are happy with your new Roblox password, you don't have to do anything! It's already set up. Please do not reply to this message. If you have any questions, please see the Roblox help page (https://www.roblox.com/help)."
	/// </summary>
	public override string DescriptionChangePasswordEmailHtmlBody1(string userName, string lineBreak, string actionLink)
	{
		return $".Мы заметили, что вы изменили пароль для учетной записи  Roblox: {userName}Если вы этого не совершали или кто-то не сделал этого по ошибке, пожалуйста, пройдите по ссылке ниже:{lineBreak}{actionLink}{lineBreak}{lineBreak}Если вас устраивает ваш новый пароль  Roblox, товам ничего не нужно делать. Все уже настроено. Пожалуйста, не отвечайте на это сообщение. Если у вас есть вопросы, обратитесть на сраницу помощи  Roblox (https://www.roblox.com/help).";
	}

	protected override string _GetTemplateForDescriptionChangePasswordEmailHtmlBody1()
	{
		return ".Мы заметили, что вы изменили пароль для учетной записи  Roblox: {userName}Если вы этого не совершали или кто-то не сделал этого по ошибке, пожалуйста, пройдите по ссылке ниже:{lineBreak}{actionLink}{lineBreak}{lineBreak}Если вас устраивает ваш новый пароль  Roblox, товам ничего не нужно делать. Все уже настроено. Пожалуйста, не отвечайте на это сообщение. Если у вас есть вопросы, обратитесть на сраницу помощи  Roblox (https://www.roblox.com/help).";
	}

	protected override string _GetTemplateForDescriptionEmailToResetPassword()
	{
		return "Введите адрес эл. почты, чтобы сбросить пароль.";
	}

	protected override string _GetTemplateForDescriptionEmailToRetriveUsername()
	{
		return "Введите адрес эл. почты, чтобы восстановить свое имя пользователя.";
	}

	/// <summary>
	/// Key: "Description.PasswordChangeEmail.BodyPlainText"
	/// password reset plaintext email message
	/// English String: "We noticed that the password changed for your Roblox account: {userName}. If you didn't intend to change it, or you think someone else changed it by mistake, please click this link to undo the action:\n{urlWithTicket}\n\nIf you are happy with your new Roblox password, you don't have to do anything! It's already set up. Please do not reply to this message. If you have any questions, please see the Roblox help page (https://www.roblox.com/help)."
	/// </summary>
	public override string DescriptionPasswordChangeEmailBodyPlainText(string userName, string urlWithTicket)
	{
		return $"Мы заметили, что вы изменили пароль для учетной записи  Roblox: {userName}Если вы этого не совершали или кто-то не сделал этого по ошибке, пожалуйста, пройдите по ссылке ниже:\n{urlWithTicket}\n\nЕсли вас устраивает ваш новый пароль  Roblox, товам ничего не нужно делать. Все уже настроено. Пожалуйста, не отвечайте на это сообщение. Если у вас есть вопросы, обратитесть на сраницу помощи  Roblox (https://www.roblox.com/help).";
	}

	protected override string _GetTemplateForDescriptionPasswordChangeEmailBodyPlainText()
	{
		return "Мы заметили, что вы изменили пароль для учетной записи  Roblox: {userName}Если вы этого не совершали или кто-то не сделал этого по ошибке, пожалуйста, пройдите по ссылке ниже:\n{urlWithTicket}\n\nЕсли вас устраивает ваш новый пароль  Roblox, товам ничего не нужно делать. Все уже настроено. Пожалуйста, не отвечайте на это сообщение. Если у вас есть вопросы, обратитесть на сраницу помощи  Roblox (https://www.roblox.com/help).";
	}

	/// <summary>
	/// Key: "Description.PasswordChangeEmail.From"
	/// name of the sender as shown in from field of the email
	/// English String: "\"Roblox Password Reset\" {fromEmailAddress}"
	/// </summary>
	public override string DescriptionPasswordChangeEmailFrom(string fromEmailAddress)
	{
		return $"«Изменение пароля Roblox» {fromEmailAddress}";
	}

	protected override string _GetTemplateForDescriptionPasswordChangeEmailFrom()
	{
		return "«Изменение пароля Roblox» {fromEmailAddress}";
	}

	protected override string _GetTemplateForDescriptionPasswordChangeEmailSubject()
	{
		return "Сброс пароля Roblox";
	}

	/// <summary>
	/// Key: "Description.PasswordResetEmail.From"
	/// The "From" field for the password reset email
	/// English String: "{escapeLiteralStart}Roblox Password Reset{escapeLiteralEnd} {fromEmailAddress}"
	/// </summary>
	public override string DescriptionPasswordResetEmailFrom(string escapeLiteralStart, string escapeLiteralEnd, string fromEmailAddress)
	{
		return $"{escapeLiteralStart}Изменение пароля Roblox{escapeLiteralEnd} {fromEmailAddress}";
	}

	protected override string _GetTemplateForDescriptionPasswordResetEmailFrom()
	{
		return "{escapeLiteralStart}Изменение пароля Roblox{escapeLiteralEnd} {fromEmailAddress}";
	}

	/// <summary>
	/// Key: "Description.PasswordResetEmail.HtmlBody"
	/// This email is sent when a user requests a password reset.
	/// English String: "We have received a request to reset the password for your Roblox account: {emailOrUsername}{lineBreak}{lineBreak}If you submitted this request, please click the button below to proceed.{lineBreak}This button will be active for {passwordResetTicketHours} hours, {passwordResetTicketMinutes} minutes. If you do not wish to reset your password, please disregard this notice.{lineBreak}{lineBreak}{aTagWithStartHref}{resetPasswordUrl}{hrefEnd}{buttonStart}Reset Password{buttonEnd}{aTagEnd}"
	/// </summary>
	public override string DescriptionPasswordResetEmailHtmlBody(string emailOrUsername, string lineBreak, string passwordResetTicketHours, string passwordResetTicketMinutes, string aTagWithStartHref, string resetPasswordUrl, string hrefEnd, string buttonStart, string buttonEnd, string aTagEnd)
	{
		return $"Мы получили запрос на изменение вашего пароля для учетной записи Roblox: {emailOrUsername}{lineBreak}{lineBreak}Если вы действительно сделали этот запрос, пожалуйста, нажмите на кнопку ниже.{lineBreak}Эта кнопка будет активна в течение {passwordResetTicketHours} часов, {passwordResetTicketMinutes} минут. если вы не желаете изменить свой пароль, пожалуйста, игнорируйте это сообщение.{lineBreak}{lineBreak}{aTagWithStartHref}{resetPasswordUrl}{hrefEnd}{buttonStart}Изменить пароль{buttonEnd}{aTagEnd}";
	}

	protected override string _GetTemplateForDescriptionPasswordResetEmailHtmlBody()
	{
		return "Мы получили запрос на изменение вашего пароля для учетной записи Roblox: {emailOrUsername}{lineBreak}{lineBreak}Если вы действительно сделали этот запрос, пожалуйста, нажмите на кнопку ниже.{lineBreak}Эта кнопка будет активна в течение {passwordResetTicketHours} часов, {passwordResetTicketMinutes} минут. если вы не желаете изменить свой пароль, пожалуйста, игнорируйте это сообщение.{lineBreak}{lineBreak}{aTagWithStartHref}{resetPasswordUrl}{hrefEnd}{buttonStart}Изменить пароль{buttonEnd}{aTagEnd}";
	}

	/// <summary>
	/// Key: "Description.PasswordResetEmail.PlainBody"
	/// This email is sent when a user requests a password reset.
	/// English String: "We have received a request to reset the password for your Roblox account: {emailOrUsername}{lineBreak}{lineBreak}If you submitted this request, please click the link below or paste it into a web browser to proceed.{lineBreak}This link will be active for {passwordResetTicketHours} hours, {passwordResetTicketMinutes} minutes. If you do not wish to reset your password, please disregard this notice.{lineBreak}{lineBreak}{resetPasswordUrl}"
	/// </summary>
	public override string DescriptionPasswordResetEmailPlainBody(string emailOrUsername, string lineBreak, string passwordResetTicketHours, string passwordResetTicketMinutes, string resetPasswordUrl)
	{
		return $"Мы получили запрос на изменение вашего пароля для учетной записи Roblox: {emailOrUsername}{lineBreak}{lineBreak}Если вы действительно сделали этот запрос, пожалуйста, пройдите по ссылке ниже или скопируйте ее в браузер.{lineBreak}Эта ссылка будет активна в течение {passwordResetTicketHours} часов, {passwordResetTicketMinutes} минут. если вы не желаете изменить свой пароль, пожалуйста, игнорируйте это сообщение.{lineBreak}{lineBreak}{resetPasswordUrl}";
	}

	protected override string _GetTemplateForDescriptionPasswordResetEmailPlainBody()
	{
		return "Мы получили запрос на изменение вашего пароля для учетной записи Roblox: {emailOrUsername}{lineBreak}{lineBreak}Если вы действительно сделали этот запрос, пожалуйста, пройдите по ссылке ниже или скопируйте ее в браузер.{lineBreak}Эта ссылка будет активна в течение {passwordResetTicketHours} часов, {passwordResetTicketMinutes} минут. если вы не желаете изменить свой пароль, пожалуйста, игнорируйте это сообщение.{lineBreak}{lineBreak}{resetPasswordUrl}";
	}

	protected override string _GetTemplateForDescriptionPasswordResetEmailSubject()
	{
		return "Изменение пароля учетной записи Roblox";
	}

	protected override string _GetTemplateForDescriptionPhoneToResetPassword()
	{
		return "Введите номер телефона, чтобы сбросить пароль.";
	}

	protected override string _GetTemplateForDescriptionPhoneToRetriveUsername()
	{
		return "Введите номер телефона, чтобы восстановить свое имя пользователя.";
	}

	protected override string _GetTemplateForHeadingVerifyCode()
	{
		return "Подтвердить код";
	}

	protected override string _GetTemplateForHeadingVerifyPhone()
	{
		return "Проверка телефона";
	}

	protected override string _GetTemplateForHeadingForgetPasswordOrUsername()
	{
		return "Забыт пароль или имя пользователя";
	}

	protected override string _GetTemplateForLabelActionButtonYes()
	{
		return "Да";
	}

	protected override string _GetTemplateForLabelForgetMyPassword()
	{
		return "Пароль забыт";
	}

	protected override string _GetTemplateForLabelForgetMyUsername()
	{
		return "Имя пользователя забыто";
	}

	protected override string _GetTemplateForLabelInvalidEmail()
	{
		return "Недопустимый адрес эл. почты";
	}

	protected override string _GetTemplateForLabelInvalidPhoneNumber()
	{
		return "Недопустимый номер телефона";
	}

	protected override string _GetTemplateForLabelNeutralButtonOk()
	{
		return "ОК";
	}

	protected override string _GetTemplateForLabelPassword()
	{
		return "Пароль";
	}

	protected override string _GetTemplateForLabelResendCode()
	{
		return "Отправить код заново";
	}

	protected override string _GetTemplateForLabelSubmit()
	{
		return "Отправить";
	}

	protected override string _GetTemplateForLabelToolTipWhoCanFindMeByPhone()
	{
		return "Эта настройка позволяет указать, кто может найти вас по номеру вашего телефона.";
	}

	protected override string _GetTemplateForLabelUsername()
	{
		return "Имя пользователя";
	}

	protected override string _GetTemplateForLabelWhoCanFindMeByPhone()
	{
		return "Кто может найти меня по номеру телефона?";
	}

	/// <summary>
	/// Key: "Message.CantSendEmailWarning"
	/// English String: "If you did not give us a {styleStart}real email address{styleEnd} when you created your account, we cannot send you an email."
	/// </summary>
	public override string MessageCantSendEmailWarning(string styleStart, string styleEnd)
	{
		return $"Если вы не указали {styleStart}настоящий адрес эл. почты{styleEnd} при создании учетной записи, мы не сможем отправить вам сообщение.";
	}

	protected override string _GetTemplateForMessageCantSendEmailWarning()
	{
		return "Если вы не указали {styleStart}настоящий адрес эл. почты{styleEnd} при создании учетной записи, мы не сможем отправить вам сообщение.";
	}

	protected override string _GetTemplateForMessageDefaultError()
	{
		return "Произошла ошибка. Повторите попытку позже.";
	}

	protected override string _GetTemplateForMessageEmailForUsernameSuccessBody()
	{
		return "Если ваша эл. почта была ранее подтверждена в вашей учетной записи, то на ее адрес было выслано ваше имя пользователя.";
	}

	protected override string _GetTemplateForMessageEmailSuccessBody()
	{
		return "Если в вашей учетной записи была сохранена эл. почта, на нее были отправлены инструкции.";
	}

	protected override string _GetTemplateForMessageEmailSuccessTitle()
	{
		return "Сообщение отправлено";
	}

	protected override string _GetTemplateForMessageEnterCode()
	{
		return "Если ваш телефон был ранее подтвержден в вашей учетной записи, то на его номер был выслан код. Пожалуйста, введите его ниже.";
	}

	protected override string _GetTemplateForMessageEnterCodeSentToEmail()
	{
		return "Введите код, отправленный вам по электронной почте.";
	}

	protected override string _GetTemplateForMessagePhoneForUsernameSuccessBody()
	{
		return "СМС с вашим именем (именами) пользователя(-ей) было отправлено на телефонный номер, если он был подтвержден в вашей учетной записи.";
	}

	protected override string _GetTemplateForMessagePhoneForUsernameSuccessTitle()
	{
		return "СМС отправлено";
	}

	protected override string _GetTemplateForMessageAccountDoesNotHaveAnEmail()
	{
		return "К этой учетной записи не прикреплен адрес эл. почты";
	}

	protected override string _GetTemplateForMessageAccountNotFoundByEmail()
	{
		return "Учетная запись не найдена. Укажите другой адрес эл. почты.";
	}

	protected override string _GetTemplateForMessageAccountNotFoundByPhone()
	{
		return "Учетная запись не найдена. Укажите другой номер телефона.";
	}

	protected override string _GetTemplateForMessageAccountRecoveryUnknownError()
	{
		return "Ошибка системы. Учетную запись невозможно восстановить до этого состояния.";
	}

	protected override string _GetTemplateForMessageCaptchaError()
	{
		return "Нам необходимо убедиться, что вы – не робот!";
	}

	protected override string _GetTemplateForMessageCaptchaFailError()
	{
		return "Введенные вами слова не соответствуют изображению. Повторите попытку.";
	}

	protected override string _GetTemplateForMessageCredentialsError()
	{
		return "Неправильный пароль или имя пользователя. Проверьте еще раз и повторите попытку.";
	}

	protected override string _GetTemplateForMessageFloodCheckedError()
	{
		return "Слишком много попыток. Повторите попытку позже.";
	}

	protected override string _GetTemplateForMessageForgotPasswordFeatureDisabled()
	{
		return "Функция временно недоступна. Повторите попытку позже.";
	}

	protected override string _GetTemplateForMessageForgotPasswordSuccess()
	{
		return "Инструкции по входу отправлены вам по электронной почте";
	}

	protected override string _GetTemplateForMessageInvalidAccountStatus()
	{
		return "Состояние учетной записи запрещает сброс пароля";
	}

	protected override string _GetTemplateForMessageInvalidPassword()
	{
		return "Недопустимый пароль";
	}

	protected override string _GetTemplateForMessageInvalidTicket()
	{
		return "Не удалось загрузить этот билет безопасности.";
	}

	protected override string _GetTemplateForMessageInvalidUserNameOrEmail()
	{
		return "Недопустимое имя пользователя или несуществующий адрес эл. почты";
	}

	protected override string _GetTemplateForMessageMobileResetPasswordSuccess()
	{
		return "MobileResetPasswordSuccess";
	}

	protected override string _GetTemplateForMessageNoAccountsLinkedToEmail()
	{
		return "К этому адресу эл. почты не прикреплена учетная запись";
	}

	protected override string _GetTemplateForMessageOldUsernameError()
	{
		return "Похоже, вы указываете имя пользователя, которое было изменено. Войдите с новым именем пользователя.";
	}

	protected override string _GetTemplateForMessagePasswordCannotBeUsed()
	{
		return "К сожалению, этот пароль нельзя использовать.";
	}

	/// <summary>
	/// Key: "MessagePasswordResetTicketExpired"
	/// English String: "Sorry, password reset requests expire {expirationHour} hours, {expirationMinute} minutes after issuance. Try requesting another password reset ticket again."
	/// </summary>
	public override string MessagePasswordResetTicketExpired(string expirationHour, string expirationMinute)
	{
		return $"К сожалению, запросы на сброс пароля истекают через {expirationHour} ч. {expirationMinute} мин. после отправки. Запросите новый билет на сброс пароля.";
	}

	protected override string _GetTemplateForMessagePasswordResetTicketExpired()
	{
		return "К сожалению, запросы на сброс пароля истекают через {expirationHour} ч. {expirationMinute} мин. после отправки. Запросите новый билет на сброс пароля.";
	}

	protected override string _GetTemplateForMessagePasswordsDoNotMatch()
	{
		return "Пароли не совпадают";
	}

	protected override string _GetTemplateForMessageSamlUnauthenticated()
	{
		return "Необходимо войти в Roblox, чтобы завершить аутентификацию.";
	}

	protected override string _GetTemplateForMessageUnknownError()
	{
		return "Неизвестная ошибка";
	}

	protected override string _GetTemplateForMessageUnknownSystemError()
	{
		return "Ошибка системы. Вернитесь на экран входа.";
	}

	protected override string _GetTemplateForPlaceholderEmail()
	{
		return "Эл. почта";
	}

	/// <summary>
	/// Key: "Placeholder.EnterCode"
	/// English String: "Enter Code ({codeLength}-digit)"
	/// </summary>
	public override string PlaceholderEnterCode(string codeLength)
	{
		return $"Введите код (из {codeLength} цифр)";
	}

	protected override string _GetTemplateForPlaceholderEnterCode()
	{
		return "Введите код (из {codeLength} цифр)";
	}

	protected override string _GetTemplateForPlaceholderPhoneNumber()
	{
		return "Номер телефона";
	}

	protected override string _GetTemplateForResponsePasswordResetSuccess()
	{
		return "Пароль сброшен! Войдите в учетную запись повторно.";
	}

	protected override string _GetTemplateForResponseSuccess()
	{
		return "Успех";
	}

	protected override string _GetTemplateForResponseUpdatePasswordFlooded()
	{
		return "Слишком много попыток. Повторите попытку позже.";
	}

	protected override string _GetTemplateForResponseUpdatePasswordIncorrect()
	{
		return "Неправильный текущий пароль. Пароль не изменен.";
	}

	protected override string _GetTemplateForResponseUpdatePasswordInputMissing()
	{
		return "Требуется указать и подтвердить новый пароль";
	}

	protected override string _GetTemplateForResponseUpdatePasswordMismatch()
	{
		return "Данные в полях «Новый пароль» и «Подтверждение пароля» должны совпадать";
	}
}
