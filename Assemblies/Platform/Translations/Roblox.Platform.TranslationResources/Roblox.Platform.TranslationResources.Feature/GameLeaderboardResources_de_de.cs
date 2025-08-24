namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides GameLeaderboardResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class GameLeaderboardResources_de_de : GameLeaderboardResources_en_us, IGameLeaderboardResources, ITranslationResources
{
	/// <summary>
	/// Key: "Heading.Clans"
	/// English String: "Clans"
	/// </summary>
	public override string HeadingClans => "Klans";

	/// <summary>
	/// Key: "Heading.Players"
	/// English String: "Players"
	/// </summary>
	public override string HeadingPlayers => "Spieler";

	/// <summary>
	/// Key: "Label.AllTime"
	/// English String: "All Time"
	/// </summary>
	public override string LabelAllTime => "Seit Beginn";

	/// <summary>
	/// Key: "Label.Clan"
	/// English String: "Clan"
	/// </summary>
	public override string LabelClan => "Klan";

	/// <summary>
	/// Key: "Label.Clans"
	/// English String: "Clans"
	/// </summary>
	public override string LabelClans => "Klans";

	/// <summary>
	/// Key: "Label.ErrorLoading"
	/// English String: "Error loading rows..."
	/// </summary>
	public override string LabelErrorLoading => "Fehler beim Laden der Reihen\u00a0...";

	/// <summary>
	/// Key: "Label.ErrorLoadingRows"
	/// English String: "Error loading rows."
	/// </summary>
	public override string LabelErrorLoadingRows => "Fehler beim Laden der Reihen.";

	/// <summary>
	/// Key: "Label.GoGetPoints"
	/// English String: "You are not yet ranked for this time period. Go earn some Points!"
	/// </summary>
	public override string LabelGoGetPoints => "Du hast noch keinen Rang für diesen Zeitabschnitt. Hol dir ein paar Punkte!";

	/// <summary>
	/// Key: "Label.Leader"
	/// English String: "Leader"
	/// </summary>
	public override string LabelLeader => "Anführer";

	/// <summary>
	/// Key: "Label.Loading"
	/// English String: "Loading..."
	/// </summary>
	public override string LabelLoading => "Wird geladen\u00a0...";

	/// <summary>
	/// Key: "Label.NoResults"
	/// English String: "No results found"
	/// </summary>
	public override string LabelNoResults => "Keine Ergebnisse gefunden";

	/// <summary>
	/// Key: "Label.Owner"
	/// English String: "Owner"
	/// </summary>
	public override string LabelOwner => "Besitzer";

	/// <summary>
	/// Key: "Label.PastMonth"
	/// English String: "Past Month"
	/// </summary>
	public override string LabelPastMonth => "Letzter Monat";

	/// <summary>
	/// Key: "Label.PastWeek"
	/// English String: "Past Week"
	/// </summary>
	public override string LabelPastWeek => "Letzte Woche";

	/// <summary>
	/// Key: "Label.Points"
	/// English String: "Points"
	/// </summary>
	public override string LabelPoints => "Punkte";

	/// <summary>
	/// Key: "Label.PrimaryGroup"
	/// English String: "Primary Group"
	/// </summary>
	public override string LabelPrimaryGroup => "Hauptgruppe";

	/// <summary>
	/// Key: "Label.Rank"
	/// English String: "Rank"
	/// </summary>
	public override string LabelRank => "Rang";

	/// <summary>
	/// Key: "Label.SeeMore"
	/// English String: "See More"
	/// </summary>
	public override string LabelSeeMore => "Mehr ansehen";

	/// <summary>
	/// Key: "Label.Today"
	/// English String: "Today"
	/// </summary>
	public override string LabelToday => "Heute";

	/// <summary>
	/// Key: "Label.UpdatedOneHour"
	/// English String: "Updated approx. 1 hour ago"
	/// </summary>
	public override string LabelUpdatedOneHour => "Vor etwa 1\u00a0Stunde aktualisiert";

	/// <summary>
	/// Key: "Label.UpdatedTenMinutes"
	/// English String: "Updated approx. 10 minutes ago"
	/// </summary>
	public override string LabelUpdatedTenMinutes => "Vor etwa 10 Minuten aktualisiert";

	public GameLeaderboardResources_de_de(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForHeadingClans()
	{
		return "Klans";
	}

	protected override string _GetTemplateForHeadingPlayers()
	{
		return "Spieler";
	}

	protected override string _GetTemplateForLabelAllTime()
	{
		return "Seit Beginn";
	}

	protected override string _GetTemplateForLabelClan()
	{
		return "Klan";
	}

	protected override string _GetTemplateForLabelClans()
	{
		return "Klans";
	}

	protected override string _GetTemplateForLabelErrorLoading()
	{
		return "Fehler beim Laden der Reihen\u00a0...";
	}

	protected override string _GetTemplateForLabelErrorLoadingRows()
	{
		return "Fehler beim Laden der Reihen.";
	}

	protected override string _GetTemplateForLabelGoGetPoints()
	{
		return "Du hast noch keinen Rang für diesen Zeitabschnitt. Hol dir ein paar Punkte!";
	}

	protected override string _GetTemplateForLabelLeader()
	{
		return "Anführer";
	}

	protected override string _GetTemplateForLabelLoading()
	{
		return "Wird geladen\u00a0...";
	}

	protected override string _GetTemplateForLabelNoResults()
	{
		return "Keine Ergebnisse gefunden";
	}

	protected override string _GetTemplateForLabelOwner()
	{
		return "Besitzer";
	}

	protected override string _GetTemplateForLabelPastMonth()
	{
		return "Letzter Monat";
	}

	protected override string _GetTemplateForLabelPastWeek()
	{
		return "Letzte Woche";
	}

	protected override string _GetTemplateForLabelPoints()
	{
		return "Punkte";
	}

	protected override string _GetTemplateForLabelPrimaryGroup()
	{
		return "Hauptgruppe";
	}

	protected override string _GetTemplateForLabelRank()
	{
		return "Rang";
	}

	protected override string _GetTemplateForLabelSeeMore()
	{
		return "Mehr ansehen";
	}

	protected override string _GetTemplateForLabelToday()
	{
		return "Heute";
	}

	protected override string _GetTemplateForLabelUpdatedOneHour()
	{
		return "Vor etwa 1\u00a0Stunde aktualisiert";
	}

	protected override string _GetTemplateForLabelUpdatedTenMinutes()
	{
		return "Vor etwa 10 Minuten aktualisiert";
	}
}
