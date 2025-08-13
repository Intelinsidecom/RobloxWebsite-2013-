using System;
using Roblox.Entities;

namespace Roblox.Platform.Authentication.AccountSecurityTickets.Entities;

internal class AccountSecurityTypeCachedMssqlEntity : IAccountSecurityTypeEntity, IUpdateableEntity<short>, IEntity<short>
{
	public short Id { get; set; }

	public string Value { get; set; }

	public DateTime Created { get; set; }

	public DateTime Updated { get; set; }

	public void Update()
	{
		AccountSecurityType cal = AccountSecurityType.Get(Id);
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
		(AccountSecurityType.Get(Id) ?? throw new InvalidOperationException("Attempted delete on unpersisted entity.")).Delete();
	}
}
