namespace Roblox.Platform.TranslationResources.Authentication {
    /// <summary>

/// This class overrides TencentResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class TencentResources_ru_ru : TencentResources_en_us, ITencentResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.QQLogin"
	/// button text for logging in with QQ (social network application)
	/// English String: "QQ Login"
	/// </summary>
	public override string ActionQQLogin => "QQ Ð²Ñ…Ð¾Ð´";

	/// <summary>
	/// Key: "Action.WeChatLogin"
	/// button text for logging in with WeChat (social network application)
	/// English String: "WeChat Login"
	/// </summary>
	public override string ActionWeChatLogin => "Ð’Ñ…Ð¾Ð´ Ð² WeChat";

	public TencentResources_ru_ru(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionQQLogin()
	{
		return "QQ Ð²Ñ…Ð¾Ð´";
	}

	protected override string _GetTemplateForActionWeChatLogin()
	{
		return "Ð’Ñ…Ð¾Ð´ Ð² WeChat";
	}
}


}
