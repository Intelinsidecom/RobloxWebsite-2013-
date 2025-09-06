using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Roblox.Configuration;

namespace Roblox.Platform.Universes.Properties;

/// <summary>
/// Configuration that uses Roblox.Configuration.Provider
/// </summary>
[System.Configuration.SettingsProvider(typeof(Provider))]
[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
internal sealed class Settings : System.Configuration.ApplicationSettingsBase, ISettings
{
	private readonly ConcurrentDictionary<string, object> _Properties = new ConcurrentDictionary<string, object>();

	private static Settings defaultInstance = (Settings)System.Configuration.SettingsBase.Synchronized(new Settings());

	public override object this[string propertyName]
	{
		get
		{
			return _Properties.GetOrAdd(propertyName, (string propName) => base[propName]);
		}
		set
		{
			base[propertyName] = value;
		}
	}

	public static Settings Default => defaultInstance;

	[System.Configuration.ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[System.Configuration.DefaultSettingValue("False")]
	public bool IsPublishToCatalogItemChangeQueueEnabled => (bool)this["IsPublishToCatalogItemChangeQueueEnabled"];

	[System.Configuration.ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[System.Configuration.DefaultSettingValue("False")]
	public bool IsPublishToUniverseChangeTopicEnabled => (bool)this["IsPublishToUniverseChangeTopicEnabled"];

	[System.Configuration.ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[System.Configuration.DefaultSettingValue("")]
	public string AwsUniverseChangeTopicAccessKeyIdAndSecretCsv => (string)this["AwsUniverseChangeTopicAccessKeyIdAndSecretCsv"];

	[System.Configuration.ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[System.Configuration.DefaultSettingValue("")]
	public string AwsUniverseChangeSnsTopicArn => (string)this["AwsUniverseChangeSnsTopicArn"];

	[System.Configuration.ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[System.Configuration.DefaultSettingValue("False")]
	public bool IsSettingUniversePrivacyTypeToPrivateOnMissingRootPlaceIdEnabled => (bool)this["IsSettingUniversePrivacyTypeToPrivateOnMissingRootPlaceIdEnabled"];

	[System.Configuration.ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[System.Configuration.DefaultSettingValue("Private")]
	public string DefaultUniversePrivacyType => (string)this["DefaultUniversePrivacyType"];

	[System.Configuration.ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[System.Configuration.DefaultSettingValue("50")]
	public int UniverseNameMaxLength => (int)this["UniverseNameMaxLength"];

	[System.Configuration.ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[System.Configuration.DefaultSettingValue("False")]
	public bool PermissionsV2ReadsEnabled => (bool)this["PermissionsV2ReadsEnabled"];

	[System.Configuration.ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[System.Configuration.DefaultSettingValue("0")]
	public double PermissionsV2ReadsPercentage => (double)this["PermissionsV2ReadsPercentage"];

	[System.Configuration.ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[System.Configuration.DefaultSettingValue("False")]
	public bool PermissionsV2PlayReadsEnabled => (bool)this["PermissionsV2PlayReadsEnabled"];

	[System.Configuration.ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[System.Configuration.DefaultSettingValue("0")]
	public double PermissionsV2PlayReadsPercentage => (double)this["PermissionsV2PlayReadsPercentage"];

	internal Settings()
	{
		base.PropertyChanged += delegate(object sender, PropertyChangedEventArgs propertyChangeEvent)
		{
			_Properties.TryRemove(propertyChangeEvent.PropertyName, out var _);
		};
	}

	protected override void OnSettingsLoaded(object sender, System.Configuration.SettingsLoadedEventArgs e)
	{
		base.OnSettingsLoaded(sender, e);
		Provider.RegisterSettings(e, this);
	}

	private void UpdateProperty(object sender, PropertyChangedEventArgs propertyChangeEvent)
	{
		_Properties.TryRemove(propertyChangeEvent.PropertyName, out var _);
	}
}


