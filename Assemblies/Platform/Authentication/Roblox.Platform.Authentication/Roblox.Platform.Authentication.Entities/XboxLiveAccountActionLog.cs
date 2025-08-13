using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.Authentication.Entities;

internal class XboxLiveAccountActionLog : IRobloxEntity<long, XboxLiveAccountActionLogDAL>, ICacheableObject<long>, ICacheableObject
{
	private XboxLiveAccountActionLogDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: false, hasUnqualifiedCollections: false), typeof(XboxLiveAccountActionLog).ToString(), isNullCacheable: true);

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

	internal byte XboxLiveAccountActionTypeID
	{
		get
		{
			return _EntityDAL.XboxLiveAccountActionTypeID;
		}
		set
		{
			_EntityDAL.XboxLiveAccountActionTypeID = value;
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

	public XboxLiveAccountActionLog()
	{
		_EntityDAL = new XboxLiveAccountActionLogDAL();
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

	internal static XboxLiveAccountActionLog CreateNew(long accountId, byte xboxLiveAccountActionTypeId, string xboxLivePairwiseId, string xboxLiveGamerTagHash)
	{
		XboxLiveAccountActionLog xboxLiveAccountActionLog = new XboxLiveAccountActionLog();
		xboxLiveAccountActionLog.AccountID = accountId;
		xboxLiveAccountActionLog.XboxLiveAccountActionTypeID = xboxLiveAccountActionTypeId;
		xboxLiveAccountActionLog.XboxLivePairwiseID = xboxLivePairwiseId;
		xboxLiveAccountActionLog.XboxLiveGamerTagHash = xboxLiveGamerTagHash;
		xboxLiveAccountActionLog.Save();
		return xboxLiveAccountActionLog;
	}

	internal static XboxLiveAccountActionLog Get(long id)
	{
		return EntityHelper.GetEntity<long, XboxLiveAccountActionLogDAL, XboxLiveAccountActionLog>(EntityCacheInfo, id, () => XboxLiveAccountActionLogDAL.Get(id));
	}

	internal static ICollection<XboxLiveAccountActionLog> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.MultiGetEntity<long, XboxLiveAccountActionLogDAL, XboxLiveAccountActionLog>(ids, EntityCacheInfo, XboxLiveAccountActionLogDAL.MultiGet);
	}

	internal static ICollection<XboxLiveAccountActionLog> GetXboxLiveAccountActionLogsByAccountID(long accountID, int count, long exclusiveStartXboxLiveAccountActionLogId)
	{
		string collectionId = $"GetXboxLiveAccountActionLogsByAccountID_AccountID:{accountID}_Count:{count}_ExclusiveStartXboxLiveAccountActionLogID:{exclusiveStartXboxLiveAccountActionLogId}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy($"AccountID:{accountID}"), collectionId, () => XboxLiveAccountActionLogDAL.GetXboxLiveAccountActionLogIDsByAccountID(accountID, count, exclusiveStartXboxLiveAccountActionLogId), MultiGet);
	}

	internal static ICollection<XboxLiveAccountActionLog> GetXboxLiveAccountActionLogsByAccountIDAndXboxLiveAccountActionTypeID(long accountID, byte xboxLiveAccountActionTypeID, int count, long exclusiveStartXboxLiveAccountActionLogId)
	{
		string collectionId = $"GetXboxLiveAccountActionLogsByAccountIDAndXboxLiveAccountActionTypeID_AccountID:{accountID}_XboxLiveAccountActionTypeID:{xboxLiveAccountActionTypeID}_Count:{count}_ExclusiveStartXboxLiveAccountActionLogID:{exclusiveStartXboxLiveAccountActionLogId}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy($"AccountID:{accountID}_XboxLiveAccountActionTypeID:{xboxLiveAccountActionTypeID}"), collectionId, () => XboxLiveAccountActionLogDAL.GetXboxLiveAccountActionLogIDsByAccountIDAndXboxLiveAccountActionTypeID(accountID, xboxLiveAccountActionTypeID, count, exclusiveStartXboxLiveAccountActionLogId), MultiGet);
	}

	public void Construct(XboxLiveAccountActionLogDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield break;
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken($"AccountID:{AccountID}");
		yield return new StateToken($"AccountID:{AccountID}_XboxLiveAccountActionTypeID:{XboxLiveAccountActionTypeID}");
	}
}
