using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Marketing;

internal class SponsoredPageDeviceType : IRobloxEntity<int, SponsoredPageDeviceTypeDAL>, ICacheableObject<int>, ICacheableObject
{
	private SponsoredPageDeviceTypeDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(SponsoredPageDeviceType).ToString(), isNullCacheable: true);

	public int ID => _EntityDAL.ID;

	internal int SponsoredPageID
	{
		get
		{
			return _EntityDAL.SponsoredPageID;
		}
		set
		{
			_EntityDAL.SponsoredPageID = value;
		}
	}

	internal long DeviceTypesBitMask
	{
		get
		{
			return _EntityDAL.DeviceTypesBitMask;
		}
		set
		{
			_EntityDAL.DeviceTypesBitMask = value;
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

	public SponsoredPageDeviceType()
	{
		_EntityDAL = new SponsoredPageDeviceTypeDAL();
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

	internal static SponsoredPageDeviceType Get(int id)
	{
		return EntityHelper.GetEntity<int, SponsoredPageDeviceTypeDAL, SponsoredPageDeviceType>(EntityCacheInfo, id, () => SponsoredPageDeviceTypeDAL.Get(id));
	}

	private static ICollection<SponsoredPageDeviceType> MultiGet(ICollection<int> ids)
	{
		return EntityHelper.MultiGetEntity<int, SponsoredPageDeviceTypeDAL, SponsoredPageDeviceType>(ids, EntityCacheInfo, SponsoredPageDeviceTypeDAL.MultiGet);
	}

	public static SponsoredPageDeviceType GetBySponsoredPageId(int sponsoredPageId)
	{
		return EntityHelper.GetEntityByLookup<int, SponsoredPageDeviceTypeDAL, SponsoredPageDeviceType>(EntityCacheInfo, GetLookupCacheKeysBySponsoredPageID(sponsoredPageId), () => SponsoredPageDeviceTypeDAL.GetSponsoredPageDeviceTypeBySponsoredPageID(sponsoredPageId));
	}

	public void Construct(SponsoredPageDeviceTypeDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return GetLookupCacheKeysBySponsoredPageID(SponsoredPageID);
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}

	private static string GetLookupCacheKeysBySponsoredPageID(int sponsoredPageID)
	{
		return $"SponsoredPageID:{sponsoredPageID}";
	}
}
