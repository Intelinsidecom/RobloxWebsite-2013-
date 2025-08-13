using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using Roblox.Platform.Core;

namespace Roblox.Platform.Studio;

internal class AssetSearchKeywordStatistic : IAssetSearchKeywordStatistic
{
	private static readonly string _Jsonormat = "{{\"stats\": {0}}}";

	public long Id { get; }

	public long AssetId { get; }

	public string Json { get; }

	public AssetSearchKeywordStatistic(long assetId, long id, string json)
	{
		AssetId = assetId;
		Id = id;
		Json = json;
	}

	public IKeywordStatistic GetKeywordStatistics(string keyword)
	{
		try
		{
			List<JToken> kwdStatList = JObject.Parse(string.Format(_Jsonormat, Json))["stats"].Where((JToken o) => o["searchKwd"].ToString() == keyword).ToList();
			if (kwdStatList.Count == 0)
			{
				return null;
			}
			JToken jToken = kwdStatList[0];
			string totalSearchStr = jToken["returnedInSearches"].ToString();
			string totalInsertStr = jToken["insertsRemainsDistinct"].ToString();
			string wilsonScoreStr = jToken["wilsonScore"].ToString();
			if (!int.TryParse(totalSearchStr, out var totalSearch) || !int.TryParse(totalInsertStr, out var totalInsert) || !double.TryParse(wilsonScoreStr, out var wilsonScore))
			{
				return null;
			}
			return new KeywordStatistic
			{
				AssetId = AssetId,
				Keyword = keyword,
				TotalInsert = totalInsert,
				TotalSearch = totalSearch,
				WilsonScore = wilsonScore
			};
		}
		catch (Exception ex)
		{
			throw new PlatformException("Search keyword json is not in correct format.", ex.InnerException);
		}
	}

	public Dictionary<string, double> GetAllKeywordStatistics()
	{
		Dictionary<string, double> kwdWilsonScoreDictionary = new Dictionary<string, double>();
		try
		{
			JToken stats = JObject.Parse(string.Format(_Jsonormat, Json))["stats"];
			if (stats == null)
			{
				return kwdWilsonScoreDictionary;
			}
			foreach (JToken item in (IEnumerable<JToken>)stats)
			{
				string kwd = item["searchKwd"].ToString();
				if (double.TryParse(item["wilsonScore"].ToString(), out var wilsonScore))
				{
					kwdWilsonScoreDictionary.Add(kwd, wilsonScore);
				}
			}
			return kwdWilsonScoreDictionary;
		}
		catch (Exception ex)
		{
			throw new PlatformException("Search keyword json is not in correct format.", ex.InnerException);
		}
	}
}
