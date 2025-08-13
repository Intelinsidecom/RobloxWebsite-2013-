using System.Collections.Generic;

namespace Roblox.Platform.Studio;

/// <summary>
/// Provides an interface for AssetSearchKeywordStatistic.
/// </summary>
public interface IAssetSearchKeywordStatistic
{
	/// <summary>
	/// Get the Id.
	/// </summary>
	long Id { get; }

	/// <summary>
	/// Get the asset Id.
	/// </summary>
	long AssetId { get; }

	/// <summary>
	/// Get the json string.
	/// </summary>
	string Json { get; }

	/// <summary>
	/// Get the keyword stats for a given keyword.
	/// </summary>
	/// <param name="keyword"></param>
	IKeywordStatistic GetKeywordStatistics(string keyword);

	/// <summary>
	/// Get all keyword stats for a given asset id.
	/// </summary>
	Dictionary<string, double> GetAllKeywordStatistics();
}
