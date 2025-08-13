using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Platform.Assets;
using Roblox.Platform.Core;
using Roblox.Platform.Math.Statistics;
using Roblox.Platform.Studio.Properties;

namespace Roblox.Platform.Studio;

internal class StudioSearchAssetsSortFactory : IStudioSearchAssetsSortFactory, IDomainFactory<StudioDomainFactories>, IDomainObject<StudioDomainFactories>
{
	private const string _AmplitudeCorrection = "AmplitudeCorrection";

	private const string _ShrinkCorrection = "ShrinkCorrection";

	public StudioDomainFactories DomainFactories { get; }

	public StudioSearchAssetsSortFactory(StudioDomainFactories studioDomainFactories)
	{
		if (studioDomainFactories == null)
		{
			throw new PlatformArgumentNullException("studioDomainFactories");
		}
		DomainFactories = studioDomainFactories;
	}

	/// <summary>
	/// This method takes two list of assets and does union of list and sort the merged list 
	/// by beta distrubution sample that is calculated from total searches and total inserts of assets.
	/// Total inserts and total searches of an asset are fetched from database using <seealso cref="T:Roblox.Platform.Studio.IAssetSearchKeywordStatisticFactory" />
	/// </summary>
	/// <param name="assetsFromDefaultSearch"></param>
	/// <param name="assetsFromWilsonScoreSearch"></param>
	/// <param name="betaDistribution"></param>
	/// <param name="assetSearchKeywordStatisticFactory"></param>
	/// <param name="keyword"></param>
	public ICollection<IAsset> GetSortedAssets(ICollection<IAsset> assetsFromDefaultSearch, ICollection<IAsset> assetsFromWilsonScoreSearch, BetaDistribution betaDistribution, IAssetSearchKeywordStatisticFactory assetSearchKeywordStatisticFactory, string keyword)
	{
		if (!Settings.Default.AdjustedThompsonSamplingSortingEnabled)
		{
			return assetsFromWilsonScoreSearch.Union(assetsFromDefaultSearch, new AssetComparer()).ToList().OrderByDescending(delegate(IAsset a)
			{
				IKeywordStatistic keywordStatistic = assetSearchKeywordStatisticFactory.Get(a.Id)?.GetKeywordStatistics(keyword);
				return (keywordStatistic != null) ? betaDistribution.GetBetaDistributionSample(keywordStatistic.TotalInsert, keywordStatistic.TotalSearch - keywordStatistic.TotalInsert) : betaDistribution.GetBetaDistributionSample(1.0, 1.0);
			})
				.ToList();
		}
		return GetAssetsSortedByAdjustedThompsonSample(assetsFromDefaultSearch, assetsFromWilsonScoreSearch, betaDistribution, assetSearchKeywordStatisticFactory, keyword);
	}

	/// <summary>
	/// This method takes two list of assets and does union of list and sort the merged list 
	/// by adjusted beta distrubution sample that is calculated from adjustments in total searches and total inserts of assets.
	/// Total inserts and total searches of an asset are fetched from database using <seealso cref="T:Roblox.Platform.Studio.IAssetSearchKeywordStatisticFactory" />
	/// </summary>
	/// <param name="assetsFromDefaultSearch"></param>
	/// <param name="assetsFromWilsonScoreSearch"></param>
	/// <param name="betaDistribution"></param>
	/// <param name="assetSearchKeywordStatisticFactory"></param>
	/// <param name="keyword"></param>
	public ICollection<IAsset> GetAssetsSortedByAdjustedThompsonSample(ICollection<IAsset> assetsFromDefaultSearch, ICollection<IAsset> assetsFromWilsonScoreSearch, BetaDistribution betaDistribution, IAssetSearchKeywordStatisticFactory assetSearchKeywordStatisticFactory, string keyword)
	{
		double zeroSearchedModelSuccess = 0.0;
		double zeroSearchedModelFailure = 0.0;
		double meanSuccess = 0.0;
		double meanFailure = 0.0;
		double shrink = 0.0;
		CalculateMeanSuccessFailure(assetsFromWilsonScoreSearch, assetSearchKeywordStatisticFactory, keyword, shrink, out meanSuccess, out meanFailure);
		CalculateAdjustmentToZeroSearchedModel(meanSuccess, meanFailure, out zeroSearchedModelSuccess, out zeroSearchedModelFailure);
		HashSet<long> assetIdHashSetFromWilsonScoreSort = new HashSet<long>(assetsFromWilsonScoreSearch.Select((IAsset a) => a.Id));
		return (from a in assetsFromWilsonScoreSearch.Union(assetsFromDefaultSearch, new AssetComparer()).ToList()
			orderby GetBetaDistributionSample(a.Id, assetIdHashSetFromWilsonScoreSort, zeroSearchedModelSuccess, zeroSearchedModelFailure, shrink, keyword, assetSearchKeywordStatisticFactory, betaDistribution) descending
			select a).ToList();
	}

