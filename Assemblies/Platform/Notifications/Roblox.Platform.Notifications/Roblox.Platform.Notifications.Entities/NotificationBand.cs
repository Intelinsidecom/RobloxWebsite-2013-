using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.Notifications.Entities;

internal class NotificationBand : IRobloxEntity<int, NotificationBandDAL>, ICacheableObject<int>, ICacheableObject
{
	private NotificationBandDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(NotificationBand).ToString(), isNullCacheable: true);

	public int ID => _EntityDAL.ID;

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

	internal bool IsEnabledByDefault
	{
		get
		{
			return _EntityDAL.IsEnabledByDefault;
		}
		set
		{
			_EntityDAL.IsEnabledByDefault = value;
		}
	}

	internal bool IsOverridable
	{
		get
		{
			return _EntityDAL.IsOverridable;
		}
		set
		{
			_EntityDAL.IsOverridable = value;
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

	public NotificationBand()
	{
		_EntityDAL = new NotificationBandDAL();
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

	internal static NotificationBand Get(int id)
	{
		return EntityHelper.GetEntity<int, NotificationBandDAL, NotificationBand>(EntityCacheInfo, id, () => NotificationBandDAL.Get(id));
	}

	private static ICollection<NotificationBand> MultiGet(ICollection<int> ids)
	{
		return EntityHelper.MultiGetEntity<int, NotificationBandDAL, NotificationBand>(ids, EntityCacheInfo, NotificationBandDAL.MultiGet);
	}

	public static NotificationBand GetByNotificationSourceTypeIDAndReceiverDestinationTypeID(short notificationSourceTypeID, short receiverDestinationTypeID)
	{
		return EntityHelper.GetEntityByLookup<int, NotificationBandDAL, NotificationBand>(EntityCacheInfo, GetLookupCacheKeysByNotificationSourceTypeIDReceiverDestinationTypeID(notificationSourceTypeID, receiverDestinationTypeID), () => NotificationBandDAL.GetNotificationBandByNotificationSourceTypeIDAndReceiverDestinationTypeID(notificationSourceTypeID, receiverDestinationTypeID));
	}

	internal static ICollection<NotificationBand> GetNotificationBandsByNotificationSourceTypeIDPaged(short notificationSourceTypeID, int startRowIndex, int maximumRows)
	{
		string collectionId = $"GetNotificationBandsByNotificationSourceTypeIDPaged_NotificationSourceTypeID:{notificationSourceTypeID}_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy(GetLookupCacheKeysByNotificationSourceTypeID(notificationSourceTypeID)), collectionId, () => NotificationBandDAL.GetNotificationBandIDsByNotificationSourceTypeIDPaged(notificationSourceTypeID, startRowIndex + 1, maximumRows), MultiGet);
	}

	internal static ICollection<NotificationBand> GetNotificationBandsByReceiverDestinationTypeIDPaged(short receiverDestinationTypeID, int startRowIndex, int maximumRows)
	{
		string collectionId = $"GetNotificationBandsByReceiverDestinationTypeIDPaged_ReceiverDestinationTypeID:{receiverDestinationTypeID}_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy(GetLookupCacheKeysByReceiverDestinationTypeID(receiverDestinationTypeID)), collectionId, () => NotificationBandDAL.GetNotificationBandIDsByReceiverDestinationTypeIDPaged(receiverDestinationTypeID, startRowIndex + 1, maximumRows), MultiGet);
	}

	public void Construct(NotificationBandDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return GetLookupCacheKeysByNotificationSourceTypeIDReceiverDestinationTypeID(NotificationSourceTypeID, ReceiverDestinationTypeID);
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken(GetLookupCacheKeysByNotificationSourceTypeID(NotificationSourceTypeID));
		yield return new StateToken(GetLookupCacheKeysByReceiverDestinationTypeID(ReceiverDestinationTypeID));
	}

	private static string GetLookupCacheKeysByNotificationSourceTypeIDReceiverDestinationTypeID(short notificationSourceTypeID, short receiverDestinationTypeID)
	{
		return $"NotificationSourceTypeID:{notificationSourceTypeID}_ReceiverDestinationTypeID:{receiverDestinationTypeID}";
	}

	private static string GetLookupCacheKeysByNotificationSourceTypeID(short notificationSourceTypeID)
	{
		return $"NotificationSourceTypeID:{notificationSourceTypeID}";
	}

	private static string GetLookupCacheKeysByReceiverDestinationTypeID(short receiverDestinationTypeID)
	{
		return $"ReceiverDestinationTypeID:{receiverDestinationTypeID}";
	}
}
