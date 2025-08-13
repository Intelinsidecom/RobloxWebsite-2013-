using Roblox.Entities;

namespace Roblox.Platform.UniverseSettings;

internal interface IUniverseAvatarSettingEntity : IUpdateableEntity<long>, IEntity<long>
{
	long UniverseId { get; set; }

	byte UniverseAvatarTypeId { get; set; }

	byte? UniverseScaleTypeId { get; set; }

	byte? UniverseAvatarAnimationTypeId { get; set; }

	byte? UniverseAvatarCollisionTypeId { get; set; }

	byte? UniverseAvatarJointPositioningTypeId { get; set; }

	byte? UniverseAvatarBodyTypeId { get; set; }

	int? UniverseAvatarMinScaleId { get; set; }

	int? UniverseAvatarMaxScaleId { get; set; }
}
