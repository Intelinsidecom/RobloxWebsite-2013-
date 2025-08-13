namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides ProfileResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ProfileResources_ja_jp : ProfileResources_en_us, IProfileResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Accept"
	/// English String: "Accept"
	/// </summary>
	public override string ActionAccept => "承認する";

	/// <summary>
	/// Key: "Action.AddFriend"
	/// English String: "Add Friend"
	/// </summary>
	public override string ActionAddFriend => "友達を追加";

	/// <summary>
	/// Key: "Action.BlockUser"
	/// English String: "Block User"
	/// </summary>
	public override string ActionBlockUser => "ユーザーをブロック";

	/// <summary>
	/// Key: "Action.CancelBlockUser"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancelBlockUser => "キャンセル";

	/// <summary>
	/// Key: "Action.Chat"
	/// English String: "Chat"
	/// </summary>
	public override string ActionChat => "チャット";

	/// <summary>
	/// Key: "Action.Close"
	/// close modal
	/// English String: "Close"
	/// </summary>
	public override string ActionClose => "閉じる";

	/// <summary>
	/// Key: "Action.ConfirmBlockUser"
	/// English String: "Block"
	/// </summary>
	public override string ActionConfirmBlockUser => "ブロック";

	/// <summary>
	/// Key: "Action.ConfirmUnblockUser"
	/// English String: "Unblock"
	/// </summary>
	public override string ActionConfirmUnblockUser => "ブロックを解除";

	/// <summary>
	/// Key: "Action.Favorites"
	/// English String: "Favorites"
	/// </summary>
	public override string ActionFavorites => "お気に入り";

	/// <summary>
	/// Key: "Action.Follow"
	/// English String: "Follow"
	/// </summary>
	public override string ActionFollow => "フォロー";

	/// <summary>
	/// Key: "Action.GridView"
	/// English String: "Grid View"
	/// </summary>
	public override string ActionGridView => "グリッド表示";

	/// <summary>
	/// Key: "Action.ImpersonateUser"
	/// English String: "Impersonate User"
	/// </summary>
	public override string ActionImpersonateUser => "なりすましユーザー";

	/// <summary>
	/// Key: "Action.Inventory"
	/// English String: "Inventory"
	/// </summary>
	public override string ActionInventory => "インベントリ";

	/// <summary>
	/// Key: "Action.JoinGame"
	/// English String: "Join Game"
	/// </summary>
	public override string ActionJoinGame => "ゲームに参加";

	/// <summary>
	/// Key: "Action.Message"
	/// English String: "Message"
	/// </summary>
	public override string ActionMessage => "メッセージ";

	/// <summary>
	/// Key: "Action.Pending"
	/// English String: "Pending"
	/// </summary>
	public override string ActionPending => "保留中です";

	/// <summary>
	/// Key: "Action.Save"
	/// English String: "Save"
	/// </summary>
	public override string ActionSave => "保存";

	/// <summary>
	/// Key: "Action.SeeAll"
	/// English String: "See All"
	/// </summary>
	public override string ActionSeeAll => "すべて見る";

	/// <summary>
	/// Key: "Action.SeeLess"
	/// English String: "See Less"
	/// </summary>
	public override string ActionSeeLess => "見る数を減らす";

	/// <summary>
	/// Key: "Action.SeeMore"
	/// English String: "See More"
	/// </summary>
	public override string ActionSeeMore => "もっと見る";

	/// <summary>
	/// Key: "Action.SlideshowView"
	/// English String: "Slideshow View"
	/// </summary>
	public override string ActionSlideshowView => "スライドショー表示";

	/// <summary>
	/// Key: "Action.Trade"
	/// English String: "Trade"
	/// </summary>
	public override string ActionTrade => "取引";

	/// <summary>
	/// Key: "Action.TradeItems"
	/// English String: "Trade Items"
	/// </summary>
	public override string ActionTradeItems => "取引アイテム";

	/// <summary>
	/// Key: "Action.UnblockUser"
	/// English String: "Unblock User"
	/// </summary>
	public override string ActionUnblockUser => "ユーザーのブロックを解除";

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
	/// Key: "Action.UpdateStatus"
	/// English String: "Update Status"
	/// </summary>
	public override string ActionUpdateStatus => "状況をアップデート";

	/// <summary>
	/// Key: "Description.BlockUserFooter"
	/// English String: "When you've blocked a user, neither of you can directly contact the other."
	/// </summary>
	public override string DescriptionBlockUserFooter => "ユーザーをブロックすると、自分からも相手からも直接コンタクトを取ることができなくなります。";

	/// <summary>
	/// Key: "Description.BlockUserPrompt"
	/// English String: "Are you sure you want to block this user?"
	/// </summary>
	public override string DescriptionBlockUserPrompt => "このユーザーをブロックしてよろしいですか？";

	/// <summary>
	/// Key: "Description.ChangeAlias"
	/// English String: "Only you can see this information"
	/// </summary>
	public override string DescriptionChangeAlias => "この情報は自分だけが見れるものです";

	/// <summary>
	/// Key: "Description.UnblockUserPrompt"
	/// English String: "Are you sure you want to unblock this user?"
	/// </summary>
	public override string DescriptionUnblockUserPrompt => "このユーザーのブロックを解除してよろしいですか？";

	/// <summary>
	/// Key: "Heading.AboutTab"
	/// this is for the heading under About tab on profile page
	/// English String: "About"
	/// </summary>
	public override string HeadingAboutTab => "情報";

	/// <summary>
	/// Key: "Heading.BlockUserTitle"
	/// English String: "Warning"
	/// </summary>
	public override string HeadingBlockUserTitle => "警告";

	/// <summary>
	/// Key: "Heading.Collections"
	/// English String: "Collections"
	/// </summary>
	public override string HeadingCollections => "コレクション";

	/// <summary>
	/// Key: "Heading.CurrentlyWearing"
	/// English String: "Currently Wearing"
	/// </summary>
	public override string HeadingCurrentlyWearing => "装備中";

	/// <summary>
	/// Key: "Heading.FavoriteGames"
	/// English String: "Favorites"
	/// </summary>
	public override string HeadingFavoriteGames => "お気に入り";

	/// <summary>
	/// Key: "Heading.Friends"
	/// English String: "Friends"
	/// </summary>
	public override string HeadingFriends => "友達";

	/// <summary>
	/// Key: "Heading.Games"
	/// English String: "Games"
	/// </summary>
	public override string HeadingGames => "ゲーム";

	/// <summary>
	/// Key: "Heading.GameTitle"
	/// English String: "Games"
	/// </summary>
	public override string HeadingGameTitle => "ゲーム";

	/// <summary>
	/// Key: "Heading.Groups"
	/// English String: "Groups"
	/// </summary>
	public override string HeadingGroups => "グループ";

	/// <summary>
	/// Key: "Heading.PlayerAssetsBadges"
	/// English String: "Player Badges"
	/// </summary>
	public override string HeadingPlayerAssetsBadges => "プレイヤーバッジ";

	/// <summary>
	/// Key: "Heading.PlayerAssetsClothing"
	/// English String: "Clothing"
	/// </summary>
	public override string HeadingPlayerAssetsClothing => "コスチューム";

	/// <summary>
	/// Key: "Heading.PlayerAssetsModels"
	/// English String: "Models"
	/// </summary>
	public override string HeadingPlayerAssetsModels => "モデル";

	/// <summary>
	/// Key: "Heading.PlayerBadge"
	/// English String: "Player Badges"
	/// </summary>
	public override string HeadingPlayerBadge => "プレイヤーバッジ";

	/// <summary>
	/// Key: "Heading.Profile"
	/// English String: "Profile"
	/// </summary>
	public override string HeadingProfile => "プロフィール";

	/// <summary>
	/// Key: "Heading.ProfileGroups"
	/// English String: "Groups"
	/// </summary>
	public override string HeadingProfileGroups => "グループ";

	/// <summary>
	/// Key: "Heading.RobloxBadge"
	/// English String: "Roblox Badges"
	/// </summary>
	public override string HeadingRobloxBadge => "Robloxバッジ";

	/// <summary>
	/// Key: "Heading.Statistics"
	/// English String: "Statistics"
	/// </summary>
	public override string HeadingStatistics => "統計";

	/// <summary>
	/// Key: "Label.About"
	/// English String: "About"
	/// </summary>
	public override string LabelAbout => "情報";

	/// <summary>
	/// Key: "Label.Alias"
	/// Friends Tag, nickname
	/// English String: "Alias"
	/// </summary>
	public override string LabelAlias => "ニックネーム";

	/// <summary>
	/// Key: "Label.BlockWarningBody"
	/// English String: "Are you sure you want to block this user?"
	/// </summary>
	public override string LabelBlockWarningBody => "このユーザーをブロックしてよろしいですか？";

	/// <summary>
	/// Key: "Label.BlockWarningConfirm"
	/// English String: "Block"
	/// </summary>
	public override string LabelBlockWarningConfirm => "ブロック";

	/// <summary>
	/// Key: "Label.BlockWarningFooter"
	/// English String: "When you've blocked a user, neither of you can directly contact the other."
	/// </summary>
	public override string LabelBlockWarningFooter => "ユーザーをブロックすると、自分からも相手からも直接コンタクトを取ることができなくなります。";

	/// <summary>
	/// Key: "Label.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string LabelCancel => "キャンセル";

	/// <summary>
	/// Key: "Label.ChangeAlias"
	/// set nickname
	/// English String: "Set Alias"
	/// </summary>
	public override string LabelChangeAlias => "ニックネームを設定";

	/// <summary>
	/// Key: "Label.Creations"
	/// English String: "Creations"
	/// </summary>
	public override string LabelCreations => "作品";

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
	/// Key: "Label.ForumPosts"
	/// English String: "Forum Posts"
	/// </summary>
	public override string LabelForumPosts => "フォーラムの投稿";

	/// <summary>
	/// Key: "Label.Friends"
	/// English String: "Friends"
	/// </summary>
	public override string LabelFriends => "友達";

	/// <summary>
	/// Key: "Label.GridView"
	/// English String: "Grid View"
	/// </summary>
	public override string LabelGridView => "グリッド表示";

	/// <summary>
	/// Key: "Label.JoinDate"
	/// English String: "Join Date"
	/// </summary>
	public override string LabelJoinDate => "参加日";

	/// <summary>
	/// Key: "Label.LoadMore"
	/// English String: "Load More"
	/// </summary>
	public override string LabelLoadMore => "さらに読み込む";

	/// <summary>
	/// Key: "Label.Members"
	/// English String: "Members"
	/// </summary>
	public override string LabelMembers => "メンバー";

	/// <summary>
	/// Key: "Label.PastUsername"
	/// English String: "Past Usernames"
	/// </summary>
	public override string LabelPastUsername => "過去のユーザーネーム";

	/// <summary>
	/// Key: "Label.PastUsernames"
	/// English String: "Past usernames"
	/// </summary>
	public override string LabelPastUsernames => "過去のユーザーネーム";

	/// <summary>
	/// Key: "Label.PlaceVisits"
	/// English String: "Place Visits"
	/// </summary>
	public override string LabelPlaceVisits => "プレースの訪問数";

	/// <summary>
	/// Key: "Label.Playing"
	/// English String: "Playing"
	/// </summary>
	public override string LabelPlaying => "プレイ中";

	/// <summary>
	/// Key: "Label.Rank"
	/// English String: "Rank"
	/// </summary>
	public override string LabelRank => "ランク";

	/// <summary>
	/// Key: "Label.ReadMore"
	/// English String: "Read More"
	/// </summary>
	public override string LabelReadMore => "続きを読む";

	/// <summary>
	/// Key: "Label.ReportAbuse"
	/// English String: "Report Abuse"
	/// </summary>
	public override string LabelReportAbuse => "規約違反を報告";

	/// <summary>
	/// Key: "Label.ShowLess"
	/// English String: "Show Less"
	/// </summary>
	public override string LabelShowLess => "表示を減らす";

	/// <summary>
	/// Key: "Label.SlideshowView"
	/// English String: "Slideshow View"
	/// </summary>
	public override string LabelSlideshowView => "スライドショー表示";

	/// <summary>
	/// Key: "Label.UnblockWarningBody"
	/// English String: "Are you sure you want to unblock this user?"
	/// </summary>
	public override string LabelUnblockWarningBody => "このユーザーのブロックを解除してよろしいですか？";

	/// <summary>
	/// Key: "Label.UnblockWarningConfirm"
	/// English String: "Unblock"
	/// </summary>
	public override string LabelUnblockWarningConfirm => "ブロックを解除";

	/// <summary>
	/// Key: "Label.Visits"
	/// English String: "Visits"
	/// </summary>
	public override string LabelVisits => "訪問数";

	/// <summary>
	/// Key: "Label.WarningTitle"
	/// English String: "Warning"
	/// </summary>
	public override string LabelWarningTitle => "警告";

	/// <summary>
	/// Key: "Message.AliasHasError"
	/// English String: "An error has occurred. Please try again later"
	/// </summary>
	public override string MessageAliasHasError => "エラーが発生しました。後でもう一度お試しください";

	/// <summary>
	/// Key: "Message.AliasIsModerated"
	/// English String: "Please avoid using full names or offensive language."
	/// </summary>
	public override string MessageAliasIsModerated => "フルネームや不適切な言葉を使わないようにしてください。";

	/// <summary>
	/// Key: "Message.ChangeStatus"
	/// English String: "What are you up to?"
	/// </summary>
	public override string MessageChangeStatus => "何をしますか？";

	/// <summary>
	/// Key: "Message.ErrorBlockLimit"
	/// English String: "Operation failed! You may have blocked too many people."
	/// </summary>
	public override string MessageErrorBlockLimit => "実行できませんでした。ブロックしたユーザーが多すぎる可能性があります。";

	/// <summary>
	/// Key: "Message.ErrorGeneral"
	/// English String: "Something went wrong. Please check back in a few minutes."
	/// </summary>
	public override string MessageErrorGeneral => "問題が発生しました。しばらくしてからもう一度お試しください。";

	/// <summary>
	/// Key: "Message.Sharing"
	/// English String: "Sharing..."
	/// </summary>
	public override string MessageSharing => "シェアしています...";

	/// <summary>
	/// Key: "Response.TooManyAttempts"
	/// flood error response
	/// English String: "Too Many Attempts"
	/// </summary>
	public override string ResponseTooManyAttempts => "試行回数が多すぎます";

	public ProfileResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAccept()
	{
		return "承認する";
	}

	protected override string _GetTemplateForActionAddFriend()
	{
		return "友達を追加";
	}

	protected override string _GetTemplateForActionBlockUser()
	{
		return "ユーザーをブロック";
	}

	protected override string _GetTemplateForActionCancelBlockUser()
	{
		return "キャンセル";
	}

	protected override string _GetTemplateForActionChat()
	{
		return "チャット";
	}

	protected override string _GetTemplateForActionClose()
	{
		return "閉じる";
	}

	protected override string _GetTemplateForActionConfirmBlockUser()
	{
		return "ブロック";
	}

	protected override string _GetTemplateForActionConfirmUnblockUser()
	{
		return "ブロックを解除";
	}

	protected override string _GetTemplateForActionFavorites()
	{
		return "お気に入り";
	}

	protected override string _GetTemplateForActionFollow()
	{
		return "フォロー";
	}

	protected override string _GetTemplateForActionGridView()
	{
		return "グリッド表示";
	}

	protected override string _GetTemplateForActionImpersonateUser()
	{
		return "なりすましユーザー";
	}

	protected override string _GetTemplateForActionInventory()
	{
		return "インベントリ";
	}

	protected override string _GetTemplateForActionJoinGame()
	{
		return "ゲームに参加";
	}

	protected override string _GetTemplateForActionMessage()
	{
		return "メッセージ";
	}

	protected override string _GetTemplateForActionPending()
	{
		return "保留中です";
	}

	protected override string _GetTemplateForActionSave()
	{
		return "保存";
	}

	protected override string _GetTemplateForActionSeeAll()
	{
		return "すべて見る";
	}

	protected override string _GetTemplateForActionSeeLess()
	{
		return "見る数を減らす";
	}

	protected override string _GetTemplateForActionSeeMore()
	{
		return "もっと見る";
	}

	protected override string _GetTemplateForActionSlideshowView()
	{
		return "スライドショー表示";
	}

	protected override string _GetTemplateForActionTrade()
	{
		return "取引";
	}

	protected override string _GetTemplateForActionTradeItems()
	{
		return "取引アイテム";
	}

	protected override string _GetTemplateForActionUnblockUser()
	{
		return "ユーザーのブロックを解除";
	}

	protected override string _GetTemplateForActionUnfollow()
	{
		return "フォローをやめる";
	}

	protected override string _GetTemplateForActionUnfriend()
	{
		return "友達解除";
	}

	protected override string _GetTemplateForActionUpdateStatus()
	{
		return "状況をアップデート";
	}

	protected override string _GetTemplateForDescriptionBlockUserFooter()
	{
		return "ユーザーをブロックすると、自分からも相手からも直接コンタクトを取ることができなくなります。";
	}

	protected override string _GetTemplateForDescriptionBlockUserPrompt()
	{
		return "このユーザーをブロックしてよろしいですか？";
	}

	protected override string _GetTemplateForDescriptionChangeAlias()
	{
		return "この情報は自分だけが見れるものです";
	}

	protected override string _GetTemplateForDescriptionUnblockUserPrompt()
	{
		return "このユーザーのブロックを解除してよろしいですか？";
	}

	protected override string _GetTemplateForHeadingAboutTab()
	{
		return "情報";
	}

	protected override string _GetTemplateForHeadingBlockUserTitle()
	{
		return "警告";
	}

	protected override string _GetTemplateForHeadingCollections()
	{
		return "コレクション";
	}

	protected override string _GetTemplateForHeadingCurrentlyWearing()
	{
		return "装備中";
	}

	protected override string _GetTemplateForHeadingFavoriteGames()
	{
		return "お気に入り";
	}

	protected override string _GetTemplateForHeadingFriends()
	{
		return "友達";
	}

	/// <summary>
	/// Key: "Heading.FriendsNum"
	/// English String: "Friends ({friendsCount})"
	/// </summary>
	public override string HeadingFriendsNum(string friendsCount)
	{
		return $"友達（{friendsCount} 人）";
	}

	protected override string _GetTemplateForHeadingFriendsNum()
	{
		return "友達（{friendsCount} 人）";
	}

	protected override string _GetTemplateForHeadingGames()
	{
		return "ゲーム";
	}

	protected override string _GetTemplateForHeadingGameTitle()
	{
		return "ゲーム";
	}

	protected override string _GetTemplateForHeadingGroups()
	{
		return "グループ";
	}

	protected override string _GetTemplateForHeadingPlayerAssetsBadges()
	{
		return "プレイヤーバッジ";
	}

	protected override string _GetTemplateForHeadingPlayerAssetsClothing()
	{
		return "コスチューム";
	}

	protected override string _GetTemplateForHeadingPlayerAssetsModels()
	{
		return "モデル";
	}

	protected override string _GetTemplateForHeadingPlayerBadge()
	{
		return "プレイヤーバッジ";
	}

	protected override string _GetTemplateForHeadingProfile()
	{
		return "プロフィール";
	}

	protected override string _GetTemplateForHeadingProfileGroups()
	{
		return "グループ";
	}

	protected override string _GetTemplateForHeadingRobloxBadge()
	{
		return "Robloxバッジ";
	}

	protected override string _GetTemplateForHeadingStatistics()
	{
		return "統計";
	}

	protected override string _GetTemplateForLabelAbout()
	{
		return "情報";
	}

	protected override string _GetTemplateForLabelAlias()
	{
		return "ニックネーム";
	}

	protected override string _GetTemplateForLabelBlockWarningBody()
	{
		return "このユーザーをブロックしてよろしいですか？";
	}

	protected override string _GetTemplateForLabelBlockWarningConfirm()
	{
		return "ブロック";
	}

	protected override string _GetTemplateForLabelBlockWarningFooter()
	{
		return "ユーザーをブロックすると、自分からも相手からも直接コンタクトを取ることができなくなります。";
	}

	protected override string _GetTemplateForLabelCancel()
	{
		return "キャンセル";
	}

	protected override string _GetTemplateForLabelChangeAlias()
	{
		return "ニックネームを設定";
	}

	protected override string _GetTemplateForLabelCreations()
	{
		return "作品";
	}

	protected override string _GetTemplateForLabelFollowers()
	{
		return "フォロワー";
	}

	protected override string _GetTemplateForLabelFollowing()
	{
		return "フォロー中";
	}

	protected override string _GetTemplateForLabelForumPosts()
	{
		return "フォーラムの投稿";
	}

	protected override string _GetTemplateForLabelFriends()
	{
		return "友達";
	}

	protected override string _GetTemplateForLabelGridView()
	{
		return "グリッド表示";
	}

	protected override string _GetTemplateForLabelJoinDate()
	{
		return "参加日";
	}

	protected override string _GetTemplateForLabelLoadMore()
	{
		return "さらに読み込む";
	}

	protected override string _GetTemplateForLabelMembers()
	{
		return "メンバー";
	}

	protected override string _GetTemplateForLabelPastUsername()
	{
		return "過去のユーザーネーム";
	}

	protected override string _GetTemplateForLabelPastUsernames()
	{
		return "過去のユーザーネーム";
	}

	protected override string _GetTemplateForLabelPlaceVisits()
	{
		return "プレースの訪問数";
	}

	protected override string _GetTemplateForLabelPlaying()
	{
		return "プレイ中";
	}

	/// <summary>
	/// Key: "Label.Quotation"
	/// You only need to localize the quotation mark, e.g. 「{userStatus}」
	/// English String: "\"{userStatus}\""
	/// </summary>
	public override string LabelQuotation(string userStatus)
	{
		return $"「{userStatus}」";
	}

	protected override string _GetTemplateForLabelQuotation()
	{
		return "「{userStatus}」";
	}

	protected override string _GetTemplateForLabelRank()
	{
		return "ランク";
	}

	protected override string _GetTemplateForLabelReadMore()
	{
		return "続きを読む";
	}

	protected override string _GetTemplateForLabelReportAbuse()
	{
		return "規約違反を報告";
	}

	protected override string _GetTemplateForLabelShowLess()
	{
		return "表示を減らす";
	}

	protected override string _GetTemplateForLabelSlideshowView()
	{
		return "スライドショー表示";
	}

	protected override string _GetTemplateForLabelUnblockWarningBody()
	{
		return "このユーザーのブロックを解除してよろしいですか？";
	}

	protected override string _GetTemplateForLabelUnblockWarningConfirm()
	{
		return "ブロックを解除";
	}

	protected override string _GetTemplateForLabelVisits()
	{
		return "訪問数";
	}

	protected override string _GetTemplateForLabelWarningTitle()
	{
		return "警告";
	}

	protected override string _GetTemplateForMessageAliasHasError()
	{
		return "エラーが発生しました。後でもう一度お試しください";
	}

	protected override string _GetTemplateForMessageAliasIsModerated()
	{
		return "フルネームや不適切な言葉を使わないようにしてください。";
	}

	protected override string _GetTemplateForMessageChangeStatus()
	{
		return "何をしますか？";
	}

	protected override string _GetTemplateForMessageErrorBlockLimit()
	{
		return "実行できませんでした。ブロックしたユーザーが多すぎる可能性があります。";
	}

	protected override string _GetTemplateForMessageErrorGeneral()
	{
		return "問題が発生しました。しばらくしてからもう一度お試しください。";
	}

	/// <summary>
	/// Key: "Message.NoCreation"
	/// English String: "{username} has no creations."
	/// </summary>
	public override string MessageNoCreation(string username)
	{
		return $"{username}には作品がありません。";
	}

	protected override string _GetTemplateForMessageNoCreation()
	{
		return "{username}には作品がありません。";
	}

	protected override string _GetTemplateForMessageSharing()
	{
		return "シェアしています...";
	}

	protected override string _GetTemplateForResponseTooManyAttempts()
	{
		return "試行回数が多すぎます";
	}
}
