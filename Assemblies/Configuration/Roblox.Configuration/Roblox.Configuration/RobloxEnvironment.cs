using System;
using System.Collections.Generic;
using Roblox.Configuration.Properties;

namespace Roblox.Configuration;

public static class RobloxEnvironment
{
	private static readonly string _InternalApiServicePrefix;

	private static readonly string _InternalApiServiceSuffix;

	private static readonly string _ApiServiceSuffix;

	public static string Abbreviation { get; }

	public static string Name { get; }

	public static int Id { get; }

	public static string Domain { get; }

	public static string WebsiteUrl { get; }

	public static string CdnDomain { get; }

	public static string ChinaBaseDomain { get; }

	public static string ChinaCdnDomain { get; }

	public static string ApiGatewayUrl { get; }

	public static string ApiProxyUrl { get; }

	public static string WebsiteHttpsUrl { get; }

	public static string AvatarApiUrl { get; }

	public static string InventoryApiUrl { get; }

	public static string PublishApiUrl { get; }

	public static string BillingApiUrl { get; }

	public static string ChatApiUrl { get; }

	public static string DiscussionsApiUrl { get; }

	public static string GroupsApiUrl { get; }

	public static string DevelopApiUrl { get; }

	public static string CatalogApiUrl { get; }

	public static string AccountSettingsApiUrl { get; }

	public static string AuthenticationApiUrl { get; }

	public static string GamesApiUrl { get; }

	public static string LocaleApiUrl { get; }

	public static string CaptchaApiUrl { get; }

	public static string FriendsApiUrl { get; }

	public static string FriendsAppSiteUrl { get; }

	public static string PointsApiUrl { get; }

	public static string PresenceApiUrl { get; }

	public static string BadgesApiUrl { get; }

	public static string NotificationApiUrl { get; }

	public static string AssetDeliveryApiUrl { get; }

	public static string ThumbnailsApiUrl { get; }

	public static string TranslationsApiUrl { get; }

	public static string AbTestingApiUrl { get; }

	public static string AuthAppSiteUrl { get; }

	public static string GameInternationalizationApiUrl { get; }

	public static string FollowingsApiUrl { get; }

	public static string AdsApiUrl { get; }

	public static string SurveysApiUrl { get; }

	public static string RatingsApiUrl { get; }

	public static string PremiumFeaturesApiUrl { get; }

	public static string EconomyApiUrl { get; }

	public static string TranslationRolesApiUrl { get; }

	public static string MetricsApiUrl { get; }

	public static string ContactsApiUrl { get; }

	public static string MidasApiUrl { get; }

	public static string LocalizationTablesApiUrl { get; }

	public static string VoiceApiUrl { get; }

	public static string TradesApiUrl { get; }

	public static string AccountInformationApiUrl { get; }

	public static string ItemConfigurationApiUrl { get; }

	public static string ThumbnailsResizerApiUrl { get; }

	public static string UsersApiUrl { get; }

	public static string UniversalAppConfigurationApiUrl { get; }

	public static string EngagementPayoutsApiUrl { get; }

	public static string ScreenTimeApiUrl { get; }

	public static Dictionary<string, string> ApiSiteDomains { get; }

