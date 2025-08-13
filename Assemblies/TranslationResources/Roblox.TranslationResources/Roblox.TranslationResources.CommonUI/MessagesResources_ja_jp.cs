namespace Roblox.TranslationResources.CommonUI;

/// <summary>
/// This class overrides MessagesResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class MessagesResources_ja_jp : MessagesResources_en_us, IMessagesResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.PreviousPage"
	/// button title
	/// English String: "Go to the Previous Page"
	/// </summary>
	public override string ActionPreviousPage => "前のページに戻る";

	/// <summary>
	/// Key: "Action.ReturnHome"
	/// button title
	/// English String: "Return Home"
	/// </summary>
	public override string ActionReturnHome => "ホーム画面に戻る";

	/// <summary>
	/// Key: "Label.Error"
	/// English String: "Error"
	/// </summary>
	public override string LabelError => "エラー";

	/// <summary>
	/// Key: "Label.ErrorImage"
	/// alternate text shown for error image
	/// English String: "Error Image"
	/// </summary>
	public override string LabelErrorImage => "エラー画像";

	/// <summary>
	/// Key: "Label.TooManyCharacters"
	/// English String: "Too many characters!"
	/// </summary>
	public override string LabelTooManyCharacters => "文字数が多すぎます！";

	/// <summary>
	/// Key: "Message.AlwaysAllowed"
	/// English String: "Always allowed"
	/// </summary>
	public override string MessageAlwaysAllowed => "常に許可";

	/// <summary>
	/// Key: "Message.AnalyiticsCookies"
	/// English String: "Analytics Cookies"
	/// </summary>
	public override string MessageAnalyiticsCookies => "分析クッキー";

	/// <summary>
	/// Key: "Message.AnalyiticsCookiesDescription"
	/// English String: "These cookies used for improving site performance or understanding site usage."
	/// </summary>
	public override string MessageAnalyiticsCookiesDescription => "これらのクッキーはサイトのパフォーマンス改善やサイトがどのように使用されているかを理解するために使用されています。";

	/// <summary>
	/// Key: "Message.AnalyiticsCookiesItem1"
	/// English String: "Google Analytics"
	/// </summary>
	public override string MessageAnalyiticsCookiesItem1 => "Google アナリティクス";

	/// <summary>
	/// Key: "Message.AnalyiticsCookiesItem2"
	/// English String: "Google Universal Analytics"
	/// </summary>
	public override string MessageAnalyiticsCookiesItem2 => "Google ユニバース アナリティクス";

	/// <summary>
	/// Key: "Message.EssentialCookies"
	/// English String: "Essential Cookies"
	/// </summary>
	public override string MessageEssentialCookies => "エッセンシャルクッキー";

	/// <summary>
	/// Key: "Message.EssentialCookiesDescription"
	/// English String: "These cookies are required to provide the functionality on the site, such as for user authentication, securing the system or saving cookie preferences."
	/// </summary>
	public override string MessageEssentialCookiesDescription => "これらのクッキーはユーザー認証やシステム保全、クッキー環境設定の保存などのサイト機能を提供するために必要です。";

	/// <summary>
	/// Key: "Message.EssentialCookiesItem1"
	/// English String: "Roblox"
	/// </summary>
	public override string MessageEssentialCookiesItem1 => "Roblox";

	/// <summary>
	/// Key: "Message.EssentialCookiesItem2"
	/// English String: "Zendesk"
	/// </summary>
	public override string MessageEssentialCookiesItem2 => "Zendesk";

	/// <summary>
	/// Key: "Message.ManageCookies"
	/// English String: "Manage Cookies"
	/// </summary>
	public override string MessageManageCookies => "クッキー管理";

	/// <summary>
	/// Key: "MessageEssentialCookiesItem3"
	/// English String: "Gigya"
	/// </summary>
	public override string MessageEssentialCookiesItem3 => "Gigya";

	/// <summary>
	/// Key: "Response.AccessDenied"
	/// 403 error message
	/// English String: "Access Denied"
	/// </summary>
	public override string ResponseAccessDenied => "アクセス禁止";

	/// <summary>
	/// Key: "Response.AccessDeniedDescription"
	/// 403 error message detail
	/// English String: "You don't have permission to view this page"
	/// </summary>
	public override string ResponseAccessDeniedDescription => "このページを見る権限がありません";

	/// <summary>
	/// Key: "Response.BadRequest"
	/// 400 error message title
	/// English String: "Bad Request"
	/// </summary>
	public override string ResponseBadRequest => "不当なリクエスト";

	/// <summary>
	/// Key: "Response.BadRequestDescription"
	/// error message detail for 400 error
	/// English String: "There was a problem with your request"
	/// </summary>
	public override string ResponseBadRequestDescription => "リクエストにエラーが発生しました";

	/// <summary>
	/// Key: "Response.InternalServerError"
	/// 500 error message title
	/// English String: "Internal Server Error"
	/// </summary>
	public override string ResponseInternalServerError => "内部サーバーエラー";

	/// <summary>
	/// Key: "Response.InternalServerErrorDescription"
	/// 500 error message description
	/// English String: "An unexpected error occurred"
	/// </summary>
	public override string ResponseInternalServerErrorDescription => "予期せぬエラーが発生しました";

	/// <summary>
	/// Key: "Response.PageNotFound"
	/// 404 error message title
	/// English String: "Page Not found"
	/// </summary>
	public override string ResponsePageNotFound => "ページが見つかりませんでした";

	/// <summary>
	/// Key: "Response.PageNotFoundDescrition"
	/// 404 error message description
	/// English String: "Page cannot be found or no longer exists"
	/// </summary>
	public override string ResponsePageNotFoundDescrition => "ページを表示できないか、既に存在しません";

	/// <summary>
	/// Key: "Response.RequestError"
	/// error message for incorrect request
	/// English String: "Error with your request"
	/// </summary>
	public override string ResponseRequestError => "リクエストのエラー";

	/// <summary>
	/// Key: "Response.SomethingWentWrong"
	/// default error message
	/// English String: "Something went wrong"
	/// </summary>
	public override string ResponseSomethingWentWrong => "問題が起きたようです";

	/// <summary>
	/// Key: "Response.TooManyAttemptsText"
	/// English String: "Too Many Attempts"
	/// </summary>
	public override string ResponseTooManyAttemptsText => "試行回数が多すぎます";

	/// <summary>
	/// Key: "Response.UnexpectedError"
	/// default error description
	/// English String: "An unexpected error occurred. Please try again later."
	/// </summary>
	public override string ResponseUnexpectedError => "不明なエラーが発生しました。後でもう一度お試しください。";

	public MessagesResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionPreviousPage()
	{
		return "前のページに戻る";
	}

	protected override string _GetTemplateForActionReturnHome()
	{
		return "ホーム画面に戻る";
	}

	/// <summary>
	/// Key: "CookieLawNoticev2"
	/// Incorrect key, obsoleted
	/// English String: "Roblox uses cookies to personalize content, provide social media features and analyze the traffic on our site. To learn about how we use cookies and how you can {startLink}manage cookie preferences{endLink}, please refer to our {startLink2}Privacy and Cookie Policy{endLink2}."
	/// </summary>
	public override string CookieLawNoticev2(string startLink, string endLink, string startLink2, string endLink2)
	{
		return $"Robloxはコンテンツのパーソナライズ、ソーシャルメディア機能の提供、サイト上のトラフィック分析のためにクッキーを使用しています。Robloxによるクッキー使用の内容を確認し、{startLink}クッキー環境設定の管理{endLink}を行うには、{startLink2}プライバシーおよびクッキーポリシー{endLink2}をご覧ください。";
	}

	protected override string _GetTemplateForCookieLawNoticev2()
	{
		return "Robloxはコンテンツのパーソナライズ、ソーシャルメディア機能の提供、サイト上のトラフィック分析のためにクッキーを使用しています。Robloxによるクッキー使用の内容を確認し、{startLink}クッキー環境設定の管理{endLink}を行うには、{startLink2}プライバシーおよびクッキーポリシー{endLink2}をご覧ください。";
	}

	/// <summary>
	/// Key: "Description.ContactCustomerService"
	/// message shown on common error pages
	/// English String: "If you continue to receive this page, please contact customer service at {emailLink}"
	/// </summary>
	public override string DescriptionContactCustomerService(string emailLink)
	{
		return $"このページが続けて表示される場合はカスターサービスにメールでお問い合わせください:{emailLink}";
	}

	protected override string _GetTemplateForDescriptionContactCustomerService()
	{
		return "このページが続けて表示される場合はカスターサービスにメールでお問い合わせください:{emailLink}";
	}

	protected override string _GetTemplateForLabelError()
	{
		return "エラー";
	}

	protected override string _GetTemplateForLabelErrorImage()
	{
		return "エラー画像";
	}

	protected override string _GetTemplateForLabelTooManyCharacters()
	{
		return "文字数が多すぎます！";
	}

	protected override string _GetTemplateForMessageAlwaysAllowed()
	{
		return "常に許可";
	}

	protected override string _GetTemplateForMessageAnalyiticsCookies()
	{
		return "分析クッキー";
	}

	protected override string _GetTemplateForMessageAnalyiticsCookiesDescription()
	{
		return "これらのクッキーはサイトのパフォーマンス改善やサイトがどのように使用されているかを理解するために使用されています。";
	}

	protected override string _GetTemplateForMessageAnalyiticsCookiesItem1()
	{
		return "Google アナリティクス";
	}

	protected override string _GetTemplateForMessageAnalyiticsCookiesItem2()
	{
		return "Google ユニバース アナリティクス";
	}

	/// <summary>
	/// Key: "Message.CookieLawNotice"
	/// Cookies are used for Internet-based data storage, and this message warns users that we use them to improve their experience. See https://en.wikipedia.org/wiki/HTTP_cookie for more information.
	/// English String: "Roblox uses cookies to offer you a better experience. For further information, including information on how to withdraw consent and how to manage the use of cookies on Roblox, please refer to our {startLink}Privacy and Cookie Policy{endLink}."
	/// </summary>
	public override string MessageCookieLawNotice(string startLink, string endLink)
	{
		return $"Robloxではより良い体験をご提供するために、クッキーを利用しております。 同意を取り消す方法や、Robloxでの クッキーの管理方法などの詳細については、{startLink}プライバシーおよびクッキーポリシー{endLink}をご参照ください。";
	}

	protected override string _GetTemplateForMessageCookieLawNotice()
	{
		return "Robloxではより良い体験をご提供するために、クッキーを利用しております。 同意を取り消す方法や、Robloxでの クッキーの管理方法などの詳細については、{startLink}プライバシーおよびクッキーポリシー{endLink}をご参照ください。";
	}

	/// <summary>
	/// Key: "Message.CookieLawNoticev2"
	/// English String: "Roblox uses cookies to personalize content, provide social media features and analyze the traffic on our site. To learn about how we use cookies and how you can {startLink}manage cookie preferences{endLink}, please refer to our {startLink2}Privacy and Cookie Policy{endLink2}."
	/// </summary>
	public override string MessageCookieLawNoticev2(string startLink, string endLink, string startLink2, string endLink2)
	{
		return $"Robloxはコンテンツのパーソナライズ、ソーシャルメディア機能の提供、サイト上のトラフィック分析のためにクッキーを使用しています。Robloxによるクッキー使用の内容を確認し、{startLink}クッキー環境設定の管理{endLink}を行うには、{startLink2}プライバシーおよびクッキーポリシー{endLink2}をご覧ください。";
	}

	protected override string _GetTemplateForMessageCookieLawNoticev2()
	{
		return "Robloxはコンテンツのパーソナライズ、ソーシャルメディア機能の提供、サイト上のトラフィック分析のためにクッキーを使用しています。Robloxによるクッキー使用の内容を確認し、{startLink}クッキー環境設定の管理{endLink}を行うには、{startLink2}プライバシーおよびクッキーポリシー{endLink2}をご覧ください。";
	}

	/// <summary>
	/// Key: "Message.CookieModalText"
	/// English String: "Please choose whether this site may use cookies as described below. You can learn more about how this site uses cookies and related technologies by reading our {startLink}privacy policy{endLink}."
	/// </summary>
	public override string MessageCookieModalText(string startLink, string endLink)
	{
		return $"下で説明されている内容でサイトがクッキーを使用するかどうかを選んでください。本サイトがクッキーおよび関連技術を使用する内容の詳細については、{startLink}プライバシーポリシー{endLink}をご覧ください。";
	}

	protected override string _GetTemplateForMessageCookieModalText()
	{
		return "下で説明されている内容でサイトがクッキーを使用するかどうかを選んでください。本サイトがクッキーおよび関連技術を使用する内容の詳細については、{startLink}プライバシーポリシー{endLink}をご覧ください。";
	}

	protected override string _GetTemplateForMessageEssentialCookies()
	{
		return "エッセンシャルクッキー";
	}

	protected override string _GetTemplateForMessageEssentialCookiesDescription()
	{
		return "これらのクッキーはユーザー認証やシステム保全、クッキー環境設定の保存などのサイト機能を提供するために必要です。";
	}

	protected override string _GetTemplateForMessageEssentialCookiesItem1()
	{
		return "Roblox";
	}

	protected override string _GetTemplateForMessageEssentialCookiesItem2()
	{
		return "Zendesk";
	}

	protected override string _GetTemplateForMessageManageCookies()
	{
		return "クッキー管理";
	}

	protected override string _GetTemplateForMessageEssentialCookiesItem3()
	{
		return "Gigya";
	}

	protected override string _GetTemplateForResponseAccessDenied()
	{
		return "アクセス禁止";
	}

	protected override string _GetTemplateForResponseAccessDeniedDescription()
	{
		return "このページを見る権限がありません";
	}

	protected override string _GetTemplateForResponseBadRequest()
	{
		return "不当なリクエスト";
	}

	protected override string _GetTemplateForResponseBadRequestDescription()
	{
		return "リクエストにエラーが発生しました";
	}

	protected override string _GetTemplateForResponseInternalServerError()
	{
		return "内部サーバーエラー";
	}

	protected override string _GetTemplateForResponseInternalServerErrorDescription()
	{
		return "予期せぬエラーが発生しました";
	}

	protected override string _GetTemplateForResponsePageNotFound()
	{
		return "ページが見つかりませんでした";
	}

	protected override string _GetTemplateForResponsePageNotFoundDescrition()
	{
		return "ページを表示できないか、既に存在しません";
	}

	protected override string _GetTemplateForResponseRequestError()
	{
		return "リクエストのエラー";
	}

	protected override string _GetTemplateForResponseSomethingWentWrong()
	{
		return "問題が起きたようです";
	}

	protected override string _GetTemplateForResponseTooManyAttemptsText()
	{
		return "試行回数が多すぎます";
	}

	protected override string _GetTemplateForResponseUnexpectedError()
	{
		return "不明なエラーが発生しました。後でもう一度お試しください。";
	}
}
