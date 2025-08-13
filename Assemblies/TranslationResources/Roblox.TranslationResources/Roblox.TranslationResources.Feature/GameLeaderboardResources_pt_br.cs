namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides GameLeaderboardResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class GameLeaderboardResources_pt_br : GameLeaderboardResources_en_us, IGameLeaderboardResources, ITranslationResources
{
	/// <summary>
	/// Key: "Heading.Clans"
	/// English String: "Clans"
	/// </summary>
	public override string HeadingClans => "Clãs";

	/// <summary>
	/// Key: "Heading.Players"
	/// English String: "Players"
	/// </summary>
	public override string HeadingPlayers => "Jogadores";

	/// <summary>
	/// Key: "Label.AllTime"
	/// English String: "All Time"
	/// </summary>
	public override string LabelAllTime => "Todos os tempos";

	/// <summary>
	/// Key: "Label.Clan"
	/// English String: "Clan"
	/// </summary>
	public override string LabelClan => "Clã";

	/// <summary>
	/// Key: "Label.Clans"
	/// English String: "Clans"
	/// </summary>
	public override string LabelClans => "Clãs";

	/// <summary>
	/// Key: "Label.ErrorLoading"
	/// English String: "Error loading rows..."
	/// </summary>
	public override string LabelErrorLoading => "Erro ao carregar linhas...";

	/// <summary>
	/// Key: "Label.ErrorLoadingRows"
	/// English String: "Error loading rows."
	/// </summary>
	public override string LabelErrorLoadingRows => "Erro ao carregar linhas.";

	/// <summary>
	/// Key: "Label.GoGetPoints"
	/// English String: "You are not yet ranked for this time period. Go earn some Points!"
	/// </summary>
	public override string LabelGoGetPoints => "Você ainda não tem um ranque para este período de tempo. Vá ganhar uns pontos!";

	/// <summary>
	/// Key: "Label.Leader"
	/// English String: "Leader"
	/// </summary>
	public override string LabelLeader => "Líder";

	/// <summary>
	/// Key: "Label.Loading"
	/// English String: "Loading..."
	/// </summary>
	public override string LabelLoading => "Carregando...";

	/// <summary>
	/// Key: "Label.NoResults"
	/// English String: "No results found"
	/// </summary>
	public override string LabelNoResults => "Nenhum resultado encontrado";

	/// <summary>
	/// Key: "Label.Owner"
	/// English String: "Owner"
	/// </summary>
	public override string LabelOwner => "Dono";

	/// <summary>
	/// Key: "Label.PastMonth"
	/// English String: "Past Month"
	/// </summary>
	public override string LabelPastMonth => "Mês passado";

	/// <summary>
	/// Key: "Label.PastWeek"
	/// English String: "Past Week"
	/// </summary>
	public override string LabelPastWeek => "Semana passada";

	/// <summary>
	/// Key: "Label.Points"
	/// English String: "Points"
	/// </summary>
	public override string LabelPoints => "Pontos";

	/// <summary>
	/// Key: "Label.PrimaryGroup"
	/// English String: "Primary Group"
	/// </summary>
	public override string LabelPrimaryGroup => "Grupo principal";

	/// <summary>
	/// Key: "Label.Rank"
	/// English String: "Rank"
	/// </summary>
	public override string LabelRank => "Ranque";

	/// <summary>
	/// Key: "Label.SeeMore"
	/// English String: "See More"
	/// </summary>
	public override string LabelSeeMore => "Ver mais";

	/// <summary>
	/// Key: "Label.Today"
	/// English String: "Today"
	/// </summary>
	public override string LabelToday => "Hoje";

	/// <summary>
	/// Key: "Label.UpdatedOneHour"
	/// English String: "Updated approx. 1 hour ago"
	/// </summary>
	public override string LabelUpdatedOneHour => "Atualizado há mais ou menos 1 hora";

	/// <summary>
	/// Key: "Label.UpdatedTenMinutes"
	/// English String: "Updated approx. 10 minutes ago"
	/// </summary>
	public override string LabelUpdatedTenMinutes => "Atualizado há mais ou menos 10 minutos";

	public GameLeaderboardResources_pt_br(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForHeadingClans()
	{
		return "Clãs";
	}

	protected override string _GetTemplateForHeadingPlayers()
	{
		return "Jogadores";
	}

	protected override string _GetTemplateForLabelAllTime()
	{
		return "Todos os tempos";
	}

	protected override string _GetTemplateForLabelClan()
	{
		return "Clã";
	}

	protected override string _GetTemplateForLabelClans()
	{
		return "Clãs";
	}

	protected override string _GetTemplateForLabelErrorLoading()
	{
		return "Erro ao carregar linhas...";
	}

	protected override string _GetTemplateForLabelErrorLoadingRows()
	{
		return "Erro ao carregar linhas.";
	}

	protected override string _GetTemplateForLabelGoGetPoints()
	{
		return "Você ainda não tem um ranque para este período de tempo. Vá ganhar uns pontos!";
	}

	protected override string _GetTemplateForLabelLeader()
	{
		return "Líder";
	}

	protected override string _GetTemplateForLabelLoading()
	{
		return "Carregando...";
	}

	protected override string _GetTemplateForLabelNoResults()
	{
		return "Nenhum resultado encontrado";
	}

	protected override string _GetTemplateForLabelOwner()
	{
		return "Dono";
	}

	protected override string _GetTemplateForLabelPastMonth()
	{
		return "Mês passado";
	}

	protected override string _GetTemplateForLabelPastWeek()
	{
		return "Semana passada";
	}

	protected override string _GetTemplateForLabelPoints()
	{
		return "Pontos";
	}

	protected override string _GetTemplateForLabelPrimaryGroup()
	{
		return "Grupo principal";
	}

	protected override string _GetTemplateForLabelRank()
	{
		return "Ranque";
	}

	protected override string _GetTemplateForLabelSeeMore()
	{
		return "Ver mais";
	}

	protected override string _GetTemplateForLabelToday()
	{
		return "Hoje";
	}

	protected override string _GetTemplateForLabelUpdatedOneHour()
	{
		return "Atualizado há mais ou menos 1 hora";
	}

	protected override string _GetTemplateForLabelUpdatedTenMinutes()
	{
		return "Atualizado há mais ou menos 10 minutos";
	}
}
