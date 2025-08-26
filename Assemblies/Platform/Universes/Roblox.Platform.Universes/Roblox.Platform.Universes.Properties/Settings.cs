namespace extern {
    alias ConfMan;

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
[ConfMan::System.Configuration.SettingsProvider(typeof(Provider))]
[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
internal sealed class Settings : ConfMan::System.Configuration.ApplicationSettingsBase, ISettings
{
	private readonly ConcurrentDictionary<string, object> _Properties = new ConcurrentDictionary<string, object>();

	private static Settings defaultInstance = (Settings)ConfMan::System.Configuration.SettingsBase.Synchronized(new Settings());

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

	[ConfMan::System.Configuration.ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[ConfMan::System.Configuration.DefaultSettingValue("False")]
	public bool IsPublishToCatalogItemChangeQueueEnabled => (bool)this["IsPublishToCatalogItemChangeQueueEnabled"];

	[ConfMan::System.Configuration.ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[ConfMan::System.Configuration.DefaultSettingValue("False")]
	public bool IsPublishToUniverseChangeTopicEnabled => (bool)this["IsPublishToUniverseChangeTopicEnabled"];

	[ConfMan::System.Configuration.ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[ConfMan::System.Configuration.DefaultSettingValue("")]
	public string AwsUniverseChangeTopicAccessKeyIdAndSecretCsv => (string)this["AwsUniverseChangeTopicAccessKeyIdAndSecretCsv"];

	[ConfMan::System.Configuration.ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[ConfMan::System.Configuration.DefaultSettingValue("")]
	public string AwsUniverseChangeSnsTopicArn => (string)this["AwsUniverseChangeSnsTopicArn"];

	[ConfMan::System.Configuration.ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[ConfMan::System.Configuration.DefaultSettingValue("False")]
	public bool IsSettingUniversePrivacyTypeToPrivateOnMissingRootPlaceIdEnabled => (bool)this["IsSettingUniversePrivacyTypeToPrivateOnMissingRootPlaceIdEnabled"];

	[ConfMan::System.Configuration.ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[ConfMan::System.Configuration.DefaultSettingValue("Private")]
	public string DefaultUniversePrivacyType => (string)this["DefaultUniversePrivacyType"];

	[ConfMan::System.Configuration.ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[ConfMan::System.Configuration.DefaultSettingValue("50")]
	public int UniverseNameMaxLength => (int)this["UniverseNameMaxLength"];

	[ConfMan::System.Configuration.ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[ConfMan::System.Configuration.DefaultSettingValue("False")]
	public bool PermissionsV2ReadsEnabled => (bool)this["PermissionsV2ReadsEnabled"];

	[ConfMan::System.Configuration.ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[ConfMan::System.Configuration.DefaultSettingValue("0")]
	public double PermissionsV2ReadsPercentage => (double)this["PermissionsV2ReadsPercentage"];

	[ConfMan::System.Configuration.ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[ConfMan::System.Configuration.DefaultSettingValue("False")]
	public bool PermissionsV2PlayReadsEnabled => (bool)this["PermissionsV2PlayReadsEnabled"];

	[ConfMan::System.Configuration.ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[ConfMan::System.Configuration.DefaultSettingValue("0")]
	public double PermissionsV2PlayReadsPercentage => (double)this["PermissionsV2PlayReadsPercentage"];

	internal Settings()
	{
		base.PropertyChanged += delegate(object sender, PropertyChangedEventArgs propertyChangeEvent)
		{
			_Properties.TryRemove(propertyChangeEvent.PropertyName, out var _);
		};
	}

	protected override void OnSettingsLoaded(object sender, ConfMan::System.Configuration.SettingsLoadedEventArgs e)
	{
		base.OnSettingsLoaded(sender, e);
		Provider.RegisterSettings(e, this);
	}

	private void UpdateProperty(object sender, PropertyChangedEventArgs propertyChangeEvent)
	{
		_Properties.TryRemove(propertyChangeEvent.PropertyName, out var _);
	}
}


