namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides ChinaPaymentResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ChinaPaymentResources_zh_cn : ChinaPaymentResources_en_us, IChinaPaymentResources, ITranslationResources
{
	/// <summary>
	/// Key: "Heading.Error"
	/// English String: "Error"
	/// </summary>
	public override string HeadingError => "错误";

	/// <summary>
	/// Key: "Message.ScriptNotLoadError"
	/// English String: "We have a problem loading the Midas script now. Please try again later"
	/// </summary>
	public override string MessageScriptNotLoadError => "加载 Midas 脚本时遇到问题。请稍后重试。";

	/// <summary>
	/// Key: "Message.SessionExpiredError"
	/// English String: "Looks like your WeChat session is expired and we cannot process your request. Please log out and log in again."
	/// </summary>
	public override string MessageSessionExpiredError => "你的微信会话似乎已过期，我们无法处理你的请求。请退出登录并重试。";

	public ChinaPaymentResources_zh_cn(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForHeadingError()
	{
		return "错误";
	}

	protected override string _GetTemplateForMessageScriptNotLoadError()
	{
		return "加载 Midas 脚本时遇到问题。请稍后重试。";
	}

	protected override string _GetTemplateForMessageSessionExpiredError()
	{
		return "你的微信会话似乎已过期，我们无法处理你的请求。请退出登录并重试。";
	}
}
