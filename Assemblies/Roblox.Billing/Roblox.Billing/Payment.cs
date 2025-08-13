using System;
using System.Collections.Generic;
using Roblox.Billing.Business_Logic_Layer;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Billing;

public class Payment : IRobloxEntity<long, PaymentDAL>, ICacheableObject<long>, ICacheableObject, IPayment
{
	private PaymentDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "Payment", isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	public int SaleID
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

	public byte PaymentProviderTypeID
	{
		get
		{
			return _EntityDAL.PaymentProviderTypeID;
		}
		set
		{
			_EntityDAL.PaymentProviderTypeID = value;
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

	public decimal Amount
	{
		get
		{
			return _EntityDAL.Amount;
		}
		set
		{
			_EntityDAL.Amount = value;
		}
	}

	public byte? CurrencyTypeID
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

	public DateTime Created => _EntityDAL.Created;

	public DateTime Updated => _EntityDAL.Updated;

	public CacheInfo CacheInfo => EntityCacheInfo;

	public Payment()
	{
		_EntityDAL = new PaymentDAL();
	}

	private static Payment DoGet(long id)
	{
		return EntityHelper.DoGet<long, PaymentDAL, Payment>(() => PaymentDAL.Get(id), id);
	}

	public static Payment Get(long id)
	{
		return EntityHelper.GetEntityOld(EntityCacheInfo, id, () => DoGet(id));
	}

	private static ICollection<Payment> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.MultiGetEntity<long, PaymentDAL, Payment>(ids, EntityCacheInfo, PaymentDAL.MultiGet);
	}

	internal static ICollection<Payment> GetPaymentsBySaleIDPaged(int saleId, long startRowIndex, long maximumRows)
	{
		string collectionId = $"GetPaymentsBySaleIDPaged_SaleID:{saleId}_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy(GetLookupCacheKeysBySaleId(saleId)), collectionId, () => PaymentDAL.GetPaymentIDsBySaleIDPaged(saleId, startRowIndex + 1, maximumRows), MultiGet);
	}

	internal static ICollection<Payment> GetPaymentsBySaleIDPagedPaymentDateAsc(int saleId, long startRowIndex, long maximumRows)
	{
		string collectionId = $"GetPaymentsBySaleIDPagedPaymentDateAsc_SaleID:{saleId}_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy(GetLookupCacheKeysBySaleId(saleId)), collectionId, () => PaymentDAL.GetPaymentIDsBySaleIDPagedPaymentDateAsc(saleId, startRowIndex + 1, maximumRows), MultiGet);
	}

	internal static long GetTotalNumberOfPaymentsBySaleId(int saleId)
	{
		string countId = $"GetTotalNumberOfPaymentsBySaleId_SaleID:{saleId}";
		return EntityHelper.GetEntityCount(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy(GetLookupCacheKeysBySaleId(saleId)), countId, () => PaymentDAL.GetTotalNumberOfPaymentsBySaleID(saleId));
	}

	internal void Delete()
	{
		EntityHelper.DeleteEntity(this, _EntityDAL.Delete);
	}

	public static ICollection<Payment> GetPaymentsBySale(int saleId)
	{
		string collectionId = $"GetPaymentsBySale_SaleID:{saleId}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, GetLookupCacheKeysBySaleId(saleId)), collectionId, () => PaymentDAL.GetPaymentIDsBySaleID(saleId), Get);
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

	public static Payment CreateNew(int SaleID, byte PaymentProviderTypeID, byte PaymentStatusTypeID, DateTime PaymentDate, decimal Amount, byte? currencyTypeID = null)
	{
		if (!currencyTypeID.HasValue)
		{
			currencyTypeID = CurrencyType.GetUSDCurrencyTypeID;
		}
		Payment payment = new Payment();
		payment.SaleID = SaleID;
		payment.PaymentProviderTypeID = PaymentProviderTypeID;
		payment.PaymentStatusTypeID = PaymentStatusTypeID;
		payment.PaymentDate = PaymentDate;
		payment.Amount = Amount;
		payment.CurrencyTypeID = currencyTypeID;
		payment.Save();
		return payment;
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
		yield return new StateToken(GetLookupCacheKeysBySaleId(SaleID));
	}

	private static string GetLookupCacheKeysBySaleId(int saleId)
	{
		return $"SaleID:{saleId}";
	}
}
