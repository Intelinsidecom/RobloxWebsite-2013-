using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;
using Roblox.DataAccess;
using Roblox.DataV2.Core;
using Roblox.Economy;
using Roblox.Economy.Common;
using Roblox.EventLog;
using Roblox.HelperClasses.FeedJson;
using Roblox.Platform.AssetOwnership;
using Roblox.WebsiteSettings.Properties;

namespace Roblox;

[Serializable]
public class Feed : IEquatable<Feed>, IRobloxEntity<long, FeedDAL>, ICacheableObject<long>, ICacheableObject, IRemoteCacheableObject
{
	private FeedDAL _EntityDAL;

	private static List<int> _AssetTypeIdsAllowedInFeed = new List<int>
	{
		AssetType.GearID,
		AssetType.HatID,
		AssetType.HairAccessoryID,
		AssetType.FaceAccessoryID,
		AssetType.NeckAccessoryID,
		AssetType.ShoulderAccessoryID,
		AssetType.FrontAccessoryID,
		AssetType.BackAccessoryID,
		AssetType.WaistAccessoryID,
		AssetType.ClimbAnimationID,
		AssetType.DeathAnimationID,
		AssetType.FallAnimationID,
		AssetType.IdleAnimationID,
		AssetType.JumpAnimationID,
		AssetType.RunAnimationID,
		AssetType.SwimAnimationID,
		AssetType.WalkAnimationID,
		AssetType.PoseAnimationID,
		AssetType.PlaceID
	};

	private static IAssetOwnershipAuthority _AssetOwnershipAuthority { get; } = new AssetOwnershipAuthority(Asset.LookupAssetTypeId, "ServerClassLibrary", NoOpLogger.Instance);


	public long ID
	{
		get
		{
			return _EntityDAL.ID;
		}
		set
		{
			_EntityDAL.ID = value;
		}
	}

	public long UserID
	{
		get
		{
			return _EntityDAL.UserID;
		}
		set
		{
			_EntityDAL.UserID = value;
		}
	}

	public long ItemID
	{
		get
		{
			return _EntityDAL.ItemID;
		}
		set
		{
			_EntityDAL.ItemID = value;
		}
	}

	public int ItemType
	{
		get
		{
			return _EntityDAL.ItemType;
		}
		set
		{
			_EntityDAL.ItemType = value;
		}
	}

	public int ActionType
	{
		get
		{
			return _EntityDAL.ActionType;
		}
		set
		{
			_EntityDAL.ActionType = value;
		}
	}

	public string Description
	{
		get
		{
			return _EntityDAL.Description;
		}
		set
		{
			_EntityDAL.Description = value;
		}
	}

	public DateTime ActionDate
	{
		get
		{
			return _EntityDAL.ActionDate;
		}
		set
		{
			_EntityDAL.ActionDate = value;
		}
	}

	public DateTime HarvestDate
	{
		get
		{
			return _EntityDAL.HarvestDate;
		}
		set
		{
			_EntityDAL.HarvestDate = value;
		}
	}

	public User User
	{
		get
		{
			if (_EntityDAL != null && _EntityDAL.UserID != 0L)
			{
				return User.Get(_EntityDAL.UserID);
			}
			return null;
		}
	}

	public CacheInfo CacheInfo => EntityCacheInfo;

	public static CacheInfo EntityCacheInfo => new CacheInfo("Feed");

	public Feed()
	{
		_EntityDAL = new FeedDAL();
	}

	private Feed(FeedDAL dal)
	{
		_EntityDAL = dal;
	}

	private static void UpdateBestFriendsStatus(long viewerID, User bff)
	{
		UserStatus s = UserStatus.GetOrCreate(bff.ID);
		List<Feed> feeds = (List<Feed>)GetFeedsByUserIDAndActionType(bff.ID, FeedType.Status, 1);
		Feed f = null;
		if (feeds.Count > 0)
		{
			f = feeds[0];
		}
		if (s != null && s.ID != 0L && !string.IsNullOrWhiteSpace(s.Message))
		{
			long feedItemID = UpdateFeed(bff.ID, f, s.Message, s.Updated);
			if (!UserFeed.Exists(viewerID, feedItemID))
			{
				UserFeed.CreateNew(viewerID, feedItemID);
			}
		}
	}

