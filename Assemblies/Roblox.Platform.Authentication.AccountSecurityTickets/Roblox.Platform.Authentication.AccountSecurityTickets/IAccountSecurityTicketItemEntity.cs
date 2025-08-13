using Roblox.Entities;

namespace Roblox.Platform.Authentication.AccountSecurityTickets;

internal interface IAccountSecurityTicketItemEntity : IUpdateableEntity<long>, IEntity<long>
{
	long AccountSecurityTicketsId { get; set; }

	short AccountSecurityTypeId { get; set; }

	long AccountSecurityTargetId { get; set; }
}
