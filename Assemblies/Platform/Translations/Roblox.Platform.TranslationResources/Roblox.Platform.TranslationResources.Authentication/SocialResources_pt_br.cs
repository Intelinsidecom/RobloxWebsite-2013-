namespace Roblox.TranslationResources.Authentication;

/// <summary>
/// This class overrides SocialResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class SocialResources_pt_br : SocialResources_en_us, ISocialResources, ITranslationResources
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
	public override string ActionUnlink => "Desvincular";

	/// <summary>
	/// Key: "Description.ConnectedAccounts"
	/// English String: "Disconnect your connected accounts here. Unlinking an account will log you out of Roblox."
	/// </summary>
	public override string DescriptionConnectedAccounts => "Desconecte suas contas conectadas aqui. Ao desvincular esta conta, você se desconecta do Roblox";

	/// <summary>
	/// Key: "Description.UnlinkLogOutWarning"
	/// English String: "Unlinking this account will log you out of Roblox. You will have to link your account again to log back in."
	/// </summary>
	public override string DescriptionUnlinkLogOutWarning => "Ao desvincular esta conta, você se desconecta do Roblox. Para se conectar novamente, você precisará vincular sua conta novamente.";

	/// <summary>
	/// Key: "Heading.ConnectedAccounts"
	/// English String: "Connected Accounts"
	/// </summary>
	public override string HeadingConnectedAccounts => "Contas conectadas";

	/// <summary>
	/// Key: "Placeholder.Password"
	/// English String: "Password"
	/// </summary>
	public override string PlaceholderPassword => "Senha";

	/// <summary>
	/// Key: "Response.InvalidPassword"
	/// English String: "Invalid Password."
	/// </summary>
	public override string ResponseInvalidPassword => "Senha inválida.";

	public SocialResources_pt_br(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "Cancelar";
	}

	protected override string _GetTemplateForActionUnlink()
	{
		return "Desvincular";
	}

	protected override string _GetTemplateForDescriptionConnectedAccounts()
	{
		return "Desconecte suas contas conectadas aqui. Ao desvincular esta conta, você se desconecta do Roblox";
	}

	protected override string _GetTemplateForDescriptionUnlinkLogOutWarning()
	{
		return "Ao desvincular esta conta, você se desconecta do Roblox. Para se conectar novamente, você precisará vincular sua conta novamente.";
	}

	protected override string _GetTemplateForHeadingConnectedAccounts()
	{
		return "Contas conectadas";
	}

	/// <summary>
	/// Key: "Heading.Unlink"
	/// English String: "Unlink {provider}"
	/// </summary>
	public override string HeadingUnlink(string provider)
	{
		return $"Desvincular {provider}";
	}

	protected override string _GetTemplateForHeadingUnlink()
	{
		return "Desvincular {provider}";
	}

	protected override string _GetTemplateForPlaceholderPassword()
	{
		return "Senha";
	}

	protected override string _GetTemplateForResponseInvalidPassword()
	{
		return "Senha inválida.";
	}
}
