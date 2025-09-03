using System;
using Roblox.Assets;
using Roblox.Platform.CatalogItemChangePublisher.Properties;
using Roblox.Economy;
using Roblox.Economy.Common;
using Roblox.EventLog;
using Roblox.Platform.AssetOwnership;
using Roblox.Platform.Assets;
using Roblox.Platform.Counters;
using Roblox.Properties;
using Roblox.WebsiteSettings.Properties;
namespace Roblox.Platform.CatalogItemChangePublisher
{
    static class CatalogItemEventListener
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
            if (Roblox.Platform.CatalogItemChangePublisher.Properties.Settings.Default.NotifyOnImpressionUpdates)
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
}
