using System;
using Roblox.Economy;
using Roblox.Economy.Common;
using Roblox.Platform.Marketplace.Client.Interfaces;
using Roblox.Platform.Marketplace.Client.Models;

namespace Roblox.Platform.Marketplace.Client
{
    public class MarketplaceAuthority : IMarketplaceAuthority
    {
        public void CreateProduct(byte productType, long? targetId, long? agentId, bool isForSale, bool isPublic, long? priceInRobux, long? priceInTickets, int? minimumMembershipLevel, long universeId, long placeId, float? salePercentage)
        {
            // no-op stub
        }

        public void ChangeProductPrice(long productId, long? newPriceInRobux)
        {
            // Stub: No-op
        }

        public PurchaseProductResult RecurringPurchaseProduct(long ownerUserId, long productId, int currencyType, long expectedPrice, bool recurring, int periodMagnitude, PeriodType periodType, long? callbackUrlId, DateTime? scheduledAt, long flags, byte platformTypeId, int saleLocationType, long? storefrontId, long? existingPrivateServerId)
        {
            return new PurchaseProductResult
            {
                Status = (int)TransactionStatus.Success,
                SaleId = 1
            };
        }

        public RecurringSale GetRecurringSale(long saleId)
        {
            return new RecurringSale { RecurringAmount = 0, SaleID = saleId };
        }

        public bool CancelRecurringSale(long saleId) => true;

        public bool ActivateRecurringSale(long saleId, DateTime activateAt, DateTime? endDate) => true;
    }
}

