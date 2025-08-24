using Roblox.Platform.Membership;

namespace Roblox.Platform.Social.Messages;

/// <summary>
/// Public interface representing a user's privacy settings for receiving messages.
/// </summary>
public interface IMessagePrivacySetting
{
	/// <summary>
	/// A <see cref="T:Roblox.Platform.Membership.IUser" />.
	/// </summary>
	IUser User { get; }

	/// <summary>
	/// The <see cref="P:Roblox.Platform.Social.Messages.IMessagePrivacySetting.MessagePrivacyType" /> that controls who can send the user messages.
	/// </summary>
	MessagePrivacyType MessagePrivacyType { get; }

	/// <summary>
	/// Updates the privacy type. If the chosen privacy type is not valid for the user's age bracket, or if the chosen privacy
	/// type is equal to the existing privacy type, this method does not update the DB.
	/// </summary>
	/// <param name="newPrivacyType"></param>
	/// <exception cref="T:Roblox.Data.DataIntegrityException">Thrown if the underlying entity object is null</exception>
	void UpdatePrivacyType(MessagePrivacyType newPrivacyType);

	/// <summary>
	/// Checks that the user's privacy setting is valid for their age bracket, and updates it to a default value if it is invalid.
	/// </summary>
	/// <exception cref="T:Roblox.Data.DataIntegrityException">Thrown if the underlying entity object is null</exception>
	void Sanitize();
}
