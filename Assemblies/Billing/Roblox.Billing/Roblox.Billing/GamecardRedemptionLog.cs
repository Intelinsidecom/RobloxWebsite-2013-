using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Billing;

public class GamecardRedemptionLog : IRobloxEntity<int, GamecardRedemptionLogDAL>, ICacheableObject<int>, ICacheableObject
{
	private GamecardRedemptionLogDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "Roblox.Billing.GamecardRedemptionLog", isNullCacheable: true);

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

	public byte MerchantID
	{
		get
		{
			return _EntityDAL.MerchantID;
		}
		set
		{
			_EntityDAL.MerchantID = value;
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

	public string CardPIN
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

	public GamecardRedemptionLog()
	{
		_EntityDAL = new GamecardRedemptionLogDAL();
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

	public static GamecardRedemptionLog CreateNew(long accountid, byte merchantid, decimal cardvalue, string cardpin)
	{
		GamecardRedemptionLog gamecardRedemptionLog = new GamecardRedemptionLog();
		gamecardRedemptionLog.AccountID = accountid;
		gamecardRedemptionLog.MerchantID = merchantid;
		gamecardRedemptionLog.CardValue = cardvalue;
		gamecardRedemptionLog.CardPIN = cardpin;
		gamecardRedemptionLog.Save();
		return gamecardRedemptionLog;
	}

	public static GamecardRedemptionLog Get(int id)
	{
		return EntityHelper.GetEntity<int, GamecardRedemptionLogDAL, GamecardRedemptionLog>(EntityCacheInfo, id, () => GamecardRedemptionLogDAL.Get(id));
	}

	public static ICollection<GamecardRedemptionLog> GetByCardPin(string CardPIN)
	{
		if (string.IsNullOrWhiteSpace(CardPIN))
		{
			throw new ApplicationException("Required value not specified: CardPIN.");
		}
		string collectionId = $"GetGamecardRedemptionLogsByCardPIN_CardPIN:{CardPIN}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"CardPIN:{CardPIN}"), collectionId, () => GamecardRedemptionLogDAL.GetGamecardRedemptionLogIDsByCardPIN(CardPIN), Get);
	}

	public static bool HasPreviousTransactions(string CardPIN)
	{
		if (string.IsNullOrWhiteSpace(CardPIN))
		{
			throw new ApplicationException("Required value not specified: CardPin.");
		}
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"CardPIN:{CardPIN}"), $"GamecardRedemptionLog_GetLogCountByCardPin:{CardPIN}", () => GamecardRedemptionLogDAL.GetLogCountByPin(CardPIN)) != 0;
	}

	/// <summary>
	/// This method returns the latest COUNT number of GamecardRedemptionLogs
	/// </summary>
	public static ICollection<GamecardRedemptionLog> GetByAccountID(int count, long accountID)
	{
		if (accountID == 0L)
		{
			throw new ApplicationException("Required value not specified: AccountID.");
		}
		string collectionId = $"GetGamecardRedemptionLogIDsByAccountID_Count:{count}_AccountID:{accountID}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"AccountID:{accountID}"), collectionId, () => GamecardRedemptionLogDAL.GetGamecardRedemptionLogIDsByAccountID(count, accountID), Get);
	}

	public void Construct(GamecardRedemptionLogDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield break;
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken($"MerchantID:{MerchantID}");
		yield return new StateToken($"CardPIN:{CardPIN}");
	}
}
