using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.TwoStepVerification.Entities;

[ExcludeFromCodeCoverage]
internal class TwoStepVerificationSessionToken : IRobloxEntity<long, TwoStepVerificationSessionTokenDAL>, ICacheableObject<long>, ICacheableObject
{
	private TwoStepVerificationSessionTokenDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(TwoStepVerificationSessionToken).ToString(), isNullCacheable: true);

	public long ID => _EntityDAL.Id;

	internal long AccountId
	{
		get
		{
			return _EntityDAL.AccountId;
		}
		set
		{
			_EntityDAL.AccountId = value;
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

	internal DateTime Expiration
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

	public TwoStepVerificationSessionToken()
	{
		_EntityDAL = new TwoStepVerificationSessionTokenDAL();
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

	internal static TwoStepVerificationSessionToken CreateNew(long accountId, Guid token, DateTime expiration)
	{
		TwoStepVerificationSessionToken twoStepVerificationSessionToken = new TwoStepVerificationSessionToken();
		twoStepVerificationSessionToken.AccountId = accountId;
		twoStepVerificationSessionToken.Token = token;
		twoStepVerificationSessionToken.Expiration = expiration;
		twoStepVerificationSessionToken.Save();
		return twoStepVerificationSessionToken;
	}

	internal static TwoStepVerificationSessionToken Get(long id)
	{
		return EntityHelper.GetEntity<long, TwoStepVerificationSessionTokenDAL, TwoStepVerificationSessionToken>(EntityCacheInfo, id, () => TwoStepVerificationSessionTokenDAL.Get(id));
	}

	private static ICollection<TwoStepVerificationSessionToken> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.MultiGetEntity<long, TwoStepVerificationSessionTokenDAL, TwoStepVerificationSessionToken>(ids, EntityCacheInfo, TwoStepVerificationSessionTokenDAL.MultiGet);
	}

	internal static ICollection<TwoStepVerificationSessionToken> GetTwoStepVerificationSessionTokensByAccountIdPaged(long accountId, long startRowIndex, long maximumRows)
	{
		string collectionId = $"GetTwoStepVerificationSessionTokensByAccountIDPaged_AccountID:{accountId}_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy(GetLookupCacheKeysByAccountId(accountId)), collectionId, () => TwoStepVerificationSessionTokenDAL.GetTwoStepVerificationSessionTokenIDsByAccountIdPaged(accountId, startRowIndex + 1, maximumRows), MultiGet);
	}

	internal static TwoStepVerificationSessionToken GetByToken(Guid token)
	{
		return EntityHelper.GetEntityByLookup<long, TwoStepVerificationSessionTokenDAL, TwoStepVerificationSessionToken>(EntityCacheInfo, GetLookupCacheKeysByToken(token), () => TwoStepVerificationSessionTokenDAL.GetTwoStepVerificationSessionTokenByToken(token));
	}

	public void Construct(TwoStepVerificationSessionTokenDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return GetLookupCacheKeysByToken(Token);
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken(GetLookupCacheKeysByAccountId(AccountId));
	}

	private static string GetLookupCacheKeysByToken(Guid token)
	{
		return $"Token:{token}";
	}

	private static string GetLookupCacheKeysByAccountId(long accountID)
	{
		return $"AccountID:{accountID}";
	}
}
