using System;
using Roblox.TranslationResources.Feature;

namespace Roblox.TranslationResources;

internal class FeatureResources : IFeatureResources, ITranslationResourcesNamespacesGroup
{
	private readonly Lazy<IAccountSettingsResources> _IAccountSettingsResources;

	private readonly Lazy<IAvatarResources> _IAvatarResources;

	private readonly Lazy<IBuildersClubResources> _IBuildersClubResources;

	private readonly Lazy<IBuildersClubExpiringModalResources> _IBuildersClubExpiringModalResources;

	private readonly Lazy<IBuildersClubPageResources> _IBuildersClubPageResources;

	private readonly Lazy<IBuildersClubPanelResources> _IBuildersClubPanelResources;

	private readonly Lazy<ICashOutResources> _ICashOutResources;

	private readonly Lazy<ICatalogResources> _ICatalogResources;

	private readonly Lazy<IChatResources> _IChatResources;

	private readonly Lazy<IChinaPaymentResources> _IChinaPaymentResources;

	private readonly Lazy<ICommentsResources> _ICommentsResources;

	private readonly Lazy<IContactUpsellResources> _IContactUpsellResources;

	private readonly Lazy<ICreatePlaceProductPromotionResources> _ICreatePlaceProductPromotionResources;

	private readonly Lazy<ICreditCardExpiringModalResources> _ICreditCardExpiringModalResources;

	private readonly Lazy<ICrowdSourcedTranslationResources> _ICrowdSourcedTranslationResources;

	private readonly Lazy<IDevelopLandingResources> _IDevelopLandingResources;

	private readonly Lazy<IDevexCashOutResources> _IDevexCashOutResources;

	private readonly Lazy<IDevExHomeResources> _IDevExHomeResources;

	private readonly Lazy<IDownloadAppResources> _IDownloadAppResources;

	private readonly Lazy<IEmailConfirmationResources> _IEmailConfirmationResources;

	private readonly Lazy<IEngagementPayoutResources> _IEngagementPayoutResources;

	private readonly Lazy<IFavoritesResources> _IFavoritesResources;

	private readonly Lazy<IFeedResources> _IFeedResources;

	private readonly Lazy<IFeedsResources> _IFeedsResources;

	private readonly Lazy<IFileUploadComponentResources> _IFileUploadComponentResources;

	private readonly Lazy<IFriendsResources> _IFriendsResources;

	private readonly Lazy<IGameBadgesResources> _IGameBadgesResources;

	private readonly Lazy<IGameContextMenuResources> _IGameContextMenuResources;

	private readonly Lazy<IGameDetailsResources> _IGameDetailsResources;

	private readonly Lazy<IGameFollowsResources> _IGameFollowsResources;

	private readonly Lazy<IGameGearResources> _IGameGearResources;

	private readonly Lazy<IGameGearOptionsDisplayResources> _IGameGearOptionsDisplayResources;

	private readonly Lazy<IGameLanguagesResources> _IGameLanguagesResources;

	private readonly Lazy<IGameLaunchGuestModeResources> _IGameLaunchGuestModeResources;

	private readonly Lazy<IGameLeaderboardResources> _IGameLeaderboardResources;

	private readonly Lazy<IGameLocalizationResources> _IGameLocalizationResources;

	private readonly Lazy<IGamePageResources> _IGamePageResources;

	private readonly Lazy<IGamePassResources> _IGamePassResources;

	private readonly Lazy<IGroupsResources> _IGroupsResources;

	private readonly Lazy<IHomeResources> _IHomeResources;

	private readonly Lazy<IInventoryResources> _IInventoryResources;

	private readonly Lazy<IItemResources> _IItemResources;

	private readonly Lazy<IItemConfigurationResources> _IItemConfigurationResources;

	private readonly Lazy<IItemModelResources> _IItemModelResources;

	private readonly Lazy<ILandingResources> _ILandingResources;

	private readonly Lazy<IMessagesResources> _IMessagesResources;

	private readonly Lazy<IPaymentResources> _IPaymentResources;

	private readonly Lazy<IPeopleListResources> _IPeopleListResources;

	private readonly Lazy<IPlacesListResources> _IPlacesListResources;

	private readonly Lazy<IPlaceThumbnailsResources> _IPlaceThumbnailsResources;

