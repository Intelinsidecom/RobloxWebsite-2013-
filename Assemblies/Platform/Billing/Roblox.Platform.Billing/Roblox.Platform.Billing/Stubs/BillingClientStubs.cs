using System;
using System.Threading.Tasks;

// Stubbed client API for Xsolla/Blackhawk billing integration used by Roblox.Platform.Billing
// These are minimal contract definitions to satisfy compile-time references.
// If/when the real client assembly is added, this file can be removed.

namespace Roblox.Billing.Client
{
    public interface IBillingClient
    {
        // Redemption (redeem PIN)
        Model.XsollaBlackhawkRedemptionModel ProcessXsollaBlackhawkRedemption(string userId, string ip, string pinCode);
        Task<Model.XsollaBlackhawkRedemptionModel> ProcessXsollaBlackhawkRedemptionAsync(string userId, string ip, string pinCode);

        // Reversal (undo redemption)
        Model.ReverseXsollaBlackhawkModel ProcessXsollaBlackhawkReversal(string userId, string pinCode);
        Task<Model.ReverseXsollaBlackhawkModel> ProcessXsollaBlackhawkReversalAsync(string userId, string pinCode);

        // Status lookup
        Model.XsollaBlackhawkStatusModel ProcessXsollaBlackhawkStatusLookup(string userId, string pinCode);
        Task<Model.XsollaBlackhawkStatusModel> ProcessXsollaBlackhawkStatusLookupAsync(string userId, string pinCode);
    }
}

namespace Roblox.Billing.Client.Enums
{
    // Enum values chosen to match comparisons performed in provider code
    public enum RedeemXsollaBlackhawkErrorCode
    {
        None = 0,
        CardAlreadyRedeemed = 10,
        InvalidPin = 20,
        NetworkFailure = 30,
        // Placeholder for any unmapped error bucket used in comparisons
        Unknown = int.MaxValue,
        ConfigurationError = 50,
    }

    public enum ReverseXsollaBlackhawkErrorCode
    {
        None = 0,
        CardNotRedeemed = 10,
        InvalidPin = 20,
        NetworkFailure = 30,
        ConfigurationError = 50,
        Unknown = int.MaxValue,
    }

    public enum XsollaBlackhawkStatusErrorCode
    {
        None = 0,
        CardNotRedeemed = 10,
        InvalidPin = 20,
        NetworkFailure = 30,
        ConfigurationError = 50,
        Unknown = int.MaxValue,
    }
}

namespace Roblox.Billing.Client.Model
{
    using Roblox.Billing.Client.Enums;

    // Redemption models
    public class XsollaBlackhawkRedemptionModel
    {
        public decimal AmountRedeemed { get; set; }
        public string TransactionId { get; set; }
        public int MerchantId { get; set; }
    }

    public class XsollaBlackhawkRedemptionErrorModel : XsollaBlackhawkRedemptionModel
    {
        public RedeemXsollaBlackhawkErrorCode ErrorCode { get; set; }
    }

    // Reversal models
    public class ReverseXsollaBlackhawkModel
    {
        public string TransactionId { get; set; }
    }

    public class ReverseXsollaBlackhawkErrorModel : ReverseXsollaBlackhawkModel
    {
        public ReverseXsollaBlackhawkErrorCode ErrorCode { get; set; }
    }

    // Status lookup models
    public class XsollaBlackhawkStatusModel
    {
        public string TransactionId { get; set; }
        public string Status { get; set; }
    }

    public class XsollaBlackhawkStatusErrorModel : XsollaBlackhawkStatusModel
    {
        public XsollaBlackhawkStatusErrorCode ErrorCode { get; set; }
    }
}
