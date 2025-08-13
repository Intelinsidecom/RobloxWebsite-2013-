namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides TranslationRolesResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class TranslationRolesResources_de_de : TranslationRolesResources_en_us, ITranslationRolesResources, ITranslationResources
{
	/// <summary>
	/// Key: "Description.Modal.DeleteTranslator"
	/// English String: "Are you sure you want to delete this translator?"
	/// </summary>
	public override string DescriptionModalDeleteTranslator => "Möchtest du wirklich diesen Übersetzer löschen?";

	/// <summary>
	/// Key: "Description.TranslatorTooltip"
	/// English String: "Add translators by username or user ID. You can also add a specific role set from a Group you own as translators. Users with translator access will be able to view game content and provide translations."
	/// </summary>
	public override string DescriptionTranslatorTooltip => "Füge Übersetzer nach Benutzername oder Benutzer-ID ein. Du kannst auch bestimmte Rollen an Nutzer aus deinen Gruppen vergeben. Benutzer mit Übersetzerzugriff können Spielinhalte einsehen und Übersetzungen erstellen.";

	/// <summary>
	/// Key: "Heading.Modal.DeleteTranslator"
	/// English String: "Delete Translator"
	/// </summary>
	public override string HeadingModalDeleteTranslator => "Übersetzer löschen";

	/// <summary>
	/// Key: "Heading.Translators"
	/// English String: "Translators"
	/// </summary>
	public override string HeadingTranslators => "Übersetzer";

	/// <summary>
	/// Key: "Label.AddUser"
	/// English String: "Click to add translator"
	/// </summary>
	public override string LabelAddUser => "Klicke, um den Übersetzer hinzuzufügen.";

	/// <summary>
	/// Key: "Label.EnterGroupIdPlaceholder"
	/// English String: "Enter Translator Group ID"
	/// </summary>
	public override string LabelEnterGroupIdPlaceholder => "Gib die Gruppen-ID des Übersetzers ein";

	/// <summary>
	/// Key: "Label.EnterUserIdPlaceholder"
	/// English String: "Enter Translator's UserID"
	/// </summary>
	public override string LabelEnterUserIdPlaceholder => "Gib die Benutzer-ID des Übersetzers ein";

	/// <summary>
	/// Key: "Label.EnterUsernamePlaceholder"
	/// English String: "Enter Translator's Username"
	/// </summary>
	public override string LabelEnterUsernamePlaceholder => "Gib den Benutzernamen des Übersetzers ein.";

	/// <summary>
	/// Key: "Label.EntireGroup"
	/// English String: "Entire Group"
	/// </summary>
	public override string LabelEntireGroup => "Gesamte Gruppe";

	/// <summary>
	/// Key: "Label.GroupId"
	/// English String: "Group ID"
	/// </summary>
	public override string LabelGroupId => "Gruppen-ID";

	/// <summary>
	/// Key: "Label.Groups"
	/// English String: "Groups"
	/// </summary>
	public override string LabelGroups => "Gruppen";

	/// <summary>
	/// Key: "Label.PrivateGroup"
	/// English String: "Private Group"
	/// </summary>
	public override string LabelPrivateGroup => "Private Gruppe";

	/// <summary>
	/// Key: "Label.PublicGroup"
	/// English String: "Public Group"
	/// </summary>
	public override string LabelPublicGroup => "Öffentliche Gruppe";

	/// <summary>
	/// Key: "Label.RemoveUser"
	/// English String: "Click to remove translator"
	/// </summary>
	public override string LabelRemoveUser => "Klicke, um den Übersetzer zu entfernen.";

	/// <summary>
	/// Key: "Label.SelectGroupRole"
	/// English String: "Select Group Role"
	/// </summary>
	public override string LabelSelectGroupRole => "Gruppenrolle auswählen";

	/// <summary>
	/// Key: "Label.TranslatorsTooltip"
	/// English String: "Users and groups with translator access will be able to view game content and provide translations."
	/// </summary>
	public override string LabelTranslatorsTooltip => "Benutzer und Gruppen mit Übersetzungszugriff können Spielinhalte einsehen und Übersetzungen erstellen.";

	/// <summary>
	/// Key: "Label.UserId"
	/// English String: "User ID"
	/// </summary>
	public override string LabelUserId => "Benutzer-ID";

	/// <summary>
	/// Key: "Label.Username"
	/// English String: "Username"
	/// </summary>
	public override string LabelUsername => "Benutzername";

	/// <summary>
	/// Key: "Label.Users"
	/// English String: "Users"
	/// </summary>
	public override string LabelUsers => "Nutzer";

	/// <summary>
	/// Key: "Message.EnterTranslatorGroupID"
	/// English String: "Please enter Group ID of the group you like to add as translator"
	/// </summary>
	public override string MessageEnterTranslatorGroupID => "Bitte gib die Gruppen-ID der Gruppe ein, die du gerne als Übersetzer hinzufügen möchtest";

	/// <summary>
	/// Key: "Message.EnterTranslatorUserId"
	/// English String: "Please enter a translator's User ID"
	/// </summary>
	public override string MessageEnterTranslatorUserId => "Bitte gib den Benutzernamen eines Übersetzers ein";

	/// <summary>
	/// Key: "Message.EnterTranslatorUsername"
	/// English String: "Please enter a translator's username"
	/// </summary>
	public override string MessageEnterTranslatorUsername => "Bitte gib den Benutzernamen eines Übersetzers ein.";

	/// <summary>
	/// Key: "Message.GroupAlreadyAdded"
	/// English String: "The group is already added."
	/// </summary>
	public override string MessageGroupAlreadyAdded => "Die Gruppe wurde bereits hinzugefügt.";

	/// <summary>
	/// Key: "Message.GroupAlreadyAddedWithRoleset"
	/// English String: "Group with specified role set is already added. "
	/// </summary>
	public override string MessageGroupAlreadyAddedWithRoleset => "Gruppe mit angegebenen Rollen wurde bereits hinzugefügt. ";

	/// <summary>
	/// Key: "Message.InvalidGroup"
	/// English String: "Group not found. Please check Group ID entered."
	/// </summary>
	public override string MessageInvalidGroup => "Gruppe nicht gefunden. Bitte überprüfe die eingegebene Gruppen-ID.";

	/// <summary>
	/// Key: "Message.RolesServerError"
	/// This error message is shown when we are unable to show information to the user. We ask them to refresh or try again later because our services might be down.
	/// English String: "Unable to retrieve data. Please refresh or try again later."
	/// </summary>
	public override string MessageRolesServerError => "Daten konnten nicht abgerufen werden. Bitte aktualisiere oder versuche es später erneut.";

	/// <summary>
	/// Key: "Message.UserAlreadyAdded"
	/// English String: "This user is already added"
	/// </summary>
	public override string MessageUserAlreadyAdded => "Dieser Benutzer wurde bereits hinzugefügt.";

	/// <summary>
	/// Key: "Message.UserNotFound"
	/// English String: "User not found. Please check Username or User ID entered."
	/// </summary>
	public override string MessageUserNotFound => "Benutzer nicht gefunden. Bitte überprüfe den Benutzernamen oder die Benutzer-ID.";

	public TranslationRolesResources_de_de(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForDescriptionModalDeleteTranslator()
	{
		return "Möchtest du wirklich diesen Übersetzer löschen?";
	}

	protected override string _GetTemplateForDescriptionTranslatorTooltip()
	{
		return "Füge Übersetzer nach Benutzername oder Benutzer-ID ein. Du kannst auch bestimmte Rollen an Nutzer aus deinen Gruppen vergeben. Benutzer mit Übersetzerzugriff können Spielinhalte einsehen und Übersetzungen erstellen.";
	}

	protected override string _GetTemplateForHeadingModalDeleteTranslator()
	{
		return "Übersetzer löschen";
	}

	protected override string _GetTemplateForHeadingTranslators()
	{
		return "Übersetzer";
	}

	protected override string _GetTemplateForLabelAddUser()
	{
		return "Klicke, um den Übersetzer hinzuzufügen.";
	}

	protected override string _GetTemplateForLabelEnterGroupIdPlaceholder()
	{
		return "Gib die Gruppen-ID des Übersetzers ein";
	}

	protected override string _GetTemplateForLabelEnterUserIdPlaceholder()
	{
		return "Gib die Benutzer-ID des Übersetzers ein";
	}

	protected override string _GetTemplateForLabelEnterUsernamePlaceholder()
	{
		return "Gib den Benutzernamen des Übersetzers ein.";
	}

	protected override string _GetTemplateForLabelEntireGroup()
	{
		return "Gesamte Gruppe";
	}

	protected override string _GetTemplateForLabelGroupId()
	{
		return "Gruppen-ID";
	}

	protected override string _GetTemplateForLabelGroups()
	{
		return "Gruppen";
	}

	protected override string _GetTemplateForLabelPrivateGroup()
	{
		return "Private Gruppe";
	}

	protected override string _GetTemplateForLabelPublicGroup()
	{
		return "Öffentliche Gruppe";
	}

	protected override string _GetTemplateForLabelRemoveUser()
	{
		return "Klicke, um den Übersetzer zu entfernen.";
	}

	/// <summary>
	/// Key: "Label.RolesetName"
	/// English String: "Role: {rolesetName}"
	/// </summary>
	public override string LabelRolesetName(string rolesetName)
	{
		return $"Rolle: {rolesetName}";
	}

	protected override string _GetTemplateForLabelRolesetName()
	{
		return "Rolle: {rolesetName}";
	}

	protected override string _GetTemplateForLabelSelectGroupRole()
	{
		return "Gruppenrolle auswählen";
	}

	protected override string _GetTemplateForLabelTranslatorsTooltip()
	{
		return "Benutzer und Gruppen mit Übersetzungszugriff können Spielinhalte einsehen und Übersetzungen erstellen.";
	}

	protected override string _GetTemplateForLabelUserId()
	{
		return "Benutzer-ID";
	}

	protected override string _GetTemplateForLabelUsername()
	{
		return "Benutzername";
	}

	protected override string _GetTemplateForLabelUsers()
	{
		return "Nutzer";
	}

	protected override string _GetTemplateForMessageEnterTranslatorGroupID()
	{
		return "Bitte gib die Gruppen-ID der Gruppe ein, die du gerne als Übersetzer hinzufügen möchtest";
	}

	protected override string _GetTemplateForMessageEnterTranslatorUserId()
	{
		return "Bitte gib den Benutzernamen eines Übersetzers ein";
	}

	protected override string _GetTemplateForMessageEnterTranslatorUsername()
	{
		return "Bitte gib den Benutzernamen eines Übersetzers ein.";
	}

	protected override string _GetTemplateForMessageGroupAlreadyAdded()
	{
		return "Die Gruppe wurde bereits hinzugefügt.";
	}

	protected override string _GetTemplateForMessageGroupAlreadyAddedWithRoleset()
	{
		return "Gruppe mit angegebenen Rollen wurde bereits hinzugefügt. ";
	}

	protected override string _GetTemplateForMessageInvalidGroup()
	{
		return "Gruppe nicht gefunden. Bitte überprüfe die eingegebene Gruppen-ID.";
	}

	protected override string _GetTemplateForMessageRolesServerError()
	{
		return "Daten konnten nicht abgerufen werden. Bitte aktualisiere oder versuche es später erneut.";
	}

	protected override string _GetTemplateForMessageUserAlreadyAdded()
	{
		return "Dieser Benutzer wurde bereits hinzugefügt.";
	}

	protected override string _GetTemplateForMessageUserNotFound()
	{
		return "Benutzer nicht gefunden. Bitte überprüfe den Benutzernamen oder die Benutzer-ID.";
	}
}
