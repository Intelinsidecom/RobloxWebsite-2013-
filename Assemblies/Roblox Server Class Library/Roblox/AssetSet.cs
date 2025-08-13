using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Threading;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;
using Roblox.EventLog;
using Roblox.Locking;
using Roblox.Properties;

namespace Roblox;

[DataContract]
public class AssetSet : IRobloxEntity<int, AssetSetDAL>, ICacheableObject<int>, ICacheableObject
{
	public class MaximumSetsReached : Exception
	{
	}

	private AssetSetDAL _EntityDAL;

	private CreatorRef _CreatorRef = CreatorRef.Empty;

	public static readonly string MyStuffSetName;

	public static readonly string FavoritesSetName;

	private static SelfDisposingTimer timer;

	private static List<AssetSet> _RobloxSets;

	public static string[] SuperSafePrivacyNameAdjectiveChoices;

	public static string[] SuperSafePrivacyNameCategoryChoices;

	public static string[] SuperSafePrivacyNameNounChoices;

	public static List<string> AllStrings;

	public static CacheInfo EntityCacheInfo;

	[DataMember]
	public int ID
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
	public string Name
	{
		get
		{
			return _EntityDAL.Name;
		}
		set
		{
			if (value.Length > 100)
			{
				_EntityDAL.Name = value.Substring(0, 100);
			}
			else
			{
				_EntityDAL.Name = value;
			}
		}
	}

	[DataMember]
	public string Description
	{
		get
		{
			return _EntityDAL.Description;
		}
		set
		{
			if (value.Length > 500)
			{
				_EntityDAL.Description = value.Substring(0, 500);
			}
			else
			{
				_EntityDAL.Description = value;
			}
		}
	}

	[DataMember]
	public long CreatorUserID
	{
		get
		{
			if (CreatorRef.CreateNewRefFromAgentId(CreatorAgentID).IsGroupType())
			{
				return 0L;
			}
			return User.GetUserIDByAgentID(CreatorAgentID);
		}
		private set
		{
		}
	}

	public long CreatorAgentID
	{
		get
		{
			long creatorId = _EntityDAL.CreatorAgentID;
			if (_CreatorRef.AgentID != creatorId)
			{
				_CreatorRef = CreatorRef.CreateNewRefFromAgentId(creatorId);
			}
			return creatorId;
		}
		set
		{
			_EntityDAL.CreatorAgentID = value;
			if (_CreatorRef.AgentID != value)
			{
				_CreatorRef = CreatorRef.CreateNewRefFromAgentId(value);
			}
		}
	}

	[DataMember]
	public long ImageAssetID
	{
		get
		{
			return _EntityDAL.ImageAssetID;
		}
		set
		{
			_EntityDAL.ImageAssetID = value;
		}
	}

	[DataMember]
	public bool IsSubscribable
	{
		get
		{
			return _EntityDAL.IsSubscribable;
		}
		private set
		{
		}
	}

