namespace Roblox.Platform.TranslationResources.Notifications {
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
	public override string ActionAccept => "ìˆ˜ë½";

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "ì·¨ì†Œ";

	/// <summary>
	/// Key: "Action.Chat"
	/// English String: "Chat"
	/// </summary>
	public override string ActionChat => "ì±„íŒ…";

	/// <summary>
	/// Key: "Action.Ignore"
	/// English String: "Ignore"
	/// </summary>
	public override string ActionIgnore => "ë¬´ì‹œ";

	/// <summary>
	/// Key: "Action.Play"
	/// Label for button to launch game.
	/// English String: "Play"
	/// </summary>
	public override string ActionPlay => "í”Œë ˆì´";

	/// <summary>
	/// Key: "Action.ReportAbuse"
	/// Label for link to report a game update message
	/// English String: "Report Abuse"
	/// </summary>
	public override string ActionReportAbuse => "ì‹ ê³ í•˜ê¸°";

	/// <summary>
	/// Key: "Action.Undo"
	/// Label for Undo link to reverse the unfollow action
	/// English String: "Undo"
	/// </summary>
	public override string ActionUndo => "ì‹¤í–‰ ì·¨ì†Œ";

	/// <summary>
	/// Key: "Action.View"
	/// English String: "View"
	/// </summary>
	public override string ActionView => "ë³´ê¸°";

	/// <summary>
	/// Key: "Action.ViewAll"
	/// English String: "View All"
	/// </summary>
	public override string ActionViewAll => "ì „ì²´ ë³´ê¸°";

	/// <summary>
	/// Key: "Heading.BackToAllNotifications"
	/// Heading displayed in game updates view, containing back link to notifications main view.
	/// English String: "All Notifications"
	/// </summary>
	public override string HeadingBackToAllNotifications => "ì „ì²´ ì•Œë¦¼";

	/// <summary>
	/// Key: "Label.NoNetworkConnectionText"
	/// English String: "Connecting..."
	/// </summary>
	public override string LabelNoNetworkConnectionText => "ì—°ê²° ì¤‘...";

	/// <summary>
	/// Key: "Label.NoNotifications"
	/// English String: "No Notifications"
	/// </summary>
	public override string LabelNoNotifications => "ì•Œë¦¼ ì—†ìŒ";

	/// <summary>
	/// Key: "Label.Notifications"
	/// English String: "Notifications"
	/// </summary>
	public override string LabelNotifications => "ì•Œë¦¼";

	/// <summary>
	/// Key: "Label.Settings"
	/// English String: "Settings"
	/// </summary>
	public override string LabelSettings => "ì„¤ì •";

	/// <summary>
	/// Key: "Message.GameNotPlayableOnDevice"
	/// Message displayed on game update card when the game is not playable on the device type.
	/// English String: "Not playable on this device"
	/// </summary>
	public override string MessageGameNotPlayableOnDevice => "ë³¸ ê¸°ê¸°ì—ì„œëŠ” í”Œë ˆì´í•  ìˆ˜ ì—†ì–´ìš”";

	/// <summary>
	/// Key: "Message.TooManyFriendsOther"
	/// English String: "That user already has the max number of friends."
	/// </summary>
	public override string MessageTooManyFriendsOther => "í•´ë‹¹ ì‚¬ìš©ìžì˜ ì¹œêµ¬ ìˆ˜ê°€ í•œë„ì— ë„ë‹¬í–ˆì–´ìš”.";

	/// <summary>
	/// Key: "Message.TooManyFriendsSelf"
	/// English String: "You already have the max number of friends."
	/// </summary>
	public override string MessageTooManyFriendsSelf => "ì¹œêµ¬ ìˆ˜ê°€ í•œë„ì— ë„ë‹¬í–ˆì–´ìš”.";

	public NotificationStreamResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAccept()
	{
		return "ìˆ˜ë½";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "ì·¨ì†Œ";
	}

	protected override string _GetTemplateForActionChat()
	{
		return "ì±„íŒ…";
	}

	protected override string _GetTemplateForActionIgnore()
	{
		return "ë¬´ì‹œ";
	}

	protected override string _GetTemplateForActionPlay()
	{
		return "í”Œë ˆì´";
	}

	protected override string _GetTemplateForActionReportAbuse()
	{
		return "ì‹ ê³ í•˜ê¸°";
	}

	protected override string _GetTemplateForActionUndo()
	{
		return "ì‹¤í–‰ ì·¨ì†Œ";
	}

