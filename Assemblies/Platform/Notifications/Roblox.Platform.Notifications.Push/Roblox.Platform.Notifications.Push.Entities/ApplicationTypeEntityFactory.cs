using Roblox.Platform.Notifications.Push.Entities.BLL;

namespace Roblox.Platform.Notifications.Push.Entities;

internal class ApplicationTypeEntityFactory : IApplicationTypeEntityFactory
{
	public IApplicationTypeEntity Get(int id)
	{
		return CalToCachedMssql(ApplicationType.Get(id));
	}

	public IApplicationTypeEntity GetOrCreate(string value)
	{
		return CalToCachedMssql(ApplicationType.GetOrCreate(value));
	}

	public IApplicationTypeEntity GetByValue(string value)
	{
		return CalToCachedMssql(ApplicationType.GetByValue(value));
	}

	private static IApplicationTypeEntity CalToCachedMssql(ApplicationType cal)
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
