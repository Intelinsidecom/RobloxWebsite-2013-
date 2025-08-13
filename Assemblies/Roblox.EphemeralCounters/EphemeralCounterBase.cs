using Roblox.EphemeralCounters.Client;

namespace Roblox.EphemeralCounters;

internal abstract class EphemeralCounterBase
{
	protected readonly EphemeralCountersClient Client;

	protected EphemeralCounterBase(EphemeralCountersClient client)
	{
		Client = client;
	}
}
