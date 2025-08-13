using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.Notifications.Entities;

internal class ReceiverDestinationTypeOptOut : IRobloxEntity<long, ReceiverDestinationTypeOptOutDAL>, ICacheableObject<long>, ICacheableObject
{
	private ReceiverDestinationTypeOptOutDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(ReceiverDestinationTypeOptOut).ToString(), isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	internal long ReceiverID
	{
		get
		{
			return _EntityDAL.ReceiverID;
		}
		set
		{
			_EntityDAL.ReceiverID = value;
		}
	}

	internal short ReceiverDestinationTypeID
	{
		get
		{
			return _EntityDAL.ReceiverDestinationTypeID;
		}
		set
		{
			_EntityDAL.ReceiverDestinationTypeID = value;
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

	public ReceiverDestinationTypeOptOut()
	{
		_EntityDAL = new ReceiverDestinationTypeOptOutDAL();
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
			_EntityDAL.Insert();
		}, _EntityDAL.Update);
	}

	internal static ReceiverDestinationTypeOptOut Get(long id)
	{
		return EntityHelper.GetEntity<long, ReceiverDestinationTypeOptOutDAL, ReceiverDestinationTypeOptOut>(EntityCacheInfo, id, () => ReceiverDestinationTypeOptOutDAL.Get(id));
	}

	private static ICollection<ReceiverDestinationTypeOptOut> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.MultiGetEntity<long, ReceiverDestinationTypeOptOutDAL, ReceiverDestinationTypeOptOut>(ids, EntityCacheInfo, ReceiverDestinationTypeOptOutDAL.MultiGet);
	}

	public static ReceiverDestinationTypeOptOut GetByReceiverIDAndReceiverDestinationTypeID(long receiverID, short receiverDestinationTypeID)
	{
		return EntityHelper.GetEntityByLookup<long, ReceiverDestinationTypeOptOutDAL, ReceiverDestinationTypeOptOut>(EntityCacheInfo, GetLookupCacheKeysByReceiverIDReceiverDestinationTypeID(receiverID, receiverDestinationTypeID), () => ReceiverDestinationTypeOptOutDAL.GetReceiverDestinationTypeOptOutByReceiverIDAndReceiverDestinationTypeID(receiverID, receiverDestinationTypeID));
	}

	internal static ICollection<ReceiverDestinationTypeOptOut> GetReceiverDestinationTypeOptOutsByReceiverIDPaged(long receiverID, long startRowIndex, long maximumRows)
	{
		string collectionId = $"GetReceiverDestinationTypeOptOutsByReceiverIDPaged_ReceiverID:{receiverID}_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy(GetLookupCacheKeysByReceiverID(receiverID)), collectionId, () => ReceiverDestinationTypeOptOutDAL.GetReceiverDestinationTypeOptOutIDsByReceiverIDPaged(receiverID, startRowIndex + 1, maximumRows), MultiGet);
	}

	public void Construct(ReceiverDestinationTypeOptOutDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return GetLookupCacheKeysByReceiverIDReceiverDestinationTypeID(ReceiverID, ReceiverDestinationTypeID);
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken(GetLookupCacheKeysByReceiverID(ReceiverID));
	}

	private static string GetLookupCacheKeysByReceiverIDReceiverDestinationTypeID(long receiverID, int receiverDestinationTypeID)
	{
		return $"ReceiverID:{receiverID}_ReceiverDestinationTypeID:{receiverDestinationTypeID}";
	}

	private static string GetLookupCacheKeysByReceiverID(long receiverID)
	{
		return $"ReceiverID:{receiverID}";
	}
}
