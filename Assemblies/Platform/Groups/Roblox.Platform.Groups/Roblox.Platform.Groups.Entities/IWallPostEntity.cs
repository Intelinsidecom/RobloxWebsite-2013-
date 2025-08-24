using Roblox.Entities;

namespace Roblox.Platform.Groups.Entities;

internal interface IWallPostEntity : IUpdateableEntity<long>, IEntity<long>
{
	long GroupId { get; set; }

	long UserId { get; set; }

	string Value { get; set; }
}
