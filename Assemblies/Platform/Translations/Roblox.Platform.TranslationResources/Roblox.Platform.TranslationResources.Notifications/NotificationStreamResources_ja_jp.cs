namespace Roblox.TranslationResources.Notifications;

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
	public override string ActionAccept => "承認する";

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "キャンセル";

	/// <summary>
	/// Key: "Action.Chat"
	/// English String: "Chat"
	/// </summary>
	public override string ActionChat => "チャット";

	/// <summary>
	/// Key: "Action.Ignore"
	/// English String: "Ignore"
	/// </summary>
	public override string ActionIgnore => "無視する";

	/// <summary>
	/// Key: "Action.Play"
	/// Label for button to launch game.
	/// English String: "Play"
	/// </summary>
	public override string ActionPlay => "プレイ";

	/// <summary>
	/// Key: "Action.ReportAbuse"
	/// Label for link to report a game update message
	/// English String: "Report Abuse"
	/// </summary>
	public override string ActionReportAbuse => "規約違反を報告";

	/// <summary>
	/// Key: "Action.Undo"
	/// Label for Undo link to reverse the unfollow action
	/// English String: "Undo"
	/// </summary>
	public override string ActionUndo => "取り消す";

	/// <summary>
	/// Key: "Action.View"
	/// English String: "View"
	/// </summary>
	public override string ActionView => "表示";

	/// <summary>
	/// Key: "Action.ViewAll"
	/// English String: "View All"
	/// </summary>
	public override string ActionViewAll => "すべて表示";

	/// <summary>
	/// Key: "Heading.BackToAllNotifications"
	/// Heading displayed in game updates view, containing back link to notifications main view.
	/// English String: "All Notifications"
	/// </summary>
	public override string HeadingBackToAllNotifications => "すべての通知";

	/// <summary>
	/// Key: "Label.NoNetworkConnectionText"
	/// English String: "Connecting..."
	/// </summary>
	public override string LabelNoNetworkConnectionText => "接続中...";

	/// <summary>
	/// Key: "Label.NoNotifications"
	/// English String: "No Notifications"
	/// </summary>
	public override string LabelNoNotifications => "通知はありません";

	/// <summary>
	/// Key: "Label.Notifications"
	/// English String: "Notifications"
	/// </summary>
	public override string LabelNotifications => "通知";

	/// <summary>
	/// Key: "Label.Settings"
	/// English String: "Settings"
	/// </summary>
	public override string LabelSettings => "設定";

	/// <summary>
	/// Key: "Message.GameNotPlayableOnDevice"
	/// Message displayed on game update card when the game is not playable on the device type.
	/// English String: "Not playable on this device"
	/// </summary>
	public override string MessageGameNotPlayableOnDevice => "このデバイスではプレイできません";

	/// <summary>
	/// Key: "Message.TooManyFriendsOther"
	/// English String: "That user already has the max number of friends."
	/// </summary>
	public override string MessageTooManyFriendsOther => "そのユーザーは、これ以上友達を増やせません。";

	/// <summary>
	/// Key: "Message.TooManyFriendsSelf"
	/// English String: "You already have the max number of friends."
	/// </summary>
	public override string MessageTooManyFriendsSelf => "これ以上友達を増やせません。";

	public NotificationStreamResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAccept()
	{
		return "承認する";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "キャンセル";
	}

	protected override string _GetTemplateForActionChat()
	{
		return "チャット";
	}

	protected override string _GetTemplateForActionIgnore()
	{
		return "無視する";
	}

	protected override string _GetTemplateForActionPlay()
	{
		return "プレイ";
	}

	protected override string _GetTemplateForActionReportAbuse()
	{
		return "規約違反を報告";
	}

	protected override string _GetTemplateForActionUndo()
	{
		return "取り消す";
	}

	/// <summary>
	/// Key: "Action.UnfollowGame"
	/// Label of menu item to unfollow the game
	/// English String: "Unfollow {gameName}"
	/// </summary>
	public override string ActionUnfollowGame(string gameName)
	{
		return $"{gameName}のフォローをやめる";
	}

	protected override string _GetTemplateForActionUnfollowGame()
	{
		return "{gameName}のフォローをやめる";
	}

	protected override string _GetTemplateForActionView()
	{
		return "表示";
	}

	protected override string _GetTemplateForActionViewAll()
	{
		return "すべて表示";
	}

	protected override string _GetTemplateForHeadingBackToAllNotifications()
	{
		return "すべての通知";
	}

	protected override string _GetTemplateForLabelNoNetworkConnectionText()
	{
		return "接続中...";
	}

	protected override string _GetTemplateForLabelNoNotifications()
	{
		return "通知はありません";
	}

	protected override string _GetTemplateForLabelNotifications()
	{
		return "通知";
	}

	protected override string _GetTemplateForLabelSettings()
	{
		return "設定";
	}

	/// <summary>
	/// Key: "Message.AggregatedGameUpdateDouble"
	/// Message displayed on aggregated game update notification card, when there are exactly two games sending update.
	/// English String: "{gameOne} and {gameTwo} sent updates."
	/// </summary>
	public override string MessageAggregatedGameUpdateDouble(string gameOne, string gameTwo)
	{
		return $"{gameOne}と{gameTwo}がアップデートを送信しました。";
	}

	protected override string _GetTemplateForMessageAggregatedGameUpdateDouble()
	{
		return "{gameOne}と{gameTwo}がアップデートを送信しました。";
	}

	protected override string _GetTemplateForMessageAggregatedGameUpdateMultiple()
	{
		return "{gameOne}、{gameTwo}、他{otherCount, plural, =1 {# 種類のゲーム} other {# 種類のゲーム}}がアップデートを送信しました。";
	}

	/// <summary>
	/// Key: "Message.ConfirmAcceptedDouble"
	/// English String: "{userOne} and {userTwo}"
	/// </summary>
	public override string MessageConfirmAcceptedDouble(string userOne, string userTwo)
	{
		return $"{userOne}さんと{userTwo}さん";
	}

	protected override string _GetTemplateForMessageConfirmAcceptedDouble()
	{
		return "{userOne}さんと{userTwo}さん";
	}

	protected override string _GetTemplateForMessageConfirmAcceptedMultiple()
	{
		return "{userOne}さん、{userTwo}さん、他{userMultipleCount, plural, =1 {人} other {人}}";
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
		return $"{userOne}さんと{userTwo}さんが友達になりました！";
	}

	protected override string _GetTemplateForMessageConfirmSentDouble()
	{
		return "{userOne}さんと{userTwo}さんが友達になりました！";
	}

	protected override string _GetTemplateForMessageConfirmSentMultiple()
	{
		return "{userOne}さん、{userTwo}さん、他{userMultipleCount, plural, =1 {人} other {人}}が、友達になりました！";
	}

	/// <summary>
	/// Key: "Message.ConfirmSentSingle"
	/// English String: "{userOne} is now your friend!"
	/// </summary>
	public override string MessageConfirmSentSingle(string userOne)
	{
		return $"{userOne}さんが友達になりました！";
	}

	protected override string _GetTemplateForMessageConfirmSentSingle()
	{
		return "{userOne}さんが友達になりました！";
	}

	/// <summary>
	/// Key: "Message.DeveloperMetricsAvailable"
	/// English String: "{month} {year} Analytics Report for {gameName} available."
	/// </summary>
	public override string MessageDeveloperMetricsAvailable(string month, string year, string gameName)
	{
		return $"{month} {year} の{gameName} の解析レポートが存在します.";
	}

	protected override string _GetTemplateForMessageDeveloperMetricsAvailable()
	{
		return "{month} {year} の{gameName} の解析レポートが存在します.";
	}

	protected override string _GetTemplateForMessageDeveloperMetricsAvailableMultiple()
	{
		return "{gameName} の {year} {month} の解析レポートと {otherCount, plural, =1 {# 件の他のゲーム} other {# 件の他のゲーム}}のものがあります";
	}

	/// <summary>
	/// Key: "Message.DeveloperMetricsAvailableMultiple2"
	/// English String: "{month} {year} Analytics Report for {gameCount} games available."
	/// </summary>
	public override string MessageDeveloperMetricsAvailableMultiple2(string month, string year, string gameCount)
	{
		return $"{year} {month} の {gameCount} 件のゲーム解析レポートがあります。";
	}

	protected override string _GetTemplateForMessageDeveloperMetricsAvailableMultiple2()
	{
		return "{year} {month} の {gameCount} 件のゲーム解析レポートがあります。";
	}

	/// <summary>
	/// Key: "Message.FriendRequestAcceptedDouble"
	/// English String: "{userOne} and {userTwo} accepted your friend request."
	/// </summary>
	public override string MessageFriendRequestAcceptedDouble(string userOne, string userTwo)
	{
		return $"{userOne}さんと{userTwo}さんが、あなたの友達リクエストを承認しました。";
	}

	protected override string _GetTemplateForMessageFriendRequestAcceptedDouble()
	{
		return "{userOne}さんと{userTwo}さんが、あなたの友達リクエストを承認しました。";
	}

	protected override string _GetTemplateForMessageFriendRequestAcceptedMultiple()
	{
		return "{userOne}さん、{userTwo}さん、他{userMultipleCount, plural, =1 {# 人} other {# 人}}が、あなたの友達リクエストを承認しました。";
	}

	/// <summary>
	/// Key: "Message.FriendRequestAcceptedSingle"
	/// English String: "{userOne} accepted your friend request."
	/// </summary>
	public override string MessageFriendRequestAcceptedSingle(string userOne)
	{
		return $"{userOne}さんが、あなたの友達リクエストを承認しました。";
	}

	protected override string _GetTemplateForMessageFriendRequestAcceptedSingle()
	{
		return "{userOne}さんが、あなたの友達リクエストを承認しました。";
	}

	/// <summary>
	/// Key: "Message.FriendRequestSentDouble"
	/// English String: "{userOne} and {userTwo} sent you friend requests."
	/// </summary>
	public override string MessageFriendRequestSentDouble(string userOne, string userTwo)
	{
		return $"{userOne} さんと{userTwo} さんから友達リクエストが届きました。";
	}

	protected override string _GetTemplateForMessageFriendRequestSentDouble()
	{
		return "{userOne} さんと{userTwo} さんから友達リクエストが届きました。";
	}

	protected override string _GetTemplateForMessageFriendRequestSentMultiple()
	{
		return "{userOne}さん、{userTwo}さん、他{userMultipleCount, plural, =1 {人} other {人}}から友達リクエストが届きました。";
	}

	/// <summary>
	/// Key: "Message.FriendRequestSentSingle"
	/// English String: "{userOne} sent you a friend request."
	/// </summary>
	public override string MessageFriendRequestSentSingle(string userOne)
	{
		return $"{userOne} さんから友達リクエストが届きました。";
	}

	protected override string _GetTemplateForMessageFriendRequestSentSingle()
	{
		return "{userOne} さんから友達リクエストが届きました。";
	}

	protected override string _GetTemplateForMessageGameNotPlayableOnDevice()
	{
		return "このデバイスではプレイできません";
	}

	/// <summary>
	/// Key: "Message.MessageAndPreview"
	/// English String: "{titleStart}Message from {username}:{titleEnd} {message}"
	/// </summary>
	public override string MessageMessageAndPreview(string titleStart, string username, string titleEnd, string message)
	{
		return $"{titleStart}{username}さんからのメッセージ:{titleEnd} {message}";
	}

	protected override string _GetTemplateForMessageMessageAndPreview()
	{
		return "{titleStart}{username}さんからのメッセージ:{titleEnd} {message}";
	}

	/// <summary>
	/// Key: "Message.MessageFrom"
	/// English String: "Message from {username}:"
	/// </summary>
	public override string MessageMessageFrom(string username)
	{
		return $"{username}さんからのメッセージ:";
	}

	protected override string _GetTemplateForMessageMessageFrom()
	{
		return "{username}さんからのメッセージ:";
	}

	protected override string _GetTemplateForMessageNumberofNewNotifications()
	{
		return "{notificationCount, plural, =1 {# 新着通知} other {# 新着通知}}";
	}

	protected override string _GetTemplateForMessageTooManyFriendsOther()
	{
		return "そのユーザーは、これ以上友達を増やせません。";
	}

	protected override string _GetTemplateForMessageTooManyFriendsSelf()
	{
		return "これ以上友達を増やせません。";
	}

	/// <summary>
	/// Key: "Message.UnfollowedGame"
	/// Message displayed in game update card after user unfollowed the game
	/// English String: "Unfollowed {gameName}"
	/// </summary>
	public override string MessageUnfollowedGame(string gameName)
	{
		return $"{gameName}のフォローをやめました";
	}

	protected override string _GetTemplateForMessageUnfollowedGame()
	{
		return "{gameName}のフォローをやめました";
	}

	protected override string _GetTemplateForMessageYouHaveNewFriendRequests()
	{
		return "{numberOfRequests}件の{numberOfRequests, plural, =1 {友達リクエスト} other {友達リクエスト}}が届きました。";
	}

	protected override string _GetTemplateForMessageYouHaveNewFriends()
	{
		return "{numberOfFriends}人の{numberOfFriends, plural, =1 {友達} other {友達}}ができました。";
	}

	protected override string _GetTemplateForMessageYouReceivedMessages()
	{
		return "{numberOfMessagesText}件の{numberOfMessages, plural, =1 {メッセージ} other {メッセージ}}が届きました";
	}
}
