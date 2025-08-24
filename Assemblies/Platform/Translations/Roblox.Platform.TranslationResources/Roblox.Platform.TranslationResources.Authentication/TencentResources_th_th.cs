namespace Roblox.TranslationResources.Authentication;

/// <summary>
/// This class overrides TencentResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class TencentResources_th_th : TencentResources_en_us, ITencentResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.QQLogin"
	/// button text for logging in with QQ (social network application)
	/// English String: "QQ Login"
	/// </summary>
	public override string ActionQQLogin => "เข\u0e49าส\u0e39\u0e48ระบบ QQ";

	/// <summary>
	/// Key: "Action.WeChatLogin"
	/// button text for logging in with WeChat (social network application)
	/// English String: "WeChat Login"
	/// </summary>
	public override string ActionWeChatLogin => "เข\u0e49าส\u0e39\u0e48ระบบ WeChat";

	public TencentResources_th_th(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionQQLogin()
	{
		return "เข\u0e49าส\u0e39\u0e48ระบบ QQ";
	}

	protected override string _GetTemplateForActionWeChatLogin()
	{
		return "เข\u0e49าส\u0e39\u0e48ระบบ WeChat";
	}
}
