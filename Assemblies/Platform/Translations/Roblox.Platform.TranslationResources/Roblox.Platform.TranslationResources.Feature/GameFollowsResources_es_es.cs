namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides GameFollowsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class GameFollowsResources_es_es : GameFollowsResources_en_us, IGameFollowsResources, ITranslationResources
{
	/// <summary>
	/// Key: "ActionCancel"
	/// Login dialog cancel label
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "Cancelar";

	/// <summary>
	/// Key: "ActionLogin"
	/// Login button label
	/// English String: "Login"
	/// </summary>
	public override string ActionLogin => "Iniciar sesiÃ³n";

	/// <summary>
	/// Key: "DescriptionLoginRequired"
	/// Login dialog text for guest user
	/// English String: "You must be logged in to follow this game. Please Login or Register to continue."
	/// </summary>
	public override string DescriptionLoginRequired => "Debes iniciar sesiÃ³n para seguir este juego. Inicia sesiÃ³n o regÃ­strate para continuar.";

	/// <summary>
	/// Key: "LabelFollow"
	/// Label for follow game button
	/// English String: "Follow"
	/// </summary>
	public override string LabelFollow => "Seguir";

	/// <summary>
	/// Key: "LabelFollowing"
	/// Label for follow game button
	/// English String: "Following"
	/// </summary>
	public override string LabelFollowing => "Siguiendo";

	/// <summary>
	/// Key: "LabelLoginRequired"
	/// Text for dialog for guest user to redirect to login
	/// English String: "Login Required"
	/// </summary>
	public override string LabelLoginRequired => "Inicio de sesiÃ³n obligatorio";

	/// <summary>
	/// Key: "TooltipFollowGame"
	/// Tooltip for follow game button
	/// English String: "Follow Game"
	/// </summary>
	public override string TooltipFollowGame => "Seguir juego";

	/// <summary>
	/// Key: "TooltipFollowLimitReached"
	/// Tooltip for follow game button
	/// English String: "Limit reached. Please unfollow other games to follow this one."
	/// </summary>
	public override string TooltipFollowLimitReached => "LÃ­mite alcanzado. Deja de seguir otros juegos para seguir este.";

	/// <summary>
	/// Key: "TooltipUnfollowGame"
	/// Tooltip for follow game button
	/// English String: "Unfollow Game"
	/// </summary>
	public override string TooltipUnfollowGame => "Dejar de seguir juego";

	public GameFollowsResources_es_es(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "Cancelar";
	}

	protected override string _GetTemplateForActionLogin()
	{
		return "Iniciar sesiÃ³n";
	}

	protected override string _GetTemplateForDescriptionLoginRequired()
	{
		return "Debes iniciar sesiÃ³n para seguir este juego. Inicia sesiÃ³n o regÃ­strate para continuar.";
	}

	protected override string _GetTemplateForLabelFollow()
	{
		return "Seguir";
	}

	protected override string _GetTemplateForLabelFollowing()
	{
		return "Siguiendo";
	}

	protected override string _GetTemplateForLabelLoginRequired()
	{
		return "Inicio de sesiÃ³n obligatorio";
	}

	protected override string _GetTemplateForTooltipFollowGame()
	{
		return "Seguir juego";
	}

	protected override string _GetTemplateForTooltipFollowLimitReached()
	{
		return "LÃ­mite alcanzado. Deja de seguir otros juegos para seguir este.";
	}

	protected override string _GetTemplateForTooltipUnfollowGame()
	{
		return "Dejar de seguir juego";
	}
}


}
