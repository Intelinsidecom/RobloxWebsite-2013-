namespace Roblox.Platform.RealTimeNotifications
{
    public interface ISubscriptionResult
    {
	    string ChannelName { get; }

	    object CallbackAction { get; }

	    string ServerId { get; }
    }
}
