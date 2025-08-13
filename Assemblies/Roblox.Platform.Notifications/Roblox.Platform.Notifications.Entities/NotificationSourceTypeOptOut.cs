using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.Notifications.Entities;

internal class NotificationSourceTypeOptOut : IRobloxEntity<long, NotificationSourceTypeOptOutDAL>, ICacheableObject<long>, ICacheableObject
{
	private NotificationSourceTypeOptOutDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(NotificationSourceTypeOptOut).ToString(), isNullCacheable: true);

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

	internal short NotificationSourceTypeID
	{
		get
		{
			return _EntityDAL.NotificationSourceTypeID;
		}
		set
		{
			_EntityDAL.NotificationSourceTypeID = value;
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

	public NotificationSourceTypeOptOut()
	{
		_EntityDAL = new NotificationSourceTypeOptOutDAL();
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

	internal static NotificationSourceTypeOptOut Get(long id)
	{
		return EntityHelper.GetEntity<long, NotificationSourceTypeOptOutDAL, NotificationSourceTypeOptOut>(EntityCacheInfo, id, () => NotificationSourceTypeOptOutDAL.Get(id));
	}

	private static ICollection<NotificationSourceTypeOptOut> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.MultiGetEntity<long, NotificationSourceTypeOptOutDAL, NotificationSourceTypeOptOut>(ids, EntityCacheInfo, NotificationSourceTypeOptOutDAL.MultiGet);
	}

	public static NotificationSourceTypeOptOut GetByReceiverIDAndNotificationSourceTypeID(long receiverID, short notificationSourceTypeID)
	{
		return EntityHelper.GetEntityByLookup<long, NotificationSourceTypeOptOutDAL, NotificationSourceTypeOptOut>(EntityCacheInfo, GetLookupCacheKeysByReceiverIDNotificationSourceTypeID(receiverID, notificationSourceTypeID), () => NotificationSourceTypeOptOutDAL.GetNotificationSourceTypeOptOutByReceiverIDAndNotificationSourceTypeID(receiverID, notificationSourceTypeID));
	}

	internal static ICollection<NotificationSourceTypeOptOut> GetNotificationSourceTypeOptOutsByReceiverIDPaged(long receiverID, long startRowIndex, long maximumRows)
	{
		string collectionId = $"GetNotificationSourceTypeOptOutsByReceiverIDPaged_ReceiverID:{receiverID}_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy(GetLookupCacheKeysByReceiverID(receiverID)), collectionId, () => NotificationSourceTypeOptOutDAL.GetNotificationSourceTypeOptOutIDsByReceiverIDPaged(receiverID, startRowIndex + 1, maximumRows), MultiGet);
	}

	public void Construct(NotificationSourceTypeOptOutDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return GetLookupCacheKeysByReceiverIDNotificationSourceTypeID(ReceiverID, NotificationSourceTypeID);
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken(GetLookupCacheKeysByReceiverID(ReceiverID));
	}

	private static string GetLookupCacheKeysByReceiverID(long receiverID)
	{
		return $"ReceiverID:{receiverID}";
	}

	private static string GetLookupCacheKeysByReceiverIDNotificationSourceTypeID(long receiverID, int notificationSourceTypeID)
	{
		return $"ReceiverID:{receiverID}_NotificationSourceTypeID:{notificationSourceTypeID}";
	}
}
