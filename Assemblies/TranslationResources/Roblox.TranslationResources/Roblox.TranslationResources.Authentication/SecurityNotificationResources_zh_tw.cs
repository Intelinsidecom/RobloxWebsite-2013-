namespace Roblox.TranslationResources.Authentication;

/// <summary>
/// This class overrides SecurityNotificationResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class SecurityNotificationResources_zh_tw : SecurityNotificationResources_en_us, ISecurityNotificationResources, ITranslationResources
{
	/// <summary>
	/// Key: "Heading.Important"
	/// English String: "Important"
	/// </summary>
	public override string HeadingImportant => "重要";

	public SecurityNotificationResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	/// <summary>
	/// Key: "Description.SecurityNotificationText"
	/// English String: "For the safety and security of your account, your Roblox password has been reset. To regain access to your account, please type in your email or phone number and click the submit button on this page. If you do not have an email or phone number associated with your account, please contact Roblox customer service at {aTagStartWithHref}{emailMailToLink}{hrefEnd}{emailText}{aTagEnd}."
	/// </summary>
	public override string DescriptionSecurityNotificationText(string aTagStartWithHref, string emailMailToLink, string hrefEnd, string emailText, string aTagEnd)
	{
		return $"為了維護您的帳號的安全，您的 Roblox 密碼已被重製。若要取回您的帳號，請在此頁面的「提交」按鈕輸入您的電子郵件地址或手機號碼。若您的帳號沒有電子郵件地址或手機號碼。請在 {aTagStartWithHref}{emailMailToLink}{hrefEnd}{emailText}{aTagEnd} 聯絡 Roblox 客服人員。";
	}

	protected override string _GetTemplateForDescriptionSecurityNotificationText()
	{
		return "為了維護您的帳號的安全，您的 Roblox 密碼已被重製。若要取回您的帳號，請在此頁面的「提交」按鈕輸入您的電子郵件地址或手機號碼。若您的帳號沒有電子郵件地址或手機號碼。請在 {aTagStartWithHref}{emailMailToLink}{hrefEnd}{emailText}{aTagEnd} 聯絡 Roblox 客服人員。";
	}

	/// <summary>
	/// Key: "Description.SecurityNotificationTextWarning"
	/// English String: "Please choose a password that is brand {startSpan}new{endSpan} and {startSpan}unique{endSpan} to Roblox, do not use this password on any other site. This is the best way to prevent your Roblox account from getting compromised."
	/// </summary>
	public override string DescriptionSecurityNotificationTextWarning(string startSpan, string endSpan)
	{
		return $"請選擇{startSpan}全新{endSpan}且{startSpan}只用於 Roblox {endSpan}的密碼。請勿在其它網站上使用此密碼，以免您的 Roblox 帳號遭到入侵。";
	}

	protected override string _GetTemplateForDescriptionSecurityNotificationTextWarning()
	{
		return "請選擇{startSpan}全新{endSpan}且{startSpan}只用於 Roblox {endSpan}的密碼。請勿在其它網站上使用此密碼，以免您的 Roblox 帳號遭到入侵。";
	}

	protected override string _GetTemplateForHeadingImportant()
	{
		return "重要";
	}
}
