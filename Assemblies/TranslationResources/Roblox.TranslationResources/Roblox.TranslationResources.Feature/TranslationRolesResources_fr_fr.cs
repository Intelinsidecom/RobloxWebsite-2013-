namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides TranslationRolesResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class TranslationRolesResources_fr_fr : TranslationRolesResources_en_us, ITranslationRolesResources, ITranslationResources
{
	/// <summary>
	/// Key: "Description.Modal.DeleteTranslator"
	/// English String: "Are you sure you want to delete this translator?"
	/// </summary>
	public override string DescriptionModalDeleteTranslator => "Voulez-vous vraiment supprimer ce traducteur\u00a0?";

	/// <summary>
	/// Key: "Description.TranslatorTooltip"
	/// English String: "Add translators by username or user ID. You can also add a specific role set from a Group you own as translators. Users with translator access will be able to view game content and provide translations."
	/// </summary>
	public override string DescriptionTranslatorTooltip => "Ajouter des traducteurs selon leur nom ou leur ID d'utilisateur. Vous pouvez également ajouter un rôle spécifique depuis un groupe de traducteurs en votre possession. Les utilisateurs avec un accès traducteur peuvent voir le contenu du jeu et proposer des traductions.";

	/// <summary>
	/// Key: "Heading.Modal.DeleteTranslator"
	/// English String: "Delete Translator"
	/// </summary>
	public override string HeadingModalDeleteTranslator => "Supprimer traducteur";

	/// <summary>
	/// Key: "Heading.Translators"
	/// English String: "Translators"
	/// </summary>
	public override string HeadingTranslators => "Traducteurs";

	/// <summary>
	/// Key: "Label.AddUser"
	/// English String: "Click to add translator"
	/// </summary>
	public override string LabelAddUser => "Cliquez pour ajouter un traducteur";

	/// <summary>
	/// Key: "Label.EnterGroupIdPlaceholder"
	/// English String: "Enter Translator Group ID"
	/// </summary>
	public override string LabelEnterGroupIdPlaceholder => "Saisir l'ID du groupe de traducteurs";

	/// <summary>
	/// Key: "Label.EnterUserIdPlaceholder"
	/// English String: "Enter Translator's UserID"
	/// </summary>
	public override string LabelEnterUserIdPlaceholder => "Saisissez une ID d'utilisateur de traducteur";

	/// <summary>
	/// Key: "Label.EnterUsernamePlaceholder"
	/// English String: "Enter Translator's Username"
	/// </summary>
	public override string LabelEnterUsernamePlaceholder => "Saisissez un nom de traducteur";

	/// <summary>
	/// Key: "Label.EntireGroup"
	/// English String: "Entire Group"
	/// </summary>
	public override string LabelEntireGroup => "Tout le groupe";

	/// <summary>
	/// Key: "Label.GroupId"
	/// English String: "Group ID"
	/// </summary>
	public override string LabelGroupId => "ID de groupe";

	/// <summary>
	/// Key: "Label.Groups"
	/// English String: "Groups"
	/// </summary>
	public override string LabelGroups => "Groupes";

	/// <summary>
	/// Key: "Label.PrivateGroup"
	/// English String: "Private Group"
	/// </summary>
	public override string LabelPrivateGroup => "Groupe privé";

	/// <summary>
	/// Key: "Label.PublicGroup"
	/// English String: "Public Group"
	/// </summary>
	public override string LabelPublicGroup => "Groupe public";

	/// <summary>
	/// Key: "Label.RemoveUser"
	/// English String: "Click to remove translator"
	/// </summary>
	public override string LabelRemoveUser => "Cliquez pour retirer le traducteur";

	/// <summary>
	/// Key: "Label.SelectGroupRole"
	/// English String: "Select Group Role"
	/// </summary>
	public override string LabelSelectGroupRole => "Sélectionner le rôle du groupe";

	/// <summary>
	/// Key: "Label.TranslatorsTooltip"
	/// English String: "Users and groups with translator access will be able to view game content and provide translations."
	/// </summary>
	public override string LabelTranslatorsTooltip => "Les utilisateurs et les groupes avec un accès traducteur peuvent voir le contenu du jeu et proposer des traductions.";

	/// <summary>
	/// Key: "Label.UserId"
	/// English String: "User ID"
	/// </summary>
	public override string LabelUserId => "ID d'utilisateur";

	/// <summary>
	/// Key: "Label.Username"
	/// English String: "Username"
	/// </summary>
	public override string LabelUsername => "Nom d'utilisateur";

	/// <summary>
	/// Key: "Label.Users"
	/// English String: "Users"
	/// </summary>
	public override string LabelUsers => "Utilisateurs";

	/// <summary>
	/// Key: "Message.EnterTranslatorGroupID"
	/// English String: "Please enter Group ID of the group you like to add as translator"
	/// </summary>
	public override string MessageEnterTranslatorGroupID => "Veuillez saisir l'ID du groupe que vous souhaitez ajouter comme traducteur";

	/// <summary>
	/// Key: "Message.EnterTranslatorUserId"
	/// English String: "Please enter a translator's User ID"
	/// </summary>
	public override string MessageEnterTranslatorUserId => "Veuillez saisir une ID d'utilisateur de traducteur.";

	/// <summary>
	/// Key: "Message.EnterTranslatorUsername"
	/// English String: "Please enter a translator's username"
	/// </summary>
	public override string MessageEnterTranslatorUsername => "Veuillez saisir un nom de traducteur.";

	/// <summary>
	/// Key: "Message.GroupAlreadyAdded"
	/// English String: "The group is already added."
	/// </summary>
	public override string MessageGroupAlreadyAdded => "Ce groupe est déjà ajouté.";

	/// <summary>
	/// Key: "Message.GroupAlreadyAddedWithRoleset"
	/// English String: "Group with specified role set is already added. "
	/// </summary>
	public override string MessageGroupAlreadyAddedWithRoleset => "Un groupe avec le rôle indiqué a déjà été ajouté. ";

	/// <summary>
	/// Key: "Message.InvalidGroup"
	/// English String: "Group not found. Please check Group ID entered."
	/// </summary>
	public override string MessageInvalidGroup => "Groupe introuvable. Vérifiez l'ID de groupe indiquée.";

	/// <summary>
	/// Key: "Message.RolesServerError"
	/// This error message is shown when we are unable to show information to the user. We ask them to refresh or try again later because our services might be down.
	/// English String: "Unable to retrieve data. Please refresh or try again later."
	/// </summary>
	public override string MessageRolesServerError => "Récupération des données impossible. Veuillez actualiser ou réessayer plus tard.";

	/// <summary>
	/// Key: "Message.UserAlreadyAdded"
	/// English String: "This user is already added"
	/// </summary>
	public override string MessageUserAlreadyAdded => "Cet utilisateur est déjà ajouté";

	/// <summary>
	/// Key: "Message.UserNotFound"
	/// English String: "User not found. Please check Username or User ID entered."
	/// </summary>
	public override string MessageUserNotFound => "Utilisateur introuvable. Vérifiez le nom ou l'ID d'utilisateur indiquée.";

	public TranslationRolesResources_fr_fr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForDescriptionModalDeleteTranslator()
	{
		return "Voulez-vous vraiment supprimer ce traducteur\u00a0?";
	}

	protected override string _GetTemplateForDescriptionTranslatorTooltip()
	{
		return "Ajouter des traducteurs selon leur nom ou leur ID d'utilisateur. Vous pouvez également ajouter un rôle spécifique depuis un groupe de traducteurs en votre possession. Les utilisateurs avec un accès traducteur peuvent voir le contenu du jeu et proposer des traductions.";
	}

	protected override string _GetTemplateForHeadingModalDeleteTranslator()
	{
		return "Supprimer traducteur";
	}

	protected override string _GetTemplateForHeadingTranslators()
	{
		return "Traducteurs";
	}

	protected override string _GetTemplateForLabelAddUser()
	{
		return "Cliquez pour ajouter un traducteur";
	}

	protected override string _GetTemplateForLabelEnterGroupIdPlaceholder()
	{
		return "Saisir l'ID du groupe de traducteurs";
	}

	protected override string _GetTemplateForLabelEnterUserIdPlaceholder()
	{
		return "Saisissez une ID d'utilisateur de traducteur";
	}

	protected override string _GetTemplateForLabelEnterUsernamePlaceholder()
	{
		return "Saisissez un nom de traducteur";
	}

	protected override string _GetTemplateForLabelEntireGroup()
	{
		return "Tout le groupe";
	}

	protected override string _GetTemplateForLabelGroupId()
	{
		return "ID de groupe";
	}

	protected override string _GetTemplateForLabelGroups()
	{
		return "Groupes";
	}

	protected override string _GetTemplateForLabelPrivateGroup()
	{
		return "Groupe privé";
	}

	protected override string _GetTemplateForLabelPublicGroup()
	{
		return "Groupe public";
	}

	protected override string _GetTemplateForLabelRemoveUser()
	{
		return "Cliquez pour retirer le traducteur";
	}

	/// <summary>
	/// Key: "Label.RolesetName"
	/// English String: "Role: {rolesetName}"
	/// </summary>
	public override string LabelRolesetName(string rolesetName)
	{
		return $"Rôle : {rolesetName}";
	}

	protected override string _GetTemplateForLabelRolesetName()
	{
		return "Rôle : {rolesetName}";
	}

	protected override string _GetTemplateForLabelSelectGroupRole()
	{
		return "Sélectionner le rôle du groupe";
	}

	protected override string _GetTemplateForLabelTranslatorsTooltip()
	{
		return "Les utilisateurs et les groupes avec un accès traducteur peuvent voir le contenu du jeu et proposer des traductions.";
	}

	protected override string _GetTemplateForLabelUserId()
	{
		return "ID d'utilisateur";
	}

	protected override string _GetTemplateForLabelUsername()
	{
		return "Nom d'utilisateur";
	}

	protected override string _GetTemplateForLabelUsers()
	{
		return "Utilisateurs";
	}

	protected override string _GetTemplateForMessageEnterTranslatorGroupID()
	{
		return "Veuillez saisir l'ID du groupe que vous souhaitez ajouter comme traducteur";
	}

	protected override string _GetTemplateForMessageEnterTranslatorUserId()
	{
		return "Veuillez saisir une ID d'utilisateur de traducteur.";
	}

	protected override string _GetTemplateForMessageEnterTranslatorUsername()
	{
		return "Veuillez saisir un nom de traducteur.";
	}

	protected override string _GetTemplateForMessageGroupAlreadyAdded()
	{
		return "Ce groupe est déjà ajouté.";
	}

	protected override string _GetTemplateForMessageGroupAlreadyAddedWithRoleset()
	{
		return "Un groupe avec le rôle indiqué a déjà été ajouté. ";
	}

	protected override string _GetTemplateForMessageInvalidGroup()
	{
		return "Groupe introuvable. Vérifiez l'ID de groupe indiquée.";
	}

	protected override string _GetTemplateForMessageRolesServerError()
	{
		return "Récupération des données impossible. Veuillez actualiser ou réessayer plus tard.";
	}

	protected override string _GetTemplateForMessageUserAlreadyAdded()
	{
		return "Cet utilisateur est déjà ajouté";
	}

	protected override string _GetTemplateForMessageUserNotFound()
	{
		return "Utilisateur introuvable. Vérifiez le nom ou l'ID d'utilisateur indiquée.";
	}
}
