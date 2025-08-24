using Roblox.Platform.Membership;

namespace Roblox.Platform.Social.Messages;

/// <summary>
/// Provides methods to determine whether or not a user can send a private message to another user.
/// </summary>
public interface IMessagePrivacyAuthority
{
	/// <summary>
	/// Determines whether or not a user can send a message to another user.
	/// </summary>
	/// <param name="sender">The user ID of the user sending the message.</param>
	/// <param name="recipient">The user ID of the user receiving the message.</param>
	/// <returns>The result of the check.</returns>
	/// <exception cref="T:System.ArgumentException">Thrown if the sender ID or the recipient ID are invalid.</exception>
	PrivacySettingsCheckResult CanSendMessage(IUser sender, IUser recipient);
}
