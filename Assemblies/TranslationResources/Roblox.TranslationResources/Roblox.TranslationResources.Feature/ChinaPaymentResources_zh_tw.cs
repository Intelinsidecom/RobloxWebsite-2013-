namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides ChinaPaymentResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ChinaPaymentResources_zh_tw : ChinaPaymentResources_en_us, IChinaPaymentResources, ITranslationResources
{
	/// <summary>
	/// Key: "Heading.Error"
	/// English String: "Error"
	/// </summary>
	public override string HeadingError => "錯誤";

	/// <summary>
	/// Key: "Message.ScriptNotLoadError"
	/// English String: "We have a problem loading the Midas script now. Please try again later"
	/// </summary>
	public override string MessageScriptNotLoadError => "載入 Midas 腳本發生錯誤，請稍後再試。";

	/// <summary>
	/// Key: "Message.SessionExpiredError"
	/// English String: "Looks like your WeChat session is expired and we cannot process your request. Please log out and log in again."
	/// </summary>
	public override string MessageSessionExpiredError => "無法處理請求，您的微信登入似乎逾時。請重新登入。";

	public ChinaPaymentResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForHeadingError()
	{
		return "錯誤";
	}

	protected override string _GetTemplateForMessageScriptNotLoadError()
	{
		return "載入 Midas 腳本發生錯誤，請稍後再試。";
	}

	protected override string _GetTemplateForMessageSessionExpiredError()
	{
		return "無法處理請求，您的微信登入似乎逾時。請重新登入。";
	}
}
