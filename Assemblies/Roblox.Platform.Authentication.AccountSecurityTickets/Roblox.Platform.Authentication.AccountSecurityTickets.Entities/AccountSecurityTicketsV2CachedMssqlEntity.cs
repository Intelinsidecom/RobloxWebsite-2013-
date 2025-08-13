using System;
using Roblox.Entities;

namespace Roblox.Platform.Authentication.AccountSecurityTickets.Entities;

internal class AccountSecurityTicketsV2CachedMssqlEntity : IAccountSecurityTicketsV2Entity, IUpdateableEntity<long>, IEntity<long>
{
	public long Id { get; set; }

	public Guid Value { get; set; }

	public long AccountId { get; set; }

	public bool IsValid { get; set; }

	public DateTime Created { get; set; }

	public DateTime Updated { get; set; }

	public void Update()
	{
		AccountSecurityTicketsV2 cal = AccountSecurityTicketsV2.Get(Id);
		if (cal == null)
		{
			throw new InvalidOperationException("Attempted update on unpersisted entity.");
		}
		cal.Value = Value;
		cal.AccountID = AccountId;
		cal.IsValid = IsValid;
		cal.Save();
		Updated = cal.Updated;
	}

	public void Delete()
	{
		(AccountSecurityTicketsV2.Get(Id) ?? throw new InvalidOperationException("Attempted delete on unpersisted entity.")).Delete();
	}
}
