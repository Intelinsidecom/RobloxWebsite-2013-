namespace Roblox.Platform.Social.Follow;

/// <summary>
/// A user's privacy setting for allowing/disallowing other users to follow them into game
/// </summary>
public interface IFollowPrivacySetting
{
	/// <summary>
	/// Currently set privacy type
	/// </summary>
	FollowPrivacyType PrivacyType { get; }

	/// <summary>
	/// If privacy type is inappropriate for user's age, does nothing
	/// </summary>
	/// <returns>Returns a boolean indicating whether the save was successful or not</returns>
	bool SetPrivacyType(FollowPrivacyType privacyType);

	/// <summary>
	/// If current privacy type is inappropriate for user's age, updates it to default (for age)
	/// </summary>
	void Sanitize();
}
