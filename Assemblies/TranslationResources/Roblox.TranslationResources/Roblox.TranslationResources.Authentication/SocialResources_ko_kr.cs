namespace Roblox.TranslationResources.Authentication;

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
	public override string ActionCancel => "취소";

	/// <summary>
	/// Key: "Action.Unlink"
	/// English String: "Unlink"
	/// </summary>
	public override string ActionUnlink => "연결 해제";

	/// <summary>
	/// Key: "Description.ConnectedAccounts"
	/// English String: "Disconnect your connected accounts here. Unlinking an account will log you out of Roblox."
	/// </summary>
	public override string DescriptionConnectedAccounts => "여기에서 현재 연결 계정을 해제하세요. 해제하면 Roblox에서 로그아웃됩니다.";

	/// <summary>
	/// Key: "Description.UnlinkLogOutWarning"
	/// English String: "Unlinking this account will log you out of Roblox. You will have to link your account again to log back in."
	/// </summary>
	public override string DescriptionUnlinkLogOutWarning => "계정 연결을 해제하면 Roblox에서 로그아웃됩니다. 다시 로그인하려면 계정을 다시 연결해야 합니다.";

	/// <summary>
	/// Key: "Heading.ConnectedAccounts"
	/// English String: "Connected Accounts"
	/// </summary>
	public override string HeadingConnectedAccounts => "연결된 계정";

	/// <summary>
	/// Key: "Placeholder.Password"
	/// English String: "Password"
	/// </summary>
	public override string PlaceholderPassword => "비밀번호";

	/// <summary>
	/// Key: "Response.InvalidPassword"
	/// English String: "Invalid Password."
	/// </summary>
	public override string ResponseInvalidPassword => "유효하지 않은 비밀번호.";

	public SocialResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "취소";
	}

	protected override string _GetTemplateForActionUnlink()
	{
		return "연결 해제";
	}

	protected override string _GetTemplateForDescriptionConnectedAccounts()
	{
		return "여기에서 현재 연결 계정을 해제하세요. 해제하면 Roblox에서 로그아웃됩니다.";
	}

	protected override string _GetTemplateForDescriptionUnlinkLogOutWarning()
	{
		return "계정 연결을 해제하면 Roblox에서 로그아웃됩니다. 다시 로그인하려면 계정을 다시 연결해야 합니다.";
	}

	protected override string _GetTemplateForHeadingConnectedAccounts()
	{
		return "연결된 계정";
	}

	/// <summary>
	/// Key: "Heading.Unlink"
	/// English String: "Unlink {provider}"
	/// </summary>
	public override string HeadingUnlink(string provider)
	{
		return $"{provider} 연결 해제";
	}

	protected override string _GetTemplateForHeadingUnlink()
	{
		return "{provider} 연결 해제";
	}

	protected override string _GetTemplateForPlaceholderPassword()
	{
		return "비밀번호";
	}

	protected override string _GetTemplateForResponseInvalidPassword()
	{
		return "유효하지 않은 비밀번호.";
	}
}
