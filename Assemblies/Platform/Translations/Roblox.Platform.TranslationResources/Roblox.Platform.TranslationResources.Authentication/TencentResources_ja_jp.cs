namespace Roblox.Platform.TranslationResources.Authentication {
    /// <summary>

/// This class overrides TencentResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class TencentResources_ja_jp : TencentResources_en_us, ITencentResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.QQLogin"
	/// button text for logging in with QQ (social network application)
	/// English String: "QQ Login"
	/// </summary>
	public override string ActionQQLogin => "ãƒ†ãƒ³ã‚»ãƒ³ãƒˆQQãƒ­ã‚°ã‚¤ãƒ³";

	/// <summary>
	/// Key: "Action.WeChatLogin"
	/// button text for logging in with WeChat (social network application)
	/// English String: "WeChat Login"
	/// </summary>
	public override string ActionWeChatLogin => "WeChatãƒ­ã‚°ã‚¤ãƒ³";

	public TencentResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionQQLogin()
	{
		return "ãƒ†ãƒ³ã‚»ãƒ³ãƒˆQQãƒ­ã‚°ã‚¤ãƒ³";
	}

	protected override string _GetTemplateForActionWeChatLogin()
	{
		return "WeChatãƒ­ã‚°ã‚¤ãƒ³";
	}
}


}
