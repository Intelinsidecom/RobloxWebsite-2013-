using System;
using Roblox.Entities;

namespace Roblox.Platform.Authentication.AccountSecurityTickets;

public interface IAccountSecurityTicketsV2Entity : IUpdateableEntity<long>, IEntity<long>
{
	Guid Value { get; set; }

	long AccountId { get; set; }

	bool IsValid { get; set; }
}
