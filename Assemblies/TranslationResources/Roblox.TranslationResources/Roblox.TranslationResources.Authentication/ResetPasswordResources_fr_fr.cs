namespace Roblox.TranslationResources.Authentication;

/// <summary>
/// This class overrides ResetPasswordResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ResetPasswordResources_fr_fr : ResetPasswordResources_en_us, IResetPasswordResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "Annuler";

	/// <summary>
	/// Key: "Action.EmailToResetPassword"
	/// English String: "Use email to reset password"
	/// </summary>
	public override string ActionEmailToResetPassword => "Réinitialiser le mot de passe à l'aide d'un e-mail";

	/// <summary>
	/// Key: "Action.EmailToRetriveUsername"
	/// English String: "Use email to retrieve username"
	/// </summary>
	public override string ActionEmailToRetriveUsername => "Récupérer le nom d'utilisateur à l'aide d'un e-mail";

	/// <summary>
	/// Key: "Action.Ok"
	/// OK
	/// English String: "OK"
	/// </summary>
	public override string ActionOk => "Ok";

	/// <summary>
	/// Key: "Action.PhoneToResetPassword"
	/// English String: "Use phone number to reset password"
	/// </summary>
	public override string ActionPhoneToResetPassword => "Réinitialiser le mot de passe à l'aide d'un numéro de téléphone";

	/// <summary>
	/// Key: "Action.PhoneToRetriveUsername"
	/// English String: "Use phone number to retrieve username"
	/// </summary>
	public override string ActionPhoneToRetriveUsername => "Récupérer le nom d'utilisateur à l'aide d'un numéro de téléphone";

	/// <summary>
	/// Key: "Action.Verify"
	/// English String: "Verify"
	/// </summary>
	public override string ActionVerify => "Vérifier";

	/// <summary>
	/// Key: "Description.EmailToResetPassword"
	/// English String: "Enter your email to reset your password."
	/// </summary>
	public override string DescriptionEmailToResetPassword => "Saisissez votre e-mail pour récupérer votre mot de passe.";

	/// <summary>
	/// Key: "Description.EmailToRetriveUsername"
	/// English String: "Enter your email to retrieve your username."
	/// </summary>
	public override string DescriptionEmailToRetriveUsername => "Saisissez votre e-mail pour récupérer votre nom d'utilisateur.";

	/// <summary>
	/// Key: "Description.PasswordChangeEmail.Subject"
	/// email subject to change password
	/// English String: "Roblox Password Reset"
	/// </summary>
	public override string DescriptionPasswordChangeEmailSubject => "Réinitialisation du mot de passe pour Roblox";

	/// <summary>
	/// Key: "Description.PasswordResetEmail.Subject"
	/// Subject for password reset email
	/// English String: "Roblox Account Password Reset"
	/// </summary>
	public override string DescriptionPasswordResetEmailSubject => "Réinitialiser mot de passe cu compte Roblox";

	/// <summary>
	/// Key: "Description.PhoneToResetPassword"
	/// English String: "Enter your phone number to reset your password."
	/// </summary>
	public override string DescriptionPhoneToResetPassword => "Saisissez votre numéro de téléphone pour récupérer votre mot de passe.";

	/// <summary>
	/// Key: "Description.PhoneToRetriveUsername"
	/// English String: "Enter your phone number to retrieve your username."
	/// </summary>
	public override string DescriptionPhoneToRetriveUsername => "Saisissez votre numéro de téléphone pour récupérer votre nom d'utilisateur.";

	/// <summary>
	/// Key: "Heading.VerifyCode"
	/// verify code heading
	/// English String: "Verify Code"
	/// </summary>
	public override string HeadingVerifyCode => "Vérifier le code";

	/// <summary>
	/// Key: "Heading.VerifyPhone"
	/// English String: "Verify Phone"
	/// </summary>
	public override string HeadingVerifyPhone => "Vérifier le téléphone";

	/// <summary>
	/// Key: "HeadingForgetPasswordOrUsername"
	/// English String: "Forgot Password or Username"
	/// </summary>
	public override string HeadingForgetPasswordOrUsername => "Mot de passe ou nom d'utilisateur oublié";

	/// <summary>
	/// Key: "Label.ActionButtonYes"
	/// button label
	/// English String: "Yes"
	/// </summary>
	public override string LabelActionButtonYes => "Oui";

	/// <summary>
	/// Key: "Label.ForgetMyPassword"
	/// English String: "Forgot My Password"
	/// </summary>
	public override string LabelForgetMyPassword => "Mot de passe oublié";

	/// <summary>
	/// Key: "Label.ForgetMyUsername"
	/// English String: "Forgot My Username"
	/// </summary>
	public override string LabelForgetMyUsername => "Nom d'utilisateur oublié";

	/// <summary>
	/// Key: "Label.InvalidEmail"
	/// English String: "Invalid email"
	/// </summary>
	public override string LabelInvalidEmail => "E-mail invalide";

	/// <summary>
	/// Key: "Label.InvalidPhoneNumber"
	/// English String: "Invalid phone number"
	/// </summary>
	public override string LabelInvalidPhoneNumber => "Numéro de téléphone invalide";

	/// <summary>
	/// Key: "Label.NeutralButtonOk"
	/// ok button label
	/// English String: "OK"
	/// </summary>
	public override string LabelNeutralButtonOk => "Ok";

	/// <summary>
	/// Key: "Label.Password"
	/// label
	/// English String: "Password"
	/// </summary>
	public override string LabelPassword => "Mot de passe";

	/// <summary>
	/// Key: "Label.ResendCode"
	/// English String: "Resend Code"
	/// </summary>
	public override string LabelResendCode => "Renvoyer le code";

	/// <summary>
	/// Key: "Label.Submit"
	/// English String: "Submit"
	/// </summary>
	public override string LabelSubmit => "Soumettre";

	/// <summary>
	/// Key: "Label.ToolTip.WhoCanFindMeByPhone"
	/// English String: "This setting controls who can find you using the phone number you provided."
	/// </summary>
	public override string LabelToolTipWhoCanFindMeByPhone => "Cette option vous permet contrôler qui peut vous trouver à l'aide du numéro de téléphone fourni.";

	/// <summary>
	/// Key: "Label.Username"
	/// English String: "Username"
	/// </summary>
	public override string LabelUsername => "Nom d'utilisateur";

	/// <summary>
	/// Key: "Label.WhoCanFindMeByPhone"
	/// English String: "Who can find me by my phone number?"
	/// </summary>
	public override string LabelWhoCanFindMeByPhone => "Qui peut me trouver à l'aide de mon numéro de téléphone\u00a0?";

	/// <summary>
	/// Key: "Message.DefaultError"
	/// English String: "An error occurred, try again later."
	/// </summary>
	public override string MessageDefaultError => "Une erreur est survenue. Veuillez réessayer plus tard.";

	/// <summary>
	/// Key: "Message.EmailForUsernameSuccessBody"
	/// success message
	/// English String: "An email with your username(s) has been sent to you if the email was previously saved on your account."
	/// </summary>
	public override string MessageEmailForUsernameSuccessBody => "Un email avec ton ou tes nom(s) d'utilisateur t'a été envoyé, si tu avais déjà enregistré une adresse email sur ton compte.";

	/// <summary>
	/// Key: "Message.EmailSuccessBody"
	/// English String: "An email with instructions has been sent to you if the email was previously saved on your account."
	/// </summary>
	public override string MessageEmailSuccessBody => "Un email avec des instructions t'a été envoyé à ton adresse email, si tu en avais déjà enregistré une sur ton compte.";

	/// <summary>
	/// Key: "Message.EmailSuccessTitle"
	/// English String: "Email Sent"
	/// </summary>
	public override string MessageEmailSuccessTitle => "E-mail envoyé";

	/// <summary>
	/// Key: "Message.EnterCode"
	/// English String: "A code was sent to your phone if it was previously verified on your account. Please enter it below"
	/// </summary>
	public override string MessageEnterCode => "Un code a été envoyé sur ton téléphone, si tu avais déjà enregistré un numéro sur ton compte. Il faut l’entrer ci-dessous";

	/// <summary>
	/// Key: "Message.EnterCodeSentToEmail"
	/// Enter the code we just sent to your email.
	/// English String: "Enter the code we just sent to your email."
	/// </summary>
	public override string MessageEnterCodeSentToEmail => "Saisissez le code qui vous a été envoyé par e-mail.";

	/// <summary>
	/// Key: "Message.PhoneForUsernameSuccessBody"
	/// English String: "An SMS with your username(s) has been sent to you if the phone number was previously verified on your account."
	/// </summary>
	public override string MessagePhoneForUsernameSuccessBody => "Un SMS avec ton/tes nom(s) d'utilisateur t'a été envoyé, si tu en avais déjà enregistré un numéro de téléphone sur ton compte.";

	/// <summary>
	/// Key: "Message.PhoneForUsernameSuccessTitle"
	/// English String: "SMS Sent"
	/// </summary>
	public override string MessagePhoneForUsernameSuccessTitle => "SMS envoyé";

	/// <summary>
	/// Key: "MessageAccountDoesNotHaveAnEmail"
	/// English String: "There is no email linked to this account"
	/// </summary>
	public override string MessageAccountDoesNotHaveAnEmail => "Aucune adresse e-mail n'est liée à ce compte";

	/// <summary>
	/// Key: "MessageAccountNotFoundByEmail"
	/// No account found. Please use a different email.
	/// English String: "No account found. Please use a different email."
	/// </summary>
	public override string MessageAccountNotFoundByEmail => "Aucun compte trouvé. Veuillez utiliser une autre adresse e-mail.";

	/// <summary>
	/// Key: "MessageAccountNotFoundByPhone"
	/// No account found. Please use a different phone number.
	/// English String: "No account found. Please use a different phone number."
	/// </summary>
	public override string MessageAccountNotFoundByPhone => "Aucun compte trouvé. Veuillez utiliser un autre numéro de téléphone.";

	/// <summary>
	/// Key: "MessageAccountRecoveryUnknownError"
	/// English String: "System error. Account could not be restored to this state."
	/// </summary>
	public override string MessageAccountRecoveryUnknownError => "Erreur système. Restauration du compte impossible.";

	/// <summary>
	/// Key: "MessageCaptchaError"
	/// English String: "We need to make sure you're not a robot!"
	/// </summary>
	public override string MessageCaptchaError => "Nous devons vérifier que vous n'êtes pas un robot\u00a0!";

	/// <summary>
	/// Key: "MessageCaptchaFailError"
	/// English String: "The words you typed didn't match the picture. Please try again."
	/// </summary>
	public override string MessageCaptchaFailError => "Les mots saisis ne correspondent pas à l'image. Veuillez réessayer.";

	/// <summary>
	/// Key: "MessageCredentialsError"
	/// English String: "Your username or password is incorrect. Please check them and try again."
	/// </summary>
	public override string MessageCredentialsError => "Votre nom d'utilisateur ou votre mot de passe est incorrect. Veuillez vérifier et réessayer.";

	/// <summary>
	/// Key: "MessageFloodCheckedError"
	/// English String: "Too many attempts. Please try again later."
	/// </summary>
	public override string MessageFloodCheckedError => "Trop de tentatives. Veuillez réessayer plus tard.";

	/// <summary>
	/// Key: "MessageForgotPasswordFeatureDisabled"
	/// English String: "Feature temporarily disabled. Please try again later."
	/// </summary>
	public override string MessageForgotPasswordFeatureDisabled => "Fonctionnalité temporairement désactivée. Veuillez réessayer plus tard.";

	/// <summary>
	/// Key: "MessageForgotPasswordSuccess"
	/// English String: "Check your email for login instructions"
	/// </summary>
	public override string MessageForgotPasswordSuccess => "Vérifiez vos e-mails pour des instructions de connexion.";

	/// <summary>
	/// Key: "MessageInvalidAccountStatus"
	/// English String: "Account status prevents resetting password"
	/// </summary>
	public override string MessageInvalidAccountStatus => "L'état du compte empêche la réinitialisation du mot de passe.";

	/// <summary>
	/// Key: "MessageInvalidPassword"
	/// English String: "Invalid password"
	/// </summary>
	public override string MessageInvalidPassword => "Mot de passe invalide";

	/// <summary>
	/// Key: "MessageInvalidTicket"
	/// English String: "We couldn't load this security ticket."
	/// </summary>
	public override string MessageInvalidTicket => "Nous n'avons pas été en mesure de charger ce jeton de sécurité.";

	/// <summary>
	/// Key: "MessageInvalidUserNameOrEmail"
	/// English String: "Invalid username, or no email exists"
	/// </summary>
	public override string MessageInvalidUserNameOrEmail => "Nom d'utilisateur invalide ou aucune adresse e-mail";

	/// <summary>
	/// Key: "MessageMobileResetPasswordSuccess"
	/// English String: "MobileResetPasswordSuccess"
	/// </summary>
	public override string MessageMobileResetPasswordSuccess => "MobileResetPasswordSuccess";

	/// <summary>
	/// Key: "MessageNoAccountsLinkedToEmail"
	/// English String: "There are no accounts linked to this email address"
	/// </summary>
	public override string MessageNoAccountsLinkedToEmail => "Aucun compte n'est lié à cette adresse e-mail";

	/// <summary>
	/// Key: "MessageOldUsernameError"
	/// English String: "It looks like you are trying to log in with a username that has changed. Please log in with your new username."
	/// </summary>
	public override string MessageOldUsernameError => "Votre nom d'utilisateur a été modifié. Veuillez vous connecter avec votre nouveau nom d'utilisateur.";

	/// <summary>
	/// Key: "MessagePasswordCannotBeUsed"
	/// English String: "Sorry, that password cannot be used."
	/// </summary>
	public override string MessagePasswordCannotBeUsed => "Impossible d'utiliser ce mot de passe.";

	/// <summary>
	/// Key: "MessagePasswordsDoNotMatch"
	/// English String: "Passwords do not match"
	/// </summary>
	public override string MessagePasswordsDoNotMatch => "Les mots de passe ne correspondent pas";

	/// <summary>
	/// Key: "MessageSamlUnauthenticated"
	/// English String: "You must log in to Roblox to finish authenticating."
	/// </summary>
	public override string MessageSamlUnauthenticated => "Vous devez vous connecter à Roblox pour terminer l'authentification.";

	/// <summary>
	/// Key: "MessageUnknownError"
	/// English String: "Unknown Error"
	/// </summary>
	public override string MessageUnknownError => "Erreur inconnue";

	/// <summary>
	/// Key: "MessageUnknownSystemError"
	/// English String: "System error. Please return to login screen."
	/// </summary>
	public override string MessageUnknownSystemError => "Erreur système. Veuillez revenir à l'écran de connexion.";

	/// <summary>
	/// Key: "Placeholder.Email"
	/// English String: "Email"
	/// </summary>
	public override string PlaceholderEmail => "E-mail";

	/// <summary>
	/// Key: "Placeholder.PhoneNumber"
	/// English String: "Phone Number"
	/// </summary>
	public override string PlaceholderPhoneNumber => "Numéro de téléphone";

	/// <summary>
	/// Key: "Response.PasswordResetSuccess"
	/// Password reset success! Please login again.
	/// English String: "Password reset success! Please login again."
	/// </summary>
	public override string ResponsePasswordResetSuccess => "Réinitialisation du mot de passe effectuée\u00a0! Veuillez vous reconnecter.";

	/// <summary>
	/// Key: "Response.Success"
	/// English String: "Success"
	/// </summary>
	public override string ResponseSuccess => "Succès";

	/// <summary>
	/// Key: "Response.UpdatePasswordFlooded"
	/// English String: "Too many attempts. Please try again later."
	/// </summary>
	public override string ResponseUpdatePasswordFlooded => "Trop de tentatives. Veuillez réessayer plus tard.";

	/// <summary>
	/// Key: "Response.UpdatePasswordIncorrect"
	/// English String: "Your current password is incorrect, the password was not changed."
	/// </summary>
	public override string ResponseUpdatePasswordIncorrect => "Votre mot de passe actuel est incorrect, le mot de passe n'a pas été modifié.";

	/// <summary>
	/// Key: "Response.UpdatePasswordInputMissing"
	/// English String: "Must include new password and confirm password"
	/// </summary>
	public override string ResponseUpdatePasswordInputMissing => "Vous devez inclure le nouveau mot de passe et le confirmer.";

	/// <summary>
	/// Key: "Response.UpdatePasswordMismatch"
	/// English String: "Your new password and confirm password must match"
	/// </summary>
	public override string ResponseUpdatePasswordMismatch => "Votre nouveau mot de passe et le mot de passe de confirmation doivent correspondre.";

	public ResetPasswordResources_fr_fr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "Annuler";
	}

	protected override string _GetTemplateForActionEmailToResetPassword()
	{
		return "Réinitialiser le mot de passe à l'aide d'un e-mail";
	}

	protected override string _GetTemplateForActionEmailToRetriveUsername()
	{
		return "Récupérer le nom d'utilisateur à l'aide d'un e-mail";
	}

	protected override string _GetTemplateForActionOk()
	{
		return "Ok";
	}

	protected override string _GetTemplateForActionPhoneToResetPassword()
	{
		return "Réinitialiser le mot de passe à l'aide d'un numéro de téléphone";
	}

	protected override string _GetTemplateForActionPhoneToRetriveUsername()
	{
		return "Récupérer le nom d'utilisateur à l'aide d'un numéro de téléphone";
	}

	protected override string _GetTemplateForActionVerify()
	{
		return "Vérifier";
	}

	/// <summary>
	/// Key: "Description.ChangePasswordEmail.HtmlBody1"
	/// email body for change password email
	/// English String: "We noticed that the password changed for your Roblox account: {userName}. If you didn't intend to change it, or you think someone else changed it by mistake, please click this link to undo the action:{lineBreak} {actionLink} {lineBreak}{lineBreak}If you are happy with your new Roblox password, you don't have to do anything! It's already set up. Please do not reply to this message. If you have any questions, please see the Roblox help page (https://www.roblox.com/help)."
	/// </summary>
	public override string DescriptionChangePasswordEmailHtmlBody1(string userName, string lineBreak, string actionLink)
	{
		return $"Nous avons remarqué que le mot de passe de votre compte {userName} a été modifié. Au cas où ce changement n'était pas intentionnel, ou si vous pensez que quelqu'un peut l'avoir effectué à votre place par accident, veuillez cliquer sur le lien suivant afin d'annuler la modification\u00a0: {lineBreak} {actionLink} {lineBreak}{lineBreak}. Si vous aviez bel et bien demandé à changer le mot de passe de votre compte Roblox, alors tout est paré\u00a0! Merci de ne pas répondre à ce message. Pour toute question, n'hésitez pas à consulter la page d'aide de Roblox (https://www.roblox.com/help).";
	}

	protected override string _GetTemplateForDescriptionChangePasswordEmailHtmlBody1()
	{
		return "Nous avons remarqué que le mot de passe de votre compte {userName} a été modifié. Au cas où ce changement n'était pas intentionnel, ou si vous pensez que quelqu'un peut l'avoir effectué à votre place par accident, veuillez cliquer sur le lien suivant afin d'annuler la modification\u00a0: {lineBreak} {actionLink} {lineBreak}{lineBreak}. Si vous aviez bel et bien demandé à changer le mot de passe de votre compte Roblox, alors tout est paré\u00a0! Merci de ne pas répondre à ce message. Pour toute question, n'hésitez pas à consulter la page d'aide de Roblox (https://www.roblox.com/help).";
	}

	protected override string _GetTemplateForDescriptionEmailToResetPassword()
	{
		return "Saisissez votre e-mail pour récupérer votre mot de passe.";
	}

	protected override string _GetTemplateForDescriptionEmailToRetriveUsername()
	{
		return "Saisissez votre e-mail pour récupérer votre nom d'utilisateur.";
	}

	/// <summary>
	/// Key: "Description.PasswordChangeEmail.BodyPlainText"
	/// password reset plaintext email message
	/// English String: "We noticed that the password changed for your Roblox account: {userName}. If you didn't intend to change it, or you think someone else changed it by mistake, please click this link to undo the action:\n{urlWithTicket}\n\nIf you are happy with your new Roblox password, you don't have to do anything! It's already set up. Please do not reply to this message. If you have any questions, please see the Roblox help page (https://www.roblox.com/help)."
	/// </summary>
	public override string DescriptionPasswordChangeEmailBodyPlainText(string userName, string urlWithTicket)
	{
		return $"Nous avons remarqué que le mot de passe de votre compte {userName} a été modifié. Au cas où ce changement n'était pas intentionnel, ou si vous pensez que quelqu'un peut l'avoir effectué à votre place par accident, veuillez cliquer sur le lien suivant afin d'annuler la modification\u00a0: \n{urlWithTicket}\n\n. Si vous aviez bel et bien demandé à changer le mot de passe de votre compte Roblox, alors tout est paré\u00a0! Merci de ne pas répondre à ce message. Pour toute question, n'hésitez pas à consulter la page d'aide de Roblox (https://www.roblox.com/help).";
	}

	protected override string _GetTemplateForDescriptionPasswordChangeEmailBodyPlainText()
	{
		return "Nous avons remarqué que le mot de passe de votre compte {userName} a été modifié. Au cas où ce changement n'était pas intentionnel, ou si vous pensez que quelqu'un peut l'avoir effectué à votre place par accident, veuillez cliquer sur le lien suivant afin d'annuler la modification\u00a0: \n{urlWithTicket}\n\n. Si vous aviez bel et bien demandé à changer le mot de passe de votre compte Roblox, alors tout est paré\u00a0! Merci de ne pas répondre à ce message. Pour toute question, n'hésitez pas à consulter la page d'aide de Roblox (https://www.roblox.com/help).";
	}

	/// <summary>
	/// Key: "Description.PasswordChangeEmail.From"
	/// name of the sender as shown in from field of the email
	/// English String: "\"Roblox Password Reset\" {fromEmailAddress}"
	/// </summary>
	public override string DescriptionPasswordChangeEmailFrom(string fromEmailAddress)
	{
		return $"Réinitialisation du mot de passe pour Roblox {fromEmailAddress}";
	}

	protected override string _GetTemplateForDescriptionPasswordChangeEmailFrom()
	{
		return "Réinitialisation du mot de passe pour Roblox {fromEmailAddress}";
	}

	protected override string _GetTemplateForDescriptionPasswordChangeEmailSubject()
	{
		return "Réinitialisation du mot de passe pour Roblox";
	}

	/// <summary>
	/// Key: "Description.PasswordResetEmail.From"
	/// The "From" field for the password reset email
	/// English String: "{escapeLiteralStart}Roblox Password Reset{escapeLiteralEnd} {fromEmailAddress}"
	/// </summary>
	public override string DescriptionPasswordResetEmailFrom(string escapeLiteralStart, string escapeLiteralEnd, string fromEmailAddress)
	{
		return $"{escapeLiteralStart}Réinitialisation du mot de passe pour Roblox{escapeLiteralEnd} {fromEmailAddress}";
	}

	protected override string _GetTemplateForDescriptionPasswordResetEmailFrom()
	{
		return "{escapeLiteralStart}Réinitialisation du mot de passe pour Roblox{escapeLiteralEnd} {fromEmailAddress}";
	}

	/// <summary>
	/// Key: "Description.PasswordResetEmail.HtmlBody"
	/// This email is sent when a user requests a password reset.
	/// English String: "We have received a request to reset the password for your Roblox account: {emailOrUsername}{lineBreak}{lineBreak}If you submitted this request, please click the button below to proceed.{lineBreak}This button will be active for {passwordResetTicketHours} hours, {passwordResetTicketMinutes} minutes. If you do not wish to reset your password, please disregard this notice.{lineBreak}{lineBreak}{aTagWithStartHref}{resetPasswordUrl}{hrefEnd}{buttonStart}Reset Password{buttonEnd}{aTagEnd}"
	/// </summary>
	public override string DescriptionPasswordResetEmailHtmlBody(string emailOrUsername, string lineBreak, string passwordResetTicketHours, string passwordResetTicketMinutes, string aTagWithStartHref, string resetPasswordUrl, string hrefEnd, string buttonStart, string buttonEnd, string aTagEnd)
	{
		return $"Nous avons reçu une demande de réinitialisation du mot de passe pour votre compte Roblox : {emailOrUsername}{lineBreak}{lineBreak}Si vous avez soumis cette requête, veuillez cliquez le bouton ci-dessous pour continuer.{lineBreak}Ce bouton est valide pendant {passwordResetTicketHours} heures, {passwordResetTicketMinutes} minutes. Si vous ne voulez pas changer votre mot de passe, veuillez ne pas tenir compte de cette notice.{lineBreak}{lineBreak}{aTagWithStartHref}{resetPasswordUrl}{hrefEnd}{buttonStart}Réinitialiser mot de passe{buttonEnd}{aTagEnd}";
	}

	protected override string _GetTemplateForDescriptionPasswordResetEmailHtmlBody()
	{
		return "Nous avons reçu une demande de réinitialisation du mot de passe pour votre compte Roblox : {emailOrUsername}{lineBreak}{lineBreak}Si vous avez soumis cette requête, veuillez cliquez le bouton ci-dessous pour continuer.{lineBreak}Ce bouton est valide pendant {passwordResetTicketHours} heures, {passwordResetTicketMinutes} minutes. Si vous ne voulez pas changer votre mot de passe, veuillez ne pas tenir compte de cette notice.{lineBreak}{lineBreak}{aTagWithStartHref}{resetPasswordUrl}{hrefEnd}{buttonStart}Réinitialiser mot de passe{buttonEnd}{aTagEnd}";
	}

	/// <summary>
	/// Key: "Description.PasswordResetEmail.PlainBody"
	/// This email is sent when a user requests a password reset.
	/// English String: "We have received a request to reset the password for your Roblox account: {emailOrUsername}{lineBreak}{lineBreak}If you submitted this request, please click the link below or paste it into a web browser to proceed.{lineBreak}This link will be active for {passwordResetTicketHours} hours, {passwordResetTicketMinutes} minutes. If you do not wish to reset your password, please disregard this notice.{lineBreak}{lineBreak}{resetPasswordUrl}"
	/// </summary>
	public override string DescriptionPasswordResetEmailPlainBody(string emailOrUsername, string lineBreak, string passwordResetTicketHours, string passwordResetTicketMinutes, string resetPasswordUrl)
	{
		return $"Nous avons reçu une demande de réinitialisation du mot de passe pour votre compte Roblox : {emailOrUsername}{lineBreak}{lineBreak}Si vous avez soumis cette requête, veuillez cliquez le lien ci-dessous ou le copier dans un navigateur web pour continuer.{lineBreak}Ce lien est valide pendant {passwordResetTicketHours} heures, {passwordResetTicketMinutes} minutes. Si vous ne voulez pas changer votre mot de passe, veuillez ne pas tenir compte de cette notice.{lineBreak}{lineBreak}{resetPasswordUrl}";
	}

	protected override string _GetTemplateForDescriptionPasswordResetEmailPlainBody()
	{
		return "Nous avons reçu une demande de réinitialisation du mot de passe pour votre compte Roblox : {emailOrUsername}{lineBreak}{lineBreak}Si vous avez soumis cette requête, veuillez cliquez le lien ci-dessous ou le copier dans un navigateur web pour continuer.{lineBreak}Ce lien est valide pendant {passwordResetTicketHours} heures, {passwordResetTicketMinutes} minutes. Si vous ne voulez pas changer votre mot de passe, veuillez ne pas tenir compte de cette notice.{lineBreak}{lineBreak}{resetPasswordUrl}";
	}

	protected override string _GetTemplateForDescriptionPasswordResetEmailSubject()
	{
		return "Réinitialiser mot de passe cu compte Roblox";
	}

	protected override string _GetTemplateForDescriptionPhoneToResetPassword()
	{
		return "Saisissez votre numéro de téléphone pour récupérer votre mot de passe.";
	}

	protected override string _GetTemplateForDescriptionPhoneToRetriveUsername()
	{
		return "Saisissez votre numéro de téléphone pour récupérer votre nom d'utilisateur.";
	}

	protected override string _GetTemplateForHeadingVerifyCode()
	{
		return "Vérifier le code";
	}

	protected override string _GetTemplateForHeadingVerifyPhone()
	{
		return "Vérifier le téléphone";
	}

	protected override string _GetTemplateForHeadingForgetPasswordOrUsername()
	{
		return "Mot de passe ou nom d'utilisateur oublié";
	}

	protected override string _GetTemplateForLabelActionButtonYes()
	{
		return "Oui";
	}

	protected override string _GetTemplateForLabelForgetMyPassword()
	{
		return "Mot de passe oublié";
	}

	protected override string _GetTemplateForLabelForgetMyUsername()
	{
		return "Nom d'utilisateur oublié";
	}

	protected override string _GetTemplateForLabelInvalidEmail()
	{
		return "E-mail invalide";
	}

	protected override string _GetTemplateForLabelInvalidPhoneNumber()
	{
		return "Numéro de téléphone invalide";
	}

	protected override string _GetTemplateForLabelNeutralButtonOk()
	{
		return "Ok";
	}

	protected override string _GetTemplateForLabelPassword()
	{
		return "Mot de passe";
	}

	protected override string _GetTemplateForLabelResendCode()
	{
		return "Renvoyer le code";
	}

	protected override string _GetTemplateForLabelSubmit()
	{
		return "Soumettre";
	}

	protected override string _GetTemplateForLabelToolTipWhoCanFindMeByPhone()
	{
		return "Cette option vous permet contrôler qui peut vous trouver à l'aide du numéro de téléphone fourni.";
	}

	protected override string _GetTemplateForLabelUsername()
	{
		return "Nom d'utilisateur";
	}

	protected override string _GetTemplateForLabelWhoCanFindMeByPhone()
	{
		return "Qui peut me trouver à l'aide de mon numéro de téléphone\u00a0?";
	}

	/// <summary>
	/// Key: "Message.CantSendEmailWarning"
	/// English String: "If you did not give us a {styleStart}real email address{styleEnd} when you created your account, we cannot send you an email."
	/// </summary>
	public override string MessageCantSendEmailWarning(string styleStart, string styleEnd)
	{
		return $"Si vous n'avez pas fourni d'{styleStart}adresse e-mail valide{styleEnd} lors de la création de votre compte, nous ne pourrons pas vous envoyer d'e-mail.";
	}

	protected override string _GetTemplateForMessageCantSendEmailWarning()
	{
		return "Si vous n'avez pas fourni d'{styleStart}adresse e-mail valide{styleEnd} lors de la création de votre compte, nous ne pourrons pas vous envoyer d'e-mail.";
	}

	protected override string _GetTemplateForMessageDefaultError()
	{
		return "Une erreur est survenue. Veuillez réessayer plus tard.";
	}

	protected override string _GetTemplateForMessageEmailForUsernameSuccessBody()
	{
		return "Un email avec ton ou tes nom(s) d'utilisateur t'a été envoyé, si tu avais déjà enregistré une adresse email sur ton compte.";
	}

	protected override string _GetTemplateForMessageEmailSuccessBody()
	{
		return "Un email avec des instructions t'a été envoyé à ton adresse email, si tu en avais déjà enregistré une sur ton compte.";
	}

	protected override string _GetTemplateForMessageEmailSuccessTitle()
	{
		return "E-mail envoyé";
	}

	protected override string _GetTemplateForMessageEnterCode()
	{
		return "Un code a été envoyé sur ton téléphone, si tu avais déjà enregistré un numéro sur ton compte. Il faut l’entrer ci-dessous";
	}

	protected override string _GetTemplateForMessageEnterCodeSentToEmail()
	{
		return "Saisissez le code qui vous a été envoyé par e-mail.";
	}

	protected override string _GetTemplateForMessagePhoneForUsernameSuccessBody()
	{
		return "Un SMS avec ton/tes nom(s) d'utilisateur t'a été envoyé, si tu en avais déjà enregistré un numéro de téléphone sur ton compte.";
	}

	protected override string _GetTemplateForMessagePhoneForUsernameSuccessTitle()
	{
		return "SMS envoyé";
	}

	protected override string _GetTemplateForMessageAccountDoesNotHaveAnEmail()
	{
		return "Aucune adresse e-mail n'est liée à ce compte";
	}

	protected override string _GetTemplateForMessageAccountNotFoundByEmail()
	{
		return "Aucun compte trouvé. Veuillez utiliser une autre adresse e-mail.";
	}

	protected override string _GetTemplateForMessageAccountNotFoundByPhone()
	{
		return "Aucun compte trouvé. Veuillez utiliser un autre numéro de téléphone.";
	}

	protected override string _GetTemplateForMessageAccountRecoveryUnknownError()
	{
		return "Erreur système. Restauration du compte impossible.";
	}

	protected override string _GetTemplateForMessageCaptchaError()
	{
		return "Nous devons vérifier que vous n'êtes pas un robot\u00a0!";
	}

	protected override string _GetTemplateForMessageCaptchaFailError()
	{
		return "Les mots saisis ne correspondent pas à l'image. Veuillez réessayer.";
	}

	protected override string _GetTemplateForMessageCredentialsError()
	{
		return "Votre nom d'utilisateur ou votre mot de passe est incorrect. Veuillez vérifier et réessayer.";
	}

	protected override string _GetTemplateForMessageFloodCheckedError()
	{
		return "Trop de tentatives. Veuillez réessayer plus tard.";
	}

	protected override string _GetTemplateForMessageForgotPasswordFeatureDisabled()
	{
		return "Fonctionnalité temporairement désactivée. Veuillez réessayer plus tard.";
	}

	protected override string _GetTemplateForMessageForgotPasswordSuccess()
	{
		return "Vérifiez vos e-mails pour des instructions de connexion.";
	}

	protected override string _GetTemplateForMessageInvalidAccountStatus()
	{
		return "L'état du compte empêche la réinitialisation du mot de passe.";
	}

	protected override string _GetTemplateForMessageInvalidPassword()
	{
		return "Mot de passe invalide";
	}

	protected override string _GetTemplateForMessageInvalidTicket()
	{
		return "Nous n'avons pas été en mesure de charger ce jeton de sécurité.";
	}

	protected override string _GetTemplateForMessageInvalidUserNameOrEmail()
	{
		return "Nom d'utilisateur invalide ou aucune adresse e-mail";
	}

	protected override string _GetTemplateForMessageMobileResetPasswordSuccess()
	{
		return "MobileResetPasswordSuccess";
	}

	protected override string _GetTemplateForMessageNoAccountsLinkedToEmail()
	{
		return "Aucun compte n'est lié à cette adresse e-mail";
	}

	protected override string _GetTemplateForMessageOldUsernameError()
	{
		return "Votre nom d'utilisateur a été modifié. Veuillez vous connecter avec votre nouveau nom d'utilisateur.";
	}

	protected override string _GetTemplateForMessagePasswordCannotBeUsed()
	{
		return "Impossible d'utiliser ce mot de passe.";
	}

	/// <summary>
	/// Key: "MessagePasswordResetTicketExpired"
	/// English String: "Sorry, password reset requests expire {expirationHour} hours, {expirationMinute} minutes after issuance. Try requesting another password reset ticket again."
	/// </summary>
	public override string MessagePasswordResetTicketExpired(string expirationHour, string expirationMinute)
	{
		return $"Désolé, les demandes de réinitialisation de mot de passe expirent {expirationHour} heures et {expirationMinute} minutes après avoir été soumises. Veuillez retenter de réinitialiser le mot de passe au moyen d'un nouveau jeton de sécurité.";
	}

	protected override string _GetTemplateForMessagePasswordResetTicketExpired()
	{
		return "Désolé, les demandes de réinitialisation de mot de passe expirent {expirationHour} heures et {expirationMinute} minutes après avoir été soumises. Veuillez retenter de réinitialiser le mot de passe au moyen d'un nouveau jeton de sécurité.";
	}

	protected override string _GetTemplateForMessagePasswordsDoNotMatch()
	{
		return "Les mots de passe ne correspondent pas";
	}

	protected override string _GetTemplateForMessageSamlUnauthenticated()
	{
		return "Vous devez vous connecter à Roblox pour terminer l'authentification.";
	}

	protected override string _GetTemplateForMessageUnknownError()
	{
		return "Erreur inconnue";
	}

	protected override string _GetTemplateForMessageUnknownSystemError()
	{
		return "Erreur système. Veuillez revenir à l'écran de connexion.";
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
		return $"Saisir le code ({codeLength}\u00a0chiffres)";
	}

	protected override string _GetTemplateForPlaceholderEnterCode()
	{
		return "Saisir le code ({codeLength}\u00a0chiffres)";
	}

	protected override string _GetTemplateForPlaceholderPhoneNumber()
	{
		return "Numéro de téléphone";
	}

	protected override string _GetTemplateForResponsePasswordResetSuccess()
	{
		return "Réinitialisation du mot de passe effectuée\u00a0! Veuillez vous reconnecter.";
	}

	protected override string _GetTemplateForResponseSuccess()
	{
		return "Succès";
	}

	protected override string _GetTemplateForResponseUpdatePasswordFlooded()
	{
		return "Trop de tentatives. Veuillez réessayer plus tard.";
	}

	protected override string _GetTemplateForResponseUpdatePasswordIncorrect()
	{
		return "Votre mot de passe actuel est incorrect, le mot de passe n'a pas été modifié.";
	}

	protected override string _GetTemplateForResponseUpdatePasswordInputMissing()
	{
		return "Vous devez inclure le nouveau mot de passe et le confirmer.";
	}

	protected override string _GetTemplateForResponseUpdatePasswordMismatch()
	{
		return "Votre nouveau mot de passe et le mot de passe de confirmation doivent correspondre.";
	}
}
