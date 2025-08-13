using Roblox.Platform.Membership;

namespace Roblox.Platform.Privacy;

/// <summary>
/// Base interface for feature privacy systems
/// </summary>
public interface IUserPrivacySetting
{
	/// <summary>
	/// Privacy level - governs who can perform the related action (example: no one, friends, everyone, etc)
	/// </summary>
	UserPrivacyLevelType PrivacyLevel { get; set; }

	/// <summary>
	/// Action being restricted
	/// </summary>
	UserPrivacySettingType SettingType { get; }

	/// <summary>
	/// The user who the setting belongs to
	/// </summary>
	IUser User { get; }
}
