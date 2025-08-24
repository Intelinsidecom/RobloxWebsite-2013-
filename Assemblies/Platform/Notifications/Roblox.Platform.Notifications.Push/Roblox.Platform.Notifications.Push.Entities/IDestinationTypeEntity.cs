using Roblox.Entities;

namespace Roblox.Platform.Notifications.Push.Entities;

internal interface IDestinationTypeEntity : IUpdateableEntity<int>, IEntity<int>
{
	int ApplicationTypeId { get; set; }

	int PlatformTypeId { get; set; }

	string RegistrationEndpoint { get; set; }
}
