using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;
using Roblox.Economy.Properties;

namespace Roblox.Economy;

[Serializable]
public class Product : IRobloxEntity<long, ProductDAL>, ICacheableObject<long>, ICacheableObject, IRemoteCacheableObject
{
	public enum LookupFilter
	{
		AssetID,
		ID
	}

	public delegate void EntityCreatedEventHandler(Product sender, EventArgs e);

	public delegate void EntityDeletedEventHandler(Product sender, EventArgs e);

	public delegate void EntityUpdatedEventHandler(Product sender, EventArgs e);

	private ProductDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "Product", isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	public byte ProductTypeID
	{
		get
		{
			return _EntityDAL.ProductTypeID;
		}
		set
		{
			_EntityDAL.ProductTypeID = value;
		}
	}

	public ProductType ProductType
	{
		get
		{
			return ProductType.Get(ProductTypeID);
		}
		set
		{
			if (value != null)
			{
				ProductTypeID = value.ID;
			}
			else
			{
				ProductTypeID = 0;
			}
		}
	}

	public bool IsPublicDomain
	{
		get
		{
			return _EntityDAL.IsPublicDomain;
		}
		set
		{
			if (value)
			{
				IsForSale = false;
				PriceInRobux = null;
				PriceInTickets = null;
			}
			_EntityDAL.IsPublicDomain = value;
		}
	}

	public bool IsForSale
	{
		get
		{
			return _EntityDAL.IsForSale;
		}
		set
		{
			if (value)
			{
				IsPublicDomain = false;
			}
			else
			{
				PriceInRobux = null;
				PriceInTickets = null;
			}
			_EntityDAL.IsForSale = value;
		}
	}

	public bool IsNew => DateTime.Now.AddDays(-Settings.Default.NewProductDuration) < Created;

	public long? PriceInRobux
	{
		get
		{
			return _EntityDAL.PriceInRobux;
		}
		set
		{
			if (value.HasValue && value > 0)
			{
				IsForSale = true;
			}
			if (value == 0)
			{
				value = null;
			}
			_EntityDAL.PriceInRobux = value;
		}
	}

	public long? PriceInTickets
	{
		get
		{
			return _EntityDAL.PriceInTickets;
		}
		set
		{
			if (value.HasValue && value > 0)
			{
				IsForSale = true;
			}
			if (value == 0)
			{
				value = null;
			}
			_EntityDAL.PriceInTickets = value;
		}
	}

	public int? RobloxProductID
	{
		get
		{
			return _EntityDAL.RobloxProductID;
		}
		set
		{
			_EntityDAL.RobloxProductID = value;
		}
	}

	public RobloxProduct RobloxProduct
	{
		get
		{
			return RobloxProduct.Get(RobloxProductID);
		}
		set
		{
			if (value != null)
			{
				RobloxProductID = value.ID;
			}
			else
			{
				RobloxProductID = null;
			}
		}
	}

	/// <summary>
	/// Stored as AssetID in the db, this is actually a TargetID controlled by ProductType.
	/// </summary>
	public long? TargetID
	{
		get
		{
			return _EntityDAL.AssetID;
		}
		set
		{
			_EntityDAL.AssetID = value;
		}
	}

	public int? AssetTypeID
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

	public long? CreatorID
	{
		get
		{
			return _EntityDAL.CreatorID;
		}
		set
		{
			_EntityDAL.CreatorID = value;
		}
	}

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

	public float? AffiliateFeePercentage
	{
		get
		{
			return (float?)_EntityDAL.AffiliateFeePercentage / 100f;
		}
		set
		{
			if (!value.HasValue || value <= 0f || value > 1f)
			{
				_EntityDAL.AffiliateFeePercentage = null;
			}
			else
			{
				_EntityDAL.AffiliateFeePercentage = (int)(value * 100f).Value;
			}
		}
	}

	public DateTime Created => _EntityDAL.Created;

	public DateTime Updated => _EntityDAL.Updated;

	public ProductOption ProductOptions => ProductOption.GetOrCreate(ID);

	public bool IsLimitedEdition => ProductOptions.IsLimitedEdition;

	public bool IsResellable => ProductOptions.IsResellable;

	public long? TotalAvailable
	{
		get
		{
			return ProductOptions.TotalAvailable;
		}
		set
		{
			ProductOptions.TotalAvailable = value;
		}
	}

	public long? NumberRemaining
	{
		get
		{
			return ProductOptions.NumberRemaining;
		}
		set
		{
			ProductOptions.NumberRemaining = value;
		}
	}

