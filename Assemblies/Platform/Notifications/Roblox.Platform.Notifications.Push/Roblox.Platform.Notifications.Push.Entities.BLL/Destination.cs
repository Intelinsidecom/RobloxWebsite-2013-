using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.Notifications.Push.Entities.BLL;

internal class Destination : IRobloxEntity<long, DestinationDAL>, ICacheableObject<long>, ICacheableObject, IRemoteCacheableObject
{
	private DestinationDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(Destination).ToString(), isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	internal int DestinationTypeID
	{
		get
		{
			return _EntityDAL.DestinationTypeID;
		}
		set
		{
			_EntityDAL.DestinationTypeID = value;
		}
	}

	internal string ExternalServiceDestinationID
	{
		get
		{
			return _EntityDAL.ExternalServiceDestinationID;
		}
		set
		{
			_EntityDAL.ExternalServiceDestinationID = value;
		}
	}

	internal string NotificationDeliveryEndpoint
	{
		get
		{
			return _EntityDAL.NotificationDeliveryEndpoint;
		}
		set
		{
			_EntityDAL.NotificationDeliveryEndpoint = value;
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

	internal byte[] ExternalServiceDestinationIDHash
	{
		get
		{
			return _EntityDAL.ExternalServiceDestinationIDHash;
		}
		set
		{
			_EntityDAL.ExternalServiceDestinationIDHash = value;
		}
	}

	public CacheInfo CacheInfo => EntityCacheInfo;

	public Destination()
	{
		_EntityDAL = new DestinationDAL();
	}

	public Destination(DestinationDAL entityDAL)
	{
		_EntityDAL = new DestinationDAL();
	}

	public static Destination Create(int destinationTypeID, string externalServiceDestinationID, byte[] externalServiceDestinationIDHash, string notificationDeliveryEndpoint)
	{
		Destination destination = new Destination();
		destination.DestinationTypeID = destinationTypeID;
		destination.ExternalServiceDestinationID = externalServiceDestinationID;
		destination.ExternalServiceDestinationIDHash = externalServiceDestinationIDHash;
		destination.NotificationDeliveryEndpoint = notificationDeliveryEndpoint;
		destination.Save();
		return destination;
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

	internal static Destination Get(long id)
	{
		return EntityHelper.GetEntity<long, DestinationDAL, Destination>(EntityCacheInfo, id, () => DestinationDAL.Get(id));
	}

	private static ICollection<Destination> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.MultiGetEntity<long, DestinationDAL, Destination>(ids, EntityCacheInfo, DestinationDAL.MultiGet);
	}

	public static Destination GetByDestinationTypeIDAndExternalServiceDestinationID(int destinationTypeId, string externalServiceDestinationId)
	{
		return EntityHelper.GetEntityByLookup<long, DestinationDAL, Destination>(EntityCacheInfo, GetLookupCacheKeysByDestinationTypeIDExternalServiceDestinationID(destinationTypeId, externalServiceDestinationId), () => DestinationDAL.GetDestinationByDestinationTypeIDAndExternalServiceDestinationID(destinationTypeId, externalServiceDestinationId));
	}

	internal static ICollection<Destination> GetDestinationsByDestinationTypeIDAndExternalServiceDestinationIDHash(int destinationTypeId, byte[] externalServiceDestinationIdHash, int count, long exclusiveStartDestinationId)
	{
		string collectionId = $"GetDestinationsByDestinationTypeIDAndExternalServiceDestinationIDHash_DestinationTypeID:{destinationTypeId}_ExternalServiceDestinationIDHash:{externalServiceDestinationIdHash}_Count:{count}_ExclusiveStartDestinationID:{exclusiveStartDestinationId}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy(GetLookupCacheKeysByDestinationTypeIDExternalServiceDestinationIDHash(destinationTypeId, externalServiceDestinationIdHash)), collectionId, () => DestinationDAL.GetDestinationIDsByDestinationTypeIDAndExternalServiceDestinationIDHash(destinationTypeId, externalServiceDestinationIdHash, count, exclusiveStartDestinationId), MultiGet);
	}

	public void Construct(DestinationDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return GetLookupCacheKeysByDestinationTypeIDExternalServiceDestinationID(DestinationTypeID, ExternalServiceDestinationID);
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken(GetLookupCacheKeysByDestinationTypeIDExternalServiceDestinationIDHash(DestinationTypeID, ExternalServiceDestinationIDHash));
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}

	private static string GetLookupCacheKeysByDestinationTypeIDExternalServiceDestinationID(int destinationTypeId, string externalServiceDestinationId)
	{
		return $"DestinationTypeID:{destinationTypeId}_ExternalServiceDestinationID:{externalServiceDestinationId}";
	}

	private static string GetLookupCacheKeysByDestinationTypeIDExternalServiceDestinationIDHash(int destinationTypeId, byte[] externalServiceDestinationIdHash)
	{
		return $"DestinationTypeID:{destinationTypeId}_ExternalServiceDestinationIDHash:{externalServiceDestinationIdHash}";
	}
}
