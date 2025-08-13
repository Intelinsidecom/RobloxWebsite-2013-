namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides GameLeaderboardResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class GameLeaderboardResources_zh_cn : GameLeaderboardResources_en_us, IGameLeaderboardResources, ITranslationResources
{
	/// <summary>
	/// Key: "Heading.Clans"
	/// English String: "Clans"
	/// </summary>
	public override string HeadingClans => "部落";

	/// <summary>
	/// Key: "Heading.Players"
	/// English String: "Players"
	/// </summary>
	public override string HeadingPlayers => "玩家";

	/// <summary>
	/// Key: "Label.AllTime"
	/// English String: "All Time"
	/// </summary>
	public override string LabelAllTime => "所有时间";

	/// <summary>
	/// Key: "Label.Clan"
	/// English String: "Clan"
	/// </summary>
	public override string LabelClan => "部落";

	/// <summary>
	/// Key: "Label.Clans"
	/// English String: "Clans"
	/// </summary>
	public override string LabelClans => "部落";

	/// <summary>
	/// Key: "Label.ErrorLoading"
	/// English String: "Error loading rows..."
	/// </summary>
	public override string LabelErrorLoading => "加载行出错...";

	/// <summary>
	/// Key: "Label.ErrorLoadingRows"
	/// English String: "Error loading rows."
	/// </summary>
	public override string LabelErrorLoadingRows => "加载行出错。";

	/// <summary>
	/// Key: "Label.GoGetPoints"
	/// English String: "You are not yet ranked for this time period. Go earn some Points!"
	/// </summary>
	public override string LabelGoGetPoints => "你这段时间尚无排名。去赢一些点数吧！";

	/// <summary>
	/// Key: "Label.Leader"
	/// English String: "Leader"
	/// </summary>
	public override string LabelLeader => "队长";

	/// <summary>
	/// Key: "Label.Loading"
	/// English String: "Loading..."
	/// </summary>
	public override string LabelLoading => "正在加载...";

	/// <summary>
	/// Key: "Label.NoResults"
	/// English String: "No results found"
	/// </summary>
	public override string LabelNoResults => "未找到结果";

	/// <summary>
	/// Key: "Label.Owner"
	/// English String: "Owner"
	/// </summary>
	public override string LabelOwner => "主人";

	/// <summary>
	/// Key: "Label.PastMonth"
	/// English String: "Past Month"
	/// </summary>
	public override string LabelPastMonth => "上个月";

	/// <summary>
	/// Key: "Label.PastWeek"
	/// English String: "Past Week"
	/// </summary>
	public override string LabelPastWeek => "上星期";

	/// <summary>
	/// Key: "Label.Points"
	/// English String: "Points"
	/// </summary>
	public override string LabelPoints => "点数";

	/// <summary>
	/// Key: "Label.PrimaryGroup"
	/// English String: "Primary Group"
	/// </summary>
	public override string LabelPrimaryGroup => "主要群组";

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
	public override string LabelUpdatedOneHour => "约 1 小时前更新";

	/// <summary>
	/// Key: "Label.UpdatedTenMinutes"
	/// English String: "Updated approx. 10 minutes ago"
	/// </summary>
	public override string LabelUpdatedTenMinutes => "约 10 分钟前更新";

	public GameLeaderboardResources_zh_cn(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForHeadingClans()
	{
		return "部落";
	}

	protected override string _GetTemplateForHeadingPlayers()
	{
		return "玩家";
	}

	protected override string _GetTemplateForLabelAllTime()
	{
		return "所有时间";
	}

	protected override string _GetTemplateForLabelClan()
	{
		return "部落";
	}

	protected override string _GetTemplateForLabelClans()
	{
		return "部落";
	}

	protected override string _GetTemplateForLabelErrorLoading()
	{
		return "加载行出错...";
	}

	protected override string _GetTemplateForLabelErrorLoadingRows()
	{
		return "加载行出错。";
	}

	protected override string _GetTemplateForLabelGoGetPoints()
	{
		return "你这段时间尚无排名。去赢一些点数吧！";
	}

	protected override string _GetTemplateForLabelLeader()
	{
		return "队长";
	}

	protected override string _GetTemplateForLabelLoading()
	{
		return "正在加载...";
	}

	protected override string _GetTemplateForLabelNoResults()
	{
		return "未找到结果";
	}

	protected override string _GetTemplateForLabelOwner()
	{
		return "主人";
	}

	protected override string _GetTemplateForLabelPastMonth()
	{
		return "上个月";
	}

	protected override string _GetTemplateForLabelPastWeek()
	{
		return "上星期";
	}

	protected override string _GetTemplateForLabelPoints()
	{
		return "点数";
	}

	protected override string _GetTemplateForLabelPrimaryGroup()
	{
		return "主要群组";
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
		return "约 1 小时前更新";
	}

	protected override string _GetTemplateForLabelUpdatedTenMinutes()
	{
		return "约 10 分钟前更新";
	}
}
