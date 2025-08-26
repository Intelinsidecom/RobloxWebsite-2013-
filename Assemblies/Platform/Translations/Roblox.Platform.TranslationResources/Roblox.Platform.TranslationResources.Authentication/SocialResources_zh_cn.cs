namespace Roblox.Platform.TranslationResources.Authentication {
    /// <summary>

/// This class overrides SocialResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class SocialResources_zh_cn : SocialResources_en_us, ISocialResources, ITranslationResources
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
	public override string ActionUnlink => "è§£é™¤è¿žæŽ¥";

	/// <summary>
	/// Key: "Description.ConnectedAccounts"
	/// English String: "Disconnect your connected accounts here. Unlinking an account will log you out of Roblox."
	/// </summary>
	public override string DescriptionConnectedAccounts => "åœ¨è¿™é‡Œè§£é™¤ä¸Žä½ å…³è”å¸æˆ·çš„è¿žæŽ¥ã€‚å–æ¶ˆå¸æˆ·å…³è”åŽï¼Œä½ ä¹Ÿå°†ç™»å‡º Robloxã€‚";

	/// <summary>
	/// Key: "Description.UnlinkLogOutWarning"
	/// English String: "Unlinking this account will log you out of Roblox. You will have to link your account again to log back in."
	/// </summary>
	public override string DescriptionUnlinkLogOutWarning => "è§£é™¤ä¸Žæ­¤å¸æˆ·çš„è¿žæŽ¥å°†å¯¼è‡´ä½ ç™»å‡º Robloxã€‚ä½ éœ€è¦é‡æ–°è¿žæŽ¥ä½ çš„å¸æˆ·ä»¥ç™»å½•ã€‚";

	/// <summary>
	/// Key: "Heading.ConnectedAccounts"
	/// English String: "Connected Accounts"
	/// </summary>
	public override string HeadingConnectedAccounts => "å…³è”å¸æˆ·";

	/// <summary>
	/// Key: "Placeholder.Password"
	/// English String: "Password"
	/// </summary>
	public override string PlaceholderPassword => "å¯†ç ";

	/// <summary>
	/// Key: "Response.InvalidPassword"
	/// English String: "Invalid Password."
	/// </summary>
	public override string ResponseInvalidPassword => "å¯†ç æ— æ•ˆã€‚";

	public SocialResources_zh_cn(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "å–æ¶ˆ";
	}

	protected override string _GetTemplateForActionUnlink()
	{
		return "è§£é™¤è¿žæŽ¥";
	}

	protected override string _GetTemplateForDescriptionConnectedAccounts()
	{
		return "åœ¨è¿™é‡Œè§£é™¤ä¸Žä½ å…³è”å¸æˆ·çš„è¿žæŽ¥ã€‚å–æ¶ˆå¸æˆ·å…³è”åŽï¼Œä½ ä¹Ÿå°†ç™»å‡º Robloxã€‚";
	}

	protected override string _GetTemplateForDescriptionUnlinkLogOutWarning()
	{
		return "è§£é™¤ä¸Žæ­¤å¸æˆ·çš„è¿žæŽ¥å°†å¯¼è‡´ä½ ç™»å‡º Robloxã€‚ä½ éœ€è¦é‡æ–°è¿žæŽ¥ä½ çš„å¸æˆ·ä»¥ç™»å½•ã€‚";
	}

	protected override string _GetTemplateForHeadingConnectedAccounts()
	{
		return "å…³è”å¸æˆ·";
	}

	/// <summary>
	/// Key: "Heading.Unlink"
	/// English String: "Unlink {provider}"
	/// </summary>
	public override string HeadingUnlink(string provider)
	{
		return $"è§£é™¤è¿žæŽ¥ {provider}";
	}

	protected override string _GetTemplateForHeadingUnlink()
	{
		return "è§£é™¤è¿žæŽ¥ {provider}";
	}

	protected override string _GetTemplateForPlaceholderPassword()
	{
		return "å¯†ç ";
	}

	protected override string _GetTemplateForResponseInvalidPassword()
	{
		return "å¯†ç æ— æ•ˆã€‚";
	}
}


}
