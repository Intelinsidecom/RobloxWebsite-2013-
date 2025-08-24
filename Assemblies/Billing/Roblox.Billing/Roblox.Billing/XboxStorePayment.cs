using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Billing;

public class XboxStorePayment : IRobloxEntity<int, XboxStorePaymentDAL>, ICacheableObject<int>, ICacheableObject
{
	private XboxStorePaymentDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(XboxStorePayment).ToString(), isNullCacheable: true);

	public int ID => _EntityDAL.ID;

	public long PaymentID
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

	public string XboxStoreProductID
	{
		get
		{
			return _EntityDAL.XboxStoreProductID;
		}
		set
		{
			_EntityDAL.XboxStoreProductID = value;
		}
	}

	public string XboxStoreTransactionID
	{
		get
		{
			return _EntityDAL.XboxStoreTransactionID;
		}
		set
		{
			_EntityDAL.XboxStoreTransactionID = value;
		}
	}

	public string XboxStoreTitleID
	{
		get
		{
			return _EntityDAL.XboxStoreTitleID;
		}
		set
		{
			_EntityDAL.XboxStoreTitleID = value;
		}
	}

	public string XboxStoreSandboxID
	{
		get
		{
			return _EntityDAL.XboxStoreSandboxID;
		}
		set
		{
			_EntityDAL.XboxStoreSandboxID = value;
		}
	}

	internal DateTime PurchaseTime
	{
		get
		{
			return _EntityDAL.PurchaseTime;
		}
		set
		{
			_EntityDAL.PurchaseTime = value;
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

	public XboxStorePayment()
	{
		_EntityDAL = new XboxStorePaymentDAL();
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

	internal static XboxStorePayment Get(int id)
	{
		return EntityHelper.GetEntity<int, XboxStorePaymentDAL, XboxStorePayment>(EntityCacheInfo, id, () => XboxStorePaymentDAL.Get(id));
	}

	internal static ICollection<XboxStorePayment> MultiGet(ICollection<int> ids)
	{
		return EntityHelper.MultiGetEntity<int, XboxStorePaymentDAL, XboxStorePayment>(ids, EntityCacheInfo, XboxStorePaymentDAL.MultiGet);
	}

	public static XboxStorePayment GetByPaymentID(long paymentID)
	{
		return EntityHelper.GetEntityByLookup<int, XboxStorePaymentDAL, XboxStorePayment>(EntityCacheInfo, $"PaymentID:{paymentID}", () => XboxStorePaymentDAL.GetXboxStorePaymentByPaymentID(paymentID));
	}

	public static XboxStorePayment GetByXboxStoreTransactionID(string xboxStoreTransactionID)
	{
		return EntityHelper.GetEntityByLookup<int, XboxStorePaymentDAL, XboxStorePayment>(EntityCacheInfo, $"XboxStoreTransactionID:{xboxStoreTransactionID}", () => XboxStorePaymentDAL.GetXboxStorePaymentByXboxStoreTransactionID(xboxStoreTransactionID));
	}

	public void Construct(XboxStorePaymentDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"PaymentID:{PaymentID}";
		yield return $"XboxStoreTransactionID:{XboxStoreTransactionID}";
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
