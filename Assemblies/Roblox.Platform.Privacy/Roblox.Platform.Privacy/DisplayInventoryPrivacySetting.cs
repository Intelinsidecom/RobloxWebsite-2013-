using Roblox.Platform.Membership;

namespace Roblox.Platform.Privacy;

internal class DisplayInventoryPrivacySetting : IDisplayInventoryPrivacySetting, IUserPrivacySetting
{
	/// <inheritdoc />
	public UserPrivacyLevelType PrivacyLevel { get; set; }

	/// <inheritdoc />
	public UserPrivacySettingType SettingType => UserPrivacySettingType.DisplayInventory;

	/// <inheritdoc />
	public IUser User { get; }

	/// <summary>
	/// Initialize a new instance of <see cref="T:Roblox.Platform.Privacy.DisplayInventoryPrivacySetting" />.
	/// </summary>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" />.</param>
	/// <param name="privacyLevel">The <see cref="T:Roblox.Platform.Privacy.UserPrivacyLevelType" />.</param>
	public DisplayInventoryPrivacySetting(IUser user, UserPrivacyLevelType privacyLevel)
	{
		User = user;
		PrivacyLevel = privacyLevel;
	}
}
