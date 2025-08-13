namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides FriendsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class FriendsResources_ja_jp : FriendsResources_en_us, IFriendsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Accept"
	/// English String: "Accept"
	/// </summary>
	public override string ActionAccept => "承認する";

	/// <summary>
	/// Key: "Action.FindFriends"
	/// English String: "Find Friends"
	/// </summary>
	public override string ActionFindFriends => "友達を見つける";

	/// <summary>
	/// Key: "Action.Follow"
	/// English String: "Follow"
	/// </summary>
	public override string ActionFollow => "フォロー";

	/// <summary>
	/// Key: "Action.Ignore"
	/// English String: "Ignore"
	/// </summary>
	public override string ActionIgnore => "無視する";

	/// <summary>
	/// Key: "Action.IgnoreAll"
	/// English String: "Ignore All"
	/// </summary>
	public override string ActionIgnoreAll => "すべて無視する";

	/// <summary>
	/// Key: "Action.Unfollow"
	/// English String: "Unfollow"
	/// </summary>
	public override string ActionUnfollow => "フォローをやめる";

	/// <summary>
	/// Key: "Action.Unfriend"
	/// English String: "Unfriend"
	/// </summary>
	public override string ActionUnfriend => "友達解除";

	/// <summary>
	/// Key: "Heading.MyFriends"
	/// English String: "My Friends"
	/// </summary>
	public override string HeadingMyFriends => "あなたの友達";

	/// <summary>
	/// Key: "Label.ErrorTitle"
	/// English String: "Error"
	/// </summary>
	public override string LabelErrorTitle => "エラー";

	/// <summary>
	/// Key: "Label.Followers"
	/// English String: "Followers"
	/// </summary>
	public override string LabelFollowers => "フォロワー";

	/// <summary>
	/// Key: "Label.Following"
	/// English String: "Following"
	/// </summary>
	public override string LabelFollowing => "フォロー中";

	/// <summary>
	/// Key: "Label.FriendRequests"
	/// English String: "Friend Requests"
	/// </summary>
	public override string LabelFriendRequests => "友達リクエスト";

	/// <summary>
	/// Key: "Label.Friends"
	/// English String: "Friends"
	/// </summary>
	public override string LabelFriends => "友達";

	/// <summary>
	/// Key: "Label.Offline"
	/// English String: "Offline"
	/// </summary>
	public override string LabelOffline => "オフライン";

	/// <summary>
	/// Key: "Label.Ok"
	/// English String: "Ok"
	/// </summary>
	public override string LabelOk => "OK";

	/// <summary>
	/// Key: "Label.Online"
	/// English String: "Online"
	/// </summary>
	public override string LabelOnline => "オンライン";

	/// <summary>
	/// Key: "Label.Requests"
	/// English String: "Requests"
	/// </summary>
	public override string LabelRequests => "リクエスト";

	/// <summary>
	/// Key: "Label.SearchFriends"
	/// When user doesn't have any friends.
	/// English String: "Search for Friends"
	/// </summary>
	public override string LabelSearchFriends => "友達を検索";

	/// <summary>
	/// Key: "Label.Unfollowed"
	/// Unfollowed
	/// English String: "Unfollowed"
	/// </summary>
	public override string LabelUnfollowed => "フォローをやめました";

	/// <summary>
	/// Key: "Message.ActionNotAllowedError"
	/// English String: "Action not allowed"
	/// </summary>
	public override string MessageActionNotAllowedError => "アクションが許可されていません";

	/// <summary>
	/// Key: "Message.AlreadyExistsError"
	/// English String: "Already exists."
	/// </summary>
	public override string MessageAlreadyExistsError => "すでにあります。";

	/// <summary>
	/// Key: "Message.CurrentInvalidParametersError"
	/// English String: "Invalid parameters."
	/// </summary>
	public override string MessageCurrentInvalidParametersError => "無効なパラメータです。";

	/// <summary>
	/// Key: "Message.CurrentUserFriendsLimitExceededError"
	/// English String: "You have reached the maximum number of Friends. Please remove a Friend before accepting any more Friend Requests."
	/// </summary>
	public override string MessageCurrentUserFriendsLimitExceededError => "友達の数が上限を超えました。友達リクエストを承認する前に、ほかの友達を削除してください。";

	/// <summary>
	/// Key: "Message.DefaultError"
	/// English String: "An error ocurred."
	/// </summary>
	public override string MessageDefaultError => "エラーが発生しました。";

	/// <summary>
	/// Key: "Message.FloodLimitExceededError"
	/// English String: "You are performing this action too often. Please wait a minute and try again."
	/// </summary>
	public override string MessageFloodLimitExceededError => "この操作を何度も実行しています。1分ほど待ってからやり直してください。";

	/// <summary>
	/// Key: "Message.FollowerTabTooltip"
	/// English String: "People who have chosen to follow your activity."
	/// </summary>
	public override string MessageFollowerTabTooltip => "あなたのアクティビティをフォローしているユーザー。";

	/// <summary>
	/// Key: "Message.FollowingTabTooltip"
	/// English String: "People whose activity you have chosen to follow."
	/// </summary>
	public override string MessageFollowingTabTooltip => "あなたがアクティビティをフォローしているユーザー。";

	/// <summary>
	/// Key: "Message.ForGeneralError"
	/// English String: "Something went wrong."
	/// </summary>
	public override string MessageForGeneralError => "問題が発生しました。";

	/// <summary>
	/// Key: "Message.ForGeneralFooter"
	/// English String: "Please check back in few minutes."
	/// </summary>
	public override string MessageForGeneralFooter => "しばらくしてからもう一度お試しください。";

	/// <summary>
	/// Key: "Message.ForMaxFriendsError"
	/// English String: "Unable to process Request.You currently have the max number of Friends allowed. "
	/// </summary>
	public override string MessageForMaxFriendsError => "リクエストを処理できません。現在、登録できる友達の数が上限に達しています。 ";

	/// <summary>
	/// Key: "Message.ForMaxFriendsFooter"
	/// English String: "Unfriend someone before accepting any more Friend Requests."
	/// </summary>
	public override string MessageForMaxFriendsFooter => "これ以上の友達リクエストを承認するには、誰かを友達解除してください。";

	/// <summary>
	/// Key: "Message.ForMaxRequestsError"
	/// English String: "Unable to process Request. That user currently has the max number of Friends allowed."
	/// </summary>
	public override string MessageForMaxRequestsError => "リクエストを処理できません。現在、そのユーザーは登録できる友達の数が上限に達しています。";

	/// <summary>
	/// Key: "Message.ForMaxRequestsFooter"
	/// English String: "You can not accept their Friend Request until they remove a Friend."
	/// </summary>
	public override string MessageForMaxRequestsFooter => "ほかの友達を削除するまで、新しい友達リクエストを承認できません。";

	/// <summary>
	/// Key: "Message.FriendRequestNotExistError"
	/// English String: "Friend request does not exist"
	/// </summary>
	public override string MessageFriendRequestNotExistError => "友達リクエストが存在しません";

	/// <summary>
	/// Key: "Message.FriendsLimitExceededError"
	/// English String: "Friends limit exceeded."
	/// </summary>
	public override string MessageFriendsLimitExceededError => "友達の数が上限を超えました。";

	/// <summary>
	/// Key: "Message.FriendsTabTooltip"
	/// English String: "Friends are established when two Roblox users mutually agree to friendship."
	/// </summary>
	public override string MessageFriendsTabTooltip => "Robloxのユーザー二人がお互いに同意すれば、友達になれます。";

	/// <summary>
	/// Key: "Message.NotRecipientError"
	/// English String: "You are not the recipient of this friend request."
	/// </summary>
	public override string MessageNotRecipientError => "この友達リクエストは、あなた宛てではありません。";

	/// <summary>
	/// Key: "Message.OtherUserFriendsLimitExceededError"
	/// English String: "Friends limit exceeded."
	/// </summary>
	public override string MessageOtherUserFriendsLimitExceededError => "友達の数が上限を超えました。";

	/// <summary>
	/// Key: "Message.RequestsTabTooltip"
	/// English String: "Friends are established when two Roblox users mutually agree to friendship."
	/// </summary>
	public override string MessageRequestsTabTooltip => "Robloxのユーザー二人がお互いに同意すれば、友達になれます。";

	/// <summary>
	/// Key: "Message.RobloxIsMoreFunWithFriends"
	/// English String: "Roblox is more fun with friends!"
	/// </summary>
	public override string MessageRobloxIsMoreFunWithFriends => "Robloxは、友達と一緒にプレイすれば、もっとお楽しみいただけます！";

	/// <summary>
	/// Key: "Message.SelfFollowingAttemptError"
	/// English String: "You cannot follow yourself."
	/// </summary>
	public override string MessageSelfFollowingAttemptError => "自分をフォローすることはできません。";

	/// <summary>
	/// Key: "Message.SelfFriendingAttemptError"
	/// English String: "You cannot be friends with yourself."
	/// </summary>
	public override string MessageSelfFriendingAttemptError => "自分と友達になることはできません。";

	/// <summary>
	/// Key: "Message.SystemUnavailableError"
	/// English String: "Friends and Followers system is unavailable."
	/// </summary>
	public override string MessageSystemUnavailableError => "友達およびフォロワーのシステムは利用できません。";

	/// <summary>
	/// Key: "Message.UnblockUserPinLockedError"
	/// English String: "Pin is locked."
	/// </summary>
	public override string MessageUnblockUserPinLockedError => "PINはロックされています。";

	/// <summary>
	/// Key: "Message.UserBlockedError"
	/// English String: "User is blocked"
	/// </summary>
	public override string MessageUserBlockedError => "ユーザーはブロックされています";

	/// <summary>
	/// Key: "Message.UserHasNotPassedCaptchaError"
	/// English String: "You need to pass Captcha."
	/// </summary>
	public override string MessageUserHasNotPassedCaptchaError => "キャプチャを完了する必要があります。";

	/// <summary>
	/// Key: "Message.UsersAreNotInSameGameError"
	/// English String: "Users need to be in the same game."
	/// </summary>
	public override string MessageUsersAreNotInSameGameError => "ユーザーが同じゲーム内にいる必要があります。";

	public FriendsResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAccept()
	{
		return "承認する";
	}

	protected override string _GetTemplateForActionFindFriends()
	{
		return "友達を見つける";
	}

	protected override string _GetTemplateForActionFollow()
	{
		return "フォロー";
	}

	protected override string _GetTemplateForActionIgnore()
	{
		return "無視する";
	}

	protected override string _GetTemplateForActionIgnoreAll()
	{
		return "すべて無視する";
	}

	protected override string _GetTemplateForActionUnfollow()
	{
		return "フォローをやめる";
	}

	protected override string _GetTemplateForActionUnfriend()
	{
		return "友達解除";
	}

	/// <summary>
	/// Key: "Description.SearchFriends"
	/// When user doesn't have friends, this suggestive text will show up.
	/// English String: "Tap the magnifying glass icon above and search for a user or {startLink}play games{endLink} to meet people."
	/// </summary>
	public override string DescriptionSearchFriends(string startLink, string endLink)
	{
		return $"上部の虫眼鏡アイコンをタップして、ユーザーを検索するか、{startLink}ゲームをプレイ{endLink}して、知り合いになりましょう。";
	}

	protected override string _GetTemplateForDescriptionSearchFriends()
	{
		return "上部の虫眼鏡アイコンをタップして、ユーザーを検索するか、{startLink}ゲームをプレイ{endLink}して、知り合いになりましょう。";
	}

	protected override string _GetTemplateForHeadingMyFriends()
	{
		return "あなたの友達";
	}

	/// <summary>
	/// Key: "Heading.UsersFriends"
	/// English String: "{username}'s Friends"
	/// </summary>
	public override string HeadingUsersFriends(string username)
	{
		return $"{username} さんの友達";
	}

	protected override string _GetTemplateForHeadingUsersFriends()
	{
		return "{username} さんの友達";
	}

	protected override string _GetTemplateForLabelErrorTitle()
	{
		return "エラー";
	}

	protected override string _GetTemplateForLabelFollowers()
	{
		return "フォロワー";
	}

	protected override string _GetTemplateForLabelFollowing()
	{
		return "フォロー中";
	}

	protected override string _GetTemplateForLabelFriendRequests()
	{
		return "友達リクエスト";
	}

	protected override string _GetTemplateForLabelFriends()
	{
		return "友達";
	}

	/// <summary>
	/// Key: "Label.NearbyUpsell"
	/// Shown when a user is on the Universal Friend Finder page and has no friend requests. This tells them to try another feature to find friends called "Nearby"
	/// English String: "You have no pending friend requests. To add friends, check out {startSpan}Nearby{endSpan}."
	/// </summary>
	public override string LabelNearbyUpsell(string startSpan, string endSpan)
	{
		return $"保留中の友達リクエストはありません。友達を追加するには、 {startSpan}周辺{endSpan} をチェックしてください。";
	}

	protected override string _GetTemplateForLabelNearbyUpsell()
	{
		return "保留中の友達リクエストはありません。友達を追加するには、 {startSpan}周辺{endSpan} をチェックしてください。";
	}

	protected override string _GetTemplateForLabelOffline()
	{
		return "オフライン";
	}

	protected override string _GetTemplateForLabelOk()
	{
		return "OK";
	}

	protected override string _GetTemplateForLabelOnline()
	{
		return "オンライン";
	}

	protected override string _GetTemplateForLabelRequests()
	{
		return "リクエスト";
	}

	protected override string _GetTemplateForLabelSearchFriends()
	{
		return "友達を検索";
	}

	protected override string _GetTemplateForLabelUnfollowed()
	{
		return "フォローをやめました";
	}

	protected override string _GetTemplateForMessageActionNotAllowedError()
	{
		return "アクションが許可されていません";
	}

	protected override string _GetTemplateForMessageAlreadyExistsError()
	{
		return "すでにあります。";
	}

	protected override string _GetTemplateForMessageCurrentInvalidParametersError()
	{
		return "無効なパラメータです。";
	}

	protected override string _GetTemplateForMessageCurrentUserFriendsLimitExceededError()
	{
		return "友達の数が上限を超えました。友達リクエストを承認する前に、ほかの友達を削除してください。";
	}

	protected override string _GetTemplateForMessageDefaultError()
	{
		return "エラーが発生しました。";
	}

	protected override string _GetTemplateForMessageFloodLimitExceededError()
	{
		return "この操作を何度も実行しています。1分ほど待ってからやり直してください。";
	}

	protected override string _GetTemplateForMessageFollowerTabTooltip()
	{
		return "あなたのアクティビティをフォローしているユーザー。";
	}

	protected override string _GetTemplateForMessageFollowingTabTooltip()
	{
		return "あなたがアクティビティをフォローしているユーザー。";
	}

	protected override string _GetTemplateForMessageForGeneralError()
	{
		return "問題が発生しました。";
	}

	protected override string _GetTemplateForMessageForGeneralFooter()
	{
		return "しばらくしてからもう一度お試しください。";
	}

	protected override string _GetTemplateForMessageForMaxFriendsError()
	{
		return "リクエストを処理できません。現在、登録できる友達の数が上限に達しています。 ";
	}

	protected override string _GetTemplateForMessageForMaxFriendsFooter()
	{
		return "これ以上の友達リクエストを承認するには、誰かを友達解除してください。";
	}

	protected override string _GetTemplateForMessageForMaxRequestsError()
	{
		return "リクエストを処理できません。現在、そのユーザーは登録できる友達の数が上限に達しています。";
	}

	protected override string _GetTemplateForMessageForMaxRequestsFooter()
	{
		return "ほかの友達を削除するまで、新しい友達リクエストを承認できません。";
	}

	protected override string _GetTemplateForMessageFriendRequestNotExistError()
	{
		return "友達リクエストが存在しません";
	}

	protected override string _GetTemplateForMessageFriendsLimitExceededError()
	{
		return "友達の数が上限を超えました。";
	}

	protected override string _GetTemplateForMessageFriendsTabTooltip()
	{
		return "Robloxのユーザー二人がお互いに同意すれば、友達になれます。";
	}

	protected override string _GetTemplateForMessageNotRecipientError()
	{
		return "この友達リクエストは、あなた宛てではありません。";
	}

	protected override string _GetTemplateForMessageOtherUserFriendsLimitExceededError()
	{
		return "友達の数が上限を超えました。";
	}

	protected override string _GetTemplateForMessageRequestsTabTooltip()
	{
		return "Robloxのユーザー二人がお互いに同意すれば、友達になれます。";
	}

	protected override string _GetTemplateForMessageRobloxIsMoreFunWithFriends()
	{
		return "Robloxは、友達と一緒にプレイすれば、もっとお楽しみいただけます！";
	}

	protected override string _GetTemplateForMessageSelfFollowingAttemptError()
	{
		return "自分をフォローすることはできません。";
	}

	protected override string _GetTemplateForMessageSelfFriendingAttemptError()
	{
		return "自分と友達になることはできません。";
	}

	protected override string _GetTemplateForMessageSystemUnavailableError()
	{
		return "友達およびフォロワーのシステムは利用できません。";
	}

	protected override string _GetTemplateForMessageUnblockUserPinLockedError()
	{
		return "PINはロックされています。";
	}

	protected override string _GetTemplateForMessageUserBlockedError()
	{
		return "ユーザーはブロックされています";
	}

	protected override string _GetTemplateForMessageUserHasNotPassedCaptchaError()
	{
		return "キャプチャを完了する必要があります。";
	}

	protected override string _GetTemplateForMessageUsersAreNotInSameGameError()
	{
		return "ユーザーが同じゲーム内にいる必要があります。";
	}
}
