using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;
using Roblox.Web.ElevatedActions.DAL;

namespace Roblox.Web.ElevatedActions.BLL;

public class ElevatedActionLog : IRobloxEntity<int, ElevatedActionLogDAL>, ICacheableObject<int>, ICacheableObject
{
	private ElevatedActionLogDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "Roblox.Web.ElevatedActions.BLL.ElevatedActionLog", isNullCacheable: true);

	public int ID => _EntityDAL.ID;

	public int ElevatedActionID
	{
		get
		{
			return _EntityDAL.ElevatedActionID;
		}
		set
		{
			_EntityDAL.ElevatedActionID = value;
		}
	}

	public long UserID
	{
		get
		{
			return _EntityDAL.UserID;
		}
		set
		{
			_EntityDAL.UserID = value;
		}
	}

	public int RoleSetID
	{
		get
		{
			return _EntityDAL.RoleSetID;
		}
		set
		{
			_EntityDAL.RoleSetID = value;
		}
	}

	public string LogData
	{
		get
		{
			return _EntityDAL.LogData;
		}
		set
		{
			_EntityDAL.LogData = value;
		}
	}

	public bool Success
	{
		get
		{
			return _EntityDAL.Success;
		}
		set
		{
			_EntityDAL.Success = value;
		}
	}

	public string IpAddress
	{
		get
		{
			return _EntityDAL.IpAddress;
		}
		set
		{
			_EntityDAL.IpAddress = value;
		}
	}

	public int BrowserTrackerID
	{
		get
		{
			return _EntityDAL.BrowserTrackerID;
		}
		set
		{
			_EntityDAL.BrowserTrackerID = value;
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

	public ElevatedActionLog()
	{
		_EntityDAL = new ElevatedActionLogDAL();
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

	public static ElevatedActionLog CreateNew(int elevatedActionId, long userId, int roleSetId, string logData, bool success, string ipAddress, int browserTrackerId)
	{
		ElevatedActionLog elevatedActionLog = new ElevatedActionLog();
		elevatedActionLog.ElevatedActionID = elevatedActionId;
		elevatedActionLog.UserID = userId;
		elevatedActionLog.RoleSetID = roleSetId;
		elevatedActionLog.LogData = logData;
		elevatedActionLog.Success = success;
		elevatedActionLog.IpAddress = ipAddress;
		elevatedActionLog.BrowserTrackerID = browserTrackerId;
		elevatedActionLog.Save();
		return elevatedActionLog;
	}

	public static ElevatedActionLog Get(int id)
	{
		return EntityHelper.GetEntity<int, ElevatedActionLogDAL, ElevatedActionLog>(EntityCacheInfo, id, () => ElevatedActionLogDAL.Get(id));
	}

	public void Construct(ElevatedActionLogDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield break;
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
