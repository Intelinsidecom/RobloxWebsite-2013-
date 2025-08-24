namespace Roblox.TranslationResources.Feature;

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
	public override string ActionAdd => "添加";

	/// <summary>
	/// Key: "Action.BuyAccess"
	/// English String: "Buy Access"
	/// </summary>
	public override string ActionBuyAccess => "购买通行证";

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "取消";

	/// <summary>
	/// Key: "Action.Create"
	/// English String: "Create"
	/// </summary>
	public override string ActionCreate => "创建";

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
	public override string ActionJoinVoice => "";

	/// <summary>
	/// Key: "Action.Leave"
	/// English String: "Leave"
	/// </summary>
	public override string ActionLeave => "离开";

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
	public override string ActionRemove => "移除";

	/// <summary>
	/// Key: "Action.Report"
	/// English String: "Report"
	/// </summary>
	public override string ActionReport => "举报";

	/// <summary>
	/// Key: "Action.Save"
	/// English String: "Save"
	/// </summary>
	public override string ActionSave => "保存";

	/// <summary>
	/// Key: "Action.Send"
	/// English String: "Send"
	/// </summary>
	public override string ActionSend => "发送";

	/// <summary>
	/// Key: "Action.Set"
	/// English String: "Set"
	/// </summary>
	public override string ActionSet => "设置";

	/// <summary>
	/// Key: "Action.StartParty"
	/// button label
	/// English String: "Start a Party"
	/// </summary>
	public override string ActionStartParty => "开始组队";

	/// <summary>
	/// Key: "Action.Stay"
	/// English String: "Stay"
	/// </summary>
	public override string ActionStay => "留下";

	/// <summary>
	/// Key: "Action.TurnOn"
	/// English String: "Turn On"
	/// </summary>
	public override string ActionTurnOn => "开启";

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
	public override string HeadingBuyItem => "购买物品";

	/// <summary>
	/// Key: "Heading.Chat"
	/// English String: "Chat"
	/// </summary>
	public override string HeadingChat => "聊天";

	public override string HeadingChatAndParty => "聊天与队伍";

	/// <summary>
	/// Key: "Heading.ConfirmLeaving"
	/// English String: "Are you sure to leave this chat group?"
	/// </summary>
	public override string HeadingConfirmLeaving => "是否确定离开此群聊？";

	/// <summary>
	/// Key: "Heading.ContinueToReport"
	/// English String: "Continue to report?"
	/// </summary>
	public override string HeadingContinueToReport => "继续举报？";

	/// <summary>
	/// Key: "Heading.CreateParty"
	/// English String: "Create Party"
	/// </summary>
	public override string HeadingCreateParty => "创建派对";

	/// <summary>
	/// Key: "Heading.LeaveChatGroup"
	/// English String: "Leave Chat Group"
	/// </summary>
	public override string HeadingLeaveChatGroup => "离开群聊";

	/// <summary>
	/// Key: "Heading.LeaveChatGroupQ"
	/// English String: "Leave Chat Group?"
	/// </summary>
	public override string HeadingLeaveChatGroupQ => "离开群聊？";

	/// <summary>
	/// Key: "Heading.NewChatGroup"
	/// English String: "New Chat Group"
	/// </summary>
	public override string HeadingNewChatGroup => "新群聊";

	/// <summary>
	/// Key: "Heading.RemoveUser"
	/// English String: "Remove User?"
	/// </summary>
	public override string HeadingRemoveUser => "移除用户？";

	/// <summary>
	/// Key: "Heading.Report"
	/// heading for abuse report dialog
	/// English String: "Report"
	/// </summary>
	public override string HeadingReport => "举报";

	/// <summary>
	/// Key: "Label.AddFriends"
	/// English String: "Add Friends"
	/// </summary>
	public override string LabelAddFriends => "添加好友";

	/// <summary>
	/// Key: "Label.BuyButton"
	/// English String: "Buy"
	/// </summary>
	public override string LabelBuyButton => "购买";

	/// <summary>
	/// Key: "Label.ChangeChatGroupName"
	/// English String: "Change your chat group name"
	/// </summary>
	public override string LabelChangeChatGroupName => "更改你的群聊名称";

	/// <summary>
	/// Key: "Label.ChatDetails"
	/// English String: "Chat Details"
	/// </summary>
	public override string LabelChatDetails => "聊天详情";

	/// <summary>
	/// Key: "Label.ChatGroupName"
	/// English String: "Chat Group Name"
	/// </summary>
	public override string LabelChatGroupName => "群聊名称";

	/// <summary>
	/// Key: "Label.Close"
	/// English String: "Close"
	/// </summary>
	public override string LabelClose => "关闭";

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
	public override string LabelConversationNotificationsOn => "开启";

	/// <summary>
	/// Key: "Label.Details.PlayTogether"
	/// English String: "PlayTogether"
	/// </summary>
	public override string LabelDetailsPlayTogether => "一起玩";

	/// <summary>
	/// Key: "Label.FindGame"
	/// English String: "Find Game"
	/// </summary>
	public override string LabelFindGame => "查找游戏";

	/// <summary>
	/// Key: "Label.GameNotAvailableButton"
	/// English String: "Not Available"
	/// </summary>
	public override string LabelGameNotAvailableButton => "不可用";

	/// <summary>
	/// Key: "Label.General"
	/// English String: "General"
	/// </summary>
	public override string LabelGeneral => "通用";

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
	public override string LabelInGame => "在游戏中";

	/// <summary>
	/// Key: "Label.InputPlaceHolder.SearchForFriends"
	/// English String: "Search for friends"
	/// </summary>
	public override string LabelInputPlaceHolderSearchForFriends => "搜索好友";

	/// <summary>
	/// Key: "Label.InputPlaceHolder.SendMessage"
	/// English String: "Send a message"
	/// </summary>
	public override string LabelInputPlaceHolderSendMessage => "发送信息";

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
	public override string LabelJoinGame => "加入游戏";

	/// <summary>
	/// Key: "Label.JoinParty"
	/// English String: "Join Party"
	/// </summary>
	public override string LabelJoinParty => "加入队伍";

	/// <summary>
	/// Key: "Label.LeaveChatGroup"
	/// English String: "Leave Chat Group"
	/// </summary>
	public override string LabelLeaveChatGroup => "离开群聊";

	/// <summary>
	/// Key: "Label.LeaveParty"
	/// English String: "Leave Party"
	/// </summary>
	public override string LabelLeaveParty => "离开队伍";

	/// <summary>
	/// Key: "Label.Member"
	/// English String: "Member"
	/// </summary>
	public override string LabelMember => "成员";

	/// <summary>
	/// Key: "Label.Members"
	/// English String: "Members"
	/// </summary>
	public override string LabelMembers => "成员";

	/// <summary>
	/// Key: "Label.Mute15Minutes"
	/// mute conversation for 15 mins
	/// English String: "For 15 minutes"
	/// </summary>
	public override string LabelMute15Minutes => "持续 15 分钟";

	/// <summary>
	/// Key: "Label.Mute1Hour"
	/// Mute conversation for 1 hour
	/// English String: "For an hour"
	/// </summary>
	public override string LabelMute1Hour => "持续一小时";

	/// <summary>
	/// Key: "Label.Mute24Hours"
	/// Mute conversation for a day
	/// English String: "For a day"
	/// </summary>
	public override string LabelMute24Hours => "持续一天";

	/// <summary>
	/// Key: "Label.Mute8Hours"
	/// Mute conversation for 8 hours
	/// English String: "For 8 hours"
	/// </summary>
	public override string LabelMute8Hours => "持续 8 小时";

	/// <summary>
	/// Key: "Label.MuteConversationNotificationsForGroup"
	/// English String: "Mute notifications for this chat group"
	/// </summary>
	public override string LabelMuteConversationNotificationsForGroup => "将此群聊的通知静音";

	/// <summary>
	/// Key: "Label.MuteConversationNotificationsForOneToOne"
	/// English String: "Mute notifications for this conversation"
	/// </summary>
	public override string LabelMuteConversationNotificationsForOneToOne => "将此对话的通知静音";

	/// <summary>
	/// Key: "Label.MuteInfinite"
	/// Mute conversation until user turns back
	/// English String: "Until I turn them back on"
	/// </summary>
	public override string LabelMuteInfinite => "直到我关闭静音为止";

	/// <summary>
	/// Key: "Label.NameYourChangeGroup"
	/// English String: "Name your change group"
	/// </summary>
	public override string LabelNameYourChangeGroup => "命名你的群聊";

	/// <summary>
	/// Key: "Label.NameYourChatGroup"
	/// English String: "Name your chat group"
	/// </summary>
	public override string LabelNameYourChatGroup => "命名你的群聊";

	/// <summary>
	/// Key: "Label.NotImplementedMessageType"
	/// This message is displayed in chat when user receives message type that can't be rendered by current app version and update is not available, yet (e.g. latest version was rolled back, or in deprecated Android native chat)
	/// English String: "This message could not be displayed."
	/// </summary>
	public override string LabelNotImplementedMessageType => "信息无法显示。";

	/// <summary>
	/// Key: "Label.NotInCall"
	/// English String: "Not in call"
	/// </summary>
	public override string LabelNotInCall => "";

	/// <summary>
	/// Key: "Label.Offline"
	/// English String: "Offline"
	/// </summary>
	public override string LabelOffline => "离线";

	/// <summary>
	/// Key: "Label.Online"
	/// English String: "Online"
	/// </summary>
	public override string LabelOnline => "在线";

	/// <summary>
	/// Key: "Label.PinGameTooltip"
	/// English String: "Pin Game"
	/// </summary>
	public override string LabelPinGameTooltip => "置顶游戏";

	/// <summary>
	/// Key: "Label.PinnedGame"
	/// This is a title of card, means this game card is pinned game
	/// English String: "Pinned Game"
	/// </summary>
	public override string LabelPinnedGame => "置顶游戏";

	/// <summary>
	/// Key: "Label.PlayButton"
	/// English String: "Play"
	/// </summary>
	public override string LabelPlayButton => "开始游戏";

	/// <summary>
	/// Key: "Label.PlayGames"
	/// English String: "Play Games"
	/// </summary>
	public override string LabelPlayGames => "开始游戏";

	/// <summary>
	/// Key: "Label.PlayTogether"
	/// English String: "Play Together"
	/// </summary>
	public override string LabelPlayTogether => "一起玩";

	/// <summary>
	/// Key: "Label.RecommendedGames"
	/// English String: "Recommended"
	/// </summary>
	public override string LabelRecommendedGames => "推荐";

	/// <summary>
	/// Key: "Label.SeeLess"
	/// English String: "See Less"
	/// </summary>
	public override string LabelSeeLess => "收起";

	/// <summary>
	/// Key: "Label.SeeMore"
	/// English String: "See More"
	/// </summary>
	public override string LabelSeeMore => "查看更多";

	/// <summary>
	/// Key: "Label.ShowLessGames"
	/// English String: "Show Less"
	/// </summary>
	public override string LabelShowLessGames => "收起";

	/// <summary>
	/// Key: "Label.SpanTitle.CreateGroupNeeds2More"
	/// English String: "Add at least 2 people to create chat group"
	/// </summary>
	public override string LabelSpanTitleCreateGroupNeeds2More => "添加至少 2 人以创建群聊";

	/// <summary>
	/// Key: "Label.SpanTitle.Loading"
	/// English String: "loading ..."
	/// </summary>
	public override string LabelSpanTitleLoading => "正在加载...";

	/// <summary>
	/// Key: "Label.TimestampOffUntilTomorrow"
	/// English String: "Off until tomorrow"
	/// </summary>
	public override string LabelTimestampOffUntilTomorrow => "到明天为止保持关闭";

	/// <summary>
	/// Key: "Label.TimestampOffUntilTurnedBackOn"
	/// English String: "Off until turned back on\""
	/// </summary>
	public override string LabelTimestampOffUntilTurnedBackOn => "直到重新开启一直保持关闭";

	/// <summary>
	/// Key: "Label.TurnOnConversationNotificationsPrompt"
	/// English String: "Do you want to turn on notifications?"
	/// </summary>
	public override string LabelTurnOnConversationNotificationsPrompt => "是否要开启通知功能？";

	/// <summary>
	/// Key: "Label.UnpinGameTooltip"
	/// English String: "Unpin Game"
	/// </summary>
	public override string LabelUnpinGameTooltip => "取消置顶游戏";

	/// <summary>
	/// Key: "Label.ViewDetailsButton"
	/// English String: "View Details"
	/// </summary>
	public override string LabelViewDetailsButton => "查看详情";

	/// <summary>
	/// Key: "Label.ViewProfile"
	/// English String: "View Profile"
	/// </summary>
	public override string LabelViewProfile => "查看个人资料";

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
	public override string LabelYesterday => "昨天";

	/// <summary>
	/// Key: "Message.ConversationTitleModerated"
	/// Chat group name was moderated.
	/// English String: "Chat group name was moderated."
	/// </summary>
	public override string MessageConversationTitleModerated => "群聊名称已被过滤。";

	/// <summary>
	/// Key: "Message.Default"
	/// English String: "Not everyone in this chat can see your message."
	/// </summary>
	public override string MessageDefault => "不是所有在此聊天中的人都能看到你的信息。";

	/// <summary>
	/// Key: "Message.DefaultErrorMsg"
	/// English String: "An error occurred"
	/// </summary>
	public override string MessageDefaultErrorMsg => "发生错误";

	/// <summary>
	/// Key: "Message.Error"
	/// English String: "Error"
	/// </summary>
	public override string MessageError => "错误";

	/// <summary>
	/// Key: "Message.JoinPartyText"
	/// English String: "The party leader is finding a game to play."
	/// </summary>
	public override string MessageJoinPartyText => "队长正在寻找一起玩的游戏。";

	/// <summary>
	/// Key: "Message.MakeFriendsToChatNPlay"
	/// English String: "Make friends to start chatting and partying!"
	/// </summary>
	public override string MessageMakeFriendsToChatNPlay => "结交好友，开始聊天玩耍！";

	/// <summary>
	/// Key: "Message.MessageContentModerated"
	/// English String: "Your message was moderated and not sent."
	/// </summary>
	public override string MessageMessageContentModerated => "你的信息已被过滤，未能发送。";

	/// <summary>
	/// Key: "Message.MessageFilterForReceivers"
	/// English String: "Not everyone in this chat can see your message."
	/// </summary>
	public override string MessageMessageFilterForReceivers => "不是所有在此聊天中的人都能看到你的信息。";

	/// <summary>
	/// Key: "Message.NoConnectionMsg"
	/// English String: "Connecting..."
	/// </summary>
	public override string MessageNoConnectionMsg => "正在连接...";

	/// <summary>
	/// Key: "Message.PartyInviteMsg"
	/// English String: "PARTY INVITE!"
	/// </summary>
	public override string MessagePartyInviteMsg => "队伍邀请！";

	/// <summary>
	/// Key: "Message.PlayGameUpdate"
	/// English String: " is playing the pinned game: "
	/// </summary>
	public override string MessagePlayGameUpdate => " 正在玩置顶游戏： ";

	/// <summary>
	/// Key: "Message.TextTooLong"
	/// English String: "Your message was too long and not sent."
	/// </summary>
	public override string MessageTextTooLong => "你的信息过长，未能发送。";

	/// <summary>
	/// Key: "Message.UnknownMessageType"
	/// This serves as the fallback string for when an message type is received that the web chat does not know how to render.
	/// English String: "A message cannot be displayed"
	/// </summary>
	public override string MessageUnknownMessageType => "信息无法显示";

	/// <summary>
	/// Key: "PlayButton"
	/// English String: "Play"
	/// </summary>
	public override string PlayButton => "开始游戏";

	/// <summary>
	/// Key: "Response.PartyInvite"
	/// notification message
	/// English String: "You received a party Invite."
	/// </summary>
	public override string ResponsePartyInvite => "你收到队伍邀请。";

	public ChatResources_zh_cjv(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAdd()
	{
		return "添加";
	}

	protected override string _GetTemplateForActionBuyAccess()
	{
		return "购买通行证";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "取消";
	}

	protected override string _GetTemplateForActionCreate()
	{
		return "创建";
	}

	protected override string _GetTemplateForActionJoin()
	{
		return "加入";
	}

	protected override string _GetTemplateForActionJoinVoice()
	{
		return "";
	}

	protected override string _GetTemplateForActionLeave()
	{
		return "离开";
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
		return "移除";
	}

	protected override string _GetTemplateForActionReport()
	{
		return "举报";
	}

	protected override string _GetTemplateForActionSave()
	{
		return "保存";
	}

	protected override string _GetTemplateForActionSend()
	{
		return "发送";
	}

	protected override string _GetTemplateForActionSet()
	{
		return "设置";
	}

	protected override string _GetTemplateForActionStartParty()
	{
		return "开始组队";
	}

	protected override string _GetTemplateForActionStay()
	{
		return "留下";
	}

	protected override string _GetTemplateForActionTurnOn()
	{
		return "开启";
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
		return "购买物品";
	}

	protected override string _GetTemplateForHeadingChat()
	{
		return "聊天";
	}

	protected override string _GetTemplateForHeadingChatAndParty()
	{
		return "聊天与队伍";
	}

	protected override string _GetTemplateForHeadingConfirmLeaving()
	{
		return "是否确定离开此群聊？";
	}

	protected override string _GetTemplateForHeadingContinueToReport()
	{
		return "继续举报？";
	}

	protected override string _GetTemplateForHeadingCreateParty()
	{
		return "创建派对";
	}

	protected override string _GetTemplateForHeadingLeaveChatGroup()
	{
		return "离开群聊";
	}

	protected override string _GetTemplateForHeadingLeaveChatGroupQ()
	{
		return "离开群聊？";
	}

	protected override string _GetTemplateForHeadingNewChatGroup()
	{
		return "新群聊";
	}

	protected override string _GetTemplateForHeadingRemoveUser()
	{
		return "移除用户？";
	}

	protected override string _GetTemplateForHeadingReport()
	{
		return "举报";
	}

	protected override string _GetTemplateForLabelAddFriends()
	{
		return "添加好友";
	}

	/// <summary>
	/// Key: "Label.BuyAccessToGameForModal"
	/// English String: "Would you like to buy access to the Place: {placeName} from {creatorName} for {robux}?"
	/// </summary>
	public override string LabelBuyAccessToGameForModal(string placeName, string creatorName, string robux)
	{
		return $"你是否要以 {robux} 的价格向“{creatorName}”购买场景“{placeName}”的通行证？";
	}

	protected override string _GetTemplateForLabelBuyAccessToGameForModal()
	{
		return "你是否要以 {robux} 的价格向“{creatorName}”购买场景“{placeName}”的通行证？";
	}

	protected override string _GetTemplateForLabelBuyButton()
	{
		return "购买";
	}

	protected override string _GetTemplateForLabelChangeChatGroupName()
	{
		return "更改你的群聊名称";
	}

	protected override string _GetTemplateForLabelChatDetails()
	{
		return "聊天详情";
	}

	protected override string _GetTemplateForLabelChatGroupName()
	{
		return "群聊名称";
	}

	protected override string _GetTemplateForLabelClose()
	{
		return "关闭";
	}

	protected override string _GetTemplateForLabelConversationNotifications()
	{
		return "通知";
	}

	protected override string _GetTemplateForLabelConversationNotificationsOn()
	{
		return "开启";
	}

	protected override string _GetTemplateForLabelDetailsPlayTogether()
	{
		return "一起玩";
	}

	protected override string _GetTemplateForLabelFindGame()
	{
		return "查找游戏";
	}

	protected override string _GetTemplateForLabelGameNotAvailableButton()
	{
		return "不可用";
	}

	protected override string _GetTemplateForLabelGeneral()
	{
		return "通用";
	}

	protected override string _GetTemplateForLabelInCall()
	{
		return "";
	}

	protected override string _GetTemplateForLabelInGame()
	{
		return "在游戏中";
	}

	protected override string _GetTemplateForLabelInputPlaceHolderSearchForFriends()
	{
		return "搜索好友";
	}

	protected override string _GetTemplateForLabelInputPlaceHolderSendMessage()
	{
		return "发送信息";
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
		return "加入游戏";
	}

	protected override string _GetTemplateForLabelJoinParty()
	{
		return "加入队伍";
	}

	protected override string _GetTemplateForLabelLeaveChatGroup()
	{
		return "离开群聊";
	}

	protected override string _GetTemplateForLabelLeaveParty()
	{
		return "离开队伍";
	}

	protected override string _GetTemplateForLabelMember()
	{
		return "成员";
	}

	/// <summary>
	/// Key: "Label.MemberJoinText"
	/// English String: "{userName} joined the party"
	/// </summary>
	public override string LabelMemberJoinText(string userName)
	{
		return $"“{userName}“加入了队伍";
	}

	protected override string _GetTemplateForLabelMemberJoinText()
	{
		return "“{userName}“加入了队伍";
	}

	protected override string _GetTemplateForLabelMembers()
	{
		return "成员";
	}

	protected override string _GetTemplateForLabelMute15Minutes()
	{
		return "持续 15 分钟";
	}

	protected override string _GetTemplateForLabelMute1Hour()
	{
		return "持续一小时";
	}

	protected override string _GetTemplateForLabelMute24Hours()
	{
		return "持续一天";
	}

	protected override string _GetTemplateForLabelMute8Hours()
	{
		return "持续 8 小时";
	}

	protected override string _GetTemplateForLabelMuteConversationNotificationsForGroup()
	{
		return "将此群聊的通知静音";
	}

	protected override string _GetTemplateForLabelMuteConversationNotificationsForOneToOne()
	{
		return "将此对话的通知静音";
	}

	protected override string _GetTemplateForLabelMuteInfinite()
	{
		return "直到我关闭静音为止";
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
		return "命名你的群聊";
	}

	protected override string _GetTemplateForLabelNameYourChatGroup()
	{
		return "命名你的群聊";
	}

	protected override string _GetTemplateForLabelNotImplementedMessageType()
	{
		return "信息无法显示。";
	}

	protected override string _GetTemplateForLabelNotInCall()
	{
		return "";
	}

	protected override string _GetTemplateForLabelOffline()
	{
		return "离线";
	}

	protected override string _GetTemplateForLabelOnline()
	{
		return "在线";
	}

	/// <summary>
	/// Key: "Label.PartyLeaderTooltip"
	/// English String: "{userName} is the party leader"
	/// </summary>
	public override string LabelPartyLeaderTooltip(string userName)
	{
		return $"“{userName}”是队长";
	}

	protected override string _GetTemplateForLabelPartyLeaderTooltip()
	{
		return "“{userName}”是队长";
	}

	/// <summary>
	/// Key: "Label.PartyMemberTooltip"
	/// English String: "{userName} is in the party"
	/// </summary>
	public override string LabelPartyMemberTooltip(string userName)
	{
		return $"“{userName}”在队伍中";
	}

	protected override string _GetTemplateForLabelPartyMemberTooltip()
	{
		return "“{userName}”在队伍中";
	}

	/// <summary>
	/// Key: "Label.PartyName"
	/// English String: "Party : {title}"
	/// </summary>
	public override string LabelPartyName(string title)
	{
		return $"队伍：“{title}”";
	}

	protected override string _GetTemplateForLabelPartyName()
	{
		return "队伍：“{title}”";
	}

	/// <summary>
	/// Key: "Label.PendingMemberTooltip"
	/// English String: "{userName} is not in the party"
	/// </summary>
	public override string LabelPendingMemberTooltip(string userName)
	{
		return $"“{userName}”不在队伍中 ";
	}

	protected override string _GetTemplateForLabelPendingMemberTooltip()
	{
		return "“{userName}”不在队伍中 ";
	}

	protected override string _GetTemplateForLabelPinGameTooltip()
	{
		return "置顶游戏";
	}

	protected override string _GetTemplateForLabelPinnedGame()
	{
		return "置顶游戏";
	}

	protected override string _GetTemplateForLabelPlayButton()
	{
		return "开始游戏";
	}

	protected override string _GetTemplateForLabelPlayGames()
	{
		return "开始游戏";
	}

	/// <summary>
	/// Key: "Label.PlayingGame"
	/// English String: "Playing {game}"
	/// </summary>
	public override string LabelPlayingGame(string game)
	{
		return $"正在玩“{game}”";
	}

	protected override string _GetTemplateForLabelPlayingGame()
	{
		return "正在玩“{game}”";
	}

	protected override string _GetTemplateForLabelPlayTogether()
	{
		return "一起玩";
	}

	protected override string _GetTemplateForLabelRecommendedGames()
	{
		return "推荐";
	}

	protected override string _GetTemplateForLabelSeeLess()
	{
		return "收起";
	}

	protected override string _GetTemplateForLabelSeeMore()
	{
		return "查看更多";
	}

	protected override string _GetTemplateForLabelShowLessGames()
	{
		return "收起";
	}

	/// <summary>
	/// Key: "Label.ShowMoreGames"
	/// English String: "Show More (+{count})"
	/// </summary>
	public override string LabelShowMoreGames(string count)
	{
		return $"显示更多（+{count} 名）";
	}

	protected override string _GetTemplateForLabelShowMoreGames()
	{
		return "显示更多（+{count} 名）";
	}

	protected override string _GetTemplateForLabelSpanTitleCreateGroupNeeds2More()
	{
		return "添加至少 2 人以创建群聊";
	}

	protected override string _GetTemplateForLabelSpanTitleLoading()
	{
		return "正在加载...";
	}

	/// <summary>
	/// Key: "Label.TimestampOffUntilCertainTime"
	/// English String: "Off until {timestamp}"
	/// </summary>
	public override string LabelTimestampOffUntilCertainTime(string timestamp)
	{
		return $"到{timestamp}为止保持关闭";
	}

	protected override string _GetTemplateForLabelTimestampOffUntilCertainTime()
	{
		return "到{timestamp}为止保持关闭";
	}

	protected override string _GetTemplateForLabelTimestampOffUntilTomorrow()
	{
		return "到明天为止保持关闭";
	}

	protected override string _GetTemplateForLabelTimestampOffUntilTurnedBackOn()
	{
		return "直到重新开启一直保持关闭";
	}

	protected override string _GetTemplateForLabelTurnOnConversationNotificationsPrompt()
	{
		return "是否要开启通知功能？";
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
		return "取消置顶游戏";
	}

	protected override string _GetTemplateForLabelViewDetailsButton()
	{
		return "查看详情";
	}

	protected override string _GetTemplateForLabelViewProfile()
	{
		return "查看个人资料";
	}

	protected override string _GetTemplateForLabelVoiceSetting()
	{
		return "";
	}

	protected override string _GetTemplateForLabelYesterday()
	{
		return "昨天";
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
		return $"要与好友聊天，请在你的{frontLink}隐私设置{endLink}中开启聊天功能";
	}

	protected override string _GetTemplateForMessageChatPrivacySetting()
	{
		return "要与好友聊天，请在你的{frontLink}隐私设置{endLink}中开启聊天功能";
	}

	/// <summary>
	/// Key: "Message.conversationTitleChangedText"
	/// English String: "{userName} named the chat group: {groupName}"
	/// </summary>
	public override string MessageconversationTitleChangedText(string userName, string groupName)
	{
		return $"“{userName}”已将群聊命名为“{groupName}”";
	}

	protected override string _GetTemplateForMessageconversationTitleChangedText()
	{
		return "“{userName}”已将群聊命名为“{groupName}”";
	}

	protected override string _GetTemplateForMessageConversationTitleModerated()
	{
		return "群聊名称已被过滤。";
	}

	protected override string _GetTemplateForMessageDefault()
	{
		return "不是所有在此聊天中的人都能看到你的信息。";
	}

	protected override string _GetTemplateForMessageDefaultErrorMsg()
	{
		return "发生错误";
	}

	/// <summary>
	/// Key: "Message.DefaultTitleForMsg"
	/// English String: "{userName} says ..."
	/// </summary>
	public override string MessageDefaultTitleForMsg(string userName)
	{
		return $"“{userName}”说...";
	}

	protected override string _GetTemplateForMessageDefaultTitleForMsg()
	{
		return "“{userName}”说...";
	}

	/// <summary>
	/// Key: "Message.DefaultTitleForPartyInvite"
	/// English String: "Party invite from {userName}"
	/// </summary>
	public override string MessageDefaultTitleForPartyInvite(string userName)
	{
		return $"“{userName}”发来的队伍邀请";
	}

	protected override string _GetTemplateForMessageDefaultTitleForPartyInvite()
	{
		return "“{userName}”发来的队伍邀请";
	}

	protected override string _GetTemplateForMessageError()
	{
		return "错误";
	}

	/// <summary>
	/// Key: "Message.FindGameToPlay"
	/// English String: "{frontLink}Find Games{endLink} to play with your friends!"
	/// </summary>
	public override string MessageFindGameToPlay(string frontLink, string endLink)
	{
		return $"{frontLink}寻找游戏{endLink}，与好友一起同乐！";
	}

	protected override string _GetTemplateForMessageFindGameToPlay()
	{
		return "{frontLink}寻找游戏{endLink}，与好友一起同乐！";
	}

	protected override string _GetTemplateForMessageJoinPartyText()
	{
		return "队长正在寻找一起玩的游戏。";
	}

	protected override string _GetTemplateForMessageMakeFriendsToChatNPlay()
	{
		return "结交好友，开始聊天玩耍！";
	}

	protected override string _GetTemplateForMessageMessageContentModerated()
	{
		return "你的信息已被过滤，未能发送。";
	}

	protected override string _GetTemplateForMessageMessageFilterForReceivers()
	{
		return "不是所有在此聊天中的人都能看到你的信息。";
	}

	protected override string _GetTemplateForMessageNoConnectionMsg()
	{
		return "正在连接...";
	}

	protected override string _GetTemplateForMessagePartyInviteMsg()
	{
		return "队伍邀请！";
	}

	/// <summary>
	/// Key: "Message.PinGameUpdate"
	/// users pinned game in conversation
	/// English String: "{userName} chose a game to play together: {gameName}"
	/// </summary>
	public override string MessagePinGameUpdate(string userName, string gameName)
	{
		return $"“{userName}”选择了一个一起玩的游戏：“{gameName}”";
	}

	protected override string _GetTemplateForMessagePinGameUpdate()
	{
		return "“{userName}”选择了一个一起玩的游戏：“{gameName}”";
	}

	protected override string _GetTemplateForMessagePlayGameUpdate()
	{
		return " 正在玩置顶游戏： ";
	}

	protected override string _GetTemplateForMessageTextTooLong()
	{
		return "你的信息过长，未能发送。";
	}

	/// <summary>
	/// Key: "Message.ToastText"
	/// English String: "You can have up to {friendNum} friends in chat group."
	/// </summary>
	public override string MessageToastText(string friendNum)
	{
		return $"你的群聊中最多可以有 {friendNum} 位好友。";
	}

	protected override string _GetTemplateForMessageToastText()
	{
		return "你的群聊中最多可以有 {friendNum} 位好友。";
	}

	protected override string _GetTemplateForMessageUnknownMessageType()
	{
		return "信息无法显示";
	}

	protected override string _GetTemplateForPlayButton()
	{
		return "开始游戏";
	}

	protected override string _GetTemplateForResponsePartyInvite()
	{
		return "你收到队伍邀请。";
	}
}