	/// <summary>
	/// If limited edition product, number sold BY ROBLOX. Null if not limited
	/// </summary>
	public long? LimitedEditionSalesCount
	{
		get
		{
			if (!ProductOptions.IsLimitedEdition)
			{
				return null;
			}
			return ProductOptions.TotalAvailable - ProductOptions.NumberRemaining;
		}
	}

	/// <summary>
	/// The ad is a traditional horizontal banner ad.
	/// </summary>
	public static Product UserAd_728x90 => GetByRobloxProductID(RobloxProduct.UserAd_728x90.ID);

	/// <summary>
	/// The ad is a traditional vertical skyscraper ad.
	/// </summary>
	public static Product UserAd_160x600 => GetByRobloxProductID(RobloxProduct.UserAd_160x600.ID);

	/// <summary>
	/// The ad is a traditional square ad.
	/// </summary>
	public static Product UserAd_300x250 => GetByRobloxProductID(RobloxProduct.UserAd_300x250.ID);

	/// <summary>
	/// The ad is a promoted universe for desktop.
	/// </summary>
	public static Product UserAd_PromotedUniverseDesktop => GetByRobloxProductID(RobloxProduct.UserAd_PromotedUniverseDesktop.ID);

	/// <summary>
	/// The ad is a promoted universe for tablet.
	/// </summary>
	public static Product UserAd_PromotedUniverseTablet => GetByRobloxProductID(RobloxProduct.UserAd_PromotedUniverseTablet.ID);

	/// <summary>
	/// The ad is a promoted universe for phone.
	/// </summary>
	public static Product UserAd_PromotedUniversePhone => GetByRobloxProductID(RobloxProduct.UserAd_PromotedUniversePhone.ID);

	/// <summary>
	/// The ad is a promoted universe for console.
	/// </summary>
	public static Product UserAd_PromotedUniverseConsole => GetByRobloxProductID(RobloxProduct.UserAd_PromotedUniverseConsole.ID);

	public static Product Group => GetByRobloxProductID(RobloxProduct.Group.ID);

	public static Product Badge => GetByRobloxProductID(RobloxProduct.Badge.ID);

	public static Product GroupRoleSet => GetByRobloxProductID(RobloxProduct.GroupRoleSet.ID);

	public static Product YouTubeMediaItem => GetByRobloxProductID(RobloxProduct.YouTubeMediaItem.ID);

	public static Product ImageMediaItem => GetByRobloxProductID(RobloxProduct.ImageMediaItem.ID);

	public static Product GamePass => GetByRobloxProductID(RobloxProduct.GamePass.ID);

	public static Product CashOut => GetByRobloxProductID(RobloxProduct.CashOut.ID);

	public static Product Audio => GetByRobloxProductID(RobloxProduct.Audio.ID);

	public static Product AudioShortSoundEffect => GetByRobloxProductID(RobloxProduct.AudioShortSoundEffect.ID);

	public static Product AudioLongSoundEffect => GetByRobloxProductID(RobloxProduct.AudioLongSoundEffect.ID);

	public static Product AudioMusic => GetByRobloxProductID(RobloxProduct.AudioMusic.ID);

	public static Product AudioLongMusic => GetByRobloxProductID(RobloxProduct.AudioLongMusic.ID);

	public static Product UsernameChange => GetByRobloxProductID(RobloxProduct.UsernameChange.ID);

	public static Product Animation => GetByRobloxProductID(RobloxProduct.Animation.ID);

	public static Product Clan => GetByRobloxProductID(RobloxProduct.Clan.ID);

	public static Product PrivateServer => GetByRobloxProductID(RobloxProduct.PrivateServer.ID);

	public CacheInfo CacheInfo => EntityCacheInfo;

	public static event EntityCreatedEventHandler EntityCreated;

	public static event EntityUpdatedEventHandler EntityUpdated;

	public Product()
	{
		_EntityDAL = new ProductDAL();
	}

	public Product(ProductDAL dal)
	{
		_EntityDAL = dal;
	}

	private void EnforceProductDataConsistency()
	{
		if (IsForSale && !PriceInRobux.HasValue && !PriceInTickets.HasValue)
		{
			IsForSale = false;
		}
	}

