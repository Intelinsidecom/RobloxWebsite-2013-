namespace Roblox.TranslationResources.Feature;

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
	public override string HeadingClans => "클랜";

	/// <summary>
	/// Key: "Heading.Players"
	/// English String: "Players"
	/// </summary>
	public override string HeadingPlayers => "플레이어";

	/// <summary>
	/// Key: "Label.AllTime"
	/// English String: "All Time"
	/// </summary>
	public override string LabelAllTime => "전체 기간";

	/// <summary>
	/// Key: "Label.Clan"
	/// English String: "Clan"
	/// </summary>
	public override string LabelClan => "클랜";

	/// <summary>
	/// Key: "Label.Clans"
	/// English String: "Clans"
	/// </summary>
	public override string LabelClans => "클랜";

	/// <summary>
	/// Key: "Label.ErrorLoading"
	/// English String: "Error loading rows..."
	/// </summary>
	public override string LabelErrorLoading => "리더보드 로딩 중 오류 발생...";

	/// <summary>
	/// Key: "Label.ErrorLoadingRows"
	/// English String: "Error loading rows."
	/// </summary>
	public override string LabelErrorLoadingRows => "리더보드 로드 중 오류 발생.";

	/// <summary>
	/// Key: "Label.GoGetPoints"
	/// English String: "You are not yet ranked for this time period. Go earn some Points!"
	/// </summary>
	public override string LabelGoGetPoints => "이번 기간에 아직 순위에 들지 못했군요. 점수를 좀 더 쌓아보세요!";

	/// <summary>
	/// Key: "Label.Leader"
	/// English String: "Leader"
	/// </summary>
	public override string LabelLeader => "리더";

	/// <summary>
	/// Key: "Label.Loading"
	/// English String: "Loading..."
	/// </summary>
	public override string LabelLoading => "로딩 중...";

	/// <summary>
	/// Key: "Label.NoResults"
	/// English String: "No results found"
	/// </summary>
	public override string LabelNoResults => "결과 없음";

	/// <summary>
	/// Key: "Label.Owner"
	/// English String: "Owner"
	/// </summary>
	public override string LabelOwner => "소유자";

	/// <summary>
	/// Key: "Label.PastMonth"
	/// English String: "Past Month"
	/// </summary>
	public override string LabelPastMonth => "지난달";

	/// <summary>
	/// Key: "Label.PastWeek"
	/// English String: "Past Week"
	/// </summary>
	public override string LabelPastWeek => "지난주";

	/// <summary>
	/// Key: "Label.Points"
	/// English String: "Points"
	/// </summary>
	public override string LabelPoints => "점수";

	/// <summary>
	/// Key: "Label.PrimaryGroup"
	/// English String: "Primary Group"
	/// </summary>
	public override string LabelPrimaryGroup => "기본 그룹";

	/// <summary>
	/// Key: "Label.Rank"
	/// English String: "Rank"
	/// </summary>
	public override string LabelRank => "순위";

	/// <summary>
	/// Key: "Label.SeeMore"
	/// English String: "See More"
	/// </summary>
	public override string LabelSeeMore => "더 보기";

	/// <summary>
	/// Key: "Label.Today"
	/// English String: "Today"
	/// </summary>
	public override string LabelToday => "오늘";

	/// <summary>
	/// Key: "Label.UpdatedOneHour"
	/// English String: "Updated approx. 1 hour ago"
	/// </summary>
	public override string LabelUpdatedOneHour => "약 1시간 전에 업데이트됨";

	/// <summary>
	/// Key: "Label.UpdatedTenMinutes"
	/// English String: "Updated approx. 10 minutes ago"
	/// </summary>
	public override string LabelUpdatedTenMinutes => "약 10분 전에 업데이트됨";

	public GameLeaderboardResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForHeadingClans()
	{
		return "클랜";
	}

	protected override string _GetTemplateForHeadingPlayers()
	{
		return "플레이어";
	}

	protected override string _GetTemplateForLabelAllTime()
	{
		return "전체 기간";
	}

	protected override string _GetTemplateForLabelClan()
	{
		return "클랜";
	}

	protected override string _GetTemplateForLabelClans()
	{
		return "클랜";
	}

	protected override string _GetTemplateForLabelErrorLoading()
	{
		return "리더보드 로딩 중 오류 발생...";
	}

	protected override string _GetTemplateForLabelErrorLoadingRows()
	{
		return "리더보드 로드 중 오류 발생.";
	}

	protected override string _GetTemplateForLabelGoGetPoints()
	{
		return "이번 기간에 아직 순위에 들지 못했군요. 점수를 좀 더 쌓아보세요!";
	}

	protected override string _GetTemplateForLabelLeader()
	{
		return "리더";
	}

	protected override string _GetTemplateForLabelLoading()
	{
		return "로딩 중...";
	}

	protected override string _GetTemplateForLabelNoResults()
	{
		return "결과 없음";
	}

	protected override string _GetTemplateForLabelOwner()
	{
		return "소유자";
	}

	protected override string _GetTemplateForLabelPastMonth()
	{
		return "지난달";
	}

	protected override string _GetTemplateForLabelPastWeek()
	{
		return "지난주";
	}

	protected override string _GetTemplateForLabelPoints()
	{
		return "점수";
	}

	protected override string _GetTemplateForLabelPrimaryGroup()
	{
		return "기본 그룹";
	}

	protected override string _GetTemplateForLabelRank()
	{
		return "순위";
	}

	protected override string _GetTemplateForLabelSeeMore()
	{
		return "더 보기";
	}

	protected override string _GetTemplateForLabelToday()
	{
		return "오늘";
	}

	protected override string _GetTemplateForLabelUpdatedOneHour()
	{
		return "약 1시간 전에 업데이트됨";
	}

	protected override string _GetTemplateForLabelUpdatedTenMinutes()
	{
		return "약 10분 전에 업데이트됨";
	}
}
