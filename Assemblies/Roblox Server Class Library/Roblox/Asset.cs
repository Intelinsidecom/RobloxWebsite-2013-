using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data;
using Roblox.Data.Interfaces;
using Roblox.DataAccess;
using Roblox.Economy;
using Roblox.Platform.AssetOwnership;
using Roblox.Properties;
using Roblox.Web.SEO;

namespace Roblox;

[DataContract]
[DataObject]
[Obsolete("Should use Roblox.Platform.Assets. This entity is going to be deleted.")]
[DebuggerDisplay("Asset {ID}")]
public class Asset : IAsset, IRobloxEntity<long, AssetDAL>, ICacheableObject<long>, ICacheableObject, IRemoteCacheableObject
{
	public delegate void EntityCreatedEventHandler(Asset sender, EventArgs e);

	public delegate void EntityDeletedEventHandler(Asset sender, EventArgs e);

	public delegate void EntityUpdatedEventHandler(Asset sender, EventArgs e);

	internal AssetDAL _EntityDAL;

	private long? _OriginalCreatorID;

	private bool? _OriginalIsArchived;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: false), "Asset", isNullCacheable: true);

	[DataMember]
	[DataObjectField(true, true, false)]
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

	[DataObjectField(false)]
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

	[DataObjectField(false)]
	public long AssetHashID
	{
		get
		{
			return _EntityDAL.AssetHashID;
		}
		set
		{
			_EntityDAL.AssetHashID = value;
		}
	}

	/// <summary>
	/// A bitmask representation of all AssetCategories associated with this asset
	/// </summary>
	[DataObjectField(false)]
	public ulong AssetCategories
	{
		get
		{
			return (ulong)_EntityDAL.AssetCategories;
		}
		set
		{
			_EntityDAL.AssetCategories = (long)value;
		}
	}

	/// <summary>
	/// A bitmask representation of all AssetGenres associated with this asset
	/// </summary>
	[DataObjectField(false)]
	public ulong AssetGenres
	{
		get
		{
			return (ulong)_EntityDAL.AssetGenres;
		}
		set
		{
			_EntityDAL.AssetGenres = (long)value;
		}
	}

	[DataObjectField(false)]
	public string Hash
	{
		get
		{
			return _EntityDAL.Hash;
		}
		set
		{
			_EntityDAL.Hash = value;
		}
	}

	[DataMember]
	[DataObjectField(false, false)]
	public string Name
	{
		get
		{
			return _EntityDAL.Name;
		}
		internal set
		{
			_EntityDAL.Name = value;
		}
	}

	[DataObjectField(false, false, false)]
	public string Description
	{
		get
		{
			return _EntityDAL.Description ?? string.Empty;
		}
		internal set
		{
			_EntityDAL.Description = value;
		}
	}

	public long CurrentVersionID
	{
		get
		{
			return _EntityDAL.CurrentVersionID;
		}
		set
		{
			_EntityDAL.CurrentVersionID = value;
		}
	}

	/// <summary>
	/// The AgentId of the Creator
	/// </summary>
	public long CreatorID
	{
		get
		{
			return _EntityDAL.CreatorID;
		}
		set
		{
			if (!_OriginalCreatorID.HasValue)
			{
				_OriginalCreatorID = _EntityDAL.CreatorID;
			}
			_EntityDAL.CreatorID = value;
		}
	}

	public bool? IsArchived
	{
		get
		{
			return _EntityDAL.IsArchived;
		}
		set
		{
			if (!_OriginalIsArchived.HasValue)
			{
				_OriginalIsArchived = _EntityDAL.IsArchived;
			}
			_EntityDAL.IsArchived = value;
		}
	}

	[DataObjectField(false)]
	public DateTime Created => _EntityDAL.Created;

	[DataObjectField(false)]
	public DateTime Updated => _EntityDAL.Updated;

	/// <summary>
	/// A search-engine friendly asset NAME (Example: My awesome #1 Vibhu tycoon obby -&gt; My-awesome-1-Vibhu-tycoon-obby)
	/// </summary>
	public string SEOName => NameConverter.ConvertToSEO(Name) + "-item";

	public IEnumerable<AssetCategory> Categories => AssetCategory.ConvertBitMaskToCategories(AssetTypeID, AssetCategories);

	public IEnumerable<AssetGenre> Genres => AssetGenre.ConvertBitMaskToGenres(AssetGenres);

	public ICreator Creator => GetCreator();

	public CreatorRef CreatorRefObject => GetCreatorRefObject();

	[DataObjectField(false)]
	public AssetVersion CurrentVersion
	{
		get
		{
			return AssetVersion.Get(CurrentVersionID);
		}
		set
		{
			if (value != null)
			{
				_EntityDAL.CurrentVersionID = value.ID;
			}
			else
			{
				_EntityDAL.CurrentVersionID = 0L;
			}
		}
	}

	[DataObjectField(false)]
	public AssetHash AssetHash
	{
		get
		{
			return GetAssetHash();
		}
		set
		{
			if (value != null)
			{
				_EntityDAL.AssetHashID = value.ID;
			}
			else
			{
				_EntityDAL.AssetHashID = 0L;
			}
		}
	}

	public bool IsApproved => CurrentVersion?.IsApproved ?? false;

	public bool IsHashDynamic => true;

	public bool IsReviewed => CurrentVersion?.IsReviewed ?? false;

	[DataObjectField(false)]
	public AssetType Type
	{
		get
		{
			return GetAssetType();
		}
		set
		{
			if (value != null)
			{
				_EntityDAL.AssetTypeID = value.ID;
			}
			else
			{
				_EntityDAL.AssetTypeID = 0;
			}
		}
	}

	public bool IsNullCacheable => true;

	public CacheInfo CacheInfo => EntityCacheInfo;

	public static event EntityCreatedEventHandler EntityCreated;

	public static event EntityDeletedEventHandler EntityDeleted;

	public static event EntityUpdatedEventHandler EntityUpdated;

	/// <summary>
	/// Tests to see whether this asset is category compatible with a given Gear asset
	/// </summary>
	/// <param name="gear">Gear to test for Category match against this Asset</param>
	/// <returns>True or False</returns>
	public bool PassesGearCategoryMatch(Asset gear)
	{
		if (gear.AssetCategories == 0L)
		{
			return false;
		}
		return (~AssetOption.GetOrCreate(ID).AllowedGearCategories & gear.AssetCategories) == 0;
	}

	public bool PassesGearGenreMatch(Asset gear)
	{
		if (AssetOption.GetOrCreate(ID).EnforceGenre)
		{
			if (AssetGenres == 0L || gear.AssetGenres == 0L)
			{
				return true;
			}
			return (AssetGenres & gear.AssetGenres) != 0;
		}
		return true;
	}

	private Asset(AssetDAL dal)
	{
		_EntityDAL = dal;
	}

	public Asset()
	{
		_EntityDAL = new AssetDAL();
	}

	public void DelayedReleaseAssetSave()
	{
		EntityHelper.SaveEntity(this, delegate
		{
			_EntityDAL.Created = DateTime.Now;
			_EntityDAL.Updated = DateTime.Now.AddMonths(-4);
			_EntityDAL.Insert();
		}, delegate
		{
			_EntityDAL.Updated = DateTime.Now.AddMonths(-4);
			_EntityDAL.Update();
		});
	}

	public void DelayedReleaseAssetSetUpdate(DateTime newUpdated)
	{
		_EntityDAL.Updated = newUpdated;
	}

	internal void Delete()
	{
		EntityHelper.DeleteEntity(this, _EntityDAL.Delete);
		OnEntityDeleted(this, EventArgs.Empty);
	}

	public AssetHash GetAssetHash()
	{
		return AssetHash.MustGet(AssetHashID);
	}

	public AssetType GetAssetType()
	{
		return AssetType.MustGet(AssetTypeID);
	}

	public ICreator GetCreator()
	{
		return CreatorRefObject.GetCreator();
	}

	public CreatorRef GetCreatorRefObject()
	{
		CreatorRef creatorRef = CreatorRef.CreateNewRefFromAgentId(_EntityDAL.CreatorID);
		if (!creatorRef.IsEmpty())
		{
			return creatorRef;
		}
		throw new DataIntegrityException($"Asset {ID} foreign key failure: CreatorID {_EntityDAL.CreatorID}");
	}

	public AssetVersion GetCurrentVersion()
	{
		return AssetVersion.Get(CurrentVersionID);
	}

	public bool IsPackageAssetType()
	{
		return AssetType.IsPackageAssetType(AssetTypeID);
	}

	public bool IsCommentaryEnabled()
	{
		if (!Comment.GlobalCommentaryIsEnabled)
		{
			return false;
		}
		return AssetOption.GetOrCreate(ID).EnableComments;
	}

	public bool MembershipLevelOk(User user)
	{
		if (!Settings.Default.BCOnlyPlacesEnabled)
		{
			return true;
		}
		AssetOption assetOption = AssetOption.GetOrCreate(ID);
		if (assetOption.MinMembershipType == AssetOption.MembershipType.None)
		{
			return true;
		}
		if (user == null)
		{
			return false;
		}
		if (assetOption.MinMembershipType <= AssetOption.MembershipType.BuildersClub && user.IsBuildersClubMember())
		{
			return true;
		}
		if (assetOption.MinMembershipType <= AssetOption.MembershipType.TurboBuildersClub && user.IsTurboBuildersClubMember())
		{
			return true;
		}
		if (assetOption.MinMembershipType <= AssetOption.MembershipType.OutrageousBuildersClub && user.IsOutrageousBuildersClubMember())
		{
			return true;
		}
		return false;
	}

	internal void Save()
	{
		if (_EntityDAL == null)
		{
			throw new ApplicationException("Required object not provided: EntityDAL.");
		}
		EntityHelper.SaveEntity(this, delegate
		{
			_EntityDAL.Created = DateTime.Now;
			_EntityDAL.Updated = _EntityDAL.Created;
			_EntityDAL.Insert();
			OnEntityCreated(this, EventArgs.Empty);
		}, delegate
		{
			_EntityDAL.Updated = DateTime.Now;
			_EntityDAL.Update();
			OnEntityUpdated(this, EventArgs.Empty);
		});
		_OriginalCreatorID = null;
		_OriginalIsArchived = null;
	}

	public static Asset CreateEmpty()
	{
		return new Asset();
	}

	[Obsolete("Should use Roblox.Platform.Assets.IAssetFactory.")]
	[DataObjectMethod(DataObjectMethodType.Select, true)]
	public static Asset Get(long id)
	{
		if (id <= 0)
		{
			return null;
		}
		return EntityHelper.GetEntity<long, AssetDAL, Asset>(EntityCacheInfo, id, () => AssetDAL.Get(id));
	}

	/// <summary>
	/// Gets <see cref="T:Roblox.Asset" /> by ids.
	/// </summary>
	/// <remarks>Should only be used by Roblox.Platform.Assets.</remarks>
	internal static IEnumerable<Asset> MultiGet(IReadOnlyCollection<long> ids)
	{
		if (ids == null)
		{
			throw new ArgumentNullException("ids");
		}
		List<long> validIds = ids.Where((long id) => id > 0).ToList();
		return EntityHelper.GetEntitiesByIds<Asset, AssetDAL, long>(EntityCacheInfo, validIds, AssetDAL.MultiGet);
	}

	/// <summary>
	/// This method should only be used in the context of EntityHelper.GetEntityCollection. Do not make it internal or public
	/// </summary>
	/// <param name="ids"></param>
	/// <returns></returns>
	private static ICollection<Asset> MultiGet_Private(ICollection<long> ids)
	{
		return EntityHelper.MultiGetEntity<long, AssetDAL, Asset>(ids, EntityCacheInfo, AssetDAL.MultiGet);
	}

	public static Asset Get(long? id)
	{
		if (id.HasValue)
		{
			return Get(id.Value);
		}
		return null;
	}

	/// <summary>
	/// Gets a search-engine friendly URL given an asset (Format: http://www.roblox.com/[item_seo_name]?id=123)
	/// </summary>
	public static string GetSEOURL(Asset asset)
	{
		if (asset == null)
		{
			return string.Empty;
		}
		string name = NameConverter.ConvertToSEO(asset.Name);
		if (asset.Type.ID == AssetType.PlaceID)
		{
			return $"/games/{asset.ID}/{name}";
		}
		return $"/catalog/{asset.ID}/{name}";
	}

	/// <summary>
	/// Gets a search-engine friendly URL given an asset (Format: http://www.roblox.com/[item_seo_name]?id=123)
	/// </summary>
	public static string GetSEOURL(IUserAsset userAsset)
	{
		if (userAsset != null)
		{
			return GetSEOURL(MustGet(userAsset.AssetId));
		}
		throw new ApplicationException("Null userasset passed into GetSEOURL");
	}

	public static ICollection<Asset> GetToolboxAssetsPaged(int toolboxId, int startRowIndex, int maximumRows)
	{
		string collectionId = $"GetToolboxAssetsPaged_ToolboxID:{toolboxId}_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, "ToolboxID:" + toolboxId), collectionId, () => AssetDAL.GetToolboxAssetIDsPaged(toolboxId, startRowIndex + 1, maximumRows), MultiGet_Private);
	}

	public static long GetTotalNumberOfToolboxAssets(int toolboxId)
	{
		string countId = $"GetTotalNumberOfToolboxAssets_ToolboxID:{toolboxId}";
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, "ToolboxID:" + toolboxId), countId, () => AssetDAL.GetTotalNumberOfToolboxAssets(toolboxId));
	}

	public static long GetTotalNumberOfAssetsByTypeAndAgentID(int assetTypeId, long agentId, CreatorType creatorType)
	{
		string countId = $"GetTotalNumberOfAssetsByTypeAndAgentID_AssetTypeID:{assetTypeId}_CreatorID:{agentId}_CreatorType:{creatorType}";
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"AssetTypeID:{assetTypeId}_CreatorID:{agentId}"), countId, () => AssetDAL.GetTotalNumberOfAssetsByCreatorID(assetTypeId, agentId));
	}

	public static ICollection<Asset> GetAssetsByTypeAndUserIDPaged(int assetTypeId, long userId, CreatorType creatorType, int startRowIndex, int maximumRows)
	{
		string collectionId = $"GetAssetsByTypeAndUserIDPaged_AssetTypeID:{assetTypeId}_CreatorID:{userId}_CreatorType:{creatorType}_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"AssetTypeID:{assetTypeId}_CreatorID:{userId}"), collectionId, () => AssetDAL.GetAssetIDsByUserIDPaged(assetTypeId, userId, startRowIndex + 1, maximumRows), MultiGet_Private);
	}

	public static ICollection<Asset> GetAssetsByTypeAndUserIDAndArchivedStatusPaged(int assetTypeId, long userId, CreatorType creatorType, bool isArchived, int startRowIndex, int maximumRows)
	{
		string collectionId = $"GetAssetsByTypeAndUserIDPaged_AssetTypeID:{assetTypeId}_CreatorID:{userId}_CreatorType:{creatorType}_IsArchived:{isArchived}_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		if (!Settings.Default.IsLookupbyAssetArchivedEnabled)
		{
			return GetAssetsByTypeAndUserIDPaged(assetTypeId, userId, creatorType, startRowIndex, maximumRows);
		}
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"AssetTypeID:{assetTypeId}_CreatorID:{userId}_IsArchived:{isArchived}"), collectionId, () => AssetDAL.GetAssetIDsByUserIDAndArchivedStatusPaged(assetTypeId, userId, isArchived, startRowIndex + 1, maximumRows), MultiGet_Private);
	}

	public static Asset MustGet(long id)
	{
		return EntityHelper.MustGet(id, Get);
	}

	public static int LookupAssetTypeId(long assetId)
	{
		return MustGet(assetId).AssetTypeID;
	}

	/// <summary>
	/// place null, gear null =&gt; true
	/// place null, gear non-null =&gt; true
	/// place non-null, gear null =&gt; this will throw, but it never happens apparently.  (since place.PassesGearCategoryMatch(gear) doesn't null-check gear)
	/// place non-null, gear non-null =&gt; (there is a product, and promotion exists) or (gear passes the place category &amp; genre check))
	/// </summary>
	public static bool PlaceAllowsGear(Asset place, Asset gear)
	{
		if (place == null)
		{
			return true;
		}
		bool isPlaceProductPromotion = false;
		if (gear != null)
		{
			Product product = Product.Get(Product.LookupFilter.AssetID, gear.ID);
			if (product == null)
			{
				return false;
			}
			isPlaceProductPromotion = PlaceProductPromotion.GetPlaceProductPromotionByPlaceIDAndProductID(place.ID, product.ID) != null;
		}
		if (isPlaceProductPromotion || (place.PassesGearCategoryMatch(gear) && place.PassesGearGenreMatch(gear)))
		{
			return true;
		}
		return false;
	}

	public void SetGroupItemCreatorAgentId(long agentId)
	{
		_EntityDAL.CreatorID = agentId;
		Save();
	}

	public bool IsCreator(ICreator creator)
	{
		return CreatorRefObject.IsReferenceTo(creator);
	}

	public string GetIdentifier()
	{
		return ID.ToString();
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}

	private static void OnEntityCreated(Asset entity, EventArgs e)
	{
		if (Asset.EntityCreated != null)
		{
			RobloxThreadPool.QueueUserWorkItem(delegate
			{
				Asset.EntityCreated(entity, e);
			});
		}
	}

	private static void OnEntityDeleted(Asset entity, EventArgs e)
	{
		if (Asset.EntityDeleted != null)
		{
			RobloxThreadPool.QueueUserWorkItem(delegate
			{
				Asset.EntityDeleted(entity, e);
			});
		}
	}

	private static void OnEntityUpdated(Asset entity, EventArgs e)
	{
		if (Asset.EntityUpdated != null)
		{
			RobloxThreadPool.QueueUserWorkItem(delegate
			{
				Asset.EntityUpdated(entity, e);
			});
		}
	}

	public void Construct(AssetDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield break;
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		if (_OriginalCreatorID.HasValue)
		{
			yield return new StateToken($"AssetTypeID:{AssetTypeID}_CreatorID:{_OriginalCreatorID}");
			yield return new StateToken($"AssetTypeID:{AssetTypeID}_CreatorID:{_OriginalCreatorID}_IsArchived:{IsArchived == true}");
		}
		if (_OriginalIsArchived.HasValue)
		{
			yield return new StateToken($"AssetTypeID:{AssetTypeID}_CreatorID:{CreatorID}_IsArchived:{_OriginalIsArchived}");
		}
		if (_OriginalCreatorID.HasValue && _OriginalIsArchived.HasValue)
		{
			yield return new StateToken($"AssetTypeID:{AssetTypeID}_CreatorID:{_OriginalCreatorID}_IsArchived:{_OriginalIsArchived}");
		}
		yield return new StateToken($"AssetTypeID:{AssetTypeID}_CreatorID:{CreatorID}");
		yield return new StateToken($"AssetTypeID:{AssetTypeID}_CreatorID:{CreatorID}_IsArchived:{IsArchived == true}");
	}
}
