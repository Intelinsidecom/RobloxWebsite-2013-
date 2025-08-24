using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.Studio.Entities;

internal class ToolboxSearchAlgorithmResult : IRobloxEntity<long, ToolboxSearchAlgorithmResultDAL>, ICacheableObject<long>, ICacheableObject
{
	private ToolboxSearchAlgorithmResultDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(ToolboxSearchAlgorithmResult).ToString(), isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	internal int AlgorithmID
	{
		get
		{
			return _EntityDAL.AlgorithmID;
		}
		set
		{
			_EntityDAL.AlgorithmID = value;
		}
	}

	internal string Keyword
	{
		get
		{
			return _EntityDAL.Keyword;
		}
		set
		{
			_EntityDAL.Keyword = value;
		}
	}

	internal long[] Results
	{
		get
		{
			return _EntityDAL.Results;
		}
		set
		{
			_EntityDAL.Results = value;
		}
	}

	internal DateTime Created
	{
		get
		{
			return _EntityDAL.Created;
		}
		set
		{
			_EntityDAL.Created = value;
		}
	}

	public CacheInfo CacheInfo => EntityCacheInfo;

	public ToolboxSearchAlgorithmResult()
	{
		_EntityDAL = new ToolboxSearchAlgorithmResultDAL();
	}

	internal void Delete()
	{
		EntityHelper.DeleteEntity(this, _EntityDAL.Delete);
	}

	internal void Save()
	{
		EntityHelper.SaveEntity(this, delegate
		{
			_EntityDAL.Created = DateTime.Now;
			_EntityDAL.Insert();
		}, delegate
		{
			_EntityDAL.Created = DateTime.Now;
			_EntityDAL.Insert();
		});
	}

	internal static ToolboxSearchAlgorithmResult Get(long id)
	{
		return EntityHelper.GetEntity<long, ToolboxSearchAlgorithmResultDAL, ToolboxSearchAlgorithmResult>(EntityCacheInfo, id, () => ToolboxSearchAlgorithmResultDAL.Get(id));
	}

	private static ICollection<ToolboxSearchAlgorithmResult> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.MultiGetEntity<long, ToolboxSearchAlgorithmResultDAL, ToolboxSearchAlgorithmResult>(ids, EntityCacheInfo, ToolboxSearchAlgorithmResultDAL.MultiGet);
	}

	public static ToolboxSearchAlgorithmResult GetByAlgorithmIDAndKeyword(int algorithmID, string keyword)
	{
		return EntityHelper.GetEntityByLookup<long, ToolboxSearchAlgorithmResultDAL, ToolboxSearchAlgorithmResult>(EntityCacheInfo, GetLookupCacheKeysByAlgorithmIDKeyword(algorithmID, keyword), () => ToolboxSearchAlgorithmResultDAL.GetAlgorithmResultByAlgorithmIDAndKeyword(algorithmID, keyword));
	}

	public void Construct(ToolboxSearchAlgorithmResultDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return GetLookupCacheKeysByAlgorithmIDKeyword(AlgorithmID, Keyword);
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}

	private static string GetLookupCacheKeysByAlgorithmIDKeyword(int algorithmID, string keyword)
	{
		return $"AlgorithmID:{algorithmID}_Keyword:{keyword}";
	}
}
