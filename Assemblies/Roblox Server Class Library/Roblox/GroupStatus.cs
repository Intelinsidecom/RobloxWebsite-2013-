using System;
using System.Collections.Generic;
using System.ComponentModel;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox;

public class GroupStatus : IEquatable<GroupStatus>, IRobloxEntity<long, GroupStatusDAL>, ICacheableObject<long>, ICacheableObject
{
	private GroupStatusDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "GroupStatus", isNullCacheable: true);

	[DataObjectField(true, true)]
	public long ID => _EntityDAL.ID;

	[DataObjectField(false, false, false)]
	public long GroupID
	{
		get
		{
			return _EntityDAL.GroupID;
		}
		internal set
		{
			_EntityDAL.GroupID = value;
		}
	}

	[DataObjectField(false)]
	public long PosterID
	{
		get
		{
			return _EntityDAL.PosterID;
		}
		internal set
		{
			_EntityDAL.PosterID = value;
		}
	}

	[DataObjectField(false, false, false)]
	public string Message
	{
		get
		{
			return _EntityDAL.Message;
		}
		internal set
		{
			_EntityDAL.Message = value;
		}
	}

	[DataObjectField(false)]
	public DateTime Updated => _EntityDAL.Updated;

	[DataObjectField(false)]
	public DateTime Created => _EntityDAL.Created;

	public CacheInfo CacheInfo => EntityCacheInfo;

	private GroupStatus(GroupStatusDAL dal)
	{
		_EntityDAL = dal;
	}

	public GroupStatus()
	{
		_EntityDAL = new GroupStatusDAL();
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
			_EntityDAL.Updated = Created;
			_EntityDAL.Insert();
		}, delegate
		{
			_EntityDAL.Updated = DateTime.Now;
			_EntityDAL.Update();
		});
	}

	internal static GroupStatus CreateNew(long PosterID, long groupId, string Message)
	{
		GroupStatus groupStatus = new GroupStatus();
		groupStatus.GroupID = groupId;
		groupStatus.PosterID = PosterID;
		groupStatus.Message = Message;
		groupStatus.Save();
		return groupStatus;
	}

	private static GroupStatus DoGetByGroupID(long groupId)
	{
		return EntityHelper.DoGetByLookup<long, GroupStatusDAL, GroupStatus>(() => GroupStatusDAL.GetByGroupID(groupId), null);
	}

	private static GroupStatus DoGet(long id)
	{
		return EntityHelper.DoGet<long, GroupStatusDAL, GroupStatus>(() => GroupStatusDAL.Get(id), id);
	}

	public static GroupStatus Get(long id)
	{
		return EntityHelper.GetEntityOld(EntityCacheInfo, id, () => DoGet(id));
	}

	public static GroupStatus Get(long? id)
	{
		if (id.HasValue)
		{
			return Get(id.Value);
		}
		return null;
	}

	public static GroupStatus GetGroupStatusByGroupID(long groupId)
	{
		_ = $"GetGroupStatusByGroupID_GroupID:{groupId}";
		return EntityHelper.GetEntityByLookupOld<long, GroupStatus>(EntityCacheInfo, $"GroupID:{groupId}", () => DoGetByGroupID(groupId));
	}

	public void Construct(GroupStatusDAL dal)
	{
		_EntityDAL = dal;
	}

	public bool Equals(GroupStatus other)
	{
		if (other == null)
		{
			return false;
		}
		return ID == other.ID;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		ICollection<string> idLookups = new List<string>();
		if (_EntityDAL != null)
		{
			idLookups.Add($"GroupID:{GroupID}");
		}
		return idLookups;
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		return new List<StateToken>();
	}

	/// <summary>
	/// Checks if the status appearing in Feeds for a particular user is out of date - if so, attempts to grab
	/// the freshest status for that user and place into Feeds
	/// </summary>
	/// <returns></returns>
	internal long UpdateFeed(long groupId, Feed f)
	{
		if (!string.IsNullOrEmpty(Message) && Message.Trim().Length > 0 && (f == null || f.ID == 0L || f.ActionDate < Updated))
		{
			f = new Feed();
			f.UserID = PosterID;
			f.ActionType = FeedType.Group.ID;
			f.ItemType = FeedType.Group.ID;
			f.ItemID = groupId;
			f.ActionDate = Updated;
			f.HarvestDate = DateTime.Now;
			f.Description = Message.Trim();
			f.Save();
		}
		return f.ID;
	}
}
