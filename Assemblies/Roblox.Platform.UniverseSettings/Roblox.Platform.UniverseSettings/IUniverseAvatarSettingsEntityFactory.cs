using System.Collections.Generic;
using Roblox.Platform.Core;

namespace Roblox.Platform.UniverseSettings;

internal interface IUniverseAvatarSettingsEntityFactory : IDomainFactory<UniverseSettingsDomainFactories>, IDomainObject<UniverseSettingsDomainFactories>
{
	IUniverseAvatarSettingEntity Get(long id);

	IReadOnlyCollection<IUniverseAvatarSettingEntity> GetUniverseAvatarSettings(ICollection<long> ids);

	IUniverseAvatarSettingEntity GetByUniverseId(long universeId);

	IUniverseAvatarSettingEntity GetOrCreate(long universeId, UniverseAvatarType universeAvatarType, UniverseScaleType universeScaleType, UniverseAvatarAnimationType universeAvatarAnimationType, UniverseAvatarCollisionType universeAvatarCollisionType, UniverseAvatarBodyType universeAvatarBodyType, UniverseAvatarJointPositioningType universeAvatarJointPositioningType, int? universeAvatarMinScaleId = null, int? universeAvatarMaxScaleId = null);

	IUniverseAvatarSettingEntity GetOrCreate(long universeId);
}
