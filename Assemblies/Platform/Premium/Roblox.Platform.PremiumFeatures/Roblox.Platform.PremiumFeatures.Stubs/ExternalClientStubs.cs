using Roblox.Platform.PremiumFeatures.Models.Enums;
using Roblox.Platform.PremiumFeatures.Models.Requests;
using Roblox.Platform.PremiumFeatures.Models.Responses;
using Roblox.Platform.PremiumFeatures.Models;

namespace Roblox.PremiumFeatures.Client.Interfaces
{
    // Minimal stub to satisfy compile until real client is wired
    public interface IPremiumFeaturesClient
    {
        PremiumFeatureProductModelResponse GetAvailablePremiumFeaturesProducts(PremiumFeatureType premiumFeatureType);
        SubscriptionProductResponse GetSubscriptionProductForUser(long accountId);
        bool IsPremiumAccount(long accountId);
        BuildersClubCancellationForUserResponse GetBuildersClubCancellationForUser(BuildersClubCancellationForUserRequest request);
        BuildersClubCancellationForUserResponse ExecuteBuildersClubCancellationForUser(BuildersClubCancellationForUserRequest request);
    }
}

namespace Roblox.Billing.Client
{
    using Roblox.Platform.PremiumFeatures.Models.Requests;
    using Roblox.Platform.PremiumFeatures.Models.Responses;
    using Roblox.Platform.PremiumFeatures.Models;

    // Minimal stub to satisfy compile until real client is wired
    public interface IBillingClient
    {
        PremiumFeaturesAvailableProductResponse GetProductDetailFromPremiumFeatureProducts(PremiumFeatureProductDetailRequest request);
        PurchasePlatformResponse GetPurchasePlatformForSubscription(long accountId);
        SubscriptionProductResponse UpdateSubscriptionProductForUser(SubscriptionUpdateForUserRequest request);
        MembershipMigrationModel AttemptMembershipMigration(long userId);
        GetMembershipMigrationAuditLogResponse GetMembershipMigrationAuditLog(long userId);
    }
}

