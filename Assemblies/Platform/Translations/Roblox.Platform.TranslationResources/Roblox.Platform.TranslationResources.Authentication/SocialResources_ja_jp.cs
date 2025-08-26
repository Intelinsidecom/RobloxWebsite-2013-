namespace Roblox.Platform.TranslationResources.Authentication {
    /// <summary>

/// This class overrides SocialResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class SocialResources_ja_jp : SocialResources_en_us, ISocialResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "ã‚­ãƒ£ãƒ³ã‚»ãƒ«";

	/// <summary>
	/// Key: "Action.Unlink"
	/// English String: "Unlink"
	/// </summary>
	public override string ActionUnlink => "ãƒªãƒ³ã‚¯è§£é™¤";

	/// <summary>
	/// Key: "Description.ConnectedAccounts"
	/// English String: "Disconnect your connected accounts here. Unlinking an account will log you out of Roblox."
	/// </summary>
	public override string DescriptionConnectedAccounts => "æŽ¥ç¶šæ¸ˆã¿ã®ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã‚’ã“ã“ã§è§£é™¤ã€‚ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã®ãƒªãƒ³ã‚¯è§£é™¤ã‚’ã™ã‚‹ã¨Robloxã‹ã‚‰ãƒ­ã‚°ã‚¢ã‚¦ãƒˆã•ã‚Œã¾ã™ã€‚";

	/// <summary>
	/// Key: "Description.UnlinkLogOutWarning"
	/// English String: "Unlinking this account will log you out of Roblox. You will have to link your account again to log back in."
	/// </summary>
	public override string DescriptionUnlinkLogOutWarning => "ã“ã®ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã‚’ãƒªãƒ³ã‚¯è§£é™¤ã™ã‚‹ã¨Robloxã‹ã‚‰ãƒ­ã‚°ã‚¢ã‚¦ãƒˆã•ã‚Œã¾ã™ã€‚ã¾ãŸãƒ­ã‚°ã‚¤ãƒ³ã—ç›´ã™ã«ã¯ã€ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã‚’ãƒªãƒ³ã‚¯ã™ã‚‹å¿…è¦ãŒã‚ã‚Šã¾ã™ã€‚";

	/// <summary>
	/// Key: "Heading.ConnectedAccounts"
	/// English String: "Connected Accounts"
	/// </summary>
	public override string HeadingConnectedAccounts => "æŽ¥ç¶šæ¸ˆã¿ã‚¢ã‚«ã‚¦ãƒ³ãƒˆ";

	/// <summary>
	/// Key: "Placeholder.Password"
	/// English String: "Password"
	/// </summary>
	public override string PlaceholderPassword => "ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰";

	/// <summary>
	/// Key: "Response.InvalidPassword"
	/// English String: "Invalid Password."
	/// </summary>
	public override string ResponseInvalidPassword => "ç„¡åŠ¹ãªãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ã€‚";

	public SocialResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "ã‚­ãƒ£ãƒ³ã‚»ãƒ«";
	}

	protected override string _GetTemplateForActionUnlink()
	{
		return "ãƒªãƒ³ã‚¯è§£é™¤";
	}

	protected override string _GetTemplateForDescriptionConnectedAccounts()
	{
		return "æŽ¥ç¶šæ¸ˆã¿ã®ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã‚’ã“ã“ã§è§£é™¤ã€‚ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã®ãƒªãƒ³ã‚¯è§£é™¤ã‚’ã™ã‚‹ã¨Robloxã‹ã‚‰ãƒ­ã‚°ã‚¢ã‚¦ãƒˆã•ã‚Œã¾ã™ã€‚";
	}

	protected override string _GetTemplateForDescriptionUnlinkLogOutWarning()
	{
		return "ã“ã®ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã‚’ãƒªãƒ³ã‚¯è§£é™¤ã™ã‚‹ã¨Robloxã‹ã‚‰ãƒ­ã‚°ã‚¢ã‚¦ãƒˆã•ã‚Œã¾ã™ã€‚ã¾ãŸãƒ­ã‚°ã‚¤ãƒ³ã—ç›´ã™ã«ã¯ã€ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã‚’ãƒªãƒ³ã‚¯ã™ã‚‹å¿…è¦ãŒã‚ã‚Šã¾ã™ã€‚";
	}

	protected override string _GetTemplateForHeadingConnectedAccounts()
	{
		return "æŽ¥ç¶šæ¸ˆã¿ã‚¢ã‚«ã‚¦ãƒ³ãƒˆ";
	}

	/// <summary>
	/// Key: "Heading.Unlink"
	/// English String: "Unlink {provider}"
	/// </summary>
	public override string HeadingUnlink(string provider)
	{
		return $"{provider} ã®ãƒªãƒ³ã‚¯è§£é™¤";
	}

	protected override string _GetTemplateForHeadingUnlink()
	{
		return "{provider} ã®ãƒªãƒ³ã‚¯è§£é™¤";
	}

	protected override string _GetTemplateForPlaceholderPassword()
	{
		return "ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰";
	}

	protected override string _GetTemplateForResponseInvalidPassword()
	{
		return "ç„¡åŠ¹ãªãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ã€‚";
	}
}


}
