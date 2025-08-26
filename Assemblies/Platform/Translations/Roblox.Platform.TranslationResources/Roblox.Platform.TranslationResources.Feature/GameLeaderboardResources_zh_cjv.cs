namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides GameLeaderboardResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class GameLeaderboardResources_zh_cjv : GameLeaderboardResources_en_us, IGameLeaderboardResources, ITranslationResources
{
	/// <summary>
	/// Key: "Heading.Clans"
	/// English String: "Clans"
	/// </summary>
	public override string HeadingClans => "éƒ¨è½";

	/// <summary>
	/// Key: "Heading.Players"
	/// English String: "Players"
	/// </summary>
	public override string HeadingPlayers => "çŽ©å®¶";

	/// <summary>
	/// Key: "Label.AllTime"
	/// English String: "All Time"
	/// </summary>
	public override string LabelAllTime => "æ‰€æœ‰æ—¶é—´";

	/// <summary>
	/// Key: "Label.Clan"
	/// English String: "Clan"
	/// </summary>
	public override string LabelClan => "éƒ¨è½";

	/// <summary>
	/// Key: "Label.Clans"
	/// English String: "Clans"
	/// </summary>
	public override string LabelClans => "éƒ¨è½";

	/// <summary>
	/// Key: "Label.ErrorLoading"
	/// English String: "Error loading rows..."
	/// </summary>
	public override string LabelErrorLoading => "åŠ è½½è¡Œå‡ºé”™...";

	/// <summary>
	/// Key: "Label.ErrorLoadingRows"
	/// English String: "Error loading rows."
	/// </summary>
	public override string LabelErrorLoadingRows => "åŠ è½½è¡Œå‡ºé”™ã€‚";

	/// <summary>
	/// Key: "Label.GoGetPoints"
	/// English String: "You are not yet ranked for this time period. Go earn some Points!"
	/// </summary>
	public override string LabelGoGetPoints => "ä½ è¿™æ®µæ—¶é—´å°šæ— æŽ’åã€‚åŽ»èµ¢ä¸€äº›ç‚¹æ•°å§ï¼";

	/// <summary>
	/// Key: "Label.Leader"
	/// English String: "Leader"
	/// </summary>
	public override string LabelLeader => "é˜Ÿé•¿";

	/// <summary>
	/// Key: "Label.Loading"
	/// English String: "Loading..."
	/// </summary>
	public override string LabelLoading => "æ­£åœ¨åŠ è½½...";

	/// <summary>
	/// Key: "Label.NoResults"
	/// English String: "No results found"
	/// </summary>
	public override string LabelNoResults => "æœªæ‰¾åˆ°ç»“æžœ";

	/// <summary>
	/// Key: "Label.Owner"
	/// English String: "Owner"
	/// </summary>
	public override string LabelOwner => "ä¸»äºº";

	/// <summary>
	/// Key: "Label.PastMonth"
	/// English String: "Past Month"
	/// </summary>
	public override string LabelPastMonth => "ä¸Šä¸ªæœˆ";

	/// <summary>
	/// Key: "Label.PastWeek"
	/// English String: "Past Week"
	/// </summary>
	public override string LabelPastWeek => "ä¸Šæ˜ŸæœŸ";

	/// <summary>
	/// Key: "Label.Points"
	/// English String: "Points"
	/// </summary>
	public override string LabelPoints => "ç‚¹æ•°";

	/// <summary>
	/// Key: "Label.PrimaryGroup"
	/// English String: "Primary Group"
	/// </summary>
	public override string LabelPrimaryGroup => "ä¸»è¦ç¾¤ç»„";

	/// <summary>
	/// Key: "Label.Rank"
	/// English String: "Rank"
	/// </summary>
	public override string LabelRank => "æŽ’å";

	/// <summary>
	/// Key: "Label.SeeMore"
	/// English String: "See More"
	/// </summary>
	public override string LabelSeeMore => "æŸ¥çœ‹æ›´å¤š";

	/// <summary>
	/// Key: "Label.Today"
	/// English String: "Today"
	/// </summary>
	public override string LabelToday => "ä»Šå¤©";

	/// <summary>
	/// Key: "Label.UpdatedOneHour"
	/// English String: "Updated approx. 1 hour ago"
	/// </summary>
	public override string LabelUpdatedOneHour => "çº¦ 1 å°æ—¶å‰æ›´æ–°";

	/// <summary>
	/// Key: "Label.UpdatedTenMinutes"
	/// English String: "Updated approx. 10 minutes ago"
	/// </summary>
	public override string LabelUpdatedTenMinutes => "çº¦ 10 åˆ†é’Ÿå‰æ›´æ–°";

	public GameLeaderboardResources_zh_cjv(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForHeadingClans()
	{
		return "éƒ¨è½";
	}

	protected override string _GetTemplateForHeadingPlayers()
	{
		return "çŽ©å®¶";
	}

	protected override string _GetTemplateForLabelAllTime()
	{
		return "æ‰€æœ‰æ—¶é—´";
	}

	protected override string _GetTemplateForLabelClan()
	{
		return "éƒ¨è½";
	}

	protected override string _GetTemplateForLabelClans()
	{
		return "éƒ¨è½";
	}

	protected override string _GetTemplateForLabelErrorLoading()
	{
		return "åŠ è½½è¡Œå‡ºé”™...";
	}

	protected override string _GetTemplateForLabelErrorLoadingRows()
	{
		return "åŠ è½½è¡Œå‡ºé”™ã€‚";
	}

	protected override string _GetTemplateForLabelGoGetPoints()
	{
		return "ä½ è¿™æ®µæ—¶é—´å°šæ— æŽ’åã€‚åŽ»èµ¢ä¸€äº›ç‚¹æ•°å§ï¼";
	}

	protected override string _GetTemplateForLabelLeader()
	{
		return "é˜Ÿé•¿";
	}

	protected override string _GetTemplateForLabelLoading()
	{
		return "æ­£åœ¨åŠ è½½...";
	}

	protected override string _GetTemplateForLabelNoResults()
	{
		return "æœªæ‰¾åˆ°ç»“æžœ";
	}

	protected override string _GetTemplateForLabelOwner()
	{
		return "ä¸»äºº";
	}

	protected override string _GetTemplateForLabelPastMonth()
	{
		return "ä¸Šä¸ªæœˆ";
	}

	protected override string _GetTemplateForLabelPastWeek()
	{
		return "ä¸Šæ˜ŸæœŸ";
	}

	protected override string _GetTemplateForLabelPoints()
	{
		return "ç‚¹æ•°";
	}

	protected override string _GetTemplateForLabelPrimaryGroup()
	{
		return "ä¸»è¦ç¾¤ç»„";
	}

	protected override string _GetTemplateForLabelRank()
	{
		return "æŽ’å";
	}

	protected override string _GetTemplateForLabelSeeMore()
	{
		return "æŸ¥çœ‹æ›´å¤š";
	}

	protected override string _GetTemplateForLabelToday()
	{
		return "ä»Šå¤©";
	}

	protected override string _GetTemplateForLabelUpdatedOneHour()
	{
		return "çº¦ 1 å°æ—¶å‰æ›´æ–°";
	}

	protected override string _GetTemplateForLabelUpdatedTenMinutes()
	{
		return "çº¦ 10 åˆ†é’Ÿå‰æ›´æ–°";
	}
}


}