	private readonly Lazy<IPlayerSearchResultsResources> _IPlayerSearchResultsResources;

	private readonly Lazy<IPluginsResources> _IPluginsResources;

	private readonly Lazy<IPremiumResources> _IPremiumResources;

	private readonly Lazy<IPremiumMigrationResources> _IPremiumMigrationResources;

	private readonly Lazy<IPremiumMigrationWebResources> _IPremiumMigrationWebResources;

	private readonly Lazy<IPrivateSalesResources> _IPrivateSalesResources;

	private readonly Lazy<IPrivateServersResources> _IPrivateServersResources;

	private readonly Lazy<IProfileResources> _IProfileResources;

	private readonly Lazy<IPromotedChannelsResources> _IPromotedChannelsResources;

	private readonly Lazy<IPromotedProductResources> _IPromotedProductResources;

	private readonly Lazy<IRecommendationsResources> _IRecommendationsResources;

	private readonly Lazy<IRedeemToyResources> _IRedeemToyResources;

	private readonly Lazy<IReportAbuseResources> _IReportAbuseResources;

	private readonly Lazy<IRobloxCreditResources> _IRobloxCreditResources;

	private readonly Lazy<IServerListResources> _IServerListResources;

	private readonly Lazy<IShopDialogResources> _IShopDialogResources;

	private readonly Lazy<ISocialMetaTagsResources> _ISocialMetaTagsResources;

	private readonly Lazy<ISocialShareResources> _ISocialShareResources;

	private readonly Lazy<ISourceLanguageResources> _ISourceLanguageResources;

	private readonly Lazy<ISupportResources> _ISupportResources;

	private readonly Lazy<ISupportedLanguagesResources> _ISupportedLanguagesResources;

	private readonly Lazy<ISurveysGameRatingsResources> _ISurveysGameRatingsResources;

	private readonly Lazy<ITranslationAnalyticsResources> _ITranslationAnalyticsResources;

	private readonly Lazy<ITranslationLanguageSwitchResources> _ITranslationLanguageSwitchResources;

	private readonly Lazy<ITranslationManagementResources> _ITranslationManagementResources;

	private readonly Lazy<ITranslationRolesResources> _ITranslationRolesResources;

	private readonly Lazy<ITranslatorPortalResources> _ITranslatorPortalResources;

	private readonly Lazy<IVIPServerResources> _IVIPServerResources;

	private readonly Lazy<IVotingPanelResources> _IVotingPanelResources;

	public IAccountSettingsResources AccountSettings => _IAccountSettingsResources.Value;

	public IAvatarResources Avatar => _IAvatarResources.Value;

	public IBuildersClubResources BuildersClub => _IBuildersClubResources.Value;

	public IBuildersClubExpiringModalResources BuildersClubExpiringModal => _IBuildersClubExpiringModalResources.Value;

	public IBuildersClubPageResources BuildersClubPage => _IBuildersClubPageResources.Value;

	public IBuildersClubPanelResources BuildersClubPanel => _IBuildersClubPanelResources.Value;

	public ICashOutResources CashOut => _ICashOutResources.Value;

	public ICatalogResources Catalog => _ICatalogResources.Value;

	public IChatResources Chat => _IChatResources.Value;

	public IChinaPaymentResources ChinaPayment => _IChinaPaymentResources.Value;

	public ICommentsResources Comments => _ICommentsResources.Value;

	public IContactUpsellResources ContactUpsell => _IContactUpsellResources.Value;

	public ICreatePlaceProductPromotionResources CreatePlaceProductPromotion => _ICreatePlaceProductPromotionResources.Value;

	public ICreditCardExpiringModalResources CreditCardExpiringModal => _ICreditCardExpiringModalResources.Value;

	public ICrowdSourcedTranslationResources CrowdSourcedTranslation => _ICrowdSourcedTranslationResources.Value;

	public IDevelopLandingResources DevelopLanding => _IDevelopLandingResources.Value;

	public IDevexCashOutResources DevexCashOut => _IDevexCashOutResources.Value;

	public IDevExHomeResources DevExHome => _IDevExHomeResources.Value;

	public IDownloadAppResources DownloadApp => _IDownloadAppResources.Value;

	public IEmailConfirmationResources EmailConfirmation => _IEmailConfirmationResources.Value;

