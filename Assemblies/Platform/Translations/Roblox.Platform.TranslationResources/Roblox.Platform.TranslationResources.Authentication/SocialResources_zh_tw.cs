namespace Roblox.Platform.TranslationResources.Authentication {
    /// <summary>

/// This class overrides SocialResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class SocialResources_zh_tw : SocialResources_en_us, ISocialResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "å–æ¶ˆ";

	/// <summary>
	/// Key: "Action.Unlink"
	/// English String: "Unlink"
	/// </summary>
	public override string ActionUnlink => "è§£é™¤é€£æŽ¥";

	/// <summary>
	/// Key: "Description.ConnectedAccounts"
	/// English String: "Disconnect your connected accounts here. Unlinking an account will log you out of Roblox."
	/// </summary>
	public override string DescriptionConnectedAccounts => "åœ¨æ­¤å°‡å·²é€£æŽ¥çš„å¸³è™Ÿè§£é™¤é€£æŽ¥ï¼Œæ‚¨å°‡åœ¨è§£é™¤é€£æŽ¥å¸³è™Ÿå¾Œç™»å‡º Robloxã€‚";

	/// <summary>
	/// Key: "Description.UnlinkLogOutWarning"
	/// English String: "Unlinking this account will log you out of Roblox. You will have to link your account again to log back in."
	/// </summary>
	public override string DescriptionUnlinkLogOutWarning => "è§£é™¤é€£æŽ¥æ­¤å¸³è™Ÿå¾Œï¼Œæ‚¨å°‡æœƒç™»å‡º Robloxã€‚è‹¥è¦é‡æ–°ç™»å…¥ï¼Œæ‚¨å°±å¿…é ˆé‡æ–°é€£æŽ¥æ‚¨çš„å¸³è™Ÿã€‚";

	/// <summary>
	/// Key: "Heading.ConnectedAccounts"
	/// English String: "Connected Accounts"
	/// </summary>
	public override string HeadingConnectedAccounts => "å·²é€£æŽ¥çš„å¸³è™Ÿ";

	/// <summary>
	/// Key: "Placeholder.Password"
	/// English String: "Password"
	/// </summary>
	public override string PlaceholderPassword => "å¯†ç¢¼";

	/// <summary>
	/// Key: "Response.InvalidPassword"
	/// English String: "Invalid Password."
	/// </summary>
	public override string ResponseInvalidPassword => "å¯†ç¢¼ç„¡æ•ˆ";

	public SocialResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "å–æ¶ˆ";
	}

	protected override string _GetTemplateForActionUnlink()
	{
		return "è§£é™¤é€£æŽ¥";
	}

	protected override string _GetTemplateForDescriptionConnectedAccounts()
	{
		return "åœ¨æ­¤å°‡å·²é€£æŽ¥çš„å¸³è™Ÿè§£é™¤é€£æŽ¥ï¼Œæ‚¨å°‡åœ¨è§£é™¤é€£æŽ¥å¸³è™Ÿå¾Œç™»å‡º Robloxã€‚";
	}

	protected override string _GetTemplateForDescriptionUnlinkLogOutWarning()
	{
		return "è§£é™¤é€£æŽ¥æ­¤å¸³è™Ÿå¾Œï¼Œæ‚¨å°‡æœƒç™»å‡º Robloxã€‚è‹¥è¦é‡æ–°ç™»å…¥ï¼Œæ‚¨å°±å¿…é ˆé‡æ–°é€£æŽ¥æ‚¨çš„å¸³è™Ÿã€‚";
	}

	protected override string _GetTemplateForHeadingConnectedAccounts()
	{
		return "å·²é€£æŽ¥çš„å¸³è™Ÿ";
	}

	/// <summary>
	/// Key: "Heading.Unlink"
	/// English String: "Unlink {provider}"
	/// </summary>
	public override string HeadingUnlink(string provider)
	{
		return $"è§£é™¤é€£æŽ¥ {provider} å¸³è™Ÿ";
	}

	protected override string _GetTemplateForHeadingUnlink()
	{
		return "è§£é™¤é€£æŽ¥ {provider} å¸³è™Ÿ";
	}

	protected override string _GetTemplateForPlaceholderPassword()
	{
		return "å¯†ç¢¼";
	}

	protected override string _GetTemplateForResponseInvalidPassword()
	{
		return "å¯†ç¢¼ç„¡æ•ˆ";
	}
}


}
