using Roblox.Platform.Membership;

namespace Roblox.Platform.XboxLive;

/// <summary>
/// A Factory for <see cref="T:Roblox.Platform.XboxLive.CrossPlaySetting" />
/// </summary>
public interface ICrossPlaySettingFactory
{
	/// <summary>
	/// Gets the by user identifier.
	/// </summary>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" /> who's setting to get.</param>
	/// <returns>The <see cref="T:Roblox.Platform.XboxLive.CrossPlaySetting" /></returns>
	ICrossPlaySetting GetByUserId(IUser user);

	/// <summary>
	/// Creates a new <see cref="T:Roblox.Platform.XboxLive.CrossPlaySetting" />.
	/// </summary>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" /> who's setting to create.</param>
	/// <param name="isEnabled">if set to <c>true</c> [is enabled].</param>
	/// <returns>A new <see cref="T:Roblox.Platform.XboxLive.CrossPlaySetting" /></returns>
	ICrossPlaySetting CreateNew(IUser user, bool isEnabled);
}
