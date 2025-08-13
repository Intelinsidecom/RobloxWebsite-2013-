namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides GroupsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class GroupsResources_zh_tw : GroupsResources_en_us, IGroupsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.AdvertiseGroup"
	/// English String: "Advertise Group"
	/// </summary>
	public override string ActionAdvertiseGroup => "宣傳群組";

	/// <summary>
	/// Key: "Action.AuditLog"
	/// English String: "Audit Log"
	/// </summary>
	public override string ActionAuditLog => "管理紀錄";

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "取消";

	/// <summary>
	/// Key: "Action.CancelRequest"
	/// English String: "Cancel Request"
	/// </summary>
	public override string ActionCancelRequest => "取消請求";

	/// <summary>
	/// Key: "Action.ClaimOwnership"
	/// English String: "Claim Ownership"
	/// </summary>
	public override string ActionClaimOwnership => "成為主人";

	/// <summary>
	/// Key: "Action.Close"
	/// English String: "Close"
	/// </summary>
	public override string ActionClose => "關閉";

	/// <summary>
	/// Key: "Action.ConfigureGroup"
	/// English String: "Configure Group"
	/// </summary>
	public override string ActionConfigureGroup => "設定群組";

	/// <summary>
	/// Key: "Action.CreateGroup"
	/// English String: "Create Group"
	/// </summary>
	public override string ActionCreateGroup => "建立群組";

	/// <summary>
	/// Key: "Action.Delete"
	/// English String: "Delete"
	/// </summary>
	public override string ActionDelete => "刪除";

	/// <summary>
	/// Key: "Action.Exile"
	/// English String: "Exile"
	/// </summary>
	public override string ActionExile => "驅逐";

	/// <summary>
	/// Key: "Action.ExileUser"
	/// English String: "Exile User"
	/// </summary>
	public override string ActionExileUser => "驅除使用者";

	/// <summary>
	/// Key: "Action.GroupAdmin"
	/// English String: "Group Admin"
	/// </summary>
	public override string ActionGroupAdmin => "群組管理員";

	/// <summary>
	/// Key: "Action.GroupShout"
	/// Text on the button for sending / posting a group shout
	/// English String: "Group Shout"
	/// </summary>
	public override string ActionGroupShout => "群組廣播";

	/// <summary>
	/// Key: "Action.JoinGroup"
	/// English String: "Join Group"
	/// </summary>
	public override string ActionJoinGroup => "加入群組";

	/// <summary>
	/// Key: "Action.LeaveGroup"
	/// English String: "Leave Group"
	/// </summary>
	public override string ActionLeaveGroup => "離開群組";

	/// <summary>
	/// Key: "Action.MakePrimary"
	/// English String: "Make Primary"
	/// </summary>
	public override string ActionMakePrimary => "設為主要群組";

	/// <summary>
	/// Key: "Action.MakePrimaryGroup"
	/// Set the current group as the users primary group
	/// English String: "Make Primary Group"
	/// </summary>
	public override string ActionMakePrimaryGroup => "設為主要群組";

	/// <summary>
	/// Key: "Action.Post"
	/// English String: "Post"
	/// </summary>
	public override string ActionPost => "貼文";

	/// <summary>
	/// Key: "Action.Purchase"
	/// English String: "Purchase"
	/// </summary>
	public override string ActionPurchase => "購買";

	/// <summary>
	/// Key: "Action.RemovePrimary"
	/// English String: "Remove Primary"
	/// </summary>
	public override string ActionRemovePrimary => "解除主要群組";

	/// <summary>
	/// Key: "Action.Report"
	/// English String: "Report"
	/// </summary>
	public override string ActionReport => "檢舉";

	/// <summary>
	/// Key: "Action.ReportAbuse"
	/// English String: "Report Abuse"
	/// </summary>
	public override string ActionReportAbuse => "檢舉濫用";

	/// <summary>
	/// Key: "Action.Upgrade"
	/// English String: "Upgrade"
	/// </summary>
	public override string ActionUpgrade => "升級";

	/// <summary>
	/// Key: "Action.UpgradeToJoin"
	/// English String: "Upgrade to Join"
	/// </summary>
	public override string ActionUpgradeToJoin => "升級後即可加入";

	/// <summary>
	/// Key: "Action.Yes"
	/// English String: "Yes"
	/// </summary>
	public override string ActionYes => "確定";

	/// <summary>
	/// Key: "Description.ClothingRevenue"
	/// English String: "Groups have the ability to create and sell official shirts, pants, and t-shirts! All revenue goes to group funds."
	/// </summary>
	public override string DescriptionClothingRevenue => "群組可以創作及販賣官方服裝，收入將歸入群組資金。";

	/// <summary>
	/// Key: "Description.DeleteAllPostsByUser"
	/// English String: "Also delete all posts by this user."
	/// </summary>
	public override string DescriptionDeleteAllPostsByUser => "同時刪除此使用者所有貼文。";

	/// <summary>
	/// Key: "Description.ExileUserWarning"
	/// English String: "Are you sure you want to exile this user?"
	/// </summary>
	public override string DescriptionExileUserWarning => "確定驅逐此使用者？";

	/// <summary>
	/// Key: "Description.LeaveGroupAsOwnerWarning"
	/// English String: "This will leave the group ownerless."
	/// </summary>
	public override string DescriptionLeaveGroupAsOwnerWarning => "此群組將會沒有主人。";

	/// <summary>
	/// Key: "Description.LeaveGroupWarning"
	/// English String: "Are you sure you want to leave this group?"
	/// </summary>
	public override string DescriptionLeaveGroupWarning => "確定離開群組？";

	/// <summary>
	/// Key: "Description.MakePrimaryGroupWarning"
	/// English String: "Are you sure you want to make this your primary group?"
	/// </summary>
	public override string DescriptionMakePrimaryGroupWarning => "確定將此群組設為主要群組？";

	/// <summary>
	/// Key: "Description.NoneMaxGroups"
	/// English String: "Upgrade to Builders Club to join more groups."
	/// </summary>
	public override string DescriptionNoneMaxGroups => "若要加入更多群組，請升級到 Builders Club。";

	/// <summary>
	/// Key: "Description.NoneMaxGroupsPremium"
	/// English String: "Upgrade to Roblox Premium to join more groups."
	/// </summary>
	public override string DescriptionNoneMaxGroupsPremium => "若要加入更多群組，請升級到 Roblox Premium。";

	/// <summary>
	/// Key: "Description.noneMaxGroupsPremiumText"
	/// English String: "Upgrade to Roblox Premium to join more groups."
	/// </summary>
	public override string DescriptionnoneMaxGroupsPremiumText => "若要加入更多群組，請升級到 Roblox Premium。";

	/// <summary>
	/// Key: "Description.ObcMaxGroups"
	/// English String: "You have joined the maximum number of groups."
	/// </summary>
	public override string DescriptionObcMaxGroups => "您的加入群組數量已達上限。";

	/// <summary>
	/// Key: "Description.OtherBcMaxGroups"
	/// English String: "Upgrade your Builders Club to join more groups."
	/// </summary>
	public override string DescriptionOtherBcMaxGroups => "若要加入更多群組，請升級您的 Builders Club 會員資格。";

	/// <summary>
	/// Key: "Description.otherPremiumMaxGroupsText"
	/// English String: "Upgrade your Roblox Premium to join more groups."
	/// </summary>
	public override string DescriptionotherPremiumMaxGroupsText => "若要加入更多群組，請升級您的 Roblox Premium 會員資格。";

	/// <summary>
	/// Key: "Description.PremiumMaxGroups"
	/// English String: "You have joined the maximum number of groups."
	/// </summary>
	public override string DescriptionPremiumMaxGroups => "您的加入群組數量已達上限。";

	/// <summary>
	/// Key: "Description.PurchaseBody"
	/// English String: "Would you like to create this group for"
	/// </summary>
	public override string DescriptionPurchaseBody => "確定建立此群組？費用：";

	/// <summary>
	/// Key: "Description.RemovePrimaryGroupWarning"
	/// English String: "Are you sure you want to remove your primary group?"
	/// </summary>
	public override string DescriptionRemovePrimaryGroupWarning => "確定解除此群組為主要群組？";

	/// <summary>
	/// Key: "Description.ReportAbuseDescription"
	/// English String: "What would you like to report?"
	/// </summary>
	public override string DescriptionReportAbuseDescription => "您想檢舉什麼？";

	/// <summary>
	/// Key: "Description.WallPrivacySettings"
	/// English String: "Your privacy settings do not allow you to post to group walls. Click here to adjust these settings."
	/// </summary>
	public override string DescriptionWallPrivacySettings => "您的隱私權設定不允許你發表貼文，請前往此處變更您的設定。";

	/// <summary>
	/// Key: "Heading.About"
	/// English String: "About"
	/// </summary>
	public override string HeadingAbout => "介紹";

	/// <summary>
	/// Key: "Heading.Affiliates"
	/// English String: "Affiliates"
	/// </summary>
	public override string HeadingAffiliates => "夥伴";

	/// <summary>
	/// Key: "Heading.Allies"
	/// English String: "Allies"
	/// </summary>
	public override string HeadingAllies => "盟友";

	/// <summary>
	/// Key: "Heading.Date"
	/// English String: "Date"
	/// </summary>
	public override string HeadingDate => "日期";

	/// <summary>
	/// Key: "Heading.Description"
	/// English String: "Description"
	/// </summary>
	public override string HeadingDescription => "說明";

	/// <summary>
	/// Key: "Heading.Enemies"
	/// English String: "Enemies"
	/// </summary>
	public override string HeadingEnemies => "敵人";

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
	public override string HeadingGames => "遊戲";

	/// <summary>
	/// Key: "Heading.GroupPurchase"
	/// English String: "Group Purchase Confirmation"
	/// </summary>
	public override string HeadingGroupPurchase => "群組購買確認";

	/// <summary>
	/// Key: "Heading.GroupShout"
	/// English String: "Group Shout"
	/// </summary>
	public override string HeadingGroupShout => "群組廣播";

	/// <summary>
	/// Key: "Heading.LeaveGroup"
	/// English String: "Leave Group"
	/// </summary>
	public override string HeadingLeaveGroup => "離開群組";

	/// <summary>
	/// Key: "Heading.MakePrimaryGroup"
	/// Heading of make primary group modal
	/// English String: "Make Primary Group"
	/// </summary>
	public override string HeadingMakePrimaryGroup => "設為主要群組";

	/// <summary>
	/// Key: "Heading.Members"
	/// English String: "Members"
	/// </summary>
	public override string HeadingMembers => "成員";

	/// <summary>
	/// Key: "Heading.NameOrDescription"
	/// Selection option for what to report when reporting something in a group
	/// English String: "Name or Description"
	/// </summary>
	public override string HeadingNameOrDescription => "名稱或介紹";

	/// <summary>
	/// Key: "Heading.Payouts"
	/// English String: "Payouts"
	/// </summary>
	public override string HeadingPayouts => "支付";

	/// <summary>
	/// Key: "Heading.Primary"
	/// English String: "Primary"
	/// </summary>
	public override string HeadingPrimary => "主要";

	/// <summary>
	/// Key: "Heading.Rank"
	/// English String: "Rank"
	/// </summary>
	public override string HeadingRank => "階級";

	/// <summary>
	/// Key: "Heading.RemovePrimaryGroup"
	/// English String: "Remove Primary Group"
	/// </summary>
	public override string HeadingRemovePrimaryGroup => "解除主要群組";

	/// <summary>
	/// Key: "Heading.Role"
	/// English String: "Role"
	/// </summary>
	public override string HeadingRole => "階級";

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
	public override string HeadingShout => "廣播";

	/// <summary>
	/// Key: "Heading.Store"
	/// English String: "Store"
	/// </summary>
	public override string HeadingStore => "商店";

	/// <summary>
	/// Key: "Heading.User"
	/// English String: "User"
	/// </summary>
	public override string HeadingUser => "使用者";

	/// <summary>
	/// Key: "Heading.Wall"
	/// English String: "Wall"
	/// </summary>
	public override string HeadingWall => "動態牆";

	/// <summary>
	/// Key: "Label.Abandon"
	/// English String: "Abandon"
	/// </summary>
	public override string LabelAbandon => "捨棄";

	/// <summary>
	/// Key: "Label.AcceptAllyRequest"
	/// English String: "Accept Ally Request"
	/// </summary>
	public override string LabelAcceptAllyRequest => "接受盟友請求";

	/// <summary>
	/// Key: "Label.AcceptJoinRequest"
	/// English String: "Accept Join Request"
	/// </summary>
	public override string LabelAcceptJoinRequest => "接受加入請求";

	/// <summary>
	/// Key: "Label.AddGroupPlace"
	/// English String: "Add Group Place"
	/// </summary>
	public override string LabelAddGroupPlace => "新增群組空間";

	/// <summary>
	/// Key: "Label.AdjustCurrencyAmounts"
	/// English String: "Adjust Currency Amounts"
	/// </summary>
	public override string LabelAdjustCurrencyAmounts => "調整貨幣金額";

	/// <summary>
	/// Key: "Label.All"
	/// English String: "All"
	/// </summary>
	public override string LabelAll => "全部";

	/// <summary>
	/// Key: "Label.AnyoneCanJoin"
	/// English String: "Anyone Can Join"
	/// </summary>
	public override string LabelAnyoneCanJoin => "所有人都可以加入";

	/// <summary>
	/// Key: "Label.BuyAd"
	/// English String: "Buy Ad"
	/// </summary>
	public override string LabelBuyAd => "購買廣告";

	/// <summary>
	/// Key: "Label.BuyClan"
	/// English String: "Buy Clan"
	/// </summary>
	public override string LabelBuyClan => "購買公會";

	/// <summary>
	/// Key: "Label.ByOwner"
	/// Prefix to either the owner of the group, or "No One!" if the group has no owner. Could not properly format like By {ownerName} because ownerName is a link in this case
	/// English String: "By"
	/// </summary>
	public override string LabelByOwner => "建立者：";

	/// <summary>
	/// Key: "Label.CancelClanInvite"
	/// English String: "Cancel Clan Invite"
	/// </summary>
	public override string LabelCancelClanInvite => "取消公會邀請";

	/// <summary>
	/// Key: "Label.ChangeDescription"
	/// English String: "Change Description"
	/// </summary>
	public override string LabelChangeDescription => "變更說明";

	/// <summary>
	/// Key: "Label.ChangeOwner"
	/// English String: "Change Owner"
	/// </summary>
	public override string LabelChangeOwner => "變更主人";

	/// <summary>
	/// Key: "Label.ChangeRank"
	/// English String: "Change Rank"
	/// </summary>
	public override string LabelChangeRank => "變更階級";

	/// <summary>
	/// Key: "Label.Claim"
	/// English String: "Claim"
	/// </summary>
	public override string LabelClaim => "取得";

	/// <summary>
	/// Key: "Label.ConfigureBadge"
	/// English String: "Configure Badge"
	/// </summary>
	public override string LabelConfigureBadge => "設定徽章";

	/// <summary>
	/// Key: "Label.ConfigureGroupAsset"
	/// English String: "Configure Group Asset"
	/// </summary>
	public override string LabelConfigureGroupAsset => "設定群組素材";

	/// <summary>
	/// Key: "Label.ConfigureGroupDevelopmentItem"
	/// English String: "Configure Group Development Item"
	/// </summary>
	public override string LabelConfigureGroupDevelopmentItem => "設定群組開發道具";

	/// <summary>
	/// Key: "Label.ConfigureGroupGame"
	/// English String: "Configure Group Game"
	/// </summary>
	public override string LabelConfigureGroupGame => "設定群組遊戲";

	/// <summary>
	/// Key: "Label.ConfigureItems"
	/// English String: "Configure Items"
	/// </summary>
	public override string LabelConfigureItems => "設定道具";

	/// <summary>
	/// Key: "Label.CreateBadge"
	/// English String: "Create Badge"
	/// </summary>
	public override string LabelCreateBadge => "建立徽章";

	/// <summary>
	/// Key: "Label.CreateEnemy"
	/// English String: "Create Enemy"
	/// </summary>
	public override string LabelCreateEnemy => "設定敵人";

	/// <summary>
	/// Key: "Label.CreateGamePass"
	/// English String: "Create Game Pass"
	/// </summary>
	public override string LabelCreateGamePass => "建立遊戲證";

	/// <summary>
	/// Key: "Label.CreateGroup"
	/// English String: "Create Group"
	/// </summary>
	public override string LabelCreateGroup => "建立群組";

	/// <summary>
	/// Key: "Label.CreateGroupAsset"
	/// English String: "Create Group Asset"
	/// </summary>
	public override string LabelCreateGroupAsset => "建立群組素材";

	/// <summary>
	/// Key: "Label.CreateGroupBuildersClubTooltip"
	/// English String: "Creating a group requires a Builders Club membership."
	/// </summary>
	public override string LabelCreateGroupBuildersClubTooltip => "只有 Builders Club 會員可以建立群組。";

	/// <summary>
	/// Key: "Label.CreateGroupDescription"
	/// English String: "Description (optional)"
	/// </summary>
	public override string LabelCreateGroupDescription => "說明（可省略）";

	/// <summary>
	/// Key: "Label.CreateGroupDeveloperProduct"
	/// English String: "Create Group Developer Product"
	/// </summary>
	public override string LabelCreateGroupDeveloperProduct => "建立群組開發人員產品";

	/// <summary>
	/// Key: "Label.CreateGroupEmblem"
	/// English String: "Emblem"
	/// </summary>
	public override string LabelCreateGroupEmblem => "標誌";

	/// <summary>
	/// Key: "Label.CreateGroupFee"
	/// English String: "Group Creation Fee"
	/// </summary>
	public override string LabelCreateGroupFee => "團隊建立費用";

	/// <summary>
	/// Key: "Label.CreateGroupName"
	/// English String: "Name your group"
	/// </summary>
	public override string LabelCreateGroupName => "命名群組";

	/// <summary>
	/// Key: "Label.CreateGroupPremiumTooltip"
	/// English String: "Creating a group requires a Roblox Premium membership."
	/// </summary>
	public override string LabelCreateGroupPremiumTooltip => "只有 Roblox Premium 會員可以建立群組。";

	/// <summary>
	/// Key: "Label.CreateGroupTooltip"
	/// English String: "Create a new group"
	/// </summary>
	public override string LabelCreateGroupTooltip => "建立新群組";

	/// <summary>
	/// Key: "Label.CreateItems"
	/// English String: "Create Items"
	/// </summary>
	public override string LabelCreateItems => "建立道具";

	/// <summary>
	/// Key: "Label.DeclineAllyRequest"
	/// English String: "Decline Ally Request"
	/// </summary>
	public override string LabelDeclineAllyRequest => "拒絕盟友請求";

	/// <summary>
	/// Key: "Label.DeclineJoinRequest"
	/// English String: "Decline Join Request"
	/// </summary>
	public override string LabelDeclineJoinRequest => "拒絕加入請求";

	/// <summary>
	/// Key: "Label.Delete"
	/// English String: "Delete"
	/// </summary>
	public override string LabelDelete => "刪除";

	/// <summary>
	/// Key: "Label.DeleteAllPostsByUser"
	/// English String: "Also delete all posts by this user."
	/// </summary>
	public override string LabelDeleteAllPostsByUser => "同時刪除此使用者所有貼文。";

	/// <summary>
	/// Key: "Label.DeleteAlly"
	/// English String: "Delete Ally"
	/// </summary>
	public override string LabelDeleteAlly => "刪除盟友";

	/// <summary>
	/// Key: "Label.DeleteEnemy"
	/// English String: "Delete Enemy"
	/// </summary>
	public override string LabelDeleteEnemy => "刪除敵人";

	/// <summary>
	/// Key: "Label.DeleteGroupPlace"
	/// English String: "Delete Group Place"
	/// </summary>
	public override string LabelDeleteGroupPlace => "刪除群組空間";

	/// <summary>
	/// Key: "Label.DeletePost"
	/// English String: "Delete Post"
	/// </summary>
	public override string LabelDeletePost => "刪除貼文";

	/// <summary>
	/// Key: "Label.Funds"
	/// English String: "Funds"
	/// </summary>
	public override string LabelFunds => "資金";

	/// <summary>
	/// Key: "Label.GroupClosed"
	/// English String: "Group Closed"
	/// </summary>
	public override string LabelGroupClosed => "群組已關閉";

	/// <summary>
	/// Key: "Label.GroupLocked"
	/// English String: "This group has been locked"
	/// </summary>
	public override string LabelGroupLocked => "此群組已遭鎖定";

	/// <summary>
	/// Key: "Label.InviteToClan"
	/// English String: "Invite to Clan"
	/// </summary>
	public override string LabelInviteToClan => "邀請到公會";

	/// <summary>
	/// Key: "Label.KickFromClan"
	/// English String: "Kick from Clan"
	/// </summary>
	public override string LabelKickFromClan => "踢出公會";

	/// <summary>
	/// Key: "Label.Loading"
	/// English String: "Loading..."
	/// </summary>
	public override string LabelLoading => "正在載入…";

	/// <summary>
	/// Key: "Label.Lock"
	/// English String: "Lock"
	/// </summary>
	public override string LabelLock => "鎖定";

	/// <summary>
	/// Key: "Label.ManageGroupCreations"
	/// English String: "Create or manage group items."
	/// </summary>
	public override string LabelManageGroupCreations => "創作或管理群組道具。";

	/// <summary>
	/// Key: "Label.ManualApproval"
	/// English String: "Manual Approval"
	/// </summary>
	public override string LabelManualApproval => "手動批准";

	/// <summary>
	/// Key: "Label.ModerateDiscussion"
	/// English String: "Moderate Discussion"
	/// </summary>
	public override string LabelModerateDiscussion => "管理對話";

	/// <summary>
	/// Key: "Label.NoAllies"
	/// English String: "This group does not have any allies."
	/// </summary>
	public override string LabelNoAllies => "此群組沒有盟友。";

	/// <summary>
	/// Key: "Label.NoEnemies"
	/// English String: "This group does not have any enemies."
	/// </summary>
	public override string LabelNoEnemies => "此群組沒有敵人。";

	/// <summary>
	/// Key: "Label.NoGames"
	/// English String: "No games are associated with this group."
	/// </summary>
	public override string LabelNoGames => "此群組沒有遊戲。";

	/// <summary>
	/// Key: "Label.NoMembersInRole"
	/// English String: "No group members are in this role."
	/// </summary>
	public override string LabelNoMembersInRole => "此階級沒有成員。";

	/// <summary>
	/// Key: "Label.NoOne"
	/// English String: "No One!"
	/// </summary>
	public override string LabelNoOne => "沒有人！";

	/// <summary>
	/// Key: "Label.NoStoreItems"
	/// English String: "No items are for sale in this group."
	/// </summary>
	public override string LabelNoStoreItems => "此群組沒有販賣中道具。";

	/// <summary>
	/// Key: "Label.NoWallPosts"
	/// English String: "Nobody has said anything yet..."
	/// </summary>
	public override string LabelNoWallPosts => "還沒有人發言…";

	/// <summary>
	/// Key: "Label.OnlyBcCanJoin"
	/// English String: "Only Builders Club members can join"
	/// </summary>
	public override string LabelOnlyBcCanJoin => "只有 Builders Club 會員可以加入";

	/// <summary>
	/// Key: "Label.OnlyPremiumCanJoin"
	/// English String: "Only users with membership can join"
	/// </summary>
	public override string LabelOnlyPremiumCanJoin => "會員限定";

	/// <summary>
	/// Key: "Label.PrivateGroup"
	/// If group is invite only
	/// English String: "Private"
	/// </summary>
	public override string LabelPrivateGroup => "私人";

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
	public override string LabelPublishPlace => "發佈空間";

	/// <summary>
	/// Key: "Label.RemoveGroupPlace"
	/// English String: "Remove Group Place"
	/// </summary>
	public override string LabelRemoveGroupPlace => "移除群組空間";

	/// <summary>
	/// Key: "Label.RemoveMember"
	/// English String: "Remove Member"
	/// </summary>
	public override string LabelRemoveMember => "移除成員";

	/// <summary>
	/// Key: "Label.Rename"
	/// English String: "Rename"
	/// </summary>
	public override string LabelRename => "刪除";

	/// <summary>
	/// Key: "Label.RevertGroupAsset"
	/// English String: "Revert Group Asset"
	/// </summary>
	public override string LabelRevertGroupAsset => "還原群組素材";

	/// <summary>
	/// Key: "Label.SavePlace"
	/// English String: "Save Place"
	/// </summary>
	public override string LabelSavePlace => "儲存徽章";

	/// <summary>
	/// Key: "Label.SearchGroups"
	/// English String: "Search All Groups"
	/// </summary>
	public override string LabelSearchGroups => "搜尋所有群組";

	/// <summary>
	/// Key: "Label.SearchUsers"
	/// English String: "Search Users"
	/// </summary>
	public override string LabelSearchUsers => "搜尋使用者";

	/// <summary>
	/// Key: "Label.SendAllyRequest"
	/// English String: "Send Ally Request"
	/// </summary>
	public override string LabelSendAllyRequest => "傳送盟友請求";

	/// <summary>
	/// Key: "Label.ShoutPlaceholder"
	/// English String: "Enter your shout"
	/// </summary>
	public override string LabelShoutPlaceholder => "輸入您的廣播訊息";

	/// <summary>
	/// Key: "Label.SpendGroupFunds"
	/// English String: "Spend Group Funds"
	/// </summary>
	public override string LabelSpendGroupFunds => "使用群組資金";

	/// <summary>
	/// Key: "Label.Success"
	/// English String: "Success"
	/// </summary>
	public override string LabelSuccess => "成功";

	/// <summary>
	/// Key: "Label.Unlock"
	/// English String: "Unlock"
	/// </summary>
	public override string LabelUnlock => "解鎖";

	/// <summary>
	/// Key: "Label.UpdateGroupAsset"
	/// English String: "Update Group Asset"
	/// </summary>
	public override string LabelUpdateGroupAsset => "更新群組素材";

	/// <summary>
	/// Key: "Label.WallPostPlaceholder"
	/// English String: "Say something..."
	/// </summary>
	public override string LabelWallPostPlaceholder => "說點什麼…";

	/// <summary>
	/// Key: "Label.WallPostsUnavailable"
	/// Displayed in the group wall area when we cannot successfully load wall posts
	/// English String: "Wall posts are temporarily unavailable, please check back later."
	/// </summary>
	public override string LabelWallPostsUnavailable => "無法載入貼文，請稍後再試。";

	/// <summary>
	/// Key: "Label.Warning"
	/// English String: "Warning"
	/// </summary>
	public override string LabelWarning => "警告";

	/// <summary>
	/// Key: "Message.AlreadyMember"
	/// English String: "You are already a member of this group."
	/// </summary>
	public override string MessageAlreadyMember => "您已加入此群組。";

	/// <summary>
	/// Key: "Message.AlreadyRequested"
	/// English String: "You have already requested to join this group."
	/// </summary>
	public override string MessageAlreadyRequested => "您已請求加入此群組。";

	/// <summary>
	/// Key: "Message.BuildGroupRolesListError"
	/// English String: "Unable to load members for selected role."
	/// </summary>
	public override string MessageBuildGroupRolesListError => "無法載入此階級成員。";

	/// <summary>
	/// Key: "Message.CannotClaimGroupWithOwner"
	/// English String: "This group already has an owner."
	/// </summary>
	public override string MessageCannotClaimGroupWithOwner => "此群組已有主人。";

	/// <summary>
	/// Key: "Message.ChangeOwnerEmpty"
	/// English String: "There is no owner of the group"
	/// </summary>
	public override string MessageChangeOwnerEmpty => "群組沒有主人";

	/// <summary>
	/// Key: "Message.ClaimOwnershipError"
	/// English String: "Unable to claim ownership of group."
	/// </summary>
	public override string MessageClaimOwnershipError => "無法成為群組主人。";

	/// <summary>
	/// Key: "Message.ClaimOwnershipSuccess"
	/// English String: "Successfully claimed ownership of group."
	/// </summary>
	public override string MessageClaimOwnershipSuccess => "成功成為群組主人。";

	/// <summary>
	/// Key: "Message.DefaultError"
	/// English String: "An error occurred."
	/// </summary>
	public override string MessageDefaultError => "發生錯誤。";

	/// <summary>
	/// Key: "Message.DeleteWallPostError"
	/// English String: "Unable to delete wall post."
	/// </summary>
	public override string MessageDeleteWallPostError => "無法刪除貼文。";

	/// <summary>
	/// Key: "Message.DeleteWallPostsByUserError"
	/// English String: "Unable to delete wall posts by user."
	/// </summary>
	public override string MessageDeleteWallPostsByUserError => "無法刪除此使用者的貼文。";

	/// <summary>
	/// Key: "Message.DeleteWallPostSuccess"
	/// English String: "Successfully deleted wall post."
	/// </summary>
	public override string MessageDeleteWallPostSuccess => "成功刪除貼文。";

	/// <summary>
	/// Key: "Message.DescriptionTooLong"
	/// English String: "The description is too long."
	/// </summary>
	public override string MessageDescriptionTooLong => "說明過長。";

	/// <summary>
	/// Key: "Message.DuplicateName"
	/// English String: "Name is already taken. Please try another."
	/// </summary>
	public override string MessageDuplicateName => "名稱已被使用，請輸入新的名稱。";

	/// <summary>
	/// Key: "Message.ExileUserError"
	/// English String: "Unable to exile user."
	/// </summary>
	public override string MessageExileUserError => "無法驅逐使用者。";

	/// <summary>
	/// Key: "Message.FeatureDisabled"
	/// English String: "The feature is disabled."
	/// </summary>
	public override string MessageFeatureDisabled => "此功能停用中。";

	/// <summary>
	/// Key: "Message.GetGroupRelationshipsError"
	/// English String: "Unable to load group affiliates."
	/// </summary>
	public override string MessageGetGroupRelationshipsError => "無法載入群組夥伴。";

	/// <summary>
	/// Key: "Message.GroupClosed"
	/// English String: "You cannot join a closed group."
	/// </summary>
	public override string MessageGroupClosed => "無法加入已關閉的群組。";

	/// <summary>
	/// Key: "Message.GroupCreationDisabled"
	/// English String: "Group creation is currently disabled."
	/// </summary>
	public override string MessageGroupCreationDisabled => "目前無法建立群組。";

	/// <summary>
	/// Key: "Message.GroupIconInvalid"
	/// English String: "Icon is missing or invalid."
	/// </summary>
	public override string MessageGroupIconInvalid => "找不到圖示或圖示無效。";

	/// <summary>
	/// Key: "Message.GroupMembershipsUnavailableError"
	/// Error displayed on group details view when the system is in read-only mode for maintenance and you try to perform an action.
	/// English String: "The group membership system is temporarily unavailable. Please try again later."
	/// </summary>
	public override string MessageGroupMembershipsUnavailableError => "目前無法使用群組會員系統，請稍後再試。";

	/// <summary>
	/// Key: "Message.InsufficientFunds"
	/// English String: "Insufficient Robux funds."
	/// </summary>
	public override string MessageInsufficientFunds => "Robux 不足。";

	/// <summary>
	/// Key: "Message.InsufficientGroupSpace"
	/// English String: "You are already in the maximum number of groups."
	/// </summary>
	public override string MessageInsufficientGroupSpace => "您的加入群組數量已達上限。";

	/// <summary>
	/// Key: "Message.InsufficientMembership"
	/// English String: "You do not have the builders club membership necessary to join this group."
	/// </summary>
	public override string MessageInsufficientMembership => "您的 Builders Club 會員資格不足，無法加入此群組。";

	/// <summary>
	/// Key: "Message.InsufficientPermission"
	/// English String: "Insufficient permissions to complete the request."
	/// </summary>
	public override string MessageInsufficientPermission => "權限不足，無法執行請求。";

	/// <summary>
	/// Key: "Message.InsufficientPermissionsForRelationships"
	/// English String: "You don't have permission to manage this group's relationships."
	/// </summary>
	public override string MessageInsufficientPermissionsForRelationships => "您沒有權限管理群組關係。";

	/// <summary>
	/// Key: "Message.InsufficientRobux"
	/// English String: "You do not have enough Robux to create the group."
	/// </summary>
	public override string MessageInsufficientRobux => "您的 Robux 不足，無法建立群組。";

	/// <summary>
	/// Key: "Message.InvalidAmount"
	/// English String: "The amount is invalid."
	/// </summary>
	public override string MessageInvalidAmount => "金額無效。";

	/// <summary>
	/// Key: "Message.InvalidGroup"
	/// English String: "Group is invalid or does not exist."
	/// </summary>
	public override string MessageInvalidGroup => "群組無效或不存在。";

	/// <summary>
	/// Key: "Message.InvalidGroupIcon"
	/// English String: "The group icon is invalid."
	/// </summary>
	public override string MessageInvalidGroupIcon => "群組圖示無效。";

	/// <summary>
	/// Key: "Message.InvalidGroupId"
	/// English String: "The group is invalid or does not exist."
	/// </summary>
	public override string MessageInvalidGroupId => "群組無效或不存在。";

	/// <summary>
	/// Key: "Message.InvalidGroupWallPostId"
	/// English String: "The group wall post id is invalid or does not exist."
	/// </summary>
	public override string MessageInvalidGroupWallPostId => "動態牆貼文 ID 無效或不存在。";

	/// <summary>
	/// Key: "Message.InvalidIds"
	/// English String: "Ids could not be parsed from request."
	/// </summary>
	public override string MessageInvalidIds => "無法從請求取出 ID。";

	/// <summary>
	/// Key: "Message.InvalidIdsError"
	/// English String: "Ids could not be parsed from request."
	/// </summary>
	public override string MessageInvalidIdsError => "無法從請求取出 ID。";

	/// <summary>
	/// Key: "Message.InvalidMembership"
	/// English String: "User must have builders club membership."
	/// </summary>
	public override string MessageInvalidMembership => "使用者必須是 Builders Club 會員。";

	/// <summary>
	/// Key: "Message.InvalidName"
	/// English String: "The name is invalid."
	/// </summary>
	public override string MessageInvalidName => "名稱無效。";

	/// <summary>
	/// Key: "Message.InvalidPaginationParameters"
	/// English String: "Invalid or missing pagination parameters."
	/// </summary>
	public override string MessageInvalidPaginationParameters => "分頁參數無效或不存在。";

	/// <summary>
	/// Key: "Message.InvalidPayoutType"
	/// English String: "Invalid payout type."
	/// </summary>
	public override string MessageInvalidPayoutType => "支付類型無效。";

	/// <summary>
	/// Key: "Message.InvalidRecipient"
	/// English String: "The recipient is invalid."
	/// </summary>
	public override string MessageInvalidRecipient => "收件者無效。";

	/// <summary>
	/// Key: "Message.InvalidRelationshipType"
	/// English String: "Group relationship type is invalid."
	/// </summary>
	public override string MessageInvalidRelationshipType => "群組關係類型無效。";

	/// <summary>
	/// Key: "Message.InvalidRoleSetId"
	/// English String: "The roleset is invalid or does not exist."
	/// </summary>
	public override string MessageInvalidRoleSetId => "階級無效或不存在。";

	/// <summary>
	/// Key: "Message.InvalidUser"
	/// English String: "The user is invalid or does not exist."
	/// </summary>
	public override string MessageInvalidUser => "使用者無效或不存在。";

	/// <summary>
	/// Key: "Message.InvalidWallPostContent"
	/// English String: "Your post was empty, white space, or more than 500 characters."
	/// </summary>
	public override string MessageInvalidWallPostContent => "您的貼文可能空白，包含空格字元，或超過 500 個字元。";

	/// <summary>
	/// Key: "Message.JoinGroupError"
	/// English String: "Unable to join group."
	/// </summary>
	public override string MessageJoinGroupError => "無法加入群組。";

	/// <summary>
	/// Key: "Message.JoinGroupPendingSuccess"
	/// English String: "Requested to join group, your request is pending."
	/// </summary>
	public override string MessageJoinGroupPendingSuccess => "已傳送加入請求，請等待管理員審核。";

	/// <summary>
	/// Key: "Message.JoinGroupSuccess"
	/// English String: "Successfully joined the group."
	/// </summary>
	public override string MessageJoinGroupSuccess => "成功加入群組。";

	/// <summary>
	/// Key: "Message.LeaveGroupError"
	/// English String: "Unable to leave group."
	/// </summary>
	public override string MessageLeaveGroupError => "無法離開群組。";

	/// <summary>
	/// Key: "Message.LoadGroupError"
	/// English String: "Unable to load group."
	/// </summary>
	public override string MessageLoadGroupError => "無法載入群組。";

	/// <summary>
	/// Key: "Message.LoadGroupGamesError"
	/// English String: "Unable to load games."
	/// </summary>
	public override string MessageLoadGroupGamesError => "無法載入遊戲。";

	/// <summary>
	/// Key: "Message.LoadGroupListError"
	/// English String: "Unable to load group list."
	/// </summary>
	public override string MessageLoadGroupListError => "無法載入群組清單。";

	/// <summary>
	/// Key: "Message.LoadGroupMembershipsError"
	/// English String: "Unable to load user membership information."
	/// </summary>
	public override string MessageLoadGroupMembershipsError => "無法載入會員資格資訊。";

	/// <summary>
	/// Key: "Message.LoadGroupMetadataError"
	/// English String: "Unable to load group info."
	/// </summary>
	public override string MessageLoadGroupMetadataError => "無法載入群組資訊。";

	/// <summary>
	/// Key: "Message.LoadGroupStoreItemsError"
	/// English String: "Unable to load store items."
	/// </summary>
	public override string MessageLoadGroupStoreItemsError => "無法載入商店道具。";

	/// <summary>
	/// Key: "Message.LoadUserGroupMembershipError"
	/// English String: "Unable to load group member information."
	/// </summary>
	public override string MessageLoadUserGroupMembershipError => "無法載入成員資訊。";

	/// <summary>
	/// Key: "Message.LoadWallPostsError"
	/// English String: "Unable to load wall posts."
	/// </summary>
	public override string MessageLoadWallPostsError => "無法載入貼文。";

	/// <summary>
	/// Key: "Message.MakePrimaryError"
	/// English String: "Unable to make primary group."
	/// </summary>
	public override string MessageMakePrimaryError => "無法設為主要群組。";

	/// <summary>
	/// Key: "Message.MaxGroups"
	/// English String: "User is in maximum number of groups."
	/// </summary>
	public override string MessageMaxGroups => "使用者的加入群組數量已達上限。";

	/// <summary>
	/// Key: "Message.MissingGroupIcon"
	/// English String: "The group icon is missing from the request."
	/// </summary>
	public override string MessageMissingGroupIcon => "請求中找不到群組圖示。";

	/// <summary>
	/// Key: "Message.MissingGroupStatusContent"
	/// English String: "Missing group status content."
	/// </summary>
	public override string MessageMissingGroupStatusContent => "群組狀態不存在。";

	/// <summary>
	/// Key: "Message.NameInvalid"
	/// English String: "Name is missing or has invalid characters."
	/// </summary>
	public override string MessageNameInvalid => "找不到名稱或名稱含有無效字元。";

	/// <summary>
	/// Key: "Message.NameModerated"
	/// English String: "The name is moderated."
	/// </summary>
	public override string MessageNameModerated => "名稱遭到過濾。";

	/// <summary>
	/// Key: "Message.NameTaken"
	/// English String: "The name has been taken."
	/// </summary>
	public override string MessageNameTaken => "名稱已被使用。";

	/// <summary>
	/// Key: "Message.NameTooLong"
	/// English String: "The name is too long."
	/// </summary>
	public override string MessageNameTooLong => "名稱過長。";

	/// <summary>
	/// Key: "Message.NoPrimary"
	/// English String: "The user specified does not have a primary group."
	/// </summary>
	public override string MessageNoPrimary => "該使用者沒有主要群組。";

	/// <summary>
	/// Key: "Message.PassCaptchaToJoin"
	/// English String: "You must pass the captcha test before joining this group."
	/// </summary>
	public override string MessagePassCaptchaToJoin => "若要加入此群組，請先通過 Captcha 驗證。";

	/// <summary>
	/// Key: "Message.PassCaptchaToPost"
	/// English String: "Captcha must be solved to post to the group wall."
	/// </summary>
	public override string MessagePassCaptchaToPost => "若要在群組動態牆貼文，請先通過 Captcha 驗證。";

	/// <summary>
	/// Key: "Message.RemovePrimaryError"
	/// English String: "Unable to remove primary group."
	/// </summary>
	public override string MessageRemovePrimaryError => "無法解除主要群組。";

	/// <summary>
	/// Key: "Message.SearchTermCharactersLimit"
	/// English String: "The search term needs to be between 2 and 50 characters"
	/// </summary>
	public override string MessageSearchTermCharactersLimit => "搜尋字串須為 2 到 50 個字元之間";

	/// <summary>
	/// Key: "Message.SearchTermEmptyError"
	/// English String: "Search term is empty"
	/// </summary>
	public override string MessageSearchTermEmptyError => "搜尋字串空白";

	/// <summary>
	/// Key: "Message.SearchTermFilteredError"
	/// English String: "Search term was filtered"
	/// </summary>
	public override string MessageSearchTermFilteredError => "搜尋字串遭到過濾";

	/// <summary>
	/// Key: "Message.SendGroupShoutError"
	/// English String: "Unable to send group shout."
	/// </summary>
	public override string MessageSendGroupShoutError => "無法傳送群組廣播。";

	/// <summary>
	/// Key: "Message.SendPostError"
	/// English String: "Unable to send post."
	/// </summary>
	public override string MessageSendPostError => "無法發表貼文。";

	/// <summary>
	/// Key: "Message.TooManyAttempts"
	/// English String: "Too many attempts to join the group. Please try again later."
	/// </summary>
	public override string MessageTooManyAttempts => "加入群組次數過多，請稍後再試。";

	/// <summary>
	/// Key: "Message.TooManyAttemptsToClaimGroups"
	/// English String: "Too many attempts to claim groups. Please try again later."
	/// </summary>
	public override string MessageTooManyAttemptsToClaimGroups => "取得群組次數過多，請稍後再試。";

	/// <summary>
	/// Key: "Message.TooManyGroups"
	/// English String: "You have reached the group capacity. Please leave a group before creating a new one."
	/// </summary>
	public override string MessageTooManyGroups => "您已到達加入群組上限，建立新群組之前請先離開一個群組。";

	/// <summary>
	/// Key: "Message.TooManyIds"
	/// English String: "Too many ids in request."
	/// </summary>
	public override string MessageTooManyIds => "請求 ID 數量過多。";

	/// <summary>
	/// Key: "Message.TooManyPosts"
	/// English String: "You are posting too fast, please try again in a few minutes."
	/// </summary>
	public override string MessageTooManyPosts => "您的貼文頻率過高，請稍後再試。";

	/// <summary>
	/// Key: "Message.TooManyRequests"
	/// English String: "Too many requests."
	/// </summary>
	public override string MessageTooManyRequests => "請求過多。";

	/// <summary>
	/// Key: "Message.UnauthorizedForPostStatus"
	/// English String: "You are not authorized to set the status of this group."
	/// </summary>
	public override string MessageUnauthorizedForPostStatus => " 您沒有權限定此群組的狀態。";

	/// <summary>
	/// Key: "Message.UnauthorizedForViewGroupPayouts"
	/// English String: "You don't have permission to view this group's payouts."
	/// </summary>
	public override string MessageUnauthorizedForViewGroupPayouts => "您沒有權限檢視此群組的支付。";

	/// <summary>
	/// Key: "Message.UnauthorizedToClaimGroup"
	/// English String: "You are not authorized to claim this group."
	/// </summary>
	public override string MessageUnauthorizedToClaimGroup => "您沒有權限取得此群組。";

	/// <summary>
	/// Key: "Message.UnauthorizedToManageMember"
	/// English String: "You do not have permission to manage this member."
	/// </summary>
	public override string MessageUnauthorizedToManageMember => "您沒有管理此成員的權限。";

	/// <summary>
	/// Key: "Message.UnauthorizedToViewRolesetPermissions"
	/// English String: "You are not authorized to view permissions for this roleset."
	/// </summary>
	public override string MessageUnauthorizedToViewRolesetPermissions => "您沒有權限查看此階級的權限。";

	/// <summary>
	/// Key: "Message.UnauthorizedToViewWall"
	/// English String: "You do not have permission to access this group wall."
	/// </summary>
	public override string MessageUnauthorizedToViewWall => "您沒有使用此群組動態牆的權限。";

	/// <summary>
	/// Key: "Message.UnknownError"
	/// English String: "Unknown error"
	/// </summary>
	public override string MessageUnknownError => "未知錯誤";

	/// <summary>
	/// Key: "Message.UserNotInGroup"
	/// English String: "You aren't a member of the group specified."
	/// </summary>
	public override string MessageUserNotInGroup => "您不是指定群組的成員。";

	public GroupsResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAdvertiseGroup()
	{
		return "宣傳群組";
	}

	protected override string _GetTemplateForActionAuditLog()
	{
		return "管理紀錄";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "取消";
	}

	protected override string _GetTemplateForActionCancelRequest()
	{
		return "取消請求";
	}

	protected override string _GetTemplateForActionClaimOwnership()
	{
		return "成為主人";
	}

	protected override string _GetTemplateForActionClose()
	{
		return "關閉";
	}

	protected override string _GetTemplateForActionConfigureGroup()
	{
		return "設定群組";
	}

	protected override string _GetTemplateForActionCreateGroup()
	{
		return "建立群組";
	}

	protected override string _GetTemplateForActionDelete()
	{
		return "刪除";
	}

	protected override string _GetTemplateForActionExile()
	{
		return "驅逐";
	}

	protected override string _GetTemplateForActionExileUser()
	{
		return "驅除使用者";
	}

	protected override string _GetTemplateForActionGroupAdmin()
	{
		return "群組管理員";
	}

	protected override string _GetTemplateForActionGroupShout()
	{
		return "群組廣播";
	}

	protected override string _GetTemplateForActionJoinGroup()
	{
		return "加入群組";
	}

	protected override string _GetTemplateForActionLeaveGroup()
	{
		return "離開群組";
	}

	protected override string _GetTemplateForActionMakePrimary()
	{
		return "設為主要群組";
	}

	protected override string _GetTemplateForActionMakePrimaryGroup()
	{
		return "設為主要群組";
	}

	protected override string _GetTemplateForActionPost()
	{
		return "貼文";
	}

	protected override string _GetTemplateForActionPurchase()
	{
		return "購買";
	}

	protected override string _GetTemplateForActionRemovePrimary()
	{
		return "解除主要群組";
	}

	protected override string _GetTemplateForActionReport()
	{
		return "檢舉";
	}

	protected override string _GetTemplateForActionReportAbuse()
	{
		return "檢舉濫用";
	}

	protected override string _GetTemplateForActionUpgrade()
	{
		return "升級";
	}

	protected override string _GetTemplateForActionUpgradeToJoin()
	{
		return "升級後即可加入";
	}

	protected override string _GetTemplateForActionYes()
	{
		return "確定";
	}

	protected override string _GetTemplateForDescriptionClothingRevenue()
	{
		return "群組可以創作及販賣官方服裝，收入將歸入群組資金。";
	}

	protected override string _GetTemplateForDescriptionDeleteAllPostsByUser()
	{
		return "同時刪除此使用者所有貼文。";
	}

	protected override string _GetTemplateForDescriptionExileUserWarning()
	{
		return "確定驅逐此使用者？";
	}

	protected override string _GetTemplateForDescriptionLeaveGroupAsOwnerWarning()
	{
		return "此群組將會沒有主人。";
	}

	protected override string _GetTemplateForDescriptionLeaveGroupWarning()
	{
		return "確定離開群組？";
	}

	protected override string _GetTemplateForDescriptionMakePrimaryGroupWarning()
	{
		return "確定將此群組設為主要群組？";
	}

	protected override string _GetTemplateForDescriptionNoneMaxGroups()
	{
		return "若要加入更多群組，請升級到 Builders Club。";
	}

	protected override string _GetTemplateForDescriptionNoneMaxGroupsPremium()
	{
		return "若要加入更多群組，請升級到 Roblox Premium。";
	}

	protected override string _GetTemplateForDescriptionnoneMaxGroupsPremiumText()
	{
		return "若要加入更多群組，請升級到 Roblox Premium。";
	}

	protected override string _GetTemplateForDescriptionObcMaxGroups()
	{
		return "您的加入群組數量已達上限。";
	}

	protected override string _GetTemplateForDescriptionOtherBcMaxGroups()
	{
		return "若要加入更多群組，請升級您的 Builders Club 會員資格。";
	}

	protected override string _GetTemplateForDescriptionotherPremiumMaxGroupsText()
	{
		return "若要加入更多群組，請升級您的 Roblox Premium 會員資格。";
	}

	protected override string _GetTemplateForDescriptionPremiumMaxGroups()
	{
		return "您的加入群組數量已達上限。";
	}

	protected override string _GetTemplateForDescriptionPurchaseBody()
	{
		return "確定建立此群組？費用：";
	}

	protected override string _GetTemplateForDescriptionRemovePrimaryGroupWarning()
	{
		return "確定解除此群組為主要群組？";
	}

	protected override string _GetTemplateForDescriptionReportAbuseDescription()
	{
		return "您想檢舉什麼？";
	}

	protected override string _GetTemplateForDescriptionWallPrivacySettings()
	{
		return "您的隱私權設定不允許你發表貼文，請前往此處變更您的設定。";
	}

	protected override string _GetTemplateForHeadingAbout()
	{
		return "介紹";
	}

	protected override string _GetTemplateForHeadingAffiliates()
	{
		return "夥伴";
	}

	protected override string _GetTemplateForHeadingAllies()
	{
		return "盟友";
	}

	/// <summary>
	/// Key: "Heading.ConfigureGroup"
	/// English String: "Configure {groupName}"
	/// </summary>
	public override string HeadingConfigureGroup(string groupName)
	{
		return $"設定 {groupName}";
	}

	protected override string _GetTemplateForHeadingConfigureGroup()
	{
		return "設定 {groupName}";
	}

	protected override string _GetTemplateForHeadingDate()
	{
		return "日期";
	}

	protected override string _GetTemplateForHeadingDescription()
	{
		return "說明";
	}

	protected override string _GetTemplateForHeadingEnemies()
	{
		return "敵人";
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
		return "遊戲";
	}

	protected override string _GetTemplateForHeadingGroupPurchase()
	{
		return "群組購買確認";
	}

	protected override string _GetTemplateForHeadingGroupShout()
	{
		return "群組廣播";
	}

	protected override string _GetTemplateForHeadingLeaveGroup()
	{
		return "離開群組";
	}

	protected override string _GetTemplateForHeadingMakePrimaryGroup()
	{
		return "設為主要群組";
	}

	protected override string _GetTemplateForHeadingMembers()
	{
		return "成員";
	}

	protected override string _GetTemplateForHeadingNameOrDescription()
	{
		return "名稱或介紹";
	}

	protected override string _GetTemplateForHeadingPayouts()
	{
		return "支付";
	}

	protected override string _GetTemplateForHeadingPrimary()
	{
		return "主要";
	}

	protected override string _GetTemplateForHeadingRank()
	{
		return "階級";
	}

	protected override string _GetTemplateForHeadingRemovePrimaryGroup()
	{
		return "解除主要群組";
	}

	protected override string _GetTemplateForHeadingRole()
	{
		return "階級";
	}

	protected override string _GetTemplateForHeadingSettings()
	{
		return "設定";
	}

	protected override string _GetTemplateForHeadingShout()
	{
		return "廣播";
	}

	protected override string _GetTemplateForHeadingStore()
	{
		return "商店";
	}

	protected override string _GetTemplateForHeadingUser()
	{
		return "使用者";
	}

	protected override string _GetTemplateForHeadingWall()
	{
		return "動態牆";
	}

	protected override string _GetTemplateForLabelAbandon()
	{
		return "捨棄";
	}

	protected override string _GetTemplateForLabelAcceptAllyRequest()
	{
		return "接受盟友請求";
	}

	protected override string _GetTemplateForLabelAcceptJoinRequest()
	{
		return "接受加入請求";
	}

	protected override string _GetTemplateForLabelAddGroupPlace()
	{
		return "新增群組空間";
	}

	protected override string _GetTemplateForLabelAdjustCurrencyAmounts()
	{
		return "調整貨幣金額";
	}

	protected override string _GetTemplateForLabelAll()
	{
		return "全部";
	}

	protected override string _GetTemplateForLabelAnyoneCanJoin()
	{
		return "所有人都可以加入";
	}

	protected override string _GetTemplateForLabelBuyAd()
	{
		return "購買廣告";
	}

	protected override string _GetTemplateForLabelBuyClan()
	{
		return "購買公會";
	}

	protected override string _GetTemplateForLabelByOwner()
	{
		return "建立者：";
	}

	protected override string _GetTemplateForLabelCancelClanInvite()
	{
		return "取消公會邀請";
	}

	protected override string _GetTemplateForLabelChangeDescription()
	{
		return "變更說明";
	}

	protected override string _GetTemplateForLabelChangeOwner()
	{
		return "變更主人";
	}

	protected override string _GetTemplateForLabelChangeRank()
	{
		return "變更階級";
	}

	protected override string _GetTemplateForLabelClaim()
	{
		return "取得";
	}

	protected override string _GetTemplateForLabelConfigureBadge()
	{
		return "設定徽章";
	}

	protected override string _GetTemplateForLabelConfigureGroupAsset()
	{
		return "設定群組素材";
	}

	protected override string _GetTemplateForLabelConfigureGroupDevelopmentItem()
	{
		return "設定群組開發道具";
	}

	protected override string _GetTemplateForLabelConfigureGroupGame()
	{
		return "設定群組遊戲";
	}

	protected override string _GetTemplateForLabelConfigureItems()
	{
		return "設定道具";
	}

	protected override string _GetTemplateForLabelCreateBadge()
	{
		return "建立徽章";
	}

	protected override string _GetTemplateForLabelCreateEnemy()
	{
		return "設定敵人";
	}

	protected override string _GetTemplateForLabelCreateGamePass()
	{
		return "建立遊戲證";
	}

	protected override string _GetTemplateForLabelCreateGroup()
	{
		return "建立群組";
	}

	protected override string _GetTemplateForLabelCreateGroupAsset()
	{
		return "建立群組素材";
	}

	protected override string _GetTemplateForLabelCreateGroupBuildersClubTooltip()
	{
		return "只有 Builders Club 會員可以建立群組。";
	}

	protected override string _GetTemplateForLabelCreateGroupDescription()
	{
		return "說明（可省略）";
	}

	protected override string _GetTemplateForLabelCreateGroupDeveloperProduct()
	{
		return "建立群組開發人員產品";
	}

	protected override string _GetTemplateForLabelCreateGroupEmblem()
	{
		return "標誌";
	}

	protected override string _GetTemplateForLabelCreateGroupFee()
	{
		return "團隊建立費用";
	}

	protected override string _GetTemplateForLabelCreateGroupName()
	{
		return "命名群組";
	}

	protected override string _GetTemplateForLabelCreateGroupPremiumTooltip()
	{
		return "只有 Roblox Premium 會員可以建立群組。";
	}

	protected override string _GetTemplateForLabelCreateGroupTooltip()
	{
		return "建立新群組";
	}

	protected override string _GetTemplateForLabelCreateItems()
	{
		return "建立道具";
	}

	protected override string _GetTemplateForLabelDeclineAllyRequest()
	{
		return "拒絕盟友請求";
	}

	protected override string _GetTemplateForLabelDeclineJoinRequest()
	{
		return "拒絕加入請求";
	}

	protected override string _GetTemplateForLabelDelete()
	{
		return "刪除";
	}

	protected override string _GetTemplateForLabelDeleteAllPostsByUser()
	{
		return "同時刪除此使用者所有貼文。";
	}

	protected override string _GetTemplateForLabelDeleteAlly()
	{
		return "刪除盟友";
	}

	protected override string _GetTemplateForLabelDeleteEnemy()
	{
		return "刪除敵人";
	}

	protected override string _GetTemplateForLabelDeleteGroupPlace()
	{
		return "刪除群組空間";
	}

	protected override string _GetTemplateForLabelDeletePost()
	{
		return "刪除貼文";
	}

	protected override string _GetTemplateForLabelFunds()
	{
		return "資金";
	}

	protected override string _GetTemplateForLabelGroupClosed()
	{
		return "群組已關閉";
	}

	protected override string _GetTemplateForLabelGroupLocked()
	{
		return "此群組已遭鎖定";
	}

	/// <summary>
	/// Key: "Label.GroupSearchResults"
	/// English String: "Group Results For {searchTerm}"
	/// </summary>
	public override string LabelGroupSearchResults(string searchTerm)
	{
		return $"搜尋 {searchTerm} 得到的群組";
	}

	protected override string _GetTemplateForLabelGroupSearchResults()
	{
		return "搜尋 {searchTerm} 得到的群組";
	}

	protected override string _GetTemplateForLabelInviteToClan()
	{
		return "邀請到公會";
	}

	protected override string _GetTemplateForLabelKickFromClan()
	{
		return "踢出公會";
	}

	protected override string _GetTemplateForLabelLoading()
	{
		return "正在載入…";
	}

	protected override string _GetTemplateForLabelLock()
	{
		return "鎖定";
	}

	protected override string _GetTemplateForLabelManageGroupCreations()
	{
		return "創作或管理群組道具。";
	}

	protected override string _GetTemplateForLabelManualApproval()
	{
		return "手動批准";
	}

	/// <summary>
	/// Key: "Label.MaxGroupsTooltip"
	/// English String: "You may only be in a maximum of {maxGroups} groups at one time"
	/// </summary>
	public override string LabelMaxGroupsTooltip(string maxGroups)
	{
		return $"您最多只能同時加入 {maxGroups} 個群組";
	}

	protected override string _GetTemplateForLabelMaxGroupsTooltip()
	{
		return "您最多只能同時加入 {maxGroups} 個群組";
	}

	protected override string _GetTemplateForLabelMembers()
	{
		return "{memberCount, plural, =0 {# 位成員} =1 {# 位成員} other {# 位成員}}";
	}

	protected override string _GetTemplateForLabelModerateDiscussion()
	{
		return "管理對話";
	}

	protected override string _GetTemplateForLabelNoAllies()
	{
		return "此群組沒有盟友。";
	}

	protected override string _GetTemplateForLabelNoEnemies()
	{
		return "此群組沒有敵人。";
	}

	protected override string _GetTemplateForLabelNoGames()
	{
		return "此群組沒有遊戲。";
	}

	protected override string _GetTemplateForLabelNoMembersInRole()
	{
		return "此階級沒有成員。";
	}

	protected override string _GetTemplateForLabelNoOne()
	{
		return "沒有人！";
	}

	/// <summary>
	/// Key: "Label.NoResults"
	/// English String: "No results for \"{searchTerm}\""
	/// </summary>
	public override string LabelNoResults(string searchTerm)
	{
		return $"搜尋「{searchTerm}」沒有結果";
	}

	protected override string _GetTemplateForLabelNoResults()
	{
		return "搜尋「{searchTerm}」沒有結果";
	}

	protected override string _GetTemplateForLabelNoStoreItems()
	{
		return "此群組沒有販賣中道具。";
	}

	protected override string _GetTemplateForLabelNoWallPosts()
	{
		return "還沒有人發言…";
	}

	protected override string _GetTemplateForLabelOnlyBcCanJoin()
	{
		return "只有 Builders Club 會員可以加入";
	}

	protected override string _GetTemplateForLabelOnlyPremiumCanJoin()
	{
		return "會員限定";
	}

	protected override string _GetTemplateForLabelPrivateGroup()
	{
		return "私人";
	}

	protected override string _GetTemplateForLabelPublicGroup()
	{
		return "公開";
	}

	protected override string _GetTemplateForLabelPublishPlace()
	{
		return "發佈空間";
	}

	protected override string _GetTemplateForLabelRemoveGroupPlace()
	{
		return "移除群組空間";
	}

	protected override string _GetTemplateForLabelRemoveMember()
	{
		return "移除成員";
	}

	protected override string _GetTemplateForLabelRename()
	{
		return "刪除";
	}

	protected override string _GetTemplateForLabelRevertGroupAsset()
	{
		return "還原群組素材";
	}

	protected override string _GetTemplateForLabelSavePlace()
	{
		return "儲存徽章";
	}

	protected override string _GetTemplateForLabelSearchGroups()
	{
		return "搜尋所有群組";
	}

	protected override string _GetTemplateForLabelSearchUsers()
	{
		return "搜尋使用者";
	}

	protected override string _GetTemplateForLabelSendAllyRequest()
	{
		return "傳送盟友請求";
	}

	protected override string _GetTemplateForLabelShoutPlaceholder()
	{
		return "輸入您的廣播訊息";
	}

	protected override string _GetTemplateForLabelSpendGroupFunds()
	{
		return "使用群組資金";
	}

	protected override string _GetTemplateForLabelSuccess()
	{
		return "成功";
	}

	protected override string _GetTemplateForLabelUnlock()
	{
		return "解鎖";
	}

	protected override string _GetTemplateForLabelUpdateGroupAsset()
	{
		return "更新群組素材";
	}

	protected override string _GetTemplateForLabelWallPostPlaceholder()
	{
		return "說點什麼…";
	}

	protected override string _GetTemplateForLabelWallPostsUnavailable()
	{
		return "無法載入貼文，請稍後再試。";
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
		return $"{actor}（群組主人）捨棄了群組";
	}

	protected override string _GetTemplateForMessageAbandon()
	{
		return "{actor}（群組主人）捨棄了群組";
	}

	/// <summary>
	/// Key: "Message.AcceptAllyRequest"
	/// English String: "{actor} accepted group {group}'s ally request"
	/// </summary>
	public override string MessageAcceptAllyRequest(string actor, string group)
	{
		return $"{actor} 接受了群組 {group} 的盟友請求";
	}

	protected override string _GetTemplateForMessageAcceptAllyRequest()
	{
		return "{actor} 接受了群組 {group} 的盟友請求";
	}

	/// <summary>
	/// Key: "Message.AcceptJoinRequest"
	/// English String: "{actor} accepted user {user}'s join request"
	/// </summary>
	public override string MessageAcceptJoinRequest(string actor, string user)
	{
		return $"{actor} 接受了使用者 {user} 的加入請求";
	}

	protected override string _GetTemplateForMessageAcceptJoinRequest()
	{
		return "{actor} 接受了使用者 {user} 的加入請求";
	}

	/// <summary>
	/// Key: "Message.AddGroupPlace"
	/// English String: "{actor} added game {game} as a group game"
	/// </summary>
	public override string MessageAddGroupPlace(string actor, string game)
	{
		return $"{actor} 已新增遊戲 {game} 為群組遊戲";
	}

	protected override string _GetTemplateForMessageAddGroupPlace()
	{
		return "{actor} 已新增遊戲 {game} 為群組遊戲";
	}

	/// <summary>
	/// Key: "Message.AdjustCurrencyAmountsDecreased"
	/// English String: "{actor} decreased group funds by {amount}"
	/// </summary>
	public override string MessageAdjustCurrencyAmountsDecreased(string actor, string amount)
	{
		return $"{actor} 已將群組資金減少 {amount}";
	}

	protected override string _GetTemplateForMessageAdjustCurrencyAmountsDecreased()
	{
		return "{actor} 已將群組資金減少 {amount}";
	}

	/// <summary>
	/// Key: "Message.AdjustCurrencyAmountsIncreased"
	/// English String: "{actor} increased group funds by {amount}"
	/// </summary>
	public override string MessageAdjustCurrencyAmountsIncreased(string actor, string amount)
	{
		return $"{actor} 已將群組資金增加 {amount}";
	}

	protected override string _GetTemplateForMessageAdjustCurrencyAmountsIncreased()
	{
		return "{actor} 已將群組資金增加 {amount}";
	}

	protected override string _GetTemplateForMessageAlreadyMember()
	{
		return "您已加入此群組。";
	}

	protected override string _GetTemplateForMessageAlreadyRequested()
	{
		return "您已請求加入此群組。";
	}

	protected override string _GetTemplateForMessageBuildGroupRolesListError()
	{
		return "無法載入此階級成員。";
	}

	/// <summary>
	/// Key: "Message.BuyAd"
	/// English String: "{actor} bid {bid} on group ad {adName}"
	/// </summary>
	public override string MessageBuyAd(string actor, string bid, string adName)
	{
		return $"{actor} 已在群組廣告 {adName} 下標 {bid}";
	}

	protected override string _GetTemplateForMessageBuyAd()
	{
		return "{actor} 已在群組廣告 {adName} 下標 {bid}";
	}

	/// <summary>
	/// Key: "Message.BuyClan"
	/// English String: "{actor} bought a group clan"
	/// </summary>
	public override string MessageBuyClan(string actor)
	{
		return $"{actor} 購買了群組公會";
	}

	protected override string _GetTemplateForMessageBuyClan()
	{
		return "{actor} 購買了群組公會";
	}

	/// <summary>
	/// Key: "Message.CancelClanInvite"
	/// English String: "{actor} cancelled {user}'s clan invite"
	/// </summary>
	public override string MessageCancelClanInvite(string actor, string user)
	{
		return $"{actor} 已取消 {user} 的公會邀請";
	}

	protected override string _GetTemplateForMessageCancelClanInvite()
	{
		return "{actor} 已取消 {user} 的公會邀請";
	}

	protected override string _GetTemplateForMessageCannotClaimGroupWithOwner()
	{
		return "此群組已有主人。";
	}

	/// <summary>
	/// Key: "Message.ChangeDescription"
	/// English String: "{actor} changed the description to \"{newDescription}\""
	/// </summary>
	public override string MessageChangeDescription(string actor, string newDescription)
	{
		return $"{actor} 已將說明變更為「{newDescription}」";
	}

	protected override string _GetTemplateForMessageChangeDescription()
	{
		return "{actor} 已將說明變更為「{newDescription}」";
	}

	/// <summary>
	/// Key: "Message.ChangeOwner"
	/// English String: "{actor} changed the group owner. {user} is the new group owner"
	/// </summary>
	public override string MessageChangeOwner(string actor, string user)
	{
		return $"{actor} 已變更群組主人。新的群組主人為 {user}";
	}

	protected override string _GetTemplateForMessageChangeOwner()
	{
		return "{actor} 已變更群組主人。新的群組主人為 {user}";
	}

	protected override string _GetTemplateForMessageChangeOwnerEmpty()
	{
		return "群組沒有主人";
	}

	/// <summary>
	/// Key: "Message.ChangeRank"
	/// English String: "{actor} changed user {user}'s rank from {oldRoleSet} to {newRoleSet}"
	/// </summary>
	public override string MessageChangeRank(string actor, string user, string oldRoleSet, string newRoleSet)
	{
		return $"{actor} 已將使用者 {user} 的階級從 {oldRoleSet} 變更為 {newRoleSet}";
	}

	protected override string _GetTemplateForMessageChangeRank()
	{
		return "{actor} 已將使用者 {user} 的階級從 {oldRoleSet} 變更為 {newRoleSet}";
	}

	/// <summary>
	/// Key: "Message.Claim"
	/// English String: "{actor} claimed ownership of the group"
	/// </summary>
	public override string MessageClaim(string actor)
	{
		return $"{actor} 已成為群組主人";
	}

	protected override string _GetTemplateForMessageClaim()
	{
		return "{actor} 已成為群組主人";
	}

	protected override string _GetTemplateForMessageClaimOwnershipError()
	{
		return "無法成為群組主人。";
	}

	protected override string _GetTemplateForMessageClaimOwnershipSuccess()
	{
		return "成功成為群組主人。";
	}

	/// <summary>
	/// Key: "Message.ConfigureAsset"
	/// English String: "{actor} updated asset {item}: {actions}"
	/// </summary>
	public override string MessageConfigureAsset(string actor, string item, string actions)
	{
		return $"{actor} 已更新素材 {item}：{actions}";
	}

	protected override string _GetTemplateForMessageConfigureAsset()
	{
		return "{actor} 已更新素材 {item}：{actions}";
	}

	/// <summary>
	/// Key: "Message.ConfigureBadgeDisabled"
	/// English String: "{actor} disabled the badge {badge}"
	/// </summary>
	public override string MessageConfigureBadgeDisabled(string actor, string badge)
	{
		return $"{actor} 已停用徽章 {badge}";
	}

	protected override string _GetTemplateForMessageConfigureBadgeDisabled()
	{
		return "{actor} 已停用徽章 {badge}";
	}

	/// <summary>
	/// Key: "Message.ConfigureBadgeEnabled"
	/// English String: "{actor} enabled the badge {badge}"
	/// </summary>
	public override string MessageConfigureBadgeEnabled(string actor, string badge)
	{
		return $"{actor} 已啟用徽章 {badge}";
	}

	protected override string _GetTemplateForMessageConfigureBadgeEnabled()
	{
		return "{actor} 已啟用徽章 {badge}";
	}

	/// <summary>
	/// Key: "Message.ConfigureBadgeUpdate"
	/// English String: "{actor} configured the badge {badge}"
	/// </summary>
	public override string MessageConfigureBadgeUpdate(string actor, string badge)
	{
		return $"{actor} 已設定徽章 {badge}";
	}

	protected override string _GetTemplateForMessageConfigureBadgeUpdate()
	{
		return "{actor} 已設定徽章 {badge}";
	}

	/// <summary>
	/// Key: "Message.ConfigureGame"
	/// English String: "{actor} updated {game}: {actions}"
	/// </summary>
	public override string MessageConfigureGame(string actor, string game, string actions)
	{
		return $"{actor} 已更新 {game}：{actions}";
	}

	protected override string _GetTemplateForMessageConfigureGame()
	{
		return "{actor} 已更新 {game}：{actions}";
	}

	/// <summary>
	/// Key: "Message.ConfigureGameDeveloperProduct"
	/// English String: "{actor} updated developer product {id}: {actions}"
	/// </summary>
	public override string MessageConfigureGameDeveloperProduct(string actor, string id, string actions)
	{
		return $"{actor} 已更新開發人員產品 {id}：{actions}";
	}

	protected override string _GetTemplateForMessageConfigureGameDeveloperProduct()
	{
		return "{actor} 已更新開發人員產品 {id}：{actions}";
	}

	/// <summary>
	/// Key: "Message.ConfigureItems"
	/// English String: "{actor} configured the group item {item}"
	/// </summary>
	public override string MessageConfigureItems(string actor, string item)
	{
		return $"{actor} 已設定群組道具 {item}";
	}

	protected override string _GetTemplateForMessageConfigureItems()
	{
		return "{actor} 已設定群組道具 {item}";
	}

	/// <summary>
	/// Key: "Message.CreateAsset"
	/// English String: "{actor} created asset {item}"
	/// </summary>
	public override string MessageCreateAsset(string actor, string item)
	{
		return $"{actor} 已建立素材 {item}";
	}

	protected override string _GetTemplateForMessageCreateAsset()
	{
		return "{actor} 已建立素材 {item}";
	}

	/// <summary>
	/// Key: "Message.CreateBadge"
	/// English String: "{actor} created the badge {badge}"
	/// </summary>
	public override string MessageCreateBadge(string actor, string badge)
	{
		return $"{actor} 已建立徽章 {badge}";
	}

	protected override string _GetTemplateForMessageCreateBadge()
	{
		return "{actor} 已建立徽章 {badge}";
	}

	/// <summary>
	/// Key: "Message.CreateDeveloperProduct"
	/// English String: "{actor} created developer product with id {id}"
	/// </summary>
	public override string MessageCreateDeveloperProduct(string actor, string id)
	{
		return $"{actor} 已建立開發人員產品，ID 為 {id}";
	}

	protected override string _GetTemplateForMessageCreateDeveloperProduct()
	{
		return "{actor} 已建立開發人員產品，ID 為 {id}";
	}

	/// <summary>
	/// Key: "Message.CreateEnemy"
	/// English String: "{actor} declared group {group} as an enemy"
	/// </summary>
	public override string MessageCreateEnemy(string actor, string group)
	{
		return $"{actor} 已宣告群組 {group} 為敵人";
	}

	protected override string _GetTemplateForMessageCreateEnemy()
	{
		return "{actor} 已宣告群組 {group} 為敵人";
	}

	/// <summary>
	/// Key: "Message.CreateGamePass"
	/// English String: "{actor} created a Game Pass for {game}: {gamePass}"
	/// </summary>
	public override string MessageCreateGamePass(string actor, string game, string gamePass)
	{
		return $"{actor} 已為 {game} 建立遊戲證：{gamePass}";
	}

	protected override string _GetTemplateForMessageCreateGamePass()
	{
		return "{actor} 已為 {game} 建立遊戲證：{gamePass}";
	}

	/// <summary>
	/// Key: "Message.CreateItems"
	/// English String: "{actor} created the group item {item}"
	/// </summary>
	public override string MessageCreateItems(string actor, string item)
	{
		return $"{actor} 已建立群組道具 {item}";
	}

	protected override string _GetTemplateForMessageCreateItems()
	{
		return "{actor} 已建立群組道具 {item}";
	}

	/// <summary>
	/// Key: "Message.DeclineAllyRequest"
	/// English String: "{actor} declined group {group}'s ally request"
	/// </summary>
	public override string MessageDeclineAllyRequest(string actor, string group)
	{
		return $"{actor} 拒絕了群組 {group} 的盟友請求";
	}

	protected override string _GetTemplateForMessageDeclineAllyRequest()
	{
		return "{actor} 拒絕了群組 {group} 的盟友請求";
	}

	/// <summary>
	/// Key: "Message.DeclineJoinRequest"
	/// English String: "{actor} declined user {user}'s join request"
	/// </summary>
	public override string MessageDeclineJoinRequest(string actor, string user)
	{
		return $"{actor} 拒絕了使用者 {user} 的加入請求";
	}

	protected override string _GetTemplateForMessageDeclineJoinRequest()
	{
		return "{actor} 拒絕了使用者 {user} 的加入請求";
	}

	protected override string _GetTemplateForMessageDefaultError()
	{
		return "發生錯誤。";
	}

	/// <summary>
	/// Key: "Message.Delete"
	/// English String: "{actor} deleted current group"
	/// </summary>
	public override string MessageDelete(string actor)
	{
		return $"{actor} 刪除了目前群組";
	}

	protected override string _GetTemplateForMessageDelete()
	{
		return "{actor} 刪除了目前群組";
	}

	/// <summary>
	/// Key: "Message.DeleteAlly"
	/// English String: "{actor} removed group {group} as an ally"
	/// </summary>
	public override string MessageDeleteAlly(string actor, string group)
	{
		return $"{actor} 已將群組 {group} 從盟友移除";
	}

	protected override string _GetTemplateForMessageDeleteAlly()
	{
		return "{actor} 已將群組 {group} 從盟友移除";
	}

	/// <summary>
	/// Key: "Message.DeleteEnemy"
	/// English String: "{actor} removed group {group} as an enemy"
	/// </summary>
	public override string MessageDeleteEnemy(string actor, string group)
	{
		return $"{actor} 已將群組 {group} 從敵人移除";
	}

	protected override string _GetTemplateForMessageDeleteEnemy()
	{
		return "{actor} 已將群組 {group} 從敵人移除";
	}

	/// <summary>
	/// Key: "Message.DeleteGroupPlace"
	/// English String: "{actor} removed game {game} as a group game"
	/// </summary>
	public override string MessageDeleteGroupPlace(string actor, string game)
	{
		return $"{actor} 已移除遊戲 {game} 為群組遊戲";
	}

	protected override string _GetTemplateForMessageDeleteGroupPlace()
	{
		return "{actor} 已移除遊戲 {game} 為群組遊戲";
	}

	/// <summary>
	/// Key: "Message.DeletePost"
	/// English String: "{actor} deleted post \"{postDesc}\" by user {user}"
	/// </summary>
	public override string MessageDeletePost(string actor, string postDesc, string user)
	{
		return $"{actor} 刪除了使用者 {user} 發表的貼文「{postDesc}」";
	}

	protected override string _GetTemplateForMessageDeletePost()
	{
		return "{actor} 刪除了使用者 {user} 發表的貼文「{postDesc}」";
	}

	protected override string _GetTemplateForMessageDeleteWallPostError()
	{
		return "無法刪除貼文。";
	}

	protected override string _GetTemplateForMessageDeleteWallPostsByUserError()
	{
		return "無法刪除此使用者的貼文。";
	}

	protected override string _GetTemplateForMessageDeleteWallPostSuccess()
	{
		return "成功刪除貼文。";
	}

	protected override string _GetTemplateForMessageDescriptionTooLong()
	{
		return "說明過長。";
	}

	protected override string _GetTemplateForMessageDuplicateName()
	{
		return "名稱已被使用，請輸入新的名稱。";
	}

	protected override string _GetTemplateForMessageExileUserError()
	{
		return "無法驅逐使用者。";
	}

	protected override string _GetTemplateForMessageFeatureDisabled()
	{
		return "此功能停用中。";
	}

	protected override string _GetTemplateForMessageGetGroupRelationshipsError()
	{
		return "無法載入群組夥伴。";
	}

	protected override string _GetTemplateForMessageGroupClosed()
	{
		return "無法加入已關閉的群組。";
	}

	protected override string _GetTemplateForMessageGroupCreationDisabled()
	{
		return "目前無法建立群組。";
	}

	protected override string _GetTemplateForMessageGroupIconInvalid()
	{
		return "找不到圖示或圖示無效。";
	}

	/// <summary>
	/// Key: "Message.GroupIconTooLarge"
	/// English String: "Icon cannot be larger than {maxSize} mb."
	/// </summary>
	public override string MessageGroupIconTooLarge(string maxSize)
	{
		return $"圖示不可大於 {maxSize} MB。";
	}

	protected override string _GetTemplateForMessageGroupIconTooLarge()
	{
		return "圖示不可大於 {maxSize} MB。";
	}

	protected override string _GetTemplateForMessageGroupMembershipsUnavailableError()
	{
		return "目前無法使用群組會員系統，請稍後再試。";
	}

	protected override string _GetTemplateForMessageInsufficientFunds()
	{
		return "Robux 不足。";
	}

	protected override string _GetTemplateForMessageInsufficientGroupSpace()
	{
		return "您的加入群組數量已達上限。";
	}

	protected override string _GetTemplateForMessageInsufficientMembership()
	{
		return "您的 Builders Club 會員資格不足，無法加入此群組。";
	}

	protected override string _GetTemplateForMessageInsufficientPermission()
	{
		return "權限不足，無法執行請求。";
	}

	protected override string _GetTemplateForMessageInsufficientPermissionsForRelationships()
	{
		return "您沒有權限管理群組關係。";
	}

	protected override string _GetTemplateForMessageInsufficientRobux()
	{
		return "您的 Robux 不足，無法建立群組。";
	}

	protected override string _GetTemplateForMessageInvalidAmount()
	{
		return "金額無效。";
	}

	protected override string _GetTemplateForMessageInvalidGroup()
	{
		return "群組無效或不存在。";
	}

	protected override string _GetTemplateForMessageInvalidGroupIcon()
	{
		return "群組圖示無效。";
	}

	protected override string _GetTemplateForMessageInvalidGroupId()
	{
		return "群組無效或不存在。";
	}

	protected override string _GetTemplateForMessageInvalidGroupWallPostId()
	{
		return "動態牆貼文 ID 無效或不存在。";
	}

	protected override string _GetTemplateForMessageInvalidIds()
	{
		return "無法從請求取出 ID。";
	}

	protected override string _GetTemplateForMessageInvalidIdsError()
	{
		return "無法從請求取出 ID。";
	}

	protected override string _GetTemplateForMessageInvalidMembership()
	{
		return "使用者必須是 Builders Club 會員。";
	}

	protected override string _GetTemplateForMessageInvalidName()
	{
		return "名稱無效。";
	}

	protected override string _GetTemplateForMessageInvalidPaginationParameters()
	{
		return "分頁參數無效或不存在。";
	}

	protected override string _GetTemplateForMessageInvalidPayoutType()
	{
		return "支付類型無效。";
	}

	protected override string _GetTemplateForMessageInvalidRecipient()
	{
		return "收件者無效。";
	}

	protected override string _GetTemplateForMessageInvalidRelationshipType()
	{
		return "群組關係類型無效。";
	}

	protected override string _GetTemplateForMessageInvalidRoleSetId()
	{
		return "階級無效或不存在。";
	}

	protected override string _GetTemplateForMessageInvalidUser()
	{
		return "使用者無效或不存在。";
	}

	protected override string _GetTemplateForMessageInvalidWallPostContent()
	{
		return "您的貼文可能空白，包含空格字元，或超過 500 個字元。";
	}

	/// <summary>
	/// Key: "Message.InviteToClan"
	/// English String: "{actor} invited user {user} to the clan"
	/// </summary>
	public override string MessageInviteToClan(string actor, string user)
	{
		return $"{actor} 已將 {user} 邀請到公會";
	}

	protected override string _GetTemplateForMessageInviteToClan()
	{
		return "{actor} 已將 {user} 邀請到公會";
	}

	protected override string _GetTemplateForMessageJoinGroupError()
	{
		return "無法加入群組。";
	}

	protected override string _GetTemplateForMessageJoinGroupPendingSuccess()
	{
		return "已傳送加入請求，請等待管理員審核。";
	}

	protected override string _GetTemplateForMessageJoinGroupSuccess()
	{
		return "成功加入群組。";
	}

	/// <summary>
	/// Key: "Message.KickFromClan"
	/// English String: "{actor} kicked user {user} out of the clan"
	/// </summary>
	public override string MessageKickFromClan(string actor, string user)
	{
		return $"{actor} 已將 {user} 踢出公會";
	}

	protected override string _GetTemplateForMessageKickFromClan()
	{
		return "{actor} 已將 {user} 踢出公會";
	}

	protected override string _GetTemplateForMessageLeaveGroupError()
	{
		return "無法離開群組。";
	}

	protected override string _GetTemplateForMessageLoadGroupError()
	{
		return "無法載入群組。";
	}

	protected override string _GetTemplateForMessageLoadGroupGamesError()
	{
		return "無法載入遊戲。";
	}

	protected override string _GetTemplateForMessageLoadGroupListError()
	{
		return "無法載入群組清單。";
	}

	protected override string _GetTemplateForMessageLoadGroupMembershipsError()
	{
		return "無法載入會員資格資訊。";
	}

	protected override string _GetTemplateForMessageLoadGroupMetadataError()
	{
		return "無法載入群組資訊。";
	}

	protected override string _GetTemplateForMessageLoadGroupStoreItemsError()
	{
		return "無法載入商店道具。";
	}

	protected override string _GetTemplateForMessageLoadUserGroupMembershipError()
	{
		return "無法載入成員資訊。";
	}

	protected override string _GetTemplateForMessageLoadWallPostsError()
	{
		return "無法載入貼文。";
	}

	/// <summary>
	/// Key: "Message.Lock"
	/// English String: "{actor} locked the group"
	/// </summary>
	public override string MessageLock(string actor)
	{
		return $"{actor} 已鎖定群組";
	}

	protected override string _GetTemplateForMessageLock()
	{
		return "{actor} 已鎖定群組";
	}

	protected override string _GetTemplateForMessageMakePrimaryError()
	{
		return "無法設為主要群組。";
	}

	protected override string _GetTemplateForMessageMaxGroups()
	{
		return "使用者的加入群組數量已達上限。";
	}

	protected override string _GetTemplateForMessageMissingGroupIcon()
	{
		return "請求中找不到群組圖示。";
	}

	protected override string _GetTemplateForMessageMissingGroupStatusContent()
	{
		return "群組狀態不存在。";
	}

	protected override string _GetTemplateForMessageNameInvalid()
	{
		return "找不到名稱或名稱含有無效字元。";
	}

	protected override string _GetTemplateForMessageNameModerated()
	{
		return "名稱遭到過濾。";
	}

	protected override string _GetTemplateForMessageNameTaken()
	{
		return "名稱已被使用。";
	}

	protected override string _GetTemplateForMessageNameTooLong()
	{
		return "名稱過長。";
	}

	protected override string _GetTemplateForMessageNoPrimary()
	{
		return "該使用者沒有主要群組。";
	}

	protected override string _GetTemplateForMessagePassCaptchaToJoin()
	{
		return "若要加入此群組，請先通過 Captcha 驗證。";
	}

	protected override string _GetTemplateForMessagePassCaptchaToPost()
	{
		return "若要在群組動態牆貼文，請先通過 Captcha 驗證。";
	}

	/// <summary>
	/// Key: "Message.PostStatus"
	/// English String: "{actor} changed the group status to \"{groupStatus}\""
	/// </summary>
	public override string MessagePostStatus(string actor, string groupStatus)
	{
		return $"{actor} 已將群組狀態變更為「{groupStatus}」";
	}

	protected override string _GetTemplateForMessagePostStatus()
	{
		return "{actor} 已將群組狀態變更為「{groupStatus}」";
	}

	/// <summary>
	/// Key: "Message.RemoveMember"
	/// English String: "{actor} kicked user {user}"
	/// </summary>
	public override string MessageRemoveMember(string actor, string user)
	{
		return $"{actor} 已踢出使用者 {user}";
	}

	protected override string _GetTemplateForMessageRemoveMember()
	{
		return "{actor} 已踢出使用者 {user}";
	}

	protected override string _GetTemplateForMessageRemovePrimaryError()
	{
		return "無法解除主要群組。";
	}

	/// <summary>
	/// Key: "Message.Rename"
	/// English String: "{actor} renamed current group to {newName}"
	/// </summary>
	public override string MessageRename(string actor, string newName)
	{
		return $"{actor} 已將目前群組名稱變更為 {newName}";
	}

	protected override string _GetTemplateForMessageRename()
	{
		return "{actor} 已將目前群組名稱變更為 {newName}";
	}

	protected override string _GetTemplateForMessageSearchTermCharactersLimit()
	{
		return "搜尋字串須為 2 到 50 個字元之間";
	}

	protected override string _GetTemplateForMessageSearchTermEmptyError()
	{
		return "搜尋字串空白";
	}

	protected override string _GetTemplateForMessageSearchTermFilteredError()
	{
		return "搜尋字串遭到過濾";
	}

	/// <summary>
	/// Key: "Message.SendAllyRequest"
	/// English String: "{actor} sent an ally request to group {group}"
	/// </summary>
	public override string MessageSendAllyRequest(string actor, string group)
	{
		return $"{actor} 向群組 {group} 傳送了盟友請求";
	}

	protected override string _GetTemplateForMessageSendAllyRequest()
	{
		return "{actor} 向群組 {group} 傳送了盟友請求";
	}

	protected override string _GetTemplateForMessageSendGroupShoutError()
	{
		return "無法傳送群組廣播。";
	}

	protected override string _GetTemplateForMessageSendPostError()
	{
		return "無法發表貼文。";
	}

	/// <summary>
	/// Key: "Message.SpendGroupFunds"
	/// English String: "{actor} spent {amount} of group funds for: {item}"
	/// </summary>
	public override string MessageSpendGroupFunds(string actor, string amount, string item)
	{
		return $"{actor} 使用了 {amount} 群組資金購買 {item}";
	}

	protected override string _GetTemplateForMessageSpendGroupFunds()
	{
		return "{actor} 使用了 {amount} 群組資金購買 {item}";
	}

	protected override string _GetTemplateForMessageTooManyAttempts()
	{
		return "加入群組次數過多，請稍後再試。";
	}

	protected override string _GetTemplateForMessageTooManyAttemptsToClaimGroups()
	{
		return "取得群組次數過多，請稍後再試。";
	}

	protected override string _GetTemplateForMessageTooManyGroups()
	{
		return "您已到達加入群組上限，建立新群組之前請先離開一個群組。";
	}

	protected override string _GetTemplateForMessageTooManyIds()
	{
		return "請求 ID 數量過多。";
	}

	protected override string _GetTemplateForMessageTooManyPosts()
	{
		return "您的貼文頻率過高，請稍後再試。";
	}

	protected override string _GetTemplateForMessageTooManyRequests()
	{
		return "請求過多。";
	}

	protected override string _GetTemplateForMessageUnauthorizedForPostStatus()
	{
		return " 您沒有權限定此群組的狀態。";
	}

	protected override string _GetTemplateForMessageUnauthorizedForViewGroupPayouts()
	{
		return "您沒有權限檢視此群組的支付。";
	}

	protected override string _GetTemplateForMessageUnauthorizedToClaimGroup()
	{
		return "您沒有權限取得此群組。";
	}

	protected override string _GetTemplateForMessageUnauthorizedToManageMember()
	{
		return "您沒有管理此成員的權限。";
	}

	protected override string _GetTemplateForMessageUnauthorizedToViewRolesetPermissions()
	{
		return "您沒有權限查看此階級的權限。";
	}

	protected override string _GetTemplateForMessageUnauthorizedToViewWall()
	{
		return "您沒有使用此群組動態牆的權限。";
	}

	protected override string _GetTemplateForMessageUnknownError()
	{
		return "未知錯誤";
	}

	/// <summary>
	/// Key: "Message.Unlock"
	/// English String: "{actor} unlocked the group"
	/// </summary>
	public override string MessageUnlock(string actor)
	{
		return $"{actor} 已解鎖群組";
	}

	protected override string _GetTemplateForMessageUnlock()
	{
		return "{actor} 已解鎖群組";
	}

	/// <summary>
	/// Key: "Message.UpdateAsset"
	/// English String: "{actor} created new version {version} of asset {item}"
	/// </summary>
	public override string MessageUpdateAsset(string actor, string version, string item)
	{
		return $"{actor} 已建立素材 {item} 的第 {version} 版本";
	}

	protected override string _GetTemplateForMessageUpdateAsset()
	{
		return "{actor} 已建立素材 {item} 的第 {version} 版本";
	}

	/// <summary>
	/// Key: "Message.UpdateAssetRevert"
	/// English String: "{actor} reverted asset {item} from version {version} to {oldVersion}"
	/// </summary>
	public override string MessageUpdateAssetRevert(string actor, string item, string version, string oldVersion)
	{
		return $"{actor} 已將素材 {item} 的版本從 {version} 還原為 {oldVersion}";
	}

	protected override string _GetTemplateForMessageUpdateAssetRevert()
	{
		return "{actor} 已將素材 {item} 的版本從 {version} 還原為 {oldVersion}";
	}

	protected override string _GetTemplateForMessageUserNotInGroup()
	{
		return "您不是指定群組的成員。";
	}
}
