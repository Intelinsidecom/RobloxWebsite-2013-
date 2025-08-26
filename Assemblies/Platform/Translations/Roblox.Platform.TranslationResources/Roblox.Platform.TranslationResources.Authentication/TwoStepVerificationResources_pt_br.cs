namespace Roblox.Platform.TranslationResources.Authentication {
    /// <summary>

/// This class overrides TwoStepVerificationResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class TwoStepVerificationResources_pt_br : TwoStepVerificationResources_en_us, ITwoStepVerificationResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "Cancelar";

	/// <summary>
	/// Key: "Action.Resend"
	/// English String: "Resend Code"
	/// </summary>
	public override string ActionResend => "Reenviar cÃ³digo";

	/// <summary>
	/// Key: "Action.StartOver"
	/// link text to restart verification
	/// English String: "Start Over"
	/// </summary>
	public override string ActionStartOver => "RecomeÃ§ar";

	/// <summary>
	/// Key: "Action.Submit"
	/// submit button text
	/// English String: "Submit"
	/// </summary>
	public override string ActionSubmit => "Enviar";

	/// <summary>
	/// Key: "Action.Verify"
	/// English String: "Verify"
	/// </summary>
	public override string ActionVerify => "Verificar";

	/// <summary>
	/// Key: "Label.Code"
	/// verification code for 2 factor authentication
	/// English String: "Code"
	/// </summary>
	public override string LabelCode => "CÃ³digo";

	/// <summary>
	/// Key: "Label.DidNotReceive"
	/// English String: "Didn't receive the code?"
	/// </summary>
	public override string LabelDidNotReceive => "NÃ£o recebeu o cÃ³digo?";

	/// <summary>
	/// Key: "Label.EnterCode"
	/// English String: "Enter Code (6-digit)"
	/// </summary>
	public override string LabelEnterCode => "Insira o cÃ³digo (6 dÃ­gitos)";

	/// <summary>
	/// Key: "Label.EnterEmailCode"
	/// English String: "Enter the code we just sent you via email"
	/// </summary>
	public override string LabelEnterEmailCode => "Insira o cÃ³digo que enviamos por e-mail";

	/// <summary>
	/// Key: "Label.EnterTextCode"
	/// English String: "Enter the code we just sent you via text message"
	/// </summary>
	public override string LabelEnterTextCode => "Insira o cÃ³digo que enviamos por mensagem de texto";

	/// <summary>
	/// Key: "Label.EnterTwoStepVerificationCode"
	/// Enter your two step verification code.
	/// English String: "Enter your two step verification code."
	/// </summary>
	public override string LabelEnterTwoStepVerificationCode => "Insira seu cÃ³digo de verificaÃ§Ã£o de duas etapas.";

	/// <summary>
	/// Key: "Label.FacebookPasswordWarning"
	/// If you have been signing in with Facebook, you must set a password.
	/// English String: "If you have been signing in with Facebook, you must set a password."
	/// </summary>
	public override string LabelFacebookPasswordWarning => "Se vocÃª tem se conectado com o Facebook, vocÃª precisa definir uma senha.";

	/// <summary>
	/// Key: "Label.LearnMore"
	/// Learn More link text
	/// English String: "Learn More"
	/// </summary>
	public override string LabelLearnMore => "Saiba mais";

	/// <summary>
	/// Key: "Label.NewCode"
	/// verification code resent, label changes to new code
	/// English String: "New Code"
	/// </summary>
	public override string LabelNewCode => "Novo cÃ³digo";

	/// <summary>
	/// Key: "Label.RobloxSupport"
	/// English String: "Roblox Support"
	/// </summary>
	public override string LabelRobloxSupport => "Suporte Roblox";

	/// <summary>
	/// Key: "Label.TrustThisDevice"
	/// English String: "Trust this device for 30 days"
	/// </summary>
	public override string LabelTrustThisDevice => "Confiar neste dispositivo por 30 dias";

	/// <summary>
	/// Key: "Label.TwoStepVerification"
	/// English String: "2-Step Verification"
	/// </summary>
	public override string LabelTwoStepVerification => "VerificaÃ§Ã£o de 2 passos";

	/// <summary>
	/// Key: "Response.CodeSent"
	/// English String: "Code Sent"
	/// </summary>
	public override string ResponseCodeSent => "CÃ³digo enviado";

	/// <summary>
	/// Key: "Response.FeatureNotAvailable"
	/// English String: "Feature not available. Please contact support."
	/// </summary>
	public override string ResponseFeatureNotAvailable => "Funcionalidade nÃ£o disponÃ­vel. Contate o suporte.";

	/// <summary>
	/// Key: "Response.InvalidCode"
	/// English String: "Invalid code."
	/// </summary>
	public override string ResponseInvalidCode => "CÃ³digo invÃ¡lido.";

	/// <summary>
	/// Key: "Response.SystemErrorReturnToLogin"
	/// English String: "System error. Please return to login screen."
	/// </summary>
	public override string ResponseSystemErrorReturnToLogin => "Erro do sistema. Volte para a tela de conexÃ£o.";

	/// <summary>
	/// Key: "Response.TooManyAttempts"
	/// English String: "Too many attempts. Please try again later."
	/// </summary>
	public override string ResponseTooManyAttempts => "Tentativas excessivas. Tente de novo mais tarde.";

	/// <summary>
	/// Key: "Response.TooManyCharacters"
	/// error message
	/// English String: "Too many characters"
	/// </summary>
	public override string ResponseTooManyCharacters => "Caracteres em excesso";

	public TwoStepVerificationResources_pt_br(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "Cancelar";
	}

	protected override string _GetTemplateForActionResend()
	{
		return "Reenviar cÃ³digo";
	}

	protected override string _GetTemplateForActionStartOver()
	{
		return "RecomeÃ§ar";
	}

	protected override string _GetTemplateForActionSubmit()
	{
		return "Enviar";
	}

	protected override string _GetTemplateForActionVerify()
	{
		return "Verificar";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationActivationEmail.Body.Over13"
	/// Body for 2SV activation email for over 13 users
	/// English String: "Hi {accountName},{lineBreak}{lineBreak}You have activated 2-Step Verification for your Roblox account. Next time you log in from a new device, you will need to enter a 6-digit security code that Roblox sends to you via email.{lineBreak}{lineBreak}Roblox"
	/// </summary>
	public override string DescriptionTwoStepVerificationActivationEmailBodyOver13(string accountName, string lineBreak)
	{
		return $"OlÃ¡ {accountName},{lineBreak}{lineBreak}VocÃª ativou a verificaÃ§Ã£o de 2 passos para a sua conta Roblox. Na prÃ³xima vez que vocÃª se conectar em um novo dispositivo, precisarÃ¡ inserir um cÃ³digo de seguranÃ§a de 6 dÃ­gitos que o Roblox envia para vocÃª por e-mail.{lineBreak}{lineBreak}Roblox";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationActivationEmailBodyOver13()
	{
		return "OlÃ¡ {accountName},{lineBreak}{lineBreak}VocÃª ativou a verificaÃ§Ã£o de 2 passos para a sua conta Roblox. Na prÃ³xima vez que vocÃª se conectar em um novo dispositivo, precisarÃ¡ inserir um cÃ³digo de seguranÃ§a de 6 dÃ­gitos que o Roblox envia para vocÃª por e-mail.{lineBreak}{lineBreak}Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationActivationEmail.Body.Under13"
	/// Body for 2SV activation email for under 13 users
	/// English String: "Hi,{lineBreak}{lineBreak}2-Step Verification has been activated for your child's Roblox account, {accountName}. Next time they log in from a new device, they will need to enter a 6-digit security code that Roblox sends to you via email.{lineBreak}{lineBreak}Roblox"
	/// </summary>
	public override string DescriptionTwoStepVerificationActivationEmailBodyUnder13(string lineBreak, string accountName)
	{
		return $"OlÃ¡ ,{lineBreak}{lineBreak}A verificaÃ§Ã£o de 2 passos foi ativada para a conta Roblox do seu filho(a), {accountName}. Na prÃ³xima vez que ele(a) se conectar em um novo dispositivo, precisarÃ¡ inserir um cÃ³digo de seguranÃ§a de 6 dÃ­gitos que o Roblox envia para vocÃª por e-mail.{lineBreak}{lineBreak}Roblox";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationActivationEmailBodyUnder13()
	{
		return "OlÃ¡ ,{lineBreak}{lineBreak}A verificaÃ§Ã£o de 2 passos foi ativada para a conta Roblox do seu filho(a), {accountName}. Na prÃ³xima vez que ele(a) se conectar em um novo dispositivo, precisarÃ¡ inserir um cÃ³digo de seguranÃ§a de 6 dÃ­gitos que o Roblox envia para vocÃª por e-mail.{lineBreak}{lineBreak}Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationActivationEmail.Subject"
	/// Subject for 2SV activation email
	/// English String: "2-Step Verification Activated for Roblox Account: {accountName}"
	/// </summary>
	public override string DescriptionTwoStepVerificationActivationEmailSubject(string accountName)
	{
		return $"VerificaÃ§Ã£o de 2 passos ativada para a conta Roblox: {accountName}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationActivationEmailSubject()
	{
		return "VerificaÃ§Ã£o de 2 passos ativada para a conta Roblox: {accountName}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationDeactivationEmail.Body.Over13"
	/// Body for 2SV deactivation email for over 13 users
	/// English String: "Hi {accountName},{lineBreak}{lineBreak}You have deactivated 2-Step Verification for your Roblox account. A security code will no longer be required when you log into your account.{lineBreak}{lineBreak}Roblox"
	/// </summary>
	public override string DescriptionTwoStepVerificationDeactivationEmailBodyOver13(string accountName, string lineBreak)
	{
		return $"OlÃ¡ {accountName},{lineBreak}{lineBreak}VocÃª desativou a verificaÃ§Ã£o de 2 passos para sua conta Roblox. Um cÃ³digo de seguranÃ§a nÃ£o serÃ¡ mais necessÃ¡rio quando vocÃª se conectar na sua conta.{lineBreak}{lineBreak}Roblox";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationDeactivationEmailBodyOver13()
	{
		return "OlÃ¡ {accountName},{lineBreak}{lineBreak}VocÃª desativou a verificaÃ§Ã£o de 2 passos para sua conta Roblox. Um cÃ³digo de seguranÃ§a nÃ£o serÃ¡ mais necessÃ¡rio quando vocÃª se conectar na sua conta.{lineBreak}{lineBreak}Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationDeactivationEmail.Body.Under13"
	/// Body for 2SV deactivation email for under 13 users
	/// English String: "Hi,{lineBreak}{lineBreak}2-Step Verification has been deactivated for your child's Roblox account, {accountName}. A security code will no longer be required when they log into the account.{lineBreak}{lineBreak}Roblox"
	/// </summary>
	public override string DescriptionTwoStepVerificationDeactivationEmailBodyUnder13(string lineBreak, string accountName)
	{
		return $"OlÃ¡ ,{lineBreak}{lineBreak}A verificaÃ§Ã£o de 2 passos foi desativada para a conta Roblox do seu filho(a), {accountName}. Um cÃ³digo de seguranÃ§a nÃ£o serÃ¡ mais necessÃ¡rio quando ele(a) se conectar na conta.{lineBreak}{lineBreak}Roblox";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationDeactivationEmailBodyUnder13()
	{
		return "OlÃ¡ ,{lineBreak}{lineBreak}A verificaÃ§Ã£o de 2 passos foi desativada para a conta Roblox do seu filho(a), {accountName}. Um cÃ³digo de seguranÃ§a nÃ£o serÃ¡ mais necessÃ¡rio quando ele(a) se conectar na conta.{lineBreak}{lineBreak}Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationDeactivationEmail.Subject	"
	/// Subject for 2SV deactivation email
	/// English String: "2-Step Verification Deactivated for Roblox Account: {accountName}"
	/// </summary>
	public override string DescriptionTwoStepVerificationDeactivationEmailSubject(string accountName)
	{
		return $"VerificaÃ§Ã£o de 2 passos desativada para a conta Roblox: {accountName}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationDeactivationEmailSubject()
	{
		return "VerificaÃ§Ã£o de 2 passos desativada para a conta Roblox: {accountName}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo1"
	/// Geolocation information about IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {region}, {country} ({ipAddress}).{spanEndTag}{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo1(string spanStartTagWithBold, string username, string region, string country, string ipAddress, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}SolicitaÃ§Ã£o de login recebida de {username} em {region}, {country} ({ipAddress}).{spanEndTag}{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo1()
	{
		return "{spanStartTagWithBold}SolicitaÃ§Ã£o de login recebida de {username} em {region}, {country} ({ipAddress}).{spanEndTag}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo2"
	/// Geolocation info about IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {country} ({ipAddress}).{spanEndTag}{lineBreak}{lineBreak}\t"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo2(string spanStartTagWithBold, string username, string country, string ipAddress, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}SolicitaÃ§Ã£o de login recebida de {username} em {country} ({ipAddress}).{spanEndTag}{lineBreak}{lineBreak}\t";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo2()
	{
		return "{spanStartTagWithBold}SolicitaÃ§Ã£o de login recebida de {username} em {country} ({ipAddress}).{spanEndTag}{lineBreak}{lineBreak}\t";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo3"
	/// Geolocation info about IP trying to log in
	/// English String: "{spanStartTagWithBold}Login request received from {username} (From Roblox Internal).{spanEndTag}{lineBreak}{lineBreak}\t"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo3(string spanStartTagWithBold, string username, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}SolicitaÃ§Ã£o de login recebida de {username} (Roblox interno).{spanEndTag}{lineBreak}{lineBreak}\t";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo3()
	{
		return "{spanStartTagWithBold}SolicitaÃ§Ã£o de login recebida de {username} (Roblox interno).{spanEndTag}{lineBreak}{lineBreak}\t";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo4"
	/// Geolocation info of IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {country}.{spanEndTag}{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo4(string spanStartTagWithBold, string username, string country, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}SolicitaÃ§Ã£o de login recebida de {username} em {country}.{spanEndTag}{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo4()
	{
		return "{spanStartTagWithBold}SolicitaÃ§Ã£o de login recebida de {username} em {country}.{spanEndTag}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo5"
	/// Geolocation info of IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {region}, {country}.{spanEndTag}{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo5(string spanStartTagWithBold, string username, string region, string country, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}SolicitaÃ§Ã£o de login recebida de {username} em {region}, {country}.{spanEndTag}{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo5()
	{
		return "{spanStartTagWithBold}SolicitaÃ§Ã£o de login recebida de {username} em {region}, {country}.{spanEndTag}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo6"
	/// Geolocation info of IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {city}, {region}, {country}.{spanEndTag}{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo6(string spanStartTagWithBold, string username, string city, string region, string country, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}SolicitaÃ§Ã£o de login recebida de {username} em {city}, {region}, {country}.{spanEndTag}{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo6()
	{
		return "{spanStartTagWithBold}SolicitaÃ§Ã£o de login recebida de {username} em {city}, {region}, {country}.{spanEndTag}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.HtmlBody"
	/// Html body for 2SV login email
	/// English String: "{geoLocationInformation}{spanStartTagWithBold}Login code for {accountName}: {lineBreak}{lineBreak}{code} {spanEndTag}{lineBreak}{lineBreak}Enter this code into the 2-Step Verification screen to finish logging in. This code will expire in 15 minutes.{lineBreak}{lineBreak}This email was sent because your account tried to login to Roblox from a new browser or device. If you haven't tried logging into Roblox, someone else may be trying to access your account. You are strongly advised to change your password if you did not generate this request.{lineBreak}{lineBreak}Resources:{lineBreak}{aTagStartWithHref}{ChangePasswordLink}{hrefEnd}Change Your Password{aTagEnd} {lineBreak}{aTagStartWithHref}{TwoStepVerificationArticleLink}{hrefEnd}Learn More About 2-Step Verification{aTagEnd} {lineBreak}{aTagStartWithHref}{AccountSafetyArticleLink}{hrefEnd}Keeping Your Account Safe{aTagEnd} {lineBreak}{aTagStartWithHref}{SupportLink}{hrefEnd}General Roblox Support{aTagEnd} {lineBreak}{lineBreak}Thank you,{lineBreak}{lineBreak}The Roblox Team"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlBody(string geoLocationInformation, string spanStartTagWithBold, string accountName, string lineBreak, string code, string spanEndTag, string aTagStartWithHref, string ChangePasswordLink, string hrefEnd, string aTagEnd, string TwoStepVerificationArticleLink, string AccountSafetyArticleLink, string SupportLink)
	{
		return $"{geoLocationInformation}{spanStartTagWithBold}CÃ³digo de login para {accountName}: {lineBreak}{lineBreak}{code} {spanEndTag}{lineBreak}{lineBreak}Insira este cÃ³digo na tela de verificaÃ§Ã£o de 2 passos para terminar de se conectar. Este cÃ³digo irÃ¡ expirar em 15 minutos.{lineBreak}{lineBreak}Este e-mail foi enviado porque vocÃª tentou conectar com sua conta no Roblox a partir de um novo dispositivo ou navegador. Caso nÃ£o tenha tentado se conectar no Roblox, alÃ©m pode estar tentando acessar a sua conta. Altere sua senha imediatamente caso nÃ£o tenha gerado esta solicitaÃ§Ã£o.{lineBreak}{lineBreak}Recursos:{lineBreak}{aTagStartWithHref}{ChangePasswordLink}{hrefEnd}Alterar sua senha{aTagEnd} {lineBreak}{aTagStartWithHref}{TwoStepVerificationArticleLink}{hrefEnd}Saiba mais sobre a verificaÃ§Ã£o de 2 passos{aTagEnd} {lineBreak}{aTagStartWithHref}{AccountSafetyArticleLink}{hrefEnd}Mantendo sua conta segura{aTagEnd} {lineBreak}{aTagStartWithHref}{SupportLink}{hrefEnd}Suporte geral do Roblox{aTagEnd} {lineBreak}{lineBreak}Atenciosamente,{lineBreak}{lineBreak}A equipe Roblox";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlBody()
	{
		return "{geoLocationInformation}{spanStartTagWithBold}CÃ³digo de login para {accountName}: {lineBreak}{lineBreak}{code} {spanEndTag}{lineBreak}{lineBreak}Insira este cÃ³digo na tela de verificaÃ§Ã£o de 2 passos para terminar de se conectar. Este cÃ³digo irÃ¡ expirar em 15 minutos.{lineBreak}{lineBreak}Este e-mail foi enviado porque vocÃª tentou conectar com sua conta no Roblox a partir de um novo dispositivo ou navegador. Caso nÃ£o tenha tentado se conectar no Roblox, alÃ©m pode estar tentando acessar a sua conta. Altere sua senha imediatamente caso nÃ£o tenha gerado esta solicitaÃ§Ã£o.{lineBreak}{lineBreak}Recursos:{lineBreak}{aTagStartWithHref}{ChangePasswordLink}{hrefEnd}Alterar sua senha{aTagEnd} {lineBreak}{aTagStartWithHref}{TwoStepVerificationArticleLink}{hrefEnd}Saiba mais sobre a verificaÃ§Ã£o de 2 passos{aTagEnd} {lineBreak}{aTagStartWithHref}{AccountSafetyArticleLink}{hrefEnd}Mantendo sua conta segura{aTagEnd} {lineBreak}{aTagStartWithHref}{SupportLink}{hrefEnd}Suporte geral do Roblox{aTagEnd} {lineBreak}{lineBreak}Atenciosamente,{lineBreak}{lineBreak}A equipe Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainBody"
	/// Plain body for 2SV login email
	/// English String: "{geoLocationInformation}Login code for {accountName}: {lineBreak}{lineBreak} {code} {lineBreak}{lineBreak}Enter this code into the 2-Step Verification screen to finish logging in. This code will expire in 15 minutes. {lineBreak}{lineBreak}This email was sent because your account tried to login to Roblox from a new browser or device. If you haven't tried logging into Roblox, someone else may be trying to access your account. You are strongly advised to change your password if you did not generate this request. {lineBreak}{lineBreak}Resources: {lineBreak}Change Your Password [{accountInfoPageLink}] {lineBreak}Learn More About 2-Step Verification [{twoStepVerificationHelpArticleLink}]{lineBreak}Keeping Your Account Safe [{keepAccountSafeArticleLink}] {lineBreak}General Roblox Support [{supportPageLink}] {lineBreak}{lineBreak}Thank you, {lineBreak}{lineBreak}The Roblox Team"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainBody(string geoLocationInformation, string accountName, string lineBreak, string code, string accountInfoPageLink, string twoStepVerificationHelpArticleLink, string keepAccountSafeArticleLink, string supportPageLink)
	{
		return $"{geoLocationInformation} CÃ³digo de login para {accountName}: {lineBreak}{lineBreak} {code} {lineBreak}{lineBreak}Insira este cÃ³digo na tela de verificaÃ§Ã£o de 2 passos para terminar de se conectar. Este cÃ³digo irÃ¡ expirar em 15 minutos. {lineBreak}{lineBreak}Este e-mail foi enviado porque vocÃª tentou conectar com sua conta no Roblox a partir de um novo dispositivo ou navegador. Caso nÃ£o tenha tentado se conectar no Roblox, alÃ©m pode estar tentando acessar a sua conta. Altere sua senha imediatamente caso nÃ£o tenha gerado esta solicitaÃ§Ã£o. {lineBreak}{lineBreak}Recursos:{lineBreak}Alterar sua senha [{accountInfoPageLink}] {lineBreak}Saiba mais sobre a verificaÃ§Ã£o de 2 passos [{twoStepVerificationHelpArticleLink}]{lineBreak}Mantendo sua conta segura [{keepAccountSafeArticleLink}] {lineBreak}Suporte geral do Roblox [{supportPageLink}] {lineBreak}{lineBreak}Atenciosamente, {lineBreak}{lineBreak}A equipe do Roblox";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainBody()
	{
		return "{geoLocationInformation} CÃ³digo de login para {accountName}: {lineBreak}{lineBreak} {code} {lineBreak}{lineBreak}Insira este cÃ³digo na tela de verificaÃ§Ã£o de 2 passos para terminar de se conectar. Este cÃ³digo irÃ¡ expirar em 15 minutos. {lineBreak}{lineBreak}Este e-mail foi enviado porque vocÃª tentou conectar com sua conta no Roblox a partir de um novo dispositivo ou navegador. Caso nÃ£o tenha tentado se conectar no Roblox, alÃ©m pode estar tentando acessar a sua conta. Altere sua senha imediatamente caso nÃ£o tenha gerado esta solicitaÃ§Ã£o. {lineBreak}{lineBreak}Recursos:{lineBreak}Alterar sua senha [{accountInfoPageLink}] {lineBreak}Saiba mais sobre a verificaÃ§Ã£o de 2 passos [{twoStepVerificationHelpArticleLink}]{lineBreak}Mantendo sua conta segura [{keepAccountSafeArticleLink}] {lineBreak}Suporte geral do Roblox [{supportPageLink}] {lineBreak}{lineBreak}Atenciosamente, {lineBreak}{lineBreak}A equipe do Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo1"
	/// GeoLocation info of IP trying to login
	/// English String: "Login request received from {username} located in {region}, {country} ({ipAddress}).{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo1(string username, string region, string country, string ipAddress, string lineBreak)
	{
		return $"SolicitaÃ§Ã£o de login recebida de {username} em {region}, {country} ({ipAddress}).{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo1()
	{
		return "SolicitaÃ§Ã£o de login recebida de {username} em {region}, {country} ({ipAddress}).{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo2"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} located in {country} ({ipAddress}).{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo2(string username, string country, string ipAddress, string lineBreak)
	{
		return $"SolicitaÃ§Ã£o de login recebida de {username} em {country} ({ipAddress}).{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo2()
	{
		return "SolicitaÃ§Ã£o de login recebida de {username} em {country} ({ipAddress}).{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo3"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} (From Roblox Internal).{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo3(string username, string lineBreak)
	{
		return $"SolicitaÃ§Ã£o de login recebida de {username} (Roblox interno).{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo3()
	{
		return "SolicitaÃ§Ã£o de login recebida de {username} (Roblox interno).{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo4"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} located in {country}.{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo4(string username, string country, string lineBreak)
	{
		return $"SolicitaÃ§Ã£o de login recebida de {username} em {country}.{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo4()
	{
		return "SolicitaÃ§Ã£o de login recebida de {username} em {country}.{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo5"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} located in {region}, {country}.{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo5(string username, string region, string country, string lineBreak)
	{
		return $"SolicitaÃ§Ã£o de login recebida de {username} em {region}, {country}.{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo5()
	{
		return "SolicitaÃ§Ã£o de login recebida de {username} em {region}, {country}.{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo6"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} located in {city}, {region}, {country}.{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo6(string username, string city, string region, string country, string lineBreak)
	{
		return $"SolicitaÃ§Ã£o de login recebida de {username} em {city}, {region}, {country}.{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo6()
	{
		return "SolicitaÃ§Ã£o de login recebida de {username} em {city}, {region}, {country}.{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Subject"
	/// Subject for 2SV login email
	/// English String: "Verification Code for Roblox Account: {accountName}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailSubject(string accountName)
	{
		return $"CÃ³digo de verificaÃ§Ã£o da conta Roblox: {accountName}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailSubject()
	{
		return "CÃ³digo de verificaÃ§Ã£o da conta Roblox: {accountName}";
	}

	protected override string _GetTemplateForLabelCode()
	{
		return "CÃ³digo";
	}

	/// <summary>
	/// Key: "Label.CodeInputPlaceholderText"
	/// example: Enter 4-digit code
	/// English String: "Enter {codeLength}-digit Code"
	/// </summary>
	public override string LabelCodeInputPlaceholderText(string codeLength)
	{
		return $"Insira o cÃ³digo de {codeLength} digitos";
	}

	protected override string _GetTemplateForLabelCodeInputPlaceholderText()
	{
		return "Insira o cÃ³digo de {codeLength} digitos";
	}

	protected override string _GetTemplateForLabelDidNotReceive()
	{
		return "NÃ£o recebeu o cÃ³digo?";
	}

	protected override string _GetTemplateForLabelEnterCode()
	{
		return "Insira o cÃ³digo (6 dÃ­gitos)";
	}

	protected override string _GetTemplateForLabelEnterEmailCode()
	{
		return "Insira o cÃ³digo que enviamos por e-mail";
	}

	protected override string _GetTemplateForLabelEnterTextCode()
	{
		return "Insira o cÃ³digo que enviamos por mensagem de texto";
	}

	protected override string _GetTemplateForLabelEnterTwoStepVerificationCode()
	{
		return "Insira seu cÃ³digo de verificaÃ§Ã£o de duas etapas.";
	}

	protected override string _GetTemplateForLabelFacebookPasswordWarning()
	{
		return "Se vocÃª tem se conectado com o Facebook, vocÃª precisa definir uma senha.";
	}

	protected override string _GetTemplateForLabelLearnMore()
	{
		return "Saiba mais";
	}

	/// <summary>
	/// Key: "Label.NeedHelpContactSupport"
	/// label for the support article link
	/// English String: "Need help? Contact {supportLink}"
	/// </summary>
	public override string LabelNeedHelpContactSupport(string supportLink)
	{
		return $"Precisa de ajuda? Contate {supportLink}";
	}

	protected override string _GetTemplateForLabelNeedHelpContactSupport()
	{
		return "Precisa de ajuda? Contate {supportLink}";
	}

	protected override string _GetTemplateForLabelNewCode()
	{
		return "Novo cÃ³digo";
	}

	protected override string _GetTemplateForLabelRobloxSupport()
	{
		return "Suporte Roblox";
	}

	protected override string _GetTemplateForLabelTrustThisDevice()
	{
		return "Confiar neste dispositivo por 30 dias";
	}

	protected override string _GetTemplateForLabelTwoStepVerification()
	{
		return "VerificaÃ§Ã£o de 2 passos";
	}

	protected override string _GetTemplateForResponseCodeSent()
	{
		return "CÃ³digo enviado";
	}

	protected override string _GetTemplateForResponseFeatureNotAvailable()
	{
		return "Funcionalidade nÃ£o disponÃ­vel. Contate o suporte.";
	}

	protected override string _GetTemplateForResponseInvalidCode()
	{
		return "CÃ³digo invÃ¡lido.";
	}

	protected override string _GetTemplateForResponseSystemErrorReturnToLogin()
	{
		return "Erro do sistema. Volte para a tela de conexÃ£o.";
	}

	protected override string _GetTemplateForResponseTooManyAttempts()
	{
		return "Tentativas excessivas. Tente de novo mais tarde.";
	}

	protected override string _GetTemplateForResponseTooManyCharacters()
	{
		return "Caracteres em excesso";
	}
}


}
