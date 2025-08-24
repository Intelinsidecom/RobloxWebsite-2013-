using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Economy.Common;

public class TransactionType : IRobloxEntity<byte, TransactionTypeDAL>, ICacheableObject<byte>, ICacheableObject
{
	private TransactionTypeDAL _EntityDAL;

	public static readonly byte AdjustmentID;

	public static readonly string AdjustmentValue;

	public static readonly byte CreditID;

	public static readonly string CreditValue;

	public static readonly byte DebitID;

	public static readonly string DebitValue;

	public static CacheInfo EntityCacheInfo;

	public byte ID => _EntityDAL.ID;

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

	public DateTime Created => _EntityDAL.Created;

	public DateTime Updated => _EntityDAL.Updated;

	public CacheInfo CacheInfo => EntityCacheInfo;

	public TransactionType()
	{
		_EntityDAL = new TransactionTypeDAL();
	}

	static TransactionType()
	{
		AdjustmentValue = "Adjustment";
		CreditValue = "Credit";
		DebitValue = "Debit";
		EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "TransactionType", isNullCacheable: true);
		AdjustmentID = Get(AdjustmentValue).ID;
		CreditID = Get(CreditValue).ID;
		DebitID = Get(DebitValue).ID;
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
			_EntityDAL.Updated = Created;
			_EntityDAL.Insert();
		}, delegate
		{
			_EntityDAL.Updated = DateTime.Now;
			_EntityDAL.Update();
		});
	}

	private static TransactionType DoGet(byte id)
	{
		return EntityHelper.DoGet<byte, TransactionTypeDAL, TransactionType>(() => TransactionTypeDAL.Get(id), id);
	}

	private static TransactionType DoGet(string value)
	{
		return EntityHelper.DoGetByLookup<byte, TransactionTypeDAL, TransactionType>(() => TransactionTypeDAL.Get(value), value);
	}

	public static TransactionType Get(byte id)
	{
		return EntityHelper.GetEntityOld(EntityCacheInfo, id, () => DoGet(id));
	}

	public static TransactionType Get(byte? id)
	{
		if (id.HasValue)
		{
			return Get(id.Value);
		}
		return null;
	}

	public static TransactionType Get(string value)
	{
		return EntityHelper.GetEntityByLookupOld<byte, TransactionType>(EntityCacheInfo, value, () => DoGet(value));
	}

	public static ICollection<TransactionType> GetTransactionTypesPaged(int startRowIndex, int maximumRows)
	{
		string collectionId = $"GetTransactionTypesPaged_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.UnqualifiedNonExpiringCachePolicy, collectionId, () => TransactionTypeDAL.GetTransactionTypeIDsPaged(startRowIndex + 1, maximumRows), Get);
	}

	public static int GetTotalNumberOfTransactionTypes()
	{
		return EntityHelper.GetEntityCount(EntityCacheInfo, CacheManager.UnqualifiedNonExpiringCachePolicy, "GetTotalNumberOfTransactionTypes", TransactionTypeDAL.GetTotalNumberOfTransactionTypes);
	}

	public void Construct(TransactionTypeDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		if (_EntityDAL != null)
		{
			yield return Value;
		}
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
