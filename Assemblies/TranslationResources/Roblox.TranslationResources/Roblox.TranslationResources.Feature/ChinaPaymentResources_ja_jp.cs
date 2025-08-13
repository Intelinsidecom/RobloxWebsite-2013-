namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides ChinaPaymentResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ChinaPaymentResources_ja_jp : ChinaPaymentResources_en_us, IChinaPaymentResources, ITranslationResources
{
	/// <summary>
	/// Key: "Heading.Error"
	/// English String: "Error"
	/// </summary>
	public override string HeadingError => "エラー";

	/// <summary>
	/// Key: "Message.ScriptNotLoadError"
	/// English String: "We have a problem loading the Midas script now. Please try again later"
	/// </summary>
	public override string MessageScriptNotLoadError => "現在、Midas scriptの読み込みに問題があります。後でやり直してください。";

	/// <summary>
	/// Key: "Message.SessionExpiredError"
	/// English String: "Looks like your WeChat session is expired and we cannot process your request. Please log out and log in again."
	/// </summary>
	public override string MessageSessionExpiredError => "WeChatセッションが期限切れのため、リスエストを処理できませんでした。ログアウト後、ログインしなおしてください。";

	public ChinaPaymentResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForHeadingError()
	{
		return "エラー";
	}

	protected override string _GetTemplateForMessageScriptNotLoadError()
	{
		return "現在、Midas scriptの読み込みに問題があります。後でやり直してください。";
	}

	protected override string _GetTemplateForMessageSessionExpiredError()
	{
		return "WeChatセッションが期限切れのため、リスエストを処理できませんでした。ログアウト後、ログインしなおしてください。";
	}
}
