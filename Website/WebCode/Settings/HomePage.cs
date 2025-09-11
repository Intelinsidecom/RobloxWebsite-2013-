using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Roblox.Configuration;

namespace Roblox.WebsiteSettings.Properties;

/// <summary>
/// Configuration for Billing related features
/// </summary>
[SettingsProvider(typeof(Provider))]
[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
public sealed class HomePage : ApplicationSettingsBase
{
	private readonly ConcurrentDictionary<string, object> _Properties = new ConcurrentDictionary<string, object>();

	private static HomePage defaultInstance = (HomePage)SettingsBase.Synchronized(new HomePage());

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

	public static HomePage Default => defaultInstance;

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool IsMobileAppHomePageFooterEnabled => (bool)this["IsMobileAppHomePageFooterEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsBlogNewsHomePageInAppDisabled => (bool)this["IsBlogNewsHomePageInAppDisabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsDevExOnHomePageDisabled => (bool)this["IsDevExOnHomePageDisabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsMobileFeedOnlyPageEnabledForSoothsayers => (bool)this["IsMobileFeedOnlyPageEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsMobileFeedOnlyPageEnabledForAll => (bool)this["IsMobileFeedOnlyPageEnabledForAll"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsFindFriendsButtonEnabled => (bool)this["IsFindFriendsButtonEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsFindFriendsButtonEnabledForSoothsayers => (bool)this["IsFindFriendsButtonEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int FindFriendsButtonRolloutPercentage => (int)this["FindFriendsButtonRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("6")]
	public int FindFriendsMinimumMajorAndroidVersion => (int)this["FindFriendsMinimumMajorAndroidVersion"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("8")]
	public int FindFriendsMinimumMajorIOSVersion => (int)this["FindFriendsMinimumMajorIOSVersion"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("7.00:00:00")]
	public TimeSpan PlacesListAbTestingMinEnrollmentEligibleTimeSpan => (TimeSpan)this["PlacesListAbTestingMinEnrollmentEligibleTimeSpan"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool IsFeedsFeatureEnabled => (bool)this["IsFeedsFeatureEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsOverridingFeedsFeatureEnabledForSoothsayers => (bool)this["IsOverridingFeedsFeatureEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool IsFeedsFeatureEnabledForSoothsayers => (bool)this["IsFeedsFeatureEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public double NsOnePulsarTestScriptRatio => (double)this["NsOnePulsarTestScriptRatio"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public string LandingRedesignEnabledForBrowserTrackerIdWhitelist => (string)this["LandingRedesignEnabledForBrowserTrackerIdWhitelist"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int LandingRedesignRolloutPercentage => (int)this["LandingRedesignRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsLandingRedesignForAllEnabled => (bool)this["IsLandingRedesignForAllEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string LandingRedesignAbTestName => (string)this["LandingRedesignAbTestName"];

	internal HomePage()
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
