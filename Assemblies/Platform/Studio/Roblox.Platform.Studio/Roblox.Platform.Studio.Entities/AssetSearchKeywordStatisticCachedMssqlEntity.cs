using System;
using Roblox.Entities;

namespace Roblox.Platform.Studio.Entities;

internal class AssetSearchKeywordStatisticCachedMssqlEntity : IAssetSearchKeywordStatisticEntity, IUpdateableEntity<long>, IEntity<long>
{
	public long Id { get; set; }

	public long AssetId { get; set; }

	public string Value { get; set; }

	public DateTime Created { get; set; }

	public DateTime Updated { get; set; }

	public void Update()
	{
		AssetSearchKeywordStatistic cal = AssetSearchKeywordStatistic.Get(Id);
		if (cal == null)
		{
			throw new InvalidOperationException("Attempted update on unpersisted entity.");
		}
		cal.AssetID = AssetId;
		cal.Value = Value;
		cal.Save();
		Updated = cal.Updated;
	}

	public void Delete()
	{
		(AssetSearchKeywordStatistic.Get(Id) ?? throw new InvalidOperationException("Attempted delete on unpersisted entity.")).Delete();
	}
}