	/// <summary>
	/// Checks if the status appearing in Feeds for a particular user is out of date - if so, attempts to grab
	/// the freshest status for that user and place into Feeds
	/// </summary>
	/// <returns></returns>
	private static long UpdateFeed(long userID, Feed f, string message, DateTime date)
	{
		if (string.IsNullOrEmpty(message) || message.Trim().Length <= 0)
		{
			return f.ID;
		}
		if (f != null && f.ID != 0L && f.ActionDate >= date)
		{
			return f.ID;
		}
		f = new Feed
		{
			UserID = userID,
			ActionType = FeedType.Status.ID,
			ItemType = FeedType.Status.ID,
			ItemID = userID,
			ActionDate = date,
			HarvestDate = DateTime.Now,
			Description = message.Trim()
		};
		f.Save();
		return f.ID;
	}

	private static void UpdateGroupStatus(long viewerID, long groupId)
	{
		GroupStatus gs = GroupStatus.GetGroupStatusByGroupID(groupId);
		List<Feed> feeds = (List<Feed>)GetFeedsByItemIDAndActionType(groupId, FeedType.Group, 1);
		Feed f = null;
		if (feeds.Count > 0)
		{
			f = feeds[0];
		}
		if (gs != null && gs.ID != 0L && !string.IsNullOrEmpty(gs.Message) && gs.Message.Trim().Length > 0)
		{
			long feedItemID = gs.UpdateFeed(groupId, f);
			if (!UserFeed.Exists(viewerID, feedItemID))
			{
				UserFeed.CreateNew(viewerID, feedItemID);
			}
		}
	}

	private static void UpdateBoughtItem(long viewerID, User f)
	{
		List<Feed> feeds = (List<Feed>)GetFeedsByUserIDAndActionType(f.ID, FeedType.BoughtItem, 1);
		DateTime lastFeedDate = DateTime.Now.AddDays(-7.0);
		if (feeds.Count > 0 && feeds[0].ActionDate > lastFeedDate)
		{
			lastFeedDate = feeds[0].ActionDate;
		}
		foreach (Sale s in Sale.GetSalesByPurchaserPaged(Convert.ToInt32(f.ID), 0, 10).Reverse())
		{
			if (!(s.Created <= lastFeedDate) && s.TotalPrice != 0L)
			{
				Product p = s.Product;
				if (p.TargetID.HasValue && p.AssetTypeID.HasValue && _AssetTypeIdsAllowedInFeed.Contains(p.AssetTypeID.Value))
				{
					long assetId = ((p.ProductType.ID != ProductType.ResellableProductID) ? p.TargetID.Value : _AssetOwnershipAuthority.GetUserAssetByUserAssetId(p.TargetID.Value).AssetId);
					string json = Serialize(new SingleAssetPackage
					{
						AssetID = assetId
					});
					Feed newFeed = CreateNew(f.ID, f.ID, FeedType.BoughtItem.ID, FeedType.BoughtItem.ID, json, s.Created);
					UserFeed.CreateNew(viewerID, newFeed.ID);
				}
			}
		}
	}

	private static void UpdateCreatedNewPlace(long viewerID, User f)
	{
		List<Feed> feeds = (List<Feed>)GetFeedsByUserIDAndActionType(f.ID, FeedType.NewPlace, 1);
		DateTime lastFeedDate = DateTime.Now.AddDays(-7.0);
		if (feeds.Count > 0 && feeds[0].ActionDate > lastFeedDate)
		{
			lastFeedDate = feeds[0].ActionDate;
		}
		foreach (IUserAsset userAsset in _AssetOwnershipAuthority.GetUserAssetsByUserIdAndAssetTypeId(f.ID, AssetType.PlaceID, long.MaxValue, 10, SortOrder.Desc).Take(2).Reverse())
		{
			if (!(userAsset.Created <= lastFeedDate))
			{
				string json = Serialize(new SingleAssetPackage
				{
					AssetID = userAsset.AssetId
				});
				if (Asset.Get(userAsset.AssetId).GetCreator().ID == userAsset.UserId)
				{
					Feed newFeed = CreateNew(f.ID, f.ID, FeedType.NewPlace.ID, FeedType.NewPlace.ID, json, userAsset.Created);
					UserFeed.CreateNew(viewerID, newFeed.ID);
				}
			}
		}
	}

