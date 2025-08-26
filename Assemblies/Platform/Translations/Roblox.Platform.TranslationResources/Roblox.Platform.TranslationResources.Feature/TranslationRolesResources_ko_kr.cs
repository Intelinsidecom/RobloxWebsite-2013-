namespace Roblox.Platform.TranslationResources.Feature {
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
	public override string DescriptionModalDeleteTranslator => "ì •ë§ë¡œ ì´ ë²ˆì—­ê°€ë¥¼ ì‚­ì œí• ê¹Œìš”?";

	/// <summary>
	/// Key: "Description.TranslatorTooltip"
	/// English String: "Add translators by username or user ID. You can also add a specific role set from a Group you own as translators. Users with translator access will be able to view game content and provide translations."
	/// </summary>
	public override string DescriptionTranslatorTooltip => "ì‚¬ìš©ìž ì´ë¦„ì´ë‚˜ IDë¡œ ë²ˆì—­ê°€ë¥¼ ì¶”ê°€í•˜ì„¸ìš”. ì†Œìœ í•˜ê³  ìžˆëŠ” ê·¸ë£¹ì˜ ì—­í• êµ°ì— ë²ˆì—­ê°€ë¥¼ ì¶”ê°€í•  ìˆ˜ë„ ìžˆìŠµë‹ˆë‹¤. ë²ˆì—­ ì ‘ê·¼ ê¶Œí•œì´ ìžˆëŠ” ì‚¬ìš©ìžëŠ” ê²Œìž„ ì½˜í…ì¸ ë¥¼ ë³´ê±°ë‚˜ ë²ˆì—­ì„ í•  ìˆ˜ ìžˆìŠµë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Heading.Modal.DeleteTranslator"
	/// English String: "Delete Translator"
	/// </summary>
	public override string HeadingModalDeleteTranslator => "ë²ˆì—­ê°€ ì‚­ì œ";

	/// <summary>
	/// Key: "Heading.Translators"
	/// English String: "Translators"
	/// </summary>
	public override string HeadingTranslators => "ë²ˆì—­ê°€";

	/// <summary>
	/// Key: "Label.AddUser"
	/// English String: "Click to add translator"
	/// </summary>
	public override string LabelAddUser => "ë²ˆì—­ê°€ë¥¼ ì¶”ê°€í•˜ë ¤ë©´ í´ë¦­í•˜ì„¸ìš”";

	/// <summary>
	/// Key: "Label.EnterGroupIdPlaceholder"
	/// English String: "Enter Translator Group ID"
	/// </summary>
	public override string LabelEnterGroupIdPlaceholder => "ë²ˆì—­ê°€ ê·¸ë£¹ ID ìž…ë ¥";

	/// <summary>
	/// Key: "Label.EnterUserIdPlaceholder"
	/// English String: "Enter Translator's UserID"
	/// </summary>
	public override string LabelEnterUserIdPlaceholder => "ë²ˆì—­ê°€ì˜ ì‚¬ìš©ìž ID ìž…ë ¥";

	/// <summary>
	/// Key: "Label.EnterUsernamePlaceholder"
	/// English String: "Enter Translator's Username"
	/// </summary>
	public override string LabelEnterUsernamePlaceholder => "ë²ˆì—­ê°€ì˜ ì‚¬ìš©ìž ì´ë¦„ì„ ìž…ë ¥í•˜ì„¸ìš”";

	/// <summary>
	/// Key: "Label.EntireGroup"
	/// English String: "Entire Group"
	/// </summary>
	public override string LabelEntireGroup => "ê·¸ë£¹ ì „ì²´";

	/// <summary>
	/// Key: "Label.GroupId"
	/// English String: "Group ID"
	/// </summary>
	public override string LabelGroupId => "ê·¸ë£¹ ID";

	/// <summary>
	/// Key: "Label.Groups"
	/// English String: "Groups"
	/// </summary>
	public override string LabelGroups => "ê·¸ë£¹";

	/// <summary>
	/// Key: "Label.PrivateGroup"
	/// English String: "Private Group"
	/// </summary>
	public override string LabelPrivateGroup => "ë¹„ê³µê°œ ê·¸ë£¹";

	/// <summary>
	/// Key: "Label.PublicGroup"
	/// English String: "Public Group"
	/// </summary>
	public override string LabelPublicGroup => "ê³µê°œ ê·¸ë£¹";

	/// <summary>
	/// Key: "Label.RemoveUser"
	/// English String: "Click to remove translator"
	/// </summary>
	public override string LabelRemoveUser => "ë²ˆì—­ê°€ë¥¼ ì‚­ì œí•˜ë ¤ë©´ í´ë¦­í•˜ì„¸ìš”";

	/// <summary>
	/// Key: "Label.SelectGroupRole"
	/// English String: "Select Group Role"
	/// </summary>
	public override string LabelSelectGroupRole => "ê·¸ë£¹ ì—­í•  ì„ íƒ";

	/// <summary>
	/// Key: "Label.TranslatorsTooltip"
	/// English String: "Users and groups with translator access will be able to view game content and provide translations."
	/// </summary>
	public override string LabelTranslatorsTooltip => "ë²ˆì—­ ì ‘ê·¼ ê¶Œí•œì´ ìžˆëŠ” ì‚¬ìš©ìžì™€ ê·¸ë£¹ì€ ê²Œìž„ ì½˜í…ì¸ ë¥¼ ë³´ê±°ë‚˜ ë²ˆì—­ì„ í•  ìˆ˜ ìžˆìŠµë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Label.UserId"
	/// English String: "User ID"
	/// </summary>
	public override string LabelUserId => "ì‚¬ìš©ìž ID";

	/// <summary>
	/// Key: "Label.Username"
	/// English String: "Username"
	/// </summary>
	public override string LabelUsername => "ì‚¬ìš©ìž ì´ë¦„";

	/// <summary>
	/// Key: "Label.Users"
	/// English String: "Users"
	/// </summary>
	public override string LabelUsers => "ì‚¬ìš©ìž";

	/// <summary>
	/// Key: "Message.EnterTranslatorGroupID"
	/// English String: "Please enter Group ID of the group you like to add as translator"
	/// </summary>
	public override string MessageEnterTranslatorGroupID => "ë²ˆì—­ê°€ë¡œ ì¶”ê°€í•  ê·¸ë£¹ì˜ ê·¸ë£¹ IDë¥¼ ìž…ë ¥í•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "Message.EnterTranslatorUserId"
	/// English String: "Please enter a translator's User ID"
	/// </summary>
	public override string MessageEnterTranslatorUserId => "ë²ˆì—­ê°€ì˜ ì‚¬ìš©ìž IDë¥¼ ìž…ë ¥í•˜ì„¸ìš”";

	/// <summary>
	/// Key: "Message.EnterTranslatorUsername"
	/// English String: "Please enter a translator's username"
	/// </summary>
	public override string MessageEnterTranslatorUsername => "ë²ˆì—­ê°€ì˜ ì‚¬ìš©ìž ì´ë¦„ì„ ìž…ë ¥í•˜ì„¸ìš”";

	/// <summary>
	/// Key: "Message.GroupAlreadyAdded"
	/// English String: "The group is already added."
	/// </summary>
	public override string MessageGroupAlreadyAdded => "ì´ë¯¸ ì¶”ê°€ëœ ê·¸ë£¹ì´ì—ìš”.";

	/// <summary>
	/// Key: "Message.GroupAlreadyAddedWithRoleset"
	/// English String: "Group with specified role set is already added. "
	/// </summary>
	public override string MessageGroupAlreadyAddedWithRoleset => "ì´ ì—­í• êµ°ì˜ ê·¸ë£¹ì´ ì´ë¯¸ ì¶”ê°€ë˜ì—ˆì–´ìš”. ";

	/// <summary>
	/// Key: "Message.InvalidGroup"
	/// English String: "Group not found. Please check Group ID entered."
	/// </summary>
	public override string MessageInvalidGroup => "ê·¸ë£¹ì„ ì°¾ì„ ìˆ˜ ì—†ìŠµë‹ˆë‹¤. ìž…ë ¥í•œ ê·¸ë£¹ IDë¥¼ í™•ì¸í•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "Message.RolesServerError"
	/// This error message is shown when we are unable to show information to the user. We ask them to refresh or try again later because our services might be down.
	/// English String: "Unable to retrieve data. Please refresh or try again later."
	/// </summary>
	public override string MessageRolesServerError => "ë°ì´í„° ê²€ìƒ‰ ë¶ˆê°€. ìƒˆë¡œ ê³ ì¹¨ì„ í•˜ê±°ë‚˜ ë‚˜ì¤‘ì— ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "Message.UserAlreadyAdded"
	/// English String: "This user is already added"
	/// </summary>
	public override string MessageUserAlreadyAdded => "ë³¸ ì‚¬ìš©ìžëŠ” ì´ë¯¸ ì¶”ê°€ë˜ì—ˆìŠµë‹ˆë‹¤";

	/// <summary>
	/// Key: "Message.UserNotFound"
	/// English String: "User not found. Please check Username or User ID entered."
	/// </summary>
	public override string MessageUserNotFound => "ì‚¬ìš©ìžë¥¼ ì°¾ì„ ìˆ˜ ì—†ìŠµë‹ˆë‹¤. ìž…ë ¥í•œ ì‚¬ìš©ìž ì´ë¦„ì´ë‚˜ IDë¥¼ í™•ì¸í•˜ì„¸ìš”.";

	public TranslationRolesResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForDescriptionModalDeleteTranslator()
	{
		return "ì •ë§ë¡œ ì´ ë²ˆì—­ê°€ë¥¼ ì‚­ì œí• ê¹Œìš”?";
	}

	protected override string _GetTemplateForDescriptionTranslatorTooltip()
	{
		return "ì‚¬ìš©ìž ì´ë¦„ì´ë‚˜ IDë¡œ ë²ˆì—­ê°€ë¥¼ ì¶”ê°€í•˜ì„¸ìš”. ì†Œìœ í•˜ê³  ìžˆëŠ” ê·¸ë£¹ì˜ ì—­í• êµ°ì— ë²ˆì—­ê°€ë¥¼ ì¶”ê°€í•  ìˆ˜ë„ ìžˆìŠµë‹ˆë‹¤. ë²ˆì—­ ì ‘ê·¼ ê¶Œí•œì´ ìžˆëŠ” ì‚¬ìš©ìžëŠ” ê²Œìž„ ì½˜í…ì¸ ë¥¼ ë³´ê±°ë‚˜ ë²ˆì—­ì„ í•  ìˆ˜ ìžˆìŠµë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForHeadingModalDeleteTranslator()
	{
		return "ë²ˆì—­ê°€ ì‚­ì œ";
	}

	protected override string _GetTemplateForHeadingTranslators()
	{
		return "ë²ˆì—­ê°€";
	}

	protected override string _GetTemplateForLabelAddUser()
	{
		return "ë²ˆì—­ê°€ë¥¼ ì¶”ê°€í•˜ë ¤ë©´ í´ë¦­í•˜ì„¸ìš”";
	}

	protected override string _GetTemplateForLabelEnterGroupIdPlaceholder()
	{
		return "ë²ˆì—­ê°€ ê·¸ë£¹ ID ìž…ë ¥";
	}

	protected override string _GetTemplateForLabelEnterUserIdPlaceholder()
	{
		return "ë²ˆì—­ê°€ì˜ ì‚¬ìš©ìž ID ìž…ë ¥";
	}

	protected override string _GetTemplateForLabelEnterUsernamePlaceholder()
	{
		return "ë²ˆì—­ê°€ì˜ ì‚¬ìš©ìž ì´ë¦„ì„ ìž…ë ¥í•˜ì„¸ìš”";
	}

	protected override string _GetTemplateForLabelEntireGroup()
	{
		return "ê·¸ë£¹ ì „ì²´";
	}

	protected override string _GetTemplateForLabelGroupId()
	{
		return "ê·¸ë£¹ ID";
	}

	protected override string _GetTemplateForLabelGroups()
	{
		return "ê·¸ë£¹";
	}

	protected override string _GetTemplateForLabelPrivateGroup()
	{
		return "ë¹„ê³µê°œ ê·¸ë£¹";
	}

	protected override string _GetTemplateForLabelPublicGroup()
	{
		return "ê³µê°œ ê·¸ë£¹";
	}

	protected override string _GetTemplateForLabelRemoveUser()
	{
		return "ë²ˆì—­ê°€ë¥¼ ì‚­ì œí•˜ë ¤ë©´ í´ë¦­í•˜ì„¸ìš”";
	}

	/// <summary>
	/// Key: "Label.RolesetName"
	/// English String: "Role: {rolesetName}"
	/// </summary>
	public override string LabelRolesetName(string rolesetName)
	{
		return $"ì—­í• : {rolesetName}";
	}

	protected override string _GetTemplateForLabelRolesetName()
	{
		return "ì—­í• : {rolesetName}";
	}

	protected override string _GetTemplateForLabelSelectGroupRole()
	{
		return "ê·¸ë£¹ ì—­í•  ì„ íƒ";
	}

	protected override string _GetTemplateForLabelTranslatorsTooltip()
	{
		return "ë²ˆì—­ ì ‘ê·¼ ê¶Œí•œì´ ìžˆëŠ” ì‚¬ìš©ìžì™€ ê·¸ë£¹ì€ ê²Œìž„ ì½˜í…ì¸ ë¥¼ ë³´ê±°ë‚˜ ë²ˆì—­ì„ í•  ìˆ˜ ìžˆìŠµë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForLabelUserId()
	{
		return "ì‚¬ìš©ìž ID";
	}

	protected override string _GetTemplateForLabelUsername()
	{
		return "ì‚¬ìš©ìž ì´ë¦„";
	}

	protected override string _GetTemplateForLabelUsers()
	{
		return "ì‚¬ìš©ìž";
	}

	protected override string _GetTemplateForMessageEnterTranslatorGroupID()
	{
		return "ë²ˆì—­ê°€ë¡œ ì¶”ê°€í•  ê·¸ë£¹ì˜ ê·¸ë£¹ IDë¥¼ ìž…ë ¥í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForMessageEnterTranslatorUserId()
	{
		return "ë²ˆì—­ê°€ì˜ ì‚¬ìš©ìž IDë¥¼ ìž…ë ¥í•˜ì„¸ìš”";
	}

	protected override string _GetTemplateForMessageEnterTranslatorUsername()
	{
		return "ë²ˆì—­ê°€ì˜ ì‚¬ìš©ìž ì´ë¦„ì„ ìž…ë ¥í•˜ì„¸ìš”";
	}

	protected override string _GetTemplateForMessageGroupAlreadyAdded()
	{
		return "ì´ë¯¸ ì¶”ê°€ëœ ê·¸ë£¹ì´ì—ìš”.";
	}

	protected override string _GetTemplateForMessageGroupAlreadyAddedWithRoleset()
	{
		return "ì´ ì—­í• êµ°ì˜ ê·¸ë£¹ì´ ì´ë¯¸ ì¶”ê°€ë˜ì—ˆì–´ìš”. ";
	}

	protected override string _GetTemplateForMessageInvalidGroup()
	{
		return "ê·¸ë£¹ì„ ì°¾ì„ ìˆ˜ ì—†ìŠµë‹ˆë‹¤. ìž…ë ¥í•œ ê·¸ë£¹ IDë¥¼ í™•ì¸í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForMessageRolesServerError()
	{
		return "ë°ì´í„° ê²€ìƒ‰ ë¶ˆê°€. ìƒˆë¡œ ê³ ì¹¨ì„ í•˜ê±°ë‚˜ ë‚˜ì¤‘ì— ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForMessageUserAlreadyAdded()
	{
		return "ë³¸ ì‚¬ìš©ìžëŠ” ì´ë¯¸ ì¶”ê°€ë˜ì—ˆìŠµë‹ˆë‹¤";
	}

	protected override string _GetTemplateForMessageUserNotFound()
	{
		return "ì‚¬ìš©ìžë¥¼ ì°¾ì„ ìˆ˜ ì—†ìŠµë‹ˆë‹¤. ìž…ë ¥í•œ ì‚¬ìš©ìž ì´ë¦„ì´ë‚˜ IDë¥¼ í™•ì¸í•˜ì„¸ìš”.";
	}
}


}
