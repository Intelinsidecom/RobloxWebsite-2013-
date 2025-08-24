namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides GameFollowsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class GameFollowsResources_pt_br : GameFollowsResources_en_us, IGameFollowsResources, ITranslationResources
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
	public override string ActionLogin => "Conectar-se";

	/// <summary>
	/// Key: "DescriptionLoginRequired"
	/// Login dialog text for guest user
	/// English String: "You must be logged in to follow this game. Please Login or Register to continue."
	/// </summary>
	public override string DescriptionLoginRequired => "Você precisa estar conectado para poder seguir este jogo. Conecte-se ou registre-se para continuar.";

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
	public override string LabelFollowing => "Seguindo";

	/// <summary>
	/// Key: "LabelLoginRequired"
	/// Text for dialog for guest user to redirect to login
	/// English String: "Login Required"
	/// </summary>
	public override string LabelLoginRequired => "Você precisa se conectar";

	/// <summary>
	/// Key: "TooltipFollowGame"
	/// Tooltip for follow game button
	/// English String: "Follow Game"
	/// </summary>
	public override string TooltipFollowGame => "Seguir jogo";

	/// <summary>
	/// Key: "TooltipFollowLimitReached"
	/// Tooltip for follow game button
	/// English String: "Limit reached. Please unfollow other games to follow this one."
	/// </summary>
	public override string TooltipFollowLimitReached => "Limite atingido. Deixe de seguir outros jogos para começar a seguir este.";

	/// <summary>
	/// Key: "TooltipUnfollowGame"
	/// Tooltip for follow game button
	/// English String: "Unfollow Game"
	/// </summary>
	public override string TooltipUnfollowGame => "Deixar de seguir Jogo";

	public GameFollowsResources_pt_br(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "Cancelar";
	}

	protected override string _GetTemplateForActionLogin()
	{
		return "Conectar-se";
	}

	protected override string _GetTemplateForDescriptionLoginRequired()
	{
		return "Você precisa estar conectado para poder seguir este jogo. Conecte-se ou registre-se para continuar.";
	}

	protected override string _GetTemplateForLabelFollow()
	{
		return "Seguir";
	}

	protected override string _GetTemplateForLabelFollowing()
	{
		return "Seguindo";
	}

	protected override string _GetTemplateForLabelLoginRequired()
	{
		return "Você precisa se conectar";
	}

	protected override string _GetTemplateForTooltipFollowGame()
	{
		return "Seguir jogo";
	}

	protected override string _GetTemplateForTooltipFollowLimitReached()
	{
		return "Limite atingido. Deixe de seguir outros jogos para começar a seguir este.";
	}

	protected override string _GetTemplateForTooltipUnfollowGame()
	{
		return "Deixar de seguir Jogo";
	}
}
