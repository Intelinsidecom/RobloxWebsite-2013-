namespace Roblox.Platform.TranslationResources.Feature {
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
	public override string DescriptionModalDeleteTranslator => "ã“ã®ç¿»è¨³è€…ã‚’å‰Šé™¤ã—ã¦ã‚ˆã‚ã—ã„ã§ã™ã‹ï¼Ÿ";

	/// <summary>
	/// Key: "Description.TranslatorTooltip"
	/// English String: "Add translators by username or user ID. You can also add a specific role set from a Group you own as translators. Users with translator access will be able to view game content and provide translations."
	/// </summary>
	public override string DescriptionTranslatorTooltip => "ç¿»è¨³è€…ã‚’ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ ã¾ãŸã¯ãƒ¦ãƒ¼ã‚¶ãƒ¼IDã§è¿½åŠ ã—ã¦ãã ã•ã„ã€‚ç¿»è¨³è€…ã¨ã—ã¦æ‰€æœ‰ã—ã¦ã„ã‚‹ã‚°ãƒ«ãƒ¼ãƒ—ã‹ã‚‰ç‰¹å®šã®å½¹å‰²ã‚»ãƒƒãƒˆã‚’è¿½åŠ ã™ã‚‹ã“ã¨ã‚‚ã§ãã¾ã™ã€‚ç¿»è¨³è€…ã‚¢ã‚¯ã‚»ã‚¹æ¨©é™ã®ã‚ã‚‹ãƒ¦ãƒ¼ã‚¶ãƒ¼ã¯ã€ã‚²ãƒ¼ãƒ ã‚³ãƒ³ãƒ†ãƒ³ãƒ„ã‚’ç¢ºèªã—ã¦ç¿»è¨³ã‚’æä¾›ã™ã‚‹ã“ã¨ãŒã§ãã¾ã™ã€‚";

	/// <summary>
	/// Key: "Heading.Modal.DeleteTranslator"
	/// English String: "Delete Translator"
	/// </summary>
	public override string HeadingModalDeleteTranslator => "ç¿»è¨³è€…ã‚’å‰Šé™¤";

	/// <summary>
	/// Key: "Heading.Translators"
	/// English String: "Translators"
	/// </summary>
	public override string HeadingTranslators => "ç¿»è¨³è€…";

	/// <summary>
	/// Key: "Label.AddUser"
	/// English String: "Click to add translator"
	/// </summary>
	public override string LabelAddUser => "ã‚¯ãƒªãƒƒã‚¯ã—ã¦ç¿»è¨³è€…ã‚’è¿½åŠ ";

	/// <summary>
	/// Key: "Label.EnterGroupIdPlaceholder"
	/// English String: "Enter Translator Group ID"
	/// </summary>
	public override string LabelEnterGroupIdPlaceholder => "ç¿»è¨³è€…ã®ã‚°ãƒ«ãƒ¼ãƒ—IDã‚’å…¥åŠ›ã—ã¦ãã ã•ã„";

	/// <summary>
	/// Key: "Label.EnterUserIdPlaceholder"
	/// English String: "Enter Translator's UserID"
	/// </summary>
	public override string LabelEnterUserIdPlaceholder => "ç¿»è¨³è€…ã®ãƒ¦ãƒ¼ã‚¶ãƒ¼IDã‚’å…¥åŠ›ã—ã¦ä¸‹ã•ã„ã€‚";

	/// <summary>
	/// Key: "Label.EnterUsernamePlaceholder"
	/// English String: "Enter Translator's Username"
	/// </summary>
	public override string LabelEnterUsernamePlaceholder => "ç¿»è¨³è€…ã®ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ ã‚’å…¥åŠ›ã—ã¦ä¸‹ã•ã„ã€‚";

	/// <summary>
	/// Key: "Label.EntireGroup"
	/// English String: "Entire Group"
	/// </summary>
	public override string LabelEntireGroup => "ã‚°ãƒ«ãƒ¼ãƒ—å…¨ä½“";

	/// <summary>
	/// Key: "Label.GroupId"
	/// English String: "Group ID"
	/// </summary>
	public override string LabelGroupId => "ã‚°ãƒ«ãƒ¼ãƒ—ID";

	/// <summary>
	/// Key: "Label.Groups"
	/// English String: "Groups"
	/// </summary>
	public override string LabelGroups => "ã‚°ãƒ«ãƒ¼ãƒ—";

	/// <summary>
	/// Key: "Label.PrivateGroup"
	/// English String: "Private Group"
	/// </summary>
	public override string LabelPrivateGroup => "ãƒ—ãƒ©ã‚¤ãƒ™ãƒ¼ãƒˆã‚°ãƒ«ãƒ¼ãƒ—";

	/// <summary>
	/// Key: "Label.PublicGroup"
	/// English String: "Public Group"
	/// </summary>
	public override string LabelPublicGroup => "å…¬é–‹ã‚°ãƒ«ãƒ¼ãƒ—";

	/// <summary>
	/// Key: "Label.RemoveUser"
	/// English String: "Click to remove translator"
	/// </summary>
	public override string LabelRemoveUser => "ã‚¯ãƒªãƒƒã‚¯ã—ã¦ç¿»è¨³è€…ã‚’å‰Šé™¤";

	/// <summary>
	/// Key: "Label.SelectGroupRole"
	/// English String: "Select Group Role"
	/// </summary>
	public override string LabelSelectGroupRole => "ã‚°ãƒ«ãƒ¼ãƒ—ã®å½¹å‰²ã‚’é¸æŠž";

	/// <summary>
	/// Key: "Label.TranslatorsTooltip"
	/// English String: "Users and groups with translator access will be able to view game content and provide translations."
	/// </summary>
	public override string LabelTranslatorsTooltip => "ç¿»è¨³è€…ã‚¢ã‚¯ã‚»ã‚¹æ¨©é™ã®ã‚ã‚‹ãƒ¦ãƒ¼ã‚¶ãƒ¼ã‚„ã‚°ãƒ«ãƒ¼ãƒ—ã¯ã€ã‚²ãƒ¼ãƒ ã‚³ãƒ³ãƒ†ãƒ³ãƒ„ã‚’ç¢ºèªã—ã¦ç¿»è¨³ã‚’æä¾›ã™ã‚‹ã“ã¨ãŒã§ãã¾ã™ã€‚";

	/// <summary>
	/// Key: "Label.UserId"
	/// English String: "User ID"
	/// </summary>
	public override string LabelUserId => "ãƒ¦ãƒ¼ã‚¶ãƒ¼ID";

	/// <summary>
	/// Key: "Label.Username"
	/// English String: "Username"
	/// </summary>
	public override string LabelUsername => "ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ ";

	/// <summary>
	/// Key: "Label.Users"
	/// English String: "Users"
	/// </summary>
	public override string LabelUsers => "ãƒ¦ãƒ¼ã‚¶ãƒ¼";

	/// <summary>
	/// Key: "Message.EnterTranslatorGroupID"
	/// English String: "Please enter Group ID of the group you like to add as translator"
	/// </summary>
	public override string MessageEnterTranslatorGroupID => "ç¿»è¨³è€…ã¨ã—ã¦è¿½åŠ ã™ã‚‹ã‚°ãƒ«ãƒ¼ãƒ—ã®ã‚°ãƒ«ãƒ¼ãƒ—IDã‚’å…¥åŠ›ã—ã¦ãã ã•ã„";

	/// <summary>
	/// Key: "Message.EnterTranslatorUserId"
	/// English String: "Please enter a translator's User ID"
	/// </summary>
	public override string MessageEnterTranslatorUserId => "ç¿»è¨³è€…ã®ãƒ¦ãƒ¼ã‚¶ãƒ¼IDã‚’å…¥åŠ›ã—ã¦ãã ã•ã„";

	/// <summary>
	/// Key: "Message.EnterTranslatorUsername"
	/// English String: "Please enter a translator's username"
	/// </summary>
	public override string MessageEnterTranslatorUsername => "ç¿»è¨³è€…ã®ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ ã‚’å…¥åŠ›ã—ã¦ä¸‹ã•ã„";

	/// <summary>
	/// Key: "Message.GroupAlreadyAdded"
	/// English String: "The group is already added."
	/// </summary>
	public override string MessageGroupAlreadyAdded => "ã‚°ãƒ«ãƒ¼ãƒ—ã¯ã™ã§ã«è¿½åŠ ã•ã‚Œã¦ã„ã¾ã™ã€‚";

	/// <summary>
	/// Key: "Message.GroupAlreadyAddedWithRoleset"
	/// English String: "Group with specified role set is already added. "
	/// </summary>
	public override string MessageGroupAlreadyAddedWithRoleset => "æŒ‡å®šã—ãŸå½¹å‰²ã‚»ãƒƒãƒˆã®ã‚°ãƒ«ãƒ¼ãƒ—ã¯ã™ã§ã«è¿½åŠ ã•ã‚Œã¦ã„ã¾ã™ã€‚ ";

	/// <summary>
	/// Key: "Message.InvalidGroup"
	/// English String: "Group not found. Please check Group ID entered."
	/// </summary>
	public override string MessageInvalidGroup => "ã‚°ãƒ«ãƒ¼ãƒ—ãŒè¦‹ã¤ã‹ã‚Šã¾ã›ã‚“ã§ã—ãŸã€‚å…¥åŠ›ã—ãŸã‚°ãƒ«ãƒ¼ãƒ—IDã‚’ãƒã‚§ãƒƒã‚¯ã—ã¦ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Message.RolesServerError"
	/// This error message is shown when we are unable to show information to the user. We ask them to refresh or try again later because our services might be down.
	/// English String: "Unable to retrieve data. Please refresh or try again later."
	/// </summary>
	public override string MessageRolesServerError => "ãƒ‡ãƒ¼ã‚¿ã‚’å–å¾—ã§ãã¾ã›ã‚“ã€‚ãƒªãƒ•ãƒ¬ãƒƒã‚·ãƒ¥ã™ã‚‹ã‹ã€å¾Œã§ã‚‚ã†ä¸€åº¦ãŠè©¦ã—ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Message.UserAlreadyAdded"
	/// English String: "This user is already added"
	/// </summary>
	public override string MessageUserAlreadyAdded => "ã“ã®ãƒ¦ãƒ¼ã‚¶ãƒ¼ã¯ã™ã§ã«è¿½åŠ ã•ã‚Œã¦ã„ã¾ã™";

	/// <summary>
	/// Key: "Message.UserNotFound"
	/// English String: "User not found. Please check Username or User ID entered."
	/// </summary>
	public override string MessageUserNotFound => "ãƒ¦ãƒ¼ã‚¶ãƒ¼ãŒè¦‹ã¤ã‹ã‚Šã¾ã›ã‚“ã§ã—ãŸã€‚å…¥åŠ›ã—ãŸãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ ã¾ãŸã¯ãƒ¦ãƒ¼ã‚¶ãƒ¼IDã‚’ãƒã‚§ãƒƒã‚¯ã—ã¦ãã ã•ã„ã€‚";

	public TranslationRolesResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForDescriptionModalDeleteTranslator()
	{
		return "ã“ã®ç¿»è¨³è€…ã‚’å‰Šé™¤ã—ã¦ã‚ˆã‚ã—ã„ã§ã™ã‹ï¼Ÿ";
	}

	protected override string _GetTemplateForDescriptionTranslatorTooltip()
	{
		return "ç¿»è¨³è€…ã‚’ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ ã¾ãŸã¯ãƒ¦ãƒ¼ã‚¶ãƒ¼IDã§è¿½åŠ ã—ã¦ãã ã•ã„ã€‚ç¿»è¨³è€…ã¨ã—ã¦æ‰€æœ‰ã—ã¦ã„ã‚‹ã‚°ãƒ«ãƒ¼ãƒ—ã‹ã‚‰ç‰¹å®šã®å½¹å‰²ã‚»ãƒƒãƒˆã‚’è¿½åŠ ã™ã‚‹ã“ã¨ã‚‚ã§ãã¾ã™ã€‚ç¿»è¨³è€…ã‚¢ã‚¯ã‚»ã‚¹æ¨©é™ã®ã‚ã‚‹ãƒ¦ãƒ¼ã‚¶ãƒ¼ã¯ã€ã‚²ãƒ¼ãƒ ã‚³ãƒ³ãƒ†ãƒ³ãƒ„ã‚’ç¢ºèªã—ã¦ç¿»è¨³ã‚’æä¾›ã™ã‚‹ã“ã¨ãŒã§ãã¾ã™ã€‚";
	}

	protected override string _GetTemplateForHeadingModalDeleteTranslator()
	{
		return "ç¿»è¨³è€…ã‚’å‰Šé™¤";
	}

	protected override string _GetTemplateForHeadingTranslators()
	{
		return "ç¿»è¨³è€…";
	}

	protected override string _GetTemplateForLabelAddUser()
	{
		return "ã‚¯ãƒªãƒƒã‚¯ã—ã¦ç¿»è¨³è€…ã‚’è¿½åŠ ";
	}

	protected override string _GetTemplateForLabelEnterGroupIdPlaceholder()
	{
		return "ç¿»è¨³è€…ã®ã‚°ãƒ«ãƒ¼ãƒ—IDã‚’å…¥åŠ›ã—ã¦ãã ã•ã„";
	}

	protected override string _GetTemplateForLabelEnterUserIdPlaceholder()
	{
		return "ç¿»è¨³è€…ã®ãƒ¦ãƒ¼ã‚¶ãƒ¼IDã‚’å…¥åŠ›ã—ã¦ä¸‹ã•ã„ã€‚";
	}

	protected override string _GetTemplateForLabelEnterUsernamePlaceholder()
	{
		return "ç¿»è¨³è€…ã®ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ ã‚’å…¥åŠ›ã—ã¦ä¸‹ã•ã„ã€‚";
	}

	protected override string _GetTemplateForLabelEntireGroup()
	{
		return "ã‚°ãƒ«ãƒ¼ãƒ—å…¨ä½“";
	}

	protected override string _GetTemplateForLabelGroupId()
	{
		return "ã‚°ãƒ«ãƒ¼ãƒ—ID";
	}

	protected override string _GetTemplateForLabelGroups()
	{
		return "ã‚°ãƒ«ãƒ¼ãƒ—";
	}

	protected override string _GetTemplateForLabelPrivateGroup()
	{
		return "ãƒ—ãƒ©ã‚¤ãƒ™ãƒ¼ãƒˆã‚°ãƒ«ãƒ¼ãƒ—";
	}

	protected override string _GetTemplateForLabelPublicGroup()
	{
		return "å…¬é–‹ã‚°ãƒ«ãƒ¼ãƒ—";
	}

	protected override string _GetTemplateForLabelRemoveUser()
	{
		return "ã‚¯ãƒªãƒƒã‚¯ã—ã¦ç¿»è¨³è€…ã‚’å‰Šé™¤";
	}

	/// <summary>
	/// Key: "Label.RolesetName"
	/// English String: "Role: {rolesetName}"
	/// </summary>
	public override string LabelRolesetName(string rolesetName)
	{
		return $"å½¹å‰²: {rolesetName}";
	}

	protected override string _GetTemplateForLabelRolesetName()
	{
		return "å½¹å‰²: {rolesetName}";
	}

	protected override string _GetTemplateForLabelSelectGroupRole()
	{
		return "ã‚°ãƒ«ãƒ¼ãƒ—ã®å½¹å‰²ã‚’é¸æŠž";
	}

	protected override string _GetTemplateForLabelTranslatorsTooltip()
	{
		return "ç¿»è¨³è€…ã‚¢ã‚¯ã‚»ã‚¹æ¨©é™ã®ã‚ã‚‹ãƒ¦ãƒ¼ã‚¶ãƒ¼ã‚„ã‚°ãƒ«ãƒ¼ãƒ—ã¯ã€ã‚²ãƒ¼ãƒ ã‚³ãƒ³ãƒ†ãƒ³ãƒ„ã‚’ç¢ºèªã—ã¦ç¿»è¨³ã‚’æä¾›ã™ã‚‹ã“ã¨ãŒã§ãã¾ã™ã€‚";
	}

	protected override string _GetTemplateForLabelUserId()
	{
		return "ãƒ¦ãƒ¼ã‚¶ãƒ¼ID";
	}

	protected override string _GetTemplateForLabelUsername()
	{
		return "ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ ";
	}

	protected override string _GetTemplateForLabelUsers()
	{
		return "ãƒ¦ãƒ¼ã‚¶ãƒ¼";
	}

	protected override string _GetTemplateForMessageEnterTranslatorGroupID()
	{
		return "ç¿»è¨³è€…ã¨ã—ã¦è¿½åŠ ã™ã‚‹ã‚°ãƒ«ãƒ¼ãƒ—ã®ã‚°ãƒ«ãƒ¼ãƒ—IDã‚’å…¥åŠ›ã—ã¦ãã ã•ã„";
	}

	protected override string _GetTemplateForMessageEnterTranslatorUserId()
	{
		return "ç¿»è¨³è€…ã®ãƒ¦ãƒ¼ã‚¶ãƒ¼IDã‚’å…¥åŠ›ã—ã¦ãã ã•ã„";
	}

	protected override string _GetTemplateForMessageEnterTranslatorUsername()
	{
		return "ç¿»è¨³è€…ã®ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ ã‚’å…¥åŠ›ã—ã¦ä¸‹ã•ã„";
	}

	protected override string _GetTemplateForMessageGroupAlreadyAdded()
	{
		return "ã‚°ãƒ«ãƒ¼ãƒ—ã¯ã™ã§ã«è¿½åŠ ã•ã‚Œã¦ã„ã¾ã™ã€‚";
	}

	protected override string _GetTemplateForMessageGroupAlreadyAddedWithRoleset()
	{
		return "æŒ‡å®šã—ãŸå½¹å‰²ã‚»ãƒƒãƒˆã®ã‚°ãƒ«ãƒ¼ãƒ—ã¯ã™ã§ã«è¿½åŠ ã•ã‚Œã¦ã„ã¾ã™ã€‚ ";
	}

	protected override string _GetTemplateForMessageInvalidGroup()
	{
		return "ã‚°ãƒ«ãƒ¼ãƒ—ãŒè¦‹ã¤ã‹ã‚Šã¾ã›ã‚“ã§ã—ãŸã€‚å…¥åŠ›ã—ãŸã‚°ãƒ«ãƒ¼ãƒ—IDã‚’ãƒã‚§ãƒƒã‚¯ã—ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForMessageRolesServerError()
	{
		return "ãƒ‡ãƒ¼ã‚¿ã‚’å–å¾—ã§ãã¾ã›ã‚“ã€‚ãƒªãƒ•ãƒ¬ãƒƒã‚·ãƒ¥ã™ã‚‹ã‹ã€å¾Œã§ã‚‚ã†ä¸€åº¦ãŠè©¦ã—ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForMessageUserAlreadyAdded()
	{
		return "ã“ã®ãƒ¦ãƒ¼ã‚¶ãƒ¼ã¯ã™ã§ã«è¿½åŠ ã•ã‚Œã¦ã„ã¾ã™";
	}

	protected override string _GetTemplateForMessageUserNotFound()
	{
		return "ãƒ¦ãƒ¼ã‚¶ãƒ¼ãŒè¦‹ã¤ã‹ã‚Šã¾ã›ã‚“ã§ã—ãŸã€‚å…¥åŠ›ã—ãŸãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ ã¾ãŸã¯ãƒ¦ãƒ¼ã‚¶ãƒ¼IDã‚’ãƒã‚§ãƒƒã‚¯ã—ã¦ãã ã•ã„ã€‚";
	}
}


}
