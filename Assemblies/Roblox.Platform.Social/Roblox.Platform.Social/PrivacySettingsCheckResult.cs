namespace Roblox.Platform.Social;

/// <summary>
/// Represents the result of a privacy settings check.
/// </summary>
public enum PrivacySettingsCheckResult
{
	/// <summary>
	/// The check failed because the sender is not logged in.
	/// </summary>
	Login,
	/// <summary>
	/// The check failed because the recipient does not exist.
	/// </summary>
	BadRecipient,
	/// <summary>
	/// The check failed because the sender does not exist.
	/// </summary>
	BadSender,
	/// <summary>
	/// The check failed because the sender and recipient are the same user.
	/// </summary>
	SentToSelf,
	/// <summary>
	/// The check failed because the sender's privacy settings are too high.
	/// </summary>
	SenderPrivacySettingsTooHigh,
	/// <summary>
	/// The check failed because the recipient's privacy settings are too high.
	/// </summary>
	RecipientPrivacySettingsTooHigh,
	/// <summary>
	/// The check passed successfully.
	/// </summary>
	Passed,
	/// <summary>
	/// The Friends Service is currently unavailable
	/// </summary>
	FriendsServiceUnavailable
}
