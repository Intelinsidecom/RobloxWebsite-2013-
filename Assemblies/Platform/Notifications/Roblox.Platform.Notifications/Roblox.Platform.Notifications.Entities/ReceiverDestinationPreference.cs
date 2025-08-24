using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.Notifications.Entities;

internal class ReceiverDestinationPreference : IRobloxEntity<long, ReceiverDestinationPreferenceDAL>, ICacheableObject<long>, ICacheableObject
{
	private ReceiverDestinationPreferenceDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(ReceiverDestinationPreference).ToString(), isNullCacheable: true);

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

	internal long DestinationID
	{
		get
		{
			return _EntityDAL.DestinationID;
		}
		set
		{
			_EntityDAL.DestinationID = value;
		}
	}

	internal bool IsEnabled
	{
		get
		{
			return _EntityDAL.IsEnabled;
		}
		set
		{
			_EntityDAL.IsEnabled = value;
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

	public ReceiverDestinationPreference()
	{
		_EntityDAL = new ReceiverDestinationPreferenceDAL();
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

	internal static ReceiverDestinationPreference Get(long id)
	{
		return EntityHelper.GetEntity<long, ReceiverDestinationPreferenceDAL, ReceiverDestinationPreference>(EntityCacheInfo, id, () => ReceiverDestinationPreferenceDAL.Get(id));
	}

	private static ICollection<ReceiverDestinationPreference> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.MultiGetEntity<long, ReceiverDestinationPreferenceDAL, ReceiverDestinationPreference>(ids, EntityCacheInfo, ReceiverDestinationPreferenceDAL.MultiGet);
	}

	public static ReceiverDestinationPreference GetByReceiverIDNotificationSourceTypeIDAndDestinationID(long receiverID, short notificationSourceTypeID, long destinationID)
	{
		return EntityHelper.GetEntityByLookup<long, ReceiverDestinationPreferenceDAL, ReceiverDestinationPreference>(EntityCacheInfo, GetLookupCacheKeysByReceiverIDNotificationSourceTypeIDDestinationID(receiverID, notificationSourceTypeID, destinationID), () => ReceiverDestinationPreferenceDAL.GetReceiverDestinationPreferenceByReceiverIDNotificationSourceTypeIDAndDestinationID(receiverID, notificationSourceTypeID, destinationID));
	}

	internal static ICollection<ReceiverDestinationPreference> GetReceiverDestinationPreferencesByReceiverIDPaged(long receiverID, long startRowIndex, long maximumRows)
	{
		string collectionId = $"GetReceiverDestinationPreferencesByReceiverIDPaged_ReceiverID:{receiverID}_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy(GetLookupCacheKeysByReceiverID(receiverID)), collectionId, () => ReceiverDestinationPreferenceDAL.GetReceiverDestinationPreferenceIDsByReceiverIDPaged(receiverID, startRowIndex + 1, maximumRows), MultiGet);
	}

	public void Construct(ReceiverDestinationPreferenceDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return GetLookupCacheKeysByReceiverIDNotificationSourceTypeIDDestinationID(ReceiverID, NotificationSourceTypeID, DestinationID);
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken(GetLookupCacheKeysByReceiverID(ReceiverID));
	}

	private static string GetLookupCacheKeysByReceiverID(long receiverID)
	{
		return $"ReceiverID:{receiverID}";
	}

	private static string GetLookupCacheKeysByReceiverIDNotificationSourceTypeIDDestinationID(long receiverID, int notificationSourceTypeID, long destinationID)
	{
		return $"ReceiverID:{receiverID}_NotificationSourceTypeID:{notificationSourceTypeID}_DestinationID:{destinationID}";
	}
}
