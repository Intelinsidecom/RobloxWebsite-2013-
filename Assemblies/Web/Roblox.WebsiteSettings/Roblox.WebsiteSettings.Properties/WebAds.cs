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
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
public sealed class WebAds : ApplicationSettingsBase
{
	private readonly ConcurrentDictionary<string, object> _Properties = new ConcurrentDictionary<string, object>();

	private static WebAds defaultInstance = (WebAds)SettingsBase.Synchronized(new WebAds());

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

	public static WebAds Default => defaultInstance;

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("/1015347/VideoPrerollUnder13")]
	public string DFPPrerollAdUnitForGuestAndUnder13User => (string)this["DFPPrerollAdUnitForGuestAndUnder13User"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("/1015347/VideoPreroll")]
	public string DFPPrerollAdUnit => (string)this["DFPPrerollAdUnit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Production")]
	public string DFPPrerollEnvironment => (string)this["DFPPrerollEnvironment"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsSwfPreloaderEnabled => (bool)this["IsSwfPreloaderEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool IsCompanionAdRenderedByGoogleTag => (bool)this["IsCompanionAdRenderedByGoogleTag"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool PrerollAdsEnabled => (bool)this["PrerollAdsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("33")]
	public int PrerollLoadingBarLengthSeconds => (int)this["PrerollLoadingBarLengthSeconds"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("11000")]
	public int PrerollLoadingTimeout => (int)this["PrerollLoadingTimeout"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("41000")]
	public int PrerollPlayingTimeout => (int)this["PrerollPlayingTimeout"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool PrerollTrackEventsEnabled => (bool)this["PrerollTrackEventsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Get more with Builders Club!")]
	public string VideoPrerollUpsellText => (string)this["VideoPrerollUpsellText"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool DFPPrerollEnabled => (bool)this["DFPPrerollEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool PrerollMacEnabled => (bool)this["PrerollMacEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0.5")]
	public double PrerollSimplePercentageChance => (double)this["PrerollSimplePercentageChance"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string PrerollWhitelistPlaceIds => (string)this["PrerollWhitelistPlaceIds"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsLazyLoadUserAdsEnabledForSoothSayers => (bool)this["IsLazyLoadUserAdsEnabledForSoothSayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsLazyLoadUserAdsEnabledForAll => (bool)this["IsLazyLoadUserAdsEnabledForAll"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Red")]
	public string RPOSponsoredPageName => (string)this["RPOSponsoredPageName"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("jwcreatorchallenge")]
	public string JurassicWorldSponsoredPageName => (string)this["JurassicWorldSponsoredPageName"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsSponsoredPageOverrideUrlMapRouteEnabled => (bool)this["IsSponsoredPageOverrideUrlMapRouteEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("cn")]
	public string RestrictedCountryCodeCsv => (string)this["RestrictedCountryCodeCsv"];

	internal WebAds()
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
