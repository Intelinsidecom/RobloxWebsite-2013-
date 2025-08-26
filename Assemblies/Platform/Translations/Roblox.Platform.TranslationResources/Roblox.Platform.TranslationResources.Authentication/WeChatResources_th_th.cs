namespace Roblox.Platform.TranslationResources.Authentication {
    /// <summary>

/// This class overrides WeChatResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class WeChatResources_th_th : WeChatResources_en_us, IWeChatResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.WeChatLogin"
	/// button text for logging in with WeChat (social network application)
	/// English String: "WeChat Login"
	/// </summary>
	public override string ActionWeChatLogin => "à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸£à¸°à¸šà¸š WeChat";

	public WeChatResources_th_th(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionWeChatLogin()
	{
		return "à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸£à¸°à¸šà¸š WeChat";
	}
}


}
