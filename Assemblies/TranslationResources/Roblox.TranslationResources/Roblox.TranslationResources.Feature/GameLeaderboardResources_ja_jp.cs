namespace Roblox.TranslationResources.Feature;

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
	public override string HeadingClans => "クラン";

	/// <summary>
	/// Key: "Heading.Players"
	/// English String: "Players"
	/// </summary>
	public override string HeadingPlayers => "プレイヤー";

	/// <summary>
	/// Key: "Label.AllTime"
	/// English String: "All Time"
	/// </summary>
	public override string LabelAllTime => "通算";

	/// <summary>
	/// Key: "Label.Clan"
	/// English String: "Clan"
	/// </summary>
	public override string LabelClan => "クラン";

	/// <summary>
	/// Key: "Label.Clans"
	/// English String: "Clans"
	/// </summary>
	public override string LabelClans => "クラン";

	/// <summary>
	/// Key: "Label.ErrorLoading"
	/// English String: "Error loading rows..."
	/// </summary>
	public override string LabelErrorLoading => "列の読み込み中にエラーが発生しました...";

	/// <summary>
	/// Key: "Label.ErrorLoadingRows"
	/// English String: "Error loading rows."
	/// </summary>
	public override string LabelErrorLoadingRows => "列の読み込み中にエラーが発生しました。";

	/// <summary>
	/// Key: "Label.GoGetPoints"
	/// English String: "You are not yet ranked for this time period. Go earn some Points!"
	/// </summary>
	public override string LabelGoGetPoints => "あなたは、この期間中はまだランクインしていません。ポイントを稼ごう！";

	/// <summary>
	/// Key: "Label.Leader"
	/// English String: "Leader"
	/// </summary>
	public override string LabelLeader => "リーダー";

	/// <summary>
	/// Key: "Label.Loading"
	/// English String: "Loading..."
	/// </summary>
	public override string LabelLoading => "読み込み中...";

	/// <summary>
	/// Key: "Label.NoResults"
	/// English String: "No results found"
	/// </summary>
	public override string LabelNoResults => "結果が見つかりませんでした";

	/// <summary>
	/// Key: "Label.Owner"
	/// English String: "Owner"
	/// </summary>
	public override string LabelOwner => "所有者";

	/// <summary>
	/// Key: "Label.PastMonth"
	/// English String: "Past Month"
	/// </summary>
	public override string LabelPastMonth => "先月";

	/// <summary>
	/// Key: "Label.PastWeek"
	/// English String: "Past Week"
	/// </summary>
	public override string LabelPastWeek => "先週";

	/// <summary>
	/// Key: "Label.Points"
	/// English String: "Points"
	/// </summary>
	public override string LabelPoints => "ポイント";

	/// <summary>
	/// Key: "Label.PrimaryGroup"
	/// English String: "Primary Group"
	/// </summary>
	public override string LabelPrimaryGroup => "メイングループ";

	/// <summary>
	/// Key: "Label.Rank"
	/// English String: "Rank"
	/// </summary>
	public override string LabelRank => "ランク";

	/// <summary>
	/// Key: "Label.SeeMore"
	/// English String: "See More"
	/// </summary>
	public override string LabelSeeMore => "もっと見る";

	/// <summary>
	/// Key: "Label.Today"
	/// English String: "Today"
	/// </summary>
	public override string LabelToday => "今日";

	/// <summary>
	/// Key: "Label.UpdatedOneHour"
	/// English String: "Updated approx. 1 hour ago"
	/// </summary>
	public override string LabelUpdatedOneHour => "約1時間前にアップデート済み";

	/// <summary>
	/// Key: "Label.UpdatedTenMinutes"
	/// English String: "Updated approx. 10 minutes ago"
	/// </summary>
	public override string LabelUpdatedTenMinutes => "約10分前にアップデート済み";

	public GameLeaderboardResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForHeadingClans()
	{
		return "クラン";
	}

	protected override string _GetTemplateForHeadingPlayers()
	{
		return "プレイヤー";
	}

	protected override string _GetTemplateForLabelAllTime()
	{
		return "通算";
	}

	protected override string _GetTemplateForLabelClan()
	{
		return "クラン";
	}

	protected override string _GetTemplateForLabelClans()
	{
		return "クラン";
	}

	protected override string _GetTemplateForLabelErrorLoading()
	{
		return "列の読み込み中にエラーが発生しました...";
	}

	protected override string _GetTemplateForLabelErrorLoadingRows()
	{
		return "列の読み込み中にエラーが発生しました。";
	}

	protected override string _GetTemplateForLabelGoGetPoints()
	{
		return "あなたは、この期間中はまだランクインしていません。ポイントを稼ごう！";
	}

	protected override string _GetTemplateForLabelLeader()
	{
		return "リーダー";
	}

	protected override string _GetTemplateForLabelLoading()
	{
		return "読み込み中...";
	}

	protected override string _GetTemplateForLabelNoResults()
	{
		return "結果が見つかりませんでした";
	}

	protected override string _GetTemplateForLabelOwner()
	{
		return "所有者";
	}

	protected override string _GetTemplateForLabelPastMonth()
	{
		return "先月";
	}

	protected override string _GetTemplateForLabelPastWeek()
	{
		return "先週";
	}

	protected override string _GetTemplateForLabelPoints()
	{
		return "ポイント";
	}

	protected override string _GetTemplateForLabelPrimaryGroup()
	{
		return "メイングループ";
	}

	protected override string _GetTemplateForLabelRank()
	{
		return "ランク";
	}

	protected override string _GetTemplateForLabelSeeMore()
	{
		return "もっと見る";
	}

	protected override string _GetTemplateForLabelToday()
	{
		return "今日";
	}

	protected override string _GetTemplateForLabelUpdatedOneHour()
	{
		return "約1時間前にアップデート済み";
	}

	protected override string _GetTemplateForLabelUpdatedTenMinutes()
	{
		return "約10分前にアップデート済み";
	}
}
