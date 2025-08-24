using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Marketing;

public class Campaign : IRobloxEntity<int, CampaignDAL>, ICacheableObject<int>, ICacheableObject
{
	private CampaignDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: false), typeof(Campaign).ToString(), isNullCacheable: true);

	public int ID => _EntityDAL.ID;

	public int PartnerID
	{
		get
		{
			return _EntityDAL.PartnerID;
		}
		set
		{
			_EntityDAL.PartnerID = value;
		}
	}

	public string Name
	{
		get
		{
			return _EntityDAL.Name;
		}
		set
		{
			_EntityDAL.Name = value;
		}
	}

	public bool IsBlacklisted
	{
		get
		{
			return _EntityDAL.IsBlacklisted;
		}
		set
		{
			_EntityDAL.IsBlacklisted = value;
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

	public Campaign()
	{
		_EntityDAL = new CampaignDAL();
	}

	internal void Delete()
	{
		EntityHelper.DeleteEntity(this, _EntityDAL.Delete);
	}

	public void Save()
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

	public static Campaign CreateNew(int partnerid, string name, bool isBlacklisted)
	{
		Campaign campaign = new Campaign();
		campaign.PartnerID = partnerid;
		campaign.Name = name;
		campaign.IsBlacklisted = isBlacklisted;
		campaign.Save();
		return campaign;
	}

	public static Campaign Get(int id)
	{
		return EntityHelper.GetEntity<int, CampaignDAL, Campaign>(EntityCacheInfo, id, () => CampaignDAL.Get(id));
	}

	public static ICollection<Campaign> GetCampaignsByPartnerID_Paged(int partnerId, int startIndex, int maxRows)
	{
		string collectionId = $"GetCampaignsByPartnerID_Paged_PartnerID:{partnerId}_StartRowIndex:{startIndex}_MaximumRows:{maxRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Unqualified, null), collectionId, () => CampaignDAL.GetCampaignIDsByPartnerID_Paged(partnerId, startIndex + 1, maxRows), Get);
	}

	public void Construct(CampaignDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield break;
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken($"PartnerID:{PartnerID}");
	}
}
