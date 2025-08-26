namespace Roblox.Platform.TranslationResources.Authentication {
    /// <summary>

/// This class overrides ResetPasswordResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ResetPasswordResources_es_es : ResetPasswordResources_en_us, IResetPasswordResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "Cancelar";

	/// <summary>
	/// Key: "Action.EmailToResetPassword"
	/// English String: "Use email to reset password"
	/// </summary>
	public override string ActionEmailToResetPassword => "Usar el correo electrÃ³nico para restablecer la contraseÃ±a";

	/// <summary>
	/// Key: "Action.EmailToRetriveUsername"
	/// English String: "Use email to retrieve username"
	/// </summary>
	public override string ActionEmailToRetriveUsername => "Usar el correo electrÃ³nico para recuperar el nombre de usuario";

	/// <summary>
	/// Key: "Action.Ok"
	/// OK
	/// English String: "OK"
	/// </summary>
	public override string ActionOk => "Aceptar";

	/// <summary>
	/// Key: "Action.PhoneToResetPassword"
	/// English String: "Use phone number to reset password"
	/// </summary>
	public override string ActionPhoneToResetPassword => "Usar el nÃºmero de telÃ©fono para restablecer la contraseÃ±a";

	/// <summary>
	/// Key: "Action.PhoneToRetriveUsername"
	/// English String: "Use phone number to retrieve username"
	/// </summary>
	public override string ActionPhoneToRetriveUsername => "Usar el nÃºmero de telÃ©fono para recuperar el nombre de usuario";

	/// <summary>
	/// Key: "Action.Verify"
	/// English String: "Verify"
	/// </summary>
	public override string ActionVerify => "Verificar";

	/// <summary>
	/// Key: "Description.EmailToResetPassword"
	/// English String: "Enter your email to reset your password."
	/// </summary>
	public override string DescriptionEmailToResetPassword => "Introduce tu correo electrÃ³nico para restablecer tu contraseÃ±a.";

	/// <summary>
	/// Key: "Description.EmailToRetriveUsername"
	/// English String: "Enter your email to retrieve your username."
	/// </summary>
	public override string DescriptionEmailToRetriveUsername => "Introduce tu correo electrÃ³nico para recuperar tu nombre de usuario.";

	/// <summary>
	/// Key: "Description.PasswordChangeEmail.Subject"
	/// email subject to change password
	/// English String: "Roblox Password Reset"
	/// </summary>
	public override string DescriptionPasswordChangeEmailSubject => "ContraseÃ±a de Roblox restablecida";

	/// <summary>
	/// Key: "Description.PasswordResetEmail.Subject"
	/// Subject for password reset email
	/// English String: "Roblox Account Password Reset"
	/// </summary>
	public override string DescriptionPasswordResetEmailSubject => "Restablecimiento de la contraseÃ±a para la cuenta de Roblox";

	/// <summary>
	/// Key: "Description.PhoneToResetPassword"
	/// English String: "Enter your phone number to reset your password."
	/// </summary>
	public override string DescriptionPhoneToResetPassword => "Introduce tu nÃºmero de telÃ©fono para restablecer tu contraseÃ±a.";

	/// <summary>
	/// Key: "Description.PhoneToRetriveUsername"
	/// English String: "Enter your phone number to retrieve your username."
	/// </summary>
	public override string DescriptionPhoneToRetriveUsername => "Introduce tu nÃºmero de telÃ©fono para recuperar tu nombre de usuario.";

	/// <summary>
	/// Key: "Heading.VerifyCode"
	/// verify code heading
	/// English String: "Verify Code"
	/// </summary>
	public override string HeadingVerifyCode => "Verificar cÃ³digo";

	/// <summary>
	/// Key: "Heading.VerifyPhone"
	/// English String: "Verify Phone"
	/// </summary>
	public override string HeadingVerifyPhone => "Verificar telÃ©fono";

	/// <summary>
	/// Key: "HeadingForgetPasswordOrUsername"
	/// English String: "Forgot Password or Username"
	/// </summary>
	public override string HeadingForgetPasswordOrUsername => "He olvidado la contraseÃ±a o el nombre de usuario.";

	/// <summary>
	/// Key: "Label.ActionButtonYes"
	/// button label
	/// English String: "Yes"
	/// </summary>
	public override string LabelActionButtonYes => "SÃ­";

	/// <summary>
	/// Key: "Label.ForgetMyPassword"
	/// English String: "Forgot My Password"
	/// </summary>
	public override string LabelForgetMyPassword => "He olvidado mi contraseÃ±a.";

	/// <summary>
	/// Key: "Label.ForgetMyUsername"
	/// English String: "Forgot My Username"
	/// </summary>
	public override string LabelForgetMyUsername => "He olvidado mi nombre de usuario.";

	/// <summary>
	/// Key: "Label.InvalidEmail"
	/// English String: "Invalid email"
	/// </summary>
	public override string LabelInvalidEmail => "Correo electrÃ³nico no vÃ¡lido";

	/// <summary>
	/// Key: "Label.InvalidPhoneNumber"
	/// English String: "Invalid phone number"
	/// </summary>
	public override string LabelInvalidPhoneNumber => "NÃºmero de telÃ©fono no vÃ¡lido";

	/// <summary>
	/// Key: "Label.NeutralButtonOk"
	/// ok button label
	/// English String: "OK"
	/// </summary>
	public override string LabelNeutralButtonOk => "Aceptar";

	/// <summary>
	/// Key: "Label.Password"
	/// label
	/// English String: "Password"
	/// </summary>
	public override string LabelPassword => "ContraseÃ±a";

	/// <summary>
	/// Key: "Label.ResendCode"
	/// English String: "Resend Code"
	/// </summary>
	public override string LabelResendCode => "Reenviar cÃ³digo";

	/// <summary>
	/// Key: "Label.Submit"
	/// English String: "Submit"
	/// </summary>
	public override string LabelSubmit => "Enviar";

	/// <summary>
	/// Key: "Label.ToolTip.WhoCanFindMeByPhone"
	/// English String: "This setting controls who can find you using the phone number you provided."
	/// </summary>
	public override string LabelToolTipWhoCanFindMeByPhone => "Este ajuste controla quiÃ©n puede encontrarte mediante el nÃºmero de telÃ©fono que has proporcionado.";

	/// <summary>
	/// Key: "Label.Username"
	/// English String: "Username"
	/// </summary>
	public override string LabelUsername => "Nombre de usuario";

	/// <summary>
	/// Key: "Label.WhoCanFindMeByPhone"
	/// English String: "Who can find me by my phone number?"
	/// </summary>
	public override string LabelWhoCanFindMeByPhone => "Â¿QuiÃ©n puede encontrarme por mi nÃºmero de telÃ©fono?";

	/// <summary>
	/// Key: "Message.DefaultError"
	/// English String: "An error occurred, try again later."
	/// </summary>
	public override string MessageDefaultError => "Se ha producido un error. IntÃ©ntalo de nuevo mÃ¡s tarde.";

	/// <summary>
	/// Key: "Message.EmailForUsernameSuccessBody"
	/// success message
	/// English String: "An email with your username(s) has been sent to you if the email was previously saved on your account."
	/// </summary>
	public override string MessageEmailForUsernameSuccessBody => "Se ha enviado un correo electrÃ³nico con tu nombre de usuario, siempre y cuando se haya guardado previamente esa direcciÃ³n en tu cuenta.";

	/// <summary>
	/// Key: "Message.EmailSuccessBody"
	/// English String: "An email with instructions has been sent to you if the email was previously saved on your account."
	/// </summary>
	public override string MessageEmailSuccessBody => "Se ha enviado un correo electrÃ³nico con instrucciones, siempre y cuando se haya guardado previamente esa direcciÃ³n en tu cuenta.";

	/// <summary>
	/// Key: "Message.EmailSuccessTitle"
	/// English String: "Email Sent"
	/// </summary>
	public override string MessageEmailSuccessTitle => "Correo electrÃ³nico enviado";

	/// <summary>
	/// Key: "Message.EnterCode"
	/// English String: "A code was sent to your phone if it was previously verified on your account. Please enter it below"
	/// </summary>
	public override string MessageEnterCode => "Se ha enviado un cÃ³digo a tu telÃ©fono, siempre y cuando ese nÃºmero se haya sido verificado previamente en tu cuenta. IngrÃ©salo aquÃ­ abajo";

	/// <summary>
	/// Key: "Message.EnterCodeSentToEmail"
	/// Enter the code we just sent to your email.
	/// English String: "Enter the code we just sent to your email."
	/// </summary>
	public override string MessageEnterCodeSentToEmail => "Introduce el cÃ³digo que te acabamos de enviar a tu correo electrÃ³nico.";

	/// <summary>
	/// Key: "Message.PhoneForUsernameSuccessBody"
	/// English String: "An SMS with your username(s) has been sent to you if the phone number was previously verified on your account."
	/// </summary>
	public override string MessagePhoneForUsernameSuccessBody => "Se ha enviado un SMS con los nombres de usuario a tu telÃ©fono, siempre y cuando ese nÃºmero se haya verificado previamente en tu cuenta.";

	/// <summary>
	/// Key: "Message.PhoneForUsernameSuccessTitle"
	/// English String: "SMS Sent"
	/// </summary>
	public override string MessagePhoneForUsernameSuccessTitle => "SMS enviado";

	/// <summary>
	/// Key: "MessageAccountDoesNotHaveAnEmail"
	/// English String: "There is no email linked to this account"
	/// </summary>
	public override string MessageAccountDoesNotHaveAnEmail => "No hay correo electrÃ³nico vinculado a esta cuenta.";

	/// <summary>
	/// Key: "MessageAccountNotFoundByEmail"
	/// No account found. Please use a different email.
	/// English String: "No account found. Please use a different email."
	/// </summary>
	public override string MessageAccountNotFoundByEmail => "No se ha encontrado la cuenta. Prueba a usar otro correo electrÃ³nico.";

	/// <summary>
	/// Key: "MessageAccountNotFoundByPhone"
	/// No account found. Please use a different phone number.
	/// English String: "No account found. Please use a different phone number."
	/// </summary>
	public override string MessageAccountNotFoundByPhone => "No se ha encontrado la cuenta. Prueba a usar otro nÃºmero de telÃ©fono.";

	/// <summary>
	/// Key: "MessageAccountRecoveryUnknownError"
	/// English String: "System error. Account could not be restored to this state."
	/// </summary>
	public override string MessageAccountRecoveryUnknownError => "Error del sistema. No se ha podido restaurar la cuenta a este estado.";

	/// <summary>
	/// Key: "MessageCaptchaError"
	/// English String: "We need to make sure you're not a robot!"
	/// </summary>
	public override string MessageCaptchaError => "Tenemos que asegurarnos de que no eres un robot.";

	/// <summary>
	/// Key: "MessageCaptchaFailError"
	/// English String: "The words you typed didn't match the picture. Please try again."
	/// </summary>
	public override string MessageCaptchaFailError => "Las palabras que has introducido no coinciden con la imagen. IntÃ©ntalo de nuevo.";

	/// <summary>
	/// Key: "MessageCredentialsError"
	/// English String: "Your username or password is incorrect. Please check them and try again."
	/// </summary>
	public override string MessageCredentialsError => "Tu nombre de usuario o tu contraseÃ±a son incorrectos. CompruÃ©balos y vuelve a intentarlo.";

	/// <summary>
	/// Key: "MessageFloodCheckedError"
	/// English String: "Too many attempts. Please try again later."
	/// </summary>
	public override string MessageFloodCheckedError => "Demasiados intentos. IntÃ©ntalo de nuevo mÃ¡s tarde.";

	/// <summary>
	/// Key: "MessageForgotPasswordFeatureDisabled"
	/// English String: "Feature temporarily disabled. Please try again later."
	/// </summary>
	public override string MessageForgotPasswordFeatureDisabled => "FunciÃ³n desactivada temporalmente. IntÃ©ntalo de nuevo mÃ¡s tarde.";

	/// <summary>
	/// Key: "MessageForgotPasswordSuccess"
	/// English String: "Check your email for login instructions"
	/// </summary>
	public override string MessageForgotPasswordSuccess => "Busca las instrucciones de inicio de sesiÃ³n en tu correo electrÃ³nico.";

	/// <summary>
	/// Key: "MessageInvalidAccountStatus"
	/// English String: "Account status prevents resetting password"
	/// </summary>
	public override string MessageInvalidAccountStatus => "El estado de la cuenta impide restablecer la contraseÃ±a.";

	/// <summary>
	/// Key: "MessageInvalidPassword"
	/// English String: "Invalid password"
	/// </summary>
	public override string MessageInvalidPassword => "ContraseÃ±a no vÃ¡lida";

	/// <summary>
	/// Key: "MessageInvalidTicket"
	/// English String: "We couldn't load this security ticket."
	/// </summary>
	public override string MessageInvalidTicket => "No hemos podido cargar este ticket de seguridad.";

	/// <summary>
	/// Key: "MessageInvalidUserNameOrEmail"
	/// English String: "Invalid username, or no email exists"
	/// </summary>
	public override string MessageInvalidUserNameOrEmail => "Nombre de usuario no vÃ¡lido o correo electrÃ³nico inexistente.";

	/// <summary>
	/// Key: "MessageMobileResetPasswordSuccess"
	/// English String: "MobileResetPasswordSuccess"
	/// </summary>
	public override string MessageMobileResetPasswordSuccess => "MobileResetPasswordSuccess";

	/// <summary>
	/// Key: "MessageNoAccountsLinkedToEmail"
	/// English String: "There are no accounts linked to this email address"
	/// </summary>
	public override string MessageNoAccountsLinkedToEmail => "No hay cuentas vinculadas a esta direcciÃ³n de correo electrÃ³nico.";

	/// <summary>
	/// Key: "MessageOldUsernameError"
	/// English String: "It looks like you are trying to log in with a username that has changed. Please log in with your new username."
	/// </summary>
	public override string MessageOldUsernameError => "Parece que intentas iniciar sesiÃ³n con un nombre de usuario que ha cambiado. Inicia sesiÃ³n con tu nuevo nombre de usuario.";

	/// <summary>
	/// Key: "MessagePasswordCannotBeUsed"
	/// English String: "Sorry, that password cannot be used."
	/// </summary>
	public override string MessagePasswordCannotBeUsed => "Lo sentimos, esa contraseÃ±a no se puede usar.";

	/// <summary>
	/// Key: "MessagePasswordsDoNotMatch"
	/// English String: "Passwords do not match"
	/// </summary>
	public override string MessagePasswordsDoNotMatch => "Las contraseÃ±as no coinciden.";

	/// <summary>
	/// Key: "MessageSamlUnauthenticated"
	/// English String: "You must log in to Roblox to finish authenticating."
	/// </summary>
	public override string MessageSamlUnauthenticated => "Debes iniciar sesiÃ³n en Roblox para completar la autenticaciÃ³n.";

	/// <summary>
	/// Key: "MessageUnknownError"
	/// English String: "Unknown Error"
	/// </summary>
	public override string MessageUnknownError => "Error desconocido";

	/// <summary>
	/// Key: "MessageUnknownSystemError"
	/// English String: "System error. Please return to login screen."
	/// </summary>
	public override string MessageUnknownSystemError => "Error del sistema. Regresa a la pantalla de inicio de sesiÃ³n.";

	/// <summary>
	/// Key: "Placeholder.Email"
	/// English String: "Email"
	/// </summary>
	public override string PlaceholderEmail => "Correo electrÃ³nico";

	/// <summary>
	/// Key: "Placeholder.PhoneNumber"
	/// English String: "Phone Number"
	/// </summary>
	public override string PlaceholderPhoneNumber => "NÃºmero de telÃ©fono";

	/// <summary>
	/// Key: "Response.PasswordResetSuccess"
	/// Password reset success! Please login again.
	/// English String: "Password reset success! Please login again."
	/// </summary>
	public override string ResponsePasswordResetSuccess => "La contraseÃ±a ha sido restablecida correctamente. Vuelve a iniciar sesiÃ³n.";

	/// <summary>
	/// Key: "Response.Success"
	/// English String: "Success"
	/// </summary>
	public override string ResponseSuccess => "Hecho";

	/// <summary>
	/// Key: "Response.UpdatePasswordFlooded"
	/// English String: "Too many attempts. Please try again later."
	/// </summary>
	public override string ResponseUpdatePasswordFlooded => "Demasiados intentos. IntÃ©ntalo de nuevo mÃ¡s tarde.";

	/// <summary>
	/// Key: "Response.UpdatePasswordIncorrect"
	/// English String: "Your current password is incorrect, the password was not changed."
	/// </summary>
	public override string ResponseUpdatePasswordIncorrect => "La contraseÃ±a actual es incorrecta. La contraseÃ±a no se ha modificado.";

	/// <summary>
	/// Key: "Response.UpdatePasswordInputMissing"
	/// English String: "Must include new password and confirm password"
	/// </summary>
	public override string ResponseUpdatePasswordInputMissing => "Debes incluir la contraseÃ±a nueva y la de confirmaciÃ³n.";

	/// <summary>
	/// Key: "Response.UpdatePasswordMismatch"
	/// English String: "Your new password and confirm password must match"
	/// </summary>
	public override string ResponseUpdatePasswordMismatch => "La contraseÃ±a nueva y la de confirmaciÃ³n deben coincidir.";

	public ResetPasswordResources_es_es(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "Cancelar";
	}

	protected override string _GetTemplateForActionEmailToResetPassword()
	{
		return "Usar el correo electrÃ³nico para restablecer la contraseÃ±a";
	}

	protected override string _GetTemplateForActionEmailToRetriveUsername()
	{
		return "Usar el correo electrÃ³nico para recuperar el nombre de usuario";
	}

	protected override string _GetTemplateForActionOk()
	{
		return "Aceptar";
	}

	protected override string _GetTemplateForActionPhoneToResetPassword()
	{
		return "Usar el nÃºmero de telÃ©fono para restablecer la contraseÃ±a";
	}

	protected override string _GetTemplateForActionPhoneToRetriveUsername()
	{
		return "Usar el nÃºmero de telÃ©fono para recuperar el nombre de usuario";
	}

	protected override string _GetTemplateForActionVerify()
	{
		return "Verificar";
	}

	/// <summary>
	/// Key: "Description.ChangePasswordEmail.HtmlBody1"
	/// email body for change password email
	/// English String: "We noticed that the password changed for your Roblox account: {userName}. If you didn't intend to change it, or you think someone else changed it by mistake, please click this link to undo the action:{lineBreak} {actionLink} {lineBreak}{lineBreak}If you are happy with your new Roblox password, you don't have to do anything! It's already set up. Please do not reply to this message. If you have any questions, please see the Roblox help page (https://www.roblox.com/help)."
	/// </summary>
	public override string DescriptionChangePasswordEmailHtmlBody1(string userName, string lineBreak, string actionLink)
	{
		return $"Hemos notado que se ha modificado la contraseÃ±a de Roblox de tu cuenta: {userName}. Si no era tu intenciÃ³n cambiarla o si crees que otra persona la ha modificado por error, haz clic aquÃ­ para deshacer esa acciÃ³n:{lineBreak}{actionLink} {lineBreak}{lineBreak}Si estÃ¡s a gusto con tu nueva contraseÃ±a de Roblox, no tienes que hacer nada; ya estÃ¡ configurada. No contestes a este mensaje. Si tienes preguntas, consulta la pÃ¡gina de ayuda de Roblox (https://www.roblox.com/help).";
	}

	protected override string _GetTemplateForDescriptionChangePasswordEmailHtmlBody1()
	{
		return "Hemos notado que se ha modificado la contraseÃ±a de Roblox de tu cuenta: {userName}. Si no era tu intenciÃ³n cambiarla o si crees que otra persona la ha modificado por error, haz clic aquÃ­ para deshacer esa acciÃ³n:{lineBreak}{actionLink} {lineBreak}{lineBreak}Si estÃ¡s a gusto con tu nueva contraseÃ±a de Roblox, no tienes que hacer nada; ya estÃ¡ configurada. No contestes a este mensaje. Si tienes preguntas, consulta la pÃ¡gina de ayuda de Roblox (https://www.roblox.com/help).";
	}

	protected override string _GetTemplateForDescriptionEmailToResetPassword()
	{
		return "Introduce tu correo electrÃ³nico para restablecer tu contraseÃ±a.";
	}

	protected override string _GetTemplateForDescriptionEmailToRetriveUsername()
	{
		return "Introduce tu correo electrÃ³nico para recuperar tu nombre de usuario.";
	}

	/// <summary>
	/// Key: "Description.PasswordChangeEmail.BodyPlainText"
	/// password reset plaintext email message
	/// English String: "We noticed that the password changed for your Roblox account: {userName}. If you didn't intend to change it, or you think someone else changed it by mistake, please click this link to undo the action:\n{urlWithTicket}\n\nIf you are happy with your new Roblox password, you don't have to do anything! It's already set up. Please do not reply to this message. If you have any questions, please see the Roblox help page (https://www.roblox.com/help)."
	/// </summary>
	public override string DescriptionPasswordChangeEmailBodyPlainText(string userName, string urlWithTicket)
	{
		return $"Hemos notado que se ha modificado la contraseÃ±a de Roblox de tu cuenta: {userName}. Si no era tu intenciÃ³n cambiarla o si crees que otra persona la ha modificado por error, haz clic aquÃ­ para deshacer esa acciÃ³n: \n{urlWithTicket}\n\nSi estÃ¡s a gusto con tu nueva contraseÃ±a de Roblox, no tienes que hacer nada; ya estÃ¡ configurada. No contestes a este mensaje. Si tienes preguntas, consulta la pÃ¡gina de ayuda de Roblox (https://www.roblox.com/help).";
	}

	protected override string _GetTemplateForDescriptionPasswordChangeEmailBodyPlainText()
	{
		return "Hemos notado que se ha modificado la contraseÃ±a de Roblox de tu cuenta: {userName}. Si no era tu intenciÃ³n cambiarla o si crees que otra persona la ha modificado por error, haz clic aquÃ­ para deshacer esa acciÃ³n: \n{urlWithTicket}\n\nSi estÃ¡s a gusto con tu nueva contraseÃ±a de Roblox, no tienes que hacer nada; ya estÃ¡ configurada. No contestes a este mensaje. Si tienes preguntas, consulta la pÃ¡gina de ayuda de Roblox (https://www.roblox.com/help).";
	}

	/// <summary>
	/// Key: "Description.PasswordChangeEmail.From"
	/// name of the sender as shown in from field of the email
	/// English String: "\"Roblox Password Reset\" {fromEmailAddress}"
	/// </summary>
	public override string DescriptionPasswordChangeEmailFrom(string fromEmailAddress)
	{
		return $"\"ContraseÃ±a de Roblox restablecida\" {fromEmailAddress}";
	}

	protected override string _GetTemplateForDescriptionPasswordChangeEmailFrom()
	{
		return "\"ContraseÃ±a de Roblox restablecida\" {fromEmailAddress}";
	}

	protected override string _GetTemplateForDescriptionPasswordChangeEmailSubject()
	{
		return "ContraseÃ±a de Roblox restablecida";
	}

	/// <summary>
	/// Key: "Description.PasswordResetEmail.From"
	/// The "From" field for the password reset email
	/// English String: "{escapeLiteralStart}Roblox Password Reset{escapeLiteralEnd} {fromEmailAddress}"
	/// </summary>
	public override string DescriptionPasswordResetEmailFrom(string escapeLiteralStart, string escapeLiteralEnd, string fromEmailAddress)
	{
		return $"{escapeLiteralStart}Restablecimiento de contraseÃ±a de Roblox{escapeLiteralEnd} {fromEmailAddress}";
	}

	protected override string _GetTemplateForDescriptionPasswordResetEmailFrom()
	{
		return "{escapeLiteralStart}Restablecimiento de contraseÃ±a de Roblox{escapeLiteralEnd} {fromEmailAddress}";
	}

	/// <summary>
	/// Key: "Description.PasswordResetEmail.HtmlBody"
	/// This email is sent when a user requests a password reset.
	/// English String: "We have received a request to reset the password for your Roblox account: {emailOrUsername}{lineBreak}{lineBreak}If you submitted this request, please click the button below to proceed.{lineBreak}This button will be active for {passwordResetTicketHours} hours, {passwordResetTicketMinutes} minutes. If you do not wish to reset your password, please disregard this notice.{lineBreak}{lineBreak}{aTagWithStartHref}{resetPasswordUrl}{hrefEnd}{buttonStart}Reset Password{buttonEnd}{aTagEnd}"
	/// </summary>
	public override string DescriptionPasswordResetEmailHtmlBody(string emailOrUsername, string lineBreak, string passwordResetTicketHours, string passwordResetTicketMinutes, string aTagWithStartHref, string resetPasswordUrl, string hrefEnd, string buttonStart, string buttonEnd, string aTagEnd)
	{
		return $"Hemos recibido una solicitud para cambiar la contraseÃ±a de tu cuenta de Roblox: {emailOrUsername}{lineBreak}{lineBreak}Si enviaste la solicitud, haz clic en el siguiente enlace.{lineBreak}Este enlace estarÃ¡ activo durante {passwordResetTicketHours} horas, {passwordResetTicketMinutes} minutos. Si no quieres restablecer la contraseÃ±a, ignora este aviso.{lineBreak}{lineBreak}{aTagWithStartHref}{resetPasswordUrl}{hrefEnd}{buttonStart}Restablecer la contraseÃ±a{buttonEnd}{aTagEnd}";
	}

	protected override string _GetTemplateForDescriptionPasswordResetEmailHtmlBody()
	{
		return "Hemos recibido una solicitud para cambiar la contraseÃ±a de tu cuenta de Roblox: {emailOrUsername}{lineBreak}{lineBreak}Si enviaste la solicitud, haz clic en el siguiente enlace.{lineBreak}Este enlace estarÃ¡ activo durante {passwordResetTicketHours} horas, {passwordResetTicketMinutes} minutos. Si no quieres restablecer la contraseÃ±a, ignora este aviso.{lineBreak}{lineBreak}{aTagWithStartHref}{resetPasswordUrl}{hrefEnd}{buttonStart}Restablecer la contraseÃ±a{buttonEnd}{aTagEnd}";
	}

	/// <summary>
	/// Key: "Description.PasswordResetEmail.PlainBody"
	/// This email is sent when a user requests a password reset.
	/// English String: "We have received a request to reset the password for your Roblox account: {emailOrUsername}{lineBreak}{lineBreak}If you submitted this request, please click the link below or paste it into a web browser to proceed.{lineBreak}This link will be active for {passwordResetTicketHours} hours, {passwordResetTicketMinutes} minutes. If you do not wish to reset your password, please disregard this notice.{lineBreak}{lineBreak}{resetPasswordUrl}"
	/// </summary>
	public override string DescriptionPasswordResetEmailPlainBody(string emailOrUsername, string lineBreak, string passwordResetTicketHours, string passwordResetTicketMinutes, string resetPasswordUrl)
	{
		return $"Hemos recibido una solicitud para cambiar la contraseÃ±a de tu cuenta de Roblox: {emailOrUsername}{lineBreak}{lineBreak}Si enviaste la solicitud, haz clic en el siguiente enlace o pÃ©galo en un navegador para continuar.{lineBreak}Este enlace estarÃ¡ activo durante {passwordResetTicketHours} horas, {passwordResetTicketMinutes} minutos. Si no quieres restablecer la contraseÃ±a, ignora este aviso.{lineBreak}{lineBreak}{resetPasswordUrl}";
	}

	protected override string _GetTemplateForDescriptionPasswordResetEmailPlainBody()
	{
		return "Hemos recibido una solicitud para cambiar la contraseÃ±a de tu cuenta de Roblox: {emailOrUsername}{lineBreak}{lineBreak}Si enviaste la solicitud, haz clic en el siguiente enlace o pÃ©galo en un navegador para continuar.{lineBreak}Este enlace estarÃ¡ activo durante {passwordResetTicketHours} horas, {passwordResetTicketMinutes} minutos. Si no quieres restablecer la contraseÃ±a, ignora este aviso.{lineBreak}{lineBreak}{resetPasswordUrl}";
	}

	protected override string _GetTemplateForDescriptionPasswordResetEmailSubject()
	{
		return "Restablecimiento de la contraseÃ±a para la cuenta de Roblox";
	}

	protected override string _GetTemplateForDescriptionPhoneToResetPassword()
	{
		return "Introduce tu nÃºmero de telÃ©fono para restablecer tu contraseÃ±a.";
	}

	protected override string _GetTemplateForDescriptionPhoneToRetriveUsername()
	{
		return "Introduce tu nÃºmero de telÃ©fono para recuperar tu nombre de usuario.";
	}

	protected override string _GetTemplateForHeadingVerifyCode()
	{
		return "Verificar cÃ³digo";
	}

	protected override string _GetTemplateForHeadingVerifyPhone()
	{
		return "Verificar telÃ©fono";
	}

	protected override string _GetTemplateForHeadingForgetPasswordOrUsername()
	{
		return "He olvidado la contraseÃ±a o el nombre de usuario.";
	}

	protected override string _GetTemplateForLabelActionButtonYes()
	{
		return "SÃ­";
	}

	protected override string _GetTemplateForLabelForgetMyPassword()
	{
		return "He olvidado mi contraseÃ±a.";
	}

	protected override string _GetTemplateForLabelForgetMyUsername()
	{
		return "He olvidado mi nombre de usuario.";
	}

	protected override string _GetTemplateForLabelInvalidEmail()
	{
		return "Correo electrÃ³nico no vÃ¡lido";
	}

	protected override string _GetTemplateForLabelInvalidPhoneNumber()
	{
		return "NÃºmero de telÃ©fono no vÃ¡lido";
	}

	protected override string _GetTemplateForLabelNeutralButtonOk()
	{
		return "Aceptar";
	}

	protected override string _GetTemplateForLabelPassword()
	{
		return "ContraseÃ±a";
	}

	protected override string _GetTemplateForLabelResendCode()
	{
		return "Reenviar cÃ³digo";
	}

	protected override string _GetTemplateForLabelSubmit()
	{
		return "Enviar";
	}

	protected override string _GetTemplateForLabelToolTipWhoCanFindMeByPhone()
	{
		return "Este ajuste controla quiÃ©n puede encontrarte mediante el nÃºmero de telÃ©fono que has proporcionado.";
	}

	protected override string _GetTemplateForLabelUsername()
	{
		return "Nombre de usuario";
	}

	protected override string _GetTemplateForLabelWhoCanFindMeByPhone()
	{
		return "Â¿QuiÃ©n puede encontrarme por mi nÃºmero de telÃ©fono?";
	}

	/// <summary>
	/// Key: "Message.CantSendEmailWarning"
	/// English String: "If you did not give us a {styleStart}real email address{styleEnd} when you created your account, we cannot send you an email."
	/// </summary>
	public override string MessageCantSendEmailWarning(string styleStart, string styleEnd)
	{
		return $"Si no nos diste una {styleStart}direcciÃ³n de correo electrÃ³nico autÃ©ntica{styleEnd} cuando creaste la cuenta, no podemos enviarte un correo electrÃ³nico.";
	}

	protected override string _GetTemplateForMessageCantSendEmailWarning()
	{
		return "Si no nos diste una {styleStart}direcciÃ³n de correo electrÃ³nico autÃ©ntica{styleEnd} cuando creaste la cuenta, no podemos enviarte un correo electrÃ³nico.";
	}

	protected override string _GetTemplateForMessageDefaultError()
	{
		return "Se ha producido un error. IntÃ©ntalo de nuevo mÃ¡s tarde.";
	}

	protected override string _GetTemplateForMessageEmailForUsernameSuccessBody()
	{
		return "Se ha enviado un correo electrÃ³nico con tu nombre de usuario, siempre y cuando se haya guardado previamente esa direcciÃ³n en tu cuenta.";
	}

	protected override string _GetTemplateForMessageEmailSuccessBody()
	{
		return "Se ha enviado un correo electrÃ³nico con instrucciones, siempre y cuando se haya guardado previamente esa direcciÃ³n en tu cuenta.";
	}

	protected override string _GetTemplateForMessageEmailSuccessTitle()
	{
		return "Correo electrÃ³nico enviado";
	}

	protected override string _GetTemplateForMessageEnterCode()
	{
		return "Se ha enviado un cÃ³digo a tu telÃ©fono, siempre y cuando ese nÃºmero se haya sido verificado previamente en tu cuenta. IngrÃ©salo aquÃ­ abajo";
	}

	protected override string _GetTemplateForMessageEnterCodeSentToEmail()
	{
		return "Introduce el cÃ³digo que te acabamos de enviar a tu correo electrÃ³nico.";
	}

	protected override string _GetTemplateForMessagePhoneForUsernameSuccessBody()
	{
		return "Se ha enviado un SMS con los nombres de usuario a tu telÃ©fono, siempre y cuando ese nÃºmero se haya verificado previamente en tu cuenta.";
	}

	protected override string _GetTemplateForMessagePhoneForUsernameSuccessTitle()
	{
		return "SMS enviado";
	}

	protected override string _GetTemplateForMessageAccountDoesNotHaveAnEmail()
	{
		return "No hay correo electrÃ³nico vinculado a esta cuenta.";
	}

	protected override string _GetTemplateForMessageAccountNotFoundByEmail()
	{
		return "No se ha encontrado la cuenta. Prueba a usar otro correo electrÃ³nico.";
	}

	protected override string _GetTemplateForMessageAccountNotFoundByPhone()
	{
		return "No se ha encontrado la cuenta. Prueba a usar otro nÃºmero de telÃ©fono.";
	}

	protected override string _GetTemplateForMessageAccountRecoveryUnknownError()
	{
		return "Error del sistema. No se ha podido restaurar la cuenta a este estado.";
	}

	protected override string _GetTemplateForMessageCaptchaError()
	{
		return "Tenemos que asegurarnos de que no eres un robot.";
	}

	protected override string _GetTemplateForMessageCaptchaFailError()
	{
		return "Las palabras que has introducido no coinciden con la imagen. IntÃ©ntalo de nuevo.";
	}

	protected override string _GetTemplateForMessageCredentialsError()
	{
		return "Tu nombre de usuario o tu contraseÃ±a son incorrectos. CompruÃ©balos y vuelve a intentarlo.";
	}

	protected override string _GetTemplateForMessageFloodCheckedError()
	{
		return "Demasiados intentos. IntÃ©ntalo de nuevo mÃ¡s tarde.";
	}

	protected override string _GetTemplateForMessageForgotPasswordFeatureDisabled()
	{
		return "FunciÃ³n desactivada temporalmente. IntÃ©ntalo de nuevo mÃ¡s tarde.";
	}

	protected override string _GetTemplateForMessageForgotPasswordSuccess()
	{
		return "Busca las instrucciones de inicio de sesiÃ³n en tu correo electrÃ³nico.";
	}

	protected override string _GetTemplateForMessageInvalidAccountStatus()
	{
		return "El estado de la cuenta impide restablecer la contraseÃ±a.";
	}

	protected override string _GetTemplateForMessageInvalidPassword()
	{
		return "ContraseÃ±a no vÃ¡lida";
	}

	protected override string _GetTemplateForMessageInvalidTicket()
	{
		return "No hemos podido cargar este ticket de seguridad.";
	}

	protected override string _GetTemplateForMessageInvalidUserNameOrEmail()
	{
		return "Nombre de usuario no vÃ¡lido o correo electrÃ³nico inexistente.";
	}

	protected override string _GetTemplateForMessageMobileResetPasswordSuccess()
	{
		return "MobileResetPasswordSuccess";
	}

	protected override string _GetTemplateForMessageNoAccountsLinkedToEmail()
	{
		return "No hay cuentas vinculadas a esta direcciÃ³n de correo electrÃ³nico.";
	}

	protected override string _GetTemplateForMessageOldUsernameError()
	{
		return "Parece que intentas iniciar sesiÃ³n con un nombre de usuario que ha cambiado. Inicia sesiÃ³n con tu nuevo nombre de usuario.";
	}

	protected override string _GetTemplateForMessagePasswordCannotBeUsed()
	{
		return "Lo sentimos, esa contraseÃ±a no se puede usar.";
	}

	/// <summary>
	/// Key: "MessagePasswordResetTicketExpired"
	/// English String: "Sorry, password reset requests expire {expirationHour} hours, {expirationMinute} minutes after issuance. Try requesting another password reset ticket again."
	/// </summary>
	public override string MessagePasswordResetTicketExpired(string expirationHour, string expirationMinute)
	{
		return $"Lo sentimos. Las solicitudes de restablecimiento de contraseÃ±a caducan {expirationHour} horas, {expirationMinute} minutos despuÃ©s de expedirse. Intenta solicitar otro ticket de restablecimiento de contraseÃ±a.";
	}

	protected override string _GetTemplateForMessagePasswordResetTicketExpired()
	{
		return "Lo sentimos. Las solicitudes de restablecimiento de contraseÃ±a caducan {expirationHour} horas, {expirationMinute} minutos despuÃ©s de expedirse. Intenta solicitar otro ticket de restablecimiento de contraseÃ±a.";
	}

	protected override string _GetTemplateForMessagePasswordsDoNotMatch()
	{
		return "Las contraseÃ±as no coinciden.";
	}

	protected override string _GetTemplateForMessageSamlUnauthenticated()
	{
		return "Debes iniciar sesiÃ³n en Roblox para completar la autenticaciÃ³n.";
	}

	protected override string _GetTemplateForMessageUnknownError()
	{
		return "Error desconocido";
	}

	protected override string _GetTemplateForMessageUnknownSystemError()
	{
		return "Error del sistema. Regresa a la pantalla de inicio de sesiÃ³n.";
	}

	protected override string _GetTemplateForPlaceholderEmail()
	{
		return "Correo electrÃ³nico";
	}

	/// <summary>
	/// Key: "Placeholder.EnterCode"
	/// English String: "Enter Code ({codeLength}-digit)"
	/// </summary>
	public override string PlaceholderEnterCode(string codeLength)
	{
		return $"Introduce el cÃ³digo ({codeLength} dÃ­gitos)";
	}

	protected override string _GetTemplateForPlaceholderEnterCode()
	{
		return "Introduce el cÃ³digo ({codeLength} dÃ­gitos)";
	}

	protected override string _GetTemplateForPlaceholderPhoneNumber()
	{
		return "NÃºmero de telÃ©fono";
	}

	protected override string _GetTemplateForResponsePasswordResetSuccess()
	{
		return "La contraseÃ±a ha sido restablecida correctamente. Vuelve a iniciar sesiÃ³n.";
	}

	protected override string _GetTemplateForResponseSuccess()
	{
		return "Hecho";
	}

	protected override string _GetTemplateForResponseUpdatePasswordFlooded()
	{
		return "Demasiados intentos. IntÃ©ntalo de nuevo mÃ¡s tarde.";
	}

	protected override string _GetTemplateForResponseUpdatePasswordIncorrect()
	{
		return "La contraseÃ±a actual es incorrecta. La contraseÃ±a no se ha modificado.";
	}

	protected override string _GetTemplateForResponseUpdatePasswordInputMissing()
	{
		return "Debes incluir la contraseÃ±a nueva y la de confirmaciÃ³n.";
	}

	protected override string _GetTemplateForResponseUpdatePasswordMismatch()
	{
		return "La contraseÃ±a nueva y la de confirmaciÃ³n deben coincidir.";
	}
}


}
