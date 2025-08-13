namespace Roblox.TranslationResources.Notifications;

/// <summary>
/// This class overrides NotificationStreamResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class NotificationStreamResources_zh_cn : NotificationStreamResources_en_us, INotificationStreamResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Accept"
	/// English String: "Accept"
	/// </summary>
	public override string ActionAccept => "接受";

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "取消";

	/// <summary>
	/// Key: "Action.Chat"
	/// English String: "Chat"
	/// </summary>
	public override string ActionChat => "聊天";

	/// <summary>
	/// Key: "Action.Ignore"
	/// English String: "Ignore"
	/// </summary>
	public override string ActionIgnore => "忽略";

	/// <summary>
	/// Key: "Action.Play"
	/// Label for button to launch game.
	/// English String: "Play"
	/// </summary>
	public override string ActionPlay => "开始游戏";

	/// <summary>
	/// Key: "Action.ReportAbuse"
	/// Label for link to report a game update message
	/// English String: "Report Abuse"
	/// </summary>
	public override string ActionReportAbuse => "报告滥用行为";

	/// <summary>
	/// Key: "Action.Undo"
	/// Label for Undo link to reverse the unfollow action
	/// English String: "Undo"
	/// </summary>
	public override string ActionUndo => "撤消";

	/// <summary>
	/// Key: "Action.View"
	/// English String: "View"
	/// </summary>
	public override string ActionView => "查看";

	/// <summary>
	/// Key: "Action.ViewAll"
	/// English String: "View All"
	/// </summary>
	public override string ActionViewAll => "查看所有";

	/// <summary>
	/// Key: "Heading.BackToAllNotifications"
	/// Heading displayed in game updates view, containing back link to notifications main view.
	/// English String: "All Notifications"
	/// </summary>
	public override string HeadingBackToAllNotifications => "所有通知";

	/// <summary>
	/// Key: "Label.NoNetworkConnectionText"
	/// English String: "Connecting..."
	/// </summary>
	public override string LabelNoNetworkConnectionText => "正在连接...";

	/// <summary>
	/// Key: "Label.NoNotifications"
	/// English String: "No Notifications"
	/// </summary>
	public override string LabelNoNotifications => "无通知";

	/// <summary>
	/// Key: "Label.Notifications"
	/// English String: "Notifications"
	/// </summary>
	public override string LabelNotifications => "通知";

	/// <summary>
	/// Key: "Label.Settings"
	/// English String: "Settings"
	/// </summary>
	public override string LabelSettings => "设置";

	/// <summary>
	/// Key: "Message.GameNotPlayableOnDevice"
	/// Message displayed on game update card when the game is not playable on the device type.
	/// English String: "Not playable on this device"
	/// </summary>
	public override string MessageGameNotPlayableOnDevice => "在此设备上不可玩";

	/// <summary>
	/// Key: "Message.TooManyFriendsOther"
	/// English String: "That user already has the max number of friends."
	/// </summary>
	public override string MessageTooManyFriendsOther => "该用户的好友人数已达上限。";

	/// <summary>
	/// Key: "Message.TooManyFriendsSelf"
	/// English String: "You already have the max number of friends."
	/// </summary>
	public override string MessageTooManyFriendsSelf => "你的好友人数已达上限。";

	public NotificationStreamResources_zh_cn(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAccept()
	{
		return "接受";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "取消";
	}

	protected override string _GetTemplateForActionChat()
	{
		return "聊天";
	}

	protected override string _GetTemplateForActionIgnore()
	{
		return "忽略";
	}

	protected override string _GetTemplateForActionPlay()
	{
		return "开始游戏";
	}

	protected override string _GetTemplateForActionReportAbuse()
	{
		return "报告滥用行为";
	}

	protected override string _GetTemplateForActionUndo()
	{
		return "撤消";
	}

	/// <summary>
	/// Key: "Action.UnfollowGame"
	/// Label of menu item to unfollow the game
	/// English String: "Unfollow {gameName}"
	/// </summary>
	public override string ActionUnfollowGame(string gameName)
	{
		return $"取消关注 {gameName}";
	}

	protected override string _GetTemplateForActionUnfollowGame()
	{
		return "取消关注 {gameName}";
	}

	protected override string _GetTemplateForActionView()
	{
		return "查看";
	}

	protected override string _GetTemplateForActionViewAll()
	{
		return "查看所有";
	}

	protected override string _GetTemplateForHeadingBackToAllNotifications()
	{
		return "所有通知";
	}

	protected override string _GetTemplateForLabelNoNetworkConnectionText()
	{
		return "正在连接...";
	}

	protected override string _GetTemplateForLabelNoNotifications()
	{
		return "无通知";
	}

	protected override string _GetTemplateForLabelNotifications()
	{
		return "通知";
	}

	protected override string _GetTemplateForLabelSettings()
	{
		return "设置";
	}

	/// <summary>
	/// Key: "Message.AggregatedGameUpdateDouble"
	/// Message displayed on aggregated game update notification card, when there are exactly two games sending update.
	/// English String: "{gameOne} and {gameTwo} sent updates."
	/// </summary>
	public override string MessageAggregatedGameUpdateDouble(string gameOne, string gameTwo)
	{
		return $"{gameOne} 和 {gameTwo} 已发送更新。";
	}

	protected override string _GetTemplateForMessageAggregatedGameUpdateDouble()
	{
		return "{gameOne} 和 {gameTwo} 已发送更新。";
	}

	protected override string _GetTemplateForMessageAggregatedGameUpdateMultiple()
	{
		return "{gameOne}，{gameTwo} 及 {otherCount, plural,=1 {#个其他游戏}other {# 个其他游戏}}已发布更新。";
	}

	/// <summary>
	/// Key: "Message.ConfirmAcceptedDouble"
	/// English String: "{userOne} and {userTwo}"
	/// </summary>
	public override string MessageConfirmAcceptedDouble(string userOne, string userTwo)
	{
		return $"{userOne} 和 {userTwo}";
	}

	protected override string _GetTemplateForMessageConfirmAcceptedDouble()
	{
		return "{userOne} 和 {userTwo}";
	}

	protected override string _GetTemplateForMessageConfirmAcceptedMultiple()
	{
		return "{userOne}、{userTwo} 和 {userMultipleCount, plural, =1 {# 人} other {# 人}}";
	}

	/// <summary>
	/// Key: "Message.ConfirmAcceptedSingle"
	/// English String: "{userOne}"
	/// </summary>
	public override string MessageConfirmAcceptedSingle(string userOne)
	{
		return $"{userOne}";
	}

	protected override string _GetTemplateForMessageConfirmAcceptedSingle()
	{
		return "{userOne}";
	}

	/// <summary>
	/// Key: "Message.ConfirmSentDouble"
	/// English String: "{userOne} and {userTwo} are now your friends!"
	/// </summary>
	public override string MessageConfirmSentDouble(string userOne, string userTwo)
	{
		return $"{userOne} 和 {userTwo} 现在是你的好友了！";
	}

	protected override string _GetTemplateForMessageConfirmSentDouble()
	{
		return "{userOne} 和 {userTwo} 现在是你的好友了！";
	}

	protected override string _GetTemplateForMessageConfirmSentMultiple()
	{
		return "{userOne}、{userTwo} 和其他 {userMultipleCount, plural, =1 {# 人} other {# 人}}现在是你的好友了！";
	}

	/// <summary>
	/// Key: "Message.ConfirmSentSingle"
	/// English String: "{userOne} is now your friend!"
	/// </summary>
	public override string MessageConfirmSentSingle(string userOne)
	{
		return $"{userOne} 现在是你的好友了！";
	}

	protected override string _GetTemplateForMessageConfirmSentSingle()
	{
		return "{userOne} 现在是你的好友了！";
	}

	/// <summary>
	/// Key: "Message.DeveloperMetricsAvailable"
	/// English String: "{month} {year} Analytics Report for {gameName} available."
	/// </summary>
	public override string MessageDeveloperMetricsAvailable(string month, string year, string gameName)
	{
		return $"“{gameName}”{year}年{month}的分析报告已开放。";
	}

	protected override string _GetTemplateForMessageDeveloperMetricsAvailable()
	{
		return "“{gameName}”{year}年{month}的分析报告已开放。";
	}

	protected override string _GetTemplateForMessageDeveloperMetricsAvailableMultiple()
	{
		return "“{gameName}”和另外 {otherCount, plural, =1 {# 个游戏} other {# 个游戏}}{year}年{month}的分析报告已开放。";
	}

	/// <summary>
	/// Key: "Message.DeveloperMetricsAvailableMultiple2"
	/// English String: "{month} {year} Analytics Report for {gameCount} games available."
	/// </summary>
	public override string MessageDeveloperMetricsAvailableMultiple2(string month, string year, string gameCount)
	{
		return $"{gameCount} 个游戏{year}年{month}的分析报告已开放。";
	}

	protected override string _GetTemplateForMessageDeveloperMetricsAvailableMultiple2()
	{
		return "{gameCount} 个游戏{year}年{month}的分析报告已开放。";
	}

	/// <summary>
	/// Key: "Message.FriendRequestAcceptedDouble"
	/// English String: "{userOne} and {userTwo} accepted your friend request."
	/// </summary>
	public override string MessageFriendRequestAcceptedDouble(string userOne, string userTwo)
	{
		return $"{userOne} 和 {userTwo} 已接受了你的好友邀请。";
	}

	protected override string _GetTemplateForMessageFriendRequestAcceptedDouble()
	{
		return "{userOne} 和 {userTwo} 已接受了你的好友邀请。";
	}

	protected override string _GetTemplateForMessageFriendRequestAcceptedMultiple()
	{
		return "{userOne}、{userTwo} 和其他 {userMultipleCount, plural, =1 {# 人} other {# 人}}已接受了你的好友邀请。";
	}

	/// <summary>
	/// Key: "Message.FriendRequestAcceptedSingle"
	/// English String: "{userOne} accepted your friend request."
	/// </summary>
	public override string MessageFriendRequestAcceptedSingle(string userOne)
	{
		return $"{userOne} 已接受了你的好友邀请。";
	}

	protected override string _GetTemplateForMessageFriendRequestAcceptedSingle()
	{
		return "{userOne} 已接受了你的好友邀请。";
	}

	/// <summary>
	/// Key: "Message.FriendRequestSentDouble"
	/// English String: "{userOne} and {userTwo} sent you friend requests."
	/// </summary>
	public override string MessageFriendRequestSentDouble(string userOne, string userTwo)
	{
		return $"{userOne} 和 {userTwo} 向你发出了好友邀请。";
	}

	protected override string _GetTemplateForMessageFriendRequestSentDouble()
	{
		return "{userOne} 和 {userTwo} 向你发出了好友邀请。";
	}

	protected override string _GetTemplateForMessageFriendRequestSentMultiple()
	{
		return "{userOne}、{userTwo} 和其他 {userMultipleCount, plural, =1 {# 人} other {# 人}}向你发出了好友邀请。";
	}

	/// <summary>
	/// Key: "Message.FriendRequestSentSingle"
	/// English String: "{userOne} sent you a friend request."
	/// </summary>
	public override string MessageFriendRequestSentSingle(string userOne)
	{
		return $"{userOne} 向你发出了好友邀请。";
	}

	protected override string _GetTemplateForMessageFriendRequestSentSingle()
	{
		return "{userOne} 向你发出了好友邀请。";
	}

	protected override string _GetTemplateForMessageGameNotPlayableOnDevice()
	{
		return "在此设备上不可玩";
	}

	/// <summary>
	/// Key: "Message.MessageAndPreview"
	/// English String: "{titleStart}Message from {username}:{titleEnd} {message}"
	/// </summary>
	public override string MessageMessageAndPreview(string titleStart, string username, string titleEnd, string message)
	{
		return $"{titleStart}{username}发来信息：{titleEnd} {message}";
	}

	protected override string _GetTemplateForMessageMessageAndPreview()
	{
		return "{titleStart}{username}发来信息：{titleEnd} {message}";
	}

	/// <summary>
	/// Key: "Message.MessageFrom"
	/// English String: "Message from {username}:"
	/// </summary>
	public override string MessageMessageFrom(string username)
	{
		return $"{username} 发来信息：";
	}

	protected override string _GetTemplateForMessageMessageFrom()
	{
		return "{username} 发来信息：";
	}

	protected override string _GetTemplateForMessageNumberofNewNotifications()
	{
		return "{notificationCount, plural, =1 {# 条新通知} other {# 条新通知}}";
	}

	protected override string _GetTemplateForMessageTooManyFriendsOther()
	{
		return "该用户的好友人数已达上限。";
	}

	protected override string _GetTemplateForMessageTooManyFriendsSelf()
	{
		return "你的好友人数已达上限。";
	}

	/// <summary>
	/// Key: "Message.UnfollowedGame"
	/// Message displayed in game update card after user unfollowed the game
	/// English String: "Unfollowed {gameName}"
	/// </summary>
	public override string MessageUnfollowedGame(string gameName)
	{
		return $"已取消关注 {gameName}";
	}

	protected override string _GetTemplateForMessageUnfollowedGame()
	{
		return "已取消关注 {gameName}";
	}

	protected override string _GetTemplateForMessageYouHaveNewFriendRequests()
	{
		return "你有 {numberOfRequests} 条新的{numberOfRequests, plural, =1 {好友邀请} other {好友邀请}}。";
	}

	protected override string _GetTemplateForMessageYouHaveNewFriends()
	{
		return "你有 {numberOfFriends} 位新{numberOfFriends, plural, =1 {好友} other {好友}}。";
	}

	protected override string _GetTemplateForMessageYouReceivedMessages()
	{
		return "你收到了 {numberOfMessagesText} 条{numberOfMessages, plural, =1 {信息} other {信息}}";
	}
}
