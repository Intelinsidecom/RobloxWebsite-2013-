// Minimal stub for Roblox.AssetInstances.Client when the real client assembly is unavailable.
// Only contains what's used in UserAssetOwnershipAuthority.

using System;

namespace Roblox.AssetInstances.Client
{
    public sealed class AssetInstancesClient
    {
        public AssetInstancesClient(Func<string> apiKeyGetter, Func<string> endpointGetter)
        {
            // noop
        }
    }
}
