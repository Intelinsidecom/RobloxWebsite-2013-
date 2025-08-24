namespace Roblox.TranslationResources.Authentication;

/// <summary>
/// This class overrides SocialResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class SocialResources_zh_cjv : SocialResources_en_us, ISocialResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "取消";

	/// <summary>
	/// Key: "Action.Unlink"
	/// English String: "Unlink"
	/// </summary>
	public override string ActionUnlink => "解除连接";

	/// <summary>
	/// Key: "Description.ConnectedAccounts"
	/// English String: "Disconnect your connected accounts here. Unlinking an account will log you out of Roblox."
	/// </summary>
	public override string DescriptionConnectedAccounts => "在这里解除与你关联帐户的连接。取消帐户关联后，你也将登出 Roblox。";

	/// <summary>
	/// Key: "Description.UnlinkLogOutWarning"
	/// English String: "Unlinking this account will log you out of Roblox. You will have to link your account again to log back in."
	/// </summary>
	public override string DescriptionUnlinkLogOutWarning => "解除与此帐户的连接将导致你登出 Roblox。你需要重新连接你的帐户以登录。";

	/// <summary>
	/// Key: "Heading.ConnectedAccounts"
	/// English String: "Connected Accounts"
	/// </summary>
	public override string HeadingConnectedAccounts => "关联帐户";

	/// <summary>
	/// Key: "Placeholder.Password"
	/// English String: "Password"
	/// </summary>
	public override string PlaceholderPassword => "密码";

	/// <summary>
	/// Key: "Response.InvalidPassword"
	/// English String: "Invalid Password."
	/// </summary>
	public override string ResponseInvalidPassword => "密码无效。";

	public SocialResources_zh_cjv(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "取消";
	}

	protected override string _GetTemplateForActionUnlink()
	{
		return "解除连接";
	}

	protected override string _GetTemplateForDescriptionConnectedAccounts()
	{
		return "在这里解除与你关联帐户的连接。取消帐户关联后，你也将登出 Roblox。";
	}

	protected override string _GetTemplateForDescriptionUnlinkLogOutWarning()
	{
		return "解除与此帐户的连接将导致你登出 Roblox。你需要重新连接你的帐户以登录。";
	}

	protected override string _GetTemplateForHeadingConnectedAccounts()
	{
		return "关联帐户";
	}

	/// <summary>
	/// Key: "Heading.Unlink"
	/// English String: "Unlink {provider}"
	/// </summary>
	public override string HeadingUnlink(string provider)
	{
		return $"解除连接 {provider}";
	}

	protected override string _GetTemplateForHeadingUnlink()
	{
		return "解除连接 {provider}";
	}

	protected override string _GetTemplateForPlaceholderPassword()
	{
		return "密码";
	}

	protected override string _GetTemplateForResponseInvalidPassword()
	{
		return "密码无效。";
	}
}