	/// <summary>
	/// Key: "Action.UnfollowGame"
	/// Label of menu item to unfollow the game
	/// English String: "Unfollow {gameName}"
	/// </summary>
	public override string ActionUnfollowGame(string gameName)
	{
		return $"{gameName} íŒ”ë¡œìš° ì·¨ì†Œ";
	}

	protected override string _GetTemplateForActionUnfollowGame()
	{
		return "{gameName} íŒ”ë¡œìš° ì·¨ì†Œ";
	}

	protected override string _GetTemplateForActionView()
	{
		return "ë³´ê¸°";
	}

	protected override string _GetTemplateForActionViewAll()
	{
		return "ì „ì²´ ë³´ê¸°";
	}

	protected override string _GetTemplateForHeadingBackToAllNotifications()
	{
		return "ì „ì²´ ì•Œë¦¼";
	}

	protected override string _GetTemplateForLabelNoNetworkConnectionText()
	{
		return "ì—°ê²° ì¤‘...";
	}

	protected override string _GetTemplateForLabelNoNotifications()
	{
		return "ì•Œë¦¼ ì—†ìŒ";
	}

	protected override string _GetTemplateForLabelNotifications()
	{
		return "ì•Œë¦¼";
	}

	protected override string _GetTemplateForLabelSettings()
	{
		return "ì„¤ì •";
	}

	/// <summary>
	/// Key: "Message.AggregatedGameUpdateDouble"
	/// Message displayed on aggregated game update notification card, when there are exactly two games sending update.
	/// English String: "{gameOne} and {gameTwo} sent updates."
	/// </summary>
	public override string MessageAggregatedGameUpdateDouble(string gameOne, string gameTwo)
	{
		return $"{gameOne}, {gameTwo}ì— ì—…ë°ì´íŠ¸ê°€ ìžˆì–´ìš”.";
	}

	protected override string _GetTemplateForMessageAggregatedGameUpdateDouble()
	{
		return "{gameOne}, {gameTwo}ì— ì—…ë°ì´íŠ¸ê°€ ìžˆì–´ìš”.";
	}

	protected override string _GetTemplateForMessageAggregatedGameUpdateMultiple()
	{
		return "{gameOne}, {gameTwo} , {otherCount, plural, =1 {#ê°œ ê¸°íƒ€ ê²Œìž„} other {#ê°œ ê¸°íƒ€ ê²Œìž„}}ì— ì—…ë°ì´íŠ¸ê°€ ìžˆì–´ìš”.";
	}

	/// <summary>
	/// Key: "Message.ConfirmAcceptedDouble"
	/// English String: "{userOne} and {userTwo}"
	/// </summary>
	public override string MessageConfirmAcceptedDouble(string userOne, string userTwo)
	{
		return $"{userOne}ë‹˜ê³¼ {userTwo}ë‹˜";
	}

	protected override string _GetTemplateForMessageConfirmAcceptedDouble()
	{
		return "{userOne}ë‹˜ê³¼ {userTwo}ë‹˜";
	}

	protected override string _GetTemplateForMessageConfirmAcceptedMultiple()
	{
		return "{userOne}ë‹˜, {userTwo}ë‹˜ ì™¸ {userMultipleCount, plural, =1 {#ëª…} other {#ëª…}}";
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
		return $"{userOne}ë‹˜ê³¼ {userTwo}ë‹˜ì´ ì¹œêµ¬ê°€ ë˜ì—ˆì–´ìš”!";
	}

	protected override string _GetTemplateForMessageConfirmSentDouble()
	{
		return "{userOne}ë‹˜ê³¼ {userTwo}ë‹˜ì´ ì¹œêµ¬ê°€ ë˜ì—ˆì–´ìš”!";
	}

	protected override string _GetTemplateForMessageConfirmSentMultiple()
	{
		return "{userOne}ë‹˜, {userTwo}ë‹˜ ì™¸ {userMultipleCount, plural, =1 {#ëª…} other {#ëª…}}ê³¼ ì¹œêµ¬ê°€ ë˜ì—ˆì–´ìš”!";
	}

	/// <summary>
	/// Key: "Message.ConfirmSentSingle"
	/// English String: "{userOne} is now your friend!"
	/// </summary>
	public override string MessageConfirmSentSingle(string userOne)
	{
		return $"{userOne}ë‹˜ê³¼ ì¹œêµ¬ê°€ ë˜ì—ˆì–´ìš”!";
	}

	protected override string _GetTemplateForMessageConfirmSentSingle()
	{
		return "{userOne}ë‹˜ê³¼ ì¹œêµ¬ê°€ ë˜ì—ˆì–´ìš”!";
	}

