namespace Roblox.Platform.TranslationResources.Notifications {
    /// <summary>

/// This class overrides NotificationStreamResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class NotificationStreamResources_zh_tw : NotificationStreamResources_en_us, INotificationStreamResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Accept"
	/// English String: "Accept"
	/// </summary>
	public override string ActionAccept => "æŽ¥å—";

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "å–æ¶ˆ";

	/// <summary>
	/// Key: "Action.Chat"
	/// English String: "Chat"
	/// </summary>
	public override string ActionChat => "èŠå¤©";

	/// <summary>
	/// Key: "Action.Ignore"
	/// English String: "Ignore"
	/// </summary>
	public override string ActionIgnore => "å¿½ç•¥";

	/// <summary>
	/// Key: "Action.Play"
	/// Label for button to launch game.
	/// English String: "Play"
	/// </summary>
	public override string ActionPlay => "é–‹å§‹éŠæˆ²";

	/// <summary>
	/// Key: "Action.ReportAbuse"
	/// Label for link to report a game update message
	/// English String: "Report Abuse"
	/// </summary>
	public override string ActionReportAbuse => "æª¢èˆ‰æ¿«ç”¨";

	/// <summary>
	/// Key: "Action.Undo"
	/// Label for Undo link to reverse the unfollow action
	/// English String: "Undo"
	/// </summary>
	public override string ActionUndo => "å¾©åŽŸ";

	/// <summary>
	/// Key: "Action.View"
	/// English String: "View"
	/// </summary>
	public override string ActionView => "æª¢è¦–";

	/// <summary>
	/// Key: "Action.ViewAll"
	/// English String: "View All"
	/// </summary>
	public override string ActionViewAll => "æª¢è¦–å…¨éƒ¨";

	/// <summary>
	/// Key: "Heading.BackToAllNotifications"
	/// Heading displayed in game updates view, containing back link to notifications main view.
	/// English String: "All Notifications"
	/// </summary>
	public override string HeadingBackToAllNotifications => "æ‰€æœ‰é€šçŸ¥";

	/// <summary>
	/// Key: "Label.NoNetworkConnectionText"
	/// English String: "Connecting..."
	/// </summary>
	public override string LabelNoNetworkConnectionText => "æ­£åœ¨é€£ç·šâ€¦";

	/// <summary>
	/// Key: "Label.NoNotifications"
	/// English String: "No Notifications"
	/// </summary>
	public override string LabelNoNotifications => "æ²’æœ‰é€šçŸ¥";

	/// <summary>
	/// Key: "Label.Notifications"
	/// English String: "Notifications"
	/// </summary>
	public override string LabelNotifications => "é€šçŸ¥";

	/// <summary>
	/// Key: "Label.Settings"
	/// English String: "Settings"
	/// </summary>
	public override string LabelSettings => "è¨­å®š";

	/// <summary>
	/// Key: "Message.GameNotPlayableOnDevice"
	/// Message displayed on game update card when the game is not playable on the device type.
	/// English String: "Not playable on this device"
	/// </summary>
	public override string MessageGameNotPlayableOnDevice => "ç„¡æ³•åœ¨æ­¤è£ç½®é–‹å•Ÿ";

	/// <summary>
	/// Key: "Message.TooManyFriendsOther"
	/// English String: "That user already has the max number of friends."
	/// </summary>
	public override string MessageTooManyFriendsOther => "è©²ä½¿ç”¨è€…çš„å¥½å‹äººæ•¸å·²é”ä¸Šé™ã€‚";

	/// <summary>
	/// Key: "Message.TooManyFriendsSelf"
	/// English String: "You already have the max number of friends."
	/// </summary>
	public override string MessageTooManyFriendsSelf => "æ‚¨çš„å¥½å‹äººæ•¸å·²é”ä¸Šé™ã€‚";

	public NotificationStreamResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAccept()
	{
		return "æŽ¥å—";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "å–æ¶ˆ";
	}

	protected override string _GetTemplateForActionChat()
	{
		return "èŠå¤©";
	}

	protected override string _GetTemplateForActionIgnore()
	{
		return "å¿½ç•¥";
	}

	protected override string _GetTemplateForActionPlay()
	{
		return "é–‹å§‹éŠæˆ²";
	}

