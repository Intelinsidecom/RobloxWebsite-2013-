namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides GroupsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class GroupsResources_zh_cjv : GroupsResources_en_us, IGroupsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.AdvertiseGroup"
	/// English String: "Advertise Group"
	/// </summary>
	public override string ActionAdvertiseGroup => "宣传群组";

	/// <summary>
	/// Key: "Action.AuditLog"
	/// English String: "Audit Log"
	/// </summary>
	public override string ActionAuditLog => "管理记录";

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "取消";

	/// <summary>
	/// Key: "Action.CancelRequest"
	/// English String: "Cancel Request"
	/// </summary>
	public override string ActionCancelRequest => "取消请求";

	/// <summary>
	/// Key: "Action.ClaimOwnership"
	/// English String: "Claim Ownership"
	/// </summary>
	public override string ActionClaimOwnership => "成为群主";

	/// <summary>
	/// Key: "Action.Close"
	/// English String: "Close"
	/// </summary>
	public override string ActionClose => "关闭";

	/// <summary>
	/// Key: "Action.ConfigureGroup"
	/// English String: "Configure Group"
	/// </summary>
	public override string ActionConfigureGroup => "配置群组";

	/// <summary>
	/// Key: "Action.CreateGroup"
	/// English String: "Create Group"
	/// </summary>
	public override string ActionCreateGroup => "创建群组";

	/// <summary>
	/// Key: "Action.Delete"
	/// English String: "Delete"
	/// </summary>
	public override string ActionDelete => "删除";

	/// <summary>
	/// Key: "Action.Exile"
	/// English String: "Exile"
	/// </summary>
	public override string ActionExile => "驱逐";

	/// <summary>
	/// Key: "Action.ExileUser"
	/// English String: "Exile User"
	/// </summary>
	public override string ActionExileUser => "驱逐用户";

	/// <summary>
	/// Key: "Action.GroupAdmin"
	/// English String: "Group Admin"
	/// </summary>
	public override string ActionGroupAdmin => "群组管理员";

	/// <summary>
	/// Key: "Action.GroupShout"
	/// Text on the button for sending / posting a group shout
	/// English String: "Group Shout"
	/// </summary>
	public override string ActionGroupShout => "群组广播";

	/// <summary>
	/// Key: "Action.JoinGroup"
	/// English String: "Join Group"
	/// </summary>
	public override string ActionJoinGroup => "加入群组";

	/// <summary>
	/// Key: "Action.LeaveGroup"
	/// English String: "Leave Group"
	/// </summary>
	public override string ActionLeaveGroup => "离开群组";

	/// <summary>
	/// Key: "Action.MakePrimary"
	/// English String: "Make Primary"
	/// </summary>
	public override string ActionMakePrimary => "设为主要群组";

	/// <summary>
	/// Key: "Action.MakePrimaryGroup"
	/// Set the current group as the users primary group
	/// English String: "Make Primary Group"
	/// </summary>
	public override string ActionMakePrimaryGroup => "设为主要群组";

	/// <summary>
	/// Key: "Action.Post"
	/// English String: "Post"
	/// </summary>
	public override string ActionPost => "发布";

	/// <summary>
	/// Key: "Action.Purchase"
	/// English String: "Purchase"
	/// </summary>
	public override string ActionPurchase => "购买";

	/// <summary>
	/// Key: "Action.RemovePrimary"
	/// English String: "Remove Primary"
	/// </summary>
	public override string ActionRemovePrimary => "移除主要群组";

	/// <summary>
	/// Key: "Action.Report"
	/// English String: "Report"
	/// </summary>
	public override string ActionReport => "举报";

	/// <summary>
	/// Key: "Action.ReportAbuse"
	/// English String: "Report Abuse"
	/// </summary>
	public override string ActionReportAbuse => "报告滥用行为";

	/// <summary>
	/// Key: "Action.Upgrade"
	/// English String: "Upgrade"
	/// </summary>
	public override string ActionUpgrade => "升级";

	/// <summary>
	/// Key: "Action.UpgradeToJoin"
	/// English String: "Upgrade to Join"
	/// </summary>
	public override string ActionUpgradeToJoin => "升级后即可加入";

	/// <summary>
	/// Key: "Action.Yes"
	/// English String: "Yes"
	/// </summary>
	public override string ActionYes => "是";

	/// <summary>
	/// Key: "Description.ClothingRevenue"
	/// English String: "Groups have the ability to create and sell official shirts, pants, and t-shirts! All revenue goes to group funds."
	/// </summary>
	public override string DescriptionClothingRevenue => "群组可创作并发售官方版衬衫，裤子及 T 恤，所有收入将作为资金归入群组。";

	/// <summary>
	/// Key: "Description.DeleteAllPostsByUser"
	/// English String: "Also delete all posts by this user."
	/// </summary>
	public override string DescriptionDeleteAllPostsByUser => "同时删除此用户的所有帖子。";

	/// <summary>
	/// Key: "Description.ExileUserWarning"
	/// English String: "Are you sure you want to exile this user?"
	/// </summary>
	public override string DescriptionExileUserWarning => "是否确定要驱逐此用户？";

	/// <summary>
	/// Key: "Description.LeaveGroupAsOwnerWarning"
	/// English String: "This will leave the group ownerless."
	/// </summary>
	public override string DescriptionLeaveGroupAsOwnerWarning => "此群组将会没有群主。";

	/// <summary>
	/// Key: "Description.LeaveGroupWarning"
	/// English String: "Are you sure you want to leave this group?"
	/// </summary>
	public override string DescriptionLeaveGroupWarning => "是否确定要离开此群组？";

	/// <summary>
	/// Key: "Description.MakePrimaryGroupWarning"
	/// English String: "Are you sure you want to make this your primary group?"
	/// </summary>
	public override string DescriptionMakePrimaryGroupWarning => "确定要将此群组设为你的主要群组？";

	/// <summary>
	/// Key: "Description.NoneMaxGroups"
	/// English String: "Upgrade to Builders Club to join more groups."
	/// </summary>
	public override string DescriptionNoneMaxGroups => "若要加入更多群组，请先升级为 Builders Club 会员。";

	/// <summary>
	/// Key: "Description.NoneMaxGroupsPremium"
	/// English String: "Upgrade to Roblox Premium to join more groups."
	/// </summary>
	public override string DescriptionNoneMaxGroupsPremium => "若要加入更多群组，请先升级至 Roblox Premium 会员。";

	/// <summary>
	/// Key: "Description.noneMaxGroupsPremiumText"
	/// English String: "Upgrade to Roblox Premium to join more groups."
	/// </summary>
	public override string DescriptionnoneMaxGroupsPremiumText => "若要加入更多群组，请先升级至 Roblox Premium 会员。";

	/// <summary>
	/// Key: "Description.ObcMaxGroups"
	/// English String: "You have joined the maximum number of groups."
	/// </summary>
	public override string DescriptionObcMaxGroups => "你加入的群组数量已达上限。";

	/// <summary>
	/// Key: "Description.OtherBcMaxGroups"
	/// English String: "Upgrade your Builders Club to join more groups."
	/// </summary>
	public override string DescriptionOtherBcMaxGroups => "若要加入更多群组，请先升级你的 Builders Club 会员资格。";

	/// <summary>
	/// Key: "Description.otherPremiumMaxGroupsText"
	/// English String: "Upgrade your Roblox Premium to join more groups."
	/// </summary>
	public override string DescriptionotherPremiumMaxGroupsText => "若要加入更多群组，请先升级你的 Roblox Premium 会员资格。";

	/// <summary>
	/// Key: "Description.PremiumMaxGroups"
	/// English String: "You have joined the maximum number of groups."
	/// </summary>
	public override string DescriptionPremiumMaxGroups => "你加入的群组数量已达上限。";

	/// <summary>
	/// Key: "Description.PurchaseBody"
	/// English String: "Would you like to create this group for"
	/// </summary>
	public override string DescriptionPurchaseBody => "确定要创建此群组吗？费用为：";

	/// <summary>
	/// Key: "Description.RemovePrimaryGroupWarning"
	/// English String: "Are you sure you want to remove your primary group?"
	/// </summary>
	public override string DescriptionRemovePrimaryGroupWarning => "是否确定要移除你的主要群组？";

	/// <summary>
	/// Key: "Description.ReportAbuseDescription"
	/// English String: "What would you like to report?"
	/// </summary>
	public override string DescriptionReportAbuseDescription => "你想要举报哪些问题？";

	/// <summary>
	/// Key: "Description.WallPrivacySettings"
	/// English String: "Your privacy settings do not allow you to post to group walls. Click here to adjust these settings."
	/// </summary>
	public override string DescriptionWallPrivacySettings => "你的隐私设置不允许你发布帖子，请点按此处更改你的设置。";

	/// <summary>
	/// Key: "Heading.About"
	/// English String: "About"
	/// </summary>
	public override string HeadingAbout => "简介";

	/// <summary>
	/// Key: "Heading.Affiliates"
	/// English String: "Affiliates"
	/// </summary>
	public override string HeadingAffiliates => "伙伴";

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
	public override string HeadingDescription => "描述";

	/// <summary>
	/// Key: "Heading.Enemies"
	/// English String: "Enemies"
	/// </summary>
	public override string HeadingEnemies => "敌人";

	/// <summary>
	/// Key: "Heading.ExileUserWarning"
	/// English String: "Warning"
	/// </summary>
	public override string HeadingExileUserWarning => "警告";

	/// <summary>
	/// Key: "Heading.Funds"
	/// English String: "Funds"
	/// </summary>
	public override string HeadingFunds => "资金";

	/// <summary>
	/// Key: "Heading.Games"
	/// English String: "Games"
	/// </summary>
	public override string HeadingGames => "游戏";

	/// <summary>
	/// Key: "Heading.GroupPurchase"
	/// English String: "Group Purchase Confirmation"
	/// </summary>
	public override string HeadingGroupPurchase => "群组购买确认";

	/// <summary>
	/// Key: "Heading.GroupShout"
	/// English String: "Group Shout"
	/// </summary>
	public override string HeadingGroupShout => "群组广播";

	/// <summary>
	/// Key: "Heading.LeaveGroup"
	/// English String: "Leave Group"
	/// </summary>
	public override string HeadingLeaveGroup => "离开群组";

	/// <summary>
	/// Key: "Heading.MakePrimaryGroup"
	/// Heading of make primary group modal
	/// English String: "Make Primary Group"
	/// </summary>
	public override string HeadingMakePrimaryGroup => "设为主要群组";

	/// <summary>
	/// Key: "Heading.Members"
	/// English String: "Members"
	/// </summary>
	public override string HeadingMembers => "成员";

	/// <summary>
	/// Key: "Heading.NameOrDescription"
	/// Selection option for what to report when reporting something in a group
	/// English String: "Name or Description"
	/// </summary>
	public override string HeadingNameOrDescription => "名称或描述";

	/// <summary>
	/// Key: "Heading.Payouts"
	/// English String: "Payouts"
	/// </summary>
	public override string HeadingPayouts => "支出";

	/// <summary>
	/// Key: "Heading.Primary"
	/// English String: "Primary"
	/// </summary>
	public override string HeadingPrimary => "主要";

	/// <summary>
	/// Key: "Heading.Rank"
	/// English String: "Rank"
	/// </summary>
	public override string HeadingRank => "等级";

	/// <summary>
	/// Key: "Heading.RemovePrimaryGroup"
	/// English String: "Remove Primary Group"
	/// </summary>
	public override string HeadingRemovePrimaryGroup => "移除主要群组";

	/// <summary>
	/// Key: "Heading.Role"
	/// English String: "Role"
	/// </summary>
	public override string HeadingRole => "角色";

	/// <summary>
	/// Key: "Heading.Settings"
	/// English String: "Settings"
	/// </summary>
	public override string HeadingSettings => "设置";

	/// <summary>
	/// Key: "Heading.Shout"
	/// To be displayed above the group shout (the current status for a group set by admins)
	/// English String: "Shout"
	/// </summary>
	public override string HeadingShout => "广播";

	/// <summary>
	/// Key: "Heading.Store"
	/// English String: "Store"
	/// </summary>
	public override string HeadingStore => "商店";

	/// <summary>
	/// Key: "Heading.User"
	/// English String: "User"
	/// </summary>
	public override string HeadingUser => "用户";

	/// <summary>
	/// Key: "Heading.Wall"
	/// English String: "Wall"
	/// </summary>
	public override string HeadingWall => "留言板";

	/// <summary>
	/// Key: "Label.Abandon"
	/// English String: "Abandon"
	/// </summary>
	public override string LabelAbandon => "舍弃";

	/// <summary>
	/// Key: "Label.AcceptAllyRequest"
	/// English String: "Accept Ally Request"
	/// </summary>
	public override string LabelAcceptAllyRequest => "接受盟友邀请";

	/// <summary>
	/// Key: "Label.AcceptJoinRequest"
	/// English String: "Accept Join Request"
	/// </summary>
	public override string LabelAcceptJoinRequest => "接受加入邀请";

	/// <summary>
	/// Key: "Label.AddGroupPlace"
	/// English String: "Add Group Place"
	/// </summary>
	public override string LabelAddGroupPlace => "添加群组空间";

	/// <summary>
	/// Key: "Label.AdjustCurrencyAmounts"
	/// English String: "Adjust Currency Amounts"
	/// </summary>
	public override string LabelAdjustCurrencyAmounts => "调整货币金额";

	/// <summary>
	/// Key: "Label.All"
	/// English String: "All"
	/// </summary>
	public override string LabelAll => "全部";

	/// <summary>
	/// Key: "Label.AnyoneCanJoin"
	/// English String: "Anyone Can Join"
	/// </summary>
	public override string LabelAnyoneCanJoin => "任何人都可以加入";

	/// <summary>
	/// Key: "Label.BuyAd"
	/// English String: "Buy Ad"
	/// </summary>
	public override string LabelBuyAd => "购买广告";

	/// <summary>
	/// Key: "Label.BuyClan"
	/// English String: "Buy Clan"
	/// </summary>
	public override string LabelBuyClan => "购买公会";

	/// <summary>
	/// Key: "Label.ByOwner"
	/// Prefix to either the owner of the group, or "No One!" if the group has no owner. Could not properly format like By {ownerName} because ownerName is a link in this case
	/// English String: "By"
	/// </summary>
	public override string LabelByOwner => "创建者";

	/// <summary>
	/// Key: "Label.CancelClanInvite"
	/// English String: "Cancel Clan Invite"
	/// </summary>
	public override string LabelCancelClanInvite => "取消公会邀请";

	/// <summary>
	/// Key: "Label.ChangeDescription"
	/// English String: "Change Description"
	/// </summary>
	public override string LabelChangeDescription => "更改描述";

	/// <summary>
	/// Key: "Label.ChangeOwner"
	/// English String: "Change Owner"
	/// </summary>
	public override string LabelChangeOwner => "变更群主";

	/// <summary>
	/// Key: "Label.ChangeRank"
	/// English String: "Change Rank"
	/// </summary>
	public override string LabelChangeRank => "更改等级";

	/// <summary>
	/// Key: "Label.Claim"
	/// English String: "Claim"
	/// </summary>
	public override string LabelClaim => "获取";

	/// <summary>
	/// Key: "Label.ConfigureBadge"
	/// English String: "Configure Badge"
	/// </summary>
	public override string LabelConfigureBadge => "设置徽章";

	/// <summary>
	/// Key: "Label.ConfigureGroupAsset"
	/// English String: "Configure Group Asset"
	/// </summary>
	public override string LabelConfigureGroupAsset => "设置群组素材";

	/// <summary>
	/// Key: "Label.ConfigureGroupDevelopmentItem"
	/// English String: "Configure Group Development Item"
	/// </summary>
	public override string LabelConfigureGroupDevelopmentItem => "设置群组开发道具";

	/// <summary>
	/// Key: "Label.ConfigureGroupGame"
	/// English String: "Configure Group Game"
	/// </summary>
	public override string LabelConfigureGroupGame => "设置群组名称";

	/// <summary>
	/// Key: "Label.ConfigureItems"
	/// English String: "Configure Items"
	/// </summary>
	public override string LabelConfigureItems => "设置道具";

	/// <summary>
	/// Key: "Label.CreateBadge"
	/// English String: "Create Badge"
	/// </summary>
	public override string LabelCreateBadge => "创建徽章";

	/// <summary>
	/// Key: "Label.CreateEnemy"
	/// English String: "Create Enemy"
	/// </summary>
	public override string LabelCreateEnemy => "设定敌人";

	/// <summary>
	/// Key: "Label.CreateGamePass"
	/// English String: "Create Game Pass"
	/// </summary>
	public override string LabelCreateGamePass => "创建游戏通行证";

	/// <summary>
	/// Key: "Label.CreateGroup"
	/// English String: "Create Group"
	/// </summary>
	public override string LabelCreateGroup => "创建群组";

	/// <summary>
	/// Key: "Label.CreateGroupAsset"
	/// English String: "Create Group Asset"
	/// </summary>
	public override string LabelCreateGroupAsset => "创建群组素材";

	/// <summary>
	/// Key: "Label.CreateGroupBuildersClubTooltip"
	/// English String: "Creating a group requires a Builders Club membership."
	/// </summary>
	public override string LabelCreateGroupBuildersClubTooltip => "需要拥有 Builders Club 会员资格才能创建群组。";

	/// <summary>
	/// Key: "Label.CreateGroupDescription"
	/// English String: "Description (optional)"
	/// </summary>
	public override string LabelCreateGroupDescription => "描述（可省略）";

	/// <summary>
	/// Key: "Label.CreateGroupDeveloperProduct"
	/// English String: "Create Group Developer Product"
	/// </summary>
	public override string LabelCreateGroupDeveloperProduct => "创建群组开发者产品";

	/// <summary>
	/// Key: "Label.CreateGroupEmblem"
	/// English String: "Emblem"
	/// </summary>
	public override string LabelCreateGroupEmblem => "标志";

	/// <summary>
	/// Key: "Label.CreateGroupFee"
	/// English String: "Group Creation Fee"
	/// </summary>
	public override string LabelCreateGroupFee => "创建群组费用";

	/// <summary>
	/// Key: "Label.CreateGroupName"
	/// English String: "Name your group"
	/// </summary>
	public override string LabelCreateGroupName => "命名你的群组";

	/// <summary>
	/// Key: "Label.CreateGroupPremiumTooltip"
	/// English String: "Creating a group requires a Roblox Premium membership."
	/// </summary>
	public override string LabelCreateGroupPremiumTooltip => "需要拥有 Roblox Premium 会员资格才能创建群组。";

	/// <summary>
	/// Key: "Label.CreateGroupTooltip"
	/// English String: "Create a new group"
	/// </summary>
	public override string LabelCreateGroupTooltip => "创建新群组";

	/// <summary>
	/// Key: "Label.CreateItems"
	/// English String: "Create Items"
	/// </summary>
	public override string LabelCreateItems => "创建道具";

	/// <summary>
	/// Key: "Label.DeclineAllyRequest"
	/// English String: "Decline Ally Request"
	/// </summary>
	public override string LabelDeclineAllyRequest => "拒绝盟友邀请";

	/// <summary>
	/// Key: "Label.DeclineJoinRequest"
	/// English String: "Decline Join Request"
	/// </summary>
	public override string LabelDeclineJoinRequest => "拒绝加入邀请";

	/// <summary>
	/// Key: "Label.Delete"
	/// English String: "Delete"
	/// </summary>
	public override string LabelDelete => "删除";

	/// <summary>
	/// Key: "Label.DeleteAllPostsByUser"
	/// English String: "Also delete all posts by this user."
	/// </summary>
	public override string LabelDeleteAllPostsByUser => "同时删除此用户的所有帖子。";

	/// <summary>
	/// Key: "Label.DeleteAlly"
	/// English String: "Delete Ally"
	/// </summary>
	public override string LabelDeleteAlly => "删除盟友";

	/// <summary>
	/// Key: "Label.DeleteEnemy"
	/// English String: "Delete Enemy"
	/// </summary>
	public override string LabelDeleteEnemy => "删除敌人";

	/// <summary>
	/// Key: "Label.DeleteGroupPlace"
	/// English String: "Delete Group Place"
	/// </summary>
	public override string LabelDeleteGroupPlace => "删除群组空间";

	/// <summary>
	/// Key: "Label.DeletePost"
	/// English String: "Delete Post"
	/// </summary>
	public override string LabelDeletePost => "删除帖子";

	/// <summary>
	/// Key: "Label.Funds"
	/// English String: "Funds"
	/// </summary>
	public override string LabelFunds => "资金";

	/// <summary>
	/// Key: "Label.GroupClosed"
	/// English String: "Group Closed"
	/// </summary>
	public override string LabelGroupClosed => "群组已关闭";

	/// <summary>
	/// Key: "Label.GroupLocked"
	/// English String: "This group has been locked"
	/// </summary>
	public override string LabelGroupLocked => "此群组已被锁定";

	/// <summary>
	/// Key: "Label.InviteToClan"
	/// English String: "Invite to Clan"
	/// </summary>
	public override string LabelInviteToClan => "邀请至公会";

	/// <summary>
	/// Key: "Label.KickFromClan"
	/// English String: "Kick from Clan"
	/// </summary>
	public override string LabelKickFromClan => "踢出公会";

	/// <summary>
	/// Key: "Label.Loading"
	/// English String: "Loading..."
	/// </summary>
	public override string LabelLoading => "正在加载...";

	/// <summary>
	/// Key: "Label.Lock"
	/// English String: "Lock"
	/// </summary>
	public override string LabelLock => "锁定";

	/// <summary>
	/// Key: "Label.ManageGroupCreations"
	/// English String: "Create or manage group items."
	/// </summary>
	public override string LabelManageGroupCreations => "创建或管理群组内容。";

	/// <summary>
	/// Key: "Label.ManualApproval"
	/// English String: "Manual Approval"
	/// </summary>
	public override string LabelManualApproval => "手动批准";

	/// <summary>
	/// Key: "Label.ModerateDiscussion"
	/// English String: "Moderate Discussion"
	/// </summary>
	public override string LabelModerateDiscussion => "管理对话";

	/// <summary>
	/// Key: "Label.NoAllies"
	/// English String: "This group does not have any allies."
	/// </summary>
	public override string LabelNoAllies => "此群组没有任何盟友。";

	/// <summary>
	/// Key: "Label.NoEnemies"
	/// English String: "This group does not have any enemies."
	/// </summary>
	public override string LabelNoEnemies => "此群组没有任何敌人。";

	/// <summary>
	/// Key: "Label.NoGames"
	/// English String: "No games are associated with this group."
	/// </summary>
	public override string LabelNoGames => "没有与此群组相关联的游戏。";

	/// <summary>
	/// Key: "Label.NoMembersInRole"
	/// English String: "No group members are in this role."
	/// </summary>
	public override string LabelNoMembersInRole => "没有此角色的群组成员。";

	/// <summary>
	/// Key: "Label.NoOne"
	/// English String: "No One!"
	/// </summary>
	public override string LabelNoOne => "没有人！";

	/// <summary>
	/// Key: "Label.NoStoreItems"
	/// English String: "No items are for sale in this group."
	/// </summary>
	public override string LabelNoStoreItems => "此群组没有待售物品。";

	/// <summary>
	/// Key: "Label.NoWallPosts"
	/// English String: "Nobody has said anything yet..."
	/// </summary>
	public override string LabelNoWallPosts => "还没有人发言...";

	/// <summary>
	/// Key: "Label.OnlyBcCanJoin"
	/// English String: "Only Builders Club members can join"
	/// </summary>
	public override string LabelOnlyBcCanJoin => "只有 Builders Club 会员才能加入";

	/// <summary>
	/// Key: "Label.OnlyPremiumCanJoin"
	/// English String: "Only users with membership can join"
	/// </summary>
	public override string LabelOnlyPremiumCanJoin => "仅限会员";

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
	public override string LabelPublicGroup => "公开";

	/// <summary>
	/// Key: "Label.PublishPlace"
	/// English String: "Publish Place"
	/// </summary>
	public override string LabelPublishPlace => "发布空间";

	/// <summary>
	/// Key: "Label.RemoveGroupPlace"
	/// English String: "Remove Group Place"
	/// </summary>
	public override string LabelRemoveGroupPlace => "移除群组空间";

	/// <summary>
	/// Key: "Label.RemoveMember"
	/// English String: "Remove Member"
	/// </summary>
	public override string LabelRemoveMember => "移除成员";

	/// <summary>
	/// Key: "Label.Rename"
	/// English String: "Rename"
	/// </summary>
	public override string LabelRename => "重命名";

	/// <summary>
	/// Key: "Label.RevertGroupAsset"
	/// English String: "Revert Group Asset"
	/// </summary>
	public override string LabelRevertGroupAsset => "还原群组素材";

	/// <summary>
	/// Key: "Label.SavePlace"
	/// English String: "Save Place"
	/// </summary>
	public override string LabelSavePlace => "保存空间";

	/// <summary>
	/// Key: "Label.SearchGroups"
	/// English String: "Search All Groups"
	/// </summary>
	public override string LabelSearchGroups => "搜索全部群组";

	/// <summary>
	/// Key: "Label.SearchUsers"
	/// English String: "Search Users"
	/// </summary>
	public override string LabelSearchUsers => "搜索用户";

	/// <summary>
	/// Key: "Label.SendAllyRequest"
	/// English String: "Send Ally Request"
	/// </summary>
	public override string LabelSendAllyRequest => "发送盟友邀请";

	/// <summary>
	/// Key: "Label.ShoutPlaceholder"
	/// English String: "Enter your shout"
	/// </summary>
	public override string LabelShoutPlaceholder => "输入你的广播内容";

	/// <summary>
	/// Key: "Label.SpendGroupFunds"
	/// English String: "Spend Group Funds"
	/// </summary>
	public override string LabelSpendGroupFunds => "使用群组资金";

	/// <summary>
	/// Key: "Label.Success"
	/// English String: "Success"
	/// </summary>
	public override string LabelSuccess => "成功";

	/// <summary>
	/// Key: "Label.Unlock"
	/// English String: "Unlock"
	/// </summary>
	public override string LabelUnlock => "解锁";

	/// <summary>
	/// Key: "Label.UpdateGroupAsset"
	/// English String: "Update Group Asset"
	/// </summary>
	public override string LabelUpdateGroupAsset => "更新群组素材";

	/// <summary>
	/// Key: "Label.WallPostPlaceholder"
	/// English String: "Say something..."
	/// </summary>
	public override string LabelWallPostPlaceholder => "说点什么...";

	/// <summary>
	/// Key: "Label.WallPostsUnavailable"
	/// Displayed in the group wall area when we cannot successfully load wall posts
	/// English String: "Wall posts are temporarily unavailable, please check back later."
	/// </summary>
	public override string LabelWallPostsUnavailable => "留言板帖子暂时不可用，请稍后重试。";

	/// <summary>
	/// Key: "Label.Warning"
	/// English String: "Warning"
	/// </summary>
	public override string LabelWarning => "警告";

	/// <summary>
	/// Key: "Message.AlreadyMember"
	/// English String: "You are already a member of this group."
	/// </summary>
	public override string MessageAlreadyMember => "你已加入此群组。";

	/// <summary>
	/// Key: "Message.AlreadyRequested"
	/// English String: "You have already requested to join this group."
	/// </summary>
	public override string MessageAlreadyRequested => "你已请求加入此群组。";

	/// <summary>
	/// Key: "Message.BuildGroupRolesListError"
	/// English String: "Unable to load members for selected role."
	/// </summary>
	public override string MessageBuildGroupRolesListError => "无法加载所选角色的成员。";

	/// <summary>
	/// Key: "Message.CannotClaimGroupWithOwner"
	/// English String: "This group already has an owner."
	/// </summary>
	public override string MessageCannotClaimGroupWithOwner => "此群组已有群主。";

	/// <summary>
	/// Key: "Message.ChangeOwnerEmpty"
	/// English String: "There is no owner of the group"
	/// </summary>
	public override string MessageChangeOwnerEmpty => "群组没有群主";

	/// <summary>
	/// Key: "Message.ClaimOwnershipError"
	/// English String: "Unable to claim ownership of group."
	/// </summary>
	public override string MessageClaimOwnershipError => "无法成为群主。";

	/// <summary>
	/// Key: "Message.ClaimOwnershipSuccess"
	/// English String: "Successfully claimed ownership of group."
	/// </summary>
	public override string MessageClaimOwnershipSuccess => "成功成为群主。";

	/// <summary>
	/// Key: "Message.DefaultError"
	/// English String: "An error occurred."
	/// </summary>
	public override string MessageDefaultError => "发生错误。";

	/// <summary>
	/// Key: "Message.DeleteWallPostError"
	/// English String: "Unable to delete wall post."
	/// </summary>
	public override string MessageDeleteWallPostError => "无法删除留言板帖子。";

	/// <summary>
	/// Key: "Message.DeleteWallPostsByUserError"
	/// English String: "Unable to delete wall posts by user."
	/// </summary>
	public override string MessageDeleteWallPostsByUserError => "无法删除此用户的帖子。";

	/// <summary>
	/// Key: "Message.DeleteWallPostSuccess"
	/// English String: "Successfully deleted wall post."
	/// </summary>
	public override string MessageDeleteWallPostSuccess => "成功删除帖子。";

	/// <summary>
	/// Key: "Message.DescriptionTooLong"
	/// English String: "The description is too long."
	/// </summary>
	public override string MessageDescriptionTooLong => "描述过长。";

	/// <summary>
	/// Key: "Message.DuplicateName"
	/// English String: "Name is already taken. Please try another."
	/// </summary>
	public override string MessageDuplicateName => "名称已被使用，请输入新的名称。";

	/// <summary>
	/// Key: "Message.ExileUserError"
	/// English String: "Unable to exile user."
	/// </summary>
	public override string MessageExileUserError => "无法驱逐用户。";

	/// <summary>
	/// Key: "Message.FeatureDisabled"
	/// English String: "The feature is disabled."
	/// </summary>
	public override string MessageFeatureDisabled => "此功能已停用。";

	/// <summary>
	/// Key: "Message.GetGroupRelationshipsError"
	/// English String: "Unable to load group affiliates."
	/// </summary>
	public override string MessageGetGroupRelationshipsError => "无法加载群组伙伴。";

	/// <summary>
	/// Key: "Message.GroupClosed"
	/// English String: "You cannot join a closed group."
	/// </summary>
	public override string MessageGroupClosed => "你不能加入已关闭的群组。";

	/// <summary>
	/// Key: "Message.GroupCreationDisabled"
	/// English String: "Group creation is currently disabled."
	/// </summary>
	public override string MessageGroupCreationDisabled => "当前无法创建群组。";

	/// <summary>
	/// Key: "Message.GroupIconInvalid"
	/// English String: "Icon is missing or invalid."
	/// </summary>
	public override string MessageGroupIconInvalid => "图标缺失或无效。";

	/// <summary>
	/// Key: "Message.GroupMembershipsUnavailableError"
	/// Error displayed on group details view when the system is in read-only mode for maintenance and you try to perform an action.
	/// English String: "The group membership system is temporarily unavailable. Please try again later."
	/// </summary>
	public override string MessageGroupMembershipsUnavailableError => "群组会员系统当前不可用。请稍后重试。";

	/// <summary>
	/// Key: "Message.InsufficientFunds"
	/// English String: "Insufficient Robux funds."
	/// </summary>
	public override string MessageInsufficientFunds => "Robux 不足。";

	/// <summary>
	/// Key: "Message.InsufficientGroupSpace"
	/// English String: "You are already in the maximum number of groups."
	/// </summary>
	public override string MessageInsufficientGroupSpace => "你加入的群组数量已达上限。";

	/// <summary>
	/// Key: "Message.InsufficientMembership"
	/// English String: "You do not have the builders club membership necessary to join this group."
	/// </summary>
	public override string MessageInsufficientMembership => "你的 Builders Club 会员资格不足，无法加入此群组。";

	/// <summary>
	/// Key: "Message.InsufficientPermission"
	/// English String: "Insufficient permissions to complete the request."
	/// </summary>
	public override string MessageInsufficientPermission => "权限不足，无法完成请求。";

	/// <summary>
	/// Key: "Message.InsufficientPermissionsForRelationships"
	/// English String: "You don't have permission to manage this group's relationships."
	/// </summary>
	public override string MessageInsufficientPermissionsForRelationships => "你没有权限管理群组关系。";

	/// <summary>
	/// Key: "Message.InsufficientRobux"
	/// English String: "You do not have enough Robux to create the group."
	/// </summary>
	public override string MessageInsufficientRobux => "你的 Robux 不足，无法创建群组。";

	/// <summary>
	/// Key: "Message.InvalidAmount"
	/// English String: "The amount is invalid."
	/// </summary>
	public override string MessageInvalidAmount => "金额无效。";

	/// <summary>
	/// Key: "Message.InvalidGroup"
	/// English String: "Group is invalid or does not exist."
	/// </summary>
	public override string MessageInvalidGroup => "群组无效或不存在。";

	/// <summary>
	/// Key: "Message.InvalidGroupIcon"
	/// English String: "The group icon is invalid."
	/// </summary>
	public override string MessageInvalidGroupIcon => "群组图标无效。";

	/// <summary>
	/// Key: "Message.InvalidGroupId"
	/// English String: "The group is invalid or does not exist."
	/// </summary>
	public override string MessageInvalidGroupId => "群组无效或不存在。";

	/// <summary>
	/// Key: "Message.InvalidGroupWallPostId"
	/// English String: "The group wall post id is invalid or does not exist."
	/// </summary>
	public override string MessageInvalidGroupWallPostId => "群组页面帖子 ID 无效或不存在。";

	/// <summary>
	/// Key: "Message.InvalidIds"
	/// English String: "Ids could not be parsed from request."
	/// </summary>
	public override string MessageInvalidIds => "无法从请求取出 ID。";

	/// <summary>
	/// Key: "Message.InvalidIdsError"
	/// English String: "Ids could not be parsed from request."
	/// </summary>
	public override string MessageInvalidIdsError => "无法从请求取出 ID。";

	/// <summary>
	/// Key: "Message.InvalidMembership"
	/// English String: "User must have builders club membership."
	/// </summary>
	public override string MessageInvalidMembership => "用户必须是 Builders Club 会员。";

	/// <summary>
	/// Key: "Message.InvalidName"
	/// English String: "The name is invalid."
	/// </summary>
	public override string MessageInvalidName => "名称无效。";

	/// <summary>
	/// Key: "Message.InvalidPaginationParameters"
	/// English String: "Invalid or missing pagination parameters."
	/// </summary>
	public override string MessageInvalidPaginationParameters => "分页参数无效或不存在。";

	/// <summary>
	/// Key: "Message.InvalidPayoutType"
	/// English String: "Invalid payout type."
	/// </summary>
	public override string MessageInvalidPayoutType => "支付类型无效。";

	/// <summary>
	/// Key: "Message.InvalidRecipient"
	/// English String: "The recipient is invalid."
	/// </summary>
	public override string MessageInvalidRecipient => "收件人无效。";

	/// <summary>
	/// Key: "Message.InvalidRelationshipType"
	/// English String: "Group relationship type is invalid."
	/// </summary>
	public override string MessageInvalidRelationshipType => "群组关系类型无效。";

	/// <summary>
	/// Key: "Message.InvalidRoleSetId"
	/// English String: "The roleset is invalid or does not exist."
	/// </summary>
	public override string MessageInvalidRoleSetId => "等级无效或不存在。";

	/// <summary>
	/// Key: "Message.InvalidUser"
	/// English String: "The user is invalid or does not exist."
	/// </summary>
	public override string MessageInvalidUser => "用户无效或不存在。";

	/// <summary>
	/// Key: "Message.InvalidWallPostContent"
	/// English String: "Your post was empty, white space, or more than 500 characters."
	/// </summary>
	public override string MessageInvalidWallPostContent => "你的帖子可能为空白、包含空格，或超过 500 个字符。";

	/// <summary>
	/// Key: "Message.JoinGroupError"
	/// English String: "Unable to join group."
	/// </summary>
	public override string MessageJoinGroupError => "无法加入群组。";

	/// <summary>
	/// Key: "Message.JoinGroupPendingSuccess"
	/// English String: "Requested to join group, your request is pending."
	/// </summary>
	public override string MessageJoinGroupPendingSuccess => "加入群组请求已发送，请等待审核。";

	/// <summary>
	/// Key: "Message.JoinGroupSuccess"
	/// English String: "Successfully joined the group."
	/// </summary>
	public override string MessageJoinGroupSuccess => "成功加入群组。";

	/// <summary>
	/// Key: "Message.LeaveGroupError"
	/// English String: "Unable to leave group."
	/// </summary>
	public override string MessageLeaveGroupError => "无法离开群组。";

	/// <summary>
	/// Key: "Message.LoadGroupError"
	/// English String: "Unable to load group."
	/// </summary>
	public override string MessageLoadGroupError => "无法加载群组。";

	/// <summary>
	/// Key: "Message.LoadGroupGamesError"
	/// English String: "Unable to load games."
	/// </summary>
	public override string MessageLoadGroupGamesError => "无法加载游戏。";

	/// <summary>
	/// Key: "Message.LoadGroupListError"
	/// English String: "Unable to load group list."
	/// </summary>
	public override string MessageLoadGroupListError => "无法加载群组列表。";

	/// <summary>
	/// Key: "Message.LoadGroupMembershipsError"
	/// English String: "Unable to load user membership information."
	/// </summary>
	public override string MessageLoadGroupMembershipsError => "无法加载用户会员资格信息。";

	/// <summary>
	/// Key: "Message.LoadGroupMetadataError"
	/// English String: "Unable to load group info."
	/// </summary>
	public override string MessageLoadGroupMetadataError => "无法加载群组信息。";

	/// <summary>
	/// Key: "Message.LoadGroupStoreItemsError"
	/// English String: "Unable to load store items."
	/// </summary>
	public override string MessageLoadGroupStoreItemsError => "无法加载商店道具。";

	/// <summary>
	/// Key: "Message.LoadUserGroupMembershipError"
	/// English String: "Unable to load group member information."
	/// </summary>
	public override string MessageLoadUserGroupMembershipError => "无法加载群组成员信息。";

	/// <summary>
	/// Key: "Message.LoadWallPostsError"
	/// English String: "Unable to load wall posts."
	/// </summary>
	public override string MessageLoadWallPostsError => "无法加载帖子。";

	/// <summary>
	/// Key: "Message.MakePrimaryError"
	/// English String: "Unable to make primary group."
	/// </summary>
	public override string MessageMakePrimaryError => "无法设为主要群组。";

	/// <summary>
	/// Key: "Message.MaxGroups"
	/// English String: "User is in maximum number of groups."
	/// </summary>
	public override string MessageMaxGroups => "用户加入的群组数量已达上限。";

	/// <summary>
	/// Key: "Message.MissingGroupIcon"
	/// English String: "The group icon is missing from the request."
	/// </summary>
	public override string MessageMissingGroupIcon => "请求中找不到群组图标。";

	/// <summary>
	/// Key: "Message.MissingGroupStatusContent"
	/// English String: "Missing group status content."
	/// </summary>
	public override string MessageMissingGroupStatusContent => "群组状态内容不存在。";

	/// <summary>
	/// Key: "Message.NameInvalid"
	/// English String: "Name is missing or has invalid characters."
	/// </summary>
	public override string MessageNameInvalid => "名称缺失或包含无效字符。";

	/// <summary>
	/// Key: "Message.NameModerated"
	/// English String: "The name is moderated."
	/// </summary>
	public override string MessageNameModerated => "名称已被过滤。";

	/// <summary>
	/// Key: "Message.NameTaken"
	/// English String: "The name has been taken."
	/// </summary>
	public override string MessageNameTaken => "名称已占用。";

	/// <summary>
	/// Key: "Message.NameTooLong"
	/// English String: "The name is too long."
	/// </summary>
	public override string MessageNameTooLong => "名称过长。";

	/// <summary>
	/// Key: "Message.NoPrimary"
	/// English String: "The user specified does not have a primary group."
	/// </summary>
	public override string MessageNoPrimary => "该用户没有主要群组。";

	/// <summary>
	/// Key: "Message.PassCaptchaToJoin"
	/// English String: "You must pass the captcha test before joining this group."
	/// </summary>
	public override string MessagePassCaptchaToJoin => "若要加入此群组，请先通过 Captcha 验证。";

	/// <summary>
	/// Key: "Message.PassCaptchaToPost"
	/// English String: "Captcha must be solved to post to the group wall."
	/// </summary>
	public override string MessagePassCaptchaToPost => "若要在群组页面发布帖子，请先通过 Captcha 验证。";

	/// <summary>
	/// Key: "Message.RemovePrimaryError"
	/// English String: "Unable to remove primary group."
	/// </summary>
	public override string MessageRemovePrimaryError => "无法移除主要群组。";

	/// <summary>
	/// Key: "Message.SearchTermCharactersLimit"
	/// English String: "The search term needs to be between 2 and 50 characters"
	/// </summary>
	public override string MessageSearchTermCharactersLimit => "搜索字符须为 2 到 50 个字符之间";

	/// <summary>
	/// Key: "Message.SearchTermEmptyError"
	/// English String: "Search term is empty"
	/// </summary>
	public override string MessageSearchTermEmptyError => "搜索字符为空";

	/// <summary>
	/// Key: "Message.SearchTermFilteredError"
	/// English String: "Search term was filtered"
	/// </summary>
	public override string MessageSearchTermFilteredError => "搜索字符已被过滤";

	/// <summary>
	/// Key: "Message.SendGroupShoutError"
	/// English String: "Unable to send group shout."
	/// </summary>
	public override string MessageSendGroupShoutError => "无法发送群组广播。";

	/// <summary>
	/// Key: "Message.SendPostError"
	/// English String: "Unable to send post."
	/// </summary>
	public override string MessageSendPostError => "无法发送帖子。";

	/// <summary>
	/// Key: "Message.TooManyAttempts"
	/// English String: "Too many attempts to join the group. Please try again later."
	/// </summary>
	public override string MessageTooManyAttempts => "尝试加入群组的次数过多。请稍后重试。";

	/// <summary>
	/// Key: "Message.TooManyAttemptsToClaimGroups"
	/// English String: "Too many attempts to claim groups. Please try again later."
	/// </summary>
	public override string MessageTooManyAttemptsToClaimGroups => "尝试认领群组的次数过多。请稍后重试。";

	/// <summary>
	/// Key: "Message.TooManyGroups"
	/// English String: "You have reached the group capacity. Please leave a group before creating a new one."
	/// </summary>
	public override string MessageTooManyGroups => "你加入的群组已达上限。创建新群组前，请先离开一个群组。";

	/// <summary>
	/// Key: "Message.TooManyIds"
	/// English String: "Too many ids in request."
	/// </summary>
	public override string MessageTooManyIds => "请求 ID 数量过多。";

	/// <summary>
	/// Key: "Message.TooManyPosts"
	/// English String: "You are posting too fast, please try again in a few minutes."
	/// </summary>
	public override string MessageTooManyPosts => "你的帖子发布频率过高，请稍候重试。";

	/// <summary>
	/// Key: "Message.TooManyRequests"
	/// English String: "Too many requests."
	/// </summary>
	public override string MessageTooManyRequests => "请求过多。";

	/// <summary>
	/// Key: "Message.UnauthorizedForPostStatus"
	/// English String: "You are not authorized to set the status of this group."
	/// </summary>
	public override string MessageUnauthorizedForPostStatus => "你没有权限来限定此群组的状态。";

	/// <summary>
	/// Key: "Message.UnauthorizedForViewGroupPayouts"
	/// English String: "You don't have permission to view this group's payouts."
	/// </summary>
	public override string MessageUnauthorizedForViewGroupPayouts => "你没有权限查看此群组的支付。";

	/// <summary>
	/// Key: "Message.UnauthorizedToClaimGroup"
	/// English String: "You are not authorized to claim this group."
	/// </summary>
	public override string MessageUnauthorizedToClaimGroup => "你没有权限认领此群组。";

	/// <summary>
	/// Key: "Message.UnauthorizedToManageMember"
	/// English String: "You do not have permission to manage this member."
	/// </summary>
	public override string MessageUnauthorizedToManageMember => "你没有管理此成员的权限。";

	/// <summary>
	/// Key: "Message.UnauthorizedToViewRolesetPermissions"
	/// English String: "You are not authorized to view permissions for this roleset."
	/// </summary>
	public override string MessageUnauthorizedToViewRolesetPermissions => "你没有权限查看此等级的权限。";

	/// <summary>
	/// Key: "Message.UnauthorizedToViewWall"
	/// English String: "You do not have permission to access this group wall."
	/// </summary>
	public override string MessageUnauthorizedToViewWall => "你没有访问此群组页面的权限。";

	/// <summary>
	/// Key: "Message.UnknownError"
	/// English String: "Unknown error"
	/// </summary>
	public override string MessageUnknownError => "未知错误";

	/// <summary>
	/// Key: "Message.UserNotInGroup"
	/// English String: "You aren't a member of the group specified."
	/// </summary>
	public override string MessageUserNotInGroup => "你不是指定群组的成员。";

	public GroupsResources_zh_cjv(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAdvertiseGroup()
	{
		return "宣传群组";
	}

	protected override string _GetTemplateForActionAuditLog()
	{
		return "管理记录";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "取消";
	}

	protected override string _GetTemplateForActionCancelRequest()
	{
		return "取消请求";
	}

	protected override string _GetTemplateForActionClaimOwnership()
	{
		return "成为群主";
	}

	protected override string _GetTemplateForActionClose()
	{
		return "关闭";
	}

	protected override string _GetTemplateForActionConfigureGroup()
	{
		return "配置群组";
	}

	protected override string _GetTemplateForActionCreateGroup()
	{
		return "创建群组";
	}

	protected override string _GetTemplateForActionDelete()
	{
		return "删除";
	}

	protected override string _GetTemplateForActionExile()
	{
		return "驱逐";
	}

	protected override string _GetTemplateForActionExileUser()
	{
		return "驱逐用户";
	}

	protected override string _GetTemplateForActionGroupAdmin()
	{
		return "群组管理员";
	}

	protected override string _GetTemplateForActionGroupShout()
	{
		return "群组广播";
	}

	protected override string _GetTemplateForActionJoinGroup()
	{
		return "加入群组";
	}

	protected override string _GetTemplateForActionLeaveGroup()
	{
		return "离开群组";
	}

	protected override string _GetTemplateForActionMakePrimary()
	{
		return "设为主要群组";
	}

	protected override string _GetTemplateForActionMakePrimaryGroup()
	{
		return "设为主要群组";
	}

	protected override string _GetTemplateForActionPost()
	{
		return "发布";
	}

	protected override string _GetTemplateForActionPurchase()
	{
		return "购买";
	}

	protected override string _GetTemplateForActionRemovePrimary()
	{
		return "移除主要群组";
	}

	protected override string _GetTemplateForActionReport()
	{
		return "举报";
	}

	protected override string _GetTemplateForActionReportAbuse()
	{
		return "报告滥用行为";
	}

	protected override string _GetTemplateForActionUpgrade()
	{
		return "升级";
	}

	protected override string _GetTemplateForActionUpgradeToJoin()
	{
		return "升级后即可加入";
	}

	protected override string _GetTemplateForActionYes()
	{
		return "是";
	}

	protected override string _GetTemplateForDescriptionClothingRevenue()
	{
		return "群组可创作并发售官方版衬衫，裤子及 T 恤，所有收入将作为资金归入群组。";
	}

	protected override string _GetTemplateForDescriptionDeleteAllPostsByUser()
	{
		return "同时删除此用户的所有帖子。";
	}

	protected override string _GetTemplateForDescriptionExileUserWarning()
	{
		return "是否确定要驱逐此用户？";
	}

	protected override string _GetTemplateForDescriptionLeaveGroupAsOwnerWarning()
	{
		return "此群组将会没有群主。";
	}

	protected override string _GetTemplateForDescriptionLeaveGroupWarning()
	{
		return "是否确定要离开此群组？";
	}

	protected override string _GetTemplateForDescriptionMakePrimaryGroupWarning()
	{
		return "确定要将此群组设为你的主要群组？";
	}

	protected override string _GetTemplateForDescriptionNoneMaxGroups()
	{
		return "若要加入更多群组，请先升级为 Builders Club 会员。";
	}

	protected override string _GetTemplateForDescriptionNoneMaxGroupsPremium()
	{
		return "若要加入更多群组，请先升级至 Roblox Premium 会员。";
	}

	protected override string _GetTemplateForDescriptionnoneMaxGroupsPremiumText()
	{
		return "若要加入更多群组，请先升级至 Roblox Premium 会员。";
	}

	protected override string _GetTemplateForDescriptionObcMaxGroups()
	{
		return "你加入的群组数量已达上限。";
	}

	protected override string _GetTemplateForDescriptionOtherBcMaxGroups()
	{
		return "若要加入更多群组，请先升级你的 Builders Club 会员资格。";
	}

	protected override string _GetTemplateForDescriptionotherPremiumMaxGroupsText()
	{
		return "若要加入更多群组，请先升级你的 Roblox Premium 会员资格。";
	}

	protected override string _GetTemplateForDescriptionPremiumMaxGroups()
	{
		return "你加入的群组数量已达上限。";
	}

	protected override string _GetTemplateForDescriptionPurchaseBody()
	{
		return "确定要创建此群组吗？费用为：";
	}

	protected override string _GetTemplateForDescriptionRemovePrimaryGroupWarning()
	{
		return "是否确定要移除你的主要群组？";
	}

	protected override string _GetTemplateForDescriptionReportAbuseDescription()
	{
		return "你想要举报哪些问题？";
	}

	protected override string _GetTemplateForDescriptionWallPrivacySettings()
	{
		return "你的隐私设置不允许你发布帖子，请点按此处更改你的设置。";
	}

	protected override string _GetTemplateForHeadingAbout()
	{
		return "简介";
	}

	protected override string _GetTemplateForHeadingAffiliates()
	{
		return "伙伴";
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
		return $"配置{groupName}";
	}

	protected override string _GetTemplateForHeadingConfigureGroup()
	{
		return "配置{groupName}";
	}

	protected override string _GetTemplateForHeadingDate()
	{
		return "日期";
	}

	protected override string _GetTemplateForHeadingDescription()
	{
		return "描述";
	}

	protected override string _GetTemplateForHeadingEnemies()
	{
		return "敌人";
	}

	protected override string _GetTemplateForHeadingExileUserWarning()
	{
		return "警告";
	}

	protected override string _GetTemplateForHeadingFunds()
	{
		return "资金";
	}

	protected override string _GetTemplateForHeadingGames()
	{
		return "游戏";
	}

	protected override string _GetTemplateForHeadingGroupPurchase()
	{
		return "群组购买确认";
	}

	protected override string _GetTemplateForHeadingGroupShout()
	{
		return "群组广播";
	}

	protected override string _GetTemplateForHeadingLeaveGroup()
	{
		return "离开群组";
	}

	protected override string _GetTemplateForHeadingMakePrimaryGroup()
	{
		return "设为主要群组";
	}

	protected override string _GetTemplateForHeadingMembers()
	{
		return "成员";
	}

	protected override string _GetTemplateForHeadingNameOrDescription()
	{
		return "名称或描述";
	}

	protected override string _GetTemplateForHeadingPayouts()
	{
		return "支出";
	}

	protected override string _GetTemplateForHeadingPrimary()
	{
		return "主要";
	}

	protected override string _GetTemplateForHeadingRank()
	{
		return "等级";
	}

	protected override string _GetTemplateForHeadingRemovePrimaryGroup()
	{
		return "移除主要群组";
	}

	protected override string _GetTemplateForHeadingRole()
	{
		return "角色";
	}

	protected override string _GetTemplateForHeadingSettings()
	{
		return "设置";
	}

	protected override string _GetTemplateForHeadingShout()
	{
		return "广播";
	}

	protected override string _GetTemplateForHeadingStore()
	{
		return "商店";
	}

	protected override string _GetTemplateForHeadingUser()
	{
		return "用户";
	}

	protected override string _GetTemplateForHeadingWall()
	{
		return "留言板";
	}

	protected override string _GetTemplateForLabelAbandon()
	{
		return "舍弃";
	}

	protected override string _GetTemplateForLabelAcceptAllyRequest()
	{
		return "接受盟友邀请";
	}

	protected override string _GetTemplateForLabelAcceptJoinRequest()
	{
		return "接受加入邀请";
	}

	protected override string _GetTemplateForLabelAddGroupPlace()
	{
		return "添加群组空间";
	}

	protected override string _GetTemplateForLabelAdjustCurrencyAmounts()
	{
		return "调整货币金额";
	}

	protected override string _GetTemplateForLabelAll()
	{
		return "全部";
	}

	protected override string _GetTemplateForLabelAnyoneCanJoin()
	{
		return "任何人都可以加入";
	}

	protected override string _GetTemplateForLabelBuyAd()
	{
		return "购买广告";
	}

	protected override string _GetTemplateForLabelBuyClan()
	{
		return "购买公会";
	}

	protected override string _GetTemplateForLabelByOwner()
	{
		return "创建者";
	}

	protected override string _GetTemplateForLabelCancelClanInvite()
	{
		return "取消公会邀请";
	}

	protected override string _GetTemplateForLabelChangeDescription()
	{
		return "更改描述";
	}

	protected override string _GetTemplateForLabelChangeOwner()
	{
		return "变更群主";
	}

	protected override string _GetTemplateForLabelChangeRank()
	{
		return "更改等级";
	}

	protected override string _GetTemplateForLabelClaim()
	{
		return "获取";
	}

	protected override string _GetTemplateForLabelConfigureBadge()
	{
		return "设置徽章";
	}

	protected override string _GetTemplateForLabelConfigureGroupAsset()
	{
		return "设置群组素材";
	}

	protected override string _GetTemplateForLabelConfigureGroupDevelopmentItem()
	{
		return "设置群组开发道具";
	}

	protected override string _GetTemplateForLabelConfigureGroupGame()
	{
		return "设置群组名称";
	}

	protected override string _GetTemplateForLabelConfigureItems()
	{
		return "设置道具";
	}

	protected override string _GetTemplateForLabelCreateBadge()
	{
		return "创建徽章";
	}

	protected override string _GetTemplateForLabelCreateEnemy()
	{
		return "设定敌人";
	}

	protected override string _GetTemplateForLabelCreateGamePass()
	{
		return "创建游戏通行证";
	}

	protected override string _GetTemplateForLabelCreateGroup()
	{
		return "创建群组";
	}

	protected override string _GetTemplateForLabelCreateGroupAsset()
	{
		return "创建群组素材";
	}

	protected override string _GetTemplateForLabelCreateGroupBuildersClubTooltip()
	{
		return "需要拥有 Builders Club 会员资格才能创建群组。";
	}

	protected override string _GetTemplateForLabelCreateGroupDescription()
	{
		return "描述（可省略）";
	}

	protected override string _GetTemplateForLabelCreateGroupDeveloperProduct()
	{
		return "创建群组开发者产品";
	}

	protected override string _GetTemplateForLabelCreateGroupEmblem()
	{
		return "标志";
	}

	protected override string _GetTemplateForLabelCreateGroupFee()
	{
		return "创建群组费用";
	}

	protected override string _GetTemplateForLabelCreateGroupName()
	{
		return "命名你的群组";
	}

	protected override string _GetTemplateForLabelCreateGroupPremiumTooltip()
	{
		return "需要拥有 Roblox Premium 会员资格才能创建群组。";
	}

	protected override string _GetTemplateForLabelCreateGroupTooltip()
	{
		return "创建新群组";
	}

	protected override string _GetTemplateForLabelCreateItems()
	{
		return "创建道具";
	}

	protected override string _GetTemplateForLabelDeclineAllyRequest()
	{
		return "拒绝盟友邀请";
	}

	protected override string _GetTemplateForLabelDeclineJoinRequest()
	{
		return "拒绝加入邀请";
	}

	protected override string _GetTemplateForLabelDelete()
	{
		return "删除";
	}

	protected override string _GetTemplateForLabelDeleteAllPostsByUser()
	{
		return "同时删除此用户的所有帖子。";
	}

	protected override string _GetTemplateForLabelDeleteAlly()
	{
		return "删除盟友";
	}

	protected override string _GetTemplateForLabelDeleteEnemy()
	{
		return "删除敌人";
	}

	protected override string _GetTemplateForLabelDeleteGroupPlace()
	{
		return "删除群组空间";
	}

	protected override string _GetTemplateForLabelDeletePost()
	{
		return "删除帖子";
	}

	protected override string _GetTemplateForLabelFunds()
	{
		return "资金";
	}

	protected override string _GetTemplateForLabelGroupClosed()
	{
		return "群组已关闭";
	}

	protected override string _GetTemplateForLabelGroupLocked()
	{
		return "此群组已被锁定";
	}

	/// <summary>
	/// Key: "Label.GroupSearchResults"
	/// English String: "Group Results For {searchTerm}"
	/// </summary>
	public override string LabelGroupSearchResults(string searchTerm)
	{
		return $"搜索群组“{searchTerm}”的结果";
	}

	protected override string _GetTemplateForLabelGroupSearchResults()
	{
		return "搜索群组“{searchTerm}”的结果";
	}

	protected override string _GetTemplateForLabelInviteToClan()
	{
		return "邀请至公会";
	}

	protected override string _GetTemplateForLabelKickFromClan()
	{
		return "踢出公会";
	}

	protected override string _GetTemplateForLabelLoading()
	{
		return "正在加载...";
	}

	protected override string _GetTemplateForLabelLock()
	{
		return "锁定";
	}

	protected override string _GetTemplateForLabelManageGroupCreations()
	{
		return "创建或管理群组内容。";
	}

	protected override string _GetTemplateForLabelManualApproval()
	{
		return "手动批准";
	}

	/// <summary>
	/// Key: "Label.MaxGroupsTooltip"
	/// English String: "You may only be in a maximum of {maxGroups} groups at one time"
	/// </summary>
	public override string LabelMaxGroupsTooltip(string maxGroups)
	{
		return $"你可能只能同时加入 {maxGroups} 个群组";
	}

	protected override string _GetTemplateForLabelMaxGroupsTooltip()
	{
		return "你可能只能同时加入 {maxGroups} 个群组";
	}

	protected override string _GetTemplateForLabelMembers()
	{
		return "{memberCount, plural, =0 {# 名成员} =1 {# 名成员} other {# 名成员}}";
	}

	protected override string _GetTemplateForLabelModerateDiscussion()
	{
		return "管理对话";
	}

	protected override string _GetTemplateForLabelNoAllies()
	{
		return "此群组没有任何盟友。";
	}

	protected override string _GetTemplateForLabelNoEnemies()
	{
		return "此群组没有任何敌人。";
	}

	protected override string _GetTemplateForLabelNoGames()
	{
		return "没有与此群组相关联的游戏。";
	}

	protected override string _GetTemplateForLabelNoMembersInRole()
	{
		return "没有此角色的群组成员。";
	}

	protected override string _GetTemplateForLabelNoOne()
	{
		return "没有人！";
	}

	/// <summary>
	/// Key: "Label.NoResults"
	/// English String: "No results for \"{searchTerm}\""
	/// </summary>
	public override string LabelNoResults(string searchTerm)
	{
		return $"搜索不到关于“{searchTerm}”的结果";
	}

	protected override string _GetTemplateForLabelNoResults()
	{
		return "搜索不到关于“{searchTerm}”的结果";
	}

	protected override string _GetTemplateForLabelNoStoreItems()
	{
		return "此群组没有待售物品。";
	}

	protected override string _GetTemplateForLabelNoWallPosts()
	{
		return "还没有人发言...";
	}

	protected override string _GetTemplateForLabelOnlyBcCanJoin()
	{
		return "只有 Builders Club 会员才能加入";
	}

	protected override string _GetTemplateForLabelOnlyPremiumCanJoin()
	{
		return "仅限会员";
	}

	protected override string _GetTemplateForLabelPrivateGroup()
	{
		return "私人";
	}

	protected override string _GetTemplateForLabelPublicGroup()
	{
		return "公开";
	}

	protected override string _GetTemplateForLabelPublishPlace()
	{
		return "发布空间";
	}

	protected override string _GetTemplateForLabelRemoveGroupPlace()
	{
		return "移除群组空间";
	}

	protected override string _GetTemplateForLabelRemoveMember()
	{
		return "移除成员";
	}

	protected override string _GetTemplateForLabelRename()
	{
		return "重命名";
	}

	protected override string _GetTemplateForLabelRevertGroupAsset()
	{
		return "还原群组素材";
	}

	protected override string _GetTemplateForLabelSavePlace()
	{
		return "保存空间";
	}

	protected override string _GetTemplateForLabelSearchGroups()
	{
		return "搜索全部群组";
	}

	protected override string _GetTemplateForLabelSearchUsers()
	{
		return "搜索用户";
	}

	protected override string _GetTemplateForLabelSendAllyRequest()
	{
		return "发送盟友邀请";
	}

	protected override string _GetTemplateForLabelShoutPlaceholder()
	{
		return "输入你的广播内容";
	}

	protected override string _GetTemplateForLabelSpendGroupFunds()
	{
		return "使用群组资金";
	}

	protected override string _GetTemplateForLabelSuccess()
	{
		return "成功";
	}

	protected override string _GetTemplateForLabelUnlock()
	{
		return "解锁";
	}

	protected override string _GetTemplateForLabelUpdateGroupAsset()
	{
		return "更新群组素材";
	}

	protected override string _GetTemplateForLabelWallPostPlaceholder()
	{
		return "说点什么...";
	}

	protected override string _GetTemplateForLabelWallPostsUnavailable()
	{
		return "留言板帖子暂时不可用，请稍后重试。";
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
		return $"“{actor}”（群主）已舍弃群组";
	}

	protected override string _GetTemplateForMessageAbandon()
	{
		return "“{actor}”（群主）已舍弃群组";
	}

	/// <summary>
	/// Key: "Message.AcceptAllyRequest"
	/// English String: "{actor} accepted group {group}'s ally request"
	/// </summary>
	public override string MessageAcceptAllyRequest(string actor, string group)
	{
		return $"“{actor}”已接受群组“{group}”的盟友邀请";
	}

	protected override string _GetTemplateForMessageAcceptAllyRequest()
	{
		return "“{actor}”已接受群组“{group}”的盟友邀请";
	}

	/// <summary>
	/// Key: "Message.AcceptJoinRequest"
	/// English String: "{actor} accepted user {user}'s join request"
	/// </summary>
	public override string MessageAcceptJoinRequest(string actor, string user)
	{
		return $"“{actor}”已接受了用户“{user}”的加入请求";
	}

	protected override string _GetTemplateForMessageAcceptJoinRequest()
	{
		return "“{actor}”已接受了用户“{user}”的加入请求";
	}

	/// <summary>
	/// Key: "Message.AddGroupPlace"
	/// English String: "{actor} added game {game} as a group game"
	/// </summary>
	public override string MessageAddGroupPlace(string actor, string game)
	{
		return $"“{actor}”已添加游戏“{game}”为群组游戏";
	}

	protected override string _GetTemplateForMessageAddGroupPlace()
	{
		return "“{actor}”已添加游戏“{game}”为群组游戏";
	}

	/// <summary>
	/// Key: "Message.AdjustCurrencyAmountsDecreased"
	/// English String: "{actor} decreased group funds by {amount}"
	/// </summary>
	public override string MessageAdjustCurrencyAmountsDecreased(string actor, string amount)
	{
		return $"“{actor}”已将群组资金减少 {amount}";
	}

	protected override string _GetTemplateForMessageAdjustCurrencyAmountsDecreased()
	{
		return "“{actor}”已将群组资金减少 {amount}";
	}

	/// <summary>
	/// Key: "Message.AdjustCurrencyAmountsIncreased"
	/// English String: "{actor} increased group funds by {amount}"
	/// </summary>
	public override string MessageAdjustCurrencyAmountsIncreased(string actor, string amount)
	{
		return $"“{actor}”已将群组资金增加 {amount}";
	}

	protected override string _GetTemplateForMessageAdjustCurrencyAmountsIncreased()
	{
		return "“{actor}”已将群组资金增加 {amount}";
	}

	protected override string _GetTemplateForMessageAlreadyMember()
	{
		return "你已加入此群组。";
	}

	protected override string _GetTemplateForMessageAlreadyRequested()
	{
		return "你已请求加入此群组。";
	}

	protected override string _GetTemplateForMessageBuildGroupRolesListError()
	{
		return "无法加载所选角色的成员。";
	}

	/// <summary>
	/// Key: "Message.BuyAd"
	/// English String: "{actor} bid {bid} on group ad {adName}"
	/// </summary>
	public override string MessageBuyAd(string actor, string bid, string adName)
	{
		return $"“{actor}”已在群组广告“{adName}”竞拍 {bid}";
	}

	protected override string _GetTemplateForMessageBuyAd()
	{
		return "“{actor}”已在群组广告“{adName}”竞拍 {bid}";
	}

	/// <summary>
	/// Key: "Message.BuyClan"
	/// English String: "{actor} bought a group clan"
	/// </summary>
	public override string MessageBuyClan(string actor)
	{
		return $"“{actor}”已购买群组公会";
	}

	protected override string _GetTemplateForMessageBuyClan()
	{
		return "“{actor}”已购买群组公会";
	}

	/// <summary>
	/// Key: "Message.CancelClanInvite"
	/// English String: "{actor} cancelled {user}'s clan invite"
	/// </summary>
	public override string MessageCancelClanInvite(string actor, string user)
	{
		return $"“{actor}”已取消“{user}”的公会邀请";
	}

	protected override string _GetTemplateForMessageCancelClanInvite()
	{
		return "“{actor}”已取消“{user}”的公会邀请";
	}

	protected override string _GetTemplateForMessageCannotClaimGroupWithOwner()
	{
		return "此群组已有群主。";
	}

	/// <summary>
	/// Key: "Message.ChangeDescription"
	/// English String: "{actor} changed the description to \"{newDescription}\""
	/// </summary>
	public override string MessageChangeDescription(string actor, string newDescription)
	{
		return $"“{actor}”已将描述改为“{newDescription}”";
	}

	protected override string _GetTemplateForMessageChangeDescription()
	{
		return "“{actor}”已将描述改为“{newDescription}”";
	}

	/// <summary>
	/// Key: "Message.ChangeOwner"
	/// English String: "{actor} changed the group owner. {user} is the new group owner"
	/// </summary>
	public override string MessageChangeOwner(string actor, string user)
	{
		return $"“{actor}”已更改群主。新的群主为“{user}”";
	}

	protected override string _GetTemplateForMessageChangeOwner()
	{
		return "“{actor}”已更改群主。新的群主为“{user}”";
	}

	protected override string _GetTemplateForMessageChangeOwnerEmpty()
	{
		return "群组没有群主";
	}

	/// <summary>
	/// Key: "Message.ChangeRank"
	/// English String: "{actor} changed user {user}'s rank from {oldRoleSet} to {newRoleSet}"
	/// </summary>
	public override string MessageChangeRank(string actor, string user, string oldRoleSet, string newRoleSet)
	{
		return $"“{actor}”已将用户“{user}”的等级从{oldRoleSet}更改为{newRoleSet}";
	}

	protected override string _GetTemplateForMessageChangeRank()
	{
		return "“{actor}”已将用户“{user}”的等级从{oldRoleSet}更改为{newRoleSet}";
	}

	/// <summary>
	/// Key: "Message.Claim"
	/// English String: "{actor} claimed ownership of the group"
	/// </summary>
	public override string MessageClaim(string actor)
	{
		return $"“{actor}”已成为群主";
	}

	protected override string _GetTemplateForMessageClaim()
	{
		return "“{actor}”已成为群主";
	}

	protected override string _GetTemplateForMessageClaimOwnershipError()
	{
		return "无法成为群主。";
	}

	protected override string _GetTemplateForMessageClaimOwnershipSuccess()
	{
		return "成功成为群主。";
	}

	/// <summary>
	/// Key: "Message.ConfigureAsset"
	/// English String: "{actor} updated asset {item}: {actions}"
	/// </summary>
	public override string MessageConfigureAsset(string actor, string item, string actions)
	{
		return $"“{actor}”已更新素材“{item}”：{actions}\n";
	}

	protected override string _GetTemplateForMessageConfigureAsset()
	{
		return "“{actor}”已更新素材“{item}”：{actions}\n";
	}

	/// <summary>
	/// Key: "Message.ConfigureBadgeDisabled"
	/// English String: "{actor} disabled the badge {badge}"
	/// </summary>
	public override string MessageConfigureBadgeDisabled(string actor, string badge)
	{
		return $"“{actor}”已停用徽章“{badge}”";
	}

	protected override string _GetTemplateForMessageConfigureBadgeDisabled()
	{
		return "“{actor}”已停用徽章“{badge}”";
	}

	/// <summary>
	/// Key: "Message.ConfigureBadgeEnabled"
	/// English String: "{actor} enabled the badge {badge}"
	/// </summary>
	public override string MessageConfigureBadgeEnabled(string actor, string badge)
	{
		return $"“{actor}”已启用徽章“{badge}”";
	}

	protected override string _GetTemplateForMessageConfigureBadgeEnabled()
	{
		return "“{actor}”已启用徽章“{badge}”";
	}

	/// <summary>
	/// Key: "Message.ConfigureBadgeUpdate"
	/// English String: "{actor} configured the badge {badge}"
	/// </summary>
	public override string MessageConfigureBadgeUpdate(string actor, string badge)
	{
		return $"“{actor}”已设置徽章“{badge}”";
	}

	protected override string _GetTemplateForMessageConfigureBadgeUpdate()
	{
		return "“{actor}”已设置徽章“{badge}”";
	}

	/// <summary>
	/// Key: "Message.ConfigureGame"
	/// English String: "{actor} updated {game}: {actions}"
	/// </summary>
	public override string MessageConfigureGame(string actor, string game, string actions)
	{
		return $"“{actor}”已更新素材“{game}”：{actions}\n";
	}

	protected override string _GetTemplateForMessageConfigureGame()
	{
		return "“{actor}”已更新素材“{game}”：{actions}\n";
	}

	/// <summary>
	/// Key: "Message.ConfigureGameDeveloperProduct"
	/// English String: "{actor} updated developer product {id}: {actions}"
	/// </summary>
	public override string MessageConfigureGameDeveloperProduct(string actor, string id, string actions)
	{
		return $"“{actor}”已更新 ID 为 {id} 的开发者产品：{actions}\n";
	}

	protected override string _GetTemplateForMessageConfigureGameDeveloperProduct()
	{
		return "“{actor}”已更新 ID 为 {id} 的开发者产品：{actions}\n";
	}

	/// <summary>
	/// Key: "Message.ConfigureItems"
	/// English String: "{actor} configured the group item {item}"
	/// </summary>
	public override string MessageConfigureItems(string actor, string item)
	{
		return $"“{actor}”已设置群组道具“{item}”";
	}

	protected override string _GetTemplateForMessageConfigureItems()
	{
		return "“{actor}”已设置群组道具“{item}”";
	}

	/// <summary>
	/// Key: "Message.CreateAsset"
	/// English String: "{actor} created asset {item}"
	/// </summary>
	public override string MessageCreateAsset(string actor, string item)
	{
		return $"“{actor}”已创建素材“{item}”";
	}

	protected override string _GetTemplateForMessageCreateAsset()
	{
		return "“{actor}”已创建素材“{item}”";
	}

	/// <summary>
	/// Key: "Message.CreateBadge"
	/// English String: "{actor} created the badge {badge}"
	/// </summary>
	public override string MessageCreateBadge(string actor, string badge)
	{
		return $"“{actor}”已建立徽章“{badge}”";
	}

	protected override string _GetTemplateForMessageCreateBadge()
	{
		return "“{actor}”已建立徽章“{badge}”";
	}

	/// <summary>
	/// Key: "Message.CreateDeveloperProduct"
	/// English String: "{actor} created developer product with id {id}"
	/// </summary>
	public override string MessageCreateDeveloperProduct(string actor, string id)
	{
		return $"“{actor}”已创建开发者产品，ID 为 {id}";
	}

	protected override string _GetTemplateForMessageCreateDeveloperProduct()
	{
		return "“{actor}”已创建开发者产品，ID 为 {id}";
	}

	/// <summary>
	/// Key: "Message.CreateEnemy"
	/// English String: "{actor} declared group {group} as an enemy"
	/// </summary>
	public override string MessageCreateEnemy(string actor, string group)
	{
		return $"“{actor}”已宣布“{group}”为敌人";
	}

	protected override string _GetTemplateForMessageCreateEnemy()
	{
		return "“{actor}”已宣布“{group}”为敌人";
	}

	/// <summary>
	/// Key: "Message.CreateGamePass"
	/// English String: "{actor} created a Game Pass for {game}: {gamePass}"
	/// </summary>
	public override string MessageCreateGamePass(string actor, string game, string gamePass)
	{
		return $"“{actor}”已为“{game}”创建游戏通行证：{gamePass}";
	}

	protected override string _GetTemplateForMessageCreateGamePass()
	{
		return "“{actor}”已为“{game}”创建游戏通行证：{gamePass}";
	}

	/// <summary>
	/// Key: "Message.CreateItems"
	/// English String: "{actor} created the group item {item}"
	/// </summary>
	public override string MessageCreateItems(string actor, string item)
	{
		return $"“{actor}”已创建群组物品“{item}”";
	}

	protected override string _GetTemplateForMessageCreateItems()
	{
		return "“{actor}”已创建群组物品“{item}”";
	}

	/// <summary>
	/// Key: "Message.DeclineAllyRequest"
	/// English String: "{actor} declined group {group}'s ally request"
	/// </summary>
	public override string MessageDeclineAllyRequest(string actor, string group)
	{
		return $"“{actor}”已拒绝群组“{group}”的盟友邀请";
	}

	protected override string _GetTemplateForMessageDeclineAllyRequest()
	{
		return "“{actor}”已拒绝群组“{group}”的盟友邀请";
	}

	/// <summary>
	/// Key: "Message.DeclineJoinRequest"
	/// English String: "{actor} declined user {user}'s join request"
	/// </summary>
	public override string MessageDeclineJoinRequest(string actor, string user)
	{
		return $"“{actor}”已拒绝用户“{user}”的加入请求";
	}

	protected override string _GetTemplateForMessageDeclineJoinRequest()
	{
		return "“{actor}”已拒绝用户“{user}”的加入请求";
	}

	protected override string _GetTemplateForMessageDefaultError()
	{
		return "发生错误。";
	}

	/// <summary>
	/// Key: "Message.Delete"
	/// English String: "{actor} deleted current group"
	/// </summary>
	public override string MessageDelete(string actor)
	{
		return $"“{actor}”已删除当前群组";
	}

	protected override string _GetTemplateForMessageDelete()
	{
		return "“{actor}”已删除当前群组";
	}

	/// <summary>
	/// Key: "Message.DeleteAlly"
	/// English String: "{actor} removed group {group} as an ally"
	/// </summary>
	public override string MessageDeleteAlly(string actor, string group)
	{
		return $"“{actor}”已将群组“{group}”从盟友移除";
	}

	protected override string _GetTemplateForMessageDeleteAlly()
	{
		return "“{actor}”已将群组“{group}”从盟友移除";
	}

	/// <summary>
	/// Key: "Message.DeleteEnemy"
	/// English String: "{actor} removed group {group} as an enemy"
	/// </summary>
	public override string MessageDeleteEnemy(string actor, string group)
	{
		return $"“{actor}”已将群组“{group}”从敌人移除";
	}

	protected override string _GetTemplateForMessageDeleteEnemy()
	{
		return "“{actor}”已将群组“{group}”从敌人移除";
	}

	/// <summary>
	/// Key: "Message.DeleteGroupPlace"
	/// English String: "{actor} removed game {game} as a group game"
	/// </summary>
	public override string MessageDeleteGroupPlace(string actor, string game)
	{
		return $"“{actor}”已移除群组游戏“{game}”";
	}

	protected override string _GetTemplateForMessageDeleteGroupPlace()
	{
		return "“{actor}”已移除群组游戏“{game}”";
	}

	/// <summary>
	/// Key: "Message.DeletePost"
	/// English String: "{actor} deleted post \"{postDesc}\" by user {user}"
	/// </summary>
	public override string MessageDeletePost(string actor, string postDesc, string user)
	{
		return $"“{actor}”已将用户“{user}”的帖子“{postDesc}”删除";
	}

	protected override string _GetTemplateForMessageDeletePost()
	{
		return "“{actor}”已将用户“{user}”的帖子“{postDesc}”删除";
	}

	protected override string _GetTemplateForMessageDeleteWallPostError()
	{
		return "无法删除留言板帖子。";
	}

	protected override string _GetTemplateForMessageDeleteWallPostsByUserError()
	{
		return "无法删除此用户的帖子。";
	}

	protected override string _GetTemplateForMessageDeleteWallPostSuccess()
	{
		return "成功删除帖子。";
	}

	protected override string _GetTemplateForMessageDescriptionTooLong()
	{
		return "描述过长。";
	}

	protected override string _GetTemplateForMessageDuplicateName()
	{
		return "名称已被使用，请输入新的名称。";
	}

	protected override string _GetTemplateForMessageExileUserError()
	{
		return "无法驱逐用户。";
	}

	protected override string _GetTemplateForMessageFeatureDisabled()
	{
		return "此功能已停用。";
	}

	protected override string _GetTemplateForMessageGetGroupRelationshipsError()
	{
		return "无法加载群组伙伴。";
	}

	protected override string _GetTemplateForMessageGroupClosed()
	{
		return "你不能加入已关闭的群组。";
	}

	protected override string _GetTemplateForMessageGroupCreationDisabled()
	{
		return "当前无法创建群组。";
	}

	protected override string _GetTemplateForMessageGroupIconInvalid()
	{
		return "图标缺失或无效。";
	}

	/// <summary>
	/// Key: "Message.GroupIconTooLarge"
	/// English String: "Icon cannot be larger than {maxSize} mb."
	/// </summary>
	public override string MessageGroupIconTooLarge(string maxSize)
	{
		return $"图标大小不可超过 {maxSize} MB。";
	}

	protected override string _GetTemplateForMessageGroupIconTooLarge()
	{
		return "图标大小不可超过 {maxSize} MB。";
	}

	protected override string _GetTemplateForMessageGroupMembershipsUnavailableError()
	{
		return "群组会员系统当前不可用。请稍后重试。";
	}

	protected override string _GetTemplateForMessageInsufficientFunds()
	{
		return "Robux 不足。";
	}

	protected override string _GetTemplateForMessageInsufficientGroupSpace()
	{
		return "你加入的群组数量已达上限。";
	}

	protected override string _GetTemplateForMessageInsufficientMembership()
	{
		return "你的 Builders Club 会员资格不足，无法加入此群组。";
	}

	protected override string _GetTemplateForMessageInsufficientPermission()
	{
		return "权限不足，无法完成请求。";
	}

	protected override string _GetTemplateForMessageInsufficientPermissionsForRelationships()
	{
		return "你没有权限管理群组关系。";
	}

	protected override string _GetTemplateForMessageInsufficientRobux()
	{
		return "你的 Robux 不足，无法创建群组。";
	}

	protected override string _GetTemplateForMessageInvalidAmount()
	{
		return "金额无效。";
	}

	protected override string _GetTemplateForMessageInvalidGroup()
	{
		return "群组无效或不存在。";
	}

	protected override string _GetTemplateForMessageInvalidGroupIcon()
	{
		return "群组图标无效。";
	}

	protected override string _GetTemplateForMessageInvalidGroupId()
	{
		return "群组无效或不存在。";
	}

	protected override string _GetTemplateForMessageInvalidGroupWallPostId()
	{
		return "群组页面帖子 ID 无效或不存在。";
	}

	protected override string _GetTemplateForMessageInvalidIds()
	{
		return "无法从请求取出 ID。";
	}

	protected override string _GetTemplateForMessageInvalidIdsError()
	{
		return "无法从请求取出 ID。";
	}

	protected override string _GetTemplateForMessageInvalidMembership()
	{
		return "用户必须是 Builders Club 会员。";
	}

	protected override string _GetTemplateForMessageInvalidName()
	{
		return "名称无效。";
	}

	protected override string _GetTemplateForMessageInvalidPaginationParameters()
	{
		return "分页参数无效或不存在。";
	}

	protected override string _GetTemplateForMessageInvalidPayoutType()
	{
		return "支付类型无效。";
	}

	protected override string _GetTemplateForMessageInvalidRecipient()
	{
		return "收件人无效。";
	}

	protected override string _GetTemplateForMessageInvalidRelationshipType()
	{
		return "群组关系类型无效。";
	}

	protected override string _GetTemplateForMessageInvalidRoleSetId()
	{
		return "等级无效或不存在。";
	}

	protected override string _GetTemplateForMessageInvalidUser()
	{
		return "用户无效或不存在。";
	}

	protected override string _GetTemplateForMessageInvalidWallPostContent()
	{
		return "你的帖子可能为空白、包含空格，或超过 500 个字符。";
	}

	/// <summary>
	/// Key: "Message.InviteToClan"
	/// English String: "{actor} invited user {user} to the clan"
	/// </summary>
	public override string MessageInviteToClan(string actor, string user)
	{
		return $"“{actor}”已邀请用户“{user}”至工会";
	}

	protected override string _GetTemplateForMessageInviteToClan()
	{
		return "“{actor}”已邀请用户“{user}”至工会";
	}

	protected override string _GetTemplateForMessageJoinGroupError()
	{
		return "无法加入群组。";
	}

	protected override string _GetTemplateForMessageJoinGroupPendingSuccess()
	{
		return "加入群组请求已发送，请等待审核。";
	}

	protected override string _GetTemplateForMessageJoinGroupSuccess()
	{
		return "成功加入群组。";
	}

	/// <summary>
	/// Key: "Message.KickFromClan"
	/// English String: "{actor} kicked user {user} out of the clan"
	/// </summary>
	public override string MessageKickFromClan(string actor, string user)
	{
		return $"“{actor}”已将用户“{user}”踢出公会";
	}

	protected override string _GetTemplateForMessageKickFromClan()
	{
		return "“{actor}”已将用户“{user}”踢出公会";
	}

	protected override string _GetTemplateForMessageLeaveGroupError()
	{
		return "无法离开群组。";
	}

	protected override string _GetTemplateForMessageLoadGroupError()
	{
		return "无法加载群组。";
	}

	protected override string _GetTemplateForMessageLoadGroupGamesError()
	{
		return "无法加载游戏。";
	}

	protected override string _GetTemplateForMessageLoadGroupListError()
	{
		return "无法加载群组列表。";
	}

	protected override string _GetTemplateForMessageLoadGroupMembershipsError()
	{
		return "无法加载用户会员资格信息。";
	}

	protected override string _GetTemplateForMessageLoadGroupMetadataError()
	{
		return "无法加载群组信息。";
	}

	protected override string _GetTemplateForMessageLoadGroupStoreItemsError()
	{
		return "无法加载商店道具。";
	}

	protected override string _GetTemplateForMessageLoadUserGroupMembershipError()
	{
		return "无法加载群组成员信息。";
	}

	protected override string _GetTemplateForMessageLoadWallPostsError()
	{
		return "无法加载帖子。";
	}

	/// <summary>
	/// Key: "Message.Lock"
	/// English String: "{actor} locked the group"
	/// </summary>
	public override string MessageLock(string actor)
	{
		return $"“{actor}”已锁定群组";
	}

	protected override string _GetTemplateForMessageLock()
	{
		return "“{actor}”已锁定群组";
	}

	protected override string _GetTemplateForMessageMakePrimaryError()
	{
		return "无法设为主要群组。";
	}

	protected override string _GetTemplateForMessageMaxGroups()
	{
		return "用户加入的群组数量已达上限。";
	}

	protected override string _GetTemplateForMessageMissingGroupIcon()
	{
		return "请求中找不到群组图标。";
	}

	protected override string _GetTemplateForMessageMissingGroupStatusContent()
	{
		return "群组状态内容不存在。";
	}

	protected override string _GetTemplateForMessageNameInvalid()
	{
		return "名称缺失或包含无效字符。";
	}

	protected override string _GetTemplateForMessageNameModerated()
	{
		return "名称已被过滤。";
	}

	protected override string _GetTemplateForMessageNameTaken()
	{
		return "名称已占用。";
	}

	protected override string _GetTemplateForMessageNameTooLong()
	{
		return "名称过长。";
	}

	protected override string _GetTemplateForMessageNoPrimary()
	{
		return "该用户没有主要群组。";
	}

	protected override string _GetTemplateForMessagePassCaptchaToJoin()
	{
		return "若要加入此群组，请先通过 Captcha 验证。";
	}

	protected override string _GetTemplateForMessagePassCaptchaToPost()
	{
		return "若要在群组页面发布帖子，请先通过 Captcha 验证。";
	}

	/// <summary>
	/// Key: "Message.PostStatus"
	/// English String: "{actor} changed the group status to \"{groupStatus}\""
	/// </summary>
	public override string MessagePostStatus(string actor, string groupStatus)
	{
		return $"“{actor}”已将群组状态更改为“{groupStatus}”";
	}

	protected override string _GetTemplateForMessagePostStatus()
	{
		return "“{actor}”已将群组状态更改为“{groupStatus}”";
	}

	/// <summary>
	/// Key: "Message.RemoveMember"
	/// English String: "{actor} kicked user {user}"
	/// </summary>
	public override string MessageRemoveMember(string actor, string user)
	{
		return $"“{actor}”已将用户“{user}”踢出";
	}

	protected override string _GetTemplateForMessageRemoveMember()
	{
		return "“{actor}”已将用户“{user}”踢出";
	}

	protected override string _GetTemplateForMessageRemovePrimaryError()
	{
		return "无法移除主要群组。";
	}

	/// <summary>
	/// Key: "Message.Rename"
	/// English String: "{actor} renamed current group to {newName}"
	/// </summary>
	public override string MessageRename(string actor, string newName)
	{
		return $"“{actor}”已将当前群组名称更改为“{newName}”";
	}

	protected override string _GetTemplateForMessageRename()
	{
		return "“{actor}”已将当前群组名称更改为“{newName}”";
	}

	protected override string _GetTemplateForMessageSearchTermCharactersLimit()
	{
		return "搜索字符须为 2 到 50 个字符之间";
	}

	protected override string _GetTemplateForMessageSearchTermEmptyError()
	{
		return "搜索字符为空";
	}

	protected override string _GetTemplateForMessageSearchTermFilteredError()
	{
		return "搜索字符已被过滤";
	}

	/// <summary>
	/// Key: "Message.SendAllyRequest"
	/// English String: "{actor} sent an ally request to group {group}"
	/// </summary>
	public override string MessageSendAllyRequest(string actor, string group)
	{
		return $"“{actor}”向群组“{group}”发送了盟友邀请";
	}

	protected override string _GetTemplateForMessageSendAllyRequest()
	{
		return "“{actor}”向群组“{group}”发送了盟友邀请";
	}

	protected override string _GetTemplateForMessageSendGroupShoutError()
	{
		return "无法发送群组广播。";
	}

	protected override string _GetTemplateForMessageSendPostError()
	{
		return "无法发送帖子。";
	}

	/// <summary>
	/// Key: "Message.SpendGroupFunds"
	/// English String: "{actor} spent {amount} of group funds for: {item}"
	/// </summary>
	public override string MessageSpendGroupFunds(string actor, string amount, string item)
	{
		return $"“{actor}”已使用 {amount} 群组资金购买“{item}”";
	}

	protected override string _GetTemplateForMessageSpendGroupFunds()
	{
		return "“{actor}”已使用 {amount} 群组资金购买“{item}”";
	}

	protected override string _GetTemplateForMessageTooManyAttempts()
	{
		return "尝试加入群组的次数过多。请稍后重试。";
	}

	protected override string _GetTemplateForMessageTooManyAttemptsToClaimGroups()
	{
		return "尝试认领群组的次数过多。请稍后重试。";
	}

	protected override string _GetTemplateForMessageTooManyGroups()
	{
		return "你加入的群组已达上限。创建新群组前，请先离开一个群组。";
	}

	protected override string _GetTemplateForMessageTooManyIds()
	{
		return "请求 ID 数量过多。";
	}

	protected override string _GetTemplateForMessageTooManyPosts()
	{
		return "你的帖子发布频率过高，请稍候重试。";
	}

	protected override string _GetTemplateForMessageTooManyRequests()
	{
		return "请求过多。";
	}

	protected override string _GetTemplateForMessageUnauthorizedForPostStatus()
	{
		return "你没有权限来限定此群组的状态。";
	}

	protected override string _GetTemplateForMessageUnauthorizedForViewGroupPayouts()
	{
		return "你没有权限查看此群组的支付。";
	}

	protected override string _GetTemplateForMessageUnauthorizedToClaimGroup()
	{
		return "你没有权限认领此群组。";
	}

	protected override string _GetTemplateForMessageUnauthorizedToManageMember()
	{
		return "你没有管理此成员的权限。";
	}

	protected override string _GetTemplateForMessageUnauthorizedToViewRolesetPermissions()
	{
		return "你没有权限查看此等级的权限。";
	}

	protected override string _GetTemplateForMessageUnauthorizedToViewWall()
	{
		return "你没有访问此群组页面的权限。";
	}

	protected override string _GetTemplateForMessageUnknownError()
	{
		return "未知错误";
	}

	/// <summary>
	/// Key: "Message.Unlock"
	/// English String: "{actor} unlocked the group"
	/// </summary>
	public override string MessageUnlock(string actor)
	{
		return $"“{actor}”已解锁群组";
	}

	protected override string _GetTemplateForMessageUnlock()
	{
		return "“{actor}”已解锁群组";
	}

	/// <summary>
	/// Key: "Message.UpdateAsset"
	/// English String: "{actor} created new version {version} of asset {item}"
	/// </summary>
	public override string MessageUpdateAsset(string actor, string version, string item)
	{
		return $"“{actor}”已创建素材“{item}”的新版本 {version}";
	}

	protected override string _GetTemplateForMessageUpdateAsset()
	{
		return "“{actor}”已创建素材“{item}”的新版本 {version}";
	}

	/// <summary>
	/// Key: "Message.UpdateAssetRevert"
	/// English String: "{actor} reverted asset {item} from version {version} to {oldVersion}"
	/// </summary>
	public override string MessageUpdateAssetRevert(string actor, string item, string version, string oldVersion)
	{
		return $"“{actor}”已将素材“{item}”的版本从 {version} 还原为 {oldVersion}";
	}

	protected override string _GetTemplateForMessageUpdateAssetRevert()
	{
		return "“{actor}”已将素材“{item}”的版本从 {version} 还原为 {oldVersion}";
	}

	protected override string _GetTemplateForMessageUserNotInGroup()
	{
		return "你不是指定群组的成员。";
	}
}
