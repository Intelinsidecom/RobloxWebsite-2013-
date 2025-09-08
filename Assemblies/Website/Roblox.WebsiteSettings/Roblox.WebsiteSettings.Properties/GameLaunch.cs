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
public sealed class GameLaunch : ApplicationSettingsBase, IGameLaunchSettings
{
	private static GameLaunch defaultInstance = (GameLaunch)SettingsBase.Synchronized(new GameLaunch());

	private readonly ConcurrentDictionary<string, object> _Properties = new ConcurrentDictionary<string, object>();

	public static GameLaunch Default => defaultInstance;

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsAndroidPlayOnChromeBookEnabledForSoothsayers => (bool)this["IsAndroidPlayOnChromeBookEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsAndroidPlayOnChromeBookEnabledForAll => (bool)this["IsAndroidPlayOnChromeBookEnabledForAll"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsStudioPluginLaunchModeEnabled => (bool)this["IsStudioPluginLaunchModeEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsDisplayingReasonProhibitedEnabledForSoothsayers => (bool)this["IsDisplayingReasonProhibitedEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("https://en.help.roblox.com/hc/es/articles/204473560-C%C3%B3mo-Instalar-y-Jugar-Roblox-Usando-el-Navegador")]
	public string GameInstallHelpPageUrlSpanish => (string)this["GameInstallHelpPageUrlSpanish"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("https://en.help.roblox.com/hc/en-us/articles/204473560-How-to-Install-and-Play-Roblox-Using-Browser")]
	public string GameInstallHelpPageUrlEnglish => (string)this["GameInstallHelpPageUrlEnglish"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool IsGaLaunchAttemptAndLaunchSuccessEnabled => (bool)this["IsGaLaunchAttemptAndLaunchSuccessEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool AreProtocolSeparateScriptParametersEnabledForAll => (bool)this["AreProtocolSeparateScriptParametersEnabledForAll"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool AreProtocolSeparateScriptParametersEnabledForSoothsayers => (bool)this["AreProtocolSeparateScriptParametersEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int ProtocolSeparateScriptParametersRolloutPercentage => (int)this["ProtocolSeparateScriptParametersRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("100")]
	public int ProtocolAvatarParameterEnabledPercentage => (int)this["ProtocolAvatarParameterEnabledPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string GuestIpFloodCheckBypassCsv => (string)this["GuestIpFloodCheckBypassCsv"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsSendingUserSupportedLocaleInProtocolLaunchEnabledForSoothsayers => (bool)this["IsSendingUserSupportedLocaleInProtocolLaunchEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int IsSendingUserSupportedLocaleInProtocolLaunchEnabledRollout => (int)this["IsSendingUserSupportedLocaleInProtocolLaunchEnabledRollout"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsSendingUserSupportedLocaleInProtocolLaunchEnabledForAll => (bool)this["IsSendingUserSupportedLocaleInProtocolLaunchEnabledForAll"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool IsPlayTogetherJoinPrivateGameEnabled => (bool)this["IsPlayTogetherJoinPrivateGameEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsGameLaunchFromGameUpdateIOSEnabled => (bool)this["IsGameLaunchFromGameUpdateIOSEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsGameLaunchFromGameUpdateAndroidEnabled => (bool)this["IsGameLaunchFromGameUpdateAndroidEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsGameLaunchFromGameUpdateWindowsAppEnabled => (bool)this["IsGameLaunchFromGameUpdateWindowsAppEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsSendingIndependentGameLocaleEnabledForSoothsayers => (bool)this["IsSendingIndependentGameLocaleEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int IsSendingIndependentGameLocaleEnabledRollout => (int)this["IsSendingIndependentGameLocaleEnabledRollout"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsSendingIndependentGameLocaleEnabledForAll => (bool)this["IsSendingIndependentGameLocaleEnabledForAll"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool FetchClientVersionsFromVersionCompatibilityService => (bool)this["FetchClientVersionsFromVersionCompatibilityService"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsGameLaunchDialogRefactorEnabled => (bool)this["IsGameLaunchDialogRefactorEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("2.358")]
	public string MinAndroidAppVersionForGameLaunchFromGameUpdate => (string)this["MinAndroidAppVersionForGameLaunchFromGameUpdate"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsProtocolHandlerBaseUrlParamEnabled => (bool)this["IsProtocolHandlerBaseUrlParamEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsGameJoinRequestProcessorForRequestGameEnabledForSoothsayers => (bool)this["IsGameJoinRequestProcessorForRequestGameEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int GameJoinRequestProcessorForRequestGameRolloutPercentage => (int)this["GameJoinRequestProcessorForRequestGameRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsGameJoinRequestProcessorForRequestGameEnabledForAll => (bool)this["IsGameJoinRequestProcessorForRequestGameEnabledForAll"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool IsGameJoinEnabled => (bool)this["IsGameJoinEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsGameJoinRefactorForJoinTicketEnabledForSoothsayers => (bool)this["IsGameJoinRefactorForJoinTicketEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int GameJoinRefactorForJoinTicketRolloutPercentage => (int)this["GameJoinRefactorForJoinTicketRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsGameJoinRefactorForJoinTicketEnabledForAll => (bool)this["IsGameJoinRefactorForJoinTicketEnabledForAll"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool UseSessionIdToVerifyUserPresenceDuringTeleport => (bool)this["UseSessionIdToVerifyUserPresenceDuringTeleport"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool BlockTeleportsIfUserSessionInvalid => (bool)this["BlockTeleportsIfUserSessionInvalid"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool BlockTeleportsIfSessionIdHeaderAbsent => (bool)this["BlockTeleportsIfSessionIdHeaderAbsent"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool UseTeleportValidationHelper => (bool)this["UseTeleportValidationHelper"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool StreamIllegalTeleportEvent => (bool)this["StreamIllegalTeleportEvent"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool AreWarningLogsEnabledForClbPlaceLaunchCheck => (bool)this["AreWarningLogsEnabledForClbPlaceLaunchCheck"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool EnableAuthenticationApiAuthenticationTicketsForSoothsayers => (bool)this["EnableAuthenticationApiAuthenticationTicketsForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int AuthenticationApiAuthenticationTicketsRolloutPercent => (int)this["AuthenticationApiAuthenticationTicketsRolloutPercent"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsRobloxIconGameLaunchEnabledForRetheme => (bool)this["IsRobloxIconGameLaunchEnabledForRetheme"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsGameJoinRequestProcessorForRequestGameJobEnabledForSoothsayers => (bool)this["IsGameJoinRequestProcessorForRequestGameJobEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int GameJoinRequestProcessorForRequestGameJobRolloutPercentage => (int)this["GameJoinRequestProcessorForRequestGameJobRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsGameJoinRequestProcessorForRequestGameJobEnabledForAll => (bool)this["IsGameJoinRequestProcessorForRequestGameJobEnabledForAll"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsGameJoinRequestProcessorForRequestPrivateGameEnabledForSoothsayers => (bool)this["IsGameJoinRequestProcessorForRequestPrivateGameEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int GameJoinRequestProcessorForRequestPrivateGameRolloutPercentage => (int)this["GameJoinRequestProcessorForRequestPrivateGameRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsGameJoinRequestProcessorForRequestPrivateGameEnabledForAll => (bool)this["IsGameJoinRequestProcessorForRequestPrivateGameEnabledForAll"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsGameJoinRequestProcessorForRequestFollowUserEnabledForSoothsayers => (bool)this["IsGameJoinRequestProcessorForRequestFollowUserEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int GameJoinRequestProcessorForRequestFollowUserRolloutPercentage => (int)this["GameJoinRequestProcessorForRequestFollowUserRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsGameJoinRequestProcessorForRequestFollowUserEnabledForAll => (bool)this["IsGameJoinRequestProcessorForRequestFollowUserEnabledForAll"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsGameJoinRequestProcessorForCloudEditEnabledForSoothsayers => (bool)this["IsGameJoinRequestProcessorForCloudEditEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int GameJoinRequestProcessorForCloudEditRolloutPercentage => (int)this["GameJoinRequestProcessorForCloudEditRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsGameJoinRequestProcessorForCloudEditEnabledForAll => (bool)this["IsGameJoinRequestProcessorForCloudEditEnabledForAll"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsGameJoinRequestProcessorForRequestPlayWithPartyEnabledForSoothsayers => (bool)this["IsGameJoinRequestProcessorForRequestPlayWithPartyEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int GameJoinRequestProcessorForRequestPlayWithPartyRolloutPercentage => (int)this["GameJoinRequestProcessorForRequestPlayWithPartyRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsGameJoinRequestProcessorForRequestPlayWithPartyEnabledForAll => (bool)this["IsGameJoinRequestProcessorForRequestPlayWithPartyEnabledForAll"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsGameJoinRequestProcessorForPlayTogetherGameEnabledForSoothsayers => (bool)this["IsGameJoinRequestProcessorForPlayTogetherGameEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int GameJoinRequestProcessorForPlayTogetherGameRolloutPercentage => (int)this["GameJoinRequestProcessorForPlayTogetherGameRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsGameJoinRequestProcessorForPlayTogetherGameEnabledForAll => (bool)this["IsGameJoinRequestProcessorForPlayTogetherGameEnabledForAll"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsPlayabilityCheckForCloudEditEnabled => (bool)this["IsPlayabilityCheckForCloudEditEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string GameJoinPlaceIdWhiteListForWarningLogs => (string)this["GameJoinPlaceIdWhiteListForWarningLogs"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string GameJoinUserIdWhiteListForWarningLogs => (string)this["GameJoinUserIdWhiteListForWarningLogs"];

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

	internal GameLaunch()
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
