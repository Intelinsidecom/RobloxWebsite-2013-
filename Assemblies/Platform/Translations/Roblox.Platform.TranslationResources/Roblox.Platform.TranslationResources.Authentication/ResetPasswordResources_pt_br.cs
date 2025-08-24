namespace Roblox.TranslationResources.Authentication;

/// <summary>
/// This class overrides ResetPasswordResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ResetPasswordResources_pt_br : ResetPasswordResources_en_us, IResetPasswordResources, ITranslationResources
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
	public override string ActionEmailToResetPassword => "Usar e-mail para redefinir a senha";

	/// <summary>
	/// Key: "Action.EmailToRetriveUsername"
	/// English String: "Use email to retrieve username"
	/// </summary>
	public override string ActionEmailToRetriveUsername => "Usar e-mail para recuperar o nome de usuário";

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
	public override string ActionPhoneToResetPassword => "Usar número de telefone para redefinir a senha";

	/// <summary>
	/// Key: "Action.PhoneToRetriveUsername"
	/// English String: "Use phone number to retrieve username"
	/// </summary>
	public override string ActionPhoneToRetriveUsername => "Usar número de telefone para recuperar o nome de usuário";

	/// <summary>
	/// Key: "Action.Verify"
	/// English String: "Verify"
	/// </summary>
	public override string ActionVerify => "Verificar";

	/// <summary>
	/// Key: "Description.EmailToResetPassword"
	/// English String: "Enter your email to reset your password."
	/// </summary>
	public override string DescriptionEmailToResetPassword => "Insira seu e-mail para redefinir sua senha.";

	/// <summary>
	/// Key: "Description.EmailToRetriveUsername"
	/// English String: "Enter your email to retrieve your username."
	/// </summary>
	public override string DescriptionEmailToRetriveUsername => "Insira seu e-mail para recuperar seu nome de usuário.";

	/// <summary>
	/// Key: "Description.PasswordChangeEmail.Subject"
	/// email subject to change password
	/// English String: "Roblox Password Reset"
	/// </summary>
	public override string DescriptionPasswordChangeEmailSubject => "Redefinição de senha Roblox";

	/// <summary>
	/// Key: "Description.PasswordResetEmail.Subject"
	/// Subject for password reset email
	/// English String: "Roblox Account Password Reset"
	/// </summary>
	public override string DescriptionPasswordResetEmailSubject => "Redefinição de senha da conta Roblox";

	/// <summary>
	/// Key: "Description.PhoneToResetPassword"
	/// English String: "Enter your phone number to reset your password."
	/// </summary>
	public override string DescriptionPhoneToResetPassword => "Insira seu número de telefone para redefinir sua senha.";

	/// <summary>
	/// Key: "Description.PhoneToRetriveUsername"
	/// English String: "Enter your phone number to retrieve your username."
	/// </summary>
	public override string DescriptionPhoneToRetriveUsername => "Insira seu número de telefone para recuperar seu nome de usuário.";

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
	public override string HeadingVerifyPhone => "Verificar telefone";

	/// <summary>
	/// Key: "HeadingForgetPasswordOrUsername"
	/// English String: "Forgot Password or Username"
	/// </summary>
	public override string HeadingForgetPasswordOrUsername => "Esqueceu a senha ou nome de usuário";

	/// <summary>
	/// Key: "Label.ActionButtonYes"
	/// button label
	/// English String: "Yes"
	/// </summary>
	public override string LabelActionButtonYes => "Sim";

	/// <summary>
	/// Key: "Label.ForgetMyPassword"
	/// English String: "Forgot My Password"
	/// </summary>
	public override string LabelForgetMyPassword => "Esqueci minha senha";

	/// <summary>
	/// Key: "Label.ForgetMyUsername"
	/// English String: "Forgot My Username"
	/// </summary>
	public override string LabelForgetMyUsername => "Esqueci meu nome de usuário";

	/// <summary>
	/// Key: "Label.InvalidEmail"
	/// English String: "Invalid email"
	/// </summary>
	public override string LabelInvalidEmail => "E-mail inválido";

	/// <summary>
	/// Key: "Label.InvalidPhoneNumber"
	/// English String: "Invalid phone number"
	/// </summary>
	public override string LabelInvalidPhoneNumber => "Número de telefone inválido";

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
	public override string LabelPassword => "Senha";

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
	public override string LabelToolTipWhoCanFindMeByPhone => "Esta configuração controla quem pode encontrar você usando o número de telefone que você forneceu.";

	/// <summary>
	/// Key: "Label.Username"
	/// English String: "Username"
	/// </summary>
	public override string LabelUsername => "Nome de usuário";

	/// <summary>
	/// Key: "Label.WhoCanFindMeByPhone"
	/// English String: "Who can find me by my phone number?"
	/// </summary>
	public override string LabelWhoCanFindMeByPhone => "Quem pode me encontrar por meu número de telefone?";

	/// <summary>
	/// Key: "Message.DefaultError"
	/// English String: "An error occurred, try again later."
	/// </summary>
	public override string MessageDefaultError => "Ocorreu um erro. Tente de novo mais tarde.";

	/// <summary>
	/// Key: "Message.EmailForUsernameSuccessBody"
	/// success message
	/// English String: "An email with your username(s) has been sent to you if the email was previously saved on your account."
	/// </summary>
	public override string MessageEmailForUsernameSuccessBody => "Um e-mail com seu(s) nome(s) de usuário foi enviado para você se o e-mail tiver sido salvo anteriormente na sua conta.";

	/// <summary>
	/// Key: "Message.EmailSuccessBody"
	/// English String: "An email with instructions has been sent to you if the email was previously saved on your account."
	/// </summary>
	public override string MessageEmailSuccessBody => "Um e-mail com instruções foi enviado para você se o e-mail tiver sido salvo anteriormente na sua conta.";

	/// <summary>
	/// Key: "Message.EmailSuccessTitle"
	/// English String: "Email Sent"
	/// </summary>
	public override string MessageEmailSuccessTitle => "E-mail enviado";

	/// <summary>
	/// Key: "Message.EnterCode"
	/// English String: "A code was sent to your phone if it was previously verified on your account. Please enter it below"
	/// </summary>
	public override string MessageEnterCode => "Um código foi enviado para o seu telefone se ele tiver sido verificado anteriormente na sua conta. Digite-o abaixo";

	/// <summary>
	/// Key: "Message.EnterCodeSentToEmail"
	/// Enter the code we just sent to your email.
	/// English String: "Enter the code we just sent to your email."
	/// </summary>
	public override string MessageEnterCodeSentToEmail => "Insira o código que enviamos para o seu e-mail.";

	/// <summary>
	/// Key: "Message.PhoneForUsernameSuccessBody"
	/// English String: "An SMS with your username(s) has been sent to you if the phone number was previously verified on your account."
	/// </summary>
	public override string MessagePhoneForUsernameSuccessBody => "Um SMS com seu(s) nome(s) de usuário foi enviado para você se o seu número de telefone tiver sido verificado anteriormente na sua conta.";

	/// <summary>
	/// Key: "Message.PhoneForUsernameSuccessTitle"
	/// English String: "SMS Sent"
	/// </summary>
	public override string MessagePhoneForUsernameSuccessTitle => "SMS enviado";

	/// <summary>
	/// Key: "MessageAccountDoesNotHaveAnEmail"
	/// English String: "There is no email linked to this account"
	/// </summary>
	public override string MessageAccountDoesNotHaveAnEmail => "Não há e-mail associado a esta conta";

	/// <summary>
	/// Key: "MessageAccountNotFoundByEmail"
	/// No account found. Please use a different email.
	/// English String: "No account found. Please use a different email."
	/// </summary>
	public override string MessageAccountNotFoundByEmail => "Nenhuma conta encontrada. Use um e-mail diferente.";

	/// <summary>
	/// Key: "MessageAccountNotFoundByPhone"
	/// No account found. Please use a different phone number.
	/// English String: "No account found. Please use a different phone number."
	/// </summary>
	public override string MessageAccountNotFoundByPhone => "Nenhuma conta encontrada. Use um número de telefone diferente.";

	/// <summary>
	/// Key: "MessageAccountRecoveryUnknownError"
	/// English String: "System error. Account could not be restored to this state."
	/// </summary>
	public override string MessageAccountRecoveryUnknownError => "Erro de sistema. A conta não pôde ser restaurada para este estado.";

	/// <summary>
	/// Key: "MessageCaptchaError"
	/// English String: "We need to make sure you're not a robot!"
	/// </summary>
	public override string MessageCaptchaError => "Temos que nos certificar de que você não é um robô!";

	/// <summary>
	/// Key: "MessageCaptchaFailError"
	/// English String: "The words you typed didn't match the picture. Please try again."
	/// </summary>
	public override string MessageCaptchaFailError => "As palavras que você digitou não conferem com a imagem. Tente novamente.";

	/// <summary>
	/// Key: "MessageCredentialsError"
	/// English String: "Your username or password is incorrect. Please check them and try again."
	/// </summary>
	public override string MessageCredentialsError => "Seu nome de usuário ou senha estão incorretos. Confira e tente novamente.";

	/// <summary>
	/// Key: "MessageFloodCheckedError"
	/// English String: "Too many attempts. Please try again later."
	/// </summary>
	public override string MessageFloodCheckedError => "Tentativas excessivas. Tente de novo mais tarde.";

	/// <summary>
	/// Key: "MessageForgotPasswordFeatureDisabled"
	/// English String: "Feature temporarily disabled. Please try again later."
	/// </summary>
	public override string MessageForgotPasswordFeatureDisabled => "Funcionalidade desabilitada no momento. Tente de novo mais tarde.";

	/// <summary>
	/// Key: "MessageForgotPasswordSuccess"
	/// English String: "Check your email for login instructions"
	/// </summary>
	public override string MessageForgotPasswordSuccess => "Confira seu e-mail para instruções de conexão";

	/// <summary>
	/// Key: "MessageInvalidAccountStatus"
	/// English String: "Account status prevents resetting password"
	/// </summary>
	public override string MessageInvalidAccountStatus => "O status da conta impede a redefinição da senha";

	/// <summary>
	/// Key: "MessageInvalidPassword"
	/// English String: "Invalid password"
	/// </summary>
	public override string MessageInvalidPassword => "Senha inválida";

	/// <summary>
	/// Key: "MessageInvalidTicket"
	/// English String: "We couldn't load this security ticket."
	/// </summary>
	public override string MessageInvalidTicket => "Impossível carregar este ticket de segurança.";

	/// <summary>
	/// Key: "MessageInvalidUserNameOrEmail"
	/// English String: "Invalid username, or no email exists"
	/// </summary>
	public override string MessageInvalidUserNameOrEmail => "Nome de usuário inválido ou e-mail não existe";

	/// <summary>
	/// Key: "MessageMobileResetPasswordSuccess"
	/// English String: "MobileResetPasswordSuccess"
	/// </summary>
	public override string MessageMobileResetPasswordSuccess => "MobileResetPasswordSuccess";

	/// <summary>
	/// Key: "MessageNoAccountsLinkedToEmail"
	/// English String: "There are no accounts linked to this email address"
	/// </summary>
	public override string MessageNoAccountsLinkedToEmail => "Não há contas associadas a este endereço de e-mail";

	/// <summary>
	/// Key: "MessageOldUsernameError"
	/// English String: "It looks like you are trying to log in with a username that has changed. Please log in with your new username."
	/// </summary>
	public override string MessageOldUsernameError => "Parece que você está tentando se conectar com um nome de usuário que foi alterado. Tente se conectar com seu novo nome de usuário.";

	/// <summary>
	/// Key: "MessagePasswordCannotBeUsed"
	/// English String: "Sorry, that password cannot be used."
	/// </summary>
	public override string MessagePasswordCannotBeUsed => "Infelizmente esta senha não pode ser usada.";

	/// <summary>
	/// Key: "MessagePasswordsDoNotMatch"
	/// English String: "Passwords do not match"
	/// </summary>
	public override string MessagePasswordsDoNotMatch => "As senhas não conferem";

	/// <summary>
	/// Key: "MessageSamlUnauthenticated"
	/// English String: "You must log in to Roblox to finish authenticating."
	/// </summary>
	public override string MessageSamlUnauthenticated => "Você precisa de conectar ao Roblox para concluir a autenticação.";

	/// <summary>
	/// Key: "MessageUnknownError"
	/// English String: "Unknown Error"
	/// </summary>
	public override string MessageUnknownError => "Erro desconhecido";

	/// <summary>
	/// Key: "MessageUnknownSystemError"
	/// English String: "System error. Please return to login screen."
	/// </summary>
	public override string MessageUnknownSystemError => "Erro do sistema. Volte para a tela de conexão.";

	/// <summary>
	/// Key: "Placeholder.Email"
	/// English String: "Email"
	/// </summary>
	public override string PlaceholderEmail => "E-mail";

	/// <summary>
	/// Key: "Placeholder.PhoneNumber"
	/// English String: "Phone Number"
	/// </summary>
	public override string PlaceholderPhoneNumber => "Número de telefone";

	/// <summary>
	/// Key: "Response.PasswordResetSuccess"
	/// Password reset success! Please login again.
	/// English String: "Password reset success! Please login again."
	/// </summary>
	public override string ResponsePasswordResetSuccess => "Senha redefinida. Conecte-se novamente.";

	/// <summary>
	/// Key: "Response.Success"
	/// English String: "Success"
	/// </summary>
	public override string ResponseSuccess => "Sucesso";

	/// <summary>
	/// Key: "Response.UpdatePasswordFlooded"
	/// English String: "Too many attempts. Please try again later."
	/// </summary>
	public override string ResponseUpdatePasswordFlooded => "Tentativas excessivas. Tente de novo mais tarde.";

	/// <summary>
	/// Key: "Response.UpdatePasswordIncorrect"
	/// English String: "Your current password is incorrect, the password was not changed."
	/// </summary>
	public override string ResponseUpdatePasswordIncorrect => "Sua senha atual está incorreta. A senha não foi alterada.";

	/// <summary>
	/// Key: "Response.UpdatePasswordInputMissing"
	/// English String: "Must include new password and confirm password"
	/// </summary>
	public override string ResponseUpdatePasswordInputMissing => "É preciso inserir uma nova senha e confirmá-la.";

	/// <summary>
	/// Key: "Response.UpdatePasswordMismatch"
	/// English String: "Your new password and confirm password must match"
	/// </summary>
	public override string ResponseUpdatePasswordMismatch => "Sua nova senha e confirmação de senha devem ser idênticas.";

	public ResetPasswordResources_pt_br(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "Cancelar";
	}

	protected override string _GetTemplateForActionEmailToResetPassword()
	{
		return "Usar e-mail para redefinir a senha";
	}

	protected override string _GetTemplateForActionEmailToRetriveUsername()
	{
		return "Usar e-mail para recuperar o nome de usuário";
	}

	protected override string _GetTemplateForActionOk()
	{
		return "OK";
	}

	protected override string _GetTemplateForActionPhoneToResetPassword()
	{
		return "Usar número de telefone para redefinir a senha";
	}

	protected override string _GetTemplateForActionPhoneToRetriveUsername()
	{
		return "Usar número de telefone para recuperar o nome de usuário";
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
		return $"Notamos que você alterou a senha da sua conta Roblox: {userName}. Se você não teve a intenção de alterá-la, ou se acha que alguém a tenha alterado por acidente, clique neste link para desfazer a ação:{lineBreak} {actionLink} {lineBreak}{lineBreak}Caso esteja satisfeito com sua nova senha Roblox, nenhuma ação é necessária, já está tudo pronto! Não responda esta mensagem. Em caso de dúvidas, confira a página de ajuda do Roblox (https://www.roblox.com/help).";
	}

	protected override string _GetTemplateForDescriptionChangePasswordEmailHtmlBody1()
	{
		return "Notamos que você alterou a senha da sua conta Roblox: {userName}. Se você não teve a intenção de alterá-la, ou se acha que alguém a tenha alterado por acidente, clique neste link para desfazer a ação:{lineBreak} {actionLink} {lineBreak}{lineBreak}Caso esteja satisfeito com sua nova senha Roblox, nenhuma ação é necessária, já está tudo pronto! Não responda esta mensagem. Em caso de dúvidas, confira a página de ajuda do Roblox (https://www.roblox.com/help).";
	}

	protected override string _GetTemplateForDescriptionEmailToResetPassword()
	{
		return "Insira seu e-mail para redefinir sua senha.";
	}

	protected override string _GetTemplateForDescriptionEmailToRetriveUsername()
	{
		return "Insira seu e-mail para recuperar seu nome de usuário.";
	}

	/// <summary>
	/// Key: "Description.PasswordChangeEmail.BodyPlainText"
	/// password reset plaintext email message
	/// English String: "We noticed that the password changed for your Roblox account: {userName}. If you didn't intend to change it, or you think someone else changed it by mistake, please click this link to undo the action:\n{urlWithTicket}\n\nIf you are happy with your new Roblox password, you don't have to do anything! It's already set up. Please do not reply to this message. If you have any questions, please see the Roblox help page (https://www.roblox.com/help)."
	/// </summary>
	public override string DescriptionPasswordChangeEmailBodyPlainText(string userName, string urlWithTicket)
	{
		return $"Notamos que você alterou a senha da sua conta Roblox: {userName}. Se você não teve a intenção de alterá-la, ou se acha que alguém a tenha alterado por acidente, clique neste link para desfazer a ação:\n{urlWithTicket}\n\nCaso esteja satisfeito com sua nova senha Roblox, nenhuma ação é necessária, já está tudo pronto! Não responda esta mensagem. Em caso de dúvidas, confira a página de ajuda do Roblox (https://www.roblox.com/help).";
	}

	protected override string _GetTemplateForDescriptionPasswordChangeEmailBodyPlainText()
	{
		return "Notamos que você alterou a senha da sua conta Roblox: {userName}. Se você não teve a intenção de alterá-la, ou se acha que alguém a tenha alterado por acidente, clique neste link para desfazer a ação:\n{urlWithTicket}\n\nCaso esteja satisfeito com sua nova senha Roblox, nenhuma ação é necessária, já está tudo pronto! Não responda esta mensagem. Em caso de dúvidas, confira a página de ajuda do Roblox (https://www.roblox.com/help).";
	}

	/// <summary>
	/// Key: "Description.PasswordChangeEmail.From"
	/// name of the sender as shown in from field of the email
	/// English String: "\"Roblox Password Reset\" {fromEmailAddress}"
	/// </summary>
	public override string DescriptionPasswordChangeEmailFrom(string fromEmailAddress)
	{
		return $"“Redefinição de senha Roblox” {fromEmailAddress}";
	}

	protected override string _GetTemplateForDescriptionPasswordChangeEmailFrom()
	{
		return "“Redefinição de senha Roblox” {fromEmailAddress}";
	}

	protected override string _GetTemplateForDescriptionPasswordChangeEmailSubject()
	{
		return "Redefinição de senha Roblox";
	}

	/// <summary>
	/// Key: "Description.PasswordResetEmail.From"
	/// The "From" field for the password reset email
	/// English String: "{escapeLiteralStart}Roblox Password Reset{escapeLiteralEnd} {fromEmailAddress}"
	/// </summary>
	public override string DescriptionPasswordResetEmailFrom(string escapeLiteralStart, string escapeLiteralEnd, string fromEmailAddress)
	{
		return $"{escapeLiteralStart}Redefinir senha Roblox{escapeLiteralEnd} {fromEmailAddress}";
	}

	protected override string _GetTemplateForDescriptionPasswordResetEmailFrom()
	{
		return "{escapeLiteralStart}Redefinir senha Roblox{escapeLiteralEnd} {fromEmailAddress}";
	}

	/// <summary>
	/// Key: "Description.PasswordResetEmail.HtmlBody"
	/// This email is sent when a user requests a password reset.
	/// English String: "We have received a request to reset the password for your Roblox account: {emailOrUsername}{lineBreak}{lineBreak}If you submitted this request, please click the button below to proceed.{lineBreak}This button will be active for {passwordResetTicketHours} hours, {passwordResetTicketMinutes} minutes. If you do not wish to reset your password, please disregard this notice.{lineBreak}{lineBreak}{aTagWithStartHref}{resetPasswordUrl}{hrefEnd}{buttonStart}Reset Password{buttonEnd}{aTagEnd}"
	/// </summary>
	public override string DescriptionPasswordResetEmailHtmlBody(string emailOrUsername, string lineBreak, string passwordResetTicketHours, string passwordResetTicketMinutes, string aTagWithStartHref, string resetPasswordUrl, string hrefEnd, string buttonStart, string buttonEnd, string aTagEnd)
	{
		return $"Recebemos uma solicitação para redefinir a senha de sua conta Roblox: {emailOrUsername}{lineBreak}{lineBreak}Caso tenha feito esta solicitação, clique no botão abaixo para continuar.{lineBreak}Este botão estará ativo por {passwordResetTicketHours} horas e {passwordResetTicketMinutes} minutos. Caso não queira redefinir sua senha, desconsidere este aviso.{lineBreak}{lineBreak}{aTagWithStartHref}{resetPasswordUrl}{hrefEnd}{buttonStart}Redefinir senha{buttonEnd}{aTagEnd}";
	}

	protected override string _GetTemplateForDescriptionPasswordResetEmailHtmlBody()
	{
		return "Recebemos uma solicitação para redefinir a senha de sua conta Roblox: {emailOrUsername}{lineBreak}{lineBreak}Caso tenha feito esta solicitação, clique no botão abaixo para continuar.{lineBreak}Este botão estará ativo por {passwordResetTicketHours} horas e {passwordResetTicketMinutes} minutos. Caso não queira redefinir sua senha, desconsidere este aviso.{lineBreak}{lineBreak}{aTagWithStartHref}{resetPasswordUrl}{hrefEnd}{buttonStart}Redefinir senha{buttonEnd}{aTagEnd}";
	}

	/// <summary>
	/// Key: "Description.PasswordResetEmail.PlainBody"
	/// This email is sent when a user requests a password reset.
	/// English String: "We have received a request to reset the password for your Roblox account: {emailOrUsername}{lineBreak}{lineBreak}If you submitted this request, please click the link below or paste it into a web browser to proceed.{lineBreak}This link will be active for {passwordResetTicketHours} hours, {passwordResetTicketMinutes} minutes. If you do not wish to reset your password, please disregard this notice.{lineBreak}{lineBreak}{resetPasswordUrl}"
	/// </summary>
	public override string DescriptionPasswordResetEmailPlainBody(string emailOrUsername, string lineBreak, string passwordResetTicketHours, string passwordResetTicketMinutes, string resetPasswordUrl)
	{
		return $"Recebemos uma solicitação para redefinir a senha de sua conta Roblox: {emailOrUsername}{lineBreak}{lineBreak}Caso tenha feito esta solicitação, clique no link abaixo ou copie e cole o link em um navegador de Internet para continuar.{lineBreak}Este link estará ativo por {passwordResetTicketHours} horas e {passwordResetTicketMinutes} minutos. Caso não queira redefinir sua senha, desconsidere este aviso.{lineBreak}{lineBreak}{resetPasswordUrl}";
	}

	protected override string _GetTemplateForDescriptionPasswordResetEmailPlainBody()
	{
		return "Recebemos uma solicitação para redefinir a senha de sua conta Roblox: {emailOrUsername}{lineBreak}{lineBreak}Caso tenha feito esta solicitação, clique no link abaixo ou copie e cole o link em um navegador de Internet para continuar.{lineBreak}Este link estará ativo por {passwordResetTicketHours} horas e {passwordResetTicketMinutes} minutos. Caso não queira redefinir sua senha, desconsidere este aviso.{lineBreak}{lineBreak}{resetPasswordUrl}";
	}

	protected override string _GetTemplateForDescriptionPasswordResetEmailSubject()
	{
		return "Redefinição de senha da conta Roblox";
	}

	protected override string _GetTemplateForDescriptionPhoneToResetPassword()
	{
		return "Insira seu número de telefone para redefinir sua senha.";
	}

	protected override string _GetTemplateForDescriptionPhoneToRetriveUsername()
	{
		return "Insira seu número de telefone para recuperar seu nome de usuário.";
	}

	protected override string _GetTemplateForHeadingVerifyCode()
	{
		return "Verificar código";
	}

	protected override string _GetTemplateForHeadingVerifyPhone()
	{
		return "Verificar telefone";
	}

	protected override string _GetTemplateForHeadingForgetPasswordOrUsername()
	{
		return "Esqueceu a senha ou nome de usuário";
	}

	protected override string _GetTemplateForLabelActionButtonYes()
	{
		return "Sim";
	}

	protected override string _GetTemplateForLabelForgetMyPassword()
	{
		return "Esqueci minha senha";
	}

	protected override string _GetTemplateForLabelForgetMyUsername()
	{
		return "Esqueci meu nome de usuário";
	}

	protected override string _GetTemplateForLabelInvalidEmail()
	{
		return "E-mail inválido";
	}

	protected override string _GetTemplateForLabelInvalidPhoneNumber()
	{
		return "Número de telefone inválido";
	}

	protected override string _GetTemplateForLabelNeutralButtonOk()
	{
		return "OK";
	}

	protected override string _GetTemplateForLabelPassword()
	{
		return "Senha";
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
		return "Esta configuração controla quem pode encontrar você usando o número de telefone que você forneceu.";
	}

	protected override string _GetTemplateForLabelUsername()
	{
		return "Nome de usuário";
	}

	protected override string _GetTemplateForLabelWhoCanFindMeByPhone()
	{
		return "Quem pode me encontrar por meu número de telefone?";
	}

	/// <summary>
	/// Key: "Message.CantSendEmailWarning"
	/// English String: "If you did not give us a {styleStart}real email address{styleEnd} when you created your account, we cannot send you an email."
	/// </summary>
	public override string MessageCantSendEmailWarning(string styleStart, string styleEnd)
	{
		return $"Se você não nos forneceu um {styleStart}endereço de e-mail real{styleEnd} ao criar a sua conta, não podemos lhe enviar um e-mail.";
	}

	protected override string _GetTemplateForMessageCantSendEmailWarning()
	{
		return "Se você não nos forneceu um {styleStart}endereço de e-mail real{styleEnd} ao criar a sua conta, não podemos lhe enviar um e-mail.";
	}

	protected override string _GetTemplateForMessageDefaultError()
	{
		return "Ocorreu um erro. Tente de novo mais tarde.";
	}

	protected override string _GetTemplateForMessageEmailForUsernameSuccessBody()
	{
		return "Um e-mail com seu(s) nome(s) de usuário foi enviado para você se o e-mail tiver sido salvo anteriormente na sua conta.";
	}

	protected override string _GetTemplateForMessageEmailSuccessBody()
	{
		return "Um e-mail com instruções foi enviado para você se o e-mail tiver sido salvo anteriormente na sua conta.";
	}

	protected override string _GetTemplateForMessageEmailSuccessTitle()
	{
		return "E-mail enviado";
	}

	protected override string _GetTemplateForMessageEnterCode()
	{
		return "Um código foi enviado para o seu telefone se ele tiver sido verificado anteriormente na sua conta. Digite-o abaixo";
	}

	protected override string _GetTemplateForMessageEnterCodeSentToEmail()
	{
		return "Insira o código que enviamos para o seu e-mail.";
	}

	protected override string _GetTemplateForMessagePhoneForUsernameSuccessBody()
	{
		return "Um SMS com seu(s) nome(s) de usuário foi enviado para você se o seu número de telefone tiver sido verificado anteriormente na sua conta.";
	}

	protected override string _GetTemplateForMessagePhoneForUsernameSuccessTitle()
	{
		return "SMS enviado";
	}

	protected override string _GetTemplateForMessageAccountDoesNotHaveAnEmail()
	{
		return "Não há e-mail associado a esta conta";
	}

	protected override string _GetTemplateForMessageAccountNotFoundByEmail()
	{
		return "Nenhuma conta encontrada. Use um e-mail diferente.";
	}

	protected override string _GetTemplateForMessageAccountNotFoundByPhone()
	{
		return "Nenhuma conta encontrada. Use um número de telefone diferente.";
	}

	protected override string _GetTemplateForMessageAccountRecoveryUnknownError()
	{
		return "Erro de sistema. A conta não pôde ser restaurada para este estado.";
	}

	protected override string _GetTemplateForMessageCaptchaError()
	{
		return "Temos que nos certificar de que você não é um robô!";
	}

	protected override string _GetTemplateForMessageCaptchaFailError()
	{
		return "As palavras que você digitou não conferem com a imagem. Tente novamente.";
	}

	protected override string _GetTemplateForMessageCredentialsError()
	{
		return "Seu nome de usuário ou senha estão incorretos. Confira e tente novamente.";
	}

	protected override string _GetTemplateForMessageFloodCheckedError()
	{
		return "Tentativas excessivas. Tente de novo mais tarde.";
	}

	protected override string _GetTemplateForMessageForgotPasswordFeatureDisabled()
	{
		return "Funcionalidade desabilitada no momento. Tente de novo mais tarde.";
	}

	protected override string _GetTemplateForMessageForgotPasswordSuccess()
	{
		return "Confira seu e-mail para instruções de conexão";
	}

	protected override string _GetTemplateForMessageInvalidAccountStatus()
	{
		return "O status da conta impede a redefinição da senha";
	}

	protected override string _GetTemplateForMessageInvalidPassword()
	{
		return "Senha inválida";
	}

	protected override string _GetTemplateForMessageInvalidTicket()
	{
		return "Impossível carregar este ticket de segurança.";
	}

	protected override string _GetTemplateForMessageInvalidUserNameOrEmail()
	{
		return "Nome de usuário inválido ou e-mail não existe";
	}

	protected override string _GetTemplateForMessageMobileResetPasswordSuccess()
	{
		return "MobileResetPasswordSuccess";
	}

	protected override string _GetTemplateForMessageNoAccountsLinkedToEmail()
	{
		return "Não há contas associadas a este endereço de e-mail";
	}

	protected override string _GetTemplateForMessageOldUsernameError()
	{
		return "Parece que você está tentando se conectar com um nome de usuário que foi alterado. Tente se conectar com seu novo nome de usuário.";
	}

	protected override string _GetTemplateForMessagePasswordCannotBeUsed()
	{
		return "Infelizmente esta senha não pode ser usada.";
	}

	/// <summary>
	/// Key: "MessagePasswordResetTicketExpired"
	/// English String: "Sorry, password reset requests expire {expirationHour} hours, {expirationMinute} minutes after issuance. Try requesting another password reset ticket again."
	/// </summary>
	public override string MessagePasswordResetTicketExpired(string expirationHour, string expirationMinute)
	{
		return $"Solicitações de redefinição de senha expiram em {expirationHour} horas e {expirationMinute} minutos. Tente solicitar outro ticket de redefinição de senha.";
	}

	protected override string _GetTemplateForMessagePasswordResetTicketExpired()
	{
		return "Solicitações de redefinição de senha expiram em {expirationHour} horas e {expirationMinute} minutos. Tente solicitar outro ticket de redefinição de senha.";
	}

	protected override string _GetTemplateForMessagePasswordsDoNotMatch()
	{
		return "As senhas não conferem";
	}

	protected override string _GetTemplateForMessageSamlUnauthenticated()
	{
		return "Você precisa de conectar ao Roblox para concluir a autenticação.";
	}

	protected override string _GetTemplateForMessageUnknownError()
	{
		return "Erro desconhecido";
	}

	protected override string _GetTemplateForMessageUnknownSystemError()
	{
		return "Erro do sistema. Volte para a tela de conexão.";
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
		return $"Insira o código ({codeLength} dígitos)";
	}

	protected override string _GetTemplateForPlaceholderEnterCode()
	{
		return "Insira o código ({codeLength} dígitos)";
	}

	protected override string _GetTemplateForPlaceholderPhoneNumber()
	{
		return "Número de telefone";
	}

	protected override string _GetTemplateForResponsePasswordResetSuccess()
	{
		return "Senha redefinida. Conecte-se novamente.";
	}

	protected override string _GetTemplateForResponseSuccess()
	{
		return "Sucesso";
	}

	protected override string _GetTemplateForResponseUpdatePasswordFlooded()
	{
		return "Tentativas excessivas. Tente de novo mais tarde.";
	}

	protected override string _GetTemplateForResponseUpdatePasswordIncorrect()
	{
		return "Sua senha atual está incorreta. A senha não foi alterada.";
	}

	protected override string _GetTemplateForResponseUpdatePasswordInputMissing()
	{
		return "É preciso inserir uma nova senha e confirmá-la.";
	}

	protected override string _GetTemplateForResponseUpdatePasswordMismatch()
	{
		return "Sua nova senha e confirmação de senha devem ser idênticas.";
	}
}
