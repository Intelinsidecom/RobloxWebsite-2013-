namespace Roblox.TranslationResources.Authentication;

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
	public override string ActionEmailToResetPassword => "Usar el correo electrónico para restablecer la contraseña";

	/// <summary>
	/// Key: "Action.EmailToRetriveUsername"
	/// English String: "Use email to retrieve username"
	/// </summary>
	public override string ActionEmailToRetriveUsername => "Usar el correo electrónico para recuperar el nombre de usuario";

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
	public override string ActionPhoneToResetPassword => "Usar el número de teléfono para restablecer la contraseña";

	/// <summary>
	/// Key: "Action.PhoneToRetriveUsername"
	/// English String: "Use phone number to retrieve username"
	/// </summary>
	public override string ActionPhoneToRetriveUsername => "Usar el número de teléfono para recuperar el nombre de usuario";

	/// <summary>
	/// Key: "Action.Verify"
	/// English String: "Verify"
	/// </summary>
	public override string ActionVerify => "Verificar";

	/// <summary>
	/// Key: "Description.EmailToResetPassword"
	/// English String: "Enter your email to reset your password."
	/// </summary>
	public override string DescriptionEmailToResetPassword => "Introduce tu correo electrónico para restablecer tu contraseña.";

	/// <summary>
	/// Key: "Description.EmailToRetriveUsername"
	/// English String: "Enter your email to retrieve your username."
	/// </summary>
	public override string DescriptionEmailToRetriveUsername => "Introduce tu correo electrónico para recuperar tu nombre de usuario.";

	/// <summary>
	/// Key: "Description.PasswordChangeEmail.Subject"
	/// email subject to change password
	/// English String: "Roblox Password Reset"
	/// </summary>
	public override string DescriptionPasswordChangeEmailSubject => "Contraseña de Roblox restablecida";

	/// <summary>
	/// Key: "Description.PasswordResetEmail.Subject"
	/// Subject for password reset email
	/// English String: "Roblox Account Password Reset"
	/// </summary>
	public override string DescriptionPasswordResetEmailSubject => "Restablecimiento de la contraseña para la cuenta de Roblox";

	/// <summary>
	/// Key: "Description.PhoneToResetPassword"
	/// English String: "Enter your phone number to reset your password."
	/// </summary>
	public override string DescriptionPhoneToResetPassword => "Introduce tu número de teléfono para restablecer tu contraseña.";

	/// <summary>
	/// Key: "Description.PhoneToRetriveUsername"
	/// English String: "Enter your phone number to retrieve your username."
	/// </summary>
	public override string DescriptionPhoneToRetriveUsername => "Introduce tu número de teléfono para recuperar tu nombre de usuario.";

	/// <summary>
	/// Key: "Heading.VerifyCode"
	/// verify code heading
	/// English String: "Verify Code"
	/// </summary>
	public override string HeadingVerifyCode => "Verificar código";

	/// <summary>
	/// Key: "Heading.VerifyPhone"
	/// English String: "Verify Phone"
	/// </summary>
	public override string HeadingVerifyPhone => "Verificar teléfono";

	/// <summary>
	/// Key: "HeadingForgetPasswordOrUsername"
	/// English String: "Forgot Password or Username"
	/// </summary>
	public override string HeadingForgetPasswordOrUsername => "He olvidado la contraseña o el nombre de usuario.";

	/// <summary>
	/// Key: "Label.ActionButtonYes"
	/// button label
	/// English String: "Yes"
	/// </summary>
	public override string LabelActionButtonYes => "Sí";

	/// <summary>
	/// Key: "Label.ForgetMyPassword"
	/// English String: "Forgot My Password"
	/// </summary>
	public override string LabelForgetMyPassword => "He olvidado mi contraseña.";

	/// <summary>
	/// Key: "Label.ForgetMyUsername"
	/// English String: "Forgot My Username"
	/// </summary>
	public override string LabelForgetMyUsername => "He olvidado mi nombre de usuario.";

	/// <summary>
	/// Key: "Label.InvalidEmail"
	/// English String: "Invalid email"
	/// </summary>
	public override string LabelInvalidEmail => "Correo electrónico no válido";

	/// <summary>
	/// Key: "Label.InvalidPhoneNumber"
	/// English String: "Invalid phone number"
	/// </summary>
	public override string LabelInvalidPhoneNumber => "Número de teléfono no válido";

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
	public override string LabelPassword => "Contraseña";

	/// <summary>
	/// Key: "Label.ResendCode"
	/// English String: "Resend Code"
	/// </summary>
	public override string LabelResendCode => "Reenviar código";

	/// <summary>
	/// Key: "Label.Submit"
	/// English String: "Submit"
	/// </summary>
	public override string LabelSubmit => "Enviar";

	/// <summary>
	/// Key: "Label.ToolTip.WhoCanFindMeByPhone"
	/// English String: "This setting controls who can find you using the phone number you provided."
	/// </summary>
	public override string LabelToolTipWhoCanFindMeByPhone => "Este ajuste controla quién puede encontrarte mediante el número de teléfono que has proporcionado.";

	/// <summary>
	/// Key: "Label.Username"
	/// English String: "Username"
	/// </summary>
	public override string LabelUsername => "Nombre de usuario";

	/// <summary>
	/// Key: "Label.WhoCanFindMeByPhone"
	/// English String: "Who can find me by my phone number?"
	/// </summary>
	public override string LabelWhoCanFindMeByPhone => "¿Quién puede encontrarme por mi número de teléfono?";

	/// <summary>
	/// Key: "Message.DefaultError"
	/// English String: "An error occurred, try again later."
	/// </summary>
	public override string MessageDefaultError => "Se ha producido un error. Inténtalo de nuevo más tarde.";

	/// <summary>
	/// Key: "Message.EmailForUsernameSuccessBody"
	/// success message
	/// English String: "An email with your username(s) has been sent to you if the email was previously saved on your account."
	/// </summary>
	public override string MessageEmailForUsernameSuccessBody => "Se ha enviado un correo electrónico con tu nombre de usuario, siempre y cuando se haya guardado previamente esa dirección en tu cuenta.";

	/// <summary>
	/// Key: "Message.EmailSuccessBody"
	/// English String: "An email with instructions has been sent to you if the email was previously saved on your account."
	/// </summary>
	public override string MessageEmailSuccessBody => "Se ha enviado un correo electrónico con instrucciones, siempre y cuando se haya guardado previamente esa dirección en tu cuenta.";

	/// <summary>
	/// Key: "Message.EmailSuccessTitle"
	/// English String: "Email Sent"
	/// </summary>
	public override string MessageEmailSuccessTitle => "Correo electrónico enviado";

	/// <summary>
	/// Key: "Message.EnterCode"
	/// English String: "A code was sent to your phone if it was previously verified on your account. Please enter it below"
	/// </summary>
	public override string MessageEnterCode => "Se ha enviado un código a tu teléfono, siempre y cuando ese número se haya sido verificado previamente en tu cuenta. Ingrésalo aquí abajo";

	/// <summary>
	/// Key: "Message.EnterCodeSentToEmail"
	/// Enter the code we just sent to your email.
	/// English String: "Enter the code we just sent to your email."
	/// </summary>
	public override string MessageEnterCodeSentToEmail => "Introduce el código que te acabamos de enviar a tu correo electrónico.";

	/// <summary>
	/// Key: "Message.PhoneForUsernameSuccessBody"
	/// English String: "An SMS with your username(s) has been sent to you if the phone number was previously verified on your account."
	/// </summary>
	public override string MessagePhoneForUsernameSuccessBody => "Se ha enviado un SMS con los nombres de usuario a tu teléfono, siempre y cuando ese número se haya verificado previamente en tu cuenta.";

	/// <summary>
	/// Key: "Message.PhoneForUsernameSuccessTitle"
	/// English String: "SMS Sent"
	/// </summary>
	public override string MessagePhoneForUsernameSuccessTitle => "SMS enviado";

	/// <summary>
	/// Key: "MessageAccountDoesNotHaveAnEmail"
	/// English String: "There is no email linked to this account"
	/// </summary>
	public override string MessageAccountDoesNotHaveAnEmail => "No hay correo electrónico vinculado a esta cuenta.";

	/// <summary>
	/// Key: "MessageAccountNotFoundByEmail"
	/// No account found. Please use a different email.
	/// English String: "No account found. Please use a different email."
	/// </summary>
	public override string MessageAccountNotFoundByEmail => "No se ha encontrado la cuenta. Prueba a usar otro correo electrónico.";

	/// <summary>
	/// Key: "MessageAccountNotFoundByPhone"
	/// No account found. Please use a different phone number.
	/// English String: "No account found. Please use a different phone number."
	/// </summary>
	public override string MessageAccountNotFoundByPhone => "No se ha encontrado la cuenta. Prueba a usar otro número de teléfono.";

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
	public override string MessageCaptchaFailError => "Las palabras que has introducido no coinciden con la imagen. Inténtalo de nuevo.";

	/// <summary>
	/// Key: "MessageCredentialsError"
	/// English String: "Your username or password is incorrect. Please check them and try again."
	/// </summary>
	public override string MessageCredentialsError => "Tu nombre de usuario o tu contraseña son incorrectos. Compruébalos y vuelve a intentarlo.";

	/// <summary>
	/// Key: "MessageFloodCheckedError"
	/// English String: "Too many attempts. Please try again later."
	/// </summary>
	public override string MessageFloodCheckedError => "Demasiados intentos. Inténtalo de nuevo más tarde.";

	/// <summary>
	/// Key: "MessageForgotPasswordFeatureDisabled"
	/// English String: "Feature temporarily disabled. Please try again later."
	/// </summary>
	public override string MessageForgotPasswordFeatureDisabled => "Función desactivada temporalmente. Inténtalo de nuevo más tarde.";

	/// <summary>
	/// Key: "MessageForgotPasswordSuccess"
	/// English String: "Check your email for login instructions"
	/// </summary>
	public override string MessageForgotPasswordSuccess => "Busca las instrucciones de inicio de sesión en tu correo electrónico.";

	/// <summary>
	/// Key: "MessageInvalidAccountStatus"
	/// English String: "Account status prevents resetting password"
	/// </summary>
	public override string MessageInvalidAccountStatus => "El estado de la cuenta impide restablecer la contraseña.";

	/// <summary>
	/// Key: "MessageInvalidPassword"
	/// English String: "Invalid password"
	/// </summary>
	public override string MessageInvalidPassword => "Contraseña no válida";

	/// <summary>
	/// Key: "MessageInvalidTicket"
	/// English String: "We couldn't load this security ticket."
	/// </summary>
	public override string MessageInvalidTicket => "No hemos podido cargar este ticket de seguridad.";

	/// <summary>
	/// Key: "MessageInvalidUserNameOrEmail"
	/// English String: "Invalid username, or no email exists"
	/// </summary>
	public override string MessageInvalidUserNameOrEmail => "Nombre de usuario no válido o correo electrónico inexistente.";

	/// <summary>
	/// Key: "MessageMobileResetPasswordSuccess"
	/// English String: "MobileResetPasswordSuccess"
	/// </summary>
	public override string MessageMobileResetPasswordSuccess => "MobileResetPasswordSuccess";

	/// <summary>
	/// Key: "MessageNoAccountsLinkedToEmail"
	/// English String: "There are no accounts linked to this email address"
	/// </summary>
	public override string MessageNoAccountsLinkedToEmail => "No hay cuentas vinculadas a esta dirección de correo electrónico.";

	/// <summary>
	/// Key: "MessageOldUsernameError"
	/// English String: "It looks like you are trying to log in with a username that has changed. Please log in with your new username."
	/// </summary>
	public override string MessageOldUsernameError => "Parece que intentas iniciar sesión con un nombre de usuario que ha cambiado. Inicia sesión con tu nuevo nombre de usuario.";

	/// <summary>
	/// Key: "MessagePasswordCannotBeUsed"
	/// English String: "Sorry, that password cannot be used."
	/// </summary>
	public override string MessagePasswordCannotBeUsed => "Lo sentimos, esa contraseña no se puede usar.";

	/// <summary>
	/// Key: "MessagePasswordsDoNotMatch"
	/// English String: "Passwords do not match"
	/// </summary>
	public override string MessagePasswordsDoNotMatch => "Las contraseñas no coinciden.";

	/// <summary>
	/// Key: "MessageSamlUnauthenticated"
	/// English String: "You must log in to Roblox to finish authenticating."
	/// </summary>
	public override string MessageSamlUnauthenticated => "Debes iniciar sesión en Roblox para completar la autenticación.";

	/// <summary>
	/// Key: "MessageUnknownError"
	/// English String: "Unknown Error"
	/// </summary>
	public override string MessageUnknownError => "Error desconocido";

	/// <summary>
	/// Key: "MessageUnknownSystemError"
	/// English String: "System error. Please return to login screen."
	/// </summary>
	public override string MessageUnknownSystemError => "Error del sistema. Regresa a la pantalla de inicio de sesión.";

	/// <summary>
	/// Key: "Placeholder.Email"
	/// English String: "Email"
	/// </summary>
	public override string PlaceholderEmail => "Correo electrónico";

	/// <summary>
	/// Key: "Placeholder.PhoneNumber"
	/// English String: "Phone Number"
	/// </summary>
	public override string PlaceholderPhoneNumber => "Número de teléfono";

	/// <summary>
	/// Key: "Response.PasswordResetSuccess"
	/// Password reset success! Please login again.
	/// English String: "Password reset success! Please login again."
	/// </summary>
	public override string ResponsePasswordResetSuccess => "La contraseña ha sido restablecida correctamente. Vuelve a iniciar sesión.";

	/// <summary>
	/// Key: "Response.Success"
	/// English String: "Success"
	/// </summary>
	public override string ResponseSuccess => "Hecho";

	/// <summary>
	/// Key: "Response.UpdatePasswordFlooded"
	/// English String: "Too many attempts. Please try again later."
	/// </summary>
	public override string ResponseUpdatePasswordFlooded => "Demasiados intentos. Inténtalo de nuevo más tarde.";

	/// <summary>
	/// Key: "Response.UpdatePasswordIncorrect"
	/// English String: "Your current password is incorrect, the password was not changed."
	/// </summary>
	public override string ResponseUpdatePasswordIncorrect => "La contraseña actual es incorrecta. La contraseña no se ha modificado.";

	/// <summary>
	/// Key: "Response.UpdatePasswordInputMissing"
	/// English String: "Must include new password and confirm password"
	/// </summary>
	public override string ResponseUpdatePasswordInputMissing => "Debes incluir la contraseña nueva y la de confirmación.";

	/// <summary>
	/// Key: "Response.UpdatePasswordMismatch"
	/// English String: "Your new password and confirm password must match"
	/// </summary>
	public override string ResponseUpdatePasswordMismatch => "La contraseña nueva y la de confirmación deben coincidir.";

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
		return "Usar el correo electrónico para restablecer la contraseña";
	}

	protected override string _GetTemplateForActionEmailToRetriveUsername()
	{
		return "Usar el correo electrónico para recuperar el nombre de usuario";
	}

	protected override string _GetTemplateForActionOk()
	{
		return "Aceptar";
	}

	protected override string _GetTemplateForActionPhoneToResetPassword()
	{
		return "Usar el número de teléfono para restablecer la contraseña";
	}

	protected override string _GetTemplateForActionPhoneToRetriveUsername()
	{
		return "Usar el número de teléfono para recuperar el nombre de usuario";
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
		return $"Hemos notado que se ha modificado la contraseña de Roblox de tu cuenta: {userName}. Si no era tu intención cambiarla o si crees que otra persona la ha modificado por error, haz clic aquí para deshacer esa acción:{lineBreak}{actionLink} {lineBreak}{lineBreak}Si estás a gusto con tu nueva contraseña de Roblox, no tienes que hacer nada; ya está configurada. No contestes a este mensaje. Si tienes preguntas, consulta la página de ayuda de Roblox (https://www.roblox.com/help).";
	}

	protected override string _GetTemplateForDescriptionChangePasswordEmailHtmlBody1()
	{
		return "Hemos notado que se ha modificado la contraseña de Roblox de tu cuenta: {userName}. Si no era tu intención cambiarla o si crees que otra persona la ha modificado por error, haz clic aquí para deshacer esa acción:{lineBreak}{actionLink} {lineBreak}{lineBreak}Si estás a gusto con tu nueva contraseña de Roblox, no tienes que hacer nada; ya está configurada. No contestes a este mensaje. Si tienes preguntas, consulta la página de ayuda de Roblox (https://www.roblox.com/help).";
	}

	protected override string _GetTemplateForDescriptionEmailToResetPassword()
	{
		return "Introduce tu correo electrónico para restablecer tu contraseña.";
	}

	protected override string _GetTemplateForDescriptionEmailToRetriveUsername()
	{
		return "Introduce tu correo electrónico para recuperar tu nombre de usuario.";
	}

	/// <summary>
	/// Key: "Description.PasswordChangeEmail.BodyPlainText"
	/// password reset plaintext email message
	/// English String: "We noticed that the password changed for your Roblox account: {userName}. If you didn't intend to change it, or you think someone else changed it by mistake, please click this link to undo the action:\n{urlWithTicket}\n\nIf you are happy with your new Roblox password, you don't have to do anything! It's already set up. Please do not reply to this message. If you have any questions, please see the Roblox help page (https://www.roblox.com/help)."
	/// </summary>
	public override string DescriptionPasswordChangeEmailBodyPlainText(string userName, string urlWithTicket)
	{
		return $"Hemos notado que se ha modificado la contraseña de Roblox de tu cuenta: {userName}. Si no era tu intención cambiarla o si crees que otra persona la ha modificado por error, haz clic aquí para deshacer esa acción: \n{urlWithTicket}\n\nSi estás a gusto con tu nueva contraseña de Roblox, no tienes que hacer nada; ya está configurada. No contestes a este mensaje. Si tienes preguntas, consulta la página de ayuda de Roblox (https://www.roblox.com/help).";
	}

	protected override string _GetTemplateForDescriptionPasswordChangeEmailBodyPlainText()
	{
		return "Hemos notado que se ha modificado la contraseña de Roblox de tu cuenta: {userName}. Si no era tu intención cambiarla o si crees que otra persona la ha modificado por error, haz clic aquí para deshacer esa acción: \n{urlWithTicket}\n\nSi estás a gusto con tu nueva contraseña de Roblox, no tienes que hacer nada; ya está configurada. No contestes a este mensaje. Si tienes preguntas, consulta la página de ayuda de Roblox (https://www.roblox.com/help).";
	}

	/// <summary>
	/// Key: "Description.PasswordChangeEmail.From"
	/// name of the sender as shown in from field of the email
	/// English String: "\"Roblox Password Reset\" {fromEmailAddress}"
	/// </summary>
	public override string DescriptionPasswordChangeEmailFrom(string fromEmailAddress)
	{
		return $"\"Contraseña de Roblox restablecida\" {fromEmailAddress}";
	}

	protected override string _GetTemplateForDescriptionPasswordChangeEmailFrom()
	{
		return "\"Contraseña de Roblox restablecida\" {fromEmailAddress}";
	}

	protected override string _GetTemplateForDescriptionPasswordChangeEmailSubject()
	{
		return "Contraseña de Roblox restablecida";
	}

	/// <summary>
	/// Key: "Description.PasswordResetEmail.From"
	/// The "From" field for the password reset email
	/// English String: "{escapeLiteralStart}Roblox Password Reset{escapeLiteralEnd} {fromEmailAddress}"
	/// </summary>
	public override string DescriptionPasswordResetEmailFrom(string escapeLiteralStart, string escapeLiteralEnd, string fromEmailAddress)
	{
		return $"{escapeLiteralStart}Restablecimiento de contraseña de Roblox{escapeLiteralEnd} {fromEmailAddress}";
	}

	protected override string _GetTemplateForDescriptionPasswordResetEmailFrom()
	{
		return "{escapeLiteralStart}Restablecimiento de contraseña de Roblox{escapeLiteralEnd} {fromEmailAddress}";
	}

	/// <summary>
	/// Key: "Description.PasswordResetEmail.HtmlBody"
	/// This email is sent when a user requests a password reset.
	/// English String: "We have received a request to reset the password for your Roblox account: {emailOrUsername}{lineBreak}{lineBreak}If you submitted this request, please click the button below to proceed.{lineBreak}This button will be active for {passwordResetTicketHours} hours, {passwordResetTicketMinutes} minutes. If you do not wish to reset your password, please disregard this notice.{lineBreak}{lineBreak}{aTagWithStartHref}{resetPasswordUrl}{hrefEnd}{buttonStart}Reset Password{buttonEnd}{aTagEnd}"
	/// </summary>
	public override string DescriptionPasswordResetEmailHtmlBody(string emailOrUsername, string lineBreak, string passwordResetTicketHours, string passwordResetTicketMinutes, string aTagWithStartHref, string resetPasswordUrl, string hrefEnd, string buttonStart, string buttonEnd, string aTagEnd)
	{
		return $"Hemos recibido una solicitud para cambiar la contraseña de tu cuenta de Roblox: {emailOrUsername}{lineBreak}{lineBreak}Si enviaste la solicitud, haz clic en el siguiente enlace.{lineBreak}Este enlace estará activo durante {passwordResetTicketHours} horas, {passwordResetTicketMinutes} minutos. Si no quieres restablecer la contraseña, ignora este aviso.{lineBreak}{lineBreak}{aTagWithStartHref}{resetPasswordUrl}{hrefEnd}{buttonStart}Restablecer la contraseña{buttonEnd}{aTagEnd}";
	}

	protected override string _GetTemplateForDescriptionPasswordResetEmailHtmlBody()
	{
		return "Hemos recibido una solicitud para cambiar la contraseña de tu cuenta de Roblox: {emailOrUsername}{lineBreak}{lineBreak}Si enviaste la solicitud, haz clic en el siguiente enlace.{lineBreak}Este enlace estará activo durante {passwordResetTicketHours} horas, {passwordResetTicketMinutes} minutos. Si no quieres restablecer la contraseña, ignora este aviso.{lineBreak}{lineBreak}{aTagWithStartHref}{resetPasswordUrl}{hrefEnd}{buttonStart}Restablecer la contraseña{buttonEnd}{aTagEnd}";
	}

	/// <summary>
	/// Key: "Description.PasswordResetEmail.PlainBody"
	/// This email is sent when a user requests a password reset.
	/// English String: "We have received a request to reset the password for your Roblox account: {emailOrUsername}{lineBreak}{lineBreak}If you submitted this request, please click the link below or paste it into a web browser to proceed.{lineBreak}This link will be active for {passwordResetTicketHours} hours, {passwordResetTicketMinutes} minutes. If you do not wish to reset your password, please disregard this notice.{lineBreak}{lineBreak}{resetPasswordUrl}"
	/// </summary>
	public override string DescriptionPasswordResetEmailPlainBody(string emailOrUsername, string lineBreak, string passwordResetTicketHours, string passwordResetTicketMinutes, string resetPasswordUrl)
	{
		return $"Hemos recibido una solicitud para cambiar la contraseña de tu cuenta de Roblox: {emailOrUsername}{lineBreak}{lineBreak}Si enviaste la solicitud, haz clic en el siguiente enlace o pégalo en un navegador para continuar.{lineBreak}Este enlace estará activo durante {passwordResetTicketHours} horas, {passwordResetTicketMinutes} minutos. Si no quieres restablecer la contraseña, ignora este aviso.{lineBreak}{lineBreak}{resetPasswordUrl}";
	}

	protected override string _GetTemplateForDescriptionPasswordResetEmailPlainBody()
	{
		return "Hemos recibido una solicitud para cambiar la contraseña de tu cuenta de Roblox: {emailOrUsername}{lineBreak}{lineBreak}Si enviaste la solicitud, haz clic en el siguiente enlace o pégalo en un navegador para continuar.{lineBreak}Este enlace estará activo durante {passwordResetTicketHours} horas, {passwordResetTicketMinutes} minutos. Si no quieres restablecer la contraseña, ignora este aviso.{lineBreak}{lineBreak}{resetPasswordUrl}";
	}

	protected override string _GetTemplateForDescriptionPasswordResetEmailSubject()
	{
		return "Restablecimiento de la contraseña para la cuenta de Roblox";
	}

	protected override string _GetTemplateForDescriptionPhoneToResetPassword()
	{
		return "Introduce tu número de teléfono para restablecer tu contraseña.";
	}

	protected override string _GetTemplateForDescriptionPhoneToRetriveUsername()
	{
		return "Introduce tu número de teléfono para recuperar tu nombre de usuario.";
	}

	protected override string _GetTemplateForHeadingVerifyCode()
	{
		return "Verificar código";
	}

	protected override string _GetTemplateForHeadingVerifyPhone()
	{
		return "Verificar teléfono";
	}

	protected override string _GetTemplateForHeadingForgetPasswordOrUsername()
	{
		return "He olvidado la contraseña o el nombre de usuario.";
	}

	protected override string _GetTemplateForLabelActionButtonYes()
	{
		return "Sí";
	}

	protected override string _GetTemplateForLabelForgetMyPassword()
	{
		return "He olvidado mi contraseña.";
	}

	protected override string _GetTemplateForLabelForgetMyUsername()
	{
		return "He olvidado mi nombre de usuario.";
	}

	protected override string _GetTemplateForLabelInvalidEmail()
	{
		return "Correo electrónico no válido";
	}

	protected override string _GetTemplateForLabelInvalidPhoneNumber()
	{
		return "Número de teléfono no válido";
	}

	protected override string _GetTemplateForLabelNeutralButtonOk()
	{
		return "Aceptar";
	}

	protected override string _GetTemplateForLabelPassword()
	{
		return "Contraseña";
	}

	protected override string _GetTemplateForLabelResendCode()
	{
		return "Reenviar código";
	}

	protected override string _GetTemplateForLabelSubmit()
	{
		return "Enviar";
	}

	protected override string _GetTemplateForLabelToolTipWhoCanFindMeByPhone()
	{
		return "Este ajuste controla quién puede encontrarte mediante el número de teléfono que has proporcionado.";
	}

	protected override string _GetTemplateForLabelUsername()
	{
		return "Nombre de usuario";
	}

	protected override string _GetTemplateForLabelWhoCanFindMeByPhone()
	{
		return "¿Quién puede encontrarme por mi número de teléfono?";
	}

	/// <summary>
	/// Key: "Message.CantSendEmailWarning"
	/// English String: "If you did not give us a {styleStart}real email address{styleEnd} when you created your account, we cannot send you an email."
	/// </summary>
	public override string MessageCantSendEmailWarning(string styleStart, string styleEnd)
	{
		return $"Si no nos diste una {styleStart}dirección de correo electrónico auténtica{styleEnd} cuando creaste la cuenta, no podemos enviarte un correo electrónico.";
	}

	protected override string _GetTemplateForMessageCantSendEmailWarning()
	{
		return "Si no nos diste una {styleStart}dirección de correo electrónico auténtica{styleEnd} cuando creaste la cuenta, no podemos enviarte un correo electrónico.";
	}

	protected override string _GetTemplateForMessageDefaultError()
	{
		return "Se ha producido un error. Inténtalo de nuevo más tarde.";
	}

	protected override string _GetTemplateForMessageEmailForUsernameSuccessBody()
	{
		return "Se ha enviado un correo electrónico con tu nombre de usuario, siempre y cuando se haya guardado previamente esa dirección en tu cuenta.";
	}

	protected override string _GetTemplateForMessageEmailSuccessBody()
	{
		return "Se ha enviado un correo electrónico con instrucciones, siempre y cuando se haya guardado previamente esa dirección en tu cuenta.";
	}

	protected override string _GetTemplateForMessageEmailSuccessTitle()
	{
		return "Correo electrónico enviado";
	}

	protected override string _GetTemplateForMessageEnterCode()
	{
		return "Se ha enviado un código a tu teléfono, siempre y cuando ese número se haya sido verificado previamente en tu cuenta. Ingrésalo aquí abajo";
	}

	protected override string _GetTemplateForMessageEnterCodeSentToEmail()
	{
		return "Introduce el código que te acabamos de enviar a tu correo electrónico.";
	}

	protected override string _GetTemplateForMessagePhoneForUsernameSuccessBody()
	{
		return "Se ha enviado un SMS con los nombres de usuario a tu teléfono, siempre y cuando ese número se haya verificado previamente en tu cuenta.";
	}

	protected override string _GetTemplateForMessagePhoneForUsernameSuccessTitle()
	{
		return "SMS enviado";
	}

	protected override string _GetTemplateForMessageAccountDoesNotHaveAnEmail()
	{
		return "No hay correo electrónico vinculado a esta cuenta.";
	}

	protected override string _GetTemplateForMessageAccountNotFoundByEmail()
	{
		return "No se ha encontrado la cuenta. Prueba a usar otro correo electrónico.";
	}

	protected override string _GetTemplateForMessageAccountNotFoundByPhone()
	{
		return "No se ha encontrado la cuenta. Prueba a usar otro número de teléfono.";
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
		return "Las palabras que has introducido no coinciden con la imagen. Inténtalo de nuevo.";
	}

	protected override string _GetTemplateForMessageCredentialsError()
	{
		return "Tu nombre de usuario o tu contraseña son incorrectos. Compruébalos y vuelve a intentarlo.";
	}

	protected override string _GetTemplateForMessageFloodCheckedError()
	{
		return "Demasiados intentos. Inténtalo de nuevo más tarde.";
	}

	protected override string _GetTemplateForMessageForgotPasswordFeatureDisabled()
	{
		return "Función desactivada temporalmente. Inténtalo de nuevo más tarde.";
	}

	protected override string _GetTemplateForMessageForgotPasswordSuccess()
	{
		return "Busca las instrucciones de inicio de sesión en tu correo electrónico.";
	}

	protected override string _GetTemplateForMessageInvalidAccountStatus()
	{
		return "El estado de la cuenta impide restablecer la contraseña.";
	}

	protected override string _GetTemplateForMessageInvalidPassword()
	{
		return "Contraseña no válida";
	}

	protected override string _GetTemplateForMessageInvalidTicket()
	{
		return "No hemos podido cargar este ticket de seguridad.";
	}

	protected override string _GetTemplateForMessageInvalidUserNameOrEmail()
	{
		return "Nombre de usuario no válido o correo electrónico inexistente.";
	}

	protected override string _GetTemplateForMessageMobileResetPasswordSuccess()
	{
		return "MobileResetPasswordSuccess";
	}

	protected override string _GetTemplateForMessageNoAccountsLinkedToEmail()
	{
		return "No hay cuentas vinculadas a esta dirección de correo electrónico.";
	}

	protected override string _GetTemplateForMessageOldUsernameError()
	{
		return "Parece que intentas iniciar sesión con un nombre de usuario que ha cambiado. Inicia sesión con tu nuevo nombre de usuario.";
	}

	protected override string _GetTemplateForMessagePasswordCannotBeUsed()
	{
		return "Lo sentimos, esa contraseña no se puede usar.";
	}

	/// <summary>
	/// Key: "MessagePasswordResetTicketExpired"
	/// English String: "Sorry, password reset requests expire {expirationHour} hours, {expirationMinute} minutes after issuance. Try requesting another password reset ticket again."
	/// </summary>
	public override string MessagePasswordResetTicketExpired(string expirationHour, string expirationMinute)
	{
		return $"Lo sentimos. Las solicitudes de restablecimiento de contraseña caducan {expirationHour} horas, {expirationMinute} minutos después de expedirse. Intenta solicitar otro ticket de restablecimiento de contraseña.";
	}

	protected override string _GetTemplateForMessagePasswordResetTicketExpired()
	{
		return "Lo sentimos. Las solicitudes de restablecimiento de contraseña caducan {expirationHour} horas, {expirationMinute} minutos después de expedirse. Intenta solicitar otro ticket de restablecimiento de contraseña.";
	}

	protected override string _GetTemplateForMessagePasswordsDoNotMatch()
	{
		return "Las contraseñas no coinciden.";
	}

	protected override string _GetTemplateForMessageSamlUnauthenticated()
	{
		return "Debes iniciar sesión en Roblox para completar la autenticación.";
	}

	protected override string _GetTemplateForMessageUnknownError()
	{
		return "Error desconocido";
	}

	protected override string _GetTemplateForMessageUnknownSystemError()
	{
		return "Error del sistema. Regresa a la pantalla de inicio de sesión.";
	}

	protected override string _GetTemplateForPlaceholderEmail()
	{
		return "Correo electrónico";
	}

	/// <summary>
	/// Key: "Placeholder.EnterCode"
	/// English String: "Enter Code ({codeLength}-digit)"
	/// </summary>
	public override string PlaceholderEnterCode(string codeLength)
	{
		return $"Introduce el código ({codeLength} dígitos)";
	}

	protected override string _GetTemplateForPlaceholderEnterCode()
	{
		return "Introduce el código ({codeLength} dígitos)";
	}

	protected override string _GetTemplateForPlaceholderPhoneNumber()
	{
		return "Número de teléfono";
	}

	protected override string _GetTemplateForResponsePasswordResetSuccess()
	{
		return "La contraseña ha sido restablecida correctamente. Vuelve a iniciar sesión.";
	}

	protected override string _GetTemplateForResponseSuccess()
	{
		return "Hecho";
	}

	protected override string _GetTemplateForResponseUpdatePasswordFlooded()
	{
		return "Demasiados intentos. Inténtalo de nuevo más tarde.";
	}

	protected override string _GetTemplateForResponseUpdatePasswordIncorrect()
	{
		return "La contraseña actual es incorrecta. La contraseña no se ha modificado.";
	}

	protected override string _GetTemplateForResponseUpdatePasswordInputMissing()
	{
		return "Debes incluir la contraseña nueva y la de confirmación.";
	}

	protected override string _GetTemplateForResponseUpdatePasswordMismatch()
	{
		return "La contraseña nueva y la de confirmación deben coincidir.";
	}
}