	public IEngagementPayoutResources EngagementPayout => _IEngagementPayoutResources.Value;

	public IFavoritesResources Favorites => _IFavoritesResources.Value;

	public IFeedResources Feed => _IFeedResources.Value;

	public IFeedsResources Feeds => _IFeedsResources.Value;

	public IFileUploadComponentResources FileUploadComponent => _IFileUploadComponentResources.Value;

	public IFriendsResources Friends => _IFriendsResources.Value;

	public IGameBadgesResources GameBadges => _IGameBadgesResources.Value;

	public IGameContextMenuResources GameContextMenu => _IGameContextMenuResources.Value;

	public IGameDetailsResources GameDetails => _IGameDetailsResources.Value;

	public IGameFollowsResources GameFollows => _IGameFollowsResources.Value;

	public IGameGearResources GameGear => _IGameGearResources.Value;

	public IGameGearOptionsDisplayResources GameGearOptionsDisplay => _IGameGearOptionsDisplayResources.Value;

	public IGameLanguagesResources GameLanguages => _IGameLanguagesResources.Value;

	public IGameLaunchGuestModeResources GameLaunchGuestMode => _IGameLaunchGuestModeResources.Value;

	public IGameLeaderboardResources GameLeaderboard => _IGameLeaderboardResources.Value;

	public IGameLocalizationResources GameLocalization => _IGameLocalizationResources.Value;

	public IGamePageResources GamePage => _IGamePageResources.Value;

	public IGamePassResources GamePass => _IGamePassResources.Value;

	public IGroupsResources Groups => _IGroupsResources.Value;

	public IHomeResources Home => _IHomeResources.Value;

	public IInventoryResources Inventory => _IInventoryResources.Value;

	public IItemResources Item => _IItemResources.Value;

	public IItemConfigurationResources ItemConfiguration => _IItemConfigurationResources.Value;

	public IItemModelResources ItemModel => _IItemModelResources.Value;

	public ILandingResources Landing => _ILandingResources.Value;

	public IMessagesResources Messages => _IMessagesResources.Value;

	public IPaymentResources Payment => _IPaymentResources.Value;

	public IPeopleListResources PeopleList => _IPeopleListResources.Value;

	public IPlacesListResources PlacesList => _IPlacesListResources.Value;

	public IPlaceThumbnailsResources PlaceThumbnails => _IPlaceThumbnailsResources.Value;

	public IPlayerSearchResultsResources PlayerSearchResults => _IPlayerSearchResultsResources.Value;

	public IPluginsResources Plugins => _IPluginsResources.Value;

	public IPremiumResources Premium => _IPremiumResources.Value;

	public IPremiumMigrationResources PremiumMigration => _IPremiumMigrationResources.Value;

	public IPremiumMigrationWebResources PremiumMigrationWeb => _IPremiumMigrationWebResources.Value;

	public IPrivateSalesResources PrivateSales => _IPrivateSalesResources.Value;

	public IPrivateServersResources PrivateServers => _IPrivateServersResources.Value;

	public IProfileResources Profile => _IProfileResources.Value;

	public IPromotedChannelsResources PromotedChannels => _IPromotedChannelsResources.Value;

	public IPromotedProductResources PromotedProduct => _IPromotedProductResources.Value;

	public IRecommendationsResources Recommendations => _IRecommendationsResources.Value;

	public IRedeemToyResources RedeemToy => _IRedeemToyResources.Value;

	public IReportAbuseResources ReportAbuse => _IReportAbuseResources.Value;

	public IRobloxCreditResources RobloxCredit => _IRobloxCreditResources.Value;

	public IServerListResources ServerList => _IServerListResources.Value;

	public IShopDialogResources ShopDialog => _IShopDialogResources.Value;

	public ISocialMetaTagsResources SocialMetaTags => _ISocialMetaTagsResources.Value;

	public ISocialShareResources SocialShare => _ISocialShareResources.Value;

	public ISourceLanguageResources SourceLanguage => _ISourceLanguageResources.Value;

	public ISupportResources Support => _ISupportResources.Value;

	public ISupportedLanguagesResources SupportedLanguages => _ISupportedLanguagesResources.Value;

	public ISurveysGameRatingsResources SurveysGameRatings => _ISurveysGameRatingsResources.Value;

