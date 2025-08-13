using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.CurrencyBudgets.Entities;

internal class CurrencyHolderType : IRobloxEntity<int, CurrencyHolderTypeDAL>, ICacheableObject<int>, ICacheableObject
{
	private CurrencyHolderTypeDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: false, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(CurrencyHolderType).ToString(), isNullCacheable: true);

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

	public CurrencyHolderType()
	{
		_EntityDAL = new CurrencyHolderTypeDAL();
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

	internal static CurrencyHolderType Get(int id)
	{
		return EntityHelper.GetEntity<int, CurrencyHolderTypeDAL, CurrencyHolderType>(EntityCacheInfo, id, () => CurrencyHolderTypeDAL.Get(id));
	}

	internal static ICollection<CurrencyHolderType> MultiGet(ICollection<int> ids)
	{
		return EntityHelper.MultiGetEntity<int, CurrencyHolderTypeDAL, CurrencyHolderType>(ids, EntityCacheInfo, CurrencyHolderTypeDAL.MultiGet);
	}

	public static CurrencyHolderType GetByValue(string value)
	{
		return EntityHelper.GetEntityByLookup<int, CurrencyHolderTypeDAL, CurrencyHolderType>(EntityCacheInfo, GetLookupCacheKeysByValue(value), () => CurrencyHolderTypeDAL.GetCurrencyHolderTypeByValue(value));
	}

	public static CurrencyHolderType GetOrCreate(string value)
	{
		return EntityHelper.GetOrCreateEntity<int, CurrencyHolderType>(EntityCacheInfo, GetLookupCacheKeysByValue(value), () => DoGetOrCreate(value));
	}

	private static CurrencyHolderType DoGetOrCreate(string value)
	{
		return EntityHelper.DoGetOrCreate<int, CurrencyHolderTypeDAL, CurrencyHolderType>(() => CurrencyHolderTypeDAL.GetOrCreateCurrencyHolderType(value));
	}

	public void Construct(CurrencyHolderTypeDAL dal)
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
