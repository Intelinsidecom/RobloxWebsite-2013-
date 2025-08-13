namespace Roblox.Platform.Permissions;

/// <summary>
/// A temporary enum for the action types hardcoded for the May 2018 deadline.
/// After the action types are converted to be data-driven, this enum will be deprecated.
/// </summary>
public enum GdprActions : byte
{
	EnterSocialMediaInfo,
	ViewSocialMediaOnProfile,
	StoreOwnEmailAddress,
	StorePhoneNumber,
	UpdateOwnBirthday,
	UploadVideo,
	SignupForDevEx,
	BeInGdprJurisdiction
}
