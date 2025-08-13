namespace Roblox.TranslationResources.Feature;

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
	public override string ActionAdd => "追加";

	/// <summary>
	/// Key: "Action.BuyAccess"
	/// English String: "Buy Access"
	/// </summary>
	public override string ActionBuyAccess => "アクセスを買う";

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "キャンセル";

	/// <summary>
	/// Key: "Action.Create"
	/// English String: "Create"
	/// </summary>
	public override string ActionCreate => "作成";

	/// <summary>
	/// Key: "Action.Join"
	/// join the voice chat conversation
	/// English String: "Join"
	/// </summary>
	public override string ActionJoin => "参加";

	/// <summary>
	/// Key: "Action.JoinVoice"
	/// Join voice call
	/// English String: "Join"
	/// </summary>
	public override string ActionJoinVoice => "参加";

	/// <summary>
	/// Key: "Action.Leave"
	/// English String: "Leave"
	/// </summary>
	public override string ActionLeave => "やめる";

	/// <summary>
	/// Key: "Action.Mute"
	/// mute microphone in short term
	/// English String: "Mute"
	/// </summary>
	public override string ActionMute => "消音";

	/// <summary>
	/// Key: "Action.MuteMic"
	/// English String: "Mute Your Microphone"
	/// </summary>
	public override string ActionMuteMic => "マイクをミュート";

	/// <summary>
	/// Key: "Action.Remove"
	/// English String: "Remove"
	/// </summary>
	public override string ActionRemove => "削除";

	/// <summary>
	/// Key: "Action.Report"
	/// English String: "Report"
	/// </summary>
	public override string ActionReport => "報告する";

	/// <summary>
	/// Key: "Action.Save"
	/// English String: "Save"
	/// </summary>
	public override string ActionSave => "保存";

	/// <summary>
	/// Key: "Action.Send"
	/// English String: "Send"
	/// </summary>
	public override string ActionSend => "送信";

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
	public override string ActionStartParty => "パーティを結成する";

	/// <summary>
	/// Key: "Action.Stay"
	/// English String: "Stay"
	/// </summary>
	public override string ActionStay => "そのまま";

	/// <summary>
	/// Key: "Action.TurnOn"
	/// English String: "Turn On"
	/// </summary>
	public override string ActionTurnOn => "オンにする";

	/// <summary>
	/// Key: "Action.Unmute"
	/// unmute mic in short term
	/// English String: "Unmute"
	/// </summary>
	public override string ActionUnmute => "ミュート解除";

	/// <summary>
	/// Key: "Action.UnmuteMic"
	/// English String: "Unmute Your Microphone"
	/// </summary>
	public override string ActionUnmuteMic => "マイクをミュート解除";

	/// <summary>
	/// Key: "Description.JoinInVoiceChat"
	/// English String: "Click Join to join the call"
	/// </summary>
	public override string DescriptionJoinInVoiceChat => "通話に参加するには参加をクリック";

	/// <summary>
	/// Key: "Description.UserInVoice"
	/// User is actively in voice chat
	/// English String: "You are in the voice chat"
	/// </summary>
	public override string DescriptionUserInVoice => "ボイスチャット中です";

	/// <summary>
	/// Key: "Description.VoiceNotConnect"
	/// Error handling message when voice chat api return errors
	/// English String: "Could not connect to voice chat"
	/// </summary>
	public override string DescriptionVoiceNotConnect => "ボイスチャットに接続できませんでした";

	/// <summary>
	/// Key: "Heading.BuyItem"
	/// English String: "Buy Item"
	/// </summary>
	public override string HeadingBuyItem => "アイテムを買う";

	/// <summary>
	/// Key: "Heading.Chat"
	/// English String: "Chat"
	/// </summary>
	public override string HeadingChat => "チャット";

	public override string HeadingChatAndParty => "チャットとパーティ";

	/// <summary>
	/// Key: "Heading.ConfirmLeaving"
	/// English String: "Are you sure to leave this chat group?"
	/// </summary>
	public override string HeadingConfirmLeaving => "このチャットグループを終了してよろしいですか？";

	/// <summary>
	/// Key: "Heading.ContinueToReport"
	/// English String: "Continue to report?"
	/// </summary>
	public override string HeadingContinueToReport => "報告しますか？";

	/// <summary>
	/// Key: "Heading.CreateParty"
	/// English String: "Create Party"
	/// </summary>
	public override string HeadingCreateParty => "パーティを作成";

	/// <summary>
	/// Key: "Heading.LeaveChatGroup"
	/// English String: "Leave Chat Group"
	/// </summary>
	public override string HeadingLeaveChatGroup => "チャットグループを終了";

	/// <summary>
	/// Key: "Heading.LeaveChatGroupQ"
	/// English String: "Leave Chat Group?"
	/// </summary>
	public override string HeadingLeaveChatGroupQ => "チャットグループを終了しますか？";

	/// <summary>
	/// Key: "Heading.NewChatGroup"
	/// English String: "New Chat Group"
	/// </summary>
	public override string HeadingNewChatGroup => "新規チャットグループ";

	/// <summary>
	/// Key: "Heading.RemoveUser"
	/// English String: "Remove User?"
	/// </summary>
	public override string HeadingRemoveUser => "ユーザーを削除しますか？";

	/// <summary>
	/// Key: "Heading.Report"
	/// heading for abuse report dialog
	/// English String: "Report"
	/// </summary>
	public override string HeadingReport => "報告する";

	/// <summary>
	/// Key: "Label.AddFriends"
	/// English String: "Add Friends"
	/// </summary>
	public override string LabelAddFriends => "友達を追加する";

	/// <summary>
	/// Key: "Label.BuyButton"
	/// English String: "Buy"
	/// </summary>
	public override string LabelBuyButton => "買う";

	/// <summary>
	/// Key: "Label.ChangeChatGroupName"
	/// English String: "Change your chat group name"
	/// </summary>
	public override string LabelChangeChatGroupName => "チャットグループ名を変更する";

	/// <summary>
	/// Key: "Label.ChatDetails"
	/// English String: "Chat Details"
	/// </summary>
	public override string LabelChatDetails => "チャット詳細";

	/// <summary>
	/// Key: "Label.ChatGroupName"
	/// English String: "Chat Group Name"
	/// </summary>
	public override string LabelChatGroupName => "チャットグループ名";

	/// <summary>
	/// Key: "Label.Close"
	/// English String: "Close"
	/// </summary>
	public override string LabelClose => "閉じる";

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
	public override string LabelConversationNotificationsOn => "オン";

	/// <summary>
	/// Key: "Label.Details.PlayTogether"
	/// English String: "PlayTogether"
	/// </summary>
	public override string LabelDetailsPlayTogether => "一緒にプレイ";

	/// <summary>
	/// Key: "Label.FindGame"
	/// English String: "Find Game"
	/// </summary>
	public override string LabelFindGame => "ゲームを探す";

	/// <summary>
	/// Key: "Label.GameNotAvailableButton"
	/// English String: "Not Available"
	/// </summary>
	public override string LabelGameNotAvailableButton => "利用できません";

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
	public override string LabelInGame => "ゲーム内";

	/// <summary>
	/// Key: "Label.InputPlaceHolder.SearchForFriends"
	/// English String: "Search for friends"
	/// </summary>
	public override string LabelInputPlaceHolderSearchForFriends => "友達を検索";

	/// <summary>
	/// Key: "Label.InputPlaceHolder.SendMessage"
	/// English String: "Send a message"
	/// </summary>
	public override string LabelInputPlaceHolderSendMessage => "メッセージを送信";

	/// <summary>
	/// Key: "Label.InStudio"
	/// English String: "In Studio"
	/// </summary>
	public override string LabelInStudio => "Studio内";

	/// <summary>
	/// Key: "Label.JoinButton"
	/// English String: "Join"
	/// </summary>
	public override string LabelJoinButton => "参加";

	/// <summary>
	/// Key: "Label.JoinGame"
	/// English String: "Join Game"
	/// </summary>
	public override string LabelJoinGame => "ゲームに参加";

	/// <summary>
	/// Key: "Label.JoinParty"
	/// English String: "Join Party"
	/// </summary>
	public override string LabelJoinParty => "パーティに参加";

	/// <summary>
	/// Key: "Label.LeaveChatGroup"
	/// English String: "Leave Chat Group"
	/// </summary>
	public override string LabelLeaveChatGroup => "チャットグループを終了";

	/// <summary>
	/// Key: "Label.LeaveParty"
	/// English String: "Leave Party"
	/// </summary>
	public override string LabelLeaveParty => "パーティを終了";

	/// <summary>
	/// Key: "Label.Member"
	/// English String: "Member"
	/// </summary>
	public override string LabelMember => "メンバー";

	/// <summary>
	/// Key: "Label.Members"
	/// English String: "Members"
	/// </summary>
	public override string LabelMembers => "メンバー";

	/// <summary>
	/// Key: "Label.Mute15Minutes"
	/// mute conversation for 15 mins
	/// English String: "For 15 minutes"
	/// </summary>
	public override string LabelMute15Minutes => "15分間";

	/// <summary>
	/// Key: "Label.Mute1Hour"
	/// Mute conversation for 1 hour
	/// English String: "For an hour"
	/// </summary>
	public override string LabelMute1Hour => "1時間";

	/// <summary>
	/// Key: "Label.Mute24Hours"
	/// Mute conversation for a day
	/// English String: "For a day"
	/// </summary>
	public override string LabelMute24Hours => "1日";

	/// <summary>
	/// Key: "Label.Mute8Hours"
	/// Mute conversation for 8 hours
	/// English String: "For 8 hours"
	/// </summary>
	public override string LabelMute8Hours => "8時間";

	/// <summary>
	/// Key: "Label.MuteConversationNotificationsForGroup"
	/// English String: "Mute notifications for this chat group"
	/// </summary>
	public override string LabelMuteConversationNotificationsForGroup => "このチャットグループの通知をオフにする";

	/// <summary>
	/// Key: "Label.MuteConversationNotificationsForOneToOne"
	/// English String: "Mute notifications for this conversation"
	/// </summary>
	public override string LabelMuteConversationNotificationsForOneToOne => "この会話の通知をオフにする";

	/// <summary>
	/// Key: "Label.MuteInfinite"
	/// Mute conversation until user turns back
	/// English String: "Until I turn them back on"
	/// </summary>
	public override string LabelMuteInfinite => "オンに戻すまで";

	/// <summary>
	/// Key: "Label.NameYourChangeGroup"
	/// English String: "Name your change group"
	/// </summary>
	public override string LabelNameYourChangeGroup => "変更グループに名前を付ける";

	/// <summary>
	/// Key: "Label.NameYourChatGroup"
	/// English String: "Name your chat group"
	/// </summary>
	public override string LabelNameYourChatGroup => "チャットグループに名前を付ける";

	/// <summary>
	/// Key: "Label.NotImplementedMessageType"
	/// This message is displayed in chat when user receives message type that can't be rendered by current app version and update is not available, yet (e.g. latest version was rolled back, or in deprecated Android native chat)
	/// English String: "This message could not be displayed."
	/// </summary>
	public override string LabelNotImplementedMessageType => "メッセージを表示できませんでした。";

	/// <summary>
	/// Key: "Label.NotInCall"
	/// English String: "Not in call"
	/// </summary>
	public override string LabelNotInCall => "通話中ではありません";

	/// <summary>
	/// Key: "Label.Offline"
	/// English String: "Offline"
	/// </summary>
	public override string LabelOffline => "オフライン";

	/// <summary>
	/// Key: "Label.Online"
	/// English String: "Online"
	/// </summary>
	public override string LabelOnline => "オンライン";

	/// <summary>
	/// Key: "Label.PinGameTooltip"
	/// English String: "Pin Game"
	/// </summary>
	public override string LabelPinGameTooltip => "ゲームにピンを付ける";

	/// <summary>
	/// Key: "Label.PinnedGame"
	/// This is a title of card, means this game card is pinned game
	/// English String: "Pinned Game"
	/// </summary>
	public override string LabelPinnedGame => "ピンを付けたゲーム";

	/// <summary>
	/// Key: "Label.PlayButton"
	/// English String: "Play"
	/// </summary>
	public override string LabelPlayButton => "プレイ";

	/// <summary>
	/// Key: "Label.PlayGames"
	/// English String: "Play Games"
	/// </summary>
	public override string LabelPlayGames => "ゲームをプレイ";

	/// <summary>
	/// Key: "Label.PlayTogether"
	/// English String: "Play Together"
	/// </summary>
	public override string LabelPlayTogether => "一緒にプレイする";

	/// <summary>
	/// Key: "Label.RecommendedGames"
	/// English String: "Recommended"
	/// </summary>
	public override string LabelRecommendedGames => "おすすめ";

	/// <summary>
	/// Key: "Label.SeeLess"
	/// English String: "See Less"
	/// </summary>
	public override string LabelSeeLess => "見る数を減らす";

	/// <summary>
	/// Key: "Label.SeeMore"
	/// English String: "See More"
	/// </summary>
	public override string LabelSeeMore => "もっと見る";

	/// <summary>
	/// Key: "Label.ShowLessGames"
	/// English String: "Show Less"
	/// </summary>
	public override string LabelShowLessGames => "表示を減らす";

	/// <summary>
	/// Key: "Label.SpanTitle.CreateGroupNeeds2More"
	/// English String: "Add at least 2 people to create chat group"
	/// </summary>
	public override string LabelSpanTitleCreateGroupNeeds2More => "チャットグループを作成するには、2人以上追加してください";

	/// <summary>
	/// Key: "Label.SpanTitle.Loading"
	/// English String: "loading ..."
	/// </summary>
	public override string LabelSpanTitleLoading => "読み込み中 ...";

	/// <summary>
	/// Key: "Label.TimestampOffUntilTomorrow"
	/// English String: "Off until tomorrow"
	/// </summary>
	public override string LabelTimestampOffUntilTomorrow => "明日までオフ";

	/// <summary>
	/// Key: "Label.TimestampOffUntilTurnedBackOn"
	/// English String: "Off until turned back on\""
	/// </summary>
	public override string LabelTimestampOffUntilTurnedBackOn => "オンに戻すまでオフ";

	/// <summary>
	/// Key: "Label.TurnOnConversationNotificationsPrompt"
	/// English String: "Do you want to turn on notifications?"
	/// </summary>
	public override string LabelTurnOnConversationNotificationsPrompt => "通知をオンにしますか？";

	/// <summary>
	/// Key: "Label.UnpinGameTooltip"
	/// English String: "Unpin Game"
	/// </summary>
	public override string LabelUnpinGameTooltip => "ゲームのピンを外す";

	/// <summary>
	/// Key: "Label.ViewDetailsButton"
	/// English String: "View Details"
	/// </summary>
	public override string LabelViewDetailsButton => "詳細を表示";

	/// <summary>
	/// Key: "Label.ViewProfile"
	/// English String: "View Profile"
	/// </summary>
	public override string LabelViewProfile => "プロフィールを見る";

	/// <summary>
	/// Key: "Label.VoiceSetting"
	/// Voice chat setting label
	/// English String: "Voice Settings"
	/// </summary>
	public override string LabelVoiceSetting => "ボイス設定";

	/// <summary>
	/// Key: "Label.Yesterday"
	/// time stamp for chat message received yesterday
	/// English String: "Yesterday"
	/// </summary>
	public override string LabelYesterday => "昨日";

	/// <summary>
	/// Key: "Message.ConversationTitleModerated"
	/// Chat group name was moderated.
	/// English String: "Chat group name was moderated."
	/// </summary>
	public override string MessageConversationTitleModerated => "チャットグループ名が規制対象です。";

	/// <summary>
	/// Key: "Message.Default"
	/// English String: "Not everyone in this chat can see your message."
	/// </summary>
	public override string MessageDefault => "このチャットでは、全員があなたのメッセージを見れるわけではありません。";

	/// <summary>
	/// Key: "Message.DefaultErrorMsg"
	/// English String: "An error occurred"
	/// </summary>
	public override string MessageDefaultErrorMsg => "エラーが発生";

	/// <summary>
	/// Key: "Message.Error"
	/// English String: "Error"
	/// </summary>
	public override string MessageError => "エラー";

	/// <summary>
	/// Key: "Message.JoinPartyText"
	/// English String: "The party leader is finding a game to play."
	/// </summary>
	public override string MessageJoinPartyText => "パーティリーダーがプレイするゲームを探しています。";

	/// <summary>
	/// Key: "Message.MakeFriendsToChatNPlay"
	/// English String: "Make friends to start chatting and partying!"
	/// </summary>
	public override string MessageMakeFriendsToChatNPlay => "友達を作ってチャットやパーティを始めよう！";

	/// <summary>
	/// Key: "Message.MessageContentModerated"
	/// English String: "Your message was moderated and not sent."
	/// </summary>
	public override string MessageMessageContentModerated => "メッセージは、規制により送信されませんでした。";

	/// <summary>
	/// Key: "Message.MessageFilterForReceivers"
	/// English String: "Not everyone in this chat can see your message."
	/// </summary>
	public override string MessageMessageFilterForReceivers => "このチャットでは、全員があなたのメッセージを見れるわけではありません。";

	/// <summary>
	/// Key: "Message.NoConnectionMsg"
	/// English String: "Connecting..."
	/// </summary>
	public override string MessageNoConnectionMsg => "接続中...";

	/// <summary>
	/// Key: "Message.PartyInviteMsg"
	/// English String: "PARTY INVITE!"
	/// </summary>
	public override string MessagePartyInviteMsg => "パーティへの招待！";

	/// <summary>
	/// Key: "Message.PlayGameUpdate"
	/// English String: " is playing the pinned game: "
	/// </summary>
	public override string MessagePlayGameUpdate => " さんは、ピンを付けた以下のゲームをプレイ中: ";

	/// <summary>
	/// Key: "Message.TextTooLong"
	/// English String: "Your message was too long and not sent."
	/// </summary>
	public override string MessageTextTooLong => "メッセージが長すぎるため、送信されませんでした。";

	/// <summary>
	/// Key: "Message.UnknownMessageType"
	/// This serves as the fallback string for when an message type is received that the web chat does not know how to render.
	/// English String: "A message cannot be displayed"
	/// </summary>
	public override string MessageUnknownMessageType => "メッセージを表示できません";

	/// <summary>
	/// Key: "PlayButton"
	/// English String: "Play"
	/// </summary>
	public override string PlayButton => "プレイ";

	/// <summary>
	/// Key: "Response.PartyInvite"
	/// notification message
	/// English String: "You received a party Invite."
	/// </summary>
	public override string ResponsePartyInvite => "パーティへの招待が届きました。";

	public ChatResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAdd()
	{
		return "追加";
	}

	protected override string _GetTemplateForActionBuyAccess()
	{
		return "アクセスを買う";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "キャンセル";
	}

	protected override string _GetTemplateForActionCreate()
	{
		return "作成";
	}

	protected override string _GetTemplateForActionJoin()
	{
		return "参加";
	}

	protected override string _GetTemplateForActionJoinVoice()
	{
		return "参加";
	}

	protected override string _GetTemplateForActionLeave()
	{
		return "やめる";
	}

	protected override string _GetTemplateForActionMute()
	{
		return "消音";
	}

	protected override string _GetTemplateForActionMuteMic()
	{
		return "マイクをミュート";
	}

	protected override string _GetTemplateForActionRemove()
	{
		return "削除";
	}

	protected override string _GetTemplateForActionReport()
	{
		return "報告する";
	}

	protected override string _GetTemplateForActionSave()
	{
		return "保存";
	}

	protected override string _GetTemplateForActionSend()
	{
		return "送信";
	}

	protected override string _GetTemplateForActionSet()
	{
		return "設定";
	}

	protected override string _GetTemplateForActionStartParty()
	{
		return "パーティを結成する";
	}

	protected override string _GetTemplateForActionStay()
	{
		return "そのまま";
	}

	protected override string _GetTemplateForActionTurnOn()
	{
		return "オンにする";
	}

	protected override string _GetTemplateForActionUnmute()
	{
		return "ミュート解除";
	}

	protected override string _GetTemplateForActionUnmuteMic()
	{
		return "マイクをミュート解除";
	}

	protected override string _GetTemplateForDescriptionJoinInVoiceChat()
	{
		return "通話に参加するには参加をクリック";
	}

	protected override string _GetTemplateForDescriptionUserInVoice()
	{
		return "ボイスチャット中です";
	}

	protected override string _GetTemplateForDescriptionVoiceNotConnect()
	{
		return "ボイスチャットに接続できませんでした";
	}

	protected override string _GetTemplateForHeadingBuyItem()
	{
		return "アイテムを買う";
	}

	protected override string _GetTemplateForHeadingChat()
	{
		return "チャット";
	}

	protected override string _GetTemplateForHeadingChatAndParty()
	{
		return "チャットとパーティ";
	}

	protected override string _GetTemplateForHeadingConfirmLeaving()
	{
		return "このチャットグループを終了してよろしいですか？";
	}

	protected override string _GetTemplateForHeadingContinueToReport()
	{
		return "報告しますか？";
	}

	protected override string _GetTemplateForHeadingCreateParty()
	{
		return "パーティを作成";
	}

	protected override string _GetTemplateForHeadingLeaveChatGroup()
	{
		return "チャットグループを終了";
	}

	protected override string _GetTemplateForHeadingLeaveChatGroupQ()
	{
		return "チャットグループを終了しますか？";
	}

	protected override string _GetTemplateForHeadingNewChatGroup()
	{
		return "新規チャットグループ";
	}

	protected override string _GetTemplateForHeadingRemoveUser()
	{
		return "ユーザーを削除しますか？";
	}

	protected override string _GetTemplateForHeadingReport()
	{
		return "報告する";
	}

	protected override string _GetTemplateForLabelAddFriends()
	{
		return "友達を追加する";
	}

	/// <summary>
	/// Key: "Label.BuyAccessToGameForModal"
	/// English String: "Would you like to buy access to the Place: {placeName} from {creatorName} for {robux}?"
	/// </summary>
	public override string LabelBuyAccessToGameForModal(string placeName, string creatorName, string robux)
	{
		return $"{creatorName} さんが作ったプレース、 {placeName} へのアクセスを {robux} で買いますか？";
	}

	protected override string _GetTemplateForLabelBuyAccessToGameForModal()
	{
		return "{creatorName} さんが作ったプレース、 {placeName} へのアクセスを {robux} で買いますか？";
	}

	protected override string _GetTemplateForLabelBuyButton()
	{
		return "買う";
	}

	protected override string _GetTemplateForLabelChangeChatGroupName()
	{
		return "チャットグループ名を変更する";
	}

	protected override string _GetTemplateForLabelChatDetails()
	{
		return "チャット詳細";
	}

	protected override string _GetTemplateForLabelChatGroupName()
	{
		return "チャットグループ名";
	}

	protected override string _GetTemplateForLabelClose()
	{
		return "閉じる";
	}

	protected override string _GetTemplateForLabelConversationNotifications()
	{
		return "通知";
	}

	protected override string _GetTemplateForLabelConversationNotificationsOn()
	{
		return "オン";
	}

	protected override string _GetTemplateForLabelDetailsPlayTogether()
	{
		return "一緒にプレイ";
	}

	protected override string _GetTemplateForLabelFindGame()
	{
		return "ゲームを探す";
	}

	protected override string _GetTemplateForLabelGameNotAvailableButton()
	{
		return "利用できません";
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
		return "ゲーム内";
	}

	protected override string _GetTemplateForLabelInputPlaceHolderSearchForFriends()
	{
		return "友達を検索";
	}

	protected override string _GetTemplateForLabelInputPlaceHolderSendMessage()
	{
		return "メッセージを送信";
	}

	protected override string _GetTemplateForLabelInStudio()
	{
		return "Studio内";
	}

	protected override string _GetTemplateForLabelJoinButton()
	{
		return "参加";
	}

	protected override string _GetTemplateForLabelJoinGame()
	{
		return "ゲームに参加";
	}

	protected override string _GetTemplateForLabelJoinParty()
	{
		return "パーティに参加";
	}

	protected override string _GetTemplateForLabelLeaveChatGroup()
	{
		return "チャットグループを終了";
	}

	protected override string _GetTemplateForLabelLeaveParty()
	{
		return "パーティを終了";
	}

	protected override string _GetTemplateForLabelMember()
	{
		return "メンバー";
	}

	/// <summary>
	/// Key: "Label.MemberJoinText"
	/// English String: "{userName} joined the party"
	/// </summary>
	public override string LabelMemberJoinText(string userName)
	{
		return $"{userName} さんがパーティに参加しました";
	}

	protected override string _GetTemplateForLabelMemberJoinText()
	{
		return "{userName} さんがパーティに参加しました";
	}

	protected override string _GetTemplateForLabelMembers()
	{
		return "メンバー";
	}

	protected override string _GetTemplateForLabelMute15Minutes()
	{
		return "15分間";
	}

	protected override string _GetTemplateForLabelMute1Hour()
	{
		return "1時間";
	}

	protected override string _GetTemplateForLabelMute24Hours()
	{
		return "1日";
	}

	protected override string _GetTemplateForLabelMute8Hours()
	{
		return "8時間";
	}

	protected override string _GetTemplateForLabelMuteConversationNotificationsForGroup()
	{
		return "このチャットグループの通知をオフにする";
	}

	protected override string _GetTemplateForLabelMuteConversationNotificationsForOneToOne()
	{
		return "この会話の通知をオフにする";
	}

	protected override string _GetTemplateForLabelMuteInfinite()
	{
		return "オンに戻すまで";
	}

	protected override string _GetTemplateForLabelNameYourChangeGroup()
	{
		return "変更グループに名前を付ける";
	}

	protected override string _GetTemplateForLabelNameYourChatGroup()
	{
		return "チャットグループに名前を付ける";
	}

	protected override string _GetTemplateForLabelNotImplementedMessageType()
	{
		return "メッセージを表示できませんでした。";
	}

	protected override string _GetTemplateForLabelNotInCall()
	{
		return "通話中ではありません";
	}

	protected override string _GetTemplateForLabelOffline()
	{
		return "オフライン";
	}

	protected override string _GetTemplateForLabelOnline()
	{
		return "オンライン";
	}

	/// <summary>
	/// Key: "Label.PartyLeaderTooltip"
	/// English String: "{userName} is the party leader"
	/// </summary>
	public override string LabelPartyLeaderTooltip(string userName)
	{
		return $"{userName} さんがパーティリーダーです";
	}

	protected override string _GetTemplateForLabelPartyLeaderTooltip()
	{
		return "{userName} さんがパーティリーダーです";
	}

	/// <summary>
	/// Key: "Label.PartyMemberTooltip"
	/// English String: "{userName} is in the party"
	/// </summary>
	public override string LabelPartyMemberTooltip(string userName)
	{
		return $"{userName} さんはパーティに参加しています";
	}

	protected override string _GetTemplateForLabelPartyMemberTooltip()
	{
		return "{userName} さんはパーティに参加しています";
	}

	/// <summary>
	/// Key: "Label.PartyName"
	/// English String: "Party : {title}"
	/// </summary>
	public override string LabelPartyName(string title)
	{
		return $"パーティ: {title}";
	}

	protected override string _GetTemplateForLabelPartyName()
	{
		return "パーティ: {title}";
	}

	/// <summary>
	/// Key: "Label.PendingMemberTooltip"
	/// English String: "{userName} is not in the party"
	/// </summary>
	public override string LabelPendingMemberTooltip(string userName)
	{
		return $"{userName} さんはパーティに参加していません";
	}

	protected override string _GetTemplateForLabelPendingMemberTooltip()
	{
		return "{userName} さんはパーティに参加していません";
	}

	protected override string _GetTemplateForLabelPinGameTooltip()
	{
		return "ゲームにピンを付ける";
	}

	protected override string _GetTemplateForLabelPinnedGame()
	{
		return "ピンを付けたゲーム";
	}

	protected override string _GetTemplateForLabelPlayButton()
	{
		return "プレイ";
	}

	protected override string _GetTemplateForLabelPlayGames()
	{
		return "ゲームをプレイ";
	}

	/// <summary>
	/// Key: "Label.PlayingGame"
	/// English String: "Playing {game}"
	/// </summary>
	public override string LabelPlayingGame(string game)
	{
		return $"{game}をプレイ中";
	}

	protected override string _GetTemplateForLabelPlayingGame()
	{
		return "{game}をプレイ中";
	}

	protected override string _GetTemplateForLabelPlayTogether()
	{
		return "一緒にプレイする";
	}

	protected override string _GetTemplateForLabelRecommendedGames()
	{
		return "おすすめ";
	}

	protected override string _GetTemplateForLabelSeeLess()
	{
		return "見る数を減らす";
	}

	protected override string _GetTemplateForLabelSeeMore()
	{
		return "もっと見る";
	}

	protected override string _GetTemplateForLabelShowLessGames()
	{
		return "表示を減らす";
	}

	/// <summary>
	/// Key: "Label.ShowMoreGames"
	/// English String: "Show More (+{count})"
	/// </summary>
	public override string LabelShowMoreGames(string count)
	{
		return $"さらに表示（+{count}）";
	}

	protected override string _GetTemplateForLabelShowMoreGames()
	{
		return "さらに表示（+{count}）";
	}

	protected override string _GetTemplateForLabelSpanTitleCreateGroupNeeds2More()
	{
		return "チャットグループを作成するには、2人以上追加してください";
	}

	protected override string _GetTemplateForLabelSpanTitleLoading()
	{
		return "読み込み中 ...";
	}

	/// <summary>
	/// Key: "Label.TimestampOffUntilCertainTime"
	/// English String: "Off until {timestamp}"
	/// </summary>
	public override string LabelTimestampOffUntilCertainTime(string timestamp)
	{
		return $"{timestamp}までオフ";
	}

	protected override string _GetTemplateForLabelTimestampOffUntilCertainTime()
	{
		return "{timestamp}までオフ";
	}

	protected override string _GetTemplateForLabelTimestampOffUntilTomorrow()
	{
		return "明日までオフ";
	}

	protected override string _GetTemplateForLabelTimestampOffUntilTurnedBackOn()
	{
		return "オンに戻すまでオフ";
	}

	protected override string _GetTemplateForLabelTurnOnConversationNotificationsPrompt()
	{
		return "通知をオンにしますか？";
	}

	protected override string _GetTemplateForLabelUnpinGameTooltip()
	{
		return "ゲームのピンを外す";
	}

	protected override string _GetTemplateForLabelViewDetailsButton()
	{
		return "詳細を表示";
	}

	protected override string _GetTemplateForLabelViewProfile()
	{
		return "プロフィールを見る";
	}

	protected override string _GetTemplateForLabelVoiceSetting()
	{
		return "ボイス設定";
	}

	protected override string _GetTemplateForLabelYesterday()
	{
		return "昨日";
	}

	/// <summary>
	/// Key: "Message.ChatPrivacySetting"
	/// English String: "To chat with friends, turn on chat in your {frontLink}Privacy Settings{endLink}"
	/// </summary>
	public override string MessageChatPrivacySetting(string frontLink, string endLink)
	{
		return $"友達とチャットするには、「{frontLink}プライバシー設定{endLink}」でチャットを有効にしてください";
	}

	protected override string _GetTemplateForMessageChatPrivacySetting()
	{
		return "友達とチャットするには、「{frontLink}プライバシー設定{endLink}」でチャットを有効にしてください";
	}

	/// <summary>
	/// Key: "Message.conversationTitleChangedText"
	/// English String: "{userName} named the chat group: {groupName}"
	/// </summary>
	public override string MessageconversationTitleChangedText(string userName, string groupName)
	{
		return $"{userName}さんがチャットグループ名を指定しました: {groupName}";
	}

	protected override string _GetTemplateForMessageconversationTitleChangedText()
	{
		return "{userName}さんがチャットグループ名を指定しました: {groupName}";
	}

	protected override string _GetTemplateForMessageConversationTitleModerated()
	{
		return "チャットグループ名が規制対象です。";
	}

	protected override string _GetTemplateForMessageDefault()
	{
		return "このチャットでは、全員があなたのメッセージを見れるわけではありません。";
	}

	protected override string _GetTemplateForMessageDefaultErrorMsg()
	{
		return "エラーが発生";
	}

	/// <summary>
	/// Key: "Message.DefaultTitleForMsg"
	/// English String: "{userName} says ..."
	/// </summary>
	public override string MessageDefaultTitleForMsg(string userName)
	{
		return $"{userName}さんの発言...";
	}

	protected override string _GetTemplateForMessageDefaultTitleForMsg()
	{
		return "{userName}さんの発言...";
	}

	/// <summary>
	/// Key: "Message.DefaultTitleForPartyInvite"
	/// English String: "Party invite from {userName}"
	/// </summary>
	public override string MessageDefaultTitleForPartyInvite(string userName)
	{
		return $"{userName}さんからのパーティへの招待";
	}

	protected override string _GetTemplateForMessageDefaultTitleForPartyInvite()
	{
		return "{userName}さんからのパーティへの招待";
	}

	protected override string _GetTemplateForMessageError()
	{
		return "エラー";
	}

	/// <summary>
	/// Key: "Message.FindGameToPlay"
	/// English String: "{frontLink}Find Games{endLink} to play with your friends!"
	/// </summary>
	public override string MessageFindGameToPlay(string frontLink, string endLink)
	{
		return $"友達と一緒にプレイする{frontLink}ゲームを見つけよう{endLink}！";
	}

	protected override string _GetTemplateForMessageFindGameToPlay()
	{
		return "友達と一緒にプレイする{frontLink}ゲームを見つけよう{endLink}！";
	}

	protected override string _GetTemplateForMessageJoinPartyText()
	{
		return "パーティリーダーがプレイするゲームを探しています。";
	}

	protected override string _GetTemplateForMessageMakeFriendsToChatNPlay()
	{
		return "友達を作ってチャットやパーティを始めよう！";
	}

	protected override string _GetTemplateForMessageMessageContentModerated()
	{
		return "メッセージは、規制により送信されませんでした。";
	}

	protected override string _GetTemplateForMessageMessageFilterForReceivers()
	{
		return "このチャットでは、全員があなたのメッセージを見れるわけではありません。";
	}

	protected override string _GetTemplateForMessageNoConnectionMsg()
	{
		return "接続中...";
	}

	protected override string _GetTemplateForMessagePartyInviteMsg()
	{
		return "パーティへの招待！";
	}

	/// <summary>
	/// Key: "Message.PinGameUpdate"
	/// users pinned game in conversation
	/// English String: "{userName} chose a game to play together: {gameName}"
	/// </summary>
	public override string MessagePinGameUpdate(string userName, string gameName)
	{
		return $"{userName} さんが一緒にプレイするゲームを選びました: {gameName}";
	}

	protected override string _GetTemplateForMessagePinGameUpdate()
	{
		return "{userName} さんが一緒にプレイするゲームを選びました: {gameName}";
	}

	protected override string _GetTemplateForMessagePlayGameUpdate()
	{
		return " さんは、ピンを付けた以下のゲームをプレイ中: ";
	}

	protected override string _GetTemplateForMessageTextTooLong()
	{
		return "メッセージが長すぎるため、送信されませんでした。";
	}

	/// <summary>
	/// Key: "Message.ToastText"
	/// English String: "You can have up to {friendNum} friends in chat group."
	/// </summary>
	public override string MessageToastText(string friendNum)
	{
		return $"チャットグループには友達を{friendNum}人まで追加できます。";
	}

	protected override string _GetTemplateForMessageToastText()
	{
		return "チャットグループには友達を{friendNum}人まで追加できます。";
	}

	protected override string _GetTemplateForMessageUnknownMessageType()
	{
		return "メッセージを表示できません";
	}

	protected override string _GetTemplateForPlayButton()
	{
		return "プレイ";
	}

	protected override string _GetTemplateForResponsePartyInvite()
	{
		return "パーティへの招待が届きました。";
	}
}
