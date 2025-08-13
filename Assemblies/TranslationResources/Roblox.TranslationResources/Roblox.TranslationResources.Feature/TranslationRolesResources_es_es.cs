namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides TranslationRolesResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class TranslationRolesResources_es_es : TranslationRolesResources_en_us, ITranslationRolesResources, ITranslationResources
{
	/// <summary>
	/// Key: "Description.Modal.DeleteTranslator"
	/// English String: "Are you sure you want to delete this translator?"
	/// </summary>
	public override string DescriptionModalDeleteTranslator => "¿Seguro que quieres eliminar este traductor?";

	/// <summary>
	/// Key: "Description.TranslatorTooltip"
	/// English String: "Add translators by username or user ID. You can also add a specific role set from a Group you own as translators. Users with translator access will be able to view game content and provide translations."
	/// </summary>
	public override string DescriptionTranslatorTooltip => "Añade traductores utilizando el nombre o ID de usuario. También puedes definir unas funciones, como la de traductor, desde el grupo de tu propiedad. Los traductores pueden ver el contenido del juego y traducirlo.";

	/// <summary>
	/// Key: "Heading.Modal.DeleteTranslator"
	/// English String: "Delete Translator"
	/// </summary>
	public override string HeadingModalDeleteTranslator => "Eliminar traductor";

	/// <summary>
	/// Key: "Heading.Translators"
	/// English String: "Translators"
	/// </summary>
	public override string HeadingTranslators => "Traductores";

	/// <summary>
	/// Key: "Label.AddUser"
	/// English String: "Click to add translator"
	/// </summary>
	public override string LabelAddUser => "Haz clic para añadir al traductor";

	/// <summary>
	/// Key: "Label.EnterGroupIdPlaceholder"
	/// English String: "Enter Translator Group ID"
	/// </summary>
	public override string LabelEnterGroupIdPlaceholder => "Introduce el ID de grupo del traductor";

	/// <summary>
	/// Key: "Label.EnterUserIdPlaceholder"
	/// English String: "Enter Translator's UserID"
	/// </summary>
	public override string LabelEnterUserIdPlaceholder => "Introduce el ID de usuario del traductor";

	/// <summary>
	/// Key: "Label.EnterUsernamePlaceholder"
	/// English String: "Enter Translator's Username"
	/// </summary>
	public override string LabelEnterUsernamePlaceholder => "Introduce el nombre de usuario del traductor";

	/// <summary>
	/// Key: "Label.EntireGroup"
	/// English String: "Entire Group"
	/// </summary>
	public override string LabelEntireGroup => "Todo el grupo";

	/// <summary>
	/// Key: "Label.GroupId"
	/// English String: "Group ID"
	/// </summary>
	public override string LabelGroupId => "ID de grupo";

	/// <summary>
	/// Key: "Label.Groups"
	/// English String: "Groups"
	/// </summary>
	public override string LabelGroups => "Grupos";

	/// <summary>
	/// Key: "Label.PrivateGroup"
	/// English String: "Private Group"
	/// </summary>
	public override string LabelPrivateGroup => "Grupo privado";

	/// <summary>
	/// Key: "Label.PublicGroup"
	/// English String: "Public Group"
	/// </summary>
	public override string LabelPublicGroup => "Grupo público";

	/// <summary>
	/// Key: "Label.RemoveUser"
	/// English String: "Click to remove translator"
	/// </summary>
	public override string LabelRemoveUser => "Haz clic para eliminar al traductor";

	/// <summary>
	/// Key: "Label.SelectGroupRole"
	/// English String: "Select Group Role"
	/// </summary>
	public override string LabelSelectGroupRole => "Seleccionar un rol para el grupo";

	/// <summary>
	/// Key: "Label.TranslatorsTooltip"
	/// English String: "Users and groups with translator access will be able to view game content and provide translations."
	/// </summary>
	public override string LabelTranslatorsTooltip => "Los usuarios y grupos que tengan acceso como traductores podrán ver el contenido del juego y traducirlo.";

	/// <summary>
	/// Key: "Label.UserId"
	/// English String: "User ID"
	/// </summary>
	public override string LabelUserId => "ID de usuario";

	/// <summary>
	/// Key: "Label.Username"
	/// English String: "Username"
	/// </summary>
	public override string LabelUsername => "Nombre de usuario";

	/// <summary>
	/// Key: "Label.Users"
	/// English String: "Users"
	/// </summary>
	public override string LabelUsers => "Usuarios";

	/// <summary>
	/// Key: "Message.EnterTranslatorGroupID"
	/// English String: "Please enter Group ID of the group you like to add as translator"
	/// </summary>
	public override string MessageEnterTranslatorGroupID => "Introduce el ID de grupo del grupo que quieres añadir como traductor.";

	/// <summary>
	/// Key: "Message.EnterTranslatorUserId"
	/// English String: "Please enter a translator's User ID"
	/// </summary>
	public override string MessageEnterTranslatorUserId => "Introduce el ID de usuario de un traductor";

	/// <summary>
	/// Key: "Message.EnterTranslatorUsername"
	/// English String: "Please enter a translator's username"
	/// </summary>
	public override string MessageEnterTranslatorUsername => "Introduce el nombre de usuario del traductor";

	/// <summary>
	/// Key: "Message.GroupAlreadyAdded"
	/// English String: "The group is already added."
	/// </summary>
	public override string MessageGroupAlreadyAdded => "El grupo ya se ha añadido.";

	/// <summary>
	/// Key: "Message.GroupAlreadyAddedWithRoleset"
	/// English String: "Group with specified role set is already added. "
	/// </summary>
	public override string MessageGroupAlreadyAddedWithRoleset => "El grupo con roles específicos ya se ha añadido. ";

	/// <summary>
	/// Key: "Message.InvalidGroup"
	/// English String: "Group not found. Please check Group ID entered."
	/// </summary>
	public override string MessageInvalidGroup => "Grupo no encontrado. Comprueba el ID de grupo.";

	/// <summary>
	/// Key: "Message.RolesServerError"
	/// This error message is shown when we are unable to show information to the user. We ask them to refresh or try again later because our services might be down.
	/// English String: "Unable to retrieve data. Please refresh or try again later."
	/// </summary>
	public override string MessageRolesServerError => "No se puede recuperar los datos. Actualiza la página o inténtalo más tarde.";

	/// <summary>
	/// Key: "Message.UserAlreadyAdded"
	/// English String: "This user is already added"
	/// </summary>
	public override string MessageUserAlreadyAdded => "Este usuario ya se ha añadido";

	/// <summary>
	/// Key: "Message.UserNotFound"
	/// English String: "User not found. Please check Username or User ID entered."
	/// </summary>
	public override string MessageUserNotFound => "Usuario no encontrado. Comprueba el nombre o ID de usuario ingresados.";

	public TranslationRolesResources_es_es(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForDescriptionModalDeleteTranslator()
	{
		return "¿Seguro que quieres eliminar este traductor?";
	}

	protected override string _GetTemplateForDescriptionTranslatorTooltip()
	{
		return "Añade traductores utilizando el nombre o ID de usuario. También puedes definir unas funciones, como la de traductor, desde el grupo de tu propiedad. Los traductores pueden ver el contenido del juego y traducirlo.";
	}

	protected override string _GetTemplateForHeadingModalDeleteTranslator()
	{
		return "Eliminar traductor";
	}

	protected override string _GetTemplateForHeadingTranslators()
	{
		return "Traductores";
	}

	protected override string _GetTemplateForLabelAddUser()
	{
		return "Haz clic para añadir al traductor";
	}

	protected override string _GetTemplateForLabelEnterGroupIdPlaceholder()
	{
		return "Introduce el ID de grupo del traductor";
	}

	protected override string _GetTemplateForLabelEnterUserIdPlaceholder()
	{
		return "Introduce el ID de usuario del traductor";
	}

	protected override string _GetTemplateForLabelEnterUsernamePlaceholder()
	{
		return "Introduce el nombre de usuario del traductor";
	}

	protected override string _GetTemplateForLabelEntireGroup()
	{
		return "Todo el grupo";
	}

	protected override string _GetTemplateForLabelGroupId()
	{
		return "ID de grupo";
	}

	protected override string _GetTemplateForLabelGroups()
	{
		return "Grupos";
	}

	protected override string _GetTemplateForLabelPrivateGroup()
	{
		return "Grupo privado";
	}

	protected override string _GetTemplateForLabelPublicGroup()
	{
		return "Grupo público";
	}

	protected override string _GetTemplateForLabelRemoveUser()
	{
		return "Haz clic para eliminar al traductor";
	}

	/// <summary>
	/// Key: "Label.RolesetName"
	/// English String: "Role: {rolesetName}"
	/// </summary>
	public override string LabelRolesetName(string rolesetName)
	{
		return $"Rol: {rolesetName}";
	}

	protected override string _GetTemplateForLabelRolesetName()
	{
		return "Rol: {rolesetName}";
	}

	protected override string _GetTemplateForLabelSelectGroupRole()
	{
		return "Seleccionar un rol para el grupo";
	}

	protected override string _GetTemplateForLabelTranslatorsTooltip()
	{
		return "Los usuarios y grupos que tengan acceso como traductores podrán ver el contenido del juego y traducirlo.";
	}

	protected override string _GetTemplateForLabelUserId()
	{
		return "ID de usuario";
	}

	protected override string _GetTemplateForLabelUsername()
	{
		return "Nombre de usuario";
	}

	protected override string _GetTemplateForLabelUsers()
	{
		return "Usuarios";
	}

	protected override string _GetTemplateForMessageEnterTranslatorGroupID()
	{
		return "Introduce el ID de grupo del grupo que quieres añadir como traductor.";
	}

	protected override string _GetTemplateForMessageEnterTranslatorUserId()
	{
		return "Introduce el ID de usuario de un traductor";
	}

	protected override string _GetTemplateForMessageEnterTranslatorUsername()
	{
		return "Introduce el nombre de usuario del traductor";
	}

	protected override string _GetTemplateForMessageGroupAlreadyAdded()
	{
		return "El grupo ya se ha añadido.";
	}

	protected override string _GetTemplateForMessageGroupAlreadyAddedWithRoleset()
	{
		return "El grupo con roles específicos ya se ha añadido. ";
	}

	protected override string _GetTemplateForMessageInvalidGroup()
	{
		return "Grupo no encontrado. Comprueba el ID de grupo.";
	}

	protected override string _GetTemplateForMessageRolesServerError()
	{
		return "No se puede recuperar los datos. Actualiza la página o inténtalo más tarde.";
	}

	protected override string _GetTemplateForMessageUserAlreadyAdded()
	{
		return "Este usuario ya se ha añadido";
	}

	protected override string _GetTemplateForMessageUserNotFound()
	{
		return "Usuario no encontrado. Comprueba el nombre o ID de usuario ingresados.";
	}
}
