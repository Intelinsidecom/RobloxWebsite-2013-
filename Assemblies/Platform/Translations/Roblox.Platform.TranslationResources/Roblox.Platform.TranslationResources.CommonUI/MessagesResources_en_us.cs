using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.CommonUI;

internal class MessagesResources_en_us : TranslationResourcesBase, IMessagesResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "Action.PreviousPage"
	/// button title
	/// English String: "Go to the Previous Page"
	/// </summary>
	public virtual string ActionPreviousPage => "Go to the Previous Page";

	/// <summary>
	/// Key: "Action.ReturnHome"
	/// button title
	/// English String: "Return Home"
	/// </summary>
	public virtual string ActionReturnHome => "Return Home";

	/// <summary>
	/// Key: "Label.Error"
	/// English String: "Error"
	/// </summary>
	public virtual string LabelError => "Error";

	/// <summary>
	/// Key: "Label.ErrorImage"
	/// alternate text shown for error image
	/// English String: "Error Image"
	/// </summary>
	public virtual string LabelErrorImage => "Error Image";

	/// <summary>
	/// Key: "Label.TooManyCharacters"
	/// English String: "Too many characters!"
	/// </summary>
	public virtual string LabelTooManyCharacters => "Too many characters!";

	/// <summary>
	/// Key: "Message.AlwaysAllowed"
	/// English String: "Always allowed"
	/// </summary>
	public virtual string MessageAlwaysAllowed => "Always allowed";

	/// <summary>
	/// Key: "Message.AnalyiticsCookies"
	/// English String: "Analytics Cookies"
	/// </summary>
	public virtual string MessageAnalyiticsCookies => "Analytics Cookies";

	/// <summary>
	/// Key: "Message.AnalyiticsCookiesDescription"
	/// English String: "These cookies used for improving site performance or understanding site usage."
	/// </summary>
	public virtual string MessageAnalyiticsCookiesDescription => "These cookies used for improving site performance or understanding site usage.";

	/// <summary>
	/// Key: "Message.AnalyiticsCookiesItem1"
	/// English String: "Google Analytics"
	/// </summary>
	public virtual string MessageAnalyiticsCookiesItem1 => "Google Analytics";

	/// <summary>
	/// Key: "Message.AnalyiticsCookiesItem2"
	/// English String: "Google Universal Analytics"
	/// </summary>
	public virtual string MessageAnalyiticsCookiesItem2 => "Google Universal Analytics";

	/// <summary>
	/// Key: "Message.EssentialCookies"
	/// English String: "Essential Cookies"
	/// </summary>
	public virtual string MessageEssentialCookies => "Essential Cookies";

	/// <summary>
	/// Key: "Message.EssentialCookiesDescription"
	/// English String: "These cookies are required to provide the functionality on the site, such as for user authentication, securing the system or saving cookie preferences."
	/// </summary>
	public virtual string MessageEssentialCookiesDescription => "These cookies are required to provide the functionality on the site, such as for user authentication, securing the system or saving cookie preferences.";

	/// <summary>
	/// Key: "Message.EssentialCookiesItem1"
	/// English String: "Roblox"
	/// </summary>
	public virtual string MessageEssentialCookiesItem1 => "Roblox";

	/// <summary>
	/// Key: "Message.EssentialCookiesItem2"
	/// English String: "Zendesk"
	/// </summary>
	public virtual string MessageEssentialCookiesItem2 => "Zendesk";

	/// <summary>
	/// Key: "Message.ManageCookies"
	/// English String: "Manage Cookies"
	/// </summary>
	public virtual string MessageManageCookies => "Manage Cookies";

	/// <summary>
	/// Key: "MessageEssentialCookiesItem3"
	/// English String: "Gigya"
	/// </summary>
	public virtual string MessageEssentialCookiesItem3 => "Gigya";

	/// <summary>
	/// Key: "Response.AccessDenied"
	/// 403 error message
	/// English String: "Access Denied"
	/// </summary>
	public virtual string ResponseAccessDenied => "Access Denied";

	/// <summary>
	/// Key: "Response.AccessDeniedDescription"
	/// 403 error message detail
	/// English String: "You don't have permission to view this page"
	/// </summary>
	public virtual string ResponseAccessDeniedDescription => "You don't have permission to view this page";

	/// <summary>
	/// Key: "Response.BadRequest"
	/// 400 error message title
	/// English String: "Bad Request"
	/// </summary>
	public virtual string ResponseBadRequest => "Bad Request";

	/// <summary>
	/// Key: "Response.BadRequestDescription"
	/// error message detail for 400 error
	/// English String: "There was a problem with your request"
	/// </summary>
	public virtual string ResponseBadRequestDescription => "There was a problem with your request";

	/// <summary>
	/// Key: "Response.InternalServerError"
	/// 500 error message title
	/// English String: "Internal Server Error"
	/// </summary>
	public virtual string ResponseInternalServerError => "Internal Server Error";

	/// <summary>
	/// Key: "Response.InternalServerErrorDescription"
	/// 500 error message description
	/// English String: "An unexpected error occurred"
	/// </summary>
	public virtual string ResponseInternalServerErrorDescription => "An unexpected error occurred";

	/// <summary>
	/// Key: "Response.PageNotFound"
	/// 404 error message title
	/// English String: "Page Not found"
	/// </summary>
	public virtual string ResponsePageNotFound => "Page Not found";

	/// <summary>
	/// Key: "Response.PageNotFoundDescrition"
	/// 404 error message description
	/// English String: "Page cannot be found or no longer exists"
	/// </summary>
	public virtual string ResponsePageNotFoundDescrition => "Page cannot be found or no longer exists";

	/// <summary>
	/// Key: "Response.RequestError"
	/// error message for incorrect request
	/// English String: "Error with your request"
	/// </summary>
	public virtual string ResponseRequestError => "Error with your request";

	/// <summary>
	/// Key: "Response.SomethingWentWrong"
	/// default error message
	/// English String: "Something went wrong"
	/// </summary>
	public virtual string ResponseSomethingWentWrong => "Something went wrong";

	/// <summary>
	/// Key: "Response.TooManyAttemptsText"
	/// English String: "Too Many Attempts"
	/// </summary>
	public virtual string ResponseTooManyAttemptsText => "Too Many Attempts";

	/// <summary>
	/// Key: "Response.UnexpectedError"
	/// default error description
	/// English String: "An unexpected error occurred. Please try again later."
	/// </summary>
	public virtual string ResponseUnexpectedError => "An unexpected error occurred. Please try again later.";

	public MessagesResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"Action.PreviousPage",
				_GetTemplateForActionPreviousPage()
			},
			{
				"Action.ReturnHome",
				_GetTemplateForActionReturnHome()
			},
			{
				"CookieLawNoticev2",
				_GetTemplateForCookieLawNoticev2()
			},
			{
				"Description.ContactCustomerService",
				_GetTemplateForDescriptionContactCustomerService()
			},
			{
				"Label.Error",
				_GetTemplateForLabelError()
			},
			{
				"Label.ErrorImage",
				_GetTemplateForLabelErrorImage()
			},
			{
				"Label.TooManyCharacters",
				_GetTemplateForLabelTooManyCharacters()
			},
			{
				"Message.AlwaysAllowed",
				_GetTemplateForMessageAlwaysAllowed()
			},
			{
				"Message.AnalyiticsCookies",
				_GetTemplateForMessageAnalyiticsCookies()
			},
			{
				"Message.AnalyiticsCookiesDescription",
				_GetTemplateForMessageAnalyiticsCookiesDescription()
			},
			{
				"Message.AnalyiticsCookiesItem1",
				_GetTemplateForMessageAnalyiticsCookiesItem1()
			},
			{
				"Message.AnalyiticsCookiesItem2",
				_GetTemplateForMessageAnalyiticsCookiesItem2()
			},
			{
				"Message.CookieLawNotice",
				_GetTemplateForMessageCookieLawNotice()
			},
			{
				"Message.CookieLawNoticev2",
				_GetTemplateForMessageCookieLawNoticev2()
			},
			{
				"Message.CookieModalText",
				_GetTemplateForMessageCookieModalText()
			},
			{
				"Message.EssentialCookies",
				_GetTemplateForMessageEssentialCookies()
			},
			{
				"Message.EssentialCookiesDescription",
				_GetTemplateForMessageEssentialCookiesDescription()
			},
			{
				"Message.EssentialCookiesItem1",
				_GetTemplateForMessageEssentialCookiesItem1()
			},
			{
				"Message.EssentialCookiesItem2",
				_GetTemplateForMessageEssentialCookiesItem2()
			},
			{
				"Message.ManageCookies",
				_GetTemplateForMessageManageCookies()
			},
			{
				"MessageEssentialCookiesItem3",
				_GetTemplateForMessageEssentialCookiesItem3()
			},
			{
				"Response.AccessDenied",
				_GetTemplateForResponseAccessDenied()
			},
			{
				"Response.AccessDeniedDescription",
				_GetTemplateForResponseAccessDeniedDescription()
			},
			{
				"Response.BadRequest",
				_GetTemplateForResponseBadRequest()
			},
			{
				"Response.BadRequestDescription",
				_GetTemplateForResponseBadRequestDescription()
			},
			{
				"Response.InternalServerError",
				_GetTemplateForResponseInternalServerError()
			},
			{
				"Response.InternalServerErrorDescription",
				_GetTemplateForResponseInternalServerErrorDescription()
			},
			{
				"Response.PageNotFound",
				_GetTemplateForResponsePageNotFound()
			},
			{
				"Response.PageNotFoundDescrition",
				_GetTemplateForResponsePageNotFoundDescrition()
			},
			{
				"Response.RequestError",
				_GetTemplateForResponseRequestError()
			},
			{
				"Response.SomethingWentWrong",
				_GetTemplateForResponseSomethingWentWrong()
			},
			{
				"Response.TooManyAttemptsText",
				_GetTemplateForResponseTooManyAttemptsText()
			},
			{
				"Response.UnexpectedError",
				_GetTemplateForResponseUnexpectedError()
			}
		});
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "CommonUI.Messages";
	}

	protected virtual string _GetTemplateForActionPreviousPage()
	{
		return "Go to the Previous Page";
	}

	protected virtual string _GetTemplateForActionReturnHome()
	{
		return "Return Home";
	}

	/// <summary>
	/// Key: "CookieLawNoticev2"
	/// Incorrect key, obsoleted
	/// English String: "Roblox uses cookies to personalize content, provide social media features and analyze the traffic on our site. To learn about how we use cookies and how you can {startLink}manage cookie preferences{endLink}, please refer to our {startLink2}Privacy and Cookie Policy{endLink2}."
	/// </summary>
	public virtual string CookieLawNoticev2(string startLink, string endLink, string startLink2, string endLink2)
	{
		return $"Roblox uses cookies to personalize content, provide social media features and analyze the traffic on our site. To learn about how we use cookies and how you can {startLink}manage cookie preferences{endLink}, please refer to our {startLink2}Privacy and Cookie Policy{endLink2}.";
	}

	protected virtual string _GetTemplateForCookieLawNoticev2()
	{
		return "Roblox uses cookies to personalize content, provide social media features and analyze the traffic on our site. To learn about how we use cookies and how you can {startLink}manage cookie preferences{endLink}, please refer to our {startLink2}Privacy and Cookie Policy{endLink2}.";
	}

	/// <summary>
	/// Key: "Description.ContactCustomerService"
	/// message shown on common error pages
	/// English String: "If you continue to receive this page, please contact customer service at {emailLink}"
	/// </summary>
	public virtual string DescriptionContactCustomerService(string emailLink)
	{
		return $"If you continue to receive this page, please contact customer service at {emailLink}";
	}

	protected virtual string _GetTemplateForDescriptionContactCustomerService()
	{
		return "If you continue to receive this page, please contact customer service at {emailLink}";
	}

	protected virtual string _GetTemplateForLabelError()
	{
		return "Error";
	}

	protected virtual string _GetTemplateForLabelErrorImage()
	{
		return "Error Image";
	}

	protected virtual string _GetTemplateForLabelTooManyCharacters()
	{
		return "Too many characters!";
	}

	protected virtual string _GetTemplateForMessageAlwaysAllowed()
	{
		return "Always allowed";
	}

	protected virtual string _GetTemplateForMessageAnalyiticsCookies()
	{
		return "Analytics Cookies";
	}

	protected virtual string _GetTemplateForMessageAnalyiticsCookiesDescription()
	{
		return "These cookies used for improving site performance or understanding site usage.";
	}

	protected virtual string _GetTemplateForMessageAnalyiticsCookiesItem1()
	{
		return "Google Analytics";
	}

	protected virtual string _GetTemplateForMessageAnalyiticsCookiesItem2()
	{
		return "Google Universal Analytics";
	}

	/// <summary>
	/// Key: "Message.CookieLawNotice"
	/// Cookies are used for Internet-based data storage, and this message warns users that we use them to improve their experience. See https://en.wikipedia.org/wiki/HTTP_cookie for more information.
	/// English String: "Roblox uses cookies to offer you a better experience. For further information, including information on how to withdraw consent and how to manage the use of cookies on Roblox, please refer to our {startLink}Privacy and Cookie Policy{endLink}."
	/// </summary>
	public virtual string MessageCookieLawNotice(string startLink, string endLink)
	{
		return $"Roblox uses cookies to offer you a better experience. For further information, including information on how to withdraw consent and how to manage the use of cookies on Roblox, please refer to our {startLink}Privacy and Cookie Policy{endLink}.";
	}

	protected virtual string _GetTemplateForMessageCookieLawNotice()
	{
		return "Roblox uses cookies to offer you a better experience. For further information, including information on how to withdraw consent and how to manage the use of cookies on Roblox, please refer to our {startLink}Privacy and Cookie Policy{endLink}.";
	}

	/// <summary>
	/// Key: "Message.CookieLawNoticev2"
	/// English String: "Roblox uses cookies to personalize content, provide social media features and analyze the traffic on our site. To learn about how we use cookies and how you can {startLink}manage cookie preferences{endLink}, please refer to our {startLink2}Privacy and Cookie Policy{endLink2}."
	/// </summary>
	public virtual string MessageCookieLawNoticev2(string startLink, string endLink, string startLink2, string endLink2)
	{
		return $"Roblox uses cookies to personalize content, provide social media features and analyze the traffic on our site. To learn about how we use cookies and how you can {startLink}manage cookie preferences{endLink}, please refer to our {startLink2}Privacy and Cookie Policy{endLink2}.";
	}

	protected virtual string _GetTemplateForMessageCookieLawNoticev2()
	{
		return "Roblox uses cookies to personalize content, provide social media features and analyze the traffic on our site. To learn about how we use cookies and how you can {startLink}manage cookie preferences{endLink}, please refer to our {startLink2}Privacy and Cookie Policy{endLink2}.";
	}

	/// <summary>
	/// Key: "Message.CookieModalText"
	/// English String: "Please choose whether this site may use cookies as described below. You can learn more about how this site uses cookies and related technologies by reading our {startLink}privacy policy{endLink}."
	/// </summary>
	public virtual string MessageCookieModalText(string startLink, string endLink)
	{
		return $"Please choose whether this site may use cookies as described below. You can learn more about how this site uses cookies and related technologies by reading our {startLink}privacy policy{endLink}.";
	}

	protected virtual string _GetTemplateForMessageCookieModalText()
	{
		return "Please choose whether this site may use cookies as described below. You can learn more about how this site uses cookies and related technologies by reading our {startLink}privacy policy{endLink}.";
	}

	protected virtual string _GetTemplateForMessageEssentialCookies()
	{
		return "Essential Cookies";
	}

	protected virtual string _GetTemplateForMessageEssentialCookiesDescription()
	{
		return "These cookies are required to provide the functionality on the site, such as for user authentication, securing the system or saving cookie preferences.";
	}

	protected virtual string _GetTemplateForMessageEssentialCookiesItem1()
	{
		return "Roblox";
	}

	protected virtual string _GetTemplateForMessageEssentialCookiesItem2()
	{
		return "Zendesk";
	}

	protected virtual string _GetTemplateForMessageManageCookies()
	{
		return "Manage Cookies";
	}

	protected virtual string _GetTemplateForMessageEssentialCookiesItem3()
	{
		return "Gigya";
	}

	protected virtual string _GetTemplateForResponseAccessDenied()
	{
		return "Access Denied";
	}

	protected virtual string _GetTemplateForResponseAccessDeniedDescription()
	{
		return "You don't have permission to view this page";
	}

	protected virtual string _GetTemplateForResponseBadRequest()
	{
		return "Bad Request";
	}

	protected virtual string _GetTemplateForResponseBadRequestDescription()
	{
		return "There was a problem with your request";
	}

	protected virtual string _GetTemplateForResponseInternalServerError()
	{
		return "Internal Server Error";
	}

	protected virtual string _GetTemplateForResponseInternalServerErrorDescription()
	{
		return "An unexpected error occurred";
	}

	protected virtual string _GetTemplateForResponsePageNotFound()
	{
		return "Page Not found";
	}

	protected virtual string _GetTemplateForResponsePageNotFoundDescrition()
	{
		return "Page cannot be found or no longer exists";
	}

	protected virtual string _GetTemplateForResponseRequestError()
	{
		return "Error with your request";
	}

	protected virtual string _GetTemplateForResponseSomethingWentWrong()
	{
		return "Something went wrong";
	}

	protected virtual string _GetTemplateForResponseTooManyAttemptsText()
	{
		return "Too Many Attempts";
	}

	protected virtual string _GetTemplateForResponseUnexpectedError()
	{
		return "An unexpected error occurred. Please try again later.";
	}
}
