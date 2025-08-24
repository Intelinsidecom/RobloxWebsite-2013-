using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Billing;

public class CreditTransactionType : IRobloxEntity<int, CreditTransactionTypeDAL>, ICacheableObject<int>, ICacheableObject
{
	private CreditTransactionTypeDAL _EntityDAL;

	public static readonly int CreditID;

	public static readonly string CreditValue;

	public static readonly int DebitID;

	public static readonly string DebitValue;

	public static readonly int AdjustmentID;

	public static readonly string AdjustmentValue;

	public static CacheInfo EntityCacheInfo;

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

	public DateTime Created
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

	public DateTime Updated
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

	public CreditTransactionType()
	{
		_EntityDAL = new CreditTransactionTypeDAL();
	}

	static CreditTransactionType()
	{
		CreditValue = "Credit";
		DebitValue = "Debit";
		AdjustmentValue = "Adjustment";
		EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "Roblox.Billing.CreditTransactionType", isNullCacheable: true);
		CreditID = Get(CreditValue).ID;
		DebitID = Get(DebitValue).ID;
		AdjustmentID = Get(AdjustmentValue).ID;
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

	public static CreditTransactionType CreateNew(string value)
	{
		CreditTransactionType creditTransactionType = new CreditTransactionType();
		creditTransactionType.Value = value;
		creditTransactionType.Save();
		return creditTransactionType;
	}

	public static CreditTransactionType Get(int id)
	{
		return EntityHelper.GetEntity<int, CreditTransactionTypeDAL, CreditTransactionType>(EntityCacheInfo, id, () => CreditTransactionTypeDAL.Get(id));
	}

	public static CreditTransactionType Get(string value)
	{
		return EntityHelper.GetEntityByLookup<int, CreditTransactionTypeDAL, CreditTransactionType>(EntityCacheInfo, $"Value:{value}", () => CreditTransactionTypeDAL.GetByValue(value));
	}

	public void Construct(CreditTransactionTypeDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"Value:{Value}";
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