	static RobloxEnvironment()
	{
		Abbreviation = EnvironmentSettings.Default.EnvironmentAbbreviation;
		Name = EnvironmentSettings.Default.EnvironmentName;
		Id = EnvironmentSettings.Default.EnvironmentId;
		Domain = EnvironmentSettings.Default.ApplicationDomain;
		ChinaBaseDomain = EnvironmentSettings.Default.ChinaBaseDomain;
		WebsiteUrl = $"http://www.{Domain}";
		_InternalApiServicePrefix = EnvironmentSettings.Default.InternalServicesProtocol + "://";
		_InternalApiServiceSuffix = "." + EnvironmentSettings.Default.InternalServicesDomain;
		_ApiServiceSuffix = ".api." + Domain;
		CdnDomain = EnvironmentSettings.Default.CdnDomain;
		ChinaCdnDomain = EnvironmentSettings.Default.ChinaCdnDomain;
		ApiGatewayUrl = $"https://apis.{Domain}";
		ApiProxyUrl = $"https://api.{Domain}";
		WebsiteHttpsUrl = $"https://www.{Domain}";
		AvatarApiUrl = $"https://avatar.{Domain}";
		InventoryApiUrl = $"https://inventory.{Domain}";
		PublishApiUrl = $"https://publish.{Domain}";
		BillingApiUrl = $"https://billing.{Domain}";
		ChatApiUrl = $"https://{EnvironmentSettings.Default.ChatApiPrefix}.{Domain}";
		DiscussionsApiUrl = $"https://{EnvironmentSettings.Default.DiscussionsApiPrefix}.{Domain}";
		GroupsApiUrl = $"https://groups.{Domain}";
		DevelopApiUrl = $"https://develop.{Domain}";
		CatalogApiUrl = $"https://catalog.{Domain}";
		AccountSettingsApiUrl = $"https://accountsettings.{Domain}";
		AuthenticationApiUrl = $"https://auth.{Domain}";
		LocaleApiUrl = $"https://{EnvironmentSettings.Default.LocaleApiPrefix}.{Domain}";
		GamesApiUrl = $"https://games.{Domain}";
		FriendsApiUrl = $"https://friends.{Domain}";
		FriendsAppSiteUrl = $"https://{EnvironmentSettings.Default.FriendsAppSitePrefix}.{Domain}";
		PointsApiUrl = $"https://points.{Domain}";
		PresenceApiUrl = $"https://presence.{Domain}";
		BadgesApiUrl = $"https://badges.{Domain}";
		NotificationApiUrl = $"https://notifications.{Domain}";
		AssetDeliveryApiUrl = $"https://assetdelivery.{Domain}";
		ThumbnailsApiUrl = $"https://thumbnails.{Domain}";
		TranslationsApiUrl = $"https://{EnvironmentSettings.Default.TranslationsApiSitePrefix}.{Domain}";
		AbTestingApiUrl = $"https://{EnvironmentSettings.Default.AbTestingApiPrefix}.{Domain}";
		MetricsApiUrl = $"https://{EnvironmentSettings.Default.MetricsApiSiteSubdomain}.{Domain}";
		MidasApiUrl = $"https://{EnvironmentSettings.Default.MidasApiPrefix}.{Domain}";
		LocalizationTablesApiUrl = $"https://{EnvironmentSettings.Default.LocalizationTablesApiPrefix}.{Domain}";
		FollowingsApiUrl = $"https://followings.{Domain}";
		AuthAppSiteUrl = $"https://{EnvironmentSettings.Default.AuthAppSitePrefix}.{Domain}";
		GameInternationalizationApiUrl = $"https://{EnvironmentSettings.Default.GameInternationalizationApiSitePrefix}.{Domain}";
		CaptchaApiUrl = $"https://captcha.{Domain}";
		AdsApiUrl = $"https://ads.{Domain}";
		SurveysApiUrl = $"https://surveys.{Domain}";
		RatingsApiUrl = $"https://ratings.{Domain}";
		PremiumFeaturesApiUrl = $"https://premiumfeatures.{Domain}";
		EconomyApiUrl = $"https://economy.{Domain}";
		VoiceApiUrl = $"https://voice.{Domain}";
		TradesApiUrl = $"https://trades.{Domain}";
		AccountInformationApiUrl = $"https://accountinformation.{Domain}";
		UniversalAppConfigurationApiUrl = $"{ApiGatewayUrl}/universal-app-configuration";
		TranslationRolesApiUrl = $"https://{EnvironmentSettings.Default.TranslationRolesApiSitePrefix}.{Domain}";
		ContactsApiUrl = $"https://{EnvironmentSettings.Default.ContactsApiSitePrefix}.{Domain}";
		ItemConfigurationApiUrl = $"https://{EnvironmentSettings.Default.ItemConfigurationApiSitePrefix}.{Domain}";
		ThumbnailsResizerApiUrl = $"https://thumbnailsresizer.{Domain}";
		UsersApiUrl = $"https://users.{Domain}";
		EngagementPayoutsApiUrl = $"https://engagementpayouts.{Domain}";
		ScreenTimeApiUrl = $"https://apis.rcs.{Domain}/screen-time-api";
		ApiSiteDomains = new Dictionary<string, string>
		{
			{ "abtestingApiSite", AbTestingApiUrl },
			{ "accountInformationApi", AccountInformationApiUrl },
			{ "accountSettingsApi", AccountSettingsApiUrl },
			{ "apiGatewayUrl", ApiGatewayUrl },
			{ "apiProxyUrl", ApiProxyUrl },
			{ "assetDeliveryApi", AssetDeliveryApiUrl },
			{ "authApi", AuthenticationApiUrl },
			{ "authAppSite", AuthAppSiteUrl },
			{ "avatarApi", AvatarApiUrl },
			{ "badgesApi", BadgesApiUrl },
			{ "billingApi", BillingApiUrl },
			{ "captchaApi", CaptchaApiUrl },
			{ "catalogApi", CatalogApiUrl },
			{ "chatApi", ChatApiUrl },
			{ "contactsApi", ContactsApiUrl },
			{ "developApi", DevelopApiUrl },
			{ "domain", Domain },
			{ "economyApi", EconomyApiUrl },
			{ "engagementPayoutsApi", EngagementPayoutsApiUrl },
			{ "followingsApi", FollowingsApiUrl },
			{ "friendsApi", FriendsApiUrl },
			{ "friendsAppSite", FriendsAppSiteUrl },
			{ "gamesApi", GamesApiUrl },
			{ "gameInternationalizationApi", GameInternationalizationApiUrl },
			{ "groupsApi", GroupsApiUrl },
			{ "inventoryApi", InventoryApiUrl },
			{ "itemConfigurationApi", ItemConfigurationApiUrl },
			{ "localeApi", LocaleApiUrl },
			{ "localizationTablesApi", LocalizationTablesApiUrl },
			{ "metricsApi", MetricsApiUrl },
			{ "midasApi", MidasApiUrl },
			{ "notificationApi", NotificationApiUrl },
			{ "premiumFeaturesApi", PremiumFeaturesApiUrl },
			{ "presenceApi", PresenceApiUrl },
			{ "publishApi", PublishApiUrl },
			{ "screenTimeApi", ScreenTimeApiUrl },
			{ "thumbnailsApi", ThumbnailsApiUrl },
			{ "translationRolesApi", TranslationRolesApiUrl },
			{ "universalAppConfigurationApi", UniversalAppConfigurationApiUrl },
			{ "usersApi", UsersApiUrl },
			{ "voiceApi", VoiceApiUrl },
			{ "websiteUrl", WebsiteHttpsUrl }
		};
	}

	[Obsolete("GetApiEndpoint method is deprecated. Use it only if your service still lives on roblox.com domain. If so, then ask to map simulpong and simulprod domains for your service. Use GetInternalApiServiceEndpoint method if your services mapped to simulpong/simulprod.")]
	public static string GetApiEndpoint(string apiServiceName)
	{
		return _InternalApiServicePrefix + apiServiceName + _ApiServiceSuffix;
	}

	public static string GetInternalApiServiceEndpoint(string serviceName)
	{
		return _InternalApiServicePrefix + serviceName + _InternalApiServiceSuffix;
	}
}
