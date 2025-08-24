namespace Roblox.Platform.Notifications.Push;

internal class Receiver : IReceiver
{
	public int TypeId { get; private set; }

	public long TargetId { get; private set; }

	public Receiver(int typeId, long targetId)
	{
		TypeId = typeId;
		TargetId = targetId;
	}
}
