namespace Roblox.PremiumFeatures.Models.Requests {
    public class SubscriptionUpdateForUserRequest {
        public long AccountId { get; set; }
        public int PremiumFeatureId { get; set; }
        public bool IsRecurring { get; set; }
    }
}
