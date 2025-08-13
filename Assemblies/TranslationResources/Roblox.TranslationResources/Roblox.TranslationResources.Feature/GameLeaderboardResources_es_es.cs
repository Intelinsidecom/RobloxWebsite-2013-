namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides GameLeaderboardResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class GameLeaderboardResources_es_es : GameLeaderboardResources_en_us, IGameLeaderboardResources, ITranslationResources
{
	/// <summary>
	/// Key: "Heading.Clans"
	/// English String: "Clans"
	/// </summary>
	public override string HeadingClans => "Clanes";

	/// <summary>
	/// Key: "Heading.Players"
	/// English String: "Players"
	/// </summary>
	public override string HeadingPlayers => "Jugadores";

	/// <summary>
	/// Key: "Label.AllTime"
	/// English String: "All Time"
	/// </summary>
	public override string LabelAllTime => "Todos los tiempos";

	/// <summary>
	/// Key: "Label.Clan"
	/// English String: "Clan"
	/// </summary>
	public override string LabelClan => "Clan";

	/// <summary>
	/// Key: "Label.Clans"
	/// English String: "Clans"
	/// </summary>
	public override string LabelClans => "Clanes";

	/// <summary>
	/// Key: "Label.ErrorLoading"
	/// English String: "Error loading rows..."
	/// </summary>
	public override string LabelErrorLoading => "Error al cargar las filas...";

	/// <summary>
	/// Key: "Label.ErrorLoadingRows"
	/// English String: "Error loading rows."
	/// </summary>
	public override string LabelErrorLoadingRows => "Error al cargar las filas.";

	/// <summary>
	/// Key: "Label.GoGetPoints"
	/// English String: "You are not yet ranked for this time period. Go earn some Points!"
	/// </summary>
	public override string LabelGoGetPoints => "Todavía no te has clasificado en este período de tiempo. ¡Ve a ganar puntos!";

	/// <summary>
	/// Key: "Label.Leader"
	/// English String: "Leader"
	/// </summary>
	public override string LabelLeader => "Líder";

	/// <summary>
	/// Key: "Label.Loading"
	/// English String: "Loading..."
	/// </summary>
	public override string LabelLoading => "Cargando...";

	/// <summary>
	/// Key: "Label.NoResults"
	/// English String: "No results found"
	/// </summary>
	public override string LabelNoResults => "Sin resultados";

	/// <summary>
	/// Key: "Label.Owner"
	/// English String: "Owner"
	/// </summary>
	public override string LabelOwner => "Dueño";

	/// <summary>
	/// Key: "Label.PastMonth"
	/// English String: "Past Month"
	/// </summary>
	public override string LabelPastMonth => "Mes pasado";

	/// <summary>
	/// Key: "Label.PastWeek"
	/// English String: "Past Week"
	/// </summary>
	public override string LabelPastWeek => "Semana pasada";

	/// <summary>
	/// Key: "Label.Points"
	/// English String: "Points"
	/// </summary>
	public override string LabelPoints => "Puntos";

	/// <summary>
	/// Key: "Label.PrimaryGroup"
	/// English String: "Primary Group"
	/// </summary>
	public override string LabelPrimaryGroup => "Grupo principal";

	/// <summary>
	/// Key: "Label.Rank"
	/// English String: "Rank"
	/// </summary>
	public override string LabelRank => "Rango";

	/// <summary>
	/// Key: "Label.SeeMore"
	/// English String: "See More"
	/// </summary>
	public override string LabelSeeMore => "Ver más";

	/// <summary>
	/// Key: "Label.Today"
	/// English String: "Today"
	/// </summary>
	public override string LabelToday => "Hoy";

	/// <summary>
	/// Key: "Label.UpdatedOneHour"
	/// English String: "Updated approx. 1 hour ago"
	/// </summary>
	public override string LabelUpdatedOneHour => "Actualizado hace 1 hora aprox.";

	/// <summary>
	/// Key: "Label.UpdatedTenMinutes"
	/// English String: "Updated approx. 10 minutes ago"
	/// </summary>
	public override string LabelUpdatedTenMinutes => "Actualizado hace 10 minutos aprox.";

	public GameLeaderboardResources_es_es(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForHeadingClans()
	{
		return "Clanes";
	}

	protected override string _GetTemplateForHeadingPlayers()
	{
		return "Jugadores";
	}

	protected override string _GetTemplateForLabelAllTime()
	{
		return "Todos los tiempos";
	}

	protected override string _GetTemplateForLabelClan()
	{
		return "Clan";
	}

	protected override string _GetTemplateForLabelClans()
	{
		return "Clanes";
	}

	protected override string _GetTemplateForLabelErrorLoading()
	{
		return "Error al cargar las filas...";
	}

	protected override string _GetTemplateForLabelErrorLoadingRows()
	{
		return "Error al cargar las filas.";
	}

	protected override string _GetTemplateForLabelGoGetPoints()
	{
		return "Todavía no te has clasificado en este período de tiempo. ¡Ve a ganar puntos!";
	}

	protected override string _GetTemplateForLabelLeader()
	{
		return "Líder";
	}

	protected override string _GetTemplateForLabelLoading()
	{
		return "Cargando...";
	}

	protected override string _GetTemplateForLabelNoResults()
	{
		return "Sin resultados";
	}

	protected override string _GetTemplateForLabelOwner()
	{
		return "Dueño";
	}

	protected override string _GetTemplateForLabelPastMonth()
	{
		return "Mes pasado";
	}

	protected override string _GetTemplateForLabelPastWeek()
	{
		return "Semana pasada";
	}

	protected override string _GetTemplateForLabelPoints()
	{
		return "Puntos";
	}

	protected override string _GetTemplateForLabelPrimaryGroup()
	{
		return "Grupo principal";
	}

	protected override string _GetTemplateForLabelRank()
	{
		return "Rango";
	}

	protected override string _GetTemplateForLabelSeeMore()
	{
		return "Ver más";
	}

	protected override string _GetTemplateForLabelToday()
	{
		return "Hoy";
	}

	protected override string _GetTemplateForLabelUpdatedOneHour()
	{
		return "Actualizado hace 1 hora aprox.";
	}

	protected override string _GetTemplateForLabelUpdatedTenMinutes()
	{
		return "Actualizado hace 10 minutos aprox.";
	}
}
