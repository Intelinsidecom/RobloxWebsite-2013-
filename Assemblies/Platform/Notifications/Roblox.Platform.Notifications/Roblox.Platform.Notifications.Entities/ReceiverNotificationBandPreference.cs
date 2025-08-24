using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;
using Roblox.Platform.Notifications.Properties;

namespace Roblox.Platform.Notifications.Entities;

internal class ReceiverNotificationBandPreference : IRobloxEntity<long, ReceiverNotificationBandPreferenceDAL>, ICacheableObject<long>, ICacheableObject, IRemoteCacheableObject
{
	private ReceiverNotificationBandPreferenceDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(ReceiverNotificationBandPreference).ToString(), isNullCacheable: true);

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

	internal int NotificationBandID
	{
		get
		{
			return _EntityDAL.NotificationBandID;
		}
		set
		{
			_EntityDAL.NotificationBandID = value;
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

	public ReceiverNotificationBandPreference()
	{
		_EntityDAL = new ReceiverNotificationBandPreferenceDAL();
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}

	public ReceiverNotificationBandPreference(ReceiverNotificationBandPreferenceDAL dal)
	{
		_EntityDAL = dal;
	}

	internal void Delete()
	{
		if (Settings.Default.IsRemoteCacheForReceiverNotificationBandPreferenceEnabled)
		{
			EntityHelper.DeleteEntityWithRemoteCache(this, _EntityDAL.Delete);
		}
		else
		{
			EntityHelper.DeleteEntity(this, _EntityDAL.Delete);
		}
	}

	internal void Save()
	{
		if (Settings.Default.IsRemoteCacheForReceiverNotificationBandPreferenceEnabled)
		{
			EntityHelper.SaveEntityWithRemoteCache(this, delegate
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
		else
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
	}

	internal static ReceiverNotificationBandPreference Get(long id)
	{
		return EntityHelper.GetEntity<long, ReceiverNotificationBandPreferenceDAL, ReceiverNotificationBandPreference>(EntityCacheInfo, id, () => ReceiverNotificationBandPreferenceDAL.Get(id));
	}

	private static ICollection<ReceiverNotificationBandPreference> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.MultiGetEntity<long, ReceiverNotificationBandPreferenceDAL, ReceiverNotificationBandPreference>(ids, EntityCacheInfo, ReceiverNotificationBandPreferenceDAL.MultiGet);
	}

	public static ReceiverNotificationBandPreference GetByReceiverIDAndNotificationBandID(long receiverID, int notificationBandID)
	{
		if (Settings.Default.IsRemoteCacheForReceiverNotificationBandPreferenceEnabled)
		{
			return EntityHelper.GetEntityByLookupWithRemoteCache<long, ReceiverNotificationBandPreferenceDAL, ReceiverNotificationBandPreference>(EntityCacheInfo, GetLookupCacheKeysByReceiverIDNotificationBandID(receiverID, notificationBandID), () => ReceiverNotificationBandPreferenceDAL.GetReceiverNotificationBandPreferenceByReceiverIDAndNotificationBandID(receiverID, notificationBandID), Get);
		}
		return EntityHelper.GetEntityByLookup<long, ReceiverNotificationBandPreferenceDAL, ReceiverNotificationBandPreference>(EntityCacheInfo, GetLookupCacheKeysByReceiverIDNotificationBandID(receiverID, notificationBandID), () => ReceiverNotificationBandPreferenceDAL.GetReceiverNotificationBandPreferenceByReceiverIDAndNotificationBandID(receiverID, notificationBandID));
	}

	internal static ICollection<ReceiverNotificationBandPreference> GetReceiverNotificationBandPreferencesByReceiverIDPaged(long receiverID, long startRowIndex, long maximumRows)
	{
		string collectionId = $"GetReceiverNotificationBandPreferencesByReceiverIDPaged_ReceiverID:{receiverID}_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy(GetLookupCacheKeysByReceiverID(receiverID)), collectionId, () => ReceiverNotificationBandPreferenceDAL.GetReceiverNotificationBandPreferenceIDsByReceiverIDPaged(receiverID, startRowIndex + 1, maximumRows), MultiGet);
	}

	public void Construct(ReceiverNotificationBandPreferenceDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return GetLookupCacheKeysByReceiverIDNotificationBandID(ReceiverID, NotificationBandID);
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken(GetLookupCacheKeysByReceiverID(ReceiverID));
	}

	private static string GetLookupCacheKeysByReceiverID(long receiverID)
	{
		return $"ReceiverID:{receiverID}";
	}

	private static string GetLookupCacheKeysByReceiverIDNotificationBandID(long receiverID, int notificationBandID)
	{
		return $"ReceiverID:{receiverID}_NotificationBandID:{notificationBandID}";
	}
}
