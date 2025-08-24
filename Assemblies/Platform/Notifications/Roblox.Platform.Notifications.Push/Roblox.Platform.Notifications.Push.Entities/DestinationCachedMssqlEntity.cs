using System;
using Roblox.Entities;
using Roblox.Platform.Notifications.Push.Entities.BLL;

namespace Roblox.Platform.Notifications.Push.Entities;

internal class DestinationCachedMssqlEntity : IDestinationEntity, IUpdateableEntity<long>, IEntity<long>
{
	public long Id { get; set; }

	public int DestinationTypeId { get; set; }

	public string ExternalServiceDestinationId { get; set; }

	public string NotificationDeliveryEndpoint { get; set; }

	public DateTime Created { get; set; }

	public DateTime Updated { get; set; }

	public byte[] ExternalServiceDestinationIdHash { get; set; }

	public void Update()
	{
		Destination cal = Destination.Get(Id);
		if (cal == null)
		{
			throw new InvalidOperationException("Attempted update on unpersisted entity.");
		}
		cal.DestinationTypeID = DestinationTypeId;
		cal.ExternalServiceDestinationID = ExternalServiceDestinationId;
		cal.NotificationDeliveryEndpoint = NotificationDeliveryEndpoint;
		cal.ExternalServiceDestinationIDHash = ExternalServiceDestinationIdHash;
		cal.Save();
		Updated = cal.Updated;
	}

	public void Delete()
	{
		(Destination.Get(Id) ?? throw new InvalidOperationException("Attempted delete on unpersisted entity.")).Delete();
	}
}
