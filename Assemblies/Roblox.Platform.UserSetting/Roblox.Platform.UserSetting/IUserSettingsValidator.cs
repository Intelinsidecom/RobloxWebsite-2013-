using Roblox.Platform.Membership;

namespace Roblox.Platform.UserSetting;

/// <summary>
/// Validating the CuratedContent configurations.
/// </summary>
public interface IUserSettingsValidator
{
	/// <summary>
	/// Should the the given <see cref="T:Roblox.Platform.MembershipCore.IUserIdentifier" /> be treated as having CuratedContentOnly = true.
	/// Considers both the Feature Flag and the User's setting.
	/// </summary>
	/// <param name="user"></param>
	/// <returns></returns>
	bool IsUserConfiguredForCuratedContentOnly(IUser user);

	/// <summary>
	/// Is the CuratedContent feature enabled for the given user.
	/// </summary>
	/// <returns></returns>
	bool CuratedContentOnlyIsActive(IUser user);
}
