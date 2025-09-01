using Roblox.Platform.EphemeralCounters.Client;
namespace Roblox.Platform.EphemeralCounters
{
    abstract class EphemeralCounterBase
    {
        protected readonly EphemeralCountersClient Client;

        protected EphemeralCounterBase(EphemeralCountersClient client)
        {
            Client = client;
        }
    }

}
