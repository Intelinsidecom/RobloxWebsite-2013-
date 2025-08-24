using Roblox.Entities;

namespace Roblox.Platform.Groups.Entities;

internal interface IStatusEntity : IUpdateableEntity<long>, IEntity<long>
{
	long GroupId { get; }

	long PosterId { get; }

	string Message { get; }
}
