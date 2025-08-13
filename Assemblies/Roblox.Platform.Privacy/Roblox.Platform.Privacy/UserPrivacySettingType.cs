namespace Roblox.Platform.Privacy;

/// <summary>
/// Systems whose privacy settings are backed by the permissions system. These are passed to the <see cref="T:Roblox.Platform.Privacy.IUserPrivacyAccessor" /> to manage privacy
/// settings for the specified system
/// </summary>
public enum UserPrivacySettingType
{
	SendPrivateServerInvite = 1,
	DisplaySocialNetworks,
	AppChatMessaging,
	GameChatMessaging,
	PhoneNumberDiscovery,
	DisplayInventory
}
