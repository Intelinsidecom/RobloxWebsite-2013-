namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides TranslationRolesResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class TranslationRolesResources_ja_jp : TranslationRolesResources_en_us, ITranslationRolesResources, ITranslationResources
{
	/// <summary>
	/// Key: "Description.Modal.DeleteTranslator"
	/// English String: "Are you sure you want to delete this translator?"
	/// </summary>
	public override string DescriptionModalDeleteTranslator => "この翻訳者を削除してよろしいですか？";

	/// <summary>
	/// Key: "Description.TranslatorTooltip"
	/// English String: "Add translators by username or user ID. You can also add a specific role set from a Group you own as translators. Users with translator access will be able to view game content and provide translations."
	/// </summary>
	public override string DescriptionTranslatorTooltip => "翻訳者をユーザーネームまたはユーザーIDで追加してください。翻訳者として所有しているグループから特定の役割セットを追加することもできます。翻訳者アクセス権限のあるユーザーは、ゲームコンテンツを確認して翻訳を提供することができます。";

	/// <summary>
	/// Key: "Heading.Modal.DeleteTranslator"
	/// English String: "Delete Translator"
	/// </summary>
	public override string HeadingModalDeleteTranslator => "翻訳者を削除";

	/// <summary>
	/// Key: "Heading.Translators"
	/// English String: "Translators"
	/// </summary>
	public override string HeadingTranslators => "翻訳者";

	/// <summary>
	/// Key: "Label.AddUser"
	/// English String: "Click to add translator"
	/// </summary>
	public override string LabelAddUser => "クリックして翻訳者を追加";

	/// <summary>
	/// Key: "Label.EnterGroupIdPlaceholder"
	/// English String: "Enter Translator Group ID"
	/// </summary>
	public override string LabelEnterGroupIdPlaceholder => "翻訳者のグループIDを入力してください";

	/// <summary>
	/// Key: "Label.EnterUserIdPlaceholder"
	/// English String: "Enter Translator's UserID"
	/// </summary>
	public override string LabelEnterUserIdPlaceholder => "翻訳者のユーザーIDを入力して下さい。";

	/// <summary>
	/// Key: "Label.EnterUsernamePlaceholder"
	/// English String: "Enter Translator's Username"
	/// </summary>
	public override string LabelEnterUsernamePlaceholder => "翻訳者のユーザーネームを入力して下さい。";

	/// <summary>
	/// Key: "Label.EntireGroup"
	/// English String: "Entire Group"
	/// </summary>
	public override string LabelEntireGroup => "グループ全体";

	/// <summary>
	/// Key: "Label.GroupId"
	/// English String: "Group ID"
	/// </summary>
	public override string LabelGroupId => "グループID";

	/// <summary>
	/// Key: "Label.Groups"
	/// English String: "Groups"
	/// </summary>
	public override string LabelGroups => "グループ";

	/// <summary>
	/// Key: "Label.PrivateGroup"
	/// English String: "Private Group"
	/// </summary>
	public override string LabelPrivateGroup => "プライベートグループ";

	/// <summary>
	/// Key: "Label.PublicGroup"
	/// English String: "Public Group"
	/// </summary>
	public override string LabelPublicGroup => "公開グループ";

	/// <summary>
	/// Key: "Label.RemoveUser"
	/// English String: "Click to remove translator"
	/// </summary>
	public override string LabelRemoveUser => "クリックして翻訳者を削除";

	/// <summary>
	/// Key: "Label.SelectGroupRole"
	/// English String: "Select Group Role"
	/// </summary>
	public override string LabelSelectGroupRole => "グループの役割を選択";

	/// <summary>
	/// Key: "Label.TranslatorsTooltip"
	/// English String: "Users and groups with translator access will be able to view game content and provide translations."
	/// </summary>
	public override string LabelTranslatorsTooltip => "翻訳者アクセス権限のあるユーザーやグループは、ゲームコンテンツを確認して翻訳を提供することができます。";

	/// <summary>
	/// Key: "Label.UserId"
	/// English String: "User ID"
	/// </summary>
	public override string LabelUserId => "ユーザーID";

	/// <summary>
	/// Key: "Label.Username"
	/// English String: "Username"
	/// </summary>
	public override string LabelUsername => "ユーザーネーム";

	/// <summary>
	/// Key: "Label.Users"
	/// English String: "Users"
	/// </summary>
	public override string LabelUsers => "ユーザー";

	/// <summary>
	/// Key: "Message.EnterTranslatorGroupID"
	/// English String: "Please enter Group ID of the group you like to add as translator"
	/// </summary>
	public override string MessageEnterTranslatorGroupID => "翻訳者として追加するグループのグループIDを入力してください";

	/// <summary>
	/// Key: "Message.EnterTranslatorUserId"
	/// English String: "Please enter a translator's User ID"
	/// </summary>
	public override string MessageEnterTranslatorUserId => "翻訳者のユーザーIDを入力してください";

	/// <summary>
	/// Key: "Message.EnterTranslatorUsername"
	/// English String: "Please enter a translator's username"
	/// </summary>
	public override string MessageEnterTranslatorUsername => "翻訳者のユーザーネームを入力して下さい";

	/// <summary>
	/// Key: "Message.GroupAlreadyAdded"
	/// English String: "The group is already added."
	/// </summary>
	public override string MessageGroupAlreadyAdded => "グループはすでに追加されています。";

	/// <summary>
	/// Key: "Message.GroupAlreadyAddedWithRoleset"
	/// English String: "Group with specified role set is already added. "
	/// </summary>
	public override string MessageGroupAlreadyAddedWithRoleset => "指定した役割セットのグループはすでに追加されています。 ";

	/// <summary>
	/// Key: "Message.InvalidGroup"
	/// English String: "Group not found. Please check Group ID entered."
	/// </summary>
	public override string MessageInvalidGroup => "グループが見つかりませんでした。入力したグループIDをチェックしてください。";

	/// <summary>
	/// Key: "Message.RolesServerError"
	/// This error message is shown when we are unable to show information to the user. We ask them to refresh or try again later because our services might be down.
	/// English String: "Unable to retrieve data. Please refresh or try again later."
	/// </summary>
	public override string MessageRolesServerError => "データを取得できません。リフレッシュするか、後でもう一度お試しください。";

	/// <summary>
	/// Key: "Message.UserAlreadyAdded"
	/// English String: "This user is already added"
	/// </summary>
	public override string MessageUserAlreadyAdded => "このユーザーはすでに追加されています";

	/// <summary>
	/// Key: "Message.UserNotFound"
	/// English String: "User not found. Please check Username or User ID entered."
	/// </summary>
	public override string MessageUserNotFound => "ユーザーが見つかりませんでした。入力したユーザーネームまたはユーザーIDをチェックしてください。";

	public TranslationRolesResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForDescriptionModalDeleteTranslator()
	{
		return "この翻訳者を削除してよろしいですか？";
	}

	protected override string _GetTemplateForDescriptionTranslatorTooltip()
	{
		return "翻訳者をユーザーネームまたはユーザーIDで追加してください。翻訳者として所有しているグループから特定の役割セットを追加することもできます。翻訳者アクセス権限のあるユーザーは、ゲームコンテンツを確認して翻訳を提供することができます。";
	}

	protected override string _GetTemplateForHeadingModalDeleteTranslator()
	{
		return "翻訳者を削除";
	}

	protected override string _GetTemplateForHeadingTranslators()
	{
		return "翻訳者";
	}

	protected override string _GetTemplateForLabelAddUser()
	{
		return "クリックして翻訳者を追加";
	}

	protected override string _GetTemplateForLabelEnterGroupIdPlaceholder()
	{
		return "翻訳者のグループIDを入力してください";
	}

	protected override string _GetTemplateForLabelEnterUserIdPlaceholder()
	{
		return "翻訳者のユーザーIDを入力して下さい。";
	}

	protected override string _GetTemplateForLabelEnterUsernamePlaceholder()
	{
		return "翻訳者のユーザーネームを入力して下さい。";
	}

	protected override string _GetTemplateForLabelEntireGroup()
	{
		return "グループ全体";
	}

	protected override string _GetTemplateForLabelGroupId()
	{
		return "グループID";
	}

	protected override string _GetTemplateForLabelGroups()
	{
		return "グループ";
	}

	protected override string _GetTemplateForLabelPrivateGroup()
	{
		return "プライベートグループ";
	}

	protected override string _GetTemplateForLabelPublicGroup()
	{
		return "公開グループ";
	}

	protected override string _GetTemplateForLabelRemoveUser()
	{
		return "クリックして翻訳者を削除";
	}

	/// <summary>
	/// Key: "Label.RolesetName"
	/// English String: "Role: {rolesetName}"
	/// </summary>
	public override string LabelRolesetName(string rolesetName)
	{
		return $"役割: {rolesetName}";
	}

	protected override string _GetTemplateForLabelRolesetName()
	{
		return "役割: {rolesetName}";
	}

	protected override string _GetTemplateForLabelSelectGroupRole()
	{
		return "グループの役割を選択";
	}

	protected override string _GetTemplateForLabelTranslatorsTooltip()
	{
		return "翻訳者アクセス権限のあるユーザーやグループは、ゲームコンテンツを確認して翻訳を提供することができます。";
	}

	protected override string _GetTemplateForLabelUserId()
	{
		return "ユーザーID";
	}

	protected override string _GetTemplateForLabelUsername()
	{
		return "ユーザーネーム";
	}

	protected override string _GetTemplateForLabelUsers()
	{
		return "ユーザー";
	}

	protected override string _GetTemplateForMessageEnterTranslatorGroupID()
	{
		return "翻訳者として追加するグループのグループIDを入力してください";
	}

	protected override string _GetTemplateForMessageEnterTranslatorUserId()
	{
		return "翻訳者のユーザーIDを入力してください";
	}

	protected override string _GetTemplateForMessageEnterTranslatorUsername()
	{
		return "翻訳者のユーザーネームを入力して下さい";
	}

	protected override string _GetTemplateForMessageGroupAlreadyAdded()
	{
		return "グループはすでに追加されています。";
	}

	protected override string _GetTemplateForMessageGroupAlreadyAddedWithRoleset()
	{
		return "指定した役割セットのグループはすでに追加されています。 ";
	}

	protected override string _GetTemplateForMessageInvalidGroup()
	{
		return "グループが見つかりませんでした。入力したグループIDをチェックしてください。";
	}

	protected override string _GetTemplateForMessageRolesServerError()
	{
		return "データを取得できません。リフレッシュするか、後でもう一度お試しください。";
	}

	protected override string _GetTemplateForMessageUserAlreadyAdded()
	{
		return "このユーザーはすでに追加されています";
	}

	protected override string _GetTemplateForMessageUserNotFound()
	{
		return "ユーザーが見つかりませんでした。入力したユーザーネームまたはユーザーIDをチェックしてください。";
	}
}
