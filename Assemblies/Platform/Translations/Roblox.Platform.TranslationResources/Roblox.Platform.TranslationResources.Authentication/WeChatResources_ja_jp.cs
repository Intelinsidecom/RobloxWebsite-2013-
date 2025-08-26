namespace Roblox.Platform.TranslationResources.Authentication {
    /// <summary>

/// This class overrides WeChatResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class WeChatResources_ja_jp : WeChatResources_en_us, IWeChatResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.WeChatLogin"
	/// button text for logging in with WeChat (social network application)
	/// English String: "WeChat Login"
	/// </summary>
	public override string ActionWeChatLogin => "WeChatãƒ­ã‚°ã‚¤ãƒ³";

	public WeChatResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionWeChatLogin()
	{
		return "WeChatãƒ­ã‚°ã‚¤ãƒ³";
	}
}


}
