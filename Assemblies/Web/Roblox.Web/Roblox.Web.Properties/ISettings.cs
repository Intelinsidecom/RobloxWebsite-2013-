using System;

namespace Roblox.Web.Properties;

public interface ISettings
{
	object this[string propertyName] { get; set; }

	bool AccessControlMaxAgeHeaderAddedToOptionsRequest { get; }

	int AccessControlMaxAgeInSeconds { get; }

	string AppDeviceIdentifierCookie_Name { get; }

	string CookielessUrlRegex { get; }

	bool CustomJsonSerializationOptInContractResolverEnabled { get; }

	string CustomJsonSerializationOptInContractResolverNamespaceRestriction { get; }

	bool CustomJsonSerializationOptInContractResolverSerializeUnmarkedObject { get; }

	bool CustomJsonSerializationOptInContractResolverUnmarkedProperty { get; }

	bool CustomJsonSerializationOptInContractResolverViolationLogError { get; }

	bool CustomJsonSerializationOptInContractResolverViolationThrowException { get; }

	bool EtagCheckIpMatch { get; }

	TimeSpan EtagIpExpiryTime { get; }

	bool IsGameServerJobSignatureCheckEnabled { get; }

	bool jQueryVersionLatest { get; }

	bool OmittingXsrfTokenIsAlwaysInvalid { get; }

	bool RbxUserTokenEnabled { get; }

	string RbxUserTokenHeaderName { get; }

	string RbxUserTokenSecretSalt { get; }

	bool RedirectCookielessUrls { get; }

	string RobloxEnableCorsAllowedOrigins { get; }

	bool RobloxHybridEnabled { get; }

	TimeSpan SessionCookieExpiration { get; }

	bool SessionCookieSetsDomain { get; }

	bool UpdatePresenceAfterActionExecuted { get; }

	bool UserScreenForIOSVersionNotSupportedEnabled { get; }

	bool XsrfOnHandlerIgnoresIisCustomErrors { get; }

	TimeSpan XsrfTokenCacheExpiry { get; }

	bool XsrfTokenValidationEnabled { get; }

	int XsrfWithCorsOptionsCacheTimeInMinutes { get; }

	bool LoggingMetricsEnabled { get; }

	string GameServerHeaderBypassValue { get; }

	bool IsGameServerOnlyHeaderBypassEnabled { get; }

	string CorsBlacklistedOrigins { get; }
}
