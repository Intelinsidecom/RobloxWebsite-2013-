using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.Authentication.AccountSecurityTickets.Entities;

public class AccountSecurityTicketItem : IRobloxEntity<long, AccountSecurityTicketItemDAL>, ICacheableObject<long>, ICacheableObject, IRemoteCacheableObject
{
	private AccountSecurityTicketItemDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(AccountSecurityTicketItem).ToString(), isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	internal long AccountSecurityTicketID
	{
		get
		{
			return _EntityDAL.AccountSecurityTicketID;
		}
		set
		{
			_EntityDAL.AccountSecurityTicketID = value;
		}
	}

	internal short AccountSecurityTypeID
	{
		get
		{
			return _EntityDAL.AccountSecurityTypeID;
		}
		set
		{
			_EntityDAL.AccountSecurityTypeID = value;
		}
	}

	internal long AccountSecurityTargetID
	{
		get
		{
			return _EntityDAL.AccountSecurityTargetID;
		}
		set
		{
			_EntityDAL.AccountSecurityTargetID = value;
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

	public AccountSecurityTicketItem()
	{
		_EntityDAL = new AccountSecurityTicketItemDAL();
	}

	public AccountSecurityTicketItem(AccountSecurityTicketItemDAL entityDAL)
	{
		_EntityDAL = entityDAL;
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

	internal static AccountSecurityTicketItem Get(long id)
	{
		return EntityHelper.GetEntity<long, AccountSecurityTicketItemDAL, AccountSecurityTicketItem>(EntityCacheInfo, id, () => AccountSecurityTicketItemDAL.Get(id));
	}

	private static ICollection<AccountSecurityTicketItem> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.MultiGetEntity<long, AccountSecurityTicketItemDAL, AccountSecurityTicketItem>(ids, EntityCacheInfo, AccountSecurityTicketItemDAL.MultiGet);
	}

	internal static ICollection<AccountSecurityTicketItem> GetAccountSecurityTicketItemsByAccountSecurityTicketID(long accountSecurityTicketId, int count, long exclusiveStartAccountSecurityTicketItemId)
	{
		string collectionId = $"GetAccountSecurityTicketItemsByAccountSecurityTicketID_AccountSecurityTicketID:{accountSecurityTicketId}_Count:{count}_ExclusiveStartAccountSecurityTicketItemID:{exclusiveStartAccountSecurityTicketItemId}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy(GetLookupCacheKeysByAccountSecurityTicketID(accountSecurityTicketId)), collectionId, () => AccountSecurityTicketItemDAL.GetAccountSecurityTicketItemIDsByAccountSecurityTicketID(accountSecurityTicketId, count, exclusiveStartAccountSecurityTicketItemId), MultiGet);
	}

	public static int GetTotalNumberOfAccountSecurityTicketItemsByAccountSecurityTicketId(long accountSecurityTicketId)
	{
		string countId = $"GetTotalNumberOfAccountSecurityTicketItemsByAccountSecurityTicketId_AccountSecurityTicketID:{accountSecurityTicketId}";
		return EntityHelper.GetEntityCount(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy(GetLookupCacheKeysByAccountSecurityTicketID(accountSecurityTicketId)), countId, () => AccountSecurityTicketItemDAL.GetTotalNumberOfAccountSecurityTicketItemsByAccountSecurityTicketID(accountSecurityTicketId));
	}

	public void Construct(AccountSecurityTicketItemDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield break;
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken(GetLookupCacheKeysByAccountSecurityTicketID(AccountSecurityTicketID));
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}

	private static string GetLookupCacheKeysByValue(string value)
	{
		return $"Value:{value}";
	}

	private static string GetLookupCacheKeysByAccountIDIsValid(long accountId, bool isValid)
	{
		return $"AccountID:{accountId}_IsValid:{isValid}";
	}

	private static string GetLookupCacheKeysByAccountSecurityTicketID(long accountSecurityTicketId)
	{
		return $"AccountSecurityTicketID:{accountSecurityTicketId}";
	}
}
