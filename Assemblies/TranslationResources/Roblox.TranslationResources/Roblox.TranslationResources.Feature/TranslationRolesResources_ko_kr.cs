namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides TranslationRolesResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class TranslationRolesResources_ko_kr : TranslationRolesResources_en_us, ITranslationRolesResources, ITranslationResources
{
	/// <summary>
	/// Key: "Description.Modal.DeleteTranslator"
	/// English String: "Are you sure you want to delete this translator?"
	/// </summary>
	public override string DescriptionModalDeleteTranslator => "정말로 이 번역가를 삭제할까요?";

	/// <summary>
	/// Key: "Description.TranslatorTooltip"
	/// English String: "Add translators by username or user ID. You can also add a specific role set from a Group you own as translators. Users with translator access will be able to view game content and provide translations."
	/// </summary>
	public override string DescriptionTranslatorTooltip => "사용자 이름이나 ID로 번역가를 추가하세요. 소유하고 있는 그룹의 역할군에 번역가를 추가할 수도 있습니다. 번역 접근 권한이 있는 사용자는 게임 콘텐츠를 보거나 번역을 할 수 있습니다.";

	/// <summary>
	/// Key: "Heading.Modal.DeleteTranslator"
	/// English String: "Delete Translator"
	/// </summary>
	public override string HeadingModalDeleteTranslator => "번역가 삭제";

	/// <summary>
	/// Key: "Heading.Translators"
	/// English String: "Translators"
	/// </summary>
	public override string HeadingTranslators => "번역가";

	/// <summary>
	/// Key: "Label.AddUser"
	/// English String: "Click to add translator"
	/// </summary>
	public override string LabelAddUser => "번역가를 추가하려면 클릭하세요";

	/// <summary>
	/// Key: "Label.EnterGroupIdPlaceholder"
	/// English String: "Enter Translator Group ID"
	/// </summary>
	public override string LabelEnterGroupIdPlaceholder => "번역가 그룹 ID 입력";

	/// <summary>
	/// Key: "Label.EnterUserIdPlaceholder"
	/// English String: "Enter Translator's UserID"
	/// </summary>
	public override string LabelEnterUserIdPlaceholder => "번역가의 사용자 ID 입력";

	/// <summary>
	/// Key: "Label.EnterUsernamePlaceholder"
	/// English String: "Enter Translator's Username"
	/// </summary>
	public override string LabelEnterUsernamePlaceholder => "번역가의 사용자 이름을 입력하세요";

	/// <summary>
	/// Key: "Label.EntireGroup"
	/// English String: "Entire Group"
	/// </summary>
	public override string LabelEntireGroup => "그룹 전체";

	/// <summary>
	/// Key: "Label.GroupId"
	/// English String: "Group ID"
	/// </summary>
	public override string LabelGroupId => "그룹 ID";

	/// <summary>
	/// Key: "Label.Groups"
	/// English String: "Groups"
	/// </summary>
	public override string LabelGroups => "그룹";

	/// <summary>
	/// Key: "Label.PrivateGroup"
	/// English String: "Private Group"
	/// </summary>
	public override string LabelPrivateGroup => "비공개 그룹";

	/// <summary>
	/// Key: "Label.PublicGroup"
	/// English String: "Public Group"
	/// </summary>
	public override string LabelPublicGroup => "공개 그룹";

	/// <summary>
	/// Key: "Label.RemoveUser"
	/// English String: "Click to remove translator"
	/// </summary>
	public override string LabelRemoveUser => "번역가를 삭제하려면 클릭하세요";

	/// <summary>
	/// Key: "Label.SelectGroupRole"
	/// English String: "Select Group Role"
	/// </summary>
	public override string LabelSelectGroupRole => "그룹 역할 선택";

	/// <summary>
	/// Key: "Label.TranslatorsTooltip"
	/// English String: "Users and groups with translator access will be able to view game content and provide translations."
	/// </summary>
	public override string LabelTranslatorsTooltip => "번역 접근 권한이 있는 사용자와 그룹은 게임 콘텐츠를 보거나 번역을 할 수 있습니다.";

	/// <summary>
	/// Key: "Label.UserId"
	/// English String: "User ID"
	/// </summary>
	public override string LabelUserId => "사용자 ID";

	/// <summary>
	/// Key: "Label.Username"
	/// English String: "Username"
	/// </summary>
	public override string LabelUsername => "사용자 이름";

	/// <summary>
	/// Key: "Label.Users"
	/// English String: "Users"
	/// </summary>
	public override string LabelUsers => "사용자";

	/// <summary>
	/// Key: "Message.EnterTranslatorGroupID"
	/// English String: "Please enter Group ID of the group you like to add as translator"
	/// </summary>
	public override string MessageEnterTranslatorGroupID => "번역가로 추가할 그룹의 그룹 ID를 입력하세요.";

	/// <summary>
	/// Key: "Message.EnterTranslatorUserId"
	/// English String: "Please enter a translator's User ID"
	/// </summary>
	public override string MessageEnterTranslatorUserId => "번역가의 사용자 ID를 입력하세요";

	/// <summary>
	/// Key: "Message.EnterTranslatorUsername"
	/// English String: "Please enter a translator's username"
	/// </summary>
	public override string MessageEnterTranslatorUsername => "번역가의 사용자 이름을 입력하세요";

	/// <summary>
	/// Key: "Message.GroupAlreadyAdded"
	/// English String: "The group is already added."
	/// </summary>
	public override string MessageGroupAlreadyAdded => "이미 추가된 그룹이에요.";

	/// <summary>
	/// Key: "Message.GroupAlreadyAddedWithRoleset"
	/// English String: "Group with specified role set is already added. "
	/// </summary>
	public override string MessageGroupAlreadyAddedWithRoleset => "이 역할군의 그룹이 이미 추가되었어요. ";

	/// <summary>
	/// Key: "Message.InvalidGroup"
	/// English String: "Group not found. Please check Group ID entered."
	/// </summary>
	public override string MessageInvalidGroup => "그룹을 찾을 수 없습니다. 입력한 그룹 ID를 확인하세요.";

	/// <summary>
	/// Key: "Message.RolesServerError"
	/// This error message is shown when we are unable to show information to the user. We ask them to refresh or try again later because our services might be down.
	/// English String: "Unable to retrieve data. Please refresh or try again later."
	/// </summary>
	public override string MessageRolesServerError => "데이터 검색 불가. 새로 고침을 하거나 나중에 다시 시도하세요.";

	/// <summary>
	/// Key: "Message.UserAlreadyAdded"
	/// English String: "This user is already added"
	/// </summary>
	public override string MessageUserAlreadyAdded => "본 사용자는 이미 추가되었습니다";

	/// <summary>
	/// Key: "Message.UserNotFound"
	/// English String: "User not found. Please check Username or User ID entered."
	/// </summary>
	public override string MessageUserNotFound => "사용자를 찾을 수 없습니다. 입력한 사용자 이름이나 ID를 확인하세요.";

	public TranslationRolesResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForDescriptionModalDeleteTranslator()
	{
		return "정말로 이 번역가를 삭제할까요?";
	}

	protected override string _GetTemplateForDescriptionTranslatorTooltip()
	{
		return "사용자 이름이나 ID로 번역가를 추가하세요. 소유하고 있는 그룹의 역할군에 번역가를 추가할 수도 있습니다. 번역 접근 권한이 있는 사용자는 게임 콘텐츠를 보거나 번역을 할 수 있습니다.";
	}

	protected override string _GetTemplateForHeadingModalDeleteTranslator()
	{
		return "번역가 삭제";
	}

	protected override string _GetTemplateForHeadingTranslators()
	{
		return "번역가";
	}

	protected override string _GetTemplateForLabelAddUser()
	{
		return "번역가를 추가하려면 클릭하세요";
	}

	protected override string _GetTemplateForLabelEnterGroupIdPlaceholder()
	{
		return "번역가 그룹 ID 입력";
	}

	protected override string _GetTemplateForLabelEnterUserIdPlaceholder()
	{
		return "번역가의 사용자 ID 입력";
	}

	protected override string _GetTemplateForLabelEnterUsernamePlaceholder()
	{
		return "번역가의 사용자 이름을 입력하세요";
	}

	protected override string _GetTemplateForLabelEntireGroup()
	{
		return "그룹 전체";
	}

	protected override string _GetTemplateForLabelGroupId()
	{
		return "그룹 ID";
	}

	protected override string _GetTemplateForLabelGroups()
	{
		return "그룹";
	}

	protected override string _GetTemplateForLabelPrivateGroup()
	{
		return "비공개 그룹";
	}

	protected override string _GetTemplateForLabelPublicGroup()
	{
		return "공개 그룹";
	}

	protected override string _GetTemplateForLabelRemoveUser()
	{
		return "번역가를 삭제하려면 클릭하세요";
	}

	/// <summary>
	/// Key: "Label.RolesetName"
	/// English String: "Role: {rolesetName}"
	/// </summary>
	public override string LabelRolesetName(string rolesetName)
	{
		return $"역할: {rolesetName}";
	}

	protected override string _GetTemplateForLabelRolesetName()
	{
		return "역할: {rolesetName}";
	}

	protected override string _GetTemplateForLabelSelectGroupRole()
	{
		return "그룹 역할 선택";
	}

	protected override string _GetTemplateForLabelTranslatorsTooltip()
	{
		return "번역 접근 권한이 있는 사용자와 그룹은 게임 콘텐츠를 보거나 번역을 할 수 있습니다.";
	}

	protected override string _GetTemplateForLabelUserId()
	{
		return "사용자 ID";
	}

	protected override string _GetTemplateForLabelUsername()
	{
		return "사용자 이름";
	}

	protected override string _GetTemplateForLabelUsers()
	{
		return "사용자";
	}

	protected override string _GetTemplateForMessageEnterTranslatorGroupID()
	{
		return "번역가로 추가할 그룹의 그룹 ID를 입력하세요.";
	}

	protected override string _GetTemplateForMessageEnterTranslatorUserId()
	{
		return "번역가의 사용자 ID를 입력하세요";
	}

	protected override string _GetTemplateForMessageEnterTranslatorUsername()
	{
		return "번역가의 사용자 이름을 입력하세요";
	}

	protected override string _GetTemplateForMessageGroupAlreadyAdded()
	{
		return "이미 추가된 그룹이에요.";
	}

	protected override string _GetTemplateForMessageGroupAlreadyAddedWithRoleset()
	{
		return "이 역할군의 그룹이 이미 추가되었어요. ";
	}

	protected override string _GetTemplateForMessageInvalidGroup()
	{
		return "그룹을 찾을 수 없습니다. 입력한 그룹 ID를 확인하세요.";
	}

	protected override string _GetTemplateForMessageRolesServerError()
	{
		return "데이터 검색 불가. 새로 고침을 하거나 나중에 다시 시도하세요.";
	}

	protected override string _GetTemplateForMessageUserAlreadyAdded()
	{
		return "본 사용자는 이미 추가되었습니다";
	}

	protected override string _GetTemplateForMessageUserNotFound()
	{
		return "사용자를 찾을 수 없습니다. 입력한 사용자 이름이나 ID를 확인하세요.";
	}
}
