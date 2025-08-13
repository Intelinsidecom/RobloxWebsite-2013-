namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides TranslationRolesResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class TranslationRolesResources_pt_br : TranslationRolesResources_en_us, ITranslationRolesResources, ITranslationResources
{
	/// <summary>
	/// Key: "Description.Modal.DeleteTranslator"
	/// English String: "Are you sure you want to delete this translator?"
	/// </summary>
	public override string DescriptionModalDeleteTranslator => "Quer mesmo excluir este tradutor?";

	/// <summary>
	/// Key: "Description.TranslatorTooltip"
	/// English String: "Add translators by username or user ID. You can also add a specific role set from a Group you own as translators. Users with translator access will be able to view game content and provide translations."
	/// </summary>
	public override string DescriptionTranslatorTooltip => "Adicione tradutores pelo nome de usuário ou ID de usuário. Você também pode adicionar um conjunto de funções específico de um grupo que pertença a você como tradutores. Usuários com acesso de tradutores poderão ver o conteúdo do jogo e fornecer traduções.";

	/// <summary>
	/// Key: "Heading.Modal.DeleteTranslator"
	/// English String: "Delete Translator"
	/// </summary>
	public override string HeadingModalDeleteTranslator => "Excluir tradutor";

	/// <summary>
	/// Key: "Heading.Translators"
	/// English String: "Translators"
	/// </summary>
	public override string HeadingTranslators => "Tradutores";

	/// <summary>
	/// Key: "Label.AddUser"
	/// English String: "Click to add translator"
	/// </summary>
	public override string LabelAddUser => "Clique para adicionar tradutor";

	/// <summary>
	/// Key: "Label.EnterGroupIdPlaceholder"
	/// English String: "Enter Translator Group ID"
	/// </summary>
	public override string LabelEnterGroupIdPlaceholder => "Insira a ID de grupo de tradutores";

	/// <summary>
	/// Key: "Label.EnterUserIdPlaceholder"
	/// English String: "Enter Translator's UserID"
	/// </summary>
	public override string LabelEnterUserIdPlaceholder => "Insira a ID de usuário do tradutor";

	/// <summary>
	/// Key: "Label.EnterUsernamePlaceholder"
	/// English String: "Enter Translator's Username"
	/// </summary>
	public override string LabelEnterUsernamePlaceholder => "Insira o nome de usuário do tradutor";

	/// <summary>
	/// Key: "Label.EntireGroup"
	/// English String: "Entire Group"
	/// </summary>
	public override string LabelEntireGroup => "Grupo inteiro";

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
	public override string LabelRemoveUser => "Clique para remover tradutor";

	/// <summary>
	/// Key: "Label.SelectGroupRole"
	/// English String: "Select Group Role"
	/// </summary>
	public override string LabelSelectGroupRole => "Selecionar função do grupo";

	/// <summary>
	/// Key: "Label.TranslatorsTooltip"
	/// English String: "Users and groups with translator access will be able to view game content and provide translations."
	/// </summary>
	public override string LabelTranslatorsTooltip => "Usuários e grupos com acesso de tradutores poderão ver o conteúdo do jogo e fornecer traduções.";

	/// <summary>
	/// Key: "Label.UserId"
	/// English String: "User ID"
	/// </summary>
	public override string LabelUserId => "ID de usuário";

	/// <summary>
	/// Key: "Label.Username"
	/// English String: "Username"
	/// </summary>
	public override string LabelUsername => "Nome de usuário";

	/// <summary>
	/// Key: "Label.Users"
	/// English String: "Users"
	/// </summary>
	public override string LabelUsers => "Usuários";

	/// <summary>
	/// Key: "Message.EnterTranslatorGroupID"
	/// English String: "Please enter Group ID of the group you like to add as translator"
	/// </summary>
	public override string MessageEnterTranslatorGroupID => "Insira a ID de grupo do grupo que você quer adicionar como tradutor";

	/// <summary>
	/// Key: "Message.EnterTranslatorUserId"
	/// English String: "Please enter a translator's User ID"
	/// </summary>
	public override string MessageEnterTranslatorUserId => "Insira a ID de usuário de um tradutor";

	/// <summary>
	/// Key: "Message.EnterTranslatorUsername"
	/// English String: "Please enter a translator's username"
	/// </summary>
	public override string MessageEnterTranslatorUsername => "Insira o nome de usuário de um tradutor";

	/// <summary>
	/// Key: "Message.GroupAlreadyAdded"
	/// English String: "The group is already added."
	/// </summary>
	public override string MessageGroupAlreadyAdded => "O grupo já foi adicionado.";

	/// <summary>
	/// Key: "Message.GroupAlreadyAddedWithRoleset"
	/// English String: "Group with specified role set is already added. "
	/// </summary>
	public override string MessageGroupAlreadyAddedWithRoleset => "Grupo com conjunto de funções específico já adicionado. ";

	/// <summary>
	/// Key: "Message.InvalidGroup"
	/// English String: "Group not found. Please check Group ID entered."
	/// </summary>
	public override string MessageInvalidGroup => "Grupo não encontrado. Confira o nome de usuário ou ID de grupo inseridos.";

	/// <summary>
	/// Key: "Message.RolesServerError"
	/// This error message is shown when we are unable to show information to the user. We ask them to refresh or try again later because our services might be down.
	/// English String: "Unable to retrieve data. Please refresh or try again later."
	/// </summary>
	public override string MessageRolesServerError => "Impossível recuperar dados. Atualize ou tente novamente mais tarde.";

	/// <summary>
	/// Key: "Message.UserAlreadyAdded"
	/// English String: "This user is already added"
	/// </summary>
	public override string MessageUserAlreadyAdded => "O usuário já foi adicionado";

	/// <summary>
	/// Key: "Message.UserNotFound"
	/// English String: "User not found. Please check Username or User ID entered."
	/// </summary>
	public override string MessageUserNotFound => "Usuário não encontrado. Confira o nome de usuário ou ID de usuário inseridos.";

	public TranslationRolesResources_pt_br(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForDescriptionModalDeleteTranslator()
	{
		return "Quer mesmo excluir este tradutor?";
	}

	protected override string _GetTemplateForDescriptionTranslatorTooltip()
	{
		return "Adicione tradutores pelo nome de usuário ou ID de usuário. Você também pode adicionar um conjunto de funções específico de um grupo que pertença a você como tradutores. Usuários com acesso de tradutores poderão ver o conteúdo do jogo e fornecer traduções.";
	}

	protected override string _GetTemplateForHeadingModalDeleteTranslator()
	{
		return "Excluir tradutor";
	}

	protected override string _GetTemplateForHeadingTranslators()
	{
		return "Tradutores";
	}

	protected override string _GetTemplateForLabelAddUser()
	{
		return "Clique para adicionar tradutor";
	}

	protected override string _GetTemplateForLabelEnterGroupIdPlaceholder()
	{
		return "Insira a ID de grupo de tradutores";
	}

	protected override string _GetTemplateForLabelEnterUserIdPlaceholder()
	{
		return "Insira a ID de usuário do tradutor";
	}

	protected override string _GetTemplateForLabelEnterUsernamePlaceholder()
	{
		return "Insira o nome de usuário do tradutor";
	}

	protected override string _GetTemplateForLabelEntireGroup()
	{
		return "Grupo inteiro";
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
		return "Clique para remover tradutor";
	}

	/// <summary>
	/// Key: "Label.RolesetName"
	/// English String: "Role: {rolesetName}"
	/// </summary>
	public override string LabelRolesetName(string rolesetName)
	{
		return $"Função: {rolesetName}";
	}

	protected override string _GetTemplateForLabelRolesetName()
	{
		return "Função: {rolesetName}";
	}

	protected override string _GetTemplateForLabelSelectGroupRole()
	{
		return "Selecionar função do grupo";
	}

	protected override string _GetTemplateForLabelTranslatorsTooltip()
	{
		return "Usuários e grupos com acesso de tradutores poderão ver o conteúdo do jogo e fornecer traduções.";
	}

	protected override string _GetTemplateForLabelUserId()
	{
		return "ID de usuário";
	}

	protected override string _GetTemplateForLabelUsername()
	{
		return "Nome de usuário";
	}

	protected override string _GetTemplateForLabelUsers()
	{
		return "Usuários";
	}

	protected override string _GetTemplateForMessageEnterTranslatorGroupID()
	{
		return "Insira a ID de grupo do grupo que você quer adicionar como tradutor";
	}

	protected override string _GetTemplateForMessageEnterTranslatorUserId()
	{
		return "Insira a ID de usuário de um tradutor";
	}

	protected override string _GetTemplateForMessageEnterTranslatorUsername()
	{
		return "Insira o nome de usuário de um tradutor";
	}

	protected override string _GetTemplateForMessageGroupAlreadyAdded()
	{
		return "O grupo já foi adicionado.";
	}

	protected override string _GetTemplateForMessageGroupAlreadyAddedWithRoleset()
	{
		return "Grupo com conjunto de funções específico já adicionado. ";
	}

	protected override string _GetTemplateForMessageInvalidGroup()
	{
		return "Grupo não encontrado. Confira o nome de usuário ou ID de grupo inseridos.";
	}

	protected override string _GetTemplateForMessageRolesServerError()
	{
		return "Impossível recuperar dados. Atualize ou tente novamente mais tarde.";
	}

	protected override string _GetTemplateForMessageUserAlreadyAdded()
	{
		return "O usuário já foi adicionado";
	}

	protected override string _GetTemplateForMessageUserNotFound()
	{
		return "Usuário não encontrado. Confira o nome de usuário ou ID de usuário inseridos.";
	}
}
