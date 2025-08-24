using System;
using Roblox.Platform.StaticContent.Properties;

namespace Roblox.Platform.StaticContent;

/// <inheritdoc cref="T:Roblox.Platform.StaticContent.IComponentSuffixProvider" />
public class SettingsBasedComponentSuffixProvider : IComponentSuffixProvider
{
	private readonly ISettings _Settings;

	/// <summary>
	/// Initializes a new <see cref="T:Roblox.Platform.StaticContent.SettingsBasedComponentSuffixProvider" />.
	/// </summary>
	public SettingsBasedComponentSuffixProvider()
		: this(Settings.Default)
	{
	}

	internal SettingsBasedComponentSuffixProvider(ISettings settings)
	{
		_Settings = settings ?? throw new ArgumentNullException("settings");
	}

	/// <inheritdoc cref="M:Roblox.Platform.StaticContent.IComponentSuffixProvider.GetComponentSuffix" />
	public string GetComponentSuffix()
	{
		return _Settings.ComponentSuffix;
	}
}
