namespace Roblox.Platform.Avatar;

/// <summary>
/// https://confluence.roblox.com/display/PLATFORM/Avatar+Project+2016
/// What ways can an avatar change?
///
/// This is not stored in a db so it can be reordered for now.
/// </summary>
public enum AvatarChangeTypeEnum
{
	WearClothing = 1,
	RemoveClothing,
	WearAccessory,
	RemoveAccessory,
	WearAvatarAnimation,
	RemoveAvatarAnimation,
	WearBodyPart,
	RemoveBodyPart,
	WearGear,
	RemoveGear,
	WearPackage,
	RemovePackage,
	RemoveAll,
	WearOutfit,
	UpdateOutfit,
	CreateOutfit,
	SetBodyColors,
	SetPlayerAvatarType,
	SetScale,
	Unknown,
	TryOn
}
