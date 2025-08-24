using Roblox.Entities;

namespace Roblox.Platform.Assets.Places.Entities;

internal interface IPlaceAttributeEntity : IUpdateableEntity<long>, IEntity<long>
{
	long PlaceId { get; set; }

	bool? UsePlaceMediaForThumb { get; set; }

	bool? OverridesDefaultAvatar { get; set; }

	bool? UsePortraitMode { get; set; }

	long? UniverseId { get; set; }

	bool? IsFilteringEnabled { get; set; }
}
