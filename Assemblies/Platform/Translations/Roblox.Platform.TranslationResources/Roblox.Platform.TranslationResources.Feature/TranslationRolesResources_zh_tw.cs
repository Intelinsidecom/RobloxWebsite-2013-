namespace Roblox.Platform.TranslationResources.Feature {
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
	public override string DescriptionModalDeleteTranslator => "ç¢ºå®šåˆªé™¤æ­¤è­¯è€…ï¼Ÿ";

	/// <summary>
	/// Key: "Description.TranslatorTooltip"
	/// English String: "Add translators by username or user ID. You can also add a specific role set from a Group you own as translators. Users with translator access will be able to view game content and provide translations."
	/// </summary>
	public override string DescriptionTranslatorTooltip => "ä»¥ä½¿ç”¨è€…åç¨±æˆ–ä½¿ç”¨è€… ID æ–°å¢žè­¯è€…ã€‚æ‚¨ä¹Ÿå¯ä»¥å¾žæ‚¨ç®¡ç†çš„ç¾¤çµ„è£¡é¢ç‚ºç‰¹å®šéšŽç´šå•Ÿç”¨è­¯è€…æ¬Šé™ã€‚æ“æœ‰è­¯è€…æ¬Šé™çš„ä½¿ç”¨è€…å°‡å¯ä»¥æª¢è¦–éŠæˆ²å…§å®¹èˆ‡æä¾›ç¿»è­¯ã€‚";

	/// <summary>
	/// Key: "Heading.Modal.DeleteTranslator"
	/// English String: "Delete Translator"
	/// </summary>
	public override string HeadingModalDeleteTranslator => "åˆªé™¤è­¯è€…";

	/// <summary>
	/// Key: "Heading.Translators"
	/// English String: "Translators"
	/// </summary>
	public override string HeadingTranslators => "è­¯è€…";

	/// <summary>
	/// Key: "Label.AddUser"
	/// English String: "Click to add translator"
	/// </summary>
	public override string LabelAddUser => "æŒ‰ä¸‹æ–°å¢žè­¯è€…";

	/// <summary>
	/// Key: "Label.EnterGroupIdPlaceholder"
	/// English String: "Enter Translator Group ID"
	/// </summary>
	public override string LabelEnterGroupIdPlaceholder => "è¼¸å…¥è­¯è€…ç¾¤çµ„ ID";

	/// <summary>
	/// Key: "Label.EnterUserIdPlaceholder"
	/// English String: "Enter Translator's UserID"
	/// </summary>
	public override string LabelEnterUserIdPlaceholder => "è¼¸å…¥è­¯è€…çš„ä½¿ç”¨è€… ID";

	/// <summary>
	/// Key: "Label.EnterUsernamePlaceholder"
	/// English String: "Enter Translator's Username"
	/// </summary>
	public override string LabelEnterUsernamePlaceholder => "è¼¸å…¥è­¯è€…ä½¿ç”¨è€…åç¨±";

	/// <summary>
	/// Key: "Label.EntireGroup"
	/// English String: "Entire Group"
	/// </summary>
	public override string LabelEntireGroup => "æ•´å€‹ç¾¤çµ„";

	/// <summary>
	/// Key: "Label.GroupId"
	/// English String: "Group ID"
	/// </summary>
	public override string LabelGroupId => "ç¾¤çµ„ ID";

	/// <summary>
	/// Key: "Label.Groups"
	/// English String: "Groups"
	/// </summary>
	public override string LabelGroups => "ç¾¤çµ„";

	/// <summary>
	/// Key: "Label.PrivateGroup"
	/// English String: "Private Group"
	/// </summary>
	public override string LabelPrivateGroup => "ç§äººç¾¤çµ„";

	/// <summary>
	/// Key: "Label.PublicGroup"
	/// English String: "Public Group"
	/// </summary>
	public override string LabelPublicGroup => "å…¬é–‹ç¾¤çµ„";

	/// <summary>
	/// Key: "Label.RemoveUser"
	/// English String: "Click to remove translator"
	/// </summary>
	public override string LabelRemoveUser => "æŒ‰ä¸‹ç§»é™¤è­¯è€…";

	/// <summary>
	/// Key: "Label.SelectGroupRole"
	/// English String: "Select Group Role"
	/// </summary>
	public override string LabelSelectGroupRole => "é¸æ“‡ç¾¤çµ„éšŽç´š";

	/// <summary>
	/// Key: "Label.TranslatorsTooltip"
	/// English String: "Users and groups with translator access will be able to view game content and provide translations."
	/// </summary>
	public override string LabelTranslatorsTooltip => "æ“æœ‰è­¯è€…æ¬Šé™çš„ä½¿ç”¨è€…å°‡å¯ä»¥æª¢è¦–éŠæˆ²å…§å®¹èˆ‡æä¾›ç¿»è­¯ã€‚";

	/// <summary>
	/// Key: "Label.UserId"
	/// English String: "User ID"
	/// </summary>
	public override string LabelUserId => "ä½¿ç”¨è€… ID";

	/// <summary>
	/// Key: "Label.Username"
	/// English String: "Username"
	/// </summary>
	public override string LabelUsername => "ä½¿ç”¨è€…åç¨±";

	/// <summary>
	/// Key: "Label.Users"
	/// English String: "Users"
	/// </summary>
	public override string LabelUsers => "ä½¿ç”¨è€…";

	/// <summary>
	/// Key: "Message.EnterTranslatorGroupID"
	/// English String: "Please enter Group ID of the group you like to add as translator"
	/// </summary>
	public override string MessageEnterTranslatorGroupID => "è«‹è¼¸å…¥æ¬²è¨­ç‚ºè­¯è€…çš„ç¾¤çµ„çš„ ID";

	/// <summary>
	/// Key: "Message.EnterTranslatorUserId"
	/// English String: "Please enter a translator's User ID"
	/// </summary>
	public override string MessageEnterTranslatorUserId => "è«‹è¼¸å…¥è­¯è€…ä½¿ç”¨è€… IDã€‚";

	/// <summary>
	/// Key: "Message.EnterTranslatorUsername"
	/// English String: "Please enter a translator's username"
	/// </summary>
	public override string MessageEnterTranslatorUsername => "è«‹è¼¸å…¥è­¯è€…ä½¿ç”¨è€…åç¨±";

	/// <summary>
	/// Key: "Message.GroupAlreadyAdded"
	/// English String: "The group is already added."
	/// </summary>
	public override string MessageGroupAlreadyAdded => "æ­¤ç¾¤çµ„å·²åŠ å…¥ã€‚";

	/// <summary>
	/// Key: "Message.GroupAlreadyAddedWithRoleset"
	/// English String: "Group with specified role set is already added. "
	/// </summary>
	public override string MessageGroupAlreadyAddedWithRoleset => "å·²ç‚ºæ­¤ç¾¤çµ„è¨­å®šæŒ‡å®šæ¬Šé™ã€‚";

	/// <summary>
	/// Key: "Message.InvalidGroup"
	/// English String: "Group not found. Please check Group ID entered."
	/// </summary>
	public override string MessageInvalidGroup => "æ‰¾ä¸åˆ°ç¾¤çµ„ï¼Œè«‹ç¢ºèªç¾¤çµ„ IDã€‚";

	/// <summary>
	/// Key: "Message.RolesServerError"
	/// This error message is shown when we are unable to show information to the user. We ask them to refresh or try again later because our services might be down.
	/// English String: "Unable to retrieve data. Please refresh or try again later."
	/// </summary>
	public override string MessageRolesServerError => "ç„¡æ³•æ“·å–è³‡æ–™ï¼Œè«‹é‡æ–°æ•´ç†æˆ–ç¨å¾Œå†è©¦ã€‚";

	/// <summary>
	/// Key: "Message.UserAlreadyAdded"
	/// English String: "This user is already added"
	/// </summary>
	public override string MessageUserAlreadyAdded => "æ­¤ä½¿ç”¨è€…å·²åŠ å…¥";

	/// <summary>
	/// Key: "Message.UserNotFound"
	/// English String: "User not found. Please check Username or User ID entered."
	/// </summary>
	public override string MessageUserNotFound => "æ‰¾ä¸åˆ°ä½¿ç”¨è€…ï¼Œè«‹æª¢æŸ¥è¼¸å…¥çš„ä½¿ç”¨è€…åç¨±æˆ–ä½¿ç”¨è€… IDã€‚";

	public TranslationRolesResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForDescriptionModalDeleteTranslator()
	{
		return "ç¢ºå®šåˆªé™¤æ­¤è­¯è€…ï¼Ÿ";
	}

	protected override string _GetTemplateForDescriptionTranslatorTooltip()
	{
		return "ä»¥ä½¿ç”¨è€…åç¨±æˆ–ä½¿ç”¨è€… ID æ–°å¢žè­¯è€…ã€‚æ‚¨ä¹Ÿå¯ä»¥å¾žæ‚¨ç®¡ç†çš„ç¾¤çµ„è£¡é¢ç‚ºç‰¹å®šéšŽç´šå•Ÿç”¨è­¯è€…æ¬Šé™ã€‚æ“æœ‰è­¯è€…æ¬Šé™çš„ä½¿ç”¨è€…å°‡å¯ä»¥æª¢è¦–éŠæˆ²å…§å®¹èˆ‡æä¾›ç¿»è­¯ã€‚";
	}

	protected override string _GetTemplateForHeadingModalDeleteTranslator()
	{
		return "åˆªé™¤è­¯è€…";
	}

	protected override string _GetTemplateForHeadingTranslators()
	{
		return "è­¯è€…";
	}

	protected override string _GetTemplateForLabelAddUser()
	{
		return "æŒ‰ä¸‹æ–°å¢žè­¯è€…";
	}

	protected override string _GetTemplateForLabelEnterGroupIdPlaceholder()
	{
		return "è¼¸å…¥è­¯è€…ç¾¤çµ„ ID";
	}

	protected override string _GetTemplateForLabelEnterUserIdPlaceholder()
	{
		return "è¼¸å…¥è­¯è€…çš„ä½¿ç”¨è€… ID";
	}

	protected override string _GetTemplateForLabelEnterUsernamePlaceholder()
	{
		return "è¼¸å…¥è­¯è€…ä½¿ç”¨è€…åç¨±";
	}

	protected override string _GetTemplateForLabelEntireGroup()
	{
		return "æ•´å€‹ç¾¤çµ„";
	}

	protected override string _GetTemplateForLabelGroupId()
	{
		return "ç¾¤çµ„ ID";
	}

	protected override string _GetTemplateForLabelGroups()
	{
		return "ç¾¤çµ„";
	}

	protected override string _GetTemplateForLabelPrivateGroup()
	{
		return "ç§äººç¾¤çµ„";
	}

	protected override string _GetTemplateForLabelPublicGroup()
	{
		return "å…¬é–‹ç¾¤çµ„";
	}

	protected override string _GetTemplateForLabelRemoveUser()
	{
		return "æŒ‰ä¸‹ç§»é™¤è­¯è€…";
	}

	/// <summary>
	/// Key: "Label.RolesetName"
	/// English String: "Role: {rolesetName}"
	/// </summary>
	public override string LabelRolesetName(string rolesetName)
	{
		return $"éšŽç´šï¼š{rolesetName}";
	}

	protected override string _GetTemplateForLabelRolesetName()
	{
		return "éšŽç´šï¼š{rolesetName}";
	}

	protected override string _GetTemplateForLabelSelectGroupRole()
	{
		return "é¸æ“‡ç¾¤çµ„éšŽç´š";
	}

	protected override string _GetTemplateForLabelTranslatorsTooltip()
	{
		return "æ“æœ‰è­¯è€…æ¬Šé™çš„ä½¿ç”¨è€…å°‡å¯ä»¥æª¢è¦–éŠæˆ²å…§å®¹èˆ‡æä¾›ç¿»è­¯ã€‚";
	}

	protected override string _GetTemplateForLabelUserId()
	{
		return "ä½¿ç”¨è€… ID";
	}

	protected override string _GetTemplateForLabelUsername()
	{
		return "ä½¿ç”¨è€…åç¨±";
	}

	protected override string _GetTemplateForLabelUsers()
	{
		return "ä½¿ç”¨è€…";
	}

	protected override string _GetTemplateForMessageEnterTranslatorGroupID()
	{
		return "è«‹è¼¸å…¥æ¬²è¨­ç‚ºè­¯è€…çš„ç¾¤çµ„çš„ ID";
	}

	protected override string _GetTemplateForMessageEnterTranslatorUserId()
	{
		return "è«‹è¼¸å…¥è­¯è€…ä½¿ç”¨è€… IDã€‚";
	}

	protected override string _GetTemplateForMessageEnterTranslatorUsername()
	{
		return "è«‹è¼¸å…¥è­¯è€…ä½¿ç”¨è€…åç¨±";
	}

	protected override string _GetTemplateForMessageGroupAlreadyAdded()
	{
		return "æ­¤ç¾¤çµ„å·²åŠ å…¥ã€‚";
	}

	protected override string _GetTemplateForMessageGroupAlreadyAddedWithRoleset()
	{
		return "å·²ç‚ºæ­¤ç¾¤çµ„è¨­å®šæŒ‡å®šæ¬Šé™ã€‚";
	}

	protected override string _GetTemplateForMessageInvalidGroup()
	{
		return "æ‰¾ä¸åˆ°ç¾¤çµ„ï¼Œè«‹ç¢ºèªç¾¤çµ„ IDã€‚";
	}

	protected override string _GetTemplateForMessageRolesServerError()
	{
		return "ç„¡æ³•æ“·å–è³‡æ–™ï¼Œè«‹é‡æ–°æ•´ç†æˆ–ç¨å¾Œå†è©¦ã€‚";
	}

	protected override string _GetTemplateForMessageUserAlreadyAdded()
	{
		return "æ­¤ä½¿ç”¨è€…å·²åŠ å…¥";
	}

	protected override string _GetTemplateForMessageUserNotFound()
	{
		return "æ‰¾ä¸åˆ°ä½¿ç”¨è€…ï¼Œè«‹æª¢æŸ¥è¼¸å…¥çš„ä½¿ç”¨è€…åç¨±æˆ–ä½¿ç”¨è€… IDã€‚";
	}
}


}
