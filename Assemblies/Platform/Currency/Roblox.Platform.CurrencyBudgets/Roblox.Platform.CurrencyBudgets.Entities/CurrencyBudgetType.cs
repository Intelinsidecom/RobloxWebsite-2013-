using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.CurrencyBudgets.Entities;

internal class CurrencyBudgetType : IRobloxEntity<int, CurrencyBudgetTypeDAL>, ICacheableObject<int>, ICacheableObject
{
	private CurrencyBudgetTypeDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: false, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(CurrencyBudgetType).ToString(), isNullCacheable: true);

	public int ID => _EntityDAL.ID;

	internal string Value
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

	public CurrencyBudgetType()
	{
		_EntityDAL = new CurrencyBudgetTypeDAL();
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
			_EntityDAL.Update();
		});
	}

	internal static CurrencyBudgetType Get(int id)
	{
		return EntityHelper.GetEntity<int, CurrencyBudgetTypeDAL, CurrencyBudgetType>(EntityCacheInfo, id, () => CurrencyBudgetTypeDAL.Get(id));
	}

	internal static ICollection<CurrencyBudgetType> MultiGet(ICollection<int> ids)
	{
		return EntityHelper.MultiGetEntity<int, CurrencyBudgetTypeDAL, CurrencyBudgetType>(ids, EntityCacheInfo, CurrencyBudgetTypeDAL.MultiGet);
	}

	public static CurrencyBudgetType GetByValue(string value)
	{
		return EntityHelper.GetEntityByLookup<int, CurrencyBudgetTypeDAL, CurrencyBudgetType>(EntityCacheInfo, GetLookupCacheKeysByValue(value), () => CurrencyBudgetTypeDAL.GetCurrencyBudgetTypeByValue(value));
	}

	public static CurrencyBudgetType GetOrCreate(string value)
	{
		return EntityHelper.GetOrCreateEntity<int, CurrencyBudgetType>(EntityCacheInfo, GetLookupCacheKeysByValue(value), () => DoGetOrCreate(value));
	}

	private static CurrencyBudgetType DoGetOrCreate(string value)
	{
		return EntityHelper.DoGetOrCreate<int, CurrencyBudgetTypeDAL, CurrencyBudgetType>(() => CurrencyBudgetTypeDAL.GetOrCreateCurrencyBudgetType(value));
	}

	public void Construct(CurrencyBudgetTypeDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return GetLookupCacheKeysByValue(Value);
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}

	private static string GetLookupCacheKeysByValue(string value)
	{
		return $"Value:{value}";
	}
}
