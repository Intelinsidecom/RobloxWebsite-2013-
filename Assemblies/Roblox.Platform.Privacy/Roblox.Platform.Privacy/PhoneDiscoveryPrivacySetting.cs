using Roblox.Platform.Membership;

namespace Roblox.Platform.Privacy;

/// <inheritdoc />
internal class PhoneDiscoveryPrivacySetting : IPhoneDiscoveryPrivacySetting, IUserPrivacySetting
{
	/// <inheritdoc />
	public UserPrivacyLevelType PrivacyLevel { get; set; }

	/// <inheritdoc />
	public UserPrivacySettingType SettingType { get; }

	/// <inheritdoc />
	public IUser User { get; }

	/// <summary>
	/// Initialize a new instance of <see cref="T:Roblox.Platform.Privacy.PhoneDiscoveryPrivacySetting" />.
	/// </summary>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" />.</param>
	/// <param name="privacyLevel">The <see cref="T:Roblox.Platform.Privacy.UserPrivacyLevelType" />.</param>
	public PhoneDiscoveryPrivacySetting(IUser user, UserPrivacyLevelType privacyLevel)
	{
		User = user;
		SettingType = UserPrivacySettingType.PhoneNumberDiscovery;
		PrivacyLevel = privacyLevel;
	}
}
