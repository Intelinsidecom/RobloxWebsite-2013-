using System;
using System.Collections.Generic;
using Roblox.EventLog;

namespace Roblox.Billing
{
    // Stub replacement for PayPal-dependent Cancellation task leasing
    internal static class Cancellation
    {
        public static ICollection<IParallelWorkTask> LeaseWorkItems(Guid workerId, int numberOfTasks, int leaseDurationInMinutes, int maxCancellationsPerDay, ILogger logger)
        {
            // PayPal/Payflow not available in this environment; do not schedule any cancellations.
            return new List<IParallelWorkTask>();
        }
    }
}
