using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.Groups.Entities;

[ExcludeFromCodeCoverage]
internal class ClanMember : IRobloxEntity<long, ClanMemberDAL>, ICacheableObject<long>, ICacheableObject
{
	private ClanMemberDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), typeof(ClanMember).ToString(), isNullCacheable: true);

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

	public ClanMember()
	{
		_EntityDAL = new ClanMemberDAL();
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

	internal static ClanMember CreateNew(long groupid, long userid)
	{
		ClanMember clanMember = new ClanMember();
		clanMember.GroupID = groupid;
		clanMember.UserID = userid;
		clanMember.Save();
		return clanMember;
	}

	internal static ClanMember Get(long id)
	{
		return EntityHelper.GetEntity<long, ClanMemberDAL, ClanMember>(EntityCacheInfo, id, () => ClanMemberDAL.Get(id));
	}

	public static ClanMember GetByUserID(long userID)
	{
		return EntityHelper.GetEntityByLookup<long, ClanMemberDAL, ClanMember>(EntityCacheInfo, $"UserID:{userID}", () => ClanMemberDAL.GetClanMemberByUserID(userID));
	}

	public static IEnumerable<ClanMember> GetClanMembersByGroupID_Paged(long groupId, int startIndex, int maxRows)
	{
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"GroupID:{groupId}"), $"GetClanMembersByGroupID_Paged_GroupID:{groupId}_StartIndex:{startIndex}_MaxRows:{maxRows}", () => ClanMemberDAL.GetClanMemberIDsByGroupID_Paged(groupId, startIndex + 1, maxRows), Get);
	}

	public static int GetTotalNumberOfClanMembersByGroupID(long groupId)
	{
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"GroupID:{groupId}"), $"GetTotalNumberOfClanMembersByGroupID_GroupID:{groupId}", () => ClanMemberDAL.GetTotalNumberOfClanMembersByGroupID(groupId));
	}

	public void Construct(ClanMemberDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"UserID:{UserID}";
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken($"GroupID:{GroupID}");
	}
}