	public void Save()
	{
		bool num = ID == 0;
		EnforceProductDataConsistency();
		EntityHelper.SaveEntityWithRemoteCache(this, delegate
		{
			_EntityDAL.Created = DateTime.Now;
			_EntityDAL.Updated = Created;
			_EntityDAL.Insert();
		}, delegate
		{
			_EntityDAL.Updated = DateTime.Now;
			_EntityDAL.Update();
		});
		if (num)
		{
			OnEntityCreated(this, EventArgs.Empty);
		}
		else
		{
			OnEntityUpdated(this, EventArgs.Empty);
		}
	}

	private static Product DoGet(long id)
	{
		return EntityHelper.DoGet<long, ProductDAL, Product>(() => ProductDAL.Get(id), id);
	}

	public static Product CreateNew(byte productTypeId, long targetId, bool isPublicDomain, bool isForSale, long? priceInRobux, long? priceInTickets, float? affiliateFeePercentage, long? creatorTargetId)
	{
		Product product = new Product();
		product.ProductTypeID = productTypeId;
		product.TargetID = targetId;
		product.IsPublicDomain = isPublicDomain;
		product.IsForSale = isForSale;
		product.PriceInRobux = priceInRobux;
		product.PriceInTickets = priceInTickets;
		product.AffiliateFeePercentage = affiliateFeePercentage;
		product.CreatorID = creatorTargetId;
		product.Save();
		return product;
	}

	public static Product CreateNew(byte productTypeId, long? targetId, long? sellerUserId, bool isPublicDomain, bool isForSale, long? priceInRobux, long? priceInTickets, int? assetTypeId, long assetGenres, long assetCategories, float? affiliateFeePercentage)
	{
		Product product = new Product();
		product.ProductTypeID = productTypeId;
		product.TargetID = targetId;
		product.CreatorID = sellerUserId;
		product.IsPublicDomain = isPublicDomain;
		product.IsForSale = isForSale;
		product.PriceInRobux = priceInRobux;
		product.PriceInTickets = priceInTickets;
		product.AssetTypeID = assetTypeId;
		product.AssetGenres = (ulong)assetGenres;
		product.AssetCategories = (ulong)assetCategories;
		product.AffiliateFeePercentage = affiliateFeePercentage;
		product.Save();
		return product;
	}

	public static Product CreateNewRobloxProduct(bool isPublicDomain, bool isForSale, long? priceInRobux, long? priceInTickets, RobloxProduct robloxProduct, float? affiliateFeePercentage = null)
	{
		Product product = new Product();
		product.ProductTypeID = ProductType.RobloxProductID;
		product.IsPublicDomain = isPublicDomain;
		product.IsForSale = isForSale;
		product.PriceInRobux = priceInRobux;
		product.PriceInTickets = priceInTickets;
		product.RobloxProduct = robloxProduct;
		product.TargetID = null;
		product.AssetTypeID = null;
		product.CreatorID = null;
		product.AssetGenres = 0uL;
		product.AssetCategories = 0uL;
		product.AffiliateFeePercentage = affiliateFeePercentage;
		product.Save();
		return product;
	}

	public static Product CreateNewUserProduct(bool isPublicDomain, bool isForSale, long? priceInRobux, long? priceInTickets, long assetId, int assetTypeId, long creatorId, ulong assetGenres, ulong assetCategories, float? affiliateFeePercentage = null)
	{
		Product product = new Product();
		product.ProductTypeID = ProductType.UserProductID;
		product.IsPublicDomain = isPublicDomain;
		product.IsForSale = isForSale;
		product.PriceInRobux = priceInRobux;
		product.PriceInTickets = priceInTickets;
		product.RobloxProductID = null;
		product.TargetID = assetId;
		product.AssetTypeID = assetTypeId;
		product.CreatorID = creatorId;
		product.AssetGenres = assetGenres;
		product.AssetCategories = assetCategories;
		product.AffiliateFeePercentage = affiliateFeePercentage;
		product.Save();
		return product;
	}

	public static Product CreateNewResellableProduct(long userAssetId, Product p)
	{
		Product product = new Product();
		product.ProductTypeID = ProductType.ResellableProductID;
		product.IsPublicDomain = p.IsPublicDomain;
		product.IsForSale = p.IsForSale;
		product.PriceInRobux = p.PriceInRobux;
		product.PriceInTickets = p.PriceInRobux;
		product.RobloxProductID = null;
		product.TargetID = userAssetId;
		product.AssetTypeID = p.AssetTypeID;
		product.CreatorID = p.CreatorID;
		product.AssetGenres = p.AssetGenres;
		product.AssetCategories = p.AssetCategories;
		product.AffiliateFeePercentage = p.AffiliateFeePercentage;
		product.Save();
		return product;
	}

