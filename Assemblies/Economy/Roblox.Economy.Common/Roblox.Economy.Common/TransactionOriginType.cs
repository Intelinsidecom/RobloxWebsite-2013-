using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Economy.Common;

public class TransactionOriginType : IRobloxEntity<byte, TransactionOriginTypeDAL>, ICacheableObject<byte>, ICacheableObject
{
	private TransactionOriginTypeDAL _EntityDAL;

	public static readonly byte AmbassadorAwardID;

	public static readonly string AmbassadorAwardValue;

	public static readonly byte BuildersClubSignupBonusID;

	public static readonly string BuildersClubSignupBonusValue;

	public static readonly byte BuildersClubStipendID;

	public static readonly string BuildersClubStipendValue;

	public static readonly byte BuildersClubStipendBonusID;

	public static readonly string BuildersClubStipendBonusValue;

	public static readonly byte CurrencyPurchaseID;

	public static readonly string CurrencyPurchaseValue;

	public static readonly byte CurrencyTradeID;

	public static readonly string CurrencyTradeValue;

	public static readonly byte DailyLoginAwardID;

	public static readonly string DailyLoginAwardValue;

	public static readonly byte MiscellaneousAdjustmentID;

	public static readonly string MiscellaneousAdjustmentValue;

	public static readonly byte PlaceTrafficAwardID;

	public static readonly string PlaceTrafficAwardValue;

	public static readonly byte SaleOfGoodsID;

	public static readonly string SaleOfGoodsValue;

	public static readonly byte AffiliateSaleID;

	public static readonly string AffiliateSaleValue;

	public static readonly byte TradeSystemTradeID;

	public static readonly string TradeSystemTradeValue;

	public static readonly byte VideoRefundID;

	public static readonly string VideoRefundValue;

	public static readonly byte RefundFromItemHoldID;

	public static readonly string RefundFromItemHoldValue;

	public static readonly byte CashOutID;

	public static readonly string CashOutValue;

	public static readonly byte AdjustmentByRobloxAdminID;

	public static readonly string AdjustmentByRobloxAdmin;

	public static readonly byte InGameAdImpressionPayoutID;

	public static readonly string InGameAdImpressionPayoutValue;

	public static readonly byte OrganicAcquisitionTargetedID;

	public static readonly string OrganicAcquisitionTargetedValue;

	public static readonly byte OrganicAcquisitionPromotedID;

	public static readonly string OrganicAcquisitionPromotedValue;

	public static readonly byte GroupRevenuePayoutID;

	public static readonly string GroupRevenuePayoutValue;

	public static readonly byte EndorsedAssetRewardID;

	public static readonly string EndorsedAssetRewardValue;

	public static readonly byte CSAdjustmentID;

	public static readonly string CSAdjustmentValue;

	public static readonly byte ContestID;

	public static readonly string ContestValue;

	public static readonly byte SurveyWinnerID;

	public static readonly string SurveyWinnerValue;

	public static readonly byte RetextureID;

	public static readonly string RetextureValue;

	public static readonly byte AdvertisingPromotionID;

	public static readonly string AdvertisingPromotionValue;

	public static readonly byte NewEmployeeID;

	public static readonly string NewEmployeeValue;

	public static readonly byte TestingID;

	public static readonly string TestingValue;

	public static readonly byte AccountRestoresID;

	public static readonly string AccountRestoresValue;

	public static CacheInfo EntityCacheInfo;

	public byte ID => _EntityDAL.ID;

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

	public DateTime Created => _EntityDAL.Created;

	public DateTime Updated => _EntityDAL.Updated;

	public CacheInfo CacheInfo => EntityCacheInfo;

	public TransactionOriginType()
	{
		_EntityDAL = new TransactionOriginTypeDAL();
	}