	public static void CheckForUpdates(long viewerID, Func<long, ICollection<User>> bestFriendsProvider, Func<long, ICollection<long>> getGroupIdsUserIdIsMemberOf)
	{
		RobloxThreadPool.QueueUserWorkItem(delegate
		{
			try
			{
				foreach (User current in bestFriendsProvider(viewerID))
				{
					UpdateBestFriendsStatus(viewerID, current);
					if (Settings.Default.EnableFeedNewPlace)
					{
						UpdateCreatedNewPlace(viewerID, current);
					}
					if (Settings.Default.EnableFeedBoughtItem)
					{
						UpdateBoughtItem(viewerID, current);
					}
				}
				foreach (long current2 in getGroupIdsUserIdIsMemberOf(viewerID))
				{
					UpdateGroupStatus(viewerID, current2);
				}
			}
			catch (Exception ex)
			{
				ExceptionHandler.LogException(ex);
			}
		});
	}

	/// <summary>
	/// Tells client how long it should cache a user's feed for before asking the service to get it again
	/// </summary>
	/// <returns></returns>
	public static int GetLocalCacheInterval()
	{
		return 5;
	}

	/// <summary>
	/// Sets the caching interval
	/// </summary>
	public static void SetLocalCacheInterval(int interval)
	{
	}

	private static Feed DoGet(long id)
	{
		return EntityHelper.DoGet<long, FeedDAL, Feed>(() => FeedDAL.Get(id), id);
	}

	public void Delete()
	{
		EntityHelper.DeleteEntity(this, _EntityDAL.Delete);
	}

	public void Save()
	{
		EntityHelper.SaveEntity(this, delegate
		{
			_EntityDAL.Insert();
		}, delegate
		{
			_EntityDAL.Update();
		});
	}

	public static Feed CreateNew(long userID, long itemID, int itemType, int actionType, string description, DateTime actionDate)
	{
		Feed feed = new Feed();
		feed.UserID = userID;
		feed.ItemID = itemID;
		feed.ItemType = itemType;
		feed.ActionType = actionType;
		feed.Description = description;
		feed.ActionDate = actionDate;
		feed.HarvestDate = actionDate.AddDays(-1.0);
		feed.Save();
		return feed;
	}

	public static Feed Get(long id)
	{
		return EntityHelper.GetEntityOld(EntityCacheInfo, id, () => DoGet(id));
	}

	/// <summary>
	/// Retrieves the feed that a specific user is supposed to see, based on his userfeed
	/// </summary>
	/// <param name="userID"></param>
	/// <returns></returns>
	public static ICollection<Feed> GetFeedForViewer(long userID)
	{
		ICollection<Feed> feed = new List<Feed>();
		foreach (UserFeed item in UserFeed.GetUserFeedsByUserIDPaged(userID, 0, 20))
		{
			Feed f = Get(item.FeedID);
			feed.Add(f);
		}
		return feed;
	}

	public static ICollection<Feed> GetFeedsByUserIDAndActionType(long userID, FeedType actionType, int limit)
	{
		string collectionId = string.Format("GetFeedsByUserIDAndActionType_UserID:{0}_ActionType:{1}", userID, actionType.ID, limit);
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"UserID:{userID}"), collectionId, () => FeedDAL.GetFeedIDsByUserIDAndActionType(userID, actionType.ID, limit), Get);
	}

	public static ICollection<Feed> GetFeedsByItemIDAndActionType(long itemID, FeedType actionType, int limit)
	{
		string collectionId = string.Format("GetFeedsByItemIDAndActionType_ItemID:{0}_ActionType:{1}", itemID, actionType.ID, limit);
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"ItemID:{itemID}"), collectionId, () => FeedDAL.GetFeedIDsByItemIDAndActionType(itemID, actionType.ID, limit), Get);
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		if (_EntityDAL != null)
		{
			yield return $"UserID:{UserID}";
		}
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		return new List<StateToken>
		{
			new StateToken($"UserID:{UserID}"),
			new StateToken($"ItemID:{ItemID}")
		};
	}

	public void Construct(FeedDAL dal)
	{
		_EntityDAL = dal;
	}

	public bool Equals(Feed other)
	{
		if (other == null)
		{
			return false;
		}
		return ID == other.ID;
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}

	public static string Serialize<T>(T obj)
	{
		DataContractJsonSerializer serializer = new DataContractJsonSerializer(obj.GetType());
		using MemoryStream ms = new MemoryStream();
		serializer.WriteObject(ms, obj);
		return Encoding.UTF8.GetString(ms.ToArray());
	}
}
