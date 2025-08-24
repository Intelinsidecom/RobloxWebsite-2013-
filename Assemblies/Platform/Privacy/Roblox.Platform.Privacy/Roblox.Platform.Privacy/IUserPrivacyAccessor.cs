using Roblox.Platform.Membership;

namespace Roblox.Platform.Privacy;

/// <summary>
/// A number of our privacy settings are backed by the Permission system. This accessor encapsulates the interaction necessary with the 
/// Permission system to get or set a privacy setting. No feature- or user- specific validation is done here, that is expected to be handled 
/// by the consumer. This class is basically the data access layer, NOT business logic.
/// </summary>
public interface IUserPrivacyAccessor
{
	/// <summary>
	/// Gets or creates the privacy level for a specific feature.
	/// </summary>
	IUserPrivacySetting GetOrCreatePrivacyLevelForUserPrivacySetting(UserPrivacySettingType settingType, IUser user, UserPrivacyLevelType defaultPrivacyLevel);

	/// <summary>
	/// Sets privacy level type for a specific feature.
	/// </summary>
	void SetPrivacyLevelForUserPrivacySetting(IUserPrivacySetting privacyLevel);
}
