namespace Roblox.TranslationResources.Notifications;

/// <summary>
/// This class overrides NotificationStreamResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class NotificationStreamResources_ko_kr : NotificationStreamResources_en_us, INotificationStreamResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Accept"
	/// English String: "Accept"
	/// </summary>
	public override string ActionAccept => "수락";

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "취소";

	/// <summary>
	/// Key: "Action.Chat"
	/// English String: "Chat"
	/// </summary>
	public override string ActionChat => "채팅";

	/// <summary>
	/// Key: "Action.Ignore"
	/// English String: "Ignore"
	/// </summary>
	public override string ActionIgnore => "무시";

	/// <summary>
	/// Key: "Action.Play"
	/// Label for button to launch game.
	/// English String: "Play"
	/// </summary>
	public override string ActionPlay => "플레이";

	/// <summary>
	/// Key: "Action.ReportAbuse"
	/// Label for link to report a game update message
	/// English String: "Report Abuse"
	/// </summary>
	public override string ActionReportAbuse => "신고하기";

	/// <summary>
	/// Key: "Action.Undo"
	/// Label for Undo link to reverse the unfollow action
	/// English String: "Undo"
	/// </summary>
	public override string ActionUndo => "실행 취소";

	/// <summary>
	/// Key: "Action.View"
	/// English String: "View"
	/// </summary>
	public override string ActionView => "보기";

	/// <summary>
	/// Key: "Action.ViewAll"
	/// English String: "View All"
	/// </summary>
	public override string ActionViewAll => "전체 보기";

	/// <summary>
	/// Key: "Heading.BackToAllNotifications"
	/// Heading displayed in game updates view, containing back link to notifications main view.
	/// English String: "All Notifications"
	/// </summary>
	public override string HeadingBackToAllNotifications => "전체 알림";

	/// <summary>
	/// Key: "Label.NoNetworkConnectionText"
	/// English String: "Connecting..."
	/// </summary>
	public override string LabelNoNetworkConnectionText => "연결 중...";

	/// <summary>
	/// Key: "Label.NoNotifications"
	/// English String: "No Notifications"
	/// </summary>
	public override string LabelNoNotifications => "알림 없음";

	/// <summary>
	/// Key: "Label.Notifications"
	/// English String: "Notifications"
	/// </summary>
	public override string LabelNotifications => "알림";

	/// <summary>
	/// Key: "Label.Settings"
	/// English String: "Settings"
	/// </summary>
	public override string LabelSettings => "설정";

	/// <summary>
	/// Key: "Message.GameNotPlayableOnDevice"
	/// Message displayed on game update card when the game is not playable on the device type.
	/// English String: "Not playable on this device"
	/// </summary>
	public override string MessageGameNotPlayableOnDevice => "본 기기에서는 플레이할 수 없어요";

	/// <summary>
	/// Key: "Message.TooManyFriendsOther"
	/// English String: "That user already has the max number of friends."
	/// </summary>
	public override string MessageTooManyFriendsOther => "해당 사용자의 친구 수가 한도에 도달했어요.";

	/// <summary>
	/// Key: "Message.TooManyFriendsSelf"
	/// English String: "You already have the max number of friends."
	/// </summary>
	public override string MessageTooManyFriendsSelf => "친구 수가 한도에 도달했어요.";

	public NotificationStreamResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAccept()
	{
		return "수락";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "취소";
	}

	protected override string _GetTemplateForActionChat()
	{
		return "채팅";
	}

	protected override string _GetTemplateForActionIgnore()
	{
		return "무시";
	}

	protected override string _GetTemplateForActionPlay()
	{
		return "플레이";
	}

	protected override string _GetTemplateForActionReportAbuse()
	{
		return "신고하기";
	}

	protected override string _GetTemplateForActionUndo()
	{
		return "실행 취소";
	}

	/// <summary>
	/// Key: "Action.UnfollowGame"
	/// Label of menu item to unfollow the game
	/// English String: "Unfollow {gameName}"
	/// </summary>
	public override string ActionUnfollowGame(string gameName)
	{
		return $"{gameName} 팔로우 취소";
	}

	protected override string _GetTemplateForActionUnfollowGame()
	{
		return "{gameName} 팔로우 취소";
	}

	protected override string _GetTemplateForActionView()
	{
		return "보기";
	}

	protected override string _GetTemplateForActionViewAll()
	{
		return "전체 보기";
	}

	protected override string _GetTemplateForHeadingBackToAllNotifications()
	{
		return "전체 알림";
	}

	protected override string _GetTemplateForLabelNoNetworkConnectionText()
	{
		return "연결 중...";
	}

	protected override string _GetTemplateForLabelNoNotifications()
	{
		return "알림 없음";
	}

	protected override string _GetTemplateForLabelNotifications()
	{
		return "알림";
	}

	protected override string _GetTemplateForLabelSettings()
	{
		return "설정";
	}

	/// <summary>
	/// Key: "Message.AggregatedGameUpdateDouble"
	/// Message displayed on aggregated game update notification card, when there are exactly two games sending update.
	/// English String: "{gameOne} and {gameTwo} sent updates."
	/// </summary>
	public override string MessageAggregatedGameUpdateDouble(string gameOne, string gameTwo)
	{
		return $"{gameOne}, {gameTwo}에 업데이트가 있어요.";
	}

	protected override string _GetTemplateForMessageAggregatedGameUpdateDouble()
	{
		return "{gameOne}, {gameTwo}에 업데이트가 있어요.";
	}

	protected override string _GetTemplateForMessageAggregatedGameUpdateMultiple()
	{
		return "{gameOne}, {gameTwo} , {otherCount, plural, =1 {#개 기타 게임} other {#개 기타 게임}}에 업데이트가 있어요.";
	}

	/// <summary>
	/// Key: "Message.ConfirmAcceptedDouble"
	/// English String: "{userOne} and {userTwo}"
	/// </summary>
	public override string MessageConfirmAcceptedDouble(string userOne, string userTwo)
	{
		return $"{userOne}님과 {userTwo}님";
	}

	protected override string _GetTemplateForMessageConfirmAcceptedDouble()
	{
		return "{userOne}님과 {userTwo}님";
	}

	protected override string _GetTemplateForMessageConfirmAcceptedMultiple()
	{
		return "{userOne}님, {userTwo}님 외 {userMultipleCount, plural, =1 {#명} other {#명}}";
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
		return $"{userOne}님과 {userTwo}님이 친구가 되었어요!";
	}

	protected override string _GetTemplateForMessageConfirmSentDouble()
	{
		return "{userOne}님과 {userTwo}님이 친구가 되었어요!";
	}

	protected override string _GetTemplateForMessageConfirmSentMultiple()
	{
		return "{userOne}님, {userTwo}님 외 {userMultipleCount, plural, =1 {#명} other {#명}}과 친구가 되었어요!";
	}

	/// <summary>
	/// Key: "Message.ConfirmSentSingle"
	/// English String: "{userOne} is now your friend!"
	/// </summary>
	public override string MessageConfirmSentSingle(string userOne)
	{
		return $"{userOne}님과 친구가 되었어요!";
	}

	protected override string _GetTemplateForMessageConfirmSentSingle()
	{
		return "{userOne}님과 친구가 되었어요!";
	}

	/// <summary>
	/// Key: "Message.DeveloperMetricsAvailable"
	/// English String: "{month} {year} Analytics Report for {gameName} available."
	/// </summary>
	public override string MessageDeveloperMetricsAvailable(string month, string year, string gameName)
	{
		return $"{gameName}의 {year} {month} 분석 보고서를 이용할 수 있어요.";
	}

	protected override string _GetTemplateForMessageDeveloperMetricsAvailable()
	{
		return "{gameName}의 {year} {month} 분석 보고서를 이용할 수 있어요.";
	}

	protected override string _GetTemplateForMessageDeveloperMetricsAvailableMultiple()
	{
		return "{gameName} 및 {otherCount, plural, =1 {#개 기타 게임} other {# 기타 게임}}의 {year} {month} 분석 보고서를 이용할 수 있어요.";
	}

	/// <summary>
	/// Key: "Message.DeveloperMetricsAvailableMultiple2"
	/// English String: "{month} {year} Analytics Report for {gameCount} games available."
	/// </summary>
	public override string MessageDeveloperMetricsAvailableMultiple2(string month, string year, string gameCount)
	{
		return $"{gameCount}개 게임의 {year} {month} 분석 보고서를 이용할 수 있어요.";
	}

	protected override string _GetTemplateForMessageDeveloperMetricsAvailableMultiple2()
	{
		return "{gameCount}개 게임의 {year} {month} 분석 보고서를 이용할 수 있어요.";
	}

	/// <summary>
	/// Key: "Message.FriendRequestAcceptedDouble"
	/// English String: "{userOne} and {userTwo} accepted your friend request."
	/// </summary>
	public override string MessageFriendRequestAcceptedDouble(string userOne, string userTwo)
	{
		return $"{userOne}님과 {userTwo}님이 친구 요청을 수락했어요.";
	}

	protected override string _GetTemplateForMessageFriendRequestAcceptedDouble()
	{
		return "{userOne}님과 {userTwo}님이 친구 요청을 수락했어요.";
	}

	protected override string _GetTemplateForMessageFriendRequestAcceptedMultiple()
	{
		return "{userOne}님, {userTwo}님 외 {userMultipleCount, plural, =1 {#명} other {#명}}이 친구 요청을 수락했어요.";
	}

	/// <summary>
	/// Key: "Message.FriendRequestAcceptedSingle"
	/// English String: "{userOne} accepted your friend request."
	/// </summary>
	public override string MessageFriendRequestAcceptedSingle(string userOne)
	{
		return $"{userOne}님이 친구 요청을 수락했어요.";
	}

	protected override string _GetTemplateForMessageFriendRequestAcceptedSingle()
	{
		return "{userOne}님이 친구 요청을 수락했어요.";
	}

	/// <summary>
	/// Key: "Message.FriendRequestSentDouble"
	/// English String: "{userOne} and {userTwo} sent you friend requests."
	/// </summary>
	public override string MessageFriendRequestSentDouble(string userOne, string userTwo)
	{
		return $"{userOne}님과 {userTwo}님이 친구 요청을 보냈어요.";
	}

	protected override string _GetTemplateForMessageFriendRequestSentDouble()
	{
		return "{userOne}님과 {userTwo}님이 친구 요청을 보냈어요.";
	}

	protected override string _GetTemplateForMessageFriendRequestSentMultiple()
	{
		return "{userOne}님, {userTwo}님 외 {userMultipleCount, plural, =1 {#명} other {#명}}이 친구 요청을 보냈어요.";
	}

	/// <summary>
	/// Key: "Message.FriendRequestSentSingle"
	/// English String: "{userOne} sent you a friend request."
	/// </summary>
	public override string MessageFriendRequestSentSingle(string userOne)
	{
		return $"{userOne}님이 친구 요청을 보냈어요.";
	}

	protected override string _GetTemplateForMessageFriendRequestSentSingle()
	{
		return "{userOne}님이 친구 요청을 보냈어요.";
	}

	protected override string _GetTemplateForMessageGameNotPlayableOnDevice()
	{
		return "본 기기에서는 플레이할 수 없어요";
	}

	/// <summary>
	/// Key: "Message.MessageAndPreview"
	/// English String: "{titleStart}Message from {username}:{titleEnd} {message}"
	/// </summary>
	public override string MessageMessageAndPreview(string titleStart, string username, string titleEnd, string message)
	{
		return $"{titleStart}{username}님의 메시지:{titleEnd} {message}";
	}

	protected override string _GetTemplateForMessageMessageAndPreview()
	{
		return "{titleStart}{username}님의 메시지:{titleEnd} {message}";
	}

	/// <summary>
	/// Key: "Message.MessageFrom"
	/// English String: "Message from {username}:"
	/// </summary>
	public override string MessageMessageFrom(string username)
	{
		return $"{username}님의 메시지: ";
	}

	protected override string _GetTemplateForMessageMessageFrom()
	{
		return "{username}님의 메시지: ";
	}

	protected override string _GetTemplateForMessageNumberofNewNotifications()
	{
		return "{notificationCount, plural, =1 {새 알림 #건} other {새 알림 #건}}";
	}

	protected override string _GetTemplateForMessageTooManyFriendsOther()
	{
		return "해당 사용자의 친구 수가 한도에 도달했어요.";
	}

	protected override string _GetTemplateForMessageTooManyFriendsSelf()
	{
		return "친구 수가 한도에 도달했어요.";
	}

	/// <summary>
	/// Key: "Message.UnfollowedGame"
	/// Message displayed in game update card after user unfollowed the game
	/// English String: "Unfollowed {gameName}"
	/// </summary>
	public override string MessageUnfollowedGame(string gameName)
	{
		return $"{gameName} 팔로우 취소";
	}

	protected override string _GetTemplateForMessageUnfollowedGame()
	{
		return "{gameName} 팔로우 취소";
	}

	protected override string _GetTemplateForMessageYouHaveNewFriendRequests()
	{
		return "{numberOfRequests}개의 새 {numberOfRequests, plural, =1 {친구 요청} other {친구 요청}}이 도착했어요.";
	}

	protected override string _GetTemplateForMessageYouHaveNewFriends()
	{
		return "{numberOfFriends}명의 새 {numberOfFriends, plural, =1 {친구} other {친구}}가 생겼어요.";
	}

	protected override string _GetTemplateForMessageYouReceivedMessages()
	{
		return "{numberOfMessagesText}개의 새 {numberOfMessages, plural, =1 {메시지} other {메시지}}가 도착했어요.";
	}
}