	protected override string _GetTemplateForActionReportAbuse()
	{
		return "æª¢èˆ‰æ¿«ç”¨";
	}

	protected override string _GetTemplateForActionUndo()
	{
		return "å¾©åŽŸ";
	}

	/// <summary>
	/// Key: "Action.UnfollowGame"
	/// Label of menu item to unfollow the game
	/// English String: "Unfollow {gameName}"
	/// </summary>
	public override string ActionUnfollowGame(string gameName)
	{
		return $"å–æ¶ˆè¿½è¹¤ {gameName}";
	}

	protected override string _GetTemplateForActionUnfollowGame()
	{
		return "å–æ¶ˆè¿½è¹¤ {gameName}";
	}

	protected override string _GetTemplateForActionView()
	{
		return "æª¢è¦–";
	}

	protected override string _GetTemplateForActionViewAll()
	{
		return "æª¢è¦–å…¨éƒ¨";
	}

	protected override string _GetTemplateForHeadingBackToAllNotifications()
	{
		return "æ‰€æœ‰é€šçŸ¥";
	}

	protected override string _GetTemplateForLabelNoNetworkConnectionText()
	{
		return "æ­£åœ¨é€£ç·šâ€¦";
	}

	protected override string _GetTemplateForLabelNoNotifications()
	{
		return "æ²’æœ‰é€šçŸ¥";
	}

	protected override string _GetTemplateForLabelNotifications()
	{
		return "é€šçŸ¥";
	}

	protected override string _GetTemplateForLabelSettings()
	{
		return "è¨­å®š";
	}

	/// <summary>
	/// Key: "Message.AggregatedGameUpdateDouble"
	/// Message displayed on aggregated game update notification card, when there are exactly two games sending update.
	/// English String: "{gameOne} and {gameTwo} sent updates."
	/// </summary>
	public override string MessageAggregatedGameUpdateDouble(string gameOne, string gameTwo)
	{
		return $"{gameOne} å’Œ {gameTwo} å·²ç™¼å¸ƒæ›´æ–°ã€‚";
	}

	protected override string _GetTemplateForMessageAggregatedGameUpdateDouble()
	{
		return "{gameOne} å’Œ {gameTwo} å·²ç™¼å¸ƒæ›´æ–°ã€‚";
	}

	protected override string _GetTemplateForMessageAggregatedGameUpdateMultiple()
	{
		return "{gameOne}ã€{gameTwo} åŠå¦å¤– {otherCount, plural, =1 {# å€‹éŠæˆ²} other {# å€‹éŠæˆ²}}å·²ç™¼å¸ƒæ›´æ–°ã€‚";
	}

	/// <summary>
	/// Key: "Message.ConfirmAcceptedDouble"
	/// English String: "{userOne} and {userTwo}"
	/// </summary>
	public override string MessageConfirmAcceptedDouble(string userOne, string userTwo)
	{
		return $"{userOne} å’Œ {userTwo}";
	}

	protected override string _GetTemplateForMessageConfirmAcceptedDouble()
	{
		return "{userOne} å’Œ {userTwo}";
	}

	protected override string _GetTemplateForMessageConfirmAcceptedMultiple()
	{
		return "{userOne}ã€{userTwo} åŠå¦å¤– {userMultipleCount, plural, =1 {# äºº} other {# äºº}}";
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
		return $"{userOne} å’Œ {userTwo} å·²æˆç‚ºæ‚¨çš„å¥½å‹ï¼";
	}

	protected override string _GetTemplateForMessageConfirmSentDouble()
	{
		return "{userOne} å’Œ {userTwo} å·²æˆç‚ºæ‚¨çš„å¥½å‹ï¼";
	}

	protected override string _GetTemplateForMessageConfirmSentMultiple()
	{
		return "{userOne}ã€{userTwo} åŠå…¶ä»– {userMultipleCount, plural, =1 {# äºº} other {# äºº}}å·²æˆç‚ºæ‚¨çš„å¥½å‹ï¼";
	}

	/// <summary>
	/// Key: "Message.ConfirmSentSingle"
	/// English String: "{userOne} is now your friend!"
	/// </summary>
	public override string MessageConfirmSentSingle(string userOne)
	{
		return $"{userOne} å·²æˆç‚ºæ‚¨çš„å¥½å‹ï¼";
	}

