using System.Collections.Generic;
using Roblox.Identities.Models;

namespace Roblox.Identities.Client
{
    public interface IIdentitiesClient
    {
        WeChatSessionDataResult GetWeChatSessionDataByAccountIdAndIdentityPlatform(long accountId, WeChatIdentityPlatform platform);
        IEnumerable<ExternalIdentityType> GetExternalIdentityTypesWithValidSessions(long accountId, ExternalIdentityPlatformType platformType);
    }
}
