namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides GroupsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class GroupsResources_es_es : GroupsResources_en_us, IGroupsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.AdvertiseGroup"
	/// English String: "Advertise Group"
	/// </summary>
	public override string ActionAdvertiseGroup => "Promocionar grupo";

	/// <summary>
	/// Key: "Action.AuditLog"
	/// English String: "Audit Log"
	/// </summary>
	public override string ActionAuditLog => "Registro de auditoría";

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "Cancelar";

	/// <summary>
	/// Key: "Action.CancelRequest"
	/// English String: "Cancel Request"
	/// </summary>
	public override string ActionCancelRequest => "Cancelar la solicitud";

	/// <summary>
	/// Key: "Action.ClaimOwnership"
	/// English String: "Claim Ownership"
	/// </summary>
	public override string ActionClaimOwnership => "Reclamar la propiedad";

	/// <summary>
	/// Key: "Action.Close"
	/// English String: "Close"
	/// </summary>
	public override string ActionClose => "Cerrar";

	/// <summary>
	/// Key: "Action.ConfigureGroup"
	/// English String: "Configure Group"
	/// </summary>
	public override string ActionConfigureGroup => "Configurar grupo";

	/// <summary>
	/// Key: "Action.CreateGroup"
	/// English String: "Create Group"
	/// </summary>
	public override string ActionCreateGroup => "Crear grupo";

	/// <summary>
	/// Key: "Action.Delete"
	/// English String: "Delete"
	/// </summary>
	public override string ActionDelete => "Eliminar";

	/// <summary>
	/// Key: "Action.Exile"
	/// English String: "Exile"
	/// </summary>
	public override string ActionExile => "Expulsar";

	/// <summary>
	/// Key: "Action.ExileUser"
	/// English String: "Exile User"
	/// </summary>
	public override string ActionExileUser => "Expulsar usuario";

	/// <summary>
	/// Key: "Action.GroupAdmin"
	/// English String: "Group Admin"
	/// </summary>
	public override string ActionGroupAdmin => "Administrador del grupo";

	/// <summary>
	/// Key: "Action.GroupShout"
	/// Text on the button for sending / posting a group shout
	/// English String: "Group Shout"
	/// </summary>
	public override string ActionGroupShout => "Anuncio grupal";

	/// <summary>
	/// Key: "Action.JoinGroup"
	/// English String: "Join Group"
	/// </summary>
	public override string ActionJoinGroup => "Unirse al grupo";

	/// <summary>
	/// Key: "Action.LeaveGroup"
	/// English String: "Leave Group"
	/// </summary>
	public override string ActionLeaveGroup => "Salir del grupo";

	/// <summary>
	/// Key: "Action.MakePrimary"
	/// English String: "Make Primary"
	/// </summary>
	public override string ActionMakePrimary => "Convertir en grupo principal";

	/// <summary>
	/// Key: "Action.MakePrimaryGroup"
	/// Set the current group as the users primary group
	/// English String: "Make Primary Group"
	/// </summary>
	public override string ActionMakePrimaryGroup => "Convertir en grupo principal";

	/// <summary>
	/// Key: "Action.Post"
	/// English String: "Post"
	/// </summary>
	public override string ActionPost => "Publicar";

	/// <summary>
	/// Key: "Action.Purchase"
	/// English String: "Purchase"
	/// </summary>
	public override string ActionPurchase => "Comprar";

	/// <summary>
	/// Key: "Action.RemovePrimary"
	/// English String: "Remove Primary"
	/// </summary>
	public override string ActionRemovePrimary => "Eliminar grupo principal";

	/// <summary>
	/// Key: "Action.Report"
	/// English String: "Report"
	/// </summary>
	public override string ActionReport => "Denunciar";

	/// <summary>
	/// Key: "Action.ReportAbuse"
	/// English String: "Report Abuse"
	/// </summary>
	public override string ActionReportAbuse => "Denunciar abuso";

	/// <summary>
	/// Key: "Action.Upgrade"
	/// English String: "Upgrade"
	/// </summary>
	public override string ActionUpgrade => "Mejorar";

	/// <summary>
	/// Key: "Action.UpgradeToJoin"
	/// English String: "Upgrade to Join"
	/// </summary>
	public override string ActionUpgradeToJoin => "Mejorar suscripción para unirse";

	/// <summary>
	/// Key: "Action.Yes"
	/// English String: "Yes"
	/// </summary>
	public override string ActionYes => "Sí";

	/// <summary>
	/// Key: "Description.ClothingRevenue"
	/// English String: "Groups have the ability to create and sell official shirts, pants, and t-shirts! All revenue goes to group funds."
	/// </summary>
	public override string DescriptionClothingRevenue => "Los grupos pueden crear y vender camisas, pantalones y camisetas oficiales. Todos los ingresos de la venta se depositarán en los fondos del grupo.";

	/// <summary>
	/// Key: "Description.DeleteAllPostsByUser"
	/// English String: "Also delete all posts by this user."
	/// </summary>
	public override string DescriptionDeleteAllPostsByUser => "Esta acción eliminará todos los mensajes publicados por este usuario.";

	/// <summary>
	/// Key: "Description.ExileUserWarning"
	/// English String: "Are you sure you want to exile this user?"
	/// </summary>
	public override string DescriptionExileUserWarning => "¿Seguro que quieres expulsar a este usuario?";

	/// <summary>
	/// Key: "Description.LeaveGroupAsOwnerWarning"
	/// English String: "This will leave the group ownerless."
	/// </summary>
	public override string DescriptionLeaveGroupAsOwnerWarning => "Esta acción dejará el grupo sin dueño.";

	/// <summary>
	/// Key: "Description.LeaveGroupWarning"
	/// English String: "Are you sure you want to leave this group?"
	/// </summary>
	public override string DescriptionLeaveGroupWarning => "¿Seguro que quieres salir de este grupo?";

	/// <summary>
	/// Key: "Description.MakePrimaryGroupWarning"
	/// English String: "Are you sure you want to make this your primary group?"
	/// </summary>
	public override string DescriptionMakePrimaryGroupWarning => "¿Seguro que quieres convertirlo en tu grupo principal?";

	/// <summary>
	/// Key: "Description.NoneMaxGroups"
	/// English String: "Upgrade to Builders Club to join more groups."
	/// </summary>
	public override string DescriptionNoneMaxGroups => "Mejora tu suscripción al Builders Club para unirte a más grupos.";

	/// <summary>
	/// Key: "Description.NoneMaxGroupsPremium"
	/// English String: "Upgrade to Roblox Premium to join more groups."
	/// </summary>
	public override string DescriptionNoneMaxGroupsPremium => "Mejora tu suscripción a Roblox Premium para unirte a más grupos.";

	/// <summary>
	/// Key: "Description.noneMaxGroupsPremiumText"
	/// English String: "Upgrade to Roblox Premium to join more groups."
	/// </summary>
	public override string DescriptionnoneMaxGroupsPremiumText => "Mejora tu suscripción a Roblox Premium para unirte a más grupos.";

	/// <summary>
	/// Key: "Description.ObcMaxGroups"
	/// English String: "You have joined the maximum number of groups."
	/// </summary>
	public override string DescriptionObcMaxGroups => "Te has unido al número máximo de grupos.";

	/// <summary>
	/// Key: "Description.OtherBcMaxGroups"
	/// English String: "Upgrade your Builders Club to join more groups."
	/// </summary>
	public override string DescriptionOtherBcMaxGroups => "Mejora tu suscripción de Builders Club para unirte a más grupos.";

	/// <summary>
	/// Key: "Description.otherPremiumMaxGroupsText"
	/// English String: "Upgrade your Roblox Premium to join more groups."
	/// </summary>
	public override string DescriptionotherPremiumMaxGroupsText => "Mejora tu suscripción de Roblox Premium para unirte a más grupos.";

	/// <summary>
	/// Key: "Description.PremiumMaxGroups"
	/// English String: "You have joined the maximum number of groups."
	/// </summary>
	public override string DescriptionPremiumMaxGroups => "Te has unido al número máximo de grupos.";

	/// <summary>
	/// Key: "Description.PurchaseBody"
	/// English String: "Would you like to create this group for"
	/// </summary>
	public override string DescriptionPurchaseBody => "¿Quieres crear este grupo por";

	/// <summary>
	/// Key: "Description.RemovePrimaryGroupWarning"
	/// English String: "Are you sure you want to remove your primary group?"
	/// </summary>
	public override string DescriptionRemovePrimaryGroupWarning => "¿Seguro que quieres eliminar tu grupo principal?";

	/// <summary>
	/// Key: "Description.ReportAbuseDescription"
	/// English String: "What would you like to report?"
	/// </summary>
	public override string DescriptionReportAbuseDescription => "¿Qué quieres denunciar?";

	/// <summary>
	/// Key: "Description.WallPrivacySettings"
	/// English String: "Your privacy settings do not allow you to post to group walls. Click here to adjust these settings."
	/// </summary>
	public override string DescriptionWallPrivacySettings => "Tu configuración de privacidad no te permite publicar en el muro del grupo. Haz clic aquí para modificar los parámetros.";

	/// <summary>
	/// Key: "Heading.About"
	/// English String: "About"
	/// </summary>
	public override string HeadingAbout => "Sobre el grupo";

	/// <summary>
	/// Key: "Heading.Affiliates"
	/// English String: "Affiliates"
	/// </summary>
	public override string HeadingAffiliates => "Afiliados";

	/// <summary>
	/// Key: "Heading.Allies"
	/// English String: "Allies"
	/// </summary>
	public override string HeadingAllies => "Aliados";

	/// <summary>
	/// Key: "Heading.Date"
	/// English String: "Date"
	/// </summary>
	public override string HeadingDate => "Fecha";

	/// <summary>
	/// Key: "Heading.Description"
	/// English String: "Description"
	/// </summary>
	public override string HeadingDescription => "Descripción";

	/// <summary>
	/// Key: "Heading.Enemies"
	/// English String: "Enemies"
	/// </summary>
	public override string HeadingEnemies => "Enemigos";

	/// <summary>
	/// Key: "Heading.ExileUserWarning"
	/// English String: "Warning"
	/// </summary>
	public override string HeadingExileUserWarning => "Advertencia";

	/// <summary>
	/// Key: "Heading.Funds"
	/// English String: "Funds"
	/// </summary>
	public override string HeadingFunds => "Fondos";

	/// <summary>
	/// Key: "Heading.Games"
	/// English String: "Games"
	/// </summary>
	public override string HeadingGames => "Juegos";

	/// <summary>
	/// Key: "Heading.GroupPurchase"
	/// English String: "Group Purchase Confirmation"
	/// </summary>
	public override string HeadingGroupPurchase => "Confirmación de compra de grupo";

	/// <summary>
	/// Key: "Heading.GroupShout"
	/// English String: "Group Shout"
	/// </summary>
	public override string HeadingGroupShout => "Anuncio grupal";

	/// <summary>
	/// Key: "Heading.LeaveGroup"
	/// English String: "Leave Group"
	/// </summary>
	public override string HeadingLeaveGroup => "Salir del grupo";

	/// <summary>
	/// Key: "Heading.MakePrimaryGroup"
	/// Heading of make primary group modal
	/// English String: "Make Primary Group"
	/// </summary>
	public override string HeadingMakePrimaryGroup => "Convertir en grupo principal";

	/// <summary>
	/// Key: "Heading.Members"
	/// English String: "Members"
	/// </summary>
	public override string HeadingMembers => "Miembros";

	/// <summary>
	/// Key: "Heading.NameOrDescription"
	/// Selection option for what to report when reporting something in a group
	/// English String: "Name or Description"
	/// </summary>
	public override string HeadingNameOrDescription => "Nombre o descripción";

	/// <summary>
	/// Key: "Heading.Payouts"
	/// English String: "Payouts"
	/// </summary>
	public override string HeadingPayouts => "Pagos";

	/// <summary>
	/// Key: "Heading.Primary"
	/// English String: "Primary"
	/// </summary>
	public override string HeadingPrimary => "Principal";

	/// <summary>
	/// Key: "Heading.Rank"
	/// English String: "Rank"
	/// </summary>
	public override string HeadingRank => "Rango";

	/// <summary>
	/// Key: "Heading.RemovePrimaryGroup"
	/// English String: "Remove Primary Group"
	/// </summary>
	public override string HeadingRemovePrimaryGroup => "Eliminar grupo principal";

	/// <summary>
	/// Key: "Heading.Role"
	/// English String: "Role"
	/// </summary>
	public override string HeadingRole => "Rol";

	/// <summary>
	/// Key: "Heading.Settings"
	/// English String: "Settings"
	/// </summary>
	public override string HeadingSettings => "Configuración";

	/// <summary>
	/// Key: "Heading.Shout"
	/// To be displayed above the group shout (the current status for a group set by admins)
	/// English String: "Shout"
	/// </summary>
	public override string HeadingShout => "Anuncio";

	/// <summary>
	/// Key: "Heading.Store"
	/// English String: "Store"
	/// </summary>
	public override string HeadingStore => "Tienda";

	/// <summary>
	/// Key: "Heading.User"
	/// English String: "User"
	/// </summary>
	public override string HeadingUser => "Usuario";

	/// <summary>
	/// Key: "Heading.Wall"
	/// English String: "Wall"
	/// </summary>
	public override string HeadingWall => "Muro";

	/// <summary>
	/// Key: "Label.Abandon"
	/// English String: "Abandon"
	/// </summary>
	public override string LabelAbandon => "Abandonar";

	/// <summary>
	/// Key: "Label.AcceptAllyRequest"
	/// English String: "Accept Ally Request"
	/// </summary>
	public override string LabelAcceptAllyRequest => "Aceptar solicitud de aliado";

	/// <summary>
	/// Key: "Label.AcceptJoinRequest"
	/// English String: "Accept Join Request"
	/// </summary>
	public override string LabelAcceptJoinRequest => "Aceptar solicitud a unirse";

	/// <summary>
	/// Key: "Label.AddGroupPlace"
	/// English String: "Add Group Place"
	/// </summary>
	public override string LabelAddGroupPlace => "Añadir un lugar de grupo";

	/// <summary>
	/// Key: "Label.AdjustCurrencyAmounts"
	/// English String: "Adjust Currency Amounts"
	/// </summary>
	public override string LabelAdjustCurrencyAmounts => "Ajustar monto";

	/// <summary>
	/// Key: "Label.All"
	/// English String: "All"
	/// </summary>
	public override string LabelAll => "Todos";

	/// <summary>
	/// Key: "Label.AnyoneCanJoin"
	/// English String: "Anyone Can Join"
	/// </summary>
	public override string LabelAnyoneCanJoin => "Todos pueden unirse";

	/// <summary>
	/// Key: "Label.BuyAd"
	/// English String: "Buy Ad"
	/// </summary>
	public override string LabelBuyAd => "Comprar anuncio";

	/// <summary>
	/// Key: "Label.BuyClan"
	/// English String: "Buy Clan"
	/// </summary>
	public override string LabelBuyClan => "Comprar clan";

	/// <summary>
	/// Key: "Label.ByOwner"
	/// Prefix to either the owner of the group, or "No One!" if the group has no owner. Could not properly format like By {ownerName} because ownerName is a link in this case
	/// English String: "By"
	/// </summary>
	public override string LabelByOwner => "De";

	/// <summary>
	/// Key: "Label.CancelClanInvite"
	/// English String: "Cancel Clan Invite"
	/// </summary>
	public override string LabelCancelClanInvite => "Cancelar invitación del clan";

	/// <summary>
	/// Key: "Label.ChangeDescription"
	/// English String: "Change Description"
	/// </summary>
	public override string LabelChangeDescription => "Cambiar descripción";

	/// <summary>
	/// Key: "Label.ChangeOwner"
	/// English String: "Change Owner"
	/// </summary>
	public override string LabelChangeOwner => "Cambiar propietario";

	/// <summary>
	/// Key: "Label.ChangeRank"
	/// English String: "Change Rank"
	/// </summary>
	public override string LabelChangeRank => "Cambiar rango";

	/// <summary>
	/// Key: "Label.Claim"
	/// English String: "Claim"
	/// </summary>
	public override string LabelClaim => "Reclamar";

	/// <summary>
	/// Key: "Label.ConfigureBadge"
	/// English String: "Configure Badge"
	/// </summary>
	public override string LabelConfigureBadge => "Configurar emblema";

	/// <summary>
	/// Key: "Label.ConfigureGroupAsset"
	/// English String: "Configure Group Asset"
	/// </summary>
	public override string LabelConfigureGroupAsset => "Configurar recurso de grupo";

	/// <summary>
	/// Key: "Label.ConfigureGroupDevelopmentItem"
	/// English String: "Configure Group Development Item"
	/// </summary>
	public override string LabelConfigureGroupDevelopmentItem => "Configurar objeto de desarrollo del grupo";

	/// <summary>
	/// Key: "Label.ConfigureGroupGame"
	/// English String: "Configure Group Game"
	/// </summary>
	public override string LabelConfigureGroupGame => "Configurar juego del grupo";

	/// <summary>
	/// Key: "Label.ConfigureItems"
	/// English String: "Configure Items"
	/// </summary>
	public override string LabelConfigureItems => "Configurar objetos";

	/// <summary>
	/// Key: "Label.CreateBadge"
	/// English String: "Create Badge"
	/// </summary>
	public override string LabelCreateBadge => "Crear emblema";

	/// <summary>
	/// Key: "Label.CreateEnemy"
	/// English String: "Create Enemy"
	/// </summary>
	public override string LabelCreateEnemy => "Crear enemigo";

	/// <summary>
	/// Key: "Label.CreateGamePass"
	/// English String: "Create Game Pass"
	/// </summary>
	public override string LabelCreateGamePass => "Crear pase del juego";

	/// <summary>
	/// Key: "Label.CreateGroup"
	/// English String: "Create Group"
	/// </summary>
	public override string LabelCreateGroup => "Crear grupo";

	/// <summary>
	/// Key: "Label.CreateGroupAsset"
	/// English String: "Create Group Asset"
	/// </summary>
	public override string LabelCreateGroupAsset => "Crear recurso de grupo";

	/// <summary>
	/// Key: "Label.CreateGroupBuildersClubTooltip"
	/// English String: "Creating a group requires a Builders Club membership."
	/// </summary>
	public override string LabelCreateGroupBuildersClubTooltip => "Para crear un nuevo grupo se requiere la suscripción al Builders Club.";

	/// <summary>
	/// Key: "Label.CreateGroupDescription"
	/// English String: "Description (optional)"
	/// </summary>
	public override string LabelCreateGroupDescription => "Descripción (opcional)";

	/// <summary>
	/// Key: "Label.CreateGroupDeveloperProduct"
	/// English String: "Create Group Developer Product"
	/// </summary>
	public override string LabelCreateGroupDeveloperProduct => "Crear producto de grupo de desarrolladores";

	/// <summary>
	/// Key: "Label.CreateGroupEmblem"
	/// English String: "Emblem"
	/// </summary>
	public override string LabelCreateGroupEmblem => "Emblema";

	/// <summary>
	/// Key: "Label.CreateGroupFee"
	/// English String: "Group Creation Fee"
	/// </summary>
	public override string LabelCreateGroupFee => "Cuota de creación de grupo";

	/// <summary>
	/// Key: "Label.CreateGroupName"
	/// English String: "Name your group"
	/// </summary>
	public override string LabelCreateGroupName => "Ponle nombre a tu grupo";

	/// <summary>
	/// Key: "Label.CreateGroupPremiumTooltip"
	/// English String: "Creating a group requires a Roblox Premium membership."
	/// </summary>
	public override string LabelCreateGroupPremiumTooltip => "Para crear un grupo se requiere la suscripción a Roblox Premium.";

	/// <summary>
	/// Key: "Label.CreateGroupTooltip"
	/// English String: "Create a new group"
	/// </summary>
	public override string LabelCreateGroupTooltip => "Crear un nuevo grupo";

	/// <summary>
	/// Key: "Label.CreateItems"
	/// English String: "Create Items"
	/// </summary>
	public override string LabelCreateItems => "Crear objetos";

	/// <summary>
	/// Key: "Label.DeclineAllyRequest"
	/// English String: "Decline Ally Request"
	/// </summary>
	public override string LabelDeclineAllyRequest => "Rechazar solicitud de aliado";

	/// <summary>
	/// Key: "Label.DeclineJoinRequest"
	/// English String: "Decline Join Request"
	/// </summary>
	public override string LabelDeclineJoinRequest => "Rechazar solicitud a unirse";

	/// <summary>
	/// Key: "Label.Delete"
	/// English String: "Delete"
	/// </summary>
	public override string LabelDelete => "Eliminar";

	/// <summary>
	/// Key: "Label.DeleteAllPostsByUser"
	/// English String: "Also delete all posts by this user."
	/// </summary>
	public override string LabelDeleteAllPostsByUser => "Eliminar todas sus publicaciones.";

	/// <summary>
	/// Key: "Label.DeleteAlly"
	/// English String: "Delete Ally"
	/// </summary>
	public override string LabelDeleteAlly => "Eliminar aliado";

	/// <summary>
	/// Key: "Label.DeleteEnemy"
	/// English String: "Delete Enemy"
	/// </summary>
	public override string LabelDeleteEnemy => "Eliminar enemigo";

	/// <summary>
	/// Key: "Label.DeleteGroupPlace"
	/// English String: "Delete Group Place"
	/// </summary>
	public override string LabelDeleteGroupPlace => "Eliminar lugar de grupo";

	/// <summary>
	/// Key: "Label.DeletePost"
	/// English String: "Delete Post"
	/// </summary>
	public override string LabelDeletePost => "Eliminar publicación";

	/// <summary>
	/// Key: "Label.Funds"
	/// English String: "Funds"
	/// </summary>
	public override string LabelFunds => "Fondos";

	/// <summary>
	/// Key: "Label.GroupClosed"
	/// English String: "Group Closed"
	/// </summary>
	public override string LabelGroupClosed => "Grupo cerrado";

	/// <summary>
	/// Key: "Label.GroupLocked"
	/// English String: "This group has been locked"
	/// </summary>
	public override string LabelGroupLocked => "Este grupo ha sido bloqueado";

	/// <summary>
	/// Key: "Label.InviteToClan"
	/// English String: "Invite to Clan"
	/// </summary>
	public override string LabelInviteToClan => "Invitar al clan";

	/// <summary>
	/// Key: "Label.KickFromClan"
	/// English String: "Kick from Clan"
	/// </summary>
	public override string LabelKickFromClan => "Expulsar del clan";

	/// <summary>
	/// Key: "Label.Loading"
	/// English String: "Loading..."
	/// </summary>
	public override string LabelLoading => "Cargando...";

	/// <summary>
	/// Key: "Label.Lock"
	/// English String: "Lock"
	/// </summary>
	public override string LabelLock => "Bloquear";

	/// <summary>
	/// Key: "Label.ManageGroupCreations"
	/// English String: "Create or manage group items."
	/// </summary>
	public override string LabelManageGroupCreations => "Crear o administrar objetos del grupo";

	/// <summary>
	/// Key: "Label.ManualApproval"
	/// English String: "Manual Approval"
	/// </summary>
	public override string LabelManualApproval => "Aprobación manual";

	/// <summary>
	/// Key: "Label.ModerateDiscussion"
	/// English String: "Moderate Discussion"
	/// </summary>
	public override string LabelModerateDiscussion => "Moderar discusión";

	/// <summary>
	/// Key: "Label.NoAllies"
	/// English String: "This group does not have any allies."
	/// </summary>
	public override string LabelNoAllies => "Este grupo no tiene aliados.";

	/// <summary>
	/// Key: "Label.NoEnemies"
	/// English String: "This group does not have any enemies."
	/// </summary>
	public override string LabelNoEnemies => "Este grupo no tiene enemigos.";

	/// <summary>
	/// Key: "Label.NoGames"
	/// English String: "No games are associated with this group."
	/// </summary>
	public override string LabelNoGames => "No hay juegos asociados con este grupo.";

	/// <summary>
	/// Key: "Label.NoMembersInRole"
	/// English String: "No group members are in this role."
	/// </summary>
	public override string LabelNoMembersInRole => "No hay miembros del grupo que desempeñan esta función.";

	/// <summary>
	/// Key: "Label.NoOne"
	/// English String: "No One!"
	/// </summary>
	public override string LabelNoOne => "¡Nadie!";

	/// <summary>
	/// Key: "Label.NoStoreItems"
	/// English String: "No items are for sale in this group."
	/// </summary>
	public override string LabelNoStoreItems => "No hay objetos a la venta en este grupo.";

	/// <summary>
	/// Key: "Label.NoWallPosts"
	/// English String: "Nobody has said anything yet..."
	/// </summary>
	public override string LabelNoWallPosts => "Nadie ha dicho nada todavía...";

	/// <summary>
	/// Key: "Label.OnlyBcCanJoin"
	/// English String: "Only Builders Club members can join"
	/// </summary>
	public override string LabelOnlyBcCanJoin => "Solo los miembros del Builders Club pueden unirse";

	/// <summary>
	/// Key: "Label.OnlyPremiumCanJoin"
	/// English String: "Only users with membership can join"
	/// </summary>
	public override string LabelOnlyPremiumCanJoin => "Solo los usuarios con una suscripción pueden unirse";

	/// <summary>
	/// Key: "Label.PrivateGroup"
	/// If group is invite only
	/// English String: "Private"
	/// </summary>
	public override string LabelPrivateGroup => "Privado";

	/// <summary>
	/// Key: "Label.PublicGroup"
	/// If group is open for anyone to join
	/// English String: "Public"
	/// </summary>
	public override string LabelPublicGroup => "Público";

	/// <summary>
	/// Key: "Label.PublishPlace"
	/// English String: "Publish Place"
	/// </summary>
	public override string LabelPublishPlace => "Publicar lugar";

	/// <summary>
	/// Key: "Label.RemoveGroupPlace"
	/// English String: "Remove Group Place"
	/// </summary>
	public override string LabelRemoveGroupPlace => "Eliminar un lugar de grupo";

	/// <summary>
	/// Key: "Label.RemoveMember"
	/// English String: "Remove Member"
	/// </summary>
	public override string LabelRemoveMember => "Eliminar miembro";

	/// <summary>
	/// Key: "Label.Rename"
	/// English String: "Rename"
	/// </summary>
	public override string LabelRename => "Renombrar";

	/// <summary>
	/// Key: "Label.RevertGroupAsset"
	/// English String: "Revert Group Asset"
	/// </summary>
	public override string LabelRevertGroupAsset => "Revertir recurso de grupo";

	/// <summary>
	/// Key: "Label.SavePlace"
	/// English String: "Save Place"
	/// </summary>
	public override string LabelSavePlace => "Guardar lugar";

	/// <summary>
	/// Key: "Label.SearchGroups"
	/// English String: "Search All Groups"
	/// </summary>
	public override string LabelSearchGroups => "Buscar todos los grupos";

	/// <summary>
	/// Key: "Label.SearchUsers"
	/// English String: "Search Users"
	/// </summary>
	public override string LabelSearchUsers => "Buscar usuarios";

	/// <summary>
	/// Key: "Label.SendAllyRequest"
	/// English String: "Send Ally Request"
	/// </summary>
	public override string LabelSendAllyRequest => "Enviar una solicitud de aliado";

	/// <summary>
	/// Key: "Label.ShoutPlaceholder"
	/// English String: "Enter your shout"
	/// </summary>
	public override string LabelShoutPlaceholder => "Introduce tu anuncio";

	/// <summary>
	/// Key: "Label.SpendGroupFunds"
	/// English String: "Spend Group Funds"
	/// </summary>
	public override string LabelSpendGroupFunds => "Gastar fondos del grupo";

	/// <summary>
	/// Key: "Label.Success"
	/// English String: "Success"
	/// </summary>
	public override string LabelSuccess => "Hecho";

	/// <summary>
	/// Key: "Label.Unlock"
	/// English String: "Unlock"
	/// </summary>
	public override string LabelUnlock => "Desbloquear";

	/// <summary>
	/// Key: "Label.UpdateGroupAsset"
	/// English String: "Update Group Asset"
	/// </summary>
	public override string LabelUpdateGroupAsset => "Actualizar recurso de grupo";

	/// <summary>
	/// Key: "Label.WallPostPlaceholder"
	/// English String: "Say something..."
	/// </summary>
	public override string LabelWallPostPlaceholder => "Di algo...";

	/// <summary>
	/// Key: "Label.WallPostsUnavailable"
	/// Displayed in the group wall area when we cannot successfully load wall posts
	/// English String: "Wall posts are temporarily unavailable, please check back later."
	/// </summary>
	public override string LabelWallPostsUnavailable => "La publicaciones del muro no están disponibles temporalmente. Inténtalo más tarde.";

	/// <summary>
	/// Key: "Label.Warning"
	/// English String: "Warning"
	/// </summary>
	public override string LabelWarning => "Advertencia";

	/// <summary>
	/// Key: "Message.AlreadyMember"
	/// English String: "You are already a member of this group."
	/// </summary>
	public override string MessageAlreadyMember => "Ya eres miembro de este grupo.";

	/// <summary>
	/// Key: "Message.AlreadyRequested"
	/// English String: "You have already requested to join this group."
	/// </summary>
	public override string MessageAlreadyRequested => "Ya has solicitado unirte a este grupo.";

	/// <summary>
	/// Key: "Message.BuildGroupRolesListError"
	/// English String: "Unable to load members for selected role."
	/// </summary>
	public override string MessageBuildGroupRolesListError => "No se han podido cargar los miembros para el rol seleccionado.";

	/// <summary>
	/// Key: "Message.CannotClaimGroupWithOwner"
	/// English String: "This group already has an owner."
	/// </summary>
	public override string MessageCannotClaimGroupWithOwner => "Este grupo ya tiene dueño.";

	/// <summary>
	/// Key: "Message.ChangeOwnerEmpty"
	/// English String: "There is no owner of the group"
	/// </summary>
	public override string MessageChangeOwnerEmpty => "Este grupo no tiene propietario";

	/// <summary>
	/// Key: "Message.ClaimOwnershipError"
	/// English String: "Unable to claim ownership of group."
	/// </summary>
	public override string MessageClaimOwnershipError => "No se ha podido reclamar la propiedad del grupo.";

	/// <summary>
	/// Key: "Message.ClaimOwnershipSuccess"
	/// English String: "Successfully claimed ownership of group."
	/// </summary>
	public override string MessageClaimOwnershipSuccess => "Se ha reclamado la propiedad del grupo correctamente.";

	/// <summary>
	/// Key: "Message.DefaultError"
	/// English String: "An error occurred."
	/// </summary>
	public override string MessageDefaultError => "Se ha producido un error.";

	/// <summary>
	/// Key: "Message.DeleteWallPostError"
	/// English String: "Unable to delete wall post."
	/// </summary>
	public override string MessageDeleteWallPostError => "No se ha podido eliminar la publicación del muro.";

	/// <summary>
	/// Key: "Message.DeleteWallPostsByUserError"
	/// English String: "Unable to delete wall posts by user."
	/// </summary>
	public override string MessageDeleteWallPostsByUserError => "No se han podido eliminar del muro las publicaciones del usuario.";

	/// <summary>
	/// Key: "Message.DeleteWallPostSuccess"
	/// English String: "Successfully deleted wall post."
	/// </summary>
	public override string MessageDeleteWallPostSuccess => "Se ha eliminado la publicación del muro correctamente.";

	/// <summary>
	/// Key: "Message.DescriptionTooLong"
	/// English String: "The description is too long."
	/// </summary>
	public override string MessageDescriptionTooLong => "La descripción es demasiado larga.";

	/// <summary>
	/// Key: "Message.DuplicateName"
	/// English String: "Name is already taken. Please try another."
	/// </summary>
	public override string MessageDuplicateName => "El nombre ya está en uso. Intenta con otro.";

	/// <summary>
	/// Key: "Message.ExileUserError"
	/// English String: "Unable to exile user."
	/// </summary>
	public override string MessageExileUserError => "No se ha podido expulsar al usuario.";

	/// <summary>
	/// Key: "Message.FeatureDisabled"
	/// English String: "The feature is disabled."
	/// </summary>
	public override string MessageFeatureDisabled => "La función está desactivada.";

	/// <summary>
	/// Key: "Message.GetGroupRelationshipsError"
	/// English String: "Unable to load group affiliates."
	/// </summary>
	public override string MessageGetGroupRelationshipsError => "No se han podido cargar los afiliados del grupo.";

	/// <summary>
	/// Key: "Message.GroupClosed"
	/// English String: "You cannot join a closed group."
	/// </summary>
	public override string MessageGroupClosed => "No puedes unirte a un grupo cerrado.";

	/// <summary>
	/// Key: "Message.GroupCreationDisabled"
	/// English String: "Group creation is currently disabled."
	/// </summary>
	public override string MessageGroupCreationDisabled => "La creación de grupo está desactivada en este momento.";

	/// <summary>
	/// Key: "Message.GroupIconInvalid"
	/// English String: "Icon is missing or invalid."
	/// </summary>
	public override string MessageGroupIconInvalid => "Falta el icono o no es válido.";

	/// <summary>
	/// Key: "Message.GroupMembershipsUnavailableError"
	/// Error displayed on group details view when the system is in read-only mode for maintenance and you try to perform an action.
	/// English String: "The group membership system is temporarily unavailable. Please try again later."
	/// </summary>
	public override string MessageGroupMembershipsUnavailableError => "El sistema de suscripción de grupo no está disponible temporalmente. Inténtalo de nuevo más tarde.";

	/// <summary>
	/// Key: "Message.InsufficientFunds"
	/// English String: "Insufficient Robux funds."
	/// </summary>
	public override string MessageInsufficientFunds => "Robux insuficientes.";

	/// <summary>
	/// Key: "Message.InsufficientGroupSpace"
	/// English String: "You are already in the maximum number of groups."
	/// </summary>
	public override string MessageInsufficientGroupSpace => "Ya te has unido al número máximo de grupos.";

	/// <summary>
	/// Key: "Message.InsufficientMembership"
	/// English String: "You do not have the builders club membership necessary to join this group."
	/// </summary>
	public override string MessageInsufficientMembership => "No tienes la suscripción al Builders Club necesaria para unirte a este grupo.";

	/// <summary>
	/// Key: "Message.InsufficientPermission"
	/// English String: "Insufficient permissions to complete the request."
	/// </summary>
	public override string MessageInsufficientPermission => "Permisos suficientes para completar la solicitud.";

	/// <summary>
	/// Key: "Message.InsufficientPermissionsForRelationships"
	/// English String: "You don't have permission to manage this group's relationships."
	/// </summary>
	public override string MessageInsufficientPermissionsForRelationships => "No tienes permiso para gestionar las relaciones de este grupo.";

	/// <summary>
	/// Key: "Message.InsufficientRobux"
	/// English String: "You do not have enough Robux to create the group."
	/// </summary>
	public override string MessageInsufficientRobux => "No tienes suficientes Robux para crear el grupo.";

	/// <summary>
	/// Key: "Message.InvalidAmount"
	/// English String: "The amount is invalid."
	/// </summary>
	public override string MessageInvalidAmount => "La cantidad no es válida.";

	/// <summary>
	/// Key: "Message.InvalidGroup"
	/// English String: "Group is invalid or does not exist."
	/// </summary>
	public override string MessageInvalidGroup => "El grupo no es válido o no existe.";

	/// <summary>
	/// Key: "Message.InvalidGroupIcon"
	/// English String: "The group icon is invalid."
	/// </summary>
	public override string MessageInvalidGroupIcon => "El icono del grupo no es válido.";

	/// <summary>
	/// Key: "Message.InvalidGroupId"
	/// English String: "The group is invalid or does not exist."
	/// </summary>
	public override string MessageInvalidGroupId => "El grupo no es válido o no existe.";

	/// <summary>
	/// Key: "Message.InvalidGroupWallPostId"
	/// English String: "The group wall post id is invalid or does not exist."
	/// </summary>
	public override string MessageInvalidGroupWallPostId => "El ID de la publicación en el muro del grupo no es válido o no existe.";

	/// <summary>
	/// Key: "Message.InvalidIds"
	/// English String: "Ids could not be parsed from request."
	/// </summary>
	public override string MessageInvalidIds => "No se han podido analizar los ID de la solicitud.";

	/// <summary>
	/// Key: "Message.InvalidIdsError"
	/// English String: "Ids could not be parsed from request."
	/// </summary>
	public override string MessageInvalidIdsError => "No se han podido analizar los ID de la solicitud.";

	/// <summary>
	/// Key: "Message.InvalidMembership"
	/// English String: "User must have builders club membership."
	/// </summary>
	public override string MessageInvalidMembership => "El usuario debe tener una suscripción al Builders Club.";

	/// <summary>
	/// Key: "Message.InvalidName"
	/// English String: "The name is invalid."
	/// </summary>
	public override string MessageInvalidName => "El nombre no es válido.";

	/// <summary>
	/// Key: "Message.InvalidPaginationParameters"
	/// English String: "Invalid or missing pagination parameters."
	/// </summary>
	public override string MessageInvalidPaginationParameters => "Parámetros de paginación no válidos o faltantes.";

	/// <summary>
	/// Key: "Message.InvalidPayoutType"
	/// English String: "Invalid payout type."
	/// </summary>
	public override string MessageInvalidPayoutType => "Tipo de pago no válido.";

	/// <summary>
	/// Key: "Message.InvalidRecipient"
	/// English String: "The recipient is invalid."
	/// </summary>
	public override string MessageInvalidRecipient => "El destinatario no es válido.";

	/// <summary>
	/// Key: "Message.InvalidRelationshipType"
	/// English String: "Group relationship type is invalid."
	/// </summary>
	public override string MessageInvalidRelationshipType => "El tipo de relación del grupo no es válido.";

	/// <summary>
	/// Key: "Message.InvalidRoleSetId"
	/// English String: "The roleset is invalid or does not exist."
	/// </summary>
	public override string MessageInvalidRoleSetId => "Los roles no son válidos o no existen.";

	/// <summary>
	/// Key: "Message.InvalidUser"
	/// English String: "The user is invalid or does not exist."
	/// </summary>
	public override string MessageInvalidUser => "El usuario no es válido o no existe.";

	/// <summary>
	/// Key: "Message.InvalidWallPostContent"
	/// English String: "Your post was empty, white space, or more than 500 characters."
	/// </summary>
	public override string MessageInvalidWallPostContent => "Tu publicación está vacía, contiene solo espacios en blanco o excede los 500 caracteres.";

	/// <summary>
	/// Key: "Message.JoinGroupError"
	/// English String: "Unable to join group."
	/// </summary>
	public override string MessageJoinGroupError => "No se ha podido unir al grupo.";

	/// <summary>
	/// Key: "Message.JoinGroupPendingSuccess"
	/// English String: "Requested to join group, your request is pending."
	/// </summary>
	public override string MessageJoinGroupPendingSuccess => "La solicitud para unirse al grupo ha sido recibida y está pendiente.";

	/// <summary>
	/// Key: "Message.JoinGroupSuccess"
	/// English String: "Successfully joined the group."
	/// </summary>
	public override string MessageJoinGroupSuccess => "Te has unido al grupo.";

	/// <summary>
	/// Key: "Message.LeaveGroupError"
	/// English String: "Unable to leave group."
	/// </summary>
	public override string MessageLeaveGroupError => "No se ha podido salir del grupo.";

	/// <summary>
	/// Key: "Message.LoadGroupError"
	/// English String: "Unable to load group."
	/// </summary>
	public override string MessageLoadGroupError => "No se ha podido cargar el grupo.";

	/// <summary>
	/// Key: "Message.LoadGroupGamesError"
	/// English String: "Unable to load games."
	/// </summary>
	public override string MessageLoadGroupGamesError => "No se han podido cargar los juegos.";

	/// <summary>
	/// Key: "Message.LoadGroupListError"
	/// English String: "Unable to load group list."
	/// </summary>
	public override string MessageLoadGroupListError => "No se puede cargar la lista del grupo.";

	/// <summary>
	/// Key: "Message.LoadGroupMembershipsError"
	/// English String: "Unable to load user membership information."
	/// </summary>
	public override string MessageLoadGroupMembershipsError => "No se ha podido cargar la información de la suscripción del usuario.";

	/// <summary>
	/// Key: "Message.LoadGroupMetadataError"
	/// English String: "Unable to load group info."
	/// </summary>
	public override string MessageLoadGroupMetadataError => "No se ha podido cargar la información del grupo.";

	/// <summary>
	/// Key: "Message.LoadGroupStoreItemsError"
	/// English String: "Unable to load store items."
	/// </summary>
	public override string MessageLoadGroupStoreItemsError => "No se han podido cargar los objetos de la tienda.";

	/// <summary>
	/// Key: "Message.LoadUserGroupMembershipError"
	/// English String: "Unable to load group member information."
	/// </summary>
	public override string MessageLoadUserGroupMembershipError => "No se ha podido cargar la información del miembro del grupo.";

	/// <summary>
	/// Key: "Message.LoadWallPostsError"
	/// English String: "Unable to load wall posts."
	/// </summary>
	public override string MessageLoadWallPostsError => "No se han podido cargar las publicaciones del muro.";

	/// <summary>
	/// Key: "Message.MakePrimaryError"
	/// English String: "Unable to make primary group."
	/// </summary>
	public override string MessageMakePrimaryError => "No se ha podido crear un grupo principal.";

	/// <summary>
	/// Key: "Message.MaxGroups"
	/// English String: "User is in maximum number of groups."
	/// </summary>
	public override string MessageMaxGroups => "El usuario se ha unido al número máximo de grupos.";

	/// <summary>
	/// Key: "Message.MissingGroupIcon"
	/// English String: "The group icon is missing from the request."
	/// </summary>
	public override string MessageMissingGroupIcon => "Falta el icono del grupo en la solicitud.";

	/// <summary>
	/// Key: "Message.MissingGroupStatusContent"
	/// English String: "Missing group status content."
	/// </summary>
	public override string MessageMissingGroupStatusContent => "Falta el contenido de estado del grupo.";

	/// <summary>
	/// Key: "Message.NameInvalid"
	/// English String: "Name is missing or has invalid characters."
	/// </summary>
	public override string MessageNameInvalid => "Falta el nombre o los caracteres no son válidos.";

	/// <summary>
	/// Key: "Message.NameModerated"
	/// English String: "The name is moderated."
	/// </summary>
	public override string MessageNameModerated => "El nombre se ha moderado.";

	/// <summary>
	/// Key: "Message.NameTaken"
	/// English String: "The name has been taken."
	/// </summary>
	public override string MessageNameTaken => "El nombre ha sido tomado.";

	/// <summary>
	/// Key: "Message.NameTooLong"
	/// English String: "The name is too long."
	/// </summary>
	public override string MessageNameTooLong => "El nombre es demasiado largo.";

	/// <summary>
	/// Key: "Message.NoPrimary"
	/// English String: "The user specified does not have a primary group."
	/// </summary>
	public override string MessageNoPrimary => "El usuario especificado no tiene un grupo principal.";

	/// <summary>
	/// Key: "Message.PassCaptchaToJoin"
	/// English String: "You must pass the captcha test before joining this group."
	/// </summary>
	public override string MessagePassCaptchaToJoin => "Debes aprobar el Captcha antes de unirte a este grupo.";

	/// <summary>
	/// Key: "Message.PassCaptchaToPost"
	/// English String: "Captcha must be solved to post to the group wall."
	/// </summary>
	public override string MessagePassCaptchaToPost => "Se debe aprobar el Captcha para poder publicar en el muro del grupo.";

	/// <summary>
	/// Key: "Message.RemovePrimaryError"
	/// English String: "Unable to remove primary group."
	/// </summary>
	public override string MessageRemovePrimaryError => "No se ha podido eliminar el grupo principal.";

	/// <summary>
	/// Key: "Message.SearchTermCharactersLimit"
	/// English String: "The search term needs to be between 2 and 50 characters"
	/// </summary>
	public override string MessageSearchTermCharactersLimit => "El término de búsqueda debe tener entre 2 y 50 caracteres";

	/// <summary>
	/// Key: "Message.SearchTermEmptyError"
	/// English String: "Search term is empty"
	/// </summary>
	public override string MessageSearchTermEmptyError => "El campo de búsqueda está vacío";

	/// <summary>
	/// Key: "Message.SearchTermFilteredError"
	/// English String: "Search term was filtered"
	/// </summary>
	public override string MessageSearchTermFilteredError => "Se ha moderado el campo de búsqueda";

	/// <summary>
	/// Key: "Message.SendGroupShoutError"
	/// English String: "Unable to send group shout."
	/// </summary>
	public override string MessageSendGroupShoutError => "No se ha podido enviar un anuncio grupal.";

	/// <summary>
	/// Key: "Message.SendPostError"
	/// English String: "Unable to send post."
	/// </summary>
	public override string MessageSendPostError => "No se ha podido enviar la publicación.";

	/// <summary>
	/// Key: "Message.TooManyAttempts"
	/// English String: "Too many attempts to join the group. Please try again later."
	/// </summary>
	public override string MessageTooManyAttempts => "Demasiados intentos para unirte al grupo. Inténtalo de nuevo más tarde.";

	/// <summary>
	/// Key: "Message.TooManyAttemptsToClaimGroups"
	/// English String: "Too many attempts to claim groups. Please try again later."
	/// </summary>
	public override string MessageTooManyAttemptsToClaimGroups => "Demasiados intentos para reclamar el grupo. Inténtalo de nuevo más tarde.";

	/// <summary>
	/// Key: "Message.TooManyGroups"
	/// English String: "You have reached the group capacity. Please leave a group before creating a new one."
	/// </summary>
	public override string MessageTooManyGroups => "Has llegado a la cantidad máxima de grupos. Tienes que salir de un grupo para crear uno nuevo.";

	/// <summary>
	/// Key: "Message.TooManyIds"
	/// English String: "Too many ids in request."
	/// </summary>
	public override string MessageTooManyIds => "Demasiados ID en la solicitud.";

	/// <summary>
	/// Key: "Message.TooManyPosts"
	/// English String: "You are posting too fast, please try again in a few minutes."
	/// </summary>
	public override string MessageTooManyPosts => "Estás publicando demasiado rápido. Inténtalo de nuevo en unos minutos.";

	/// <summary>
	/// Key: "Message.TooManyRequests"
	/// English String: "Too many requests."
	/// </summary>
	public override string MessageTooManyRequests => "Demasiadas solicitudes.";

	/// <summary>
	/// Key: "Message.UnauthorizedForPostStatus"
	/// English String: "You are not authorized to set the status of this group."
	/// </summary>
	public override string MessageUnauthorizedForPostStatus => "No tienes autorización para establecer el estado de este grupo.";

	/// <summary>
	/// Key: "Message.UnauthorizedForViewGroupPayouts"
	/// English String: "You don't have permission to view this group's payouts."
	/// </summary>
	public override string MessageUnauthorizedForViewGroupPayouts => "No tienes permiso para ver los pagos de este grupo.";

	/// <summary>
	/// Key: "Message.UnauthorizedToClaimGroup"
	/// English String: "You are not authorized to claim this group."
	/// </summary>
	public override string MessageUnauthorizedToClaimGroup => "No tienes autorización para reclamar este grupo.";

	/// <summary>
	/// Key: "Message.UnauthorizedToManageMember"
	/// English String: "You do not have permission to manage this member."
	/// </summary>
	public override string MessageUnauthorizedToManageMember => "No tienes permiso para gestionar a este miembro.";

	/// <summary>
	/// Key: "Message.UnauthorizedToViewRolesetPermissions"
	/// English String: "You are not authorized to view permissions for this roleset."
	/// </summary>
	public override string MessageUnauthorizedToViewRolesetPermissions => "No tienes autorización para ver los permisos de estos roles.";

	/// <summary>
	/// Key: "Message.UnauthorizedToViewWall"
	/// English String: "You do not have permission to access this group wall."
	/// </summary>
	public override string MessageUnauthorizedToViewWall => "No tienes permiso para acceder al muro de este grupo.";

	/// <summary>
	/// Key: "Message.UnknownError"
	/// English String: "Unknown error"
	/// </summary>
	public override string MessageUnknownError => "Error desconocido";

	/// <summary>
	/// Key: "Message.UserNotInGroup"
	/// English String: "You aren't a member of the group specified."
	/// </summary>
	public override string MessageUserNotInGroup => "No eres miembro del grupo especificado.";

	public GroupsResources_es_es(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAdvertiseGroup()
	{
		return "Promocionar grupo";
	}

	protected override string _GetTemplateForActionAuditLog()
	{
		return "Registro de auditoría";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "Cancelar";
	}

	protected override string _GetTemplateForActionCancelRequest()
	{
		return "Cancelar la solicitud";
	}

	protected override string _GetTemplateForActionClaimOwnership()
	{
		return "Reclamar la propiedad";
	}

	protected override string _GetTemplateForActionClose()
	{
		return "Cerrar";
	}

	protected override string _GetTemplateForActionConfigureGroup()
	{
		return "Configurar grupo";
	}

	protected override string _GetTemplateForActionCreateGroup()
	{
		return "Crear grupo";
	}

	protected override string _GetTemplateForActionDelete()
	{
		return "Eliminar";
	}

	protected override string _GetTemplateForActionExile()
	{
		return "Expulsar";
	}

	protected override string _GetTemplateForActionExileUser()
	{
		return "Expulsar usuario";
	}

	protected override string _GetTemplateForActionGroupAdmin()
	{
		return "Administrador del grupo";
	}

	protected override string _GetTemplateForActionGroupShout()
	{
		return "Anuncio grupal";
	}

	protected override string _GetTemplateForActionJoinGroup()
	{
		return "Unirse al grupo";
	}

	protected override string _GetTemplateForActionLeaveGroup()
	{
		return "Salir del grupo";
	}

	protected override string _GetTemplateForActionMakePrimary()
	{
		return "Convertir en grupo principal";
	}

	protected override string _GetTemplateForActionMakePrimaryGroup()
	{
		return "Convertir en grupo principal";
	}

	protected override string _GetTemplateForActionPost()
	{
		return "Publicar";
	}

	protected override string _GetTemplateForActionPurchase()
	{
		return "Comprar";
	}

	protected override string _GetTemplateForActionRemovePrimary()
	{
		return "Eliminar grupo principal";
	}

	protected override string _GetTemplateForActionReport()
	{
		return "Denunciar";
	}

	protected override string _GetTemplateForActionReportAbuse()
	{
		return "Denunciar abuso";
	}

	protected override string _GetTemplateForActionUpgrade()
	{
		return "Mejorar";
	}

	protected override string _GetTemplateForActionUpgradeToJoin()
	{
		return "Mejorar suscripción para unirse";
	}

	protected override string _GetTemplateForActionYes()
	{
		return "Sí";
	}

	protected override string _GetTemplateForDescriptionClothingRevenue()
	{
		return "Los grupos pueden crear y vender camisas, pantalones y camisetas oficiales. Todos los ingresos de la venta se depositarán en los fondos del grupo.";
	}

	protected override string _GetTemplateForDescriptionDeleteAllPostsByUser()
	{
		return "Esta acción eliminará todos los mensajes publicados por este usuario.";
	}

	protected override string _GetTemplateForDescriptionExileUserWarning()
	{
		return "¿Seguro que quieres expulsar a este usuario?";
	}

	protected override string _GetTemplateForDescriptionLeaveGroupAsOwnerWarning()
	{
		return "Esta acción dejará el grupo sin dueño.";
	}

	protected override string _GetTemplateForDescriptionLeaveGroupWarning()
	{
		return "¿Seguro que quieres salir de este grupo?";
	}

	protected override string _GetTemplateForDescriptionMakePrimaryGroupWarning()
	{
		return "¿Seguro que quieres convertirlo en tu grupo principal?";
	}

	protected override string _GetTemplateForDescriptionNoneMaxGroups()
	{
		return "Mejora tu suscripción al Builders Club para unirte a más grupos.";
	}

	protected override string _GetTemplateForDescriptionNoneMaxGroupsPremium()
	{
		return "Mejora tu suscripción a Roblox Premium para unirte a más grupos.";
	}

	protected override string _GetTemplateForDescriptionnoneMaxGroupsPremiumText()
	{
		return "Mejora tu suscripción a Roblox Premium para unirte a más grupos.";
	}

	protected override string _GetTemplateForDescriptionObcMaxGroups()
	{
		return "Te has unido al número máximo de grupos.";
	}

	protected override string _GetTemplateForDescriptionOtherBcMaxGroups()
	{
		return "Mejora tu suscripción de Builders Club para unirte a más grupos.";
	}

	protected override string _GetTemplateForDescriptionotherPremiumMaxGroupsText()
	{
		return "Mejora tu suscripción de Roblox Premium para unirte a más grupos.";
	}

	protected override string _GetTemplateForDescriptionPremiumMaxGroups()
	{
		return "Te has unido al número máximo de grupos.";
	}

	protected override string _GetTemplateForDescriptionPurchaseBody()
	{
		return "¿Quieres crear este grupo por";
	}

	protected override string _GetTemplateForDescriptionRemovePrimaryGroupWarning()
	{
		return "¿Seguro que quieres eliminar tu grupo principal?";
	}

	protected override string _GetTemplateForDescriptionReportAbuseDescription()
	{
		return "¿Qué quieres denunciar?";
	}

	protected override string _GetTemplateForDescriptionWallPrivacySettings()
	{
		return "Tu configuración de privacidad no te permite publicar en el muro del grupo. Haz clic aquí para modificar los parámetros.";
	}

	protected override string _GetTemplateForHeadingAbout()
	{
		return "Sobre el grupo";
	}

	protected override string _GetTemplateForHeadingAffiliates()
	{
		return "Afiliados";
	}

	protected override string _GetTemplateForHeadingAllies()
	{
		return "Aliados";
	}

	/// <summary>
	/// Key: "Heading.ConfigureGroup"
	/// English String: "Configure {groupName}"
	/// </summary>
	public override string HeadingConfigureGroup(string groupName)
	{
		return $"Configurar {groupName}";
	}

	protected override string _GetTemplateForHeadingConfigureGroup()
	{
		return "Configurar {groupName}";
	}

	protected override string _GetTemplateForHeadingDate()
	{
		return "Fecha";
	}

	protected override string _GetTemplateForHeadingDescription()
	{
		return "Descripción";
	}

	protected override string _GetTemplateForHeadingEnemies()
	{
		return "Enemigos";
	}

	protected override string _GetTemplateForHeadingExileUserWarning()
	{
		return "Advertencia";
	}

	protected override string _GetTemplateForHeadingFunds()
	{
		return "Fondos";
	}

	protected override string _GetTemplateForHeadingGames()
	{
		return "Juegos";
	}

	protected override string _GetTemplateForHeadingGroupPurchase()
	{
		return "Confirmación de compra de grupo";
	}

	protected override string _GetTemplateForHeadingGroupShout()
	{
		return "Anuncio grupal";
	}

	protected override string _GetTemplateForHeadingLeaveGroup()
	{
		return "Salir del grupo";
	}

	protected override string _GetTemplateForHeadingMakePrimaryGroup()
	{
		return "Convertir en grupo principal";
	}

	protected override string _GetTemplateForHeadingMembers()
	{
		return "Miembros";
	}

	protected override string _GetTemplateForHeadingNameOrDescription()
	{
		return "Nombre o descripción";
	}

	protected override string _GetTemplateForHeadingPayouts()
	{
		return "Pagos";
	}

	protected override string _GetTemplateForHeadingPrimary()
	{
		return "Principal";
	}

	protected override string _GetTemplateForHeadingRank()
	{
		return "Rango";
	}

	protected override string _GetTemplateForHeadingRemovePrimaryGroup()
	{
		return "Eliminar grupo principal";
	}

	protected override string _GetTemplateForHeadingRole()
	{
		return "Rol";
	}

	protected override string _GetTemplateForHeadingSettings()
	{
		return "Configuración";
	}

	protected override string _GetTemplateForHeadingShout()
	{
		return "Anuncio";
	}

	protected override string _GetTemplateForHeadingStore()
	{
		return "Tienda";
	}

	protected override string _GetTemplateForHeadingUser()
	{
		return "Usuario";
	}

	protected override string _GetTemplateForHeadingWall()
	{
		return "Muro";
	}

	protected override string _GetTemplateForLabelAbandon()
	{
		return "Abandonar";
	}

	protected override string _GetTemplateForLabelAcceptAllyRequest()
	{
		return "Aceptar solicitud de aliado";
	}

	protected override string _GetTemplateForLabelAcceptJoinRequest()
	{
		return "Aceptar solicitud a unirse";
	}

	protected override string _GetTemplateForLabelAddGroupPlace()
	{
		return "Añadir un lugar de grupo";
	}

	protected override string _GetTemplateForLabelAdjustCurrencyAmounts()
	{
		return "Ajustar monto";
	}

	protected override string _GetTemplateForLabelAll()
	{
		return "Todos";
	}

	protected override string _GetTemplateForLabelAnyoneCanJoin()
	{
		return "Todos pueden unirse";
	}

	protected override string _GetTemplateForLabelBuyAd()
	{
		return "Comprar anuncio";
	}

	protected override string _GetTemplateForLabelBuyClan()
	{
		return "Comprar clan";
	}

	protected override string _GetTemplateForLabelByOwner()
	{
		return "De";
	}

	protected override string _GetTemplateForLabelCancelClanInvite()
	{
		return "Cancelar invitación del clan";
	}

	protected override string _GetTemplateForLabelChangeDescription()
	{
		return "Cambiar descripción";
	}

	protected override string _GetTemplateForLabelChangeOwner()
	{
		return "Cambiar propietario";
	}

	protected override string _GetTemplateForLabelChangeRank()
	{
		return "Cambiar rango";
	}

	protected override string _GetTemplateForLabelClaim()
	{
		return "Reclamar";
	}

	protected override string _GetTemplateForLabelConfigureBadge()
	{
		return "Configurar emblema";
	}

	protected override string _GetTemplateForLabelConfigureGroupAsset()
	{
		return "Configurar recurso de grupo";
	}

	protected override string _GetTemplateForLabelConfigureGroupDevelopmentItem()
	{
		return "Configurar objeto de desarrollo del grupo";
	}

	protected override string _GetTemplateForLabelConfigureGroupGame()
	{
		return "Configurar juego del grupo";
	}

	protected override string _GetTemplateForLabelConfigureItems()
	{
		return "Configurar objetos";
	}

	protected override string _GetTemplateForLabelCreateBadge()
	{
		return "Crear emblema";
	}

	protected override string _GetTemplateForLabelCreateEnemy()
	{
		return "Crear enemigo";
	}

	protected override string _GetTemplateForLabelCreateGamePass()
	{
		return "Crear pase del juego";
	}

	protected override string _GetTemplateForLabelCreateGroup()
	{
		return "Crear grupo";
	}

	protected override string _GetTemplateForLabelCreateGroupAsset()
	{
		return "Crear recurso de grupo";
	}

	protected override string _GetTemplateForLabelCreateGroupBuildersClubTooltip()
	{
		return "Para crear un nuevo grupo se requiere la suscripción al Builders Club.";
	}

	protected override string _GetTemplateForLabelCreateGroupDescription()
	{
		return "Descripción (opcional)";
	}

	protected override string _GetTemplateForLabelCreateGroupDeveloperProduct()
	{
		return "Crear producto de grupo de desarrolladores";
	}

	protected override string _GetTemplateForLabelCreateGroupEmblem()
	{
		return "Emblema";
	}

	protected override string _GetTemplateForLabelCreateGroupFee()
	{
		return "Cuota de creación de grupo";
	}

	protected override string _GetTemplateForLabelCreateGroupName()
	{
		return "Ponle nombre a tu grupo";
	}

	protected override string _GetTemplateForLabelCreateGroupPremiumTooltip()
	{
		return "Para crear un grupo se requiere la suscripción a Roblox Premium.";
	}

	protected override string _GetTemplateForLabelCreateGroupTooltip()
	{
		return "Crear un nuevo grupo";
	}

	protected override string _GetTemplateForLabelCreateItems()
	{
		return "Crear objetos";
	}

	protected override string _GetTemplateForLabelDeclineAllyRequest()
	{
		return "Rechazar solicitud de aliado";
	}

	protected override string _GetTemplateForLabelDeclineJoinRequest()
	{
		return "Rechazar solicitud a unirse";
	}

	protected override string _GetTemplateForLabelDelete()
	{
		return "Eliminar";
	}

	protected override string _GetTemplateForLabelDeleteAllPostsByUser()
	{
		return "Eliminar todas sus publicaciones.";
	}

	protected override string _GetTemplateForLabelDeleteAlly()
	{
		return "Eliminar aliado";
	}

	protected override string _GetTemplateForLabelDeleteEnemy()
	{
		return "Eliminar enemigo";
	}

	protected override string _GetTemplateForLabelDeleteGroupPlace()
	{
		return "Eliminar lugar de grupo";
	}

	protected override string _GetTemplateForLabelDeletePost()
	{
		return "Eliminar publicación";
	}

	protected override string _GetTemplateForLabelFunds()
	{
		return "Fondos";
	}

	protected override string _GetTemplateForLabelGroupClosed()
	{
		return "Grupo cerrado";
	}

	protected override string _GetTemplateForLabelGroupLocked()
	{
		return "Este grupo ha sido bloqueado";
	}

	/// <summary>
	/// Key: "Label.GroupSearchResults"
	/// English String: "Group Results For {searchTerm}"
	/// </summary>
	public override string LabelGroupSearchResults(string searchTerm)
	{
		return $"Resultados de grupo para {searchTerm}";
	}

	protected override string _GetTemplateForLabelGroupSearchResults()
	{
		return "Resultados de grupo para {searchTerm}";
	}

	protected override string _GetTemplateForLabelInviteToClan()
	{
		return "Invitar al clan";
	}

	protected override string _GetTemplateForLabelKickFromClan()
	{
		return "Expulsar del clan";
	}

	protected override string _GetTemplateForLabelLoading()
	{
		return "Cargando...";
	}

	protected override string _GetTemplateForLabelLock()
	{
		return "Bloquear";
	}

	protected override string _GetTemplateForLabelManageGroupCreations()
	{
		return "Crear o administrar objetos del grupo";
	}

	protected override string _GetTemplateForLabelManualApproval()
	{
		return "Aprobación manual";
	}

	/// <summary>
	/// Key: "Label.MaxGroupsTooltip"
	/// English String: "You may only be in a maximum of {maxGroups} groups at one time"
	/// </summary>
	public override string LabelMaxGroupsTooltip(string maxGroups)
	{
		return $"Puedes unirte a un máximo de {maxGroups} grupos a la vez.";
	}

	protected override string _GetTemplateForLabelMaxGroupsTooltip()
	{
		return "Puedes unirte a un máximo de {maxGroups} grupos a la vez.";
	}

	protected override string _GetTemplateForLabelMembers()
	{
		return "{memberCount, plural, =0 {# miembros} =1 {# miembro} other {# miembros}}";
	}

	protected override string _GetTemplateForLabelModerateDiscussion()
	{
		return "Moderar discusión";
	}

	protected override string _GetTemplateForLabelNoAllies()
	{
		return "Este grupo no tiene aliados.";
	}

	protected override string _GetTemplateForLabelNoEnemies()
	{
		return "Este grupo no tiene enemigos.";
	}

	protected override string _GetTemplateForLabelNoGames()
	{
		return "No hay juegos asociados con este grupo.";
	}

	protected override string _GetTemplateForLabelNoMembersInRole()
	{
		return "No hay miembros del grupo que desempeñan esta función.";
	}

	protected override string _GetTemplateForLabelNoOne()
	{
		return "¡Nadie!";
	}

	/// <summary>
	/// Key: "Label.NoResults"
	/// English String: "No results for \"{searchTerm}\""
	/// </summary>
	public override string LabelNoResults(string searchTerm)
	{
		return $"Ningún resultado para \"{searchTerm}\"";
	}

	protected override string _GetTemplateForLabelNoResults()
	{
		return "Ningún resultado para \"{searchTerm}\"";
	}

	protected override string _GetTemplateForLabelNoStoreItems()
	{
		return "No hay objetos a la venta en este grupo.";
	}

	protected override string _GetTemplateForLabelNoWallPosts()
	{
		return "Nadie ha dicho nada todavía...";
	}

	protected override string _GetTemplateForLabelOnlyBcCanJoin()
	{
		return "Solo los miembros del Builders Club pueden unirse";
	}

	protected override string _GetTemplateForLabelOnlyPremiumCanJoin()
	{
		return "Solo los usuarios con una suscripción pueden unirse";
	}

	protected override string _GetTemplateForLabelPrivateGroup()
	{
		return "Privado";
	}

	protected override string _GetTemplateForLabelPublicGroup()
	{
		return "Público";
	}

	protected override string _GetTemplateForLabelPublishPlace()
	{
		return "Publicar lugar";
	}

	protected override string _GetTemplateForLabelRemoveGroupPlace()
	{
		return "Eliminar un lugar de grupo";
	}

	protected override string _GetTemplateForLabelRemoveMember()
	{
		return "Eliminar miembro";
	}

	protected override string _GetTemplateForLabelRename()
	{
		return "Renombrar";
	}

	protected override string _GetTemplateForLabelRevertGroupAsset()
	{
		return "Revertir recurso de grupo";
	}

	protected override string _GetTemplateForLabelSavePlace()
	{
		return "Guardar lugar";
	}

	protected override string _GetTemplateForLabelSearchGroups()
	{
		return "Buscar todos los grupos";
	}

	protected override string _GetTemplateForLabelSearchUsers()
	{
		return "Buscar usuarios";
	}

	protected override string _GetTemplateForLabelSendAllyRequest()
	{
		return "Enviar una solicitud de aliado";
	}

	protected override string _GetTemplateForLabelShoutPlaceholder()
	{
		return "Introduce tu anuncio";
	}

	protected override string _GetTemplateForLabelSpendGroupFunds()
	{
		return "Gastar fondos del grupo";
	}

	protected override string _GetTemplateForLabelSuccess()
	{
		return "Hecho";
	}

	protected override string _GetTemplateForLabelUnlock()
	{
		return "Desbloquear";
	}

	protected override string _GetTemplateForLabelUpdateGroupAsset()
	{
		return "Actualizar recurso de grupo";
	}

	protected override string _GetTemplateForLabelWallPostPlaceholder()
	{
		return "Di algo...";
	}

	protected override string _GetTemplateForLabelWallPostsUnavailable()
	{
		return "La publicaciones del muro no están disponibles temporalmente. Inténtalo más tarde.";
	}

	protected override string _GetTemplateForLabelWarning()
	{
		return "Advertencia";
	}

	/// <summary>
	/// Key: "Message.Abandon"
	/// English String: "{actor} (group owner) abandoned the group"
	/// </summary>
	public override string MessageAbandon(string actor)
	{
		return $"{actor} (el propietario del grupo) ha salido del grupo";
	}

	protected override string _GetTemplateForMessageAbandon()
	{
		return "{actor} (el propietario del grupo) ha salido del grupo";
	}

	/// <summary>
	/// Key: "Message.AcceptAllyRequest"
	/// English String: "{actor} accepted group {group}'s ally request"
	/// </summary>
	public override string MessageAcceptAllyRequest(string actor, string group)
	{
		return $"{actor} ha aceptado la solicitud de aliado del grupo {group}";
	}

	protected override string _GetTemplateForMessageAcceptAllyRequest()
	{
		return "{actor} ha aceptado la solicitud de aliado del grupo {group}";
	}

	/// <summary>
	/// Key: "Message.AcceptJoinRequest"
	/// English String: "{actor} accepted user {user}'s join request"
	/// </summary>
	public override string MessageAcceptJoinRequest(string actor, string user)
	{
		return $"{actor} ha aceptado la solicitud a unirse de {user}";
	}

	protected override string _GetTemplateForMessageAcceptJoinRequest()
	{
		return "{actor} ha aceptado la solicitud a unirse de {user}";
	}

	/// <summary>
	/// Key: "Message.AddGroupPlace"
	/// English String: "{actor} added game {game} as a group game"
	/// </summary>
	public override string MessageAddGroupPlace(string actor, string game)
	{
		return $"{actor} ha añadido el juego {game} como juego del grupo";
	}

	protected override string _GetTemplateForMessageAddGroupPlace()
	{
		return "{actor} ha añadido el juego {game} como juego del grupo";
	}

	/// <summary>
	/// Key: "Message.AdjustCurrencyAmountsDecreased"
	/// English String: "{actor} decreased group funds by {amount}"
	/// </summary>
	public override string MessageAdjustCurrencyAmountsDecreased(string actor, string amount)
	{
		return $"{actor} ha reducido los fondos de grupo de {amount}";
	}

	protected override string _GetTemplateForMessageAdjustCurrencyAmountsDecreased()
	{
		return "{actor} ha reducido los fondos de grupo de {amount}";
	}

	/// <summary>
	/// Key: "Message.AdjustCurrencyAmountsIncreased"
	/// English String: "{actor} increased group funds by {amount}"
	/// </summary>
	public override string MessageAdjustCurrencyAmountsIncreased(string actor, string amount)
	{
		return $"{actor} ha aumentado los fondos del grupo de {amount}";
	}

	protected override string _GetTemplateForMessageAdjustCurrencyAmountsIncreased()
	{
		return "{actor} ha aumentado los fondos del grupo de {amount}";
	}

	protected override string _GetTemplateForMessageAlreadyMember()
	{
		return "Ya eres miembro de este grupo.";
	}

	protected override string _GetTemplateForMessageAlreadyRequested()
	{
		return "Ya has solicitado unirte a este grupo.";
	}

	protected override string _GetTemplateForMessageBuildGroupRolesListError()
	{
		return "No se han podido cargar los miembros para el rol seleccionado.";
	}

	/// <summary>
	/// Key: "Message.BuyAd"
	/// English String: "{actor} bid {bid} on group ad {adName}"
	/// </summary>
	public override string MessageBuyAd(string actor, string bid, string adName)
	{
		return $"{actor} ha hecho una oferta de {bid} en el anuncio publicitario {adName}";
	}

	protected override string _GetTemplateForMessageBuyAd()
	{
		return "{actor} ha hecho una oferta de {bid} en el anuncio publicitario {adName}";
	}

	/// <summary>
	/// Key: "Message.BuyClan"
	/// English String: "{actor} bought a group clan"
	/// </summary>
	public override string MessageBuyClan(string actor)
	{
		return $"{actor} ha comprado un grupo clan";
	}

	protected override string _GetTemplateForMessageBuyClan()
	{
		return "{actor} ha comprado un grupo clan";
	}

	/// <summary>
	/// Key: "Message.CancelClanInvite"
	/// English String: "{actor} cancelled {user}'s clan invite"
	/// </summary>
	public override string MessageCancelClanInvite(string actor, string user)
	{
		return $"{actor} ha cancelado la invitación de {user} al clan";
	}

	protected override string _GetTemplateForMessageCancelClanInvite()
	{
		return "{actor} ha cancelado la invitación de {user} al clan";
	}

	protected override string _GetTemplateForMessageCannotClaimGroupWithOwner()
	{
		return "Este grupo ya tiene dueño.";
	}

	/// <summary>
	/// Key: "Message.ChangeDescription"
	/// English String: "{actor} changed the description to \"{newDescription}\""
	/// </summary>
	public override string MessageChangeDescription(string actor, string newDescription)
	{
		return $"{actor} ha cambiado la descripción a \"{newDescription}\"";
	}

	protected override string _GetTemplateForMessageChangeDescription()
	{
		return "{actor} ha cambiado la descripción a \"{newDescription}\"";
	}

	/// <summary>
	/// Key: "Message.ChangeOwner"
	/// English String: "{actor} changed the group owner. {user} is the new group owner"
	/// </summary>
	public override string MessageChangeOwner(string actor, string user)
	{
		return $"{actor} ha cambiado el propietario del grupo. {user} es el nuevo propietario";
	}

	protected override string _GetTemplateForMessageChangeOwner()
	{
		return "{actor} ha cambiado el propietario del grupo. {user} es el nuevo propietario";
	}

	protected override string _GetTemplateForMessageChangeOwnerEmpty()
	{
		return "Este grupo no tiene propietario";
	}

	/// <summary>
	/// Key: "Message.ChangeRank"
	/// English String: "{actor} changed user {user}'s rank from {oldRoleSet} to {newRoleSet}"
	/// </summary>
	public override string MessageChangeRank(string actor, string user, string oldRoleSet, string newRoleSet)
	{
		return $"{actor} ha cambiado el rango de {user} de {oldRoleSet} a {newRoleSet}";
	}

	protected override string _GetTemplateForMessageChangeRank()
	{
		return "{actor} ha cambiado el rango de {user} de {oldRoleSet} a {newRoleSet}";
	}

	/// <summary>
	/// Key: "Message.Claim"
	/// English String: "{actor} claimed ownership of the group"
	/// </summary>
	public override string MessageClaim(string actor)
	{
		return $"{actor} ha reclamado la propiedad del grupo";
	}

	protected override string _GetTemplateForMessageClaim()
	{
		return "{actor} ha reclamado la propiedad del grupo";
	}

	protected override string _GetTemplateForMessageClaimOwnershipError()
	{
		return "No se ha podido reclamar la propiedad del grupo.";
	}

	protected override string _GetTemplateForMessageClaimOwnershipSuccess()
	{
		return "Se ha reclamado la propiedad del grupo correctamente.";
	}

	/// <summary>
	/// Key: "Message.ConfigureAsset"
	/// English String: "{actor} updated asset {item}: {actions}"
	/// </summary>
	public override string MessageConfigureAsset(string actor, string item, string actions)
	{
		return $"{actor} ha actualizado el recurso {item}: {actions}";
	}

	protected override string _GetTemplateForMessageConfigureAsset()
	{
		return "{actor} ha actualizado el recurso {item}: {actions}";
	}

	/// <summary>
	/// Key: "Message.ConfigureBadgeDisabled"
	/// English String: "{actor} disabled the badge {badge}"
	/// </summary>
	public override string MessageConfigureBadgeDisabled(string actor, string badge)
	{
		return $"{actor} ha desactivado el emblema {badge}";
	}

	protected override string _GetTemplateForMessageConfigureBadgeDisabled()
	{
		return "{actor} ha desactivado el emblema {badge}";
	}

	/// <summary>
	/// Key: "Message.ConfigureBadgeEnabled"
	/// English String: "{actor} enabled the badge {badge}"
	/// </summary>
	public override string MessageConfigureBadgeEnabled(string actor, string badge)
	{
		return $"{actor} ha activado el emblema {badge}";
	}

	protected override string _GetTemplateForMessageConfigureBadgeEnabled()
	{
		return "{actor} ha activado el emblema {badge}";
	}

	/// <summary>
	/// Key: "Message.ConfigureBadgeUpdate"
	/// English String: "{actor} configured the badge {badge}"
	/// </summary>
	public override string MessageConfigureBadgeUpdate(string actor, string badge)
	{
		return $"{actor} ha configurado el emblema {badge}";
	}

	protected override string _GetTemplateForMessageConfigureBadgeUpdate()
	{
		return "{actor} ha configurado el emblema {badge}";
	}

	/// <summary>
	/// Key: "Message.ConfigureGame"
	/// English String: "{actor} updated {game}: {actions}"
	/// </summary>
	public override string MessageConfigureGame(string actor, string game, string actions)
	{
		return $"{actor} ha actualizado {game}: {actions}";
	}

	protected override string _GetTemplateForMessageConfigureGame()
	{
		return "{actor} ha actualizado {game}: {actions}";
	}

	/// <summary>
	/// Key: "Message.ConfigureGameDeveloperProduct"
	/// English String: "{actor} updated developer product {id}: {actions}"
	/// </summary>
	public override string MessageConfigureGameDeveloperProduct(string actor, string id, string actions)
	{
		return $"{actor} ha actualizado un producto de desarrollador {id}: {actions}";
	}

	protected override string _GetTemplateForMessageConfigureGameDeveloperProduct()
	{
		return "{actor} ha actualizado un producto de desarrollador {id}: {actions}";
	}

	/// <summary>
	/// Key: "Message.ConfigureItems"
	/// English String: "{actor} configured the group item {item}"
	/// </summary>
	public override string MessageConfigureItems(string actor, string item)
	{
		return $"{actor} ha configurado el objeto del grupo {item}";
	}

	protected override string _GetTemplateForMessageConfigureItems()
	{
		return "{actor} ha configurado el objeto del grupo {item}";
	}

	/// <summary>
	/// Key: "Message.CreateAsset"
	/// English String: "{actor} created asset {item}"
	/// </summary>
	public override string MessageCreateAsset(string actor, string item)
	{
		return $"{actor} ha creado el recurso {item}";
	}

	protected override string _GetTemplateForMessageCreateAsset()
	{
		return "{actor} ha creado el recurso {item}";
	}

	/// <summary>
	/// Key: "Message.CreateBadge"
	/// English String: "{actor} created the badge {badge}"
	/// </summary>
	public override string MessageCreateBadge(string actor, string badge)
	{
		return $"{actor} ha creado el emblema {badge}";
	}

	protected override string _GetTemplateForMessageCreateBadge()
	{
		return "{actor} ha creado el emblema {badge}";
	}

	/// <summary>
	/// Key: "Message.CreateDeveloperProduct"
	/// English String: "{actor} created developer product with id {id}"
	/// </summary>
	public override string MessageCreateDeveloperProduct(string actor, string id)
	{
		return $"{actor} ha creado un producto de desarrollador con el ID {id}";
	}

	protected override string _GetTemplateForMessageCreateDeveloperProduct()
	{
		return "{actor} ha creado un producto de desarrollador con el ID {id}";
	}

	/// <summary>
	/// Key: "Message.CreateEnemy"
	/// English String: "{actor} declared group {group} as an enemy"
	/// </summary>
	public override string MessageCreateEnemy(string actor, string group)
	{
		return $"{actor} ha declarado como enemigo al grupo {group}";
	}

	protected override string _GetTemplateForMessageCreateEnemy()
	{
		return "{actor} ha declarado como enemigo al grupo {group}";
	}

	/// <summary>
	/// Key: "Message.CreateGamePass"
	/// English String: "{actor} created a Game Pass for {game}: {gamePass}"
	/// </summary>
	public override string MessageCreateGamePass(string actor, string game, string gamePass)
	{
		return $"{actor} ha creado un pase del juego para {game}: {gamePass}";
	}

	protected override string _GetTemplateForMessageCreateGamePass()
	{
		return "{actor} ha creado un pase del juego para {game}: {gamePass}";
	}

	/// <summary>
	/// Key: "Message.CreateItems"
	/// English String: "{actor} created the group item {item}"
	/// </summary>
	public override string MessageCreateItems(string actor, string item)
	{
		return $"{actor} ha creado el objeto del grupo {item}";
	}

	protected override string _GetTemplateForMessageCreateItems()
	{
		return "{actor} ha creado el objeto del grupo {item}";
	}

	/// <summary>
	/// Key: "Message.DeclineAllyRequest"
	/// English String: "{actor} declined group {group}'s ally request"
	/// </summary>
	public override string MessageDeclineAllyRequest(string actor, string group)
	{
		return $"{actor} ha rechazado la solicitud de aliado del grupo {group}";
	}

	protected override string _GetTemplateForMessageDeclineAllyRequest()
	{
		return "{actor} ha rechazado la solicitud de aliado del grupo {group}";
	}

	/// <summary>
	/// Key: "Message.DeclineJoinRequest"
	/// English String: "{actor} declined user {user}'s join request"
	/// </summary>
	public override string MessageDeclineJoinRequest(string actor, string user)
	{
		return $"{actor} ha rechazado de solicitud a unirse de {user}";
	}

	protected override string _GetTemplateForMessageDeclineJoinRequest()
	{
		return "{actor} ha rechazado de solicitud a unirse de {user}";
	}

	protected override string _GetTemplateForMessageDefaultError()
	{
		return "Se ha producido un error.";
	}

	/// <summary>
	/// Key: "Message.Delete"
	/// English String: "{actor} deleted current group"
	/// </summary>
	public override string MessageDelete(string actor)
	{
		return $"{actor} ha eliminado el grupo actual";
	}

	protected override string _GetTemplateForMessageDelete()
	{
		return "{actor} ha eliminado el grupo actual";
	}

	/// <summary>
	/// Key: "Message.DeleteAlly"
	/// English String: "{actor} removed group {group} as an ally"
	/// </summary>
	public override string MessageDeleteAlly(string actor, string group)
	{
		return $"{actor} ha eliminado al grupo aliado {group}";
	}

	protected override string _GetTemplateForMessageDeleteAlly()
	{
		return "{actor} ha eliminado al grupo aliado {group}";
	}

	/// <summary>
	/// Key: "Message.DeleteEnemy"
	/// English String: "{actor} removed group {group} as an enemy"
	/// </summary>
	public override string MessageDeleteEnemy(string actor, string group)
	{
		return $"{actor} ha eliminado al grupo enemigo {group}";
	}

	protected override string _GetTemplateForMessageDeleteEnemy()
	{
		return "{actor} ha eliminado al grupo enemigo {group}";
	}

	/// <summary>
	/// Key: "Message.DeleteGroupPlace"
	/// English String: "{actor} removed game {game} as a group game"
	/// </summary>
	public override string MessageDeleteGroupPlace(string actor, string game)
	{
		return $"{actor} ha eliminado el juego {game} como juego del grupo";
	}

	protected override string _GetTemplateForMessageDeleteGroupPlace()
	{
		return "{actor} ha eliminado el juego {game} como juego del grupo";
	}

	/// <summary>
	/// Key: "Message.DeletePost"
	/// English String: "{actor} deleted post \"{postDesc}\" by user {user}"
	/// </summary>
	public override string MessageDeletePost(string actor, string postDesc, string user)
	{
		return $"{actor} ha eliminado la publicación \"{postDesc}\" de {user}";
	}

	protected override string _GetTemplateForMessageDeletePost()
	{
		return "{actor} ha eliminado la publicación \"{postDesc}\" de {user}";
	}

	protected override string _GetTemplateForMessageDeleteWallPostError()
	{
		return "No se ha podido eliminar la publicación del muro.";
	}

	protected override string _GetTemplateForMessageDeleteWallPostsByUserError()
	{
		return "No se han podido eliminar del muro las publicaciones del usuario.";
	}

	protected override string _GetTemplateForMessageDeleteWallPostSuccess()
	{
		return "Se ha eliminado la publicación del muro correctamente.";
	}

	protected override string _GetTemplateForMessageDescriptionTooLong()
	{
		return "La descripción es demasiado larga.";
	}

	protected override string _GetTemplateForMessageDuplicateName()
	{
		return "El nombre ya está en uso. Intenta con otro.";
	}

	protected override string _GetTemplateForMessageExileUserError()
	{
		return "No se ha podido expulsar al usuario.";
	}

	protected override string _GetTemplateForMessageFeatureDisabled()
	{
		return "La función está desactivada.";
	}

	protected override string _GetTemplateForMessageGetGroupRelationshipsError()
	{
		return "No se han podido cargar los afiliados del grupo.";
	}

	protected override string _GetTemplateForMessageGroupClosed()
	{
		return "No puedes unirte a un grupo cerrado.";
	}

	protected override string _GetTemplateForMessageGroupCreationDisabled()
	{
		return "La creación de grupo está desactivada en este momento.";
	}

	protected override string _GetTemplateForMessageGroupIconInvalid()
	{
		return "Falta el icono o no es válido.";
	}

	/// <summary>
	/// Key: "Message.GroupIconTooLarge"
	/// English String: "Icon cannot be larger than {maxSize} mb."
	/// </summary>
	public override string MessageGroupIconTooLarge(string maxSize)
	{
		return $"El icono no puede ser mayor de {maxSize} MB.";
	}

	protected override string _GetTemplateForMessageGroupIconTooLarge()
	{
		return "El icono no puede ser mayor de {maxSize} MB.";
	}

	protected override string _GetTemplateForMessageGroupMembershipsUnavailableError()
	{
		return "El sistema de suscripción de grupo no está disponible temporalmente. Inténtalo de nuevo más tarde.";
	}

	protected override string _GetTemplateForMessageInsufficientFunds()
	{
		return "Robux insuficientes.";
	}

	protected override string _GetTemplateForMessageInsufficientGroupSpace()
	{
		return "Ya te has unido al número máximo de grupos.";
	}

	protected override string _GetTemplateForMessageInsufficientMembership()
	{
		return "No tienes la suscripción al Builders Club necesaria para unirte a este grupo.";
	}

	protected override string _GetTemplateForMessageInsufficientPermission()
	{
		return "Permisos suficientes para completar la solicitud.";
	}

	protected override string _GetTemplateForMessageInsufficientPermissionsForRelationships()
	{
		return "No tienes permiso para gestionar las relaciones de este grupo.";
	}

	protected override string _GetTemplateForMessageInsufficientRobux()
	{
		return "No tienes suficientes Robux para crear el grupo.";
	}

	protected override string _GetTemplateForMessageInvalidAmount()
	{
		return "La cantidad no es válida.";
	}

	protected override string _GetTemplateForMessageInvalidGroup()
	{
		return "El grupo no es válido o no existe.";
	}

	protected override string _GetTemplateForMessageInvalidGroupIcon()
	{
		return "El icono del grupo no es válido.";
	}

	protected override string _GetTemplateForMessageInvalidGroupId()
	{
		return "El grupo no es válido o no existe.";
	}

	protected override string _GetTemplateForMessageInvalidGroupWallPostId()
	{
		return "El ID de la publicación en el muro del grupo no es válido o no existe.";
	}

	protected override string _GetTemplateForMessageInvalidIds()
	{
		return "No se han podido analizar los ID de la solicitud.";
	}

	protected override string _GetTemplateForMessageInvalidIdsError()
	{
		return "No se han podido analizar los ID de la solicitud.";
	}

	protected override string _GetTemplateForMessageInvalidMembership()
	{
		return "El usuario debe tener una suscripción al Builders Club.";
	}

	protected override string _GetTemplateForMessageInvalidName()
	{
		return "El nombre no es válido.";
	}

	protected override string _GetTemplateForMessageInvalidPaginationParameters()
	{
		return "Parámetros de paginación no válidos o faltantes.";
	}

	protected override string _GetTemplateForMessageInvalidPayoutType()
	{
		return "Tipo de pago no válido.";
	}

	protected override string _GetTemplateForMessageInvalidRecipient()
	{
		return "El destinatario no es válido.";
	}

	protected override string _GetTemplateForMessageInvalidRelationshipType()
	{
		return "El tipo de relación del grupo no es válido.";
	}

	protected override string _GetTemplateForMessageInvalidRoleSetId()
	{
		return "Los roles no son válidos o no existen.";
	}

	protected override string _GetTemplateForMessageInvalidUser()
	{
		return "El usuario no es válido o no existe.";
	}

	protected override string _GetTemplateForMessageInvalidWallPostContent()
	{
		return "Tu publicación está vacía, contiene solo espacios en blanco o excede los 500 caracteres.";
	}

	/// <summary>
	/// Key: "Message.InviteToClan"
	/// English String: "{actor} invited user {user} to the clan"
	/// </summary>
	public override string MessageInviteToClan(string actor, string user)
	{
		return $"{actor} ha invitado a {user} al clan";
	}

	protected override string _GetTemplateForMessageInviteToClan()
	{
		return "{actor} ha invitado a {user} al clan";
	}

	protected override string _GetTemplateForMessageJoinGroupError()
	{
		return "No se ha podido unir al grupo.";
	}

	protected override string _GetTemplateForMessageJoinGroupPendingSuccess()
	{
		return "La solicitud para unirse al grupo ha sido recibida y está pendiente.";
	}

	protected override string _GetTemplateForMessageJoinGroupSuccess()
	{
		return "Te has unido al grupo.";
	}

	/// <summary>
	/// Key: "Message.KickFromClan"
	/// English String: "{actor} kicked user {user} out of the clan"
	/// </summary>
	public override string MessageKickFromClan(string actor, string user)
	{
		return $"{actor} ha expulsado a {user} del clan";
	}

	protected override string _GetTemplateForMessageKickFromClan()
	{
		return "{actor} ha expulsado a {user} del clan";
	}

	protected override string _GetTemplateForMessageLeaveGroupError()
	{
		return "No se ha podido salir del grupo.";
	}

	protected override string _GetTemplateForMessageLoadGroupError()
	{
		return "No se ha podido cargar el grupo.";
	}

	protected override string _GetTemplateForMessageLoadGroupGamesError()
	{
		return "No se han podido cargar los juegos.";
	}

	protected override string _GetTemplateForMessageLoadGroupListError()
	{
		return "No se puede cargar la lista del grupo.";
	}

	protected override string _GetTemplateForMessageLoadGroupMembershipsError()
	{
		return "No se ha podido cargar la información de la suscripción del usuario.";
	}

	protected override string _GetTemplateForMessageLoadGroupMetadataError()
	{
		return "No se ha podido cargar la información del grupo.";
	}

	protected override string _GetTemplateForMessageLoadGroupStoreItemsError()
	{
		return "No se han podido cargar los objetos de la tienda.";
	}

	protected override string _GetTemplateForMessageLoadUserGroupMembershipError()
	{
		return "No se ha podido cargar la información del miembro del grupo.";
	}

	protected override string _GetTemplateForMessageLoadWallPostsError()
	{
		return "No se han podido cargar las publicaciones del muro.";
	}

	/// <summary>
	/// Key: "Message.Lock"
	/// English String: "{actor} locked the group"
	/// </summary>
	public override string MessageLock(string actor)
	{
		return $"{actor} ha bloqueado el grupo";
	}

	protected override string _GetTemplateForMessageLock()
	{
		return "{actor} ha bloqueado el grupo";
	}

	protected override string _GetTemplateForMessageMakePrimaryError()
	{
		return "No se ha podido crear un grupo principal.";
	}

	protected override string _GetTemplateForMessageMaxGroups()
	{
		return "El usuario se ha unido al número máximo de grupos.";
	}

	protected override string _GetTemplateForMessageMissingGroupIcon()
	{
		return "Falta el icono del grupo en la solicitud.";
	}

	protected override string _GetTemplateForMessageMissingGroupStatusContent()
	{
		return "Falta el contenido de estado del grupo.";
	}

	protected override string _GetTemplateForMessageNameInvalid()
	{
		return "Falta el nombre o los caracteres no son válidos.";
	}

	protected override string _GetTemplateForMessageNameModerated()
	{
		return "El nombre se ha moderado.";
	}

	protected override string _GetTemplateForMessageNameTaken()
	{
		return "El nombre ha sido tomado.";
	}

	protected override string _GetTemplateForMessageNameTooLong()
	{
		return "El nombre es demasiado largo.";
	}

	protected override string _GetTemplateForMessageNoPrimary()
	{
		return "El usuario especificado no tiene un grupo principal.";
	}

	protected override string _GetTemplateForMessagePassCaptchaToJoin()
	{
		return "Debes aprobar el Captcha antes de unirte a este grupo.";
	}

	protected override string _GetTemplateForMessagePassCaptchaToPost()
	{
		return "Se debe aprobar el Captcha para poder publicar en el muro del grupo.";
	}

	/// <summary>
	/// Key: "Message.PostStatus"
	/// English String: "{actor} changed the group status to \"{groupStatus}\""
	/// </summary>
	public override string MessagePostStatus(string actor, string groupStatus)
	{
		return $"{actor} ha cambiado el estado del grupo a \"{groupStatus}\"";
	}

	protected override string _GetTemplateForMessagePostStatus()
	{
		return "{actor} ha cambiado el estado del grupo a \"{groupStatus}\"";
	}

	/// <summary>
	/// Key: "Message.RemoveMember"
	/// English String: "{actor} kicked user {user}"
	/// </summary>
	public override string MessageRemoveMember(string actor, string user)
	{
		return $"{actor} ha expulsado a {user}";
	}

	protected override string _GetTemplateForMessageRemoveMember()
	{
		return "{actor} ha expulsado a {user}";
	}

	protected override string _GetTemplateForMessageRemovePrimaryError()
	{
		return "No se ha podido eliminar el grupo principal.";
	}

	/// <summary>
	/// Key: "Message.Rename"
	/// English String: "{actor} renamed current group to {newName}"
	/// </summary>
	public override string MessageRename(string actor, string newName)
	{
		return $"{actor} ha cambiado el nombre del grupo actual a {newName}";
	}

	protected override string _GetTemplateForMessageRename()
	{
		return "{actor} ha cambiado el nombre del grupo actual a {newName}";
	}

	protected override string _GetTemplateForMessageSearchTermCharactersLimit()
	{
		return "El término de búsqueda debe tener entre 2 y 50 caracteres";
	}

	protected override string _GetTemplateForMessageSearchTermEmptyError()
	{
		return "El campo de búsqueda está vacío";
	}

	protected override string _GetTemplateForMessageSearchTermFilteredError()
	{
		return "Se ha moderado el campo de búsqueda";
	}

	/// <summary>
	/// Key: "Message.SendAllyRequest"
	/// English String: "{actor} sent an ally request to group {group}"
	/// </summary>
	public override string MessageSendAllyRequest(string actor, string group)
	{
		return $"{actor} ha enviado una solicitud de aliado al grupo {group}";
	}

	protected override string _GetTemplateForMessageSendAllyRequest()
	{
		return "{actor} ha enviado una solicitud de aliado al grupo {group}";
	}

	protected override string _GetTemplateForMessageSendGroupShoutError()
	{
		return "No se ha podido enviar un anuncio grupal.";
	}

	protected override string _GetTemplateForMessageSendPostError()
	{
		return "No se ha podido enviar la publicación.";
	}

	/// <summary>
	/// Key: "Message.SpendGroupFunds"
	/// English String: "{actor} spent {amount} of group funds for: {item}"
	/// </summary>
	public override string MessageSpendGroupFunds(string actor, string amount, string item)
	{
		return $"{actor} ha gastado {amount} de los fondos del grupo: {item}";
	}

	protected override string _GetTemplateForMessageSpendGroupFunds()
	{
		return "{actor} ha gastado {amount} de los fondos del grupo: {item}";
	}

	protected override string _GetTemplateForMessageTooManyAttempts()
	{
		return "Demasiados intentos para unirte al grupo. Inténtalo de nuevo más tarde.";
	}

	protected override string _GetTemplateForMessageTooManyAttemptsToClaimGroups()
	{
		return "Demasiados intentos para reclamar el grupo. Inténtalo de nuevo más tarde.";
	}

	protected override string _GetTemplateForMessageTooManyGroups()
	{
		return "Has llegado a la cantidad máxima de grupos. Tienes que salir de un grupo para crear uno nuevo.";
	}

	protected override string _GetTemplateForMessageTooManyIds()
	{
		return "Demasiados ID en la solicitud.";
	}

	protected override string _GetTemplateForMessageTooManyPosts()
	{
		return "Estás publicando demasiado rápido. Inténtalo de nuevo en unos minutos.";
	}

	protected override string _GetTemplateForMessageTooManyRequests()
	{
		return "Demasiadas solicitudes.";
	}

	protected override string _GetTemplateForMessageUnauthorizedForPostStatus()
	{
		return "No tienes autorización para establecer el estado de este grupo.";
	}

	protected override string _GetTemplateForMessageUnauthorizedForViewGroupPayouts()
	{
		return "No tienes permiso para ver los pagos de este grupo.";
	}

	protected override string _GetTemplateForMessageUnauthorizedToClaimGroup()
	{
		return "No tienes autorización para reclamar este grupo.";
	}

	protected override string _GetTemplateForMessageUnauthorizedToManageMember()
	{
		return "No tienes permiso para gestionar a este miembro.";
	}

	protected override string _GetTemplateForMessageUnauthorizedToViewRolesetPermissions()
	{
		return "No tienes autorización para ver los permisos de estos roles.";
	}

	protected override string _GetTemplateForMessageUnauthorizedToViewWall()
	{
		return "No tienes permiso para acceder al muro de este grupo.";
	}

	protected override string _GetTemplateForMessageUnknownError()
	{
		return "Error desconocido";
	}

	/// <summary>
	/// Key: "Message.Unlock"
	/// English String: "{actor} unlocked the group"
	/// </summary>
	public override string MessageUnlock(string actor)
	{
		return $"{actor} ha desbloqueado el grupo";
	}

	protected override string _GetTemplateForMessageUnlock()
	{
		return "{actor} ha desbloqueado el grupo";
	}

	/// <summary>
	/// Key: "Message.UpdateAsset"
	/// English String: "{actor} created new version {version} of asset {item}"
	/// </summary>
	public override string MessageUpdateAsset(string actor, string version, string item)
	{
		return $"{actor} ha creado una nueva versión {version} del recurso {item}";
	}

	protected override string _GetTemplateForMessageUpdateAsset()
	{
		return "{actor} ha creado una nueva versión {version} del recurso {item}";
	}

	/// <summary>
	/// Key: "Message.UpdateAssetRevert"
	/// English String: "{actor} reverted asset {item} from version {version} to {oldVersion}"
	/// </summary>
	public override string MessageUpdateAssetRevert(string actor, string item, string version, string oldVersion)
	{
		return $"{actor} ha revertido el recurso {item} de la versión {version} a {oldVersion}";
	}

	protected override string _GetTemplateForMessageUpdateAssetRevert()
	{
		return "{actor} ha revertido el recurso {item} de la versión {version} a {oldVersion}";
	}

	protected override string _GetTemplateForMessageUserNotInGroup()
	{
		return "No eres miembro del grupo especificado.";
	}
}
