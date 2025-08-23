using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Roblox.Configuration;

namespace Roblox.Web.Properties;

/// <summary>
/// Configuration that uses Roblox.Configuration.Provider
/// </summary>
[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
[SettingsProvider(typeof(Provider))]
[ExcludeFromCodeCoverage]
public sealed class Settings : ApplicationSettingsBase, ISettings
{
	private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());

	private readonly ConcurrentDictionary<string, object> _Properties = new ConcurrentDictionary<string, object>();

	public static Settings Default => defaultInstance;

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool XsrfTokenValidationEnabled => (bool)this["XsrfTokenValidationEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1.00:00:00")]
	public TimeSpan XsrfTokenCacheExpiry => (TimeSpan)this["XsrfTokenCacheExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool jQueryVersionLatest => (bool)this["jQueryVersionLatest"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("04:00:00")]
	public TimeSpan SessionCookieExpiration => (TimeSpan)this["SessionCookieExpiration"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool RedirectCookielessUrls => (bool)this["RedirectCookielessUrls"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("\\\\([a-zA-Z]\\\\([^/]*\\\\)\\\\)/(.*)")]
	public string CookielessUrlRegex => (string)this["CookielessUrlRegex"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("X-RBXUSER-TOKEN")]
	public string RbxUserTokenHeaderName => (string)this["RbxUserTokenHeaderName"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string RbxUserTokenSecretSalt => (string)this["RbxUserTokenSecretSalt"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool RbxUserTokenEnabled => (bool)this["RbxUserTokenEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool EtagCheckIpMatch => (bool)this["EtagCheckIpMatch"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1.00:00:00")]
	public TimeSpan EtagIpExpiryTime => (TimeSpan)this["EtagIpExpiryTime"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool UserScreenForIOSVersionNotSupportedEnabled => (bool)this["UserScreenForIOSVersionNotSupportedEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool RobloxHybridEnabled => (bool)this["RobloxHybridEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool SessionCookieSetsDomain => (bool)this["SessionCookieSetsDomain"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string RobloxEnableCorsAllowedOrigins => (string)this["RobloxEnableCorsAllowedOrigins"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("2")]
	public int XsrfWithCorsOptionsCacheTimeInMinutes => (int)this["XsrfWithCorsOptionsCacheTimeInMinutes"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool XsrfOnHandlerIgnoresIisCustomErrors => (bool)this["XsrfOnHandlerIgnoresIisCustomErrors"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool OmittingXsrfTokenIsAlwaysInvalid => (bool)this["OmittingXsrfTokenIsAlwaysInvalid"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("RBXAppDeviceIdentifier")]
	public string AppDeviceIdentifierCookie_Name => (string)this["AppDeviceIdentifierCookie_Name"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool UpdatePresenceAfterActionExecuted => (bool)this["UpdatePresenceAfterActionExecuted"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsGameServerJobSignatureCheckEnabled => (bool)this["IsGameServerJobSignatureCheckEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool AccessControlMaxAgeHeaderAddedToOptionsRequest => (bool)this["AccessControlMaxAgeHeaderAddedToOptionsRequest"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("600")]
	public int AccessControlMaxAgeInSeconds => (int)this["AccessControlMaxAgeInSeconds"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool CustomJsonSerializationOptInContractResolverEnabled => (bool)this["CustomJsonSerializationOptInContractResolverEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool CustomJsonSerializationOptInContractResolverViolationThrowException => (bool)this["CustomJsonSerializationOptInContractResolverViolationThrowException"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool CustomJsonSerializationOptInContractResolverViolationLogError => (bool)this["CustomJsonSerializationOptInContractResolverViolationLogError"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool CustomJsonSerializationOptInContractResolverSerializeUnmarkedObject => (bool)this["CustomJsonSerializationOptInContractResolverSerializeUnmarkedObject"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool CustomJsonSerializationOptInContractResolverUnmarkedProperty => (bool)this["CustomJsonSerializationOptInContractResolverUnmarkedProperty"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Roblox")]
	public string CustomJsonSerializationOptInContractResolverNamespaceRestriction => (string)this["CustomJsonSerializationOptInContractResolverNamespaceRestriction"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool LoggingMetricsEnabled => (bool)this["LoggingMetricsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool PageBaseCacheControlMustRevalidateHeaderEnabled => (bool)this["PageBaseCacheControlMustRevalidateHeaderEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("#notmybypass")]
	public string GameServerHeaderBypassValue => (string)this["GameServerHeaderBypassValue"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsGameServerOnlyHeaderBypassEnabled => (bool)this["IsGameServerOnlyHeaderBypassEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string CorsBlacklistedOrigins => (string)this["CorsBlacklistedOrigins"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string TotpXsrfTokenSecretKey => (string)this["TotpXsrfTokenSecretKey"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool OffsetTotpXsrfExpirationEnabled => (bool)this["OffsetTotpXsrfExpirationEnabled"];

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
