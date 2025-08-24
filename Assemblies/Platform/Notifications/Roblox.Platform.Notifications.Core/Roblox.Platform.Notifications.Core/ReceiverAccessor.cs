using System;
using Roblox.Platform.Notifications.Core.Entities;

namespace Roblox.Platform.Notifications.Core;

public class ReceiverAccessor : IReceiverAccessor
{
	public IReceiver GetByReceiverTypeAndTarget(ReceiverType receiverType, long receiverTarget)
	{
		Roblox.Platform.Notifications.Core.Entities.Receiver receiverEntity = Roblox.Platform.Notifications.Core.Entities.Receiver.GetOrCreate(Roblox.Platform.Notifications.Core.Entities.ReceiverType.GetOrCreate(receiverType.ToString()).ID, receiverTarget);
		return new Receiver
		{
			Id = receiverEntity.ID,
			ReceiverType = receiverType,
			ReceiverTargetId = receiverTarget
		};
	}

	public IReceiver Get(long receiverId)
	{
		Roblox.Platform.Notifications.Core.Entities.Receiver receiverEntity = Roblox.Platform.Notifications.Core.Entities.Receiver.Get(receiverId);
		Roblox.Platform.Notifications.Core.Entities.ReceiverType receiverTypeEntity = Roblox.Platform.Notifications.Core.Entities.ReceiverType.Get(receiverEntity.ReceiverTypeID);
		ReceiverType receiverType = (ReceiverType)Enum.Parse(typeof(ReceiverType), receiverTypeEntity.Value);
		return new Receiver
		{
			Id = receiverEntity.ID,
			ReceiverType = receiverType,
			ReceiverTargetId = receiverEntity.ReceiverTargetID
		};
	}
}
