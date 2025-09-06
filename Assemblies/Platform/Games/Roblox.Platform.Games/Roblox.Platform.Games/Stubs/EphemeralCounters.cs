namespace Roblox.Platform.EphemeralCounters
{
    // Minimal interface stubs used by PrivateServerConfigurationActionCounters
    public interface IEphemeralCounter
    {
        void Increment(int value);
    }

    public interface IEphemeralCounterFactory
    {
        IEphemeralCounter GetCounter(string name);
    }
}
