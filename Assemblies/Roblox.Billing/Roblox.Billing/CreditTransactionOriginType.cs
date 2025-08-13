using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Billing;

public class CreditTransactionOriginType : IRobloxEntity<int, CreditTransactionOriginTypeDAL>, ICacheableObject<int>, ICacheableObject
{
	private CreditTransactionOriginTypeDAL _EntityDAL;

	public static readonly int SaleOfGoodsID;

	public static readonly string SaleOfGoodsValue;

	public static readonly int InCommID;

	public static readonly string IncommValue;

	public static readonly int MiscellaneousAdjustmentID;

	public static readonly string MiscellaneousAdjustmentValue;

	public static readonly int RixtyPinID;

	public static readonly string RixtyPinValue;

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

	public CreditTransactionOriginType()
	{
		_EntityDAL = new CreditTransactionOriginTypeDAL();
	}

	static CreditTransactionOriginType()
	{
		SaleOfGoodsValue = "Sale Of Goods";
		IncommValue = "InComm";
		MiscellaneousAdjustmentValue = "Miscellaneous Adjustment";
		RixtyPinValue = "RixtyPin";
		EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "Roblox.Billing.CreditTransactionOriginType", isNullCacheable: true);
		SaleOfGoodsID = Get(SaleOfGoodsValue).ID;
		InCommID = Get(IncommValue).ID;
		MiscellaneousAdjustmentID = Get(MiscellaneousAdjustmentValue).ID;
		RixtyPinID = Get(RixtyPinValue).ID;
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

	public static CreditTransactionOriginType CreateNew(string value)
	{
		CreditTransactionOriginType creditTransactionOriginType = new CreditTransactionOriginType();
		creditTransactionOriginType.Value = value;
		creditTransactionOriginType.Save();
		return creditTransactionOriginType;
	}

	public static CreditTransactionOriginType Get(int id)
	{
		return EntityHelper.GetEntity<int, CreditTransactionOriginTypeDAL, CreditTransactionOriginType>(EntityCacheInfo, id, () => CreditTransactionOriginTypeDAL.Get(id));
	}

	public static CreditTransactionOriginType Get(string value)
	{
		return EntityHelper.GetEntityByLookup<int, CreditTransactionOriginTypeDAL, CreditTransactionOriginType>(EntityCacheInfo, $"Value:{value}", () => CreditTransactionOriginTypeDAL.GetByValue(value));
	}

	public void Construct(CreditTransactionOriginTypeDAL dal)
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
