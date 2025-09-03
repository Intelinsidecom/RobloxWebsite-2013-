using System;
using Roblox.PremiumFeatures;

namespace Roblox
{
    // Minimal helper to satisfy references in PremiumFeatures tasks.
    public static class PremiumFeatureHelper
    {
        // Static worker ID placeholder
        public static Guid WorkerID { get; } = Guid.Empty;

        // Returns a base expiration from a start time and a duration type.
        // Placeholder logic: if DurationType exposes a length, prefer it; otherwise default to 30 days.
        public static DateTime CalculateBaseExpiration(DateTime start, DurationType durationType, bool isRenewal)
        {
            // Try to infer duration from known fields if present; fall back to 30 days.
            try
            {
                // Common patterns: durationType.Days, .Months, .Value, etc. We safely branch.
                // Note: This is placeholder; adjust if DurationType exposes concrete fields.
                int days = 30;
                var valueProp = durationType?.GetType().GetProperty("Days");
                if (valueProp != null)
                {
                    object v = valueProp.GetValue(durationType, null);
                    if (v is int d && d > 0) days = d;
                }
                return start.AddDays(days);
            }
            catch
            {
                return start.AddDays(30);
            }
        }

        // Returns the unpadded expiration; placeholder returns the provided expiration.
        public static DateTime CalculateGracePeriodAwareUnpaddedExpiration(DateTime expiration, bool isRenewal)
        {
            return expiration;
        }

        // Renewal date helper; placeholder: return baseExpiration for renewals; otherwise null.
        public static DateTime? CalculateRenewal(DateTime baseExpiration, bool isRenewal)
        {
            return isRenewal ? baseExpiration : (DateTime?)null;
        }
    }
}
