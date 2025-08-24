using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Billing.Entities;

public class AppleAppStorePayment : IRobloxEntity<int, AppleAppStorePaymentDAL>, ICacheableObject<int>, ICacheableObject
{
	private AppleAppStorePaymentDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), typeof(AppleAppStorePayment).ToString(), isNullCacheable: true);

	public int ID => _EntityDAL.ID;

	public long PaymentId
	{
		get
		{
			return _EntityDAL.PaymentId;
		}
		set
		{
			_EntityDAL.PaymentId = value;
		}
	}

	public int Status
	{
		get
		{
			return _EntityDAL.Status;
		}
		set
		{
			_EntityDAL.Status = value;
		}
	}

	public string Receipt
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

	public string ReceiptHash
	{
		get
		{
			return _EntityDAL.ReceiptHash;
		}
		set
		{
			_EntityDAL.ReceiptHash = value;
		}
	}

	public string AppItemId
	{
		get
		{
			return _EntityDAL.AppItemId;
		}
		set
		{
			_EntityDAL.AppItemId = value;
		}
	}

	public string Bid
	{
		get
		{
			return _EntityDAL.Bid;
		}
		set
		{
			_EntityDAL.Bid = value;
		}
	}

	public string BVRS
	{
		get
		{
			return _EntityDAL.BVRS;
		}
		set
		{
			_EntityDAL.BVRS = value;
		}
	}

	public string ItemId
	{
		get
		{
			return _EntityDAL.ItemId;
		}
		set
		{
			_EntityDAL.ItemId = value;
		}
	}

	public string OriginalPurchaseDate
	{
		get
		{
			return _EntityDAL.OriginalPurchaseDate;
		}
		set
		{
			_EntityDAL.OriginalPurchaseDate = value;
		}
	}

	public string OriginalTransactionId
	{
		get
		{
			return _EntityDAL.OriginalTransactionId;
		}
		set
		{
			_EntityDAL.OriginalTransactionId = value;
		}
	}

	public string ProductId
	{
		get
		{
			return _EntityDAL.ProductId;
		}
		set
		{
			_EntityDAL.ProductId = value;
		}
	}

	public string PurchaseDate
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

	public string Quantity
	{
		get
		{
			return _EntityDAL.Quantity;
		}
		set
		{
			_EntityDAL.Quantity = value;
		}
	}

	public string TransactionId
	{
		get
		{
			return _EntityDAL.TransactionId;
		}
		set
		{
			_EntityDAL.TransactionId = value;
		}
	}

	public string VersionExternalIdentifier
	{
		get
		{
			return _EntityDAL.VersionExternalIdentifier;
		}
		set
		{
			_EntityDAL.VersionExternalIdentifier = value;
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

	public long? TransactionId_BigInt
	{
		get
		{
			return _EntityDAL.TransactionId_BigInt;
		}
		set
		{
			_EntityDAL.TransactionId_BigInt = value;
		}
	}

	public CacheInfo CacheInfo => EntityCacheInfo;

	public AppleAppStorePayment()
	{
		_EntityDAL = new AppleAppStorePaymentDAL();
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

	internal static AppleAppStorePayment CreateNew(long paymentId, AppleAppStoreProofOfPurchase proofOfPurchase)
	{
		string receiptHash = HashFunctions.ComputeHashString(proofOfPurchase.Receipt.GetBytes());
		return CreateNew(paymentId, proofOfPurchase.Status, proofOfPurchase.Receipt, receiptHash, proofOfPurchase.AppItemId, proofOfPurchase.Bid, proofOfPurchase.BVRS, proofOfPurchase.ItemId, proofOfPurchase.OriginalPurchaseDate, proofOfPurchase.OriginalTransactionId, proofOfPurchase.ProductId, proofOfPurchase.PurchaseDate, proofOfPurchase.Quantity, proofOfPurchase.TransactionId, proofOfPurchase.VersionExternalIdentifier);
	}

	public static AppleAppStorePayment CreateNew(long paymentId, int status, string receipt, string receiptHash, string appItemId, string bid, string bvrs, string itemId, string originalPurchaseDate, string originalTransactionId, string productId, string purchaseDate, string quantity, string transactionId, string versionExternalIdentifier)
	{
		AppleAppStorePayment entity = new AppleAppStorePayment();
		entity.PaymentId = paymentId;
		entity.Status = status;
		entity.Receipt = receipt;
		entity.ReceiptHash = receiptHash;
		entity.AppItemId = appItemId;
		entity.Bid = bid;
		entity.BVRS = bvrs;
		entity.ItemId = itemId;
		entity.OriginalPurchaseDate = originalPurchaseDate;
		entity.OriginalTransactionId = originalTransactionId;
		entity.ProductId = productId;
		entity.PurchaseDate = purchaseDate;
		entity.Quantity = quantity;
		entity.TransactionId = transactionId;
		if (long.TryParse(entity.TransactionId, out var transactionIdBigInt))
		{
			entity.TransactionId_BigInt = transactionIdBigInt;
		}
		entity.VersionExternalIdentifier = versionExternalIdentifier;
		entity.Save();
		return entity;
	}

	public static AppleAppStorePayment Get(int id)
	{
		return EntityHelper.GetEntity<int, AppleAppStorePaymentDAL, AppleAppStorePayment>(EntityCacheInfo, id, () => AppleAppStorePaymentDAL.Get(id));
	}

	internal static ICollection<AppleAppStorePayment> MultiGet(ICollection<int> ids)
	{
		return EntityHelper.MultiGetEntity<int, AppleAppStorePaymentDAL, AppleAppStorePayment>(ids, EntityCacheInfo, AppleAppStorePaymentDAL.MultiGet);
	}

	public static AppleAppStorePayment GetByPaymentId(long paymentId)
	{
		return EntityHelper.GetEntityByLookup<int, AppleAppStorePaymentDAL, AppleAppStorePayment>(EntityCacheInfo, $"PaymentId:{paymentId}", () => AppleAppStorePaymentDAL.GetAppleAppStorePaymentByPaymentId(paymentId));
	}

	public static ICollection<AppleAppStorePayment> GetByTransactionIDBigInt(long transactionIDBigInt)
	{
		string collectionId = $"GetByTransactionIDBigInt_TransactionIDBigInt:{transactionIDBigInt}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"TransactionIDBigInt:{transactionIDBigInt}"), collectionId, () => AppleAppStorePaymentDAL.GetAppleAppStorePaymentIDsByTransactionIDBigInt(transactionIDBigInt), MultiGet);
	}

	public static int GetTotalNumberOfAppleAppStorePaymentsByReceiptHashAndStatus(string receiptHash, int status)
	{
		string countId = "GetTotalNumberOfAppleAppStorePaymentsByReceiptHashAndStatus_ReceiptHash:" + receiptHash + "_Status:" + status;
		string cachedStateQualifier = "ReceiptHash:" + receiptHash + "_Status:" + status;
		return EntityHelper.GetEntityCount(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy(cachedStateQualifier), countId, () => AppleAppStorePaymentDAL.GetTotalNumberOfAppleAppStorePaymentsByReceiptHashAndStatus(receiptHash, status));
	}

	public static int GetTotalNumberOfAppleAppStorePaymentsByTransactionIdBigIntAndStatus(long transactionIdBigInt, int status)
	{
		string countId = "GetTotalNumberOfAppleAppStorePaymentsByTransactionIdBigIntAndStatus_TransactionIdBigInt:" + transactionIdBigInt + "_Status:" + status;
		string cachedStateQualifier = "TransactionIdBigInt:" + transactionIdBigInt + "_Status:" + status;
		return EntityHelper.GetEntityCount(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy(cachedStateQualifier), countId, () => AppleAppStorePaymentDAL.GetTotalNumberOfAppleAppStorePaymentsByTransactionIdBigIntAndStatus(transactionIdBigInt, status));
	}

	public void Construct(AppleAppStorePaymentDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"PaymentID:{PaymentId}";
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken("ReceiptHash:" + ReceiptHash + "_Status:" + Status);
		yield return new StateToken("TransactionIdBigInt:" + TransactionId_BigInt + "_Status:" + Status);
	}
}
