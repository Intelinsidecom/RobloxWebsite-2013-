using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;
using Roblox.Economy;
using Roblox.Properties;

namespace Roblox;

/// When AssetSetItems are retrieved (Get), the public domain bit is checked.  If the item has become
/// publicly unavailable, the associated AssetSetItem is removed;  Also, if they're considered unsafe at that point
/// we delete them.  More efficient to do it on insert than on any retrieval... so maybe move to just the insert tool.
/// *
[DataContract]
public class AssetSetItem : IRobloxEntity<long, AssetSetItemDAL>, ICacheableObject<long>, ICacheableObject
{
	public delegate void EntityCreatedEventHandler(AssetSetItem sender, EventArgs e);

	public delegate void EntityDeletedEventHandler(AssetSetItem sender, EventArgs e);

	private AssetSetItemDAL _EntityDAL;

	public const string ItemUntrusted = "{0}'s {1} has been removed from your {2} set because it has become untrusted.";

	public const string ItemNotPublicDomain = "{0}'s {1} has been removed from your {2} set because it has been removed from public domain.";

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "Roblox.AssetSetItem", isNullCacheable: true);

	[DataMember]
	public long ID
	{
		get
		{
			return _EntityDAL.ID;
		}
		private set
		{
		}
	}

	[DataMember]
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

	[DataMember]
	public long AssetVersionID
	{
		get
		{
			return _EntityDAL.AssetVersionID;
		}
		set
		{
			_EntityDAL.AssetVersionID = value;
		}
	}

	[DataMember]
	public int AssetTypeID
	{
		get
		{
			return _EntityDAL.AssetTypeID;
		}
		set
		{
			_EntityDAL.AssetTypeID = value;
		}
	}

	[DataMember]
	public int SortOrder
	{
		get
		{
			return _EntityDAL.SortOrder;
		}
		set
		{
			_EntityDAL.SortOrder = value;
		}
	}

	[DataMember]
	public string Name
	{
		get
		{
			return AssetVersion.Name;
		}
		private set
		{
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

	public AssetSet AssetSet => AssetSet.Get(AssetSetID);

	public AssetVersion AssetVersion => AssetVersion.Get(AssetVersionID);

	public AssetType AssetType => AssetType.Get(AssetTypeID);

	public AssetHashSafetyRating Rating => AssetHashSafetyRating.GetOrCreate(AssetVersion.AssetHashID);

	public static int MaximumNumberOfItemsPerAssetSet => Settings.Default.MaximumNumberOfItemsPerAssetSet;

	public CacheInfo CacheInfo => EntityCacheInfo;

	public static event EntityCreatedEventHandler EntityCreated;

	public static event EntityDeletedEventHandler EntityDeleted;

	public AssetSetItem()
	{
		_EntityDAL = new AssetSetItemDAL();
	}

	public void Save()
	{
		EntityHelper.SaveEntity(this, delegate
		{
			_EntityDAL.Created = DateTime.Now;
			_EntityDAL.Updated = Created;
			_EntityDAL.Insert();
			OnEntityCreated(this, EventArgs.Empty);
		}, delegate
		{
			_EntityDAL.Updated = DateTime.Now;
			_EntityDAL.Update();
		});
	}

	public void Delete(string removalMessage)
	{
		if (!string.IsNullOrEmpty(removalMessage))
		{
			RobloxThreadPool.QueueUserWorkItem(delegate
			{
				SendItemRemovalMessage(removalMessage, AssetVersionID, AssetSetID);
			});
		}
		EntityHelper.DeleteEntity(this, _EntityDAL.Delete);
		OnEntityDeleted(this, EventArgs.Empty);
	}

	public static void SendItemRemovalMessage(string msg, long assetVersionId, int assetSetId)
	{
		AssetSet set = AssetSet.Get(assetSetId);
		if (set != null && set.Creator.CreatorType != CreatorType.Group)
		{
			User recipient = User.Get(set.Creator.ID);
			AssetVersion version = AssetVersion.Get(assetVersionId);
			Message message = new Message();
			message.MessageTypeID = MessageType.PrivateMessageID;
			message.IsSystemMessage = true;
			message.Recipient = recipient;
			message.Subject = "Item removed from Set " + set.Name;
			message.Body = string.Format(msg, version.Creator.Name, version.Name, set.Name);
			message.Send();
		}
	}

	private static AssetSetItem DoGetOrCreate(int assetSetId, long assetVersionId, int assetTypeId)
	{
		bool created = false;
		AssetSetItem entity = EntityHelper.DoGetOrCreate<long, AssetSetItemDAL, AssetSetItem>(delegate
		{
			EntityHelper.GetOrCreateDALWrapper<AssetSetItemDAL> orCreate = AssetSetItemDAL.GetOrCreate(assetSetId, assetVersionId, assetTypeId);
			created = orCreate.CreatedNewEntity;
			return orCreate;
		});
		if (created)
		{
			OnEntityCreated(entity, EventArgs.Empty);
		}
		return entity;
	}

	public static AssetSetItem GetOrCreate(int assetSetId, long assetVersionId)
	{
		if (GetTotalNumberOfAssetSetItemsByAssetSetIDAndAssetTypeID(assetSetId, null) > MaximumNumberOfItemsPerAssetSet)
		{
			return Get(assetSetId, assetVersionId);
		}
		AssetVersion av = AssetVersion.Get(assetVersionId);
		if (av == null)
		{
			throw new ApplicationException("Invalid AssetVersionID");
		}
		return EntityHelper.GetOrCreateEntity<long, AssetSetItem>(EntityCacheInfo, $"AssetSetID:{assetSetId}_AssetVersionID:{assetVersionId}", () => DoGetOrCreate(assetSetId, assetVersionId, av.AssetTypeID));
	}

	internal static HashSet<long> GetItemAssetIdsBySetId(int assetSetId, int startRowIndex, int maximumRows)
	{
		string collectionId = $"GetItemAssetIdsBySetId_AssetSetID:{assetSetId}_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		string cachedStateQualifier = $"AssetSetID:{assetSetId}";
		return (HashSet<long>)EntityHelper.GetEntityIDCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, cachedStateQualifier), collectionId, delegate
		{
			ICollection<long> assetSetItemIDsPaged = AssetSetItemDAL.GetAssetSetItemIDsPaged(assetSetId, null, startRowIndex + 1, maximumRows);
			HashSet<long> hashSet = new HashSet<long>();
			foreach (long item in assetSetItemIDsPaged)
			{
				AssetVersion assetVersion = AssetVersion.Get(Get(item).AssetVersionID);
				hashSet.Add(assetVersion.AssetID);
			}
			return hashSet;
		});
	}

	public static AssetSetItem Get(long id)
	{
		return LazyUpdate(EntityHelper.GetEntity<long, AssetSetItemDAL, AssetSetItem>(EntityCacheInfo, id, () => AssetSetItemDAL.Get(id)));
	}

	public static AssetSetItem Get(int assetSetId, long assetVersionId)
	{
		return LazyUpdate(EntityHelper.GetEntityByLookup<long, AssetSetItemDAL, AssetSetItem>(EntityCacheInfo, $"AssetSetID:{assetSetId}_AssetVersionID:{assetVersionId}", () => AssetSetItemDAL.Get(assetSetId, assetVersionId)));
	}

	public static AssetSetItem LazyUpdate(AssetSetItem item)
	{
		if (item == null || item.AssetVersion == null)
		{
			return null;
		}
		Product prod = Product.Get(Product.LookupFilter.AssetID, item.AssetVersion.AssetID);
		if (prod != null && !prod.IsPublicDomain)
		{
			item.Delete("{0}'s {1} has been removed from your {2} set because it has been removed from public domain.");
			return null;
		}
		if (item.AssetVersion.IsReviewed && !item.AssetVersion.IsApproved)
		{
			item.Delete("{0}'s {1} has been removed from your {2} set because it has become untrusted.");
			return null;
		}
		AssetHashSafetyRating rating = AssetHashSafetyRating.GetOrCreate(item.AssetVersion.AssetHashID);
		if (item.AssetSet.IsSubscribable && !rating.IsTrusted())
		{
			item.Delete("{0}'s {1} has been removed from your {2} set because it has become untrusted.");
			return null;
		}
		return item;
	}

	public static int GetTotalNumberOfAssetSetItemsByAssetSetIDAndAssetTypeID(int assetSetId, int? assetTypeId)
	{
		string countId = $"GetTotalNumberOfAssetSetItems_AssetSetID:{assetSetId}_AssetTypeID:{assetTypeId}";
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, (!assetTypeId.HasValue) ? $"AssetSetID:{assetSetId}" : $"AssetSetID:{assetSetId}_AssetTypeID:{assetTypeId}"), countId, () => AssetSetItemDAL.GetTotalNumberOfAssetSetItemsByAssetSetIDAndAssetTypeID(assetSetId, assetTypeId));
	}

	public static ICollection<AssetSetItem> GetAssetSetItemsPaged(int assetSetId, int? assetTypeId, int startRowIndex, int maximumRows)
	{
		string collectionId = $"GetAssetSetItemsPaged_AssetSetID:{assetSetId}_AssetTypeID:{assetTypeId}_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		IEnumerable<long> entityIDCollection = EntityHelper.GetEntityIDCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, (!assetTypeId.HasValue) ? $"AssetSetID:{assetSetId}" : $"AssetSetID:{assetSetId}_AssetTypeID:{assetTypeId}"), collectionId, () => AssetSetItemDAL.GetAssetSetItemIDsPaged(assetSetId, assetTypeId, startRowIndex + 1, maximumRows));
		ICollection<AssetSetItem> items = new List<AssetSetItem>();
		foreach (long item2 in entityIDCollection)
		{
			AssetSetItem item = Get(item2);
			if (item != null)
			{
				items.Add(item);
			}
		}
		return items;
	}

	public void Construct(AssetSetItemDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"AssetSetID:{AssetSetID}_AssetVersionID:{AssetVersionID}";
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken($"AssetSetID:{AssetSetID}");
		yield return new StateToken($"AssetSetID:{AssetSetID}_AssetTypeID:{AssetTypeID}");
	}

	private static void OnEntityCreated(AssetSetItem entity, EventArgs e)
	{
		if (AssetSetItem.EntityCreated != null)
		{
			RobloxThreadPool.QueueUserWorkItem(delegate
			{
				AssetSetItem.EntityCreated(entity, e);
			});
		}
	}

	private static void OnEntityDeleted(AssetSetItem entity, EventArgs e)
	{
		if (AssetSetItem.EntityDeleted != null)
		{
			RobloxThreadPool.QueueUserWorkItem(delegate
			{
				AssetSetItem.EntityDeleted(entity, e);
			});
		}
	}
}
