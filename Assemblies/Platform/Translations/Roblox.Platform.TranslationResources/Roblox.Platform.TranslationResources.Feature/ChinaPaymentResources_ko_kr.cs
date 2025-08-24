namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides ChinaPaymentResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ChinaPaymentResources_ko_kr : ChinaPaymentResources_en_us, IChinaPaymentResources, ITranslationResources
{
	/// <summary>
	/// Key: "Heading.Error"
	/// English String: "Error"
	/// </summary>
	public override string HeadingError => "오류";

	/// <summary>
	/// Key: "Message.ScriptNotLoadError"
	/// English String: "We have a problem loading the Midas script now. Please try again later"
	/// </summary>
	public override string MessageScriptNotLoadError => "지금 Midas 스크립트를 불러오는 데에 문제가 있습니다. 잠시 후에 다시 시도하세요.";

	/// <summary>
	/// Key: "Message.SessionExpiredError"
	/// English String: "Looks like your WeChat session is expired and we cannot process your request. Please log out and log in again."
	/// </summary>
	public override string MessageSessionExpiredError => "WeChat 세션이 만료되어 요청을 처리할 수 없어요. 로그아웃하여 다시 로그인하세요.";

	public ChinaPaymentResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForHeadingError()
	{
		return "오류";
	}

	protected override string _GetTemplateForMessageScriptNotLoadError()
	{
		return "지금 Midas 스크립트를 불러오는 데에 문제가 있습니다. 잠시 후에 다시 시도하세요.";
	}

	protected override string _GetTemplateForMessageSessionExpiredError()
	{
		return "WeChat 세션이 만료되어 요청을 처리할 수 없어요. 로그아웃하여 다시 로그인하세요.";
	}
}
