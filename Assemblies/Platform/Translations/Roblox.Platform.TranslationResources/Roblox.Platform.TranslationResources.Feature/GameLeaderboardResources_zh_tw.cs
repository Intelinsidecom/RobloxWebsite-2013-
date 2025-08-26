namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides GameLeaderboardResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class GameLeaderboardResources_zh_tw : GameLeaderboardResources_en_us, IGameLeaderboardResources, ITranslationResources
{
	/// <summary>
	/// Key: "Heading.Clans"
	/// English String: "Clans"
	/// </summary>
	public override string HeadingClans => "å…¬æœƒ";

	/// <summary>
	/// Key: "Heading.Players"
	/// English String: "Players"
	/// </summary>
	public override string HeadingPlayers => "çŽ©å®¶";

	/// <summary>
	/// Key: "Label.AllTime"
	/// English String: "All Time"
	/// </summary>
	public override string LabelAllTime => "æ­·ä¾†";

	/// <summary>
	/// Key: "Label.Clan"
	/// English String: "Clan"
	/// </summary>
	public override string LabelClan => "å…¬æœƒ";

	/// <summary>
	/// Key: "Label.Clans"
	/// English String: "Clans"
	/// </summary>
	public override string LabelClans => "å…¬æœƒ";

	/// <summary>
	/// Key: "Label.ErrorLoading"
	/// English String: "Error loading rows..."
	/// </summary>
	public override string LabelErrorLoading => "è¼‰å…¥åˆ—è¡¨æ™‚ç™¼ç”ŸéŒ¯èª¤â€¦";

	/// <summary>
	/// Key: "Label.ErrorLoadingRows"
	/// English String: "Error loading rows."
	/// </summary>
	public override string LabelErrorLoadingRows => "è¼‰å…¥åˆ—è¡¨æ™‚ç™¼ç”ŸéŒ¯èª¤ã€‚";

	/// <summary>
	/// Key: "Label.GoGetPoints"
	/// English String: "You are not yet ranked for this time period. Go earn some Points!"
	/// </summary>
	public override string LabelGoGetPoints => "æ‚¨åœ¨æ­¤æœŸé–“æ²’æœ‰æŽ’åï¼Œå¿«åŽ»çŽ©éŠæˆ²æå‡æŽ’åï¼";

	/// <summary>
	/// Key: "Label.Leader"
	/// English String: "Leader"
	/// </summary>
	public override string LabelLeader => "éšŠé•·";

	/// <summary>
	/// Key: "Label.Loading"
	/// English String: "Loading..."
	/// </summary>
	public override string LabelLoading => "æ­£åœ¨è¼‰å…¥...";

	/// <summary>
	/// Key: "Label.NoResults"
	/// English String: "No results found"
	/// </summary>
	public override string LabelNoResults => "æ‰¾ä¸åˆ°çµæžœ";

	/// <summary>
	/// Key: "Label.Owner"
	/// English String: "Owner"
	/// </summary>
	public override string LabelOwner => "ä¸»äºº";

	/// <summary>
	/// Key: "Label.PastMonth"
	/// English String: "Past Month"
	/// </summary>
	public override string LabelPastMonth => "å‰æœˆ";

	/// <summary>
	/// Key: "Label.PastWeek"
	/// English String: "Past Week"
	/// </summary>
	public override string LabelPastWeek => "å‰ä¸€é€±";

	/// <summary>
	/// Key: "Label.Points"
	/// English String: "Points"
	/// </summary>
	public override string LabelPoints => "åˆ†æ•¸";

	/// <summary>
	/// Key: "Label.PrimaryGroup"
	/// English String: "Primary Group"
	/// </summary>
	public override string LabelPrimaryGroup => "ä¸»è¦ç¾¤çµ„";

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
	public override string LabelUpdatedOneHour => "ç´„ 1 å°æ™‚å‰æ›´æ–°";

	/// <summary>
	/// Key: "Label.UpdatedTenMinutes"
	/// English String: "Updated approx. 10 minutes ago"
	/// </summary>
	public override string LabelUpdatedTenMinutes => "ç´„ 10 åˆ†é˜å‰æ›´æ–°";

	public GameLeaderboardResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForHeadingClans()
	{
		return "å…¬æœƒ";
	}

	protected override string _GetTemplateForHeadingPlayers()
	{
		return "çŽ©å®¶";
	}

	protected override string _GetTemplateForLabelAllTime()
	{
		return "æ­·ä¾†";
	}

	protected override string _GetTemplateForLabelClan()
	{
		return "å…¬æœƒ";
	}

	protected override string _GetTemplateForLabelClans()
	{
		return "å…¬æœƒ";
	}

	protected override string _GetTemplateForLabelErrorLoading()
	{
		return "è¼‰å…¥åˆ—è¡¨æ™‚ç™¼ç”ŸéŒ¯èª¤â€¦";
	}

	protected override string _GetTemplateForLabelErrorLoadingRows()
	{
		return "è¼‰å…¥åˆ—è¡¨æ™‚ç™¼ç”ŸéŒ¯èª¤ã€‚";
	}

	protected override string _GetTemplateForLabelGoGetPoints()
	{
		return "æ‚¨åœ¨æ­¤æœŸé–“æ²’æœ‰æŽ’åï¼Œå¿«åŽ»çŽ©éŠæˆ²æå‡æŽ’åï¼";
	}

	protected override string _GetTemplateForLabelLeader()
	{
		return "éšŠé•·";
	}

	protected override string _GetTemplateForLabelLoading()
	{
		return "æ­£åœ¨è¼‰å…¥...";
	}

	protected override string _GetTemplateForLabelNoResults()
	{
		return "æ‰¾ä¸åˆ°çµæžœ";
	}

	protected override string _GetTemplateForLabelOwner()
	{
		return "ä¸»äºº";
	}

	protected override string _GetTemplateForLabelPastMonth()
	{
		return "å‰æœˆ";
	}

	protected override string _GetTemplateForLabelPastWeek()
	{
		return "å‰ä¸€é€±";
	}

	protected override string _GetTemplateForLabelPoints()
	{
		return "åˆ†æ•¸";
	}

	protected override string _GetTemplateForLabelPrimaryGroup()
	{
		return "ä¸»è¦ç¾¤çµ„";
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
		return "ç´„ 1 å°æ™‚å‰æ›´æ–°";
	}

	protected override string _GetTemplateForLabelUpdatedTenMinutes()
	{
		return "ç´„ 10 åˆ†é˜å‰æ›´æ–°";
	}
}


}
