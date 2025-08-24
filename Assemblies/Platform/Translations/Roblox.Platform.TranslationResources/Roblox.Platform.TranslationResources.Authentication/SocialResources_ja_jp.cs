namespace Roblox.TranslationResources.Authentication;

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
	public override string ActionCancel => "キャンセル";

	/// <summary>
	/// Key: "Action.Unlink"
	/// English String: "Unlink"
	/// </summary>
	public override string ActionUnlink => "リンク解除";

	/// <summary>
	/// Key: "Description.ConnectedAccounts"
	/// English String: "Disconnect your connected accounts here. Unlinking an account will log you out of Roblox."
	/// </summary>
	public override string DescriptionConnectedAccounts => "接続済みのアカウントをここで解除。アカウントのリンク解除をするとRobloxからログアウトされます。";

	/// <summary>
	/// Key: "Description.UnlinkLogOutWarning"
	/// English String: "Unlinking this account will log you out of Roblox. You will have to link your account again to log back in."
	/// </summary>
	public override string DescriptionUnlinkLogOutWarning => "このアカウントをリンク解除するとRobloxからログアウトされます。またログインし直すには、アカウントをリンクする必要があります。";

	/// <summary>
	/// Key: "Heading.ConnectedAccounts"
	/// English String: "Connected Accounts"
	/// </summary>
	public override string HeadingConnectedAccounts => "接続済みアカウント";

	/// <summary>
	/// Key: "Placeholder.Password"
	/// English String: "Password"
	/// </summary>
	public override string PlaceholderPassword => "パスワード";

	/// <summary>
	/// Key: "Response.InvalidPassword"
	/// English String: "Invalid Password."
	/// </summary>
	public override string ResponseInvalidPassword => "無効なパスワード。";

	public SocialResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "キャンセル";
	}

	protected override string _GetTemplateForActionUnlink()
	{
		return "リンク解除";
	}

	protected override string _GetTemplateForDescriptionConnectedAccounts()
	{
		return "接続済みのアカウントをここで解除。アカウントのリンク解除をするとRobloxからログアウトされます。";
	}

	protected override string _GetTemplateForDescriptionUnlinkLogOutWarning()
	{
		return "このアカウントをリンク解除するとRobloxからログアウトされます。またログインし直すには、アカウントをリンクする必要があります。";
	}

	protected override string _GetTemplateForHeadingConnectedAccounts()
	{
		return "接続済みアカウント";
	}

	/// <summary>
	/// Key: "Heading.Unlink"
	/// English String: "Unlink {provider}"
	/// </summary>
	public override string HeadingUnlink(string provider)
	{
		return $"{provider} のリンク解除";
	}

	protected override string _GetTemplateForHeadingUnlink()
	{
		return "{provider} のリンク解除";
	}

	protected override string _GetTemplateForPlaceholderPassword()
	{
		return "パスワード";
	}

	protected override string _GetTemplateForResponseInvalidPassword()
	{
		return "無効なパスワード。";
	}
}
