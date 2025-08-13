using System;
using Roblox.Platform.Devices.Entities;

namespace Roblox.Platform.Devices;

internal class ApplicationTypeEntityFactory : IApplicationTypeEntityFactory
{
	public IApplicationTypeEntity GetById(byte id)
	{
		return CalToCachedMssql(Roblox.Platform.Devices.Entities.ApplicationType.Get(id));
	}

	public IApplicationTypeEntity GetByValue(string value)
	{
		if (string.IsNullOrEmpty(value))
		{
			throw new ArgumentNullException("value");
		}
		return CalToCachedMssql(Roblox.Platform.Devices.Entities.ApplicationType.GetByValue(value));
	}

	private static IApplicationTypeEntity CalToCachedMssql(Roblox.Platform.Devices.Entities.ApplicationType cal)
	{
		if (cal != null)
		{
			return new ApplicationTypeCachedMssqlEntity
			{
				Id = cal.ID,
				Value = cal.Value,
				Created = cal.Created,
				Updated = cal.Updated
			};
		}
		return null;
	}
}
