using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.Groups.Entities;

[ExcludeFromCodeCoverage]
internal class ClanInvitation : IRobloxEntity<long, ClanInvitationDAL>, ICacheableObject<long>, ICacheableObject
{
	private ClanInvitationDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), typeof(ClanInvitation).ToString(), isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	internal long GroupID
	{
		get
		{
			return _EntityDAL.GroupID;
		}
		set
		{
			_EntityDAL.GroupID = value;
		}
	}

	internal long UserID
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

	public CacheInfo CacheInfo => EntityCacheInfo;

	public ClanInvitation()
	{
		_EntityDAL = new ClanInvitationDAL();
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
			_EntityDAL.Insert();
		}, delegate
		{
			_EntityDAL.Update();
		});
	}

	internal static ClanInvitation CreateNew(long groupid, long userid)
	{
		ClanInvitation clanInvitation = new ClanInvitation();
		clanInvitation.GroupID = groupid;
		clanInvitation.UserID = userid;
		clanInvitation.Save();
		return clanInvitation;
	}

	internal static ClanInvitation Get(long id)
	{
		return EntityHelper.GetEntity<long, ClanInvitationDAL, ClanInvitation>(EntityCacheInfo, id, () => ClanInvitationDAL.Get(id));
	}

	public static ClanInvitation GetByGroupIDUserID(long groupID, long userID)
	{
		return EntityHelper.GetEntityByLookup<long, ClanInvitationDAL, ClanInvitation>(EntityCacheInfo, $"GroupID:{groupID}_UserID:{userID}", () => ClanInvitationDAL.GetClanInvitationByGroupIDUserID(groupID, userID));
	}

	public static IEnumerable<ClanInvitation> GetClanInvitationsByGroupID_Paged(long groupId, int startIndex, int maxRows)
	{
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"GroupID:{groupId}"), $"GetClanInvitationsByGroupID_Paged_GroupID:{groupId}_StartIndex:{startIndex}_MaxRows:{maxRows}", () => ClanInvitationDAL.GetClanInvitationIDsByGroupID_Paged(groupId, startIndex + 1, maxRows), Get);
	}

	public static int GetTotalNumberOfClanInvitationsByGroupID(long groupId)
	{
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"GroupID:{groupId}"), $"GetTotalNumberOfClanInvitationsByGroupID_GroupID:{groupId}", () => ClanInvitationDAL.GetTotalNumberOfClanInvitationsByGroupID(groupId));
	}

	public void Construct(ClanInvitationDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"GroupID:{GroupID}_UserID:{UserID}";
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken($"GroupID:{GroupID}");
	}
}
