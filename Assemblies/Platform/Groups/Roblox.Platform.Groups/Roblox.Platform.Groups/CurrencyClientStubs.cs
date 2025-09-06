using System;

#if false
namespace Roblox.Platform.Currency.Client
{
    // Disabled stub: real implementation is provided by Roblox.Platform.Currency.Client project.
    public interface ICurrencyAuthority
    {
        long GetRobuxBalance(long agentId);
        long CreditRobux(long agentId, long amount);
        bool TryDebitRobux(long agentId, long amount);
    }
}
#endif