	protected override string _GetTemplateForMessageConfirmSentSingle()
	{
		return "{userOne} å·²æˆç‚ºæ‚¨çš„å¥½å‹ï¼";
	}

	/// <summary>
	/// Key: "Message.DeveloperMetricsAvailable"
	/// English String: "{month} {year} Analytics Report for {gameName} available."
	/// </summary>
	public override string MessageDeveloperMetricsAvailable(string month, string year, string gameName)
	{
		return $"{gameName} {year} å¹´ {month} çš„åˆ†æžå ±å‘Šå·²é–‹æ”¾ã€‚";
	}

	protected override string _GetTemplateForMessageDeveloperMetricsAvailable()
	{
		return "{gameName} {year} å¹´ {month} çš„åˆ†æžå ±å‘Šå·²é–‹æ”¾ã€‚";
	}

	protected override string _GetTemplateForMessageDeveloperMetricsAvailableMultiple()
	{
		return "{gameName} å’Œå¦å¤– {otherCount, plural, =1 {# å€‹éŠæˆ²} other {# å€‹éŠæˆ²}} {year} å¹´ {month}çš„åˆ†æžå ±å‘Šå·²é–‹æ”¾ã€‚";
	}

	/// <summary>
	/// Key: "Message.DeveloperMetricsAvailableMultiple2"
	/// English String: "{month} {year} Analytics Report for {gameCount} games available."
	/// </summary>
	public override string MessageDeveloperMetricsAvailableMultiple2(string month, string year, string gameCount)
	{
		return $"{gameCount} å€‹éŠæˆ² {year} å¹´ {month} çš„åˆ†æžå ±å‘Šå·²é–‹æ”¾ã€‚";
	}

	protected override string _GetTemplateForMessageDeveloperMetricsAvailableMultiple2()
	{
		return "{gameCount} å€‹éŠæˆ² {year} å¹´ {month} çš„åˆ†æžå ±å‘Šå·²é–‹æ”¾ã€‚";
	}

	/// <summary>
	/// Key: "Message.FriendRequestAcceptedDouble"
	/// English String: "{userOne} and {userTwo} accepted your friend request."
	/// </summary>
	public override string MessageFriendRequestAcceptedDouble(string userOne, string userTwo)
	{
		return $"{userOne} åŠ {userTwo} å·²æŽ¥å—æ‚¨çš„å¥½å‹é‚€è«‹ã€‚";
	}

	protected override string _GetTemplateForMessageFriendRequestAcceptedDouble()
	{
		return "{userOne} åŠ {userTwo} å·²æŽ¥å—æ‚¨çš„å¥½å‹é‚€è«‹ã€‚";
	}

	protected override string _GetTemplateForMessageFriendRequestAcceptedMultiple()
	{
		return "{userOne}ã€{userTwo} åŠå¦å¤– {userMultipleCount, plural, =1 {# äºº} other {# äºº}}å·²æŽ¥å—æ‚¨çš„å¥½å‹é‚€è«‹ã€‚";
	}

	/// <summary>
	/// Key: "Message.FriendRequestAcceptedSingle"
	/// English String: "{userOne} accepted your friend request."
	/// </summary>
	public override string MessageFriendRequestAcceptedSingle(string userOne)
	{
		return $"{userOne} å·²æŽ¥å—æ‚¨çš„å¥½å‹é‚€è«‹ã€‚";
	}

	protected override string _GetTemplateForMessageFriendRequestAcceptedSingle()
	{
		return "{userOne} å·²æŽ¥å—æ‚¨çš„å¥½å‹é‚€è«‹ã€‚";
	}

	/// <summary>
	/// Key: "Message.FriendRequestSentDouble"
	/// English String: "{userOne} and {userTwo} sent you friend requests."
	/// </summary>
	public override string MessageFriendRequestSentDouble(string userOne, string userTwo)
	{
		return $"{userOne} åŠ {userTwo} å‘æ‚¨å‚³é€å¥½å‹é‚€è«‹ã€‚";
	}

	protected override string _GetTemplateForMessageFriendRequestSentDouble()
	{
		return "{userOne} åŠ {userTwo} å‘æ‚¨å‚³é€å¥½å‹é‚€è«‹ã€‚";
	}

