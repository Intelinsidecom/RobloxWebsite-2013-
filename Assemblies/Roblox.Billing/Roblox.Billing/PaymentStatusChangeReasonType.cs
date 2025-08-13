using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Billing;

public class PaymentStatusChangeReasonType : IRobloxEntity<byte, PaymentStatusChangeReasonTypeDAL>, ICacheableObject<byte>, ICacheableObject
{
	private PaymentStatusChangeReasonTypeDAL _EntityDAL;

	public static readonly PaymentStatusChangeReasonType Technical;

	public static readonly PaymentStatusChangeReasonType Clerical;

	public static readonly PaymentStatusChangeReasonType Quality;

	public static readonly PaymentStatusChangeReasonType Fraud;

	public static readonly PaymentStatusChangeReasonType DeclinedCardByUserFloodchecker;

	public static readonly PaymentStatusChangeReasonType DeclinedCardByIPFloodchecker;

	public static readonly PaymentStatusChangeReasonType PurchaseLimitCheckEmailAddressMonthly;

	public static readonly PaymentStatusChangeReasonType PurchaseLimitCheckNewUserAccount;

	public static readonly PaymentStatusChangeReasonType PurchaseLimitCheckIPDaily;

	public static readonly PaymentStatusChangeReasonType PurchaseLimitCheckIPMonthly;

	public static readonly PaymentStatusChangeReasonType PurchaseLimitCheckCreditCardDaily;

	public static readonly PaymentStatusChangeReasonType PurchaseLimitCheckCreditCardMonthly;

	public static readonly PaymentStatusChangeReasonType PurchaseLimitCheckUserAccountDaily;

	public static readonly PaymentStatusChangeReasonType PurchaseLimitCheckUserAccountMonthly;

	public static readonly PaymentStatusChangeReasonType DoublePurchaseCheckUserAccount;

	public static readonly PaymentStatusChangeReasonType PurchaseCountCheckCreditCardDaily;

	public static readonly PaymentStatusChangeReasonType DeclinedByFraudDetector;

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

	public PaymentStatusChangeReasonType()
	{
		_EntityDAL = new PaymentStatusChangeReasonTypeDAL();
	}

	static PaymentStatusChangeReasonType()
	{
		EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(PaymentStatusChangeReasonType).ToString(), isNullCacheable: true);
		Technical = GetByValue("Technical");
		Clerical = GetByValue("Clerical");
		Quality = GetByValue("Quality");
		Fraud = GetByValue("Fraud");
		DeclinedCardByUserFloodchecker = GetByValue("DeclinedCardByUserFloodchecker");
		DeclinedCardByIPFloodchecker = GetByValue("DeclinedCardByIPFloodchecker");
		PurchaseLimitCheckEmailAddressMonthly = GetByValue("PurchaseLimitCheckEmailAddressMonthly");
		PurchaseLimitCheckNewUserAccount = GetByValue("PurchaseLimitCheckNewUserAccount");
		PurchaseLimitCheckIPDaily = GetByValue("PurchaseLimitCheckIPDaily");
		PurchaseLimitCheckIPMonthly = GetByValue("PurchaseLimitCheckIPMonthly");
		PurchaseLimitCheckCreditCardDaily = GetByValue("PurchaseLimitCheckCreditCardDaily");
		PurchaseLimitCheckCreditCardMonthly = GetByValue("PurchaseLimitCheckCreditCardMonthly");
		PurchaseLimitCheckUserAccountDaily = GetByValue("PurchaseLimitCheckUserAccountDaily");
		PurchaseLimitCheckUserAccountMonthly = GetByValue("PurchaseLimitCheckUserAccountMonthly");
		DoublePurchaseCheckUserAccount = GetByValue("DoublePurchaseCheckUserAccount");
		PurchaseCountCheckCreditCardDaily = GetByValue("PurchaseCountCheckCreditCardDaily");
		DeclinedByFraudDetector = GetByValue("DeclinedByFraudDetector");
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

	private static PaymentStatusChangeReasonType CreateNew(string value)
	{
		PaymentStatusChangeReasonType paymentStatusChangeReasonType = new PaymentStatusChangeReasonType();
		paymentStatusChangeReasonType.Value = value;
		paymentStatusChangeReasonType.Save();
		return paymentStatusChangeReasonType;
	}

	public static PaymentStatusChangeReasonType Get(byte id)
	{
		return EntityHelper.GetEntity<byte, PaymentStatusChangeReasonTypeDAL, PaymentStatusChangeReasonType>(EntityCacheInfo, id, () => PaymentStatusChangeReasonTypeDAL.Get(id));
	}

	internal static PaymentStatusChangeReasonType GetByValue(string value)
	{
		return EntityHelper.GetEntityByLookup<byte, PaymentStatusChangeReasonTypeDAL, PaymentStatusChangeReasonType>(EntityCacheInfo, $"Value:{value}", () => PaymentStatusChangeReasonTypeDAL.GetByValue(value));
	}

	public void Construct(PaymentStatusChangeReasonTypeDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"Value:{Value}";
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
