namespace Roblox.TranslationResources.Authentication;

/// <summary>
/// This class overrides SocialResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class SocialResources_es_es : SocialResources_en_us, ISocialResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "Cancelar";

	/// <summary>
	/// Key: "Action.Unlink"
	/// English String: "Unlink"
	/// </summary>
	public override string ActionUnlink => "Desenlazar";

	/// <summary>
	/// Key: "Description.ConnectedAccounts"
	/// English String: "Disconnect your connected accounts here. Unlinking an account will log you out of Roblox."
	/// </summary>
	public override string DescriptionConnectedAccounts => "Desconecta tus cuentas conectadas aquí. Si desenlazas una cuenta, se cerrará sesión en Roblox.";

	/// <summary>
	/// Key: "Description.UnlinkLogOutWarning"
	/// English String: "Unlinking this account will log you out of Roblox. You will have to link your account again to log back in."
	/// </summary>
	public override string DescriptionUnlinkLogOutWarning => "Si desenlazas esta cuenta, se cerrará sesión en Roblox. Tendrás que volver a enlazar tu cuenta para iniciar sesión.";

	/// <summary>
	/// Key: "Heading.ConnectedAccounts"
	/// English String: "Connected Accounts"
	/// </summary>
	public override string HeadingConnectedAccounts => "Cuentas conectadas";

	/// <summary>
	/// Key: "Placeholder.Password"
	/// English String: "Password"
	/// </summary>
	public override string PlaceholderPassword => "Contraseña";

	/// <summary>
	/// Key: "Response.InvalidPassword"
	/// English String: "Invalid Password."
	/// </summary>
	public override string ResponseInvalidPassword => "Contraseña no válida.";

	public SocialResources_es_es(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "Cancelar";
	}

	protected override string _GetTemplateForActionUnlink()
	{
		return "Desenlazar";
	}

	protected override string _GetTemplateForDescriptionConnectedAccounts()
	{
		return "Desconecta tus cuentas conectadas aquí. Si desenlazas una cuenta, se cerrará sesión en Roblox.";
	}

	protected override string _GetTemplateForDescriptionUnlinkLogOutWarning()
	{
		return "Si desenlazas esta cuenta, se cerrará sesión en Roblox. Tendrás que volver a enlazar tu cuenta para iniciar sesión.";
	}

	protected override string _GetTemplateForHeadingConnectedAccounts()
	{
		return "Cuentas conectadas";
	}

	/// <summary>
	/// Key: "Heading.Unlink"
	/// English String: "Unlink {provider}"
	/// </summary>
	public override string HeadingUnlink(string provider)
	{
		return $"Desenlazar {provider}";
	}

	protected override string _GetTemplateForHeadingUnlink()
	{
		return "Desenlazar {provider}";
	}

	protected override string _GetTemplateForPlaceholderPassword()
	{
		return "Contraseña";
	}

	protected override string _GetTemplateForResponseInvalidPassword()
	{
		return "Contraseña no válida.";
	}
}
