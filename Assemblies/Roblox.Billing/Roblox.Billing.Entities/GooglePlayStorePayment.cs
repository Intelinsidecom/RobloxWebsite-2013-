using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Billing.Entities;

public class GooglePlayStorePayment : IRobloxEntity<int, GooglePlayStorePaymentDAL>, ICacheableObject<int>, ICacheableObject
{
	private GooglePlayStorePaymentDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), typeof(GooglePlayStorePayment).ToString(), isNullCacheable: true);

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

	public string PackageName
	{
		get
		{
			return _EntityDAL.PackageName;
		}
		set
		{
			_EntityDAL.PackageName = value;
		}
	}

	public string OrderID
	{
		get
		{
			return _EntityDAL.OrderID;
		}
		set
		{
			_EntityDAL.OrderID = value;
		}
	}

	public string AppProductID
	{
		get
		{
			return _EntityDAL.AppProductID;
		}
		set
		{
			_EntityDAL.AppProductID = value;
		}
	}

	public string TokenHash
	{
		get
		{
			return _EntityDAL.TokenHash;
		}
		set
		{
			_EntityDAL.TokenHash = value;
		}
	}

	public string Token
	{
		get
		{
			return _EntityDAL.Token;
		}
		set
		{
			_EntityDAL.Token = value;
		}
	}

	public string DeveloperPayload
	{
		get
		{
			return _EntityDAL.DeveloperPayload;
		}
		set
		{
			_EntityDAL.DeveloperPayload = value;
		}
	}

	public int? PurchaseState
	{
		get
		{
			return _EntityDAL.PurchaseState;
		}
		set
		{
			_EntityDAL.PurchaseState = value;
		}
	}

	public long? PurchaseTime
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

	public int? ConsumptionState
	{
		get
		{
			return _EntityDAL.ConsumptionState;
		}
		set
		{
			_EntityDAL.ConsumptionState = value;
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

	public GooglePlayStorePayment()
	{
		_EntityDAL = new GooglePlayStorePaymentDAL();
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

	public static GooglePlayStorePayment Get(int id)
	{
		return EntityHelper.GetEntity<int, GooglePlayStorePaymentDAL, GooglePlayStorePayment>(EntityCacheInfo, id, () => GooglePlayStorePaymentDAL.Get(id));
	}

	private static ICollection<GooglePlayStorePayment> MultiGet(ICollection<int> ids)
	{
		return EntityHelper.MultiGetEntity<int, GooglePlayStorePaymentDAL, GooglePlayStorePayment>(ids, EntityCacheInfo, GooglePlayStorePaymentDAL.MultiGet);
	}

	public static GooglePlayStorePayment GetByPaymentID(long paymentID)
	{
		return EntityHelper.GetEntityByLookup<int, GooglePlayStorePaymentDAL, GooglePlayStorePayment>(EntityCacheInfo, $"PaymentID:{paymentID}", () => GooglePlayStorePaymentDAL.GetGooglePlayStorePaymentByPaymentID(paymentID));
	}

	public static int GetTotalNumberOfGooglePlayStorePayments(string packageName, string appProductID, string tokenHash, int? purchaseState)
	{
		string cacheKey = string.Format("PackageName:{0}_AppProductID:{1}_TokenHash:{2}_PaymentState:{3}", packageName, appProductID, tokenHash, purchaseState.HasValue ? purchaseState.ToString() : "null");
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, cacheKey), "GetTotalNumberOfGooglePlayStorePayments_" + cacheKey, () => GooglePlayStorePaymentDAL.GetTotalNumberOfGooglePlayStorePayments(packageName, appProductID, tokenHash, purchaseState));
	}

	public static ICollection<GooglePlayStorePayment> GetGooglePlayStorePaymentsByOrderIDPaged(string orderId, int count, int? exclusiveStartId = null)
	{
		string collectionId = $"GetGooglePlayStorePaymentsByOrderID_OrderID:{orderId}_Count:{count}_ExclusiveStartId:{exclusiveStartId}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy(GetLookupCacheKeysByOrderID(orderId)), collectionId, () => GooglePlayStorePaymentDAL.GetGooglePlayStorePaymentIDsByOrderID(orderId, count, exclusiveStartId), MultiGet);
	}

	public void Construct(GooglePlayStorePaymentDAL dal)
	{
		_EntityDAL = dal;
	}

	public static string GetTokenHash(string token)
	{
		return HashFunctions.ComputeHashString(token.GetBytes());
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"PaymentID:{PaymentID}";
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken(GetLookupCacheKeysByOrderID(OrderID));
		yield return new StateToken(string.Format("PackageName:{0}_AppProductID:{1}_TokenHash:{2}_PaymentState:{3}", PackageName, AppProductID, TokenHash, PurchaseState.HasValue ? PurchaseState.ToString() : "null"));
	}

	private static string GetLookupCacheKeysByOrderID(string orderId)
	{
		return $"OrderID:{orderId}";
	}
}
