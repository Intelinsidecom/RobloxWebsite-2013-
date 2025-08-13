using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Roblox.Configuration;

namespace Roblox.Platform.XboxLive.Properties;

/// <summary>
/// Configuration that uses Roblox.Configuration.Provider
/// </summary>
[SettingsProvider(typeof(Provider))]
[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.3.0.0")]
internal sealed class Settings : ApplicationSettingsBase, IXboxLiveSettings
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
	[DefaultSettingValue("00:00:10")]
	public TimeSpan XboxLiveAccountManagementLockTimeout => (TimeSpan)this["XboxLiveAccountManagementLockTimeout"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool XboxLiveSignupEnabled => (bool)this["XboxLiveSignupEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1000")]
	public int XboxExclusiveCatalogAssetsMaxCount => (int)this["XboxExclusiveCatalogAssetsMaxCount"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("65241,1426962,1436444,2471084,27484317,16600266,31751338,43565599,67622937,68797667,71674506,77518451,77610935,78351145,79481129,80718732,84941230,85824585,83858907,88683984,93690795,93740418,104929499")]
	public string XboxExclusiveGameUniverseIds => (string)this["XboxExclusiveGameUniverseIds"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool XboxLiveAccountLinkingEnabled => (bool)this["XboxLiveAccountLinkingEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool XboxUserLoginConsecutiveDayCountEnabled => (bool)this["XboxUserLoginConsecutiveDayCountEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool XboxCurrencyBudgetsEnabled => (bool)this["XboxCurrencyBudgetsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool XboxExclusivityEnabled => (bool)this["XboxExclusivityEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string XboxSoothsayerUserIdCsv => (string)this["XboxSoothsayerUserIdCsv"];

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
