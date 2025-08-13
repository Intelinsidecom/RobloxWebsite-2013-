using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Billing;

public class Imbursement : IRobloxEntity<int, ImbursementDAL>, ICacheableObject<int>, ICacheableObject
{
	private ImbursementDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(Imbursement).ToString(), isNullCacheable: true);

	public int ID => _EntityDAL.ID;

	public long UserID
	{
		get
		{
			return _EntityDAL.UserID;
		}
		set
		{
			_EntityDAL.UserID = value;
		}
	}

	public int AccountPayableID
	{
		get
		{
			return _EntityDAL.AccountPayableID;
		}
		set
		{
			_EntityDAL.AccountPayableID = value;
		}
	}

	public byte CurrencyTypeID
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

	/// <summary>
	/// The original status type ID of the imbursement.
	/// It's used for cache invalidation
	/// </summary>
	private byte? _OriginalImbursementStatusTypeID { get; set; }

	public byte ImbursementStatusTypeID
	{
		get
		{
			return _EntityDAL.ImbursementStatusTypeID;
		}
		set
		{
			if (!_OriginalImbursementStatusTypeID.HasValue)
			{
				_OriginalImbursementStatusTypeID = _EntityDAL.ImbursementStatusTypeID;
			}
			_EntityDAL.ImbursementStatusTypeID = value;
		}
	}

	public byte? ImbursementRejectionTypeID
	{
		get
		{
			return _EntityDAL.ImbursementRejectionTypeID;
		}
		set
		{
			_EntityDAL.ImbursementRejectionTypeID = value;
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

	public int Robux
	{
		get
		{
			return _EntityDAL.Robux;
		}
		set
		{
			_EntityDAL.Robux = value;
		}
	}

	public string EscrowID
	{
		get
		{
			return _EntityDAL.EscrowID;
		}
		set
		{
			_EntityDAL.EscrowID = value;
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

	public Imbursement()
	{
		_EntityDAL = new ImbursementDAL();
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
		_OriginalImbursementStatusTypeID = null;
	}

	public static Imbursement CreateNew(long userID, int accountPayableID, byte currencyTypeID, byte imbursementStatusTypeID, decimal amount, int robux, string escrowID, byte? imbursementRejectionTypeID = null)
	{
		Imbursement imbursement = new Imbursement();
		imbursement.UserID = userID;
		imbursement.AccountPayableID = accountPayableID;
		imbursement.CurrencyTypeID = currencyTypeID;
		imbursement.ImbursementStatusTypeID = imbursementStatusTypeID;
		imbursement.ImbursementRejectionTypeID = imbursementRejectionTypeID;
		imbursement.Amount = amount;
		imbursement.Robux = robux;
		imbursement.EscrowID = escrowID;
		imbursement.Save();
		return imbursement;
	}

	public static Imbursement Get(int id)
	{
		return EntityHelper.GetEntity<int, ImbursementDAL, Imbursement>(EntityCacheInfo, id, () => ImbursementDAL.Get(id));
	}

	internal static ICollection<Imbursement> MultiGet(ICollection<int> ids)
	{
		return EntityHelper.MultiGetEntity<int, ImbursementDAL, Imbursement>(ids, EntityCacheInfo, ImbursementDAL.MultiGet);
	}

	public static ICollection<Imbursement> GetImbursementsByAccountPayableID(int accountPayableID, int startRowIndex, int maxRows)
	{
		string collectionId = $"GetImbursementsByAccountPayableID_AccountPayableID:{accountPayableID}_StartRowIndex:{startRowIndex}_MaxRows:{maxRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"AccountPayableID:{accountPayableID}"), collectionId, () => ImbursementDAL.GetImbursementIDsByAccountPayableID(accountPayableID, startRowIndex, maxRows), MultiGet);
	}

	public static ICollection<Imbursement> GetImbursementsByUserID(long userId, int startRowIndex, int maxRows)
	{
		string collectionId = $"GetImbursementsByUserID_UserID:{userId}_StartRowIndex:{startRowIndex}_MaxRows:{maxRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"UserID:{userId}"), collectionId, () => ImbursementDAL.GetImbursementIDsByUserID(userId, startRowIndex, maxRows), MultiGet);
	}

	public static ICollection<Imbursement> GetImbursementIDsByUserIDBetweenDates(long userId, DateTime startDate, DateTime endDate, int startRowIndex, int maxRows)
	{
		string collectionId = $"GetImbursementIDsByUserIDBetweenDates_UserID:{userId}_StartDate:{startDate}_EndDate:{endDate}_StartRowIndex:{startRowIndex}_MaxRows:{maxRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"UserID:{userId}"), collectionId, () => ImbursementDAL.GetImbursementIDsByUserIDBetweenDates(userId, startDate, endDate, startRowIndex, maxRows), MultiGet);
	}

	public static ICollection<Imbursement> GetImbursementsByImbursementStatusTypeID(byte statusTypeID, int startRowIndex, int maxRows)
	{
		string collectionId = $"GetImbursementsByImbursementStatusTypeID_StatusTypeID:{statusTypeID}_StartRowIndex:{startRowIndex}_MaxRows:{maxRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"ImbursementStatusTypeID:{statusTypeID}"), collectionId, () => ImbursementDAL.GetImbursementIDsByImbursementStatusTypeID(statusTypeID, startRowIndex, maxRows), MultiGet);
	}

	public static ICollection<Imbursement> GetImbursementsByUserIDAndImbursementStatusTypeID(byte statusTypeID, long userID, int startRowIndex, int maxRows)
	{
		string collectionId = $"GetImbursementsByUserIDAndImbursementStatusTypeID_StatusTypeID:{statusTypeID}_UserID:{userID}_StartRowIndex:{startRowIndex}_MaxRows:{maxRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"UserID:{userID}_ImbursementStatusTypeID:{statusTypeID}"), collectionId, () => ImbursementDAL.GetImbursementIDsByUserIDAndImbursementStatusTypeID(statusTypeID, userID, startRowIndex, maxRows), MultiGet);
	}

	public static int GetTotalNumberOfImbursementsByImbursementStatusTypeID(byte statusTypeID)
	{
		string countID = $"ImbursementStatusTypeID:{statusTypeID}";
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"ImbursementStatusTypeID:{statusTypeID}"), countID, () => ImbursementDAL.GetTotalNumberOfImbursementIDsByImbursementStatusTypeID(statusTypeID));
	}

	public static int GetTotalNumberOfImbursementsByUserIDBetweenDates(long userId, DateTime startDate, DateTime endDate)
	{
		string countID = $"GetImbursementIDsByUserIDBetweenDates_UserID:{userId}_StartDate:{startDate}_EndDate:{endDate}";
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"UserID:{userId}"), countID, () => ImbursementDAL.GetTotalNumberOfImbursementsByUserIDBetweenDates(userId, startDate, endDate));
	}

	public static int GetTotalNumberOfImbursementsByUserID(long userId)
	{
		string countID = $"GetTotalNumberOfImbursementsByUserID:{userId}";
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"UserID:{userId}"), countID, () => ImbursementDAL.GetTotalNumberOfImbursementsByUserID(userId));
	}

	public static int GetTotalNumberOfImbursementsByAccountPayableID(int accountPayableID)
	{
		string countID = $"GetTotalNumberOfImbursementsByAccountPayableID:{accountPayableID}";
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"AccountPayableID:{accountPayableID}"), countID, () => ImbursementDAL.GetTotalNumberOfImbursementsByAccountPayableID(accountPayableID));
	}

	public static int GetTotalNumberOfImbursementsByUserIDAndImbursementStatusTypeID(long userID, byte statusTypeID)
	{
		string countID = $"GetTotalNumberOfImbursementsByUserIDAndImbursementStatusTypeID_UserID:{userID}_ImbursementStatusTypeID:{statusTypeID}";
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"UserID:{userID}_ImbursementStatusTypeID:{statusTypeID}"), countID, () => ImbursementDAL.GetTotalNumberOfImbursementsByUserIDAndImbursementStatusTypeID(userID, statusTypeID));
	}

	public void Construct(ImbursementDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield break;
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken($"AccountPayableID:{AccountPayableID}");
		yield return new StateToken($"UserID:{UserID}");
		yield return new StateToken($"UserID:{UserID}_ImbursementStatusTypeID:{ImbursementStatusTypeID}");
		yield return new StateToken($"ImbursementStatusTypeID:{ImbursementStatusTypeID}");
		if (_OriginalImbursementStatusTypeID.HasValue)
		{
			yield return new StateToken($"ImbursementStatusTypeID:{_OriginalImbursementStatusTypeID}");
			yield return new StateToken($"UserID:{UserID}_ImbursementStatusTypeID:{_OriginalImbursementStatusTypeID}");
		}
	}
}
