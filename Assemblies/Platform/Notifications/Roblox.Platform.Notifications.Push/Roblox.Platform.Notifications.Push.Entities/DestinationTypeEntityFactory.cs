using System.Collections.Generic;
using System.Linq;
using Roblox.Platform.Core;
using Roblox.Platform.Notifications.Push.Entities.BLL;

namespace Roblox.Platform.Notifications.Push.Entities;

internal class DestinationTypeEntityFactory : IDestinationTypeEntityFactory
{
	public IDestinationTypeEntity Get(int id)
	{
		return CalToCachedMssql(DestinationType.Get(id));
	}

	public IDestinationTypeEntity GetByApplicationTypeIdAndPlatformTypeId(int applicationTypeId, int platformTypeId)
	{
		return CalToCachedMssql(DestinationType.GetByApplicationTypeIDAndPlatformTypeID(applicationTypeId, platformTypeId));
	}

	public IEnumerable<IDestinationTypeEntity> GetByApplicationTypeIdPaged(int applicationTypeId, int startRowIndex, int maxRows)
	{
		if (startRowIndex < 0)
		{
			throw new PlatformArgumentException("'startRowIndex' cannot be negative");
		}
		if (maxRows <= 0)
		{
			throw new PlatformArgumentException("'maxRows' must be positive");
		}
		return DestinationType.GetDestinationTypesByApplicationTypeIDPaged(applicationTypeId, startRowIndex, maxRows).Select(CalToCachedMssql);
	}

	public IDestinationTypeEntity Create(int applicationTypeId, int platformTypeId, string registrationEndpoint)
	{
		DestinationType destinationType = new DestinationType();
		destinationType.ApplicationTypeID = applicationTypeId;
		destinationType.PlatformTypeID = platformTypeId;
		destinationType.RegistrationEndpoint = registrationEndpoint;
		destinationType.Save();
		return CalToCachedMssql(destinationType);
	}

	private static IDestinationTypeEntity CalToCachedMssql(DestinationType cal)
	{
		if (cal != null)
		{
			return new DestinationTypeCachedMssqlEntity
			{
				Id = cal.ID,
				ApplicationTypeId = cal.ApplicationTypeID,
				PlatformTypeId = cal.PlatformTypeID,
				RegistrationEndpoint = cal.RegistrationEndpoint,
				Created = cal.Created,
				Updated = cal.Updated
			};
		}
		return null;
	}
}
