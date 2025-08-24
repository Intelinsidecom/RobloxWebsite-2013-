using System;
using Roblox.Entities;
using Roblox.Platform.Notifications.Push.Entities.BLL;

namespace Roblox.Platform.Notifications.Push.Entities;

internal class DestinationTypeCachedMssqlEntity : IDestinationTypeEntity, IUpdateableEntity<int>, IEntity<int>
{
	public int Id { get; set; }

	public int ApplicationTypeId { get; set; }

	public int PlatformTypeId { get; set; }

	public string RegistrationEndpoint { get; set; }

	public DateTime Created { get; set; }

	public DateTime Updated { get; set; }

	public void Update()
	{
		DestinationType cal = DestinationType.Get(Id);
		if (cal == null)
		{
			throw new InvalidOperationException("Attempted update on unpersisted entity.");
		}
		cal.ApplicationTypeID = ApplicationTypeId;
		cal.PlatformTypeID = PlatformTypeId;
		cal.RegistrationEndpoint = RegistrationEndpoint;
		cal.Save();
		Updated = cal.Updated;
	}

	public void Delete()
	{
		(DestinationType.Get(Id) ?? throw new InvalidOperationException("Attempted delete on unpersisted entity.")).Delete();
	}
}
