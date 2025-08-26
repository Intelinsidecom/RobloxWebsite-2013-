namespace Roblox.Platform.TranslationResources.Authentication {
    /// <summary>

/// This class overrides TencentResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class TencentResources_ko_kr : TencentResources_en_us, ITencentResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.QQLogin"
	/// button text for logging in with QQ (social network application)
	/// English String: "QQ Login"
	/// </summary>
	public override string ActionQQLogin => "QQ ë¡œê·¸ì¸";

	/// <summary>
	/// Key: "Action.WeChatLogin"
	/// button text for logging in with WeChat (social network application)
	/// English String: "WeChat Login"
	/// </summary>
	public override string ActionWeChatLogin => "WeChat ë¡œê·¸ì¸";

	public TencentResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionQQLogin()
	{
		return "QQ ë¡œê·¸ì¸";
	}

	protected override string _GetTemplateForActionWeChatLogin()
	{
		return "WeChat ë¡œê·¸ì¸";
	}
}


}
