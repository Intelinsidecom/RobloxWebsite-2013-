namespace Roblox.TranslationResources.Authentication;

/// <summary>
/// This class overrides SocialResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class SocialResources_fr_fr : SocialResources_en_us, ISocialResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "Annuler";

	/// <summary>
	/// Key: "Action.Unlink"
	/// English String: "Unlink"
	/// </summary>
	public override string ActionUnlink => "Supprimer le lien";

	/// <summary>
	/// Key: "Description.ConnectedAccounts"
	/// English String: "Disconnect your connected accounts here. Unlinking an account will log you out of Roblox."
	/// </summary>
	public override string DescriptionConnectedAccounts => "Déconnecte tes comptes connectés ici. Supprimer le lien vers un compte entraîne la déconnexion à Roblox.";

	/// <summary>
	/// Key: "Description.UnlinkLogOutWarning"
	/// English String: "Unlinking this account will log you out of Roblox. You will have to link your account again to log back in."
	/// </summary>
	public override string DescriptionUnlinkLogOutWarning => "Supprimer le lien vers ce compte va te déconnecter de Roblox. Tu devras lier ton compte de nouveau avant de te connecter.";

	/// <summary>
	/// Key: "Heading.ConnectedAccounts"
	/// English String: "Connected Accounts"
	/// </summary>
	public override string HeadingConnectedAccounts => "Comptes connectés";

	/// <summary>
	/// Key: "Placeholder.Password"
	/// English String: "Password"
	/// </summary>
	public override string PlaceholderPassword => "Mot de passe";

	/// <summary>
	/// Key: "Response.InvalidPassword"
	/// English String: "Invalid Password."
	/// </summary>
	public override string ResponseInvalidPassword => "Mot de passe invalide.";

	public SocialResources_fr_fr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "Annuler";
	}

	protected override string _GetTemplateForActionUnlink()
	{
		return "Supprimer le lien";
	}

	protected override string _GetTemplateForDescriptionConnectedAccounts()
	{
		return "Déconnecte tes comptes connectés ici. Supprimer le lien vers un compte entraîne la déconnexion à Roblox.";
	}

	protected override string _GetTemplateForDescriptionUnlinkLogOutWarning()
	{
		return "Supprimer le lien vers ce compte va te déconnecter de Roblox. Tu devras lier ton compte de nouveau avant de te connecter.";
	}

	protected override string _GetTemplateForHeadingConnectedAccounts()
	{
		return "Comptes connectés";
	}

	/// <summary>
	/// Key: "Heading.Unlink"
	/// English String: "Unlink {provider}"
	/// </summary>
	public override string HeadingUnlink(string provider)
	{
		return $"Supprimer le lien {provider}";
	}

	protected override string _GetTemplateForHeadingUnlink()
	{
		return "Supprimer le lien {provider}";
	}

	protected override string _GetTemplateForPlaceholderPassword()
	{
		return "Mot de passe";
	}

	protected override string _GetTemplateForResponseInvalidPassword()
	{
		return "Mot de passe invalide.";
	}
}
