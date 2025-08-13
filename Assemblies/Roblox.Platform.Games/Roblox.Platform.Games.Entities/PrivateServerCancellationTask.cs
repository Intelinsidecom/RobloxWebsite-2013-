using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.Games.Entities;

internal class PrivateServerCancellationTask : IRobloxEntity<long, PrivateServerCancellationTaskDAL>, ICacheableObject<long>, ICacheableObject
{
	private PrivateServerCancellationTaskDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(PrivateServerCancellationTask).ToString(), isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	internal long PrivateServerID
	{
		get
		{
			return _EntityDAL.PrivateServerID;
		}
		set
		{
			_EntityDAL.PrivateServerID = value;
		}
	}

	internal DateTime DueDate
	{
		get
		{
			return _EntityDAL.DueDate;
		}
		set
		{
			_EntityDAL.DueDate = value;
		}
	}

	internal DateTime? LeaseExpiration
	{
		get
		{
			return _EntityDAL.LeaseExpiration;
		}
		set
		{
			_EntityDAL.LeaseExpiration = value;
		}
	}

	internal Guid? WorkerID
	{
		get
		{
			return _EntityDAL.WorkerID;
		}
		set
		{
			_EntityDAL.WorkerID = value;
		}
	}

	internal DateTime? Completed
	{
		get
		{
			return _EntityDAL.Completed;
		}
		set
		{
			_EntityDAL.Completed = value;
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

	public PrivateServerCancellationTask()
	{
		_EntityDAL = new PrivateServerCancellationTaskDAL();
	}

	public PrivateServerCancellationTask(PrivateServerCancellationTaskDAL entityDal)
	{
		_EntityDAL = entityDal;
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

	internal static PrivateServerCancellationTask CreateNew(long privateServerId, DateTime dueDate)
	{
		PrivateServerCancellationTask privateServerCancellationTask = new PrivateServerCancellationTask();
		privateServerCancellationTask.PrivateServerID = privateServerId;
		privateServerCancellationTask.DueDate = dueDate;
		privateServerCancellationTask.Save();
		return privateServerCancellationTask;
	}

	internal static PrivateServerCancellationTask Get(long id)
	{
		return EntityHelper.GetEntity<long, PrivateServerCancellationTaskDAL, PrivateServerCancellationTask>(EntityCacheInfo, id, () => PrivateServerCancellationTaskDAL.Get(id));
	}

	internal static ICollection<PrivateServerCancellationTask> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.MultiGetEntity<long, PrivateServerCancellationTaskDAL, PrivateServerCancellationTask>(ids, EntityCacheInfo, PrivateServerCancellationTaskDAL.MultiGet);
	}

	public static ICollection<PrivateServerCancellationTask> LeaseTasks(Guid workerId, int leaseDurationInMinutes, int maxCount)
	{
		List<PrivateServerCancellationTask> entities = new List<PrivateServerCancellationTask>();
		foreach (long item in PrivateServerCancellationTaskDAL.LeaseTasks(workerId, leaseDurationInMinutes, maxCount))
		{
			PrivateServerCancellationTaskDAL entityDal = PrivateServerCancellationTaskDAL.Get(item);
			if (entityDal != null)
			{
				PrivateServerCancellationTask entity = new PrivateServerCancellationTask(entityDal);
				CacheManager.ProcessEntityChange(entity, StateChangeEventType.Modification);
				entities.Add(entity);
			}
		}
		return entities;
	}

	public void Construct(PrivateServerCancellationTaskDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield break;
	}
}
