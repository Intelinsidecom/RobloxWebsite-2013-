using Roblox.Platform.Membership;

namespace Roblox.Platform.Social.Follow;

/// <summary>
/// Factor for follow privacy settings
/// </summary>
public interface IFollowPrivacySettingFactory
{
	/// <param name="user">Will throw a PlatformArgumentNullException if null</param>
	IFollowPrivacySetting GetOrCreate(IUser user);
}
