using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Economy;

public class Payment : IRobloxEntity<long, PaymentDAL>, ICacheableObject<long>, ICacheableObject
{
	private PaymentDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), typeof(Payment).ToString(), isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	public long SaleID
	{
		get
		{
			return _EntityDAL.SaleID;
		}
		set
		{
			_EntityDAL.SaleID = value;
		}
	}

	public long UnitPrice
	{
		get
		{
			return _EntityDAL.UnitPrice;
		}
		set
		{
			_EntityDAL.UnitPrice = value;
		}
	}

	public int CurrencyTypeID
	{
		get
		{
			return (byte)_EntityDAL.CurrencyTypeID;
		}
		set
		{
			_EntityDAL.CurrencyTypeID = value;
		}
	}

	public byte PaymentStatusTypeID
	{
		get
		{
			return _EntityDAL.PaymentStatusTypeID;
		}
		set
		{
			_EntityDAL.PaymentStatusTypeID = value;
		}
	}

	public DateTime PaymentDate
	{
		get
		{
			return _EntityDAL.PaymentDate;
		}
		set
		{
			_EntityDAL.PaymentDate = value;
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

	public Payment()
	{
		_EntityDAL = new PaymentDAL();
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
			_EntityDAL.Updated = _EntityDAL.Created;
			_EntityDAL.Insert();
		}, delegate
		{
			_EntityDAL.Updated = DateTime.Now;
			_EntityDAL.Update();
		});
	}

	public static Payment CreateNew(long saleId, long unitPrice, byte currencyTypeId, PaymentStatusType paymentStatusType, DateTime paymentDate)
	{
		Payment payment = new Payment();
		payment.SaleID = saleId;
		payment.UnitPrice = unitPrice;
		payment.CurrencyTypeID = currencyTypeId;
		payment.PaymentStatusTypeID = paymentStatusType.ID;
		payment.PaymentDate = paymentDate;
		payment.Save();
		return payment;
	}

	public static Payment Get(long id)
	{
		return EntityHelper.GetEntity<long, PaymentDAL, Payment>(EntityCacheInfo, id, () => PaymentDAL.Get(id));
	}

	public static ICollection<Payment> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.MultiGetEntity<long, PaymentDAL, Payment>(ids, EntityCacheInfo, PaymentDAL.MultiGet);
	}

	public static ICollection<Payment> GetPaymentsBySaleIDPaged(long saleID, long startRowIndex, long maximumRows)
	{
		string collectionId = $"GetPaymentsBySaleIDPaged_SaleID:{saleID}_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy($"SaleID:{saleID}"), collectionId, () => PaymentDAL.GetPaymentIDsBySaleIDPaged(saleID, startRowIndex + 1, maximumRows), MultiGet);
	}

	public static long GetTotalNumberOfPaymentsBySaleId(long saleID)
	{
		string countId = $"GetTotalNumberOfPaymentsBySaleId_SaleID:{saleID}";
		return EntityHelper.GetEntityCount(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy($"SaleID:{saleID}"), countId, () => PaymentDAL.GetTotalNumberOfPaymentsBySaleID(saleID));
	}

	public void Construct(PaymentDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield break;
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken($"SaleID:{SaleID}");
	}
}
