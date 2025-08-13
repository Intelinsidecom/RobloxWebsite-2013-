using System;
using Roblox.Entities;
using Roblox.Platform.Notifications.Push.Entities.BLL;

namespace Roblox.Platform.Notifications.Push.Entities;

internal class ReceiverDestinationCachedMssqlEntity : IReceiverDestinationEntity, IUpdateableEntity<long>, IEntity<long>
{
	public long Id { get; set; }

	public int ReceiverTypeId { get; set; }

	public long ReceiverTargetId { get; set; }

	public long DestinationId { get; set; }

	public bool IsAuthorizedByReceiver { get; set; }

	public bool IsActive { get; set; }

	public int AuthenticationTypeId { get; set; }

	public string AuthenticationValue { get; set; }

	public string Name { get; set; }

	public DateTime Created { get; set; }

	public DateTime Updated { get; set; }

	public void Update()
	{
		ReceiverDestination cal = ReceiverDestination.Get(Id);
		if (cal == null)
		{
			throw new InvalidOperationException("Attempted update on unpersisted entity.");
		}
		cal.ReceiverTypeID = ReceiverTypeId;
		cal.ReceiverTargetID = ReceiverTargetId;
		cal.DestinationID = DestinationId;
		cal.IsAuthorizedByReceiver = IsAuthorizedByReceiver;
		cal.IsActive = IsActive;
		cal.AuthenticationTypeID = AuthenticationTypeId;
		cal.AuthenticationValue = AuthenticationValue;
		cal.Name = Name;
		cal.Save();
		Updated = cal.Updated;
	}

	public void Delete()
	{
		(ReceiverDestination.Get(Id) ?? throw new InvalidOperationException("Attempted delete on unpersisted entity.")).Delete();
	}
}
