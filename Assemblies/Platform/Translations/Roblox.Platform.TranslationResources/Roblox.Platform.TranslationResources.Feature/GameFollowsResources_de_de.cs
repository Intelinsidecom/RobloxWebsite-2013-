namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides GameFollowsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class GameFollowsResources_de_de : GameFollowsResources_en_us, IGameFollowsResources, ITranslationResources
{
	/// <summary>
	/// Key: "ActionCancel"
	/// Login dialog cancel label
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "Abbrechen";

	/// <summary>
	/// Key: "ActionLogin"
	/// Login button label
	/// English String: "Login"
	/// </summary>
	public override string ActionLogin => "Anmelden";

	/// <summary>
	/// Key: "DescriptionLoginRequired"
	/// Login dialog text for guest user
	/// English String: "You must be logged in to follow this game. Please Login or Register to continue."
	/// </summary>
	public override string DescriptionLoginRequired => "Um diesem Spiel zu folgen, musst du angemeldet sein. Bitte anmelden oder registrieren, um fortzufahren.";

	/// <summary>
	/// Key: "LabelFollow"
	/// Label for follow game button
	/// English String: "Follow"
	/// </summary>
	public override string LabelFollow => "Folgen";

	/// <summary>
	/// Key: "LabelFollowing"
	/// Label for follow game button
	/// English String: "Following"
	/// </summary>
	public override string LabelFollowing => "Ich folge";

	/// <summary>
	/// Key: "LabelLoginRequired"
	/// Text for dialog for guest user to redirect to login
	/// English String: "Login Required"
	/// </summary>
	public override string LabelLoginRequired => "Anmeldung erforderlich";

	/// <summary>
	/// Key: "TooltipFollowGame"
	/// Tooltip for follow game button
	/// English String: "Follow Game"
	/// </summary>
	public override string TooltipFollowGame => "Spiel folgen";

	/// <summary>
	/// Key: "TooltipFollowLimitReached"
	/// Tooltip for follow game button
	/// English String: "Limit reached. Please unfollow other games to follow this one."
	/// </summary>
	public override string TooltipFollowLimitReached => "Maximale Anzahl erreicht. Bitte folge anderen Spielen nicht mehr, um diesem Spiel zu folgen.";

	/// <summary>
	/// Key: "TooltipUnfollowGame"
	/// Tooltip for follow game button
	/// English String: "Unfollow Game"
	/// </summary>
	public override string TooltipUnfollowGame => "Spiel nicht mehr folgen";

	public GameFollowsResources_de_de(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "Abbrechen";
	}

	protected override string _GetTemplateForActionLogin()
	{
		return "Anmelden";
	}

	protected override string _GetTemplateForDescriptionLoginRequired()
	{
		return "Um diesem Spiel zu folgen, musst du angemeldet sein. Bitte anmelden oder registrieren, um fortzufahren.";
	}

	protected override string _GetTemplateForLabelFollow()
	{
		return "Folgen";
	}

	protected override string _GetTemplateForLabelFollowing()
	{
		return "Ich folge";
	}

	protected override string _GetTemplateForLabelLoginRequired()
	{
		return "Anmeldung erforderlich";
	}

	protected override string _GetTemplateForTooltipFollowGame()
	{
		return "Spiel folgen";
	}

	protected override string _GetTemplateForTooltipFollowLimitReached()
	{
		return "Maximale Anzahl erreicht. Bitte folge anderen Spielen nicht mehr, um diesem Spiel zu folgen.";
	}

	protected override string _GetTemplateForTooltipUnfollowGame()
	{
		return "Spiel nicht mehr folgen";
	}
}
