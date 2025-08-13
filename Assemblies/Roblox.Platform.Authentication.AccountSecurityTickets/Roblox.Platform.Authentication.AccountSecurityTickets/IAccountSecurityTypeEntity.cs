using Roblox.Entities;

namespace Roblox.Platform.Authentication.AccountSecurityTickets;

internal interface IAccountSecurityTypeEntity : IUpdateableEntity<short>, IEntity<short>
{
	string Value { get; set; }
}
