using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.Notifications.Push.Entities.BLL;

internal class DestinationType : IRobloxEntity<int, DestinationTypeDAL>, ICacheableObject<int>, ICacheableObject
{
	private DestinationTypeDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(DestinationType).ToString(), isNullCacheable: true);

	public int ID => _EntityDAL.ID;

	internal int ApplicationTypeID
	{
		get
		{
			return _EntityDAL.ApplicationTypeID;
		}
		set
		{
			_EntityDAL.ApplicationTypeID = value;
		}
	}

	internal int PlatformTypeID
	{
		get
		{
			return _EntityDAL.PlatformTypeID;
		}
		set
		{
			_EntityDAL.PlatformTypeID = value;
		}
	}

	internal string RegistrationEndpoint
	{
		get
		{
			return _EntityDAL.RegistrationEndpoint;
		}
		set
		{
			_EntityDAL.RegistrationEndpoint = value;
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

	public DestinationType()
	{
		_EntityDAL = new DestinationTypeDAL();
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

	internal static DestinationType Get(int id)
	{
		return EntityHelper.GetEntity<int, DestinationTypeDAL, DestinationType>(EntityCacheInfo, id, () => DestinationTypeDAL.Get(id));
	}

	private static ICollection<DestinationType> MultiGet(ICollection<int> ids)
	{
		return EntityHelper.MultiGetEntity<int, DestinationTypeDAL, DestinationType>(ids, EntityCacheInfo, DestinationTypeDAL.MultiGet);
	}

	public static DestinationType GetByApplicationTypeIDAndPlatformTypeID(int applicationTypeID, int platformTypeID)
	{
		return EntityHelper.GetEntityByLookup<int, DestinationTypeDAL, DestinationType>(EntityCacheInfo, GetLookupCacheKeysByApplicationTypeIDPlatformTypeID(applicationTypeID, platformTypeID), () => DestinationTypeDAL.GetDestinationTypeByApplicationTypeIDAndPlatformTypeID(applicationTypeID, platformTypeID));
	}

	internal static ICollection<DestinationType> GetDestinationTypesByApplicationTypeIDPaged(int applicationTypeID, int startRowIndex, int maximumRows)
	{
		string collectionId = $"GetDestinationTypesByApplicationTypeIDPaged_ApplicationTypeID:{applicationTypeID}_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy(GetLookupCacheKeysByApplicationTypeID(applicationTypeID)), collectionId, () => DestinationTypeDAL.GetDestinationTypeIDsByApplicationTypeIDPaged(applicationTypeID, startRowIndex + 1, maximumRows), MultiGet);
	}

	public void Construct(DestinationTypeDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return GetLookupCacheKeysByApplicationTypeIDPlatformTypeID(ApplicationTypeID, PlatformTypeID);
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken(GetLookupCacheKeysByApplicationTypeID(ApplicationTypeID));
	}

	private static string GetLookupCacheKeysByApplicationTypeIDPlatformTypeID(int applicationTypeID, int platformTypeID)
	{
		return $"ApplicationTypeID:{applicationTypeID}_PlatformTypeID:{platformTypeID}";
	}

	private static string GetLookupCacheKeysByApplicationTypeID(int applicationTypeID)
	{
		return $"ApplicationTypeID:{applicationTypeID}";
	}
}
