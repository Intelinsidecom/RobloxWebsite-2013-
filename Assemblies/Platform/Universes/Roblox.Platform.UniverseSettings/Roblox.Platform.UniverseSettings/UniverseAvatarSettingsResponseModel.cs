using System.Collections.Generic;

namespace Roblox.Platform.UniverseSettings;

public class UniverseAvatarSettingsResponseModel
{
	public long UniverseId { get; set; }

	public UniverseAvatarType UniverseAvatarType { get; set; }

	public UniverseScaleType UniverseScaleType { get; set; }

	public UniverseAvatarAnimationType UniverseAvatarAnimationType { get; set; }

	public UniverseAvatarCollisionType UniverseAvatarCollisionType { get; set; }

	public UniverseAvatarBodyType UniverseAvatarBodyType { get; set; }

	public UniverseAvatarJointPositioningType UniverseAvatarJointPositioningType { get; set; }

	public ICollection<UniverseAvatarAssetOverrideResponseModel> UniverseAvatarAssetOverrides { get; set; }

	public int? UniverseAvatarMinScaleId { get; set; }

	public int? UniverseAvatarMaxScaleId { get; set; }

	public UniverseAvatarSettingsResponseModel()
	{
	}

	public UniverseAvatarSettingsResponseModel(long universeId, UniverseAvatarType universeAvatarType, UniverseScaleType universeScaleType, UniverseAvatarAnimationType universeAvatarAnimationType, UniverseAvatarCollisionType universeAvatarCollisionType, UniverseAvatarBodyType universeAvatarBodyType, UniverseAvatarJointPositioningType universeAvatarJointPositioningType, int? universeAvatarMinScaleId = null, int? universeAvatarMaxScaleId = null, ICollection<UniverseAvatarAssetOverrideResponseModel> universeAvatarAssetOverrides = null)
	{
		UniverseId = universeId;
		UniverseAvatarType = universeAvatarType;
		UniverseScaleType = universeScaleType;
		UniverseAvatarAnimationType = universeAvatarAnimationType;
		UniverseAvatarCollisionType = universeAvatarCollisionType;
		UniverseAvatarBodyType = universeAvatarBodyType;
		UniverseAvatarJointPositioningType = universeAvatarJointPositioningType;
		UniverseAvatarAssetOverrides = universeAvatarAssetOverrides;
		UniverseAvatarMinScaleId = universeAvatarMinScaleId;
		UniverseAvatarMaxScaleId = universeAvatarMaxScaleId;
	}
}