	static TransactionOriginType()
	{
		AmbassadorAwardValue = "Ambassador Award";
		BuildersClubSignupBonusValue = "Builders Club Signup Bonus";
		BuildersClubStipendValue = "Builders Club Stipend";
		BuildersClubStipendBonusValue = "Builders Club Stipend Bonus";
		CurrencyPurchaseValue = "Currency Purchase";
		CurrencyTradeValue = "Currency Trade";
		DailyLoginAwardValue = "Daily Login Award";
		MiscellaneousAdjustmentValue = "Miscellaneous Adjustment";
		PlaceTrafficAwardValue = "Place Traffic Award";
		SaleOfGoodsValue = "Sale of Goods";
		AffiliateSaleValue = "Affiliate Sale";
		TradeSystemTradeValue = "Trade System Trade";
		VideoRefundValue = "Video Refund";
		RefundFromItemHoldValue = "Refund from Item Hold";
		CashOutValue = "Cash Out";
		AdjustmentByRobloxAdmin = "Adjustment By Roblox Admin";
		InGameAdImpressionPayoutValue = "In Game Ad Impression Payout";
		OrganicAcquisitionTargetedValue = "Organic Acquisition Targeted Payout";
		OrganicAcquisitionPromotedValue = "Organic Acquisition Promoted Payout";
		GroupRevenuePayoutValue = "Group Revenue Payout";
		EndorsedAssetRewardValue = "Endorsed Asset Reward";
		CSAdjustmentValue = "CS Adjustment";
		ContestValue = "Contest";
		SurveyWinnerValue = "Survey Winner";
		RetextureValue = "Retexture";
		AdvertisingPromotionValue = "Advertising Promotion";
		NewEmployeeValue = "New Employee";
		TestingValue = "Testing";
		AccountRestoresValue = "Account Restores";
		EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "TransactionOriginType", isNullCacheable: true);
		AmbassadorAwardID = Get(AmbassadorAwardValue).ID;
		BuildersClubSignupBonusID = Get(BuildersClubSignupBonusValue).ID;
		BuildersClubStipendID = Get(BuildersClubStipendValue).ID;
		BuildersClubStipendBonusID = Get(BuildersClubStipendBonusValue).ID;
		CurrencyPurchaseID = Get(CurrencyPurchaseValue).ID;
		CurrencyTradeID = Get(CurrencyTradeValue).ID;
		DailyLoginAwardID = Get(DailyLoginAwardValue).ID;
		MiscellaneousAdjustmentID = Get(MiscellaneousAdjustmentValue).ID;
		PlaceTrafficAwardID = Get(PlaceTrafficAwardValue).ID;
		SaleOfGoodsID = Get(SaleOfGoodsValue).ID;
		AffiliateSaleID = Get(AffiliateSaleValue).ID;
		TradeSystemTradeID = Get(TradeSystemTradeValue).ID;
		VideoRefundID = Get(VideoRefundValue).ID;
		AdjustmentByRobloxAdminID = Get(AdjustmentByRobloxAdmin).ID;
		RefundFromItemHoldID = Get(RefundFromItemHoldValue).ID;
		CashOutID = Get(CashOutValue).ID;
		InGameAdImpressionPayoutID = Get(InGameAdImpressionPayoutValue).ID;
		OrganicAcquisitionPromotedID = Get(OrganicAcquisitionPromotedValue).ID;
		OrganicAcquisitionTargetedID = Get(OrganicAcquisitionTargetedValue).ID;
		GroupRevenuePayoutID = Get(GroupRevenuePayoutValue).ID;
		EndorsedAssetRewardID = Get(EndorsedAssetRewardValue).ID;
		CSAdjustmentID = Get(CSAdjustmentValue).ID;
		ContestID = Get(ContestValue).ID;
		SurveyWinnerID = Get(SurveyWinnerValue).ID;
		RetextureID = Get(RetextureValue).ID;
		AdvertisingPromotionID = Get(AdvertisingPromotionValue).ID;
		NewEmployeeID = Get(NewEmployeeValue).ID;
		TestingID = Get(TestingValue).ID;
		AccountRestoresID = Get(AccountRestoresValue).ID;
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
			_EntityDAL.Updated = Created;
			_EntityDAL.Insert();
		}, delegate
		{
			_EntityDAL.Updated = DateTime.Now;
			_EntityDAL.Update();
		});
	}

	private static TransactionOriginType DoGet(byte id)
	{
		return EntityHelper.DoGet<byte, TransactionOriginTypeDAL, TransactionOriginType>(() => TransactionOriginTypeDAL.Get(id), id);
	}

	private static TransactionOriginType DoGet(string value)
	{
		return EntityHelper.DoGetByLookup<byte, TransactionOriginTypeDAL, TransactionOriginType>(() => TransactionOriginTypeDAL.Get(value), value);
	}

	public static TransactionOriginType Get(byte id)
	{
		return EntityHelper.GetEntityOld(EntityCacheInfo, id, () => DoGet(id));
	}

	public static TransactionOriginType Get(byte? id)
	{
		if (id.HasValue)
		{
			return Get(id.Value);
		}
		return null;
	}

	public static TransactionOriginType Get(string value)
	{
		return EntityHelper.GetEntityByLookupOld<byte, TransactionOriginType>(EntityCacheInfo, value, () => DoGet(value));
	}

	public static ICollection<TransactionOriginType> GetTransactionOriginTypesPaged(int startRowIndex, int maximumRows)
	{
		string collectionId = $"GetTransactionOriginTypesPaged_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.UnqualifiedNonExpiringCachePolicy, collectionId, () => TransactionOriginTypeDAL.GetTransactionOriginTypeIDsPaged(startRowIndex + 1, maximumRows), Get);
	}

	public static int GetTotalNumberOfTransactionOriginTypes()
	{
		return EntityHelper.GetEntityCount(EntityCacheInfo, CacheManager.UnqualifiedNonExpiringCachePolicy, "GetTotalNumberOfTransactionOriginTypes", TransactionOriginTypeDAL.GetTotalNumberOfTransactionOriginTypes);
	}

	public void Construct(TransactionOriginTypeDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		if (_EntityDAL != null)
		{
			yield return Value;
		}
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
