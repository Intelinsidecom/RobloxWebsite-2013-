namespace Roblox.TranslationResources.Authentication;

/// <summary>
/// This class overrides SecurityNotificationResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class SecurityNotificationResources_ko_kr : SecurityNotificationResources_en_us, ISecurityNotificationResources, ITranslationResources
{
	/// <summary>
	/// Key: "Heading.Important"
	/// English String: "Important"
	/// </summary>
	public override string HeadingImportant => "중요";

	public SecurityNotificationResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	/// <summary>
	/// Key: "Description.SecurityNotificationText"
	/// English String: "For the safety and security of your account, your Roblox password has been reset. To regain access to your account, please type in your email or phone number and click the submit button on this page. If you do not have an email or phone number associated with your account, please contact Roblox customer service at {aTagStartWithHref}{emailMailToLink}{hrefEnd}{emailText}{aTagEnd}."
	/// </summary>
	public override string DescriptionSecurityNotificationText(string aTagStartWithHref, string emailMailToLink, string hrefEnd, string emailText, string aTagEnd)
	{
		return $"회원님 계정의 안전과 보안을 위해 비밀번호가 재설정되었습니다. 계정에 다시 접근하려면 이 페이지에 이메일 또는 전화번호를 입력하고 제출 버튼을 클릭하세요. 계정과 연결된 이메일 또는 전화번호가 없는 경우, Roblox 지원 센터{aTagStartWithHref}{emailMailToLink}{hrefEnd}{emailText}{aTagEnd}에 문의하세요.";
	}

	protected override string _GetTemplateForDescriptionSecurityNotificationText()
	{
		return "회원님 계정의 안전과 보안을 위해 비밀번호가 재설정되었습니다. 계정에 다시 접근하려면 이 페이지에 이메일 또는 전화번호를 입력하고 제출 버튼을 클릭하세요. 계정과 연결된 이메일 또는 전화번호가 없는 경우, Roblox 지원 센터{aTagStartWithHref}{emailMailToLink}{hrefEnd}{emailText}{aTagEnd}에 문의하세요.";
	}

	/// <summary>
	/// Key: "Description.SecurityNotificationTextWarning"
	/// English String: "Please choose a password that is brand {startSpan}new{endSpan} and {startSpan}unique{endSpan} to Roblox, do not use this password on any other site. This is the best way to prevent your Roblox account from getting compromised."
	/// </summary>
	public override string DescriptionSecurityNotificationTextWarning(string startSpan, string endSpan)
	{
		return $"Roblox에서만 사용하는 {startSpan}새롭고{endSpan} {startSpan}독특한{endSpan} 비밀번호를 만들고, 다른 사이트에서는 이 비밀번호를 사용하지 마세요. 회원님의 Roblox 계정을 보호할 수 있는 가장 좋은 방법입니다.";
	}

	protected override string _GetTemplateForDescriptionSecurityNotificationTextWarning()
	{
		return "Roblox에서만 사용하는 {startSpan}새롭고{endSpan} {startSpan}독특한{endSpan} 비밀번호를 만들고, 다른 사이트에서는 이 비밀번호를 사용하지 마세요. 회원님의 Roblox 계정을 보호할 수 있는 가장 좋은 방법입니다.";
	}

	protected override string _GetTemplateForHeadingImportant()
	{
		return "중요";
	}
}
