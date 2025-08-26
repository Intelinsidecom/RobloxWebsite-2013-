namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides ChatResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ChatResources_ja_jp : ChatResources_en_us, IChatResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Add"
	/// English String: "Add"
	/// </summary>
	public override string ActionAdd => "è¿½åŠ ";

	/// <summary>
	/// Key: "Action.BuyAccess"
	/// English String: "Buy Access"
	/// </summary>
	public override string ActionBuyAccess => "ã‚¢ã‚¯ã‚»ã‚¹ã‚’è²·ã†";

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "ã‚­ãƒ£ãƒ³ã‚»ãƒ«";

	/// <summary>
	/// Key: "Action.Create"
	/// English String: "Create"
	/// </summary>
	public override string ActionCreate => "ä½œæˆ";

	/// <summary>
	/// Key: "Action.Join"
	/// join the voice chat conversation
	/// English String: "Join"
	/// </summary>
	public override string ActionJoin => "å‚åŠ ";

	/// <summary>
	/// Key: "Action.JoinVoice"
	/// Join voice call
	/// English String: "Join"
	/// </summary>
	public override string ActionJoinVoice => "å‚åŠ ";

	/// <summary>
	/// Key: "Action.Leave"
	/// English String: "Leave"
	/// </summary>
	public override string ActionLeave => "ã‚„ã‚ã‚‹";

	/// <summary>
	/// Key: "Action.Mute"
	/// mute microphone in short term
	/// English String: "Mute"
	/// </summary>
	public override string ActionMute => "æ¶ˆéŸ³";

	/// <summary>
	/// Key: "Action.MuteMic"
	/// English String: "Mute Your Microphone"
	/// </summary>
	public override string ActionMuteMic => "ãƒžã‚¤ã‚¯ã‚’ãƒŸãƒ¥ãƒ¼ãƒˆ";

	/// <summary>
	/// Key: "Action.Remove"
	/// English String: "Remove"
	/// </summary>
	public override string ActionRemove => "å‰Šé™¤";

	/// <summary>
	/// Key: "Action.Report"
	/// English String: "Report"
	/// </summary>
	public override string ActionReport => "å ±å‘Šã™ã‚‹";

	/// <summary>
	/// Key: "Action.Save"
	/// English String: "Save"
	/// </summary>
	public override string ActionSave => "ä¿å­˜";

	/// <summary>
	/// Key: "Action.Send"
	/// English String: "Send"
	/// </summary>
	public override string ActionSend => "é€ä¿¡";

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
	public override string ActionStartParty => "ãƒ‘ãƒ¼ãƒ†ã‚£ã‚’çµæˆã™ã‚‹";

	/// <summary>
	/// Key: "Action.Stay"
	/// English String: "Stay"
	/// </summary>
	public override string ActionStay => "ãã®ã¾ã¾";

	/// <summary>
	/// Key: "Action.TurnOn"
	/// English String: "Turn On"
	/// </summary>
	public override string ActionTurnOn => "ã‚ªãƒ³ã«ã™ã‚‹";

	/// <summary>
	/// Key: "Action.Unmute"
	/// unmute mic in short term
	/// English String: "Unmute"
	/// </summary>
	public override string ActionUnmute => "ãƒŸãƒ¥ãƒ¼ãƒˆè§£é™¤";

	/// <summary>
	/// Key: "Action.UnmuteMic"
	/// English String: "Unmute Your Microphone"
	/// </summary>
	public override string ActionUnmuteMic => "ãƒžã‚¤ã‚¯ã‚’ãƒŸãƒ¥ãƒ¼ãƒˆè§£é™¤";

	/// <summary>
	/// Key: "Description.JoinInVoiceChat"
	/// English String: "Click Join to join the call"
	/// </summary>
	public override string DescriptionJoinInVoiceChat => "é€šè©±ã«å‚åŠ ã™ã‚‹ã«ã¯å‚åŠ ã‚’ã‚¯ãƒªãƒƒã‚¯";

	/// <summary>
	/// Key: "Description.UserInVoice"
	/// User is actively in voice chat
	/// English String: "You are in the voice chat"
	/// </summary>
	public override string DescriptionUserInVoice => "ãƒœã‚¤ã‚¹ãƒãƒ£ãƒƒãƒˆä¸­ã§ã™";

	/// <summary>
	/// Key: "Description.VoiceNotConnect"
	/// Error handling message when voice chat api return errors
	/// English String: "Could not connect to voice chat"
	/// </summary>
	public override string DescriptionVoiceNotConnect => "ãƒœã‚¤ã‚¹ãƒãƒ£ãƒƒãƒˆã«æŽ¥ç¶šã§ãã¾ã›ã‚“ã§ã—ãŸ";

	/// <summary>
	/// Key: "Heading.BuyItem"
	/// English String: "Buy Item"
	/// </summary>
	public override string HeadingBuyItem => "ã‚¢ã‚¤ãƒ†ãƒ ã‚’è²·ã†";

	/// <summary>
	/// Key: "Heading.Chat"
	/// English String: "Chat"
	/// </summary>
	public override string HeadingChat => "ãƒãƒ£ãƒƒãƒˆ";

	public override string HeadingChatAndParty => "ãƒãƒ£ãƒƒãƒˆã¨ãƒ‘ãƒ¼ãƒ†ã‚£";

	/// <summary>
	/// Key: "Heading.ConfirmLeaving"
	/// English String: "Are you sure to leave this chat group?"
	/// </summary>
	public override string HeadingConfirmLeaving => "ã“ã®ãƒãƒ£ãƒƒãƒˆã‚°ãƒ«ãƒ¼ãƒ—ã‚’çµ‚äº†ã—ã¦ã‚ˆã‚ã—ã„ã§ã™ã‹ï¼Ÿ";

	/// <summary>
	/// Key: "Heading.ContinueToReport"
	/// English String: "Continue to report?"
	/// </summary>
	public override string HeadingContinueToReport => "å ±å‘Šã—ã¾ã™ã‹ï¼Ÿ";

	/// <summary>
	/// Key: "Heading.CreateParty"
	/// English String: "Create Party"
	/// </summary>
	public override string HeadingCreateParty => "ãƒ‘ãƒ¼ãƒ†ã‚£ã‚’ä½œæˆ";

	/// <summary>
	/// Key: "Heading.LeaveChatGroup"
	/// English String: "Leave Chat Group"
	/// </summary>
	public override string HeadingLeaveChatGroup => "ãƒãƒ£ãƒƒãƒˆã‚°ãƒ«ãƒ¼ãƒ—ã‚’çµ‚äº†";

	/// <summary>
	/// Key: "Heading.LeaveChatGroupQ"
	/// English String: "Leave Chat Group?"
	/// </summary>
	public override string HeadingLeaveChatGroupQ => "ãƒãƒ£ãƒƒãƒˆã‚°ãƒ«ãƒ¼ãƒ—ã‚’çµ‚äº†ã—ã¾ã™ã‹ï¼Ÿ";

	/// <summary>
	/// Key: "Heading.NewChatGroup"
	/// English String: "New Chat Group"
	/// </summary>
	public override string HeadingNewChatGroup => "æ–°è¦ãƒãƒ£ãƒƒãƒˆã‚°ãƒ«ãƒ¼ãƒ—";

	/// <summary>
	/// Key: "Heading.RemoveUser"
	/// English String: "Remove User?"
	/// </summary>
	public override string HeadingRemoveUser => "ãƒ¦ãƒ¼ã‚¶ãƒ¼ã‚’å‰Šé™¤ã—ã¾ã™ã‹ï¼Ÿ";

	/// <summary>
	/// Key: "Heading.Report"
	/// heading for abuse report dialog
	/// English String: "Report"
	/// </summary>
	public override string HeadingReport => "å ±å‘Šã™ã‚‹";

	/// <summary>
	/// Key: "Label.AddFriends"
	/// English String: "Add Friends"
	/// </summary>
	public override string LabelAddFriends => "å‹é”ã‚’è¿½åŠ ã™ã‚‹";

	/// <summary>
	/// Key: "Label.BuyButton"
	/// English String: "Buy"
	/// </summary>
	public override string LabelBuyButton => "è²·ã†";

	/// <summary>
	/// Key: "Label.ChangeChatGroupName"
	/// English String: "Change your chat group name"
	/// </summary>
	public override string LabelChangeChatGroupName => "ãƒãƒ£ãƒƒãƒˆã‚°ãƒ«ãƒ¼ãƒ—åã‚’å¤‰æ›´ã™ã‚‹";

	/// <summary>
	/// Key: "Label.ChatDetails"
	/// English String: "Chat Details"
	/// </summary>
	public override string LabelChatDetails => "ãƒãƒ£ãƒƒãƒˆè©³ç´°";

	/// <summary>
	/// Key: "Label.ChatGroupName"
	/// English String: "Chat Group Name"
	/// </summary>
	public override string LabelChatGroupName => "ãƒãƒ£ãƒƒãƒˆã‚°ãƒ«ãƒ¼ãƒ—å";

	/// <summary>
	/// Key: "Label.Close"
	/// English String: "Close"
	/// </summary>
	public override string LabelClose => "é–‰ã˜ã‚‹";

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
	public override string LabelConversationNotificationsOn => "ã‚ªãƒ³";

	/// <summary>
	/// Key: "Label.Details.PlayTogether"
	/// English String: "PlayTogether"
	/// </summary>
	public override string LabelDetailsPlayTogether => "ä¸€ç·’ã«ãƒ—ãƒ¬ã‚¤";

	/// <summary>
	/// Key: "Label.FindGame"
	/// English String: "Find Game"
	/// </summary>
	public override string LabelFindGame => "ã‚²ãƒ¼ãƒ ã‚’æŽ¢ã™";

	/// <summary>
	/// Key: "Label.GameNotAvailableButton"
	/// English String: "Not Available"
	/// </summary>
	public override string LabelGameNotAvailableButton => "åˆ©ç”¨ã§ãã¾ã›ã‚“";

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
	public override string LabelInGame => "ã‚²ãƒ¼ãƒ å†…";

	/// <summary>
	/// Key: "Label.InputPlaceHolder.SearchForFriends"
	/// English String: "Search for friends"
	/// </summary>
	public override string LabelInputPlaceHolderSearchForFriends => "å‹é”ã‚’æ¤œç´¢";

	/// <summary>
	/// Key: "Label.InputPlaceHolder.SendMessage"
	/// English String: "Send a message"
	/// </summary>
	public override string LabelInputPlaceHolderSendMessage => "ãƒ¡ãƒƒã‚»ãƒ¼ã‚¸ã‚’é€ä¿¡";

	/// <summary>
	/// Key: "Label.InStudio"
	/// English String: "In Studio"
	/// </summary>
	public override string LabelInStudio => "Studioå†…";

	/// <summary>
	/// Key: "Label.JoinButton"
	/// English String: "Join"
	/// </summary>
	public override string LabelJoinButton => "å‚åŠ ";

	/// <summary>
	/// Key: "Label.JoinGame"
	/// English String: "Join Game"
	/// </summary>
	public override string LabelJoinGame => "ã‚²ãƒ¼ãƒ ã«å‚åŠ ";

	/// <summary>
	/// Key: "Label.JoinParty"
	/// English String: "Join Party"
	/// </summary>
	public override string LabelJoinParty => "ãƒ‘ãƒ¼ãƒ†ã‚£ã«å‚åŠ ";

	/// <summary>
	/// Key: "Label.LeaveChatGroup"
	/// English String: "Leave Chat Group"
	/// </summary>
	public override string LabelLeaveChatGroup => "ãƒãƒ£ãƒƒãƒˆã‚°ãƒ«ãƒ¼ãƒ—ã‚’çµ‚äº†";

	/// <summary>
	/// Key: "Label.LeaveParty"
	/// English String: "Leave Party"
	/// </summary>
	public override string LabelLeaveParty => "ãƒ‘ãƒ¼ãƒ†ã‚£ã‚’çµ‚äº†";

	/// <summary>
	/// Key: "Label.Member"
	/// English String: "Member"
	/// </summary>
	public override string LabelMember => "ãƒ¡ãƒ³ãƒãƒ¼";

	/// <summary>
	/// Key: "Label.Members"
	/// English String: "Members"
	/// </summary>
	public override string LabelMembers => "ãƒ¡ãƒ³ãƒãƒ¼";

	/// <summary>
	/// Key: "Label.Mute15Minutes"
	/// mute conversation for 15 mins
	/// English String: "For 15 minutes"
	/// </summary>
	public override string LabelMute15Minutes => "15åˆ†é–“";

	/// <summary>
	/// Key: "Label.Mute1Hour"
	/// Mute conversation for 1 hour
	/// English String: "For an hour"
	/// </summary>
	public override string LabelMute1Hour => "1æ™‚é–“";

	/// <summary>
	/// Key: "Label.Mute24Hours"
	/// Mute conversation for a day
	/// English String: "For a day"
	/// </summary>
	public override string LabelMute24Hours => "1æ—¥";

	/// <summary>
	/// Key: "Label.Mute8Hours"
	/// Mute conversation for 8 hours
	/// English String: "For 8 hours"
	/// </summary>
	public override string LabelMute8Hours => "8æ™‚é–“";

	/// <summary>
	/// Key: "Label.MuteConversationNotificationsForGroup"
	/// English String: "Mute notifications for this chat group"
	/// </summary>
	public override string LabelMuteConversationNotificationsForGroup => "ã“ã®ãƒãƒ£ãƒƒãƒˆã‚°ãƒ«ãƒ¼ãƒ—ã®é€šçŸ¥ã‚’ã‚ªãƒ•ã«ã™ã‚‹";

	/// <summary>
	/// Key: "Label.MuteConversationNotificationsForOneToOne"
	/// English String: "Mute notifications for this conversation"
	/// </summary>
	public override string LabelMuteConversationNotificationsForOneToOne => "ã“ã®ä¼šè©±ã®é€šçŸ¥ã‚’ã‚ªãƒ•ã«ã™ã‚‹";

	/// <summary>
	/// Key: "Label.MuteInfinite"
	/// Mute conversation until user turns back
	/// English String: "Until I turn them back on"
	/// </summary>
	public override string LabelMuteInfinite => "ã‚ªãƒ³ã«æˆ»ã™ã¾ã§";

	/// <summary>
	/// Key: "Label.NameYourChangeGroup"
	/// English String: "Name your change group"
	/// </summary>
	public override string LabelNameYourChangeGroup => "å¤‰æ›´ã‚°ãƒ«ãƒ¼ãƒ—ã«åå‰ã‚’ä»˜ã‘ã‚‹";

	/// <summary>
	/// Key: "Label.NameYourChatGroup"
	/// English String: "Name your chat group"
	/// </summary>
	public override string LabelNameYourChatGroup => "ãƒãƒ£ãƒƒãƒˆã‚°ãƒ«ãƒ¼ãƒ—ã«åå‰ã‚’ä»˜ã‘ã‚‹";

	/// <summary>
	/// Key: "Label.NotImplementedMessageType"
	/// This message is displayed in chat when user receives message type that can't be rendered by current app version and update is not available, yet (e.g. latest version was rolled back, or in deprecated Android native chat)
	/// English String: "This message could not be displayed."
	/// </summary>
	public override string LabelNotImplementedMessageType => "ãƒ¡ãƒƒã‚»ãƒ¼ã‚¸ã‚’è¡¨ç¤ºã§ãã¾ã›ã‚“ã§ã—ãŸã€‚";

	/// <summary>
	/// Key: "Label.NotInCall"
	/// English String: "Not in call"
	/// </summary>
	public override string LabelNotInCall => "é€šè©±ä¸­ã§ã¯ã‚ã‚Šã¾ã›ã‚“";

	/// <summary>
	/// Key: "Label.Offline"
	/// English String: "Offline"
	/// </summary>
	public override string LabelOffline => "ã‚ªãƒ•ãƒ©ã‚¤ãƒ³";

	/// <summary>
	/// Key: "Label.Online"
	/// English String: "Online"
	/// </summary>
	public override string LabelOnline => "ã‚ªãƒ³ãƒ©ã‚¤ãƒ³";

	/// <summary>
	/// Key: "Label.PinGameTooltip"
	/// English String: "Pin Game"
	/// </summary>
	public override string LabelPinGameTooltip => "ã‚²ãƒ¼ãƒ ã«ãƒ”ãƒ³ã‚’ä»˜ã‘ã‚‹";

	/// <summary>
	/// Key: "Label.PinnedGame"
	/// This is a title of card, means this game card is pinned game
	/// English String: "Pinned Game"
	/// </summary>
	public override string LabelPinnedGame => "ãƒ”ãƒ³ã‚’ä»˜ã‘ãŸã‚²ãƒ¼ãƒ ";

	/// <summary>
	/// Key: "Label.PlayButton"
	/// English String: "Play"
	/// </summary>
	public override string LabelPlayButton => "ãƒ—ãƒ¬ã‚¤";

	/// <summary>
	/// Key: "Label.PlayGames"
	/// English String: "Play Games"
	/// </summary>
	public override string LabelPlayGames => "ã‚²ãƒ¼ãƒ ã‚’ãƒ—ãƒ¬ã‚¤";

	/// <summary>
	/// Key: "Label.PlayTogether"
	/// English String: "Play Together"
	/// </summary>
	public override string LabelPlayTogether => "ä¸€ç·’ã«ãƒ—ãƒ¬ã‚¤ã™ã‚‹";

	/// <summary>
	/// Key: "Label.RecommendedGames"
	/// English String: "Recommended"
	/// </summary>
	public override string LabelRecommendedGames => "ãŠã™ã™ã‚";

	/// <summary>
	/// Key: "Label.SeeLess"
	/// English String: "See Less"
	/// </summary>
	public override string LabelSeeLess => "è¦‹ã‚‹æ•°ã‚’æ¸›ã‚‰ã™";

	/// <summary>
	/// Key: "Label.SeeMore"
	/// English String: "See More"
	/// </summary>
	public override string LabelSeeMore => "ã‚‚ã£ã¨è¦‹ã‚‹";

	/// <summary>
	/// Key: "Label.ShowLessGames"
	/// English String: "Show Less"
	/// </summary>
	public override string LabelShowLessGames => "è¡¨ç¤ºã‚’æ¸›ã‚‰ã™";

	/// <summary>
	/// Key: "Label.SpanTitle.CreateGroupNeeds2More"
	/// English String: "Add at least 2 people to create chat group"
	/// </summary>
	public override string LabelSpanTitleCreateGroupNeeds2More => "ãƒãƒ£ãƒƒãƒˆã‚°ãƒ«ãƒ¼ãƒ—ã‚’ä½œæˆã™ã‚‹ã«ã¯ã€2äººä»¥ä¸Šè¿½åŠ ã—ã¦ãã ã•ã„";

	/// <summary>
	/// Key: "Label.SpanTitle.Loading"
	/// English String: "loading ..."
	/// </summary>
	public override string LabelSpanTitleLoading => "èª­ã¿è¾¼ã¿ä¸­ ...";

	/// <summary>
	/// Key: "Label.TimestampOffUntilTomorrow"
	/// English String: "Off until tomorrow"
	/// </summary>
	public override string LabelTimestampOffUntilTomorrow => "æ˜Žæ—¥ã¾ã§ã‚ªãƒ•";

	/// <summary>
	/// Key: "Label.TimestampOffUntilTurnedBackOn"
	/// English String: "Off until turned back on\""
	/// </summary>
	public override string LabelTimestampOffUntilTurnedBackOn => "ã‚ªãƒ³ã«æˆ»ã™ã¾ã§ã‚ªãƒ•";

	/// <summary>
	/// Key: "Label.TurnOnConversationNotificationsPrompt"
	/// English String: "Do you want to turn on notifications?"
	/// </summary>
	public override string LabelTurnOnConversationNotificationsPrompt => "é€šçŸ¥ã‚’ã‚ªãƒ³ã«ã—ã¾ã™ã‹ï¼Ÿ";

	/// <summary>
	/// Key: "Label.UnpinGameTooltip"
	/// English String: "Unpin Game"
	/// </summary>
	public override string LabelUnpinGameTooltip => "ã‚²ãƒ¼ãƒ ã®ãƒ”ãƒ³ã‚’å¤–ã™";

	/// <summary>
	/// Key: "Label.ViewDetailsButton"
	/// English String: "View Details"
	/// </summary>
	public override string LabelViewDetailsButton => "è©³ç´°ã‚’è¡¨ç¤º";

	/// <summary>
	/// Key: "Label.ViewProfile"
	/// English String: "View Profile"
	/// </summary>
	public override string LabelViewProfile => "ãƒ—ãƒ­ãƒ•ã‚£ãƒ¼ãƒ«ã‚’è¦‹ã‚‹";

	/// <summary>
	/// Key: "Label.VoiceSetting"
	/// Voice chat setting label
	/// English String: "Voice Settings"
	/// </summary>
	public override string LabelVoiceSetting => "ãƒœã‚¤ã‚¹è¨­å®š";

	/// <summary>
	/// Key: "Label.Yesterday"
	/// time stamp for chat message received yesterday
	/// English String: "Yesterday"
	/// </summary>
	public override string LabelYesterday => "æ˜¨æ—¥";

	/// <summary>
	/// Key: "Message.ConversationTitleModerated"
	/// Chat group name was moderated.
	/// English String: "Chat group name was moderated."
	/// </summary>
	public override string MessageConversationTitleModerated => "ãƒãƒ£ãƒƒãƒˆã‚°ãƒ«ãƒ¼ãƒ—åãŒè¦åˆ¶å¯¾è±¡ã§ã™ã€‚";

	/// <summary>
	/// Key: "Message.Default"
	/// English String: "Not everyone in this chat can see your message."
	/// </summary>
	public override string MessageDefault => "ã“ã®ãƒãƒ£ãƒƒãƒˆã§ã¯ã€å…¨å“¡ãŒã‚ãªãŸã®ãƒ¡ãƒƒã‚»ãƒ¼ã‚¸ã‚’è¦‹ã‚Œã‚‹ã‚ã‘ã§ã¯ã‚ã‚Šã¾ã›ã‚“ã€‚";

	/// <summary>
	/// Key: "Message.DefaultErrorMsg"
	/// English String: "An error occurred"
	/// </summary>
	public override string MessageDefaultErrorMsg => "ã‚¨ãƒ©ãƒ¼ãŒç™ºç”Ÿ";

	/// <summary>
	/// Key: "Message.Error"
	/// English String: "Error"
	/// </summary>
	public override string MessageError => "ã‚¨ãƒ©ãƒ¼";

	/// <summary>
	/// Key: "Message.JoinPartyText"
	/// English String: "The party leader is finding a game to play."
	/// </summary>
	public override string MessageJoinPartyText => "ãƒ‘ãƒ¼ãƒ†ã‚£ãƒªãƒ¼ãƒ€ãƒ¼ãŒãƒ—ãƒ¬ã‚¤ã™ã‚‹ã‚²ãƒ¼ãƒ ã‚’æŽ¢ã—ã¦ã„ã¾ã™ã€‚";

	/// <summary>
	/// Key: "Message.MakeFriendsToChatNPlay"
	/// English String: "Make friends to start chatting and partying!"
	/// </summary>
	public override string MessageMakeFriendsToChatNPlay => "å‹é”ã‚’ä½œã£ã¦ãƒãƒ£ãƒƒãƒˆã‚„ãƒ‘ãƒ¼ãƒ†ã‚£ã‚’å§‹ã‚ã‚ˆã†ï¼";

	/// <summary>
	/// Key: "Message.MessageContentModerated"
	/// English String: "Your message was moderated and not sent."
	/// </summary>
	public override string MessageMessageContentModerated => "ãƒ¡ãƒƒã‚»ãƒ¼ã‚¸ã¯ã€è¦åˆ¶ã«ã‚ˆã‚Šé€ä¿¡ã•ã‚Œã¾ã›ã‚“ã§ã—ãŸã€‚";

	/// <summary>
	/// Key: "Message.MessageFilterForReceivers"
	/// English String: "Not everyone in this chat can see your message."
	/// </summary>
	public override string MessageMessageFilterForReceivers => "ã“ã®ãƒãƒ£ãƒƒãƒˆã§ã¯ã€å…¨å“¡ãŒã‚ãªãŸã®ãƒ¡ãƒƒã‚»ãƒ¼ã‚¸ã‚’è¦‹ã‚Œã‚‹ã‚ã‘ã§ã¯ã‚ã‚Šã¾ã›ã‚“ã€‚";

	/// <summary>
	/// Key: "Message.NoConnectionMsg"
	/// English String: "Connecting..."
	/// </summary>
	public override string MessageNoConnectionMsg => "æŽ¥ç¶šä¸­...";

	/// <summary>
	/// Key: "Message.PartyInviteMsg"
	/// English String: "PARTY INVITE!"
	/// </summary>
	public override string MessagePartyInviteMsg => "ãƒ‘ãƒ¼ãƒ†ã‚£ã¸ã®æ‹›å¾…ï¼";

	/// <summary>
	/// Key: "Message.PlayGameUpdate"
	/// English String: " is playing the pinned game: "
	/// </summary>
	public override string MessagePlayGameUpdate => " ã•ã‚“ã¯ã€ãƒ”ãƒ³ã‚’ä»˜ã‘ãŸä»¥ä¸‹ã®ã‚²ãƒ¼ãƒ ã‚’ãƒ—ãƒ¬ã‚¤ä¸­: ";

	/// <summary>
	/// Key: "Message.TextTooLong"
	/// English String: "Your message was too long and not sent."
	/// </summary>
	public override string MessageTextTooLong => "ãƒ¡ãƒƒã‚»ãƒ¼ã‚¸ãŒé•·ã™ãŽã‚‹ãŸã‚ã€é€ä¿¡ã•ã‚Œã¾ã›ã‚“ã§ã—ãŸã€‚";

	/// <summary>
	/// Key: "Message.UnknownMessageType"
	/// This serves as the fallback string for when an message type is received that the web chat does not know how to render.
	/// English String: "A message cannot be displayed"
	/// </summary>
	public override string MessageUnknownMessageType => "ãƒ¡ãƒƒã‚»ãƒ¼ã‚¸ã‚’è¡¨ç¤ºã§ãã¾ã›ã‚“";

	/// <summary>
	/// Key: "PlayButton"
	/// English String: "Play"
	/// </summary>
	public override string PlayButton => "ãƒ—ãƒ¬ã‚¤";

	/// <summary>
	/// Key: "Response.PartyInvite"
	/// notification message
	/// English String: "You received a party Invite."
	/// </summary>
	public override string ResponsePartyInvite => "ãƒ‘ãƒ¼ãƒ†ã‚£ã¸ã®æ‹›å¾…ãŒå±Šãã¾ã—ãŸã€‚";

	public ChatResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAdd()
	{
		return "è¿½åŠ ";
	}

	protected override string _GetTemplateForActionBuyAccess()
	{
		return "ã‚¢ã‚¯ã‚»ã‚¹ã‚’è²·ã†";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "ã‚­ãƒ£ãƒ³ã‚»ãƒ«";
	}

	protected override string _GetTemplateForActionCreate()
	{
		return "ä½œæˆ";
	}

	protected override string _GetTemplateForActionJoin()
	{
		return "å‚åŠ ";
	}

	protected override string _GetTemplateForActionJoinVoice()
	{
		return "å‚åŠ ";
	}

	protected override string _GetTemplateForActionLeave()
	{
		return "ã‚„ã‚ã‚‹";
	}

	protected override string _GetTemplateForActionMute()
	{
		return "æ¶ˆéŸ³";
	}

	protected override string _GetTemplateForActionMuteMic()
	{
		return "ãƒžã‚¤ã‚¯ã‚’ãƒŸãƒ¥ãƒ¼ãƒˆ";
	}

	protected override string _GetTemplateForActionRemove()
	{
		return "å‰Šé™¤";
	}

	protected override string _GetTemplateForActionReport()
	{
		return "å ±å‘Šã™ã‚‹";
	}

	protected override string _GetTemplateForActionSave()
	{
		return "ä¿å­˜";
	}

	protected override string _GetTemplateForActionSend()
	{
		return "é€ä¿¡";
	}

	protected override string _GetTemplateForActionSet()
	{
		return "è¨­å®š";
	}

	protected override string _GetTemplateForActionStartParty()
	{
		return "ãƒ‘ãƒ¼ãƒ†ã‚£ã‚’çµæˆã™ã‚‹";
	}

	protected override string _GetTemplateForActionStay()
	{
		return "ãã®ã¾ã¾";
	}

	protected override string _GetTemplateForActionTurnOn()
	{
		return "ã‚ªãƒ³ã«ã™ã‚‹";
	}

	protected override string _GetTemplateForActionUnmute()
	{
		return "ãƒŸãƒ¥ãƒ¼ãƒˆè§£é™¤";
	}

	protected override string _GetTemplateForActionUnmuteMic()
	{
		return "ãƒžã‚¤ã‚¯ã‚’ãƒŸãƒ¥ãƒ¼ãƒˆè§£é™¤";
	}

	protected override string _GetTemplateForDescriptionJoinInVoiceChat()
	{
		return "é€šè©±ã«å‚åŠ ã™ã‚‹ã«ã¯å‚åŠ ã‚’ã‚¯ãƒªãƒƒã‚¯";
	}

	protected override string _GetTemplateForDescriptionUserInVoice()
	{
		return "ãƒœã‚¤ã‚¹ãƒãƒ£ãƒƒãƒˆä¸­ã§ã™";
	}

	protected override string _GetTemplateForDescriptionVoiceNotConnect()
	{
		return "ãƒœã‚¤ã‚¹ãƒãƒ£ãƒƒãƒˆã«æŽ¥ç¶šã§ãã¾ã›ã‚“ã§ã—ãŸ";
	}

	protected override string _GetTemplateForHeadingBuyItem()
	{
		return "ã‚¢ã‚¤ãƒ†ãƒ ã‚’è²·ã†";
	}

	protected override string _GetTemplateForHeadingChat()
	{
		return "ãƒãƒ£ãƒƒãƒˆ";
	}

	protected override string _GetTemplateForHeadingChatAndParty()
	{
		return "ãƒãƒ£ãƒƒãƒˆã¨ãƒ‘ãƒ¼ãƒ†ã‚£";
	}

	protected override string _GetTemplateForHeadingConfirmLeaving()
	{
		return "ã“ã®ãƒãƒ£ãƒƒãƒˆã‚°ãƒ«ãƒ¼ãƒ—ã‚’çµ‚äº†ã—ã¦ã‚ˆã‚ã—ã„ã§ã™ã‹ï¼Ÿ";
	}

	protected override string _GetTemplateForHeadingContinueToReport()
	{
		return "å ±å‘Šã—ã¾ã™ã‹ï¼Ÿ";
	}

	protected override string _GetTemplateForHeadingCreateParty()
	{
		return "ãƒ‘ãƒ¼ãƒ†ã‚£ã‚’ä½œæˆ";
	}

	protected override string _GetTemplateForHeadingLeaveChatGroup()
	{
		return "ãƒãƒ£ãƒƒãƒˆã‚°ãƒ«ãƒ¼ãƒ—ã‚’çµ‚äº†";
	}

	protected override string _GetTemplateForHeadingLeaveChatGroupQ()
	{
		return "ãƒãƒ£ãƒƒãƒˆã‚°ãƒ«ãƒ¼ãƒ—ã‚’çµ‚äº†ã—ã¾ã™ã‹ï¼Ÿ";
	}

	protected override string _GetTemplateForHeadingNewChatGroup()
	{
		return "æ–°è¦ãƒãƒ£ãƒƒãƒˆã‚°ãƒ«ãƒ¼ãƒ—";
	}

	protected override string _GetTemplateForHeadingRemoveUser()
	{
		return "ãƒ¦ãƒ¼ã‚¶ãƒ¼ã‚’å‰Šé™¤ã—ã¾ã™ã‹ï¼Ÿ";
	}

	protected override string _GetTemplateForHeadingReport()
	{
		return "å ±å‘Šã™ã‚‹";
	}

	protected override string _GetTemplateForLabelAddFriends()
	{
		return "å‹é”ã‚’è¿½åŠ ã™ã‚‹";
	}

	/// <summary>
	/// Key: "Label.BuyAccessToGameForModal"
	/// English String: "Would you like to buy access to the Place: {placeName} from {creatorName} for {robux}?"
	/// </summary>
	public override string LabelBuyAccessToGameForModal(string placeName, string creatorName, string robux)
	{
		return $"{creatorName} ã•ã‚“ãŒä½œã£ãŸãƒ—ãƒ¬ãƒ¼ã‚¹ã€ {placeName} ã¸ã®ã‚¢ã‚¯ã‚»ã‚¹ã‚’ {robux} ã§è²·ã„ã¾ã™ã‹ï¼Ÿ";
	}

	protected override string _GetTemplateForLabelBuyAccessToGameForModal()
	{
		return "{creatorName} ã•ã‚“ãŒä½œã£ãŸãƒ—ãƒ¬ãƒ¼ã‚¹ã€ {placeName} ã¸ã®ã‚¢ã‚¯ã‚»ã‚¹ã‚’ {robux} ã§è²·ã„ã¾ã™ã‹ï¼Ÿ";
	}

	protected override string _GetTemplateForLabelBuyButton()
	{
		return "è²·ã†";
	}

	protected override string _GetTemplateForLabelChangeChatGroupName()
	{
		return "ãƒãƒ£ãƒƒãƒˆã‚°ãƒ«ãƒ¼ãƒ—åã‚’å¤‰æ›´ã™ã‚‹";
	}

	protected override string _GetTemplateForLabelChatDetails()
	{
		return "ãƒãƒ£ãƒƒãƒˆè©³ç´°";
	}

	protected override string _GetTemplateForLabelChatGroupName()
	{
		return "ãƒãƒ£ãƒƒãƒˆã‚°ãƒ«ãƒ¼ãƒ—å";
	}

	protected override string _GetTemplateForLabelClose()
	{
		return "é–‰ã˜ã‚‹";
	}

	protected override string _GetTemplateForLabelConversationNotifications()
	{
		return "é€šçŸ¥";
	}

	protected override string _GetTemplateForLabelConversationNotificationsOn()
	{
		return "ã‚ªãƒ³";
	}

	protected override string _GetTemplateForLabelDetailsPlayTogether()
	{
		return "ä¸€ç·’ã«ãƒ—ãƒ¬ã‚¤";
	}

	protected override string _GetTemplateForLabelFindGame()
	{
		return "ã‚²ãƒ¼ãƒ ã‚’æŽ¢ã™";
	}

	protected override string _GetTemplateForLabelGameNotAvailableButton()
	{
		return "åˆ©ç”¨ã§ãã¾ã›ã‚“";
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
		return "ã‚²ãƒ¼ãƒ å†…";
	}

	protected override string _GetTemplateForLabelInputPlaceHolderSearchForFriends()
	{
		return "å‹é”ã‚’æ¤œç´¢";
	}

	protected override string _GetTemplateForLabelInputPlaceHolderSendMessage()
	{
		return "ãƒ¡ãƒƒã‚»ãƒ¼ã‚¸ã‚’é€ä¿¡";
	}

	protected override string _GetTemplateForLabelInStudio()
	{
		return "Studioå†…";
	}

	protected override string _GetTemplateForLabelJoinButton()
	{
		return "å‚åŠ ";
	}

	protected override string _GetTemplateForLabelJoinGame()
	{
		return "ã‚²ãƒ¼ãƒ ã«å‚åŠ ";
	}

	protected override string _GetTemplateForLabelJoinParty()
	{
		return "ãƒ‘ãƒ¼ãƒ†ã‚£ã«å‚åŠ ";
	}

	protected override string _GetTemplateForLabelLeaveChatGroup()
	{
		return "ãƒãƒ£ãƒƒãƒˆã‚°ãƒ«ãƒ¼ãƒ—ã‚’çµ‚äº†";
	}

	protected override string _GetTemplateForLabelLeaveParty()
	{
		return "ãƒ‘ãƒ¼ãƒ†ã‚£ã‚’çµ‚äº†";
	}

	protected override string _GetTemplateForLabelMember()
	{
		return "ãƒ¡ãƒ³ãƒãƒ¼";
	}

	/// <summary>
	/// Key: "Label.MemberJoinText"
	/// English String: "{userName} joined the party"
	/// </summary>
	public override string LabelMemberJoinText(string userName)
	{
		return $"{userName} ã•ã‚“ãŒãƒ‘ãƒ¼ãƒ†ã‚£ã«å‚åŠ ã—ã¾ã—ãŸ";
	}

	protected override string _GetTemplateForLabelMemberJoinText()
	{
		return "{userName} ã•ã‚“ãŒãƒ‘ãƒ¼ãƒ†ã‚£ã«å‚åŠ ã—ã¾ã—ãŸ";
	}

	protected override string _GetTemplateForLabelMembers()
	{
		return "ãƒ¡ãƒ³ãƒãƒ¼";
	}

	protected override string _GetTemplateForLabelMute15Minutes()
	{
		return "15åˆ†é–“";
	}

	protected override string _GetTemplateForLabelMute1Hour()
	{
		return "1æ™‚é–“";
	}

	protected override string _GetTemplateForLabelMute24Hours()
	{
		return "1æ—¥";
	}

	protected override string _GetTemplateForLabelMute8Hours()
	{
		return "8æ™‚é–“";
	}

	protected override string _GetTemplateForLabelMuteConversationNotificationsForGroup()
	{
		return "ã“ã®ãƒãƒ£ãƒƒãƒˆã‚°ãƒ«ãƒ¼ãƒ—ã®é€šçŸ¥ã‚’ã‚ªãƒ•ã«ã™ã‚‹";
	}

	protected override string _GetTemplateForLabelMuteConversationNotificationsForOneToOne()
	{
		return "ã“ã®ä¼šè©±ã®é€šçŸ¥ã‚’ã‚ªãƒ•ã«ã™ã‚‹";
	}

	protected override string _GetTemplateForLabelMuteInfinite()
	{
		return "ã‚ªãƒ³ã«æˆ»ã™ã¾ã§";
	}

	protected override string _GetTemplateForLabelNameYourChangeGroup()
	{
		return "å¤‰æ›´ã‚°ãƒ«ãƒ¼ãƒ—ã«åå‰ã‚’ä»˜ã‘ã‚‹";
	}

	protected override string _GetTemplateForLabelNameYourChatGroup()
	{
		return "ãƒãƒ£ãƒƒãƒˆã‚°ãƒ«ãƒ¼ãƒ—ã«åå‰ã‚’ä»˜ã‘ã‚‹";
	}

	protected override string _GetTemplateForLabelNotImplementedMessageType()
	{
		return "ãƒ¡ãƒƒã‚»ãƒ¼ã‚¸ã‚’è¡¨ç¤ºã§ãã¾ã›ã‚“ã§ã—ãŸã€‚";
	}

	protected override string _GetTemplateForLabelNotInCall()
	{
		return "é€šè©±ä¸­ã§ã¯ã‚ã‚Šã¾ã›ã‚“";
	}

	protected override string _GetTemplateForLabelOffline()
	{
		return "ã‚ªãƒ•ãƒ©ã‚¤ãƒ³";
	}

	protected override string _GetTemplateForLabelOnline()
	{
		return "ã‚ªãƒ³ãƒ©ã‚¤ãƒ³";
	}

	/// <summary>
	/// Key: "Label.PartyLeaderTooltip"
	/// English String: "{userName} is the party leader"
	/// </summary>
	public override string LabelPartyLeaderTooltip(string userName)
	{
		return $"{userName} ã•ã‚“ãŒãƒ‘ãƒ¼ãƒ†ã‚£ãƒªãƒ¼ãƒ€ãƒ¼ã§ã™";
	}

	protected override string _GetTemplateForLabelPartyLeaderTooltip()
	{
		return "{userName} ã•ã‚“ãŒãƒ‘ãƒ¼ãƒ†ã‚£ãƒªãƒ¼ãƒ€ãƒ¼ã§ã™";
	}

	/// <summary>
	/// Key: "Label.PartyMemberTooltip"
	/// English String: "{userName} is in the party"
	/// </summary>
	public override string LabelPartyMemberTooltip(string userName)
	{
		return $"{userName} ã•ã‚“ã¯ãƒ‘ãƒ¼ãƒ†ã‚£ã«å‚åŠ ã—ã¦ã„ã¾ã™";
	}

	protected override string _GetTemplateForLabelPartyMemberTooltip()
	{
		return "{userName} ã•ã‚“ã¯ãƒ‘ãƒ¼ãƒ†ã‚£ã«å‚åŠ ã—ã¦ã„ã¾ã™";
	}

	/// <summary>
	/// Key: "Label.PartyName"
	/// English String: "Party : {title}"
	/// </summary>
	public override string LabelPartyName(string title)
	{
		return $"ãƒ‘ãƒ¼ãƒ†ã‚£: {title}";
	}

	protected override string _GetTemplateForLabelPartyName()
	{
		return "ãƒ‘ãƒ¼ãƒ†ã‚£: {title}";
	}

	/// <summary>
	/// Key: "Label.PendingMemberTooltip"
	/// English String: "{userName} is not in the party"
	/// </summary>
	public override string LabelPendingMemberTooltip(string userName)
	{
		return $"{userName} ã•ã‚“ã¯ãƒ‘ãƒ¼ãƒ†ã‚£ã«å‚åŠ ã—ã¦ã„ã¾ã›ã‚“";
	}

	protected override string _GetTemplateForLabelPendingMemberTooltip()
	{
		return "{userName} ã•ã‚“ã¯ãƒ‘ãƒ¼ãƒ†ã‚£ã«å‚åŠ ã—ã¦ã„ã¾ã›ã‚“";
	}

	protected override string _GetTemplateForLabelPinGameTooltip()
	{
		return "ã‚²ãƒ¼ãƒ ã«ãƒ”ãƒ³ã‚’ä»˜ã‘ã‚‹";
	}

	protected override string _GetTemplateForLabelPinnedGame()
	{
		return "ãƒ”ãƒ³ã‚’ä»˜ã‘ãŸã‚²ãƒ¼ãƒ ";
	}

	protected override string _GetTemplateForLabelPlayButton()
	{
		return "ãƒ—ãƒ¬ã‚¤";
	}

	protected override string _GetTemplateForLabelPlayGames()
	{
		return "ã‚²ãƒ¼ãƒ ã‚’ãƒ—ãƒ¬ã‚¤";
	}

	/// <summary>
	/// Key: "Label.PlayingGame"
	/// English String: "Playing {game}"
	/// </summary>
	public override string LabelPlayingGame(string game)
	{
		return $"{game}ã‚’ãƒ—ãƒ¬ã‚¤ä¸­";
	}

	protected override string _GetTemplateForLabelPlayingGame()
	{
		return "{game}ã‚’ãƒ—ãƒ¬ã‚¤ä¸­";
	}

	protected override string _GetTemplateForLabelPlayTogether()
	{
		return "ä¸€ç·’ã«ãƒ—ãƒ¬ã‚¤ã™ã‚‹";
	}

	protected override string _GetTemplateForLabelRecommendedGames()
	{
		return "ãŠã™ã™ã‚";
	}

	protected override string _GetTemplateForLabelSeeLess()
	{
		return "è¦‹ã‚‹æ•°ã‚’æ¸›ã‚‰ã™";
	}

	protected override string _GetTemplateForLabelSeeMore()
	{
		return "ã‚‚ã£ã¨è¦‹ã‚‹";
	}

	protected override string _GetTemplateForLabelShowLessGames()
	{
		return "è¡¨ç¤ºã‚’æ¸›ã‚‰ã™";
	}

	/// <summary>
	/// Key: "Label.ShowMoreGames"
	/// English String: "Show More (+{count})"
	/// </summary>
	public override string LabelShowMoreGames(string count)
	{
		return $"ã•ã‚‰ã«è¡¨ç¤ºï¼ˆ+{count}ï¼‰";
	}

	protected override string _GetTemplateForLabelShowMoreGames()
	{
		return "ã•ã‚‰ã«è¡¨ç¤ºï¼ˆ+{count}ï¼‰";
	}

	protected override string _GetTemplateForLabelSpanTitleCreateGroupNeeds2More()
	{
		return "ãƒãƒ£ãƒƒãƒˆã‚°ãƒ«ãƒ¼ãƒ—ã‚’ä½œæˆã™ã‚‹ã«ã¯ã€2äººä»¥ä¸Šè¿½åŠ ã—ã¦ãã ã•ã„";
	}

	protected override string _GetTemplateForLabelSpanTitleLoading()
	{
		return "èª­ã¿è¾¼ã¿ä¸­ ...";
	}

	/// <summary>
	/// Key: "Label.TimestampOffUntilCertainTime"
	/// English String: "Off until {timestamp}"
	/// </summary>
	public override string LabelTimestampOffUntilCertainTime(string timestamp)
	{
		return $"{timestamp}ã¾ã§ã‚ªãƒ•";
	}

	protected override string _GetTemplateForLabelTimestampOffUntilCertainTime()
	{
		return "{timestamp}ã¾ã§ã‚ªãƒ•";
	}

	protected override string _GetTemplateForLabelTimestampOffUntilTomorrow()
	{
		return "æ˜Žæ—¥ã¾ã§ã‚ªãƒ•";
	}

	protected override string _GetTemplateForLabelTimestampOffUntilTurnedBackOn()
	{
		return "ã‚ªãƒ³ã«æˆ»ã™ã¾ã§ã‚ªãƒ•";
	}

	protected override string _GetTemplateForLabelTurnOnConversationNotificationsPrompt()
	{
		return "é€šçŸ¥ã‚’ã‚ªãƒ³ã«ã—ã¾ã™ã‹ï¼Ÿ";
	}

	protected override string _GetTemplateForLabelUnpinGameTooltip()
	{
		return "ã‚²ãƒ¼ãƒ ã®ãƒ”ãƒ³ã‚’å¤–ã™";
	}

	protected override string _GetTemplateForLabelViewDetailsButton()
	{
		return "è©³ç´°ã‚’è¡¨ç¤º";
	}

	protected override string _GetTemplateForLabelViewProfile()
	{
		return "ãƒ—ãƒ­ãƒ•ã‚£ãƒ¼ãƒ«ã‚’è¦‹ã‚‹";
	}

	protected override string _GetTemplateForLabelVoiceSetting()
	{
		return "ãƒœã‚¤ã‚¹è¨­å®š";
	}

	protected override string _GetTemplateForLabelYesterday()
	{
		return "æ˜¨æ—¥";
	}

	/// <summary>
	/// Key: "Message.ChatPrivacySetting"
	/// English String: "To chat with friends, turn on chat in your {frontLink}Privacy Settings{endLink}"
	/// </summary>
	public override string MessageChatPrivacySetting(string frontLink, string endLink)
	{
		return $"å‹é”ã¨ãƒãƒ£ãƒƒãƒˆã™ã‚‹ã«ã¯ã€ã€Œ{frontLink}ãƒ—ãƒ©ã‚¤ãƒã‚·ãƒ¼è¨­å®š{endLink}ã€ã§ãƒãƒ£ãƒƒãƒˆã‚’æœ‰åŠ¹ã«ã—ã¦ãã ã•ã„";
	}

	protected override string _GetTemplateForMessageChatPrivacySetting()
	{
		return "å‹é”ã¨ãƒãƒ£ãƒƒãƒˆã™ã‚‹ã«ã¯ã€ã€Œ{frontLink}ãƒ—ãƒ©ã‚¤ãƒã‚·ãƒ¼è¨­å®š{endLink}ã€ã§ãƒãƒ£ãƒƒãƒˆã‚’æœ‰åŠ¹ã«ã—ã¦ãã ã•ã„";
	}

	/// <summary>
	/// Key: "Message.conversationTitleChangedText"
	/// English String: "{userName} named the chat group: {groupName}"
	/// </summary>
	public override string MessageconversationTitleChangedText(string userName, string groupName)
	{
		return $"{userName}ã•ã‚“ãŒãƒãƒ£ãƒƒãƒˆã‚°ãƒ«ãƒ¼ãƒ—åã‚’æŒ‡å®šã—ã¾ã—ãŸ: {groupName}";
	}

	protected override string _GetTemplateForMessageconversationTitleChangedText()
	{
		return "{userName}ã•ã‚“ãŒãƒãƒ£ãƒƒãƒˆã‚°ãƒ«ãƒ¼ãƒ—åã‚’æŒ‡å®šã—ã¾ã—ãŸ: {groupName}";
	}

	protected override string _GetTemplateForMessageConversationTitleModerated()
	{
		return "ãƒãƒ£ãƒƒãƒˆã‚°ãƒ«ãƒ¼ãƒ—åãŒè¦åˆ¶å¯¾è±¡ã§ã™ã€‚";
	}

	protected override string _GetTemplateForMessageDefault()
	{
		return "ã“ã®ãƒãƒ£ãƒƒãƒˆã§ã¯ã€å…¨å“¡ãŒã‚ãªãŸã®ãƒ¡ãƒƒã‚»ãƒ¼ã‚¸ã‚’è¦‹ã‚Œã‚‹ã‚ã‘ã§ã¯ã‚ã‚Šã¾ã›ã‚“ã€‚";
	}

	protected override string _GetTemplateForMessageDefaultErrorMsg()
	{
		return "ã‚¨ãƒ©ãƒ¼ãŒç™ºç”Ÿ";
	}

	/// <summary>
	/// Key: "Message.DefaultTitleForMsg"
	/// English String: "{userName} says ..."
	/// </summary>
	public override string MessageDefaultTitleForMsg(string userName)
	{
		return $"{userName}ã•ã‚“ã®ç™ºè¨€...";
	}

	protected override string _GetTemplateForMessageDefaultTitleForMsg()
	{
		return "{userName}ã•ã‚“ã®ç™ºè¨€...";
	}

	/// <summary>
	/// Key: "Message.DefaultTitleForPartyInvite"
	/// English String: "Party invite from {userName}"
	/// </summary>
	public override string MessageDefaultTitleForPartyInvite(string userName)
	{
		return $"{userName}ã•ã‚“ã‹ã‚‰ã®ãƒ‘ãƒ¼ãƒ†ã‚£ã¸ã®æ‹›å¾…";
	}

	protected override string _GetTemplateForMessageDefaultTitleForPartyInvite()
	{
		return "{userName}ã•ã‚“ã‹ã‚‰ã®ãƒ‘ãƒ¼ãƒ†ã‚£ã¸ã®æ‹›å¾…";
	}

	protected override string _GetTemplateForMessageError()
	{
		return "ã‚¨ãƒ©ãƒ¼";
	}

	/// <summary>
	/// Key: "Message.FindGameToPlay"
	/// English String: "{frontLink}Find Games{endLink} to play with your friends!"
	/// </summary>
	public override string MessageFindGameToPlay(string frontLink, string endLink)
	{
		return $"å‹é”ã¨ä¸€ç·’ã«ãƒ—ãƒ¬ã‚¤ã™ã‚‹{frontLink}ã‚²ãƒ¼ãƒ ã‚’è¦‹ã¤ã‘ã‚ˆã†{endLink}ï¼";
	}

	protected override string _GetTemplateForMessageFindGameToPlay()
	{
		return "å‹é”ã¨ä¸€ç·’ã«ãƒ—ãƒ¬ã‚¤ã™ã‚‹{frontLink}ã‚²ãƒ¼ãƒ ã‚’è¦‹ã¤ã‘ã‚ˆã†{endLink}ï¼";
	}

	protected override string _GetTemplateForMessageJoinPartyText()
	{
		return "ãƒ‘ãƒ¼ãƒ†ã‚£ãƒªãƒ¼ãƒ€ãƒ¼ãŒãƒ—ãƒ¬ã‚¤ã™ã‚‹ã‚²ãƒ¼ãƒ ã‚’æŽ¢ã—ã¦ã„ã¾ã™ã€‚";
	}

	protected override string _GetTemplateForMessageMakeFriendsToChatNPlay()
	{
		return "å‹é”ã‚’ä½œã£ã¦ãƒãƒ£ãƒƒãƒˆã‚„ãƒ‘ãƒ¼ãƒ†ã‚£ã‚’å§‹ã‚ã‚ˆã†ï¼";
	}

	protected override string _GetTemplateForMessageMessageContentModerated()
	{
		return "ãƒ¡ãƒƒã‚»ãƒ¼ã‚¸ã¯ã€è¦åˆ¶ã«ã‚ˆã‚Šé€ä¿¡ã•ã‚Œã¾ã›ã‚“ã§ã—ãŸã€‚";
	}

	protected override string _GetTemplateForMessageMessageFilterForReceivers()
	{
		return "ã“ã®ãƒãƒ£ãƒƒãƒˆã§ã¯ã€å…¨å“¡ãŒã‚ãªãŸã®ãƒ¡ãƒƒã‚»ãƒ¼ã‚¸ã‚’è¦‹ã‚Œã‚‹ã‚ã‘ã§ã¯ã‚ã‚Šã¾ã›ã‚“ã€‚";
	}

	protected override string _GetTemplateForMessageNoConnectionMsg()
	{
		return "æŽ¥ç¶šä¸­...";
	}

	protected override string _GetTemplateForMessagePartyInviteMsg()
	{
		return "ãƒ‘ãƒ¼ãƒ†ã‚£ã¸ã®æ‹›å¾…ï¼";
	}

	/// <summary>
	/// Key: "Message.PinGameUpdate"
	/// users pinned game in conversation
	/// English String: "{userName} chose a game to play together: {gameName}"
	/// </summary>
	public override string MessagePinGameUpdate(string userName, string gameName)
	{
		return $"{userName} ã•ã‚“ãŒä¸€ç·’ã«ãƒ—ãƒ¬ã‚¤ã™ã‚‹ã‚²ãƒ¼ãƒ ã‚’é¸ã³ã¾ã—ãŸ: {gameName}";
	}

	protected override string _GetTemplateForMessagePinGameUpdate()
	{
		return "{userName} ã•ã‚“ãŒä¸€ç·’ã«ãƒ—ãƒ¬ã‚¤ã™ã‚‹ã‚²ãƒ¼ãƒ ã‚’é¸ã³ã¾ã—ãŸ: {gameName}";
	}

	protected override string _GetTemplateForMessagePlayGameUpdate()
	{
		return " ã•ã‚“ã¯ã€ãƒ”ãƒ³ã‚’ä»˜ã‘ãŸä»¥ä¸‹ã®ã‚²ãƒ¼ãƒ ã‚’ãƒ—ãƒ¬ã‚¤ä¸­: ";
	}

	protected override string _GetTemplateForMessageTextTooLong()
	{
		return "ãƒ¡ãƒƒã‚»ãƒ¼ã‚¸ãŒé•·ã™ãŽã‚‹ãŸã‚ã€é€ä¿¡ã•ã‚Œã¾ã›ã‚“ã§ã—ãŸã€‚";
	}

	/// <summary>
	/// Key: "Message.ToastText"
	/// English String: "You can have up to {friendNum} friends in chat group."
	/// </summary>
	public override string MessageToastText(string friendNum)
	{
		return $"ãƒãƒ£ãƒƒãƒˆã‚°ãƒ«ãƒ¼ãƒ—ã«ã¯å‹é”ã‚’{friendNum}äººã¾ã§è¿½åŠ ã§ãã¾ã™ã€‚";
	}

	protected override string _GetTemplateForMessageToastText()
	{
		return "ãƒãƒ£ãƒƒãƒˆã‚°ãƒ«ãƒ¼ãƒ—ã«ã¯å‹é”ã‚’{friendNum}äººã¾ã§è¿½åŠ ã§ãã¾ã™ã€‚";
	}

	protected override string _GetTemplateForMessageUnknownMessageType()
	{
		return "ãƒ¡ãƒƒã‚»ãƒ¼ã‚¸ã‚’è¡¨ç¤ºã§ãã¾ã›ã‚“";
	}

	protected override string _GetTemplateForPlayButton()
	{
		return "ãƒ—ãƒ¬ã‚¤";
	}

	protected override string _GetTemplateForResponsePartyInvite()
	{
		return "ãƒ‘ãƒ¼ãƒ†ã‚£ã¸ã®æ‹›å¾…ãŒå±Šãã¾ã—ãŸã€‚";
	}
}


}
