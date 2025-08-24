namespace Roblox.Platform.Notifications.Push;

internal interface IReceiver
{
	int TypeId { get; }

	long TargetId { get; }
}
