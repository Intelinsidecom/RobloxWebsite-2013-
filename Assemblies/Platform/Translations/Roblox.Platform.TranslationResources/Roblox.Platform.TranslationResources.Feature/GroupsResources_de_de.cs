namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides GroupsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class GroupsResources_de_de : GroupsResources_en_us, IGroupsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.AdvertiseGroup"
	/// English String: "Advertise Group"
	/// </summary>
	public override string ActionAdvertiseGroup => "Gruppe bewerben";

	/// <summary>
	/// Key: "Action.AuditLog"
	/// English String: "Audit Log"
	/// </summary>
	public override string ActionAuditLog => "Prüfungsprotokoll";

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "Abbrechen";

	/// <summary>
	/// Key: "Action.CancelRequest"
	/// English String: "Cancel Request"
	/// </summary>
	public override string ActionCancelRequest => "Anfrage abbrechen";

	/// <summary>
	/// Key: "Action.ClaimOwnership"
	/// English String: "Claim Ownership"
	/// </summary>
	public override string ActionClaimOwnership => "Besitz beanspruchen";

	/// <summary>
	/// Key: "Action.Close"
	/// English String: "Close"
	/// </summary>
	public override string ActionClose => "Schließen";

	/// <summary>
	/// Key: "Action.ConfigureGroup"
	/// English String: "Configure Group"
	/// </summary>
	public override string ActionConfigureGroup => "Gruppe konfigurieren";

	/// <summary>
	/// Key: "Action.CreateGroup"
	/// English String: "Create Group"
	/// </summary>
	public override string ActionCreateGroup => "Gruppe erstellen";

	/// <summary>
	/// Key: "Action.Delete"
	/// English String: "Delete"
	/// </summary>
	public override string ActionDelete => "Löschen";

	/// <summary>
	/// Key: "Action.Exile"
	/// English String: "Exile"
	/// </summary>
	public override string ActionExile => "Verbannen";

	/// <summary>
	/// Key: "Action.ExileUser"
	/// English String: "Exile User"
	/// </summary>
	public override string ActionExileUser => "Benutzer verbannen";

	/// <summary>
	/// Key: "Action.GroupAdmin"
	/// English String: "Group Admin"
	/// </summary>
	public override string ActionGroupAdmin => "Gruppenadministrator";

	/// <summary>
	/// Key: "Action.GroupShout"
	/// Text on the button for sending / posting a group shout
	/// English String: "Group Shout"
	/// </summary>
	public override string ActionGroupShout => "Ruf an die Gruppe";

	/// <summary>
	/// Key: "Action.JoinGroup"
	/// English String: "Join Group"
	/// </summary>
	public override string ActionJoinGroup => "Gruppe beitreten";

	/// <summary>
	/// Key: "Action.LeaveGroup"
	/// English String: "Leave Group"
	/// </summary>
	public override string ActionLeaveGroup => "Gruppe verlassen";

	/// <summary>
	/// Key: "Action.MakePrimary"
	/// English String: "Make Primary"
	/// </summary>
	public override string ActionMakePrimary => "Als Hauptgruppe festlegen";

	/// <summary>
	/// Key: "Action.MakePrimaryGroup"
	/// Set the current group as the users primary group
	/// English String: "Make Primary Group"
	/// </summary>
	public override string ActionMakePrimaryGroup => "Als Hauptgruppe festlegen";

	/// <summary>
	/// Key: "Action.Post"
	/// English String: "Post"
	/// </summary>
	public override string ActionPost => "Posten";

	/// <summary>
	/// Key: "Action.Purchase"
	/// English String: "Purchase"
	/// </summary>
	public override string ActionPurchase => "Kaufen";

	/// <summary>
	/// Key: "Action.RemovePrimary"
	/// English String: "Remove Primary"
	/// </summary>
	public override string ActionRemovePrimary => "Hauptgruppe entfernen";

	/// <summary>
	/// Key: "Action.Report"
	/// English String: "Report"
	/// </summary>
	public override string ActionReport => "Melden";

	/// <summary>
	/// Key: "Action.ReportAbuse"
	/// English String: "Report Abuse"
	/// </summary>
	public override string ActionReportAbuse => "Verstoß melden";

	/// <summary>
	/// Key: "Action.Upgrade"
	/// English String: "Upgrade"
	/// </summary>
	public override string ActionUpgrade => "Aufwerten";

	/// <summary>
	/// Key: "Action.UpgradeToJoin"
	/// English String: "Upgrade to Join"
	/// </summary>
	public override string ActionUpgradeToJoin => "Zum Beitreten aufwerten";

	/// <summary>
	/// Key: "Action.Yes"
	/// English String: "Yes"
	/// </summary>
	public override string ActionYes => "Ja";

	/// <summary>
	/// Key: "Description.ClothingRevenue"
	/// English String: "Groups have the ability to create and sell official shirts, pants, and t-shirts! All revenue goes to group funds."
	/// </summary>
	public override string DescriptionClothingRevenue => "Gruppen können offizielle Hemden, Hosen und T-Shirts erstellen und verkaufen! Alle Einnahmen fließen in das Gruppenguthaben.";

	/// <summary>
	/// Key: "Description.DeleteAllPostsByUser"
	/// English String: "Also delete all posts by this user."
	/// </summary>
	public override string DescriptionDeleteAllPostsByUser => "Damit werden auch alle Posts des Benutzers gelöscht.";

	/// <summary>
	/// Key: "Description.ExileUserWarning"
	/// English String: "Are you sure you want to exile this user?"
	/// </summary>
	public override string DescriptionExileUserWarning => "Möchtest du diesen Benutzer wirklich verbannen?";

	/// <summary>
	/// Key: "Description.LeaveGroupAsOwnerWarning"
	/// English String: "This will leave the group ownerless."
	/// </summary>
	public override string DescriptionLeaveGroupAsOwnerWarning => "Dann hat die Gruppe keinen Besitzer mehr.";

	/// <summary>
	/// Key: "Description.LeaveGroupWarning"
	/// English String: "Are you sure you want to leave this group?"
	/// </summary>
	public override string DescriptionLeaveGroupWarning => "Möchtest du diese Gruppe wirklich verlassen?";

	/// <summary>
	/// Key: "Description.MakePrimaryGroupWarning"
	/// English String: "Are you sure you want to make this your primary group?"
	/// </summary>
	public override string DescriptionMakePrimaryGroupWarning => "Möchtest du diese Gruppe wirklich zur Hauptgruppe machen?";

	/// <summary>
	/// Key: "Description.NoneMaxGroups"
	/// English String: "Upgrade to Builders Club to join more groups."
	/// </summary>
	public override string DescriptionNoneMaxGroups => "Werte auf den Builders Club auf, um mehr Gruppen beizutreten.";

	/// <summary>
	/// Key: "Description.NoneMaxGroupsPremium"
	/// English String: "Upgrade to Roblox Premium to join more groups."
	/// </summary>
	public override string DescriptionNoneMaxGroupsPremium => "Werte auf Roblox Premium auf, um mehr Gruppen beizutreten.";

	/// <summary>
	/// Key: "Description.noneMaxGroupsPremiumText"
	/// English String: "Upgrade to Roblox Premium to join more groups."
	/// </summary>
	public override string DescriptionnoneMaxGroupsPremiumText => "Werte auf Roblox Premium auf, um mehr Gruppen beizutreten.";

	/// <summary>
	/// Key: "Description.ObcMaxGroups"
	/// English String: "You have joined the maximum number of groups."
	/// </summary>
	public override string DescriptionObcMaxGroups => "Du bist der maximalen Anzahl an Gruppen beigetreten.";

	/// <summary>
	/// Key: "Description.OtherBcMaxGroups"
	/// English String: "Upgrade your Builders Club to join more groups."
	/// </summary>
	public override string DescriptionOtherBcMaxGroups => "Werte deinen Builders Club auf, um mehr Gruppen beizutreten.";

	/// <summary>
	/// Key: "Description.otherPremiumMaxGroupsText"
	/// English String: "Upgrade your Roblox Premium to join more groups."
	/// </summary>
	public override string DescriptionotherPremiumMaxGroupsText => "Werte auf Roblox Premium auf, um mehr Gruppen beizutreten.";

	/// <summary>
	/// Key: "Description.PremiumMaxGroups"
	/// English String: "You have joined the maximum number of groups."
	/// </summary>
	public override string DescriptionPremiumMaxGroups => "Du bist der maximalen Anzahl an Gruppen beigetreten.";

	/// <summary>
	/// Key: "Description.PurchaseBody"
	/// English String: "Would you like to create this group for"
	/// </summary>
	public override string DescriptionPurchaseBody => "Möchtest du diese Gruppe erstellen für einen Preis von";

	/// <summary>
	/// Key: "Description.RemovePrimaryGroupWarning"
	/// English String: "Are you sure you want to remove your primary group?"
	/// </summary>
	public override string DescriptionRemovePrimaryGroupWarning => "Möchtest du deine Hauptgruppe wirklich löschen?";

	/// <summary>
	/// Key: "Description.ReportAbuseDescription"
	/// English String: "What would you like to report?"
	/// </summary>
	public override string DescriptionReportAbuseDescription => "Was möchtest du gerne melden?";

	/// <summary>
	/// Key: "Description.WallPrivacySettings"
	/// English String: "Your privacy settings do not allow you to post to group walls. Click here to adjust these settings."
	/// </summary>
	public override string DescriptionWallPrivacySettings => "Deine Datenschutzeinstellungen erlauben es dir nicht, an Anschlagtafeln von Gruppen zu posten. Klicke hier, um deine Einstellungen anzupassen.";

	/// <summary>
	/// Key: "Heading.About"
	/// English String: "About"
	/// </summary>
	public override string HeadingAbout => "Info";

	/// <summary>
	/// Key: "Heading.Affiliates"
	/// English String: "Affiliates"
	/// </summary>
	public override string HeadingAffiliates => "Partner";

	/// <summary>
	/// Key: "Heading.Allies"
	/// English String: "Allies"
	/// </summary>
	public override string HeadingAllies => "Verbündete";

	/// <summary>
	/// Key: "Heading.Date"
	/// English String: "Date"
	/// </summary>
	public override string HeadingDate => "Datum";

	/// <summary>
	/// Key: "Heading.Description"
	/// English String: "Description"
	/// </summary>
	public override string HeadingDescription => "Beschreibung";

	/// <summary>
	/// Key: "Heading.Enemies"
	/// English String: "Enemies"
	/// </summary>
	public override string HeadingEnemies => "Feinde";

	/// <summary>
	/// Key: "Heading.ExileUserWarning"
	/// English String: "Warning"
	/// </summary>
	public override string HeadingExileUserWarning => "Warnung";

	/// <summary>
	/// Key: "Heading.Funds"
	/// English String: "Funds"
	/// </summary>
	public override string HeadingFunds => "Guthaben";

	/// <summary>
	/// Key: "Heading.Games"
	/// English String: "Games"
	/// </summary>
	public override string HeadingGames => "Spiele";

	/// <summary>
	/// Key: "Heading.GroupPurchase"
	/// English String: "Group Purchase Confirmation"
	/// </summary>
	public override string HeadingGroupPurchase => "Gruppenkauf-Bestätigung";

	/// <summary>
	/// Key: "Heading.GroupShout"
	/// English String: "Group Shout"
	/// </summary>
	public override string HeadingGroupShout => "Ruf an die Gruppe";

	/// <summary>
	/// Key: "Heading.LeaveGroup"
	/// English String: "Leave Group"
	/// </summary>
	public override string HeadingLeaveGroup => "Gruppe verlassen";

	/// <summary>
	/// Key: "Heading.MakePrimaryGroup"
	/// Heading of make primary group modal
	/// English String: "Make Primary Group"
	/// </summary>
	public override string HeadingMakePrimaryGroup => "Als Hauptgruppe festlegen";

	/// <summary>
	/// Key: "Heading.Members"
	/// English String: "Members"
	/// </summary>
	public override string HeadingMembers => "Mitglieder";

	/// <summary>
	/// Key: "Heading.NameOrDescription"
	/// Selection option for what to report when reporting something in a group
	/// English String: "Name or Description"
	/// </summary>
	public override string HeadingNameOrDescription => "Name oder Beschreibung";

	/// <summary>
	/// Key: "Heading.Payouts"
	/// English String: "Payouts"
	/// </summary>
	public override string HeadingPayouts => "Auszahlungen";

	/// <summary>
	/// Key: "Heading.Primary"
	/// English String: "Primary"
	/// </summary>
	public override string HeadingPrimary => "Hauptgruppe";

	/// <summary>
	/// Key: "Heading.Rank"
	/// English String: "Rank"
	/// </summary>
	public override string HeadingRank => "Rang";

	/// <summary>
	/// Key: "Heading.RemovePrimaryGroup"
	/// English String: "Remove Primary Group"
	/// </summary>
	public override string HeadingRemovePrimaryGroup => "Hauptgruppe entfernen";

	/// <summary>
	/// Key: "Heading.Role"
	/// English String: "Role"
	/// </summary>
	public override string HeadingRole => "Rolle";

	/// <summary>
	/// Key: "Heading.Settings"
	/// English String: "Settings"
	/// </summary>
	public override string HeadingSettings => "Einstellungen";

	/// <summary>
	/// Key: "Heading.Shout"
	/// To be displayed above the group shout (the current status for a group set by admins)
	/// English String: "Shout"
	/// </summary>
	public override string HeadingShout => "Ruf";

	/// <summary>
	/// Key: "Heading.Store"
	/// English String: "Store"
	/// </summary>
	public override string HeadingStore => "Shop";

	/// <summary>
	/// Key: "Heading.User"
	/// English String: "User"
	/// </summary>
	public override string HeadingUser => "Nutzer";

	/// <summary>
	/// Key: "Heading.Wall"
	/// English String: "Wall"
	/// </summary>
	public override string HeadingWall => "Anschlagtafel";

	/// <summary>
	/// Key: "Label.Abandon"
	/// English String: "Abandon"
	/// </summary>
	public override string LabelAbandon => "Verlassen";

	/// <summary>
	/// Key: "Label.AcceptAllyRequest"
	/// English String: "Accept Ally Request"
	/// </summary>
	public override string LabelAcceptAllyRequest => "Alliierten-Anfrage annehmen";

	/// <summary>
	/// Key: "Label.AcceptJoinRequest"
	/// English String: "Accept Join Request"
	/// </summary>
	public override string LabelAcceptJoinRequest => "Beitrittsanfrage annehmen";

	/// <summary>
	/// Key: "Label.AddGroupPlace"
	/// English String: "Add Group Place"
	/// </summary>
	public override string LabelAddGroupPlace => "Gruppen-Ort hinzufügen";

	/// <summary>
	/// Key: "Label.AdjustCurrencyAmounts"
	/// English String: "Adjust Currency Amounts"
	/// </summary>
	public override string LabelAdjustCurrencyAmounts => "Währungsbeträge anpassen";

	/// <summary>
	/// Key: "Label.All"
	/// English String: "All"
	/// </summary>
	public override string LabelAll => "Alle";

	/// <summary>
	/// Key: "Label.AnyoneCanJoin"
	/// English String: "Anyone Can Join"
	/// </summary>
	public override string LabelAnyoneCanJoin => "Jeder kann beitreten";

	/// <summary>
	/// Key: "Label.BuyAd"
	/// English String: "Buy Ad"
	/// </summary>
	public override string LabelBuyAd => "Anzeige kaufen";

	/// <summary>
	/// Key: "Label.BuyClan"
	/// English String: "Buy Clan"
	/// </summary>
	public override string LabelBuyClan => "Klan kaufen";

	/// <summary>
	/// Key: "Label.ByOwner"
	/// Prefix to either the owner of the group, or "No One!" if the group has no owner. Could not properly format like By {ownerName} because ownerName is a link in this case
	/// English String: "By"
	/// </summary>
	public override string LabelByOwner => "Von";

	/// <summary>
	/// Key: "Label.CancelClanInvite"
	/// English String: "Cancel Clan Invite"
	/// </summary>
	public override string LabelCancelClanInvite => "Klan-Einladung abbrechen";

	/// <summary>
	/// Key: "Label.ChangeDescription"
	/// English String: "Change Description"
	/// </summary>
	public override string LabelChangeDescription => "Beschreibung ändern";

	/// <summary>
	/// Key: "Label.ChangeOwner"
	/// English String: "Change Owner"
	/// </summary>
	public override string LabelChangeOwner => "Besitzer ändern";

	/// <summary>
	/// Key: "Label.ChangeRank"
	/// English String: "Change Rank"
	/// </summary>
	public override string LabelChangeRank => "Rang ändern";

	/// <summary>
	/// Key: "Label.Claim"
	/// English String: "Claim"
	/// </summary>
	public override string LabelClaim => "Behaupten";

	/// <summary>
	/// Key: "Label.ConfigureBadge"
	/// English String: "Configure Badge"
	/// </summary>
	public override string LabelConfigureBadge => "Abzeichen konfigurieren";

	/// <summary>
	/// Key: "Label.ConfigureGroupAsset"
	/// English String: "Configure Group Asset"
	/// </summary>
	public override string LabelConfigureGroupAsset => "Gruppenobjekt konfigurieren";

	/// <summary>
	/// Key: "Label.ConfigureGroupDevelopmentItem"
	/// English String: "Configure Group Development Item"
	/// </summary>
	public override string LabelConfigureGroupDevelopmentItem => "Gruppenentwicklungselement konfigurieren";

	/// <summary>
	/// Key: "Label.ConfigureGroupGame"
	/// English String: "Configure Group Game"
	/// </summary>
	public override string LabelConfigureGroupGame => "Gruppenspiel konfigurieren";

	/// <summary>
	/// Key: "Label.ConfigureItems"
	/// English String: "Configure Items"
	/// </summary>
	public override string LabelConfigureItems => "Artikel konfigurieren";

	/// <summary>
	/// Key: "Label.CreateBadge"
	/// English String: "Create Badge"
	/// </summary>
	public override string LabelCreateBadge => "Abzeichen erstellen";

	/// <summary>
	/// Key: "Label.CreateEnemy"
	/// English String: "Create Enemy"
	/// </summary>
	public override string LabelCreateEnemy => "Feind erstellen";

	/// <summary>
	/// Key: "Label.CreateGamePass"
	/// English String: "Create Game Pass"
	/// </summary>
	public override string LabelCreateGamePass => "Spielpass erstellen";

	/// <summary>
	/// Key: "Label.CreateGroup"
	/// English String: "Create Group"
	/// </summary>
	public override string LabelCreateGroup => "Gruppe erstellen";

	/// <summary>
	/// Key: "Label.CreateGroupAsset"
	/// English String: "Create Group Asset"
	/// </summary>
	public override string LabelCreateGroupAsset => "Gruppenobjekt erstellen";

	/// <summary>
	/// Key: "Label.CreateGroupBuildersClubTooltip"
	/// English String: "Creating a group requires a Builders Club membership."
	/// </summary>
	public override string LabelCreateGroupBuildersClubTooltip => "Für das Erstellen einer Gruppe wird eine „Builders Club“-Mitgliedschaft benötigt.";

	/// <summary>
	/// Key: "Label.CreateGroupDescription"
	/// English String: "Description (optional)"
	/// </summary>
	public override string LabelCreateGroupDescription => "Beschreibung (optional)";

	/// <summary>
	/// Key: "Label.CreateGroupDeveloperProduct"
	/// English String: "Create Group Developer Product"
	/// </summary>
	public override string LabelCreateGroupDeveloperProduct => "Gruppenentwicklerprodukt erstellen";

	/// <summary>
	/// Key: "Label.CreateGroupEmblem"
	/// English String: "Emblem"
	/// </summary>
	public override string LabelCreateGroupEmblem => "Emblem";

	/// <summary>
	/// Key: "Label.CreateGroupFee"
	/// English String: "Group Creation Fee"
	/// </summary>
	public override string LabelCreateGroupFee => "Gruppenerstellungsgebühr";

	/// <summary>
	/// Key: "Label.CreateGroupName"
	/// English String: "Name your group"
	/// </summary>
	public override string LabelCreateGroupName => "Benenne deine Gruppe";

	/// <summary>
	/// Key: "Label.CreateGroupPremiumTooltip"
	/// English String: "Creating a group requires a Roblox Premium membership."
	/// </summary>
	public override string LabelCreateGroupPremiumTooltip => "Für das Erstellen einer Gruppe wird eine Roblox-Premium-Mitgliedschaft benötigt.";

	/// <summary>
	/// Key: "Label.CreateGroupTooltip"
	/// English String: "Create a new group"
	/// </summary>
	public override string LabelCreateGroupTooltip => "Eine neue Gruppe erstellen";

	/// <summary>
	/// Key: "Label.CreateItems"
	/// English String: "Create Items"
	/// </summary>
	public override string LabelCreateItems => "Artikel erstellen";

	/// <summary>
	/// Key: "Label.DeclineAllyRequest"
	/// English String: "Decline Ally Request"
	/// </summary>
	public override string LabelDeclineAllyRequest => "Alliierten-Anfrage ablehnen";

	/// <summary>
	/// Key: "Label.DeclineJoinRequest"
	/// English String: "Decline Join Request"
	/// </summary>
	public override string LabelDeclineJoinRequest => "Beitrittsanfrage ablehnen";

	/// <summary>
	/// Key: "Label.Delete"
	/// English String: "Delete"
	/// </summary>
	public override string LabelDelete => "Löschen";

	/// <summary>
	/// Key: "Label.DeleteAllPostsByUser"
	/// English String: "Also delete all posts by this user."
	/// </summary>
	public override string LabelDeleteAllPostsByUser => "Damit werden auch alle Posts des Benutzers gelöscht.";

	/// <summary>
	/// Key: "Label.DeleteAlly"
	/// English String: "Delete Ally"
	/// </summary>
	public override string LabelDeleteAlly => "Alliierten löschen";

	/// <summary>
	/// Key: "Label.DeleteEnemy"
	/// English String: "Delete Enemy"
	/// </summary>
	public override string LabelDeleteEnemy => "Feind löschen";

	/// <summary>
	/// Key: "Label.DeleteGroupPlace"
	/// English String: "Delete Group Place"
	/// </summary>
	public override string LabelDeleteGroupPlace => "Gruppen-Ort löschen";

	/// <summary>
	/// Key: "Label.DeletePost"
	/// English String: "Delete Post"
	/// </summary>
	public override string LabelDeletePost => "Beitrag löschen";

	/// <summary>
	/// Key: "Label.Funds"
	/// English String: "Funds"
	/// </summary>
	public override string LabelFunds => "Guthaben";

	/// <summary>
	/// Key: "Label.GroupClosed"
	/// English String: "Group Closed"
	/// </summary>
	public override string LabelGroupClosed => "Gruppe geschlossen";

	/// <summary>
	/// Key: "Label.GroupLocked"
	/// English String: "This group has been locked"
	/// </summary>
	public override string LabelGroupLocked => "Diese Gruppe wurde gesperrt.";

	/// <summary>
	/// Key: "Label.InviteToClan"
	/// English String: "Invite to Clan"
	/// </summary>
	public override string LabelInviteToClan => "Zum Klan einladen";

	/// <summary>
	/// Key: "Label.KickFromClan"
	/// English String: "Kick from Clan"
	/// </summary>
	public override string LabelKickFromClan => "Vom Klan kicken";

	/// <summary>
	/// Key: "Label.Loading"
	/// English String: "Loading..."
	/// </summary>
	public override string LabelLoading => "Wird geladen\u00a0...";

	/// <summary>
	/// Key: "Label.Lock"
	/// English String: "Lock"
	/// </summary>
	public override string LabelLock => "Sperren";

	/// <summary>
	/// Key: "Label.ManageGroupCreations"
	/// English String: "Create or manage group items."
	/// </summary>
	public override string LabelManageGroupCreations => "Erstelle oder verwalte Gruppengegenstände.";

	/// <summary>
	/// Key: "Label.ManualApproval"
	/// English String: "Manual Approval"
	/// </summary>
	public override string LabelManualApproval => "Manuelle Genehmigung";

	/// <summary>
	/// Key: "Label.ModerateDiscussion"
	/// English String: "Moderate Discussion"
	/// </summary>
	public override string LabelModerateDiscussion => "Diskussion moderieren";

	/// <summary>
	/// Key: "Label.NoAllies"
	/// English String: "This group does not have any allies."
	/// </summary>
	public override string LabelNoAllies => "Diese Gruppe hat keine Verbündeten.";

	/// <summary>
	/// Key: "Label.NoEnemies"
	/// English String: "This group does not have any enemies."
	/// </summary>
	public override string LabelNoEnemies => "Diese Gruppe hat keine Feinde.";

	/// <summary>
	/// Key: "Label.NoGames"
	/// English String: "No games are associated with this group."
	/// </summary>
	public override string LabelNoGames => "Mit dieser Gruppe sind keine Spiele verbunden.";

	/// <summary>
	/// Key: "Label.NoMembersInRole"
	/// English String: "No group members are in this role."
	/// </summary>
	public override string LabelNoMembersInRole => "Es gibt keine Gruppenmitglieder in dieser Rolle.";

	/// <summary>
	/// Key: "Label.NoOne"
	/// English String: "No One!"
	/// </summary>
	public override string LabelNoOne => "Niemand!";

	/// <summary>
	/// Key: "Label.NoStoreItems"
	/// English String: "No items are for sale in this group."
	/// </summary>
	public override string LabelNoStoreItems => "In dieser Gruppe stehen keine Artikel zum Verkauf.";

	/// <summary>
	/// Key: "Label.NoWallPosts"
	/// English String: "Nobody has said anything yet..."
	/// </summary>
	public override string LabelNoWallPosts => "Es hat noch niemand etwas gesagt\u00a0...";

	/// <summary>
	/// Key: "Label.OnlyBcCanJoin"
	/// English String: "Only Builders Club members can join"
	/// </summary>
	public override string LabelOnlyBcCanJoin => "Es können nur Mitglieder des Builders Club beitreten.";

	/// <summary>
	/// Key: "Label.OnlyPremiumCanJoin"
	/// English String: "Only users with membership can join"
	/// </summary>
	public override string LabelOnlyPremiumCanJoin => "Nur Benutzer mit einer Mitgliedschaft können beitreten";

	/// <summary>
	/// Key: "Label.PrivateGroup"
	/// If group is invite only
	/// English String: "Private"
	/// </summary>
	public override string LabelPrivateGroup => "Privat";

	/// <summary>
	/// Key: "Label.PublicGroup"
	/// If group is open for anyone to join
	/// English String: "Public"
	/// </summary>
	public override string LabelPublicGroup => "Öffentlich";

	/// <summary>
	/// Key: "Label.PublishPlace"
	/// English String: "Publish Place"
	/// </summary>
	public override string LabelPublishPlace => "Ort veröffentlichen";

	/// <summary>
	/// Key: "Label.RemoveGroupPlace"
	/// English String: "Remove Group Place"
	/// </summary>
	public override string LabelRemoveGroupPlace => "Gruppen-Ort entfernen";

	/// <summary>
	/// Key: "Label.RemoveMember"
	/// English String: "Remove Member"
	/// </summary>
	public override string LabelRemoveMember => "Mitglied entfernen";

	/// <summary>
	/// Key: "Label.Rename"
	/// English String: "Rename"
	/// </summary>
	public override string LabelRename => "Umbenennen";

	/// <summary>
	/// Key: "Label.RevertGroupAsset"
	/// English String: "Revert Group Asset"
	/// </summary>
	public override string LabelRevertGroupAsset => "Gruppenobjekt rückgängig machen";

	/// <summary>
	/// Key: "Label.SavePlace"
	/// English String: "Save Place"
	/// </summary>
	public override string LabelSavePlace => "Ort speichern";

	/// <summary>
	/// Key: "Label.SearchGroups"
	/// English String: "Search All Groups"
	/// </summary>
	public override string LabelSearchGroups => "Alle Gruppen suchen";

	/// <summary>
	/// Key: "Label.SearchUsers"
	/// English String: "Search Users"
	/// </summary>
	public override string LabelSearchUsers => "Benutzer suchen";

	/// <summary>
	/// Key: "Label.SendAllyRequest"
	/// English String: "Send Ally Request"
	/// </summary>
	public override string LabelSendAllyRequest => "Alliierten-Anfrage senden";

	/// <summary>
	/// Key: "Label.ShoutPlaceholder"
	/// English String: "Enter your shout"
	/// </summary>
	public override string LabelShoutPlaceholder => "Gib deinen Ruf ein";

	/// <summary>
	/// Key: "Label.SpendGroupFunds"
	/// English String: "Spend Group Funds"
	/// </summary>
	public override string LabelSpendGroupFunds => "Gruppenguthaben ausgeben";

	/// <summary>
	/// Key: "Label.Success"
	/// English String: "Success"
	/// </summary>
	public override string LabelSuccess => "Erfolg";

	/// <summary>
	/// Key: "Label.Unlock"
	/// English String: "Unlock"
	/// </summary>
	public override string LabelUnlock => "Freischalten";

	/// <summary>
	/// Key: "Label.UpdateGroupAsset"
	/// English String: "Update Group Asset"
	/// </summary>
	public override string LabelUpdateGroupAsset => "Gruppenobjekt aktualisieren";

	/// <summary>
	/// Key: "Label.WallPostPlaceholder"
	/// English String: "Say something..."
	/// </summary>
	public override string LabelWallPostPlaceholder => "Sag etwas\u00a0...";

	/// <summary>
	/// Key: "Label.WallPostsUnavailable"
	/// Displayed in the group wall area when we cannot successfully load wall posts
	/// English String: "Wall posts are temporarily unavailable, please check back later."
	/// </summary>
	public override string LabelWallPostsUnavailable => "Posts sind derzeit nicht verfügbar, bitte versuche es später wieder.";

	/// <summary>
	/// Key: "Label.Warning"
	/// English String: "Warning"
	/// </summary>
	public override string LabelWarning => "Warnung";

	/// <summary>
	/// Key: "Message.AlreadyMember"
	/// English String: "You are already a member of this group."
	/// </summary>
	public override string MessageAlreadyMember => "Du bist dieser Gruppe bereits beigetreten.";

	/// <summary>
	/// Key: "Message.AlreadyRequested"
	/// English String: "You have already requested to join this group."
	/// </summary>
	public override string MessageAlreadyRequested => "Du hast bereits angefragt, dieser Gruppe beizutreten.";

	/// <summary>
	/// Key: "Message.BuildGroupRolesListError"
	/// English String: "Unable to load members for selected role."
	/// </summary>
	public override string MessageBuildGroupRolesListError => "Mitglieder für die gewählte Rolle konnten nicht geladen werden.";

	/// <summary>
	/// Key: "Message.CannotClaimGroupWithOwner"
	/// English String: "This group already has an owner."
	/// </summary>
	public override string MessageCannotClaimGroupWithOwner => "Diese Gruppe hat bereits einen Besitzer.";

	/// <summary>
	/// Key: "Message.ChangeOwnerEmpty"
	/// English String: "There is no owner of the group"
	/// </summary>
	public override string MessageChangeOwnerEmpty => "Diese Gruppe hat keinen Besitzer";

	/// <summary>
	/// Key: "Message.ClaimOwnershipError"
	/// English String: "Unable to claim ownership of group."
	/// </summary>
	public override string MessageClaimOwnershipError => "Der Besitz dieser Gruppe konnte nicht beansprucht werden.";

	/// <summary>
	/// Key: "Message.ClaimOwnershipSuccess"
	/// English String: "Successfully claimed ownership of group."
	/// </summary>
	public override string MessageClaimOwnershipSuccess => "Der Besitz dieser Gruppe wurde beansprucht.";

	/// <summary>
	/// Key: "Message.DefaultError"
	/// English String: "An error occurred."
	/// </summary>
	public override string MessageDefaultError => "Ein Fehler ist aufgetreten.";

	/// <summary>
	/// Key: "Message.DeleteWallPostError"
	/// English String: "Unable to delete wall post."
	/// </summary>
	public override string MessageDeleteWallPostError => "Post konnte nicht gelöscht werden.";

	/// <summary>
	/// Key: "Message.DeleteWallPostsByUserError"
	/// English String: "Unable to delete wall posts by user."
	/// </summary>
	public override string MessageDeleteWallPostsByUserError => "Posts des Benutzers konnten nicht gelöscht werden.";

	/// <summary>
	/// Key: "Message.DeleteWallPostSuccess"
	/// English String: "Successfully deleted wall post."
	/// </summary>
	public override string MessageDeleteWallPostSuccess => "Der Post wurde gelöscht.";

	/// <summary>
	/// Key: "Message.DescriptionTooLong"
	/// English String: "The description is too long."
	/// </summary>
	public override string MessageDescriptionTooLong => "Die Beschreibung ist zu lang.";

	/// <summary>
	/// Key: "Message.DuplicateName"
	/// English String: "Name is already taken. Please try another."
	/// </summary>
	public override string MessageDuplicateName => "Name ist bereits vergeben. Bitte versuch es mit einem anderen.";

	/// <summary>
	/// Key: "Message.ExileUserError"
	/// English String: "Unable to exile user."
	/// </summary>
	public override string MessageExileUserError => "Benutzer konnte nicht verbannt werden.";

	/// <summary>
	/// Key: "Message.FeatureDisabled"
	/// English String: "The feature is disabled."
	/// </summary>
	public override string MessageFeatureDisabled => "Die Funktion ist deaktiviert.";

	/// <summary>
	/// Key: "Message.GetGroupRelationshipsError"
	/// English String: "Unable to load group affiliates."
	/// </summary>
	public override string MessageGetGroupRelationshipsError => "Gruppenpartner konnten nicht geladen werden.";

	/// <summary>
	/// Key: "Message.GroupClosed"
	/// English String: "You cannot join a closed group."
	/// </summary>
	public override string MessageGroupClosed => "Du kannst einer geschlossenen Gruppe nicht beitreten.";

	/// <summary>
	/// Key: "Message.GroupCreationDisabled"
	/// English String: "Group creation is currently disabled."
	/// </summary>
	public override string MessageGroupCreationDisabled => "Gruppen-Erstellung ist derzeit deaktiviert.";

	/// <summary>
	/// Key: "Message.GroupIconInvalid"
	/// English String: "Icon is missing or invalid."
	/// </summary>
	public override string MessageGroupIconInvalid => "Symbol fehlt oder ist ungültig.";

	/// <summary>
	/// Key: "Message.GroupMembershipsUnavailableError"
	/// Error displayed on group details view when the system is in read-only mode for maintenance and you try to perform an action.
	/// English String: "The group membership system is temporarily unavailable. Please try again later."
	/// </summary>
	public override string MessageGroupMembershipsUnavailableError => "Das Gruppenmitgliedschaftssystem ist derzeit nicht verfügbar. Bitte versuche es später erneut.";

	/// <summary>
	/// Key: "Message.InsufficientFunds"
	/// English String: "Insufficient Robux funds."
	/// </summary>
	public override string MessageInsufficientFunds => "Nicht genügend Robux.";

	/// <summary>
	/// Key: "Message.InsufficientGroupSpace"
	/// English String: "You are already in the maximum number of groups."
	/// </summary>
	public override string MessageInsufficientGroupSpace => "Du bist der maximalen Anzahl an Gruppen bereits beigetreten.";

	/// <summary>
	/// Key: "Message.InsufficientMembership"
	/// English String: "You do not have the builders club membership necessary to join this group."
	/// </summary>
	public override string MessageInsufficientMembership => "Du hast nicht die nötige Builders Club Mitgliedschaft, um dieser Gruppe beizutreten.";

	/// <summary>
	/// Key: "Message.InsufficientPermission"
	/// English String: "Insufficient permissions to complete the request."
	/// </summary>
	public override string MessageInsufficientPermission => "Unzureichende Berechtigungen zum Abschließen der Anfrage.";

	/// <summary>
	/// Key: "Message.InsufficientPermissionsForRelationships"
	/// English String: "You don't have permission to manage this group's relationships."
	/// </summary>
	public override string MessageInsufficientPermissionsForRelationships => "Du hast nicht die nötigen Rechte, um die Beziehungen dieser Gruppe zu verwalten.";

	/// <summary>
	/// Key: "Message.InsufficientRobux"
	/// English String: "You do not have enough Robux to create the group."
	/// </summary>
	public override string MessageInsufficientRobux => "Du hast nicht genügend Robux, um die Gruppe zu erstellen.";

	/// <summary>
	/// Key: "Message.InvalidAmount"
	/// English String: "The amount is invalid."
	/// </summary>
	public override string MessageInvalidAmount => "Die Menge ist ungültig.";

	/// <summary>
	/// Key: "Message.InvalidGroup"
	/// English String: "Group is invalid or does not exist."
	/// </summary>
	public override string MessageInvalidGroup => "Gruppe ist ungültig oder existiert nicht.";

	/// <summary>
	/// Key: "Message.InvalidGroupIcon"
	/// English String: "The group icon is invalid."
	/// </summary>
	public override string MessageInvalidGroupIcon => "Das Gruppensymbol ist ungültig.";

	/// <summary>
	/// Key: "Message.InvalidGroupId"
	/// English String: "The group is invalid or does not exist."
	/// </summary>
	public override string MessageInvalidGroupId => "Gruppe ist ungültig oder existiert nicht.";

	/// <summary>
	/// Key: "Message.InvalidGroupWallPostId"
	/// English String: "The group wall post id is invalid or does not exist."
	/// </summary>
	public override string MessageInvalidGroupWallPostId => "Die Gruppen-Wand-Post-ID ist ungültig oder existiert nicht.";

	/// <summary>
	/// Key: "Message.InvalidIds"
	/// English String: "Ids could not be parsed from request."
	/// </summary>
	public override string MessageInvalidIds => "IDs konnten nicht aus der Anfrage analysiert werden.";

	/// <summary>
	/// Key: "Message.InvalidIdsError"
	/// English String: "Ids could not be parsed from request."
	/// </summary>
	public override string MessageInvalidIdsError => "IDs konnten nicht aus der Anfrage analysiert werden.";

	/// <summary>
	/// Key: "Message.InvalidMembership"
	/// English String: "User must have builders club membership."
	/// </summary>
	public override string MessageInvalidMembership => "Benutzer müssen eine Builders-Club-Mitgliedschaft haben.";

	/// <summary>
	/// Key: "Message.InvalidName"
	/// English String: "The name is invalid."
	/// </summary>
	public override string MessageInvalidName => "Der Name ist ungültig.";

	/// <summary>
	/// Key: "Message.InvalidPaginationParameters"
	/// English String: "Invalid or missing pagination parameters."
	/// </summary>
	public override string MessageInvalidPaginationParameters => "Ungültige oder fehlende Paginierung-Parameter.";

	/// <summary>
	/// Key: "Message.InvalidPayoutType"
	/// English String: "Invalid payout type."
	/// </summary>
	public override string MessageInvalidPayoutType => "Ungültige Auszahlungsart.";

	/// <summary>
	/// Key: "Message.InvalidRecipient"
	/// English String: "The recipient is invalid."
	/// </summary>
	public override string MessageInvalidRecipient => "Der Empfänger ist ungültig.";

	/// <summary>
	/// Key: "Message.InvalidRelationshipType"
	/// English String: "Group relationship type is invalid."
	/// </summary>
	public override string MessageInvalidRelationshipType => "Gruppenbeziehungstyp ist ungültig.";

	/// <summary>
	/// Key: "Message.InvalidRoleSetId"
	/// English String: "The roleset is invalid or does not exist."
	/// </summary>
	public override string MessageInvalidRoleSetId => "Diese Rolle ist ungültig oder existiert nicht.";

	/// <summary>
	/// Key: "Message.InvalidUser"
	/// English String: "The user is invalid or does not exist."
	/// </summary>
	public override string MessageInvalidUser => "Benutzer ist ungültig oder existiert nicht.";

	/// <summary>
	/// Key: "Message.InvalidWallPostContent"
	/// English String: "Your post was empty, white space, or more than 500 characters."
	/// </summary>
	public override string MessageInvalidWallPostContent => "Dein Post war leer, beinhaltete Leerzeichen oder war länger als 500 Zeichen.";

	/// <summary>
	/// Key: "Message.JoinGroupError"
	/// English String: "Unable to join group."
	/// </summary>
	public override string MessageJoinGroupError => "Gruppe konnte nicht beigetreten werden.";

	/// <summary>
	/// Key: "Message.JoinGroupPendingSuccess"
	/// English String: "Requested to join group, your request is pending."
	/// </summary>
	public override string MessageJoinGroupPendingSuccess => "Du hast eine Beitrittsanfrage zur Gruppe versendet. Deine Anfrage ist ausstehend.";

	/// <summary>
	/// Key: "Message.JoinGroupSuccess"
	/// English String: "Successfully joined the group."
	/// </summary>
	public override string MessageJoinGroupSuccess => "Du bist der Gruppe beigetreten.";

	/// <summary>
	/// Key: "Message.LeaveGroupError"
	/// English String: "Unable to leave group."
	/// </summary>
	public override string MessageLeaveGroupError => "Gruppe konnte nicht verlassen werden.";

	/// <summary>
	/// Key: "Message.LoadGroupError"
	/// English String: "Unable to load group."
	/// </summary>
	public override string MessageLoadGroupError => "Gruppe konnte nicht geladen werden.";

	/// <summary>
	/// Key: "Message.LoadGroupGamesError"
	/// English String: "Unable to load games."
	/// </summary>
	public override string MessageLoadGroupGamesError => "Spiele konnten nicht geladen werden.";

	/// <summary>
	/// Key: "Message.LoadGroupListError"
	/// English String: "Unable to load group list."
	/// </summary>
	public override string MessageLoadGroupListError => "Gruppenliste konnte nicht geladen werden.";

	/// <summary>
	/// Key: "Message.LoadGroupMembershipsError"
	/// English String: "Unable to load user membership information."
	/// </summary>
	public override string MessageLoadGroupMembershipsError => "Mitgliedschaftsinformation des Benutzers konnte nicht geladen werden.";

	/// <summary>
	/// Key: "Message.LoadGroupMetadataError"
	/// English String: "Unable to load group info."
	/// </summary>
	public override string MessageLoadGroupMetadataError => "Gruppeninformation konnte nicht geladen werden.";

	/// <summary>
	/// Key: "Message.LoadGroupStoreItemsError"
	/// English String: "Unable to load store items."
	/// </summary>
	public override string MessageLoadGroupStoreItemsError => "Shop-Artikel konnte nicht geladen werden.";

	/// <summary>
	/// Key: "Message.LoadUserGroupMembershipError"
	/// English String: "Unable to load group member information."
	/// </summary>
	public override string MessageLoadUserGroupMembershipError => "Information über Gruppenmitglied konnte nicht geladen werden.";

	/// <summary>
	/// Key: "Message.LoadWallPostsError"
	/// English String: "Unable to load wall posts."
	/// </summary>
	public override string MessageLoadWallPostsError => "Posts konnten nicht geladen werden.";

	/// <summary>
	/// Key: "Message.MakePrimaryError"
	/// English String: "Unable to make primary group."
	/// </summary>
	public override string MessageMakePrimaryError => "Gruppe konnte nicht als Hauptgruppe festgelegt werden.";

	/// <summary>
	/// Key: "Message.MaxGroups"
	/// English String: "User is in maximum number of groups."
	/// </summary>
	public override string MessageMaxGroups => "Benutzer ist schon der maximalen Anzahl an Gruppen beigetreten.";

	/// <summary>
	/// Key: "Message.MissingGroupIcon"
	/// English String: "The group icon is missing from the request."
	/// </summary>
	public override string MessageMissingGroupIcon => "Das Gruppensymbol fehlt in der Anfrage.";

	/// <summary>
	/// Key: "Message.MissingGroupStatusContent"
	/// English String: "Missing group status content."
	/// </summary>
	public override string MessageMissingGroupStatusContent => "Fehlende Gruppenstatus-Inhalte.";

	/// <summary>
	/// Key: "Message.NameInvalid"
	/// English String: "Name is missing or has invalid characters."
	/// </summary>
	public override string MessageNameInvalid => "Name fehlt oder hat ungültige Zeichen.";

	/// <summary>
	/// Key: "Message.NameModerated"
	/// English String: "The name is moderated."
	/// </summary>
	public override string MessageNameModerated => "Der Name wird moderiert.";

	/// <summary>
	/// Key: "Message.NameTaken"
	/// English String: "The name has been taken."
	/// </summary>
	public override string MessageNameTaken => "Der Name ist schon vergeben.";

	/// <summary>
	/// Key: "Message.NameTooLong"
	/// English String: "The name is too long."
	/// </summary>
	public override string MessageNameTooLong => "Der Name ist zu lang.";

	/// <summary>
	/// Key: "Message.NoPrimary"
	/// English String: "The user specified does not have a primary group."
	/// </summary>
	public override string MessageNoPrimary => "Der angegebene Benutzer hat keine Primärgruppe.";

	/// <summary>
	/// Key: "Message.PassCaptchaToJoin"
	/// English String: "You must pass the captcha test before joining this group."
	/// </summary>
	public override string MessagePassCaptchaToJoin => "Du musst den Captcha-Test lösen, bevor du dieser Gruppe beitreten kannst.";

	/// <summary>
	/// Key: "Message.PassCaptchaToPost"
	/// English String: "Captcha must be solved to post to the group wall."
	/// </summary>
	public override string MessagePassCaptchaToPost => "Um in der Gruppen-Wand zu posten, musst du zuerst den Captcha-Test lösen.";

	/// <summary>
	/// Key: "Message.RemovePrimaryError"
	/// English String: "Unable to remove primary group."
	/// </summary>
	public override string MessageRemovePrimaryError => "Hauptgruppe konnte nicht entfernt werden.";

	/// <summary>
	/// Key: "Message.SearchTermCharactersLimit"
	/// English String: "The search term needs to be between 2 and 50 characters"
	/// </summary>
	public override string MessageSearchTermCharactersLimit => "Der Suchbegriff muss zwischen 2 und 50 Zeichen enthalten";

	/// <summary>
	/// Key: "Message.SearchTermEmptyError"
	/// English String: "Search term is empty"
	/// </summary>
	public override string MessageSearchTermEmptyError => "Suchbegriff ist leer";

	/// <summary>
	/// Key: "Message.SearchTermFilteredError"
	/// English String: "Search term was filtered"
	/// </summary>
	public override string MessageSearchTermFilteredError => "Suchbegriff wurde gefiltert";

	/// <summary>
	/// Key: "Message.SendGroupShoutError"
	/// English String: "Unable to send group shout."
	/// </summary>
	public override string MessageSendGroupShoutError => "Ruf an die Gruppe konnte nicht gesendet werden.";

	/// <summary>
	/// Key: "Message.SendPostError"
	/// English String: "Unable to send post."
	/// </summary>
	public override string MessageSendPostError => "Post konnte nicht gesendet werden.";

	/// <summary>
	/// Key: "Message.TooManyAttempts"
	/// English String: "Too many attempts to join the group. Please try again later."
	/// </summary>
	public override string MessageTooManyAttempts => "Zu viele Versuche, der Gruppe beizutreten. Bitte versuch es später erneut.";

	/// <summary>
	/// Key: "Message.TooManyAttemptsToClaimGroups"
	/// English String: "Too many attempts to claim groups. Please try again later."
	/// </summary>
	public override string MessageTooManyAttemptsToClaimGroups => "Es gab zu viele Versuche, einer Gruppe beizutreten. Bitte versuch es später erneut.";

	/// <summary>
	/// Key: "Message.TooManyGroups"
	/// English String: "You have reached the group capacity. Please leave a group before creating a new one."
	/// </summary>
	public override string MessageTooManyGroups => "Du hast die Gruppenkapazität erreicht. Bitte verlasse eine Gruppe, bevor du eine neue erstellst.";

	/// <summary>
	/// Key: "Message.TooManyIds"
	/// English String: "Too many ids in request."
	/// </summary>
	public override string MessageTooManyIds => "Anfrage enthält zu viele IDs.";

	/// <summary>
	/// Key: "Message.TooManyPosts"
	/// English String: "You are posting too fast, please try again in a few minutes."
	/// </summary>
	public override string MessageTooManyPosts => "Du postest zu schnell, bitte versuch es in einigen Minuten erneut.";

	/// <summary>
	/// Key: "Message.TooManyRequests"
	/// English String: "Too many requests."
	/// </summary>
	public override string MessageTooManyRequests => "Zu viele Anfragen.";

	/// <summary>
	/// Key: "Message.UnauthorizedForPostStatus"
	/// English String: "You are not authorized to set the status of this group."
	/// </summary>
	public override string MessageUnauthorizedForPostStatus => "Du bist nicht berechtigt, den Status dieser Gruppe zu setzen.";

	/// <summary>
	/// Key: "Message.UnauthorizedForViewGroupPayouts"
	/// English String: "You don't have permission to view this group's payouts."
	/// </summary>
	public override string MessageUnauthorizedForViewGroupPayouts => "Du hast nicht die nötigen Rechte, um die Auszahlungen dieser Gruppe aufzurufen.";

	/// <summary>
	/// Key: "Message.UnauthorizedToClaimGroup"
	/// English String: "You are not authorized to claim this group."
	/// </summary>
	public override string MessageUnauthorizedToClaimGroup => "Du bist nicht berechtigt, diese Gruppe zu behaupten.";

	/// <summary>
	/// Key: "Message.UnauthorizedToManageMember"
	/// English String: "You do not have permission to manage this member."
	/// </summary>
	public override string MessageUnauthorizedToManageMember => "Du hast keine Berechtigung, dieses Mitglied zu verwalten.";

	/// <summary>
	/// Key: "Message.UnauthorizedToViewRolesetPermissions"
	/// English String: "You are not authorized to view permissions for this roleset."
	/// </summary>
	public override string MessageUnauthorizedToViewRolesetPermissions => "Du bist nicht berechtigt, die Berechtigungen für diese Rollen einzusehen.";

	/// <summary>
	/// Key: "Message.UnauthorizedToViewWall"
	/// English String: "You do not have permission to access this group wall."
	/// </summary>
	public override string MessageUnauthorizedToViewWall => "Du hast keine Berechtigung, diese Gruppen-Wand aufzurufen.";

	/// <summary>
	/// Key: "Message.UnknownError"
	/// English String: "Unknown error"
	/// </summary>
	public override string MessageUnknownError => "Unbekannter Fehler";

	/// <summary>
	/// Key: "Message.UserNotInGroup"
	/// English String: "You aren't a member of the group specified."
	/// </summary>
	public override string MessageUserNotInGroup => "Du bist kein Mitglied der angegebenen Gruppe.";

	public GroupsResources_de_de(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAdvertiseGroup()
	{
		return "Gruppe bewerben";
	}

	protected override string _GetTemplateForActionAuditLog()
	{
		return "Prüfungsprotokoll";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "Abbrechen";
	}

	protected override string _GetTemplateForActionCancelRequest()
	{
		return "Anfrage abbrechen";
	}

	protected override string _GetTemplateForActionClaimOwnership()
	{
		return "Besitz beanspruchen";
	}

	protected override string _GetTemplateForActionClose()
	{
		return "Schließen";
	}

	protected override string _GetTemplateForActionConfigureGroup()
	{
		return "Gruppe konfigurieren";
	}

	protected override string _GetTemplateForActionCreateGroup()
	{
		return "Gruppe erstellen";
	}

	protected override string _GetTemplateForActionDelete()
	{
		return "Löschen";
	}

	protected override string _GetTemplateForActionExile()
	{
		return "Verbannen";
	}

	protected override string _GetTemplateForActionExileUser()
	{
		return "Benutzer verbannen";
	}

	protected override string _GetTemplateForActionGroupAdmin()
	{
		return "Gruppenadministrator";
	}

	protected override string _GetTemplateForActionGroupShout()
	{
		return "Ruf an die Gruppe";
	}

	protected override string _GetTemplateForActionJoinGroup()
	{
		return "Gruppe beitreten";
	}

	protected override string _GetTemplateForActionLeaveGroup()
	{
		return "Gruppe verlassen";
	}

	protected override string _GetTemplateForActionMakePrimary()
	{
		return "Als Hauptgruppe festlegen";
	}

	protected override string _GetTemplateForActionMakePrimaryGroup()
	{
		return "Als Hauptgruppe festlegen";
	}

	protected override string _GetTemplateForActionPost()
	{
		return "Posten";
	}

	protected override string _GetTemplateForActionPurchase()
	{
		return "Kaufen";
	}

	protected override string _GetTemplateForActionRemovePrimary()
	{
		return "Hauptgruppe entfernen";
	}

	protected override string _GetTemplateForActionReport()
	{
		return "Melden";
	}

	protected override string _GetTemplateForActionReportAbuse()
	{
		return "Verstoß melden";
	}

	protected override string _GetTemplateForActionUpgrade()
	{
		return "Aufwerten";
	}

	protected override string _GetTemplateForActionUpgradeToJoin()
	{
		return "Zum Beitreten aufwerten";
	}

	protected override string _GetTemplateForActionYes()
	{
		return "Ja";
	}

	protected override string _GetTemplateForDescriptionClothingRevenue()
	{
		return "Gruppen können offizielle Hemden, Hosen und T-Shirts erstellen und verkaufen! Alle Einnahmen fließen in das Gruppenguthaben.";
	}

	protected override string _GetTemplateForDescriptionDeleteAllPostsByUser()
	{
		return "Damit werden auch alle Posts des Benutzers gelöscht.";
	}

	protected override string _GetTemplateForDescriptionExileUserWarning()
	{
		return "Möchtest du diesen Benutzer wirklich verbannen?";
	}

	protected override string _GetTemplateForDescriptionLeaveGroupAsOwnerWarning()
	{
		return "Dann hat die Gruppe keinen Besitzer mehr.";
	}

	protected override string _GetTemplateForDescriptionLeaveGroupWarning()
	{
		return "Möchtest du diese Gruppe wirklich verlassen?";
	}

	protected override string _GetTemplateForDescriptionMakePrimaryGroupWarning()
	{
		return "Möchtest du diese Gruppe wirklich zur Hauptgruppe machen?";
	}

	protected override string _GetTemplateForDescriptionNoneMaxGroups()
	{
		return "Werte auf den Builders Club auf, um mehr Gruppen beizutreten.";
	}

	protected override string _GetTemplateForDescriptionNoneMaxGroupsPremium()
	{
		return "Werte auf Roblox Premium auf, um mehr Gruppen beizutreten.";
	}

	protected override string _GetTemplateForDescriptionnoneMaxGroupsPremiumText()
	{
		return "Werte auf Roblox Premium auf, um mehr Gruppen beizutreten.";
	}

	protected override string _GetTemplateForDescriptionObcMaxGroups()
	{
		return "Du bist der maximalen Anzahl an Gruppen beigetreten.";
	}

	protected override string _GetTemplateForDescriptionOtherBcMaxGroups()
	{
		return "Werte deinen Builders Club auf, um mehr Gruppen beizutreten.";
	}

	protected override string _GetTemplateForDescriptionotherPremiumMaxGroupsText()
	{
		return "Werte auf Roblox Premium auf, um mehr Gruppen beizutreten.";
	}

	protected override string _GetTemplateForDescriptionPremiumMaxGroups()
	{
		return "Du bist der maximalen Anzahl an Gruppen beigetreten.";
	}

	protected override string _GetTemplateForDescriptionPurchaseBody()
	{
		return "Möchtest du diese Gruppe erstellen für einen Preis von";
	}

	protected override string _GetTemplateForDescriptionRemovePrimaryGroupWarning()
	{
		return "Möchtest du deine Hauptgruppe wirklich löschen?";
	}

	protected override string _GetTemplateForDescriptionReportAbuseDescription()
	{
		return "Was möchtest du gerne melden?";
	}

	protected override string _GetTemplateForDescriptionWallPrivacySettings()
	{
		return "Deine Datenschutzeinstellungen erlauben es dir nicht, an Anschlagtafeln von Gruppen zu posten. Klicke hier, um deine Einstellungen anzupassen.";
	}

	protected override string _GetTemplateForHeadingAbout()
	{
		return "Info";
	}

	protected override string _GetTemplateForHeadingAffiliates()
	{
		return "Partner";
	}

	protected override string _GetTemplateForHeadingAllies()
	{
		return "Verbündete";
	}

	/// <summary>
	/// Key: "Heading.ConfigureGroup"
	/// English String: "Configure {groupName}"
	/// </summary>
	public override string HeadingConfigureGroup(string groupName)
	{
		return $"{groupName} konfigurieren";
	}

	protected override string _GetTemplateForHeadingConfigureGroup()
	{
		return "{groupName} konfigurieren";
	}

	protected override string _GetTemplateForHeadingDate()
	{
		return "Datum";
	}

	protected override string _GetTemplateForHeadingDescription()
	{
		return "Beschreibung";
	}

	protected override string _GetTemplateForHeadingEnemies()
	{
		return "Feinde";
	}

	protected override string _GetTemplateForHeadingExileUserWarning()
	{
		return "Warnung";
	}

	protected override string _GetTemplateForHeadingFunds()
	{
		return "Guthaben";
	}

	protected override string _GetTemplateForHeadingGames()
	{
		return "Spiele";
	}

	protected override string _GetTemplateForHeadingGroupPurchase()
	{
		return "Gruppenkauf-Bestätigung";
	}

	protected override string _GetTemplateForHeadingGroupShout()
	{
		return "Ruf an die Gruppe";
	}

	protected override string _GetTemplateForHeadingLeaveGroup()
	{
		return "Gruppe verlassen";
	}

	protected override string _GetTemplateForHeadingMakePrimaryGroup()
	{
		return "Als Hauptgruppe festlegen";
	}

	protected override string _GetTemplateForHeadingMembers()
	{
		return "Mitglieder";
	}

	protected override string _GetTemplateForHeadingNameOrDescription()
	{
		return "Name oder Beschreibung";
	}

	protected override string _GetTemplateForHeadingPayouts()
	{
		return "Auszahlungen";
	}

	protected override string _GetTemplateForHeadingPrimary()
	{
		return "Hauptgruppe";
	}

	protected override string _GetTemplateForHeadingRank()
	{
		return "Rang";
	}

	protected override string _GetTemplateForHeadingRemovePrimaryGroup()
	{
		return "Hauptgruppe entfernen";
	}

	protected override string _GetTemplateForHeadingRole()
	{
		return "Rolle";
	}

	protected override string _GetTemplateForHeadingSettings()
	{
		return "Einstellungen";
	}

	protected override string _GetTemplateForHeadingShout()
	{
		return "Ruf";
	}

	protected override string _GetTemplateForHeadingStore()
	{
		return "Shop";
	}

	protected override string _GetTemplateForHeadingUser()
	{
		return "Nutzer";
	}

	protected override string _GetTemplateForHeadingWall()
	{
		return "Anschlagtafel";
	}

	protected override string _GetTemplateForLabelAbandon()
	{
		return "Verlassen";
	}

	protected override string _GetTemplateForLabelAcceptAllyRequest()
	{
		return "Alliierten-Anfrage annehmen";
	}

	protected override string _GetTemplateForLabelAcceptJoinRequest()
	{
		return "Beitrittsanfrage annehmen";
	}

	protected override string _GetTemplateForLabelAddGroupPlace()
	{
		return "Gruppen-Ort hinzufügen";
	}

	protected override string _GetTemplateForLabelAdjustCurrencyAmounts()
	{
		return "Währungsbeträge anpassen";
	}

	protected override string _GetTemplateForLabelAll()
	{
		return "Alle";
	}

	protected override string _GetTemplateForLabelAnyoneCanJoin()
	{
		return "Jeder kann beitreten";
	}

	protected override string _GetTemplateForLabelBuyAd()
	{
		return "Anzeige kaufen";
	}

	protected override string _GetTemplateForLabelBuyClan()
	{
		return "Klan kaufen";
	}

	protected override string _GetTemplateForLabelByOwner()
	{
		return "Von";
	}

	protected override string _GetTemplateForLabelCancelClanInvite()
	{
		return "Klan-Einladung abbrechen";
	}

	protected override string _GetTemplateForLabelChangeDescription()
	{
		return "Beschreibung ändern";
	}

	protected override string _GetTemplateForLabelChangeOwner()
	{
		return "Besitzer ändern";
	}

	protected override string _GetTemplateForLabelChangeRank()
	{
		return "Rang ändern";
	}

	protected override string _GetTemplateForLabelClaim()
	{
		return "Behaupten";
	}

	protected override string _GetTemplateForLabelConfigureBadge()
	{
		return "Abzeichen konfigurieren";
	}

	protected override string _GetTemplateForLabelConfigureGroupAsset()
	{
		return "Gruppenobjekt konfigurieren";
	}

	protected override string _GetTemplateForLabelConfigureGroupDevelopmentItem()
	{
		return "Gruppenentwicklungselement konfigurieren";
	}

	protected override string _GetTemplateForLabelConfigureGroupGame()
	{
		return "Gruppenspiel konfigurieren";
	}

	protected override string _GetTemplateForLabelConfigureItems()
	{
		return "Artikel konfigurieren";
	}

	protected override string _GetTemplateForLabelCreateBadge()
	{
		return "Abzeichen erstellen";
	}

	protected override string _GetTemplateForLabelCreateEnemy()
	{
		return "Feind erstellen";
	}

	protected override string _GetTemplateForLabelCreateGamePass()
	{
		return "Spielpass erstellen";
	}

	protected override string _GetTemplateForLabelCreateGroup()
	{
		return "Gruppe erstellen";
	}

	protected override string _GetTemplateForLabelCreateGroupAsset()
	{
		return "Gruppenobjekt erstellen";
	}

	protected override string _GetTemplateForLabelCreateGroupBuildersClubTooltip()
	{
		return "Für das Erstellen einer Gruppe wird eine „Builders Club“-Mitgliedschaft benötigt.";
	}

	protected override string _GetTemplateForLabelCreateGroupDescription()
	{
		return "Beschreibung (optional)";
	}

	protected override string _GetTemplateForLabelCreateGroupDeveloperProduct()
	{
		return "Gruppenentwicklerprodukt erstellen";
	}

	protected override string _GetTemplateForLabelCreateGroupEmblem()
	{
		return "Emblem";
	}

	protected override string _GetTemplateForLabelCreateGroupFee()
	{
		return "Gruppenerstellungsgebühr";
	}

	protected override string _GetTemplateForLabelCreateGroupName()
	{
		return "Benenne deine Gruppe";
	}

	protected override string _GetTemplateForLabelCreateGroupPremiumTooltip()
	{
		return "Für das Erstellen einer Gruppe wird eine Roblox-Premium-Mitgliedschaft benötigt.";
	}

	protected override string _GetTemplateForLabelCreateGroupTooltip()
	{
		return "Eine neue Gruppe erstellen";
	}

	protected override string _GetTemplateForLabelCreateItems()
	{
		return "Artikel erstellen";
	}

	protected override string _GetTemplateForLabelDeclineAllyRequest()
	{
		return "Alliierten-Anfrage ablehnen";
	}

	protected override string _GetTemplateForLabelDeclineJoinRequest()
	{
		return "Beitrittsanfrage ablehnen";
	}

	protected override string _GetTemplateForLabelDelete()
	{
		return "Löschen";
	}

	protected override string _GetTemplateForLabelDeleteAllPostsByUser()
	{
		return "Damit werden auch alle Posts des Benutzers gelöscht.";
	}

	protected override string _GetTemplateForLabelDeleteAlly()
	{
		return "Alliierten löschen";
	}

	protected override string _GetTemplateForLabelDeleteEnemy()
	{
		return "Feind löschen";
	}

	protected override string _GetTemplateForLabelDeleteGroupPlace()
	{
		return "Gruppen-Ort löschen";
	}

	protected override string _GetTemplateForLabelDeletePost()
	{
		return "Beitrag löschen";
	}

	protected override string _GetTemplateForLabelFunds()
	{
		return "Guthaben";
	}

	protected override string _GetTemplateForLabelGroupClosed()
	{
		return "Gruppe geschlossen";
	}

	protected override string _GetTemplateForLabelGroupLocked()
	{
		return "Diese Gruppe wurde gesperrt.";
	}

	/// <summary>
	/// Key: "Label.GroupSearchResults"
	/// English String: "Group Results For {searchTerm}"
	/// </summary>
	public override string LabelGroupSearchResults(string searchTerm)
	{
		return $"Gruppenergebnisse für {searchTerm}";
	}

	protected override string _GetTemplateForLabelGroupSearchResults()
	{
		return "Gruppenergebnisse für {searchTerm}";
	}

	protected override string _GetTemplateForLabelInviteToClan()
	{
		return "Zum Klan einladen";
	}

	protected override string _GetTemplateForLabelKickFromClan()
	{
		return "Vom Klan kicken";
	}

	protected override string _GetTemplateForLabelLoading()
	{
		return "Wird geladen\u00a0...";
	}

	protected override string _GetTemplateForLabelLock()
	{
		return "Sperren";
	}

	protected override string _GetTemplateForLabelManageGroupCreations()
	{
		return "Erstelle oder verwalte Gruppengegenstände.";
	}

	protected override string _GetTemplateForLabelManualApproval()
	{
		return "Manuelle Genehmigung";
	}

	/// <summary>
	/// Key: "Label.MaxGroupsTooltip"
	/// English String: "You may only be in a maximum of {maxGroups} groups at one time"
	/// </summary>
	public override string LabelMaxGroupsTooltip(string maxGroups)
	{
		return $"Du kannst maximal in {maxGroups} Gruppen gleichzeitig sein.";
	}

	protected override string _GetTemplateForLabelMaxGroupsTooltip()
	{
		return "Du kannst maximal in {maxGroups} Gruppen gleichzeitig sein.";
	}

	protected override string _GetTemplateForLabelMembers()
	{
		return "{memberCount, plural, =0 {# Mitglieder} =1 {# Mitglied} other {# Mitglieder}}";
	}

	protected override string _GetTemplateForLabelModerateDiscussion()
	{
		return "Diskussion moderieren";
	}

	protected override string _GetTemplateForLabelNoAllies()
	{
		return "Diese Gruppe hat keine Verbündeten.";
	}

	protected override string _GetTemplateForLabelNoEnemies()
	{
		return "Diese Gruppe hat keine Feinde.";
	}

	protected override string _GetTemplateForLabelNoGames()
	{
		return "Mit dieser Gruppe sind keine Spiele verbunden.";
	}

	protected override string _GetTemplateForLabelNoMembersInRole()
	{
		return "Es gibt keine Gruppenmitglieder in dieser Rolle.";
	}

	protected override string _GetTemplateForLabelNoOne()
	{
		return "Niemand!";
	}

	/// <summary>
	/// Key: "Label.NoResults"
	/// English String: "No results for \"{searchTerm}\""
	/// </summary>
	public override string LabelNoResults(string searchTerm)
	{
		return $"Keine Ergebnisse für „{searchTerm}“";
	}

	protected override string _GetTemplateForLabelNoResults()
	{
		return "Keine Ergebnisse für „{searchTerm}“";
	}

	protected override string _GetTemplateForLabelNoStoreItems()
	{
		return "In dieser Gruppe stehen keine Artikel zum Verkauf.";
	}

	protected override string _GetTemplateForLabelNoWallPosts()
	{
		return "Es hat noch niemand etwas gesagt\u00a0...";
	}

	protected override string _GetTemplateForLabelOnlyBcCanJoin()
	{
		return "Es können nur Mitglieder des Builders Club beitreten.";
	}

	protected override string _GetTemplateForLabelOnlyPremiumCanJoin()
	{
		return "Nur Benutzer mit einer Mitgliedschaft können beitreten";
	}

	protected override string _GetTemplateForLabelPrivateGroup()
	{
		return "Privat";
	}

	protected override string _GetTemplateForLabelPublicGroup()
	{
		return "Öffentlich";
	}

	protected override string _GetTemplateForLabelPublishPlace()
	{
		return "Ort veröffentlichen";
	}

	protected override string _GetTemplateForLabelRemoveGroupPlace()
	{
		return "Gruppen-Ort entfernen";
	}

	protected override string _GetTemplateForLabelRemoveMember()
	{
		return "Mitglied entfernen";
	}

	protected override string _GetTemplateForLabelRename()
	{
		return "Umbenennen";
	}

	protected override string _GetTemplateForLabelRevertGroupAsset()
	{
		return "Gruppenobjekt rückgängig machen";
	}

	protected override string _GetTemplateForLabelSavePlace()
	{
		return "Ort speichern";
	}

	protected override string _GetTemplateForLabelSearchGroups()
	{
		return "Alle Gruppen suchen";
	}

	protected override string _GetTemplateForLabelSearchUsers()
	{
		return "Benutzer suchen";
	}

	protected override string _GetTemplateForLabelSendAllyRequest()
	{
		return "Alliierten-Anfrage senden";
	}

	protected override string _GetTemplateForLabelShoutPlaceholder()
	{
		return "Gib deinen Ruf ein";
	}

	protected override string _GetTemplateForLabelSpendGroupFunds()
	{
		return "Gruppenguthaben ausgeben";
	}

	protected override string _GetTemplateForLabelSuccess()
	{
		return "Erfolg";
	}

	protected override string _GetTemplateForLabelUnlock()
	{
		return "Freischalten";
	}

	protected override string _GetTemplateForLabelUpdateGroupAsset()
	{
		return "Gruppenobjekt aktualisieren";
	}

	protected override string _GetTemplateForLabelWallPostPlaceholder()
	{
		return "Sag etwas\u00a0...";
	}

	protected override string _GetTemplateForLabelWallPostsUnavailable()
	{
		return "Posts sind derzeit nicht verfügbar, bitte versuche es später wieder.";
	}

	protected override string _GetTemplateForLabelWarning()
	{
		return "Warnung";
	}

	/// <summary>
	/// Key: "Message.Abandon"
	/// English String: "{actor} (group owner) abandoned the group"
	/// </summary>
	public override string MessageAbandon(string actor)
	{
		return $"{actor} (Gruppenbesitzer) hat die Gruppe verlassen";
	}

	protected override string _GetTemplateForMessageAbandon()
	{
		return "{actor} (Gruppenbesitzer) hat die Gruppe verlassen";
	}

	/// <summary>
	/// Key: "Message.AcceptAllyRequest"
	/// English String: "{actor} accepted group {group}'s ally request"
	/// </summary>
	public override string MessageAcceptAllyRequest(string actor, string group)
	{
		return $"{actor} hat die Alliierten-Anfrage von der {group}-Gruppe angenommen";
	}

	protected override string _GetTemplateForMessageAcceptAllyRequest()
	{
		return "{actor} hat die Alliierten-Anfrage von der {group}-Gruppe angenommen";
	}

	/// <summary>
	/// Key: "Message.AcceptJoinRequest"
	/// English String: "{actor} accepted user {user}'s join request"
	/// </summary>
	public override string MessageAcceptJoinRequest(string actor, string user)
	{
		return $"{actor} hat {user}s Beitrittsanfrage angenommen";
	}

	protected override string _GetTemplateForMessageAcceptJoinRequest()
	{
		return "{actor} hat {user}s Beitrittsanfrage angenommen";
	}

	/// <summary>
	/// Key: "Message.AddGroupPlace"
	/// English String: "{actor} added game {game} as a group game"
	/// </summary>
	public override string MessageAddGroupPlace(string actor, string game)
	{
		return $"{actor} hat das Spiel {game} als Gruppenspiel hinzugefügt";
	}

	protected override string _GetTemplateForMessageAddGroupPlace()
	{
		return "{actor} hat das Spiel {game} als Gruppenspiel hinzugefügt";
	}

	/// <summary>
	/// Key: "Message.AdjustCurrencyAmountsDecreased"
	/// English String: "{actor} decreased group funds by {amount}"
	/// </summary>
	public override string MessageAdjustCurrencyAmountsDecreased(string actor, string amount)
	{
		return $"{actor} hat das Gruppenguthaben um {amount} reduziert";
	}

	protected override string _GetTemplateForMessageAdjustCurrencyAmountsDecreased()
	{
		return "{actor} hat das Gruppenguthaben um {amount} reduziert";
	}

	/// <summary>
	/// Key: "Message.AdjustCurrencyAmountsIncreased"
	/// English String: "{actor} increased group funds by {amount}"
	/// </summary>
	public override string MessageAdjustCurrencyAmountsIncreased(string actor, string amount)
	{
		return $"{actor} hat das Gruppenguthaben um {amount} erhöht";
	}

	protected override string _GetTemplateForMessageAdjustCurrencyAmountsIncreased()
	{
		return "{actor} hat das Gruppenguthaben um {amount} erhöht";
	}

	protected override string _GetTemplateForMessageAlreadyMember()
	{
		return "Du bist dieser Gruppe bereits beigetreten.";
	}

	protected override string _GetTemplateForMessageAlreadyRequested()
	{
		return "Du hast bereits angefragt, dieser Gruppe beizutreten.";
	}

	protected override string _GetTemplateForMessageBuildGroupRolesListError()
	{
		return "Mitglieder für die gewählte Rolle konnten nicht geladen werden.";
	}

	/// <summary>
	/// Key: "Message.BuyAd"
	/// English String: "{actor} bid {bid} on group ad {adName}"
	/// </summary>
	public override string MessageBuyAd(string actor, string bid, string adName)
	{
		return $"{actor} bietet {bid} auf Gruppenanzeige {adName}";
	}

	protected override string _GetTemplateForMessageBuyAd()
	{
		return "{actor} bietet {bid} auf Gruppenanzeige {adName}";
	}

	/// <summary>
	/// Key: "Message.BuyClan"
	/// English String: "{actor} bought a group clan"
	/// </summary>
	public override string MessageBuyClan(string actor)
	{
		return $"{actor} hat einen Gruppenklan gekauft";
	}

	protected override string _GetTemplateForMessageBuyClan()
	{
		return "{actor} hat einen Gruppenklan gekauft";
	}

	/// <summary>
	/// Key: "Message.CancelClanInvite"
	/// English String: "{actor} cancelled {user}'s clan invite"
	/// </summary>
	public override string MessageCancelClanInvite(string actor, string user)
	{
		return $"{actor} hat {user}s Klan-Einladung gelöscht";
	}

	protected override string _GetTemplateForMessageCancelClanInvite()
	{
		return "{actor} hat {user}s Klan-Einladung gelöscht";
	}

	protected override string _GetTemplateForMessageCannotClaimGroupWithOwner()
	{
		return "Diese Gruppe hat bereits einen Besitzer.";
	}

	/// <summary>
	/// Key: "Message.ChangeDescription"
	/// English String: "{actor} changed the description to \"{newDescription}\""
	/// </summary>
	public override string MessageChangeDescription(string actor, string newDescription)
	{
		return $"{actor} hat die Beschreibung in „{newDescription}“ geändert";
	}

	protected override string _GetTemplateForMessageChangeDescription()
	{
		return "{actor} hat die Beschreibung in „{newDescription}“ geändert";
	}

	/// <summary>
	/// Key: "Message.ChangeOwner"
	/// English String: "{actor} changed the group owner. {user} is the new group owner"
	/// </summary>
	public override string MessageChangeOwner(string actor, string user)
	{
		return $"{actor} hat den Gruppenbesitzer geändert. {user} ist der neue Gruppenbesitzer";
	}

	protected override string _GetTemplateForMessageChangeOwner()
	{
		return "{actor} hat den Gruppenbesitzer geändert. {user} ist der neue Gruppenbesitzer";
	}

	protected override string _GetTemplateForMessageChangeOwnerEmpty()
	{
		return "Diese Gruppe hat keinen Besitzer";
	}

	/// <summary>
	/// Key: "Message.ChangeRank"
	/// English String: "{actor} changed user {user}'s rank from {oldRoleSet} to {newRoleSet}"
	/// </summary>
	public override string MessageChangeRank(string actor, string user, string oldRoleSet, string newRoleSet)
	{
		return $"{actor} hat den Rang von Benutzer {user} von {oldRoleSet} in {newRoleSet} geändert";
	}

	protected override string _GetTemplateForMessageChangeRank()
	{
		return "{actor} hat den Rang von Benutzer {user} von {oldRoleSet} in {newRoleSet} geändert";
	}

	/// <summary>
	/// Key: "Message.Claim"
	/// English String: "{actor} claimed ownership of the group"
	/// </summary>
	public override string MessageClaim(string actor)
	{
		return $"{actor} hat das Eigentum an der Gruppe beansprucht";
	}

	protected override string _GetTemplateForMessageClaim()
	{
		return "{actor} hat das Eigentum an der Gruppe beansprucht";
	}

	protected override string _GetTemplateForMessageClaimOwnershipError()
	{
		return "Der Besitz dieser Gruppe konnte nicht beansprucht werden.";
	}

	protected override string _GetTemplateForMessageClaimOwnershipSuccess()
	{
		return "Der Besitz dieser Gruppe wurde beansprucht.";
	}

	/// <summary>
	/// Key: "Message.ConfigureAsset"
	/// English String: "{actor} updated asset {item}: {actions}"
	/// </summary>
	public override string MessageConfigureAsset(string actor, string item, string actions)
	{
		return $"{actor} hat das Objekt {item} aktualisiert: {actions}";
	}

	protected override string _GetTemplateForMessageConfigureAsset()
	{
		return "{actor} hat das Objekt {item} aktualisiert: {actions}";
	}

	/// <summary>
	/// Key: "Message.ConfigureBadgeDisabled"
	/// English String: "{actor} disabled the badge {badge}"
	/// </summary>
	public override string MessageConfigureBadgeDisabled(string actor, string badge)
	{
		return $"{actor} hat das {badge}-Abzeichen deaktiviert";
	}

	protected override string _GetTemplateForMessageConfigureBadgeDisabled()
	{
		return "{actor} hat das {badge}-Abzeichen deaktiviert";
	}

	/// <summary>
	/// Key: "Message.ConfigureBadgeEnabled"
	/// English String: "{actor} enabled the badge {badge}"
	/// </summary>
	public override string MessageConfigureBadgeEnabled(string actor, string badge)
	{
		return $"{actor} hat das {badge}-Abzeichen aktiviert";
	}

	protected override string _GetTemplateForMessageConfigureBadgeEnabled()
	{
		return "{actor} hat das {badge}-Abzeichen aktiviert";
	}

	/// <summary>
	/// Key: "Message.ConfigureBadgeUpdate"
	/// English String: "{actor} configured the badge {badge}"
	/// </summary>
	public override string MessageConfigureBadgeUpdate(string actor, string badge)
	{
		return $"{actor} hat das {badge}-Abzeichen konfiguriert";
	}

	protected override string _GetTemplateForMessageConfigureBadgeUpdate()
	{
		return "{actor} hat das {badge}-Abzeichen konfiguriert";
	}

	/// <summary>
	/// Key: "Message.ConfigureGame"
	/// English String: "{actor} updated {game}: {actions}"
	/// </summary>
	public override string MessageConfigureGame(string actor, string game, string actions)
	{
		return $"{actor} hat das Spiel {game} aktualisiert: {actions}";
	}

	protected override string _GetTemplateForMessageConfigureGame()
	{
		return "{actor} hat das Spiel {game} aktualisiert: {actions}";
	}

	/// <summary>
	/// Key: "Message.ConfigureGameDeveloperProduct"
	/// English String: "{actor} updated developer product {id}: {actions}"
	/// </summary>
	public override string MessageConfigureGameDeveloperProduct(string actor, string id, string actions)
	{
		return $"{actor} hat das Entwicklerprodukt {id} aktualisiert: {actions}";
	}

	protected override string _GetTemplateForMessageConfigureGameDeveloperProduct()
	{
		return "{actor} hat das Entwicklerprodukt {id} aktualisiert: {actions}";
	}

	/// <summary>
	/// Key: "Message.ConfigureItems"
	/// English String: "{actor} configured the group item {item}"
	/// </summary>
	public override string MessageConfigureItems(string actor, string item)
	{
		return $"{actor} hat den Gruppenartikel {item} konfiguriert";
	}

	protected override string _GetTemplateForMessageConfigureItems()
	{
		return "{actor} hat den Gruppenartikel {item} konfiguriert";
	}

	/// <summary>
	/// Key: "Message.CreateAsset"
	/// English String: "{actor} created asset {item}"
	/// </summary>
	public override string MessageCreateAsset(string actor, string item)
	{
		return $"{actor} hat das Objekt {item} erstellt";
	}

	protected override string _GetTemplateForMessageCreateAsset()
	{
		return "{actor} hat das Objekt {item} erstellt";
	}

	/// <summary>
	/// Key: "Message.CreateBadge"
	/// English String: "{actor} created the badge {badge}"
	/// </summary>
	public override string MessageCreateBadge(string actor, string badge)
	{
		return $"{actor} hat das {badge}-Abzeichen erstellt";
	}

	protected override string _GetTemplateForMessageCreateBadge()
	{
		return "{actor} hat das {badge}-Abzeichen erstellt";
	}

	/// <summary>
	/// Key: "Message.CreateDeveloperProduct"
	/// English String: "{actor} created developer product with id {id}"
	/// </summary>
	public override string MessageCreateDeveloperProduct(string actor, string id)
	{
		return $"{actor} hat ein Entwicklerprodukt mit der ID {id} erstellt";
	}

	protected override string _GetTemplateForMessageCreateDeveloperProduct()
	{
		return "{actor} hat ein Entwicklerprodukt mit der ID {id} erstellt";
	}

	/// <summary>
	/// Key: "Message.CreateEnemy"
	/// English String: "{actor} declared group {group} as an enemy"
	/// </summary>
	public override string MessageCreateEnemy(string actor, string group)
	{
		return $"{actor} hat die {group}-Gruppe zum Feind erklärt";
	}

	protected override string _GetTemplateForMessageCreateEnemy()
	{
		return "{actor} hat die {group}-Gruppe zum Feind erklärt";
	}

	/// <summary>
	/// Key: "Message.CreateGamePass"
	/// English String: "{actor} created a Game Pass for {game}: {gamePass}"
	/// </summary>
	public override string MessageCreateGamePass(string actor, string game, string gamePass)
	{
		return $"{actor} hat einen Spielpass für {game}: {gamePass} erstellt";
	}

	protected override string _GetTemplateForMessageCreateGamePass()
	{
		return "{actor} hat einen Spielpass für {game}: {gamePass} erstellt";
	}

	/// <summary>
	/// Key: "Message.CreateItems"
	/// English String: "{actor} created the group item {item}"
	/// </summary>
	public override string MessageCreateItems(string actor, string item)
	{
		return $"{actor} hat den Gruppenartikel {item} erstellt";
	}

	protected override string _GetTemplateForMessageCreateItems()
	{
		return "{actor} hat den Gruppenartikel {item} erstellt";
	}

	/// <summary>
	/// Key: "Message.DeclineAllyRequest"
	/// English String: "{actor} declined group {group}'s ally request"
	/// </summary>
	public override string MessageDeclineAllyRequest(string actor, string group)
	{
		return $"{actor} hat die Alliierten-Anfrage der {group}-Gruppe abgelehnt";
	}

	protected override string _GetTemplateForMessageDeclineAllyRequest()
	{
		return "{actor} hat die Alliierten-Anfrage der {group}-Gruppe abgelehnt";
	}

	/// <summary>
	/// Key: "Message.DeclineJoinRequest"
	/// English String: "{actor} declined user {user}'s join request"
	/// </summary>
	public override string MessageDeclineJoinRequest(string actor, string user)
	{
		return $"{actor} hat {user}s Beitrittsanfrage abgelehent";
	}

	protected override string _GetTemplateForMessageDeclineJoinRequest()
	{
		return "{actor} hat {user}s Beitrittsanfrage abgelehent";
	}

	protected override string _GetTemplateForMessageDefaultError()
	{
		return "Ein Fehler ist aufgetreten.";
	}

	/// <summary>
	/// Key: "Message.Delete"
	/// English String: "{actor} deleted current group"
	/// </summary>
	public override string MessageDelete(string actor)
	{
		return $"{actor} hat die aktuelle Gruppe gelöscht";
	}

	protected override string _GetTemplateForMessageDelete()
	{
		return "{actor} hat die aktuelle Gruppe gelöscht";
	}

	/// <summary>
	/// Key: "Message.DeleteAlly"
	/// English String: "{actor} removed group {group} as an ally"
	/// </summary>
	public override string MessageDeleteAlly(string actor, string group)
	{
		return $"{actor} hat die {group}-Gruppe von den Alliierten entfernt";
	}

	protected override string _GetTemplateForMessageDeleteAlly()
	{
		return "{actor} hat die {group}-Gruppe von den Alliierten entfernt";
	}

	/// <summary>
	/// Key: "Message.DeleteEnemy"
	/// English String: "{actor} removed group {group} as an enemy"
	/// </summary>
	public override string MessageDeleteEnemy(string actor, string group)
	{
		return $"{actor} hat die {group}-Gruppe von den Feinden entfernt";
	}

	protected override string _GetTemplateForMessageDeleteEnemy()
	{
		return "{actor} hat die {group}-Gruppe von den Feinden entfernt";
	}

	/// <summary>
	/// Key: "Message.DeleteGroupPlace"
	/// English String: "{actor} removed game {game} as a group game"
	/// </summary>
	public override string MessageDeleteGroupPlace(string actor, string game)
	{
		return $"{actor} hat das Spiel {game} als Gruppenspiel entfernt";
	}

	protected override string _GetTemplateForMessageDeleteGroupPlace()
	{
		return "{actor} hat das Spiel {game} als Gruppenspiel entfernt";
	}

	/// <summary>
	/// Key: "Message.DeletePost"
	/// English String: "{actor} deleted post \"{postDesc}\" by user {user}"
	/// </summary>
	public override string MessageDeletePost(string actor, string postDesc, string user)
	{
		return $"{actor} hat den Beitrag „{postDesc}“ von {user} gelöscht";
	}

	protected override string _GetTemplateForMessageDeletePost()
	{
		return "{actor} hat den Beitrag „{postDesc}“ von {user} gelöscht";
	}

	protected override string _GetTemplateForMessageDeleteWallPostError()
	{
		return "Post konnte nicht gelöscht werden.";
	}

	protected override string _GetTemplateForMessageDeleteWallPostsByUserError()
	{
		return "Posts des Benutzers konnten nicht gelöscht werden.";
	}

	protected override string _GetTemplateForMessageDeleteWallPostSuccess()
	{
		return "Der Post wurde gelöscht.";
	}

	protected override string _GetTemplateForMessageDescriptionTooLong()
	{
		return "Die Beschreibung ist zu lang.";
	}

	protected override string _GetTemplateForMessageDuplicateName()
	{
		return "Name ist bereits vergeben. Bitte versuch es mit einem anderen.";
	}

	protected override string _GetTemplateForMessageExileUserError()
	{
		return "Benutzer konnte nicht verbannt werden.";
	}

	protected override string _GetTemplateForMessageFeatureDisabled()
	{
		return "Die Funktion ist deaktiviert.";
	}

	protected override string _GetTemplateForMessageGetGroupRelationshipsError()
	{
		return "Gruppenpartner konnten nicht geladen werden.";
	}

	protected override string _GetTemplateForMessageGroupClosed()
	{
		return "Du kannst einer geschlossenen Gruppe nicht beitreten.";
	}

	protected override string _GetTemplateForMessageGroupCreationDisabled()
	{
		return "Gruppen-Erstellung ist derzeit deaktiviert.";
	}

	protected override string _GetTemplateForMessageGroupIconInvalid()
	{
		return "Symbol fehlt oder ist ungültig.";
	}

	/// <summary>
	/// Key: "Message.GroupIconTooLarge"
	/// English String: "Icon cannot be larger than {maxSize} mb."
	/// </summary>
	public override string MessageGroupIconTooLarge(string maxSize)
	{
		return $"Symbol darf nicht größer als {maxSize} MB sein.";
	}

	protected override string _GetTemplateForMessageGroupIconTooLarge()
	{
		return "Symbol darf nicht größer als {maxSize} MB sein.";
	}

	protected override string _GetTemplateForMessageGroupMembershipsUnavailableError()
	{
		return "Das Gruppenmitgliedschaftssystem ist derzeit nicht verfügbar. Bitte versuche es später erneut.";
	}

	protected override string _GetTemplateForMessageInsufficientFunds()
	{
		return "Nicht genügend Robux.";
	}

	protected override string _GetTemplateForMessageInsufficientGroupSpace()
	{
		return "Du bist der maximalen Anzahl an Gruppen bereits beigetreten.";
	}

	protected override string _GetTemplateForMessageInsufficientMembership()
	{
		return "Du hast nicht die nötige Builders Club Mitgliedschaft, um dieser Gruppe beizutreten.";
	}

	protected override string _GetTemplateForMessageInsufficientPermission()
	{
		return "Unzureichende Berechtigungen zum Abschließen der Anfrage.";
	}

	protected override string _GetTemplateForMessageInsufficientPermissionsForRelationships()
	{
		return "Du hast nicht die nötigen Rechte, um die Beziehungen dieser Gruppe zu verwalten.";
	}

	protected override string _GetTemplateForMessageInsufficientRobux()
	{
		return "Du hast nicht genügend Robux, um die Gruppe zu erstellen.";
	}

	protected override string _GetTemplateForMessageInvalidAmount()
	{
		return "Die Menge ist ungültig.";
	}

	protected override string _GetTemplateForMessageInvalidGroup()
	{
		return "Gruppe ist ungültig oder existiert nicht.";
	}

	protected override string _GetTemplateForMessageInvalidGroupIcon()
	{
		return "Das Gruppensymbol ist ungültig.";
	}

	protected override string _GetTemplateForMessageInvalidGroupId()
	{
		return "Gruppe ist ungültig oder existiert nicht.";
	}

	protected override string _GetTemplateForMessageInvalidGroupWallPostId()
	{
		return "Die Gruppen-Wand-Post-ID ist ungültig oder existiert nicht.";
	}

	protected override string _GetTemplateForMessageInvalidIds()
	{
		return "IDs konnten nicht aus der Anfrage analysiert werden.";
	}

	protected override string _GetTemplateForMessageInvalidIdsError()
	{
		return "IDs konnten nicht aus der Anfrage analysiert werden.";
	}

	protected override string _GetTemplateForMessageInvalidMembership()
	{
		return "Benutzer müssen eine Builders-Club-Mitgliedschaft haben.";
	}

	protected override string _GetTemplateForMessageInvalidName()
	{
		return "Der Name ist ungültig.";
	}

	protected override string _GetTemplateForMessageInvalidPaginationParameters()
	{
		return "Ungültige oder fehlende Paginierung-Parameter.";
	}

	protected override string _GetTemplateForMessageInvalidPayoutType()
	{
		return "Ungültige Auszahlungsart.";
	}

	protected override string _GetTemplateForMessageInvalidRecipient()
	{
		return "Der Empfänger ist ungültig.";
	}

	protected override string _GetTemplateForMessageInvalidRelationshipType()
	{
		return "Gruppenbeziehungstyp ist ungültig.";
	}

	protected override string _GetTemplateForMessageInvalidRoleSetId()
	{
		return "Diese Rolle ist ungültig oder existiert nicht.";
	}

	protected override string _GetTemplateForMessageInvalidUser()
	{
		return "Benutzer ist ungültig oder existiert nicht.";
	}

	protected override string _GetTemplateForMessageInvalidWallPostContent()
	{
		return "Dein Post war leer, beinhaltete Leerzeichen oder war länger als 500 Zeichen.";
	}

	/// <summary>
	/// Key: "Message.InviteToClan"
	/// English String: "{actor} invited user {user} to the clan"
	/// </summary>
	public override string MessageInviteToClan(string actor, string user)
	{
		return $"{actor} hat {user} zum Klan eingeladen";
	}

	protected override string _GetTemplateForMessageInviteToClan()
	{
		return "{actor} hat {user} zum Klan eingeladen";
	}

	protected override string _GetTemplateForMessageJoinGroupError()
	{
		return "Gruppe konnte nicht beigetreten werden.";
	}

	protected override string _GetTemplateForMessageJoinGroupPendingSuccess()
	{
		return "Du hast eine Beitrittsanfrage zur Gruppe versendet. Deine Anfrage ist ausstehend.";
	}

	protected override string _GetTemplateForMessageJoinGroupSuccess()
	{
		return "Du bist der Gruppe beigetreten.";
	}

	/// <summary>
	/// Key: "Message.KickFromClan"
	/// English String: "{actor} kicked user {user} out of the clan"
	/// </summary>
	public override string MessageKickFromClan(string actor, string user)
	{
		return $"{actor} hat {user} vom Klan gekickt";
	}

	protected override string _GetTemplateForMessageKickFromClan()
	{
		return "{actor} hat {user} vom Klan gekickt";
	}

	protected override string _GetTemplateForMessageLeaveGroupError()
	{
		return "Gruppe konnte nicht verlassen werden.";
	}

	protected override string _GetTemplateForMessageLoadGroupError()
	{
		return "Gruppe konnte nicht geladen werden.";
	}

	protected override string _GetTemplateForMessageLoadGroupGamesError()
	{
		return "Spiele konnten nicht geladen werden.";
	}

	protected override string _GetTemplateForMessageLoadGroupListError()
	{
		return "Gruppenliste konnte nicht geladen werden.";
	}

	protected override string _GetTemplateForMessageLoadGroupMembershipsError()
	{
		return "Mitgliedschaftsinformation des Benutzers konnte nicht geladen werden.";
	}

	protected override string _GetTemplateForMessageLoadGroupMetadataError()
	{
		return "Gruppeninformation konnte nicht geladen werden.";
	}

	protected override string _GetTemplateForMessageLoadGroupStoreItemsError()
	{
		return "Shop-Artikel konnte nicht geladen werden.";
	}

	protected override string _GetTemplateForMessageLoadUserGroupMembershipError()
	{
		return "Information über Gruppenmitglied konnte nicht geladen werden.";
	}

	protected override string _GetTemplateForMessageLoadWallPostsError()
	{
		return "Posts konnten nicht geladen werden.";
	}

	/// <summary>
	/// Key: "Message.Lock"
	/// English String: "{actor} locked the group"
	/// </summary>
	public override string MessageLock(string actor)
	{
		return $"{actor} hat die Gruppe gesperrt";
	}

	protected override string _GetTemplateForMessageLock()
	{
		return "{actor} hat die Gruppe gesperrt";
	}

	protected override string _GetTemplateForMessageMakePrimaryError()
	{
		return "Gruppe konnte nicht als Hauptgruppe festgelegt werden.";
	}

	protected override string _GetTemplateForMessageMaxGroups()
	{
		return "Benutzer ist schon der maximalen Anzahl an Gruppen beigetreten.";
	}

	protected override string _GetTemplateForMessageMissingGroupIcon()
	{
		return "Das Gruppensymbol fehlt in der Anfrage.";
	}

	protected override string _GetTemplateForMessageMissingGroupStatusContent()
	{
		return "Fehlende Gruppenstatus-Inhalte.";
	}

	protected override string _GetTemplateForMessageNameInvalid()
	{
		return "Name fehlt oder hat ungültige Zeichen.";
	}

	protected override string _GetTemplateForMessageNameModerated()
	{
		return "Der Name wird moderiert.";
	}

	protected override string _GetTemplateForMessageNameTaken()
	{
		return "Der Name ist schon vergeben.";
	}

	protected override string _GetTemplateForMessageNameTooLong()
	{
		return "Der Name ist zu lang.";
	}

	protected override string _GetTemplateForMessageNoPrimary()
	{
		return "Der angegebene Benutzer hat keine Primärgruppe.";
	}

	protected override string _GetTemplateForMessagePassCaptchaToJoin()
	{
		return "Du musst den Captcha-Test lösen, bevor du dieser Gruppe beitreten kannst.";
	}

	protected override string _GetTemplateForMessagePassCaptchaToPost()
	{
		return "Um in der Gruppen-Wand zu posten, musst du zuerst den Captcha-Test lösen.";
	}

	/// <summary>
	/// Key: "Message.PostStatus"
	/// English String: "{actor} changed the group status to \"{groupStatus}\""
	/// </summary>
	public override string MessagePostStatus(string actor, string groupStatus)
	{
		return $"{actor} hat den Gruppenstatus in „{groupStatus}“ geändert";
	}

	protected override string _GetTemplateForMessagePostStatus()
	{
		return "{actor} hat den Gruppenstatus in „{groupStatus}“ geändert";
	}

	/// <summary>
	/// Key: "Message.RemoveMember"
	/// English String: "{actor} kicked user {user}"
	/// </summary>
	public override string MessageRemoveMember(string actor, string user)
	{
		return $"{actor} hat {user} rausgeworfen";
	}

	protected override string _GetTemplateForMessageRemoveMember()
	{
		return "{actor} hat {user} rausgeworfen";
	}

	protected override string _GetTemplateForMessageRemovePrimaryError()
	{
		return "Hauptgruppe konnte nicht entfernt werden.";
	}

	/// <summary>
	/// Key: "Message.Rename"
	/// English String: "{actor} renamed current group to {newName}"
	/// </summary>
	public override string MessageRename(string actor, string newName)
	{
		return $"{actor} hat die aktuelle Gruppe in {newName} umbenannt";
	}

	protected override string _GetTemplateForMessageRename()
	{
		return "{actor} hat die aktuelle Gruppe in {newName} umbenannt";
	}

	protected override string _GetTemplateForMessageSearchTermCharactersLimit()
	{
		return "Der Suchbegriff muss zwischen 2 und 50 Zeichen enthalten";
	}

	protected override string _GetTemplateForMessageSearchTermEmptyError()
	{
		return "Suchbegriff ist leer";
	}

	protected override string _GetTemplateForMessageSearchTermFilteredError()
	{
		return "Suchbegriff wurde gefiltert";
	}

	/// <summary>
	/// Key: "Message.SendAllyRequest"
	/// English String: "{actor} sent an ally request to group {group}"
	/// </summary>
	public override string MessageSendAllyRequest(string actor, string group)
	{
		return $"{actor} hat eine Alliierten-Angrage an {group}-Gruppe gesendet";
	}

	protected override string _GetTemplateForMessageSendAllyRequest()
	{
		return "{actor} hat eine Alliierten-Angrage an {group}-Gruppe gesendet";
	}

	protected override string _GetTemplateForMessageSendGroupShoutError()
	{
		return "Ruf an die Gruppe konnte nicht gesendet werden.";
	}

	protected override string _GetTemplateForMessageSendPostError()
	{
		return "Post konnte nicht gesendet werden.";
	}

	/// <summary>
	/// Key: "Message.SpendGroupFunds"
	/// English String: "{actor} spent {amount} of group funds for: {item}"
	/// </summary>
	public override string MessageSpendGroupFunds(string actor, string amount, string item)
	{
		return $"{actor} hat {amount} vom Gruppenguthaben für: {item} ausgegeben";
	}

	protected override string _GetTemplateForMessageSpendGroupFunds()
	{
		return "{actor} hat {amount} vom Gruppenguthaben für: {item} ausgegeben";
	}

	protected override string _GetTemplateForMessageTooManyAttempts()
	{
		return "Zu viele Versuche, der Gruppe beizutreten. Bitte versuch es später erneut.";
	}

	protected override string _GetTemplateForMessageTooManyAttemptsToClaimGroups()
	{
		return "Es gab zu viele Versuche, einer Gruppe beizutreten. Bitte versuch es später erneut.";
	}

	protected override string _GetTemplateForMessageTooManyGroups()
	{
		return "Du hast die Gruppenkapazität erreicht. Bitte verlasse eine Gruppe, bevor du eine neue erstellst.";
	}

	protected override string _GetTemplateForMessageTooManyIds()
	{
		return "Anfrage enthält zu viele IDs.";
	}

	protected override string _GetTemplateForMessageTooManyPosts()
	{
		return "Du postest zu schnell, bitte versuch es in einigen Minuten erneut.";
	}

	protected override string _GetTemplateForMessageTooManyRequests()
	{
		return "Zu viele Anfragen.";
	}

	protected override string _GetTemplateForMessageUnauthorizedForPostStatus()
	{
		return "Du bist nicht berechtigt, den Status dieser Gruppe zu setzen.";
	}

	protected override string _GetTemplateForMessageUnauthorizedForViewGroupPayouts()
	{
		return "Du hast nicht die nötigen Rechte, um die Auszahlungen dieser Gruppe aufzurufen.";
	}

	protected override string _GetTemplateForMessageUnauthorizedToClaimGroup()
	{
		return "Du bist nicht berechtigt, diese Gruppe zu behaupten.";
	}

	protected override string _GetTemplateForMessageUnauthorizedToManageMember()
	{
		return "Du hast keine Berechtigung, dieses Mitglied zu verwalten.";
	}

	protected override string _GetTemplateForMessageUnauthorizedToViewRolesetPermissions()
	{
		return "Du bist nicht berechtigt, die Berechtigungen für diese Rollen einzusehen.";
	}

	protected override string _GetTemplateForMessageUnauthorizedToViewWall()
	{
		return "Du hast keine Berechtigung, diese Gruppen-Wand aufzurufen.";
	}

	protected override string _GetTemplateForMessageUnknownError()
	{
		return "Unbekannter Fehler";
	}

	/// <summary>
	/// Key: "Message.Unlock"
	/// English String: "{actor} unlocked the group"
	/// </summary>
	public override string MessageUnlock(string actor)
	{
		return $"{actor} hat die Gruppe freigeschaltet";
	}

	protected override string _GetTemplateForMessageUnlock()
	{
		return "{actor} hat die Gruppe freigeschaltet";
	}

	/// <summary>
	/// Key: "Message.UpdateAsset"
	/// English String: "{actor} created new version {version} of asset {item}"
	/// </summary>
	public override string MessageUpdateAsset(string actor, string version, string item)
	{
		return $"{actor} hat die neue Version {version} vom Objekt {item}";
	}

	protected override string _GetTemplateForMessageUpdateAsset()
	{
		return "{actor} hat die neue Version {version} vom Objekt {item}";
	}

	/// <summary>
	/// Key: "Message.UpdateAssetRevert"
	/// English String: "{actor} reverted asset {item} from version {version} to {oldVersion}"
	/// </summary>
	public override string MessageUpdateAssetRevert(string actor, string item, string version, string oldVersion)
	{
		return $"{actor} hat das Objekt {item} von Version {version} auf {oldVersion} zurückgesetzt";
	}

	protected override string _GetTemplateForMessageUpdateAssetRevert()
	{
		return "{actor} hat das Objekt {item} von Version {version} auf {oldVersion} zurückgesetzt";
	}

	protected override string _GetTemplateForMessageUserNotInGroup()
	{
		return "Du bist kein Mitglied der angegebenen Gruppe.";
	}
}