	protected override string _GetTemplateForMessageFriendRequestSentMultiple()
	{
		return "{userOne}ã€{userTwo} åŠå¦å¤– {userMultipleCount, plural, =1 {# äºº} other {# äºº}}å‘æ‚¨å‚³é€å¥½å‹é‚€è«‹ã€‚";
	}

	/// <summary>
	/// Key: "Message.FriendRequestSentSingle"
	/// English String: "{userOne} sent you a friend request."
	/// </summary>
	public override string MessageFriendRequestSentSingle(string userOne)
	{
		return $"{userOne} å‘æ‚¨å‚³é€å¥½å‹é‚€è«‹ã€‚";
	}

	protected override string _GetTemplateForMessageFriendRequestSentSingle()
	{
		return "{userOne} å‘æ‚¨å‚³é€å¥½å‹é‚€è«‹ã€‚";
	}

	protected override string _GetTemplateForMessageGameNotPlayableOnDevice()
	{
		return "ç„¡æ³•åœ¨æ­¤è£ç½®é–‹å•Ÿ";
	}

	/// <summary>
	/// Key: "Message.MessageAndPreview"
	/// English String: "{titleStart}Message from {username}:{titleEnd} {message}"
	/// </summary>
	public override string MessageMessageAndPreview(string titleStart, string username, string titleEnd, string message)
	{
		return $"{titleStart}{username} å‚³é€çš„è¨Šæ¯ï¼š{titleEnd} {message}";
	}

	protected override string _GetTemplateForMessageMessageAndPreview()
	{
		return "{titleStart}{username} å‚³é€çš„è¨Šæ¯ï¼š{titleEnd} {message}";
	}

	/// <summary>
	/// Key: "Message.MessageFrom"
	/// English String: "Message from {username}:"
	/// </summary>
	public override string MessageMessageFrom(string username)
	{
		return $"{username} å‚³é€çš„è¨Šæ¯ï¼š";
	}

	protected override string _GetTemplateForMessageMessageFrom()
	{
		return "{username} å‚³é€çš„è¨Šæ¯ï¼š";
	}

	protected override string _GetTemplateForMessageNumberofNewNotifications()
	{
		return "{notificationCount, plural, =1 {# å‰‡æ–°é€šçŸ¥} other {# å‰‡æ–°é€šçŸ¥}}";
	}

	protected override string _GetTemplateForMessageTooManyFriendsOther()
	{
		return "è©²ä½¿ç”¨è€…çš„å¥½å‹äººæ•¸å·²é”ä¸Šé™ã€‚";
	}

	protected override string _GetTemplateForMessageTooManyFriendsSelf()
	{
		return "æ‚¨çš„å¥½å‹äººæ•¸å·²é”ä¸Šé™ã€‚";
	}

	/// <summary>
	/// Key: "Message.UnfollowedGame"
	/// Message displayed in game update card after user unfollowed the game
	/// English String: "Unfollowed {gameName}"
	/// </summary>
	public override string MessageUnfollowedGame(string gameName)
	{
		return $"å·²å–æ¶ˆè¿½è¹¤ {gameName}";
	}

	protected override string _GetTemplateForMessageUnfollowedGame()
	{
		return "å·²å–æ¶ˆè¿½è¹¤ {gameName}";
	}

	protected override string _GetTemplateForMessageYouHaveNewFriendRequests()
	{
		return "æ‚¨æœ‰ {numberOfRequests} å‰‡æ–°çš„{numberOfRequests, plural, =1 {å¥½å‹é‚€è«‹} other {å¥½å‹é‚€è«‹}}ã€‚";
	}

	protected override string _GetTemplateForMessageYouHaveNewFriends()
	{
		return "æ‚¨æœ‰ {numberOfFriends} ä½æ–°{numberOfFriends, plural, =1 {å¥½å‹} other {å¥½å‹}}ã€‚";
	}

	protected override string _GetTemplateForMessageYouReceivedMessages()
	{
		return "æ‚¨æ”¶åˆ° {numberOfMessagesText} å‰‡{numberOfMessages, plural, =1 {è¨Šæ¯} other {è¨Šæ¯}}";
	}
}


}
