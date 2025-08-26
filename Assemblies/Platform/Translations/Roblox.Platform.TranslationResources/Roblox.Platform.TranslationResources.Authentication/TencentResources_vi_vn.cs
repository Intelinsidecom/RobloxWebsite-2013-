namespace Roblox.Platform.TranslationResources.Authentication {
    /// <summary>

/// This class overrides TencentResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class TencentResources_vi_vn : TencentResources_en_us, ITencentResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.QQLogin"
	/// button text for logging in with QQ (social network application)
	/// English String: "QQ Login"
	/// </summary>
	public override string ActionQQLogin => "ÄÄƒng nháº­p báº±ng QQ";

	/// <summary>
	/// Key: "Action.WeChatLogin"
	/// button text for logging in with WeChat (social network application)
	/// English String: "WeChat Login"
	/// </summary>
	public override string ActionWeChatLogin => "ÄÄƒng nháº­p báº±ng WeChat";

	public TencentResources_vi_vn(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionQQLogin()
	{
		return "ÄÄƒng nháº­p báº±ng QQ";
	}

	protected override string _GetTemplateForActionWeChatLogin()
	{
		return "ÄÄƒng nháº­p báº±ng WeChat";
	}
}


}
