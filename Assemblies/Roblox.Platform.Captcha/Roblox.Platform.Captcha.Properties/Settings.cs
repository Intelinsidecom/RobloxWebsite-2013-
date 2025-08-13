using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Roblox.Configuration;

namespace Roblox.Platform.Captcha.Properties;

[SettingsProvider(typeof(Provider))]
[ExcludeFromCodeCoverage]
[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
public sealed class Settings : ApplicationSettingsBase, ISettings
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
	[DefaultSettingValue("00:05:00")]
	public TimeSpan SuccessExpirationTime => (TimeSpan)this["SuccessExpirationTime"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool IsCaptchaFirstMessageEnabledForAll => (bool)this["IsCaptchaFirstMessageEnabledForAll"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool CaptchaFirstFriendRequestEnabledForAll => (bool)this["CaptchaFirstFriendRequestEnabledForAll"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool CaptchaFirstFollowRequestEnabledForAll => (bool)this["CaptchaFirstFollowRequestEnabledForAll"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("365")]
	public int FollowCaptchaMinUserAgeInDays => (int)this["FollowCaptchaMinUserAgeInDays"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("365")]
	public int FriendRequestCaptchaMinUserAgeInDays => (int)this["FriendRequestCaptchaMinUserAgeInDays"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("365")]
	public int MessageCaptchaMinUserAgeInDays => (int)this["MessageCaptchaMinUserAgeInDays"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool CaptchaFirstGroupJoinEnabledForAll => (bool)this["CaptchaFirstGroupJoinEnabledForAll"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("365")]
	public int GroupJoinCaptchaMinUserAgeInDays => (int)this["GroupJoinCaptchaMinUserAgeInDays"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool CaptchaFirstPostCommentEnabledForSoothsayers => (bool)this["CaptchaFirstPostCommentEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool CaptchaFirstPostCommentEnabledForAll => (bool)this["CaptchaFirstPostCommentEnabledForAll"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("3600")]
	public int TimeInGameSecondsBypassCaptchaThreshold => (int)this["TimeInGameSecondsBypassCaptchaThreshold"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsTimeInGameBypassCaptchaEnabled => (bool)this["IsTimeInGameBypassCaptchaEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool IsAccountAgeBypassCaptchaEnabled => (bool)this["IsAccountAgeBypassCaptchaEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("2")]
	public int TimeInGameMonthsRangeFromCurrentInclusive => (int)this["TimeInGameMonthsRangeFromCurrentInclusive"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool TimeInGameBypassOnlyIncludeRecentMonths => (bool)this["TimeInGameBypassOnlyIncludeRecentMonths"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsCaptchaOnClothingUploadsEnabledForSoothsayers => (bool)this["IsCaptchaOnClothingUploadsEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsCaptchaOnClothingUploadsEnabledForAll => (bool)this["IsCaptchaOnClothingUploadsEnabledForAll"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("365")]
	public int ClothingUploadCaptchaMinUserAgeInDays => (int)this["ClothingUploadCaptchaMinUserAgeInDays"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("6LcXuDUUAAAAABcfUv0HcM77gEF5bK80FN5EGUXU")]
	public string GoogleTrulyInvisibleCaptchaPublicKey => (string)this["GoogleTrulyInvisibleCaptchaPublicKey"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string GoogleTrulyInvisibleCaptchaPrivateKey => (string)this["GoogleTrulyInvisibleCaptchaPrivateKey"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsTrulyInvisibleCaptchaEnabledForAll => (bool)this["IsTrulyInvisibleCaptchaEnabledForAll"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsTrulyInvisibleCaptchaEnabledForSoothsayers => (bool)this["IsTrulyInvisibleCaptchaEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int TrulyInvisibleCaptchaLoggingPercentage => (int)this["TrulyInvisibleCaptchaLoggingPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsCaptchaV2RequiredForUserRequests => (bool)this["IsCaptchaV2RequiredForUserRequests"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsCaptchaV2RequiredForAllRequests => (bool)this["IsCaptchaV2RequiredForAllRequests"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool CaptchaFavoritesEnabledForSoothsayers => (bool)this["CaptchaFavoritesEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool CaptchaFavoritesEnabledForAll => (bool)this["CaptchaFavoritesEnabledForAll"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string CaptchaFavoritesAssetTypesCsv => (string)this["CaptchaFavoritesAssetTypesCsv"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool GroupWallPostCaptchaEnabledForAll => (bool)this["GroupWallPostCaptchaEnabledForAll"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool CaptchaCompletedReverseFloodCheckerUsernameKeyEnabled => (bool)this["CaptchaCompletedReverseFloodCheckerUsernameKeyEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool CaptchaCompletedReverseFloodCheckerUserIdKeyEnabled => (bool)this["CaptchaCompletedReverseFloodCheckerUserIdKeyEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool CaptchaCompletedReverseFloodCheckerEnabled => (bool)this["CaptchaCompletedReverseFloodCheckerEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("06:00:00")]
	public TimeSpan CaptchaCompletedReverseFloodCheckerExpiry => (TimeSpan)this["CaptchaCompletedReverseFloodCheckerExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1")]
	public int CaptchaCompletedReverseFloodCheckerLimit => (int)this["CaptchaCompletedReverseFloodCheckerLimit"];

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
