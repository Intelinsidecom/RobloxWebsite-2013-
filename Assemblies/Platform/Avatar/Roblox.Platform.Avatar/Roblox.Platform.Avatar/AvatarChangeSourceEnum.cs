namespace Roblox.Platform.Avatar;

/// <summary>
/// Where do avatar changes come from?  i.e. what is the closest point to the user that the change originated from?
/// The goal of this is to cover all characterizable sources of changes.
/// </summary>
public enum AvatarChangeSourceEnum
{
	AvatarPage = 1,
	ItemPage,
	MobileAvatarPage,
	MobileItemPage,
	InGameAvatarEditor,
	MobileApp,
	ApiSiteDirectAccess,
	Extension,
	SwaggerDocs,
	Unknown,
	AvatarPageV2,
	XBox
}
