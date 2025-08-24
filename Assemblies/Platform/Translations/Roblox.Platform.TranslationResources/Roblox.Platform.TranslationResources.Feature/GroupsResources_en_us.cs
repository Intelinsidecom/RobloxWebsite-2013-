using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Feature;

internal class GroupsResources_en_us : TranslationResourcesBase, IGroupsResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "Action.AdvertiseGroup"
	/// English String: "Advertise Group"
	/// </summary>
	public virtual string ActionAdvertiseGroup => "Advertise Group";

	/// <summary>
	/// Key: "Action.AuditLog"
	/// English String: "Audit Log"
	/// </summary>
	public virtual string ActionAuditLog => "Audit Log";

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public virtual string ActionCancel => "Cancel";

	/// <summary>
	/// Key: "Action.CancelRequest"
	/// English String: "Cancel Request"
	/// </summary>
	public virtual string ActionCancelRequest => "Cancel Request";

	/// <summary>
	/// Key: "Action.ClaimOwnership"
	/// English String: "Claim Ownership"
	/// </summary>
	public virtual string ActionClaimOwnership => "Claim Ownership";

	/// <summary>
	/// Key: "Action.Close"
	/// English String: "Close"
	/// </summary>
	public virtual string ActionClose => "Close";

	/// <summary>
	/// Key: "Action.ConfigureGroup"
	/// English String: "Configure Group"
	/// </summary>
	public virtual string ActionConfigureGroup => "Configure Group";

	/// <summary>
	/// Key: "Action.CreateGroup"
	/// English String: "Create Group"
	/// </summary>
	public virtual string ActionCreateGroup => "Create Group";

	/// <summary>
	/// Key: "Action.Delete"
	/// English String: "Delete"
	/// </summary>
	public virtual string ActionDelete => "Delete";

	/// <summary>
	/// Key: "Action.Exile"
	/// English String: "Exile"
	/// </summary>
	public virtual string ActionExile => "Exile";

	/// <summary>
	/// Key: "Action.ExileUser"
	/// English String: "Exile User"
	/// </summary>
	public virtual string ActionExileUser => "Exile User";

	/// <summary>
	/// Key: "Action.GroupAdmin"
	/// English String: "Group Admin"
	/// </summary>
	public virtual string ActionGroupAdmin => "Group Admin";

	/// <summary>
	/// Key: "Action.GroupShout"
	/// Text on the button for sending / posting a group shout
	/// English String: "Group Shout"
	/// </summary>
	public virtual string ActionGroupShout => "Group Shout";

	/// <summary>
	/// Key: "Action.JoinGroup"
	/// English String: "Join Group"
	/// </summary>
	public virtual string ActionJoinGroup => "Join Group";

	/// <summary>
	/// Key: "Action.LeaveGroup"
	/// English String: "Leave Group"
	/// </summary>
	public virtual string ActionLeaveGroup => "Leave Group";

	/// <summary>
	/// Key: "Action.MakePrimary"
	/// English String: "Make Primary"
	/// </summary>
	public virtual string ActionMakePrimary => "Make Primary";

	/// <summary>
	/// Key: "Action.MakePrimaryGroup"
	/// Set the current group as the users primary group
	/// English String: "Make Primary Group"
	/// </summary>
	public virtual string ActionMakePrimaryGroup => "Make Primary Group";

	/// <summary>
	/// Key: "Action.Post"
	/// English String: "Post"
	/// </summary>
	public virtual string ActionPost => "Post";

	/// <summary>
	/// Key: "Action.Purchase"
	/// English String: "Purchase"
	/// </summary>
	public virtual string ActionPurchase => "Purchase";

	/// <summary>
	/// Key: "Action.RemovePrimary"
	/// English String: "Remove Primary"
	/// </summary>
	public virtual string ActionRemovePrimary => "Remove Primary";

	/// <summary>
	/// Key: "Action.Report"
	/// English String: "Report"
	/// </summary>
	public virtual string ActionReport => "Report";

	/// <summary>
	/// Key: "Action.ReportAbuse"
	/// English String: "Report Abuse"
	/// </summary>
	public virtual string ActionReportAbuse => "Report Abuse";

	/// <summary>
	/// Key: "Action.Upgrade"
	/// English String: "Upgrade"
	/// </summary>
	public virtual string ActionUpgrade => "Upgrade";

	/// <summary>
	/// Key: "Action.UpgradeToJoin"
	/// English String: "Upgrade to Join"
	/// </summary>
	public virtual string ActionUpgradeToJoin => "Upgrade to Join";

	/// <summary>
	/// Key: "Action.Yes"
	/// English String: "Yes"
	/// </summary>
	public virtual string ActionYes => "Yes";

	/// <summary>
	/// Key: "Description.ClothingRevenue"
	/// English String: "Groups have the ability to create and sell official shirts, pants, and t-shirts! All revenue goes to group funds."
	/// </summary>
	public virtual string DescriptionClothingRevenue => "Groups have the ability to create and sell official shirts, pants, and t-shirts! All revenue goes to group funds.";

	/// <summary>
	/// Key: "Description.DeleteAllPostsByUser"
	/// English String: "Also delete all posts by this user."
	/// </summary>
	public virtual string DescriptionDeleteAllPostsByUser => "Also delete all posts by this user.";

	/// <summary>
	/// Key: "Description.ExileUserWarning"
	/// English String: "Are you sure you want to exile this user?"
	/// </summary>
	public virtual string DescriptionExileUserWarning => "Are you sure you want to exile this user?";

	/// <summary>
	/// Key: "Description.LeaveGroupAsOwnerWarning"
	/// English String: "This will leave the group ownerless."
	/// </summary>
	public virtual string DescriptionLeaveGroupAsOwnerWarning => "This will leave the group ownerless.";

	/// <summary>
	/// Key: "Description.LeaveGroupWarning"
	/// English String: "Are you sure you want to leave this group?"
	/// </summary>
	public virtual string DescriptionLeaveGroupWarning => "Are you sure you want to leave this group?";

	/// <summary>
	/// Key: "Description.MakePrimaryGroupWarning"
	/// English String: "Are you sure you want to make this your primary group?"
	/// </summary>
	public virtual string DescriptionMakePrimaryGroupWarning => "Are you sure you want to make this your primary group?";

	/// <summary>
	/// Key: "Description.NoneMaxGroups"
	/// English String: "Upgrade to Builders Club to join more groups."
	/// </summary>
	public virtual string DescriptionNoneMaxGroups => "Upgrade to Builders Club to join more groups.";

	/// <summary>
	/// Key: "Description.NoneMaxGroupsPremium"
	/// English String: "Upgrade to Roblox Premium to join more groups."
	/// </summary>
	public virtual string DescriptionNoneMaxGroupsPremium => "Upgrade to Roblox Premium to join more groups.";

	/// <summary>
	/// Key: "Description.noneMaxGroupsPremiumText"
	/// English String: "Upgrade to Roblox Premium to join more groups."
	/// </summary>
	public virtual string DescriptionnoneMaxGroupsPremiumText => "Upgrade to Roblox Premium to join more groups.";

	/// <summary>
	/// Key: "Description.ObcMaxGroups"
	/// English String: "You have joined the maximum number of groups."
	/// </summary>
	public virtual string DescriptionObcMaxGroups => "You have joined the maximum number of groups.";

	/// <summary>
	/// Key: "Description.OtherBcMaxGroups"
	/// English String: "Upgrade your Builders Club to join more groups."
	/// </summary>
	public virtual string DescriptionOtherBcMaxGroups => "Upgrade your Builders Club to join more groups.";

	/// <summary>
	/// Key: "Description.otherPremiumMaxGroupsText"
	/// English String: "Upgrade your Roblox Premium to join more groups."
	/// </summary>
	public virtual string DescriptionotherPremiumMaxGroupsText => "Upgrade your Roblox Premium to join more groups.";

	/// <summary>
	/// Key: "Description.PremiumMaxGroups"
	/// English String: "You have joined the maximum number of groups."
	/// </summary>
	public virtual string DescriptionPremiumMaxGroups => "You have joined the maximum number of groups.";

	/// <summary>
	/// Key: "Description.PurchaseBody"
	/// English String: "Would you like to create this group for"
	/// </summary>
	public virtual string DescriptionPurchaseBody => "Would you like to create this group for";

	/// <summary>
	/// Key: "Description.RemovePrimaryGroupWarning"
	/// English String: "Are you sure you want to remove your primary group?"
	/// </summary>
	public virtual string DescriptionRemovePrimaryGroupWarning => "Are you sure you want to remove your primary group?";

	/// <summary>
	/// Key: "Description.ReportAbuseDescription"
	/// English String: "What would you like to report?"
	/// </summary>
	public virtual string DescriptionReportAbuseDescription => "What would you like to report?";

	/// <summary>
	/// Key: "Description.WallPrivacySettings"
	/// English String: "Your privacy settings do not allow you to post to group walls. Click here to adjust these settings."
	/// </summary>
	public virtual string DescriptionWallPrivacySettings => "Your privacy settings do not allow you to post to group walls. Click here to adjust these settings.";

	/// <summary>
	/// Key: "Heading.About"
	/// English String: "About"
	/// </summary>
	public virtual string HeadingAbout => "About";

	/// <summary>
	/// Key: "Heading.Affiliates"
	/// English String: "Affiliates"
	/// </summary>
	public virtual string HeadingAffiliates => "Affiliates";

	/// <summary>
	/// Key: "Heading.Allies"
	/// English String: "Allies"
	/// </summary>
	public virtual string HeadingAllies => "Allies";

	/// <summary>
	/// Key: "Heading.Date"
	/// English String: "Date"
	/// </summary>
	public virtual string HeadingDate => "Date";

	/// <summary>
	/// Key: "Heading.Description"
	/// English String: "Description"
	/// </summary>
	public virtual string HeadingDescription => "Description";

	/// <summary>
	/// Key: "Heading.Enemies"
	/// English String: "Enemies"
	/// </summary>
	public virtual string HeadingEnemies => "Enemies";

	/// <summary>
	/// Key: "Heading.ExileUserWarning"
	/// English String: "Warning"
	/// </summary>
	public virtual string HeadingExileUserWarning => "Warning";

	/// <summary>
	/// Key: "Heading.Funds"
	/// English String: "Funds"
	/// </summary>
	public virtual string HeadingFunds => "Funds";

	/// <summary>
	/// Key: "Heading.Games"
	/// English String: "Games"
	/// </summary>
	public virtual string HeadingGames => "Games";

	/// <summary>
	/// Key: "Heading.GroupPurchase"
	/// English String: "Group Purchase Confirmation"
	/// </summary>
	public virtual string HeadingGroupPurchase => "Group Purchase Confirmation";

	/// <summary>
	/// Key: "Heading.GroupShout"
	/// English String: "Group Shout"
	/// </summary>
	public virtual string HeadingGroupShout => "Group Shout";

	/// <summary>
	/// Key: "Heading.LeaveGroup"
	/// English String: "Leave Group"
	/// </summary>
	public virtual string HeadingLeaveGroup => "Leave Group";

	/// <summary>
	/// Key: "Heading.MakePrimaryGroup"
	/// Heading of make primary group modal
	/// English String: "Make Primary Group"
	/// </summary>
	public virtual string HeadingMakePrimaryGroup => "Make Primary Group";

	/// <summary>
	/// Key: "Heading.Members"
	/// English String: "Members"
	/// </summary>
	public virtual string HeadingMembers => "Members";

	/// <summary>
	/// Key: "Heading.NameOrDescription"
	/// Selection option for what to report when reporting something in a group
	/// English String: "Name or Description"
	/// </summary>
	public virtual string HeadingNameOrDescription => "Name or Description";

	/// <summary>
	/// Key: "Heading.Payouts"
	/// English String: "Payouts"
	/// </summary>
	public virtual string HeadingPayouts => "Payouts";

	/// <summary>
	/// Key: "Heading.Primary"
	/// English String: "Primary"
	/// </summary>
	public virtual string HeadingPrimary => "Primary";

	/// <summary>
	/// Key: "Heading.Rank"
	/// English String: "Rank"
	/// </summary>
	public virtual string HeadingRank => "Rank";

	/// <summary>
	/// Key: "Heading.RemovePrimaryGroup"
	/// English String: "Remove Primary Group"
	/// </summary>
	public virtual string HeadingRemovePrimaryGroup => "Remove Primary Group";

	/// <summary>
	/// Key: "Heading.Role"
	/// English String: "Role"
	/// </summary>
	public virtual string HeadingRole => "Role";

	/// <summary>
	/// Key: "Heading.Settings"
	/// English String: "Settings"
	/// </summary>
	public virtual string HeadingSettings => "Settings";

	/// <summary>
	/// Key: "Heading.Shout"
	/// To be displayed above the group shout (the current status for a group set by admins)
	/// English String: "Shout"
	/// </summary>
	public virtual string HeadingShout => "Shout";

	/// <summary>
	/// Key: "Heading.Store"
	/// English String: "Store"
	/// </summary>
	public virtual string HeadingStore => "Store";

	/// <summary>
	/// Key: "Heading.User"
	/// English String: "User"
	/// </summary>
	public virtual string HeadingUser => "User";

	/// <summary>
	/// Key: "Heading.Wall"
	/// English String: "Wall"
	/// </summary>
	public virtual string HeadingWall => "Wall";

	/// <summary>
	/// Key: "Label.Abandon"
	/// English String: "Abandon"
	/// </summary>
	public virtual string LabelAbandon => "Abandon";

	/// <summary>
	/// Key: "Label.AcceptAllyRequest"
	/// English String: "Accept Ally Request"
	/// </summary>
	public virtual string LabelAcceptAllyRequest => "Accept Ally Request";

	/// <summary>
	/// Key: "Label.AcceptJoinRequest"
	/// English String: "Accept Join Request"
	/// </summary>
	public virtual string LabelAcceptJoinRequest => "Accept Join Request";

	/// <summary>
	/// Key: "Label.AddGroupPlace"
	/// English String: "Add Group Place"
	/// </summary>
	public virtual string LabelAddGroupPlace => "Add Group Place";

	/// <summary>
	/// Key: "Label.AdjustCurrencyAmounts"
	/// English String: "Adjust Currency Amounts"
	/// </summary>
	public virtual string LabelAdjustCurrencyAmounts => "Adjust Currency Amounts";

	/// <summary>
	/// Key: "Label.All"
	/// English String: "All"
	/// </summary>
	public virtual string LabelAll => "All";

	/// <summary>
	/// Key: "Label.AnyoneCanJoin"
	/// English String: "Anyone Can Join"
	/// </summary>
	public virtual string LabelAnyoneCanJoin => "Anyone Can Join";

	/// <summary>
	/// Key: "Label.BuyAd"
	/// English String: "Buy Ad"
	/// </summary>
	public virtual string LabelBuyAd => "Buy Ad";

	/// <summary>
	/// Key: "Label.BuyClan"
	/// English String: "Buy Clan"
	/// </summary>
	public virtual string LabelBuyClan => "Buy Clan";

	/// <summary>
	/// Key: "Label.ByOwner"
	/// Prefix to either the owner of the group, or "No One!" if the group has no owner. Could not properly format like By {ownerName} because ownerName is a link in this case
	/// English String: "By"
	/// </summary>
	public virtual string LabelByOwner => "By";

	/// <summary>
	/// Key: "Label.CancelClanInvite"
	/// English String: "Cancel Clan Invite"
	/// </summary>
	public virtual string LabelCancelClanInvite => "Cancel Clan Invite";

	/// <summary>
	/// Key: "Label.ChangeDescription"
	/// English String: "Change Description"
	/// </summary>
	public virtual string LabelChangeDescription => "Change Description";

	/// <summary>
	/// Key: "Label.ChangeOwner"
	/// English String: "Change Owner"
	/// </summary>
	public virtual string LabelChangeOwner => "Change Owner";

	/// <summary>
	/// Key: "Label.ChangeRank"
	/// English String: "Change Rank"
	/// </summary>
	public virtual string LabelChangeRank => "Change Rank";

	/// <summary>
	/// Key: "Label.Claim"
	/// English String: "Claim"
	/// </summary>
	public virtual string LabelClaim => "Claim";

	/// <summary>
	/// Key: "Label.ConfigureBadge"
	/// English String: "Configure Badge"
	/// </summary>
	public virtual string LabelConfigureBadge => "Configure Badge";

	/// <summary>
	/// Key: "Label.ConfigureGroupAsset"
	/// English String: "Configure Group Asset"
	/// </summary>
	public virtual string LabelConfigureGroupAsset => "Configure Group Asset";

	/// <summary>
	/// Key: "Label.ConfigureGroupDevelopmentItem"
	/// English String: "Configure Group Development Item"
	/// </summary>
	public virtual string LabelConfigureGroupDevelopmentItem => "Configure Group Development Item";

	/// <summary>
	/// Key: "Label.ConfigureGroupGame"
	/// English String: "Configure Group Game"
	/// </summary>
	public virtual string LabelConfigureGroupGame => "Configure Group Game";

	/// <summary>
	/// Key: "Label.ConfigureItems"
	/// English String: "Configure Items"
	/// </summary>
	public virtual string LabelConfigureItems => "Configure Items";

	/// <summary>
	/// Key: "Label.CreateBadge"
	/// English String: "Create Badge"
	/// </summary>
	public virtual string LabelCreateBadge => "Create Badge";

	/// <summary>
	/// Key: "Label.CreateEnemy"
	/// English String: "Create Enemy"
	/// </summary>
	public virtual string LabelCreateEnemy => "Create Enemy";

	/// <summary>
	/// Key: "Label.CreateGamePass"
	/// English String: "Create Game Pass"
	/// </summary>
	public virtual string LabelCreateGamePass => "Create Game Pass";

	/// <summary>
	/// Key: "Label.CreateGroup"
	/// English String: "Create Group"
	/// </summary>
	public virtual string LabelCreateGroup => "Create Group";

	/// <summary>
	/// Key: "Label.CreateGroupAsset"
	/// English String: "Create Group Asset"
	/// </summary>
	public virtual string LabelCreateGroupAsset => "Create Group Asset";

	/// <summary>
	/// Key: "Label.CreateGroupBuildersClubTooltip"
	/// English String: "Creating a group requires a Builders Club membership."
	/// </summary>
	public virtual string LabelCreateGroupBuildersClubTooltip => "Creating a group requires a Builders Club membership.";

	/// <summary>
	/// Key: "Label.CreateGroupDescription"
	/// English String: "Description (optional)"
	/// </summary>
	public virtual string LabelCreateGroupDescription => "Description (optional)";

	/// <summary>
	/// Key: "Label.CreateGroupDeveloperProduct"
	/// English String: "Create Group Developer Product"
	/// </summary>
	public virtual string LabelCreateGroupDeveloperProduct => "Create Group Developer Product";

	/// <summary>
	/// Key: "Label.CreateGroupEmblem"
	/// English String: "Emblem"
	/// </summary>
	public virtual string LabelCreateGroupEmblem => "Emblem";

	/// <summary>
	/// Key: "Label.CreateGroupFee"
	/// English String: "Group Creation Fee"
	/// </summary>
	public virtual string LabelCreateGroupFee => "Group Creation Fee";

	/// <summary>
	/// Key: "Label.CreateGroupName"
	/// English String: "Name your group"
	/// </summary>
	public virtual string LabelCreateGroupName => "Name your group";

	/// <summary>
	/// Key: "Label.CreateGroupPremiumTooltip"
	/// English String: "Creating a group requires a Roblox Premium membership."
	/// </summary>
	public virtual string LabelCreateGroupPremiumTooltip => "Creating a group requires a Roblox Premium membership.";

	/// <summary>
	/// Key: "Label.CreateGroupTooltip"
	/// English String: "Create a new group"
	/// </summary>
	public virtual string LabelCreateGroupTooltip => "Create a new group";

	/// <summary>
	/// Key: "Label.CreateItems"
	/// English String: "Create Items"
	/// </summary>
	public virtual string LabelCreateItems => "Create Items";

	/// <summary>
	/// Key: "Label.DeclineAllyRequest"
	/// English String: "Decline Ally Request"
	/// </summary>
	public virtual string LabelDeclineAllyRequest => "Decline Ally Request";

	/// <summary>
	/// Key: "Label.DeclineJoinRequest"
	/// English String: "Decline Join Request"
	/// </summary>
	public virtual string LabelDeclineJoinRequest => "Decline Join Request";

	/// <summary>
	/// Key: "Label.Delete"
	/// English String: "Delete"
	/// </summary>
	public virtual string LabelDelete => "Delete";

	/// <summary>
	/// Key: "Label.DeleteAllPostsByUser"
	/// English String: "Also delete all posts by this user."
	/// </summary>
	public virtual string LabelDeleteAllPostsByUser => "Also delete all posts by this user.";

	/// <summary>
	/// Key: "Label.DeleteAlly"
	/// English String: "Delete Ally"
	/// </summary>
	public virtual string LabelDeleteAlly => "Delete Ally";

	/// <summary>
	/// Key: "Label.DeleteEnemy"
	/// English String: "Delete Enemy"
	/// </summary>
	public virtual string LabelDeleteEnemy => "Delete Enemy";

	/// <summary>
	/// Key: "Label.DeleteGroupPlace"
	/// English String: "Delete Group Place"
	/// </summary>
	public virtual string LabelDeleteGroupPlace => "Delete Group Place";

	/// <summary>
	/// Key: "Label.DeletePost"
	/// English String: "Delete Post"
	/// </summary>
	public virtual string LabelDeletePost => "Delete Post";

	/// <summary>
	/// Key: "Label.Funds"
	/// English String: "Funds"
	/// </summary>
	public virtual string LabelFunds => "Funds";

	/// <summary>
	/// Key: "Label.GroupClosed"
	/// English String: "Group Closed"
	/// </summary>
	public virtual string LabelGroupClosed => "Group Closed";

	/// <summary>
	/// Key: "Label.GroupLocked"
	/// English String: "This group has been locked"
	/// </summary>
	public virtual string LabelGroupLocked => "This group has been locked";

	/// <summary>
	/// Key: "Label.InviteToClan"
	/// English String: "Invite to Clan"
	/// </summary>
	public virtual string LabelInviteToClan => "Invite to Clan";

	/// <summary>
	/// Key: "Label.KickFromClan"
	/// English String: "Kick from Clan"
	/// </summary>
	public virtual string LabelKickFromClan => "Kick from Clan";

	/// <summary>
	/// Key: "Label.Loading"
	/// English String: "Loading..."
	/// </summary>
	public virtual string LabelLoading => "Loading...";

	/// <summary>
	/// Key: "Label.Lock"
	/// English String: "Lock"
	/// </summary>
	public virtual string LabelLock => "Lock";

	/// <summary>
	/// Key: "Label.ManageGroupCreations"
	/// English String: "Create or manage group items."
	/// </summary>
	public virtual string LabelManageGroupCreations => "Create or manage group items.";

	/// <summary>
	/// Key: "Label.ManualApproval"
	/// English String: "Manual Approval"
	/// </summary>
	public virtual string LabelManualApproval => "Manual Approval";

	/// <summary>
	/// Key: "Label.ModerateDiscussion"
	/// English String: "Moderate Discussion"
	/// </summary>
	public virtual string LabelModerateDiscussion => "Moderate Discussion";

	/// <summary>
	/// Key: "Label.NoAllies"
	/// English String: "This group does not have any allies."
	/// </summary>
	public virtual string LabelNoAllies => "This group does not have any allies.";

	/// <summary>
	/// Key: "Label.NoEnemies"
	/// English String: "This group does not have any enemies."
	/// </summary>
	public virtual string LabelNoEnemies => "This group does not have any enemies.";

	/// <summary>
	/// Key: "Label.NoGames"
	/// English String: "No games are associated with this group."
	/// </summary>
	public virtual string LabelNoGames => "No games are associated with this group.";

	/// <summary>
	/// Key: "Label.NoMembersInRole"
	/// English String: "No group members are in this role."
	/// </summary>
	public virtual string LabelNoMembersInRole => "No group members are in this role.";

	/// <summary>
	/// Key: "Label.NoOne"
	/// English String: "No One!"
	/// </summary>
	public virtual string LabelNoOne => "No One!";

	/// <summary>
	/// Key: "Label.NoStoreItems"
	/// English String: "No items are for sale in this group."
	/// </summary>
	public virtual string LabelNoStoreItems => "No items are for sale in this group.";

	/// <summary>
	/// Key: "Label.NoWallPosts"
	/// English String: "Nobody has said anything yet..."
	/// </summary>
	public virtual string LabelNoWallPosts => "Nobody has said anything yet...";

	/// <summary>
	/// Key: "Label.OnlyBcCanJoin"
	/// English String: "Only Builders Club members can join"
	/// </summary>
	public virtual string LabelOnlyBcCanJoin => "Only Builders Club members can join";

	/// <summary>
	/// Key: "Label.OnlyPremiumCanJoin"
	/// English String: "Only users with membership can join"
	/// </summary>
	public virtual string LabelOnlyPremiumCanJoin => "Only users with membership can join";

	/// <summary>
	/// Key: "Label.PrivateGroup"
	/// If group is invite only
	/// English String: "Private"
	/// </summary>
	public virtual string LabelPrivateGroup => "Private";

	/// <summary>
	/// Key: "Label.PublicGroup"
	/// If group is open for anyone to join
	/// English String: "Public"
	/// </summary>
	public virtual string LabelPublicGroup => "Public";

	/// <summary>
	/// Key: "Label.PublishPlace"
	/// English String: "Publish Place"
	/// </summary>
	public virtual string LabelPublishPlace => "Publish Place";

	/// <summary>
	/// Key: "Label.RemoveGroupPlace"
	/// English String: "Remove Group Place"
	/// </summary>
	public virtual string LabelRemoveGroupPlace => "Remove Group Place";

	/// <summary>
	/// Key: "Label.RemoveMember"
	/// English String: "Remove Member"
	/// </summary>
	public virtual string LabelRemoveMember => "Remove Member";

	/// <summary>
	/// Key: "Label.Rename"
	/// English String: "Rename"
	/// </summary>
	public virtual string LabelRename => "Rename";

	/// <summary>
	/// Key: "Label.RevertGroupAsset"
	/// English String: "Revert Group Asset"
	/// </summary>
	public virtual string LabelRevertGroupAsset => "Revert Group Asset";

	/// <summary>
	/// Key: "Label.SavePlace"
	/// English String: "Save Place"
	/// </summary>
	public virtual string LabelSavePlace => "Save Place";

	/// <summary>
	/// Key: "Label.SearchGroups"
	/// English String: "Search All Groups"
	/// </summary>
	public virtual string LabelSearchGroups => "Search All Groups";

	/// <summary>
	/// Key: "Label.SearchUsers"
	/// English String: "Search Users"
	/// </summary>
	public virtual string LabelSearchUsers => "Search Users";

	/// <summary>
	/// Key: "Label.SendAllyRequest"
	/// English String: "Send Ally Request"
	/// </summary>
	public virtual string LabelSendAllyRequest => "Send Ally Request";

	/// <summary>
	/// Key: "Label.ShoutPlaceholder"
	/// English String: "Enter your shout"
	/// </summary>
	public virtual string LabelShoutPlaceholder => "Enter your shout";

	/// <summary>
	/// Key: "Label.SpendGroupFunds"
	/// English String: "Spend Group Funds"
	/// </summary>
	public virtual string LabelSpendGroupFunds => "Spend Group Funds";

	/// <summary>
	/// Key: "Label.Success"
	/// English String: "Success"
	/// </summary>
	public virtual string LabelSuccess => "Success";

	/// <summary>
	/// Key: "Label.Unlock"
	/// English String: "Unlock"
	/// </summary>
	public virtual string LabelUnlock => "Unlock";

	/// <summary>
	/// Key: "Label.UpdateGroupAsset"
	/// English String: "Update Group Asset"
	/// </summary>
	public virtual string LabelUpdateGroupAsset => "Update Group Asset";

	/// <summary>
	/// Key: "Label.WallPostPlaceholder"
	/// English String: "Say something..."
	/// </summary>
	public virtual string LabelWallPostPlaceholder => "Say something...";

	/// <summary>
	/// Key: "Label.WallPostsUnavailable"
	/// Displayed in the group wall area when we cannot successfully load wall posts
	/// English String: "Wall posts are temporarily unavailable, please check back later."
	/// </summary>
	public virtual string LabelWallPostsUnavailable => "Wall posts are temporarily unavailable, please check back later.";

	/// <summary>
	/// Key: "Label.Warning"
	/// English String: "Warning"
	/// </summary>
	public virtual string LabelWarning => "Warning";

	/// <summary>
	/// Key: "Message.AlreadyMember"
	/// English String: "You are already a member of this group."
	/// </summary>
	public virtual string MessageAlreadyMember => "You are already a member of this group.";

	/// <summary>
	/// Key: "Message.AlreadyRequested"
	/// English String: "You have already requested to join this group."
	/// </summary>
	public virtual string MessageAlreadyRequested => "You have already requested to join this group.";

	/// <summary>
	/// Key: "Message.BuildGroupRolesListError"
	/// English String: "Unable to load members for selected role."
	/// </summary>
	public virtual string MessageBuildGroupRolesListError => "Unable to load members for selected role.";

	/// <summary>
	/// Key: "Message.CannotClaimGroupWithOwner"
	/// English String: "This group already has an owner."
	/// </summary>
	public virtual string MessageCannotClaimGroupWithOwner => "This group already has an owner.";

	/// <summary>
	/// Key: "Message.ChangeOwnerEmpty"
	/// English String: "There is no owner of the group"
	/// </summary>
	public virtual string MessageChangeOwnerEmpty => "There is no owner of the group";

	/// <summary>
	/// Key: "Message.ClaimOwnershipError"
	/// English String: "Unable to claim ownership of group."
	/// </summary>
	public virtual string MessageClaimOwnershipError => "Unable to claim ownership of group.";

	/// <summary>
	/// Key: "Message.ClaimOwnershipSuccess"
	/// English String: "Successfully claimed ownership of group."
	/// </summary>
	public virtual string MessageClaimOwnershipSuccess => "Successfully claimed ownership of group.";

	/// <summary>
	/// Key: "Message.DefaultError"
	/// English String: "An error occurred."
	/// </summary>
	public virtual string MessageDefaultError => "An error occurred.";

	/// <summary>
	/// Key: "Message.DeleteWallPostError"
	/// English String: "Unable to delete wall post."
	/// </summary>
	public virtual string MessageDeleteWallPostError => "Unable to delete wall post.";

	/// <summary>
	/// Key: "Message.DeleteWallPostsByUserError"
	/// English String: "Unable to delete wall posts by user."
	/// </summary>
	public virtual string MessageDeleteWallPostsByUserError => "Unable to delete wall posts by user.";

	/// <summary>
	/// Key: "Message.DeleteWallPostSuccess"
	/// English String: "Successfully deleted wall post."
	/// </summary>
	public virtual string MessageDeleteWallPostSuccess => "Successfully deleted wall post.";

	/// <summary>
	/// Key: "Message.DescriptionTooLong"
	/// English String: "The description is too long."
	/// </summary>
	public virtual string MessageDescriptionTooLong => "The description is too long.";

	/// <summary>
	/// Key: "Message.DuplicateName"
	/// English String: "Name is already taken. Please try another."
	/// </summary>
	public virtual string MessageDuplicateName => "Name is already taken. Please try another.";

	/// <summary>
	/// Key: "Message.ExileUserError"
	/// English String: "Unable to exile user."
	/// </summary>
	public virtual string MessageExileUserError => "Unable to exile user.";

	/// <summary>
	/// Key: "Message.FeatureDisabled"
	/// English String: "The feature is disabled."
	/// </summary>
	public virtual string MessageFeatureDisabled => "The feature is disabled.";

	/// <summary>
	/// Key: "Message.GetGroupRelationshipsError"
	/// English String: "Unable to load group affiliates."
	/// </summary>
	public virtual string MessageGetGroupRelationshipsError => "Unable to load group affiliates.";

	/// <summary>
	/// Key: "Message.GroupClosed"
	/// English String: "You cannot join a closed group."
	/// </summary>
	public virtual string MessageGroupClosed => "You cannot join a closed group.";

	/// <summary>
	/// Key: "Message.GroupCreationDisabled"
	/// English String: "Group creation is currently disabled."
	/// </summary>
	public virtual string MessageGroupCreationDisabled => "Group creation is currently disabled.";

	/// <summary>
	/// Key: "Message.GroupIconInvalid"
	/// English String: "Icon is missing or invalid."
	/// </summary>
	public virtual string MessageGroupIconInvalid => "Icon is missing or invalid.";

	/// <summary>
	/// Key: "Message.GroupMembershipsUnavailableError"
	/// Error displayed on group details view when the system is in read-only mode for maintenance and you try to perform an action.
	/// English String: "The group membership system is temporarily unavailable. Please try again later."
	/// </summary>
	public virtual string MessageGroupMembershipsUnavailableError => "The group membership system is temporarily unavailable. Please try again later.";

	/// <summary>
	/// Key: "Message.InsufficientFunds"
	/// English String: "Insufficient Robux funds."
	/// </summary>
	public virtual string MessageInsufficientFunds => "Insufficient Robux funds.";

	/// <summary>
	/// Key: "Message.InsufficientGroupSpace"
	/// English String: "You are already in the maximum number of groups."
	/// </summary>
	public virtual string MessageInsufficientGroupSpace => "You are already in the maximum number of groups.";

	/// <summary>
	/// Key: "Message.InsufficientMembership"
	/// English String: "You do not have the builders club membership necessary to join this group."
	/// </summary>
	public virtual string MessageInsufficientMembership => "You do not have the builders club membership necessary to join this group.";

	/// <summary>
	/// Key: "Message.InsufficientPermission"
	/// English String: "Insufficient permissions to complete the request."
	/// </summary>
	public virtual string MessageInsufficientPermission => "Insufficient permissions to complete the request.";

	/// <summary>
	/// Key: "Message.InsufficientPermissionsForRelationships"
	/// English String: "You don't have permission to manage this group's relationships."
	/// </summary>
	public virtual string MessageInsufficientPermissionsForRelationships => "You don't have permission to manage this group's relationships.";

	/// <summary>
	/// Key: "Message.InsufficientRobux"
	/// English String: "You do not have enough Robux to create the group."
	/// </summary>
	public virtual string MessageInsufficientRobux => "You do not have enough Robux to create the group.";

	/// <summary>
	/// Key: "Message.InvalidAmount"
	/// English String: "The amount is invalid."
	/// </summary>
	public virtual string MessageInvalidAmount => "The amount is invalid.";

	/// <summary>
	/// Key: "Message.InvalidGroup"
	/// English String: "Group is invalid or does not exist."
	/// </summary>
	public virtual string MessageInvalidGroup => "Group is invalid or does not exist.";

	/// <summary>
	/// Key: "Message.InvalidGroupIcon"
	/// English String: "The group icon is invalid."
	/// </summary>
	public virtual string MessageInvalidGroupIcon => "The group icon is invalid.";

	/// <summary>
	/// Key: "Message.InvalidGroupId"
	/// English String: "The group is invalid or does not exist."
	/// </summary>
	public virtual string MessageInvalidGroupId => "The group is invalid or does not exist.";

	/// <summary>
	/// Key: "Message.InvalidGroupWallPostId"
	/// English String: "The group wall post id is invalid or does not exist."
	/// </summary>
	public virtual string MessageInvalidGroupWallPostId => "The group wall post id is invalid or does not exist.";

	/// <summary>
	/// Key: "Message.InvalidIds"
	/// English String: "Ids could not be parsed from request."
	/// </summary>
	public virtual string MessageInvalidIds => "Ids could not be parsed from request.";

	/// <summary>
	/// Key: "Message.InvalidIdsError"
	/// English String: "Ids could not be parsed from request."
	/// </summary>
	public virtual string MessageInvalidIdsError => "Ids could not be parsed from request.";

	/// <summary>
	/// Key: "Message.InvalidMembership"
	/// English String: "User must have builders club membership."
	/// </summary>
	public virtual string MessageInvalidMembership => "User must have builders club membership.";

	/// <summary>
	/// Key: "Message.InvalidName"
	/// English String: "The name is invalid."
	/// </summary>
	public virtual string MessageInvalidName => "The name is invalid.";

	/// <summary>
	/// Key: "Message.InvalidPaginationParameters"
	/// English String: "Invalid or missing pagination parameters."
	/// </summary>
	public virtual string MessageInvalidPaginationParameters => "Invalid or missing pagination parameters.";

	/// <summary>
	/// Key: "Message.InvalidPayoutType"
	/// English String: "Invalid payout type."
	/// </summary>
	public virtual string MessageInvalidPayoutType => "Invalid payout type.";

	/// <summary>
	/// Key: "Message.InvalidRecipient"
	/// English String: "The recipient is invalid."
	/// </summary>
	public virtual string MessageInvalidRecipient => "The recipient is invalid.";

	/// <summary>
	/// Key: "Message.InvalidRelationshipType"
	/// English String: "Group relationship type is invalid."
	/// </summary>
	public virtual string MessageInvalidRelationshipType => "Group relationship type is invalid.";

	/// <summary>
	/// Key: "Message.InvalidRoleSetId"
	/// English String: "The roleset is invalid or does not exist."
	/// </summary>
	public virtual string MessageInvalidRoleSetId => "The roleset is invalid or does not exist.";

	/// <summary>
	/// Key: "Message.InvalidUser"
	/// English String: "The user is invalid or does not exist."
	/// </summary>
	public virtual string MessageInvalidUser => "The user is invalid or does not exist.";

	/// <summary>
	/// Key: "Message.InvalidWallPostContent"
	/// English String: "Your post was empty, white space, or more than 500 characters."
	/// </summary>
	public virtual string MessageInvalidWallPostContent => "Your post was empty, white space, or more than 500 characters.";

	/// <summary>
	/// Key: "Message.JoinGroupError"
	/// English String: "Unable to join group."
	/// </summary>
	public virtual string MessageJoinGroupError => "Unable to join group.";

	/// <summary>
	/// Key: "Message.JoinGroupPendingSuccess"
	/// English String: "Requested to join group, your request is pending."
	/// </summary>
	public virtual string MessageJoinGroupPendingSuccess => "Requested to join group, your request is pending.";

	/// <summary>
	/// Key: "Message.JoinGroupSuccess"
	/// English String: "Successfully joined the group."
	/// </summary>
	public virtual string MessageJoinGroupSuccess => "Successfully joined the group.";

	/// <summary>
	/// Key: "Message.LeaveGroupError"
	/// English String: "Unable to leave group."
	/// </summary>
	public virtual string MessageLeaveGroupError => "Unable to leave group.";

	/// <summary>
	/// Key: "Message.LoadGroupError"
	/// English String: "Unable to load group."
	/// </summary>
	public virtual string MessageLoadGroupError => "Unable to load group.";

	/// <summary>
	/// Key: "Message.LoadGroupGamesError"
	/// English String: "Unable to load games."
	/// </summary>
	public virtual string MessageLoadGroupGamesError => "Unable to load games.";

	/// <summary>
	/// Key: "Message.LoadGroupListError"
	/// English String: "Unable to load group list."
	/// </summary>
	public virtual string MessageLoadGroupListError => "Unable to load group list.";

	/// <summary>
	/// Key: "Message.LoadGroupMembershipsError"
	/// English String: "Unable to load user membership information."
	/// </summary>
	public virtual string MessageLoadGroupMembershipsError => "Unable to load user membership information.";

	/// <summary>
	/// Key: "Message.LoadGroupMetadataError"
	/// English String: "Unable to load group info."
	/// </summary>
	public virtual string MessageLoadGroupMetadataError => "Unable to load group info.";

	/// <summary>
	/// Key: "Message.LoadGroupStoreItemsError"
	/// English String: "Unable to load store items."
	/// </summary>
	public virtual string MessageLoadGroupStoreItemsError => "Unable to load store items.";

	/// <summary>
	/// Key: "Message.LoadUserGroupMembershipError"
	/// English String: "Unable to load group member information."
	/// </summary>
	public virtual string MessageLoadUserGroupMembershipError => "Unable to load group member information.";

	/// <summary>
	/// Key: "Message.LoadWallPostsError"
	/// English String: "Unable to load wall posts."
	/// </summary>
	public virtual string MessageLoadWallPostsError => "Unable to load wall posts.";

	/// <summary>
	/// Key: "Message.MakePrimaryError"
	/// English String: "Unable to make primary group."
	/// </summary>
	public virtual string MessageMakePrimaryError => "Unable to make primary group.";

	/// <summary>
	/// Key: "Message.MaxGroups"
	/// English String: "User is in maximum number of groups."
	/// </summary>
	public virtual string MessageMaxGroups => "User is in maximum number of groups.";

	/// <summary>
	/// Key: "Message.MissingGroupIcon"
	/// English String: "The group icon is missing from the request."
	/// </summary>
	public virtual string MessageMissingGroupIcon => "The group icon is missing from the request.";

	/// <summary>
	/// Key: "Message.MissingGroupStatusContent"
	/// English String: "Missing group status content."
	/// </summary>
	public virtual string MessageMissingGroupStatusContent => "Missing group status content.";

	/// <summary>
	/// Key: "Message.NameInvalid"
	/// English String: "Name is missing or has invalid characters."
	/// </summary>
	public virtual string MessageNameInvalid => "Name is missing or has invalid characters.";

	/// <summary>
	/// Key: "Message.NameModerated"
	/// English String: "The name is moderated."
	/// </summary>
	public virtual string MessageNameModerated => "The name is moderated.";

	/// <summary>
	/// Key: "Message.NameTaken"
	/// English String: "The name has been taken."
	/// </summary>
	public virtual string MessageNameTaken => "The name has been taken.";

	/// <summary>
	/// Key: "Message.NameTooLong"
	/// English String: "The name is too long."
	/// </summary>
	public virtual string MessageNameTooLong => "The name is too long.";

	/// <summary>
	/// Key: "Message.NoPrimary"
	/// English String: "The user specified does not have a primary group."
	/// </summary>
	public virtual string MessageNoPrimary => "The user specified does not have a primary group.";

	/// <summary>
	/// Key: "Message.PassCaptchaToJoin"
	/// English String: "You must pass the captcha test before joining this group."
	/// </summary>
	public virtual string MessagePassCaptchaToJoin => "You must pass the captcha test before joining this group.";

	/// <summary>
	/// Key: "Message.PassCaptchaToPost"
	/// English String: "Captcha must be solved to post to the group wall."
	/// </summary>
	public virtual string MessagePassCaptchaToPost => "Captcha must be solved to post to the group wall.";

	/// <summary>
	/// Key: "Message.RemovePrimaryError"
	/// English String: "Unable to remove primary group."
	/// </summary>
	public virtual string MessageRemovePrimaryError => "Unable to remove primary group.";

	/// <summary>
	/// Key: "Message.SearchTermCharactersLimit"
	/// English String: "The search term needs to be between 2 and 50 characters"
	/// </summary>
	public virtual string MessageSearchTermCharactersLimit => "The search term needs to be between 2 and 50 characters";

	/// <summary>
	/// Key: "Message.SearchTermEmptyError"
	/// English String: "Search term is empty"
	/// </summary>
	public virtual string MessageSearchTermEmptyError => "Search term is empty";

	/// <summary>
	/// Key: "Message.SearchTermFilteredError"
	/// English String: "Search term was filtered"
	/// </summary>
	public virtual string MessageSearchTermFilteredError => "Search term was filtered";

	/// <summary>
	/// Key: "Message.SendGroupShoutError"
	/// English String: "Unable to send group shout."
	/// </summary>
	public virtual string MessageSendGroupShoutError => "Unable to send group shout.";

	/// <summary>
	/// Key: "Message.SendPostError"
	/// English String: "Unable to send post."
	/// </summary>
	public virtual string MessageSendPostError => "Unable to send post.";

	/// <summary>
	/// Key: "Message.TooManyAttempts"
	/// English String: "Too many attempts to join the group. Please try again later."
	/// </summary>
	public virtual string MessageTooManyAttempts => "Too many attempts to join the group. Please try again later.";

	/// <summary>
	/// Key: "Message.TooManyAttemptsToClaimGroups"
	/// English String: "Too many attempts to claim groups. Please try again later."
	/// </summary>
	public virtual string MessageTooManyAttemptsToClaimGroups => "Too many attempts to claim groups. Please try again later.";

	/// <summary>
	/// Key: "Message.TooManyGroups"
	/// English String: "You have reached the group capacity. Please leave a group before creating a new one."
	/// </summary>
	public virtual string MessageTooManyGroups => "You have reached the group capacity. Please leave a group before creating a new one.";

	/// <summary>
	/// Key: "Message.TooManyIds"
	/// English String: "Too many ids in request."
	/// </summary>
	public virtual string MessageTooManyIds => "Too many ids in request.";

	/// <summary>
	/// Key: "Message.TooManyPosts"
	/// English String: "You are posting too fast, please try again in a few minutes."
	/// </summary>
	public virtual string MessageTooManyPosts => "You are posting too fast, please try again in a few minutes.";

	/// <summary>
	/// Key: "Message.TooManyRequests"
	/// English String: "Too many requests."
	/// </summary>
	public virtual string MessageTooManyRequests => "Too many requests.";

	/// <summary>
	/// Key: "Message.UnauthorizedForPostStatus"
	/// English String: "You are not authorized to set the status of this group."
	/// </summary>
	public virtual string MessageUnauthorizedForPostStatus => "You are not authorized to set the status of this group.";

	/// <summary>
	/// Key: "Message.UnauthorizedForViewGroupPayouts"
	/// English String: "You don't have permission to view this group's payouts."
	/// </summary>
	public virtual string MessageUnauthorizedForViewGroupPayouts => "You don't have permission to view this group's payouts.";

	/// <summary>
	/// Key: "Message.UnauthorizedToClaimGroup"
	/// English String: "You are not authorized to claim this group."
	/// </summary>
	public virtual string MessageUnauthorizedToClaimGroup => "You are not authorized to claim this group.";

	/// <summary>
	/// Key: "Message.UnauthorizedToManageMember"
	/// English String: "You do not have permission to manage this member."
	/// </summary>
	public virtual string MessageUnauthorizedToManageMember => "You do not have permission to manage this member.";

	/// <summary>
	/// Key: "Message.UnauthorizedToViewRolesetPermissions"
	/// English String: "You are not authorized to view permissions for this roleset."
	/// </summary>
	public virtual string MessageUnauthorizedToViewRolesetPermissions => "You are not authorized to view permissions for this roleset.";

	/// <summary>
	/// Key: "Message.UnauthorizedToViewWall"
	/// English String: "You do not have permission to access this group wall."
	/// </summary>
	public virtual string MessageUnauthorizedToViewWall => "You do not have permission to access this group wall.";

	/// <summary>
	/// Key: "Message.UnknownError"
	/// English String: "Unknown error"
	/// </summary>
	public virtual string MessageUnknownError => "Unknown error";

	/// <summary>
	/// Key: "Message.UserNotInGroup"
	/// English String: "You aren't a member of the group specified."
	/// </summary>
	public virtual string MessageUserNotInGroup => "You aren't a member of the group specified.";

	public GroupsResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"Action.AdvertiseGroup",
				_GetTemplateForActionAdvertiseGroup()
			},
			{
				"Action.AuditLog",
				_GetTemplateForActionAuditLog()
			},
			{
				"Action.Cancel",
				_GetTemplateForActionCancel()
			},
			{
				"Action.CancelRequest",
				_GetTemplateForActionCancelRequest()
			},
			{
				"Action.ClaimOwnership",
				_GetTemplateForActionClaimOwnership()
			},
			{
				"Action.Close",
				_GetTemplateForActionClose()
			},
			{
				"Action.ConfigureGroup",
				_GetTemplateForActionConfigureGroup()
			},
			{
				"Action.CreateGroup",
				_GetTemplateForActionCreateGroup()
			},
			{
				"Action.Delete",
				_GetTemplateForActionDelete()
			},
			{
				"Action.Exile",
				_GetTemplateForActionExile()
			},
			{
				"Action.ExileUser",
				_GetTemplateForActionExileUser()
			},
			{
				"Action.GroupAdmin",
				_GetTemplateForActionGroupAdmin()
			},
			{
				"Action.GroupShout",
				_GetTemplateForActionGroupShout()
			},
			{
				"Action.JoinGroup",
				_GetTemplateForActionJoinGroup()
			},
			{
				"Action.LeaveGroup",
				_GetTemplateForActionLeaveGroup()
			},
			{
				"Action.MakePrimary",
				_GetTemplateForActionMakePrimary()
			},
			{
				"Action.MakePrimaryGroup",
				_GetTemplateForActionMakePrimaryGroup()
			},
			{
				"Action.Post",
				_GetTemplateForActionPost()
			},
			{
				"Action.Purchase",
				_GetTemplateForActionPurchase()
			},
			{
				"Action.RemovePrimary",
				_GetTemplateForActionRemovePrimary()
			},
			{
				"Action.Report",
				_GetTemplateForActionReport()
			},
			{
				"Action.ReportAbuse",
				_GetTemplateForActionReportAbuse()
			},
			{
				"Action.Upgrade",
				_GetTemplateForActionUpgrade()
			},
			{
				"Action.UpgradeToJoin",
				_GetTemplateForActionUpgradeToJoin()
			},
			{
				"Action.Yes",
				_GetTemplateForActionYes()
			},
			{
				"Description.ClothingRevenue",
				_GetTemplateForDescriptionClothingRevenue()
			},
			{
				"Description.DeleteAllPostsByUser",
				_GetTemplateForDescriptionDeleteAllPostsByUser()
			},
			{
				"Description.ExileUserWarning",
				_GetTemplateForDescriptionExileUserWarning()
			},
			{
				"Description.LeaveGroupAsOwnerWarning",
				_GetTemplateForDescriptionLeaveGroupAsOwnerWarning()
			},
			{
				"Description.LeaveGroupWarning",
				_GetTemplateForDescriptionLeaveGroupWarning()
			},
			{
				"Description.MakePrimaryGroupWarning",
				_GetTemplateForDescriptionMakePrimaryGroupWarning()
			},
			{
				"Description.NoneMaxGroups",
				_GetTemplateForDescriptionNoneMaxGroups()
			},
			{
				"Description.NoneMaxGroupsPremium",
				_GetTemplateForDescriptionNoneMaxGroupsPremium()
			},
			{
				"Description.noneMaxGroupsPremiumText",
				_GetTemplateForDescriptionnoneMaxGroupsPremiumText()
			},
			{
				"Description.ObcMaxGroups",
				_GetTemplateForDescriptionObcMaxGroups()
			},
			{
				"Description.OtherBcMaxGroups",
				_GetTemplateForDescriptionOtherBcMaxGroups()
			},
			{
				"Description.otherPremiumMaxGroupsText",
				_GetTemplateForDescriptionotherPremiumMaxGroupsText()
			},
			{
				"Description.PremiumMaxGroups",
				_GetTemplateForDescriptionPremiumMaxGroups()
			},
			{
				"Description.PurchaseBody",
				_GetTemplateForDescriptionPurchaseBody()
			},
			{
				"Description.RemovePrimaryGroupWarning",
				_GetTemplateForDescriptionRemovePrimaryGroupWarning()
			},
			{
				"Description.ReportAbuseDescription",
				_GetTemplateForDescriptionReportAbuseDescription()
			},
			{
				"Description.WallPrivacySettings",
				_GetTemplateForDescriptionWallPrivacySettings()
			},
			{
				"Heading.About",
				_GetTemplateForHeadingAbout()
			},
			{
				"Heading.Affiliates",
				_GetTemplateForHeadingAffiliates()
			},
			{
				"Heading.Allies",
				_GetTemplateForHeadingAllies()
			},
			{
				"Heading.ConfigureGroup",
				_GetTemplateForHeadingConfigureGroup()
			},
			{
				"Heading.Date",
				_GetTemplateForHeadingDate()
			},
			{
				"Heading.Description",
				_GetTemplateForHeadingDescription()
			},
			{
				"Heading.Enemies",
				_GetTemplateForHeadingEnemies()
			},
			{
				"Heading.ExileUserWarning",
				_GetTemplateForHeadingExileUserWarning()
			},
			{
				"Heading.Funds",
				_GetTemplateForHeadingFunds()
			},
			{
				"Heading.Games",
				_GetTemplateForHeadingGames()
			},
			{
				"Heading.GroupPurchase",
				_GetTemplateForHeadingGroupPurchase()
			},
			{
				"Heading.GroupShout",
				_GetTemplateForHeadingGroupShout()
			},
			{
				"Heading.LeaveGroup",
				_GetTemplateForHeadingLeaveGroup()
			},
			{
				"Heading.MakePrimaryGroup",
				_GetTemplateForHeadingMakePrimaryGroup()
			},
			{
				"Heading.Members",
				_GetTemplateForHeadingMembers()
			},
			{
				"Heading.NameOrDescription",
				_GetTemplateForHeadingNameOrDescription()
			},
			{
				"Heading.Payouts",
				_GetTemplateForHeadingPayouts()
			},
			{
				"Heading.Primary",
				_GetTemplateForHeadingPrimary()
			},
			{
				"Heading.Rank",
				_GetTemplateForHeadingRank()
			},
			{
				"Heading.RemovePrimaryGroup",
				_GetTemplateForHeadingRemovePrimaryGroup()
			},
			{
				"Heading.Role",
				_GetTemplateForHeadingRole()
			},
			{
				"Heading.Settings",
				_GetTemplateForHeadingSettings()
			},
			{
				"Heading.Shout",
				_GetTemplateForHeadingShout()
			},
			{
				"Heading.Store",
				_GetTemplateForHeadingStore()
			},
			{
				"Heading.User",
				_GetTemplateForHeadingUser()
			},
			{
				"Heading.Wall",
				_GetTemplateForHeadingWall()
			},
			{
				"Label.Abandon",
				_GetTemplateForLabelAbandon()
			},
			{
				"Label.AcceptAllyRequest",
				_GetTemplateForLabelAcceptAllyRequest()
			},
			{
				"Label.AcceptJoinRequest",
				_GetTemplateForLabelAcceptJoinRequest()
			},
			{
				"Label.AddGroupPlace",
				_GetTemplateForLabelAddGroupPlace()
			},
			{
				"Label.AdjustCurrencyAmounts",
				_GetTemplateForLabelAdjustCurrencyAmounts()
			},
			{
				"Label.All",
				_GetTemplateForLabelAll()
			},
			{
				"Label.AnyoneCanJoin",
				_GetTemplateForLabelAnyoneCanJoin()
			},
			{
				"Label.BuyAd",
				_GetTemplateForLabelBuyAd()
			},
			{
				"Label.BuyClan",
				_GetTemplateForLabelBuyClan()
			},
			{
				"Label.ByOwner",
				_GetTemplateForLabelByOwner()
			},
			{
				"Label.CancelClanInvite",
				_GetTemplateForLabelCancelClanInvite()
			},
			{
				"Label.ChangeDescription",
				_GetTemplateForLabelChangeDescription()
			},
			{
				"Label.ChangeOwner",
				_GetTemplateForLabelChangeOwner()
			},
			{
				"Label.ChangeRank",
				_GetTemplateForLabelChangeRank()
			},
			{
				"Label.Claim",
				_GetTemplateForLabelClaim()
			},
			{
				"Label.ConfigureBadge",
				_GetTemplateForLabelConfigureBadge()
			},
			{
				"Label.ConfigureGroupAsset",
				_GetTemplateForLabelConfigureGroupAsset()
			},
			{
				"Label.ConfigureGroupDevelopmentItem",
				_GetTemplateForLabelConfigureGroupDevelopmentItem()
			},
			{
				"Label.ConfigureGroupGame",
				_GetTemplateForLabelConfigureGroupGame()
			},
			{
				"Label.ConfigureItems",
				_GetTemplateForLabelConfigureItems()
			},
			{
				"Label.CreateBadge",
				_GetTemplateForLabelCreateBadge()
			},
			{
				"Label.CreateEnemy",
				_GetTemplateForLabelCreateEnemy()
			},
			{
				"Label.CreateGamePass",
				_GetTemplateForLabelCreateGamePass()
			},
			{
				"Label.CreateGroup",
				_GetTemplateForLabelCreateGroup()
			},
			{
				"Label.CreateGroupAsset",
				_GetTemplateForLabelCreateGroupAsset()
			},
			{
				"Label.CreateGroupBuildersClubTooltip",
				_GetTemplateForLabelCreateGroupBuildersClubTooltip()
			},
			{
				"Label.CreateGroupDescription",
				_GetTemplateForLabelCreateGroupDescription()
			},
			{
				"Label.CreateGroupDeveloperProduct",
				_GetTemplateForLabelCreateGroupDeveloperProduct()
			},
			{
				"Label.CreateGroupEmblem",
				_GetTemplateForLabelCreateGroupEmblem()
			},
			{
				"Label.CreateGroupFee",
				_GetTemplateForLabelCreateGroupFee()
			},
			{
				"Label.CreateGroupName",
				_GetTemplateForLabelCreateGroupName()
			},
			{
				"Label.CreateGroupPremiumTooltip",
				_GetTemplateForLabelCreateGroupPremiumTooltip()
			},
			{
				"Label.CreateGroupTooltip",
				_GetTemplateForLabelCreateGroupTooltip()
			},
			{
				"Label.CreateItems",
				_GetTemplateForLabelCreateItems()
			},
			{
				"Label.DeclineAllyRequest",
				_GetTemplateForLabelDeclineAllyRequest()
			},
			{
				"Label.DeclineJoinRequest",
				_GetTemplateForLabelDeclineJoinRequest()
			},
			{
				"Label.Delete",
				_GetTemplateForLabelDelete()
			},
			{
				"Label.DeleteAllPostsByUser",
				_GetTemplateForLabelDeleteAllPostsByUser()
			},
			{
				"Label.DeleteAlly",
				_GetTemplateForLabelDeleteAlly()
			},
			{
				"Label.DeleteEnemy",
				_GetTemplateForLabelDeleteEnemy()
			},
			{
				"Label.DeleteGroupPlace",
				_GetTemplateForLabelDeleteGroupPlace()
			},
			{
				"Label.DeletePost",
				_GetTemplateForLabelDeletePost()
			},
			{
				"Label.Funds",
				_GetTemplateForLabelFunds()
			},
			{
				"Label.GroupClosed",
				_GetTemplateForLabelGroupClosed()
			},
			{
				"Label.GroupLocked",
				_GetTemplateForLabelGroupLocked()
			},
			{
				"Label.GroupSearchResults",
				_GetTemplateForLabelGroupSearchResults()
			},
			{
				"Label.InviteToClan",
				_GetTemplateForLabelInviteToClan()
			},
			{
				"Label.KickFromClan",
				_GetTemplateForLabelKickFromClan()
			},
			{
				"Label.Loading",
				_GetTemplateForLabelLoading()
			},
			{
				"Label.Lock",
				_GetTemplateForLabelLock()
			},
			{
				"Label.ManageGroupCreations",
				_GetTemplateForLabelManageGroupCreations()
			},
			{
				"Label.ManualApproval",
				_GetTemplateForLabelManualApproval()
			},
			{
				"Label.MaxGroupsTooltip",
				_GetTemplateForLabelMaxGroupsTooltip()
			},
			{
				"Label.Members",
				_GetTemplateForLabelMembers()
			},
			{
				"Label.ModerateDiscussion",
				_GetTemplateForLabelModerateDiscussion()
			},
			{
				"Label.NoAllies",
				_GetTemplateForLabelNoAllies()
			},
			{
				"Label.NoEnemies",
				_GetTemplateForLabelNoEnemies()
			},
			{
				"Label.NoGames",
				_GetTemplateForLabelNoGames()
			},
			{
				"Label.NoMembersInRole",
				_GetTemplateForLabelNoMembersInRole()
			},
			{
				"Label.NoOne",
				_GetTemplateForLabelNoOne()
			},
			{
				"Label.NoResults",
				_GetTemplateForLabelNoResults()
			},
			{
				"Label.NoStoreItems",
				_GetTemplateForLabelNoStoreItems()
			},
			{
				"Label.NoWallPosts",
				_GetTemplateForLabelNoWallPosts()
			},
			{
				"Label.OnlyBcCanJoin",
				_GetTemplateForLabelOnlyBcCanJoin()
			},
			{
				"Label.OnlyPremiumCanJoin",
				_GetTemplateForLabelOnlyPremiumCanJoin()
			},
			{
				"Label.PrivateGroup",
				_GetTemplateForLabelPrivateGroup()
			},
			{
				"Label.PublicGroup",
				_GetTemplateForLabelPublicGroup()
			},
			{
				"Label.PublishPlace",
				_GetTemplateForLabelPublishPlace()
			},
			{
				"Label.RemoveGroupPlace",
				_GetTemplateForLabelRemoveGroupPlace()
			},
			{
				"Label.RemoveMember",
				_GetTemplateForLabelRemoveMember()
			},
			{
				"Label.Rename",
				_GetTemplateForLabelRename()
			},
			{
				"Label.RevertGroupAsset",
				_GetTemplateForLabelRevertGroupAsset()
			},
			{
				"Label.SavePlace",
				_GetTemplateForLabelSavePlace()
			},
			{
				"Label.SearchGroups",
				_GetTemplateForLabelSearchGroups()
			},
			{
				"Label.SearchUsers",
				_GetTemplateForLabelSearchUsers()
			},
			{
				"Label.SendAllyRequest",
				_GetTemplateForLabelSendAllyRequest()
			},
			{
				"Label.ShoutPlaceholder",
				_GetTemplateForLabelShoutPlaceholder()
			},
			{
				"Label.SpendGroupFunds",
				_GetTemplateForLabelSpendGroupFunds()
			},
			{
				"Label.Success",
				_GetTemplateForLabelSuccess()
			},
			{
				"Label.Unlock",
				_GetTemplateForLabelUnlock()
			},
			{
				"Label.UpdateGroupAsset",
				_GetTemplateForLabelUpdateGroupAsset()
			},
			{
				"Label.WallPostPlaceholder",
				_GetTemplateForLabelWallPostPlaceholder()
			},
			{
				"Label.WallPostsUnavailable",
				_GetTemplateForLabelWallPostsUnavailable()
			},
			{
				"Label.Warning",
				_GetTemplateForLabelWarning()
			},
			{
				"Message.Abandon",
				_GetTemplateForMessageAbandon()
			},
			{
				"Message.AcceptAllyRequest",
				_GetTemplateForMessageAcceptAllyRequest()
			},
			{
				"Message.AcceptJoinRequest",
				_GetTemplateForMessageAcceptJoinRequest()
			},
			{
				"Message.AddGroupPlace",
				_GetTemplateForMessageAddGroupPlace()
			},
			{
				"Message.AdjustCurrencyAmountsDecreased",
				_GetTemplateForMessageAdjustCurrencyAmountsDecreased()
			},
			{
				"Message.AdjustCurrencyAmountsIncreased",
				_GetTemplateForMessageAdjustCurrencyAmountsIncreased()
			},
			{
				"Message.AlreadyMember",
				_GetTemplateForMessageAlreadyMember()
			},
			{
				"Message.AlreadyRequested",
				_GetTemplateForMessageAlreadyRequested()
			},
			{
				"Message.BuildGroupRolesListError",
				_GetTemplateForMessageBuildGroupRolesListError()
			},
			{
				"Message.BuyAd",
				_GetTemplateForMessageBuyAd()
			},
			{
				"Message.BuyClan",
				_GetTemplateForMessageBuyClan()
			},
			{
				"Message.CancelClanInvite",
				_GetTemplateForMessageCancelClanInvite()
			},
			{
				"Message.CannotClaimGroupWithOwner",
				_GetTemplateForMessageCannotClaimGroupWithOwner()
			},
			{
				"Message.ChangeDescription",
				_GetTemplateForMessageChangeDescription()
			},
			{
				"Message.ChangeOwner",
				_GetTemplateForMessageChangeOwner()
			},
			{
				"Message.ChangeOwnerEmpty",
				_GetTemplateForMessageChangeOwnerEmpty()
			},
			{
				"Message.ChangeRank",
				_GetTemplateForMessageChangeRank()
			},
			{
				"Message.Claim",
				_GetTemplateForMessageClaim()
			},
			{
				"Message.ClaimOwnershipError",
				_GetTemplateForMessageClaimOwnershipError()
			},
			{
				"Message.ClaimOwnershipSuccess",
				_GetTemplateForMessageClaimOwnershipSuccess()
			},
			{
				"Message.ConfigureAsset",
				_GetTemplateForMessageConfigureAsset()
			},
			{
				"Message.ConfigureBadgeDisabled",
				_GetTemplateForMessageConfigureBadgeDisabled()
			},
			{
				"Message.ConfigureBadgeEnabled",
				_GetTemplateForMessageConfigureBadgeEnabled()
			},
			{
				"Message.ConfigureBadgeUpdate",
				_GetTemplateForMessageConfigureBadgeUpdate()
			},
			{
				"Message.ConfigureGame",
				_GetTemplateForMessageConfigureGame()
			},
			{
				"Message.ConfigureGameDeveloperProduct",
				_GetTemplateForMessageConfigureGameDeveloperProduct()
			},
			{
				"Message.ConfigureItems",
				_GetTemplateForMessageConfigureItems()
			},
			{
				"Message.CreateAsset",
				_GetTemplateForMessageCreateAsset()
			},
			{
				"Message.CreateBadge",
				_GetTemplateForMessageCreateBadge()
			},
			{
				"Message.CreateDeveloperProduct",
				_GetTemplateForMessageCreateDeveloperProduct()
			},
			{
				"Message.CreateEnemy",
				_GetTemplateForMessageCreateEnemy()
			},
			{
				"Message.CreateGamePass",
				_GetTemplateForMessageCreateGamePass()
			},
			{
				"Message.CreateItems",
				_GetTemplateForMessageCreateItems()
			},
			{
				"Message.DeclineAllyRequest",
				_GetTemplateForMessageDeclineAllyRequest()
			},
			{
				"Message.DeclineJoinRequest",
				_GetTemplateForMessageDeclineJoinRequest()
			},
			{
				"Message.DefaultError",
				_GetTemplateForMessageDefaultError()
			},
			{
				"Message.Delete",
				_GetTemplateForMessageDelete()
			},
			{
				"Message.DeleteAlly",
				_GetTemplateForMessageDeleteAlly()
			},
			{
				"Message.DeleteEnemy",
				_GetTemplateForMessageDeleteEnemy()
			},
			{
				"Message.DeleteGroupPlace",
				_GetTemplateForMessageDeleteGroupPlace()
			},
			{
				"Message.DeletePost",
				_GetTemplateForMessageDeletePost()
			},
			{
				"Message.DeleteWallPostError",
				_GetTemplateForMessageDeleteWallPostError()
			},
			{
				"Message.DeleteWallPostsByUserError",
				_GetTemplateForMessageDeleteWallPostsByUserError()
			},
			{
				"Message.DeleteWallPostSuccess",
				_GetTemplateForMessageDeleteWallPostSuccess()
			},
			{
				"Message.DescriptionTooLong",
				_GetTemplateForMessageDescriptionTooLong()
			},
			{
				"Message.DuplicateName",
				_GetTemplateForMessageDuplicateName()
			},
			{
				"Message.ExileUserError",
				_GetTemplateForMessageExileUserError()
			},
			{
				"Message.FeatureDisabled",
				_GetTemplateForMessageFeatureDisabled()
			},
			{
				"Message.GetGroupRelationshipsError",
				_GetTemplateForMessageGetGroupRelationshipsError()
			},
			{
				"Message.GroupClosed",
				_GetTemplateForMessageGroupClosed()
			},
			{
				"Message.GroupCreationDisabled",
				_GetTemplateForMessageGroupCreationDisabled()
			},
			{
				"Message.GroupIconInvalid",
				_GetTemplateForMessageGroupIconInvalid()
			},
			{
				"Message.GroupIconTooLarge",
				_GetTemplateForMessageGroupIconTooLarge()
			},
			{
				"Message.GroupMembershipsUnavailableError",
				_GetTemplateForMessageGroupMembershipsUnavailableError()
			},
			{
				"Message.InsufficientFunds",
				_GetTemplateForMessageInsufficientFunds()
			},
			{
				"Message.InsufficientGroupSpace",
				_GetTemplateForMessageInsufficientGroupSpace()
			},
			{
				"Message.InsufficientMembership",
				_GetTemplateForMessageInsufficientMembership()
			},
			{
				"Message.InsufficientPermission",
				_GetTemplateForMessageInsufficientPermission()
			},
			{
				"Message.InsufficientPermissionsForRelationships",
				_GetTemplateForMessageInsufficientPermissionsForRelationships()
			},
			{
				"Message.InsufficientRobux",
				_GetTemplateForMessageInsufficientRobux()
			},
			{
				"Message.InvalidAmount",
				_GetTemplateForMessageInvalidAmount()
			},
			{
				"Message.InvalidGroup",
				_GetTemplateForMessageInvalidGroup()
			},
			{
				"Message.InvalidGroupIcon",
				_GetTemplateForMessageInvalidGroupIcon()
			},
			{
				"Message.InvalidGroupId",
				_GetTemplateForMessageInvalidGroupId()
			},
			{
				"Message.InvalidGroupWallPostId",
				_GetTemplateForMessageInvalidGroupWallPostId()
			},
			{
				"Message.InvalidIds",
				_GetTemplateForMessageInvalidIds()
			},
			{
				"Message.InvalidIdsError",
				_GetTemplateForMessageInvalidIdsError()
			},
			{
				"Message.InvalidMembership",
				_GetTemplateForMessageInvalidMembership()
			},
			{
				"Message.InvalidName",
				_GetTemplateForMessageInvalidName()
			},
			{
				"Message.InvalidPaginationParameters",
				_GetTemplateForMessageInvalidPaginationParameters()
			},
			{
				"Message.InvalidPayoutType",
				_GetTemplateForMessageInvalidPayoutType()
			},
			{
				"Message.InvalidRecipient",
				_GetTemplateForMessageInvalidRecipient()
			},
			{
				"Message.InvalidRelationshipType",
				_GetTemplateForMessageInvalidRelationshipType()
			},
			{
				"Message.InvalidRoleSetId",
				_GetTemplateForMessageInvalidRoleSetId()
			},
			{
				"Message.InvalidUser",
				_GetTemplateForMessageInvalidUser()
			},
			{
				"Message.InvalidWallPostContent",
				_GetTemplateForMessageInvalidWallPostContent()
			},
			{
				"Message.InviteToClan",
				_GetTemplateForMessageInviteToClan()
			},
			{
				"Message.JoinGroupError",
				_GetTemplateForMessageJoinGroupError()
			},
			{
				"Message.JoinGroupPendingSuccess",
				_GetTemplateForMessageJoinGroupPendingSuccess()
			},
			{
				"Message.JoinGroupSuccess",
				_GetTemplateForMessageJoinGroupSuccess()
			},
			{
				"Message.KickFromClan",
				_GetTemplateForMessageKickFromClan()
			},
			{
				"Message.LeaveGroupError",
				_GetTemplateForMessageLeaveGroupError()
			},
			{
				"Message.LoadGroupError",
				_GetTemplateForMessageLoadGroupError()
			},
			{
				"Message.LoadGroupGamesError",
				_GetTemplateForMessageLoadGroupGamesError()
			},
			{
				"Message.LoadGroupListError",
				_GetTemplateForMessageLoadGroupListError()
			},
			{
				"Message.LoadGroupMembershipsError",
				_GetTemplateForMessageLoadGroupMembershipsError()
			},
			{
				"Message.LoadGroupMetadataError",
				_GetTemplateForMessageLoadGroupMetadataError()
			},
			{
				"Message.LoadGroupStoreItemsError",
				_GetTemplateForMessageLoadGroupStoreItemsError()
			},
			{
				"Message.LoadUserGroupMembershipError",
				_GetTemplateForMessageLoadUserGroupMembershipError()
			},
			{
				"Message.LoadWallPostsError",
				_GetTemplateForMessageLoadWallPostsError()
			},
			{
				"Message.Lock",
				_GetTemplateForMessageLock()
			},
			{
				"Message.MakePrimaryError",
				_GetTemplateForMessageMakePrimaryError()
			},
			{
				"Message.MaxGroups",
				_GetTemplateForMessageMaxGroups()
			},
			{
				"Message.MissingGroupIcon",
				_GetTemplateForMessageMissingGroupIcon()
			},
			{
				"Message.MissingGroupStatusContent",
				_GetTemplateForMessageMissingGroupStatusContent()
			},
			{
				"Message.NameInvalid",
				_GetTemplateForMessageNameInvalid()
			},
			{
				"Message.NameModerated",
				_GetTemplateForMessageNameModerated()
			},
			{
				"Message.NameTaken",
				_GetTemplateForMessageNameTaken()
			},
			{
				"Message.NameTooLong",
				_GetTemplateForMessageNameTooLong()
			},
			{
				"Message.NoPrimary",
				_GetTemplateForMessageNoPrimary()
			},
			{
				"Message.PassCaptchaToJoin",
				_GetTemplateForMessagePassCaptchaToJoin()
			},
			{
				"Message.PassCaptchaToPost",
				_GetTemplateForMessagePassCaptchaToPost()
			},
			{
				"Message.PostStatus",
				_GetTemplateForMessagePostStatus()
			},
			{
				"Message.RemoveMember",
				_GetTemplateForMessageRemoveMember()
			},
			{
				"Message.RemovePrimaryError",
				_GetTemplateForMessageRemovePrimaryError()
			},
			{
				"Message.Rename",
				_GetTemplateForMessageRename()
			},
			{
				"Message.SearchTermCharactersLimit",
				_GetTemplateForMessageSearchTermCharactersLimit()
			},
			{
				"Message.SearchTermEmptyError",
				_GetTemplateForMessageSearchTermEmptyError()
			},
			{
				"Message.SearchTermFilteredError",
				_GetTemplateForMessageSearchTermFilteredError()
			},
			{
				"Message.SendAllyRequest",
				_GetTemplateForMessageSendAllyRequest()
			},
			{
				"Message.SendGroupShoutError",
				_GetTemplateForMessageSendGroupShoutError()
			},
			{
				"Message.SendPostError",
				_GetTemplateForMessageSendPostError()
			},
			{
				"Message.SpendGroupFunds",
				_GetTemplateForMessageSpendGroupFunds()
			},
			{
				"Message.TooManyAttempts",
				_GetTemplateForMessageTooManyAttempts()
			},
			{
				"Message.TooManyAttemptsToClaimGroups",
				_GetTemplateForMessageTooManyAttemptsToClaimGroups()
			},
			{
				"Message.TooManyGroups",
				_GetTemplateForMessageTooManyGroups()
			},
			{
				"Message.TooManyIds",
				_GetTemplateForMessageTooManyIds()
			},
			{
				"Message.TooManyPosts",
				_GetTemplateForMessageTooManyPosts()
			},
			{
				"Message.TooManyRequests",
				_GetTemplateForMessageTooManyRequests()
			},
			{
				"Message.UnauthorizedForPostStatus",
				_GetTemplateForMessageUnauthorizedForPostStatus()
			},
			{
				"Message.UnauthorizedForViewGroupPayouts",
				_GetTemplateForMessageUnauthorizedForViewGroupPayouts()
			},
			{
				"Message.UnauthorizedToClaimGroup",
				_GetTemplateForMessageUnauthorizedToClaimGroup()
			},
			{
				"Message.UnauthorizedToManageMember",
				_GetTemplateForMessageUnauthorizedToManageMember()
			},
			{
				"Message.UnauthorizedToViewRolesetPermissions",
				_GetTemplateForMessageUnauthorizedToViewRolesetPermissions()
			},
			{
				"Message.UnauthorizedToViewWall",
				_GetTemplateForMessageUnauthorizedToViewWall()
			},
			{
				"Message.UnknownError",
				_GetTemplateForMessageUnknownError()
			},
			{
				"Message.Unlock",
				_GetTemplateForMessageUnlock()
			},
			{
				"Message.UpdateAsset",
				_GetTemplateForMessageUpdateAsset()
			},
			{
				"Message.UpdateAssetRevert",
				_GetTemplateForMessageUpdateAssetRevert()
			},
			{
				"Message.UserNotInGroup",
				_GetTemplateForMessageUserNotInGroup()
			}
		});
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "Feature.Groups";
	}

	protected virtual string _GetTemplateForActionAdvertiseGroup()
	{
		return "Advertise Group";
	}

	protected virtual string _GetTemplateForActionAuditLog()
	{
		return "Audit Log";
	}

	protected virtual string _GetTemplateForActionCancel()
	{
		return "Cancel";
	}

	protected virtual string _GetTemplateForActionCancelRequest()
	{
		return "Cancel Request";
	}

	protected virtual string _GetTemplateForActionClaimOwnership()
	{
		return "Claim Ownership";
	}

	protected virtual string _GetTemplateForActionClose()
	{
		return "Close";
	}

	protected virtual string _GetTemplateForActionConfigureGroup()
	{
		return "Configure Group";
	}

	protected virtual string _GetTemplateForActionCreateGroup()
	{
		return "Create Group";
	}

	protected virtual string _GetTemplateForActionDelete()
	{
		return "Delete";
	}

	protected virtual string _GetTemplateForActionExile()
	{
		return "Exile";
	}

	protected virtual string _GetTemplateForActionExileUser()
	{
		return "Exile User";
	}

	protected virtual string _GetTemplateForActionGroupAdmin()
	{
		return "Group Admin";
	}

	protected virtual string _GetTemplateForActionGroupShout()
	{
		return "Group Shout";
	}

	protected virtual string _GetTemplateForActionJoinGroup()
	{
		return "Join Group";
	}

	protected virtual string _GetTemplateForActionLeaveGroup()
	{
		return "Leave Group";
	}

	protected virtual string _GetTemplateForActionMakePrimary()
	{
		return "Make Primary";
	}

	protected virtual string _GetTemplateForActionMakePrimaryGroup()
	{
		return "Make Primary Group";
	}

	protected virtual string _GetTemplateForActionPost()
	{
		return "Post";
	}

	protected virtual string _GetTemplateForActionPurchase()
	{
		return "Purchase";
	}

	protected virtual string _GetTemplateForActionRemovePrimary()
	{
		return "Remove Primary";
	}

	protected virtual string _GetTemplateForActionReport()
	{
		return "Report";
	}

	protected virtual string _GetTemplateForActionReportAbuse()
	{
		return "Report Abuse";
	}

	protected virtual string _GetTemplateForActionUpgrade()
	{
		return "Upgrade";
	}

	protected virtual string _GetTemplateForActionUpgradeToJoin()
	{
		return "Upgrade to Join";
	}

	protected virtual string _GetTemplateForActionYes()
	{
		return "Yes";
	}

	protected virtual string _GetTemplateForDescriptionClothingRevenue()
	{
		return "Groups have the ability to create and sell official shirts, pants, and t-shirts! All revenue goes to group funds.";
	}

	protected virtual string _GetTemplateForDescriptionDeleteAllPostsByUser()
	{
		return "Also delete all posts by this user.";
	}

	protected virtual string _GetTemplateForDescriptionExileUserWarning()
	{
		return "Are you sure you want to exile this user?";
	}

	protected virtual string _GetTemplateForDescriptionLeaveGroupAsOwnerWarning()
	{
		return "This will leave the group ownerless.";
	}

	protected virtual string _GetTemplateForDescriptionLeaveGroupWarning()
	{
		return "Are you sure you want to leave this group?";
	}

	protected virtual string _GetTemplateForDescriptionMakePrimaryGroupWarning()
	{
		return "Are you sure you want to make this your primary group?";
	}

	protected virtual string _GetTemplateForDescriptionNoneMaxGroups()
	{
		return "Upgrade to Builders Club to join more groups.";
	}

	protected virtual string _GetTemplateForDescriptionNoneMaxGroupsPremium()
	{
		return "Upgrade to Roblox Premium to join more groups.";
	}

	protected virtual string _GetTemplateForDescriptionnoneMaxGroupsPremiumText()
	{
		return "Upgrade to Roblox Premium to join more groups.";
	}

	protected virtual string _GetTemplateForDescriptionObcMaxGroups()
	{
		return "You have joined the maximum number of groups.";
	}

	protected virtual string _GetTemplateForDescriptionOtherBcMaxGroups()
	{
		return "Upgrade your Builders Club to join more groups.";
	}

	protected virtual string _GetTemplateForDescriptionotherPremiumMaxGroupsText()
	{
		return "Upgrade your Roblox Premium to join more groups.";
	}

	protected virtual string _GetTemplateForDescriptionPremiumMaxGroups()
	{
		return "You have joined the maximum number of groups.";
	}

	protected virtual string _GetTemplateForDescriptionPurchaseBody()
	{
		return "Would you like to create this group for";
	}

	protected virtual string _GetTemplateForDescriptionRemovePrimaryGroupWarning()
	{
		return "Are you sure you want to remove your primary group?";
	}

	protected virtual string _GetTemplateForDescriptionReportAbuseDescription()
	{
		return "What would you like to report?";
	}

	protected virtual string _GetTemplateForDescriptionWallPrivacySettings()
	{
		return "Your privacy settings do not allow you to post to group walls. Click here to adjust these settings.";
	}

	protected virtual string _GetTemplateForHeadingAbout()
	{
		return "About";
	}

	protected virtual string _GetTemplateForHeadingAffiliates()
	{
		return "Affiliates";
	}

	protected virtual string _GetTemplateForHeadingAllies()
	{
		return "Allies";
	}

	/// <summary>
	/// Key: "Heading.ConfigureGroup"
	/// English String: "Configure {groupName}"
	/// </summary>
	public virtual string HeadingConfigureGroup(string groupName)
	{
		return $"Configure {groupName}";
	}

	protected virtual string _GetTemplateForHeadingConfigureGroup()
	{
		return "Configure {groupName}";
	}

	protected virtual string _GetTemplateForHeadingDate()
	{
		return "Date";
	}

	protected virtual string _GetTemplateForHeadingDescription()
	{
		return "Description";
	}

	protected virtual string _GetTemplateForHeadingEnemies()
	{
		return "Enemies";
	}

	protected virtual string _GetTemplateForHeadingExileUserWarning()
	{
		return "Warning";
	}

	protected virtual string _GetTemplateForHeadingFunds()
	{
		return "Funds";
	}

	protected virtual string _GetTemplateForHeadingGames()
	{
		return "Games";
	}

	protected virtual string _GetTemplateForHeadingGroupPurchase()
	{
		return "Group Purchase Confirmation";
	}

	protected virtual string _GetTemplateForHeadingGroupShout()
	{
		return "Group Shout";
	}

	protected virtual string _GetTemplateForHeadingLeaveGroup()
	{
		return "Leave Group";
	}

	protected virtual string _GetTemplateForHeadingMakePrimaryGroup()
	{
		return "Make Primary Group";
	}

	protected virtual string _GetTemplateForHeadingMembers()
	{
		return "Members";
	}

	protected virtual string _GetTemplateForHeadingNameOrDescription()
	{
		return "Name or Description";
	}

	protected virtual string _GetTemplateForHeadingPayouts()
	{
		return "Payouts";
	}

	protected virtual string _GetTemplateForHeadingPrimary()
	{
		return "Primary";
	}

	protected virtual string _GetTemplateForHeadingRank()
	{
		return "Rank";
	}

	protected virtual string _GetTemplateForHeadingRemovePrimaryGroup()
	{
		return "Remove Primary Group";
	}

	protected virtual string _GetTemplateForHeadingRole()
	{
		return "Role";
	}

	protected virtual string _GetTemplateForHeadingSettings()
	{
		return "Settings";
	}

	protected virtual string _GetTemplateForHeadingShout()
	{
		return "Shout";
	}

	protected virtual string _GetTemplateForHeadingStore()
	{
		return "Store";
	}

	protected virtual string _GetTemplateForHeadingUser()
	{
		return "User";
	}

	protected virtual string _GetTemplateForHeadingWall()
	{
		return "Wall";
	}

	protected virtual string _GetTemplateForLabelAbandon()
	{
		return "Abandon";
	}

	protected virtual string _GetTemplateForLabelAcceptAllyRequest()
	{
		return "Accept Ally Request";
	}

	protected virtual string _GetTemplateForLabelAcceptJoinRequest()
	{
		return "Accept Join Request";
	}

	protected virtual string _GetTemplateForLabelAddGroupPlace()
	{
		return "Add Group Place";
	}

	protected virtual string _GetTemplateForLabelAdjustCurrencyAmounts()
	{
		return "Adjust Currency Amounts";
	}

	protected virtual string _GetTemplateForLabelAll()
	{
		return "All";
	}

	protected virtual string _GetTemplateForLabelAnyoneCanJoin()
	{
		return "Anyone Can Join";
	}

	protected virtual string _GetTemplateForLabelBuyAd()
	{
		return "Buy Ad";
	}

	protected virtual string _GetTemplateForLabelBuyClan()
	{
		return "Buy Clan";
	}

	protected virtual string _GetTemplateForLabelByOwner()
	{
		return "By";
	}

	protected virtual string _GetTemplateForLabelCancelClanInvite()
	{
		return "Cancel Clan Invite";
	}

	protected virtual string _GetTemplateForLabelChangeDescription()
	{
		return "Change Description";
	}

	protected virtual string _GetTemplateForLabelChangeOwner()
	{
		return "Change Owner";
	}

	protected virtual string _GetTemplateForLabelChangeRank()
	{
		return "Change Rank";
	}

	protected virtual string _GetTemplateForLabelClaim()
	{
		return "Claim";
	}

	protected virtual string _GetTemplateForLabelConfigureBadge()
	{
		return "Configure Badge";
	}

	protected virtual string _GetTemplateForLabelConfigureGroupAsset()
	{
		return "Configure Group Asset";
	}

	protected virtual string _GetTemplateForLabelConfigureGroupDevelopmentItem()
	{
		return "Configure Group Development Item";
	}

	protected virtual string _GetTemplateForLabelConfigureGroupGame()
	{
		return "Configure Group Game";
	}

	protected virtual string _GetTemplateForLabelConfigureItems()
	{
		return "Configure Items";
	}

	protected virtual string _GetTemplateForLabelCreateBadge()
	{
		return "Create Badge";
	}

	protected virtual string _GetTemplateForLabelCreateEnemy()
	{
		return "Create Enemy";
	}

	protected virtual string _GetTemplateForLabelCreateGamePass()
	{
		return "Create Game Pass";
	}

	protected virtual string _GetTemplateForLabelCreateGroup()
	{
		return "Create Group";
	}

	protected virtual string _GetTemplateForLabelCreateGroupAsset()
	{
		return "Create Group Asset";
	}

	protected virtual string _GetTemplateForLabelCreateGroupBuildersClubTooltip()
	{
		return "Creating a group requires a Builders Club membership.";
	}

	protected virtual string _GetTemplateForLabelCreateGroupDescription()
	{
		return "Description (optional)";
	}

	protected virtual string _GetTemplateForLabelCreateGroupDeveloperProduct()
	{
		return "Create Group Developer Product";
	}

	protected virtual string _GetTemplateForLabelCreateGroupEmblem()
	{
		return "Emblem";
	}

	protected virtual string _GetTemplateForLabelCreateGroupFee()
	{
		return "Group Creation Fee";
	}

	protected virtual string _GetTemplateForLabelCreateGroupName()
	{
		return "Name your group";
	}

	protected virtual string _GetTemplateForLabelCreateGroupPremiumTooltip()
	{
		return "Creating a group requires a Roblox Premium membership.";
	}

	protected virtual string _GetTemplateForLabelCreateGroupTooltip()
	{
		return "Create a new group";
	}

	protected virtual string _GetTemplateForLabelCreateItems()
	{
		return "Create Items";
	}

	protected virtual string _GetTemplateForLabelDeclineAllyRequest()
	{
		return "Decline Ally Request";
	}

	protected virtual string _GetTemplateForLabelDeclineJoinRequest()
	{
		return "Decline Join Request";
	}

	protected virtual string _GetTemplateForLabelDelete()
	{
		return "Delete";
	}

	protected virtual string _GetTemplateForLabelDeleteAllPostsByUser()
	{
		return "Also delete all posts by this user.";
	}

	protected virtual string _GetTemplateForLabelDeleteAlly()
	{
		return "Delete Ally";
	}

	protected virtual string _GetTemplateForLabelDeleteEnemy()
	{
		return "Delete Enemy";
	}

	protected virtual string _GetTemplateForLabelDeleteGroupPlace()
	{
		return "Delete Group Place";
	}

	protected virtual string _GetTemplateForLabelDeletePost()
	{
		return "Delete Post";
	}

	protected virtual string _GetTemplateForLabelFunds()
	{
		return "Funds";
	}

	protected virtual string _GetTemplateForLabelGroupClosed()
	{
		return "Group Closed";
	}

	protected virtual string _GetTemplateForLabelGroupLocked()
	{
		return "This group has been locked";
	}

	/// <summary>
	/// Key: "Label.GroupSearchResults"
	/// English String: "Group Results For {searchTerm}"
	/// </summary>
	public virtual string LabelGroupSearchResults(string searchTerm)
	{
		return $"Group Results For {searchTerm}";
	}

	protected virtual string _GetTemplateForLabelGroupSearchResults()
	{
		return "Group Results For {searchTerm}";
	}

	protected virtual string _GetTemplateForLabelInviteToClan()
	{
		return "Invite to Clan";
	}

	protected virtual string _GetTemplateForLabelKickFromClan()
	{
		return "Kick from Clan";
	}

	protected virtual string _GetTemplateForLabelLoading()
	{
		return "Loading...";
	}

	protected virtual string _GetTemplateForLabelLock()
	{
		return "Lock";
	}

	protected virtual string _GetTemplateForLabelManageGroupCreations()
	{
		return "Create or manage group items.";
	}

	protected virtual string _GetTemplateForLabelManualApproval()
	{
		return "Manual Approval";
	}

	/// <summary>
	/// Key: "Label.MaxGroupsTooltip"
	/// English String: "You may only be in a maximum of {maxGroups} groups at one time"
	/// </summary>
	public virtual string LabelMaxGroupsTooltip(string maxGroups)
	{
		return $"You may only be in a maximum of {maxGroups} groups at one time";
	}

	protected virtual string _GetTemplateForLabelMaxGroupsTooltip()
	{
		return "You may only be in a maximum of {maxGroups} groups at one time";
	}

	protected virtual string _GetTemplateForLabelMembers()
	{
		return "{memberCount, plural, =0 {# Members} =1 {# Member} other {# Members}}";
	}

	protected virtual string _GetTemplateForLabelModerateDiscussion()
	{
		return "Moderate Discussion";
	}

	protected virtual string _GetTemplateForLabelNoAllies()
	{
		return "This group does not have any allies.";
	}

	protected virtual string _GetTemplateForLabelNoEnemies()
	{
		return "This group does not have any enemies.";
	}

	protected virtual string _GetTemplateForLabelNoGames()
	{
		return "No games are associated with this group.";
	}

	protected virtual string _GetTemplateForLabelNoMembersInRole()
	{
		return "No group members are in this role.";
	}

	protected virtual string _GetTemplateForLabelNoOne()
	{
		return "No One!";
	}

	/// <summary>
	/// Key: "Label.NoResults"
	/// English String: "No results for \"{searchTerm}\""
	/// </summary>
	public virtual string LabelNoResults(string searchTerm)
	{
		return $"No results for \"{searchTerm}\"";
	}

	protected virtual string _GetTemplateForLabelNoResults()
	{
		return "No results for \"{searchTerm}\"";
	}

	protected virtual string _GetTemplateForLabelNoStoreItems()
	{
		return "No items are for sale in this group.";
	}

	protected virtual string _GetTemplateForLabelNoWallPosts()
	{
		return "Nobody has said anything yet...";
	}

	protected virtual string _GetTemplateForLabelOnlyBcCanJoin()
	{
		return "Only Builders Club members can join";
	}

	protected virtual string _GetTemplateForLabelOnlyPremiumCanJoin()
	{
		return "Only users with membership can join";
	}

	protected virtual string _GetTemplateForLabelPrivateGroup()
	{
		return "Private";
	}

	protected virtual string _GetTemplateForLabelPublicGroup()
	{
		return "Public";
	}

	protected virtual string _GetTemplateForLabelPublishPlace()
	{
		return "Publish Place";
	}

	protected virtual string _GetTemplateForLabelRemoveGroupPlace()
	{
		return "Remove Group Place";
	}

	protected virtual string _GetTemplateForLabelRemoveMember()
	{
		return "Remove Member";
	}

	protected virtual string _GetTemplateForLabelRename()
	{
		return "Rename";
	}

	protected virtual string _GetTemplateForLabelRevertGroupAsset()
	{
		return "Revert Group Asset";
	}

	protected virtual string _GetTemplateForLabelSavePlace()
	{
		return "Save Place";
	}

	protected virtual string _GetTemplateForLabelSearchGroups()
	{
		return "Search All Groups";
	}

	protected virtual string _GetTemplateForLabelSearchUsers()
	{
		return "Search Users";
	}

	protected virtual string _GetTemplateForLabelSendAllyRequest()
	{
		return "Send Ally Request";
	}

	protected virtual string _GetTemplateForLabelShoutPlaceholder()
	{
		return "Enter your shout";
	}

	protected virtual string _GetTemplateForLabelSpendGroupFunds()
	{
		return "Spend Group Funds";
	}

	protected virtual string _GetTemplateForLabelSuccess()
	{
		return "Success";
	}

	protected virtual string _GetTemplateForLabelUnlock()
	{
		return "Unlock";
	}

	protected virtual string _GetTemplateForLabelUpdateGroupAsset()
	{
		return "Update Group Asset";
	}

	protected virtual string _GetTemplateForLabelWallPostPlaceholder()
	{
		return "Say something...";
	}

	protected virtual string _GetTemplateForLabelWallPostsUnavailable()
	{
		return "Wall posts are temporarily unavailable, please check back later.";
	}

	protected virtual string _GetTemplateForLabelWarning()
	{
		return "Warning";
	}

	/// <summary>
	/// Key: "Message.Abandon"
	/// English String: "{actor} (group owner) abandoned the group"
	/// </summary>
	public virtual string MessageAbandon(string actor)
	{
		return $"{actor} (group owner) abandoned the group";
	}

	protected virtual string _GetTemplateForMessageAbandon()
	{
		return "{actor} (group owner) abandoned the group";
	}

	/// <summary>
	/// Key: "Message.AcceptAllyRequest"
	/// English String: "{actor} accepted group {group}'s ally request"
	/// </summary>
	public virtual string MessageAcceptAllyRequest(string actor, string group)
	{
		return $"{actor} accepted group {group}'s ally request";
	}

	protected virtual string _GetTemplateForMessageAcceptAllyRequest()
	{
		return "{actor} accepted group {group}'s ally request";
	}

	/// <summary>
	/// Key: "Message.AcceptJoinRequest"
	/// English String: "{actor} accepted user {user}'s join request"
	/// </summary>
	public virtual string MessageAcceptJoinRequest(string actor, string user)
	{
		return $"{actor} accepted user {user}'s join request";
	}

	protected virtual string _GetTemplateForMessageAcceptJoinRequest()
	{
		return "{actor} accepted user {user}'s join request";
	}

	/// <summary>
	/// Key: "Message.AddGroupPlace"
	/// English String: "{actor} added game {game} as a group game"
	/// </summary>
	public virtual string MessageAddGroupPlace(string actor, string game)
	{
		return $"{actor} added game {game} as a group game";
	}

	protected virtual string _GetTemplateForMessageAddGroupPlace()
	{
		return "{actor} added game {game} as a group game";
	}

	/// <summary>
	/// Key: "Message.AdjustCurrencyAmountsDecreased"
	/// English String: "{actor} decreased group funds by {amount}"
	/// </summary>
	public virtual string MessageAdjustCurrencyAmountsDecreased(string actor, string amount)
	{
		return $"{actor} decreased group funds by {amount}";
	}

	protected virtual string _GetTemplateForMessageAdjustCurrencyAmountsDecreased()
	{
		return "{actor} decreased group funds by {amount}";
	}

	/// <summary>
	/// Key: "Message.AdjustCurrencyAmountsIncreased"
	/// English String: "{actor} increased group funds by {amount}"
	/// </summary>
	public virtual string MessageAdjustCurrencyAmountsIncreased(string actor, string amount)
	{
		return $"{actor} increased group funds by {amount}";
	}

	protected virtual string _GetTemplateForMessageAdjustCurrencyAmountsIncreased()
	{
		return "{actor} increased group funds by {amount}";
	}

	protected virtual string _GetTemplateForMessageAlreadyMember()
	{
		return "You are already a member of this group.";
	}

	protected virtual string _GetTemplateForMessageAlreadyRequested()
	{
		return "You have already requested to join this group.";
	}

	protected virtual string _GetTemplateForMessageBuildGroupRolesListError()
	{
		return "Unable to load members for selected role.";
	}

	/// <summary>
	/// Key: "Message.BuyAd"
	/// English String: "{actor} bid {bid} on group ad {adName}"
	/// </summary>
	public virtual string MessageBuyAd(string actor, string bid, string adName)
	{
		return $"{actor} bid {bid} on group ad {adName}";
	}

	protected virtual string _GetTemplateForMessageBuyAd()
	{
		return "{actor} bid {bid} on group ad {adName}";
	}

	/// <summary>
	/// Key: "Message.BuyClan"
	/// English String: "{actor} bought a group clan"
	/// </summary>
	public virtual string MessageBuyClan(string actor)
	{
		return $"{actor} bought a group clan";
	}

	protected virtual string _GetTemplateForMessageBuyClan()
	{
		return "{actor} bought a group clan";
	}

	/// <summary>
	/// Key: "Message.CancelClanInvite"
	/// English String: "{actor} cancelled {user}'s clan invite"
	/// </summary>
	public virtual string MessageCancelClanInvite(string actor, string user)
	{
		return $"{actor} cancelled {user}'s clan invite";
	}

	protected virtual string _GetTemplateForMessageCancelClanInvite()
	{
		return "{actor} cancelled {user}'s clan invite";
	}

	protected virtual string _GetTemplateForMessageCannotClaimGroupWithOwner()
	{
		return "This group already has an owner.";
	}

	/// <summary>
	/// Key: "Message.ChangeDescription"
	/// English String: "{actor} changed the description to \"{newDescription}\""
	/// </summary>
	public virtual string MessageChangeDescription(string actor, string newDescription)
	{
		return $"{actor} changed the description to \"{newDescription}\"";
	}

	protected virtual string _GetTemplateForMessageChangeDescription()
	{
		return "{actor} changed the description to \"{newDescription}\"";
	}

	/// <summary>
	/// Key: "Message.ChangeOwner"
	/// English String: "{actor} changed the group owner. {user} is the new group owner"
	/// </summary>
	public virtual string MessageChangeOwner(string actor, string user)
	{
		return $"{actor} changed the group owner. {user} is the new group owner";
	}

	protected virtual string _GetTemplateForMessageChangeOwner()
	{
		return "{actor} changed the group owner. {user} is the new group owner";
	}

	protected virtual string _GetTemplateForMessageChangeOwnerEmpty()
	{
		return "There is no owner of the group";
	}

	/// <summary>
	/// Key: "Message.ChangeRank"
	/// English String: "{actor} changed user {user}'s rank from {oldRoleSet} to {newRoleSet}"
	/// </summary>
	public virtual string MessageChangeRank(string actor, string user, string oldRoleSet, string newRoleSet)
	{
		return $"{actor} changed user {user}'s rank from {oldRoleSet} to {newRoleSet}";
	}

	protected virtual string _GetTemplateForMessageChangeRank()
	{
		return "{actor} changed user {user}'s rank from {oldRoleSet} to {newRoleSet}";
	}

	/// <summary>
	/// Key: "Message.Claim"
	/// English String: "{actor} claimed ownership of the group"
	/// </summary>
	public virtual string MessageClaim(string actor)
	{
		return $"{actor} claimed ownership of the group";
	}

	protected virtual string _GetTemplateForMessageClaim()
	{
		return "{actor} claimed ownership of the group";
	}

	protected virtual string _GetTemplateForMessageClaimOwnershipError()
	{
		return "Unable to claim ownership of group.";
	}

	protected virtual string _GetTemplateForMessageClaimOwnershipSuccess()
	{
		return "Successfully claimed ownership of group.";
	}

	/// <summary>
	/// Key: "Message.ConfigureAsset"
	/// English String: "{actor} updated asset {item}: {actions}"
	/// </summary>
	public virtual string MessageConfigureAsset(string actor, string item, string actions)
	{
		return $"{actor} updated asset {item}: {actions}";
	}

	protected virtual string _GetTemplateForMessageConfigureAsset()
	{
		return "{actor} updated asset {item}: {actions}";
	}

	/// <summary>
	/// Key: "Message.ConfigureBadgeDisabled"
	/// English String: "{actor} disabled the badge {badge}"
	/// </summary>
	public virtual string MessageConfigureBadgeDisabled(string actor, string badge)
	{
		return $"{actor} disabled the badge {badge}";
	}

	protected virtual string _GetTemplateForMessageConfigureBadgeDisabled()
	{
		return "{actor} disabled the badge {badge}";
	}

	/// <summary>
	/// Key: "Message.ConfigureBadgeEnabled"
	/// English String: "{actor} enabled the badge {badge}"
	/// </summary>
	public virtual string MessageConfigureBadgeEnabled(string actor, string badge)
	{
		return $"{actor} enabled the badge {badge}";
	}

	protected virtual string _GetTemplateForMessageConfigureBadgeEnabled()
	{
		return "{actor} enabled the badge {badge}";
	}

	/// <summary>
	/// Key: "Message.ConfigureBadgeUpdate"
	/// English String: "{actor} configured the badge {badge}"
	/// </summary>
	public virtual string MessageConfigureBadgeUpdate(string actor, string badge)
	{
		return $"{actor} configured the badge {badge}";
	}

	protected virtual string _GetTemplateForMessageConfigureBadgeUpdate()
	{
		return "{actor} configured the badge {badge}";
	}

	/// <summary>
	/// Key: "Message.ConfigureGame"
	/// English String: "{actor} updated {game}: {actions}"
	/// </summary>
	public virtual string MessageConfigureGame(string actor, string game, string actions)
	{
		return $"{actor} updated {game}: {actions}";
	}

	protected virtual string _GetTemplateForMessageConfigureGame()
	{
		return "{actor} updated {game}: {actions}";
	}

	/// <summary>
	/// Key: "Message.ConfigureGameDeveloperProduct"
	/// English String: "{actor} updated developer product {id}: {actions}"
	/// </summary>
	public virtual string MessageConfigureGameDeveloperProduct(string actor, string id, string actions)
	{
		return $"{actor} updated developer product {id}: {actions}";
	}

	protected virtual string _GetTemplateForMessageConfigureGameDeveloperProduct()
	{
		return "{actor} updated developer product {id}: {actions}";
	}

	/// <summary>
	/// Key: "Message.ConfigureItems"
	/// English String: "{actor} configured the group item {item}"
	/// </summary>
	public virtual string MessageConfigureItems(string actor, string item)
	{
		return $"{actor} configured the group item {item}";
	}

	protected virtual string _GetTemplateForMessageConfigureItems()
	{
		return "{actor} configured the group item {item}";
	}

	/// <summary>
	/// Key: "Message.CreateAsset"
	/// English String: "{actor} created asset {item}"
	/// </summary>
	public virtual string MessageCreateAsset(string actor, string item)
	{
		return $"{actor} created asset {item}";
	}

	protected virtual string _GetTemplateForMessageCreateAsset()
	{
		return "{actor} created asset {item}";
	}

	/// <summary>
	/// Key: "Message.CreateBadge"
	/// English String: "{actor} created the badge {badge}"
	/// </summary>
	public virtual string MessageCreateBadge(string actor, string badge)
	{
		return $"{actor} created the badge {badge}";
	}

	protected virtual string _GetTemplateForMessageCreateBadge()
	{
		return "{actor} created the badge {badge}";
	}

	/// <summary>
	/// Key: "Message.CreateDeveloperProduct"
	/// English String: "{actor} created developer product with id {id}"
	/// </summary>
	public virtual string MessageCreateDeveloperProduct(string actor, string id)
	{
		return $"{actor} created developer product with id {id}";
	}

	protected virtual string _GetTemplateForMessageCreateDeveloperProduct()
	{
		return "{actor} created developer product with id {id}";
	}

	/// <summary>
	/// Key: "Message.CreateEnemy"
	/// English String: "{actor} declared group {group} as an enemy"
	/// </summary>
	public virtual string MessageCreateEnemy(string actor, string group)
	{
		return $"{actor} declared group {group} as an enemy";
	}

	protected virtual string _GetTemplateForMessageCreateEnemy()
	{
		return "{actor} declared group {group} as an enemy";
	}

	/// <summary>
	/// Key: "Message.CreateGamePass"
	/// English String: "{actor} created a Game Pass for {game}: {gamePass}"
	/// </summary>
	public virtual string MessageCreateGamePass(string actor, string game, string gamePass)
	{
		return $"{actor} created a Game Pass for {game}: {gamePass}";
	}

	protected virtual string _GetTemplateForMessageCreateGamePass()
	{
		return "{actor} created a Game Pass for {game}: {gamePass}";
	}

	/// <summary>
	/// Key: "Message.CreateItems"
	/// English String: "{actor} created the group item {item}"
	/// </summary>
	public virtual string MessageCreateItems(string actor, string item)
	{
		return $"{actor} created the group item {item}";
	}

	protected virtual string _GetTemplateForMessageCreateItems()
	{
		return "{actor} created the group item {item}";
	}

	/// <summary>
	/// Key: "Message.DeclineAllyRequest"
	/// English String: "{actor} declined group {group}'s ally request"
	/// </summary>
	public virtual string MessageDeclineAllyRequest(string actor, string group)
	{
		return $"{actor} declined group {group}'s ally request";
	}

	protected virtual string _GetTemplateForMessageDeclineAllyRequest()
	{
		return "{actor} declined group {group}'s ally request";
	}

	/// <summary>
	/// Key: "Message.DeclineJoinRequest"
	/// English String: "{actor} declined user {user}'s join request"
	/// </summary>
	public virtual string MessageDeclineJoinRequest(string actor, string user)
	{
		return $"{actor} declined user {user}'s join request";
	}

	protected virtual string _GetTemplateForMessageDeclineJoinRequest()
	{
		return "{actor} declined user {user}'s join request";
	}

	protected virtual string _GetTemplateForMessageDefaultError()
	{
		return "An error occurred.";
	}

	/// <summary>
	/// Key: "Message.Delete"
	/// English String: "{actor} deleted current group"
	/// </summary>
	public virtual string MessageDelete(string actor)
	{
		return $"{actor} deleted current group";
	}

	protected virtual string _GetTemplateForMessageDelete()
	{
		return "{actor} deleted current group";
	}

	/// <summary>
	/// Key: "Message.DeleteAlly"
	/// English String: "{actor} removed group {group} as an ally"
	/// </summary>
	public virtual string MessageDeleteAlly(string actor, string group)
	{
		return $"{actor} removed group {group} as an ally";
	}

	protected virtual string _GetTemplateForMessageDeleteAlly()
	{
		return "{actor} removed group {group} as an ally";
	}

	/// <summary>
	/// Key: "Message.DeleteEnemy"
	/// English String: "{actor} removed group {group} as an enemy"
	/// </summary>
	public virtual string MessageDeleteEnemy(string actor, string group)
	{
		return $"{actor} removed group {group} as an enemy";
	}

	protected virtual string _GetTemplateForMessageDeleteEnemy()
	{
		return "{actor} removed group {group} as an enemy";
	}

	/// <summary>
	/// Key: "Message.DeleteGroupPlace"
	/// English String: "{actor} removed game {game} as a group game"
	/// </summary>
	public virtual string MessageDeleteGroupPlace(string actor, string game)
	{
		return $"{actor} removed game {game} as a group game";
	}

	protected virtual string _GetTemplateForMessageDeleteGroupPlace()
	{
		return "{actor} removed game {game} as a group game";
	}

	/// <summary>
	/// Key: "Message.DeletePost"
	/// English String: "{actor} deleted post \"{postDesc}\" by user {user}"
	/// </summary>
	public virtual string MessageDeletePost(string actor, string postDesc, string user)
	{
		return $"{actor} deleted post \"{postDesc}\" by user {user}";
	}

	protected virtual string _GetTemplateForMessageDeletePost()
	{
		return "{actor} deleted post \"{postDesc}\" by user {user}";
	}

	protected virtual string _GetTemplateForMessageDeleteWallPostError()
	{
		return "Unable to delete wall post.";
	}

	protected virtual string _GetTemplateForMessageDeleteWallPostsByUserError()
	{
		return "Unable to delete wall posts by user.";
	}

	protected virtual string _GetTemplateForMessageDeleteWallPostSuccess()
	{
		return "Successfully deleted wall post.";
	}

	protected virtual string _GetTemplateForMessageDescriptionTooLong()
	{
		return "The description is too long.";
	}

	protected virtual string _GetTemplateForMessageDuplicateName()
	{
		return "Name is already taken. Please try another.";
	}

	protected virtual string _GetTemplateForMessageExileUserError()
	{
		return "Unable to exile user.";
	}

	protected virtual string _GetTemplateForMessageFeatureDisabled()
	{
		return "The feature is disabled.";
	}

	protected virtual string _GetTemplateForMessageGetGroupRelationshipsError()
	{
		return "Unable to load group affiliates.";
	}

	protected virtual string _GetTemplateForMessageGroupClosed()
	{
		return "You cannot join a closed group.";
	}

	protected virtual string _GetTemplateForMessageGroupCreationDisabled()
	{
		return "Group creation is currently disabled.";
	}

	protected virtual string _GetTemplateForMessageGroupIconInvalid()
	{
		return "Icon is missing or invalid.";
	}

	/// <summary>
	/// Key: "Message.GroupIconTooLarge"
	/// English String: "Icon cannot be larger than {maxSize} mb."
	/// </summary>
	public virtual string MessageGroupIconTooLarge(string maxSize)
	{
		return $"Icon cannot be larger than {maxSize} mb.";
	}

	protected virtual string _GetTemplateForMessageGroupIconTooLarge()
	{
		return "Icon cannot be larger than {maxSize} mb.";
	}

	protected virtual string _GetTemplateForMessageGroupMembershipsUnavailableError()
	{
		return "The group membership system is temporarily unavailable. Please try again later.";
	}

	protected virtual string _GetTemplateForMessageInsufficientFunds()
	{
		return "Insufficient Robux funds.";
	}

	protected virtual string _GetTemplateForMessageInsufficientGroupSpace()
	{
		return "You are already in the maximum number of groups.";
	}

	protected virtual string _GetTemplateForMessageInsufficientMembership()
	{
		return "You do not have the builders club membership necessary to join this group.";
	}

	protected virtual string _GetTemplateForMessageInsufficientPermission()
	{
		return "Insufficient permissions to complete the request.";
	}

	protected virtual string _GetTemplateForMessageInsufficientPermissionsForRelationships()
	{
		return "You don't have permission to manage this group's relationships.";
	}

	protected virtual string _GetTemplateForMessageInsufficientRobux()
	{
		return "You do not have enough Robux to create the group.";
	}

	protected virtual string _GetTemplateForMessageInvalidAmount()
	{
		return "The amount is invalid.";
	}

	protected virtual string _GetTemplateForMessageInvalidGroup()
	{
		return "Group is invalid or does not exist.";
	}

	protected virtual string _GetTemplateForMessageInvalidGroupIcon()
	{
		return "The group icon is invalid.";
	}

	protected virtual string _GetTemplateForMessageInvalidGroupId()
	{
		return "The group is invalid or does not exist.";
	}

	protected virtual string _GetTemplateForMessageInvalidGroupWallPostId()
	{
		return "The group wall post id is invalid or does not exist.";
	}

	protected virtual string _GetTemplateForMessageInvalidIds()
	{
		return "Ids could not be parsed from request.";
	}

	protected virtual string _GetTemplateForMessageInvalidIdsError()
	{
		return "Ids could not be parsed from request.";
	}

	protected virtual string _GetTemplateForMessageInvalidMembership()
	{
		return "User must have builders club membership.";
	}

	protected virtual string _GetTemplateForMessageInvalidName()
	{
		return "The name is invalid.";
	}

	protected virtual string _GetTemplateForMessageInvalidPaginationParameters()
	{
		return "Invalid or missing pagination parameters.";
	}

	protected virtual string _GetTemplateForMessageInvalidPayoutType()
	{
		return "Invalid payout type.";
	}

	protected virtual string _GetTemplateForMessageInvalidRecipient()
	{
		return "The recipient is invalid.";
	}

	protected virtual string _GetTemplateForMessageInvalidRelationshipType()
	{
		return "Group relationship type is invalid.";
	}

	protected virtual string _GetTemplateForMessageInvalidRoleSetId()
	{
		return "The roleset is invalid or does not exist.";
	}

	protected virtual string _GetTemplateForMessageInvalidUser()
	{
		return "The user is invalid or does not exist.";
	}

	protected virtual string _GetTemplateForMessageInvalidWallPostContent()
	{
		return "Your post was empty, white space, or more than 500 characters.";
	}

	/// <summary>
	/// Key: "Message.InviteToClan"
	/// English String: "{actor} invited user {user} to the clan"
	/// </summary>
	public virtual string MessageInviteToClan(string actor, string user)
	{
		return $"{actor} invited user {user} to the clan";
	}

	protected virtual string _GetTemplateForMessageInviteToClan()
	{
		return "{actor} invited user {user} to the clan";
	}

	protected virtual string _GetTemplateForMessageJoinGroupError()
	{
		return "Unable to join group.";
	}

	protected virtual string _GetTemplateForMessageJoinGroupPendingSuccess()
	{
		return "Requested to join group, your request is pending.";
	}

	protected virtual string _GetTemplateForMessageJoinGroupSuccess()
	{
		return "Successfully joined the group.";
	}

	/// <summary>
	/// Key: "Message.KickFromClan"
	/// English String: "{actor} kicked user {user} out of the clan"
	/// </summary>
	public virtual string MessageKickFromClan(string actor, string user)
	{
		return $"{actor} kicked user {user} out of the clan";
	}

	protected virtual string _GetTemplateForMessageKickFromClan()
	{
		return "{actor} kicked user {user} out of the clan";
	}

	protected virtual string _GetTemplateForMessageLeaveGroupError()
	{
		return "Unable to leave group.";
	}

	protected virtual string _GetTemplateForMessageLoadGroupError()
	{
		return "Unable to load group.";
	}

	protected virtual string _GetTemplateForMessageLoadGroupGamesError()
	{
		return "Unable to load games.";
	}

	protected virtual string _GetTemplateForMessageLoadGroupListError()
	{
		return "Unable to load group list.";
	}

	protected virtual string _GetTemplateForMessageLoadGroupMembershipsError()
	{
		return "Unable to load user membership information.";
	}

	protected virtual string _GetTemplateForMessageLoadGroupMetadataError()
	{
		return "Unable to load group info.";
	}

	protected virtual string _GetTemplateForMessageLoadGroupStoreItemsError()
	{
		return "Unable to load store items.";
	}

	protected virtual string _GetTemplateForMessageLoadUserGroupMembershipError()
	{
		return "Unable to load group member information.";
	}

	protected virtual string _GetTemplateForMessageLoadWallPostsError()
	{
		return "Unable to load wall posts.";
	}

	/// <summary>
	/// Key: "Message.Lock"
	/// English String: "{actor} locked the group"
	/// </summary>
	public virtual string MessageLock(string actor)
	{
		return $"{actor} locked the group";
	}

	protected virtual string _GetTemplateForMessageLock()
	{
		return "{actor} locked the group";
	}

	protected virtual string _GetTemplateForMessageMakePrimaryError()
	{
		return "Unable to make primary group.";
	}

	protected virtual string _GetTemplateForMessageMaxGroups()
	{
		return "User is in maximum number of groups.";
	}

	protected virtual string _GetTemplateForMessageMissingGroupIcon()
	{
		return "The group icon is missing from the request.";
	}

	protected virtual string _GetTemplateForMessageMissingGroupStatusContent()
	{
		return "Missing group status content.";
	}

	protected virtual string _GetTemplateForMessageNameInvalid()
	{
		return "Name is missing or has invalid characters.";
	}

	protected virtual string _GetTemplateForMessageNameModerated()
	{
		return "The name is moderated.";
	}

	protected virtual string _GetTemplateForMessageNameTaken()
	{
		return "The name has been taken.";
	}

	protected virtual string _GetTemplateForMessageNameTooLong()
	{
		return "The name is too long.";
	}

	protected virtual string _GetTemplateForMessageNoPrimary()
	{
		return "The user specified does not have a primary group.";
	}

	protected virtual string _GetTemplateForMessagePassCaptchaToJoin()
	{
		return "You must pass the captcha test before joining this group.";
	}

	protected virtual string _GetTemplateForMessagePassCaptchaToPost()
	{
		return "Captcha must be solved to post to the group wall.";
	}

	/// <summary>
	/// Key: "Message.PostStatus"
	/// English String: "{actor} changed the group status to \"{groupStatus}\""
	/// </summary>
	public virtual string MessagePostStatus(string actor, string groupStatus)
	{
		return $"{actor} changed the group status to \"{groupStatus}\"";
	}

	protected virtual string _GetTemplateForMessagePostStatus()
	{
		return "{actor} changed the group status to \"{groupStatus}\"";
	}

	/// <summary>
	/// Key: "Message.RemoveMember"
	/// English String: "{actor} kicked user {user}"
	/// </summary>
	public virtual string MessageRemoveMember(string actor, string user)
	{
		return $"{actor} kicked user {user}";
	}

	protected virtual string _GetTemplateForMessageRemoveMember()
	{
		return "{actor} kicked user {user}";
	}

	protected virtual string _GetTemplateForMessageRemovePrimaryError()
	{
		return "Unable to remove primary group.";
	}

	/// <summary>
	/// Key: "Message.Rename"
	/// English String: "{actor} renamed current group to {newName}"
	/// </summary>
	public virtual string MessageRename(string actor, string newName)
	{
		return $"{actor} renamed current group to {newName}";
	}

	protected virtual string _GetTemplateForMessageRename()
	{
		return "{actor} renamed current group to {newName}";
	}

	protected virtual string _GetTemplateForMessageSearchTermCharactersLimit()
	{
		return "The search term needs to be between 2 and 50 characters";
	}

	protected virtual string _GetTemplateForMessageSearchTermEmptyError()
	{
		return "Search term is empty";
	}

	protected virtual string _GetTemplateForMessageSearchTermFilteredError()
	{
		return "Search term was filtered";
	}

	/// <summary>
	/// Key: "Message.SendAllyRequest"
	/// English String: "{actor} sent an ally request to group {group}"
	/// </summary>
	public virtual string MessageSendAllyRequest(string actor, string group)
	{
		return $"{actor} sent an ally request to group {group}";
	}

	protected virtual string _GetTemplateForMessageSendAllyRequest()
	{
		return "{actor} sent an ally request to group {group}";
	}

	protected virtual string _GetTemplateForMessageSendGroupShoutError()
	{
		return "Unable to send group shout.";
	}

	protected virtual string _GetTemplateForMessageSendPostError()
	{
		return "Unable to send post.";
	}

	/// <summary>
	/// Key: "Message.SpendGroupFunds"
	/// English String: "{actor} spent {amount} of group funds for: {item}"
	/// </summary>
	public virtual string MessageSpendGroupFunds(string actor, string amount, string item)
	{
		return $"{actor} spent {amount} of group funds for: {item}";
	}

	protected virtual string _GetTemplateForMessageSpendGroupFunds()
	{
		return "{actor} spent {amount} of group funds for: {item}";
	}

	protected virtual string _GetTemplateForMessageTooManyAttempts()
	{
		return "Too many attempts to join the group. Please try again later.";
	}

	protected virtual string _GetTemplateForMessageTooManyAttemptsToClaimGroups()
	{
		return "Too many attempts to claim groups. Please try again later.";
	}

	protected virtual string _GetTemplateForMessageTooManyGroups()
	{
		return "You have reached the group capacity. Please leave a group before creating a new one.";
	}

	protected virtual string _GetTemplateForMessageTooManyIds()
	{
		return "Too many ids in request.";
	}

	protected virtual string _GetTemplateForMessageTooManyPosts()
	{
		return "You are posting too fast, please try again in a few minutes.";
	}

	protected virtual string _GetTemplateForMessageTooManyRequests()
	{
		return "Too many requests.";
	}

	protected virtual string _GetTemplateForMessageUnauthorizedForPostStatus()
	{
		return "You are not authorized to set the status of this group.";
	}

	protected virtual string _GetTemplateForMessageUnauthorizedForViewGroupPayouts()
	{
		return "You don't have permission to view this group's payouts.";
	}

	protected virtual string _GetTemplateForMessageUnauthorizedToClaimGroup()
	{
		return "You are not authorized to claim this group.";
	}

	protected virtual string _GetTemplateForMessageUnauthorizedToManageMember()
	{
		return "You do not have permission to manage this member.";
	}

	protected virtual string _GetTemplateForMessageUnauthorizedToViewRolesetPermissions()
	{
		return "You are not authorized to view permissions for this roleset.";
	}

	protected virtual string _GetTemplateForMessageUnauthorizedToViewWall()
	{
		return "You do not have permission to access this group wall.";
	}

	protected virtual string _GetTemplateForMessageUnknownError()
	{
		return "Unknown error";
	}

	/// <summary>
	/// Key: "Message.Unlock"
	/// English String: "{actor} unlocked the group"
	/// </summary>
	public virtual string MessageUnlock(string actor)
	{
		return $"{actor} unlocked the group";
	}

	protected virtual string _GetTemplateForMessageUnlock()
	{
		return "{actor} unlocked the group";
	}

	/// <summary>
	/// Key: "Message.UpdateAsset"
	/// English String: "{actor} created new version {version} of asset {item}"
	/// </summary>
	public virtual string MessageUpdateAsset(string actor, string version, string item)
	{
		return $"{actor} created new version {version} of asset {item}";
	}

	protected virtual string _GetTemplateForMessageUpdateAsset()
	{
		return "{actor} created new version {version} of asset {item}";
	}

	/// <summary>
	/// Key: "Message.UpdateAssetRevert"
	/// English String: "{actor} reverted asset {item} from version {version} to {oldVersion}"
	/// </summary>
	public virtual string MessageUpdateAssetRevert(string actor, string item, string version, string oldVersion)
	{
		return $"{actor} reverted asset {item} from version {version} to {oldVersion}";
	}

	protected virtual string _GetTemplateForMessageUpdateAssetRevert()
	{
		return "{actor} reverted asset {item} from version {version} to {oldVersion}";
	}

	protected virtual string _GetTemplateForMessageUserNotInGroup()
	{
		return "You aren't a member of the group specified.";
	}
}
