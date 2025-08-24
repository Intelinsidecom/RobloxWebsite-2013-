using Roblox.Entities;

namespace Roblox.Platform.Notifications.Push.Entities;

internal interface IAuthenticationTypeEntity : IUpdateableEntity<int>, IEntity<int>
{
	string Value { get; set; }
}
