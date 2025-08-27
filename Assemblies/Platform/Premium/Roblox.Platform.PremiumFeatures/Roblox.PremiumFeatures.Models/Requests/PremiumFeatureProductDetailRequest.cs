using System.Collections.Generic;
using Roblox.PremiumFeatures.Models.Enums;

namespace Roblox.PremiumFeatures.Models.Requests {
    public class PremiumFeatureProductDetailRequest {
        public List<object> PremiumFeatureProducts { get; set; } = new List<object>();
        public bool IsMobile { get; set; }
        public long AccountId { get; set; }
        public PremiumFeaturesProductPlatformType PlatformType { get; set; }
        public int CountryId { get; set; }
    }
}
