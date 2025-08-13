namespace Roblox.TranslationResources.Authentication;

/// <summary>
/// This class overrides TwoStepVerificationResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class TwoStepVerificationResources_ru_ru : TwoStepVerificationResources_en_us, ITwoStepVerificationResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "Отмена";

	/// <summary>
	/// Key: "Action.Resend"
	/// English String: "Resend Code"
	/// </summary>
	public override string ActionResend => "Отправить код заново";

	/// <summary>
	/// Key: "Action.StartOver"
	/// link text to restart verification
	/// English String: "Start Over"
	/// </summary>
	public override string ActionStartOver => "Начать заново";

	/// <summary>
	/// Key: "Action.Submit"
	/// submit button text
	/// English String: "Submit"
	/// </summary>
	public override string ActionSubmit => "Отправить";

	/// <summary>
	/// Key: "Action.Verify"
	/// English String: "Verify"
	/// </summary>
	public override string ActionVerify => "Проверить";

	/// <summary>
	/// Key: "Label.Code"
	/// verification code for 2 factor authentication
	/// English String: "Code"
	/// </summary>
	public override string LabelCode => "Код";

	/// <summary>
	/// Key: "Label.DidNotReceive"
	/// English String: "Didn't receive the code?"
	/// </summary>
	public override string LabelDidNotReceive => "Не получили код?";

	/// <summary>
	/// Key: "Label.EnterCode"
	/// English String: "Enter Code (6-digit)"
	/// </summary>
	public override string LabelEnterCode => "Введите код (6 цифр)";

	/// <summary>
	/// Key: "Label.EnterEmailCode"
	/// English String: "Enter the code we just sent you via email"
	/// </summary>
	public override string LabelEnterEmailCode => "Введите код, отправленный вам по электронной почте";

	/// <summary>
	/// Key: "Label.EnterTextCode"
	/// English String: "Enter the code we just sent you via text message"
	/// </summary>
	public override string LabelEnterTextCode => "Введите код, отправленный вам в сообщении";

	/// <summary>
	/// Key: "Label.EnterTwoStepVerificationCode"
	/// Enter your two step verification code.
	/// English String: "Enter your two step verification code."
	/// </summary>
	public override string LabelEnterTwoStepVerificationCode => "Введите код двухэтапной идентификации.";

	/// <summary>
	/// Key: "Label.FacebookPasswordWarning"
	/// If you have been signing in with Facebook, you must set a password.
	/// English String: "If you have been signing in with Facebook, you must set a password."
	/// </summary>
	public override string LabelFacebookPasswordWarning => "Если вы использовали учетную запись Facebook, необходимо указать пароль.";

	/// <summary>
	/// Key: "Label.LearnMore"
	/// Learn More link text
	/// English String: "Learn More"
	/// </summary>
	public override string LabelLearnMore => "Подробнее";

	/// <summary>
	/// Key: "Label.NewCode"
	/// verification code resent, label changes to new code
	/// English String: "New Code"
	/// </summary>
	public override string LabelNewCode => "Новый код";

	/// <summary>
	/// Key: "Label.RobloxSupport"
	/// English String: "Roblox Support"
	/// </summary>
	public override string LabelRobloxSupport => "Служба поддержки Roblox";

	/// <summary>
	/// Key: "Label.TrustThisDevice"
	/// English String: "Trust this device for 30 days"
	/// </summary>
	public override string LabelTrustThisDevice => "Считать устройство проверенным 30 дней";

	/// <summary>
	/// Key: "Label.TwoStepVerification"
	/// English String: "2-Step Verification"
	/// </summary>
	public override string LabelTwoStepVerification => "Двухэтапная проверка";

	/// <summary>
	/// Key: "Response.CodeSent"
	/// English String: "Code Sent"
	/// </summary>
	public override string ResponseCodeSent => "Код отправлен";

	/// <summary>
	/// Key: "Response.FeatureNotAvailable"
	/// English String: "Feature not available. Please contact support."
	/// </summary>
	public override string ResponseFeatureNotAvailable => "Функция недоступна. Обратитесь в службу поддержки.";

	/// <summary>
	/// Key: "Response.InvalidCode"
	/// English String: "Invalid code."
	/// </summary>
	public override string ResponseInvalidCode => "Недопустимый код";

	/// <summary>
	/// Key: "Response.SystemErrorReturnToLogin"
	/// English String: "System error. Please return to login screen."
	/// </summary>
	public override string ResponseSystemErrorReturnToLogin => "Ошибка системы. Вернитесь на экран входа.";

	/// <summary>
	/// Key: "Response.TooManyAttempts"
	/// English String: "Too many attempts. Please try again later."
	/// </summary>
	public override string ResponseTooManyAttempts => "Слишком много попыток. Повторите попытку позже.";

	/// <summary>
	/// Key: "Response.TooManyCharacters"
	/// error message
	/// English String: "Too many characters"
	/// </summary>
	public override string ResponseTooManyCharacters => "Слишком много символов";

	public TwoStepVerificationResources_ru_ru(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "Отмена";
	}

	protected override string _GetTemplateForActionResend()
	{
		return "Отправить код заново";
	}

	protected override string _GetTemplateForActionStartOver()
	{
		return "Начать заново";
	}

	protected override string _GetTemplateForActionSubmit()
	{
		return "Отправить";
	}

	protected override string _GetTemplateForActionVerify()
	{
		return "Проверить";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationActivationEmail.Body.Over13"
	/// Body for 2SV activation email for over 13 users
	/// English String: "Hi {accountName},{lineBreak}{lineBreak}You have activated 2-Step Verification for your Roblox account. Next time you log in from a new device, you will need to enter a 6-digit security code that Roblox sends to you via email.{lineBreak}{lineBreak}Roblox"
	/// </summary>
	public override string DescriptionTwoStepVerificationActivationEmailBodyOver13(string accountName, string lineBreak)
	{
		return $"Привет, {accountName},{lineBreak}{lineBreak}Вы активировали двухэтапную проверку для вашей учетной записи Roblox. В следующий раз, когда вы войдете с нового устройства, вам будет нужно ввести шестизначный код безопасности, который бутет отправлен вам по эл. почте.{lineBreak}{lineBreak}Roblox";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationActivationEmailBodyOver13()
	{
		return "Привет, {accountName},{lineBreak}{lineBreak}Вы активировали двухэтапную проверку для вашей учетной записи Roblox. В следующий раз, когда вы войдете с нового устройства, вам будет нужно ввести шестизначный код безопасности, который бутет отправлен вам по эл. почте.{lineBreak}{lineBreak}Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationActivationEmail.Body.Under13"
	/// Body for 2SV activation email for under 13 users
	/// English String: "Hi,{lineBreak}{lineBreak}2-Step Verification has been activated for your child's Roblox account, {accountName}. Next time they log in from a new device, they will need to enter a 6-digit security code that Roblox sends to you via email.{lineBreak}{lineBreak}Roblox"
	/// </summary>
	public override string DescriptionTwoStepVerificationActivationEmailBodyUnder13(string lineBreak, string accountName)
	{
		return $"Привет,,{lineBreak}{lineBreak}Вы активировали двухэтапную проверку для учетной записи Roblox вашего ребенка, {accountName}. В следующий раз, когда он войдет с нового устройства, вам будет нужно ввести шестизначный код безопасности, который бутет отправлен вам по эл. почте..{lineBreak}{lineBreak}Roblox";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationActivationEmailBodyUnder13()
	{
		return "Привет,,{lineBreak}{lineBreak}Вы активировали двухэтапную проверку для учетной записи Roblox вашего ребенка, {accountName}. В следующий раз, когда он войдет с нового устройства, вам будет нужно ввести шестизначный код безопасности, который бутет отправлен вам по эл. почте..{lineBreak}{lineBreak}Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationActivationEmail.Subject"
	/// Subject for 2SV activation email
	/// English String: "2-Step Verification Activated for Roblox Account: {accountName}"
	/// </summary>
	public override string DescriptionTwoStepVerificationActivationEmailSubject(string accountName)
	{
		return $"Для учетной записи Roblox активирована двухэтапная проверка: {accountName}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationActivationEmailSubject()
	{
		return "Для учетной записи Roblox активирована двухэтапная проверка: {accountName}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationDeactivationEmail.Body.Over13"
	/// Body for 2SV deactivation email for over 13 users
	/// English String: "Hi {accountName},{lineBreak}{lineBreak}You have deactivated 2-Step Verification for your Roblox account. A security code will no longer be required when you log into your account.{lineBreak}{lineBreak}Roblox"
	/// </summary>
	public override string DescriptionTwoStepVerificationDeactivationEmailBodyOver13(string accountName, string lineBreak)
	{
		return $"Привет, {accountName},{lineBreak}{lineBreak}Вы деактивировали двухэтапную проверку для вашей учетной записи Roblox. Для в хода в учетную запись код безопасности больше не требуется.{lineBreak}{lineBreak}Roblox";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationDeactivationEmailBodyOver13()
	{
		return "Привет, {accountName},{lineBreak}{lineBreak}Вы деактивировали двухэтапную проверку для вашей учетной записи Roblox. Для в хода в учетную запись код безопасности больше не требуется.{lineBreak}{lineBreak}Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationDeactivationEmail.Body.Under13"
	/// Body for 2SV deactivation email for under 13 users
	/// English String: "Hi,{lineBreak}{lineBreak}2-Step Verification has been deactivated for your child's Roblox account, {accountName}. A security code will no longer be required when they log into the account.{lineBreak}{lineBreak}Roblox"
	/// </summary>
	public override string DescriptionTwoStepVerificationDeactivationEmailBodyUnder13(string lineBreak, string accountName)
	{
		return $"Привет,{lineBreak}{lineBreak}Вы деактивировали двухэтапную проверку для учетной записи Roblox вашего ребенка, {accountName}. A security code will no longer be required when they log into the account.{lineBreak}{lineBreak}Roblox";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationDeactivationEmailBodyUnder13()
	{
		return "Привет,{lineBreak}{lineBreak}Вы деактивировали двухэтапную проверку для учетной записи Roblox вашего ребенка, {accountName}. A security code will no longer be required when they log into the account.{lineBreak}{lineBreak}Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationDeactivationEmail.Subject	"
	/// Subject for 2SV deactivation email
	/// English String: "2-Step Verification Deactivated for Roblox Account: {accountName}"
	/// </summary>
	public override string DescriptionTwoStepVerificationDeactivationEmailSubject(string accountName)
	{
		return $"Для учетной записи Roblox деактивирована двухэтапная проверка: {accountName}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationDeactivationEmailSubject()
	{
		return "Для учетной записи Roblox деактивирована двухэтапная проверка: {accountName}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo1"
	/// Geolocation information about IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {region}, {country} ({ipAddress}).{spanEndTag}{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo1(string spanStartTagWithBold, string username, string region, string country, string ipAddress, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}Запрос на вход получен от пользователя {username}, расположенного в {region}, {country} ({ipAddress}).{spanEndTag}{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo1()
	{
		return "{spanStartTagWithBold}Запрос на вход получен от пользователя {username}, расположенного в {region}, {country} ({ipAddress}).{spanEndTag}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo2"
	/// Geolocation info about IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {country} ({ipAddress}).{spanEndTag}{lineBreak}{lineBreak}\t"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo2(string spanStartTagWithBold, string username, string country, string ipAddress, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}Запрос на вход получен от пользователя {username}, расположенного в {country},  ({ipAddress}).{spanEndTag}{lineBreak}{lineBreak}\t";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo2()
	{
		return "{spanStartTagWithBold}Запрос на вход получен от пользователя {username}, расположенного в {country},  ({ipAddress}).{spanEndTag}{lineBreak}{lineBreak}\t";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo3"
	/// Geolocation info about IP trying to log in
	/// English String: "{spanStartTagWithBold}Login request received from {username} (From Roblox Internal).{spanEndTag}{lineBreak}{lineBreak}\t"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo3(string spanStartTagWithBold, string username, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}Запрос на вход получен от пользователя {username}, (из Roblox).{spanEndTag}{lineBreak}{lineBreak}\t";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo3()
	{
		return "{spanStartTagWithBold}Запрос на вход получен от пользователя {username}, (из Roblox).{spanEndTag}{lineBreak}{lineBreak}\t";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo4"
	/// Geolocation info of IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {country}.{spanEndTag}{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo4(string spanStartTagWithBold, string username, string country, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}Запрос на вход получен от пользователя {username} расположенного в стране {country}.{spanEndTag}{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo4()
	{
		return "{spanStartTagWithBold}Запрос на вход получен от пользователя {username} расположенного в стране {country}.{spanEndTag}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo5"
	/// Geolocation info of IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {region}, {country}.{spanEndTag}{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo5(string spanStartTagWithBold, string username, string region, string country, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}Запрос на вход получен от пользователя {username} расположенного в регионе {region}, {country}.{spanEndTag}{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo5()
	{
		return "{spanStartTagWithBold}Запрос на вход получен от пользователя {username} расположенного в регионе {region}, {country}.{spanEndTag}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo6"
	/// Geolocation info of IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {city}, {region}, {country}.{spanEndTag}{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo6(string spanStartTagWithBold, string username, string city, string region, string country, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}Запрос на вход получен от пользователя {username} расположенного в городе {city}, {region}, {country}.{spanEndTag}{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo6()
	{
		return "{spanStartTagWithBold}Запрос на вход получен от пользователя {username} расположенного в городе {city}, {region}, {country}.{spanEndTag}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.HtmlBody"
	/// Html body for 2SV login email
	/// English String: "{geoLocationInformation}{spanStartTagWithBold}Login code for {accountName}: {lineBreak}{lineBreak}{code} {spanEndTag}{lineBreak}{lineBreak}Enter this code into the 2-Step Verification screen to finish logging in. This code will expire in 15 minutes.{lineBreak}{lineBreak}This email was sent because your account tried to login to Roblox from a new browser or device. If you haven't tried logging into Roblox, someone else may be trying to access your account. You are strongly advised to change your password if you did not generate this request.{lineBreak}{lineBreak}Resources:{lineBreak}{aTagStartWithHref}{ChangePasswordLink}{hrefEnd}Change Your Password{aTagEnd} {lineBreak}{aTagStartWithHref}{TwoStepVerificationArticleLink}{hrefEnd}Learn More About 2-Step Verification{aTagEnd} {lineBreak}{aTagStartWithHref}{AccountSafetyArticleLink}{hrefEnd}Keeping Your Account Safe{aTagEnd} {lineBreak}{aTagStartWithHref}{SupportLink}{hrefEnd}General Roblox Support{aTagEnd} {lineBreak}{lineBreak}Thank you,{lineBreak}{lineBreak}The Roblox Team"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlBody(string geoLocationInformation, string spanStartTagWithBold, string accountName, string lineBreak, string code, string spanEndTag, string aTagStartWithHref, string ChangePasswordLink, string hrefEnd, string aTagEnd, string TwoStepVerificationArticleLink, string AccountSafetyArticleLink, string SupportLink)
	{
		return $"{geoLocationInformation}{spanStartTagWithBold}Код на вход для учетной записи {accountName}: {lineBreak}{lineBreak} {code} {spanEndTag}{lineBreak}{lineBreak}Введите этот код на экране двухэтапной проверки для завершения входа в систему. Срок действия кода истекает через 15 минут. {lineBreak}{lineBreak}Это сообщение было отправлено вам, так как в вашу учетную запись Roblox была предпринята попытка входа через другой браузер или с другого устройства. Если вы не пытались войти в Roblox, возможно, кто-то другой пытался получить доступ к вашей учетной записи. В этом случае мы настоятельно рекомендуем сменить ваш пароль. {lineBreak}{lineBreak}Источники: {lineBreak}{aTagStartWithHref}{ChangePasswordLink}{hrefEnd}Изменить пароль  {aTagEnd}{lineBreak}{aTagStartWithHref}{TwoStepVerificationArticleLink}{hrefEnd}Подробнее о двухэтапной проверке {aTagEnd}{lineBreak}{aTagStartWithHref}{AccountSafetyArticleLink}{hrefEnd}Обеспечение безопасности вашей учетной записи {aTagEnd}{lineBreak}{aTagStartWithHref}{SupportLink}{hrefEnd}Техническая поддержка Roblox {aTagEnd}{lineBreak}{lineBreak}С благодарностью, {lineBreak}{lineBreak}Команда Roblox";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlBody()
	{
		return "{geoLocationInformation}{spanStartTagWithBold}Код на вход для учетной записи {accountName}: {lineBreak}{lineBreak} {code} {spanEndTag}{lineBreak}{lineBreak}Введите этот код на экране двухэтапной проверки для завершения входа в систему. Срок действия кода истекает через 15 минут. {lineBreak}{lineBreak}Это сообщение было отправлено вам, так как в вашу учетную запись Roblox была предпринята попытка входа через другой браузер или с другого устройства. Если вы не пытались войти в Roblox, возможно, кто-то другой пытался получить доступ к вашей учетной записи. В этом случае мы настоятельно рекомендуем сменить ваш пароль. {lineBreak}{lineBreak}Источники: {lineBreak}{aTagStartWithHref}{ChangePasswordLink}{hrefEnd}Изменить пароль  {aTagEnd}{lineBreak}{aTagStartWithHref}{TwoStepVerificationArticleLink}{hrefEnd}Подробнее о двухэтапной проверке {aTagEnd}{lineBreak}{aTagStartWithHref}{AccountSafetyArticleLink}{hrefEnd}Обеспечение безопасности вашей учетной записи {aTagEnd}{lineBreak}{aTagStartWithHref}{SupportLink}{hrefEnd}Техническая поддержка Roblox {aTagEnd}{lineBreak}{lineBreak}С благодарностью, {lineBreak}{lineBreak}Команда Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainBody"
	/// Plain body for 2SV login email
	/// English String: "{geoLocationInformation}Login code for {accountName}: {lineBreak}{lineBreak} {code} {lineBreak}{lineBreak}Enter this code into the 2-Step Verification screen to finish logging in. This code will expire in 15 minutes. {lineBreak}{lineBreak}This email was sent because your account tried to login to Roblox from a new browser or device. If you haven't tried logging into Roblox, someone else may be trying to access your account. You are strongly advised to change your password if you did not generate this request. {lineBreak}{lineBreak}Resources: {lineBreak}Change Your Password [{accountInfoPageLink}] {lineBreak}Learn More About 2-Step Verification [{twoStepVerificationHelpArticleLink}]{lineBreak}Keeping Your Account Safe [{keepAccountSafeArticleLink}] {lineBreak}General Roblox Support [{supportPageLink}] {lineBreak}{lineBreak}Thank you, {lineBreak}{lineBreak}The Roblox Team"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainBody(string geoLocationInformation, string accountName, string lineBreak, string code, string accountInfoPageLink, string twoStepVerificationHelpArticleLink, string keepAccountSafeArticleLink, string supportPageLink)
	{
		return $"{geoLocationInformation}Код на вход для учетной записи {accountName}: {lineBreak}{lineBreak} {code} {lineBreak}{lineBreak}Введите этот код на экране двухэтапной проверки для завершения входа в систему. Срок действия кода истекает через 15 минут. {lineBreak}{lineBreak}Это сообщение было отправлено вам, так как в вашу учетную запись Roblox была предпринята попытка входа через другой браузер или с другого устройства. Если вы не пытались войти в Roblox, возможно, кто-то другой пытался получить доступ к вашей учетной записи. В этом случае мы настоятельно рекомендуем сменить ваш пароль.{lineBreak}{lineBreak}Источники: {lineBreak}Изменить пароль [{accountInfoPageLink}] {lineBreak}Подробнее о двухэтапной проверке [{twoStepVerificationHelpArticleLink}]{lineBreak}Обеспечение безопасности вашей учетной записи [{keepAccountSafeArticleLink}] {lineBreak}Техническая поддержка Roblox [{supportPageLink}] {lineBreak}{lineBreak}С благодарностью, {lineBreak}{lineBreak}Команда Roblox";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainBody()
	{
		return "{geoLocationInformation}Код на вход для учетной записи {accountName}: {lineBreak}{lineBreak} {code} {lineBreak}{lineBreak}Введите этот код на экране двухэтапной проверки для завершения входа в систему. Срок действия кода истекает через 15 минут. {lineBreak}{lineBreak}Это сообщение было отправлено вам, так как в вашу учетную запись Roblox была предпринята попытка входа через другой браузер или с другого устройства. Если вы не пытались войти в Roblox, возможно, кто-то другой пытался получить доступ к вашей учетной записи. В этом случае мы настоятельно рекомендуем сменить ваш пароль.{lineBreak}{lineBreak}Источники: {lineBreak}Изменить пароль [{accountInfoPageLink}] {lineBreak}Подробнее о двухэтапной проверке [{twoStepVerificationHelpArticleLink}]{lineBreak}Обеспечение безопасности вашей учетной записи [{keepAccountSafeArticleLink}] {lineBreak}Техническая поддержка Roblox [{supportPageLink}] {lineBreak}{lineBreak}С благодарностью, {lineBreak}{lineBreak}Команда Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo1"
	/// GeoLocation info of IP trying to login
	/// English String: "Login request received from {username} located in {region}, {country} ({ipAddress}).{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo1(string username, string region, string country, string ipAddress, string lineBreak)
	{
		return $"Запрос на вход получен от пользователя {username}, расположенного в {region}, {country} ({ipAddress}).{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo1()
	{
		return "Запрос на вход получен от пользователя {username}, расположенного в {region}, {country} ({ipAddress}).{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo2"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} located in {country} ({ipAddress}).{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo2(string username, string country, string ipAddress, string lineBreak)
	{
		return $"Запрос на вход получен от пользователя {username}, расположенного в {country},  ({ipAddress}).{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo2()
	{
		return "Запрос на вход получен от пользователя {username}, расположенного в {country},  ({ipAddress}).{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo3"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} (From Roblox Internal).{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo3(string username, string lineBreak)
	{
		return $"Запрос на вход получен от пользователя {username}, (из Roblox).{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo3()
	{
		return "Запрос на вход получен от пользователя {username}, (из Roblox).{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo4"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} located in {country}.{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo4(string username, string country, string lineBreak)
	{
		return $"Запрос на вход получен от пользователя {username} расположенного в стране {country}.{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo4()
	{
		return "Запрос на вход получен от пользователя {username} расположенного в стране {country}.{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo5"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} located in {region}, {country}.{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo5(string username, string region, string country, string lineBreak)
	{
		return $"Запрос на вход получен от пользователя {username} расположенного в регионе {region}, {country}.{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo5()
	{
		return "Запрос на вход получен от пользователя {username} расположенного в регионе {region}, {country}.{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo6"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} located in {city}, {region}, {country}.{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo6(string username, string city, string region, string country, string lineBreak)
	{
		return $"Запрос на вход получен от пользователя {username} расположенного в городе {city}, {region}, {country}.{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo6()
	{
		return "Запрос на вход получен от пользователя {username} расположенного в городе {city}, {region}, {country}.{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Subject"
	/// Subject for 2SV login email
	/// English String: "Verification Code for Roblox Account: {accountName}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailSubject(string accountName)
	{
		return $"Идентификационный код для учетной записи Roblox: {accountName}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailSubject()
	{
		return "Идентификационный код для учетной записи Roblox: {accountName}";
	}

	protected override string _GetTemplateForLabelCode()
	{
		return "Код";
	}

	/// <summary>
	/// Key: "Label.CodeInputPlaceholderText"
	/// example: Enter 4-digit code
	/// English String: "Enter {codeLength}-digit Code"
	/// </summary>
	public override string LabelCodeInputPlaceholderText(string codeLength)
	{
		return $"Введите {codeLength}-значный код";
	}

	protected override string _GetTemplateForLabelCodeInputPlaceholderText()
	{
		return "Введите {codeLength}-значный код";
	}

	protected override string _GetTemplateForLabelDidNotReceive()
	{
		return "Не получили код?";
	}

	protected override string _GetTemplateForLabelEnterCode()
	{
		return "Введите код (6 цифр)";
	}

	protected override string _GetTemplateForLabelEnterEmailCode()
	{
		return "Введите код, отправленный вам по электронной почте";
	}

	protected override string _GetTemplateForLabelEnterTextCode()
	{
		return "Введите код, отправленный вам в сообщении";
	}

	protected override string _GetTemplateForLabelEnterTwoStepVerificationCode()
	{
		return "Введите код двухэтапной идентификации.";
	}

	protected override string _GetTemplateForLabelFacebookPasswordWarning()
	{
		return "Если вы использовали учетную запись Facebook, необходимо указать пароль.";
	}

	protected override string _GetTemplateForLabelLearnMore()
	{
		return "Подробнее";
	}

	/// <summary>
	/// Key: "Label.NeedHelpContactSupport"
	/// label for the support article link
	/// English String: "Need help? Contact {supportLink}"
	/// </summary>
	public override string LabelNeedHelpContactSupport(string supportLink)
	{
		return $"Требуется помощь? Обратитесь: {supportLink}";
	}

	protected override string _GetTemplateForLabelNeedHelpContactSupport()
	{
		return "Требуется помощь? Обратитесь: {supportLink}";
	}

	protected override string _GetTemplateForLabelNewCode()
	{
		return "Новый код";
	}

	protected override string _GetTemplateForLabelRobloxSupport()
	{
		return "Служба поддержки Roblox";
	}

	protected override string _GetTemplateForLabelTrustThisDevice()
	{
		return "Считать устройство проверенным 30 дней";
	}

	protected override string _GetTemplateForLabelTwoStepVerification()
	{
		return "Двухэтапная проверка";
	}

	protected override string _GetTemplateForResponseCodeSent()
	{
		return "Код отправлен";
	}

	protected override string _GetTemplateForResponseFeatureNotAvailable()
	{
		return "Функция недоступна. Обратитесь в службу поддержки.";
	}

	protected override string _GetTemplateForResponseInvalidCode()
	{
		return "Недопустимый код";
	}

	protected override string _GetTemplateForResponseSystemErrorReturnToLogin()
	{
		return "Ошибка системы. Вернитесь на экран входа.";
	}

	protected override string _GetTemplateForResponseTooManyAttempts()
	{
		return "Слишком много попыток. Повторите попытку позже.";
	}

	protected override string _GetTemplateForResponseTooManyCharacters()
	{
		return "Слишком много символов";
	}
}
