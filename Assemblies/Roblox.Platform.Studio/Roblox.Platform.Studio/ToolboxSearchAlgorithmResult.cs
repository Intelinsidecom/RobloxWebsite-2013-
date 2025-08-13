namespace Roblox.Platform.Studio;

internal class ToolboxSearchAlgorithmResult : IToolboxSearchAlgorithmResult
{
	public long Id { get; }

	public int AlgorithmId { get; }

	public string Keyword { get; }

	public long[] Results { get; }

	public ToolboxSearchAlgorithmResult(long id, int algorithmId, string keyword, long[] results)
	{
		Id = id;
		AlgorithmId = algorithmId;
		Keyword = keyword;
		Results = results;
	}
}
