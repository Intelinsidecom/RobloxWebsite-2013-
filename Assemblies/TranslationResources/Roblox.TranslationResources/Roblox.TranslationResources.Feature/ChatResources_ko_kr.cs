namespace Roblox.TranslationResources.Feature;

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
	public override string ActionAdd => "추가";

	/// <summary>
	/// Key: "Action.BuyAccess"
	/// English String: "Buy Access"
	/// </summary>
	public override string ActionBuyAccess => "이용권 구매";

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "취소";

	/// <summary>
	/// Key: "Action.Create"
	/// English String: "Create"
	/// </summary>
	public override string ActionCreate => "만들기";

	/// <summary>
	/// Key: "Action.Join"
	/// join the voice chat conversation
	/// English String: "Join"
	/// </summary>
	public override string ActionJoin => "가입";

	/// <summary>
	/// Key: "Action.Leave"
	/// English String: "Leave"
	/// </summary>
	public override string ActionLeave => "나가기";

	/// <summary>
	/// Key: "Action.Remove"
	/// English String: "Remove"
	/// </summary>
	public override string ActionRemove => "삭제";

	/// <summary>
	/// Key: "Action.Report"
	/// English String: "Report"
	/// </summary>
	public override string ActionReport => "신고하기";

	/// <summary>
	/// Key: "Action.Save"
	/// English String: "Save"
	/// </summary>
	public override string ActionSave => "저장";

	/// <summary>
	/// Key: "Action.Send"
	/// English String: "Send"
	/// </summary>
	public override string ActionSend => "보내기";

	/// <summary>
	/// Key: "Action.Set"
	/// English String: "Set"
	/// </summary>
	public override string ActionSet => "설정";

	/// <summary>
	/// Key: "Action.StartParty"
	/// button label
	/// English String: "Start a Party"
	/// </summary>
	public override string ActionStartParty => "파티 시작하기";

	/// <summary>
	/// Key: "Action.Stay"
	/// English String: "Stay"
	/// </summary>
	public override string ActionStay => "머물기";

	/// <summary>
	/// Key: "Action.TurnOn"
	/// English String: "Turn On"
	/// </summary>
	public override string ActionTurnOn => "켜기";

	/// <summary>
	/// Key: "Heading.BuyItem"
	/// English String: "Buy Item"
	/// </summary>
	public override string HeadingBuyItem => "아이템 구매";

	/// <summary>
	/// Key: "Heading.Chat"
	/// English String: "Chat"
	/// </summary>
	public override string HeadingChat => "채팅";

	public override string HeadingChatAndParty => "채팅 및 파티";

	/// <summary>
	/// Key: "Heading.ConfirmLeaving"
	/// English String: "Are you sure to leave this chat group?"
	/// </summary>
	public override string HeadingConfirmLeaving => "채팅그룹을 정말 나가시겠습니까?";

	/// <summary>
	/// Key: "Heading.ContinueToReport"
	/// English String: "Continue to report?"
	/// </summary>
	public override string HeadingContinueToReport => "신고를 계속 하시겠습니까?";

	/// <summary>
	/// Key: "Heading.CreateParty"
	/// English String: "Create Party"
	/// </summary>
	public override string HeadingCreateParty => "파티 만들기";

	/// <summary>
	/// Key: "Heading.LeaveChatGroup"
	/// English String: "Leave Chat Group"
	/// </summary>
	public override string HeadingLeaveChatGroup => "채팅그룹 나가기";

	/// <summary>
	/// Key: "Heading.LeaveChatGroupQ"
	/// English String: "Leave Chat Group?"
	/// </summary>
	public override string HeadingLeaveChatGroupQ => "채팅그룹을 나가시겠습니까?";

	/// <summary>
	/// Key: "Heading.NewChatGroup"
	/// English String: "New Chat Group"
	/// </summary>
	public override string HeadingNewChatGroup => "새 채팅그룹";

	/// <summary>
	/// Key: "Heading.RemoveUser"
	/// English String: "Remove User?"
	/// </summary>
	public override string HeadingRemoveUser => "사용자를 삭제하시겠습니까?";

	/// <summary>
	/// Key: "Heading.Report"
	/// heading for abuse report dialog
	/// English String: "Report"
	/// </summary>
	public override string HeadingReport => "신고하기";

	/// <summary>
	/// Key: "Label.AddFriends"
	/// English String: "Add Friends"
	/// </summary>
	public override string LabelAddFriends => "친구 추가";

	/// <summary>
	/// Key: "Label.BuyButton"
	/// English String: "Buy"
	/// </summary>
	public override string LabelBuyButton => "구매";

	/// <summary>
	/// Key: "Label.ChangeChatGroupName"
	/// English String: "Change your chat group name"
	/// </summary>
	public override string LabelChangeChatGroupName => "채팅그룹 이름 변경";

	/// <summary>
	/// Key: "Label.ChatDetails"
	/// English String: "Chat Details"
	/// </summary>
	public override string LabelChatDetails => "채팅 정보";

	/// <summary>
	/// Key: "Label.ChatGroupName"
	/// English String: "Chat Group Name"
	/// </summary>
	public override string LabelChatGroupName => "채팅그룹 이름";

	/// <summary>
	/// Key: "Label.Close"
	/// English String: "Close"
	/// </summary>
	public override string LabelClose => "닫기";

	/// <summary>
	/// Key: "Label.ConversationNotifications"
	/// conversation notification
	/// English String: "Notifications"
	/// </summary>
	public override string LabelConversationNotifications => "알림";

	/// <summary>
	/// Key: "Label.ConversationNotificationsOn"
	/// conversation notification is on
	/// English String: "On"
	/// </summary>
	public override string LabelConversationNotificationsOn => "켜기";

	/// <summary>
	/// Key: "Label.Details.PlayTogether"
	/// English String: "PlayTogether"
	/// </summary>
	public override string LabelDetailsPlayTogether => "함께 플레이";

	/// <summary>
	/// Key: "Label.FindGame"
	/// English String: "Find Game"
	/// </summary>
	public override string LabelFindGame => "게임 찾기";

	/// <summary>
	/// Key: "Label.GameNotAvailableButton"
	/// English String: "Not Available"
	/// </summary>
	public override string LabelGameNotAvailableButton => "이용 불가";

	/// <summary>
	/// Key: "Label.General"
	/// English String: "General"
	/// </summary>
	public override string LabelGeneral => "일반";

	/// <summary>
	/// Key: "Label.InGame"
	/// English String: "In Game"
	/// </summary>
	public override string LabelInGame => "게임 중";

	/// <summary>
	/// Key: "Label.InputPlaceHolder.SearchForFriends"
	/// English String: "Search for friends"
	/// </summary>
	public override string LabelInputPlaceHolderSearchForFriends => "친구 찾기";

	/// <summary>
	/// Key: "Label.InputPlaceHolder.SendMessage"
	/// English String: "Send a message"
	/// </summary>
	public override string LabelInputPlaceHolderSendMessage => "메시지 보내기";

	/// <summary>
	/// Key: "Label.InStudio"
	/// English String: "In Studio"
	/// </summary>
	public override string LabelInStudio => "Studio 사용 중";

	/// <summary>
	/// Key: "Label.JoinButton"
	/// English String: "Join"
	/// </summary>
	public override string LabelJoinButton => "가입";

	/// <summary>
	/// Key: "Label.JoinGame"
	/// English String: "Join Game"
	/// </summary>
	public override string LabelJoinGame => "게임 참가";

	/// <summary>
	/// Key: "Label.JoinParty"
	/// English String: "Join Party"
	/// </summary>
	public override string LabelJoinParty => "파티 참가";

	/// <summary>
	/// Key: "Label.LeaveChatGroup"
	/// English String: "Leave Chat Group"
	/// </summary>
	public override string LabelLeaveChatGroup => "채팅그룹 나가기";

	/// <summary>
	/// Key: "Label.LeaveParty"
	/// English String: "Leave Party"
	/// </summary>
	public override string LabelLeaveParty => "파티 나가기";

	/// <summary>
	/// Key: "Label.Member"
	/// English String: "Member"
	/// </summary>
	public override string LabelMember => "멤버";

	/// <summary>
	/// Key: "Label.Members"
	/// English String: "Members"
	/// </summary>
	public override string LabelMembers => "멤버";

	/// <summary>
	/// Key: "Label.Mute15Minutes"
	/// mute conversation for 15 mins
	/// English String: "For 15 minutes"
	/// </summary>
	public override string LabelMute15Minutes => "15분";

	/// <summary>
	/// Key: "Label.Mute1Hour"
	/// Mute conversation for 1 hour
	/// English String: "For an hour"
	/// </summary>
	public override string LabelMute1Hour => "1시간";

	/// <summary>
	/// Key: "Label.Mute24Hours"
	/// Mute conversation for a day
	/// English String: "For a day"
	/// </summary>
	public override string LabelMute24Hours => "하루";

	/// <summary>
	/// Key: "Label.Mute8Hours"
	/// Mute conversation for 8 hours
	/// English String: "For 8 hours"
	/// </summary>
	public override string LabelMute8Hours => "8시간";

	/// <summary>
	/// Key: "Label.MuteConversationNotificationsForGroup"
	/// English String: "Mute notifications for this chat group"
	/// </summary>
	public override string LabelMuteConversationNotificationsForGroup => "채팅그룹 알림 음소거";

	/// <summary>
	/// Key: "Label.MuteConversationNotificationsForOneToOne"
	/// English String: "Mute notifications for this conversation"
	/// </summary>
	public override string LabelMuteConversationNotificationsForOneToOne => "대화 중 알림 음소거";

	/// <summary>
	/// Key: "Label.MuteInfinite"
	/// Mute conversation until user turns back
	/// English String: "Until I turn them back on"
	/// </summary>
	public override string LabelMuteInfinite => "다시 켤 때까지";

	/// <summary>
	/// Key: "Label.NameYourChangeGroup"
	/// English String: "Name your change group"
	/// </summary>
	public override string LabelNameYourChangeGroup => "채팅그룹 이름 설정";

	/// <summary>
	/// Key: "Label.NameYourChatGroup"
	/// English String: "Name your chat group"
	/// </summary>
	public override string LabelNameYourChatGroup => "채팅그룹 이름 설정";

	/// <summary>
	/// Key: "Label.NotImplementedMessageType"
	/// This message is displayed in chat when user receives message type that can't be rendered by current app version and update is not available, yet (e.g. latest version was rolled back, or in deprecated Android native chat)
	/// English String: "This message could not be displayed."
	/// </summary>
	public override string LabelNotImplementedMessageType => "이 메시지를 표시할 수 없어요.";

	/// <summary>
	/// Key: "Label.Offline"
	/// English String: "Offline"
	/// </summary>
	public override string LabelOffline => "오프라인";

	/// <summary>
	/// Key: "Label.Online"
	/// English String: "Online"
	/// </summary>
	public override string LabelOnline => "온라인";

	/// <summary>
	/// Key: "Label.PinGameTooltip"
	/// English String: "Pin Game"
	/// </summary>
	public override string LabelPinGameTooltip => "게임 핀하기";

	/// <summary>
	/// Key: "Label.PinnedGame"
	/// This is a title of card, means this game card is pinned game
	/// English String: "Pinned Game"
	/// </summary>
	public override string LabelPinnedGame => "핀한 게임";

	/// <summary>
	/// Key: "Label.PlayButton"
	/// English String: "Play"
	/// </summary>
	public override string LabelPlayButton => "플레이";

	/// <summary>
	/// Key: "Label.PlayGames"
	/// English String: "Play Games"
	/// </summary>
	public override string LabelPlayGames => "게임 플레이";

	/// <summary>
	/// Key: "Label.PlayTogether"
	/// English String: "Play Together"
	/// </summary>
	public override string LabelPlayTogether => "함께 플레이";

	/// <summary>
	/// Key: "Label.RecommendedGames"
	/// English String: "Recommended"
	/// </summary>
	public override string LabelRecommendedGames => "추천";

	/// <summary>
	/// Key: "Label.SeeLess"
	/// English String: "See Less"
	/// </summary>
	public override string LabelSeeLess => "간략히 보기";

	/// <summary>
	/// Key: "Label.SeeMore"
	/// English String: "See More"
	/// </summary>
	public override string LabelSeeMore => "더 보기";

	/// <summary>
	/// Key: "Label.ShowLessGames"
	/// English String: "Show Less"
	/// </summary>
	public override string LabelShowLessGames => "간략히 보기";

	/// <summary>
	/// Key: "Label.SpanTitle.CreateGroupNeeds2More"
	/// English String: "Add at least 2 people to create chat group"
	/// </summary>
	public override string LabelSpanTitleCreateGroupNeeds2More => "2명 이상을 추가해야 채팅 그룹을 만들 수 있습니다";

	/// <summary>
	/// Key: "Label.SpanTitle.Loading"
	/// English String: "loading ..."
	/// </summary>
	public override string LabelSpanTitleLoading => "로드 중...";

	/// <summary>
	/// Key: "Label.TimestampOffUntilTomorrow"
	/// English String: "Off until tomorrow"
	/// </summary>
	public override string LabelTimestampOffUntilTomorrow => "내일까지 끄기";

	/// <summary>
	/// Key: "Label.TimestampOffUntilTurnedBackOn"
	/// English String: "Off until turned back on\""
	/// </summary>
	public override string LabelTimestampOffUntilTurnedBackOn => "다시 켤 때까지 끄기\"";

	/// <summary>
	/// Key: "Label.TurnOnConversationNotificationsPrompt"
	/// English String: "Do you want to turn on notifications?"
	/// </summary>
	public override string LabelTurnOnConversationNotificationsPrompt => "알림을 켤까요?";

	/// <summary>
	/// Key: "Label.UnpinGameTooltip"
	/// English String: "Unpin Game"
	/// </summary>
	public override string LabelUnpinGameTooltip => "게임 핀 해제하기";

	/// <summary>
	/// Key: "Label.ViewDetailsButton"
	/// English String: "View Details"
	/// </summary>
	public override string LabelViewDetailsButton => "자세히 보기";

	/// <summary>
	/// Key: "Label.ViewProfile"
	/// English String: "View Profile"
	/// </summary>
	public override string LabelViewProfile => "프로필 보기";

	/// <summary>
	/// Key: "Label.Yesterday"
	/// time stamp for chat message received yesterday
	/// English String: "Yesterday"
	/// </summary>
	public override string LabelYesterday => "어제";

	/// <summary>
	/// Key: "Message.ConversationTitleModerated"
	/// Chat group name was moderated.
	/// English String: "Chat group name was moderated."
	/// </summary>
	public override string MessageConversationTitleModerated => "채팅그룹 이름이 검열을 통과하지 못했습니다.";

	/// <summary>
	/// Key: "Message.Default"
	/// English String: "Not everyone in this chat can see your message."
	/// </summary>
	public override string MessageDefault => "채팅 참가자 중 일부는 회원님의 메시지를 볼 수 없어요.";

	/// <summary>
	/// Key: "Message.DefaultErrorMsg"
	/// English String: "An error occurred"
	/// </summary>
	public override string MessageDefaultErrorMsg => "오류가 발생했어요";

	/// <summary>
	/// Key: "Message.Error"
	/// English String: "Error"
	/// </summary>
	public override string MessageError => "오류";

	/// <summary>
	/// Key: "Message.JoinPartyText"
	/// English String: "The party leader is finding a game to play."
	/// </summary>
	public override string MessageJoinPartyText => "파티장이 플레이할 게임을 찾고 있어요.";

	/// <summary>
	/// Key: "Message.MakeFriendsToChatNPlay"
	/// English String: "Make friends to start chatting and partying!"
	/// </summary>
	public override string MessageMakeFriendsToChatNPlay => "채팅과 파티 활동을 시작하려면 친구를 만드세요!";

	/// <summary>
	/// Key: "Message.MessageContentModerated"
	/// English String: "Your message was moderated and not sent."
	/// </summary>
	public override string MessageMessageContentModerated => "메시지가 검열을 통과하지 못해 전송되지 않았어요.";

	/// <summary>
	/// Key: "Message.MessageFilterForReceivers"
	/// English String: "Not everyone in this chat can see your message."
	/// </summary>
	public override string MessageMessageFilterForReceivers => "채팅 참가자 중 일부는 회원님의 메시지를 볼 수 없어요.";

	/// <summary>
	/// Key: "Message.NoConnectionMsg"
	/// English String: "Connecting..."
	/// </summary>
	public override string MessageNoConnectionMsg => "연결 중...";

	/// <summary>
	/// Key: "Message.PartyInviteMsg"
	/// English String: "PARTY INVITE!"
	/// </summary>
	public override string MessagePartyInviteMsg => "파티 초대!";

	/// <summary>
	/// Key: "Message.PlayGameUpdate"
	/// English String: " is playing the pinned game: "
	/// </summary>
	public override string MessagePlayGameUpdate => " 님이 핀한 게임 플레이 중: ";

	/// <summary>
	/// Key: "Message.TextTooLong"
	/// English String: "Your message was too long and not sent."
	/// </summary>
	public override string MessageTextTooLong => "메시지가 너무 길어서 전송되지 않았어요.";

	/// <summary>
	/// Key: "Message.UnknownMessageType"
	/// This serves as the fallback string for when an message type is received that the web chat does not know how to render.
	/// English String: "A message cannot be displayed"
	/// </summary>
	public override string MessageUnknownMessageType => "메시지를 표시할 수 없음";

	/// <summary>
	/// Key: "PlayButton"
	/// English String: "Play"
	/// </summary>
	public override string PlayButton => "플레이";

	/// <summary>
	/// Key: "Response.PartyInvite"
	/// notification message
	/// English String: "You received a party Invite."
	/// </summary>
	public override string ResponsePartyInvite => "파티 초대를 받았어요.";

	public ChatResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAdd()
	{
		return "추가";
	}

	protected override string _GetTemplateForActionBuyAccess()
	{
		return "이용권 구매";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "취소";
	}

	protected override string _GetTemplateForActionCreate()
	{
		return "만들기";
	}

	protected override string _GetTemplateForActionJoin()
	{
		return "가입";
	}

	protected override string _GetTemplateForActionLeave()
	{
		return "나가기";
	}

	protected override string _GetTemplateForActionRemove()
	{
		return "삭제";
	}

	protected override string _GetTemplateForActionReport()
	{
		return "신고하기";
	}

	protected override string _GetTemplateForActionSave()
	{
		return "저장";
	}

	protected override string _GetTemplateForActionSend()
	{
		return "보내기";
	}

	protected override string _GetTemplateForActionSet()
	{
		return "설정";
	}

	protected override string _GetTemplateForActionStartParty()
	{
		return "파티 시작하기";
	}

	protected override string _GetTemplateForActionStay()
	{
		return "머물기";
	}

	protected override string _GetTemplateForActionTurnOn()
	{
		return "켜기";
	}

	protected override string _GetTemplateForHeadingBuyItem()
	{
		return "아이템 구매";
	}

	protected override string _GetTemplateForHeadingChat()
	{
		return "채팅";
	}

	protected override string _GetTemplateForHeadingChatAndParty()
	{
		return "채팅 및 파티";
	}

	protected override string _GetTemplateForHeadingConfirmLeaving()
	{
		return "채팅그룹을 정말 나가시겠습니까?";
	}

	protected override string _GetTemplateForHeadingContinueToReport()
	{
		return "신고를 계속 하시겠습니까?";
	}

	protected override string _GetTemplateForHeadingCreateParty()
	{
		return "파티 만들기";
	}

	protected override string _GetTemplateForHeadingLeaveChatGroup()
	{
		return "채팅그룹 나가기";
	}

	protected override string _GetTemplateForHeadingLeaveChatGroupQ()
	{
		return "채팅그룹을 나가시겠습니까?";
	}

	protected override string _GetTemplateForHeadingNewChatGroup()
	{
		return "새 채팅그룹";
	}

	protected override string _GetTemplateForHeadingRemoveUser()
	{
		return "사용자를 삭제하시겠습니까?";
	}

	protected override string _GetTemplateForHeadingReport()
	{
		return "신고하기";
	}

	protected override string _GetTemplateForLabelAddFriends()
	{
		return "친구 추가";
	}

	/// <summary>
	/// Key: "Label.BuyAccessToGameForModal"
	/// English String: "Would you like to buy access to the Place: {placeName} from {creatorName} for {robux}?"
	/// </summary>
	public override string LabelBuyAccessToGameForModal(string placeName, string creatorName, string robux)
	{
		return $"{creatorName}이(가) 만든 {placeName} 이용권을 {robux}으(로) 구매할까요?";
	}

	protected override string _GetTemplateForLabelBuyAccessToGameForModal()
	{
		return "{creatorName}이(가) 만든 {placeName} 이용권을 {robux}으(로) 구매할까요?";
	}

	protected override string _GetTemplateForLabelBuyButton()
	{
		return "구매";
	}

	protected override string _GetTemplateForLabelChangeChatGroupName()
	{
		return "채팅그룹 이름 변경";
	}

	protected override string _GetTemplateForLabelChatDetails()
	{
		return "채팅 정보";
	}

	protected override string _GetTemplateForLabelChatGroupName()
	{
		return "채팅그룹 이름";
	}

	protected override string _GetTemplateForLabelClose()
	{
		return "닫기";
	}

	protected override string _GetTemplateForLabelConversationNotifications()
	{
		return "알림";
	}

	protected override string _GetTemplateForLabelConversationNotificationsOn()
	{
		return "켜기";
	}

	protected override string _GetTemplateForLabelDetailsPlayTogether()
	{
		return "함께 플레이";
	}

	protected override string _GetTemplateForLabelFindGame()
	{
		return "게임 찾기";
	}

	protected override string _GetTemplateForLabelGameNotAvailableButton()
	{
		return "이용 불가";
	}

	protected override string _GetTemplateForLabelGeneral()
	{
		return "일반";
	}

	protected override string _GetTemplateForLabelInGame()
	{
		return "게임 중";
	}

	protected override string _GetTemplateForLabelInputPlaceHolderSearchForFriends()
	{
		return "친구 찾기";
	}

	protected override string _GetTemplateForLabelInputPlaceHolderSendMessage()
	{
		return "메시지 보내기";
	}

	protected override string _GetTemplateForLabelInStudio()
	{
		return "Studio 사용 중";
	}

	protected override string _GetTemplateForLabelJoinButton()
	{
		return "가입";
	}

	protected override string _GetTemplateForLabelJoinGame()
	{
		return "게임 참가";
	}

	protected override string _GetTemplateForLabelJoinParty()
	{
		return "파티 참가";
	}

	protected override string _GetTemplateForLabelLeaveChatGroup()
	{
		return "채팅그룹 나가기";
	}

	protected override string _GetTemplateForLabelLeaveParty()
	{
		return "파티 나가기";
	}

	protected override string _GetTemplateForLabelMember()
	{
		return "멤버";
	}

	/// <summary>
	/// Key: "Label.MemberJoinText"
	/// English String: "{userName} joined the party"
	/// </summary>
	public override string LabelMemberJoinText(string userName)
	{
		return $"{userName}님이 파티에 참가했어요";
	}

	protected override string _GetTemplateForLabelMemberJoinText()
	{
		return "{userName}님이 파티에 참가했어요";
	}

	protected override string _GetTemplateForLabelMembers()
	{
		return "멤버";
	}

	protected override string _GetTemplateForLabelMute15Minutes()
	{
		return "15분";
	}

	protected override string _GetTemplateForLabelMute1Hour()
	{
		return "1시간";
	}

	protected override string _GetTemplateForLabelMute24Hours()
	{
		return "하루";
	}

	protected override string _GetTemplateForLabelMute8Hours()
	{
		return "8시간";
	}

	protected override string _GetTemplateForLabelMuteConversationNotificationsForGroup()
	{
		return "채팅그룹 알림 음소거";
	}

	protected override string _GetTemplateForLabelMuteConversationNotificationsForOneToOne()
	{
		return "대화 중 알림 음소거";
	}

	protected override string _GetTemplateForLabelMuteInfinite()
	{
		return "다시 켤 때까지";
	}

	protected override string _GetTemplateForLabelNameYourChangeGroup()
	{
		return "채팅그룹 이름 설정";
	}

	protected override string _GetTemplateForLabelNameYourChatGroup()
	{
		return "채팅그룹 이름 설정";
	}

	protected override string _GetTemplateForLabelNotImplementedMessageType()
	{
		return "이 메시지를 표시할 수 없어요.";
	}

	protected override string _GetTemplateForLabelOffline()
	{
		return "오프라인";
	}

	protected override string _GetTemplateForLabelOnline()
	{
		return "온라인";
	}

	/// <summary>
	/// Key: "Label.PartyLeaderTooltip"
	/// English String: "{userName} is the party leader"
	/// </summary>
	public override string LabelPartyLeaderTooltip(string userName)
	{
		return $"{userName}님이 파티장입니다";
	}

	protected override string _GetTemplateForLabelPartyLeaderTooltip()
	{
		return "{userName}님이 파티장입니다";
	}

	/// <summary>
	/// Key: "Label.PartyMemberTooltip"
	/// English String: "{userName} is in the party"
	/// </summary>
	public override string LabelPartyMemberTooltip(string userName)
	{
		return $"{userName}님은 파티 소속이에요";
	}

	protected override string _GetTemplateForLabelPartyMemberTooltip()
	{
		return "{userName}님은 파티 소속이에요";
	}

	/// <summary>
	/// Key: "Label.PartyName"
	/// English String: "Party : {title}"
	/// </summary>
	public override string LabelPartyName(string title)
	{
		return $"파티: {title}";
	}

	protected override string _GetTemplateForLabelPartyName()
	{
		return "파티: {title}";
	}

	/// <summary>
	/// Key: "Label.PendingMemberTooltip"
	/// English String: "{userName} is not in the party"
	/// </summary>
	public override string LabelPendingMemberTooltip(string userName)
	{
		return $"{userName}님은 파티 소속이 아니에요";
	}

	protected override string _GetTemplateForLabelPendingMemberTooltip()
	{
		return "{userName}님은 파티 소속이 아니에요";
	}

	protected override string _GetTemplateForLabelPinGameTooltip()
	{
		return "게임 핀하기";
	}

	protected override string _GetTemplateForLabelPinnedGame()
	{
		return "핀한 게임";
	}

	protected override string _GetTemplateForLabelPlayButton()
	{
		return "플레이";
	}

	protected override string _GetTemplateForLabelPlayGames()
	{
		return "게임 플레이";
	}

	/// <summary>
	/// Key: "Label.PlayingGame"
	/// English String: "Playing {game}"
	/// </summary>
	public override string LabelPlayingGame(string game)
	{
		return $"{game} 플레이 중";
	}

	protected override string _GetTemplateForLabelPlayingGame()
	{
		return "{game} 플레이 중";
	}

	protected override string _GetTemplateForLabelPlayTogether()
	{
		return "함께 플레이";
	}

	protected override string _GetTemplateForLabelRecommendedGames()
	{
		return "추천";
	}

	protected override string _GetTemplateForLabelSeeLess()
	{
		return "간략히 보기";
	}

	protected override string _GetTemplateForLabelSeeMore()
	{
		return "더 보기";
	}

	protected override string _GetTemplateForLabelShowLessGames()
	{
		return "간략히 보기";
	}

	/// <summary>
	/// Key: "Label.ShowMoreGames"
	/// English String: "Show More (+{count})"
	/// </summary>
	public override string LabelShowMoreGames(string count)
	{
		return $"더 보기 (+{count})";
	}

	protected override string _GetTemplateForLabelShowMoreGames()
	{
		return "더 보기 (+{count})";
	}

	protected override string _GetTemplateForLabelSpanTitleCreateGroupNeeds2More()
	{
		return "2명 이상을 추가해야 채팅 그룹을 만들 수 있습니다";
	}

	protected override string _GetTemplateForLabelSpanTitleLoading()
	{
		return "로드 중...";
	}

	/// <summary>
	/// Key: "Label.TimestampOffUntilCertainTime"
	/// English String: "Off until {timestamp}"
	/// </summary>
	public override string LabelTimestampOffUntilCertainTime(string timestamp)
	{
		return $"{timestamp}까지 끄기";
	}

	protected override string _GetTemplateForLabelTimestampOffUntilCertainTime()
	{
		return "{timestamp}까지 끄기";
	}

	protected override string _GetTemplateForLabelTimestampOffUntilTomorrow()
	{
		return "내일까지 끄기";
	}

	protected override string _GetTemplateForLabelTimestampOffUntilTurnedBackOn()
	{
		return "다시 켤 때까지 끄기\"";
	}

	protected override string _GetTemplateForLabelTurnOnConversationNotificationsPrompt()
	{
		return "알림을 켤까요?";
	}

	protected override string _GetTemplateForLabelUnpinGameTooltip()
	{
		return "게임 핀 해제하기";
	}

	protected override string _GetTemplateForLabelViewDetailsButton()
	{
		return "자세히 보기";
	}

	protected override string _GetTemplateForLabelViewProfile()
	{
		return "프로필 보기";
	}

	protected override string _GetTemplateForLabelYesterday()
	{
		return "어제";
	}

	/// <summary>
	/// Key: "Message.ChatPrivacySetting"
	/// English String: "To chat with friends, turn on chat in your {frontLink}Privacy Settings{endLink}"
	/// </summary>
	public override string MessageChatPrivacySetting(string frontLink, string endLink)
	{
		return $"친구와 이야기를 나누려면 {frontLink}개인정보 설정{endLink}에서 채팅을 활성화하세요";
	}

	protected override string _GetTemplateForMessageChatPrivacySetting()
	{
		return "친구와 이야기를 나누려면 {frontLink}개인정보 설정{endLink}에서 채팅을 활성화하세요";
	}

	/// <summary>
	/// Key: "Message.conversationTitleChangedText"
	/// English String: "{userName} named the chat group: {groupName}"
	/// </summary>
	public override string MessageconversationTitleChangedText(string userName, string groupName)
	{
		return $"{userName}님이 설정한 채팅그룹 이름: {groupName}";
	}

	protected override string _GetTemplateForMessageconversationTitleChangedText()
	{
		return "{userName}님이 설정한 채팅그룹 이름: {groupName}";
	}

	protected override string _GetTemplateForMessageConversationTitleModerated()
	{
		return "채팅그룹 이름이 검열을 통과하지 못했습니다.";
	}

	protected override string _GetTemplateForMessageDefault()
	{
		return "채팅 참가자 중 일부는 회원님의 메시지를 볼 수 없어요.";
	}

	protected override string _GetTemplateForMessageDefaultErrorMsg()
	{
		return "오류가 발생했어요";
	}

	/// <summary>
	/// Key: "Message.DefaultTitleForMsg"
	/// English String: "{userName} says ..."
	/// </summary>
	public override string MessageDefaultTitleForMsg(string userName)
	{
		return $"{userName}님의 말:";
	}

	protected override string _GetTemplateForMessageDefaultTitleForMsg()
	{
		return "{userName}님의 말:";
	}

	/// <summary>
	/// Key: "Message.DefaultTitleForPartyInvite"
	/// English String: "Party invite from {userName}"
	/// </summary>
	public override string MessageDefaultTitleForPartyInvite(string userName)
	{
		return $"{userName}님이 파티에 초대했어요";
	}

	protected override string _GetTemplateForMessageDefaultTitleForPartyInvite()
	{
		return "{userName}님이 파티에 초대했어요";
	}

	protected override string _GetTemplateForMessageError()
	{
		return "오류";
	}

	/// <summary>
	/// Key: "Message.FindGameToPlay"
	/// English String: "{frontLink}Find Games{endLink} to play with your friends!"
	/// </summary>
	public override string MessageFindGameToPlay(string frontLink, string endLink)
	{
		return $"{frontLink}게임 검색{endLink}을 통해 친구와 즐길 게임을 찾아보세요!";
	}

	protected override string _GetTemplateForMessageFindGameToPlay()
	{
		return "{frontLink}게임 검색{endLink}을 통해 친구와 즐길 게임을 찾아보세요!";
	}

	protected override string _GetTemplateForMessageJoinPartyText()
	{
		return "파티장이 플레이할 게임을 찾고 있어요.";
	}

	protected override string _GetTemplateForMessageMakeFriendsToChatNPlay()
	{
		return "채팅과 파티 활동을 시작하려면 친구를 만드세요!";
	}

	protected override string _GetTemplateForMessageMessageContentModerated()
	{
		return "메시지가 검열을 통과하지 못해 전송되지 않았어요.";
	}

	protected override string _GetTemplateForMessageMessageFilterForReceivers()
	{
		return "채팅 참가자 중 일부는 회원님의 메시지를 볼 수 없어요.";
	}

	protected override string _GetTemplateForMessageNoConnectionMsg()
	{
		return "연결 중...";
	}

	protected override string _GetTemplateForMessagePartyInviteMsg()
	{
		return "파티 초대!";
	}

	/// <summary>
	/// Key: "Message.PinGameUpdate"
	/// users pinned game in conversation
	/// English String: "{userName} chose a game to play together: {gameName}"
	/// </summary>
	public override string MessagePinGameUpdate(string userName, string gameName)
	{
		return $"{userName}님이 함께 플레이하기 위해 선택한 게임: {gameName}";
	}

	protected override string _GetTemplateForMessagePinGameUpdate()
	{
		return "{userName}님이 함께 플레이하기 위해 선택한 게임: {gameName}";
	}

	protected override string _GetTemplateForMessagePlayGameUpdate()
	{
		return " 님이 핀한 게임 플레이 중: ";
	}

	protected override string _GetTemplateForMessageTextTooLong()
	{
		return "메시지가 너무 길어서 전송되지 않았어요.";
	}

	/// <summary>
	/// Key: "Message.ToastText"
	/// English String: "You can have up to {friendNum} friends in chat group."
	/// </summary>
	public override string MessageToastText(string friendNum)
	{
		return $"채팅그룹 최대 정원은 {friendNum}명입니다.";
	}

	protected override string _GetTemplateForMessageToastText()
	{
		return "채팅그룹 최대 정원은 {friendNum}명입니다.";
	}

	protected override string _GetTemplateForMessageUnknownMessageType()
	{
		return "메시지를 표시할 수 없음";
	}

	protected override string _GetTemplateForPlayButton()
	{
		return "플레이";
	}

	protected override string _GetTemplateForResponsePartyInvite()
	{
		return "파티 초대를 받았어요.";
	}
}
