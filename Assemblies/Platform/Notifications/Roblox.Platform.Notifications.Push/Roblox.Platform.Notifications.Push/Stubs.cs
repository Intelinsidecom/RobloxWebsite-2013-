// Temporary stubs to unblock build for Notifications.Push
// TODO: Replace with real implementations by adding proper project references

namespace Roblox.EphemeralCounters
{
    public interface IEphemeralCounter
    {
        void Increment(int value);
    }

    internal sealed class NoopEphemeralCounter : IEphemeralCounter
    {
        public void Increment(int value) { }
    }

    public class EphemeralCounterFactory
    {
        public IEphemeralCounter GetCounter(string name)
        {
            return new NoopEphemeralCounter();
        }
    }
}

namespace Roblox.Platform.Localization.Accounts
{
    using Roblox.Platform.Membership;

    public interface IMasterResources { }

    public interface ILocalizationResourceProvider
    {
        IMasterResources GetLocalizationResources(IUser user);
    }
}
