using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.Games.Entities;

internal class PrivateServerCancellationTaskStatus : IRobloxEntity<long, PrivateServerCancellationTaskStatusDAL>, ICacheableObject<long>, ICacheableObject
{
	private PrivateServerCancellationTaskStatusDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(PrivateServerCancellationTaskStatus).ToString(), isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	internal long PrivateServerCancellationTaskID
	{
		get
		{
			return _EntityDAL.PrivateServerCancellationTaskID;
		}
		set
		{
			_EntityDAL.PrivateServerCancellationTaskID = value;
		}
	}

	internal int PrivateServerCancellationTaskStatusTypeID
	{
		get
		{
			return _EntityDAL.PrivateServerCancellationTaskStatusTypeID;
		}
		set
		{
			_EntityDAL.PrivateServerCancellationTaskStatusTypeID = value;
		}
	}

	internal string Reason
	{
		get
		{
			return _EntityDAL.Reason;
		}
		set
		{
			_EntityDAL.Reason = value;
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

	public PrivateServerCancellationTaskStatus()
	{
		_EntityDAL = new PrivateServerCancellationTaskStatusDAL();
	}

	public PrivateServerCancellationTaskStatus(PrivateServerCancellationTaskStatusDAL entityDAL)
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

	internal static PrivateServerCancellationTaskStatus CreateNew(long privateServerCancellationTaskId, int privateServerCancellationTaskStatusTypeId, string reason)
	{
		PrivateServerCancellationTaskStatus privateServerCancellationTaskStatus = new PrivateServerCancellationTaskStatus();
		privateServerCancellationTaskStatus.PrivateServerCancellationTaskID = privateServerCancellationTaskId;
		privateServerCancellationTaskStatus.PrivateServerCancellationTaskStatusTypeID = privateServerCancellationTaskStatusTypeId;
		privateServerCancellationTaskStatus.Reason = reason;
		privateServerCancellationTaskStatus.Save();
		return privateServerCancellationTaskStatus;
	}

	internal static PrivateServerCancellationTaskStatus Get(long id)
	{
		return EntityHelper.GetEntity<long, PrivateServerCancellationTaskStatusDAL, PrivateServerCancellationTaskStatus>(EntityCacheInfo, id, () => PrivateServerCancellationTaskStatusDAL.Get(id));
	}

	private static ICollection<PrivateServerCancellationTaskStatus> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.MultiGetEntity<long, PrivateServerCancellationTaskStatusDAL, PrivateServerCancellationTaskStatus>(ids, EntityCacheInfo, PrivateServerCancellationTaskStatusDAL.MultiGet);
	}

	public static PrivateServerCancellationTaskStatus GetOrCreate(long privateServerCancellationTaskId)
	{
		return EntityHelper.GetOrCreateEntity<long, PrivateServerCancellationTaskStatus>(EntityCacheInfo, GetLookupCacheKeysByPrivateServerCancellationTaskID(privateServerCancellationTaskId), () => DoGetOrCreate(privateServerCancellationTaskId));
	}

	private static PrivateServerCancellationTaskStatus DoGetOrCreate(long privateServerCancellationTaskId)
	{
		return EntityHelper.DoGetOrCreate<long, PrivateServerCancellationTaskStatusDAL, PrivateServerCancellationTaskStatus>(() => PrivateServerCancellationTaskStatusDAL.GetOrCreatePrivateServerCancellationTaskStatus(privateServerCancellationTaskId));
	}

	public void Construct(PrivateServerCancellationTaskStatusDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return GetLookupCacheKeysByPrivateServerCancellationTaskID(PrivateServerCancellationTaskID);
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}

	private static string GetLookupCacheKeysByPrivateServerCancellationTaskID(long privateServerCancellationTaskId)
	{
		return $"PrivateServerCancellationTaskID:{privateServerCancellationTaskId}";
	}
}
