using Roblox.Entities;

namespace Roblox.Platform.Notifications.Push.Entities;

internal interface IDestinationEntity : IUpdateableEntity<long>, IEntity<long>
{
	int DestinationTypeId { get; set; }

	string ExternalServiceDestinationId { get; set; }

	string NotificationDeliveryEndpoint { get; set; }

	byte[] ExternalServiceDestinationIdHash { get; set; }
}
