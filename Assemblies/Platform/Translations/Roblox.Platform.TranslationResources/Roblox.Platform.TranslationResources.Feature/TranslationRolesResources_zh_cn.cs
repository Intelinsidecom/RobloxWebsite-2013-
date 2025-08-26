namespace Roblox.Platform.TranslationResources.Feature {
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
	public override string DescriptionModalDeleteTranslator => "æ˜¯å¦ç¡®å®šåˆ é™¤æ­¤è¯‘è€…ï¼Ÿ";

	/// <summary>
	/// Key: "Description.TranslatorTooltip"
	/// English String: "Add translators by username or user ID. You can also add a specific role set from a Group you own as translators. Users with translator access will be able to view game content and provide translations."
	/// </summary>
	public override string DescriptionTranslatorTooltip => "ä½¿ç”¨ç”¨æˆ·åæˆ–ç”¨æˆ· ID æ·»åŠ è¯‘è€…ã€‚ä½ ä¹Ÿå¯ä»¥ä»Žä½ ç®¡ç†çš„ç¾¤ç»„ä¸­ä¸ºç‰¹å®šç­‰çº§æ·»åŠ è¯‘è€…æƒé™ã€‚æ‹¥æœ‰è¯‘è€…æƒé™çš„ç”¨æˆ·å°†å¯ä»¥æŸ¥çœ‹æ¸¸æˆå†…å®¹å¹¶æä¾›ç¿»è¯‘ã€‚";

	/// <summary>
	/// Key: "Heading.Modal.DeleteTranslator"
	/// English String: "Delete Translator"
	/// </summary>
	public override string HeadingModalDeleteTranslator => "åˆ é™¤è¯‘è€…";

	/// <summary>
	/// Key: "Heading.Translators"
	/// English String: "Translators"
	/// </summary>
	public override string HeadingTranslators => "è¯‘è€…";

	/// <summary>
	/// Key: "Label.AddUser"
	/// English String: "Click to add translator"
	/// </summary>
	public override string LabelAddUser => "ç‚¹æŒ‰ä»¥æ·»åŠ è¯‘è€…";

	/// <summary>
	/// Key: "Label.EnterGroupIdPlaceholder"
	/// English String: "Enter Translator Group ID"
	/// </summary>
	public override string LabelEnterGroupIdPlaceholder => "è¾“å…¥è¯‘è€…ç¾¤ç»„ ID";

	/// <summary>
	/// Key: "Label.EnterUserIdPlaceholder"
	/// English String: "Enter Translator's UserID"
	/// </summary>
	public override string LabelEnterUserIdPlaceholder => "è¾“å…¥è¯‘è€…çš„ç”¨æˆ· ID";

	/// <summary>
	/// Key: "Label.EnterUsernamePlaceholder"
	/// English String: "Enter Translator's Username"
	/// </summary>
	public override string LabelEnterUsernamePlaceholder => "è¾“å…¥è¯‘è€…çš„ç”¨æˆ·å";

	/// <summary>
	/// Key: "Label.EntireGroup"
	/// English String: "Entire Group"
	/// </summary>
	public override string LabelEntireGroup => "æ•´ä¸ªç¾¤ç»„";

	/// <summary>
	/// Key: "Label.GroupId"
	/// English String: "Group ID"
	/// </summary>
	public override string LabelGroupId => "ç¾¤ç»„ ID";

	/// <summary>
	/// Key: "Label.Groups"
	/// English String: "Groups"
	/// </summary>
	public override string LabelGroups => "ç¾¤ç»„";

	/// <summary>
	/// Key: "Label.PrivateGroup"
	/// English String: "Private Group"
	/// </summary>
	public override string LabelPrivateGroup => "ç§å¯†ç¾¤ç»„";

	/// <summary>
	/// Key: "Label.PublicGroup"
	/// English String: "Public Group"
	/// </summary>
	public override string LabelPublicGroup => "å…¬å¼€ç¾¤ç»„";

	/// <summary>
	/// Key: "Label.RemoveUser"
	/// English String: "Click to remove translator"
	/// </summary>
	public override string LabelRemoveUser => "ç‚¹æŒ‰ä»¥ç§»é™¤è¯‘è€…";

	/// <summary>
	/// Key: "Label.SelectGroupRole"
	/// English String: "Select Group Role"
	/// </summary>
	public override string LabelSelectGroupRole => "é€‰æ‹©ç¾¤ç»„è§’è‰²";

	/// <summary>
	/// Key: "Label.TranslatorsTooltip"
	/// English String: "Users and groups with translator access will be able to view game content and provide translations."
	/// </summary>
	public override string LabelTranslatorsTooltip => "æ‹¥æœ‰è¯‘è€…æƒé™çš„ç”¨æˆ·å°†å¯ä»¥æŸ¥çœ‹æ¸¸æˆå†…å®¹å¹¶æä¾›ç¿»è¯‘ã€‚";

	/// <summary>
	/// Key: "Label.UserId"
	/// English String: "User ID"
	/// </summary>
	public override string LabelUserId => "ç”¨æˆ· ID";

	/// <summary>
	/// Key: "Label.Username"
	/// English String: "Username"
	/// </summary>
	public override string LabelUsername => "ç”¨æˆ·å";

	/// <summary>
	/// Key: "Label.Users"
	/// English String: "Users"
	/// </summary>
	public override string LabelUsers => "ç”¨æˆ·";

	/// <summary>
	/// Key: "Message.EnterTranslatorGroupID"
	/// English String: "Please enter Group ID of the group you like to add as translator"
	/// </summary>
	public override string MessageEnterTranslatorGroupID => "è¯·ä¸ºä½ æƒ³è¦æ·»åŠ ä¸ºè¯‘è€…çš„ç¾¤ç»„è¾“å…¥ç¾¤ç»„ IDã€‚";

	/// <summary>
	/// Key: "Message.EnterTranslatorUserId"
	/// English String: "Please enter a translator's User ID"
	/// </summary>
	public override string MessageEnterTranslatorUserId => "è¯·è¾“å…¥è¯‘è€…çš„ç”¨æˆ· ID";

	/// <summary>
	/// Key: "Message.EnterTranslatorUsername"
	/// English String: "Please enter a translator's username"
	/// </summary>
	public override string MessageEnterTranslatorUsername => "è¯·è¾“å…¥è¯‘è€…çš„ç”¨æˆ·å";

	/// <summary>
	/// Key: "Message.GroupAlreadyAdded"
	/// English String: "The group is already added."
	/// </summary>
	public override string MessageGroupAlreadyAdded => "å·²æ·»åŠ æ­¤ç¾¤ç»„ã€‚";

	/// <summary>
	/// Key: "Message.GroupAlreadyAddedWithRoleset"
	/// English String: "Group with specified role set is already added. "
	/// </summary>
	public override string MessageGroupAlreadyAddedWithRoleset => "å·²ä¸ºæ­¤ç¾¤ç»„è®¾å®šæŒ‡å®šæƒé™ã€‚ ";

	/// <summary>
	/// Key: "Message.InvalidGroup"
	/// English String: "Group not found. Please check Group ID entered."
	/// </summary>
	public override string MessageInvalidGroup => "æ‰¾ä¸åˆ°ç¾¤ç»„ã€‚è¯·æ£€æŸ¥å·²è¾“å…¥çš„ç¾¤ç»„ IDã€‚";

	/// <summary>
	/// Key: "Message.RolesServerError"
	/// This error message is shown when we are unable to show information to the user. We ask them to refresh or try again later because our services might be down.
	/// English String: "Unable to retrieve data. Please refresh or try again later."
	/// </summary>
	public override string MessageRolesServerError => "æ— æ³•èŽ·å–æ•°æ®ã€‚è¯·åˆ·æ–°æˆ–ç¨åŽé‡è¯•ã€‚";

	/// <summary>
	/// Key: "Message.UserAlreadyAdded"
	/// English String: "This user is already added"
	/// </summary>
	public override string MessageUserAlreadyAdded => "å·²æ·»åŠ æ­¤ç”¨æˆ·";

	/// <summary>
	/// Key: "Message.UserNotFound"
	/// English String: "User not found. Please check Username or User ID entered."
	/// </summary>
	public override string MessageUserNotFound => "æ‰¾ä¸åˆ°ç”¨æˆ·ã€‚è¯·æ£€æŸ¥è¾“å…¥çš„ç”¨æˆ·åæˆ–ç”¨æˆ· IDã€‚";

	public TranslationRolesResources_zh_cn(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForDescriptionModalDeleteTranslator()
	{
		return "æ˜¯å¦ç¡®å®šåˆ é™¤æ­¤è¯‘è€…ï¼Ÿ";
	}

	protected override string _GetTemplateForDescriptionTranslatorTooltip()
	{
		return "ä½¿ç”¨ç”¨æˆ·åæˆ–ç”¨æˆ· ID æ·»åŠ è¯‘è€…ã€‚ä½ ä¹Ÿå¯ä»¥ä»Žä½ ç®¡ç†çš„ç¾¤ç»„ä¸­ä¸ºç‰¹å®šç­‰çº§æ·»åŠ è¯‘è€…æƒé™ã€‚æ‹¥æœ‰è¯‘è€…æƒé™çš„ç”¨æˆ·å°†å¯ä»¥æŸ¥çœ‹æ¸¸æˆå†…å®¹å¹¶æä¾›ç¿»è¯‘ã€‚";
	}

	protected override string _GetTemplateForHeadingModalDeleteTranslator()
	{
		return "åˆ é™¤è¯‘è€…";
	}

	protected override string _GetTemplateForHeadingTranslators()
	{
		return "è¯‘è€…";
	}

	protected override string _GetTemplateForLabelAddUser()
	{
		return "ç‚¹æŒ‰ä»¥æ·»åŠ è¯‘è€…";
	}

	protected override string _GetTemplateForLabelEnterGroupIdPlaceholder()
	{
		return "è¾“å…¥è¯‘è€…ç¾¤ç»„ ID";
	}

	protected override string _GetTemplateForLabelEnterUserIdPlaceholder()
	{
		return "è¾“å…¥è¯‘è€…çš„ç”¨æˆ· ID";
	}

	protected override string _GetTemplateForLabelEnterUsernamePlaceholder()
	{
		return "è¾“å…¥è¯‘è€…çš„ç”¨æˆ·å";
	}

	protected override string _GetTemplateForLabelEntireGroup()
	{
		return "æ•´ä¸ªç¾¤ç»„";
	}

	protected override string _GetTemplateForLabelGroupId()
	{
		return "ç¾¤ç»„ ID";
	}

	protected override string _GetTemplateForLabelGroups()
	{
		return "ç¾¤ç»„";
	}

	protected override string _GetTemplateForLabelPrivateGroup()
	{
		return "ç§å¯†ç¾¤ç»„";
	}

	protected override string _GetTemplateForLabelPublicGroup()
	{
		return "å…¬å¼€ç¾¤ç»„";
	}

	protected override string _GetTemplateForLabelRemoveUser()
	{
		return "ç‚¹æŒ‰ä»¥ç§»é™¤è¯‘è€…";
	}

	/// <summary>
	/// Key: "Label.RolesetName"
	/// English String: "Role: {rolesetName}"
	/// </summary>
	public override string LabelRolesetName(string rolesetName)
	{
		return $"æƒé™ï¼š{rolesetName}";
	}

	protected override string _GetTemplateForLabelRolesetName()
	{
		return "æƒé™ï¼š{rolesetName}";
	}

	protected override string _GetTemplateForLabelSelectGroupRole()
	{
		return "é€‰æ‹©ç¾¤ç»„è§’è‰²";
	}

	protected override string _GetTemplateForLabelTranslatorsTooltip()
	{
		return "æ‹¥æœ‰è¯‘è€…æƒé™çš„ç”¨æˆ·å°†å¯ä»¥æŸ¥çœ‹æ¸¸æˆå†…å®¹å¹¶æä¾›ç¿»è¯‘ã€‚";
	}

	protected override string _GetTemplateForLabelUserId()
	{
		return "ç”¨æˆ· ID";
	}

	protected override string _GetTemplateForLabelUsername()
	{
		return "ç”¨æˆ·å";
	}

	protected override string _GetTemplateForLabelUsers()
	{
		return "ç”¨æˆ·";
	}

	protected override string _GetTemplateForMessageEnterTranslatorGroupID()
	{
		return "è¯·ä¸ºä½ æƒ³è¦æ·»åŠ ä¸ºè¯‘è€…çš„ç¾¤ç»„è¾“å…¥ç¾¤ç»„ IDã€‚";
	}

	protected override string _GetTemplateForMessageEnterTranslatorUserId()
	{
		return "è¯·è¾“å…¥è¯‘è€…çš„ç”¨æˆ· ID";
	}

	protected override string _GetTemplateForMessageEnterTranslatorUsername()
	{
		return "è¯·è¾“å…¥è¯‘è€…çš„ç”¨æˆ·å";
	}

	protected override string _GetTemplateForMessageGroupAlreadyAdded()
	{
		return "å·²æ·»åŠ æ­¤ç¾¤ç»„ã€‚";
	}

	protected override string _GetTemplateForMessageGroupAlreadyAddedWithRoleset()
	{
		return "å·²ä¸ºæ­¤ç¾¤ç»„è®¾å®šæŒ‡å®šæƒé™ã€‚ ";
	}

	protected override string _GetTemplateForMessageInvalidGroup()
	{
		return "æ‰¾ä¸åˆ°ç¾¤ç»„ã€‚è¯·æ£€æŸ¥å·²è¾“å…¥çš„ç¾¤ç»„ IDã€‚";
	}

	protected override string _GetTemplateForMessageRolesServerError()
	{
		return "æ— æ³•èŽ·å–æ•°æ®ã€‚è¯·åˆ·æ–°æˆ–ç¨åŽé‡è¯•ã€‚";
	}

	protected override string _GetTemplateForMessageUserAlreadyAdded()
	{
		return "å·²æ·»åŠ æ­¤ç”¨æˆ·";
	}

	protected override string _GetTemplateForMessageUserNotFound()
	{
		return "æ‰¾ä¸åˆ°ç”¨æˆ·ã€‚è¯·æ£€æŸ¥è¾“å…¥çš„ç”¨æˆ·åæˆ–ç”¨æˆ· IDã€‚";
	}
}


}
