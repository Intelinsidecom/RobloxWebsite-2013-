namespace Roblox.Platform.Groups;

/// <summary>
/// Provides indirect settings for groups.
/// </summary>
public interface IGroupSettingsProvider
{
	/// <summary>
	/// Gets whether or not a boolean group setting is enabled.
	/// </summary>
	/// <param name="group">The <see cref="T:Roblox.Platform.Groups.IGroup" />.</param>
	/// <param name="groupSetting">The <see cref="T:Roblox.Platform.Groups.GroupSetting" />.</param>
	/// <returns><c>true</c> if the setting is enabled.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	/// - <paramref name="group" />
	/// </exception>
	bool IsSettingEnabled(IGroup group, GroupSetting groupSetting);
}
