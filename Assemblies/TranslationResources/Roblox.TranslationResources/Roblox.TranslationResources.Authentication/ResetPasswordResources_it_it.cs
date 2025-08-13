namespace Roblox.TranslationResources.Authentication;

/// <summary>
/// This class overrides ResetPasswordResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ResetPasswordResources_it_it : ResetPasswordResources_en_us, IResetPasswordResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "Annulla";

	/// <summary>
	/// Key: "Action.EmailToResetPassword"
	/// English String: "Use email to reset password"
	/// </summary>
	public override string ActionEmailToResetPassword => "Usa l'e-mail per reimpostare la password";

	/// <summary>
	/// Key: "Action.EmailToRetriveUsername"
	/// English String: "Use email to retrieve username"
	/// </summary>
	public override string ActionEmailToRetriveUsername => "Usa l'e-mail per recuperare il nome utente";

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
	public override string ActionPhoneToResetPassword => "Usa il numero di telefono per reimpostare la password";

	/// <summary>
	/// Key: "Action.PhoneToRetriveUsername"
	/// English String: "Use phone number to retrieve username"
	/// </summary>
	public override string ActionPhoneToRetriveUsername => "Usa il numero di telefono per recuperare il nome utente";

	/// <summary>
	/// Key: "Action.Verify"
	/// English String: "Verify"
	/// </summary>
	public override string ActionVerify => "Verifica";

	/// <summary>
	/// Key: "Description.EmailToResetPassword"
	/// English String: "Enter your email to reset your password."
	/// </summary>
	public override string DescriptionEmailToResetPassword => "Inserisci il tuo indirizzo e-mail per reimpostare la password.";

	/// <summary>
	/// Key: "Description.EmailToRetriveUsername"
	/// English String: "Enter your email to retrieve your username."
	/// </summary>
	public override string DescriptionEmailToRetriveUsername => "Inserisci il tuo indirizzo e-mail per recuperare il nome utente.";

	/// <summary>
	/// Key: "Description.PasswordChangeEmail.Subject"
	/// email subject to change password
	/// English String: "Roblox Password Reset"
	/// </summary>
	public override string DescriptionPasswordChangeEmailSubject => "Reimpostazione password Roblox";

	/// <summary>
	/// Key: "Description.PasswordResetEmail.Subject"
	/// Subject for password reset email
	/// English String: "Roblox Account Password Reset"
	/// </summary>
	public override string DescriptionPasswordResetEmailSubject => "Reimpostazione password account Roblox";

	/// <summary>
	/// Key: "Description.PhoneToResetPassword"
	/// English String: "Enter your phone number to reset your password."
	/// </summary>
	public override string DescriptionPhoneToResetPassword => "Inserisci il tuo numero di telefono per reimpostare la password.";

	/// <summary>
	/// Key: "Description.PhoneToRetriveUsername"
	/// English String: "Enter your phone number to retrieve your username."
	/// </summary>
	public override string DescriptionPhoneToRetriveUsername => "Inserisci il tuo numero di telefono per recuperare il nome utente.";

	/// <summary>
	/// Key: "Heading.VerifyCode"
	/// verify code heading
	/// English String: "Verify Code"
	/// </summary>
	public override string HeadingVerifyCode => "Verifica codice";

	/// <summary>
	/// Key: "Heading.VerifyPhone"
	/// English String: "Verify Phone"
	/// </summary>
	public override string HeadingVerifyPhone => "Verifica cellulare";

	/// <summary>
	/// Key: "HeadingForgetPasswordOrUsername"
	/// English String: "Forgot Password or Username"
	/// </summary>
	public override string HeadingForgetPasswordOrUsername => "Password o nome utente dimenticati";

	/// <summary>
	/// Key: "Label.ActionButtonYes"
	/// button label
	/// English String: "Yes"
	/// </summary>
	public override string LabelActionButtonYes => "Sì";

	/// <summary>
	/// Key: "Label.ForgetMyPassword"
	/// English String: "Forgot My Password"
	/// </summary>
	public override string LabelForgetMyPassword => "Ho dimenticato la password";

	/// <summary>
	/// Key: "Label.ForgetMyUsername"
	/// English String: "Forgot My Username"
	/// </summary>
	public override string LabelForgetMyUsername => "Ho dimenticato il nome utente";

	/// <summary>
	/// Key: "Label.InvalidEmail"
	/// English String: "Invalid email"
	/// </summary>
	public override string LabelInvalidEmail => "E-mail non valida";

	/// <summary>
	/// Key: "Label.InvalidPhoneNumber"
	/// English String: "Invalid phone number"
	/// </summary>
	public override string LabelInvalidPhoneNumber => "Numero di telefono non valido";

	/// <summary>
	/// Key: "Label.NeutralButtonOk"
	/// ok button label
	/// English String: "OK"
	/// </summary>
	public override string LabelNeutralButtonOk => "OK";

	/// <summary>
	/// Key: "Label.Password"
	/// label
	/// English String: "Password"
	/// </summary>
	public override string LabelPassword => "Password";

	/// <summary>
	/// Key: "Label.ResendCode"
	/// English String: "Resend Code"
	/// </summary>
	public override string LabelResendCode => "Invia nuovamente il codice";

	/// <summary>
	/// Key: "Label.Submit"
	/// English String: "Submit"
	/// </summary>
	public override string LabelSubmit => "Invia";

	/// <summary>
	/// Key: "Label.ToolTip.WhoCanFindMeByPhone"
	/// English String: "This setting controls who can find you using the phone number you provided."
	/// </summary>
	public override string LabelToolTipWhoCanFindMeByPhone => "Con questa impostazione controlli chi può trovarti tramite il numero di telefono che hai fornito.";

	/// <summary>
	/// Key: "Label.Username"
	/// English String: "Username"
	/// </summary>
	public override string LabelUsername => "Nome utente";

	/// <summary>
	/// Key: "Label.WhoCanFindMeByPhone"
	/// English String: "Who can find me by my phone number?"
	/// </summary>
	public override string LabelWhoCanFindMeByPhone => "Chi può trovarmi tramite il mio numero di telefono?";

	/// <summary>
	/// Key: "Message.DefaultError"
	/// English String: "An error occurred, try again later."
	/// </summary>
	public override string MessageDefaultError => "Si è verificato un errore. Riprova più tardi.";

	/// <summary>
	/// Key: "Message.EmailForUsernameSuccessBody"
	/// success message
	/// English String: "An email with your username(s) has been sent to you if the email was previously saved on your account."
	/// </summary>
	public override string MessageEmailForUsernameSuccessBody => "Se il tuo indirizzo e-mail è stato già salvato sul tuo account, riceverai un'e-mail con il tuo/i tuoi nome/i utente.";

	/// <summary>
	/// Key: "Message.EmailSuccessBody"
	/// English String: "An email with instructions has been sent to you if the email was previously saved on your account."
	/// </summary>
	public override string MessageEmailSuccessBody => "Se il tuo indirizzo e-mail è stato già salvato sul tuo account, riceverai un'e-mail con le istruzioni.";

	/// <summary>
	/// Key: "Message.EmailSuccessTitle"
	/// English String: "Email Sent"
	/// </summary>
	public override string MessageEmailSuccessTitle => "E-mail inviata";

	/// <summary>
	/// Key: "Message.EnterCode"
	/// English String: "A code was sent to your phone if it was previously verified on your account. Please enter it below"
	/// </summary>
	public override string MessageEnterCode => "Se il tuo numero di telefono è già stato verificato sul tuo account, riceverai un codice. Inseriscilo qui sotto";

	/// <summary>
	/// Key: "Message.EnterCodeSentToEmail"
	/// Enter the code we just sent to your email.
	/// English String: "Enter the code we just sent to your email."
	/// </summary>
	public override string MessageEnterCodeSentToEmail => "Inserisci il codice che ti abbiamo inviato tramite e-mail.";

	/// <summary>
	/// Key: "Message.PhoneForUsernameSuccessBody"
	/// English String: "An SMS with your username(s) has been sent to you if the phone number was previously verified on your account."
	/// </summary>
	public override string MessagePhoneForUsernameSuccessBody => "Se il numero di telefono è già stato verificato sul tuo account, ti abbiamo inviato un SMS con i tuoi nomi utente.";

	/// <summary>
	/// Key: "Message.PhoneForUsernameSuccessTitle"
	/// English String: "SMS Sent"
	/// </summary>
	public override string MessagePhoneForUsernameSuccessTitle => "SMS inviato";

	/// <summary>
	/// Key: "MessageAccountDoesNotHaveAnEmail"
	/// English String: "There is no email linked to this account"
	/// </summary>
	public override string MessageAccountDoesNotHaveAnEmail => "Non c'è alcun indirizzo e-mail collegato a questo account";

	/// <summary>
	/// Key: "MessageAccountNotFoundByEmail"
	/// No account found. Please use a different email.
	/// English String: "No account found. Please use a different email."
	/// </summary>
	public override string MessageAccountNotFoundByEmail => "Account non trovato. Utilizza un indirizzo e-mail diverso.";

	/// <summary>
	/// Key: "MessageAccountNotFoundByPhone"
	/// No account found. Please use a different phone number.
	/// English String: "No account found. Please use a different phone number."
	/// </summary>
	public override string MessageAccountNotFoundByPhone => "Account non trovato. Utilizza un numero di telefono diverso.";

	/// <summary>
	/// Key: "MessageAccountRecoveryUnknownError"
	/// English String: "System error. Account could not be restored to this state."
	/// </summary>
	public override string MessageAccountRecoveryUnknownError => "Errore di sistema. Lo stato dell'account non può essere ripristinato.";

	/// <summary>
	/// Key: "MessageCaptchaError"
	/// English String: "We need to make sure you're not a robot!"
	/// </summary>
	public override string MessageCaptchaError => "Dobbiamo assicurarci che tu non sia un robot!";

	/// <summary>
	/// Key: "MessageCaptchaFailError"
	/// English String: "The words you typed didn't match the picture. Please try again."
	/// </summary>
	public override string MessageCaptchaFailError => "Le parole che hai digitato non corrispondono all'immagine. Riprova.";

	/// <summary>
	/// Key: "MessageCredentialsError"
	/// English String: "Your username or password is incorrect. Please check them and try again."
	/// </summary>
	public override string MessageCredentialsError => "La password o il nome utente non sono corretti. Controlla e prova di nuovo.";

	/// <summary>
	/// Key: "MessageFloodCheckedError"
	/// English String: "Too many attempts. Please try again later."
	/// </summary>
	public override string MessageFloodCheckedError => "Troppi tentativi. Riprova più tardi.";

	/// <summary>
	/// Key: "MessageForgotPasswordFeatureDisabled"
	/// English String: "Feature temporarily disabled. Please try again later."
	/// </summary>
	public override string MessageForgotPasswordFeatureDisabled => "Funzione temporaneamente disattivata. Riprova più tardi.";

	/// <summary>
	/// Key: "MessageForgotPasswordSuccess"
	/// English String: "Check your email for login instructions"
	/// </summary>
	public override string MessageForgotPasswordSuccess => "Controlla la tua e-mail per le istruzioni sull'accesso";

	/// <summary>
	/// Key: "MessageInvalidAccountStatus"
	/// English String: "Account status prevents resetting password"
	/// </summary>
	public override string MessageInvalidAccountStatus => "Lo stato dell'account impedisce di reimpostare la password";

	/// <summary>
	/// Key: "MessageInvalidPassword"
	/// English String: "Invalid password"
	/// </summary>
	public override string MessageInvalidPassword => "Password non valida";

	/// <summary>
	/// Key: "MessageInvalidTicket"
	/// English String: "We couldn't load this security ticket."
	/// </summary>
	public override string MessageInvalidTicket => "Non è stato possibile caricare questo ticket di sicurezza.";

	/// <summary>
	/// Key: "MessageInvalidUserNameOrEmail"
	/// English String: "Invalid username, or no email exists"
	/// </summary>
	public override string MessageInvalidUserNameOrEmail => "Nome utente non valido o e-mail inesistente";

	/// <summary>
	/// Key: "MessageMobileResetPasswordSuccess"
	/// English String: "MobileResetPasswordSuccess"
	/// </summary>
	public override string MessageMobileResetPasswordSuccess => "MobileResetPasswordSuccess";

	/// <summary>
	/// Key: "MessageNoAccountsLinkedToEmail"
	/// English String: "There are no accounts linked to this email address"
	/// </summary>
	public override string MessageNoAccountsLinkedToEmail => "Non ci sono account collegati a questo indirizzo e-mail";

	/// <summary>
	/// Key: "MessageOldUsernameError"
	/// English String: "It looks like you are trying to log in with a username that has changed. Please log in with your new username."
	/// </summary>
	public override string MessageOldUsernameError => "Stai cercando di accedere con un nome utente che è stato modificato. Usa il nuovo nome utente.";

	/// <summary>
	/// Key: "MessagePasswordCannotBeUsed"
	/// English String: "Sorry, that password cannot be used."
	/// </summary>
	public override string MessagePasswordCannotBeUsed => "Spiacenti, quella password non può essere usata.";

	/// <summary>
	/// Key: "MessagePasswordsDoNotMatch"
	/// English String: "Passwords do not match"
	/// </summary>
	public override string MessagePasswordsDoNotMatch => "Le password non coincidono";

	/// <summary>
	/// Key: "MessageSamlUnauthenticated"
	/// English String: "You must log in to Roblox to finish authenticating."
	/// </summary>
	public override string MessageSamlUnauthenticated => "Devi accedere a Roblox per terminare l'autenticazione.";

	/// <summary>
	/// Key: "MessageUnknownError"
	/// English String: "Unknown Error"
	/// </summary>
	public override string MessageUnknownError => "Errore imprevisto";

	/// <summary>
	/// Key: "MessageUnknownSystemError"
	/// English String: "System error. Please return to login screen."
	/// </summary>
	public override string MessageUnknownSystemError => "Errore di sistema. Torna alla schermata di accesso.";

	/// <summary>
	/// Key: "Placeholder.Email"
	/// English String: "Email"
	/// </summary>
	public override string PlaceholderEmail => "E-mail";

	/// <summary>
	/// Key: "Placeholder.PhoneNumber"
	/// English String: "Phone Number"
	/// </summary>
	public override string PlaceholderPhoneNumber => "Numero di telefono";

	/// <summary>
	/// Key: "Response.PasswordResetSuccess"
	/// Password reset success! Please login again.
	/// English String: "Password reset success! Please login again."
	/// </summary>
	public override string ResponsePasswordResetSuccess => "Password reimpostata! Accedi di nuovo.";

	/// <summary>
	/// Key: "Response.Success"
	/// English String: "Success"
	/// </summary>
	public override string ResponseSuccess => "Successo";

	/// <summary>
	/// Key: "Response.UpdatePasswordFlooded"
	/// English String: "Too many attempts. Please try again later."
	/// </summary>
	public override string ResponseUpdatePasswordFlooded => "Troppi tentativi. Riprova più tardi.";

	/// <summary>
	/// Key: "Response.UpdatePasswordIncorrect"
	/// English String: "Your current password is incorrect, the password was not changed."
	/// </summary>
	public override string ResponseUpdatePasswordIncorrect => "La tua password attuale non è corretta. La password non è cambiata.";

	/// <summary>
	/// Key: "Response.UpdatePasswordInputMissing"
	/// English String: "Must include new password and confirm password"
	/// </summary>
	public override string ResponseUpdatePasswordInputMissing => "Devi includere una nuova password e confermarla.";

	/// <summary>
	/// Key: "Response.UpdatePasswordMismatch"
	/// English String: "Your new password and confirm password must match"
	/// </summary>
	public override string ResponseUpdatePasswordMismatch => "La nuova password e la password di conferma devono essere identiche.";

	public ResetPasswordResources_it_it(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "Annulla";
	}

	protected override string _GetTemplateForActionEmailToResetPassword()
	{
		return "Usa l'e-mail per reimpostare la password";
	}

	protected override string _GetTemplateForActionEmailToRetriveUsername()
	{
		return "Usa l'e-mail per recuperare il nome utente";
	}

	protected override string _GetTemplateForActionOk()
	{
		return "OK";
	}

	protected override string _GetTemplateForActionPhoneToResetPassword()
	{
		return "Usa il numero di telefono per reimpostare la password";
	}

	protected override string _GetTemplateForActionPhoneToRetriveUsername()
	{
		return "Usa il numero di telefono per recuperare il nome utente";
	}

	protected override string _GetTemplateForActionVerify()
	{
		return "Verifica";
	}

	/// <summary>
	/// Key: "Description.ChangePasswordEmail.HtmlBody1"
	/// email body for change password email
	/// English String: "We noticed that the password changed for your Roblox account: {userName}. If you didn't intend to change it, or you think someone else changed it by mistake, please click this link to undo the action:{lineBreak} {actionLink} {lineBreak}{lineBreak}If you are happy with your new Roblox password, you don't have to do anything! It's already set up. Please do not reply to this message. If you have any questions, please see the Roblox help page (https://www.roblox.com/help)."
	/// </summary>
	public override string DescriptionChangePasswordEmailHtmlBody1(string userName, string lineBreak, string actionLink)
	{
		return $"Abbiamo notato che è cambiata la password del tuo account Roblox: {userName}. Se non era tua intenzione cambiarla, o se pensi che sia stata cambiata per sbaglio da qualcun altro, fai clic su questo link per annullare l'azione:{lineBreak} {actionLink} {lineBreak}{lineBreak}Se, invece, la modifica della password Roblox è stata intenzionale, non devi fare nient'altro! La password è già stata reimpostata. Non rispondere a questo messaggio. Per qualsiasi domanda, vai alla pagina di aiuto di Roblox (https://www.roblox.com/help).";
	}

	protected override string _GetTemplateForDescriptionChangePasswordEmailHtmlBody1()
	{
		return "Abbiamo notato che è cambiata la password del tuo account Roblox: {userName}. Se non era tua intenzione cambiarla, o se pensi che sia stata cambiata per sbaglio da qualcun altro, fai clic su questo link per annullare l'azione:{lineBreak} {actionLink} {lineBreak}{lineBreak}Se, invece, la modifica della password Roblox è stata intenzionale, non devi fare nient'altro! La password è già stata reimpostata. Non rispondere a questo messaggio. Per qualsiasi domanda, vai alla pagina di aiuto di Roblox (https://www.roblox.com/help).";
	}

	protected override string _GetTemplateForDescriptionEmailToResetPassword()
	{
		return "Inserisci il tuo indirizzo e-mail per reimpostare la password.";
	}

	protected override string _GetTemplateForDescriptionEmailToRetriveUsername()
	{
		return "Inserisci il tuo indirizzo e-mail per recuperare il nome utente.";
	}

	/// <summary>
	/// Key: "Description.PasswordChangeEmail.BodyPlainText"
	/// password reset plaintext email message
	/// English String: "We noticed that the password changed for your Roblox account: {userName}. If you didn't intend to change it, or you think someone else changed it by mistake, please click this link to undo the action:\n{urlWithTicket}\n\nIf you are happy with your new Roblox password, you don't have to do anything! It's already set up. Please do not reply to this message. If you have any questions, please see the Roblox help page (https://www.roblox.com/help)."
	/// </summary>
	public override string DescriptionPasswordChangeEmailBodyPlainText(string userName, string urlWithTicket)
	{
		return $"Abbiamo notato che è cambiata la password del tuo account Roblox: {userName}. Se non era tua intenzione cambiarla, o se pensi che sia stata cambiata per sbaglio da qualcun altro, fai clic su questo link per annullare l'azione:\n{urlWithTicket}\n\nSe, invece, la modifica della password Roblox è stata intenzionale, non devi fare nient'altro! La password è già stata reimpostata. Non rispondere a questo messaggio. Per qualsiasi domanda, vai alla pagina di aiuto di Roblox (https://www.roblox.com/help).";
	}

	protected override string _GetTemplateForDescriptionPasswordChangeEmailBodyPlainText()
	{
		return "Abbiamo notato che è cambiata la password del tuo account Roblox: {userName}. Se non era tua intenzione cambiarla, o se pensi che sia stata cambiata per sbaglio da qualcun altro, fai clic su questo link per annullare l'azione:\n{urlWithTicket}\n\nSe, invece, la modifica della password Roblox è stata intenzionale, non devi fare nient'altro! La password è già stata reimpostata. Non rispondere a questo messaggio. Per qualsiasi domanda, vai alla pagina di aiuto di Roblox (https://www.roblox.com/help).";
	}

	/// <summary>
	/// Key: "Description.PasswordChangeEmail.From"
	/// name of the sender as shown in from field of the email
	/// English String: "\"Roblox Password Reset\" {fromEmailAddress}"
	/// </summary>
	public override string DescriptionPasswordChangeEmailFrom(string fromEmailAddress)
	{
		return $"\"Reimpostazione password Roblox\" {fromEmailAddress}";
	}

	protected override string _GetTemplateForDescriptionPasswordChangeEmailFrom()
	{
		return "\"Reimpostazione password Roblox\" {fromEmailAddress}";
	}

	protected override string _GetTemplateForDescriptionPasswordChangeEmailSubject()
	{
		return "Reimpostazione password Roblox";
	}

	/// <summary>
	/// Key: "Description.PasswordResetEmail.From"
	/// The "From" field for the password reset email
	/// English String: "{escapeLiteralStart}Roblox Password Reset{escapeLiteralEnd} {fromEmailAddress}"
	/// </summary>
	public override string DescriptionPasswordResetEmailFrom(string escapeLiteralStart, string escapeLiteralEnd, string fromEmailAddress)
	{
		return $"{escapeLiteralStart}Reimpostazione password Roblox{escapeLiteralEnd} {fromEmailAddress}";
	}

	protected override string _GetTemplateForDescriptionPasswordResetEmailFrom()
	{
		return "{escapeLiteralStart}Reimpostazione password Roblox{escapeLiteralEnd} {fromEmailAddress}";
	}

	/// <summary>
	/// Key: "Description.PasswordResetEmail.HtmlBody"
	/// This email is sent when a user requests a password reset.
	/// English String: "We have received a request to reset the password for your Roblox account: {emailOrUsername}{lineBreak}{lineBreak}If you submitted this request, please click the button below to proceed.{lineBreak}This button will be active for {passwordResetTicketHours} hours, {passwordResetTicketMinutes} minutes. If you do not wish to reset your password, please disregard this notice.{lineBreak}{lineBreak}{aTagWithStartHref}{resetPasswordUrl}{hrefEnd}{buttonStart}Reset Password{buttonEnd}{aTagEnd}"
	/// </summary>
	public override string DescriptionPasswordResetEmailHtmlBody(string emailOrUsername, string lineBreak, string passwordResetTicketHours, string passwordResetTicketMinutes, string aTagWithStartHref, string resetPasswordUrl, string hrefEnd, string buttonStart, string buttonEnd, string aTagEnd)
	{
		return $"Abbiamo ricevuto una richiesta di reimpostazione della password per il tuo account Roblox: {emailOrUsername}{lineBreak}{lineBreak}Se sei stato tu a inviarla, fai clic sul pulsante sottostante per procedere.{lineBreak}Il pulsante rimarrà attivo per {passwordResetTicketHours} ore e {passwordResetTicketMinutes} minuti. Se non desideri reimpostare la password, ignora questo messaggio.{lineBreak}{lineBreak}{aTagWithStartHref}{resetPasswordUrl}{hrefEnd}{buttonStart}Reimposta password{buttonEnd}{aTagEnd}";
	}

	protected override string _GetTemplateForDescriptionPasswordResetEmailHtmlBody()
	{
		return "Abbiamo ricevuto una richiesta di reimpostazione della password per il tuo account Roblox: {emailOrUsername}{lineBreak}{lineBreak}Se sei stato tu a inviarla, fai clic sul pulsante sottostante per procedere.{lineBreak}Il pulsante rimarrà attivo per {passwordResetTicketHours} ore e {passwordResetTicketMinutes} minuti. Se non desideri reimpostare la password, ignora questo messaggio.{lineBreak}{lineBreak}{aTagWithStartHref}{resetPasswordUrl}{hrefEnd}{buttonStart}Reimposta password{buttonEnd}{aTagEnd}";
	}

	/// <summary>
	/// Key: "Description.PasswordResetEmail.PlainBody"
	/// This email is sent when a user requests a password reset.
	/// English String: "We have received a request to reset the password for your Roblox account: {emailOrUsername}{lineBreak}{lineBreak}If you submitted this request, please click the link below or paste it into a web browser to proceed.{lineBreak}This link will be active for {passwordResetTicketHours} hours, {passwordResetTicketMinutes} minutes. If you do not wish to reset your password, please disregard this notice.{lineBreak}{lineBreak}{resetPasswordUrl}"
	/// </summary>
	public override string DescriptionPasswordResetEmailPlainBody(string emailOrUsername, string lineBreak, string passwordResetTicketHours, string passwordResetTicketMinutes, string resetPasswordUrl)
	{
		return $"Abbiamo ricevuto una richiesta di reimpostazione della password per il tuo account Roblox: {emailOrUsername}{lineBreak}{lineBreak}Se sei stato tu a inviarla, fai clic sul link sottostante oppure copialo e incollalo in un browser Web per procedere.{lineBreak}Il link rimarrà attivo per {passwordResetTicketHours} ore e {passwordResetTicketMinutes} minuti. Se non desideri reimpostare la password, ignora questo messaggio.{lineBreak}{lineBreak}{resetPasswordUrl}";
	}

	protected override string _GetTemplateForDescriptionPasswordResetEmailPlainBody()
	{
		return "Abbiamo ricevuto una richiesta di reimpostazione della password per il tuo account Roblox: {emailOrUsername}{lineBreak}{lineBreak}Se sei stato tu a inviarla, fai clic sul link sottostante oppure copialo e incollalo in un browser Web per procedere.{lineBreak}Il link rimarrà attivo per {passwordResetTicketHours} ore e {passwordResetTicketMinutes} minuti. Se non desideri reimpostare la password, ignora questo messaggio.{lineBreak}{lineBreak}{resetPasswordUrl}";
	}

	protected override string _GetTemplateForDescriptionPasswordResetEmailSubject()
	{
		return "Reimpostazione password account Roblox";
	}

	protected override string _GetTemplateForDescriptionPhoneToResetPassword()
	{
		return "Inserisci il tuo numero di telefono per reimpostare la password.";
	}

	protected override string _GetTemplateForDescriptionPhoneToRetriveUsername()
	{
		return "Inserisci il tuo numero di telefono per recuperare il nome utente.";
	}

	protected override string _GetTemplateForHeadingVerifyCode()
	{
		return "Verifica codice";
	}

	protected override string _GetTemplateForHeadingVerifyPhone()
	{
		return "Verifica cellulare";
	}

	protected override string _GetTemplateForHeadingForgetPasswordOrUsername()
	{
		return "Password o nome utente dimenticati";
	}

	protected override string _GetTemplateForLabelActionButtonYes()
	{
		return "Sì";
	}

	protected override string _GetTemplateForLabelForgetMyPassword()
	{
		return "Ho dimenticato la password";
	}

	protected override string _GetTemplateForLabelForgetMyUsername()
	{
		return "Ho dimenticato il nome utente";
	}

	protected override string _GetTemplateForLabelInvalidEmail()
	{
		return "E-mail non valida";
	}

	protected override string _GetTemplateForLabelInvalidPhoneNumber()
	{
		return "Numero di telefono non valido";
	}

	protected override string _GetTemplateForLabelNeutralButtonOk()
	{
		return "OK";
	}

	protected override string _GetTemplateForLabelPassword()
	{
		return "Password";
	}

	protected override string _GetTemplateForLabelResendCode()
	{
		return "Invia nuovamente il codice";
	}

	protected override string _GetTemplateForLabelSubmit()
	{
		return "Invia";
	}

	protected override string _GetTemplateForLabelToolTipWhoCanFindMeByPhone()
	{
		return "Con questa impostazione controlli chi può trovarti tramite il numero di telefono che hai fornito.";
	}

	protected override string _GetTemplateForLabelUsername()
	{
		return "Nome utente";
	}

	protected override string _GetTemplateForLabelWhoCanFindMeByPhone()
	{
		return "Chi può trovarmi tramite il mio numero di telefono?";
	}

	/// <summary>
	/// Key: "Message.CantSendEmailWarning"
	/// English String: "If you did not give us a {styleStart}real email address{styleEnd} when you created your account, we cannot send you an email."
	/// </summary>
	public override string MessageCantSendEmailWarning(string styleStart, string styleEnd)
	{
		return $"Se non hai fornito un {styleStart}indirizzo e-mail reale{styleEnd} quando hai creato l'account, non possiamo inviarti un'e-mail.";
	}

	protected override string _GetTemplateForMessageCantSendEmailWarning()
	{
		return "Se non hai fornito un {styleStart}indirizzo e-mail reale{styleEnd} quando hai creato l'account, non possiamo inviarti un'e-mail.";
	}

	protected override string _GetTemplateForMessageDefaultError()
	{
		return "Si è verificato un errore. Riprova più tardi.";
	}

	protected override string _GetTemplateForMessageEmailForUsernameSuccessBody()
	{
		return "Se il tuo indirizzo e-mail è stato già salvato sul tuo account, riceverai un'e-mail con il tuo/i tuoi nome/i utente.";
	}

	protected override string _GetTemplateForMessageEmailSuccessBody()
	{
		return "Se il tuo indirizzo e-mail è stato già salvato sul tuo account, riceverai un'e-mail con le istruzioni.";
	}

	protected override string _GetTemplateForMessageEmailSuccessTitle()
	{
		return "E-mail inviata";
	}

	protected override string _GetTemplateForMessageEnterCode()
	{
		return "Se il tuo numero di telefono è già stato verificato sul tuo account, riceverai un codice. Inseriscilo qui sotto";
	}

	protected override string _GetTemplateForMessageEnterCodeSentToEmail()
	{
		return "Inserisci il codice che ti abbiamo inviato tramite e-mail.";
	}

	protected override string _GetTemplateForMessagePhoneForUsernameSuccessBody()
	{
		return "Se il numero di telefono è già stato verificato sul tuo account, ti abbiamo inviato un SMS con i tuoi nomi utente.";
	}

	protected override string _GetTemplateForMessagePhoneForUsernameSuccessTitle()
	{
		return "SMS inviato";
	}

	protected override string _GetTemplateForMessageAccountDoesNotHaveAnEmail()
	{
		return "Non c'è alcun indirizzo e-mail collegato a questo account";
	}

	protected override string _GetTemplateForMessageAccountNotFoundByEmail()
	{
		return "Account non trovato. Utilizza un indirizzo e-mail diverso.";
	}

	protected override string _GetTemplateForMessageAccountNotFoundByPhone()
	{
		return "Account non trovato. Utilizza un numero di telefono diverso.";
	}

	protected override string _GetTemplateForMessageAccountRecoveryUnknownError()
	{
		return "Errore di sistema. Lo stato dell'account non può essere ripristinato.";
	}

	protected override string _GetTemplateForMessageCaptchaError()
	{
		return "Dobbiamo assicurarci che tu non sia un robot!";
	}

	protected override string _GetTemplateForMessageCaptchaFailError()
	{
		return "Le parole che hai digitato non corrispondono all'immagine. Riprova.";
	}

	protected override string _GetTemplateForMessageCredentialsError()
	{
		return "La password o il nome utente non sono corretti. Controlla e prova di nuovo.";
	}

	protected override string _GetTemplateForMessageFloodCheckedError()
	{
		return "Troppi tentativi. Riprova più tardi.";
	}

	protected override string _GetTemplateForMessageForgotPasswordFeatureDisabled()
	{
		return "Funzione temporaneamente disattivata. Riprova più tardi.";
	}

	protected override string _GetTemplateForMessageForgotPasswordSuccess()
	{
		return "Controlla la tua e-mail per le istruzioni sull'accesso";
	}

	protected override string _GetTemplateForMessageInvalidAccountStatus()
	{
		return "Lo stato dell'account impedisce di reimpostare la password";
	}

	protected override string _GetTemplateForMessageInvalidPassword()
	{
		return "Password non valida";
	}

	protected override string _GetTemplateForMessageInvalidTicket()
	{
		return "Non è stato possibile caricare questo ticket di sicurezza.";
	}

	protected override string _GetTemplateForMessageInvalidUserNameOrEmail()
	{
		return "Nome utente non valido o e-mail inesistente";
	}

	protected override string _GetTemplateForMessageMobileResetPasswordSuccess()
	{
		return "MobileResetPasswordSuccess";
	}

	protected override string _GetTemplateForMessageNoAccountsLinkedToEmail()
	{
		return "Non ci sono account collegati a questo indirizzo e-mail";
	}

	protected override string _GetTemplateForMessageOldUsernameError()
	{
		return "Stai cercando di accedere con un nome utente che è stato modificato. Usa il nuovo nome utente.";
	}

	protected override string _GetTemplateForMessagePasswordCannotBeUsed()
	{
		return "Spiacenti, quella password non può essere usata.";
	}

	/// <summary>
	/// Key: "MessagePasswordResetTicketExpired"
	/// English String: "Sorry, password reset requests expire {expirationHour} hours, {expirationMinute} minutes after issuance. Try requesting another password reset ticket again."
	/// </summary>
	public override string MessagePasswordResetTicketExpired(string expirationHour, string expirationMinute)
	{
		return $"Spiacenti, le richieste per reimpostare la password scadono {expirationHour} ore e {expirationMinute} minuti dopo l'inoltro. Prova a inviare un'altra richiesta.";
	}

	protected override string _GetTemplateForMessagePasswordResetTicketExpired()
	{
		return "Spiacenti, le richieste per reimpostare la password scadono {expirationHour} ore e {expirationMinute} minuti dopo l'inoltro. Prova a inviare un'altra richiesta.";
	}

	protected override string _GetTemplateForMessagePasswordsDoNotMatch()
	{
		return "Le password non coincidono";
	}

	protected override string _GetTemplateForMessageSamlUnauthenticated()
	{
		return "Devi accedere a Roblox per terminare l'autenticazione.";
	}

	protected override string _GetTemplateForMessageUnknownError()
	{
		return "Errore imprevisto";
	}

	protected override string _GetTemplateForMessageUnknownSystemError()
	{
		return "Errore di sistema. Torna alla schermata di accesso.";
	}

	protected override string _GetTemplateForPlaceholderEmail()
	{
		return "E-mail";
	}

	/// <summary>
	/// Key: "Placeholder.EnterCode"
	/// English String: "Enter Code ({codeLength}-digit)"
	/// </summary>
	public override string PlaceholderEnterCode(string codeLength)
	{
		return $"Inserisci il codice ({codeLength} cifre)";
	}

	protected override string _GetTemplateForPlaceholderEnterCode()
	{
		return "Inserisci il codice ({codeLength} cifre)";
	}

	protected override string _GetTemplateForPlaceholderPhoneNumber()
	{
		return "Numero di telefono";
	}

	protected override string _GetTemplateForResponsePasswordResetSuccess()
	{
		return "Password reimpostata! Accedi di nuovo.";
	}

	protected override string _GetTemplateForResponseSuccess()
	{
		return "Successo";
	}

	protected override string _GetTemplateForResponseUpdatePasswordFlooded()
	{
		return "Troppi tentativi. Riprova più tardi.";
	}

	protected override string _GetTemplateForResponseUpdatePasswordIncorrect()
	{
		return "La tua password attuale non è corretta. La password non è cambiata.";
	}

	protected override string _GetTemplateForResponseUpdatePasswordInputMissing()
	{
		return "Devi includere una nuova password e confermarla.";
	}

	protected override string _GetTemplateForResponseUpdatePasswordMismatch()
	{
		return "La nuova password e la password di conferma devono essere identiche.";
	}
}
