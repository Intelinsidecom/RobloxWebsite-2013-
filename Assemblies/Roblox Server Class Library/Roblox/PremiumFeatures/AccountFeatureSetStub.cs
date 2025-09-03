using System;

namespace Roblox.PremiumFeatures
{
    // Temporary stub to break circular project dependency with Roblox.Platform.PremiumFeatures
    // Only the members used by Roblox.Showcase are implemented.
    internal class AccountFeatureSet
    {
        public long AccountID { get; }
        public byte ShowcaseAllotment { get; set; }
        public DateTime Created { get; } = DateTime.MinValue;
        public DateTime Updated { get; } = DateTime.MinValue;

        private AccountFeatureSet(long accountId, byte showcaseAllotment)
        {
            AccountID = accountId;
            ShowcaseAllotment = showcaseAllotment;
        }

        public static AccountFeatureSet GetOrCreate(long accountId)
        {
            // Use a generous default to avoid inadvertently deleting user showcases.
            const byte defaultAllotment = 50;
            return new AccountFeatureSet(accountId, defaultAllotment);
        }
    }
}
