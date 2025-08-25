using System;

namespace Roblox.Platform.Currency.Client
{
    // Minimal stub to satisfy Roblox.Groups usage.
    public interface ICurrencyAuthority
    {
        long GetRobuxBalance(long agentId);
        long CreditRobux(long agentId, long amount);
        bool TryDebitRobux(long agentId, long amount);
        // Add other members if compilation reveals additional requirements.
    }
}
