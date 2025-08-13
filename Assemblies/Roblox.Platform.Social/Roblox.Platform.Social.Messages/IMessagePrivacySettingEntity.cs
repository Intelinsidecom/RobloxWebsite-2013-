namespace Roblox.Platform.Social.Messages;

/// <summary>
/// Wrapper for the legacy UserMessagePrivacySetting class - makes platform code testable. There should be no logic in
/// the implementation of this interface.
/// </summary>
internal interface IMessagePrivacySettingEntity
{
	long Id { get; }

	long UserId { get; }

	MessagePrivacyType PrivacyType { get; set; }

	void Save();
}
