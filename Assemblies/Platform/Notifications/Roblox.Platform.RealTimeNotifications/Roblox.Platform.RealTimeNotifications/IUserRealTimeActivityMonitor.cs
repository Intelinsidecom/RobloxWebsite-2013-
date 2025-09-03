namespace Roblox.Platform.RealTimeNotifications
{
    public interface IUserRealTimeActivityMonitor
    {
        void RecordUserRealTimeConnectionActive(long userId);

        bool IsUserActiveNow(long userId);

        bool HasUserBeenActiveRecently(long userId);
    }
}
