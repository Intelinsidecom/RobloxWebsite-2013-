using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Billing.Entities;

internal class WindowsStorePayment : IRobloxEntity<long, WindowsStorePaymentDAL>, ICacheableObject<long>, ICacheableObject
{
	private WindowsStorePaymentDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: false, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(WindowsStorePayment).ToString(), isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	internal long PaymentID
	{
		get
		{
			return _EntityDAL.PaymentID;
		}
		set
		{
			_EntityDAL.PaymentID = value;
		}
	}

	internal DateTime PurchaseDate
	{
		get
		{
			return _EntityDAL.PurchaseDate;
		}
		set
		{
			_EntityDAL.PurchaseDate = value;
		}
	}

	internal string TransactionID
	{
		get
		{
			return _EntityDAL.TransactionID;
		}
		set
		{
			_EntityDAL.TransactionID = value;
		}
	}

	internal string Receipt
	{
		get
		{
			return _EntityDAL.Receipt;
		}
		set
		{
			_EntityDAL.Receipt = value;
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

	public WindowsStorePayment()
	{
		_EntityDAL = new WindowsStorePaymentDAL();
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
			_EntityDAL.Updated = _EntityDAL.Created;
			_EntityDAL.Insert();
		}, delegate
		{
			_EntityDAL.Updated = DateTime.Now;
			_EntityDAL.Update();
		});
	}

	internal static WindowsStorePayment Get(long id)
	{
		return EntityHelper.GetEntity<long, WindowsStorePaymentDAL, WindowsStorePayment>(EntityCacheInfo, id, () => WindowsStorePaymentDAL.Get(id));
	}

	private static ICollection<WindowsStorePayment> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.MultiGetEntity<long, WindowsStorePaymentDAL, WindowsStorePayment>(ids, EntityCacheInfo, WindowsStorePaymentDAL.MultiGet);
	}

	public static WindowsStorePayment GetByPaymentID(long paymentID)
	{
		return EntityHelper.GetEntityByLookup<long, WindowsStorePaymentDAL, WindowsStorePayment>(EntityCacheInfo, GetLookupCacheKeysByPaymentID(paymentID), () => WindowsStorePaymentDAL.GetWindowsStorePaymentByPaymentID(paymentID));
	}

	public static WindowsStorePayment GetByTransactionID(string transactionID)
	{
		return EntityHelper.GetEntityByLookup<long, WindowsStorePaymentDAL, WindowsStorePayment>(EntityCacheInfo, GetLookupCacheKeysByTransactionID(transactionID), () => WindowsStorePaymentDAL.GetWindowsStorePaymentByTransactionID(transactionID));
	}

	public void Construct(WindowsStorePaymentDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return GetLookupCacheKeysByPaymentID(PaymentID);
		yield return GetLookupCacheKeysByTransactionID(TransactionID);
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}

	private static string GetLookupCacheKeysByPaymentID(long paymentID)
	{
		return $"PaymentID:{paymentID}";
	}

	private static string GetLookupCacheKeysByTransactionID(string transactionID)
	{
		return $"TransactionID:{transactionID}";
	}
}
