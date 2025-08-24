using System.Collections.Generic;
using Roblox.RequestContext;

namespace Roblox.Platform.PolicyLookup
{
    // Minimal stub to satisfy compile when Roblox.PolicyLookup.dll is unavailable.
    public interface IDefaultPolicyLookup
    {
        ICollection<Policy> GetApplicablePolicies(string userCountryCode, bool isXboxUser, bool isChinaLicenseUser, bool isChinaBetaUser);
    }
}
