using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Roblox.Configuration;

namespace Roblox.Web.Devices.Properties;

/// <summary>
/// Configuration that uses Roblox.Configuration.Provider
/// </summary>
[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
[SettingsProvider(typeof(Provider))]
public sealed class Settings : ApplicationSettingsBase, ISettings
{
	private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());

	private readonly ConcurrentDictionary<string, object> _Properties = new ConcurrentDictionary<string, object>();

	public static Settings Default => defaultInstance;

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("500")]
	public int AndroidDeviceMemoryThreshold => (int)this["AndroidDeviceMemoryThreshold"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("6")]
	public double AndroidDeviceScreenPhysicalInchXThreshold => (double)this["AndroidDeviceScreenPhysicalInchXThreshold"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("4")]
	public double AndroidDeviceScreenPhysicalInchYThreshold => (double)this["AndroidDeviceScreenPhysicalInchYThreshold"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("powershell")]
	public string PowershellUserAgentString => (string)this["PowershellUserAgentString"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("7")]
	public int MinimumMajorIOSVersion => (int)this["MinimumMajorIOSVersion"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsDeviceHandleFloodCheckEnabled => (bool)this["IsDeviceHandleFloodCheckEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool VerifyDeviceHandleV1 => (bool)this["VerifyDeviceHandleV1"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool AcceptDeviceHandleV1 => (bool)this["AcceptDeviceHandleV1"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool VerifyDeviceHandleV2 => (bool)this["VerifyDeviceHandleV2"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool AcceptDeviceHandleV2 => (bool)this["AcceptDeviceHandleV2"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("RBX-Device-Handle")]
	public string DeviceHandleV1HeaderName => (string)this["DeviceHandleV1HeaderName"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("_rbldh")]
	public string DeviceHandleV1CookieName => (string)this["DeviceHandleV1CookieName"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("X-Ablm")]
	public string DeviceHandleV2HeaderName => (string)this["DeviceHandleV2HeaderName"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("_ablm")]
	public string DeviceHandleV2CookieName => (string)this["DeviceHandleV2CookieName"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool RobloxAppViaUserAgentDetectedAsRobloxAppEnabled => (bool)this["RobloxAppViaUserAgentDetectedAsRobloxAppEnabled"];

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
