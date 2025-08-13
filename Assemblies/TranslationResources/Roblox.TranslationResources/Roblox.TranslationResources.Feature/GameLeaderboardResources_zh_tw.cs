namespace Roblox.TranslationResources.Feature;

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
	public override string HeadingClans => "公會";

	/// <summary>
	/// Key: "Heading.Players"
	/// English String: "Players"
	/// </summary>
	public override string HeadingPlayers => "玩家";

	/// <summary>
	/// Key: "Label.AllTime"
	/// English String: "All Time"
	/// </summary>
	public override string LabelAllTime => "歷來";

	/// <summary>
	/// Key: "Label.Clan"
	/// English String: "Clan"
	/// </summary>
	public override string LabelClan => "公會";

	/// <summary>
	/// Key: "Label.Clans"
	/// English String: "Clans"
	/// </summary>
	public override string LabelClans => "公會";

	/// <summary>
	/// Key: "Label.ErrorLoading"
	/// English String: "Error loading rows..."
	/// </summary>
	public override string LabelErrorLoading => "載入列表時發生錯誤…";

	/// <summary>
	/// Key: "Label.ErrorLoadingRows"
	/// English String: "Error loading rows."
	/// </summary>
	public override string LabelErrorLoadingRows => "載入列表時發生錯誤。";

	/// <summary>
	/// Key: "Label.GoGetPoints"
	/// English String: "You are not yet ranked for this time period. Go earn some Points!"
	/// </summary>
	public override string LabelGoGetPoints => "您在此期間沒有排名，快去玩遊戲提升排名！";

	/// <summary>
	/// Key: "Label.Leader"
	/// English String: "Leader"
	/// </summary>
	public override string LabelLeader => "隊長";

	/// <summary>
	/// Key: "Label.Loading"
	/// English String: "Loading..."
	/// </summary>
	public override string LabelLoading => "正在載入...";

	/// <summary>
	/// Key: "Label.NoResults"
	/// English String: "No results found"
	/// </summary>
	public override string LabelNoResults => "找不到結果";

	/// <summary>
	/// Key: "Label.Owner"
	/// English String: "Owner"
	/// </summary>
	public override string LabelOwner => "主人";

	/// <summary>
	/// Key: "Label.PastMonth"
	/// English String: "Past Month"
	/// </summary>
	public override string LabelPastMonth => "前月";

	/// <summary>
	/// Key: "Label.PastWeek"
	/// English String: "Past Week"
	/// </summary>
	public override string LabelPastWeek => "前一週";

	/// <summary>
	/// Key: "Label.Points"
	/// English String: "Points"
	/// </summary>
	public override string LabelPoints => "分數";

	/// <summary>
	/// Key: "Label.PrimaryGroup"
	/// English String: "Primary Group"
	/// </summary>
	public override string LabelPrimaryGroup => "主要群組";

	/// <summary>
	/// Key: "Label.Rank"
	/// English String: "Rank"
	/// </summary>
	public override string LabelRank => "排名";

	/// <summary>
	/// Key: "Label.SeeMore"
	/// English String: "See More"
	/// </summary>
	public override string LabelSeeMore => "查看更多";

	/// <summary>
	/// Key: "Label.Today"
	/// English String: "Today"
	/// </summary>
	public override string LabelToday => "今天";

	/// <summary>
	/// Key: "Label.UpdatedOneHour"
	/// English String: "Updated approx. 1 hour ago"
	/// </summary>
	public override string LabelUpdatedOneHour => "約 1 小時前更新";

	/// <summary>
	/// Key: "Label.UpdatedTenMinutes"
	/// English String: "Updated approx. 10 minutes ago"
	/// </summary>
	public override string LabelUpdatedTenMinutes => "約 10 分鐘前更新";

	public GameLeaderboardResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForHeadingClans()
	{
		return "公會";
	}

	protected override string _GetTemplateForHeadingPlayers()
	{
		return "玩家";
	}

	protected override string _GetTemplateForLabelAllTime()
	{
		return "歷來";
	}

	protected override string _GetTemplateForLabelClan()
	{
		return "公會";
	}

	protected override string _GetTemplateForLabelClans()
	{
		return "公會";
	}

	protected override string _GetTemplateForLabelErrorLoading()
	{
		return "載入列表時發生錯誤…";
	}

	protected override string _GetTemplateForLabelErrorLoadingRows()
	{
		return "載入列表時發生錯誤。";
	}

	protected override string _GetTemplateForLabelGoGetPoints()
	{
		return "您在此期間沒有排名，快去玩遊戲提升排名！";
	}

	protected override string _GetTemplateForLabelLeader()
	{
		return "隊長";
	}

	protected override string _GetTemplateForLabelLoading()
	{
		return "正在載入...";
	}

	protected override string _GetTemplateForLabelNoResults()
	{
		return "找不到結果";
	}

	protected override string _GetTemplateForLabelOwner()
	{
		return "主人";
	}

	protected override string _GetTemplateForLabelPastMonth()
	{
		return "前月";
	}

	protected override string _GetTemplateForLabelPastWeek()
	{
		return "前一週";
	}

	protected override string _GetTemplateForLabelPoints()
	{
		return "分數";
	}

	protected override string _GetTemplateForLabelPrimaryGroup()
	{
		return "主要群組";
	}

	protected override string _GetTemplateForLabelRank()
	{
		return "排名";
	}

	protected override string _GetTemplateForLabelSeeMore()
	{
		return "查看更多";
	}

	protected override string _GetTemplateForLabelToday()
	{
		return "今天";
	}

	protected override string _GetTemplateForLabelUpdatedOneHour()
	{
		return "約 1 小時前更新";
	}

	protected override string _GetTemplateForLabelUpdatedTenMinutes()
	{
		return "約 10 分鐘前更新";
	}
}
