namespace Roblox.Platform.Membership;

/// <summary>
/// Interface to validate whether a feature should be enabled for a user or ont.
/// </summary>
public interface IFeatureEnabledValidator
{
	/// <summary>
	/// Check if the feature should be enabled for the user.
	/// </summary>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser"></see></param>
	/// <returns>Pass / Fail of the check.</returns>
	bool IsFeatureEnabled(IUser user);
}
