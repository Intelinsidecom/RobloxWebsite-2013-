using System.ComponentModel;

namespace Roblox.Platform.EventStream.WebEvents;

/// <summary>
/// Represents an event's target environment.
///
/// Some represent a specific web source, but others represent a conceptual grouping of event sources.  (e.g. Chat, Avatar)
/// </summary>
/// <remarks>The <see cref="T:System.ComponentModel.DescriptionAttribute" /> will be used as the event target for streaming.</remarks>
public enum EventTarget
{
	[Description("www")]
	Www = 0,
	[Description("apiproxy")]
	ApiProxy = 1,
	[Description("gameInstancesProcessor")]
	GameInstancesProcessor = 2,
	[Description("mobile")]
	MobileApp = 3,
	[Description("studio")]
	Studio = 4,
	[Description("mobileSite")]
	MobileWebsite = 5,
	[Description("gameCounters")]
	GameCounters = 6,
	[Description("diagnostic")]
	Diagnostic = 7,
	[Description("chatSite")]
	ChatSite = 8,
	[Description("eventIngestSite")]
	EventIngestSite = 9,
	[Description("notificationsSite")]
	NotificationsSite = 10,
	[Description("realTimeNotificationsSite")]
	RealTimeNotificationsSite = 11,
	[Description("gamePersistenceSite")]
	GamePersistenceSite = 12,
	[Description("inventoryApi")]
	InventoryApi = 13,
	[Description("avatarApi")]
	AvatarApi = 14,
	[Description("textFilterApi")]
	TextFilterApi = 15,
	[Description("testApi")]
	TestApi = 16,
	[Description("authenticationApi")]
	AuthenticationApi = 17,
	[Description("developApi")]
	DevelopApi = 18,
	[Description("abuseApi")]
	AbuseApi = 19,
	[Description("publishApi")]
	PublishApi = 20,
	[Description("billingApi")]
	BillingApi = 21,
	[Description("avatar")]
	Avatar = 22,
	[Description("groupsApi")]
	GroupsApi = 23,
	[Description("accountSettingsApi")]
	AccountSettingsApi = 24,
	[Description("catalogApi")]
	CatalogApi = 25,
	[Description("presenceApi")]
	PresenceApi = 26,
	[Description("smsService")]
	SmsService = 27,
	[Description("localeApi")]
	LocaleApi = 29,
	[Description("gamesApi")]
	GamesApi = 30,
	[Description("friendsApi")]
	FriendsApi = 31,
	[Description("pointsApi")]
	PointsApi = 32,
	[Description("gameJoinApi")]
	GameJoinApi = 33,
	[Description("thumbnails")]
	Thumbnails = 34,
	[Description("blankEvents")]
	BlankEvents = 35,
	[Description("badgesApi")]
	BadgesApi = 36,
	[Description("cdnProvidersApi")]
	CdnProvidersApi = 37,
	[Description("assetDeliveryApi")]
	AssetDeliveryApi = 38,
	[Description("thumbnailsApi")]
	ThumbnailsApi = 39,
	[Description("clientSettingsApi")]
	ClientSettingsApi = 40,
	[Description("translationsApi")]
	TranslationsApi = 41,
	[Description("abTestingApi")]
	AbTestingApi = 42,
	[Description("followApi")]
	FollowApi = 43,
	[Description("gameInternationalizationApi")]
	GameInternationalizationApi = 44,
	[Description("captchaApi")]
	CaptchaApi = 45,
	[Description("adsApi")]
	AdsApi = 46,
	[Description("surveysApi")]
	SurveysApi = 47,
	[Description("ratingsApi")]
	RatingsApi = 48,
	[Description("premiumFeaturesApi")]
	PremiumFeaturesApi = 49,
	[Description("economyApi")]
	EconomyApi = 50,
	[Description("translationRolesApi")]
	TranslationRolesApi = 51,
	[Description("metricsApi")]
	MetricsApi = 52,
	[Description("midasApi")]
	MidasApi = 53,
	[Description("contactsApi")]
	ContactsApi = 54,
	[Description("discussionsApi")]
	DiscussionsApi = 55,
	[Description("localizationTablesApi")]
	LocalizationTablesApi = 56,
	[Description("voiceApi")]
	VoiceApi = 57,
	[Description("itemConfigurationApi")]
	ItemConfigurationApi = 58,
	[Description("thumbnailsresizerApi")]
	ThumbnailsResizerApi = 59,
	[Description("tradesApi")]
	TradesApi = 60,
	[Description("accountInformationApi")]
	AccountInformationApi = 61,
	[Description("usersApi")]
	UsersApi = 62,
	[Description("C3POApi")]
	C3POApi = 63,
	[Description("engagementPayoutsApi")]
	EngagementPayoutsApi = 64,
	[Description("adminWebsite")]
	AdminWebsite = 65,
	[Description("modWebsite")]
	ModerationWebsite = 66,
	[Description("csWebsite")]
	CustomerServiceWebsite = 67,
	[Description("logoutFromAllSessionsProcessor")]
	LogoutFromAllSessionsProcessor = 68
}
