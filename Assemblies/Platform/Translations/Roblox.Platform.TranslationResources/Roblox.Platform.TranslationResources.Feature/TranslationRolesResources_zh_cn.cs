namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides TranslationRolesResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class TranslationRolesResources_zh_cn : TranslationRolesResources_en_us, ITranslationRolesResources, ITranslationResources
{
	/// <summary>
	/// Key: "Description.Modal.DeleteTranslator"
	/// English String: "Are you sure you want to delete this translator?"
	/// </summary>
	public override string DescriptionModalDeleteTranslator => "是否确定删除此译者？";

	/// <summary>
	/// Key: "Description.TranslatorTooltip"
	/// English String: "Add translators by username or user ID. You can also add a specific role set from a Group you own as translators. Users with translator access will be able to view game content and provide translations."
	/// </summary>
	public override string DescriptionTranslatorTooltip => "使用用户名或用户 ID 添加译者。你也可以从你管理的群组中为特定等级添加译者权限。拥有译者权限的用户将可以查看游戏内容并提供翻译。";

	/// <summary>
	/// Key: "Heading.Modal.DeleteTranslator"
	/// English String: "Delete Translator"
	/// </summary>
	public override string HeadingModalDeleteTranslator => "删除译者";

	/// <summary>
	/// Key: "Heading.Translators"
	/// English String: "Translators"
	/// </summary>
	public override string HeadingTranslators => "译者";

	/// <summary>
	/// Key: "Label.AddUser"
	/// English String: "Click to add translator"
	/// </summary>
	public override string LabelAddUser => "点按以添加译者";

	/// <summary>
	/// Key: "Label.EnterGroupIdPlaceholder"
	/// English String: "Enter Translator Group ID"
	/// </summary>
	public override string LabelEnterGroupIdPlaceholder => "输入译者群组 ID";

	/// <summary>
	/// Key: "Label.EnterUserIdPlaceholder"
	/// English String: "Enter Translator's UserID"
	/// </summary>
	public override string LabelEnterUserIdPlaceholder => "输入译者的用户 ID";

	/// <summary>
	/// Key: "Label.EnterUsernamePlaceholder"
	/// English String: "Enter Translator's Username"
	/// </summary>
	public override string LabelEnterUsernamePlaceholder => "输入译者的用户名";

	/// <summary>
	/// Key: "Label.EntireGroup"
	/// English String: "Entire Group"
	/// </summary>
	public override string LabelEntireGroup => "整个群组";

	/// <summary>
	/// Key: "Label.GroupId"
	/// English String: "Group ID"
	/// </summary>
	public override string LabelGroupId => "群组 ID";

	/// <summary>
	/// Key: "Label.Groups"
	/// English String: "Groups"
	/// </summary>
	public override string LabelGroups => "群组";

	/// <summary>
	/// Key: "Label.PrivateGroup"
	/// English String: "Private Group"
	/// </summary>
	public override string LabelPrivateGroup => "私密群组";

	/// <summary>
	/// Key: "Label.PublicGroup"
	/// English String: "Public Group"
	/// </summary>
	public override string LabelPublicGroup => "公开群组";

	/// <summary>
	/// Key: "Label.RemoveUser"
	/// English String: "Click to remove translator"
	/// </summary>
	public override string LabelRemoveUser => "点按以移除译者";

	/// <summary>
	/// Key: "Label.SelectGroupRole"
	/// English String: "Select Group Role"
	/// </summary>
	public override string LabelSelectGroupRole => "选择群组角色";

	/// <summary>
	/// Key: "Label.TranslatorsTooltip"
	/// English String: "Users and groups with translator access will be able to view game content and provide translations."
	/// </summary>
	public override string LabelTranslatorsTooltip => "拥有译者权限的用户将可以查看游戏内容并提供翻译。";

	/// <summary>
	/// Key: "Label.UserId"
	/// English String: "User ID"
	/// </summary>
	public override string LabelUserId => "用户 ID";

	/// <summary>
	/// Key: "Label.Username"
	/// English String: "Username"
	/// </summary>
	public override string LabelUsername => "用户名";

	/// <summary>
	/// Key: "Label.Users"
	/// English String: "Users"
	/// </summary>
	public override string LabelUsers => "用户";

	/// <summary>
	/// Key: "Message.EnterTranslatorGroupID"
	/// English String: "Please enter Group ID of the group you like to add as translator"
	/// </summary>
	public override string MessageEnterTranslatorGroupID => "请为你想要添加为译者的群组输入群组 ID。";

	/// <summary>
	/// Key: "Message.EnterTranslatorUserId"
	/// English String: "Please enter a translator's User ID"
	/// </summary>
	public override string MessageEnterTranslatorUserId => "请输入译者的用户 ID";

	/// <summary>
	/// Key: "Message.EnterTranslatorUsername"
	/// English String: "Please enter a translator's username"
	/// </summary>
	public override string MessageEnterTranslatorUsername => "请输入译者的用户名";

	/// <summary>
	/// Key: "Message.GroupAlreadyAdded"
	/// English String: "The group is already added."
	/// </summary>
	public override string MessageGroupAlreadyAdded => "已添加此群组。";

	/// <summary>
	/// Key: "Message.GroupAlreadyAddedWithRoleset"
	/// English String: "Group with specified role set is already added. "
	/// </summary>
	public override string MessageGroupAlreadyAddedWithRoleset => "已为此群组设定指定权限。 ";

	/// <summary>
	/// Key: "Message.InvalidGroup"
	/// English String: "Group not found. Please check Group ID entered."
	/// </summary>
	public override string MessageInvalidGroup => "找不到群组。请检查已输入的群组 ID。";

	/// <summary>
	/// Key: "Message.RolesServerError"
	/// This error message is shown when we are unable to show information to the user. We ask them to refresh or try again later because our services might be down.
	/// English String: "Unable to retrieve data. Please refresh or try again later."
	/// </summary>
	public override string MessageRolesServerError => "无法获取数据。请刷新或稍后重试。";

	/// <summary>
	/// Key: "Message.UserAlreadyAdded"
	/// English String: "This user is already added"
	/// </summary>
	public override string MessageUserAlreadyAdded => "已添加此用户";

	/// <summary>
	/// Key: "Message.UserNotFound"
	/// English String: "User not found. Please check Username or User ID entered."
	/// </summary>
	public override string MessageUserNotFound => "找不到用户。请检查输入的用户名或用户 ID。";

	public TranslationRolesResources_zh_cn(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForDescriptionModalDeleteTranslator()
	{
		return "是否确定删除此译者？";
	}

	protected override string _GetTemplateForDescriptionTranslatorTooltip()
	{
		return "使用用户名或用户 ID 添加译者。你也可以从你管理的群组中为特定等级添加译者权限。拥有译者权限的用户将可以查看游戏内容并提供翻译。";
	}

	protected override string _GetTemplateForHeadingModalDeleteTranslator()
	{
		return "删除译者";
	}

	protected override string _GetTemplateForHeadingTranslators()
	{
		return "译者";
	}

	protected override string _GetTemplateForLabelAddUser()
	{
		return "点按以添加译者";
	}

	protected override string _GetTemplateForLabelEnterGroupIdPlaceholder()
	{
		return "输入译者群组 ID";
	}

	protected override string _GetTemplateForLabelEnterUserIdPlaceholder()
	{
		return "输入译者的用户 ID";
	}

	protected override string _GetTemplateForLabelEnterUsernamePlaceholder()
	{
		return "输入译者的用户名";
	}

	protected override string _GetTemplateForLabelEntireGroup()
	{
		return "整个群组";
	}

	protected override string _GetTemplateForLabelGroupId()
	{
		return "群组 ID";
	}

	protected override string _GetTemplateForLabelGroups()
	{
		return "群组";
	}

	protected override string _GetTemplateForLabelPrivateGroup()
	{
		return "私密群组";
	}

	protected override string _GetTemplateForLabelPublicGroup()
	{
		return "公开群组";
	}

	protected override string _GetTemplateForLabelRemoveUser()
	{
		return "点按以移除译者";
	}

	/// <summary>
	/// Key: "Label.RolesetName"
	/// English String: "Role: {rolesetName}"
	/// </summary>
	public override string LabelRolesetName(string rolesetName)
	{
		return $"权限：{rolesetName}";
	}

	protected override string _GetTemplateForLabelRolesetName()
	{
		return "权限：{rolesetName}";
	}

	protected override string _GetTemplateForLabelSelectGroupRole()
	{
		return "选择群组角色";
	}

	protected override string _GetTemplateForLabelTranslatorsTooltip()
	{
		return "拥有译者权限的用户将可以查看游戏内容并提供翻译。";
	}

	protected override string _GetTemplateForLabelUserId()
	{
		return "用户 ID";
	}

	protected override string _GetTemplateForLabelUsername()
	{
		return "用户名";
	}

	protected override string _GetTemplateForLabelUsers()
	{
		return "用户";
	}

	protected override string _GetTemplateForMessageEnterTranslatorGroupID()
	{
		return "请为你想要添加为译者的群组输入群组 ID。";
	}

	protected override string _GetTemplateForMessageEnterTranslatorUserId()
	{
		return "请输入译者的用户 ID";
	}

	protected override string _GetTemplateForMessageEnterTranslatorUsername()
	{
		return "请输入译者的用户名";
	}

	protected override string _GetTemplateForMessageGroupAlreadyAdded()
	{
		return "已添加此群组。";
	}

	protected override string _GetTemplateForMessageGroupAlreadyAddedWithRoleset()
	{
		return "已为此群组设定指定权限。 ";
	}

	protected override string _GetTemplateForMessageInvalidGroup()
	{
		return "找不到群组。请检查已输入的群组 ID。";
	}

	protected override string _GetTemplateForMessageRolesServerError()
	{
		return "无法获取数据。请刷新或稍后重试。";
	}

	protected override string _GetTemplateForMessageUserAlreadyAdded()
	{
		return "已添加此用户";
	}

	protected override string _GetTemplateForMessageUserNotFound()
	{
		return "找不到用户。请检查输入的用户名或用户 ID。";
	}
}
