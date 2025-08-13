using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Moderation;

public class UserModerationNote : IRobloxEntity<long, UserModerationNoteDAL>, ICacheableObject<long>, ICacheableObject
{
	private UserModerationNoteDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "Roblox.Moderation.UserModerationNote", isNullCacheable: true);

	public long ID => _EntityDAL.ID;

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

	public long ModeratorID
	{
		get
		{
			return _EntityDAL.ModeratorID;
		}
		set
		{
			_EntityDAL.ModeratorID = value;
		}
	}

	public string Value
	{
		get
		{
			return _EntityDAL.Value;
		}
		set
		{
			_EntityDAL.Value = value;
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

	public UserModerationNote()
	{
		_EntityDAL = new UserModerationNoteDAL();
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

	public static UserModerationNote CreateNew(long userId, long moderatorId, string value)
	{
		UserModerationNote userModerationNote = new UserModerationNote();
		userModerationNote.UserID = userId;
		userModerationNote.ModeratorID = moderatorId;
		userModerationNote.Value = value;
		userModerationNote.Save();
		return userModerationNote;
	}

	public static UserModerationNote Get(long id)
	{
		return EntityHelper.GetEntity<long, UserModerationNoteDAL, UserModerationNote>(EntityCacheInfo, id, () => UserModerationNoteDAL.Get(id));
	}

	public void Delete()
	{
		EntityHelper.DeleteEntity(this, _EntityDAL.Delete);
	}

	public static ICollection<UserModerationNote> GetUserModerationNotesByUserID(long userID)
	{
		string collectionId = $"GetUserModerationNotes_UserID:{userID}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, null, collectionId, () => UserModerationNoteDAL.GetUserModerationNoteIDsByUserID(userID), Get);
	}

	public void Construct(UserModerationNoteDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		if (_EntityDAL != null)
		{
			yield return $"UserID:{UserID}";
		}
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
