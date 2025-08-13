namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides GameFollowsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class GameFollowsResources_fr_fr : GameFollowsResources_en_us, IGameFollowsResources, ITranslationResources
{
	/// <summary>
	/// Key: "ActionCancel"
	/// Login dialog cancel label
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "Annuler";

	/// <summary>
	/// Key: "ActionLogin"
	/// Login button label
	/// English String: "Login"
	/// </summary>
	public override string ActionLogin => "Connexion";

	/// <summary>
	/// Key: "DescriptionLoginRequired"
	/// Login dialog text for guest user
	/// English String: "You must be logged in to follow this game. Please Login or Register to continue."
	/// </summary>
	public override string DescriptionLoginRequired => "Vous devez être connecté(e) pour suivre ce jeu. Veuillez vous connecter ou vous inscrire pour continuer.";

	/// <summary>
	/// Key: "LabelFollow"
	/// Label for follow game button
	/// English String: "Follow"
	/// </summary>
	public override string LabelFollow => "Suivre";

	/// <summary>
	/// Key: "LabelFollowing"
	/// Label for follow game button
	/// English String: "Following"
	/// </summary>
	public override string LabelFollowing => "Abonné";

	/// <summary>
	/// Key: "LabelLoginRequired"
	/// Text for dialog for guest user to redirect to login
	/// English String: "Login Required"
	/// </summary>
	public override string LabelLoginRequired => "Connexion requise";

	/// <summary>
	/// Key: "TooltipFollowGame"
	/// Tooltip for follow game button
	/// English String: "Follow Game"
	/// </summary>
	public override string TooltipFollowGame => "S'abonner au jeu";

	/// <summary>
	/// Key: "TooltipFollowLimitReached"
	/// Tooltip for follow game button
	/// English String: "Limit reached. Please unfollow other games to follow this one."
	/// </summary>
	public override string TooltipFollowLimitReached => "Limite atteinte. Veuillez vous désabonner d'autre jeux pour pouvoir le suivre.";

	/// <summary>
	/// Key: "TooltipUnfollowGame"
	/// Tooltip for follow game button
	/// English String: "Unfollow Game"
	/// </summary>
	public override string TooltipUnfollowGame => "Se désabonner du jeu";

	public GameFollowsResources_fr_fr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "Annuler";
	}

	protected override string _GetTemplateForActionLogin()
	{
		return "Connexion";
	}

	protected override string _GetTemplateForDescriptionLoginRequired()
	{
		return "Vous devez être connecté(e) pour suivre ce jeu. Veuillez vous connecter ou vous inscrire pour continuer.";
	}

	protected override string _GetTemplateForLabelFollow()
	{
		return "Suivre";
	}

	protected override string _GetTemplateForLabelFollowing()
	{
		return "Abonné";
	}

	protected override string _GetTemplateForLabelLoginRequired()
	{
		return "Connexion requise";
	}

	protected override string _GetTemplateForTooltipFollowGame()
	{
		return "S'abonner au jeu";
	}

	protected override string _GetTemplateForTooltipFollowLimitReached()
	{
		return "Limite atteinte. Veuillez vous désabonner d'autre jeux pour pouvoir le suivre.";
	}

	protected override string _GetTemplateForTooltipUnfollowGame()
	{
		return "Se désabonner du jeu";
	}
}
