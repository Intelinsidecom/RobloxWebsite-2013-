using Roblox.Entities;

namespace Roblox.Platform.Email.Entities;

internal interface IEmailAddressEntity : IEntity<int>
{
	string Address { get; }

	bool IsBlacklisted { get; }
}
