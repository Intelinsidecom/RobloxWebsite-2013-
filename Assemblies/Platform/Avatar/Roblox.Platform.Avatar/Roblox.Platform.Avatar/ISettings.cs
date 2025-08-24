namespace Roblox.Platform.Avatar;

internal interface ISettings
{
	bool StopWritingBodyColorsToAvatarHash { get; }

	bool OverrideAvatarScaleWithDefaults { get; }

	bool DisableAdvancedAccessoryMode { get; }

	int GetUserAssetByIdUseMultiGetRolloutPercentage { get; }

	int UserOwnsUnexpiredAssetCheckRolloutPercentage { get; }

	int UserMayRemoveAssetCheckV2RolloutPercentage { get; }
}
