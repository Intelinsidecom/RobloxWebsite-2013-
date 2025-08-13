namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides ProfileResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ProfileResources_ko_kr : ProfileResources_en_us, IProfileResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Accept"
	/// English String: "Accept"
	/// </summary>
	public override string ActionAccept => "수락";

	/// <summary>
	/// Key: "Action.AddFriend"
	/// English String: "Add Friend"
	/// </summary>
	public override string ActionAddFriend => "친구 추가";

	/// <summary>
	/// Key: "Action.BlockUser"
	/// English String: "Block User"
	/// </summary>
	public override string ActionBlockUser => "사용자 차단";

	/// <summary>
	/// Key: "Action.CancelBlockUser"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancelBlockUser => "취소";

	/// <summary>
	/// Key: "Action.Chat"
	/// English String: "Chat"
	/// </summary>
	public override string ActionChat => "채팅";

	/// <summary>
	/// Key: "Action.Close"
	/// close modal
	/// English String: "Close"
	/// </summary>
	public override string ActionClose => "닫기";

	/// <summary>
	/// Key: "Action.ConfirmBlockUser"
	/// English String: "Block"
	/// </summary>
	public override string ActionConfirmBlockUser => "차단";

	/// <summary>
	/// Key: "Action.ConfirmUnblockUser"
	/// English String: "Unblock"
	/// </summary>
	public override string ActionConfirmUnblockUser => "차단 해제";

	/// <summary>
	/// Key: "Action.Favorites"
	/// English String: "Favorites"
	/// </summary>
	public override string ActionFavorites => "즐겨찾기";

	/// <summary>
	/// Key: "Action.Follow"
	/// English String: "Follow"
	/// </summary>
	public override string ActionFollow => "팔로우";

	/// <summary>
	/// Key: "Action.GridView"
	/// English String: "Grid View"
	/// </summary>
	public override string ActionGridView => "격자 보기";

	/// <summary>
	/// Key: "Action.ImpersonateUser"
	/// English String: "Impersonate User"
	/// </summary>
	public override string ActionImpersonateUser => "사용자 사칭";

	/// <summary>
	/// Key: "Action.Inventory"
	/// English String: "Inventory"
	/// </summary>
	public override string ActionInventory => "인벤토리";

	/// <summary>
	/// Key: "Action.JoinGame"
	/// English String: "Join Game"
	/// </summary>
	public override string ActionJoinGame => "게임 참가";

	/// <summary>
	/// Key: "Action.Message"
	/// English String: "Message"
	/// </summary>
	public override string ActionMessage => "메시지";

	/// <summary>
	/// Key: "Action.Pending"
	/// English String: "Pending"
	/// </summary>
	public override string ActionPending => "대기 중";

	/// <summary>
	/// Key: "Action.Save"
	/// English String: "Save"
	/// </summary>
	public override string ActionSave => "저장";

	/// <summary>
	/// Key: "Action.SeeAll"
	/// English String: "See All"
	/// </summary>
	public override string ActionSeeAll => "전체 보기";

	/// <summary>
	/// Key: "Action.SeeLess"
	/// English String: "See Less"
	/// </summary>
	public override string ActionSeeLess => "간략히 보기";

	/// <summary>
	/// Key: "Action.SeeMore"
	/// English String: "See More"
	/// </summary>
	public override string ActionSeeMore => "더 보기";

	/// <summary>
	/// Key: "Action.SlideshowView"
	/// English String: "Slideshow View"
	/// </summary>
	public override string ActionSlideshowView => "슬라이드쇼 보기";

	/// <summary>
	/// Key: "Action.Trade"
	/// English String: "Trade"
	/// </summary>
	public override string ActionTrade => "거래";

	/// <summary>
	/// Key: "Action.TradeItems"
	/// English String: "Trade Items"
	/// </summary>
	public override string ActionTradeItems => "아이템 거래";

	/// <summary>
	/// Key: "Action.UnblockUser"
	/// English String: "Unblock User"
	/// </summary>
	public override string ActionUnblockUser => "사용자 차단 해제";

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
	/// Key: "Action.UpdateStatus"
	/// English String: "Update Status"
	/// </summary>
	public override string ActionUpdateStatus => "상태 업데이트";

	/// <summary>
	/// Key: "Description.BlockUserFooter"
	/// English String: "When you've blocked a user, neither of you can directly contact the other."
	/// </summary>
	public override string DescriptionBlockUserFooter => "사용자를 차단하면 해당 사용자와 서로 연락할 수 없습니다.";

	/// <summary>
	/// Key: "Description.BlockUserPrompt"
	/// English String: "Are you sure you want to block this user?"
	/// </summary>
	public override string DescriptionBlockUserPrompt => "본 사용자를 정말 차단할까요?";

	/// <summary>
	/// Key: "Description.ChangeAlias"
	/// English String: "Only you can see this information"
	/// </summary>
	public override string DescriptionChangeAlias => "오직 나만 이 정보를 볼 수 있어요";

	/// <summary>
	/// Key: "Description.UnblockUserPrompt"
	/// English String: "Are you sure you want to unblock this user?"
	/// </summary>
	public override string DescriptionUnblockUserPrompt => "본 사용자를 정말 차단 해제할까요?";

	/// <summary>
	/// Key: "Heading.AboutTab"
	/// this is for the heading under About tab on profile page
	/// English String: "About"
	/// </summary>
	public override string HeadingAboutTab => "소개";

	/// <summary>
	/// Key: "Heading.BlockUserTitle"
	/// English String: "Warning"
	/// </summary>
	public override string HeadingBlockUserTitle => "주의";

	/// <summary>
	/// Key: "Heading.Collections"
	/// English String: "Collections"
	/// </summary>
	public override string HeadingCollections => "컬렉션";

	/// <summary>
	/// Key: "Heading.CurrentlyWearing"
	/// English String: "Currently Wearing"
	/// </summary>
	public override string HeadingCurrentlyWearing => "현재 착용 중";

	/// <summary>
	/// Key: "Heading.FavoriteGames"
	/// English String: "Favorites"
	/// </summary>
	public override string HeadingFavoriteGames => "즐겨찾기";

	/// <summary>
	/// Key: "Heading.Friends"
	/// English String: "Friends"
	/// </summary>
	public override string HeadingFriends => "친구";

	/// <summary>
	/// Key: "Heading.Games"
	/// English String: "Games"
	/// </summary>
	public override string HeadingGames => "게임";

	/// <summary>
	/// Key: "Heading.GameTitle"
	/// English String: "Games"
	/// </summary>
	public override string HeadingGameTitle => "게임";

	/// <summary>
	/// Key: "Heading.Groups"
	/// English String: "Groups"
	/// </summary>
	public override string HeadingGroups => "그룹";

	/// <summary>
	/// Key: "Heading.PlayerAssetsBadges"
	/// English String: "Player Badges"
	/// </summary>
	public override string HeadingPlayerAssetsBadges => "플레이어 배지";

	/// <summary>
	/// Key: "Heading.PlayerAssetsClothing"
	/// English String: "Clothing"
	/// </summary>
	public override string HeadingPlayerAssetsClothing => "복장";

	/// <summary>
	/// Key: "Heading.PlayerAssetsModels"
	/// English String: "Models"
	/// </summary>
	public override string HeadingPlayerAssetsModels => "모델";

	/// <summary>
	/// Key: "Heading.PlayerBadge"
	/// English String: "Player Badges"
	/// </summary>
	public override string HeadingPlayerBadge => "플레이어 배지";

	/// <summary>
	/// Key: "Heading.Profile"
	/// English String: "Profile"
	/// </summary>
	public override string HeadingProfile => "프로필";

	/// <summary>
	/// Key: "Heading.ProfileGroups"
	/// English String: "Groups"
	/// </summary>
	public override string HeadingProfileGroups => "그룹";

	/// <summary>
	/// Key: "Heading.RobloxBadge"
	/// English String: "Roblox Badges"
	/// </summary>
	public override string HeadingRobloxBadge => "Roblox 배지";

	/// <summary>
	/// Key: "Heading.Statistics"
	/// English String: "Statistics"
	/// </summary>
	public override string HeadingStatistics => "통계";

	/// <summary>
	/// Key: "Label.About"
	/// English String: "About"
	/// </summary>
	public override string LabelAbout => "소개";

	/// <summary>
	/// Key: "Label.Alias"
	/// Friends Tag, nickname
	/// English String: "Alias"
	/// </summary>
	public override string LabelAlias => "닉네임";

	/// <summary>
	/// Key: "Label.BlockWarningBody"
	/// English String: "Are you sure you want to block this user?"
	/// </summary>
	public override string LabelBlockWarningBody => "본 사용자를 정말 차단할까요?";

	/// <summary>
	/// Key: "Label.BlockWarningConfirm"
	/// English String: "Block"
	/// </summary>
	public override string LabelBlockWarningConfirm => "차단";

	/// <summary>
	/// Key: "Label.BlockWarningFooter"
	/// English String: "When you've blocked a user, neither of you can directly contact the other."
	/// </summary>
	public override string LabelBlockWarningFooter => "사용자를 차단하면 해당 사용자와 서로 연락할 수 없습니다.";

	/// <summary>
	/// Key: "Label.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string LabelCancel => "취소";

	/// <summary>
	/// Key: "Label.ChangeAlias"
	/// set nickname
	/// English String: "Set Alias"
	/// </summary>
	public override string LabelChangeAlias => "닉네임 설정";

	/// <summary>
	/// Key: "Label.Creations"
	/// English String: "Creations"
	/// </summary>
	public override string LabelCreations => "작품";

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
	/// Key: "Label.ForumPosts"
	/// English String: "Forum Posts"
	/// </summary>
	public override string LabelForumPosts => "포럼 게시물";

	/// <summary>
	/// Key: "Label.Friends"
	/// English String: "Friends"
	/// </summary>
	public override string LabelFriends => "친구";

	/// <summary>
	/// Key: "Label.GridView"
	/// English String: "Grid View"
	/// </summary>
	public override string LabelGridView => "격자 보기";

	/// <summary>
	/// Key: "Label.JoinDate"
	/// English String: "Join Date"
	/// </summary>
	public override string LabelJoinDate => "가입 날짜";

	/// <summary>
	/// Key: "Label.LoadMore"
	/// English String: "Load More"
	/// </summary>
	public override string LabelLoadMore => "더 불러오기";

	/// <summary>
	/// Key: "Label.Members"
	/// English String: "Members"
	/// </summary>
	public override string LabelMembers => "멤버";

	/// <summary>
	/// Key: "Label.PastUsername"
	/// English String: "Past Usernames"
	/// </summary>
	public override string LabelPastUsername => "이전 사용자 이름";

	/// <summary>
	/// Key: "Label.PastUsernames"
	/// English String: "Past usernames"
	/// </summary>
	public override string LabelPastUsernames => "이전 사용자 이름";

	/// <summary>
	/// Key: "Label.PlaceVisits"
	/// English String: "Place Visits"
	/// </summary>
	public override string LabelPlaceVisits => "장소 방문";

	/// <summary>
	/// Key: "Label.Playing"
	/// English String: "Playing"
	/// </summary>
	public override string LabelPlaying => "플레이 중";

	/// <summary>
	/// Key: "Label.Rank"
	/// English String: "Rank"
	/// </summary>
	public override string LabelRank => "등급";

	/// <summary>
	/// Key: "Label.ReadMore"
	/// English String: "Read More"
	/// </summary>
	public override string LabelReadMore => "더 보기";

	/// <summary>
	/// Key: "Label.ReportAbuse"
	/// English String: "Report Abuse"
	/// </summary>
	public override string LabelReportAbuse => "신고하기";

	/// <summary>
	/// Key: "Label.ShowLess"
	/// English String: "Show Less"
	/// </summary>
	public override string LabelShowLess => "간략히 보기";

	/// <summary>
	/// Key: "Label.SlideshowView"
	/// English String: "Slideshow View"
	/// </summary>
	public override string LabelSlideshowView => "슬라이드쇼 보기";

	/// <summary>
	/// Key: "Label.UnblockWarningBody"
	/// English String: "Are you sure you want to unblock this user?"
	/// </summary>
	public override string LabelUnblockWarningBody => "본 사용자를 정말 차단 해제할까요?";

	/// <summary>
	/// Key: "Label.UnblockWarningConfirm"
	/// English String: "Unblock"
	/// </summary>
	public override string LabelUnblockWarningConfirm => "차단 해제";

	/// <summary>
	/// Key: "Label.Visits"
	/// English String: "Visits"
	/// </summary>
	public override string LabelVisits => "방문";

	/// <summary>
	/// Key: "Label.WarningTitle"
	/// English String: "Warning"
	/// </summary>
	public override string LabelWarningTitle => "주의";

	/// <summary>
	/// Key: "Message.AliasHasError"
	/// English String: "An error has occurred. Please try again later"
	/// </summary>
	public override string MessageAliasHasError => "오류가 발생했어요. 나중에 다시 시도하세요";

	/// <summary>
	/// Key: "Message.AliasIsModerated"
	/// English String: "Please avoid using full names or offensive language."
	/// </summary>
	public override string MessageAliasIsModerated => "실명이나 공격적인 언어를 사용하지 마세요.";

	/// <summary>
	/// Key: "Message.ChangeStatus"
	/// English String: "What are you up to?"
	/// </summary>
	public override string MessageChangeStatus => "무엇을 하고 싶나요?";

	/// <summary>
	/// Key: "Message.ErrorBlockLimit"
	/// English String: "Operation failed! You may have blocked too many people."
	/// </summary>
	public override string MessageErrorBlockLimit => "작업 실패! 차단한 사용자가 너무 많아요.";

	/// <summary>
	/// Key: "Message.ErrorGeneral"
	/// English String: "Something went wrong. Please check back in a few minutes."
	/// </summary>
	public override string MessageErrorGeneral => "오류가 발생했어요. 몇 분 후 다시 확인해보세요.";

	/// <summary>
	/// Key: "Message.Sharing"
	/// English String: "Sharing..."
	/// </summary>
	public override string MessageSharing => "공유 중...";

	/// <summary>
	/// Key: "Response.TooManyAttempts"
	/// flood error response
	/// English String: "Too Many Attempts"
	/// </summary>
	public override string ResponseTooManyAttempts => "시도 가능 횟수를 초과했습니다";

	public ProfileResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAccept()
	{
		return "수락";
	}

	protected override string _GetTemplateForActionAddFriend()
	{
		return "친구 추가";
	}

	protected override string _GetTemplateForActionBlockUser()
	{
		return "사용자 차단";
	}

	protected override string _GetTemplateForActionCancelBlockUser()
	{
		return "취소";
	}

	protected override string _GetTemplateForActionChat()
	{
		return "채팅";
	}

	protected override string _GetTemplateForActionClose()
	{
		return "닫기";
	}

	protected override string _GetTemplateForActionConfirmBlockUser()
	{
		return "차단";
	}

	protected override string _GetTemplateForActionConfirmUnblockUser()
	{
		return "차단 해제";
	}

	protected override string _GetTemplateForActionFavorites()
	{
		return "즐겨찾기";
	}

	protected override string _GetTemplateForActionFollow()
	{
		return "팔로우";
	}

	protected override string _GetTemplateForActionGridView()
	{
		return "격자 보기";
	}

	protected override string _GetTemplateForActionImpersonateUser()
	{
		return "사용자 사칭";
	}

	protected override string _GetTemplateForActionInventory()
	{
		return "인벤토리";
	}

	protected override string _GetTemplateForActionJoinGame()
	{
		return "게임 참가";
	}

	protected override string _GetTemplateForActionMessage()
	{
		return "메시지";
	}

	protected override string _GetTemplateForActionPending()
	{
		return "대기 중";
	}

	protected override string _GetTemplateForActionSave()
	{
		return "저장";
	}

	protected override string _GetTemplateForActionSeeAll()
	{
		return "전체 보기";
	}

	protected override string _GetTemplateForActionSeeLess()
	{
		return "간략히 보기";
	}

	protected override string _GetTemplateForActionSeeMore()
	{
		return "더 보기";
	}

	protected override string _GetTemplateForActionSlideshowView()
	{
		return "슬라이드쇼 보기";
	}

	protected override string _GetTemplateForActionTrade()
	{
		return "거래";
	}

	protected override string _GetTemplateForActionTradeItems()
	{
		return "아이템 거래";
	}

	protected override string _GetTemplateForActionUnblockUser()
	{
		return "사용자 차단 해제";
	}

	protected override string _GetTemplateForActionUnfollow()
	{
		return "팔로우 취소";
	}

	protected override string _GetTemplateForActionUnfriend()
	{
		return "친구 끊기";
	}

	protected override string _GetTemplateForActionUpdateStatus()
	{
		return "상태 업데이트";
	}

	protected override string _GetTemplateForDescriptionBlockUserFooter()
	{
		return "사용자를 차단하면 해당 사용자와 서로 연락할 수 없습니다.";
	}

	protected override string _GetTemplateForDescriptionBlockUserPrompt()
	{
		return "본 사용자를 정말 차단할까요?";
	}

	protected override string _GetTemplateForDescriptionChangeAlias()
	{
		return "오직 나만 이 정보를 볼 수 있어요";
	}

	protected override string _GetTemplateForDescriptionUnblockUserPrompt()
	{
		return "본 사용자를 정말 차단 해제할까요?";
	}

	protected override string _GetTemplateForHeadingAboutTab()
	{
		return "소개";
	}

	protected override string _GetTemplateForHeadingBlockUserTitle()
	{
		return "주의";
	}

	protected override string _GetTemplateForHeadingCollections()
	{
		return "컬렉션";
	}

	protected override string _GetTemplateForHeadingCurrentlyWearing()
	{
		return "현재 착용 중";
	}

	protected override string _GetTemplateForHeadingFavoriteGames()
	{
		return "즐겨찾기";
	}

	protected override string _GetTemplateForHeadingFriends()
	{
		return "친구";
	}

	/// <summary>
	/// Key: "Heading.FriendsNum"
	/// English String: "Friends ({friendsCount})"
	/// </summary>
	public override string HeadingFriendsNum(string friendsCount)
	{
		return $"친구 ({friendsCount}명)";
	}

	protected override string _GetTemplateForHeadingFriendsNum()
	{
		return "친구 ({friendsCount}명)";
	}

	protected override string _GetTemplateForHeadingGames()
	{
		return "게임";
	}

	protected override string _GetTemplateForHeadingGameTitle()
	{
		return "게임";
	}

	protected override string _GetTemplateForHeadingGroups()
	{
		return "그룹";
	}

	protected override string _GetTemplateForHeadingPlayerAssetsBadges()
	{
		return "플레이어 배지";
	}

	protected override string _GetTemplateForHeadingPlayerAssetsClothing()
	{
		return "복장";
	}

	protected override string _GetTemplateForHeadingPlayerAssetsModels()
	{
		return "모델";
	}

	protected override string _GetTemplateForHeadingPlayerBadge()
	{
		return "플레이어 배지";
	}

	protected override string _GetTemplateForHeadingProfile()
	{
		return "프로필";
	}

	protected override string _GetTemplateForHeadingProfileGroups()
	{
		return "그룹";
	}

	protected override string _GetTemplateForHeadingRobloxBadge()
	{
		return "Roblox 배지";
	}

	protected override string _GetTemplateForHeadingStatistics()
	{
		return "통계";
	}

	protected override string _GetTemplateForLabelAbout()
	{
		return "소개";
	}

	protected override string _GetTemplateForLabelAlias()
	{
		return "닉네임";
	}

	protected override string _GetTemplateForLabelBlockWarningBody()
	{
		return "본 사용자를 정말 차단할까요?";
	}

	protected override string _GetTemplateForLabelBlockWarningConfirm()
	{
		return "차단";
	}

	protected override string _GetTemplateForLabelBlockWarningFooter()
	{
		return "사용자를 차단하면 해당 사용자와 서로 연락할 수 없습니다.";
	}

	protected override string _GetTemplateForLabelCancel()
	{
		return "취소";
	}

	protected override string _GetTemplateForLabelChangeAlias()
	{
		return "닉네임 설정";
	}

	protected override string _GetTemplateForLabelCreations()
	{
		return "작품";
	}

	protected override string _GetTemplateForLabelFollowers()
	{
		return "팔로워";
	}

	protected override string _GetTemplateForLabelFollowing()
	{
		return "팔로잉";
	}

	protected override string _GetTemplateForLabelForumPosts()
	{
		return "포럼 게시물";
	}

	protected override string _GetTemplateForLabelFriends()
	{
		return "친구";
	}

	protected override string _GetTemplateForLabelGridView()
	{
		return "격자 보기";
	}

	protected override string _GetTemplateForLabelJoinDate()
	{
		return "가입 날짜";
	}

	protected override string _GetTemplateForLabelLoadMore()
	{
		return "더 불러오기";
	}

	protected override string _GetTemplateForLabelMembers()
	{
		return "멤버";
	}

	protected override string _GetTemplateForLabelPastUsername()
	{
		return "이전 사용자 이름";
	}

	protected override string _GetTemplateForLabelPastUsernames()
	{
		return "이전 사용자 이름";
	}

	protected override string _GetTemplateForLabelPlaceVisits()
	{
		return "장소 방문";
	}

	protected override string _GetTemplateForLabelPlaying()
	{
		return "플레이 중";
	}

	/// <summary>
	/// Key: "Label.Quotation"
	/// You only need to localize the quotation mark, e.g. 「{userStatus}」
	/// English String: "\"{userStatus}\""
	/// </summary>
	public override string LabelQuotation(string userStatus)
	{
		return $"'{userStatus}'";
	}

	protected override string _GetTemplateForLabelQuotation()
	{
		return "'{userStatus}'";
	}

	protected override string _GetTemplateForLabelRank()
	{
		return "등급";
	}

	protected override string _GetTemplateForLabelReadMore()
	{
		return "더 보기";
	}

	protected override string _GetTemplateForLabelReportAbuse()
	{
		return "신고하기";
	}

	protected override string _GetTemplateForLabelShowLess()
	{
		return "간략히 보기";
	}

	protected override string _GetTemplateForLabelSlideshowView()
	{
		return "슬라이드쇼 보기";
	}

	protected override string _GetTemplateForLabelUnblockWarningBody()
	{
		return "본 사용자를 정말 차단 해제할까요?";
	}

	protected override string _GetTemplateForLabelUnblockWarningConfirm()
	{
		return "차단 해제";
	}

	protected override string _GetTemplateForLabelVisits()
	{
		return "방문";
	}

	protected override string _GetTemplateForLabelWarningTitle()
	{
		return "주의";
	}

	protected override string _GetTemplateForMessageAliasHasError()
	{
		return "오류가 발생했어요. 나중에 다시 시도하세요";
	}

	protected override string _GetTemplateForMessageAliasIsModerated()
	{
		return "실명이나 공격적인 언어를 사용하지 마세요.";
	}

	protected override string _GetTemplateForMessageChangeStatus()
	{
		return "무엇을 하고 싶나요?";
	}

	protected override string _GetTemplateForMessageErrorBlockLimit()
	{
		return "작업 실패! 차단한 사용자가 너무 많아요.";
	}

	protected override string _GetTemplateForMessageErrorGeneral()
	{
		return "오류가 발생했어요. 몇 분 후 다시 확인해보세요.";
	}

	/// <summary>
	/// Key: "Message.NoCreation"
	/// English String: "{username} has no creations."
	/// </summary>
	public override string MessageNoCreation(string username)
	{
		return $"{username}님의 작품이 없습니다.";
	}

	protected override string _GetTemplateForMessageNoCreation()
	{
		return "{username}님의 작품이 없습니다.";
	}

	protected override string _GetTemplateForMessageSharing()
	{
		return "공유 중...";
	}

	protected override string _GetTemplateForResponseTooManyAttempts()
	{
		return "시도 가능 횟수를 초과했습니다";
	}
}
