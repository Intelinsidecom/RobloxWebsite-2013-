namespace Roblox.Marketplace.Client
{
    // Minimal interface stub used by UniversePrivateServersSettingsManager
    public interface IMarketplaceAuthority
    {
        void ChangeProductPrice(long productId, long? newPriceInRobux);
        object CreateProduct(byte productTypeId,
                              long? universeId,
                              long? agentId,
                              bool isForSale,
                              bool isPublicDomain,
                              long? priceInRobux,
                              long? initialQuantity,
                              int? minimumMembershipLevel,
                              long contextUserId,
                              long contextGroupId,
                              float? sellerFeePercentage);
    }
}