	/// <summary>
	/// Key: "Message.DeveloperMetricsAvailable"
	/// English String: "{month} {year} Analytics Report for {gameName} available."
	/// </summary>
	public override string MessageDeveloperMetricsAvailable(string month, string year, string gameName)
	{
		return $"{gameName}ì˜ {year} {month} ë¶„ì„ ë³´ê³ ì„œë¥¼ ì´ìš©í•  ìˆ˜ ìžˆì–´ìš”.";
	}

	protected override string _GetTemplateForMessageDeveloperMetricsAvailable()
	{
		return "{gameName}ì˜ {year} {month} ë¶„ì„ ë³´ê³ ì„œë¥¼ ì´ìš©í•  ìˆ˜ ìžˆì–´ìš”.";
	}

	protected override string _GetTemplateForMessageDeveloperMetricsAvailableMultiple()
	{
		return "{gameName} ë° {otherCount, plural, =1 {#ê°œ ê¸°íƒ€ ê²Œìž„} other {# ê¸°íƒ€ ê²Œìž„}}ì˜ {year} {month} ë¶„ì„ ë³´ê³ ì„œë¥¼ ì´ìš©í•  ìˆ˜ ìžˆì–´ìš”.";
	}

	/// <summary>
	/// Key: "Message.DeveloperMetricsAvailableMultiple2"
	/// English String: "{month} {year} Analytics Report for {gameCount} games available."
	/// </summary>
	public override string MessageDeveloperMetricsAvailableMultiple2(string month, string year, string gameCount)
	{
		return $"{gameCount}ê°œ ê²Œìž„ì˜ {year} {month} ë¶„ì„ ë³´ê³ ì„œë¥¼ ì´ìš©í•  ìˆ˜ ìžˆì–´ìš”.";
	}

	protected override string _GetTemplateForMessageDeveloperMetricsAvailableMultiple2()
	{
		return "{gameCount}ê°œ ê²Œìž„ì˜ {year} {month} ë¶„ì„ ë³´ê³ ì„œë¥¼ ì´ìš©í•  ìˆ˜ ìžˆì–´ìš”.";
	}

	/// <summary>
	/// Key: "Message.FriendRequestAcceptedDouble"
	/// English String: "{userOne} and {userTwo} accepted your friend request."
	/// </summary>
	public override string MessageFriendRequestAcceptedDouble(string userOne, string userTwo)
	{
		return $"{userOne}ë‹˜ê³¼ {userTwo}ë‹˜ì´ ì¹œêµ¬ ìš”ì²­ì„ ìˆ˜ë½í–ˆì–´ìš”.";
	}

	protected override string _GetTemplateForMessageFriendRequestAcceptedDouble()
	{
		return "{userOne}ë‹˜ê³¼ {userTwo}ë‹˜ì´ ì¹œêµ¬ ìš”ì²­ì„ ìˆ˜ë½í–ˆì–´ìš”.";
	}

	protected override string _GetTemplateForMessageFriendRequestAcceptedMultiple()
	{
		return "{userOne}ë‹˜, {userTwo}ë‹˜ ì™¸ {userMultipleCount, plural, =1 {#ëª…} other {#ëª…}}ì´ ì¹œêµ¬ ìš”ì²­ì„ ìˆ˜ë½í–ˆì–´ìš”.";
	}

	/// <summary>
	/// Key: "Message.FriendRequestAcceptedSingle"
	/// English String: "{userOne} accepted your friend request."
	/// </summary>
	public override string MessageFriendRequestAcceptedSingle(string userOne)
	{
		return $"{userOne}ë‹˜ì´ ì¹œêµ¬ ìš”ì²­ì„ ìˆ˜ë½í–ˆì–´ìš”.";
	}

	protected override string _GetTemplateForMessageFriendRequestAcceptedSingle()
	{
		return "{userOne}ë‹˜ì´ ì¹œêµ¬ ìš”ì²­ì„ ìˆ˜ë½í–ˆì–´ìš”.";
	}

	/// <summary>
	/// Key: "Message.FriendRequestSentDouble"
	/// English String: "{userOne} and {userTwo} sent you friend requests."
	/// </summary>
	public override string MessageFriendRequestSentDouble(string userOne, string userTwo)
	{
		return $"{userOne}ë‹˜ê³¼ {userTwo}ë‹˜ì´ ì¹œêµ¬ ìš”ì²­ì„ ë³´ëƒˆì–´ìš”.";
	}

	protected override string _GetTemplateForMessageFriendRequestSentDouble()
	{
		return "{userOne}ë‹˜ê³¼ {userTwo}ë‹˜ì´ ì¹œêµ¬ ìš”ì²­ì„ ë³´ëƒˆì–´ìš”.";
	}