	/// <summary>
	/// Provides the beta distribution based sort order.
	/// </summary>
	/// <param name="assetId"></param>
	/// <param name="assetIds"></param>
	/// <param name="zeroSearchedModelSuccess"></param>
	/// <param name="zeroSearchedModelFailure"></param>
	/// <param name="shrink"></param>
	/// <param name="keyword"></param>
	/// <param name="assetSearchKeywordStatisticFactory"></param>
	/// <param name="betaDistribution"></param>
	/// <returns></returns>
	private double GetBetaDistributionSample(long assetId, HashSet<long> assetIds, double zeroSearchedModelSuccess, double zeroSearchedModelFailure, double shrink, string keyword, IAssetSearchKeywordStatisticFactory assetSearchKeywordStatisticFactory, BetaDistribution betaDistribution)
	{
		IKeywordStatistic kwdStats = assetSearchKeywordStatisticFactory.Get(assetId)?.GetKeywordStatistics(keyword);
		if (kwdStats != null && assetIds.Contains(assetId))
		{
			int laplaceCorrectedSuccess = Settings.Default.ThompsonLaplaceSuccessAdjustmentNumber;
			int laplaceCorrectedFailure = Settings.Default.ThompsonLaplaceFailureAdjustmentNumber;
			double success = kwdStats.TotalInsert + laplaceCorrectedSuccess;
			double failure = kwdStats.TotalSearch - kwdStats.TotalInsert + laplaceCorrectedFailure;
			ApplyAmplitudeCorrection(shrink, ref success, ref failure);
			return betaDistribution.GetBetaDistributionSample(success, failure);
		}
		return betaDistribution.GetBetaDistributionSample(zeroSearchedModelSuccess, zeroSearchedModelFailure);
	}

	/// <summary>
	/// Calculate success and failure using different correction schemes.
	/// </summary>
	/// <param name="shrink"></param>
	/// <param name="success"></param>
	/// <param name="failure"></param>
	private void ApplyAmplitudeCorrection(double shrink, ref double success, ref double failure)
	{
		string thompsonSamplingCorrections = Settings.Default.ThompsonSamplingCorrections;
		if (!(thompsonSamplingCorrections == "AmplitudeCorrection"))
		{
			if (thompsonSamplingCorrections == "ShrinkCorrection")
			{
				ApplyAmplitudeShrinkCorrection(shrink, ref success, ref failure);
			}
			else
			{
				ApplyMaximumAmplitudeCorrection(ref success, ref failure);
			}
		}
		else
		{
			ApplyMaximumAmplitudeCorrection(ref success, ref failure);
		}
	}

	private void ApplyMaximumAmplitudeCorrection(ref double success, ref double failure)
	{
		double maxAmplitude = Settings.Default.MaxAmplitudeForBetaCurves;
		double total = success + failure;
		if (total != 0.0 && total > maxAmplitude)
		{
			success = maxAmplitude * (success / total);
			failure = maxAmplitude - success;
		}
	}

	private void ApplyAmplitudeShrinkCorrection(double shrink, ref double success, ref double failure)
	{
		success = shrink * success;
		failure = shrink * failure;
	}

