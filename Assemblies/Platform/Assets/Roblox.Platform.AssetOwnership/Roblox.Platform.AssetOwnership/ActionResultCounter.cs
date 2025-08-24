using Roblox.Instrumentation;

namespace Roblox.Platform.AssetOwnership;

/// <summary>
/// Counts for either Total, or "{action} | {result}"
/// where action is AwardAsset|AwardAssetAllowingDuplicates, etc, and result is AwardAssetResult|TransferAssetResult|RevokeAssetResult
/// </summary>
internal sealed class ActionResultCounter
{
	private const string _AverageResponseTimeCounterName = "AvgResponseTime";

	private const string _ActionResultsPerSecondCounterName = "ActionResultsPerSecond";

	public IAverageValueCounter AverageResponseTime { get; }

	public IRateOfCountsPerSecondCounter ActionResultsPerSecond { get; }

	public ActionResultCounter(ICounterRegistry registry, string category, string actionResult)
	{
		string actionsResultsPerSecondName = string.Format("{0} | {1}", "ActionResultsPerSecond", actionResult);
		ActionResultsPerSecond = registry.GetRateOfCountsPerSecondCounter(category, actionsResultsPerSecondName);
		string responseTimeName = string.Format("{0} | {1}", "AvgResponseTime", actionResult);
		AverageResponseTime = registry.GetAverageValueCounter(category, responseTimeName);
	}
}
