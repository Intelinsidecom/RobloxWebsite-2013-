namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides ProfileResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ProfileResources_ko_kr : ProfileResources_en_us, IProfileResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Accept"
	/// English String: "Accept"
	/// </summary>
	public override string ActionAccept => "ìˆ˜ë½";

	/// <summary>
	/// Key: "Action.AddFriend"
	/// English String: "Add Friend"
	/// </summary>
	public override string ActionAddFriend => "ì¹œêµ¬ ì¶”ê°€";

	/// <summary>
	/// Key: "Action.BlockUser"
	/// English String: "Block User"
	/// </summary>
	public override string ActionBlockUser => "ì‚¬ìš©ìž ì°¨ë‹¨";

	/// <summary>
	/// Key: "Action.CancelBlockUser"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancelBlockUser => "ì·¨ì†Œ";

	/// <summary>
	/// Key: "Action.Chat"
	/// English String: "Chat"
	/// </summary>
	public override string ActionChat => "ì±„íŒ…";

	/// <summary>
	/// Key: "Action.Close"
	/// close modal
	/// English String: "Close"
	/// </summary>
	public override string ActionClose => "ë‹«ê¸°";

	/// <summary>
	/// Key: "Action.ConfirmBlockUser"
	/// English String: "Block"
	/// </summary>
	public override string ActionConfirmBlockUser => "ì°¨ë‹¨";

	/// <summary>
	/// Key: "Action.ConfirmUnblockUser"
	/// English String: "Unblock"
	/// </summary>
	public override string ActionConfirmUnblockUser => "ì°¨ë‹¨ í•´ì œ";

	/// <summary>
	/// Key: "Action.Favorites"
	/// English String: "Favorites"
	/// </summary>
	public override string ActionFavorites => "ì¦ê²¨ì°¾ê¸°";

	/// <summary>
	/// Key: "Action.Follow"
	/// English String: "Follow"
	/// </summary>
	public override string ActionFollow => "íŒ”ë¡œìš°";

	/// <summary>
	/// Key: "Action.GridView"
	/// English String: "Grid View"
	/// </summary>
	public override string ActionGridView => "ê²©ìž ë³´ê¸°";

	/// <summary>
	/// Key: "Action.ImpersonateUser"
	/// English String: "Impersonate User"
	/// </summary>
	public override string ActionImpersonateUser => "ì‚¬ìš©ìž ì‚¬ì¹­";

	/// <summary>
	/// Key: "Action.Inventory"
	/// English String: "Inventory"
	/// </summary>
	public override string ActionInventory => "ì¸ë²¤í† ë¦¬";

	/// <summary>
	/// Key: "Action.JoinGame"
	/// English String: "Join Game"
	/// </summary>
	public override string ActionJoinGame => "ê²Œìž„ ì°¸ê°€";

	/// <summary>
	/// Key: "Action.Message"
	/// English String: "Message"
	/// </summary>
	public override string ActionMessage => "ë©”ì‹œì§€";

	/// <summary>
	/// Key: "Action.Pending"
	/// English String: "Pending"
	/// </summary>
	public override string ActionPending => "ëŒ€ê¸° ì¤‘";

	/// <summary>
	/// Key: "Action.Save"
	/// English String: "Save"
	/// </summary>
	public override string ActionSave => "ì €ìž¥";

	/// <summary>
	/// Key: "Action.SeeAll"
	/// English String: "See All"
	/// </summary>
	public override string ActionSeeAll => "ì „ì²´ ë³´ê¸°";

	/// <summary>
	/// Key: "Action.SeeLess"
	/// English String: "See Less"
	/// </summary>
	public override string ActionSeeLess => "ê°„ëžµížˆ ë³´ê¸°";

	/// <summary>
	/// Key: "Action.SeeMore"
	/// English String: "See More"
	/// </summary>
	public override string ActionSeeMore => "ë” ë³´ê¸°";

	/// <summary>
	/// Key: "Action.SlideshowView"
	/// English String: "Slideshow View"
	/// </summary>
	public override string ActionSlideshowView => "ìŠ¬ë¼ì´ë“œì‡¼ ë³´ê¸°";

	/// <summary>
	/// Key: "Action.Trade"
	/// English String: "Trade"
	/// </summary>
	public override string ActionTrade => "ê±°ëž˜";

	/// <summary>
	/// Key: "Action.TradeItems"
	/// English String: "Trade Items"
	/// </summary>
	public override string ActionTradeItems => "ì•„ì´í…œ ê±°ëž˜";

	/// <summary>
	/// Key: "Action.UnblockUser"
	/// English String: "Unblock User"
	/// </summary>
	public override string ActionUnblockUser => "ì‚¬ìš©ìž ì°¨ë‹¨ í•´ì œ";

	/// <summary>
	/// Key: "Action.Unfollow"
	/// English String: "Unfollow"
	/// </summary>
	public override string ActionUnfollow => "íŒ”ë¡œìš° ì·¨ì†Œ";

	/// <summary>
	/// Key: "Action.Unfriend"
	/// English String: "Unfriend"
	/// </summary>
	public override string ActionUnfriend => "ì¹œêµ¬ ëŠê¸°";

	/// <summary>
	/// Key: "Action.UpdateStatus"
	/// English String: "Update Status"
	/// </summary>
	public override string ActionUpdateStatus => "ìƒíƒœ ì—…ë°ì´íŠ¸";

	/// <summary>
	/// Key: "Description.BlockUserFooter"
	/// English String: "When you've blocked a user, neither of you can directly contact the other."
	/// </summary>
	public override string DescriptionBlockUserFooter => "ì‚¬ìš©ìžë¥¼ ì°¨ë‹¨í•˜ë©´ í•´ë‹¹ ì‚¬ìš©ìžì™€ ì„œë¡œ ì—°ë½í•  ìˆ˜ ì—†ìŠµë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Description.BlockUserPrompt"
	/// English String: "Are you sure you want to block this user?"
	/// </summary>
	public override string DescriptionBlockUserPrompt => "ë³¸ ì‚¬ìš©ìžë¥¼ ì •ë§ ì°¨ë‹¨í• ê¹Œìš”?";

	/// <summary>
	/// Key: "Description.ChangeAlias"
	/// English String: "Only you can see this information"
	/// </summary>
	public override string DescriptionChangeAlias => "ì˜¤ì§ ë‚˜ë§Œ ì´ ì •ë³´ë¥¼ ë³¼ ìˆ˜ ìžˆì–´ìš”";

	/// <summary>
	/// Key: "Description.UnblockUserPrompt"
	/// English String: "Are you sure you want to unblock this user?"
	/// </summary>
	public override string DescriptionUnblockUserPrompt => "ë³¸ ì‚¬ìš©ìžë¥¼ ì •ë§ ì°¨ë‹¨ í•´ì œí• ê¹Œìš”?";

	/// <summary>
	/// Key: "Heading.AboutTab"
	/// this is for the heading under About tab on profile page
	/// English String: "About"
	/// </summary>
	public override string HeadingAboutTab => "ì†Œê°œ";

	/// <summary>
	/// Key: "Heading.BlockUserTitle"
	/// English String: "Warning"
	/// </summary>
	public override string HeadingBlockUserTitle => "ì£¼ì˜";

	/// <summary>
	/// Key: "Heading.Collections"
	/// English String: "Collections"
	/// </summary>
	public override string HeadingCollections => "ì»¬ë ‰ì…˜";

	/// <summary>
	/// Key: "Heading.CurrentlyWearing"
	/// English String: "Currently Wearing"
	/// </summary>
	public override string HeadingCurrentlyWearing => "í˜„ìž¬ ì°©ìš© ì¤‘";

	/// <summary>
	/// Key: "Heading.FavoriteGames"
	/// English String: "Favorites"
	/// </summary>
	public override string HeadingFavoriteGames => "ì¦ê²¨ì°¾ê¸°";

	/// <summary>
	/// Key: "Heading.Friends"
	/// English String: "Friends"
	/// </summary>
	public override string HeadingFriends => "ì¹œêµ¬";

	/// <summary>
	/// Key: "Heading.Games"
	/// English String: "Games"
	/// </summary>
	public override string HeadingGames => "ê²Œìž„";

	/// <summary>
	/// Key: "Heading.GameTitle"
	/// English String: "Games"
	/// </summary>
	public override string HeadingGameTitle => "ê²Œìž„";

	/// <summary>
	/// Key: "Heading.Groups"
	/// English String: "Groups"
	/// </summary>
	public override string HeadingGroups => "ê·¸ë£¹";

	/// <summary>
	/// Key: "Heading.PlayerAssetsBadges"
	/// English String: "Player Badges"
	/// </summary>
	public override string HeadingPlayerAssetsBadges => "í”Œë ˆì´ì–´ ë°°ì§€";

	/// <summary>
	/// Key: "Heading.PlayerAssetsClothing"
	/// English String: "Clothing"
	/// </summary>
	public override string HeadingPlayerAssetsClothing => "ë³µìž¥";

	/// <summary>
	/// Key: "Heading.PlayerAssetsModels"
	/// English String: "Models"
	/// </summary>
	public override string HeadingPlayerAssetsModels => "ëª¨ë¸";

	/// <summary>
	/// Key: "Heading.PlayerBadge"
	/// English String: "Player Badges"
	/// </summary>
	public override string HeadingPlayerBadge => "í”Œë ˆì´ì–´ ë°°ì§€";

	/// <summary>
	/// Key: "Heading.Profile"
	/// English String: "Profile"
	/// </summary>
	public override string HeadingProfile => "í”„ë¡œí•„";

	/// <summary>
	/// Key: "Heading.ProfileGroups"
	/// English String: "Groups"
	/// </summary>
	public override string HeadingProfileGroups => "ê·¸ë£¹";

	/// <summary>
	/// Key: "Heading.RobloxBadge"
	/// English String: "Roblox Badges"
	/// </summary>
	public override string HeadingRobloxBadge => "Roblox ë°°ì§€";

	/// <summary>
	/// Key: "Heading.Statistics"
	/// English String: "Statistics"
	/// </summary>
	public override string HeadingStatistics => "í†µê³„";

	/// <summary>
	/// Key: "Label.About"
	/// English String: "About"
	/// </summary>
	public override string LabelAbout => "ì†Œê°œ";

	/// <summary>
	/// Key: "Label.Alias"
	/// Friends Tag, nickname
	/// English String: "Alias"
	/// </summary>
	public override string LabelAlias => "ë‹‰ë„¤ìž„";

	/// <summary>
	/// Key: "Label.BlockWarningBody"
	/// English String: "Are you sure you want to block this user?"
	/// </summary>
	public override string LabelBlockWarningBody => "ë³¸ ì‚¬ìš©ìžë¥¼ ì •ë§ ì°¨ë‹¨í• ê¹Œìš”?";

	/// <summary>
	/// Key: "Label.BlockWarningConfirm"
	/// English String: "Block"
	/// </summary>
	public override string LabelBlockWarningConfirm => "ì°¨ë‹¨";

	/// <summary>
	/// Key: "Label.BlockWarningFooter"
	/// English String: "When you've blocked a user, neither of you can directly contact the other."
	/// </summary>
	public override string LabelBlockWarningFooter => "ì‚¬ìš©ìžë¥¼ ì°¨ë‹¨í•˜ë©´ í•´ë‹¹ ì‚¬ìš©ìžì™€ ì„œë¡œ ì—°ë½í•  ìˆ˜ ì—†ìŠµë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Label.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string LabelCancel => "ì·¨ì†Œ";

	/// <summary>
	/// Key: "Label.ChangeAlias"
	/// set nickname
	/// English String: "Set Alias"
	/// </summary>
	public override string LabelChangeAlias => "ë‹‰ë„¤ìž„ ì„¤ì •";

	/// <summary>
	/// Key: "Label.Creations"
	/// English String: "Creations"
	/// </summary>
	public override string LabelCreations => "ìž‘í’ˆ";

	/// <summary>
	/// Key: "Label.Followers"
	/// English String: "Followers"
	/// </summary>
	public override string LabelFollowers => "íŒ”ë¡œì›Œ";

	/// <summary>
	/// Key: "Label.Following"
	/// English String: "Following"
	/// </summary>
	public override string LabelFollowing => "íŒ”ë¡œìž‰";

	/// <summary>
	/// Key: "Label.ForumPosts"
	/// English String: "Forum Posts"
	/// </summary>
	public override string LabelForumPosts => "í¬ëŸ¼ ê²Œì‹œë¬¼";

	/// <summary>
	/// Key: "Label.Friends"
	/// English String: "Friends"
	/// </summary>
	public override string LabelFriends => "ì¹œêµ¬";

	/// <summary>
	/// Key: "Label.GridView"
	/// English String: "Grid View"
	/// </summary>
	public override string LabelGridView => "ê²©ìž ë³´ê¸°";

	/// <summary>
	/// Key: "Label.JoinDate"
	/// English String: "Join Date"
	/// </summary>
	public override string LabelJoinDate => "ê°€ìž… ë‚ ì§œ";

	/// <summary>
	/// Key: "Label.LoadMore"
	/// English String: "Load More"
	/// </summary>
	public override string LabelLoadMore => "ë” ë¶ˆëŸ¬ì˜¤ê¸°";

	/// <summary>
	/// Key: "Label.Members"
	/// English String: "Members"
	/// </summary>
	public override string LabelMembers => "ë©¤ë²„";

	/// <summary>
	/// Key: "Label.PastUsername"
	/// English String: "Past Usernames"
	/// </summary>
	public override string LabelPastUsername => "ì´ì „ ì‚¬ìš©ìž ì´ë¦„";

	/// <summary>
	/// Key: "Label.PastUsernames"
	/// English String: "Past usernames"
	/// </summary>
	public override string LabelPastUsernames => "ì´ì „ ì‚¬ìš©ìž ì´ë¦„";

	/// <summary>
	/// Key: "Label.PlaceVisits"
	/// English String: "Place Visits"
	/// </summary>
	public override string LabelPlaceVisits => "ìž¥ì†Œ ë°©ë¬¸";

	/// <summary>
	/// Key: "Label.Playing"
	/// English String: "Playing"
	/// </summary>
	public override string LabelPlaying => "í”Œë ˆì´ ì¤‘";

	/// <summary>
	/// Key: "Label.Rank"
	/// English String: "Rank"
	/// </summary>
	public override string LabelRank => "ë“±ê¸‰";

	/// <summary>
	/// Key: "Label.ReadMore"
	/// English String: "Read More"
	/// </summary>
	public override string LabelReadMore => "ë” ë³´ê¸°";

	/// <summary>
	/// Key: "Label.ReportAbuse"
	/// English String: "Report Abuse"
	/// </summary>
	public override string LabelReportAbuse => "ì‹ ê³ í•˜ê¸°";

	/// <summary>
	/// Key: "Label.ShowLess"
	/// English String: "Show Less"
	/// </summary>
	public override string LabelShowLess => "ê°„ëžµížˆ ë³´ê¸°";

	/// <summary>
	/// Key: "Label.SlideshowView"
	/// English String: "Slideshow View"
	/// </summary>
	public override string LabelSlideshowView => "ìŠ¬ë¼ì´ë“œì‡¼ ë³´ê¸°";

	/// <summary>
	/// Key: "Label.UnblockWarningBody"
	/// English String: "Are you sure you want to unblock this user?"
	/// </summary>
	public override string LabelUnblockWarningBody => "ë³¸ ì‚¬ìš©ìžë¥¼ ì •ë§ ì°¨ë‹¨ í•´ì œí• ê¹Œìš”?";

	/// <summary>
	/// Key: "Label.UnblockWarningConfirm"
	/// English String: "Unblock"
	/// </summary>
	public override string LabelUnblockWarningConfirm => "ì°¨ë‹¨ í•´ì œ";

	/// <summary>
	/// Key: "Label.Visits"
	/// English String: "Visits"
	/// </summary>
	public override string LabelVisits => "ë°©ë¬¸";

	/// <summary>
	/// Key: "Label.WarningTitle"
	/// English String: "Warning"
	/// </summary>
	public override string LabelWarningTitle => "ì£¼ì˜";

	/// <summary>
	/// Key: "Message.AliasHasError"
	/// English String: "An error has occurred. Please try again later"
	/// </summary>
	public override string MessageAliasHasError => "ì˜¤ë¥˜ê°€ ë°œìƒí–ˆì–´ìš”. ë‚˜ì¤‘ì— ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”";

	/// <summary>
	/// Key: "Message.AliasIsModerated"
	/// English String: "Please avoid using full names or offensive language."
	/// </summary>
	public override string MessageAliasIsModerated => "ì‹¤ëª…ì´ë‚˜ ê³µê²©ì ì¸ ì–¸ì–´ë¥¼ ì‚¬ìš©í•˜ì§€ ë§ˆì„¸ìš”.";

	/// <summary>
	/// Key: "Message.ChangeStatus"
	/// English String: "What are you up to?"
	/// </summary>
	public override string MessageChangeStatus => "ë¬´ì—‡ì„ í•˜ê³  ì‹¶ë‚˜ìš”?";

	/// <summary>
	/// Key: "Message.ErrorBlockLimit"
	/// English String: "Operation failed! You may have blocked too many people."
	/// </summary>
	public override string MessageErrorBlockLimit => "ìž‘ì—… ì‹¤íŒ¨! ì°¨ë‹¨í•œ ì‚¬ìš©ìžê°€ ë„ˆë¬´ ë§Žì•„ìš”.";

	/// <summary>
	/// Key: "Message.ErrorGeneral"
	/// English String: "Something went wrong. Please check back in a few minutes."
	/// </summary>
	public override string MessageErrorGeneral => "ì˜¤ë¥˜ê°€ ë°œìƒí–ˆì–´ìš”. ëª‡ ë¶„ í›„ ë‹¤ì‹œ í™•ì¸í•´ë³´ì„¸ìš”.";

	/// <summary>
	/// Key: "Message.Sharing"
	/// English String: "Sharing..."
	/// </summary>
	public override string MessageSharing => "ê³µìœ  ì¤‘...";

	/// <summary>
	/// Key: "Response.TooManyAttempts"
	/// flood error response
	/// English String: "Too Many Attempts"
	/// </summary>
	public override string ResponseTooManyAttempts => "ì‹œë„ ê°€ëŠ¥ íšŸìˆ˜ë¥¼ ì´ˆê³¼í–ˆìŠµë‹ˆë‹¤";

	public ProfileResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAccept()
	{
		return "ìˆ˜ë½";
	}

	protected override string _GetTemplateForActionAddFriend()
	{
		return "ì¹œêµ¬ ì¶”ê°€";
	}

	protected override string _GetTemplateForActionBlockUser()
	{
		return "ì‚¬ìš©ìž ì°¨ë‹¨";
	}

	protected override string _GetTemplateForActionCancelBlockUser()
	{
		return "ì·¨ì†Œ";
	}

	protected override string _GetTemplateForActionChat()
	{
		return "ì±„íŒ…";
	}

	protected override string _GetTemplateForActionClose()
	{
		return "ë‹«ê¸°";
	}

	protected override string _GetTemplateForActionConfirmBlockUser()
	{
		return "ì°¨ë‹¨";
	}

	protected override string _GetTemplateForActionConfirmUnblockUser()
	{
		return "ì°¨ë‹¨ í•´ì œ";
	}

	protected override string _GetTemplateForActionFavorites()
	{
		return "ì¦ê²¨ì°¾ê¸°";
	}

	protected override string _GetTemplateForActionFollow()
	{
		return "íŒ”ë¡œìš°";
	}

	protected override string _GetTemplateForActionGridView()
	{
		return "ê²©ìž ë³´ê¸°";
	}

	protected override string _GetTemplateForActionImpersonateUser()
	{
		return "ì‚¬ìš©ìž ì‚¬ì¹­";
	}

	protected override string _GetTemplateForActionInventory()
	{
		return "ì¸ë²¤í† ë¦¬";
	}

	protected override string _GetTemplateForActionJoinGame()
	{
		return "ê²Œìž„ ì°¸ê°€";
	}

	protected override string _GetTemplateForActionMessage()
	{
		return "ë©”ì‹œì§€";
	}

	protected override string _GetTemplateForActionPending()
	{
		return "ëŒ€ê¸° ì¤‘";
	}

	protected override string _GetTemplateForActionSave()
	{
		return "ì €ìž¥";
	}

	protected override string _GetTemplateForActionSeeAll()
	{
		return "ì „ì²´ ë³´ê¸°";
	}

	protected override string _GetTemplateForActionSeeLess()
	{
		return "ê°„ëžµížˆ ë³´ê¸°";
	}

	protected override string _GetTemplateForActionSeeMore()
	{
		return "ë” ë³´ê¸°";
	}

	protected override string _GetTemplateForActionSlideshowView()
	{
		return "ìŠ¬ë¼ì´ë“œì‡¼ ë³´ê¸°";
	}

	protected override string _GetTemplateForActionTrade()
	{
		return "ê±°ëž˜";
	}

	protected override string _GetTemplateForActionTradeItems()
	{
		return "ì•„ì´í…œ ê±°ëž˜";
	}

	protected override string _GetTemplateForActionUnblockUser()
	{
		return "ì‚¬ìš©ìž ì°¨ë‹¨ í•´ì œ";
	}

	protected override string _GetTemplateForActionUnfollow()
	{
		return "íŒ”ë¡œìš° ì·¨ì†Œ";
	}

	protected override string _GetTemplateForActionUnfriend()
	{
		return "ì¹œêµ¬ ëŠê¸°";
	}

	protected override string _GetTemplateForActionUpdateStatus()
	{
		return "ìƒíƒœ ì—…ë°ì´íŠ¸";
	}

	protected override string _GetTemplateForDescriptionBlockUserFooter()
	{
		return "ì‚¬ìš©ìžë¥¼ ì°¨ë‹¨í•˜ë©´ í•´ë‹¹ ì‚¬ìš©ìžì™€ ì„œë¡œ ì—°ë½í•  ìˆ˜ ì—†ìŠµë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForDescriptionBlockUserPrompt()
	{
		return "ë³¸ ì‚¬ìš©ìžë¥¼ ì •ë§ ì°¨ë‹¨í• ê¹Œìš”?";
	}

	protected override string _GetTemplateForDescriptionChangeAlias()
	{
		return "ì˜¤ì§ ë‚˜ë§Œ ì´ ì •ë³´ë¥¼ ë³¼ ìˆ˜ ìžˆì–´ìš”";
	}

	protected override string _GetTemplateForDescriptionUnblockUserPrompt()
	{
		return "ë³¸ ì‚¬ìš©ìžë¥¼ ì •ë§ ì°¨ë‹¨ í•´ì œí• ê¹Œìš”?";
	}

	protected override string _GetTemplateForHeadingAboutTab()
	{
		return "ì†Œê°œ";
	}

	protected override string _GetTemplateForHeadingBlockUserTitle()
	{
		return "ì£¼ì˜";
	}

	protected override string _GetTemplateForHeadingCollections()
	{
		return "ì»¬ë ‰ì…˜";
	}

	protected override string _GetTemplateForHeadingCurrentlyWearing()
	{
		return "í˜„ìž¬ ì°©ìš© ì¤‘";
	}

	protected override string _GetTemplateForHeadingFavoriteGames()
	{
		return "ì¦ê²¨ì°¾ê¸°";
	}

	protected override string _GetTemplateForHeadingFriends()
	{
		return "ì¹œêµ¬";
	}

	/// <summary>
	/// Key: "Heading.FriendsNum"
	/// English String: "Friends ({friendsCount})"
	/// </summary>
	public override string HeadingFriendsNum(string friendsCount)
	{
		return $"ì¹œêµ¬ ({friendsCount}ëª…)";
	}

	protected override string _GetTemplateForHeadingFriendsNum()
	{
		return "ì¹œêµ¬ ({friendsCount}ëª…)";
	}

	protected override string _GetTemplateForHeadingGames()
	{
		return "ê²Œìž„";
	}

	protected override string _GetTemplateForHeadingGameTitle()
	{
		return "ê²Œìž„";
	}

	protected override string _GetTemplateForHeadingGroups()
	{
		return "ê·¸ë£¹";
	}

	protected override string _GetTemplateForHeadingPlayerAssetsBadges()
	{
		return "í”Œë ˆì´ì–´ ë°°ì§€";
	}

	protected override string _GetTemplateForHeadingPlayerAssetsClothing()
	{
		return "ë³µìž¥";
	}

	protected override string _GetTemplateForHeadingPlayerAssetsModels()
	{
		return "ëª¨ë¸";
	}

	protected override string _GetTemplateForHeadingPlayerBadge()
	{
		return "í”Œë ˆì´ì–´ ë°°ì§€";
	}

	protected override string _GetTemplateForHeadingProfile()
	{
		return "í”„ë¡œí•„";
	}

	protected override string _GetTemplateForHeadingProfileGroups()
	{
		return "ê·¸ë£¹";
	}

	protected override string _GetTemplateForHeadingRobloxBadge()
	{
		return "Roblox ë°°ì§€";
	}

	protected override string _GetTemplateForHeadingStatistics()
	{
		return "í†µê³„";
	}

	protected override string _GetTemplateForLabelAbout()
	{
		return "ì†Œê°œ";
	}

	protected override string _GetTemplateForLabelAlias()
	{
		return "ë‹‰ë„¤ìž„";
	}

	protected override string _GetTemplateForLabelBlockWarningBody()
	{
		return "ë³¸ ì‚¬ìš©ìžë¥¼ ì •ë§ ì°¨ë‹¨í• ê¹Œìš”?";
	}

	protected override string _GetTemplateForLabelBlockWarningConfirm()
	{
		return "ì°¨ë‹¨";
	}

	protected override string _GetTemplateForLabelBlockWarningFooter()
	{
		return "ì‚¬ìš©ìžë¥¼ ì°¨ë‹¨í•˜ë©´ í•´ë‹¹ ì‚¬ìš©ìžì™€ ì„œë¡œ ì—°ë½í•  ìˆ˜ ì—†ìŠµë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForLabelCancel()
	{
		return "ì·¨ì†Œ";
	}

	protected override string _GetTemplateForLabelChangeAlias()
	{
		return "ë‹‰ë„¤ìž„ ì„¤ì •";
	}

	protected override string _GetTemplateForLabelCreations()
	{
		return "ìž‘í’ˆ";
	}

	protected override string _GetTemplateForLabelFollowers()
	{
		return "íŒ”ë¡œì›Œ";
	}

	protected override string _GetTemplateForLabelFollowing()
	{
		return "íŒ”ë¡œìž‰";
	}

	protected override string _GetTemplateForLabelForumPosts()
	{
		return "í¬ëŸ¼ ê²Œì‹œë¬¼";
	}

	protected override string _GetTemplateForLabelFriends()
	{
		return "ì¹œêµ¬";
	}

	protected override string _GetTemplateForLabelGridView()
	{
		return "ê²©ìž ë³´ê¸°";
	}

	protected override string _GetTemplateForLabelJoinDate()
	{
		return "ê°€ìž… ë‚ ì§œ";
	}

	protected override string _GetTemplateForLabelLoadMore()
	{
		return "ë” ë¶ˆëŸ¬ì˜¤ê¸°";
	}

	protected override string _GetTemplateForLabelMembers()
	{
		return "ë©¤ë²„";
	}

	protected override string _GetTemplateForLabelPastUsername()
	{
		return "ì´ì „ ì‚¬ìš©ìž ì´ë¦„";
	}

	protected override string _GetTemplateForLabelPastUsernames()
	{
		return "ì´ì „ ì‚¬ìš©ìž ì´ë¦„";
	}

	protected override string _GetTemplateForLabelPlaceVisits()
	{
		return "ìž¥ì†Œ ë°©ë¬¸";
	}

	protected override string _GetTemplateForLabelPlaying()
	{
		return "í”Œë ˆì´ ì¤‘";
	}

	/// <summary>
	/// Key: "Label.Quotation"
	/// You only need to localize the quotation mark, e.g. ã€Œ{userStatus}ã€
	/// English String: "\"{userStatus}\""
	/// </summary>
	public override string LabelQuotation(string userStatus)
	{
		return $"'{userStatus}'";
	}

	protected override string _GetTemplateForLabelQuotation()
	{
		return "'{userStatus}'";
	}

	protected override string _GetTemplateForLabelRank()
	{
		return "ë“±ê¸‰";
	}

	protected override string _GetTemplateForLabelReadMore()
	{
		return "ë” ë³´ê¸°";
	}

	protected override string _GetTemplateForLabelReportAbuse()
	{
		return "ì‹ ê³ í•˜ê¸°";
	}

	protected override string _GetTemplateForLabelShowLess()
	{
		return "ê°„ëžµížˆ ë³´ê¸°";
	}

	protected override string _GetTemplateForLabelSlideshowView()
	{
		return "ìŠ¬ë¼ì´ë“œì‡¼ ë³´ê¸°";
	}

	protected override string _GetTemplateForLabelUnblockWarningBody()
	{
		return "ë³¸ ì‚¬ìš©ìžë¥¼ ì •ë§ ì°¨ë‹¨ í•´ì œí• ê¹Œìš”?";
	}

	protected override string _GetTemplateForLabelUnblockWarningConfirm()
	{
		return "ì°¨ë‹¨ í•´ì œ";
	}

	protected override string _GetTemplateForLabelVisits()
	{
		return "ë°©ë¬¸";
	}

	protected override string _GetTemplateForLabelWarningTitle()
	{
		return "ì£¼ì˜";
	}

	protected override string _GetTemplateForMessageAliasHasError()
	{
		return "ì˜¤ë¥˜ê°€ ë°œìƒí–ˆì–´ìš”. ë‚˜ì¤‘ì— ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”";
	}

	protected override string _GetTemplateForMessageAliasIsModerated()
	{
		return "ì‹¤ëª…ì´ë‚˜ ê³µê²©ì ì¸ ì–¸ì–´ë¥¼ ì‚¬ìš©í•˜ì§€ ë§ˆì„¸ìš”.";
	}

	protected override string _GetTemplateForMessageChangeStatus()
	{
		return "ë¬´ì—‡ì„ í•˜ê³  ì‹¶ë‚˜ìš”?";
	}

	protected override string _GetTemplateForMessageErrorBlockLimit()
	{
		return "ìž‘ì—… ì‹¤íŒ¨! ì°¨ë‹¨í•œ ì‚¬ìš©ìžê°€ ë„ˆë¬´ ë§Žì•„ìš”.";
	}

	protected override string _GetTemplateForMessageErrorGeneral()
	{
		return "ì˜¤ë¥˜ê°€ ë°œìƒí–ˆì–´ìš”. ëª‡ ë¶„ í›„ ë‹¤ì‹œ í™•ì¸í•´ë³´ì„¸ìš”.";
	}

	/// <summary>
	/// Key: "Message.NoCreation"
	/// English String: "{username} has no creations."
	/// </summary>
	public override string MessageNoCreation(string username)
	{
		return $"{username}ë‹˜ì˜ ìž‘í’ˆì´ ì—†ìŠµë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForMessageNoCreation()
	{
		return "{username}ë‹˜ì˜ ìž‘í’ˆì´ ì—†ìŠµë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForMessageSharing()
	{
		return "ê³µìœ  ì¤‘...";
	}

	protected override string _GetTemplateForResponseTooManyAttempts()
	{
		return "ì‹œë„ ê°€ëŠ¥ íšŸìˆ˜ë¥¼ ì´ˆê³¼í–ˆìŠµë‹ˆë‹¤";
	}
}


}
