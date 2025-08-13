using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Web.Games;

[DataContract]
internal class BadgeAssetAward : IRobloxEntity<int, BadgeAssetAwardDAL>, ICacheableObject<int>, ICacheableObject
{
	private BadgeAssetAwardDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "Roblox.Web.Games.BadgeAssetAward", isNullCacheable: true);

	[DataMember]
	public int ID
	{
		get
		{
			return _EntityDAL.ID;
		}
		private set
		{
		}
	}

	[DataMember]
	public long BadgeID
	{
		get
		{
			return _EntityDAL.BadgeID;
		}
		set
		{
			_EntityDAL.BadgeID = value;
		}
	}

	[DataMember]
	public long AssetAwardID
	{
		get
		{
			return _EntityDAL.AssetAwardID;
		}
		set
		{
			_EntityDAL.AssetAwardID = value;
		}
	}

	[DataMember]
	public string Description
	{
		get
		{
			return _EntityDAL.Description;
		}
		set
		{
			_EntityDAL.Description = value;
		}
	}

	[DataMember]
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

	[DataMember]
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

	public BadgeAssetAward()
	{
		_EntityDAL = new BadgeAssetAwardDAL();
	}

	public void Save()
	{
		EntityHelper.SaveEntity(this, delegate
		{
			_EntityDAL.Created = DateTime.Now;
			_EntityDAL.Updated = Created;
			_EntityDAL.Description = Description;
			_EntityDAL.Insert();
		}, delegate
		{
			_EntityDAL.Updated = DateTime.Now;
			_EntityDAL.Update();
		});
	}

	public void Delete()
	{
		EntityHelper.DeleteEntity(this, _EntityDAL.Delete);
	}

	public static BadgeAssetAward CreateNew(long badgeid, long assetawardid, string description)
	{
		BadgeAssetAward badgeAssetAward = new BadgeAssetAward();
		badgeAssetAward.BadgeID = badgeid;
		badgeAssetAward.AssetAwardID = assetawardid;
		badgeAssetAward.Description = description;
		badgeAssetAward.Save();
		return badgeAssetAward;
	}

	public static BadgeAssetAward Get(int id)
	{
		return EntityHelper.GetEntity<int, BadgeAssetAwardDAL, BadgeAssetAward>(EntityCacheInfo, id, () => BadgeAssetAwardDAL.Get(id));
	}

	public static ICollection<BadgeAssetAward> GetBadgeAssetAwardsByBadgeID(long badgeid)
	{
		string collectionId = $"GetBadgeAssetAwardsByBadgeID_BadgeID:{badgeid}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"BadgeID:{badgeid}"), collectionId, () => BadgeAssetAwardDAL.GetBadgeAssetAwardIDsByBadgeID(badgeid), Get);
	}

	public static ICollection<BadgeAssetAward> GetBadgeAssetAwardsPaged(int startRowIndex, int maximumRows)
	{
		List<BadgeAssetAward> badgeAssetAwards = new List<BadgeAssetAward>();
		foreach (int ID in BadgeAssetAwardDAL.GetBadgeAssetAwardIDsPaged(startRowIndex, maximumRows))
		{
			badgeAssetAwards.Add(Get(ID));
		}
		return badgeAssetAwards;
	}

	public static int GetTotalNumberOfBadgeAssetAwards()
	{
		return BadgeAssetAwardDAL.GetTotalNumberOfBadgeAssetAwards();
	}

	public void Construct(BadgeAssetAwardDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield break;
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		return new List<StateToken>
		{
			new StateToken($"BadgeID:{BadgeID}")
		};
	}
}
