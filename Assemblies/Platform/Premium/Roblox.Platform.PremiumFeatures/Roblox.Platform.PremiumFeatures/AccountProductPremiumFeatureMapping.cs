using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.PremiumFeatures;

public class AccountProductPremiumFeatureMapping : IRobloxEntity<int, AccountProductPremiumFeatureMappingDAL>, ICacheableObject<int>, ICacheableObject
{
	private AccountProductPremiumFeatureMappingDAL _EntityDAL;

	internal static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "AccountProductPremiumFeatureMapping", isNullCacheable: true);

	public int ID => _EntityDAL.ID;

	internal int AccountProductID
	{
		get
		{
			return _EntityDAL.AccountProductID;
		}
		set
		{
			_EntityDAL.AccountProductID = value;
		}
	}

	internal int PremiumFeatureID
	{
		get
		{
			return _EntityDAL.PremiumFeatureID;
		}
		set
		{
			_EntityDAL.PremiumFeatureID = value;
		}
	}

	internal DateTime Created => _EntityDAL.Created;

	internal DateTime Updated => _EntityDAL.Updated;

	public CacheInfo CacheInfo => EntityCacheInfo;

	public AccountProductPremiumFeatureMapping()
	{
		_EntityDAL = new AccountProductPremiumFeatureMappingDAL();
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
			_EntityDAL.Updated = Created;
			_EntityDAL.Insert();
		}, delegate
		{
			_EntityDAL.Updated = DateTime.Now;
			_EntityDAL.Update();
		});
	}

	internal static AccountProductPremiumFeatureMapping Get(int id)
	{
		return EntityHelper.GetEntity<int, AccountProductPremiumFeatureMappingDAL, AccountProductPremiumFeatureMapping>(EntityCacheInfo, id, () => AccountProductPremiumFeatureMappingDAL.Get(id));
	}

	internal static AccountProductPremiumFeatureMapping Get(int? id)
	{
		if (id.HasValue)
		{
			return Get(id.Value);
		}
		return null;
	}

	public static ICollection<int> GetAllIDs()
	{
		return AccountProductPremiumFeatureMappingDAL.GetAllIDs();
	}

	public void Construct(AccountProductPremiumFeatureMappingDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"AccountProductID:{AccountProductID}";
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}

	public static Dictionary<int, int> GetAccountProductPremiumFeatureMappingsFromDB()
	{
		Dictionary<int, int> mappings = new Dictionary<int, int>();
		foreach (int item in (List<int>)GetAllIDs())
		{
			AccountProductPremiumFeatureMapping ap = Get(item);
			mappings.Add(ap.AccountProductID, ap.PremiumFeatureID);
		}
		return mappings;
	}
}
