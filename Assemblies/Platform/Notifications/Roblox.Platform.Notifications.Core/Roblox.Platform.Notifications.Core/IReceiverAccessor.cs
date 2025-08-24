namespace Roblox.Platform.Notifications.Core;

public interface IReceiverAccessor
{
	IReceiver GetByReceiverTypeAndTarget(ReceiverType receiverType, long receiverTarget);

	IReceiver Get(long receiverId);
}
