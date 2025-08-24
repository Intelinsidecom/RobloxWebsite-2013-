using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Marketing;

public class TrackingPixel : IRobloxEntity<int, TrackingPixelDAL>, ICacheableObject<int>, ICacheableObject
{
	private TrackingPixelDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), typeof(TrackingPixel).ToString(), isNullCacheable: true);

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

	public string PixelHTML
	{
		get
		{
			return _EntityDAL.PixelHTML;
		}
		set
		{
			_EntityDAL.PixelHTML = value;
		}
	}

	public int TrackingEventID
	{
		get
		{
			return _EntityDAL.TrackingEventID;
		}
		set
		{
			_EntityDAL.TrackingEventID = value;
		}
	}

	public bool IsActive
	{
		get
		{
			return _EntityDAL.IsActive;
		}
		set
		{
			_EntityDAL.IsActive = value;
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

	public TrackingPixel()
	{
		_EntityDAL = new TrackingPixelDAL();
	}

	public void Delete()
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

	public static TrackingPixel CreateNew(int partnerid, string pixel, int trackingeventid, bool isActive = false)
	{
		TrackingPixel trackingPixel = new TrackingPixel();
		trackingPixel.PartnerID = partnerid;
		trackingPixel.PixelHTML = pixel;
		trackingPixel.TrackingEventID = trackingeventid;
		trackingPixel.IsActive = isActive;
		trackingPixel.Save();
		return trackingPixel;
	}

	public static TrackingPixel Get(int id)
	{
		return EntityHelper.GetEntity<int, TrackingPixelDAL, TrackingPixel>(EntityCacheInfo, id, () => TrackingPixelDAL.Get(id));
	}

	public static ICollection<TrackingPixel> GetTrackingPixelsByPartnerID_Paged(int partnerId, int startIndex, int maxRows)
	{
		string collectionId = $"GetTrackingPixelsByPartnerID_Paged_PartnerID:{partnerId}_StartRowIndex:{startIndex}_MaximumRows:{maxRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Unqualified, null), collectionId, () => TrackingPixelDAL.GetTrackingPixelIDsByPartnerID_Paged(partnerId, startIndex + 1, maxRows), Get);
	}

	public static TrackingPixel GetTrackingPixelByPartnerIDAndTrackingEventID(int partnerID, int trackingEventID)
	{
		return EntityHelper.GetEntityByLookup<int, TrackingPixelDAL, TrackingPixel>(EntityCacheInfo, $"PartnerID:{partnerID}_TrackingEventID:{trackingEventID}", () => TrackingPixelDAL.GetByPartnerIDAndTrackingEventID(partnerID, trackingEventID));
	}

	public void Construct(TrackingPixelDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"PartnerID:{PartnerID}_TrackingEventID:{TrackingEventID}";
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken($"PartnerID:{PartnerID}");
	}
}
