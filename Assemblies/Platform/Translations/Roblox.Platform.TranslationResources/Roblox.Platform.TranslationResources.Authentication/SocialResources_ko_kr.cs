namespace Roblox.Platform.TranslationResources.Authentication {
    /// <summary>

/// This class overrides SocialResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class SocialResources_ko_kr : SocialResources_en_us, ISocialResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "ì·¨ì†Œ";

	/// <summary>
	/// Key: "Action.Unlink"
	/// English String: "Unlink"
	/// </summary>
	public override string ActionUnlink => "ì—°ê²° í•´ì œ";

	/// <summary>
	/// Key: "Description.ConnectedAccounts"
	/// English String: "Disconnect your connected accounts here. Unlinking an account will log you out of Roblox."
	/// </summary>
	public override string DescriptionConnectedAccounts => "ì—¬ê¸°ì—ì„œ í˜„ìž¬ ì—°ê²° ê³„ì •ì„ í•´ì œí•˜ì„¸ìš”. í•´ì œí•˜ë©´ Robloxì—ì„œ ë¡œê·¸ì•„ì›ƒë©ë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Description.UnlinkLogOutWarning"
	/// English String: "Unlinking this account will log you out of Roblox. You will have to link your account again to log back in."
	/// </summary>
	public override string DescriptionUnlinkLogOutWarning => "ê³„ì • ì—°ê²°ì„ í•´ì œí•˜ë©´ Robloxì—ì„œ ë¡œê·¸ì•„ì›ƒë©ë‹ˆë‹¤. ë‹¤ì‹œ ë¡œê·¸ì¸í•˜ë ¤ë©´ ê³„ì •ì„ ë‹¤ì‹œ ì—°ê²°í•´ì•¼ í•©ë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Heading.ConnectedAccounts"
	/// English String: "Connected Accounts"
	/// </summary>
	public override string HeadingConnectedAccounts => "ì—°ê²°ëœ ê³„ì •";

	/// <summary>
	/// Key: "Placeholder.Password"
	/// English String: "Password"
	/// </summary>
	public override string PlaceholderPassword => "ë¹„ë°€ë²ˆí˜¸";

	/// <summary>
	/// Key: "Response.InvalidPassword"
	/// English String: "Invalid Password."
	/// </summary>
	public override string ResponseInvalidPassword => "ìœ íš¨í•˜ì§€ ì•Šì€ ë¹„ë°€ë²ˆí˜¸.";

	public SocialResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "ì·¨ì†Œ";
	}

	protected override string _GetTemplateForActionUnlink()
	{
		return "ì—°ê²° í•´ì œ";
	}

	protected override string _GetTemplateForDescriptionConnectedAccounts()
	{
		return "ì—¬ê¸°ì—ì„œ í˜„ìž¬ ì—°ê²° ê³„ì •ì„ í•´ì œí•˜ì„¸ìš”. í•´ì œí•˜ë©´ Robloxì—ì„œ ë¡œê·¸ì•„ì›ƒë©ë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForDescriptionUnlinkLogOutWarning()
	{
		return "ê³„ì • ì—°ê²°ì„ í•´ì œí•˜ë©´ Robloxì—ì„œ ë¡œê·¸ì•„ì›ƒë©ë‹ˆë‹¤. ë‹¤ì‹œ ë¡œê·¸ì¸í•˜ë ¤ë©´ ê³„ì •ì„ ë‹¤ì‹œ ì—°ê²°í•´ì•¼ í•©ë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForHeadingConnectedAccounts()
	{
		return "ì—°ê²°ëœ ê³„ì •";
	}

	/// <summary>
	/// Key: "Heading.Unlink"
	/// English String: "Unlink {provider}"
	/// </summary>
	public override string HeadingUnlink(string provider)
	{
		return $"{provider} ì—°ê²° í•´ì œ";
	}

	protected override string _GetTemplateForHeadingUnlink()
	{
		return "{provider} ì—°ê²° í•´ì œ";
	}

	protected override string _GetTemplateForPlaceholderPassword()
	{
		return "ë¹„ë°€ë²ˆí˜¸";
	}

	protected override string _GetTemplateForResponseInvalidPassword()
	{
		return "ìœ íš¨í•˜ì§€ ì•Šì€ ë¹„ë°€ë²ˆí˜¸.";
	}
}


}