	public ITranslationAnalyticsResources TranslationAnalytics => _ITranslationAnalyticsResources.Value;

	public ITranslationLanguageSwitchResources TranslationLanguageSwitch => _ITranslationLanguageSwitchResources.Value;

	public ITranslationManagementResources TranslationManagement => _ITranslationManagementResources.Value;

	public ITranslationRolesResources TranslationRoles => _ITranslationRolesResources.Value;

	public ITranslatorPortalResources TranslatorPortal => _ITranslatorPortalResources.Value;

	public IVIPServerResources VIPServer => _IVIPServerResources.Value;

	public IVotingPanelResources VotingPanel => _IVotingPanelResources.Value;

	public FeatureResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		_IAccountSettingsResources = new Lazy<IAccountSettingsResources>(() => AccountSettingsResourceFactory.GetResources(locale, state));
		_IAvatarResources = new Lazy<IAvatarResources>(() => AvatarResourceFactory.GetResources(locale, state));
		_IBuildersClubResources = new Lazy<IBuildersClubResources>(() => BuildersClubResourceFactory.GetResources(locale, state));
		_IBuildersClubExpiringModalResources = new Lazy<IBuildersClubExpiringModalResources>(() => BuildersClubExpiringModalResourceFactory.GetResources(locale, state));
		_IBuildersClubPageResources = new Lazy<IBuildersClubPageResources>(() => BuildersClubPageResourceFactory.GetResources(locale, state));
		_IBuildersClubPanelResources = new Lazy<IBuildersClubPanelResources>(() => BuildersClubPanelResourceFactory.GetResources(locale, state));
		_ICashOutResources = new Lazy<ICashOutResources>(() => CashOutResourceFactory.GetResources(locale, state));
		_ICatalogResources = new Lazy<ICatalogResources>(() => CatalogResourceFactory.GetResources(locale, state));
		_IChatResources = new Lazy<IChatResources>(() => ChatResourceFactory.GetResources(locale, state));
		_IChinaPaymentResources = new Lazy<IChinaPaymentResources>(() => ChinaPaymentResourceFactory.GetResources(locale, state));
		_ICommentsResources = new Lazy<ICommentsResources>(() => CommentsResourceFactory.GetResources(locale, state));
		_IContactUpsellResources = new Lazy<IContactUpsellResources>(() => ContactUpsellResourceFactory.GetResources(locale, state));
		_ICreatePlaceProductPromotionResources = new Lazy<ICreatePlaceProductPromotionResources>(() => CreatePlaceProductPromotionResourceFactory.GetResources(locale, state));
		_ICreditCardExpiringModalResources = new Lazy<ICreditCardExpiringModalResources>(() => CreditCardExpiringModalResourceFactory.GetResources(locale, state));
		_ICrowdSourcedTranslationResources = new Lazy<ICrowdSourcedTranslationResources>(() => CrowdSourcedTranslationResourceFactory.GetResources(locale, state));
		_IDevelopLandingResources = new Lazy<IDevelopLandingResources>(() => DevelopLandingResourceFactory.GetResources(locale, state));
		_IDevexCashOutResources = new Lazy<IDevexCashOutResources>(() => DevexCashOutResourceFactory.GetResources(locale, state));
		_IDevExHomeResources = new Lazy<IDevExHomeResources>(() => DevExHomeResourceFactory.GetResources(locale, state));
		_IDownloadAppResources = new Lazy<IDownloadAppResources>(() => DownloadAppResourceFactory.GetResources(locale, state));
		_IEmailConfirmationResources = new Lazy<IEmailConfirmationResources>(() => EmailConfirmationResourceFactory.GetResources(locale, state));
		_IEngagementPayoutResources = new Lazy<IEngagementPayoutResources>(() => EngagementPayoutResourceFactory.GetResources(locale, state));
		_IFavoritesResources = new Lazy<IFavoritesResources>(() => FavoritesResourceFactory.GetResources(locale, state));
		_IFeedResources = new Lazy<IFeedResources>(() => FeedResourceFactory.GetResources(locale, state));
		_IFeedsResources = new Lazy<IFeedsResources>(() => FeedsResourceFactory.GetResources(locale, state));
		_IFileUploadComponentResources = new Lazy<IFileUploadComponentResources>(() => FileUploadComponentResourceFactory.GetResources(locale, state));
		_IFriendsResources = new Lazy<IFriendsResources>(() => FriendsResourceFactory.GetResources(locale, state));
		_IGameBadgesResources = new Lazy<IGameBadgesResources>(() => GameBadgesResourceFactory.GetResources(locale, state));
		_IGameContextMenuResources = new Lazy<IGameContextMenuResources>(() => GameContextMenuResourceFactory.GetResources(locale, state));
		_IGameDetailsResources = new Lazy<IGameDetailsResources>(() => GameDetailsResourceFactory.GetResources(locale, state));
		_IGameFollowsResources = new Lazy<IGameFollowsResources>(() => GameFollowsResourceFactory.GetResources(locale, state));
		_IGameGearResources = new Lazy<IGameGearResources>(() => GameGearResourceFactory.GetResources(locale, state));
		_IGameGearOptionsDisplayResources = new Lazy<IGameGearOptionsDisplayResources>(() => GameGearOptionsDisplayResourceFactory.GetResources(locale, state));
		_IGameLanguagesResources = new Lazy<IGameLanguagesResources>(() => GameLanguagesResourceFactory.GetResources(locale, state));
		_IGameLaunchGuestModeResources = new Lazy<IGameLaunchGuestModeResources>(() => GameLaunchGuestModeResourceFactory.GetResources(locale, state));
		_IGameLeaderboardResources = new Lazy<IGameLeaderboardResources>(() => GameLeaderboardResourceFactory.GetResources(locale, state));
		_IGameLocalizationResources = new Lazy<IGameLocalizationResources>(() => GameLocalizationResourceFactory.GetResources(locale, state));
		_IGamePageResources = new Lazy<IGamePageResources>(() => GamePageResourceFactory.GetResources(locale, state));
		_IGamePassResources = new Lazy<IGamePassResources>(() => GamePassResourceFactory.GetResources(locale, state));
		_IGroupsResources = new Lazy<IGroupsResources>(() => GroupsResourceFactory.GetResources(locale, state));
		_IHomeResources = new Lazy<IHomeResources>(() => HomeResourceFactory.GetResources(locale, state));
		_IInventoryResources = new Lazy<IInventoryResources>(() => InventoryResourceFactory.GetResources(locale, state));
		_IItemResources = new Lazy<IItemResources>(() => ItemResourceFactory.GetResources(locale, state));
		_IItemConfigurationResources = new Lazy<IItemConfigurationResources>(() => ItemConfigurationResourceFactory.GetResources(locale, state));
		_IItemModelResources = new Lazy<IItemModelResources>(() => ItemModelResourceFactory.GetResources(locale, state));
		_ILandingResources = new Lazy<ILandingResources>(() => LandingResourceFactory.GetResources(locale, state));
		_IMessagesResources = new Lazy<IMessagesResources>(() => MessagesResourceFactory.GetResources(locale, state));
		_IPaymentResources = new Lazy<IPaymentResources>(() => PaymentResourceFactory.GetResources(locale, state));
		_IPeopleListResources = new Lazy<IPeopleListResources>(() => PeopleListResourceFactory.GetResources(locale, state));
		_IPlacesListResources = new Lazy<IPlacesListResources>(() => PlacesListResourceFactory.GetResources(locale, state));
		_IPlaceThumbnailsResources = new Lazy<IPlaceThumbnailsResources>(() => PlaceThumbnailsResourceFactory.GetResources(locale, state));
		_IPlayerSearchResultsResources = new Lazy<IPlayerSearchResultsResources>(() => PlayerSearchResultsResourceFactory.GetResources(locale, state));
		_IPluginsResources = new Lazy<IPluginsResources>(() => PluginsResourceFactory.GetResources(locale, state));
		_IPremiumResources = new Lazy<IPremiumResources>(() => PremiumResourceFactory.GetResources(locale, state));
		_IPremiumMigrationResources = new Lazy<IPremiumMigrationResources>(() => PremiumMigrationResourceFactory.GetResources(locale, state));
		_IPremiumMigrationWebResources = new Lazy<IPremiumMigrationWebResources>(() => PremiumMigrationWebResourceFactory.GetResources(locale, state));
		_IPrivateSalesResources = new Lazy<IPrivateSalesResources>(() => PrivateSalesResourceFactory.GetResources(locale, state));
		_IPrivateServersResources = new Lazy<IPrivateServersResources>(() => PrivateServersResourceFactory.GetResources(locale, state));
		_IProfileResources = new Lazy<IProfileResources>(() => ProfileResourceFactory.GetResources(locale, state));
		_IPromotedChannelsResources = new Lazy<IPromotedChannelsResources>(() => PromotedChannelsResourceFactory.GetResources(locale, state));
		_IPromotedProductResources = new Lazy<IPromotedProductResources>(() => PromotedProductResourceFactory.GetResources(locale, state));
		_IRecommendationsResources = new Lazy<IRecommendationsResources>(() => RecommendationsResourceFactory.GetResources(locale, state));
		_IRedeemToyResources = new Lazy<IRedeemToyResources>(() => RedeemToyResourceFactory.GetResources(locale, state));
		_IReportAbuseResources = new Lazy<IReportAbuseResources>(() => ReportAbuseResourceFactory.GetResources(locale, state));
		_IRobloxCreditResources = new Lazy<IRobloxCreditResources>(() => RobloxCreditResourceFactory.GetResources(locale, state));
		_IServerListResources = new Lazy<IServerListResources>(() => ServerListResourceFactory.GetResources(locale, state));
		_IShopDialogResources = new Lazy<IShopDialogResources>(() => ShopDialogResourceFactory.GetResources(locale, state));
		_ISocialMetaTagsResources = new Lazy<ISocialMetaTagsResources>(() => SocialMetaTagsResourceFactory.GetResources(locale, state));
		_ISocialShareResources = new Lazy<ISocialShareResources>(() => SocialShareResourceFactory.GetResources(locale, state));
		_ISourceLanguageResources = new Lazy<ISourceLanguageResources>(() => SourceLanguageResourceFactory.GetResources(locale, state));
		_ISupportResources = new Lazy<ISupportResources>(() => SupportResourceFactory.GetResources(locale, state));
		_ISupportedLanguagesResources = new Lazy<ISupportedLanguagesResources>(() => SupportedLanguagesResourceFactory.GetResources(locale, state));
		_ISurveysGameRatingsResources = new Lazy<ISurveysGameRatingsResources>(() => SurveysGameRatingsResourceFactory.GetResources(locale, state));
		_ITranslationAnalyticsResources = new Lazy<ITranslationAnalyticsResources>(() => TranslationAnalyticsResourceFactory.GetResources(locale, state));
		_ITranslationLanguageSwitchResources = new Lazy<ITranslationLanguageSwitchResources>(() => TranslationLanguageSwitchResourceFactory.GetResources(locale, state));
		_ITranslationManagementResources = new Lazy<ITranslationManagementResources>(() => TranslationManagementResourceFactory.GetResources(locale, state));
		_ITranslationRolesResources = new Lazy<ITranslationRolesResources>(() => TranslationRolesResourceFactory.GetResources(locale, state));
		_ITranslatorPortalResources = new Lazy<ITranslatorPortalResources>(() => TranslatorPortalResourceFactory.GetResources(locale, state));
		_IVIPServerResources = new Lazy<IVIPServerResources>(() => VIPServerResourceFactory.GetResources(locale, state));
		_IVotingPanelResources = new Lazy<IVotingPanelResources>(() => VotingPanelResourceFactory.GetResources(locale, state));
	}

	public ITranslationResources GetByFullNamespace(string fullTranslationResourceNamespace)
	{
		if (string.IsNullOrWhiteSpace(fullTranslationResourceNamespace))
		{
			throw new ArgumentException("Value cannot be null or whitespace.", "fullTranslationResourceNamespace");
		}
		return fullTranslationResourceNamespace switch
		{
			"Feature.AccountSettings" => AccountSettings, 
			"Feature.Avatar" => Avatar, 
			"Feature.BuildersClub" => BuildersClub, 
			"Feature.BuildersClubExpiringModal" => BuildersClubExpiringModal, 
			"Feature.BuildersClubPage" => BuildersClubPage, 
			"Feature.BuildersClubPanel" => BuildersClubPanel, 
			"Feature.CashOut" => CashOut, 
			"Feature.Catalog" => Catalog, 
			"Feature.Chat" => Chat, 
			"Feature.ChinaPayment" => ChinaPayment, 
			"Feature.Comments" => Comments, 
			"Feature.ContactUpsell" => ContactUpsell, 
			"Feature.CreatePlaceProductPromotion" => CreatePlaceProductPromotion, 
			"Feature.CreditCardExpiringModal" => CreditCardExpiringModal, 
			"Feature.CrowdSourcedTranslation" => CrowdSourcedTranslation, 
			"Feature.DevelopLanding" => DevelopLanding, 
			"Feature.DevexCashOut" => DevexCashOut, 
			"Feature.DevExHome" => DevExHome, 
			"Feature.DownloadApp" => DownloadApp, 
			"Feature.EmailConfirmation" => EmailConfirmation, 
			"Feature.EngagementPayout" => EngagementPayout, 
			"Feature.Favorites" => Favorites, 
			"Feature.Feed" => Feed, 
			"Feature.Feeds" => Feeds, 
			"Feature.FileUploadComponent" => FileUploadComponent, 
			"Feature.Friends" => Friends, 
			"Feature.GameBadges" => GameBadges, 
			"Feature.GameContextMenu" => GameContextMenu, 
			"Feature.GameDetails" => GameDetails, 
			"Feature.GameFollows" => GameFollows, 
			"Feature.GameGear" => GameGear, 
			"Feature.GameGearOptionsDisplay" => GameGearOptionsDisplay, 
			"Feature.GameLanguages" => GameLanguages, 
			"Feature.GameLaunchGuestMode" => GameLaunchGuestMode, 
			"Feature.GameLeaderboard" => GameLeaderboard, 
			"Feature.GameLocalization" => GameLocalization, 
			"Feature.GamePage" => GamePage, 
			"Feature.GamePass" => GamePass, 
			"Feature.Groups" => Groups, 
			"Feature.Home" => Home, 
			"Feature.Inventory" => Inventory, 
			"Feature.Item" => Item, 
			"Feature.ItemConfiguration" => ItemConfiguration, 
			"Feature.ItemModel" => ItemModel, 
			"Feature.Landing" => Landing, 
			"Feature.Messages" => Messages, 
			"Feature.Payment" => Payment, 
			"Feature.PeopleList" => PeopleList, 
			"Feature.PlacesList" => PlacesList, 
			"Feature.PlaceThumbnails" => PlaceThumbnails, 
			"Feature.PlayerSearchResults" => PlayerSearchResults, 
			"Feature.Plugins" => Plugins, 
			"Feature.Premium" => Premium, 
			"Feature.PremiumMigration" => PremiumMigration, 
			"Feature.PremiumMigrationWeb" => PremiumMigrationWeb, 
			"Feature.PrivateSales" => PrivateSales, 
			"Feature.PrivateServers" => PrivateServers, 
			"Feature.Profile" => Profile, 
			"Feature.PromotedChannels" => PromotedChannels, 
			"Feature.PromotedProduct" => PromotedProduct, 
			"Feature.Recommendations" => Recommendations, 
			"Feature.RedeemToy" => RedeemToy, 
			"Feature.ReportAbuse" => ReportAbuse, 
			"Feature.RobloxCredit" => RobloxCredit, 
			"Feature.ServerList" => ServerList, 
			"Feature.ShopDialog" => ShopDialog, 
			"Feature.SocialMetaTags" => SocialMetaTags, 
			"Feature.SocialShare" => SocialShare, 
			"Feature.SourceLanguage" => SourceLanguage, 
			"Feature.Support" => Support, 
			"Feature.SupportedLanguages" => SupportedLanguages, 
			"Feature.SurveysGameRatings" => SurveysGameRatings, 
			"Feature.TranslationAnalytics" => TranslationAnalytics, 
			"Feature.TranslationLanguageSwitch" => TranslationLanguageSwitch, 
			"Feature.TranslationManagement" => TranslationManagement, 
			"Feature.TranslationRoles" => TranslationRoles, 
			"Feature.TranslatorPortal" => TranslatorPortal, 
			"Feature.VIPServer" => VIPServer, 
			"Feature.VotingPanel" => VotingPanel, 
			_ => null, 
		};
	}
}
