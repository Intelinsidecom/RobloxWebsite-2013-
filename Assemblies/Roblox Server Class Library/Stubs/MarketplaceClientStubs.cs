using System;

namespace Roblox.Marketplace.Client
{
    public class PurchaseProductResult
    {
        public int Status { get; set; }
    }

    public class MarketplaceAuthority
    {
        public PurchaseProductResult PurchaseProduct(
            long purchaserId,
            long productId,
            int currencyTypeId,
            long purchasePrice,
            bool placeInHold,
            long placeProductPromotionId,
            byte platformTypeId,
            Roblox.Economy.SaleLocationType saleLocationType,
            long? saleLocationId)
        {
            return new PurchaseProductResult { Status = 0 };
        }
    }
}
