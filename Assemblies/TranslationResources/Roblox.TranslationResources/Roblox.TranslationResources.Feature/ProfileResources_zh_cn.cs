namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides ProfileResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ProfileResources_zh_cn : ProfileResources_en_us, IProfileResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Accept"
	/// English String: "Accept"
	/// </summary>
	public override string ActionAccept => "接受";

	/// <summary>
	/// Key: "Action.AddFriend"
	/// English String: "Add Friend"
	/// </summary>
	public override string ActionAddFriend => "添加好友";

	/// <summary>
	/// Key: "Action.BlockUser"
	/// English String: "Block User"
	/// </summary>
	public override string ActionBlockUser => "屏蔽用户";

	/// <summary>
	/// Key: "Action.CancelBlockUser"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancelBlockUser => "取消";

	/// <summary>
	/// Key: "Action.Chat"
	/// English String: "Chat"
	/// </summary>
	public override string ActionChat => "聊天";

	/// <summary>
	/// Key: "Action.Close"
	/// close modal
	/// English String: "Close"
	/// </summary>
	public override string ActionClose => "关闭";

	/// <summary>
	/// Key: "Action.ConfirmBlockUser"
	/// English String: "Block"
	/// </summary>
	public override string ActionConfirmBlockUser => "屏蔽";

	/// <summary>
	/// Key: "Action.ConfirmUnblockUser"
	/// English String: "Unblock"
	/// </summary>
	public override string ActionConfirmUnblockUser => "取消屏蔽";

	/// <summary>
	/// Key: "Action.Favorites"
	/// English String: "Favorites"
	/// </summary>
	public override string ActionFavorites => "最爱";

	/// <summary>
	/// Key: "Action.Follow"
	/// English String: "Follow"
	/// </summary>
	public override string ActionFollow => "关注";

	/// <summary>
	/// Key: "Action.GridView"
	/// English String: "Grid View"
	/// </summary>
	public override string ActionGridView => "网格视图";

	/// <summary>
	/// Key: "Action.ImpersonateUser"
	/// English String: "Impersonate User"
	/// </summary>
	public override string ActionImpersonateUser => "假冒用户";

	/// <summary>
	/// Key: "Action.Inventory"
	/// English String: "Inventory"
	/// </summary>
	public override string ActionInventory => "道具";

	/// <summary>
	/// Key: "Action.JoinGame"
	/// English String: "Join Game"
	/// </summary>
	public override string ActionJoinGame => "加入游戏";

	/// <summary>
	/// Key: "Action.Message"
	/// English String: "Message"
	/// </summary>
	public override string ActionMessage => "发送信息";

	/// <summary>
	/// Key: "Action.Pending"
	/// English String: "Pending"
	/// </summary>
	public override string ActionPending => "待处理";

	/// <summary>
	/// Key: "Action.Save"
	/// English String: "Save"
	/// </summary>
	public override string ActionSave => "保存";

	/// <summary>
	/// Key: "Action.SeeAll"
	/// English String: "See All"
	/// </summary>
	public override string ActionSeeAll => "查看全部";

	/// <summary>
	/// Key: "Action.SeeLess"
	/// English String: "See Less"
	/// </summary>
	public override string ActionSeeLess => "收起";

	/// <summary>
	/// Key: "Action.SeeMore"
	/// English String: "See More"
	/// </summary>
	public override string ActionSeeMore => "查看更多";

	/// <summary>
	/// Key: "Action.SlideshowView"
	/// English String: "Slideshow View"
	/// </summary>
	public override string ActionSlideshowView => "幻灯片视图";

	/// <summary>
	/// Key: "Action.Trade"
	/// English String: "Trade"
	/// </summary>
	public override string ActionTrade => "交易";

	/// <summary>
	/// Key: "Action.TradeItems"
	/// English String: "Trade Items"
	/// </summary>
	public override string ActionTradeItems => "交易物品";

	/// <summary>
	/// Key: "Action.UnblockUser"
	/// English String: "Unblock User"
	/// </summary>
	public override string ActionUnblockUser => "取消屏蔽用户";

	/// <summary>
	/// Key: "Action.Unfollow"
	/// English String: "Unfollow"
	/// </summary>
	public override string ActionUnfollow => "取消关注";

	/// <summary>
	/// Key: "Action.Unfriend"
	/// English String: "Unfriend"
	/// </summary>
	public override string ActionUnfriend => "解除好友关系";

	/// <summary>
	/// Key: "Action.UpdateStatus"
	/// English String: "Update Status"
	/// </summary>
	public override string ActionUpdateStatus => "更新状态";

	/// <summary>
	/// Key: "Description.BlockUserFooter"
	/// English String: "When you've blocked a user, neither of you can directly contact the other."
	/// </summary>
	public override string DescriptionBlockUserFooter => "当你屏蔽某位用户时，你们将无法直接联系对方。";

	/// <summary>
	/// Key: "Description.BlockUserPrompt"
	/// English String: "Are you sure you want to block this user?"
	/// </summary>
	public override string DescriptionBlockUserPrompt => "是否确定要屏蔽此用户？";

	/// <summary>
	/// Key: "Description.ChangeAlias"
	/// English String: "Only you can see this information"
	/// </summary>
	public override string DescriptionChangeAlias => "只有你可以查看此信息";

	/// <summary>
	/// Key: "Description.UnblockUserPrompt"
	/// English String: "Are you sure you want to unblock this user?"
	/// </summary>
	public override string DescriptionUnblockUserPrompt => "是否确定要取消屏蔽此用户？";

	/// <summary>
	/// Key: "Heading.AboutTab"
	/// this is for the heading under About tab on profile page
	/// English String: "About"
	/// </summary>
	public override string HeadingAboutTab => "关于";

	/// <summary>
	/// Key: "Heading.BlockUserTitle"
	/// English String: "Warning"
	/// </summary>
	public override string HeadingBlockUserTitle => "警告";

	/// <summary>
	/// Key: "Heading.Collections"
	/// English String: "Collections"
	/// </summary>
	public override string HeadingCollections => "收藏";

	/// <summary>
	/// Key: "Heading.CurrentlyWearing"
	/// English String: "Currently Wearing"
	/// </summary>
	public override string HeadingCurrentlyWearing => "当前穿着";

	/// <summary>
	/// Key: "Heading.FavoriteGames"
	/// English String: "Favorites"
	/// </summary>
	public override string HeadingFavoriteGames => "最爱";

	/// <summary>
	/// Key: "Heading.Friends"
	/// English String: "Friends"
	/// </summary>
	public override string HeadingFriends => "好友";

	/// <summary>
	/// Key: "Heading.Games"
	/// English String: "Games"
	/// </summary>
	public override string HeadingGames => "游戏";

	/// <summary>
	/// Key: "Heading.GameTitle"
	/// English String: "Games"
	/// </summary>
	public override string HeadingGameTitle => "游戏";

	/// <summary>
	/// Key: "Heading.Groups"
	/// English String: "Groups"
	/// </summary>
	public override string HeadingGroups => "群组";

	/// <summary>
	/// Key: "Heading.PlayerAssetsBadges"
	/// English String: "Player Badges"
	/// </summary>
	public override string HeadingPlayerAssetsBadges => "玩家徽章";

	/// <summary>
	/// Key: "Heading.PlayerAssetsClothing"
	/// English String: "Clothing"
	/// </summary>
	public override string HeadingPlayerAssetsClothing => "服装";

	/// <summary>
	/// Key: "Heading.PlayerAssetsModels"
	/// English String: "Models"
	/// </summary>
	public override string HeadingPlayerAssetsModels => "模型";

	/// <summary>
	/// Key: "Heading.PlayerBadge"
	/// English String: "Player Badges"
	/// </summary>
	public override string HeadingPlayerBadge => "玩家徽章";

	/// <summary>
	/// Key: "Heading.Profile"
	/// English String: "Profile"
	/// </summary>
	public override string HeadingProfile => "个人资料";

	/// <summary>
	/// Key: "Heading.ProfileGroups"
	/// English String: "Groups"
	/// </summary>
	public override string HeadingProfileGroups => "群组";

	/// <summary>
	/// Key: "Heading.RobloxBadge"
	/// English String: "Roblox Badges"
	/// </summary>
	public override string HeadingRobloxBadge => "Roblox 徽章";

	/// <summary>
	/// Key: "Heading.Statistics"
	/// English String: "Statistics"
	/// </summary>
	public override string HeadingStatistics => "统计资料";

	/// <summary>
	/// Key: "Label.About"
	/// English String: "About"
	/// </summary>
	public override string LabelAbout => "关于";

	/// <summary>
	/// Key: "Label.Alias"
	/// Friends Tag, nickname
	/// English String: "Alias"
	/// </summary>
	public override string LabelAlias => "别名";

	/// <summary>
	/// Key: "Label.BlockWarningBody"
	/// English String: "Are you sure you want to block this user?"
	/// </summary>
	public override string LabelBlockWarningBody => "是否确定要屏蔽此用户？";

	/// <summary>
	/// Key: "Label.BlockWarningConfirm"
	/// English String: "Block"
	/// </summary>
	public override string LabelBlockWarningConfirm => "屏蔽";

	/// <summary>
	/// Key: "Label.BlockWarningFooter"
	/// English String: "When you've blocked a user, neither of you can directly contact the other."
	/// </summary>
	public override string LabelBlockWarningFooter => "当你屏蔽一位用户时，你们将无法直接联系对方。";

	/// <summary>
	/// Key: "Label.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string LabelCancel => "取消";

	/// <summary>
	/// Key: "Label.ChangeAlias"
	/// set nickname
	/// English String: "Set Alias"
	/// </summary>
	public override string LabelChangeAlias => "设置别名";

	/// <summary>
	/// Key: "Label.Creations"
	/// English String: "Creations"
	/// </summary>
	public override string LabelCreations => "作品";

	/// <summary>
	/// Key: "Label.Followers"
	/// English String: "Followers"
	/// </summary>
	public override string LabelFollowers => "粉丝";

	/// <summary>
	/// Key: "Label.Following"
	/// English String: "Following"
	/// </summary>
	public override string LabelFollowing => "关注中";

	/// <summary>
	/// Key: "Label.ForumPosts"
	/// English String: "Forum Posts"
	/// </summary>
	public override string LabelForumPosts => "论坛帖子";

	/// <summary>
	/// Key: "Label.Friends"
	/// English String: "Friends"
	/// </summary>
	public override string LabelFriends => "好友";

	/// <summary>
	/// Key: "Label.GridView"
	/// English String: "Grid View"
	/// </summary>
	public override string LabelGridView => "网格视图";

	/// <summary>
	/// Key: "Label.JoinDate"
	/// English String: "Join Date"
	/// </summary>
	public override string LabelJoinDate => "加入日期";

	/// <summary>
	/// Key: "Label.LoadMore"
	/// English String: "Load More"
	/// </summary>
	public override string LabelLoadMore => "加载更多";

	/// <summary>
	/// Key: "Label.Members"
	/// English String: "Members"
	/// </summary>
	public override string LabelMembers => "会员";

	/// <summary>
	/// Key: "Label.PastUsername"
	/// English String: "Past Usernames"
	/// </summary>
	public override string LabelPastUsername => "曾用名";

	/// <summary>
	/// Key: "Label.PastUsernames"
	/// English String: "Past usernames"
	/// </summary>
	public override string LabelPastUsernames => "曾用名";

	/// <summary>
	/// Key: "Label.PlaceVisits"
	/// English String: "Place Visits"
	/// </summary>
	public override string LabelPlaceVisits => "场景访问次数";

	/// <summary>
	/// Key: "Label.Playing"
	/// English String: "Playing"
	/// </summary>
	public override string LabelPlaying => "正在游戏";

	/// <summary>
	/// Key: "Label.Rank"
	/// English String: "Rank"
	/// </summary>
	public override string LabelRank => "排名";

	/// <summary>
	/// Key: "Label.ReadMore"
	/// English String: "Read More"
	/// </summary>
	public override string LabelReadMore => "阅读更多";

	/// <summary>
	/// Key: "Label.ReportAbuse"
	/// English String: "Report Abuse"
	/// </summary>
	public override string LabelReportAbuse => "报告滥用行为";

	/// <summary>
	/// Key: "Label.ShowLess"
	/// English String: "Show Less"
	/// </summary>
	public override string LabelShowLess => "收起";

	/// <summary>
	/// Key: "Label.SlideshowView"
	/// English String: "Slideshow View"
	/// </summary>
	public override string LabelSlideshowView => "幻灯片视图";

	/// <summary>
	/// Key: "Label.UnblockWarningBody"
	/// English String: "Are you sure you want to unblock this user?"
	/// </summary>
	public override string LabelUnblockWarningBody => "是否确定要取消屏蔽此用户？";

	/// <summary>
	/// Key: "Label.UnblockWarningConfirm"
	/// English String: "Unblock"
	/// </summary>
	public override string LabelUnblockWarningConfirm => "取消屏蔽";

	/// <summary>
	/// Key: "Label.Visits"
	/// English String: "Visits"
	/// </summary>
	public override string LabelVisits => "访问次数";

	/// <summary>
	/// Key: "Label.WarningTitle"
	/// English String: "Warning"
	/// </summary>
	public override string LabelWarningTitle => "警告";

	/// <summary>
	/// Key: "Message.AliasHasError"
	/// English String: "An error has occurred. Please try again later"
	/// </summary>
	public override string MessageAliasHasError => "发生错误，请稍候重试";

	/// <summary>
	/// Key: "Message.AliasIsModerated"
	/// English String: "Please avoid using full names or offensive language."
	/// </summary>
	public override string MessageAliasIsModerated => "请勿使用本名或不当语言。";

	/// <summary>
	/// Key: "Message.ChangeStatus"
	/// English String: "What are you up to?"
	/// </summary>
	public override string MessageChangeStatus => "最近怎么样？";

	/// <summary>
	/// Key: "Message.ErrorBlockLimit"
	/// English String: "Operation failed! You may have blocked too many people."
	/// </summary>
	public override string MessageErrorBlockLimit => "操作失败！你屏蔽的人数可能过多。";

	/// <summary>
	/// Key: "Message.ErrorGeneral"
	/// English String: "Something went wrong. Please check back in a few minutes."
	/// </summary>
	public override string MessageErrorGeneral => "发生错误。请过几分钟再回来查看。";

	/// <summary>
	/// Key: "Message.Sharing"
	/// English String: "Sharing..."
	/// </summary>
	public override string MessageSharing => "正在分享...";

	/// <summary>
	/// Key: "Response.TooManyAttempts"
	/// flood error response
	/// English String: "Too Many Attempts"
	/// </summary>
	public override string ResponseTooManyAttempts => "尝试次数过多";

	public ProfileResources_zh_cn(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAccept()
	{
		return "接受";
	}

	protected override string _GetTemplateForActionAddFriend()
	{
		return "添加好友";
	}

	protected override string _GetTemplateForActionBlockUser()
	{
		return "屏蔽用户";
	}

	protected override string _GetTemplateForActionCancelBlockUser()
	{
		return "取消";
	}

	protected override string _GetTemplateForActionChat()
	{
		return "聊天";
	}

	protected override string _GetTemplateForActionClose()
	{
		return "关闭";
	}

	protected override string _GetTemplateForActionConfirmBlockUser()
	{
		return "屏蔽";
	}

	protected override string _GetTemplateForActionConfirmUnblockUser()
	{
		return "取消屏蔽";
	}

	protected override string _GetTemplateForActionFavorites()
	{
		return "最爱";
	}

	protected override string _GetTemplateForActionFollow()
	{
		return "关注";
	}

	protected override string _GetTemplateForActionGridView()
	{
		return "网格视图";
	}

	protected override string _GetTemplateForActionImpersonateUser()
	{
		return "假冒用户";
	}

	protected override string _GetTemplateForActionInventory()
	{
		return "道具";
	}

	protected override string _GetTemplateForActionJoinGame()
	{
		return "加入游戏";
	}

	protected override string _GetTemplateForActionMessage()
	{
		return "发送信息";
	}

	protected override string _GetTemplateForActionPending()
	{
		return "待处理";
	}

	protected override string _GetTemplateForActionSave()
	{
		return "保存";
	}

	protected override string _GetTemplateForActionSeeAll()
	{
		return "查看全部";
	}

	protected override string _GetTemplateForActionSeeLess()
	{
		return "收起";
	}

	protected override string _GetTemplateForActionSeeMore()
	{
		return "查看更多";
	}

	protected override string _GetTemplateForActionSlideshowView()
	{
		return "幻灯片视图";
	}

	protected override string _GetTemplateForActionTrade()
	{
		return "交易";
	}

	protected override string _GetTemplateForActionTradeItems()
	{
		return "交易物品";
	}

	protected override string _GetTemplateForActionUnblockUser()
	{
		return "取消屏蔽用户";
	}

	protected override string _GetTemplateForActionUnfollow()
	{
		return "取消关注";
	}

	protected override string _GetTemplateForActionUnfriend()
	{
		return "解除好友关系";
	}

	protected override string _GetTemplateForActionUpdateStatus()
	{
		return "更新状态";
	}

	protected override string _GetTemplateForDescriptionBlockUserFooter()
	{
		return "当你屏蔽某位用户时，你们将无法直接联系对方。";
	}

	protected override string _GetTemplateForDescriptionBlockUserPrompt()
	{
		return "是否确定要屏蔽此用户？";
	}

	protected override string _GetTemplateForDescriptionChangeAlias()
	{
		return "只有你可以查看此信息";
	}

	protected override string _GetTemplateForDescriptionUnblockUserPrompt()
	{
		return "是否确定要取消屏蔽此用户？";
	}

	protected override string _GetTemplateForHeadingAboutTab()
	{
		return "关于";
	}

	protected override string _GetTemplateForHeadingBlockUserTitle()
	{
		return "警告";
	}

	protected override string _GetTemplateForHeadingCollections()
	{
		return "收藏";
	}

	protected override string _GetTemplateForHeadingCurrentlyWearing()
	{
		return "当前穿着";
	}

	protected override string _GetTemplateForHeadingFavoriteGames()
	{
		return "最爱";
	}

	protected override string _GetTemplateForHeadingFriends()
	{
		return "好友";
	}

	/// <summary>
	/// Key: "Heading.FriendsNum"
	/// English String: "Friends ({friendsCount})"
	/// </summary>
	public override string HeadingFriendsNum(string friendsCount)
	{
		return $"好友（{friendsCount} 名）";
	}

	protected override string _GetTemplateForHeadingFriendsNum()
	{
		return "好友（{friendsCount} 名）";
	}

	protected override string _GetTemplateForHeadingGames()
	{
		return "游戏";
	}

	protected override string _GetTemplateForHeadingGameTitle()
	{
		return "游戏";
	}

	protected override string _GetTemplateForHeadingGroups()
	{
		return "群组";
	}

	protected override string _GetTemplateForHeadingPlayerAssetsBadges()
	{
		return "玩家徽章";
	}

	protected override string _GetTemplateForHeadingPlayerAssetsClothing()
	{
		return "服装";
	}

	protected override string _GetTemplateForHeadingPlayerAssetsModels()
	{
		return "模型";
	}

	protected override string _GetTemplateForHeadingPlayerBadge()
	{
		return "玩家徽章";
	}

	protected override string _GetTemplateForHeadingProfile()
	{
		return "个人资料";
	}

	protected override string _GetTemplateForHeadingProfileGroups()
	{
		return "群组";
	}

	protected override string _GetTemplateForHeadingRobloxBadge()
	{
		return "Roblox 徽章";
	}

	protected override string _GetTemplateForHeadingStatistics()
	{
		return "统计资料";
	}

	protected override string _GetTemplateForLabelAbout()
	{
		return "关于";
	}

	protected override string _GetTemplateForLabelAlias()
	{
		return "别名";
	}

	protected override string _GetTemplateForLabelBlockWarningBody()
	{
		return "是否确定要屏蔽此用户？";
	}

	protected override string _GetTemplateForLabelBlockWarningConfirm()
	{
		return "屏蔽";
	}

	protected override string _GetTemplateForLabelBlockWarningFooter()
	{
		return "当你屏蔽一位用户时，你们将无法直接联系对方。";
	}

	protected override string _GetTemplateForLabelCancel()
	{
		return "取消";
	}

	protected override string _GetTemplateForLabelChangeAlias()
	{
		return "设置别名";
	}

	protected override string _GetTemplateForLabelCreations()
	{
		return "作品";
	}

	protected override string _GetTemplateForLabelFollowers()
	{
		return "粉丝";
	}

	protected override string _GetTemplateForLabelFollowing()
	{
		return "关注中";
	}

	protected override string _GetTemplateForLabelForumPosts()
	{
		return "论坛帖子";
	}

	protected override string _GetTemplateForLabelFriends()
	{
		return "好友";
	}

	protected override string _GetTemplateForLabelGridView()
	{
		return "网格视图";
	}

	protected override string _GetTemplateForLabelJoinDate()
	{
		return "加入日期";
	}

	protected override string _GetTemplateForLabelLoadMore()
	{
		return "加载更多";
	}

	protected override string _GetTemplateForLabelMembers()
	{
		return "会员";
	}

	protected override string _GetTemplateForLabelPastUsername()
	{
		return "曾用名";
	}

	protected override string _GetTemplateForLabelPastUsernames()
	{
		return "曾用名";
	}

	protected override string _GetTemplateForLabelPlaceVisits()
	{
		return "场景访问次数";
	}

	protected override string _GetTemplateForLabelPlaying()
	{
		return "正在游戏";
	}

	/// <summary>
	/// Key: "Label.Quotation"
	/// You only need to localize the quotation mark, e.g. 「{userStatus}」
	/// English String: "\"{userStatus}\""
	/// </summary>
	public override string LabelQuotation(string userStatus)
	{
		return $"“{userStatus}”";
	}

	protected override string _GetTemplateForLabelQuotation()
	{
		return "“{userStatus}”";
	}

	protected override string _GetTemplateForLabelRank()
	{
		return "排名";
	}

	protected override string _GetTemplateForLabelReadMore()
	{
		return "阅读更多";
	}

	protected override string _GetTemplateForLabelReportAbuse()
	{
		return "报告滥用行为";
	}

	protected override string _GetTemplateForLabelShowLess()
	{
		return "收起";
	}

	protected override string _GetTemplateForLabelSlideshowView()
	{
		return "幻灯片视图";
	}

	protected override string _GetTemplateForLabelUnblockWarningBody()
	{
		return "是否确定要取消屏蔽此用户？";
	}

	protected override string _GetTemplateForLabelUnblockWarningConfirm()
	{
		return "取消屏蔽";
	}

	protected override string _GetTemplateForLabelVisits()
	{
		return "访问次数";
	}

	protected override string _GetTemplateForLabelWarningTitle()
	{
		return "警告";
	}

	protected override string _GetTemplateForMessageAliasHasError()
	{
		return "发生错误，请稍候重试";
	}

	protected override string _GetTemplateForMessageAliasIsModerated()
	{
		return "请勿使用本名或不当语言。";
	}

	protected override string _GetTemplateForMessageChangeStatus()
	{
		return "最近怎么样？";
	}

	protected override string _GetTemplateForMessageErrorBlockLimit()
	{
		return "操作失败！你屏蔽的人数可能过多。";
	}

	protected override string _GetTemplateForMessageErrorGeneral()
	{
		return "发生错误。请过几分钟再回来查看。";
	}

	/// <summary>
	/// Key: "Message.NoCreation"
	/// English String: "{username} has no creations."
	/// </summary>
	public override string MessageNoCreation(string username)
	{
		return $"“{username}”没有作品。";
	}

	protected override string _GetTemplateForMessageNoCreation()
	{
		return "“{username}”没有作品。";
	}

	protected override string _GetTemplateForMessageSharing()
	{
		return "正在分享...";
	}

	protected override string _GetTemplateForResponseTooManyAttempts()
	{
		return "尝试次数过多";
	}
}
