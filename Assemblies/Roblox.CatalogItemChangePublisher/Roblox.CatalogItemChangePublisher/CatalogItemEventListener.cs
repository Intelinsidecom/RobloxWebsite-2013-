using System;
using Roblox.Assets;
using Roblox.CatalogItemChangePublisher.Properties;
using Roblox.Economy;
using Roblox.Economy.Common;
using Roblox.EventLog;
using Roblox.Platform.AssetOwnership;
using Roblox.Platform.Assets;
using Roblox.Platform.Counters;
using Roblox.Properties;
using Roblox.WebsiteSettings.Properties;

namespace Roblox.CatalogItemChangePublisher;

public static class CatalogItemEventListener
{
	private static IAssetOwnershipAuthority _AssetOwnershipAuthority { get; } = new AssetOwnershipAuthority(Asset.LookupAssetTypeId, "Roblox.CatalogItemChangePublisher", NoOpLogger.Instance);


	/// <summary>
	/// Registers event listeners for Catalog Item changes
	/// </summary>
	public static void Register()
	{
		Asset.EntityCreated += CatalogItemModification_Asset;
		Asset.EntityUpdated += CatalogItemModification_Asset;
		Product.EntityCreated += CatalogItemModification_Product;
		Product.EntityUpdated += CatalogItemModification_Product;
		ProductOption.EntityCreated += CatalogItemModification_ProductOption;
		ProductOption.EntityUpdated += CatalogItemModification_ProductOption;
		AssetOptionEvents.AssetOptionEntityCreated += CatalogItemModification_UserAssetOption;
		AssetOptionEvents.AssetOptionEntityUpdated += CatalogItemModification_UserAssetOption;
		Sale.EntityCreated += CatalogItemModification_Sale;
		Sale.EntityUpdated += CatalogItemModification_Sale;
		RecentlyInsertedAsset.EntityCreated += CatalogItemModification_ModelInsert;
		RecentlyInsertedAsset.EntityUpdated += CatalogItemModification_ModelInsert;
		ImpressionsCounter.ImpressionIncrementEvent = (Action<Item>)Delegate.Combine(ImpressionsCounter.ImpressionIncrementEvent, new Action<Item>(CatalogItemModification_ImpressionsUpdate));
		AssetSetItem.EntityCreated += CatalogItemModification_SetItem;
		AssetSetItem.EntityDeleted += CatalogItemModification_SetItem;
	}

	private static void CatalogItemModification_Asset(Asset asset, EventArgs e)
	{
		Roblox.Platform.Assets.AssetType assetTypeID = (Roblox.Platform.Assets.AssetType)asset.AssetTypeID;
		if (assetTypeID != Roblox.Platform.Assets.AssetType.Place && assetTypeID != Roblox.Platform.Assets.AssetType.SolidModel && assetTypeID != Roblox.Platform.Assets.AssetType.Image)
		{
			CatalogItemChangePublisher.Singleton.Publish(asset.ID);
		}
	}

	private static void CatalogItemModification_Product(Product product, EventArgs e)
	{
		CatalogItemType itemType;
		long? itemTargetId = GetItemIDAndTypeByProduct(product, out itemType);
		if (itemTargetId.HasValue)
		{
			CatalogItemChangePublisher.Singleton.Publish(itemTargetId.Value, itemType, useDelay: true);
		}
	}

	private static void CatalogItemModification_ProductOption(ProductOption productOption, EventArgs e)
	{
		CatalogItemModification_Product(Product.Get(productOption.ProductID), e);
	}

	private static void CatalogItemModification_Sale(Sale sale, EventArgs e)
	{
		CatalogItemType itemType;
		long? itemTargetId = GetItemIDAndTypeByProduct(Product.Get(sale.ProductID), out itemType);
		if (itemTargetId.HasValue)
		{
			CatalogItemChangePublisher.Singleton.Publish(itemTargetId.Value, itemType, useDelay: true);
		}
	}

	private static void CatalogItemModification_UserAssetOption(IUserAssetOption userAssetOption)
	{
		if (Roblox.Properties.Settings.Default.SendLimitedEditionLowestPriceToSolr)
		{
			IUserAsset userAsset = _AssetOwnershipAuthority.GetUserAssetByUserAssetId(userAssetOption.UserAssetId);
			if (userAsset != null && userAsset.AssetTypeId != AssetType.PlaceID)
			{
				CatalogItemChangePublisher.Singleton.Publish(userAsset.AssetId);
			}
		}
	}

	private static void CatalogItemModification_ModelInsert(RecentlyInsertedAsset recentlyInsertedAsset, EventArgs e)
	{
		if (recentlyInsertedAsset.AssetTypeID != AssetType.PlaceID)
		{
			CatalogItemChangePublisher.Singleton.Publish(recentlyInsertedAsset.AssetID, useDelay: true);
		}
	}

	private static void CatalogItemModification_ImpressionsUpdate(Item item)
	{
		if (Roblox.CatalogItemChangePublisher.Properties.Settings.Default.NotifyOnImpressionUpdates)
		{
			CatalogItemChangePublisher.Singleton.Publish(item.TargetId, (CatalogItemType)item.Type);
		}
	}

	private static void CatalogItemModification_SetItem(AssetSetItem item, EventArgs e)
	{
		if (Roblox.Properties.Settings.Default.AssetEndorsementsEnabled && item.AssetSetID == Roblox.WebsiteSettings.Properties.Settings.Default.EndorsedSetId)
		{
			AssetVersion assetVersion = AssetVersion.Get(item.AssetVersionID);
			if (assetVersion != null && item.AssetTypeID != AssetType.PlaceID)
			{
				CatalogItemChangePublisher.Singleton.Publish(assetVersion.AssetID, useDelay: true);
			}
		}
	}

	private static long? GetItemIDAndTypeByProduct(Product product, out CatalogItemType itemType)
	{
		itemType = CatalogItemType.Asset;
		byte productTypeId = product.ProductTypeID;
		if (productTypeId != ProductType.UserProductID && productTypeId != ProductType.ResellableProductID)
		{
			return null;
		}
		long? targetId = product.TargetID;
		if (!targetId.HasValue)
		{
			return null;
		}
		if (product.ProductTypeID == ProductType.BundleProductID)
		{
			itemType = CatalogItemType.Bundle;
			return targetId;
		}
		long assetId;
		if (product.ProductTypeID == ProductType.ResellableProductID)
		{
			IUserAsset userAsset = _AssetOwnershipAuthority.GetUserAssetByUserAssetId(targetId.Value);
			if (userAsset == null || userAsset.AssetTypeId == AssetType.PlaceID)
			{
				return null;
			}
			assetId = userAsset.AssetId;
		}
		else
		{
			assetId = targetId.Value;
		}
		return assetId;
	}
}