	public static Product Get(long id)
	{
		return EntityHelper.GetEntity<long, ProductDAL, Product>(EntityCacheInfo, id, () => ProductDAL.Get(id));
	}

	public static Product Get(long? id)
	{
		if (id.HasValue)
		{
			return Get(id.Value);
		}
		return null;
	}

	public static Product GetByAssetID(long assetId)
	{
		return GetByTypeAndTargetID(ProductType.UserProductID, assetId);
	}

	public static Product GetByUserAssetID(long userAssetId)
	{
		return GetByTypeAndTargetID(ProductType.ResellableProductID, userAssetId);
	}

	public static Product GetByRobloxProductID(int robloxProductId)
	{
		return EntityHelper.GetEntityByLookupWithRemoteCache<long, ProductDAL, Product>(EntityCacheInfo, $"RobloxProductID:{robloxProductId}", () => ProductDAL.GetByRobloxProductID(robloxProductId), Get);
	}

	public static Product GetByDeveloperProductID(long developerProductId)
	{
		return GetByTypeAndTargetID(ProductType.DeveloperProductID, developerProductId);
	}

	public static Product GetByTypeAndTargetID(int productTypeId, long targetId)
	{
		return EntityHelper.GetEntityByLookupWithRemoteCache<long, ProductDAL, Product>(EntityCacheInfo, $"ProductTypeID:{productTypeId}_TargetID:{targetId}", () => ProductDAL.GetByProductTypeIDAndTargetID(productTypeId, targetId), Get);
	}

	/// <summary>
	/// Only use this if you know what you are doing
	/// There are a few assets on production with two Products that match the given ProductTypeId and TargetId
	/// We will have to fix this later and make the two columns have a unique key
	/// </summary>
	/// <param name="productTypeId"></param>
	/// <param name="targetId"></param>
	/// <returns></returns>
	public static ICollection<Product> GetProductsByProductTypeIDAndTargetID(int productTypeId, long targetId)
	{
		string collectionId = $"GetProductsByProductTypeIDAndTargetID_ProductTypeID:{productTypeId}_TargetID:{targetId}";
		string cachedStateQualifier = $"ProductTypeID:{productTypeId}_TargetID:{targetId}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy(cachedStateQualifier), collectionId, () => ProductDAL.GetProductIdsByProductTypeIDAndTargetID(productTypeId, targetId), DoGet);
	}

	public static Product Get(LookupFilter lookupFilter, long id)
	{
		if (lookupFilter == LookupFilter.AssetID)
		{
			return GetByTypeAndTargetID(ProductType.UserProductID, id);
		}
		return Get(id);
	}

	public void Construct(ProductDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		if (_EntityDAL != null)
		{
			if (TargetID.HasValue)
			{
				yield return $"ProductTypeID:{ProductTypeID}_TargetID:{TargetID}";
			}
			if (RobloxProductID.HasValue)
			{
				yield return $"RobloxProductID:{RobloxProductID}";
			}
		}
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		List<StateToken> stateTokens = new List<StateToken>();
		if (AssetTypeID.HasValue)
		{
			stateTokens.Add(new StateToken($"AssetTypeID:{AssetTypeID.Value}_CreatorID:0"));
		}
		if (CreatorID.HasValue)
		{
			stateTokens.Add(new StateToken($"AssetTypeID:0_CreatorID:{CreatorID.Value}"));
		}
		if (AssetTypeID.HasValue && CreatorID.HasValue)
		{
			stateTokens.Add(new StateToken($"AssetTypeID:{AssetTypeID.Value}_CreatorID:{CreatorID.Value}"));
		}
		stateTokens.Add(new StateToken("CreatorID:0"));
		stateTokens.Add(new StateToken($"ProductTypeID:{ProductTypeID}_TargetID:{TargetID}"));
		return stateTokens;
	}

	private static void OnEntityCreated(Product entity, EventArgs e)
	{
		if (Product.EntityCreated != null)
		{
			RobloxThreadPool.QueueUserWorkItem(delegate
			{
				Product.EntityCreated(entity, e);
			});
		}
	}

	private static void OnEntityUpdated(Product entity, EventArgs e)
	{
		if (Product.EntityUpdated != null)
		{
			RobloxThreadPool.QueueUserWorkItem(delegate
			{
				Product.EntityUpdated(entity, e);
			});
		}
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}
}
