using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.CurrencyBudgets.Entities;

/// <summary>
/// Tracks the amount and transactions of a currency for a given holder.
/// </summary>
/// <seealso cref="T:Roblox.Platform.CurrencyBudgets.IPlatformCurrencyBudget" />
internal class CurrencyBudget : IRobloxEntity<long, CurrencyBudgetDAL>, ICacheableObject<long>, ICacheableObject, ICurrencyBudget
{
	private CurrencyBudgetDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: false, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(CurrencyBudget).ToString(), isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	public int CurrencyBudgetTypeID
	{
		get
		{
			return _EntityDAL.CurrencyBudgetTypeID;
		}
		set
		{
			_EntityDAL.CurrencyBudgetTypeID = value;
		}
	}

	public byte CurrencyTypeID
	{
		get
		{
			return _EntityDAL.CurrencyTypeID;
		}
		set
		{
			_EntityDAL.CurrencyTypeID = value;
		}
	}

	public int CurrencyHolderTypeID
	{
		get
		{
			return _EntityDAL.CurrencyHolderTypeID;
		}
		set
		{
			_EntityDAL.CurrencyHolderTypeID = value;
		}
	}

	public long CurrencyHolderTargetID
	{
		get
		{
			return _EntityDAL.CurrencyHolderTargetID;
		}
		set
		{
			_EntityDAL.CurrencyHolderTargetID = value;
		}
	}

	public long Value
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

	internal DateTime Updated
	{
		get
		{
			return _EntityDAL.Updated;
		}
		set
		{
			_EntityDAL.Updated = value;
		}
	}

	public CacheInfo CacheInfo => EntityCacheInfo;

	public CurrencyBudget()
	{
		_EntityDAL = new CurrencyBudgetDAL();
	}

	public void Delete()
	{
		EntityHelper.DeleteEntity(this, _EntityDAL.Delete);
	}

	public void Save()
	{
		EntityHelper.SaveEntity(this, delegate
		{
			_EntityDAL.Created = DateTime.Now;
			_EntityDAL.Updated = _EntityDAL.Created;
			_EntityDAL.Insert();
		}, delegate
		{
			_EntityDAL.Updated = DateTime.Now;
			_EntityDAL.Update();
		});
	}

	public void Credit(long amount)
	{
		if (amount >= 1)
		{
			_EntityDAL.Credit(amount);
			CacheManager.ProcessEntityChange(this, StateChangeEventType.Modification);
		}
	}

	public bool TryDebit(long amount)
	{
		if (amount < 0)
		{
			return false;
		}
		bool num = _EntityDAL.TryDebit(amount);
		if (num)
		{
			CacheManager.ProcessEntityChange(this, StateChangeEventType.Modification);
		}
		return num;
	}

	internal static CurrencyBudget Get(long id)
	{
		return EntityHelper.GetEntity<long, CurrencyBudgetDAL, CurrencyBudget>(EntityCacheInfo, id, () => CurrencyBudgetDAL.Get(id));
	}

	internal static ICollection<CurrencyBudget> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.MultiGetEntity<long, CurrencyBudgetDAL, CurrencyBudget>(ids, EntityCacheInfo, CurrencyBudgetDAL.MultiGet);
	}

	public static CurrencyBudget GetByCurrencyBudgetTypeIDCurrencyTypeIDCurrencyHolderTypeIDAndCurrencyHolderTargetID(int currencyBudgetTypeId, byte currencyTypeId, int currencyHolderTypeId, long currencyHolderTargetId)
	{
		return EntityHelper.GetEntityByLookup<long, CurrencyBudgetDAL, CurrencyBudget>(EntityCacheInfo, GetLookupCacheKeysByCurrencyBudgetTypeIDCurrencyTypeIDCurrencyHolderTypeIDCurrencyHolderTargetID(currencyBudgetTypeId, currencyTypeId, currencyHolderTypeId, currencyHolderTargetId), () => CurrencyBudgetDAL.GetCurrencyBudgetByCurrencyBudgetTypeIDCurrencyTypeIDCurrencyHolderTypeIDAndCurrencyHolderTargetID(currencyBudgetTypeId, currencyTypeId, currencyHolderTypeId, currencyHolderTargetId));
	}

	public static CurrencyBudget GetOrCreate(int currencyBudgetTypeId, byte currencyTypeId, int currencyHolderTypeId, long currencyHolderTargetId)
	{
		return EntityHelper.GetOrCreateEntity<long, CurrencyBudget>(EntityCacheInfo, GetLookupCacheKeysByCurrencyBudgetTypeIDCurrencyTypeIDCurrencyHolderTypeIDCurrencyHolderTargetID(currencyBudgetTypeId, currencyTypeId, currencyHolderTypeId, currencyHolderTargetId), () => DoGetOrCreate(currencyBudgetTypeId, currencyTypeId, currencyHolderTypeId, currencyHolderTargetId));
	}

	private static CurrencyBudget DoGetOrCreate(int currencyBudgetTypeID, byte currencyTypeId, int currencyHolderTypeId, long currencyHolderTargetId)
	{
		return EntityHelper.DoGetOrCreate<long, CurrencyBudgetDAL, CurrencyBudget>(() => CurrencyBudgetDAL.GetOrCreateCurrencyBudget(currencyBudgetTypeID, currencyTypeId, currencyHolderTypeId, currencyHolderTargetId));
	}

	public void Construct(CurrencyBudgetDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return GetLookupCacheKeysByCurrencyBudgetTypeIDCurrencyTypeIDCurrencyHolderTypeIDCurrencyHolderTargetID(CurrencyBudgetTypeID, CurrencyTypeID, CurrencyHolderTypeID, CurrencyHolderTargetID);
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}

	private static string GetLookupCacheKeysByCurrencyBudgetTypeIDCurrencyTypeIDCurrencyHolderTypeIDCurrencyHolderTargetID(int currencyBudgetTypeId, byte currencyTypeId, int currencyHolderTypeId, long currencyHolderTargetId)
	{
		return $"CurrencyBudgetTypeID:{currencyBudgetTypeId}_CurrencyTypeID:{currencyTypeId}_CurrencyHolderTypeID:{currencyHolderTypeId}_CurrencyHolderTargetID:{currencyHolderTargetId}";
	}
}
