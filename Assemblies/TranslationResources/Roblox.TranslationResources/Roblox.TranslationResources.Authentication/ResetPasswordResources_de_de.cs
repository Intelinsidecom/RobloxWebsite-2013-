namespace Roblox.TranslationResources.Authentication;

/// <summary>
/// This class overrides ResetPasswordResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ResetPasswordResources_de_de : ResetPasswordResources_en_us, IResetPasswordResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "Abbrechen";

	/// <summary>
	/// Key: "Action.EmailToResetPassword"
	/// English String: "Use email to reset password"
	/// </summary>
	public override string ActionEmailToResetPassword => "Passwort über E-Mail-Adresse zurücksetzen";

	/// <summary>
	/// Key: "Action.EmailToRetriveUsername"
	/// English String: "Use email to retrieve username"
	/// </summary>
	public override string ActionEmailToRetriveUsername => "Benutzernamen über E-Mail-Adresse erhalten";

	/// <summary>
	/// Key: "Action.Ok"
	/// OK
	/// English String: "OK"
	/// </summary>
	public override string ActionOk => "Okay";

	/// <summary>
	/// Key: "Action.PhoneToResetPassword"
	/// English String: "Use phone number to reset password"
	/// </summary>
	public override string ActionPhoneToResetPassword => "Passwort über Handynummer zurücksetzen";

	/// <summary>
	/// Key: "Action.PhoneToRetriveUsername"
	/// English String: "Use phone number to retrieve username"
	/// </summary>
	public override string ActionPhoneToRetriveUsername => "Benutzernamen über Handynummer erhalten";

	/// <summary>
	/// Key: "Action.Verify"
	/// English String: "Verify"
	/// </summary>
	public override string ActionVerify => "Verifizieren";

	/// <summary>
	/// Key: "Description.EmailToResetPassword"
	/// English String: "Enter your email to reset your password."
	/// </summary>
	public override string DescriptionEmailToResetPassword => "Gib deine E-Mail-Adresse ein, um dein Passwort zurückzusetzen.";

	/// <summary>
	/// Key: "Description.EmailToRetriveUsername"
	/// English String: "Enter your email to retrieve your username."
	/// </summary>
	public override string DescriptionEmailToRetriveUsername => "Gib deine E-Mail-Adresse ein, um deinen Benutzernamen zu erhalten.";

	/// <summary>
	/// Key: "Description.PasswordChangeEmail.Subject"
	/// email subject to change password
	/// English String: "Roblox Password Reset"
	/// </summary>
	public override string DescriptionPasswordChangeEmailSubject => "Roblox-Passwort zurückgesetzt";

	/// <summary>
	/// Key: "Description.PasswordResetEmail.Subject"
	/// Subject for password reset email
	/// English String: "Roblox Account Password Reset"
	/// </summary>
	public override string DescriptionPasswordResetEmailSubject => "Passwort für Roblox-Konto zurücksetzen";

	/// <summary>
	/// Key: "Description.PhoneToResetPassword"
	/// English String: "Enter your phone number to reset your password."
	/// </summary>
	public override string DescriptionPhoneToResetPassword => "Gib deine Handynummer ein, um dein Passwort zurückzusetzen.";

	/// <summary>
	/// Key: "Description.PhoneToRetriveUsername"
	/// English String: "Enter your phone number to retrieve your username."
	/// </summary>
	public override string DescriptionPhoneToRetriveUsername => "Gib deine Handynummer ein, um deinen Benutzernamen zu erhalten.";

	/// <summary>
	/// Key: "Heading.VerifyCode"
	/// verify code heading
	/// English String: "Verify Code"
	/// </summary>
	public override string HeadingVerifyCode => "Code verifizieren";

	/// <summary>
	/// Key: "Heading.VerifyPhone"
	/// English String: "Verify Phone"
	/// </summary>
	public override string HeadingVerifyPhone => "Handy verifizieren";

	/// <summary>
	/// Key: "HeadingForgetPasswordOrUsername"
	/// English String: "Forgot Password or Username"
	/// </summary>
	public override string HeadingForgetPasswordOrUsername => "Passwort oder Benutzername vergessen";

	/// <summary>
	/// Key: "Label.ActionButtonYes"
	/// button label
	/// English String: "Yes"
	/// </summary>
	public override string LabelActionButtonYes => "Ja";

	/// <summary>
	/// Key: "Label.ForgetMyPassword"
	/// English String: "Forgot My Password"
	/// </summary>
	public override string LabelForgetMyPassword => "Passwort vergessen";

	/// <summary>
	/// Key: "Label.ForgetMyUsername"
	/// English String: "Forgot My Username"
	/// </summary>
	public override string LabelForgetMyUsername => "Benutzername vergessen";

	/// <summary>
	/// Key: "Label.InvalidEmail"
	/// English String: "Invalid email"
	/// </summary>
	public override string LabelInvalidEmail => "Ungültige E-Mail-Adresse";

	/// <summary>
	/// Key: "Label.InvalidPhoneNumber"
	/// English String: "Invalid phone number"
	/// </summary>
	public override string LabelInvalidPhoneNumber => "Ungültige Handynummer";

	/// <summary>
	/// Key: "Label.NeutralButtonOk"
	/// ok button label
	/// English String: "OK"
	/// </summary>
	public override string LabelNeutralButtonOk => "Okay";

	/// <summary>
	/// Key: "Label.Password"
	/// label
	/// English String: "Password"
	/// </summary>
	public override string LabelPassword => "Passwort";

	/// <summary>
	/// Key: "Label.ResendCode"
	/// English String: "Resend Code"
	/// </summary>
	public override string LabelResendCode => "Code erneut senden";

	/// <summary>
	/// Key: "Label.Submit"
	/// English String: "Submit"
	/// </summary>
	public override string LabelSubmit => "Senden";

	/// <summary>
	/// Key: "Label.ToolTip.WhoCanFindMeByPhone"
	/// English String: "This setting controls who can find you using the phone number you provided."
	/// </summary>
	public override string LabelToolTipWhoCanFindMeByPhone => "Mit dieser Einstellung kannst du festlegen, wer dich über die von dir angegebene Handynummer finden kann.";

	/// <summary>
	/// Key: "Label.Username"
	/// English String: "Username"
	/// </summary>
	public override string LabelUsername => "Benutzername";

	/// <summary>
	/// Key: "Label.WhoCanFindMeByPhone"
	/// English String: "Who can find me by my phone number?"
	/// </summary>
	public override string LabelWhoCanFindMeByPhone => "Wer kann mich über meine Handynummer finden?";

	/// <summary>
	/// Key: "Message.DefaultError"
	/// English String: "An error occurred, try again later."
	/// </summary>
	public override string MessageDefaultError => "Ein Fehler ist aufgetreten. Bitte versuche es später erneut.";

	/// <summary>
	/// Key: "Message.EmailForUsernameSuccessBody"
	/// success message
	/// English String: "An email with your username(s) has been sent to you if the email was previously saved on your account."
	/// </summary>
	public override string MessageEmailForUsernameSuccessBody => "Eine E-Mail mit deinem Benutzernamen wurde an dich gesendet, wenn diese Email bereits in deinem Konto gespeichert ist.";

	/// <summary>
	/// Key: "Message.EmailSuccessBody"
	/// English String: "An email with instructions has been sent to you if the email was previously saved on your account."
	/// </summary>
	public override string MessageEmailSuccessBody => "Eine E-Mail mit Anweisungen wurde an dich gesendet, wenn die E-Mail zuvor in deinem Konto gespeichert wurde.";

	/// <summary>
	/// Key: "Message.EmailSuccessTitle"
	/// English String: "Email Sent"
	/// </summary>
	public override string MessageEmailSuccessTitle => "E-Mail gesendet";

	/// <summary>
	/// Key: "Message.EnterCode"
	/// English String: "A code was sent to your phone if it was previously verified on your account. Please enter it below"
	/// </summary>
	public override string MessageEnterCode => "Ein Code wurde an dein Handy gesendet, wenn es zuvor in deinem Konto bestätigt wurde. Bitte gib den Code unten ein";

	/// <summary>
	/// Key: "Message.EnterCodeSentToEmail"
	/// Enter the code we just sent to your email.
	/// English String: "Enter the code we just sent to your email."
	/// </summary>
	public override string MessageEnterCodeSentToEmail => "Gib den Code ein, den wir dir gerade per E-Mail geschickt haben.";

	/// <summary>
	/// Key: "Message.PhoneForUsernameSuccessBody"
	/// English String: "An SMS with your username(s) has been sent to you if the phone number was previously verified on your account."
	/// </summary>
	public override string MessagePhoneForUsernameSuccessBody => "Eine SMS mit deinem Benutzernamen wurde an dich gesendet, wenn du deine Telefonnummer zuvor in deinem Konto bestätigt hast.";

	/// <summary>
	/// Key: "Message.PhoneForUsernameSuccessTitle"
	/// English String: "SMS Sent"
	/// </summary>
	public override string MessagePhoneForUsernameSuccessTitle => "SMS gesendet";

	/// <summary>
	/// Key: "MessageAccountDoesNotHaveAnEmail"
	/// English String: "There is no email linked to this account"
	/// </summary>
	public override string MessageAccountDoesNotHaveAnEmail => "Mit diesem Konto ist keine E-Mail-Adresse verbunden.";

	/// <summary>
	/// Key: "MessageAccountNotFoundByEmail"
	/// No account found. Please use a different email.
	/// English String: "No account found. Please use a different email."
	/// </summary>
	public override string MessageAccountNotFoundByEmail => "Kein Konto gefunden. Bitte versuche es mit einer anderen E-Mail-Adresse.";

	/// <summary>
	/// Key: "MessageAccountNotFoundByPhone"
	/// No account found. Please use a different phone number.
	/// English String: "No account found. Please use a different phone number."
	/// </summary>
	public override string MessageAccountNotFoundByPhone => "Kein Konto gefunden. Bitte versuche es mit einer anderen Handynummer.";

	/// <summary>
	/// Key: "MessageAccountRecoveryUnknownError"
	/// English String: "System error. Account could not be restored to this state."
	/// </summary>
	public override string MessageAccountRecoveryUnknownError => "Systemfehler. Kontostatus konnte nicht wiederhergestellt werden.";

	/// <summary>
	/// Key: "MessageCaptchaError"
	/// English String: "We need to make sure you're not a robot!"
	/// </summary>
	public override string MessageCaptchaError => "Wir müssen sicherstellen, dass du kein Roboter bist!";

	/// <summary>
	/// Key: "MessageCaptchaFailError"
	/// English String: "The words you typed didn't match the picture. Please try again."
	/// </summary>
	public override string MessageCaptchaFailError => "Die von dir eingegebenen Wörter stimmen nicht mit dem Bild überein. Bitte versuche es erneut.";

	/// <summary>
	/// Key: "MessageCredentialsError"
	/// English String: "Your username or password is incorrect. Please check them and try again."
	/// </summary>
	public override string MessageCredentialsError => "Dein Benutzername oder dein Passwort ist falsch. Bitte überprüfe beide und versuche es erneut.";

	/// <summary>
	/// Key: "MessageFloodCheckedError"
	/// English String: "Too many attempts. Please try again later."
	/// </summary>
	public override string MessageFloodCheckedError => "Zu viele Versuche. Bitte versuche es später erneut.";

	/// <summary>
	/// Key: "MessageForgotPasswordFeatureDisabled"
	/// English String: "Feature temporarily disabled. Please try again later."
	/// </summary>
	public override string MessageForgotPasswordFeatureDisabled => "Feature ist derzeit deaktiviert. Bitte versuche es später erneut.";

	/// <summary>
	/// Key: "MessageForgotPasswordSuccess"
	/// English String: "Check your email for login instructions"
	/// </summary>
	public override string MessageForgotPasswordSuccess => "Sieh in deinem E-Mail-Postfach nach, um Anweisungen zur Anmeldung zu erhalten.";

	/// <summary>
	/// Key: "MessageInvalidAccountStatus"
	/// English String: "Account status prevents resetting password"
	/// </summary>
	public override string MessageInvalidAccountStatus => "Status des Kontos verhindert Zurücksetzen des Passworts.";

	/// <summary>
	/// Key: "MessageInvalidPassword"
	/// English String: "Invalid password"
	/// </summary>
	public override string MessageInvalidPassword => "Ungültiges Passwort";

	/// <summary>
	/// Key: "MessageInvalidTicket"
	/// English String: "We couldn't load this security ticket."
	/// </summary>
	public override string MessageInvalidTicket => "Wir konnten dieses Sicherheitsticket nicht laden.";

	/// <summary>
	/// Key: "MessageInvalidUserNameOrEmail"
	/// English String: "Invalid username, or no email exists"
	/// </summary>
	public override string MessageInvalidUserNameOrEmail => "Ungültiger Benutzername oder es existiert keine E-Mail-Adresse.";

	/// <summary>
	/// Key: "MessageMobileResetPasswordSuccess"
	/// English String: "MobileResetPasswordSuccess"
	/// </summary>
	public override string MessageMobileResetPasswordSuccess => "MobileResetPasswordSuccess";

	/// <summary>
	/// Key: "MessageNoAccountsLinkedToEmail"
	/// English String: "There are no accounts linked to this email address"
	/// </summary>
	public override string MessageNoAccountsLinkedToEmail => "Mit dieser E-Mail-Adresse sind keine Konten verbunden.";

	/// <summary>
	/// Key: "MessageOldUsernameError"
	/// English String: "It looks like you are trying to log in with a username that has changed. Please log in with your new username."
	/// </summary>
	public override string MessageOldUsernameError => "Du versuchst, dich mit einem Benutzernamen anzumelden, der geändert wurde. Bitte melde dich mit deinem neuen Benutzernamen an.";

	/// <summary>
	/// Key: "MessagePasswordCannotBeUsed"
	/// English String: "Sorry, that password cannot be used."
	/// </summary>
	public override string MessagePasswordCannotBeUsed => "Entschuldigung, das Passwort kann nicht verwendet werden.";

	/// <summary>
	/// Key: "MessagePasswordsDoNotMatch"
	/// English String: "Passwords do not match"
	/// </summary>
	public override string MessagePasswordsDoNotMatch => "Passwörter stimmen nicht überein";

	/// <summary>
	/// Key: "MessageSamlUnauthenticated"
	/// English String: "You must log in to Roblox to finish authenticating."
	/// </summary>
	public override string MessageSamlUnauthenticated => "Du musst dich bei Roblox anmelden, um die Authentifizierung abzuschließen.";

	/// <summary>
	/// Key: "MessageUnknownError"
	/// English String: "Unknown Error"
	/// </summary>
	public override string MessageUnknownError => "Unbekannter Fehler";

	/// <summary>
	/// Key: "MessageUnknownSystemError"
	/// English String: "System error. Please return to login screen."
	/// </summary>
	public override string MessageUnknownSystemError => "Systemfehler. Bitte kehre zum Anmeldefenster zurück.";

	/// <summary>
	/// Key: "Placeholder.Email"
	/// English String: "Email"
	/// </summary>
	public override string PlaceholderEmail => "E-Mail-Adresse";

	/// <summary>
	/// Key: "Placeholder.PhoneNumber"
	/// English String: "Phone Number"
	/// </summary>
	public override string PlaceholderPhoneNumber => "Handynummer";

	/// <summary>
	/// Key: "Response.PasswordResetSuccess"
	/// Password reset success! Please login again.
	/// English String: "Password reset success! Please login again."
	/// </summary>
	public override string ResponsePasswordResetSuccess => "Passwortrücksetzung abgeschlossen! Bitte melde dich erneut an.";

	/// <summary>
	/// Key: "Response.Success"
	/// English String: "Success"
	/// </summary>
	public override string ResponseSuccess => "Erfolg";

	/// <summary>
	/// Key: "Response.UpdatePasswordFlooded"
	/// English String: "Too many attempts. Please try again later."
	/// </summary>
	public override string ResponseUpdatePasswordFlooded => "Zu viele Versuche. Bitte versuche es später erneut.";

	/// <summary>
	/// Key: "Response.UpdatePasswordIncorrect"
	/// English String: "Your current password is incorrect, the password was not changed."
	/// </summary>
	public override string ResponseUpdatePasswordIncorrect => "Dein aktuelles Passwort ist falsch, das Passwort wurde nicht geändert.";

	/// <summary>
	/// Key: "Response.UpdatePasswordInputMissing"
	/// English String: "Must include new password and confirm password"
	/// </summary>
	public override string ResponseUpdatePasswordInputMissing => "Neues Passwort muss eingegeben und bestätigt werden.";

	/// <summary>
	/// Key: "Response.UpdatePasswordMismatch"
	/// English String: "Your new password and confirm password must match"
	/// </summary>
	public override string ResponseUpdatePasswordMismatch => "Dein neues Passwort und das bestätigte Passwort müssen übereinstimmen.";

	public ResetPasswordResources_de_de(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "Abbrechen";
	}

	protected override string _GetTemplateForActionEmailToResetPassword()
	{
		return "Passwort über E-Mail-Adresse zurücksetzen";
	}

	protected override string _GetTemplateForActionEmailToRetriveUsername()
	{
		return "Benutzernamen über E-Mail-Adresse erhalten";
	}

	protected override string _GetTemplateForActionOk()
	{
		return "Okay";
	}

	protected override string _GetTemplateForActionPhoneToResetPassword()
	{
		return "Passwort über Handynummer zurücksetzen";
	}

	protected override string _GetTemplateForActionPhoneToRetriveUsername()
	{
		return "Benutzernamen über Handynummer erhalten";
	}

	protected override string _GetTemplateForActionVerify()
	{
		return "Verifizieren";
	}

	/// <summary>
	/// Key: "Description.ChangePasswordEmail.HtmlBody1"
	/// email body for change password email
	/// English String: "We noticed that the password changed for your Roblox account: {userName}. If you didn't intend to change it, or you think someone else changed it by mistake, please click this link to undo the action:{lineBreak} {actionLink} {lineBreak}{lineBreak}If you are happy with your new Roblox password, you don't have to do anything! It's already set up. Please do not reply to this message. If you have any questions, please see the Roblox help page (https://www.roblox.com/help)."
	/// </summary>
	public override string DescriptionChangePasswordEmailHtmlBody1(string userName, string lineBreak, string actionLink)
	{
		return $"Wir haben festgestellt, dass sich das Passwort für dein Roblox-Konto {userName} geändert hat. Falls dies nicht beabsichtigt war oder du glaubst, dass es jemand aus Versehen geändert hat, klicke auf diesen Link, um die Änderung rückgängig zu machen:{lineBreak}{actionLink}{lineBreak}{lineBreak}Wenn du mit deinem neuen Roblox-Passwort zufrieden bist, brauchst du nichts zu tun! Es ist bereits eingestellt. Bitte antworte nicht auf diese Nachricht. Falls Du Fragen hast, sieh dir unsere Roblox-Hilfe-Seite an (https://www.roblox.com/help).";
	}

	protected override string _GetTemplateForDescriptionChangePasswordEmailHtmlBody1()
	{
		return "Wir haben festgestellt, dass sich das Passwort für dein Roblox-Konto {userName} geändert hat. Falls dies nicht beabsichtigt war oder du glaubst, dass es jemand aus Versehen geändert hat, klicke auf diesen Link, um die Änderung rückgängig zu machen:{lineBreak}{actionLink}{lineBreak}{lineBreak}Wenn du mit deinem neuen Roblox-Passwort zufrieden bist, brauchst du nichts zu tun! Es ist bereits eingestellt. Bitte antworte nicht auf diese Nachricht. Falls Du Fragen hast, sieh dir unsere Roblox-Hilfe-Seite an (https://www.roblox.com/help).";
	}

	protected override string _GetTemplateForDescriptionEmailToResetPassword()
	{
		return "Gib deine E-Mail-Adresse ein, um dein Passwort zurückzusetzen.";
	}

	protected override string _GetTemplateForDescriptionEmailToRetriveUsername()
	{
		return "Gib deine E-Mail-Adresse ein, um deinen Benutzernamen zu erhalten.";
	}

	/// <summary>
	/// Key: "Description.PasswordChangeEmail.BodyPlainText"
	/// password reset plaintext email message
	/// English String: "We noticed that the password changed for your Roblox account: {userName}. If you didn't intend to change it, or you think someone else changed it by mistake, please click this link to undo the action:\n{urlWithTicket}\n\nIf you are happy with your new Roblox password, you don't have to do anything! It's already set up. Please do not reply to this message. If you have any questions, please see the Roblox help page (https://www.roblox.com/help)."
	/// </summary>
	public override string DescriptionPasswordChangeEmailBodyPlainText(string userName, string urlWithTicket)
	{
		return $"Wir haben festgestellt, dass sich das Passwort für dein Roblox-Konto {userName} geändert hat. Falls dies nicht beabsichtigt war oder du glaubst, dass es jemand aus Versehen geändert hat, klicke auf diesen Link, um die Änderung rückgängig zu machen: {urlWithTicket}\n\nWenn du mit deinem neuen Roblox-Passwort zufrieden bist, brauchst du nichts zu tun! Es ist bereits eingestellt. Bitte antworte nicht auf diese Nachricht. Falls Du Fragen hast, sieh dir unsere Roblox-Hilfe-Seite an (https://www.roblox.com/help).";
	}

	protected override string _GetTemplateForDescriptionPasswordChangeEmailBodyPlainText()
	{
		return "Wir haben festgestellt, dass sich das Passwort für dein Roblox-Konto {userName} geändert hat. Falls dies nicht beabsichtigt war oder du glaubst, dass es jemand aus Versehen geändert hat, klicke auf diesen Link, um die Änderung rückgängig zu machen: {urlWithTicket}\n\nWenn du mit deinem neuen Roblox-Passwort zufrieden bist, brauchst du nichts zu tun! Es ist bereits eingestellt. Bitte antworte nicht auf diese Nachricht. Falls Du Fragen hast, sieh dir unsere Roblox-Hilfe-Seite an (https://www.roblox.com/help).";
	}

	/// <summary>
	/// Key: "Description.PasswordChangeEmail.From"
	/// name of the sender as shown in from field of the email
	/// English String: "\"Roblox Password Reset\" {fromEmailAddress}"
	/// </summary>
	public override string DescriptionPasswordChangeEmailFrom(string fromEmailAddress)
	{
		return $"„Roblox-Passwort zurückgesetzt“ {fromEmailAddress}";
	}

	protected override string _GetTemplateForDescriptionPasswordChangeEmailFrom()
	{
		return "„Roblox-Passwort zurückgesetzt“ {fromEmailAddress}";
	}

	protected override string _GetTemplateForDescriptionPasswordChangeEmailSubject()
	{
		return "Roblox-Passwort zurückgesetzt";
	}

	/// <summary>
	/// Key: "Description.PasswordResetEmail.From"
	/// The "From" field for the password reset email
	/// English String: "{escapeLiteralStart}Roblox Password Reset{escapeLiteralEnd} {fromEmailAddress}"
	/// </summary>
	public override string DescriptionPasswordResetEmailFrom(string escapeLiteralStart, string escapeLiteralEnd, string fromEmailAddress)
	{
		return $"{escapeLiteralStart}Roblox-Passwort zurückgesetzt{escapeLiteralEnd} {fromEmailAddress}";
	}

	protected override string _GetTemplateForDescriptionPasswordResetEmailFrom()
	{
		return "{escapeLiteralStart}Roblox-Passwort zurückgesetzt{escapeLiteralEnd} {fromEmailAddress}";
	}

	/// <summary>
	/// Key: "Description.PasswordResetEmail.HtmlBody"
	/// This email is sent when a user requests a password reset.
	/// English String: "We have received a request to reset the password for your Roblox account: {emailOrUsername}{lineBreak}{lineBreak}If you submitted this request, please click the button below to proceed.{lineBreak}This button will be active for {passwordResetTicketHours} hours, {passwordResetTicketMinutes} minutes. If you do not wish to reset your password, please disregard this notice.{lineBreak}{lineBreak}{aTagWithStartHref}{resetPasswordUrl}{hrefEnd}{buttonStart}Reset Password{buttonEnd}{aTagEnd}"
	/// </summary>
	public override string DescriptionPasswordResetEmailHtmlBody(string emailOrUsername, string lineBreak, string passwordResetTicketHours, string passwordResetTicketMinutes, string aTagWithStartHref, string resetPasswordUrl, string hrefEnd, string buttonStart, string buttonEnd, string aTagEnd)
	{
		return $"Wir haben eine Anfrage erhalten, das Passwort für dein Roblox-Konto zurückzusetzen: {emailOrUsername}{lineBreak}{lineBreak}Wenn du diese Anfrage gestellt hast, klicke bitte auf den folgenden Button, um fortzufahren.{lineBreak}Dieser Button bleibt {passwordResetTicketHours} Stunden, {passwordResetTicketMinutes} Minuten gültig. Wenn du dein Passwort nicht zurücksetzen möchtest, ignoriere einfach diese Nachricht.{lineBreak}{lineBreak}{aTagWithStartHref}{resetPasswordUrl}{hrefEnd}{buttonStart}Passwort zurücksetzen{buttonEnd}{aTagEnd}";
	}

	protected override string _GetTemplateForDescriptionPasswordResetEmailHtmlBody()
	{
		return "Wir haben eine Anfrage erhalten, das Passwort für dein Roblox-Konto zurückzusetzen: {emailOrUsername}{lineBreak}{lineBreak}Wenn du diese Anfrage gestellt hast, klicke bitte auf den folgenden Button, um fortzufahren.{lineBreak}Dieser Button bleibt {passwordResetTicketHours} Stunden, {passwordResetTicketMinutes} Minuten gültig. Wenn du dein Passwort nicht zurücksetzen möchtest, ignoriere einfach diese Nachricht.{lineBreak}{lineBreak}{aTagWithStartHref}{resetPasswordUrl}{hrefEnd}{buttonStart}Passwort zurücksetzen{buttonEnd}{aTagEnd}";
	}

	/// <summary>
	/// Key: "Description.PasswordResetEmail.PlainBody"
	/// This email is sent when a user requests a password reset.
	/// English String: "We have received a request to reset the password for your Roblox account: {emailOrUsername}{lineBreak}{lineBreak}If you submitted this request, please click the link below or paste it into a web browser to proceed.{lineBreak}This link will be active for {passwordResetTicketHours} hours, {passwordResetTicketMinutes} minutes. If you do not wish to reset your password, please disregard this notice.{lineBreak}{lineBreak}{resetPasswordUrl}"
	/// </summary>
	public override string DescriptionPasswordResetEmailPlainBody(string emailOrUsername, string lineBreak, string passwordResetTicketHours, string passwordResetTicketMinutes, string resetPasswordUrl)
	{
		return $"Wir haben eine Anfrage erhalten, das Passwort für dein Roblox-Konto zurückzusetzen: {emailOrUsername}{lineBreak}{lineBreak}Wenn du diese Anfrage gestellt hast, klicke bitte auf den folgenden Link oder kopiere ihn in einen Webbrowser, um fortzufahren.{lineBreak}Dieser Link bleibt {passwordResetTicketHours} Stunden, {passwordResetTicketMinutes} Minuten gültig. Wenn du dein Passwort nicht zurücksetzen möchtest, ignoriere einfach diese Nachricht.{lineBreak}{lineBreak}{resetPasswordUrl}";
	}

	protected override string _GetTemplateForDescriptionPasswordResetEmailPlainBody()
	{
		return "Wir haben eine Anfrage erhalten, das Passwort für dein Roblox-Konto zurückzusetzen: {emailOrUsername}{lineBreak}{lineBreak}Wenn du diese Anfrage gestellt hast, klicke bitte auf den folgenden Link oder kopiere ihn in einen Webbrowser, um fortzufahren.{lineBreak}Dieser Link bleibt {passwordResetTicketHours} Stunden, {passwordResetTicketMinutes} Minuten gültig. Wenn du dein Passwort nicht zurücksetzen möchtest, ignoriere einfach diese Nachricht.{lineBreak}{lineBreak}{resetPasswordUrl}";
	}

	protected override string _GetTemplateForDescriptionPasswordResetEmailSubject()
	{
		return "Passwort für Roblox-Konto zurücksetzen";
	}

	protected override string _GetTemplateForDescriptionPhoneToResetPassword()
	{
		return "Gib deine Handynummer ein, um dein Passwort zurückzusetzen.";
	}

	protected override string _GetTemplateForDescriptionPhoneToRetriveUsername()
	{
		return "Gib deine Handynummer ein, um deinen Benutzernamen zu erhalten.";
	}

	protected override string _GetTemplateForHeadingVerifyCode()
	{
		return "Code verifizieren";
	}

	protected override string _GetTemplateForHeadingVerifyPhone()
	{
		return "Handy verifizieren";
	}

	protected override string _GetTemplateForHeadingForgetPasswordOrUsername()
	{
		return "Passwort oder Benutzername vergessen";
	}

	protected override string _GetTemplateForLabelActionButtonYes()
	{
		return "Ja";
	}

	protected override string _GetTemplateForLabelForgetMyPassword()
	{
		return "Passwort vergessen";
	}

	protected override string _GetTemplateForLabelForgetMyUsername()
	{
		return "Benutzername vergessen";
	}

	protected override string _GetTemplateForLabelInvalidEmail()
	{
		return "Ungültige E-Mail-Adresse";
	}

	protected override string _GetTemplateForLabelInvalidPhoneNumber()
	{
		return "Ungültige Handynummer";
	}

	protected override string _GetTemplateForLabelNeutralButtonOk()
	{
		return "Okay";
	}

	protected override string _GetTemplateForLabelPassword()
	{
		return "Passwort";
	}

	protected override string _GetTemplateForLabelResendCode()
	{
		return "Code erneut senden";
	}

	protected override string _GetTemplateForLabelSubmit()
	{
		return "Senden";
	}

	protected override string _GetTemplateForLabelToolTipWhoCanFindMeByPhone()
	{
		return "Mit dieser Einstellung kannst du festlegen, wer dich über die von dir angegebene Handynummer finden kann.";
	}

	protected override string _GetTemplateForLabelUsername()
	{
		return "Benutzername";
	}

	protected override string _GetTemplateForLabelWhoCanFindMeByPhone()
	{
		return "Wer kann mich über meine Handynummer finden?";
	}

	/// <summary>
	/// Key: "Message.CantSendEmailWarning"
	/// English String: "If you did not give us a {styleStart}real email address{styleEnd} when you created your account, we cannot send you an email."
	/// </summary>
	public override string MessageCantSendEmailWarning(string styleStart, string styleEnd)
	{
		return $"Wenn du bei der Erstellung deines Kontos keine {styleStart}gültige E-Mail-Adresse{styleEnd} angegeben hast, können wir dir auch keine E-Mail senden.";
	}

	protected override string _GetTemplateForMessageCantSendEmailWarning()
	{
		return "Wenn du bei der Erstellung deines Kontos keine {styleStart}gültige E-Mail-Adresse{styleEnd} angegeben hast, können wir dir auch keine E-Mail senden.";
	}

	protected override string _GetTemplateForMessageDefaultError()
	{
		return "Ein Fehler ist aufgetreten. Bitte versuche es später erneut.";
	}

	protected override string _GetTemplateForMessageEmailForUsernameSuccessBody()
	{
		return "Eine E-Mail mit deinem Benutzernamen wurde an dich gesendet, wenn diese Email bereits in deinem Konto gespeichert ist.";
	}

	protected override string _GetTemplateForMessageEmailSuccessBody()
	{
		return "Eine E-Mail mit Anweisungen wurde an dich gesendet, wenn die E-Mail zuvor in deinem Konto gespeichert wurde.";
	}

	protected override string _GetTemplateForMessageEmailSuccessTitle()
	{
		return "E-Mail gesendet";
	}

	protected override string _GetTemplateForMessageEnterCode()
	{
		return "Ein Code wurde an dein Handy gesendet, wenn es zuvor in deinem Konto bestätigt wurde. Bitte gib den Code unten ein";
	}

	protected override string _GetTemplateForMessageEnterCodeSentToEmail()
	{
		return "Gib den Code ein, den wir dir gerade per E-Mail geschickt haben.";
	}

	protected override string _GetTemplateForMessagePhoneForUsernameSuccessBody()
	{
		return "Eine SMS mit deinem Benutzernamen wurde an dich gesendet, wenn du deine Telefonnummer zuvor in deinem Konto bestätigt hast.";
	}

	protected override string _GetTemplateForMessagePhoneForUsernameSuccessTitle()
	{
		return "SMS gesendet";
	}

	protected override string _GetTemplateForMessageAccountDoesNotHaveAnEmail()
	{
		return "Mit diesem Konto ist keine E-Mail-Adresse verbunden.";
	}

	protected override string _GetTemplateForMessageAccountNotFoundByEmail()
	{
		return "Kein Konto gefunden. Bitte versuche es mit einer anderen E-Mail-Adresse.";
	}

	protected override string _GetTemplateForMessageAccountNotFoundByPhone()
	{
		return "Kein Konto gefunden. Bitte versuche es mit einer anderen Handynummer.";
	}

	protected override string _GetTemplateForMessageAccountRecoveryUnknownError()
	{
		return "Systemfehler. Kontostatus konnte nicht wiederhergestellt werden.";
	}

	protected override string _GetTemplateForMessageCaptchaError()
	{
		return "Wir müssen sicherstellen, dass du kein Roboter bist!";
	}

	protected override string _GetTemplateForMessageCaptchaFailError()
	{
		return "Die von dir eingegebenen Wörter stimmen nicht mit dem Bild überein. Bitte versuche es erneut.";
	}

	protected override string _GetTemplateForMessageCredentialsError()
	{
		return "Dein Benutzername oder dein Passwort ist falsch. Bitte überprüfe beide und versuche es erneut.";
	}

	protected override string _GetTemplateForMessageFloodCheckedError()
	{
		return "Zu viele Versuche. Bitte versuche es später erneut.";
	}

	protected override string _GetTemplateForMessageForgotPasswordFeatureDisabled()
	{
		return "Feature ist derzeit deaktiviert. Bitte versuche es später erneut.";
	}

	protected override string _GetTemplateForMessageForgotPasswordSuccess()
	{
		return "Sieh in deinem E-Mail-Postfach nach, um Anweisungen zur Anmeldung zu erhalten.";
	}

	protected override string _GetTemplateForMessageInvalidAccountStatus()
	{
		return "Status des Kontos verhindert Zurücksetzen des Passworts.";
	}

	protected override string _GetTemplateForMessageInvalidPassword()
	{
		return "Ungültiges Passwort";
	}

	protected override string _GetTemplateForMessageInvalidTicket()
	{
		return "Wir konnten dieses Sicherheitsticket nicht laden.";
	}

	protected override string _GetTemplateForMessageInvalidUserNameOrEmail()
	{
		return "Ungültiger Benutzername oder es existiert keine E-Mail-Adresse.";
	}

	protected override string _GetTemplateForMessageMobileResetPasswordSuccess()
	{
		return "MobileResetPasswordSuccess";
	}

	protected override string _GetTemplateForMessageNoAccountsLinkedToEmail()
	{
		return "Mit dieser E-Mail-Adresse sind keine Konten verbunden.";
	}

	protected override string _GetTemplateForMessageOldUsernameError()
	{
		return "Du versuchst, dich mit einem Benutzernamen anzumelden, der geändert wurde. Bitte melde dich mit deinem neuen Benutzernamen an.";
	}

	protected override string _GetTemplateForMessagePasswordCannotBeUsed()
	{
		return "Entschuldigung, das Passwort kann nicht verwendet werden.";
	}

	/// <summary>
	/// Key: "MessagePasswordResetTicketExpired"
	/// English String: "Sorry, password reset requests expire {expirationHour} hours, {expirationMinute} minutes after issuance. Try requesting another password reset ticket again."
	/// </summary>
	public override string MessagePasswordResetTicketExpired(string expirationHour, string expirationMinute)
	{
		return $"Anfragen zum Zurücksetzen von Passwörtern laufen leider {expirationHour} St. und {expirationMinute} Min. nach Erteilung ab. Bitte sende uns ein neues Ticket zum Zurücksetzen deines Passworts.";
	}

	protected override string _GetTemplateForMessagePasswordResetTicketExpired()
	{
		return "Anfragen zum Zurücksetzen von Passwörtern laufen leider {expirationHour} St. und {expirationMinute} Min. nach Erteilung ab. Bitte sende uns ein neues Ticket zum Zurücksetzen deines Passworts.";
	}

	protected override string _GetTemplateForMessagePasswordsDoNotMatch()
	{
		return "Passwörter stimmen nicht überein";
	}

	protected override string _GetTemplateForMessageSamlUnauthenticated()
	{
		return "Du musst dich bei Roblox anmelden, um die Authentifizierung abzuschließen.";
	}

	protected override string _GetTemplateForMessageUnknownError()
	{
		return "Unbekannter Fehler";
	}

	protected override string _GetTemplateForMessageUnknownSystemError()
	{
		return "Systemfehler. Bitte kehre zum Anmeldefenster zurück.";
	}

	protected override string _GetTemplateForPlaceholderEmail()
	{
		return "E-Mail-Adresse";
	}

	/// <summary>
	/// Key: "Placeholder.EnterCode"
	/// English String: "Enter Code ({codeLength}-digit)"
	/// </summary>
	public override string PlaceholderEnterCode(string codeLength)
	{
		return $"Code eingeben ({codeLength}-stellig)";
	}

	protected override string _GetTemplateForPlaceholderEnterCode()
	{
		return "Code eingeben ({codeLength}-stellig)";
	}

	protected override string _GetTemplateForPlaceholderPhoneNumber()
	{
		return "Handynummer";
	}

	protected override string _GetTemplateForResponsePasswordResetSuccess()
	{
		return "Passwortrücksetzung abgeschlossen! Bitte melde dich erneut an.";
	}

	protected override string _GetTemplateForResponseSuccess()
	{
		return "Erfolg";
	}

	protected override string _GetTemplateForResponseUpdatePasswordFlooded()
	{
		return "Zu viele Versuche. Bitte versuche es später erneut.";
	}

	protected override string _GetTemplateForResponseUpdatePasswordIncorrect()
	{
		return "Dein aktuelles Passwort ist falsch, das Passwort wurde nicht geändert.";
	}

	protected override string _GetTemplateForResponseUpdatePasswordInputMissing()
	{
		return "Neues Passwort muss eingegeben und bestätigt werden.";
	}

	protected override string _GetTemplateForResponseUpdatePasswordMismatch()
	{
		return "Dein neues Passwort und das bestätigte Passwort müssen übereinstimmen.";
	}
}
