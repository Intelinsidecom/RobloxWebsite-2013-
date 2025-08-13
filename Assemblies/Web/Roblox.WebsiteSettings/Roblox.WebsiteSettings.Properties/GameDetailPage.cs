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
[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
[SettingsProvider(typeof(Provider))]
public sealed class GameDetailPage : ApplicationSettingsBase
{
	private static GameDetailPage defaultInstance = (GameDetailPage)SettingsBase.Synchronized(new GameDetailPage());

	private readonly ConcurrentDictionary<string, object> _Properties = new ConcurrentDictionary<string, object>();

	public static GameDetailPage Default => defaultInstance;

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool IsLeaderboardAllTimeOptionFrontendEnabled => (bool)this["IsLeaderboardAllTimeOptionFrontendEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string ShareGameToChatMinAndroidBuildVersion => (string)this["ShareGameToChatMinAndroidBuildVersion"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string ShareGameToChatMinIosBuildVersion => (string)this["ShareGameToChatMinIosBuildVersion"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool IsLeaderboardDailyOptionFrontendEnabled => (bool)this["IsLeaderboardDailyOptionFrontendEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int ConvertPngToJpegRolloutPercentage => (int)this["ConvertPngToJpegRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsNewPlayButtonEnabled => (bool)this["IsNewPlayButtonEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string NewPlayButtonEnabledForUserIdWhitelist => (string)this["NewPlayButtonEnabledForUserIdWhitelist"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsCanAccessMultiplayerCacheEnabledForSoothsayers => (bool)this["IsCanAccessMultiplayerCacheEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsCanAccessMultiplayerCacheEnabledForBetaTesters => (bool)this["IsCanAccessMultiplayerCacheEnabledForBetaTesters"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int IsCanAccessMultiplayerCacheEnabledRolloutPercentage => (int)this["IsCanAccessMultiplayerCacheEnabledRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsCanAccessMultiplayerCacheTurnedOnForAll => (bool)this["IsCanAccessMultiplayerCacheTurnedOnForAll"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1")]
	public int ProductPromotionsPageSize => (int)this["ProductPromotionsPageSize"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsGameDetailReferralEventV2Enabled => (bool)this["IsGameDetailReferralEventV2Enabled"];

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

	internal GameDetailPage()
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
