using Roblox.Entities;

namespace Roblox.Platform.Notifications.Push.Entities;

internal interface IReceiverDestinationEntity : IUpdateableEntity<long>, IEntity<long>
{
	int ReceiverTypeId { get; set; }

	long ReceiverTargetId { get; set; }

	long DestinationId { get; set; }

	bool IsAuthorizedByReceiver { get; set; }

	bool IsActive { get; set; }

	int AuthenticationTypeId { get; set; }

	string AuthenticationValue { get; set; }

	string Name { get; set; }
}
