using System;

namespace Roblox.Platform.Groups;

/// <inheritdoc cref="T:Roblox.Platform.Groups.IGroupSettingsProvider" />
internal class GroupSettingsProvider : IGroupSettingsProvider
{
	private readonly IGroupFeatureEnabler _GroupFeatureEnabler;

	/// <summary>
	/// Initializes a new <see cref="T:Roblox.Platform.Groups.GroupSettingsProvider" />.
	/// </summary>
	/// <param name="groupFeatureEnabler">An <see cref="T:Roblox.Platform.Groups.IGroupFeatureEnabler" />.</param>
	/// <exception cref="T:System.ArgumentNullException">
	/// - <paramref name="groupFeatureEnabler" />
	/// </exception>
	public GroupSettingsProvider(IGroupFeatureEnabler groupFeatureEnabler)
	{
		_GroupFeatureEnabler = groupFeatureEnabler ?? throw new ArgumentNullException("groupFeatureEnabler");
	}

	/// <inheritdoc cref="M:Roblox.Platform.Groups.IGroupSettingsProvider.IsSettingEnabled(Roblox.Platform.Groups.IGroup,Roblox.Platform.Groups.GroupSetting)" />
	public bool IsSettingEnabled(IGroup group, GroupSetting groupSetting)
	{
		if (group == null)
		{
			throw new ArgumentNullException("group");
		}
		if (groupSetting == GroupSetting.PublicGroupFunds)
		{
			return _GroupFeatureEnabler.HasFeature(group, GroupFeatureType.AllowVisibleGroupFundsID);
		}
		throw new NotImplementedException(string.Format("Setting ({0}) has not been implemented for {1}.", groupSetting, "IsSettingEnabled"));
	}
}
