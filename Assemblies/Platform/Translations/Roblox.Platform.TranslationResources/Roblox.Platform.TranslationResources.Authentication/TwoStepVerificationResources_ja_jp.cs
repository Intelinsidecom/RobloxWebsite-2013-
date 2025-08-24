namespace Roblox.TranslationResources.Authentication;

/// <summary>
/// This class overrides TwoStepVerificationResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class TwoStepVerificationResources_ja_jp : TwoStepVerificationResources_en_us, ITwoStepVerificationResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "キャンセル";

	/// <summary>
	/// Key: "Action.Resend"
	/// English String: "Resend Code"
	/// </summary>
	public override string ActionResend => "コードを再送信";

	/// <summary>
	/// Key: "Action.StartOver"
	/// link text to restart verification
	/// English String: "Start Over"
	/// </summary>
	public override string ActionStartOver => "やり直す";

	/// <summary>
	/// Key: "Action.Submit"
	/// submit button text
	/// English String: "Submit"
	/// </summary>
	public override string ActionSubmit => "送信";

	/// <summary>
	/// Key: "Action.Verify"
	/// English String: "Verify"
	/// </summary>
	public override string ActionVerify => "確認";

	/// <summary>
	/// Key: "Label.Code"
	/// verification code for 2 factor authentication
	/// English String: "Code"
	/// </summary>
	public override string LabelCode => "コード";

	/// <summary>
	/// Key: "Label.DidNotReceive"
	/// English String: "Didn't receive the code?"
	/// </summary>
	public override string LabelDidNotReceive => "コードを受け取りませんでしたか？";

	/// <summary>
	/// Key: "Label.EnterCode"
	/// English String: "Enter Code (6-digit)"
	/// </summary>
	public override string LabelEnterCode => "コードを入力 (6桁)";

	/// <summary>
	/// Key: "Label.EnterEmailCode"
	/// English String: "Enter the code we just sent you via email"
	/// </summary>
	public override string LabelEnterEmailCode => "今メールで送信したコードを入力してください";

	/// <summary>
	/// Key: "Label.EnterTextCode"
	/// English String: "Enter the code we just sent you via text message"
	/// </summary>
	public override string LabelEnterTextCode => "今テキストメッセージで送信したコードを入力してください";

	/// <summary>
	/// Key: "Label.EnterTwoStepVerificationCode"
	/// Enter your two step verification code.
	/// English String: "Enter your two step verification code."
	/// </summary>
	public override string LabelEnterTwoStepVerificationCode => "二段階認証コードを入力してください。";

	/// <summary>
	/// Key: "Label.FacebookPasswordWarning"
	/// If you have been signing in with Facebook, you must set a password.
	/// English String: "If you have been signing in with Facebook, you must set a password."
	/// </summary>
	public override string LabelFacebookPasswordWarning => "Facebookでサインインしている場合には、パスワードの設定が必要です。";

	/// <summary>
	/// Key: "Label.LearnMore"
	/// Learn More link text
	/// English String: "Learn More"
	/// </summary>
	public override string LabelLearnMore => "詳しく知る";

	/// <summary>
	/// Key: "Label.NewCode"
	/// verification code resent, label changes to new code
	/// English String: "New Code"
	/// </summary>
	public override string LabelNewCode => "新しいコード";

	/// <summary>
	/// Key: "Label.RobloxSupport"
	/// English String: "Roblox Support"
	/// </summary>
	public override string LabelRobloxSupport => "Robloxサポート";

	/// <summary>
	/// Key: "Label.TrustThisDevice"
	/// English String: "Trust this device for 30 days"
	/// </summary>
	public override string LabelTrustThisDevice => "このデバイスを30日間信頼する";

	/// <summary>
	/// Key: "Label.TwoStepVerification"
	/// English String: "2-Step Verification"
	/// </summary>
	public override string LabelTwoStepVerification => "2段階認証";

	/// <summary>
	/// Key: "Response.CodeSent"
	/// English String: "Code Sent"
	/// </summary>
	public override string ResponseCodeSent => "コードが送信されました";

	/// <summary>
	/// Key: "Response.FeatureNotAvailable"
	/// English String: "Feature not available. Please contact support."
	/// </summary>
	public override string ResponseFeatureNotAvailable => "機能が利用できません。サポートまでご連絡ください。";

	/// <summary>
	/// Key: "Response.InvalidCode"
	/// English String: "Invalid code."
	/// </summary>
	public override string ResponseInvalidCode => "無効なコード。";

	/// <summary>
	/// Key: "Response.SystemErrorReturnToLogin"
	/// English String: "System error. Please return to login screen."
	/// </summary>
	public override string ResponseSystemErrorReturnToLogin => "システムエラー。ログイン画面にお戻りください。";

	/// <summary>
	/// Key: "Response.TooManyAttempts"
	/// English String: "Too many attempts. Please try again later."
	/// </summary>
	public override string ResponseTooManyAttempts => "試行回数が多すぎます。しばらくしてからやり直してください。";

	/// <summary>
	/// Key: "Response.TooManyCharacters"
	/// error message
	/// English String: "Too many characters"
	/// </summary>
	public override string ResponseTooManyCharacters => "文字数が多すぎます";

	public TwoStepVerificationResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "キャンセル";
	}

	protected override string _GetTemplateForActionResend()
	{
		return "コードを再送信";
	}

	protected override string _GetTemplateForActionStartOver()
	{
		return "やり直す";
	}

	protected override string _GetTemplateForActionSubmit()
	{
		return "送信";
	}

	protected override string _GetTemplateForActionVerify()
	{
		return "確認";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationActivationEmail.Body.Over13"
	/// Body for 2SV activation email for over 13 users
	/// English String: "Hi {accountName},{lineBreak}{lineBreak}You have activated 2-Step Verification for your Roblox account. Next time you log in from a new device, you will need to enter a 6-digit security code that Roblox sends to you via email.{lineBreak}{lineBreak}Roblox"
	/// </summary>
	public override string DescriptionTwoStepVerificationActivationEmailBodyOver13(string accountName, string lineBreak)
	{
		return $"{accountName}さん、こんにちは。{lineBreak}{lineBreak}Robloxアカウントの2段階認証プロセスが有効になりました。 新しいデバイスから次回ログインする時に、Robloxがメールでお送りする６桁のセキュリティコードの入力が必要となります。{lineBreak}{lineBreak}Roblox";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationActivationEmailBodyOver13()
	{
		return "{accountName}さん、こんにちは。{lineBreak}{lineBreak}Robloxアカウントの2段階認証プロセスが有効になりました。 新しいデバイスから次回ログインする時に、Robloxがメールでお送りする６桁のセキュリティコードの入力が必要となります。{lineBreak}{lineBreak}Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationActivationEmail.Body.Under13"
	/// Body for 2SV activation email for under 13 users
	/// English String: "Hi,{lineBreak}{lineBreak}2-Step Verification has been activated for your child's Roblox account, {accountName}. Next time they log in from a new device, they will need to enter a 6-digit security code that Roblox sends to you via email.{lineBreak}{lineBreak}Roblox"
	/// </summary>
	public override string DescriptionTwoStepVerificationActivationEmailBodyUnder13(string lineBreak, string accountName)
	{
		return $"こんにちは。{lineBreak}{lineBreak}お子様のRobloxアカウント{accountName}の2段階認証プロセスが有効になりました。 お子様が新しいデバイスから次回ログインする時に、Robloxがメールでお送りする６桁のセキュリティコードの入力が必要となります。{lineBreak}{lineBreak}Roblox";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationActivationEmailBodyUnder13()
	{
		return "こんにちは。{lineBreak}{lineBreak}お子様のRobloxアカウント{accountName}の2段階認証プロセスが有効になりました。 お子様が新しいデバイスから次回ログインする時に、Robloxがメールでお送りする６桁のセキュリティコードの入力が必要となります。{lineBreak}{lineBreak}Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationActivationEmail.Subject"
	/// Subject for 2SV activation email
	/// English String: "2-Step Verification Activated for Roblox Account: {accountName}"
	/// </summary>
	public override string DescriptionTwoStepVerificationActivationEmailSubject(string accountName)
	{
		return $"Robloxアカウントの2段階認証プロセスが有効になりました： {accountName}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationActivationEmailSubject()
	{
		return "Robloxアカウントの2段階認証プロセスが有効になりました： {accountName}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationDeactivationEmail.Body.Over13"
	/// Body for 2SV deactivation email for over 13 users
	/// English String: "Hi {accountName},{lineBreak}{lineBreak}You have deactivated 2-Step Verification for your Roblox account. A security code will no longer be required when you log into your account.{lineBreak}{lineBreak}Roblox"
	/// </summary>
	public override string DescriptionTwoStepVerificationDeactivationEmailBodyOver13(string accountName, string lineBreak)
	{
		return $"{accountName}さん、こんにちは。{lineBreak}{lineBreak}Robloxアカウントの2段階認証プロセスが無効になりました。 アカウントに次回ログインする時に、セキュリティコードの入力は不要になります。{lineBreak}{lineBreak}Roblox";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationDeactivationEmailBodyOver13()
	{
		return "{accountName}さん、こんにちは。{lineBreak}{lineBreak}Robloxアカウントの2段階認証プロセスが無効になりました。 アカウントに次回ログインする時に、セキュリティコードの入力は不要になります。{lineBreak}{lineBreak}Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationDeactivationEmail.Body.Under13"
	/// Body for 2SV deactivation email for under 13 users
	/// English String: "Hi,{lineBreak}{lineBreak}2-Step Verification has been deactivated for your child's Roblox account, {accountName}. A security code will no longer be required when they log into the account.{lineBreak}{lineBreak}Roblox"
	/// </summary>
	public override string DescriptionTwoStepVerificationDeactivationEmailBodyUnder13(string lineBreak, string accountName)
	{
		return $"こんにちは。{lineBreak}{lineBreak}お子様のRobloxアカウント{accountName}の2段階認証プロセスが無効になりました。 お子様がアカウントに次回ログインする時に、セキュリティコードの入力は不要になります。{lineBreak}{lineBreak}Roblox";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationDeactivationEmailBodyUnder13()
	{
		return "こんにちは。{lineBreak}{lineBreak}お子様のRobloxアカウント{accountName}の2段階認証プロセスが無効になりました。 お子様がアカウントに次回ログインする時に、セキュリティコードの入力は不要になります。{lineBreak}{lineBreak}Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationDeactivationEmail.Subject	"
	/// Subject for 2SV deactivation email
	/// English String: "2-Step Verification Deactivated for Roblox Account: {accountName}"
	/// </summary>
	public override string DescriptionTwoStepVerificationDeactivationEmailSubject(string accountName)
	{
		return $"Robloxアカウントの2段階認証プロセスが無効になりました：{accountName}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationDeactivationEmailSubject()
	{
		return "Robloxアカウントの2段階認証プロセスが無効になりました：{accountName}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo1"
	/// Geolocation information about IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {region}, {country} ({ipAddress}).{spanEndTag}{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo1(string spanStartTagWithBold, string username, string region, string country, string ipAddress, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}{country}({ipAddress})の{region}に居住する{username} からログインリクエストを受けました。{spanEndTag}{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo1()
	{
		return "{spanStartTagWithBold}{country}({ipAddress})の{region}に居住する{username} からログインリクエストを受けました。{spanEndTag}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo2"
	/// Geolocation info about IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {country} ({ipAddress}).{spanEndTag}{lineBreak}{lineBreak}\t"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo2(string spanStartTagWithBold, string username, string country, string ipAddress, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}{country}({ipAddress})に住む {username} さんからログインリクエストを受けました。{spanEndTag}{lineBreak}{lineBreak}\t";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo2()
	{
		return "{spanStartTagWithBold}{country}({ipAddress})に住む {username} さんからログインリクエストを受けました。{spanEndTag}{lineBreak}{lineBreak}\t";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo3"
	/// Geolocation info about IP trying to log in
	/// English String: "{spanStartTagWithBold}Login request received from {username} (From Roblox Internal).{spanEndTag}{lineBreak}{lineBreak}\t"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo3(string spanStartTagWithBold, string username, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}{username} (Roblox内部)からログインリクエストを受けました。{spanEndTag}{lineBreak}{lineBreak}\t";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo3()
	{
		return "{spanStartTagWithBold}{username} (Roblox内部)からログインリクエストを受けました。{spanEndTag}{lineBreak}{lineBreak}\t";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo4"
	/// Geolocation info of IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {country}.{spanEndTag}{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo4(string spanStartTagWithBold, string username, string country, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}{country}に住む {username} さんからログインリクエストを受けました。{spanEndTag}{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo4()
	{
		return "{spanStartTagWithBold}{country}に住む {username} さんからログインリクエストを受けました。{spanEndTag}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo5"
	/// Geolocation info of IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {region}, {country}.{spanEndTag}{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo5(string spanStartTagWithBold, string username, string region, string country, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}{country}、{region}に住む {username} さんからログインリクエストを受けました。{spanEndTag}{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo5()
	{
		return "{spanStartTagWithBold}{country}、{region}に住む {username} さんからログインリクエストを受けました。{spanEndTag}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo6"
	/// Geolocation info of IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {city}, {region}, {country}.{spanEndTag}{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo6(string spanStartTagWithBold, string username, string city, string region, string country, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}{country}、{region}、{city}に住む {username} さんからログインリクエストを受けました。{spanEndTag}{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo6()
	{
		return "{spanStartTagWithBold}{country}、{region}、{city}に住む {username} さんからログインリクエストを受けました。{spanEndTag}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.HtmlBody"
	/// Html body for 2SV login email
	/// English String: "{geoLocationInformation}{spanStartTagWithBold}Login code for {accountName}: {lineBreak}{lineBreak}{code} {spanEndTag}{lineBreak}{lineBreak}Enter this code into the 2-Step Verification screen to finish logging in. This code will expire in 15 minutes.{lineBreak}{lineBreak}This email was sent because your account tried to login to Roblox from a new browser or device. If you haven't tried logging into Roblox, someone else may be trying to access your account. You are strongly advised to change your password if you did not generate this request.{lineBreak}{lineBreak}Resources:{lineBreak}{aTagStartWithHref}{ChangePasswordLink}{hrefEnd}Change Your Password{aTagEnd} {lineBreak}{aTagStartWithHref}{TwoStepVerificationArticleLink}{hrefEnd}Learn More About 2-Step Verification{aTagEnd} {lineBreak}{aTagStartWithHref}{AccountSafetyArticleLink}{hrefEnd}Keeping Your Account Safe{aTagEnd} {lineBreak}{aTagStartWithHref}{SupportLink}{hrefEnd}General Roblox Support{aTagEnd} {lineBreak}{lineBreak}Thank you,{lineBreak}{lineBreak}The Roblox Team"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlBody(string geoLocationInformation, string spanStartTagWithBold, string accountName, string lineBreak, string code, string spanEndTag, string aTagStartWithHref, string ChangePasswordLink, string hrefEnd, string aTagEnd, string TwoStepVerificationArticleLink, string AccountSafetyArticleLink, string SupportLink)
	{
		return $"{geoLocationInformation}{spanStartTagWithBold}のログインコード{accountName}: {lineBreak}{lineBreak}{code}{spanEndTag}{lineBreak}{lineBreak}このコードを2段階認証画面に入力すればログインが完了します。コードは15分後に期限切れになります。{lineBreak}{lineBreak}アカウントが新しいブラウザ、またはデバイスからのRobloxへのログインに使用されたため、このメールをお送りしています。Robloxにログインしようとしていない場合はアカウントは不正アクセスされている可能性があります。このリクエストに覚えが場合はパスワードを変更することを強くおすすめします。{lineBreak}{lineBreak}リソース: {lineBreak}{aTagStartWithHref}{ChangePasswordLink}{hrefEnd}パスワードの変更{aTagEnd}{lineBreak}{aTagStartWithHref}{TwoStepVerificationArticleLink}{hrefEnd}2段階認証について {aTagEnd}{lineBreak}{aTagStartWithHref}{AccountSafetyArticleLink}{hrefEnd}アカウントを安全に保ち続けましょう {aTagEnd}{lineBreak}{aTagStartWithHref}{SupportLink}{hrefEnd}Robloxに関する全般的なサポート{aTagEnd}{lineBreak}{lineBreak}よろしくお願いいたします。{lineBreak}{lineBreak}Robloxチーム";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlBody()
	{
		return "{geoLocationInformation}{spanStartTagWithBold}のログインコード{accountName}: {lineBreak}{lineBreak}{code}{spanEndTag}{lineBreak}{lineBreak}このコードを2段階認証画面に入力すればログインが完了します。コードは15分後に期限切れになります。{lineBreak}{lineBreak}アカウントが新しいブラウザ、またはデバイスからのRobloxへのログインに使用されたため、このメールをお送りしています。Robloxにログインしようとしていない場合はアカウントは不正アクセスされている可能性があります。このリクエストに覚えが場合はパスワードを変更することを強くおすすめします。{lineBreak}{lineBreak}リソース: {lineBreak}{aTagStartWithHref}{ChangePasswordLink}{hrefEnd}パスワードの変更{aTagEnd}{lineBreak}{aTagStartWithHref}{TwoStepVerificationArticleLink}{hrefEnd}2段階認証について {aTagEnd}{lineBreak}{aTagStartWithHref}{AccountSafetyArticleLink}{hrefEnd}アカウントを安全に保ち続けましょう {aTagEnd}{lineBreak}{aTagStartWithHref}{SupportLink}{hrefEnd}Robloxに関する全般的なサポート{aTagEnd}{lineBreak}{lineBreak}よろしくお願いいたします。{lineBreak}{lineBreak}Robloxチーム";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainBody"
	/// Plain body for 2SV login email
	/// English String: "{geoLocationInformation}Login code for {accountName}: {lineBreak}{lineBreak} {code} {lineBreak}{lineBreak}Enter this code into the 2-Step Verification screen to finish logging in. This code will expire in 15 minutes. {lineBreak}{lineBreak}This email was sent because your account tried to login to Roblox from a new browser or device. If you haven't tried logging into Roblox, someone else may be trying to access your account. You are strongly advised to change your password if you did not generate this request. {lineBreak}{lineBreak}Resources: {lineBreak}Change Your Password [{accountInfoPageLink}] {lineBreak}Learn More About 2-Step Verification [{twoStepVerificationHelpArticleLink}]{lineBreak}Keeping Your Account Safe [{keepAccountSafeArticleLink}] {lineBreak}General Roblox Support [{supportPageLink}] {lineBreak}{lineBreak}Thank you, {lineBreak}{lineBreak}The Roblox Team"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainBody(string geoLocationInformation, string accountName, string lineBreak, string code, string accountInfoPageLink, string twoStepVerificationHelpArticleLink, string keepAccountSafeArticleLink, string supportPageLink)
	{
		return $"{geoLocationInformation}{accountName}のログインコード: {lineBreak}{lineBreak}{code}{lineBreak}{lineBreak}このコードを2段階認証画面に入力すればログインが完了します。コードは15分後に期限切れになります。{lineBreak}{lineBreak}アカウントが新しいブラウザ、またはデバイスからのRobloxへのログインに使用されたため、このメールをお送りしています。Robloxにログインしようとしていない場合はアカウントが不正にアクセスされている可能性があります。このリクエストに覚えがない場合はパスワードを変更することを強くおすすめします。{lineBreak}{lineBreak}リソース: {lineBreak}パスワードの変更 [{accountInfoPageLink}] {lineBreak}2段階認証について [{twoStepVerificationHelpArticleLink}]{lineBreak}アカウントを安全に保ち続けましょう [{keepAccountSafeArticleLink}] {lineBreak}Robloxに関する全般的なサポート [{supportPageLink}] {lineBreak}{lineBreak}よろしくお願いいたします。{lineBreak}{lineBreak}Robloxチーム";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainBody()
	{
		return "{geoLocationInformation}{accountName}のログインコード: {lineBreak}{lineBreak}{code}{lineBreak}{lineBreak}このコードを2段階認証画面に入力すればログインが完了します。コードは15分後に期限切れになります。{lineBreak}{lineBreak}アカウントが新しいブラウザ、またはデバイスからのRobloxへのログインに使用されたため、このメールをお送りしています。Robloxにログインしようとしていない場合はアカウントが不正にアクセスされている可能性があります。このリクエストに覚えがない場合はパスワードを変更することを強くおすすめします。{lineBreak}{lineBreak}リソース: {lineBreak}パスワードの変更 [{accountInfoPageLink}] {lineBreak}2段階認証について [{twoStepVerificationHelpArticleLink}]{lineBreak}アカウントを安全に保ち続けましょう [{keepAccountSafeArticleLink}] {lineBreak}Robloxに関する全般的なサポート [{supportPageLink}] {lineBreak}{lineBreak}よろしくお願いいたします。{lineBreak}{lineBreak}Robloxチーム";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo1"
	/// GeoLocation info of IP trying to login
	/// English String: "Login request received from {username} located in {region}, {country} ({ipAddress}).{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo1(string username, string region, string country, string ipAddress, string lineBreak)
	{
		return $" {country}の{region} ({ipAddress})に居住する{username} からログインリクエストを受けました。{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo1()
	{
		return " {country}の{region} ({ipAddress})に居住する{username} からログインリクエストを受けました。{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo2"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} located in {country} ({ipAddress}).{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo2(string username, string country, string ipAddress, string lineBreak)
	{
		return $"({ipAddress})の{country}に居住する{username} からログインリクエストを受けました。{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo2()
	{
		return "({ipAddress})の{country}に居住する{username} からログインリクエストを受けました。{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo3"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} (From Roblox Internal).{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo3(string username, string lineBreak)
	{
		return $"{username} (Roblox内部)からログインリクエストを受けました。{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo3()
	{
		return "{username} (Roblox内部)からログインリクエストを受けました。{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo4"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} located in {country}.{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo4(string username, string country, string lineBreak)
	{
		return $"{country}に居住する{username} からログインリクエストを受けました。{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo4()
	{
		return "{country}に居住する{username} からログインリクエストを受けました。{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo5"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} located in {region}, {country}.{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo5(string username, string region, string country, string lineBreak)
	{
		return $"{country}、{region}に居住する{username} からログインリクエストを受けました。{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo5()
	{
		return "{country}、{region}に居住する{username} からログインリクエストを受けました。{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo6"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} located in {city}, {region}, {country}.{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo6(string username, string city, string region, string country, string lineBreak)
	{
		return $"{country}、{region}、{city}に居住する{username} からログインリクエストを受けました。{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo6()
	{
		return "{country}、{region}、{city}に居住する{username} からログインリクエストを受けました。{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Subject"
	/// Subject for 2SV login email
	/// English String: "Verification Code for Roblox Account: {accountName}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailSubject(string accountName)
	{
		return $"Robloxアカウントの認証コード: {accountName}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailSubject()
	{
		return "Robloxアカウントの認証コード: {accountName}";
	}

	protected override string _GetTemplateForLabelCode()
	{
		return "コード";
	}

	/// <summary>
	/// Key: "Label.CodeInputPlaceholderText"
	/// example: Enter 4-digit code
	/// English String: "Enter {codeLength}-digit Code"
	/// </summary>
	public override string LabelCodeInputPlaceholderText(string codeLength)
	{
		return $"{codeLength}桁のコードを入力してください";
	}

	protected override string _GetTemplateForLabelCodeInputPlaceholderText()
	{
		return "{codeLength}桁のコードを入力してください";
	}

	protected override string _GetTemplateForLabelDidNotReceive()
	{
		return "コードを受け取りませんでしたか？";
	}

	protected override string _GetTemplateForLabelEnterCode()
	{
		return "コードを入力 (6桁)";
	}

	protected override string _GetTemplateForLabelEnterEmailCode()
	{
		return "今メールで送信したコードを入力してください";
	}

	protected override string _GetTemplateForLabelEnterTextCode()
	{
		return "今テキストメッセージで送信したコードを入力してください";
	}

	protected override string _GetTemplateForLabelEnterTwoStepVerificationCode()
	{
		return "二段階認証コードを入力してください。";
	}

	protected override string _GetTemplateForLabelFacebookPasswordWarning()
	{
		return "Facebookでサインインしている場合には、パスワードの設定が必要です。";
	}

	protected override string _GetTemplateForLabelLearnMore()
	{
		return "詳しく知る";
	}

	/// <summary>
	/// Key: "Label.NeedHelpContactSupport"
	/// label for the support article link
	/// English String: "Need help? Contact {supportLink}"
	/// </summary>
	public override string LabelNeedHelpContactSupport(string supportLink)
	{
		return $"ヘルプが必要ですか？{supportLink}までお問い合わせください";
	}

	protected override string _GetTemplateForLabelNeedHelpContactSupport()
	{
		return "ヘルプが必要ですか？{supportLink}までお問い合わせください";
	}

	protected override string _GetTemplateForLabelNewCode()
	{
		return "新しいコード";
	}

	protected override string _GetTemplateForLabelRobloxSupport()
	{
		return "Robloxサポート";
	}

	protected override string _GetTemplateForLabelTrustThisDevice()
	{
		return "このデバイスを30日間信頼する";
	}

	protected override string _GetTemplateForLabelTwoStepVerification()
	{
		return "2段階認証";
	}

	protected override string _GetTemplateForResponseCodeSent()
	{
		return "コードが送信されました";
	}

	protected override string _GetTemplateForResponseFeatureNotAvailable()
	{
		return "機能が利用できません。サポートまでご連絡ください。";
	}

	protected override string _GetTemplateForResponseInvalidCode()
	{
		return "無効なコード。";
	}

	protected override string _GetTemplateForResponseSystemErrorReturnToLogin()
	{
		return "システムエラー。ログイン画面にお戻りください。";
	}

	protected override string _GetTemplateForResponseTooManyAttempts()
	{
		return "試行回数が多すぎます。しばらくしてからやり直してください。";
	}

	protected override string _GetTemplateForResponseTooManyCharacters()
	{
		return "文字数が多すぎます";
	}
}
