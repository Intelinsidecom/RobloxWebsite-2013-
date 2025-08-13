using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.Games.Entities;

internal class PrivateServer : IRobloxEntity<long, PrivateServerDAL>, ICacheableObject<long>, ICacheableObject
{
	private PrivateServerDAL _EntityDAL;

	/// <summary>
	/// The previous link code.
	/// </summary>
	/// <remarks>Used for cache invalidation.</remarks>
	private string _OriginalLinkCode;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(PrivateServer).ToString(), isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	internal long UniverseID
	{
		get
		{
			return _EntityDAL.UniverseID;
		}
		set
		{
			_EntityDAL.UniverseID = value;
		}
	}

	internal string Name
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

	internal long OwnerUserID
	{
		get
		{
			return _EntityDAL.OwnerUserID;
		}
		set
		{
			_EntityDAL.OwnerUserID = value;
		}
	}

	internal byte PrivateServerStatusTypeID
	{
		get
		{
			return _EntityDAL.PrivateServerStatusTypeID;
		}
		set
		{
			_EntityDAL.PrivateServerStatusTypeID = value;
		}
	}

	internal Guid AccessCode
	{
		get
		{
			return _EntityDAL.AccessCode;
		}
		set
		{
			_EntityDAL.AccessCode = value;
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

	internal DateTime ExpirationDate
	{
		get
		{
			return _EntityDAL.ExpirationDate;
		}
		set
		{
			_EntityDAL.ExpirationDate = value;
		}
	}

	internal string LinkCode
	{
		get
		{
			return _EntityDAL.LinkCode;
		}
		set
		{
			if (_OriginalLinkCode == null)
			{
				_OriginalLinkCode = _EntityDAL.LinkCode;
			}
			_EntityDAL.LinkCode = value;
		}
	}

	public CacheInfo CacheInfo => EntityCacheInfo;

	public PrivateServer()
	{
		_EntityDAL = new PrivateServerDAL();
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
		_OriginalLinkCode = null;
	}

	internal static PrivateServer Get(long id)
	{
		return EntityHelper.GetEntity<long, PrivateServerDAL, PrivateServer>(EntityCacheInfo, id, () => PrivateServerDAL.Get(id));
	}

	internal static ICollection<PrivateServer> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.MultiGetEntity<long, PrivateServerDAL, PrivateServer>(ids, EntityCacheInfo, PrivateServerDAL.MultiGet);
	}

	internal static PrivateServer CreateNew(long universeId, long ownerUserId, string serverName, byte privateServerStatusTypeId, Guid accessCode, DateTime expirationDate)
	{
		PrivateServer privateServer = new PrivateServer();
		privateServer.UniverseID = universeId;
		privateServer.OwnerUserID = ownerUserId;
		privateServer.Name = serverName;
		privateServer.PrivateServerStatusTypeID = privateServerStatusTypeId;
		privateServer.AccessCode = accessCode;
		privateServer.ExpirationDate = expirationDate;
		privateServer.Save();
		return privateServer;
	}

	public void Construct(PrivateServerDAL dal)
	{
		_EntityDAL = dal;
	}

	internal static PrivateServer GetPrivateServerByAccessCode(Guid accessCode)
	{
		return EntityHelper.GetEntityByLookup<long, PrivateServerDAL, PrivateServer>(EntityCacheInfo, $"AccessCode:{accessCode}", () => PrivateServerDAL.GetPrivateServerByAccessCode(accessCode));
	}

	internal static ICollection<PrivateServer> GetPrivateServersByOwnerUserIdPaged(long ownerUserId, int startRowIndex, int maximumRows)
	{
		string collectionId = $"GetPrivateServersByOwnerUserIdPaged_OwnerUserID:{ownerUserId}_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy($"OwnerUserID:{ownerUserId}"), collectionId, () => PrivateServerDAL.GetPrivateServerIDsByOwnerUserIDPaged(ownerUserId, startRowIndex + 1, maximumRows), MultiGet);
	}

	internal static ICollection<PrivateServer> GetPrivateServersByOwnerUserIdAndUniverseIdPaged(long ownerUserId, long universeId, int startRowIndex, int maximumRows)
	{
		string collectionId = $"GetPrivateServersByOwnerUserIdAndUniverseIdPaged_OwnerUserID:{ownerUserId}_UniverseID:{universeId}_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy($"OwnerUserID:{ownerUserId}_UniverseID:{universeId}"), collectionId, () => PrivateServerDAL.GetPrivateServerIDsByOwnerUserIDAndUniverseIDPaged(ownerUserId, universeId, startRowIndex + 1, maximumRows), MultiGet);
	}

	internal static ICollection<PrivateServer> GetPrivateServersByUniverseIdAndPrivateServerStatusTypeIdPaged(long universeId, byte privateServerStatusTypeID, int startRowIndex, int maximumRows)
	{
		string collectionId = $"GetPrivateServersByUniverseIdAndPrivateServerStatusTypeIdPaged_UniverseID:{universeId}_PrivateServerStatusTypeID:{privateServerStatusTypeID}_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy($"UniverseID:{universeId}_PrivateServerStatusTypeID:{privateServerStatusTypeID}"), collectionId, () => PrivateServerDAL.GetPrivateServerIDsByUniverseIDAndPrivateServerStatusTypeIDPaged(universeId, privateServerStatusTypeID, startRowIndex + 1, maximumRows), MultiGet);
	}

	internal static ICollection<PrivateServer> GetPrivateServersByUniverseIdPaged(long universeId, int startRowIndex, int maximumRows)
	{
		string collectionId = $"GetPrivateServersByUniverseIdPaged_UniverseID:{universeId}_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy($"UniverseID:{universeId}"), collectionId, () => PrivateServerDAL.GetPrivateServerIDsByUniverseIDPaged(universeId, startRowIndex + 1, maximumRows), MultiGet);
	}

	internal static long GetTotalNumberOfPrivateServersByOwnerUserId(long ownerUserId)
	{
		string countId = $"GetTotalNumberOfPrivateServersByOwnerUserId_OwnerUserID:{ownerUserId}";
		return EntityHelper.GetEntityCount(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy($"OwnerUserID:{ownerUserId}"), countId, () => PrivateServerDAL.GetTotalNumberOfPrivateServersByOwnerUserID(ownerUserId));
	}

	internal static long GetTotalNumberOfPrivateServersByOwnerUserIdAndUniverseId(long ownerUserId, long universeId)
	{
		string countId = $"GetTotalNumberOfPrivateServersByOwnerUserIdAndUniverseId_OwnerUserID:{ownerUserId}_UniverseID:{universeId}";
		return EntityHelper.GetEntityCount(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy($"OwnerUserID:{ownerUserId}_UniverseID:{universeId}"), countId, () => PrivateServerDAL.GetTotalNumberOfPrivateServersByOwnerUserIDAndUniverseID(ownerUserId, universeId));
	}

	internal static long GetTotalNumberOfPrivateServersByUniverseIdAndPrivateServerStatusTypeId(long universeId, byte privateServerStatusTypeId)
	{
		string countId = $"GetTotalNumberOfPrivateServersByUniverseIdAndPrivateServerStatusTypeId_UniverseID:{universeId}_PrivateServerStatusTypeID:{privateServerStatusTypeId}";
		return EntityHelper.GetEntityCount(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy($"UniverseID:{universeId}_PrivateServerStatusTypeID:{privateServerStatusTypeId}"), countId, () => PrivateServerDAL.GetTotalNumberOfPrivateServersByUniverseIDAndPrivateServerStatusTypeID(universeId, privateServerStatusTypeId));
	}

	internal static long GetTotalNumberOfPrivateServersByUniverseId(long universeId)
	{
		string countId = $"GetTotalNumberOfPrivateServersByUniverseId_UniverseID:{universeId}";
		return EntityHelper.GetEntityCount(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy($"UniverseID:{universeId}"), countId, () => PrivateServerDAL.GetTotalNumberOfPrivateServersByUniverseID(universeId));
	}

	internal static long GetTotalNumberOfPrivateServersByLinkCode(string linkCode)
	{
		string countId = $"GetTotalNumberOfPrivateServersByLinkCode_LinkCode:{linkCode}";
		return EntityHelper.GetEntityCount(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy($"LinkCode:{linkCode}"), countId, () => PrivateServerDAL.GetTotalNumberOfPrivateServersByLinkCode(linkCode));
	}

	internal static ICollection<PrivateServer> GetPrivateServersByLinkCodePaged(string linkCode, int startRowIndex, int maximumRows)
	{
		string collectionId = $"GetPrivateServersByLinkCodePaged_LinkCode:{linkCode}_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy($"LinkCode:{linkCode}"), collectionId, () => PrivateServerDAL.GetPrivateServerIDsByLinkCodePaged(linkCode, startRowIndex + 1, maximumRows), MultiGet);
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"AccessCode:{AccessCode}";
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken($"OwnerUserID:{OwnerUserID}");
		yield return new StateToken($"OwnerUserID:{OwnerUserID}_UniverseID:{UniverseID}");
		yield return new StateToken($"UniverseID:{UniverseID}");
		yield return new StateToken($"UniverseID:{UniverseID}_PrivateServerStatusTypeID:{PrivateServerStatusTypeID}");
		yield return new StateToken($"LinkCode:{LinkCode}");
		if (_OriginalLinkCode != null)
		{
			yield return new StateToken($"LinkCode:{_OriginalLinkCode}");
		}
	}
}
