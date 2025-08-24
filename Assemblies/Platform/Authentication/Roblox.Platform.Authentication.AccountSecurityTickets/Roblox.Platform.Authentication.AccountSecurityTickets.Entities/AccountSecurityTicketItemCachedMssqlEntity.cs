using System;
using Roblox.Entities;

namespace Roblox.Platform.Authentication.AccountSecurityTickets.Entities;

internal class AccountSecurityTicketItemCachedMssqlEntity : IAccountSecurityTicketItemEntity, IUpdateableEntity<long>, IEntity<long>
{
	public long Id { get; set; }

	public long AccountSecurityTicketsId { get; set; }

	public short AccountSecurityTypeId { get; set; }

	public long AccountSecurityTargetId { get; set; }

	public DateTime Created { get; set; }

	public DateTime Updated { get; set; }

	public void Update()
	{
		AccountSecurityTicketItem cal = AccountSecurityTicketItem.Get(Id);
		if (cal == null)
		{
			throw new InvalidOperationException("Attempted update on unpersisted entity.");
		}
		cal.AccountSecurityTicketID = AccountSecurityTicketsId;
		cal.AccountSecurityTypeID = AccountSecurityTypeId;
		cal.AccountSecurityTargetID = AccountSecurityTargetId;
		cal.Save();
		Updated = cal.Updated;
	}

	public void Delete()
	{
		(AccountSecurityTicketItem.Get(Id) ?? throw new InvalidOperationException("Attempted delete on unpersisted entity.")).Delete();
	}
}
