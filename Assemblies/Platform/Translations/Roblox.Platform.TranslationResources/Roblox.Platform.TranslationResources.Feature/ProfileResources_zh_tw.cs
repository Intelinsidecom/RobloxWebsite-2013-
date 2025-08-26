namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides ProfileResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ProfileResources_zh_tw : ProfileResources_en_us, IProfileResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Accept"
	/// English String: "Accept"
	/// </summary>
	public override string ActionAccept => "æŽ¥å—";

	/// <summary>
	/// Key: "Action.AddFriend"
	/// English String: "Add Friend"
	/// </summary>
	public override string ActionAddFriend => "æ–°å¢žå¥½å‹";

	/// <summary>
	/// Key: "Action.BlockUser"
	/// English String: "Block User"
	/// </summary>
	public override string ActionBlockUser => "å°éŽ–ä½¿ç”¨è€…";

	/// <summary>
	/// Key: "Action.CancelBlockUser"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancelBlockUser => "å–æ¶ˆ";

	/// <summary>
	/// Key: "Action.Chat"
	/// English String: "Chat"
	/// </summary>
	public override string ActionChat => "èŠå¤©";

	/// <summary>
	/// Key: "Action.Close"
	/// close modal
	/// English String: "Close"
	/// </summary>
	public override string ActionClose => "é—œé–‰";

	/// <summary>
	/// Key: "Action.ConfirmBlockUser"
	/// English String: "Block"
	/// </summary>
	public override string ActionConfirmBlockUser => "å°éŽ–";

	/// <summary>
	/// Key: "Action.ConfirmUnblockUser"
	/// English String: "Unblock"
	/// </summary>
	public override string ActionConfirmUnblockUser => "è§£é™¤å°éŽ–";

	/// <summary>
	/// Key: "Action.Favorites"
	/// English String: "Favorites"
	/// </summary>
	public override string ActionFavorites => "æœ€æ„›";

	/// <summary>
	/// Key: "Action.Follow"
	/// English String: "Follow"
	/// </summary>
	public override string ActionFollow => "è¿½è¹¤";

	/// <summary>
	/// Key: "Action.GridView"
	/// English String: "Grid View"
	/// </summary>
	public override string ActionGridView => "æ–¹æ ¼æª¢è¦–";

	/// <summary>
	/// Key: "Action.ImpersonateUser"
	/// English String: "Impersonate User"
	/// </summary>
	public override string ActionImpersonateUser => "å‡å†’ä½¿ç”¨è€…";

	/// <summary>
	/// Key: "Action.Inventory"
	/// English String: "Inventory"
	/// </summary>
	public override string ActionInventory => "é“å…·æ¬„";

	/// <summary>
	/// Key: "Action.JoinGame"
	/// English String: "Join Game"
	/// </summary>
	public override string ActionJoinGame => "åŠ å…¥éŠæˆ²";

	/// <summary>
	/// Key: "Action.Message"
	/// English String: "Message"
	/// </summary>
	public override string ActionMessage => "å‚³é€è¨Šæ¯";

	/// <summary>
	/// Key: "Action.Pending"
	/// English String: "Pending"
	/// </summary>
	public override string ActionPending => "å¾…è™•ç†";

	/// <summary>
	/// Key: "Action.Save"
	/// English String: "Save"
	/// </summary>
	public override string ActionSave => "å„²å­˜";

	/// <summary>
	/// Key: "Action.SeeAll"
	/// English String: "See All"
	/// </summary>
	public override string ActionSeeAll => "æŸ¥çœ‹å…¨éƒ¨";

	/// <summary>
	/// Key: "Action.SeeLess"
	/// English String: "See Less"
	/// </summary>
	public override string ActionSeeLess => "çœ‹æ›´å°‘";

	/// <summary>
	/// Key: "Action.SeeMore"
	/// English String: "See More"
	/// </summary>
	public override string ActionSeeMore => "æŸ¥çœ‹æ›´å¤š";

	/// <summary>
	/// Key: "Action.SlideshowView"
	/// English String: "Slideshow View"
	/// </summary>
	public override string ActionSlideshowView => "æŠ•å½±ç‰‡æª¢è¦–";

	/// <summary>
	/// Key: "Action.Trade"
	/// English String: "Trade"
	/// </summary>
	public override string ActionTrade => "äº¤æ˜“";

	/// <summary>
	/// Key: "Action.TradeItems"
	/// English String: "Trade Items"
	/// </summary>
	public override string ActionTradeItems => "äº¤æ›é“å…·";

	/// <summary>
	/// Key: "Action.UnblockUser"
	/// English String: "Unblock User"
	/// </summary>
	public override string ActionUnblockUser => "è§£é™¤å°éŽ–ä½¿ç”¨è€…";

	/// <summary>
	/// Key: "Action.Unfollow"
	/// English String: "Unfollow"
	/// </summary>
	public override string ActionUnfollow => "å–æ¶ˆè¿½è¹¤";

	/// <summary>
	/// Key: "Action.Unfriend"
	/// English String: "Unfriend"
	/// </summary>
	public override string ActionUnfriend => "åˆªé™¤å¥½å‹";

	/// <summary>
	/// Key: "Action.UpdateStatus"
	/// English String: "Update Status"
	/// </summary>
	public override string ActionUpdateStatus => "æ›´æ–°ç‹€æ…‹";

	/// <summary>
	/// Key: "Description.BlockUserFooter"
	/// English String: "When you've blocked a user, neither of you can directly contact the other."
	/// </summary>
	public override string DescriptionBlockUserFooter => "ç•¶æ‚¨å°éŽ–ä¸€ä½ä½¿ç”¨è€…æ™‚ï¼Œä½ å€‘å°‡ç„¡æ³•ç›´æŽ¥è¯çµ¡å½¼æ­¤ã€‚";

	/// <summary>
	/// Key: "Description.BlockUserPrompt"
	/// English String: "Are you sure you want to block this user?"
	/// </summary>
	public override string DescriptionBlockUserPrompt => "ç¢ºå®šå°éŽ–æ­¤ä½¿ç”¨è€…ï¼Ÿ";

	/// <summary>
	/// Key: "Description.ChangeAlias"
	/// English String: "Only you can see this information"
	/// </summary>
	public override string DescriptionChangeAlias => "åªæœ‰æ‚¨å¯ä»¥çœ‹åˆ°æ­¤è³‡è¨Š";

	/// <summary>
	/// Key: "Description.UnblockUserPrompt"
	/// English String: "Are you sure you want to unblock this user?"
	/// </summary>
	public override string DescriptionUnblockUserPrompt => "ç¢ºå®šè§£é™¤å°éŽ–æ­¤ä½¿ç”¨è€…ï¼Ÿ";

	/// <summary>
	/// Key: "Heading.AboutTab"
	/// this is for the heading under About tab on profile page
	/// English String: "About"
	/// </summary>
	public override string HeadingAboutTab => "ä»‹ç´¹";

	/// <summary>
	/// Key: "Heading.BlockUserTitle"
	/// English String: "Warning"
	/// </summary>
	public override string HeadingBlockUserTitle => "è­¦å‘Š";

	/// <summary>
	/// Key: "Heading.Collections"
	/// English String: "Collections"
	/// </summary>
	public override string HeadingCollections => "æ”¶è—";

	/// <summary>
	/// Key: "Heading.CurrentlyWearing"
	/// English String: "Currently Wearing"
	/// </summary>
	public override string HeadingCurrentlyWearing => "ç›®å‰ç©¿æˆ´";

	/// <summary>
	/// Key: "Heading.FavoriteGames"
	/// English String: "Favorites"
	/// </summary>
	public override string HeadingFavoriteGames => "æœ€æ„›";

	/// <summary>
	/// Key: "Heading.Friends"
	/// English String: "Friends"
	/// </summary>
	public override string HeadingFriends => "å¥½å‹";

	/// <summary>
	/// Key: "Heading.Games"
	/// English String: "Games"
	/// </summary>
	public override string HeadingGames => "éŠæˆ²";

	/// <summary>
	/// Key: "Heading.GameTitle"
	/// English String: "Games"
	/// </summary>
	public override string HeadingGameTitle => "éŠæˆ²";

	/// <summary>
	/// Key: "Heading.Groups"
	/// English String: "Groups"
	/// </summary>
	public override string HeadingGroups => "ç¾¤çµ„";

	/// <summary>
	/// Key: "Heading.PlayerAssetsBadges"
	/// English String: "Player Badges"
	/// </summary>
	public override string HeadingPlayerAssetsBadges => "éŠæˆ²å¾½ç« ";

	/// <summary>
	/// Key: "Heading.PlayerAssetsClothing"
	/// English String: "Clothing"
	/// </summary>
	public override string HeadingPlayerAssetsClothing => "è¡£ç‰©";

	/// <summary>
	/// Key: "Heading.PlayerAssetsModels"
	/// English String: "Models"
	/// </summary>
	public override string HeadingPlayerAssetsModels => "æ¨¡åž‹";

	/// <summary>
	/// Key: "Heading.PlayerBadge"
	/// English String: "Player Badges"
	/// </summary>
	public override string HeadingPlayerBadge => "éŠæˆ²å¾½ç« ";

	/// <summary>
	/// Key: "Heading.Profile"
	/// English String: "Profile"
	/// </summary>
	public override string HeadingProfile => "å€‹äººæª”æ¡ˆ";

	/// <summary>
	/// Key: "Heading.ProfileGroups"
	/// English String: "Groups"
	/// </summary>
	public override string HeadingProfileGroups => "ç¾¤çµ„";

	/// <summary>
	/// Key: "Heading.RobloxBadge"
	/// English String: "Roblox Badges"
	/// </summary>
	public override string HeadingRobloxBadge => "Roblox å¾½ç« ";

	/// <summary>
	/// Key: "Heading.Statistics"
	/// English String: "Statistics"
	/// </summary>
	public override string HeadingStatistics => "æ•¸æ“š";

	/// <summary>
	/// Key: "Label.About"
	/// English String: "About"
	/// </summary>
	public override string LabelAbout => "ä»‹ç´¹";

	/// <summary>
	/// Key: "Label.Alias"
	/// Friends Tag, nickname
	/// English String: "Alias"
	/// </summary>
	public override string LabelAlias => "æš±ç¨±";

	/// <summary>
	/// Key: "Label.BlockWarningBody"
	/// English String: "Are you sure you want to block this user?"
	/// </summary>
	public override string LabelBlockWarningBody => "ç¢ºå®šå°éŽ–æ­¤ä½¿ç”¨è€…ï¼Ÿ";

	/// <summary>
	/// Key: "Label.BlockWarningConfirm"
	/// English String: "Block"
	/// </summary>
	public override string LabelBlockWarningConfirm => "å°éŽ–";

	/// <summary>
	/// Key: "Label.BlockWarningFooter"
	/// English String: "When you've blocked a user, neither of you can directly contact the other."
	/// </summary>
	public override string LabelBlockWarningFooter => "ç•¶æ‚¨å°éŽ–ä¸€ä½ä½¿ç”¨è€…æ™‚ï¼Œä½ å€‘å°‡ç„¡æ³•ç›´æŽ¥è¯çµ¡å½¼æ­¤ã€‚";

	/// <summary>
	/// Key: "Label.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string LabelCancel => "å–æ¶ˆ";

	/// <summary>
	/// Key: "Label.ChangeAlias"
	/// set nickname
	/// English String: "Set Alias"
	/// </summary>
	public override string LabelChangeAlias => "è¨­å®šæš±ç¨±";

	/// <summary>
	/// Key: "Label.Creations"
	/// English String: "Creations"
	/// </summary>
	public override string LabelCreations => "ä½œå“";

	/// <summary>
	/// Key: "Label.Followers"
	/// English String: "Followers"
	/// </summary>
	public override string LabelFollowers => "è¿½è¹¤è€…";

	/// <summary>
	/// Key: "Label.Following"
	/// English String: "Following"
	/// </summary>
	public override string LabelFollowing => "è¿½è¹¤ä¸­";

	/// <summary>
	/// Key: "Label.ForumPosts"
	/// English String: "Forum Posts"
	/// </summary>
	public override string LabelForumPosts => "è«–å£‡è²¼æ–‡";

	/// <summary>
	/// Key: "Label.Friends"
	/// English String: "Friends"
	/// </summary>
	public override string LabelFriends => "å¥½å‹";

	/// <summary>
	/// Key: "Label.GridView"
	/// English String: "Grid View"
	/// </summary>
	public override string LabelGridView => "æ–¹æ ¼æª¢è¦–";

	/// <summary>
	/// Key: "Label.JoinDate"
	/// English String: "Join Date"
	/// </summary>
	public override string LabelJoinDate => "åŠ å…¥æ—¥æœŸ";

	/// <summary>
	/// Key: "Label.LoadMore"
	/// English String: "Load More"
	/// </summary>
	public override string LabelLoadMore => "è¼‰å…¥æ›´å¤š";

	/// <summary>
	/// Key: "Label.Members"
	/// English String: "Members"
	/// </summary>
	public override string LabelMembers => "æœƒå“¡";

	/// <summary>
	/// Key: "Label.PastUsername"
	/// English String: "Past Usernames"
	/// </summary>
	public override string LabelPastUsername => "ä¹‹å‰çš„ä½¿ç”¨è€…åç¨±";

	/// <summary>
	/// Key: "Label.PastUsernames"
	/// English String: "Past usernames"
	/// </summary>
	public override string LabelPastUsernames => "ä¹‹å‰çš„ä½¿ç”¨è€…åç¨±";

	/// <summary>
	/// Key: "Label.PlaceVisits"
	/// English String: "Place Visits"
	/// </summary>
	public override string LabelPlaceVisits => "ç©ºé–“é€ è¨ªæ¬¡æ•¸";

	/// <summary>
	/// Key: "Label.Playing"
	/// English String: "Playing"
	/// </summary>
	public override string LabelPlaying => "æ­£åœ¨çŽ©";

	/// <summary>
	/// Key: "Label.Rank"
	/// English String: "Rank"
	/// </summary>
	public override string LabelRank => "éšŽç´š";

	/// <summary>
	/// Key: "Label.ReadMore"
	/// English String: "Read More"
	/// </summary>
	public override string LabelReadMore => "é–±è®€æ›´å¤š";

	/// <summary>
	/// Key: "Label.ReportAbuse"
	/// English String: "Report Abuse"
	/// </summary>
	public override string LabelReportAbuse => "æª¢èˆ‰æ¿«ç”¨";

	/// <summary>
	/// Key: "Label.ShowLess"
	/// English String: "Show Less"
	/// </summary>
	public override string LabelShowLess => "é¡¯ç¤ºæ›´å°‘";

	/// <summary>
	/// Key: "Label.SlideshowView"
	/// English String: "Slideshow View"
	/// </summary>
	public override string LabelSlideshowView => "æŠ•å½±ç‰‡æª¢è¦–";

	/// <summary>
	/// Key: "Label.UnblockWarningBody"
	/// English String: "Are you sure you want to unblock this user?"
	/// </summary>
	public override string LabelUnblockWarningBody => "ç¢ºå®šè§£é™¤å°éŽ–æ­¤ä½¿ç”¨è€…ï¼Ÿ";

	/// <summary>
	/// Key: "Label.UnblockWarningConfirm"
	/// English String: "Unblock"
	/// </summary>
	public override string LabelUnblockWarningConfirm => "è§£é™¤å°éŽ–";

	/// <summary>
	/// Key: "Label.Visits"
	/// English String: "Visits"
	/// </summary>
	public override string LabelVisits => "é€ è¨ªæ¬¡æ•¸";

	/// <summary>
	/// Key: "Label.WarningTitle"
	/// English String: "Warning"
	/// </summary>
	public override string LabelWarningTitle => "è­¦å‘Š";

	/// <summary>
	/// Key: "Message.AliasHasError"
	/// English String: "An error has occurred. Please try again later"
	/// </summary>
	public override string MessageAliasHasError => "ç™¼ç”ŸéŒ¯èª¤ï¼Œè«‹ç¨å¾Œå†è©¦";

	/// <summary>
	/// Key: "Message.AliasIsModerated"
	/// English String: "Please avoid using full names or offensive language."
	/// </summary>
	public override string MessageAliasIsModerated => "è«‹å‹¿ä½¿ç”¨æœ¬åæˆ–ä¸é›…èªžè¨€ã€‚";

	/// <summary>
	/// Key: "Message.ChangeStatus"
	/// English String: "What are you up to?"
	/// </summary>
	public override string MessageChangeStatus => "æ‚¨åœ¨åšä»€éº¼ï¼Ÿ";

	/// <summary>
	/// Key: "Message.ErrorBlockLimit"
	/// English String: "Operation failed! You may have blocked too many people."
	/// </summary>
	public override string MessageErrorBlockLimit => "ç„¡æ³•ä½œæ¥­ï¼Œæ‚¨å°éŽ–çš„ä½¿ç”¨è€…äººæ•¸å¯èƒ½éŽå¤šã€‚";

	/// <summary>
	/// Key: "Message.ErrorGeneral"
	/// English String: "Something went wrong. Please check back in a few minutes."
	/// </summary>
	public override string MessageErrorGeneral => "ç™¼ç”ŸéŒ¯èª¤ï¼Œè«‹ç¨å¾Œå†å›žä¾†æŸ¥çœ‹ã€‚";

	/// <summary>
	/// Key: "Message.Sharing"
	/// English String: "Sharing..."
	/// </summary>
	public override string MessageSharing => "æ­£åœ¨åˆ†äº«â€¦";

	/// <summary>
	/// Key: "Response.TooManyAttempts"
	/// flood error response
	/// English String: "Too Many Attempts"
	/// </summary>
	public override string ResponseTooManyAttempts => "å˜—è©¦æ¬¡æ•¸éŽå¤š";

	public ProfileResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAccept()
	{
		return "æŽ¥å—";
	}

	protected override string _GetTemplateForActionAddFriend()
	{
		return "æ–°å¢žå¥½å‹";
	}

	protected override string _GetTemplateForActionBlockUser()
	{
		return "å°éŽ–ä½¿ç”¨è€…";
	}

	protected override string _GetTemplateForActionCancelBlockUser()
	{
		return "å–æ¶ˆ";
	}

	protected override string _GetTemplateForActionChat()
	{
		return "èŠå¤©";
	}

	protected override string _GetTemplateForActionClose()
	{
		return "é—œé–‰";
	}

	protected override string _GetTemplateForActionConfirmBlockUser()
	{
		return "å°éŽ–";
	}

	protected override string _GetTemplateForActionConfirmUnblockUser()
	{
		return "è§£é™¤å°éŽ–";
	}

	protected override string _GetTemplateForActionFavorites()
	{
		return "æœ€æ„›";
	}

	protected override string _GetTemplateForActionFollow()
	{
		return "è¿½è¹¤";
	}

	protected override string _GetTemplateForActionGridView()
	{
		return "æ–¹æ ¼æª¢è¦–";
	}

	protected override string _GetTemplateForActionImpersonateUser()
	{
		return "å‡å†’ä½¿ç”¨è€…";
	}

	protected override string _GetTemplateForActionInventory()
	{
		return "é“å…·æ¬„";
	}

	protected override string _GetTemplateForActionJoinGame()
	{
		return "åŠ å…¥éŠæˆ²";
	}

	protected override string _GetTemplateForActionMessage()
	{
		return "å‚³é€è¨Šæ¯";
	}

	protected override string _GetTemplateForActionPending()
	{
		return "å¾…è™•ç†";
	}

	protected override string _GetTemplateForActionSave()
	{
		return "å„²å­˜";
	}

	protected override string _GetTemplateForActionSeeAll()
	{
		return "æŸ¥çœ‹å…¨éƒ¨";
	}

	protected override string _GetTemplateForActionSeeLess()
	{
		return "çœ‹æ›´å°‘";
	}

	protected override string _GetTemplateForActionSeeMore()
	{
		return "æŸ¥çœ‹æ›´å¤š";
	}

	protected override string _GetTemplateForActionSlideshowView()
	{
		return "æŠ•å½±ç‰‡æª¢è¦–";
	}

	protected override string _GetTemplateForActionTrade()
	{
		return "äº¤æ˜“";
	}

	protected override string _GetTemplateForActionTradeItems()
	{
		return "äº¤æ›é“å…·";
	}

	protected override string _GetTemplateForActionUnblockUser()
	{
		return "è§£é™¤å°éŽ–ä½¿ç”¨è€…";
	}

	protected override string _GetTemplateForActionUnfollow()
	{
		return "å–æ¶ˆè¿½è¹¤";
	}

	protected override string _GetTemplateForActionUnfriend()
	{
		return "åˆªé™¤å¥½å‹";
	}

	protected override string _GetTemplateForActionUpdateStatus()
	{
		return "æ›´æ–°ç‹€æ…‹";
	}

	protected override string _GetTemplateForDescriptionBlockUserFooter()
	{
		return "ç•¶æ‚¨å°éŽ–ä¸€ä½ä½¿ç”¨è€…æ™‚ï¼Œä½ å€‘å°‡ç„¡æ³•ç›´æŽ¥è¯çµ¡å½¼æ­¤ã€‚";
	}

	protected override string _GetTemplateForDescriptionBlockUserPrompt()
	{
		return "ç¢ºå®šå°éŽ–æ­¤ä½¿ç”¨è€…ï¼Ÿ";
	}

	protected override string _GetTemplateForDescriptionChangeAlias()
	{
		return "åªæœ‰æ‚¨å¯ä»¥çœ‹åˆ°æ­¤è³‡è¨Š";
	}

	protected override string _GetTemplateForDescriptionUnblockUserPrompt()
	{
		return "ç¢ºå®šè§£é™¤å°éŽ–æ­¤ä½¿ç”¨è€…ï¼Ÿ";
	}

	protected override string _GetTemplateForHeadingAboutTab()
	{
		return "ä»‹ç´¹";
	}

	protected override string _GetTemplateForHeadingBlockUserTitle()
	{
		return "è­¦å‘Š";
	}

	protected override string _GetTemplateForHeadingCollections()
	{
		return "æ”¶è—";
	}

	protected override string _GetTemplateForHeadingCurrentlyWearing()
	{
		return "ç›®å‰ç©¿æˆ´";
	}

	protected override string _GetTemplateForHeadingFavoriteGames()
	{
		return "æœ€æ„›";
	}

	protected override string _GetTemplateForHeadingFriends()
	{
		return "å¥½å‹";
	}

	/// <summary>
	/// Key: "Heading.FriendsNum"
	/// English String: "Friends ({friendsCount})"
	/// </summary>
	public override string HeadingFriendsNum(string friendsCount)
	{
		return $"å¥½å‹ï¼ˆ{friendsCount}ï¼‰";
	}

	protected override string _GetTemplateForHeadingFriendsNum()
	{
		return "å¥½å‹ï¼ˆ{friendsCount}ï¼‰";
	}

	protected override string _GetTemplateForHeadingGames()
	{
		return "éŠæˆ²";
	}

	protected override string _GetTemplateForHeadingGameTitle()
	{
		return "éŠæˆ²";
	}

	protected override string _GetTemplateForHeadingGroups()
	{
		return "ç¾¤çµ„";
	}

	protected override string _GetTemplateForHeadingPlayerAssetsBadges()
	{
		return "éŠæˆ²å¾½ç« ";
	}

	protected override string _GetTemplateForHeadingPlayerAssetsClothing()
	{
		return "è¡£ç‰©";
	}

	protected override string _GetTemplateForHeadingPlayerAssetsModels()
	{
		return "æ¨¡åž‹";
	}

	protected override string _GetTemplateForHeadingPlayerBadge()
	{
		return "éŠæˆ²å¾½ç« ";
	}

	protected override string _GetTemplateForHeadingProfile()
	{
		return "å€‹äººæª”æ¡ˆ";
	}

	protected override string _GetTemplateForHeadingProfileGroups()
	{
		return "ç¾¤çµ„";
	}

	protected override string _GetTemplateForHeadingRobloxBadge()
	{
		return "Roblox å¾½ç« ";
	}

	protected override string _GetTemplateForHeadingStatistics()
	{
		return "æ•¸æ“š";
	}

	protected override string _GetTemplateForLabelAbout()
	{
		return "ä»‹ç´¹";
	}

	protected override string _GetTemplateForLabelAlias()
	{
		return "æš±ç¨±";
	}

	protected override string _GetTemplateForLabelBlockWarningBody()
	{
		return "ç¢ºå®šå°éŽ–æ­¤ä½¿ç”¨è€…ï¼Ÿ";
	}

	protected override string _GetTemplateForLabelBlockWarningConfirm()
	{
		return "å°éŽ–";
	}

	protected override string _GetTemplateForLabelBlockWarningFooter()
	{
		return "ç•¶æ‚¨å°éŽ–ä¸€ä½ä½¿ç”¨è€…æ™‚ï¼Œä½ å€‘å°‡ç„¡æ³•ç›´æŽ¥è¯çµ¡å½¼æ­¤ã€‚";
	}

	protected override string _GetTemplateForLabelCancel()
	{
		return "å–æ¶ˆ";
	}

	protected override string _GetTemplateForLabelChangeAlias()
	{
		return "è¨­å®šæš±ç¨±";
	}

	protected override string _GetTemplateForLabelCreations()
	{
		return "ä½œå“";
	}

	protected override string _GetTemplateForLabelFollowers()
	{
		return "è¿½è¹¤è€…";
	}

	protected override string _GetTemplateForLabelFollowing()
	{
		return "è¿½è¹¤ä¸­";
	}

	protected override string _GetTemplateForLabelForumPosts()
	{
		return "è«–å£‡è²¼æ–‡";
	}

	protected override string _GetTemplateForLabelFriends()
	{
		return "å¥½å‹";
	}

	protected override string _GetTemplateForLabelGridView()
	{
		return "æ–¹æ ¼æª¢è¦–";
	}

	protected override string _GetTemplateForLabelJoinDate()
	{
		return "åŠ å…¥æ—¥æœŸ";
	}

	protected override string _GetTemplateForLabelLoadMore()
	{
		return "è¼‰å…¥æ›´å¤š";
	}

	protected override string _GetTemplateForLabelMembers()
	{
		return "æœƒå“¡";
	}

	protected override string _GetTemplateForLabelPastUsername()
	{
		return "ä¹‹å‰çš„ä½¿ç”¨è€…åç¨±";
	}

	protected override string _GetTemplateForLabelPastUsernames()
	{
		return "ä¹‹å‰çš„ä½¿ç”¨è€…åç¨±";
	}

	protected override string _GetTemplateForLabelPlaceVisits()
	{
		return "ç©ºé–“é€ è¨ªæ¬¡æ•¸";
	}

	protected override string _GetTemplateForLabelPlaying()
	{
		return "æ­£åœ¨çŽ©";
	}

	/// <summary>
	/// Key: "Label.Quotation"
	/// You only need to localize the quotation mark, e.g. ã€Œ{userStatus}ã€
	/// English String: "\"{userStatus}\""
	/// </summary>
	public override string LabelQuotation(string userStatus)
	{
		return $"ã€Œ{userStatus}ã€";
	}

	protected override string _GetTemplateForLabelQuotation()
	{
		return "ã€Œ{userStatus}ã€";
	}

	protected override string _GetTemplateForLabelRank()
	{
		return "éšŽç´š";
	}

	protected override string _GetTemplateForLabelReadMore()
	{
		return "é–±è®€æ›´å¤š";
	}

	protected override string _GetTemplateForLabelReportAbuse()
	{
		return "æª¢èˆ‰æ¿«ç”¨";
	}

	protected override string _GetTemplateForLabelShowLess()
	{
		return "é¡¯ç¤ºæ›´å°‘";
	}

	protected override string _GetTemplateForLabelSlideshowView()
	{
		return "æŠ•å½±ç‰‡æª¢è¦–";
	}

	protected override string _GetTemplateForLabelUnblockWarningBody()
	{
		return "ç¢ºå®šè§£é™¤å°éŽ–æ­¤ä½¿ç”¨è€…ï¼Ÿ";
	}

	protected override string _GetTemplateForLabelUnblockWarningConfirm()
	{
		return "è§£é™¤å°éŽ–";
	}

	protected override string _GetTemplateForLabelVisits()
	{
		return "é€ è¨ªæ¬¡æ•¸";
	}

	protected override string _GetTemplateForLabelWarningTitle()
	{
		return "è­¦å‘Š";
	}

	protected override string _GetTemplateForMessageAliasHasError()
	{
		return "ç™¼ç”ŸéŒ¯èª¤ï¼Œè«‹ç¨å¾Œå†è©¦";
	}

	protected override string _GetTemplateForMessageAliasIsModerated()
	{
		return "è«‹å‹¿ä½¿ç”¨æœ¬åæˆ–ä¸é›…èªžè¨€ã€‚";
	}

	protected override string _GetTemplateForMessageChangeStatus()
	{
		return "æ‚¨åœ¨åšä»€éº¼ï¼Ÿ";
	}

	protected override string _GetTemplateForMessageErrorBlockLimit()
	{
		return "ç„¡æ³•ä½œæ¥­ï¼Œæ‚¨å°éŽ–çš„ä½¿ç”¨è€…äººæ•¸å¯èƒ½éŽå¤šã€‚";
	}

	protected override string _GetTemplateForMessageErrorGeneral()
	{
		return "ç™¼ç”ŸéŒ¯èª¤ï¼Œè«‹ç¨å¾Œå†å›žä¾†æŸ¥çœ‹ã€‚";
	}

	/// <summary>
	/// Key: "Message.NoCreation"
	/// English String: "{username} has no creations."
	/// </summary>
	public override string MessageNoCreation(string username)
	{
		return $"{username} æ²’æœ‰ä½œå“ã€‚";
	}

	protected override string _GetTemplateForMessageNoCreation()
	{
		return "{username} æ²’æœ‰ä½œå“ã€‚";
	}

	protected override string _GetTemplateForMessageSharing()
	{
		return "æ­£åœ¨åˆ†äº«â€¦";
	}

	protected override string _GetTemplateForResponseTooManyAttempts()
	{
		return "å˜—è©¦æ¬¡æ•¸éŽå¤š";
	}
}


}
