using Roblox.Entities;

namespace Roblox.Platform.Groups.Entities;

internal interface IGroupFeatureEntity : IUpdateableEntity<long>, IEntity<long>
{
	byte GroupFeatureTypeId { get; set; }

	long GroupId { get; set; }
}
