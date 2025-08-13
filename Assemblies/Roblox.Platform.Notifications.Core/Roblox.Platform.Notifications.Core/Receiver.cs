namespace Roblox.Platform.Notifications.Core;

internal class Receiver : IReceiver
{
	public long Id { get; internal set; }

	public ReceiverType ReceiverType { get; internal set; }

	public long ReceiverTargetId { get; internal set; }
}
