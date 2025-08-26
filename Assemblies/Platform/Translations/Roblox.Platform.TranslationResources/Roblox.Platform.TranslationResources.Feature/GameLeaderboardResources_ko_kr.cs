namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides GameLeaderboardResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class GameLeaderboardResources_ko_kr : GameLeaderboardResources_en_us, IGameLeaderboardResources, ITranslationResources
{
	/// <summary>
	/// Key: "Heading.Clans"
	/// English String: "Clans"
	/// </summary>
	public override string HeadingClans => "í´ëžœ";

	/// <summary>
	/// Key: "Heading.Players"
	/// English String: "Players"
	/// </summary>
	public override string HeadingPlayers => "í”Œë ˆì´ì–´";

	/// <summary>
	/// Key: "Label.AllTime"
	/// English String: "All Time"
	/// </summary>
	public override string LabelAllTime => "ì „ì²´ ê¸°ê°„";

	/// <summary>
	/// Key: "Label.Clan"
	/// English String: "Clan"
	/// </summary>
	public override string LabelClan => "í´ëžœ";

	/// <summary>
	/// Key: "Label.Clans"
	/// English String: "Clans"
	/// </summary>
	public override string LabelClans => "í´ëžœ";

	/// <summary>
	/// Key: "Label.ErrorLoading"
	/// English String: "Error loading rows..."
	/// </summary>
	public override string LabelErrorLoading => "ë¦¬ë”ë³´ë“œ ë¡œë”© ì¤‘ ì˜¤ë¥˜ ë°œìƒ...";

	/// <summary>
	/// Key: "Label.ErrorLoadingRows"
	/// English String: "Error loading rows."
	/// </summary>
	public override string LabelErrorLoadingRows => "ë¦¬ë”ë³´ë“œ ë¡œë“œ ì¤‘ ì˜¤ë¥˜ ë°œìƒ.";

	/// <summary>
	/// Key: "Label.GoGetPoints"
	/// English String: "You are not yet ranked for this time period. Go earn some Points!"
	/// </summary>
	public override string LabelGoGetPoints => "ì´ë²ˆ ê¸°ê°„ì— ì•„ì§ ìˆœìœ„ì— ë“¤ì§€ ëª»í–ˆêµ°ìš”. ì ìˆ˜ë¥¼ ì¢€ ë” ìŒ“ì•„ë³´ì„¸ìš”!";

	/// <summary>
	/// Key: "Label.Leader"
	/// English String: "Leader"
	/// </summary>
	public override string LabelLeader => "ë¦¬ë”";

	/// <summary>
	/// Key: "Label.Loading"
	/// English String: "Loading..."
	/// </summary>
	public override string LabelLoading => "ë¡œë”© ì¤‘...";

	/// <summary>
	/// Key: "Label.NoResults"
	/// English String: "No results found"
	/// </summary>
	public override string LabelNoResults => "ê²°ê³¼ ì—†ìŒ";

	/// <summary>
	/// Key: "Label.Owner"
	/// English String: "Owner"
	/// </summary>
	public override string LabelOwner => "ì†Œìœ ìž";

	/// <summary>
	/// Key: "Label.PastMonth"
	/// English String: "Past Month"
	/// </summary>
	public override string LabelPastMonth => "ì§€ë‚œë‹¬";

	/// <summary>
	/// Key: "Label.PastWeek"
	/// English String: "Past Week"
	/// </summary>
	public override string LabelPastWeek => "ì§€ë‚œì£¼";

	/// <summary>
	/// Key: "Label.Points"
	/// English String: "Points"
	/// </summary>
	public override string LabelPoints => "ì ìˆ˜";

	/// <summary>
	/// Key: "Label.PrimaryGroup"
	/// English String: "Primary Group"
	/// </summary>
	public override string LabelPrimaryGroup => "ê¸°ë³¸ ê·¸ë£¹";

	/// <summary>
	/// Key: "Label.Rank"
	/// English String: "Rank"
	/// </summary>
	public override string LabelRank => "ìˆœìœ„";

	/// <summary>
	/// Key: "Label.SeeMore"
	/// English String: "See More"
	/// </summary>
	public override string LabelSeeMore => "ë” ë³´ê¸°";

	/// <summary>
	/// Key: "Label.Today"
	/// English String: "Today"
	/// </summary>
	public override string LabelToday => "ì˜¤ëŠ˜";

	/// <summary>
	/// Key: "Label.UpdatedOneHour"
	/// English String: "Updated approx. 1 hour ago"
	/// </summary>
	public override string LabelUpdatedOneHour => "ì•½ 1ì‹œê°„ ì „ì— ì—…ë°ì´íŠ¸ë¨";

	/// <summary>
	/// Key: "Label.UpdatedTenMinutes"
	/// English String: "Updated approx. 10 minutes ago"
	/// </summary>
	public override string LabelUpdatedTenMinutes => "ì•½ 10ë¶„ ì „ì— ì—…ë°ì´íŠ¸ë¨";

	public GameLeaderboardResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForHeadingClans()
	{
		return "í´ëžœ";
	}

	protected override string _GetTemplateForHeadingPlayers()
	{
		return "í”Œë ˆì´ì–´";
	}

	protected override string _GetTemplateForLabelAllTime()
	{
		return "ì „ì²´ ê¸°ê°„";
	}

	protected override string _GetTemplateForLabelClan()
	{
		return "í´ëžœ";
	}

	protected override string _GetTemplateForLabelClans()
	{
		return "í´ëžœ";
	}

	protected override string _GetTemplateForLabelErrorLoading()
	{
		return "ë¦¬ë”ë³´ë“œ ë¡œë”© ì¤‘ ì˜¤ë¥˜ ë°œìƒ...";
	}

	protected override string _GetTemplateForLabelErrorLoadingRows()
	{
		return "ë¦¬ë”ë³´ë“œ ë¡œë“œ ì¤‘ ì˜¤ë¥˜ ë°œìƒ.";
	}

	protected override string _GetTemplateForLabelGoGetPoints()
	{
		return "ì´ë²ˆ ê¸°ê°„ì— ì•„ì§ ìˆœìœ„ì— ë“¤ì§€ ëª»í–ˆêµ°ìš”. ì ìˆ˜ë¥¼ ì¢€ ë” ìŒ“ì•„ë³´ì„¸ìš”!";
	}

	protected override string _GetTemplateForLabelLeader()
	{
		return "ë¦¬ë”";
	}

	protected override string _GetTemplateForLabelLoading()
	{
		return "ë¡œë”© ì¤‘...";
	}

	protected override string _GetTemplateForLabelNoResults()
	{
		return "ê²°ê³¼ ì—†ìŒ";
	}

	protected override string _GetTemplateForLabelOwner()
	{
		return "ì†Œìœ ìž";
	}

	protected override string _GetTemplateForLabelPastMonth()
	{
		return "ì§€ë‚œë‹¬";
	}

	protected override string _GetTemplateForLabelPastWeek()
	{
		return "ì§€ë‚œì£¼";
	}

	protected override string _GetTemplateForLabelPoints()
	{
		return "ì ìˆ˜";
	}

	protected override string _GetTemplateForLabelPrimaryGroup()
	{
		return "ê¸°ë³¸ ê·¸ë£¹";
	}

	protected override string _GetTemplateForLabelRank()
	{
		return "ìˆœìœ„";
	}

	protected override string _GetTemplateForLabelSeeMore()
	{
		return "ë” ë³´ê¸°";
	}

	protected override string _GetTemplateForLabelToday()
	{
		return "ì˜¤ëŠ˜";
	}

	protected override string _GetTemplateForLabelUpdatedOneHour()
	{
		return "ì•½ 1ì‹œê°„ ì „ì— ì—…ë°ì´íŠ¸ë¨";
	}

	protected override string _GetTemplateForLabelUpdatedTenMinutes()
	{
		return "ì•½ 10ë¶„ ì „ì— ì—…ë°ì´íŠ¸ë¨";
	}
}


}
