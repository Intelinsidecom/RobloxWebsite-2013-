namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides FriendsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class FriendsResources_ko_kr : FriendsResources_en_us, IFriendsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Accept"
	/// English String: "Accept"
	/// </summary>
	public override string ActionAccept => "수락";

	/// <summary>
	/// Key: "Action.FindFriends"
	/// English String: "Find Friends"
	/// </summary>
	public override string ActionFindFriends => "친구 찾기";

	/// <summary>
	/// Key: "Action.Follow"
	/// English String: "Follow"
	/// </summary>
	public override string ActionFollow => "팔로우";

	/// <summary>
	/// Key: "Action.Ignore"
	/// English String: "Ignore"
	/// </summary>
	public override string ActionIgnore => "거절";

	/// <summary>
	/// Key: "Action.IgnoreAll"
	/// English String: "Ignore All"
	/// </summary>
	public override string ActionIgnoreAll => "전체 거절";

	/// <summary>
	/// Key: "Action.Unfollow"
	/// English String: "Unfollow"
	/// </summary>
	public override string ActionUnfollow => "팔로우 취소";

	/// <summary>
	/// Key: "Action.Unfriend"
	/// English String: "Unfriend"
	/// </summary>
	public override string ActionUnfriend => "친구 끊기";

	/// <summary>
	/// Key: "Heading.MyFriends"
	/// English String: "My Friends"
	/// </summary>
	public override string HeadingMyFriends => "내 친구";

	/// <summary>
	/// Key: "Label.ErrorTitle"
	/// English String: "Error"
	/// </summary>
	public override string LabelErrorTitle => "오류";

	/// <summary>
	/// Key: "Label.Followers"
	/// English String: "Followers"
	/// </summary>
	public override string LabelFollowers => "팔로워";

	/// <summary>
	/// Key: "Label.Following"
	/// English String: "Following"
	/// </summary>
	public override string LabelFollowing => "팔로잉";

	/// <summary>
	/// Key: "Label.FriendRequests"
	/// English String: "Friend Requests"
	/// </summary>
	public override string LabelFriendRequests => "친구 요청";

	/// <summary>
	/// Key: "Label.Friends"
	/// English String: "Friends"
	/// </summary>
	public override string LabelFriends => "친구";

	/// <summary>
	/// Key: "Label.Offline"
	/// English String: "Offline"
	/// </summary>
	public override string LabelOffline => "오프라인";

	/// <summary>
	/// Key: "Label.Ok"
	/// English String: "Ok"
	/// </summary>
	public override string LabelOk => "확인";

	/// <summary>
	/// Key: "Label.Online"
	/// English String: "Online"
	/// </summary>
	public override string LabelOnline => "온라인";

	/// <summary>
	/// Key: "Label.Requests"
	/// English String: "Requests"
	/// </summary>
	public override string LabelRequests => "요청";

	/// <summary>
	/// Key: "Label.SearchFriends"
	/// When user doesn't have any friends.
	/// English String: "Search for Friends"
	/// </summary>
	public override string LabelSearchFriends => "친구 검색";

	/// <summary>
	/// Key: "Label.Unfollowed"
	/// Unfollowed
	/// English String: "Unfollowed"
	/// </summary>
	public override string LabelUnfollowed => "팔로우 취소됨";

	/// <summary>
	/// Key: "Message.ActionNotAllowedError"
	/// English String: "Action not allowed"
	/// </summary>
	public override string MessageActionNotAllowedError => "허용되지 않은 작업";

	/// <summary>
	/// Key: "Message.AlreadyExistsError"
	/// English String: "Already exists."
	/// </summary>
	public override string MessageAlreadyExistsError => "이미 있어요.";

	/// <summary>
	/// Key: "Message.CurrentInvalidParametersError"
	/// English String: "Invalid parameters."
	/// </summary>
	public override string MessageCurrentInvalidParametersError => "유효하지 않은 매개변수.";

	/// <summary>
	/// Key: "Message.CurrentUserFriendsLimitExceededError"
	/// English String: "You have reached the maximum number of Friends. Please remove a Friend before accepting any more Friend Requests."
	/// </summary>
	public override string MessageCurrentUserFriendsLimitExceededError => "친구 수가 한도에 도달했어요. 친구 요청을 더 받으려면 먼저 다른 분과 친구를 끊으셔야 합니다.";

	/// <summary>
	/// Key: "Message.DefaultError"
	/// English String: "An error ocurred."
	/// </summary>
	public override string MessageDefaultError => "오류가 발생했어요.";

	/// <summary>
	/// Key: "Message.FloodLimitExceededError"
	/// English String: "You are performing this action too often. Please wait a minute and try again."
	/// </summary>
	public override string MessageFloodLimitExceededError => "같은 작업을 너무 자주 반복하셨네요. 잠시 기다렸다가 다시 시도하세요.";

	/// <summary>
	/// Key: "Message.FollowerTabTooltip"
	/// English String: "People who have chosen to follow your activity."
	/// </summary>
	public override string MessageFollowerTabTooltip => "회원님을 팔로우하는 사람들이에요.";

	/// <summary>
	/// Key: "Message.FollowingTabTooltip"
	/// English String: "People whose activity you have chosen to follow."
	/// </summary>
	public override string MessageFollowingTabTooltip => "회원님이 팔로우하는 사람들이에요.";

	/// <summary>
	/// Key: "Message.ForGeneralError"
	/// English String: "Something went wrong."
	/// </summary>
	public override string MessageForGeneralError => "오류가 발생했어요.";

	/// <summary>
	/// Key: "Message.ForGeneralFooter"
	/// English String: "Please check back in few minutes."
	/// </summary>
	public override string MessageForGeneralFooter => "몇 분 후 다시 확인하세요.";

	/// <summary>
	/// Key: "Message.ForMaxFriendsError"
	/// English String: "Unable to process Request.You currently have the max number of Friends allowed. "
	/// </summary>
	public override string MessageForMaxFriendsError => "요청 처리 불가. 친구 수가 한도에 도달했어요. ";

	/// <summary>
	/// Key: "Message.ForMaxFriendsFooter"
	/// English String: "Unfriend someone before accepting any more Friend Requests."
	/// </summary>
	public override string MessageForMaxFriendsFooter => "친구 요청을 더 받고 싶으시면 먼저 다른 분과 친구 끊기를 해야 합니다.";

	/// <summary>
	/// Key: "Message.ForMaxRequestsError"
	/// English String: "Unable to process Request. That user currently has the max number of Friends allowed."
	/// </summary>
	public override string MessageForMaxRequestsError => "요청 처리 불가. 해당 사용자가 등록한 친구 수가 한도에 도달했어요.";

	/// <summary>
	/// Key: "Message.ForMaxRequestsFooter"
	/// English String: "You can not accept their Friend Request until they remove a Friend."
	/// </summary>
	public override string MessageForMaxRequestsFooter => "친구 요청을 수락하려면 먼저 상대방이 친구를 삭제해야 합니다.";

	/// <summary>
	/// Key: "Message.FriendRequestNotExistError"
	/// English String: "Friend request does not exist"
	/// </summary>
	public override string MessageFriendRequestNotExistError => "친구 요청이 없어요";

	/// <summary>
	/// Key: "Message.FriendsLimitExceededError"
	/// English String: "Friends limit exceeded."
	/// </summary>
	public override string MessageFriendsLimitExceededError => "친구 수가 한도에 도달했어요.";

	/// <summary>
	/// Key: "Message.FriendsTabTooltip"
	/// English String: "Friends are established when two Roblox users mutually agree to friendship."
	/// </summary>
	public override string MessageFriendsTabTooltip => "Roblox 사용자 두 명이 서로 친구 맺기에 동의해야 친구 관계가 성립됩니다.";

	/// <summary>
	/// Key: "Message.NotRecipientError"
	/// English String: "You are not the recipient of this friend request."
	/// </summary>
	public override string MessageNotRecipientError => "회원님은 본 친구 요청의 수신자가 아닙니다.";

	/// <summary>
	/// Key: "Message.OtherUserFriendsLimitExceededError"
	/// English String: "Friends limit exceeded."
	/// </summary>
	public override string MessageOtherUserFriendsLimitExceededError => "친구 수가 한도를 초과했어요.";

	/// <summary>
	/// Key: "Message.RequestsTabTooltip"
	/// English String: "Friends are established when two Roblox users mutually agree to friendship."
	/// </summary>
	public override string MessageRequestsTabTooltip => "Roblox 사용자 두 명이 서로 친구 맺기에 동의해야 친구 관계가 성립됩니다.";

	/// <summary>
	/// Key: "Message.RobloxIsMoreFunWithFriends"
	/// English String: "Roblox is more fun with friends!"
	/// </summary>
	public override string MessageRobloxIsMoreFunWithFriends => "친구와 함께할 때 더욱 즐거운 Roblox!";

	/// <summary>
	/// Key: "Message.SelfFollowingAttemptError"
	/// English String: "You cannot follow yourself."
	/// </summary>
	public override string MessageSelfFollowingAttemptError => "자기 자신을 팔로우할 수 없어요.";

	/// <summary>
	/// Key: "Message.SelfFriendingAttemptError"
	/// English String: "You cannot be friends with yourself."
	/// </summary>
	public override string MessageSelfFriendingAttemptError => "자기 자신과는 친구를 맺을 수 없어요.";

	/// <summary>
	/// Key: "Message.SystemUnavailableError"
	/// English String: "Friends and Followers system is unavailable."
	/// </summary>
	public override string MessageSystemUnavailableError => "친구 및 팔로워 시스템을 이용할 수 없어요.";

	/// <summary>
	/// Key: "Message.UnblockUserPinLockedError"
	/// English String: "Pin is locked."
	/// </summary>
	public override string MessageUnblockUserPinLockedError => "PIN 사용이 중지되었습니다.";

	/// <summary>
	/// Key: "Message.UserBlockedError"
	/// English String: "User is blocked"
	/// </summary>
	public override string MessageUserBlockedError => "차단된 사용자입니다";

	/// <summary>
	/// Key: "Message.UserHasNotPassedCaptchaError"
	/// English String: "You need to pass Captcha."
	/// </summary>
	public override string MessageUserHasNotPassedCaptchaError => "보안 문자 입력을 통과해야 해요.";

	/// <summary>
	/// Key: "Message.UsersAreNotInSameGameError"
	/// English String: "Users need to be in the same game."
	/// </summary>
	public override string MessageUsersAreNotInSameGameError => "사용자들이 같은 게임에 참여해야 해요.";

	public FriendsResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAccept()
	{
		return "수락";
	}

	protected override string _GetTemplateForActionFindFriends()
	{
		return "친구 찾기";
	}

	protected override string _GetTemplateForActionFollow()
	{
		return "팔로우";
	}

	protected override string _GetTemplateForActionIgnore()
	{
		return "거절";
	}

	protected override string _GetTemplateForActionIgnoreAll()
	{
		return "전체 거절";
	}

	protected override string _GetTemplateForActionUnfollow()
	{
		return "팔로우 취소";
	}

	protected override string _GetTemplateForActionUnfriend()
	{
		return "친구 끊기";
	}

	/// <summary>
	/// Key: "Description.SearchFriends"
	/// When user doesn't have friends, this suggestive text will show up.
	/// English String: "Tap the magnifying glass icon above and search for a user or {startLink}play games{endLink} to meet people."
	/// </summary>
	public override string DescriptionSearchFriends(string startLink, string endLink)
	{
		return $"상단의 돋보기 아이콘을 눌러 사용자를 검색하거나 {startLink}게임 플레이{endLink}를 하면서 사람들을 만나보세요.";
	}

	protected override string _GetTemplateForDescriptionSearchFriends()
	{
		return "상단의 돋보기 아이콘을 눌러 사용자를 검색하거나 {startLink}게임 플레이{endLink}를 하면서 사람들을 만나보세요.";
	}

	protected override string _GetTemplateForHeadingMyFriends()
	{
		return "내 친구";
	}

	/// <summary>
	/// Key: "Heading.UsersFriends"
	/// English String: "{username}'s Friends"
	/// </summary>
	public override string HeadingUsersFriends(string username)
	{
		return $"{username}님의 친구";
	}

	protected override string _GetTemplateForHeadingUsersFriends()
	{
		return "{username}님의 친구";
	}

	protected override string _GetTemplateForLabelErrorTitle()
	{
		return "오류";
	}

	protected override string _GetTemplateForLabelFollowers()
	{
		return "팔로워";
	}

	protected override string _GetTemplateForLabelFollowing()
	{
		return "팔로잉";
	}

	protected override string _GetTemplateForLabelFriendRequests()
	{
		return "친구 요청";
	}

	protected override string _GetTemplateForLabelFriends()
	{
		return "친구";
	}

	/// <summary>
	/// Key: "Label.NearbyUpsell"
	/// Shown when a user is on the Universal Friend Finder page and has no friend requests. This tells them to try another feature to find friends called "Nearby"
	/// English String: "You have no pending friend requests. To add friends, check out {startSpan}Nearby{endSpan}."
	/// </summary>
	public override string LabelNearbyUpsell(string startSpan, string endSpan)
	{
		return $"대기 중인 친구 요청이 없습니다. 친구를 추가하려면, {startSpan}주변 플레이어 찾기{endSpan}를 살펴보세요.";
	}

	protected override string _GetTemplateForLabelNearbyUpsell()
	{
		return "대기 중인 친구 요청이 없습니다. 친구를 추가하려면, {startSpan}주변 플레이어 찾기{endSpan}를 살펴보세요.";
	}

	protected override string _GetTemplateForLabelOffline()
	{
		return "오프라인";
	}

	protected override string _GetTemplateForLabelOk()
	{
		return "확인";
	}

	protected override string _GetTemplateForLabelOnline()
	{
		return "온라인";
	}

	protected override string _GetTemplateForLabelRequests()
	{
		return "요청";
	}

	protected override string _GetTemplateForLabelSearchFriends()
	{
		return "친구 검색";
	}

	protected override string _GetTemplateForLabelUnfollowed()
	{
		return "팔로우 취소됨";
	}

	protected override string _GetTemplateForMessageActionNotAllowedError()
	{
		return "허용되지 않은 작업";
	}

	protected override string _GetTemplateForMessageAlreadyExistsError()
	{
		return "이미 있어요.";
	}

	protected override string _GetTemplateForMessageCurrentInvalidParametersError()
	{
		return "유효하지 않은 매개변수.";
	}

	protected override string _GetTemplateForMessageCurrentUserFriendsLimitExceededError()
	{
		return "친구 수가 한도에 도달했어요. 친구 요청을 더 받으려면 먼저 다른 분과 친구를 끊으셔야 합니다.";
	}

	protected override string _GetTemplateForMessageDefaultError()
	{
		return "오류가 발생했어요.";
	}

	protected override string _GetTemplateForMessageFloodLimitExceededError()
	{
		return "같은 작업을 너무 자주 반복하셨네요. 잠시 기다렸다가 다시 시도하세요.";
	}

	protected override string _GetTemplateForMessageFollowerTabTooltip()
	{
		return "회원님을 팔로우하는 사람들이에요.";
	}

	protected override string _GetTemplateForMessageFollowingTabTooltip()
	{
		return "회원님이 팔로우하는 사람들이에요.";
	}

	protected override string _GetTemplateForMessageForGeneralError()
	{
		return "오류가 발생했어요.";
	}

	protected override string _GetTemplateForMessageForGeneralFooter()
	{
		return "몇 분 후 다시 확인하세요.";
	}

	protected override string _GetTemplateForMessageForMaxFriendsError()
	{
		return "요청 처리 불가. 친구 수가 한도에 도달했어요. ";
	}

	protected override string _GetTemplateForMessageForMaxFriendsFooter()
	{
		return "친구 요청을 더 받고 싶으시면 먼저 다른 분과 친구 끊기를 해야 합니다.";
	}

	protected override string _GetTemplateForMessageForMaxRequestsError()
	{
		return "요청 처리 불가. 해당 사용자가 등록한 친구 수가 한도에 도달했어요.";
	}

	protected override string _GetTemplateForMessageForMaxRequestsFooter()
	{
		return "친구 요청을 수락하려면 먼저 상대방이 친구를 삭제해야 합니다.";
	}

	protected override string _GetTemplateForMessageFriendRequestNotExistError()
	{
		return "친구 요청이 없어요";
	}

	protected override string _GetTemplateForMessageFriendsLimitExceededError()
	{
		return "친구 수가 한도에 도달했어요.";
	}

	protected override string _GetTemplateForMessageFriendsTabTooltip()
	{
		return "Roblox 사용자 두 명이 서로 친구 맺기에 동의해야 친구 관계가 성립됩니다.";
	}

	protected override string _GetTemplateForMessageNotRecipientError()
	{
		return "회원님은 본 친구 요청의 수신자가 아닙니다.";
	}

	protected override string _GetTemplateForMessageOtherUserFriendsLimitExceededError()
	{
		return "친구 수가 한도를 초과했어요.";
	}

	protected override string _GetTemplateForMessageRequestsTabTooltip()
	{
		return "Roblox 사용자 두 명이 서로 친구 맺기에 동의해야 친구 관계가 성립됩니다.";
	}

	protected override string _GetTemplateForMessageRobloxIsMoreFunWithFriends()
	{
		return "친구와 함께할 때 더욱 즐거운 Roblox!";
	}

	protected override string _GetTemplateForMessageSelfFollowingAttemptError()
	{
		return "자기 자신을 팔로우할 수 없어요.";
	}

	protected override string _GetTemplateForMessageSelfFriendingAttemptError()
	{
		return "자기 자신과는 친구를 맺을 수 없어요.";
	}

	protected override string _GetTemplateForMessageSystemUnavailableError()
	{
		return "친구 및 팔로워 시스템을 이용할 수 없어요.";
	}

	protected override string _GetTemplateForMessageUnblockUserPinLockedError()
	{
		return "PIN 사용이 중지되었습니다.";
	}

	protected override string _GetTemplateForMessageUserBlockedError()
	{
		return "차단된 사용자입니다";
	}

	protected override string _GetTemplateForMessageUserHasNotPassedCaptchaError()
	{
		return "보안 문자 입력을 통과해야 해요.";
	}

	protected override string _GetTemplateForMessageUsersAreNotInSameGameError()
	{
		return "사용자들이 같은 게임에 참여해야 해요.";
	}
}
