namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides GameLeaderboardResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class GameLeaderboardResources_fr_fr : GameLeaderboardResources_en_us, IGameLeaderboardResources, ITranslationResources
{
	/// <summary>
	/// Key: "Heading.Clans"
	/// English String: "Clans"
	/// </summary>
	public override string HeadingClans => "Clans";

	/// <summary>
	/// Key: "Heading.Players"
	/// English String: "Players"
	/// </summary>
	public override string HeadingPlayers => "Joueurs";

	/// <summary>
	/// Key: "Label.AllTime"
	/// English String: "All Time"
	/// </summary>
	public override string LabelAllTime => "Tous les temps";

	/// <summary>
	/// Key: "Label.Clan"
	/// English String: "Clan"
	/// </summary>
	public override string LabelClan => "Clan";

	/// <summary>
	/// Key: "Label.Clans"
	/// English String: "Clans"
	/// </summary>
	public override string LabelClans => "Clans";

	/// <summary>
	/// Key: "Label.ErrorLoading"
	/// English String: "Error loading rows..."
	/// </summary>
	public override string LabelErrorLoading => "Erreur lors du chargement des lignes...";

	/// <summary>
	/// Key: "Label.ErrorLoadingRows"
	/// English String: "Error loading rows."
	/// </summary>
	public override string LabelErrorLoadingRows => "Erreur lors du chargement des lignes.";

	/// <summary>
	/// Key: "Label.GoGetPoints"
	/// English String: "You are not yet ranked for this time period. Go earn some Points!"
	/// </summary>
	public override string LabelGoGetPoints => "Vous n'êtes pas encore dans le classement pour cette période. Marquez des points\u00a0!";

	/// <summary>
	/// Key: "Label.Leader"
	/// English String: "Leader"
	/// </summary>
	public override string LabelLeader => "Chef";

	/// <summary>
	/// Key: "Label.Loading"
	/// English String: "Loading..."
	/// </summary>
	public override string LabelLoading => "Chargement...";

	/// <summary>
	/// Key: "Label.NoResults"
	/// English String: "No results found"
	/// </summary>
	public override string LabelNoResults => "Aucun résultat trouvé";

	/// <summary>
	/// Key: "Label.Owner"
	/// English String: "Owner"
	/// </summary>
	public override string LabelOwner => "Propriétaire";

	/// <summary>
	/// Key: "Label.PastMonth"
	/// English String: "Past Month"
	/// </summary>
	public override string LabelPastMonth => "Mois dernier";

	/// <summary>
	/// Key: "Label.PastWeek"
	/// English String: "Past Week"
	/// </summary>
	public override string LabelPastWeek => "Semaine dernière";

	/// <summary>
	/// Key: "Label.Points"
	/// English String: "Points"
	/// </summary>
	public override string LabelPoints => "Points";

	/// <summary>
	/// Key: "Label.PrimaryGroup"
	/// English String: "Primary Group"
	/// </summary>
	public override string LabelPrimaryGroup => "Groupe principal";

	/// <summary>
	/// Key: "Label.Rank"
	/// English String: "Rank"
	/// </summary>
	public override string LabelRank => "Rang";

	/// <summary>
	/// Key: "Label.SeeMore"
	/// English String: "See More"
	/// </summary>
	public override string LabelSeeMore => "Afficher plus";

	/// <summary>
	/// Key: "Label.Today"
	/// English String: "Today"
	/// </summary>
	public override string LabelToday => "Aujourd'hui";

	/// <summary>
	/// Key: "Label.UpdatedOneHour"
	/// English String: "Updated approx. 1 hour ago"
	/// </summary>
	public override string LabelUpdatedOneHour => "Mis à jour il y a ~1\u00a0h";

	/// <summary>
	/// Key: "Label.UpdatedTenMinutes"
	/// English String: "Updated approx. 10 minutes ago"
	/// </summary>
	public override string LabelUpdatedTenMinutes => "Mis à jour il y a ~10\u00a0min";

	public GameLeaderboardResources_fr_fr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForHeadingClans()
	{
		return "Clans";
	}

	protected override string _GetTemplateForHeadingPlayers()
	{
		return "Joueurs";
	}

	protected override string _GetTemplateForLabelAllTime()
	{
		return "Tous les temps";
	}

	protected override string _GetTemplateForLabelClan()
	{
		return "Clan";
	}

	protected override string _GetTemplateForLabelClans()
	{
		return "Clans";
	}

	protected override string _GetTemplateForLabelErrorLoading()
	{
		return "Erreur lors du chargement des lignes...";
	}

	protected override string _GetTemplateForLabelErrorLoadingRows()
	{
		return "Erreur lors du chargement des lignes.";
	}

	protected override string _GetTemplateForLabelGoGetPoints()
	{
		return "Vous n'êtes pas encore dans le classement pour cette période. Marquez des points\u00a0!";
	}

	protected override string _GetTemplateForLabelLeader()
	{
		return "Chef";
	}

	protected override string _GetTemplateForLabelLoading()
	{
		return "Chargement...";
	}

	protected override string _GetTemplateForLabelNoResults()
	{
		return "Aucun résultat trouvé";
	}

	protected override string _GetTemplateForLabelOwner()
	{
		return "Propriétaire";
	}

	protected override string _GetTemplateForLabelPastMonth()
	{
		return "Mois dernier";
	}

	protected override string _GetTemplateForLabelPastWeek()
	{
		return "Semaine dernière";
	}

	protected override string _GetTemplateForLabelPoints()
	{
		return "Points";
	}

	protected override string _GetTemplateForLabelPrimaryGroup()
	{
		return "Groupe principal";
	}

	protected override string _GetTemplateForLabelRank()
	{
		return "Rang";
	}

	protected override string _GetTemplateForLabelSeeMore()
	{
		return "Afficher plus";
	}

	protected override string _GetTemplateForLabelToday()
	{
		return "Aujourd'hui";
	}

	protected override string _GetTemplateForLabelUpdatedOneHour()
	{
		return "Mis à jour il y a ~1\u00a0h";
	}

	protected override string _GetTemplateForLabelUpdatedTenMinutes()
	{
		return "Mis à jour il y a ~10\u00a0min";
	}
}
