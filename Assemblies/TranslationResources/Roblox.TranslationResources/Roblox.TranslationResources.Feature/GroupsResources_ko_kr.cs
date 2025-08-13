namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides GroupsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class GroupsResources_ko_kr : GroupsResources_en_us, IGroupsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.AdvertiseGroup"
	/// English String: "Advertise Group"
	/// </summary>
	public override string ActionAdvertiseGroup => "그룹 홍보";

	/// <summary>
	/// Key: "Action.AuditLog"
	/// English String: "Audit Log"
	/// </summary>
	public override string ActionAuditLog => "그룹 활동 로그";

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "취소";

	/// <summary>
	/// Key: "Action.CancelRequest"
	/// English String: "Cancel Request"
	/// </summary>
	public override string ActionCancelRequest => "요청 취소";

	/// <summary>
	/// Key: "Action.ClaimOwnership"
	/// English String: "Claim Ownership"
	/// </summary>
	public override string ActionClaimOwnership => "소유권 주장";

	/// <summary>
	/// Key: "Action.Close"
	/// English String: "Close"
	/// </summary>
	public override string ActionClose => "닫기";

	/// <summary>
	/// Key: "Action.ConfigureGroup"
	/// English String: "Configure Group"
	/// </summary>
	public override string ActionConfigureGroup => "그룹 구성";

	/// <summary>
	/// Key: "Action.CreateGroup"
	/// English String: "Create Group"
	/// </summary>
	public override string ActionCreateGroup => "그룹 만들기";

	/// <summary>
	/// Key: "Action.Delete"
	/// English String: "Delete"
	/// </summary>
	public override string ActionDelete => "삭제";

	/// <summary>
	/// Key: "Action.Exile"
	/// English String: "Exile"
	/// </summary>
	public override string ActionExile => "추방";

	/// <summary>
	/// Key: "Action.ExileUser"
	/// English String: "Exile User"
	/// </summary>
	public override string ActionExileUser => "사용자 추방";

	/// <summary>
	/// Key: "Action.GroupAdmin"
	/// English String: "Group Admin"
	/// </summary>
	public override string ActionGroupAdmin => "그룹 관리자";

	/// <summary>
	/// Key: "Action.GroupShout"
	/// Text on the button for sending / posting a group shout
	/// English String: "Group Shout"
	/// </summary>
	public override string ActionGroupShout => "그룹 샤우트";

	/// <summary>
	/// Key: "Action.JoinGroup"
	/// English String: "Join Group"
	/// </summary>
	public override string ActionJoinGroup => "그룹 가입";

	/// <summary>
	/// Key: "Action.LeaveGroup"
	/// English String: "Leave Group"
	/// </summary>
	public override string ActionLeaveGroup => "그룹 나가기";

	/// <summary>
	/// Key: "Action.MakePrimary"
	/// English String: "Make Primary"
	/// </summary>
	public override string ActionMakePrimary => "기본 그룹으로 설정";

	/// <summary>
	/// Key: "Action.MakePrimaryGroup"
	/// Set the current group as the users primary group
	/// English String: "Make Primary Group"
	/// </summary>
	public override string ActionMakePrimaryGroup => "기본 그룹 만들기";

	/// <summary>
	/// Key: "Action.Post"
	/// English String: "Post"
	/// </summary>
	public override string ActionPost => "게시물";

	/// <summary>
	/// Key: "Action.Purchase"
	/// English String: "Purchase"
	/// </summary>
	public override string ActionPurchase => "구매";

	/// <summary>
	/// Key: "Action.RemovePrimary"
	/// English String: "Remove Primary"
	/// </summary>
	public override string ActionRemovePrimary => "기본 그룹 삭제";

	/// <summary>
	/// Key: "Action.Report"
	/// English String: "Report"
	/// </summary>
	public override string ActionReport => "신고";

	/// <summary>
	/// Key: "Action.ReportAbuse"
	/// English String: "Report Abuse"
	/// </summary>
	public override string ActionReportAbuse => "신고하기";

	/// <summary>
	/// Key: "Action.Upgrade"
	/// English String: "Upgrade"
	/// </summary>
	public override string ActionUpgrade => "업그레이드";

	/// <summary>
	/// Key: "Action.UpgradeToJoin"
	/// English String: "Upgrade to Join"
	/// </summary>
	public override string ActionUpgradeToJoin => "업그레이드";

	/// <summary>
	/// Key: "Action.Yes"
	/// English String: "Yes"
	/// </summary>
	public override string ActionYes => "네";

	/// <summary>
	/// Key: "Description.ClothingRevenue"
	/// English String: "Groups have the ability to create and sell official shirts, pants, and t-shirts! All revenue goes to group funds."
	/// </summary>
	public override string DescriptionClothingRevenue => "그룹에서는 그룹 자체 공식 셔츠, 바지, 티셔츠를 개발 및 판매할 수 있습니다! 모든 수입은 그룹 펀드에 적립됩니다.";

	/// <summary>
	/// Key: "Description.DeleteAllPostsByUser"
	/// English String: "Also delete all posts by this user."
	/// </summary>
	public override string DescriptionDeleteAllPostsByUser => "본 사용자가 게시한 모든 게시물도 삭제합니다.";

	/// <summary>
	/// Key: "Description.ExileUserWarning"
	/// English String: "Are you sure you want to exile this user?"
	/// </summary>
	public override string DescriptionExileUserWarning => "본 사용자를 정말 추방하시겠습니까?";

	/// <summary>
	/// Key: "Description.LeaveGroupAsOwnerWarning"
	/// English String: "This will leave the group ownerless."
	/// </summary>
	public override string DescriptionLeaveGroupAsOwnerWarning => "주인 없는 그룹이 됩니다.";

	/// <summary>
	/// Key: "Description.LeaveGroupWarning"
	/// English String: "Are you sure you want to leave this group?"
	/// </summary>
	public override string DescriptionLeaveGroupWarning => "정말 본 그룹을 나가시겠습니까?";

	/// <summary>
	/// Key: "Description.MakePrimaryGroupWarning"
	/// English String: "Are you sure you want to make this your primary group?"
	/// </summary>
	public override string DescriptionMakePrimaryGroupWarning => "정말 본 그룹을 기본 그룹으로 설정하시겠습니까?";

	/// <summary>
	/// Key: "Description.NoneMaxGroups"
	/// English String: "Upgrade to Builders Club to join more groups."
	/// </summary>
	public override string DescriptionNoneMaxGroups => "더 많은 그룹에 가입하려면 Builders Club을 업그레이드하세요.";

	/// <summary>
	/// Key: "Description.NoneMaxGroupsPremium"
	/// English String: "Upgrade to Roblox Premium to join more groups."
	/// </summary>
	public override string DescriptionNoneMaxGroupsPremium => "Roblox Premium으로 업그레이드해서 더 많은 그룹에 가입하세요.";

	/// <summary>
	/// Key: "Description.noneMaxGroupsPremiumText"
	/// English String: "Upgrade to Roblox Premium to join more groups."
	/// </summary>
	public override string DescriptionnoneMaxGroupsPremiumText => "Roblox Premium으로 업그레이드해서 더 많은 그룹에 가입하세요.";

	/// <summary>
	/// Key: "Description.ObcMaxGroups"
	/// English String: "You have joined the maximum number of groups."
	/// </summary>
	public override string DescriptionObcMaxGroups => "가입한 그룹 수가 한도에 도달했어요.";

	/// <summary>
	/// Key: "Description.OtherBcMaxGroups"
	/// English String: "Upgrade your Builders Club to join more groups."
	/// </summary>
	public override string DescriptionOtherBcMaxGroups => "더 많은 그룹에 가입하려면 Builders Club을 업그레이드하세요.";

	/// <summary>
	/// Key: "Description.otherPremiumMaxGroupsText"
	/// English String: "Upgrade your Roblox Premium to join more groups."
	/// </summary>
	public override string DescriptionotherPremiumMaxGroupsText => "Roblox Premium을 업그레이드해서 더 많은 그룹에 가입하세요.";

	/// <summary>
	/// Key: "Description.PremiumMaxGroups"
	/// English String: "You have joined the maximum number of groups."
	/// </summary>
	public override string DescriptionPremiumMaxGroups => "그룹 가입자 수 한도에 도달했어요.";

	/// <summary>
	/// Key: "Description.PurchaseBody"
	/// English String: "Would you like to create this group for"
	/// </summary>
	public override string DescriptionPurchaseBody => "이 그룹을 만들까요? 비용:";

	/// <summary>
	/// Key: "Description.RemovePrimaryGroupWarning"
	/// English String: "Are you sure you want to remove your primary group?"
	/// </summary>
	public override string DescriptionRemovePrimaryGroupWarning => "정말 회원님의 기본 그룹을 삭제하시겠습니까?";

	/// <summary>
	/// Key: "Description.ReportAbuseDescription"
	/// English String: "What would you like to report?"
	/// </summary>
	public override string DescriptionReportAbuseDescription => "어떤 내용을 신고할까요?";

	/// <summary>
	/// Key: "Description.WallPrivacySettings"
	/// English String: "Your privacy settings do not allow you to post to group walls. Click here to adjust these settings."
	/// </summary>
	public override string DescriptionWallPrivacySettings => "개인정보 설정 때문에 그룹 담벼락에 게시물을 게시할 수 없습니다. 여기를 클릭하여 설정을 변경하세요.";

	/// <summary>
	/// Key: "Heading.About"
	/// English String: "About"
	/// </summary>
	public override string HeadingAbout => "소개";

	/// <summary>
	/// Key: "Heading.Affiliates"
	/// English String: "Affiliates"
	/// </summary>
	public override string HeadingAffiliates => "파트너";

	/// <summary>
	/// Key: "Heading.Allies"
	/// English String: "Allies"
	/// </summary>
	public override string HeadingAllies => "동맹";

	/// <summary>
	/// Key: "Heading.Date"
	/// English String: "Date"
	/// </summary>
	public override string HeadingDate => "날짜";

	/// <summary>
	/// Key: "Heading.Description"
	/// English String: "Description"
	/// </summary>
	public override string HeadingDescription => "설명";

	/// <summary>
	/// Key: "Heading.Enemies"
	/// English String: "Enemies"
	/// </summary>
	public override string HeadingEnemies => "적";

	/// <summary>
	/// Key: "Heading.ExileUserWarning"
	/// English String: "Warning"
	/// </summary>
	public override string HeadingExileUserWarning => "주의";

	/// <summary>
	/// Key: "Heading.Funds"
	/// English String: "Funds"
	/// </summary>
	public override string HeadingFunds => "펀드";

	/// <summary>
	/// Key: "Heading.Games"
	/// English String: "Games"
	/// </summary>
	public override string HeadingGames => "게임";

	/// <summary>
	/// Key: "Heading.GroupPurchase"
	/// English String: "Group Purchase Confirmation"
	/// </summary>
	public override string HeadingGroupPurchase => "그룹 구매 확인";

	/// <summary>
	/// Key: "Heading.GroupShout"
	/// English String: "Group Shout"
	/// </summary>
	public override string HeadingGroupShout => "그룹 샤우트";

	/// <summary>
	/// Key: "Heading.LeaveGroup"
	/// English String: "Leave Group"
	/// </summary>
	public override string HeadingLeaveGroup => "그룹 탈퇴";

	/// <summary>
	/// Key: "Heading.MakePrimaryGroup"
	/// Heading of make primary group modal
	/// English String: "Make Primary Group"
	/// </summary>
	public override string HeadingMakePrimaryGroup => "기본 그룹 만들기";

	/// <summary>
	/// Key: "Heading.Members"
	/// English String: "Members"
	/// </summary>
	public override string HeadingMembers => "멤버";

	/// <summary>
	/// Key: "Heading.NameOrDescription"
	/// Selection option for what to report when reporting something in a group
	/// English String: "Name or Description"
	/// </summary>
	public override string HeadingNameOrDescription => "이름 또는 설명";

	/// <summary>
	/// Key: "Heading.Payouts"
	/// English String: "Payouts"
	/// </summary>
	public override string HeadingPayouts => "지불금";

	/// <summary>
	/// Key: "Heading.Primary"
	/// English String: "Primary"
	/// </summary>
	public override string HeadingPrimary => "기본";

	/// <summary>
	/// Key: "Heading.Rank"
	/// English String: "Rank"
	/// </summary>
	public override string HeadingRank => "순위";

	/// <summary>
	/// Key: "Heading.RemovePrimaryGroup"
	/// English String: "Remove Primary Group"
	/// </summary>
	public override string HeadingRemovePrimaryGroup => "기본 그룹 삭제";

	/// <summary>
	/// Key: "Heading.Role"
	/// English String: "Role"
	/// </summary>
	public override string HeadingRole => "역할";

	/// <summary>
	/// Key: "Heading.Settings"
	/// English String: "Settings"
	/// </summary>
	public override string HeadingSettings => "설정";

	/// <summary>
	/// Key: "Heading.Shout"
	/// To be displayed above the group shout (the current status for a group set by admins)
	/// English String: "Shout"
	/// </summary>
	public override string HeadingShout => "샤우트";

	/// <summary>
	/// Key: "Heading.Store"
	/// English String: "Store"
	/// </summary>
	public override string HeadingStore => "상점";

	/// <summary>
	/// Key: "Heading.User"
	/// English String: "User"
	/// </summary>
	public override string HeadingUser => "사용자";

	/// <summary>
	/// Key: "Heading.Wall"
	/// English String: "Wall"
	/// </summary>
	public override string HeadingWall => "담벼락";

	/// <summary>
	/// Key: "Label.Abandon"
	/// English String: "Abandon"
	/// </summary>
	public override string LabelAbandon => "폐기";

	/// <summary>
	/// Key: "Label.AcceptAllyRequest"
	/// English String: "Accept Ally Request"
	/// </summary>
	public override string LabelAcceptAllyRequest => "동맹 요청 수락";

	/// <summary>
	/// Key: "Label.AcceptJoinRequest"
	/// English String: "Accept Join Request"
	/// </summary>
	public override string LabelAcceptJoinRequest => "가입 요청 수락";

	/// <summary>
	/// Key: "Label.AddGroupPlace"
	/// English String: "Add Group Place"
	/// </summary>
	public override string LabelAddGroupPlace => "그룹 장소 추가";

	/// <summary>
	/// Key: "Label.AdjustCurrencyAmounts"
	/// English String: "Adjust Currency Amounts"
	/// </summary>
	public override string LabelAdjustCurrencyAmounts => "통화 금액 조정";

	/// <summary>
	/// Key: "Label.All"
	/// English String: "All"
	/// </summary>
	public override string LabelAll => "모두";

	/// <summary>
	/// Key: "Label.AnyoneCanJoin"
	/// English String: "Anyone Can Join"
	/// </summary>
	public override string LabelAnyoneCanJoin => "누구나 가입 가능";

	/// <summary>
	/// Key: "Label.BuyAd"
	/// English String: "Buy Ad"
	/// </summary>
	public override string LabelBuyAd => "광고 구매";

	/// <summary>
	/// Key: "Label.BuyClan"
	/// English String: "Buy Clan"
	/// </summary>
	public override string LabelBuyClan => "클랜 구매";

	/// <summary>
	/// Key: "Label.ByOwner"
	/// Prefix to either the owner of the group, or "No One!" if the group has no owner. Could not properly format like By {ownerName} because ownerName is a link in this case
	/// English String: "By"
	/// </summary>
	public override string LabelByOwner => "제작:";

	/// <summary>
	/// Key: "Label.CancelClanInvite"
	/// English String: "Cancel Clan Invite"
	/// </summary>
	public override string LabelCancelClanInvite => "클랜 초대 취소";

	/// <summary>
	/// Key: "Label.ChangeDescription"
	/// English String: "Change Description"
	/// </summary>
	public override string LabelChangeDescription => "설명 변경";

	/// <summary>
	/// Key: "Label.ChangeOwner"
	/// English String: "Change Owner"
	/// </summary>
	public override string LabelChangeOwner => "소유자 변경";

	/// <summary>
	/// Key: "Label.ChangeRank"
	/// English String: "Change Rank"
	/// </summary>
	public override string LabelChangeRank => "순위 변경";

	/// <summary>
	/// Key: "Label.Claim"
	/// English String: "Claim"
	/// </summary>
	public override string LabelClaim => "클레임";

	/// <summary>
	/// Key: "Label.ConfigureBadge"
	/// English String: "Configure Badge"
	/// </summary>
	public override string LabelConfigureBadge => "배지 구성";

	/// <summary>
	/// Key: "Label.ConfigureGroupAsset"
	/// English String: "Configure Group Asset"
	/// </summary>
	public override string LabelConfigureGroupAsset => "그룹 애셋 구성";

	/// <summary>
	/// Key: "Label.ConfigureGroupDevelopmentItem"
	/// English String: "Configure Group Development Item"
	/// </summary>
	public override string LabelConfigureGroupDevelopmentItem => "그룹 개발 아이템 구성";

	/// <summary>
	/// Key: "Label.ConfigureGroupGame"
	/// English String: "Configure Group Game"
	/// </summary>
	public override string LabelConfigureGroupGame => "그룹 게임 구성";

	/// <summary>
	/// Key: "Label.ConfigureItems"
	/// English String: "Configure Items"
	/// </summary>
	public override string LabelConfigureItems => "아이템 구성";

	/// <summary>
	/// Key: "Label.CreateBadge"
	/// English String: "Create Badge"
	/// </summary>
	public override string LabelCreateBadge => "배지 생성";

	/// <summary>
	/// Key: "Label.CreateEnemy"
	/// English String: "Create Enemy"
	/// </summary>
	public override string LabelCreateEnemy => "적 생성";

	/// <summary>
	/// Key: "Label.CreateGamePass"
	/// English String: "Create Game Pass"
	/// </summary>
	public override string LabelCreateGamePass => "게임패스 생성";

	/// <summary>
	/// Key: "Label.CreateGroup"
	/// English String: "Create Group"
	/// </summary>
	public override string LabelCreateGroup => "그룹 만들기";

	/// <summary>
	/// Key: "Label.CreateGroupAsset"
	/// English String: "Create Group Asset"
	/// </summary>
	public override string LabelCreateGroupAsset => "그룹 애셋 생성";

	/// <summary>
	/// Key: "Label.CreateGroupBuildersClubTooltip"
	/// English String: "Creating a group requires a Builders Club membership."
	/// </summary>
	public override string LabelCreateGroupBuildersClubTooltip => "그룹을 만들려면 Builders Club 멤버십이 필요합니다.";

	/// <summary>
	/// Key: "Label.CreateGroupDescription"
	/// English String: "Description (optional)"
	/// </summary>
	public override string LabelCreateGroupDescription => "설명 (선택사항)";

	/// <summary>
	/// Key: "Label.CreateGroupDeveloperProduct"
	/// English String: "Create Group Developer Product"
	/// </summary>
	public override string LabelCreateGroupDeveloperProduct => "그룹 개발자 상품 생성";

	/// <summary>
	/// Key: "Label.CreateGroupEmblem"
	/// English String: "Emblem"
	/// </summary>
	public override string LabelCreateGroupEmblem => "엠블럼";

	/// <summary>
	/// Key: "Label.CreateGroupFee"
	/// English String: "Group Creation Fee"
	/// </summary>
	public override string LabelCreateGroupFee => "그룹 생성 수수료";

	/// <summary>
	/// Key: "Label.CreateGroupName"
	/// English String: "Name your group"
	/// </summary>
	public override string LabelCreateGroupName => "그룹 이름 설정";

	/// <summary>
	/// Key: "Label.CreateGroupPremiumTooltip"
	/// English String: "Creating a group requires a Roblox Premium membership."
	/// </summary>
	public override string LabelCreateGroupPremiumTooltip => "그룹을 생성하려면 Roblox Premium 멤버십이 필요해요.";

	/// <summary>
	/// Key: "Label.CreateGroupTooltip"
	/// English String: "Create a new group"
	/// </summary>
	public override string LabelCreateGroupTooltip => "새 그룹 만들기";

	/// <summary>
	/// Key: "Label.CreateItems"
	/// English String: "Create Items"
	/// </summary>
	public override string LabelCreateItems => "아이템 생성";

	/// <summary>
	/// Key: "Label.DeclineAllyRequest"
	/// English String: "Decline Ally Request"
	/// </summary>
	public override string LabelDeclineAllyRequest => "동맹 요청 거절";

	/// <summary>
	/// Key: "Label.DeclineJoinRequest"
	/// English String: "Decline Join Request"
	/// </summary>
	public override string LabelDeclineJoinRequest => "가입 요청 거절";

	/// <summary>
	/// Key: "Label.Delete"
	/// English String: "Delete"
	/// </summary>
	public override string LabelDelete => "삭제";

	/// <summary>
	/// Key: "Label.DeleteAllPostsByUser"
	/// English String: "Also delete all posts by this user."
	/// </summary>
	public override string LabelDeleteAllPostsByUser => "또한 본 사용자가 게시한 모든 게시물을 삭제합니다.";

	/// <summary>
	/// Key: "Label.DeleteAlly"
	/// English String: "Delete Ally"
	/// </summary>
	public override string LabelDeleteAlly => "동맹 삭제";

	/// <summary>
	/// Key: "Label.DeleteEnemy"
	/// English String: "Delete Enemy"
	/// </summary>
	public override string LabelDeleteEnemy => "적 삭제";

	/// <summary>
	/// Key: "Label.DeleteGroupPlace"
	/// English String: "Delete Group Place"
	/// </summary>
	public override string LabelDeleteGroupPlace => "그룹 장소 삭제";

	/// <summary>
	/// Key: "Label.DeletePost"
	/// English String: "Delete Post"
	/// </summary>
	public override string LabelDeletePost => "게시물 삭제";

	/// <summary>
	/// Key: "Label.Funds"
	/// English String: "Funds"
	/// </summary>
	public override string LabelFunds => "펀드";

	/// <summary>
	/// Key: "Label.GroupClosed"
	/// English String: "Group Closed"
	/// </summary>
	public override string LabelGroupClosed => "닫힌 그룹";

	/// <summary>
	/// Key: "Label.GroupLocked"
	/// English String: "This group has been locked"
	/// </summary>
	public override string LabelGroupLocked => "잠긴 그룹입니다";

	/// <summary>
	/// Key: "Label.InviteToClan"
	/// English String: "Invite to Clan"
	/// </summary>
	public override string LabelInviteToClan => "클랜에 초대";

	/// <summary>
	/// Key: "Label.KickFromClan"
	/// English String: "Kick from Clan"
	/// </summary>
	public override string LabelKickFromClan => "클랜에서 강제 퇴장";

	/// <summary>
	/// Key: "Label.Loading"
	/// English String: "Loading..."
	/// </summary>
	public override string LabelLoading => "로딩 중...";

	/// <summary>
	/// Key: "Label.Lock"
	/// English String: "Lock"
	/// </summary>
	public override string LabelLock => "잠금";

	/// <summary>
	/// Key: "Label.ManageGroupCreations"
	/// English String: "Create or manage group items."
	/// </summary>
	public override string LabelManageGroupCreations => "그룹 아이템 만들기 혹은 관리";

	/// <summary>
	/// Key: "Label.ManualApproval"
	/// English String: "Manual Approval"
	/// </summary>
	public override string LabelManualApproval => "매뉴얼 승인";

	/// <summary>
	/// Key: "Label.ModerateDiscussion"
	/// English String: "Moderate Discussion"
	/// </summary>
	public override string LabelModerateDiscussion => "토론 검열";

	/// <summary>
	/// Key: "Label.NoAllies"
	/// English String: "This group does not have any allies."
	/// </summary>
	public override string LabelNoAllies => "동맹이 없는 그룹입니다.";

	/// <summary>
	/// Key: "Label.NoEnemies"
	/// English String: "This group does not have any enemies."
	/// </summary>
	public override string LabelNoEnemies => "적이 없는 그룹입니다.";

	/// <summary>
	/// Key: "Label.NoGames"
	/// English String: "No games are associated with this group."
	/// </summary>
	public override string LabelNoGames => "본 그룹과 연결된 게임이 없습니다.";

	/// <summary>
	/// Key: "Label.NoMembersInRole"
	/// English String: "No group members are in this role."
	/// </summary>
	public override string LabelNoMembersInRole => "본 역할을 맡고 있는 멤버가 없습니다. ";

	/// <summary>
	/// Key: "Label.NoOne"
	/// English String: "No One!"
	/// </summary>
	public override string LabelNoOne => "아무도 없어요!";

	/// <summary>
	/// Key: "Label.NoStoreItems"
	/// English String: "No items are for sale in this group."
	/// </summary>
	public override string LabelNoStoreItems => "본 그룹에서 판매 중인 아이템이 없습니다.";

	/// <summary>
	/// Key: "Label.NoWallPosts"
	/// English String: "Nobody has said anything yet..."
	/// </summary>
	public override string LabelNoWallPosts => "아직 아무도 담벼락에 게시물을 게시하지 않았어요...";

	/// <summary>
	/// Key: "Label.OnlyBcCanJoin"
	/// English String: "Only Builders Club members can join"
	/// </summary>
	public override string LabelOnlyBcCanJoin => "Builders Club 멤버만 가입할 수 있습니다";

	/// <summary>
	/// Key: "Label.OnlyPremiumCanJoin"
	/// English String: "Only users with membership can join"
	/// </summary>
	public override string LabelOnlyPremiumCanJoin => "멤버십이 있는 사용자만 가입할 수 있음";

	/// <summary>
	/// Key: "Label.PrivateGroup"
	/// If group is invite only
	/// English String: "Private"
	/// </summary>
	public override string LabelPrivateGroup => "비공개";

	/// <summary>
	/// Key: "Label.PublicGroup"
	/// If group is open for anyone to join
	/// English String: "Public"
	/// </summary>
	public override string LabelPublicGroup => "공개";

	/// <summary>
	/// Key: "Label.PublishPlace"
	/// English String: "Publish Place"
	/// </summary>
	public override string LabelPublishPlace => "장소 게시";

	/// <summary>
	/// Key: "Label.RemoveGroupPlace"
	/// English String: "Remove Group Place"
	/// </summary>
	public override string LabelRemoveGroupPlace => "그룹 장소 삭제";

	/// <summary>
	/// Key: "Label.RemoveMember"
	/// English String: "Remove Member"
	/// </summary>
	public override string LabelRemoveMember => "멤버 삭제";

	/// <summary>
	/// Key: "Label.Rename"
	/// English String: "Rename"
	/// </summary>
	public override string LabelRename => "이름 변경";

	/// <summary>
	/// Key: "Label.RevertGroupAsset"
	/// English String: "Revert Group Asset"
	/// </summary>
	public override string LabelRevertGroupAsset => "그룹 애셋 복구";

	/// <summary>
	/// Key: "Label.SavePlace"
	/// English String: "Save Place"
	/// </summary>
	public override string LabelSavePlace => "장소 저장";

	/// <summary>
	/// Key: "Label.SearchGroups"
	/// English String: "Search All Groups"
	/// </summary>
	public override string LabelSearchGroups => "전체 그룹 검색";

	/// <summary>
	/// Key: "Label.SearchUsers"
	/// English String: "Search Users"
	/// </summary>
	public override string LabelSearchUsers => "사용자 검색";

	/// <summary>
	/// Key: "Label.SendAllyRequest"
	/// English String: "Send Ally Request"
	/// </summary>
	public override string LabelSendAllyRequest => "동맹 요청 보내기";

	/// <summary>
	/// Key: "Label.ShoutPlaceholder"
	/// English String: "Enter your shout"
	/// </summary>
	public override string LabelShoutPlaceholder => "샤우트를 입력하세요";

	/// <summary>
	/// Key: "Label.SpendGroupFunds"
	/// English String: "Spend Group Funds"
	/// </summary>
	public override string LabelSpendGroupFunds => "그룹 펀드 사용";

	/// <summary>
	/// Key: "Label.Success"
	/// English String: "Success"
	/// </summary>
	public override string LabelSuccess => "완료";

	/// <summary>
	/// Key: "Label.Unlock"
	/// English String: "Unlock"
	/// </summary>
	public override string LabelUnlock => "잠금 해제";

	/// <summary>
	/// Key: "Label.UpdateGroupAsset"
	/// English String: "Update Group Asset"
	/// </summary>
	public override string LabelUpdateGroupAsset => "그룹 애셋 업데이트";

	/// <summary>
	/// Key: "Label.WallPostPlaceholder"
	/// English String: "Say something..."
	/// </summary>
	public override string LabelWallPostPlaceholder => "내용을 입력하세요...";

	/// <summary>
	/// Key: "Label.WallPostsUnavailable"
	/// Displayed in the group wall area when we cannot successfully load wall posts
	/// English String: "Wall posts are temporarily unavailable, please check back later."
	/// </summary>
	public override string LabelWallPostsUnavailable => "일시적으로 담벼락 게시물을 이용할 수 없습니다. 나중에 다시 확인하세요.";

	/// <summary>
	/// Key: "Label.Warning"
	/// English String: "Warning"
	/// </summary>
	public override string LabelWarning => "주의";

	/// <summary>
	/// Key: "Message.AlreadyMember"
	/// English String: "You are already a member of this group."
	/// </summary>
	public override string MessageAlreadyMember => "이미 이 그룹의 회원입니다.";

	/// <summary>
	/// Key: "Message.AlreadyRequested"
	/// English String: "You have already requested to join this group."
	/// </summary>
	public override string MessageAlreadyRequested => "이미 이 그룹에 대한 가입 요청을 했어요.";

	/// <summary>
	/// Key: "Message.BuildGroupRolesListError"
	/// English String: "Unable to load members for selected role."
	/// </summary>
	public override string MessageBuildGroupRolesListError => "선택하신 역할을 맡고 있는 멤버를 불러올 수 없습니다.";

	/// <summary>
	/// Key: "Message.CannotClaimGroupWithOwner"
	/// English String: "This group already has an owner."
	/// </summary>
	public override string MessageCannotClaimGroupWithOwner => "이 그룹은 이미 소유자가 있어요.";

	/// <summary>
	/// Key: "Message.ChangeOwnerEmpty"
	/// English String: "There is no owner of the group"
	/// </summary>
	public override string MessageChangeOwnerEmpty => "그룹 소유자가 없어요";

	/// <summary>
	/// Key: "Message.ClaimOwnershipError"
	/// English String: "Unable to claim ownership of group."
	/// </summary>
	public override string MessageClaimOwnershipError => "그룹 소유권을 주장할 수 없습니다";

	/// <summary>
	/// Key: "Message.ClaimOwnershipSuccess"
	/// English String: "Successfully claimed ownership of group."
	/// </summary>
	public override string MessageClaimOwnershipSuccess => "그룹 소유권 주장 완료";

	/// <summary>
	/// Key: "Message.DefaultError"
	/// English String: "An error occurred."
	/// </summary>
	public override string MessageDefaultError => "오류가 발생했어요.";

	/// <summary>
	/// Key: "Message.DeleteWallPostError"
	/// English String: "Unable to delete wall post."
	/// </summary>
	public override string MessageDeleteWallPostError => "담벼락 게시물을 삭제할 수 없습니다.";

	/// <summary>
	/// Key: "Message.DeleteWallPostsByUserError"
	/// English String: "Unable to delete wall posts by user."
	/// </summary>
	public override string MessageDeleteWallPostsByUserError => "사용자가 게시한 담벼락 게시물을 삭제할 수 없습니다";

	/// <summary>
	/// Key: "Message.DeleteWallPostSuccess"
	/// English String: "Successfully deleted wall post."
	/// </summary>
	public override string MessageDeleteWallPostSuccess => "담벼락 게시물 삭제 완료.";

	/// <summary>
	/// Key: "Message.DescriptionTooLong"
	/// English String: "The description is too long."
	/// </summary>
	public override string MessageDescriptionTooLong => "설명이 너무 길어요.";

	/// <summary>
	/// Key: "Message.DuplicateName"
	/// English String: "Name is already taken. Please try another."
	/// </summary>
	public override string MessageDuplicateName => "이미 사용 중인 이름이에요. 다른 걸로 해 보세요.";

	/// <summary>
	/// Key: "Message.ExileUserError"
	/// English String: "Unable to exile user."
	/// </summary>
	public override string MessageExileUserError => "사용자를 추방할 수 없습니다.";

	/// <summary>
	/// Key: "Message.FeatureDisabled"
	/// English String: "The feature is disabled."
	/// </summary>
	public override string MessageFeatureDisabled => "이 기능이 비활성화되었습니다.";

	/// <summary>
	/// Key: "Message.GetGroupRelationshipsError"
	/// English String: "Unable to load group affiliates."
	/// </summary>
	public override string MessageGetGroupRelationshipsError => "파트너 그룹을 불러올 수 없습니다.";

	/// <summary>
	/// Key: "Message.GroupClosed"
	/// English String: "You cannot join a closed group."
	/// </summary>
	public override string MessageGroupClosed => "비공개 그룹은 가입할 수 없어요.";

	/// <summary>
	/// Key: "Message.GroupCreationDisabled"
	/// English String: "Group creation is currently disabled."
	/// </summary>
	public override string MessageGroupCreationDisabled => "그룹 생성은 현재 사용할 수 없습니다.";

	/// <summary>
	/// Key: "Message.GroupIconInvalid"
	/// English String: "Icon is missing or invalid."
	/// </summary>
	public override string MessageGroupIconInvalid => "아이콘이 누락되었거나 유효하지 않아요.";

	/// <summary>
	/// Key: "Message.GroupMembershipsUnavailableError"
	/// Error displayed on group details view when the system is in read-only mode for maintenance and you try to perform an action.
	/// English String: "The group membership system is temporarily unavailable. Please try again later."
	/// </summary>
	public override string MessageGroupMembershipsUnavailableError => "일시적으로 그룹 멤버십 시스템 이용 불가. 나중에 다시 시도하세요.";

	/// <summary>
	/// Key: "Message.InsufficientFunds"
	/// English String: "Insufficient Robux funds."
	/// </summary>
	public override string MessageInsufficientFunds => "Robux 자금이 부족해요.";

	/// <summary>
	/// Key: "Message.InsufficientGroupSpace"
	/// English String: "You are already in the maximum number of groups."
	/// </summary>
	public override string MessageInsufficientGroupSpace => "이미 그룹 가입자 수 한도에 도달했어요.";

	/// <summary>
	/// Key: "Message.InsufficientMembership"
	/// English String: "You do not have the builders club membership necessary to join this group."
	/// </summary>
	public override string MessageInsufficientMembership => "이 그룹에 필요한 빌더스 클럽 멤버십을 소유하고 있지 않습니다.";

	/// <summary>
	/// Key: "Message.InsufficientPermission"
	/// English String: "Insufficient permissions to complete the request."
	/// </summary>
	public override string MessageInsufficientPermission => "요청을 완료하기에 권한이 부족합니다.";

	/// <summary>
	/// Key: "Message.InsufficientPermissionsForRelationships"
	/// English String: "You don't have permission to manage this group's relationships."
	/// </summary>
	public override string MessageInsufficientPermissionsForRelationships => "이 그룹 관계를 설정할 수 있는 권한이 없습니다.";

	/// <summary>
	/// Key: "Message.InsufficientRobux"
	/// English String: "You do not have enough Robux to create the group."
	/// </summary>
	public override string MessageInsufficientRobux => "Robux가 부족해서 그룹을 만들 수 없어요.";

	/// <summary>
	/// Key: "Message.InvalidAmount"
	/// English String: "The amount is invalid."
	/// </summary>
	public override string MessageInvalidAmount => "금액이 유효하지 않습니다.";

	/// <summary>
	/// Key: "Message.InvalidGroup"
	/// English String: "Group is invalid or does not exist."
	/// </summary>
	public override string MessageInvalidGroup => "그룹이 유효하지 않거나 존재하지 않아요.";

	/// <summary>
	/// Key: "Message.InvalidGroupIcon"
	/// English String: "The group icon is invalid."
	/// </summary>
	public override string MessageInvalidGroupIcon => "그룹 아이콘이 잘못되었어요.";

	/// <summary>
	/// Key: "Message.InvalidGroupId"
	/// English String: "The group is invalid or does not exist."
	/// </summary>
	public override string MessageInvalidGroupId => "그룹이 잘못되었거나 존재하지 않아요.";

	/// <summary>
	/// Key: "Message.InvalidGroupWallPostId"
	/// English String: "The group wall post id is invalid or does not exist."
	/// </summary>
	public override string MessageInvalidGroupWallPostId => "그룹 담벼락 게시물 ID가 잘못되었거나 존재하지 않아요.";

	/// <summary>
	/// Key: "Message.InvalidIds"
	/// English String: "Ids could not be parsed from request."
	/// </summary>
	public override string MessageInvalidIds => "ID를 요청에서 분석할 수 없었어요.";

	/// <summary>
	/// Key: "Message.InvalidIdsError"
	/// English String: "Ids could not be parsed from request."
	/// </summary>
	public override string MessageInvalidIdsError => "ID를 요청에서 분석할 수 없었어요.";

	/// <summary>
	/// Key: "Message.InvalidMembership"
	/// English String: "User must have builders club membership."
	/// </summary>
	public override string MessageInvalidMembership => "빌더스 클럽 멤버십이 있어야 사용할 수 있습니다.";

	/// <summary>
	/// Key: "Message.InvalidName"
	/// English String: "The name is invalid."
	/// </summary>
	public override string MessageInvalidName => "이름이 유효하지 않아요.";

	/// <summary>
	/// Key: "Message.InvalidPaginationParameters"
	/// English String: "Invalid or missing pagination parameters."
	/// </summary>
	public override string MessageInvalidPaginationParameters => "페이지 매개변수가 잘못되었거나 누락되었습니다.";

	/// <summary>
	/// Key: "Message.InvalidPayoutType"
	/// English String: "Invalid payout type."
	/// </summary>
	public override string MessageInvalidPayoutType => "유효하지 않은 지불 유형입니다.";

	/// <summary>
	/// Key: "Message.InvalidRecipient"
	/// English String: "The recipient is invalid."
	/// </summary>
	public override string MessageInvalidRecipient => "수신자가 유효하지 않습니다.";

	/// <summary>
	/// Key: "Message.InvalidRelationshipType"
	/// English String: "Group relationship type is invalid."
	/// </summary>
	public override string MessageInvalidRelationshipType => "그룹 관계 유형이 잘못되었어요.";

	/// <summary>
	/// Key: "Message.InvalidRoleSetId"
	/// English String: "The roleset is invalid or does not exist."
	/// </summary>
	public override string MessageInvalidRoleSetId => "역할군이 잘못되었거나 존재하지 않아요.";

	/// <summary>
	/// Key: "Message.InvalidUser"
	/// English String: "The user is invalid or does not exist."
	/// </summary>
	public override string MessageInvalidUser => "사용자가 잘못되었거나 존재하지 않아요.";

	/// <summary>
	/// Key: "Message.InvalidWallPostContent"
	/// English String: "Your post was empty, white space, or more than 500 characters."
	/// </summary>
	public override string MessageInvalidWallPostContent => "게시물이 비어있거나, 공백이었거나, 500자를 초과했어요.";

	/// <summary>
	/// Key: "Message.JoinGroupError"
	/// English String: "Unable to join group."
	/// </summary>
	public override string MessageJoinGroupError => "그룹 가입을 할 수 없습니다.";

	/// <summary>
	/// Key: "Message.JoinGroupPendingSuccess"
	/// English String: "Requested to join group, your request is pending."
	/// </summary>
	public override string MessageJoinGroupPendingSuccess => "그룹 가입 요청이 대기 중입니다.";

	/// <summary>
	/// Key: "Message.JoinGroupSuccess"
	/// English String: "Successfully joined the group."
	/// </summary>
	public override string MessageJoinGroupSuccess => "그룹 가입 완료.";

	/// <summary>
	/// Key: "Message.LeaveGroupError"
	/// English String: "Unable to leave group."
	/// </summary>
	public override string MessageLeaveGroupError => "그룹을 나갈 수 없습니다.";

	/// <summary>
	/// Key: "Message.LoadGroupError"
	/// English String: "Unable to load group."
	/// </summary>
	public override string MessageLoadGroupError => "그룹을 불러올 수 없습니다.";

	/// <summary>
	/// Key: "Message.LoadGroupGamesError"
	/// English String: "Unable to load games."
	/// </summary>
	public override string MessageLoadGroupGamesError => "게임을 불러올 수 없습니다.";

	/// <summary>
	/// Key: "Message.LoadGroupListError"
	/// English String: "Unable to load group list."
	/// </summary>
	public override string MessageLoadGroupListError => "그룹 목록을 불러올 수 없습니다.";

	/// <summary>
	/// Key: "Message.LoadGroupMembershipsError"
	/// English String: "Unable to load user membership information."
	/// </summary>
	public override string MessageLoadGroupMembershipsError => "사용자 멤버십 정보를 불러올 수 없습니다.";

	/// <summary>
	/// Key: "Message.LoadGroupMetadataError"
	/// English String: "Unable to load group info."
	/// </summary>
	public override string MessageLoadGroupMetadataError => "그룹 정보를 불러올 수 없습니다.";

	/// <summary>
	/// Key: "Message.LoadGroupStoreItemsError"
	/// English String: "Unable to load store items."
	/// </summary>
	public override string MessageLoadGroupStoreItemsError => "상점 아이템을 불러올 수 없습니다.";

	/// <summary>
	/// Key: "Message.LoadUserGroupMembershipError"
	/// English String: "Unable to load group member information."
	/// </summary>
	public override string MessageLoadUserGroupMembershipError => "그룹의 멤버 정보를 불러올 수 없습니다.";

	/// <summary>
	/// Key: "Message.LoadWallPostsError"
	/// English String: "Unable to load wall posts."
	/// </summary>
	public override string MessageLoadWallPostsError => "담벼락 게시물을 불러올 수 없습니다.";

	/// <summary>
	/// Key: "Message.MakePrimaryError"
	/// English String: "Unable to make primary group."
	/// </summary>
	public override string MessageMakePrimaryError => "기본 그룹을 만들 수 없습니다.";

	/// <summary>
	/// Key: "Message.MaxGroups"
	/// English String: "User is in maximum number of groups."
	/// </summary>
	public override string MessageMaxGroups => "더 이상의 그룹에 가입할 수 없어요.";

	/// <summary>
	/// Key: "Message.MissingGroupIcon"
	/// English String: "The group icon is missing from the request."
	/// </summary>
	public override string MessageMissingGroupIcon => "요청에 그룹 아이콘이 누락되었어요.";

	/// <summary>
	/// Key: "Message.MissingGroupStatusContent"
	/// English String: "Missing group status content."
	/// </summary>
	public override string MessageMissingGroupStatusContent => "그룹 상태 내용이 없습니다.";

	/// <summary>
	/// Key: "Message.NameInvalid"
	/// English String: "Name is missing or has invalid characters."
	/// </summary>
	public override string MessageNameInvalid => "이름이 누락되었거나, 유효하지 않은 문자가 포함되어 있어요.";

	/// <summary>
	/// Key: "Message.NameModerated"
	/// English String: "The name is moderated."
	/// </summary>
	public override string MessageNameModerated => "이름이 조정되었어요.";

	/// <summary>
	/// Key: "Message.NameTaken"
	/// English String: "The name has been taken."
	/// </summary>
	public override string MessageNameTaken => "사용 중인 이름이에요.";

	/// <summary>
	/// Key: "Message.NameTooLong"
	/// English String: "The name is too long."
	/// </summary>
	public override string MessageNameTooLong => "이름이 너무 길어요.";

	/// <summary>
	/// Key: "Message.NoPrimary"
	/// English String: "The user specified does not have a primary group."
	/// </summary>
	public override string MessageNoPrimary => "이 특정 사용자는 기본 그룹이 없어요.";

	/// <summary>
	/// Key: "Message.PassCaptchaToJoin"
	/// English String: "You must pass the captcha test before joining this group."
	/// </summary>
	public override string MessagePassCaptchaToJoin => "이 그룹에 가입하려면 캡차 테스트를 통과해야 해요.";

	/// <summary>
	/// Key: "Message.PassCaptchaToPost"
	/// English String: "Captcha must be solved to post to the group wall."
	/// </summary>
	public override string MessagePassCaptchaToPost => "그룹 담벼락에 게시하려면 캡차를 풀어야 해요.";

	/// <summary>
	/// Key: "Message.RemovePrimaryError"
	/// English String: "Unable to remove primary group."
	/// </summary>
	public override string MessageRemovePrimaryError => "기본 그룹을 삭제할 수 없습니다.";

	/// <summary>
	/// Key: "Message.SearchTermCharactersLimit"
	/// English String: "The search term needs to be between 2 and 50 characters"
	/// </summary>
	public override string MessageSearchTermCharactersLimit => "검색어는 1자-25자 사이여야 해요";

	/// <summary>
	/// Key: "Message.SearchTermEmptyError"
	/// English String: "Search term is empty"
	/// </summary>
	public override string MessageSearchTermEmptyError => "검색어가 입력되지 않았어요";

	/// <summary>
	/// Key: "Message.SearchTermFilteredError"
	/// English String: "Search term was filtered"
	/// </summary>
	public override string MessageSearchTermFilteredError => "검색어가 필터링되었어요";

	/// <summary>
	/// Key: "Message.SendGroupShoutError"
	/// English String: "Unable to send group shout."
	/// </summary>
	public override string MessageSendGroupShoutError => "그룹 샤우트를 발송할 수 없습니다.";

	/// <summary>
	/// Key: "Message.SendPostError"
	/// English String: "Unable to send post."
	/// </summary>
	public override string MessageSendPostError => "게시물을 전송할 수 없습니다.";

	/// <summary>
	/// Key: "Message.TooManyAttempts"
	/// English String: "Too many attempts to join the group. Please try again later."
	/// </summary>
	public override string MessageTooManyAttempts => "그룹 가입 시도가 너무 많아요. 나중에 다시 시도하세요.";

	/// <summary>
	/// Key: "Message.TooManyAttemptsToClaimGroups"
	/// English String: "Too many attempts to claim groups. Please try again later."
	/// </summary>
	public override string MessageTooManyAttemptsToClaimGroups => "그룹 소유 시도가 너무 많아요. 나중에 다시 시도하세요.";

	/// <summary>
	/// Key: "Message.TooManyGroups"
	/// English String: "You have reached the group capacity. Please leave a group before creating a new one."
	/// </summary>
	public override string MessageTooManyGroups => "그룹 수가 한도에 도달했습니다. 새 그룹을 만들기 전에 그룹 하나에서 나가세요.";

	/// <summary>
	/// Key: "Message.TooManyIds"
	/// English String: "Too many ids in request."
	/// </summary>
	public override string MessageTooManyIds => "요청에 ID가 너무 많아요.";

	/// <summary>
	/// Key: "Message.TooManyPosts"
	/// English String: "You are posting too fast, please try again in a few minutes."
	/// </summary>
	public override string MessageTooManyPosts => "게시 속도가 너무 빨라요, 몇 분 후에 다시 시도하세요.";

	/// <summary>
	/// Key: "Message.TooManyRequests"
	/// English String: "Too many requests."
	/// </summary>
	public override string MessageTooManyRequests => "요청이 너무 많아요.";

	/// <summary>
	/// Key: "Message.UnauthorizedForPostStatus"
	/// English String: "You are not authorized to set the status of this group."
	/// </summary>
	public override string MessageUnauthorizedForPostStatus => "이 그룹의 상태를 설정할 수 있는 권한이 없습니다.";

	/// <summary>
	/// Key: "Message.UnauthorizedForViewGroupPayouts"
	/// English String: "You don't have permission to view this group's payouts."
	/// </summary>
	public override string MessageUnauthorizedForViewGroupPayouts => "이 그룹의 지불금을 볼 수 있는 권한이 없습니다.";

	/// <summary>
	/// Key: "Message.UnauthorizedToClaimGroup"
	/// English String: "You are not authorized to claim this group."
	/// </summary>
	public override string MessageUnauthorizedToClaimGroup => "이 그룹을 소유할 권한이 없어요.";

	/// <summary>
	/// Key: "Message.UnauthorizedToManageMember"
	/// English String: "You do not have permission to manage this member."
	/// </summary>
	public override string MessageUnauthorizedToManageMember => "이 회원을 관리할 권한이 없어요.";

	/// <summary>
	/// Key: "Message.UnauthorizedToViewRolesetPermissions"
	/// English String: "You are not authorized to view permissions for this roleset."
	/// </summary>
	public override string MessageUnauthorizedToViewRolesetPermissions => "이 역할군의 권한을 볼 권한이 없어요.";

	/// <summary>
	/// Key: "Message.UnauthorizedToViewWall"
	/// English String: "You do not have permission to access this group wall."
	/// </summary>
	public override string MessageUnauthorizedToViewWall => "이 그룹 담벼락에 접근할 권한이 없습니다.";

	/// <summary>
	/// Key: "Message.UnknownError"
	/// English String: "Unknown error"
	/// </summary>
	public override string MessageUnknownError => "알 수 없는 오류";

	/// <summary>
	/// Key: "Message.UserNotInGroup"
	/// English String: "You aren't a member of the group specified."
	/// </summary>
	public override string MessageUserNotInGroup => "이 특정 그룹의 회원이 아닙니다.";

	public GroupsResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAdvertiseGroup()
	{
		return "그룹 홍보";
	}

	protected override string _GetTemplateForActionAuditLog()
	{
		return "그룹 활동 로그";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "취소";
	}

	protected override string _GetTemplateForActionCancelRequest()
	{
		return "요청 취소";
	}

	protected override string _GetTemplateForActionClaimOwnership()
	{
		return "소유권 주장";
	}

	protected override string _GetTemplateForActionClose()
	{
		return "닫기";
	}

	protected override string _GetTemplateForActionConfigureGroup()
	{
		return "그룹 구성";
	}

	protected override string _GetTemplateForActionCreateGroup()
	{
		return "그룹 만들기";
	}

	protected override string _GetTemplateForActionDelete()
	{
		return "삭제";
	}

	protected override string _GetTemplateForActionExile()
	{
		return "추방";
	}

	protected override string _GetTemplateForActionExileUser()
	{
		return "사용자 추방";
	}

	protected override string _GetTemplateForActionGroupAdmin()
	{
		return "그룹 관리자";
	}

	protected override string _GetTemplateForActionGroupShout()
	{
		return "그룹 샤우트";
	}

	protected override string _GetTemplateForActionJoinGroup()
	{
		return "그룹 가입";
	}

	protected override string _GetTemplateForActionLeaveGroup()
	{
		return "그룹 나가기";
	}

	protected override string _GetTemplateForActionMakePrimary()
	{
		return "기본 그룹으로 설정";
	}

	protected override string _GetTemplateForActionMakePrimaryGroup()
	{
		return "기본 그룹 만들기";
	}

	protected override string _GetTemplateForActionPost()
	{
		return "게시물";
	}

	protected override string _GetTemplateForActionPurchase()
	{
		return "구매";
	}

	protected override string _GetTemplateForActionRemovePrimary()
	{
		return "기본 그룹 삭제";
	}

	protected override string _GetTemplateForActionReport()
	{
		return "신고";
	}

	protected override string _GetTemplateForActionReportAbuse()
	{
		return "신고하기";
	}

	protected override string _GetTemplateForActionUpgrade()
	{
		return "업그레이드";
	}

	protected override string _GetTemplateForActionUpgradeToJoin()
	{
		return "업그레이드";
	}

	protected override string _GetTemplateForActionYes()
	{
		return "네";
	}

	protected override string _GetTemplateForDescriptionClothingRevenue()
	{
		return "그룹에서는 그룹 자체 공식 셔츠, 바지, 티셔츠를 개발 및 판매할 수 있습니다! 모든 수입은 그룹 펀드에 적립됩니다.";
	}

	protected override string _GetTemplateForDescriptionDeleteAllPostsByUser()
	{
		return "본 사용자가 게시한 모든 게시물도 삭제합니다.";
	}

	protected override string _GetTemplateForDescriptionExileUserWarning()
	{
		return "본 사용자를 정말 추방하시겠습니까?";
	}

	protected override string _GetTemplateForDescriptionLeaveGroupAsOwnerWarning()
	{
		return "주인 없는 그룹이 됩니다.";
	}

	protected override string _GetTemplateForDescriptionLeaveGroupWarning()
	{
		return "정말 본 그룹을 나가시겠습니까?";
	}

	protected override string _GetTemplateForDescriptionMakePrimaryGroupWarning()
	{
		return "정말 본 그룹을 기본 그룹으로 설정하시겠습니까?";
	}

	protected override string _GetTemplateForDescriptionNoneMaxGroups()
	{
		return "더 많은 그룹에 가입하려면 Builders Club을 업그레이드하세요.";
	}

	protected override string _GetTemplateForDescriptionNoneMaxGroupsPremium()
	{
		return "Roblox Premium으로 업그레이드해서 더 많은 그룹에 가입하세요.";
	}

	protected override string _GetTemplateForDescriptionnoneMaxGroupsPremiumText()
	{
		return "Roblox Premium으로 업그레이드해서 더 많은 그룹에 가입하세요.";
	}

	protected override string _GetTemplateForDescriptionObcMaxGroups()
	{
		return "가입한 그룹 수가 한도에 도달했어요.";
	}

	protected override string _GetTemplateForDescriptionOtherBcMaxGroups()
	{
		return "더 많은 그룹에 가입하려면 Builders Club을 업그레이드하세요.";
	}

	protected override string _GetTemplateForDescriptionotherPremiumMaxGroupsText()
	{
		return "Roblox Premium을 업그레이드해서 더 많은 그룹에 가입하세요.";
	}

	protected override string _GetTemplateForDescriptionPremiumMaxGroups()
	{
		return "그룹 가입자 수 한도에 도달했어요.";
	}

	protected override string _GetTemplateForDescriptionPurchaseBody()
	{
		return "이 그룹을 만들까요? 비용:";
	}

	protected override string _GetTemplateForDescriptionRemovePrimaryGroupWarning()
	{
		return "정말 회원님의 기본 그룹을 삭제하시겠습니까?";
	}

	protected override string _GetTemplateForDescriptionReportAbuseDescription()
	{
		return "어떤 내용을 신고할까요?";
	}

	protected override string _GetTemplateForDescriptionWallPrivacySettings()
	{
		return "개인정보 설정 때문에 그룹 담벼락에 게시물을 게시할 수 없습니다. 여기를 클릭하여 설정을 변경하세요.";
	}

	protected override string _GetTemplateForHeadingAbout()
	{
		return "소개";
	}

	protected override string _GetTemplateForHeadingAffiliates()
	{
		return "파트너";
	}

	protected override string _GetTemplateForHeadingAllies()
	{
		return "동맹";
	}

	/// <summary>
	/// Key: "Heading.ConfigureGroup"
	/// English String: "Configure {groupName}"
	/// </summary>
	public override string HeadingConfigureGroup(string groupName)
	{
		return $"{groupName} 구성";
	}

	protected override string _GetTemplateForHeadingConfigureGroup()
	{
		return "{groupName} 구성";
	}

	protected override string _GetTemplateForHeadingDate()
	{
		return "날짜";
	}

	protected override string _GetTemplateForHeadingDescription()
	{
		return "설명";
	}

	protected override string _GetTemplateForHeadingEnemies()
	{
		return "적";
	}

	protected override string _GetTemplateForHeadingExileUserWarning()
	{
		return "주의";
	}

	protected override string _GetTemplateForHeadingFunds()
	{
		return "펀드";
	}

	protected override string _GetTemplateForHeadingGames()
	{
		return "게임";
	}

	protected override string _GetTemplateForHeadingGroupPurchase()
	{
		return "그룹 구매 확인";
	}

	protected override string _GetTemplateForHeadingGroupShout()
	{
		return "그룹 샤우트";
	}

	protected override string _GetTemplateForHeadingLeaveGroup()
	{
		return "그룹 탈퇴";
	}

	protected override string _GetTemplateForHeadingMakePrimaryGroup()
	{
		return "기본 그룹 만들기";
	}

	protected override string _GetTemplateForHeadingMembers()
	{
		return "멤버";
	}

	protected override string _GetTemplateForHeadingNameOrDescription()
	{
		return "이름 또는 설명";
	}

	protected override string _GetTemplateForHeadingPayouts()
	{
		return "지불금";
	}

	protected override string _GetTemplateForHeadingPrimary()
	{
		return "기본";
	}

	protected override string _GetTemplateForHeadingRank()
	{
		return "순위";
	}

	protected override string _GetTemplateForHeadingRemovePrimaryGroup()
	{
		return "기본 그룹 삭제";
	}

	protected override string _GetTemplateForHeadingRole()
	{
		return "역할";
	}

	protected override string _GetTemplateForHeadingSettings()
	{
		return "설정";
	}

	protected override string _GetTemplateForHeadingShout()
	{
		return "샤우트";
	}

	protected override string _GetTemplateForHeadingStore()
	{
		return "상점";
	}

	protected override string _GetTemplateForHeadingUser()
	{
		return "사용자";
	}

	protected override string _GetTemplateForHeadingWall()
	{
		return "담벼락";
	}

	protected override string _GetTemplateForLabelAbandon()
	{
		return "폐기";
	}

	protected override string _GetTemplateForLabelAcceptAllyRequest()
	{
		return "동맹 요청 수락";
	}

	protected override string _GetTemplateForLabelAcceptJoinRequest()
	{
		return "가입 요청 수락";
	}

	protected override string _GetTemplateForLabelAddGroupPlace()
	{
		return "그룹 장소 추가";
	}

	protected override string _GetTemplateForLabelAdjustCurrencyAmounts()
	{
		return "통화 금액 조정";
	}

	protected override string _GetTemplateForLabelAll()
	{
		return "모두";
	}

	protected override string _GetTemplateForLabelAnyoneCanJoin()
	{
		return "누구나 가입 가능";
	}

	protected override string _GetTemplateForLabelBuyAd()
	{
		return "광고 구매";
	}

	protected override string _GetTemplateForLabelBuyClan()
	{
		return "클랜 구매";
	}

	protected override string _GetTemplateForLabelByOwner()
	{
		return "제작:";
	}

	protected override string _GetTemplateForLabelCancelClanInvite()
	{
		return "클랜 초대 취소";
	}

	protected override string _GetTemplateForLabelChangeDescription()
	{
		return "설명 변경";
	}

	protected override string _GetTemplateForLabelChangeOwner()
	{
		return "소유자 변경";
	}

	protected override string _GetTemplateForLabelChangeRank()
	{
		return "순위 변경";
	}

	protected override string _GetTemplateForLabelClaim()
	{
		return "클레임";
	}

	protected override string _GetTemplateForLabelConfigureBadge()
	{
		return "배지 구성";
	}

	protected override string _GetTemplateForLabelConfigureGroupAsset()
	{
		return "그룹 애셋 구성";
	}

	protected override string _GetTemplateForLabelConfigureGroupDevelopmentItem()
	{
		return "그룹 개발 아이템 구성";
	}

	protected override string _GetTemplateForLabelConfigureGroupGame()
	{
		return "그룹 게임 구성";
	}

	protected override string _GetTemplateForLabelConfigureItems()
	{
		return "아이템 구성";
	}

	protected override string _GetTemplateForLabelCreateBadge()
	{
		return "배지 생성";
	}

	protected override string _GetTemplateForLabelCreateEnemy()
	{
		return "적 생성";
	}

	protected override string _GetTemplateForLabelCreateGamePass()
	{
		return "게임패스 생성";
	}

	protected override string _GetTemplateForLabelCreateGroup()
	{
		return "그룹 만들기";
	}

	protected override string _GetTemplateForLabelCreateGroupAsset()
	{
		return "그룹 애셋 생성";
	}

	protected override string _GetTemplateForLabelCreateGroupBuildersClubTooltip()
	{
		return "그룹을 만들려면 Builders Club 멤버십이 필요합니다.";
	}

	protected override string _GetTemplateForLabelCreateGroupDescription()
	{
		return "설명 (선택사항)";
	}

	protected override string _GetTemplateForLabelCreateGroupDeveloperProduct()
	{
		return "그룹 개발자 상품 생성";
	}

	protected override string _GetTemplateForLabelCreateGroupEmblem()
	{
		return "엠블럼";
	}

	protected override string _GetTemplateForLabelCreateGroupFee()
	{
		return "그룹 생성 수수료";
	}

	protected override string _GetTemplateForLabelCreateGroupName()
	{
		return "그룹 이름 설정";
	}

	protected override string _GetTemplateForLabelCreateGroupPremiumTooltip()
	{
		return "그룹을 생성하려면 Roblox Premium 멤버십이 필요해요.";
	}

	protected override string _GetTemplateForLabelCreateGroupTooltip()
	{
		return "새 그룹 만들기";
	}

	protected override string _GetTemplateForLabelCreateItems()
	{
		return "아이템 생성";
	}

	protected override string _GetTemplateForLabelDeclineAllyRequest()
	{
		return "동맹 요청 거절";
	}

	protected override string _GetTemplateForLabelDeclineJoinRequest()
	{
		return "가입 요청 거절";
	}

	protected override string _GetTemplateForLabelDelete()
	{
		return "삭제";
	}

	protected override string _GetTemplateForLabelDeleteAllPostsByUser()
	{
		return "또한 본 사용자가 게시한 모든 게시물을 삭제합니다.";
	}

	protected override string _GetTemplateForLabelDeleteAlly()
	{
		return "동맹 삭제";
	}

	protected override string _GetTemplateForLabelDeleteEnemy()
	{
		return "적 삭제";
	}

	protected override string _GetTemplateForLabelDeleteGroupPlace()
	{
		return "그룹 장소 삭제";
	}

	protected override string _GetTemplateForLabelDeletePost()
	{
		return "게시물 삭제";
	}

	protected override string _GetTemplateForLabelFunds()
	{
		return "펀드";
	}

	protected override string _GetTemplateForLabelGroupClosed()
	{
		return "닫힌 그룹";
	}

	protected override string _GetTemplateForLabelGroupLocked()
	{
		return "잠긴 그룹입니다";
	}

	/// <summary>
	/// Key: "Label.GroupSearchResults"
	/// English String: "Group Results For {searchTerm}"
	/// </summary>
	public override string LabelGroupSearchResults(string searchTerm)
	{
		return $"{searchTerm}에 대한 그룹 검색 결과";
	}

	protected override string _GetTemplateForLabelGroupSearchResults()
	{
		return "{searchTerm}에 대한 그룹 검색 결과";
	}

	protected override string _GetTemplateForLabelInviteToClan()
	{
		return "클랜에 초대";
	}

	protected override string _GetTemplateForLabelKickFromClan()
	{
		return "클랜에서 강제 퇴장";
	}

	protected override string _GetTemplateForLabelLoading()
	{
		return "로딩 중...";
	}

	protected override string _GetTemplateForLabelLock()
	{
		return "잠금";
	}

	protected override string _GetTemplateForLabelManageGroupCreations()
	{
		return "그룹 아이템 만들기 혹은 관리";
	}

	protected override string _GetTemplateForLabelManualApproval()
	{
		return "매뉴얼 승인";
	}

	/// <summary>
	/// Key: "Label.MaxGroupsTooltip"
	/// English String: "You may only be in a maximum of {maxGroups} groups at one time"
	/// </summary>
	public override string LabelMaxGroupsTooltip(string maxGroups)
	{
		return $"한 번에 최대 {maxGroups} 그룹까지만 참가 가능합니다";
	}

	protected override string _GetTemplateForLabelMaxGroupsTooltip()
	{
		return "한 번에 최대 {maxGroups} 그룹까지만 참가 가능합니다";
	}

	protected override string _GetTemplateForLabelMembers()
	{
		return "{memberCount, plural, =0 {# 멤버} =1 {# 멤버} other {# 멤버}}";
	}

	protected override string _GetTemplateForLabelModerateDiscussion()
	{
		return "토론 검열";
	}

	protected override string _GetTemplateForLabelNoAllies()
	{
		return "동맹이 없는 그룹입니다.";
	}

	protected override string _GetTemplateForLabelNoEnemies()
	{
		return "적이 없는 그룹입니다.";
	}

	protected override string _GetTemplateForLabelNoGames()
	{
		return "본 그룹과 연결된 게임이 없습니다.";
	}

	protected override string _GetTemplateForLabelNoMembersInRole()
	{
		return "본 역할을 맡고 있는 멤버가 없습니다. ";
	}

	protected override string _GetTemplateForLabelNoOne()
	{
		return "아무도 없어요!";
	}

	/// <summary>
	/// Key: "Label.NoResults"
	/// English String: "No results for \"{searchTerm}\""
	/// </summary>
	public override string LabelNoResults(string searchTerm)
	{
		return $"\"{searchTerm}\"에 대한 검색 결과 없음";
	}

	protected override string _GetTemplateForLabelNoResults()
	{
		return "\"{searchTerm}\"에 대한 검색 결과 없음";
	}

	protected override string _GetTemplateForLabelNoStoreItems()
	{
		return "본 그룹에서 판매 중인 아이템이 없습니다.";
	}

	protected override string _GetTemplateForLabelNoWallPosts()
	{
		return "아직 아무도 담벼락에 게시물을 게시하지 않았어요...";
	}

	protected override string _GetTemplateForLabelOnlyBcCanJoin()
	{
		return "Builders Club 멤버만 가입할 수 있습니다";
	}

	protected override string _GetTemplateForLabelOnlyPremiumCanJoin()
	{
		return "멤버십이 있는 사용자만 가입할 수 있음";
	}

	protected override string _GetTemplateForLabelPrivateGroup()
	{
		return "비공개";
	}

	protected override string _GetTemplateForLabelPublicGroup()
	{
		return "공개";
	}

	protected override string _GetTemplateForLabelPublishPlace()
	{
		return "장소 게시";
	}

	protected override string _GetTemplateForLabelRemoveGroupPlace()
	{
		return "그룹 장소 삭제";
	}

	protected override string _GetTemplateForLabelRemoveMember()
	{
		return "멤버 삭제";
	}

	protected override string _GetTemplateForLabelRename()
	{
		return "이름 변경";
	}

	protected override string _GetTemplateForLabelRevertGroupAsset()
	{
		return "그룹 애셋 복구";
	}

	protected override string _GetTemplateForLabelSavePlace()
	{
		return "장소 저장";
	}

	protected override string _GetTemplateForLabelSearchGroups()
	{
		return "전체 그룹 검색";
	}

	protected override string _GetTemplateForLabelSearchUsers()
	{
		return "사용자 검색";
	}

	protected override string _GetTemplateForLabelSendAllyRequest()
	{
		return "동맹 요청 보내기";
	}

	protected override string _GetTemplateForLabelShoutPlaceholder()
	{
		return "샤우트를 입력하세요";
	}

	protected override string _GetTemplateForLabelSpendGroupFunds()
	{
		return "그룹 펀드 사용";
	}

	protected override string _GetTemplateForLabelSuccess()
	{
		return "완료";
	}

	protected override string _GetTemplateForLabelUnlock()
	{
		return "잠금 해제";
	}

	protected override string _GetTemplateForLabelUpdateGroupAsset()
	{
		return "그룹 애셋 업데이트";
	}

	protected override string _GetTemplateForLabelWallPostPlaceholder()
	{
		return "내용을 입력하세요...";
	}

	protected override string _GetTemplateForLabelWallPostsUnavailable()
	{
		return "일시적으로 담벼락 게시물을 이용할 수 없습니다. 나중에 다시 확인하세요.";
	}

	protected override string _GetTemplateForLabelWarning()
	{
		return "주의";
	}

	/// <summary>
	/// Key: "Message.Abandon"
	/// English String: "{actor} (group owner) abandoned the group"
	/// </summary>
	public override string MessageAbandon(string actor)
	{
		return $"{actor}(그룹 소유자)님이 그룹을 떠났어요";
	}

	protected override string _GetTemplateForMessageAbandon()
	{
		return "{actor}(그룹 소유자)님이 그룹을 떠났어요";
	}

	/// <summary>
	/// Key: "Message.AcceptAllyRequest"
	/// English String: "{actor} accepted group {group}'s ally request"
	/// </summary>
	public override string MessageAcceptAllyRequest(string actor, string group)
	{
		return $"{actor}님이 {group} 그룹의 동맹 요청을 수락했어요";
	}

	protected override string _GetTemplateForMessageAcceptAllyRequest()
	{
		return "{actor}님이 {group} 그룹의 동맹 요청을 수락했어요";
	}

	/// <summary>
	/// Key: "Message.AcceptJoinRequest"
	/// English String: "{actor} accepted user {user}'s join request"
	/// </summary>
	public override string MessageAcceptJoinRequest(string actor, string user)
	{
		return $"{actor}님이 {user}님의 가입 신청을 수락했어요";
	}

	protected override string _GetTemplateForMessageAcceptJoinRequest()
	{
		return "{actor}님이 {user}님의 가입 신청을 수락했어요";
	}

	/// <summary>
	/// Key: "Message.AddGroupPlace"
	/// English String: "{actor} added game {game} as a group game"
	/// </summary>
	public override string MessageAddGroupPlace(string actor, string game)
	{
		return $"{actor}님이 {game} 게임을 그룹 게임으로 추가했어요";
	}

	protected override string _GetTemplateForMessageAddGroupPlace()
	{
		return "{actor}님이 {game} 게임을 그룹 게임으로 추가했어요";
	}

	/// <summary>
	/// Key: "Message.AdjustCurrencyAmountsDecreased"
	/// English String: "{actor} decreased group funds by {amount}"
	/// </summary>
	public override string MessageAdjustCurrencyAmountsDecreased(string actor, string amount)
	{
		return $"{actor}님이 그룹 펀드를 {amount}으로 감액했어요";
	}

	protected override string _GetTemplateForMessageAdjustCurrencyAmountsDecreased()
	{
		return "{actor}님이 그룹 펀드를 {amount}으로 감액했어요";
	}

	/// <summary>
	/// Key: "Message.AdjustCurrencyAmountsIncreased"
	/// English String: "{actor} increased group funds by {amount}"
	/// </summary>
	public override string MessageAdjustCurrencyAmountsIncreased(string actor, string amount)
	{
		return $"{actor}님이 그룹 펀드를 {amount}으로 증액했어요";
	}

	protected override string _GetTemplateForMessageAdjustCurrencyAmountsIncreased()
	{
		return "{actor}님이 그룹 펀드를 {amount}으로 증액했어요";
	}

	protected override string _GetTemplateForMessageAlreadyMember()
	{
		return "이미 이 그룹의 회원입니다.";
	}

	protected override string _GetTemplateForMessageAlreadyRequested()
	{
		return "이미 이 그룹에 대한 가입 요청을 했어요.";
	}

	protected override string _GetTemplateForMessageBuildGroupRolesListError()
	{
		return "선택하신 역할을 맡고 있는 멤버를 불러올 수 없습니다.";
	}

	/// <summary>
	/// Key: "Message.BuyAd"
	/// English String: "{actor} bid {bid} on group ad {adName}"
	/// </summary>
	public override string MessageBuyAd(string actor, string bid, string adName)
	{
		return $"{actor}님이 그룹 광고 {adName}에 {bid} 입찰했어요";
	}

	protected override string _GetTemplateForMessageBuyAd()
	{
		return "{actor}님이 그룹 광고 {adName}에 {bid} 입찰했어요";
	}

	/// <summary>
	/// Key: "Message.BuyClan"
	/// English String: "{actor} bought a group clan"
	/// </summary>
	public override string MessageBuyClan(string actor)
	{
		return $"{actor}님이 그룹 클랜을 구매했어요";
	}

	protected override string _GetTemplateForMessageBuyClan()
	{
		return "{actor}님이 그룹 클랜을 구매했어요";
	}

	/// <summary>
	/// Key: "Message.CancelClanInvite"
	/// English String: "{actor} cancelled {user}'s clan invite"
	/// </summary>
	public override string MessageCancelClanInvite(string actor, string user)
	{
		return $"{actor}님이 {user}님의 클랜 초대를 취소했어요";
	}

	protected override string _GetTemplateForMessageCancelClanInvite()
	{
		return "{actor}님이 {user}님의 클랜 초대를 취소했어요";
	}

	protected override string _GetTemplateForMessageCannotClaimGroupWithOwner()
	{
		return "이 그룹은 이미 소유자가 있어요.";
	}

	/// <summary>
	/// Key: "Message.ChangeDescription"
	/// English String: "{actor} changed the description to \"{newDescription}\""
	/// </summary>
	public override string MessageChangeDescription(string actor, string newDescription)
	{
		return $"{actor}님이 설명을 \"{newDescription}\"(으)로 수정했어요";
	}

	protected override string _GetTemplateForMessageChangeDescription()
	{
		return "{actor}님이 설명을 \"{newDescription}\"(으)로 수정했어요";
	}

	/// <summary>
	/// Key: "Message.ChangeOwner"
	/// English String: "{actor} changed the group owner. {user} is the new group owner"
	/// </summary>
	public override string MessageChangeOwner(string actor, string user)
	{
		return $"{actor}님이 그룹 소유자를 변경했어요. 새로운 그룹 소유자는 {user}님이에요";
	}

	protected override string _GetTemplateForMessageChangeOwner()
	{
		return "{actor}님이 그룹 소유자를 변경했어요. 새로운 그룹 소유자는 {user}님이에요";
	}

	protected override string _GetTemplateForMessageChangeOwnerEmpty()
	{
		return "그룹 소유자가 없어요";
	}

	/// <summary>
	/// Key: "Message.ChangeRank"
	/// English String: "{actor} changed user {user}'s rank from {oldRoleSet} to {newRoleSet}"
	/// </summary>
	public override string MessageChangeRank(string actor, string user, string oldRoleSet, string newRoleSet)
	{
		return $"{actor}님이 {user}님의 등급을 {oldRoleSet}에서 {newRoleSet}(으)로 변경했어요 ";
	}

	protected override string _GetTemplateForMessageChangeRank()
	{
		return "{actor}님이 {user}님의 등급을 {oldRoleSet}에서 {newRoleSet}(으)로 변경했어요 ";
	}

	/// <summary>
	/// Key: "Message.Claim"
	/// English String: "{actor} claimed ownership of the group"
	/// </summary>
	public override string MessageClaim(string actor)
	{
		return $"{actor}님이 그룹의 소유권을 주장했어요";
	}

	protected override string _GetTemplateForMessageClaim()
	{
		return "{actor}님이 그룹의 소유권을 주장했어요";
	}

	protected override string _GetTemplateForMessageClaimOwnershipError()
	{
		return "그룹 소유권을 주장할 수 없습니다";
	}

	protected override string _GetTemplateForMessageClaimOwnershipSuccess()
	{
		return "그룹 소유권 주장 완료";
	}

	/// <summary>
	/// Key: "Message.ConfigureAsset"
	/// English String: "{actor} updated asset {item}: {actions}"
	/// </summary>
	public override string MessageConfigureAsset(string actor, string item, string actions)
	{
		return $"{actor}님이 {item} 애셋을 업데이트함: {actions}";
	}

	protected override string _GetTemplateForMessageConfigureAsset()
	{
		return "{actor}님이 {item} 애셋을 업데이트함: {actions}";
	}

	/// <summary>
	/// Key: "Message.ConfigureBadgeDisabled"
	/// English String: "{actor} disabled the badge {badge}"
	/// </summary>
	public override string MessageConfigureBadgeDisabled(string actor, string badge)
	{
		return $"{actor}님이 {badge} 배지를 비활성화했어요";
	}

	protected override string _GetTemplateForMessageConfigureBadgeDisabled()
	{
		return "{actor}님이 {badge} 배지를 비활성화했어요";
	}

	/// <summary>
	/// Key: "Message.ConfigureBadgeEnabled"
	/// English String: "{actor} enabled the badge {badge}"
	/// </summary>
	public override string MessageConfigureBadgeEnabled(string actor, string badge)
	{
		return $"{actor}님이 {badge} 배지를 활성화했어요";
	}

	protected override string _GetTemplateForMessageConfigureBadgeEnabled()
	{
		return "{actor}님이 {badge} 배지를 활성화했어요";
	}

	/// <summary>
	/// Key: "Message.ConfigureBadgeUpdate"
	/// English String: "{actor} configured the badge {badge}"
	/// </summary>
	public override string MessageConfigureBadgeUpdate(string actor, string badge)
	{
		return $"{actor}님이 {badge} 배지를 구성했어요";
	}

	protected override string _GetTemplateForMessageConfigureBadgeUpdate()
	{
		return "{actor}님이 {badge} 배지를 구성했어요";
	}

	/// <summary>
	/// Key: "Message.ConfigureGame"
	/// English String: "{actor} updated {game}: {actions}"
	/// </summary>
	public override string MessageConfigureGame(string actor, string game, string actions)
	{
		return $"{actor}님이 {game}을(를) 업데이트함: {actions}";
	}

	protected override string _GetTemplateForMessageConfigureGame()
	{
		return "{actor}님이 {game}을(를) 업데이트함: {actions}";
	}

	/// <summary>
	/// Key: "Message.ConfigureGameDeveloperProduct"
	/// English String: "{actor} updated developer product {id}: {actions}"
	/// </summary>
	public override string MessageConfigureGameDeveloperProduct(string actor, string id, string actions)
	{
		return $"{actor}님이 개발자 상품 {id}을(를) 업데이트함: {actions}";
	}

	protected override string _GetTemplateForMessageConfigureGameDeveloperProduct()
	{
		return "{actor}님이 개발자 상품 {id}을(를) 업데이트함: {actions}";
	}

	/// <summary>
	/// Key: "Message.ConfigureItems"
	/// English String: "{actor} configured the group item {item}"
	/// </summary>
	public override string MessageConfigureItems(string actor, string item)
	{
		return $"{actor}님이 그룹 아이템 {item}을(를) 구성했어요";
	}

	protected override string _GetTemplateForMessageConfigureItems()
	{
		return "{actor}님이 그룹 아이템 {item}을(를) 구성했어요";
	}

	/// <summary>
	/// Key: "Message.CreateAsset"
	/// English String: "{actor} created asset {item}"
	/// </summary>
	public override string MessageCreateAsset(string actor, string item)
	{
		return $"{actor}님이 {item} 애셋을 생성했어요";
	}

	protected override string _GetTemplateForMessageCreateAsset()
	{
		return "{actor}님이 {item} 애셋을 생성했어요";
	}

	/// <summary>
	/// Key: "Message.CreateBadge"
	/// English String: "{actor} created the badge {badge}"
	/// </summary>
	public override string MessageCreateBadge(string actor, string badge)
	{
		return $"{actor}님이 {badge} 배지를 생성했어요";
	}

	protected override string _GetTemplateForMessageCreateBadge()
	{
		return "{actor}님이 {badge} 배지를 생성했어요";
	}

	/// <summary>
	/// Key: "Message.CreateDeveloperProduct"
	/// English String: "{actor} created developer product with id {id}"
	/// </summary>
	public override string MessageCreateDeveloperProduct(string actor, string id)
	{
		return $"{actor}님이 ID가 {id}인 개발자 상품을 만들었어요";
	}

	protected override string _GetTemplateForMessageCreateDeveloperProduct()
	{
		return "{actor}님이 ID가 {id}인 개발자 상품을 만들었어요";
	}

	/// <summary>
	/// Key: "Message.CreateEnemy"
	/// English String: "{actor} declared group {group} as an enemy"
	/// </summary>
	public override string MessageCreateEnemy(string actor, string group)
	{
		return $"{actor}님이 {group} 그룹을 적으로 선포했어요";
	}

	protected override string _GetTemplateForMessageCreateEnemy()
	{
		return "{actor}님이 {group} 그룹을 적으로 선포했어요";
	}

	/// <summary>
	/// Key: "Message.CreateGamePass"
	/// English String: "{actor} created a Game Pass for {game}: {gamePass}"
	/// </summary>
	public override string MessageCreateGamePass(string actor, string game, string gamePass)
	{
		return $"{actor}님이 {game}에 생성한 게임패스: {gamePass}";
	}

	protected override string _GetTemplateForMessageCreateGamePass()
	{
		return "{actor}님이 {game}에 생성한 게임패스: {gamePass}";
	}

	/// <summary>
	/// Key: "Message.CreateItems"
	/// English String: "{actor} created the group item {item}"
	/// </summary>
	public override string MessageCreateItems(string actor, string item)
	{
		return $"{actor}님이 그룹 아이템 {item}을(를) 생성했어요";
	}

	protected override string _GetTemplateForMessageCreateItems()
	{
		return "{actor}님이 그룹 아이템 {item}을(를) 생성했어요";
	}

	/// <summary>
	/// Key: "Message.DeclineAllyRequest"
	/// English String: "{actor} declined group {group}'s ally request"
	/// </summary>
	public override string MessageDeclineAllyRequest(string actor, string group)
	{
		return $"{actor}님이 {group} 그룹의 동맹 요청을 거절했어요";
	}

	protected override string _GetTemplateForMessageDeclineAllyRequest()
	{
		return "{actor}님이 {group} 그룹의 동맹 요청을 거절했어요";
	}

	/// <summary>
	/// Key: "Message.DeclineJoinRequest"
	/// English String: "{actor} declined user {user}'s join request"
	/// </summary>
	public override string MessageDeclineJoinRequest(string actor, string user)
	{
		return $"{actor}님이 {user}님의 가입 신청을 거절했어요";
	}

	protected override string _GetTemplateForMessageDeclineJoinRequest()
	{
		return "{actor}님이 {user}님의 가입 신청을 거절했어요";
	}

	protected override string _GetTemplateForMessageDefaultError()
	{
		return "오류가 발생했어요.";
	}

	/// <summary>
	/// Key: "Message.Delete"
	/// English String: "{actor} deleted current group"
	/// </summary>
	public override string MessageDelete(string actor)
	{
		return $"{actor}님이 현재 그룹을 삭제했어요";
	}

	protected override string _GetTemplateForMessageDelete()
	{
		return "{actor}님이 현재 그룹을 삭제했어요";
	}

	/// <summary>
	/// Key: "Message.DeleteAlly"
	/// English String: "{actor} removed group {group} as an ally"
	/// </summary>
	public override string MessageDeleteAlly(string actor, string group)
	{
		return $"{actor}님이 {group} 그룹을 동맹에서 제외시켰어요";
	}

	protected override string _GetTemplateForMessageDeleteAlly()
	{
		return "{actor}님이 {group} 그룹을 동맹에서 제외시켰어요";
	}

	/// <summary>
	/// Key: "Message.DeleteEnemy"
	/// English String: "{actor} removed group {group} as an enemy"
	/// </summary>
	public override string MessageDeleteEnemy(string actor, string group)
	{
		return $"{actor}님이 {group} 그룹을 적에서 제외시켰어요";
	}

	protected override string _GetTemplateForMessageDeleteEnemy()
	{
		return "{actor}님이 {group} 그룹을 적에서 제외시켰어요";
	}

	/// <summary>
	/// Key: "Message.DeleteGroupPlace"
	/// English String: "{actor} removed game {game} as a group game"
	/// </summary>
	public override string MessageDeleteGroupPlace(string actor, string game)
	{
		return $"{actor}님이 {game} 게임을 그룹 게임에서 삭제했어요";
	}

	protected override string _GetTemplateForMessageDeleteGroupPlace()
	{
		return "{actor}님이 {game} 게임을 그룹 게임에서 삭제했어요";
	}

	/// <summary>
	/// Key: "Message.DeletePost"
	/// English String: "{actor} deleted post \"{postDesc}\" by user {user}"
	/// </summary>
	public override string MessageDeletePost(string actor, string postDesc, string user)
	{
		return $"{actor}님이 {user}님의 게시물 \"{postDesc}\"을(를) 삭제했어요";
	}

	protected override string _GetTemplateForMessageDeletePost()
	{
		return "{actor}님이 {user}님의 게시물 \"{postDesc}\"을(를) 삭제했어요";
	}

	protected override string _GetTemplateForMessageDeleteWallPostError()
	{
		return "담벼락 게시물을 삭제할 수 없습니다.";
	}

	protected override string _GetTemplateForMessageDeleteWallPostsByUserError()
	{
		return "사용자가 게시한 담벼락 게시물을 삭제할 수 없습니다";
	}

	protected override string _GetTemplateForMessageDeleteWallPostSuccess()
	{
		return "담벼락 게시물 삭제 완료.";
	}

	protected override string _GetTemplateForMessageDescriptionTooLong()
	{
		return "설명이 너무 길어요.";
	}

	protected override string _GetTemplateForMessageDuplicateName()
	{
		return "이미 사용 중인 이름이에요. 다른 걸로 해 보세요.";
	}

	protected override string _GetTemplateForMessageExileUserError()
	{
		return "사용자를 추방할 수 없습니다.";
	}

	protected override string _GetTemplateForMessageFeatureDisabled()
	{
		return "이 기능이 비활성화되었습니다.";
	}

	protected override string _GetTemplateForMessageGetGroupRelationshipsError()
	{
		return "파트너 그룹을 불러올 수 없습니다.";
	}

	protected override string _GetTemplateForMessageGroupClosed()
	{
		return "비공개 그룹은 가입할 수 없어요.";
	}

	protected override string _GetTemplateForMessageGroupCreationDisabled()
	{
		return "그룹 생성은 현재 사용할 수 없습니다.";
	}

	protected override string _GetTemplateForMessageGroupIconInvalid()
	{
		return "아이콘이 누락되었거나 유효하지 않아요.";
	}

	/// <summary>
	/// Key: "Message.GroupIconTooLarge"
	/// English String: "Icon cannot be larger than {maxSize} mb."
	/// </summary>
	public override string MessageGroupIconTooLarge(string maxSize)
	{
		return $"아이콘 크기는 최대 {maxSize}MB까지만 가능해요.";
	}

	protected override string _GetTemplateForMessageGroupIconTooLarge()
	{
		return "아이콘 크기는 최대 {maxSize}MB까지만 가능해요.";
	}

	protected override string _GetTemplateForMessageGroupMembershipsUnavailableError()
	{
		return "일시적으로 그룹 멤버십 시스템 이용 불가. 나중에 다시 시도하세요.";
	}

	protected override string _GetTemplateForMessageInsufficientFunds()
	{
		return "Robux 자금이 부족해요.";
	}

	protected override string _GetTemplateForMessageInsufficientGroupSpace()
	{
		return "이미 그룹 가입자 수 한도에 도달했어요.";
	}

	protected override string _GetTemplateForMessageInsufficientMembership()
	{
		return "이 그룹에 필요한 빌더스 클럽 멤버십을 소유하고 있지 않습니다.";
	}

	protected override string _GetTemplateForMessageInsufficientPermission()
	{
		return "요청을 완료하기에 권한이 부족합니다.";
	}

	protected override string _GetTemplateForMessageInsufficientPermissionsForRelationships()
	{
		return "이 그룹 관계를 설정할 수 있는 권한이 없습니다.";
	}

	protected override string _GetTemplateForMessageInsufficientRobux()
	{
		return "Robux가 부족해서 그룹을 만들 수 없어요.";
	}

	protected override string _GetTemplateForMessageInvalidAmount()
	{
		return "금액이 유효하지 않습니다.";
	}

	protected override string _GetTemplateForMessageInvalidGroup()
	{
		return "그룹이 유효하지 않거나 존재하지 않아요.";
	}

	protected override string _GetTemplateForMessageInvalidGroupIcon()
	{
		return "그룹 아이콘이 잘못되었어요.";
	}

	protected override string _GetTemplateForMessageInvalidGroupId()
	{
		return "그룹이 잘못되었거나 존재하지 않아요.";
	}

	protected override string _GetTemplateForMessageInvalidGroupWallPostId()
	{
		return "그룹 담벼락 게시물 ID가 잘못되었거나 존재하지 않아요.";
	}

	protected override string _GetTemplateForMessageInvalidIds()
	{
		return "ID를 요청에서 분석할 수 없었어요.";
	}

	protected override string _GetTemplateForMessageInvalidIdsError()
	{
		return "ID를 요청에서 분석할 수 없었어요.";
	}

	protected override string _GetTemplateForMessageInvalidMembership()
	{
		return "빌더스 클럽 멤버십이 있어야 사용할 수 있습니다.";
	}

	protected override string _GetTemplateForMessageInvalidName()
	{
		return "이름이 유효하지 않아요.";
	}

	protected override string _GetTemplateForMessageInvalidPaginationParameters()
	{
		return "페이지 매개변수가 잘못되었거나 누락되었습니다.";
	}

	protected override string _GetTemplateForMessageInvalidPayoutType()
	{
		return "유효하지 않은 지불 유형입니다.";
	}

	protected override string _GetTemplateForMessageInvalidRecipient()
	{
		return "수신자가 유효하지 않습니다.";
	}

	protected override string _GetTemplateForMessageInvalidRelationshipType()
	{
		return "그룹 관계 유형이 잘못되었어요.";
	}

	protected override string _GetTemplateForMessageInvalidRoleSetId()
	{
		return "역할군이 잘못되었거나 존재하지 않아요.";
	}

	protected override string _GetTemplateForMessageInvalidUser()
	{
		return "사용자가 잘못되었거나 존재하지 않아요.";
	}

	protected override string _GetTemplateForMessageInvalidWallPostContent()
	{
		return "게시물이 비어있거나, 공백이었거나, 500자를 초과했어요.";
	}

	/// <summary>
	/// Key: "Message.InviteToClan"
	/// English String: "{actor} invited user {user} to the clan"
	/// </summary>
	public override string MessageInviteToClan(string actor, string user)
	{
		return $"{actor}님이 {user}님을 클랜으로 초대했어요";
	}

	protected override string _GetTemplateForMessageInviteToClan()
	{
		return "{actor}님이 {user}님을 클랜으로 초대했어요";
	}

	protected override string _GetTemplateForMessageJoinGroupError()
	{
		return "그룹 가입을 할 수 없습니다.";
	}

	protected override string _GetTemplateForMessageJoinGroupPendingSuccess()
	{
		return "그룹 가입 요청이 대기 중입니다.";
	}

	protected override string _GetTemplateForMessageJoinGroupSuccess()
	{
		return "그룹 가입 완료.";
	}

	/// <summary>
	/// Key: "Message.KickFromClan"
	/// English String: "{actor} kicked user {user} out of the clan"
	/// </summary>
	public override string MessageKickFromClan(string actor, string user)
	{
		return $"{actor}님이 {user}님을 클랜에서 강제 퇴장시켰어요";
	}

	protected override string _GetTemplateForMessageKickFromClan()
	{
		return "{actor}님이 {user}님을 클랜에서 강제 퇴장시켰어요";
	}

	protected override string _GetTemplateForMessageLeaveGroupError()
	{
		return "그룹을 나갈 수 없습니다.";
	}

	protected override string _GetTemplateForMessageLoadGroupError()
	{
		return "그룹을 불러올 수 없습니다.";
	}

	protected override string _GetTemplateForMessageLoadGroupGamesError()
	{
		return "게임을 불러올 수 없습니다.";
	}

	protected override string _GetTemplateForMessageLoadGroupListError()
	{
		return "그룹 목록을 불러올 수 없습니다.";
	}

	protected override string _GetTemplateForMessageLoadGroupMembershipsError()
	{
		return "사용자 멤버십 정보를 불러올 수 없습니다.";
	}

	protected override string _GetTemplateForMessageLoadGroupMetadataError()
	{
		return "그룹 정보를 불러올 수 없습니다.";
	}

	protected override string _GetTemplateForMessageLoadGroupStoreItemsError()
	{
		return "상점 아이템을 불러올 수 없습니다.";
	}

	protected override string _GetTemplateForMessageLoadUserGroupMembershipError()
	{
		return "그룹의 멤버 정보를 불러올 수 없습니다.";
	}

	protected override string _GetTemplateForMessageLoadWallPostsError()
	{
		return "담벼락 게시물을 불러올 수 없습니다.";
	}

	/// <summary>
	/// Key: "Message.Lock"
	/// English String: "{actor} locked the group"
	/// </summary>
	public override string MessageLock(string actor)
	{
		return $"{actor}님이 그룹을 잠갔어요";
	}

	protected override string _GetTemplateForMessageLock()
	{
		return "{actor}님이 그룹을 잠갔어요";
	}

	protected override string _GetTemplateForMessageMakePrimaryError()
	{
		return "기본 그룹을 만들 수 없습니다.";
	}

	protected override string _GetTemplateForMessageMaxGroups()
	{
		return "더 이상의 그룹에 가입할 수 없어요.";
	}

	protected override string _GetTemplateForMessageMissingGroupIcon()
	{
		return "요청에 그룹 아이콘이 누락되었어요.";
	}

	protected override string _GetTemplateForMessageMissingGroupStatusContent()
	{
		return "그룹 상태 내용이 없습니다.";
	}

	protected override string _GetTemplateForMessageNameInvalid()
	{
		return "이름이 누락되었거나, 유효하지 않은 문자가 포함되어 있어요.";
	}

	protected override string _GetTemplateForMessageNameModerated()
	{
		return "이름이 조정되었어요.";
	}

	protected override string _GetTemplateForMessageNameTaken()
	{
		return "사용 중인 이름이에요.";
	}

	protected override string _GetTemplateForMessageNameTooLong()
	{
		return "이름이 너무 길어요.";
	}

	protected override string _GetTemplateForMessageNoPrimary()
	{
		return "이 특정 사용자는 기본 그룹이 없어요.";
	}

	protected override string _GetTemplateForMessagePassCaptchaToJoin()
	{
		return "이 그룹에 가입하려면 캡차 테스트를 통과해야 해요.";
	}

	protected override string _GetTemplateForMessagePassCaptchaToPost()
	{
		return "그룹 담벼락에 게시하려면 캡차를 풀어야 해요.";
	}

	/// <summary>
	/// Key: "Message.PostStatus"
	/// English String: "{actor} changed the group status to \"{groupStatus}\""
	/// </summary>
	public override string MessagePostStatus(string actor, string groupStatus)
	{
		return $"{actor}님이 그룹 상태를 \"{groupStatus}\"(으)로 변경했어요";
	}

	protected override string _GetTemplateForMessagePostStatus()
	{
		return "{actor}님이 그룹 상태를 \"{groupStatus}\"(으)로 변경했어요";
	}

	/// <summary>
	/// Key: "Message.RemoveMember"
	/// English String: "{actor} kicked user {user}"
	/// </summary>
	public override string MessageRemoveMember(string actor, string user)
	{
		return $"{actor}님이 {user}님을 강제 퇴장시켰어요";
	}

	protected override string _GetTemplateForMessageRemoveMember()
	{
		return "{actor}님이 {user}님을 강제 퇴장시켰어요";
	}

	protected override string _GetTemplateForMessageRemovePrimaryError()
	{
		return "기본 그룹을 삭제할 수 없습니다.";
	}

	/// <summary>
	/// Key: "Message.Rename"
	/// English String: "{actor} renamed current group to {newName}"
	/// </summary>
	public override string MessageRename(string actor, string newName)
	{
		return $"{actor}님이 현재 그룹 이름을 {newName}(으)로 변경했어요";
	}

	protected override string _GetTemplateForMessageRename()
	{
		return "{actor}님이 현재 그룹 이름을 {newName}(으)로 변경했어요";
	}

	protected override string _GetTemplateForMessageSearchTermCharactersLimit()
	{
		return "검색어는 1자-25자 사이여야 해요";
	}

	protected override string _GetTemplateForMessageSearchTermEmptyError()
	{
		return "검색어가 입력되지 않았어요";
	}

	protected override string _GetTemplateForMessageSearchTermFilteredError()
	{
		return "검색어가 필터링되었어요";
	}

	/// <summary>
	/// Key: "Message.SendAllyRequest"
	/// English String: "{actor} sent an ally request to group {group}"
	/// </summary>
	public override string MessageSendAllyRequest(string actor, string group)
	{
		return $"{actor}님이 {group} 그룹에 동맹 요청을 보냈어요";
	}

	protected override string _GetTemplateForMessageSendAllyRequest()
	{
		return "{actor}님이 {group} 그룹에 동맹 요청을 보냈어요";
	}

	protected override string _GetTemplateForMessageSendGroupShoutError()
	{
		return "그룹 샤우트를 발송할 수 없습니다.";
	}

	protected override string _GetTemplateForMessageSendPostError()
	{
		return "게시물을 전송할 수 없습니다.";
	}

	/// <summary>
	/// Key: "Message.SpendGroupFunds"
	/// English String: "{actor} spent {amount} of group funds for: {item}"
	/// </summary>
	public override string MessageSpendGroupFunds(string actor, string amount, string item)
	{
		return $"{actor}님이 {item} 구매에 그룹 펀드를 {amount} 사용했어요";
	}

	protected override string _GetTemplateForMessageSpendGroupFunds()
	{
		return "{actor}님이 {item} 구매에 그룹 펀드를 {amount} 사용했어요";
	}

	protected override string _GetTemplateForMessageTooManyAttempts()
	{
		return "그룹 가입 시도가 너무 많아요. 나중에 다시 시도하세요.";
	}

	protected override string _GetTemplateForMessageTooManyAttemptsToClaimGroups()
	{
		return "그룹 소유 시도가 너무 많아요. 나중에 다시 시도하세요.";
	}

	protected override string _GetTemplateForMessageTooManyGroups()
	{
		return "그룹 수가 한도에 도달했습니다. 새 그룹을 만들기 전에 그룹 하나에서 나가세요.";
	}

	protected override string _GetTemplateForMessageTooManyIds()
	{
		return "요청에 ID가 너무 많아요.";
	}

	protected override string _GetTemplateForMessageTooManyPosts()
	{
		return "게시 속도가 너무 빨라요, 몇 분 후에 다시 시도하세요.";
	}

	protected override string _GetTemplateForMessageTooManyRequests()
	{
		return "요청이 너무 많아요.";
	}

	protected override string _GetTemplateForMessageUnauthorizedForPostStatus()
	{
		return "이 그룹의 상태를 설정할 수 있는 권한이 없습니다.";
	}

	protected override string _GetTemplateForMessageUnauthorizedForViewGroupPayouts()
	{
		return "이 그룹의 지불금을 볼 수 있는 권한이 없습니다.";
	}

	protected override string _GetTemplateForMessageUnauthorizedToClaimGroup()
	{
		return "이 그룹을 소유할 권한이 없어요.";
	}

	protected override string _GetTemplateForMessageUnauthorizedToManageMember()
	{
		return "이 회원을 관리할 권한이 없어요.";
	}

	protected override string _GetTemplateForMessageUnauthorizedToViewRolesetPermissions()
	{
		return "이 역할군의 권한을 볼 권한이 없어요.";
	}

	protected override string _GetTemplateForMessageUnauthorizedToViewWall()
	{
		return "이 그룹 담벼락에 접근할 권한이 없습니다.";
	}

	protected override string _GetTemplateForMessageUnknownError()
	{
		return "알 수 없는 오류";
	}

	/// <summary>
	/// Key: "Message.Unlock"
	/// English String: "{actor} unlocked the group"
	/// </summary>
	public override string MessageUnlock(string actor)
	{
		return $"{actor}님이 그룹을 잠금 해제했어요";
	}

	protected override string _GetTemplateForMessageUnlock()
	{
		return "{actor}님이 그룹을 잠금 해제했어요";
	}

	/// <summary>
	/// Key: "Message.UpdateAsset"
	/// English String: "{actor} created new version {version} of asset {item}"
	/// </summary>
	public override string MessageUpdateAsset(string actor, string version, string item)
	{
		return $"{actor}님이 {item} 애셋의 새로운 버전 {version}을(를) 생성했어요";
	}

	protected override string _GetTemplateForMessageUpdateAsset()
	{
		return "{actor}님이 {item} 애셋의 새로운 버전 {version}을(를) 생성했어요";
	}

	/// <summary>
	/// Key: "Message.UpdateAssetRevert"
	/// English String: "{actor} reverted asset {item} from version {version} to {oldVersion}"
	/// </summary>
	public override string MessageUpdateAssetRevert(string actor, string item, string version, string oldVersion)
	{
		return $"{actor}님이 {item} 애셋을 버전 {version}에서 {oldVersion}(으)로 되돌렸어요";
	}

	protected override string _GetTemplateForMessageUpdateAssetRevert()
	{
		return "{actor}님이 {item} 애셋을 버전 {version}에서 {oldVersion}(으)로 되돌렸어요";
	}

	protected override string _GetTemplateForMessageUserNotInGroup()
	{
		return "이 특정 그룹의 회원이 아닙니다.";
	}
}
