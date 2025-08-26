namespace Roblox.Platform.TranslationResources.Authentication {
    /// <summary>

/// This class overrides WeChatResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class WeChatResources_ru_ru : WeChatResources_en_us, IWeChatResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.WeChatLogin"
	/// button text for logging in with WeChat (social network application)
	/// English String: "WeChat Login"
	/// </summary>
	public override string ActionWeChatLogin => "Ð’Ñ…Ð¾Ð´ Ð² WeChat";

	public WeChatResources_ru_ru(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionWeChatLogin()
	{
		return "Ð’Ñ…Ð¾Ð´ Ð² WeChat";
	}
}


}
