using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;
using Roblox.Locking;
using Roblox.Properties;

namespace Roblox;

public class AssetSetSubscription : IRobloxEntity<int, AssetSetSubscriptionDAL>, ICacheableObject<int>, ICacheableObject
{
	public class MaximumSubscriptionsReached : Exception
	{
	}

	private const string SetDeletedMessage = "You have been unsubscribed from Set ID: {0} because the set has been deleted.";

	private const string SetMadePrivate = "You have been unsubscribed from {0}'s {1} because the set has been made private.";

	private AssetSetSubscriptionDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "Roblox.AssetSetSubscription", isNullCacheable: true);

	public static int MaximumNumberOfAssetSetSubscriptions => Settings.Default.MaximumNumberOfAssetSetSubscriptions;

	public int ID => _EntityDAL.ID;

	public long SubscriberUserID
	{
		get
		{
			return _EntityDAL.SubscriberUserID;
		}
		set
		{
			_EntityDAL.SubscriberUserID = value;
		}
	}

	public long AssetSetCreatorAgentID
	{
		get
		{
			return _EntityDAL.AssetSetCreatorAgentID;
		}
		set
		{
			_EntityDAL.AssetSetCreatorAgentID = value;
		}
	}

	public int AssetSetID
	{
		get
		{
			return _EntityDAL.AssetSetID;
		}
		set
		{
			_EntityDAL.AssetSetID = value;
		}
	}

	public DateTime Created
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

	public DateTime Updated
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

	public User Creator => User.Get(User.GetUserIDByAgentID(AssetSetCreatorAgentID));

	public User SubscriberUser => User.Get(SubscriberUserID);

	public AssetSet AssetSet => AssetSet.Get(AssetSetID);

	public CacheInfo CacheInfo => EntityCacheInfo;

	public AssetSetSubscription()
	{
		_EntityDAL = new AssetSetSubscriptionDAL();
	}

	public static AssetSetSubscription CreateNew(long subscriberUserId, int assetSetId)
	{
		AssetSet assetSet = AssetSet.Get(assetSetId);
		AssetSetSubscription assetSetSubscription = new AssetSetSubscription();
		assetSetSubscription.SubscriberUserID = subscriberUserId;
		assetSetSubscription.AssetSetID = assetSetId;
		assetSetSubscription.AssetSetCreatorAgentID = assetSet.CreatorAgentID;
		assetSetSubscription.Save();
		return assetSetSubscription;
	}

	public void Save()
	{
		EntityHelper.SaveEntity(this, delegate
		{
			LeasedLock orCreate = LeasedLock.GetOrCreate($"AssetSetSubscription_CreateNew_SubscriberUserID:{_EntityDAL.SubscriberUserID}");
			if (!orCreate.TryAcquire(ParallelTaskWorker.ID, 60000))
			{
				throw new ApplicationException("Lock not acquired.");
			}
			if (GetTotalNumberOfAssetSetSubscriptionsBySubscriberUserID(_EntityDAL.SubscriberUserID) >= MaximumNumberOfAssetSetSubscriptions)
			{
				throw new MaximumSubscriptionsReached();
			}
			_EntityDAL.Created = DateTime.Now;
			_EntityDAL.Updated = Created;
			_EntityDAL.Insert();
			orCreate.TryRelease(ParallelTaskWorker.ID);
		}, delegate
		{
			_EntityDAL.Updated = DateTime.Now;
			_EntityDAL.Update();
		});
	}

	public void Delete()
	{
		EntityHelper.DeleteEntity(this, _EntityDAL.Delete);
	}

	public static bool CanSubscribe(int assetSetId, long userId, out string reasonProhibited)
	{
		if (Get(userId, assetSetId) != null)
		{
			reasonProhibited = "User is already subscribed to this set.";
			return false;
		}
		AssetSet set = AssetSet.Get(assetSetId);
		if (set == null)
		{
			reasonProhibited = "Set does not exist.";
			return false;
		}
		if (!set.IsSubscribable)
		{
			reasonProhibited = "This set can not be subscribed to.";
			return false;
		}
		User user = User.Get(userId);
		if (set.Creator.Equals(user))
		{
			reasonProhibited = "This user already owns this set.";
			return false;
		}
		if (GetTotalNumberOfAssetSetSubscriptionsBySubscriberUserID(userId) >= MaximumNumberOfAssetSetSubscriptions)
		{
			reasonProhibited = "This user already has the maximum number of subscriptions allowed.";
			return false;
		}
		reasonProhibited = "";
		return true;
	}

	public static AssetSetSubscription Get(int id)
	{
		return LazyUpdate(EntityHelper.GetEntity<int, AssetSetSubscriptionDAL, AssetSetSubscription>(EntityCacheInfo, id, () => AssetSetSubscriptionDAL.Get(id)));
	}

	public static AssetSetSubscription Get(long subscriberUserId, int assetSetId)
	{
		string lookup = $"SubscriberUserID:{subscriberUserId}_AssetSetID:{assetSetId}";
		return LazyUpdate(EntityHelper.GetEntityByLookup<int, AssetSetSubscriptionDAL, AssetSetSubscription>(EntityCacheInfo, lookup, () => AssetSetSubscriptionDAL.Get(subscriberUserId, assetSetId)));
	}

	private static AssetSetSubscription LazyUpdate(AssetSetSubscription sub)
	{
		if (sub == null)
		{
			return null;
		}
		if (sub.AssetSet == null)
		{
			int setId = sub.AssetSetID;
			long subscriberId2 = sub.SubscriberUserID;
			RobloxThreadPool.QueueUserWorkItem(delegate
			{
				SendUnsubscribeMessage($"You have been unsubscribed from Set ID: {setId} because the set has been deleted.", subscriberId2);
			});
			sub.Delete();
			return null;
		}
		if (!sub.AssetSet.IsSubscribable)
		{
			string creatorName = sub.AssetSet.Creator.Name;
			string setName = sub.AssetSet.Name;
			_ = sub.AssetSetID;
			long subscriberId = sub.SubscriberUserID;
			RobloxThreadPool.QueueUserWorkItem(delegate
			{
				SendUnsubscribeMessage($"You have been unsubscribed from {creatorName}'s {setName} because the set has been made private.", subscriberId);
			});
			sub.Delete();
			return null;
		}
		return sub;
	}

	public static int GetTotalNumberOfAssetSetSubscriptionsBySubscriberUserID(long subscriberUserId)
	{
		string countId = $"GetTotalNumberOfAssetSetSubscriptions_SubscriberUserID:{subscriberUserId}";
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"SubscriberUserID:{subscriberUserId}"), countId, () => AssetSetSubscriptionDAL.GetTotalNumberOfAssetSetSubscriptionsBySubscriberUserID(subscriberUserId));
	}

	public static ICollection<AssetSetSubscription> GetAssetSetSubscriptionBySubscriberUserID(long subscriberUserId, int startRowIndex, int maximumRows)
	{
		string collectionId = $"GetAssetSetSubscriptionBySubscriberUserID_SubscriberUserID:{subscriberUserId}_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		IEnumerable<int> entityIDCollection = EntityHelper.GetEntityIDCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"SubscriberUserID:{subscriberUserId}"), collectionId, () => AssetSetSubscriptionDAL.GetAssetSetSubscriptionIDsBySubscriberUserID(subscriberUserId, startRowIndex, maximumRows));
		ICollection<AssetSetSubscription> entities = new List<AssetSetSubscription>();
		foreach (int item in entityIDCollection)
		{
			AssetSetSubscription entity = Get(item);
			if (entity != null)
			{
				entities.Add(entity);
			}
		}
		return entities;
	}

	public static int GetTotalNumberOfAssetSetSubscriptionsByAssetSetID(int assetSetId)
	{
		string countId = $"GetTotalNumberOfAssetSetSubscriptions_AssetSetID:{assetSetId}";
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"AssetSetID:{assetSetId}"), countId, () => AssetSetSubscriptionDAL.GetTotalNumberOfAssetSetSubscriptionsByAssetSetID(assetSetId));
	}

	public static ICollection<AssetSetSubscription> GetAssetSetSubscriptionByAssetSetID(int assetSetId, int startRowIndex, int maximumRows)
	{
		string collectionId = $"GetAssetSetSubscriptionBySubscriberUserID_AssetSetID:{assetSetId}_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		IEnumerable<int> entityIDCollection = EntityHelper.GetEntityIDCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"AssetSetID:{assetSetId}"), collectionId, () => AssetSetSubscriptionDAL.GetAssetSetSubscriptionIDsByAssetSetID(assetSetId, startRowIndex, maximumRows));
		ICollection<AssetSetSubscription> entities = new List<AssetSetSubscription>();
		foreach (int item in entityIDCollection)
		{
			AssetSetSubscription entity = Get(item);
			if (entity != null)
			{
				entities.Add(entity);
			}
		}
		return entities;
	}

	public static void SendUnsubscribeMessage(string msg, long recipientUserId)
	{
		User recipient = User.Get(recipientUserId);
		Message message = new Message();
		message.MessageTypeID = MessageType.PrivateMessageID;
		message.IsSystemMessage = true;
		message.Recipient = recipient;
		message.Subject = "Unsubscribed From Set";
		message.Body = msg;
		message.Send();
	}

	public void Construct(AssetSetSubscriptionDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		if (_EntityDAL != null)
		{
			yield return $"SubscriberUserID:{SubscriberUserID}_AssetSetID:{AssetSetID}";
		}
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken($"SubscriberUserID:{SubscriberUserID}");
		yield return new StateToken($"AssetSetID:{AssetSetID}");
	}
}
