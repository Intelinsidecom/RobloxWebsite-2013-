using Roblox.EphemeralCounters.Client;
namespace Roblox.Platform.EphemeralCountersinternal {
    abstract class EphemeralCounterBase

{
	protected readonly EphemeralCountersClient Client;

	protected EphemeralCounterBase(EphemeralCountersClient client)
	{
		Client = client;
	}
}


}
