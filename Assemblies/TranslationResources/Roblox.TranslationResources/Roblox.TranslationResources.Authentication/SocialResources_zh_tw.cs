namespace Roblox.TranslationResources.Authentication;

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
	public override string ActionCancel => "取消";

	/// <summary>
	/// Key: "Action.Unlink"
	/// English String: "Unlink"
	/// </summary>
	public override string ActionUnlink => "解除連接";

	/// <summary>
	/// Key: "Description.ConnectedAccounts"
	/// English String: "Disconnect your connected accounts here. Unlinking an account will log you out of Roblox."
	/// </summary>
	public override string DescriptionConnectedAccounts => "在此將已連接的帳號解除連接，您將在解除連接帳號後登出 Roblox。";

	/// <summary>
	/// Key: "Description.UnlinkLogOutWarning"
	/// English String: "Unlinking this account will log you out of Roblox. You will have to link your account again to log back in."
	/// </summary>
	public override string DescriptionUnlinkLogOutWarning => "解除連接此帳號後，您將會登出 Roblox。若要重新登入，您就必須重新連接您的帳號。";

	/// <summary>
	/// Key: "Heading.ConnectedAccounts"
	/// English String: "Connected Accounts"
	/// </summary>
	public override string HeadingConnectedAccounts => "已連接的帳號";

	/// <summary>
	/// Key: "Placeholder.Password"
	/// English String: "Password"
	/// </summary>
	public override string PlaceholderPassword => "密碼";

	/// <summary>
	/// Key: "Response.InvalidPassword"
	/// English String: "Invalid Password."
	/// </summary>
	public override string ResponseInvalidPassword => "密碼無效";

	public SocialResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "取消";
	}

	protected override string _GetTemplateForActionUnlink()
	{
		return "解除連接";
	}

	protected override string _GetTemplateForDescriptionConnectedAccounts()
	{
		return "在此將已連接的帳號解除連接，您將在解除連接帳號後登出 Roblox。";
	}

	protected override string _GetTemplateForDescriptionUnlinkLogOutWarning()
	{
		return "解除連接此帳號後，您將會登出 Roblox。若要重新登入，您就必須重新連接您的帳號。";
	}

	protected override string _GetTemplateForHeadingConnectedAccounts()
	{
		return "已連接的帳號";
	}

	/// <summary>
	/// Key: "Heading.Unlink"
	/// English String: "Unlink {provider}"
	/// </summary>
	public override string HeadingUnlink(string provider)
	{
		return $"解除連接 {provider} 帳號";
	}

	protected override string _GetTemplateForHeadingUnlink()
	{
		return "解除連接 {provider} 帳號";
	}

	protected override string _GetTemplateForPlaceholderPassword()
	{
		return "密碼";
	}

	protected override string _GetTemplateForResponseInvalidPassword()
	{
		return "密碼無效";
	}
}
