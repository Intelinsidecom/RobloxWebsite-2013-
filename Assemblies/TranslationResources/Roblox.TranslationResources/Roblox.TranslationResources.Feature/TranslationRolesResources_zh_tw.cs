namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides TranslationRolesResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class TranslationRolesResources_zh_tw : TranslationRolesResources_en_us, ITranslationRolesResources, ITranslationResources
{
	/// <summary>
	/// Key: "Description.Modal.DeleteTranslator"
	/// English String: "Are you sure you want to delete this translator?"
	/// </summary>
	public override string DescriptionModalDeleteTranslator => "確定刪除此譯者？";

	/// <summary>
	/// Key: "Description.TranslatorTooltip"
	/// English String: "Add translators by username or user ID. You can also add a specific role set from a Group you own as translators. Users with translator access will be able to view game content and provide translations."
	/// </summary>
	public override string DescriptionTranslatorTooltip => "以使用者名稱或使用者 ID 新增譯者。您也可以從您管理的群組裡面為特定階級啟用譯者權限。擁有譯者權限的使用者將可以檢視遊戲內容與提供翻譯。";

	/// <summary>
	/// Key: "Heading.Modal.DeleteTranslator"
	/// English String: "Delete Translator"
	/// </summary>
	public override string HeadingModalDeleteTranslator => "刪除譯者";

	/// <summary>
	/// Key: "Heading.Translators"
	/// English String: "Translators"
	/// </summary>
	public override string HeadingTranslators => "譯者";

	/// <summary>
	/// Key: "Label.AddUser"
	/// English String: "Click to add translator"
	/// </summary>
	public override string LabelAddUser => "按下新增譯者";

	/// <summary>
	/// Key: "Label.EnterGroupIdPlaceholder"
	/// English String: "Enter Translator Group ID"
	/// </summary>
	public override string LabelEnterGroupIdPlaceholder => "輸入譯者群組 ID";

	/// <summary>
	/// Key: "Label.EnterUserIdPlaceholder"
	/// English String: "Enter Translator's UserID"
	/// </summary>
	public override string LabelEnterUserIdPlaceholder => "輸入譯者的使用者 ID";

	/// <summary>
	/// Key: "Label.EnterUsernamePlaceholder"
	/// English String: "Enter Translator's Username"
	/// </summary>
	public override string LabelEnterUsernamePlaceholder => "輸入譯者使用者名稱";

	/// <summary>
	/// Key: "Label.EntireGroup"
	/// English String: "Entire Group"
	/// </summary>
	public override string LabelEntireGroup => "整個群組";

	/// <summary>
	/// Key: "Label.GroupId"
	/// English String: "Group ID"
	/// </summary>
	public override string LabelGroupId => "群組 ID";

	/// <summary>
	/// Key: "Label.Groups"
	/// English String: "Groups"
	/// </summary>
	public override string LabelGroups => "群組";

	/// <summary>
	/// Key: "Label.PrivateGroup"
	/// English String: "Private Group"
	/// </summary>
	public override string LabelPrivateGroup => "私人群組";

	/// <summary>
	/// Key: "Label.PublicGroup"
	/// English String: "Public Group"
	/// </summary>
	public override string LabelPublicGroup => "公開群組";

	/// <summary>
	/// Key: "Label.RemoveUser"
	/// English String: "Click to remove translator"
	/// </summary>
	public override string LabelRemoveUser => "按下移除譯者";

	/// <summary>
	/// Key: "Label.SelectGroupRole"
	/// English String: "Select Group Role"
	/// </summary>
	public override string LabelSelectGroupRole => "選擇群組階級";

	/// <summary>
	/// Key: "Label.TranslatorsTooltip"
	/// English String: "Users and groups with translator access will be able to view game content and provide translations."
	/// </summary>
	public override string LabelTranslatorsTooltip => "擁有譯者權限的使用者將可以檢視遊戲內容與提供翻譯。";

	/// <summary>
	/// Key: "Label.UserId"
	/// English String: "User ID"
	/// </summary>
	public override string LabelUserId => "使用者 ID";

	/// <summary>
	/// Key: "Label.Username"
	/// English String: "Username"
	/// </summary>
	public override string LabelUsername => "使用者名稱";

	/// <summary>
	/// Key: "Label.Users"
	/// English String: "Users"
	/// </summary>
	public override string LabelUsers => "使用者";

	/// <summary>
	/// Key: "Message.EnterTranslatorGroupID"
	/// English String: "Please enter Group ID of the group you like to add as translator"
	/// </summary>
	public override string MessageEnterTranslatorGroupID => "請輸入欲設為譯者的群組的 ID";

	/// <summary>
	/// Key: "Message.EnterTranslatorUserId"
	/// English String: "Please enter a translator's User ID"
	/// </summary>
	public override string MessageEnterTranslatorUserId => "請輸入譯者使用者 ID。";

	/// <summary>
	/// Key: "Message.EnterTranslatorUsername"
	/// English String: "Please enter a translator's username"
	/// </summary>
	public override string MessageEnterTranslatorUsername => "請輸入譯者使用者名稱";

	/// <summary>
	/// Key: "Message.GroupAlreadyAdded"
	/// English String: "The group is already added."
	/// </summary>
	public override string MessageGroupAlreadyAdded => "此群組已加入。";

	/// <summary>
	/// Key: "Message.GroupAlreadyAddedWithRoleset"
	/// English String: "Group with specified role set is already added. "
	/// </summary>
	public override string MessageGroupAlreadyAddedWithRoleset => "已為此群組設定指定權限。";

	/// <summary>
	/// Key: "Message.InvalidGroup"
	/// English String: "Group not found. Please check Group ID entered."
	/// </summary>
	public override string MessageInvalidGroup => "找不到群組，請確認群組 ID。";

	/// <summary>
	/// Key: "Message.RolesServerError"
	/// This error message is shown when we are unable to show information to the user. We ask them to refresh or try again later because our services might be down.
	/// English String: "Unable to retrieve data. Please refresh or try again later."
	/// </summary>
	public override string MessageRolesServerError => "無法擷取資料，請重新整理或稍後再試。";

	/// <summary>
	/// Key: "Message.UserAlreadyAdded"
	/// English String: "This user is already added"
	/// </summary>
	public override string MessageUserAlreadyAdded => "此使用者已加入";

	/// <summary>
	/// Key: "Message.UserNotFound"
	/// English String: "User not found. Please check Username or User ID entered."
	/// </summary>
	public override string MessageUserNotFound => "找不到使用者，請檢查輸入的使用者名稱或使用者 ID。";

	public TranslationRolesResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForDescriptionModalDeleteTranslator()
	{
		return "確定刪除此譯者？";
	}

	protected override string _GetTemplateForDescriptionTranslatorTooltip()
	{
		return "以使用者名稱或使用者 ID 新增譯者。您也可以從您管理的群組裡面為特定階級啟用譯者權限。擁有譯者權限的使用者將可以檢視遊戲內容與提供翻譯。";
	}

	protected override string _GetTemplateForHeadingModalDeleteTranslator()
	{
		return "刪除譯者";
	}

	protected override string _GetTemplateForHeadingTranslators()
	{
		return "譯者";
	}

	protected override string _GetTemplateForLabelAddUser()
	{
		return "按下新增譯者";
	}

	protected override string _GetTemplateForLabelEnterGroupIdPlaceholder()
	{
		return "輸入譯者群組 ID";
	}

	protected override string _GetTemplateForLabelEnterUserIdPlaceholder()
	{
		return "輸入譯者的使用者 ID";
	}

	protected override string _GetTemplateForLabelEnterUsernamePlaceholder()
	{
		return "輸入譯者使用者名稱";
	}

	protected override string _GetTemplateForLabelEntireGroup()
	{
		return "整個群組";
	}

	protected override string _GetTemplateForLabelGroupId()
	{
		return "群組 ID";
	}

	protected override string _GetTemplateForLabelGroups()
	{
		return "群組";
	}

	protected override string _GetTemplateForLabelPrivateGroup()
	{
		return "私人群組";
	}

	protected override string _GetTemplateForLabelPublicGroup()
	{
		return "公開群組";
	}

	protected override string _GetTemplateForLabelRemoveUser()
	{
		return "按下移除譯者";
	}

	/// <summary>
	/// Key: "Label.RolesetName"
	/// English String: "Role: {rolesetName}"
	/// </summary>
	public override string LabelRolesetName(string rolesetName)
	{
		return $"階級：{rolesetName}";
	}

	protected override string _GetTemplateForLabelRolesetName()
	{
		return "階級：{rolesetName}";
	}

	protected override string _GetTemplateForLabelSelectGroupRole()
	{
		return "選擇群組階級";
	}

	protected override string _GetTemplateForLabelTranslatorsTooltip()
	{
		return "擁有譯者權限的使用者將可以檢視遊戲內容與提供翻譯。";
	}

	protected override string _GetTemplateForLabelUserId()
	{
		return "使用者 ID";
	}

	protected override string _GetTemplateForLabelUsername()
	{
		return "使用者名稱";
	}

	protected override string _GetTemplateForLabelUsers()
	{
		return "使用者";
	}

	protected override string _GetTemplateForMessageEnterTranslatorGroupID()
	{
		return "請輸入欲設為譯者的群組的 ID";
	}

	protected override string _GetTemplateForMessageEnterTranslatorUserId()
	{
		return "請輸入譯者使用者 ID。";
	}

	protected override string _GetTemplateForMessageEnterTranslatorUsername()
	{
		return "請輸入譯者使用者名稱";
	}

	protected override string _GetTemplateForMessageGroupAlreadyAdded()
	{
		return "此群組已加入。";
	}

	protected override string _GetTemplateForMessageGroupAlreadyAddedWithRoleset()
	{
		return "已為此群組設定指定權限。";
	}

	protected override string _GetTemplateForMessageInvalidGroup()
	{
		return "找不到群組，請確認群組 ID。";
	}

	protected override string _GetTemplateForMessageRolesServerError()
	{
		return "無法擷取資料，請重新整理或稍後再試。";
	}

	protected override string _GetTemplateForMessageUserAlreadyAdded()
	{
		return "此使用者已加入";
	}

	protected override string _GetTemplateForMessageUserNotFound()
	{
		return "找不到使用者，請檢查輸入的使用者名稱或使用者 ID。";
	}
}
