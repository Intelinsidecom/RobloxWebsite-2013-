using Roblox.Platform.Membership;

namespace Roblox.Platform.UniverseSettings;

public interface IUniverseSettingsFactoryForAdmins
{
	UniverseAvatarSettingsResponseModel GetUniverseAvatarSettings(long universeId);

	UniverseAvatarType GetValidUniverseAvatarType(long? universeId);

	UniverseScaleType GetValidUniverseScaleType(long? universeId);

	UniverseAvatarAnimationType GetValidUniverseAvatarAnimationType(long? universeId);

	UniverseAvatarCollisionType GetValidUniverseAvatarCollisionType(long? universeId);

	UniverseAvatarBodyType GetValidUniverseAvatarBodyType(long? universeId);

	UniverseAvatarJointPositioningType GetValidUniverseAvatarJointPositioningType(long? universeId);

	bool SetUniverseAvatarTypeByAdmin(long universeId, UniverseAvatarType universeAvatarType);

	void SetUniverseScaleTypeByAdmin(long universeId, UniverseScaleType universeScaleType);

	void SetUniverseAvatarAnimationType(IUser user, long universeId, UniverseAvatarAnimationType universeAvatarAnimationType);

	void SetUniverseAvatarCollisionType(IUser user, long universeId, UniverseAvatarCollisionType universeAvatarCollisionType);

	void SetUniverseAvatarBodyType(IUser user, long universeId, UniverseAvatarBodyType universeAvatarBodyType);

	void SetUniverseAvatarJointPositioningType(IUser user, long universeId, UniverseAvatarJointPositioningType universeAvatarJointPositioningType);
}
