namespace Roblox.RealTimeNotifications;

public interface ISubscriptionResult
{
	string ChannelName { get; }

	object CallbackAction { get; }

	string ServerId { get; }
}
