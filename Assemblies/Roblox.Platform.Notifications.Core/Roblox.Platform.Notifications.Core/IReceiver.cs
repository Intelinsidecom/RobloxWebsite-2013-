namespace Roblox.Platform.Notifications.Core;

public interface IReceiver
{
	long Id { get; }

	ReceiverType ReceiverType { get; }

	long ReceiverTargetId { get; }
}
