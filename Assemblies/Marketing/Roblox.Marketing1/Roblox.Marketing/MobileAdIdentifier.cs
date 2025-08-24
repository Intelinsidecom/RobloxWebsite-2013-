using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Marketing;

public class MobileAdIdentifier : IRobloxEntity<int, MobileAdIdentifierDAL>, ICacheableObject<int>, ICacheableObject
{
	private MobileAdIdentifierDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(MobileAdIdentifier).ToString(), isNullCacheable: true);

	public int ID => _EntityDAL.ID;

	internal Guid DeviceID
	{
		get
		{
			return _EntityDAL.DeviceID;
		}
		set
		{
			_EntityDAL.DeviceID = value;
		}
	}

	internal byte OperatingSystemTypeID
	{
		get
		{
			return _EntityDAL.OperatingSystemTypeID;
		}
		set
		{
			_EntityDAL.OperatingSystemTypeID = value;
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

	public MobileAdIdentifier()
	{
		_EntityDAL = new MobileAdIdentifierDAL();
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

	internal static MobileAdIdentifier Get(int id)
	{
		return EntityHelper.GetEntity<int, MobileAdIdentifierDAL, MobileAdIdentifier>(EntityCacheInfo, id, () => MobileAdIdentifierDAL.Get(id));
	}

	internal static ICollection<MobileAdIdentifier> MultiGet(ICollection<int> ids)
	{
		return EntityHelper.MultiGetEntity<int, MobileAdIdentifierDAL, MobileAdIdentifier>(ids, EntityCacheInfo, MobileAdIdentifierDAL.MultiGet);
	}

	public static MobileAdIdentifier GetOrCreate(Guid deviceId, byte operatingSystemTypeId)
	{
		return EntityHelper.GetOrCreateEntity<int, MobileAdIdentifier>(EntityCacheInfo, $"DeviceID:{deviceId}_OperatingSystemTypeID:{operatingSystemTypeId}", () => DoGetOrCreate(deviceId, operatingSystemTypeId));
	}

	private static MobileAdIdentifier DoGetOrCreate(Guid deviceId, byte operatingSystemTypeId)
	{
		return EntityHelper.DoGetOrCreate<int, MobileAdIdentifierDAL, MobileAdIdentifier>(() => MobileAdIdentifierDAL.GetOrCreateMobileAdIdentifier(deviceId, operatingSystemTypeId));
	}

	public static MobileAdIdentifier GetByDeviceIDOperatingSystemTypeID(Guid deviceId, byte operatingSystemTypeId)
	{
		return EntityHelper.GetEntityByLookup<int, MobileAdIdentifierDAL, MobileAdIdentifier>(EntityCacheInfo, $"DeviceID:{deviceId}_OperatingSystemTypeID:{operatingSystemTypeId}", () => MobileAdIdentifierDAL.GetMobileAdIdentifierByDeviceIDOperatingSystemTypeID(deviceId, operatingSystemTypeId));
	}

	public void Construct(MobileAdIdentifierDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"DeviceID:{DeviceID}_OperatingSystemTypeID:{OperatingSystemTypeID}";
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
