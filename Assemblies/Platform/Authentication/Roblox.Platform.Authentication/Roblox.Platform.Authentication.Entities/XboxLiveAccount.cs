using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;
using Roblox.Platform.Authentication.Properties;

namespace Roblox.Platform.Authentication.Entities;

public class XboxLiveAccount : IRobloxEntity<int, XboxLiveAccountDAL>, ICacheableObject<int>, ICacheableObject, IRemoteCacheableObject
{
	private XboxLiveAccountDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(XboxLiveAccount).ToString(), isNullCacheable: true);

	public int ID => _EntityDAL.ID;

	/// <summary>
	/// Roblox AccountId. Not Xbox AccountId
	/// </summary>
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

	internal string XboxLivePairwiseID
	{
		get
		{
			return _EntityDAL.XboxLivePairwiseID;
		}
		set
		{
			_EntityDAL.XboxLivePairwiseID = value;
		}
	}

	internal string XboxLiveGamerTagHash
	{
		get
		{
			return _EntityDAL.XboxLiveGamerTagHash;
		}
		set
		{
			_EntityDAL.XboxLiveGamerTagHash = value;
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

	public XboxLiveAccount()
	{
		_EntityDAL = new XboxLiveAccountDAL();
	}

	public XboxLiveAccount(XboxLiveAccountDAL xboxliveaccountDAL)
	{
		_EntityDAL = xboxliveaccountDAL;
	}

	internal void Delete()
	{
		if (Settings.Default.IsRemoteCacheEnabledForXboxLiveAccount)
		{
			EntityHelper.DeleteEntityWithRemoteCache(this, _EntityDAL.Delete);
		}
		else
		{
			EntityHelper.DeleteEntity(this, _EntityDAL.Delete);
		}
	}

	internal void Save()
	{
		if (Settings.Default.IsRemoteCacheEnabledForXboxLiveAccount)
		{
			EntityHelper.SaveEntityWithRemoteCache(this, delegate
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
		else
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
	}

	internal static XboxLiveAccount Get(int id)
	{
		return EntityHelper.GetEntity<int, XboxLiveAccountDAL, XboxLiveAccount>(EntityCacheInfo, id, () => XboxLiveAccountDAL.Get(id));
	}

	internal static ICollection<XboxLiveAccount> MultiGet(ICollection<int> ids)
	{
		return EntityHelper.MultiGetEntity<int, XboxLiveAccountDAL, XboxLiveAccount>(ids, EntityCacheInfo, XboxLiveAccountDAL.MultiGet);
	}

	public static XboxLiveAccount GetByAccountID(long accountID)
	{
		if (Settings.Default.IsRemoteCacheEnabledForXboxLiveAccount)
		{
			return EntityHelper.GetEntityByLookupWithRemoteCache<int, XboxLiveAccountDAL, XboxLiveAccount>(EntityCacheInfo, $"AccountID:{accountID}", () => XboxLiveAccountDAL.GetXboxLiveAccountByAccountID(accountID), Get);
		}
		return EntityHelper.GetEntityByLookup<int, XboxLiveAccountDAL, XboxLiveAccount>(EntityCacheInfo, $"AccountID:{accountID}", () => XboxLiveAccountDAL.GetXboxLiveAccountByAccountID(accountID));
	}

	public static XboxLiveAccount GetByXboxLivePairwiseID(string xboxLivePairwiseID)
	{
		return EntityHelper.GetEntityByLookup<int, XboxLiveAccountDAL, XboxLiveAccount>(EntityCacheInfo, $"XboxLivePairwiseID:{xboxLivePairwiseID}", () => XboxLiveAccountDAL.GetXboxLiveAccountByXboxLivePairwiseID(xboxLivePairwiseID));
	}

	public static ICollection<XboxLiveAccount> GetXboxLiveAccountsByXboxLiveGamerTagHash(string xboxLiveGamerTagHash, int count, int exclusiveStartXboxLiveAccountId)
	{
		string collectionId = $"GetXboxLiveAccountsByXboxLiveGamerTagHash_XboxLiveGamerTagHash:{xboxLiveGamerTagHash}_Count:{count}_ExclusiveStartXboxLiveAccountID:{exclusiveStartXboxLiveAccountId}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy($"XboxLiveGamerTagHash:{xboxLiveGamerTagHash}"), collectionId, () => XboxLiveAccountDAL.GetXboxLiveAccountIDsByXboxLiveGamerTagHash(xboxLiveGamerTagHash, count, exclusiveStartXboxLiveAccountId), MultiGet);
	}

	public void Construct(XboxLiveAccountDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"AccountID:{AccountID}";
		yield return $"XboxLivePairwiseID:{XboxLivePairwiseID}";
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken($"XboxLiveGamerTagHash:{XboxLiveGamerTagHash}");
	}
}
