namespace Roblox.TranslationResources.Feature;

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
	public override string ActionAdd => "新增";

	/// <summary>
	/// Key: "Action.BuyAccess"
	/// English String: "Buy Access"
	/// </summary>
	public override string ActionBuyAccess => "購買通行權";

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "取消";

	/// <summary>
	/// Key: "Action.Create"
	/// English String: "Create"
	/// </summary>
	public override string ActionCreate => "建立";

	/// <summary>
	/// Key: "Action.Join"
	/// join the voice chat conversation
	/// English String: "Join"
	/// </summary>
	public override string ActionJoin => "加入";

	/// <summary>
	/// Key: "Action.JoinVoice"
	/// Join voice call
	/// English String: "Join"
	/// </summary>
	public override string ActionJoinVoice => "加入";

	/// <summary>
	/// Key: "Action.Leave"
	/// English String: "Leave"
	/// </summary>
	public override string ActionLeave => "離開";

	/// <summary>
	/// Key: "Action.LeaveVoice"
	/// Leave voice chat
	/// English String: "Leave"
	/// </summary>
	public override string ActionLeaveVoice => "離開";

	/// <summary>
	/// Key: "Action.Mute"
	/// mute microphone in short term
	/// English String: "Mute"
	/// </summary>
	public override string ActionMute => "靜音";

	/// <summary>
	/// Key: "Action.MuteMic"
	/// English String: "Mute Your Microphone"
	/// </summary>
	public override string ActionMuteMic => "靜音麥克風";

	/// <summary>
	/// Key: "Action.Remove"
	/// English String: "Remove"
	/// </summary>
	public override string ActionRemove => "移除";

	/// <summary>
	/// Key: "Action.Report"
	/// English String: "Report"
	/// </summary>
	public override string ActionReport => "檢舉";

	/// <summary>
	/// Key: "Action.Save"
	/// English String: "Save"
	/// </summary>
	public override string ActionSave => "儲存";

	/// <summary>
	/// Key: "Action.Send"
	/// English String: "Send"
	/// </summary>
	public override string ActionSend => "傳送";

	/// <summary>
	/// Key: "Action.Set"
	/// English String: "Set"
	/// </summary>
	public override string ActionSet => "設定";

	/// <summary>
	/// Key: "Action.StartParty"
	/// button label
	/// English String: "Start a Party"
	/// </summary>
	public override string ActionStartParty => "建立隊伍";

	/// <summary>
	/// Key: "Action.Stay"
	/// English String: "Stay"
	/// </summary>
	public override string ActionStay => "取消";

	/// <summary>
	/// Key: "Action.TurnOn"
	/// English String: "Turn On"
	/// </summary>
	public override string ActionTurnOn => "開啟";

	/// <summary>
	/// Key: "Action.Unmute"
	/// unmute mic in short term
	/// English String: "Unmute"
	/// </summary>
	public override string ActionUnmute => "解除靜音";

	/// <summary>
	/// Key: "Action.UnmuteMic"
	/// English String: "Unmute Your Microphone"
	/// </summary>
	public override string ActionUnmuteMic => "解除靜音麥克風";

	/// <summary>
	/// Key: "Description.JoinInVoiceChat"
	/// English String: "Click Join to join the call"
	/// </summary>
	public override string DescriptionJoinInVoiceChat => "按下「加入」加入語音通話";

	/// <summary>
	/// Key: "Description.LeaveVoiceChat"
	/// English String: "Click Leave to leave the call"
	/// </summary>
	public override string DescriptionLeaveVoiceChat => "按下「離開」離開語音通話";

	/// <summary>
	/// Key: "Description.UserInVoice"
	/// User is actively in voice chat
	/// English String: "You are in the voice chat"
	/// </summary>
	public override string DescriptionUserInVoice => "您在語音通話裡";

	/// <summary>
	/// Key: "Description.VoiceNotConnect"
	/// Error handling message when voice chat api return errors
	/// English String: "Could not connect to voice chat"
	/// </summary>
	public override string DescriptionVoiceNotConnect => "無法連線到語音通話";

	/// <summary>
	/// Key: "Heading.BuyItem"
	/// English String: "Buy Item"
	/// </summary>
	public override string HeadingBuyItem => "購買道具";

	/// <summary>
	/// Key: "Heading.Chat"
	/// English String: "Chat"
	/// </summary>
	public override string HeadingChat => "聊天";

	public override string HeadingChatAndParty => "聊天與隊伍";

	/// <summary>
	/// Key: "Heading.ConfirmLeaving"
	/// English String: "Are you sure to leave this chat group?"
	/// </summary>
	public override string HeadingConfirmLeaving => "確定離開此群組？";

	/// <summary>
	/// Key: "Heading.ContinueToReport"
	/// English String: "Continue to report?"
	/// </summary>
	public override string HeadingContinueToReport => "檢舉此玩家？";

	/// <summary>
	/// Key: "Heading.CreateParty"
	/// English String: "Create Party"
	/// </summary>
	public override string HeadingCreateParty => "建立隊伍";

	/// <summary>
	/// Key: "Heading.LeaveChatGroup"
	/// English String: "Leave Chat Group"
	/// </summary>
	public override string HeadingLeaveChatGroup => "離開群組";

	/// <summary>
	/// Key: "Heading.LeaveChatGroupQ"
	/// English String: "Leave Chat Group?"
	/// </summary>
	public override string HeadingLeaveChatGroupQ => "離開群組？";

	/// <summary>
	/// Key: "Heading.NewChatGroup"
	/// English String: "New Chat Group"
	/// </summary>
	public override string HeadingNewChatGroup => "新增群組";

	/// <summary>
	/// Key: "Heading.RemoveUser"
	/// English String: "Remove User?"
	/// </summary>
	public override string HeadingRemoveUser => "移除使用者？";

	/// <summary>
	/// Key: "Heading.Report"
	/// heading for abuse report dialog
	/// English String: "Report"
	/// </summary>
	public override string HeadingReport => "檢舉";

	/// <summary>
	/// Key: "Label.AddFriends"
	/// English String: "Add Friends"
	/// </summary>
	public override string LabelAddFriends => "新增好友";

	/// <summary>
	/// Key: "Label.BuyButton"
	/// English String: "Buy"
	/// </summary>
	public override string LabelBuyButton => "購買";

	/// <summary>
	/// Key: "Label.ChangeChatGroupName"
	/// English String: "Change your chat group name"
	/// </summary>
	public override string LabelChangeChatGroupName => "變更群組名稱";

	/// <summary>
	/// Key: "Label.ChatDetails"
	/// English String: "Chat Details"
	/// </summary>
	public override string LabelChatDetails => "聊天室資料";

	/// <summary>
	/// Key: "Label.ChatGroupName"
	/// English String: "Chat Group Name"
	/// </summary>
	public override string LabelChatGroupName => "群組名稱";

	/// <summary>
	/// Key: "Label.Close"
	/// English String: "Close"
	/// </summary>
	public override string LabelClose => "關閉";

	/// <summary>
	/// Key: "Label.ConversationNotifications"
	/// conversation notification
	/// English String: "Notifications"
	/// </summary>
	public override string LabelConversationNotifications => "通知";

	/// <summary>
	/// Key: "Label.ConversationNotificationsOn"
	/// conversation notification is on
	/// English String: "On"
	/// </summary>
	public override string LabelConversationNotificationsOn => "開啟";

	/// <summary>
	/// Key: "Label.Details.PlayTogether"
	/// English String: "PlayTogether"
	/// </summary>
	public override string LabelDetailsPlayTogether => "一起玩";

	/// <summary>
	/// Key: "Label.FindGame"
	/// English String: "Find Game"
	/// </summary>
	public override string LabelFindGame => "尋找遊戲";

	/// <summary>
	/// Key: "Label.GameNotAvailableButton"
	/// English String: "Not Available"
	/// </summary>
	public override string LabelGameNotAvailableButton => "無法使用";

	/// <summary>
	/// Key: "Label.General"
	/// English String: "General"
	/// </summary>
	public override string LabelGeneral => "一般";

	/// <summary>
	/// Key: "Label.InCall"
	/// In voice call
	/// English String: "In Call"
	/// </summary>
	public override string LabelInCall => "通話中";

	/// <summary>
	/// Key: "Label.InGame"
	/// English String: "In Game"
	/// </summary>
	public override string LabelInGame => "遊戲中";

	/// <summary>
	/// Key: "Label.InputPlaceHolder.SearchForFriends"
	/// English String: "Search for friends"
	/// </summary>
	public override string LabelInputPlaceHolderSearchForFriends => "搜尋好友";

	/// <summary>
	/// Key: "Label.InputPlaceHolder.SendMessage"
	/// English String: "Send a message"
	/// </summary>
	public override string LabelInputPlaceHolderSendMessage => "傳送訊息";

	/// <summary>
	/// Key: "Label.InStudio"
	/// English String: "In Studio"
	/// </summary>
	public override string LabelInStudio => "在 Studio 中";

	/// <summary>
	/// Key: "Label.JoinButton"
	/// English String: "Join"
	/// </summary>
	public override string LabelJoinButton => "加入";

	/// <summary>
	/// Key: "Label.JoinGame"
	/// English String: "Join Game"
	/// </summary>
	public override string LabelJoinGame => "加入遊戲";

	/// <summary>
	/// Key: "Label.JoinParty"
	/// English String: "Join Party"
	/// </summary>
	public override string LabelJoinParty => "加入隊伍";

	/// <summary>
	/// Key: "Label.LeaveChatGroup"
	/// English String: "Leave Chat Group"
	/// </summary>
	public override string LabelLeaveChatGroup => "離開群組";

	/// <summary>
	/// Key: "Label.LeaveParty"
	/// English String: "Leave Party"
	/// </summary>
	public override string LabelLeaveParty => "離開隊伍";

	/// <summary>
	/// Key: "Label.Member"
	/// English String: "Member"
	/// </summary>
	public override string LabelMember => "成員";

	/// <summary>
	/// Key: "Label.Members"
	/// English String: "Members"
	/// </summary>
	public override string LabelMembers => "成員";

	/// <summary>
	/// Key: "Label.Mute15Minutes"
	/// mute conversation for 15 mins
	/// English String: "For 15 minutes"
	/// </summary>
	public override string LabelMute15Minutes => "開啟 15 分鐘";

	/// <summary>
	/// Key: "Label.Mute1Hour"
	/// Mute conversation for 1 hour
	/// English String: "For an hour"
	/// </summary>
	public override string LabelMute1Hour => "開啟 1 小時";

	/// <summary>
	/// Key: "Label.Mute24Hours"
	/// Mute conversation for a day
	/// English String: "For a day"
	/// </summary>
	public override string LabelMute24Hours => "開啟 1 天";

	/// <summary>
	/// Key: "Label.Mute8Hours"
	/// Mute conversation for 8 hours
	/// English String: "For 8 hours"
	/// </summary>
	public override string LabelMute8Hours => "開啟 8 小時";

	/// <summary>
	/// Key: "Label.MuteConversationNotificationsForGroup"
	/// English String: "Mute notifications for this chat group"
	/// </summary>
	public override string LabelMuteConversationNotificationsForGroup => "將此群組的通知靜音";

	/// <summary>
	/// Key: "Label.MuteConversationNotificationsForOneToOne"
	/// English String: "Mute notifications for this conversation"
	/// </summary>
	public override string LabelMuteConversationNotificationsForOneToOne => "將此對話的通知靜音";

	/// <summary>
	/// Key: "Label.MuteInfinite"
	/// Mute conversation until user turns back
	/// English String: "Until I turn them back on"
	/// </summary>
	public override string LabelMuteInfinite => "直到我重新開啟為止";

	/// <summary>
	/// Key: "Label.NameYourChangeGroup"
	/// English String: "Name your change group"
	/// </summary>
	public override string LabelNameYourChangeGroup => "命名群組";

	/// <summary>
	/// Key: "Label.NameYourChatGroup"
	/// English String: "Name your chat group"
	/// </summary>
	public override string LabelNameYourChatGroup => "命名群組";

	/// <summary>
	/// Key: "Label.NotImplementedMessageType"
	/// This message is displayed in chat when user receives message type that can't be rendered by current app version and update is not available, yet (e.g. latest version was rolled back, or in deprecated Android native chat)
	/// English String: "This message could not be displayed."
	/// </summary>
	public override string LabelNotImplementedMessageType => "無法顯示此訊息。";

	/// <summary>
	/// Key: "Label.NotInCall"
	/// English String: "Not in call"
	/// </summary>
	public override string LabelNotInCall => "未加入通話";

	/// <summary>
	/// Key: "Label.Offline"
	/// English String: "Offline"
	/// </summary>
	public override string LabelOffline => "離線";

	/// <summary>
	/// Key: "Label.Online"
	/// English String: "Online"
	/// </summary>
	public override string LabelOnline => "在線";

	/// <summary>
	/// Key: "Label.PinGameTooltip"
	/// English String: "Pin Game"
	/// </summary>
	public override string LabelPinGameTooltip => "置頂遊戲";

	/// <summary>
	/// Key: "Label.PinnedGame"
	/// This is a title of card, means this game card is pinned game
	/// English String: "Pinned Game"
	/// </summary>
	public override string LabelPinnedGame => "已置頂的遊戲";

	/// <summary>
	/// Key: "Label.PlayButton"
	/// English String: "Play"
	/// </summary>
	public override string LabelPlayButton => "開始遊戲";

	/// <summary>
	/// Key: "Label.PlayGames"
	/// English String: "Play Games"
	/// </summary>
	public override string LabelPlayGames => "玩遊戲";

	/// <summary>
	/// Key: "Label.PlayTogether"
	/// English String: "Play Together"
	/// </summary>
	public override string LabelPlayTogether => "一起玩";

	/// <summary>
	/// Key: "Label.RecommendedGames"
	/// English String: "Recommended"
	/// </summary>
	public override string LabelRecommendedGames => "推薦";

	/// <summary>
	/// Key: "Label.SeeLess"
	/// English String: "See Less"
	/// </summary>
	public override string LabelSeeLess => "簡閱";

	/// <summary>
	/// Key: "Label.SeeMore"
	/// English String: "See More"
	/// </summary>
	public override string LabelSeeMore => "查看更多";

	/// <summary>
	/// Key: "Label.ShowLessGames"
	/// English String: "Show Less"
	/// </summary>
	public override string LabelShowLessGames => "顯示更少";

	/// <summary>
	/// Key: "Label.SpanTitle.CreateGroupNeeds2More"
	/// English String: "Add at least 2 people to create chat group"
	/// </summary>
	public override string LabelSpanTitleCreateGroupNeeds2More => "加入至少 2 位好友，即可建立聊天群組";

	/// <summary>
	/// Key: "Label.SpanTitle.Loading"
	/// English String: "loading ..."
	/// </summary>
	public override string LabelSpanTitleLoading => "正在載入...";

	/// <summary>
	/// Key: "Label.TimestampOffUntilTomorrow"
	/// English String: "Off until tomorrow"
	/// </summary>
	public override string LabelTimestampOffUntilTomorrow => "關閉到明天為止";

	/// <summary>
	/// Key: "Label.TimestampOffUntilTurnedBackOn"
	/// English String: "Off until turned back on\""
	/// </summary>
	public override string LabelTimestampOffUntilTurnedBackOn => "關閉到重新開啟為止";

	/// <summary>
	/// Key: "Label.TurnOnConversationNotificationsPrompt"
	/// English String: "Do you want to turn on notifications?"
	/// </summary>
	public override string LabelTurnOnConversationNotificationsPrompt => "您要開啟通知功能嗎？";

	/// <summary>
	/// Key: "Label.UnpinGameTooltip"
	/// English String: "Unpin Game"
	/// </summary>
	public override string LabelUnpinGameTooltip => "取消置頂遊戲";

	/// <summary>
	/// Key: "Label.ViewDetailsButton"
	/// English String: "View Details"
	/// </summary>
	public override string LabelViewDetailsButton => "檢視詳細資料";

	/// <summary>
	/// Key: "Label.ViewProfile"
	/// English String: "View Profile"
	/// </summary>
	public override string LabelViewProfile => "檢視個人檔案";

	/// <summary>
	/// Key: "Label.VoiceSetting"
	/// Voice chat setting label
	/// English String: "Voice Settings"
	/// </summary>
	public override string LabelVoiceSetting => "語音設定";

	/// <summary>
	/// Key: "Label.Yesterday"
	/// time stamp for chat message received yesterday
	/// English String: "Yesterday"
	/// </summary>
	public override string LabelYesterday => "昨天";

	/// <summary>
	/// Key: "Message.ConversationTitleModerated"
	/// Chat group name was moderated.
	/// English String: "Chat group name was moderated."
	/// </summary>
	public override string MessageConversationTitleModerated => "群組名稱遭到過濾。";

	/// <summary>
	/// Key: "Message.Default"
	/// English String: "Not everyone in this chat can see your message."
	/// </summary>
	public override string MessageDefault => "某些在此聊天室的使用者將看不到您的訊息。";

	/// <summary>
	/// Key: "Message.DefaultErrorMsg"
	/// English String: "An error occurred"
	/// </summary>
	public override string MessageDefaultErrorMsg => "發生錯誤";

	/// <summary>
	/// Key: "Message.Error"
	/// English String: "Error"
	/// </summary>
	public override string MessageError => "錯誤";

	/// <summary>
	/// Key: "Message.JoinPartyText"
	/// English String: "The party leader is finding a game to play."
	/// </summary>
	public override string MessageJoinPartyText => "隊長正在尋找遊戲。";

	/// <summary>
	/// Key: "Message.MakeFriendsToChatNPlay"
	/// English String: "Make friends to start chatting and partying!"
	/// </summary>
	public override string MessageMakeFriendsToChatNPlay => "結交好友，開始聊天玩耍！";

	/// <summary>
	/// Key: "Message.MessageContentModerated"
	/// English String: "Your message was moderated and not sent."
	/// </summary>
	public override string MessageMessageContentModerated => "您的訊息遭到過濾，無法傳送。";

	/// <summary>
	/// Key: "Message.MessageFilterForReceivers"
	/// English String: "Not everyone in this chat can see your message."
	/// </summary>
	public override string MessageMessageFilterForReceivers => "某些在此聊天室的使用者將看不到您的訊息。";

	/// <summary>
	/// Key: "Message.NoConnectionMsg"
	/// English String: "Connecting..."
	/// </summary>
	public override string MessageNoConnectionMsg => "正在連線…";

	/// <summary>
	/// Key: "Message.PartyInviteMsg"
	/// English String: "PARTY INVITE!"
	/// </summary>
	public override string MessagePartyInviteMsg => "聚會邀請！";

	/// <summary>
	/// Key: "Message.PlayGameUpdate"
	/// English String: " is playing the pinned game: "
	/// </summary>
	public override string MessagePlayGameUpdate => " 在玩置頂的遊戲： ";

	/// <summary>
	/// Key: "Message.TextTooLong"
	/// English String: "Your message was too long and not sent."
	/// </summary>
	public override string MessageTextTooLong => "您的訊息過長，無法傳送。";

	/// <summary>
	/// Key: "Message.UnknownMessageType"
	/// This serves as the fallback string for when an message type is received that the web chat does not know how to render.
	/// English String: "A message cannot be displayed"
	/// </summary>
	public override string MessageUnknownMessageType => "無法顯示訊息";

	/// <summary>
	/// Key: "PlayButton"
	/// English String: "Play"
	/// </summary>
	public override string PlayButton => "開始遊戲";

	/// <summary>
	/// Key: "Response.PartyInvite"
	/// notification message
	/// English String: "You received a party Invite."
	/// </summary>
	public override string ResponsePartyInvite => "您收到隊伍邀請。";

	public ChatResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAdd()
	{
		return "新增";
	}

	protected override string _GetTemplateForActionBuyAccess()
	{
		return "購買通行權";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "取消";
	}

	protected override string _GetTemplateForActionCreate()
	{
		return "建立";
	}

	protected override string _GetTemplateForActionJoin()
	{
		return "加入";
	}

	protected override string _GetTemplateForActionJoinVoice()
	{
		return "加入";
	}

	protected override string _GetTemplateForActionLeave()
	{
		return "離開";
	}

	protected override string _GetTemplateForActionLeaveVoice()
	{
		return "離開";
	}

	protected override string _GetTemplateForActionMute()
	{
		return "靜音";
	}

	protected override string _GetTemplateForActionMuteMic()
	{
		return "靜音麥克風";
	}

	protected override string _GetTemplateForActionRemove()
	{
		return "移除";
	}

	protected override string _GetTemplateForActionReport()
	{
		return "檢舉";
	}

	protected override string _GetTemplateForActionSave()
	{
		return "儲存";
	}

	protected override string _GetTemplateForActionSend()
	{
		return "傳送";
	}

	protected override string _GetTemplateForActionSet()
	{
		return "設定";
	}

	protected override string _GetTemplateForActionStartParty()
	{
		return "建立隊伍";
	}

	protected override string _GetTemplateForActionStay()
	{
		return "取消";
	}

	protected override string _GetTemplateForActionTurnOn()
	{
		return "開啟";
	}

	protected override string _GetTemplateForActionUnmute()
	{
		return "解除靜音";
	}

	protected override string _GetTemplateForActionUnmuteMic()
	{
		return "解除靜音麥克風";
	}

	protected override string _GetTemplateForDescriptionJoinInVoiceChat()
	{
		return "按下「加入」加入語音通話";
	}

	protected override string _GetTemplateForDescriptionLeaveVoiceChat()
	{
		return "按下「離開」離開語音通話";
	}

	protected override string _GetTemplateForDescriptionUserInVoice()
	{
		return "您在語音通話裡";
	}

	protected override string _GetTemplateForDescriptionVoiceNotConnect()
	{
		return "無法連線到語音通話";
	}

	protected override string _GetTemplateForHeadingBuyItem()
	{
		return "購買道具";
	}

	protected override string _GetTemplateForHeadingChat()
	{
		return "聊天";
	}

	protected override string _GetTemplateForHeadingChatAndParty()
	{
		return "聊天與隊伍";
	}

	protected override string _GetTemplateForHeadingConfirmLeaving()
	{
		return "確定離開此群組？";
	}

	protected override string _GetTemplateForHeadingContinueToReport()
	{
		return "檢舉此玩家？";
	}

	protected override string _GetTemplateForHeadingCreateParty()
	{
		return "建立隊伍";
	}

	protected override string _GetTemplateForHeadingLeaveChatGroup()
	{
		return "離開群組";
	}

	protected override string _GetTemplateForHeadingLeaveChatGroupQ()
	{
		return "離開群組？";
	}

	protected override string _GetTemplateForHeadingNewChatGroup()
	{
		return "新增群組";
	}

	protected override string _GetTemplateForHeadingRemoveUser()
	{
		return "移除使用者？";
	}

	protected override string _GetTemplateForHeadingReport()
	{
		return "檢舉";
	}

	protected override string _GetTemplateForLabelAddFriends()
	{
		return "新增好友";
	}

	/// <summary>
	/// Key: "Label.BuyAccessToGameForModal"
	/// English String: "Would you like to buy access to the Place: {placeName} from {creatorName} for {robux}?"
	/// </summary>
	public override string LabelBuyAccessToGameForModal(string placeName, string creatorName, string robux)
	{
		return $"您要以 {robux} 向 {creatorName} 購買 {placeName} 的空間通行權嗎？";
	}

	protected override string _GetTemplateForLabelBuyAccessToGameForModal()
	{
		return "您要以 {robux} 向 {creatorName} 購買 {placeName} 的空間通行權嗎？";
	}

	protected override string _GetTemplateForLabelBuyButton()
	{
		return "購買";
	}

	protected override string _GetTemplateForLabelChangeChatGroupName()
	{
		return "變更群組名稱";
	}

	protected override string _GetTemplateForLabelChatDetails()
	{
		return "聊天室資料";
	}

	protected override string _GetTemplateForLabelChatGroupName()
	{
		return "群組名稱";
	}

	protected override string _GetTemplateForLabelClose()
	{
		return "關閉";
	}

	protected override string _GetTemplateForLabelConversationNotifications()
	{
		return "通知";
	}

	protected override string _GetTemplateForLabelConversationNotificationsOn()
	{
		return "開啟";
	}

	protected override string _GetTemplateForLabelDetailsPlayTogether()
	{
		return "一起玩";
	}

	protected override string _GetTemplateForLabelFindGame()
	{
		return "尋找遊戲";
	}

	protected override string _GetTemplateForLabelGameNotAvailableButton()
	{
		return "無法使用";
	}

	protected override string _GetTemplateForLabelGeneral()
	{
		return "一般";
	}

	protected override string _GetTemplateForLabelInCall()
	{
		return "通話中";
	}

	protected override string _GetTemplateForLabelInGame()
	{
		return "遊戲中";
	}

	protected override string _GetTemplateForLabelInputPlaceHolderSearchForFriends()
	{
		return "搜尋好友";
	}

	protected override string _GetTemplateForLabelInputPlaceHolderSendMessage()
	{
		return "傳送訊息";
	}

	protected override string _GetTemplateForLabelInStudio()
	{
		return "在 Studio 中";
	}

	protected override string _GetTemplateForLabelJoinButton()
	{
		return "加入";
	}

	protected override string _GetTemplateForLabelJoinGame()
	{
		return "加入遊戲";
	}

	protected override string _GetTemplateForLabelJoinParty()
	{
		return "加入隊伍";
	}

	protected override string _GetTemplateForLabelLeaveChatGroup()
	{
		return "離開群組";
	}

	protected override string _GetTemplateForLabelLeaveParty()
	{
		return "離開隊伍";
	}

	protected override string _GetTemplateForLabelMember()
	{
		return "成員";
	}

	/// <summary>
	/// Key: "Label.MemberJoinText"
	/// English String: "{userName} joined the party"
	/// </summary>
	public override string LabelMemberJoinText(string userName)
	{
		return $"{userName} 已加入隊伍";
	}

	protected override string _GetTemplateForLabelMemberJoinText()
	{
		return "{userName} 已加入隊伍";
	}

	protected override string _GetTemplateForLabelMembers()
	{
		return "成員";
	}

	protected override string _GetTemplateForLabelMute15Minutes()
	{
		return "開啟 15 分鐘";
	}

	protected override string _GetTemplateForLabelMute1Hour()
	{
		return "開啟 1 小時";
	}

	protected override string _GetTemplateForLabelMute24Hours()
	{
		return "開啟 1 天";
	}

	protected override string _GetTemplateForLabelMute8Hours()
	{
		return "開啟 8 小時";
	}

	protected override string _GetTemplateForLabelMuteConversationNotificationsForGroup()
	{
		return "將此群組的通知靜音";
	}

	protected override string _GetTemplateForLabelMuteConversationNotificationsForOneToOne()
	{
		return "將此對話的通知靜音";
	}

	protected override string _GetTemplateForLabelMuteInfinite()
	{
		return "直到我重新開啟為止";
	}

	protected override string _GetTemplateForLabelNameYourChangeGroup()
	{
		return "命名群組";
	}

	protected override string _GetTemplateForLabelNameYourChatGroup()
	{
		return "命名群組";
	}

	protected override string _GetTemplateForLabelNotImplementedMessageType()
	{
		return "無法顯示此訊息。";
	}

	protected override string _GetTemplateForLabelNotInCall()
	{
		return "未加入通話";
	}

	protected override string _GetTemplateForLabelOffline()
	{
		return "離線";
	}

	protected override string _GetTemplateForLabelOnline()
	{
		return "在線";
	}

	/// <summary>
	/// Key: "Label.PartyLeaderTooltip"
	/// English String: "{userName} is the party leader"
	/// </summary>
	public override string LabelPartyLeaderTooltip(string userName)
	{
		return $"{userName} 是隊長";
	}

	protected override string _GetTemplateForLabelPartyLeaderTooltip()
	{
		return "{userName} 是隊長";
	}

	/// <summary>
	/// Key: "Label.PartyMemberTooltip"
	/// English String: "{userName} is in the party"
	/// </summary>
	public override string LabelPartyMemberTooltip(string userName)
	{
		return $"{userName} 在隊伍中";
	}

	protected override string _GetTemplateForLabelPartyMemberTooltip()
	{
		return "{userName} 在隊伍中";
	}

	/// <summary>
	/// Key: "Label.PartyName"
	/// English String: "Party : {title}"
	/// </summary>
	public override string LabelPartyName(string title)
	{
		return $"隊伍：{title}";
	}

	protected override string _GetTemplateForLabelPartyName()
	{
		return "隊伍：{title}";
	}

	/// <summary>
	/// Key: "Label.PendingMemberTooltip"
	/// English String: "{userName} is not in the party"
	/// </summary>
	public override string LabelPendingMemberTooltip(string userName)
	{
		return $"{userName} 不在隊伍中";
	}

	protected override string _GetTemplateForLabelPendingMemberTooltip()
	{
		return "{userName} 不在隊伍中";
	}

	protected override string _GetTemplateForLabelPinGameTooltip()
	{
		return "置頂遊戲";
	}

	protected override string _GetTemplateForLabelPinnedGame()
	{
		return "已置頂的遊戲";
	}

	protected override string _GetTemplateForLabelPlayButton()
	{
		return "開始遊戲";
	}

	protected override string _GetTemplateForLabelPlayGames()
	{
		return "玩遊戲";
	}

	/// <summary>
	/// Key: "Label.PlayingGame"
	/// English String: "Playing {game}"
	/// </summary>
	public override string LabelPlayingGame(string game)
	{
		return $"正在玩 {game}";
	}

	protected override string _GetTemplateForLabelPlayingGame()
	{
		return "正在玩 {game}";
	}

	protected override string _GetTemplateForLabelPlayTogether()
	{
		return "一起玩";
	}

	protected override string _GetTemplateForLabelRecommendedGames()
	{
		return "推薦";
	}

	protected override string _GetTemplateForLabelSeeLess()
	{
		return "簡閱";
	}

	protected override string _GetTemplateForLabelSeeMore()
	{
		return "查看更多";
	}

	protected override string _GetTemplateForLabelShowLessGames()
	{
		return "顯示更少";
	}

	/// <summary>
	/// Key: "Label.ShowMoreGames"
	/// English String: "Show More (+{count})"
	/// </summary>
	public override string LabelShowMoreGames(string count)
	{
		return $"顯示更多（+{count}）";
	}

	protected override string _GetTemplateForLabelShowMoreGames()
	{
		return "顯示更多（+{count}）";
	}

	protected override string _GetTemplateForLabelSpanTitleCreateGroupNeeds2More()
	{
		return "加入至少 2 位好友，即可建立聊天群組";
	}

	protected override string _GetTemplateForLabelSpanTitleLoading()
	{
		return "正在載入...";
	}

	/// <summary>
	/// Key: "Label.TimestampOffUntilCertainTime"
	/// English String: "Off until {timestamp}"
	/// </summary>
	public override string LabelTimestampOffUntilCertainTime(string timestamp)
	{
		return $"關閉到 {timestamp} 為止";
	}

	protected override string _GetTemplateForLabelTimestampOffUntilCertainTime()
	{
		return "關閉到 {timestamp} 為止";
	}

	protected override string _GetTemplateForLabelTimestampOffUntilTomorrow()
	{
		return "關閉到明天為止";
	}

	protected override string _GetTemplateForLabelTimestampOffUntilTurnedBackOn()
	{
		return "關閉到重新開啟為止";
	}

	protected override string _GetTemplateForLabelTurnOnConversationNotificationsPrompt()
	{
		return "您要開啟通知功能嗎？";
	}

	protected override string _GetTemplateForLabelUnpinGameTooltip()
	{
		return "取消置頂遊戲";
	}

	protected override string _GetTemplateForLabelViewDetailsButton()
	{
		return "檢視詳細資料";
	}

	protected override string _GetTemplateForLabelViewProfile()
	{
		return "檢視個人檔案";
	}

	protected override string _GetTemplateForLabelVoiceSetting()
	{
		return "語音設定";
	}

	protected override string _GetTemplateForLabelYesterday()
	{
		return "昨天";
	}

	/// <summary>
	/// Key: "Message.ChatPrivacySetting"
	/// English String: "To chat with friends, turn on chat in your {frontLink}Privacy Settings{endLink}"
	/// </summary>
	public override string MessageChatPrivacySetting(string frontLink, string endLink)
	{
		return $"若要與好友聊天，請先在您的{frontLink}隱私權設定{endLink}中開啟聊天功能";
	}

	protected override string _GetTemplateForMessageChatPrivacySetting()
	{
		return "若要與好友聊天，請先在您的{frontLink}隱私權設定{endLink}中開啟聊天功能";
	}

	/// <summary>
	/// Key: "Message.conversationTitleChangedText"
	/// English String: "{userName} named the chat group: {groupName}"
	/// </summary>
	public override string MessageconversationTitleChangedText(string userName, string groupName)
	{
		return $"{userName} 將此群組命名為 {groupName}";
	}

	protected override string _GetTemplateForMessageconversationTitleChangedText()
	{
		return "{userName} 將此群組命名為 {groupName}";
	}

	protected override string _GetTemplateForMessageConversationTitleModerated()
	{
		return "群組名稱遭到過濾。";
	}

	protected override string _GetTemplateForMessageDefault()
	{
		return "某些在此聊天室的使用者將看不到您的訊息。";
	}

	protected override string _GetTemplateForMessageDefaultErrorMsg()
	{
		return "發生錯誤";
	}

	/// <summary>
	/// Key: "Message.DefaultTitleForMsg"
	/// English String: "{userName} says ..."
	/// </summary>
	public override string MessageDefaultTitleForMsg(string userName)
	{
		return $"{userName} 說…";
	}

	protected override string _GetTemplateForMessageDefaultTitleForMsg()
	{
		return "{userName} 說…";
	}

	/// <summary>
	/// Key: "Message.DefaultTitleForPartyInvite"
	/// English String: "Party invite from {userName}"
	/// </summary>
	public override string MessageDefaultTitleForPartyInvite(string userName)
	{
		return $"{userName} 的隊伍邀請";
	}

	protected override string _GetTemplateForMessageDefaultTitleForPartyInvite()
	{
		return "{userName} 的隊伍邀請";
	}

	protected override string _GetTemplateForMessageError()
	{
		return "錯誤";
	}

	/// <summary>
	/// Key: "Message.FindGameToPlay"
	/// English String: "{frontLink}Find Games{endLink} to play with your friends!"
	/// </summary>
	public override string MessageFindGameToPlay(string frontLink, string endLink)
	{
		return $"{frontLink}尋找遊戲{endLink}，與您的好友同樂！";
	}

	protected override string _GetTemplateForMessageFindGameToPlay()
	{
		return "{frontLink}尋找遊戲{endLink}，與您的好友同樂！";
	}

	protected override string _GetTemplateForMessageJoinPartyText()
	{
		return "隊長正在尋找遊戲。";
	}

	protected override string _GetTemplateForMessageMakeFriendsToChatNPlay()
	{
		return "結交好友，開始聊天玩耍！";
	}

	protected override string _GetTemplateForMessageMessageContentModerated()
	{
		return "您的訊息遭到過濾，無法傳送。";
	}

	protected override string _GetTemplateForMessageMessageFilterForReceivers()
	{
		return "某些在此聊天室的使用者將看不到您的訊息。";
	}

	protected override string _GetTemplateForMessageNoConnectionMsg()
	{
		return "正在連線…";
	}

	protected override string _GetTemplateForMessagePartyInviteMsg()
	{
		return "聚會邀請！";
	}

	/// <summary>
	/// Key: "Message.PinGameUpdate"
	/// users pinned game in conversation
	/// English String: "{userName} chose a game to play together: {gameName}"
	/// </summary>
	public override string MessagePinGameUpdate(string userName, string gameName)
	{
		return $"{userName} 選擇了一起玩的遊戲：{gameName}";
	}

	protected override string _GetTemplateForMessagePinGameUpdate()
	{
		return "{userName} 選擇了一起玩的遊戲：{gameName}";
	}

	protected override string _GetTemplateForMessagePlayGameUpdate()
	{
		return " 在玩置頂的遊戲： ";
	}

	protected override string _GetTemplateForMessageTextTooLong()
	{
		return "您的訊息過長，無法傳送。";
	}

	/// <summary>
	/// Key: "Message.ToastText"
	/// English String: "You can have up to {friendNum} friends in chat group."
	/// </summary>
	public override string MessageToastText(string friendNum)
	{
		return $"您的群組最多可以有 {friendNum} 位好友。";
	}

	protected override string _GetTemplateForMessageToastText()
	{
		return "您的群組最多可以有 {friendNum} 位好友。";
	}

	protected override string _GetTemplateForMessageUnknownMessageType()
	{
		return "無法顯示訊息";
	}

	protected override string _GetTemplateForPlayButton()
	{
		return "開始遊戲";
	}

	protected override string _GetTemplateForResponsePartyInvite()
	{
		return "您收到隊伍邀請。";
	}
}
