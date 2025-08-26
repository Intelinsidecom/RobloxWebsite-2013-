namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides ChatResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ChatResources_zh_cjv : ChatResources_en_us, IChatResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Add"
	/// English String: "Add"
	/// </summary>
	public override string ActionAdd => "æ·»åŠ ";

	/// <summary>
	/// Key: "Action.BuyAccess"
	/// English String: "Buy Access"
	/// </summary>
	public override string ActionBuyAccess => "è´­ä¹°é€šè¡Œè¯";

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "å–æ¶ˆ";

	/// <summary>
	/// Key: "Action.Create"
	/// English String: "Create"
	/// </summary>
	public override string ActionCreate => "åˆ›å»º";

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
	public override string ActionJoinVoice => "";

	/// <summary>
	/// Key: "Action.Leave"
	/// English String: "Leave"
	/// </summary>
	public override string ActionLeave => "ç¦»å¼€";

	/// <summary>
	/// Key: "Action.LeaveVoice"
	/// Leave voice chat
	/// English String: "Leave"
	/// </summary>
	public override string ActionLeaveVoice => "";

	/// <summary>
	/// Key: "Action.Mute"
	/// mute microphone in short term
	/// English String: "Mute"
	/// </summary>
	public override string ActionMute => "";

	/// <summary>
	/// Key: "Action.MuteMic"
	/// English String: "Mute Your Microphone"
	/// </summary>
	public override string ActionMuteMic => "";

	/// <summary>
	/// Key: "Action.Remove"
	/// English String: "Remove"
	/// </summary>
	public override string ActionRemove => "ç§»é™¤";

	/// <summary>
	/// Key: "Action.Report"
	/// English String: "Report"
	/// </summary>
	public override string ActionReport => "ä¸¾æŠ¥";

	/// <summary>
	/// Key: "Action.Save"
	/// English String: "Save"
	/// </summary>
	public override string ActionSave => "ä¿å­˜";

	/// <summary>
	/// Key: "Action.Send"
	/// English String: "Send"
	/// </summary>
	public override string ActionSend => "å‘é€";

	/// <summary>
	/// Key: "Action.Set"
	/// English String: "Set"
	/// </summary>
	public override string ActionSet => "è®¾ç½®";

	/// <summary>
	/// Key: "Action.StartParty"
	/// button label
	/// English String: "Start a Party"
	/// </summary>
	public override string ActionStartParty => "å¼€å§‹ç»„é˜Ÿ";

	/// <summary>
	/// Key: "Action.Stay"
	/// English String: "Stay"
	/// </summary>
	public override string ActionStay => "ç•™ä¸‹";

	/// <summary>
	/// Key: "Action.TurnOn"
	/// English String: "Turn On"
	/// </summary>
	public override string ActionTurnOn => "å¼€å¯";

	/// <summary>
	/// Key: "Action.Unmute"
	/// unmute mic in short term
	/// English String: "Unmute"
	/// </summary>
	public override string ActionUnmute => "";

	/// <summary>
	/// Key: "Action.UnmuteMic"
	/// English String: "Unmute Your Microphone"
	/// </summary>
	public override string ActionUnmuteMic => "";

	/// <summary>
	/// Key: "Description.JoinInVoiceChat"
	/// English String: "Click Join to join the call"
	/// </summary>
	public override string DescriptionJoinInVoiceChat => "";

	/// <summary>
	/// Key: "Description.LeaveVoiceChat"
	/// English String: "Click Leave to leave the call"
	/// </summary>
	public override string DescriptionLeaveVoiceChat => "";

	/// <summary>
	/// Key: "Description.UserInVoice"
	/// User is actively in voice chat
	/// English String: "You are in the voice chat"
	/// </summary>
	public override string DescriptionUserInVoice => "";

	/// <summary>
	/// Key: "Description.VoiceNotConnect"
	/// Error handling message when voice chat api return errors
	/// English String: "Could not connect to voice chat"
	/// </summary>
	public override string DescriptionVoiceNotConnect => "";

	/// <summary>
	/// Key: "Heading.BuyItem"
	/// English String: "Buy Item"
	/// </summary>
	public override string HeadingBuyItem => "è´­ä¹°ç‰©å“";

	/// <summary>
	/// Key: "Heading.Chat"
	/// English String: "Chat"
	/// </summary>
	public override string HeadingChat => "èŠå¤©";

	public override string HeadingChatAndParty => "èŠå¤©ä¸Žé˜Ÿä¼";

	/// <summary>
	/// Key: "Heading.ConfirmLeaving"
	/// English String: "Are you sure to leave this chat group?"
	/// </summary>
	public override string HeadingConfirmLeaving => "æ˜¯å¦ç¡®å®šç¦»å¼€æ­¤ç¾¤èŠï¼Ÿ";

	/// <summary>
	/// Key: "Heading.ContinueToReport"
	/// English String: "Continue to report?"
	/// </summary>
	public override string HeadingContinueToReport => "ç»§ç»­ä¸¾æŠ¥ï¼Ÿ";

	/// <summary>
	/// Key: "Heading.CreateParty"
	/// English String: "Create Party"
	/// </summary>
	public override string HeadingCreateParty => "åˆ›å»ºæ´¾å¯¹";

	/// <summary>
	/// Key: "Heading.LeaveChatGroup"
	/// English String: "Leave Chat Group"
	/// </summary>
	public override string HeadingLeaveChatGroup => "ç¦»å¼€ç¾¤èŠ";

	/// <summary>
	/// Key: "Heading.LeaveChatGroupQ"
	/// English String: "Leave Chat Group?"
	/// </summary>
	public override string HeadingLeaveChatGroupQ => "ç¦»å¼€ç¾¤èŠï¼Ÿ";

	/// <summary>
	/// Key: "Heading.NewChatGroup"
	/// English String: "New Chat Group"
	/// </summary>
	public override string HeadingNewChatGroup => "æ–°ç¾¤èŠ";

	/// <summary>
	/// Key: "Heading.RemoveUser"
	/// English String: "Remove User?"
	/// </summary>
	public override string HeadingRemoveUser => "ç§»é™¤ç”¨æˆ·ï¼Ÿ";

	/// <summary>
	/// Key: "Heading.Report"
	/// heading for abuse report dialog
	/// English String: "Report"
	/// </summary>
	public override string HeadingReport => "ä¸¾æŠ¥";

	/// <summary>
	/// Key: "Label.AddFriends"
	/// English String: "Add Friends"
	/// </summary>
	public override string LabelAddFriends => "æ·»åŠ å¥½å‹";

	/// <summary>
	/// Key: "Label.BuyButton"
	/// English String: "Buy"
	/// </summary>
	public override string LabelBuyButton => "è´­ä¹°";

	/// <summary>
	/// Key: "Label.ChangeChatGroupName"
	/// English String: "Change your chat group name"
	/// </summary>
	public override string LabelChangeChatGroupName => "æ›´æ”¹ä½ çš„ç¾¤èŠåç§°";

	/// <summary>
	/// Key: "Label.ChatDetails"
	/// English String: "Chat Details"
	/// </summary>
	public override string LabelChatDetails => "èŠå¤©è¯¦æƒ…";

	/// <summary>
	/// Key: "Label.ChatGroupName"
	/// English String: "Chat Group Name"
	/// </summary>
	public override string LabelChatGroupName => "ç¾¤èŠåç§°";

	/// <summary>
	/// Key: "Label.Close"
	/// English String: "Close"
	/// </summary>
	public override string LabelClose => "å…³é—­";

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
	public override string LabelConversationNotificationsOn => "å¼€å¯";

	/// <summary>
	/// Key: "Label.Details.PlayTogether"
	/// English String: "PlayTogether"
	/// </summary>
	public override string LabelDetailsPlayTogether => "ä¸€èµ·çŽ©";

	/// <summary>
	/// Key: "Label.FindGame"
	/// English String: "Find Game"
	/// </summary>
	public override string LabelFindGame => "æŸ¥æ‰¾æ¸¸æˆ";

	/// <summary>
	/// Key: "Label.GameNotAvailableButton"
	/// English String: "Not Available"
	/// </summary>
	public override string LabelGameNotAvailableButton => "ä¸å¯ç”¨";

	/// <summary>
	/// Key: "Label.General"
	/// English String: "General"
	/// </summary>
	public override string LabelGeneral => "é€šç”¨";

	/// <summary>
	/// Key: "Label.InCall"
	/// In voice call
	/// English String: "In Call"
	/// </summary>
	public override string LabelInCall => "";

	/// <summary>
	/// Key: "Label.InGame"
	/// English String: "In Game"
	/// </summary>
	public override string LabelInGame => "åœ¨æ¸¸æˆä¸­";

	/// <summary>
	/// Key: "Label.InputPlaceHolder.SearchForFriends"
	/// English String: "Search for friends"
	/// </summary>
	public override string LabelInputPlaceHolderSearchForFriends => "æœç´¢å¥½å‹";

	/// <summary>
	/// Key: "Label.InputPlaceHolder.SendMessage"
	/// English String: "Send a message"
	/// </summary>
	public override string LabelInputPlaceHolderSendMessage => "å‘é€ä¿¡æ¯";

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
	public override string LabelJoinGame => "åŠ å…¥æ¸¸æˆ";

	/// <summary>
	/// Key: "Label.JoinParty"
	/// English String: "Join Party"
	/// </summary>
	public override string LabelJoinParty => "åŠ å…¥é˜Ÿä¼";

	/// <summary>
	/// Key: "Label.LeaveChatGroup"
	/// English String: "Leave Chat Group"
	/// </summary>
	public override string LabelLeaveChatGroup => "ç¦»å¼€ç¾¤èŠ";

	/// <summary>
	/// Key: "Label.LeaveParty"
	/// English String: "Leave Party"
	/// </summary>
	public override string LabelLeaveParty => "ç¦»å¼€é˜Ÿä¼";

	/// <summary>
	/// Key: "Label.Member"
	/// English String: "Member"
	/// </summary>
	public override string LabelMember => "æˆå‘˜";

	/// <summary>
	/// Key: "Label.Members"
	/// English String: "Members"
	/// </summary>
	public override string LabelMembers => "æˆå‘˜";

	/// <summary>
	/// Key: "Label.Mute15Minutes"
	/// mute conversation for 15 mins
	/// English String: "For 15 minutes"
	/// </summary>
	public override string LabelMute15Minutes => "æŒç»­ 15 åˆ†é’Ÿ";

	/// <summary>
	/// Key: "Label.Mute1Hour"
	/// Mute conversation for 1 hour
	/// English String: "For an hour"
	/// </summary>
	public override string LabelMute1Hour => "æŒç»­ä¸€å°æ—¶";

	/// <summary>
	/// Key: "Label.Mute24Hours"
	/// Mute conversation for a day
	/// English String: "For a day"
	/// </summary>
	public override string LabelMute24Hours => "æŒç»­ä¸€å¤©";

	/// <summary>
	/// Key: "Label.Mute8Hours"
	/// Mute conversation for 8 hours
	/// English String: "For 8 hours"
	/// </summary>
	public override string LabelMute8Hours => "æŒç»­ 8 å°æ—¶";

	/// <summary>
	/// Key: "Label.MuteConversationNotificationsForGroup"
	/// English String: "Mute notifications for this chat group"
	/// </summary>
	public override string LabelMuteConversationNotificationsForGroup => "å°†æ­¤ç¾¤èŠçš„é€šçŸ¥é™éŸ³";

	/// <summary>
	/// Key: "Label.MuteConversationNotificationsForOneToOne"
	/// English String: "Mute notifications for this conversation"
	/// </summary>
	public override string LabelMuteConversationNotificationsForOneToOne => "å°†æ­¤å¯¹è¯çš„é€šçŸ¥é™éŸ³";

	/// <summary>
	/// Key: "Label.MuteInfinite"
	/// Mute conversation until user turns back
	/// English String: "Until I turn them back on"
	/// </summary>
	public override string LabelMuteInfinite => "ç›´åˆ°æˆ‘å…³é—­é™éŸ³ä¸ºæ­¢";

	/// <summary>
	/// Key: "Label.NameYourChangeGroup"
	/// English String: "Name your change group"
	/// </summary>
	public override string LabelNameYourChangeGroup => "å‘½åä½ çš„ç¾¤èŠ";

	/// <summary>
	/// Key: "Label.NameYourChatGroup"
	/// English String: "Name your chat group"
	/// </summary>
	public override string LabelNameYourChatGroup => "å‘½åä½ çš„ç¾¤èŠ";

	/// <summary>
	/// Key: "Label.NotImplementedMessageType"
	/// This message is displayed in chat when user receives message type that can't be rendered by current app version and update is not available, yet (e.g. latest version was rolled back, or in deprecated Android native chat)
	/// English String: "This message could not be displayed."
	/// </summary>
	public override string LabelNotImplementedMessageType => "ä¿¡æ¯æ— æ³•æ˜¾ç¤ºã€‚";

	/// <summary>
	/// Key: "Label.NotInCall"
	/// English String: "Not in call"
	/// </summary>
	public override string LabelNotInCall => "";

	/// <summary>
	/// Key: "Label.Offline"
	/// English String: "Offline"
	/// </summary>
	public override string LabelOffline => "ç¦»çº¿";

	/// <summary>
	/// Key: "Label.Online"
	/// English String: "Online"
	/// </summary>
	public override string LabelOnline => "åœ¨çº¿";

	/// <summary>
	/// Key: "Label.PinGameTooltip"
	/// English String: "Pin Game"
	/// </summary>
	public override string LabelPinGameTooltip => "ç½®é¡¶æ¸¸æˆ";

	/// <summary>
	/// Key: "Label.PinnedGame"
	/// This is a title of card, means this game card is pinned game
	/// English String: "Pinned Game"
	/// </summary>
	public override string LabelPinnedGame => "ç½®é¡¶æ¸¸æˆ";

	/// <summary>
	/// Key: "Label.PlayButton"
	/// English String: "Play"
	/// </summary>
	public override string LabelPlayButton => "å¼€å§‹æ¸¸æˆ";

	/// <summary>
	/// Key: "Label.PlayGames"
	/// English String: "Play Games"
	/// </summary>
	public override string LabelPlayGames => "å¼€å§‹æ¸¸æˆ";

	/// <summary>
	/// Key: "Label.PlayTogether"
	/// English String: "Play Together"
	/// </summary>
	public override string LabelPlayTogether => "ä¸€èµ·çŽ©";

	/// <summary>
	/// Key: "Label.RecommendedGames"
	/// English String: "Recommended"
	/// </summary>
	public override string LabelRecommendedGames => "æŽ¨è";

	/// <summary>
	/// Key: "Label.SeeLess"
	/// English String: "See Less"
	/// </summary>
	public override string LabelSeeLess => "æ”¶èµ·";

	/// <summary>
	/// Key: "Label.SeeMore"
	/// English String: "See More"
	/// </summary>
	public override string LabelSeeMore => "æŸ¥çœ‹æ›´å¤š";

	/// <summary>
	/// Key: "Label.ShowLessGames"
	/// English String: "Show Less"
	/// </summary>
	public override string LabelShowLessGames => "æ”¶èµ·";

	/// <summary>
	/// Key: "Label.SpanTitle.CreateGroupNeeds2More"
	/// English String: "Add at least 2 people to create chat group"
	/// </summary>
	public override string LabelSpanTitleCreateGroupNeeds2More => "æ·»åŠ è‡³å°‘ 2 äººä»¥åˆ›å»ºç¾¤èŠ";

	/// <summary>
	/// Key: "Label.SpanTitle.Loading"
	/// English String: "loading ..."
	/// </summary>
	public override string LabelSpanTitleLoading => "æ­£åœ¨åŠ è½½...";

	/// <summary>
	/// Key: "Label.TimestampOffUntilTomorrow"
	/// English String: "Off until tomorrow"
	/// </summary>
	public override string LabelTimestampOffUntilTomorrow => "åˆ°æ˜Žå¤©ä¸ºæ­¢ä¿æŒå…³é—­";

	/// <summary>
	/// Key: "Label.TimestampOffUntilTurnedBackOn"
	/// English String: "Off until turned back on\""
	/// </summary>
	public override string LabelTimestampOffUntilTurnedBackOn => "ç›´åˆ°é‡æ–°å¼€å¯ä¸€ç›´ä¿æŒå…³é—­";

	/// <summary>
	/// Key: "Label.TurnOnConversationNotificationsPrompt"
	/// English String: "Do you want to turn on notifications?"
	/// </summary>
	public override string LabelTurnOnConversationNotificationsPrompt => "æ˜¯å¦è¦å¼€å¯é€šçŸ¥åŠŸèƒ½ï¼Ÿ";

	/// <summary>
	/// Key: "Label.UnpinGameTooltip"
	/// English String: "Unpin Game"
	/// </summary>
	public override string LabelUnpinGameTooltip => "å–æ¶ˆç½®é¡¶æ¸¸æˆ";

	/// <summary>
	/// Key: "Label.ViewDetailsButton"
	/// English String: "View Details"
	/// </summary>
	public override string LabelViewDetailsButton => "æŸ¥çœ‹è¯¦æƒ…";

	/// <summary>
	/// Key: "Label.ViewProfile"
	/// English String: "View Profile"
	/// </summary>
	public override string LabelViewProfile => "æŸ¥çœ‹ä¸ªäººèµ„æ–™";

	/// <summary>
	/// Key: "Label.VoiceSetting"
	/// Voice chat setting label
	/// English String: "Voice Settings"
	/// </summary>
	public override string LabelVoiceSetting => "";

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
	public override string MessageConversationTitleModerated => "ç¾¤èŠåç§°å·²è¢«è¿‡æ»¤ã€‚";

	/// <summary>
	/// Key: "Message.Default"
	/// English String: "Not everyone in this chat can see your message."
	/// </summary>
	public override string MessageDefault => "ä¸æ˜¯æ‰€æœ‰åœ¨æ­¤èŠå¤©ä¸­çš„äººéƒ½èƒ½çœ‹åˆ°ä½ çš„ä¿¡æ¯ã€‚";

	/// <summary>
	/// Key: "Message.DefaultErrorMsg"
	/// English String: "An error occurred"
	/// </summary>
	public override string MessageDefaultErrorMsg => "å‘ç”Ÿé”™è¯¯";

	/// <summary>
	/// Key: "Message.Error"
	/// English String: "Error"
	/// </summary>
	public override string MessageError => "é”™è¯¯";

	/// <summary>
	/// Key: "Message.JoinPartyText"
	/// English String: "The party leader is finding a game to play."
	/// </summary>
	public override string MessageJoinPartyText => "é˜Ÿé•¿æ­£åœ¨å¯»æ‰¾ä¸€èµ·çŽ©çš„æ¸¸æˆã€‚";

	/// <summary>
	/// Key: "Message.MakeFriendsToChatNPlay"
	/// English String: "Make friends to start chatting and partying!"
	/// </summary>
	public override string MessageMakeFriendsToChatNPlay => "ç»“äº¤å¥½å‹ï¼Œå¼€å§‹èŠå¤©çŽ©è€ï¼";

	/// <summary>
	/// Key: "Message.MessageContentModerated"
	/// English String: "Your message was moderated and not sent."
	/// </summary>
	public override string MessageMessageContentModerated => "ä½ çš„ä¿¡æ¯å·²è¢«è¿‡æ»¤ï¼Œæœªèƒ½å‘é€ã€‚";

	/// <summary>
	/// Key: "Message.MessageFilterForReceivers"
	/// English String: "Not everyone in this chat can see your message."
	/// </summary>
	public override string MessageMessageFilterForReceivers => "ä¸æ˜¯æ‰€æœ‰åœ¨æ­¤èŠå¤©ä¸­çš„äººéƒ½èƒ½çœ‹åˆ°ä½ çš„ä¿¡æ¯ã€‚";

	/// <summary>
	/// Key: "Message.NoConnectionMsg"
	/// English String: "Connecting..."
	/// </summary>
	public override string MessageNoConnectionMsg => "æ­£åœ¨è¿žæŽ¥...";

	/// <summary>
	/// Key: "Message.PartyInviteMsg"
	/// English String: "PARTY INVITE!"
	/// </summary>
	public override string MessagePartyInviteMsg => "é˜Ÿä¼é‚€è¯·ï¼";

	/// <summary>
	/// Key: "Message.PlayGameUpdate"
	/// English String: " is playing the pinned game: "
	/// </summary>
	public override string MessagePlayGameUpdate => " æ­£åœ¨çŽ©ç½®é¡¶æ¸¸æˆï¼š ";

	/// <summary>
	/// Key: "Message.TextTooLong"
	/// English String: "Your message was too long and not sent."
	/// </summary>
	public override string MessageTextTooLong => "ä½ çš„ä¿¡æ¯è¿‡é•¿ï¼Œæœªèƒ½å‘é€ã€‚";

	/// <summary>
	/// Key: "Message.UnknownMessageType"
	/// This serves as the fallback string for when an message type is received that the web chat does not know how to render.
	/// English String: "A message cannot be displayed"
	/// </summary>
	public override string MessageUnknownMessageType => "ä¿¡æ¯æ— æ³•æ˜¾ç¤º";

	/// <summary>
	/// Key: "PlayButton"
	/// English String: "Play"
	/// </summary>
	public override string PlayButton => "å¼€å§‹æ¸¸æˆ";

	/// <summary>
	/// Key: "Response.PartyInvite"
	/// notification message
	/// English String: "You received a party Invite."
	/// </summary>
	public override string ResponsePartyInvite => "ä½ æ”¶åˆ°é˜Ÿä¼é‚€è¯·ã€‚";

	public ChatResources_zh_cjv(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAdd()
	{
		return "æ·»åŠ ";
	}

	protected override string _GetTemplateForActionBuyAccess()
	{
		return "è´­ä¹°é€šè¡Œè¯";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "å–æ¶ˆ";
	}

	protected override string _GetTemplateForActionCreate()
	{
		return "åˆ›å»º";
	}

	protected override string _GetTemplateForActionJoin()
	{
		return "åŠ å…¥";
	}

	protected override string _GetTemplateForActionJoinVoice()
	{
		return "";
	}

	protected override string _GetTemplateForActionLeave()
	{
		return "ç¦»å¼€";
	}

	protected override string _GetTemplateForActionLeaveVoice()
	{
		return "";
	}

	protected override string _GetTemplateForActionMute()
	{
		return "";
	}

	protected override string _GetTemplateForActionMuteMic()
	{
		return "";
	}

	protected override string _GetTemplateForActionRemove()
	{
		return "ç§»é™¤";
	}

	protected override string _GetTemplateForActionReport()
	{
		return "ä¸¾æŠ¥";
	}

	protected override string _GetTemplateForActionSave()
	{
		return "ä¿å­˜";
	}

	protected override string _GetTemplateForActionSend()
	{
		return "å‘é€";
	}

	protected override string _GetTemplateForActionSet()
	{
		return "è®¾ç½®";
	}

	protected override string _GetTemplateForActionStartParty()
	{
		return "å¼€å§‹ç»„é˜Ÿ";
	}

	protected override string _GetTemplateForActionStay()
	{
		return "ç•™ä¸‹";
	}

	protected override string _GetTemplateForActionTurnOn()
	{
		return "å¼€å¯";
	}

	protected override string _GetTemplateForActionUnmute()
	{
		return "";
	}

	protected override string _GetTemplateForActionUnmuteMic()
	{
		return "";
	}

	protected override string _GetTemplateForDescriptionJoinInVoiceChat()
	{
		return "";
	}

	protected override string _GetTemplateForDescriptionLeaveVoiceChat()
	{
		return "";
	}

	protected override string _GetTemplateForDescriptionUserInVoice()
	{
		return "";
	}

	protected override string _GetTemplateForDescriptionVoiceNotConnect()
	{
		return "";
	}

	protected override string _GetTemplateForHeadingBuyItem()
	{
		return "è´­ä¹°ç‰©å“";
	}

	protected override string _GetTemplateForHeadingChat()
	{
		return "èŠå¤©";
	}

	protected override string _GetTemplateForHeadingChatAndParty()
	{
		return "èŠå¤©ä¸Žé˜Ÿä¼";
	}

	protected override string _GetTemplateForHeadingConfirmLeaving()
	{
		return "æ˜¯å¦ç¡®å®šç¦»å¼€æ­¤ç¾¤èŠï¼Ÿ";
	}

	protected override string _GetTemplateForHeadingContinueToReport()
	{
		return "ç»§ç»­ä¸¾æŠ¥ï¼Ÿ";
	}

	protected override string _GetTemplateForHeadingCreateParty()
	{
		return "åˆ›å»ºæ´¾å¯¹";
	}

	protected override string _GetTemplateForHeadingLeaveChatGroup()
	{
		return "ç¦»å¼€ç¾¤èŠ";
	}

	protected override string _GetTemplateForHeadingLeaveChatGroupQ()
	{
		return "ç¦»å¼€ç¾¤èŠï¼Ÿ";
	}

	protected override string _GetTemplateForHeadingNewChatGroup()
	{
		return "æ–°ç¾¤èŠ";
	}

	protected override string _GetTemplateForHeadingRemoveUser()
	{
		return "ç§»é™¤ç”¨æˆ·ï¼Ÿ";
	}

	protected override string _GetTemplateForHeadingReport()
	{
		return "ä¸¾æŠ¥";
	}

	protected override string _GetTemplateForLabelAddFriends()
	{
		return "æ·»åŠ å¥½å‹";
	}

	/// <summary>
	/// Key: "Label.BuyAccessToGameForModal"
	/// English String: "Would you like to buy access to the Place: {placeName} from {creatorName} for {robux}?"
	/// </summary>
	public override string LabelBuyAccessToGameForModal(string placeName, string creatorName, string robux)
	{
		return $"ä½ æ˜¯å¦è¦ä»¥ {robux} çš„ä»·æ ¼å‘â€œ{creatorName}â€è´­ä¹°åœºæ™¯â€œ{placeName}â€çš„é€šè¡Œè¯ï¼Ÿ";
	}

	protected override string _GetTemplateForLabelBuyAccessToGameForModal()
	{
		return "ä½ æ˜¯å¦è¦ä»¥ {robux} çš„ä»·æ ¼å‘â€œ{creatorName}â€è´­ä¹°åœºæ™¯â€œ{placeName}â€çš„é€šè¡Œè¯ï¼Ÿ";
	}

	protected override string _GetTemplateForLabelBuyButton()
	{
		return "è´­ä¹°";
	}

	protected override string _GetTemplateForLabelChangeChatGroupName()
	{
		return "æ›´æ”¹ä½ çš„ç¾¤èŠåç§°";
	}

	protected override string _GetTemplateForLabelChatDetails()
	{
		return "èŠå¤©è¯¦æƒ…";
	}

	protected override string _GetTemplateForLabelChatGroupName()
	{
		return "ç¾¤èŠåç§°";
	}

	protected override string _GetTemplateForLabelClose()
	{
		return "å…³é—­";
	}

	protected override string _GetTemplateForLabelConversationNotifications()
	{
		return "é€šçŸ¥";
	}

	protected override string _GetTemplateForLabelConversationNotificationsOn()
	{
		return "å¼€å¯";
	}

	protected override string _GetTemplateForLabelDetailsPlayTogether()
	{
		return "ä¸€èµ·çŽ©";
	}

	protected override string _GetTemplateForLabelFindGame()
	{
		return "æŸ¥æ‰¾æ¸¸æˆ";
	}

	protected override string _GetTemplateForLabelGameNotAvailableButton()
	{
		return "ä¸å¯ç”¨";
	}

	protected override string _GetTemplateForLabelGeneral()
	{
		return "é€šç”¨";
	}

	protected override string _GetTemplateForLabelInCall()
	{
		return "";
	}

	protected override string _GetTemplateForLabelInGame()
	{
		return "åœ¨æ¸¸æˆä¸­";
	}

	protected override string _GetTemplateForLabelInputPlaceHolderSearchForFriends()
	{
		return "æœç´¢å¥½å‹";
	}

	protected override string _GetTemplateForLabelInputPlaceHolderSendMessage()
	{
		return "å‘é€ä¿¡æ¯";
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
		return "åŠ å…¥æ¸¸æˆ";
	}

	protected override string _GetTemplateForLabelJoinParty()
	{
		return "åŠ å…¥é˜Ÿä¼";
	}

	protected override string _GetTemplateForLabelLeaveChatGroup()
	{
		return "ç¦»å¼€ç¾¤èŠ";
	}

	protected override string _GetTemplateForLabelLeaveParty()
	{
		return "ç¦»å¼€é˜Ÿä¼";
	}

	protected override string _GetTemplateForLabelMember()
	{
		return "æˆå‘˜";
	}

	/// <summary>
	/// Key: "Label.MemberJoinText"
	/// English String: "{userName} joined the party"
	/// </summary>
	public override string LabelMemberJoinText(string userName)
	{
		return $"â€œ{userName}â€œåŠ å…¥äº†é˜Ÿä¼";
	}

	protected override string _GetTemplateForLabelMemberJoinText()
	{
		return "â€œ{userName}â€œåŠ å…¥äº†é˜Ÿä¼";
	}

	protected override string _GetTemplateForLabelMembers()
	{
		return "æˆå‘˜";
	}

	protected override string _GetTemplateForLabelMute15Minutes()
	{
		return "æŒç»­ 15 åˆ†é’Ÿ";
	}

	protected override string _GetTemplateForLabelMute1Hour()
	{
		return "æŒç»­ä¸€å°æ—¶";
	}

	protected override string _GetTemplateForLabelMute24Hours()
	{
		return "æŒç»­ä¸€å¤©";
	}

	protected override string _GetTemplateForLabelMute8Hours()
	{
		return "æŒç»­ 8 å°æ—¶";
	}

	protected override string _GetTemplateForLabelMuteConversationNotificationsForGroup()
	{
		return "å°†æ­¤ç¾¤èŠçš„é€šçŸ¥é™éŸ³";
	}

	protected override string _GetTemplateForLabelMuteConversationNotificationsForOneToOne()
	{
		return "å°†æ­¤å¯¹è¯çš„é€šçŸ¥é™éŸ³";
	}

	protected override string _GetTemplateForLabelMuteInfinite()
	{
		return "ç›´åˆ°æˆ‘å…³é—­é™éŸ³ä¸ºæ­¢";
	}

	/// <summary>
	/// Key: "Label.MuteSomeone"
	/// this is a mistake should not url , please skip this
	/// English String: "Mute {username}"
	/// </summary>
	public override string LabelMuteSomeone(string username)
	{
		return "";
	}

	protected override string _GetTemplateForLabelMuteSomeone()
	{
		return "";
	}

	protected override string _GetTemplateForLabelNameYourChangeGroup()
	{
		return "å‘½åä½ çš„ç¾¤èŠ";
	}

	protected override string _GetTemplateForLabelNameYourChatGroup()
	{
		return "å‘½åä½ çš„ç¾¤èŠ";
	}

	protected override string _GetTemplateForLabelNotImplementedMessageType()
	{
		return "ä¿¡æ¯æ— æ³•æ˜¾ç¤ºã€‚";
	}

	protected override string _GetTemplateForLabelNotInCall()
	{
		return "";
	}

	protected override string _GetTemplateForLabelOffline()
	{
		return "ç¦»çº¿";
	}

	protected override string _GetTemplateForLabelOnline()
	{
		return "åœ¨çº¿";
	}

	/// <summary>
	/// Key: "Label.PartyLeaderTooltip"
	/// English String: "{userName} is the party leader"
	/// </summary>
	public override string LabelPartyLeaderTooltip(string userName)
	{
		return $"â€œ{userName}â€æ˜¯é˜Ÿé•¿";
	}

	protected override string _GetTemplateForLabelPartyLeaderTooltip()
	{
		return "â€œ{userName}â€æ˜¯é˜Ÿé•¿";
	}

	/// <summary>
	/// Key: "Label.PartyMemberTooltip"
	/// English String: "{userName} is in the party"
	/// </summary>
	public override string LabelPartyMemberTooltip(string userName)
	{
		return $"â€œ{userName}â€åœ¨é˜Ÿä¼ä¸­";
	}

	protected override string _GetTemplateForLabelPartyMemberTooltip()
	{
		return "â€œ{userName}â€åœ¨é˜Ÿä¼ä¸­";
	}

	/// <summary>
	/// Key: "Label.PartyName"
	/// English String: "Party : {title}"
	/// </summary>
	public override string LabelPartyName(string title)
	{
		return $"é˜Ÿä¼ï¼šâ€œ{title}â€";
	}

	protected override string _GetTemplateForLabelPartyName()
	{
		return "é˜Ÿä¼ï¼šâ€œ{title}â€";
	}

	/// <summary>
	/// Key: "Label.PendingMemberTooltip"
	/// English String: "{userName} is not in the party"
	/// </summary>
	public override string LabelPendingMemberTooltip(string userName)
	{
		return $"â€œ{userName}â€ä¸åœ¨é˜Ÿä¼ä¸­ ";
	}

	protected override string _GetTemplateForLabelPendingMemberTooltip()
	{
		return "â€œ{userName}â€ä¸åœ¨é˜Ÿä¼ä¸­ ";
	}

	protected override string _GetTemplateForLabelPinGameTooltip()
	{
		return "ç½®é¡¶æ¸¸æˆ";
	}

	protected override string _GetTemplateForLabelPinnedGame()
	{
		return "ç½®é¡¶æ¸¸æˆ";
	}

	protected override string _GetTemplateForLabelPlayButton()
	{
		return "å¼€å§‹æ¸¸æˆ";
	}

	protected override string _GetTemplateForLabelPlayGames()
	{
		return "å¼€å§‹æ¸¸æˆ";
	}

	/// <summary>
	/// Key: "Label.PlayingGame"
	/// English String: "Playing {game}"
	/// </summary>
	public override string LabelPlayingGame(string game)
	{
		return $"æ­£åœ¨çŽ©â€œ{game}â€";
	}

	protected override string _GetTemplateForLabelPlayingGame()
	{
		return "æ­£åœ¨çŽ©â€œ{game}â€";
	}

	protected override string _GetTemplateForLabelPlayTogether()
	{
		return "ä¸€èµ·çŽ©";
	}

	protected override string _GetTemplateForLabelRecommendedGames()
	{
		return "æŽ¨è";
	}

	protected override string _GetTemplateForLabelSeeLess()
	{
		return "æ”¶èµ·";
	}

	protected override string _GetTemplateForLabelSeeMore()
	{
		return "æŸ¥çœ‹æ›´å¤š";
	}

	protected override string _GetTemplateForLabelShowLessGames()
	{
		return "æ”¶èµ·";
	}

	/// <summary>
	/// Key: "Label.ShowMoreGames"
	/// English String: "Show More (+{count})"
	/// </summary>
	public override string LabelShowMoreGames(string count)
	{
		return $"æ˜¾ç¤ºæ›´å¤šï¼ˆ+{count} åï¼‰";
	}

	protected override string _GetTemplateForLabelShowMoreGames()
	{
		return "æ˜¾ç¤ºæ›´å¤šï¼ˆ+{count} åï¼‰";
	}

	protected override string _GetTemplateForLabelSpanTitleCreateGroupNeeds2More()
	{
		return "æ·»åŠ è‡³å°‘ 2 äººä»¥åˆ›å»ºç¾¤èŠ";
	}

	protected override string _GetTemplateForLabelSpanTitleLoading()
	{
		return "æ­£åœ¨åŠ è½½...";
	}

	/// <summary>
	/// Key: "Label.TimestampOffUntilCertainTime"
	/// English String: "Off until {timestamp}"
	/// </summary>
	public override string LabelTimestampOffUntilCertainTime(string timestamp)
	{
		return $"åˆ°{timestamp}ä¸ºæ­¢ä¿æŒå…³é—­";
	}

	protected override string _GetTemplateForLabelTimestampOffUntilCertainTime()
	{
		return "åˆ°{timestamp}ä¸ºæ­¢ä¿æŒå…³é—­";
	}

	protected override string _GetTemplateForLabelTimestampOffUntilTomorrow()
	{
		return "åˆ°æ˜Žå¤©ä¸ºæ­¢ä¿æŒå…³é—­";
	}

	protected override string _GetTemplateForLabelTimestampOffUntilTurnedBackOn()
	{
		return "ç›´åˆ°é‡æ–°å¼€å¯ä¸€ç›´ä¿æŒå…³é—­";
	}

	protected override string _GetTemplateForLabelTurnOnConversationNotificationsPrompt()
	{
		return "æ˜¯å¦è¦å¼€å¯é€šçŸ¥åŠŸèƒ½ï¼Ÿ";
	}

	/// <summary>
	/// Key: "Label.UnmuteUser"
	/// English String: "Unmute {username}"
	/// </summary>
	public override string LabelUnmuteUser(string username)
	{
		return "";
	}

	protected override string _GetTemplateForLabelUnmuteUser()
	{
		return "";
	}

	protected override string _GetTemplateForLabelUnpinGameTooltip()
	{
		return "å–æ¶ˆç½®é¡¶æ¸¸æˆ";
	}

	protected override string _GetTemplateForLabelViewDetailsButton()
	{
		return "æŸ¥çœ‹è¯¦æƒ…";
	}

	protected override string _GetTemplateForLabelViewProfile()
	{
		return "æŸ¥çœ‹ä¸ªäººèµ„æ–™";
	}

	protected override string _GetTemplateForLabelVoiceSetting()
	{
		return "";
	}

	protected override string _GetTemplateForLabelYesterday()
	{
		return "æ˜¨å¤©";
	}

	/// <summary>
	/// Key: "Lable.MuteUser"
	/// must user's voice chat
	/// English String: "Mute {username}"
	/// </summary>
	public override string LableMuteUser(string username)
	{
		return "";
	}

	protected override string _GetTemplateForLableMuteUser()
	{
		return "";
	}

	/// <summary>
	/// Key: "Message.ChatPrivacySetting"
	/// English String: "To chat with friends, turn on chat in your {frontLink}Privacy Settings{endLink}"
	/// </summary>
	public override string MessageChatPrivacySetting(string frontLink, string endLink)
	{
		return $"è¦ä¸Žå¥½å‹èŠå¤©ï¼Œè¯·åœ¨ä½ çš„{frontLink}éšç§è®¾ç½®{endLink}ä¸­å¼€å¯èŠå¤©åŠŸèƒ½";
	}

	protected override string _GetTemplateForMessageChatPrivacySetting()
	{
		return "è¦ä¸Žå¥½å‹èŠå¤©ï¼Œè¯·åœ¨ä½ çš„{frontLink}éšç§è®¾ç½®{endLink}ä¸­å¼€å¯èŠå¤©åŠŸèƒ½";
	}

	/// <summary>
	/// Key: "Message.conversationTitleChangedText"
	/// English String: "{userName} named the chat group: {groupName}"
	/// </summary>
	public override string MessageconversationTitleChangedText(string userName, string groupName)
	{
		return $"â€œ{userName}â€å·²å°†ç¾¤èŠå‘½åä¸ºâ€œ{groupName}â€";
	}

	protected override string _GetTemplateForMessageconversationTitleChangedText()
	{
		return "â€œ{userName}â€å·²å°†ç¾¤èŠå‘½åä¸ºâ€œ{groupName}â€";
	}

	protected override string _GetTemplateForMessageConversationTitleModerated()
	{
		return "ç¾¤èŠåç§°å·²è¢«è¿‡æ»¤ã€‚";
	}

	protected override string _GetTemplateForMessageDefault()
	{
		return "ä¸æ˜¯æ‰€æœ‰åœ¨æ­¤èŠå¤©ä¸­çš„äººéƒ½èƒ½çœ‹åˆ°ä½ çš„ä¿¡æ¯ã€‚";
	}

	protected override string _GetTemplateForMessageDefaultErrorMsg()
	{
		return "å‘ç”Ÿé”™è¯¯";
	}

	/// <summary>
	/// Key: "Message.DefaultTitleForMsg"
	/// English String: "{userName} says ..."
	/// </summary>
	public override string MessageDefaultTitleForMsg(string userName)
	{
		return $"â€œ{userName}â€è¯´...";
	}

	protected override string _GetTemplateForMessageDefaultTitleForMsg()
	{
		return "â€œ{userName}â€è¯´...";
	}

	/// <summary>
	/// Key: "Message.DefaultTitleForPartyInvite"
	/// English String: "Party invite from {userName}"
	/// </summary>
	public override string MessageDefaultTitleForPartyInvite(string userName)
	{
		return $"â€œ{userName}â€å‘æ¥çš„é˜Ÿä¼é‚€è¯·";
	}

	protected override string _GetTemplateForMessageDefaultTitleForPartyInvite()
	{
		return "â€œ{userName}â€å‘æ¥çš„é˜Ÿä¼é‚€è¯·";
	}

	protected override string _GetTemplateForMessageError()
	{
		return "é”™è¯¯";
	}

	/// <summary>
	/// Key: "Message.FindGameToPlay"
	/// English String: "{frontLink}Find Games{endLink} to play with your friends!"
	/// </summary>
	public override string MessageFindGameToPlay(string frontLink, string endLink)
	{
		return $"{frontLink}å¯»æ‰¾æ¸¸æˆ{endLink}ï¼Œä¸Žå¥½å‹ä¸€èµ·åŒä¹ï¼";
	}

	protected override string _GetTemplateForMessageFindGameToPlay()
	{
		return "{frontLink}å¯»æ‰¾æ¸¸æˆ{endLink}ï¼Œä¸Žå¥½å‹ä¸€èµ·åŒä¹ï¼";
	}

	protected override string _GetTemplateForMessageJoinPartyText()
	{
		return "é˜Ÿé•¿æ­£åœ¨å¯»æ‰¾ä¸€èµ·çŽ©çš„æ¸¸æˆã€‚";
	}

	protected override string _GetTemplateForMessageMakeFriendsToChatNPlay()
	{
		return "ç»“äº¤å¥½å‹ï¼Œå¼€å§‹èŠå¤©çŽ©è€ï¼";
	}

	protected override string _GetTemplateForMessageMessageContentModerated()
	{
		return "ä½ çš„ä¿¡æ¯å·²è¢«è¿‡æ»¤ï¼Œæœªèƒ½å‘é€ã€‚";
	}

	protected override string _GetTemplateForMessageMessageFilterForReceivers()
	{
		return "ä¸æ˜¯æ‰€æœ‰åœ¨æ­¤èŠå¤©ä¸­çš„äººéƒ½èƒ½çœ‹åˆ°ä½ çš„ä¿¡æ¯ã€‚";
	}

	protected override string _GetTemplateForMessageNoConnectionMsg()
	{
		return "æ­£åœ¨è¿žæŽ¥...";
	}

	protected override string _GetTemplateForMessagePartyInviteMsg()
	{
		return "é˜Ÿä¼é‚€è¯·ï¼";
	}

	/// <summary>
	/// Key: "Message.PinGameUpdate"
	/// users pinned game in conversation
	/// English String: "{userName} chose a game to play together: {gameName}"
	/// </summary>
	public override string MessagePinGameUpdate(string userName, string gameName)
	{
		return $"â€œ{userName}â€é€‰æ‹©äº†ä¸€ä¸ªä¸€èµ·çŽ©çš„æ¸¸æˆï¼šâ€œ{gameName}â€";
	}

	protected override string _GetTemplateForMessagePinGameUpdate()
	{
		return "â€œ{userName}â€é€‰æ‹©äº†ä¸€ä¸ªä¸€èµ·çŽ©çš„æ¸¸æˆï¼šâ€œ{gameName}â€";
	}

	protected override string _GetTemplateForMessagePlayGameUpdate()
	{
		return " æ­£åœ¨çŽ©ç½®é¡¶æ¸¸æˆï¼š ";
	}

	protected override string _GetTemplateForMessageTextTooLong()
	{
		return "ä½ çš„ä¿¡æ¯è¿‡é•¿ï¼Œæœªèƒ½å‘é€ã€‚";
	}

	/// <summary>
	/// Key: "Message.ToastText"
	/// English String: "You can have up to {friendNum} friends in chat group."
	/// </summary>
	public override string MessageToastText(string friendNum)
	{
		return $"ä½ çš„ç¾¤èŠä¸­æœ€å¤šå¯ä»¥æœ‰ {friendNum} ä½å¥½å‹ã€‚";
	}

	protected override string _GetTemplateForMessageToastText()
	{
		return "ä½ çš„ç¾¤èŠä¸­æœ€å¤šå¯ä»¥æœ‰ {friendNum} ä½å¥½å‹ã€‚";
	}

	protected override string _GetTemplateForMessageUnknownMessageType()
	{
		return "ä¿¡æ¯æ— æ³•æ˜¾ç¤º";
	}

	protected override string _GetTemplateForPlayButton()
	{
		return "å¼€å§‹æ¸¸æˆ";
	}

	protected override string _GetTemplateForResponsePartyInvite()
	{
		return "ä½ æ”¶åˆ°é˜Ÿä¼é‚€è¯·ã€‚";
	}
}


}
