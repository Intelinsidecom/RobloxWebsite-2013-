using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.CurrencyBudgets.Entities;

internal class CurrencyBudgetTransactionType : IRobloxEntity<int, CurrencyBudgetTransactionTypeDAL>, ICacheableObject<int>, ICacheableObject
{
	private CurrencyBudgetTransactionTypeDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: false, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(CurrencyBudgetTransactionType).ToString(), isNullCacheable: true);

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

	public CurrencyBudgetTransactionType()
	{
		_EntityDAL = new CurrencyBudgetTransactionTypeDAL();
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

	internal static CurrencyBudgetTransactionType Get(int id)
	{
		return EntityHelper.GetEntity<int, CurrencyBudgetTransactionTypeDAL, CurrencyBudgetTransactionType>(EntityCacheInfo, id, () => CurrencyBudgetTransactionTypeDAL.Get(id));
	}

	internal static ICollection<CurrencyBudgetTransactionType> MultiGet(ICollection<int> ids)
	{
		return EntityHelper.MultiGetEntity<int, CurrencyBudgetTransactionTypeDAL, CurrencyBudgetTransactionType>(ids, EntityCacheInfo, CurrencyBudgetTransactionTypeDAL.MultiGet);
	}

	public static CurrencyBudgetTransactionType GetByValue(string value)
	{
		return EntityHelper.GetEntityByLookup<int, CurrencyBudgetTransactionTypeDAL, CurrencyBudgetTransactionType>(EntityCacheInfo, GetLookupCacheKeysByValue(value), () => CurrencyBudgetTransactionTypeDAL.GetCurrencyBudgetTransactionTypeByValue(value));
	}

	public static CurrencyBudgetTransactionType GetOrCreate(string value)
	{
		return EntityHelper.GetOrCreateEntity<int, CurrencyBudgetTransactionType>(EntityCacheInfo, GetLookupCacheKeysByValue(value), () => DoGetOrCreate(value));
	}

	private static CurrencyBudgetTransactionType DoGetOrCreate(string value)
	{
		return EntityHelper.DoGetOrCreate<int, CurrencyBudgetTransactionTypeDAL, CurrencyBudgetTransactionType>(() => CurrencyBudgetTransactionTypeDAL.GetOrCreateCurrencyBudgetTransactionType(value));
	}

	public void Construct(CurrencyBudgetTransactionTypeDAL dal)
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
