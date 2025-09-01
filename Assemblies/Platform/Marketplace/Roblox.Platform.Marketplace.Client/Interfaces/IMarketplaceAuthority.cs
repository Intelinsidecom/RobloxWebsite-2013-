using System;
using Roblox.Economy.Common;
using Roblox.Platform.Marketplace.Client.Models;

namespace Roblox.Platform.Marketplace.Client.Interfaces
{
    public interface IMarketplaceAuthority
    {
        void CreateProduct(byte productType, long? targetId, long? agentId, bool isForSale, bool isPublic, long? priceInRobux, long? priceInTickets, int? minimumMembershipLevel, long universeId, long placeId, float? salePercentage);
        void ChangeProductPrice(long productId, long? newPriceInRobux);
        PurchaseProductResult RecurringPurchaseProduct(long ownerUserId, long productId, int currencyType, long expectedPrice, bool recurring, int periodMagnitude, PeriodType periodType, long? callbackUrlId, DateTime? scheduledAt, long flags, byte platformTypeId, int saleLocationType, long? storefrontId, long? existingPrivateServerId);
        RecurringSale GetRecurringSale(long saleId);
        bool CancelRecurringSale(long saleId);
        bool ActivateRecurringSale(long saleId, DateTime activateAt, DateTime? endDate);
    }
}
