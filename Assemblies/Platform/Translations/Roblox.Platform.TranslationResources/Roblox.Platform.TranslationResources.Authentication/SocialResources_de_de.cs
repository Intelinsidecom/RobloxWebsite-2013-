namespace Roblox.TranslationResources.Authentication;

/// <summary>
/// This class overrides SocialResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class SocialResources_de_de : SocialResources_en_us, ISocialResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "Abbrechen";

	/// <summary>
	/// Key: "Action.Unlink"
	/// English String: "Unlink"
	/// </summary>
	public override string ActionUnlink => "Verknüpfung aufheben";

	/// <summary>
	/// Key: "Description.ConnectedAccounts"
	/// English String: "Disconnect your connected accounts here. Unlinking an account will log you out of Roblox."
	/// </summary>
	public override string DescriptionConnectedAccounts => "Trenne hier deine verbundenen Konten. Wenn du die Verknüpfung eines Kontos aufhebst, wirst du von Roblox abgemeldet.";

	/// <summary>
	/// Key: "Description.UnlinkLogOutWarning"
	/// English String: "Unlinking this account will log you out of Roblox. You will have to link your account again to log back in."
	/// </summary>
	public override string DescriptionUnlinkLogOutWarning => "Wenn du die Verknüpfung dieses Kontos aufhebst, wirst du von Roblox abgemeldet. Du musst dein Konto erneut verknüpfen, um sich erneut anzumelden.";

	/// <summary>
	/// Key: "Heading.ConnectedAccounts"
	/// English String: "Connected Accounts"
	/// </summary>
	public override string HeadingConnectedAccounts => "Verbundene Kontos";

	/// <summary>
	/// Key: "Placeholder.Password"
	/// English String: "Password"
	/// </summary>
	public override string PlaceholderPassword => "Passwort";

	/// <summary>
	/// Key: "Response.InvalidPassword"
	/// English String: "Invalid Password."
	/// </summary>
	public override string ResponseInvalidPassword => "Ungültiges Passwort.";

	public SocialResources_de_de(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "Abbrechen";
	}

	protected override string _GetTemplateForActionUnlink()
	{
		return "Verknüpfung aufheben";
	}

	protected override string _GetTemplateForDescriptionConnectedAccounts()
	{
		return "Trenne hier deine verbundenen Konten. Wenn du die Verknüpfung eines Kontos aufhebst, wirst du von Roblox abgemeldet.";
	}

	protected override string _GetTemplateForDescriptionUnlinkLogOutWarning()
	{
		return "Wenn du die Verknüpfung dieses Kontos aufhebst, wirst du von Roblox abgemeldet. Du musst dein Konto erneut verknüpfen, um sich erneut anzumelden.";
	}

	protected override string _GetTemplateForHeadingConnectedAccounts()
	{
		return "Verbundene Kontos";
	}

	/// <summary>
	/// Key: "Heading.Unlink"
	/// English String: "Unlink {provider}"
	/// </summary>
	public override string HeadingUnlink(string provider)
	{
		return $"Verknüpfung zu {provider} aufheben";
	}

	protected override string _GetTemplateForHeadingUnlink()
	{
		return "Verknüpfung zu {provider} aufheben";
	}

	protected override string _GetTemplateForPlaceholderPassword()
	{
		return "Passwort";
	}

	protected override string _GetTemplateForResponseInvalidPassword()
	{
		return "Ungültiges Passwort.";
	}
}
