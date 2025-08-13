using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Billing;

/// <summary>
/// Represents the caching access layer for an AmazonStorePayment.
/// </summary>
public class AmazonStorePayment : IRobloxEntity<long, AmazonStorePaymentDAL>, ICacheableObject<long>, ICacheableObject
{
	/// <summary>
	/// The backing DAL entity.
	/// </summary>
	private AmazonStorePaymentDAL _EntityDAL;

	/// <summary>
	/// The entity's <see cref="P:Roblox.Billing.AmazonStorePayment.CacheInfo" />.
	/// </summary>
	private static readonly CacheInfo _CacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(AmazonStorePayment).ToString(), isNullCacheable: true);

	/// <summary>
	/// Gets the payment's ID.
	/// </summary>
	public long ID
	{
		get
		{
			return _EntityDAL.ID;
		}
		internal set
		{
			_EntityDAL.ID = value;
		}
	}

	/// <summary>
	/// Gets or sets the ID of the corresponding payment record.
	/// </summary>
	public long PaymentID
	{
		get
		{
			return _EntityDAL.PaymentID;
		}
		internal set
		{
			_EntityDAL.PaymentID = value;
		}
	}

	/// <summary>
	/// Gets or sets the receipt ID supplied by Amazon.
	/// </summary>
	public string AmazonReceiptID
	{
		get
		{
			return _EntityDAL.AmazonReceiptID;
		}
		internal set
		{
			_EntityDAL.AmazonReceiptID = value;
		}
	}

	/// <summary>
	/// Gets or sets the hash of <see cref="P:Roblox.Billing.AmazonStorePayment.AmazonReceiptID" />.
	/// </summary>
	public string AmazonReceiptIDHash
	{
		get
		{
			return _EntityDAL.AmazonReceiptIDHash;
		}
		set
		{
			_EntityDAL.AmazonReceiptIDHash = value;
		}
	}

	/// <summary>
	/// Gets or sets the ID of the Amazon user.
	/// </summary>
	public string AmazonUserID
	{
		get
		{
			return _EntityDAL.AmazonUserID;
		}
		internal set
		{
			_EntityDAL.AmazonUserID = value;
		}
	}

	/// <summary>
	/// Gets or sets the ID of the Amazon product.
	/// </summary>
	public string AmazonProductID
	{
		get
		{
			return _EntityDAL.AmazonProductID;
		}
		internal set
		{
			_EntityDAL.AmazonProductID = value;
		}
	}

	/// <summary>
	/// Gets or sets the date that a product subscription was canceled.
	/// If a substriction is ongoing then <see cref="P:Roblox.Billing.AmazonStorePayment.CancelDate" /> will be null.
	/// </summary>
	public string CancelDate
	{
		get
		{
			return _EntityDAL.CancelDate;
		}
		set
		{
			_EntityDAL.CancelDate = value;
		}
	}

	/// <summary>
	/// Gets or sets the type of the product that was paid for.
	/// </summary>
	public string ProductType
	{
		get
		{
			return _EntityDAL.CancelDate;
		}
		set
		{
			_EntityDAL.CancelDate = value;
		}
	}

	/// <summary>
	/// Gets or sets the date that the purchase was made.
	/// </summary>
	public long? PurchaseDate
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

	/// <summary>
	/// The <see cref="T:System.DateTime" /> at which the record was created.
	/// </summary>
	public DateTime Created
	{
		get
		{
			return _EntityDAL.Created;
		}
		internal set
		{
			_EntityDAL.Created = value;
		}
	}

	/// <summary>
	/// The <see cref="T:System.DateTime" /> at which the record was last updated.
	/// </summary>
	public DateTime Updated
	{
		get
		{
			return _EntityDAL.Updated;
		}
		internal set
		{
			_EntityDAL.Updated = value;
		}
	}

	/// <summary>
	/// Gets the entity's <see cref="P:Roblox.Billing.AmazonStorePayment.CacheInfo" />.
	/// </summary>
	public CacheInfo CacheInfo => _CacheInfo;

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Billing.AmazonStorePayment" /> class.
	/// </summary>
	public AmazonStorePayment()
	{
		_EntityDAL = new AmazonStorePaymentDAL();
	}

	/// <summary>
	/// Constructs an <see cref="T:Roblox.Billing.AmazonStorePayment" /> from the given <see cref="T:Roblox.Billing.AmazonStorePaymentDAL" />.
	/// </summary>
	/// <param name="dal">The <see cref="T:Roblox.Billing.AmazonStorePaymentDAL" /> to construct the <see cref="T:Roblox.Billing.AmazonStorePayment" /> from.</param>
	public void Construct(AmazonStorePaymentDAL dal)
	{
		_EntityDAL = dal;
	}

	/// <summary>
	/// Deletes the entity from the database.
	/// </summary>
	public void Delete()
	{
		EntityHelper.DeleteEntity(this, _EntityDAL.Delete);
	}

	/// <summary>
	/// Saves the entity to the database.
	/// </summary>
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

	/// <summary>
	/// Gets an <see cref="T:Roblox.Billing.AmazonStorePayment" /> by its ID.
	/// </summary>
	/// <param name="id">The ID of the <see cref="T:Roblox.Billing.AmazonStorePayment" /> to get.</param>
	/// <returns>The <see cref="T:Roblox.Billing.AmazonStorePayment" /> with the given ID, or null if none exists.</returns>
	public static AmazonStorePayment Get(long id)
	{
		return EntityHelper.GetEntity<long, AmazonStorePaymentDAL, AmazonStorePayment>(_CacheInfo, id, () => AmazonStorePaymentDAL.Get(id));
	}

	/// <summary>
	/// MultiGet <see cref="T:Roblox.Billing.AmazonStorePayment" /> by their IDs.
	/// </summary>
	/// <param name="ids"></param>
	/// <returns></returns>
	internal static ICollection<AmazonStorePayment> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.MultiGetEntity<long, AmazonStorePaymentDAL, AmazonStorePayment>(ids, _CacheInfo, AmazonStorePaymentDAL.MultiGet);
	}

	/// <summary>
	/// Builds the entity's ID lookups.
	/// </summary>
	/// <returns>The entity's ID lookups.</returns>
	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield break;
	}

	/// <summary>
	/// Builds the entity's <see cref="T:Roblox.Caching.StateToken" /> collection.
	/// </summary>
	/// <returns>The entity's <see cref="T:Roblox.Caching.StateToken" /> collection.</returns>
	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken("AmazonReceiptIDHash:" + AmazonReceiptIDHash);
	}

	/// <summary>
	/// Gets the total number of AmazonStorePayments containing the given receipt hash.
	/// </summary>
	/// <param name="amazonReceiptIdHash">The receipt hash.</param>
	/// <returns>The total number of AmazonStorePayments containing the given receipt hash.</returns>
	public static int GetTotalNumberOfAmazonStorePaymentsByAmazonReceiptIdHash(string amazonReceiptIdHash)
	{
		string countId = "GetTotalNumberOfAmazonStorePaymentsByAmazonReceiptIDHash_AmazonReceiptIDHash:" + amazonReceiptIdHash;
		string cachedStateQualifier = "AmazonReceiptIDHash:" + amazonReceiptIdHash;
		return EntityHelper.GetEntityCount(_CacheInfo, CacheManager.BuildQualifiedCachePolicy(cachedStateQualifier), countId, () => AmazonStorePaymentDAL.GetTotalNumberOfAppleAppStorePaymentsByAmazonReceiptIdHash(amazonReceiptIdHash));
	}

	/// <summary>
	/// Gets all AmazonStorePayments containing the given receipt hash.
	/// </summary>
	/// <param name="amazonReceiptIdHash">The receipt hash.</param>
	/// <param name="startRowIndex">StartRowIndex</param>
	/// <param name="maxRows">MaxRows</param>
	/// <returns>All AmazonStorePayments containing the given receipt hash.</returns>
	public static IEnumerable<AmazonStorePayment> GetAmazonStorePaymentsByAmazonReceiptIdHash_Paged(string amazonReceiptIdHash, int startRowIndex, int maxRows)
	{
		string collectionId = $"GetAmazonStorePaymentIDsByAmazonReceiptIDHash_AmazonReceiptIDHash:{amazonReceiptIdHash}_StartRowIndex:{startRowIndex}_MaximumRows:{maxRows}";
		string cachedStateQualifier = "AmazonReceiptIDHash:" + amazonReceiptIdHash;
		return EntityHelper.GetEntityCollection(_CacheInfo, CacheManager.BuildQualifiedCachePolicy(cachedStateQualifier), collectionId, () => AmazonStorePaymentDAL.GetAmazonStorePaymentIDsByAmazonReceiptIdHash_Paged(amazonReceiptIdHash, startRowIndex + 1, maxRows), MultiGet);
	}
}
