namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides ChatResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ChatResources_ko_kr : ChatResources_en_us, IChatResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Add"
	/// English String: "Add"
	/// </summary>
	public override string ActionAdd => "ì¶”ê°€";

	/// <summary>
	/// Key: "Action.BuyAccess"
	/// English String: "Buy Access"
	/// </summary>
	public override string ActionBuyAccess => "ì´ìš©ê¶Œ êµ¬ë§¤";

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "ì·¨ì†Œ";

	/// <summary>
	/// Key: "Action.Create"
	/// English String: "Create"
	/// </summary>
	public override string ActionCreate => "ë§Œë“¤ê¸°";

	/// <summary>
	/// Key: "Action.Join"
	/// join the voice chat conversation
	/// English String: "Join"
	/// </summary>
	public override string ActionJoin => "ê°€ìž…";

	/// <summary>
	/// Key: "Action.Leave"
	/// English String: "Leave"
	/// </summary>
	public override string ActionLeave => "ë‚˜ê°€ê¸°";

	/// <summary>
	/// Key: "Action.Remove"
	/// English String: "Remove"
	/// </summary>
	public override string ActionRemove => "ì‚­ì œ";

	/// <summary>
	/// Key: "Action.Report"
	/// English String: "Report"
	/// </summary>
	public override string ActionReport => "ì‹ ê³ í•˜ê¸°";

	/// <summary>
	/// Key: "Action.Save"
	/// English String: "Save"
	/// </summary>
	public override string ActionSave => "ì €ìž¥";

	/// <summary>
	/// Key: "Action.Send"
	/// English String: "Send"
	/// </summary>
	public override string ActionSend => "ë³´ë‚´ê¸°";

	/// <summary>
	/// Key: "Action.Set"
	/// English String: "Set"
	/// </summary>
	public override string ActionSet => "ì„¤ì •";

	/// <summary>
	/// Key: "Action.StartParty"
	/// button label
	/// English String: "Start a Party"
	/// </summary>
	public override string ActionStartParty => "íŒŒí‹° ì‹œìž‘í•˜ê¸°";

	/// <summary>
	/// Key: "Action.Stay"
	/// English String: "Stay"
	/// </summary>
	public override string ActionStay => "ë¨¸ë¬¼ê¸°";

	/// <summary>
	/// Key: "Action.TurnOn"
	/// English String: "Turn On"
	/// </summary>
	public override string ActionTurnOn => "ì¼œê¸°";

	/// <summary>
	/// Key: "Heading.BuyItem"
	/// English String: "Buy Item"
	/// </summary>
	public override string HeadingBuyItem => "ì•„ì´í…œ êµ¬ë§¤";

	/// <summary>
	/// Key: "Heading.Chat"
	/// English String: "Chat"
	/// </summary>
	public override string HeadingChat => "ì±„íŒ…";

	public override string HeadingChatAndParty => "ì±„íŒ… ë° íŒŒí‹°";

	/// <summary>
	/// Key: "Heading.ConfirmLeaving"
	/// English String: "Are you sure to leave this chat group?"
	/// </summary>
	public override string HeadingConfirmLeaving => "ì±„íŒ…ê·¸ë£¹ì„ ì •ë§ ë‚˜ê°€ì‹œê² ìŠµë‹ˆê¹Œ?";

	/// <summary>
	/// Key: "Heading.ContinueToReport"
	/// English String: "Continue to report?"
	/// </summary>
	public override string HeadingContinueToReport => "ì‹ ê³ ë¥¼ ê³„ì† í•˜ì‹œê² ìŠµë‹ˆê¹Œ?";

	/// <summary>
	/// Key: "Heading.CreateParty"
	/// English String: "Create Party"
	/// </summary>
	public override string HeadingCreateParty => "íŒŒí‹° ë§Œë“¤ê¸°";

	/// <summary>
	/// Key: "Heading.LeaveChatGroup"
	/// English String: "Leave Chat Group"
	/// </summary>
	public override string HeadingLeaveChatGroup => "ì±„íŒ…ê·¸ë£¹ ë‚˜ê°€ê¸°";

	/// <summary>
	/// Key: "Heading.LeaveChatGroupQ"
	/// English String: "Leave Chat Group?"
	/// </summary>
	public override string HeadingLeaveChatGroupQ => "ì±„íŒ…ê·¸ë£¹ì„ ë‚˜ê°€ì‹œê² ìŠµë‹ˆê¹Œ?";

	/// <summary>
	/// Key: "Heading.NewChatGroup"
	/// English String: "New Chat Group"
	/// </summary>
	public override string HeadingNewChatGroup => "ìƒˆ ì±„íŒ…ê·¸ë£¹";

	/// <summary>
	/// Key: "Heading.RemoveUser"
	/// English String: "Remove User?"
	/// </summary>
	public override string HeadingRemoveUser => "ì‚¬ìš©ìžë¥¼ ì‚­ì œí•˜ì‹œê² ìŠµë‹ˆê¹Œ?";

	/// <summary>
	/// Key: "Heading.Report"
	/// heading for abuse report dialog
	/// English String: "Report"
	/// </summary>
	public override string HeadingReport => "ì‹ ê³ í•˜ê¸°";

	/// <summary>
	/// Key: "Label.AddFriends"
	/// English String: "Add Friends"
	/// </summary>
	public override string LabelAddFriends => "ì¹œêµ¬ ì¶”ê°€";

	/// <summary>
	/// Key: "Label.BuyButton"
	/// English String: "Buy"
	/// </summary>
	public override string LabelBuyButton => "êµ¬ë§¤";

	/// <summary>
	/// Key: "Label.ChangeChatGroupName"
	/// English String: "Change your chat group name"
	/// </summary>
	public override string LabelChangeChatGroupName => "ì±„íŒ…ê·¸ë£¹ ì´ë¦„ ë³€ê²½";

	/// <summary>
	/// Key: "Label.ChatDetails"
	/// English String: "Chat Details"
	/// </summary>
	public override string LabelChatDetails => "ì±„íŒ… ì •ë³´";

	/// <summary>
	/// Key: "Label.ChatGroupName"
	/// English String: "Chat Group Name"
	/// </summary>
	public override string LabelChatGroupName => "ì±„íŒ…ê·¸ë£¹ ì´ë¦„";

	/// <summary>
	/// Key: "Label.Close"
	/// English String: "Close"
	/// </summary>
	public override string LabelClose => "ë‹«ê¸°";

	/// <summary>
	/// Key: "Label.ConversationNotifications"
	/// conversation notification
	/// English String: "Notifications"
	/// </summary>
	public override string LabelConversationNotifications => "ì•Œë¦¼";

	/// <summary>
	/// Key: "Label.ConversationNotificationsOn"
	/// conversation notification is on
	/// English String: "On"
	/// </summary>
	public override string LabelConversationNotificationsOn => "ì¼œê¸°";

	/// <summary>
	/// Key: "Label.Details.PlayTogether"
	/// English String: "PlayTogether"
	/// </summary>
	public override string LabelDetailsPlayTogether => "í•¨ê»˜ í”Œë ˆì´";

	/// <summary>
	/// Key: "Label.FindGame"
	/// English String: "Find Game"
	/// </summary>
	public override string LabelFindGame => "ê²Œìž„ ì°¾ê¸°";

	/// <summary>
	/// Key: "Label.GameNotAvailableButton"
	/// English String: "Not Available"
	/// </summary>
	public override string LabelGameNotAvailableButton => "ì´ìš© ë¶ˆê°€";

	/// <summary>
	/// Key: "Label.General"
	/// English String: "General"
	/// </summary>
	public override string LabelGeneral => "ì¼ë°˜";

	/// <summary>
	/// Key: "Label.InGame"
	/// English String: "In Game"
	/// </summary>
	public override string LabelInGame => "ê²Œìž„ ì¤‘";

	/// <summary>
	/// Key: "Label.InputPlaceHolder.SearchForFriends"
	/// English String: "Search for friends"
	/// </summary>
	public override string LabelInputPlaceHolderSearchForFriends => "ì¹œêµ¬ ì°¾ê¸°";

	/// <summary>
	/// Key: "Label.InputPlaceHolder.SendMessage"
	/// English String: "Send a message"
	/// </summary>
	public override string LabelInputPlaceHolderSendMessage => "ë©”ì‹œì§€ ë³´ë‚´ê¸°";

	/// <summary>
	/// Key: "Label.InStudio"
	/// English String: "In Studio"
	/// </summary>
	public override string LabelInStudio => "Studio ì‚¬ìš© ì¤‘";

	/// <summary>
	/// Key: "Label.JoinButton"
	/// English String: "Join"
	/// </summary>
	public override string LabelJoinButton => "ê°€ìž…";

	/// <summary>
	/// Key: "Label.JoinGame"
	/// English String: "Join Game"
	/// </summary>
	public override string LabelJoinGame => "ê²Œìž„ ì°¸ê°€";

	/// <summary>
	/// Key: "Label.JoinParty"
	/// English String: "Join Party"
	/// </summary>
	public override string LabelJoinParty => "íŒŒí‹° ì°¸ê°€";

	/// <summary>
	/// Key: "Label.LeaveChatGroup"
	/// English String: "Leave Chat Group"
	/// </summary>
	public override string LabelLeaveChatGroup => "ì±„íŒ…ê·¸ë£¹ ë‚˜ê°€ê¸°";

	/// <summary>
	/// Key: "Label.LeaveParty"
	/// English String: "Leave Party"
	/// </summary>
	public override string LabelLeaveParty => "íŒŒí‹° ë‚˜ê°€ê¸°";

	/// <summary>
	/// Key: "Label.Member"
	/// English String: "Member"
	/// </summary>
	public override string LabelMember => "ë©¤ë²„";

	/// <summary>
	/// Key: "Label.Members"
	/// English String: "Members"
	/// </summary>
	public override string LabelMembers => "ë©¤ë²„";

	/// <summary>
	/// Key: "Label.Mute15Minutes"
	/// mute conversation for 15 mins
	/// English String: "For 15 minutes"
	/// </summary>
	public override string LabelMute15Minutes => "15ë¶„";

	/// <summary>
	/// Key: "Label.Mute1Hour"
	/// Mute conversation for 1 hour
	/// English String: "For an hour"
	/// </summary>
	public override string LabelMute1Hour => "1ì‹œê°„";

	/// <summary>
	/// Key: "Label.Mute24Hours"
	/// Mute conversation for a day
	/// English String: "For a day"
	/// </summary>
	public override string LabelMute24Hours => "í•˜ë£¨";

	/// <summary>
	/// Key: "Label.Mute8Hours"
	/// Mute conversation for 8 hours
	/// English String: "For 8 hours"
	/// </summary>
	public override string LabelMute8Hours => "8ì‹œê°„";

	/// <summary>
	/// Key: "Label.MuteConversationNotificationsForGroup"
	/// English String: "Mute notifications for this chat group"
	/// </summary>
	public override string LabelMuteConversationNotificationsForGroup => "ì±„íŒ…ê·¸ë£¹ ì•Œë¦¼ ìŒì†Œê±°";

	/// <summary>
	/// Key: "Label.MuteConversationNotificationsForOneToOne"
	/// English String: "Mute notifications for this conversation"
	/// </summary>
	public override string LabelMuteConversationNotificationsForOneToOne => "ëŒ€í™” ì¤‘ ì•Œë¦¼ ìŒì†Œê±°";

	/// <summary>
	/// Key: "Label.MuteInfinite"
	/// Mute conversation until user turns back
	/// English String: "Until I turn them back on"
	/// </summary>
	public override string LabelMuteInfinite => "ë‹¤ì‹œ ì¼¤ ë•Œê¹Œì§€";

	/// <summary>
	/// Key: "Label.NameYourChangeGroup"
	/// English String: "Name your change group"
	/// </summary>
	public override string LabelNameYourChangeGroup => "ì±„íŒ…ê·¸ë£¹ ì´ë¦„ ì„¤ì •";

	/// <summary>
	/// Key: "Label.NameYourChatGroup"
	/// English String: "Name your chat group"
	/// </summary>
	public override string LabelNameYourChatGroup => "ì±„íŒ…ê·¸ë£¹ ì´ë¦„ ì„¤ì •";

	/// <summary>
	/// Key: "Label.NotImplementedMessageType"
	/// This message is displayed in chat when user receives message type that can't be rendered by current app version and update is not available, yet (e.g. latest version was rolled back, or in deprecated Android native chat)
	/// English String: "This message could not be displayed."
	/// </summary>
	public override string LabelNotImplementedMessageType => "ì´ ë©”ì‹œì§€ë¥¼ í‘œì‹œí•  ìˆ˜ ì—†ì–´ìš”.";

	/// <summary>
	/// Key: "Label.Offline"
	/// English String: "Offline"
	/// </summary>
	public override string LabelOffline => "ì˜¤í”„ë¼ì¸";

	/// <summary>
	/// Key: "Label.Online"
	/// English String: "Online"
	/// </summary>
	public override string LabelOnline => "ì˜¨ë¼ì¸";

	/// <summary>
	/// Key: "Label.PinGameTooltip"
	/// English String: "Pin Game"
	/// </summary>
	public override string LabelPinGameTooltip => "ê²Œìž„ í•€í•˜ê¸°";

	/// <summary>
	/// Key: "Label.PinnedGame"
	/// This is a title of card, means this game card is pinned game
	/// English String: "Pinned Game"
	/// </summary>
	public override string LabelPinnedGame => "í•€í•œ ê²Œìž„";

	/// <summary>
	/// Key: "Label.PlayButton"
	/// English String: "Play"
	/// </summary>
	public override string LabelPlayButton => "í”Œë ˆì´";

	/// <summary>
	/// Key: "Label.PlayGames"
	/// English String: "Play Games"
	/// </summary>
	public override string LabelPlayGames => "ê²Œìž„ í”Œë ˆì´";

	/// <summary>
	/// Key: "Label.PlayTogether"
	/// English String: "Play Together"
	/// </summary>
	public override string LabelPlayTogether => "í•¨ê»˜ í”Œë ˆì´";

	/// <summary>
	/// Key: "Label.RecommendedGames"
	/// English String: "Recommended"
	/// </summary>
	public override string LabelRecommendedGames => "ì¶”ì²œ";

	/// <summary>
	/// Key: "Label.SeeLess"
	/// English String: "See Less"
	/// </summary>
	public override string LabelSeeLess => "ê°„ëžµížˆ ë³´ê¸°";

	/// <summary>
	/// Key: "Label.SeeMore"
	/// English String: "See More"
	/// </summary>
	public override string LabelSeeMore => "ë” ë³´ê¸°";

	/// <summary>
	/// Key: "Label.ShowLessGames"
	/// English String: "Show Less"
	/// </summary>
	public override string LabelShowLessGames => "ê°„ëžµížˆ ë³´ê¸°";

	/// <summary>
	/// Key: "Label.SpanTitle.CreateGroupNeeds2More"
	/// English String: "Add at least 2 people to create chat group"
	/// </summary>
	public override string LabelSpanTitleCreateGroupNeeds2More => "2ëª… ì´ìƒì„ ì¶”ê°€í•´ì•¼ ì±„íŒ… ê·¸ë£¹ì„ ë§Œë“¤ ìˆ˜ ìžˆìŠµë‹ˆë‹¤";

	/// <summary>
	/// Key: "Label.SpanTitle.Loading"
	/// English String: "loading ..."
	/// </summary>
	public override string LabelSpanTitleLoading => "ë¡œë“œ ì¤‘...";

	/// <summary>
	/// Key: "Label.TimestampOffUntilTomorrow"
	/// English String: "Off until tomorrow"
	/// </summary>
	public override string LabelTimestampOffUntilTomorrow => "ë‚´ì¼ê¹Œì§€ ë„ê¸°";

	/// <summary>
	/// Key: "Label.TimestampOffUntilTurnedBackOn"
	/// English String: "Off until turned back on\""
	/// </summary>
	public override string LabelTimestampOffUntilTurnedBackOn => "ë‹¤ì‹œ ì¼¤ ë•Œê¹Œì§€ ë„ê¸°\"";

	/// <summary>
	/// Key: "Label.TurnOnConversationNotificationsPrompt"
	/// English String: "Do you want to turn on notifications?"
	/// </summary>
	public override string LabelTurnOnConversationNotificationsPrompt => "ì•Œë¦¼ì„ ì¼¤ê¹Œìš”?";

	/// <summary>
	/// Key: "Label.UnpinGameTooltip"
	/// English String: "Unpin Game"
	/// </summary>
	public override string LabelUnpinGameTooltip => "ê²Œìž„ í•€ í•´ì œí•˜ê¸°";

	/// <summary>
	/// Key: "Label.ViewDetailsButton"
	/// English String: "View Details"
	/// </summary>
	public override string LabelViewDetailsButton => "ìžì„¸ížˆ ë³´ê¸°";

	/// <summary>
	/// Key: "Label.ViewProfile"
	/// English String: "View Profile"
	/// </summary>
	public override string LabelViewProfile => "í”„ë¡œí•„ ë³´ê¸°";

	/// <summary>
	/// Key: "Label.Yesterday"
	/// time stamp for chat message received yesterday
	/// English String: "Yesterday"
	/// </summary>
	public override string LabelYesterday => "ì–´ì œ";

	/// <summary>
	/// Key: "Message.ConversationTitleModerated"
	/// Chat group name was moderated.
	/// English String: "Chat group name was moderated."
	/// </summary>
	public override string MessageConversationTitleModerated => "ì±„íŒ…ê·¸ë£¹ ì´ë¦„ì´ ê²€ì—´ì„ í†µê³¼í•˜ì§€ ëª»í–ˆìŠµë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Message.Default"
	/// English String: "Not everyone in this chat can see your message."
	/// </summary>
	public override string MessageDefault => "ì±„íŒ… ì°¸ê°€ìž ì¤‘ ì¼ë¶€ëŠ” íšŒì›ë‹˜ì˜ ë©”ì‹œì§€ë¥¼ ë³¼ ìˆ˜ ì—†ì–´ìš”.";

	/// <summary>
	/// Key: "Message.DefaultErrorMsg"
	/// English String: "An error occurred"
	/// </summary>
	public override string MessageDefaultErrorMsg => "ì˜¤ë¥˜ê°€ ë°œìƒí–ˆì–´ìš”";

	/// <summary>
	/// Key: "Message.Error"
	/// English String: "Error"
	/// </summary>
	public override string MessageError => "ì˜¤ë¥˜";

	/// <summary>
	/// Key: "Message.JoinPartyText"
	/// English String: "The party leader is finding a game to play."
	/// </summary>
	public override string MessageJoinPartyText => "íŒŒí‹°ìž¥ì´ í”Œë ˆì´í•  ê²Œìž„ì„ ì°¾ê³  ìžˆì–´ìš”.";

	/// <summary>
	/// Key: "Message.MakeFriendsToChatNPlay"
	/// English String: "Make friends to start chatting and partying!"
	/// </summary>
	public override string MessageMakeFriendsToChatNPlay => "ì±„íŒ…ê³¼ íŒŒí‹° í™œë™ì„ ì‹œìž‘í•˜ë ¤ë©´ ì¹œêµ¬ë¥¼ ë§Œë“œì„¸ìš”!";

	/// <summary>
	/// Key: "Message.MessageContentModerated"
	/// English String: "Your message was moderated and not sent."
	/// </summary>
	public override string MessageMessageContentModerated => "ë©”ì‹œì§€ê°€ ê²€ì—´ì„ í†µê³¼í•˜ì§€ ëª»í•´ ì „ì†¡ë˜ì§€ ì•Šì•˜ì–´ìš”.";

	/// <summary>
	/// Key: "Message.MessageFilterForReceivers"
	/// English String: "Not everyone in this chat can see your message."
	/// </summary>
	public override string MessageMessageFilterForReceivers => "ì±„íŒ… ì°¸ê°€ìž ì¤‘ ì¼ë¶€ëŠ” íšŒì›ë‹˜ì˜ ë©”ì‹œì§€ë¥¼ ë³¼ ìˆ˜ ì—†ì–´ìš”.";

	/// <summary>
	/// Key: "Message.NoConnectionMsg"
	/// English String: "Connecting..."
	/// </summary>
	public override string MessageNoConnectionMsg => "ì—°ê²° ì¤‘...";

	/// <summary>
	/// Key: "Message.PartyInviteMsg"
	/// English String: "PARTY INVITE!"
	/// </summary>
	public override string MessagePartyInviteMsg => "íŒŒí‹° ì´ˆëŒ€!";

	/// <summary>
	/// Key: "Message.PlayGameUpdate"
	/// English String: " is playing the pinned game: "
	/// </summary>
	public override string MessagePlayGameUpdate => " ë‹˜ì´ í•€í•œ ê²Œìž„ í”Œë ˆì´ ì¤‘: ";

	/// <summary>
	/// Key: "Message.TextTooLong"
	/// English String: "Your message was too long and not sent."
	/// </summary>
	public override string MessageTextTooLong => "ë©”ì‹œì§€ê°€ ë„ˆë¬´ ê¸¸ì–´ì„œ ì „ì†¡ë˜ì§€ ì•Šì•˜ì–´ìš”.";

	/// <summary>
	/// Key: "Message.UnknownMessageType"
	/// This serves as the fallback string for when an message type is received that the web chat does not know how to render.
	/// English String: "A message cannot be displayed"
	/// </summary>
	public override string MessageUnknownMessageType => "ë©”ì‹œì§€ë¥¼ í‘œì‹œí•  ìˆ˜ ì—†ìŒ";

	/// <summary>
	/// Key: "PlayButton"
	/// English String: "Play"
	/// </summary>
	public override string PlayButton => "í”Œë ˆì´";

	/// <summary>
	/// Key: "Response.PartyInvite"
	/// notification message
	/// English String: "You received a party Invite."
	/// </summary>
	public override string ResponsePartyInvite => "íŒŒí‹° ì´ˆëŒ€ë¥¼ ë°›ì•˜ì–´ìš”.";

	public ChatResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAdd()
	{
		return "ì¶”ê°€";
	}

	protected override string _GetTemplateForActionBuyAccess()
	{
		return "ì´ìš©ê¶Œ êµ¬ë§¤";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "ì·¨ì†Œ";
	}

	protected override string _GetTemplateForActionCreate()
	{
		return "ë§Œë“¤ê¸°";
	}

	protected override string _GetTemplateForActionJoin()
	{
		return "ê°€ìž…";
	}

	protected override string _GetTemplateForActionLeave()
	{
		return "ë‚˜ê°€ê¸°";
	}

	protected override string _GetTemplateForActionRemove()
	{
		return "ì‚­ì œ";
	}

	protected override string _GetTemplateForActionReport()
	{
		return "ì‹ ê³ í•˜ê¸°";
	}

	protected override string _GetTemplateForActionSave()
	{
		return "ì €ìž¥";
	}

	protected override string _GetTemplateForActionSend()
	{
		return "ë³´ë‚´ê¸°";
	}

	protected override string _GetTemplateForActionSet()
	{
		return "ì„¤ì •";
	}

	protected override string _GetTemplateForActionStartParty()
	{
		return "íŒŒí‹° ì‹œìž‘í•˜ê¸°";
	}

	protected override string _GetTemplateForActionStay()
	{
		return "ë¨¸ë¬¼ê¸°";
	}

	protected override string _GetTemplateForActionTurnOn()
	{
		return "ì¼œê¸°";
	}

	protected override string _GetTemplateForHeadingBuyItem()
	{
		return "ì•„ì´í…œ êµ¬ë§¤";
	}

	protected override string _GetTemplateForHeadingChat()
	{
		return "ì±„íŒ…";
	}

	protected override string _GetTemplateForHeadingChatAndParty()
	{
		return "ì±„íŒ… ë° íŒŒí‹°";
	}

	protected override string _GetTemplateForHeadingConfirmLeaving()
	{
		return "ì±„íŒ…ê·¸ë£¹ì„ ì •ë§ ë‚˜ê°€ì‹œê² ìŠµë‹ˆê¹Œ?";
	}

	protected override string _GetTemplateForHeadingContinueToReport()
	{
		return "ì‹ ê³ ë¥¼ ê³„ì† í•˜ì‹œê² ìŠµë‹ˆê¹Œ?";
	}

	protected override string _GetTemplateForHeadingCreateParty()
	{
		return "íŒŒí‹° ë§Œë“¤ê¸°";
	}

	protected override string _GetTemplateForHeadingLeaveChatGroup()
	{
		return "ì±„íŒ…ê·¸ë£¹ ë‚˜ê°€ê¸°";
	}

	protected override string _GetTemplateForHeadingLeaveChatGroupQ()
	{
		return "ì±„íŒ…ê·¸ë£¹ì„ ë‚˜ê°€ì‹œê² ìŠµë‹ˆê¹Œ?";
	}

	protected override string _GetTemplateForHeadingNewChatGroup()
	{
		return "ìƒˆ ì±„íŒ…ê·¸ë£¹";
	}

	protected override string _GetTemplateForHeadingRemoveUser()
	{
		return "ì‚¬ìš©ìžë¥¼ ì‚­ì œí•˜ì‹œê² ìŠµë‹ˆê¹Œ?";
	}

	protected override string _GetTemplateForHeadingReport()
	{
		return "ì‹ ê³ í•˜ê¸°";
	}

	protected override string _GetTemplateForLabelAddFriends()
	{
		return "ì¹œêµ¬ ì¶”ê°€";
	}

	/// <summary>
	/// Key: "Label.BuyAccessToGameForModal"
	/// English String: "Would you like to buy access to the Place: {placeName} from {creatorName} for {robux}?"
	/// </summary>
	public override string LabelBuyAccessToGameForModal(string placeName, string creatorName, string robux)
	{
		return $"{creatorName}ì´(ê°€) ë§Œë“  {placeName} ì´ìš©ê¶Œì„ {robux}ìœ¼(ë¡œ) êµ¬ë§¤í• ê¹Œìš”?";
	}

	protected override string _GetTemplateForLabelBuyAccessToGameForModal()
	{
		return "{creatorName}ì´(ê°€) ë§Œë“  {placeName} ì´ìš©ê¶Œì„ {robux}ìœ¼(ë¡œ) êµ¬ë§¤í• ê¹Œìš”?";
	}

	protected override string _GetTemplateForLabelBuyButton()
	{
		return "êµ¬ë§¤";
	}

	protected override string _GetTemplateForLabelChangeChatGroupName()
	{
		return "ì±„íŒ…ê·¸ë£¹ ì´ë¦„ ë³€ê²½";
	}

	protected override string _GetTemplateForLabelChatDetails()
	{
		return "ì±„íŒ… ì •ë³´";
	}

	protected override string _GetTemplateForLabelChatGroupName()
	{
		return "ì±„íŒ…ê·¸ë£¹ ì´ë¦„";
	}

	protected override string _GetTemplateForLabelClose()
	{
		return "ë‹«ê¸°";
	}

	protected override string _GetTemplateForLabelConversationNotifications()
	{
		return "ì•Œë¦¼";
	}

	protected override string _GetTemplateForLabelConversationNotificationsOn()
	{
		return "ì¼œê¸°";
	}

	protected override string _GetTemplateForLabelDetailsPlayTogether()
	{
		return "í•¨ê»˜ í”Œë ˆì´";
	}

	protected override string _GetTemplateForLabelFindGame()
	{
		return "ê²Œìž„ ì°¾ê¸°";
	}

	protected override string _GetTemplateForLabelGameNotAvailableButton()
	{
		return "ì´ìš© ë¶ˆê°€";
	}

	protected override string _GetTemplateForLabelGeneral()
	{
		return "ì¼ë°˜";
	}

	protected override string _GetTemplateForLabelInGame()
	{
		return "ê²Œìž„ ì¤‘";
	}

	protected override string _GetTemplateForLabelInputPlaceHolderSearchForFriends()
	{
		return "ì¹œêµ¬ ì°¾ê¸°";
	}

	protected override string _GetTemplateForLabelInputPlaceHolderSendMessage()
	{
		return "ë©”ì‹œì§€ ë³´ë‚´ê¸°";
	}

	protected override string _GetTemplateForLabelInStudio()
	{
		return "Studio ì‚¬ìš© ì¤‘";
	}

	protected override string _GetTemplateForLabelJoinButton()
	{
		return "ê°€ìž…";
	}

	protected override string _GetTemplateForLabelJoinGame()
	{
		return "ê²Œìž„ ì°¸ê°€";
	}

	protected override string _GetTemplateForLabelJoinParty()
	{
		return "íŒŒí‹° ì°¸ê°€";
	}

	protected override string _GetTemplateForLabelLeaveChatGroup()
	{
		return "ì±„íŒ…ê·¸ë£¹ ë‚˜ê°€ê¸°";
	}

	protected override string _GetTemplateForLabelLeaveParty()
	{
		return "íŒŒí‹° ë‚˜ê°€ê¸°";
	}

	protected override string _GetTemplateForLabelMember()
	{
		return "ë©¤ë²„";
	}

	/// <summary>
	/// Key: "Label.MemberJoinText"
	/// English String: "{userName} joined the party"
	/// </summary>
	public override string LabelMemberJoinText(string userName)
	{
		return $"{userName}ë‹˜ì´ íŒŒí‹°ì— ì°¸ê°€í–ˆì–´ìš”";
	}

	protected override string _GetTemplateForLabelMemberJoinText()
	{
		return "{userName}ë‹˜ì´ íŒŒí‹°ì— ì°¸ê°€í–ˆì–´ìš”";
	}

	protected override string _GetTemplateForLabelMembers()
	{
		return "ë©¤ë²„";
	}

	protected override string _GetTemplateForLabelMute15Minutes()
	{
		return "15ë¶„";
	}

	protected override string _GetTemplateForLabelMute1Hour()
	{
		return "1ì‹œê°„";
	}

	protected override string _GetTemplateForLabelMute24Hours()
	{
		return "í•˜ë£¨";
	}

	protected override string _GetTemplateForLabelMute8Hours()
	{
		return "8ì‹œê°„";
	}

	protected override string _GetTemplateForLabelMuteConversationNotificationsForGroup()
	{
		return "ì±„íŒ…ê·¸ë£¹ ì•Œë¦¼ ìŒì†Œê±°";
	}

	protected override string _GetTemplateForLabelMuteConversationNotificationsForOneToOne()
	{
		return "ëŒ€í™” ì¤‘ ì•Œë¦¼ ìŒì†Œê±°";
	}

	protected override string _GetTemplateForLabelMuteInfinite()
	{
		return "ë‹¤ì‹œ ì¼¤ ë•Œê¹Œì§€";
	}

	protected override string _GetTemplateForLabelNameYourChangeGroup()
	{
		return "ì±„íŒ…ê·¸ë£¹ ì´ë¦„ ì„¤ì •";
	}

	protected override string _GetTemplateForLabelNameYourChatGroup()
	{
		return "ì±„íŒ…ê·¸ë£¹ ì´ë¦„ ì„¤ì •";
	}

	protected override string _GetTemplateForLabelNotImplementedMessageType()
	{
		return "ì´ ë©”ì‹œì§€ë¥¼ í‘œì‹œí•  ìˆ˜ ì—†ì–´ìš”.";
	}

	protected override string _GetTemplateForLabelOffline()
	{
		return "ì˜¤í”„ë¼ì¸";
	}

	protected override string _GetTemplateForLabelOnline()
	{
		return "ì˜¨ë¼ì¸";
	}

	/// <summary>
	/// Key: "Label.PartyLeaderTooltip"
	/// English String: "{userName} is the party leader"
	/// </summary>
	public override string LabelPartyLeaderTooltip(string userName)
	{
		return $"{userName}ë‹˜ì´ íŒŒí‹°ìž¥ìž…ë‹ˆë‹¤";
	}

	protected override string _GetTemplateForLabelPartyLeaderTooltip()
	{
		return "{userName}ë‹˜ì´ íŒŒí‹°ìž¥ìž…ë‹ˆë‹¤";
	}

	/// <summary>
	/// Key: "Label.PartyMemberTooltip"
	/// English String: "{userName} is in the party"
	/// </summary>
	public override string LabelPartyMemberTooltip(string userName)
	{
		return $"{userName}ë‹˜ì€ íŒŒí‹° ì†Œì†ì´ì—ìš”";
	}

	protected override string _GetTemplateForLabelPartyMemberTooltip()
	{
		return "{userName}ë‹˜ì€ íŒŒí‹° ì†Œì†ì´ì—ìš”";
	}

	/// <summary>
	/// Key: "Label.PartyName"
	/// English String: "Party : {title}"
	/// </summary>
	public override string LabelPartyName(string title)
	{
		return $"íŒŒí‹°: {title}";
	}

	protected override string _GetTemplateForLabelPartyName()
	{
		return "íŒŒí‹°: {title}";
	}

	/// <summary>
	/// Key: "Label.PendingMemberTooltip"
	/// English String: "{userName} is not in the party"
	/// </summary>
	public override string LabelPendingMemberTooltip(string userName)
	{
		return $"{userName}ë‹˜ì€ íŒŒí‹° ì†Œì†ì´ ì•„ë‹ˆì—ìš”";
	}

	protected override string _GetTemplateForLabelPendingMemberTooltip()
	{
		return "{userName}ë‹˜ì€ íŒŒí‹° ì†Œì†ì´ ì•„ë‹ˆì—ìš”";
	}

	protected override string _GetTemplateForLabelPinGameTooltip()
	{
		return "ê²Œìž„ í•€í•˜ê¸°";
	}

	protected override string _GetTemplateForLabelPinnedGame()
	{
		return "í•€í•œ ê²Œìž„";
	}

	protected override string _GetTemplateForLabelPlayButton()
	{
		return "í”Œë ˆì´";
	}

	protected override string _GetTemplateForLabelPlayGames()
	{
		return "ê²Œìž„ í”Œë ˆì´";
	}

	/// <summary>
	/// Key: "Label.PlayingGame"
	/// English String: "Playing {game}"
	/// </summary>
	public override string LabelPlayingGame(string game)
	{
		return $"{game} í”Œë ˆì´ ì¤‘";
	}

	protected override string _GetTemplateForLabelPlayingGame()
	{
		return "{game} í”Œë ˆì´ ì¤‘";
	}

	protected override string _GetTemplateForLabelPlayTogether()
	{
		return "í•¨ê»˜ í”Œë ˆì´";
	}

	protected override string _GetTemplateForLabelRecommendedGames()
	{
		return "ì¶”ì²œ";
	}

	protected override string _GetTemplateForLabelSeeLess()
	{
		return "ê°„ëžµížˆ ë³´ê¸°";
	}

	protected override string _GetTemplateForLabelSeeMore()
	{
		return "ë” ë³´ê¸°";
	}

	protected override string _GetTemplateForLabelShowLessGames()
	{
		return "ê°„ëžµížˆ ë³´ê¸°";
	}

	/// <summary>
	/// Key: "Label.ShowMoreGames"
	/// English String: "Show More (+{count})"
	/// </summary>
	public override string LabelShowMoreGames(string count)
	{
		return $"ë” ë³´ê¸° (+{count})";
	}

	protected override string _GetTemplateForLabelShowMoreGames()
	{
		return "ë” ë³´ê¸° (+{count})";
	}

	protected override string _GetTemplateForLabelSpanTitleCreateGroupNeeds2More()
	{
		return "2ëª… ì´ìƒì„ ì¶”ê°€í•´ì•¼ ì±„íŒ… ê·¸ë£¹ì„ ë§Œë“¤ ìˆ˜ ìžˆìŠµë‹ˆë‹¤";
	}

	protected override string _GetTemplateForLabelSpanTitleLoading()
	{
		return "ë¡œë“œ ì¤‘...";
	}

	/// <summary>
	/// Key: "Label.TimestampOffUntilCertainTime"
	/// English String: "Off until {timestamp}"
	/// </summary>
	public override string LabelTimestampOffUntilCertainTime(string timestamp)
	{
		return $"{timestamp}ê¹Œì§€ ë„ê¸°";
	}

	protected override string _GetTemplateForLabelTimestampOffUntilCertainTime()
	{
		return "{timestamp}ê¹Œì§€ ë„ê¸°";
	}

	protected override string _GetTemplateForLabelTimestampOffUntilTomorrow()
	{
		return "ë‚´ì¼ê¹Œì§€ ë„ê¸°";
	}

	protected override string _GetTemplateForLabelTimestampOffUntilTurnedBackOn()
	{
		return "ë‹¤ì‹œ ì¼¤ ë•Œê¹Œì§€ ë„ê¸°\"";
	}

	protected override string _GetTemplateForLabelTurnOnConversationNotificationsPrompt()
	{
		return "ì•Œë¦¼ì„ ì¼¤ê¹Œìš”?";
	}

	protected override string _GetTemplateForLabelUnpinGameTooltip()
	{
		return "ê²Œìž„ í•€ í•´ì œí•˜ê¸°";
	}

	protected override string _GetTemplateForLabelViewDetailsButton()
	{
		return "ìžì„¸ížˆ ë³´ê¸°";
	}

	protected override string _GetTemplateForLabelViewProfile()
	{
		return "í”„ë¡œí•„ ë³´ê¸°";
	}

	protected override string _GetTemplateForLabelYesterday()
	{
		return "ì–´ì œ";
	}

	/// <summary>
	/// Key: "Message.ChatPrivacySetting"
	/// English String: "To chat with friends, turn on chat in your {frontLink}Privacy Settings{endLink}"
	/// </summary>
	public override string MessageChatPrivacySetting(string frontLink, string endLink)
	{
		return $"ì¹œêµ¬ì™€ ì´ì•¼ê¸°ë¥¼ ë‚˜ëˆ„ë ¤ë©´ {frontLink}ê°œì¸ì •ë³´ ì„¤ì •{endLink}ì—ì„œ ì±„íŒ…ì„ í™œì„±í™”í•˜ì„¸ìš”";
	}

	protected override string _GetTemplateForMessageChatPrivacySetting()
	{
		return "ì¹œêµ¬ì™€ ì´ì•¼ê¸°ë¥¼ ë‚˜ëˆ„ë ¤ë©´ {frontLink}ê°œì¸ì •ë³´ ì„¤ì •{endLink}ì—ì„œ ì±„íŒ…ì„ í™œì„±í™”í•˜ì„¸ìš”";
	}

	/// <summary>
	/// Key: "Message.conversationTitleChangedText"
	/// English String: "{userName} named the chat group: {groupName}"
	/// </summary>
	public override string MessageconversationTitleChangedText(string userName, string groupName)
	{
		return $"{userName}ë‹˜ì´ ì„¤ì •í•œ ì±„íŒ…ê·¸ë£¹ ì´ë¦„: {groupName}";
	}

	protected override string _GetTemplateForMessageconversationTitleChangedText()
	{
		return "{userName}ë‹˜ì´ ì„¤ì •í•œ ì±„íŒ…ê·¸ë£¹ ì´ë¦„: {groupName}";
	}

	protected override string _GetTemplateForMessageConversationTitleModerated()
	{
		return "ì±„íŒ…ê·¸ë£¹ ì´ë¦„ì´ ê²€ì—´ì„ í†µê³¼í•˜ì§€ ëª»í–ˆìŠµë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForMessageDefault()
	{
		return "ì±„íŒ… ì°¸ê°€ìž ì¤‘ ì¼ë¶€ëŠ” íšŒì›ë‹˜ì˜ ë©”ì‹œì§€ë¥¼ ë³¼ ìˆ˜ ì—†ì–´ìš”.";
	}

	protected override string _GetTemplateForMessageDefaultErrorMsg()
	{
		return "ì˜¤ë¥˜ê°€ ë°œìƒí–ˆì–´ìš”";
	}

	/// <summary>
	/// Key: "Message.DefaultTitleForMsg"
	/// English String: "{userName} says ..."
	/// </summary>
	public override string MessageDefaultTitleForMsg(string userName)
	{
		return $"{userName}ë‹˜ì˜ ë§:";
	}

	protected override string _GetTemplateForMessageDefaultTitleForMsg()
	{
		return "{userName}ë‹˜ì˜ ë§:";
	}

	/// <summary>
	/// Key: "Message.DefaultTitleForPartyInvite"
	/// English String: "Party invite from {userName}"
	/// </summary>
	public override string MessageDefaultTitleForPartyInvite(string userName)
	{
		return $"{userName}ë‹˜ì´ íŒŒí‹°ì— ì´ˆëŒ€í–ˆì–´ìš”";
	}

	protected override string _GetTemplateForMessageDefaultTitleForPartyInvite()
	{
		return "{userName}ë‹˜ì´ íŒŒí‹°ì— ì´ˆëŒ€í–ˆì–´ìš”";
	}

	protected override string _GetTemplateForMessageError()
	{
		return "ì˜¤ë¥˜";
	}

	/// <summary>
	/// Key: "Message.FindGameToPlay"
	/// English String: "{frontLink}Find Games{endLink} to play with your friends!"
	/// </summary>
	public override string MessageFindGameToPlay(string frontLink, string endLink)
	{
		return $"{frontLink}ê²Œìž„ ê²€ìƒ‰{endLink}ì„ í†µí•´ ì¹œêµ¬ì™€ ì¦ê¸¸ ê²Œìž„ì„ ì°¾ì•„ë³´ì„¸ìš”!";
	}

	protected override string _GetTemplateForMessageFindGameToPlay()
	{
		return "{frontLink}ê²Œìž„ ê²€ìƒ‰{endLink}ì„ í†µí•´ ì¹œêµ¬ì™€ ì¦ê¸¸ ê²Œìž„ì„ ì°¾ì•„ë³´ì„¸ìš”!";
	}

	protected override string _GetTemplateForMessageJoinPartyText()
	{
		return "íŒŒí‹°ìž¥ì´ í”Œë ˆì´í•  ê²Œìž„ì„ ì°¾ê³  ìžˆì–´ìš”.";
	}

	protected override string _GetTemplateForMessageMakeFriendsToChatNPlay()
	{
		return "ì±„íŒ…ê³¼ íŒŒí‹° í™œë™ì„ ì‹œìž‘í•˜ë ¤ë©´ ì¹œêµ¬ë¥¼ ë§Œë“œì„¸ìš”!";
	}

	protected override string _GetTemplateForMessageMessageContentModerated()
	{
		return "ë©”ì‹œì§€ê°€ ê²€ì—´ì„ í†µê³¼í•˜ì§€ ëª»í•´ ì „ì†¡ë˜ì§€ ì•Šì•˜ì–´ìš”.";
	}

	protected override string _GetTemplateForMessageMessageFilterForReceivers()
	{
		return "ì±„íŒ… ì°¸ê°€ìž ì¤‘ ì¼ë¶€ëŠ” íšŒì›ë‹˜ì˜ ë©”ì‹œì§€ë¥¼ ë³¼ ìˆ˜ ì—†ì–´ìš”.";
	}

	protected override string _GetTemplateForMessageNoConnectionMsg()
	{
		return "ì—°ê²° ì¤‘...";
	}

	protected override string _GetTemplateForMessagePartyInviteMsg()
	{
		return "íŒŒí‹° ì´ˆëŒ€!";
	}

	/// <summary>
	/// Key: "Message.PinGameUpdate"
	/// users pinned game in conversation
	/// English String: "{userName} chose a game to play together: {gameName}"
	/// </summary>
	public override string MessagePinGameUpdate(string userName, string gameName)
	{
		return $"{userName}ë‹˜ì´ í•¨ê»˜ í”Œë ˆì´í•˜ê¸° ìœ„í•´ ì„ íƒí•œ ê²Œìž„: {gameName}";
	}

	protected override string _GetTemplateForMessagePinGameUpdate()
	{
		return "{userName}ë‹˜ì´ í•¨ê»˜ í”Œë ˆì´í•˜ê¸° ìœ„í•´ ì„ íƒí•œ ê²Œìž„: {gameName}";
	}

	protected override string _GetTemplateForMessagePlayGameUpdate()
	{
		return " ë‹˜ì´ í•€í•œ ê²Œìž„ í”Œë ˆì´ ì¤‘: ";
	}

	protected override string _GetTemplateForMessageTextTooLong()
	{
		return "ë©”ì‹œì§€ê°€ ë„ˆë¬´ ê¸¸ì–´ì„œ ì „ì†¡ë˜ì§€ ì•Šì•˜ì–´ìš”.";
	}

	/// <summary>
	/// Key: "Message.ToastText"
	/// English String: "You can have up to {friendNum} friends in chat group."
	/// </summary>
	public override string MessageToastText(string friendNum)
	{
		return $"ì±„íŒ…ê·¸ë£¹ ìµœëŒ€ ì •ì›ì€ {friendNum}ëª…ìž…ë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForMessageToastText()
	{
		return "ì±„íŒ…ê·¸ë£¹ ìµœëŒ€ ì •ì›ì€ {friendNum}ëª…ìž…ë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForMessageUnknownMessageType()
	{
		return "ë©”ì‹œì§€ë¥¼ í‘œì‹œí•  ìˆ˜ ì—†ìŒ";
	}

	protected override string _GetTemplateForPlayButton()
	{
		return "í”Œë ˆì´";
	}

	protected override string _GetTemplateForResponsePartyInvite()
	{
		return "íŒŒí‹° ì´ˆëŒ€ë¥¼ ë°›ì•˜ì–´ìš”.";
	}
}


}
