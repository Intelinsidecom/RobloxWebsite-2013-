namespace Roblox.Platform.Studio;

internal class KeywordStatistic : IKeywordStatistic
{
	public long AssetId { get; set; }

	public string Keyword { get; set; }

	public double WilsonScore { get; set; }

	public int TotalSearch { get; set; }

	public int TotalInsert { get; set; }
}
