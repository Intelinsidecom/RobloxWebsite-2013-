using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.PremiumFeatures;

public class GrantedAssetList : IRobloxEntity<int, GrantedAssetListDAL>, ICacheableObject<int>, ICacheableObject
{
	private GrantedAssetListDAL _EntityDAL;

	public const string NoneValue = "None";

	public static readonly int NoneID;

	internal static CacheInfo EntityCacheInfo;

	public int ID => _EntityDAL.ID;

	public string Value
	{
		get
		{
			return _EntityDAL.Value;
		}
		set
		{
			_EntityDAL.Value = value;
		}
	}

	internal DateTime Created => _EntityDAL.Created;

	internal DateTime Updated => _EntityDAL.Updated;

	public CacheInfo CacheInfo => EntityCacheInfo;

	public GrantedAssetList()
	{
		_EntityDAL = new GrantedAssetListDAL();
	}

	static GrantedAssetList()
	{
		NoneID = 0;
		EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "GrantedAssetList", isNullCacheable: true);
		NoneID = GetByValue("None").ID;
	}

	internal void Delete()
	{
		EntityHelper.DeleteEntity(this, _EntityDAL.Delete);
	}

	public void Save()
	{
		EntityHelper.SaveEntity(this, delegate
		{
			_EntityDAL.Created = DateTime.Now;
			_EntityDAL.Updated = Created;
			_EntityDAL.Insert();
		}, delegate
		{
			_EntityDAL.Updated = DateTime.Now;
			_EntityDAL.Update();
		});
	}

	public static GrantedAssetList Get(int id)
	{
		return EntityHelper.GetEntity<int, GrantedAssetListDAL, GrantedAssetList>(EntityCacheInfo, id, () => GrantedAssetListDAL.Get(id));
	}

	internal static GrantedAssetList Get(int? id)
	{
		if (id.HasValue)
		{
			return Get(id.Value);
		}
		return null;
	}

	public static GrantedAssetList GetByValue(string value)
	{
		return EntityHelper.GetEntityByLookup<int, GrantedAssetListDAL, GrantedAssetList>(EntityCacheInfo, $"Value:{value}", () => GrantedAssetListDAL.GetByValue(value));
	}

	public void Construct(GrantedAssetListDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		if (_EntityDAL != null)
		{
			yield return $"Value:{Value}";
		}
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
