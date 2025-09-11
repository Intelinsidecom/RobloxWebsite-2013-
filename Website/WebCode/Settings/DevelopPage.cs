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
public sealed class DevelopPage : ApplicationSettingsBase
{
	private readonly ConcurrentDictionary<string, object> _Properties = new ConcurrentDictionary<string, object>();

	private static DevelopPage defaultInstance = (DevelopPage)SettingsBase.Synchronized(new DevelopPage());

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

	public static DevelopPage Default => defaultInstance;

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("http://devforum.roblox.com")]
	public string RobloxDevforumLink => (string)this["RobloxDevforumLink"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("https://www.youtube.com/playlist?list=PLuEQ5BB-Z1PLiLI_As4MC3SMS5Gwbwl40")]
	public string RobloxUniversityLink => (string)this["RobloxUniversityLink"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("http://wiki.roblox.com")]
	public string RobloxWikiLink => (string)this["RobloxWikiLink"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("https://www.youtube.com/embed/SkMLcBPXHUA")]
	public string RobloxUniversityVideo1Link => (string)this["RobloxUniversityVideo1Link"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("https://www.youtube.com/embed/3nn_eQwhBc8")]
	public string RobloxUniversityVideo2Link => (string)this["RobloxUniversityVideo2Link"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("SkMLcBPXHUA")]
	public string RobloxUniversityVideo1Id => (string)this["RobloxUniversityVideo1Id"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("3nn_eQwhBc8")]
	public string RobloxUniversityVideo2Id => (string)this["RobloxUniversityVideo2Id"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("https://en.help.roblox.com/hc/en-us/articles/203314100")]
	public string RobloxDevExHelpFullUrl => (string)this["RobloxDevExHelpFullUrl"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsDevelopSiteForVipServersEnabled => (bool)this["IsDevelopSiteForVipServersEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsCrashRateFilteringStatsEnabled => (bool)this["IsCrashRateFilteringStatsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsProportionDeveloperSettingEnabled => (bool)this["IsProportionDeveloperSettingEnabled"];

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("https://www.youtube.com/embed/ESONLLLwF8A?mute=1&autoplay=1&showinfo=0&controls=0&disablekb=1&loop=1&playlist=ESONLLLwF8A")]
	public string RobloxMontageVideoLink
	{
		get
		{
			return (string)this["RobloxMontageVideoLink"];
		}
		set
		{
			this["RobloxMontageVideoLink"] = value;
		}
	}

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("https://en.help.roblox.com/hc/en-us/articles/115005718246-Developer-Exchange-Terms-of-Use")]
	public string RobloxDevExTermsFullUrl => (string)this["RobloxDevExTermsFullUrl"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("8000")]
	public int SetImageUploadMaxDimension => (int)this["SetImageUploadMaxDimension"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("60")]
	public int GameUpdateMaxLength => (int)this["GameUpdateMaxLength"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsJointPositioningTypeSettingEnabled => (bool)this["IsJointPositioningTypeSettingEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsMorphingSettingEnabled => (bool)this["IsMorphingSettingEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsGameDevStatsEnabled => (bool)this["IsGameDevStatsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsGameUpdateAnalyticsUIEnabled => (bool)this["IsGameUpdateAnalyticsUIEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ViewGroupDevelopWithClothingPermissionsEnabledForAll => (bool)this["ViewGroupDevelopWithClothingPermissionsEnabledForAll"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ViewGroupDevelopWithClothingPermissionsEnabledForSoothsayers => (bool)this["ViewGroupDevelopWithClothingPermissionsEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool AreNotForSaleItemsIncludedInLibrarySearchEnabled => (bool)this["AreNotForSaleItemsIncludedInLibrarySearchEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool AreNotForSaleItemsHiddenForLibraryItemTypesInSearchEnabled => (bool)this["AreNotForSaleItemsHiddenForLibraryItemTypesInSearchEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool DefaultIncludeNotForSaleValueOnParseFailure => (bool)this["DefaultIncludeNotForSaleValueOnParseFailure"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ArePartiallyModeratedUniverseNameAndDescriptionAllowed => (bool)this["ArePartiallyModeratedUniverseNameAndDescriptionAllowed"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsArchivedUIEnabledOnDevelopPage => (bool)this["IsArchivedUIEnabledOnDevelopPage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("https://developer.roblox.com/")]
	public string RobloxDevHubLink => (string)this["RobloxDevHubLink"];

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsCashoutPageWebAppEnabled => (bool)this["IsCashoutPageWebAppEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsPlaceRevertSaveOnly => (bool)this["IsPlaceRevertSaveOnly"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ShowVersionHistoryBanner => (bool)this["ShowVersionHistoryBanner"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ShowVersionHistoryPopup => (bool)this["ShowVersionHistoryPopup"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsGroupAdvertisePermissionCheckOnUserAdsListEnabled => (bool)this["IsGroupAdvertisePermissionCheckOnUserAdsListEnabled"];

	internal DevelopPage()
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
