// Minimal stubs to satisfy references to Roblox.Marketplace.Client and Roblox.Currency.Client
// Replace with real assemblies when available.

namespace Roblox.Marketplace.Client
{
    public enum SaleLocationType
    {
        None = 0
    }

    public class PurchaseProductResult
    {
        public long? SaleId { get; set; }
        public int Status { get; set; }
    }

    public interface IMarketplaceAuthority
    {
        PurchaseProductResult PurchaseProduct(long purchaserUserId, long productId, int currencyId, long price, bool isLowConfidence, long buyerAssetId, int platformTypeId, SaleLocationType saleLocationType, long? referrerId);
    }
}

namespace Roblox.Currency.Client
{
    public class CurrencyBalances
    {
        public long RobuxBalance { get; set; }
    }

    public interface ICurrencyAuthority
    {
        CurrencyBalances GetCurrencyBalances(long agentId);
        long GetRobuxBalance(long userId);
        void CreditRobux(long userId, long amount);
    }
}
