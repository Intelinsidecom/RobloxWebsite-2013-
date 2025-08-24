using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.CurrencyBudgets.Entities;

internal class CurrencyBudgetTransaction : IRobloxEntity<long, CurrencyBudgetTransactionDAL>, ICacheableObject<long>, ICacheableObject
{
	private CurrencyBudgetTransactionDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(CurrencyBudgetTransaction).ToString(), isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	internal long CurrencyBudgetID
	{
		get
		{
			return _EntityDAL.CurrencyBudgetID;
		}
		set
		{
			_EntityDAL.CurrencyBudgetID = value;
		}
	}

	internal long Delta
	{
		get
		{
			return _EntityDAL.Delta;
		}
		set
		{
			_EntityDAL.Delta = value;
		}
	}

	internal int CurrencyBudgetTransactionTypeID
	{
		get
		{
			return _EntityDAL.CurrencyBudgetTransactionTypeID;
		}
		set
		{
			_EntityDAL.CurrencyBudgetTransactionTypeID = value;
		}
	}

	internal long CurrencyBudgetTransactionTargetID
	{
		get
		{
			return _EntityDAL.CurrencyBudgetTransactionTargetID;
		}
		set
		{
			_EntityDAL.CurrencyBudgetTransactionTargetID = value;
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

	public CurrencyBudgetTransaction()
	{
		_EntityDAL = new CurrencyBudgetTransactionDAL();
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

	internal static CurrencyBudgetTransaction CreateNew(long currencyBudgetId, long delta, int currencyBudgetTransactionTypeId, long currencyBudgetTransactionTargetId)
	{
		CurrencyBudgetTransaction currencyBudgetTransaction = new CurrencyBudgetTransaction();
		currencyBudgetTransaction.CurrencyBudgetID = currencyBudgetId;
		currencyBudgetTransaction.Delta = delta;
		currencyBudgetTransaction.CurrencyBudgetTransactionTypeID = currencyBudgetTransactionTypeId;
		currencyBudgetTransaction.CurrencyBudgetTransactionTargetID = currencyBudgetTransactionTargetId;
		currencyBudgetTransaction.Save();
		return currencyBudgetTransaction;
	}

	internal static CurrencyBudgetTransaction Get(long id)
	{
		return EntityHelper.GetEntity<long, CurrencyBudgetTransactionDAL, CurrencyBudgetTransaction>(EntityCacheInfo, id, () => CurrencyBudgetTransactionDAL.Get(id));
	}

	internal static ICollection<CurrencyBudgetTransaction> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.MultiGetEntity<long, CurrencyBudgetTransactionDAL, CurrencyBudgetTransaction>(ids, EntityCacheInfo, CurrencyBudgetTransactionDAL.MultiGet);
	}

	internal static ICollection<CurrencyBudgetTransaction> GetCurrencyBudgetTransactionsByCurrencyBudgetIDPaged(long currencyBudgetId, long startRowIndex, long maximumRows)
	{
		string collectionId = $"GetCurrencyBudgetTransactionsByCurrencyBudgetIDPaged_CurrencyBudgetID:{currencyBudgetId}_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy(GetLookupCacheKeysByCurrencyBudgetID(currencyBudgetId)), collectionId, () => CurrencyBudgetTransactionDAL.GetCurrencyBudgetTransactionIDsByCurrencyBudgetIDPaged(currencyBudgetId, startRowIndex + 1, maximumRows), MultiGet);
	}

	internal static long GetTotalNumberOfCurrencyBudgetTransactionsByCurrencyBudgetId(long currencyBudgetId)
	{
		string countId = $"GetTotalNumberOfCurrencyBudgetTransactionsByCurrencyBudgetId_CurrencyBudgetID:{currencyBudgetId}";
		return EntityHelper.GetEntityCount(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy(GetLookupCacheKeysByCurrencyBudgetID(currencyBudgetId)), countId, () => CurrencyBudgetTransactionDAL.GetTotalNumberOfCurrencyBudgetTransactionsByCurrencyBudgetID(currencyBudgetId));
	}

	public void Construct(CurrencyBudgetTransactionDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return GetLookupCacheKeysByCurrencyBudgetTransactionTypeIDCurrencyBudgetTransactionTargetID(CurrencyBudgetTransactionTypeID, CurrencyBudgetTransactionTargetID);
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken(GetLookupCacheKeysByCurrencyBudgetID(CurrencyBudgetID));
	}

	private static string GetLookupCacheKeysByCurrencyBudgetTransactionTypeIDCurrencyBudgetTransactionTargetID(int currencyBudgetTransactionTypeID, long currencyBudgetTransactionTargetID)
	{
		return $"CurrencyBudgetTransactionTypeID:{currencyBudgetTransactionTypeID}_CurrencyBudgetTransactionTargetID:{currencyBudgetTransactionTargetID}";
	}

	private static string GetLookupCacheKeysByCurrencyBudgetID(long currencyBudgetID)
	{
		return $"CurrencyBudgetID:{currencyBudgetID}";
	}
}
