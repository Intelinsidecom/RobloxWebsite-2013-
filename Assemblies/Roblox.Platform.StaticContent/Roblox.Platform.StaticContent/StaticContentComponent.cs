namespace Roblox.Platform.StaticContent;

/// <summary>
/// All known components that can be used with static content.
/// </summary>
public enum StaticContentComponent
{
	/// <summary>
	/// Nickname component 
	/// </summary>
	Aliases,
	/// <summary>
	/// AngularJS Utilities scripts such as filters, directives, services
	/// </summary>
	AngularJsUtilities,
	/// <summary>
	/// The public Api documentation page.
	/// </summary>
	ApiDocumentation,
	/// <summary>
	/// Component for the webview used to display captcha in-app.
	/// </summary>
	AppCaptcha,
	/// <summary>
	/// The avatar page.
	/// </summary>
	Avatar,
	/// <summary>
	/// Upsell page on mobile browser to install app.
	/// </summary>
	AvatarUpsell,
	/// <summary>
	/// Captcha component(s.)
	/// </summary>
	Captcha,
	/// <summary>
	/// CashOut Robux via devex component
	/// </summary>
	CashOut,
	/// <summary>
	/// Catalog page for desktop, tablet
	/// </summary>
	Catalog,
	/// <summary>
	/// Web Chat
	/// </summary>
	Chat,
	/// <summary>
	/// The configure group page.
	/// </summary>
	ConfigureGroup,
	/// <summary>
	/// The configure localization page.
	/// </summary>
	ConfigureLocalization,
	/// <summary>
	/// Website cookie banner
	/// </summary>
	CookieBanner,
	/// <summary>
	/// Core ES6 utilities, without external dependencies.
	/// </summary>
	CoreUtilities,
	/// <summary>
	/// Core Roblox ES6 utilities, with external dependencies on WWW's window.Roblox.
	/// </summary>
	CoreRobloxUtilities,
	/// <summary>
	/// The create group page.
	/// </summary>
	CreateGroup,
	/// <summary>
	/// The create item page.
	/// </summary>
	CreateItem,
	/// <summary>
	/// scripts for cross tab election 
	/// </summary>
	CrossTabCommunication,
	/// <summary>
	/// cursor pagination widget
	/// </summary>
	CursorPagination,
	/// <summary>
	/// The engagement based payout page
	/// </summary>
	EngagementPayout,
	/// <summary>
	/// The favorites page.
	/// </summary>
	Favorites,
	/// <summary>
	/// The file upload UI component
	/// </summary>
	FileUpload,
	/// <summary>
	/// the component at the bottom of page 
	/// </summary>
	Footer,
	/// <summary>
	/// The Forgot Password and Username page
	/// </summary>
	ForgotCredentials,
	/// <summary>
	/// Friends page
	/// </summary>
	Friends,
	/// <summary>
	/// All Game Launch related code.
	/// </summary>
	GameLaunch,
	/// <summary>
	/// The groups details page.
	/// </summary>
	GroupDetails,
	/// <summary>
	/// The group search page
	/// </summary>
	GroupSearch,
	/// <summary>
	/// The groups list page.
	/// </summary>
	GroupsList,
	/// <summary>
	/// The GUAC lives on Admin Site.
	/// </summary>
	GUAC,
	/// <summary>
	/// Interactive text filter scripts.
	/// </summary>
	Hinteractive,
	/// <summary>
	/// International utilities for AngularJs, i.e. languageResourceProvider
	/// </summary>
	InternationalAngularJs,
	/// <summary>
	/// International Core library, i.e. Roblox.Intl
	/// </summary>
	InternationalCore,
	/// <summary>
	/// The inventory page.
	/// </summary>
	Inventory,
	/// <summary>
	/// The item configuration page.
	/// </summary>
	ItemConfiguration,
	/// <summary>
	/// The item manifold components.
	/// </summary>
	ItemManifolds,
	/// <summary>
	/// Item resale modules.
	/// </summary>
	ItemResale,
	/// <summary>
	/// Jquery libraries and core scripts
	/// </summary>
	JQuery,
	/// <summary>
	/// The real landing page.
	/// </summary>
	Landing,
	/// <summary>
	/// The landing page.
	/// </summary>
	LandingPage,
	/// <summary>
	/// Roblox style definition for legacy page
	/// </summary>
	/// <remarks>
	/// e.g. font, color, buttons etc
	/// </remarks>
	LegacyStyleGuide,
	/// <summary>
	/// The load testing app.
	/// </summary>
	LoadTesting,
	/// <summary>
	/// The Localization page.
	/// </summary>
	Localization,
	/// <summary>
	/// Login components.
	/// </summary>
	/// <remarks>
	/// Page, widget, etc.
	/// </remarks>
	Login,
	/// <summary>
	/// China MidasPayment page
	/// </summary>
	MidasPayment,
	/// <summary>
	/// Premium migration modal
	/// </summary>
	MembershipMigration,
	/// <summary>
	/// Left navigation, header
	/// </summary>
	Navigation,
	/// <summary>
	/// Notification Stream at navigation bar
	/// </summary>
	NotificationStream,
	/// <summary>
	/// Notification Stream Embedded page inapp
	/// </summary>
	NotificationStreamEmbedded,
	/// <summary>
	/// Roblox Premium related component
	/// </summary>
	Premium,
	/// <summary>
	/// Friends list component
	/// </summary>
	PeopleList,
	/// <summary>
	/// React core libraries
	/// </summary>
	React,
	/// <summary>
	/// React Common UI Components
	/// </summary>
	ReactStyleGuide,
	/// <summary>
	/// React specific utilities
	/// </summary>
	ReactUtilities,
	/// <summary>
	/// Signal R notification and library
	/// </summary>
	RealTime,
	/// <summary>
	/// Catalog item recommendations
	/// </summary>
	Recommendations,
	/// <summary>
	/// Internal browser for item recommendations
	/// </summary>
	RecommendationsBrowser,
	/// <summary>
	/// Roblox Credit component
	/// </summary>
	RobloxCredit,
	/// <summary>
	/// Premium Robux page
	/// </summary>
	Robux,
	/// <summary>
	/// Robux Icon
	/// </summary>
	RobuxIcon,
	/// <summary>
	/// Games list for home page
	/// </summary>
	PlacesList,
	/// <summary>
	/// Reset Password
	/// </summary>
	ResetPassword,
	/// <summary>
	/// Return to Studio
	/// </summary>
	ReturnToStudio,
	/// <summary>
	/// Revert Account
	/// </summary>
	RevertAccount,
	/// <summary>
	/// Rules components
	/// </summary>
	Rules,
	/// <summary>
	///  Saml error
	///  </summary>
	SamlError,
	/// <summary>
	///  Sentry
	///  </summary>
	Sentry,
	/// <summary>
	///  Signup
	///  </summary>
	Signup,
	/// <summary>
	/// The configuration component for social links.
	/// </summary>
	SocialLinksConfiguration,
	/// <summary>
	/// The primary display component for social links.
	/// </summary>
	SocialLinksJumbotron,
	/// <summary>
	/// Roblox style definition
	/// </summary>
	/// <remarks>
	/// e.g. font, color, buttons etc
	/// </remarks>
	StyleGuide,
	/// <summary>
	/// Style Guide Reference Page (style guide page style)
	/// </summary>
	/// <remarks>
	/// e.g. font, color, buttons etc
	/// </remarks>
	StyleGuideReference,
	/// <summary>
	/// Roblox Premium membership page
	/// </summary>
	Subscription,
	/// <summary>
	/// System Feedback UI element
	/// </summary>
	SystemFeedback,
	/// <summary>
	/// Tencent Authentication components
	/// </summary>
	TencentAuth,
	/// <summary>
	/// Thumbnailing components.
	/// </summary>
	/// <remarks>
	/// e.g. Avatar headshots, asset thumbnails, badge icons, etc.
	/// </remarks>
	Thumbnails,
	/// <summary>
	/// TranslationResourceProvider utility class
	/// </summary>
	TranslationResources,
	/// <summary>
	/// The translation management app component
	/// </summary>
	TranslationManagement,
	/// <summary>
	/// Translator Portal main page
	/// </summary>
	TranslatorPortal,
	/// <summary>
	/// The two step verification page.
	/// </summary>
	TwoStepVerification,
	/// <summary>
	/// Voice chat testing page
	/// </summary>
	VoiceTest,
	/// <summary>
	/// email verification page.
	/// </summary>
	VerifyEmail,
	/// <summary>
	/// WeChat login.
	/// </summary>
	WeChat
}
