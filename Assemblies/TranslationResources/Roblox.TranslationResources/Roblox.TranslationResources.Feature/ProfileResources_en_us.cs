using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Feature;

internal class ProfileResources_en_us : TranslationResourcesBase, IProfileResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "Action.Accept"
	/// English String: "Accept"
	/// </summary>
	public virtual string ActionAccept => "Accept";

	/// <summary>
	/// Key: "Action.AddFriend"
	/// English String: "Add Friend"
	/// </summary>
	public virtual string ActionAddFriend => "Add Friend";

	/// <summary>
	/// Key: "Action.BlockUser"
	/// English String: "Block User"
	/// </summary>
	public virtual string ActionBlockUser => "Block User";

	/// <summary>
	/// Key: "Action.CancelBlockUser"
	/// English String: "Cancel"
	/// </summary>
	public virtual string ActionCancelBlockUser => "Cancel";

	/// <summary>
	/// Key: "Action.Chat"
	/// English String: "Chat"
	/// </summary>
	public virtual string ActionChat => "Chat";

	/// <summary>
	/// Key: "Action.Close"
	/// close modal
	/// English String: "Close"
	/// </summary>
	public virtual string ActionClose => "Close";

	/// <summary>
	/// Key: "Action.ConfirmBlockUser"
	/// English String: "Block"
	/// </summary>
	public virtual string ActionConfirmBlockUser => "Block";

	/// <summary>
	/// Key: "Action.ConfirmUnblockUser"
	/// English String: "Unblock"
	/// </summary>
	public virtual string ActionConfirmUnblockUser => "Unblock";

	/// <summary>
	/// Key: "Action.Favorites"
	/// English String: "Favorites"
	/// </summary>
	public virtual string ActionFavorites => "Favorites";

	/// <summary>
	/// Key: "Action.Follow"
	/// English String: "Follow"
	/// </summary>
	public virtual string ActionFollow => "Follow";

	/// <summary>
	/// Key: "Action.GridView"
	/// English String: "Grid View"
	/// </summary>
	public virtual string ActionGridView => "Grid View";

	/// <summary>
	/// Key: "Action.ImpersonateUser"
	/// English String: "Impersonate User"
	/// </summary>
	public virtual string ActionImpersonateUser => "Impersonate User";

	/// <summary>
	/// Key: "Action.Inventory"
	/// English String: "Inventory"
	/// </summary>
	public virtual string ActionInventory => "Inventory";

	/// <summary>
	/// Key: "Action.JoinGame"
	/// English String: "Join Game"
	/// </summary>
	public virtual string ActionJoinGame => "Join Game";

	/// <summary>
	/// Key: "Action.Message"
	/// English String: "Message"
	/// </summary>
	public virtual string ActionMessage => "Message";

	/// <summary>
	/// Key: "Action.Pending"
	/// English String: "Pending"
	/// </summary>
	public virtual string ActionPending => "Pending";

	/// <summary>
	/// Key: "Action.Save"
	/// English String: "Save"
	/// </summary>
	public virtual string ActionSave => "Save";

	/// <summary>
	/// Key: "Action.SeeAll"
	/// English String: "See All"
	/// </summary>
	public virtual string ActionSeeAll => "See All";

	/// <summary>
	/// Key: "Action.SeeLess"
	/// English String: "See Less"
	/// </summary>
	public virtual string ActionSeeLess => "See Less";

	/// <summary>
	/// Key: "Action.SeeMore"
	/// English String: "See More"
	/// </summary>
	public virtual string ActionSeeMore => "See More";

	/// <summary>
	/// Key: "Action.SlideshowView"
	/// English String: "Slideshow View"
	/// </summary>
	public virtual string ActionSlideshowView => "Slideshow View";

	/// <summary>
	/// Key: "Action.Trade"
	/// English String: "Trade"
	/// </summary>
	public virtual string ActionTrade => "Trade";

	/// <summary>
	/// Key: "Action.TradeItems"
	/// English String: "Trade Items"
	/// </summary>
	public virtual string ActionTradeItems => "Trade Items";

	/// <summary>
	/// Key: "Action.UnblockUser"
	/// English String: "Unblock User"
	/// </summary>
	public virtual string ActionUnblockUser => "Unblock User";

	/// <summary>
	/// Key: "Action.Unfollow"
	/// English String: "Unfollow"
	/// </summary>
	public virtual string ActionUnfollow => "Unfollow";

	/// <summary>
	/// Key: "Action.Unfriend"
	/// English String: "Unfriend"
	/// </summary>
	public virtual string ActionUnfriend => "Unfriend";

	/// <summary>
	/// Key: "Action.UpdateStatus"
	/// English String: "Update Status"
	/// </summary>
	public virtual string ActionUpdateStatus => "Update Status";

	/// <summary>
	/// Key: "Description.BlockUserFooter"
	/// English String: "When you've blocked a user, neither of you can directly contact the other."
	/// </summary>
	public virtual string DescriptionBlockUserFooter => "When you've blocked a user, neither of you can directly contact the other.";

	/// <summary>
	/// Key: "Description.BlockUserPrompt"
	/// English String: "Are you sure you want to block this user?"
	/// </summary>
	public virtual string DescriptionBlockUserPrompt => "Are you sure you want to block this user?";

	/// <summary>
	/// Key: "Description.ChangeAlias"
	/// English String: "Only you can see this information"
	/// </summary>
	public virtual string DescriptionChangeAlias => "Only you can see this information";

	/// <summary>
	/// Key: "Description.UnblockUserPrompt"
	/// English String: "Are you sure you want to unblock this user?"
	/// </summary>
	public virtual string DescriptionUnblockUserPrompt => "Are you sure you want to unblock this user?";

	/// <summary>
	/// Key: "Heading.AboutTab"
	/// this is for the heading under About tab on profile page
	/// English String: "About"
	/// </summary>
	public virtual string HeadingAboutTab => "About";

	/// <summary>
	/// Key: "Heading.BlockUserTitle"
	/// English String: "Warning"
	/// </summary>
	public virtual string HeadingBlockUserTitle => "Warning";

	/// <summary>
	/// Key: "Heading.Collections"
	/// English String: "Collections"
	/// </summary>
	public virtual string HeadingCollections => "Collections";

	/// <summary>
	/// Key: "Heading.CurrentlyWearing"
	/// English String: "Currently Wearing"
	/// </summary>
	public virtual string HeadingCurrentlyWearing => "Currently Wearing";

	/// <summary>
	/// Key: "Heading.FavoriteGames"
	/// English String: "Favorites"
	/// </summary>
	public virtual string HeadingFavoriteGames => "Favorites";

	/// <summary>
	/// Key: "Heading.Friends"
	/// English String: "Friends"
	/// </summary>
	public virtual string HeadingFriends => "Friends";

	/// <summary>
	/// Key: "Heading.Games"
	/// English String: "Games"
	/// </summary>
	public virtual string HeadingGames => "Games";

	/// <summary>
	/// Key: "Heading.GameTitle"
	/// English String: "Games"
	/// </summary>
	public virtual string HeadingGameTitle => "Games";

	/// <summary>
	/// Key: "Heading.Groups"
	/// English String: "Groups"
	/// </summary>
	public virtual string HeadingGroups => "Groups";

	/// <summary>
	/// Key: "Heading.PlayerAssetsBadges"
	/// English String: "Player Badges"
	/// </summary>
	public virtual string HeadingPlayerAssetsBadges => "Player Badges";

	/// <summary>
	/// Key: "Heading.PlayerAssetsClothing"
	/// English String: "Clothing"
	/// </summary>
	public virtual string HeadingPlayerAssetsClothing => "Clothing";

	/// <summary>
	/// Key: "Heading.PlayerAssetsModels"
	/// English String: "Models"
	/// </summary>
	public virtual string HeadingPlayerAssetsModels => "Models";

	/// <summary>
	/// Key: "Heading.PlayerBadge"
	/// English String: "Player Badges"
	/// </summary>
	public virtual string HeadingPlayerBadge => "Player Badges";

	/// <summary>
	/// Key: "Heading.Profile"
	/// English String: "Profile"
	/// </summary>
	public virtual string HeadingProfile => "Profile";

	/// <summary>
	/// Key: "Heading.ProfileGroups"
	/// English String: "Groups"
	/// </summary>
	public virtual string HeadingProfileGroups => "Groups";

	/// <summary>
	/// Key: "Heading.RobloxBadge"
	/// English String: "Roblox Badges"
	/// </summary>
	public virtual string HeadingRobloxBadge => "Roblox Badges";

	/// <summary>
	/// Key: "Heading.Statistics"
	/// English String: "Statistics"
	/// </summary>
	public virtual string HeadingStatistics => "Statistics";

	/// <summary>
	/// Key: "Label.About"
	/// English String: "About"
	/// </summary>
	public virtual string LabelAbout => "About";

	/// <summary>
	/// Key: "Label.Alias"
	/// Friends Tag, nickname
	/// English String: "Alias"
	/// </summary>
	public virtual string LabelAlias => "Alias";

	/// <summary>
	/// Key: "Label.BlockWarningBody"
	/// English String: "Are you sure you want to block this user?"
	/// </summary>
	public virtual string LabelBlockWarningBody => "Are you sure you want to block this user?";

	/// <summary>
	/// Key: "Label.BlockWarningConfirm"
	/// English String: "Block"
	/// </summary>
	public virtual string LabelBlockWarningConfirm => "Block";

	/// <summary>
	/// Key: "Label.BlockWarningFooter"
	/// English String: "When you've blocked a user, neither of you can directly contact the other."
	/// </summary>
	public virtual string LabelBlockWarningFooter => "When you've blocked a user, neither of you can directly contact the other.";

	/// <summary>
	/// Key: "Label.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public virtual string LabelCancel => "Cancel";

	/// <summary>
	/// Key: "Label.ChangeAlias"
	/// set nickname
	/// English String: "Set Alias"
	/// </summary>
	public virtual string LabelChangeAlias => "Set Alias";

	/// <summary>
	/// Key: "Label.Creations"
	/// English String: "Creations"
	/// </summary>
	public virtual string LabelCreations => "Creations";

	/// <summary>
	/// Key: "Label.Followers"
	/// English String: "Followers"
	/// </summary>
	public virtual string LabelFollowers => "Followers";

	/// <summary>
	/// Key: "Label.Following"
	/// English String: "Following"
	/// </summary>
	public virtual string LabelFollowing => "Following";

	/// <summary>
	/// Key: "Label.ForumPosts"
	/// English String: "Forum Posts"
	/// </summary>
	public virtual string LabelForumPosts => "Forum Posts";

	/// <summary>
	/// Key: "Label.Friends"
	/// English String: "Friends"
	/// </summary>
	public virtual string LabelFriends => "Friends";

	/// <summary>
	/// Key: "Label.GridView"
	/// English String: "Grid View"
	/// </summary>
	public virtual string LabelGridView => "Grid View";

	/// <summary>
	/// Key: "Label.JoinDate"
	/// English String: "Join Date"
	/// </summary>
	public virtual string LabelJoinDate => "Join Date";

	/// <summary>
	/// Key: "Label.LoadMore"
	/// English String: "Load More"
	/// </summary>
	public virtual string LabelLoadMore => "Load More";

	/// <summary>
	/// Key: "Label.Members"
	/// English String: "Members"
	/// </summary>
	public virtual string LabelMembers => "Members";

	/// <summary>
	/// Key: "Label.PastUsername"
	/// English String: "Past Usernames"
	/// </summary>
	public virtual string LabelPastUsername => "Past Usernames";

	/// <summary>
	/// Key: "Label.PastUsernames"
	/// English String: "Past usernames"
	/// </summary>
	public virtual string LabelPastUsernames => "Past usernames";

	/// <summary>
	/// Key: "Label.PlaceVisits"
	/// English String: "Place Visits"
	/// </summary>
	public virtual string LabelPlaceVisits => "Place Visits";

	/// <summary>
	/// Key: "Label.Playing"
	/// English String: "Playing"
	/// </summary>
	public virtual string LabelPlaying => "Playing";

	/// <summary>
	/// Key: "Label.Rank"
	/// English String: "Rank"
	/// </summary>
	public virtual string LabelRank => "Rank";

	/// <summary>
	/// Key: "Label.ReadMore"
	/// English String: "Read More"
	/// </summary>
	public virtual string LabelReadMore => "Read More";

	/// <summary>
	/// Key: "Label.ReportAbuse"
	/// English String: "Report Abuse"
	/// </summary>
	public virtual string LabelReportAbuse => "Report Abuse";

	/// <summary>
	/// Key: "Label.ShowLess"
	/// English String: "Show Less"
	/// </summary>
	public virtual string LabelShowLess => "Show Less";

	/// <summary>
	/// Key: "Label.SlideshowView"
	/// English String: "Slideshow View"
	/// </summary>
	public virtual string LabelSlideshowView => "Slideshow View";

	/// <summary>
	/// Key: "Label.UnblockWarningBody"
	/// English String: "Are you sure you want to unblock this user?"
	/// </summary>
	public virtual string LabelUnblockWarningBody => "Are you sure you want to unblock this user?";

	/// <summary>
	/// Key: "Label.UnblockWarningConfirm"
	/// English String: "Unblock"
	/// </summary>
	public virtual string LabelUnblockWarningConfirm => "Unblock";

	/// <summary>
	/// Key: "Label.Visits"
	/// English String: "Visits"
	/// </summary>
	public virtual string LabelVisits => "Visits";

	/// <summary>
	/// Key: "Label.WarningTitle"
	/// English String: "Warning"
	/// </summary>
	public virtual string LabelWarningTitle => "Warning";

	/// <summary>
	/// Key: "Message.AliasHasError"
	/// English String: "An error has occurred. Please try again later"
	/// </summary>
	public virtual string MessageAliasHasError => "An error has occurred. Please try again later";

	/// <summary>
	/// Key: "Message.AliasIsModerated"
	/// English String: "Please avoid using full names or offensive language."
	/// </summary>
	public virtual string MessageAliasIsModerated => "Please avoid using full names or offensive language.";

	/// <summary>
	/// Key: "Message.ChangeStatus"
	/// English String: "What are you up to?"
	/// </summary>
	public virtual string MessageChangeStatus => "What are you up to?";

	/// <summary>
	/// Key: "Message.ErrorBlockLimit"
	/// English String: "Operation failed! You may have blocked too many people."
	/// </summary>
	public virtual string MessageErrorBlockLimit => "Operation failed! You may have blocked too many people.";

	/// <summary>
	/// Key: "Message.ErrorGeneral"
	/// English String: "Something went wrong. Please check back in a few minutes."
	/// </summary>
	public virtual string MessageErrorGeneral => "Something went wrong. Please check back in a few minutes.";

	/// <summary>
	/// Key: "Message.Sharing"
	/// English String: "Sharing..."
	/// </summary>
	public virtual string MessageSharing => "Sharing...";

	/// <summary>
	/// Key: "Response.TooManyAttempts"
	/// flood error response
	/// English String: "Too Many Attempts"
	/// </summary>
	public virtual string ResponseTooManyAttempts => "Too Many Attempts";

	public ProfileResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"Action.Accept",
				_GetTemplateForActionAccept()
			},
			{
				"Action.AddFriend",
				_GetTemplateForActionAddFriend()
			},
			{
				"Action.BlockUser",
				_GetTemplateForActionBlockUser()
			},
			{
				"Action.CancelBlockUser",
				_GetTemplateForActionCancelBlockUser()
			},
			{
				"Action.Chat",
				_GetTemplateForActionChat()
			},
			{
				"Action.Close",
				_GetTemplateForActionClose()
			},
			{
				"Action.ConfirmBlockUser",
				_GetTemplateForActionConfirmBlockUser()
			},
			{
				"Action.ConfirmUnblockUser",
				_GetTemplateForActionConfirmUnblockUser()
			},
			{
				"Action.Favorites",
				_GetTemplateForActionFavorites()
			},
			{
				"Action.Follow",
				_GetTemplateForActionFollow()
			},
			{
				"Action.GridView",
				_GetTemplateForActionGridView()
			},
			{
				"Action.ImpersonateUser",
				_GetTemplateForActionImpersonateUser()
			},
			{
				"Action.Inventory",
				_GetTemplateForActionInventory()
			},
			{
				"Action.JoinGame",
				_GetTemplateForActionJoinGame()
			},
			{
				"Action.Message",
				_GetTemplateForActionMessage()
			},
			{
				"Action.Pending",
				_GetTemplateForActionPending()
			},
			{
				"Action.Save",
				_GetTemplateForActionSave()
			},
			{
				"Action.SeeAll",
				_GetTemplateForActionSeeAll()
			},
			{
				"Action.SeeLess",
				_GetTemplateForActionSeeLess()
			},
			{
				"Action.SeeMore",
				_GetTemplateForActionSeeMore()
			},
			{
				"Action.SlideshowView",
				_GetTemplateForActionSlideshowView()
			},
			{
				"Action.Trade",
				_GetTemplateForActionTrade()
			},
			{
				"Action.TradeItems",
				_GetTemplateForActionTradeItems()
			},
			{
				"Action.UnblockUser",
				_GetTemplateForActionUnblockUser()
			},
			{
				"Action.Unfollow",
				_GetTemplateForActionUnfollow()
			},
			{
				"Action.Unfriend",
				_GetTemplateForActionUnfriend()
			},
			{
				"Action.UpdateStatus",
				_GetTemplateForActionUpdateStatus()
			},
			{
				"Description.BlockUserFooter",
				_GetTemplateForDescriptionBlockUserFooter()
			},
			{
				"Description.BlockUserPrompt",
				_GetTemplateForDescriptionBlockUserPrompt()
			},
			{
				"Description.ChangeAlias",
				_GetTemplateForDescriptionChangeAlias()
			},
			{
				"Description.UnblockUserPrompt",
				_GetTemplateForDescriptionUnblockUserPrompt()
			},
			{
				"Heading.AboutTab",
				_GetTemplateForHeadingAboutTab()
			},
			{
				"Heading.BlockUserTitle",
				_GetTemplateForHeadingBlockUserTitle()
			},
			{
				"Heading.Collections",
				_GetTemplateForHeadingCollections()
			},
			{
				"Heading.CurrentlyWearing",
				_GetTemplateForHeadingCurrentlyWearing()
			},
			{
				"Heading.FavoriteGames",
				_GetTemplateForHeadingFavoriteGames()
			},
			{
				"Heading.Friends",
				_GetTemplateForHeadingFriends()
			},
			{
				"Heading.FriendsNum",
				_GetTemplateForHeadingFriendsNum()
			},
			{
				"Heading.Games",
				_GetTemplateForHeadingGames()
			},
			{
				"Heading.GameTitle",
				_GetTemplateForHeadingGameTitle()
			},
			{
				"Heading.Groups",
				_GetTemplateForHeadingGroups()
			},
			{
				"Heading.PlayerAssetsBadges",
				_GetTemplateForHeadingPlayerAssetsBadges()
			},
			{
				"Heading.PlayerAssetsClothing",
				_GetTemplateForHeadingPlayerAssetsClothing()
			},
			{
				"Heading.PlayerAssetsModels",
				_GetTemplateForHeadingPlayerAssetsModels()
			},
			{
				"Heading.PlayerBadge",
				_GetTemplateForHeadingPlayerBadge()
			},
			{
				"Heading.Profile",
				_GetTemplateForHeadingProfile()
			},
			{
				"Heading.ProfileGroups",
				_GetTemplateForHeadingProfileGroups()
			},
			{
				"Heading.RobloxBadge",
				_GetTemplateForHeadingRobloxBadge()
			},
			{
				"Heading.Statistics",
				_GetTemplateForHeadingStatistics()
			},
			{
				"Label.About",
				_GetTemplateForLabelAbout()
			},
			{
				"Label.Alias",
				_GetTemplateForLabelAlias()
			},
			{
				"Label.BlockWarningBody",
				_GetTemplateForLabelBlockWarningBody()
			},
			{
				"Label.BlockWarningConfirm",
				_GetTemplateForLabelBlockWarningConfirm()
			},
			{
				"Label.BlockWarningFooter",
				_GetTemplateForLabelBlockWarningFooter()
			},
			{
				"Label.Cancel",
				_GetTemplateForLabelCancel()
			},
			{
				"Label.ChangeAlias",
				_GetTemplateForLabelChangeAlias()
			},
			{
				"Label.Creations",
				_GetTemplateForLabelCreations()
			},
			{
				"Label.Followers",
				_GetTemplateForLabelFollowers()
			},
			{
				"Label.Following",
				_GetTemplateForLabelFollowing()
			},
			{
				"Label.ForumPosts",
				_GetTemplateForLabelForumPosts()
			},
			{
				"Label.Friends",
				_GetTemplateForLabelFriends()
			},
			{
				"Label.GridView",
				_GetTemplateForLabelGridView()
			},
			{
				"Label.JoinDate",
				_GetTemplateForLabelJoinDate()
			},
			{
				"Label.LoadMore",
				_GetTemplateForLabelLoadMore()
			},
			{
				"Label.Members",
				_GetTemplateForLabelMembers()
			},
			{
				"Label.PastUsername",
				_GetTemplateForLabelPastUsername()
			},
			{
				"Label.PastUsernames",
				_GetTemplateForLabelPastUsernames()
			},
			{
				"Label.PlaceVisits",
				_GetTemplateForLabelPlaceVisits()
			},
			{
				"Label.Playing",
				_GetTemplateForLabelPlaying()
			},
			{
				"Label.Quotation",
				_GetTemplateForLabelQuotation()
			},
			{
				"Label.Rank",
				_GetTemplateForLabelRank()
			},
			{
				"Label.ReadMore",
				_GetTemplateForLabelReadMore()
			},
			{
				"Label.ReportAbuse",
				_GetTemplateForLabelReportAbuse()
			},
			{
				"Label.ShowLess",
				_GetTemplateForLabelShowLess()
			},
			{
				"Label.SlideshowView",
				_GetTemplateForLabelSlideshowView()
			},
			{
				"Label.UnblockWarningBody",
				_GetTemplateForLabelUnblockWarningBody()
			},
			{
				"Label.UnblockWarningConfirm",
				_GetTemplateForLabelUnblockWarningConfirm()
			},
			{
				"Label.Visits",
				_GetTemplateForLabelVisits()
			},
			{
				"Label.WarningTitle",
				_GetTemplateForLabelWarningTitle()
			},
			{
				"Message.AliasHasError",
				_GetTemplateForMessageAliasHasError()
			},
			{
				"Message.AliasIsModerated",
				_GetTemplateForMessageAliasIsModerated()
			},
			{
				"Message.ChangeStatus",
				_GetTemplateForMessageChangeStatus()
			},
			{
				"Message.ErrorBlockLimit",
				_GetTemplateForMessageErrorBlockLimit()
			},
			{
				"Message.ErrorGeneral",
				_GetTemplateForMessageErrorGeneral()
			},
			{
				"Message.NoCreation",
				_GetTemplateForMessageNoCreation()
			},
			{
				"Message.Sharing",
				_GetTemplateForMessageSharing()
			},
			{
				"Response.TooManyAttempts",
				_GetTemplateForResponseTooManyAttempts()
			}
		});
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "Feature.Profile";
	}

	protected virtual string _GetTemplateForActionAccept()
	{
		return "Accept";
	}

	protected virtual string _GetTemplateForActionAddFriend()
	{
		return "Add Friend";
	}

	protected virtual string _GetTemplateForActionBlockUser()
	{
		return "Block User";
	}

	protected virtual string _GetTemplateForActionCancelBlockUser()
	{
		return "Cancel";
	}

	protected virtual string _GetTemplateForActionChat()
	{
		return "Chat";
	}

	protected virtual string _GetTemplateForActionClose()
	{
		return "Close";
	}

	protected virtual string _GetTemplateForActionConfirmBlockUser()
	{
		return "Block";
	}

	protected virtual string _GetTemplateForActionConfirmUnblockUser()
	{
		return "Unblock";
	}

	protected virtual string _GetTemplateForActionFavorites()
	{
		return "Favorites";
	}

	protected virtual string _GetTemplateForActionFollow()
	{
		return "Follow";
	}

	protected virtual string _GetTemplateForActionGridView()
	{
		return "Grid View";
	}

	protected virtual string _GetTemplateForActionImpersonateUser()
	{
		return "Impersonate User";
	}

	protected virtual string _GetTemplateForActionInventory()
	{
		return "Inventory";
	}

	protected virtual string _GetTemplateForActionJoinGame()
	{
		return "Join Game";
	}

	protected virtual string _GetTemplateForActionMessage()
	{
		return "Message";
	}

	protected virtual string _GetTemplateForActionPending()
	{
		return "Pending";
	}

	protected virtual string _GetTemplateForActionSave()
	{
		return "Save";
	}

	protected virtual string _GetTemplateForActionSeeAll()
	{
		return "See All";
	}

	protected virtual string _GetTemplateForActionSeeLess()
	{
		return "See Less";
	}

	protected virtual string _GetTemplateForActionSeeMore()
	{
		return "See More";
	}

	protected virtual string _GetTemplateForActionSlideshowView()
	{
		return "Slideshow View";
	}

	protected virtual string _GetTemplateForActionTrade()
	{
		return "Trade";
	}

	protected virtual string _GetTemplateForActionTradeItems()
	{
		return "Trade Items";
	}

	protected virtual string _GetTemplateForActionUnblockUser()
	{
		return "Unblock User";
	}

	protected virtual string _GetTemplateForActionUnfollow()
	{
		return "Unfollow";
	}

	protected virtual string _GetTemplateForActionUnfriend()
	{
		return "Unfriend";
	}

	protected virtual string _GetTemplateForActionUpdateStatus()
	{
		return "Update Status";
	}

	protected virtual string _GetTemplateForDescriptionBlockUserFooter()
	{
		return "When you've blocked a user, neither of you can directly contact the other.";
	}

	protected virtual string _GetTemplateForDescriptionBlockUserPrompt()
	{
		return "Are you sure you want to block this user?";
	}

	protected virtual string _GetTemplateForDescriptionChangeAlias()
	{
		return "Only you can see this information";
	}

	protected virtual string _GetTemplateForDescriptionUnblockUserPrompt()
	{
		return "Are you sure you want to unblock this user?";
	}

	protected virtual string _GetTemplateForHeadingAboutTab()
	{
		return "About";
	}

	protected virtual string _GetTemplateForHeadingBlockUserTitle()
	{
		return "Warning";
	}

	protected virtual string _GetTemplateForHeadingCollections()
	{
		return "Collections";
	}

	protected virtual string _GetTemplateForHeadingCurrentlyWearing()
	{
		return "Currently Wearing";
	}

	protected virtual string _GetTemplateForHeadingFavoriteGames()
	{
		return "Favorites";
	}

	protected virtual string _GetTemplateForHeadingFriends()
	{
		return "Friends";
	}

	/// <summary>
	/// Key: "Heading.FriendsNum"
	/// English String: "Friends ({friendsCount})"
	/// </summary>
	public virtual string HeadingFriendsNum(string friendsCount)
	{
		return $"Friends ({friendsCount})";
	}

	protected virtual string _GetTemplateForHeadingFriendsNum()
	{
		return "Friends ({friendsCount})";
	}

	protected virtual string _GetTemplateForHeadingGames()
	{
		return "Games";
	}

	protected virtual string _GetTemplateForHeadingGameTitle()
	{
		return "Games";
	}

	protected virtual string _GetTemplateForHeadingGroups()
	{
		return "Groups";
	}

	protected virtual string _GetTemplateForHeadingPlayerAssetsBadges()
	{
		return "Player Badges";
	}

	protected virtual string _GetTemplateForHeadingPlayerAssetsClothing()
	{
		return "Clothing";
	}

	protected virtual string _GetTemplateForHeadingPlayerAssetsModels()
	{
		return "Models";
	}

	protected virtual string _GetTemplateForHeadingPlayerBadge()
	{
		return "Player Badges";
	}

	protected virtual string _GetTemplateForHeadingProfile()
	{
		return "Profile";
	}

	protected virtual string _GetTemplateForHeadingProfileGroups()
	{
		return "Groups";
	}

	protected virtual string _GetTemplateForHeadingRobloxBadge()
	{
		return "Roblox Badges";
	}

	protected virtual string _GetTemplateForHeadingStatistics()
	{
		return "Statistics";
	}

	protected virtual string _GetTemplateForLabelAbout()
	{
		return "About";
	}

	protected virtual string _GetTemplateForLabelAlias()
	{
		return "Alias";
	}

	protected virtual string _GetTemplateForLabelBlockWarningBody()
	{
		return "Are you sure you want to block this user?";
	}

	protected virtual string _GetTemplateForLabelBlockWarningConfirm()
	{
		return "Block";
	}

	protected virtual string _GetTemplateForLabelBlockWarningFooter()
	{
		return "When you've blocked a user, neither of you can directly contact the other.";
	}

	protected virtual string _GetTemplateForLabelCancel()
	{
		return "Cancel";
	}

	protected virtual string _GetTemplateForLabelChangeAlias()
	{
		return "Set Alias";
	}

	protected virtual string _GetTemplateForLabelCreations()
	{
		return "Creations";
	}

	protected virtual string _GetTemplateForLabelFollowers()
	{
		return "Followers";
	}

	protected virtual string _GetTemplateForLabelFollowing()
	{
		return "Following";
	}

	protected virtual string _GetTemplateForLabelForumPosts()
	{
		return "Forum Posts";
	}

	protected virtual string _GetTemplateForLabelFriends()
	{
		return "Friends";
	}

	protected virtual string _GetTemplateForLabelGridView()
	{
		return "Grid View";
	}

	protected virtual string _GetTemplateForLabelJoinDate()
	{
		return "Join Date";
	}

	protected virtual string _GetTemplateForLabelLoadMore()
	{
		return "Load More";
	}

	protected virtual string _GetTemplateForLabelMembers()
	{
		return "Members";
	}

	protected virtual string _GetTemplateForLabelPastUsername()
	{
		return "Past Usernames";
	}

	protected virtual string _GetTemplateForLabelPastUsernames()
	{
		return "Past usernames";
	}

	protected virtual string _GetTemplateForLabelPlaceVisits()
	{
		return "Place Visits";
	}

	protected virtual string _GetTemplateForLabelPlaying()
	{
		return "Playing";
	}

	/// <summary>
	/// Key: "Label.Quotation"
	/// You only need to localize the quotation mark, e.g. 「{userStatus}」
	/// English String: "\"{userStatus}\""
	/// </summary>
	public virtual string LabelQuotation(string userStatus)
	{
		return $"\"{userStatus}\"";
	}

	protected virtual string _GetTemplateForLabelQuotation()
	{
		return "\"{userStatus}\"";
	}

	protected virtual string _GetTemplateForLabelRank()
	{
		return "Rank";
	}

	protected virtual string _GetTemplateForLabelReadMore()
	{
		return "Read More";
	}

	protected virtual string _GetTemplateForLabelReportAbuse()
	{
		return "Report Abuse";
	}

	protected virtual string _GetTemplateForLabelShowLess()
	{
		return "Show Less";
	}

	protected virtual string _GetTemplateForLabelSlideshowView()
	{
		return "Slideshow View";
	}

	protected virtual string _GetTemplateForLabelUnblockWarningBody()
	{
		return "Are you sure you want to unblock this user?";
	}

	protected virtual string _GetTemplateForLabelUnblockWarningConfirm()
	{
		return "Unblock";
	}

	protected virtual string _GetTemplateForLabelVisits()
	{
		return "Visits";
	}

	protected virtual string _GetTemplateForLabelWarningTitle()
	{
		return "Warning";
	}

	protected virtual string _GetTemplateForMessageAliasHasError()
	{
		return "An error has occurred. Please try again later";
	}

	protected virtual string _GetTemplateForMessageAliasIsModerated()
	{
		return "Please avoid using full names or offensive language.";
	}

	protected virtual string _GetTemplateForMessageChangeStatus()
	{
		return "What are you up to?";
	}

	protected virtual string _GetTemplateForMessageErrorBlockLimit()
	{
		return "Operation failed! You may have blocked too many people.";
	}

	protected virtual string _GetTemplateForMessageErrorGeneral()
	{
		return "Something went wrong. Please check back in a few minutes.";
	}

	/// <summary>
	/// Key: "Message.NoCreation"
	/// English String: "{username} has no creations."
	/// </summary>
	public virtual string MessageNoCreation(string username)
	{
		return $"{username} has no creations.";
	}

	protected virtual string _GetTemplateForMessageNoCreation()
	{
		return "{username} has no creations.";
	}

	protected virtual string _GetTemplateForMessageSharing()
	{
		return "Sharing...";
	}

	protected virtual string _GetTemplateForResponseTooManyAttempts()
	{
		return "Too Many Attempts";
	}
}
