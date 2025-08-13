using Roblox.Platform.Membership;

namespace Roblox.Platform.Social.Messages;

/// <summary>
/// Fetches and constructs <see cref="T:Roblox.Platform.Social.Messages.IMessagePrivacySetting" />s.
/// </summary>
public interface IMessagePrivacySettingFactory
{
	/// <summary>
	/// Gets or creates a <see cref="T:Roblox.Platform.Social.Messages.IMessagePrivacySetting" /> by its user. If the appropriate setting is true, the user's
	/// setting will be sanitized as well.
	/// </summary>
	/// <param name="user">The user.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Social.Messages.IMessagePrivacySetting" /> whose user ID matches the given user.</returns>
	/// <exception cref="T:System.ArgumentNullException">Thrown if the passed in user is null</exception>
	IMessagePrivacySetting GetOrCreate(IUser user);
}
