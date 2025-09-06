using Roblox.FloodCheckers.Core;

namespace Roblox.Platform.Chat
{
    internal sealed class StubSuspiciousIpChecker : ISuspiciousIpChecker
    {
        public bool IsSuspicious(string ipAddress) => false;
    }
}
