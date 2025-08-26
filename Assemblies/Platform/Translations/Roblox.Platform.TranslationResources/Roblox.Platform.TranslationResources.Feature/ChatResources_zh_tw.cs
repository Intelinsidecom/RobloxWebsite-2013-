namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides ChatResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ChatResources_zh_tw : ChatResources_en_us, IChatResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Add"
	/// English String: "Add"
	/// </summary>
	public override string ActionAdd => "æ–°å¢ž";

	/// <summary>
	/// Key: "Action.BuyAccess"
	/// English String: "Buy Access"
	/// </summary>
	public override string ActionBuyAccess => "è³¼è²·é€šè¡Œæ¬Š";

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "å–æ¶ˆ";

	/// <summary>
	/// Key: "Action.Create"
	/// English String: "Create"
	/// </summary>
	public override string ActionCreate => "å»ºç«‹";

	/// <summary>
	/// Key: "Action.Join"
	/// join the voice chat conversation
	/// English String: "Join"
	/// </summary>
	public override string ActionJoin => "åŠ å…¥";

	/// <summary>
	/// Key: "Action.JoinVoice"
	/// Join voice call
	/// English String: "Join"
	/// </summary>
	public override string ActionJoinVoice => "åŠ å…¥";

	/// <summary>
	/// Key: "Action.Leave"
	/// English String: "Leave"
	/// </summary>
	public override string ActionLeave => "é›¢é–‹";

	/// <summary>
	/// Key: "Action.LeaveVoice"
	/// Leave voice chat
	/// English String: "Leave"
	/// </summary>
	public override string ActionLeaveVoice => "é›¢é–‹";

	/// <summary>
	/// Key: "Action.Mute"
	/// mute microphone in short term
	/// English String: "Mute"
	/// </summary>
	public override string ActionMute => "éœéŸ³";

	/// <summary>
	/// Key: "Action.MuteMic"
	/// English String: "Mute Your Microphone"
	/// </summary>
	public override string ActionMuteMic => "éœéŸ³éº¥å…‹é¢¨";

	/// <summary>
	/// Key: "Action.Remove"
	/// English String: "Remove"
	/// </summary>
	public override string ActionRemove => "ç§»é™¤";

	/// <summary>
	/// Key: "Action.Report"
	/// English String: "Report"
	/// </summary>
	public override string ActionReport => "æª¢èˆ‰";

	/// <summary>
	/// Key: "Action.Save"
	/// English String: "Save"
	/// </summary>
	public override string ActionSave => "å„²å­˜";

	/// <summary>
	/// Key: "Action.Send"
	/// English String: "Send"
	/// </summary>
	public override string ActionSend => "å‚³é€";

	/// <summary>
	/// Key: "Action.Set"
	/// English String: "Set"
	/// </summary>
	public override string ActionSet => "è¨­å®š";

	/// <summary>
	/// Key: "Action.StartParty"
	/// button label
	/// English String: "Start a Party"
	/// </summary>
	public override string ActionStartParty => "å»ºç«‹éšŠä¼";

	/// <summary>
	/// Key: "Action.Stay"
	/// English String: "Stay"
	/// </summary>
	public override string ActionStay => "å–æ¶ˆ";

	/// <summary>
	/// Key: "Action.TurnOn"
	/// English String: "Turn On"
	/// </summary>
	public override string ActionTurnOn => "é–‹å•Ÿ";

	/// <summary>
	/// Key: "Action.Unmute"
	/// unmute mic in short term
	/// English String: "Unmute"
	/// </summary>
	public override string ActionUnmute => "è§£é™¤éœéŸ³";

	/// <summary>
	/// Key: "Action.UnmuteMic"
	/// English String: "Unmute Your Microphone"
	/// </summary>
	public override string ActionUnmuteMic => "è§£é™¤éœéŸ³éº¥å…‹é¢¨";

	/// <summary>
	/// Key: "Description.JoinInVoiceChat"
	/// English String: "Click Join to join the call"
	/// </summary>
	public override string DescriptionJoinInVoiceChat => "æŒ‰ä¸‹ã€ŒåŠ å…¥ã€åŠ å…¥èªžéŸ³é€šè©±";

	/// <summary>
	/// Key: "Description.LeaveVoiceChat"
	/// English String: "Click Leave to leave the call"
	/// </summary>
	public override string DescriptionLeaveVoiceChat => "æŒ‰ä¸‹ã€Œé›¢é–‹ã€é›¢é–‹èªžéŸ³é€šè©±";

	/// <summary>
	/// Key: "Description.UserInVoice"
	/// User is actively in voice chat
	/// English String: "You are in the voice chat"
	/// </summary>
	public override string DescriptionUserInVoice => "æ‚¨åœ¨èªžéŸ³é€šè©±è£¡";

	/// <summary>
	/// Key: "Description.VoiceNotConnect"
	/// Error handling message when voice chat api return errors
	/// English String: "Could not connect to voice chat"
	/// </summary>
	public override string DescriptionVoiceNotConnect => "ç„¡æ³•é€£ç·šåˆ°èªžéŸ³é€šè©±";

	/// <summary>
	/// Key: "Heading.BuyItem"
	/// English String: "Buy Item"
	/// </summary>
	public override string HeadingBuyItem => "è³¼è²·é“å…·";

	/// <summary>
	/// Key: "Heading.Chat"
	/// English String: "Chat"
	/// </summary>
	public override string HeadingChat => "èŠå¤©";

	public override string HeadingChatAndParty => "èŠå¤©èˆ‡éšŠä¼";

	/// <summary>
	/// Key: "Heading.ConfirmLeaving"
	/// English String: "Are you sure to leave this chat group?"
	/// </summary>
	public override string HeadingConfirmLeaving => "ç¢ºå®šé›¢é–‹æ­¤ç¾¤çµ„ï¼Ÿ";

	/// <summary>
	/// Key: "Heading.ContinueToReport"
	/// English String: "Continue to report?"
	/// </summary>
	public override string HeadingContinueToReport => "æª¢èˆ‰æ­¤çŽ©å®¶ï¼Ÿ";

	/// <summary>
	/// Key: "Heading.CreateParty"
	/// English String: "Create Party"
	/// </summary>
	public override string HeadingCreateParty => "å»ºç«‹éšŠä¼";

	/// <summary>
	/// Key: "Heading.LeaveChatGroup"
	/// English String: "Leave Chat Group"
	/// </summary>
	public override string HeadingLeaveChatGroup => "é›¢é–‹ç¾¤çµ„";

	/// <summary>
	/// Key: "Heading.LeaveChatGroupQ"
	/// English String: "Leave Chat Group?"
	/// </summary>
	public override string HeadingLeaveChatGroupQ => "é›¢é–‹ç¾¤çµ„ï¼Ÿ";

	/// <summary>
	/// Key: "Heading.NewChatGroup"
	/// English String: "New Chat Group"
	/// </summary>
	public override string HeadingNewChatGroup => "æ–°å¢žç¾¤çµ„";

	/// <summary>
	/// Key: "Heading.RemoveUser"
	/// English String: "Remove User?"
	/// </summary>
	public override string HeadingRemoveUser => "ç§»é™¤ä½¿ç”¨è€…ï¼Ÿ";

	/// <summary>
	/// Key: "Heading.Report"
	/// heading for abuse report dialog
	/// English String: "Report"
	/// </summary>
	public override string HeadingReport => "æª¢èˆ‰";

	/// <summary>
	/// Key: "Label.AddFriends"
	/// English String: "Add Friends"
	/// </summary>
	public override string LabelAddFriends => "æ–°å¢žå¥½å‹";

	/// <summary>
	/// Key: "Label.BuyButton"
	/// English String: "Buy"
	/// </summary>
	public override string LabelBuyButton => "è³¼è²·";

	/// <summary>
	/// Key: "Label.ChangeChatGroupName"
	/// English String: "Change your chat group name"
	/// </summary>
	public override string LabelChangeChatGroupName => "è®Šæ›´ç¾¤çµ„åç¨±";

	/// <summary>
	/// Key: "Label.ChatDetails"
	/// English String: "Chat Details"
	/// </summary>
	public override string LabelChatDetails => "èŠå¤©å®¤è³‡æ–™";

	/// <summary>
	/// Key: "Label.ChatGroupName"
	/// English String: "Chat Group Name"
	/// </summary>
	public override string LabelChatGroupName => "ç¾¤çµ„åç¨±";

	/// <summary>
	/// Key: "Label.Close"
	/// English String: "Close"
	/// </summary>
	public override string LabelClose => "é—œé–‰";

	/// <summary>
	/// Key: "Label.ConversationNotifications"
	/// conversation notification
	/// English String: "Notifications"
	/// </summary>
	public override string LabelConversationNotifications => "é€šçŸ¥";

	/// <summary>
	/// Key: "Label.ConversationNotificationsOn"
	/// conversation notification is on
	/// English String: "On"
	/// </summary>
	public override string LabelConversationNotificationsOn => "é–‹å•Ÿ";

	/// <summary>
	/// Key: "Label.Details.PlayTogether"
	/// English String: "PlayTogether"
	/// </summary>
	public override string LabelDetailsPlayTogether => "ä¸€èµ·çŽ©";

	/// <summary>
	/// Key: "Label.FindGame"
	/// English String: "Find Game"
	/// </summary>
	public override string LabelFindGame => "å°‹æ‰¾éŠæˆ²";

	/// <summary>
	/// Key: "Label.GameNotAvailableButton"
	/// English String: "Not Available"
	/// </summary>
	public override string LabelGameNotAvailableButton => "ç„¡æ³•ä½¿ç”¨";

	/// <summary>
	/// Key: "Label.General"
	/// English String: "General"
	/// </summary>
	public override string LabelGeneral => "ä¸€èˆ¬";

	/// <summary>
	/// Key: "Label.InCall"
	/// In voice call
	/// English String: "In Call"
	/// </summary>
	public override string LabelInCall => "é€šè©±ä¸­";

	/// <summary>
	/// Key: "Label.InGame"
	/// English String: "In Game"
	/// </summary>
	public override string LabelInGame => "éŠæˆ²ä¸­";

	/// <summary>
	/// Key: "Label.InputPlaceHolder.SearchForFriends"
	/// English String: "Search for friends"
	/// </summary>
	public override string LabelInputPlaceHolderSearchForFriends => "æœå°‹å¥½å‹";

	/// <summary>
	/// Key: "Label.InputPlaceHolder.SendMessage"
	/// English String: "Send a message"
	/// </summary>
	public override string LabelInputPlaceHolderSendMessage => "å‚³é€è¨Šæ¯";

	/// <summary>
	/// Key: "Label.InStudio"
	/// English String: "In Studio"
	/// </summary>
	public override string LabelInStudio => "åœ¨ Studio ä¸­";

	/// <summary>
	/// Key: "Label.JoinButton"
	/// English String: "Join"
	/// </summary>
	public override string LabelJoinButton => "åŠ å…¥";

	/// <summary>
	/// Key: "Label.JoinGame"
	/// English String: "Join Game"
	/// </summary>
	public override string LabelJoinGame => "åŠ å…¥éŠæˆ²";

	/// <summary>
	/// Key: "Label.JoinParty"
	/// English String: "Join Party"
	/// </summary>
	public override string LabelJoinParty => "åŠ å…¥éšŠä¼";

	/// <summary>
	/// Key: "Label.LeaveChatGroup"
	/// English String: "Leave Chat Group"
	/// </summary>
	public override string LabelLeaveChatGroup => "é›¢é–‹ç¾¤çµ„";

	/// <summary>
	/// Key: "Label.LeaveParty"
	/// English String: "Leave Party"
	/// </summary>
	public override string LabelLeaveParty => "é›¢é–‹éšŠä¼";

	/// <summary>
	/// Key: "Label.Member"
	/// English String: "Member"
	/// </summary>
	public override string LabelMember => "æˆå“¡";

	/// <summary>
	/// Key: "Label.Members"
	/// English String: "Members"
	/// </summary>
	public override string LabelMembers => "æˆå“¡";

	/// <summary>
	/// Key: "Label.Mute15Minutes"
	/// mute conversation for 15 mins
	/// English String: "For 15 minutes"
	/// </summary>
	public override string LabelMute15Minutes => "é–‹å•Ÿ 15 åˆ†é˜";

	/// <summary>
	/// Key: "Label.Mute1Hour"
	/// Mute conversation for 1 hour
	/// English String: "For an hour"
	/// </summary>
	public override string LabelMute1Hour => "é–‹å•Ÿ 1 å°æ™‚";

	/// <summary>
	/// Key: "Label.Mute24Hours"
	/// Mute conversation for a day
	/// English String: "For a day"
	/// </summary>
	public override string LabelMute24Hours => "é–‹å•Ÿ 1 å¤©";

	/// <summary>
	/// Key: "Label.Mute8Hours"
	/// Mute conversation for 8 hours
	/// English String: "For 8 hours"
	/// </summary>
	public override string LabelMute8Hours => "é–‹å•Ÿ 8 å°æ™‚";

	/// <summary>
	/// Key: "Label.MuteConversationNotificationsForGroup"
	/// English String: "Mute notifications for this chat group"
	/// </summary>
	public override string LabelMuteConversationNotificationsForGroup => "å°‡æ­¤ç¾¤çµ„çš„é€šçŸ¥éœéŸ³";

	/// <summary>
	/// Key: "Label.MuteConversationNotificationsForOneToOne"
	/// English String: "Mute notifications for this conversation"
	/// </summary>
	public override string LabelMuteConversationNotificationsForOneToOne => "å°‡æ­¤å°è©±çš„é€šçŸ¥éœéŸ³";

	/// <summary>
	/// Key: "Label.MuteInfinite"
	/// Mute conversation until user turns back
	/// English String: "Until I turn them back on"
	/// </summary>
	public override string LabelMuteInfinite => "ç›´åˆ°æˆ‘é‡æ–°é–‹å•Ÿç‚ºæ­¢";

	/// <summary>
	/// Key: "Label.NameYourChangeGroup"
	/// English String: "Name your change group"
	/// </summary>
	public override string LabelNameYourChangeGroup => "å‘½åç¾¤çµ„";

	/// <summary>
	/// Key: "Label.NameYourChatGroup"
	/// English String: "Name your chat group"
	/// </summary>
	public override string LabelNameYourChatGroup => "å‘½åç¾¤çµ„";

	/// <summary>
	/// Key: "Label.NotImplementedMessageType"
	/// This message is displayed in chat when user receives message type that can't be rendered by current app version and update is not available, yet (e.g. latest version was rolled back, or in deprecated Android native chat)
	/// English String: "This message could not be displayed."
	/// </summary>
	public override string LabelNotImplementedMessageType => "ç„¡æ³•é¡¯ç¤ºæ­¤è¨Šæ¯ã€‚";

	/// <summary>
	/// Key: "Label.NotInCall"
	/// English String: "Not in call"
	/// </summary>
	public override string LabelNotInCall => "æœªåŠ å…¥é€šè©±";

	/// <summary>
	/// Key: "Label.Offline"
	/// English String: "Offline"
	/// </summary>
	public override string LabelOffline => "é›¢ç·š";

	/// <summary>
	/// Key: "Label.Online"
	/// English String: "Online"
	/// </summary>
	public override string LabelOnline => "åœ¨ç·š";

	/// <summary>
	/// Key: "Label.PinGameTooltip"
	/// English String: "Pin Game"
	/// </summary>
	public override string LabelPinGameTooltip => "ç½®é ‚éŠæˆ²";

	/// <summary>
	/// Key: "Label.PinnedGame"
	/// This is a title of card, means this game card is pinned game
	/// English String: "Pinned Game"
	/// </summary>
	public override string LabelPinnedGame => "å·²ç½®é ‚çš„éŠæˆ²";

	/// <summary>
	/// Key: "Label.PlayButton"
	/// English String: "Play"
	/// </summary>
	public override string LabelPlayButton => "é–‹å§‹éŠæˆ²";

	/// <summary>
	/// Key: "Label.PlayGames"
	/// English String: "Play Games"
	/// </summary>
	public override string LabelPlayGames => "çŽ©éŠæˆ²";

	/// <summary>
	/// Key: "Label.PlayTogether"
	/// English String: "Play Together"
	/// </summary>
	public override string LabelPlayTogether => "ä¸€èµ·çŽ©";

	/// <summary>
	/// Key: "Label.RecommendedGames"
	/// English String: "Recommended"
	/// </summary>
	public override string LabelRecommendedGames => "æŽ¨è–¦";

	/// <summary>
	/// Key: "Label.SeeLess"
	/// English String: "See Less"
	/// </summary>
	public override string LabelSeeLess => "ç°¡é–±";

	/// <summary>
	/// Key: "Label.SeeMore"
	/// English String: "See More"
	/// </summary>
	public override string LabelSeeMore => "æŸ¥çœ‹æ›´å¤š";

	/// <summary>
	/// Key: "Label.ShowLessGames"
	/// English String: "Show Less"
	/// </summary>
	public override string LabelShowLessGames => "é¡¯ç¤ºæ›´å°‘";

	/// <summary>
	/// Key: "Label.SpanTitle.CreateGroupNeeds2More"
	/// English String: "Add at least 2 people to create chat group"
	/// </summary>
	public override string LabelSpanTitleCreateGroupNeeds2More => "åŠ å…¥è‡³å°‘ 2 ä½å¥½å‹ï¼Œå³å¯å»ºç«‹èŠå¤©ç¾¤çµ„";

	/// <summary>
	/// Key: "Label.SpanTitle.Loading"
	/// English String: "loading ..."
	/// </summary>
	public override string LabelSpanTitleLoading => "æ­£åœ¨è¼‰å…¥...";

	/// <summary>
	/// Key: "Label.TimestampOffUntilTomorrow"
	/// English String: "Off until tomorrow"
	/// </summary>
	public override string LabelTimestampOffUntilTomorrow => "é—œé–‰åˆ°æ˜Žå¤©ç‚ºæ­¢";

	/// <summary>
	/// Key: "Label.TimestampOffUntilTurnedBackOn"
	/// English String: "Off until turned back on\""
	/// </summary>
	public override string LabelTimestampOffUntilTurnedBackOn => "é—œé–‰åˆ°é‡æ–°é–‹å•Ÿç‚ºæ­¢";

	/// <summary>
	/// Key: "Label.TurnOnConversationNotificationsPrompt"
	/// English String: "Do you want to turn on notifications?"
	/// </summary>
	public override string LabelTurnOnConversationNotificationsPrompt => "æ‚¨è¦é–‹å•Ÿé€šçŸ¥åŠŸèƒ½å—Žï¼Ÿ";

	/// <summary>
	/// Key: "Label.UnpinGameTooltip"
	/// English String: "Unpin Game"
	/// </summary>
	public override string LabelUnpinGameTooltip => "å–æ¶ˆç½®é ‚éŠæˆ²";

	/// <summary>
	/// Key: "Label.ViewDetailsButton"
	/// English String: "View Details"
	/// </summary>
	public override string LabelViewDetailsButton => "æª¢è¦–è©³ç´°è³‡æ–™";

	/// <summary>
	/// Key: "Label.ViewProfile"
	/// English String: "View Profile"
	/// </summary>
	public override string LabelViewProfile => "æª¢è¦–å€‹äººæª”æ¡ˆ";

	/// <summary>
	/// Key: "Label.VoiceSetting"
	/// Voice chat setting label
	/// English String: "Voice Settings"
	/// </summary>
	public override string LabelVoiceSetting => "èªžéŸ³è¨­å®š";

	/// <summary>
	/// Key: "Label.Yesterday"
	/// time stamp for chat message received yesterday
	/// English String: "Yesterday"
	/// </summary>
	public override string LabelYesterday => "æ˜¨å¤©";

	/// <summary>
	/// Key: "Message.ConversationTitleModerated"
	/// Chat group name was moderated.
	/// English String: "Chat group name was moderated."
	/// </summary>
	public override string MessageConversationTitleModerated => "ç¾¤çµ„åç¨±é­åˆ°éŽæ¿¾ã€‚";

	/// <summary>
	/// Key: "Message.Default"
	/// English String: "Not everyone in this chat can see your message."
	/// </summary>
	public override string MessageDefault => "æŸäº›åœ¨æ­¤èŠå¤©å®¤çš„ä½¿ç”¨è€…å°‡çœ‹ä¸åˆ°æ‚¨çš„è¨Šæ¯ã€‚";

	/// <summary>
	/// Key: "Message.DefaultErrorMsg"
	/// English String: "An error occurred"
	/// </summary>
	public override string MessageDefaultErrorMsg => "ç™¼ç”ŸéŒ¯èª¤";

	/// <summary>
	/// Key: "Message.Error"
	/// English String: "Error"
	/// </summary>
	public override string MessageError => "éŒ¯èª¤";

	/// <summary>
	/// Key: "Message.JoinPartyText"
	/// English String: "The party leader is finding a game to play."
	/// </summary>
	public override string MessageJoinPartyText => "éšŠé•·æ­£åœ¨å°‹æ‰¾éŠæˆ²ã€‚";

	/// <summary>
	/// Key: "Message.MakeFriendsToChatNPlay"
	/// English String: "Make friends to start chatting and partying!"
	/// </summary>
	public override string MessageMakeFriendsToChatNPlay => "çµäº¤å¥½å‹ï¼Œé–‹å§‹èŠå¤©çŽ©è€ï¼";

	/// <summary>
	/// Key: "Message.MessageContentModerated"
	/// English String: "Your message was moderated and not sent."
	/// </summary>
	public override string MessageMessageContentModerated => "æ‚¨çš„è¨Šæ¯é­åˆ°éŽæ¿¾ï¼Œç„¡æ³•å‚³é€ã€‚";

	/// <summary>
	/// Key: "Message.MessageFilterForReceivers"
	/// English String: "Not everyone in this chat can see your message."
	/// </summary>
	public override string MessageMessageFilterForReceivers => "æŸäº›åœ¨æ­¤èŠå¤©å®¤çš„ä½¿ç”¨è€…å°‡çœ‹ä¸åˆ°æ‚¨çš„è¨Šæ¯ã€‚";

	/// <summary>
	/// Key: "Message.NoConnectionMsg"
	/// English String: "Connecting..."
	/// </summary>
	public override string MessageNoConnectionMsg => "æ­£åœ¨é€£ç·šâ€¦";

	/// <summary>
	/// Key: "Message.PartyInviteMsg"
	/// English String: "PARTY INVITE!"
	/// </summary>
	public override string MessagePartyInviteMsg => "èšæœƒé‚€è«‹ï¼";

	/// <summary>
	/// Key: "Message.PlayGameUpdate"
	/// English String: " is playing the pinned game: "
	/// </summary>
	public override string MessagePlayGameUpdate => " åœ¨çŽ©ç½®é ‚çš„éŠæˆ²ï¼š ";

	/// <summary>
	/// Key: "Message.TextTooLong"
	/// English String: "Your message was too long and not sent."
	/// </summary>
	public override string MessageTextTooLong => "æ‚¨çš„è¨Šæ¯éŽé•·ï¼Œç„¡æ³•å‚³é€ã€‚";

	/// <summary>
	/// Key: "Message.UnknownMessageType"
	/// This serves as the fallback string for when an message type is received that the web chat does not know how to render.
	/// English String: "A message cannot be displayed"
	/// </summary>
	public override string MessageUnknownMessageType => "ç„¡æ³•é¡¯ç¤ºè¨Šæ¯";

	/// <summary>
	/// Key: "PlayButton"
	/// English String: "Play"
	/// </summary>
	public override string PlayButton => "é–‹å§‹éŠæˆ²";

	/// <summary>
	/// Key: "Response.PartyInvite"
	/// notification message
	/// English String: "You received a party Invite."
	/// </summary>
	public override string ResponsePartyInvite => "æ‚¨æ”¶åˆ°éšŠä¼é‚€è«‹ã€‚";

	public ChatResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAdd()
	{
		return "æ–°å¢ž";
	}

	protected override string _GetTemplateForActionBuyAccess()
	{
		return "è³¼è²·é€šè¡Œæ¬Š";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "å–æ¶ˆ";
	}

	protected override string _GetTemplateForActionCreate()
	{
		return "å»ºç«‹";
	}

	protected override string _GetTemplateForActionJoin()
	{
		return "åŠ å…¥";
	}

	protected override string _GetTemplateForActionJoinVoice()
	{
		return "åŠ å…¥";
	}

	protected override string _GetTemplateForActionLeave()
	{
		return "é›¢é–‹";
	}

	protected override string _GetTemplateForActionLeaveVoice()
	{
		return "é›¢é–‹";
	}

	protected override string _GetTemplateForActionMute()
	{
		return "éœéŸ³";
	}

	protected override string _GetTemplateForActionMuteMic()
	{
		return "éœéŸ³éº¥å…‹é¢¨";
	}

	protected override string _GetTemplateForActionRemove()
	{
		return "ç§»é™¤";
	}

	protected override string _GetTemplateForActionReport()
	{
		return "æª¢èˆ‰";
	}

	protected override string _GetTemplateForActionSave()
	{
		return "å„²å­˜";
	}

	protected override string _GetTemplateForActionSend()
	{
		return "å‚³é€";
	}

	protected override string _GetTemplateForActionSet()
	{
		return "è¨­å®š";
	}

	protected override string _GetTemplateForActionStartParty()
	{
		return "å»ºç«‹éšŠä¼";
	}

	protected override string _GetTemplateForActionStay()
	{
		return "å–æ¶ˆ";
	}

	protected override string _GetTemplateForActionTurnOn()
	{
		return "é–‹å•Ÿ";
	}

	protected override string _GetTemplateForActionUnmute()
	{
		return "è§£é™¤éœéŸ³";
	}

	protected override string _GetTemplateForActionUnmuteMic()
	{
		return "è§£é™¤éœéŸ³éº¥å…‹é¢¨";
	}

	protected override string _GetTemplateForDescriptionJoinInVoiceChat()
	{
		return "æŒ‰ä¸‹ã€ŒåŠ å…¥ã€åŠ å…¥èªžéŸ³é€šè©±";
	}

	protected override string _GetTemplateForDescriptionLeaveVoiceChat()
	{
		return "æŒ‰ä¸‹ã€Œé›¢é–‹ã€é›¢é–‹èªžéŸ³é€šè©±";
	}

	protected override string _GetTemplateForDescriptionUserInVoice()
	{
		return "æ‚¨åœ¨èªžéŸ³é€šè©±è£¡";
	}

	protected override string _GetTemplateForDescriptionVoiceNotConnect()
	{
		return "ç„¡æ³•é€£ç·šåˆ°èªžéŸ³é€šè©±";
	}

	protected override string _GetTemplateForHeadingBuyItem()
	{
		return "è³¼è²·é“å…·";
	}

	protected override string _GetTemplateForHeadingChat()
	{
		return "èŠå¤©";
	}

	protected override string _GetTemplateForHeadingChatAndParty()
	{
		return "èŠå¤©èˆ‡éšŠä¼";
	}

	protected override string _GetTemplateForHeadingConfirmLeaving()
	{
		return "ç¢ºå®šé›¢é–‹æ­¤ç¾¤çµ„ï¼Ÿ";
	}

	protected override string _GetTemplateForHeadingContinueToReport()
	{
		return "æª¢èˆ‰æ­¤çŽ©å®¶ï¼Ÿ";
	}

	protected override string _GetTemplateForHeadingCreateParty()
	{
		return "å»ºç«‹éšŠä¼";
	}

	protected override string _GetTemplateForHeadingLeaveChatGroup()
	{
		return "é›¢é–‹ç¾¤çµ„";
	}

	protected override string _GetTemplateForHeadingLeaveChatGroupQ()
	{
		return "é›¢é–‹ç¾¤çµ„ï¼Ÿ";
	}

	protected override string _GetTemplateForHeadingNewChatGroup()
	{
		return "æ–°å¢žç¾¤çµ„";
	}

	protected override string _GetTemplateForHeadingRemoveUser()
	{
		return "ç§»é™¤ä½¿ç”¨è€…ï¼Ÿ";
	}

	protected override string _GetTemplateForHeadingReport()
	{
		return "æª¢èˆ‰";
	}

	protected override string _GetTemplateForLabelAddFriends()
	{
		return "æ–°å¢žå¥½å‹";
	}

	/// <summary>
	/// Key: "Label.BuyAccessToGameForModal"
	/// English String: "Would you like to buy access to the Place: {placeName} from {creatorName} for {robux}?"
	/// </summary>
	public override string LabelBuyAccessToGameForModal(string placeName, string creatorName, string robux)
	{
		return $"æ‚¨è¦ä»¥ {robux} å‘ {creatorName} è³¼è²· {placeName} çš„ç©ºé–“é€šè¡Œæ¬Šå—Žï¼Ÿ";
	}

	protected override string _GetTemplateForLabelBuyAccessToGameForModal()
	{
		return "æ‚¨è¦ä»¥ {robux} å‘ {creatorName} è³¼è²· {placeName} çš„ç©ºé–“é€šè¡Œæ¬Šå—Žï¼Ÿ";
	}

	protected override string _GetTemplateForLabelBuyButton()
	{
		return "è³¼è²·";
	}

	protected override string _GetTemplateForLabelChangeChatGroupName()
	{
		return "è®Šæ›´ç¾¤çµ„åç¨±";
	}

	protected override string _GetTemplateForLabelChatDetails()
	{
		return "èŠå¤©å®¤è³‡æ–™";
	}

	protected override string _GetTemplateForLabelChatGroupName()
	{
		return "ç¾¤çµ„åç¨±";
	}

	protected override string _GetTemplateForLabelClose()
	{
		return "é—œé–‰";
	}

	protected override string _GetTemplateForLabelConversationNotifications()
	{
		return "é€šçŸ¥";
	}

	protected override string _GetTemplateForLabelConversationNotificationsOn()
	{
		return "é–‹å•Ÿ";
	}

	protected override string _GetTemplateForLabelDetailsPlayTogether()
	{
		return "ä¸€èµ·çŽ©";
	}

	protected override string _GetTemplateForLabelFindGame()
	{
		return "å°‹æ‰¾éŠæˆ²";
	}

	protected override string _GetTemplateForLabelGameNotAvailableButton()
	{
		return "ç„¡æ³•ä½¿ç”¨";
	}

	protected override string _GetTemplateForLabelGeneral()
	{
		return "ä¸€èˆ¬";
	}

	protected override string _GetTemplateForLabelInCall()
	{
		return "é€šè©±ä¸­";
	}

	protected override string _GetTemplateForLabelInGame()
	{
		return "éŠæˆ²ä¸­";
	}

	protected override string _GetTemplateForLabelInputPlaceHolderSearchForFriends()
	{
		return "æœå°‹å¥½å‹";
	}

	protected override string _GetTemplateForLabelInputPlaceHolderSendMessage()
	{
		return "å‚³é€è¨Šæ¯";
	}

	protected override string _GetTemplateForLabelInStudio()
	{
		return "åœ¨ Studio ä¸­";
	}

	protected override string _GetTemplateForLabelJoinButton()
	{
		return "åŠ å…¥";
	}

	protected override string _GetTemplateForLabelJoinGame()
	{
		return "åŠ å…¥éŠæˆ²";
	}

	protected override string _GetTemplateForLabelJoinParty()
	{
		return "åŠ å…¥éšŠä¼";
	}

	protected override string _GetTemplateForLabelLeaveChatGroup()
	{
		return "é›¢é–‹ç¾¤çµ„";
	}

	protected override string _GetTemplateForLabelLeaveParty()
	{
		return "é›¢é–‹éšŠä¼";
	}

	protected override string _GetTemplateForLabelMember()
	{
		return "æˆå“¡";
	}

	/// <summary>
	/// Key: "Label.MemberJoinText"
	/// English String: "{userName} joined the party"
	/// </summary>
	public override string LabelMemberJoinText(string userName)
	{
		return $"{userName} å·²åŠ å…¥éšŠä¼";
	}

	protected override string _GetTemplateForLabelMemberJoinText()
	{
		return "{userName} å·²åŠ å…¥éšŠä¼";
	}

	protected override string _GetTemplateForLabelMembers()
	{
		return "æˆå“¡";
	}

	protected override string _GetTemplateForLabelMute15Minutes()
	{
		return "é–‹å•Ÿ 15 åˆ†é˜";
	}

	protected override string _GetTemplateForLabelMute1Hour()
	{
		return "é–‹å•Ÿ 1 å°æ™‚";
	}

	protected override string _GetTemplateForLabelMute24Hours()
	{
		return "é–‹å•Ÿ 1 å¤©";
	}

	protected override string _GetTemplateForLabelMute8Hours()
	{
		return "é–‹å•Ÿ 8 å°æ™‚";
	}

	protected override string _GetTemplateForLabelMuteConversationNotificationsForGroup()
	{
		return "å°‡æ­¤ç¾¤çµ„çš„é€šçŸ¥éœéŸ³";
	}

	protected override string _GetTemplateForLabelMuteConversationNotificationsForOneToOne()
	{
		return "å°‡æ­¤å°è©±çš„é€šçŸ¥éœéŸ³";
	}

	protected override string _GetTemplateForLabelMuteInfinite()
	{
		return "ç›´åˆ°æˆ‘é‡æ–°é–‹å•Ÿç‚ºæ­¢";
	}

	protected override string _GetTemplateForLabelNameYourChangeGroup()
	{
		return "å‘½åç¾¤çµ„";
	}

	protected override string _GetTemplateForLabelNameYourChatGroup()
	{
		return "å‘½åç¾¤çµ„";
	}

	protected override string _GetTemplateForLabelNotImplementedMessageType()
	{
		return "ç„¡æ³•é¡¯ç¤ºæ­¤è¨Šæ¯ã€‚";
	}

	protected override string _GetTemplateForLabelNotInCall()
	{
		return "æœªåŠ å…¥é€šè©±";
	}

	protected override string _GetTemplateForLabelOffline()
	{
		return "é›¢ç·š";
	}

	protected override string _GetTemplateForLabelOnline()
	{
		return "åœ¨ç·š";
	}

	/// <summary>
	/// Key: "Label.PartyLeaderTooltip"
	/// English String: "{userName} is the party leader"
	/// </summary>
	public override string LabelPartyLeaderTooltip(string userName)
	{
		return $"{userName} æ˜¯éšŠé•·";
	}

	protected override string _GetTemplateForLabelPartyLeaderTooltip()
	{
		return "{userName} æ˜¯éšŠé•·";
	}

	/// <summary>
	/// Key: "Label.PartyMemberTooltip"
	/// English String: "{userName} is in the party"
	/// </summary>
	public override string LabelPartyMemberTooltip(string userName)
	{
		return $"{userName} åœ¨éšŠä¼ä¸­";
	}

	protected override string _GetTemplateForLabelPartyMemberTooltip()
	{
		return "{userName} åœ¨éšŠä¼ä¸­";
	}

	/// <summary>
	/// Key: "Label.PartyName"
	/// English String: "Party : {title}"
	/// </summary>
	public override string LabelPartyName(string title)
	{
		return $"éšŠä¼ï¼š{title}";
	}

	protected override string _GetTemplateForLabelPartyName()
	{
		return "éšŠä¼ï¼š{title}";
	}

	/// <summary>
	/// Key: "Label.PendingMemberTooltip"
	/// English String: "{userName} is not in the party"
	/// </summary>
	public override string LabelPendingMemberTooltip(string userName)
	{
		return $"{userName} ä¸åœ¨éšŠä¼ä¸­";
	}

	protected override string _GetTemplateForLabelPendingMemberTooltip()
	{
		return "{userName} ä¸åœ¨éšŠä¼ä¸­";
	}

	protected override string _GetTemplateForLabelPinGameTooltip()
	{
		return "ç½®é ‚éŠæˆ²";
	}

	protected override string _GetTemplateForLabelPinnedGame()
	{
		return "å·²ç½®é ‚çš„éŠæˆ²";
	}

	protected override string _GetTemplateForLabelPlayButton()
	{
		return "é–‹å§‹éŠæˆ²";
	}

	protected override string _GetTemplateForLabelPlayGames()
	{
		return "çŽ©éŠæˆ²";
	}

	/// <summary>
	/// Key: "Label.PlayingGame"
	/// English String: "Playing {game}"
	/// </summary>
	public override string LabelPlayingGame(string game)
	{
		return $"æ­£åœ¨çŽ© {game}";
	}

	protected override string _GetTemplateForLabelPlayingGame()
	{
		return "æ­£åœ¨çŽ© {game}";
	}

	protected override string _GetTemplateForLabelPlayTogether()
	{
		return "ä¸€èµ·çŽ©";
	}

	protected override string _GetTemplateForLabelRecommendedGames()
	{
		return "æŽ¨è–¦";
	}

	protected override string _GetTemplateForLabelSeeLess()
	{
		return "ç°¡é–±";
	}

	protected override string _GetTemplateForLabelSeeMore()
	{
		return "æŸ¥çœ‹æ›´å¤š";
	}

	protected override string _GetTemplateForLabelShowLessGames()
	{
		return "é¡¯ç¤ºæ›´å°‘";
	}

	/// <summary>
	/// Key: "Label.ShowMoreGames"
	/// English String: "Show More (+{count})"
	/// </summary>
	public override string LabelShowMoreGames(string count)
	{
		return $"é¡¯ç¤ºæ›´å¤šï¼ˆ+{count}ï¼‰";
	}

	protected override string _GetTemplateForLabelShowMoreGames()
	{
		return "é¡¯ç¤ºæ›´å¤šï¼ˆ+{count}ï¼‰";
	}

	protected override string _GetTemplateForLabelSpanTitleCreateGroupNeeds2More()
	{
		return "åŠ å…¥è‡³å°‘ 2 ä½å¥½å‹ï¼Œå³å¯å»ºç«‹èŠå¤©ç¾¤çµ„";
	}

	protected override string _GetTemplateForLabelSpanTitleLoading()
	{
		return "æ­£åœ¨è¼‰å…¥...";
	}

	/// <summary>
	/// Key: "Label.TimestampOffUntilCertainTime"
	/// English String: "Off until {timestamp}"
	/// </summary>
	public override string LabelTimestampOffUntilCertainTime(string timestamp)
	{
		return $"é—œé–‰åˆ° {timestamp} ç‚ºæ­¢";
	}

	protected override string _GetTemplateForLabelTimestampOffUntilCertainTime()
	{
		return "é—œé–‰åˆ° {timestamp} ç‚ºæ­¢";
	}

	protected override string _GetTemplateForLabelTimestampOffUntilTomorrow()
	{
		return "é—œé–‰åˆ°æ˜Žå¤©ç‚ºæ­¢";
	}

	protected override string _GetTemplateForLabelTimestampOffUntilTurnedBackOn()
	{
		return "é—œé–‰åˆ°é‡æ–°é–‹å•Ÿç‚ºæ­¢";
	}

	protected override string _GetTemplateForLabelTurnOnConversationNotificationsPrompt()
	{
		return "æ‚¨è¦é–‹å•Ÿé€šçŸ¥åŠŸèƒ½å—Žï¼Ÿ";
	}

	protected override string _GetTemplateForLabelUnpinGameTooltip()
	{
		return "å–æ¶ˆç½®é ‚éŠæˆ²";
	}

	protected override string _GetTemplateForLabelViewDetailsButton()
	{
		return "æª¢è¦–è©³ç´°è³‡æ–™";
	}

	protected override string _GetTemplateForLabelViewProfile()
	{
		return "æª¢è¦–å€‹äººæª”æ¡ˆ";
	}

	protected override string _GetTemplateForLabelVoiceSetting()
	{
		return "èªžéŸ³è¨­å®š";
	}

	protected override string _GetTemplateForLabelYesterday()
	{
		return "æ˜¨å¤©";
	}

	/// <summary>
	/// Key: "Message.ChatPrivacySetting"
	/// English String: "To chat with friends, turn on chat in your {frontLink}Privacy Settings{endLink}"
	/// </summary>
	public override string MessageChatPrivacySetting(string frontLink, string endLink)
	{
		return $"è‹¥è¦èˆ‡å¥½å‹èŠå¤©ï¼Œè«‹å…ˆåœ¨æ‚¨çš„{frontLink}éš±ç§æ¬Šè¨­å®š{endLink}ä¸­é–‹å•ŸèŠå¤©åŠŸèƒ½";
	}

	protected override string _GetTemplateForMessageChatPrivacySetting()
	{
		return "è‹¥è¦èˆ‡å¥½å‹èŠå¤©ï¼Œè«‹å…ˆåœ¨æ‚¨çš„{frontLink}éš±ç§æ¬Šè¨­å®š{endLink}ä¸­é–‹å•ŸèŠå¤©åŠŸèƒ½";
	}

	/// <summary>
	/// Key: "Message.conversationTitleChangedText"
	/// English String: "{userName} named the chat group: {groupName}"
	/// </summary>
	public override string MessageconversationTitleChangedText(string userName, string groupName)
	{
		return $"{userName} å°‡æ­¤ç¾¤çµ„å‘½åç‚º {groupName}";
	}

	protected override string _GetTemplateForMessageconversationTitleChangedText()
	{
		return "{userName} å°‡æ­¤ç¾¤çµ„å‘½åç‚º {groupName}";
	}

	protected override string _GetTemplateForMessageConversationTitleModerated()
	{
		return "ç¾¤çµ„åç¨±é­åˆ°éŽæ¿¾ã€‚";
	}

	protected override string _GetTemplateForMessageDefault()
	{
		return "æŸäº›åœ¨æ­¤èŠå¤©å®¤çš„ä½¿ç”¨è€…å°‡çœ‹ä¸åˆ°æ‚¨çš„è¨Šæ¯ã€‚";
	}

	protected override string _GetTemplateForMessageDefaultErrorMsg()
	{
		return "ç™¼ç”ŸéŒ¯èª¤";
	}

	/// <summary>
	/// Key: "Message.DefaultTitleForMsg"
	/// English String: "{userName} says ..."
	/// </summary>
	public override string MessageDefaultTitleForMsg(string userName)
	{
		return $"{userName} èªªâ€¦";
	}

	protected override string _GetTemplateForMessageDefaultTitleForMsg()
	{
		return "{userName} èªªâ€¦";
	}

	/// <summary>
	/// Key: "Message.DefaultTitleForPartyInvite"
	/// English String: "Party invite from {userName}"
	/// </summary>
	public override string MessageDefaultTitleForPartyInvite(string userName)
	{
		return $"{userName} çš„éšŠä¼é‚€è«‹";
	}

	protected override string _GetTemplateForMessageDefaultTitleForPartyInvite()
	{
		return "{userName} çš„éšŠä¼é‚€è«‹";
	}

	protected override string _GetTemplateForMessageError()
	{
		return "éŒ¯èª¤";
	}

	/// <summary>
	/// Key: "Message.FindGameToPlay"
	/// English String: "{frontLink}Find Games{endLink} to play with your friends!"
	/// </summary>
	public override string MessageFindGameToPlay(string frontLink, string endLink)
	{
		return $"{frontLink}å°‹æ‰¾éŠæˆ²{endLink}ï¼Œèˆ‡æ‚¨çš„å¥½å‹åŒæ¨‚ï¼";
	}

	protected override string _GetTemplateForMessageFindGameToPlay()
	{
		return "{frontLink}å°‹æ‰¾éŠæˆ²{endLink}ï¼Œèˆ‡æ‚¨çš„å¥½å‹åŒæ¨‚ï¼";
	}

	protected override string _GetTemplateForMessageJoinPartyText()
	{
		return "éšŠé•·æ­£åœ¨å°‹æ‰¾éŠæˆ²ã€‚";
	}

	protected override string _GetTemplateForMessageMakeFriendsToChatNPlay()
	{
		return "çµäº¤å¥½å‹ï¼Œé–‹å§‹èŠå¤©çŽ©è€ï¼";
	}

	protected override string _GetTemplateForMessageMessageContentModerated()
	{
		return "æ‚¨çš„è¨Šæ¯é­åˆ°éŽæ¿¾ï¼Œç„¡æ³•å‚³é€ã€‚";
	}

	protected override string _GetTemplateForMessageMessageFilterForReceivers()
	{
		return "æŸäº›åœ¨æ­¤èŠå¤©å®¤çš„ä½¿ç”¨è€…å°‡çœ‹ä¸åˆ°æ‚¨çš„è¨Šæ¯ã€‚";
	}

	protected override string _GetTemplateForMessageNoConnectionMsg()
	{
		return "æ­£åœ¨é€£ç·šâ€¦";
	}

	protected override string _GetTemplateForMessagePartyInviteMsg()
	{
		return "èšæœƒé‚€è«‹ï¼";
	}

	/// <summary>
	/// Key: "Message.PinGameUpdate"
	/// users pinned game in conversation
	/// English String: "{userName} chose a game to play together: {gameName}"
	/// </summary>
	public override string MessagePinGameUpdate(string userName, string gameName)
	{
		return $"{userName} é¸æ“‡äº†ä¸€èµ·çŽ©çš„éŠæˆ²ï¼š{gameName}";
	}

	protected override string _GetTemplateForMessagePinGameUpdate()
	{
		return "{userName} é¸æ“‡äº†ä¸€èµ·çŽ©çš„éŠæˆ²ï¼š{gameName}";
	}

	protected override string _GetTemplateForMessagePlayGameUpdate()
	{
		return " åœ¨çŽ©ç½®é ‚çš„éŠæˆ²ï¼š ";
	}

	protected override string _GetTemplateForMessageTextTooLong()
	{
		return "æ‚¨çš„è¨Šæ¯éŽé•·ï¼Œç„¡æ³•å‚³é€ã€‚";
	}

	/// <summary>
	/// Key: "Message.ToastText"
	/// English String: "You can have up to {friendNum} friends in chat group."
	/// </summary>
	public override string MessageToastText(string friendNum)
	{
		return $"æ‚¨çš„ç¾¤çµ„æœ€å¤šå¯ä»¥æœ‰ {friendNum} ä½å¥½å‹ã€‚";
	}

	protected override string _GetTemplateForMessageToastText()
	{
		return "æ‚¨çš„ç¾¤çµ„æœ€å¤šå¯ä»¥æœ‰ {friendNum} ä½å¥½å‹ã€‚";
	}

	protected override string _GetTemplateForMessageUnknownMessageType()
	{
		return "ç„¡æ³•é¡¯ç¤ºè¨Šæ¯";
	}

	protected override string _GetTemplateForPlayButton()
	{
		return "é–‹å§‹éŠæˆ²";
	}

	protected override string _GetTemplateForResponsePartyInvite()
	{
		return "æ‚¨æ”¶åˆ°éšŠä¼é‚€è«‹ã€‚";
	}
}


}
