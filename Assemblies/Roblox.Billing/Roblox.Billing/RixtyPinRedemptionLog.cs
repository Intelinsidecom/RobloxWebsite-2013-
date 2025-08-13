using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Billing;

public class RixtyPinRedemptionLog : IRobloxEntity<int, RixtyPinRedemptionLogDAL>, ICacheableObject<int>, ICacheableObject
{
	private RixtyPinRedemptionLogDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "Roblox.Billing.RixtyPinRedemptionLog", isNullCacheable: true);

	public int ID => _EntityDAL.ID;

	public long AccountID
	{
		get
		{
			return _EntityDAL.AccountID;
		}
		set
		{
			_EntityDAL.AccountID = value;
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

	public string TransactionID
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

	public decimal CardValue
	{
		get
		{
			return _EntityDAL.CardValue;
		}
		set
		{
			_EntityDAL.CardValue = value;
		}
	}

	public long CardPIN
	{
		get
		{
			return _EntityDAL.CardPIN;
		}
		set
		{
			_EntityDAL.CardPIN = value;
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

	public RixtyPinRedemptionLog()
	{
		_EntityDAL = new RixtyPinRedemptionLogDAL();
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

	public static RixtyPinRedemptionLog CreateNew(long accountId, byte paymentStatusTypeId, string transactionId, decimal cardValue, long cardPin)
	{
		RixtyPinRedemptionLog rixtyPinRedemptionLog = new RixtyPinRedemptionLog();
		rixtyPinRedemptionLog.AccountID = accountId;
		rixtyPinRedemptionLog.PaymentStatusTypeID = paymentStatusTypeId;
		rixtyPinRedemptionLog.TransactionID = transactionId;
		rixtyPinRedemptionLog.CardValue = cardValue;
		rixtyPinRedemptionLog.CardPIN = cardPin;
		rixtyPinRedemptionLog.Save();
		return rixtyPinRedemptionLog;
	}

	public static RixtyPinRedemptionLog CreateNew(long accountId, byte paymentStatusTypeId, string transactionId, decimal cardValue, string cardPin)
	{
		long pinNumber = long.Parse(new Regex("\\D").Replace(cardPin, ""));
		return CreateNew(accountId, paymentStatusTypeId, transactionId, cardValue, pinNumber);
	}

	public static RixtyPinRedemptionLog Get(int id)
	{
		return EntityHelper.GetEntity<int, RixtyPinRedemptionLogDAL, RixtyPinRedemptionLog>(EntityCacheInfo, id, () => RixtyPinRedemptionLogDAL.Get(id));
	}

	public static RixtyPinRedemptionLog GetByCardPIN(long cardPin)
	{
		return EntityHelper.DoGetByLookup<int, RixtyPinRedemptionLogDAL, RixtyPinRedemptionLog>(() => RixtyPinRedemptionLogDAL.GetByCardPIN(cardPin), $"CardPIN:{cardPin}");
	}

	public static RixtyPinRedemptionLog GetByCardPIN(string cardPin)
	{
		return GetByCardPIN(long.Parse(new Regex("\\D").Replace(cardPin, "")));
	}

	public void Construct(RixtyPinRedemptionLogDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield break;
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken($"CardPIN:{CardPIN}");
	}
}
