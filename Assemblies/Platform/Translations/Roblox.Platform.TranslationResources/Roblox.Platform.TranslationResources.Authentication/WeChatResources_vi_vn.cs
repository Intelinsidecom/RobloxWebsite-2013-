namespace Roblox.Platform.TranslationResources.Authentication {
    /// <summary>

/// This class overrides WeChatResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class WeChatResources_vi_vn : WeChatResources_en_us, IWeChatResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.WeChatLogin"
	/// button text for logging in with WeChat (social network application)
	/// English String: "WeChat Login"
	/// </summary>
	public override string ActionWeChatLogin => "ÄÄƒng nháº­p báº±ng WeChat";

	public WeChatResources_vi_vn(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionWeChatLogin()
	{
		return "ÄÄƒng nháº­p báº±ng WeChat";
	}
}


}