	/// <summary>
	/// Calculate success and failure of models which do not have keyword stats data.
	/// Either new models or never searched.
	/// </summary>
	/// <param name="meanSuccess"></param>
	/// <param name="meanFailure"></param>
	/// <param name="success"></param>
	/// <param name="failure"></param>
	private void CalculateAdjustmentToZeroSearchedModel(double meanSuccess, double meanFailure, out double success, out double failure)
	{
		double num = meanSuccess + meanFailure;
		meanSuccess = Settings.Default.ZeroSearchedSuccessFailureRatioMultiplier * meanSuccess;
		meanFailure = num - meanSuccess;
		success = Settings.Default.ZeroSearchedAmplitudeMultiplier * meanSuccess;
		failure = Settings.Default.ZeroSearchedAmplitudeMultiplier * meanFailure;
	}

	private void CalculateMeanSuccessFailure(ICollection<IAsset> assets, IAssetSearchKeywordStatisticFactory assetSearchKeywordStatisticFactory, string keyword, double shrink, out double meanSuccess, out double meanFailure)
	{
		meanSuccess = 0.0;
		meanFailure = 0.0;
		double success = 0.0;
		double failure = 0.0;
		int total = 0;
		foreach (IAsset asset in assets)
		{
			IKeywordStatistic kwdStats = assetSearchKeywordStatisticFactory.Get(asset.Id)?.GetKeywordStatistics(keyword);
			if (kwdStats != null)
			{
				int laplaceCorrectedSuccess = Settings.Default.ThompsonLaplaceSuccessAdjustmentNumber;
				int laplaceCorrectedFailure = Settings.Default.ThompsonLaplaceFailureAdjustmentNumber;
				double correctedSuccess = kwdStats.TotalInsert + laplaceCorrectedSuccess;
				double correctedFailure = kwdStats.TotalSearch - kwdStats.TotalInsert + laplaceCorrectedFailure;
				ApplyAmplitudeCorrection(shrink, ref correctedSuccess, ref correctedFailure);
				success += correctedSuccess;
				failure += correctedFailure;
				total++;
			}
		}
		if (total != 0)
		{
			meanSuccess = success / (double)total;
			meanFailure = failure / (double)total;
		}
	}

	private double GetShrink(ICollection<IAsset> assets, IAssetSearchKeywordStatisticFactory assetSearchKeywordStatisticFactory, string keyword)
	{
		double globalMaxAmplitude = Settings.Default.MaxAmplitudeForBetaCurves;
		double maxAmplitude = -1.0;
		double shrink = 0.0;
		foreach (IAsset asset in assets)
		{
			IKeywordStatistic kwdStats = assetSearchKeywordStatisticFactory.Get(asset.Id)?.GetKeywordStatistics(keyword);
			if (kwdStats != null)
			{
				maxAmplitude = System.Math.Max(maxAmplitude, kwdStats.TotalSearch);
			}
		}
		if (maxAmplitude != 0.0)
		{
			shrink = globalMaxAmplitude / maxAmplitude;
		}
		return shrink;
	}

	public ICollection<IAsset> GetSortedAssets(ICollection<IAsset> assetsFromFirstSearchQueryResults, ICollection<IAsset> assetsFromSecondSearchQueryResults, int firstSearchQueryCount, int secondSearchQueryCount, IAssetSearchKeywordStatisticFactory assetSearchKeywordStatisticFactory, string keyword, int maxResults)
	{
		if (firstSearchQueryCount == 0)
		{
			return assetsFromSecondSearchQueryResults;
		}
		if (secondSearchQueryCount == 0)
		{
			return assetsFromFirstSearchQueryResults;
		}
		if (firstSearchQueryCount + secondSearchQueryCount == maxResults)
		{
			IEnumerable<IAsset> first = assetsFromFirstSearchQueryResults.Take(firstSearchQueryCount);
			IEnumerable<IAsset> assetsFromSecondSearchQueryResultsList = assetsFromSecondSearchQueryResults.Take(secondSearchQueryCount);
			return first.Union(assetsFromSecondSearchQueryResultsList, new AssetComparer()).ToList();
		}
		throw new PlatformArgumentException("firstSearchQueryCount" + firstSearchQueryCount + "secondSearchQueryCount" + secondSearchQueryCount + "GetSortedAssets");
	}
}