	protected override string _GetTemplateForMessageFriendRequestSentMultiple()
	{
		return "{userOne}ë‹˜, {userTwo}ë‹˜ ì™¸ {userMultipleCount, plural, =1 {#ëª…} other {#ëª…}}ì´ ì¹œêµ¬ ìš”ì²­ì„ ë³´ëƒˆì–´ìš”.";
	}

	/// <summary>
	/// Key: "Message.FriendRequestSentSingle"
	/// English String: "{userOne} sent you a friend request."
	/// </summary>
	public override string MessageFriendRequestSentSingle(string userOne)
	{
		return $"{userOne}ë‹˜ì´ ì¹œêµ¬ ìš”ì²­ì„ ë³´ëƒˆì–´ìš”.";
	}

	protected override string _GetTemplateForMessageFriendRequestSentSingle()
	{
		return "{userOne}ë‹˜ì´ ì¹œêµ¬ ìš”ì²­ì„ ë³´ëƒˆì–´ìš”.";
	}

	protected override string _GetTemplateForMessageGameNotPlayableOnDevice()
	{
		return "ë³¸ ê¸°ê¸°ì—ì„œëŠ” í”Œë ˆì´í•  ìˆ˜ ì—†ì–´ìš”";
	}

	/// <summary>
	/// Key: "Message.MessageAndPreview"
	/// English String: "{titleStart}Message from {username}:{titleEnd} {message}"
	/// </summary>
	public override string MessageMessageAndPreview(string titleStart, string username, string titleEnd, string message)
	{
		return $"{titleStart}{username}ë‹˜ì˜ ë©”ì‹œì§€:{titleEnd} {message}";
	}

	protected override string _GetTemplateForMessageMessageAndPreview()
	{
		return "{titleStart}{username}ë‹˜ì˜ ë©”ì‹œì§€:{titleEnd} {message}";
	}

	/// <summary>
	/// Key: "Message.MessageFrom"
	/// English String: "Message from {username}:"
	/// </summary>
	public override string MessageMessageFrom(string username)
	{
		return $"{username}ë‹˜ì˜ ë©”ì‹œì§€: ";
	}

	protected override string _GetTemplateForMessageMessageFrom()
	{
		return "{username}ë‹˜ì˜ ë©”ì‹œì§€: ";
	}

	protected override string _GetTemplateForMessageNumberofNewNotifications()
	{
		return "{notificationCount, plural, =1 {ìƒˆ ì•Œë¦¼ #ê±´} other {ìƒˆ ì•Œë¦¼ #ê±´}}";
	}

	protected override string _GetTemplateForMessageTooManyFriendsOther()
	{
		return "í•´ë‹¹ ì‚¬ìš©ìžì˜ ì¹œêµ¬ ìˆ˜ê°€ í•œë„ì— ë„ë‹¬í–ˆì–´ìš”.";
	}

	protected override string _GetTemplateForMessageTooManyFriendsSelf()
	{
		return "ì¹œêµ¬ ìˆ˜ê°€ í•œë„ì— ë„ë‹¬í–ˆì–´ìš”.";
	}

	/// <summary>
	/// Key: "Message.UnfollowedGame"
	/// Message displayed in game update card after user unfollowed the game
	/// English String: "Unfollowed {gameName}"
	/// </summary>
	public override string MessageUnfollowedGame(string gameName)
	{
		return $"{gameName} íŒ”ë¡œìš° ì·¨ì†Œ";
	}

	protected override string _GetTemplateForMessageUnfollowedGame()
	{
		return "{gameName} íŒ”ë¡œìš° ì·¨ì†Œ";
	}

	protected override string _GetTemplateForMessageYouHaveNewFriendRequests()
	{
		return "{numberOfRequests}ê°œì˜ ìƒˆ {numberOfRequests, plural, =1 {ì¹œêµ¬ ìš”ì²­} other {ì¹œêµ¬ ìš”ì²­}}ì´ ë„ì°©í–ˆì–´ìš”.";
	}

	protected override string _GetTemplateForMessageYouHaveNewFriends()
	{
		return "{numberOfFriends}ëª…ì˜ ìƒˆ {numberOfFriends, plural, =1 {ì¹œêµ¬} other {ì¹œêµ¬}}ê°€ ìƒê²¼ì–´ìš”.";
	}

	protected override string _GetTemplateForMessageYouReceivedMessages()
	{
		return "{numberOfMessagesText}ê°œì˜ ìƒˆ {numberOfMessages, plural, =1 {ë©”ì‹œì§€} other {ë©”ì‹œì§€}}ê°€ ë„ì°©í–ˆì–´ìš”.";
	}
}


}
