namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides GroupsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class GroupsResources_ja_jp : GroupsResources_en_us, IGroupsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.AdvertiseGroup"
	/// English String: "Advertise Group"
	/// </summary>
	public override string ActionAdvertiseGroup => "グループを宣伝する";

	/// <summary>
	/// Key: "Action.AuditLog"
	/// English String: "Audit Log"
	/// </summary>
	public override string ActionAuditLog => "審査ログ";

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "キャンセル";

	/// <summary>
	/// Key: "Action.CancelRequest"
	/// English String: "Cancel Request"
	/// </summary>
	public override string ActionCancelRequest => "リクエストをキャンセル";

	/// <summary>
	/// Key: "Action.ClaimOwnership"
	/// English String: "Claim Ownership"
	/// </summary>
	public override string ActionClaimOwnership => "所有権を取得";

	/// <summary>
	/// Key: "Action.Close"
	/// English String: "Close"
	/// </summary>
	public override string ActionClose => "閉鎖する";

	/// <summary>
	/// Key: "Action.ConfigureGroup"
	/// English String: "Configure Group"
	/// </summary>
	public override string ActionConfigureGroup => "グループを環境設定する";

	/// <summary>
	/// Key: "Action.CreateGroup"
	/// English String: "Create Group"
	/// </summary>
	public override string ActionCreateGroup => "グループを作成";

	/// <summary>
	/// Key: "Action.Delete"
	/// English String: "Delete"
	/// </summary>
	public override string ActionDelete => "削除";

	/// <summary>
	/// Key: "Action.Exile"
	/// English String: "Exile"
	/// </summary>
	public override string ActionExile => "追放";

	/// <summary>
	/// Key: "Action.ExileUser"
	/// English String: "Exile User"
	/// </summary>
	public override string ActionExileUser => "ユーザーを追放";

	/// <summary>
	/// Key: "Action.GroupAdmin"
	/// English String: "Group Admin"
	/// </summary>
	public override string ActionGroupAdmin => "グループ管理";

	/// <summary>
	/// Key: "Action.GroupShout"
	/// Text on the button for sending / posting a group shout
	/// English String: "Group Shout"
	/// </summary>
	public override string ActionGroupShout => "グループシャウト";

	/// <summary>
	/// Key: "Action.JoinGroup"
	/// English String: "Join Group"
	/// </summary>
	public override string ActionJoinGroup => "グループに参加";

	/// <summary>
	/// Key: "Action.LeaveGroup"
	/// English String: "Leave Group"
	/// </summary>
	public override string ActionLeaveGroup => "グループを終了";

	/// <summary>
	/// Key: "Action.MakePrimary"
	/// English String: "Make Primary"
	/// </summary>
	public override string ActionMakePrimary => "メイングループに設定";

	/// <summary>
	/// Key: "Action.MakePrimaryGroup"
	/// Set the current group as the users primary group
	/// English String: "Make Primary Group"
	/// </summary>
	public override string ActionMakePrimaryGroup => "メイングループに設定";

	/// <summary>
	/// Key: "Action.Post"
	/// English String: "Post"
	/// </summary>
	public override string ActionPost => "投稿";

	/// <summary>
	/// Key: "Action.Purchase"
	/// English String: "Purchase"
	/// </summary>
	public override string ActionPurchase => "購入";

	/// <summary>
	/// Key: "Action.RemovePrimary"
	/// English String: "Remove Primary"
	/// </summary>
	public override string ActionRemovePrimary => "メイングループを削除";

	/// <summary>
	/// Key: "Action.Report"
	/// English String: "Report"
	/// </summary>
	public override string ActionReport => "報告する";

	/// <summary>
	/// Key: "Action.ReportAbuse"
	/// English String: "Report Abuse"
	/// </summary>
	public override string ActionReportAbuse => "規約違反を報告";

	/// <summary>
	/// Key: "Action.Upgrade"
	/// English String: "Upgrade"
	/// </summary>
	public override string ActionUpgrade => "アップグレード";

	/// <summary>
	/// Key: "Action.UpgradeToJoin"
	/// English String: "Upgrade to Join"
	/// </summary>
	public override string ActionUpgradeToJoin => "アップグレードして参加";

	/// <summary>
	/// Key: "Action.Yes"
	/// English String: "Yes"
	/// </summary>
	public override string ActionYes => "はい";

	/// <summary>
	/// Key: "Description.ClothingRevenue"
	/// English String: "Groups have the ability to create and sell official shirts, pants, and t-shirts! All revenue goes to group funds."
	/// </summary>
	public override string DescriptionClothingRevenue => "グループでは、公式シャツ、パンツ、Tシャツなどを作ったり販売ができます！売上はグループの資金となります。";

	/// <summary>
	/// Key: "Description.DeleteAllPostsByUser"
	/// English String: "Also delete all posts by this user."
	/// </summary>
	public override string DescriptionDeleteAllPostsByUser => "このユーザーのすべての投稿も削除します。";

	/// <summary>
	/// Key: "Description.ExileUserWarning"
	/// English String: "Are you sure you want to exile this user?"
	/// </summary>
	public override string DescriptionExileUserWarning => "このユーザーを追放してよろしいですか？";

	/// <summary>
	/// Key: "Description.LeaveGroupAsOwnerWarning"
	/// English String: "This will leave the group ownerless."
	/// </summary>
	public override string DescriptionLeaveGroupAsOwnerWarning => "グループに所有者がいない状態になります。";

	/// <summary>
	/// Key: "Description.LeaveGroupWarning"
	/// English String: "Are you sure you want to leave this group?"
	/// </summary>
	public override string DescriptionLeaveGroupWarning => "このグループを終了してよろしいですか？";

	/// <summary>
	/// Key: "Description.MakePrimaryGroupWarning"
	/// English String: "Are you sure you want to make this your primary group?"
	/// </summary>
	public override string DescriptionMakePrimaryGroupWarning => "このグループをメイングループにしてよろしいですか？";

	/// <summary>
	/// Key: "Description.NoneMaxGroups"
	/// English String: "Upgrade to Builders Club to join more groups."
	/// </summary>
	public override string DescriptionNoneMaxGroups => "他のグループにも参加するには、Builders Clubにアップグレードしてください。";

	/// <summary>
	/// Key: "Description.NoneMaxGroupsPremium"
	/// English String: "Upgrade to Roblox Premium to join more groups."
	/// </summary>
	public override string DescriptionNoneMaxGroupsPremium => "他のグループにも参加するには、Roblox Premiumにアップグレードしてください。";

	/// <summary>
	/// Key: "Description.noneMaxGroupsPremiumText"
	/// English String: "Upgrade to Roblox Premium to join more groups."
	/// </summary>
	public override string DescriptionnoneMaxGroupsPremiumText => "他のグループにも参加するには、Roblox Premiumにアップグレードしてください。";

	/// <summary>
	/// Key: "Description.ObcMaxGroups"
	/// English String: "You have joined the maximum number of groups."
	/// </summary>
	public override string DescriptionObcMaxGroups => "参加できるグループの最大数に到達しました。";

	/// <summary>
	/// Key: "Description.OtherBcMaxGroups"
	/// English String: "Upgrade your Builders Club to join more groups."
	/// </summary>
	public override string DescriptionOtherBcMaxGroups => "他のグループにも参加するには、Builders Clubをアップグレードしてください。";

	/// <summary>
	/// Key: "Description.otherPremiumMaxGroupsText"
	/// English String: "Upgrade your Roblox Premium to join more groups."
	/// </summary>
	public override string DescriptionotherPremiumMaxGroupsText => "他のグループにも参加するには、Roblox Premiumにアップグレードしてください。";

	/// <summary>
	/// Key: "Description.PremiumMaxGroups"
	/// English String: "You have joined the maximum number of groups."
	/// </summary>
	public override string DescriptionPremiumMaxGroups => "参加できるグループの最大数に到達しました。";

	/// <summary>
	/// Key: "Description.PurchaseBody"
	/// English String: "Would you like to create this group for"
	/// </summary>
	public override string DescriptionPurchaseBody => "以下でこのグループを作成しますか：";

	/// <summary>
	/// Key: "Description.RemovePrimaryGroupWarning"
	/// English String: "Are you sure you want to remove your primary group?"
	/// </summary>
	public override string DescriptionRemovePrimaryGroupWarning => "メイングループを削除してよろしいですか？";

	/// <summary>
	/// Key: "Description.ReportAbuseDescription"
	/// English String: "What would you like to report?"
	/// </summary>
	public override string DescriptionReportAbuseDescription => "何を報告しますか。";

	/// <summary>
	/// Key: "Description.WallPrivacySettings"
	/// English String: "Your privacy settings do not allow you to post to group walls. Click here to adjust these settings."
	/// </summary>
	public override string DescriptionWallPrivacySettings => "プライバシー設定により、グループ掲示板への投稿が許可されていません。こちらをクリックして、設定を変更してください。";

	/// <summary>
	/// Key: "Heading.About"
	/// English String: "About"
	/// </summary>
	public override string HeadingAbout => "情報";

	/// <summary>
	/// Key: "Heading.Affiliates"
	/// English String: "Affiliates"
	/// </summary>
	public override string HeadingAffiliates => "仲間";

	/// <summary>
	/// Key: "Heading.Allies"
	/// English String: "Allies"
	/// </summary>
	public override string HeadingAllies => "仲間";

	/// <summary>
	/// Key: "Heading.Date"
	/// English String: "Date"
	/// </summary>
	public override string HeadingDate => "日付";

	/// <summary>
	/// Key: "Heading.Description"
	/// English String: "Description"
	/// </summary>
	public override string HeadingDescription => "詳細";

	/// <summary>
	/// Key: "Heading.Enemies"
	/// English String: "Enemies"
	/// </summary>
	public override string HeadingEnemies => "敵";

	/// <summary>
	/// Key: "Heading.ExileUserWarning"
	/// English String: "Warning"
	/// </summary>
	public override string HeadingExileUserWarning => "警告";

	/// <summary>
	/// Key: "Heading.Funds"
	/// English String: "Funds"
	/// </summary>
	public override string HeadingFunds => "資金";

	/// <summary>
	/// Key: "Heading.Games"
	/// English String: "Games"
	/// </summary>
	public override string HeadingGames => "ゲーム";

	/// <summary>
	/// Key: "Heading.GroupPurchase"
	/// English String: "Group Purchase Confirmation"
	/// </summary>
	public override string HeadingGroupPurchase => "グループ購入の確認";

	/// <summary>
	/// Key: "Heading.GroupShout"
	/// English String: "Group Shout"
	/// </summary>
	public override string HeadingGroupShout => "グループシャウト";

	/// <summary>
	/// Key: "Heading.LeaveGroup"
	/// English String: "Leave Group"
	/// </summary>
	public override string HeadingLeaveGroup => "グループを終了";

	/// <summary>
	/// Key: "Heading.MakePrimaryGroup"
	/// Heading of make primary group modal
	/// English String: "Make Primary Group"
	/// </summary>
	public override string HeadingMakePrimaryGroup => "メイングループに設定";

	/// <summary>
	/// Key: "Heading.Members"
	/// English String: "Members"
	/// </summary>
	public override string HeadingMembers => "メンバー";

	/// <summary>
	/// Key: "Heading.NameOrDescription"
	/// Selection option for what to report when reporting something in a group
	/// English String: "Name or Description"
	/// </summary>
	public override string HeadingNameOrDescription => "名前、または詳細";

	/// <summary>
	/// Key: "Heading.Payouts"
	/// English String: "Payouts"
	/// </summary>
	public override string HeadingPayouts => "ペイアウト";

	/// <summary>
	/// Key: "Heading.Primary"
	/// English String: "Primary"
	/// </summary>
	public override string HeadingPrimary => "メイン";

	/// <summary>
	/// Key: "Heading.Rank"
	/// English String: "Rank"
	/// </summary>
	public override string HeadingRank => "ランク";

	/// <summary>
	/// Key: "Heading.RemovePrimaryGroup"
	/// English String: "Remove Primary Group"
	/// </summary>
	public override string HeadingRemovePrimaryGroup => "メイングループを削除";

	/// <summary>
	/// Key: "Heading.Role"
	/// English String: "Role"
	/// </summary>
	public override string HeadingRole => "役割";

	/// <summary>
	/// Key: "Heading.Settings"
	/// English String: "Settings"
	/// </summary>
	public override string HeadingSettings => "設定";

	/// <summary>
	/// Key: "Heading.Shout"
	/// To be displayed above the group shout (the current status for a group set by admins)
	/// English String: "Shout"
	/// </summary>
	public override string HeadingShout => "シャウト";

	/// <summary>
	/// Key: "Heading.Store"
	/// English String: "Store"
	/// </summary>
	public override string HeadingStore => "ストア";

	/// <summary>
	/// Key: "Heading.User"
	/// English String: "User"
	/// </summary>
	public override string HeadingUser => "ユーザー";

	/// <summary>
	/// Key: "Heading.Wall"
	/// English String: "Wall"
	/// </summary>
	public override string HeadingWall => "掲示板";

	/// <summary>
	/// Key: "Label.Abandon"
	/// English String: "Abandon"
	/// </summary>
	public override string LabelAbandon => "破棄";

	/// <summary>
	/// Key: "Label.AcceptAllyRequest"
	/// English String: "Accept Ally Request"
	/// </summary>
	public override string LabelAcceptAllyRequest => "同盟リクエストを承認する";

	/// <summary>
	/// Key: "Label.AcceptJoinRequest"
	/// English String: "Accept Join Request"
	/// </summary>
	public override string LabelAcceptJoinRequest => "参加リクエストを承認する";

	/// <summary>
	/// Key: "Label.AddGroupPlace"
	/// English String: "Add Group Place"
	/// </summary>
	public override string LabelAddGroupPlace => "グループプレースを追加";

	/// <summary>
	/// Key: "Label.AdjustCurrencyAmounts"
	/// English String: "Adjust Currency Amounts"
	/// </summary>
	public override string LabelAdjustCurrencyAmounts => "通貨の額を調整";

	/// <summary>
	/// Key: "Label.All"
	/// English String: "All"
	/// </summary>
	public override string LabelAll => "すべて";

	/// <summary>
	/// Key: "Label.AnyoneCanJoin"
	/// English String: "Anyone Can Join"
	/// </summary>
	public override string LabelAnyoneCanJoin => "誰でも参加できます";

	/// <summary>
	/// Key: "Label.BuyAd"
	/// English String: "Buy Ad"
	/// </summary>
	public override string LabelBuyAd => "広告を購入";

	/// <summary>
	/// Key: "Label.BuyClan"
	/// English String: "Buy Clan"
	/// </summary>
	public override string LabelBuyClan => "クランを購入";

	/// <summary>
	/// Key: "Label.ByOwner"
	/// Prefix to either the owner of the group, or "No One!" if the group has no owner. Could not properly format like By {ownerName} because ownerName is a link in this case
	/// English String: "By"
	/// </summary>
	public override string LabelByOwner => "作：";

	/// <summary>
	/// Key: "Label.CancelClanInvite"
	/// English String: "Cancel Clan Invite"
	/// </summary>
	public override string LabelCancelClanInvite => "クランの招待状をキャンセル";

	/// <summary>
	/// Key: "Label.ChangeDescription"
	/// English String: "Change Description"
	/// </summary>
	public override string LabelChangeDescription => "詳細を変更";

	/// <summary>
	/// Key: "Label.ChangeOwner"
	/// English String: "Change Owner"
	/// </summary>
	public override string LabelChangeOwner => "所有者を変更";

	/// <summary>
	/// Key: "Label.ChangeRank"
	/// English String: "Change Rank"
	/// </summary>
	public override string LabelChangeRank => "ランクを変更";

	/// <summary>
	/// Key: "Label.Claim"
	/// English String: "Claim"
	/// </summary>
	public override string LabelClaim => "取得";

	/// <summary>
	/// Key: "Label.ConfigureBadge"
	/// English String: "Configure Badge"
	/// </summary>
	public override string LabelConfigureBadge => "バッジを環境設定する";

	/// <summary>
	/// Key: "Label.ConfigureGroupAsset"
	/// English String: "Configure Group Asset"
	/// </summary>
	public override string LabelConfigureGroupAsset => "グループアセットの環境設定";

	/// <summary>
	/// Key: "Label.ConfigureGroupDevelopmentItem"
	/// English String: "Configure Group Development Item"
	/// </summary>
	public override string LabelConfigureGroupDevelopmentItem => "グループ開発アイテムを環境設定する";

	/// <summary>
	/// Key: "Label.ConfigureGroupGame"
	/// English String: "Configure Group Game"
	/// </summary>
	public override string LabelConfigureGroupGame => "グループゲームを環境設定する";

	/// <summary>
	/// Key: "Label.ConfigureItems"
	/// English String: "Configure Items"
	/// </summary>
	public override string LabelConfigureItems => "アイテムの環境設定";

	/// <summary>
	/// Key: "Label.CreateBadge"
	/// English String: "Create Badge"
	/// </summary>
	public override string LabelCreateBadge => "バッジを作成";

	/// <summary>
	/// Key: "Label.CreateEnemy"
	/// English String: "Create Enemy"
	/// </summary>
	public override string LabelCreateEnemy => "敵を作成";

	/// <summary>
	/// Key: "Label.CreateGamePass"
	/// English String: "Create Game Pass"
	/// </summary>
	public override string LabelCreateGamePass => "ゲームパスを作成";

	/// <summary>
	/// Key: "Label.CreateGroup"
	/// English String: "Create Group"
	/// </summary>
	public override string LabelCreateGroup => "グループを作成";

	/// <summary>
	/// Key: "Label.CreateGroupAsset"
	/// English String: "Create Group Asset"
	/// </summary>
	public override string LabelCreateGroupAsset => "グループアセットを作成";

	/// <summary>
	/// Key: "Label.CreateGroupBuildersClubTooltip"
	/// English String: "Creating a group requires a Builders Club membership."
	/// </summary>
	public override string LabelCreateGroupBuildersClubTooltip => "グループの作成には、Builders Clubメンバーシップが必要です。";

	/// <summary>
	/// Key: "Label.CreateGroupDescription"
	/// English String: "Description (optional)"
	/// </summary>
	public override string LabelCreateGroupDescription => "詳細（オプショナル）";

	/// <summary>
	/// Key: "Label.CreateGroupDeveloperProduct"
	/// English String: "Create Group Developer Product"
	/// </summary>
	public override string LabelCreateGroupDeveloperProduct => "グループ開発者製品を作成";

	/// <summary>
	/// Key: "Label.CreateGroupEmblem"
	/// English String: "Emblem"
	/// </summary>
	public override string LabelCreateGroupEmblem => "エンブレム";

	/// <summary>
	/// Key: "Label.CreateGroupFee"
	/// English String: "Group Creation Fee"
	/// </summary>
	public override string LabelCreateGroupFee => "グループ作成手数料";

	/// <summary>
	/// Key: "Label.CreateGroupName"
	/// English String: "Name your group"
	/// </summary>
	public override string LabelCreateGroupName => "グループに名前を付ける";

	/// <summary>
	/// Key: "Label.CreateGroupPremiumTooltip"
	/// English String: "Creating a group requires a Roblox Premium membership."
	/// </summary>
	public override string LabelCreateGroupPremiumTooltip => "グループの作成には、Roblox Premiumメンバーシップが必要です。";

	/// <summary>
	/// Key: "Label.CreateGroupTooltip"
	/// English String: "Create a new group"
	/// </summary>
	public override string LabelCreateGroupTooltip => "新しいグループを作成";

	/// <summary>
	/// Key: "Label.CreateItems"
	/// English String: "Create Items"
	/// </summary>
	public override string LabelCreateItems => "アイテムを作成";

	/// <summary>
	/// Key: "Label.DeclineAllyRequest"
	/// English String: "Decline Ally Request"
	/// </summary>
	public override string LabelDeclineAllyRequest => "同盟リクエストを却下";

	/// <summary>
	/// Key: "Label.DeclineJoinRequest"
	/// English String: "Decline Join Request"
	/// </summary>
	public override string LabelDeclineJoinRequest => "参加リクエストを却下";

	/// <summary>
	/// Key: "Label.Delete"
	/// English String: "Delete"
	/// </summary>
	public override string LabelDelete => "削除";

	/// <summary>
	/// Key: "Label.DeleteAllPostsByUser"
	/// English String: "Also delete all posts by this user."
	/// </summary>
	public override string LabelDeleteAllPostsByUser => "このユーザーのすべての投稿も削除します。";

	/// <summary>
	/// Key: "Label.DeleteAlly"
	/// English String: "Delete Ally"
	/// </summary>
	public override string LabelDeleteAlly => "味方を削除";

	/// <summary>
	/// Key: "Label.DeleteEnemy"
	/// English String: "Delete Enemy"
	/// </summary>
	public override string LabelDeleteEnemy => "敵を削除";

	/// <summary>
	/// Key: "Label.DeleteGroupPlace"
	/// English String: "Delete Group Place"
	/// </summary>
	public override string LabelDeleteGroupPlace => "グループプレースを削除";

	/// <summary>
	/// Key: "Label.DeletePost"
	/// English String: "Delete Post"
	/// </summary>
	public override string LabelDeletePost => "投稿を削除";

	/// <summary>
	/// Key: "Label.Funds"
	/// English String: "Funds"
	/// </summary>
	public override string LabelFunds => "資金";

	/// <summary>
	/// Key: "Label.GroupClosed"
	/// English String: "Group Closed"
	/// </summary>
	public override string LabelGroupClosed => "グループを閉鎖しました";

	/// <summary>
	/// Key: "Label.GroupLocked"
	/// English String: "This group has been locked"
	/// </summary>
	public override string LabelGroupLocked => "このグループはロックされています";

	/// <summary>
	/// Key: "Label.InviteToClan"
	/// English String: "Invite to Clan"
	/// </summary>
	public override string LabelInviteToClan => "クランに招待";

	/// <summary>
	/// Key: "Label.KickFromClan"
	/// English String: "Kick from Clan"
	/// </summary>
	public override string LabelKickFromClan => "クランから追放";

	/// <summary>
	/// Key: "Label.Loading"
	/// English String: "Loading..."
	/// </summary>
	public override string LabelLoading => "読み込み中...";

	/// <summary>
	/// Key: "Label.Lock"
	/// English String: "Lock"
	/// </summary>
	public override string LabelLock => "ロック";

	/// <summary>
	/// Key: "Label.ManageGroupCreations"
	/// English String: "Create or manage group items."
	/// </summary>
	public override string LabelManageGroupCreations => "グループアイテムの作成と管理。";

	/// <summary>
	/// Key: "Label.ManualApproval"
	/// English String: "Manual Approval"
	/// </summary>
	public override string LabelManualApproval => "マニュアル承認";

	/// <summary>
	/// Key: "Label.ModerateDiscussion"
	/// English String: "Moderate Discussion"
	/// </summary>
	public override string LabelModerateDiscussion => "ディスカッションをモデレートする";

	/// <summary>
	/// Key: "Label.NoAllies"
	/// English String: "This group does not have any allies."
	/// </summary>
	public override string LabelNoAllies => "このグループには仲間がいません。";

	/// <summary>
	/// Key: "Label.NoEnemies"
	/// English String: "This group does not have any enemies."
	/// </summary>
	public override string LabelNoEnemies => "このグループには敵がいません。";

	/// <summary>
	/// Key: "Label.NoGames"
	/// English String: "No games are associated with this group."
	/// </summary>
	public override string LabelNoGames => "このグループに関連付けられたゲームはありません。";

	/// <summary>
	/// Key: "Label.NoMembersInRole"
	/// English String: "No group members are in this role."
	/// </summary>
	public override string LabelNoMembersInRole => "この役割のグループメンバーはいません。";

	/// <summary>
	/// Key: "Label.NoOne"
	/// English String: "No One!"
	/// </summary>
	public override string LabelNoOne => "誰もいません！";

	/// <summary>
	/// Key: "Label.NoStoreItems"
	/// English String: "No items are for sale in this group."
	/// </summary>
	public override string LabelNoStoreItems => "このグループで販売中のアイテムはありません。";

	/// <summary>
	/// Key: "Label.NoWallPosts"
	/// English String: "Nobody has said anything yet..."
	/// </summary>
	public override string LabelNoWallPosts => "まだ誰も発言していません...";

	/// <summary>
	/// Key: "Label.OnlyBcCanJoin"
	/// English String: "Only Builders Club members can join"
	/// </summary>
	public override string LabelOnlyBcCanJoin => "Builders Clubのメンバーだけが参加できます";

	/// <summary>
	/// Key: "Label.OnlyPremiumCanJoin"
	/// English String: "Only users with membership can join"
	/// </summary>
	public override string LabelOnlyPremiumCanJoin => "参加できるのはメンバーシップを持つユーザーだけです";

	/// <summary>
	/// Key: "Label.PrivateGroup"
	/// If group is invite only
	/// English String: "Private"
	/// </summary>
	public override string LabelPrivateGroup => "プライベート";

	/// <summary>
	/// Key: "Label.PublicGroup"
	/// If group is open for anyone to join
	/// English String: "Public"
	/// </summary>
	public override string LabelPublicGroup => "公開";

	/// <summary>
	/// Key: "Label.PublishPlace"
	/// English String: "Publish Place"
	/// </summary>
	public override string LabelPublishPlace => "プレースを公開する";

	/// <summary>
	/// Key: "Label.RemoveGroupPlace"
	/// English String: "Remove Group Place"
	/// </summary>
	public override string LabelRemoveGroupPlace => "グループプレースを削除";

	/// <summary>
	/// Key: "Label.RemoveMember"
	/// English String: "Remove Member"
	/// </summary>
	public override string LabelRemoveMember => "メンバーを削除";

	/// <summary>
	/// Key: "Label.Rename"
	/// English String: "Rename"
	/// </summary>
	public override string LabelRename => "名前を変更";

	/// <summary>
	/// Key: "Label.RevertGroupAsset"
	/// English String: "Revert Group Asset"
	/// </summary>
	public override string LabelRevertGroupAsset => "グループアセットを元に戻す";

	/// <summary>
	/// Key: "Label.SavePlace"
	/// English String: "Save Place"
	/// </summary>
	public override string LabelSavePlace => "プレースを保存";

	/// <summary>
	/// Key: "Label.SearchGroups"
	/// English String: "Search All Groups"
	/// </summary>
	public override string LabelSearchGroups => "すべてのグループを検索";

	/// <summary>
	/// Key: "Label.SearchUsers"
	/// English String: "Search Users"
	/// </summary>
	public override string LabelSearchUsers => "ユーザーを検索";

	/// <summary>
	/// Key: "Label.SendAllyRequest"
	/// English String: "Send Ally Request"
	/// </summary>
	public override string LabelSendAllyRequest => "同盟リクエストを送信";

	/// <summary>
	/// Key: "Label.ShoutPlaceholder"
	/// English String: "Enter your shout"
	/// </summary>
	public override string LabelShoutPlaceholder => "シャウトを入力してください";

	/// <summary>
	/// Key: "Label.SpendGroupFunds"
	/// English String: "Spend Group Funds"
	/// </summary>
	public override string LabelSpendGroupFunds => "グループ資金を使う";

	/// <summary>
	/// Key: "Label.Success"
	/// English String: "Success"
	/// </summary>
	public override string LabelSuccess => "成功";

	/// <summary>
	/// Key: "Label.Unlock"
	/// English String: "Unlock"
	/// </summary>
	public override string LabelUnlock => "アンロック";

	/// <summary>
	/// Key: "Label.UpdateGroupAsset"
	/// English String: "Update Group Asset"
	/// </summary>
	public override string LabelUpdateGroupAsset => "グループアセットをアップデート";

	/// <summary>
	/// Key: "Label.WallPostPlaceholder"
	/// English String: "Say something..."
	/// </summary>
	public override string LabelWallPostPlaceholder => "発言してください...";

	/// <summary>
	/// Key: "Label.WallPostsUnavailable"
	/// Displayed in the group wall area when we cannot successfully load wall posts
	/// English String: "Wall posts are temporarily unavailable, please check back later."
	/// </summary>
	public override string LabelWallPostsUnavailable => "掲示板への投稿は一時的に利用できません。しばらくしてからもう一度お試しください。";

	/// <summary>
	/// Key: "Label.Warning"
	/// English String: "Warning"
	/// </summary>
	public override string LabelWarning => "警告";

	/// <summary>
	/// Key: "Message.AlreadyMember"
	/// English String: "You are already a member of this group."
	/// </summary>
	public override string MessageAlreadyMember => "すでにこのグループのメンバーです。";

	/// <summary>
	/// Key: "Message.AlreadyRequested"
	/// English String: "You have already requested to join this group."
	/// </summary>
	public override string MessageAlreadyRequested => "このグループにはすでに参加リクエスト中です。";

	/// <summary>
	/// Key: "Message.BuildGroupRolesListError"
	/// English String: "Unable to load members for selected role."
	/// </summary>
	public override string MessageBuildGroupRolesListError => "選択した役割のメンバーを読み込めません。";

	/// <summary>
	/// Key: "Message.CannotClaimGroupWithOwner"
	/// English String: "This group already has an owner."
	/// </summary>
	public override string MessageCannotClaimGroupWithOwner => "このグループには、すでに所有者が存在します。";

	/// <summary>
	/// Key: "Message.ChangeOwnerEmpty"
	/// English String: "There is no owner of the group"
	/// </summary>
	public override string MessageChangeOwnerEmpty => "グループの所有者がいません";

	/// <summary>
	/// Key: "Message.ClaimOwnershipError"
	/// English String: "Unable to claim ownership of group."
	/// </summary>
	public override string MessageClaimOwnershipError => "グループの所有権を取得できません。";

	/// <summary>
	/// Key: "Message.ClaimOwnershipSuccess"
	/// English String: "Successfully claimed ownership of group."
	/// </summary>
	public override string MessageClaimOwnershipSuccess => "グループの所有権を取得しました。";

	/// <summary>
	/// Key: "Message.DefaultError"
	/// English String: "An error occurred."
	/// </summary>
	public override string MessageDefaultError => "エラーが発生しました。";

	/// <summary>
	/// Key: "Message.DeleteWallPostError"
	/// English String: "Unable to delete wall post."
	/// </summary>
	public override string MessageDeleteWallPostError => "掲示板投稿を削除できません。";

	/// <summary>
	/// Key: "Message.DeleteWallPostsByUserError"
	/// English String: "Unable to delete wall posts by user."
	/// </summary>
	public override string MessageDeleteWallPostsByUserError => "ユーザーの掲示板投稿を削除できません。";

	/// <summary>
	/// Key: "Message.DeleteWallPostSuccess"
	/// English String: "Successfully deleted wall post."
	/// </summary>
	public override string MessageDeleteWallPostSuccess => "掲示板投稿を削除しました。";

	/// <summary>
	/// Key: "Message.DescriptionTooLong"
	/// English String: "The description is too long."
	/// </summary>
	public override string MessageDescriptionTooLong => "詳細が長すぎます。";

	/// <summary>
	/// Key: "Message.DuplicateName"
	/// English String: "Name is already taken. Please try another."
	/// </summary>
	public override string MessageDuplicateName => "名前はすでに使われています。他の名前をお試しください。";

	/// <summary>
	/// Key: "Message.ExileUserError"
	/// English String: "Unable to exile user."
	/// </summary>
	public override string MessageExileUserError => "ユーザーを追放できません。";

	/// <summary>
	/// Key: "Message.FeatureDisabled"
	/// English String: "The feature is disabled."
	/// </summary>
	public override string MessageFeatureDisabled => "この機能はオフになっています。";

	/// <summary>
	/// Key: "Message.GetGroupRelationshipsError"
	/// English String: "Unable to load group affiliates."
	/// </summary>
	public override string MessageGetGroupRelationshipsError => "グループの仲間を読み込めません。";

	/// <summary>
	/// Key: "Message.GroupClosed"
	/// English String: "You cannot join a closed group."
	/// </summary>
	public override string MessageGroupClosed => "閉鎖されたグループに参加することはできません。";

	/// <summary>
	/// Key: "Message.GroupCreationDisabled"
	/// English String: "Group creation is currently disabled."
	/// </summary>
	public override string MessageGroupCreationDisabled => "グループ作成は、現在無効になっています。";

	/// <summary>
	/// Key: "Message.GroupIconInvalid"
	/// English String: "Icon is missing or invalid."
	/// </summary>
	public override string MessageGroupIconInvalid => "アイコンが無効、または存在しません。";

	/// <summary>
	/// Key: "Message.GroupMembershipsUnavailableError"
	/// Error displayed on group details view when the system is in read-only mode for maintenance and you try to perform an action.
	/// English String: "The group membership system is temporarily unavailable. Please try again later."
	/// </summary>
	public override string MessageGroupMembershipsUnavailableError => "このグループメンバーシップのシステムは一時的にご利用できません。後でもう一度お試しください。";

	/// <summary>
	/// Key: "Message.InsufficientFunds"
	/// English String: "Insufficient Robux funds."
	/// </summary>
	public override string MessageInsufficientFunds => "Robuxが不足しています。";

	/// <summary>
	/// Key: "Message.InsufficientGroupSpace"
	/// English String: "You are already in the maximum number of groups."
	/// </summary>
	public override string MessageInsufficientGroupSpace => "参加できるグループの最大数に到達しました。";

	/// <summary>
	/// Key: "Message.InsufficientMembership"
	/// English String: "You do not have the builders club membership necessary to join this group."
	/// </summary>
	public override string MessageInsufficientMembership => "このグループへの参加に必要なBuilders Clubメンバーシップがありません。";

	/// <summary>
	/// Key: "Message.InsufficientPermission"
	/// English String: "Insufficient permissions to complete the request."
	/// </summary>
	public override string MessageInsufficientPermission => "リクエストを完了する権限がありません。";

	/// <summary>
	/// Key: "Message.InsufficientPermissionsForRelationships"
	/// English String: "You don't have permission to manage this group's relationships."
	/// </summary>
	public override string MessageInsufficientPermissionsForRelationships => "このグループの関係を管理する権限がありません。";

	/// <summary>
	/// Key: "Message.InsufficientRobux"
	/// English String: "You do not have enough Robux to create the group."
	/// </summary>
	public override string MessageInsufficientRobux => "Robuxが不足しているためグループ作成できません。";

	/// <summary>
	/// Key: "Message.InvalidAmount"
	/// English String: "The amount is invalid."
	/// </summary>
	public override string MessageInvalidAmount => "この値は無効です。";

	/// <summary>
	/// Key: "Message.InvalidGroup"
	/// English String: "Group is invalid or does not exist."
	/// </summary>
	public override string MessageInvalidGroup => "グループが無効、または存在しません。";

	/// <summary>
	/// Key: "Message.InvalidGroupIcon"
	/// English String: "The group icon is invalid."
	/// </summary>
	public override string MessageInvalidGroupIcon => "グループアイコンが無効です。";

	/// <summary>
	/// Key: "Message.InvalidGroupId"
	/// English String: "The group is invalid or does not exist."
	/// </summary>
	public override string MessageInvalidGroupId => "グループが無効、または存在しません。";

	/// <summary>
	/// Key: "Message.InvalidGroupWallPostId"
	/// English String: "The group wall post id is invalid or does not exist."
	/// </summary>
	public override string MessageInvalidGroupWallPostId => "グループ掲示板への投稿IDが無効、または存在しません。";

	/// <summary>
	/// Key: "Message.InvalidIds"
	/// English String: "Ids could not be parsed from request."
	/// </summary>
	public override string MessageInvalidIds => "リクエストからIDを解析できませんでした。";

	/// <summary>
	/// Key: "Message.InvalidIdsError"
	/// English String: "Ids could not be parsed from request."
	/// </summary>
	public override string MessageInvalidIdsError => "リクエストからIDを解析できませんでした。";

	/// <summary>
	/// Key: "Message.InvalidMembership"
	/// English String: "User must have builders club membership."
	/// </summary>
	public override string MessageInvalidMembership => "Builders Clubメンバーシップを持つユーザーである必要があります。";

	/// <summary>
	/// Key: "Message.InvalidName"
	/// English String: "The name is invalid."
	/// </summary>
	public override string MessageInvalidName => "名前が無効です。";

	/// <summary>
	/// Key: "Message.InvalidPaginationParameters"
	/// English String: "Invalid or missing pagination parameters."
	/// </summary>
	public override string MessageInvalidPaginationParameters => "ページネーションのパラメータが無効、または存在しません。";

	/// <summary>
	/// Key: "Message.InvalidPayoutType"
	/// English String: "Invalid payout type."
	/// </summary>
	public override string MessageInvalidPayoutType => "このペイアウト方法は無効です。";

	/// <summary>
	/// Key: "Message.InvalidRecipient"
	/// English String: "The recipient is invalid."
	/// </summary>
	public override string MessageInvalidRecipient => "この受信者は無効です。";

	/// <summary>
	/// Key: "Message.InvalidRelationshipType"
	/// English String: "Group relationship type is invalid."
	/// </summary>
	public override string MessageInvalidRelationshipType => "グループの関係タイプが無効です。";

	/// <summary>
	/// Key: "Message.InvalidRoleSetId"
	/// English String: "The roleset is invalid or does not exist."
	/// </summary>
	public override string MessageInvalidRoleSetId => "役割セットが無効、または存在しません。";

	/// <summary>
	/// Key: "Message.InvalidUser"
	/// English String: "The user is invalid or does not exist."
	/// </summary>
	public override string MessageInvalidUser => "ユーザーが無効、または存在しません。";

	/// <summary>
	/// Key: "Message.InvalidWallPostContent"
	/// English String: "Your post was empty, white space, or more than 500 characters."
	/// </summary>
	public override string MessageInvalidWallPostContent => "投稿が未入力か空白、または500文字を超えています。";

	/// <summary>
	/// Key: "Message.JoinGroupError"
	/// English String: "Unable to join group."
	/// </summary>
	public override string MessageJoinGroupError => "グループに参加できません。";

	/// <summary>
	/// Key: "Message.JoinGroupPendingSuccess"
	/// English String: "Requested to join group, your request is pending."
	/// </summary>
	public override string MessageJoinGroupPendingSuccess => "グループへの参加をリクエストしました。リクエストは保留中です。";

	/// <summary>
	/// Key: "Message.JoinGroupSuccess"
	/// English String: "Successfully joined the group."
	/// </summary>
	public override string MessageJoinGroupSuccess => "グループに参加しました。";

	/// <summary>
	/// Key: "Message.LeaveGroupError"
	/// English String: "Unable to leave group."
	/// </summary>
	public override string MessageLeaveGroupError => "グループを終了できません。";

	/// <summary>
	/// Key: "Message.LoadGroupError"
	/// English String: "Unable to load group."
	/// </summary>
	public override string MessageLoadGroupError => "グループを読み込めません。";

	/// <summary>
	/// Key: "Message.LoadGroupGamesError"
	/// English String: "Unable to load games."
	/// </summary>
	public override string MessageLoadGroupGamesError => "ゲームを読み込めません。";

	/// <summary>
	/// Key: "Message.LoadGroupListError"
	/// English String: "Unable to load group list."
	/// </summary>
	public override string MessageLoadGroupListError => "グループリストを読み込めません。";

	/// <summary>
	/// Key: "Message.LoadGroupMembershipsError"
	/// English String: "Unable to load user membership information."
	/// </summary>
	public override string MessageLoadGroupMembershipsError => "ユーザーのメンバーシップ情報を読み込めません。";

	/// <summary>
	/// Key: "Message.LoadGroupMetadataError"
	/// English String: "Unable to load group info."
	/// </summary>
	public override string MessageLoadGroupMetadataError => "グループ情報を読み込めません。";

	/// <summary>
	/// Key: "Message.LoadGroupStoreItemsError"
	/// English String: "Unable to load store items."
	/// </summary>
	public override string MessageLoadGroupStoreItemsError => "ストアのアイテムを読み込めません。";

	/// <summary>
	/// Key: "Message.LoadUserGroupMembershipError"
	/// English String: "Unable to load group member information."
	/// </summary>
	public override string MessageLoadUserGroupMembershipError => "グループのメンバー情報を読み込めません。";

	/// <summary>
	/// Key: "Message.LoadWallPostsError"
	/// English String: "Unable to load wall posts."
	/// </summary>
	public override string MessageLoadWallPostsError => "掲示板投稿を読み込めません。";

	/// <summary>
	/// Key: "Message.MakePrimaryError"
	/// English String: "Unable to make primary group."
	/// </summary>
	public override string MessageMakePrimaryError => "メイングループに設定できません。";

	/// <summary>
	/// Key: "Message.MaxGroups"
	/// English String: "User is in maximum number of groups."
	/// </summary>
	public override string MessageMaxGroups => "ユーザーは、これ以上グループに参加できません。";

	/// <summary>
	/// Key: "Message.MissingGroupIcon"
	/// English String: "The group icon is missing from the request."
	/// </summary>
	public override string MessageMissingGroupIcon => "リクエストにグループアイコンが存在しません。";

	/// <summary>
	/// Key: "Message.MissingGroupStatusContent"
	/// English String: "Missing group status content."
	/// </summary>
	public override string MessageMissingGroupStatusContent => "グループ状況コンテンツがありません。";

	/// <summary>
	/// Key: "Message.NameInvalid"
	/// English String: "Name is missing or has invalid characters."
	/// </summary>
	public override string MessageNameInvalid => "名前が無効、または存在しません。";

	/// <summary>
	/// Key: "Message.NameModerated"
	/// English String: "The name is moderated."
	/// </summary>
	public override string MessageNameModerated => "名前が規制対象です。";

	/// <summary>
	/// Key: "Message.NameTaken"
	/// English String: "The name has been taken."
	/// </summary>
	public override string MessageNameTaken => "この名前はすでに使われています。";

	/// <summary>
	/// Key: "Message.NameTooLong"
	/// English String: "The name is too long."
	/// </summary>
	public override string MessageNameTooLong => "名前が長すぎます。";

	/// <summary>
	/// Key: "Message.NoPrimary"
	/// English String: "The user specified does not have a primary group."
	/// </summary>
	public override string MessageNoPrimary => "指定したユーザーには、メイングループが存在しません。";

	/// <summary>
	/// Key: "Message.PassCaptchaToJoin"
	/// English String: "You must pass the captcha test before joining this group."
	/// </summary>
	public override string MessagePassCaptchaToJoin => "このグループに参加する前に、キャプチャを完了させる必要があります。";

	/// <summary>
	/// Key: "Message.PassCaptchaToPost"
	/// English String: "Captcha must be solved to post to the group wall."
	/// </summary>
	public override string MessagePassCaptchaToPost => "グループ掲示板に投稿するには、キャプチャを完了させる必要があります。";

	/// <summary>
	/// Key: "Message.RemovePrimaryError"
	/// English String: "Unable to remove primary group."
	/// </summary>
	public override string MessageRemovePrimaryError => "メイングループを削除できません。";

	/// <summary>
	/// Key: "Message.SearchTermCharactersLimit"
	/// English String: "The search term needs to be between 2 and 50 characters"
	/// </summary>
	public override string MessageSearchTermCharactersLimit => "検索する語句は、2から50文字である必要があります";

	/// <summary>
	/// Key: "Message.SearchTermEmptyError"
	/// English String: "Search term is empty"
	/// </summary>
	public override string MessageSearchTermEmptyError => "検索する語句が空白です";

	/// <summary>
	/// Key: "Message.SearchTermFilteredError"
	/// English String: "Search term was filtered"
	/// </summary>
	public override string MessageSearchTermFilteredError => "検索する語句が規制対象です";

	/// <summary>
	/// Key: "Message.SendGroupShoutError"
	/// English String: "Unable to send group shout."
	/// </summary>
	public override string MessageSendGroupShoutError => "グループシャウトを送信できません。";

	/// <summary>
	/// Key: "Message.SendPostError"
	/// English String: "Unable to send post."
	/// </summary>
	public override string MessageSendPostError => "投稿を送信できません。";

	/// <summary>
	/// Key: "Message.TooManyAttempts"
	/// English String: "Too many attempts to join the group. Please try again later."
	/// </summary>
	public override string MessageTooManyAttempts => "グループへの参加の試行回数が多すぎます。後でもう一度お試しください。";

	/// <summary>
	/// Key: "Message.TooManyAttemptsToClaimGroups"
	/// English String: "Too many attempts to claim groups. Please try again later."
	/// </summary>
	public override string MessageTooManyAttemptsToClaimGroups => "グループ取得の試行回数が多すぎます。後でもう一度お試しください。";

	/// <summary>
	/// Key: "Message.TooManyGroups"
	/// English String: "You have reached the group capacity. Please leave a group before creating a new one."
	/// </summary>
	public override string MessageTooManyGroups => "グループ数が上限に達しました。新しいものを作成する前にグループから抜けてください。";

	/// <summary>
	/// Key: "Message.TooManyIds"
	/// English String: "Too many ids in request."
	/// </summary>
	public override string MessageTooManyIds => "リクエストしたIDが多すぎます。";

	/// <summary>
	/// Key: "Message.TooManyPosts"
	/// English String: "You are posting too fast, please try again in a few minutes."
	/// </summary>
	public override string MessageTooManyPosts => "投稿の間隔が短すぎます。数分後にもう一度お試しください。";

	/// <summary>
	/// Key: "Message.TooManyRequests"
	/// English String: "Too many requests."
	/// </summary>
	public override string MessageTooManyRequests => "リクエストが多すぎます。";

	/// <summary>
	/// Key: "Message.UnauthorizedForPostStatus"
	/// English String: "You are not authorized to set the status of this group."
	/// </summary>
	public override string MessageUnauthorizedForPostStatus => "このグループの状況を設定する権限がありません。";

	/// <summary>
	/// Key: "Message.UnauthorizedForViewGroupPayouts"
	/// English String: "You don't have permission to view this group's payouts."
	/// </summary>
	public override string MessageUnauthorizedForViewGroupPayouts => "このグループのペイアウトを見る権限がありません";

	/// <summary>
	/// Key: "Message.UnauthorizedToClaimGroup"
	/// English String: "You are not authorized to claim this group."
	/// </summary>
	public override string MessageUnauthorizedToClaimGroup => "このグループを取得する権限がありません。";

	/// <summary>
	/// Key: "Message.UnauthorizedToManageMember"
	/// English String: "You do not have permission to manage this member."
	/// </summary>
	public override string MessageUnauthorizedToManageMember => "このメンバーの管理をする権限がありません。";

	/// <summary>
	/// Key: "Message.UnauthorizedToViewRolesetPermissions"
	/// English String: "You are not authorized to view permissions for this roleset."
	/// </summary>
	public override string MessageUnauthorizedToViewRolesetPermissions => "この役割の許可レベルを見る権限がありません。";

	/// <summary>
	/// Key: "Message.UnauthorizedToViewWall"
	/// English String: "You do not have permission to access this group wall."
	/// </summary>
	public override string MessageUnauthorizedToViewWall => "このグループの掲示板にアクセスする権限がありません。";

	/// <summary>
	/// Key: "Message.UnknownError"
	/// English String: "Unknown error"
	/// </summary>
	public override string MessageUnknownError => "不明なエラーが発生しました";

	/// <summary>
	/// Key: "Message.UserNotInGroup"
	/// English String: "You aren't a member of the group specified."
	/// </summary>
	public override string MessageUserNotInGroup => "指定したグループのメンバーではありません。";

	public GroupsResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAdvertiseGroup()
	{
		return "グループを宣伝する";
	}

	protected override string _GetTemplateForActionAuditLog()
	{
		return "審査ログ";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "キャンセル";
	}

	protected override string _GetTemplateForActionCancelRequest()
	{
		return "リクエストをキャンセル";
	}

	protected override string _GetTemplateForActionClaimOwnership()
	{
		return "所有権を取得";
	}

	protected override string _GetTemplateForActionClose()
	{
		return "閉鎖する";
	}

	protected override string _GetTemplateForActionConfigureGroup()
	{
		return "グループを環境設定する";
	}

	protected override string _GetTemplateForActionCreateGroup()
	{
		return "グループを作成";
	}

	protected override string _GetTemplateForActionDelete()
	{
		return "削除";
	}

	protected override string _GetTemplateForActionExile()
	{
		return "追放";
	}

	protected override string _GetTemplateForActionExileUser()
	{
		return "ユーザーを追放";
	}

	protected override string _GetTemplateForActionGroupAdmin()
	{
		return "グループ管理";
	}

	protected override string _GetTemplateForActionGroupShout()
	{
		return "グループシャウト";
	}

	protected override string _GetTemplateForActionJoinGroup()
	{
		return "グループに参加";
	}

	protected override string _GetTemplateForActionLeaveGroup()
	{
		return "グループを終了";
	}

	protected override string _GetTemplateForActionMakePrimary()
	{
		return "メイングループに設定";
	}

	protected override string _GetTemplateForActionMakePrimaryGroup()
	{
		return "メイングループに設定";
	}

	protected override string _GetTemplateForActionPost()
	{
		return "投稿";
	}

	protected override string _GetTemplateForActionPurchase()
	{
		return "購入";
	}

	protected override string _GetTemplateForActionRemovePrimary()
	{
		return "メイングループを削除";
	}

	protected override string _GetTemplateForActionReport()
	{
		return "報告する";
	}

	protected override string _GetTemplateForActionReportAbuse()
	{
		return "規約違反を報告";
	}

	protected override string _GetTemplateForActionUpgrade()
	{
		return "アップグレード";
	}

	protected override string _GetTemplateForActionUpgradeToJoin()
	{
		return "アップグレードして参加";
	}

	protected override string _GetTemplateForActionYes()
	{
		return "はい";
	}

	protected override string _GetTemplateForDescriptionClothingRevenue()
	{
		return "グループでは、公式シャツ、パンツ、Tシャツなどを作ったり販売ができます！売上はグループの資金となります。";
	}

	protected override string _GetTemplateForDescriptionDeleteAllPostsByUser()
	{
		return "このユーザーのすべての投稿も削除します。";
	}

	protected override string _GetTemplateForDescriptionExileUserWarning()
	{
		return "このユーザーを追放してよろしいですか？";
	}

	protected override string _GetTemplateForDescriptionLeaveGroupAsOwnerWarning()
	{
		return "グループに所有者がいない状態になります。";
	}

	protected override string _GetTemplateForDescriptionLeaveGroupWarning()
	{
		return "このグループを終了してよろしいですか？";
	}

	protected override string _GetTemplateForDescriptionMakePrimaryGroupWarning()
	{
		return "このグループをメイングループにしてよろしいですか？";
	}

	protected override string _GetTemplateForDescriptionNoneMaxGroups()
	{
		return "他のグループにも参加するには、Builders Clubにアップグレードしてください。";
	}

	protected override string _GetTemplateForDescriptionNoneMaxGroupsPremium()
	{
		return "他のグループにも参加するには、Roblox Premiumにアップグレードしてください。";
	}

	protected override string _GetTemplateForDescriptionnoneMaxGroupsPremiumText()
	{
		return "他のグループにも参加するには、Roblox Premiumにアップグレードしてください。";
	}

	protected override string _GetTemplateForDescriptionObcMaxGroups()
	{
		return "参加できるグループの最大数に到達しました。";
	}

	protected override string _GetTemplateForDescriptionOtherBcMaxGroups()
	{
		return "他のグループにも参加するには、Builders Clubをアップグレードしてください。";
	}

	protected override string _GetTemplateForDescriptionotherPremiumMaxGroupsText()
	{
		return "他のグループにも参加するには、Roblox Premiumにアップグレードしてください。";
	}

	protected override string _GetTemplateForDescriptionPremiumMaxGroups()
	{
		return "参加できるグループの最大数に到達しました。";
	}

	protected override string _GetTemplateForDescriptionPurchaseBody()
	{
		return "以下でこのグループを作成しますか：";
	}

	protected override string _GetTemplateForDescriptionRemovePrimaryGroupWarning()
	{
		return "メイングループを削除してよろしいですか？";
	}

	protected override string _GetTemplateForDescriptionReportAbuseDescription()
	{
		return "何を報告しますか。";
	}

	protected override string _GetTemplateForDescriptionWallPrivacySettings()
	{
		return "プライバシー設定により、グループ掲示板への投稿が許可されていません。こちらをクリックして、設定を変更してください。";
	}

	protected override string _GetTemplateForHeadingAbout()
	{
		return "情報";
	}

	protected override string _GetTemplateForHeadingAffiliates()
	{
		return "仲間";
	}

	protected override string _GetTemplateForHeadingAllies()
	{
		return "仲間";
	}

	/// <summary>
	/// Key: "Heading.ConfigureGroup"
	/// English String: "Configure {groupName}"
	/// </summary>
	public override string HeadingConfigureGroup(string groupName)
	{
		return $"{groupName} を環境設定する";
	}

	protected override string _GetTemplateForHeadingConfigureGroup()
	{
		return "{groupName} を環境設定する";
	}

	protected override string _GetTemplateForHeadingDate()
	{
		return "日付";
	}

	protected override string _GetTemplateForHeadingDescription()
	{
		return "詳細";
	}

	protected override string _GetTemplateForHeadingEnemies()
	{
		return "敵";
	}

	protected override string _GetTemplateForHeadingExileUserWarning()
	{
		return "警告";
	}

	protected override string _GetTemplateForHeadingFunds()
	{
		return "資金";
	}

	protected override string _GetTemplateForHeadingGames()
	{
		return "ゲーム";
	}

	protected override string _GetTemplateForHeadingGroupPurchase()
	{
		return "グループ購入の確認";
	}

	protected override string _GetTemplateForHeadingGroupShout()
	{
		return "グループシャウト";
	}

	protected override string _GetTemplateForHeadingLeaveGroup()
	{
		return "グループを終了";
	}

	protected override string _GetTemplateForHeadingMakePrimaryGroup()
	{
		return "メイングループに設定";
	}

	protected override string _GetTemplateForHeadingMembers()
	{
		return "メンバー";
	}

	protected override string _GetTemplateForHeadingNameOrDescription()
	{
		return "名前、または詳細";
	}

	protected override string _GetTemplateForHeadingPayouts()
	{
		return "ペイアウト";
	}

	protected override string _GetTemplateForHeadingPrimary()
	{
		return "メイン";
	}

	protected override string _GetTemplateForHeadingRank()
	{
		return "ランク";
	}

	protected override string _GetTemplateForHeadingRemovePrimaryGroup()
	{
		return "メイングループを削除";
	}

	protected override string _GetTemplateForHeadingRole()
	{
		return "役割";
	}

	protected override string _GetTemplateForHeadingSettings()
	{
		return "設定";
	}

	protected override string _GetTemplateForHeadingShout()
	{
		return "シャウト";
	}

	protected override string _GetTemplateForHeadingStore()
	{
		return "ストア";
	}

	protected override string _GetTemplateForHeadingUser()
	{
		return "ユーザー";
	}

	protected override string _GetTemplateForHeadingWall()
	{
		return "掲示板";
	}

	protected override string _GetTemplateForLabelAbandon()
	{
		return "破棄";
	}

	protected override string _GetTemplateForLabelAcceptAllyRequest()
	{
		return "同盟リクエストを承認する";
	}

	protected override string _GetTemplateForLabelAcceptJoinRequest()
	{
		return "参加リクエストを承認する";
	}

	protected override string _GetTemplateForLabelAddGroupPlace()
	{
		return "グループプレースを追加";
	}

	protected override string _GetTemplateForLabelAdjustCurrencyAmounts()
	{
		return "通貨の額を調整";
	}

	protected override string _GetTemplateForLabelAll()
	{
		return "すべて";
	}

	protected override string _GetTemplateForLabelAnyoneCanJoin()
	{
		return "誰でも参加できます";
	}

	protected override string _GetTemplateForLabelBuyAd()
	{
		return "広告を購入";
	}

	protected override string _GetTemplateForLabelBuyClan()
	{
		return "クランを購入";
	}

	protected override string _GetTemplateForLabelByOwner()
	{
		return "作：";
	}

	protected override string _GetTemplateForLabelCancelClanInvite()
	{
		return "クランの招待状をキャンセル";
	}

	protected override string _GetTemplateForLabelChangeDescription()
	{
		return "詳細を変更";
	}

	protected override string _GetTemplateForLabelChangeOwner()
	{
		return "所有者を変更";
	}

	protected override string _GetTemplateForLabelChangeRank()
	{
		return "ランクを変更";
	}

	protected override string _GetTemplateForLabelClaim()
	{
		return "取得";
	}

	protected override string _GetTemplateForLabelConfigureBadge()
	{
		return "バッジを環境設定する";
	}

	protected override string _GetTemplateForLabelConfigureGroupAsset()
	{
		return "グループアセットの環境設定";
	}

	protected override string _GetTemplateForLabelConfigureGroupDevelopmentItem()
	{
		return "グループ開発アイテムを環境設定する";
	}

	protected override string _GetTemplateForLabelConfigureGroupGame()
	{
		return "グループゲームを環境設定する";
	}

	protected override string _GetTemplateForLabelConfigureItems()
	{
		return "アイテムの環境設定";
	}

	protected override string _GetTemplateForLabelCreateBadge()
	{
		return "バッジを作成";
	}

	protected override string _GetTemplateForLabelCreateEnemy()
	{
		return "敵を作成";
	}

	protected override string _GetTemplateForLabelCreateGamePass()
	{
		return "ゲームパスを作成";
	}

	protected override string _GetTemplateForLabelCreateGroup()
	{
		return "グループを作成";
	}

	protected override string _GetTemplateForLabelCreateGroupAsset()
	{
		return "グループアセットを作成";
	}

	protected override string _GetTemplateForLabelCreateGroupBuildersClubTooltip()
	{
		return "グループの作成には、Builders Clubメンバーシップが必要です。";
	}

	protected override string _GetTemplateForLabelCreateGroupDescription()
	{
		return "詳細（オプショナル）";
	}

	protected override string _GetTemplateForLabelCreateGroupDeveloperProduct()
	{
		return "グループ開発者製品を作成";
	}

	protected override string _GetTemplateForLabelCreateGroupEmblem()
	{
		return "エンブレム";
	}

	protected override string _GetTemplateForLabelCreateGroupFee()
	{
		return "グループ作成手数料";
	}

	protected override string _GetTemplateForLabelCreateGroupName()
	{
		return "グループに名前を付ける";
	}

	protected override string _GetTemplateForLabelCreateGroupPremiumTooltip()
	{
		return "グループの作成には、Roblox Premiumメンバーシップが必要です。";
	}

	protected override string _GetTemplateForLabelCreateGroupTooltip()
	{
		return "新しいグループを作成";
	}

	protected override string _GetTemplateForLabelCreateItems()
	{
		return "アイテムを作成";
	}

	protected override string _GetTemplateForLabelDeclineAllyRequest()
	{
		return "同盟リクエストを却下";
	}

	protected override string _GetTemplateForLabelDeclineJoinRequest()
	{
		return "参加リクエストを却下";
	}

	protected override string _GetTemplateForLabelDelete()
	{
		return "削除";
	}

	protected override string _GetTemplateForLabelDeleteAllPostsByUser()
	{
		return "このユーザーのすべての投稿も削除します。";
	}

	protected override string _GetTemplateForLabelDeleteAlly()
	{
		return "味方を削除";
	}

	protected override string _GetTemplateForLabelDeleteEnemy()
	{
		return "敵を削除";
	}

	protected override string _GetTemplateForLabelDeleteGroupPlace()
	{
		return "グループプレースを削除";
	}

	protected override string _GetTemplateForLabelDeletePost()
	{
		return "投稿を削除";
	}

	protected override string _GetTemplateForLabelFunds()
	{
		return "資金";
	}

	protected override string _GetTemplateForLabelGroupClosed()
	{
		return "グループを閉鎖しました";
	}

	protected override string _GetTemplateForLabelGroupLocked()
	{
		return "このグループはロックされています";
	}

	/// <summary>
	/// Key: "Label.GroupSearchResults"
	/// English String: "Group Results For {searchTerm}"
	/// </summary>
	public override string LabelGroupSearchResults(string searchTerm)
	{
		return $"{searchTerm} のグループでの結果";
	}

	protected override string _GetTemplateForLabelGroupSearchResults()
	{
		return "{searchTerm} のグループでの結果";
	}

	protected override string _GetTemplateForLabelInviteToClan()
	{
		return "クランに招待";
	}

	protected override string _GetTemplateForLabelKickFromClan()
	{
		return "クランから追放";
	}

	protected override string _GetTemplateForLabelLoading()
	{
		return "読み込み中...";
	}

	protected override string _GetTemplateForLabelLock()
	{
		return "ロック";
	}

	protected override string _GetTemplateForLabelManageGroupCreations()
	{
		return "グループアイテムの作成と管理。";
	}

	protected override string _GetTemplateForLabelManualApproval()
	{
		return "マニュアル承認";
	}

	/// <summary>
	/// Key: "Label.MaxGroupsTooltip"
	/// English String: "You may only be in a maximum of {maxGroups} groups at one time"
	/// </summary>
	public override string LabelMaxGroupsTooltip(string maxGroups)
	{
		return $"同時に参加できるのは、 {maxGroups} グループまでです";
	}

	protected override string _GetTemplateForLabelMaxGroupsTooltip()
	{
		return "同時に参加できるのは、 {maxGroups} グループまでです";
	}

	protected override string _GetTemplateForLabelMembers()
	{
		return "{memberCount, plural, =0 {# メンバー} =1 {# メンバー} other {# メンバー}}";
	}

	protected override string _GetTemplateForLabelModerateDiscussion()
	{
		return "ディスカッションをモデレートする";
	}

	protected override string _GetTemplateForLabelNoAllies()
	{
		return "このグループには仲間がいません。";
	}

	protected override string _GetTemplateForLabelNoEnemies()
	{
		return "このグループには敵がいません。";
	}

	protected override string _GetTemplateForLabelNoGames()
	{
		return "このグループに関連付けられたゲームはありません。";
	}

	protected override string _GetTemplateForLabelNoMembersInRole()
	{
		return "この役割のグループメンバーはいません。";
	}

	protected override string _GetTemplateForLabelNoOne()
	{
		return "誰もいません！";
	}

	/// <summary>
	/// Key: "Label.NoResults"
	/// English String: "No results for \"{searchTerm}\""
	/// </summary>
	public override string LabelNoResults(string searchTerm)
	{
		return $"「{searchTerm}」は見つかりませんでした";
	}

	protected override string _GetTemplateForLabelNoResults()
	{
		return "「{searchTerm}」は見つかりませんでした";
	}

	protected override string _GetTemplateForLabelNoStoreItems()
	{
		return "このグループで販売中のアイテムはありません。";
	}

	protected override string _GetTemplateForLabelNoWallPosts()
	{
		return "まだ誰も発言していません...";
	}

	protected override string _GetTemplateForLabelOnlyBcCanJoin()
	{
		return "Builders Clubのメンバーだけが参加できます";
	}

	protected override string _GetTemplateForLabelOnlyPremiumCanJoin()
	{
		return "参加できるのはメンバーシップを持つユーザーだけです";
	}

	protected override string _GetTemplateForLabelPrivateGroup()
	{
		return "プライベート";
	}

	protected override string _GetTemplateForLabelPublicGroup()
	{
		return "公開";
	}

	protected override string _GetTemplateForLabelPublishPlace()
	{
		return "プレースを公開する";
	}

	protected override string _GetTemplateForLabelRemoveGroupPlace()
	{
		return "グループプレースを削除";
	}

	protected override string _GetTemplateForLabelRemoveMember()
	{
		return "メンバーを削除";
	}

	protected override string _GetTemplateForLabelRename()
	{
		return "名前を変更";
	}

	protected override string _GetTemplateForLabelRevertGroupAsset()
	{
		return "グループアセットを元に戻す";
	}

	protected override string _GetTemplateForLabelSavePlace()
	{
		return "プレースを保存";
	}

	protected override string _GetTemplateForLabelSearchGroups()
	{
		return "すべてのグループを検索";
	}

	protected override string _GetTemplateForLabelSearchUsers()
	{
		return "ユーザーを検索";
	}

	protected override string _GetTemplateForLabelSendAllyRequest()
	{
		return "同盟リクエストを送信";
	}

	protected override string _GetTemplateForLabelShoutPlaceholder()
	{
		return "シャウトを入力してください";
	}

	protected override string _GetTemplateForLabelSpendGroupFunds()
	{
		return "グループ資金を使う";
	}

	protected override string _GetTemplateForLabelSuccess()
	{
		return "成功";
	}

	protected override string _GetTemplateForLabelUnlock()
	{
		return "アンロック";
	}

	protected override string _GetTemplateForLabelUpdateGroupAsset()
	{
		return "グループアセットをアップデート";
	}

	protected override string _GetTemplateForLabelWallPostPlaceholder()
	{
		return "発言してください...";
	}

	protected override string _GetTemplateForLabelWallPostsUnavailable()
	{
		return "掲示板への投稿は一時的に利用できません。しばらくしてからもう一度お試しください。";
	}

	protected override string _GetTemplateForLabelWarning()
	{
		return "警告";
	}

	/// <summary>
	/// Key: "Message.Abandon"
	/// English String: "{actor} (group owner) abandoned the group"
	/// </summary>
	public override string MessageAbandon(string actor)
	{
		return $"{actor} （グループ所有者）がグループを破棄しました";
	}

	protected override string _GetTemplateForMessageAbandon()
	{
		return "{actor} （グループ所有者）がグループを破棄しました";
	}

	/// <summary>
	/// Key: "Message.AcceptAllyRequest"
	/// English String: "{actor} accepted group {group}'s ally request"
	/// </summary>
	public override string MessageAcceptAllyRequest(string actor, string group)
	{
		return $"{actor} が {group} グループの同盟リクエストを承認しました";
	}

	protected override string _GetTemplateForMessageAcceptAllyRequest()
	{
		return "{actor} が {group} グループの同盟リクエストを承認しました";
	}

	/// <summary>
	/// Key: "Message.AcceptJoinRequest"
	/// English String: "{actor} accepted user {user}'s join request"
	/// </summary>
	public override string MessageAcceptJoinRequest(string actor, string user)
	{
		return $"{actor} が ユーザーの {user} の参加リクエストを承認しました";
	}

	protected override string _GetTemplateForMessageAcceptJoinRequest()
	{
		return "{actor} が ユーザーの {user} の参加リクエストを承認しました";
	}

	/// <summary>
	/// Key: "Message.AddGroupPlace"
	/// English String: "{actor} added game {game} as a group game"
	/// </summary>
	public override string MessageAddGroupPlace(string actor, string game)
	{
		return $"{actor} がゲームの {game} をグループゲームに追加しました";
	}

	protected override string _GetTemplateForMessageAddGroupPlace()
	{
		return "{actor} がゲームの {game} をグループゲームに追加しました";
	}

	/// <summary>
	/// Key: "Message.AdjustCurrencyAmountsDecreased"
	/// English String: "{actor} decreased group funds by {amount}"
	/// </summary>
	public override string MessageAdjustCurrencyAmountsDecreased(string actor, string amount)
	{
		return $"{actor} がグループ資金を {amount} 減らしました";
	}

	protected override string _GetTemplateForMessageAdjustCurrencyAmountsDecreased()
	{
		return "{actor} がグループ資金を {amount} 減らしました";
	}

	/// <summary>
	/// Key: "Message.AdjustCurrencyAmountsIncreased"
	/// English String: "{actor} increased group funds by {amount}"
	/// </summary>
	public override string MessageAdjustCurrencyAmountsIncreased(string actor, string amount)
	{
		return $"{actor} がグループ資金を {amount} 増やしました";
	}

	protected override string _GetTemplateForMessageAdjustCurrencyAmountsIncreased()
	{
		return "{actor} がグループ資金を {amount} 増やしました";
	}

	protected override string _GetTemplateForMessageAlreadyMember()
	{
		return "すでにこのグループのメンバーです。";
	}

	protected override string _GetTemplateForMessageAlreadyRequested()
	{
		return "このグループにはすでに参加リクエスト中です。";
	}

	protected override string _GetTemplateForMessageBuildGroupRolesListError()
	{
		return "選択した役割のメンバーを読み込めません。";
	}

	/// <summary>
	/// Key: "Message.BuyAd"
	/// English String: "{actor} bid {bid} on group ad {adName}"
	/// </summary>
	public override string MessageBuyAd(string actor, string bid, string adName)
	{
		return $"{actor} が {adName} のグループ広告を {bid} で入札";
	}

	protected override string _GetTemplateForMessageBuyAd()
	{
		return "{actor} が {adName} のグループ広告を {bid} で入札";
	}

	/// <summary>
	/// Key: "Message.BuyClan"
	/// English String: "{actor} bought a group clan"
	/// </summary>
	public override string MessageBuyClan(string actor)
	{
		return $"{actor} がグループクランを購入しました";
	}

	protected override string _GetTemplateForMessageBuyClan()
	{
		return "{actor} がグループクランを購入しました";
	}

	/// <summary>
	/// Key: "Message.CancelClanInvite"
	/// English String: "{actor} cancelled {user}'s clan invite"
	/// </summary>
	public override string MessageCancelClanInvite(string actor, string user)
	{
		return $"{actor} が {user} へのクランへの招待状をキャンセルしました";
	}

	protected override string _GetTemplateForMessageCancelClanInvite()
	{
		return "{actor} が {user} へのクランへの招待状をキャンセルしました";
	}

	protected override string _GetTemplateForMessageCannotClaimGroupWithOwner()
	{
		return "このグループには、すでに所有者が存在します。";
	}

	/// <summary>
	/// Key: "Message.ChangeDescription"
	/// English String: "{actor} changed the description to \"{newDescription}\""
	/// </summary>
	public override string MessageChangeDescription(string actor, string newDescription)
	{
		return $"{actor} が詳細を 「{newDescription}」に変更しました";
	}

	protected override string _GetTemplateForMessageChangeDescription()
	{
		return "{actor} が詳細を 「{newDescription}」に変更しました";
	}

	/// <summary>
	/// Key: "Message.ChangeOwner"
	/// English String: "{actor} changed the group owner. {user} is the new group owner"
	/// </summary>
	public override string MessageChangeOwner(string actor, string user)
	{
		return $"{actor} がグループ所有者を変更しました。 {user} が新しいグループ所有者です";
	}

	protected override string _GetTemplateForMessageChangeOwner()
	{
		return "{actor} がグループ所有者を変更しました。 {user} が新しいグループ所有者です";
	}

	protected override string _GetTemplateForMessageChangeOwnerEmpty()
	{
		return "グループの所有者がいません";
	}

	/// <summary>
	/// Key: "Message.ChangeRank"
	/// English String: "{actor} changed user {user}'s rank from {oldRoleSet} to {newRoleSet}"
	/// </summary>
	public override string MessageChangeRank(string actor, string user, string oldRoleSet, string newRoleSet)
	{
		return $"{actor} がユーザーの {user} のランクを {oldRoleSet} から {newRoleSet} に変更しました";
	}

	protected override string _GetTemplateForMessageChangeRank()
	{
		return "{actor} がユーザーの {user} のランクを {oldRoleSet} から {newRoleSet} に変更しました";
	}

	/// <summary>
	/// Key: "Message.Claim"
	/// English String: "{actor} claimed ownership of the group"
	/// </summary>
	public override string MessageClaim(string actor)
	{
		return $"{actor} がグループの所有権を取得しました";
	}

	protected override string _GetTemplateForMessageClaim()
	{
		return "{actor} がグループの所有権を取得しました";
	}

	protected override string _GetTemplateForMessageClaimOwnershipError()
	{
		return "グループの所有権を取得できません。";
	}

	protected override string _GetTemplateForMessageClaimOwnershipSuccess()
	{
		return "グループの所有権を取得しました。";
	}

	/// <summary>
	/// Key: "Message.ConfigureAsset"
	/// English String: "{actor} updated asset {item}: {actions}"
	/// </summary>
	public override string MessageConfigureAsset(string actor, string item, string actions)
	{
		return $"{actor} が {item} のアセットをアップデートしました: {actions}";
	}

	protected override string _GetTemplateForMessageConfigureAsset()
	{
		return "{actor} が {item} のアセットをアップデートしました: {actions}";
	}

	/// <summary>
	/// Key: "Message.ConfigureBadgeDisabled"
	/// English String: "{actor} disabled the badge {badge}"
	/// </summary>
	public override string MessageConfigureBadgeDisabled(string actor, string badge)
	{
		return $"{actor} が {badge} バッジを無効化しました";
	}

	protected override string _GetTemplateForMessageConfigureBadgeDisabled()
	{
		return "{actor} が {badge} バッジを無効化しました";
	}

	/// <summary>
	/// Key: "Message.ConfigureBadgeEnabled"
	/// English String: "{actor} enabled the badge {badge}"
	/// </summary>
	public override string MessageConfigureBadgeEnabled(string actor, string badge)
	{
		return $"{actor} が {badge} バッジを有効化しました";
	}

	protected override string _GetTemplateForMessageConfigureBadgeEnabled()
	{
		return "{actor} が {badge} バッジを有効化しました";
	}

	/// <summary>
	/// Key: "Message.ConfigureBadgeUpdate"
	/// English String: "{actor} configured the badge {badge}"
	/// </summary>
	public override string MessageConfigureBadgeUpdate(string actor, string badge)
	{
		return $"{actor} が {badge} バッジを環境設定しました";
	}

	protected override string _GetTemplateForMessageConfigureBadgeUpdate()
	{
		return "{actor} が {badge} バッジを環境設定しました";
	}

	/// <summary>
	/// Key: "Message.ConfigureGame"
	/// English String: "{actor} updated {game}: {actions}"
	/// </summary>
	public override string MessageConfigureGame(string actor, string game, string actions)
	{
		return $"{actor} が {game} をアップデートしました: {actions}";
	}

	protected override string _GetTemplateForMessageConfigureGame()
	{
		return "{actor} が {game} をアップデートしました: {actions}";
	}

	/// <summary>
	/// Key: "Message.ConfigureGameDeveloperProduct"
	/// English String: "{actor} updated developer product {id}: {actions}"
	/// </summary>
	public override string MessageConfigureGameDeveloperProduct(string actor, string id, string actions)
	{
		return $"{actor} がID {id} の開発者製品をアップデートしました: {actions}";
	}

	protected override string _GetTemplateForMessageConfigureGameDeveloperProduct()
	{
		return "{actor} がID {id} の開発者製品をアップデートしました: {actions}";
	}

	/// <summary>
	/// Key: "Message.ConfigureItems"
	/// English String: "{actor} configured the group item {item}"
	/// </summary>
	public override string MessageConfigureItems(string actor, string item)
	{
		return $"{actor} がグループアイテムの {item} を環境設定しました";
	}

	protected override string _GetTemplateForMessageConfigureItems()
	{
		return "{actor} がグループアイテムの {item} を環境設定しました";
	}

	/// <summary>
	/// Key: "Message.CreateAsset"
	/// English String: "{actor} created asset {item}"
	/// </summary>
	public override string MessageCreateAsset(string actor, string item)
	{
		return $"{actor} が {item} のアセットを作成しました";
	}

	protected override string _GetTemplateForMessageCreateAsset()
	{
		return "{actor} が {item} のアセットを作成しました";
	}

	/// <summary>
	/// Key: "Message.CreateBadge"
	/// English String: "{actor} created the badge {badge}"
	/// </summary>
	public override string MessageCreateBadge(string actor, string badge)
	{
		return $"{actor} が {badge} バッジを作成しました";
	}

	protected override string _GetTemplateForMessageCreateBadge()
	{
		return "{actor} が {badge} バッジを作成しました";
	}

	/// <summary>
	/// Key: "Message.CreateDeveloperProduct"
	/// English String: "{actor} created developer product with id {id}"
	/// </summary>
	public override string MessageCreateDeveloperProduct(string actor, string id)
	{
		return $"{actor} がID {id} の開発者製品を作成しました";
	}

	protected override string _GetTemplateForMessageCreateDeveloperProduct()
	{
		return "{actor} がID {id} の開発者製品を作成しました";
	}

	/// <summary>
	/// Key: "Message.CreateEnemy"
	/// English String: "{actor} declared group {group} as an enemy"
	/// </summary>
	public override string MessageCreateEnemy(string actor, string group)
	{
		return $"{actor} が {group} グループを敵に指定しました\u3000";
	}

	protected override string _GetTemplateForMessageCreateEnemy()
	{
		return "{actor} が {group} グループを敵に指定しました\u3000";
	}

	/// <summary>
	/// Key: "Message.CreateGamePass"
	/// English String: "{actor} created a Game Pass for {game}: {gamePass}"
	/// </summary>
	public override string MessageCreateGamePass(string actor, string game, string gamePass)
	{
		return $"{actor} が {game} のゲームパスを作成しました: {gamePass}";
	}

	protected override string _GetTemplateForMessageCreateGamePass()
	{
		return "{actor} が {game} のゲームパスを作成しました: {gamePass}";
	}

	/// <summary>
	/// Key: "Message.CreateItems"
	/// English String: "{actor} created the group item {item}"
	/// </summary>
	public override string MessageCreateItems(string actor, string item)
	{
		return $"{actor} がグループアイテムの {item} を作成しました";
	}

	protected override string _GetTemplateForMessageCreateItems()
	{
		return "{actor} がグループアイテムの {item} を作成しました";
	}

	/// <summary>
	/// Key: "Message.DeclineAllyRequest"
	/// English String: "{actor} declined group {group}'s ally request"
	/// </summary>
	public override string MessageDeclineAllyRequest(string actor, string group)
	{
		return $"{actor} が {group} グループの同盟リクエストを却下しました";
	}

	protected override string _GetTemplateForMessageDeclineAllyRequest()
	{
		return "{actor} が {group} グループの同盟リクエストを却下しました";
	}

	/// <summary>
	/// Key: "Message.DeclineJoinRequest"
	/// English String: "{actor} declined user {user}'s join request"
	/// </summary>
	public override string MessageDeclineJoinRequest(string actor, string user)
	{
		return $"{actor} が ユーザーの {user} の参加リクエストを却下しました";
	}

	protected override string _GetTemplateForMessageDeclineJoinRequest()
	{
		return "{actor} が ユーザーの {user} の参加リクエストを却下しました";
	}

	protected override string _GetTemplateForMessageDefaultError()
	{
		return "エラーが発生しました。";
	}

	/// <summary>
	/// Key: "Message.Delete"
	/// English String: "{actor} deleted current group"
	/// </summary>
	public override string MessageDelete(string actor)
	{
		return $"{actor} が現在のグループを削除しました";
	}

	protected override string _GetTemplateForMessageDelete()
	{
		return "{actor} が現在のグループを削除しました";
	}

	/// <summary>
	/// Key: "Message.DeleteAlly"
	/// English String: "{actor} removed group {group} as an ally"
	/// </summary>
	public override string MessageDeleteAlly(string actor, string group)
	{
		return $"{actor} が {group} グループを同盟から削除しました\u3000";
	}

	protected override string _GetTemplateForMessageDeleteAlly()
	{
		return "{actor} が {group} グループを同盟から削除しました\u3000";
	}

	/// <summary>
	/// Key: "Message.DeleteEnemy"
	/// English String: "{actor} removed group {group} as an enemy"
	/// </summary>
	public override string MessageDeleteEnemy(string actor, string group)
	{
		return $"{actor} が {group} グループを敵から削除しました\u3000";
	}

	protected override string _GetTemplateForMessageDeleteEnemy()
	{
		return "{actor} が {group} グループを敵から削除しました\u3000";
	}

	/// <summary>
	/// Key: "Message.DeleteGroupPlace"
	/// English String: "{actor} removed game {game} as a group game"
	/// </summary>
	public override string MessageDeleteGroupPlace(string actor, string game)
	{
		return $"{actor} がゲームの {game} をグループゲームから削除しました";
	}

	protected override string _GetTemplateForMessageDeleteGroupPlace()
	{
		return "{actor} がゲームの {game} をグループゲームから削除しました";
	}

	/// <summary>
	/// Key: "Message.DeletePost"
	/// English String: "{actor} deleted post \"{postDesc}\" by user {user}"
	/// </summary>
	public override string MessageDeletePost(string actor, string postDesc, string user)
	{
		return $"{actor} がユーザーの {user} が投稿した「{postDesc}」を削除しました";
	}

	protected override string _GetTemplateForMessageDeletePost()
	{
		return "{actor} がユーザーの {user} が投稿した「{postDesc}」を削除しました";
	}

	protected override string _GetTemplateForMessageDeleteWallPostError()
	{
		return "掲示板投稿を削除できません。";
	}

	protected override string _GetTemplateForMessageDeleteWallPostsByUserError()
	{
		return "ユーザーの掲示板投稿を削除できません。";
	}

	protected override string _GetTemplateForMessageDeleteWallPostSuccess()
	{
		return "掲示板投稿を削除しました。";
	}

	protected override string _GetTemplateForMessageDescriptionTooLong()
	{
		return "詳細が長すぎます。";
	}

	protected override string _GetTemplateForMessageDuplicateName()
	{
		return "名前はすでに使われています。他の名前をお試しください。";
	}

	protected override string _GetTemplateForMessageExileUserError()
	{
		return "ユーザーを追放できません。";
	}

	protected override string _GetTemplateForMessageFeatureDisabled()
	{
		return "この機能はオフになっています。";
	}

	protected override string _GetTemplateForMessageGetGroupRelationshipsError()
	{
		return "グループの仲間を読み込めません。";
	}

	protected override string _GetTemplateForMessageGroupClosed()
	{
		return "閉鎖されたグループに参加することはできません。";
	}

	protected override string _GetTemplateForMessageGroupCreationDisabled()
	{
		return "グループ作成は、現在無効になっています。";
	}

	protected override string _GetTemplateForMessageGroupIconInvalid()
	{
		return "アイコンが無効、または存在しません。";
	}

	/// <summary>
	/// Key: "Message.GroupIconTooLarge"
	/// English String: "Icon cannot be larger than {maxSize} mb."
	/// </summary>
	public override string MessageGroupIconTooLarge(string maxSize)
	{
		return $"アイコンのサイズは最大 {maxSize} mbまでです。";
	}

	protected override string _GetTemplateForMessageGroupIconTooLarge()
	{
		return "アイコンのサイズは最大 {maxSize} mbまでです。";
	}

	protected override string _GetTemplateForMessageGroupMembershipsUnavailableError()
	{
		return "このグループメンバーシップのシステムは一時的にご利用できません。後でもう一度お試しください。";
	}

	protected override string _GetTemplateForMessageInsufficientFunds()
	{
		return "Robuxが不足しています。";
	}

	protected override string _GetTemplateForMessageInsufficientGroupSpace()
	{
		return "参加できるグループの最大数に到達しました。";
	}

	protected override string _GetTemplateForMessageInsufficientMembership()
	{
		return "このグループへの参加に必要なBuilders Clubメンバーシップがありません。";
	}

	protected override string _GetTemplateForMessageInsufficientPermission()
	{
		return "リクエストを完了する権限がありません。";
	}

	protected override string _GetTemplateForMessageInsufficientPermissionsForRelationships()
	{
		return "このグループの関係を管理する権限がありません。";
	}

	protected override string _GetTemplateForMessageInsufficientRobux()
	{
		return "Robuxが不足しているためグループ作成できません。";
	}

	protected override string _GetTemplateForMessageInvalidAmount()
	{
		return "この値は無効です。";
	}

	protected override string _GetTemplateForMessageInvalidGroup()
	{
		return "グループが無効、または存在しません。";
	}

	protected override string _GetTemplateForMessageInvalidGroupIcon()
	{
		return "グループアイコンが無効です。";
	}

	protected override string _GetTemplateForMessageInvalidGroupId()
	{
		return "グループが無効、または存在しません。";
	}

	protected override string _GetTemplateForMessageInvalidGroupWallPostId()
	{
		return "グループ掲示板への投稿IDが無効、または存在しません。";
	}

	protected override string _GetTemplateForMessageInvalidIds()
	{
		return "リクエストからIDを解析できませんでした。";
	}

	protected override string _GetTemplateForMessageInvalidIdsError()
	{
		return "リクエストからIDを解析できませんでした。";
	}

	protected override string _GetTemplateForMessageInvalidMembership()
	{
		return "Builders Clubメンバーシップを持つユーザーである必要があります。";
	}

	protected override string _GetTemplateForMessageInvalidName()
	{
		return "名前が無効です。";
	}

	protected override string _GetTemplateForMessageInvalidPaginationParameters()
	{
		return "ページネーションのパラメータが無効、または存在しません。";
	}

	protected override string _GetTemplateForMessageInvalidPayoutType()
	{
		return "このペイアウト方法は無効です。";
	}

	protected override string _GetTemplateForMessageInvalidRecipient()
	{
		return "この受信者は無効です。";
	}

	protected override string _GetTemplateForMessageInvalidRelationshipType()
	{
		return "グループの関係タイプが無効です。";
	}

	protected override string _GetTemplateForMessageInvalidRoleSetId()
	{
		return "役割セットが無効、または存在しません。";
	}

	protected override string _GetTemplateForMessageInvalidUser()
	{
		return "ユーザーが無効、または存在しません。";
	}

	protected override string _GetTemplateForMessageInvalidWallPostContent()
	{
		return "投稿が未入力か空白、または500文字を超えています。";
	}

	/// <summary>
	/// Key: "Message.InviteToClan"
	/// English String: "{actor} invited user {user} to the clan"
	/// </summary>
	public override string MessageInviteToClan(string actor, string user)
	{
		return $"{actor} がユーザーの {user} をクランに招待しました";
	}

	protected override string _GetTemplateForMessageInviteToClan()
	{
		return "{actor} がユーザーの {user} をクランに招待しました";
	}

	protected override string _GetTemplateForMessageJoinGroupError()
	{
		return "グループに参加できません。";
	}

	protected override string _GetTemplateForMessageJoinGroupPendingSuccess()
	{
		return "グループへの参加をリクエストしました。リクエストは保留中です。";
	}

	protected override string _GetTemplateForMessageJoinGroupSuccess()
	{
		return "グループに参加しました。";
	}

	/// <summary>
	/// Key: "Message.KickFromClan"
	/// English String: "{actor} kicked user {user} out of the clan"
	/// </summary>
	public override string MessageKickFromClan(string actor, string user)
	{
		return $"{actor} がユーザーの {user} をクランから追放しました";
	}

	protected override string _GetTemplateForMessageKickFromClan()
	{
		return "{actor} がユーザーの {user} をクランから追放しました";
	}

	protected override string _GetTemplateForMessageLeaveGroupError()
	{
		return "グループを終了できません。";
	}

	protected override string _GetTemplateForMessageLoadGroupError()
	{
		return "グループを読み込めません。";
	}

	protected override string _GetTemplateForMessageLoadGroupGamesError()
	{
		return "ゲームを読み込めません。";
	}

	protected override string _GetTemplateForMessageLoadGroupListError()
	{
		return "グループリストを読み込めません。";
	}

	protected override string _GetTemplateForMessageLoadGroupMembershipsError()
	{
		return "ユーザーのメンバーシップ情報を読み込めません。";
	}

	protected override string _GetTemplateForMessageLoadGroupMetadataError()
	{
		return "グループ情報を読み込めません。";
	}

	protected override string _GetTemplateForMessageLoadGroupStoreItemsError()
	{
		return "ストアのアイテムを読み込めません。";
	}

	protected override string _GetTemplateForMessageLoadUserGroupMembershipError()
	{
		return "グループのメンバー情報を読み込めません。";
	}

	protected override string _GetTemplateForMessageLoadWallPostsError()
	{
		return "掲示板投稿を読み込めません。";
	}

	/// <summary>
	/// Key: "Message.Lock"
	/// English String: "{actor} locked the group"
	/// </summary>
	public override string MessageLock(string actor)
	{
		return $"{actor} がグループをロックしました";
	}

	protected override string _GetTemplateForMessageLock()
	{
		return "{actor} がグループをロックしました";
	}

	protected override string _GetTemplateForMessageMakePrimaryError()
	{
		return "メイングループに設定できません。";
	}

	protected override string _GetTemplateForMessageMaxGroups()
	{
		return "ユーザーは、これ以上グループに参加できません。";
	}

	protected override string _GetTemplateForMessageMissingGroupIcon()
	{
		return "リクエストにグループアイコンが存在しません。";
	}

	protected override string _GetTemplateForMessageMissingGroupStatusContent()
	{
		return "グループ状況コンテンツがありません。";
	}

	protected override string _GetTemplateForMessageNameInvalid()
	{
		return "名前が無効、または存在しません。";
	}

	protected override string _GetTemplateForMessageNameModerated()
	{
		return "名前が規制対象です。";
	}

	protected override string _GetTemplateForMessageNameTaken()
	{
		return "この名前はすでに使われています。";
	}

	protected override string _GetTemplateForMessageNameTooLong()
	{
		return "名前が長すぎます。";
	}

	protected override string _GetTemplateForMessageNoPrimary()
	{
		return "指定したユーザーには、メイングループが存在しません。";
	}

	protected override string _GetTemplateForMessagePassCaptchaToJoin()
	{
		return "このグループに参加する前に、キャプチャを完了させる必要があります。";
	}

	protected override string _GetTemplateForMessagePassCaptchaToPost()
	{
		return "グループ掲示板に投稿するには、キャプチャを完了させる必要があります。";
	}

	/// <summary>
	/// Key: "Message.PostStatus"
	/// English String: "{actor} changed the group status to \"{groupStatus}\""
	/// </summary>
	public override string MessagePostStatus(string actor, string groupStatus)
	{
		return $"{actor} がグループ状況を 「{groupStatus}」に変更しました";
	}

	protected override string _GetTemplateForMessagePostStatus()
	{
		return "{actor} がグループ状況を 「{groupStatus}」に変更しました";
	}

	/// <summary>
	/// Key: "Message.RemoveMember"
	/// English String: "{actor} kicked user {user}"
	/// </summary>
	public override string MessageRemoveMember(string actor, string user)
	{
		return $"{actor} がユーザーの {user} を追放しました";
	}

	protected override string _GetTemplateForMessageRemoveMember()
	{
		return "{actor} がユーザーの {user} を追放しました";
	}

	protected override string _GetTemplateForMessageRemovePrimaryError()
	{
		return "メイングループを削除できません。";
	}

	/// <summary>
	/// Key: "Message.Rename"
	/// English String: "{actor} renamed current group to {newName}"
	/// </summary>
	public override string MessageRename(string actor, string newName)
	{
		return $"{actor} が現在のグループ名を {newName} に変更しました";
	}

	protected override string _GetTemplateForMessageRename()
	{
		return "{actor} が現在のグループ名を {newName} に変更しました";
	}

	protected override string _GetTemplateForMessageSearchTermCharactersLimit()
	{
		return "検索する語句は、2から50文字である必要があります";
	}

	protected override string _GetTemplateForMessageSearchTermEmptyError()
	{
		return "検索する語句が空白です";
	}

	protected override string _GetTemplateForMessageSearchTermFilteredError()
	{
		return "検索する語句が規制対象です";
	}

	/// <summary>
	/// Key: "Message.SendAllyRequest"
	/// English String: "{actor} sent an ally request to group {group}"
	/// </summary>
	public override string MessageSendAllyRequest(string actor, string group)
	{
		return $"{actor} が同盟リクエストを {group} グループに送信しました";
	}

	protected override string _GetTemplateForMessageSendAllyRequest()
	{
		return "{actor} が同盟リクエストを {group} グループに送信しました";
	}

	protected override string _GetTemplateForMessageSendGroupShoutError()
	{
		return "グループシャウトを送信できません。";
	}

	protected override string _GetTemplateForMessageSendPostError()
	{
		return "投稿を送信できません。";
	}

	/// <summary>
	/// Key: "Message.SpendGroupFunds"
	/// English String: "{actor} spent {amount} of group funds for: {item}"
	/// </summary>
	public override string MessageSpendGroupFunds(string actor, string amount, string item)
	{
		return $"{actor} がグループ資金を {amount} 使ったアイテムは: {item}";
	}

	protected override string _GetTemplateForMessageSpendGroupFunds()
	{
		return "{actor} がグループ資金を {amount} 使ったアイテムは: {item}";
	}

	protected override string _GetTemplateForMessageTooManyAttempts()
	{
		return "グループへの参加の試行回数が多すぎます。後でもう一度お試しください。";
	}

	protected override string _GetTemplateForMessageTooManyAttemptsToClaimGroups()
	{
		return "グループ取得の試行回数が多すぎます。後でもう一度お試しください。";
	}

	protected override string _GetTemplateForMessageTooManyGroups()
	{
		return "グループ数が上限に達しました。新しいものを作成する前にグループから抜けてください。";
	}

	protected override string _GetTemplateForMessageTooManyIds()
	{
		return "リクエストしたIDが多すぎます。";
	}

	protected override string _GetTemplateForMessageTooManyPosts()
	{
		return "投稿の間隔が短すぎます。数分後にもう一度お試しください。";
	}

	protected override string _GetTemplateForMessageTooManyRequests()
	{
		return "リクエストが多すぎます。";
	}

	protected override string _GetTemplateForMessageUnauthorizedForPostStatus()
	{
		return "このグループの状況を設定する権限がありません。";
	}

	protected override string _GetTemplateForMessageUnauthorizedForViewGroupPayouts()
	{
		return "このグループのペイアウトを見る権限がありません";
	}

	protected override string _GetTemplateForMessageUnauthorizedToClaimGroup()
	{
		return "このグループを取得する権限がありません。";
	}

	protected override string _GetTemplateForMessageUnauthorizedToManageMember()
	{
		return "このメンバーの管理をする権限がありません。";
	}

	protected override string _GetTemplateForMessageUnauthorizedToViewRolesetPermissions()
	{
		return "この役割の許可レベルを見る権限がありません。";
	}

	protected override string _GetTemplateForMessageUnauthorizedToViewWall()
	{
		return "このグループの掲示板にアクセスする権限がありません。";
	}

	protected override string _GetTemplateForMessageUnknownError()
	{
		return "不明なエラーが発生しました";
	}

	/// <summary>
	/// Key: "Message.Unlock"
	/// English String: "{actor} unlocked the group"
	/// </summary>
	public override string MessageUnlock(string actor)
	{
		return $"{actor} がグループをアンロックしました";
	}

	protected override string _GetTemplateForMessageUnlock()
	{
		return "{actor} がグループをアンロックしました";
	}

	/// <summary>
	/// Key: "Message.UpdateAssetRevert"
	/// English String: "{actor} reverted asset {item} from version {version} to {oldVersion}"
	/// </summary>
	public override string MessageUpdateAssetRevert(string actor, string item, string version, string oldVersion)
	{
		return $"{actor} が {item} のアセットをバージョン {version} から {oldVersion} に戻しました";
	}

	protected override string _GetTemplateForMessageUpdateAssetRevert()
	{
		return "{actor} が {item} のアセットをバージョン {version} から {oldVersion} に戻しました";
	}

	protected override string _GetTemplateForMessageUserNotInGroup()
	{
		return "指定したグループのメンバーではありません。";
	}
}
