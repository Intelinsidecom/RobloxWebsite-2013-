using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Roblox.Configuration;

namespace Roblox.WebsiteSettings.Properties;

/// <summary>
/// Configuration that uses Roblox.Configuration.Provider
/// </summary>
[SettingsProvider(typeof(Provider))]
[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.6.0.0")]
public sealed class GoogleAnalytics : ApplicationSettingsBase
{
	private readonly ConcurrentDictionary<string, object> _Properties = new ConcurrentDictionary<string, object>();

	private static GoogleAnalytics defaultInstance = (GoogleAnalytics)SettingsBase.Synchronized(new GoogleAnalytics());

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

	public static GoogleAnalytics Default => defaultInstance;

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("roblox.com")]
	public string GoogleAnalyticsDomainName => (string)this["GoogleAnalyticsDomainName"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool GoogleAnalyticsContentGroupsEnabled => (bool)this["GoogleAnalyticsContentGroupsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool IsJavascriptExceptionLoggingEnabled => (bool)this["IsJavascriptExceptionLoggingEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("10")]
	public int Async3AnalyticsSampleRateValue => (int)this["Async3AnalyticsSampleRateValue"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsAsync3AnalyticsSampleRateEnabled => (bool)this["IsAsync3AnalyticsSampleRateEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string Async4AnalyticsAccountCode => (string)this["Async4AnalyticsAccountCode"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool GoogleAnalyticsSetDomainNameEnabled => (bool)this["GoogleAnalyticsSetDomainNameEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ExcludeGoogleAnalyticsFromAccountRecoveryPage => (bool)this["ExcludeGoogleAnalyticsFromAccountRecoveryPage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool IsGaDFPPreRollEventEnabled => (bool)this["IsGaDFPPreRollEventEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool IsGaPerformanceEventEnabled => (bool)this["IsGaPerformanceEventEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("cn")]
	public string RestrictedCountryCodeCsv => (string)this["RestrictedCountryCodeCsv"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("100")]
	public int Async2AnalyticsSampleRateValue => (int)this["Async2AnalyticsSampleRateValue"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsAsync2AnalyticsSampleRateEnabled => (bool)this["IsAsync2AnalyticsSampleRateEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string GoogleSiteVerificationToken => (string)this["GoogleSiteVerificationToken"];

	internal GoogleAnalytics()
	{
		base.PropertyChanged += delegate(object sender, PropertyChangedEventArgs propertyChangeEvent)
		{
			_Properties.TryRemove(propertyChangeEvent.PropertyName, out var _);
		};
	}

	protected override void OnSettingsLoaded(object sender, SettingsLoadedEventArgs e)
	{
		base.OnSettingsLoaded(sender, e);
		Provider.RegisterSettings(e, this);
	}

	private void UpdateProperty(object sender, PropertyChangedEventArgs propertyChangeEvent)
	{
		_Properties.TryRemove(propertyChangeEvent.PropertyName, out var _);
	}
}
