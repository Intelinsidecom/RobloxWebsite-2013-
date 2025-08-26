namespace Roblox.Platform.TranslationResources.Notifications {
    /// <summary>

/// This class overrides NotificationStreamResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class NotificationStreamResources_ja_jp : NotificationStreamResources_en_us, INotificationStreamResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Accept"
	/// English String: "Accept"
	/// </summary>
	public override string ActionAccept => "æ‰¿èªã™ã‚‹";

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "ã‚­ãƒ£ãƒ³ã‚»ãƒ«";

	/// <summary>
	/// Key: "Action.Chat"
	/// English String: "Chat"
	/// </summary>
	public override string ActionChat => "ãƒãƒ£ãƒƒãƒˆ";

	/// <summary>
	/// Key: "Action.Ignore"
	/// English String: "Ignore"
	/// </summary>
	public override string ActionIgnore => "ç„¡è¦–ã™ã‚‹";

	/// <summary>
	/// Key: "Action.Play"
	/// Label for button to launch game.
	/// English String: "Play"
	/// </summary>
	public override string ActionPlay => "ãƒ—ãƒ¬ã‚¤";

	/// <summary>
	/// Key: "Action.ReportAbuse"
	/// Label for link to report a game update message
	/// English String: "Report Abuse"
	/// </summary>
	public override string ActionReportAbuse => "è¦ç´„é•åã‚’å ±å‘Š";

	/// <summary>
	/// Key: "Action.Undo"
	/// Label for Undo link to reverse the unfollow action
	/// English String: "Undo"
	/// </summary>
	public override string ActionUndo => "å–ã‚Šæ¶ˆã™";

	/// <summary>
	/// Key: "Action.View"
	/// English String: "View"
	/// </summary>
	public override string ActionView => "è¡¨ç¤º";

	/// <summary>
	/// Key: "Action.ViewAll"
	/// English String: "View All"
	/// </summary>
	public override string ActionViewAll => "ã™ã¹ã¦è¡¨ç¤º";

	/// <summary>
	/// Key: "Heading.BackToAllNotifications"
	/// Heading displayed in game updates view, containing back link to notifications main view.
	/// English String: "All Notifications"
	/// </summary>
	public override string HeadingBackToAllNotifications => "ã™ã¹ã¦ã®é€šçŸ¥";

	/// <summary>
	/// Key: "Label.NoNetworkConnectionText"
	/// English String: "Connecting..."
	/// </summary>
	public override string LabelNoNetworkConnectionText => "æŽ¥ç¶šä¸­...";

	/// <summary>
	/// Key: "Label.NoNotifications"
	/// English String: "No Notifications"
	/// </summary>
	public override string LabelNoNotifications => "é€šçŸ¥ã¯ã‚ã‚Šã¾ã›ã‚“";

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
	public override string MessageGameNotPlayableOnDevice => "ã“ã®ãƒ‡ãƒã‚¤ã‚¹ã§ã¯ãƒ—ãƒ¬ã‚¤ã§ãã¾ã›ã‚“";

	/// <summary>
	/// Key: "Message.TooManyFriendsOther"
	/// English String: "That user already has the max number of friends."
	/// </summary>
	public override string MessageTooManyFriendsOther => "ãã®ãƒ¦ãƒ¼ã‚¶ãƒ¼ã¯ã€ã“ã‚Œä»¥ä¸Šå‹é”ã‚’å¢—ã‚„ã›ã¾ã›ã‚“ã€‚";

	/// <summary>
	/// Key: "Message.TooManyFriendsSelf"
	/// English String: "You already have the max number of friends."
	/// </summary>
	public override string MessageTooManyFriendsSelf => "ã“ã‚Œä»¥ä¸Šå‹é”ã‚’å¢—ã‚„ã›ã¾ã›ã‚“ã€‚";

	public NotificationStreamResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAccept()
	{
		return "æ‰¿èªã™ã‚‹";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "ã‚­ãƒ£ãƒ³ã‚»ãƒ«";
	}

	protected override string _GetTemplateForActionChat()
	{
		return "ãƒãƒ£ãƒƒãƒˆ";
	}

	protected override string _GetTemplateForActionIgnore()
	{
		return "ç„¡è¦–ã™ã‚‹";
	}

	protected override string _GetTemplateForActionPlay()
	{
		return "ãƒ—ãƒ¬ã‚¤";
	}

	protected override string _GetTemplateForActionReportAbuse()
	{
		return "è¦ç´„é•åã‚’å ±å‘Š";
	}

	protected override string _GetTemplateForActionUndo()
	{
		return "å–ã‚Šæ¶ˆã™";
	}

	/// <summary>
	/// Key: "Action.UnfollowGame"
	/// Label of menu item to unfollow the game
	/// English String: "Unfollow {gameName}"
	/// </summary>
	public override string ActionUnfollowGame(string gameName)
	{
		return $"{gameName}ã®ãƒ•ã‚©ãƒ­ãƒ¼ã‚’ã‚„ã‚ã‚‹";
	}

	protected override string _GetTemplateForActionUnfollowGame()
	{
		return "{gameName}ã®ãƒ•ã‚©ãƒ­ãƒ¼ã‚’ã‚„ã‚ã‚‹";
	}

	protected override string _GetTemplateForActionView()
	{
		return "è¡¨ç¤º";
	}

	protected override string _GetTemplateForActionViewAll()
	{
		return "ã™ã¹ã¦è¡¨ç¤º";
	}

	protected override string _GetTemplateForHeadingBackToAllNotifications()
	{
		return "ã™ã¹ã¦ã®é€šçŸ¥";
	}

	protected override string _GetTemplateForLabelNoNetworkConnectionText()
	{
		return "æŽ¥ç¶šä¸­...";
	}

	protected override string _GetTemplateForLabelNoNotifications()
	{
		return "é€šçŸ¥ã¯ã‚ã‚Šã¾ã›ã‚“";
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
		return $"{gameOne}ã¨{gameTwo}ãŒã‚¢ãƒƒãƒ—ãƒ‡ãƒ¼ãƒˆã‚’é€ä¿¡ã—ã¾ã—ãŸã€‚";
	}

	protected override string _GetTemplateForMessageAggregatedGameUpdateDouble()
	{
		return "{gameOne}ã¨{gameTwo}ãŒã‚¢ãƒƒãƒ—ãƒ‡ãƒ¼ãƒˆã‚’é€ä¿¡ã—ã¾ã—ãŸã€‚";
	}

	protected override string _GetTemplateForMessageAggregatedGameUpdateMultiple()
	{
		return "{gameOne}ã€{gameTwo}ã€ä»–{otherCount, plural, =1 {# ç¨®é¡žã®ã‚²ãƒ¼ãƒ } other {# ç¨®é¡žã®ã‚²ãƒ¼ãƒ }}ãŒã‚¢ãƒƒãƒ—ãƒ‡ãƒ¼ãƒˆã‚’é€ä¿¡ã—ã¾ã—ãŸã€‚";
	}

	/// <summary>
	/// Key: "Message.ConfirmAcceptedDouble"
	/// English String: "{userOne} and {userTwo}"
	/// </summary>
	public override string MessageConfirmAcceptedDouble(string userOne, string userTwo)
	{
		return $"{userOne}ã•ã‚“ã¨{userTwo}ã•ã‚“";
	}

	protected override string _GetTemplateForMessageConfirmAcceptedDouble()
	{
		return "{userOne}ã•ã‚“ã¨{userTwo}ã•ã‚“";
	}

	protected override string _GetTemplateForMessageConfirmAcceptedMultiple()
	{
		return "{userOne}ã•ã‚“ã€{userTwo}ã•ã‚“ã€ä»–{userMultipleCount, plural, =1 {äºº} other {äºº}}";
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
		return $"{userOne}ã•ã‚“ã¨{userTwo}ã•ã‚“ãŒå‹é”ã«ãªã‚Šã¾ã—ãŸï¼";
	}

	protected override string _GetTemplateForMessageConfirmSentDouble()
	{
		return "{userOne}ã•ã‚“ã¨{userTwo}ã•ã‚“ãŒå‹é”ã«ãªã‚Šã¾ã—ãŸï¼";
	}

	protected override string _GetTemplateForMessageConfirmSentMultiple()
	{
		return "{userOne}ã•ã‚“ã€{userTwo}ã•ã‚“ã€ä»–{userMultipleCount, plural, =1 {äºº} other {äºº}}ãŒã€å‹é”ã«ãªã‚Šã¾ã—ãŸï¼";
	}

	/// <summary>
	/// Key: "Message.ConfirmSentSingle"
	/// English String: "{userOne} is now your friend!"
	/// </summary>
	public override string MessageConfirmSentSingle(string userOne)
	{
		return $"{userOne}ã•ã‚“ãŒå‹é”ã«ãªã‚Šã¾ã—ãŸï¼";
	}

	protected override string _GetTemplateForMessageConfirmSentSingle()
	{
		return "{userOne}ã•ã‚“ãŒå‹é”ã«ãªã‚Šã¾ã—ãŸï¼";
	}

	/// <summary>
	/// Key: "Message.DeveloperMetricsAvailable"
	/// English String: "{month} {year} Analytics Report for {gameName} available."
	/// </summary>
	public override string MessageDeveloperMetricsAvailable(string month, string year, string gameName)
	{
		return $"{month} {year} ã®{gameName} ã®è§£æžãƒ¬ãƒãƒ¼ãƒˆãŒå­˜åœ¨ã—ã¾ã™.";
	}

	protected override string _GetTemplateForMessageDeveloperMetricsAvailable()
	{
		return "{month} {year} ã®{gameName} ã®è§£æžãƒ¬ãƒãƒ¼ãƒˆãŒå­˜åœ¨ã—ã¾ã™.";
	}

	protected override string _GetTemplateForMessageDeveloperMetricsAvailableMultiple()
	{
		return "{gameName} ã® {year} {month} ã®è§£æžãƒ¬ãƒãƒ¼ãƒˆã¨ {otherCount, plural, =1 {# ä»¶ã®ä»–ã®ã‚²ãƒ¼ãƒ } other {# ä»¶ã®ä»–ã®ã‚²ãƒ¼ãƒ }}ã®ã‚‚ã®ãŒã‚ã‚Šã¾ã™";
	}

	/// <summary>
	/// Key: "Message.DeveloperMetricsAvailableMultiple2"
	/// English String: "{month} {year} Analytics Report for {gameCount} games available."
	/// </summary>
	public override string MessageDeveloperMetricsAvailableMultiple2(string month, string year, string gameCount)
	{
		return $"{year} {month} ã® {gameCount} ä»¶ã®ã‚²ãƒ¼ãƒ è§£æžãƒ¬ãƒãƒ¼ãƒˆãŒã‚ã‚Šã¾ã™ã€‚";
	}

	protected override string _GetTemplateForMessageDeveloperMetricsAvailableMultiple2()
	{
		return "{year} {month} ã® {gameCount} ä»¶ã®ã‚²ãƒ¼ãƒ è§£æžãƒ¬ãƒãƒ¼ãƒˆãŒã‚ã‚Šã¾ã™ã€‚";
	}

	/// <summary>
	/// Key: "Message.FriendRequestAcceptedDouble"
	/// English String: "{userOne} and {userTwo} accepted your friend request."
	/// </summary>
	public override string MessageFriendRequestAcceptedDouble(string userOne, string userTwo)
	{
		return $"{userOne}ã•ã‚“ã¨{userTwo}ã•ã‚“ãŒã€ã‚ãªãŸã®å‹é”ãƒªã‚¯ã‚¨ã‚¹ãƒˆã‚’æ‰¿èªã—ã¾ã—ãŸã€‚";
	}

	protected override string _GetTemplateForMessageFriendRequestAcceptedDouble()
	{
		return "{userOne}ã•ã‚“ã¨{userTwo}ã•ã‚“ãŒã€ã‚ãªãŸã®å‹é”ãƒªã‚¯ã‚¨ã‚¹ãƒˆã‚’æ‰¿èªã—ã¾ã—ãŸã€‚";
	}

	protected override string _GetTemplateForMessageFriendRequestAcceptedMultiple()
	{
		return "{userOne}ã•ã‚“ã€{userTwo}ã•ã‚“ã€ä»–{userMultipleCount, plural, =1 {# äºº} other {# äºº}}ãŒã€ã‚ãªãŸã®å‹é”ãƒªã‚¯ã‚¨ã‚¹ãƒˆã‚’æ‰¿èªã—ã¾ã—ãŸã€‚";
	}

	/// <summary>
	/// Key: "Message.FriendRequestAcceptedSingle"
	/// English String: "{userOne} accepted your friend request."
	/// </summary>
	public override string MessageFriendRequestAcceptedSingle(string userOne)
	{
		return $"{userOne}ã•ã‚“ãŒã€ã‚ãªãŸã®å‹é”ãƒªã‚¯ã‚¨ã‚¹ãƒˆã‚’æ‰¿èªã—ã¾ã—ãŸã€‚";
	}

	protected override string _GetTemplateForMessageFriendRequestAcceptedSingle()
	{
		return "{userOne}ã•ã‚“ãŒã€ã‚ãªãŸã®å‹é”ãƒªã‚¯ã‚¨ã‚¹ãƒˆã‚’æ‰¿èªã—ã¾ã—ãŸã€‚";
	}

	/// <summary>
	/// Key: "Message.FriendRequestSentDouble"
	/// English String: "{userOne} and {userTwo} sent you friend requests."
	/// </summary>
	public override string MessageFriendRequestSentDouble(string userOne, string userTwo)
	{
		return $"{userOne} ã•ã‚“ã¨{userTwo} ã•ã‚“ã‹ã‚‰å‹é”ãƒªã‚¯ã‚¨ã‚¹ãƒˆãŒå±Šãã¾ã—ãŸã€‚";
	}

	protected override string _GetTemplateForMessageFriendRequestSentDouble()
	{
		return "{userOne} ã•ã‚“ã¨{userTwo} ã•ã‚“ã‹ã‚‰å‹é”ãƒªã‚¯ã‚¨ã‚¹ãƒˆãŒå±Šãã¾ã—ãŸã€‚";
	}

	protected override string _GetTemplateForMessageFriendRequestSentMultiple()
	{
		return "{userOne}ã•ã‚“ã€{userTwo}ã•ã‚“ã€ä»–{userMultipleCount, plural, =1 {äºº} other {äºº}}ã‹ã‚‰å‹é”ãƒªã‚¯ã‚¨ã‚¹ãƒˆãŒå±Šãã¾ã—ãŸã€‚";
	}

	/// <summary>
	/// Key: "Message.FriendRequestSentSingle"
	/// English String: "{userOne} sent you a friend request."
	/// </summary>
	public override string MessageFriendRequestSentSingle(string userOne)
	{
		return $"{userOne} ã•ã‚“ã‹ã‚‰å‹é”ãƒªã‚¯ã‚¨ã‚¹ãƒˆãŒå±Šãã¾ã—ãŸã€‚";
	}

	protected override string _GetTemplateForMessageFriendRequestSentSingle()
	{
		return "{userOne} ã•ã‚“ã‹ã‚‰å‹é”ãƒªã‚¯ã‚¨ã‚¹ãƒˆãŒå±Šãã¾ã—ãŸã€‚";
	}

	protected override string _GetTemplateForMessageGameNotPlayableOnDevice()
	{
		return "ã“ã®ãƒ‡ãƒã‚¤ã‚¹ã§ã¯ãƒ—ãƒ¬ã‚¤ã§ãã¾ã›ã‚“";
	}

	/// <summary>
	/// Key: "Message.MessageAndPreview"
	/// English String: "{titleStart}Message from {username}:{titleEnd} {message}"
	/// </summary>
	public override string MessageMessageAndPreview(string titleStart, string username, string titleEnd, string message)
	{
		return $"{titleStart}{username}ã•ã‚“ã‹ã‚‰ã®ãƒ¡ãƒƒã‚»ãƒ¼ã‚¸:{titleEnd} {message}";
	}

	protected override string _GetTemplateForMessageMessageAndPreview()
	{
		return "{titleStart}{username}ã•ã‚“ã‹ã‚‰ã®ãƒ¡ãƒƒã‚»ãƒ¼ã‚¸:{titleEnd} {message}";
	}

	/// <summary>
	/// Key: "Message.MessageFrom"
	/// English String: "Message from {username}:"
	/// </summary>
	public override string MessageMessageFrom(string username)
	{
		return $"{username}ã•ã‚“ã‹ã‚‰ã®ãƒ¡ãƒƒã‚»ãƒ¼ã‚¸:";
	}

	protected override string _GetTemplateForMessageMessageFrom()
	{
		return "{username}ã•ã‚“ã‹ã‚‰ã®ãƒ¡ãƒƒã‚»ãƒ¼ã‚¸:";
	}

	protected override string _GetTemplateForMessageNumberofNewNotifications()
	{
		return "{notificationCount, plural, =1 {# æ–°ç€é€šçŸ¥} other {# æ–°ç€é€šçŸ¥}}";
	}

	protected override string _GetTemplateForMessageTooManyFriendsOther()
	{
		return "ãã®ãƒ¦ãƒ¼ã‚¶ãƒ¼ã¯ã€ã“ã‚Œä»¥ä¸Šå‹é”ã‚’å¢—ã‚„ã›ã¾ã›ã‚“ã€‚";
	}

	protected override string _GetTemplateForMessageTooManyFriendsSelf()
	{
		return "ã“ã‚Œä»¥ä¸Šå‹é”ã‚’å¢—ã‚„ã›ã¾ã›ã‚“ã€‚";
	}

	/// <summary>
	/// Key: "Message.UnfollowedGame"
	/// Message displayed in game update card after user unfollowed the game
	/// English String: "Unfollowed {gameName}"
	/// </summary>
	public override string MessageUnfollowedGame(string gameName)
	{
		return $"{gameName}ã®ãƒ•ã‚©ãƒ­ãƒ¼ã‚’ã‚„ã‚ã¾ã—ãŸ";
	}

	protected override string _GetTemplateForMessageUnfollowedGame()
	{
		return "{gameName}ã®ãƒ•ã‚©ãƒ­ãƒ¼ã‚’ã‚„ã‚ã¾ã—ãŸ";
	}

	protected override string _GetTemplateForMessageYouHaveNewFriendRequests()
	{
		return "{numberOfRequests}ä»¶ã®{numberOfRequests, plural, =1 {å‹é”ãƒªã‚¯ã‚¨ã‚¹ãƒˆ} other {å‹é”ãƒªã‚¯ã‚¨ã‚¹ãƒˆ}}ãŒå±Šãã¾ã—ãŸã€‚";
	}

	protected override string _GetTemplateForMessageYouHaveNewFriends()
	{
		return "{numberOfFriends}äººã®{numberOfFriends, plural, =1 {å‹é”} other {å‹é”}}ãŒã§ãã¾ã—ãŸã€‚";
	}

	protected override string _GetTemplateForMessageYouReceivedMessages()
	{
		return "{numberOfMessagesText}ä»¶ã®{numberOfMessages, plural, =1 {ãƒ¡ãƒƒã‚»ãƒ¼ã‚¸} other {ãƒ¡ãƒƒã‚»ãƒ¼ã‚¸}}ãŒå±Šãã¾ã—ãŸ";
	}
}


}
