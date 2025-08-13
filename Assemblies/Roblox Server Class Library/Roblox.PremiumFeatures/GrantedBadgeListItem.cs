using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.PremiumFeatures;

public class GrantedBadgeListItem : IRobloxEntity<long, GrantedBadgeListItemDAL>, ICacheableObject<long>, ICacheableObject
{
	private GrantedBadgeListItemDAL _EntityDAL;

	internal static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "GrantedBadgeListItem", isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	internal byte GrantedBadgeListID
	{
		get
		{
			return _EntityDAL.GrantedBadgeListID;
		}
		set
		{
			_EntityDAL.GrantedBadgeListID = GrantedBadgeListID;
		}
	}

	public int BadgeTypeID
	{
		get
		{
			return _EntityDAL.BadgeTypeID;
		}
		set
		{
			_EntityDAL.BadgeTypeID = value;
		}
	}

	internal DateTime Created => _EntityDAL.Created;

	internal DateTime Updated => _EntityDAL.Updated;

	public CacheInfo CacheInfo => EntityCacheInfo;

	public GrantedBadgeListItem()
	{
		_EntityDAL = new GrantedBadgeListItemDAL();
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

	public static GrantedBadgeListItem Get(long id)
	{
		return EntityHelper.GetEntity<long, GrantedBadgeListItemDAL, GrantedBadgeListItem>(EntityCacheInfo, id, () => GrantedBadgeListItemDAL.Get(id));
	}

	internal static GrantedBadgeListItem Get(long? id)
	{
		if (id.HasValue)
		{
			return Get(id.Value);
		}
		return null;
	}

	internal static GrantedBadgeListItem GetByGrantedBadgeListIDAndBadgeTypeID(byte grantedBadgeListId, int badgeTypeId)
	{
		return EntityHelper.GetEntityByLookup<long, GrantedBadgeListItemDAL, GrantedBadgeListItem>(EntityCacheInfo, $"GrantedBadgeListID:{grantedBadgeListId}_BadgeTypeID:{badgeTypeId}", () => GrantedBadgeListItemDAL.GetByGrantedBadgeListIDAndBadgeTypeID(grantedBadgeListId, badgeTypeId));
	}

	public static ICollection<GrantedBadgeListItem> GetGrantedBadgeListItemsByGrantedBadgeListID(byte grantedBadgeListId)
	{
		string collectionId = $"GetGrantedBadgeListItemsByGrantedBadgeListID_GrantedBadgeListID:{grantedBadgeListId}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"GrantedBadgeListID:{grantedBadgeListId}"), collectionId, () => GrantedBadgeListItemDAL.GetGrantedBadgeListItemIDsByGrantedBadgeListID(grantedBadgeListId), Get);
	}

	public void Construct(GrantedBadgeListItemDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		if (_EntityDAL != null)
		{
			yield return $"GrantedBadgeListID:{GrantedBadgeListID}_BadgeTypeID:{BadgeTypeID}";
		}
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken($"GrantedBadgeListID:{GrantedBadgeListID}");
	}
}
