namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides GroupsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class GroupsResources_fr_fr : GroupsResources_en_us, IGroupsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.AdvertiseGroup"
	/// English String: "Advertise Group"
	/// </summary>
	public override string ActionAdvertiseGroup => "Promouvoir le groupe";

	/// <summary>
	/// Key: "Action.AuditLog"
	/// English String: "Audit Log"
	/// </summary>
	public override string ActionAuditLog => "Journal d'audit";

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "Annuler";

	/// <summary>
	/// Key: "Action.CancelRequest"
	/// English String: "Cancel Request"
	/// </summary>
	public override string ActionCancelRequest => "Annuler la demande";

	/// <summary>
	/// Key: "Action.ClaimOwnership"
	/// English String: "Claim Ownership"
	/// </summary>
	public override string ActionClaimOwnership => "Revendiquer la propriété";

	/// <summary>
	/// Key: "Action.Close"
	/// English String: "Close"
	/// </summary>
	public override string ActionClose => "Fermer";

	/// <summary>
	/// Key: "Action.ConfigureGroup"
	/// English String: "Configure Group"
	/// </summary>
	public override string ActionConfigureGroup => "Configuration du groupe";

	/// <summary>
	/// Key: "Action.CreateGroup"
	/// English String: "Create Group"
	/// </summary>
	public override string ActionCreateGroup => "Créer un groupe";

	/// <summary>
	/// Key: "Action.Delete"
	/// English String: "Delete"
	/// </summary>
	public override string ActionDelete => "Supprimer";

	/// <summary>
	/// Key: "Action.Exile"
	/// English String: "Exile"
	/// </summary>
	public override string ActionExile => "Bannir";

	/// <summary>
	/// Key: "Action.ExileUser"
	/// English String: "Exile User"
	/// </summary>
	public override string ActionExileUser => "Bannir l'utilisateur";

	/// <summary>
	/// Key: "Action.GroupAdmin"
	/// English String: "Group Admin"
	/// </summary>
	public override string ActionGroupAdmin => "Administrateur du groupe";

	/// <summary>
	/// Key: "Action.GroupShout"
	/// Text on the button for sending / posting a group shout
	/// English String: "Group Shout"
	/// </summary>
	public override string ActionGroupShout => "Appel de groupe";

	/// <summary>
	/// Key: "Action.JoinGroup"
	/// English String: "Join Group"
	/// </summary>
	public override string ActionJoinGroup => "Rejoindre le groupe";

	/// <summary>
	/// Key: "Action.LeaveGroup"
	/// English String: "Leave Group"
	/// </summary>
	public override string ActionLeaveGroup => "Quitter le groupe";

	/// <summary>
	/// Key: "Action.MakePrimary"
	/// English String: "Make Primary"
	/// </summary>
	public override string ActionMakePrimary => "Désigner comme groupe principal";

	/// <summary>
	/// Key: "Action.MakePrimaryGroup"
	/// Set the current group as the users primary group
	/// English String: "Make Primary Group"
	/// </summary>
	public override string ActionMakePrimaryGroup => "Désigner comme groupe principal";

	/// <summary>
	/// Key: "Action.Post"
	/// English String: "Post"
	/// </summary>
	public override string ActionPost => "Publier";

	/// <summary>
	/// Key: "Action.Purchase"
	/// English String: "Purchase"
	/// </summary>
	public override string ActionPurchase => "Acheter";

	/// <summary>
	/// Key: "Action.RemovePrimary"
	/// English String: "Remove Primary"
	/// </summary>
	public override string ActionRemovePrimary => "Supprimer le groupe principal";

	/// <summary>
	/// Key: "Action.Report"
	/// English String: "Report"
	/// </summary>
	public override string ActionReport => "Signaler";

	/// <summary>
	/// Key: "Action.ReportAbuse"
	/// English String: "Report Abuse"
	/// </summary>
	public override string ActionReportAbuse => "Signaler une infraction";

	/// <summary>
	/// Key: "Action.Upgrade"
	/// English String: "Upgrade"
	/// </summary>
	public override string ActionUpgrade => "Améliorer";

	/// <summary>
	/// Key: "Action.UpgradeToJoin"
	/// English String: "Upgrade to Join"
	/// </summary>
	public override string ActionUpgradeToJoin => "Améliorer pour rejoindre";

	/// <summary>
	/// Key: "Action.Yes"
	/// English String: "Yes"
	/// </summary>
	public override string ActionYes => "Oui";

	/// <summary>
	/// Key: "Description.ClothingRevenue"
	/// English String: "Groups have the ability to create and sell official shirts, pants, and t-shirts! All revenue goes to group funds."
	/// </summary>
	public override string DescriptionClothingRevenue => "Les groupes peuvent créer et vendre des chemises, des pantalons et des tee-shirts officiels\u00a0! Les recettes sont ajoutées aux fonds du groupe.";

	/// <summary>
	/// Key: "Description.DeleteAllPostsByUser"
	/// English String: "Also delete all posts by this user."
	/// </summary>
	public override string DescriptionDeleteAllPostsByUser => "Effacer également tous les messages de cet utilisateur.";

	/// <summary>
	/// Key: "Description.ExileUserWarning"
	/// English String: "Are you sure you want to exile this user?"
	/// </summary>
	public override string DescriptionExileUserWarning => "Voulez-vous vraiment bannir cet utilisateur\u00a0?";

	/// <summary>
	/// Key: "Description.LeaveGroupAsOwnerWarning"
	/// English String: "This will leave the group ownerless."
	/// </summary>
	public override string DescriptionLeaveGroupAsOwnerWarning => "Ce groupe n'aura plus de propriétaire.";

	/// <summary>
	/// Key: "Description.LeaveGroupWarning"
	/// English String: "Are you sure you want to leave this group?"
	/// </summary>
	public override string DescriptionLeaveGroupWarning => "Voulez-vous vraiment quitter ce groupe\u00a0?";

	/// <summary>
	/// Key: "Description.MakePrimaryGroupWarning"
	/// English String: "Are you sure you want to make this your primary group?"
	/// </summary>
	public override string DescriptionMakePrimaryGroupWarning => "Voulez-vous vraiment faire de ce groupe votre groupe principal\u00a0?";

	/// <summary>
	/// Key: "Description.NoneMaxGroups"
	/// English String: "Upgrade to Builders Club to join more groups."
	/// </summary>
	public override string DescriptionNoneMaxGroups => "Abonnez-vous au Builders Club pour rejoindre plus de groupes.";

	/// <summary>
	/// Key: "Description.NoneMaxGroupsPremium"
	/// English String: "Upgrade to Roblox Premium to join more groups."
	/// </summary>
	public override string DescriptionNoneMaxGroupsPremium => "Abonnez-vous à Roblox Premium pour rejoindre plus de groupes.";

	/// <summary>
	/// Key: "Description.noneMaxGroupsPremiumText"
	/// English String: "Upgrade to Roblox Premium to join more groups."
	/// </summary>
	public override string DescriptionnoneMaxGroupsPremiumText => "Abonnez-vous à Roblox Premium pour rejoindre plus de groupes.";

	/// <summary>
	/// Key: "Description.ObcMaxGroups"
	/// English String: "You have joined the maximum number of groups."
	/// </summary>
	public override string DescriptionObcMaxGroups => "Vous avez rejoint le nombre maximum de groupes autorisés.";

	/// <summary>
	/// Key: "Description.OtherBcMaxGroups"
	/// English String: "Upgrade your Builders Club to join more groups."
	/// </summary>
	public override string DescriptionOtherBcMaxGroups => "Améliorez votre abonnement au Builders Club pour rejoindre plus de groupes.";

	/// <summary>
	/// Key: "Description.otherPremiumMaxGroupsText"
	/// English String: "Upgrade your Roblox Premium to join more groups."
	/// </summary>
	public override string DescriptionotherPremiumMaxGroupsText => "Améliorez votre abonnement à Roblox Premium pour rejoindre plus de groupes.";

	/// <summary>
	/// Key: "Description.PremiumMaxGroups"
	/// English String: "You have joined the maximum number of groups."
	/// </summary>
	public override string DescriptionPremiumMaxGroups => "Vous avez déjà rejoint le nombre maximal de groupes.";

	/// <summary>
	/// Key: "Description.PurchaseBody"
	/// English String: "Would you like to create this group for"
	/// </summary>
	public override string DescriptionPurchaseBody => "Tu voudrais créer ce groupe pour ";

	/// <summary>
	/// Key: "Description.RemovePrimaryGroupWarning"
	/// English String: "Are you sure you want to remove your primary group?"
	/// </summary>
	public override string DescriptionRemovePrimaryGroupWarning => "Voulez-vous vraiment supprimer votre groupe principal\u00a0?";

	/// <summary>
	/// Key: "Description.ReportAbuseDescription"
	/// English String: "What would you like to report?"
	/// </summary>
	public override string DescriptionReportAbuseDescription => "Que veux-tu signaler ?";

	/// <summary>
	/// Key: "Description.WallPrivacySettings"
	/// English String: "Your privacy settings do not allow you to post to group walls. Click here to adjust these settings."
	/// </summary>
	public override string DescriptionWallPrivacySettings => "Vos paramètres de confidentialité ne vous permettent pas de publier des messages sur les murs de groupe. Cliquez ici pour modifier ces paramètres.";

	/// <summary>
	/// Key: "Heading.About"
	/// English String: "About"
	/// </summary>
	public override string HeadingAbout => "À propos";

	/// <summary>
	/// Key: "Heading.Affiliates"
	/// English String: "Affiliates"
	/// </summary>
	public override string HeadingAffiliates => "Affiliés";

	/// <summary>
	/// Key: "Heading.Allies"
	/// English String: "Allies"
	/// </summary>
	public override string HeadingAllies => "Alliés";

	/// <summary>
	/// Key: "Heading.Date"
	/// English String: "Date"
	/// </summary>
	public override string HeadingDate => "Date";

	/// <summary>
	/// Key: "Heading.Description"
	/// English String: "Description"
	/// </summary>
	public override string HeadingDescription => "Description";

	/// <summary>
	/// Key: "Heading.Enemies"
	/// English String: "Enemies"
	/// </summary>
	public override string HeadingEnemies => "Ennemis";

	/// <summary>
	/// Key: "Heading.ExileUserWarning"
	/// English String: "Warning"
	/// </summary>
	public override string HeadingExileUserWarning => "Avertissement";

	/// <summary>
	/// Key: "Heading.Funds"
	/// English String: "Funds"
	/// </summary>
	public override string HeadingFunds => "Fonds";

	/// <summary>
	/// Key: "Heading.Games"
	/// English String: "Games"
	/// </summary>
	public override string HeadingGames => "Jeux";

	/// <summary>
	/// Key: "Heading.GroupPurchase"
	/// English String: "Group Purchase Confirmation"
	/// </summary>
	public override string HeadingGroupPurchase => "Confirmation d'achat de groupe";

	/// <summary>
	/// Key: "Heading.GroupShout"
	/// English String: "Group Shout"
	/// </summary>
	public override string HeadingGroupShout => "Appel de groupe";

	/// <summary>
	/// Key: "Heading.LeaveGroup"
	/// English String: "Leave Group"
	/// </summary>
	public override string HeadingLeaveGroup => "Quitter le groupe";

	/// <summary>
	/// Key: "Heading.MakePrimaryGroup"
	/// Heading of make primary group modal
	/// English String: "Make Primary Group"
	/// </summary>
	public override string HeadingMakePrimaryGroup => "Désigner comme groupe principal";

	/// <summary>
	/// Key: "Heading.Members"
	/// English String: "Members"
	/// </summary>
	public override string HeadingMembers => "Membres";

	/// <summary>
	/// Key: "Heading.NameOrDescription"
	/// Selection option for what to report when reporting something in a group
	/// English String: "Name or Description"
	/// </summary>
	public override string HeadingNameOrDescription => "Nom / Description";

	/// <summary>
	/// Key: "Heading.Payouts"
	/// English String: "Payouts"
	/// </summary>
	public override string HeadingPayouts => "Gains";

	/// <summary>
	/// Key: "Heading.Primary"
	/// English String: "Primary"
	/// </summary>
	public override string HeadingPrimary => "Principal";

	/// <summary>
	/// Key: "Heading.Rank"
	/// English String: "Rank"
	/// </summary>
	public override string HeadingRank => "Rang";

	/// <summary>
	/// Key: "Heading.RemovePrimaryGroup"
	/// English String: "Remove Primary Group"
	/// </summary>
	public override string HeadingRemovePrimaryGroup => "Ne plus désigner comme groupe principal";

	/// <summary>
	/// Key: "Heading.Role"
	/// English String: "Role"
	/// </summary>
	public override string HeadingRole => "Rôle";

	/// <summary>
	/// Key: "Heading.Settings"
	/// English String: "Settings"
	/// </summary>
	public override string HeadingSettings => "Paramètres";

	/// <summary>
	/// Key: "Heading.Shout"
	/// To be displayed above the group shout (the current status for a group set by admins)
	/// English String: "Shout"
	/// </summary>
	public override string HeadingShout => "Appel";

	/// <summary>
	/// Key: "Heading.Store"
	/// English String: "Store"
	/// </summary>
	public override string HeadingStore => "Boutique";

	/// <summary>
	/// Key: "Heading.User"
	/// English String: "User"
	/// </summary>
	public override string HeadingUser => "Utilisateur";

	/// <summary>
	/// Key: "Heading.Wall"
	/// English String: "Wall"
	/// </summary>
	public override string HeadingWall => "Mur";

	/// <summary>
	/// Key: "Label.Abandon"
	/// English String: "Abandon"
	/// </summary>
	public override string LabelAbandon => "Abandonner";

	/// <summary>
	/// Key: "Label.AcceptAllyRequest"
	/// English String: "Accept Ally Request"
	/// </summary>
	public override string LabelAcceptAllyRequest => "Accepter la demande d'alliance";

	/// <summary>
	/// Key: "Label.AcceptJoinRequest"
	/// English String: "Accept Join Request"
	/// </summary>
	public override string LabelAcceptJoinRequest => "Accepter la demande de participation";

	/// <summary>
	/// Key: "Label.AddGroupPlace"
	/// English String: "Add Group Place"
	/// </summary>
	public override string LabelAddGroupPlace => "Ajouter un emplacement de groupe";

	/// <summary>
	/// Key: "Label.AdjustCurrencyAmounts"
	/// English String: "Adjust Currency Amounts"
	/// </summary>
	public override string LabelAdjustCurrencyAmounts => "Modifier les montants de monnaie";

	/// <summary>
	/// Key: "Label.All"
	/// English String: "All"
	/// </summary>
	public override string LabelAll => "Tous";

	/// <summary>
	/// Key: "Label.AnyoneCanJoin"
	/// English String: "Anyone Can Join"
	/// </summary>
	public override string LabelAnyoneCanJoin => "Tout le monde peut rejoindre";

	/// <summary>
	/// Key: "Label.BuyAd"
	/// English String: "Buy Ad"
	/// </summary>
	public override string LabelBuyAd => "Acheter la publicité";

	/// <summary>
	/// Key: "Label.BuyClan"
	/// English String: "Buy Clan"
	/// </summary>
	public override string LabelBuyClan => "Acheter le clan";

	/// <summary>
	/// Key: "Label.ByOwner"
	/// Prefix to either the owner of the group, or "No One!" if the group has no owner. Could not properly format like By {ownerName} because ownerName is a link in this case
	/// English String: "By"
	/// </summary>
	public override string LabelByOwner => "Par";

	/// <summary>
	/// Key: "Label.CancelClanInvite"
	/// English String: "Cancel Clan Invite"
	/// </summary>
	public override string LabelCancelClanInvite => "Annuler l'invitation au clan";

	/// <summary>
	/// Key: "Label.ChangeDescription"
	/// English String: "Change Description"
	/// </summary>
	public override string LabelChangeDescription => "Modifier la description";

	/// <summary>
	/// Key: "Label.ChangeOwner"
	/// English String: "Change Owner"
	/// </summary>
	public override string LabelChangeOwner => "Changer de propriétaire";

	/// <summary>
	/// Key: "Label.ChangeRank"
	/// English String: "Change Rank"
	/// </summary>
	public override string LabelChangeRank => "Modifier le rang";

	/// <summary>
	/// Key: "Label.Claim"
	/// English String: "Claim"
	/// </summary>
	public override string LabelClaim => "Revendiquer";

	/// <summary>
	/// Key: "Label.ConfigureBadge"
	/// English String: "Configure Badge"
	/// </summary>
	public override string LabelConfigureBadge => "Configurer un badge";

	/// <summary>
	/// Key: "Label.ConfigureGroupAsset"
	/// English String: "Configure Group Asset"
	/// </summary>
	public override string LabelConfigureGroupAsset => "Configurer un élément de groupe";

	/// <summary>
	/// Key: "Label.ConfigureGroupDevelopmentItem"
	/// English String: "Configure Group Development Item"
	/// </summary>
	public override string LabelConfigureGroupDevelopmentItem => "Configurer un objet de développement de groupe";

	/// <summary>
	/// Key: "Label.ConfigureGroupGame"
	/// English String: "Configure Group Game"
	/// </summary>
	public override string LabelConfigureGroupGame => "Configurer un jeu de groupe";

	/// <summary>
	/// Key: "Label.ConfigureItems"
	/// English String: "Configure Items"
	/// </summary>
	public override string LabelConfigureItems => "Configurer les objets";

	/// <summary>
	/// Key: "Label.CreateBadge"
	/// English String: "Create Badge"
	/// </summary>
	public override string LabelCreateBadge => "Créer un badge";

	/// <summary>
	/// Key: "Label.CreateEnemy"
	/// English String: "Create Enemy"
	/// </summary>
	public override string LabelCreateEnemy => "Créer un ennemi";

	/// <summary>
	/// Key: "Label.CreateGamePass"
	/// English String: "Create Game Pass"
	/// </summary>
	public override string LabelCreateGamePass => "Créer un passe de jeu";

	/// <summary>
	/// Key: "Label.CreateGroup"
	/// English String: "Create Group"
	/// </summary>
	public override string LabelCreateGroup => "Créer un groupe";

	/// <summary>
	/// Key: "Label.CreateGroupAsset"
	/// English String: "Create Group Asset"
	/// </summary>
	public override string LabelCreateGroupAsset => "Créer un élément de groupe";

	/// <summary>
	/// Key: "Label.CreateGroupBuildersClubTooltip"
	/// English String: "Creating a group requires a Builders Club membership."
	/// </summary>
	public override string LabelCreateGroupBuildersClubTooltip => "Un abonnement au Builders Club est nécessaire pour créer un groupe.";

	/// <summary>
	/// Key: "Label.CreateGroupDescription"
	/// English String: "Description (optional)"
	/// </summary>
	public override string LabelCreateGroupDescription => "Description (optionnel)";

	/// <summary>
	/// Key: "Label.CreateGroupDeveloperProduct"
	/// English String: "Create Group Developer Product"
	/// </summary>
	public override string LabelCreateGroupDeveloperProduct => "Créer un produit développeur de groupe";

	/// <summary>
	/// Key: "Label.CreateGroupEmblem"
	/// English String: "Emblem"
	/// </summary>
	public override string LabelCreateGroupEmblem => "Emblème";

	/// <summary>
	/// Key: "Label.CreateGroupFee"
	/// English String: "Group Creation Fee"
	/// </summary>
	public override string LabelCreateGroupFee => "Taxe de création de groupe";

	/// <summary>
	/// Key: "Label.CreateGroupName"
	/// English String: "Name your group"
	/// </summary>
	public override string LabelCreateGroupName => "Nomme ton groupe";

	/// <summary>
	/// Key: "Label.CreateGroupPremiumTooltip"
	/// English String: "Creating a group requires a Roblox Premium membership."
	/// </summary>
	public override string LabelCreateGroupPremiumTooltip => "La création d'un groupe nécessite un abonnement à Roblox Premium.";

	/// <summary>
	/// Key: "Label.CreateGroupTooltip"
	/// English String: "Create a new group"
	/// </summary>
	public override string LabelCreateGroupTooltip => "Créer un nouveau groupe";

	/// <summary>
	/// Key: "Label.CreateItems"
	/// English String: "Create Items"
	/// </summary>
	public override string LabelCreateItems => "Créer les objets";

	/// <summary>
	/// Key: "Label.DeclineAllyRequest"
	/// English String: "Decline Ally Request"
	/// </summary>
	public override string LabelDeclineAllyRequest => "Refuser la demande d'alliance";

	/// <summary>
	/// Key: "Label.DeclineJoinRequest"
	/// English String: "Decline Join Request"
	/// </summary>
	public override string LabelDeclineJoinRequest => "Refuser la demande de participation";

	/// <summary>
	/// Key: "Label.Delete"
	/// English String: "Delete"
	/// </summary>
	public override string LabelDelete => "Supprimer";

	/// <summary>
	/// Key: "Label.DeleteAllPostsByUser"
	/// English String: "Also delete all posts by this user."
	/// </summary>
	public override string LabelDeleteAllPostsByUser => "Effacer également tous les messages de cet utilisateur.";

	/// <summary>
	/// Key: "Label.DeleteAlly"
	/// English String: "Delete Ally"
	/// </summary>
	public override string LabelDeleteAlly => "Supprimer l'allié";

	/// <summary>
	/// Key: "Label.DeleteEnemy"
	/// English String: "Delete Enemy"
	/// </summary>
	public override string LabelDeleteEnemy => "Supprimer l'ennemi";

	/// <summary>
	/// Key: "Label.DeleteGroupPlace"
	/// English String: "Delete Group Place"
	/// </summary>
	public override string LabelDeleteGroupPlace => "Supprimer l'emplacement de groupe";

	/// <summary>
	/// Key: "Label.DeletePost"
	/// English String: "Delete Post"
	/// </summary>
	public override string LabelDeletePost => "Supprimer le message";

	/// <summary>
	/// Key: "Label.Funds"
	/// English String: "Funds"
	/// </summary>
	public override string LabelFunds => "Fonds";

	/// <summary>
	/// Key: "Label.GroupClosed"
	/// English String: "Group Closed"
	/// </summary>
	public override string LabelGroupClosed => "Groupe fermé";

	/// <summary>
	/// Key: "Label.GroupLocked"
	/// English String: "This group has been locked"
	/// </summary>
	public override string LabelGroupLocked => "Ce groupe a été verrouillé.";

	/// <summary>
	/// Key: "Label.InviteToClan"
	/// English String: "Invite to Clan"
	/// </summary>
	public override string LabelInviteToClan => "Inviter dans le clan";

	/// <summary>
	/// Key: "Label.KickFromClan"
	/// English String: "Kick from Clan"
	/// </summary>
	public override string LabelKickFromClan => "Expulser du clan";

	/// <summary>
	/// Key: "Label.Loading"
	/// English String: "Loading..."
	/// </summary>
	public override string LabelLoading => "Chargement...";

	/// <summary>
	/// Key: "Label.Lock"
	/// English String: "Lock"
	/// </summary>
	public override string LabelLock => "Verrouiller";

	/// <summary>
	/// Key: "Label.ManageGroupCreations"
	/// English String: "Create or manage group items."
	/// </summary>
	public override string LabelManageGroupCreations => "Créer ou gérer les objets du groupe.";

	/// <summary>
	/// Key: "Label.ManualApproval"
	/// English String: "Manual Approval"
	/// </summary>
	public override string LabelManualApproval => "Approbation manuelle";

	/// <summary>
	/// Key: "Label.ModerateDiscussion"
	/// English String: "Moderate Discussion"
	/// </summary>
	public override string LabelModerateDiscussion => "Modérer la discussion";

	/// <summary>
	/// Key: "Label.NoAllies"
	/// English String: "This group does not have any allies."
	/// </summary>
	public override string LabelNoAllies => "Ce groupe n'a pas d'alliés.";

	/// <summary>
	/// Key: "Label.NoEnemies"
	/// English String: "This group does not have any enemies."
	/// </summary>
	public override string LabelNoEnemies => "Ce groupe n'a pas d'ennemis.";

	/// <summary>
	/// Key: "Label.NoGames"
	/// English String: "No games are associated with this group."
	/// </summary>
	public override string LabelNoGames => "Aucun jeu n'est associé à ce groupe.";

	/// <summary>
	/// Key: "Label.NoMembersInRole"
	/// English String: "No group members are in this role."
	/// </summary>
	public override string LabelNoMembersInRole => "Aucun membre du groupe n'occupe ce rôle.";

	/// <summary>
	/// Key: "Label.NoOne"
	/// English String: "No One!"
	/// </summary>
	public override string LabelNoOne => "Personne\u00a0!";

	/// <summary>
	/// Key: "Label.NoStoreItems"
	/// English String: "No items are for sale in this group."
	/// </summary>
	public override string LabelNoStoreItems => "Aucun objet n'est à vendre dans ce groupe.";

	/// <summary>
	/// Key: "Label.NoWallPosts"
	/// English String: "Nobody has said anything yet..."
	/// </summary>
	public override string LabelNoWallPosts => "Personne n'a dit quoi que ce soit pour l'instant...";

	/// <summary>
	/// Key: "Label.OnlyBcCanJoin"
	/// English String: "Only Builders Club members can join"
	/// </summary>
	public override string LabelOnlyBcCanJoin => "Seuls les membres du Builders Club peuvent s'y joindre.";

	/// <summary>
	/// Key: "Label.OnlyPremiumCanJoin"
	/// English String: "Only users with membership can join"
	/// </summary>
	public override string LabelOnlyPremiumCanJoin => "Seuls les membres abonnés peuvent rejoindre";

	/// <summary>
	/// Key: "Label.PrivateGroup"
	/// If group is invite only
	/// English String: "Private"
	/// </summary>
	public override string LabelPrivateGroup => "Privé";

	/// <summary>
	/// Key: "Label.PublicGroup"
	/// If group is open for anyone to join
	/// English String: "Public"
	/// </summary>
	public override string LabelPublicGroup => "Public";

	/// <summary>
	/// Key: "Label.PublishPlace"
	/// English String: "Publish Place"
	/// </summary>
	public override string LabelPublishPlace => "Publier l'emplacement";

	/// <summary>
	/// Key: "Label.RemoveGroupPlace"
	/// English String: "Remove Group Place"
	/// </summary>
	public override string LabelRemoveGroupPlace => "Supprimer l'emplacement de groupe";

	/// <summary>
	/// Key: "Label.RemoveMember"
	/// English String: "Remove Member"
	/// </summary>
	public override string LabelRemoveMember => "Retirer le membre";

	/// <summary>
	/// Key: "Label.Rename"
	/// English String: "Rename"
	/// </summary>
	public override string LabelRename => "Renommer";

	/// <summary>
	/// Key: "Label.RevertGroupAsset"
	/// English String: "Revert Group Asset"
	/// </summary>
	public override string LabelRevertGroupAsset => "Rétrograder un élément de groupe";

	/// <summary>
	/// Key: "Label.SavePlace"
	/// English String: "Save Place"
	/// </summary>
	public override string LabelSavePlace => "Enregistrer l'emplacement";

	/// <summary>
	/// Key: "Label.SearchGroups"
	/// English String: "Search All Groups"
	/// </summary>
	public override string LabelSearchGroups => "Rechercher tous les groupes";

	/// <summary>
	/// Key: "Label.SearchUsers"
	/// English String: "Search Users"
	/// </summary>
	public override string LabelSearchUsers => "Rechercher des utilisateurs";

	/// <summary>
	/// Key: "Label.SendAllyRequest"
	/// English String: "Send Ally Request"
	/// </summary>
	public override string LabelSendAllyRequest => "Envoyer une demande d'alliance";

	/// <summary>
	/// Key: "Label.ShoutPlaceholder"
	/// English String: "Enter your shout"
	/// </summary>
	public override string LabelShoutPlaceholder => "Saisissez votre appel";

	/// <summary>
	/// Key: "Label.SpendGroupFunds"
	/// English String: "Spend Group Funds"
	/// </summary>
	public override string LabelSpendGroupFunds => "Dépenser les fonds du groupe";

	/// <summary>
	/// Key: "Label.Success"
	/// English String: "Success"
	/// </summary>
	public override string LabelSuccess => "Succès";

	/// <summary>
	/// Key: "Label.Unlock"
	/// English String: "Unlock"
	/// </summary>
	public override string LabelUnlock => "Déverrouiller";

	/// <summary>
	/// Key: "Label.UpdateGroupAsset"
	/// English String: "Update Group Asset"
	/// </summary>
	public override string LabelUpdateGroupAsset => "Mettre à jour un élément de groupe";

	/// <summary>
	/// Key: "Label.WallPostPlaceholder"
	/// English String: "Say something..."
	/// </summary>
	public override string LabelWallPostPlaceholder => "Dire quelque chose...";

	/// <summary>
	/// Key: "Label.WallPostsUnavailable"
	/// Displayed in the group wall area when we cannot successfully load wall posts
	/// English String: "Wall posts are temporarily unavailable, please check back later."
	/// </summary>
	public override string LabelWallPostsUnavailable => "Les messages du mur sont indisponibles pour l'instant, veuillez revenir plus tard.";

	/// <summary>
	/// Key: "Label.Warning"
	/// English String: "Warning"
	/// </summary>
	public override string LabelWarning => "Avertissement";

	/// <summary>
	/// Key: "Message.AlreadyMember"
	/// English String: "You are already a member of this group."
	/// </summary>
	public override string MessageAlreadyMember => "Tu fais déjà partie de ce groupe.";

	/// <summary>
	/// Key: "Message.AlreadyRequested"
	/// English String: "You have already requested to join this group."
	/// </summary>
	public override string MessageAlreadyRequested => "Vous avez déjà demandé à rejoindre ce groupe.";

	/// <summary>
	/// Key: "Message.BuildGroupRolesListError"
	/// English String: "Unable to load members for selected role."
	/// </summary>
	public override string MessageBuildGroupRolesListError => "Impossible de charger les membres occupant le rôle sélectionné.";

	/// <summary>
	/// Key: "Message.CannotClaimGroupWithOwner"
	/// English String: "This group already has an owner."
	/// </summary>
	public override string MessageCannotClaimGroupWithOwner => "Ce groupe a déjà un propriétaire.";

	/// <summary>
	/// Key: "Message.ChangeOwnerEmpty"
	/// English String: "There is no owner of the group"
	/// </summary>
	public override string MessageChangeOwnerEmpty => "Ce groupe n'a pas de propriétaire";

	/// <summary>
	/// Key: "Message.ClaimOwnershipError"
	/// English String: "Unable to claim ownership of group."
	/// </summary>
	public override string MessageClaimOwnershipError => "Impossible de revendiquer la propriété du groupe.";

	/// <summary>
	/// Key: "Message.ClaimOwnershipSuccess"
	/// English String: "Successfully claimed ownership of group."
	/// </summary>
	public override string MessageClaimOwnershipSuccess => "La propriété du groupe a bien été revendiquée.";

	/// <summary>
	/// Key: "Message.DefaultError"
	/// English String: "An error occurred."
	/// </summary>
	public override string MessageDefaultError => "Une erreur est survenue.";

	/// <summary>
	/// Key: "Message.DeleteWallPostError"
	/// English String: "Unable to delete wall post."
	/// </summary>
	public override string MessageDeleteWallPostError => "Impossible de supprimer le message du mur.";

	/// <summary>
	/// Key: "Message.DeleteWallPostsByUserError"
	/// English String: "Unable to delete wall posts by user."
	/// </summary>
	public override string MessageDeleteWallPostsByUserError => "Impossible de supprimer les messages ajoutés au mur par l'utilisateur.";

	/// <summary>
	/// Key: "Message.DeleteWallPostSuccess"
	/// English String: "Successfully deleted wall post."
	/// </summary>
	public override string MessageDeleteWallPostSuccess => "Le message du mur a bien été supprimé.";

	/// <summary>
	/// Key: "Message.DescriptionTooLong"
	/// English String: "The description is too long."
	/// </summary>
	public override string MessageDescriptionTooLong => "La description est trop longue.";

	/// <summary>
	/// Key: "Message.DuplicateName"
	/// English String: "Name is already taken. Please try another."
	/// </summary>
	public override string MessageDuplicateName => "Nom déjà utilisé. Essaies-en un autre.";

	/// <summary>
	/// Key: "Message.ExileUserError"
	/// English String: "Unable to exile user."
	/// </summary>
	public override string MessageExileUserError => "Impossible de bannir l'utilisateur.";

	/// <summary>
	/// Key: "Message.FeatureDisabled"
	/// English String: "The feature is disabled."
	/// </summary>
	public override string MessageFeatureDisabled => "Cette fonctionnalité est désactivée.";

	/// <summary>
	/// Key: "Message.GetGroupRelationshipsError"
	/// English String: "Unable to load group affiliates."
	/// </summary>
	public override string MessageGetGroupRelationshipsError => "Impossible de charger les affiliés du groupe.";

	/// <summary>
	/// Key: "Message.GroupClosed"
	/// English String: "You cannot join a closed group."
	/// </summary>
	public override string MessageGroupClosed => "Vous ne pouvez pas rejoindre un groupe fermé.";

	/// <summary>
	/// Key: "Message.GroupCreationDisabled"
	/// English String: "Group creation is currently disabled."
	/// </summary>
	public override string MessageGroupCreationDisabled => "La création de groupe est actuellement désactivée.";

	/// <summary>
	/// Key: "Message.GroupIconInvalid"
	/// English String: "Icon is missing or invalid."
	/// </summary>
	public override string MessageGroupIconInvalid => "Icône manquante ou invalide.";

	/// <summary>
	/// Key: "Message.GroupMembershipsUnavailableError"
	/// Error displayed on group details view when the system is in read-only mode for maintenance and you try to perform an action.
	/// English String: "The group membership system is temporarily unavailable. Please try again later."
	/// </summary>
	public override string MessageGroupMembershipsUnavailableError => "Les abonnements de groupes sont temporairement indisponibles. Réessaye plus tard.";

	/// <summary>
	/// Key: "Message.InsufficientFunds"
	/// English String: "Insufficient Robux funds."
	/// </summary>
	public override string MessageInsufficientFunds => "Pas assez de Robux.";

	/// <summary>
	/// Key: "Message.InsufficientGroupSpace"
	/// English String: "You are already in the maximum number of groups."
	/// </summary>
	public override string MessageInsufficientGroupSpace => "Vous avez déjà rejoint le nombre maximal de groupes.";

	/// <summary>
	/// Key: "Message.InsufficientMembership"
	/// English String: "You do not have the builders club membership necessary to join this group."
	/// </summary>
	public override string MessageInsufficientMembership => "Vous n'avez pas l'abonnement au Builders Club nécessaire pour rejoindre ce groupe.";

	/// <summary>
	/// Key: "Message.InsufficientPermission"
	/// English String: "Insufficient permissions to complete the request."
	/// </summary>
	public override string MessageInsufficientPermission => "Tu n'es pas autorisé.e à faire ça.";

	/// <summary>
	/// Key: "Message.InsufficientPermissionsForRelationships"
	/// English String: "You don't have permission to manage this group's relationships."
	/// </summary>
	public override string MessageInsufficientPermissionsForRelationships => "Vous n'avez pas l'autorisation de modifier les relations de ce groupe.";

	/// <summary>
	/// Key: "Message.InsufficientRobux"
	/// English String: "You do not have enough Robux to create the group."
	/// </summary>
	public override string MessageInsufficientRobux => "Tu n'as pas assez de Robux pour créer le groupe.";

	/// <summary>
	/// Key: "Message.InvalidAmount"
	/// English String: "The amount is invalid."
	/// </summary>
	public override string MessageInvalidAmount => "Le montant n'est pas valide.";

	/// <summary>
	/// Key: "Message.InvalidGroup"
	/// English String: "Group is invalid or does not exist."
	/// </summary>
	public override string MessageInvalidGroup => "Le groupe n'est pas valide ou n'existe pas.";

	/// <summary>
	/// Key: "Message.InvalidGroupIcon"
	/// English String: "The group icon is invalid."
	/// </summary>
	public override string MessageInvalidGroupIcon => "L'icône du groupe n'est pas valide.";

	/// <summary>
	/// Key: "Message.InvalidGroupId"
	/// English String: "The group is invalid or does not exist."
	/// </summary>
	public override string MessageInvalidGroupId => "Le groupe n'est pas valide ou n'existe pas.";

	/// <summary>
	/// Key: "Message.InvalidGroupWallPostId"
	/// English String: "The group wall post id is invalid or does not exist."
	/// </summary>
	public override string MessageInvalidGroupWallPostId => "L'ID du mur du groupe n'est pas valide ou n'existe pas.";

	/// <summary>
	/// Key: "Message.InvalidIds"
	/// English String: "Ids could not be parsed from request."
	/// </summary>
	public override string MessageInvalidIds => "Analyse des ID impossible pour cette requête.";

	/// <summary>
	/// Key: "Message.InvalidIdsError"
	/// English String: "Ids could not be parsed from request."
	/// </summary>
	public override string MessageInvalidIdsError => "Analyse des ID impossible pour cette requête.";

	/// <summary>
	/// Key: "Message.InvalidMembership"
	/// English String: "User must have builders club membership."
	/// </summary>
	public override string MessageInvalidMembership => "L'utilisateur doit être abonné au Builders Club";

	/// <summary>
	/// Key: "Message.InvalidName"
	/// English String: "The name is invalid."
	/// </summary>
	public override string MessageInvalidName => "Le nom n'est pas valide.";

	/// <summary>
	/// Key: "Message.InvalidPaginationParameters"
	/// English String: "Invalid or missing pagination parameters."
	/// </summary>
	public override string MessageInvalidPaginationParameters => "Paramètres de pagination non valides ou inexistants.";

	/// <summary>
	/// Key: "Message.InvalidPayoutType"
	/// English String: "Invalid payout type."
	/// </summary>
	public override string MessageInvalidPayoutType => "Mode de paiement invalide.";

	/// <summary>
	/// Key: "Message.InvalidRecipient"
	/// English String: "The recipient is invalid."
	/// </summary>
	public override string MessageInvalidRecipient => "Le destinataire est invalide.";

	/// <summary>
	/// Key: "Message.InvalidRelationshipType"
	/// English String: "Group relationship type is invalid."
	/// </summary>
	public override string MessageInvalidRelationshipType => "Le type de relation du groupe n'est pas valide.";

	/// <summary>
	/// Key: "Message.InvalidRoleSetId"
	/// English String: "The roleset is invalid or does not exist."
	/// </summary>
	public override string MessageInvalidRoleSetId => "Le rôle n'est pas valide ou n'existe pas.";

	/// <summary>
	/// Key: "Message.InvalidUser"
	/// English String: "The user is invalid or does not exist."
	/// </summary>
	public override string MessageInvalidUser => "L'utilisateur n'est pas valide ou n'existe pas.";

	/// <summary>
	/// Key: "Message.InvalidWallPostContent"
	/// English String: "Your post was empty, white space, or more than 500 characters."
	/// </summary>
	public override string MessageInvalidWallPostContent => "Votre message était vide, ne contenait que des espaces ou comptait plus de 500\u00a0caractères.";

	/// <summary>
	/// Key: "Message.JoinGroupError"
	/// English String: "Unable to join group."
	/// </summary>
	public override string MessageJoinGroupError => "Impossible de rejoindre le groupe.";

	/// <summary>
	/// Key: "Message.JoinGroupPendingSuccess"
	/// English String: "Requested to join group, your request is pending."
	/// </summary>
	public override string MessageJoinGroupPendingSuccess => "Vous avez demandé à rejoindre le groupe\u00a0; la demande est en attente.";

	/// <summary>
	/// Key: "Message.JoinGroupSuccess"
	/// English String: "Successfully joined the group."
	/// </summary>
	public override string MessageJoinGroupSuccess => "Vous avez rejoint le groupe.";

	/// <summary>
	/// Key: "Message.LeaveGroupError"
	/// English String: "Unable to leave group."
	/// </summary>
	public override string MessageLeaveGroupError => "Impossible de quitter le groupe.";

	/// <summary>
	/// Key: "Message.LoadGroupError"
	/// English String: "Unable to load group."
	/// </summary>
	public override string MessageLoadGroupError => "Impossible de charger le groupe.";

	/// <summary>
	/// Key: "Message.LoadGroupGamesError"
	/// English String: "Unable to load games."
	/// </summary>
	public override string MessageLoadGroupGamesError => "Impossible de charger les jeux.";

	/// <summary>
	/// Key: "Message.LoadGroupListError"
	/// English String: "Unable to load group list."
	/// </summary>
	public override string MessageLoadGroupListError => "Impossible de charger la liste des groupes.";

	/// <summary>
	/// Key: "Message.LoadGroupMembershipsError"
	/// English String: "Unable to load user membership information."
	/// </summary>
	public override string MessageLoadGroupMembershipsError => "Impossible de charger les informations d'abonnement de l'utilisateur.";

	/// <summary>
	/// Key: "Message.LoadGroupMetadataError"
	/// English String: "Unable to load group info."
	/// </summary>
	public override string MessageLoadGroupMetadataError => "Impossible de charger les informations du groupe.";

	/// <summary>
	/// Key: "Message.LoadGroupStoreItemsError"
	/// English String: "Unable to load store items."
	/// </summary>
	public override string MessageLoadGroupStoreItemsError => "Impossible de charger les objets du magasin.";

	/// <summary>
	/// Key: "Message.LoadUserGroupMembershipError"
	/// English String: "Unable to load group member information."
	/// </summary>
	public override string MessageLoadUserGroupMembershipError => "Impossible de charger les informations du membre du groupe.";

	/// <summary>
	/// Key: "Message.LoadWallPostsError"
	/// English String: "Unable to load wall posts."
	/// </summary>
	public override string MessageLoadWallPostsError => "Impossible de charger les messages du mur.";

	/// <summary>
	/// Key: "Message.MakePrimaryError"
	/// English String: "Unable to make primary group."
	/// </summary>
	public override string MessageMakePrimaryError => "Impossible de créer le groupe principal.";

	/// <summary>
	/// Key: "Message.MaxGroups"
	/// English String: "User is in maximum number of groups."
	/// </summary>
	public override string MessageMaxGroups => "L'utilisateur a déjà rejoint le nombre maximal de groupes.";

	/// <summary>
	/// Key: "Message.MissingGroupIcon"
	/// English String: "The group icon is missing from the request."
	/// </summary>
	public override string MessageMissingGroupIcon => "Il manque l'icône du groupe pour cette requête.";

	/// <summary>
	/// Key: "Message.MissingGroupStatusContent"
	/// English String: "Missing group status content."
	/// </summary>
	public override string MessageMissingGroupStatusContent => "Statut du groupe manquant.";

	/// <summary>
	/// Key: "Message.NameInvalid"
	/// English String: "Name is missing or has invalid characters."
	/// </summary>
	public override string MessageNameInvalid => "Nom manquant ou contient des symboles invalides.";

	/// <summary>
	/// Key: "Message.NameModerated"
	/// English String: "The name is moderated."
	/// </summary>
	public override string MessageNameModerated => "Le nom est modéré.";

	/// <summary>
	/// Key: "Message.NameTaken"
	/// English String: "The name has been taken."
	/// </summary>
	public override string MessageNameTaken => "Le nom est déjà pris.";

	/// <summary>
	/// Key: "Message.NameTooLong"
	/// English String: "The name is too long."
	/// </summary>
	public override string MessageNameTooLong => "Le nom est trop long.";

	/// <summary>
	/// Key: "Message.NoPrimary"
	/// English String: "The user specified does not have a primary group."
	/// </summary>
	public override string MessageNoPrimary => "L'utilisateur indiqué n'a pas de groupe principal.";

	/// <summary>
	/// Key: "Message.PassCaptchaToJoin"
	/// English String: "You must pass the captcha test before joining this group."
	/// </summary>
	public override string MessagePassCaptchaToJoin => "Vous devez effectuer la vérification captcha avant de rejoindre ce groupe.";

	/// <summary>
	/// Key: "Message.PassCaptchaToPost"
	/// English String: "Captcha must be solved to post to the group wall."
	/// </summary>
	public override string MessagePassCaptchaToPost => "Le captcha doit être résolu avant de pouvoir écrire sur le mur du groupe.";

	/// <summary>
	/// Key: "Message.RemovePrimaryError"
	/// English String: "Unable to remove primary group."
	/// </summary>
	public override string MessageRemovePrimaryError => "Impossible de supprimer le groupe principal.";

	/// <summary>
	/// Key: "Message.SearchTermCharactersLimit"
	/// English String: "The search term needs to be between 2 and 50 characters"
	/// </summary>
	public override string MessageSearchTermCharactersLimit => "Le terme de recherche doit être entre 2 et 50 caractères";

	/// <summary>
	/// Key: "Message.SearchTermEmptyError"
	/// English String: "Search term is empty"
	/// </summary>
	public override string MessageSearchTermEmptyError => "Le champ de recherche est vide";

	/// <summary>
	/// Key: "Message.SearchTermFilteredError"
	/// English String: "Search term was filtered"
	/// </summary>
	public override string MessageSearchTermFilteredError => "Le champ de recherche a été modéré";

	/// <summary>
	/// Key: "Message.SendGroupShoutError"
	/// English String: "Unable to send group shout."
	/// </summary>
	public override string MessageSendGroupShoutError => "Impossible d'envoyer un appel de groupe.";

	/// <summary>
	/// Key: "Message.SendPostError"
	/// English String: "Unable to send post."
	/// </summary>
	public override string MessageSendPostError => "Impossible de publier le message.";

	/// <summary>
	/// Key: "Message.TooManyAttempts"
	/// English String: "Too many attempts to join the group. Please try again later."
	/// </summary>
	public override string MessageTooManyAttempts => "Trop de tentatives pour rejoindre le groupe. Veuillez réessayer plus tard.";

	/// <summary>
	/// Key: "Message.TooManyAttemptsToClaimGroups"
	/// English String: "Too many attempts to claim groups. Please try again later."
	/// </summary>
	public override string MessageTooManyAttemptsToClaimGroups => "Trop de tentatives pour revendiquer des groupes. Veuillez réessayer plus tard.";

	/// <summary>
	/// Key: "Message.TooManyGroups"
	/// English String: "You have reached the group capacity. Please leave a group before creating a new one."
	/// </summary>
	public override string MessageTooManyGroups => "Capacité maximale atteinte. Quitte un groupe avant de pouvoir en créer un nouveau.";

	/// <summary>
	/// Key: "Message.TooManyIds"
	/// English String: "Too many ids in request."
	/// </summary>
	public override string MessageTooManyIds => "Trop grand nombre d'ID pour cette requête.";

	/// <summary>
	/// Key: "Message.TooManyPosts"
	/// English String: "You are posting too fast, please try again in a few minutes."
	/// </summary>
	public override string MessageTooManyPosts => "Vous écrivez trop de messages, veuillez réessayer dans quelques minutes.";

	/// <summary>
	/// Key: "Message.TooManyRequests"
	/// English String: "Too many requests."
	/// </summary>
	public override string MessageTooManyRequests => "Trop de requêtes.";

	/// <summary>
	/// Key: "Message.UnauthorizedForPostStatus"
	/// English String: "You are not authorized to set the status of this group."
	/// </summary>
	public override string MessageUnauthorizedForPostStatus => "Vous n'avez pas l'autorisation de modifier le statut de ce groupe.";

	/// <summary>
	/// Key: "Message.UnauthorizedForViewGroupPayouts"
	/// English String: "You don't have permission to view this group's payouts."
	/// </summary>
	public override string MessageUnauthorizedForViewGroupPayouts => "Vous n'avez pas l'autorisation de voir les gains de ce groupe.";

	/// <summary>
	/// Key: "Message.UnauthorizedToClaimGroup"
	/// English String: "You are not authorized to claim this group."
	/// </summary>
	public override string MessageUnauthorizedToClaimGroup => "Vous n'avez pas l'autorisation de revendiquer ce groupe.";

	/// <summary>
	/// Key: "Message.UnauthorizedToManageMember"
	/// English String: "You do not have permission to manage this member."
	/// </summary>
	public override string MessageUnauthorizedToManageMember => "Vous n'avez pas la permission d'éditer ce membre.";

	/// <summary>
	/// Key: "Message.UnauthorizedToViewRolesetPermissions"
	/// English String: "You are not authorized to view permissions for this roleset."
	/// </summary>
	public override string MessageUnauthorizedToViewRolesetPermissions => "Vous n'avez pas l'autorisation de voir les permissions pour ce rôle.";

	/// <summary>
	/// Key: "Message.UnauthorizedToViewWall"
	/// English String: "You do not have permission to access this group wall."
	/// </summary>
	public override string MessageUnauthorizedToViewWall => "Vous n'avez pas la permission d'accéder au mur de ce groupe.";

	/// <summary>
	/// Key: "Message.UnknownError"
	/// English String: "Unknown error"
	/// </summary>
	public override string MessageUnknownError => "Erreur inconnue";

	/// <summary>
	/// Key: "Message.UserNotInGroup"
	/// English String: "You aren't a member of the group specified."
	/// </summary>
	public override string MessageUserNotInGroup => "Tu ne fais pas partie du groupe indiqué.";

	public GroupsResources_fr_fr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAdvertiseGroup()
	{
		return "Promouvoir le groupe";
	}

	protected override string _GetTemplateForActionAuditLog()
	{
		return "Journal d'audit";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "Annuler";
	}

	protected override string _GetTemplateForActionCancelRequest()
	{
		return "Annuler la demande";
	}

	protected override string _GetTemplateForActionClaimOwnership()
	{
		return "Revendiquer la propriété";
	}

	protected override string _GetTemplateForActionClose()
	{
		return "Fermer";
	}

	protected override string _GetTemplateForActionConfigureGroup()
	{
		return "Configuration du groupe";
	}

	protected override string _GetTemplateForActionCreateGroup()
	{
		return "Créer un groupe";
	}

	protected override string _GetTemplateForActionDelete()
	{
		return "Supprimer";
	}

	protected override string _GetTemplateForActionExile()
	{
		return "Bannir";
	}

	protected override string _GetTemplateForActionExileUser()
	{
		return "Bannir l'utilisateur";
	}

	protected override string _GetTemplateForActionGroupAdmin()
	{
		return "Administrateur du groupe";
	}

	protected override string _GetTemplateForActionGroupShout()
	{
		return "Appel de groupe";
	}

	protected override string _GetTemplateForActionJoinGroup()
	{
		return "Rejoindre le groupe";
	}

	protected override string _GetTemplateForActionLeaveGroup()
	{
		return "Quitter le groupe";
	}

	protected override string _GetTemplateForActionMakePrimary()
	{
		return "Désigner comme groupe principal";
	}

	protected override string _GetTemplateForActionMakePrimaryGroup()
	{
		return "Désigner comme groupe principal";
	}

	protected override string _GetTemplateForActionPost()
	{
		return "Publier";
	}

	protected override string _GetTemplateForActionPurchase()
	{
		return "Acheter";
	}

	protected override string _GetTemplateForActionRemovePrimary()
	{
		return "Supprimer le groupe principal";
	}

	protected override string _GetTemplateForActionReport()
	{
		return "Signaler";
	}

	protected override string _GetTemplateForActionReportAbuse()
	{
		return "Signaler une infraction";
	}

	protected override string _GetTemplateForActionUpgrade()
	{
		return "Améliorer";
	}

	protected override string _GetTemplateForActionUpgradeToJoin()
	{
		return "Améliorer pour rejoindre";
	}

	protected override string _GetTemplateForActionYes()
	{
		return "Oui";
	}

	protected override string _GetTemplateForDescriptionClothingRevenue()
	{
		return "Les groupes peuvent créer et vendre des chemises, des pantalons et des tee-shirts officiels\u00a0! Les recettes sont ajoutées aux fonds du groupe.";
	}

	protected override string _GetTemplateForDescriptionDeleteAllPostsByUser()
	{
		return "Effacer également tous les messages de cet utilisateur.";
	}

	protected override string _GetTemplateForDescriptionExileUserWarning()
	{
		return "Voulez-vous vraiment bannir cet utilisateur\u00a0?";
	}

	protected override string _GetTemplateForDescriptionLeaveGroupAsOwnerWarning()
	{
		return "Ce groupe n'aura plus de propriétaire.";
	}

	protected override string _GetTemplateForDescriptionLeaveGroupWarning()
	{
		return "Voulez-vous vraiment quitter ce groupe\u00a0?";
	}

	protected override string _GetTemplateForDescriptionMakePrimaryGroupWarning()
	{
		return "Voulez-vous vraiment faire de ce groupe votre groupe principal\u00a0?";
	}

	protected override string _GetTemplateForDescriptionNoneMaxGroups()
	{
		return "Abonnez-vous au Builders Club pour rejoindre plus de groupes.";
	}

	protected override string _GetTemplateForDescriptionNoneMaxGroupsPremium()
	{
		return "Abonnez-vous à Roblox Premium pour rejoindre plus de groupes.";
	}

	protected override string _GetTemplateForDescriptionnoneMaxGroupsPremiumText()
	{
		return "Abonnez-vous à Roblox Premium pour rejoindre plus de groupes.";
	}

	protected override string _GetTemplateForDescriptionObcMaxGroups()
	{
		return "Vous avez rejoint le nombre maximum de groupes autorisés.";
	}

	protected override string _GetTemplateForDescriptionOtherBcMaxGroups()
	{
		return "Améliorez votre abonnement au Builders Club pour rejoindre plus de groupes.";
	}

	protected override string _GetTemplateForDescriptionotherPremiumMaxGroupsText()
	{
		return "Améliorez votre abonnement à Roblox Premium pour rejoindre plus de groupes.";
	}

	protected override string _GetTemplateForDescriptionPremiumMaxGroups()
	{
		return "Vous avez déjà rejoint le nombre maximal de groupes.";
	}

	protected override string _GetTemplateForDescriptionPurchaseBody()
	{
		return "Tu voudrais créer ce groupe pour ";
	}

	protected override string _GetTemplateForDescriptionRemovePrimaryGroupWarning()
	{
		return "Voulez-vous vraiment supprimer votre groupe principal\u00a0?";
	}

	protected override string _GetTemplateForDescriptionReportAbuseDescription()
	{
		return "Que veux-tu signaler ?";
	}

	protected override string _GetTemplateForDescriptionWallPrivacySettings()
	{
		return "Vos paramètres de confidentialité ne vous permettent pas de publier des messages sur les murs de groupe. Cliquez ici pour modifier ces paramètres.";
	}

	protected override string _GetTemplateForHeadingAbout()
	{
		return "À propos";
	}

	protected override string _GetTemplateForHeadingAffiliates()
	{
		return "Affiliés";
	}

	protected override string _GetTemplateForHeadingAllies()
	{
		return "Alliés";
	}

	/// <summary>
	/// Key: "Heading.ConfigureGroup"
	/// English String: "Configure {groupName}"
	/// </summary>
	public override string HeadingConfigureGroup(string groupName)
	{
		return $"Configurer {groupName}";
	}

	protected override string _GetTemplateForHeadingConfigureGroup()
	{
		return "Configurer {groupName}";
	}

	protected override string _GetTemplateForHeadingDate()
	{
		return "Date";
	}

	protected override string _GetTemplateForHeadingDescription()
	{
		return "Description";
	}

	protected override string _GetTemplateForHeadingEnemies()
	{
		return "Ennemis";
	}

	protected override string _GetTemplateForHeadingExileUserWarning()
	{
		return "Avertissement";
	}

	protected override string _GetTemplateForHeadingFunds()
	{
		return "Fonds";
	}

	protected override string _GetTemplateForHeadingGames()
	{
		return "Jeux";
	}

	protected override string _GetTemplateForHeadingGroupPurchase()
	{
		return "Confirmation d'achat de groupe";
	}

	protected override string _GetTemplateForHeadingGroupShout()
	{
		return "Appel de groupe";
	}

	protected override string _GetTemplateForHeadingLeaveGroup()
	{
		return "Quitter le groupe";
	}

	protected override string _GetTemplateForHeadingMakePrimaryGroup()
	{
		return "Désigner comme groupe principal";
	}

	protected override string _GetTemplateForHeadingMembers()
	{
		return "Membres";
	}

	protected override string _GetTemplateForHeadingNameOrDescription()
	{
		return "Nom / Description";
	}

	protected override string _GetTemplateForHeadingPayouts()
	{
		return "Gains";
	}

	protected override string _GetTemplateForHeadingPrimary()
	{
		return "Principal";
	}

	protected override string _GetTemplateForHeadingRank()
	{
		return "Rang";
	}

	protected override string _GetTemplateForHeadingRemovePrimaryGroup()
	{
		return "Ne plus désigner comme groupe principal";
	}

	protected override string _GetTemplateForHeadingRole()
	{
		return "Rôle";
	}

	protected override string _GetTemplateForHeadingSettings()
	{
		return "Paramètres";
	}

	protected override string _GetTemplateForHeadingShout()
	{
		return "Appel";
	}

	protected override string _GetTemplateForHeadingStore()
	{
		return "Boutique";
	}

	protected override string _GetTemplateForHeadingUser()
	{
		return "Utilisateur";
	}

	protected override string _GetTemplateForHeadingWall()
	{
		return "Mur";
	}

	protected override string _GetTemplateForLabelAbandon()
	{
		return "Abandonner";
	}

	protected override string _GetTemplateForLabelAcceptAllyRequest()
	{
		return "Accepter la demande d'alliance";
	}

	protected override string _GetTemplateForLabelAcceptJoinRequest()
	{
		return "Accepter la demande de participation";
	}

	protected override string _GetTemplateForLabelAddGroupPlace()
	{
		return "Ajouter un emplacement de groupe";
	}

	protected override string _GetTemplateForLabelAdjustCurrencyAmounts()
	{
		return "Modifier les montants de monnaie";
	}

	protected override string _GetTemplateForLabelAll()
	{
		return "Tous";
	}

	protected override string _GetTemplateForLabelAnyoneCanJoin()
	{
		return "Tout le monde peut rejoindre";
	}

	protected override string _GetTemplateForLabelBuyAd()
	{
		return "Acheter la publicité";
	}

	protected override string _GetTemplateForLabelBuyClan()
	{
		return "Acheter le clan";
	}

	protected override string _GetTemplateForLabelByOwner()
	{
		return "Par";
	}

	protected override string _GetTemplateForLabelCancelClanInvite()
	{
		return "Annuler l'invitation au clan";
	}

	protected override string _GetTemplateForLabelChangeDescription()
	{
		return "Modifier la description";
	}

	protected override string _GetTemplateForLabelChangeOwner()
	{
		return "Changer de propriétaire";
	}

	protected override string _GetTemplateForLabelChangeRank()
	{
		return "Modifier le rang";
	}

	protected override string _GetTemplateForLabelClaim()
	{
		return "Revendiquer";
	}

	protected override string _GetTemplateForLabelConfigureBadge()
	{
		return "Configurer un badge";
	}

	protected override string _GetTemplateForLabelConfigureGroupAsset()
	{
		return "Configurer un élément de groupe";
	}

	protected override string _GetTemplateForLabelConfigureGroupDevelopmentItem()
	{
		return "Configurer un objet de développement de groupe";
	}

	protected override string _GetTemplateForLabelConfigureGroupGame()
	{
		return "Configurer un jeu de groupe";
	}

	protected override string _GetTemplateForLabelConfigureItems()
	{
		return "Configurer les objets";
	}

	protected override string _GetTemplateForLabelCreateBadge()
	{
		return "Créer un badge";
	}

	protected override string _GetTemplateForLabelCreateEnemy()
	{
		return "Créer un ennemi";
	}

	protected override string _GetTemplateForLabelCreateGamePass()
	{
		return "Créer un passe de jeu";
	}

	protected override string _GetTemplateForLabelCreateGroup()
	{
		return "Créer un groupe";
	}

	protected override string _GetTemplateForLabelCreateGroupAsset()
	{
		return "Créer un élément de groupe";
	}

	protected override string _GetTemplateForLabelCreateGroupBuildersClubTooltip()
	{
		return "Un abonnement au Builders Club est nécessaire pour créer un groupe.";
	}

	protected override string _GetTemplateForLabelCreateGroupDescription()
	{
		return "Description (optionnel)";
	}

	protected override string _GetTemplateForLabelCreateGroupDeveloperProduct()
	{
		return "Créer un produit développeur de groupe";
	}

	protected override string _GetTemplateForLabelCreateGroupEmblem()
	{
		return "Emblème";
	}

	protected override string _GetTemplateForLabelCreateGroupFee()
	{
		return "Taxe de création de groupe";
	}

	protected override string _GetTemplateForLabelCreateGroupName()
	{
		return "Nomme ton groupe";
	}

	protected override string _GetTemplateForLabelCreateGroupPremiumTooltip()
	{
		return "La création d'un groupe nécessite un abonnement à Roblox Premium.";
	}

	protected override string _GetTemplateForLabelCreateGroupTooltip()
	{
		return "Créer un nouveau groupe";
	}

	protected override string _GetTemplateForLabelCreateItems()
	{
		return "Créer les objets";
	}

	protected override string _GetTemplateForLabelDeclineAllyRequest()
	{
		return "Refuser la demande d'alliance";
	}

	protected override string _GetTemplateForLabelDeclineJoinRequest()
	{
		return "Refuser la demande de participation";
	}

	protected override string _GetTemplateForLabelDelete()
	{
		return "Supprimer";
	}

	protected override string _GetTemplateForLabelDeleteAllPostsByUser()
	{
		return "Effacer également tous les messages de cet utilisateur.";
	}

	protected override string _GetTemplateForLabelDeleteAlly()
	{
		return "Supprimer l'allié";
	}

	protected override string _GetTemplateForLabelDeleteEnemy()
	{
		return "Supprimer l'ennemi";
	}

	protected override string _GetTemplateForLabelDeleteGroupPlace()
	{
		return "Supprimer l'emplacement de groupe";
	}

	protected override string _GetTemplateForLabelDeletePost()
	{
		return "Supprimer le message";
	}

	protected override string _GetTemplateForLabelFunds()
	{
		return "Fonds";
	}

	protected override string _GetTemplateForLabelGroupClosed()
	{
		return "Groupe fermé";
	}

	protected override string _GetTemplateForLabelGroupLocked()
	{
		return "Ce groupe a été verrouillé.";
	}

	/// <summary>
	/// Key: "Label.GroupSearchResults"
	/// English String: "Group Results For {searchTerm}"
	/// </summary>
	public override string LabelGroupSearchResults(string searchTerm)
	{
		return $"Résultats de groupe pour {searchTerm}";
	}

	protected override string _GetTemplateForLabelGroupSearchResults()
	{
		return "Résultats de groupe pour {searchTerm}";
	}

	protected override string _GetTemplateForLabelInviteToClan()
	{
		return "Inviter dans le clan";
	}

	protected override string _GetTemplateForLabelKickFromClan()
	{
		return "Expulser du clan";
	}

	protected override string _GetTemplateForLabelLoading()
	{
		return "Chargement...";
	}

	protected override string _GetTemplateForLabelLock()
	{
		return "Verrouiller";
	}

	protected override string _GetTemplateForLabelManageGroupCreations()
	{
		return "Créer ou gérer les objets du groupe.";
	}

	protected override string _GetTemplateForLabelManualApproval()
	{
		return "Approbation manuelle";
	}

	/// <summary>
	/// Key: "Label.MaxGroupsTooltip"
	/// English String: "You may only be in a maximum of {maxGroups} groups at one time"
	/// </summary>
	public override string LabelMaxGroupsTooltip(string maxGroups)
	{
		return $"Vous ne pouvez faire partie que de {maxGroups}\u00a0groupes à la fois";
	}

	protected override string _GetTemplateForLabelMaxGroupsTooltip()
	{
		return "Vous ne pouvez faire partie que de {maxGroups}\u00a0groupes à la fois";
	}

	protected override string _GetTemplateForLabelMembers()
	{
		return "{memberCount, plural, =0 {# membres} =1 {# membre} other {# membres}}";
	}

	protected override string _GetTemplateForLabelModerateDiscussion()
	{
		return "Modérer la discussion";
	}

	protected override string _GetTemplateForLabelNoAllies()
	{
		return "Ce groupe n'a pas d'alliés.";
	}

	protected override string _GetTemplateForLabelNoEnemies()
	{
		return "Ce groupe n'a pas d'ennemis.";
	}

	protected override string _GetTemplateForLabelNoGames()
	{
		return "Aucun jeu n'est associé à ce groupe.";
	}

	protected override string _GetTemplateForLabelNoMembersInRole()
	{
		return "Aucun membre du groupe n'occupe ce rôle.";
	}

	protected override string _GetTemplateForLabelNoOne()
	{
		return "Personne\u00a0!";
	}

	/// <summary>
	/// Key: "Label.NoResults"
	/// English String: "No results for \"{searchTerm}\""
	/// </summary>
	public override string LabelNoResults(string searchTerm)
	{
		return $"Aucun résultat pour \"{searchTerm}\"";
	}

	protected override string _GetTemplateForLabelNoResults()
	{
		return "Aucun résultat pour \"{searchTerm}\"";
	}

	protected override string _GetTemplateForLabelNoStoreItems()
	{
		return "Aucun objet n'est à vendre dans ce groupe.";
	}

	protected override string _GetTemplateForLabelNoWallPosts()
	{
		return "Personne n'a dit quoi que ce soit pour l'instant...";
	}

	protected override string _GetTemplateForLabelOnlyBcCanJoin()
	{
		return "Seuls les membres du Builders Club peuvent s'y joindre.";
	}

	protected override string _GetTemplateForLabelOnlyPremiumCanJoin()
	{
		return "Seuls les membres abonnés peuvent rejoindre";
	}

	protected override string _GetTemplateForLabelPrivateGroup()
	{
		return "Privé";
	}

	protected override string _GetTemplateForLabelPublicGroup()
	{
		return "Public";
	}

	protected override string _GetTemplateForLabelPublishPlace()
	{
		return "Publier l'emplacement";
	}

	protected override string _GetTemplateForLabelRemoveGroupPlace()
	{
		return "Supprimer l'emplacement de groupe";
	}

	protected override string _GetTemplateForLabelRemoveMember()
	{
		return "Retirer le membre";
	}

	protected override string _GetTemplateForLabelRename()
	{
		return "Renommer";
	}

	protected override string _GetTemplateForLabelRevertGroupAsset()
	{
		return "Rétrograder un élément de groupe";
	}

	protected override string _GetTemplateForLabelSavePlace()
	{
		return "Enregistrer l'emplacement";
	}

	protected override string _GetTemplateForLabelSearchGroups()
	{
		return "Rechercher tous les groupes";
	}

	protected override string _GetTemplateForLabelSearchUsers()
	{
		return "Rechercher des utilisateurs";
	}

	protected override string _GetTemplateForLabelSendAllyRequest()
	{
		return "Envoyer une demande d'alliance";
	}

	protected override string _GetTemplateForLabelShoutPlaceholder()
	{
		return "Saisissez votre appel";
	}

	protected override string _GetTemplateForLabelSpendGroupFunds()
	{
		return "Dépenser les fonds du groupe";
	}

	protected override string _GetTemplateForLabelSuccess()
	{
		return "Succès";
	}

	protected override string _GetTemplateForLabelUnlock()
	{
		return "Déverrouiller";
	}

	protected override string _GetTemplateForLabelUpdateGroupAsset()
	{
		return "Mettre à jour un élément de groupe";
	}

	protected override string _GetTemplateForLabelWallPostPlaceholder()
	{
		return "Dire quelque chose...";
	}

	protected override string _GetTemplateForLabelWallPostsUnavailable()
	{
		return "Les messages du mur sont indisponibles pour l'instant, veuillez revenir plus tard.";
	}

	protected override string _GetTemplateForLabelWarning()
	{
		return "Avertissement";
	}

	/// <summary>
	/// Key: "Message.Abandon"
	/// English String: "{actor} (group owner) abandoned the group"
	/// </summary>
	public override string MessageAbandon(string actor)
	{
		return $"{actor} (propriétaire) a abandonné le groupe";
	}

	protected override string _GetTemplateForMessageAbandon()
	{
		return "{actor} (propriétaire) a abandonné le groupe";
	}

	/// <summary>
	/// Key: "Message.AcceptAllyRequest"
	/// English String: "{actor} accepted group {group}'s ally request"
	/// </summary>
	public override string MessageAcceptAllyRequest(string actor, string group)
	{
		return $"{actor} a accepté la demande d'alliance du groupe {group}";
	}

	protected override string _GetTemplateForMessageAcceptAllyRequest()
	{
		return "{actor} a accepté la demande d'alliance du groupe {group}";
	}

	/// <summary>
	/// Key: "Message.AcceptJoinRequest"
	/// English String: "{actor} accepted user {user}'s join request"
	/// </summary>
	public override string MessageAcceptJoinRequest(string actor, string user)
	{
		return $"{actor} a accepté la demande de participation de {user}";
	}

	protected override string _GetTemplateForMessageAcceptJoinRequest()
	{
		return "{actor} a accepté la demande de participation de {user}";
	}

	/// <summary>
	/// Key: "Message.AddGroupPlace"
	/// English String: "{actor} added game {game} as a group game"
	/// </summary>
	public override string MessageAddGroupPlace(string actor, string game)
	{
		return $"{actor} a ajouté le jeu {game} comme jeu de groupe";
	}

	protected override string _GetTemplateForMessageAddGroupPlace()
	{
		return "{actor} a ajouté le jeu {game} comme jeu de groupe";
	}

	/// <summary>
	/// Key: "Message.AdjustCurrencyAmountsDecreased"
	/// English String: "{actor} decreased group funds by {amount}"
	/// </summary>
	public override string MessageAdjustCurrencyAmountsDecreased(string actor, string amount)
	{
		return $"{actor} a diminué les fonds du groupe de {amount}";
	}

	protected override string _GetTemplateForMessageAdjustCurrencyAmountsDecreased()
	{
		return "{actor} a diminué les fonds du groupe de {amount}";
	}

	/// <summary>
	/// Key: "Message.AdjustCurrencyAmountsIncreased"
	/// English String: "{actor} increased group funds by {amount}"
	/// </summary>
	public override string MessageAdjustCurrencyAmountsIncreased(string actor, string amount)
	{
		return $"{actor} a augmenté les fonds du groupe de {amount}";
	}

	protected override string _GetTemplateForMessageAdjustCurrencyAmountsIncreased()
	{
		return "{actor} a augmenté les fonds du groupe de {amount}";
	}

	protected override string _GetTemplateForMessageAlreadyMember()
	{
		return "Tu fais déjà partie de ce groupe.";
	}

	protected override string _GetTemplateForMessageAlreadyRequested()
	{
		return "Vous avez déjà demandé à rejoindre ce groupe.";
	}

	protected override string _GetTemplateForMessageBuildGroupRolesListError()
	{
		return "Impossible de charger les membres occupant le rôle sélectionné.";
	}

	/// <summary>
	/// Key: "Message.BuyAd"
	/// English String: "{actor} bid {bid} on group ad {adName}"
	/// </summary>
	public override string MessageBuyAd(string actor, string bid, string adName)
	{
		return $"{actor} a fait une offre de {bid} pour la publicité de groupe {adName}";
	}

	protected override string _GetTemplateForMessageBuyAd()
	{
		return "{actor} a fait une offre de {bid} pour la publicité de groupe {adName}";
	}

	/// <summary>
	/// Key: "Message.BuyClan"
	/// English String: "{actor} bought a group clan"
	/// </summary>
	public override string MessageBuyClan(string actor)
	{
		return $"{actor} a acheté un clan de groupe";
	}

	protected override string _GetTemplateForMessageBuyClan()
	{
		return "{actor} a acheté un clan de groupe";
	}

	/// <summary>
	/// Key: "Message.CancelClanInvite"
	/// English String: "{actor} cancelled {user}'s clan invite"
	/// </summary>
	public override string MessageCancelClanInvite(string actor, string user)
	{
		return $"{actor} a annulé l'invitation au clan de {user}";
	}

	protected override string _GetTemplateForMessageCancelClanInvite()
	{
		return "{actor} a annulé l'invitation au clan de {user}";
	}

	protected override string _GetTemplateForMessageCannotClaimGroupWithOwner()
	{
		return "Ce groupe a déjà un propriétaire.";
	}

	/// <summary>
	/// Key: "Message.ChangeDescription"
	/// English String: "{actor} changed the description to \"{newDescription}\""
	/// </summary>
	public override string MessageChangeDescription(string actor, string newDescription)
	{
		return $"{actor} a changé la description du groupe en «\u00a0{newDescription}\u00a0»";
	}

	protected override string _GetTemplateForMessageChangeDescription()
	{
		return "{actor} a changé la description du groupe en «\u00a0{newDescription}\u00a0»";
	}

	/// <summary>
	/// Key: "Message.ChangeOwner"
	/// English String: "{actor} changed the group owner. {user} is the new group owner"
	/// </summary>
	public override string MessageChangeOwner(string actor, string user)
	{
		return $"{actor} a transféré la propriété du groupe à {user}";
	}

	protected override string _GetTemplateForMessageChangeOwner()
	{
		return "{actor} a transféré la propriété du groupe à {user}";
	}

	protected override string _GetTemplateForMessageChangeOwnerEmpty()
	{
		return "Ce groupe n'a pas de propriétaire";
	}

	/// <summary>
	/// Key: "Message.ChangeRank"
	/// English String: "{actor} changed user {user}'s rank from {oldRoleSet} to {newRoleSet}"
	/// </summary>
	public override string MessageChangeRank(string actor, string user, string oldRoleSet, string newRoleSet)
	{
		return $"{actor} a modifié le rang de l'utilisateur {user} de {oldRoleSet} en {newRoleSet}";
	}

	protected override string _GetTemplateForMessageChangeRank()
	{
		return "{actor} a modifié le rang de l'utilisateur {user} de {oldRoleSet} en {newRoleSet}";
	}

	/// <summary>
	/// Key: "Message.Claim"
	/// English String: "{actor} claimed ownership of the group"
	/// </summary>
	public override string MessageClaim(string actor)
	{
		return $"{actor} a revendiqué la propriété du groupe";
	}

	protected override string _GetTemplateForMessageClaim()
	{
		return "{actor} a revendiqué la propriété du groupe";
	}

	protected override string _GetTemplateForMessageClaimOwnershipError()
	{
		return "Impossible de revendiquer la propriété du groupe.";
	}

	protected override string _GetTemplateForMessageClaimOwnershipSuccess()
	{
		return "La propriété du groupe a bien été revendiquée.";
	}

	/// <summary>
	/// Key: "Message.ConfigureAsset"
	/// English String: "{actor} updated asset {item}: {actions}"
	/// </summary>
	public override string MessageConfigureAsset(string actor, string item, string actions)
	{
		return $"{actor} a mis à jour l'élément {item}\u00a0: {actions}";
	}

	protected override string _GetTemplateForMessageConfigureAsset()
	{
		return "{actor} a mis à jour l'élément {item}\u00a0: {actions}";
	}

	/// <summary>
	/// Key: "Message.ConfigureBadgeDisabled"
	/// English String: "{actor} disabled the badge {badge}"
	/// </summary>
	public override string MessageConfigureBadgeDisabled(string actor, string badge)
	{
		return $"{actor} a désactivé le badge {badge}";
	}

	protected override string _GetTemplateForMessageConfigureBadgeDisabled()
	{
		return "{actor} a désactivé le badge {badge}";
	}

	/// <summary>
	/// Key: "Message.ConfigureBadgeEnabled"
	/// English String: "{actor} enabled the badge {badge}"
	/// </summary>
	public override string MessageConfigureBadgeEnabled(string actor, string badge)
	{
		return $"{actor} a activé le badge {badge}";
	}

	protected override string _GetTemplateForMessageConfigureBadgeEnabled()
	{
		return "{actor} a activé le badge {badge}";
	}

	/// <summary>
	/// Key: "Message.ConfigureBadgeUpdate"
	/// English String: "{actor} configured the badge {badge}"
	/// </summary>
	public override string MessageConfigureBadgeUpdate(string actor, string badge)
	{
		return $"{actor} a configuré le badge {badge}";
	}

	protected override string _GetTemplateForMessageConfigureBadgeUpdate()
	{
		return "{actor} a configuré le badge {badge}";
	}

	/// <summary>
	/// Key: "Message.ConfigureGame"
	/// English String: "{actor} updated {game}: {actions}"
	/// </summary>
	public override string MessageConfigureGame(string actor, string game, string actions)
	{
		return $"{actor} a mis à jour {game}\u00a0: {actions}";
	}

	protected override string _GetTemplateForMessageConfigureGame()
	{
		return "{actor} a mis à jour {game}\u00a0: {actions}";
	}

	/// <summary>
	/// Key: "Message.ConfigureGameDeveloperProduct"
	/// English String: "{actor} updated developer product {id}: {actions}"
	/// </summary>
	public override string MessageConfigureGameDeveloperProduct(string actor, string id, string actions)
	{
		return $"{actor} a mis à jour le produit développeur\u00a0{id}\u00a0: {actions}";
	}

	protected override string _GetTemplateForMessageConfigureGameDeveloperProduct()
	{
		return "{actor} a mis à jour le produit développeur\u00a0{id}\u00a0: {actions}";
	}

	/// <summary>
	/// Key: "Message.ConfigureItems"
	/// English String: "{actor} configured the group item {item}"
	/// </summary>
	public override string MessageConfigureItems(string actor, string item)
	{
		return $"{actor} a configuré l'objet de groupe {item}";
	}

	protected override string _GetTemplateForMessageConfigureItems()
	{
		return "{actor} a configuré l'objet de groupe {item}";
	}

	/// <summary>
	/// Key: "Message.CreateAsset"
	/// English String: "{actor} created asset {item}"
	/// </summary>
	public override string MessageCreateAsset(string actor, string item)
	{
		return $"{actor} a créé l'élément {item}";
	}

	protected override string _GetTemplateForMessageCreateAsset()
	{
		return "{actor} a créé l'élément {item}";
	}

	/// <summary>
	/// Key: "Message.CreateBadge"
	/// English String: "{actor} created the badge {badge}"
	/// </summary>
	public override string MessageCreateBadge(string actor, string badge)
	{
		return $"{actor} a créé le badge {badge}";
	}

	protected override string _GetTemplateForMessageCreateBadge()
	{
		return "{actor} a créé le badge {badge}";
	}

	/// <summary>
	/// Key: "Message.CreateDeveloperProduct"
	/// English String: "{actor} created developer product with id {id}"
	/// </summary>
	public override string MessageCreateDeveloperProduct(string actor, string id)
	{
		return $"{actor} a créé un produit développeur avec l'ID\u00a0{id}";
	}

	protected override string _GetTemplateForMessageCreateDeveloperProduct()
	{
		return "{actor} a créé un produit développeur avec l'ID\u00a0{id}";
	}

	/// <summary>
	/// Key: "Message.CreateEnemy"
	/// English String: "{actor} declared group {group} as an enemy"
	/// </summary>
	public override string MessageCreateEnemy(string actor, string group)
	{
		return $"{actor} a déclaré le groupe {group} comme ennemi";
	}

	protected override string _GetTemplateForMessageCreateEnemy()
	{
		return "{actor} a déclaré le groupe {group} comme ennemi";
	}

	/// <summary>
	/// Key: "Message.CreateGamePass"
	/// English String: "{actor} created a Game Pass for {game}: {gamePass}"
	/// </summary>
	public override string MessageCreateGamePass(string actor, string game, string gamePass)
	{
		return $"{actor} a créé un passe de jeu pour {game}\u00a0: {gamePass}";
	}

	protected override string _GetTemplateForMessageCreateGamePass()
	{
		return "{actor} a créé un passe de jeu pour {game}\u00a0: {gamePass}";
	}

	/// <summary>
	/// Key: "Message.CreateItems"
	/// English String: "{actor} created the group item {item}"
	/// </summary>
	public override string MessageCreateItems(string actor, string item)
	{
		return $"{actor} a créé l'objet de groupe {item}";
	}

	protected override string _GetTemplateForMessageCreateItems()
	{
		return "{actor} a créé l'objet de groupe {item}";
	}

	/// <summary>
	/// Key: "Message.DeclineAllyRequest"
	/// English String: "{actor} declined group {group}'s ally request"
	/// </summary>
	public override string MessageDeclineAllyRequest(string actor, string group)
	{
		return $"{actor} a refusé la demande d'alliance du groupe {group}";
	}

	protected override string _GetTemplateForMessageDeclineAllyRequest()
	{
		return "{actor} a refusé la demande d'alliance du groupe {group}";
	}

	/// <summary>
	/// Key: "Message.DeclineJoinRequest"
	/// English String: "{actor} declined user {user}'s join request"
	/// </summary>
	public override string MessageDeclineJoinRequest(string actor, string user)
	{
		return $"{actor} a refusé la demande de participation de {user}";
	}

	protected override string _GetTemplateForMessageDeclineJoinRequest()
	{
		return "{actor} a refusé la demande de participation de {user}";
	}

	protected override string _GetTemplateForMessageDefaultError()
	{
		return "Une erreur est survenue.";
	}

	/// <summary>
	/// Key: "Message.Delete"
	/// English String: "{actor} deleted current group"
	/// </summary>
	public override string MessageDelete(string actor)
	{
		return $"{actor} a supprimé le groupe actuel";
	}

	protected override string _GetTemplateForMessageDelete()
	{
		return "{actor} a supprimé le groupe actuel";
	}

	/// <summary>
	/// Key: "Message.DeleteAlly"
	/// English String: "{actor} removed group {group} as an ally"
	/// </summary>
	public override string MessageDeleteAlly(string actor, string group)
	{
		return $"{actor} a retiré le groupe {group} des alliés";
	}

	protected override string _GetTemplateForMessageDeleteAlly()
	{
		return "{actor} a retiré le groupe {group} des alliés";
	}

	/// <summary>
	/// Key: "Message.DeleteEnemy"
	/// English String: "{actor} removed group {group} as an enemy"
	/// </summary>
	public override string MessageDeleteEnemy(string actor, string group)
	{
		return $"{actor} a retiré le groupe {group} des ennemis";
	}

	protected override string _GetTemplateForMessageDeleteEnemy()
	{
		return "{actor} a retiré le groupe {group} des ennemis";
	}

	/// <summary>
	/// Key: "Message.DeleteGroupPlace"
	/// English String: "{actor} removed game {game} as a group game"
	/// </summary>
	public override string MessageDeleteGroupPlace(string actor, string game)
	{
		return $"{actor} a retiré le jeu {game} comme jeu de groupe";
	}

	protected override string _GetTemplateForMessageDeleteGroupPlace()
	{
		return "{actor} a retiré le jeu {game} comme jeu de groupe";
	}

	/// <summary>
	/// Key: "Message.DeletePost"
	/// English String: "{actor} deleted post \"{postDesc}\" by user {user}"
	/// </summary>
	public override string MessageDeletePost(string actor, string postDesc, string user)
	{
		return $"{actor} a supprimé le message «\u00a0{postDesc}\u00a0» de l'utilisateur {user}";
	}

	protected override string _GetTemplateForMessageDeletePost()
	{
		return "{actor} a supprimé le message «\u00a0{postDesc}\u00a0» de l'utilisateur {user}";
	}

	protected override string _GetTemplateForMessageDeleteWallPostError()
	{
		return "Impossible de supprimer le message du mur.";
	}

	protected override string _GetTemplateForMessageDeleteWallPostsByUserError()
	{
		return "Impossible de supprimer les messages ajoutés au mur par l'utilisateur.";
	}

	protected override string _GetTemplateForMessageDeleteWallPostSuccess()
	{
		return "Le message du mur a bien été supprimé.";
	}

	protected override string _GetTemplateForMessageDescriptionTooLong()
	{
		return "La description est trop longue.";
	}

	protected override string _GetTemplateForMessageDuplicateName()
	{
		return "Nom déjà utilisé. Essaies-en un autre.";
	}

	protected override string _GetTemplateForMessageExileUserError()
	{
		return "Impossible de bannir l'utilisateur.";
	}

	protected override string _GetTemplateForMessageFeatureDisabled()
	{
		return "Cette fonctionnalité est désactivée.";
	}

	protected override string _GetTemplateForMessageGetGroupRelationshipsError()
	{
		return "Impossible de charger les affiliés du groupe.";
	}

	protected override string _GetTemplateForMessageGroupClosed()
	{
		return "Vous ne pouvez pas rejoindre un groupe fermé.";
	}

	protected override string _GetTemplateForMessageGroupCreationDisabled()
	{
		return "La création de groupe est actuellement désactivée.";
	}

	protected override string _GetTemplateForMessageGroupIconInvalid()
	{
		return "Icône manquante ou invalide.";
	}

	/// <summary>
	/// Key: "Message.GroupIconTooLarge"
	/// English String: "Icon cannot be larger than {maxSize} mb."
	/// </summary>
	public override string MessageGroupIconTooLarge(string maxSize)
	{
		return $"Taille maximale d'icône {maxSize}mb.";
	}

	protected override string _GetTemplateForMessageGroupIconTooLarge()
	{
		return "Taille maximale d'icône {maxSize}mb.";
	}

	protected override string _GetTemplateForMessageGroupMembershipsUnavailableError()
	{
		return "Les abonnements de groupes sont temporairement indisponibles. Réessaye plus tard.";
	}

	protected override string _GetTemplateForMessageInsufficientFunds()
	{
		return "Pas assez de Robux.";
	}

	protected override string _GetTemplateForMessageInsufficientGroupSpace()
	{
		return "Vous avez déjà rejoint le nombre maximal de groupes.";
	}

	protected override string _GetTemplateForMessageInsufficientMembership()
	{
		return "Vous n'avez pas l'abonnement au Builders Club nécessaire pour rejoindre ce groupe.";
	}

	protected override string _GetTemplateForMessageInsufficientPermission()
	{
		return "Tu n'es pas autorisé.e à faire ça.";
	}

	protected override string _GetTemplateForMessageInsufficientPermissionsForRelationships()
	{
		return "Vous n'avez pas l'autorisation de modifier les relations de ce groupe.";
	}

	protected override string _GetTemplateForMessageInsufficientRobux()
	{
		return "Tu n'as pas assez de Robux pour créer le groupe.";
	}

	protected override string _GetTemplateForMessageInvalidAmount()
	{
		return "Le montant n'est pas valide.";
	}

	protected override string _GetTemplateForMessageInvalidGroup()
	{
		return "Le groupe n'est pas valide ou n'existe pas.";
	}

	protected override string _GetTemplateForMessageInvalidGroupIcon()
	{
		return "L'icône du groupe n'est pas valide.";
	}

	protected override string _GetTemplateForMessageInvalidGroupId()
	{
		return "Le groupe n'est pas valide ou n'existe pas.";
	}

	protected override string _GetTemplateForMessageInvalidGroupWallPostId()
	{
		return "L'ID du mur du groupe n'est pas valide ou n'existe pas.";
	}

	protected override string _GetTemplateForMessageInvalidIds()
	{
		return "Analyse des ID impossible pour cette requête.";
	}

	protected override string _GetTemplateForMessageInvalidIdsError()
	{
		return "Analyse des ID impossible pour cette requête.";
	}

	protected override string _GetTemplateForMessageInvalidMembership()
	{
		return "L'utilisateur doit être abonné au Builders Club";
	}

	protected override string _GetTemplateForMessageInvalidName()
	{
		return "Le nom n'est pas valide.";
	}

	protected override string _GetTemplateForMessageInvalidPaginationParameters()
	{
		return "Paramètres de pagination non valides ou inexistants.";
	}

	protected override string _GetTemplateForMessageInvalidPayoutType()
	{
		return "Mode de paiement invalide.";
	}

	protected override string _GetTemplateForMessageInvalidRecipient()
	{
		return "Le destinataire est invalide.";
	}

	protected override string _GetTemplateForMessageInvalidRelationshipType()
	{
		return "Le type de relation du groupe n'est pas valide.";
	}

	protected override string _GetTemplateForMessageInvalidRoleSetId()
	{
		return "Le rôle n'est pas valide ou n'existe pas.";
	}

	protected override string _GetTemplateForMessageInvalidUser()
	{
		return "L'utilisateur n'est pas valide ou n'existe pas.";
	}

	protected override string _GetTemplateForMessageInvalidWallPostContent()
	{
		return "Votre message était vide, ne contenait que des espaces ou comptait plus de 500\u00a0caractères.";
	}

	/// <summary>
	/// Key: "Message.InviteToClan"
	/// English String: "{actor} invited user {user} to the clan"
	/// </summary>
	public override string MessageInviteToClan(string actor, string user)
	{
		return $"{actor} a invité l'utilisateur {user} dans le clan";
	}

	protected override string _GetTemplateForMessageInviteToClan()
	{
		return "{actor} a invité l'utilisateur {user} dans le clan";
	}

	protected override string _GetTemplateForMessageJoinGroupError()
	{
		return "Impossible de rejoindre le groupe.";
	}

	protected override string _GetTemplateForMessageJoinGroupPendingSuccess()
	{
		return "Vous avez demandé à rejoindre le groupe\u00a0; la demande est en attente.";
	}

	protected override string _GetTemplateForMessageJoinGroupSuccess()
	{
		return "Vous avez rejoint le groupe.";
	}

	/// <summary>
	/// Key: "Message.KickFromClan"
	/// English String: "{actor} kicked user {user} out of the clan"
	/// </summary>
	public override string MessageKickFromClan(string actor, string user)
	{
		return $"{actor} a expulsé l'utilisateur {user} du clan";
	}

	protected override string _GetTemplateForMessageKickFromClan()
	{
		return "{actor} a expulsé l'utilisateur {user} du clan";
	}

	protected override string _GetTemplateForMessageLeaveGroupError()
	{
		return "Impossible de quitter le groupe.";
	}

	protected override string _GetTemplateForMessageLoadGroupError()
	{
		return "Impossible de charger le groupe.";
	}

	protected override string _GetTemplateForMessageLoadGroupGamesError()
	{
		return "Impossible de charger les jeux.";
	}

	protected override string _GetTemplateForMessageLoadGroupListError()
	{
		return "Impossible de charger la liste des groupes.";
	}

	protected override string _GetTemplateForMessageLoadGroupMembershipsError()
	{
		return "Impossible de charger les informations d'abonnement de l'utilisateur.";
	}

	protected override string _GetTemplateForMessageLoadGroupMetadataError()
	{
		return "Impossible de charger les informations du groupe.";
	}

	protected override string _GetTemplateForMessageLoadGroupStoreItemsError()
	{
		return "Impossible de charger les objets du magasin.";
	}

	protected override string _GetTemplateForMessageLoadUserGroupMembershipError()
	{
		return "Impossible de charger les informations du membre du groupe.";
	}

	protected override string _GetTemplateForMessageLoadWallPostsError()
	{
		return "Impossible de charger les messages du mur.";
	}

	/// <summary>
	/// Key: "Message.Lock"
	/// English String: "{actor} locked the group"
	/// </summary>
	public override string MessageLock(string actor)
	{
		return $"{actor} a verrouillé le groupe";
	}

	protected override string _GetTemplateForMessageLock()
	{
		return "{actor} a verrouillé le groupe";
	}

	protected override string _GetTemplateForMessageMakePrimaryError()
	{
		return "Impossible de créer le groupe principal.";
	}

	protected override string _GetTemplateForMessageMaxGroups()
	{
		return "L'utilisateur a déjà rejoint le nombre maximal de groupes.";
	}

	protected override string _GetTemplateForMessageMissingGroupIcon()
	{
		return "Il manque l'icône du groupe pour cette requête.";
	}

	protected override string _GetTemplateForMessageMissingGroupStatusContent()
	{
		return "Statut du groupe manquant.";
	}

	protected override string _GetTemplateForMessageNameInvalid()
	{
		return "Nom manquant ou contient des symboles invalides.";
	}

	protected override string _GetTemplateForMessageNameModerated()
	{
		return "Le nom est modéré.";
	}

	protected override string _GetTemplateForMessageNameTaken()
	{
		return "Le nom est déjà pris.";
	}

	protected override string _GetTemplateForMessageNameTooLong()
	{
		return "Le nom est trop long.";
	}

	protected override string _GetTemplateForMessageNoPrimary()
	{
		return "L'utilisateur indiqué n'a pas de groupe principal.";
	}

	protected override string _GetTemplateForMessagePassCaptchaToJoin()
	{
		return "Vous devez effectuer la vérification captcha avant de rejoindre ce groupe.";
	}

	protected override string _GetTemplateForMessagePassCaptchaToPost()
	{
		return "Le captcha doit être résolu avant de pouvoir écrire sur le mur du groupe.";
	}

	/// <summary>
	/// Key: "Message.PostStatus"
	/// English String: "{actor} changed the group status to \"{groupStatus}\""
	/// </summary>
	public override string MessagePostStatus(string actor, string groupStatus)
	{
		return $"{actor} a modifié le statut du groupe en «\u00a0{groupStatus}\u00a0»";
	}

	protected override string _GetTemplateForMessagePostStatus()
	{
		return "{actor} a modifié le statut du groupe en «\u00a0{groupStatus}\u00a0»";
	}

	/// <summary>
	/// Key: "Message.RemoveMember"
	/// English String: "{actor} kicked user {user}"
	/// </summary>
	public override string MessageRemoveMember(string actor, string user)
	{
		return $"{actor} a expulsé l'utilisateur {user}";
	}

	protected override string _GetTemplateForMessageRemoveMember()
	{
		return "{actor} a expulsé l'utilisateur {user}";
	}

	protected override string _GetTemplateForMessageRemovePrimaryError()
	{
		return "Impossible de supprimer le groupe principal.";
	}

	/// <summary>
	/// Key: "Message.Rename"
	/// English String: "{actor} renamed current group to {newName}"
	/// </summary>
	public override string MessageRename(string actor, string newName)
	{
		return $"{actor} a renommé le groupe en {newName}";
	}

	protected override string _GetTemplateForMessageRename()
	{
		return "{actor} a renommé le groupe en {newName}";
	}

	protected override string _GetTemplateForMessageSearchTermCharactersLimit()
	{
		return "Le terme de recherche doit être entre 2 et 50 caractères";
	}

	protected override string _GetTemplateForMessageSearchTermEmptyError()
	{
		return "Le champ de recherche est vide";
	}

	protected override string _GetTemplateForMessageSearchTermFilteredError()
	{
		return "Le champ de recherche a été modéré";
	}

	/// <summary>
	/// Key: "Message.SendAllyRequest"
	/// English String: "{actor} sent an ally request to group {group}"
	/// </summary>
	public override string MessageSendAllyRequest(string actor, string group)
	{
		return $"{actor} a envoyé une demande d'alliance au groupe {group}";
	}

	protected override string _GetTemplateForMessageSendAllyRequest()
	{
		return "{actor} a envoyé une demande d'alliance au groupe {group}";
	}

	protected override string _GetTemplateForMessageSendGroupShoutError()
	{
		return "Impossible d'envoyer un appel de groupe.";
	}

	protected override string _GetTemplateForMessageSendPostError()
	{
		return "Impossible de publier le message.";
	}

	/// <summary>
	/// Key: "Message.SpendGroupFunds"
	/// English String: "{actor} spent {amount} of group funds for: {item}"
	/// </summary>
	public override string MessageSpendGroupFunds(string actor, string amount, string item)
	{
		return $"{actor} a dépensé {amount} des fonds du groupe pour\u00a0: {item}";
	}

	protected override string _GetTemplateForMessageSpendGroupFunds()
	{
		return "{actor} a dépensé {amount} des fonds du groupe pour\u00a0: {item}";
	}

	protected override string _GetTemplateForMessageTooManyAttempts()
	{
		return "Trop de tentatives pour rejoindre le groupe. Veuillez réessayer plus tard.";
	}

	protected override string _GetTemplateForMessageTooManyAttemptsToClaimGroups()
	{
		return "Trop de tentatives pour revendiquer des groupes. Veuillez réessayer plus tard.";
	}

	protected override string _GetTemplateForMessageTooManyGroups()
	{
		return "Capacité maximale atteinte. Quitte un groupe avant de pouvoir en créer un nouveau.";
	}

	protected override string _GetTemplateForMessageTooManyIds()
	{
		return "Trop grand nombre d'ID pour cette requête.";
	}

	protected override string _GetTemplateForMessageTooManyPosts()
	{
		return "Vous écrivez trop de messages, veuillez réessayer dans quelques minutes.";
	}

	protected override string _GetTemplateForMessageTooManyRequests()
	{
		return "Trop de requêtes.";
	}

	protected override string _GetTemplateForMessageUnauthorizedForPostStatus()
	{
		return "Vous n'avez pas l'autorisation de modifier le statut de ce groupe.";
	}

	protected override string _GetTemplateForMessageUnauthorizedForViewGroupPayouts()
	{
		return "Vous n'avez pas l'autorisation de voir les gains de ce groupe.";
	}

	protected override string _GetTemplateForMessageUnauthorizedToClaimGroup()
	{
		return "Vous n'avez pas l'autorisation de revendiquer ce groupe.";
	}

	protected override string _GetTemplateForMessageUnauthorizedToManageMember()
	{
		return "Vous n'avez pas la permission d'éditer ce membre.";
	}

	protected override string _GetTemplateForMessageUnauthorizedToViewRolesetPermissions()
	{
		return "Vous n'avez pas l'autorisation de voir les permissions pour ce rôle.";
	}

	protected override string _GetTemplateForMessageUnauthorizedToViewWall()
	{
		return "Vous n'avez pas la permission d'accéder au mur de ce groupe.";
	}

	protected override string _GetTemplateForMessageUnknownError()
	{
		return "Erreur inconnue";
	}

	/// <summary>
	/// Key: "Message.Unlock"
	/// English String: "{actor} unlocked the group"
	/// </summary>
	public override string MessageUnlock(string actor)
	{
		return $"{actor} a déverrouillé le groupe";
	}

	protected override string _GetTemplateForMessageUnlock()
	{
		return "{actor} a déverrouillé le groupe";
	}

	/// <summary>
	/// Key: "Message.UpdateAsset"
	/// English String: "{actor} created new version {version} of asset {item}"
	/// </summary>
	public override string MessageUpdateAsset(string actor, string version, string item)
	{
		return $"{actor} a créé une la version\u00a0{version} de l'élément {item}";
	}

	protected override string _GetTemplateForMessageUpdateAsset()
	{
		return "{actor} a créé une la version\u00a0{version} de l'élément {item}";
	}

	/// <summary>
	/// Key: "Message.UpdateAssetRevert"
	/// English String: "{actor} reverted asset {item} from version {version} to {oldVersion}"
	/// </summary>
	public override string MessageUpdateAssetRevert(string actor, string item, string version, string oldVersion)
	{
		return $"{actor} a rétrogradé l'élément {item} de la version\u00a0{version} à\u00a0{oldVersion}";
	}

	protected override string _GetTemplateForMessageUpdateAssetRevert()
	{
		return "{actor} a rétrogradé l'élément {item} de la version\u00a0{version} à\u00a0{oldVersion}";
	}

	protected override string _GetTemplateForMessageUserNotInGroup()
	{
		return "Tu ne fais pas partie du groupe indiqué.";
	}
}
