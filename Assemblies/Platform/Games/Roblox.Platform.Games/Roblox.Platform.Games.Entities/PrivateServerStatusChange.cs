using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.Games.Entities;

internal class PrivateServerStatusChange : IRobloxEntity<long, PrivateServerStatusChangeDAL>, ICacheableObject<long>, ICacheableObject
{
	private PrivateServerStatusChangeDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(PrivateServerStatusChange).ToString(), isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	internal long PrivateServerID
	{
		get
		{
			return _EntityDAL.PrivateServerID;
		}
		set
		{
			_EntityDAL.PrivateServerID = value;
		}
	}

	internal byte OldPrivateServerStatusTypeID
	{
		get
		{
			return _EntityDAL.OldPrivateServerStatusTypeID;
		}
		set
		{
			_EntityDAL.OldPrivateServerStatusTypeID = value;
		}
	}

	internal byte NewPrivateServerStatusTypeID
	{
		get
		{
			return _EntityDAL.NewPrivateServerStatusTypeID;
		}
		set
		{
			_EntityDAL.NewPrivateServerStatusTypeID = value;
		}
	}

	internal byte PrivateServerStatusChangeReasonTypeID
	{
		get
		{
			return _EntityDAL.PrivateServerStatusChangeReasonTypeID;
		}
		set
		{
			_EntityDAL.PrivateServerStatusChangeReasonTypeID = value;
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

	public PrivateServerStatusChange()
	{
		_EntityDAL = new PrivateServerStatusChangeDAL();
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

	internal static PrivateServerStatusChange Get(long id)
	{
		return EntityHelper.GetEntity<long, PrivateServerStatusChangeDAL, PrivateServerStatusChange>(EntityCacheInfo, id, () => PrivateServerStatusChangeDAL.Get(id));
	}

	internal static ICollection<PrivateServerStatusChange> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.MultiGetEntity<long, PrivateServerStatusChangeDAL, PrivateServerStatusChange>(ids, EntityCacheInfo, PrivateServerStatusChangeDAL.MultiGet);
	}

	public void Construct(PrivateServerStatusChangeDAL dal)
	{
		_EntityDAL = dal;
	}

	internal static PrivateServerStatusChange CreateNew(long privateServerId, byte newStatusTypeId, byte oldStatusTypeId, byte reasonTypeId)
	{
		PrivateServerStatusChange privateServerStatusChange = new PrivateServerStatusChange();
		privateServerStatusChange.PrivateServerID = privateServerId;
		privateServerStatusChange.OldPrivateServerStatusTypeID = oldStatusTypeId;
		privateServerStatusChange.NewPrivateServerStatusTypeID = newStatusTypeId;
		privateServerStatusChange.PrivateServerStatusChangeReasonTypeID = reasonTypeId;
		privateServerStatusChange.Save();
		return privateServerStatusChange;
	}

	internal static ICollection<PrivateServerStatusChange> GetPrivateServerStatusChangesByPrivateServerIDPaged(long privateServerId, long startRowIndex, long maximumRows)
	{
		string collectionId = $"GetPrivateServerStatusChangesByPrivateServerIDPaged_PrivateServerID:{privateServerId}_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy($"PrivateServerID:{privateServerId}"), collectionId, () => PrivateServerStatusChangeDAL.GetPrivateServerStatusChangeIDsByPrivateServerIDPaged(privateServerId, startRowIndex + 1, maximumRows), MultiGet);
	}

	internal static long GetTotalNumberOfPrivateServerStatusChangesByPrivateServerId(long privateServerId)
	{
		string countId = $"GetTotalNumberOfPrivateServerStatusChangesByPrivateServerId_PrivateServerId:{privateServerId}";
		return EntityHelper.GetEntityCount(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy($"PrivateServerID:{privateServerId}"), countId, () => PrivateServerStatusChangeDAL.GetTotalNumberOfPrivateServerStatusChangesByPrivateServerID(privateServerId));
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield break;
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken($"PrivateServerID:{PrivateServerID}");
	}
}
