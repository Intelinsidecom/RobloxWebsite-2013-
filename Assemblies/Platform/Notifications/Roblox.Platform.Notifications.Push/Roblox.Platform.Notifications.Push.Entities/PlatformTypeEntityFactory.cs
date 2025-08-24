using Roblox.Platform.Notifications.Push.Entities.BLL;

namespace Roblox.Platform.Notifications.Push.Entities;

internal class PlatformTypeEntityFactory : IPlatformTypeEntityFactory
{
	public IPlatformTypeEntity Get(int id)
	{
		return CalToCachedMssql(PlatformType.Get(id));
	}

	public IPlatformTypeEntity GetByValue(string value)
	{
		return CalToCachedMssql(PlatformType.GetByValue(value));
	}

	private static IPlatformTypeEntity CalToCachedMssql(PlatformType cal)
	{
		if (cal != null)
		{
			return new PlatformTypeCachedMssqlEntity
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
