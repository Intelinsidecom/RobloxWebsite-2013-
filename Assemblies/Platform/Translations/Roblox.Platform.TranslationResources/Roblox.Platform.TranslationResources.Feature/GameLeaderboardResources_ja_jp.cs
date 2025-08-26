namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides GameLeaderboardResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class GameLeaderboardResources_ja_jp : GameLeaderboardResources_en_us, IGameLeaderboardResources, ITranslationResources
{
	/// <summary>
	/// Key: "Heading.Clans"
	/// English String: "Clans"
	/// </summary>
	public override string HeadingClans => "ã‚¯ãƒ©ãƒ³";

	/// <summary>
	/// Key: "Heading.Players"
	/// English String: "Players"
	/// </summary>
	public override string HeadingPlayers => "ãƒ—ãƒ¬ã‚¤ãƒ¤ãƒ¼";

	/// <summary>
	/// Key: "Label.AllTime"
	/// English String: "All Time"
	/// </summary>
	public override string LabelAllTime => "é€šç®—";

	/// <summary>
	/// Key: "Label.Clan"
	/// English String: "Clan"
	/// </summary>
	public override string LabelClan => "ã‚¯ãƒ©ãƒ³";

	/// <summary>
	/// Key: "Label.Clans"
	/// English String: "Clans"
	/// </summary>
	public override string LabelClans => "ã‚¯ãƒ©ãƒ³";

	/// <summary>
	/// Key: "Label.ErrorLoading"
	/// English String: "Error loading rows..."
	/// </summary>
	public override string LabelErrorLoading => "åˆ—ã®èª­ã¿è¾¼ã¿ä¸­ã«ã‚¨ãƒ©ãƒ¼ãŒç™ºç”Ÿã—ã¾ã—ãŸ...";

	/// <summary>
	/// Key: "Label.ErrorLoadingRows"
	/// English String: "Error loading rows."
	/// </summary>
	public override string LabelErrorLoadingRows => "åˆ—ã®èª­ã¿è¾¼ã¿ä¸­ã«ã‚¨ãƒ©ãƒ¼ãŒç™ºç”Ÿã—ã¾ã—ãŸã€‚";

	/// <summary>
	/// Key: "Label.GoGetPoints"
	/// English String: "You are not yet ranked for this time period. Go earn some Points!"
	/// </summary>
	public override string LabelGoGetPoints => "ã‚ãªãŸã¯ã€ã“ã®æœŸé–“ä¸­ã¯ã¾ã ãƒ©ãƒ³ã‚¯ã‚¤ãƒ³ã—ã¦ã„ã¾ã›ã‚“ã€‚ãƒã‚¤ãƒ³ãƒˆã‚’ç¨¼ã”ã†ï¼";

	/// <summary>
	/// Key: "Label.Leader"
	/// English String: "Leader"
	/// </summary>
	public override string LabelLeader => "ãƒªãƒ¼ãƒ€ãƒ¼";

	/// <summary>
	/// Key: "Label.Loading"
	/// English String: "Loading..."
	/// </summary>
	public override string LabelLoading => "èª­ã¿è¾¼ã¿ä¸­...";

	/// <summary>
	/// Key: "Label.NoResults"
	/// English String: "No results found"
	/// </summary>
	public override string LabelNoResults => "çµæžœãŒè¦‹ã¤ã‹ã‚Šã¾ã›ã‚“ã§ã—ãŸ";

	/// <summary>
	/// Key: "Label.Owner"
	/// English String: "Owner"
	/// </summary>
	public override string LabelOwner => "æ‰€æœ‰è€…";

	/// <summary>
	/// Key: "Label.PastMonth"
	/// English String: "Past Month"
	/// </summary>
	public override string LabelPastMonth => "å…ˆæœˆ";

	/// <summary>
	/// Key: "Label.PastWeek"
	/// English String: "Past Week"
	/// </summary>
	public override string LabelPastWeek => "å…ˆé€±";

	/// <summary>
	/// Key: "Label.Points"
	/// English String: "Points"
	/// </summary>
	public override string LabelPoints => "ãƒã‚¤ãƒ³ãƒˆ";

	/// <summary>
	/// Key: "Label.PrimaryGroup"
	/// English String: "Primary Group"
	/// </summary>
	public override string LabelPrimaryGroup => "ãƒ¡ã‚¤ãƒ³ã‚°ãƒ«ãƒ¼ãƒ—";

	/// <summary>
	/// Key: "Label.Rank"
	/// English String: "Rank"
	/// </summary>
	public override string LabelRank => "ãƒ©ãƒ³ã‚¯";

	/// <summary>
	/// Key: "Label.SeeMore"
	/// English String: "See More"
	/// </summary>
	public override string LabelSeeMore => "ã‚‚ã£ã¨è¦‹ã‚‹";

	/// <summary>
	/// Key: "Label.Today"
	/// English String: "Today"
	/// </summary>
	public override string LabelToday => "ä»Šæ—¥";

	/// <summary>
	/// Key: "Label.UpdatedOneHour"
	/// English String: "Updated approx. 1 hour ago"
	/// </summary>
	public override string LabelUpdatedOneHour => "ç´„1æ™‚é–“å‰ã«ã‚¢ãƒƒãƒ—ãƒ‡ãƒ¼ãƒˆæ¸ˆã¿";

	/// <summary>
	/// Key: "Label.UpdatedTenMinutes"
	/// English String: "Updated approx. 10 minutes ago"
	/// </summary>
	public override string LabelUpdatedTenMinutes => "ç´„10åˆ†å‰ã«ã‚¢ãƒƒãƒ—ãƒ‡ãƒ¼ãƒˆæ¸ˆã¿";

	public GameLeaderboardResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForHeadingClans()
	{
		return "ã‚¯ãƒ©ãƒ³";
	}

	protected override string _GetTemplateForHeadingPlayers()
	{
		return "ãƒ—ãƒ¬ã‚¤ãƒ¤ãƒ¼";
	}

	protected override string _GetTemplateForLabelAllTime()
	{
		return "é€šç®—";
	}

	protected override string _GetTemplateForLabelClan()
	{
		return "ã‚¯ãƒ©ãƒ³";
	}

	protected override string _GetTemplateForLabelClans()
	{
		return "ã‚¯ãƒ©ãƒ³";
	}

	protected override string _GetTemplateForLabelErrorLoading()
	{
		return "åˆ—ã®èª­ã¿è¾¼ã¿ä¸­ã«ã‚¨ãƒ©ãƒ¼ãŒç™ºç”Ÿã—ã¾ã—ãŸ...";
	}

	protected override string _GetTemplateForLabelErrorLoadingRows()
	{
		return "åˆ—ã®èª­ã¿è¾¼ã¿ä¸­ã«ã‚¨ãƒ©ãƒ¼ãŒç™ºç”Ÿã—ã¾ã—ãŸã€‚";
	}

	protected override string _GetTemplateForLabelGoGetPoints()
	{
		return "ã‚ãªãŸã¯ã€ã“ã®æœŸé–“ä¸­ã¯ã¾ã ãƒ©ãƒ³ã‚¯ã‚¤ãƒ³ã—ã¦ã„ã¾ã›ã‚“ã€‚ãƒã‚¤ãƒ³ãƒˆã‚’ç¨¼ã”ã†ï¼";
	}

	protected override string _GetTemplateForLabelLeader()
	{
		return "ãƒªãƒ¼ãƒ€ãƒ¼";
	}

	protected override string _GetTemplateForLabelLoading()
	{
		return "èª­ã¿è¾¼ã¿ä¸­...";
	}

	protected override string _GetTemplateForLabelNoResults()
	{
		return "çµæžœãŒè¦‹ã¤ã‹ã‚Šã¾ã›ã‚“ã§ã—ãŸ";
	}

	protected override string _GetTemplateForLabelOwner()
	{
		return "æ‰€æœ‰è€…";
	}

	protected override string _GetTemplateForLabelPastMonth()
	{
		return "å…ˆæœˆ";
	}

	protected override string _GetTemplateForLabelPastWeek()
	{
		return "å…ˆé€±";
	}

	protected override string _GetTemplateForLabelPoints()
	{
		return "ãƒã‚¤ãƒ³ãƒˆ";
	}

	protected override string _GetTemplateForLabelPrimaryGroup()
	{
		return "ãƒ¡ã‚¤ãƒ³ã‚°ãƒ«ãƒ¼ãƒ—";
	}

	protected override string _GetTemplateForLabelRank()
	{
		return "ãƒ©ãƒ³ã‚¯";
	}

	protected override string _GetTemplateForLabelSeeMore()
	{
		return "ã‚‚ã£ã¨è¦‹ã‚‹";
	}

	protected override string _GetTemplateForLabelToday()
	{
		return "ä»Šæ—¥";
	}

	protected override string _GetTemplateForLabelUpdatedOneHour()
	{
		return "ç´„1æ™‚é–“å‰ã«ã‚¢ãƒƒãƒ—ãƒ‡ãƒ¼ãƒˆæ¸ˆã¿";
	}

	protected override string _GetTemplateForLabelUpdatedTenMinutes()
	{
		return "ç´„10åˆ†å‰ã«ã‚¢ãƒƒãƒ—ãƒ‡ãƒ¼ãƒˆæ¸ˆã¿";
	}
}


}
