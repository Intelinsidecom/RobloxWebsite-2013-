using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Roblox.Configuration;

namespace Roblox.Platform.Infrastructure.Properties;

[SettingsProvider(typeof(Provider))]
[ExcludeFromCodeCoverage]
[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.8.0.0")]
internal sealed class Settings : ApplicationSettingsBase, ISettings
{
	private readonly ConcurrentDictionary<string, object> _Properties = new ConcurrentDictionary<string, object>();

	private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());

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

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string GameServerJobSignatureSalt => (string)this["GameServerJobSignatureSalt"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string GameServerJobSignatureAlternateSalt => (string)this["GameServerJobSignatureAlternateSalt"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:10:00")]
	public TimeSpan VendorIDToNameMapRefreshInterval => (TimeSpan)this["VendorIDToNameMapRefreshInterval"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:05:00")]
	public TimeSpan ServerIDsInAllowedGroupsRefreshInterval => (TimeSpan)this["ServerIDsInAllowedGroupsRefreshInterval"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:01:00")]
	public TimeSpan PrimaryIPAddressToServerMapRefreshInterval => (TimeSpan)this["PrimaryIPAddressToServerMapRefreshInterval"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:00:05")]
	public TimeSpan DosArrestNetworksRefreshInterval => (TimeSpan)this["DosArrestNetworksRefreshInterval"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("45")]
	public string AllowedServerGroupIDs => (string)this["AllowedServerGroupIDs"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:01:00")]
	public TimeSpan GameRelayIpAddressToDatacenterIdMapRefreshInterval => (TimeSpan)this["GameRelayIpAddressToDatacenterIdMapRefreshInterval"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string XForwardedForProxyIpAddressRanges => (string)this["XForwardedForProxyIpAddressRanges"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("2")]
	public string AllowedXForwardedForProxyServerTypeIds => (string)this["AllowedXForwardedForProxyServerTypeIds"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:05:00")]
	public TimeSpan SnatIpAddressesRefreshInterval => (TimeSpan)this["SnatIpAddressesRefreshInterval"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ReadSnatIpAddressesFromDatabase => (bool)this["ReadSnatIpAddressesFromDatabase"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string WhitelistedIpAddressRanges => (string)this["WhitelistedIpAddressRanges"];

	internal Settings()
	{
		base.PropertyChanged += delegate(object sender, PropertyChangedEventArgs args)
		{
			_Properties.TryRemove(args.PropertyName, out var _);
		};
	}

	protected override void OnSettingsLoaded(object sender, SettingsLoadedEventArgs e)
	{
		base.OnSettingsLoaded(sender, e);
		Provider.RegisterSettings(e, this);
	}
}
