using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.Authentication.Entities;

internal class SessionToken : IRobloxEntity<long, SessionTokenDAL>, ICacheableObject<long>, ICacheableObject, IRemoteCacheableObject
{
	private SessionTokenDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(SessionToken).ToString(), isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	internal long AccountID
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

	internal Guid Token
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

	internal DateTime? Updated
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

	internal DateTime? Expiration
	{
		get
		{
			return _EntityDAL.Expiration;
		}
		set
		{
			_EntityDAL.Expiration = value;
		}
	}

	public CacheInfo CacheInfo => EntityCacheInfo;

	public SessionToken()
	{
		_EntityDAL = new SessionTokenDAL();
	}

	public SessionToken(SessionTokenDAL entityDAL)
	{
		_EntityDAL = entityDAL;
	}

	internal void Delete()
	{
		EntityHelper.DeleteEntityWithRemoteCache(this, _EntityDAL.Delete);
	}

	internal void Save()
	{
		EntityHelper.SaveEntityWithRemoteCache(this, delegate
		{
			_EntityDAL.Created = DateTime.Now;
			_EntityDAL.Updated = DateTime.Now;
			_EntityDAL.Insert();
		}, delegate
		{
			_EntityDAL.Updated = DateTime.Now;
			_EntityDAL.Update();
		});
	}

	internal static SessionToken CreateNew(long accountId, Guid token, DateTime expiration)
	{
		SessionToken sessionToken = new SessionToken();
		sessionToken.AccountID = accountId;
		sessionToken.Token = token;
		sessionToken.Expiration = expiration;
		sessionToken.Save();
		return sessionToken;
	}

	internal static SessionToken Get(long id)
	{
		return EntityHelper.GetEntity<long, SessionTokenDAL, SessionToken>(EntityCacheInfo, id, () => SessionTokenDAL.Get(id));
	}

	internal static SessionToken GetByToken(Guid token)
	{
		return EntityHelper.GetEntityByLookupWithRemoteCache<long, SessionTokenDAL, SessionToken>(EntityCacheInfo, "Token:" + token, () => SessionTokenDAL.GetByToken(token), Get);
	}

	internal static ICollection<SessionToken> GetSessionTokensByAccountID_Paged(long accountId, int startRowIndex, int maximumRows)
	{
		string collectionId = $"GetSessionTokensByAccountID_Paged_AccountID:{accountId}_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"AccountID:{accountId}"), collectionId, () => SessionTokenDAL.GetSessionTokensByAccountID_Paged(accountId, startRowIndex + 1, maximumRows), Get);
	}

	public void Construct(SessionTokenDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return "Token:" + Token;
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken($"AccountID:{AccountID}");
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}
}
