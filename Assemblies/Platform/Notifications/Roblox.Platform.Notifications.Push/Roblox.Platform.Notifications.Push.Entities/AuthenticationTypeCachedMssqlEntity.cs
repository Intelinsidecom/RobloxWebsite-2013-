using System;
using Roblox.Entities;
using Roblox.Platform.Notifications.Push.Entities.BLL;

namespace Roblox.Platform.Notifications.Push.Entities;

internal class AuthenticationTypeCachedMssqlEntity : IAuthenticationTypeEntity, IUpdateableEntity<int>, IEntity<int>
{
	public int Id { get; set; }

	public string Value { get; set; }

	public DateTime Created { get; set; }

	public DateTime Updated { get; set; }

	public void Update()
	{
		AuthenticationType cal = AuthenticationType.Get(Id);
		if (cal == null)
		{
			throw new InvalidOperationException("Attempted update on unpersisted entity.");
		}
		cal.Value = Value;
		cal.Save();
		Updated = cal.Updated;
	}

	public void Delete()
	{
		(AuthenticationType.Get(Id) ?? throw new InvalidOperationException("Attempted delete on unpersisted entity.")).Delete();
	}
}