	[DataMember(Name = "Created")]
	private string CreatedJSON
	{
		get
		{
			return Created.ToString();
		}
		set
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

	[DataMember(Name = "Updated")]
	private string UpdatedJSON
	{
		get
		{
			return Updated.ToString();
		}
		set
		{
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

	public ICreator Creator => _CreatorRef.GetCreator();

	public CreatorRef CreatorRef
	{
		get
		{
			if (_CreatorRef.Equals(CreatorRef.Empty))
			{
				_CreatorRef = CreatorRef.CreateNewRefFromAgentId(_EntityDAL.CreatorAgentID);
			}
			return _CreatorRef;
		}
	}

	public Asset ImageAsset => Asset.Get(ImageAssetID);

	public static int MaximumNumberOfAssetSetsPerOwner => Settings.Default.MaximumNumberOfAssetSetsPerOwner;

	public static long MyModelsSetDefaultImageAssetID => Settings.Default.MyModelsSetDefaultImageAssetID;

	public static long MyDecalsSetDefaultImageAssetID => Settings.Default.MyDecalsSetDefaultImageAssetID;

	public static List<AssetSet> RobloxSets => _RobloxSets;

	[DataMember]
	private int SubscriberCount
	{
		get
		{
			return GetSubscriberCount();
		}
		set
		{
		}
	}

	public CacheInfo CacheInfo => EntityCacheInfo;

	private static void LoadRobloxSets()
	{
		try
		{
			List<AssetSet> sets = new List<AssetSet>();
			if (!string.IsNullOrEmpty(Settings.Default.RobloxSets))
			{
				string[] array = Settings.Default.RobloxSets.Split(';');
				foreach (string setString in array)
				{
					sets.Add(Get(Convert.ToInt32(setString)));
				}
			}
			_RobloxSets = sets;
		}
		catch (ThreadAbortException)
		{
			throw;
		}
		catch (Exception ex2)
		{
			ExceptionHandler.LogException(ex2);
		}
	}

	public static string GetSuperSafePrivacyDescription(User user)
	{
		return $"{user.Name}'s cool set of items.";
	}

	public static bool IsSuperSafeName(string name)
	{
		string[] array = name.Split(' ');
		foreach (string word in array)
		{
			if (!AllStrings.Contains(word))
			{
				return false;
			}
		}
		return true;
	}

	/// Crud *
	static AssetSet()
	{
		MyStuffSetName = "My Stuff";
		FavoritesSetName = "Favorites";
		_RobloxSets = new List<AssetSet>();
		SuperSafePrivacyNameAdjectiveChoices = new string[31]
		{
			"", "Basic", "Glorious", "L33t", "Uber", "Cool", "Awesome", "Sweet", "Radical", "Gnarly",
			"Scarey", "Nifty", "Futuristic", "Deadly", "Quick", "Magical", "Spacious", "Exterior", "Interior", "Gigantic",
			"Miniature", "Small", "Tiny", "Huge", "Popular", "Clever", "Tricksy", "Stealthy", "Enchanting", "Brilliant",
			"Destructive"
		};
		SuperSafePrivacyNameCategoryChoices = new string[29]
		{
			"", "Medieval", "Fantasy", "World War II", "World War I", "Ninja", "Samurai", "Sci-Fi", "Horror", "LOL",
			"Fantasy", "Modern Military", "Pirate", "Sports", "Town and City", "Wild West", "Egyptian", "Roman", "Greek", "Aquatic",
			"Space", "Star Wars", "Elven", "Orc", "Troll", "Goblin", "Wizard", "Magical", "Technological"
		};
		SuperSafePrivacyNameNounChoices = new string[49]
		{
			"Items", "Cars", "Parts", "Tools", "Toys", "Kits", "Weapons", "Guns", "Armor", "Cars",
			"Buildings", "Vehicles", "Furniture", "Chairs", "Boats", "Ships", "Trains", "Airplanes", "Hats", "Scenes",
			"Windows", "Doors", "Rooms", "Traps", "Beds", "Houses", "Castles", "Set", "Pies", "Foods",
			"Easter Eggs", "Figures", "Models", "Things", "NPCs", "Showcases", "Games", "Factories", "Stores", "Shops",
			"Animals", "Bears", "Lions", "Minibears", "RobloTims", "Bags", "Logos", "Decals", "Bots"
		};
		AllStrings = new List<string>();
		EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "Roblox.AssetSet", isNullCacheable: true);
		string[] superSafePrivacyNameAdjectiveChoices = SuperSafePrivacyNameAdjectiveChoices;
		for (int i = 0; i < superSafePrivacyNameAdjectiveChoices.Length; i++)
		{
			string[] array = superSafePrivacyNameAdjectiveChoices[i].Split(' ');
			foreach (string brokenEl in array)
			{
				AllStrings.Add(brokenEl);
			}
		}
		superSafePrivacyNameAdjectiveChoices = SuperSafePrivacyNameCategoryChoices;
		for (int i = 0; i < superSafePrivacyNameAdjectiveChoices.Length; i++)
		{
			string[] array = superSafePrivacyNameAdjectiveChoices[i].Split(' ');
			foreach (string brokenEl2 in array)
			{
				AllStrings.Add(brokenEl2);
			}
		}
		superSafePrivacyNameAdjectiveChoices = SuperSafePrivacyNameNounChoices;
		for (int i = 0; i < superSafePrivacyNameAdjectiveChoices.Length; i++)
		{
			string[] array = superSafePrivacyNameAdjectiveChoices[i].Split(' ');
			foreach (string brokenEl3 in array)
			{
				AllStrings.Add(brokenEl3);
			}
		}
		LoadRobloxSets();
		timer = new SelfDisposingTimer(LoadRobloxSets, TimeSpan.FromMinutes(5.0), TimeSpan.FromMinutes(5.0));
	}

	public AssetSet()
	{
		_EntityDAL = new AssetSetDAL();
	}

	public static AssetSet CreateNew(string name, string description, long creatorAgentId, long imageAssetId, bool isSubscribable)
	{
		AssetSet assetSet = new AssetSet();
		assetSet.Name = name;
		assetSet.Description = description;
		assetSet.CreatorAgentID = creatorAgentId;
		assetSet.ImageAssetID = imageAssetId;
		assetSet._EntityDAL.IsSubscribable = isSubscribable;
		assetSet.Save();
		return assetSet;
	}

	public void Save()
	{
		EntityHelper.SaveEntity(this, delegate
		{
			LeasedLock orCreate = LeasedLock.GetOrCreate($"AssetSet_CreateNew_CreatorAgentID:{_EntityDAL.CreatorAgentID}");
			if (!orCreate.TryAcquire(ParallelTaskWorker.ID, 60000))
			{
				throw new ApplicationException("Lock not acquired.");
			}
			if (GetTotalNumberOfAssetSetsByCreatorAgentID(_EntityDAL.CreatorAgentID) >= MaximumNumberOfAssetSetsPerOwner)
			{
				throw new MaximumSetsReached();
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
		foreach (AssetSetItem assetSetItem in GetAssetSetItems(null, 0, AssetSetItem.MaximumNumberOfItemsPerAssetSet))
		{
			assetSetItem.Delete(string.Empty);
		}
		EntityHelper.DeleteEntity(this, _EntityDAL.Delete);
	}

	/// Methods *
	public bool AddItem(long assetId, long assetVId)
	{
		Asset asset = Asset.Get(assetId);
		if (asset == null)
		{
			ExceptionHandler.LogException("Asset does not exist", LogLevel.Warning);
			return true;
		}
		if (!IsProperAssetType(asset))
		{
			throw new ApplicationException("Invalid asset type");
		}
		if (AssetSetItem.GetOrCreate(ID, (assetVId == 0L) ? asset.CurrentVersionID : assetVId) == null)
		{
			return false;
		}
		return true;
	}

	public void RemoveItem(long itemId)
	{
		AssetSetItem.Get(itemId)?.Delete(string.Empty);
	}

	public void SetSubscribability(bool isSubscribable)
	{
		if (IsSubscribable == isSubscribable || IsSubscribable)
		{
			return;
		}
		foreach (AssetSetItem item in GetAssetSetItems(null, 0, AssetSetItem.MaximumNumberOfItemsPerAssetSet))
		{
			AssetSetItem assetSetItem = item;
			if (assetSetItem == null)
			{
				continue;
			}
			long assetHashId = assetSetItem.AssetVersion.AssetHashID;
			RobloxThreadPool.QueueUserWorkItem(delegate
			{
				if (!AssetHashSafetyRating.GetOrCreate(assetHashId).IsTrusted())
				{
					assetSetItem.Delete("{0}'s {1} has been removed from your {2} set because it has become untrusted.");
				}
			});
		}
	}

	public int GetAssetSetItemCount(int? assetTypeId)
	{
		return AssetSetItem.GetTotalNumberOfAssetSetItemsByAssetSetIDAndAssetTypeID(ID, assetTypeId);
	}

	public int GetSubscriberCount()
	{
		if (!IsSubscribable)
		{
			return 0;
		}
		return AssetSetSubscription.GetTotalNumberOfAssetSetSubscriptionsByAssetSetID(ID);
	}

	public ICollection<AssetSetItem> GetAssetSetItems(int? assetTypeId, int startRowIndex, int maximumRows)
	{
		return AssetSetItem.GetAssetSetItemsPaged(ID, assetTypeId, startRowIndex, maximumRows);
	}

	/// Static Methods *
	public static bool IsProperAssetType(Asset asset)
	{
		if (asset.AssetTypeID != AssetType.DecalID && asset.AssetTypeID != AssetType.ModelID && asset.AssetTypeID != AssetType.AudioID)
		{
			return asset.AssetTypeID == AssetType.PluginID;
		}
		return true;
	}

	public static bool CanCreateSet(User user)
	{
		if (user == null)
		{
			return false;
		}
		return GetTotalNumberOfAssetSetsByCreatorAgentID(user.GetAgentID()) < MaximumNumberOfAssetSetsPerOwner;
	}

	public static AssetSet Get(int id)
	{
		return EntityHelper.GetEntity<int, AssetSetDAL, AssetSet>(EntityCacheInfo, id, () => AssetSetDAL.Get(id));
	}

	public static AssetSet Get(long creatorAgentId, string name)
	{
		string lookup = $"CreatorAgentID:{creatorAgentId}_Name:{name}";
		return EntityHelper.GetEntityByLookup<int, AssetSetDAL, AssetSet>(EntityCacheInfo, lookup, () => AssetSetDAL.Get(creatorAgentId, name));
	}

	public static int GetTotalNumberOfAssetSetsByCreatorAgentID(long creatorAgentId)
	{
		string countId = "GetTotalNumberOfAssetSets_CreatorAgentID:" + creatorAgentId;
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"CreatorAgentID:{creatorAgentId}"), countId, () => AssetSetDAL.GetTotalNumberOfAssetSetsByCreatorAgentID(creatorAgentId));
	}

	public static ICollection<AssetSet> GetAssetSetsPaged(long creatorAgentId, int startRowIndex, int maximumRows)
	{
		string collectionId = $"GetAssetSetsPaged_CreatorID:{creatorAgentId}_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"CreatorAgentID:{creatorAgentId}"), collectionId, () => AssetSetDAL.GetAssetSetIDsPaged(creatorAgentId, startRowIndex + 1, maximumRows), Get);
	}

	public static int GetTotalNumberOfAssetSetsBySearchCriteria(string keyword)
	{
		string countId = $"GetTotalNumberOfAssetSetsBySearchCriteria_Keyword:{keyword}";
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Unqualified, null), countId, () => AssetSetDAL.GetTotalNumberOfAssetSetsBySearchCriteria(keyword));
	}

	public bool ContainsAsset(long assetId)
	{
		return AssetSetItem.GetItemAssetIdsBySetId(ID, 0, Settings.Default.MaximumNumberOfItemsPerAssetSet).Contains(assetId);
	}

	public static ICollection<AssetSet> GetAssetSetsByKeywordSearchPagedAndSorted(string keyword, int startRowIndex, int maximumRows)
	{
		string collectionId = $"GetAssetSetsByKeywordSearchPagedAndSorted_Keyword:{keyword}_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Unqualified, null), collectionId, () => AssetSetDAL.GetAssetSetIDsByKeywordSearchPagedAndSorted(keyword, startRowIndex + 1, maximumRows), Get);
	}

	public void Construct(AssetSetDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"CreatorAgentID:{CreatorAgentID}_Name:{Name}";
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken($"CreatorAgentID:{CreatorAgentID}");
	}
}
