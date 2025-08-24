using Roblox.Platform.Notifications.Push.Entities.BLL;

namespace Roblox.Platform.Notifications.Push.Entities;

internal class AuthenticationTypeEntityFactory : IAuthenticationTypeEntityFactory
{
	public IAuthenticationTypeEntity Get(int id)
	{
		return CalToCachedMssql(AuthenticationType.Get(id));
	}

	public IAuthenticationTypeEntity GetByValue(string value)
	{
		return CalToCachedMssql(AuthenticationType.GetByValue(value));
	}

	public IAuthenticationTypeEntity GetOrCreate(string value)
	{
		return CalToCachedMssql(AuthenticationType.GetOrCreate(value));
	}

	private static IAuthenticationTypeEntity CalToCachedMssql(AuthenticationType cal)
	{
		if (cal != null)
		{
			return new AuthenticationTypeCachedMssqlEntity
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
