using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;
using Roblox.Economy.Common.Properties;
using Roblox.EventLog;

namespace Roblox.Economy.Common;

public class TransactionHistory : IRobloxEntity<long, TransactionHistoryDAL>, ICacheableObject<long>, ICacheableObject
{
	private TransactionHistoryDAL _EntityDAL;

	private static readonly TimeSpan _RobuxEarnedCountExpiration = Settings.Default.RobuxEarnedCountExpiration;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), "TransactionHistory", isNullCacheable: true);

	private bool SaleIDAccessLoggingEnabled => Settings.Default.SaleIDAccessLoggingEnabled;

	public long ID => _EntityDAL.ID;

	public byte TransactionTypeID
	{
		get
		{
			return _EntityDAL.TransactionTypeID;
		}
		set
		{
			_EntityDAL.TransactionTypeID = value;
		}
	}

	public byte TransactionOriginTypeID
	{
		get
		{
			return _EntityDAL.TransactionOriginTypeID;
		}
		set
		{
			_EntityDAL.TransactionOriginTypeID = value;
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

	public long? OriginID
	{
		get
		{
			return _EntityDAL.OriginID;
		}
		set
		{
			_EntityDAL.OriginID = value;
		}
	}

	public long? SaleID
	{
		get
		{
			if (SaleIDAccessLoggingEnabled)
			{
				ExceptionHandler.LogException("Attempt to get SaleID in TransactionHistory", LogLevel.Information);
			}
			return _EntityDAL.OriginID;
		}
		set
		{
			if (SaleIDAccessLoggingEnabled)
			{
				ExceptionHandler.LogException("Attempt to set SaleID in TransactionHistory", LogLevel.Information);
			}
			_EntityDAL.OriginID = value;
		}
	}

	public long Amount
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

	public bool IsProcessed
	{
		get
		{
			return _EntityDAL.IsProcessed;
		}
		set
		{
			_EntityDAL.IsProcessed = value;
		}
	}

	public DateTime Created => _EntityDAL.Created;

	public DateTime Updated => _EntityDAL.Updated;

	public CacheInfo CacheInfo => EntityCacheInfo;

	public TransactionHistory()
	{
		_EntityDAL = new TransactionHistoryDAL();
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

	public void Delete()
	{
		EntityHelper.DeleteEntity(this, _EntityDAL.Delete);
	}

	private static TransactionHistory DoGet(long id)
	{
		return EntityHelper.DoGet<long, TransactionHistoryDAL, TransactionHistory>(() => TransactionHistoryDAL.Get(id), id);
	}

	public static TransactionHistory Get(long id)
	{
		return EntityHelper.GetEntityOld(EntityCacheInfo, id, () => DoGet(id));
	}

	public static TransactionHistory Get(long? id)
	{
		if (id.HasValue)
		{
			return Get(id.Value);
		}
		return null;
	}

	public static long GetRobuxEarnedCount(long userId, DateTime fromDateTime)
	{
		DateTime snappedFromDateTime = fromDateTime;
		if (_RobuxEarnedCountExpiration > TimeSpan.Zero)
		{
			snappedFromDateTime = CacheManager.Snap(fromDateTime, _RobuxEarnedCountExpiration);
		}
		string countId = $"GetRobuxEarnedCount_UserID:{userId}_FromDateTime:{snappedFromDateTime}";
		string cachedStateQualifier = $"UserID:{userId}_CurrencyTypeID:{CurrencyType.RobuxID}_TransactionTypeID:{TransactionType.CreditID}";
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, cachedStateQualifier), countId, () => TransactionHistoryDAL.GetRobuxEarnedCount(userId, snappedFromDateTime));
	}

	public static long GetRobuxEarnedFromCurrencyPurchaseCount(long userId, DateTime fromDateTime)
	{
		DateTime snappedFromDateTime = fromDateTime;
		if (_RobuxEarnedCountExpiration > TimeSpan.Zero)
		{
			snappedFromDateTime = CacheManager.Snap(fromDateTime, _RobuxEarnedCountExpiration);
		}
		string countId = $"GetRobuxEarnedFromCurrencyPurchaseCount_UserID:{userId}_FromDateTime:{snappedFromDateTime}";
		string cachedStateQualifier = $"UserID:{userId}_CurrencyTypeID:{CurrencyType.RobuxID}_TransactionTypeID:{TransactionType.CreditID}_TransactionOriginTypeID:{TransactionOriginType.CurrencyPurchaseID}";
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, cachedStateQualifier), countId, () => TransactionHistoryDAL.GetRobuxEarnedFromCurrencyPurchaseCount(userId, snappedFromDateTime));
	}

	public static long GetRobuxEarnedFromLoginAwardsCount(long userId, DateTime fromDateTime)
	{
		DateTime snappedFromDateTime = fromDateTime;
		if (_RobuxEarnedCountExpiration > TimeSpan.Zero)
		{
			snappedFromDateTime = CacheManager.Snap(fromDateTime, _RobuxEarnedCountExpiration);
		}
		string countId = $"GetRobuxEarnedFromLoginAwardsCount_UserID:{userId}_FromDateTime:{snappedFromDateTime}";
		string cachedStateQualifier = $"UserID:{userId}_CurrencyTypeID:{CurrencyType.RobuxID}_TransactionTypeID:{TransactionType.CreditID}_TransactionOriginTypeID:{TransactionOriginType.DailyLoginAwardID}";
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, cachedStateQualifier), countId, () => TransactionHistoryDAL.GetRobuxEarnedFromLoginAwardsCount(userId, snappedFromDateTime));
	}

	public static long GetRobuxEarnedFromPlaceTrafficAwardsCount(long userId, DateTime fromDateTime)
	{
		DateTime snappedFromDateTime = fromDateTime;
		if (_RobuxEarnedCountExpiration > TimeSpan.Zero)
		{
			snappedFromDateTime = CacheManager.Snap(fromDateTime, _RobuxEarnedCountExpiration);
		}
		string countId = $"GetRobuxEarnedFromPlaceTrafficAwardsCount_UserID:{userId}_FromDateTime:{snappedFromDateTime}";
		string cachedStateQualifier = $"UserID:{userId}_CurrencyTypeID:{CurrencyType.RobuxID}_TransactionTypeID:{TransactionType.CreditID}_TransactionOriginTypeID:{TransactionOriginType.PlaceTrafficAwardID}";
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, cachedStateQualifier), countId, () => TransactionHistoryDAL.GetRobuxEarnedFromPlaceTrafficAwardsCount(userId, snappedFromDateTime));
	}

	public static long GetRobuxEarnedFromSaleOfGoodsCount(long userId, DateTime fromDateTime)
	{
		DateTime snappedFromDateTime = fromDateTime;
		if (_RobuxEarnedCountExpiration > TimeSpan.Zero)
		{
			snappedFromDateTime = CacheManager.Snap(fromDateTime, _RobuxEarnedCountExpiration);
		}
		string countId = $"GetRobuxEarnedFromSaleOfGoodsCount_UserID:{userId}_FromDateTime:{snappedFromDateTime}";
		string cachedStateQualifier = $"UserID:{userId}_CurrencyTypeID:{CurrencyType.RobuxID}_TransactionTypeID:{TransactionType.CreditID}_TransactionOriginTypeID:{TransactionOriginType.SaleOfGoodsID}";
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, cachedStateQualifier), countId, () => TransactionHistoryDAL.GetRobuxEarnedFromSaleOfGoodsCount(userId, snappedFromDateTime));
	}

	public static long GetRobuxEarnedFromSignupBonusCount(long userId, DateTime fromDateTime)
	{
		DateTime snappedFromDateTime = fromDateTime;
		if (_RobuxEarnedCountExpiration > TimeSpan.Zero)
		{
			snappedFromDateTime = CacheManager.Snap(fromDateTime, _RobuxEarnedCountExpiration);
		}
		string countId = $"GetRobuxEarnedFromSignupBonusCount_UserID:{userId}_FromDateTime:{snappedFromDateTime}";
		string cachedStateQualifier = $"UserID:{userId}_CurrencyTypeID:{CurrencyType.RobuxID}_TransactionTypeID:{TransactionType.CreditID}_TransactionOriginTypeID:{TransactionOriginType.BuildersClubSignupBonusID}";
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, cachedStateQualifier), countId, () => TransactionHistoryDAL.GetRobuxEarnedFromSignupBonusCount(userId, snappedFromDateTime));
	}

	public static long GetRobuxAdjustedFromAdjustments(long userId, DateTime fromDateTime)
	{
		DateTime snappedFromDateTime = fromDateTime;
		if (_RobuxEarnedCountExpiration > TimeSpan.Zero)
		{
			snappedFromDateTime = CacheManager.Snap(fromDateTime, _RobuxEarnedCountExpiration);
		}
		string countId = $"GetRobuxAdjustedFromAdjustments_UserID:{userId}_FromDateTime:{snappedFromDateTime}";
		string cachedStateQualifier = $"UserID:{userId}_CurrencyTypeID:{CurrencyType.RobuxID}_TransactionTypeID:{TransactionType.AdjustmentID}_TransactionOriginTypeID:{TransactionOriginType.MiscellaneousAdjustmentID}";
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, cachedStateQualifier), countId, () => TransactionHistoryDAL.GetRobuxAdjustedFromAdjustments(userId, snappedFromDateTime));
	}

	public static long GetRobuxCreditedFromAdjustments(long userId, DateTime fromDateTime)
	{
		DateTime snappedFromDateTime = fromDateTime;
		if (_RobuxEarnedCountExpiration > TimeSpan.Zero)
		{
			snappedFromDateTime = CacheManager.Snap(fromDateTime, _RobuxEarnedCountExpiration);
		}
		string countId = $"GetRobuxCreditedFromAdjustments_UserID:{userId}_FromDateTime:{snappedFromDateTime}";
		string cachedStateQualifier = $"UserID:{userId}_CurrencyTypeID:{CurrencyType.RobuxID}_TransactionTypeID:{TransactionType.CreditID}_TransactionOriginTypeID:{TransactionOriginType.MiscellaneousAdjustmentID}";
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, cachedStateQualifier), countId, () => TransactionHistoryDAL.GetRobuxCreditedFromAdjustments(userId, snappedFromDateTime));
	}

	public static long GetRobuxDebitedFromAdjustments(long userId, DateTime fromDateTime)
	{
		DateTime snappedFromDateTime = fromDateTime;
		if (_RobuxEarnedCountExpiration > TimeSpan.Zero)
		{
			snappedFromDateTime = CacheManager.Snap(fromDateTime, _RobuxEarnedCountExpiration);
		}
		string countId = $"GetRobuxDebitedFromAdjustments_UserID:{userId}_FromDateTime:{snappedFromDateTime}";
		string cachedStateQualifier = $"UserID:{userId}_CurrencyTypeID:{CurrencyType.RobuxID}_TransactionTypeID:{TransactionType.DebitID}_TransactionOriginTypeID:{TransactionOriginType.MiscellaneousAdjustmentID}";
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, cachedStateQualifier), countId, () => TransactionHistoryDAL.GetRobuxDebitedFromAdjustments(userId, snappedFromDateTime));
	}

	public static long GetRobuxCreditedFromCurrencyTrade(long userId, DateTime fromDateTime)
	{
		DateTime snappedFromDateTime = fromDateTime;
		if (_RobuxEarnedCountExpiration > TimeSpan.Zero)
		{
			snappedFromDateTime = CacheManager.Snap(fromDateTime, _RobuxEarnedCountExpiration);
		}
		string countId = $"GetRobuxCreditedFromCurrencyTrade_UserID:{userId}_FromDateTime:{snappedFromDateTime}";
		string cachedStateQualifier = $"UserID:{userId}_CurrencyTypeID:{CurrencyType.RobuxID}_TransactionTypeID:{TransactionType.CreditID}_TransactionOriginTypeID:{TransactionOriginType.CurrencyTradeID}";
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, cachedStateQualifier), countId, () => TransactionHistoryDAL.GetRobuxCreditedFromCurrencyTrade(userId, snappedFromDateTime));
	}

	public static long GetRobuxDebitedFromCurrencyTrade(long userId, DateTime fromDateTime)
	{
		DateTime snappedFromDateTime = fromDateTime;
		if (_RobuxEarnedCountExpiration > TimeSpan.Zero)
		{
			snappedFromDateTime = CacheManager.Snap(fromDateTime, _RobuxEarnedCountExpiration);
		}
		string countId = $"GetRobuxDebitedFromCurrencyTrade_UserID:{userId}_FromDateTime:{snappedFromDateTime}";
		string cachedStateQualifier = $"UserID:{userId}_CurrencyTypeID:{CurrencyType.RobuxID}_TransactionTypeID:{TransactionType.DebitID}_TransactionOriginTypeID:{TransactionOriginType.CurrencyTradeID}";
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, cachedStateQualifier), countId, () => TransactionHistoryDAL.GetRobuxDebitedFromCurrencyTrade(userId, snappedFromDateTime));
	}

	public static long GetRobuxDebitedFromSaleOfGoods(long userId, DateTime fromDateTime)
	{
		DateTime snappedFromDateTime = fromDateTime;
		if (_RobuxEarnedCountExpiration > TimeSpan.Zero)
		{
			snappedFromDateTime = CacheManager.Snap(fromDateTime, _RobuxEarnedCountExpiration);
		}
		string countId = $"GetRobuxDebitedFromSaleOfGoods_UserID:{userId}_FromDateTime:{snappedFromDateTime}";
		string cachedStateQualifier = $"UserID:{userId}_CurrencyTypeID:{CurrencyType.RobuxID}_TransactionTypeID:{TransactionType.DebitID}_TransactionOriginTypeID:{TransactionOriginType.SaleOfGoodsID}";
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, cachedStateQualifier), countId, () => TransactionHistoryDAL.GetRobuxDebitedFromSaleOfGoods(userId, snappedFromDateTime));
	}

	public static long GetRobuxCreditedFromTradeSystem(long userId, DateTime fromDateTime)
	{
		DateTime snappedFromDateTime = fromDateTime;
		if (_RobuxEarnedCountExpiration > TimeSpan.Zero)
		{
			snappedFromDateTime = CacheManager.Snap(fromDateTime, _RobuxEarnedCountExpiration);
		}
		string countId = $"GetRobuxCreditedFromTradeSystem_UserID:{userId}_FromDateTime:{snappedFromDateTime}";
		string cachedStateQualifier = $"UserID:{userId}_CurrencyTypeID:{CurrencyType.RobuxID}_TransactionTypeID:{TransactionType.CreditID}_TransactionOriginTypeID:{TransactionOriginType.TradeSystemTradeID}";
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, cachedStateQualifier), countId, () => TransactionHistoryDAL.GetRobuxCreditedFromTradeSystem(userId, snappedFromDateTime));
	}

	public static long GetRobuxEarnedFromBCStipendBonusCount(long userId, DateTime fromDateTime)
	{
		DateTime snappedFromDateTime = fromDateTime;
		if (_RobuxEarnedCountExpiration > TimeSpan.Zero)
		{
			snappedFromDateTime = CacheManager.Snap(fromDateTime, _RobuxEarnedCountExpiration);
		}
		string countId = $"GetRobuxEarnedFromBCStipendBonusCount_UserID:{userId}_FromDateTime:{snappedFromDateTime}";
		string cachedStateQualifier = $"UserID:{userId}_CurrencyTypeID:{CurrencyType.RobuxID}_TransactionTypeID:{TransactionType.CreditID}_TransactionOriginTypeID:{TransactionOriginType.BuildersClubStipendBonusID}";
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, cachedStateQualifier), countId, () => TransactionHistoryDAL.GetRobuxEarnedFromBCStipendBonusCount(userId, snappedFromDateTime));
	}

	public static long GetTicketsRobloxAdjustmentAmount(long userId, DateTime fromDateTime)
	{
		DateTime snappedFromDateTime = fromDateTime;
		if (_RobuxEarnedCountExpiration > TimeSpan.Zero)
		{
			snappedFromDateTime = CacheManager.Snap(fromDateTime, _RobuxEarnedCountExpiration);
		}
		string countId = $"GetTicketsRobloxAdjustmentAmount_UserID:{userId}_FromDateTime:{snappedFromDateTime}";
		string cachedStateQualifier = $"UserID:{userId}_CurrencyTypeID:{CurrencyType.RobuxID}_TransactionTypeID:{TransactionType.AdjustmentID}_TransactionOriginTypeID:{TransactionOriginType.AdjustmentByRobloxAdminID}";
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, cachedStateQualifier), countId, () => TransactionHistoryDAL.GetTransactionsTotalAmountByCriteria(userId, TransactionType.AdjustmentID, TransactionOriginType.AdjustmentByRobloxAdminID, CurrencyType.TicketsID, snappedFromDateTime));
	}

	public static long GetRobuxRobloxAdjustmentAmount(long userId, DateTime fromDateTime)
	{
		DateTime snappedFromDateTime = fromDateTime;
		if (_RobuxEarnedCountExpiration > TimeSpan.Zero)
		{
			snappedFromDateTime = CacheManager.Snap(fromDateTime, _RobuxEarnedCountExpiration);
		}
		string countId = $"GetRobuxRobloxAdjustmentAmount_UserID:{userId}_FromDateTime:{snappedFromDateTime}";
		string cachedStateQualifier = $"UserID:{userId}_CurrencyTypeID:{CurrencyType.RobuxID}_TransactionTypeID:{TransactionType.AdjustmentID}_TransactionOriginTypeID:{TransactionOriginType.AdjustmentByRobloxAdminID}";
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, cachedStateQualifier), countId, () => TransactionHistoryDAL.GetTransactionsTotalAmountByCriteria(userId, TransactionType.AdjustmentID, TransactionOriginType.AdjustmentByRobloxAdminID, CurrencyType.RobuxID, snappedFromDateTime));
	}

	public static long GetRobuxOrganicAcquisitionTargetedPayoutAmount(long userId, DateTime fromDateTime)
	{
		DateTime snappedFromDateTime = fromDateTime;
		if (_RobuxEarnedCountExpiration > TimeSpan.Zero)
		{
			snappedFromDateTime = CacheManager.Snap(fromDateTime, _RobuxEarnedCountExpiration);
		}
		string countId = $"GetOrganicAcquisitionTargetedPayoutAmount_UserID:{userId}_FromDateTime:{snappedFromDateTime}";
		string cachedStateQualifier = $"UserID:{userId}_CurrencyTypeID:{CurrencyType.RobuxID}_TransactionTypeID:{TransactionType.CreditID}_TransactionOriginTypeID:{TransactionOriginType.OrganicAcquisitionTargetedID}";
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, cachedStateQualifier), countId, () => TransactionHistoryDAL.GetTransactionsTotalAmountByCriteria(userId, TransactionType.CreditID, TransactionOriginType.OrganicAcquisitionTargetedID, CurrencyType.RobuxID, snappedFromDateTime));
	}

	public static long GetRobuxOrganicAcquisitionPromotedPayoutAmount(long userId, DateTime fromDateTime)
	{
		DateTime snappedFromDateTime = fromDateTime;
		if (_RobuxEarnedCountExpiration > TimeSpan.Zero)
		{
			snappedFromDateTime = CacheManager.Snap(fromDateTime, _RobuxEarnedCountExpiration);
		}
		string countId = $"GetOrganicAcquisitionPromotedPayoutAmount_UserID:{userId}_FromDateTime:{snappedFromDateTime}";
		string cachedStateQualifier = $"UserID:{userId}_CurrencyTypeID:{CurrencyType.RobuxID}_TransactionTypeID:{TransactionType.CreditID}_TransactionOriginTypeID:{TransactionOriginType.OrganicAcquisitionPromotedID}";
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, cachedStateQualifier), countId, () => TransactionHistoryDAL.GetTransactionsTotalAmountByCriteria(userId, TransactionType.CreditID, TransactionOriginType.OrganicAcquisitionPromotedID, CurrencyType.RobuxID, snappedFromDateTime));
	}

	public static long GetRobuxEarnedFromGroupPayouts(long agentId, DateTime fromDateTime)
	{
		DateTime snappedFromDateTime = fromDateTime;
		if (_RobuxEarnedCountExpiration > TimeSpan.Zero)
		{
			snappedFromDateTime = CacheManager.Snap(fromDateTime, _RobuxEarnedCountExpiration);
		}
		string countId = $"GetRobuxEarnedFromGroupPayouts_UserID:{agentId}_FromDateTime:{snappedFromDateTime}";
		string cachedStateQualifier = $"UserID:{agentId}_CurrencyTypeID:{CurrencyType.RobuxID}_TransactionTypeID:{TransactionType.CreditID}_TransactionOriginTypeID:{TransactionOriginType.GroupRevenuePayoutID}";
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, cachedStateQualifier), countId, () => TransactionHistoryDAL.GetRobuxEarnedFromGroupPayouts(agentId, snappedFromDateTime));
	}

	public static long GetRobuxDebitedFromGroupPayouts(long agentId, DateTime fromDateTime)
	{
		DateTime snappedFromDateTime = fromDateTime;
		if (_RobuxEarnedCountExpiration > TimeSpan.Zero)
		{
			snappedFromDateTime = CacheManager.Snap(fromDateTime, _RobuxEarnedCountExpiration);
		}
		string countId = $"GetRobuxDebitedFromGroupPayouts_UserID:{agentId}_FromDateTime:{snappedFromDateTime}";
		string cachedStateQualifier = $"UserID:{agentId}_CurrencyTypeID:{CurrencyType.RobuxID}_TransactionTypeID:{TransactionType.DebitID}_TransactionOriginTypeID:{TransactionOriginType.GroupRevenuePayoutID}";
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, cachedStateQualifier), countId, () => TransactionHistoryDAL.GetRobuxDebitedFromGroupPayouts(agentId, snappedFromDateTime));
	}

	public static ICollection<TransactionHistory> GetTransactionHistoryByCriteriaPaged(long userId, byte currencyTypeId, byte transactionTypeId, byte transactionOriginTypeId, int startRowIndex, int maximumRows)
	{
		string collectionId = $"GetTransactionHistoryIDsByCriteriaPaged_UserID:{userId}_CurrencyTypeID:{currencyTypeId}_TransactionTypeID:{transactionTypeId}_TransactionOriginTypeID:{transactionOriginTypeId}_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		string cachedStateQualifier = $"UserID:{userId}_CurrencyTypeID:{currencyTypeId}_TransactionTypeID:{transactionTypeId}_TransactionOriginTypeID:{transactionOriginTypeId}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, cachedStateQualifier), collectionId, () => TransactionHistoryDAL.GetTransactionHistoryIDsByCriteriaPaged(userId, currencyTypeId, transactionTypeId, transactionOriginTypeId, startRowIndex + 1, maximumRows), Get);
	}

	public static void Submit(long userId, byte transactionTypeId, byte transactionOriginTypeId, byte currencyTypeId, long amount)
	{
		TransactionHistory entity = new TransactionHistory();
		entity.UserID = userId;
		entity.TransactionTypeID = transactionTypeId;
		entity.TransactionOriginTypeID = transactionOriginTypeId;
		entity.CurrencyTypeID = currencyTypeId;
		entity.Amount = amount;
		entity.IsProcessed = true;
		RobloxThreadPool.QueueUserWorkItem(delegate
		{
			entity.Save();
		});
	}

	public static void Submit(long userId, byte transactionTypeId, byte transactionOriginTypeId, byte currencyTypeId, long amount, long originId)
	{
		TransactionHistory entity = new TransactionHistory();
		entity.UserID = userId;
		entity.TransactionTypeID = transactionTypeId;
		entity.TransactionOriginTypeID = transactionOriginTypeId;
		entity.CurrencyTypeID = currencyTypeId;
		entity.Amount = amount;
		entity.SaleID = originId;
		entity.IsProcessed = true;
		RobloxThreadPool.QueueUserWorkItem(delegate
		{
			entity.Save();
		});
	}

	public static TransactionHistory CreateNew(long userId, byte transactionTypeId, byte transactionOriginTypeId, byte currencyTypeId, long amount, long? saleId = null)
	{
		TransactionHistory transactionHistory = new TransactionHistory();
		transactionHistory.UserID = userId;
		transactionHistory.TransactionTypeID = transactionTypeId;
		transactionHistory.TransactionOriginTypeID = transactionOriginTypeId;
		transactionHistory.CurrencyTypeID = currencyTypeId;
		transactionHistory.Amount = amount;
		transactionHistory.SaleID = saleId;
		transactionHistory.IsProcessed = true;
		transactionHistory.Save();
		return transactionHistory;
	}

	public void Construct(TransactionHistoryDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield break;
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken($"UserID:{UserID}_CurrencyTypeID:{CurrencyTypeID}_TransactionTypeID:{TransactionTypeID}");
		yield return new StateToken($"UserID:{UserID}_CurrencyTypeID:{CurrencyTypeID}_TransactionTypeID:{TransactionTypeID}_TransactionOriginTypeID:{TransactionOriginTypeID}");
	}
}
