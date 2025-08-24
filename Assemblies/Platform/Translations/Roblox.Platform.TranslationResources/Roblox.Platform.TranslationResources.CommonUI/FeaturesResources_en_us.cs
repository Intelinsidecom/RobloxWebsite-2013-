using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.CommonUI;

internal class FeaturesResources_en_us : TranslationResourcesBase, IFeaturesResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "Action.BackToTop"
	/// English String: "Back To Top"
	/// </summary>
	public virtual string ActionBackToTop => "Back To Top";

	/// <summary>
	/// Key: "Action.BuyAccess"
	/// Purchase access to the place button
	/// English String: "Buy Access"
	/// </summary>
	public virtual string ActionBuyAccess => "Buy Access";

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public virtual string ActionCancel => "Cancel";

	/// <summary>
	/// Key: "Action.Ok"
	/// English String: "Ok"
	/// </summary>
	public virtual string ActionOk => "Ok";

	/// <summary>
	/// Key: "Action.sUpgradeNow"
	/// English String: "Upgrade Now"
	/// </summary>
	public virtual string ActionsUpgradeNow => "Upgrade Now";

	/// <summary>
	/// Key: "Description.CopyRightMessage"
	/// Copyright message at the bottom of the website
	/// English String: "©2018 Roblox Corporation. Roblox, the Roblox logo and Powering Imagination are among our registered and unregistered trademarks in the U.S. and other countries."
	/// </summary>
	public virtual string DescriptionCopyRightMessage => "©2018 Roblox Corporation. Roblox, the Roblox logo and Powering Imagination are among our registered and unregistered trademarks in the U.S. and other countries.";

	/// <summary>
	/// Key: "Description.UnsupportedLanguage"
	/// English String: "While some games may use the selected language, it is not fully supported by roblox.com."
	/// </summary>
	public virtual string DescriptionUnsupportedLanguage => "While some games may use the selected language, it is not fully supported by roblox.com.";

	/// <summary>
	/// Key: "Heading.BuyItem"
	/// Purchase access to the place
	/// English String: "Buy Item"
	/// </summary>
	public virtual string HeadingBuyItem => "Buy Item";

	/// <summary>
	/// Key: "Heading.UnsupportedLanguage"
	/// English String: "Unsupported Language"
	/// </summary>
	public virtual string HeadingUnsupportedLanguage => "Unsupported Language";

	/// <summary>
	/// Key: "Label.AboutUs"
	/// English String: "About Us"
	/// </summary>
	public virtual string LabelAboutUs => "About Us";

	/// <summary>
	/// Key: "Label.AuthenticationError"
	/// page title
	/// English String: "Authentication Error"
	/// </summary>
	public virtual string LabelAuthenticationError => "Authentication Error";

	/// <summary>
	/// Key: "Label.Badges"
	/// page title
	/// English String: "Badges"
	/// </summary>
	public virtual string LabelBadges => "Badges";

	/// <summary>
	/// Key: "Label.Careers"
	/// English String: "Careers"
	/// </summary>
	public virtual string LabelCareers => "Careers";

	/// <summary>
	/// Key: "Label.Configure"
	/// Configure
	/// English String: "Configure"
	/// </summary>
	public virtual string LabelConfigure => "Configure";

	/// <summary>
	/// Key: "Label.ConfigureGame"
	/// configure game page title
	/// English String: "Configure Game"
	/// </summary>
	public virtual string LabelConfigureGame => "Configure Game";

	/// <summary>
	/// Key: "Label.ConfigurePlace"
	/// Configure Place
	/// English String: "Configure Place"
	/// </summary>
	public virtual string LabelConfigurePlace => "Configure Place";

	/// <summary>
	/// Key: "Label.ConfigurePrivateServer"
	/// page title
	/// English String: "Configure VIP Server"
	/// </summary>
	public virtual string LabelConfigurePrivateServer => "Configure VIP Server";

	/// <summary>
	/// Key: "Label.ContactUs"
	/// page title
	/// English String: "Contact Us"
	/// </summary>
	public virtual string LabelContactUs => "Contact Us";

	/// <summary>
	/// Key: "Label.Create"
	/// Alternate name for the "Develop" section of the website
	/// English String: "Create"
	/// </summary>
	public virtual string LabelCreate => "Create";

	/// <summary>
	/// Key: "Label.CreateGame"
	/// Create Game
	/// English String: "Create Game"
	/// </summary>
	public virtual string LabelCreateGame => "Create Game";

	/// <summary>
	/// Key: "Label.CreateGroup"
	/// Create Group
	/// English String: "Create Group"
	/// </summary>
	public virtual string LabelCreateGroup => "Create Group";

	/// <summary>
	/// Key: "Label.Discover"
	/// English String: "Discover"
	/// </summary>
	public virtual string LabelDiscover => "Discover";

	/// <summary>
	/// Key: "Label.Favorites"
	/// Favorites
	/// English String: "Favorites"
	/// </summary>
	public virtual string LabelFavorites => "Favorites";

	/// <summary>
	/// Key: "Label.Feeds"
	/// English String: "My Feed"
	/// </summary>
	public virtual string LabelFeeds => "My Feed";

	/// <summary>
	/// Key: "Label.FindMyFeed"
	/// English String: "Looking for My Feed? It's now in side menu"
	/// </summary>
	public virtual string LabelFindMyFeed => "Looking for My Feed? It's now in side menu";

	/// <summary>
	/// Key: "Label.Help"
	/// English String: "Help"
	/// </summary>
	public virtual string LabelHelp => "Help";

	/// <summary>
	/// Key: "Label.Jobs"
	/// jobs link in footer
	/// English String: "Jobs"
	/// </summary>
	public virtual string LabelJobs => "Jobs";

	/// <summary>
	/// Key: "Label.Library"
	/// search context for inventory search
	/// English String: "Library"
	/// </summary>
	public virtual string LabelLibrary => "Library";

	/// <summary>
	/// Key: "Label.Merch"
	/// English String: "Merchandise"
	/// </summary>
	public virtual string LabelMerch => "Merchandise";

	/// <summary>
	/// Key: "Label.Parents"
	/// English String: "Parents"
	/// </summary>
	public virtual string LabelParents => "Parents";

	/// <summary>
	/// Key: "Label.PlaceStatistics"
	/// page title
	/// English String: "Place Statistics"
	/// </summary>
	public virtual string LabelPlaceStatistics => "Place Statistics";

	/// <summary>
	/// Key: "Label.Players"
	/// search context for user search
	/// English String: "Players"
	/// </summary>
	public virtual string LabelPlayers => "Players";

	/// <summary>
	/// Key: "Label.Privacy"
	/// English String: "Privacy"
	/// </summary>
	public virtual string LabelPrivacy => "Privacy";

	/// <summary>
	/// Key: "Label.RedeemRobloxCards"
	/// page title
	/// English String: "Redeem Roblox Cards"
	/// </summary>
	public virtual string LabelRedeemRobloxCards => "Redeem Roblox Cards";

	/// <summary>
	/// Key: "Label.sAvatar"
	/// English String: "Avatar"
	/// </summary>
	public virtual string LabelsAvatar => "Avatar";

	/// <summary>
	/// Key: "Label.sBlog"
	/// English String: "Blog"
	/// </summary>
	public virtual string LabelsBlog => "Blog";

	/// <summary>
	/// Key: "Label.sCatalog"
	/// English String: "Catalog"
	/// </summary>
	public virtual string LabelsCatalog => "Catalog";

	/// <summary>
	/// Key: "Label.sDevelop"
	/// English String: "Develop"
	/// </summary>
	public virtual string LabelsDevelop => "Develop";

	/// <summary>
	/// Key: "Label.sEvents"
	/// English String: "Events"
	/// </summary>
	public virtual string LabelsEvents => "Events";

	/// <summary>
	/// Key: "Label.sForum"
	/// English String: "Forum"
	/// </summary>
	public virtual string LabelsForum => "Forum";

	/// <summary>
	/// Key: "Label.sFriends"
	/// English String: "Friends"
	/// </summary>
	public virtual string LabelsFriends => "Friends";

	/// <summary>
	/// Key: "Label.sGames"
	/// English String: "Games"
	/// </summary>
	public virtual string LabelsGames => "Games";

	/// <summary>
	/// Key: "Label.sGroups"
	/// English String: "Groups"
	/// </summary>
	public virtual string LabelsGroups => "Groups";

	/// <summary>
	/// Key: "Label.sHome"
	/// English String: "Home"
	/// </summary>
	public virtual string LabelsHome => "Home";

	/// <summary>
	/// Key: "Label.sInventory"
	/// English String: "Inventory"
	/// </summary>
	public virtual string LabelsInventory => "Inventory";

	/// <summary>
	/// Key: "Label.sLogin"
	/// English String: "Log In"
	/// </summary>
	public virtual string LabelsLogin => "Log In";

	/// <summary>
	/// Key: "Label.sMessages"
	/// English String: "Messages"
	/// </summary>
	public virtual string LabelsMessages => "Messages";

	/// <summary>
	/// Key: "Label.sProfile"
	/// English String: "Profile"
	/// </summary>
	public virtual string LabelsProfile => "Profile";

	/// <summary>
	/// Key: "Label.sRobux"
	/// English String: "Robux"
	/// </summary>
	public virtual string LabelsRobux => "Robux";

	/// <summary>
	/// Key: "Label.sSearch"
	/// English String: "Search"
	/// </summary>
	public virtual string LabelsSearch => "Search";

	/// <summary>
	/// Key: "Label.sShop"
	/// English String: "Shop"
	/// </summary>
	public virtual string LabelsShop => "Shop";

	/// <summary>
	/// Key: "Label.sSignUp"
	/// English String: "Sign Up"
	/// </summary>
	public virtual string LabelsSignUp => "Sign Up";

	/// <summary>
	/// Key: "Label.Store"
	/// English String: "Store"
	/// </summary>
	public virtual string LabelStore => "Store";

	/// <summary>
	/// Key: "Label.sTrade"
	/// English String: "Trade"
	/// </summary>
	public virtual string LabelsTrade => "Trade";

	/// <summary>
	/// Key: "Label.Support"
	/// page title
	/// English String: "Support"
	/// </summary>
	public virtual string LabelSupport => "Support";

	/// <summary>
	/// Key: "Label.Terms"
	/// English String: "Terms"
	/// </summary>
	public virtual string LabelTerms => "Terms";

	/// <summary>
	/// Key: "Label.TermsOfUse"
	/// terms of use link label
	/// English String: "Terms of Use"
	/// </summary>
	public virtual string LabelTermsOfUse => "Terms of Use";

	/// <summary>
	/// Key: "Label.Thanks"
	/// page title
	/// English String: "Thanks"
	/// </summary>
	public virtual string LabelThanks => "Thanks";

	/// <summary>
	/// Key: "Label.Upgrade"
	/// Upgrade
	/// English String: "Upgrade"
	/// </summary>
	public virtual string LabelUpgrade => "Upgrade";

	public FeaturesResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"Action.BackToTop",
				_GetTemplateForActionBackToTop()
			},
			{
				"Action.BuyAccess",
				_GetTemplateForActionBuyAccess()
			},
			{
				"Action.Cancel",
				_GetTemplateForActionCancel()
			},
			{
				"Action.Ok",
				_GetTemplateForActionOk()
			},
			{
				"Action.sUpgradeNow",
				_GetTemplateForActionsUpgradeNow()
			},
			{
				"BuyAccessToGameForModal",
				_GetTemplateForBuyAccessToGameForModal()
			},
			{
				"Description.CopyRightMessage",
				_GetTemplateForDescriptionCopyRightMessage()
			},
			{
				"Description.CopyRightMessageDynamicYear",
				_GetTemplateForDescriptionCopyRightMessageDynamicYear()
			},
			{
				"Description.UnsupportedLanguage",
				_GetTemplateForDescriptionUnsupportedLanguage()
			},
			{
				"Description.UnsupportedLanguageModal",
				_GetTemplateForDescriptionUnsupportedLanguageModal()
			},
			{
				"Heading.BuyItem",
				_GetTemplateForHeadingBuyItem()
			},
			{
				"Heading.UnsupportedLanguage",
				_GetTemplateForHeadingUnsupportedLanguage()
			},
			{
				"Label.AboutUs",
				_GetTemplateForLabelAboutUs()
			},
			{
				"Label.AuthenticationError",
				_GetTemplateForLabelAuthenticationError()
			},
			{
				"Label.Badges",
				_GetTemplateForLabelBadges()
			},
			{
				"Label.Careers",
				_GetTemplateForLabelCareers()
			},
			{
				"Label.Configure",
				_GetTemplateForLabelConfigure()
			},
			{
				"Label.ConfigureGame",
				_GetTemplateForLabelConfigureGame()
			},
			{
				"Label.ConfigurePlace",
				_GetTemplateForLabelConfigurePlace()
			},
			{
				"Label.ConfigurePrivateServer",
				_GetTemplateForLabelConfigurePrivateServer()
			},
			{
				"Label.ContactUs",
				_GetTemplateForLabelContactUs()
			},
			{
				"Label.Create",
				_GetTemplateForLabelCreate()
			},
			{
				"Label.CreateGame",
				_GetTemplateForLabelCreateGame()
			},
			{
				"Label.CreateGroup",
				_GetTemplateForLabelCreateGroup()
			},
			{
				"Label.Discover",
				_GetTemplateForLabelDiscover()
			},
			{
				"Label.Favorites",
				_GetTemplateForLabelFavorites()
			},
			{
				"Label.Feeds",
				_GetTemplateForLabelFeeds()
			},
			{
				"Label.FindMyFeed",
				_GetTemplateForLabelFindMyFeed()
			},
			{
				"Label.Help",
				_GetTemplateForLabelHelp()
			},
			{
				"Label.Jobs",
				_GetTemplateForLabelJobs()
			},
			{
				"Label.Library",
				_GetTemplateForLabelLibrary()
			},
			{
				"Label.Merch",
				_GetTemplateForLabelMerch()
			},
			{
				"Label.Parents",
				_GetTemplateForLabelParents()
			},
			{
				"Label.PlaceStatistics",
				_GetTemplateForLabelPlaceStatistics()
			},
			{
				"Label.Players",
				_GetTemplateForLabelPlayers()
			},
			{
				"Label.Privacy",
				_GetTemplateForLabelPrivacy()
			},
			{
				"Label.RedeemRobloxCards",
				_GetTemplateForLabelRedeemRobloxCards()
			},
			{
				"Label.sAvatar",
				_GetTemplateForLabelsAvatar()
			},
			{
				"Label.sBlog",
				_GetTemplateForLabelsBlog()
			},
			{
				"Label.sCatalog",
				_GetTemplateForLabelsCatalog()
			},
			{
				"Label.sDevelop",
				_GetTemplateForLabelsDevelop()
			},
			{
				"Label.sEvents",
				_GetTemplateForLabelsEvents()
			},
			{
				"Label.sForum",
				_GetTemplateForLabelsForum()
			},
			{
				"Label.sFriends",
				_GetTemplateForLabelsFriends()
			},
			{
				"Label.sGames",
				_GetTemplateForLabelsGames()
			},
			{
				"Label.sGroups",
				_GetTemplateForLabelsGroups()
			},
			{
				"Label.sHome",
				_GetTemplateForLabelsHome()
			},
			{
				"Label.sInventory",
				_GetTemplateForLabelsInventory()
			},
			{
				"Label.sLogin",
				_GetTemplateForLabelsLogin()
			},
			{
				"Label.sMessages",
				_GetTemplateForLabelsMessages()
			},
			{
				"Label.sProfile",
				_GetTemplateForLabelsProfile()
			},
			{
				"Label.sRobux",
				_GetTemplateForLabelsRobux()
			},
			{
				"Label.sSearch",
				_GetTemplateForLabelsSearch()
			},
			{
				"Label.sSearchPhrase",
				_GetTemplateForLabelsSearchPhrase()
			},
			{
				"Label.sShop",
				_GetTemplateForLabelsShop()
			},
			{
				"Label.sSignUp",
				_GetTemplateForLabelsSignUp()
			},
			{
				"Label.Store",
				_GetTemplateForLabelStore()
			},
			{
				"Label.sTrade",
				_GetTemplateForLabelsTrade()
			},
			{
				"Label.Support",
				_GetTemplateForLabelSupport()
			},
			{
				"Label.Terms",
				_GetTemplateForLabelTerms()
			},
			{
				"Label.TermsOfUse",
				_GetTemplateForLabelTermsOfUse()
			},
			{
				"Label.Thanks",
				_GetTemplateForLabelThanks()
			},
			{
				"Label.Upgrade",
				_GetTemplateForLabelUpgrade()
			}
		});
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "CommonUI.Features";
	}

	protected virtual string _GetTemplateForActionBackToTop()
	{
		return "Back To Top";
	}

	protected virtual string _GetTemplateForActionBuyAccess()
	{
		return "Buy Access";
	}

	protected virtual string _GetTemplateForActionCancel()
	{
		return "Cancel";
	}

	protected virtual string _GetTemplateForActionOk()
	{
		return "Ok";
	}

	protected virtual string _GetTemplateForActionsUpgradeNow()
	{
		return "Upgrade Now";
	}

	/// <summary>
	/// Key: "BuyAccessToGameForModal"
	/// English String: "Would you like to buy access to the Place: {placeName} from {creatorName} for {robux}?"
	/// </summary>
	public virtual string BuyAccessToGameForModal(string placeName, string creatorName, string robux)
	{
		return $"Would you like to buy access to the Place: {placeName} from {creatorName} for {robux}?";
	}

	protected virtual string _GetTemplateForBuyAccessToGameForModal()
	{
		return "Would you like to buy access to the Place: {placeName} from {creatorName} for {robux}?";
	}

	protected virtual string _GetTemplateForDescriptionCopyRightMessage()
	{
		return "©2018 Roblox Corporation. Roblox, the Roblox logo and Powering Imagination are among our registered and unregistered trademarks in the U.S. and other countries.";
	}

	/// <summary>
	/// Key: "Description.CopyRightMessageDynamicYear"
	/// Footer copyright message with dynamic year value
	/// English String: "©{copyrightYear} Roblox Corporation. Roblox, the Roblox logo and Powering Imagination are among our registered and unregistered trademarks in the U.S. and other countries."
	/// </summary>
	public virtual string DescriptionCopyRightMessageDynamicYear(string copyrightYear)
	{
		return $"©{copyrightYear} Roblox Corporation. Roblox, the Roblox logo and Powering Imagination are among our registered and unregistered trademarks in the U.S. and other countries.";
	}

	protected virtual string _GetTemplateForDescriptionCopyRightMessageDynamicYear()
	{
		return "©{copyrightYear} Roblox Corporation. Roblox, the Roblox logo and Powering Imagination are among our registered and unregistered trademarks in the U.S. and other countries.";
	}

	protected virtual string _GetTemplateForDescriptionUnsupportedLanguage()
	{
		return "While some games may use the selected language, it is not fully supported by roblox.com.";
	}

	/// <summary>
	/// Key: "Description.UnsupportedLanguageModal"
	/// English String: "{userLanguage} is currently unavailable on roblox.com. You will see in-game content in {platformLanguage}, and roblox.com has been set to English."
	/// </summary>
	public virtual string DescriptionUnsupportedLanguageModal(string userLanguage, string platformLanguage)
	{
		return $"{userLanguage} is currently unavailable on roblox.com. You will see in-game content in {platformLanguage}, and roblox.com has been set to English.";
	}

	protected virtual string _GetTemplateForDescriptionUnsupportedLanguageModal()
	{
		return "{userLanguage} is currently unavailable on roblox.com. You will see in-game content in {platformLanguage}, and roblox.com has been set to English.";
	}

	protected virtual string _GetTemplateForHeadingBuyItem()
	{
		return "Buy Item";
	}

	protected virtual string _GetTemplateForHeadingUnsupportedLanguage()
	{
		return "Unsupported Language";
	}

	protected virtual string _GetTemplateForLabelAboutUs()
	{
		return "About Us";
	}

	protected virtual string _GetTemplateForLabelAuthenticationError()
	{
		return "Authentication Error";
	}

	protected virtual string _GetTemplateForLabelBadges()
	{
		return "Badges";
	}

	protected virtual string _GetTemplateForLabelCareers()
	{
		return "Careers";
	}

	protected virtual string _GetTemplateForLabelConfigure()
	{
		return "Configure";
	}

	protected virtual string _GetTemplateForLabelConfigureGame()
	{
		return "Configure Game";
	}

	protected virtual string _GetTemplateForLabelConfigurePlace()
	{
		return "Configure Place";
	}

	protected virtual string _GetTemplateForLabelConfigurePrivateServer()
	{
		return "Configure VIP Server";
	}

	protected virtual string _GetTemplateForLabelContactUs()
	{
		return "Contact Us";
	}

	protected virtual string _GetTemplateForLabelCreate()
	{
		return "Create";
	}

	protected virtual string _GetTemplateForLabelCreateGame()
	{
		return "Create Game";
	}

	protected virtual string _GetTemplateForLabelCreateGroup()
	{
		return "Create Group";
	}

	protected virtual string _GetTemplateForLabelDiscover()
	{
		return "Discover";
	}

	protected virtual string _GetTemplateForLabelFavorites()
	{
		return "Favorites";
	}

	protected virtual string _GetTemplateForLabelFeeds()
	{
		return "My Feed";
	}

	protected virtual string _GetTemplateForLabelFindMyFeed()
	{
		return "Looking for My Feed? It's now in side menu";
	}

	protected virtual string _GetTemplateForLabelHelp()
	{
		return "Help";
	}

	protected virtual string _GetTemplateForLabelJobs()
	{
		return "Jobs";
	}

	protected virtual string _GetTemplateForLabelLibrary()
	{
		return "Library";
	}

	protected virtual string _GetTemplateForLabelMerch()
	{
		return "Merchandise";
	}

	protected virtual string _GetTemplateForLabelParents()
	{
		return "Parents";
	}

	protected virtual string _GetTemplateForLabelPlaceStatistics()
	{
		return "Place Statistics";
	}

	protected virtual string _GetTemplateForLabelPlayers()
	{
		return "Players";
	}

	protected virtual string _GetTemplateForLabelPrivacy()
	{
		return "Privacy";
	}

	protected virtual string _GetTemplateForLabelRedeemRobloxCards()
	{
		return "Redeem Roblox Cards";
	}

	protected virtual string _GetTemplateForLabelsAvatar()
	{
		return "Avatar";
	}

	protected virtual string _GetTemplateForLabelsBlog()
	{
		return "Blog";
	}

	protected virtual string _GetTemplateForLabelsCatalog()
	{
		return "Catalog";
	}

	protected virtual string _GetTemplateForLabelsDevelop()
	{
		return "Develop";
	}

	protected virtual string _GetTemplateForLabelsEvents()
	{
		return "Events";
	}

	protected virtual string _GetTemplateForLabelsForum()
	{
		return "Forum";
	}

	protected virtual string _GetTemplateForLabelsFriends()
	{
		return "Friends";
	}

	protected virtual string _GetTemplateForLabelsGames()
	{
		return "Games";
	}

	protected virtual string _GetTemplateForLabelsGroups()
	{
		return "Groups";
	}

	protected virtual string _GetTemplateForLabelsHome()
	{
		return "Home";
	}

	protected virtual string _GetTemplateForLabelsInventory()
	{
		return "Inventory";
	}

	protected virtual string _GetTemplateForLabelsLogin()
	{
		return "Log In";
	}

	protected virtual string _GetTemplateForLabelsMessages()
	{
		return "Messages";
	}

	protected virtual string _GetTemplateForLabelsProfile()
	{
		return "Profile";
	}

	protected virtual string _GetTemplateForLabelsRobux()
	{
		return "Robux";
	}

	protected virtual string _GetTemplateForLabelsSearch()
	{
		return "Search";
	}

	/// <summary>
	/// Key: "Label.sSearchPhrase"
	/// English String: "Search \"{phrase}\" in {location}"
	/// </summary>
	public virtual string LabelsSearchPhrase(string phrase, string location)
	{
		return $"Search \"{phrase}\" in {location}";
	}

	protected virtual string _GetTemplateForLabelsSearchPhrase()
	{
		return "Search \"{phrase}\" in {location}";
	}

	protected virtual string _GetTemplateForLabelsShop()
	{
		return "Shop";
	}

	protected virtual string _GetTemplateForLabelsSignUp()
	{
		return "Sign Up";
	}

	protected virtual string _GetTemplateForLabelStore()
	{
		return "Store";
	}

	protected virtual string _GetTemplateForLabelsTrade()
	{
		return "Trade";
	}

	protected virtual string _GetTemplateForLabelSupport()
	{
		return "Support";
	}

	protected virtual string _GetTemplateForLabelTerms()
	{
		return "Terms";
	}

	protected virtual string _GetTemplateForLabelTermsOfUse()
	{
		return "Terms of Use";
	}

	protected virtual string _GetTemplateForLabelThanks()
	{
		return "Thanks";
	}

	protected virtual string _GetTemplateForLabelUpgrade()
	{
		return "Upgrade";
	}
}
